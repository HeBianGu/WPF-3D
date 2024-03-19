using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpaquePass
	/// </summary>
	/// <remarks>
	///    Render the opaque geometry with property key
	/// filtering.
	///
	/// vtkOpaquePass renders the opaque geometry of all the props that have the
	/// keys contained in vtkRenderState.
	///
	/// This pass expects an initialized depth buffer and color buffer.
	/// Initialized buffers means they have been cleared with farthest z-value and
	/// background color/gradient/transparent color.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass vtkDefaultPass
	/// </seealso>
	// Token: 0x0200059C RID: 1436
	public class vtkOpaquePass : vtkDefaultPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FC33 RID: 64563 RVA: 0x0015F43F File Offset: 0x0015D63F
		static vtkOpaquePass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpaquePass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpaquePass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FC34 RID: 64564 RVA: 0x0015F467 File Offset: 0x0015D667
		public vtkOpaquePass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FC35 RID: 64565
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpaquePass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC36 RID: 64566 RVA: 0x0015F478 File Offset: 0x0015D678
		public new static vtkOpaquePass New()
		{
			vtkOpaquePass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpaquePass.vtkOpaquePass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpaquePass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC37 RID: 64567 RVA: 0x0015F4CC File Offset: 0x0015D6CC
		public vtkOpaquePass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpaquePass.vtkOpaquePass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FC38 RID: 64568 RVA: 0x0015F510 File Offset: 0x0015D710
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FC39 RID: 64569
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpaquePass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC3A RID: 64570 RVA: 0x0015F51C File Offset: 0x0015D71C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpaquePass.vtkOpaquePass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600FC3B RID: 64571
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpaquePass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC3C RID: 64572 RVA: 0x0015F53C File Offset: 0x0015D73C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpaquePass.vtkOpaquePass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600FC3D RID: 64573
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpaquePass_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC3E RID: 64574 RVA: 0x0015F558 File Offset: 0x0015D758
		public override int IsA(string type)
		{
			return vtkOpaquePass.vtkOpaquePass_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600FC3F RID: 64575
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpaquePass_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC40 RID: 64576 RVA: 0x0015F578 File Offset: 0x0015D778
		public new static int IsTypeOf(string type)
		{
			return vtkOpaquePass.vtkOpaquePass_IsTypeOf_04(type);
		}

		// Token: 0x0600FC41 RID: 64577
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpaquePass_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC42 RID: 64578 RVA: 0x0015F594 File Offset: 0x0015D794
		public new vtkOpaquePass NewInstance()
		{
			vtkOpaquePass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpaquePass.vtkOpaquePass_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpaquePass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FC43 RID: 64579
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpaquePass_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC44 RID: 64580 RVA: 0x0015F5F0 File Offset: 0x0015D7F0
		public new static vtkOpaquePass SafeDownCast(vtkObjectBase o)
		{
			vtkOpaquePass vtkOpaquePass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpaquePass.vtkOpaquePass_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpaquePass = (vtkOpaquePass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpaquePass.Register(null);
				}
			}
			return vtkOpaquePass;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001261 RID: 4705
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpaquePass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001262 RID: 4706
		public new static readonly string MRClassNameKey = "class vtkOpaquePass";
	}
}
