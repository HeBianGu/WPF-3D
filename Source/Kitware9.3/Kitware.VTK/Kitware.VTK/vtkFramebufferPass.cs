using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFramebufferPass
	/// </summary>
	/// <remarks>
	///    Render into a FO
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass
	/// </seealso>
	// Token: 0x02000590 RID: 1424
	public class vtkFramebufferPass : vtkDepthImageProcessingPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FB53 RID: 64339 RVA: 0x0015D807 File Offset: 0x0015BA07
		static vtkFramebufferPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFramebufferPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFramebufferPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FB54 RID: 64340 RVA: 0x0015D82F File Offset: 0x0015BA2F
		public vtkFramebufferPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FB55 RID: 64341
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFramebufferPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB56 RID: 64342 RVA: 0x0015D840 File Offset: 0x0015BA40
		public new static vtkFramebufferPass New()
		{
			vtkFramebufferPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFramebufferPass.vtkFramebufferPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFramebufferPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB57 RID: 64343 RVA: 0x0015D894 File Offset: 0x0015BA94
		public vtkFramebufferPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFramebufferPass.vtkFramebufferPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FB58 RID: 64344 RVA: 0x0015D8D8 File Offset: 0x0015BAD8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FB59 RID: 64345
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFramebufferPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB5A RID: 64346 RVA: 0x0015D8E4 File Offset: 0x0015BAE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFramebufferPass.vtkFramebufferPass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600FB5B RID: 64347
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFramebufferPass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB5C RID: 64348 RVA: 0x0015D904 File Offset: 0x0015BB04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFramebufferPass.vtkFramebufferPass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600FB5D RID: 64349
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFramebufferPass_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB5E RID: 64350 RVA: 0x0015D920 File Offset: 0x0015BB20
		public override int IsA(string type)
		{
			return vtkFramebufferPass.vtkFramebufferPass_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600FB5F RID: 64351
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFramebufferPass_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB60 RID: 64352 RVA: 0x0015D940 File Offset: 0x0015BB40
		public new static int IsTypeOf(string type)
		{
			return vtkFramebufferPass.vtkFramebufferPass_IsTypeOf_04(type);
		}

		// Token: 0x0600FB61 RID: 64353
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFramebufferPass_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB62 RID: 64354 RVA: 0x0015D95C File Offset: 0x0015BB5C
		public new vtkFramebufferPass NewInstance()
		{
			vtkFramebufferPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFramebufferPass.vtkFramebufferPass_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFramebufferPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FB63 RID: 64355
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFramebufferPass_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x0600FB64 RID: 64356 RVA: 0x0015D9B8 File Offset: 0x0015BBB8
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkFramebufferPass.vtkFramebufferPass_ReleaseGraphicsResources_07(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x0600FB65 RID: 64357
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFramebufferPass_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB66 RID: 64358 RVA: 0x0015D9E8 File Offset: 0x0015BBE8
		public new static vtkFramebufferPass SafeDownCast(vtkObjectBase o)
		{
			vtkFramebufferPass vtkFramebufferPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFramebufferPass.vtkFramebufferPass_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFramebufferPass = (vtkFramebufferPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFramebufferPass.Register(null);
				}
			}
			return vtkFramebufferPass;
		}

		// Token: 0x0600FB67 RID: 64359
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFramebufferPass_SetColorFormat_09(HandleRef pThis, int _arg);

		/// <summary>
		///  Set the format to use for the color texture
		///  vtkTextureObject::Float16 vtkTextureObject::Float32
		///  and vtkTextureObject::Fixed8 are supported. Fixed8
		///  is the default.
		/// </summary>
		// Token: 0x0600FB68 RID: 64360 RVA: 0x0015DA67 File Offset: 0x0015BC67
		public virtual void SetColorFormat(int _arg)
		{
			vtkFramebufferPass.vtkFramebufferPass_SetColorFormat_09(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FB69 RID: 64361
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFramebufferPass_SetDepthFormat_10(HandleRef pThis, int _arg);

		/// <summary>
		///  Set the format to use for the depth texture
		/// e.g. vtkTextureObject::Float32
		/// </summary>
		// Token: 0x0600FB6A RID: 64362 RVA: 0x0015DA77 File Offset: 0x0015BC77
		public virtual void SetDepthFormat(int _arg)
		{
			vtkFramebufferPass.vtkFramebufferPass_SetDepthFormat_10(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001248 RID: 4680
		public new const string MRFullTypeName = "Kitware.VTK.vtkFramebufferPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001249 RID: 4681
		public new static readonly string MRClassNameKey = "class vtkFramebufferPass";
	}
}
