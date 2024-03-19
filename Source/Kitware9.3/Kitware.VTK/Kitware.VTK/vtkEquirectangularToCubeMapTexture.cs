using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEquirectangularToCubeMapTexture
	/// </summary>
	/// <remarks>
	///    compute a cubemap texture based on a standard equirectangular projection
	///
	/// This special texture converts a 2D projected texture in equirectangular format to a 3D cubemap
	/// using the GPU.
	/// The generated texture can be used as input for a skybox or an environment map for PBR shading.
	///
	/// </remarks>
	/// <seealso>
	///  vtkSkybox vtkRenderer::SetEnvironmentCubeMap
	/// </seealso>
	// Token: 0x0200058F RID: 1423
	public class vtkEquirectangularToCubeMapTexture : vtkOpenGLTexture
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FB33 RID: 64307 RVA: 0x0015D477 File Offset: 0x0015B677
		static vtkEquirectangularToCubeMapTexture()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEquirectangularToCubeMapTexture.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEquirectangularToCubeMapTexture"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FB34 RID: 64308 RVA: 0x0015D49F File Offset: 0x0015B69F
		public vtkEquirectangularToCubeMapTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FB35 RID: 64309
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEquirectangularToCubeMapTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB36 RID: 64310 RVA: 0x0015D4B0 File Offset: 0x0015B6B0
		public new static vtkEquirectangularToCubeMapTexture New()
		{
			vtkEquirectangularToCubeMapTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEquirectangularToCubeMapTexture.vtkEquirectangularToCubeMapTexture_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEquirectangularToCubeMapTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB37 RID: 64311 RVA: 0x0015D504 File Offset: 0x0015B704
		public vtkEquirectangularToCubeMapTexture() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEquirectangularToCubeMapTexture.vtkEquirectangularToCubeMapTexture_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FB38 RID: 64312 RVA: 0x0015D548 File Offset: 0x0015B748
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FB39 RID: 64313
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkEquirectangularToCubeMapTexture_GetCubeMapSize_01(HandleRef pThis);

		/// <summary>
		/// Set/Get size of each face of the output cubemap texture.
		/// Default is 512.
		/// </summary>
		// Token: 0x0600FB3A RID: 64314 RVA: 0x0015D554 File Offset: 0x0015B754
		public virtual uint GetCubeMapSize()
		{
			return vtkEquirectangularToCubeMapTexture.vtkEquirectangularToCubeMapTexture_GetCubeMapSize_01(base.GetCppThis());
		}

		// Token: 0x0600FB3B RID: 64315
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEquirectangularToCubeMapTexture_GetInputTexture_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the input equirectangular 2D texture.
		/// </summary>
		// Token: 0x0600FB3C RID: 64316 RVA: 0x0015D574 File Offset: 0x0015B774
		public virtual vtkOpenGLTexture GetInputTexture()
		{
			vtkOpenGLTexture vtkOpenGLTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEquirectangularToCubeMapTexture.vtkEquirectangularToCubeMapTexture_GetInputTexture_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLTexture = (vtkOpenGLTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLTexture.Register(null);
				}
			}
			return vtkOpenGLTexture;
		}

		// Token: 0x0600FB3D RID: 64317
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEquirectangularToCubeMapTexture_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB3E RID: 64318 RVA: 0x0015D5E4 File Offset: 0x0015B7E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEquirectangularToCubeMapTexture.vtkEquirectangularToCubeMapTexture_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600FB3F RID: 64319
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEquirectangularToCubeMapTexture_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB40 RID: 64320 RVA: 0x0015D604 File Offset: 0x0015B804
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEquirectangularToCubeMapTexture.vtkEquirectangularToCubeMapTexture_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600FB41 RID: 64321
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEquirectangularToCubeMapTexture_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB42 RID: 64322 RVA: 0x0015D620 File Offset: 0x0015B820
		public override int IsA(string type)
		{
			return vtkEquirectangularToCubeMapTexture.vtkEquirectangularToCubeMapTexture_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600FB43 RID: 64323
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEquirectangularToCubeMapTexture_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB44 RID: 64324 RVA: 0x0015D640 File Offset: 0x0015B840
		public new static int IsTypeOf(string type)
		{
			return vtkEquirectangularToCubeMapTexture.vtkEquirectangularToCubeMapTexture_IsTypeOf_06(type);
		}

		// Token: 0x0600FB45 RID: 64325
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEquirectangularToCubeMapTexture_Load_07(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x0600FB46 RID: 64326 RVA: 0x0015D65C File Offset: 0x0015B85C
		public override void Load(vtkRenderer arg0)
		{
			vtkEquirectangularToCubeMapTexture.vtkEquirectangularToCubeMapTexture_Load_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600FB47 RID: 64327
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEquirectangularToCubeMapTexture_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB48 RID: 64328 RVA: 0x0015D68C File Offset: 0x0015B88C
		public new vtkEquirectangularToCubeMapTexture NewInstance()
		{
			vtkEquirectangularToCubeMapTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEquirectangularToCubeMapTexture.vtkEquirectangularToCubeMapTexture_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEquirectangularToCubeMapTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FB49 RID: 64329
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEquirectangularToCubeMapTexture_ReleaseGraphicsResources_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this texture.
		/// The parameter window could be used to determine which graphic
		/// resources to release. Using the same texture object in multiple
		/// render windows is NOT currently supported.
		/// </summary>
		// Token: 0x0600FB4A RID: 64330 RVA: 0x0015D6E8 File Offset: 0x0015B8E8
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkEquirectangularToCubeMapTexture.vtkEquirectangularToCubeMapTexture_ReleaseGraphicsResources_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600FB4B RID: 64331
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEquirectangularToCubeMapTexture_Render_11(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x0600FB4C RID: 64332 RVA: 0x0015D718 File Offset: 0x0015B918
		public override void Render(vtkRenderer ren)
		{
			vtkEquirectangularToCubeMapTexture.vtkEquirectangularToCubeMapTexture_Render_11(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x0600FB4D RID: 64333
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEquirectangularToCubeMapTexture_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB4E RID: 64334 RVA: 0x0015D748 File Offset: 0x0015B948
		public new static vtkEquirectangularToCubeMapTexture SafeDownCast(vtkObjectBase o)
		{
			vtkEquirectangularToCubeMapTexture vtkEquirectangularToCubeMapTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEquirectangularToCubeMapTexture.vtkEquirectangularToCubeMapTexture_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEquirectangularToCubeMapTexture = (vtkEquirectangularToCubeMapTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEquirectangularToCubeMapTexture.Register(null);
				}
			}
			return vtkEquirectangularToCubeMapTexture;
		}

		// Token: 0x0600FB4F RID: 64335
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEquirectangularToCubeMapTexture_SetCubeMapSize_13(HandleRef pThis, uint _arg);

		/// <summary>
		/// Set/Get size of each face of the output cubemap texture.
		/// Default is 512.
		/// </summary>
		// Token: 0x0600FB50 RID: 64336 RVA: 0x0015D7C7 File Offset: 0x0015B9C7
		public virtual void SetCubeMapSize(uint _arg)
		{
			vtkEquirectangularToCubeMapTexture.vtkEquirectangularToCubeMapTexture_SetCubeMapSize_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FB51 RID: 64337
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEquirectangularToCubeMapTexture_SetInputTexture_14(HandleRef pThis, HandleRef texture);

		/// <summary>
		/// Get/Set the input equirectangular 2D texture.
		/// </summary>
		// Token: 0x0600FB52 RID: 64338 RVA: 0x0015D7D8 File Offset: 0x0015B9D8
		public void SetInputTexture(vtkOpenGLTexture texture)
		{
			vtkEquirectangularToCubeMapTexture.vtkEquirectangularToCubeMapTexture_SetInputTexture_14(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001246 RID: 4678
		public new const string MRFullTypeName = "Kitware.VTK.vtkEquirectangularToCubeMapTexture";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001247 RID: 4679
		public new static readonly string MRClassNameKey = "class vtkEquirectangularToCubeMapTexture";
	}
}
