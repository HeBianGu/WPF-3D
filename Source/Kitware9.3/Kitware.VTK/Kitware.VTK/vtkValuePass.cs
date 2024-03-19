using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkValuePass
	///
	/// Renders geometry using the values of a field array as fragment colors. The
	/// output can be used for deferred color mapping. It supports using arrays of
	/// either point or cell data. The target array can be selected by setting an
	/// array name/id and a component number. Only opaque geometry is supported.
	///
	/// There are two rendering modes available:
	///
	/// * INVERTIBLE_LUT  Encodes array values as RGB data and renders the result to
	/// the default framebuffer.  It uses a texture as a color LUT to map the values
	/// to RGB data. Texture size constraints limit its precision (currently 12-bit).
	/// The implementation of this mode is in vtkInternalsInvertible. This option
	/// is deprecated now that the SGI patent on floating point textures has
	/// expired and Mesa and other OpenGL's always supports it.
	///
	/// * FLOATING_POINT  Renders actual array values as floating point data to an
	/// internal RGBA32F framebuffer.  This class binds and unbinds the framebuffer
	/// on each render pass. Resources are allocated on demand. When rendering point
	/// data values are uploaded to the GPU as vertex attributes. When rendering cell
	/// data values are uploaded as a texture buffer. Custom vertex and fragment
	/// shaders are defined in order to adjust its behavior for either type of data.
	///
	/// </summary>
	/// <seealso>
	///
	/// vtkRenderPass vtkOpenGLRenderPass
	/// </seealso>
	// Token: 0x020005F4 RID: 1524
	public class vtkValuePass : vtkOpenGLRenderPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060108EB RID: 67819 RVA: 0x00171C2B File Offset: 0x0016FE2B
		static vtkValuePass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkValuePass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkValuePass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060108EC RID: 67820 RVA: 0x00171C53 File Offset: 0x0016FE53
		public vtkValuePass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060108ED RID: 67821
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkValuePass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108EE RID: 67822 RVA: 0x00171C64 File Offset: 0x0016FE64
		public new static vtkValuePass New()
		{
			vtkValuePass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkValuePass.vtkValuePass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkValuePass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108EF RID: 67823 RVA: 0x00171CB8 File Offset: 0x0016FEB8
		public vtkValuePass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkValuePass.vtkValuePass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060108F0 RID: 67824 RVA: 0x00171CFC File Offset: 0x0016FEFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060108F1 RID: 67825
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkValuePass_GetFloatImageData_01(HandleRef pThis, int format, int width, int height, IntPtr data);

		/// <summary>
		/// Interface to get the rendered image in FLOATING_POINT mode.  Low level API,
		/// a format for the internal glReadPixels call can be specified. 'data' is expected
		/// to be allocated and cleaned-up by the caller.
		/// </summary>
		// Token: 0x060108F2 RID: 67826 RVA: 0x00171D07 File Offset: 0x0016FF07
		public void GetFloatImageData(int format, int width, int height, IntPtr data)
		{
			vtkValuePass.vtkValuePass_GetFloatImageData_01(base.GetCppThis(), format, width, height, data);
		}

		// Token: 0x060108F3 RID: 67827
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkValuePass_GetFloatImageDataArray_02(HandleRef pThis, HandleRef ren, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Interface to get the rendered image in FLOATING_POINT mode.  Returns a
		/// single component array containing the rendered values.
		/// \warning The returned array is owned by this class.
		/// </summary>
		// Token: 0x060108F4 RID: 67828 RVA: 0x00171D1C File Offset: 0x0016FF1C
		public vtkFloatArray GetFloatImageDataArray(vtkRenderer ren)
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkValuePass.vtkValuePass_GetFloatImageDataArray_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		// Token: 0x060108F5 RID: 67829
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkValuePass_GetFloatImageExtents_03(HandleRef pThis);

		/// <summary>
		/// Interface to get the rendered image in FLOATING_POINT mode.  Image extents of
		/// the value array.
		/// </summary>
		// Token: 0x060108F6 RID: 67830 RVA: 0x00171DA4 File Offset: 0x0016FFA4
		public IntPtr GetFloatImageExtents()
		{
			return vtkValuePass.vtkValuePass_GetFloatImageExtents_03(base.GetCppThis());
		}

		// Token: 0x060108F7 RID: 67831
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkValuePass_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108F8 RID: 67832 RVA: 0x00171DC4 File Offset: 0x0016FFC4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkValuePass.vtkValuePass_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060108F9 RID: 67833
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkValuePass_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108FA RID: 67834 RVA: 0x00171DE4 File Offset: 0x0016FFE4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkValuePass.vtkValuePass_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060108FB RID: 67835
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkValuePass_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108FC RID: 67836 RVA: 0x00171E00 File Offset: 0x00170000
		public override int IsA(string type)
		{
			return vtkValuePass.vtkValuePass_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060108FD RID: 67837
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkValuePass_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060108FE RID: 67838 RVA: 0x00171E20 File Offset: 0x00170020
		public new static int IsTypeOf(string type)
		{
			return vtkValuePass.vtkValuePass_IsTypeOf_07(type);
		}

		// Token: 0x060108FF RID: 67839
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkValuePass_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010900 RID: 67840 RVA: 0x00171E3C File Offset: 0x0017003C
		public new vtkValuePass NewInstance()
		{
			vtkValuePass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkValuePass.vtkValuePass_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkValuePass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010901 RID: 67841
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkValuePass_ReleaseGraphicsResources_10(HandleRef pThis, HandleRef win);

		/// <summary>
		/// Interface to get the rendered image in FLOATING_POINT mode.  Image extents of
		/// the value array.
		/// </summary>
		// Token: 0x06010902 RID: 67842 RVA: 0x00171E98 File Offset: 0x00170098
		public override void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkValuePass.vtkValuePass_ReleaseGraphicsResources_10(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x06010903 RID: 67843
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkValuePass_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010904 RID: 67844 RVA: 0x00171EC8 File Offset: 0x001700C8
		public new static vtkValuePass SafeDownCast(vtkObjectBase o)
		{
			vtkValuePass vtkValuePass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkValuePass.vtkValuePass_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkValuePass = (vtkValuePass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkValuePass.Register(null);
				}
			}
			return vtkValuePass;
		}

		// Token: 0x06010905 RID: 67845
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkValuePass_SetInputArrayToProcess_12(HandleRef pThis, int fieldAssociation, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010906 RID: 67846 RVA: 0x00171F47 File Offset: 0x00170147
		public void SetInputArrayToProcess(int fieldAssociation, string name)
		{
			vtkValuePass.vtkValuePass_SetInputArrayToProcess_12(base.GetCppThis(), fieldAssociation, name);
		}

		// Token: 0x06010907 RID: 67847
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkValuePass_SetInputArrayToProcess_13(HandleRef pThis, int fieldAssociation, int fieldId);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010908 RID: 67848 RVA: 0x00171F58 File Offset: 0x00170158
		public void SetInputArrayToProcess(int fieldAssociation, int fieldId)
		{
			vtkValuePass.vtkValuePass_SetInputArrayToProcess_13(base.GetCppThis(), fieldAssociation, fieldId);
		}

		// Token: 0x06010909 RID: 67849
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkValuePass_SetInputComponentToProcess_14(HandleRef pThis, int component);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601090A RID: 67850 RVA: 0x00171F69 File Offset: 0x00170169
		public void SetInputComponentToProcess(int component)
		{
			vtkValuePass.vtkValuePass_SetInputComponentToProcess_14(base.GetCppThis(), component);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400133D RID: 4925
		public new const string MRFullTypeName = "Kitware.VTK.vtkValuePass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400133E RID: 4926
		public new static readonly string MRClassNameKey = "class vtkValuePass";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020005F5 RID: 1525
		public enum Mode
		{
			/// <summary>enum member</summary>
			// Token: 0x04001340 RID: 4928
			FLOATING_POINT = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001341 RID: 4929
			INVERTIBLE_LUT = 1
		}
	}
}
