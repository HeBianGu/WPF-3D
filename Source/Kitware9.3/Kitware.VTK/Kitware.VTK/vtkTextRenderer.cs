using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTextRenderer
	/// </summary>
	/// <remarks>
	///    Interface for generating images and path data from
	/// string data, using multiple backends.
	///
	///
	/// vtkTextRenderer produces images, bounding boxes, and vtkPath
	/// objects that represent text. The advantage of using this class is to easily
	/// integrate mathematical expressions into renderings by automatically switching
	/// between FreeType and MathText backends. If the input string contains at least
	/// two "$" symbols separated by text, the MathText backend will be used.
	/// Alternatively, the presence of unescaped "|" symbols defines multicolumn lines,
	/// which are processed with the MathText backend.
	///
	/// If the string does not meet these criteria, or if no MathText implementation is
	/// available, the faster FreeType rendering facilities are used. Literal $
	/// symbols can be used by escaping them with backslashes, "\$" (or "\\$" if the
	/// string is set programmatically).
	///
	/// For example, "Acceleration ($\\frac{m}{s^2}$)" will use MathText, but
	/// "\\$500, \\$100" will use FreeType.
	///
	/// By default, the backend is set to Detect, which determines the backend based
	/// on the contents of the string. This can be changed by setting the
	/// DefaultBackend ivar.
	///
	/// Note that this class is abstract -- link to the vtkRenderingFreetype module
	/// to get the default implementation.
	/// </remarks>
	// Token: 0x020007BD RID: 1981
	public abstract class vtkTextRenderer : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014530 RID: 83248 RVA: 0x001CBB3C File Offset: 0x001C9D3C
		static vtkTextRenderer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextRenderer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextRenderer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014531 RID: 83249 RVA: 0x001CBB64 File Offset: 0x001C9D64
		public vtkTextRenderer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014532 RID: 83250
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextRenderer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This is a singleton pattern New. There will be only ONE reference
		/// to a vtkTextRenderer subclass object per process. Clients that
		/// call this method must use Delete() on the object so that reference
		/// counting will work. The single instance will be unreferenced when
		/// the program exits. You should just use the static GetInstance() method
		/// anyway to get the singleton. This method may return NULL if the object
		/// factory cannot find an override.
		/// </summary>
		// Token: 0x06014533 RID: 83251 RVA: 0x001CBB74 File Offset: 0x001C9D74
		public new static vtkTextRenderer New()
		{
			vtkTextRenderer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextRenderer.vtkTextRenderer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// This is a singleton pattern New. There will be only ONE reference
		/// to a vtkTextRenderer subclass object per process. Clients that
		/// call this method must use Delete() on the object so that reference
		/// counting will work. The single instance will be unreferenced when
		/// the program exits. You should just use the static GetInstance() method
		/// anyway to get the singleton. This method may return NULL if the object
		/// factory cannot find an override.
		/// </summary>
		// Token: 0x06014534 RID: 83252 RVA: 0x001CBBC8 File Offset: 0x001C9DC8
		public vtkTextRenderer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTextRenderer.vtkTextRenderer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014535 RID: 83253 RVA: 0x001CBC0C File Offset: 0x001C9E0C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014536 RID: 83254
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRenderer_DetectBackend_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str);

		/// <summary>
		/// Determine the appropriate back end needed to render the given string.
		/// </summary>
		// Token: 0x06014537 RID: 83255 RVA: 0x001CBC18 File Offset: 0x001C9E18
		public virtual int DetectBackend(string str)
		{
			return vtkTextRenderer.vtkTextRenderer_DetectBackend_01(base.GetCppThis(), str);
		}

		// Token: 0x06014538 RID: 83256
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTextRenderer_FreeTypeIsSupported_02(HandleRef pThis);

		/// <summary>
		/// Test for availability of various backends
		/// </summary>
		// Token: 0x06014539 RID: 83257 RVA: 0x001CBC38 File Offset: 0x001C9E38
		public virtual bool FreeTypeIsSupported()
		{
			return vtkTextRenderer.vtkTextRenderer_FreeTypeIsSupported_02(base.GetCppThis()) != 0;
		}

		// Token: 0x0601453A RID: 83258
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTextRenderer_GetBoundingBox_03(HandleRef pThis, HandleRef tprop, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, IntPtr bbox, int dpi, int backend);

		/// <summary>
		/// Given a text property and a string, get the bounding box {xmin, xmax,
		/// ymin, ymax} of the rendered string in pixels. The origin of the bounding
		/// box is the anchor point described by the horizontal and vertical
		/// justification text property variables.
		/// Return true on success, false otherwise.
		/// </summary>
		// Token: 0x0601453B RID: 83259 RVA: 0x001CBC60 File Offset: 0x001C9E60
		public bool GetBoundingBox(vtkTextProperty tprop, string str, IntPtr bbox, int dpi, int backend)
		{
			return vtkTextRenderer.vtkTextRenderer_GetBoundingBox_03(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), str, bbox, dpi, backend) != 0;
		}

		// Token: 0x0601453C RID: 83260
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRenderer_GetConstrainedFontSize_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, HandleRef tprop, int targetWidth, int targetHeight, int dpi, int backend);

		/// <summary>
		/// This function returns the font size (in points) and sets the size in @a
		/// tprop that is required to fit the string in the target rectangle. The
		/// computed font size will be set in @a tprop as well. If an error occurs,
		/// this function will return -1.
		/// </summary>
		// Token: 0x0601453D RID: 83261 RVA: 0x001CBCA4 File Offset: 0x001C9EA4
		public int GetConstrainedFontSize(string str, vtkTextProperty tprop, int targetWidth, int targetHeight, int dpi, int backend)
		{
			return vtkTextRenderer.vtkTextRenderer_GetConstrainedFontSize_04(base.GetCppThis(), str, (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), targetWidth, targetHeight, dpi, backend);
		}

		// Token: 0x0601453E RID: 83262
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRenderer_GetDefaultBackend_05(HandleRef pThis);

		/// <summary>
		/// The backend to use when none is specified. Default: Detect
		/// </summary>
		// Token: 0x0601453F RID: 83263 RVA: 0x001CBCE0 File Offset: 0x001C9EE0
		public virtual int GetDefaultBackend()
		{
			return vtkTextRenderer.vtkTextRenderer_GetDefaultBackend_05(base.GetCppThis());
		}

		// Token: 0x06014540 RID: 83264
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextRenderer_GetInstance_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the singleton instance with no reference counting. May return NULL
		/// if the object factory cannot find an override.
		/// </summary>
		// Token: 0x06014541 RID: 83265 RVA: 0x001CBD00 File Offset: 0x001C9F00
		public static vtkTextRenderer GetInstance()
		{
			vtkTextRenderer vtkTextRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextRenderer.vtkTextRenderer_GetInstance_06(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextRenderer = (vtkTextRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextRenderer.Register(null);
				}
			}
			return vtkTextRenderer;
		}

		// Token: 0x06014542 RID: 83266
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextRenderer_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             @}
		/// </summary>
		// Token: 0x06014543 RID: 83267 RVA: 0x001CBD6C File Offset: 0x001C9F6C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTextRenderer.vtkTextRenderer_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06014544 RID: 83268
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextRenderer_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             @}
		/// </summary>
		// Token: 0x06014545 RID: 83269 RVA: 0x001CBD8C File Offset: 0x001C9F8C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTextRenderer.vtkTextRenderer_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06014546 RID: 83270
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRenderer_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             @}
		/// </summary>
		// Token: 0x06014547 RID: 83271 RVA: 0x001CBDA8 File Offset: 0x001C9FA8
		public override int IsA(string type)
		{
			return vtkTextRenderer.vtkTextRenderer_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06014548 RID: 83272
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextRenderer_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             @}
		/// </summary>
		// Token: 0x06014549 RID: 83273 RVA: 0x001CBDC8 File Offset: 0x001C9FC8
		public new static int IsTypeOf(string type)
		{
			return vtkTextRenderer.vtkTextRenderer_IsTypeOf_10(type);
		}

		// Token: 0x0601454A RID: 83274
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTextRenderer_MathTextIsSupported_11(HandleRef pThis);

		/// <summary>
		/// Test for availability of various backends
		/// </summary>
		// Token: 0x0601454B RID: 83275 RVA: 0x001CBDE4 File Offset: 0x001C9FE4
		public virtual bool MathTextIsSupported()
		{
			return vtkTextRenderer.vtkTextRenderer_MathTextIsSupported_11(base.GetCppThis()) != 0;
		}

		// Token: 0x0601454C RID: 83276
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextRenderer_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             @}
		/// </summary>
		// Token: 0x0601454D RID: 83277 RVA: 0x001CBE0C File Offset: 0x001CA00C
		public new vtkTextRenderer NewInstance()
		{
			vtkTextRenderer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextRenderer.vtkTextRenderer_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601454E RID: 83278
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTextRenderer_RenderString_14(HandleRef pThis, HandleRef tprop, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, HandleRef data, IntPtr textDims, int dpi, int backend);

		/// <summary>
		/// Given a text property and a string, this function initializes the
		/// vtkImageData *data and renders it in a vtkImageData.
		/// Return true on success, false otherwise. If using the overload that
		/// specifies "textDims", the array will be overwritten with the pixel width
		/// and height defining a tight bounding box around the text in the image,
		/// starting from the upper-right corner. This is used when rendering for a
		/// texture on graphics hardware that requires texture image dimensions to be
		/// a power of two; textDims can be used to determine the texture coordinates
		/// needed to cleanly fit the text on the target.
		/// The origin of the image's extents is aligned with the anchor point
		/// described by the text property's vertical and horizontal justification
		/// options.
		/// </summary>
		// Token: 0x0601454F RID: 83279 RVA: 0x001CBE68 File Offset: 0x001CA068
		public bool RenderString(vtkTextProperty tprop, string str, vtkImageData data, IntPtr textDims, int dpi, int backend)
		{
			return vtkTextRenderer.vtkTextRenderer_RenderString_14(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), str, (data == null) ? default(HandleRef) : data.GetCppThis(), textDims, dpi, backend) != 0;
		}

		// Token: 0x06014550 RID: 83280
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextRenderer_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             @}
		/// </summary>
		// Token: 0x06014551 RID: 83281 RVA: 0x001CBEC0 File Offset: 0x001CA0C0
		public new static vtkTextRenderer SafeDownCast(vtkObjectBase o)
		{
			vtkTextRenderer vtkTextRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextRenderer.vtkTextRenderer_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextRenderer = (vtkTextRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextRenderer.Register(null);
				}
			}
			return vtkTextRenderer;
		}

		// Token: 0x06014552 RID: 83282
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRenderer_SetDefaultBackend_16(HandleRef pThis, int _arg);

		/// <summary>
		/// The backend to use when none is specified. Default: Detect
		/// </summary>
		// Token: 0x06014553 RID: 83283 RVA: 0x001CBF3F File Offset: 0x001CA13F
		public virtual void SetDefaultBackend(int _arg)
		{
			vtkTextRenderer.vtkTextRenderer_SetDefaultBackend_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06014554 RID: 83284
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextRenderer_SetScaleToPowerOfTwo_17(HandleRef pThis, byte scale);

		/// <summary>
		/// Set to true if the graphics implementation requires texture image dimensions
		/// to be a power of two. Default is true, but this member will be set
		/// appropriately by vtkOpenGLRenderWindow::OpenGLInitContext when GL is
		/// inited.
		/// </summary>
		// Token: 0x06014555 RID: 83285 RVA: 0x001CBF4F File Offset: 0x001CA14F
		public void SetScaleToPowerOfTwo(bool scale)
		{
			vtkTextRenderer.vtkTextRenderer_SetScaleToPowerOfTwo_17(base.GetCppThis(), scale ? (byte)1 : (byte)0);
		}

		// Token: 0x06014556 RID: 83286
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTextRenderer_StringToPath_18(HandleRef pThis, HandleRef tprop, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, HandleRef path, int dpi, int backend);

		/// <summary>
		/// Given a text property and a string, this function populates the vtkPath
		/// path with the outline of the rendered string. The origin of the path
		/// coordinates is aligned with the anchor point described by the text
		/// property's horizontal and vertical justification options.
		/// Return true on success, false otherwise.
		/// </summary>
		// Token: 0x06014557 RID: 83287 RVA: 0x001CBF68 File Offset: 0x001CA168
		public bool StringToPath(vtkTextProperty tprop, string str, vtkPath path, int dpi, int backend)
		{
			return vtkTextRenderer.vtkTextRenderer_StringToPath_18(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis(), str, (path == null) ? default(HandleRef) : path.GetCppThis(), dpi, backend) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001794 RID: 6036
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextRenderer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001795 RID: 6037
		public new static readonly string MRClassNameKey = "class vtkTextRenderer";

		/// <summary>
		/// Available backends. FreeType and MathText are provided in the default
		/// implementation of this interface. Enum values less than 16 are reserved.
		/// Custom overrides should define other backends starting at 16.
		/// </summary>
		// Token: 0x020007BE RID: 1982
		public enum Backend
		{
			/// <summary>enum member</summary>
			// Token: 0x04001797 RID: 6039
			Default = -1,
			/// <summary>enum member</summary>
			// Token: 0x04001798 RID: 6040
			Detect,
			/// <summary>enum member</summary>
			// Token: 0x04001799 RID: 6041
			FreeType,
			/// <summary>enum member</summary>
			// Token: 0x0400179A RID: 6042
			MathText,
			/// <summary>enum member</summary>
			// Token: 0x0400179B RID: 6043
			UserBackend = 16
		}
	}
}
