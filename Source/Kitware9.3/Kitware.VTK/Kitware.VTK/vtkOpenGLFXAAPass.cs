using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLFXAAPass
	/// </summary>
	/// <remarks>
	///    Render pass calling the FXAA filter
	///
	/// vtkOpenGLFXAAPass is an image post processing render pass. It is a fast anti aliasing
	/// filter.
	///
	/// This pass usually takes the camera pass as its delegate pass.
	///
	/// @note Currently, this pass wraps the existing FXAA implementation. It copies the pixels
	/// from the framebuffer to a texture. A better approach would be to use the usual render pass
	/// workflow to create a framebuffer drawing directly on the texture.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass vtkDefaultPass
	/// </seealso>
	// Token: 0x020005A4 RID: 1444
	public class vtkOpenGLFXAAPass : vtkImageProcessingPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FD47 RID: 64839 RVA: 0x00160DC1 File Offset: 0x0015EFC1
		static vtkOpenGLFXAAPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLFXAAPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLFXAAPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FD48 RID: 64840 RVA: 0x00160DE9 File Offset: 0x0015EFE9
		public vtkOpenGLFXAAPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FD49 RID: 64841
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFXAAPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD4A RID: 64842 RVA: 0x00160DF8 File Offset: 0x0015EFF8
		public new static vtkOpenGLFXAAPass New()
		{
			vtkOpenGLFXAAPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLFXAAPass.vtkOpenGLFXAAPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLFXAAPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD4B RID: 64843 RVA: 0x00160E4C File Offset: 0x0015F04C
		public vtkOpenGLFXAAPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLFXAAPass.vtkOpenGLFXAAPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FD4C RID: 64844 RVA: 0x00160E90 File Offset: 0x0015F090
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FD4D RID: 64845
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFXAAPass_GetFXAAOptions_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Perform rendering according to a render state.
		/// </summary>
		// Token: 0x0600FD4E RID: 64846 RVA: 0x00160E9C File Offset: 0x0015F09C
		public virtual vtkFXAAOptions GetFXAAOptions()
		{
			vtkFXAAOptions vtkFXAAOptions = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLFXAAPass.vtkOpenGLFXAAPass_GetFXAAOptions_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFXAAOptions = (vtkFXAAOptions)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFXAAOptions.Register(null);
				}
			}
			return vtkFXAAOptions;
		}

		// Token: 0x0600FD4F RID: 64847
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLFXAAPass_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD50 RID: 64848 RVA: 0x00160F0C File Offset: 0x0015F10C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLFXAAPass.vtkOpenGLFXAAPass_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600FD51 RID: 64849
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLFXAAPass_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD52 RID: 64850 RVA: 0x00160F2C File Offset: 0x0015F12C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLFXAAPass.vtkOpenGLFXAAPass_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600FD53 RID: 64851
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLFXAAPass_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD54 RID: 64852 RVA: 0x00160F48 File Offset: 0x0015F148
		public override int IsA(string type)
		{
			return vtkOpenGLFXAAPass.vtkOpenGLFXAAPass_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600FD55 RID: 64853
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLFXAAPass_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD56 RID: 64854 RVA: 0x00160F68 File Offset: 0x0015F168
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLFXAAPass.vtkOpenGLFXAAPass_IsTypeOf_05(type);
		}

		// Token: 0x0600FD57 RID: 64855
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFXAAPass_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD58 RID: 64856 RVA: 0x00160F84 File Offset: 0x0015F184
		public new vtkOpenGLFXAAPass NewInstance()
		{
			vtkOpenGLFXAAPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLFXAAPass.vtkOpenGLFXAAPass_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLFXAAPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FD59 RID: 64857
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLFXAAPass_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FD5A RID: 64858 RVA: 0x00160FE0 File Offset: 0x0015F1E0
		public new static vtkOpenGLFXAAPass SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLFXAAPass vtkOpenGLFXAAPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLFXAAPass.vtkOpenGLFXAAPass_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLFXAAPass = (vtkOpenGLFXAAPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLFXAAPass.Register(null);
				}
			}
			return vtkOpenGLFXAAPass;
		}

		// Token: 0x0600FD5B RID: 64859
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLFXAAPass_SetFXAAOptions_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Perform rendering according to a render state.
		/// </summary>
		// Token: 0x0600FD5C RID: 64860 RVA: 0x00161060 File Offset: 0x0015F260
		public virtual void SetFXAAOptions(vtkFXAAOptions arg0)
		{
			vtkOpenGLFXAAPass.vtkOpenGLFXAAPass_SetFXAAOptions_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001273 RID: 4723
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLFXAAPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001274 RID: 4724
		public new static readonly string MRClassNameKey = "class vtkOpenGLFXAAPass";
	}
}
