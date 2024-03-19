using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkShadowMapPass
	/// </summary>
	/// <remarks>
	///    Implement a shadow mapping render pass.
	///
	/// Render the opaque polygonal geometry of a scene with shadow maps (a
	/// technique to render hard shadows in hardware).
	///
	/// This pass expects an initialized depth buffer and color buffer.
	/// Initialized buffers means they have been cleared with farthest z-value and
	/// background color/gradient/transparent color.
	/// An opaque pass may have been performed right after the initialization.
	///
	///
	///
	/// Its delegate is usually set to a vtkOpaquePass.
	///
	/// @par Implementation:
	/// The first pass of the algorithm is to generate a shadow map per light
	/// (depth map from the light point of view) by rendering the opaque objects
	/// with the OCCLUDER property keys.
	/// The second pass is to render the opaque objects with the RECEIVER keys.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass, vtkOpaquePass
	/// </seealso>
	// Token: 0x020005EE RID: 1518
	public class vtkShadowMapPass : vtkOpenGLRenderPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010833 RID: 67635 RVA: 0x00170A6A File Offset: 0x0016EC6A
		static vtkShadowMapPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShadowMapPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShadowMapPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010834 RID: 67636 RVA: 0x00170A92 File Offset: 0x0016EC92
		public vtkShadowMapPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010835 RID: 67637
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShadowMapPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010836 RID: 67638 RVA: 0x00170AA0 File Offset: 0x0016ECA0
		public new static vtkShadowMapPass New()
		{
			vtkShadowMapPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShadowMapPass.vtkShadowMapPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShadowMapPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010837 RID: 67639 RVA: 0x00170AF4 File Offset: 0x0016ECF4
		public vtkShadowMapPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkShadowMapPass.vtkShadowMapPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010838 RID: 67640 RVA: 0x00170B38 File Offset: 0x0016ED38
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010839 RID: 67641
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkShadowMapPass_GetFragmentDeclaration_01(HandleRef pThis);

		/// <summary>
		/// Get the shader code to compute light factors based
		/// on a mappers vertexVC variable
		/// </summary>
		// Token: 0x0601083A RID: 67642 RVA: 0x00170B44 File Offset: 0x0016ED44
		public string GetFragmentDeclaration()
		{
			return vtkShadowMapPass.vtkShadowMapPass_GetFragmentDeclaration_01(base.GetCppThis());
		}

		// Token: 0x0601083B RID: 67643
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkShadowMapPass_GetFragmentImplementation_02(HandleRef pThis);

		/// <summary>
		/// Get the shader code to compute light factors based
		/// on a mappers vertexVC variable
		/// </summary>
		// Token: 0x0601083C RID: 67644 RVA: 0x00170B64 File Offset: 0x0016ED64
		public string GetFragmentImplementation()
		{
			return vtkShadowMapPass.vtkShadowMapPass_GetFragmentImplementation_02(base.GetCppThis());
		}

		// Token: 0x0601083D RID: 67645
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShadowMapPass_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601083E RID: 67646 RVA: 0x00170B84 File Offset: 0x0016ED84
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkShadowMapPass.vtkShadowMapPass_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601083F RID: 67647
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShadowMapPass_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010840 RID: 67648 RVA: 0x00170BA4 File Offset: 0x0016EDA4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkShadowMapPass.vtkShadowMapPass_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06010841 RID: 67649
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShadowMapPass_GetOpaqueSequence_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Pass that render the lights and opaque geometry
		/// Typically a sequence pass with a light pass and opaque pass.
		/// </summary>
		// Token: 0x06010842 RID: 67650 RVA: 0x00170BC0 File Offset: 0x0016EDC0
		public virtual vtkRenderPass GetOpaqueSequence()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShadowMapPass.vtkShadowMapPass_GetOpaqueSequence_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06010843 RID: 67651
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShadowMapPass_GetShadowMapBakerPass_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Pass that generates the shadow maps.
		/// the vtkShadowMapPass will use the Resolution ivar of
		/// this pass.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x06010844 RID: 67652 RVA: 0x00170C30 File Offset: 0x0016EE30
		public virtual vtkShadowMapBakerPass GetShadowMapBakerPass()
		{
			vtkShadowMapBakerPass vtkShadowMapBakerPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShadowMapPass.vtkShadowMapPass_GetShadowMapBakerPass_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShadowMapBakerPass = (vtkShadowMapBakerPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShadowMapBakerPass.Register(null);
				}
			}
			return vtkShadowMapBakerPass;
		}

		// Token: 0x06010845 RID: 67653
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShadowMapPass_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010846 RID: 67654 RVA: 0x00170CA0 File Offset: 0x0016EEA0
		public override int IsA(string type)
		{
			return vtkShadowMapPass.vtkShadowMapPass_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06010847 RID: 67655
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShadowMapPass_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010848 RID: 67656 RVA: 0x00170CC0 File Offset: 0x0016EEC0
		public new static int IsTypeOf(string type)
		{
			return vtkShadowMapPass.vtkShadowMapPass_IsTypeOf_08(type);
		}

		// Token: 0x06010849 RID: 67657
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShadowMapPass_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601084A RID: 67658 RVA: 0x00170CDC File Offset: 0x0016EEDC
		public new vtkShadowMapPass NewInstance()
		{
			vtkShadowMapPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShadowMapPass.vtkShadowMapPass_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShadowMapPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601084B RID: 67659
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShadowMapPass_PostReplaceShaderValues_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string geometryShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string fragmentShader, HandleRef mapper, HandleRef prop);

		/// <summary>
		/// Get the shader code to compute light factors based
		/// on a mappers vertexVC variable
		/// </summary>
		// Token: 0x0601084C RID: 67660 RVA: 0x00170D38 File Offset: 0x0016EF38
		public override bool PostReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
		{
			return vtkShadowMapPass.vtkShadowMapPass_PostReplaceShaderValues_11(base.GetCppThis(), vertexShader, geometryShader, fragmentShader, (mapper == null) ? default(HandleRef) : mapper.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis()) != 0;
		}

		// Token: 0x0601084D RID: 67661
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkShadowMapPass_PreReplaceShaderValues_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string geometryShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string fragmentShader, HandleRef mapper, HandleRef prop);

		/// <summary>
		/// Get the shader code to compute light factors based
		/// on a mappers vertexVC variable
		/// </summary>
		// Token: 0x0601084E RID: 67662 RVA: 0x00170D90 File Offset: 0x0016EF90
		public override bool PreReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
		{
			return vtkShadowMapPass.vtkShadowMapPass_PreReplaceShaderValues_12(base.GetCppThis(), vertexShader, geometryShader, fragmentShader, (mapper == null) ? default(HandleRef) : mapper.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis()) != 0;
		}

		// Token: 0x0601084F RID: 67663
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShadowMapPass_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x06010850 RID: 67664 RVA: 0x00170DE8 File Offset: 0x0016EFE8
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkShadowMapPass.vtkShadowMapPass_ReleaseGraphicsResources_13(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x06010851 RID: 67665
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShadowMapPass_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010852 RID: 67666 RVA: 0x00170E18 File Offset: 0x0016F018
		public new static vtkShadowMapPass SafeDownCast(vtkObjectBase o)
		{
			vtkShadowMapPass vtkShadowMapPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShadowMapPass.vtkShadowMapPass_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShadowMapPass = (vtkShadowMapPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShadowMapPass.Register(null);
				}
			}
			return vtkShadowMapPass;
		}

		// Token: 0x06010853 RID: 67667
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShadowMapPass_SetOpaqueSequence_15(HandleRef pThis, HandleRef opaqueSequence);

		/// <summary>
		/// Pass that render the lights and opaque geometry
		/// Typically a sequence pass with a light pass and opaque pass.
		/// </summary>
		// Token: 0x06010854 RID: 67668 RVA: 0x00170E98 File Offset: 0x0016F098
		public virtual void SetOpaqueSequence(vtkRenderPass opaqueSequence)
		{
			vtkShadowMapPass.vtkShadowMapPass_SetOpaqueSequence_15(base.GetCppThis(), (opaqueSequence == null) ? default(HandleRef) : opaqueSequence.GetCppThis());
		}

		// Token: 0x06010855 RID: 67669
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShadowMapPass_SetShadowMapBakerPass_16(HandleRef pThis, HandleRef shadowMapBakerPass);

		/// <summary>
		/// Pass that generates the shadow maps.
		/// the vtkShadowMapPass will use the Resolution ivar of
		/// this pass.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x06010856 RID: 67670 RVA: 0x00170EC8 File Offset: 0x0016F0C8
		public virtual void SetShadowMapBakerPass(vtkShadowMapBakerPass shadowMapBakerPass)
		{
			vtkShadowMapPass.vtkShadowMapPass_SetShadowMapBakerPass_16(base.GetCppThis(), (shadowMapBakerPass == null) ? default(HandleRef) : shadowMapBakerPass.GetCppThis());
		}

		// Token: 0x06010857 RID: 67671
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShadowMapPass_ShadowMapPass_17(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// this key will contain the shadow map pass
		/// </summary>
		// Token: 0x06010858 RID: 67672 RVA: 0x00170EF8 File Offset: 0x0016F0F8
		public static vtkInformationObjectBaseKey ShadowMapPass()
		{
			vtkInformationObjectBaseKey vtkInformationObjectBaseKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShadowMapPass.vtkShadowMapPass_ShadowMapPass_17(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseKey = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseKey.Register(null);
				}
			}
			return vtkInformationObjectBaseKey;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400132E RID: 4910
		public new const string MRFullTypeName = "Kitware.VTK.vtkShadowMapPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400132F RID: 4911
		public new static readonly string MRClassNameKey = "class vtkShadowMapPass";
	}
}
