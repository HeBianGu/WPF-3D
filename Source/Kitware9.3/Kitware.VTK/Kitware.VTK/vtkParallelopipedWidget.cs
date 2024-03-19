using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParallelopipedWidget
	/// </summary>
	/// <remarks>
	///    a widget to manipulate 3D parallelopipeds
	///
	///
	/// This widget was designed with the aim of visualizing / probing cuts on
	/// a skewed image data / structured grid.
	///
	/// @par Interaction:
	/// The widget allows you to create a parallelopiped (defined by 8 handles).
	/// The widget is initially placed by using the "PlaceWidget" method in the
	/// representation class. After the widget has been created, the following
	/// interactions may be used to manipulate it :
	/// 1) Click on a handle and drag it around moves the handle in space, while
	///    keeping the same axis alignment of the parallelopiped
	/// 2) Dragging a handle with the shift button pressed resizes the piped
	///    along an axis.
	/// 3) Control-click on a handle creates a chair at that position. (A chair
	///    is a depression in the piped that allows you to visualize cuts in the
	///    volume).
	/// 4) Clicking on a chair and dragging it around moves the chair within the
	///    piped.
	/// 5) Shift-click on the piped enables you to translate it.
	///
	/// </remarks>
	// Token: 0x0200034B RID: 843
	public class vtkParallelopipedWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009929 RID: 39209 RVA: 0x000D92A4 File Offset: 0x000D74A4
		static vtkParallelopipedWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelopipedWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelopipedWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600992A RID: 39210 RVA: 0x000D92CC File Offset: 0x000D74CC
		public vtkParallelopipedWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600992B RID: 39211
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelopipedWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600992C RID: 39212 RVA: 0x000D92DC File Offset: 0x000D74DC
		public new static vtkParallelopipedWidget New()
		{
			vtkParallelopipedWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelopipedWidget.vtkParallelopipedWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelopipedWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600992D RID: 39213 RVA: 0x000D9330 File Offset: 0x000D7530
		public vtkParallelopipedWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParallelopipedWidget.vtkParallelopipedWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600992E RID: 39214 RVA: 0x000D9374 File Offset: 0x000D7574
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600992F RID: 39215
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06009930 RID: 39216 RVA: 0x000D937F File Offset: 0x000D757F
		public override void CreateDefaultRepresentation()
		{
			vtkParallelopipedWidget.vtkParallelopipedWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009931 RID: 39217
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedWidget_EnableChairCreationOff_02(HandleRef pThis);

		/// <summary>
		/// Enable/disable the creation of a chair on this widget. If off,
		/// chairs cannot be created.
		/// </summary>
		// Token: 0x06009932 RID: 39218 RVA: 0x000D938E File Offset: 0x000D758E
		public virtual void EnableChairCreationOff()
		{
			vtkParallelopipedWidget.vtkParallelopipedWidget_EnableChairCreationOff_02(base.GetCppThis());
		}

		// Token: 0x06009933 RID: 39219
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedWidget_EnableChairCreationOn_03(HandleRef pThis);

		/// <summary>
		/// Enable/disable the creation of a chair on this widget. If off,
		/// chairs cannot be created.
		/// </summary>
		// Token: 0x06009934 RID: 39220 RVA: 0x000D939D File Offset: 0x000D759D
		public virtual void EnableChairCreationOn()
		{
			vtkParallelopipedWidget.vtkParallelopipedWidget_EnableChairCreationOn_03(base.GetCppThis());
		}

		// Token: 0x06009935 RID: 39221
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelopipedWidget_GetEnableChairCreation_04(HandleRef pThis);

		/// <summary>
		/// Enable/disable the creation of a chair on this widget. If off,
		/// chairs cannot be created.
		/// </summary>
		// Token: 0x06009936 RID: 39222 RVA: 0x000D93AC File Offset: 0x000D75AC
		public virtual int GetEnableChairCreation()
		{
			return vtkParallelopipedWidget.vtkParallelopipedWidget_GetEnableChairCreation_04(base.GetCppThis());
		}

		// Token: 0x06009937 RID: 39223
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelopipedWidget_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009938 RID: 39224 RVA: 0x000D93CC File Offset: 0x000D75CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParallelopipedWidget.vtkParallelopipedWidget_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06009939 RID: 39225
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelopipedWidget_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600993A RID: 39226 RVA: 0x000D93EC File Offset: 0x000D75EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParallelopipedWidget.vtkParallelopipedWidget_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600993B RID: 39227
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelopipedWidget_GetParallelopipedRepresentation_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkParallelopipedRepresentation.
		/// </summary>
		// Token: 0x0600993C RID: 39228 RVA: 0x000D9408 File Offset: 0x000D7608
		public vtkParallelopipedRepresentation GetParallelopipedRepresentation()
		{
			vtkParallelopipedRepresentation vtkParallelopipedRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelopipedWidget.vtkParallelopipedWidget_GetParallelopipedRepresentation_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelopipedRepresentation = (vtkParallelopipedRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelopipedRepresentation.Register(null);
				}
			}
			return vtkParallelopipedRepresentation;
		}

		// Token: 0x0600993D RID: 39229
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelopipedWidget_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600993E RID: 39230 RVA: 0x000D9478 File Offset: 0x000D7678
		public override int IsA(string type)
		{
			return vtkParallelopipedWidget.vtkParallelopipedWidget_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600993F RID: 39231
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelopipedWidget_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009940 RID: 39232 RVA: 0x000D9498 File Offset: 0x000D7698
		public new static int IsTypeOf(string type)
		{
			return vtkParallelopipedWidget.vtkParallelopipedWidget_IsTypeOf_09(type);
		}

		// Token: 0x06009941 RID: 39233
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelopipedWidget_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009942 RID: 39234 RVA: 0x000D94B4 File Offset: 0x000D76B4
		public new vtkParallelopipedWidget NewInstance()
		{
			vtkParallelopipedWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelopipedWidget.vtkParallelopipedWidget_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelopipedWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009943 RID: 39235
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelopipedWidget_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009944 RID: 39236 RVA: 0x000D9510 File Offset: 0x000D7710
		public new static vtkParallelopipedWidget SafeDownCast(vtkObjectBase o)
		{
			vtkParallelopipedWidget vtkParallelopipedWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelopipedWidget.vtkParallelopipedWidget_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelopipedWidget = (vtkParallelopipedWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelopipedWidget.Register(null);
				}
			}
			return vtkParallelopipedWidget;
		}

		// Token: 0x06009945 RID: 39237
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedWidget_SetEnableChairCreation_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable the creation of a chair on this widget. If off,
		/// chairs cannot be created.
		/// </summary>
		// Token: 0x06009946 RID: 39238 RVA: 0x000D958F File Offset: 0x000D778F
		public virtual void SetEnableChairCreation(int _arg)
		{
			vtkParallelopipedWidget.vtkParallelopipedWidget_SetEnableChairCreation_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06009947 RID: 39239
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedWidget_SetEnabled_14(HandleRef pThis, int arg0);

		/// <summary>
		/// Override the superclass method. This is a composite widget, (it internally
		/// consists of handle widgets). We will override the superclass method, so
		/// that we can pass the enabled state to the internal widgets as well.
		/// </summary>
		// Token: 0x06009948 RID: 39240 RVA: 0x000D959F File Offset: 0x000D779F
		public override void SetEnabled(int arg0)
		{
			vtkParallelopipedWidget.vtkParallelopipedWidget_SetEnabled_14(base.GetCppThis(), arg0);
		}

		// Token: 0x06009949 RID: 39241
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedWidget_SetProcessEvents_15(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods to change the whether the widget responds to interaction.
		/// Overridden to pass the state to component widgets.
		/// </summary>
		// Token: 0x0600994A RID: 39242 RVA: 0x000D95AF File Offset: 0x000D77AF
		public override void SetProcessEvents(int arg0)
		{
			vtkParallelopipedWidget.vtkParallelopipedWidget_SetProcessEvents_15(base.GetCppThis(), arg0);
		}

		// Token: 0x0600994B RID: 39243
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelopipedWidget_SetRepresentation_16(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x0600994C RID: 39244 RVA: 0x000D95C0 File Offset: 0x000D77C0
		public void SetRepresentation(vtkParallelopipedRepresentation r)
		{
			vtkParallelopipedWidget.vtkParallelopipedWidget_SetRepresentation_16(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C85 RID: 3205
		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelopipedWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C86 RID: 3206
		public new static readonly string MRClassNameKey = "class vtkParallelopipedWidget";
	}
}
