using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContextTransform
	/// </summary>
	/// <remarks>
	///    all children of this item are transformed
	/// by the vtkTransform2D of this item.
	///
	///
	/// This class can be used to transform all child items of this class. The
	/// default transform is the identity.
	/// </remarks>
	// Token: 0x020007B1 RID: 1969
	public class vtkContextTransform : vtkAbstractContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014375 RID: 82805 RVA: 0x001C924F File Offset: 0x001C744F
		static vtkContextTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContextTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014376 RID: 82806 RVA: 0x001C9277 File Offset: 0x001C7477
		public vtkContextTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014377 RID: 82807
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a vtkContextTransform object.
		/// </summary>
		// Token: 0x06014378 RID: 82808 RVA: 0x001C9288 File Offset: 0x001C7488
		public new static vtkContextTransform New()
		{
			vtkContextTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextTransform.vtkContextTransform_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a vtkContextTransform object.
		/// </summary>
		// Token: 0x06014379 RID: 82809 RVA: 0x001C92DC File Offset: 0x001C74DC
		public vtkContextTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkContextTransform.vtkContextTransform_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601437A RID: 82810 RVA: 0x001C9320 File Offset: 0x001C7520
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601437B RID: 82811
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextTransform_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601437C RID: 82812 RVA: 0x001C932C File Offset: 0x001C752C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContextTransform.vtkContextTransform_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601437D RID: 82813
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextTransform_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601437E RID: 82814 RVA: 0x001C934C File Offset: 0x001C754C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContextTransform.vtkContextTransform_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601437F RID: 82815
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextTransform_GetPanModifier_03(HandleRef pThis);

		/// <summary>
		/// The modifier from vtkContextMouseEvent to use for panning.
		/// Default is vtkContextMouseEvent::NO_MODIFIER.
		/// </summary>
		// Token: 0x06014380 RID: 82816 RVA: 0x001C9368 File Offset: 0x001C7568
		public virtual int GetPanModifier()
		{
			return vtkContextTransform.vtkContextTransform_GetPanModifier_03(base.GetCppThis());
		}

		// Token: 0x06014381 RID: 82817
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextTransform_GetPanMouseButton_04(HandleRef pThis);

		/// <summary>
		/// The mouse button from vtkContextMouseEvent to use for panning.
		/// Default is vtkContextMouseEvent::LEFT_BUTTON.
		/// </summary>
		// Token: 0x06014382 RID: 82818 RVA: 0x001C9388 File Offset: 0x001C7588
		public virtual int GetPanMouseButton()
		{
			return vtkContextTransform.vtkContextTransform_GetPanMouseButton_04(base.GetCppThis());
		}

		// Token: 0x06014383 RID: 82819
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContextTransform_GetPanYOnMouseWheel_05(HandleRef pThis);

		/// <summary>
		/// Whether to pan in the Y direction on mouse wheels. Default is false.
		/// </summary>
		// Token: 0x06014384 RID: 82820 RVA: 0x001C93A8 File Offset: 0x001C75A8
		public virtual bool GetPanYOnMouseWheel()
		{
			return vtkContextTransform.vtkContextTransform_GetPanYOnMouseWheel_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06014385 RID: 82821
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextTransform_GetSecondaryPanModifier_06(HandleRef pThis);

		/// <summary>
		/// A secondary modifier from vtkContextMouseEvent to use for panning.
		/// Default is vtkContextMouseEvent::NO_MODIFIER.
		/// </summary>
		// Token: 0x06014386 RID: 82822 RVA: 0x001C93D0 File Offset: 0x001C75D0
		public virtual int GetSecondaryPanModifier()
		{
			return vtkContextTransform.vtkContextTransform_GetSecondaryPanModifier_06(base.GetCppThis());
		}

		// Token: 0x06014387 RID: 82823
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextTransform_GetSecondaryPanMouseButton_07(HandleRef pThis);

		/// <summary>
		/// A secondary mouse button from vtkContextMouseEvent to use for panning.
		/// Default is vtkContextMouseEvent::NO_BUTTON (disabled).
		/// </summary>
		// Token: 0x06014388 RID: 82824 RVA: 0x001C93F0 File Offset: 0x001C75F0
		public virtual int GetSecondaryPanMouseButton()
		{
			return vtkContextTransform.vtkContextTransform_GetSecondaryPanMouseButton_07(base.GetCppThis());
		}

		// Token: 0x06014389 RID: 82825
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextTransform_GetSecondaryZoomModifier_08(HandleRef pThis);

		/// <summary>
		/// A secondary modifier from vtkContextMouseEvent to use for panning.
		/// Default is vtkContextMouseEvent::SHIFT_MODIFIER.
		/// </summary>
		// Token: 0x0601438A RID: 82826 RVA: 0x001C9410 File Offset: 0x001C7610
		public virtual int GetSecondaryZoomModifier()
		{
			return vtkContextTransform.vtkContextTransform_GetSecondaryZoomModifier_08(base.GetCppThis());
		}

		// Token: 0x0601438B RID: 82827
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextTransform_GetSecondaryZoomMouseButton_09(HandleRef pThis);

		/// <summary>
		/// A secondary mouse button from vtkContextMouseEvent to use for panning.
		/// Default is vtkContextMouseEvent::LEFT_BUTTON.
		/// </summary>
		// Token: 0x0601438C RID: 82828 RVA: 0x001C9430 File Offset: 0x001C7630
		public virtual int GetSecondaryZoomMouseButton()
		{
			return vtkContextTransform.vtkContextTransform_GetSecondaryZoomMouseButton_09(base.GetCppThis());
		}

		// Token: 0x0601438D RID: 82829
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextTransform_GetTransform_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the vtkTransform2D that controls object transformation.
		/// </summary>
		// Token: 0x0601438E RID: 82830 RVA: 0x001C9450 File Offset: 0x001C7650
		public virtual vtkTransform2D GetTransform()
		{
			vtkTransform2D vtkTransform2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextTransform.vtkContextTransform_GetTransform_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform2D = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform2D.Register(null);
				}
			}
			return vtkTransform2D;
		}

		// Token: 0x0601438F RID: 82831
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextTransform_GetZoomModifier_11(HandleRef pThis);

		/// <summary>
		/// The modifier from vtkContextMouseEvent to use for panning.
		/// Default is vtkContextMouseEvent::NO_MODIFIER.
		/// </summary>
		// Token: 0x06014390 RID: 82832 RVA: 0x001C94C0 File Offset: 0x001C76C0
		public virtual int GetZoomModifier()
		{
			return vtkContextTransform.vtkContextTransform_GetZoomModifier_11(base.GetCppThis());
		}

		// Token: 0x06014391 RID: 82833
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextTransform_GetZoomMouseButton_12(HandleRef pThis);

		/// <summary>
		/// The mouse button from vtkContextMouseEvent to use for panning.
		/// Default is vtkContextMouseEvent::RIGHT_BUTTON.
		/// </summary>
		// Token: 0x06014392 RID: 82834 RVA: 0x001C94E0 File Offset: 0x001C76E0
		public virtual int GetZoomMouseButton()
		{
			return vtkContextTransform.vtkContextTransform_GetZoomMouseButton_12(base.GetCppThis());
		}

		// Token: 0x06014393 RID: 82835
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContextTransform_GetZoomOnMouseWheel_13(HandleRef pThis);

		/// <summary>
		/// Whether to zoom on mouse wheels. Default is true.
		/// </summary>
		// Token: 0x06014394 RID: 82836 RVA: 0x001C9500 File Offset: 0x001C7700
		public virtual bool GetZoomOnMouseWheel()
		{
			return vtkContextTransform.vtkContextTransform_GetZoomOnMouseWheel_13(base.GetCppThis()) != 0;
		}

		// Token: 0x06014395 RID: 82837
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_Identity_14(HandleRef pThis);

		/// <summary>
		/// Reset the transform to the identity transformation.
		/// </summary>
		// Token: 0x06014396 RID: 82838 RVA: 0x001C9526 File Offset: 0x001C7726
		public virtual void Identity()
		{
			vtkContextTransform.vtkContextTransform_Identity_14(base.GetCppThis());
		}

		// Token: 0x06014397 RID: 82839
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextTransform_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014398 RID: 82840 RVA: 0x001C9538 File Offset: 0x001C7738
		public override int IsA(string type)
		{
			return vtkContextTransform.vtkContextTransform_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06014399 RID: 82841
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextTransform_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601439A RID: 82842 RVA: 0x001C9558 File Offset: 0x001C7758
		public new static int IsTypeOf(string type)
		{
			return vtkContextTransform.vtkContextTransform_IsTypeOf_16(type);
		}

		// Token: 0x0601439B RID: 82843
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextTransform_MapFromParent_17(HandleRef pThis, HandleRef point, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Transforms a point from the parent coordinate system.
		/// </summary>
		// Token: 0x0601439C RID: 82844 RVA: 0x001C9574 File Offset: 0x001C7774
		public override vtkVector2f MapFromParent(vtkVector2f point)
		{
			vtkVector2f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextTransform.vtkContextTransform_MapFromParent_17(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601439D RID: 82845
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextTransform_MapToParent_18(HandleRef pThis, HandleRef point, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Transforms a point to the parent coordinate system.
		/// </summary>
		// Token: 0x0601439E RID: 82846 RVA: 0x001C95E4 File Offset: 0x001C77E4
		public override vtkVector2f MapToParent(vtkVector2f point)
		{
			vtkVector2f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextTransform.vtkContextTransform_MapToParent_18(base.GetCppThis(), (point == null) ? default(HandleRef) : point.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601439F RID: 82847
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextTransform_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060143A0 RID: 82848 RVA: 0x001C9654 File Offset: 0x001C7854
		public new vtkContextTransform NewInstance()
		{
			vtkContextTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextTransform.vtkContextTransform_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060143A1 RID: 82849
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContextTransform_Paint_21(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the item, called whenever the item needs to be drawn.
		/// </summary>
		// Token: 0x060143A2 RID: 82850 RVA: 0x001C96B0 File Offset: 0x001C78B0
		public override bool Paint(vtkContext2D painter)
		{
			return vtkContextTransform.vtkContextTransform_Paint_21(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060143A3 RID: 82851
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_PanYOnMouseWheelOff_22(HandleRef pThis);

		/// <summary>
		/// Whether to pan in the Y direction on mouse wheels. Default is false.
		/// </summary>
		// Token: 0x060143A4 RID: 82852 RVA: 0x001C96EB File Offset: 0x001C78EB
		public virtual void PanYOnMouseWheelOff()
		{
			vtkContextTransform.vtkContextTransform_PanYOnMouseWheelOff_22(base.GetCppThis());
		}

		// Token: 0x060143A5 RID: 82853
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_PanYOnMouseWheelOn_23(HandleRef pThis);

		/// <summary>
		/// Whether to pan in the Y direction on mouse wheels. Default is false.
		/// </summary>
		// Token: 0x060143A6 RID: 82854 RVA: 0x001C96FA File Offset: 0x001C78FA
		public virtual void PanYOnMouseWheelOn()
		{
			vtkContextTransform.vtkContextTransform_PanYOnMouseWheelOn_23(base.GetCppThis());
		}

		// Token: 0x060143A7 RID: 82855
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_Rotate_24(HandleRef pThis, float angle);

		/// <summary>
		/// Rotate the item by the specified angle.
		/// </summary>
		// Token: 0x060143A8 RID: 82856 RVA: 0x001C9709 File Offset: 0x001C7909
		public virtual void Rotate(float angle)
		{
			vtkContextTransform.vtkContextTransform_Rotate_24(base.GetCppThis(), angle);
		}

		// Token: 0x060143A9 RID: 82857
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextTransform_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060143AA RID: 82858 RVA: 0x001C971C File Offset: 0x001C791C
		public new static vtkContextTransform SafeDownCast(vtkObjectBase o)
		{
			vtkContextTransform vtkContextTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextTransform.vtkContextTransform_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextTransform = (vtkContextTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextTransform.Register(null);
				}
			}
			return vtkContextTransform;
		}

		// Token: 0x060143AB RID: 82859
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_Scale_26(HandleRef pThis, float dx, float dy);

		/// <summary>
		/// Scale the item by the specified amounts dx and dy in the x and y
		/// directions.
		/// </summary>
		// Token: 0x060143AC RID: 82860 RVA: 0x001C979B File Offset: 0x001C799B
		public virtual void Scale(float dx, float dy)
		{
			vtkContextTransform.vtkContextTransform_Scale_26(base.GetCppThis(), dx, dy);
		}

		// Token: 0x060143AD RID: 82861
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_SetPanModifier_27(HandleRef pThis, int _arg);

		/// <summary>
		/// The modifier from vtkContextMouseEvent to use for panning.
		/// Default is vtkContextMouseEvent::NO_MODIFIER.
		/// </summary>
		// Token: 0x060143AE RID: 82862 RVA: 0x001C97AC File Offset: 0x001C79AC
		public virtual void SetPanModifier(int _arg)
		{
			vtkContextTransform.vtkContextTransform_SetPanModifier_27(base.GetCppThis(), _arg);
		}

		// Token: 0x060143AF RID: 82863
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_SetPanMouseButton_28(HandleRef pThis, int _arg);

		/// <summary>
		/// The mouse button from vtkContextMouseEvent to use for panning.
		/// Default is vtkContextMouseEvent::LEFT_BUTTON.
		/// </summary>
		// Token: 0x060143B0 RID: 82864 RVA: 0x001C97BC File Offset: 0x001C79BC
		public virtual void SetPanMouseButton(int _arg)
		{
			vtkContextTransform.vtkContextTransform_SetPanMouseButton_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060143B1 RID: 82865
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_SetPanYOnMouseWheel_29(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to pan in the Y direction on mouse wheels. Default is false.
		/// </summary>
		// Token: 0x060143B2 RID: 82866 RVA: 0x001C97CC File Offset: 0x001C79CC
		public virtual void SetPanYOnMouseWheel(bool _arg)
		{
			vtkContextTransform.vtkContextTransform_SetPanYOnMouseWheel_29(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060143B3 RID: 82867
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_SetSecondaryPanModifier_30(HandleRef pThis, int _arg);

		/// <summary>
		/// A secondary modifier from vtkContextMouseEvent to use for panning.
		/// Default is vtkContextMouseEvent::NO_MODIFIER.
		/// </summary>
		// Token: 0x060143B4 RID: 82868 RVA: 0x001C97E4 File Offset: 0x001C79E4
		public virtual void SetSecondaryPanModifier(int _arg)
		{
			vtkContextTransform.vtkContextTransform_SetSecondaryPanModifier_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060143B5 RID: 82869
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_SetSecondaryPanMouseButton_31(HandleRef pThis, int _arg);

		/// <summary>
		/// A secondary mouse button from vtkContextMouseEvent to use for panning.
		/// Default is vtkContextMouseEvent::NO_BUTTON (disabled).
		/// </summary>
		// Token: 0x060143B6 RID: 82870 RVA: 0x001C97F4 File Offset: 0x001C79F4
		public virtual void SetSecondaryPanMouseButton(int _arg)
		{
			vtkContextTransform.vtkContextTransform_SetSecondaryPanMouseButton_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060143B7 RID: 82871
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_SetSecondaryZoomModifier_32(HandleRef pThis, int _arg);

		/// <summary>
		/// A secondary modifier from vtkContextMouseEvent to use for panning.
		/// Default is vtkContextMouseEvent::SHIFT_MODIFIER.
		/// </summary>
		// Token: 0x060143B8 RID: 82872 RVA: 0x001C9804 File Offset: 0x001C7A04
		public virtual void SetSecondaryZoomModifier(int _arg)
		{
			vtkContextTransform.vtkContextTransform_SetSecondaryZoomModifier_32(base.GetCppThis(), _arg);
		}

		// Token: 0x060143B9 RID: 82873
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_SetSecondaryZoomMouseButton_33(HandleRef pThis, int _arg);

		/// <summary>
		/// A secondary mouse button from vtkContextMouseEvent to use for panning.
		/// Default is vtkContextMouseEvent::LEFT_BUTTON.
		/// </summary>
		// Token: 0x060143BA RID: 82874 RVA: 0x001C9814 File Offset: 0x001C7A14
		public virtual void SetSecondaryZoomMouseButton(int _arg)
		{
			vtkContextTransform.vtkContextTransform_SetSecondaryZoomMouseButton_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060143BB RID: 82875
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_SetZoomModifier_34(HandleRef pThis, int _arg);

		/// <summary>
		/// The modifier from vtkContextMouseEvent to use for panning.
		/// Default is vtkContextMouseEvent::NO_MODIFIER.
		/// </summary>
		// Token: 0x060143BC RID: 82876 RVA: 0x001C9824 File Offset: 0x001C7A24
		public virtual void SetZoomModifier(int _arg)
		{
			vtkContextTransform.vtkContextTransform_SetZoomModifier_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060143BD RID: 82877
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_SetZoomMouseButton_35(HandleRef pThis, int _arg);

		/// <summary>
		/// The mouse button from vtkContextMouseEvent to use for panning.
		/// Default is vtkContextMouseEvent::RIGHT_BUTTON.
		/// </summary>
		// Token: 0x060143BE RID: 82878 RVA: 0x001C9834 File Offset: 0x001C7A34
		public virtual void SetZoomMouseButton(int _arg)
		{
			vtkContextTransform.vtkContextTransform_SetZoomMouseButton_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060143BF RID: 82879
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_SetZoomOnMouseWheel_36(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to zoom on mouse wheels. Default is true.
		/// </summary>
		// Token: 0x060143C0 RID: 82880 RVA: 0x001C9844 File Offset: 0x001C7A44
		public virtual void SetZoomOnMouseWheel(bool _arg)
		{
			vtkContextTransform.vtkContextTransform_SetZoomOnMouseWheel_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060143C1 RID: 82881
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_Translate_37(HandleRef pThis, float dx, float dy);

		/// <summary>
		/// Translate the item by the specified amounts dx and dy in the x and y
		/// directions.
		/// </summary>
		// Token: 0x060143C2 RID: 82882 RVA: 0x001C985C File Offset: 0x001C7A5C
		public virtual void Translate(float dx, float dy)
		{
			vtkContextTransform.vtkContextTransform_Translate_37(base.GetCppThis(), dx, dy);
		}

		// Token: 0x060143C3 RID: 82883
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_Update_38(HandleRef pThis);

		/// <summary>
		/// Perform any updates to the item that may be necessary before rendering.
		/// The scene should take care of calling this on all items before their
		/// Paint function is invoked.
		/// </summary>
		// Token: 0x060143C4 RID: 82884 RVA: 0x001C986D File Offset: 0x001C7A6D
		public override void Update()
		{
			vtkContextTransform.vtkContextTransform_Update_38(base.GetCppThis());
		}

		// Token: 0x060143C5 RID: 82885
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_ZoomOnMouseWheelOff_39(HandleRef pThis);

		/// <summary>
		/// Whether to zoom on mouse wheels. Default is true.
		/// </summary>
		// Token: 0x060143C6 RID: 82886 RVA: 0x001C987C File Offset: 0x001C7A7C
		public virtual void ZoomOnMouseWheelOff()
		{
			vtkContextTransform.vtkContextTransform_ZoomOnMouseWheelOff_39(base.GetCppThis());
		}

		// Token: 0x060143C7 RID: 82887
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextTransform_ZoomOnMouseWheelOn_40(HandleRef pThis);

		/// <summary>
		/// Whether to zoom on mouse wheels. Default is true.
		/// </summary>
		// Token: 0x060143C8 RID: 82888 RVA: 0x001C988B File Offset: 0x001C7A8B
		public virtual void ZoomOnMouseWheelOn()
		{
			vtkContextTransform.vtkContextTransform_ZoomOnMouseWheelOn_40(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001771 RID: 6001
		public new const string MRFullTypeName = "Kitware.VTK.vtkContextTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001772 RID: 6002
		public new static readonly string MRClassNameKey = "class vtkContextTransform";
	}
}
