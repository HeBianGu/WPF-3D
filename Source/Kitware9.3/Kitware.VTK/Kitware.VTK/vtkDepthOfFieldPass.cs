using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDepthOfFieldPass
	/// </summary>
	/// <remarks>
	///    Implement a post-processing DOF blur pass.
	///
	/// Currently only does behind the focal plane
	///
	/// This pass expects an initialized depth buffer and color buffer.
	/// Initialized buffers means they have been cleared with farthest z-value and
	/// background color/gradient/transparent color.
	///
	/// The delegate is used once.
	///
	/// Its delegate is usually set to a vtkCameraPass or to a post-processing pass.
	///
	/// @par Implementation:
	/// As the filter is separable, it first blurs the image horizontally and then
	/// vertically. This reduces the number of texture samples
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass
	/// </seealso>
	// Token: 0x02000585 RID: 1413
	public class vtkDepthOfFieldPass : vtkDepthImageProcessingPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F9DA RID: 63962 RVA: 0x0015B5DB File Offset: 0x001597DB
		static vtkDepthOfFieldPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDepthOfFieldPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDepthOfFieldPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F9DB RID: 63963 RVA: 0x0015B603 File Offset: 0x00159803
		public vtkDepthOfFieldPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F9DC RID: 63964
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthOfFieldPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9DD RID: 63965 RVA: 0x0015B614 File Offset: 0x00159814
		public new static vtkDepthOfFieldPass New()
		{
			vtkDepthOfFieldPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthOfFieldPass.vtkDepthOfFieldPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDepthOfFieldPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9DE RID: 63966 RVA: 0x0015B668 File Offset: 0x00159868
		public vtkDepthOfFieldPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDepthOfFieldPass.vtkDepthOfFieldPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F9DF RID: 63967 RVA: 0x0015B6AC File Offset: 0x001598AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F9E0 RID: 63968
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthOfFieldPass_AutomaticFocalDistanceOff_01(HandleRef pThis);

		/// <summary>
		/// Use automatic focal distance calculation, this is on by default
		/// When on the center of the viewport will always be in focus
		/// regardless of where the focal point is.
		/// </summary>
		// Token: 0x0600F9E1 RID: 63969 RVA: 0x0015B6B7 File Offset: 0x001598B7
		public virtual void AutomaticFocalDistanceOff()
		{
			vtkDepthOfFieldPass.vtkDepthOfFieldPass_AutomaticFocalDistanceOff_01(base.GetCppThis());
		}

		// Token: 0x0600F9E2 RID: 63970
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthOfFieldPass_AutomaticFocalDistanceOn_02(HandleRef pThis);

		/// <summary>
		/// Use automatic focal distance calculation, this is on by default
		/// When on the center of the viewport will always be in focus
		/// regardless of where the focal point is.
		/// </summary>
		// Token: 0x0600F9E3 RID: 63971 RVA: 0x0015B6C6 File Offset: 0x001598C6
		public virtual void AutomaticFocalDistanceOn()
		{
			vtkDepthOfFieldPass.vtkDepthOfFieldPass_AutomaticFocalDistanceOn_02(base.GetCppThis());
		}

		// Token: 0x0600F9E4 RID: 63972
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDepthOfFieldPass_GetAutomaticFocalDistance_03(HandleRef pThis);

		/// <summary>
		/// Use automatic focal distance calculation, this is on by default
		/// When on the center of the viewport will always be in focus
		/// regardless of where the focal point is.
		/// </summary>
		// Token: 0x0600F9E5 RID: 63973 RVA: 0x0015B6D8 File Offset: 0x001598D8
		public virtual bool GetAutomaticFocalDistance()
		{
			return vtkDepthOfFieldPass.vtkDepthOfFieldPass_GetAutomaticFocalDistance_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F9E6 RID: 63974
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDepthOfFieldPass_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9E7 RID: 63975 RVA: 0x0015B700 File Offset: 0x00159900
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDepthOfFieldPass.vtkDepthOfFieldPass_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600F9E8 RID: 63976
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDepthOfFieldPass_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9E9 RID: 63977 RVA: 0x0015B720 File Offset: 0x00159920
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDepthOfFieldPass.vtkDepthOfFieldPass_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600F9EA RID: 63978
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDepthOfFieldPass_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9EB RID: 63979 RVA: 0x0015B73C File Offset: 0x0015993C
		public override int IsA(string type)
		{
			return vtkDepthOfFieldPass.vtkDepthOfFieldPass_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600F9EC RID: 63980
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDepthOfFieldPass_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9ED RID: 63981 RVA: 0x0015B75C File Offset: 0x0015995C
		public new static int IsTypeOf(string type)
		{
			return vtkDepthOfFieldPass.vtkDepthOfFieldPass_IsTypeOf_07(type);
		}

		// Token: 0x0600F9EE RID: 63982
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthOfFieldPass_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9EF RID: 63983 RVA: 0x0015B778 File Offset: 0x00159978
		public new vtkDepthOfFieldPass NewInstance()
		{
			vtkDepthOfFieldPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthOfFieldPass.vtkDepthOfFieldPass_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDepthOfFieldPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F9F0 RID: 63984
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthOfFieldPass_ReleaseGraphicsResources_10(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Release graphics resources and ask components to release their own
		/// resources.
		/// \pre w_exists: w!=0
		/// </summary>
		// Token: 0x0600F9F1 RID: 63985 RVA: 0x0015B7D4 File Offset: 0x001599D4
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkDepthOfFieldPass.vtkDepthOfFieldPass_ReleaseGraphicsResources_10(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x0600F9F2 RID: 63986
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthOfFieldPass_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F9F3 RID: 63987 RVA: 0x0015B804 File Offset: 0x00159A04
		public new static vtkDepthOfFieldPass SafeDownCast(vtkObjectBase o)
		{
			vtkDepthOfFieldPass vtkDepthOfFieldPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthOfFieldPass.vtkDepthOfFieldPass_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDepthOfFieldPass = (vtkDepthOfFieldPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDepthOfFieldPass.Register(null);
				}
			}
			return vtkDepthOfFieldPass;
		}

		// Token: 0x0600F9F4 RID: 63988
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthOfFieldPass_SetAutomaticFocalDistance_12(HandleRef pThis, byte _arg);

		/// <summary>
		/// Use automatic focal distance calculation, this is on by default
		/// When on the center of the viewport will always be in focus
		/// regardless of where the focal point is.
		/// </summary>
		// Token: 0x0600F9F5 RID: 63989 RVA: 0x0015B883 File Offset: 0x00159A83
		public virtual void SetAutomaticFocalDistance(bool _arg)
		{
			vtkDepthOfFieldPass.vtkDepthOfFieldPass_SetAutomaticFocalDistance_12(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001223 RID: 4643
		public new const string MRFullTypeName = "Kitware.VTK.vtkDepthOfFieldPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001224 RID: 4644
		public new static readonly string MRClassNameKey = "class vtkDepthOfFieldPass";
	}
}
