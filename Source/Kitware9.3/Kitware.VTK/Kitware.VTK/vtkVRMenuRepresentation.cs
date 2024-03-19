using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVRMenuRepresentation
	/// </summary>
	/// <remarks>
	///    Widget representation for vtkVRMenuWidget
	/// Implementation of the popup panel representation for the
	/// vtkVRMenuWidget.
	/// This representation is rebuilt every time the selected/hovered prop changes.
	/// Its position is set according to the camera orientation and is placed at a
	/// distance defined in meters in the BuildRepresentation() method.
	///
	/// WARNING: The panel might be occluded by other props.
	///   TODO: Improve placement method.
	/// </remarks>
	// Token: 0x020000C2 RID: 194
	public class vtkVRMenuRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002A4B RID: 10827 RVA: 0x0003E7BE File Offset: 0x0003C9BE
		static vtkVRMenuRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRMenuRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRMenuRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002A4C RID: 10828 RVA: 0x0003E7E6 File Offset: 0x0003C9E6
		public vtkVRMenuRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002A4D RID: 10829
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRMenuRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06002A4E RID: 10830 RVA: 0x0003E7F4 File Offset: 0x0003C9F4
		public new static vtkVRMenuRepresentation New()
		{
			vtkVRMenuRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRMenuRepresentation.vtkVRMenuRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRMenuRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06002A4F RID: 10831 RVA: 0x0003E848 File Offset: 0x0003CA48
		public vtkVRMenuRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVRMenuRepresentation.vtkVRMenuRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002A50 RID: 10832 RVA: 0x0003E88C File Offset: 0x0003CA8C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002A51 RID: 10833
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMenuRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Methods to interface with the vtkVRMenuWidget.
		/// </summary>
		// Token: 0x06002A52 RID: 10834 RVA: 0x0003E897 File Offset: 0x0003CA97
		public override void BuildRepresentation()
		{
			vtkVRMenuRepresentation.vtkVRMenuRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06002A53 RID: 10835
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMenuRepresentation_ComplexInteraction_02(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// Methods to interface with the vtkVRMenuWidget.
		/// </summary>
		// Token: 0x06002A54 RID: 10836 RVA: 0x0003E8A8 File Offset: 0x0003CAA8
		public override void ComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkVRMenuRepresentation.vtkVRMenuRepresentation_ComplexInteraction_02(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x06002A55 RID: 10837
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMenuRepresentation_EndComplexInteraction_03(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// Methods to interface with the vtkVRMenuWidget.
		/// </summary>
		// Token: 0x06002A56 RID: 10838 RVA: 0x0003E8F0 File Offset: 0x0003CAF0
		public override void EndComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkVRMenuRepresentation.vtkVRMenuRepresentation_EndComplexInteraction_03(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x06002A57 RID: 10839
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVRMenuRepresentation_GetCurrentOption_04(HandleRef pThis);

		/// <summary>
		/// Methods to add/remove items to the menu, called by the menu widget
		/// </summary>
		// Token: 0x06002A58 RID: 10840 RVA: 0x0003E938 File Offset: 0x0003CB38
		public virtual double GetCurrentOption()
		{
			return vtkVRMenuRepresentation.vtkVRMenuRepresentation_GetCurrentOption_04(base.GetCppThis());
		}

		// Token: 0x06002A59 RID: 10841
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRMenuRepresentation_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06002A5A RID: 10842 RVA: 0x0003E958 File Offset: 0x0003CB58
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVRMenuRepresentation.vtkVRMenuRepresentation_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06002A5B RID: 10843
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRMenuRepresentation_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06002A5C RID: 10844 RVA: 0x0003E978 File Offset: 0x0003CB78
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVRMenuRepresentation.vtkVRMenuRepresentation_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06002A5D RID: 10845
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRMenuRepresentation_HasTranslucentPolygonalGeometry_07(HandleRef pThis);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06002A5E RID: 10846 RVA: 0x0003E994 File Offset: 0x0003CB94
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkVRMenuRepresentation.vtkVRMenuRepresentation_HasTranslucentPolygonalGeometry_07(base.GetCppThis());
		}

		// Token: 0x06002A5F RID: 10847
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRMenuRepresentation_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06002A60 RID: 10848 RVA: 0x0003E9B4 File Offset: 0x0003CBB4
		public override int IsA(string type)
		{
			return vtkVRMenuRepresentation.vtkVRMenuRepresentation_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06002A61 RID: 10849
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRMenuRepresentation_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06002A62 RID: 10850 RVA: 0x0003E9D4 File Offset: 0x0003CBD4
		public new static int IsTypeOf(string type)
		{
			return vtkVRMenuRepresentation.vtkVRMenuRepresentation_IsTypeOf_09(type);
		}

		// Token: 0x06002A63 RID: 10851
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRMenuRepresentation_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06002A64 RID: 10852 RVA: 0x0003E9F0 File Offset: 0x0003CBF0
		public new vtkVRMenuRepresentation NewInstance()
		{
			vtkVRMenuRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRMenuRepresentation.vtkVRMenuRepresentation_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRMenuRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002A65 RID: 10853
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMenuRepresentation_PushFrontMenuItem_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string text, HandleRef cmd);

		/// <summary>
		/// Methods to add/remove items to the menu, called by the menu widget
		/// </summary>
		// Token: 0x06002A66 RID: 10854 RVA: 0x0003EA4C File Offset: 0x0003CC4C
		public void PushFrontMenuItem(string name, string text, vtkCommand cmd)
		{
			vtkVRMenuRepresentation.vtkVRMenuRepresentation_PushFrontMenuItem_12(base.GetCppThis(), name, text, (cmd == null) ? default(HandleRef) : cmd.GetCppThis());
		}

		// Token: 0x06002A67 RID: 10855
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMenuRepresentation_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06002A68 RID: 10856 RVA: 0x0003EA80 File Offset: 0x0003CC80
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkVRMenuRepresentation.vtkVRMenuRepresentation_ReleaseGraphicsResources_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002A69 RID: 10857
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMenuRepresentation_RemoveAllMenuItems_14(HandleRef pThis);

		/// <summary>
		/// Methods to add/remove items to the menu, called by the menu widget
		/// </summary>
		// Token: 0x06002A6A RID: 10858 RVA: 0x0003EAAF File Offset: 0x0003CCAF
		public void RemoveAllMenuItems()
		{
			vtkVRMenuRepresentation.vtkVRMenuRepresentation_RemoveAllMenuItems_14(base.GetCppThis());
		}

		// Token: 0x06002A6B RID: 10859
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMenuRepresentation_RemoveMenuItem_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Methods to add/remove items to the menu, called by the menu widget
		/// </summary>
		// Token: 0x06002A6C RID: 10860 RVA: 0x0003EABE File Offset: 0x0003CCBE
		public void RemoveMenuItem(string name)
		{
			vtkVRMenuRepresentation.vtkVRMenuRepresentation_RemoveMenuItem_15(base.GetCppThis(), name);
		}

		// Token: 0x06002A6D RID: 10861
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMenuRepresentation_RenameMenuItem_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string text);

		/// <summary>
		/// Methods to add/remove items to the menu, called by the menu widget
		/// </summary>
		// Token: 0x06002A6E RID: 10862 RVA: 0x0003EACE File Offset: 0x0003CCCE
		public void RenameMenuItem(string name, string text)
		{
			vtkVRMenuRepresentation.vtkVRMenuRepresentation_RenameMenuItem_16(base.GetCppThis(), name, text);
		}

		// Token: 0x06002A6F RID: 10863
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRMenuRepresentation_RenderOverlay_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06002A70 RID: 10864 RVA: 0x0003EAE0 File Offset: 0x0003CCE0
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkVRMenuRepresentation.vtkVRMenuRepresentation_RenderOverlay_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002A71 RID: 10865
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRMenuRepresentation_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06002A72 RID: 10866 RVA: 0x0003EB14 File Offset: 0x0003CD14
		public new static vtkVRMenuRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkVRMenuRepresentation vtkVRMenuRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRMenuRepresentation.vtkVRMenuRepresentation_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRMenuRepresentation = (vtkVRMenuRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRMenuRepresentation.Register(null);
				}
			}
			return vtkVRMenuRepresentation;
		}

		// Token: 0x06002A73 RID: 10867
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMenuRepresentation_StartComplexInteraction_19(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// Methods to interface with the vtkVRMenuWidget.
		/// </summary>
		// Token: 0x06002A74 RID: 10868 RVA: 0x0003EB94 File Offset: 0x0003CD94
		public override void StartComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkVRMenuRepresentation.vtkVRMenuRepresentation_StartComplexInteraction_19(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000574 RID: 1396
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRMenuRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000575 RID: 1397
		public new static readonly string MRClassNameKey = "class vtkVRMenuRepresentation";
	}
}
