using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContinuousValueWidgetRepresentation
	/// </summary>
	/// <remarks>
	///    provide the representation for a continuous value
	///
	/// This class is used mainly as a superclass for continuous value widgets
	///
	/// </remarks>
	// Token: 0x020002F8 RID: 760
	public abstract class vtkContinuousValueWidgetRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600881C RID: 34844 RVA: 0x000C28AD File Offset: 0x000C0AAD
		static vtkContinuousValueWidgetRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContinuousValueWidgetRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContinuousValueWidgetRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600881D RID: 34845 RVA: 0x000C28D5 File Offset: 0x000C0AD5
		public vtkContinuousValueWidgetRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600881E RID: 34846 RVA: 0x000C28E3 File Offset: 0x000C0AE3
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600881F RID: 34847
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContinuousValueWidgetRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x06008820 RID: 34848 RVA: 0x000C28EE File Offset: 0x000C0AEE
		public override void BuildRepresentation()
		{
			vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008821 RID: 34849
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContinuousValueWidgetRepresentation_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008822 RID: 34850 RVA: 0x000C2900 File Offset: 0x000C0B00
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06008823 RID: 34851
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContinuousValueWidgetRepresentation_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008824 RID: 34852 RVA: 0x000C2920 File Offset: 0x000C0B20
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06008825 RID: 34853
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkContinuousValueWidgetRepresentation_GetValue_04(HandleRef pThis);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x06008826 RID: 34854 RVA: 0x000C293C File Offset: 0x000C0B3C
		public virtual double GetValue()
		{
			return vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_GetValue_04(base.GetCppThis());
		}

		// Token: 0x06008827 RID: 34855
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContinuousValueWidgetRepresentation_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008828 RID: 34856 RVA: 0x000C295C File Offset: 0x000C0B5C
		public override int IsA(string type)
		{
			return vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06008829 RID: 34857
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContinuousValueWidgetRepresentation_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600882A RID: 34858 RVA: 0x000C297C File Offset: 0x000C0B7C
		public new static int IsTypeOf(string type)
		{
			return vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_IsTypeOf_06(type);
		}

		// Token: 0x0600882B RID: 34859
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContinuousValueWidgetRepresentation_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600882C RID: 34860 RVA: 0x000C2998 File Offset: 0x000C0B98
		public new vtkContinuousValueWidgetRepresentation NewInstance()
		{
			vtkContinuousValueWidgetRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContinuousValueWidgetRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600882D RID: 34861
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContinuousValueWidgetRepresentation_PlaceWidget_08(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x0600882E RID: 34862 RVA: 0x000C29F2 File Offset: 0x000C0BF2
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_PlaceWidget_08(base.GetCppThis(), bounds);
		}

		// Token: 0x0600882F RID: 34863
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContinuousValueWidgetRepresentation_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008830 RID: 34864 RVA: 0x000C2A04 File Offset: 0x000C0C04
		public new static vtkContinuousValueWidgetRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkContinuousValueWidgetRepresentation vtkContinuousValueWidgetRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContinuousValueWidgetRepresentation = (vtkContinuousValueWidgetRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContinuousValueWidgetRepresentation.Register(null);
				}
			}
			return vtkContinuousValueWidgetRepresentation;
		}

		// Token: 0x06008831 RID: 34865
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContinuousValueWidgetRepresentation_SetValue_10(HandleRef pThis, double value);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x06008832 RID: 34866 RVA: 0x000C2A83 File Offset: 0x000C0C83
		public virtual void SetValue(double value)
		{
			vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_SetValue_10(base.GetCppThis(), value);
		}

		// Token: 0x06008833 RID: 34867
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContinuousValueWidgetRepresentation_StartWidgetInteraction_11(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x06008834 RID: 34868 RVA: 0x000C2A93 File Offset: 0x000C0C93
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_StartWidgetInteraction_11(base.GetCppThis(), eventPos);
		}

		// Token: 0x06008835 RID: 34869
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContinuousValueWidgetRepresentation_WidgetInteraction_12(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x06008836 RID: 34870 RVA: 0x000C2AA3 File Offset: 0x000C0CA3
		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkContinuousValueWidgetRepresentation.vtkContinuousValueWidgetRepresentation_WidgetInteraction_12(base.GetCppThis(), eventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B7A RID: 2938
		public new const string MRFullTypeName = "Kitware.VTK.vtkContinuousValueWidgetRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B7B RID: 2939
		public new static readonly string MRClassNameKey = "class vtkContinuousValueWidgetRepresentation";

		/// <summary>
		/// Methods to interface with the vtkSliderWidget. The PlaceWidget() method
		/// assumes that the parameter bounds[6] specifies the location in display
		/// space where the widget should be placed.
		/// </summary>
		// Token: 0x020002F9 RID: 761
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000B7D RID: 2941
			Adjusting = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000B7E RID: 2942
			Inside = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000B7F RID: 2943
			Outside = 0
		}
	}
}
