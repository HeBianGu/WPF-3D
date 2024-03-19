using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLGL2PSHelper
	/// </summary>
	/// <remarks>
	///    Access GL2PS functionality.
	///
	///
	/// This class provides convenience functions that can be used to draw into a
	/// GL2PS context. Link to vtkRenderingGL2PSOpenGL2 to bring in the
	/// vtkOpenGLGL2PSHelperImpl class, the object factory override that implements
	/// this interface.
	/// </remarks>
	// Token: 0x020001B1 RID: 433
	public abstract class vtkOpenGLGL2PSHelper : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060053AB RID: 21419 RVA: 0x00079ADB File Offset: 0x00077CDB
		static vtkOpenGLGL2PSHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLGL2PSHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLGL2PSHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060053AC RID: 21420 RVA: 0x00079B03 File Offset: 0x00077D03
		public vtkOpenGLGL2PSHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060053AD RID: 21421
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLGL2PSHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053AE RID: 21422 RVA: 0x00079B14 File Offset: 0x00077D14
		public new static vtkOpenGLGL2PSHelper New()
		{
			vtkOpenGLGL2PSHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLGL2PSHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053AF RID: 21423 RVA: 0x00079B68 File Offset: 0x00077D68
		public vtkOpenGLGL2PSHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060053B0 RID: 21424 RVA: 0x00079BAC File Offset: 0x00077DAC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060053B1 RID: 21425
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGL2PSHelper_Draw3DPath_01(HandleRef pThis, HandleRef path, HandleRef actorMatrix, IntPtr rasterPos, IntPtr actorColor, HandleRef ren, [MarshalAs(UnmanagedType.LPUTF8Str)] string label);

		/// <summary>
		/// Transform the path using the actor's matrix and current GL state, then
		/// draw it to GL2PS. The label string is inserted into the GL2PS output at the
		/// beginning of the path specification as a comment on supported backends.
		/// </summary>
		// Token: 0x060053B2 RID: 21426 RVA: 0x00079BB8 File Offset: 0x00077DB8
		public virtual void Draw3DPath(vtkPath path, vtkMatrix4x4 actorMatrix, IntPtr rasterPos, IntPtr actorColor, vtkRenderer ren, string label)
		{
			vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_Draw3DPath_01(base.GetCppThis(), (path == null) ? default(HandleRef) : path.GetCppThis(), (actorMatrix == null) ? default(HandleRef) : actorMatrix.GetCppThis(), rasterPos, actorColor, (ren == null) ? default(HandleRef) : ren.GetCppThis(), label);
		}

		// Token: 0x060053B3 RID: 21427
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGL2PSHelper_DrawImage_02(HandleRef pThis, HandleRef image, IntPtr pos);

		/// <summary>
		/// Draw the image at pos.
		/// Image must be RGB or RGBA with float scalars.
		/// </summary>
		// Token: 0x060053B4 RID: 21428 RVA: 0x00079C18 File Offset: 0x00077E18
		public virtual void DrawImage(vtkImageData image, IntPtr pos)
		{
			vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_DrawImage_02(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), pos);
		}

		// Token: 0x060053B5 RID: 21429
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGL2PSHelper_DrawPath_03(HandleRef pThis, HandleRef path, IntPtr rasterPos, IntPtr windowPos, IntPtr rgba, IntPtr scale, double rotateAngle, float strokeWidth, [MarshalAs(UnmanagedType.LPUTF8Str)] string label);

		/// <summary>
		/// Generate PS, EPS, or SVG markup from a vtkPath object, and then inject it
		/// into the output using the gl2psSpecial command. The path is translated
		/// uniformly in the scene by windowPos. It is scaled by scale and rotated
		/// counter-clockwise by rotateAngle. The rasterPos is in world coordinates
		/// and determines clipping and depth. If scale is NULL, no scaling is done.
		/// If strokeWidth is positive, the path will be stroked with the indicated
		/// width. If zero or negative, the path will be filled (default).
		/// The label string is inserted into the GL2PS output at the beginning of the
		/// path specification as a comment on supported backends.
		/// </summary>
		// Token: 0x060053B6 RID: 21430 RVA: 0x00079C48 File Offset: 0x00077E48
		public virtual void DrawPath(vtkPath path, IntPtr rasterPos, IntPtr windowPos, IntPtr rgba, IntPtr scale, double rotateAngle, float strokeWidth, string label)
		{
			vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_DrawPath_03(base.GetCppThis(), (path == null) ? default(HandleRef) : path.GetCppThis(), rasterPos, windowPos, rgba, scale, rotateAngle, strokeWidth, label);
		}

		// Token: 0x060053B7 RID: 21431
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGL2PSHelper_DrawString_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, HandleRef tprop, IntPtr pos, double backgroundDepth, HandleRef ren);

		/// <summary>
		/// Format the text in str according to tprop and instruct GL2PS to draw it at
		/// pixel coordinate pos. Background depth is the z value for the background
		/// quad, and should be in NDC space.
		/// The drawing is always done in the overlay plane.
		/// @sa TextAsPath
		/// </summary>
		// Token: 0x060053B8 RID: 21432 RVA: 0x00079C84 File Offset: 0x00077E84
		public virtual void DrawString(string str, vtkTextProperty tprop, IntPtr pos, double backgroundDepth, vtkRenderer ren)
		{
			vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_DrawString_04(base.GetCppThis(), str, (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), pos, backgroundDepth, (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x060053B9 RID: 21433
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkOpenGLGL2PSHelper.State vtkOpenGLGL2PSHelper_GetActiveState_05(HandleRef pThis);

		/// <summary>
		/// Get the current export state. Vector images are rendered in two passes:
		/// First, all non-vectorizable props are rendered, and the resulting image
		/// is inserted as a raster image into the background of the exported file
		/// (ActiveState == Background). Next, all vectorizable props are drawn
		/// and captured into GL2PS, where they are drawn over the background image.
		/// Vectorizable props should not draw themselves during the background pass,
		/// and use the vtkOpenGLGL2PSHelper API to draw themselves during the capture
		/// pass.
		/// </summary>
		// Token: 0x060053BA RID: 21434 RVA: 0x00079CD0 File Offset: 0x00077ED0
		public virtual vtkOpenGLGL2PSHelper.State GetActiveState()
		{
			return vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_GetActiveState_05(base.GetCppThis());
		}

		// Token: 0x060053BB RID: 21435
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLGL2PSHelper_GetInstance_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The global instance. Only set during export.
		/// </summary>
		// Token: 0x060053BC RID: 21436 RVA: 0x00079CF0 File Offset: 0x00077EF0
		public static vtkOpenGLGL2PSHelper GetInstance()
		{
			vtkOpenGLGL2PSHelper vtkOpenGLGL2PSHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_GetInstance_06(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLGL2PSHelper = (vtkOpenGLGL2PSHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLGL2PSHelper.Register(null);
				}
			}
			return vtkOpenGLGL2PSHelper;
		}

		// Token: 0x060053BD RID: 21437
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkOpenGLGL2PSHelper_GetLineStipple_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the current line stipple pattern per OpenGL convention. Default is
		/// 0xffff.
		/// </summary>
		// Token: 0x060053BE RID: 21438 RVA: 0x00079D5C File Offset: 0x00077F5C
		public virtual ushort GetLineStipple()
		{
			return vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_GetLineStipple_07(base.GetCppThis());
		}

		// Token: 0x060053BF RID: 21439
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLGL2PSHelper_GetLineWidth_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the current line width.
		/// </summary>
		// Token: 0x060053C0 RID: 21440 RVA: 0x00079D7C File Offset: 0x00077F7C
		public virtual float GetLineWidth()
		{
			return vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_GetLineWidth_08(base.GetCppThis());
		}

		// Token: 0x060053C1 RID: 21441
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLGL2PSHelper_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053C2 RID: 21442 RVA: 0x00079D9C File Offset: 0x00077F9C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x060053C3 RID: 21443
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLGL2PSHelper_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053C4 RID: 21444 RVA: 0x00079DBC File Offset: 0x00077FBC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x060053C5 RID: 21445
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkOpenGLGL2PSHelper_GetPointSize_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the current point size.
		/// </summary>
		// Token: 0x060053C6 RID: 21446 RVA: 0x00079DD8 File Offset: 0x00077FD8
		public virtual float GetPointSize()
		{
			return vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_GetPointSize_11(base.GetCppThis());
		}

		// Token: 0x060053C7 RID: 21447
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLGL2PSHelper_GetRenderWindow_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the renderwindow that's being exported.
		/// </summary>
		// Token: 0x060053C8 RID: 21448 RVA: 0x00079DF8 File Offset: 0x00077FF8
		public virtual vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_GetRenderWindow_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060053C9 RID: 21449
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLGL2PSHelper_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053CA RID: 21450 RVA: 0x00079E68 File Offset: 0x00078068
		public override int IsA(string type)
		{
			return vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x060053CB RID: 21451
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLGL2PSHelper_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053CC RID: 21452 RVA: 0x00079E88 File Offset: 0x00078088
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_IsTypeOf_14(type);
		}

		// Token: 0x060053CD RID: 21453
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLGL2PSHelper_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053CE RID: 21454 RVA: 0x00079EA4 File Offset: 0x000780A4
		public new vtkOpenGLGL2PSHelper NewInstance()
		{
			vtkOpenGLGL2PSHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLGL2PSHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060053CF RID: 21455
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLGL2PSHelper_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060053D0 RID: 21456 RVA: 0x00079F00 File Offset: 0x00078100
		public new static vtkOpenGLGL2PSHelper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLGL2PSHelper vtkOpenGLGL2PSHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLGL2PSHelper = (vtkOpenGLGL2PSHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLGL2PSHelper.Register(null);
				}
			}
			return vtkOpenGLGL2PSHelper;
		}

		// Token: 0x060053D1 RID: 21457
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGL2PSHelper_SetInstance_18(HandleRef arg0);

		/// <summary>
		/// The global instance. Only set during export.
		/// </summary>
		// Token: 0x060053D2 RID: 21458 RVA: 0x00079F80 File Offset: 0x00078180
		public static void SetInstance(vtkOpenGLGL2PSHelper arg0)
		{
			vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_SetInstance_18((arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060053D3 RID: 21459
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGL2PSHelper_SetLineStipple_19(HandleRef pThis, ushort _arg);

		/// <summary>
		/// Set/Get the current line stipple pattern per OpenGL convention. Default is
		/// 0xffff.
		/// </summary>
		// Token: 0x060053D4 RID: 21460 RVA: 0x00079FA9 File Offset: 0x000781A9
		public virtual void SetLineStipple(ushort _arg)
		{
			vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_SetLineStipple_19(base.GetCppThis(), _arg);
		}

		// Token: 0x060053D5 RID: 21461
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGL2PSHelper_SetLineWidth_20(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the current line width.
		/// </summary>
		// Token: 0x060053D6 RID: 21462 RVA: 0x00079FB9 File Offset: 0x000781B9
		public virtual void SetLineWidth(float _arg)
		{
			vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_SetLineWidth_20(base.GetCppThis(), _arg);
		}

		// Token: 0x060053D7 RID: 21463
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLGL2PSHelper_SetPointSize_21(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the current point size.
		/// </summary>
		// Token: 0x060053D8 RID: 21464 RVA: 0x00079FC9 File Offset: 0x000781C9
		public virtual void SetPointSize(float _arg)
		{
			vtkOpenGLGL2PSHelper.vtkOpenGLGL2PSHelper_SetPointSize_21(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007CD RID: 1997
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLGL2PSHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007CE RID: 1998
		public new static readonly string MRClassNameKey = "class vtkOpenGLGL2PSHelper";

		/// <summary>
		/// Get the renderwindow that's being exported.
		/// </summary>
		// Token: 0x020001B2 RID: 434
		public enum State
		{
			/// <summary>enum member</summary>
			// Token: 0x040007D0 RID: 2000
			Background = 1,
			/// <summary>enum member</summary>
			// Token: 0x040007D1 RID: 2001
			Capture,
			/// <summary>enum member</summary>
			// Token: 0x040007D2 RID: 2002
			Inactive = 0
		}
	}
}
