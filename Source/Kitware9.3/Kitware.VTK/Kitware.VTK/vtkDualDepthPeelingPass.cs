using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDualDepthPeelingPass
	/// </summary>
	/// <remarks>
	///    Implements the dual depth peeling algorithm.
	///
	///
	/// Dual depth peeling is an augmentatation of the standard depth peeling
	/// algorithm that peels two layers (front and back) for each render pass. The
	/// technique is described in "Order independent transparency with dual depth
	/// peeling" (February 2008) by L. Bavoil, K. Myers.
	///
	/// This algorithm has been extended to also peel volumetric data along with
	/// translucent geometry. To use this feature, set VolumetricPass to an
	/// appropriate RenderPass (usually vtkVolumetricPass).
	///
	/// The pass occurs in several stages:
	///
	/// 1. Copy the current (opaque geometry) depth buffer into a texture.
	/// 2. Initialize the min-max depth buffer from the opaque depth texture and the
	///    translucent geometry.
	/// 3. Peel the nearest and farthest fragments:
	/// 3a. Blend fragments that match the nearest depth of the min-max depth buffer
	///     into the front buffer.
	/// 3b. Write the far depth fragments into a temporary buffer.
	/// 3c. Extract the next set of min/max depth values for the next peel.
	/// 3d. Blend the temporary far fragment texture (3b) into an accumulation
	///     texture.
	/// 3e. Go back to 3a and repeat until the maximum number of peels is met, or
	///     the desired occlusion ratio is satisfied.
	/// 4. If the occlusion ratio != 0 (i.e. we hit the maximum number of peels
	///    before finishing), alpha blend the remaining fragments in-between the
	///    near and far accumulation textures.
	/// 5. Blend all accumulation buffers over the opaque color buffer to produce the
	///    final image.
	/// </remarks>
	// Token: 0x02000589 RID: 1417
	public class vtkDualDepthPeelingPass : vtkDepthPeelingPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FA3F RID: 64063 RVA: 0x0015C053 File Offset: 0x0015A253
		static vtkDualDepthPeelingPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDualDepthPeelingPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDualDepthPeelingPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FA40 RID: 64064 RVA: 0x0015C07B File Offset: 0x0015A27B
		public vtkDualDepthPeelingPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FA41 RID: 64065
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDualDepthPeelingPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA42 RID: 64066 RVA: 0x0015C08C File Offset: 0x0015A28C
		public new static vtkDualDepthPeelingPass New()
		{
			vtkDualDepthPeelingPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDualDepthPeelingPass.vtkDualDepthPeelingPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDualDepthPeelingPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA43 RID: 64067 RVA: 0x0015C0E0 File Offset: 0x0015A2E0
		public vtkDualDepthPeelingPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDualDepthPeelingPass.vtkDualDepthPeelingPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FA44 RID: 64068 RVA: 0x0015C124 File Offset: 0x0015A324
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FA45 RID: 64069
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDualDepthPeelingPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA46 RID: 64070 RVA: 0x0015C130 File Offset: 0x0015A330
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDualDepthPeelingPass.vtkDualDepthPeelingPass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600FA47 RID: 64071
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDualDepthPeelingPass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA48 RID: 64072 RVA: 0x0015C150 File Offset: 0x0015A350
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDualDepthPeelingPass.vtkDualDepthPeelingPass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600FA49 RID: 64073
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDualDepthPeelingPass_GetShaderStageMTime_03(HandleRef pThis);

		/// <summary>
		/// Delegate for rendering the volumetric geometry, if needed.
		/// It is usually set to a vtkVolumetricPass.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x0600FA4A RID: 64074 RVA: 0x0015C16C File Offset: 0x0015A36C
		public override ulong GetShaderStageMTime()
		{
			return vtkDualDepthPeelingPass.vtkDualDepthPeelingPass_GetShaderStageMTime_03(base.GetCppThis());
		}

		// Token: 0x0600FA4B RID: 64075
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDualDepthPeelingPass_GetVolumetricPass_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Delegate for rendering the volumetric geometry, if needed.
		/// It is usually set to a vtkVolumetricPass.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x0600FA4C RID: 64076 RVA: 0x0015C18C File Offset: 0x0015A38C
		public virtual vtkRenderPass GetVolumetricPass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDualDepthPeelingPass.vtkDualDepthPeelingPass_GetVolumetricPass_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600FA4D RID: 64077
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDualDepthPeelingPass_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA4E RID: 64078 RVA: 0x0015C1FC File Offset: 0x0015A3FC
		public override int IsA(string type)
		{
			return vtkDualDepthPeelingPass.vtkDualDepthPeelingPass_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600FA4F RID: 64079
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDualDepthPeelingPass_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA50 RID: 64080 RVA: 0x0015C21C File Offset: 0x0015A41C
		public new static int IsTypeOf(string type)
		{
			return vtkDualDepthPeelingPass.vtkDualDepthPeelingPass_IsTypeOf_06(type);
		}

		// Token: 0x0600FA51 RID: 64081
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDualDepthPeelingPass_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA52 RID: 64082 RVA: 0x0015C238 File Offset: 0x0015A438
		public new vtkDualDepthPeelingPass NewInstance()
		{
			vtkDualDepthPeelingPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDualDepthPeelingPass.vtkDualDepthPeelingPass_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDualDepthPeelingPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FA53 RID: 64083
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDualDepthPeelingPass_PostReplaceShaderValues_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string geometryShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string fragmentShader, HandleRef mapper, HandleRef prop);

		/// <summary>
		/// Delegate for rendering the volumetric geometry, if needed.
		/// It is usually set to a vtkVolumetricPass.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x0600FA54 RID: 64084 RVA: 0x0015C294 File Offset: 0x0015A494
		public override bool PostReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
		{
			return vtkDualDepthPeelingPass.vtkDualDepthPeelingPass_PostReplaceShaderValues_09(base.GetCppThis(), vertexShader, geometryShader, fragmentShader, (mapper == null) ? default(HandleRef) : mapper.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis()) != 0;
		}

		// Token: 0x0600FA55 RID: 64085
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDualDepthPeelingPass_PreReplaceShaderValues_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string geometryShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string fragmentShader, HandleRef mapper, HandleRef prop);

		/// <summary>
		/// Delegate for rendering the volumetric geometry, if needed.
		/// It is usually set to a vtkVolumetricPass.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x0600FA56 RID: 64086 RVA: 0x0015C2EC File Offset: 0x0015A4EC
		public override bool PreReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
		{
			return vtkDualDepthPeelingPass.vtkDualDepthPeelingPass_PreReplaceShaderValues_10(base.GetCppThis(), vertexShader, geometryShader, fragmentShader, (mapper == null) ? default(HandleRef) : mapper.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis()) != 0;
		}

		// Token: 0x0600FA57 RID: 64087
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDualDepthPeelingPass_ReleaseGraphicsResources_11(HandleRef pThis, HandleRef w);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA58 RID: 64088 RVA: 0x0015C344 File Offset: 0x0015A544
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkDualDepthPeelingPass.vtkDualDepthPeelingPass_ReleaseGraphicsResources_11(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x0600FA59 RID: 64089
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDualDepthPeelingPass_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA5A RID: 64090 RVA: 0x0015C374 File Offset: 0x0015A574
		public new static vtkDualDepthPeelingPass SafeDownCast(vtkObjectBase o)
		{
			vtkDualDepthPeelingPass vtkDualDepthPeelingPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDualDepthPeelingPass.vtkDualDepthPeelingPass_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDualDepthPeelingPass = (vtkDualDepthPeelingPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDualDepthPeelingPass.Register(null);
				}
			}
			return vtkDualDepthPeelingPass;
		}

		// Token: 0x0600FA5B RID: 64091
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDualDepthPeelingPass_SetVolumetricPass_13(HandleRef pThis, HandleRef volumetricPass);

		/// <summary>
		/// Delegate for rendering the volumetric geometry, if needed.
		/// It is usually set to a vtkVolumetricPass.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x0600FA5C RID: 64092 RVA: 0x0015C3F4 File Offset: 0x0015A5F4
		public virtual void SetVolumetricPass(vtkRenderPass volumetricPass)
		{
			vtkDualDepthPeelingPass.vtkDualDepthPeelingPass_SetVolumetricPass_13(base.GetCppThis(), (volumetricPass == null) ? default(HandleRef) : volumetricPass.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001230 RID: 4656
		public new const string MRFullTypeName = "Kitware.VTK.vtkDualDepthPeelingPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001231 RID: 4657
		public new static readonly string MRClassNameKey = "class vtkDualDepthPeelingPass";
	}
}
