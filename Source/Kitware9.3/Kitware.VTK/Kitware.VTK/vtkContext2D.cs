using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContext2D
	/// </summary>
	/// <remarks>
	///    Class for drawing 2D primitives to a graphical context.
	///
	///
	/// This defines the interface for drawing onto a 2D context. The context must
	/// be set up with a vtkContextDevice2D derived class that provides the functions
	/// to facilitate the low level calls to the context. Currently only an OpenGL
	/// based device is provided, but this could be extended in the future.
	/// </remarks>
	// Token: 0x020007AC RID: 1964
	public class vtkContext2D : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601422B RID: 82475 RVA: 0x001C7337 File Offset: 0x001C5537
		static vtkContext2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContext2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContext2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601422C RID: 82476 RVA: 0x001C735F File Offset: 0x001C555F
		public vtkContext2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601422D RID: 82477
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContext2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a 2D Painter object.
		/// </summary>
		// Token: 0x0601422E RID: 82478 RVA: 0x001C7370 File Offset: 0x001C5570
		public new static vtkContext2D New()
		{
			vtkContext2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContext2D.vtkContext2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContext2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a 2D Painter object.
		/// </summary>
		// Token: 0x0601422F RID: 82479 RVA: 0x001C73C4 File Offset: 0x001C55C4
		public vtkContext2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkContext2D.vtkContext2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014230 RID: 82480 RVA: 0x001C7408 File Offset: 0x001C5608
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014231 RID: 82481
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_AppendTransform_01(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// Append the transform for the context, the underlying device will use the
		/// matrix of the transform. Note, this is set immediately, later changes to
		/// the matrix will have no effect until it is set again. The matrix of the
		/// transform will multiply the current context transform.
		/// </summary>
		// Token: 0x06014232 RID: 82482 RVA: 0x001C7414 File Offset: 0x001C5614
		public void AppendTransform(vtkTransform2D transform)
		{
			vtkContext2D.vtkContext2D_AppendTransform_01(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x06014233 RID: 82483
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_ApplyBrush_02(HandleRef pThis, HandleRef brush);

		/// <summary>
		/// Apply the supplied brush which controls the outlines of shapes, as well as
		/// lines, points and related primitives. This makes a deep copy of the vtkBrush
		/// object in the vtkContext2D, it does not hold a pointer to the supplied object.
		/// </summary>
		// Token: 0x06014234 RID: 82484 RVA: 0x001C7444 File Offset: 0x001C5644
		public void ApplyBrush(vtkBrush brush)
		{
			vtkContext2D.vtkContext2D_ApplyBrush_02(base.GetCppThis(), (brush == null) ? default(HandleRef) : brush.GetCppThis());
		}

		// Token: 0x06014235 RID: 82485
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_ApplyId_03(HandleRef pThis, long id);

		/// <summary>
		/// Apply id as a color.
		/// </summary>
		// Token: 0x06014236 RID: 82486 RVA: 0x001C7473 File Offset: 0x001C5673
		public void ApplyId(long id)
		{
			vtkContext2D.vtkContext2D_ApplyId_03(base.GetCppThis(), id);
		}

		// Token: 0x06014237 RID: 82487
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_ApplyPen_04(HandleRef pThis, HandleRef pen);

		/// <summary>
		/// Apply the supplied pen which controls the outlines of shapes, as well as
		/// lines, points and related primitives. This makes a deep copy of the vtkPen
		/// object in the vtkContext2D, it does not hold a pointer to the supplied object.
		/// </summary>
		// Token: 0x06014238 RID: 82488 RVA: 0x001C7484 File Offset: 0x001C5684
		public void ApplyPen(vtkPen pen)
		{
			vtkContext2D.vtkContext2D_ApplyPen_04(base.GetCppThis(), (pen == null) ? default(HandleRef) : pen.GetCppThis());
		}

		// Token: 0x06014239 RID: 82489
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_ApplyTextProp_05(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Apply the supplied text property which controls how text is rendered.
		/// This makes a deep copy of the vtkTextProperty object in the vtkContext2D,
		/// it does not hold a pointer to the supplied object.
		/// </summary>
		// Token: 0x0601423A RID: 82490 RVA: 0x001C74B4 File Offset: 0x001C56B4
		public void ApplyTextProp(vtkTextProperty prop)
		{
			vtkContext2D.vtkContext2D_ApplyTextProp_05(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x0601423B RID: 82491
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_BufferIdModeBegin_06(HandleRef pThis, HandleRef bufferId);

		/// <summary>
		/// Start BufferId creation Mode.
		/// \pre not_yet: !GetBufferIdMode()
		/// \pre bufferId_exists: bufferId!=0
		/// \post started: GetBufferIdMode()
		/// </summary>
		// Token: 0x0601423C RID: 82492 RVA: 0x001C74E4 File Offset: 0x001C56E4
		public void BufferIdModeBegin(vtkAbstractContextBufferId bufferId)
		{
			vtkContext2D.vtkContext2D_BufferIdModeBegin_06(base.GetCppThis(), (bufferId == null) ? default(HandleRef) : bufferId.GetCppThis());
		}

		// Token: 0x0601423D RID: 82493
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_BufferIdModeEnd_07(HandleRef pThis);

		/// <summary>
		/// Finalize BufferId creation Mode. It makes sure that the content of the
		/// bufferId passed in argument of BufferIdModeBegin() is correctly set.
		/// \pre started: GetBufferIdMode()
		/// \post done: !GetBufferIdMode()
		/// </summary>
		// Token: 0x0601423E RID: 82494 RVA: 0x001C7513 File Offset: 0x001C5713
		public void BufferIdModeEnd()
		{
			vtkContext2D.vtkContext2D_BufferIdModeEnd_07(base.GetCppThis());
		}

		// Token: 0x0601423F RID: 82495
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContext2D_ComputeFontSizeForBoundedString_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, float width, float height);

		/// <summary>
		/// Calculate the largest possible font size where the supplied string will fit
		/// within the specified bounds.  In addition to being returned, this font size
		/// is also used to update the vtkTextProperty used by this object.
		/// NOTE: text rotation is ignored for the purposes of this function.
		/// </summary>
		// Token: 0x06014240 RID: 82496 RVA: 0x001C7524 File Offset: 0x001C5724
		public int ComputeFontSizeForBoundedString(string arg0, float width, float height)
		{
			return vtkContext2D.vtkContext2D_ComputeFontSizeForBoundedString_08(base.GetCppThis(), arg0, width, height);
		}

		// Token: 0x06014241 RID: 82497
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_ComputeJustifiedStringBounds_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, IntPtr bounds);

		/// <summary>
		/// Compute the bounds of the supplied string while taking into account the
		/// justification and rotation of the currently applied text property.
		/// </summary>
		// Token: 0x06014242 RID: 82498 RVA: 0x001C7546 File Offset: 0x001C5746
		public void ComputeJustifiedStringBounds(string arg0, IntPtr bounds)
		{
			vtkContext2D.vtkContext2D_ComputeJustifiedStringBounds_09(base.GetCppThis(), arg0, bounds);
		}

		// Token: 0x06014243 RID: 82499
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_ComputeStringBounds_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, HandleRef bounds);

		/// <summary>
		/// Compute the bounds of the supplied string. The bounds will be copied to the
		/// supplied bounds variable, the first two elements are the bottom corner of
		/// the string, and the second two elements are the width and height of the
		/// bounding box.
		///
		/// NOTE:the text justification from the current text property is
		/// NOT considered when computing these bounds.
		/// </summary>
		// Token: 0x06014244 RID: 82500 RVA: 0x001C7558 File Offset: 0x001C5758
		public void ComputeStringBounds(string arg0, vtkPoints2D bounds)
		{
			vtkContext2D.vtkContext2D_ComputeStringBounds_10(base.GetCppThis(), arg0, (bounds == null) ? default(HandleRef) : bounds.GetCppThis());
		}

		// Token: 0x06014245 RID: 82501
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_ComputeStringBounds_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, IntPtr bounds);

		/// <summary>
		/// Compute the bounds of the supplied string. The bounds will be copied to the
		/// supplied bounds variable, the first two elements are the bottom corner of
		/// the string, and the second two elements are the width and height of the
		/// bounding box.
		///
		/// NOTE:the text justification from the current text property is
		/// NOT considered when computing these bounds.
		/// </summary>
		// Token: 0x06014246 RID: 82502 RVA: 0x001C7588 File Offset: 0x001C5788
		public void ComputeStringBounds(string arg0, IntPtr bounds)
		{
			vtkContext2D.vtkContext2D_ComputeStringBounds_11(base.GetCppThis(), arg0, bounds);
		}

		// Token: 0x06014247 RID: 82503
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawArc_12(HandleRef pThis, float x, float y, float r, float startAngle, float stopAngle);

		/// <summary>
		/// Draw a circular arc with center at x,y with radius r between angles
		/// startAngle and stopAngle (expressed in degrees).
		/// \pre positive_radius: r&gt;=0
		/// </summary>
		// Token: 0x06014248 RID: 82504 RVA: 0x001C7599 File Offset: 0x001C5799
		public void DrawArc(float x, float y, float r, float startAngle, float stopAngle)
		{
			vtkContext2D.vtkContext2D_DrawArc_12(base.GetCppThis(), x, y, r, startAngle, stopAngle);
		}

		// Token: 0x06014249 RID: 82505
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawEllipse_13(HandleRef pThis, float x, float y, float rx, float ry);

		/// <summary>
		/// Draw an ellipse with center at x, y and radii rx, ry.
		/// \pre positive_rx: rx&gt;=0
		/// \pre positive_ry: ry&gt;=0
		/// </summary>
		// Token: 0x0601424A RID: 82506 RVA: 0x001C75AF File Offset: 0x001C57AF
		public void DrawEllipse(float x, float y, float rx, float ry)
		{
			vtkContext2D.vtkContext2D_DrawEllipse_13(base.GetCppThis(), x, y, rx, ry);
		}

		// Token: 0x0601424B RID: 82507
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawEllipseWedge_14(HandleRef pThis, float x, float y, float outRx, float outRy, float inRx, float inRy, float startAngle, float stopAngle);

		/// <summary>
		/// Draw an elliptic wedge with center at x, y, outer radii outRx, outRy,
		/// inner radii inRx, inRy between angles startAngle and stopAngle
		/// (expressed in degrees).
		/// \pre positive_outRx: outRx&gt;=0
		/// \pre positive_outRy: outRy&gt;=0
		/// \pre positive_inRx: inRx&gt;=0
		/// \pre positive_inRy: inRy&gt;=0
		/// \pre ordered_rx: inRx&lt;=outRx
		/// \pre ordered_ry: inRy&lt;=outRy
		/// </summary>
		// Token: 0x0601424C RID: 82508 RVA: 0x001C75C4 File Offset: 0x001C57C4
		public void DrawEllipseWedge(float x, float y, float outRx, float outRy, float inRx, float inRy, float startAngle, float stopAngle)
		{
			vtkContext2D.vtkContext2D_DrawEllipseWedge_14(base.GetCppThis(), x, y, outRx, outRy, inRx, inRy, startAngle, stopAngle);
		}

		// Token: 0x0601424D RID: 82509
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawEllipticArc_15(HandleRef pThis, float x, float y, float rX, float rY, float startAngle, float stopAngle);

		/// <summary>
		/// Draw an elliptic arc with center at x,y with radii rX and rY between
		/// angles startAngle and stopAngle (expressed in degrees).
		/// \pre positive_rX: rX&gt;=0
		/// \pre positive_rY: rY&gt;=0
		/// </summary>
		// Token: 0x0601424E RID: 82510 RVA: 0x001C75EB File Offset: 0x001C57EB
		public void DrawEllipticArc(float x, float y, float rX, float rY, float startAngle, float stopAngle)
		{
			vtkContext2D.vtkContext2D_DrawEllipticArc_15(base.GetCppThis(), x, y, rX, rY, startAngle, stopAngle);
		}

		// Token: 0x0601424F RID: 82511
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawImage_16(HandleRef pThis, float x, float y, HandleRef image);

		/// <summary>
		/// Draw the supplied image at the given x, y location (bottom corner).
		/// </summary>
		// Token: 0x06014250 RID: 82512 RVA: 0x001C7604 File Offset: 0x001C5804
		public void DrawImage(float x, float y, vtkImageData image)
		{
			vtkContext2D.vtkContext2D_DrawImage_16(base.GetCppThis(), x, y, (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		// Token: 0x06014251 RID: 82513
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawImage_17(HandleRef pThis, float x, float y, float scale, HandleRef image);

		/// <summary>
		/// Draw the supplied image at the given x, y location (bottom corner).
		/// Scale the supplied image by scale.
		/// </summary>
		// Token: 0x06014252 RID: 82514 RVA: 0x001C7638 File Offset: 0x001C5838
		public void DrawImage(float x, float y, float scale, vtkImageData image)
		{
			vtkContext2D.vtkContext2D_DrawImage_17(base.GetCppThis(), x, y, scale, (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		// Token: 0x06014253 RID: 82515
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawImage_18(HandleRef pThis, HandleRef pos, HandleRef image);

		/// <summary>
		/// Draw the supplied image at the given position. The origin, width, and
		/// height are specified by the supplied vtkRectf variable pos. The image
		/// will be drawn scaled to that size.
		/// </summary>
		// Token: 0x06014254 RID: 82516 RVA: 0x001C766C File Offset: 0x001C586C
		public void DrawImage(vtkRectf pos, vtkImageData image)
		{
			vtkContext2D.vtkContext2D_DrawImage_18(base.GetCppThis(), (pos == null) ? default(HandleRef) : pos.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		// Token: 0x06014255 RID: 82517
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawLine_19(HandleRef pThis, float x1, float y1, float x2, float y2);

		/// <summary>
		/// Draw a line between the specified points.
		/// </summary>
		// Token: 0x06014256 RID: 82518 RVA: 0x001C76B0 File Offset: 0x001C58B0
		public void DrawLine(float x1, float y1, float x2, float y2)
		{
			vtkContext2D.vtkContext2D_DrawLine_19(base.GetCppThis(), x1, y1, x2, y2);
		}

		// Token: 0x06014257 RID: 82519
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawLine_20(HandleRef pThis, IntPtr p);

		/// <summary>
		/// Draw a line between the specified points.
		/// </summary>
		// Token: 0x06014258 RID: 82520 RVA: 0x001C76C4 File Offset: 0x001C58C4
		public void DrawLine(IntPtr p)
		{
			vtkContext2D.vtkContext2D_DrawLine_20(base.GetCppThis(), p);
		}

		// Token: 0x06014259 RID: 82521
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawLine_21(HandleRef pThis, HandleRef points);

		/// <summary>
		/// Draw a line between the specified points.
		/// Note: Fastest path - points packed in x and y.
		/// </summary>
		// Token: 0x0601425A RID: 82522 RVA: 0x001C76D4 File Offset: 0x001C58D4
		public void DrawLine(vtkPoints2D points)
		{
			vtkContext2D.vtkContext2D_DrawLine_21(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x0601425B RID: 82523
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawLines_22(HandleRef pThis, HandleRef points);

		/// <summary>
		/// Draw multiple lines between the specified pairs of points.
		/// \sa DrawPoly()
		/// </summary>
		// Token: 0x0601425C RID: 82524 RVA: 0x001C7704 File Offset: 0x001C5904
		public void DrawLines(vtkPoints2D points)
		{
			vtkContext2D.vtkContext2D_DrawLines_22(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x0601425D RID: 82525
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawLines_23(HandleRef pThis, IntPtr points, int n);

		/// <summary>
		/// Draw multiple lines between the specified pairs of points
		/// \sa DrawPoly()
		/// </summary>
		// Token: 0x0601425E RID: 82526 RVA: 0x001C7733 File Offset: 0x001C5933
		public void DrawLines(IntPtr points, int n)
		{
			vtkContext2D.vtkContext2D_DrawLines_23(base.GetCppThis(), points, n);
		}

		// Token: 0x0601425F RID: 82527
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawMarkers_24(HandleRef pThis, int shape, byte highlight, IntPtr points, int n, IntPtr colors, int nc_comps);

		/// <summary>
		/// Draw a series of markers centered at the points supplied. The \a shape
		/// argument controls the marker shape, and can be one of
		/// - VTK_MARKER_CROSS
		/// - VTK_MARKER_PLUS
		/// - VTK_MARKER_SQUARE
		/// - VTK_MARKER_CIRCLE
		/// - VTK_MARKER_DIAMOND
		/// Marker size is determined by the current pen width.
		/// \param shape the shape of the marker
		/// \param highlight whether to highlight the marker or not
		/// \param points where to draw the markers
		/// \param n number of points
		/// \param colors is an optional array of colors.
		/// \param nc_comps is the number of components for the color.
		/// </summary>
		// Token: 0x06014260 RID: 82528 RVA: 0x001C7744 File Offset: 0x001C5944
		public virtual void DrawMarkers(int shape, bool highlight, IntPtr points, int n, IntPtr colors, int nc_comps)
		{
			vtkContext2D.vtkContext2D_DrawMarkers_24(base.GetCppThis(), shape, highlight ? (byte)1 : (byte)0, points, n, colors, nc_comps);
		}

		// Token: 0x06014261 RID: 82529
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawMarkers_25(HandleRef pThis, int shape, byte highlight, IntPtr points, int n);

		/// <summary>
		/// Draw a series of markers centered at the points supplied. The \a shape
		/// argument controls the marker shape, and can be one of
		/// - VTK_MARKER_CROSS
		/// - VTK_MARKER_PLUS
		/// - VTK_MARKER_SQUARE
		/// - VTK_MARKER_CIRCLE
		/// - VTK_MARKER_DIAMOND
		/// Marker size is determined by the current pen width.
		/// \param shape the shape of the marker
		/// \param highlight whether to highlight the marker or not
		/// \param points where to draw the markers
		/// \param n number of points
		/// \param colors is an optional array of colors.
		/// \param nc_comps is the number of components for the color.
		/// </summary>
		// Token: 0x06014262 RID: 82530 RVA: 0x001C7764 File Offset: 0x001C5964
		public virtual void DrawMarkers(int shape, bool highlight, IntPtr points, int n)
		{
			vtkContext2D.vtkContext2D_DrawMarkers_25(base.GetCppThis(), shape, highlight ? (byte)1 : (byte)0, points, n);
		}

		// Token: 0x06014263 RID: 82531
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawMarkers_26(HandleRef pThis, int shape, byte highlight, HandleRef points);

		/// <summary>
		/// Draw a series of markers centered at the points supplied. The \a shape
		/// argument controls the marker shape, and can be one of
		/// - VTK_MARKER_CROSS
		/// - VTK_MARKER_PLUS
		/// - VTK_MARKER_SQUARE
		/// - VTK_MARKER_CIRCLE
		/// - VTK_MARKER_DIAMOND
		/// Marker size is determined by the current pen width.
		/// \param shape the shape of the marker
		/// \param highlight whether to highlight the marker or not
		/// \param points where to draw the markers
		/// \param n number of points
		/// \param colors is an optional array of colors.
		/// \param nc_comps is the number of components for the color.
		/// </summary>
		// Token: 0x06014264 RID: 82532 RVA: 0x001C7780 File Offset: 0x001C5980
		public virtual void DrawMarkers(int shape, bool highlight, vtkPoints2D points)
		{
			vtkContext2D.vtkContext2D_DrawMarkers_26(base.GetCppThis(), shape, highlight ? (byte)1 : (byte)0, (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x06014265 RID: 82533
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawMarkers_27(HandleRef pThis, int shape, byte highlight, HandleRef points, HandleRef colors);

		/// <summary>
		/// Draw a series of markers centered at the points supplied. The \a shape
		/// argument controls the marker shape, and can be one of
		/// - VTK_MARKER_CROSS
		/// - VTK_MARKER_PLUS
		/// - VTK_MARKER_SQUARE
		/// - VTK_MARKER_CIRCLE
		/// - VTK_MARKER_DIAMOND
		/// Marker size is determined by the current pen width.
		/// \param shape the shape of the marker
		/// \param highlight whether to highlight the marker or not
		/// \param points where to draw the markers
		/// \param n number of points
		/// \param colors is an optional array of colors.
		/// \param nc_comps is the number of components for the color.
		/// </summary>
		// Token: 0x06014266 RID: 82534 RVA: 0x001C77BC File Offset: 0x001C59BC
		public virtual void DrawMarkers(int shape, bool highlight, vtkPoints2D points, vtkUnsignedCharArray colors)
		{
			vtkContext2D.vtkContext2D_DrawMarkers_27(base.GetCppThis(), shape, highlight ? (byte)1 : (byte)0, (points == null) ? default(HandleRef) : points.GetCppThis(), (colors == null) ? default(HandleRef) : colors.GetCppThis());
		}

		// Token: 0x06014267 RID: 82535
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawMarkers_28(HandleRef pThis, int shape, byte highlight, HandleRef positions, HandleRef colors, ulong cacheIdentifier);

		/// <summary>
		/// Cached draw command for markers. VBOs are rebuilt if available.
		/// </summary>
		// Token: 0x06014268 RID: 82536 RVA: 0x001C780C File Offset: 0x001C5A0C
		public virtual void DrawMarkers(int shape, bool highlight, vtkDataArray positions, vtkUnsignedCharArray colors, ulong cacheIdentifier)
		{
			vtkContext2D.vtkContext2D_DrawMarkers_28(base.GetCppThis(), shape, highlight ? (byte)1 : (byte)0, (positions == null) ? default(HandleRef) : positions.GetCppThis(), (colors == null) ? default(HandleRef) : colors.GetCppThis(), cacheIdentifier);
		}

		// Token: 0x06014269 RID: 82537
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawMathTextString_29(HandleRef pThis, HandleRef point, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1);

		/// <summary>
		/// Draw a MathText formatted equation to the screen. See
		/// http://matplotlib.sourceforge.net/users/mathtext.html for more information.
		/// MathText requires matplotlib and python, and the vtkMatplotlib module must
		/// be enabled manually during build configuration. This method will do nothing
		/// but print a warning if vtkMathTextUtilities::GetInstance() returns NULL.
		/// </summary>
		// Token: 0x0601426A RID: 82538 RVA: 0x001C7860 File Offset: 0x001C5A60
		public void DrawMathTextString(vtkPoints2D point, string arg1)
		{
			vtkContext2D.vtkContext2D_DrawMathTextString_29(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), arg1);
		}

		// Token: 0x0601426B RID: 82539
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawMathTextString_30(HandleRef pThis, float x, float y, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg2);

		/// <summary>
		/// Draw a MathText formatted equation to the screen. See
		/// http://matplotlib.sourceforge.net/users/mathtext.html for more information.
		/// MathText requires matplotlib and python, and the vtkMatplotlib module must
		/// be enabled manually during build configuration. This method will do nothing
		/// but print a warning if vtkMathTextUtilities::GetInstance() returns NULL.
		/// </summary>
		// Token: 0x0601426C RID: 82540 RVA: 0x001C7890 File Offset: 0x001C5A90
		public void DrawMathTextString(float x, float y, string arg2)
		{
			vtkContext2D.vtkContext2D_DrawMathTextString_30(base.GetCppThis(), x, y, arg2);
		}

		// Token: 0x0601426D RID: 82541
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawMathTextString_31(HandleRef pThis, HandleRef point, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1, [MarshalAs(UnmanagedType.LPUTF8Str)] string fallback);

		/// <summary>
		/// Draw a MathText formatted equation to the screen. See
		/// http://matplotlib.sourceforge.net/users/mathtext.html for more information.
		/// MathText requires matplotlib and python, and the vtkMatplotlib module must
		/// be enabled manually during build configuration.
		/// If MathText is not available on the target device the non-MathText string
		/// in "fallback" is rendered using DrawString.
		/// </summary>
		// Token: 0x0601426E RID: 82542 RVA: 0x001C78A4 File Offset: 0x001C5AA4
		public void DrawMathTextString(vtkPoints2D point, string arg1, string fallback)
		{
			vtkContext2D.vtkContext2D_DrawMathTextString_31(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), arg1, fallback);
		}

		// Token: 0x0601426F RID: 82543
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawMathTextString_32(HandleRef pThis, float x, float y, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg2, [MarshalAs(UnmanagedType.LPUTF8Str)] string fallback);

		/// <summary>
		/// Draw a MathText formatted equation to the screen. See
		/// http://matplotlib.sourceforge.net/users/mathtext.html for more information.
		/// MathText requires matplotlib and python, and the vtkMatplotlib module must
		/// be enabled manually during build configuration.
		/// If MathText is not available on the target device the non-MathText string
		/// in "fallback" is rendered using DrawString.
		/// </summary>
		// Token: 0x06014270 RID: 82544 RVA: 0x001C78D5 File Offset: 0x001C5AD5
		public void DrawMathTextString(float x, float y, string arg2, string fallback)
		{
			vtkContext2D.vtkContext2D_DrawMathTextString_32(base.GetCppThis(), x, y, arg2, fallback);
		}

		// Token: 0x06014271 RID: 82545
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPoint_33(HandleRef pThis, float x, float y);

		/// <summary>
		/// Draw a point at the supplied x and y coordinate
		/// </summary>
		// Token: 0x06014272 RID: 82546 RVA: 0x001C78E9 File Offset: 0x001C5AE9
		public void DrawPoint(float x, float y)
		{
			vtkContext2D.vtkContext2D_DrawPoint_33(base.GetCppThis(), x, y);
		}

		// Token: 0x06014273 RID: 82547
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPointSprites_34(HandleRef pThis, HandleRef sprite, HandleRef points);

		/// <summary>
		/// Draw a series of point sprites, images centred at the points supplied.
		/// The supplied vtkImageData is the sprite to be drawn, only squares will be
		/// drawn and the size is set using SetPointSize.
		/// </summary>
		// Token: 0x06014274 RID: 82548 RVA: 0x001C78FC File Offset: 0x001C5AFC
		public void DrawPointSprites(vtkImageData sprite, vtkPoints2D points)
		{
			vtkContext2D.vtkContext2D_DrawPointSprites_34(base.GetCppThis(), (sprite == null) ? default(HandleRef) : sprite.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x06014275 RID: 82549
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPointSprites_35(HandleRef pThis, HandleRef sprite, HandleRef points, HandleRef colors);

		/// <summary>
		/// Draw a series of point sprites, images centred at the points supplied.
		/// The supplied vtkImageData is the sprite to be drawn, only squares will be
		/// drawn and the size is set using SetPointSize. Points will be colored by
		/// the colors array, which must be the same length as points.
		/// </summary>
		// Token: 0x06014276 RID: 82550 RVA: 0x001C7940 File Offset: 0x001C5B40
		public void DrawPointSprites(vtkImageData sprite, vtkPoints2D points, vtkUnsignedCharArray colors)
		{
			vtkContext2D.vtkContext2D_DrawPointSprites_35(base.GetCppThis(), (sprite == null) ? default(HandleRef) : sprite.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), (colors == null) ? default(HandleRef) : colors.GetCppThis());
		}

		// Token: 0x06014277 RID: 82551
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPointSprites_36(HandleRef pThis, HandleRef sprite, IntPtr points, int n, IntPtr colors, int nc_comps);

		/// <summary>
		/// Draw a series of point sprites, images centred at the points supplied.
		/// The supplied vtkImageData is the sprite to be drawn, only squares will be
		/// drawn and the size is set using SetPointSize. Points will be colored by
		/// the colors array, which must be the same length as points.
		/// </summary>
		// Token: 0x06014278 RID: 82552 RVA: 0x001C799C File Offset: 0x001C5B9C
		public void DrawPointSprites(vtkImageData sprite, IntPtr points, int n, IntPtr colors, int nc_comps)
		{
			vtkContext2D.vtkContext2D_DrawPointSprites_36(base.GetCppThis(), (sprite == null) ? default(HandleRef) : sprite.GetCppThis(), points, n, colors, nc_comps);
		}

		// Token: 0x06014279 RID: 82553
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPointSprites_37(HandleRef pThis, HandleRef sprite, HandleRef positions, HandleRef colors, ulong cacheIdentifier);

		/// <summary>
		/// Draw a series of point sprites, images centred at the points supplied.
		/// The supplied vtkImageData is the sprite to be drawn, only squares will be
		/// drawn and the size is set using SetPointSize. Points will be colored by
		/// the colors array, which must be the same length as points.
		/// </summary>
		// Token: 0x0601427A RID: 82554 RVA: 0x001C79D4 File Offset: 0x001C5BD4
		public void DrawPointSprites(vtkImageData sprite, vtkDataArray positions, vtkUnsignedCharArray colors, ulong cacheIdentifier)
		{
			vtkContext2D.vtkContext2D_DrawPointSprites_37(base.GetCppThis(), (sprite == null) ? default(HandleRef) : sprite.GetCppThis(), (positions == null) ? default(HandleRef) : positions.GetCppThis(), (colors == null) ? default(HandleRef) : colors.GetCppThis(), cacheIdentifier);
		}

		// Token: 0x0601427B RID: 82555
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPointSprites_38(HandleRef pThis, HandleRef sprite, IntPtr points, int n);

		/// <summary>
		/// Draw a series of point sprites, images centred at the points supplied.
		/// The supplied vtkImageData is the sprite to be drawn, only squares will be
		/// drawn and the size is set using SetPointSize.
		/// </summary>
		// Token: 0x0601427C RID: 82556 RVA: 0x001C7A30 File Offset: 0x001C5C30
		public void DrawPointSprites(vtkImageData sprite, IntPtr points, int n)
		{
			vtkContext2D.vtkContext2D_DrawPointSprites_38(base.GetCppThis(), (sprite == null) ? default(HandleRef) : sprite.GetCppThis(), points, n);
		}

		// Token: 0x0601427D RID: 82557
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPoints_39(HandleRef pThis, IntPtr x, IntPtr y, int n);

		/// <summary>
		/// Draw the specified number of points using the x and y arrays supplied
		/// </summary>
		// Token: 0x0601427E RID: 82558 RVA: 0x001C7A61 File Offset: 0x001C5C61
		public void DrawPoints(IntPtr x, IntPtr y, int n)
		{
			vtkContext2D.vtkContext2D_DrawPoints_39(base.GetCppThis(), x, y, n);
		}

		// Token: 0x0601427F RID: 82559
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPoints_40(HandleRef pThis, HandleRef points);

		/// <summary>
		/// Draw a poly line between the specified points - fastest code path due to
		/// memory layout of the coordinates.
		/// </summary>
		// Token: 0x06014280 RID: 82560 RVA: 0x001C7A74 File Offset: 0x001C5C74
		public void DrawPoints(vtkPoints2D points)
		{
			vtkContext2D.vtkContext2D_DrawPoints_40(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x06014281 RID: 82561
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPoints_41(HandleRef pThis, HandleRef positions, HandleRef colors, ulong cacheIdentifier);

		/// <summary>
		/// Draw a poly line between the specified points - fastest code path due to
		/// memory layout of the coordinates.
		/// </summary>
		// Token: 0x06014282 RID: 82562 RVA: 0x001C7AA4 File Offset: 0x001C5CA4
		public void DrawPoints(vtkDataArray positions, vtkUnsignedCharArray colors, ulong cacheIdentifier)
		{
			vtkContext2D.vtkContext2D_DrawPoints_41(base.GetCppThis(), (positions == null) ? default(HandleRef) : positions.GetCppThis(), (colors == null) ? default(HandleRef) : colors.GetCppThis(), cacheIdentifier);
		}

		// Token: 0x06014283 RID: 82563
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPoints_42(HandleRef pThis, IntPtr points, int n);

		/// <summary>
		/// Draw a poly line between the specified points, where the float array is of
		/// size 2*n and the points are packed x1, y1, x2, y2 etc.
		/// Note: Fastest code path - points packed in x and y.
		/// </summary>
		// Token: 0x06014284 RID: 82564 RVA: 0x001C7AE9 File Offset: 0x001C5CE9
		public void DrawPoints(IntPtr points, int n)
		{
			vtkContext2D.vtkContext2D_DrawPoints_42(base.GetCppThis(), points, n);
		}

		// Token: 0x06014285 RID: 82565
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPoly_43(HandleRef pThis, IntPtr x, IntPtr y, int n);

		/// <summary>
		/// Draw a poly line between the specified points.
		/// </summary>
		// Token: 0x06014286 RID: 82566 RVA: 0x001C7AFA File Offset: 0x001C5CFA
		public void DrawPoly(IntPtr x, IntPtr y, int n)
		{
			vtkContext2D.vtkContext2D_DrawPoly_43(base.GetCppThis(), x, y, n);
		}

		// Token: 0x06014287 RID: 82567
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPoly_44(HandleRef pThis, HandleRef points);

		/// <summary>
		/// Draw a poly line between the specified points - fastest code path due to
		/// memory layout of the coordinates.
		/// </summary>
		// Token: 0x06014288 RID: 82568 RVA: 0x001C7B0C File Offset: 0x001C5D0C
		public void DrawPoly(vtkPoints2D points)
		{
			vtkContext2D.vtkContext2D_DrawPoly_44(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x06014289 RID: 82569
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPoly_45(HandleRef pThis, IntPtr points, int n);

		/// <summary>
		/// Draw a poly line between the specified points, where the float array is of
		/// size 2*n and the points are packed x1, y1, x2, y2 etc.
		/// Note: Fastest code path - points packed in x and y.
		/// </summary>
		// Token: 0x0601428A RID: 82570 RVA: 0x001C7B3B File Offset: 0x001C5D3B
		public void DrawPoly(IntPtr points, int n)
		{
			vtkContext2D.vtkContext2D_DrawPoly_45(base.GetCppThis(), points, n);
		}

		// Token: 0x0601428B RID: 82571
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPoly_46(HandleRef pThis, IntPtr points, int n, IntPtr colors, int nc_comps);

		/// <summary>
		/// Draw a poly line between the specified points, where the float array is of
		/// size 2*n and the points are packed x1, y1, x2, y2 etc. The line will be colored by
		/// the colors array, which must have nc_comps components (defining a single color).
		/// Note: Fastest code path - points packed in x and y.
		/// </summary>
		// Token: 0x0601428C RID: 82572 RVA: 0x001C7B4C File Offset: 0x001C5D4C
		public void DrawPoly(IntPtr points, int n, IntPtr colors, int nc_comps)
		{
			vtkContext2D.vtkContext2D_DrawPoly_46(base.GetCppThis(), points, n, colors, nc_comps);
		}

		// Token: 0x0601428D RID: 82573
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPolyData_47(HandleRef pThis, float x, float y, HandleRef polyData, HandleRef colors, int scalarMode);

		/// <summary>
		/// Draw the supplied polyData at the given x, y position (bottom corner).
		/// \note Supports only 2D meshes.
		/// </summary>
		// Token: 0x0601428E RID: 82574 RVA: 0x001C7B60 File Offset: 0x001C5D60
		public void DrawPolyData(float x, float y, vtkPolyData polyData, vtkUnsignedCharArray colors, int scalarMode)
		{
			vtkContext2D.vtkContext2D_DrawPolyData_47(base.GetCppThis(), x, y, (polyData == null) ? default(HandleRef) : polyData.GetCppThis(), (colors == null) ? default(HandleRef) : colors.GetCppThis(), scalarMode);
		}

		// Token: 0x0601428F RID: 82575
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPolygon_48(HandleRef pThis, IntPtr x, IntPtr y, int n);

		/// <summary>
		/// Draw a polygon specified specified by the points using the x and y arrays
		/// supplied
		/// </summary>
		// Token: 0x06014290 RID: 82576 RVA: 0x001C7BAA File Offset: 0x001C5DAA
		public void DrawPolygon(IntPtr x, IntPtr y, int n)
		{
			vtkContext2D.vtkContext2D_DrawPolygon_48(base.GetCppThis(), x, y, n);
		}

		// Token: 0x06014291 RID: 82577
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPolygon_49(HandleRef pThis, HandleRef points);

		/// <summary>
		/// Draw a polygon defined by the specified points - fastest code path due to
		/// memory layout of the coordinates.
		/// </summary>
		// Token: 0x06014292 RID: 82578 RVA: 0x001C7BBC File Offset: 0x001C5DBC
		public void DrawPolygon(vtkPoints2D points)
		{
			vtkContext2D.vtkContext2D_DrawPolygon_49(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x06014293 RID: 82579
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPolygon_50(HandleRef pThis, IntPtr points, int n);

		/// <summary>
		/// Draw a polygon defined by the specified points, where the float array is
		/// of size 2*n and the points are packed x1, y1, x2, y2 etc.
		/// Note: Fastest code path - points packed in x and y.
		/// </summary>
		// Token: 0x06014294 RID: 82580 RVA: 0x001C7BEB File Offset: 0x001C5DEB
		public void DrawPolygon(IntPtr points, int n)
		{
			vtkContext2D.vtkContext2D_DrawPolygon_50(base.GetCppThis(), points, n);
		}

		// Token: 0x06014295 RID: 82581
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPolygon_51(HandleRef pThis, IntPtr x, IntPtr y, int n, IntPtr color, int nc_comps);

		/// <summary>
		/// Draw a polygon specified specified by the points using the x and y arrays
		/// supplied
		/// </summary>
		// Token: 0x06014296 RID: 82582 RVA: 0x001C7BFC File Offset: 0x001C5DFC
		public void DrawPolygon(IntPtr x, IntPtr y, int n, IntPtr color, int nc_comps)
		{
			vtkContext2D.vtkContext2D_DrawPolygon_51(base.GetCppThis(), x, y, n, color, nc_comps);
		}

		// Token: 0x06014297 RID: 82583
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPolygon_52(HandleRef pThis, HandleRef points, IntPtr color, int nc_comps);

		/// <summary>
		/// Draw a polygon defined by the specified points - fastest code path due to
		/// memory layout of the coordinates.
		/// </summary>
		// Token: 0x06014298 RID: 82584 RVA: 0x001C7C14 File Offset: 0x001C5E14
		public void DrawPolygon(vtkPoints2D points, IntPtr color, int nc_comps)
		{
			vtkContext2D.vtkContext2D_DrawPolygon_52(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), color, nc_comps);
		}

		// Token: 0x06014299 RID: 82585
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawPolygon_53(HandleRef pThis, IntPtr points, int n, IntPtr color, int nc_comps);

		/// <summary>
		/// Draw a polygon defined by the specified points, where the float array is
		/// of size 2*n and the points are packed x1, y1, x2, y2 etc.
		/// Note: Fastest code path - points packed in x and y.
		/// </summary>
		// Token: 0x0601429A RID: 82586 RVA: 0x001C7C45 File Offset: 0x001C5E45
		public void DrawPolygon(IntPtr points, int n, IntPtr color, int nc_comps)
		{
			vtkContext2D.vtkContext2D_DrawPolygon_53(base.GetCppThis(), points, n, color, nc_comps);
		}

		// Token: 0x0601429B RID: 82587
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawQuad_54(HandleRef pThis, float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4);

		/// <summary>
		/// Draw a quadrilateral at the specified points (4 points, 8 floats in x, y).
		/// </summary>
		// Token: 0x0601429C RID: 82588 RVA: 0x001C7C5C File Offset: 0x001C5E5C
		public void DrawQuad(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
		{
			vtkContext2D.vtkContext2D_DrawQuad_54(base.GetCppThis(), x1, y1, x2, y2, x3, y3, x4, y4);
		}

		// Token: 0x0601429D RID: 82589
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawQuad_55(HandleRef pThis, IntPtr p);

		/// <summary>
		/// Draw a quadrilateral at the specified points (4 points, 8 floats in x, y).
		/// </summary>
		// Token: 0x0601429E RID: 82590 RVA: 0x001C7C83 File Offset: 0x001C5E83
		public void DrawQuad(IntPtr p)
		{
			vtkContext2D.vtkContext2D_DrawQuad_55(base.GetCppThis(), p);
		}

		// Token: 0x0601429F RID: 82591
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawQuadStrip_56(HandleRef pThis, HandleRef points);

		/// <summary>
		/// Draw a strip of quads
		/// </summary>
		// Token: 0x060142A0 RID: 82592 RVA: 0x001C7C94 File Offset: 0x001C5E94
		public void DrawQuadStrip(vtkPoints2D points)
		{
			vtkContext2D.vtkContext2D_DrawQuadStrip_56(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x060142A1 RID: 82593
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawQuadStrip_57(HandleRef pThis, IntPtr p, int n);

		/// <summary>
		/// Draw a strip of quads
		/// </summary>
		// Token: 0x060142A2 RID: 82594 RVA: 0x001C7CC3 File Offset: 0x001C5EC3
		public void DrawQuadStrip(IntPtr p, int n)
		{
			vtkContext2D.vtkContext2D_DrawQuadStrip_57(base.GetCppThis(), p, n);
		}

		// Token: 0x060142A3 RID: 82595
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawRect_58(HandleRef pThis, float x, float y, float w, float h);

		/// <summary>
		/// Draw a rectangle with origin at x, y and width w, height h
		/// </summary>
		// Token: 0x060142A4 RID: 82596 RVA: 0x001C7CD4 File Offset: 0x001C5ED4
		public void DrawRect(float x, float y, float w, float h)
		{
			vtkContext2D.vtkContext2D_DrawRect_58(base.GetCppThis(), x, y, w, h);
		}

		// Token: 0x060142A5 RID: 82597
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawString_59(HandleRef pThis, HandleRef point, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1);

		/// <summary>
		/// Draw some text to the screen.
		/// </summary>
		// Token: 0x060142A6 RID: 82598 RVA: 0x001C7CE8 File Offset: 0x001C5EE8
		public void DrawString(vtkPoints2D point, string arg1)
		{
			vtkContext2D.vtkContext2D_DrawString_59(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), arg1);
		}

		// Token: 0x060142A7 RID: 82599
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawString_60(HandleRef pThis, float x, float y, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg2);

		/// <summary>
		/// Draw some text to the screen.
		/// </summary>
		// Token: 0x060142A8 RID: 82600 RVA: 0x001C7D18 File Offset: 0x001C5F18
		public void DrawString(float x, float y, string arg2)
		{
			vtkContext2D.vtkContext2D_DrawString_60(base.GetCppThis(), x, y, arg2);
		}

		// Token: 0x060142A9 RID: 82601
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawStringRect_61(HandleRef pThis, HandleRef rect, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1);

		/// <summary>
		/// Draw some text to the screen in a bounding rectangle with the alignment
		/// of the text properties respecting the rectangle. The points should be
		/// supplied as bottom corner (x, y), width, height.
		/// </summary>
		// Token: 0x060142AA RID: 82602 RVA: 0x001C7D2C File Offset: 0x001C5F2C
		public void DrawStringRect(vtkPoints2D rect, string arg1)
		{
			vtkContext2D.vtkContext2D_DrawStringRect_61(base.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis(), arg1);
		}

		// Token: 0x060142AB RID: 82603
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawStringRect_62(HandleRef pThis, IntPtr rect, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1);

		/// <summary>
		/// Draw some text to the screen in a bounding rectangle with the alignment
		/// of the text properties respecting the rectangle. The points should be
		/// supplied as bottom corner (x, y), width, height.
		/// </summary>
		// Token: 0x060142AC RID: 82604 RVA: 0x001C7D5C File Offset: 0x001C5F5C
		public void DrawStringRect(IntPtr rect, string arg1)
		{
			vtkContext2D.vtkContext2D_DrawStringRect_62(base.GetCppThis(), rect, arg1);
		}

		// Token: 0x060142AD RID: 82605
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_DrawWedge_63(HandleRef pThis, float x, float y, float outRadius, float inRadius, float startAngle, float stopAngle);

		/// <summary>
		/// Draw a circular wedge with center at x, y, outer radius outRadius,
		/// inner radius inRadius between angles startAngle and stopAngle
		/// (expressed in degrees).
		/// \pre positive_outRadius: outRadius&gt;=0
		/// \pre positive_inRadius: inRadius&gt;=0
		/// \pre ordered_radii: inRadius&lt;=outRadius
		/// </summary>
		// Token: 0x060142AE RID: 82606 RVA: 0x001C7D6D File Offset: 0x001C5F6D
		public void DrawWedge(float x, float y, float outRadius, float inRadius, float startAngle, float stopAngle)
		{
			vtkContext2D.vtkContext2D_DrawWedge_63(base.GetCppThis(), x, y, outRadius, inRadius, startAngle, stopAngle);
		}

		// Token: 0x060142AF RID: 82607
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContext2D_End_64(HandleRef pThis);

		/// <summary>
		/// Ends painting on the device, you would not usually need to call this as it
		/// should be called by the destructor. Returns true if the painter is no
		/// longer active, otherwise false.
		/// </summary>
		// Token: 0x060142B0 RID: 82608 RVA: 0x001C7D88 File Offset: 0x001C5F88
		public bool End()
		{
			return vtkContext2D.vtkContext2D_End_64(base.GetCppThis()) != 0;
		}

		// Token: 0x060142B1 RID: 82609
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContext2D_FloatToInt_65(float x);

		/// <summary>
		/// Float to int conversion, performs truncation but with a rounding
		/// tolerance for float values that are within 1/256 of their closest
		/// integer.
		/// </summary>
		// Token: 0x060142B2 RID: 82610 RVA: 0x001C7DB0 File Offset: 0x001C5FB0
		public static int FloatToInt(float x)
		{
			return vtkContext2D.vtkContext2D_FloatToInt_65(x);
		}

		// Token: 0x060142B3 RID: 82611
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContext2D_GetBrush_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the pen which controls the outlines of shapes as well as lines, points
		/// and related primitives.
		/// </summary>
		// Token: 0x060142B4 RID: 82612 RVA: 0x001C7DCC File Offset: 0x001C5FCC
		public vtkBrush GetBrush()
		{
			vtkBrush vtkBrush = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContext2D.vtkContext2D_GetBrush_66(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBrush = (vtkBrush)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBrush.Register(null);
				}
			}
			return vtkBrush;
		}

		// Token: 0x060142B5 RID: 82613
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContext2D_GetBufferIdMode_67(HandleRef pThis);

		/// <summary>
		/// Tell if the context is in BufferId creation mode. Initial value is false.
		/// </summary>
		// Token: 0x060142B6 RID: 82614 RVA: 0x001C7E3C File Offset: 0x001C603C
		public bool GetBufferIdMode()
		{
			return vtkContext2D.vtkContext2D_GetBufferIdMode_67(base.GetCppThis()) != 0;
		}

		// Token: 0x060142B7 RID: 82615
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContext2D_GetNumberOfGenerationsFromBase_68(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060142B8 RID: 82616 RVA: 0x001C7E64 File Offset: 0x001C6064
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContext2D.vtkContext2D_GetNumberOfGenerationsFromBase_68(base.GetCppThis(), type);
		}

		// Token: 0x060142B9 RID: 82617
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContext2D_GetNumberOfGenerationsFromBaseType_69([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060142BA RID: 82618 RVA: 0x001C7E84 File Offset: 0x001C6084
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContext2D.vtkContext2D_GetNumberOfGenerationsFromBaseType_69(type);
		}

		// Token: 0x060142BB RID: 82619
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContext2D_GetPen_70(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the pen which controls the outlines of shapes, as well as lines,
		/// points and related primitives. This object can be modified and the changes
		/// will be reflected in subsequent drawing operations.
		/// </summary>
		// Token: 0x060142BC RID: 82620 RVA: 0x001C7EA0 File Offset: 0x001C60A0
		public vtkPen GetPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContext2D.vtkContext2D_GetPen_70(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPen = (vtkPen)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPen.Register(null);
				}
			}
			return vtkPen;
		}

		// Token: 0x060142BD RID: 82621
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContext2D_GetTextProp_71(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the text properties object for the vtkContext2D.
		/// </summary>
		// Token: 0x060142BE RID: 82622 RVA: 0x001C7F10 File Offset: 0x001C6110
		public vtkTextProperty GetTextProp()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContext2D.vtkContext2D_GetTextProp_71(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060142BF RID: 82623
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContext2D_GetTransform_72(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Compute the current transform applied to the context.
		/// </summary>
		// Token: 0x060142C0 RID: 82624 RVA: 0x001C7F80 File Offset: 0x001C6180
		public vtkTransform2D GetTransform()
		{
			vtkTransform2D vtkTransform2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContext2D.vtkContext2D_GetTransform_72(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform2D = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform2D.Register(null);
				}
			}
			return vtkTransform2D;
		}

		// Token: 0x060142C1 RID: 82625
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContext2D_IsA_73(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060142C2 RID: 82626 RVA: 0x001C7FF0 File Offset: 0x001C61F0
		public override int IsA(string type)
		{
			return vtkContext2D.vtkContext2D_IsA_73(base.GetCppThis(), type);
		}

		// Token: 0x060142C3 RID: 82627
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContext2D_IsTypeOf_74([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060142C4 RID: 82628 RVA: 0x001C8010 File Offset: 0x001C6210
		public new static int IsTypeOf(string type)
		{
			return vtkContext2D.vtkContext2D_IsTypeOf_74(type);
		}

		// Token: 0x060142C5 RID: 82629
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContext2D_MathTextIsSupported_75(HandleRef pThis);

		/// <summary>
		/// Return true if MathText rendering available on the current device.
		/// </summary>
		// Token: 0x060142C6 RID: 82630 RVA: 0x001C802C File Offset: 0x001C622C
		public bool MathTextIsSupported()
		{
			return vtkContext2D.vtkContext2D_MathTextIsSupported_75(base.GetCppThis()) != 0;
		}

		// Token: 0x060142C7 RID: 82631
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContext2D_NewInstance_77(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060142C8 RID: 82632 RVA: 0x001C8054 File Offset: 0x001C6254
		public new vtkContext2D NewInstance()
		{
			vtkContext2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContext2D.vtkContext2D_NewInstance_77(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContext2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060142C9 RID: 82633
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_PopMatrix_78(HandleRef pThis);

		/// <summary>
		/// Push/pop the transformation matrix for the painter (sets the underlying
		/// matrix for the device when available).
		/// </summary>
		// Token: 0x060142CA RID: 82634 RVA: 0x001C80AE File Offset: 0x001C62AE
		public void PopMatrix()
		{
			vtkContext2D.vtkContext2D_PopMatrix_78(base.GetCppThis());
		}

		// Token: 0x060142CB RID: 82635
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_PushMatrix_79(HandleRef pThis);

		/// <summary>
		/// Push/pop the transformation matrix for the painter (sets the underlying
		/// matrix for the device when available).
		/// </summary>
		// Token: 0x060142CC RID: 82636 RVA: 0x001C80BD File Offset: 0x001C62BD
		public void PushMatrix()
		{
			vtkContext2D.vtkContext2D_PushMatrix_79(base.GetCppThis());
		}

		// Token: 0x060142CD RID: 82637
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContext2D_SafeDownCast_80(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060142CE RID: 82638 RVA: 0x001C80CC File Offset: 0x001C62CC
		public new static vtkContext2D SafeDownCast(vtkObjectBase o)
		{
			vtkContext2D vtkContext2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContext2D.vtkContext2D_SafeDownCast_80((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContext2D = (vtkContext2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContext2D.Register(null);
				}
			}
			return vtkContext2D;
		}

		// Token: 0x060142CF RID: 82639
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContext2D_SetTransform_81(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// Set the transform for the context, the underlying device will use the
		/// matrix of the transform. Note, this is set immediately, later changes to
		/// the matrix will have no effect until it is set again.
		/// </summary>
		// Token: 0x060142D0 RID: 82640 RVA: 0x001C814C File Offset: 0x001C634C
		public void SetTransform(vtkTransform2D transform)
		{
			vtkContext2D.vtkContext2D_SetTransform_81(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001764 RID: 5988
		public new const string MRFullTypeName = "Kitware.VTK.vtkContext2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001765 RID: 5989
		public new static readonly string MRClassNameKey = "class vtkContext2D";
	}
}
