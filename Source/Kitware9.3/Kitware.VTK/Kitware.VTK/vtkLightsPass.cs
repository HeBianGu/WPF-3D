using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLightsPass
	/// </summary>
	/// <remarks>
	///    Implement the lights render pass.
	///
	/// Render the lights.
	///
	/// This pass expects an initialized camera.
	/// It disables all the lights, apply transformations for lights following the
	/// camera, and turn on the enables lights.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass
	/// </seealso>
	// Token: 0x0200059B RID: 1435
	public class vtkLightsPass : vtkRenderPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FC21 RID: 64545 RVA: 0x0015F20F File Offset: 0x0015D40F
		static vtkLightsPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLightsPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLightsPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FC22 RID: 64546 RVA: 0x0015F237 File Offset: 0x0015D437
		public vtkLightsPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FC23 RID: 64547
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightsPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC24 RID: 64548 RVA: 0x0015F248 File Offset: 0x0015D448
		public new static vtkLightsPass New()
		{
			vtkLightsPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightsPass.vtkLightsPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightsPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC25 RID: 64549 RVA: 0x0015F29C File Offset: 0x0015D49C
		public vtkLightsPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLightsPass.vtkLightsPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FC26 RID: 64550 RVA: 0x0015F2E0 File Offset: 0x0015D4E0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FC27 RID: 64551
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLightsPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC28 RID: 64552 RVA: 0x0015F2EC File Offset: 0x0015D4EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLightsPass.vtkLightsPass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600FC29 RID: 64553
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLightsPass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC2A RID: 64554 RVA: 0x0015F30C File Offset: 0x0015D50C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLightsPass.vtkLightsPass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600FC2B RID: 64555
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightsPass_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC2C RID: 64556 RVA: 0x0015F328 File Offset: 0x0015D528
		public override int IsA(string type)
		{
			return vtkLightsPass.vtkLightsPass_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600FC2D RID: 64557
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightsPass_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC2E RID: 64558 RVA: 0x0015F348 File Offset: 0x0015D548
		public new static int IsTypeOf(string type)
		{
			return vtkLightsPass.vtkLightsPass_IsTypeOf_04(type);
		}

		// Token: 0x0600FC2F RID: 64559
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightsPass_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC30 RID: 64560 RVA: 0x0015F364 File Offset: 0x0015D564
		public new vtkLightsPass NewInstance()
		{
			vtkLightsPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightsPass.vtkLightsPass_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightsPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FC31 RID: 64561
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightsPass_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC32 RID: 64562 RVA: 0x0015F3C0 File Offset: 0x0015D5C0
		public new static vtkLightsPass SafeDownCast(vtkObjectBase o)
		{
			vtkLightsPass vtkLightsPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightsPass.vtkLightsPass_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLightsPass = (vtkLightsPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLightsPass.Register(null);
				}
			}
			return vtkLightsPass;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400125F RID: 4703
		public new const string MRFullTypeName = "Kitware.VTK.vtkLightsPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001260 RID: 4704
		public new static readonly string MRClassNameKey = "class vtkLightsPass";
	}
}
