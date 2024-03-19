using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCameraPathWidget
	/// </summary>
	/// <remarks>
	///    widget for vtkCameraPathRepresentation.
	///
	/// vtkCameraPathWidget is the vtkAbstractWidget subclass for
	/// vtkCameraPathRepresentation which manages the interactions with
	/// vtkCameraPathRepresentation. This is based on vtkSplineWidget2.
	/// </remarks>
	/// <seealso>
	///
	/// vtkCameraPathRepresentation
	/// </seealso>
	// Token: 0x020002E9 RID: 745
	public class vtkCameraPathWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060085F5 RID: 34293 RVA: 0x000BF22F File Offset: 0x000BD42F
		static vtkCameraPathWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCameraPathWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraPathWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060085F6 RID: 34294 RVA: 0x000BF257 File Offset: 0x000BD457
		public vtkCameraPathWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060085F7 RID: 34295
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraPathWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060085F8 RID: 34296 RVA: 0x000BF268 File Offset: 0x000BD468
		public new static vtkCameraPathWidget New()
		{
			vtkCameraPathWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraPathWidget.vtkCameraPathWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraPathWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060085F9 RID: 34297 RVA: 0x000BF2BC File Offset: 0x000BD4BC
		public vtkCameraPathWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCameraPathWidget.vtkCameraPathWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060085FA RID: 34298 RVA: 0x000BF300 File Offset: 0x000BD500
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060085FB RID: 34299
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraPathWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set. By default,
		/// this is an instance of the vtkCameraPathRepresentation class.
		/// </summary>
		// Token: 0x060085FC RID: 34300 RVA: 0x000BF30B File Offset: 0x000BD50B
		public override void CreateDefaultRepresentation()
		{
			vtkCameraPathWidget.vtkCameraPathWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x060085FD RID: 34301
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraPathWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060085FE RID: 34302 RVA: 0x000BF31C File Offset: 0x000BD51C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCameraPathWidget.vtkCameraPathWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060085FF RID: 34303
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraPathWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008600 RID: 34304 RVA: 0x000BF33C File Offset: 0x000BD53C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCameraPathWidget.vtkCameraPathWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06008601 RID: 34305
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraPathWidget_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008602 RID: 34306 RVA: 0x000BF358 File Offset: 0x000BD558
		public override int IsA(string type)
		{
			return vtkCameraPathWidget.vtkCameraPathWidget_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06008603 RID: 34307
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraPathWidget_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008604 RID: 34308 RVA: 0x000BF378 File Offset: 0x000BD578
		public new static int IsTypeOf(string type)
		{
			return vtkCameraPathWidget.vtkCameraPathWidget_IsTypeOf_05(type);
		}

		// Token: 0x06008605 RID: 34309
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraPathWidget_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008606 RID: 34310 RVA: 0x000BF394 File Offset: 0x000BD594
		public new vtkCameraPathWidget NewInstance()
		{
			vtkCameraPathWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraPathWidget.vtkCameraPathWidget_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraPathWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008607 RID: 34311
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraPathWidget_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008608 RID: 34312 RVA: 0x000BF3F0 File Offset: 0x000BD5F0
		public new static vtkCameraPathWidget SafeDownCast(vtkObjectBase o)
		{
			vtkCameraPathWidget vtkCameraPathWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraPathWidget.vtkCameraPathWidget_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraPathWidget = (vtkCameraPathWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraPathWidget.Register(null);
				}
			}
			return vtkCameraPathWidget;
		}

		// Token: 0x06008609 RID: 34313
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraPathWidget_SetEnabled_09(HandleRef pThis, int enabling);

		/// <summary>
		/// Override superclasses SetEnabled() method because the line
		/// widget must enable its internal handle widgets.
		/// </summary>
		// Token: 0x0600860A RID: 34314 RVA: 0x000BF46F File Offset: 0x000BD66F
		public override void SetEnabled(int enabling)
		{
			vtkCameraPathWidget.vtkCameraPathWidget_SetEnabled_09(base.GetCppThis(), enabling);
		}

		// Token: 0x0600860B RID: 34315
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraPathWidget_SetRepresentation_10(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of
		/// vtkProp so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x0600860C RID: 34316 RVA: 0x000BF480 File Offset: 0x000BD680
		public void SetRepresentation(vtkCameraPathRepresentation r)
		{
			vtkCameraPathWidget.vtkCameraPathWidget_SetRepresentation_10(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B53 RID: 2899
		public new const string MRFullTypeName = "Kitware.VTK.vtkCameraPathWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B54 RID: 2900
		public new static readonly string MRClassNameKey = "class vtkCameraPathWidget";
	}
}
