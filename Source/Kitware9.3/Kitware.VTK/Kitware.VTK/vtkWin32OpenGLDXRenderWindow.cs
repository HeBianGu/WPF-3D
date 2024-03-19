using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWin32OpenGLDXRenderWindow
	/// </summary>
	/// <remarks>
	///    VTK render window providing OpenGL-DirectX interop
	///
	/// This vtkWin32OpenGLRenderWindow subclass allows for rendering in a texture
	/// that is shared between an OpenGL and a D3D context, using the NVidia
	/// NV_DX_interop extension.
	/// </remarks>
	// Token: 0x020005FA RID: 1530
	public class vtkWin32OpenGLDXRenderWindow : vtkWin32OpenGLRenderWindow
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060109BB RID: 68027 RVA: 0x00172DDC File Offset: 0x00170FDC
		static vtkWin32OpenGLDXRenderWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWin32OpenGLDXRenderWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWin32OpenGLDXRenderWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060109BC RID: 68028 RVA: 0x00172E04 File Offset: 0x00171004
		public vtkWin32OpenGLDXRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060109BD RID: 68029
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OpenGLDXRenderWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109BE RID: 68030 RVA: 0x00172E14 File Offset: 0x00171014
		public new static vtkWin32OpenGLDXRenderWindow New()
		{
			vtkWin32OpenGLDXRenderWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32OpenGLDXRenderWindow.vtkWin32OpenGLDXRenderWindow_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32OpenGLDXRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109BF RID: 68031 RVA: 0x00172E68 File Offset: 0x00171068
		public vtkWin32OpenGLDXRenderWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWin32OpenGLDXRenderWindow.vtkWin32OpenGLDXRenderWindow_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060109C0 RID: 68032 RVA: 0x00172EAC File Offset: 0x001710AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060109C1 RID: 68033
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWin32OpenGLDXRenderWindow_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109C2 RID: 68034 RVA: 0x00172EB8 File Offset: 0x001710B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWin32OpenGLDXRenderWindow.vtkWin32OpenGLDXRenderWindow_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060109C3 RID: 68035
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWin32OpenGLDXRenderWindow_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109C4 RID: 68036 RVA: 0x00172ED8 File Offset: 0x001710D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWin32OpenGLDXRenderWindow.vtkWin32OpenGLDXRenderWindow_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060109C5 RID: 68037
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLDXRenderWindow_Initialize_03(HandleRef pThis);

		/// <summary>
		/// Overridden to create the D3D device, context and texture.
		/// </summary>
		// Token: 0x060109C6 RID: 68038 RVA: 0x00172EF2 File Offset: 0x001710F2
		public override void Initialize()
		{
			vtkWin32OpenGLDXRenderWindow.vtkWin32OpenGLDXRenderWindow_Initialize_03(base.GetCppThis());
		}

		// Token: 0x060109C7 RID: 68039
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWin32OpenGLDXRenderWindow_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109C8 RID: 68040 RVA: 0x00172F04 File Offset: 0x00171104
		public override int IsA(string type)
		{
			return vtkWin32OpenGLDXRenderWindow.vtkWin32OpenGLDXRenderWindow_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060109C9 RID: 68041
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWin32OpenGLDXRenderWindow_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109CA RID: 68042 RVA: 0x00172F24 File Offset: 0x00171124
		public new static int IsTypeOf(string type)
		{
			return vtkWin32OpenGLDXRenderWindow.vtkWin32OpenGLDXRenderWindow_IsTypeOf_05(type);
		}

		// Token: 0x060109CB RID: 68043
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLDXRenderWindow_Lock_06(HandleRef pThis);

		/// <summary>
		/// Lock/Unlock the shared texture.
		/// The texture must be locked before rendering into it.
		/// </summary>
		// Token: 0x060109CC RID: 68044 RVA: 0x00172F3E File Offset: 0x0017113E
		public void Lock()
		{
			vtkWin32OpenGLDXRenderWindow.vtkWin32OpenGLDXRenderWindow_Lock_06(base.GetCppThis());
		}

		// Token: 0x060109CD RID: 68045
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OpenGLDXRenderWindow_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109CE RID: 68046 RVA: 0x00172F50 File Offset: 0x00171150
		public new vtkWin32OpenGLDXRenderWindow NewInstance()
		{
			vtkWin32OpenGLDXRenderWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32OpenGLDXRenderWindow.vtkWin32OpenGLDXRenderWindow_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32OpenGLDXRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060109CF RID: 68047
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLDXRenderWindow_RegisterSharedTexture_09(HandleRef pThis, uint textureHandle);

		/// <summary>
		/// Register/Unregister the OpenGL texture designated by \p textureHandle with
		/// this render window internal D3D shared texture.
		/// </summary>
		// Token: 0x060109D0 RID: 68048 RVA: 0x00172FAA File Offset: 0x001711AA
		public void RegisterSharedTexture(uint textureHandle)
		{
			vtkWin32OpenGLDXRenderWindow.vtkWin32OpenGLDXRenderWindow_RegisterSharedTexture_09(base.GetCppThis(), textureHandle);
		}

		// Token: 0x060109D1 RID: 68049
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWin32OpenGLDXRenderWindow_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109D2 RID: 68050 RVA: 0x00172FBC File Offset: 0x001711BC
		public new static vtkWin32OpenGLDXRenderWindow SafeDownCast(vtkObjectBase o)
		{
			vtkWin32OpenGLDXRenderWindow vtkWin32OpenGLDXRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWin32OpenGLDXRenderWindow.vtkWin32OpenGLDXRenderWindow_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWin32OpenGLDXRenderWindow = (vtkWin32OpenGLDXRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWin32OpenGLDXRenderWindow.Register(null);
				}
			}
			return vtkWin32OpenGLDXRenderWindow;
		}

		// Token: 0x060109D3 RID: 68051
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLDXRenderWindow_SetMultiSamples_11(HandleRef pThis, int samples);

		/// <summary>
		/// Overridden to update the internal D3D shared texture
		/// </summary>
		// Token: 0x060109D4 RID: 68052 RVA: 0x0017303B File Offset: 0x0017123B
		public override void SetMultiSamples(int samples)
		{
			vtkWin32OpenGLDXRenderWindow.vtkWin32OpenGLDXRenderWindow_SetMultiSamples_11(base.GetCppThis(), samples);
		}

		// Token: 0x060109D5 RID: 68053
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLDXRenderWindow_SetSize_12(HandleRef pThis, int width, int height);

		/// <summary>
		/// Overridden to resize the internal D3D shared texture
		/// </summary>
		// Token: 0x060109D6 RID: 68054 RVA: 0x0017304B File Offset: 0x0017124B
		public override void SetSize(int width, int height)
		{
			vtkWin32OpenGLDXRenderWindow.vtkWin32OpenGLDXRenderWindow_SetSize_12(base.GetCppThis(), width, height);
		}

		// Token: 0x060109D7 RID: 68055
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLDXRenderWindow_Unlock_13(HandleRef pThis);

		/// <summary>
		/// Lock/Unlock the shared texture.
		/// The texture must be locked before rendering into it.
		/// </summary>
		// Token: 0x060109D8 RID: 68056 RVA: 0x0017305C File Offset: 0x0017125C
		public void Unlock()
		{
			vtkWin32OpenGLDXRenderWindow.vtkWin32OpenGLDXRenderWindow_Unlock_13(base.GetCppThis());
		}

		// Token: 0x060109D9 RID: 68057
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWin32OpenGLDXRenderWindow_UnregisterSharedTexture_14(HandleRef pThis);

		/// <summary>
		/// Register/Unregister the OpenGL texture designated by \p textureHandle with
		/// this render window internal D3D shared texture.
		/// </summary>
		// Token: 0x060109DA RID: 68058 RVA: 0x0017306B File Offset: 0x0017126B
		public void UnregisterSharedTexture()
		{
			vtkWin32OpenGLDXRenderWindow.vtkWin32OpenGLDXRenderWindow_UnregisterSharedTexture_14(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400134A RID: 4938
		public new const string MRFullTypeName = "Kitware.VTK.vtkWin32OpenGLDXRenderWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400134B RID: 4939
		public new static readonly string MRClassNameKey = "class vtkWin32OpenGLDXRenderWindow";
	}
}
