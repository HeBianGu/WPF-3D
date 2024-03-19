using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLogoWidget
	/// </summary>
	/// <remarks>
	///    2D widget for placing and manipulating a logo
	///
	/// This class provides support for interactively displaying and manipulating
	/// a logo. Logos are defined by an image; this widget simply allows you to
	/// interactively place and resize the image logo. To use this widget, simply
	/// create a vtkLogoRepresentation (or subclass) and associate it with the
	/// vtkLogoWidget.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBorderWidget
	/// </seealso>
	// Token: 0x0200033C RID: 828
	public class vtkLogoWidget : vtkBorderWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600964B RID: 38475 RVA: 0x000D4EC7 File Offset: 0x000D30C7
		static vtkLogoWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLogoWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLogoWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600964C RID: 38476 RVA: 0x000D4EEF File Offset: 0x000D30EF
		public vtkLogoWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600964D RID: 38477
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLogoWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600964E RID: 38478 RVA: 0x000D4F00 File Offset: 0x000D3100
		public new static vtkLogoWidget New()
		{
			vtkLogoWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLogoWidget.vtkLogoWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLogoWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600964F RID: 38479 RVA: 0x000D4F54 File Offset: 0x000D3154
		public vtkLogoWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLogoWidget.vtkLogoWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009650 RID: 38480 RVA: 0x000D4F98 File Offset: 0x000D3198
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009651 RID: 38481
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLogoWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06009652 RID: 38482 RVA: 0x000D4FA3 File Offset: 0x000D31A3
		public override void CreateDefaultRepresentation()
		{
			vtkLogoWidget.vtkLogoWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009653 RID: 38483
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLogoWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009654 RID: 38484 RVA: 0x000D4FB4 File Offset: 0x000D31B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLogoWidget.vtkLogoWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06009655 RID: 38485
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLogoWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009656 RID: 38486 RVA: 0x000D4FD4 File Offset: 0x000D31D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLogoWidget.vtkLogoWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06009657 RID: 38487
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLogoWidget_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06009658 RID: 38488 RVA: 0x000D4FF0 File Offset: 0x000D31F0
		public override int IsA(string type)
		{
			return vtkLogoWidget.vtkLogoWidget_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06009659 RID: 38489
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLogoWidget_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x0600965A RID: 38490 RVA: 0x000D5010 File Offset: 0x000D3210
		public new static int IsTypeOf(string type)
		{
			return vtkLogoWidget.vtkLogoWidget_IsTypeOf_05(type);
		}

		// Token: 0x0600965B RID: 38491
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLogoWidget_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x0600965C RID: 38492 RVA: 0x000D502C File Offset: 0x000D322C
		public new vtkLogoWidget NewInstance()
		{
			vtkLogoWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLogoWidget.vtkLogoWidget_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLogoWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600965D RID: 38493
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLogoWidget_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x0600965E RID: 38494 RVA: 0x000D5088 File Offset: 0x000D3288
		public new static vtkLogoWidget SafeDownCast(vtkObjectBase o)
		{
			vtkLogoWidget vtkLogoWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLogoWidget.vtkLogoWidget_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLogoWidget = (vtkLogoWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLogoWidget.Register(null);
				}
			}
			return vtkLogoWidget;
		}

		// Token: 0x0600965F RID: 38495
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLogoWidget_SetRepresentation_09(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06009660 RID: 38496 RVA: 0x000D5108 File Offset: 0x000D3308
		public void SetRepresentation(vtkLogoRepresentation r)
		{
			vtkLogoWidget.vtkLogoWidget_SetRepresentation_09(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C54 RID: 3156
		public new const string MRFullTypeName = "Kitware.VTK.vtkLogoWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C55 RID: 3157
		public new static readonly string MRClassNameKey = "class vtkLogoWidget";
	}
}
