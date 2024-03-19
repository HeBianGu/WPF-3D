using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenXRRemotingRenderWindow
	/// </summary>
	/// <remarks>
	///    OpenXR remoting rendering window
	///
	///
	/// </remarks>
	// Token: 0x02000098 RID: 152
	public class vtkOpenXRRemotingRenderWindow : vtkOpenXRRenderWindow
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001F09 RID: 7945 RVA: 0x0002FCCC File Offset: 0x0002DECC
		static vtkOpenXRRemotingRenderWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenXRRemotingRenderWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenXRRemotingRenderWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001F0A RID: 7946 RVA: 0x0002FCF4 File Offset: 0x0002DEF4
		public vtkOpenXRRemotingRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001F0B RID: 7947
		[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRRemotingRenderWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001F0C RID: 7948 RVA: 0x0002FD04 File Offset: 0x0002DF04
		public new static vtkOpenXRRemotingRenderWindow New()
		{
			vtkOpenXRRemotingRenderWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRRemotingRenderWindow.vtkOpenXRRemotingRenderWindow_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenXRRemotingRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001F0D RID: 7949 RVA: 0x0002FD58 File Offset: 0x0002DF58
		public vtkOpenXRRemotingRenderWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenXRRemotingRenderWindow.vtkOpenXRRemotingRenderWindow_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001F0E RID: 7950 RVA: 0x0002FD9C File Offset: 0x0002DF9C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001F0F RID: 7951
		[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRemotingRenderWindow_CopyResultFrame_01(HandleRef pThis);

		/// <summary>
		/// Overridden to lock the opengl rendering while copying.
		/// </summary>
		// Token: 0x06001F10 RID: 7952 RVA: 0x0002FDA7 File Offset: 0x0002DFA7
		public override void CopyResultFrame()
		{
			vtkOpenXRRemotingRenderWindow.vtkOpenXRRemotingRenderWindow_CopyResultFrame_01(base.GetCppThis());
		}

		// Token: 0x06001F11 RID: 7953
		[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenXRRemotingRenderWindow_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001F12 RID: 7954 RVA: 0x0002FDB8 File Offset: 0x0002DFB8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenXRRemotingRenderWindow.vtkOpenXRRemotingRenderWindow_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06001F13 RID: 7955
		[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenXRRemotingRenderWindow_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001F14 RID: 7956 RVA: 0x0002FDD8 File Offset: 0x0002DFD8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenXRRemotingRenderWindow.vtkOpenXRRemotingRenderWindow_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06001F15 RID: 7957
		[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRemotingRenderWindow_Initialize_04(HandleRef pThis);

		/// <summary>
		/// Initialize helper window resources.
		/// </summary>
		// Token: 0x06001F16 RID: 7958 RVA: 0x0002FDF2 File Offset: 0x0002DFF2
		public override void Initialize()
		{
			vtkOpenXRRemotingRenderWindow.vtkOpenXRRemotingRenderWindow_Initialize_04(base.GetCppThis());
		}

		// Token: 0x06001F17 RID: 7959
		[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenXRRemotingRenderWindow_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001F18 RID: 7960 RVA: 0x0002FE04 File Offset: 0x0002E004
		public override int IsA(string type)
		{
			return vtkOpenXRRemotingRenderWindow.vtkOpenXRRemotingRenderWindow_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06001F19 RID: 7961
		[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenXRRemotingRenderWindow_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001F1A RID: 7962 RVA: 0x0002FE24 File Offset: 0x0002E024
		public new static int IsTypeOf(string type)
		{
			return vtkOpenXRRemotingRenderWindow.vtkOpenXRRemotingRenderWindow_IsTypeOf_06(type);
		}

		// Token: 0x06001F1B RID: 7963
		[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRRemotingRenderWindow_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001F1C RID: 7964 RVA: 0x0002FE40 File Offset: 0x0002E040
		public new vtkOpenXRRemotingRenderWindow NewInstance()
		{
			vtkOpenXRRemotingRenderWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRRemotingRenderWindow.vtkOpenXRRemotingRenderWindow_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenXRRemotingRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001F1D RID: 7965
		[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRRemotingRenderWindow_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001F1E RID: 7966 RVA: 0x0002FE9C File Offset: 0x0002E09C
		public new static vtkOpenXRRemotingRenderWindow SafeDownCast(vtkObjectBase o)
		{
			vtkOpenXRRemotingRenderWindow vtkOpenXRRemotingRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRRemotingRenderWindow.vtkOpenXRRemotingRenderWindow_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenXRRemotingRenderWindow = (vtkOpenXRRemotingRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenXRRemotingRenderWindow.Register(null);
				}
			}
			return vtkOpenXRRemotingRenderWindow;
		}

		// Token: 0x06001F1F RID: 7967
		[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRemotingRenderWindow_SetRemotingIPAddress_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string host);

		/// <summary>
		/// Set the OpenXR remoting IP address to connect to.
		/// </summary>
		// Token: 0x06001F20 RID: 7968 RVA: 0x0002FF1B File Offset: 0x0002E11B
		public void SetRemotingIPAddress(string host)
		{
			vtkOpenXRRemotingRenderWindow.vtkOpenXRRemotingRenderWindow_SetRemotingIPAddress_10(base.GetCppThis(), host);
		}

		// Token: 0x06001F21 RID: 7969
		[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRemotingRenderWindow_StereoMidpoint_11(HandleRef pThis);

		/// <summary>
		/// Overridden to draw to the shared D3D texture
		/// </summary>
		// Token: 0x06001F22 RID: 7970 RVA: 0x0002FF2B File Offset: 0x0002E12B
		public override void StereoMidpoint()
		{
			vtkOpenXRRemotingRenderWindow.vtkOpenXRRemotingRenderWindow_StereoMidpoint_11(base.GetCppThis());
		}

		// Token: 0x06001F23 RID: 7971
		[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRemotingRenderWindow_StereoRenderComplete_12(HandleRef pThis);

		/// <summary>
		/// Overridden to draw to the shared D3D texture
		/// </summary>
		// Token: 0x06001F24 RID: 7972 RVA: 0x0002FF3A File Offset: 0x0002E13A
		public override void StereoRenderComplete()
		{
			vtkOpenXRRemotingRenderWindow.vtkOpenXRRemotingRenderWindow_StereoRenderComplete_12(base.GetCppThis());
		}

		// Token: 0x06001F25 RID: 7973
		[DllImport("Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRemotingRenderWindow_StereoUpdate_13(HandleRef pThis);

		/// <summary>
		/// Overridden to draw to the shared D3D texture
		/// </summary>
		// Token: 0x06001F26 RID: 7974 RVA: 0x0002FF49 File Offset: 0x0002E149
		public override void StereoUpdate()
		{
			vtkOpenXRRemotingRenderWindow.vtkOpenXRRemotingRenderWindow_StereoUpdate_13(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000510 RID: 1296
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenXRRemotingRenderWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000511 RID: 1297
		public new static readonly string MRClassNameKey = "class vtkOpenXRRemotingRenderWindow";
	}
}
