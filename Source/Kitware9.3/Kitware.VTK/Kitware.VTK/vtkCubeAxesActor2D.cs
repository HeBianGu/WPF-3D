using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCubeAxesActor2D
	/// </summary>
	/// <remarks>
	///    create a 2D plot of a bounding box edges - used for navigation
	///
	/// vtkCubeAxesActor2D is a composite actor that draws three axes of the
	/// bounding box of an input dataset. The axes include labels and titles
	/// for the x-y-z axes. The algorithm selects the axes that are on the
	/// "exterior" of the bounding box, exterior as determined from examining
	/// outer edges of the bounding box in projection (display) space. Alternatively,
	/// the edges closest to the viewer (i.e., camera position) can be drawn.
	///
	/// To use this object you must define a bounding box and the camera used
	/// to render the vtkCubeAxesActor2D. The camera is used to control the
	/// scaling and position of the vtkCubeAxesActor2D so that it fits in the
	/// viewport and always remains visible.)
	///
	/// The font property of the axes titles and labels can be modified through the
	/// AxisTitleTextProperty and AxisLabelTextProperty attributes. You may also
	/// use the GetXAxisActor2D, GetYAxisActor2D or GetZAxisActor2D methods
	/// to access each individual axis actor to modify their font properties.
	///
	/// The bounding box to use is defined in one of three ways. First, if the Input
	/// ivar is defined, then the input dataset's bounds is used. If the Input is
	/// not defined, and the Prop (superclass of all actors) is defined, then the
	/// Prop's bounds is used. If neither the Input or Prop is defined, then the
	/// Bounds instance variable (an array of six doubles) is used.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor2D vtkAxisActor2D vtkXYPlotActor vtkTextProperty
	/// </seealso>
	// Token: 0x020003C8 RID: 968
	public class vtkCubeAxesActor2D : vtkActor2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600B40A RID: 46090 RVA: 0x000FDDB6 File Offset: 0x000FBFB6
		static vtkCubeAxesActor2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCubeAxesActor2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCubeAxesActor2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600B40B RID: 46091 RVA: 0x000FDDDE File Offset: 0x000FBFDE
		public vtkCubeAxesActor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600B40C RID: 46092
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with bold, italic, and shadow enabled; font family
		/// set to Arial; and label format "6.3g". The number of labels per axis
		/// is set to 3.
		/// </summary>
		// Token: 0x0600B40D RID: 46093 RVA: 0x000FDDEC File Offset: 0x000FBFEC
		public new static vtkCubeAxesActor2D New()
		{
			vtkCubeAxesActor2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCubeAxesActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object with bold, italic, and shadow enabled; font family
		/// set to Arial; and label format "6.3g". The number of labels per axis
		/// is set to 3.
		/// </summary>
		// Token: 0x0600B40E RID: 46094 RVA: 0x000FDE40 File Offset: 0x000FC040
		public vtkCubeAxesActor2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCubeAxesActor2D.vtkCubeAxesActor2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600B40F RID: 46095 RVA: 0x000FDE84 File Offset: 0x000FC084
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600B410 RID: 46096
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor2D_GetAxisLabelTextProperty_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the labels text property of all axes. Note that each axis can
		/// be controlled individually through the GetX/Y/ZAxisActor2D() methods.
		/// </summary>
		// Token: 0x0600B411 RID: 46097 RVA: 0x000FDE90 File Offset: 0x000FC090
		public virtual vtkTextProperty GetAxisLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetAxisLabelTextProperty_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600B412 RID: 46098
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor2D_GetAxisTitleTextProperty_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the title text property of all axes. Note that each axis can
		/// be controlled individually through the GetX/Y/ZAxisActor2D() methods.
		/// </summary>
		// Token: 0x0600B413 RID: 46099 RVA: 0x000FDF00 File Offset: 0x000FC100
		public virtual vtkTextProperty GetAxisTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetAxisTitleTextProperty_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600B414 RID: 46100
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor2D_GetBounds_03(HandleRef pThis);

		/// <summary>
		/// Explicitly specify the region in space around which to draw the bounds.
		/// The bounds is used only when no Input or Prop is specified. The bounds
		/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
		/// sure that the min's are less than the max's.
		/// </summary>
		// Token: 0x0600B415 RID: 46101 RVA: 0x000FDF70 File Offset: 0x000FC170
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B416 RID: 46102
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_GetBounds_04(HandleRef pThis, ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax);

		/// <summary>
		/// Explicitly specify the region in space around which to draw the bounds.
		/// The bounds is used only when no Input or Prop is specified. The bounds
		/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
		/// sure that the min's are less than the max's.
		/// </summary>
		// Token: 0x0600B417 RID: 46103 RVA: 0x000FDFB8 File Offset: 0x000FC1B8
		public void GetBounds(ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetBounds_04(base.GetCppThis(), ref xmin, ref xmax, ref ymin, ref ymax, ref zmin, ref zmax);
		}

		// Token: 0x0600B418 RID: 46104
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_GetBounds_05(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Explicitly specify the region in space around which to draw the bounds.
		/// The bounds is used only when no Input or Prop is specified. The bounds
		/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
		/// sure that the min's are less than the max's.
		/// </summary>
		// Token: 0x0600B419 RID: 46105 RVA: 0x000FDFD0 File Offset: 0x000FC1D0
		public void GetBounds(IntPtr bounds)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetBounds_05(base.GetCppThis(), bounds);
		}

		// Token: 0x0600B41A RID: 46106
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor2D_GetCamera_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the camera to perform scaling and translation of the
		/// vtkCubeAxesActor2D.
		/// </summary>
		// Token: 0x0600B41B RID: 46107 RVA: 0x000FDFE0 File Offset: 0x000FC1E0
		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetCamera_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		// Token: 0x0600B41C RID: 46108
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeAxesActor2D_GetCornerOffset_07(HandleRef pThis);

		/// <summary>
		/// Specify an offset value to "pull back" the axes from the corner at
		/// which they are joined to avoid overlap of axes labels. The
		/// "CornerOffset" is the fraction of the axis length to pull back.
		/// </summary>
		// Token: 0x0600B41D RID: 46109 RVA: 0x000FE050 File Offset: 0x000FC250
		public virtual double GetCornerOffset()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetCornerOffset_07(base.GetCppThis());
		}

		// Token: 0x0600B41E RID: 46110
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_GetFlyMode_08(HandleRef pThis);

		/// <summary>
		/// Specify a mode to control how the axes are drawn: either outer edges
		/// or closest triad to the camera position, or you may also disable flying
		/// of the axes.
		/// </summary>
		// Token: 0x0600B41F RID: 46111 RVA: 0x000FE070 File Offset: 0x000FC270
		public virtual int GetFlyMode()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetFlyMode_08(base.GetCppThis());
		}

		// Token: 0x0600B420 RID: 46112
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_GetFlyModeMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Specify a mode to control how the axes are drawn: either outer edges
		/// or closest triad to the camera position, or you may also disable flying
		/// of the axes.
		/// </summary>
		// Token: 0x0600B421 RID: 46113 RVA: 0x000FE090 File Offset: 0x000FC290
		public virtual int GetFlyModeMaxValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetFlyModeMaxValue_09(base.GetCppThis());
		}

		// Token: 0x0600B422 RID: 46114
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_GetFlyModeMinValue_10(HandleRef pThis);

		/// <summary>
		/// Specify a mode to control how the axes are drawn: either outer edges
		/// or closest triad to the camera position, or you may also disable flying
		/// of the axes.
		/// </summary>
		// Token: 0x0600B423 RID: 46115 RVA: 0x000FE0B0 File Offset: 0x000FC2B0
		public virtual int GetFlyModeMinValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetFlyModeMinValue_10(base.GetCppThis());
		}

		// Token: 0x0600B424 RID: 46116
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeAxesActor2D_GetFontFactor_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts used
		/// to label and title the axes.
		/// </summary>
		// Token: 0x0600B425 RID: 46117 RVA: 0x000FE0D0 File Offset: 0x000FC2D0
		public virtual double GetFontFactor()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetFontFactor_11(base.GetCppThis());
		}

		// Token: 0x0600B426 RID: 46118
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeAxesActor2D_GetFontFactorMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts used
		/// to label and title the axes.
		/// </summary>
		// Token: 0x0600B427 RID: 46119 RVA: 0x000FE0F0 File Offset: 0x000FC2F0
		public virtual double GetFontFactorMaxValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetFontFactorMaxValue_12(base.GetCppThis());
		}

		// Token: 0x0600B428 RID: 46120
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCubeAxesActor2D_GetFontFactorMinValue_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts used
		/// to label and title the axes.
		/// </summary>
		// Token: 0x0600B429 RID: 46121 RVA: 0x000FE110 File Offset: 0x000FC310
		public virtual double GetFontFactorMinValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetFontFactorMinValue_13(base.GetCppThis());
		}

		// Token: 0x0600B42A RID: 46122
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_GetInertia_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the inertial factor that controls how often (i.e, how
		/// many renders) the axes can switch position (jump from one axes
		/// to another).
		/// </summary>
		// Token: 0x0600B42B RID: 46123 RVA: 0x000FE130 File Offset: 0x000FC330
		public virtual int GetInertia()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetInertia_14(base.GetCppThis());
		}

		// Token: 0x0600B42C RID: 46124
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_GetInertiaMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the inertial factor that controls how often (i.e, how
		/// many renders) the axes can switch position (jump from one axes
		/// to another).
		/// </summary>
		// Token: 0x0600B42D RID: 46125 RVA: 0x000FE150 File Offset: 0x000FC350
		public virtual int GetInertiaMaxValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetInertiaMaxValue_15(base.GetCppThis());
		}

		// Token: 0x0600B42E RID: 46126
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_GetInertiaMinValue_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the inertial factor that controls how often (i.e, how
		/// many renders) the axes can switch position (jump from one axes
		/// to another).
		/// </summary>
		// Token: 0x0600B42F RID: 46127 RVA: 0x000FE170 File Offset: 0x000FC370
		public virtual int GetInertiaMinValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetInertiaMinValue_16(base.GetCppThis());
		}

		// Token: 0x0600B430 RID: 46128
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor2D_GetInput_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Use the bounding box of this input dataset to draw the cube axes. If this
		/// is not specified, then the class will attempt to determine the bounds from
		/// the defined Prop or Bounds.
		/// </summary>
		// Token: 0x0600B431 RID: 46129 RVA: 0x000FE190 File Offset: 0x000FC390
		public virtual vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetInput_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0600B432 RID: 46130
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor2D_GetLabelFormat_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the format with which to print the labels on each of the
		/// x-y-z axes.
		/// </summary>
		// Token: 0x0600B433 RID: 46131 RVA: 0x000FE200 File Offset: 0x000FC400
		public virtual string GetLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetLabelFormat_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B434 RID: 46132
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCubeAxesActor2D_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B435 RID: 46133 RVA: 0x000FE23C File Offset: 0x000FC43C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x0600B436 RID: 46134
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCubeAxesActor2D_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B437 RID: 46135 RVA: 0x000FE25C File Offset: 0x000FC45C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x0600B438 RID: 46136
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_GetNumberOfLabels_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of annotation labels to show along the x, y, and
		/// z axes. This values is a suggestion: the number of labels may vary
		/// depending on the particulars of the data.
		/// </summary>
		// Token: 0x0600B439 RID: 46137 RVA: 0x000FE278 File Offset: 0x000FC478
		public virtual int GetNumberOfLabels()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetNumberOfLabels_21(base.GetCppThis());
		}

		// Token: 0x0600B43A RID: 46138
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_GetNumberOfLabelsMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of annotation labels to show along the x, y, and
		/// z axes. This values is a suggestion: the number of labels may vary
		/// depending on the particulars of the data.
		/// </summary>
		// Token: 0x0600B43B RID: 46139 RVA: 0x000FE298 File Offset: 0x000FC498
		public virtual int GetNumberOfLabelsMaxValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetNumberOfLabelsMaxValue_22(base.GetCppThis());
		}

		// Token: 0x0600B43C RID: 46140
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_GetNumberOfLabelsMinValue_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of annotation labels to show along the x, y, and
		/// z axes. This values is a suggestion: the number of labels may vary
		/// depending on the particulars of the data.
		/// </summary>
		// Token: 0x0600B43D RID: 46141 RVA: 0x000FE2B8 File Offset: 0x000FC4B8
		public virtual int GetNumberOfLabelsMinValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetNumberOfLabelsMinValue_23(base.GetCppThis());
		}

		// Token: 0x0600B43E RID: 46142
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor2D_GetRanges_24(HandleRef pThis);

		/// <summary>
		/// Explicitly specify the range of values used on the bounds.
		/// The ranges are specified according to (xmin,xmax, ymin,ymax, zmin,zmax),
		/// making sure that the min's are less than the max's.
		/// </summary>
		// Token: 0x0600B43F RID: 46143 RVA: 0x000FE2D8 File Offset: 0x000FC4D8
		public double[] GetRanges()
		{
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetRanges_24(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B440 RID: 46144
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_GetRanges_25(HandleRef pThis, ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax);

		/// <summary>
		/// Explicitly specify the range of values used on the bounds.
		/// The ranges are specified according to (xmin,xmax, ymin,ymax, zmin,zmax),
		/// making sure that the min's are less than the max's.
		/// </summary>
		// Token: 0x0600B441 RID: 46145 RVA: 0x000FE320 File Offset: 0x000FC520
		public void GetRanges(ref double xmin, ref double xmax, ref double ymin, ref double ymax, ref double zmin, ref double zmax)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetRanges_25(base.GetCppThis(), ref xmin, ref xmax, ref ymin, ref ymax, ref zmin, ref zmax);
		}

		// Token: 0x0600B442 RID: 46146
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_GetRanges_26(HandleRef pThis, IntPtr ranges);

		/// <summary>
		/// Explicitly specify the range of values used on the bounds.
		/// The ranges are specified according to (xmin,xmax, ymin,ymax, zmin,zmax),
		/// making sure that the min's are less than the max's.
		/// </summary>
		// Token: 0x0600B443 RID: 46147 RVA: 0x000FE338 File Offset: 0x000FC538
		public void GetRanges(IntPtr ranges)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetRanges_26(base.GetCppThis(), ranges);
		}

		// Token: 0x0600B444 RID: 46148
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_GetScaling_27(HandleRef pThis);

		/// <summary>
		/// Set/Get a flag that controls whether the axes are scaled to fit in
		/// the viewport. If off, the axes size remains constant (i.e., stay the
		/// size of the bounding box). By default scaling is on so the axes are
		/// scaled to fit inside the viewport.
		/// </summary>
		// Token: 0x0600B445 RID: 46149 RVA: 0x000FE348 File Offset: 0x000FC548
		public virtual int GetScaling()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetScaling_27(base.GetCppThis());
		}

		// Token: 0x0600B446 RID: 46150
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_GetShowActualBounds_28(HandleRef pThis);

		/// <summary>
		/// Set/Get the variable that controls whether the actual
		/// bounds of the dataset are always shown. Setting this variable
		/// to 1 means that clipping is disabled and that the actual
		/// value of the bounds is displayed even with corner offsets
		/// Setting this variable to 0 means these axis will clip
		/// themselves and show variable bounds (legacy mode)
		/// </summary>
		// Token: 0x0600B447 RID: 46151 RVA: 0x000FE368 File Offset: 0x000FC568
		public virtual int GetShowActualBounds()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetShowActualBounds_28(base.GetCppThis());
		}

		// Token: 0x0600B448 RID: 46152
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_GetShowActualBoundsMaxValue_29(HandleRef pThis);

		/// <summary>
		/// Set/Get the variable that controls whether the actual
		/// bounds of the dataset are always shown. Setting this variable
		/// to 1 means that clipping is disabled and that the actual
		/// value of the bounds is displayed even with corner offsets
		/// Setting this variable to 0 means these axis will clip
		/// themselves and show variable bounds (legacy mode)
		/// </summary>
		// Token: 0x0600B449 RID: 46153 RVA: 0x000FE388 File Offset: 0x000FC588
		public virtual int GetShowActualBoundsMaxValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetShowActualBoundsMaxValue_29(base.GetCppThis());
		}

		// Token: 0x0600B44A RID: 46154
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_GetShowActualBoundsMinValue_30(HandleRef pThis);

		/// <summary>
		/// Set/Get the variable that controls whether the actual
		/// bounds of the dataset are always shown. Setting this variable
		/// to 1 means that clipping is disabled and that the actual
		/// value of the bounds is displayed even with corner offsets
		/// Setting this variable to 0 means these axis will clip
		/// themselves and show variable bounds (legacy mode)
		/// </summary>
		// Token: 0x0600B44B RID: 46155 RVA: 0x000FE3A8 File Offset: 0x000FC5A8
		public virtual int GetShowActualBoundsMinValue()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetShowActualBoundsMinValue_30(base.GetCppThis());
		}

		// Token: 0x0600B44C RID: 46156
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_GetUseRanges_31(HandleRef pThis);

		/// <summary>
		/// Set/Get a flag that controls whether the axes use the data ranges
		/// or the ranges set by SetRanges. By default the axes use the data
		/// ranges.
		/// </summary>
		// Token: 0x0600B44D RID: 46157 RVA: 0x000FE3C8 File Offset: 0x000FC5C8
		public virtual int GetUseRanges()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetUseRanges_31(base.GetCppThis());
		}

		// Token: 0x0600B44E RID: 46158
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor2D_GetViewProp_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Use the bounding box of this prop to draw the cube axes. The
		/// ViewProp is used to determine the bounds only if the Input is not
		/// defined.
		/// </summary>
		// Token: 0x0600B44F RID: 46159 RVA: 0x000FE3E8 File Offset: 0x000FC5E8
		public virtual vtkProp GetViewProp()
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetViewProp_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		// Token: 0x0600B450 RID: 46160
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor2D_GetXAxisActor2D_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve handles to the X, Y and Z axis (so that you can set their text
		/// properties for example)
		/// </summary>
		// Token: 0x0600B451 RID: 46161 RVA: 0x000FE458 File Offset: 0x000FC658
		public vtkAxisActor2D GetXAxisActor2D()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetXAxisActor2D_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		// Token: 0x0600B452 RID: 46162
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_GetXAxisVisibility_34(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// </summary>
		// Token: 0x0600B453 RID: 46163 RVA: 0x000FE4C8 File Offset: 0x000FC6C8
		public virtual int GetXAxisVisibility()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetXAxisVisibility_34(base.GetCppThis());
		}

		// Token: 0x0600B454 RID: 46164
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor2D_GetXLabel_35(HandleRef pThis);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X", "Y" and "Z".
		/// </summary>
		// Token: 0x0600B455 RID: 46165 RVA: 0x000FE4E8 File Offset: 0x000FC6E8
		public virtual string GetXLabel()
		{
			string s = Marshal.PtrToStringAnsi(vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetXLabel_35(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B456 RID: 46166
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor2D_GetYAxisActor2D_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve handles to the X, Y and Z axis (so that you can set their text
		/// properties for example)
		/// </summary>
		// Token: 0x0600B457 RID: 46167 RVA: 0x000FE524 File Offset: 0x000FC724
		public vtkAxisActor2D GetYAxisActor2D()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetYAxisActor2D_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		// Token: 0x0600B458 RID: 46168
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_GetYAxisVisibility_37(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// </summary>
		// Token: 0x0600B459 RID: 46169 RVA: 0x000FE594 File Offset: 0x000FC794
		public virtual int GetYAxisVisibility()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetYAxisVisibility_37(base.GetCppThis());
		}

		// Token: 0x0600B45A RID: 46170
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor2D_GetYLabel_38(HandleRef pThis);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X", "Y" and "Z".
		/// </summary>
		// Token: 0x0600B45B RID: 46171 RVA: 0x000FE5B4 File Offset: 0x000FC7B4
		public virtual string GetYLabel()
		{
			string s = Marshal.PtrToStringAnsi(vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetYLabel_38(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B45C RID: 46172
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor2D_GetZAxisActor2D_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve handles to the X, Y and Z axis (so that you can set their text
		/// properties for example)
		/// </summary>
		// Token: 0x0600B45D RID: 46173 RVA: 0x000FE5F0 File Offset: 0x000FC7F0
		public vtkAxisActor2D GetZAxisActor2D()
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetZAxisActor2D_39(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		// Token: 0x0600B45E RID: 46174
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_GetZAxisVisibility_40(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// </summary>
		// Token: 0x0600B45F RID: 46175 RVA: 0x000FE660 File Offset: 0x000FC860
		public virtual int GetZAxisVisibility()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetZAxisVisibility_40(base.GetCppThis());
		}

		// Token: 0x0600B460 RID: 46176
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor2D_GetZLabel_41(HandleRef pThis);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X", "Y" and "Z".
		/// </summary>
		// Token: 0x0600B461 RID: 46177 RVA: 0x000FE680 File Offset: 0x000FC880
		public virtual string GetZLabel()
		{
			string s = Marshal.PtrToStringAnsi(vtkCubeAxesActor2D.vtkCubeAxesActor2D_GetZLabel_41(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B462 RID: 46178
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_HasTranslucentPolygonalGeometry_42(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600B463 RID: 46179 RVA: 0x000FE6BC File Offset: 0x000FC8BC
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_HasTranslucentPolygonalGeometry_42(base.GetCppThis());
		}

		// Token: 0x0600B464 RID: 46180
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_IsA_43(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B465 RID: 46181 RVA: 0x000FE6DC File Offset: 0x000FC8DC
		public override int IsA(string type)
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_IsA_43(base.GetCppThis(), type);
		}

		// Token: 0x0600B466 RID: 46182
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_IsTypeOf_44([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B467 RID: 46183 RVA: 0x000FE6FC File Offset: 0x000FC8FC
		public new static int IsTypeOf(string type)
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_IsTypeOf_44(type);
		}

		// Token: 0x0600B468 RID: 46184
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor2D_NewInstance_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B469 RID: 46185 RVA: 0x000FE718 File Offset: 0x000FC918
		public new vtkCubeAxesActor2D NewInstance()
		{
			vtkCubeAxesActor2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_NewInstance_46(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCubeAxesActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600B46A RID: 46186
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_ReleaseGraphicsResources_47(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600B46B RID: 46187 RVA: 0x000FE774 File Offset: 0x000FC974
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_ReleaseGraphicsResources_47(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B46C RID: 46188
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_RenderOpaqueGeometry_48(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the axes as per the vtkProp superclass' API.
		/// </summary>
		// Token: 0x0600B46D RID: 46189 RVA: 0x000FE7A4 File Offset: 0x000FC9A4
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_RenderOpaqueGeometry_48(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B46E RID: 46190
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_RenderOverlay_49(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the axes as per the vtkProp superclass' API.
		/// </summary>
		// Token: 0x0600B46F RID: 46191 RVA: 0x000FE7D8 File Offset: 0x000FC9D8
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_RenderOverlay_49(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B470 RID: 46192
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCubeAxesActor2D_RenderTranslucentPolygonalGeometry_50(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the axes as per the vtkProp superclass' API.
		/// </summary>
		// Token: 0x0600B471 RID: 46193 RVA: 0x000FE80C File Offset: 0x000FCA0C
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkCubeAxesActor2D.vtkCubeAxesActor2D_RenderTranslucentPolygonalGeometry_50(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B472 RID: 46194
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCubeAxesActor2D_SafeDownCast_51(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B473 RID: 46195 RVA: 0x000FE840 File Offset: 0x000FCA40
		public new static vtkCubeAxesActor2D SafeDownCast(vtkObjectBase o)
		{
			vtkCubeAxesActor2D vtkCubeAxesActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCubeAxesActor2D.vtkCubeAxesActor2D_SafeDownCast_51((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCubeAxesActor2D = (vtkCubeAxesActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCubeAxesActor2D.Register(null);
				}
			}
			return vtkCubeAxesActor2D;
		}

		// Token: 0x0600B474 RID: 46196
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_ScalingOff_52(HandleRef pThis);

		/// <summary>
		/// Set/Get a flag that controls whether the axes are scaled to fit in
		/// the viewport. If off, the axes size remains constant (i.e., stay the
		/// size of the bounding box). By default scaling is on so the axes are
		/// scaled to fit inside the viewport.
		/// </summary>
		// Token: 0x0600B475 RID: 46197 RVA: 0x000FE8BF File Offset: 0x000FCABF
		public virtual void ScalingOff()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_ScalingOff_52(base.GetCppThis());
		}

		// Token: 0x0600B476 RID: 46198
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_ScalingOn_53(HandleRef pThis);

		/// <summary>
		/// Set/Get a flag that controls whether the axes are scaled to fit in
		/// the viewport. If off, the axes size remains constant (i.e., stay the
		/// size of the bounding box). By default scaling is on so the axes are
		/// scaled to fit inside the viewport.
		/// </summary>
		// Token: 0x0600B477 RID: 46199 RVA: 0x000FE8CE File Offset: 0x000FCACE
		public virtual void ScalingOn()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_ScalingOn_53(base.GetCppThis());
		}

		// Token: 0x0600B478 RID: 46200
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetAxisLabelTextProperty_54(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the labels text property of all axes. Note that each axis can
		/// be controlled individually through the GetX/Y/ZAxisActor2D() methods.
		/// </summary>
		// Token: 0x0600B479 RID: 46201 RVA: 0x000FE8E0 File Offset: 0x000FCAE0
		public virtual void SetAxisLabelTextProperty(vtkTextProperty p)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetAxisLabelTextProperty_54(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B47A RID: 46202
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetAxisTitleTextProperty_55(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the title text property of all axes. Note that each axis can
		/// be controlled individually through the GetX/Y/ZAxisActor2D() methods.
		/// </summary>
		// Token: 0x0600B47B RID: 46203 RVA: 0x000FE910 File Offset: 0x000FCB10
		public virtual void SetAxisTitleTextProperty(vtkTextProperty p)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetAxisTitleTextProperty_55(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B47C RID: 46204
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetBounds_56(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Explicitly specify the region in space around which to draw the bounds.
		/// The bounds is used only when no Input or Prop is specified. The bounds
		/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
		/// sure that the min's are less than the max's.
		/// </summary>
		// Token: 0x0600B47D RID: 46205 RVA: 0x000FE93F File Offset: 0x000FCB3F
		public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetBounds_56(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600B47E RID: 46206
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetBounds_57(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Explicitly specify the region in space around which to draw the bounds.
		/// The bounds is used only when no Input or Prop is specified. The bounds
		/// are specified according to (xmin,xmax, ymin,ymax, zmin,zmax), making
		/// sure that the min's are less than the max's.
		/// </summary>
		// Token: 0x0600B47F RID: 46207 RVA: 0x000FE957 File Offset: 0x000FCB57
		public virtual void SetBounds(IntPtr _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetBounds_57(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B480 RID: 46208
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetCamera_58(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the camera to perform scaling and translation of the
		/// vtkCubeAxesActor2D.
		/// </summary>
		// Token: 0x0600B481 RID: 46209 RVA: 0x000FE968 File Offset: 0x000FCB68
		public virtual void SetCamera(vtkCamera arg0)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetCamera_58(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B482 RID: 46210
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetCornerOffset_59(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify an offset value to "pull back" the axes from the corner at
		/// which they are joined to avoid overlap of axes labels. The
		/// "CornerOffset" is the fraction of the axis length to pull back.
		/// </summary>
		// Token: 0x0600B483 RID: 46211 RVA: 0x000FE997 File Offset: 0x000FCB97
		public virtual void SetCornerOffset(double _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetCornerOffset_59(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B484 RID: 46212
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetFlyMode_60(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify a mode to control how the axes are drawn: either outer edges
		/// or closest triad to the camera position, or you may also disable flying
		/// of the axes.
		/// </summary>
		// Token: 0x0600B485 RID: 46213 RVA: 0x000FE9A7 File Offset: 0x000FCBA7
		public virtual void SetFlyMode(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetFlyMode_60(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B486 RID: 46214
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetFlyModeToClosestTriad_61(HandleRef pThis);

		/// <summary>
		/// Specify a mode to control how the axes are drawn: either outer edges
		/// or closest triad to the camera position, or you may also disable flying
		/// of the axes.
		/// </summary>
		// Token: 0x0600B487 RID: 46215 RVA: 0x000FE9B7 File Offset: 0x000FCBB7
		public void SetFlyModeToClosestTriad()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetFlyModeToClosestTriad_61(base.GetCppThis());
		}

		// Token: 0x0600B488 RID: 46216
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetFlyModeToNone_62(HandleRef pThis);

		/// <summary>
		/// Specify a mode to control how the axes are drawn: either outer edges
		/// or closest triad to the camera position, or you may also disable flying
		/// of the axes.
		/// </summary>
		// Token: 0x0600B489 RID: 46217 RVA: 0x000FE9C6 File Offset: 0x000FCBC6
		public void SetFlyModeToNone()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetFlyModeToNone_62(base.GetCppThis());
		}

		// Token: 0x0600B48A RID: 46218
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetFlyModeToOuterEdges_63(HandleRef pThis);

		/// <summary>
		/// Specify a mode to control how the axes are drawn: either outer edges
		/// or closest triad to the camera position, or you may also disable flying
		/// of the axes.
		/// </summary>
		// Token: 0x0600B48B RID: 46219 RVA: 0x000FE9D5 File Offset: 0x000FCBD5
		public void SetFlyModeToOuterEdges()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetFlyModeToOuterEdges_63(base.GetCppThis());
		}

		// Token: 0x0600B48C RID: 46220
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetFontFactor_64(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts used
		/// to label and title the axes.
		/// </summary>
		// Token: 0x0600B48D RID: 46221 RVA: 0x000FE9E4 File Offset: 0x000FCBE4
		public virtual void SetFontFactor(double _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetFontFactor_64(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B48E RID: 46222
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetInertia_65(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the inertial factor that controls how often (i.e, how
		/// many renders) the axes can switch position (jump from one axes
		/// to another).
		/// </summary>
		// Token: 0x0600B48F RID: 46223 RVA: 0x000FE9F4 File Offset: 0x000FCBF4
		public virtual void SetInertia(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetInertia_65(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B490 RID: 46224
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetInputConnection_66(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Use the bounding box of this input dataset to draw the cube axes. If this
		/// is not specified, then the class will attempt to determine the bounds from
		/// the defined Prop or Bounds.
		/// </summary>
		// Token: 0x0600B491 RID: 46225 RVA: 0x000FEA04 File Offset: 0x000FCC04
		public virtual void SetInputConnection(vtkAlgorithmOutput arg0)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetInputConnection_66(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B492 RID: 46226
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetInputData_67(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Use the bounding box of this input dataset to draw the cube axes. If this
		/// is not specified, then the class will attempt to determine the bounds from
		/// the defined Prop or Bounds.
		/// </summary>
		// Token: 0x0600B493 RID: 46227 RVA: 0x000FEA34 File Offset: 0x000FCC34
		public virtual void SetInputData(vtkDataSet arg0)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetInputData_67(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B494 RID: 46228
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetLabelFormat_68(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the format with which to print the labels on each of the
		/// x-y-z axes.
		/// </summary>
		// Token: 0x0600B495 RID: 46229 RVA: 0x000FEA63 File Offset: 0x000FCC63
		public virtual void SetLabelFormat(string _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetLabelFormat_68(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B496 RID: 46230
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetNumberOfLabels_69(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of annotation labels to show along the x, y, and
		/// z axes. This values is a suggestion: the number of labels may vary
		/// depending on the particulars of the data.
		/// </summary>
		// Token: 0x0600B497 RID: 46231 RVA: 0x000FEA73 File Offset: 0x000FCC73
		public virtual void SetNumberOfLabels(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetNumberOfLabels_69(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B498 RID: 46232
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetRanges_70(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Explicitly specify the range of values used on the bounds.
		/// The ranges are specified according to (xmin,xmax, ymin,ymax, zmin,zmax),
		/// making sure that the min's are less than the max's.
		/// </summary>
		// Token: 0x0600B499 RID: 46233 RVA: 0x000FEA83 File Offset: 0x000FCC83
		public virtual void SetRanges(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetRanges_70(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600B49A RID: 46234
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetRanges_71(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Explicitly specify the range of values used on the bounds.
		/// The ranges are specified according to (xmin,xmax, ymin,ymax, zmin,zmax),
		/// making sure that the min's are less than the max's.
		/// </summary>
		// Token: 0x0600B49B RID: 46235 RVA: 0x000FEA9B File Offset: 0x000FCC9B
		public virtual void SetRanges(IntPtr _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetRanges_71(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B49C RID: 46236
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetScaling_72(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get a flag that controls whether the axes are scaled to fit in
		/// the viewport. If off, the axes size remains constant (i.e., stay the
		/// size of the bounding box). By default scaling is on so the axes are
		/// scaled to fit inside the viewport.
		/// </summary>
		// Token: 0x0600B49D RID: 46237 RVA: 0x000FEAAB File Offset: 0x000FCCAB
		public virtual void SetScaling(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetScaling_72(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B49E RID: 46238
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetShowActualBounds_73(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the variable that controls whether the actual
		/// bounds of the dataset are always shown. Setting this variable
		/// to 1 means that clipping is disabled and that the actual
		/// value of the bounds is displayed even with corner offsets
		/// Setting this variable to 0 means these axis will clip
		/// themselves and show variable bounds (legacy mode)
		/// </summary>
		// Token: 0x0600B49F RID: 46239 RVA: 0x000FEABB File Offset: 0x000FCCBB
		public virtual void SetShowActualBounds(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetShowActualBounds_73(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B4A0 RID: 46240
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetUseRanges_74(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get a flag that controls whether the axes use the data ranges
		/// or the ranges set by SetRanges. By default the axes use the data
		/// ranges.
		/// </summary>
		// Token: 0x0600B4A1 RID: 46241 RVA: 0x000FEACB File Offset: 0x000FCCCB
		public virtual void SetUseRanges(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetUseRanges_74(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B4A2 RID: 46242
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetViewProp_75(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Use the bounding box of this prop to draw the cube axes. The
		/// ViewProp is used to determine the bounds only if the Input is not
		/// defined.
		/// </summary>
		// Token: 0x0600B4A3 RID: 46243 RVA: 0x000FEADC File Offset: 0x000FCCDC
		public void SetViewProp(vtkProp prop)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetViewProp_75(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x0600B4A4 RID: 46244
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetXAxisVisibility_76(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// </summary>
		// Token: 0x0600B4A5 RID: 46245 RVA: 0x000FEB0B File Offset: 0x000FCD0B
		public virtual void SetXAxisVisibility(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetXAxisVisibility_76(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B4A6 RID: 46246
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetXLabel_77(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X", "Y" and "Z".
		/// </summary>
		// Token: 0x0600B4A7 RID: 46247 RVA: 0x000FEB1B File Offset: 0x000FCD1B
		public virtual void SetXLabel(string _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetXLabel_77(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B4A8 RID: 46248
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetXOrigin_78(HandleRef pThis, double _arg);

		/// <summary>
		/// Explicitly specify an origin for the axes. These usually intersect at one of the
		/// corners of the bounding box, however users have the option to override this if
		/// necessary
		/// </summary>
		// Token: 0x0600B4A9 RID: 46249 RVA: 0x000FEB2B File Offset: 0x000FCD2B
		public virtual void SetXOrigin(double _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetXOrigin_78(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B4AA RID: 46250
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetYAxisVisibility_79(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// </summary>
		// Token: 0x0600B4AB RID: 46251 RVA: 0x000FEB3B File Offset: 0x000FCD3B
		public virtual void SetYAxisVisibility(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetYAxisVisibility_79(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B4AC RID: 46252
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetYLabel_80(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X", "Y" and "Z".
		/// </summary>
		// Token: 0x0600B4AD RID: 46253 RVA: 0x000FEB4B File Offset: 0x000FCD4B
		public virtual void SetYLabel(string _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetYLabel_80(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B4AE RID: 46254
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetYOrigin_81(HandleRef pThis, double _arg);

		/// <summary>
		/// Explicitly specify an origin for the axes. These usually intersect at one of the
		/// corners of the bounding box, however users have the option to override this if
		/// necessary
		/// </summary>
		// Token: 0x0600B4AF RID: 46255 RVA: 0x000FEB5B File Offset: 0x000FCD5B
		public virtual void SetYOrigin(double _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetYOrigin_81(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B4B0 RID: 46256
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetZAxisVisibility_82(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// </summary>
		// Token: 0x0600B4B1 RID: 46257 RVA: 0x000FEB6B File Offset: 0x000FCD6B
		public virtual void SetZAxisVisibility(int _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetZAxisVisibility_82(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B4B2 RID: 46258
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetZLabel_83(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the labels for the x, y, and z axes. By default,
		/// use "X", "Y" and "Z".
		/// </summary>
		// Token: 0x0600B4B3 RID: 46259 RVA: 0x000FEB7B File Offset: 0x000FCD7B
		public virtual void SetZLabel(string _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetZLabel_83(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B4B4 RID: 46260
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_SetZOrigin_84(HandleRef pThis, double _arg);

		/// <summary>
		/// Explicitly specify an origin for the axes. These usually intersect at one of the
		/// corners of the bounding box, however users have the option to override this if
		/// necessary
		/// </summary>
		// Token: 0x0600B4B5 RID: 46261 RVA: 0x000FEB8B File Offset: 0x000FCD8B
		public virtual void SetZOrigin(double _arg)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_SetZOrigin_84(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B4B6 RID: 46262
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_ShallowCopy_85(HandleRef pThis, HandleRef actor);

		/// <summary>
		/// Shallow copy of a CubeAxesActor2D.
		/// </summary>
		// Token: 0x0600B4B7 RID: 46263 RVA: 0x000FEB9C File Offset: 0x000FCD9C
		public void ShallowCopy(vtkCubeAxesActor2D actor)
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_ShallowCopy_85(base.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		// Token: 0x0600B4B8 RID: 46264
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_UseRangesOff_86(HandleRef pThis);

		/// <summary>
		/// Set/Get a flag that controls whether the axes use the data ranges
		/// or the ranges set by SetRanges. By default the axes use the data
		/// ranges.
		/// </summary>
		// Token: 0x0600B4B9 RID: 46265 RVA: 0x000FEBCB File Offset: 0x000FCDCB
		public virtual void UseRangesOff()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_UseRangesOff_86(base.GetCppThis());
		}

		// Token: 0x0600B4BA RID: 46266
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_UseRangesOn_87(HandleRef pThis);

		/// <summary>
		/// Set/Get a flag that controls whether the axes use the data ranges
		/// or the ranges set by SetRanges. By default the axes use the data
		/// ranges.
		/// </summary>
		// Token: 0x0600B4BB RID: 46267 RVA: 0x000FEBDA File Offset: 0x000FCDDA
		public virtual void UseRangesOn()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_UseRangesOn_87(base.GetCppThis());
		}

		// Token: 0x0600B4BC RID: 46268
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_XAxisVisibilityOff_88(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// </summary>
		// Token: 0x0600B4BD RID: 46269 RVA: 0x000FEBE9 File Offset: 0x000FCDE9
		public virtual void XAxisVisibilityOff()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_XAxisVisibilityOff_88(base.GetCppThis());
		}

		// Token: 0x0600B4BE RID: 46270
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_XAxisVisibilityOn_89(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// </summary>
		// Token: 0x0600B4BF RID: 46271 RVA: 0x000FEBF8 File Offset: 0x000FCDF8
		public virtual void XAxisVisibilityOn()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_XAxisVisibilityOn_89(base.GetCppThis());
		}

		// Token: 0x0600B4C0 RID: 46272
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_YAxisVisibilityOff_90(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// </summary>
		// Token: 0x0600B4C1 RID: 46273 RVA: 0x000FEC07 File Offset: 0x000FCE07
		public virtual void YAxisVisibilityOff()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_YAxisVisibilityOff_90(base.GetCppThis());
		}

		// Token: 0x0600B4C2 RID: 46274
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_YAxisVisibilityOn_91(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// </summary>
		// Token: 0x0600B4C3 RID: 46275 RVA: 0x000FEC16 File Offset: 0x000FCE16
		public virtual void YAxisVisibilityOn()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_YAxisVisibilityOn_91(base.GetCppThis());
		}

		// Token: 0x0600B4C4 RID: 46276
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_ZAxisVisibilityOff_92(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// </summary>
		// Token: 0x0600B4C5 RID: 46277 RVA: 0x000FEC25 File Offset: 0x000FCE25
		public virtual void ZAxisVisibilityOff()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_ZAxisVisibilityOff_92(base.GetCppThis());
		}

		// Token: 0x0600B4C6 RID: 46278
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCubeAxesActor2D_ZAxisVisibilityOn_93(HandleRef pThis);

		/// <summary>
		/// Turn on and off the visibility of each axis.
		/// </summary>
		// Token: 0x0600B4C7 RID: 46279 RVA: 0x000FEC34 File Offset: 0x000FCE34
		public virtual void ZAxisVisibilityOn()
		{
			vtkCubeAxesActor2D.vtkCubeAxesActor2D_ZAxisVisibilityOn_93(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DE3 RID: 3555
		public new const string MRFullTypeName = "Kitware.VTK.vtkCubeAxesActor2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DE4 RID: 3556
		public new static readonly string MRClassNameKey = "class vtkCubeAxesActor2D";

		/// <summary>
		/// Set/Get the camera to perform scaling and translation of the
		/// vtkCubeAxesActor2D.
		/// </summary>
		// Token: 0x020003C9 RID: 969
		public enum FlyMode
		{
			/// <summary>enum member</summary>
			// Token: 0x04000DE6 RID: 3558
			VTK_FLY_CLOSEST_TRIAD = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000DE7 RID: 3559
			VTK_FLY_NONE,
			/// <summary>enum member</summary>
			// Token: 0x04000DE8 RID: 3560
			VTK_FLY_OUTER_EDGES = 0
		}
	}
}
