using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTensorProbeWidget
	/// </summary>
	/// <remarks>
	///    a widget to probe tensors on a polyline
	///
	/// The class is used to probe tensors on a trajectory. The representation
	/// (vtkTensorProbeRepresentation) is free to choose its own method of
	/// rendering the tensors. For instance vtkEllipsoidTensorProbeRepresentation
	/// renders the tensors as ellipsoids. The interactions of the widget are
	/// controlled by the left mouse button. A left click on the tensor selects
	/// it. It can dragged around the trajectory to probe the tensors on it.
	///
	/// For instance dragging the ellipsoid around with
	/// vtkEllipsoidTensorProbeRepresentation will manifest itself with the
	/// ellipsoid shape changing as needed along the trajectory.
	/// </remarks>
	// Token: 0x02000380 RID: 896
	public class vtkTensorProbeWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A341 RID: 41793 RVA: 0x000E765F File Offset: 0x000E585F
		static vtkTensorProbeWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTensorProbeWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTensorProbeWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A342 RID: 41794 RVA: 0x000E7687 File Offset: 0x000E5887
		public vtkTensorProbeWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A343 RID: 41795
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorProbeWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600A344 RID: 41796 RVA: 0x000E7698 File Offset: 0x000E5898
		public new static vtkTensorProbeWidget New()
		{
			vtkTensorProbeWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorProbeWidget.vtkTensorProbeWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTensorProbeWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600A345 RID: 41797 RVA: 0x000E76EC File Offset: 0x000E58EC
		public vtkTensorProbeWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTensorProbeWidget.vtkTensorProbeWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A346 RID: 41798 RVA: 0x000E7730 File Offset: 0x000E5930
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A347 RID: 41799
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorProbeWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// See vtkWidgetRepresentation for details.
		/// </summary>
		// Token: 0x0600A348 RID: 41800 RVA: 0x000E773B File Offset: 0x000E593B
		public override void CreateDefaultRepresentation()
		{
			vtkTensorProbeWidget.vtkTensorProbeWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600A349 RID: 41801
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTensorProbeWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x0600A34A RID: 41802 RVA: 0x000E774C File Offset: 0x000E594C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTensorProbeWidget.vtkTensorProbeWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600A34B RID: 41803
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTensorProbeWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x0600A34C RID: 41804 RVA: 0x000E776C File Offset: 0x000E596C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTensorProbeWidget.vtkTensorProbeWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600A34D RID: 41805
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorProbeWidget_GetTensorProbeRepresentation_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkTensorProbeRepresentation.
		/// </summary>
		// Token: 0x0600A34E RID: 41806 RVA: 0x000E7788 File Offset: 0x000E5988
		public vtkTensorProbeRepresentation GetTensorProbeRepresentation()
		{
			vtkTensorProbeRepresentation vtkTensorProbeRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorProbeWidget.vtkTensorProbeWidget_GetTensorProbeRepresentation_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTensorProbeRepresentation = (vtkTensorProbeRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTensorProbeRepresentation.Register(null);
				}
			}
			return vtkTensorProbeRepresentation;
		}

		// Token: 0x0600A34F RID: 41807
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorProbeWidget_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x0600A350 RID: 41808 RVA: 0x000E77F8 File Offset: 0x000E59F8
		public override int IsA(string type)
		{
			return vtkTensorProbeWidget.vtkTensorProbeWidget_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600A351 RID: 41809
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorProbeWidget_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x0600A352 RID: 41810 RVA: 0x000E7818 File Offset: 0x000E5A18
		public new static int IsTypeOf(string type)
		{
			return vtkTensorProbeWidget.vtkTensorProbeWidget_IsTypeOf_06(type);
		}

		// Token: 0x0600A353 RID: 41811
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorProbeWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x0600A354 RID: 41812 RVA: 0x000E7834 File Offset: 0x000E5A34
		public new vtkTensorProbeWidget NewInstance()
		{
			vtkTensorProbeWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorProbeWidget.vtkTensorProbeWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTensorProbeWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A355 RID: 41813
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorProbeWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class macros.
		/// </summary>
		// Token: 0x0600A356 RID: 41814 RVA: 0x000E7890 File Offset: 0x000E5A90
		public new static vtkTensorProbeWidget SafeDownCast(vtkObjectBase o)
		{
			vtkTensorProbeWidget vtkTensorProbeWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorProbeWidget.vtkTensorProbeWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTensorProbeWidget = (vtkTensorProbeWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTensorProbeWidget.Register(null);
				}
			}
			return vtkTensorProbeWidget;
		}

		// Token: 0x0600A357 RID: 41815
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorProbeWidget_SetRepresentation_10(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x0600A358 RID: 41816 RVA: 0x000E7910 File Offset: 0x000E5B10
		public void SetRepresentation(vtkTensorProbeRepresentation r)
		{
			vtkTensorProbeWidget.vtkTensorProbeWidget_SetRepresentation_10(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D0E RID: 3342
		public new const string MRFullTypeName = "Kitware.VTK.vtkTensorProbeWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D0F RID: 3343
		public new static readonly string MRClassNameKey = "class vtkTensorProbeWidget";
	}
}
