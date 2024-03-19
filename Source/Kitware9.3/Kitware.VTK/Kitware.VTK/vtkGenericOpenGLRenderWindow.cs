using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericOpenGLRenderWindow
	/// </summary>
	/// <remarks>
	///    platform independent render window
	///
	///
	/// vtkGenericOpenGLRenderWindow provides a skeleton for implementing a render window
	/// using one's own OpenGL context and drawable.
	/// To be effective, one must register an observer for WindowMakeCurrentEvent,
	/// WindowIsCurrentEvent and WindowFrameEvent.  When this class sends a WindowIsCurrentEvent,
	/// the call data is an bool* which one can use to return whether the context is current.
	/// </remarks>
	// Token: 0x0200011B RID: 283
	public class vtkGenericOpenGLRenderWindow : vtkOpenGLRenderWindow
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060039C9 RID: 14793 RVA: 0x0005441F File Offset: 0x0005261F
		static vtkGenericOpenGLRenderWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericOpenGLRenderWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericOpenGLRenderWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060039CA RID: 14794 RVA: 0x00054447 File Offset: 0x00052647
		public vtkGenericOpenGLRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060039CB RID: 14795
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039CC RID: 14796 RVA: 0x00054458 File Offset: 0x00052658
		public new static vtkGenericOpenGLRenderWindow New()
		{
			vtkGenericOpenGLRenderWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039CD RID: 14797 RVA: 0x000544AC File Offset: 0x000526AC
		public vtkGenericOpenGLRenderWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060039CE RID: 14798 RVA: 0x000544F0 File Offset: 0x000526F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060039CF RID: 14799
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_CreateAWindow_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039D0 RID: 14800 RVA: 0x000544FB File Offset: 0x000526FB
		public virtual void CreateAWindow()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_CreateAWindow_01(base.GetCppThis());
		}

		// Token: 0x060039D1 RID: 14801
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_DestroyWindow_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039D2 RID: 14802 RVA: 0x0005450A File Offset: 0x0005270A
		public virtual void DestroyWindow()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_DestroyWindow_02(base.GetCppThis());
		}

		// Token: 0x060039D3 RID: 14803
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_Finalize_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039D4 RID: 14804 RVA: 0x00054519 File Offset: 0x00052719
		public override void FinalizeWrapper()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_Finalize_03(base.GetCppThis());
		}

		// Token: 0x060039D5 RID: 14805
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_Frame_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039D6 RID: 14806 RVA: 0x00054528 File Offset: 0x00052728
		public override void Frame()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_Frame_04(base.GetCppThis());
		}

		// Token: 0x060039D7 RID: 14807
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericOpenGLRenderWindow_GetEventPending_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039D8 RID: 14808 RVA: 0x00054538 File Offset: 0x00052738
		public override int GetEventPending()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetEventPending_05(base.GetCppThis());
		}

		// Token: 0x060039D9 RID: 14809
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGenericOpenGLRenderWindow_GetForceMaximumHardwareLineWidth_06(HandleRef pThis);

		/// <summary>
		/// Specify a non-zero line width to force the hardware line width determined
		/// by the window.
		/// </summary>
		// Token: 0x060039DA RID: 14810 RVA: 0x00054558 File Offset: 0x00052758
		public virtual float GetForceMaximumHardwareLineWidth()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetForceMaximumHardwareLineWidth_06(base.GetCppThis());
		}

		// Token: 0x060039DB RID: 14811
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGenericOpenGLRenderWindow_GetForceMaximumHardwareLineWidthMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Specify a non-zero line width to force the hardware line width determined
		/// by the window.
		/// </summary>
		// Token: 0x060039DC RID: 14812 RVA: 0x00054578 File Offset: 0x00052778
		public virtual float GetForceMaximumHardwareLineWidthMaxValue()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetForceMaximumHardwareLineWidthMaxValue_07(base.GetCppThis());
		}

		// Token: 0x060039DD RID: 14813
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGenericOpenGLRenderWindow_GetForceMaximumHardwareLineWidthMinValue_08(HandleRef pThis);

		/// <summary>
		/// Specify a non-zero line width to force the hardware line width determined
		/// by the window.
		/// </summary>
		// Token: 0x060039DE RID: 14814 RVA: 0x00054598 File Offset: 0x00052798
		public virtual float GetForceMaximumHardwareLineWidthMinValue()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetForceMaximumHardwareLineWidthMinValue_08(base.GetCppThis());
		}

		// Token: 0x060039DF RID: 14815
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetGenericContext_09(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039E0 RID: 14816 RVA: 0x000545B8 File Offset: 0x000527B8
		public override IntPtr GetGenericContext()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetGenericContext_09(base.GetCppThis());
		}

		// Token: 0x060039E1 RID: 14817
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetGenericDisplayId_10(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039E2 RID: 14818 RVA: 0x000545D8 File Offset: 0x000527D8
		public override IntPtr GetGenericDisplayId()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetGenericDisplayId_10(base.GetCppThis());
		}

		// Token: 0x060039E3 RID: 14819
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetGenericDrawable_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039E4 RID: 14820 RVA: 0x000545F8 File Offset: 0x000527F8
		public override IntPtr GetGenericDrawable()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetGenericDrawable_11(base.GetCppThis());
		}

		// Token: 0x060039E5 RID: 14821
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetGenericParentId_12(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039E6 RID: 14822 RVA: 0x00054618 File Offset: 0x00052818
		public override IntPtr GetGenericParentId()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetGenericParentId_12(base.GetCppThis());
		}

		// Token: 0x060039E7 RID: 14823
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetGenericWindowId_13(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039E8 RID: 14824 RVA: 0x00054638 File Offset: 0x00052838
		public override IntPtr GetGenericWindowId()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetGenericWindowId_13(base.GetCppThis());
		}

		// Token: 0x060039E9 RID: 14825
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGenericOpenGLRenderWindow_GetMaximumHardwareLineWidth_14(HandleRef pThis);

		/// <summary>
		/// Overridden to pass explicitly specified MaximumHardwareLineWidth, if any.
		/// </summary>
		// Token: 0x060039EA RID: 14826 RVA: 0x00054658 File Offset: 0x00052858
		public override float GetMaximumHardwareLineWidth()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetMaximumHardwareLineWidth_14(base.GetCppThis());
		}

		// Token: 0x060039EB RID: 14827
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericOpenGLRenderWindow_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039EC RID: 14828 RVA: 0x00054678 File Offset: 0x00052878
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x060039ED RID: 14829
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericOpenGLRenderWindow_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039EE RID: 14830 RVA: 0x00054698 File Offset: 0x00052898
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x060039EF RID: 14831
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGenericOpenGLRenderWindow_GetReadyForRendering_17(HandleRef pThis);

		/// <summary>
		/// Set this to true to indicate that the context is now ready. For backwards
		/// compatibility reasons, it's set to true by default. If set to false, the
		/// `Render` call will be skipped entirely.
		/// </summary>
		// Token: 0x060039F0 RID: 14832 RVA: 0x000546B4 File Offset: 0x000528B4
		public virtual bool GetReadyForRendering()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetReadyForRendering_17(base.GetCppThis()) != 0;
		}

		// Token: 0x060039F1 RID: 14833
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_GetScreenSize_18(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039F2 RID: 14834 RVA: 0x000546DC File Offset: 0x000528DC
		public override int[] GetScreenSize()
		{
			IntPtr intPtr = vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_GetScreenSize_18(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060039F3 RID: 14835
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_HideCursor_19(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039F4 RID: 14836 RVA: 0x00054724 File Offset: 0x00052924
		public override void HideCursor()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_HideCursor_19(base.GetCppThis());
		}

		// Token: 0x060039F5 RID: 14837
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericOpenGLRenderWindow_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039F6 RID: 14838 RVA: 0x00054734 File Offset: 0x00052934
		public override int IsA(string type)
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x060039F7 RID: 14839
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGenericOpenGLRenderWindow_IsCurrent_21(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039F8 RID: 14840 RVA: 0x00054754 File Offset: 0x00052954
		public override bool IsCurrent()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_IsCurrent_21(base.GetCppThis()) != 0;
		}

		// Token: 0x060039F9 RID: 14841
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericOpenGLRenderWindow_IsDirect_22(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039FA RID: 14842 RVA: 0x0005477C File Offset: 0x0005297C
		public override int IsDirect()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_IsDirect_22(base.GetCppThis());
		}

		// Token: 0x060039FB RID: 14843
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericOpenGLRenderWindow_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039FC RID: 14844 RVA: 0x0005479C File Offset: 0x0005299C
		public new static int IsTypeOf(string type)
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_IsTypeOf_23(type);
		}

		// Token: 0x060039FD RID: 14845
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_MakeCurrent_24(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060039FE RID: 14846 RVA: 0x000547B6 File Offset: 0x000529B6
		public override void MakeCurrent()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_MakeCurrent_24(base.GetCppThis());
		}

		// Token: 0x060039FF RID: 14847
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A00 RID: 14848 RVA: 0x000547C8 File Offset: 0x000529C8
		public new vtkGenericOpenGLRenderWindow NewInstance()
		{
			vtkGenericOpenGLRenderWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003A01 RID: 14849
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_OpenGLInit_27(HandleRef pThis);

		/// <summary>
		/// Initialize OpenGL for this window.
		/// </summary>
		// Token: 0x06003A02 RID: 14850 RVA: 0x00054822 File Offset: 0x00052A22
		public override void OpenGLInit()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_OpenGLInit_27(base.GetCppThis());
		}

		// Token: 0x06003A03 RID: 14851
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_PopState_28(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A04 RID: 14852 RVA: 0x00054831 File Offset: 0x00052A31
		public void PopState()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_PopState_28(base.GetCppThis());
		}

		// Token: 0x06003A05 RID: 14853
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_PushState_29(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A06 RID: 14854 RVA: 0x00054840 File Offset: 0x00052A40
		public void PushState()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_PushState_29(base.GetCppThis());
		}

		// Token: 0x06003A07 RID: 14855
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_Render_30(HandleRef pThis);

		/// <summary>
		/// Override the Render method to do some state management.
		/// This method saves the OpenGL state before asking its child renderers to
		/// render their image. Once this is done, the OpenGL state is restored.
		/// \sa vtkOpenGLRenderWindow::SaveGLState()
		/// \sa vtkOpenGLRenderWindow::RestoreGLState()
		/// </summary>
		// Token: 0x06003A08 RID: 14856 RVA: 0x0005484F File Offset: 0x00052A4F
		public override void Render()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_Render_30(base.GetCppThis());
		}

		// Token: 0x06003A09 RID: 14857
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericOpenGLRenderWindow_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A0A RID: 14858 RVA: 0x00054860 File Offset: 0x00052A60
		public new static vtkGenericOpenGLRenderWindow SafeDownCast(vtkObjectBase o)
		{
			vtkGenericOpenGLRenderWindow vtkGenericOpenGLRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericOpenGLRenderWindow = (vtkGenericOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericOpenGLRenderWindow.Register(null);
				}
			}
			return vtkGenericOpenGLRenderWindow;
		}

		// Token: 0x06003A0B RID: 14859
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetBackLeftBuffer_32(HandleRef pThis, uint arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A0C RID: 14860 RVA: 0x000548DF File Offset: 0x00052ADF
		public void SetBackLeftBuffer(uint arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetBackLeftBuffer_32(base.GetCppThis(), arg0);
		}

		// Token: 0x06003A0D RID: 14861
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetBackRightBuffer_33(HandleRef pThis, uint arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A0E RID: 14862 RVA: 0x000548EF File Offset: 0x00052AEF
		public void SetBackRightBuffer(uint arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetBackRightBuffer_33(base.GetCppThis(), arg0);
		}

		// Token: 0x06003A0F RID: 14863
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetCurrentCursor_34(HandleRef pThis, int cShape);

		/// <summary>
		/// Overridden to invoke vtkCommand::CursorChangedEvent
		/// </summary>
		// Token: 0x06003A10 RID: 14864 RVA: 0x000548FF File Offset: 0x00052AFF
		public override void SetCurrentCursor(int cShape)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetCurrentCursor_34(base.GetCppThis(), cShape);
		}

		// Token: 0x06003A11 RID: 14865
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetDisplayId_35(HandleRef pThis, IntPtr arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A12 RID: 14866 RVA: 0x0005490F File Offset: 0x00052B0F
		public override void SetDisplayId(IntPtr arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetDisplayId_35(base.GetCppThis(), arg0);
		}

		// Token: 0x06003A13 RID: 14867
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetForceMaximumHardwareLineWidth_36(HandleRef pThis, float _arg);

		/// <summary>
		/// Specify a non-zero line width to force the hardware line width determined
		/// by the window.
		/// </summary>
		// Token: 0x06003A14 RID: 14868 RVA: 0x0005491F File Offset: 0x00052B1F
		public virtual void SetForceMaximumHardwareLineWidth(float _arg)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetForceMaximumHardwareLineWidth_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06003A15 RID: 14869
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetFrontLeftBuffer_37(HandleRef pThis, uint arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A16 RID: 14870 RVA: 0x0005492F File Offset: 0x00052B2F
		public void SetFrontLeftBuffer(uint arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetFrontLeftBuffer_37(base.GetCppThis(), arg0);
		}

		// Token: 0x06003A17 RID: 14871
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetFrontRightBuffer_38(HandleRef pThis, uint arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A18 RID: 14872 RVA: 0x0005493F File Offset: 0x00052B3F
		public void SetFrontRightBuffer(uint arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetFrontRightBuffer_38(base.GetCppThis(), arg0);
		}

		// Token: 0x06003A19 RID: 14873
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetFullScreen_39(HandleRef pThis, int arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A1A RID: 14874 RVA: 0x0005494F File Offset: 0x00052B4F
		public override void SetFullScreen(int arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetFullScreen_39(base.GetCppThis(), arg0);
		}

		// Token: 0x06003A1B RID: 14875
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetIsCurrent_40(HandleRef pThis, byte newValue);

		/// <summary>
		/// Allow to update state within observer callback without changing
		/// data argument and MTime.
		/// </summary>
		// Token: 0x06003A1C RID: 14876 RVA: 0x0005495F File Offset: 0x00052B5F
		public void SetIsCurrent(bool newValue)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetIsCurrent_40(base.GetCppThis(), newValue ? (byte)1 : (byte)0);
		}

		// Token: 0x06003A1D RID: 14877
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetIsDirect_41(HandleRef pThis, int newValue);

		/// <summary>
		/// Allow to update state within observer callback without changing
		/// data argument and MTime.
		/// </summary>
		// Token: 0x06003A1E RID: 14878 RVA: 0x00054977 File Offset: 0x00052B77
		public void SetIsDirect(int newValue)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetIsDirect_41(base.GetCppThis(), newValue);
		}

		// Token: 0x06003A1F RID: 14879
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetMapped_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Overridden to invoke vtkCommand::CursorChangedEvent
		/// </summary>
		// Token: 0x06003A20 RID: 14880 RVA: 0x00054987 File Offset: 0x00052B87
		public virtual void SetMapped(int _arg)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetMapped_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06003A21 RID: 14881
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetNextWindowId_43(HandleRef pThis, IntPtr arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A22 RID: 14882 RVA: 0x00054997 File Offset: 0x00052B97
		public override void SetNextWindowId(IntPtr arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetNextWindowId_43(base.GetCppThis(), arg0);
		}

		// Token: 0x06003A23 RID: 14883
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetNextWindowInfo_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A24 RID: 14884 RVA: 0x000549A7 File Offset: 0x00052BA7
		public override void SetNextWindowInfo(string arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetNextWindowInfo_44(base.GetCppThis(), arg0);
		}

		// Token: 0x06003A25 RID: 14885
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetOwnContext_45(HandleRef pThis, int arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A26 RID: 14886 RVA: 0x000549B7 File Offset: 0x00052BB7
		public void SetOwnContext(int arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetOwnContext_45(base.GetCppThis(), arg0);
		}

		// Token: 0x06003A27 RID: 14887
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetParentId_46(HandleRef pThis, IntPtr arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A28 RID: 14888 RVA: 0x000549C7 File Offset: 0x00052BC7
		public override void SetParentId(IntPtr arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetParentId_46(base.GetCppThis(), arg0);
		}

		// Token: 0x06003A29 RID: 14889
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetParentInfo_47(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A2A RID: 14890 RVA: 0x000549D7 File Offset: 0x00052BD7
		public override void SetParentInfo(string arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetParentInfo_47(base.GetCppThis(), arg0);
		}

		// Token: 0x06003A2B RID: 14891
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetReadyForRendering_48(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set this to true to indicate that the context is now ready. For backwards
		/// compatibility reasons, it's set to true by default. If set to false, the
		/// `Render` call will be skipped entirely.
		/// </summary>
		// Token: 0x06003A2C RID: 14892 RVA: 0x000549E7 File Offset: 0x00052BE7
		public virtual void SetReadyForRendering(bool _arg)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetReadyForRendering_48(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06003A2D RID: 14893
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetScreenSize_49(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set the size of the screen in pixels.
		/// An HDTV for example would be 1920 x 1080 pixels.
		/// </summary>
		// Token: 0x06003A2E RID: 14894 RVA: 0x000549FF File Offset: 0x00052BFF
		public virtual void SetScreenSize(int _arg1, int _arg2)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetScreenSize_49(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06003A2F RID: 14895
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetScreenSize_50(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the size of the screen in pixels.
		/// An HDTV for example would be 1920 x 1080 pixels.
		/// </summary>
		// Token: 0x06003A30 RID: 14896 RVA: 0x00054A10 File Offset: 0x00052C10
		public void SetScreenSize(IntPtr _arg)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetScreenSize_50(base.GetCppThis(), _arg);
		}

		// Token: 0x06003A31 RID: 14897
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetSupportsOpenGL_51(HandleRef pThis, int newValue);

		/// <summary>
		/// Allow to update state within observer callback without changing
		/// data argument and MTime.
		/// </summary>
		// Token: 0x06003A32 RID: 14898 RVA: 0x00054A20 File Offset: 0x00052C20
		public void SetSupportsOpenGL(int newValue)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetSupportsOpenGL_51(base.GetCppThis(), newValue);
		}

		// Token: 0x06003A33 RID: 14899
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetWindowId_52(HandleRef pThis, IntPtr arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A34 RID: 14900 RVA: 0x00054A30 File Offset: 0x00052C30
		public override void SetWindowId(IntPtr arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetWindowId_52(base.GetCppThis(), arg0);
		}

		// Token: 0x06003A35 RID: 14901
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_SetWindowInfo_53(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A36 RID: 14902 RVA: 0x00054A40 File Offset: 0x00052C40
		public override void SetWindowInfo(string arg0)
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SetWindowInfo_53(base.GetCppThis(), arg0);
		}

		// Token: 0x06003A37 RID: 14903
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_ShowCursor_54(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A38 RID: 14904 RVA: 0x00054A50 File Offset: 0x00052C50
		public override void ShowCursor()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_ShowCursor_54(base.GetCppThis());
		}

		// Token: 0x06003A39 RID: 14905
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericOpenGLRenderWindow_SupportsOpenGL_55(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A3A RID: 14906 RVA: 0x00054A60 File Offset: 0x00052C60
		public override int SupportsOpenGL()
		{
			return vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_SupportsOpenGL_55(base.GetCppThis());
		}

		// Token: 0x06003A3B RID: 14907
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericOpenGLRenderWindow_WindowRemap_56(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003A3C RID: 14908 RVA: 0x00054A7F File Offset: 0x00052C7F
		public override void WindowRemap()
		{
			vtkGenericOpenGLRenderWindow.vtkGenericOpenGLRenderWindow_WindowRemap_56(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400066F RID: 1647
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericOpenGLRenderWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000670 RID: 1648
		public new static readonly string MRClassNameKey = "class vtkGenericOpenGLRenderWindow";
	}
}
