using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLActor
	/// </summary>
	/// <remarks>
	///    OpenGL actor
	///
	/// vtkOpenGLActor is a concrete implementation of the abstract class vtkActor.
	/// vtkOpenGLActor interfaces to the OpenGL rendering library.
	/// </remarks>
	// Token: 0x0200059D RID: 1437
	public class vtkOpenGLActor : vtkActor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FC45 RID: 64581 RVA: 0x0015F66F File Offset: 0x0015D86F
		static vtkOpenGLActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FC46 RID: 64582 RVA: 0x0015F697 File Offset: 0x0015D897
		public vtkOpenGLActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FC47 RID: 64583
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC48 RID: 64584 RVA: 0x0015F6A8 File Offset: 0x0015D8A8
		public new static vtkOpenGLActor New()
		{
			vtkOpenGLActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLActor.vtkOpenGLActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC49 RID: 64585 RVA: 0x0015F6FC File Offset: 0x0015D8FC
		public vtkOpenGLActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLActor.vtkOpenGLActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FC4A RID: 64586 RVA: 0x0015F740 File Offset: 0x0015D940
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FC4B RID: 64587
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLActor_GLDepthMaskOverride_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If this key is set in GetPropertyKeys(), the glDepthMask will be adjusted
		/// prior to rendering translucent objects. This is useful for e.g. depth
		/// peeling.
		///
		/// If GetIsOpaque() == true, the depth mask is always enabled, regardless of
		/// this key. Otherwise, the depth mask is disabled for default alpha blending
		/// unless this key is set.
		///
		/// If this key is set, the integer value has the following meanings:
		/// 0: glDepthMask(GL_FALSE)
		/// 1: glDepthMask(GL_TRUE)
		/// Anything else: No change to depth mask.
		/// </summary>
		// Token: 0x0600FC4C RID: 64588 RVA: 0x0015F74C File Offset: 0x0015D94C
		public static vtkInformationIntegerKey GLDepthMaskOverride()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLActor.vtkOpenGLActor_GLDepthMaskOverride_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0600FC4D RID: 64589
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLActor_GetKeyMatrices_02(HandleRef pThis, HandleRef WCVCMatrix, HandleRef normalMatrix);

		/// <summary>
		/// Actual actor render method.
		/// </summary>
		// Token: 0x0600FC4E RID: 64590 RVA: 0x0015F7B8 File Offset: 0x0015D9B8
		public virtual void GetKeyMatrices(vtkMatrix4x4 WCVCMatrix, vtkMatrix3x3 normalMatrix)
		{
			vtkOpenGLActor.vtkOpenGLActor_GetKeyMatrices_02(base.GetCppThis(), (WCVCMatrix == null) ? default(HandleRef) : WCVCMatrix.GetCppThis(), (normalMatrix == null) ? default(HandleRef) : normalMatrix.GetCppThis());
		}

		// Token: 0x0600FC4F RID: 64591
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLActor_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC50 RID: 64592 RVA: 0x0015F7FC File Offset: 0x0015D9FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLActor.vtkOpenGLActor_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600FC51 RID: 64593
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLActor_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC52 RID: 64594 RVA: 0x0015F81C File Offset: 0x0015DA1C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLActor.vtkOpenGLActor_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600FC53 RID: 64595
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLActor_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC54 RID: 64596 RVA: 0x0015F838 File Offset: 0x0015DA38
		public override int IsA(string type)
		{
			return vtkOpenGLActor.vtkOpenGLActor_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600FC55 RID: 64597
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLActor_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC56 RID: 64598 RVA: 0x0015F858 File Offset: 0x0015DA58
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLActor.vtkOpenGLActor_IsTypeOf_06(type);
		}

		// Token: 0x0600FC57 RID: 64599
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLActor_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC58 RID: 64600 RVA: 0x0015F874 File Offset: 0x0015DA74
		public new vtkOpenGLActor NewInstance()
		{
			vtkOpenGLActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLActor.vtkOpenGLActor_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FC59 RID: 64601
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLActor_Render_09(HandleRef pThis, HandleRef ren, HandleRef mapper);

		/// <summary>
		/// Actual actor render method.
		/// </summary>
		// Token: 0x0600FC5A RID: 64602 RVA: 0x0015F8D0 File Offset: 0x0015DAD0
		public override void Render(vtkRenderer ren, vtkMapper mapper)
		{
			vtkOpenGLActor.vtkOpenGLActor_Render_09(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x0600FC5B RID: 64603
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLActor_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC5C RID: 64604 RVA: 0x0015F914 File Offset: 0x0015DB14
		public new static vtkOpenGLActor SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLActor vtkOpenGLActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLActor.vtkOpenGLActor_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLActor = (vtkOpenGLActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLActor.Register(null);
				}
			}
			return vtkOpenGLActor;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001263 RID: 4707
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001264 RID: 4708
		public new static readonly string MRClassNameKey = "class vtkOpenGLActor";
	}
}
