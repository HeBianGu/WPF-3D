using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProgressBarWidget
	/// </summary>
	/// <remarks>
	///    2D widget for placing and manipulating a progress bar
	///
	/// This class provides support for interactively displaying and manipulating
	/// a progress bar.A Progress bar is defined by a progress rate and the color of the bar and
	/// its background.
	/// This widget allows you to interactively place and resize the progress bar.
	/// To use this widget, simply create a vtkProgressBarRepresentation (or subclass)
	/// and associate it with a vtkProgressBarWidget instance.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBorderWidget
	/// </seealso>
	// Token: 0x0200035D RID: 861
	public class vtkProgressBarWidget : vtkBorderWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009CC2 RID: 40130 RVA: 0x000DE0E8 File Offset: 0x000DC2E8
		static vtkProgressBarWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProgressBarWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgressBarWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009CC3 RID: 40131 RVA: 0x000DE110 File Offset: 0x000DC310
		public vtkProgressBarWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009CC4 RID: 40132
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgressBarWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009CC5 RID: 40133 RVA: 0x000DE120 File Offset: 0x000DC320
		public new static vtkProgressBarWidget New()
		{
			vtkProgressBarWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgressBarWidget.vtkProgressBarWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgressBarWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009CC6 RID: 40134 RVA: 0x000DE174 File Offset: 0x000DC374
		public vtkProgressBarWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProgressBarWidget.vtkProgressBarWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009CC7 RID: 40135 RVA: 0x000DE1B8 File Offset: 0x000DC3B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009CC8 RID: 40136
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06009CC9 RID: 40137 RVA: 0x000DE1C3 File Offset: 0x000DC3C3
		public override void CreateDefaultRepresentation()
		{
			vtkProgressBarWidget.vtkProgressBarWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009CCA RID: 40138
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgressBarWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009CCB RID: 40139 RVA: 0x000DE1D4 File Offset: 0x000DC3D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProgressBarWidget.vtkProgressBarWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06009CCC RID: 40140
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgressBarWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009CCD RID: 40141 RVA: 0x000DE1F4 File Offset: 0x000DC3F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProgressBarWidget.vtkProgressBarWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06009CCE RID: 40142
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgressBarWidget_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009CCF RID: 40143 RVA: 0x000DE210 File Offset: 0x000DC410
		public override int IsA(string type)
		{
			return vtkProgressBarWidget.vtkProgressBarWidget_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06009CD0 RID: 40144
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgressBarWidget_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009CD1 RID: 40145 RVA: 0x000DE230 File Offset: 0x000DC430
		public new static int IsTypeOf(string type)
		{
			return vtkProgressBarWidget.vtkProgressBarWidget_IsTypeOf_05(type);
		}

		// Token: 0x06009CD2 RID: 40146
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgressBarWidget_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009CD3 RID: 40147 RVA: 0x000DE24C File Offset: 0x000DC44C
		public new vtkProgressBarWidget NewInstance()
		{
			vtkProgressBarWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgressBarWidget.vtkProgressBarWidget_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgressBarWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009CD4 RID: 40148
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgressBarWidget_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009CD5 RID: 40149 RVA: 0x000DE2A8 File Offset: 0x000DC4A8
		public new static vtkProgressBarWidget SafeDownCast(vtkObjectBase o)
		{
			vtkProgressBarWidget vtkProgressBarWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgressBarWidget.vtkProgressBarWidget_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProgressBarWidget = (vtkProgressBarWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProgressBarWidget.Register(null);
				}
			}
			return vtkProgressBarWidget;
		}

		// Token: 0x06009CD6 RID: 40150
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressBarWidget_SetRepresentation_09(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06009CD7 RID: 40151 RVA: 0x000DE328 File Offset: 0x000DC528
		public void SetRepresentation(vtkProgressBarRepresentation r)
		{
			vtkProgressBarWidget.vtkProgressBarWidget_SetRepresentation_09(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CAD RID: 3245
		public new const string MRFullTypeName = "Kitware.VTK.vtkProgressBarWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CAE RID: 3246
		public new static readonly string MRClassNameKey = "class vtkProgressBarWidget";
	}
}
