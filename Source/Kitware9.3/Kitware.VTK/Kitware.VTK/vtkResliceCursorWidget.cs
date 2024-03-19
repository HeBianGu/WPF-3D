using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkResliceCursorWidget
	/// </summary>
	/// <remarks>
	///    represent a reslice cursor
	///
	/// This class represents a reslice cursor that can be used to
	/// perform interactive thick slab MPR's through data. It
	/// consists of two cross sectional hairs, with an optional thickness. The
	/// hairs may have a hole in the center. These may be translated or rotated
	/// independent of each other in the view. The result is used to reslice
	/// the data along these cross sections. This allows the user to perform
	/// multi-planar thin or thick reformat of the data on an image view, rather
	/// than a 3D view. The class internally uses vtkImageSlabReslice
	/// or vtkImageReslice depending on the modes in vtkResliceCursor to
	/// do its reslicing. The slab thickness is set interactively from
	/// the widget. The slab resolution (ie the number of blend points) is
	/// set as the minimum spacing along any dimension from the dataset.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageSlabReslice vtkResliceCursorLineRepresentation
	/// vtkResliceCursor
	/// </seealso>
	// Token: 0x0200036D RID: 877
	public class vtkResliceCursorWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009F5D RID: 40797 RVA: 0x000E2193 File Offset: 0x000E0393
		static vtkResliceCursorWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkResliceCursorWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceCursorWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009F5E RID: 40798 RVA: 0x000E21BB File Offset: 0x000E03BB
		public vtkResliceCursorWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009F5F RID: 40799
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009F60 RID: 40800 RVA: 0x000E21CC File Offset: 0x000E03CC
		public new static vtkResliceCursorWidget New()
		{
			vtkResliceCursorWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorWidget.vtkResliceCursorWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceCursorWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009F61 RID: 40801 RVA: 0x000E2220 File Offset: 0x000E0420
		public vtkResliceCursorWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkResliceCursorWidget.vtkResliceCursorWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009F62 RID: 40802 RVA: 0x000E2264 File Offset: 0x000E0464
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009F63 RID: 40803
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06009F64 RID: 40804 RVA: 0x000E226F File Offset: 0x000E046F
		public override void CreateDefaultRepresentation()
		{
			vtkResliceCursorWidget.vtkResliceCursorWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009F65 RID: 40805
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorWidget_GetManageWindowLevel_02(HandleRef pThis);

		/// <summary>
		/// Also perform window level ?
		/// </summary>
		// Token: 0x06009F66 RID: 40806 RVA: 0x000E2280 File Offset: 0x000E0480
		public virtual int GetManageWindowLevel()
		{
			return vtkResliceCursorWidget.vtkResliceCursorWidget_GetManageWindowLevel_02(base.GetCppThis());
		}

		// Token: 0x06009F67 RID: 40807
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceCursorWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06009F68 RID: 40808 RVA: 0x000E22A0 File Offset: 0x000E04A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkResliceCursorWidget.vtkResliceCursorWidget_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06009F69 RID: 40809
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceCursorWidget_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06009F6A RID: 40810 RVA: 0x000E22C0 File Offset: 0x000E04C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkResliceCursorWidget.vtkResliceCursorWidget_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06009F6B RID: 40811
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorWidget_GetResliceCursorRepresentation_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkResliceCursorRepresentation.
		/// </summary>
		// Token: 0x06009F6C RID: 40812 RVA: 0x000E22DC File Offset: 0x000E04DC
		public vtkResliceCursorRepresentation GetResliceCursorRepresentation()
		{
			vtkResliceCursorRepresentation vtkResliceCursorRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorWidget.vtkResliceCursorWidget_GetResliceCursorRepresentation_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceCursorRepresentation = (vtkResliceCursorRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceCursorRepresentation.Register(null);
				}
			}
			return vtkResliceCursorRepresentation;
		}

		// Token: 0x06009F6D RID: 40813
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorWidget_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06009F6E RID: 40814 RVA: 0x000E234C File Offset: 0x000E054C
		public override int IsA(string type)
		{
			return vtkResliceCursorWidget.vtkResliceCursorWidget_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06009F6F RID: 40815
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorWidget_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06009F70 RID: 40816 RVA: 0x000E236C File Offset: 0x000E056C
		public new static int IsTypeOf(string type)
		{
			return vtkResliceCursorWidget.vtkResliceCursorWidget_IsTypeOf_07(type);
		}

		// Token: 0x06009F71 RID: 40817
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorWidget_ManageWindowLevelOff_08(HandleRef pThis);

		/// <summary>
		/// Also perform window level ?
		/// </summary>
		// Token: 0x06009F72 RID: 40818 RVA: 0x000E2386 File Offset: 0x000E0586
		public virtual void ManageWindowLevelOff()
		{
			vtkResliceCursorWidget.vtkResliceCursorWidget_ManageWindowLevelOff_08(base.GetCppThis());
		}

		// Token: 0x06009F73 RID: 40819
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorWidget_ManageWindowLevelOn_09(HandleRef pThis);

		/// <summary>
		/// Also perform window level ?
		/// </summary>
		// Token: 0x06009F74 RID: 40820 RVA: 0x000E2395 File Offset: 0x000E0595
		public virtual void ManageWindowLevelOn()
		{
			vtkResliceCursorWidget.vtkResliceCursorWidget_ManageWindowLevelOn_09(base.GetCppThis());
		}

		// Token: 0x06009F75 RID: 40821
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorWidget_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06009F76 RID: 40822 RVA: 0x000E23A4 File Offset: 0x000E05A4
		public new vtkResliceCursorWidget NewInstance()
		{
			vtkResliceCursorWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorWidget.vtkResliceCursorWidget_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceCursorWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009F77 RID: 40823
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorWidget_ResetResliceCursor_12(HandleRef pThis);

		/// <summary>
		/// Reset the cursor back to its initial state
		/// </summary>
		// Token: 0x06009F78 RID: 40824 RVA: 0x000E23FE File Offset: 0x000E05FE
		public virtual void ResetResliceCursor()
		{
			vtkResliceCursorWidget.vtkResliceCursorWidget_ResetResliceCursor_12(base.GetCppThis());
		}

		// Token: 0x06009F79 RID: 40825
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorWidget_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x06009F7A RID: 40826 RVA: 0x000E2410 File Offset: 0x000E0610
		public new static vtkResliceCursorWidget SafeDownCast(vtkObjectBase o)
		{
			vtkResliceCursorWidget vtkResliceCursorWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorWidget.vtkResliceCursorWidget_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceCursorWidget = (vtkResliceCursorWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceCursorWidget.Register(null);
				}
			}
			return vtkResliceCursorWidget;
		}

		// Token: 0x06009F7B RID: 40827
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorWidget_SetEnabled_14(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods for activiating this widget. This implementation extends the
		/// superclasses' in order to resize the widget handles due to a render
		/// start event.
		/// </summary>
		// Token: 0x06009F7C RID: 40828 RVA: 0x000E248F File Offset: 0x000E068F
		public override void SetEnabled(int arg0)
		{
			vtkResliceCursorWidget.vtkResliceCursorWidget_SetEnabled_14(base.GetCppThis(), arg0);
		}

		// Token: 0x06009F7D RID: 40829
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorWidget_SetManageWindowLevel_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Also perform window level ?
		/// </summary>
		// Token: 0x06009F7E RID: 40830 RVA: 0x000E249F File Offset: 0x000E069F
		public virtual void SetManageWindowLevel(int _arg)
		{
			vtkResliceCursorWidget.vtkResliceCursorWidget_SetManageWindowLevel_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06009F7F RID: 40831
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorWidget_SetRepresentation_16(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06009F80 RID: 40832 RVA: 0x000E24B0 File Offset: 0x000E06B0
		public void SetRepresentation(vtkResliceCursorRepresentation r)
		{
			vtkResliceCursorWidget.vtkResliceCursorWidget_SetRepresentation_16(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CDD RID: 3293
		public new const string MRFullTypeName = "Kitware.VTK.vtkResliceCursorWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CDE RID: 3294
		public new static readonly string MRClassNameKey = "class vtkResliceCursorWidget";

		/// <summary>
		/// Events
		/// </summary>
		// Token: 0x0200036E RID: 878
		public enum ResetCursorEvent_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000CE0 RID: 3296
			ResetCursorEvent = 1058,
			/// <summary>enum member</summary>
			// Token: 0x04000CE1 RID: 3297
			ResliceAxesChangedEvent = 1056,
			/// <summary>enum member</summary>
			// Token: 0x04000CE2 RID: 3298
			ResliceThicknessChangedEvent,
			/// <summary>enum member</summary>
			// Token: 0x04000CE3 RID: 3299
			WindowLevelEvent = 1055
		}
	}
}
