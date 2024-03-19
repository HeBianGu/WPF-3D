using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLineRepresentation
	/// </summary>
	/// <remarks>
	///    a class defining the representation for a vtkLineWidget2
	///
	/// This class is a concrete representation for the vtkLineWidget2. It
	/// represents a straight line with three handles: one at the beginning and
	/// ending of the line, and one used to translate the line. Through
	/// interaction with the widget, the line representation can be arbitrarily
	/// placed in the 3D space.
	///
	/// To use this representation, you normally specify the position of the two
	/// end points (either in world or display coordinates). The PlaceWidget()
	/// method is also used to initially position the representation.
	///
	/// @warning
	/// This class, and vtkLineWidget2, are next generation VTK
	/// widgets. An earlier version of this functionality was defined in the
	/// class vtkLineWidget.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLineWidget2 vtkLineWidget
	/// </seealso>
	// Token: 0x02000336 RID: 822
	public class vtkLineRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009521 RID: 38177 RVA: 0x000D3367 File Offset: 0x000D1567
		static vtkLineRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLineRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLineRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009522 RID: 38178 RVA: 0x000D338F File Offset: 0x000D158F
		public vtkLineRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009523 RID: 38179
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06009524 RID: 38180 RVA: 0x000D33A0 File Offset: 0x000D15A0
		public new static vtkLineRepresentation New()
		{
			vtkLineRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06009525 RID: 38181 RVA: 0x000D33F4 File Offset: 0x000D15F4
		public vtkLineRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLineRepresentation.vtkLineRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009526 RID: 38182 RVA: 0x000D3438 File Offset: 0x000D1638
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009527 RID: 38183
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06009528 RID: 38184 RVA: 0x000D3443 File Offset: 0x000D1643
		public override void BuildRepresentation()
		{
			vtkLineRepresentation.vtkLineRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009529 RID: 38185
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600952A RID: 38186 RVA: 0x000D3454 File Offset: 0x000D1654
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkLineRepresentation.vtkLineRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x0600952B RID: 38187
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_DirectionalLineOff_03(HandleRef pThis);

		/// <summary>
		/// Sets the representation to be a directional line with point 1 represented
		/// as a cone.
		/// </summary>
		// Token: 0x0600952C RID: 38188 RVA: 0x000D3476 File Offset: 0x000D1676
		public virtual void DirectionalLineOff()
		{
			vtkLineRepresentation.vtkLineRepresentation_DirectionalLineOff_03(base.GetCppThis());
		}

		// Token: 0x0600952D RID: 38189
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_DirectionalLineOn_04(HandleRef pThis);

		/// <summary>
		/// Sets the representation to be a directional line with point 1 represented
		/// as a cone.
		/// </summary>
		// Token: 0x0600952E RID: 38190 RVA: 0x000D3485 File Offset: 0x000D1685
		public virtual void DirectionalLineOn()
		{
			vtkLineRepresentation.vtkLineRepresentation_DirectionalLineOn_04(base.GetCppThis());
		}

		// Token: 0x0600952F RID: 38191
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_DistanceAnnotationVisibilityOff_05(HandleRef pThis);

		/// <summary>
		/// Show the distance between the points.
		/// </summary>
		// Token: 0x06009530 RID: 38192 RVA: 0x000D3494 File Offset: 0x000D1694
		public virtual void DistanceAnnotationVisibilityOff()
		{
			vtkLineRepresentation.vtkLineRepresentation_DistanceAnnotationVisibilityOff_05(base.GetCppThis());
		}

		// Token: 0x06009531 RID: 38193
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_DistanceAnnotationVisibilityOn_06(HandleRef pThis);

		/// <summary>
		/// Show the distance between the points.
		/// </summary>
		// Token: 0x06009532 RID: 38194 RVA: 0x000D34A3 File Offset: 0x000D16A3
		public virtual void DistanceAnnotationVisibilityOn()
		{
			vtkLineRepresentation.vtkLineRepresentation_DistanceAnnotationVisibilityOn_06(base.GetCppThis());
		}

		// Token: 0x06009533 RID: 38195
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_GetActors_07(HandleRef pThis, HandleRef pc);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06009534 RID: 38196 RVA: 0x000D34B4 File Offset: 0x000D16B4
		public override void GetActors(vtkPropCollection pc)
		{
			vtkLineRepresentation.vtkLineRepresentation_GetActors_07(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		// Token: 0x06009535 RID: 38197
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetBounds_08(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06009536 RID: 38198 RVA: 0x000D34E4 File Offset: 0x000D16E4
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetBounds_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009537 RID: 38199
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLineRepresentation_GetDirectionalLine_09(HandleRef pThis);

		/// <summary>
		/// Sets the representation to be a directional line with point 1 represented
		/// as a cone.
		/// </summary>
		// Token: 0x06009538 RID: 38200 RVA: 0x000D352C File Offset: 0x000D172C
		public virtual bool GetDirectionalLine()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetDirectionalLine_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06009539 RID: 38201
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLineRepresentation_GetDistance_10(HandleRef pThis);

		/// <summary>
		/// Get the distance between the points.
		/// </summary>
		// Token: 0x0600953A RID: 38202 RVA: 0x000D3554 File Offset: 0x000D1754
		public double GetDistance()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetDistance_10(base.GetCppThis());
		}

		// Token: 0x0600953B RID: 38203
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetDistanceAnnotationFormat_11(HandleRef pThis);

		/// <summary>
		/// Specify the format to use for labelling the line. Note that an empty
		/// string results in no label, or a format string without a "%" character
		/// will not print the angle value.
		/// </summary>
		// Token: 0x0600953C RID: 38204 RVA: 0x000D3574 File Offset: 0x000D1774
		public virtual string GetDistanceAnnotationFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkLineRepresentation.vtkLineRepresentation_GetDistanceAnnotationFormat_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600953D RID: 38205
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetDistanceAnnotationProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the distance annotation property
		/// </summary>
		// Token: 0x0600953E RID: 38206 RVA: 0x000D35B0 File Offset: 0x000D17B0
		public virtual vtkProperty GetDistanceAnnotationProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetDistanceAnnotationProperty_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600953F RID: 38207
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetDistanceAnnotationScale_13(HandleRef pThis);

		/// <summary>
		/// Scale text (font size along each dimension).
		/// </summary>
		// Token: 0x06009540 RID: 38208 RVA: 0x000D3620 File Offset: 0x000D1820
		public virtual IntPtr GetDistanceAnnotationScale()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetDistanceAnnotationScale_13(base.GetCppThis());
		}

		// Token: 0x06009541 RID: 38209
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineRepresentation_GetDistanceAnnotationVisibility_14(HandleRef pThis);

		/// <summary>
		/// Show the distance between the points.
		/// </summary>
		// Token: 0x06009542 RID: 38210 RVA: 0x000D3640 File Offset: 0x000D1840
		public virtual int GetDistanceAnnotationVisibility()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetDistanceAnnotationVisibility_14(base.GetCppThis());
		}

		// Token: 0x06009543 RID: 38211
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetEndPoint2Property_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the end-point (sphere) properties. The properties of the end-points
		/// when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x06009544 RID: 38212 RVA: 0x000D3660 File Offset: 0x000D1860
		public virtual vtkProperty GetEndPoint2Property()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetEndPoint2Property_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009545 RID: 38213
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetEndPointProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the end-point (sphere) properties. The properties of the end-points
		/// when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x06009546 RID: 38214 RVA: 0x000D36D0 File Offset: 0x000D18D0
		public virtual vtkProperty GetEndPointProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetEndPointProperty_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009547 RID: 38215
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineRepresentation_GetInteractionStateMaxValue_17(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., vtkLineWidget2) or
		/// other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// process with the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x06009548 RID: 38216 RVA: 0x000D3740 File Offset: 0x000D1940
		public virtual int GetInteractionStateMaxValue()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetInteractionStateMaxValue_17(base.GetCppThis());
		}

		// Token: 0x06009549 RID: 38217
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineRepresentation_GetInteractionStateMinValue_18(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., vtkLineWidget2) or
		/// other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// process with the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x0600954A RID: 38218 RVA: 0x000D3760 File Offset: 0x000D1960
		public virtual int GetInteractionStateMinValue()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetInteractionStateMinValue_18(base.GetCppThis());
		}

		// Token: 0x0600954B RID: 38219
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetLineHandleRepresentation_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the three handle representations used for the vtkLineWidget2.
		/// </summary>
		// Token: 0x0600954C RID: 38220 RVA: 0x000D3780 File Offset: 0x000D1980
		public virtual vtkPointHandleRepresentation3D GetLineHandleRepresentation()
		{
			vtkPointHandleRepresentation3D vtkPointHandleRepresentation3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetLineHandleRepresentation_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600954D RID: 38221
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetLineProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600954E RID: 38222 RVA: 0x000D37F0 File Offset: 0x000D19F0
		public virtual vtkProperty GetLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetLineProperty_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600954F RID: 38223
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkLineRepresentation_GetMTime_21(HandleRef pThis);

		/// <summary>
		/// Overload the superclasses' GetMTime() because internal classes
		/// are used to keep the state of the representation.
		/// </summary>
		// Token: 0x06009550 RID: 38224 RVA: 0x000D3860 File Offset: 0x000D1A60
		public override ulong GetMTime()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetMTime_21(base.GetCppThis());
		}

		// Token: 0x06009551 RID: 38225
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLineRepresentation_GetNumberOfGenerationsFromBase_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06009552 RID: 38226 RVA: 0x000D3880 File Offset: 0x000D1A80
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetNumberOfGenerationsFromBase_22(base.GetCppThis(), type);
		}

		// Token: 0x06009553 RID: 38227
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLineRepresentation_GetNumberOfGenerationsFromBaseType_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06009554 RID: 38228 RVA: 0x000D38A0 File Offset: 0x000D1AA0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetNumberOfGenerationsFromBaseType_23(type);
		}

		// Token: 0x06009555 RID: 38229
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_GetPoint1DisplayPosition_24(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06009556 RID: 38230 RVA: 0x000D38BA File Offset: 0x000D1ABA
		public void GetPoint1DisplayPosition(IntPtr pos)
		{
			vtkLineRepresentation.vtkLineRepresentation_GetPoint1DisplayPosition_24(base.GetCppThis(), pos);
		}

		// Token: 0x06009557 RID: 38231
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetPoint1DisplayPosition_25(HandleRef pThis);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06009558 RID: 38232 RVA: 0x000D38CC File Offset: 0x000D1ACC
		public double[] GetPoint1DisplayPosition()
		{
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetPoint1DisplayPosition_25(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009559 RID: 38233
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetPoint1Representation_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the three handle representations used for the vtkLineWidget2.
		/// </summary>
		// Token: 0x0600955A RID: 38234 RVA: 0x000D3914 File Offset: 0x000D1B14
		public virtual vtkPointHandleRepresentation3D GetPoint1Representation()
		{
			vtkPointHandleRepresentation3D vtkPointHandleRepresentation3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetPoint1Representation_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600955B RID: 38235
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_GetPoint1WorldPosition_27(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x0600955C RID: 38236 RVA: 0x000D3983 File Offset: 0x000D1B83
		public void GetPoint1WorldPosition(IntPtr pos)
		{
			vtkLineRepresentation.vtkLineRepresentation_GetPoint1WorldPosition_27(base.GetCppThis(), pos);
		}

		// Token: 0x0600955D RID: 38237
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetPoint1WorldPosition_28(HandleRef pThis);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x0600955E RID: 38238 RVA: 0x000D3994 File Offset: 0x000D1B94
		public double[] GetPoint1WorldPosition()
		{
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetPoint1WorldPosition_28(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600955F RID: 38239
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_GetPoint2DisplayPosition_29(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06009560 RID: 38240 RVA: 0x000D39DC File Offset: 0x000D1BDC
		public void GetPoint2DisplayPosition(IntPtr pos)
		{
			vtkLineRepresentation.vtkLineRepresentation_GetPoint2DisplayPosition_29(base.GetCppThis(), pos);
		}

		// Token: 0x06009561 RID: 38241
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetPoint2DisplayPosition_30(HandleRef pThis);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06009562 RID: 38242 RVA: 0x000D39EC File Offset: 0x000D1BEC
		public double[] GetPoint2DisplayPosition()
		{
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetPoint2DisplayPosition_30(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009563 RID: 38243
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetPoint2Representation_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the three handle representations used for the vtkLineWidget2.
		/// </summary>
		// Token: 0x06009564 RID: 38244 RVA: 0x000D3A34 File Offset: 0x000D1C34
		public virtual vtkPointHandleRepresentation3D GetPoint2Representation()
		{
			vtkPointHandleRepresentation3D vtkPointHandleRepresentation3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetPoint2Representation_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009565 RID: 38245
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_GetPoint2WorldPosition_32(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06009566 RID: 38246 RVA: 0x000D3AA3 File Offset: 0x000D1CA3
		public void GetPoint2WorldPosition(IntPtr pos)
		{
			vtkLineRepresentation.vtkLineRepresentation_GetPoint2WorldPosition_32(base.GetCppThis(), pos);
		}

		// Token: 0x06009567 RID: 38247
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetPoint2WorldPosition_33(HandleRef pThis);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06009568 RID: 38248 RVA: 0x000D3AB4 File Offset: 0x000D1CB4
		public double[] GetPoint2WorldPosition()
		{
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetPoint2WorldPosition_33(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009569 RID: 38249
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_GetPolyData_34(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Retrieve the polydata (including points) that defines the line.  The
		/// polydata consists of n+1 points, where n is the resolution of the
		/// line. These point values are guaranteed to be up-to-date whenever any
		/// one of the three handles are moved. To use this method, the user
		/// provides the vtkPolyData as an input argument, and the points and
		/// polyline are copied into it.
		/// </summary>
		// Token: 0x0600956A RID: 38250 RVA: 0x000D3AFC File Offset: 0x000D1CFC
		public void GetPolyData(vtkPolyData pd)
		{
			vtkLineRepresentation.vtkLineRepresentation_GetPolyData_34(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600956B RID: 38251
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineRepresentation_GetRepresentationState_35(HandleRef pThis);

		/// <summary>
		/// Sets the visual appearance of the representation based on the
		/// state it is in. This state is usually the same as InteractionState.
		/// </summary>
		// Token: 0x0600956C RID: 38252 RVA: 0x000D3B2C File Offset: 0x000D1D2C
		public virtual int GetRepresentationState()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetRepresentationState_35(base.GetCppThis());
		}

		// Token: 0x0600956D RID: 38253
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineRepresentation_GetResolution_36(HandleRef pThis);

		/// <summary>
		/// Set/Get the resolution (number of subdivisions) of the line. A line with
		/// resolution greater than one is useful when points along the line are
		/// desired; e.g., generating a rake of streamlines.
		/// </summary>
		// Token: 0x0600956E RID: 38254 RVA: 0x000D3B4C File Offset: 0x000D1D4C
		public int GetResolution()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetResolution_36(base.GetCppThis());
		}

		// Token: 0x0600956F RID: 38255
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetSelectedEndPoint2Property_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the end-point (sphere) properties. The properties of the end-points
		/// when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x06009570 RID: 38256 RVA: 0x000D3B6C File Offset: 0x000D1D6C
		public virtual vtkProperty GetSelectedEndPoint2Property()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetSelectedEndPoint2Property_37(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009571 RID: 38257
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetSelectedEndPointProperty_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the end-point (sphere) properties. The properties of the end-points
		/// when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x06009572 RID: 38258 RVA: 0x000D3BDC File Offset: 0x000D1DDC
		public virtual vtkProperty GetSelectedEndPointProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetSelectedEndPointProperty_38(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009573 RID: 38259
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetSelectedLineProperty_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06009574 RID: 38260 RVA: 0x000D3C4C File Offset: 0x000D1E4C
		public virtual vtkProperty GetSelectedLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetSelectedLineProperty_39(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009575 RID: 38261
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_GetTextActor_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the text actor
		/// </summary>
		// Token: 0x06009576 RID: 38262 RVA: 0x000D3CBC File Offset: 0x000D1EBC
		public virtual vtkFollower GetTextActor()
		{
			vtkFollower vtkFollower = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetTextActor_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFollower = (vtkFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFollower.Register(null);
				}
			}
			return vtkFollower;
		}

		// Token: 0x06009577 RID: 38263
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineRepresentation_GetTolerance_41(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels) in
		/// which the cursor is considered near enough to the line or end point
		/// to be active.
		/// </summary>
		// Token: 0x06009578 RID: 38264 RVA: 0x000D3D2C File Offset: 0x000D1F2C
		public virtual int GetTolerance()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetTolerance_41(base.GetCppThis());
		}

		// Token: 0x06009579 RID: 38265
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineRepresentation_GetToleranceMaxValue_42(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels) in
		/// which the cursor is considered near enough to the line or end point
		/// to be active.
		/// </summary>
		// Token: 0x0600957A RID: 38266 RVA: 0x000D3D4C File Offset: 0x000D1F4C
		public virtual int GetToleranceMaxValue()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetToleranceMaxValue_42(base.GetCppThis());
		}

		// Token: 0x0600957B RID: 38267
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineRepresentation_GetToleranceMinValue_43(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels) in
		/// which the cursor is considered near enough to the line or end point
		/// to be active.
		/// </summary>
		// Token: 0x0600957C RID: 38268 RVA: 0x000D3D6C File Offset: 0x000D1F6C
		public virtual int GetToleranceMinValue()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetToleranceMinValue_43(base.GetCppThis());
		}

		// Token: 0x0600957D RID: 38269
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineRepresentation_HasTranslucentPolygonalGeometry_44(HandleRef pThis);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600957E RID: 38270 RVA: 0x000D3D8C File Offset: 0x000D1F8C
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkLineRepresentation.vtkLineRepresentation_HasTranslucentPolygonalGeometry_44(base.GetCppThis());
		}

		// Token: 0x0600957F RID: 38271
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_InstantiateHandleRepresentation_45(HandleRef pThis);

		/// <summary>
		/// This method is used to specify the type of handle representation to
		/// use for the three internal vtkHandleWidgets within vtkLineWidget2.
		/// To use this method, create a dummy vtkHandleWidget (or subclass),
		/// and then invoke this method with this dummy. Then the
		/// vtkLineRepresentation uses this dummy to clone three vtkHandleWidgets
		/// of the same type. Make sure you set the handle representation before
		/// the widget is enabled. (The method InstantiateHandleRepresentation()
		/// is invoked by the vtkLineWidget2.)
		/// </summary>
		// Token: 0x06009580 RID: 38272 RVA: 0x000D3DAB File Offset: 0x000D1FAB
		public void InstantiateHandleRepresentation()
		{
			vtkLineRepresentation.vtkLineRepresentation_InstantiateHandleRepresentation_45(base.GetCppThis());
		}

		// Token: 0x06009581 RID: 38273
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineRepresentation_IsA_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06009582 RID: 38274 RVA: 0x000D3DBC File Offset: 0x000D1FBC
		public override int IsA(string type)
		{
			return vtkLineRepresentation.vtkLineRepresentation_IsA_46(base.GetCppThis(), type);
		}

		// Token: 0x06009583 RID: 38275
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineRepresentation_IsTypeOf_47([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06009584 RID: 38276 RVA: 0x000D3DDC File Offset: 0x000D1FDC
		public new static int IsTypeOf(string type)
		{
			return vtkLineRepresentation.vtkLineRepresentation_IsTypeOf_47(type);
		}

		// Token: 0x06009585 RID: 38277
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_NewInstance_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06009586 RID: 38278 RVA: 0x000D3DF8 File Offset: 0x000D1FF8
		public new vtkLineRepresentation NewInstance()
		{
			vtkLineRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_NewInstance_49(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009587 RID: 38279
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_PlaceWidget_50(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06009588 RID: 38280 RVA: 0x000D3E52 File Offset: 0x000D2052
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkLineRepresentation.vtkLineRepresentation_PlaceWidget_50(base.GetCppThis(), bounds);
		}

		// Token: 0x06009589 RID: 38281
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_ReleaseGraphicsResources_51(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600958A RID: 38282 RVA: 0x000D3E64 File Offset: 0x000D2064
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLineRepresentation.vtkLineRepresentation_ReleaseGraphicsResources_51(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600958B RID: 38283
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineRepresentation_RenderOpaqueGeometry_52(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600958C RID: 38284 RVA: 0x000D3E94 File Offset: 0x000D2094
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkLineRepresentation.vtkLineRepresentation_RenderOpaqueGeometry_52(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600958D RID: 38285
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineRepresentation_RenderTranslucentPolygonalGeometry_53(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600958E RID: 38286 RVA: 0x000D3EC8 File Offset: 0x000D20C8
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkLineRepresentation.vtkLineRepresentation_RenderTranslucentPolygonalGeometry_53(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600958F RID: 38287
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineRepresentation_SafeDownCast_54(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06009590 RID: 38288 RVA: 0x000D3EFC File Offset: 0x000D20FC
		public new static vtkLineRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkLineRepresentation vtkLineRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_SafeDownCast_54((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLineRepresentation = (vtkLineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLineRepresentation.Register(null);
				}
			}
			return vtkLineRepresentation;
		}

		// Token: 0x06009591 RID: 38289
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetDirectionalLine_55(HandleRef pThis, byte val);

		/// <summary>
		/// Sets the representation to be a directional line with point 1 represented
		/// as a cone.
		/// </summary>
		// Token: 0x06009592 RID: 38290 RVA: 0x000D3F7B File Offset: 0x000D217B
		public void SetDirectionalLine(bool val)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetDirectionalLine_55(base.GetCppThis(), val ? (byte)1 : (byte)0);
		}

		// Token: 0x06009593 RID: 38291
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetDistanceAnnotationFormat_56(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the format to use for labelling the line. Note that an empty
		/// string results in no label, or a format string without a "%" character
		/// will not print the angle value.
		/// </summary>
		// Token: 0x06009594 RID: 38292 RVA: 0x000D3F93 File Offset: 0x000D2193
		public virtual void SetDistanceAnnotationFormat(string _arg)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetDistanceAnnotationFormat_56(base.GetCppThis(), _arg);
		}

		// Token: 0x06009595 RID: 38293
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetDistanceAnnotationScale_57(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Scale text (font size along each dimension).
		/// </summary>
		// Token: 0x06009596 RID: 38294 RVA: 0x000D3FA3 File Offset: 0x000D21A3
		public void SetDistanceAnnotationScale(double x, double y, double z)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetDistanceAnnotationScale_57(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06009597 RID: 38295
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetDistanceAnnotationScale_58(HandleRef pThis, IntPtr scale);

		/// <summary>
		/// Scale text (font size along each dimension).
		/// </summary>
		// Token: 0x06009598 RID: 38296 RVA: 0x000D3FB5 File Offset: 0x000D21B5
		public virtual void SetDistanceAnnotationScale(IntPtr scale)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetDistanceAnnotationScale_58(base.GetCppThis(), scale);
		}

		// Token: 0x06009599 RID: 38297
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetDistanceAnnotationVisibility_59(HandleRef pThis, int _arg);

		/// <summary>
		/// Show the distance between the points.
		/// </summary>
		// Token: 0x0600959A RID: 38298 RVA: 0x000D3FC5 File Offset: 0x000D21C5
		public virtual void SetDistanceAnnotationVisibility(int _arg)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetDistanceAnnotationVisibility_59(base.GetCppThis(), _arg);
		}

		// Token: 0x0600959B RID: 38299
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetForegroundColor_60(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the widget color, and the color of interactive handles.
		/// </summary>
		// Token: 0x0600959C RID: 38300 RVA: 0x000D3FD5 File Offset: 0x000D21D5
		public void SetForegroundColor(double arg0, double arg1, double arg2)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetForegroundColor_60(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x0600959D RID: 38301
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetForegroundColor_61(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the widget color, and the color of interactive handles.
		/// </summary>
		// Token: 0x0600959E RID: 38302 RVA: 0x000D3FE7 File Offset: 0x000D21E7
		public void SetForegroundColor(IntPtr c)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetForegroundColor_61(base.GetCppThis(), c);
		}

		// Token: 0x0600959F RID: 38303
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetHandleRepresentation_62(HandleRef pThis, HandleRef handle);

		/// <summary>
		/// This method is used to specify the type of handle representation to
		/// use for the three internal vtkHandleWidgets within vtkLineWidget2.
		/// To use this method, create a dummy vtkHandleWidget (or subclass),
		/// and then invoke this method with this dummy. Then the
		/// vtkLineRepresentation uses this dummy to clone three vtkHandleWidgets
		/// of the same type. Make sure you set the handle representation before
		/// the widget is enabled. (The method InstantiateHandleRepresentation()
		/// is invoked by the vtkLineWidget2.)
		/// </summary>
		// Token: 0x060095A0 RID: 38304 RVA: 0x000D3FF8 File Offset: 0x000D21F8
		public void SetHandleRepresentation(vtkPointHandleRepresentation3D handle)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetHandleRepresentation_62(base.GetCppThis(), (handle == null) ? default(HandleRef) : handle.GetCppThis());
		}

		// Token: 0x060095A1 RID: 38305
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetInteractionColor_63(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the widget color, and the color of interactive handles.
		/// </summary>
		// Token: 0x060095A2 RID: 38306 RVA: 0x000D4027 File Offset: 0x000D2227
		public void SetInteractionColor(double arg0, double arg1, double arg2)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetInteractionColor_63(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x060095A3 RID: 38307
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetInteractionColor_64(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the widget color, and the color of interactive handles.
		/// </summary>
		// Token: 0x060095A4 RID: 38308 RVA: 0x000D4039 File Offset: 0x000D2239
		public void SetInteractionColor(IntPtr c)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetInteractionColor_64(base.GetCppThis(), c);
		}

		// Token: 0x060095A5 RID: 38309
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetInteractionState_65(HandleRef pThis, int _arg);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., vtkLineWidget2) or
		/// other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// process with the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x060095A6 RID: 38310 RVA: 0x000D4049 File Offset: 0x000D2249
		public virtual void SetInteractionState(int _arg)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetInteractionState_65(base.GetCppThis(), _arg);
		}

		// Token: 0x060095A7 RID: 38311
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetLineColor_66(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Convenience method to set the line color.
		/// Ideally one should use GetLineProperty()-&gt;SetColor().
		/// </summary>
		// Token: 0x060095A8 RID: 38312 RVA: 0x000D4059 File Offset: 0x000D2259
		public void SetLineColor(double r, double g, double b)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetLineColor_66(base.GetCppThis(), r, g, b);
		}

		// Token: 0x060095A9 RID: 38313
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetPoint1DisplayPosition_67(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x060095AA RID: 38314 RVA: 0x000D406B File Offset: 0x000D226B
		public void SetPoint1DisplayPosition(IntPtr pos)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetPoint1DisplayPosition_67(base.GetCppThis(), pos);
		}

		// Token: 0x060095AB RID: 38315
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetPoint1WorldPosition_68(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x060095AC RID: 38316 RVA: 0x000D407B File Offset: 0x000D227B
		public void SetPoint1WorldPosition(IntPtr pos)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetPoint1WorldPosition_68(base.GetCppThis(), pos);
		}

		// Token: 0x060095AD RID: 38317
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetPoint2DisplayPosition_69(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x060095AE RID: 38318 RVA: 0x000D408B File Offset: 0x000D228B
		public void SetPoint2DisplayPosition(IntPtr pos)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetPoint2DisplayPosition_69(base.GetCppThis(), pos);
		}

		// Token: 0x060095AF RID: 38319
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetPoint2WorldPosition_70(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x060095B0 RID: 38320 RVA: 0x000D409B File Offset: 0x000D229B
		public void SetPoint2WorldPosition(IntPtr pos)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetPoint2WorldPosition_70(base.GetCppThis(), pos);
		}

		// Token: 0x060095B1 RID: 38321
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetRenderer_71(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Overridden to set the rendererer on the internal representations.
		/// </summary>
		// Token: 0x060095B2 RID: 38322 RVA: 0x000D40AC File Offset: 0x000D22AC
		public override void SetRenderer(vtkRenderer ren)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetRenderer_71(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x060095B3 RID: 38323
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetRepresentationState_72(HandleRef pThis, int arg0);

		/// <summary>
		/// Sets the visual appearance of the representation based on the
		/// state it is in. This state is usually the same as InteractionState.
		/// </summary>
		// Token: 0x060095B4 RID: 38324 RVA: 0x000D40DB File Offset: 0x000D22DB
		public virtual void SetRepresentationState(int arg0)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetRepresentationState_72(base.GetCppThis(), arg0);
		}

		// Token: 0x060095B5 RID: 38325
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetResolution_73(HandleRef pThis, int res);

		/// <summary>
		/// Set/Get the resolution (number of subdivisions) of the line. A line with
		/// resolution greater than one is useful when points along the line are
		/// desired; e.g., generating a rake of streamlines.
		/// </summary>
		// Token: 0x060095B6 RID: 38326 RVA: 0x000D40EB File Offset: 0x000D22EB
		public void SetResolution(int res)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetResolution_73(base.GetCppThis(), res);
		}

		// Token: 0x060095B7 RID: 38327
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_SetTolerance_74(HandleRef pThis, int _arg);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels) in
		/// which the cursor is considered near enough to the line or end point
		/// to be active.
		/// </summary>
		// Token: 0x060095B8 RID: 38328 RVA: 0x000D40FB File Offset: 0x000D22FB
		public virtual void SetTolerance(int _arg)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetTolerance_74(base.GetCppThis(), _arg);
		}

		// Token: 0x060095B9 RID: 38329
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_StartWidgetInteraction_75(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060095BA RID: 38330 RVA: 0x000D410B File Offset: 0x000D230B
		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkLineRepresentation.vtkLineRepresentation_StartWidgetInteraction_75(base.GetCppThis(), e);
		}

		// Token: 0x060095BB RID: 38331
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineRepresentation_WidgetInteraction_76(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060095BC RID: 38332 RVA: 0x000D411B File Offset: 0x000D231B
		public override void WidgetInteraction(IntPtr e)
		{
			vtkLineRepresentation.vtkLineRepresentation_WidgetInteraction_76(base.GetCppThis(), e);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C3F RID: 3135
		public new const string MRFullTypeName = "Kitware.VTK.vtkLineRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C40 RID: 3136
		public new static readonly string MRClassNameKey = "class vtkLineRepresentation";

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x02000337 RID: 823
		public enum OnLine_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000C42 RID: 3138
			OnLine = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000C43 RID: 3139
			OnP1 = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000C44 RID: 3140
			OnP2,
			/// <summary>enum member</summary>
			// Token: 0x04000C45 RID: 3141
			Outside = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000C46 RID: 3142
			Scaling = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000C47 RID: 3143
			TranslatingP1 = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000C48 RID: 3144
			TranslatingP2
		}

		/// <summary>
		/// Get the text actor
		/// </summary>
		// Token: 0x02000338 RID: 824
		public enum RestrictNone_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000C4A RID: 3146
			RestrictNone,
			/// <summary>enum member</summary>
			// Token: 0x04000C4B RID: 3147
			RestrictToX,
			/// <summary>enum member</summary>
			// Token: 0x04000C4C RID: 3148
			RestrictToY,
			/// <summary>enum member</summary>
			// Token: 0x04000C4D RID: 3149
			RestrictToZ
		}
	}
}
