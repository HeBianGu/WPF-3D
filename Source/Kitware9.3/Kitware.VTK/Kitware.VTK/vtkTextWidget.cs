using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTextWidget
	/// </summary>
	/// <remarks>
	///    widget for placing text on overlay plane
	///
	/// This class provides support for interactively placing text on the 2D
	/// overlay plane. The text is defined by an instance of vtkTextActor. It uses
	/// the event bindings of its superclass (vtkBorderWidget). In addition, when
	/// the text is selected, the widget emits a WidgetActivateEvent that
	/// observers can watch for. This is useful for opening GUI dialogues to
	/// adjust font characteristics, etc. (Please see the superclass for a
	/// description of event bindings.)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBorderWidget vtkCaptionWidget
	/// </seealso>
	// Token: 0x02000389 RID: 905
	public class vtkTextWidget : vtkBorderWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A537 RID: 42295 RVA: 0x000EA4F3 File Offset: 0x000E86F3
		static vtkTextWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A538 RID: 42296 RVA: 0x000EA51B File Offset: 0x000E871B
		public vtkTextWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A539 RID: 42297
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x0600A53A RID: 42298 RVA: 0x000EA52C File Offset: 0x000E872C
		public new static vtkTextWidget New()
		{
			vtkTextWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextWidget.vtkTextWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x0600A53B RID: 42299 RVA: 0x000EA580 File Offset: 0x000E8780
		public vtkTextWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTextWidget.vtkTextWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A53C RID: 42300 RVA: 0x000EA5C4 File Offset: 0x000E87C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A53D RID: 42301
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x0600A53E RID: 42302 RVA: 0x000EA5CF File Offset: 0x000E87CF
		public override void CreateDefaultRepresentation()
		{
			vtkTextWidget.vtkTextWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600A53F RID: 42303
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600A540 RID: 42304 RVA: 0x000EA5E0 File Offset: 0x000E87E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTextWidget.vtkTextWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600A541 RID: 42305
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600A542 RID: 42306 RVA: 0x000EA600 File Offset: 0x000E8800
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTextWidget.vtkTextWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600A543 RID: 42307
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextWidget_GetTextActor_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a vtkTextActor to manage. This is a convenient, alternative
		/// method to specify the representation for the widget (i.e., used instead
		/// of SetRepresentation()). It internally creates a vtkTextRepresentation
		/// and then invokes vtkTextRepresentation::SetTextActor().
		/// </summary>
		// Token: 0x0600A544 RID: 42308 RVA: 0x000EA61C File Offset: 0x000E881C
		public vtkTextActor GetTextActor()
		{
			vtkTextActor vtkTextActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextWidget.vtkTextWidget_GetTextActor_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextActor = (vtkTextActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextActor.Register(null);
				}
			}
			return vtkTextActor;
		}

		// Token: 0x0600A545 RID: 42309
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextWidget_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600A546 RID: 42310 RVA: 0x000EA68C File Offset: 0x000E888C
		public override int IsA(string type)
		{
			return vtkTextWidget.vtkTextWidget_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600A547 RID: 42311
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextWidget_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600A548 RID: 42312 RVA: 0x000EA6AC File Offset: 0x000E88AC
		public new static int IsTypeOf(string type)
		{
			return vtkTextWidget.vtkTextWidget_IsTypeOf_06(type);
		}

		// Token: 0x0600A549 RID: 42313
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600A54A RID: 42314 RVA: 0x000EA6C8 File Offset: 0x000E88C8
		public new vtkTextWidget NewInstance()
		{
			vtkTextWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextWidget.vtkTextWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A54B RID: 42315
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600A54C RID: 42316 RVA: 0x000EA724 File Offset: 0x000E8924
		public new static vtkTextWidget SafeDownCast(vtkObjectBase o)
		{
			vtkTextWidget vtkTextWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextWidget.vtkTextWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextWidget = (vtkTextWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextWidget.Register(null);
				}
			}
			return vtkTextWidget;
		}

		// Token: 0x0600A54D RID: 42317
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextWidget_SetRepresentation_10(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x0600A54E RID: 42318 RVA: 0x000EA7A4 File Offset: 0x000E89A4
		public void SetRepresentation(vtkTextRepresentation r)
		{
			vtkTextWidget.vtkTextWidget_SetRepresentation_10(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		// Token: 0x0600A54F RID: 42319
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextWidget_SetTextActor_11(HandleRef pThis, HandleRef textActor);

		/// <summary>
		/// Specify a vtkTextActor to manage. This is a convenient, alternative
		/// method to specify the representation for the widget (i.e., used instead
		/// of SetRepresentation()). It internally creates a vtkTextRepresentation
		/// and then invokes vtkTextRepresentation::SetTextActor().
		/// </summary>
		// Token: 0x0600A550 RID: 42320 RVA: 0x000EA7D4 File Offset: 0x000E89D4
		public void SetTextActor(vtkTextActor textActor)
		{
			vtkTextWidget.vtkTextWidget_SetTextActor_11(base.GetCppThis(), (textActor == null) ? default(HandleRef) : textActor.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D29 RID: 3369
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D2A RID: 3370
		public new static readonly string MRClassNameKey = "class vtkTextWidget";
	}
}
