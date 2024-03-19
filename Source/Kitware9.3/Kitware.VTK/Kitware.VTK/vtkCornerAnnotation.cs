using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCornerAnnotation
	/// </summary>
	/// <remarks>
	///    text annotation in four corners
	///
	/// This is an annotation object that manages four text actors / mappers
	/// to provide annotation in the four corners of a viewport
	///
	/// @par Special input text::
	/// - &lt;tt&gt;\&lt;image\&gt;&lt;/tt&gt; : will be replaced with slice number (relative number)
	/// - &lt;tt&gt;\&lt;slice\&gt;&lt;/tt&gt; : will be replaced with slice number (relative number)
	/// - &lt;tt&gt;\&lt;image_and_max\&gt;&lt;/tt&gt; : will be replaced with slice number and slice max (relative)
	/// - &lt;tt&gt;\&lt;slice_and_max\&gt;&lt;/tt&gt; : will be replaced with slice number and slice max (relative)
	/// - &lt;tt&gt;\&lt;slice_pos\&gt;&lt;/tt&gt; : will be replaced by the position of the current slice
	/// - &lt;tt&gt;\&lt;window\&gt;&lt;/tt&gt; : will be replaced with window value
	/// - &lt;tt&gt;\&lt;level\&gt;&lt;/tt&gt; : will be replaced with level value
	/// - &lt;tt&gt;\&lt;window_level\&gt;&lt;/tt&gt; : will be replaced with window and level value
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor2D vtkTextMapper
	/// </seealso>
	// Token: 0x020003C2 RID: 962
	public class vtkCornerAnnotation : vtkActor2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600B1BA RID: 45498 RVA: 0x000FB3F7 File Offset: 0x000F95F7
		static vtkCornerAnnotation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCornerAnnotation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCornerAnnotation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600B1BB RID: 45499 RVA: 0x000FB41F File Offset: 0x000F961F
		public vtkCornerAnnotation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600B1BC RID: 45500
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCornerAnnotation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with a rectangle in normaled view coordinates
		/// of (0.2,0.85, 0.8, 0.95).
		/// </summary>
		// Token: 0x0600B1BD RID: 45501 RVA: 0x000FB430 File Offset: 0x000F9630
		public new static vtkCornerAnnotation New()
		{
			vtkCornerAnnotation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCornerAnnotation.vtkCornerAnnotation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCornerAnnotation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object with a rectangle in normaled view coordinates
		/// of (0.2,0.85, 0.8, 0.95).
		/// </summary>
		// Token: 0x0600B1BE RID: 45502 RVA: 0x000FB484 File Offset: 0x000F9684
		public vtkCornerAnnotation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCornerAnnotation.vtkCornerAnnotation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600B1BF RID: 45503 RVA: 0x000FB4C8 File Offset: 0x000F96C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600B1C0 RID: 45504
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCornerAnnotation_ClearAllTexts_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the text to be displayed for each corner
		/// \sa TextPosition
		/// </summary>
		// Token: 0x0600B1C1 RID: 45505 RVA: 0x000FB4D3 File Offset: 0x000F96D3
		public void ClearAllTexts()
		{
			vtkCornerAnnotation.vtkCornerAnnotation_ClearAllTexts_01(base.GetCppThis());
		}

		// Token: 0x0600B1C2 RID: 45506
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCornerAnnotation_CopyAllTextsFrom_02(HandleRef pThis, HandleRef ca);

		/// <summary>
		/// Set/Get the text to be displayed for each corner
		/// \sa TextPosition
		/// </summary>
		// Token: 0x0600B1C3 RID: 45507 RVA: 0x000FB4E4 File Offset: 0x000F96E4
		public void CopyAllTextsFrom(vtkCornerAnnotation ca)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_CopyAllTextsFrom_02(base.GetCppThis(), (ca == null) ? default(HandleRef) : ca.GetCppThis());
		}

		// Token: 0x0600B1C4 RID: 45508
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCornerAnnotation_GetImageActor_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set an image actor to look at for slice information
		/// </summary>
		// Token: 0x0600B1C5 RID: 45509 RVA: 0x000FB514 File Offset: 0x000F9714
		public virtual vtkImageActor GetImageActor()
		{
			vtkImageActor vtkImageActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCornerAnnotation.vtkCornerAnnotation_GetImageActor_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B1C6 RID: 45510
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCornerAnnotation_GetLevelScale_04(HandleRef pThis);

		/// <summary>
		/// Set the value to scale the level by.
		/// </summary>
		// Token: 0x0600B1C7 RID: 45511 RVA: 0x000FB584 File Offset: 0x000F9784
		public virtual double GetLevelScale()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetLevelScale_04(base.GetCppThis());
		}

		// Token: 0x0600B1C8 RID: 45512
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCornerAnnotation_GetLevelShift_05(HandleRef pThis);

		/// <summary>
		/// Set the value to shift the level by.
		/// </summary>
		// Token: 0x0600B1C9 RID: 45513 RVA: 0x000FB5A4 File Offset: 0x000F97A4
		public virtual double GetLevelShift()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetLevelShift_05(base.GetCppThis());
		}

		// Token: 0x0600B1CA RID: 45514
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCornerAnnotation_GetLinearFontScaleFactor_06(HandleRef pThis);

		/// <summary>
		/// Set/Get font scaling factors
		/// The font size, f, is calculated as the largest possible value
		/// such that the annotations for the given viewport do not overlap.
		/// This font size is scaled non-linearly with the viewport size,
		/// to maintain an acceptable readable size at larger viewport sizes,
		/// without being too big.
		/// f' = linearScale * pow(f,nonlinearScale)
		/// </summary>
		// Token: 0x0600B1CB RID: 45515 RVA: 0x000FB5C4 File Offset: 0x000F97C4
		public virtual double GetLinearFontScaleFactor()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetLinearFontScaleFactor_06(base.GetCppThis());
		}

		// Token: 0x0600B1CC RID: 45516
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCornerAnnotation_GetMaximumFontSize_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum/maximum size font that will be shown.
		/// If the font drops below the minimum size it will not be rendered.
		/// </summary>
		// Token: 0x0600B1CD RID: 45517 RVA: 0x000FB5E4 File Offset: 0x000F97E4
		public virtual int GetMaximumFontSize()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetMaximumFontSize_07(base.GetCppThis());
		}

		// Token: 0x0600B1CE RID: 45518
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCornerAnnotation_GetMaximumLineHeight_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum height of a line of text as a
		/// percentage of the vertical area allocated to this
		/// scaled text actor. Defaults to 1.0
		/// </summary>
		// Token: 0x0600B1CF RID: 45519 RVA: 0x000FB604 File Offset: 0x000F9804
		public virtual double GetMaximumLineHeight()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetMaximumLineHeight_08(base.GetCppThis());
		}

		// Token: 0x0600B1D0 RID: 45520
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCornerAnnotation_GetMinimumFontSize_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum/maximum size font that will be shown.
		/// If the font drops below the minimum size it will not be rendered.
		/// </summary>
		// Token: 0x0600B1D1 RID: 45521 RVA: 0x000FB624 File Offset: 0x000F9824
		public virtual int GetMinimumFontSize()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetMinimumFontSize_09(base.GetCppThis());
		}

		// Token: 0x0600B1D2 RID: 45522
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCornerAnnotation_GetNonlinearFontScaleFactor_10(HandleRef pThis);

		/// <summary>
		/// Set/Get font scaling factors
		/// The font size, f, is calculated as the largest possible value
		/// such that the annotations for the given viewport do not overlap.
		/// This font size is scaled non-linearly with the viewport size,
		/// to maintain an acceptable readable size at larger viewport sizes,
		/// without being too big.
		/// f' = linearScale * pow(f,nonlinearScale)
		/// </summary>
		// Token: 0x0600B1D3 RID: 45523 RVA: 0x000FB644 File Offset: 0x000F9844
		public virtual double GetNonlinearFontScaleFactor()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetNonlinearFontScaleFactor_10(base.GetCppThis());
		}

		// Token: 0x0600B1D4 RID: 45524
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCornerAnnotation_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B1D5 RID: 45525 RVA: 0x000FB664 File Offset: 0x000F9864
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0600B1D6 RID: 45526
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCornerAnnotation_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B1D7 RID: 45527 RVA: 0x000FB684 File Offset: 0x000F9884
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0600B1D8 RID: 45528
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCornerAnnotation_GetShowSliceAndImage_13(HandleRef pThis);

		/// <summary>
		/// Even if there is an image actor, should `slice' and `image' be displayed?
		/// </summary>
		// Token: 0x0600B1D9 RID: 45529 RVA: 0x000FB6A0 File Offset: 0x000F98A0
		public virtual int GetShowSliceAndImage()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_GetShowSliceAndImage_13(base.GetCppThis());
		}

		// Token: 0x0600B1DA RID: 45530
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCornerAnnotation_GetText_14(HandleRef pThis, int i);

		/// <summary>
		/// Set/Get the text to be displayed for each corner
		/// \sa TextPosition
		/// </summary>
		// Token: 0x0600B1DB RID: 45531 RVA: 0x000FB6C0 File Offset: 0x000F98C0
		public string GetText(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkCornerAnnotation.vtkCornerAnnotation_GetText_14(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B1DC RID: 45532
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCornerAnnotation_GetTextProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the text property of all corners.
		/// </summary>
		// Token: 0x0600B1DD RID: 45533 RVA: 0x000FB6FC File Offset: 0x000F98FC
		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCornerAnnotation.vtkCornerAnnotation_GetTextProperty_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B1DE RID: 45534
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCornerAnnotation_GetWindowLevel_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set an instance of vtkImageMapToWindowLevelColors to use for
		/// looking at window level changes
		/// </summary>
		// Token: 0x0600B1DF RID: 45535 RVA: 0x000FB76C File Offset: 0x000F996C
		public virtual vtkImageMapToWindowLevelColors GetWindowLevel()
		{
			vtkImageMapToWindowLevelColors vtkImageMapToWindowLevelColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCornerAnnotation.vtkCornerAnnotation_GetWindowLevel_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B1E0 RID: 45536
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCornerAnnotation_HasTranslucentPolygonalGeometry_17(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600B1E1 RID: 45537 RVA: 0x000FB7DC File Offset: 0x000F99DC
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_HasTranslucentPolygonalGeometry_17(base.GetCppThis());
		}

		// Token: 0x0600B1E2 RID: 45538
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCornerAnnotation_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B1E3 RID: 45539 RVA: 0x000FB7FC File Offset: 0x000F99FC
		public override int IsA(string type)
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0600B1E4 RID: 45540
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCornerAnnotation_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B1E5 RID: 45541 RVA: 0x000FB81C File Offset: 0x000F9A1C
		public new static int IsTypeOf(string type)
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_IsTypeOf_19(type);
		}

		// Token: 0x0600B1E6 RID: 45542
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCornerAnnotation_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B1E7 RID: 45543 RVA: 0x000FB838 File Offset: 0x000F9A38
		public new vtkCornerAnnotation NewInstance()
		{
			vtkCornerAnnotation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCornerAnnotation.vtkCornerAnnotation_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCornerAnnotation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600B1E8 RID: 45544
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCornerAnnotation_ReleaseGraphicsResources_22(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600B1E9 RID: 45545 RVA: 0x000FB894 File Offset: 0x000F9A94
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_ReleaseGraphicsResources_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B1EA RID: 45546
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCornerAnnotation_RenderOpaqueGeometry_23(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Draw the scalar bar and annotation text to the screen.
		/// </summary>
		// Token: 0x0600B1EB RID: 45547 RVA: 0x000FB8C4 File Offset: 0x000F9AC4
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_RenderOpaqueGeometry_23(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B1EC RID: 45548
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCornerAnnotation_RenderOverlay_24(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Draw the scalar bar and annotation text to the screen.
		/// </summary>
		// Token: 0x0600B1ED RID: 45549 RVA: 0x000FB8F8 File Offset: 0x000F9AF8
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_RenderOverlay_24(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B1EE RID: 45550
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCornerAnnotation_RenderTranslucentPolygonalGeometry_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the scalar bar and annotation text to the screen.
		/// </summary>
		// Token: 0x0600B1EF RID: 45551 RVA: 0x000FB92C File Offset: 0x000F9B2C
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkCornerAnnotation.vtkCornerAnnotation_RenderTranslucentPolygonalGeometry_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B1F0 RID: 45552
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCornerAnnotation_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B1F1 RID: 45553 RVA: 0x000FB960 File Offset: 0x000F9B60
		public new static vtkCornerAnnotation SafeDownCast(vtkObjectBase o)
		{
			vtkCornerAnnotation vtkCornerAnnotation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCornerAnnotation.vtkCornerAnnotation_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCornerAnnotation = (vtkCornerAnnotation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCornerAnnotation.Register(null);
				}
			}
			return vtkCornerAnnotation;
		}

		// Token: 0x0600B1F2 RID: 45554
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCornerAnnotation_SetImageActor_27(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set an image actor to look at for slice information
		/// </summary>
		// Token: 0x0600B1F3 RID: 45555 RVA: 0x000FB9E0 File Offset: 0x000F9BE0
		public void SetImageActor(vtkImageActor arg0)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetImageActor_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B1F4 RID: 45556
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCornerAnnotation_SetLevelScale_28(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the value to scale the level by.
		/// </summary>
		// Token: 0x0600B1F5 RID: 45557 RVA: 0x000FBA0F File Offset: 0x000F9C0F
		public virtual void SetLevelScale(double _arg)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetLevelScale_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B1F6 RID: 45558
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCornerAnnotation_SetLevelShift_29(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the value to shift the level by.
		/// </summary>
		// Token: 0x0600B1F7 RID: 45559 RVA: 0x000FBA1F File Offset: 0x000F9C1F
		public virtual void SetLevelShift(double _arg)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetLevelShift_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B1F8 RID: 45560
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCornerAnnotation_SetLinearFontScaleFactor_30(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get font scaling factors
		/// The font size, f, is calculated as the largest possible value
		/// such that the annotations for the given viewport do not overlap.
		/// This font size is scaled non-linearly with the viewport size,
		/// to maintain an acceptable readable size at larger viewport sizes,
		/// without being too big.
		/// f' = linearScale * pow(f,nonlinearScale)
		/// </summary>
		// Token: 0x0600B1F9 RID: 45561 RVA: 0x000FBA2F File Offset: 0x000F9C2F
		public virtual void SetLinearFontScaleFactor(double _arg)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetLinearFontScaleFactor_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B1FA RID: 45562
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCornerAnnotation_SetMaximumFontSize_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the minimum/maximum size font that will be shown.
		/// If the font drops below the minimum size it will not be rendered.
		/// </summary>
		// Token: 0x0600B1FB RID: 45563 RVA: 0x000FBA3F File Offset: 0x000F9C3F
		public virtual void SetMaximumFontSize(int _arg)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetMaximumFontSize_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B1FC RID: 45564
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCornerAnnotation_SetMaximumLineHeight_32(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the maximum height of a line of text as a
		/// percentage of the vertical area allocated to this
		/// scaled text actor. Defaults to 1.0
		/// </summary>
		// Token: 0x0600B1FD RID: 45565 RVA: 0x000FBA4F File Offset: 0x000F9C4F
		public virtual void SetMaximumLineHeight(double _arg)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetMaximumLineHeight_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B1FE RID: 45566
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCornerAnnotation_SetMinimumFontSize_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the minimum/maximum size font that will be shown.
		/// If the font drops below the minimum size it will not be rendered.
		/// </summary>
		// Token: 0x0600B1FF RID: 45567 RVA: 0x000FBA5F File Offset: 0x000F9C5F
		public virtual void SetMinimumFontSize(int _arg)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetMinimumFontSize_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B200 RID: 45568
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCornerAnnotation_SetNonlinearFontScaleFactor_34(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get font scaling factors
		/// The font size, f, is calculated as the largest possible value
		/// such that the annotations for the given viewport do not overlap.
		/// This font size is scaled non-linearly with the viewport size,
		/// to maintain an acceptable readable size at larger viewport sizes,
		/// without being too big.
		/// f' = linearScale * pow(f,nonlinearScale)
		/// </summary>
		// Token: 0x0600B201 RID: 45569 RVA: 0x000FBA6F File Offset: 0x000F9C6F
		public virtual void SetNonlinearFontScaleFactor(double _arg)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetNonlinearFontScaleFactor_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B202 RID: 45570
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCornerAnnotation_SetShowSliceAndImage_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Even if there is an image actor, should `slice' and `image' be displayed?
		/// </summary>
		// Token: 0x0600B203 RID: 45571 RVA: 0x000FBA7F File Offset: 0x000F9C7F
		public virtual void SetShowSliceAndImage(int _arg)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetShowSliceAndImage_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B204 RID: 45572
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCornerAnnotation_SetText_36(HandleRef pThis, int i, [MarshalAs(UnmanagedType.LPUTF8Str)] string text);

		/// <summary>
		/// Set/Get the text to be displayed for each corner
		/// \sa TextPosition
		/// </summary>
		// Token: 0x0600B205 RID: 45573 RVA: 0x000FBA8F File Offset: 0x000F9C8F
		public void SetText(int i, string text)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetText_36(base.GetCppThis(), i, text);
		}

		// Token: 0x0600B206 RID: 45574
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCornerAnnotation_SetTextProperty_37(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the text property of all corners.
		/// </summary>
		// Token: 0x0600B207 RID: 45575 RVA: 0x000FBAA0 File Offset: 0x000F9CA0
		public virtual void SetTextProperty(vtkTextProperty p)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetTextProperty_37(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B208 RID: 45576
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCornerAnnotation_SetWindowLevel_38(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set an instance of vtkImageMapToWindowLevelColors to use for
		/// looking at window level changes
		/// </summary>
		// Token: 0x0600B209 RID: 45577 RVA: 0x000FBAD0 File Offset: 0x000F9CD0
		public void SetWindowLevel(vtkImageMapToWindowLevelColors arg0)
		{
			vtkCornerAnnotation.vtkCornerAnnotation_SetWindowLevel_38(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B20A RID: 45578
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCornerAnnotation_ShowSliceAndImageOff_39(HandleRef pThis);

		/// <summary>
		/// Even if there is an image actor, should `slice' and `image' be displayed?
		/// </summary>
		// Token: 0x0600B20B RID: 45579 RVA: 0x000FBAFF File Offset: 0x000F9CFF
		public virtual void ShowSliceAndImageOff()
		{
			vtkCornerAnnotation.vtkCornerAnnotation_ShowSliceAndImageOff_39(base.GetCppThis());
		}

		// Token: 0x0600B20C RID: 45580
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCornerAnnotation_ShowSliceAndImageOn_40(HandleRef pThis);

		/// <summary>
		/// Even if there is an image actor, should `slice' and `image' be displayed?
		/// </summary>
		// Token: 0x0600B20D RID: 45581 RVA: 0x000FBB0E File Offset: 0x000F9D0E
		public virtual void ShowSliceAndImageOn()
		{
			vtkCornerAnnotation.vtkCornerAnnotation_ShowSliceAndImageOn_40(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DC8 RID: 3528
		public new const string MRFullTypeName = "Kitware.VTK.vtkCornerAnnotation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DC9 RID: 3529
		public new static readonly string MRClassNameKey = "class vtkCornerAnnotation";

		/// <summary>
		/// Position used to get or set the corner annotation text.
		/// \sa GetText(), SetText()
		/// </summary>
		// Token: 0x020003C3 RID: 963
		public enum TextPosition
		{
			/// <summary>enum member</summary>
			// Token: 0x04000DCB RID: 3531
			LeftEdge = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000DCC RID: 3532
			LowerEdge = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000DCD RID: 3533
			LowerLeft = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000DCE RID: 3534
			LowerRight,
			/// <summary>enum member</summary>
			// Token: 0x04000DCF RID: 3535
			RightEdge = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000DD0 RID: 3536
			UpperEdge = 7,
			/// <summary>enum member</summary>
			// Token: 0x04000DD1 RID: 3537
			UpperLeft = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000DD2 RID: 3538
			UpperRight
		}
	}
}
