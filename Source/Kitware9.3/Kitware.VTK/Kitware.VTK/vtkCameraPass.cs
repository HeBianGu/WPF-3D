using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCameraPass
	/// </summary>
	/// <remarks>
	///    Implement the camera render pass.
	///
	/// Render the camera.
	///
	/// It setups the projection and modelview matrices and can clear the background
	/// It calls its delegate once.
	/// After its delegate returns, it restore the modelview matrix stack.
	///
	/// Its delegate is usually set to a vtkSequencePass with a vtkLightsPass and
	/// a list of passes for the geometry.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass
	/// </seealso>
	// Token: 0x0200057C RID: 1404
	public class vtkCameraPass : vtkRenderPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F899 RID: 63641 RVA: 0x0015975B File Offset: 0x0015795B
		static vtkCameraPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCameraPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F89A RID: 63642 RVA: 0x00159783 File Offset: 0x00157983
		public vtkCameraPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F89B RID: 63643
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F89C RID: 63644 RVA: 0x00159794 File Offset: 0x00157994
		public new static vtkCameraPass New()
		{
			vtkCameraPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraPass.vtkCameraPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F89D RID: 63645 RVA: 0x001597E8 File Offset: 0x001579E8
		public vtkCameraPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCameraPass.vtkCameraPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F89E RID: 63646 RVA: 0x0015982C File Offset: 0x00157A2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F89F RID: 63647
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCameraPass_GetAspectRatioOverride_01(HandleRef pThis);

		/// <summary>
		/// Used to override the aspect ratio used when computing the projection
		/// matrix. This is useful when rendering for tile-displays for example.
		/// </summary>
		// Token: 0x0600F8A0 RID: 63648 RVA: 0x00159838 File Offset: 0x00157A38
		public virtual double GetAspectRatioOverride()
		{
			return vtkCameraPass.vtkCameraPass_GetAspectRatioOverride_01(base.GetCppThis());
		}

		// Token: 0x0600F8A1 RID: 63649
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraPass_GetDelegatePass_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Delegate for rendering the geometry.
		/// If it is NULL, nothing will be rendered and a warning will be emitted.
		/// It is usually set to a vtkSequencePass with a vtkLightsPass and
		/// a list of passes for the geometry.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x0600F8A2 RID: 63650 RVA: 0x00159858 File Offset: 0x00157A58
		public virtual vtkRenderPass GetDelegatePass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraPass.vtkCameraPass_GetDelegatePass_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600F8A3 RID: 63651
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraPass_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8A4 RID: 63652 RVA: 0x001598C8 File Offset: 0x00157AC8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCameraPass.vtkCameraPass_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600F8A5 RID: 63653
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraPass_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8A6 RID: 63654 RVA: 0x001598E8 File Offset: 0x00157AE8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCameraPass.vtkCameraPass_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600F8A7 RID: 63655
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraPass_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8A8 RID: 63656 RVA: 0x00159904 File Offset: 0x00157B04
		public override int IsA(string type)
		{
			return vtkCameraPass.vtkCameraPass_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600F8A9 RID: 63657
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraPass_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8AA RID: 63658 RVA: 0x00159924 File Offset: 0x00157B24
		public new static int IsTypeOf(string type)
		{
			return vtkCameraPass.vtkCameraPass_IsTypeOf_06(type);
		}

		// Token: 0x0600F8AB RID: 63659
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraPass_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8AC RID: 63660 RVA: 0x00159940 File Offset: 0x00157B40
		public new vtkCameraPass NewInstance()
		{
			vtkCameraPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraPass.vtkCameraPass_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F8AD RID: 63661
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraPass_ReleaseGraphicsResources_09(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x0600F8AE RID: 63662 RVA: 0x0015999C File Offset: 0x00157B9C
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkCameraPass.vtkCameraPass_ReleaseGraphicsResources_09(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x0600F8AF RID: 63663
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraPass_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8B0 RID: 63664 RVA: 0x001599CC File Offset: 0x00157BCC
		public new static vtkCameraPass SafeDownCast(vtkObjectBase o)
		{
			vtkCameraPass vtkCameraPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraPass.vtkCameraPass_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraPass = (vtkCameraPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraPass.Register(null);
				}
			}
			return vtkCameraPass;
		}

		// Token: 0x0600F8B1 RID: 63665
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraPass_SetAspectRatioOverride_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Used to override the aspect ratio used when computing the projection
		/// matrix. This is useful when rendering for tile-displays for example.
		/// </summary>
		// Token: 0x0600F8B2 RID: 63666 RVA: 0x00159A4B File Offset: 0x00157C4B
		public virtual void SetAspectRatioOverride(double _arg)
		{
			vtkCameraPass.vtkCameraPass_SetAspectRatioOverride_11(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F8B3 RID: 63667
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraPass_SetDelegatePass_12(HandleRef pThis, HandleRef delegatePass);

		/// <summary>
		/// Delegate for rendering the geometry.
		/// If it is NULL, nothing will be rendered and a warning will be emitted.
		/// It is usually set to a vtkSequencePass with a vtkLightsPass and
		/// a list of passes for the geometry.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x0600F8B4 RID: 63668 RVA: 0x00159A5C File Offset: 0x00157C5C
		public virtual void SetDelegatePass(vtkRenderPass delegatePass)
		{
			vtkCameraPass.vtkCameraPass_SetDelegatePass_12(base.GetCppThis(), (delegatePass == null) ? default(HandleRef) : delegatePass.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001211 RID: 4625
		public new const string MRFullTypeName = "Kitware.VTK.vtkCameraPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001212 RID: 4626
		public new static readonly string MRClassNameKey = "class vtkCameraPass";
	}
}
