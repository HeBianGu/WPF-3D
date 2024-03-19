using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLContextDevice3D
	/// </summary>
	/// <remarks>
	///    OpenGL class drawing 3D primitives.
	///
	///
	/// This defines the implementation of a 3D context device for drawing simple
	/// primitives.
	/// </remarks>
	// Token: 0x02000123 RID: 291
	public class vtkOpenGLContextDevice3D : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003B7D RID: 15229 RVA: 0x00056820 File Offset: 0x00054A20
		static vtkOpenGLContextDevice3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLContextDevice3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLContextDevice3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003B7E RID: 15230 RVA: 0x00056848 File Offset: 0x00054A48
		public vtkOpenGLContextDevice3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003B7F RID: 15231
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLContextDevice3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003B80 RID: 15232 RVA: 0x00056858 File Offset: 0x00054A58
		public new static vtkOpenGLContextDevice3D New()
		{
			vtkOpenGLContextDevice3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLContextDevice3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003B81 RID: 15233 RVA: 0x000568AC File Offset: 0x00054AAC
		public vtkOpenGLContextDevice3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003B82 RID: 15234 RVA: 0x000568F0 File Offset: 0x00054AF0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003B83 RID: 15235
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_ApplyBrush_01(HandleRef pThis, HandleRef brush);

		/// <summary>
		/// Apply the supplied brush which controls the outlines of shapes, as well as
		/// lines, points and related primitives. This makes a deep copy of the vtkBrush
		/// object in the vtkContext2D, it does not hold a pointer to the supplied object.
		/// </summary>
		// Token: 0x06003B84 RID: 15236 RVA: 0x000568FC File Offset: 0x00054AFC
		public virtual void ApplyBrush(vtkBrush brush)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_ApplyBrush_01(base.GetCppThis(), (brush == null) ? default(HandleRef) : brush.GetCppThis());
		}

		// Token: 0x06003B85 RID: 15237
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_ApplyPen_02(HandleRef pThis, HandleRef pen);

		/// <summary>
		/// Apply the supplied pen which controls the outlines of shapes, as well as
		/// lines, points and related primitives. This makes a deep copy of the vtkPen
		/// object in the vtkContext2D, it does not hold a pointer to the supplied object.
		/// </summary>
		// Token: 0x06003B86 RID: 15238 RVA: 0x0005692C File Offset: 0x00054B2C
		public virtual void ApplyPen(vtkPen pen)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_ApplyPen_02(base.GetCppThis(), (pen == null) ? default(HandleRef) : pen.GetCppThis());
		}

		// Token: 0x06003B87 RID: 15239
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_Begin_03(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Begin drawing, pass in the viewport to set up the view.
		/// </summary>
		// Token: 0x06003B88 RID: 15240 RVA: 0x0005695C File Offset: 0x00054B5C
		public virtual void Begin(vtkViewport viewport)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_Begin_03(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06003B89 RID: 15241
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_DisableClippingPlane_04(HandleRef pThis, int i);

		/// <summary>
		/// Enable/Disable the specified clipping plane.
		/// i is the index of the clipping plane being enabled or disabled (0 - 5).
		/// planeEquation points to the four coefficients of the equation for the
		/// clipping plane: Ax + By + Cz + D = 0.  This is the equation format
		/// expected by glClipPlane.
		/// </summary>
		// Token: 0x06003B8A RID: 15242 RVA: 0x0005698B File Offset: 0x00054B8B
		public virtual void DisableClippingPlane(int i)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_DisableClippingPlane_04(base.GetCppThis(), i);
		}

		// Token: 0x06003B8B RID: 15243
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_DrawLines_05(HandleRef pThis, IntPtr verts, int n, IntPtr colors, int nc);

		/// <summary>
		/// Draw lines defined by specified pair of points.
		/// \sa DrawPoly()
		/// </summary>
		// Token: 0x06003B8C RID: 15244 RVA: 0x0005699B File Offset: 0x00054B9B
		public virtual void DrawLines(IntPtr verts, int n, IntPtr colors, int nc)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_DrawLines_05(base.GetCppThis(), verts, n, colors, nc);
		}

		// Token: 0x06003B8D RID: 15245
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_DrawPoints_06(HandleRef pThis, IntPtr verts, int n, IntPtr colors, int nc);

		/// <summary>
		/// Draw points at the vertex positions specified.
		/// </summary>
		// Token: 0x06003B8E RID: 15246 RVA: 0x000569AF File Offset: 0x00054BAF
		public virtual void DrawPoints(IntPtr verts, int n, IntPtr colors, int nc)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_DrawPoints_06(base.GetCppThis(), verts, n, colors, nc);
		}

		// Token: 0x06003B8F RID: 15247
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_DrawPoints_07(HandleRef pThis, HandleRef positions, HandleRef colors, ulong cacheIdentifier);

		/// <summary>
		/// Draw points at the vertex positions specified.
		/// </summary>
		// Token: 0x06003B90 RID: 15248 RVA: 0x000569C4 File Offset: 0x00054BC4
		public virtual void DrawPoints(vtkDataArray positions, vtkUnsignedCharArray colors, ulong cacheIdentifier)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_DrawPoints_07(base.GetCppThis(), (positions == null) ? default(HandleRef) : positions.GetCppThis(), (colors == null) ? default(HandleRef) : colors.GetCppThis(), cacheIdentifier);
		}

		// Token: 0x06003B91 RID: 15249
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_DrawPoly_08(HandleRef pThis, IntPtr verts, int n, IntPtr colors, int nc);

		/// <summary>
		/// Draw a polyline between the specified points.
		/// </summary>
		// Token: 0x06003B92 RID: 15250 RVA: 0x00056A09 File Offset: 0x00054C09
		public virtual void DrawPoly(IntPtr verts, int n, IntPtr colors, int nc)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_DrawPoly_08(base.GetCppThis(), verts, n, colors, nc);
		}

		// Token: 0x06003B93 RID: 15251
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_DrawTriangleMesh_09(HandleRef pThis, IntPtr mesh, int n, IntPtr colors, int nc);

		/// <summary>
		/// Draw triangles to generate the specified mesh.
		/// </summary>
		// Token: 0x06003B94 RID: 15252 RVA: 0x00056A1D File Offset: 0x00054C1D
		public virtual void DrawTriangleMesh(IntPtr mesh, int n, IntPtr colors, int nc)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_DrawTriangleMesh_09(base.GetCppThis(), mesh, n, colors, nc);
		}

		// Token: 0x06003B95 RID: 15253
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_DrawTriangleMesh_10(HandleRef pThis, HandleRef positions, HandleRef colors, ulong cacheIdentifier);

		/// <summary>
		/// Draw triangles to generate the specified mesh.
		/// </summary>
		// Token: 0x06003B96 RID: 15254 RVA: 0x00056A34 File Offset: 0x00054C34
		public virtual void DrawTriangleMesh(vtkDataArray positions, vtkUnsignedCharArray colors, ulong cacheIdentifier)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_DrawTriangleMesh_10(base.GetCppThis(), (positions == null) ? default(HandleRef) : positions.GetCppThis(), (colors == null) ? default(HandleRef) : colors.GetCppThis(), cacheIdentifier);
		}

		// Token: 0x06003B97 RID: 15255
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_EnableClipping_11(HandleRef pThis, byte enable);

		/// <summary>
		/// Enable or disable the clipping of the scene.
		/// </summary>
		// Token: 0x06003B98 RID: 15256 RVA: 0x00056A79 File Offset: 0x00054C79
		public virtual void EnableClipping(bool enable)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_EnableClipping_11(base.GetCppThis(), enable ? (byte)1 : (byte)0);
		}

		// Token: 0x06003B99 RID: 15257
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_EnableClippingPlane_12(HandleRef pThis, int i, IntPtr planeEquation);

		/// <summary>
		/// Enable/Disable the specified clipping plane.
		/// i is the index of the clipping plane being enabled or disabled (0 - 5).
		/// planeEquation points to the four coefficients of the equation for the
		/// clipping plane: Ax + By + Cz + D = 0.  This is the equation format
		/// expected by glClipPlane.
		/// </summary>
		// Token: 0x06003B9A RID: 15258 RVA: 0x00056A91 File Offset: 0x00054C91
		public virtual void EnableClippingPlane(int i, IntPtr planeEquation)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_EnableClippingPlane_12(base.GetCppThis(), i, planeEquation);
		}

		// Token: 0x06003B9B RID: 15259
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_GetMatrix_13(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Set the model view matrix for the display
		/// </summary>
		// Token: 0x06003B9C RID: 15260 RVA: 0x00056AA4 File Offset: 0x00054CA4
		public virtual void GetMatrix(vtkMatrix4x4 m)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_GetMatrix_13(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x06003B9D RID: 15261
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLContextDevice3D_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003B9E RID: 15262 RVA: 0x00056AD4 File Offset: 0x00054CD4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x06003B9F RID: 15263
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLContextDevice3D_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BA0 RID: 15264 RVA: 0x00056AF4 File Offset: 0x00054CF4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x06003BA1 RID: 15265
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_Initialize_16(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// This must be set during initialization
		/// </summary>
		// Token: 0x06003BA2 RID: 15266 RVA: 0x00056B10 File Offset: 0x00054D10
		public void Initialize(vtkRenderer arg0, vtkOpenGLContextDevice2D arg1)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_Initialize_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06003BA3 RID: 15267
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLContextDevice3D_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BA4 RID: 15268 RVA: 0x00056B54 File Offset: 0x00054D54
		public override int IsA(string type)
		{
			return vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x06003BA5 RID: 15269
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLContextDevice3D_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BA6 RID: 15270 RVA: 0x00056B74 File Offset: 0x00054D74
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_IsTypeOf_18(type);
		}

		// Token: 0x06003BA7 RID: 15271
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_MultiplyMatrix_19(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Multiply the current model view matrix by the supplied one
		/// </summary>
		// Token: 0x06003BA8 RID: 15272 RVA: 0x00056B90 File Offset: 0x00054D90
		public virtual void MultiplyMatrix(vtkMatrix4x4 m)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_MultiplyMatrix_19(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x06003BA9 RID: 15273
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLContextDevice3D_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BAA RID: 15274 RVA: 0x00056BC0 File Offset: 0x00054DC0
		public new vtkOpenGLContextDevice3D NewInstance()
		{
			vtkOpenGLContextDevice3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLContextDevice3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003BAB RID: 15275
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_PopMatrix_22(HandleRef pThis);

		/// <summary>
		/// Pop the current matrix off of the stack.
		/// </summary>
		// Token: 0x06003BAC RID: 15276 RVA: 0x00056C1A File Offset: 0x00054E1A
		public virtual void PopMatrix()
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_PopMatrix_22(base.GetCppThis());
		}

		// Token: 0x06003BAD RID: 15277
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_PushMatrix_23(HandleRef pThis);

		/// <summary>
		/// Push the current matrix onto the stack.
		/// </summary>
		// Token: 0x06003BAE RID: 15278 RVA: 0x00056C29 File Offset: 0x00054E29
		public virtual void PushMatrix()
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_PushMatrix_23(base.GetCppThis());
		}

		// Token: 0x06003BAF RID: 15279
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_ReleaseCache_24(HandleRef pThis, ulong cacheIdentifier);

		/// <summary>
		/// Ask the buffer object builder to erase cache entry for given identifier.
		/// </summary>
		// Token: 0x06003BB0 RID: 15280 RVA: 0x00056C38 File Offset: 0x00054E38
		public virtual void ReleaseCache(ulong cacheIdentifier)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_ReleaseCache_24(base.GetCppThis(), cacheIdentifier);
		}

		// Token: 0x06003BB1 RID: 15281
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLContextDevice3D_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003BB2 RID: 15282 RVA: 0x00056C48 File Offset: 0x00054E48
		public new static vtkOpenGLContextDevice3D SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLContextDevice3D vtkOpenGLContextDevice3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLContextDevice3D = (vtkOpenGLContextDevice3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLContextDevice3D.Register(null);
				}
			}
			return vtkOpenGLContextDevice3D;
		}

		// Token: 0x06003BB3 RID: 15283
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_SetClipping_26(HandleRef pThis, HandleRef rect);

		/// <summary>
		/// Supply a float array of length 4 with x1, y1, width, height specifying
		/// clipping region for the device in pixels.
		/// </summary>
		// Token: 0x06003BB4 RID: 15284 RVA: 0x00056CC8 File Offset: 0x00054EC8
		public virtual void SetClipping(vtkRecti rect)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_SetClipping_26(base.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis());
		}

		// Token: 0x06003BB5 RID: 15285
		[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLContextDevice3D_SetMatrix_27(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Set the model view matrix for the display
		/// </summary>
		// Token: 0x06003BB6 RID: 15286 RVA: 0x00056CF8 File Offset: 0x00054EF8
		public virtual void SetMatrix(vtkMatrix4x4 m)
		{
			vtkOpenGLContextDevice3D.vtkOpenGLContextDevice3D_SetMatrix_27(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400067F RID: 1663
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLContextDevice3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000680 RID: 1664
		public new static readonly string MRClassNameKey = "class vtkOpenGLContextDevice3D";
	}
}
