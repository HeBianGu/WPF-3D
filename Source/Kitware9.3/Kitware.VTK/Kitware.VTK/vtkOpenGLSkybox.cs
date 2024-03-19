using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLSkybox
	/// </summary>
	/// <remarks>
	///    OpenGL Skybox
	///
	/// vtkOpenGLSkybox is a concrete implementation of the abstract class vtkSkybox.
	/// vtkOpenGLSkybox interfaces to the OpenGL rendering library.
	/// </remarks>
	// Token: 0x020005CB RID: 1483
	public class vtkOpenGLSkybox : vtkSkybox
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601035D RID: 66397 RVA: 0x00169249 File Offset: 0x00167449
		static vtkOpenGLSkybox()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLSkybox.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLSkybox"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601035E RID: 66398 RVA: 0x00169271 File Offset: 0x00167471
		public vtkOpenGLSkybox(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601035F RID: 66399
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLSkybox_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010360 RID: 66400 RVA: 0x00169280 File Offset: 0x00167480
		public new static vtkOpenGLSkybox New()
		{
			vtkOpenGLSkybox result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLSkybox.vtkOpenGLSkybox_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLSkybox)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010361 RID: 66401 RVA: 0x001692D4 File Offset: 0x001674D4
		public vtkOpenGLSkybox() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLSkybox.vtkOpenGLSkybox_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010362 RID: 66402 RVA: 0x00169318 File Offset: 0x00167518
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010363 RID: 66403
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLSkybox_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010364 RID: 66404 RVA: 0x00169324 File Offset: 0x00167524
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLSkybox.vtkOpenGLSkybox_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06010365 RID: 66405
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLSkybox_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010366 RID: 66406 RVA: 0x00169344 File Offset: 0x00167544
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLSkybox.vtkOpenGLSkybox_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06010367 RID: 66407
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLSkybox_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010368 RID: 66408 RVA: 0x00169360 File Offset: 0x00167560
		public override int IsA(string type)
		{
			return vtkOpenGLSkybox.vtkOpenGLSkybox_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06010369 RID: 66409
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLSkybox_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601036A RID: 66410 RVA: 0x00169380 File Offset: 0x00167580
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLSkybox.vtkOpenGLSkybox_IsTypeOf_04(type);
		}

		// Token: 0x0601036B RID: 66411
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLSkybox_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601036C RID: 66412 RVA: 0x0016939C File Offset: 0x0016759C
		public new vtkOpenGLSkybox NewInstance()
		{
			vtkOpenGLSkybox result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLSkybox.vtkOpenGLSkybox_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLSkybox)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601036D RID: 66413
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLSkybox_Render_07(HandleRef pThis, HandleRef ren, HandleRef mapper);

		/// <summary>
		/// Actual Skybox render method.
		/// </summary>
		// Token: 0x0601036E RID: 66414 RVA: 0x001693F8 File Offset: 0x001675F8
		public override void Render(vtkRenderer ren, vtkMapper mapper)
		{
			vtkOpenGLSkybox.vtkOpenGLSkybox_Render_07(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x0601036F RID: 66415
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLSkybox_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010370 RID: 66416 RVA: 0x0016943C File Offset: 0x0016763C
		public new static vtkOpenGLSkybox SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLSkybox vtkOpenGLSkybox = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLSkybox.vtkOpenGLSkybox_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLSkybox = (vtkOpenGLSkybox)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLSkybox.Register(null);
				}
			}
			return vtkOpenGLSkybox;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012DB RID: 4827
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLSkybox";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012DC RID: 4828
		public new static readonly string MRClassNameKey = "class vtkOpenGLSkybox";
	}
}
