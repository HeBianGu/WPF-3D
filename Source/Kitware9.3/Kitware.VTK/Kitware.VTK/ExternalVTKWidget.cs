using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000116 RID: 278
	public class ExternalVTKWidget : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060038BE RID: 14526 RVA: 0x00052F6F File Offset: 0x0005116F
		static ExternalVTKWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), ExternalVTKWidget.MRClassNameKey, Type.GetType("Kitware.VTK.ExternalVTKWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060038BF RID: 14527 RVA: 0x00052F97 File Offset: 0x00051197
		public ExternalVTKWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060038C0 RID: 14528 RVA: 0x00052FA5 File Offset: 0x000511A5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060038C1 RID: 14529
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ExternalVTKWidget_AddRenderer_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060038C2 RID: 14530 RVA: 0x00052FB0 File Offset: 0x000511B0
		public vtkExternalOpenGLRenderer AddRenderer()
		{
			vtkExternalOpenGLRenderer vtkExternalOpenGLRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = ExternalVTKWidget.ExternalVTKWidget_AddRenderer_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExternalOpenGLRenderer = (vtkExternalOpenGLRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExternalOpenGLRenderer.Register(null);
				}
			}
			return vtkExternalOpenGLRenderer;
		}

		// Token: 0x060038C3 RID: 14531
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long ExternalVTKWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060038C4 RID: 14532 RVA: 0x00053020 File Offset: 0x00051220
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return ExternalVTKWidget.ExternalVTKWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060038C5 RID: 14533
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long ExternalVTKWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060038C6 RID: 14534 RVA: 0x00053040 File Offset: 0x00051240
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return ExternalVTKWidget.ExternalVTKWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060038C7 RID: 14535
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ExternalVTKWidget_GetRenderWindow_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060038C8 RID: 14536 RVA: 0x0005305C File Offset: 0x0005125C
		public vtkExternalOpenGLRenderWindow GetRenderWindow()
		{
			vtkExternalOpenGLRenderWindow vtkExternalOpenGLRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = ExternalVTKWidget.ExternalVTKWidget_GetRenderWindow_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExternalOpenGLRenderWindow = (vtkExternalOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExternalOpenGLRenderWindow.Register(null);
				}
			}
			return vtkExternalOpenGLRenderWindow;
		}

		// Token: 0x060038C9 RID: 14537
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int ExternalVTKWidget_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060038CA RID: 14538 RVA: 0x000530CC File Offset: 0x000512CC
		public override int IsA(string type)
		{
			return ExternalVTKWidget.ExternalVTKWidget_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060038CB RID: 14539
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int ExternalVTKWidget_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060038CC RID: 14540 RVA: 0x000530EC File Offset: 0x000512EC
		public new static int IsTypeOf(string type)
		{
			return ExternalVTKWidget.ExternalVTKWidget_IsTypeOf_06(type);
		}

		// Token: 0x060038CD RID: 14541
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ExternalVTKWidget_New_07(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060038CE RID: 14542 RVA: 0x00053108 File Offset: 0x00051308
		public new static ExternalVTKWidget New()
		{
			ExternalVTKWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = ExternalVTKWidget.ExternalVTKWidget_New_07(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (ExternalVTKWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		// Token: 0x060038CF RID: 14543
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ExternalVTKWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060038D0 RID: 14544 RVA: 0x0005315C File Offset: 0x0005135C
		public new ExternalVTKWidget NewInstance()
		{
			ExternalVTKWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = ExternalVTKWidget.ExternalVTKWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (ExternalVTKWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		// Token: 0x060038D1 RID: 14545
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ExternalVTKWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060038D2 RID: 14546 RVA: 0x000531B8 File Offset: 0x000513B8
		public new static ExternalVTKWidget SafeDownCast(vtkObjectBase o)
		{
			ExternalVTKWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = ExternalVTKWidget.ExternalVTKWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (ExternalVTKWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		// Token: 0x060038D3 RID: 14547
		[DllImport("Kitware.VTK.RenderingExternal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ExternalVTKWidget_SetRenderWindow_10(HandleRef pThis, HandleRef renWin);

		// Token: 0x060038D4 RID: 14548 RVA: 0x00053224 File Offset: 0x00051424
		public void SetRenderWindow(vtkExternalOpenGLRenderWindow renWin)
		{
			ExternalVTKWidget.ExternalVTKWidget_SetRenderWindow_10(base.GetCppThis(), (renWin == null) ? default(HandleRef) : renWin.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000664 RID: 1636
		public new const string MRFullTypeName = "Kitware.VTK.ExternalVTKWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000665 RID: 1637
		public new static readonly string MRClassNameKey = "class ExternalVTKWidget";
	}
}
