using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCaptionActor2D
	/// </summary>
	/// <remarks>
	///    draw text label associated with a point
	///
	/// vtkCaptionActor2D is a hybrid 2D/3D actor that is used to associate text
	/// with a point (the AttachmentPoint) in the scene. The caption can be
	/// drawn with a rectangular border and a leader connecting
	/// the caption to the attachment point. Optionally, the leader can be
	/// glyphed at its endpoint to create arrow heads or other indicators.
	///
	/// To use the caption actor, you normally specify the Position and Position2
	/// coordinates (these are inherited from the vtkActor2D superclass). (Note
	/// that Position2 can be set using vtkActor2D's SetWidth() and SetHeight()
	/// methods.)  Position and Position2 define the size of the caption, and a
	/// third point, the AttachmentPoint, defines a point that the caption is
	/// associated with.  You must also define the caption text,
	/// whether you want a border around the caption, and whether you want a
	/// leader from the caption to the attachment point. The font attributes of
	/// the text can be set through the vtkTextProperty associated to this actor.
	/// You also indicate whether you want
	/// the leader to be 2D or 3D. (2D leaders are always drawn over the
	/// underlying geometry. 3D leaders may be occluded by the geometry.) The
	/// leader may also be terminated by an optional glyph (e.g., arrow).
	///
	/// The trickiest part about using this class is setting Position, Position2,
	/// and AttachmentPoint correctly. These instance variables are
	/// vtkCoordinates, and can be set up in various ways. In default usage, the
	/// AttachmentPoint is defined in the world coordinate system, Position is the
	/// lower-left corner of the caption and relative to AttachmentPoint (defined
	/// in display coordaintes, i.e., pixels), and Position2 is relative to
	/// Position and is the upper-right corner (also in display
	/// coordinates). However, the user has full control over the coordinates, and
	/// can do things like place the caption in a fixed position in the renderer,
	/// with the leader moving with the AttachmentPoint.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLegendBoxActor vtkTextMapper vtkTextActor vtkTextProperty
	/// vtkCoordinate
	/// </seealso>
	// Token: 0x020003BF RID: 959
	public class vtkCaptionActor2D : vtkActor2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600B10C RID: 45324 RVA: 0x000FA5D5 File Offset: 0x000F87D5
		static vtkCaptionActor2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCaptionActor2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCaptionActor2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600B10D RID: 45325 RVA: 0x000FA5FD File Offset: 0x000F87FD
		public vtkCaptionActor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600B10E RID: 45326
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionActor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B10F RID: 45327 RVA: 0x000FA60C File Offset: 0x000F880C
		public new static vtkCaptionActor2D New()
		{
			vtkCaptionActor2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCaptionActor2D.vtkCaptionActor2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B110 RID: 45328 RVA: 0x000FA660 File Offset: 0x000F8860
		public vtkCaptionActor2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCaptionActor2D.vtkCaptionActor2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600B111 RID: 45329 RVA: 0x000FA6A4 File Offset: 0x000F88A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600B112 RID: 45330
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_AttachEdgeOnlyOff_01(HandleRef pThis);

		/// <summary>
		/// Enable/disable whether to attach the arrow only to the edge,
		/// NOT the vertices of the caption border.
		/// </summary>
		// Token: 0x0600B113 RID: 45331 RVA: 0x000FA6AF File Offset: 0x000F88AF
		public virtual void AttachEdgeOnlyOff()
		{
			vtkCaptionActor2D.vtkCaptionActor2D_AttachEdgeOnlyOff_01(base.GetCppThis());
		}

		// Token: 0x0600B114 RID: 45332
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_AttachEdgeOnlyOn_02(HandleRef pThis);

		/// <summary>
		/// Enable/disable whether to attach the arrow only to the edge,
		/// NOT the vertices of the caption border.
		/// </summary>
		// Token: 0x0600B115 RID: 45333 RVA: 0x000FA6BE File Offset: 0x000F88BE
		public virtual void AttachEdgeOnlyOn()
		{
			vtkCaptionActor2D.vtkCaptionActor2D_AttachEdgeOnlyOn_02(base.GetCppThis());
		}

		// Token: 0x0600B116 RID: 45334
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_BorderOff_03(HandleRef pThis);

		/// <summary>
		/// Enable/disable the placement of a border around the text.
		/// </summary>
		// Token: 0x0600B117 RID: 45335 RVA: 0x000FA6CD File Offset: 0x000F88CD
		public virtual void BorderOff()
		{
			vtkCaptionActor2D.vtkCaptionActor2D_BorderOff_03(base.GetCppThis());
		}

		// Token: 0x0600B118 RID: 45336
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_BorderOn_04(HandleRef pThis);

		/// <summary>
		/// Enable/disable the placement of a border around the text.
		/// </summary>
		// Token: 0x0600B119 RID: 45337 RVA: 0x000FA6DC File Offset: 0x000F88DC
		public virtual void BorderOn()
		{
			vtkCaptionActor2D.vtkCaptionActor2D_BorderOn_04(base.GetCppThis());
		}

		// Token: 0x0600B11A RID: 45338
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionActor2D_GetAttachEdgeOnly_05(HandleRef pThis);

		/// <summary>
		/// Enable/disable whether to attach the arrow only to the edge,
		/// NOT the vertices of the caption border.
		/// </summary>
		// Token: 0x0600B11B RID: 45339 RVA: 0x000FA6EC File Offset: 0x000F88EC
		public virtual int GetAttachEdgeOnly()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetAttachEdgeOnly_05(base.GetCppThis());
		}

		// Token: 0x0600B11C RID: 45340
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionActor2D_GetAttachmentPoint_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the attachment point for the caption. By default, the attachment
		/// point is defined in world coordinates, but this can be changed using
		/// vtkCoordinate methods.
		/// </summary>
		// Token: 0x0600B11D RID: 45341 RVA: 0x000FA70C File Offset: 0x000F890C
		public virtual double[] GetAttachmentPoint()
		{
			IntPtr intPtr = vtkCaptionActor2D.vtkCaptionActor2D_GetAttachmentPoint_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B11E RID: 45342
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionActor2D_GetAttachmentPointCoordinate_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the attachment point for the caption. By default, the attachment
		/// point is defined in world coordinates, but this can be changed using
		/// vtkCoordinate methods.
		/// </summary>
		// Token: 0x0600B11F RID: 45343 RVA: 0x000FA754 File Offset: 0x000F8954
		public virtual vtkCoordinate GetAttachmentPointCoordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCaptionActor2D.vtkCaptionActor2D_GetAttachmentPointCoordinate_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		// Token: 0x0600B120 RID: 45344
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionActor2D_GetBorder_08(HandleRef pThis);

		/// <summary>
		/// Enable/disable the placement of a border around the text.
		/// </summary>
		// Token: 0x0600B121 RID: 45345 RVA: 0x000FA7C4 File Offset: 0x000F89C4
		public virtual int GetBorder()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetBorder_08(base.GetCppThis());
		}

		// Token: 0x0600B122 RID: 45346
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionActor2D_GetCaption_09(HandleRef pThis);

		/// <summary>
		/// Define the text to be placed in the caption. The text can be multiple
		/// lines (separated by "\n").
		/// </summary>
		// Token: 0x0600B123 RID: 45347 RVA: 0x000FA7E4 File Offset: 0x000F89E4
		public virtual string GetCaption()
		{
			string s = Marshal.PtrToStringAnsi(vtkCaptionActor2D.vtkCaptionActor2D_GetCaption_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B124 RID: 45348
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionActor2D_GetCaptionTextProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the text property.
		/// </summary>
		// Token: 0x0600B125 RID: 45349 RVA: 0x000FA820 File Offset: 0x000F8A20
		public virtual vtkTextProperty GetCaptionTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCaptionActor2D.vtkCaptionActor2D_GetCaptionTextProperty_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B126 RID: 45350
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionActor2D_GetLeader_11(HandleRef pThis);

		/// <summary>
		/// Enable/disable drawing a "line" from the caption to the
		/// attachment point.
		/// </summary>
		// Token: 0x0600B127 RID: 45351 RVA: 0x000FA890 File Offset: 0x000F8A90
		public virtual int GetLeader()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetLeader_11(base.GetCppThis());
		}

		// Token: 0x0600B128 RID: 45352
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionActor2D_GetLeaderGlyph_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a glyph to be used as the leader "head". This could be something
		/// like an arrow or sphere. If not specified, no glyph is drawn. Note that
		/// the glyph is assumed to be aligned along the x-axis and is rotated about
		/// the origin. SetLeaderGlyphData() directly uses the polydata without
		/// setting a pipeline connection. SetLeaderGlyphConnection() sets up a
		/// pipeline connection and causes an update to the input during render.
		/// </summary>
		// Token: 0x0600B129 RID: 45353 RVA: 0x000FA8B0 File Offset: 0x000F8AB0
		public virtual vtkPolyData GetLeaderGlyph()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCaptionActor2D.vtkCaptionActor2D_GetLeaderGlyph_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0600B12A RID: 45354
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCaptionActor2D_GetLeaderGlyphSize_13(HandleRef pThis);

		/// <summary>
		/// Specify the relative size of the leader head. This is expressed as a
		/// fraction of the size (diagonal length) of the renderer. The leader
		/// head is automatically scaled so that window resize, zooming or other
		/// camera motion results in proportional changes in size to the leader
		/// glyph.
		/// </summary>
		// Token: 0x0600B12B RID: 45355 RVA: 0x000FA920 File Offset: 0x000F8B20
		public virtual double GetLeaderGlyphSize()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetLeaderGlyphSize_13(base.GetCppThis());
		}

		// Token: 0x0600B12C RID: 45356
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCaptionActor2D_GetLeaderGlyphSizeMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Specify the relative size of the leader head. This is expressed as a
		/// fraction of the size (diagonal length) of the renderer. The leader
		/// head is automatically scaled so that window resize, zooming or other
		/// camera motion results in proportional changes in size to the leader
		/// glyph.
		/// </summary>
		// Token: 0x0600B12D RID: 45357 RVA: 0x000FA940 File Offset: 0x000F8B40
		public virtual double GetLeaderGlyphSizeMaxValue()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetLeaderGlyphSizeMaxValue_14(base.GetCppThis());
		}

		// Token: 0x0600B12E RID: 45358
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCaptionActor2D_GetLeaderGlyphSizeMinValue_15(HandleRef pThis);

		/// <summary>
		/// Specify the relative size of the leader head. This is expressed as a
		/// fraction of the size (diagonal length) of the renderer. The leader
		/// head is automatically scaled so that window resize, zooming or other
		/// camera motion results in proportional changes in size to the leader
		/// glyph.
		/// </summary>
		// Token: 0x0600B12F RID: 45359 RVA: 0x000FA960 File Offset: 0x000F8B60
		public virtual double GetLeaderGlyphSizeMinValue()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetLeaderGlyphSizeMinValue_15(base.GetCppThis());
		}

		// Token: 0x0600B130 RID: 45360
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionActor2D_GetMaximumLeaderGlyphSize_16(HandleRef pThis);

		/// <summary>
		/// Specify the maximum size of the leader head (if any) in pixels. This
		/// is used in conjunction with LeaderGlyphSize to cap the maximum size of
		/// the LeaderGlyph.
		/// </summary>
		// Token: 0x0600B131 RID: 45361 RVA: 0x000FA980 File Offset: 0x000F8B80
		public virtual int GetMaximumLeaderGlyphSize()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetMaximumLeaderGlyphSize_16(base.GetCppThis());
		}

		// Token: 0x0600B132 RID: 45362
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionActor2D_GetMaximumLeaderGlyphSizeMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Specify the maximum size of the leader head (if any) in pixels. This
		/// is used in conjunction with LeaderGlyphSize to cap the maximum size of
		/// the LeaderGlyph.
		/// </summary>
		// Token: 0x0600B133 RID: 45363 RVA: 0x000FA9A0 File Offset: 0x000F8BA0
		public virtual int GetMaximumLeaderGlyphSizeMaxValue()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetMaximumLeaderGlyphSizeMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0600B134 RID: 45364
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionActor2D_GetMaximumLeaderGlyphSizeMinValue_18(HandleRef pThis);

		/// <summary>
		/// Specify the maximum size of the leader head (if any) in pixels. This
		/// is used in conjunction with LeaderGlyphSize to cap the maximum size of
		/// the LeaderGlyph.
		/// </summary>
		// Token: 0x0600B135 RID: 45365 RVA: 0x000FA9C0 File Offset: 0x000F8BC0
		public virtual int GetMaximumLeaderGlyphSizeMinValue()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetMaximumLeaderGlyphSizeMinValue_18(base.GetCppThis());
		}

		// Token: 0x0600B136 RID: 45366
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCaptionActor2D_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B137 RID: 45367 RVA: 0x000FA9E0 File Offset: 0x000F8BE0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x0600B138 RID: 45368
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCaptionActor2D_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B139 RID: 45369 RVA: 0x000FAA00 File Offset: 0x000F8C00
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x0600B13A RID: 45370
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionActor2D_GetPadding_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the caption and the border. The value
		/// is specified in pixels.
		/// </summary>
		// Token: 0x0600B13B RID: 45371 RVA: 0x000FAA1C File Offset: 0x000F8C1C
		public virtual int GetPadding()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetPadding_21(base.GetCppThis());
		}

		// Token: 0x0600B13C RID: 45372
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionActor2D_GetPaddingMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the caption and the border. The value
		/// is specified in pixels.
		/// </summary>
		// Token: 0x0600B13D RID: 45373 RVA: 0x000FAA3C File Offset: 0x000F8C3C
		public virtual int GetPaddingMaxValue()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetPaddingMaxValue_22(base.GetCppThis());
		}

		// Token: 0x0600B13E RID: 45374
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionActor2D_GetPaddingMinValue_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the caption and the border. The value
		/// is specified in pixels.
		/// </summary>
		// Token: 0x0600B13F RID: 45375 RVA: 0x000FAA5C File Offset: 0x000F8C5C
		public virtual int GetPaddingMinValue()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetPaddingMinValue_23(base.GetCppThis());
		}

		// Token: 0x0600B140 RID: 45376
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionActor2D_GetTextActor_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the text actor used by the caption. This is useful if you want to control
		/// justification and other characteristics of the text actor.
		/// </summary>
		// Token: 0x0600B141 RID: 45377 RVA: 0x000FAA7C File Offset: 0x000F8C7C
		public virtual vtkTextActor GetTextActor()
		{
			vtkTextActor vtkTextActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCaptionActor2D.vtkCaptionActor2D_GetTextActor_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B142 RID: 45378
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionActor2D_GetThreeDimensionalLeader_25(HandleRef pThis);

		/// <summary>
		/// Indicate whether the leader is 2D (no hidden line) or 3D (z-buffered).
		/// </summary>
		// Token: 0x0600B143 RID: 45379 RVA: 0x000FAAEC File Offset: 0x000F8CEC
		public virtual int GetThreeDimensionalLeader()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_GetThreeDimensionalLeader_25(base.GetCppThis());
		}

		// Token: 0x0600B144 RID: 45380
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionActor2D_HasTranslucentPolygonalGeometry_26(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600B145 RID: 45381 RVA: 0x000FAB0C File Offset: 0x000F8D0C
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_HasTranslucentPolygonalGeometry_26(base.GetCppThis());
		}

		// Token: 0x0600B146 RID: 45382
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionActor2D_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B147 RID: 45383 RVA: 0x000FAB2C File Offset: 0x000F8D2C
		public override int IsA(string type)
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x0600B148 RID: 45384
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionActor2D_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B149 RID: 45385 RVA: 0x000FAB4C File Offset: 0x000F8D4C
		public new static int IsTypeOf(string type)
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_IsTypeOf_28(type);
		}

		// Token: 0x0600B14A RID: 45386
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_LeaderOff_29(HandleRef pThis);

		/// <summary>
		/// Enable/disable drawing a "line" from the caption to the
		/// attachment point.
		/// </summary>
		// Token: 0x0600B14B RID: 45387 RVA: 0x000FAB66 File Offset: 0x000F8D66
		public virtual void LeaderOff()
		{
			vtkCaptionActor2D.vtkCaptionActor2D_LeaderOff_29(base.GetCppThis());
		}

		// Token: 0x0600B14C RID: 45388
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_LeaderOn_30(HandleRef pThis);

		/// <summary>
		/// Enable/disable drawing a "line" from the caption to the
		/// attachment point.
		/// </summary>
		// Token: 0x0600B14D RID: 45389 RVA: 0x000FAB75 File Offset: 0x000F8D75
		public virtual void LeaderOn()
		{
			vtkCaptionActor2D.vtkCaptionActor2D_LeaderOn_30(base.GetCppThis());
		}

		// Token: 0x0600B14E RID: 45390
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionActor2D_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B14F RID: 45391 RVA: 0x000FAB84 File Offset: 0x000F8D84
		public new vtkCaptionActor2D NewInstance()
		{
			vtkCaptionActor2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCaptionActor2D.vtkCaptionActor2D_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600B150 RID: 45392
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_ReleaseGraphicsResources_33(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600B151 RID: 45393 RVA: 0x000FABE0 File Offset: 0x000F8DE0
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_ReleaseGraphicsResources_33(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B152 RID: 45394
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionActor2D_RenderOpaqueGeometry_34(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
		/// Draw the legend box to the screen.
		/// </summary>
		// Token: 0x0600B153 RID: 45395 RVA: 0x000FAC10 File Offset: 0x000F8E10
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_RenderOpaqueGeometry_34(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B154 RID: 45396
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionActor2D_RenderOverlay_35(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
		/// Draw the legend box to the screen.
		/// </summary>
		// Token: 0x0600B155 RID: 45397 RVA: 0x000FAC44 File Offset: 0x000F8E44
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_RenderOverlay_35(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B156 RID: 45398
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionActor2D_RenderTranslucentPolygonalGeometry_36(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
		/// Draw the legend box to the screen.
		/// </summary>
		// Token: 0x0600B157 RID: 45399 RVA: 0x000FAC78 File Offset: 0x000F8E78
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkCaptionActor2D.vtkCaptionActor2D_RenderTranslucentPolygonalGeometry_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B158 RID: 45400
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionActor2D_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B159 RID: 45401 RVA: 0x000FACAC File Offset: 0x000F8EAC
		public new static vtkCaptionActor2D SafeDownCast(vtkObjectBase o)
		{
			vtkCaptionActor2D vtkCaptionActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCaptionActor2D.vtkCaptionActor2D_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCaptionActor2D = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCaptionActor2D.Register(null);
				}
			}
			return vtkCaptionActor2D;
		}

		// Token: 0x0600B15A RID: 45402
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_SetAttachEdgeOnly_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable whether to attach the arrow only to the edge,
		/// NOT the vertices of the caption border.
		/// </summary>
		// Token: 0x0600B15B RID: 45403 RVA: 0x000FAD2B File Offset: 0x000F8F2B
		public virtual void SetAttachEdgeOnly(int _arg)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetAttachEdgeOnly_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B15C RID: 45404
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_SetAttachmentPoint_39(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Set/Get the attachment point for the caption. By default, the attachment
		/// point is defined in world coordinates, but this can be changed using
		/// vtkCoordinate methods.
		/// </summary>
		// Token: 0x0600B15D RID: 45405 RVA: 0x000FAD3B File Offset: 0x000F8F3B
		public virtual void SetAttachmentPoint(IntPtr x)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetAttachmentPoint_39(base.GetCppThis(), x);
		}

		// Token: 0x0600B15E RID: 45406
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_SetAttachmentPoint_40(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the attachment point for the caption. By default, the attachment
		/// point is defined in world coordinates, but this can be changed using
		/// vtkCoordinate methods.
		/// </summary>
		// Token: 0x0600B15F RID: 45407 RVA: 0x000FAD4B File Offset: 0x000F8F4B
		public virtual void SetAttachmentPoint(double x, double y, double z)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetAttachmentPoint_40(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600B160 RID: 45408
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_SetBorder_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable the placement of a border around the text.
		/// </summary>
		// Token: 0x0600B161 RID: 45409 RVA: 0x000FAD5D File Offset: 0x000F8F5D
		public virtual void SetBorder(int _arg)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetBorder_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B162 RID: 45410
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_SetCaption_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string caption);

		/// <summary>
		/// Define the text to be placed in the caption. The text can be multiple
		/// lines (separated by "\n").
		/// </summary>
		// Token: 0x0600B163 RID: 45411 RVA: 0x000FAD6D File Offset: 0x000F8F6D
		public virtual void SetCaption(string caption)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetCaption_42(base.GetCppThis(), caption);
		}

		// Token: 0x0600B164 RID: 45412
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_SetCaptionTextProperty_43(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the text property.
		/// </summary>
		// Token: 0x0600B165 RID: 45413 RVA: 0x000FAD80 File Offset: 0x000F8F80
		public virtual void SetCaptionTextProperty(vtkTextProperty p)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetCaptionTextProperty_43(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B166 RID: 45414
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_SetLeader_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable drawing a "line" from the caption to the
		/// attachment point.
		/// </summary>
		// Token: 0x0600B167 RID: 45415 RVA: 0x000FADAF File Offset: 0x000F8FAF
		public virtual void SetLeader(int _arg)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetLeader_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B168 RID: 45416
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_SetLeaderGlyphConnection_45(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify a glyph to be used as the leader "head". This could be something
		/// like an arrow or sphere. If not specified, no glyph is drawn. Note that
		/// the glyph is assumed to be aligned along the x-axis and is rotated about
		/// the origin. SetLeaderGlyphData() directly uses the polydata without
		/// setting a pipeline connection. SetLeaderGlyphConnection() sets up a
		/// pipeline connection and causes an update to the input during render.
		/// </summary>
		// Token: 0x0600B169 RID: 45417 RVA: 0x000FADC0 File Offset: 0x000F8FC0
		public virtual void SetLeaderGlyphConnection(vtkAlgorithmOutput arg0)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetLeaderGlyphConnection_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B16A RID: 45418
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_SetLeaderGlyphData_46(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify a glyph to be used as the leader "head". This could be something
		/// like an arrow or sphere. If not specified, no glyph is drawn. Note that
		/// the glyph is assumed to be aligned along the x-axis and is rotated about
		/// the origin. SetLeaderGlyphData() directly uses the polydata without
		/// setting a pipeline connection. SetLeaderGlyphConnection() sets up a
		/// pipeline connection and causes an update to the input during render.
		/// </summary>
		// Token: 0x0600B16B RID: 45419 RVA: 0x000FADF0 File Offset: 0x000F8FF0
		public virtual void SetLeaderGlyphData(vtkPolyData arg0)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetLeaderGlyphData_46(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B16C RID: 45420
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_SetLeaderGlyphSize_47(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the relative size of the leader head. This is expressed as a
		/// fraction of the size (diagonal length) of the renderer. The leader
		/// head is automatically scaled so that window resize, zooming or other
		/// camera motion results in proportional changes in size to the leader
		/// glyph.
		/// </summary>
		// Token: 0x0600B16D RID: 45421 RVA: 0x000FAE1F File Offset: 0x000F901F
		public virtual void SetLeaderGlyphSize(double _arg)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetLeaderGlyphSize_47(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B16E RID: 45422
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_SetMaximumLeaderGlyphSize_48(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the maximum size of the leader head (if any) in pixels. This
		/// is used in conjunction with LeaderGlyphSize to cap the maximum size of
		/// the LeaderGlyph.
		/// </summary>
		// Token: 0x0600B16F RID: 45423 RVA: 0x000FAE2F File Offset: 0x000F902F
		public virtual void SetMaximumLeaderGlyphSize(int _arg)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetMaximumLeaderGlyphSize_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B170 RID: 45424
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_SetPadding_49(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the padding between the caption and the border. The value
		/// is specified in pixels.
		/// </summary>
		// Token: 0x0600B171 RID: 45425 RVA: 0x000FAE3F File Offset: 0x000F903F
		public virtual void SetPadding(int _arg)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetPadding_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B172 RID: 45426
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_SetThreeDimensionalLeader_50(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether the leader is 2D (no hidden line) or 3D (z-buffered).
		/// </summary>
		// Token: 0x0600B173 RID: 45427 RVA: 0x000FAE4F File Offset: 0x000F904F
		public virtual void SetThreeDimensionalLeader(int _arg)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_SetThreeDimensionalLeader_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B174 RID: 45428
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_ShallowCopy_51(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of this scaled text actor. Overloads the virtual
		/// vtkProp method.
		/// </summary>
		// Token: 0x0600B175 RID: 45429 RVA: 0x000FAE60 File Offset: 0x000F9060
		public override void ShallowCopy(vtkProp prop)
		{
			vtkCaptionActor2D.vtkCaptionActor2D_ShallowCopy_51(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x0600B176 RID: 45430
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_ThreeDimensionalLeaderOff_52(HandleRef pThis);

		/// <summary>
		/// Indicate whether the leader is 2D (no hidden line) or 3D (z-buffered).
		/// </summary>
		// Token: 0x0600B177 RID: 45431 RVA: 0x000FAE8F File Offset: 0x000F908F
		public virtual void ThreeDimensionalLeaderOff()
		{
			vtkCaptionActor2D.vtkCaptionActor2D_ThreeDimensionalLeaderOff_52(base.GetCppThis());
		}

		// Token: 0x0600B178 RID: 45432
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionActor2D_ThreeDimensionalLeaderOn_53(HandleRef pThis);

		/// <summary>
		/// Indicate whether the leader is 2D (no hidden line) or 3D (z-buffered).
		/// </summary>
		// Token: 0x0600B179 RID: 45433 RVA: 0x000FAE9E File Offset: 0x000F909E
		public virtual void ThreeDimensionalLeaderOn()
		{
			vtkCaptionActor2D.vtkCaptionActor2D_ThreeDimensionalLeaderOn_53(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DC1 RID: 3521
		public new const string MRFullTypeName = "Kitware.VTK.vtkCaptionActor2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DC2 RID: 3522
		public new static readonly string MRClassNameKey = "class vtkCaptionActor2D";
	}
}
