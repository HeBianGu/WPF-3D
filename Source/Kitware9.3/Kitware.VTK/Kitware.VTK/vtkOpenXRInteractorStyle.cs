using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenXRInteractorStyle
	/// </summary>
	/// <remarks>
	///    extended from vtkInteractorStyle3D to override command methods
	/// </remarks>
	// Token: 0x020000B4 RID: 180
	public class vtkOpenXRInteractorStyle : vtkVRInteractorStyle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002797 RID: 10135 RVA: 0x0003A71E File Offset: 0x0003891E
		static vtkOpenXRInteractorStyle()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenXRInteractorStyle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenXRInteractorStyle"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002798 RID: 10136 RVA: 0x0003A746 File Offset: 0x00038946
		public vtkOpenXRInteractorStyle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002799 RID: 10137
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRInteractorStyle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600279A RID: 10138 RVA: 0x0003A754 File Offset: 0x00038954
		public new static vtkOpenXRInteractorStyle New()
		{
			vtkOpenXRInteractorStyle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRInteractorStyle.vtkOpenXRInteractorStyle_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenXRInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600279B RID: 10139 RVA: 0x0003A7A8 File Offset: 0x000389A8
		public vtkOpenXRInteractorStyle() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenXRInteractorStyle.vtkOpenXRInteractorStyle_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600279C RID: 10140 RVA: 0x0003A7EC File Offset: 0x000389EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600279D RID: 10141
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenXRInteractorStyle_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600279E RID: 10142 RVA: 0x0003A7F8 File Offset: 0x000389F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenXRInteractorStyle.vtkOpenXRInteractorStyle_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600279F RID: 10143
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenXRInteractorStyle_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060027A0 RID: 10144 RVA: 0x0003A818 File Offset: 0x00038A18
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenXRInteractorStyle.vtkOpenXRInteractorStyle_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060027A1 RID: 10145
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenXRInteractorStyle_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060027A2 RID: 10146 RVA: 0x0003A834 File Offset: 0x00038A34
		public override int IsA(string type)
		{
			return vtkOpenXRInteractorStyle.vtkOpenXRInteractorStyle_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060027A3 RID: 10147
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenXRInteractorStyle_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060027A4 RID: 10148 RVA: 0x0003A854 File Offset: 0x00038A54
		public new static int IsTypeOf(string type)
		{
			return vtkOpenXRInteractorStyle.vtkOpenXRInteractorStyle_IsTypeOf_04(type);
		}

		// Token: 0x060027A5 RID: 10149
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRInteractorStyle_LoadNextCameraPose_05(HandleRef pThis);

		/// <summary>
		/// Creates a new ControlsHelper suitable for use with this class.
		/// </summary>
		// Token: 0x060027A6 RID: 10150 RVA: 0x0003A86E File Offset: 0x00038A6E
		public override void LoadNextCameraPose()
		{
			vtkOpenXRInteractorStyle.vtkOpenXRInteractorStyle_LoadNextCameraPose_05(base.GetCppThis());
		}

		// Token: 0x060027A7 RID: 10151
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRInteractorStyle_MakeControlsHelper_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a new ControlsHelper suitable for use with this class.
		/// </summary>
		// Token: 0x060027A8 RID: 10152 RVA: 0x0003A880 File Offset: 0x00038A80
		public override vtkVRControlsHelper MakeControlsHelper()
		{
			vtkVRControlsHelper vtkVRControlsHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRInteractorStyle.vtkOpenXRInteractorStyle_MakeControlsHelper_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRControlsHelper = (vtkVRControlsHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRControlsHelper.Register(null);
				}
			}
			return vtkVRControlsHelper;
		}

		// Token: 0x060027A9 RID: 10153
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRInteractorStyle_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060027AA RID: 10154 RVA: 0x0003A8F0 File Offset: 0x00038AF0
		public new vtkOpenXRInteractorStyle NewInstance()
		{
			vtkOpenXRInteractorStyle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRInteractorStyle.vtkOpenXRInteractorStyle_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenXRInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060027AB RID: 10155
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRInteractorStyle_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060027AC RID: 10156 RVA: 0x0003A94C File Offset: 0x00038B4C
		public new static vtkOpenXRInteractorStyle SafeDownCast(vtkObjectBase o)
		{
			vtkOpenXRInteractorStyle vtkOpenXRInteractorStyle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRInteractorStyle.vtkOpenXRInteractorStyle_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenXRInteractorStyle = (vtkOpenXRInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenXRInteractorStyle.Register(null);
				}
			}
			return vtkOpenXRInteractorStyle;
		}

		// Token: 0x060027AD RID: 10157
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRInteractorStyle_SetupActions_10(HandleRef pThis, HandleRef iren);

		/// <summary>
		/// Setup default actions defined with an action path and a corresponding command.
		/// </summary>
		// Token: 0x060027AE RID: 10158 RVA: 0x0003A9CC File Offset: 0x00038BCC
		public override void SetupActions(vtkRenderWindowInteractor iren)
		{
			vtkOpenXRInteractorStyle.vtkOpenXRInteractorStyle_SetupActions_10(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000552 RID: 1362
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenXRInteractorStyle";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000553 RID: 1363
		public new static readonly string MRClassNameKey = "class vtkOpenXRInteractorStyle";
	}
}
