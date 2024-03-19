using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHiddenLineRemovalPass
	/// </summary>
	/// <remarks>
	///    RenderPass for HLR.
	///
	///
	/// This render pass renders wireframe polydata such that only the front
	/// wireframe surface is drawn.
	/// </remarks>
	// Token: 0x02000598 RID: 1432
	public class vtkHiddenLineRemovalPass : vtkOpenGLRenderPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FBF5 RID: 64501 RVA: 0x0015ECAA File Offset: 0x0015CEAA
		static vtkHiddenLineRemovalPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHiddenLineRemovalPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHiddenLineRemovalPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FBF6 RID: 64502 RVA: 0x0015ECD2 File Offset: 0x0015CED2
		public vtkHiddenLineRemovalPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FBF7 RID: 64503
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHiddenLineRemovalPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBF8 RID: 64504 RVA: 0x0015ECE0 File Offset: 0x0015CEE0
		public new static vtkHiddenLineRemovalPass New()
		{
			vtkHiddenLineRemovalPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHiddenLineRemovalPass.vtkHiddenLineRemovalPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHiddenLineRemovalPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBF9 RID: 64505 RVA: 0x0015ED34 File Offset: 0x0015CF34
		public vtkHiddenLineRemovalPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHiddenLineRemovalPass.vtkHiddenLineRemovalPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FBFA RID: 64506 RVA: 0x0015ED78 File Offset: 0x0015CF78
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FBFB RID: 64507
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHiddenLineRemovalPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBFC RID: 64508 RVA: 0x0015ED84 File Offset: 0x0015CF84
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHiddenLineRemovalPass.vtkHiddenLineRemovalPass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600FBFD RID: 64509
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHiddenLineRemovalPass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBFE RID: 64510 RVA: 0x0015EDA4 File Offset: 0x0015CFA4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHiddenLineRemovalPass.vtkHiddenLineRemovalPass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600FBFF RID: 64511
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHiddenLineRemovalPass_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC00 RID: 64512 RVA: 0x0015EDC0 File Offset: 0x0015CFC0
		public override int IsA(string type)
		{
			return vtkHiddenLineRemovalPass.vtkHiddenLineRemovalPass_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600FC01 RID: 64513
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHiddenLineRemovalPass_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC02 RID: 64514 RVA: 0x0015EDE0 File Offset: 0x0015CFE0
		public new static int IsTypeOf(string type)
		{
			return vtkHiddenLineRemovalPass.vtkHiddenLineRemovalPass_IsTypeOf_04(type);
		}

		// Token: 0x0600FC03 RID: 64515
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHiddenLineRemovalPass_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC04 RID: 64516 RVA: 0x0015EDFC File Offset: 0x0015CFFC
		public new vtkHiddenLineRemovalPass NewInstance()
		{
			vtkHiddenLineRemovalPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHiddenLineRemovalPass.vtkHiddenLineRemovalPass_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHiddenLineRemovalPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FC05 RID: 64517
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHiddenLineRemovalPass_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC06 RID: 64518 RVA: 0x0015EE58 File Offset: 0x0015D058
		public new static vtkHiddenLineRemovalPass SafeDownCast(vtkObjectBase o)
		{
			vtkHiddenLineRemovalPass vtkHiddenLineRemovalPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHiddenLineRemovalPass.vtkHiddenLineRemovalPass_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHiddenLineRemovalPass = (vtkHiddenLineRemovalPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHiddenLineRemovalPass.Register(null);
				}
			}
			return vtkHiddenLineRemovalPass;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001258 RID: 4696
		public new const string MRFullTypeName = "Kitware.VTK.vtkHiddenLineRemovalPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001259 RID: 4697
		public new static readonly string MRClassNameKey = "class vtkHiddenLineRemovalPass";
	}
}
