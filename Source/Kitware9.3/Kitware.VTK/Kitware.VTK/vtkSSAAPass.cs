using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSSAAPass
	/// </summary>
	/// <remarks>
	///    Implement Screen Space Anti Aliasing pass.
	///
	/// Render to a larger image and then sample down
	///
	/// This pass expects an initialized depth buffer and color buffer.
	/// Initialized buffers means they have been cleared with farthest z-value and
	/// background color/gradient/transparent color.
	///
	/// The delegate is used once.
	///
	/// Its delegate is usually set to a vtkCameraPass or to a post-processing pass.
	///
	/// @par Implementation:
	/// As the filter is separable, it first blurs the image horizontally and then
	/// vertically. This reduces the number of texture samples taken.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass
	/// </seealso>
	// Token: 0x020005E5 RID: 1509
	public class vtkSSAAPass : vtkRenderPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010717 RID: 67351 RVA: 0x0016EE67 File Offset: 0x0016D067
		static vtkSSAAPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSSAAPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSSAAPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010718 RID: 67352 RVA: 0x0016EE8F File Offset: 0x0016D08F
		public vtkSSAAPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010719 RID: 67353
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSSAAPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601071A RID: 67354 RVA: 0x0016EEA0 File Offset: 0x0016D0A0
		public new static vtkSSAAPass New()
		{
			vtkSSAAPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSSAAPass.vtkSSAAPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSSAAPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601071B RID: 67355 RVA: 0x0016EEF4 File Offset: 0x0016D0F4
		public vtkSSAAPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSSAAPass.vtkSSAAPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601071C RID: 67356 RVA: 0x0016EF38 File Offset: 0x0016D138
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601071D RID: 67357
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSSAAPass_GetDelegatePass_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Delegate for rendering the image to be processed.
		/// If it is NULL, nothing will be rendered and a warning will be emitted.
		/// It is usually set to a vtkCameraPass or to a post-processing pass.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x0601071E RID: 67358 RVA: 0x0016EF44 File Offset: 0x0016D144
		public virtual vtkRenderPass GetDelegatePass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSSAAPass.vtkSSAAPass_GetDelegatePass_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601071F RID: 67359
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSSAAPass_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010720 RID: 67360 RVA: 0x0016EFB4 File Offset: 0x0016D1B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSSAAPass.vtkSSAAPass_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06010721 RID: 67361
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSSAAPass_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010722 RID: 67362 RVA: 0x0016EFD4 File Offset: 0x0016D1D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSSAAPass.vtkSSAAPass_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06010723 RID: 67363
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSSAAPass_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010724 RID: 67364 RVA: 0x0016EFF0 File Offset: 0x0016D1F0
		public override int IsA(string type)
		{
			return vtkSSAAPass.vtkSSAAPass_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06010725 RID: 67365
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSSAAPass_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010726 RID: 67366 RVA: 0x0016F010 File Offset: 0x0016D210
		public new static int IsTypeOf(string type)
		{
			return vtkSSAAPass.vtkSSAAPass_IsTypeOf_05(type);
		}

		// Token: 0x06010727 RID: 67367
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSSAAPass_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010728 RID: 67368 RVA: 0x0016F02C File Offset: 0x0016D22C
		public new vtkSSAAPass NewInstance()
		{
			vtkSSAAPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSSAAPass.vtkSSAAPass_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSSAAPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010729 RID: 67369
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSSAAPass_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x0601072A RID: 67370 RVA: 0x0016F088 File Offset: 0x0016D288
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkSSAAPass.vtkSSAAPass_ReleaseGraphicsResources_08(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x0601072B RID: 67371
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSSAAPass_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601072C RID: 67372 RVA: 0x0016F0B8 File Offset: 0x0016D2B8
		public new static vtkSSAAPass SafeDownCast(vtkObjectBase o)
		{
			vtkSSAAPass vtkSSAAPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSSAAPass.vtkSSAAPass_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSSAAPass = (vtkSSAAPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSSAAPass.Register(null);
				}
			}
			return vtkSSAAPass;
		}

		// Token: 0x0601072D RID: 67373
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSSAAPass_SetDelegatePass_10(HandleRef pThis, HandleRef delegatePass);

		/// <summary>
		/// Delegate for rendering the image to be processed.
		/// If it is NULL, nothing will be rendered and a warning will be emitted.
		/// It is usually set to a vtkCameraPass or to a post-processing pass.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x0601072E RID: 67374 RVA: 0x0016F138 File Offset: 0x0016D338
		public virtual void SetDelegatePass(vtkRenderPass delegatePass)
		{
			vtkSSAAPass.vtkSSAAPass_SetDelegatePass_10(base.GetCppThis(), (delegatePass == null) ? default(HandleRef) : delegatePass.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001316 RID: 4886
		public new const string MRFullTypeName = "Kitware.VTK.vtkSSAAPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001317 RID: 4887
		public new static readonly string MRClassNameKey = "class vtkSSAAPass";
	}
}
