using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenXRRenderWindowInteractor
	/// </summary>
	/// <remarks>
	///    implements OpenXR specific functions
	/// required by vtkRenderWindowInteractor.
	///
	/// </remarks>
	// Token: 0x0200009D RID: 157
	public class vtkOpenXRRenderWindowInteractor : vtkVRRenderWindowInteractor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600213F RID: 8511 RVA: 0x0003215F File Offset: 0x0003035F
		static vtkOpenXRRenderWindowInteractor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenXRRenderWindowInteractor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenXRRenderWindowInteractor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002140 RID: 8512 RVA: 0x00032187 File Offset: 0x00030387
		public vtkOpenXRRenderWindowInteractor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002141 RID: 8513
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRRenderWindowInteractor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002142 RID: 8514 RVA: 0x00032198 File Offset: 0x00030398
		public new static vtkOpenXRRenderWindowInteractor New()
		{
			vtkOpenXRRenderWindowInteractor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRRenderWindowInteractor.vtkOpenXRRenderWindowInteractor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenXRRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002143 RID: 8515 RVA: 0x000321EC File Offset: 0x000303EC
		public vtkOpenXRRenderWindowInteractor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenXRRenderWindowInteractor.vtkOpenXRRenderWindowInteractor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002144 RID: 8516 RVA: 0x00032230 File Offset: 0x00030430
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002145 RID: 8517
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenXRRenderWindowInteractor_ApplyVibration_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string actionName, int hand, float amplitude, float duration, float frequency);

		/// <summary>
		/// Apply haptic vibration using the provided action
		/// \p action to emit vibration on \p hand to emit on \p amplitude 0.0 to 1.0.
		/// \p duration nanoseconds, default 25ms \p frequency (hz)
		/// </summary>
		// Token: 0x06002146 RID: 8518 RVA: 0x0003223C File Offset: 0x0003043C
		public bool ApplyVibration(string actionName, int hand, float amplitude, float duration, float frequency)
		{
			return vtkOpenXRRenderWindowInteractor.vtkOpenXRRenderWindowInteractor_ApplyVibration_01(base.GetCppThis(), actionName, hand, amplitude, duration, frequency) != 0;
		}

		// Token: 0x06002147 RID: 8519
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRenderWindowInteractor_DoOneEvent_02(HandleRef pThis, HandleRef renWin, HandleRef ren);

		/// <summary>
		/// Initialize the event handler
		/// </summary>
		// Token: 0x06002148 RID: 8520 RVA: 0x0003226C File Offset: 0x0003046C
		public override void DoOneEvent(vtkVRRenderWindow renWin, vtkRenderer ren)
		{
			vtkOpenXRRenderWindowInteractor.vtkOpenXRRenderWindowInteractor_DoOneEvent_02(base.GetCppThis(), (renWin == null) ? default(HandleRef) : renWin.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06002149 RID: 8521
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenXRRenderWindowInteractor_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600214A RID: 8522 RVA: 0x000322B0 File Offset: 0x000304B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenXRRenderWindowInteractor.vtkOpenXRRenderWindowInteractor_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600214B RID: 8523
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenXRRenderWindowInteractor_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600214C RID: 8524 RVA: 0x000322D0 File Offset: 0x000304D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenXRRenderWindowInteractor.vtkOpenXRRenderWindowInteractor_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600214D RID: 8525
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRenderWindowInteractor_Initialize_05(HandleRef pThis);

		/// <summary>
		/// Initialize the event handler
		/// </summary>
		// Token: 0x0600214E RID: 8526 RVA: 0x000322EA File Offset: 0x000304EA
		public override void Initialize()
		{
			vtkOpenXRRenderWindowInteractor.vtkOpenXRRenderWindowInteractor_Initialize_05(base.GetCppThis());
		}

		// Token: 0x0600214F RID: 8527
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenXRRenderWindowInteractor_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002150 RID: 8528 RVA: 0x000322FC File Offset: 0x000304FC
		public override int IsA(string type)
		{
			return vtkOpenXRRenderWindowInteractor.vtkOpenXRRenderWindowInteractor_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06002151 RID: 8529
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenXRRenderWindowInteractor_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002152 RID: 8530 RVA: 0x0003231C File Offset: 0x0003051C
		public new static int IsTypeOf(string type)
		{
			return vtkOpenXRRenderWindowInteractor.vtkOpenXRRenderWindowInteractor_IsTypeOf_07(type);
		}

		// Token: 0x06002153 RID: 8531
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRRenderWindowInteractor_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002154 RID: 8532 RVA: 0x00032338 File Offset: 0x00030538
		public new vtkOpenXRRenderWindowInteractor NewInstance()
		{
			vtkOpenXRRenderWindowInteractor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRRenderWindowInteractor.vtkOpenXRRenderWindowInteractor_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenXRRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002155 RID: 8533
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRRenderWindowInteractor_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002156 RID: 8534 RVA: 0x00032394 File Offset: 0x00030594
		public new static vtkOpenXRRenderWindowInteractor SafeDownCast(vtkObjectBase o)
		{
			vtkOpenXRRenderWindowInteractor vtkOpenXRRenderWindowInteractor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRRenderWindowInteractor.vtkOpenXRRenderWindowInteractor_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenXRRenderWindowInteractor = (vtkOpenXRRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenXRRenderWindowInteractor.Register(null);
				}
			}
			return vtkOpenXRRenderWindowInteractor;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400051B RID: 1307
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenXRRenderWindowInteractor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400051C RID: 1308
		public new static readonly string MRClassNameKey = "class vtkOpenXRRenderWindowInteractor";
	}
}
