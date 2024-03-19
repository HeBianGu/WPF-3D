using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderView
	/// </summary>
	/// <remarks>
	///    A view containing a renderer.
	///
	///
	/// vtkRenderView is a view which contains a vtkRenderer.  You may add vtkActors
	/// directly to the renderer, or add certain vtkDataRepresentation subclasses
	/// to the renderer.  The render view supports drag selection with the mouse to
	/// select cells.
	///
	/// This class is also the parent class for any more specialized view which uses
	/// a renderer.
	/// </remarks>
	// Token: 0x02000065 RID: 101
	public class vtkRenderView : vtkRenderViewBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001234 RID: 4660 RVA: 0x00020471 File Offset: 0x0001E671
		static vtkRenderView()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderView"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001235 RID: 4661 RVA: 0x00020499 File Offset: 0x0001E699
		public vtkRenderView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001236 RID: 4662
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001237 RID: 4663 RVA: 0x000204A8 File Offset: 0x0001E6A8
		public new static vtkRenderView New()
		{
			vtkRenderView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderView.vtkRenderView_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001238 RID: 4664 RVA: 0x000204FC File Offset: 0x0001E6FC
		public vtkRenderView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRenderView.vtkRenderView_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001239 RID: 4665 RVA: 0x00020540 File Offset: 0x0001E740
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600123A RID: 4666
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_AddLabels_01(HandleRef pThis, HandleRef conn);

		/// <summary>
		/// Add labels from an input connection with an associated text
		/// property. The output must be a vtkLabelHierarchy (normally the
		/// output of vtkPointSetToLabelHierarchy).
		/// </summary>
		// Token: 0x0600123B RID: 4667 RVA: 0x0002054C File Offset: 0x0001E74C
		public virtual void AddLabels(vtkAlgorithmOutput conn)
		{
			vtkRenderView.vtkRenderView_AddLabels_01(base.GetCppThis(), (conn == null) ? default(HandleRef) : conn.GetCppThis());
		}

		// Token: 0x0600123C RID: 4668
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_ApplyViewTheme_02(HandleRef pThis, HandleRef theme);

		/// <summary>
		/// Applies a view theme to this view.
		/// </summary>
		// Token: 0x0600123D RID: 4669 RVA: 0x0002057C File Offset: 0x0001E77C
		public override void ApplyViewTheme(vtkViewTheme theme)
		{
			vtkRenderView.vtkRenderView_ApplyViewTheme_02(base.GetCppThis(), (theme == null) ? default(HandleRef) : theme.GetCppThis());
		}

		// Token: 0x0600123E RID: 4670
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_DisplayHoverTextOff_03(HandleRef pThis);

		/// <summary>
		/// Whether the view should display hover text.
		/// </summary>
		// Token: 0x0600123F RID: 4671 RVA: 0x000205AB File Offset: 0x0001E7AB
		public virtual void DisplayHoverTextOff()
		{
			vtkRenderView.vtkRenderView_DisplayHoverTextOff_03(base.GetCppThis());
		}

		// Token: 0x06001240 RID: 4672
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_DisplayHoverTextOn_04(HandleRef pThis);

		/// <summary>
		/// Whether the view should display hover text.
		/// </summary>
		// Token: 0x06001241 RID: 4673 RVA: 0x000205BA File Offset: 0x0001E7BA
		public virtual void DisplayHoverTextOn()
		{
			vtkRenderView.vtkRenderView_DisplayHoverTextOn_04(base.GetCppThis());
		}

		// Token: 0x06001242 RID: 4674
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderView_GetDisplayHoverText_05(HandleRef pThis);

		/// <summary>
		/// Whether the view should display hover text.
		/// </summary>
		// Token: 0x06001243 RID: 4675 RVA: 0x000205CC File Offset: 0x0001E7CC
		public virtual bool GetDisplayHoverText()
		{
			return vtkRenderView.vtkRenderView_GetDisplayHoverText_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06001244 RID: 4676
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderView_GetDisplaySize_06(HandleRef pThis);

		/// <summary>
		/// Set the display size of the icon (which may be different from the icon
		/// size). By default, if this value is not set, the IconSize is used.
		/// </summary>
		// Token: 0x06001245 RID: 4677 RVA: 0x000205F4 File Offset: 0x0001E7F4
		public IntPtr GetDisplaySize()
		{
			return vtkRenderView.vtkRenderView_GetDisplaySize_06(base.GetCppThis());
		}

		// Token: 0x06001246 RID: 4678
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_GetDisplaySize_07(HandleRef pThis, ref int dsx, ref int dsy);

		/// <summary>
		/// Set the display size of the icon (which may be different from the icon
		/// size). By default, if this value is not set, the IconSize is used.
		/// </summary>
		// Token: 0x06001247 RID: 4679 RVA: 0x00020613 File Offset: 0x0001E813
		public void GetDisplaySize(ref int dsx, ref int dsy)
		{
			vtkRenderView.vtkRenderView_GetDisplaySize_07(base.GetCppThis(), ref dsx, ref dsy);
		}

		// Token: 0x06001248 RID: 4680
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderView_GetIconSize_08(HandleRef pThis);

		/// <summary>
		/// Set the size of each icon in the icon texture.
		/// </summary>
		// Token: 0x06001249 RID: 4681 RVA: 0x00020624 File Offset: 0x0001E824
		public virtual int[] GetIconSize()
		{
			IntPtr intPtr = vtkRenderView.vtkRenderView_GetIconSize_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600124A RID: 4682
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_GetIconSize_09(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Set the size of each icon in the icon texture.
		/// </summary>
		// Token: 0x0600124B RID: 4683 RVA: 0x0002066C File Offset: 0x0001E86C
		public virtual void GetIconSize(ref int _arg1, ref int _arg2)
		{
			vtkRenderView.vtkRenderView_GetIconSize_09(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600124C RID: 4684
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_GetIconSize_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the size of each icon in the icon texture.
		/// </summary>
		// Token: 0x0600124D RID: 4685 RVA: 0x0002067D File Offset: 0x0001E87D
		public virtual void GetIconSize(IntPtr _arg)
		{
			vtkRenderView.vtkRenderView_GetIconSize_10(base.GetCppThis(), _arg);
		}

		// Token: 0x0600124E RID: 4686
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderView_GetIconTexture_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the icon sheet to use for rendering icons.
		/// </summary>
		// Token: 0x0600124F RID: 4687 RVA: 0x00020690 File Offset: 0x0001E890
		public virtual vtkTexture GetIconTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderView.vtkRenderView_GetIconTexture_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		// Token: 0x06001250 RID: 4688
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderView_GetInteractionMode_12(HandleRef pThis);

		/// <summary>
		/// Set the render window for this view. Note that this requires special
		/// handling in order to do correctly - see the notes in the detailed
		/// description of vtkRenderViewBase.
		/// </summary>
		// Token: 0x06001251 RID: 4689 RVA: 0x00020700 File Offset: 0x0001E900
		public virtual int GetInteractionMode()
		{
			return vtkRenderView.vtkRenderView_GetInteractionMode_12(base.GetCppThis());
		}

		// Token: 0x06001252 RID: 4690
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderView_GetInteractorStyle_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the interactor style associated with the render view.
		/// </summary>
		// Token: 0x06001253 RID: 4691 RVA: 0x00020720 File Offset: 0x0001E920
		public virtual vtkInteractorObserver GetInteractorStyle()
		{
			vtkInteractorObserver vtkInteractorObserver = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderView.vtkRenderView_GetInteractorStyle_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorObserver = (vtkInteractorObserver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorObserver.Register(null);
				}
			}
			return vtkInteractorObserver;
		}

		// Token: 0x06001254 RID: 4692
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderView_GetLabelPlacementMode_14(HandleRef pThis);

		/// <summary>
		/// Label placement mode.
		/// NO_OVERLAP uses vtkLabelPlacementMapper, which has a faster startup time and
		/// works with 2D or 3D labels.
		/// ALL displays all labels (Warning: This may cause incredibly slow render
		/// times on datasets with more than a few hundred labels).
		/// </summary>
		// Token: 0x06001255 RID: 4693 RVA: 0x00020790 File Offset: 0x0001E990
		public virtual int GetLabelPlacementMode()
		{
			return vtkRenderView.vtkRenderView_GetLabelPlacementMode_14(base.GetCppThis());
		}

		// Token: 0x06001256 RID: 4694
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderView_GetLabelRenderMode_15(HandleRef pThis);

		/// <summary>
		/// Label render mode.
		/// FREETYPE uses the freetype label rendering.
		/// QT uses more advanced Qt-based label rendering.
		/// </summary>
		// Token: 0x06001257 RID: 4695 RVA: 0x000207B0 File Offset: 0x0001E9B0
		public virtual int GetLabelRenderMode()
		{
			return vtkRenderView.vtkRenderView_GetLabelRenderMode_15(base.GetCppThis());
		}

		// Token: 0x06001258 RID: 4696
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderView_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001259 RID: 4697 RVA: 0x000207D0 File Offset: 0x0001E9D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderView.vtkRenderView_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0600125A RID: 4698
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderView_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600125B RID: 4699 RVA: 0x000207F0 File Offset: 0x0001E9F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderView.vtkRenderView_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0600125C RID: 4700
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderView_GetRenderOnMouseMove_18(HandleRef pThis);

		/// <summary>
		/// Whether to render on every mouse move.
		/// </summary>
		// Token: 0x0600125D RID: 4701 RVA: 0x0002080C File Offset: 0x0001EA0C
		public virtual bool GetRenderOnMouseMove()
		{
			return vtkRenderView.vtkRenderView_GetRenderOnMouseMove_18(base.GetCppThis()) != 0;
		}

		// Token: 0x0600125E RID: 4702
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderView_GetSelectionMode_19(HandleRef pThis);

		/// <summary>
		/// Sets the selection mode for the render view.
		/// SURFACE selection uses vtkHardwareSelector to perform a selection
		/// of visible cells.
		/// FRUSTUM selection just creates a view frustum selection, which will
		/// select everything in the frustum.
		/// </summary>
		// Token: 0x0600125F RID: 4703 RVA: 0x00020834 File Offset: 0x0001EA34
		public virtual int GetSelectionMode()
		{
			return vtkRenderView.vtkRenderView_GetSelectionMode_19(base.GetCppThis());
		}

		// Token: 0x06001260 RID: 4704
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderView_GetSelectionModeMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Sets the selection mode for the render view.
		/// SURFACE selection uses vtkHardwareSelector to perform a selection
		/// of visible cells.
		/// FRUSTUM selection just creates a view frustum selection, which will
		/// select everything in the frustum.
		/// </summary>
		// Token: 0x06001261 RID: 4705 RVA: 0x00020854 File Offset: 0x0001EA54
		public virtual int GetSelectionModeMaxValue()
		{
			return vtkRenderView.vtkRenderView_GetSelectionModeMaxValue_20(base.GetCppThis());
		}

		// Token: 0x06001262 RID: 4706
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderView_GetSelectionModeMinValue_21(HandleRef pThis);

		/// <summary>
		/// Sets the selection mode for the render view.
		/// SURFACE selection uses vtkHardwareSelector to perform a selection
		/// of visible cells.
		/// FRUSTUM selection just creates a view frustum selection, which will
		/// select everything in the frustum.
		/// </summary>
		// Token: 0x06001263 RID: 4707 RVA: 0x00020874 File Offset: 0x0001EA74
		public virtual int GetSelectionModeMinValue()
		{
			return vtkRenderView.vtkRenderView_GetSelectionModeMinValue_21(base.GetCppThis());
		}

		// Token: 0x06001264 RID: 4708
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderView_GetTransform_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the view's transform. All vtkRenderedRepresentations
		/// added to this view should use this transform.
		/// </summary>
		// Token: 0x06001265 RID: 4709 RVA: 0x00020894 File Offset: 0x0001EA94
		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderView.vtkRenderView_GetTransform_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		// Token: 0x06001266 RID: 4710
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderView_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001267 RID: 4711 RVA: 0x00020904 File Offset: 0x0001EB04
		public override int IsA(string type)
		{
			return vtkRenderView.vtkRenderView_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x06001268 RID: 4712
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderView_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001269 RID: 4713 RVA: 0x00020924 File Offset: 0x0001EB24
		public new static int IsTypeOf(string type)
		{
			return vtkRenderView.vtkRenderView_IsTypeOf_24(type);
		}

		// Token: 0x0600126A RID: 4714
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderView_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600126B RID: 4715 RVA: 0x00020940 File Offset: 0x0001EB40
		public new vtkRenderView NewInstance()
		{
			vtkRenderView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderView.vtkRenderView_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600126C RID: 4716
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_RemoveLabels_27(HandleRef pThis, HandleRef conn);

		/// <summary>
		/// Remove labels from an input connection.
		/// </summary>
		// Token: 0x0600126D RID: 4717 RVA: 0x0002099C File Offset: 0x0001EB9C
		public virtual void RemoveLabels(vtkAlgorithmOutput conn)
		{
			vtkRenderView.vtkRenderView_RemoveLabels_27(base.GetCppThis(), (conn == null) ? default(HandleRef) : conn.GetCppThis());
		}

		// Token: 0x0600126E RID: 4718
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_Render_28(HandleRef pThis);

		/// <summary>
		/// Updates the representations, then calls Render() on the render window
		/// associated with this view.
		/// </summary>
		// Token: 0x0600126F RID: 4719 RVA: 0x000209CB File Offset: 0x0001EBCB
		public override void Render()
		{
			vtkRenderView.vtkRenderView_Render_28(base.GetCppThis());
		}

		// Token: 0x06001270 RID: 4720
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_RenderOnMouseMoveOff_29(HandleRef pThis);

		/// <summary>
		/// Whether to render on every mouse move.
		/// </summary>
		// Token: 0x06001271 RID: 4721 RVA: 0x000209DA File Offset: 0x0001EBDA
		public virtual void RenderOnMouseMoveOff()
		{
			vtkRenderView.vtkRenderView_RenderOnMouseMoveOff_29(base.GetCppThis());
		}

		// Token: 0x06001272 RID: 4722
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_RenderOnMouseMoveOn_30(HandleRef pThis);

		/// <summary>
		/// Whether to render on every mouse move.
		/// </summary>
		// Token: 0x06001273 RID: 4723 RVA: 0x000209E9 File Offset: 0x0001EBE9
		public virtual void RenderOnMouseMoveOn()
		{
			vtkRenderView.vtkRenderView_RenderOnMouseMoveOn_30(base.GetCppThis());
		}

		// Token: 0x06001274 RID: 4724
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderView_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001275 RID: 4725 RVA: 0x000209F8 File Offset: 0x0001EBF8
		public new static vtkRenderView SafeDownCast(vtkObjectBase o)
		{
			vtkRenderView vtkRenderView = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderView.vtkRenderView_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderView = (vtkRenderView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderView.Register(null);
				}
			}
			return vtkRenderView;
		}

		// Token: 0x06001276 RID: 4726
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetDisplayHoverText_32(HandleRef pThis, byte b);

		/// <summary>
		/// Whether the view should display hover text.
		/// </summary>
		// Token: 0x06001277 RID: 4727 RVA: 0x00020A77 File Offset: 0x0001EC77
		public virtual void SetDisplayHoverText(bool b)
		{
			vtkRenderView.vtkRenderView_SetDisplayHoverText_32(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x06001278 RID: 4728
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetDisplaySize_33(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set the display size of the icon (which may be different from the icon
		/// size). By default, if this value is not set, the IconSize is used.
		/// </summary>
		// Token: 0x06001279 RID: 4729 RVA: 0x00020A8F File Offset: 0x0001EC8F
		public virtual void SetDisplaySize(int _arg1, int _arg2)
		{
			vtkRenderView.vtkRenderView_SetDisplaySize_33(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600127A RID: 4730
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetDisplaySize_34(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the display size of the icon (which may be different from the icon
		/// size). By default, if this value is not set, the IconSize is used.
		/// </summary>
		// Token: 0x0600127B RID: 4731 RVA: 0x00020AA0 File Offset: 0x0001ECA0
		public void SetDisplaySize(IntPtr _arg)
		{
			vtkRenderView.vtkRenderView_SetDisplaySize_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600127C RID: 4732
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetIconSize_35(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set the size of each icon in the icon texture.
		/// </summary>
		// Token: 0x0600127D RID: 4733 RVA: 0x00020AB0 File Offset: 0x0001ECB0
		public virtual void SetIconSize(int _arg1, int _arg2)
		{
			vtkRenderView.vtkRenderView_SetIconSize_35(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600127E RID: 4734
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetIconSize_36(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the size of each icon in the icon texture.
		/// </summary>
		// Token: 0x0600127F RID: 4735 RVA: 0x00020AC1 File Offset: 0x0001ECC1
		public void SetIconSize(IntPtr _arg)
		{
			vtkRenderView.vtkRenderView_SetIconSize_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06001280 RID: 4736
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetIconTexture_37(HandleRef pThis, HandleRef texture);

		/// <summary>
		/// Set the icon sheet to use for rendering icons.
		/// </summary>
		// Token: 0x06001281 RID: 4737 RVA: 0x00020AD4 File Offset: 0x0001ECD4
		public virtual void SetIconTexture(vtkTexture texture)
		{
			vtkRenderView.vtkRenderView_SetIconTexture_37(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		// Token: 0x06001282 RID: 4738
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetInteractionMode_38(HandleRef pThis, int mode);

		/// <summary>
		/// Set the render window for this view. Note that this requires special
		/// handling in order to do correctly - see the notes in the detailed
		/// description of vtkRenderViewBase.
		/// </summary>
		// Token: 0x06001283 RID: 4739 RVA: 0x00020B03 File Offset: 0x0001ED03
		public void SetInteractionMode(int mode)
		{
			vtkRenderView.vtkRenderView_SetInteractionMode_38(base.GetCppThis(), mode);
		}

		// Token: 0x06001284 RID: 4740
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetInteractionModeTo2D_39(HandleRef pThis);

		/// <summary>
		/// Set the interaction mode for the view. Choices are:
		/// vtkRenderView::INTERACTION_MODE_2D - 2D interactor
		/// vtkRenderView::INTERACTION_MODE_3D - 3D interactor
		/// </summary>
		// Token: 0x06001285 RID: 4741 RVA: 0x00020B13 File Offset: 0x0001ED13
		public virtual void SetInteractionModeTo2D()
		{
			vtkRenderView.vtkRenderView_SetInteractionModeTo2D_39(base.GetCppThis());
		}

		// Token: 0x06001286 RID: 4742
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetInteractionModeTo3D_40(HandleRef pThis);

		/// <summary>
		/// Set the interaction mode for the view. Choices are:
		/// vtkRenderView::INTERACTION_MODE_2D - 2D interactor
		/// vtkRenderView::INTERACTION_MODE_3D - 3D interactor
		/// </summary>
		// Token: 0x06001287 RID: 4743 RVA: 0x00020B22 File Offset: 0x0001ED22
		public virtual void SetInteractionModeTo3D()
		{
			vtkRenderView.vtkRenderView_SetInteractionModeTo3D_40(base.GetCppThis());
		}

		// Token: 0x06001288 RID: 4744
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetInteractor_41(HandleRef pThis, HandleRef interactor);

		/// <summary>
		/// The render window interactor. Note that this requires special
		/// handling in order to do correctly - see the notes in the detailed
		/// description of vtkRenderViewBase.
		/// </summary>
		// Token: 0x06001289 RID: 4745 RVA: 0x00020B34 File Offset: 0x0001ED34
		public override void SetInteractor(vtkRenderWindowInteractor interactor)
		{
			vtkRenderView.vtkRenderView_SetInteractor_41(base.GetCppThis(), (interactor == null) ? default(HandleRef) : interactor.GetCppThis());
		}

		// Token: 0x0600128A RID: 4746
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetInteractorStyle_42(HandleRef pThis, HandleRef style);

		/// <summary>
		/// The interactor style associated with the render view.
		/// </summary>
		// Token: 0x0600128B RID: 4747 RVA: 0x00020B64 File Offset: 0x0001ED64
		public virtual void SetInteractorStyle(vtkInteractorObserver style)
		{
			vtkRenderView.vtkRenderView_SetInteractorStyle_42(base.GetCppThis(), (style == null) ? default(HandleRef) : style.GetCppThis());
		}

		// Token: 0x0600128C RID: 4748
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetLabelPlacementMode_43(HandleRef pThis, int mode);

		/// <summary>
		/// Label placement mode.
		/// NO_OVERLAP uses vtkLabelPlacementMapper, which has a faster startup time and
		/// works with 2D or 3D labels.
		/// ALL displays all labels (Warning: This may cause incredibly slow render
		/// times on datasets with more than a few hundred labels).
		/// </summary>
		// Token: 0x0600128D RID: 4749 RVA: 0x00020B93 File Offset: 0x0001ED93
		public virtual void SetLabelPlacementMode(int mode)
		{
			vtkRenderView.vtkRenderView_SetLabelPlacementMode_43(base.GetCppThis(), mode);
		}

		// Token: 0x0600128E RID: 4750
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetLabelPlacementModeToAll_44(HandleRef pThis);

		/// <summary>
		/// Label placement mode.
		/// NO_OVERLAP uses vtkLabelPlacementMapper, which has a faster startup time and
		/// works with 2D or 3D labels.
		/// ALL displays all labels (Warning: This may cause incredibly slow render
		/// times on datasets with more than a few hundred labels).
		/// </summary>
		// Token: 0x0600128F RID: 4751 RVA: 0x00020BA3 File Offset: 0x0001EDA3
		public virtual void SetLabelPlacementModeToAll()
		{
			vtkRenderView.vtkRenderView_SetLabelPlacementModeToAll_44(base.GetCppThis());
		}

		// Token: 0x06001290 RID: 4752
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetLabelPlacementModeToNoOverlap_45(HandleRef pThis);

		/// <summary>
		/// Label placement mode.
		/// NO_OVERLAP uses vtkLabelPlacementMapper, which has a faster startup time and
		/// works with 2D or 3D labels.
		/// ALL displays all labels (Warning: This may cause incredibly slow render
		/// times on datasets with more than a few hundred labels).
		/// </summary>
		// Token: 0x06001291 RID: 4753 RVA: 0x00020BB2 File Offset: 0x0001EDB2
		public virtual void SetLabelPlacementModeToNoOverlap()
		{
			vtkRenderView.vtkRenderView_SetLabelPlacementModeToNoOverlap_45(base.GetCppThis());
		}

		// Token: 0x06001292 RID: 4754
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetLabelRenderMode_46(HandleRef pThis, int mode);

		/// <summary>
		/// Label render mode.
		/// FREETYPE uses the freetype label rendering.
		/// QT uses more advanced Qt-based label rendering.
		/// </summary>
		// Token: 0x06001293 RID: 4755 RVA: 0x00020BC1 File Offset: 0x0001EDC1
		public virtual void SetLabelRenderMode(int mode)
		{
			vtkRenderView.vtkRenderView_SetLabelRenderMode_46(base.GetCppThis(), mode);
		}

		// Token: 0x06001294 RID: 4756
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetLabelRenderModeToFreetype_47(HandleRef pThis);

		/// <summary>
		/// Label render mode.
		/// FREETYPE uses the freetype label rendering.
		/// QT uses more advanced Qt-based label rendering.
		/// </summary>
		// Token: 0x06001295 RID: 4757 RVA: 0x00020BD1 File Offset: 0x0001EDD1
		public virtual void SetLabelRenderModeToFreetype()
		{
			vtkRenderView.vtkRenderView_SetLabelRenderModeToFreetype_47(base.GetCppThis());
		}

		// Token: 0x06001296 RID: 4758
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetLabelRenderModeToQt_48(HandleRef pThis);

		/// <summary>
		/// Label render mode.
		/// FREETYPE uses the freetype label rendering.
		/// QT uses more advanced Qt-based label rendering.
		/// </summary>
		// Token: 0x06001297 RID: 4759 RVA: 0x00020BE0 File Offset: 0x0001EDE0
		public virtual void SetLabelRenderModeToQt()
		{
			vtkRenderView.vtkRenderView_SetLabelRenderModeToQt_48(base.GetCppThis());
		}

		// Token: 0x06001298 RID: 4760
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetRenderOnMouseMove_49(HandleRef pThis, byte b);

		/// <summary>
		/// Whether to render on every mouse move.
		/// </summary>
		// Token: 0x06001299 RID: 4761 RVA: 0x00020BEF File Offset: 0x0001EDEF
		public void SetRenderOnMouseMove(bool b)
		{
			vtkRenderView.vtkRenderView_SetRenderOnMouseMove_49(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x0600129A RID: 4762
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetRenderWindow_50(HandleRef pThis, HandleRef win);

		/// <summary>
		/// Set the render window for this view. Note that this requires special
		/// handling in order to do correctly - see the notes in the detailed
		/// description of vtkRenderViewBase.
		/// </summary>
		// Token: 0x0600129B RID: 4763 RVA: 0x00020C08 File Offset: 0x0001EE08
		public override void SetRenderWindow(vtkRenderWindow win)
		{
			vtkRenderView.vtkRenderView_SetRenderWindow_50(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x0600129C RID: 4764
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetSelectionMode_51(HandleRef pThis, int _arg);

		/// <summary>
		/// Sets the selection mode for the render view.
		/// SURFACE selection uses vtkHardwareSelector to perform a selection
		/// of visible cells.
		/// FRUSTUM selection just creates a view frustum selection, which will
		/// select everything in the frustum.
		/// </summary>
		// Token: 0x0600129D RID: 4765 RVA: 0x00020C37 File Offset: 0x0001EE37
		public virtual void SetSelectionMode(int _arg)
		{
			vtkRenderView.vtkRenderView_SetSelectionMode_51(base.GetCppThis(), _arg);
		}

		// Token: 0x0600129E RID: 4766
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetSelectionModeToFrustum_52(HandleRef pThis);

		/// <summary>
		/// Sets the selection mode for the render view.
		/// SURFACE selection uses vtkHardwareSelector to perform a selection
		/// of visible cells.
		/// FRUSTUM selection just creates a view frustum selection, which will
		/// select everything in the frustum.
		/// </summary>
		// Token: 0x0600129F RID: 4767 RVA: 0x00020C47 File Offset: 0x0001EE47
		public void SetSelectionModeToFrustum()
		{
			vtkRenderView.vtkRenderView_SetSelectionModeToFrustum_52(base.GetCppThis());
		}

		// Token: 0x060012A0 RID: 4768
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetSelectionModeToSurface_53(HandleRef pThis);

		/// <summary>
		/// Sets the selection mode for the render view.
		/// SURFACE selection uses vtkHardwareSelector to perform a selection
		/// of visible cells.
		/// FRUSTUM selection just creates a view frustum selection, which will
		/// select everything in the frustum.
		/// </summary>
		// Token: 0x060012A1 RID: 4769 RVA: 0x00020C56 File Offset: 0x0001EE56
		public void SetSelectionModeToSurface()
		{
			vtkRenderView.vtkRenderView_SetSelectionModeToSurface_53(base.GetCppThis());
		}

		// Token: 0x060012A2 RID: 4770
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderView_SetTransform_54(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// Set the view's transform. All vtkRenderedRepresentations
		/// added to this view should use this transform.
		/// </summary>
		// Token: 0x060012A3 RID: 4771 RVA: 0x00020C68 File Offset: 0x0001EE68
		public virtual void SetTransform(vtkAbstractTransform transform)
		{
			vtkRenderView.vtkRenderView_SetTransform_54(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000450 RID: 1104
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderView";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000451 RID: 1105
		public new static readonly string MRClassNameKey = "class vtkRenderView";

		/// <summary>
		/// Set the render window for this view. Note that this requires special
		/// handling in order to do correctly - see the notes in the detailed
		/// description of vtkRenderViewBase.
		/// </summary>
		// Token: 0x02000066 RID: 102
		public enum INTERACTION_MODE_2D_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000453 RID: 1107
			INTERACTION_MODE_2D,
			/// <summary>enum member</summary>
			// Token: 0x04000454 RID: 1108
			INTERACTION_MODE_3D,
			/// <summary>enum member</summary>
			// Token: 0x04000455 RID: 1109
			INTERACTION_MODE_UNKNOWN
		}

		/// <summary>
		/// Whether the view should display hover text.
		/// </summary>
		// Token: 0x02000067 RID: 103
		public enum FRUSTUM_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000457 RID: 1111
			FRUSTUM = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000458 RID: 1112
			SURFACE = 0
		}

		/// <summary>
		/// Set the display size of the icon (which may be different from the icon
		/// size). By default, if this value is not set, the IconSize is used.
		/// </summary>
		// Token: 0x02000068 RID: 104
		public enum ALL_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400045A RID: 1114
			ALL = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400045B RID: 1115
			NO_OVERLAP = 0
		}

		/// <summary>
		/// Label placement mode.
		/// NO_OVERLAP uses vtkLabelPlacementMapper, which has a faster startup time and
		/// works with 2D or 3D labels.
		/// ALL displays all labels (Warning: This may cause incredibly slow render
		/// times on datasets with more than a few hundred labels).
		/// </summary>
		// Token: 0x02000069 RID: 105
		public enum FREETYPE_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400045D RID: 1117
			FREETYPE,
			/// <summary>enum member</summary>
			// Token: 0x0400045E RID: 1118
			QT
		}
	}
}
