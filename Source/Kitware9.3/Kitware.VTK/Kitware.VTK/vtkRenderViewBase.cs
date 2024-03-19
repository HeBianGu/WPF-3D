using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderViewBase
	/// </summary>
	/// <remarks>
	///    A base view containing a renderer.
	///
	///
	/// vtkRenderViewBase is a view which contains a vtkRenderer.  You may add
	/// vtkActors directly to the renderer.
	///
	/// This class is also the parent class for any more specialized view which uses
	/// a renderer.
	///
	/// </remarks>
	// Token: 0x02000057 RID: 87
	public class vtkRenderViewBase : vtkView
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000FCC RID: 4044 RVA: 0x0001CABE File Offset: 0x0001ACBE
		static vtkRenderViewBase()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderViewBase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderViewBase"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000FCD RID: 4045 RVA: 0x0001CAE6 File Offset: 0x0001ACE6
		public vtkRenderViewBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000FCE RID: 4046
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderViewBase_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FCF RID: 4047 RVA: 0x0001CAF4 File Offset: 0x0001ACF4
		public new static vtkRenderViewBase New()
		{
			vtkRenderViewBase result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderViewBase.vtkRenderViewBase_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderViewBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FD0 RID: 4048 RVA: 0x0001CB48 File Offset: 0x0001AD48
		public vtkRenderViewBase() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRenderViewBase.vtkRenderViewBase_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000FD1 RID: 4049 RVA: 0x0001CB8C File Offset: 0x0001AD8C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000FD2 RID: 4050
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderViewBase_GetInteractor_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The render window interactor. Note that this requires special
		/// handling in order to do correctly - see the notes in the detailed
		/// description of vtkRenderViewBase.
		/// </summary>
		// Token: 0x06000FD3 RID: 4051 RVA: 0x0001CB98 File Offset: 0x0001AD98
		public virtual vtkRenderWindowInteractor GetInteractor()
		{
			vtkRenderWindowInteractor vtkRenderWindowInteractor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderViewBase.vtkRenderViewBase_GetInteractor_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindowInteractor = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindowInteractor.Register(null);
				}
			}
			return vtkRenderWindowInteractor;
		}

		// Token: 0x06000FD4 RID: 4052
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderViewBase_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FD5 RID: 4053 RVA: 0x0001CC08 File Offset: 0x0001AE08
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderViewBase.vtkRenderViewBase_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06000FD6 RID: 4054
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderViewBase_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FD7 RID: 4055 RVA: 0x0001CC28 File Offset: 0x0001AE28
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderViewBase.vtkRenderViewBase_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06000FD8 RID: 4056
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderViewBase_GetRenderWindow_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a handle to the render window.
		/// </summary>
		// Token: 0x06000FD9 RID: 4057 RVA: 0x0001CC44 File Offset: 0x0001AE44
		public virtual vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderViewBase.vtkRenderViewBase_GetRenderWindow_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		// Token: 0x06000FDA RID: 4058
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderViewBase_GetRenderer_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Gets the renderer for this view.
		/// </summary>
		// Token: 0x06000FDB RID: 4059 RVA: 0x0001CCB4 File Offset: 0x0001AEB4
		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderViewBase.vtkRenderViewBase_GetRenderer_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x06000FDC RID: 4060
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderViewBase_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FDD RID: 4061 RVA: 0x0001CD24 File Offset: 0x0001AF24
		public override int IsA(string type)
		{
			return vtkRenderViewBase.vtkRenderViewBase_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06000FDE RID: 4062
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderViewBase_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FDF RID: 4063 RVA: 0x0001CD44 File Offset: 0x0001AF44
		public new static int IsTypeOf(string type)
		{
			return vtkRenderViewBase.vtkRenderViewBase_IsTypeOf_07(type);
		}

		// Token: 0x06000FE0 RID: 4064
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderViewBase_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FE1 RID: 4065 RVA: 0x0001CD60 File Offset: 0x0001AF60
		public new vtkRenderViewBase NewInstance()
		{
			vtkRenderViewBase result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderViewBase.vtkRenderViewBase_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderViewBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000FE2 RID: 4066
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderViewBase_Render_10(HandleRef pThis);

		/// <summary>
		/// Updates the representations, then calls Render() on the render window
		/// associated with this view.
		/// </summary>
		// Token: 0x06000FE3 RID: 4067 RVA: 0x0001CDBA File Offset: 0x0001AFBA
		public virtual void Render()
		{
			vtkRenderViewBase.vtkRenderViewBase_Render_10(base.GetCppThis());
		}

		// Token: 0x06000FE4 RID: 4068
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderViewBase_ResetCamera_11(HandleRef pThis);

		/// <summary>
		/// Updates the representations, then calls ResetCamera() on the renderer
		/// associated with this view.
		/// </summary>
		// Token: 0x06000FE5 RID: 4069 RVA: 0x0001CDC9 File Offset: 0x0001AFC9
		public virtual void ResetCamera()
		{
			vtkRenderViewBase.vtkRenderViewBase_ResetCamera_11(base.GetCppThis());
		}

		// Token: 0x06000FE6 RID: 4070
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderViewBase_ResetCameraClippingRange_12(HandleRef pThis);

		/// <summary>
		/// Updates the representations, then calls ResetCameraClippingRange() on the
		/// renderer associated with this view.
		/// </summary>
		// Token: 0x06000FE7 RID: 4071 RVA: 0x0001CDD8 File Offset: 0x0001AFD8
		public virtual void ResetCameraClippingRange()
		{
			vtkRenderViewBase.vtkRenderViewBase_ResetCameraClippingRange_12(base.GetCppThis());
		}

		// Token: 0x06000FE8 RID: 4072
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderViewBase_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000FE9 RID: 4073 RVA: 0x0001CDE8 File Offset: 0x0001AFE8
		public new static vtkRenderViewBase SafeDownCast(vtkObjectBase o)
		{
			vtkRenderViewBase vtkRenderViewBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderViewBase.vtkRenderViewBase_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderViewBase = (vtkRenderViewBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderViewBase.Register(null);
				}
			}
			return vtkRenderViewBase;
		}

		// Token: 0x06000FEA RID: 4074
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderViewBase_SetInteractor_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// The render window interactor. Note that this requires special
		/// handling in order to do correctly - see the notes in the detailed
		/// description of vtkRenderViewBase.
		/// </summary>
		// Token: 0x06000FEB RID: 4075 RVA: 0x0001CE68 File Offset: 0x0001B068
		public virtual void SetInteractor(vtkRenderWindowInteractor arg0)
		{
			vtkRenderViewBase.vtkRenderViewBase_SetInteractor_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000FEC RID: 4076
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderViewBase_SetRenderWindow_15(HandleRef pThis, HandleRef win);

		/// <summary>
		/// Set the render window for this view. Note that this requires special
		/// handling in order to do correctly - see the notes in the detailed
		/// description of vtkRenderViewBase.
		/// </summary>
		// Token: 0x06000FED RID: 4077 RVA: 0x0001CE98 File Offset: 0x0001B098
		public virtual void SetRenderWindow(vtkRenderWindow win)
		{
			vtkRenderViewBase.vtkRenderViewBase_SetRenderWindow_15(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x06000FEE RID: 4078
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderViewBase_SetRenderer_16(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Gets the renderer for this view.
		/// </summary>
		// Token: 0x06000FEF RID: 4079 RVA: 0x0001CEC8 File Offset: 0x0001B0C8
		public virtual void SetRenderer(vtkRenderer ren)
		{
			vtkRenderViewBase.vtkRenderViewBase_SetRenderer_16(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000430 RID: 1072
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderViewBase";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000431 RID: 1073
		public new static readonly string MRClassNameKey = "class vtkRenderViewBase";
	}
}
