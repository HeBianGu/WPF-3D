using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLRenderPass
	/// </summary>
	/// <remarks>
	///    Abstract render pass with shader modifications.
	///
	///
	/// Allows a render pass to update shader code using a new virtual API.
	/// </remarks>
	// Token: 0x02000582 RID: 1410
	public abstract class vtkOpenGLRenderPass : vtkRenderPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F99B RID: 63899 RVA: 0x0015AEE3 File Offset: 0x001590E3
		static vtkOpenGLRenderPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLRenderPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLRenderPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F99C RID: 63900 RVA: 0x0015AF0B File Offset: 0x0015910B
		public vtkOpenGLRenderPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F99D RID: 63901 RVA: 0x0015AF19 File Offset: 0x00159119
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F99E RID: 63902
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkOpenGLRenderPass_GetActiveDrawBuffers_01(HandleRef pThis);

		/// <summary>
		/// Number of active draw buffers.
		/// </summary>
		// Token: 0x0600F99F RID: 63903 RVA: 0x0015AF24 File Offset: 0x00159124
		public virtual uint GetActiveDrawBuffers()
		{
			return vtkOpenGLRenderPass.vtkOpenGLRenderPass_GetActiveDrawBuffers_01(base.GetCppThis());
		}

		// Token: 0x0600F9A0 RID: 63904
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLRenderPass_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9A1 RID: 63905 RVA: 0x0015AF44 File Offset: 0x00159144
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLRenderPass.vtkOpenGLRenderPass_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600F9A2 RID: 63906
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLRenderPass_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9A3 RID: 63907 RVA: 0x0015AF64 File Offset: 0x00159164
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLRenderPass.vtkOpenGLRenderPass_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600F9A4 RID: 63908
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkOpenGLRenderPass_GetShaderStageMTime_04(HandleRef pThis);

		/// <summary>
		/// For multi-stage render passes that need to change shader code during a
		/// single pass, use this method to notify a mapper that the shader needs to be
		/// rebuilt (rather than reuse the last cached shader. This method should
		/// return the last time that the shader stage changed, or 0 if the shader
		/// is single-stage.
		/// </summary>
		// Token: 0x0600F9A5 RID: 63909 RVA: 0x0015AF80 File Offset: 0x00159180
		public virtual ulong GetShaderStageMTime()
		{
			return vtkOpenGLRenderPass.vtkOpenGLRenderPass_GetShaderStageMTime_04(base.GetCppThis());
		}

		// Token: 0x0600F9A6 RID: 63910
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderPass_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9A7 RID: 63911 RVA: 0x0015AFA0 File Offset: 0x001591A0
		public override int IsA(string type)
		{
			return vtkOpenGLRenderPass.vtkOpenGLRenderPass_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600F9A8 RID: 63912
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderPass_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9A9 RID: 63913 RVA: 0x0015AFC0 File Offset: 0x001591C0
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLRenderPass.vtkOpenGLRenderPass_IsTypeOf_06(type);
		}

		// Token: 0x0600F9AA RID: 63914
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderPass_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9AB RID: 63915 RVA: 0x0015AFDC File Offset: 0x001591DC
		public new vtkOpenGLRenderPass NewInstance()
		{
			vtkOpenGLRenderPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderPass.vtkOpenGLRenderPass_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLRenderPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F9AC RID: 63916
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLRenderPass_PostReplaceShaderValues_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string geometryShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string fragmentShader, HandleRef mapper, HandleRef prop);

		/// <summary>
		/// Use vtkShaderProgram::Substitute to replace @code //VTK::XXX:YYY @endcode declarations in
		/// the shader sources. Gets called before other mapper shader replacements
		/// Return false on error.
		/// </summary>
		// Token: 0x0600F9AD RID: 63917 RVA: 0x0015B038 File Offset: 0x00159238
		public virtual bool PostReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
		{
			return vtkOpenGLRenderPass.vtkOpenGLRenderPass_PostReplaceShaderValues_08(base.GetCppThis(), vertexShader, geometryShader, fragmentShader, (mapper == null) ? default(HandleRef) : mapper.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis()) != 0;
		}

		// Token: 0x0600F9AE RID: 63918
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLRenderPass_PreReplaceShaderValues_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string geometryShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string fragmentShader, HandleRef mapper, HandleRef prop);

		/// <summary>
		/// Use vtkShaderProgram::Substitute to replace @code //VTK::XXX:YYY @endcode declarations in
		/// the shader sources. Gets called before other mapper shader replacements
		/// Return false on error.
		/// </summary>
		// Token: 0x0600F9AF RID: 63919 RVA: 0x0015B090 File Offset: 0x00159290
		public virtual bool PreReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
		{
			return vtkOpenGLRenderPass.vtkOpenGLRenderPass_PreReplaceShaderValues_09(base.GetCppThis(), vertexShader, geometryShader, fragmentShader, (mapper == null) ? default(HandleRef) : mapper.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis()) != 0;
		}

		// Token: 0x0600F9B0 RID: 63920
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderPass_RenderPasses_10(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key containing information about the current pass.
		/// </summary>
		// Token: 0x0600F9B1 RID: 63921 RVA: 0x0015B0E8 File Offset: 0x001592E8
		public static vtkInformationObjectBaseVectorKey RenderPasses()
		{
			vtkInformationObjectBaseVectorKey vtkInformationObjectBaseVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderPass.vtkOpenGLRenderPass_RenderPasses_10(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseVectorKey = (vtkInformationObjectBaseVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseVectorKey.Register(null);
				}
			}
			return vtkInformationObjectBaseVectorKey;
		}

		// Token: 0x0600F9B2 RID: 63922
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderPass_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9B3 RID: 63923 RVA: 0x0015B154 File Offset: 0x00159354
		public new static vtkOpenGLRenderPass SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLRenderPass vtkOpenGLRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderPass.vtkOpenGLRenderPass_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLRenderPass = (vtkOpenGLRenderPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLRenderPass.Register(null);
				}
			}
			return vtkOpenGLRenderPass;
		}

		// Token: 0x0600F9B4 RID: 63924
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderPass_SetActiveDrawBuffers_12(HandleRef pThis, uint _arg);

		/// <summary>
		/// Number of active draw buffers.
		/// </summary>
		// Token: 0x0600F9B5 RID: 63925 RVA: 0x0015B1D3 File Offset: 0x001593D3
		public virtual void SetActiveDrawBuffers(uint _arg)
		{
			vtkOpenGLRenderPass.vtkOpenGLRenderPass_SetActiveDrawBuffers_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400121D RID: 4637
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLRenderPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400121E RID: 4638
		public new static readonly string MRClassNameKey = "class vtkOpenGLRenderPass";
	}
}
