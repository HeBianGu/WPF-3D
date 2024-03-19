using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLContextDevice2D
	/// </summary>
	/// <remarks>
	///    Class for drawing 2D primitives using OpenGL
	/// 1.1+.
	///
	///
	/// This class takes care of drawing the 2D primitives for the vtkContext2D class.
	/// In general this class should not be used directly, but called by vtkContext2D
	/// which takes care of many of the higher level details.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkOpenGL2ContextDevice2D
	/// </seealso>
	// Token: 0x02000122 RID: 290
	public class vtkOpenGLContextDevice2D : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003B0D RID: 15117 RVA: 0x00055EDC File Offset: 0x000540DC
		static vtkOpenGLContextDevice2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLContextDevice2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLContextDevice2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003B0E RID: 15118 RVA: 0x00055F04 File Offset: 0x00054104
		public vtkOpenGLContextDevice2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003B0F RID: 15119
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLContextDevice2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a 2D Painter object.
		/// </summary>
		// Token: 0x06003B10 RID: 15120 RVA: 0x00055F14 File Offset: 0x00054114
		public new static vtkOpenGLContextDevice2D New()
		{
			vtkOpenGLContextDevice2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLContextDevice2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a 2D Painter object.
		/// </summary>
		// Token: 0x06003B11 RID: 15121 RVA: 0x00055F68 File Offset: 0x00054168
		public vtkOpenGLContextDevice2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003B12 RID: 15122 RVA: 0x00055FAC File Offset: 0x000541AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003B13 RID: 15123
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_Begin_01(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Begin drawing, pass in the viewport to set up the view.
		/// </summary>
		// Token: 0x06003B14 RID: 15124 RVA: 0x00055FB8 File Offset: 0x000541B8
		public virtual void Begin(vtkViewport viewport)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_Begin_01(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06003B15 RID: 15125
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_BufferIdModeBegin_02(HandleRef pThis, HandleRef bufferId);

		/// <summary>
		/// Start BufferId creation Mode.
		/// The default implementation is empty.
		/// \pre not_yet: !GetBufferIdMode()
		/// \pre bufferId_exists: bufferId!=0
		/// \post started: GetBufferIdMode()
		/// </summary>
		// Token: 0x06003B16 RID: 15126 RVA: 0x00055FE8 File Offset: 0x000541E8
		public virtual void BufferIdModeBegin(vtkAbstractContextBufferId bufferId)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_BufferIdModeBegin_02(base.GetCppThis(), (bufferId == null) ? default(HandleRef) : bufferId.GetCppThis());
		}

		// Token: 0x06003B17 RID: 15127
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_BufferIdModeEnd_03(HandleRef pThis);

		/// <summary>
		/// Finalize BufferId creation Mode. It makes sure that the content of the
		/// bufferId passed in argument of BufferIdModeBegin() is correctly set.
		/// The default implementation is empty.
		/// \pre started: GetBufferIdMode()
		/// \post done: !GetBufferIdMode()
		/// </summary>
		// Token: 0x06003B18 RID: 15128 RVA: 0x00056017 File Offset: 0x00054217
		public virtual void BufferIdModeEnd()
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_BufferIdModeEnd_03(base.GetCppThis());
		}

		// Token: 0x06003B19 RID: 15129
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_ComputeJustifiedStringBounds_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, IntPtr bounds);

		/// <summary>
		/// Compute the bounds of the supplied string while taking into account the
		/// justification of the currently applied text property. Simple rotations
		/// (0, 90, 180, 270 degrees) are also properly taken into account.
		/// </summary>
		// Token: 0x06003B1A RID: 15130 RVA: 0x00056026 File Offset: 0x00054226
		public virtual void ComputeJustifiedStringBounds(string arg0, IntPtr bounds)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_ComputeJustifiedStringBounds_04(base.GetCppThis(), arg0, bounds);
		}

		// Token: 0x06003B1B RID: 15131
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_ComputeStringBounds_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, IntPtr bounds);

		/// <summary>
		/// Compute the bounds of the supplied string. The bounds will be copied to the
		/// supplied bounds variable, the first two elements are the bottom corner of
		/// the string, and the second two elements are the width and height of the
		/// bounding box. An empty bounding box (0, 0, 0, 0) is returned for an
		/// empty string or string with only characters that cannot be rendered.
		/// NOTE: This function does not take account of the text rotation.
		/// </summary>
		// Token: 0x06003B1C RID: 15132 RVA: 0x00056037 File Offset: 0x00054237
		public virtual void ComputeStringBounds(string arg0, IntPtr bounds)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_ComputeStringBounds_05(base.GetCppThis(), arg0, bounds);
		}

		// Token: 0x06003B1D RID: 15133
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawColoredPolygon_06(HandleRef pThis, IntPtr points, int numPoints, IntPtr colors, int nc_comps);

		/// <summary>
		/// Draw a polygon using the specified number of points.
		/// </summary>
		// Token: 0x06003B1E RID: 15134 RVA: 0x00056048 File Offset: 0x00054248
		public virtual void DrawColoredPolygon(IntPtr points, int numPoints, IntPtr colors, int nc_comps)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawColoredPolygon_06(base.GetCppThis(), points, numPoints, colors, nc_comps);
		}

		// Token: 0x06003B1F RID: 15135
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawEllipseWedge_07(HandleRef pThis, float x, float y, float outRx, float outRy, float inRx, float inRy, float startAngle, float stopAngle);

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
		// Token: 0x06003B20 RID: 15136 RVA: 0x0005605C File Offset: 0x0005425C
		public virtual void DrawEllipseWedge(float x, float y, float outRx, float outRy, float inRx, float inRy, float startAngle, float stopAngle)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawEllipseWedge_07(base.GetCppThis(), x, y, outRx, outRy, inRx, inRy, startAngle, stopAngle);
		}

		// Token: 0x06003B21 RID: 15137
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawEllipticArc_08(HandleRef pThis, float x, float y, float rX, float rY, float startAngle, float stopAngle);

		/// <summary>
		/// Draw an elliptic arc with center at x,y with radii rX and rY between
		/// angles startAngle and stopAngle (expressed in degrees).
		/// \pre positive_rX: rX&gt;=0
		/// \pre positive_rY: rY&gt;=0
		/// </summary>
		// Token: 0x06003B22 RID: 15138 RVA: 0x00056083 File Offset: 0x00054283
		public virtual void DrawEllipticArc(float x, float y, float rX, float rY, float startAngle, float stopAngle)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawEllipticArc_08(base.GetCppThis(), x, y, rX, rY, startAngle, stopAngle);
		}

		// Token: 0x06003B23 RID: 15139
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawImage_09(HandleRef pThis, IntPtr p, float scale, HandleRef image);

		/// <summary>
		/// Draw the supplied image at the given x, y (p[0], p[1]) (bottom corner),
		/// scaled by scale (1.0 would match the image).
		/// </summary>
		// Token: 0x06003B24 RID: 15140 RVA: 0x0005609C File Offset: 0x0005429C
		public virtual void DrawImage(IntPtr p, float scale, vtkImageData image)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawImage_09(base.GetCppThis(), p, scale, (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		// Token: 0x06003B25 RID: 15141
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawImage_10(HandleRef pThis, HandleRef pos, HandleRef image);

		/// <summary>
		/// Draw the supplied image at the given position. The origin, width, and
		/// height are specified by the supplied vtkRectf variable pos. The image
		/// will be drawn scaled to that size.
		/// </summary>
		// Token: 0x06003B26 RID: 15142 RVA: 0x000560D0 File Offset: 0x000542D0
		public virtual void DrawImage(vtkRectf pos, vtkImageData image)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawImage_10(base.GetCppThis(), (pos == null) ? default(HandleRef) : pos.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		// Token: 0x06003B27 RID: 15143
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawLines_11(HandleRef pThis, IntPtr f, int n, IntPtr colors, int nc_comps);

		/// <summary>
		/// Draw lines using the points - memory layout is as follows:
		/// l1p1,l1p2,l2p1,l2p2... The lines will be colored by colors array
		/// which has nc_comps components.
		/// \sa DrawPoly()
		/// </summary>
		// Token: 0x06003B28 RID: 15144 RVA: 0x00056114 File Offset: 0x00054314
		public virtual void DrawLines(IntPtr f, int n, IntPtr colors, int nc_comps)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawLines_11(base.GetCppThis(), f, n, colors, nc_comps);
		}

		// Token: 0x06003B29 RID: 15145
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawMarkers_12(HandleRef pThis, int shape, byte highlight, IntPtr points, int n, IntPtr colors, int nc_comps);

		/// <summary>
		/// Draw a series of markers centered at the points supplied. The \a shape
		/// argument controls the marker shape, and can be one of
		/// - VTK_MARKER_CROSS
		/// - VTK_MARKER_PLUS
		/// - VTK_MARKER_SQUARE
		/// - VTK_MARKER_CIRCLE
		/// - VTK_MARKER_DIAMOND
		/// \param shape the shape of the marker
		/// \param highlight whether to highlight the marker or not
		/// \param points where to draw the sprites
		/// \param n the number of points
		/// \param colors is an optional array of colors.
		/// \param nc_comps is the number of components for the color.
		/// </summary>
		// Token: 0x06003B2A RID: 15146 RVA: 0x00056128 File Offset: 0x00054328
		public virtual void DrawMarkers(int shape, bool highlight, IntPtr points, int n, IntPtr colors, int nc_comps)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawMarkers_12(base.GetCppThis(), shape, highlight ? (byte)1 : (byte)0, points, n, colors, nc_comps);
		}

		// Token: 0x06003B2B RID: 15147
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawMarkers_13(HandleRef pThis, int shape, byte highlight, HandleRef positions, HandleRef colors, ulong cacheIdentifier);

		/// <summary>
		/// Draw a series of markers centered at the points supplied. The \a shape
		/// argument controls the marker shape, and can be one of
		/// - VTK_MARKER_CROSS
		/// - VTK_MARKER_PLUS
		/// - VTK_MARKER_SQUARE
		/// - VTK_MARKER_CIRCLE
		/// - VTK_MARKER_DIAMOND
		/// \param shape the shape of the marker
		/// \param highlight whether to highlight the marker or not
		/// \param points where to draw the sprites
		/// \param n the number of points
		/// \param colors is an optional array of colors.
		/// \param nc_comps is the number of components for the color.
		/// </summary>
		// Token: 0x06003B2C RID: 15148 RVA: 0x00056148 File Offset: 0x00054348
		public virtual void DrawMarkers(int shape, bool highlight, vtkDataArray positions, vtkUnsignedCharArray colors, ulong cacheIdentifier)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawMarkers_13(base.GetCppThis(), shape, highlight ? (byte)1 : (byte)0, (positions == null) ? default(HandleRef) : positions.GetCppThis(), (colors == null) ? default(HandleRef) : colors.GetCppThis(), cacheIdentifier);
		}

		// Token: 0x06003B2D RID: 15149
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawMathTextString_14(HandleRef pThis, IntPtr point, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1);

		/// <summary>
		/// Draw text using MathText markup for mathematical equations. See
		/// http://matplotlib.sourceforge.net/users/mathtext.html for more information.
		/// </summary>
		// Token: 0x06003B2E RID: 15150 RVA: 0x0005619A File Offset: 0x0005439A
		public virtual void DrawMathTextString(IntPtr point, string arg1)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawMathTextString_14(base.GetCppThis(), point, arg1);
		}

		// Token: 0x06003B2F RID: 15151
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawPointSprites_15(HandleRef pThis, HandleRef sprite, IntPtr points, int n, IntPtr colors, int nc_comps);

		/// <summary>
		/// Draw a series of point sprites, images centred at the points supplied.
		/// The supplied vtkImageData is the sprite to be drawn, only squares will be
		/// drawn and the size is set using SetPointSize. Points are colored by colors
		/// array which has nc_comps components - this part is optional.
		/// </summary>
		// Token: 0x06003B30 RID: 15152 RVA: 0x000561AC File Offset: 0x000543AC
		public virtual void DrawPointSprites(vtkImageData sprite, IntPtr points, int n, IntPtr colors, int nc_comps)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawPointSprites_15(base.GetCppThis(), (sprite == null) ? default(HandleRef) : sprite.GetCppThis(), points, n, colors, nc_comps);
		}

		// Token: 0x06003B31 RID: 15153
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawPointSprites_16(HandleRef pThis, HandleRef sprite, HandleRef positions, HandleRef colors, ulong cacheIdentifier);

		/// <summary>
		/// Draw a series of point sprites, images centred at the points supplied.
		/// The supplied vtkImageData is the sprite to be drawn, only squares will be
		/// drawn and the size is set using SetPointSize. Points are colored by colors
		/// array which has nc_comps components - this part is optional.
		/// </summary>
		// Token: 0x06003B32 RID: 15154 RVA: 0x000561E4 File Offset: 0x000543E4
		public virtual void DrawPointSprites(vtkImageData sprite, vtkDataArray positions, vtkUnsignedCharArray colors, ulong cacheIdentifier)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawPointSprites_16(base.GetCppThis(), (sprite == null) ? default(HandleRef) : sprite.GetCppThis(), (positions == null) ? default(HandleRef) : positions.GetCppThis(), (colors == null) ? default(HandleRef) : colors.GetCppThis(), cacheIdentifier);
		}

		// Token: 0x06003B33 RID: 15155
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawPoints_17(HandleRef pThis, IntPtr points, int n, IntPtr colors, int nc_comps);

		/// <summary>
		/// Draw a series of points - fastest code path due to memory
		/// layout of the coordinates. Points are colored by colors array
		/// which has nc_comps components
		/// </summary>
		// Token: 0x06003B34 RID: 15156 RVA: 0x0005623F File Offset: 0x0005443F
		public virtual void DrawPoints(IntPtr points, int n, IntPtr colors, int nc_comps)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawPoints_17(base.GetCppThis(), points, n, colors, nc_comps);
		}

		// Token: 0x06003B35 RID: 15157
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawPoints_18(HandleRef pThis, HandleRef positions, HandleRef colors, ulong cacheIdentifier);

		/// <summary>
		/// Draw a series of points - fastest code path due to memory
		/// layout of the coordinates. Points are colored by colors array
		/// which has nc_comps components
		/// </summary>
		// Token: 0x06003B36 RID: 15158 RVA: 0x00056254 File Offset: 0x00054454
		public virtual void DrawPoints(vtkDataArray positions, vtkUnsignedCharArray colors, ulong cacheIdentifier)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawPoints_18(base.GetCppThis(), (positions == null) ? default(HandleRef) : positions.GetCppThis(), (colors == null) ? default(HandleRef) : colors.GetCppThis(), cacheIdentifier);
		}

		// Token: 0x06003B37 RID: 15159
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawPoly_19(HandleRef pThis, IntPtr f, int n, IntPtr colors, int nc_comps);

		/// <summary>
		/// Draw a poly line using the points - fastest code path due to memory
		/// layout of the coordinates. The line will be colored by colors array
		/// which has nc_comps components
		/// </summary>
		// Token: 0x06003B38 RID: 15160 RVA: 0x00056299 File Offset: 0x00054499
		public virtual void DrawPoly(IntPtr f, int n, IntPtr colors, int nc_comps)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawPoly_19(base.GetCppThis(), f, n, colors, nc_comps);
		}

		// Token: 0x06003B39 RID: 15161
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawPolyData_20(HandleRef pThis, IntPtr p, float scale, HandleRef polyData, HandleRef colors, int scalarMode);

		/// <summary>
		/// Draw the supplied PolyData at the given x, y (p[0], p[1]) (bottom corner),
		/// scaled by scale (1.0 would match the actual dataset).
		/// </summary>
		// Token: 0x06003B3A RID: 15162 RVA: 0x000562B0 File Offset: 0x000544B0
		public virtual void DrawPolyData(IntPtr p, float scale, vtkPolyData polyData, vtkUnsignedCharArray colors, int scalarMode)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawPolyData_20(base.GetCppThis(), p, scale, (polyData == null) ? default(HandleRef) : polyData.GetCppThis(), (colors == null) ? default(HandleRef) : colors.GetCppThis(), scalarMode);
		}

		// Token: 0x06003B3B RID: 15163
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawPolygon_21(HandleRef pThis, IntPtr arg0, int arg1);

		/// <summary>
		/// Draw a polygon using the specified number of points.
		/// </summary>
		// Token: 0x06003B3C RID: 15164 RVA: 0x000562FA File Offset: 0x000544FA
		public virtual void DrawPolygon(IntPtr arg0, int arg1)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawPolygon_21(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x06003B3D RID: 15165
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawQuad_22(HandleRef pThis, IntPtr points, int n);

		/// <summary>
		/// Draws a rectangle
		/// </summary>
		// Token: 0x06003B3E RID: 15166 RVA: 0x0005630B File Offset: 0x0005450B
		public virtual void DrawQuad(IntPtr points, int n)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawQuad_22(base.GetCppThis(), points, n);
		}

		// Token: 0x06003B3F RID: 15167
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawQuadStrip_23(HandleRef pThis, IntPtr points, int n);

		/// <summary>
		/// Draws a rectangle
		/// </summary>
		// Token: 0x06003B40 RID: 15168 RVA: 0x0005631C File Offset: 0x0005451C
		public virtual void DrawQuadStrip(IntPtr points, int n)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawQuadStrip_23(base.GetCppThis(), points, n);
		}

		// Token: 0x06003B41 RID: 15169
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_DrawString_24(HandleRef pThis, IntPtr point, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1);

		/// <summary>
		/// Draw some text to the screen!
		/// </summary>
		// Token: 0x06003B42 RID: 15170 RVA: 0x0005632D File Offset: 0x0005452D
		public virtual void DrawString(IntPtr point, string arg1)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_DrawString_24(base.GetCppThis(), point, arg1);
		}

		// Token: 0x06003B43 RID: 15171
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_EnableClipping_25(HandleRef pThis, byte enable);

		/// <summary>
		/// Disable clipping of the display.
		/// </summary>
		// Token: 0x06003B44 RID: 15172 RVA: 0x0005633E File Offset: 0x0005453E
		public virtual void EnableClipping(bool enable)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_EnableClipping_25(base.GetCppThis(), enable ? (byte)1 : (byte)0);
		}

		// Token: 0x06003B45 RID: 15173
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_End_26(HandleRef pThis);

		/// <summary>
		/// End drawing, clean up the view.
		/// </summary>
		// Token: 0x06003B46 RID: 15174 RVA: 0x00056356 File Offset: 0x00054556
		public virtual void End()
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_End_26(base.GetCppThis());
		}

		// Token: 0x06003B47 RID: 15175
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_GetMatrix_27(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Set the model view matrix for the display
		/// </summary>
		// Token: 0x06003B48 RID: 15176 RVA: 0x00056368 File Offset: 0x00054568
		public virtual void GetMatrix(vtkMatrix3x3 m)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_GetMatrix_27(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x06003B49 RID: 15177
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLContextDevice2D_GetMaximumMarkerCacheSize_28(HandleRef pThis);

		/// <summary>
		/// Adjust the size of the MarkerCache. This implementation generates point
		/// sprites for each mark size/shape and uses DrawPointSprites to render them.
		/// The number of cached markers can be accessed with this function.
		/// </summary>
		// Token: 0x06003B4A RID: 15178 RVA: 0x00056398 File Offset: 0x00054598
		public virtual int GetMaximumMarkerCacheSize()
		{
			return vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_GetMaximumMarkerCacheSize_28(base.GetCppThis());
		}

		// Token: 0x06003B4B RID: 15179
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLContextDevice2D_GetModelMatrix_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the projection matrix this is needed
		/// </summary>
		// Token: 0x06003B4C RID: 15180 RVA: 0x000563B8 File Offset: 0x000545B8
		public vtkMatrix4x4 GetModelMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_GetModelMatrix_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x06003B4D RID: 15181
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLContextDevice2D_GetNumberOfGenerationsFromBase_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003B4E RID: 15182 RVA: 0x00056428 File Offset: 0x00054628
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_GetNumberOfGenerationsFromBase_30(base.GetCppThis(), type);
		}

		// Token: 0x06003B4F RID: 15183
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLContextDevice2D_GetNumberOfGenerationsFromBaseType_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003B50 RID: 15184 RVA: 0x00056448 File Offset: 0x00054648
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_GetNumberOfGenerationsFromBaseType_31(type);
		}

		// Token: 0x06003B51 RID: 15185
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLContextDevice2D_GetProjectionMatrix_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the projection matrix this is needed
		/// </summary>
		// Token: 0x06003B52 RID: 15186 RVA: 0x00056464 File Offset: 0x00054664
		public vtkMatrix4x4 GetProjectionMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_GetProjectionMatrix_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x06003B53 RID: 15187
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLContextDevice2D_GetRenderWindow_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the active RenderWindow of the device. Will return null if not active.
		/// </summary>
		// Token: 0x06003B54 RID: 15188 RVA: 0x000564D4 File Offset: 0x000546D4
		public virtual vtkOpenGLRenderWindow GetRenderWindow()
		{
			vtkOpenGLRenderWindow vtkOpenGLRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_GetRenderWindow_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLRenderWindow = (vtkOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLRenderWindow.Register(null);
				}
			}
			return vtkOpenGLRenderWindow;
		}

		// Token: 0x06003B55 RID: 15189
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLContextDevice2D_HasGLSL_34(HandleRef pThis);

		/// <summary>
		/// Check whether the current context device has support for GLSL.
		/// </summary>
		// Token: 0x06003B56 RID: 15190 RVA: 0x00056544 File Offset: 0x00054744
		public bool HasGLSL()
		{
			return vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_HasGLSL_34(base.GetCppThis()) != 0;
		}

		// Token: 0x06003B57 RID: 15191
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLContextDevice2D_IsA_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003B58 RID: 15192 RVA: 0x0005656C File Offset: 0x0005476C
		public override int IsA(string type)
		{
			return vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_IsA_35(base.GetCppThis(), type);
		}

		// Token: 0x06003B59 RID: 15193
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLContextDevice2D_IsTypeOf_36([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003B5A RID: 15194 RVA: 0x0005658C File Offset: 0x0005478C
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_IsTypeOf_36(type);
		}

		// Token: 0x06003B5B RID: 15195
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_MultiplyMatrix_37(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Multiply the current model view matrix by the supplied one.
		/// </summary>
		// Token: 0x06003B5C RID: 15196 RVA: 0x000565A8 File Offset: 0x000547A8
		public virtual void MultiplyMatrix(vtkMatrix3x3 m)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_MultiplyMatrix_37(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x06003B5D RID: 15197
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLContextDevice2D_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003B5E RID: 15198 RVA: 0x000565D8 File Offset: 0x000547D8
		public new vtkOpenGLContextDevice2D NewInstance()
		{
			vtkOpenGLContextDevice2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_NewInstance_39(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLContextDevice2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003B5F RID: 15199
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_PopMatrix_40(HandleRef pThis);

		/// <summary>
		/// Pop the current matrix off of the stack.
		/// </summary>
		// Token: 0x06003B60 RID: 15200 RVA: 0x00056632 File Offset: 0x00054832
		public virtual void PopMatrix()
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_PopMatrix_40(base.GetCppThis());
		}

		// Token: 0x06003B61 RID: 15201
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_PushMatrix_41(HandleRef pThis);

		/// <summary>
		/// Push the current matrix onto the stack.
		/// </summary>
		// Token: 0x06003B62 RID: 15202 RVA: 0x00056641 File Offset: 0x00054841
		public virtual void PushMatrix()
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_PushMatrix_41(base.GetCppThis());
		}

		// Token: 0x06003B63 RID: 15203
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_ReleaseGraphicsResources_42(HandleRef pThis, HandleRef window);

		/// <summary>
		/// Release any graphics resources that are being consumed by this device.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06003B64 RID: 15204 RVA: 0x00056650 File Offset: 0x00054850
		public virtual void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_ReleaseGraphicsResources_42(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		// Token: 0x06003B65 RID: 15205
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLContextDevice2D_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003B66 RID: 15206 RVA: 0x00056680 File Offset: 0x00054880
		public new static vtkOpenGLContextDevice2D SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLContextDevice2D vtkOpenGLContextDevice2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_SafeDownCast_43((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLContextDevice2D = (vtkOpenGLContextDevice2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLContextDevice2D.Register(null);
				}
			}
			return vtkOpenGLContextDevice2D;
		}

		// Token: 0x06003B67 RID: 15207
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_SetClipping_44(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Pop the current matrix off of the stack.
		/// </summary>
		// Token: 0x06003B68 RID: 15208 RVA: 0x000566FF File Offset: 0x000548FF
		public virtual void SetClipping(IntPtr x)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_SetClipping_44(base.GetCppThis(), x);
		}

		// Token: 0x06003B69 RID: 15209
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_SetColor_45(HandleRef pThis, IntPtr color);

		/// <summary>
		/// Set the color for the device using unsigned char of length 3, RGB.
		/// </summary>
		// Token: 0x06003B6A RID: 15210 RVA: 0x0005670F File Offset: 0x0005490F
		public virtual void SetColor(IntPtr color)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_SetColor_45(base.GetCppThis(), color);
		}

		// Token: 0x06003B6B RID: 15211
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_SetColor4_46(HandleRef pThis, IntPtr color);

		/// <summary>
		/// Set the color for the device using unsigned char of length 4, RGBA.
		/// </summary>
		// Token: 0x06003B6C RID: 15212 RVA: 0x0005671F File Offset: 0x0005491F
		public virtual void SetColor4(IntPtr color)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_SetColor4_46(base.GetCppThis(), color);
		}

		// Token: 0x06003B6D RID: 15213
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_SetLineType_47(HandleRef pThis, int type);

		/// <summary>
		/// Set the line type type (using anonymous enum in vtkPen).
		/// </summary>
		// Token: 0x06003B6E RID: 15214 RVA: 0x0005672F File Offset: 0x0005492F
		public virtual void SetLineType(int type)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_SetLineType_47(base.GetCppThis(), type);
		}

		// Token: 0x06003B6F RID: 15215
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_SetLineWidth_48(HandleRef pThis, float width);

		/// <summary>
		/// Set the line width for glyphs/sprites.
		/// </summary>
		// Token: 0x06003B70 RID: 15216 RVA: 0x0005673F File Offset: 0x0005493F
		public virtual void SetLineWidth(float width)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_SetLineWidth_48(base.GetCppThis(), width);
		}

		// Token: 0x06003B71 RID: 15217
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_SetMatrix_49(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Set the model view matrix for the display
		/// </summary>
		// Token: 0x06003B72 RID: 15218 RVA: 0x00056750 File Offset: 0x00054950
		public virtual void SetMatrix(vtkMatrix3x3 m)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_SetMatrix_49(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x06003B73 RID: 15219
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_SetMaximumMarkerCacheSize_50(HandleRef pThis, int _arg);

		/// <summary>
		/// Adjust the size of the MarkerCache. This implementation generates point
		/// sprites for each mark size/shape and uses DrawPointSprites to render them.
		/// The number of cached markers can be accessed with this function.
		/// </summary>
		// Token: 0x06003B74 RID: 15220 RVA: 0x0005677F File Offset: 0x0005497F
		public virtual void SetMaximumMarkerCacheSize(int _arg)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_SetMaximumMarkerCacheSize_50(base.GetCppThis(), _arg);
		}

		// Token: 0x06003B75 RID: 15221
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_SetPointSize_51(HandleRef pThis, float size);

		/// <summary>
		/// Set the point size for glyphs/sprites.
		/// </summary>
		// Token: 0x06003B76 RID: 15222 RVA: 0x0005678F File Offset: 0x0005498F
		public virtual void SetPointSize(float size)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_SetPointSize_51(base.GetCppThis(), size);
		}

		// Token: 0x06003B77 RID: 15223
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLContextDevice2D_SetStringRendererToFreeType_52(HandleRef pThis);

		/// <summary>
		/// Force the use of the freetype based render strategy. If Qt is available
		/// then freetype will be used preferentially, otherwise this has no effect.
		/// Returns true on success.
		/// </summary>
		// Token: 0x06003B78 RID: 15224 RVA: 0x000567A0 File Offset: 0x000549A0
		public bool SetStringRendererToFreeType()
		{
			return vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_SetStringRendererToFreeType_52(base.GetCppThis()) != 0;
		}

		// Token: 0x06003B79 RID: 15225
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLContextDevice2D_SetStringRendererToQt_53(HandleRef pThis);

		/// <summary>
		/// Force the use of the Qt based string render strategy. If Qt is not available
		/// then freetype will be used and this will return false.
		/// </summary>
		// Token: 0x06003B7A RID: 15226 RVA: 0x000567C8 File Offset: 0x000549C8
		public bool SetStringRendererToQt()
		{
			return vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_SetStringRendererToQt_53(base.GetCppThis()) != 0;
		}

		// Token: 0x06003B7B RID: 15227
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice2D_SetTexture_54(HandleRef pThis, HandleRef image, int properties);

		/// <summary>
		/// Set the texture for the device, it is used to fill the polygons
		/// </summary>
		// Token: 0x06003B7C RID: 15228 RVA: 0x000567F0 File Offset: 0x000549F0
		public virtual void SetTexture(vtkImageData image, int properties)
		{
			vtkOpenGLContextDevice2D.vtkOpenGLContextDevice2D_SetTexture_54(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), properties);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400067D RID: 1661
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLContextDevice2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400067E RID: 1662
		public new static readonly string MRClassNameKey = "class vtkOpenGLContextDevice2D";
	}
}
