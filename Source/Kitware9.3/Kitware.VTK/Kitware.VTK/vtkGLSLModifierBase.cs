using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGLSLModifierBase
	/// </summary>
	/// <remarks>
	///    Abstract class that helps you develop modifier for VTK GLSL shaders
	/// </remarks>
	// Token: 0x02000592 RID: 1426
	public abstract class vtkGLSLModifierBase : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FB7F RID: 64383 RVA: 0x0015DCE7 File Offset: 0x0015BEE7
		static vtkGLSLModifierBase()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGLSLModifierBase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLSLModifierBase"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FB80 RID: 64384 RVA: 0x0015DD0F File Offset: 0x0015BF0F
		public vtkGLSLModifierBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FB81 RID: 64385 RVA: 0x0015DD1D File Offset: 0x0015BF1D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FB82 RID: 64386
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLSLModifierBase_GLSL_MODIFIERS_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// if this key exists on the \a ShaderMods of \a vtkDrawTexturedElements, that mod will be
		/// applied before rendering.
		/// </summary>
		// Token: 0x0600FB83 RID: 64387 RVA: 0x0015DD28 File Offset: 0x0015BF28
		public static vtkInformationObjectBaseKey GLSL_MODIFIERS()
		{
			vtkInformationObjectBaseKey vtkInformationObjectBaseKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLSLModifierBase.vtkGLSLModifierBase_GLSL_MODIFIERS_01(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600FB84 RID: 64388
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLSLModifierBase_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB85 RID: 64389 RVA: 0x0015DD94 File Offset: 0x0015BF94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGLSLModifierBase.vtkGLSLModifierBase_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600FB86 RID: 64390
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLSLModifierBase_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB87 RID: 64391 RVA: 0x0015DDB4 File Offset: 0x0015BFB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGLSLModifierBase.vtkGLSLModifierBase_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600FB88 RID: 64392
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLSLModifierBase_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB89 RID: 64393 RVA: 0x0015DDD0 File Offset: 0x0015BFD0
		public override int IsA(string type)
		{
			return vtkGLSLModifierBase.vtkGLSLModifierBase_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600FB8A RID: 64394
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLSLModifierBase_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB8B RID: 64395 RVA: 0x0015DDF0 File Offset: 0x0015BFF0
		public new static int IsTypeOf(string type)
		{
			return vtkGLSLModifierBase.vtkGLSLModifierBase_IsTypeOf_05(type);
		}

		// Token: 0x0600FB8C RID: 64396
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLSLModifierBase_IsUpToDate_06(HandleRef pThis, HandleRef renderer, HandleRef mapper, HandleRef actor);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB8D RID: 64397 RVA: 0x0015DE0C File Offset: 0x0015C00C
		public virtual bool IsUpToDate(vtkOpenGLRenderer renderer, vtkAbstractMapper mapper, vtkActor actor)
		{
			return vtkGLSLModifierBase.vtkGLSLModifierBase_IsUpToDate_06(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis()) != 0;
		}

		// Token: 0x0600FB8E RID: 64398
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLSLModifierBase_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB8F RID: 64399 RVA: 0x0015DE74 File Offset: 0x0015C074
		public new vtkGLSLModifierBase NewInstance()
		{
			vtkGLSLModifierBase result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLSLModifierBase.vtkGLSLModifierBase_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLSLModifierBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FB90 RID: 64400
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLSLModifierBase_ReplaceShaderValues_08(HandleRef pThis, HandleRef renderer, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string geometryShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string fragmentShader, HandleRef mapper, HandleRef actor);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB91 RID: 64401 RVA: 0x0015DED0 File Offset: 0x0015C0D0
		public virtual bool ReplaceShaderValues(vtkOpenGLRenderer renderer, string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkActor actor)
		{
			return vtkGLSLModifierBase.vtkGLSLModifierBase_ReplaceShaderValues_08(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), vertexShader, geometryShader, fragmentShader, (mapper == null) ? default(HandleRef) : mapper.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis()) != 0;
		}

		// Token: 0x0600FB92 RID: 64402
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLSLModifierBase_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB93 RID: 64403 RVA: 0x0015DF40 File Offset: 0x0015C140
		public new static vtkGLSLModifierBase SafeDownCast(vtkObjectBase o)
		{
			vtkGLSLModifierBase vtkGLSLModifierBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLSLModifierBase.vtkGLSLModifierBase_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGLSLModifierBase = (vtkGLSLModifierBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGLSLModifierBase.Register(null);
				}
			}
			return vtkGLSLModifierBase;
		}

		// Token: 0x0600FB94 RID: 64404
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGLSLModifierBase_SetPrimitiveType_10(HandleRef pThis, uint primType);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FB95 RID: 64405 RVA: 0x0015DFBF File Offset: 0x0015C1BF
		public void SetPrimitiveType(uint primType)
		{
			vtkGLSLModifierBase.vtkGLSLModifierBase_SetPrimitiveType_10(base.GetCppThis(), primType);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400124C RID: 4684
		public new const string MRFullTypeName = "Kitware.VTK.vtkGLSLModifierBase";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400124D RID: 4685
		public new static readonly string MRClassNameKey = "class vtkGLSLModifierBase";
	}
}
