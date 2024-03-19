using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLImageMapper
	/// </summary>
	/// <remarks>
	///    2D image display support for OpenGL
	///
	/// vtkOpenGLImageMapper is a concrete subclass of vtkImageMapper that
	/// renders images under OpenGL
	///
	/// @warning
	/// vtkOpenGLImageMapper does not support vtkBitArray, you have to convert the array first
	/// to vtkUnsignedCharArray (for example)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageMapper
	/// </seealso>
	// Token: 0x020005B7 RID: 1463
	public class vtkOpenGLImageMapper : vtkImageMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601003B RID: 65595 RVA: 0x001649CD File Offset: 0x00162BCD
		static vtkOpenGLImageMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLImageMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLImageMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601003C RID: 65596 RVA: 0x001649F5 File Offset: 0x00162BF5
		public vtkOpenGLImageMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601003D RID: 65597
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLImageMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601003E RID: 65598 RVA: 0x00164A04 File Offset: 0x00162C04
		public new static vtkOpenGLImageMapper New()
		{
			vtkOpenGLImageMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLImageMapper.vtkOpenGLImageMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLImageMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601003F RID: 65599 RVA: 0x00164A58 File Offset: 0x00162C58
		public vtkOpenGLImageMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLImageMapper.vtkOpenGLImageMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010040 RID: 65600 RVA: 0x00164A9C File Offset: 0x00162C9C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010041 RID: 65601
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLImageMapper_DrawPixels_01(HandleRef pThis, HandleRef viewport, int width, int height, int numComponents, IntPtr data);

		/// <summary>
		/// draw the data once it has been converted to uchar, windowed leveled
		/// used internally by the templated functions
		/// </summary>
		// Token: 0x06010042 RID: 65602 RVA: 0x00164AA8 File Offset: 0x00162CA8
		public void DrawPixels(vtkViewport viewport, int width, int height, int numComponents, IntPtr data)
		{
			vtkOpenGLImageMapper.vtkOpenGLImageMapper_DrawPixels_01(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), width, height, numComponents, data);
		}

		// Token: 0x06010043 RID: 65603
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLImageMapper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010044 RID: 65604 RVA: 0x00164AE0 File Offset: 0x00162CE0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLImageMapper.vtkOpenGLImageMapper_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06010045 RID: 65605
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLImageMapper_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010046 RID: 65606 RVA: 0x00164B00 File Offset: 0x00162D00
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLImageMapper.vtkOpenGLImageMapper_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06010047 RID: 65607
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLImageMapper_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010048 RID: 65608 RVA: 0x00164B1C File Offset: 0x00162D1C
		public override int IsA(string type)
		{
			return vtkOpenGLImageMapper.vtkOpenGLImageMapper_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06010049 RID: 65609
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLImageMapper_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601004A RID: 65610 RVA: 0x00164B3C File Offset: 0x00162D3C
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLImageMapper.vtkOpenGLImageMapper_IsTypeOf_05(type);
		}

		// Token: 0x0601004B RID: 65611
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLImageMapper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601004C RID: 65612 RVA: 0x00164B58 File Offset: 0x00162D58
		public new vtkOpenGLImageMapper NewInstance()
		{
			vtkOpenGLImageMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLImageMapper.vtkOpenGLImageMapper_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLImageMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601004D RID: 65613
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLImageMapper_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this
		/// mapper, the image texture in particular.
		/// </summary>
		// Token: 0x0601004E RID: 65614 RVA: 0x00164BB4 File Offset: 0x00162DB4
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOpenGLImageMapper.vtkOpenGLImageMapper_ReleaseGraphicsResources_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601004F RID: 65615
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLImageMapper_RenderData_09(HandleRef pThis, HandleRef viewport, HandleRef data, HandleRef actor);

		/// <summary>
		/// Called by the Render function in vtkImageMapper.  Actually draws
		/// the image to the screen.
		/// </summary>
		// Token: 0x06010050 RID: 65616 RVA: 0x00164BE4 File Offset: 0x00162DE4
		public override void RenderData(vtkViewport viewport, vtkImageData data, vtkActor2D actor)
		{
			vtkOpenGLImageMapper.vtkOpenGLImageMapper_RenderData_09(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		// Token: 0x06010051 RID: 65617
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLImageMapper_RenderOverlay_10(HandleRef pThis, HandleRef viewport, HandleRef actor);

		/// <summary>
		/// Handle the render method.
		/// </summary>
		// Token: 0x06010052 RID: 65618 RVA: 0x00164C40 File Offset: 0x00162E40
		public override void RenderOverlay(vtkViewport viewport, vtkActor2D actor)
		{
			vtkOpenGLImageMapper.vtkOpenGLImageMapper_RenderOverlay_10(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		// Token: 0x06010053 RID: 65619
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLImageMapper_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010054 RID: 65620 RVA: 0x00164C84 File Offset: 0x00162E84
		public new static vtkOpenGLImageMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLImageMapper vtkOpenGLImageMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLImageMapper.vtkOpenGLImageMapper_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLImageMapper = (vtkOpenGLImageMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLImageMapper.Register(null);
				}
			}
			return vtkOpenGLImageMapper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012B0 RID: 4784
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLImageMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012B1 RID: 4785
		public new static readonly string MRClassNameKey = "class vtkOpenGLImageMapper";
	}
}
