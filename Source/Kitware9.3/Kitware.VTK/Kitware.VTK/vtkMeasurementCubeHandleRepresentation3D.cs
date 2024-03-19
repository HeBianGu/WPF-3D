using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMeasurementCubeHandleRepresentation3D
	/// </summary>
	/// <remarks>
	///    represent a unit cube for measuring/comparing to data.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolygonalHandleRepresentation3D vtkHandleRepresentation vtkHandleWidget
	/// </seealso>
	// Token: 0x02000340 RID: 832
	public class vtkMeasurementCubeHandleRepresentation3D : vtkHandleRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060096D5 RID: 38613 RVA: 0x000D5BAF File Offset: 0x000D3DAF
		static vtkMeasurementCubeHandleRepresentation3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMeasurementCubeHandleRepresentation3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMeasurementCubeHandleRepresentation3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060096D6 RID: 38614 RVA: 0x000D5BD7 File Offset: 0x000D3DD7
		public vtkMeasurementCubeHandleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060096D7 RID: 38615
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060096D8 RID: 38616 RVA: 0x000D5BE8 File Offset: 0x000D3DE8
		public new static vtkMeasurementCubeHandleRepresentation3D New()
		{
			vtkMeasurementCubeHandleRepresentation3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMeasurementCubeHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060096D9 RID: 38617 RVA: 0x000D5C3C File Offset: 0x000D3E3C
		public vtkMeasurementCubeHandleRepresentation3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060096DA RID: 38618 RVA: 0x000D5C80 File Offset: 0x000D3E80
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060096DB RID: 38619
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_AdaptiveScalingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off adaptive scaling for the cube.
		/// </summary>
		// Token: 0x060096DC RID: 38620 RVA: 0x000D5C8B File Offset: 0x000D3E8B
		public virtual void AdaptiveScalingOff()
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_AdaptiveScalingOff_01(base.GetCppThis());
		}

		// Token: 0x060096DD RID: 38621
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_AdaptiveScalingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off adaptive scaling for the cube.
		/// </summary>
		// Token: 0x060096DE RID: 38622 RVA: 0x000D5C9A File Offset: 0x000D3E9A
		public virtual void AdaptiveScalingOn()
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_AdaptiveScalingOn_02(base.GetCppThis());
		}

		// Token: 0x060096DF RID: 38623
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_BuildRepresentation_03(HandleRef pThis);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x060096E0 RID: 38624 RVA: 0x000D5CA9 File Offset: 0x000D3EA9
		public override void BuildRepresentation()
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_BuildRepresentation_03(base.GetCppThis());
		}

		// Token: 0x060096E1 RID: 38625
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMeasurementCubeHandleRepresentation3D_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x060096E2 RID: 38626 RVA: 0x000D5CB8 File Offset: 0x000D3EB8
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_ComputeInteractionState_04(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x060096E3 RID: 38627
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_DeepCopy_05(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x060096E4 RID: 38628 RVA: 0x000D5CDC File Offset: 0x000D3EDC
		public override void DeepCopy(vtkProp prop)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_DeepCopy_05(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x060096E5 RID: 38629
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_GetActors_06(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x060096E6 RID: 38630 RVA: 0x000D5D0C File Offset: 0x000D3F0C
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetActors_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060096E7 RID: 38631
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMeasurementCubeHandleRepresentation3D_GetAdaptiveScaling_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off adaptive scaling for the cube.
		/// </summary>
		// Token: 0x060096E8 RID: 38632 RVA: 0x000D5D3C File Offset: 0x000D3F3C
		public virtual int GetAdaptiveScaling()
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetAdaptiveScaling_07(base.GetCppThis());
		}

		// Token: 0x060096E9 RID: 38633
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_GetBounds_08(HandleRef pThis);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x060096EA RID: 38634 RVA: 0x000D5D5C File Offset: 0x000D3F5C
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetBounds_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060096EB RID: 38635
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_GetHandle_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle polydata.
		/// </summary>
		// Token: 0x060096EC RID: 38636 RVA: 0x000D5DA4 File Offset: 0x000D3FA4
		public vtkPolyData GetHandle()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetHandle_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x060096ED RID: 38637
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMeasurementCubeHandleRepresentation3D_GetHandleVisibility_10(HandleRef pThis);

		/// <summary>
		/// Toggle the visibility of the handle on and off
		/// </summary>
		// Token: 0x060096EE RID: 38638 RVA: 0x000D5E14 File Offset: 0x000D4014
		public virtual int GetHandleVisibility()
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetHandleVisibility_10(base.GetCppThis());
		}

		// Token: 0x060096EF RID: 38639
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_GetLabelText_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the label text actor
		/// </summary>
		// Token: 0x060096F0 RID: 38640 RVA: 0x000D5E34 File Offset: 0x000D4034
		public virtual vtkBillboardTextActor3D GetLabelText()
		{
			vtkBillboardTextActor3D vtkBillboardTextActor3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetLabelText_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBillboardTextActor3D = (vtkBillboardTextActor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBillboardTextActor3D.Register(null);
				}
			}
			return vtkBillboardTextActor3D;
		}

		// Token: 0x060096F1 RID: 38641
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_GetLabelTextInput_12(HandleRef pThis);

		/// <summary>
		/// A label may be associated with the cube. The string can be set via
		/// SetLabelText. The visibility of the label can be turned on / off.
		/// </summary>
		// Token: 0x060096F2 RID: 38642 RVA: 0x000D5EA4 File Offset: 0x000D40A4
		public virtual string GetLabelTextInput()
		{
			string s = Marshal.PtrToStringAnsi(vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetLabelTextInput_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060096F3 RID: 38643
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMeasurementCubeHandleRepresentation3D_GetLabelVisibility_13(HandleRef pThis);

		/// <summary>
		/// A label may be associated with the cube. The string can be set via
		/// SetLabelText. The visibility of the label can be turned on / off.
		/// </summary>
		// Token: 0x060096F4 RID: 38644 RVA: 0x000D5EE0 File Offset: 0x000D40E0
		public virtual int GetLabelVisibility()
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetLabelVisibility_13(base.GetCppThis());
		}

		// Token: 0x060096F5 RID: 38645
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_GetLengthUnit_14(HandleRef pThis);

		/// <summary>
		/// Set the label for the unit of length of a side of the cube.
		/// </summary>
		// Token: 0x060096F6 RID: 38646 RVA: 0x000D5F00 File Offset: 0x000D4100
		public virtual string GetLengthUnit()
		{
			string s = Marshal.PtrToStringAnsi(vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetLengthUnit_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060096F7 RID: 38647
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeasurementCubeHandleRepresentation3D_GetMaxRelativeCubeScreenArea_15(HandleRef pThis);

		/// <summary>
		/// Set the min/max cube representational area relative to the render window
		/// area. If adaptive scaling is on and the cube's image is outside of these
		/// bounds, the cube is adaptively scaled. The max and min relative cube sizes
		/// are clamped between 1. and 1.e-6, and MaxRelativeubeSize must be more than
		/// \c RescaleFactor greater than MinRelativeCubeScreenArea.
		/// </summary>
		// Token: 0x060096F8 RID: 38648 RVA: 0x000D5F3C File Offset: 0x000D413C
		public virtual double GetMaxRelativeCubeScreenArea()
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetMaxRelativeCubeScreenArea_15(base.GetCppThis());
		}

		// Token: 0x060096F9 RID: 38649
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeasurementCubeHandleRepresentation3D_GetMinRelativeCubeScreenArea_16(HandleRef pThis);

		/// <summary>
		/// Set the min/max cube representational area relative to the render window
		/// area. If adaptive scaling is on and the cube's image is outside of these
		/// bounds, the cube is adaptively scaled. The max and min relative cube sizes
		/// are clamped between 1. and 1.e-6, and MaxRelativeubeSize must be more than
		/// \c RescaleFactor greater than MinRelativeCubeScreenArea.
		/// </summary>
		// Token: 0x060096FA RID: 38650 RVA: 0x000D5F5C File Offset: 0x000D415C
		public virtual double GetMinRelativeCubeScreenArea()
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetMinRelativeCubeScreenArea_16(base.GetCppThis());
		}

		// Token: 0x060096FB RID: 38651
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMeasurementCubeHandleRepresentation3D_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060096FC RID: 38652 RVA: 0x000D5F7C File Offset: 0x000D417C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x060096FD RID: 38653
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMeasurementCubeHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060096FE RID: 38654 RVA: 0x000D5F9C File Offset: 0x000D419C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x060096FF RID: 38655
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_GetProperty_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties when unselected and selected.
		/// </summary>
		// Token: 0x06009700 RID: 38656 RVA: 0x000D5FB8 File Offset: 0x000D41B8
		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetProperty_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06009701 RID: 38657
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeasurementCubeHandleRepresentation3D_GetRescaleFactor_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the rescaling increment for the cube. This value is applied to
		/// each dimension, so volume scaling = std::pow(RescaleFactor, 3).
		/// </summary>
		// Token: 0x06009702 RID: 38658 RVA: 0x000D6028 File Offset: 0x000D4228
		public virtual double GetRescaleFactor()
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetRescaleFactor_20(base.GetCppThis());
		}

		// Token: 0x06009703 RID: 38659
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeasurementCubeHandleRepresentation3D_GetRescaleFactorMaxValue_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the rescaling increment for the cube. This value is applied to
		/// each dimension, so volume scaling = std::pow(RescaleFactor, 3).
		/// </summary>
		// Token: 0x06009704 RID: 38660 RVA: 0x000D6048 File Offset: 0x000D4248
		public virtual double GetRescaleFactorMaxValue()
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetRescaleFactorMaxValue_21(base.GetCppThis());
		}

		// Token: 0x06009705 RID: 38661
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeasurementCubeHandleRepresentation3D_GetRescaleFactorMinValue_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the rescaling increment for the cube. This value is applied to
		/// each dimension, so volume scaling = std::pow(RescaleFactor, 3).
		/// </summary>
		// Token: 0x06009706 RID: 38662 RVA: 0x000D6068 File Offset: 0x000D4268
		public virtual double GetRescaleFactorMinValue()
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetRescaleFactorMinValue_22(base.GetCppThis());
		}

		// Token: 0x06009707 RID: 38663
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMeasurementCubeHandleRepresentation3D_GetSelectedLabelVisibility_23(HandleRef pThis);

		/// <summary>
		/// A label may be associated with the cube. The string can be set via
		/// SetLabelText. The visibility of the label can be turned on / off.
		/// </summary>
		// Token: 0x06009708 RID: 38664 RVA: 0x000D6088 File Offset: 0x000D4288
		public virtual int GetSelectedLabelVisibility()
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetSelectedLabelVisibility_23(base.GetCppThis());
		}

		// Token: 0x06009709 RID: 38665
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_GetSelectedProperty_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties when unselected and selected.
		/// </summary>
		// Token: 0x0600970A RID: 38666 RVA: 0x000D60A8 File Offset: 0x000D42A8
		public virtual vtkProperty GetSelectedProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetSelectedProperty_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600970B RID: 38667
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeasurementCubeHandleRepresentation3D_GetSideLength_25(HandleRef pThis);

		/// <summary>
		/// Set the length of a side of the cube (default is 1).
		/// </summary>
		// Token: 0x0600970C RID: 38668 RVA: 0x000D6118 File Offset: 0x000D4318
		public virtual double GetSideLength()
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetSideLength_25(base.GetCppThis());
		}

		// Token: 0x0600970D RID: 38669
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMeasurementCubeHandleRepresentation3D_GetSmoothMotion_26(HandleRef pThis);

		/// <summary>
		/// Turn on/off smooth motion of the handle. See the documentation of
		/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
		/// in certain applications the user may want to turn it off. For instance
		/// when using certain specific PointPlacer's with the representation such
		/// as the vtkCellCentersPointPlacer, which causes the representation to
		/// snap to the center of cells. In such cases, inherent restrictions on
		/// handle placement might conflict with a request for smooth motion of the
		/// handles.
		/// </summary>
		// Token: 0x0600970E RID: 38670 RVA: 0x000D6138 File Offset: 0x000D4338
		public virtual int GetSmoothMotion()
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetSmoothMotion_26(base.GetCppThis());
		}

		// Token: 0x0600970F RID: 38671
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_GetTransform_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the transform used to transform the generic handle polydata before
		/// placing it in the render window
		/// </summary>
		// Token: 0x06009710 RID: 38672 RVA: 0x000D6158 File Offset: 0x000D4358
		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_GetTransform_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		// Token: 0x06009711 RID: 38673
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_HandleVisibilityOff_28(HandleRef pThis);

		/// <summary>
		/// Toggle the visibility of the handle on and off
		/// </summary>
		// Token: 0x06009712 RID: 38674 RVA: 0x000D61C7 File Offset: 0x000D43C7
		public virtual void HandleVisibilityOff()
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_HandleVisibilityOff_28(base.GetCppThis());
		}

		// Token: 0x06009713 RID: 38675
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_HandleVisibilityOn_29(HandleRef pThis);

		/// <summary>
		/// Toggle the visibility of the handle on and off
		/// </summary>
		// Token: 0x06009714 RID: 38676 RVA: 0x000D61D6 File Offset: 0x000D43D6
		public virtual void HandleVisibilityOn()
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_HandleVisibilityOn_29(base.GetCppThis());
		}

		// Token: 0x06009715 RID: 38677
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMeasurementCubeHandleRepresentation3D_HasTranslucentPolygonalGeometry_30(HandleRef pThis);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009716 RID: 38678 RVA: 0x000D61E8 File Offset: 0x000D43E8
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_HasTranslucentPolygonalGeometry_30(base.GetCppThis());
		}

		// Token: 0x06009717 RID: 38679
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_Highlight_31(HandleRef pThis, int highlight);

		/// <summary>
		/// Toggle highlighting (used when the cube is selected).
		/// </summary>
		// Token: 0x06009718 RID: 38680 RVA: 0x000D6207 File Offset: 0x000D4407
		public override void Highlight(int highlight)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_Highlight_31(base.GetCppThis(), highlight);
		}

		// Token: 0x06009719 RID: 38681
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMeasurementCubeHandleRepresentation3D_IsA_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600971A RID: 38682 RVA: 0x000D6218 File Offset: 0x000D4418
		public override int IsA(string type)
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_IsA_32(base.GetCppThis(), type);
		}

		// Token: 0x0600971B RID: 38683
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMeasurementCubeHandleRepresentation3D_IsTypeOf_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600971C RID: 38684 RVA: 0x000D6238 File Offset: 0x000D4438
		public new static int IsTypeOf(string type)
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_IsTypeOf_33(type);
		}

		// Token: 0x0600971D RID: 38685
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_LabelVisibilityOff_34(HandleRef pThis);

		/// <summary>
		/// A label may be associated with the cube. The string can be set via
		/// SetLabelText. The visibility of the label can be turned on / off.
		/// </summary>
		// Token: 0x0600971E RID: 38686 RVA: 0x000D6252 File Offset: 0x000D4452
		public virtual void LabelVisibilityOff()
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_LabelVisibilityOff_34(base.GetCppThis());
		}

		// Token: 0x0600971F RID: 38687
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_LabelVisibilityOn_35(HandleRef pThis);

		/// <summary>
		/// A label may be associated with the cube. The string can be set via
		/// SetLabelText. The visibility of the label can be turned on / off.
		/// </summary>
		// Token: 0x06009720 RID: 38688 RVA: 0x000D6261 File Offset: 0x000D4461
		public virtual void LabelVisibilityOn()
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_LabelVisibilityOn_35(base.GetCppThis());
		}

		// Token: 0x06009721 RID: 38689
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009722 RID: 38690 RVA: 0x000D6270 File Offset: 0x000D4470
		public new vtkMeasurementCubeHandleRepresentation3D NewInstance()
		{
			vtkMeasurementCubeHandleRepresentation3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_NewInstance_37(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMeasurementCubeHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009723 RID: 38691
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_RegisterPickers_38(HandleRef pThis);

		/// <summary>
		/// Set the label for the unit of length of a side of the cube.
		/// </summary>
		// Token: 0x06009724 RID: 38692 RVA: 0x000D62CA File Offset: 0x000D44CA
		public override void RegisterPickers()
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_RegisterPickers_38(base.GetCppThis());
		}

		// Token: 0x06009725 RID: 38693
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_ReleaseGraphicsResources_39(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009726 RID: 38694 RVA: 0x000D62DC File Offset: 0x000D44DC
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_ReleaseGraphicsResources_39(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009727 RID: 38695
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMeasurementCubeHandleRepresentation3D_RenderOpaqueGeometry_40(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009728 RID: 38696 RVA: 0x000D630C File Offset: 0x000D450C
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_RenderOpaqueGeometry_40(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06009729 RID: 38697
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMeasurementCubeHandleRepresentation3D_RenderTranslucentPolygonalGeometry_41(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x0600972A RID: 38698 RVA: 0x000D6340 File Offset: 0x000D4540
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_RenderTranslucentPolygonalGeometry_41(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600972B RID: 38699
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMeasurementCubeHandleRepresentation3D_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600972C RID: 38700 RVA: 0x000D6374 File Offset: 0x000D4574
		public new static vtkMeasurementCubeHandleRepresentation3D SafeDownCast(vtkObjectBase o)
		{
			vtkMeasurementCubeHandleRepresentation3D vtkMeasurementCubeHandleRepresentation3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SafeDownCast_42((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMeasurementCubeHandleRepresentation3D = (vtkMeasurementCubeHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMeasurementCubeHandleRepresentation3D.Register(null);
				}
			}
			return vtkMeasurementCubeHandleRepresentation3D;
		}

		// Token: 0x0600972D RID: 38701
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SelectedLabelVisibilityOff_43(HandleRef pThis);

		/// <summary>
		/// A label may be associated with the cube. The string can be set via
		/// SetLabelText. The visibility of the label can be turned on / off.
		/// </summary>
		// Token: 0x0600972E RID: 38702 RVA: 0x000D63F3 File Offset: 0x000D45F3
		public virtual void SelectedLabelVisibilityOff()
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SelectedLabelVisibilityOff_43(base.GetCppThis());
		}

		// Token: 0x0600972F RID: 38703
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SelectedLabelVisibilityOn_44(HandleRef pThis);

		/// <summary>
		/// A label may be associated with the cube. The string can be set via
		/// SetLabelText. The visibility of the label can be turned on / off.
		/// </summary>
		// Token: 0x06009730 RID: 38704 RVA: 0x000D6402 File Offset: 0x000D4602
		public virtual void SelectedLabelVisibilityOn()
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SelectedLabelVisibilityOn_44(base.GetCppThis());
		}

		// Token: 0x06009731 RID: 38705
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetAdaptiveScaling_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off adaptive scaling for the cube.
		/// </summary>
		// Token: 0x06009732 RID: 38706 RVA: 0x000D6411 File Offset: 0x000D4611
		public virtual void SetAdaptiveScaling(int _arg)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SetAdaptiveScaling_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06009733 RID: 38707
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetDisplayPosition_46(HandleRef pThis, IntPtr p);

		/// <summary>
		/// Set the position of the point in world and display coordinates.
		/// </summary>
		// Token: 0x06009734 RID: 38708 RVA: 0x000D6421 File Offset: 0x000D4621
		public override void SetDisplayPosition(IntPtr p)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SetDisplayPosition_46(base.GetCppThis(), p);
		}

		// Token: 0x06009735 RID: 38709
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetHandleVisibility_47(HandleRef pThis, int _arg);

		/// <summary>
		/// Toggle the visibility of the handle on and off
		/// </summary>
		// Token: 0x06009736 RID: 38710 RVA: 0x000D6431 File Offset: 0x000D4631
		public virtual void SetHandleVisibility(int _arg)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SetHandleVisibility_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06009737 RID: 38711
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetLabelTextInput_48(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string label);

		/// <summary>
		/// A label may be associated with the cube. The string can be set via
		/// SetLabelText. The visibility of the label can be turned on / off.
		/// </summary>
		// Token: 0x06009738 RID: 38712 RVA: 0x000D6441 File Offset: 0x000D4641
		public virtual void SetLabelTextInput(string label)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SetLabelTextInput_48(base.GetCppThis(), label);
		}

		// Token: 0x06009739 RID: 38713
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetLabelVisibility_49(HandleRef pThis, int _arg);

		/// <summary>
		/// A label may be associated with the cube. The string can be set via
		/// SetLabelText. The visibility of the label can be turned on / off.
		/// </summary>
		// Token: 0x0600973A RID: 38714 RVA: 0x000D6451 File Offset: 0x000D4651
		public virtual void SetLabelVisibility(int _arg)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SetLabelVisibility_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0600973B RID: 38715
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetLengthUnit_50(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the label for the unit of length of a side of the cube.
		/// </summary>
		// Token: 0x0600973C RID: 38716 RVA: 0x000D6461 File Offset: 0x000D4661
		public virtual void SetLengthUnit(string _arg)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SetLengthUnit_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0600973D RID: 38717
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetMaxRelativeCubeScreenArea_51(HandleRef pThis, double arg0);

		/// <summary>
		/// Set the min/max cube representational area relative to the render window
		/// area. If adaptive scaling is on and the cube's image is outside of these
		/// bounds, the cube is adaptively scaled. The max and min relative cube sizes
		/// are clamped between 1. and 1.e-6, and MaxRelativeubeSize must be more than
		/// \c RescaleFactor greater than MinRelativeCubeScreenArea.
		/// </summary>
		// Token: 0x0600973E RID: 38718 RVA: 0x000D6471 File Offset: 0x000D4671
		public void SetMaxRelativeCubeScreenArea(double arg0)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SetMaxRelativeCubeScreenArea_51(base.GetCppThis(), arg0);
		}

		// Token: 0x0600973F RID: 38719
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetMinRelativeCubeScreenArea_52(HandleRef pThis, double arg0);

		/// <summary>
		/// Set the min/max cube representational area relative to the render window
		/// area. If adaptive scaling is on and the cube's image is outside of these
		/// bounds, the cube is adaptively scaled. The max and min relative cube sizes
		/// are clamped between 1. and 1.e-6, and MaxRelativeubeSize must be more than
		/// \c RescaleFactor greater than MinRelativeCubeScreenArea.
		/// </summary>
		// Token: 0x06009740 RID: 38720 RVA: 0x000D6481 File Offset: 0x000D4681
		public void SetMinRelativeCubeScreenArea(double arg0)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SetMinRelativeCubeScreenArea_52(base.GetCppThis(), arg0);
		}

		// Token: 0x06009741 RID: 38721
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetProperty_53(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the handle properties when unselected and selected.
		/// </summary>
		// Token: 0x06009742 RID: 38722 RVA: 0x000D6494 File Offset: 0x000D4694
		public void SetProperty(vtkProperty arg0)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SetProperty_53(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009743 RID: 38723
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetRescaleFactor_54(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the rescaling increment for the cube. This value is applied to
		/// each dimension, so volume scaling = std::pow(RescaleFactor, 3).
		/// </summary>
		// Token: 0x06009744 RID: 38724 RVA: 0x000D64C3 File Offset: 0x000D46C3
		public virtual void SetRescaleFactor(double _arg)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SetRescaleFactor_54(base.GetCppThis(), _arg);
		}

		// Token: 0x06009745 RID: 38725
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetSelectedLabelVisibility_55(HandleRef pThis, int _arg);

		/// <summary>
		/// A label may be associated with the cube. The string can be set via
		/// SetLabelText. The visibility of the label can be turned on / off.
		/// </summary>
		// Token: 0x06009746 RID: 38726 RVA: 0x000D64D3 File Offset: 0x000D46D3
		public virtual void SetSelectedLabelVisibility(int _arg)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SetSelectedLabelVisibility_55(base.GetCppThis(), _arg);
		}

		// Token: 0x06009747 RID: 38727
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetSelectedProperty_56(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the handle properties when unselected and selected.
		/// </summary>
		// Token: 0x06009748 RID: 38728 RVA: 0x000D64E4 File Offset: 0x000D46E4
		public void SetSelectedProperty(vtkProperty arg0)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SetSelectedProperty_56(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009749 RID: 38729
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetSideLength_57(HandleRef pThis, double arg0);

		/// <summary>
		/// Set the length of a side of the cube (default is 1).
		/// </summary>
		// Token: 0x0600974A RID: 38730 RVA: 0x000D6513 File Offset: 0x000D4713
		public void SetSideLength(double arg0)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SetSideLength_57(base.GetCppThis(), arg0);
		}

		// Token: 0x0600974B RID: 38731
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetSmoothMotion_58(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off smooth motion of the handle. See the documentation of
		/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
		/// in certain applications the user may want to turn it off. For instance
		/// when using certain specific PointPlacer's with the representation such
		/// as the vtkCellCentersPointPlacer, which causes the representation to
		/// snap to the center of cells. In such cases, inherent restrictions on
		/// handle placement might conflict with a request for smooth motion of the
		/// handles.
		/// </summary>
		// Token: 0x0600974C RID: 38732 RVA: 0x000D6523 File Offset: 0x000D4723
		public virtual void SetSmoothMotion(int _arg)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SetSmoothMotion_58(base.GetCppThis(), _arg);
		}

		// Token: 0x0600974D RID: 38733
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SetWorldPosition_59(HandleRef pThis, IntPtr p);

		/// <summary>
		/// Set the position of the point in world and display coordinates.
		/// </summary>
		// Token: 0x0600974E RID: 38734 RVA: 0x000D6533 File Offset: 0x000D4733
		public override void SetWorldPosition(IntPtr p)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SetWorldPosition_59(base.GetCppThis(), p);
		}

		// Token: 0x0600974F RID: 38735
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_ShallowCopy_60(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009750 RID: 38736 RVA: 0x000D6544 File Offset: 0x000D4744
		public override void ShallowCopy(vtkProp prop)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_ShallowCopy_60(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06009751 RID: 38737
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SmoothMotionOff_61(HandleRef pThis);

		/// <summary>
		/// Turn on/off smooth motion of the handle. See the documentation of
		/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
		/// in certain applications the user may want to turn it off. For instance
		/// when using certain specific PointPlacer's with the representation such
		/// as the vtkCellCentersPointPlacer, which causes the representation to
		/// snap to the center of cells. In such cases, inherent restrictions on
		/// handle placement might conflict with a request for smooth motion of the
		/// handles.
		/// </summary>
		// Token: 0x06009752 RID: 38738 RVA: 0x000D6573 File Offset: 0x000D4773
		public virtual void SmoothMotionOff()
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SmoothMotionOff_61(base.GetCppThis());
		}

		// Token: 0x06009753 RID: 38739
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_SmoothMotionOn_62(HandleRef pThis);

		/// <summary>
		/// Turn on/off smooth motion of the handle. See the documentation of
		/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
		/// in certain applications the user may want to turn it off. For instance
		/// when using certain specific PointPlacer's with the representation such
		/// as the vtkCellCentersPointPlacer, which causes the representation to
		/// snap to the center of cells. In such cases, inherent restrictions on
		/// handle placement might conflict with a request for smooth motion of the
		/// handles.
		/// </summary>
		// Token: 0x06009754 RID: 38740 RVA: 0x000D6582 File Offset: 0x000D4782
		public virtual void SmoothMotionOn()
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_SmoothMotionOn_62(base.GetCppThis());
		}

		// Token: 0x06009755 RID: 38741
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_StartWidgetInteraction_63(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06009756 RID: 38742 RVA: 0x000D6591 File Offset: 0x000D4791
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_StartWidgetInteraction_63(base.GetCppThis(), eventPos);
		}

		// Token: 0x06009757 RID: 38743
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeasurementCubeHandleRepresentation3D_WidgetInteraction_64(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06009758 RID: 38744 RVA: 0x000D65A1 File Offset: 0x000D47A1
		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkMeasurementCubeHandleRepresentation3D.vtkMeasurementCubeHandleRepresentation3D_WidgetInteraction_64(base.GetCppThis(), eventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C5D RID: 3165
		public new const string MRFullTypeName = "Kitware.VTK.vtkMeasurementCubeHandleRepresentation3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C5E RID: 3166
		public new static readonly string MRClassNameKey = "class vtkMeasurementCubeHandleRepresentation3D";
	}
}
