using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTDxInteractorStyle
	/// </summary>
	/// <remarks>
	///    provide 3DConnexion device event-driven interface to the rendering window
	///
	///
	/// vtkTDxInteractorStyle is an abstract class defining an event-driven
	/// interface to support 3DConnexion device events send by
	/// vtkRenderWindowInteractor.
	/// vtkRenderWindowInteractor forwards events in a platform independent form to
	/// vtkInteractorStyle which can then delegate some processing to
	/// vtkTDxInteractorStyle.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorStyle vtkRenderWindowInteractor
	/// vtkTDxInteractorStyleCamera
	/// </seealso>
	// Token: 0x02000817 RID: 2071
	public class vtkTDxInteractorStyle : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060154D4 RID: 87252 RVA: 0x001E2D3B File Offset: 0x001E0F3B
		static vtkTDxInteractorStyle()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTDxInteractorStyle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTDxInteractorStyle"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060154D5 RID: 87253 RVA: 0x001E2D63 File Offset: 0x001E0F63
		public vtkTDxInteractorStyle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060154D6 RID: 87254 RVA: 0x001E2D71 File Offset: 0x001E0F71
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060154D7 RID: 87255
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTDxInteractorStyle_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154D8 RID: 87256 RVA: 0x001E2D7C File Offset: 0x001E0F7C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTDxInteractorStyle.vtkTDxInteractorStyle_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060154D9 RID: 87257
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTDxInteractorStyle_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154DA RID: 87258 RVA: 0x001E2D9C File Offset: 0x001E0F9C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTDxInteractorStyle.vtkTDxInteractorStyle_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060154DB RID: 87259
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTDxInteractorStyle_GetSettings_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// 3Dconnexion device settings. (sensitivity, individual axis filters).
		/// Initial object is not null.
		/// </summary>
		// Token: 0x060154DC RID: 87260 RVA: 0x001E2DB8 File Offset: 0x001E0FB8
		public virtual vtkTDxInteractorStyleSettings GetSettings()
		{
			vtkTDxInteractorStyleSettings vtkTDxInteractorStyleSettings = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTDxInteractorStyle.vtkTDxInteractorStyle_GetSettings_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTDxInteractorStyleSettings = (vtkTDxInteractorStyleSettings)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTDxInteractorStyleSettings.Register(null);
				}
			}
			return vtkTDxInteractorStyleSettings;
		}

		// Token: 0x060154DD RID: 87261
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTDxInteractorStyle_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154DE RID: 87262 RVA: 0x001E2E28 File Offset: 0x001E1028
		public override int IsA(string type)
		{
			return vtkTDxInteractorStyle.vtkTDxInteractorStyle_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060154DF RID: 87263
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTDxInteractorStyle_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154E0 RID: 87264 RVA: 0x001E2E48 File Offset: 0x001E1048
		public new static int IsTypeOf(string type)
		{
			return vtkTDxInteractorStyle.vtkTDxInteractorStyle_IsTypeOf_05(type);
		}

		// Token: 0x060154E1 RID: 87265
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTDxInteractorStyle_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154E2 RID: 87266 RVA: 0x001E2E64 File Offset: 0x001E1064
		public new vtkTDxInteractorStyle NewInstance()
		{
			vtkTDxInteractorStyle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTDxInteractorStyle.vtkTDxInteractorStyle_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTDxInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060154E3 RID: 87267
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTDxInteractorStyle_OnButtonPressedEvent_07(HandleRef pThis, int button);

		/// <summary>
		/// Action on button pressed event. Default implementation is empty.
		/// </summary>
		// Token: 0x060154E4 RID: 87268 RVA: 0x001E2EBE File Offset: 0x001E10BE
		public virtual void OnButtonPressedEvent(int button)
		{
			vtkTDxInteractorStyle.vtkTDxInteractorStyle_OnButtonPressedEvent_07(base.GetCppThis(), button);
		}

		// Token: 0x060154E5 RID: 87269
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTDxInteractorStyle_OnButtonReleasedEvent_08(HandleRef pThis, int button);

		/// <summary>
		/// Action on button released event. Default implementation is empty.
		/// </summary>
		// Token: 0x060154E6 RID: 87270 RVA: 0x001E2ECE File Offset: 0x001E10CE
		public virtual void OnButtonReleasedEvent(int button)
		{
			vtkTDxInteractorStyle.vtkTDxInteractorStyle_OnButtonReleasedEvent_08(base.GetCppThis(), button);
		}

		// Token: 0x060154E7 RID: 87271
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTDxInteractorStyle_ProcessEvent_09(HandleRef pThis, HandleRef renderer, uint arg1, IntPtr calldata);

		/// <summary>
		/// Dispatch the events TDxMotionEvent, TDxButtonPressEvent and
		/// TDxButtonReleaseEvent to OnMotionEvent(), OnButtonPressedEvent() and
		/// OnButtonReleasedEvent() respectively.
		/// It is called by the vtkInteractorStyle.
		/// This method is virtual for convenient but you should really override
		/// the On*Event() methods only.
		/// \pre renderer can be null.
		/// </summary>
		// Token: 0x060154E8 RID: 87272 RVA: 0x001E2EE0 File Offset: 0x001E10E0
		public virtual void ProcessEvent(vtkRenderer renderer, uint arg1, IntPtr calldata)
		{
			vtkTDxInteractorStyle.vtkTDxInteractorStyle_ProcessEvent_09(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), arg1, calldata);
		}

		// Token: 0x060154E9 RID: 87273
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTDxInteractorStyle_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154EA RID: 87274 RVA: 0x001E2F14 File Offset: 0x001E1114
		public new static vtkTDxInteractorStyle SafeDownCast(vtkObjectBase o)
		{
			vtkTDxInteractorStyle vtkTDxInteractorStyle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTDxInteractorStyle.vtkTDxInteractorStyle_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTDxInteractorStyle = (vtkTDxInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTDxInteractorStyle.Register(null);
				}
			}
			return vtkTDxInteractorStyle;
		}

		// Token: 0x060154EB RID: 87275
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTDxInteractorStyle_SetSettings_11(HandleRef pThis, HandleRef settings);

		/// <summary>
		/// 3Dconnexion device settings. (sensitivity, individual axis filters).
		/// Initial object is not null.
		/// </summary>
		// Token: 0x060154EC RID: 87276 RVA: 0x001E2F94 File Offset: 0x001E1194
		public virtual void SetSettings(vtkTDxInteractorStyleSettings settings)
		{
			vtkTDxInteractorStyle.vtkTDxInteractorStyle_SetSettings_11(base.GetCppThis(), (settings == null) ? default(HandleRef) : settings.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001876 RID: 6262
		public new const string MRFullTypeName = "Kitware.VTK.vtkTDxInteractorStyle";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001877 RID: 6263
		public new static readonly string MRClassNameKey = "class vtkTDxInteractorStyle";
	}
}
