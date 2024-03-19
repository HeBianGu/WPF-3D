using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkClearZPass
	/// </summary>
	/// <remarks>
	///    Clear the depth buffer with a given value.
	///
	/// Clear the depth buffer with a given value.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass
	/// </seealso>
	// Token: 0x0200057E RID: 1406
	public class vtkClearZPass : vtkRenderPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F8D1 RID: 63697 RVA: 0x00159D49 File Offset: 0x00157F49
		static vtkClearZPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClearZPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClearZPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F8D2 RID: 63698 RVA: 0x00159D71 File Offset: 0x00157F71
		public vtkClearZPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F8D3 RID: 63699
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClearZPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8D4 RID: 63700 RVA: 0x00159D80 File Offset: 0x00157F80
		public new static vtkClearZPass New()
		{
			vtkClearZPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClearZPass.vtkClearZPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClearZPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8D5 RID: 63701 RVA: 0x00159DD4 File Offset: 0x00157FD4
		public vtkClearZPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkClearZPass.vtkClearZPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F8D6 RID: 63702 RVA: 0x00159E18 File Offset: 0x00158018
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F8D7 RID: 63703
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClearZPass_GetDepth_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the depth value. Initial value is 1.0 (farthest).
		/// </summary>
		// Token: 0x0600F8D8 RID: 63704 RVA: 0x00159E24 File Offset: 0x00158024
		public virtual double GetDepth()
		{
			return vtkClearZPass.vtkClearZPass_GetDepth_01(base.GetCppThis());
		}

		// Token: 0x0600F8D9 RID: 63705
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClearZPass_GetDepthMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the depth value. Initial value is 1.0 (farthest).
		/// </summary>
		// Token: 0x0600F8DA RID: 63706 RVA: 0x00159E44 File Offset: 0x00158044
		public virtual double GetDepthMaxValue()
		{
			return vtkClearZPass.vtkClearZPass_GetDepthMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0600F8DB RID: 63707
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClearZPass_GetDepthMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the depth value. Initial value is 1.0 (farthest).
		/// </summary>
		// Token: 0x0600F8DC RID: 63708 RVA: 0x00159E64 File Offset: 0x00158064
		public virtual double GetDepthMinValue()
		{
			return vtkClearZPass.vtkClearZPass_GetDepthMinValue_03(base.GetCppThis());
		}

		// Token: 0x0600F8DD RID: 63709
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClearZPass_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8DE RID: 63710 RVA: 0x00159E84 File Offset: 0x00158084
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkClearZPass.vtkClearZPass_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600F8DF RID: 63711
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClearZPass_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8E0 RID: 63712 RVA: 0x00159EA4 File Offset: 0x001580A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkClearZPass.vtkClearZPass_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600F8E1 RID: 63713
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClearZPass_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8E2 RID: 63714 RVA: 0x00159EC0 File Offset: 0x001580C0
		public override int IsA(string type)
		{
			return vtkClearZPass.vtkClearZPass_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600F8E3 RID: 63715
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClearZPass_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8E4 RID: 63716 RVA: 0x00159EE0 File Offset: 0x001580E0
		public new static int IsTypeOf(string type)
		{
			return vtkClearZPass.vtkClearZPass_IsTypeOf_07(type);
		}

		// Token: 0x0600F8E5 RID: 63717
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClearZPass_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8E6 RID: 63718 RVA: 0x00159EFC File Offset: 0x001580FC
		public new vtkClearZPass NewInstance()
		{
			vtkClearZPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClearZPass.vtkClearZPass_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClearZPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F8E7 RID: 63719
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClearZPass_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F8E8 RID: 63720 RVA: 0x00159F58 File Offset: 0x00158158
		public new static vtkClearZPass SafeDownCast(vtkObjectBase o)
		{
			vtkClearZPass vtkClearZPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClearZPass.vtkClearZPass_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClearZPass = (vtkClearZPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClearZPass.Register(null);
				}
			}
			return vtkClearZPass;
		}

		// Token: 0x0600F8E9 RID: 63721
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClearZPass_SetDepth_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the depth value. Initial value is 1.0 (farthest).
		/// </summary>
		// Token: 0x0600F8EA RID: 63722 RVA: 0x00159FD7 File Offset: 0x001581D7
		public virtual void SetDepth(double _arg)
		{
			vtkClearZPass.vtkClearZPass_SetDepth_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001215 RID: 4629
		public new const string MRFullTypeName = "Kitware.VTK.vtkClearZPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001216 RID: 4630
		public new static readonly string MRClassNameKey = "class vtkClearZPass";
	}
}
