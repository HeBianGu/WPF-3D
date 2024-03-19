using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTooltipItem
	/// </summary>
	/// <remarks>
	///    takes care of drawing 2D axes
	///
	///
	/// The vtkTooltipItem is drawn in screen coordinates. It is used to display a
	/// tooltip on a scene, giving additional information about an element on the
	/// scene, such as in vtkChartXY. It takes care of ensuring that it draws itself
	/// within the bounds of the screen.
	/// </remarks>
	// Token: 0x020007B9 RID: 1977
	public class vtkTooltipItem : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601447E RID: 83070 RVA: 0x001CA9FD File Offset: 0x001C8BFD
		static vtkTooltipItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTooltipItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTooltipItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601447F RID: 83071 RVA: 0x001CAA25 File Offset: 0x001C8C25
		public vtkTooltipItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014480 RID: 83072
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTooltipItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x06014481 RID: 83073 RVA: 0x001CAA34 File Offset: 0x001C8C34
		public new static vtkTooltipItem New()
		{
			vtkTooltipItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTooltipItem.vtkTooltipItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTooltipItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x06014482 RID: 83074 RVA: 0x001CAA88 File Offset: 0x001C8C88
		public vtkTooltipItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTooltipItem.vtkTooltipItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014483 RID: 83075 RVA: 0x001CAACC File Offset: 0x001C8CCC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014484 RID: 83076
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTooltipItem_GetBrush_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to the vtkPen object.
		/// </summary>
		// Token: 0x06014485 RID: 83077 RVA: 0x001CAAD8 File Offset: 0x001C8CD8
		public virtual vtkBrush GetBrush()
		{
			vtkBrush vtkBrush = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTooltipItem.vtkTooltipItem_GetBrush_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBrush = (vtkBrush)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBrush.Register(null);
				}
			}
			return vtkBrush;
		}

		// Token: 0x06014486 RID: 83078
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTooltipItem_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014487 RID: 83079 RVA: 0x001CAB48 File Offset: 0x001C8D48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTooltipItem.vtkTooltipItem_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06014488 RID: 83080
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTooltipItem_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014489 RID: 83081 RVA: 0x001CAB68 File Offset: 0x001C8D68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTooltipItem.vtkTooltipItem_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601448A RID: 83082
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTooltipItem_GetPen_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to the vtkTextProperty object that controls the way the
		/// text is rendered.
		/// </summary>
		// Token: 0x0601448B RID: 83083 RVA: 0x001CAB84 File Offset: 0x001C8D84
		public virtual vtkPen GetPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTooltipItem.vtkTooltipItem_GetPen_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPen = (vtkPen)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPen.Register(null);
				}
			}
			return vtkPen;
		}

		// Token: 0x0601448C RID: 83084
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTooltipItem_GetPosition_05(HandleRef pThis);

		/// <summary>
		/// Get position of the axis (in pixels).
		/// </summary>
		// Token: 0x0601448D RID: 83085 RVA: 0x001CABF4 File Offset: 0x001C8DF4
		public virtual float[] GetPosition()
		{
			IntPtr intPtr = vtkTooltipItem.vtkTooltipItem_GetPosition_05(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601448E RID: 83086
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTooltipItem_GetPosition_06(HandleRef pThis, ref float _arg1, ref float _arg2);

		/// <summary>
		/// Get position of the axis (in pixels).
		/// </summary>
		// Token: 0x0601448F RID: 83087 RVA: 0x001CAC3C File Offset: 0x001C8E3C
		public virtual void GetPosition(ref float _arg1, ref float _arg2)
		{
			vtkTooltipItem.vtkTooltipItem_GetPosition_06(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06014490 RID: 83088
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTooltipItem_GetPosition_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get position of the axis (in pixels).
		/// </summary>
		// Token: 0x06014491 RID: 83089 RVA: 0x001CAC4D File Offset: 0x001C8E4D
		public virtual void GetPosition(IntPtr _arg)
		{
			vtkTooltipItem.vtkTooltipItem_GetPosition_07(base.GetCppThis(), _arg);
		}

		// Token: 0x06014492 RID: 83090
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTooltipItem_GetPositionVector_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get position of the axis (in pixels).
		/// </summary>
		// Token: 0x06014493 RID: 83091 RVA: 0x001CAC60 File Offset: 0x001C8E60
		public vtkVector2f GetPositionVector()
		{
			vtkVector2f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTooltipItem.vtkTooltipItem_GetPositionVector_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014494 RID: 83092
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkTooltipItem_GetText_09(HandleRef pThis);

		/// <summary>
		/// Get/set the text of the item.
		/// </summary>
		// Token: 0x06014495 RID: 83093 RVA: 0x001CACBC File Offset: 0x001C8EBC
		public virtual string GetText()
		{
			return vtkTooltipItem.vtkTooltipItem_GetText_09(base.GetCppThis());
		}

		// Token: 0x06014496 RID: 83094
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTooltipItem_GetTextProperties_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkTextProperty that governs how the tooltip text is displayed.
		/// </summary>
		// Token: 0x06014497 RID: 83095 RVA: 0x001CACDC File Offset: 0x001C8EDC
		public virtual vtkTextProperty GetTextProperties()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTooltipItem.vtkTooltipItem_GetTextProperties_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x06014498 RID: 83096
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTooltipItem_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014499 RID: 83097 RVA: 0x001CAD4C File Offset: 0x001C8F4C
		public override int IsA(string type)
		{
			return vtkTooltipItem.vtkTooltipItem_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0601449A RID: 83098
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTooltipItem_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601449B RID: 83099 RVA: 0x001CAD6C File Offset: 0x001C8F6C
		public new static int IsTypeOf(string type)
		{
			return vtkTooltipItem.vtkTooltipItem_IsTypeOf_12(type);
		}

		// Token: 0x0601449C RID: 83100
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTooltipItem_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601449D RID: 83101 RVA: 0x001CAD88 File Offset: 0x001C8F88
		public new vtkTooltipItem NewInstance()
		{
			vtkTooltipItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTooltipItem.vtkTooltipItem_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTooltipItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601449E RID: 83102
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTooltipItem_Paint_15(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the tooltip.
		/// </summary>
		// Token: 0x0601449F RID: 83103 RVA: 0x001CADE4 File Offset: 0x001C8FE4
		public override bool Paint(vtkContext2D painter)
		{
			return vtkTooltipItem.vtkTooltipItem_Paint_15(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060144A0 RID: 83104
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTooltipItem_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060144A1 RID: 83105 RVA: 0x001CAE20 File Offset: 0x001C9020
		public new static vtkTooltipItem SafeDownCast(vtkObjectBase o)
		{
			vtkTooltipItem vtkTooltipItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTooltipItem.vtkTooltipItem_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTooltipItem = (vtkTooltipItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTooltipItem.Register(null);
				}
			}
			return vtkTooltipItem;
		}

		// Token: 0x060144A2 RID: 83106
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTooltipItem_SetPosition_17(HandleRef pThis, float _arg1, float _arg2);

		/// <summary>
		/// Set the position of the tooltip (in pixels).
		/// </summary>
		// Token: 0x060144A3 RID: 83107 RVA: 0x001CAE9F File Offset: 0x001C909F
		public virtual void SetPosition(float _arg1, float _arg2)
		{
			vtkTooltipItem.vtkTooltipItem_SetPosition_17(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060144A4 RID: 83108
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTooltipItem_SetPosition_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the position of the tooltip (in pixels).
		/// </summary>
		// Token: 0x060144A5 RID: 83109 RVA: 0x001CAEB0 File Offset: 0x001C90B0
		public void SetPosition(IntPtr _arg)
		{
			vtkTooltipItem.vtkTooltipItem_SetPosition_18(base.GetCppThis(), _arg);
		}

		// Token: 0x060144A6 RID: 83110
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTooltipItem_SetPosition_19(HandleRef pThis, HandleRef pos);

		/// <summary>
		/// Set the position of the tooltip (in pixels).
		/// </summary>
		// Token: 0x060144A7 RID: 83111 RVA: 0x001CAEC0 File Offset: 0x001C90C0
		public void SetPosition(vtkVector2f pos)
		{
			vtkTooltipItem.vtkTooltipItem_SetPosition_19(base.GetCppThis(), (pos == null) ? default(HandleRef) : pos.GetCppThis());
		}

		// Token: 0x060144A8 RID: 83112
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTooltipItem_SetText_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string text);

		/// <summary>
		/// Get/set the text of the item.
		/// </summary>
		// Token: 0x060144A9 RID: 83113 RVA: 0x001CAEEF File Offset: 0x001C90EF
		public virtual void SetText(string text)
		{
			vtkTooltipItem.vtkTooltipItem_SetText_20(base.GetCppThis(), text);
		}

		// Token: 0x060144AA RID: 83114
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTooltipItem_Update_21(HandleRef pThis);

		/// <summary>
		/// Update the geometry of the tooltip.
		/// </summary>
		// Token: 0x060144AB RID: 83115 RVA: 0x001CAEFF File Offset: 0x001C90FF
		public override void Update()
		{
			vtkTooltipItem.vtkTooltipItem_Update_21(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400178C RID: 6028
		public new const string MRFullTypeName = "Kitware.VTK.vtkTooltipItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400178D RID: 6029
		public new static readonly string MRClassNameKey = "class vtkTooltipItem";
	}
}
