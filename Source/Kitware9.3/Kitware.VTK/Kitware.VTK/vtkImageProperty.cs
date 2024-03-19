using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageProperty
	/// </summary>
	/// <remarks>
	///    image display properties
	///
	/// vtkImageProperty is an object that allows control of the display
	/// of an image slice.
	/// @par Thanks:
	/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
	/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImage vtkImageMapper3D vtkImageSliceMapper vtkImageResliceMapper
	/// </seealso>
	// Token: 0x020007E9 RID: 2025
	public class vtkImageProperty : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014CF6 RID: 85238 RVA: 0x001D7377 File Offset: 0x001D5577
		static vtkImageProperty()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageProperty.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageProperty"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014CF7 RID: 85239 RVA: 0x001D739F File Offset: 0x001D559F
		public vtkImageProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014CF8 RID: 85240
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a property with no lookup table.
		/// </summary>
		// Token: 0x06014CF9 RID: 85241 RVA: 0x001D73B0 File Offset: 0x001D55B0
		public new static vtkImageProperty New()
		{
			vtkImageProperty result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageProperty.vtkImageProperty_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a property with no lookup table.
		/// </summary>
		// Token: 0x06014CFA RID: 85242 RVA: 0x001D7404 File Offset: 0x001D5604
		public vtkImageProperty() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageProperty.vtkImageProperty_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014CFB RID: 85243 RVA: 0x001D7448 File Offset: 0x001D5648
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014CFC RID: 85244
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_BackingOff_01(HandleRef pThis);

		/// <summary>
		/// Use an opaque backing polygon, which will be visible where the image
		/// is translucent.  When images are in a stack, the backing polygons
		/// for all images will be drawn before any of the images in the stack,
		/// in order to allow the images in the stack to be composited.
		/// </summary>
		// Token: 0x06014CFD RID: 85245 RVA: 0x001D7453 File Offset: 0x001D5653
		public virtual void BackingOff()
		{
			vtkImageProperty.vtkImageProperty_BackingOff_01(base.GetCppThis());
		}

		// Token: 0x06014CFE RID: 85246
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_BackingOn_02(HandleRef pThis);

		/// <summary>
		/// Use an opaque backing polygon, which will be visible where the image
		/// is translucent.  When images are in a stack, the backing polygons
		/// for all images will be drawn before any of the images in the stack,
		/// in order to allow the images in the stack to be composited.
		/// </summary>
		// Token: 0x06014CFF RID: 85247 RVA: 0x001D7462 File Offset: 0x001D5662
		public virtual void BackingOn()
		{
			vtkImageProperty.vtkImageProperty_BackingOn_02(base.GetCppThis());
		}

		// Token: 0x06014D00 RID: 85248
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_CheckerboardOff_03(HandleRef pThis);

		/// <summary>
		/// Make a checkerboard pattern where the black squares are transparent.
		/// The pattern is aligned with the camera, and centered by default.
		/// </summary>
		// Token: 0x06014D01 RID: 85249 RVA: 0x001D7471 File Offset: 0x001D5671
		public virtual void CheckerboardOff()
		{
			vtkImageProperty.vtkImageProperty_CheckerboardOff_03(base.GetCppThis());
		}

		// Token: 0x06014D02 RID: 85250
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_CheckerboardOn_04(HandleRef pThis);

		/// <summary>
		/// Make a checkerboard pattern where the black squares are transparent.
		/// The pattern is aligned with the camera, and centered by default.
		/// </summary>
		// Token: 0x06014D03 RID: 85251 RVA: 0x001D7480 File Offset: 0x001D5680
		public virtual void CheckerboardOn()
		{
			vtkImageProperty.vtkImageProperty_CheckerboardOn_04(base.GetCppThis());
		}

		// Token: 0x06014D04 RID: 85252
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_DeepCopy_05(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x06014D05 RID: 85253 RVA: 0x001D7490 File Offset: 0x001D5690
		public void DeepCopy(vtkImageProperty p)
		{
			vtkImageProperty.vtkImageProperty_DeepCopy_05(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x06014D06 RID: 85254
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageProperty_GetAmbient_06(HandleRef pThis);

		/// <summary>
		/// The ambient lighting coefficient.  The default is 1.0.
		/// </summary>
		// Token: 0x06014D07 RID: 85255 RVA: 0x001D74C0 File Offset: 0x001D56C0
		public virtual double GetAmbient()
		{
			return vtkImageProperty.vtkImageProperty_GetAmbient_06(base.GetCppThis());
		}

		// Token: 0x06014D08 RID: 85256
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageProperty_GetAmbientMaxValue_07(HandleRef pThis);

		/// <summary>
		/// The ambient lighting coefficient.  The default is 1.0.
		/// </summary>
		// Token: 0x06014D09 RID: 85257 RVA: 0x001D74E0 File Offset: 0x001D56E0
		public virtual double GetAmbientMaxValue()
		{
			return vtkImageProperty.vtkImageProperty_GetAmbientMaxValue_07(base.GetCppThis());
		}

		// Token: 0x06014D0A RID: 85258
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageProperty_GetAmbientMinValue_08(HandleRef pThis);

		/// <summary>
		/// The ambient lighting coefficient.  The default is 1.0.
		/// </summary>
		// Token: 0x06014D0B RID: 85259 RVA: 0x001D7500 File Offset: 0x001D5700
		public virtual double GetAmbientMinValue()
		{
			return vtkImageProperty.vtkImageProperty_GetAmbientMinValue_08(base.GetCppThis());
		}

		// Token: 0x06014D0C RID: 85260
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageProperty_GetBacking_09(HandleRef pThis);

		/// <summary>
		/// Use an opaque backing polygon, which will be visible where the image
		/// is translucent.  When images are in a stack, the backing polygons
		/// for all images will be drawn before any of the images in the stack,
		/// in order to allow the images in the stack to be composited.
		/// </summary>
		// Token: 0x06014D0D RID: 85261 RVA: 0x001D7520 File Offset: 0x001D5720
		public virtual int GetBacking()
		{
			return vtkImageProperty.vtkImageProperty_GetBacking_09(base.GetCppThis());
		}

		// Token: 0x06014D0E RID: 85262
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageProperty_GetBackingColor_10(HandleRef pThis);

		/// <summary>
		/// Set the color of the backing polygon.  The default color is black.
		/// </summary>
		// Token: 0x06014D0F RID: 85263 RVA: 0x001D7540 File Offset: 0x001D5740
		public virtual double[] GetBackingColor()
		{
			IntPtr intPtr = vtkImageProperty.vtkImageProperty_GetBackingColor_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014D10 RID: 85264
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_GetBackingColor_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the color of the backing polygon.  The default color is black.
		/// </summary>
		// Token: 0x06014D11 RID: 85265 RVA: 0x001D7588 File Offset: 0x001D5788
		public virtual void GetBackingColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageProperty.vtkImageProperty_GetBackingColor_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06014D12 RID: 85266
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_GetBackingColor_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color of the backing polygon.  The default color is black.
		/// </summary>
		// Token: 0x06014D13 RID: 85267 RVA: 0x001D759A File Offset: 0x001D579A
		public virtual void GetBackingColor(IntPtr _arg)
		{
			vtkImageProperty.vtkImageProperty_GetBackingColor_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06014D14 RID: 85268
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageProperty_GetCheckerboard_13(HandleRef pThis);

		/// <summary>
		/// Make a checkerboard pattern where the black squares are transparent.
		/// The pattern is aligned with the camera, and centered by default.
		/// </summary>
		// Token: 0x06014D15 RID: 85269 RVA: 0x001D75AC File Offset: 0x001D57AC
		public virtual int GetCheckerboard()
		{
			return vtkImageProperty.vtkImageProperty_GetCheckerboard_13(base.GetCppThis());
		}

		// Token: 0x06014D16 RID: 85270
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageProperty_GetCheckerboardOffset_14(HandleRef pThis);

		/// <summary>
		/// The phase offset for checkerboarding, in units of spacing.  Use a
		/// value between -1 and +1, where 1 is an offset of one squares.
		/// </summary>
		// Token: 0x06014D17 RID: 85271 RVA: 0x001D75CC File Offset: 0x001D57CC
		public virtual double[] GetCheckerboardOffset()
		{
			IntPtr intPtr = vtkImageProperty.vtkImageProperty_GetCheckerboardOffset_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014D18 RID: 85272
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_GetCheckerboardOffset_15(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// The phase offset for checkerboarding, in units of spacing.  Use a
		/// value between -1 and +1, where 1 is an offset of one squares.
		/// </summary>
		// Token: 0x06014D19 RID: 85273 RVA: 0x001D7614 File Offset: 0x001D5814
		public virtual void GetCheckerboardOffset(ref double _arg1, ref double _arg2)
		{
			vtkImageProperty.vtkImageProperty_GetCheckerboardOffset_15(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06014D1A RID: 85274
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_GetCheckerboardOffset_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The phase offset for checkerboarding, in units of spacing.  Use a
		/// value between -1 and +1, where 1 is an offset of one squares.
		/// </summary>
		// Token: 0x06014D1B RID: 85275 RVA: 0x001D7625 File Offset: 0x001D5825
		public virtual void GetCheckerboardOffset(IntPtr _arg)
		{
			vtkImageProperty.vtkImageProperty_GetCheckerboardOffset_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06014D1C RID: 85276
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageProperty_GetCheckerboardSpacing_17(HandleRef pThis);

		/// <summary>
		/// The spacing for checkerboarding.  This is in real units, not pixels.
		/// </summary>
		// Token: 0x06014D1D RID: 85277 RVA: 0x001D7638 File Offset: 0x001D5838
		public virtual double[] GetCheckerboardSpacing()
		{
			IntPtr intPtr = vtkImageProperty.vtkImageProperty_GetCheckerboardSpacing_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014D1E RID: 85278
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_GetCheckerboardSpacing_18(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// The spacing for checkerboarding.  This is in real units, not pixels.
		/// </summary>
		// Token: 0x06014D1F RID: 85279 RVA: 0x001D7680 File Offset: 0x001D5880
		public virtual void GetCheckerboardSpacing(ref double _arg1, ref double _arg2)
		{
			vtkImageProperty.vtkImageProperty_GetCheckerboardSpacing_18(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06014D20 RID: 85280
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_GetCheckerboardSpacing_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The spacing for checkerboarding.  This is in real units, not pixels.
		/// </summary>
		// Token: 0x06014D21 RID: 85281 RVA: 0x001D7691 File Offset: 0x001D5891
		public virtual void GetCheckerboardSpacing(IntPtr _arg)
		{
			vtkImageProperty.vtkImageProperty_GetCheckerboardSpacing_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06014D22 RID: 85282
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageProperty_GetColorLevel_20(HandleRef pThis);

		/// <summary>
		/// The level value for window/level.
		/// </summary>
		// Token: 0x06014D23 RID: 85283 RVA: 0x001D76A4 File Offset: 0x001D58A4
		public virtual double GetColorLevel()
		{
			return vtkImageProperty.vtkImageProperty_GetColorLevel_20(base.GetCppThis());
		}

		// Token: 0x06014D24 RID: 85284
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageProperty_GetColorWindow_21(HandleRef pThis);

		/// <summary>
		/// The window value for window/level.
		/// </summary>
		// Token: 0x06014D25 RID: 85285 RVA: 0x001D76C4 File Offset: 0x001D58C4
		public virtual double GetColorWindow()
		{
			return vtkImageProperty.vtkImageProperty_GetColorWindow_21(base.GetCppThis());
		}

		// Token: 0x06014D26 RID: 85286
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageProperty_GetDiffuse_22(HandleRef pThis);

		/// <summary>
		/// The diffuse lighting coefficient.  The default is 0.0.
		/// </summary>
		// Token: 0x06014D27 RID: 85287 RVA: 0x001D76E4 File Offset: 0x001D58E4
		public virtual double GetDiffuse()
		{
			return vtkImageProperty.vtkImageProperty_GetDiffuse_22(base.GetCppThis());
		}

		// Token: 0x06014D28 RID: 85288
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageProperty_GetDiffuseMaxValue_23(HandleRef pThis);

		/// <summary>
		/// The diffuse lighting coefficient.  The default is 0.0.
		/// </summary>
		// Token: 0x06014D29 RID: 85289 RVA: 0x001D7704 File Offset: 0x001D5904
		public virtual double GetDiffuseMaxValue()
		{
			return vtkImageProperty.vtkImageProperty_GetDiffuseMaxValue_23(base.GetCppThis());
		}

		// Token: 0x06014D2A RID: 85290
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageProperty_GetDiffuseMinValue_24(HandleRef pThis);

		/// <summary>
		/// The diffuse lighting coefficient.  The default is 0.0.
		/// </summary>
		// Token: 0x06014D2B RID: 85291 RVA: 0x001D7724 File Offset: 0x001D5924
		public virtual double GetDiffuseMinValue()
		{
			return vtkImageProperty.vtkImageProperty_GetDiffuseMinValue_24(base.GetCppThis());
		}

		// Token: 0x06014D2C RID: 85292
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageProperty_GetInterpolationType_25(HandleRef pThis);

		/// <summary>
		/// The interpolation type (default: VTK_LINEAR_INTERPOLATION).
		/// </summary>
		// Token: 0x06014D2D RID: 85293 RVA: 0x001D7744 File Offset: 0x001D5944
		public virtual int GetInterpolationType()
		{
			return vtkImageProperty.vtkImageProperty_GetInterpolationType_25(base.GetCppThis());
		}

		// Token: 0x06014D2E RID: 85294
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageProperty_GetInterpolationTypeAsString_26(HandleRef pThis);

		/// <summary>
		/// The interpolation type (default: VTK_LINEAR_INTERPOLATION).
		/// </summary>
		// Token: 0x06014D2F RID: 85295 RVA: 0x001D7764 File Offset: 0x001D5964
		public virtual string GetInterpolationTypeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageProperty.vtkImageProperty_GetInterpolationTypeAsString_26(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014D30 RID: 85296
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageProperty_GetInterpolationTypeMaxValue_27(HandleRef pThis);

		/// <summary>
		/// The interpolation type (default: VTK_LINEAR_INTERPOLATION).
		/// </summary>
		// Token: 0x06014D31 RID: 85297 RVA: 0x001D77A0 File Offset: 0x001D59A0
		public virtual int GetInterpolationTypeMaxValue()
		{
			return vtkImageProperty.vtkImageProperty_GetInterpolationTypeMaxValue_27(base.GetCppThis());
		}

		// Token: 0x06014D32 RID: 85298
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageProperty_GetInterpolationTypeMinValue_28(HandleRef pThis);

		/// <summary>
		/// The interpolation type (default: VTK_LINEAR_INTERPOLATION).
		/// </summary>
		// Token: 0x06014D33 RID: 85299 RVA: 0x001D77C0 File Offset: 0x001D59C0
		public virtual int GetInterpolationTypeMinValue()
		{
			return vtkImageProperty.vtkImageProperty_GetInterpolationTypeMinValue_28(base.GetCppThis());
		}

		// Token: 0x06014D34 RID: 85300
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageProperty_GetLayerNumber_29(HandleRef pThis);

		/// <summary>
		/// Set the layer number.  This is ignored unless the image is part
		/// of a vtkImageStack.  The default layer number is zero.
		/// </summary>
		// Token: 0x06014D35 RID: 85301 RVA: 0x001D77E0 File Offset: 0x001D59E0
		public int GetLayerNumber()
		{
			return vtkImageProperty.vtkImageProperty_GetLayerNumber_29(base.GetCppThis());
		}

		// Token: 0x06014D36 RID: 85302
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageProperty_GetLookupTable_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a lookup table for the data.  If the data is
		/// to be displayed as greyscale, or if the input data is
		/// already RGB, there is no need to set a lookup table.
		/// </summary>
		// Token: 0x06014D37 RID: 85303 RVA: 0x001D7800 File Offset: 0x001D5A00
		public virtual vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageProperty.vtkImageProperty_GetLookupTable_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		// Token: 0x06014D38 RID: 85304
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImageProperty_GetMTime_31(HandleRef pThis);

		/// <summary>
		/// Get the MTime for this property.  If the lookup table is set,
		/// the mtime will include the mtime of the lookup table.
		/// </summary>
		// Token: 0x06014D39 RID: 85305 RVA: 0x001D7870 File Offset: 0x001D5A70
		public override ulong GetMTime()
		{
			return vtkImageProperty.vtkImageProperty_GetMTime_31(base.GetCppThis());
		}

		// Token: 0x06014D3A RID: 85306
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageProperty_GetNumberOfGenerationsFromBase_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014D3B RID: 85307 RVA: 0x001D7890 File Offset: 0x001D5A90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageProperty.vtkImageProperty_GetNumberOfGenerationsFromBase_32(base.GetCppThis(), type);
		}

		// Token: 0x06014D3C RID: 85308
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageProperty_GetNumberOfGenerationsFromBaseType_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014D3D RID: 85309 RVA: 0x001D78B0 File Offset: 0x001D5AB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageProperty.vtkImageProperty_GetNumberOfGenerationsFromBaseType_33(type);
		}

		// Token: 0x06014D3E RID: 85310
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageProperty_GetOpacity_34(HandleRef pThis);

		/// <summary>
		/// The opacity of the image, where 1.0 is opaque and 0.0 is
		/// transparent.  If the image has an alpha component, then
		/// the alpha component will be multiplied by this value.
		/// The default is 1.0.
		/// </summary>
		// Token: 0x06014D3F RID: 85311 RVA: 0x001D78CC File Offset: 0x001D5ACC
		public virtual double GetOpacity()
		{
			return vtkImageProperty.vtkImageProperty_GetOpacity_34(base.GetCppThis());
		}

		// Token: 0x06014D40 RID: 85312
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageProperty_GetOpacityMaxValue_35(HandleRef pThis);

		/// <summary>
		/// The opacity of the image, where 1.0 is opaque and 0.0 is
		/// transparent.  If the image has an alpha component, then
		/// the alpha component will be multiplied by this value.
		/// The default is 1.0.
		/// </summary>
		// Token: 0x06014D41 RID: 85313 RVA: 0x001D78EC File Offset: 0x001D5AEC
		public virtual double GetOpacityMaxValue()
		{
			return vtkImageProperty.vtkImageProperty_GetOpacityMaxValue_35(base.GetCppThis());
		}

		// Token: 0x06014D42 RID: 85314
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageProperty_GetOpacityMinValue_36(HandleRef pThis);

		/// <summary>
		/// The opacity of the image, where 1.0 is opaque and 0.0 is
		/// transparent.  If the image has an alpha component, then
		/// the alpha component will be multiplied by this value.
		/// The default is 1.0.
		/// </summary>
		// Token: 0x06014D43 RID: 85315 RVA: 0x001D790C File Offset: 0x001D5B0C
		public virtual double GetOpacityMinValue()
		{
			return vtkImageProperty.vtkImageProperty_GetOpacityMinValue_36(base.GetCppThis());
		}

		// Token: 0x06014D44 RID: 85316
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageProperty_GetUseLookupTableScalarRange_37(HandleRef pThis);

		/// <summary>
		/// Use the range that is set in the lookup table, instead
		/// of setting the range from the Window/Level settings.
		/// This is off by default.
		/// </summary>
		// Token: 0x06014D45 RID: 85317 RVA: 0x001D792C File Offset: 0x001D5B2C
		public virtual int GetUseLookupTableScalarRange()
		{
			return vtkImageProperty.vtkImageProperty_GetUseLookupTableScalarRange_37(base.GetCppThis());
		}

		// Token: 0x06014D46 RID: 85318
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageProperty_IsA_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014D47 RID: 85319 RVA: 0x001D794C File Offset: 0x001D5B4C
		public override int IsA(string type)
		{
			return vtkImageProperty.vtkImageProperty_IsA_38(base.GetCppThis(), type);
		}

		// Token: 0x06014D48 RID: 85320
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageProperty_IsTypeOf_39([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014D49 RID: 85321 RVA: 0x001D796C File Offset: 0x001D5B6C
		public new static int IsTypeOf(string type)
		{
			return vtkImageProperty.vtkImageProperty_IsTypeOf_39(type);
		}

		// Token: 0x06014D4A RID: 85322
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageProperty_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014D4B RID: 85323 RVA: 0x001D7988 File Offset: 0x001D5B88
		public new vtkImageProperty NewInstance()
		{
			vtkImageProperty result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageProperty.vtkImageProperty_NewInstance_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014D4C RID: 85324
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageProperty_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014D4D RID: 85325 RVA: 0x001D79E4 File Offset: 0x001D5BE4
		public new static vtkImageProperty SafeDownCast(vtkObjectBase o)
		{
			vtkImageProperty vtkImageProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageProperty.vtkImageProperty_SafeDownCast_42((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageProperty = (vtkImageProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageProperty.Register(null);
				}
			}
			return vtkImageProperty;
		}

		// Token: 0x06014D4E RID: 85326
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetAmbient_43(HandleRef pThis, double _arg);

		/// <summary>
		/// The ambient lighting coefficient.  The default is 1.0.
		/// </summary>
		// Token: 0x06014D4F RID: 85327 RVA: 0x001D7A63 File Offset: 0x001D5C63
		public virtual void SetAmbient(double _arg)
		{
			vtkImageProperty.vtkImageProperty_SetAmbient_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06014D50 RID: 85328
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetBacking_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Use an opaque backing polygon, which will be visible where the image
		/// is translucent.  When images are in a stack, the backing polygons
		/// for all images will be drawn before any of the images in the stack,
		/// in order to allow the images in the stack to be composited.
		/// </summary>
		// Token: 0x06014D51 RID: 85329 RVA: 0x001D7A73 File Offset: 0x001D5C73
		public virtual void SetBacking(int _arg)
		{
			vtkImageProperty.vtkImageProperty_SetBacking_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06014D52 RID: 85330
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetBackingColor_45(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the color of the backing polygon.  The default color is black.
		/// </summary>
		// Token: 0x06014D53 RID: 85331 RVA: 0x001D7A83 File Offset: 0x001D5C83
		public virtual void SetBackingColor(double _arg1, double _arg2, double _arg3)
		{
			vtkImageProperty.vtkImageProperty_SetBackingColor_45(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06014D54 RID: 85332
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetBackingColor_46(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color of the backing polygon.  The default color is black.
		/// </summary>
		// Token: 0x06014D55 RID: 85333 RVA: 0x001D7A95 File Offset: 0x001D5C95
		public virtual void SetBackingColor(IntPtr _arg)
		{
			vtkImageProperty.vtkImageProperty_SetBackingColor_46(base.GetCppThis(), _arg);
		}

		// Token: 0x06014D56 RID: 85334
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetCheckerboard_47(HandleRef pThis, int _arg);

		/// <summary>
		/// Make a checkerboard pattern where the black squares are transparent.
		/// The pattern is aligned with the camera, and centered by default.
		/// </summary>
		// Token: 0x06014D57 RID: 85335 RVA: 0x001D7AA5 File Offset: 0x001D5CA5
		public virtual void SetCheckerboard(int _arg)
		{
			vtkImageProperty.vtkImageProperty_SetCheckerboard_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06014D58 RID: 85336
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetCheckerboardOffset_48(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// The phase offset for checkerboarding, in units of spacing.  Use a
		/// value between -1 and +1, where 1 is an offset of one squares.
		/// </summary>
		// Token: 0x06014D59 RID: 85337 RVA: 0x001D7AB5 File Offset: 0x001D5CB5
		public virtual void SetCheckerboardOffset(double _arg1, double _arg2)
		{
			vtkImageProperty.vtkImageProperty_SetCheckerboardOffset_48(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06014D5A RID: 85338
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetCheckerboardOffset_49(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The phase offset for checkerboarding, in units of spacing.  Use a
		/// value between -1 and +1, where 1 is an offset of one squares.
		/// </summary>
		// Token: 0x06014D5B RID: 85339 RVA: 0x001D7AC6 File Offset: 0x001D5CC6
		public void SetCheckerboardOffset(IntPtr _arg)
		{
			vtkImageProperty.vtkImageProperty_SetCheckerboardOffset_49(base.GetCppThis(), _arg);
		}

		// Token: 0x06014D5C RID: 85340
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetCheckerboardSpacing_50(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// The spacing for checkerboarding.  This is in real units, not pixels.
		/// </summary>
		// Token: 0x06014D5D RID: 85341 RVA: 0x001D7AD6 File Offset: 0x001D5CD6
		public virtual void SetCheckerboardSpacing(double _arg1, double _arg2)
		{
			vtkImageProperty.vtkImageProperty_SetCheckerboardSpacing_50(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06014D5E RID: 85342
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetCheckerboardSpacing_51(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The spacing for checkerboarding.  This is in real units, not pixels.
		/// </summary>
		// Token: 0x06014D5F RID: 85343 RVA: 0x001D7AE7 File Offset: 0x001D5CE7
		public void SetCheckerboardSpacing(IntPtr _arg)
		{
			vtkImageProperty.vtkImageProperty_SetCheckerboardSpacing_51(base.GetCppThis(), _arg);
		}

		// Token: 0x06014D60 RID: 85344
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetColorLevel_52(HandleRef pThis, double _arg);

		/// <summary>
		/// The level value for window/level.
		/// </summary>
		// Token: 0x06014D61 RID: 85345 RVA: 0x001D7AF7 File Offset: 0x001D5CF7
		public virtual void SetColorLevel(double _arg)
		{
			vtkImageProperty.vtkImageProperty_SetColorLevel_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06014D62 RID: 85346
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetColorWindow_53(HandleRef pThis, double _arg);

		/// <summary>
		/// The window value for window/level.
		/// </summary>
		// Token: 0x06014D63 RID: 85347 RVA: 0x001D7B07 File Offset: 0x001D5D07
		public virtual void SetColorWindow(double _arg)
		{
			vtkImageProperty.vtkImageProperty_SetColorWindow_53(base.GetCppThis(), _arg);
		}

		// Token: 0x06014D64 RID: 85348
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetDiffuse_54(HandleRef pThis, double _arg);

		/// <summary>
		/// The diffuse lighting coefficient.  The default is 0.0.
		/// </summary>
		// Token: 0x06014D65 RID: 85349 RVA: 0x001D7B17 File Offset: 0x001D5D17
		public virtual void SetDiffuse(double _arg)
		{
			vtkImageProperty.vtkImageProperty_SetDiffuse_54(base.GetCppThis(), _arg);
		}

		// Token: 0x06014D66 RID: 85350
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetInterpolationType_55(HandleRef pThis, int _arg);

		/// <summary>
		/// The interpolation type (default: VTK_LINEAR_INTERPOLATION).
		/// </summary>
		// Token: 0x06014D67 RID: 85351 RVA: 0x001D7B27 File Offset: 0x001D5D27
		public virtual void SetInterpolationType(int _arg)
		{
			vtkImageProperty.vtkImageProperty_SetInterpolationType_55(base.GetCppThis(), _arg);
		}

		// Token: 0x06014D68 RID: 85352
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetInterpolationTypeToCubic_56(HandleRef pThis);

		/// <summary>
		/// The interpolation type (default: VTK_LINEAR_INTERPOLATION).
		/// </summary>
		// Token: 0x06014D69 RID: 85353 RVA: 0x001D7B37 File Offset: 0x001D5D37
		public void SetInterpolationTypeToCubic()
		{
			vtkImageProperty.vtkImageProperty_SetInterpolationTypeToCubic_56(base.GetCppThis());
		}

		// Token: 0x06014D6A RID: 85354
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetInterpolationTypeToLinear_57(HandleRef pThis);

		/// <summary>
		/// The interpolation type (default: VTK_LINEAR_INTERPOLATION).
		/// </summary>
		// Token: 0x06014D6B RID: 85355 RVA: 0x001D7B46 File Offset: 0x001D5D46
		public void SetInterpolationTypeToLinear()
		{
			vtkImageProperty.vtkImageProperty_SetInterpolationTypeToLinear_57(base.GetCppThis());
		}

		// Token: 0x06014D6C RID: 85356
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetInterpolationTypeToNearest_58(HandleRef pThis);

		/// <summary>
		/// The interpolation type (default: VTK_LINEAR_INTERPOLATION).
		/// </summary>
		// Token: 0x06014D6D RID: 85357 RVA: 0x001D7B55 File Offset: 0x001D5D55
		public void SetInterpolationTypeToNearest()
		{
			vtkImageProperty.vtkImageProperty_SetInterpolationTypeToNearest_58(base.GetCppThis());
		}

		// Token: 0x06014D6E RID: 85358
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetLayerNumber_59(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the layer number.  This is ignored unless the image is part
		/// of a vtkImageStack.  The default layer number is zero.
		/// </summary>
		// Token: 0x06014D6F RID: 85359 RVA: 0x001D7B64 File Offset: 0x001D5D64
		public virtual void SetLayerNumber(int _arg)
		{
			vtkImageProperty.vtkImageProperty_SetLayerNumber_59(base.GetCppThis(), _arg);
		}

		// Token: 0x06014D70 RID: 85360
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetLookupTable_60(HandleRef pThis, HandleRef lut);

		/// <summary>
		/// Specify a lookup table for the data.  If the data is
		/// to be displayed as greyscale, or if the input data is
		/// already RGB, there is no need to set a lookup table.
		/// </summary>
		// Token: 0x06014D71 RID: 85361 RVA: 0x001D7B74 File Offset: 0x001D5D74
		public virtual void SetLookupTable(vtkScalarsToColors lut)
		{
			vtkImageProperty.vtkImageProperty_SetLookupTable_60(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		// Token: 0x06014D72 RID: 85362
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetOpacity_61(HandleRef pThis, double _arg);

		/// <summary>
		/// The opacity of the image, where 1.0 is opaque and 0.0 is
		/// transparent.  If the image has an alpha component, then
		/// the alpha component will be multiplied by this value.
		/// The default is 1.0.
		/// </summary>
		// Token: 0x06014D73 RID: 85363 RVA: 0x001D7BA3 File Offset: 0x001D5DA3
		public virtual void SetOpacity(double _arg)
		{
			vtkImageProperty.vtkImageProperty_SetOpacity_61(base.GetCppThis(), _arg);
		}

		// Token: 0x06014D74 RID: 85364
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_SetUseLookupTableScalarRange_62(HandleRef pThis, int _arg);

		/// <summary>
		/// Use the range that is set in the lookup table, instead
		/// of setting the range from the Window/Level settings.
		/// This is off by default.
		/// </summary>
		// Token: 0x06014D75 RID: 85365 RVA: 0x001D7BB3 File Offset: 0x001D5DB3
		public virtual void SetUseLookupTableScalarRange(int _arg)
		{
			vtkImageProperty.vtkImageProperty_SetUseLookupTableScalarRange_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06014D76 RID: 85366
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_UseLookupTableScalarRangeOff_63(HandleRef pThis);

		/// <summary>
		/// Use the range that is set in the lookup table, instead
		/// of setting the range from the Window/Level settings.
		/// This is off by default.
		/// </summary>
		// Token: 0x06014D77 RID: 85367 RVA: 0x001D7BC3 File Offset: 0x001D5DC3
		public virtual void UseLookupTableScalarRangeOff()
		{
			vtkImageProperty.vtkImageProperty_UseLookupTableScalarRangeOff_63(base.GetCppThis());
		}

		// Token: 0x06014D78 RID: 85368
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProperty_UseLookupTableScalarRangeOn_64(HandleRef pThis);

		/// <summary>
		/// Use the range that is set in the lookup table, instead
		/// of setting the range from the Window/Level settings.
		/// This is off by default.
		/// </summary>
		// Token: 0x06014D79 RID: 85369 RVA: 0x001D7BD2 File Offset: 0x001D5DD2
		public virtual void UseLookupTableScalarRangeOn()
		{
			vtkImageProperty.vtkImageProperty_UseLookupTableScalarRangeOn_64(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001807 RID: 6151
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageProperty";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001808 RID: 6152
		public new static readonly string MRClassNameKey = "class vtkImageProperty";
	}
}
