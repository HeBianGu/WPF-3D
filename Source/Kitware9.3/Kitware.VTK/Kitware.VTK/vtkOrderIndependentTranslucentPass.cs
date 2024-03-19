using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOrderIndependentTranslucentPass
	/// </summary>
	/// <remarks>
	///    Implement OIT rendering using average color
	///
	/// Simple version that uses average alpha weighted color
	/// and correct final computed alpha. Single pass approach.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass, vtkTranslucentPass, vtkFramebufferPass
	/// </seealso>
	// Token: 0x020005DA RID: 1498
	public class vtkOrderIndependentTranslucentPass : vtkOpenGLRenderPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060105BB RID: 67003 RVA: 0x0016C9F3 File Offset: 0x0016ABF3
		static vtkOrderIndependentTranslucentPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOrderIndependentTranslucentPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrderIndependentTranslucentPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060105BC RID: 67004 RVA: 0x0016CA1B File Offset: 0x0016AC1B
		public vtkOrderIndependentTranslucentPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060105BD RID: 67005
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrderIndependentTranslucentPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105BE RID: 67006 RVA: 0x0016CA2C File Offset: 0x0016AC2C
		public new static vtkOrderIndependentTranslucentPass New()
		{
			vtkOrderIndependentTranslucentPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrderIndependentTranslucentPass.vtkOrderIndependentTranslucentPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrderIndependentTranslucentPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105BF RID: 67007 RVA: 0x0016CA80 File Offset: 0x0016AC80
		public vtkOrderIndependentTranslucentPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOrderIndependentTranslucentPass.vtkOrderIndependentTranslucentPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060105C0 RID: 67008 RVA: 0x0016CAC4 File Offset: 0x0016ACC4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060105C1 RID: 67009
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderIndependentTranslucentPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105C2 RID: 67010 RVA: 0x0016CAD0 File Offset: 0x0016ACD0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOrderIndependentTranslucentPass.vtkOrderIndependentTranslucentPass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060105C3 RID: 67011
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderIndependentTranslucentPass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105C4 RID: 67012 RVA: 0x0016CAF0 File Offset: 0x0016ACF0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOrderIndependentTranslucentPass.vtkOrderIndependentTranslucentPass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060105C5 RID: 67013
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrderIndependentTranslucentPass_GetTranslucentPass_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Delegate for rendering the translucent polygonal geometry.
		/// If it is NULL, nothing will be rendered and a warning will be emitted.
		/// It is usually set to a vtkTranslucentPass.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x060105C6 RID: 67014 RVA: 0x0016CB0C File Offset: 0x0016AD0C
		public virtual vtkRenderPass GetTranslucentPass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrderIndependentTranslucentPass.vtkOrderIndependentTranslucentPass_GetTranslucentPass_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060105C7 RID: 67015
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrderIndependentTranslucentPass_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105C8 RID: 67016 RVA: 0x0016CB7C File Offset: 0x0016AD7C
		public override int IsA(string type)
		{
			return vtkOrderIndependentTranslucentPass.vtkOrderIndependentTranslucentPass_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060105C9 RID: 67017
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrderIndependentTranslucentPass_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105CA RID: 67018 RVA: 0x0016CB9C File Offset: 0x0016AD9C
		public new static int IsTypeOf(string type)
		{
			return vtkOrderIndependentTranslucentPass.vtkOrderIndependentTranslucentPass_IsTypeOf_05(type);
		}

		// Token: 0x060105CB RID: 67019
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrderIndependentTranslucentPass_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105CC RID: 67020 RVA: 0x0016CBB8 File Offset: 0x0016ADB8
		public new vtkOrderIndependentTranslucentPass NewInstance()
		{
			vtkOrderIndependentTranslucentPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrderIndependentTranslucentPass.vtkOrderIndependentTranslucentPass_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrderIndependentTranslucentPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060105CD RID: 67021
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOrderIndependentTranslucentPass_PostReplaceShaderValues_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string geometryShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string fragmentShader, HandleRef mapper, HandleRef prop);

		/// <summary>
		/// Delegate for rendering the translucent polygonal geometry.
		/// If it is NULL, nothing will be rendered and a warning will be emitted.
		/// It is usually set to a vtkTranslucentPass.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x060105CE RID: 67022 RVA: 0x0016CC14 File Offset: 0x0016AE14
		public override bool PostReplaceShaderValues(string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkProp prop)
		{
			return vtkOrderIndependentTranslucentPass.vtkOrderIndependentTranslucentPass_PostReplaceShaderValues_08(base.GetCppThis(), vertexShader, geometryShader, fragmentShader, (mapper == null) ? default(HandleRef) : mapper.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis()) != 0;
		}

		// Token: 0x060105CF RID: 67023
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderIndependentTranslucentPass_ReleaseGraphicsResources_09(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x060105D0 RID: 67024 RVA: 0x0016CC6C File Offset: 0x0016AE6C
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkOrderIndependentTranslucentPass.vtkOrderIndependentTranslucentPass_ReleaseGraphicsResources_09(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x060105D1 RID: 67025
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrderIndependentTranslucentPass_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105D2 RID: 67026 RVA: 0x0016CC9C File Offset: 0x0016AE9C
		public new static vtkOrderIndependentTranslucentPass SafeDownCast(vtkObjectBase o)
		{
			vtkOrderIndependentTranslucentPass vtkOrderIndependentTranslucentPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrderIndependentTranslucentPass.vtkOrderIndependentTranslucentPass_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOrderIndependentTranslucentPass = (vtkOrderIndependentTranslucentPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOrderIndependentTranslucentPass.Register(null);
				}
			}
			return vtkOrderIndependentTranslucentPass;
		}

		// Token: 0x060105D3 RID: 67027
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderIndependentTranslucentPass_SetTranslucentPass_11(HandleRef pThis, HandleRef translucentPass);

		/// <summary>
		/// Delegate for rendering the translucent polygonal geometry.
		/// If it is NULL, nothing will be rendered and a warning will be emitted.
		/// It is usually set to a vtkTranslucentPass.
		/// Initial value is a NULL pointer.
		/// </summary>
		// Token: 0x060105D4 RID: 67028 RVA: 0x0016CD1C File Offset: 0x0016AF1C
		public virtual void SetTranslucentPass(vtkRenderPass translucentPass)
		{
			vtkOrderIndependentTranslucentPass.vtkOrderIndependentTranslucentPass_SetTranslucentPass_11(base.GetCppThis(), (translucentPass == null) ? default(HandleRef) : translucentPass.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012FF RID: 4863
		public new const string MRFullTypeName = "Kitware.VTK.vtkOrderIndependentTranslucentPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001300 RID: 4864
		public new static readonly string MRClassNameKey = "class vtkOrderIndependentTranslucentPass";
	}
}
