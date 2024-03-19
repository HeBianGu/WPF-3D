using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <remarks>
	///  OpenGL2 override for vtkRenderTimerLog.
	/// </remarks>
	// Token: 0x020005C5 RID: 1477
	public class vtkOpenGLRenderTimerLog : vtkRenderTimerLog
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010268 RID: 66152 RVA: 0x00167E67 File Offset: 0x00166067
		static vtkOpenGLRenderTimerLog()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLRenderTimerLog.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLRenderTimerLog"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010269 RID: 66153 RVA: 0x00167E8F File Offset: 0x0016608F
		public vtkOpenGLRenderTimerLog(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601026A RID: 66154
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderTimerLog_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601026B RID: 66155 RVA: 0x00167EA0 File Offset: 0x001660A0
		public new static vtkOpenGLRenderTimerLog New()
		{
			vtkOpenGLRenderTimerLog result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderTimerLog.vtkOpenGLRenderTimerLog_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLRenderTimerLog)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601026C RID: 66156 RVA: 0x00167EF4 File Offset: 0x001660F4
		public vtkOpenGLRenderTimerLog() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLRenderTimerLog.vtkOpenGLRenderTimerLog_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601026D RID: 66157 RVA: 0x00167F38 File Offset: 0x00166138
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601026E RID: 66158
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLRenderTimerLog_FrameReady_01(HandleRef pThis);

		/// <summary>
		/// Overridden to do support check before returning.
		/// </summary>
		// Token: 0x0601026F RID: 66159 RVA: 0x00167F44 File Offset: 0x00166144
		public override bool FrameReady()
		{
			return vtkOpenGLRenderTimerLog.vtkOpenGLRenderTimerLog_FrameReady_01(base.GetCppThis()) != 0;
		}

		// Token: 0x06010270 RID: 66160
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLRenderTimerLog_GetLoggingEnabled_02(HandleRef pThis);

		/// <summary>
		/// Overridden to do support check before returning.
		/// </summary>
		// Token: 0x06010271 RID: 66161 RVA: 0x00167F6C File Offset: 0x0016616C
		public override bool GetLoggingEnabled()
		{
			return vtkOpenGLRenderTimerLog.vtkOpenGLRenderTimerLog_GetLoggingEnabled_02(base.GetCppThis()) != 0;
		}

		// Token: 0x06010272 RID: 66162
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkOpenGLRenderTimerLog_GetMinTimerPoolSize_03(HandleRef pThis);

		/// <summary>
		/// This implementations keeps a pool of vtkRenderTimers around, recycling them
		/// to avoid constantly allocating/freeing them. The pool is sometimes trimmed
		/// to free up memory if the number of timers in the pool is much greater the
		/// the number of timers currently used. This setting controls the minimum
		/// number of timers that will be kept. More may be kept if they are being
		/// used, but the pool will never be trimmed below this amount.
		///
		/// Default value is 32, but can be adjusted for specific use cases.
		/// </summary>
		// Token: 0x06010273 RID: 66163 RVA: 0x00167F94 File Offset: 0x00166194
		public virtual ulong GetMinTimerPoolSize()
		{
			return vtkOpenGLRenderTimerLog.vtkOpenGLRenderTimerLog_GetMinTimerPoolSize_03(base.GetCppThis());
		}

		// Token: 0x06010274 RID: 66164
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLRenderTimerLog_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010275 RID: 66165 RVA: 0x00167FB4 File Offset: 0x001661B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLRenderTimerLog.vtkOpenGLRenderTimerLog_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06010276 RID: 66166
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLRenderTimerLog_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010277 RID: 66167 RVA: 0x00167FD4 File Offset: 0x001661D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLRenderTimerLog.vtkOpenGLRenderTimerLog_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06010278 RID: 66168
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderTimerLog_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010279 RID: 66169 RVA: 0x00167FF0 File Offset: 0x001661F0
		public override int IsA(string type)
		{
			return vtkOpenGLRenderTimerLog.vtkOpenGLRenderTimerLog_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601027A RID: 66170
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLRenderTimerLog_IsSupported_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601027B RID: 66171 RVA: 0x00168010 File Offset: 0x00166210
		public override bool IsSupported()
		{
			return vtkOpenGLRenderTimerLog.vtkOpenGLRenderTimerLog_IsSupported_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0601027C RID: 66172
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLRenderTimerLog_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601027D RID: 66173 RVA: 0x00168038 File Offset: 0x00166238
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLRenderTimerLog.vtkOpenGLRenderTimerLog_IsTypeOf_08(type);
		}

		// Token: 0x0601027E RID: 66174
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderTimerLog_MarkEndEvent_09(HandleRef pThis);

		/// <summary>
		/// Overridden to do support check before returning.
		/// </summary>
		// Token: 0x0601027F RID: 66175 RVA: 0x00168052 File Offset: 0x00166252
		public override void MarkEndEvent()
		{
			vtkOpenGLRenderTimerLog.vtkOpenGLRenderTimerLog_MarkEndEvent_09(base.GetCppThis());
		}

		// Token: 0x06010280 RID: 66176
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderTimerLog_MarkFrame_10(HandleRef pThis);

		/// <summary>
		/// Overridden to do support check before returning.
		/// </summary>
		// Token: 0x06010281 RID: 66177 RVA: 0x00168061 File Offset: 0x00166261
		public override void MarkFrame()
		{
			vtkOpenGLRenderTimerLog.vtkOpenGLRenderTimerLog_MarkFrame_10(base.GetCppThis());
		}

		// Token: 0x06010282 RID: 66178
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderTimerLog_MarkStartEvent_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Overridden to do support check before returning.
		/// </summary>
		// Token: 0x06010283 RID: 66179 RVA: 0x00168070 File Offset: 0x00166270
		public override void MarkStartEvent(string name)
		{
			vtkOpenGLRenderTimerLog.vtkOpenGLRenderTimerLog_MarkStartEvent_11(base.GetCppThis(), name);
		}

		// Token: 0x06010284 RID: 66180
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderTimerLog_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010285 RID: 66181 RVA: 0x00168080 File Offset: 0x00166280
		public new vtkOpenGLRenderTimerLog NewInstance()
		{
			vtkOpenGLRenderTimerLog result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderTimerLog.vtkOpenGLRenderTimerLog_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLRenderTimerLog)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010286 RID: 66182
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderTimerLog_ReleaseGraphicsResources_14(HandleRef pThis);

		/// <summary>
		/// Releases any resources allocated on the graphics device.
		/// </summary>
		// Token: 0x06010287 RID: 66183 RVA: 0x001680DA File Offset: 0x001662DA
		public override void ReleaseGraphicsResources()
		{
			vtkOpenGLRenderTimerLog.vtkOpenGLRenderTimerLog_ReleaseGraphicsResources_14(base.GetCppThis());
		}

		// Token: 0x06010288 RID: 66184
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLRenderTimerLog_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010289 RID: 66185 RVA: 0x001680EC File Offset: 0x001662EC
		public new static vtkOpenGLRenderTimerLog SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLRenderTimerLog vtkOpenGLRenderTimerLog = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLRenderTimerLog.vtkOpenGLRenderTimerLog_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLRenderTimerLog = (vtkOpenGLRenderTimerLog)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLRenderTimerLog.Register(null);
				}
			}
			return vtkOpenGLRenderTimerLog;
		}

		// Token: 0x0601028A RID: 66186
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLRenderTimerLog_SetMinTimerPoolSize_16(HandleRef pThis, ulong _arg);

		/// <summary>
		/// This implementations keeps a pool of vtkRenderTimers around, recycling them
		/// to avoid constantly allocating/freeing them. The pool is sometimes trimmed
		/// to free up memory if the number of timers in the pool is much greater the
		/// the number of timers currently used. This setting controls the minimum
		/// number of timers that will be kept. More may be kept if they are being
		/// used, but the pool will never be trimmed below this amount.
		///
		/// Default value is 32, but can be adjusted for specific use cases.
		/// </summary>
		// Token: 0x0601028B RID: 66187 RVA: 0x0016816B File Offset: 0x0016636B
		public virtual void SetMinTimerPoolSize(ulong _arg)
		{
			vtkOpenGLRenderTimerLog.vtkOpenGLRenderTimerLog_SetMinTimerPoolSize_16(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012CC RID: 4812
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLRenderTimerLog";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012CD RID: 4813
		public new static readonly string MRClassNameKey = "class vtkOpenGLRenderTimerLog";
	}
}
