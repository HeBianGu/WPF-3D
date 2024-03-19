using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointHandleRepresentation3D
	/// </summary>
	/// <remarks>
	///    represent the position of a point in 3D space
	///
	/// This class is used to represent a vtkHandleWidget. It represents a position
	/// in 3D world coordinates using a x-y-z cursor. The cursor can be configured to
	/// show a bounding box and/or shadows.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHandleRepresentation vtkHandleWidget vtkCursor3D
	/// </seealso>
	// Token: 0x02000354 RID: 852
	public class vtkPointHandleRepresentation3D : vtkHandleRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009AC1 RID: 39617 RVA: 0x000DB5EF File Offset: 0x000D97EF
		static vtkPointHandleRepresentation3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointHandleRepresentation3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointHandleRepresentation3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009AC2 RID: 39618 RVA: 0x000DB617 File Offset: 0x000D9817
		public vtkPointHandleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009AC3 RID: 39619
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointHandleRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009AC4 RID: 39620 RVA: 0x000DB628 File Offset: 0x000D9828
		public new static vtkPointHandleRepresentation3D New()
		{
			vtkPointHandleRepresentation3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009AC5 RID: 39621 RVA: 0x000DB67C File Offset: 0x000D987C
		public vtkPointHandleRepresentation3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009AC6 RID: 39622 RVA: 0x000DB6C0 File Offset: 0x000D98C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009AC7 RID: 39623
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_AllOff_01(HandleRef pThis);

		/// <summary>
		/// Convenience methods to turn outline and shadows on and off.
		/// </summary>
		// Token: 0x06009AC8 RID: 39624 RVA: 0x000DB6CB File Offset: 0x000D98CB
		public void AllOff()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_AllOff_01(base.GetCppThis());
		}

		// Token: 0x06009AC9 RID: 39625
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_AllOn_02(HandleRef pThis);

		/// <summary>
		/// Convenience methods to turn outline and shadows on and off.
		/// </summary>
		// Token: 0x06009ACA RID: 39626 RVA: 0x000DB6DA File Offset: 0x000D98DA
		public void AllOn()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_AllOn_02(base.GetCppThis());
		}

		// Token: 0x06009ACB RID: 39627
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_BuildRepresentation_03(HandleRef pThis);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06009ACC RID: 39628 RVA: 0x000DB6E9 File Offset: 0x000D98E9
		public override void BuildRepresentation()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_BuildRepresentation_03(base.GetCppThis());
		}

		// Token: 0x06009ACD RID: 39629
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_ComplexInteraction_04(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06009ACE RID: 39630 RVA: 0x000DB6F8 File Offset: 0x000D98F8
		public override void ComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_ComplexInteraction_04(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x06009ACF RID: 39631
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointHandleRepresentation3D_ComputeComplexInteractionState_05(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata, int modify);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06009AD0 RID: 39632 RVA: 0x000DB740 File Offset: 0x000D9940
		public override int ComputeComplexInteractionState(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata, int modify)
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_ComputeComplexInteractionState_05(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata, modify);
		}

		// Token: 0x06009AD1 RID: 39633
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointHandleRepresentation3D_ComputeInteractionState_06(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06009AD2 RID: 39634 RVA: 0x000DB790 File Offset: 0x000D9990
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_ComputeInteractionState_06(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x06009AD3 RID: 39635
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_DeepCopy_07(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009AD4 RID: 39636 RVA: 0x000DB7B4 File Offset: 0x000D99B4
		public override void DeepCopy(vtkProp prop)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_DeepCopy_07(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06009AD5 RID: 39637
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_GetActors_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009AD6 RID: 39638 RVA: 0x000DB7E4 File Offset: 0x000D99E4
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetActors_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009AD7 RID: 39639
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointHandleRepresentation3D_GetBounds_09(HandleRef pThis);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06009AD8 RID: 39640 RVA: 0x000DB814 File Offset: 0x000D9A14
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetBounds_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009AD9 RID: 39641
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointHandleRepresentation3D_GetHotSpotSize_10(HandleRef pThis);

		/// <summary>
		/// Set the "hot spot" size; i.e., the region around the focus, in which the
		/// motion vector is used to control the constrained sliding action. Note the
		/// size is specified as a fraction of the length of the diagonal of the
		/// point widget's bounding box.
		/// </summary>
		// Token: 0x06009ADA RID: 39642 RVA: 0x000DB85C File Offset: 0x000D9A5C
		public virtual double GetHotSpotSize()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetHotSpotSize_10(base.GetCppThis());
		}

		// Token: 0x06009ADB RID: 39643
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointHandleRepresentation3D_GetHotSpotSizeMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set the "hot spot" size; i.e., the region around the focus, in which the
		/// motion vector is used to control the constrained sliding action. Note the
		/// size is specified as a fraction of the length of the diagonal of the
		/// point widget's bounding box.
		/// </summary>
		// Token: 0x06009ADC RID: 39644 RVA: 0x000DB87C File Offset: 0x000D9A7C
		public virtual double GetHotSpotSizeMaxValue()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetHotSpotSizeMaxValue_11(base.GetCppThis());
		}

		// Token: 0x06009ADD RID: 39645
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointHandleRepresentation3D_GetHotSpotSizeMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set the "hot spot" size; i.e., the region around the focus, in which the
		/// motion vector is used to control the constrained sliding action. Note the
		/// size is specified as a fraction of the length of the diagonal of the
		/// point widget's bounding box.
		/// </summary>
		// Token: 0x06009ADE RID: 39646 RVA: 0x000DB89C File Offset: 0x000D9A9C
		public virtual double GetHotSpotSizeMinValue()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetHotSpotSizeMinValue_12(base.GetCppThis());
		}

		// Token: 0x06009ADF RID: 39647
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointHandleRepresentation3D_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009AE0 RID: 39648 RVA: 0x000DB8BC File Offset: 0x000D9ABC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06009AE1 RID: 39649
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009AE2 RID: 39650 RVA: 0x000DB8DC File Offset: 0x000D9ADC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06009AE3 RID: 39651
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointHandleRepresentation3D_GetOutline_15(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe bounding box.
		/// </summary>
		// Token: 0x06009AE4 RID: 39652 RVA: 0x000DB8F8 File Offset: 0x000D9AF8
		public int GetOutline()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetOutline_15(base.GetCppThis());
		}

		// Token: 0x06009AE5 RID: 39653
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointHandleRepresentation3D_GetProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties when unselected and selected.
		/// </summary>
		// Token: 0x06009AE6 RID: 39654 RVA: 0x000DB918 File Offset: 0x000D9B18
		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetProperty_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009AE7 RID: 39655
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointHandleRepresentation3D_GetSelectedProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties when unselected and selected.
		/// </summary>
		// Token: 0x06009AE8 RID: 39656 RVA: 0x000DB988 File Offset: 0x000D9B88
		public virtual vtkProperty GetSelectedProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetSelectedProperty_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009AE9 RID: 39657
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointHandleRepresentation3D_GetSmoothMotion_18(HandleRef pThis);

		/// <summary>
		/// Turn on/off smooth motion of the handle. See the documentation of
		/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
		/// in certain applications the user may want to turn it off. For instance
		/// when using certain specific PointPlacer's with the representation such
		/// as the vtkCellCentersPointPlacer, which causes the representation to
		/// snap to the center of cells, or using a vtkPolygonalSurfacePointPlacer
		/// which constrains the widget to the surface of a mesh. In such cases,
		/// inherent restrictions on handle placement might conflict with a request
		/// for smooth motion of the handles.
		/// </summary>
		// Token: 0x06009AEA RID: 39658 RVA: 0x000DB9F8 File Offset: 0x000D9BF8
		public virtual int GetSmoothMotion()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetSmoothMotion_18(base.GetCppThis());
		}

		// Token: 0x06009AEB RID: 39659
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointHandleRepresentation3D_GetTranslationMode_19(HandleRef pThis);

		/// <summary>
		/// If translation mode is on, as the widget is moved the bounding box,
		/// shadows, and cursor are all translated and sized simultaneously as the
		/// point moves (i.e., the left and middle mouse buttons act the same). If
		/// translation mode is off, the cursor does not scale itself (based on the
		/// specified handle size), and the bounding box and shadows do not move or
		/// size themselves as the cursor focal point moves, which is constrained by
		/// the bounds of the point representation. (Note that the bounds can be
		/// scaled up using the right mouse button, and the bounds can be manually
		/// set with the SetBounds() method.)
		/// </summary>
		// Token: 0x06009AEC RID: 39660 RVA: 0x000DBA18 File Offset: 0x000D9C18
		public virtual int GetTranslationMode()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetTranslationMode_19(base.GetCppThis());
		}

		// Token: 0x06009AED RID: 39661
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointHandleRepresentation3D_GetXShadows_20(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe x-shadows.
		/// </summary>
		// Token: 0x06009AEE RID: 39662 RVA: 0x000DBA38 File Offset: 0x000D9C38
		public int GetXShadows()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetXShadows_20(base.GetCppThis());
		}

		// Token: 0x06009AEF RID: 39663
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointHandleRepresentation3D_GetYShadows_21(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe y-shadows.
		/// </summary>
		// Token: 0x06009AF0 RID: 39664 RVA: 0x000DBA58 File Offset: 0x000D9C58
		public int GetYShadows()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetYShadows_21(base.GetCppThis());
		}

		// Token: 0x06009AF1 RID: 39665
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointHandleRepresentation3D_GetZShadows_22(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe z-shadows.
		/// </summary>
		// Token: 0x06009AF2 RID: 39666 RVA: 0x000DBA78 File Offset: 0x000D9C78
		public int GetZShadows()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_GetZShadows_22(base.GetCppThis());
		}

		// Token: 0x06009AF3 RID: 39667
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointHandleRepresentation3D_HasTranslucentPolygonalGeometry_23(HandleRef pThis);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009AF4 RID: 39668 RVA: 0x000DBA98 File Offset: 0x000D9C98
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_HasTranslucentPolygonalGeometry_23(base.GetCppThis());
		}

		// Token: 0x06009AF5 RID: 39669
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_Highlight_24(HandleRef pThis, int highlight);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009AF6 RID: 39670 RVA: 0x000DBAB7 File Offset: 0x000D9CB7
		public override void Highlight(int highlight)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_Highlight_24(base.GetCppThis(), highlight);
		}

		// Token: 0x06009AF7 RID: 39671
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointHandleRepresentation3D_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009AF8 RID: 39672 RVA: 0x000DBAC8 File Offset: 0x000D9CC8
		public override int IsA(string type)
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x06009AF9 RID: 39673
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointHandleRepresentation3D_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009AFA RID: 39674 RVA: 0x000DBAE8 File Offset: 0x000D9CE8
		public new static int IsTypeOf(string type)
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_IsTypeOf_26(type);
		}

		// Token: 0x06009AFB RID: 39675
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointHandleRepresentation3D_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009AFC RID: 39676 RVA: 0x000DBB04 File Offset: 0x000D9D04
		public new vtkPointHandleRepresentation3D NewInstance()
		{
			vtkPointHandleRepresentation3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009AFD RID: 39677
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_OutlineOff_29(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe bounding box.
		/// </summary>
		// Token: 0x06009AFE RID: 39678 RVA: 0x000DBB5E File Offset: 0x000D9D5E
		public void OutlineOff()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_OutlineOff_29(base.GetCppThis());
		}

		// Token: 0x06009AFF RID: 39679
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_OutlineOn_30(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe bounding box.
		/// </summary>
		// Token: 0x06009B00 RID: 39680 RVA: 0x000DBB6D File Offset: 0x000D9D6D
		public void OutlineOn()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_OutlineOn_30(base.GetCppThis());
		}

		// Token: 0x06009B01 RID: 39681
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_PlaceWidget_31(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06009B02 RID: 39682 RVA: 0x000DBB7C File Offset: 0x000D9D7C
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_PlaceWidget_31(base.GetCppThis(), bounds);
		}

		// Token: 0x06009B03 RID: 39683
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_RegisterPickers_32(HandleRef pThis);

		/// <summary>
		/// Turn on/off smooth motion of the handle. See the documentation of
		/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
		/// in certain applications the user may want to turn it off. For instance
		/// when using certain specific PointPlacer's with the representation such
		/// as the vtkCellCentersPointPlacer, which causes the representation to
		/// snap to the center of cells, or using a vtkPolygonalSurfacePointPlacer
		/// which constrains the widget to the surface of a mesh. In such cases,
		/// inherent restrictions on handle placement might conflict with a request
		/// for smooth motion of the handles.
		/// </summary>
		// Token: 0x06009B04 RID: 39684 RVA: 0x000DBB8C File Offset: 0x000D9D8C
		public override void RegisterPickers()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_RegisterPickers_32(base.GetCppThis());
		}

		// Token: 0x06009B05 RID: 39685
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_ReleaseGraphicsResources_33(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009B06 RID: 39686 RVA: 0x000DBB9C File Offset: 0x000D9D9C
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_ReleaseGraphicsResources_33(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009B07 RID: 39687
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointHandleRepresentation3D_RenderOpaqueGeometry_34(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009B08 RID: 39688 RVA: 0x000DBBCC File Offset: 0x000D9DCC
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_RenderOpaqueGeometry_34(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06009B09 RID: 39689
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointHandleRepresentation3D_RenderTranslucentPolygonalGeometry_35(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009B0A RID: 39690 RVA: 0x000DBC00 File Offset: 0x000D9E00
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_RenderTranslucentPolygonalGeometry_35(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06009B0B RID: 39691
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointHandleRepresentation3D_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009B0C RID: 39692 RVA: 0x000DBC34 File Offset: 0x000D9E34
		public new static vtkPointHandleRepresentation3D SafeDownCast(vtkObjectBase o)
		{
			vtkPointHandleRepresentation3D vtkPointHandleRepresentation3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointHandleRepresentation3D = (vtkPointHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointHandleRepresentation3D.Register(null);
				}
			}
			return vtkPointHandleRepresentation3D;
		}

		// Token: 0x06009B0D RID: 39693
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SetDisplayPosition_37(HandleRef pThis, IntPtr p);

		/// <summary>
		/// Set the position of the point in world and display coordinates. Note
		/// that if the position is set outside of the bounding box, it will be
		/// clamped to the boundary of the bounding box. This method overloads
		/// the superclasses' SetWorldPosition() and SetDisplayPosition() in
		/// order to set the focal point of the cursor properly.
		/// </summary>
		// Token: 0x06009B0E RID: 39694 RVA: 0x000DBCB3 File Offset: 0x000D9EB3
		public override void SetDisplayPosition(IntPtr p)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetDisplayPosition_37(base.GetCppThis(), p);
		}

		// Token: 0x06009B0F RID: 39695
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SetForegroundColor_38(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the widget color, and the color of interactive handles.
		/// </summary>
		// Token: 0x06009B10 RID: 39696 RVA: 0x000DBCC3 File Offset: 0x000D9EC3
		public void SetForegroundColor(double arg0, double arg1, double arg2)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetForegroundColor_38(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06009B11 RID: 39697
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SetForegroundColor_39(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the widget color, and the color of interactive handles.
		/// </summary>
		// Token: 0x06009B12 RID: 39698 RVA: 0x000DBCD5 File Offset: 0x000D9ED5
		public void SetForegroundColor(IntPtr c)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetForegroundColor_39(base.GetCppThis(), c);
		}

		// Token: 0x06009B13 RID: 39699
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SetHandleSize_40(HandleRef pThis, double size);

		/// <summary>
		/// Overload the superclasses SetHandleSize() method to update internal variables.
		/// </summary>
		// Token: 0x06009B14 RID: 39700 RVA: 0x000DBCE5 File Offset: 0x000D9EE5
		public override void SetHandleSize(double size)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetHandleSize_40(base.GetCppThis(), size);
		}

		// Token: 0x06009B15 RID: 39701
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SetHotSpotSize_41(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the "hot spot" size; i.e., the region around the focus, in which the
		/// motion vector is used to control the constrained sliding action. Note the
		/// size is specified as a fraction of the length of the diagonal of the
		/// point widget's bounding box.
		/// </summary>
		// Token: 0x06009B16 RID: 39702 RVA: 0x000DBCF5 File Offset: 0x000D9EF5
		public virtual void SetHotSpotSize(double _arg)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetHotSpotSize_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06009B17 RID: 39703
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SetInteractionColor_42(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the widget color, and the color of interactive handles.
		/// </summary>
		// Token: 0x06009B18 RID: 39704 RVA: 0x000DBD05 File Offset: 0x000D9F05
		public void SetInteractionColor(double arg0, double arg1, double arg2)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetInteractionColor_42(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06009B19 RID: 39705
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SetInteractionColor_43(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the widget color, and the color of interactive handles.
		/// </summary>
		// Token: 0x06009B1A RID: 39706 RVA: 0x000DBD17 File Offset: 0x000D9F17
		public void SetInteractionColor(IntPtr c)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetInteractionColor_43(base.GetCppThis(), c);
		}

		// Token: 0x06009B1B RID: 39707
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SetOutline_44(HandleRef pThis, int o);

		/// <summary>
		/// Turn on/off the wireframe bounding box.
		/// </summary>
		// Token: 0x06009B1C RID: 39708 RVA: 0x000DBD27 File Offset: 0x000D9F27
		public void SetOutline(int o)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetOutline_44(base.GetCppThis(), o);
		}

		// Token: 0x06009B1D RID: 39709
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SetProperty_45(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the handle properties when unselected and selected.
		/// </summary>
		// Token: 0x06009B1E RID: 39710 RVA: 0x000DBD38 File Offset: 0x000D9F38
		public void SetProperty(vtkProperty arg0)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetProperty_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009B1F RID: 39711
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SetSelectedProperty_46(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the handle properties when unselected and selected.
		/// </summary>
		// Token: 0x06009B20 RID: 39712 RVA: 0x000DBD68 File Offset: 0x000D9F68
		public void SetSelectedProperty(vtkProperty arg0)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetSelectedProperty_46(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009B21 RID: 39713
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SetSmoothMotion_47(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off smooth motion of the handle. See the documentation of
		/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
		/// in certain applications the user may want to turn it off. For instance
		/// when using certain specific PointPlacer's with the representation such
		/// as the vtkCellCentersPointPlacer, which causes the representation to
		/// snap to the center of cells, or using a vtkPolygonalSurfacePointPlacer
		/// which constrains the widget to the surface of a mesh. In such cases,
		/// inherent restrictions on handle placement might conflict with a request
		/// for smooth motion of the handles.
		/// </summary>
		// Token: 0x06009B22 RID: 39714 RVA: 0x000DBD97 File Offset: 0x000D9F97
		public virtual void SetSmoothMotion(int _arg)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetSmoothMotion_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06009B23 RID: 39715
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SetTranslationMode_48(HandleRef pThis, int mode);

		/// <summary>
		/// If translation mode is on, as the widget is moved the bounding box,
		/// shadows, and cursor are all translated and sized simultaneously as the
		/// point moves (i.e., the left and middle mouse buttons act the same). If
		/// translation mode is off, the cursor does not scale itself (based on the
		/// specified handle size), and the bounding box and shadows do not move or
		/// size themselves as the cursor focal point moves, which is constrained by
		/// the bounds of the point representation. (Note that the bounds can be
		/// scaled up using the right mouse button, and the bounds can be manually
		/// set with the SetBounds() method.)
		/// </summary>
		// Token: 0x06009B24 RID: 39716 RVA: 0x000DBDA7 File Offset: 0x000D9FA7
		public void SetTranslationMode(int mode)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetTranslationMode_48(base.GetCppThis(), mode);
		}

		// Token: 0x06009B25 RID: 39717
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SetVisibility_49(HandleRef pThis, int visible);

		/// <summary>
		/// Override to ensure that the internal actor's visibility is consistent with
		/// this representation's visibility. Inconsistency between the two would cause
		/// issues in picking logic which relies on individual view prop visibility to
		/// determine whether the prop is pickable.
		/// </summary>
		// Token: 0x06009B26 RID: 39718 RVA: 0x000DBDB7 File Offset: 0x000D9FB7
		public override void SetVisibility(int visible)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetVisibility_49(base.GetCppThis(), visible);
		}

		// Token: 0x06009B27 RID: 39719
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SetWorldPosition_50(HandleRef pThis, IntPtr p);

		/// <summary>
		/// Set the position of the point in world and display coordinates. Note
		/// that if the position is set outside of the bounding box, it will be
		/// clamped to the boundary of the bounding box. This method overloads
		/// the superclasses' SetWorldPosition() and SetDisplayPosition() in
		/// order to set the focal point of the cursor properly.
		/// </summary>
		// Token: 0x06009B28 RID: 39720 RVA: 0x000DBDC7 File Offset: 0x000D9FC7
		public override void SetWorldPosition(IntPtr p)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetWorldPosition_50(base.GetCppThis(), p);
		}

		// Token: 0x06009B29 RID: 39721
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SetXShadows_51(HandleRef pThis, int o);

		/// <summary>
		/// Turn on/off the wireframe x-shadows.
		/// </summary>
		// Token: 0x06009B2A RID: 39722 RVA: 0x000DBDD7 File Offset: 0x000D9FD7
		public void SetXShadows(int o)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetXShadows_51(base.GetCppThis(), o);
		}

		// Token: 0x06009B2B RID: 39723
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SetYShadows_52(HandleRef pThis, int o);

		/// <summary>
		/// Turn on/off the wireframe y-shadows.
		/// </summary>
		// Token: 0x06009B2C RID: 39724 RVA: 0x000DBDE7 File Offset: 0x000D9FE7
		public void SetYShadows(int o)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetYShadows_52(base.GetCppThis(), o);
		}

		// Token: 0x06009B2D RID: 39725
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SetZShadows_53(HandleRef pThis, int o);

		/// <summary>
		/// Turn on/off the wireframe z-shadows.
		/// </summary>
		// Token: 0x06009B2E RID: 39726 RVA: 0x000DBDF7 File Offset: 0x000D9FF7
		public void SetZShadows(int o)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SetZShadows_53(base.GetCppThis(), o);
		}

		// Token: 0x06009B2F RID: 39727
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_ShallowCopy_54(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009B30 RID: 39728 RVA: 0x000DBE08 File Offset: 0x000DA008
		public override void ShallowCopy(vtkProp prop)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_ShallowCopy_54(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06009B31 RID: 39729
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SmoothMotionOff_55(HandleRef pThis);

		/// <summary>
		/// Turn on/off smooth motion of the handle. See the documentation of
		/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
		/// in certain applications the user may want to turn it off. For instance
		/// when using certain specific PointPlacer's with the representation such
		/// as the vtkCellCentersPointPlacer, which causes the representation to
		/// snap to the center of cells, or using a vtkPolygonalSurfacePointPlacer
		/// which constrains the widget to the surface of a mesh. In such cases,
		/// inherent restrictions on handle placement might conflict with a request
		/// for smooth motion of the handles.
		/// </summary>
		// Token: 0x06009B32 RID: 39730 RVA: 0x000DBE37 File Offset: 0x000DA037
		public virtual void SmoothMotionOff()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SmoothMotionOff_55(base.GetCppThis());
		}

		// Token: 0x06009B33 RID: 39731
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_SmoothMotionOn_56(HandleRef pThis);

		/// <summary>
		/// Turn on/off smooth motion of the handle. See the documentation of
		/// MoveFocusRequest for details. By default, SmoothMotion is ON. However,
		/// in certain applications the user may want to turn it off. For instance
		/// when using certain specific PointPlacer's with the representation such
		/// as the vtkCellCentersPointPlacer, which causes the representation to
		/// snap to the center of cells, or using a vtkPolygonalSurfacePointPlacer
		/// which constrains the widget to the surface of a mesh. In such cases,
		/// inherent restrictions on handle placement might conflict with a request
		/// for smooth motion of the handles.
		/// </summary>
		// Token: 0x06009B34 RID: 39732 RVA: 0x000DBE46 File Offset: 0x000DA046
		public virtual void SmoothMotionOn()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_SmoothMotionOn_56(base.GetCppThis());
		}

		// Token: 0x06009B35 RID: 39733
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_StartComplexInteraction_57(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06009B36 RID: 39734 RVA: 0x000DBE58 File Offset: 0x000DA058
		public override void StartComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_StartComplexInteraction_57(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x06009B37 RID: 39735
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_StartWidgetInteraction_58(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06009B38 RID: 39736 RVA: 0x000DBE9F File Offset: 0x000DA09F
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_StartWidgetInteraction_58(base.GetCppThis(), eventPos);
		}

		// Token: 0x06009B39 RID: 39737
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_TranslationModeOff_59(HandleRef pThis);

		/// <summary>
		/// If translation mode is on, as the widget is moved the bounding box,
		/// shadows, and cursor are all translated and sized simultaneously as the
		/// point moves (i.e., the left and middle mouse buttons act the same). If
		/// translation mode is off, the cursor does not scale itself (based on the
		/// specified handle size), and the bounding box and shadows do not move or
		/// size themselves as the cursor focal point moves, which is constrained by
		/// the bounds of the point representation. (Note that the bounds can be
		/// scaled up using the right mouse button, and the bounds can be manually
		/// set with the SetBounds() method.)
		/// </summary>
		// Token: 0x06009B3A RID: 39738 RVA: 0x000DBEAF File Offset: 0x000DA0AF
		public virtual void TranslationModeOff()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_TranslationModeOff_59(base.GetCppThis());
		}

		// Token: 0x06009B3B RID: 39739
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_TranslationModeOn_60(HandleRef pThis);

		/// <summary>
		/// If translation mode is on, as the widget is moved the bounding box,
		/// shadows, and cursor are all translated and sized simultaneously as the
		/// point moves (i.e., the left and middle mouse buttons act the same). If
		/// translation mode is off, the cursor does not scale itself (based on the
		/// specified handle size), and the bounding box and shadows do not move or
		/// size themselves as the cursor focal point moves, which is constrained by
		/// the bounds of the point representation. (Note that the bounds can be
		/// scaled up using the right mouse button, and the bounds can be manually
		/// set with the SetBounds() method.)
		/// </summary>
		// Token: 0x06009B3C RID: 39740 RVA: 0x000DBEBE File Offset: 0x000DA0BE
		public virtual void TranslationModeOn()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_TranslationModeOn_60(base.GetCppThis());
		}

		// Token: 0x06009B3D RID: 39741
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_WidgetInteraction_61(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to make this class properly act like a vtkWidgetRepresentation.
		/// </summary>
		// Token: 0x06009B3E RID: 39742 RVA: 0x000DBECD File Offset: 0x000DA0CD
		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_WidgetInteraction_61(base.GetCppThis(), eventPos);
		}

		// Token: 0x06009B3F RID: 39743
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_XShadowsOff_62(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe x-shadows.
		/// </summary>
		// Token: 0x06009B40 RID: 39744 RVA: 0x000DBEDD File Offset: 0x000DA0DD
		public void XShadowsOff()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_XShadowsOff_62(base.GetCppThis());
		}

		// Token: 0x06009B41 RID: 39745
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_XShadowsOn_63(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe x-shadows.
		/// </summary>
		// Token: 0x06009B42 RID: 39746 RVA: 0x000DBEEC File Offset: 0x000DA0EC
		public void XShadowsOn()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_XShadowsOn_63(base.GetCppThis());
		}

		// Token: 0x06009B43 RID: 39747
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_YShadowsOff_64(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe y-shadows.
		/// </summary>
		// Token: 0x06009B44 RID: 39748 RVA: 0x000DBEFB File Offset: 0x000DA0FB
		public void YShadowsOff()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_YShadowsOff_64(base.GetCppThis());
		}

		// Token: 0x06009B45 RID: 39749
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_YShadowsOn_65(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe y-shadows.
		/// </summary>
		// Token: 0x06009B46 RID: 39750 RVA: 0x000DBF0A File Offset: 0x000DA10A
		public void YShadowsOn()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_YShadowsOn_65(base.GetCppThis());
		}

		// Token: 0x06009B47 RID: 39751
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_ZShadowsOff_66(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe z-shadows.
		/// </summary>
		// Token: 0x06009B48 RID: 39752 RVA: 0x000DBF19 File Offset: 0x000DA119
		public void ZShadowsOff()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_ZShadowsOff_66(base.GetCppThis());
		}

		// Token: 0x06009B49 RID: 39753
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointHandleRepresentation3D_ZShadowsOn_67(HandleRef pThis);

		/// <summary>
		/// Turn on/off the wireframe z-shadows.
		/// </summary>
		// Token: 0x06009B4A RID: 39754 RVA: 0x000DBF28 File Offset: 0x000DA128
		public void ZShadowsOn()
		{
			vtkPointHandleRepresentation3D.vtkPointHandleRepresentation3D_ZShadowsOn_67(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C9B RID: 3227
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointHandleRepresentation3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C9C RID: 3228
		public new static readonly string MRClassNameKey = "class vtkPointHandleRepresentation3D";
	}
}
