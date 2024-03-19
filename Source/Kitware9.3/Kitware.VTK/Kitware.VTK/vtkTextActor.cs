using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTextActor
	/// </summary>
	/// <remarks>
	///    An actor that displays text. Scaled or unscaled
	///
	/// vtkTextActor can be used to place text annotation into a window.
	/// When TextScaleMode is NONE, the text is fixed font and operation is
	/// the same as a vtkPolyDataMapper2D/vtkActor2D pair.
	/// When TextScaleMode is VIEWPORT, the font resizes such that it maintains a
	/// consistent size relative to the viewport in which it is rendered.
	/// When TextScaleMode is PROP, the font resizes such that the text fits inside
	/// the box defined by the position 1 &amp; 2 coordinates. This class replaces the
	/// deprecated vtkScaledTextActor and acts as a convenient wrapper for
	/// a vtkTextMapper/vtkActor2D pair.
	/// Set the text property/attributes through the vtkTextProperty associated to
	/// this actor.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor2D vtkPolyDataMapper vtkTextProperty vtkTextRenderer
	/// </seealso>
	// Token: 0x020005CF RID: 1487
	public class vtkTextActor : vtkTexturedActor2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060103C5 RID: 66501 RVA: 0x00169DBB File Offset: 0x00167FBB
		static vtkTextActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060103C6 RID: 66502 RVA: 0x00169DE3 File Offset: 0x00167FE3
		public vtkTextActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060103C7 RID: 66503
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with a rectangle in normaled view coordinates
		/// of (0.2,0.85, 0.8, 0.95).
		/// </summary>
		// Token: 0x060103C8 RID: 66504 RVA: 0x00169DF4 File Offset: 0x00167FF4
		public new static vtkTextActor New()
		{
			vtkTextActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextActor.vtkTextActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object with a rectangle in normaled view coordinates
		/// of (0.2,0.85, 0.8, 0.95).
		/// </summary>
		// Token: 0x060103C9 RID: 66505 RVA: 0x00169E48 File Offset: 0x00168048
		public vtkTextActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTextActor.vtkTextActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060103CA RID: 66506 RVA: 0x00169E8C File Offset: 0x0016808C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060103CB RID: 66507
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_ComputeScaledFont_01(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Compute the scale the font should be given the viewport.  The result
		/// is placed in the ScaledTextProperty ivar.
		/// </summary>
		// Token: 0x060103CC RID: 66508 RVA: 0x00169E98 File Offset: 0x00168098
		public virtual void ComputeScaledFont(vtkViewport viewport)
		{
			vtkTextActor.vtkTextActor_ComputeScaledFont_01(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060103CD RID: 66509
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_DisplayToSpecified_02(HandleRef pThis, IntPtr pos, HandleRef vport, int specified);

		/// <summary>
		/// This is just a simple coordinate conversion method used in the render
		/// process.
		/// </summary>
		// Token: 0x060103CE RID: 66510 RVA: 0x00169EC8 File Offset: 0x001680C8
		public void DisplayToSpecified(IntPtr pos, vtkViewport vport, int specified)
		{
			vtkTextActor.vtkTextActor_DisplayToSpecified_02(base.GetCppThis(), pos, (vport == null) ? default(HandleRef) : vport.GetCppThis(), specified);
		}

		// Token: 0x060103CF RID: 66511
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor_GetAlignmentPoint_03(HandleRef pThis);

		/// <summary>
		/// This method is being deprecated.  Use SetJustification and
		/// SetVerticalJustification in text property instead.
		/// Set/Get the Alignment point
		/// if zero (default), the text aligns itself to the bottom left corner
		/// (which is defined by the PositionCoordinate)
		/// otherwise the text aligns itself to corner/midpoint or centre
		/// @verbatim
		/// 6   7   8
		/// 3   4   5
		/// 0   1   2
		/// @endverbatim
		/// This is the same as setting the TextProperty's justification.
		/// Currently TextActor is not oriented around its AlignmentPoint.
		/// </summary>
		// Token: 0x060103D0 RID: 66512 RVA: 0x00169EFC File Offset: 0x001680FC
		public int GetAlignmentPoint()
		{
			return vtkTextActor.vtkTextActor_GetAlignmentPoint_03(base.GetCppThis());
		}

		// Token: 0x060103D1 RID: 66513
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_GetBoundingBox_04(HandleRef pThis, HandleRef vport, IntPtr bbox);

		/// <summary>
		/// Return the bounding box coordinates of the text in pixels.
		/// The bbox array is populated with [ xmin, xmax, ymin, ymax ]
		/// values in that order.
		/// </summary>
		// Token: 0x060103D2 RID: 66514 RVA: 0x00169F1C File Offset: 0x0016811C
		public virtual void GetBoundingBox(vtkViewport vport, IntPtr bbox)
		{
			vtkTextActor.vtkTextActor_GetBoundingBox_04(base.GetCppThis(), (vport == null) ? default(HandleRef) : vport.GetCppThis(), bbox);
		}

		// Token: 0x060103D3 RID: 66515
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkTextActor_GetFontScale_05(HandleRef viewport);

		/// <summary>
		/// Provide a font scaling based on a viewport.  This is the scaling factor
		/// used when the TextScaleMode is set to VIEWPORT and has been made public for
		/// other components to use.  This scaling assumes that the long dimension of
		/// the viewport is meant to be 6 inches (a typical width of text in a paper)
		/// and then resizes based on if that long dimension was 72 DPI.
		/// </summary>
		// Token: 0x060103D4 RID: 66516 RVA: 0x00169F4C File Offset: 0x0016814C
		public static float GetFontScale(vtkViewport viewport)
		{
			return vtkTextActor.vtkTextActor_GetFontScale_05((viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060103D5 RID: 66517
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextActor_GetInput_06(HandleRef pThis);

		/// <summary>
		/// Set the text string to be displayed. "\n" is recognized
		/// as a carriage return/linefeed (line separator).
		/// The characters must be in the UTF-8 encoding.
		/// Convenience method to the underlying mapper
		/// </summary>
		// Token: 0x060103D6 RID: 66518 RVA: 0x00169F7C File Offset: 0x0016817C
		public string GetInput()
		{
			string s = Marshal.PtrToStringAnsi(vtkTextActor.vtkTextActor_GetInput_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060103D7 RID: 66519
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkTextActor_GetMaximumLineHeight_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum height of a line of text as a
		/// percentage of the vertical area allocated to this
		/// scaled text actor. Defaults to 1.0.
		/// Only valid when TextScaleMode is PROP.
		/// </summary>
		// Token: 0x060103D8 RID: 66520 RVA: 0x00169FB8 File Offset: 0x001681B8
		public virtual float GetMaximumLineHeight()
		{
			return vtkTextActor.vtkTextActor_GetMaximumLineHeight_07(base.GetCppThis());
		}

		// Token: 0x060103D9 RID: 66521
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextActor_GetMinimumSize_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum size in pixels for this actor.
		/// Defaults to 10,10.
		/// Only valid when TextScaleMode is PROP.
		/// </summary>
		// Token: 0x060103DA RID: 66522 RVA: 0x00169FD8 File Offset: 0x001681D8
		public virtual int[] GetMinimumSize()
		{
			IntPtr intPtr = vtkTextActor.vtkTextActor_GetMinimumSize_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060103DB RID: 66523
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_GetMinimumSize_09(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Set/Get the minimum size in pixels for this actor.
		/// Defaults to 10,10.
		/// Only valid when TextScaleMode is PROP.
		/// </summary>
		// Token: 0x060103DC RID: 66524 RVA: 0x0016A020 File Offset: 0x00168220
		public virtual void GetMinimumSize(ref int _arg1, ref int _arg2)
		{
			vtkTextActor.vtkTextActor_GetMinimumSize_09(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060103DD RID: 66525
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_GetMinimumSize_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the minimum size in pixels for this actor.
		/// Defaults to 10,10.
		/// Only valid when TextScaleMode is PROP.
		/// </summary>
		// Token: 0x060103DE RID: 66526 RVA: 0x0016A031 File Offset: 0x00168231
		public virtual void GetMinimumSize(IntPtr _arg)
		{
			vtkTextActor.vtkTextActor_GetMinimumSize_10(base.GetCppThis(), _arg);
		}

		// Token: 0x060103DF RID: 66527
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextActor_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060103E0 RID: 66528 RVA: 0x0016A044 File Offset: 0x00168244
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTextActor.vtkTextActor_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x060103E1 RID: 66529
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextActor_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060103E2 RID: 66530 RVA: 0x0016A064 File Offset: 0x00168264
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTextActor.vtkTextActor_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x060103E3 RID: 66531
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkTextActor_GetOrientation_13(HandleRef pThis);

		/// <summary>
		/// Counterclockwise rotation around the Alignment point.
		/// Units are in degrees and defaults to 0.
		/// The orientation in the text property rotates the text in the
		/// texture map.  It will proba ly not give you the effect you
		/// desire.
		/// </summary>
		// Token: 0x060103E4 RID: 66532 RVA: 0x0016A080 File Offset: 0x00168280
		public virtual float GetOrientation()
		{
			return vtkTextActor.vtkTextActor_GetOrientation_13(base.GetCppThis());
		}

		// Token: 0x060103E5 RID: 66533
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextActor_GetScaledTextProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the scaled font.  Use ComputeScaledFont to set the scale for a given
		/// viewport.
		/// </summary>
		// Token: 0x060103E6 RID: 66534 RVA: 0x0016A0A0 File Offset: 0x001682A0
		public virtual vtkTextProperty GetScaledTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextActor.vtkTextActor_GetScaledTextProperty_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060103E7 RID: 66535
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_GetSize_15(HandleRef pThis, HandleRef vport, IntPtr size);

		/// <summary>
		/// Syntactic sugar to get the size of text instead of the entire bounding box.
		/// </summary>
		// Token: 0x060103E8 RID: 66536 RVA: 0x0016A110 File Offset: 0x00168310
		public virtual void GetSize(vtkViewport vport, IntPtr size)
		{
			vtkTextActor.vtkTextActor_GetSize_15(base.GetCppThis(), (vport == null) ? default(HandleRef) : vport.GetCppThis(), size);
		}

		// Token: 0x060103E9 RID: 66537
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextActor_GetTextProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the text property.
		/// </summary>
		// Token: 0x060103EA RID: 66538 RVA: 0x0016A140 File Offset: 0x00168340
		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextActor.vtkTextActor_GetTextProperty_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060103EB RID: 66539
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor_GetTextScaleMode_17(HandleRef pThis);

		/// <summary>
		/// Set how text should be scaled.  If set to
		/// vtkTextActor::TEXT_SCALE_MODE_NONE, the font size will be fixed by the
		/// size given in TextProperty.  If set to vtkTextActor::TEXT_SCALE_MODE_PROP,
		/// the text will be scaled to fit exactly in the prop as specified by the
		/// position 1 &amp; 2 coordinates.  If set to
		/// vtkTextActor::TEXT_SCALE_MODE_VIEWPORT, the text will be scaled based on
		/// the size of the viewport it is displayed in.
		/// </summary>
		// Token: 0x060103EC RID: 66540 RVA: 0x0016A1B0 File Offset: 0x001683B0
		public virtual int GetTextScaleMode()
		{
			return vtkTextActor.vtkTextActor_GetTextScaleMode_17(base.GetCppThis());
		}

		// Token: 0x060103ED RID: 66541
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor_GetTextScaleModeMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Set how text should be scaled.  If set to
		/// vtkTextActor::TEXT_SCALE_MODE_NONE, the font size will be fixed by the
		/// size given in TextProperty.  If set to vtkTextActor::TEXT_SCALE_MODE_PROP,
		/// the text will be scaled to fit exactly in the prop as specified by the
		/// position 1 &amp; 2 coordinates.  If set to
		/// vtkTextActor::TEXT_SCALE_MODE_VIEWPORT, the text will be scaled based on
		/// the size of the viewport it is displayed in.
		/// </summary>
		// Token: 0x060103EE RID: 66542 RVA: 0x0016A1D0 File Offset: 0x001683D0
		public virtual int GetTextScaleModeMaxValue()
		{
			return vtkTextActor.vtkTextActor_GetTextScaleModeMaxValue_18(base.GetCppThis());
		}

		// Token: 0x060103EF RID: 66543
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor_GetTextScaleModeMinValue_19(HandleRef pThis);

		/// <summary>
		/// Set how text should be scaled.  If set to
		/// vtkTextActor::TEXT_SCALE_MODE_NONE, the font size will be fixed by the
		/// size given in TextProperty.  If set to vtkTextActor::TEXT_SCALE_MODE_PROP,
		/// the text will be scaled to fit exactly in the prop as specified by the
		/// position 1 &amp; 2 coordinates.  If set to
		/// vtkTextActor::TEXT_SCALE_MODE_VIEWPORT, the text will be scaled based on
		/// the size of the viewport it is displayed in.
		/// </summary>
		// Token: 0x060103F0 RID: 66544 RVA: 0x0016A1F0 File Offset: 0x001683F0
		public virtual int GetTextScaleModeMinValue()
		{
			return vtkTextActor.vtkTextActor_GetTextScaleModeMinValue_19(base.GetCppThis());
		}

		// Token: 0x060103F1 RID: 66545
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor_GetUseBorderAlign_20(HandleRef pThis);

		/// <summary>
		/// Turn on or off the UseBorderAlign option.
		/// When UseBorderAlign is on, the bounding rectangle is used to align the text,
		/// which is the proper behavior when using vtkTextRepresentation
		/// </summary>
		// Token: 0x060103F2 RID: 66546 RVA: 0x0016A210 File Offset: 0x00168410
		public virtual int GetUseBorderAlign()
		{
			return vtkTextActor.vtkTextActor_GetUseBorderAlign_20(base.GetCppThis());
		}

		// Token: 0x060103F3 RID: 66547
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor_HasTranslucentPolygonalGeometry_21(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x060103F4 RID: 66548 RVA: 0x0016A230 File Offset: 0x00168430
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkTextActor.vtkTextActor_HasTranslucentPolygonalGeometry_21(base.GetCppThis());
		}

		// Token: 0x060103F5 RID: 66549
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060103F6 RID: 66550 RVA: 0x0016A250 File Offset: 0x00168450
		public override int IsA(string type)
		{
			return vtkTextActor.vtkTextActor_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x060103F7 RID: 66551
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060103F8 RID: 66552 RVA: 0x0016A270 File Offset: 0x00168470
		public new static int IsTypeOf(string type)
		{
			return vtkTextActor.vtkTextActor_IsTypeOf_23(type);
		}

		// Token: 0x060103F9 RID: 66553
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextActor_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060103FA RID: 66554 RVA: 0x0016A28C File Offset: 0x0016848C
		public new vtkTextActor NewInstance()
		{
			vtkTextActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextActor.vtkTextActor_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060103FB RID: 66555
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_ReleaseGraphicsResources_26(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x060103FC RID: 66556 RVA: 0x0016A2E8 File Offset: 0x001684E8
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkTextActor.vtkTextActor_ReleaseGraphicsResources_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060103FD RID: 66557
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor_RenderOpaqueGeometry_27(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
		/// Draw the text actor to the screen.
		/// </summary>
		// Token: 0x060103FE RID: 66558 RVA: 0x0016A318 File Offset: 0x00168518
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkTextActor.vtkTextActor_RenderOpaqueGeometry_27(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060103FF RID: 66559
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor_RenderOverlay_28(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
		/// Draw the text actor to the screen.
		/// </summary>
		// Token: 0x06010400 RID: 66560 RVA: 0x0016A34C File Offset: 0x0016854C
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkTextActor.vtkTextActor_RenderOverlay_28(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06010401 RID: 66561
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor_RenderTranslucentPolygonalGeometry_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
		/// Draw the text actor to the screen.
		/// </summary>
		// Token: 0x06010402 RID: 66562 RVA: 0x0016A380 File Offset: 0x00168580
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkTextActor.vtkTextActor_RenderTranslucentPolygonalGeometry_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010403 RID: 66563
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextActor_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010404 RID: 66564 RVA: 0x0016A3B4 File Offset: 0x001685B4
		public new static vtkTextActor SafeDownCast(vtkObjectBase o)
		{
			vtkTextActor vtkTextActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextActor.vtkTextActor_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextActor = (vtkTextActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextActor.Register(null);
				}
			}
			return vtkTextActor;
		}

		// Token: 0x06010405 RID: 66565
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_SetAlignmentPoint_31(HandleRef pThis, int point);

		/// <summary>
		/// This method is being deprecated.  Use SetJustification and
		/// SetVerticalJustification in text property instead.
		/// Set/Get the Alignment point
		/// if zero (default), the text aligns itself to the bottom left corner
		/// (which is defined by the PositionCoordinate)
		/// otherwise the text aligns itself to corner/midpoint or centre
		/// @verbatim
		/// 6   7   8
		/// 3   4   5
		/// 0   1   2
		/// @endverbatim
		/// This is the same as setting the TextProperty's justification.
		/// Currently TextActor is not oriented around its AlignmentPoint.
		/// </summary>
		// Token: 0x06010406 RID: 66566 RVA: 0x0016A433 File Offset: 0x00168633
		public void SetAlignmentPoint(int point)
		{
			vtkTextActor.vtkTextActor_SetAlignmentPoint_31(base.GetCppThis(), point);
		}

		// Token: 0x06010407 RID: 66567
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor_SetConstrainedFontSize_32(HandleRef pThis, HandleRef arg0, int targetWidth, int targetHeight);

		/// <summary>
		/// Set and return the font size required to make this mapper fit in a given
		/// target rectangle (width x height, in pixels). A static version of the
		/// method is also available for convenience to other classes (e.g., widgets).
		/// </summary>
		// Token: 0x06010408 RID: 66568 RVA: 0x0016A444 File Offset: 0x00168644
		public virtual int SetConstrainedFontSize(vtkViewport arg0, int targetWidth, int targetHeight)
		{
			return vtkTextActor.vtkTextActor_SetConstrainedFontSize_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), targetWidth, targetHeight);
		}

		// Token: 0x06010409 RID: 66569
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor_SetConstrainedFontSize_33(HandleRef arg0, HandleRef arg1, int targetWidth, int targetHeight);

		/// <summary>
		/// Set and return the font size required to make this mapper fit in a given
		/// target rectangle (width x height, in pixels). A static version of the
		/// method is also available for convenience to other classes (e.g., widgets).
		/// </summary>
		// Token: 0x0601040A RID: 66570 RVA: 0x0016A47C File Offset: 0x0016867C
		public static int SetConstrainedFontSize(vtkTextActor arg0, vtkViewport arg1, int targetWidth, int targetHeight)
		{
			return vtkTextActor.vtkTextActor_SetConstrainedFontSize_33((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), targetWidth, targetHeight);
		}

		// Token: 0x0601040B RID: 66571
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_SetInput_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string inputString);

		/// <summary>
		/// Set the text string to be displayed. "\n" is recognized
		/// as a carriage return/linefeed (line separator).
		/// The characters must be in the UTF-8 encoding.
		/// Convenience method to the underlying mapper
		/// </summary>
		// Token: 0x0601040C RID: 66572 RVA: 0x0016A4C1 File Offset: 0x001686C1
		public void SetInput(string inputString)
		{
			vtkTextActor.vtkTextActor_SetInput_34(base.GetCppThis(), inputString);
		}

		// Token: 0x0601040D RID: 66573
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_SetMaximumLineHeight_35(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the maximum height of a line of text as a
		/// percentage of the vertical area allocated to this
		/// scaled text actor. Defaults to 1.0.
		/// Only valid when TextScaleMode is PROP.
		/// </summary>
		// Token: 0x0601040E RID: 66574 RVA: 0x0016A4D1 File Offset: 0x001686D1
		public virtual void SetMaximumLineHeight(float _arg)
		{
			vtkTextActor.vtkTextActor_SetMaximumLineHeight_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0601040F RID: 66575
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_SetMinimumSize_36(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set/Get the minimum size in pixels for this actor.
		/// Defaults to 10,10.
		/// Only valid when TextScaleMode is PROP.
		/// </summary>
		// Token: 0x06010410 RID: 66576 RVA: 0x0016A4E1 File Offset: 0x001686E1
		public virtual void SetMinimumSize(int _arg1, int _arg2)
		{
			vtkTextActor.vtkTextActor_SetMinimumSize_36(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06010411 RID: 66577
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_SetMinimumSize_37(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the minimum size in pixels for this actor.
		/// Defaults to 10,10.
		/// Only valid when TextScaleMode is PROP.
		/// </summary>
		// Token: 0x06010412 RID: 66578 RVA: 0x0016A4F2 File Offset: 0x001686F2
		public void SetMinimumSize(IntPtr _arg)
		{
			vtkTextActor.vtkTextActor_SetMinimumSize_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06010413 RID: 66579
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_SetNonLinearFontScale_38(HandleRef pThis, double exponent, int target);

		/// <summary>
		/// Enable non-linear scaling of font sizes. This is useful in combination
		/// with scaled text. With small windows you want to use the entire scaled
		/// text area. With larger windows you want to reduce the font size some so
		/// that the entire area is not used. These values modify the computed font
		/// size as follows:
		/// newFontSize = pow(FontSize,exponent)*pow(target,1.0 - exponent)
		/// typically exponent should be around 0.7 and target should be around 10
		/// </summary>
		// Token: 0x06010414 RID: 66580 RVA: 0x0016A502 File Offset: 0x00168702
		public virtual void SetNonLinearFontScale(double exponent, int target)
		{
			vtkTextActor.vtkTextActor_SetNonLinearFontScale_38(base.GetCppThis(), exponent, target);
		}

		// Token: 0x06010415 RID: 66581
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_SetOrientation_39(HandleRef pThis, float orientation);

		/// <summary>
		/// Counterclockwise rotation around the Alignment point.
		/// Units are in degrees and defaults to 0.
		/// The orientation in the text property rotates the text in the
		/// texture map.  It will proba ly not give you the effect you
		/// desire.
		/// </summary>
		// Token: 0x06010416 RID: 66582 RVA: 0x0016A513 File Offset: 0x00168713
		public void SetOrientation(float orientation)
		{
			vtkTextActor.vtkTextActor_SetOrientation_39(base.GetCppThis(), orientation);
		}

		// Token: 0x06010417 RID: 66583
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_SetTextProperty_40(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the text property.
		/// </summary>
		// Token: 0x06010418 RID: 66584 RVA: 0x0016A524 File Offset: 0x00168724
		public virtual void SetTextProperty(vtkTextProperty p)
		{
			vtkTextActor.vtkTextActor_SetTextProperty_40(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x06010419 RID: 66585
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_SetTextScaleMode_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Set how text should be scaled.  If set to
		/// vtkTextActor::TEXT_SCALE_MODE_NONE, the font size will be fixed by the
		/// size given in TextProperty.  If set to vtkTextActor::TEXT_SCALE_MODE_PROP,
		/// the text will be scaled to fit exactly in the prop as specified by the
		/// position 1 &amp; 2 coordinates.  If set to
		/// vtkTextActor::TEXT_SCALE_MODE_VIEWPORT, the text will be scaled based on
		/// the size of the viewport it is displayed in.
		/// </summary>
		// Token: 0x0601041A RID: 66586 RVA: 0x0016A553 File Offset: 0x00168753
		public virtual void SetTextScaleMode(int _arg)
		{
			vtkTextActor.vtkTextActor_SetTextScaleMode_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0601041B RID: 66587
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_SetTextScaleModeToNone_42(HandleRef pThis);

		/// <summary>
		/// Set how text should be scaled.  If set to
		/// vtkTextActor::TEXT_SCALE_MODE_NONE, the font size will be fixed by the
		/// size given in TextProperty.  If set to vtkTextActor::TEXT_SCALE_MODE_PROP,
		/// the text will be scaled to fit exactly in the prop as specified by the
		/// position 1 &amp; 2 coordinates.  If set to
		/// vtkTextActor::TEXT_SCALE_MODE_VIEWPORT, the text will be scaled based on
		/// the size of the viewport it is displayed in.
		/// </summary>
		// Token: 0x0601041C RID: 66588 RVA: 0x0016A563 File Offset: 0x00168763
		public void SetTextScaleModeToNone()
		{
			vtkTextActor.vtkTextActor_SetTextScaleModeToNone_42(base.GetCppThis());
		}

		// Token: 0x0601041D RID: 66589
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_SetTextScaleModeToProp_43(HandleRef pThis);

		/// <summary>
		/// Set how text should be scaled.  If set to
		/// vtkTextActor::TEXT_SCALE_MODE_NONE, the font size will be fixed by the
		/// size given in TextProperty.  If set to vtkTextActor::TEXT_SCALE_MODE_PROP,
		/// the text will be scaled to fit exactly in the prop as specified by the
		/// position 1 &amp; 2 coordinates.  If set to
		/// vtkTextActor::TEXT_SCALE_MODE_VIEWPORT, the text will be scaled based on
		/// the size of the viewport it is displayed in.
		/// </summary>
		// Token: 0x0601041E RID: 66590 RVA: 0x0016A572 File Offset: 0x00168772
		public void SetTextScaleModeToProp()
		{
			vtkTextActor.vtkTextActor_SetTextScaleModeToProp_43(base.GetCppThis());
		}

		// Token: 0x0601041F RID: 66591
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_SetTextScaleModeToViewport_44(HandleRef pThis);

		/// <summary>
		/// Set how text should be scaled.  If set to
		/// vtkTextActor::TEXT_SCALE_MODE_NONE, the font size will be fixed by the
		/// size given in TextProperty.  If set to vtkTextActor::TEXT_SCALE_MODE_PROP,
		/// the text will be scaled to fit exactly in the prop as specified by the
		/// position 1 &amp; 2 coordinates.  If set to
		/// vtkTextActor::TEXT_SCALE_MODE_VIEWPORT, the text will be scaled based on
		/// the size of the viewport it is displayed in.
		/// </summary>
		// Token: 0x06010420 RID: 66592 RVA: 0x0016A581 File Offset: 0x00168781
		public void SetTextScaleModeToViewport()
		{
			vtkTextActor.vtkTextActor_SetTextScaleModeToViewport_44(base.GetCppThis());
		}

		// Token: 0x06010421 RID: 66593
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_SetUseBorderAlign_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on or off the UseBorderAlign option.
		/// When UseBorderAlign is on, the bounding rectangle is used to align the text,
		/// which is the proper behavior when using vtkTextRepresentation
		/// </summary>
		// Token: 0x06010422 RID: 66594 RVA: 0x0016A590 File Offset: 0x00168790
		public virtual void SetUseBorderAlign(int _arg)
		{
			vtkTextActor.vtkTextActor_SetUseBorderAlign_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06010423 RID: 66595
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_ShallowCopy_46(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of this text actor. Overloads the virtual
		/// vtkProp method.
		/// </summary>
		// Token: 0x06010424 RID: 66596 RVA: 0x0016A5A0 File Offset: 0x001687A0
		public override void ShallowCopy(vtkProp prop)
		{
			vtkTextActor.vtkTextActor_ShallowCopy_46(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06010425 RID: 66597
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_SpecifiedToDisplay_47(HandleRef pThis, IntPtr pos, HandleRef vport, int specified);

		/// <summary>
		/// This is just a simple coordinate conversion method used in the render
		/// process.
		/// </summary>
		// Token: 0x06010426 RID: 66598 RVA: 0x0016A5D0 File Offset: 0x001687D0
		public void SpecifiedToDisplay(IntPtr pos, vtkViewport vport, int specified)
		{
			vtkTextActor.vtkTextActor_SpecifiedToDisplay_47(base.GetCppThis(), pos, (vport == null) ? default(HandleRef) : vport.GetCppThis(), specified);
		}

		// Token: 0x06010427 RID: 66599
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_UseBorderAlignOff_48(HandleRef pThis);

		/// <summary>
		/// Turn on or off the UseBorderAlign option.
		/// When UseBorderAlign is on, the bounding rectangle is used to align the text,
		/// which is the proper behavior when using vtkTextRepresentation
		/// </summary>
		// Token: 0x06010428 RID: 66600 RVA: 0x0016A601 File Offset: 0x00168801
		public virtual void UseBorderAlignOff()
		{
			vtkTextActor.vtkTextActor_UseBorderAlignOff_48(base.GetCppThis());
		}

		// Token: 0x06010429 RID: 66601
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor_UseBorderAlignOn_49(HandleRef pThis);

		/// <summary>
		/// Turn on or off the UseBorderAlign option.
		/// When UseBorderAlign is on, the bounding rectangle is used to align the text,
		/// which is the proper behavior when using vtkTextRepresentation
		/// </summary>
		// Token: 0x0601042A RID: 66602 RVA: 0x0016A610 File Offset: 0x00168810
		public virtual void UseBorderAlignOn()
		{
			vtkTextActor.vtkTextActor_UseBorderAlignOn_49(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012E3 RID: 4835
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012E4 RID: 4836
		public new static readonly string MRClassNameKey = "class vtkTextActor";

		/// <summary>
		/// Set how text should be scaled.  If set to
		/// vtkTextActor::TEXT_SCALE_MODE_NONE, the font size will be fixed by the
		/// size given in TextProperty.  If set to vtkTextActor::TEXT_SCALE_MODE_PROP,
		/// the text will be scaled to fit exactly in the prop as specified by the
		/// position 1 &amp; 2 coordinates.  If set to
		/// vtkTextActor::TEXT_SCALE_MODE_VIEWPORT, the text will be scaled based on
		/// the size of the viewport it is displayed in.
		/// </summary>
		// Token: 0x020005D0 RID: 1488
		public enum TEXT_SCALE_MODE_NONE_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040012E6 RID: 4838
			TEXT_SCALE_MODE_NONE,
			/// <summary>enum member</summary>
			// Token: 0x040012E7 RID: 4839
			TEXT_SCALE_MODE_PROP,
			/// <summary>enum member</summary>
			// Token: 0x040012E8 RID: 4840
			TEXT_SCALE_MODE_VIEWPORT
		}
	}
}
