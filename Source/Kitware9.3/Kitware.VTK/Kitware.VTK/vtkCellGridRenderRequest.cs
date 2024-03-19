using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///     vtkCellGridRenderRequest
	/// </summary>
	/// <remarks>
	///     State used by vtkCellGridMapper during rendering.
	///
	/// This is a vtkCellGridQuery subclass that mappers can use to draw cells
	/// into a renderer using an actor and, subsequently, to release resources.
	///
	/// Note that this request has two modes: it will either instruct
	/// responders to draw cells (IsReleasingResources == false) or instruct
	/// responders to release OpenGL objects for a particular window
	/// (when IsReleasingResources == true).
	/// Responders must call GetIsReleasingResources() and only perform
	/// one task or the other, depending on the returned value.
	/// </remarks>
	// Token: 0x020007D0 RID: 2000
	public class vtkCellGridRenderRequest : vtkCellGridQuery
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014723 RID: 83747 RVA: 0x001CF4A3 File Offset: 0x001CD6A3
		static vtkCellGridRenderRequest()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGridRenderRequest.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGridRenderRequest"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014724 RID: 83748 RVA: 0x001CF4CB File Offset: 0x001CD6CB
		public vtkCellGridRenderRequest(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014725 RID: 83749
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridRenderRequest_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014726 RID: 83750 RVA: 0x001CF4DC File Offset: 0x001CD6DC
		public new static vtkCellGridRenderRequest New()
		{
			vtkCellGridRenderRequest result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridRenderRequest.vtkCellGridRenderRequest_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridRenderRequest)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014727 RID: 83751 RVA: 0x001CF530 File Offset: 0x001CD730
		public vtkCellGridRenderRequest() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellGridRenderRequest.vtkCellGridRenderRequest_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014728 RID: 83752 RVA: 0x001CF574 File Offset: 0x001CD774
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014729 RID: 83753
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridRenderRequest_Finalize_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601472A RID: 83754 RVA: 0x001CF57F File Offset: 0x001CD77F
		public override void FinalizeWrapper()
		{
			vtkCellGridRenderRequest.vtkCellGridRenderRequest_Finalize_01(base.GetCppThis());
		}

		// Token: 0x0601472B RID: 83755
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridRenderRequest_GetActor_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601472C RID: 83756 RVA: 0x001CF590 File Offset: 0x001CD790
		public virtual vtkActor GetActor()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridRenderRequest.vtkCellGridRenderRequest_GetActor_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		// Token: 0x0601472D RID: 83757
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellGridRenderRequest_GetIsReleasingResources_03(HandleRef pThis);

		/// <summary>
		/// Set/get whether the request should render (false) or release resources (true).
		/// The latter should be performed as a separate query after rendering.
		///
		/// Note that after a successful call to Query with IsReleasingResources set to
		/// true, the Finalize() method will reset IsReleasingResources to false, which
		/// results in the request being marked modified.
		/// </summary>
		// Token: 0x0601472E RID: 83758 RVA: 0x001CF600 File Offset: 0x001CD800
		public virtual bool GetIsReleasingResources()
		{
			return vtkCellGridRenderRequest.vtkCellGridRenderRequest_GetIsReleasingResources_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0601472F RID: 83759
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridRenderRequest_GetMapper_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014730 RID: 83760 RVA: 0x001CF628 File Offset: 0x001CD828
		public virtual vtkCellGridMapper GetMapper()
		{
			vtkCellGridMapper vtkCellGridMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridRenderRequest.vtkCellGridRenderRequest_GetMapper_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridMapper = (vtkCellGridMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridMapper.Register(null);
				}
			}
			return vtkCellGridMapper;
		}

		// Token: 0x06014731 RID: 83761
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridRenderRequest_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014732 RID: 83762 RVA: 0x001CF698 File Offset: 0x001CD898
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGridRenderRequest.vtkCellGridRenderRequest_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06014733 RID: 83763
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridRenderRequest_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014734 RID: 83764 RVA: 0x001CF6B8 File Offset: 0x001CD8B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGridRenderRequest.vtkCellGridRenderRequest_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06014735 RID: 83765
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridRenderRequest_GetRenderer_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014736 RID: 83766 RVA: 0x001CF6D4 File Offset: 0x001CD8D4
		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridRenderRequest.vtkCellGridRenderRequest_GetRenderer_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06014737 RID: 83767
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkCellGridRenderRequest_GetShapesToDraw_08(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014738 RID: 83768 RVA: 0x001CF744 File Offset: 0x001CD944
		public virtual sbyte GetShapesToDraw()
		{
			return vtkCellGridRenderRequest.vtkCellGridRenderRequest_GetShapesToDraw_08(base.GetCppThis());
		}

		// Token: 0x06014739 RID: 83769
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkCellGridRenderRequest_GetShapesToDrawMaxValue_09(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601473A RID: 83770 RVA: 0x001CF764 File Offset: 0x001CD964
		public virtual sbyte GetShapesToDrawMaxValue()
		{
			return vtkCellGridRenderRequest.vtkCellGridRenderRequest_GetShapesToDrawMaxValue_09(base.GetCppThis());
		}

		// Token: 0x0601473B RID: 83771
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkCellGridRenderRequest_GetShapesToDrawMinValue_10(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601473C RID: 83772 RVA: 0x001CF784 File Offset: 0x001CD984
		public virtual sbyte GetShapesToDrawMinValue()
		{
			return vtkCellGridRenderRequest.vtkCellGridRenderRequest_GetShapesToDrawMinValue_10(base.GetCppThis());
		}

		// Token: 0x0601473D RID: 83773
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridRenderRequest_GetWindow_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601473E RID: 83774 RVA: 0x001CF7A4 File Offset: 0x001CD9A4
		public virtual vtkWindow GetWindow()
		{
			vtkWindow vtkWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridRenderRequest.vtkCellGridRenderRequest_GetWindow_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWindow = (vtkWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWindow.Register(null);
				}
			}
			return vtkWindow;
		}

		// Token: 0x0601473F RID: 83775
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridRenderRequest_Initialize_12(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014740 RID: 83776 RVA: 0x001CF813 File Offset: 0x001CDA13
		public override void Initialize()
		{
			vtkCellGridRenderRequest.vtkCellGridRenderRequest_Initialize_12(base.GetCppThis());
		}

		// Token: 0x06014741 RID: 83777
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridRenderRequest_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014742 RID: 83778 RVA: 0x001CF824 File Offset: 0x001CDA24
		public override int IsA(string type)
		{
			return vtkCellGridRenderRequest.vtkCellGridRenderRequest_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06014743 RID: 83779
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridRenderRequest_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014744 RID: 83780 RVA: 0x001CF844 File Offset: 0x001CDA44
		public new static int IsTypeOf(string type)
		{
			return vtkCellGridRenderRequest.vtkCellGridRenderRequest_IsTypeOf_14(type);
		}

		// Token: 0x06014745 RID: 83781
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridRenderRequest_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014746 RID: 83782 RVA: 0x001CF860 File Offset: 0x001CDA60
		public new vtkCellGridRenderRequest NewInstance()
		{
			vtkCellGridRenderRequest result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridRenderRequest.vtkCellGridRenderRequest_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridRenderRequest)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014747 RID: 83783
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridRenderRequest_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014748 RID: 83784 RVA: 0x001CF8BC File Offset: 0x001CDABC
		public new static vtkCellGridRenderRequest SafeDownCast(vtkObjectBase o)
		{
			vtkCellGridRenderRequest vtkCellGridRenderRequest = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridRenderRequest.vtkCellGridRenderRequest_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridRenderRequest = (vtkCellGridRenderRequest)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridRenderRequest.Register(null);
				}
			}
			return vtkCellGridRenderRequest;
		}

		// Token: 0x06014749 RID: 83785
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridRenderRequest_SetActor_18(HandleRef pThis, HandleRef actor);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601474A RID: 83786 RVA: 0x001CF93C File Offset: 0x001CDB3C
		public virtual void SetActor(vtkActor actor)
		{
			vtkCellGridRenderRequest.vtkCellGridRenderRequest_SetActor_18(base.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		// Token: 0x0601474B RID: 83787
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridRenderRequest_SetIsReleasingResources_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/get whether the request should render (false) or release resources (true).
		/// The latter should be performed as a separate query after rendering.
		///
		/// Note that after a successful call to Query with IsReleasingResources set to
		/// true, the Finalize() method will reset IsReleasingResources to false, which
		/// results in the request being marked modified.
		/// </summary>
		// Token: 0x0601474C RID: 83788 RVA: 0x001CF96B File Offset: 0x001CDB6B
		public virtual void SetIsReleasingResources(bool _arg)
		{
			vtkCellGridRenderRequest.vtkCellGridRenderRequest_SetIsReleasingResources_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601474D RID: 83789
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridRenderRequest_SetMapper_20(HandleRef pThis, HandleRef mapper);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601474E RID: 83790 RVA: 0x001CF984 File Offset: 0x001CDB84
		public virtual void SetMapper(vtkCellGridMapper mapper)
		{
			vtkCellGridRenderRequest.vtkCellGridRenderRequest_SetMapper_20(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x0601474F RID: 83791
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridRenderRequest_SetRenderer_21(HandleRef pThis, HandleRef renderer);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014750 RID: 83792 RVA: 0x001CF9B4 File Offset: 0x001CDBB4
		public virtual void SetRenderer(vtkRenderer renderer)
		{
			vtkCellGridRenderRequest.vtkCellGridRenderRequest_SetRenderer_21(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x06014751 RID: 83793
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridRenderRequest_SetShapesToDraw_22(HandleRef pThis, sbyte _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014752 RID: 83794 RVA: 0x001CF9E3 File Offset: 0x001CDBE3
		public virtual void SetShapesToDraw(sbyte _arg)
		{
			vtkCellGridRenderRequest.vtkCellGridRenderRequest_SetShapesToDraw_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06014753 RID: 83795
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridRenderRequest_SetWindow_23(HandleRef pThis, HandleRef window);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014754 RID: 83796 RVA: 0x001CF9F4 File Offset: 0x001CDBF4
		public virtual void SetWindow(vtkWindow window)
		{
			vtkCellGridRenderRequest.vtkCellGridRenderRequest_SetWindow_23(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017C1 RID: 6081
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGridRenderRequest";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017C2 RID: 6082
		public new static readonly string MRClassNameKey = "class vtkCellGridRenderRequest";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020007D1 RID: 2001
		public enum RenderableGeometry
		{
			/// <summary>enum member</summary>
			// Token: 0x040017C4 RID: 6084
			ALL = 15,
			/// <summary>enum member</summary>
			// Token: 0x040017C5 RID: 6085
			EDGES = 2,
			/// <summary>enum member</summary>
			// Token: 0x040017C6 RID: 6086
			FACES = 4,
			/// <summary>enum member</summary>
			// Token: 0x040017C7 RID: 6087
			SURFACE_WITH_EDGES = 6,
			/// <summary>enum member</summary>
			// Token: 0x040017C8 RID: 6088
			VERTICES = 1,
			/// <summary>enum member</summary>
			// Token: 0x040017C9 RID: 6089
			VOLUMES = 8
		}
	}
}
