using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageProcessingPass
	/// </summary>
	/// <remarks>
	///    Convenient class for post-processing passes.
	/// render pass.
	///
	/// Abstract class with some convenient methods frequently used in subclasses.
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkOpenGLRenderPass vtkGaussianBlurPass vtkSobelGradientMagnitudePass
	/// </seealso>
	// Token: 0x02000583 RID: 1411
	public abstract class vtkImageProcessingPass : vtkOpenGLRenderPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F9B6 RID: 63926 RVA: 0x0015B1E3 File Offset: 0x001593E3
		static vtkImageProcessingPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageProcessingPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageProcessingPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F9B7 RID: 63927 RVA: 0x0015B20B File Offset: 0x0015940B
		public vtkImageProcessingPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F9B8 RID: 63928 RVA: 0x0015B219 File Offset: 0x00159419
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F9B9 RID: 63929
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageProcessingPass_GetDelegatePass_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Delegate for rendering the image to be processed.
		/// If it is NULL, nothing will be rendered and a warning will be emitted.
		/// It is usually set to a vtkCameraPass or to a post-processing pass.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x0600F9BA RID: 63930 RVA: 0x0015B224 File Offset: 0x00159424
		public virtual vtkRenderPass GetDelegatePass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageProcessingPass.vtkImageProcessingPass_GetDelegatePass_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderPass = (vtkRenderPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderPass.Register(null);
				}
			}
			return vtkRenderPass;
		}

		// Token: 0x0600F9BB RID: 63931
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageProcessingPass_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9BC RID: 63932 RVA: 0x0015B294 File Offset: 0x00159494
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageProcessingPass.vtkImageProcessingPass_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600F9BD RID: 63933
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageProcessingPass_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9BE RID: 63934 RVA: 0x0015B2B4 File Offset: 0x001594B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageProcessingPass.vtkImageProcessingPass_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600F9BF RID: 63935
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageProcessingPass_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9C0 RID: 63936 RVA: 0x0015B2D0 File Offset: 0x001594D0
		public override int IsA(string type)
		{
			return vtkImageProcessingPass.vtkImageProcessingPass_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600F9C1 RID: 63937
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageProcessingPass_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9C2 RID: 63938 RVA: 0x0015B2F0 File Offset: 0x001594F0
		public new static int IsTypeOf(string type)
		{
			return vtkImageProcessingPass.vtkImageProcessingPass_IsTypeOf_05(type);
		}

		// Token: 0x0600F9C3 RID: 63939
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageProcessingPass_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9C4 RID: 63940 RVA: 0x0015B30C File Offset: 0x0015950C
		public new vtkImageProcessingPass NewInstance()
		{
			vtkImageProcessingPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageProcessingPass.vtkImageProcessingPass_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageProcessingPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F9C5 RID: 63941
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProcessingPass_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x0600F9C6 RID: 63942 RVA: 0x0015B368 File Offset: 0x00159568
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkImageProcessingPass.vtkImageProcessingPass_ReleaseGraphicsResources_07(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x0600F9C7 RID: 63943
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageProcessingPass_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9C8 RID: 63944 RVA: 0x0015B398 File Offset: 0x00159598
		public new static vtkImageProcessingPass SafeDownCast(vtkObjectBase o)
		{
			vtkImageProcessingPass vtkImageProcessingPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageProcessingPass.vtkImageProcessingPass_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageProcessingPass = (vtkImageProcessingPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageProcessingPass.Register(null);
				}
			}
			return vtkImageProcessingPass;
		}

		// Token: 0x0600F9C9 RID: 63945
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProcessingPass_SetDelegatePass_09(HandleRef pThis, HandleRef delegatePass);

		/// <summary>
		/// Delegate for rendering the image to be processed.
		/// If it is NULL, nothing will be rendered and a warning will be emitted.
		/// It is usually set to a vtkCameraPass or to a post-processing pass.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x0600F9CA RID: 63946 RVA: 0x0015B418 File Offset: 0x00159618
		public virtual void SetDelegatePass(vtkRenderPass delegatePass)
		{
			vtkImageProcessingPass.vtkImageProcessingPass_SetDelegatePass_09(base.GetCppThis(), (delegatePass == null) ? default(HandleRef) : delegatePass.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400121F RID: 4639
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageProcessingPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001220 RID: 4640
		public new static readonly string MRClassNameKey = "class vtkImageProcessingPass";
	}
}
