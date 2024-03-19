using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLightRepresentation
	/// </summary>
	/// <remarks>
	///    represent a vtkLight
	///
	/// The vtkLightRepresentation is a representation for the vtkLight.
	/// This representation consists of a LightPosition sphere with an automatically resized
	/// radius so it is always visible, a line between the LightPosition and the FocalPoint and
	/// a cone of angle ConeAngle when using Positional.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLightWidget vtkSphereWidget vtkSphereRepresentation
	/// </seealso>
	// Token: 0x02000332 RID: 818
	public class vtkLightRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060094AB RID: 38059 RVA: 0x000D2833 File Offset: 0x000D0A33
		static vtkLightRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLightRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLightRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060094AC RID: 38060 RVA: 0x000D285B File Offset: 0x000D0A5B
		public vtkLightRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060094AD RID: 38061
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060094AE RID: 38062 RVA: 0x000D286C File Offset: 0x000D0A6C
		public new static vtkLightRepresentation New()
		{
			vtkLightRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightRepresentation.vtkLightRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060094AF RID: 38063 RVA: 0x000D28C0 File Offset: 0x000D0AC0
		public vtkLightRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLightRepresentation.vtkLightRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060094B0 RID: 38064 RVA: 0x000D2904 File Offset: 0x000D0B04
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060094B1 RID: 38065
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Method to satisfy superclasses' API.
		/// </summary>
		// Token: 0x060094B2 RID: 38066 RVA: 0x000D290F File Offset: 0x000D0B0F
		public override void BuildRepresentation()
		{
			vtkLightRepresentation.vtkLightRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x060094B3 RID: 38067
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Method to satisfy superclasses' API.
		/// </summary>
		// Token: 0x060094B4 RID: 38068 RVA: 0x000D2920 File Offset: 0x000D0B20
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkLightRepresentation.vtkLightRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x060094B5 RID: 38069
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightRepresentation_GetBounds_03(HandleRef pThis);

		/// <summary>
		/// Method to satisfy superclasses' API.
		/// </summary>
		// Token: 0x060094B6 RID: 38070 RVA: 0x000D2944 File Offset: 0x000D0B44
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkLightRepresentation.vtkLightRepresentation_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060094B7 RID: 38071
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightRepresentation_GetConeAngle_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the cone angle, in degrees, for the light.
		/// Used only when positional.
		/// </summary>
		// Token: 0x060094B8 RID: 38072 RVA: 0x000D298C File Offset: 0x000D0B8C
		public virtual double GetConeAngle()
		{
			return vtkLightRepresentation.vtkLightRepresentation_GetConeAngle_04(base.GetCppThis());
		}

		// Token: 0x060094B9 RID: 38073
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightRepresentation_GetFocalPoint_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the coordinates of the focal point of the light representation.
		/// </summary>
		// Token: 0x060094BA RID: 38074 RVA: 0x000D29AC File Offset: 0x000D0BAC
		public virtual double[] GetFocalPoint()
		{
			IntPtr intPtr = vtkLightRepresentation.vtkLightRepresentation_GetFocalPoint_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060094BB RID: 38075
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightRepresentation_GetFocalPoint_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the coordinates of the focal point of the light representation.
		/// </summary>
		// Token: 0x060094BC RID: 38076 RVA: 0x000D29F4 File Offset: 0x000D0BF4
		public virtual void GetFocalPoint(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkLightRepresentation.vtkLightRepresentation_GetFocalPoint_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060094BD RID: 38077
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightRepresentation_GetFocalPoint_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the coordinates of the focal point of the light representation.
		/// </summary>
		// Token: 0x060094BE RID: 38078 RVA: 0x000D2A06 File Offset: 0x000D0C06
		public virtual void GetFocalPoint(IntPtr _arg)
		{
			vtkLightRepresentation.vtkLightRepresentation_GetFocalPoint_07(base.GetCppThis(), _arg);
		}

		// Token: 0x060094BF RID: 38079
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightRepresentation_GetInteractionStateMaxValue_08(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., vtkLightWidget) or
		/// other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// process with the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x060094C0 RID: 38080 RVA: 0x000D2A18 File Offset: 0x000D0C18
		public virtual int GetInteractionStateMaxValue()
		{
			return vtkLightRepresentation.vtkLightRepresentation_GetInteractionStateMaxValue_08(base.GetCppThis());
		}

		// Token: 0x060094C1 RID: 38081
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightRepresentation_GetInteractionStateMinValue_09(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., vtkLightWidget) or
		/// other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// process with the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x060094C2 RID: 38082 RVA: 0x000D2A38 File Offset: 0x000D0C38
		public virtual int GetInteractionStateMinValue()
		{
			return vtkLightRepresentation.vtkLightRepresentation_GetInteractionStateMinValue_09(base.GetCppThis());
		}

		// Token: 0x060094C3 RID: 38083
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightRepresentation_GetLightColor_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the light color.
		/// </summary>
		// Token: 0x060094C4 RID: 38084 RVA: 0x000D2A58 File Offset: 0x000D0C58
		public IntPtr GetLightColor()
		{
			return vtkLightRepresentation.vtkLightRepresentation_GetLightColor_10(base.GetCppThis());
		}

		// Token: 0x060094C5 RID: 38085
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightRepresentation_GetLightPosition_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the coordinates of the position of the light representation.
		/// </summary>
		// Token: 0x060094C6 RID: 38086 RVA: 0x000D2A78 File Offset: 0x000D0C78
		public virtual double[] GetLightPosition()
		{
			IntPtr intPtr = vtkLightRepresentation.vtkLightRepresentation_GetLightPosition_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060094C7 RID: 38087
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightRepresentation_GetLightPosition_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the coordinates of the position of the light representation.
		/// </summary>
		// Token: 0x060094C8 RID: 38088 RVA: 0x000D2AC0 File Offset: 0x000D0CC0
		public virtual void GetLightPosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkLightRepresentation.vtkLightRepresentation_GetLightPosition_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060094C9 RID: 38089
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightRepresentation_GetLightPosition_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the coordinates of the position of the light representation.
		/// </summary>
		// Token: 0x060094CA RID: 38090 RVA: 0x000D2AD2 File Offset: 0x000D0CD2
		public virtual void GetLightPosition(IntPtr _arg)
		{
			vtkLightRepresentation.vtkLightRepresentation_GetLightPosition_13(base.GetCppThis(), _arg);
		}

		// Token: 0x060094CB RID: 38091
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLightRepresentation_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060094CC RID: 38092 RVA: 0x000D2AE4 File Offset: 0x000D0CE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLightRepresentation.vtkLightRepresentation_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x060094CD RID: 38093
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLightRepresentation_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060094CE RID: 38094 RVA: 0x000D2B04 File Offset: 0x000D0D04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLightRepresentation.vtkLightRepresentation_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x060094CF RID: 38095
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLightRepresentation_GetPositional_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the positional flag. When set to on, a cone will be visible.
		/// </summary>
		// Token: 0x060094D0 RID: 38096 RVA: 0x000D2B20 File Offset: 0x000D0D20
		public virtual bool GetPositional()
		{
			return vtkLightRepresentation.vtkLightRepresentation_GetPositional_16(base.GetCppThis()) != 0;
		}

		// Token: 0x060094D1 RID: 38097
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightRepresentation_GetProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property used for all the actors
		/// </summary>
		// Token: 0x060094D2 RID: 38098 RVA: 0x000D2B48 File Offset: 0x000D0D48
		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightRepresentation.vtkLightRepresentation_GetProperty_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060094D3 RID: 38099
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightRepresentation_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060094D4 RID: 38100 RVA: 0x000D2BB8 File Offset: 0x000D0DB8
		public override int IsA(string type)
		{
			return vtkLightRepresentation.vtkLightRepresentation_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x060094D5 RID: 38101
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightRepresentation_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060094D6 RID: 38102 RVA: 0x000D2BD8 File Offset: 0x000D0DD8
		public new static int IsTypeOf(string type)
		{
			return vtkLightRepresentation.vtkLightRepresentation_IsTypeOf_19(type);
		}

		// Token: 0x060094D7 RID: 38103
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightRepresentation_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060094D8 RID: 38104 RVA: 0x000D2BF4 File Offset: 0x000D0DF4
		public new vtkLightRepresentation NewInstance()
		{
			vtkLightRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightRepresentation.vtkLightRepresentation_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060094D9 RID: 38105
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightRepresentation_PositionalOff_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the positional flag. When set to on, a cone will be visible.
		/// </summary>
		// Token: 0x060094DA RID: 38106 RVA: 0x000D2C4E File Offset: 0x000D0E4E
		public virtual void PositionalOff()
		{
			vtkLightRepresentation.vtkLightRepresentation_PositionalOff_22(base.GetCppThis());
		}

		// Token: 0x060094DB RID: 38107
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightRepresentation_PositionalOn_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the positional flag. When set to on, a cone will be visible.
		/// </summary>
		// Token: 0x060094DC RID: 38108 RVA: 0x000D2C5D File Offset: 0x000D0E5D
		public virtual void PositionalOn()
		{
			vtkLightRepresentation.vtkLightRepresentation_PositionalOn_23(base.GetCppThis());
		}

		// Token: 0x060094DD RID: 38109
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightRepresentation_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x060094DE RID: 38110 RVA: 0x000D2C6C File Offset: 0x000D0E6C
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkLightRepresentation.vtkLightRepresentation_ReleaseGraphicsResources_24(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x060094DF RID: 38111
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightRepresentation_RenderOpaqueGeometry_25(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x060094E0 RID: 38112 RVA: 0x000D2C9C File Offset: 0x000D0E9C
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkLightRepresentation.vtkLightRepresentation_RenderOpaqueGeometry_25(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060094E1 RID: 38113
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightRepresentation_RenderTranslucentPolygonalGeometry_26(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x060094E2 RID: 38114 RVA: 0x000D2CD0 File Offset: 0x000D0ED0
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkLightRepresentation.vtkLightRepresentation_RenderTranslucentPolygonalGeometry_26(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060094E3 RID: 38115
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightRepresentation_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060094E4 RID: 38116 RVA: 0x000D2D04 File Offset: 0x000D0F04
		public new static vtkLightRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkLightRepresentation vtkLightRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightRepresentation.vtkLightRepresentation_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLightRepresentation = (vtkLightRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLightRepresentation.Register(null);
				}
			}
			return vtkLightRepresentation;
		}

		// Token: 0x060094E5 RID: 38117
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightRepresentation_SetConeAngle_28(HandleRef pThis, double angle);

		/// <summary>
		/// Set/Get the cone angle, in degrees, for the light.
		/// Used only when positional.
		/// </summary>
		// Token: 0x060094E6 RID: 38118 RVA: 0x000D2D83 File Offset: 0x000D0F83
		public void SetConeAngle(double angle)
		{
			vtkLightRepresentation.vtkLightRepresentation_SetConeAngle_28(base.GetCppThis(), angle);
		}

		// Token: 0x060094E7 RID: 38119
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightRepresentation_SetFocalPoint_29(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Set/Get the coordinates of the focal point of the light representation.
		/// </summary>
		// Token: 0x060094E8 RID: 38120 RVA: 0x000D2D93 File Offset: 0x000D0F93
		public void SetFocalPoint(IntPtr pos)
		{
			vtkLightRepresentation.vtkLightRepresentation_SetFocalPoint_29(base.GetCppThis(), pos);
		}

		// Token: 0x060094E9 RID: 38121
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightRepresentation_SetInteractionState_30(HandleRef pThis, int _arg);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., vtkLightWidget) or
		/// other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// process with the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x060094EA RID: 38122 RVA: 0x000D2DA3 File Offset: 0x000D0FA3
		public virtual void SetInteractionState(int _arg)
		{
			vtkLightRepresentation.vtkLightRepresentation_SetInteractionState_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060094EB RID: 38123
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightRepresentation_SetLightColor_31(HandleRef pThis, IntPtr color);

		/// <summary>
		/// Set/Get the light color.
		/// </summary>
		// Token: 0x060094EC RID: 38124 RVA: 0x000D2DB3 File Offset: 0x000D0FB3
		public void SetLightColor(IntPtr color)
		{
			vtkLightRepresentation.vtkLightRepresentation_SetLightColor_31(base.GetCppThis(), color);
		}

		// Token: 0x060094ED RID: 38125
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightRepresentation_SetLightPosition_32(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Set/Get the coordinates of the position of the light representation.
		/// </summary>
		// Token: 0x060094EE RID: 38126 RVA: 0x000D2DC3 File Offset: 0x000D0FC3
		public void SetLightPosition(IntPtr pos)
		{
			vtkLightRepresentation.vtkLightRepresentation_SetLightPosition_32(base.GetCppThis(), pos);
		}

		// Token: 0x060094EF RID: 38127
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightRepresentation_SetPositional_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the positional flag. When set to on, a cone will be visible.
		/// </summary>
		// Token: 0x060094F0 RID: 38128 RVA: 0x000D2DD3 File Offset: 0x000D0FD3
		public virtual void SetPositional(bool _arg)
		{
			vtkLightRepresentation.vtkLightRepresentation_SetPositional_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060094F1 RID: 38129
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightRepresentation_StartWidgetInteraction_34(HandleRef pThis, IntPtr eventPosition);

		/// <summary>
		/// Method to satisfy superclasses' API.
		/// </summary>
		// Token: 0x060094F2 RID: 38130 RVA: 0x000D2DEB File Offset: 0x000D0FEB
		public override void StartWidgetInteraction(IntPtr eventPosition)
		{
			vtkLightRepresentation.vtkLightRepresentation_StartWidgetInteraction_34(base.GetCppThis(), eventPosition);
		}

		// Token: 0x060094F3 RID: 38131
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightRepresentation_WidgetInteraction_35(HandleRef pThis, IntPtr eventPosition);

		/// <summary>
		/// Method to satisfy superclasses' API.
		/// </summary>
		// Token: 0x060094F4 RID: 38132 RVA: 0x000D2DFB File Offset: 0x000D0FFB
		public override void WidgetInteraction(IntPtr eventPosition)
		{
			vtkLightRepresentation.vtkLightRepresentation_WidgetInteraction_35(base.GetCppThis(), eventPosition);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C33 RID: 3123
		public new const string MRFullTypeName = "Kitware.VTK.vtkLightRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C34 RID: 3124
		public new static readonly string MRClassNameKey = "class vtkLightRepresentation";

		/// <summary>
		/// Enum used to communicate interaction state.
		/// </summary>
		// Token: 0x02000333 RID: 819
		public enum MovingFocalPoint_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000C36 RID: 3126
			MovingFocalPoint = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000C37 RID: 3127
			MovingLight = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000C38 RID: 3128
			MovingPositionalFocalPoint = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000C39 RID: 3129
			Outside = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000C3A RID: 3130
			ScalingConeAngle = 4
		}
	}
}
