using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExternalOpenGLRenderer
	/// </summary>
	/// <remarks>
	///    OpenGL renderer
	///
	/// vtkExternalOpenGLRenderer is a secondary implementation of the class
	/// vtkOpenGLRenderer. vtkExternalOpenGLRenderer interfaces to the
	/// OpenGL graphics library. This class provides API to preserve the color and
	/// depth buffers, thereby allowing external applications to manage the OpenGL
	/// buffers. This becomes very useful when there are multiple OpenGL applications
	/// sharing the same OpenGL context.
	///
	/// vtkExternalOpenGLRenderer makes sure that the camera used in the scene if of
	/// type vtkExternalOpenGLCamera. It manages light and camera transformations for
	/// VTK objects in the OpenGL context.
	///
	/// \sa vtkExternalOpenGLCamera
	/// </remarks>
	// Token: 0x0200011D RID: 285
	public class vtkExternalOpenGLRenderer : vtkOpenGLRenderer
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003A63 RID: 14947 RVA: 0x00054DA0 File Offset: 0x00052FA0
		static vtkExternalOpenGLRenderer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExternalOpenGLRenderer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExternalOpenGLRenderer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003A64 RID: 14948 RVA: 0x00054DC8 File Offset: 0x00052FC8
		public vtkExternalOpenGLRenderer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003A65 RID: 14949
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExternalOpenGLRenderer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A66 RID: 14950 RVA: 0x00054DD8 File Offset: 0x00052FD8
		public new static vtkExternalOpenGLRenderer New()
		{
			vtkExternalOpenGLRenderer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExternalOpenGLRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A67 RID: 14951 RVA: 0x00054E2C File Offset: 0x0005302C
		public vtkExternalOpenGLRenderer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003A68 RID: 14952 RVA: 0x00054E70 File Offset: 0x00053070
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003A69 RID: 14953
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLRenderer_AddExternalLight_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add an external light to the list of external lights.
		/// </summary>
		// Token: 0x06003A6A RID: 14954 RVA: 0x00054E7C File Offset: 0x0005307C
		public virtual void AddExternalLight(vtkExternalLight arg0)
		{
			vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_AddExternalLight_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003A6B RID: 14955
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExternalOpenGLRenderer_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A6C RID: 14956 RVA: 0x00054EAC File Offset: 0x000530AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06003A6D RID: 14957
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExternalOpenGLRenderer_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A6E RID: 14958 RVA: 0x00054ECC File Offset: 0x000530CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06003A6F RID: 14959
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExternalOpenGLRenderer_GetPreserveGLCameraMatrices_04(HandleRef pThis);

		/// <summary>
		/// If PreserveGLCameraMatrices is set to true, VTK camera matrices
		/// are copied from the current context GL_MODELVIEW_MATRIX and
		/// GL_PROJECTION_MATRIX parameters before each render call.
		/// This flag is on by default.
		/// </summary>
		// Token: 0x06003A70 RID: 14960 RVA: 0x00054EE8 File Offset: 0x000530E8
		public virtual int GetPreserveGLCameraMatrices()
		{
			return vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_GetPreserveGLCameraMatrices_04(base.GetCppThis());
		}

		// Token: 0x06003A71 RID: 14961
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExternalOpenGLRenderer_GetPreserveGLLights_05(HandleRef pThis);

		/// <summary>
		/// If PreserveGLLights is set to true, existing GL lights are modified before
		/// each render call to match the collection of lights added with
		/// AddExternalLight(). This flag is on by default.
		/// </summary>
		// Token: 0x06003A72 RID: 14962 RVA: 0x00054F08 File Offset: 0x00053108
		public virtual int GetPreserveGLLights()
		{
			return vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_GetPreserveGLLights_05(base.GetCppThis());
		}

		// Token: 0x06003A73 RID: 14963
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExternalOpenGLRenderer_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A74 RID: 14964 RVA: 0x00054F28 File Offset: 0x00053128
		public override int IsA(string type)
		{
			return vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06003A75 RID: 14965
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExternalOpenGLRenderer_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A76 RID: 14966 RVA: 0x00054F48 File Offset: 0x00053148
		public new static int IsTypeOf(string type)
		{
			return vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_IsTypeOf_07(type);
		}

		// Token: 0x06003A77 RID: 14967
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExternalOpenGLRenderer_MakeCamera_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a new Camera sutible for use with this type of Renderer.
		/// This function creates the vtkExternalOpenGLCamera.
		/// </summary>
		// Token: 0x06003A78 RID: 14968 RVA: 0x00054F64 File Offset: 0x00053164
		public override vtkCamera MakeCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_MakeCamera_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		// Token: 0x06003A79 RID: 14969
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExternalOpenGLRenderer_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A7A RID: 14970 RVA: 0x00054FD4 File Offset: 0x000531D4
		public new vtkExternalOpenGLRenderer NewInstance()
		{
			vtkExternalOpenGLRenderer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExternalOpenGLRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003A7B RID: 14971
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLRenderer_PreserveGLCameraMatricesOff_11(HandleRef pThis);

		/// <summary>
		/// If PreserveGLCameraMatrices is set to true, VTK camera matrices
		/// are copied from the current context GL_MODELVIEW_MATRIX and
		/// GL_PROJECTION_MATRIX parameters before each render call.
		/// This flag is on by default.
		/// </summary>
		// Token: 0x06003A7C RID: 14972 RVA: 0x0005502E File Offset: 0x0005322E
		public virtual void PreserveGLCameraMatricesOff()
		{
			vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_PreserveGLCameraMatricesOff_11(base.GetCppThis());
		}

		// Token: 0x06003A7D RID: 14973
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLRenderer_PreserveGLCameraMatricesOn_12(HandleRef pThis);

		/// <summary>
		/// If PreserveGLCameraMatrices is set to true, VTK camera matrices
		/// are copied from the current context GL_MODELVIEW_MATRIX and
		/// GL_PROJECTION_MATRIX parameters before each render call.
		/// This flag is on by default.
		/// </summary>
		// Token: 0x06003A7E RID: 14974 RVA: 0x0005503D File Offset: 0x0005323D
		public virtual void PreserveGLCameraMatricesOn()
		{
			vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_PreserveGLCameraMatricesOn_12(base.GetCppThis());
		}

		// Token: 0x06003A7F RID: 14975
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLRenderer_PreserveGLLightsOff_13(HandleRef pThis);

		/// <summary>
		/// If PreserveGLLights is set to true, existing GL lights are modified before
		/// each render call to match the collection of lights added with
		/// AddExternalLight(). This flag is on by default.
		/// </summary>
		// Token: 0x06003A80 RID: 14976 RVA: 0x0005504C File Offset: 0x0005324C
		public virtual void PreserveGLLightsOff()
		{
			vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_PreserveGLLightsOff_13(base.GetCppThis());
		}

		// Token: 0x06003A81 RID: 14977
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLRenderer_PreserveGLLightsOn_14(HandleRef pThis);

		/// <summary>
		/// If PreserveGLLights is set to true, existing GL lights are modified before
		/// each render call to match the collection of lights added with
		/// AddExternalLight(). This flag is on by default.
		/// </summary>
		// Token: 0x06003A82 RID: 14978 RVA: 0x0005505B File Offset: 0x0005325B
		public virtual void PreserveGLLightsOn()
		{
			vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_PreserveGLLightsOn_14(base.GetCppThis());
		}

		// Token: 0x06003A83 RID: 14979
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLRenderer_RemoveAllExternalLights_15(HandleRef pThis);

		/// <summary>
		/// Remove all external lights
		/// </summary>
		// Token: 0x06003A84 RID: 14980 RVA: 0x0005506A File Offset: 0x0005326A
		public virtual void RemoveAllExternalLights()
		{
			vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_RemoveAllExternalLights_15(base.GetCppThis());
		}

		// Token: 0x06003A85 RID: 14981
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLRenderer_RemoveExternalLight_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove an external light from the list of external lights.
		/// </summary>
		// Token: 0x06003A86 RID: 14982 RVA: 0x0005507C File Offset: 0x0005327C
		public virtual void RemoveExternalLight(vtkExternalLight arg0)
		{
			vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_RemoveExternalLight_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003A87 RID: 14983
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLRenderer_Render_17(HandleRef pThis);

		/// <summary>
		/// Synchronize camera and light parameters
		/// </summary>
		// Token: 0x06003A88 RID: 14984 RVA: 0x000550AB File Offset: 0x000532AB
		public override void Render()
		{
			vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_Render_17(base.GetCppThis());
		}

		// Token: 0x06003A89 RID: 14985
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExternalOpenGLRenderer_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A8A RID: 14986 RVA: 0x000550BC File Offset: 0x000532BC
		public new static vtkExternalOpenGLRenderer SafeDownCast(vtkObjectBase o)
		{
			vtkExternalOpenGLRenderer vtkExternalOpenGLRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExternalOpenGLRenderer = (vtkExternalOpenGLRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExternalOpenGLRenderer.Register(null);
				}
			}
			return vtkExternalOpenGLRenderer;
		}

		// Token: 0x06003A8B RID: 14987
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLRenderer_SetPreserveGLCameraMatrices_19(HandleRef pThis, int _arg);

		/// <summary>
		/// If PreserveGLCameraMatrices is set to true, VTK camera matrices
		/// are copied from the current context GL_MODELVIEW_MATRIX and
		/// GL_PROJECTION_MATRIX parameters before each render call.
		/// This flag is on by default.
		/// </summary>
		// Token: 0x06003A8C RID: 14988 RVA: 0x0005513B File Offset: 0x0005333B
		public virtual void SetPreserveGLCameraMatrices(int _arg)
		{
			vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_SetPreserveGLCameraMatrices_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06003A8D RID: 14989
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExternalOpenGLRenderer_SetPreserveGLLights_20(HandleRef pThis, int _arg);

		/// <summary>
		/// If PreserveGLLights is set to true, existing GL lights are modified before
		/// each render call to match the collection of lights added with
		/// AddExternalLight(). This flag is on by default.
		/// </summary>
		// Token: 0x06003A8E RID: 14990 RVA: 0x0005514B File Offset: 0x0005334B
		public virtual void SetPreserveGLLights(int _arg)
		{
			vtkExternalOpenGLRenderer.vtkExternalOpenGLRenderer_SetPreserveGLLights_20(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000673 RID: 1651
		public new const string MRFullTypeName = "Kitware.VTK.vtkExternalOpenGLRenderer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000674 RID: 1652
		public new static readonly string MRClassNameKey = "class vtkExternalOpenGLRenderer";
	}
}
