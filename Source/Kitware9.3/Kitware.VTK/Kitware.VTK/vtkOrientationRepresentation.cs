using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOrientationRepresentation
	/// </summary>
	/// <remarks>
	///    a class defining the representation for the vtkOrientationWidget
	///
	/// This class is a concrete representation for the vtkOrientationWidget.
	/// The widget is represented by three flat tori of different colors in
	/// each base direction (X/Y/Z). Additional arrows can be added to it for
	/// each direction in order to simplify grabbing and understanding. Their
	/// default look is a diamond shape, but they can be customized to look
	/// like real double arrows.
	///
	/// To use this representation, you can use the PlaceWidget() method to
	/// position the widget around an actor and scale it properly.
	/// You can retrieve orientation values with component-wise getters or
	/// through a vtkTransform.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkOrientationWidget
	/// </seealso>
	// Token: 0x02000342 RID: 834
	public class vtkOrientationRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060097A7 RID: 38823 RVA: 0x000D6B70 File Offset: 0x000D4D70
		static vtkOrientationRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOrientationRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrientationRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060097A8 RID: 38824 RVA: 0x000D6B98 File Offset: 0x000D4D98
		public vtkOrientationRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060097A9 RID: 38825
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060097AA RID: 38826 RVA: 0x000D6BA8 File Offset: 0x000D4DA8
		public new static vtkOrientationRepresentation New()
		{
			vtkOrientationRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientationRepresentation.vtkOrientationRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientationRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060097AB RID: 38827 RVA: 0x000D6BFC File Offset: 0x000D4DFC
		public vtkOrientationRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOrientationRepresentation.vtkOrientationRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060097AC RID: 38828 RVA: 0x000D6C40 File Offset: 0x000D4E40
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060097AD RID: 38829
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060097AE RID: 38830 RVA: 0x000D6C4B File Offset: 0x000D4E4B
		public override void BuildRepresentation()
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x060097AF RID: 38831
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientationRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060097B0 RID: 38832 RVA: 0x000D6C5C File Offset: 0x000D4E5C
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x060097B1 RID: 38833
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_GetActors_03(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp (i.e., support rendering).
		/// GetActors adds all the internal props used by this representation to the supplied collection.
		/// </summary>
		// Token: 0x060097B2 RID: 38834 RVA: 0x000D6C80 File Offset: 0x000D4E80
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_GetActors_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060097B3 RID: 38835
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetArrowDistance_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the distance between arrows and torus.
		/// Clamped between [0.0, 0.5].
		/// Default: 0.0.
		/// </summary>
		// Token: 0x060097B4 RID: 38836 RVA: 0x000D6CB0 File Offset: 0x000D4EB0
		public virtual double GetArrowDistance()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetArrowDistance_04(base.GetCppThis());
		}

		// Token: 0x060097B5 RID: 38837
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetArrowDistanceMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the distance between arrows and torus.
		/// Clamped between [0.0, 0.5].
		/// Default: 0.0.
		/// </summary>
		// Token: 0x060097B6 RID: 38838 RVA: 0x000D6CD0 File Offset: 0x000D4ED0
		public virtual double GetArrowDistanceMaxValue()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetArrowDistanceMaxValue_05(base.GetCppThis());
		}

		// Token: 0x060097B7 RID: 38839
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetArrowDistanceMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the distance between arrows and torus.
		/// Clamped between [0.0, 0.5].
		/// Default: 0.0.
		/// </summary>
		// Token: 0x060097B8 RID: 38840 RVA: 0x000D6CF0 File Offset: 0x000D4EF0
		public virtual double GetArrowDistanceMinValue()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetArrowDistanceMinValue_06(base.GetCppThis());
		}

		// Token: 0x060097B9 RID: 38841
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetArrowLength_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the arrow length.
		/// This includes shaft+tip.
		/// Note that double arrows are two arrows
		/// next to each other.
		/// Clamped between [0.01, 0.5].
		/// Default: 0.05.
		/// </summary>
		// Token: 0x060097BA RID: 38842 RVA: 0x000D6D10 File Offset: 0x000D4F10
		public virtual double GetArrowLength()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetArrowLength_07(base.GetCppThis());
		}

		// Token: 0x060097BB RID: 38843
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetArrowLengthMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the arrow length.
		/// This includes shaft+tip.
		/// Note that double arrows are two arrows
		/// next to each other.
		/// Clamped between [0.01, 0.5].
		/// Default: 0.05.
		/// </summary>
		// Token: 0x060097BC RID: 38844 RVA: 0x000D6D30 File Offset: 0x000D4F30
		public virtual double GetArrowLengthMaxValue()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetArrowLengthMaxValue_08(base.GetCppThis());
		}

		// Token: 0x060097BD RID: 38845
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetArrowLengthMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the arrow length.
		/// This includes shaft+tip.
		/// Note that double arrows are two arrows
		/// next to each other.
		/// Clamped between [0.01, 0.5].
		/// Default: 0.05.
		/// </summary>
		// Token: 0x060097BE RID: 38846 RVA: 0x000D6D50 File Offset: 0x000D4F50
		public virtual double GetArrowLengthMinValue()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetArrowLengthMinValue_09(base.GetCppThis());
		}

		// Token: 0x060097BF RID: 38847
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetArrowShaftRadius_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius of the arrow shaft.
		/// Clamped between [0.001, 0.5].
		/// Default: 0.001.
		/// </summary>
		// Token: 0x060097C0 RID: 38848 RVA: 0x000D6D70 File Offset: 0x000D4F70
		public virtual double GetArrowShaftRadius()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetArrowShaftRadius_10(base.GetCppThis());
		}

		// Token: 0x060097C1 RID: 38849
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetArrowShaftRadiusMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius of the arrow shaft.
		/// Clamped between [0.001, 0.5].
		/// Default: 0.001.
		/// </summary>
		// Token: 0x060097C2 RID: 38850 RVA: 0x000D6D90 File Offset: 0x000D4F90
		public virtual double GetArrowShaftRadiusMaxValue()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetArrowShaftRadiusMaxValue_11(base.GetCppThis());
		}

		// Token: 0x060097C3 RID: 38851
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetArrowShaftRadiusMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius of the arrow shaft.
		/// Clamped between [0.001, 0.5].
		/// Default: 0.001.
		/// </summary>
		// Token: 0x060097C4 RID: 38852 RVA: 0x000D6DB0 File Offset: 0x000D4FB0
		public virtual double GetArrowShaftRadiusMinValue()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetArrowShaftRadiusMinValue_12(base.GetCppThis());
		}

		// Token: 0x060097C5 RID: 38853
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetArrowTipLength_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the length of the arrow tip.
		/// Factor of arrow length, equals if set to 1.
		/// Note that double arrows are two arrows
		/// next to each other.
		/// Clamped between [0.0, 1.0].
		/// Default: 1.0.
		/// </summary>
		// Token: 0x060097C6 RID: 38854 RVA: 0x000D6DD0 File Offset: 0x000D4FD0
		public virtual double GetArrowTipLength()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetArrowTipLength_13(base.GetCppThis());
		}

		// Token: 0x060097C7 RID: 38855
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetArrowTipRadius_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius of the arrow tip.
		/// Clamped between [0.001, 0.5].
		/// Default: 0.03.
		/// </summary>
		// Token: 0x060097C8 RID: 38856 RVA: 0x000D6DF0 File Offset: 0x000D4FF0
		public virtual double GetArrowTipRadius()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetArrowTipRadius_14(base.GetCppThis());
		}

		// Token: 0x060097C9 RID: 38857
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetArrowTipRadiusMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius of the arrow tip.
		/// Clamped between [0.001, 0.5].
		/// Default: 0.03.
		/// </summary>
		// Token: 0x060097CA RID: 38858 RVA: 0x000D6E10 File Offset: 0x000D5010
		public virtual double GetArrowTipRadiusMaxValue()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetArrowTipRadiusMaxValue_15(base.GetCppThis());
		}

		// Token: 0x060097CB RID: 38859
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetArrowTipRadiusMinValue_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius of the arrow tip.
		/// Clamped between [0.001, 0.5].
		/// Default: 0.03.
		/// </summary>
		// Token: 0x060097CC RID: 38860 RVA: 0x000D6E30 File Offset: 0x000D5030
		public virtual double GetArrowTipRadiusMinValue()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetArrowTipRadiusMinValue_16(base.GetCppThis());
		}

		// Token: 0x060097CD RID: 38861
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationRepresentation_GetBounds_17(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060097CE RID: 38862 RVA: 0x000D6E50 File Offset: 0x000D5050
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkOrientationRepresentation.vtkOrientationRepresentation_GetBounds_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060097CF RID: 38863
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrientationRepresentation_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060097D0 RID: 38864 RVA: 0x000D6E98 File Offset: 0x000D5098
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x060097D1 RID: 38865
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrientationRepresentation_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060097D2 RID: 38866 RVA: 0x000D6EB8 File Offset: 0x000D50B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x060097D3 RID: 38867
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationRepresentation_GetOrientation_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the orientation values.
		/// Angles are in interval [-180, 180] degrees.
		/// </summary>
		// Token: 0x060097D4 RID: 38868 RVA: 0x000D6ED4 File Offset: 0x000D50D4
		public IntPtr GetOrientation()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetOrientation_20(base.GetCppThis());
		}

		// Token: 0x060097D5 RID: 38869
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetOrientationX_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the orientation values.
		/// Angles are in interval [-180, 180] degrees.
		/// </summary>
		// Token: 0x060097D6 RID: 38870 RVA: 0x000D6EF4 File Offset: 0x000D50F4
		public double GetOrientationX()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetOrientationX_21(base.GetCppThis());
		}

		// Token: 0x060097D7 RID: 38871
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetOrientationY_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the orientation values.
		/// Angles are in interval [-180, 180] degrees.
		/// </summary>
		// Token: 0x060097D8 RID: 38872 RVA: 0x000D6F14 File Offset: 0x000D5114
		public double GetOrientationY()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetOrientationY_22(base.GetCppThis());
		}

		// Token: 0x060097D9 RID: 38873
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetOrientationZ_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the orientation values.
		/// Angles are in interval [-180, 180] degrees.
		/// </summary>
		// Token: 0x060097DA RID: 38874 RVA: 0x000D6F34 File Offset: 0x000D5134
		public double GetOrientationZ()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetOrientationZ_23(base.GetCppThis());
		}

		// Token: 0x060097DB RID: 38875
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationRepresentation_GetProperty_24(HandleRef pThis, int axis, byte selected, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the properties values.
		/// Axis is clamped to axis values.
		/// If selected is true, applies to selected properties (on hover or click).
		/// </summary>
		// Token: 0x060097DC RID: 38876 RVA: 0x000D6F54 File Offset: 0x000D5154
		public vtkProperty GetProperty(int axis, bool selected)
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientationRepresentation.vtkOrientationRepresentation_GetProperty_24(base.GetCppThis(), axis, selected ? (byte)1 : (byte)0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060097DD RID: 38877
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationRepresentation_GetPropertyX_25(HandleRef pThis, byte selected, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the properties values.
		/// Axis is clamped to axis values.
		/// If selected is true, applies to selected properties (on hover or click).
		/// </summary>
		// Token: 0x060097DE RID: 38878 RVA: 0x000D6FD0 File Offset: 0x000D51D0
		public vtkProperty GetPropertyX(bool selected)
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientationRepresentation.vtkOrientationRepresentation_GetPropertyX_25(base.GetCppThis(), selected ? (byte)1 : (byte)0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060097DF RID: 38879
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationRepresentation_GetPropertyY_26(HandleRef pThis, byte selected, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the properties values.
		/// Axis is clamped to axis values.
		/// If selected is true, applies to selected properties (on hover or click).
		/// </summary>
		// Token: 0x060097E0 RID: 38880 RVA: 0x000D7048 File Offset: 0x000D5248
		public vtkProperty GetPropertyY(bool selected)
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientationRepresentation.vtkOrientationRepresentation_GetPropertyY_26(base.GetCppThis(), selected ? (byte)1 : (byte)0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060097E1 RID: 38881
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationRepresentation_GetPropertyZ_27(HandleRef pThis, byte selected, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the properties values.
		/// Axis is clamped to axis values.
		/// If selected is true, applies to selected properties (on hover or click).
		/// </summary>
		// Token: 0x060097E2 RID: 38882 RVA: 0x000D70C0 File Offset: 0x000D52C0
		public vtkProperty GetPropertyZ(bool selected)
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientationRepresentation.vtkOrientationRepresentation_GetPropertyZ_27(base.GetCppThis(), selected ? (byte)1 : (byte)0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060097E3 RID: 38883
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOrientationRepresentation_GetShowArrows_28(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to show arrows.
		/// Default: False.
		/// </summary>
		// Token: 0x060097E4 RID: 38884 RVA: 0x000D7138 File Offset: 0x000D5338
		public virtual bool GetShowArrows()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetShowArrows_28(base.GetCppThis()) != 0;
		}

		// Token: 0x060097E5 RID: 38885
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetTorusLength_29(HandleRef pThis);

		/// <summary>
		/// Set/Get the length (Z scale) of the torus.
		/// This is a factor of Thickness parameter.
		/// Clamped between [0.01, 100.0].
		/// Default: 7.5.
		/// </summary>
		// Token: 0x060097E6 RID: 38886 RVA: 0x000D7160 File Offset: 0x000D5360
		public virtual double GetTorusLength()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetTorusLength_29(base.GetCppThis());
		}

		// Token: 0x060097E7 RID: 38887
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetTorusLengthMaxValue_30(HandleRef pThis);

		/// <summary>
		/// Set/Get the length (Z scale) of the torus.
		/// This is a factor of Thickness parameter.
		/// Clamped between [0.01, 100.0].
		/// Default: 7.5.
		/// </summary>
		// Token: 0x060097E8 RID: 38888 RVA: 0x000D7180 File Offset: 0x000D5380
		public virtual double GetTorusLengthMaxValue()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetTorusLengthMaxValue_30(base.GetCppThis());
		}

		// Token: 0x060097E9 RID: 38889
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetTorusLengthMinValue_31(HandleRef pThis);

		/// <summary>
		/// Set/Get the length (Z scale) of the torus.
		/// This is a factor of Thickness parameter.
		/// Clamped between [0.01, 100.0].
		/// Default: 7.5.
		/// </summary>
		// Token: 0x060097EA RID: 38890 RVA: 0x000D71A0 File Offset: 0x000D53A0
		public virtual double GetTorusLengthMinValue()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetTorusLengthMinValue_31(base.GetCppThis());
		}

		// Token: 0x060097EB RID: 38891
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetTorusThickness_32(HandleRef pThis);

		/// <summary>
		/// Set/Get the thickness of the torus.
		/// Thickness handles width in every axes.
		/// This means Length depends on it.
		/// Clamped between [0.001, 0.1].
		/// Default: 0.005.
		/// </summary>
		// Token: 0x060097EC RID: 38892 RVA: 0x000D71C0 File Offset: 0x000D53C0
		public virtual double GetTorusThickness()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetTorusThickness_32(base.GetCppThis());
		}

		// Token: 0x060097ED RID: 38893
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetTorusThicknessMaxValue_33(HandleRef pThis);

		/// <summary>
		/// Set/Get the thickness of the torus.
		/// Thickness handles width in every axes.
		/// This means Length depends on it.
		/// Clamped between [0.001, 0.1].
		/// Default: 0.005.
		/// </summary>
		// Token: 0x060097EE RID: 38894 RVA: 0x000D71E0 File Offset: 0x000D53E0
		public virtual double GetTorusThicknessMaxValue()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetTorusThicknessMaxValue_33(base.GetCppThis());
		}

		// Token: 0x060097EF RID: 38895
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationRepresentation_GetTorusThicknessMinValue_34(HandleRef pThis);

		/// <summary>
		/// Set/Get the thickness of the torus.
		/// Thickness handles width in every axes.
		/// This means Length depends on it.
		/// Clamped between [0.001, 0.1].
		/// Default: 0.005.
		/// </summary>
		// Token: 0x060097F0 RID: 38896 RVA: 0x000D7200 File Offset: 0x000D5400
		public virtual double GetTorusThicknessMinValue()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_GetTorusThicknessMinValue_34(base.GetCppThis());
		}

		// Token: 0x060097F1 RID: 38897
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationRepresentation_GetTransform_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the orientation transform.
		/// </summary>
		// Token: 0x060097F2 RID: 38898 RVA: 0x000D7220 File Offset: 0x000D5420
		public vtkTransform GetTransform()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientationRepresentation.vtkOrientationRepresentation_GetTransform_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		// Token: 0x060097F3 RID: 38899
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientationRepresentation_HasTranslucentPolygonalGeometry_36(HandleRef pThis);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x060097F4 RID: 38900 RVA: 0x000D7290 File Offset: 0x000D5490
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_HasTranslucentPolygonalGeometry_36(base.GetCppThis());
		}

		// Token: 0x060097F5 RID: 38901
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientationRepresentation_IsA_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060097F6 RID: 38902 RVA: 0x000D72B0 File Offset: 0x000D54B0
		public override int IsA(string type)
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_IsA_37(base.GetCppThis(), type);
		}

		// Token: 0x060097F7 RID: 38903
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientationRepresentation_IsTypeOf_38([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060097F8 RID: 38904 RVA: 0x000D72D0 File Offset: 0x000D54D0
		public new static int IsTypeOf(string type)
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_IsTypeOf_38(type);
		}

		// Token: 0x060097F9 RID: 38905
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationRepresentation_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060097FA RID: 38906 RVA: 0x000D72EC File Offset: 0x000D54EC
		public new vtkOrientationRepresentation NewInstance()
		{
			vtkOrientationRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientationRepresentation.vtkOrientationRepresentation_NewInstance_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientationRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060097FB RID: 38907
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_PlaceWidget_41(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060097FC RID: 38908 RVA: 0x000D7346 File Offset: 0x000D5546
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_PlaceWidget_41(base.GetCppThis(), bounds);
		}

		// Token: 0x060097FD RID: 38909
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_RegisterPickers_42(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., vtkOrientationWidget)
		/// or other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// process with the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x060097FE RID: 38910 RVA: 0x000D7356 File Offset: 0x000D5556
		public override void RegisterPickers()
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_RegisterPickers_42(base.GetCppThis());
		}

		// Token: 0x060097FF RID: 38911
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_ReleaseGraphicsResources_43(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x06009800 RID: 38912 RVA: 0x000D7368 File Offset: 0x000D5568
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_ReleaseGraphicsResources_43(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009801 RID: 38913
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientationRepresentation_RenderOpaqueGeometry_44(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x06009802 RID: 38914 RVA: 0x000D7398 File Offset: 0x000D5598
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_RenderOpaqueGeometry_44(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009803 RID: 38915
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientationRepresentation_RenderTranslucentPolygonalGeometry_45(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x06009804 RID: 38916 RVA: 0x000D73CC File Offset: 0x000D55CC
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkOrientationRepresentation.vtkOrientationRepresentation_RenderTranslucentPolygonalGeometry_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009805 RID: 38917
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationRepresentation_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06009806 RID: 38918 RVA: 0x000D7400 File Offset: 0x000D5600
		public new static vtkOrientationRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkOrientationRepresentation vtkOrientationRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientationRepresentation.vtkOrientationRepresentation_SafeDownCast_46((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOrientationRepresentation = (vtkOrientationRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOrientationRepresentation.Register(null);
				}
			}
			return vtkOrientationRepresentation;
		}

		// Token: 0x06009807 RID: 38919
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_SetArrowDistance_47(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the distance between arrows and torus.
		/// Clamped between [0.0, 0.5].
		/// Default: 0.0.
		/// </summary>
		// Token: 0x06009808 RID: 38920 RVA: 0x000D747F File Offset: 0x000D567F
		public virtual void SetArrowDistance(double _arg)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_SetArrowDistance_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06009809 RID: 38921
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_SetArrowLength_48(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the arrow length.
		/// This includes shaft+tip.
		/// Note that double arrows are two arrows
		/// next to each other.
		/// Clamped between [0.01, 0.5].
		/// Default: 0.05.
		/// </summary>
		// Token: 0x0600980A RID: 38922 RVA: 0x000D748F File Offset: 0x000D568F
		public virtual void SetArrowLength(double _arg)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_SetArrowLength_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0600980B RID: 38923
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_SetArrowShaftRadius_49(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the radius of the arrow shaft.
		/// Clamped between [0.001, 0.5].
		/// Default: 0.001.
		/// </summary>
		// Token: 0x0600980C RID: 38924 RVA: 0x000D749F File Offset: 0x000D569F
		public virtual void SetArrowShaftRadius(double _arg)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_SetArrowShaftRadius_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0600980D RID: 38925
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_SetArrowTipLength_50(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the length of the arrow tip.
		/// Factor of arrow length, equals if set to 1.
		/// Note that double arrows are two arrows
		/// next to each other.
		/// Clamped between [0.0, 1.0].
		/// Default: 1.0.
		/// </summary>
		// Token: 0x0600980E RID: 38926 RVA: 0x000D74AF File Offset: 0x000D56AF
		public virtual void SetArrowTipLength(double _arg)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_SetArrowTipLength_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0600980F RID: 38927
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_SetArrowTipRadius_51(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the radius of the arrow tip.
		/// Clamped between [0.001, 0.5].
		/// Default: 0.03.
		/// </summary>
		// Token: 0x06009810 RID: 38928 RVA: 0x000D74BF File Offset: 0x000D56BF
		public virtual void SetArrowTipRadius(double _arg)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_SetArrowTipRadius_51(base.GetCppThis(), _arg);
		}

		// Token: 0x06009811 RID: 38929
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_SetInteractionState_52(HandleRef pThis, int state);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., vtkOrientationWidget)
		/// or other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// process with the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x06009812 RID: 38930 RVA: 0x000D74CF File Offset: 0x000D56CF
		public void SetInteractionState(int state)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_SetInteractionState_52(base.GetCppThis(), state);
		}

		// Token: 0x06009813 RID: 38931
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_SetOrientation_53(HandleRef pThis, IntPtr values);

		/// <summary>
		/// Set/Get the orientation values.
		/// Angles are in interval [-180, 180] degrees.
		/// </summary>
		// Token: 0x06009814 RID: 38932 RVA: 0x000D74DF File Offset: 0x000D56DF
		public virtual void SetOrientation(IntPtr values)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_SetOrientation_53(base.GetCppThis(), values);
		}

		// Token: 0x06009815 RID: 38933
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_SetOrientationX_54(HandleRef pThis, double value);

		/// <summary>
		/// Set/Get the orientation values.
		/// Angles are in interval [-180, 180] degrees.
		/// </summary>
		// Token: 0x06009816 RID: 38934 RVA: 0x000D74EF File Offset: 0x000D56EF
		public virtual void SetOrientationX(double value)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_SetOrientationX_54(base.GetCppThis(), value);
		}

		// Token: 0x06009817 RID: 38935
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_SetOrientationY_55(HandleRef pThis, double value);

		/// <summary>
		/// Set/Get the orientation values.
		/// Angles are in interval [-180, 180] degrees.
		/// </summary>
		// Token: 0x06009818 RID: 38936 RVA: 0x000D74FF File Offset: 0x000D56FF
		public virtual void SetOrientationY(double value)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_SetOrientationY_55(base.GetCppThis(), value);
		}

		// Token: 0x06009819 RID: 38937
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_SetOrientationZ_56(HandleRef pThis, double value);

		/// <summary>
		/// Set/Get the orientation values.
		/// Angles are in interval [-180, 180] degrees.
		/// </summary>
		// Token: 0x0600981A RID: 38938 RVA: 0x000D750F File Offset: 0x000D570F
		public virtual void SetOrientationZ(double value)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_SetOrientationZ_56(base.GetCppThis(), value);
		}

		// Token: 0x0600981B RID: 38939
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_SetProperty_57(HandleRef pThis, int axis, byte selected, HandleRef property);

		/// <summary>
		/// Set/Get the properties values.
		/// Axis is clamped to axis values.
		/// If selected is true, applies to selected properties (on hover or click).
		/// </summary>
		// Token: 0x0600981C RID: 38940 RVA: 0x000D7520 File Offset: 0x000D5720
		public void SetProperty(int axis, bool selected, vtkProperty property)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_SetProperty_57(base.GetCppThis(), axis, selected ? (byte)1 : (byte)0, (property == null) ? default(HandleRef) : property.GetCppThis());
		}

		// Token: 0x0600981D RID: 38941
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_SetPropertyX_58(HandleRef pThis, byte selected, HandleRef property);

		/// <summary>
		/// Set/Get the properties values.
		/// Axis is clamped to axis values.
		/// If selected is true, applies to selected properties (on hover or click).
		/// </summary>
		// Token: 0x0600981E RID: 38942 RVA: 0x000D755C File Offset: 0x000D575C
		public void SetPropertyX(bool selected, vtkProperty property)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_SetPropertyX_58(base.GetCppThis(), selected ? (byte)1 : (byte)0, (property == null) ? default(HandleRef) : property.GetCppThis());
		}

		// Token: 0x0600981F RID: 38943
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_SetPropertyY_59(HandleRef pThis, byte selected, HandleRef property);

		/// <summary>
		/// Set/Get the properties values.
		/// Axis is clamped to axis values.
		/// If selected is true, applies to selected properties (on hover or click).
		/// </summary>
		// Token: 0x06009820 RID: 38944 RVA: 0x000D7594 File Offset: 0x000D5794
		public void SetPropertyY(bool selected, vtkProperty property)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_SetPropertyY_59(base.GetCppThis(), selected ? (byte)1 : (byte)0, (property == null) ? default(HandleRef) : property.GetCppThis());
		}

		// Token: 0x06009821 RID: 38945
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_SetPropertyZ_60(HandleRef pThis, byte selected, HandleRef property);

		/// <summary>
		/// Set/Get the properties values.
		/// Axis is clamped to axis values.
		/// If selected is true, applies to selected properties (on hover or click).
		/// </summary>
		// Token: 0x06009822 RID: 38946 RVA: 0x000D75CC File Offset: 0x000D57CC
		public void SetPropertyZ(bool selected, vtkProperty property)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_SetPropertyZ_60(base.GetCppThis(), selected ? (byte)1 : (byte)0, (property == null) ? default(HandleRef) : property.GetCppThis());
		}

		// Token: 0x06009823 RID: 38947
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_SetShowArrows_61(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether to show arrows.
		/// Default: False.
		/// </summary>
		// Token: 0x06009824 RID: 38948 RVA: 0x000D7604 File Offset: 0x000D5804
		public virtual void SetShowArrows(bool _arg)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_SetShowArrows_61(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06009825 RID: 38949
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_SetTorusLength_62(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the length (Z scale) of the torus.
		/// This is a factor of Thickness parameter.
		/// Clamped between [0.01, 100.0].
		/// Default: 7.5.
		/// </summary>
		// Token: 0x06009826 RID: 38950 RVA: 0x000D761C File Offset: 0x000D581C
		public virtual void SetTorusLength(double _arg)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_SetTorusLength_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06009827 RID: 38951
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_SetTorusThickness_63(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the thickness of the torus.
		/// Thickness handles width in every axes.
		/// This means Length depends on it.
		/// Clamped between [0.001, 0.1].
		/// Default: 0.005.
		/// </summary>
		// Token: 0x06009828 RID: 38952 RVA: 0x000D762C File Offset: 0x000D582C
		public virtual void SetTorusThickness(double _arg)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_SetTorusThickness_63(base.GetCppThis(), _arg);
		}

		// Token: 0x06009829 RID: 38953
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_ShowArrowsOff_64(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to show arrows.
		/// Default: False.
		/// </summary>
		// Token: 0x0600982A RID: 38954 RVA: 0x000D763C File Offset: 0x000D583C
		public virtual void ShowArrowsOff()
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_ShowArrowsOff_64(base.GetCppThis());
		}

		// Token: 0x0600982B RID: 38955
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_ShowArrowsOn_65(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to show arrows.
		/// Default: False.
		/// </summary>
		// Token: 0x0600982C RID: 38956 RVA: 0x000D764B File Offset: 0x000D584B
		public virtual void ShowArrowsOn()
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_ShowArrowsOn_65(base.GetCppThis());
		}

		// Token: 0x0600982D RID: 38957
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_StartWidgetInteraction_66(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600982E RID: 38958 RVA: 0x000D765A File Offset: 0x000D585A
		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_StartWidgetInteraction_66(base.GetCppThis(), e);
		}

		// Token: 0x0600982F RID: 38959
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationRepresentation_WidgetInteraction_67(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06009830 RID: 38960 RVA: 0x000D766A File Offset: 0x000D586A
		public override void WidgetInteraction(IntPtr e)
		{
			vtkOrientationRepresentation.vtkOrientationRepresentation_WidgetInteraction_67(base.GetCppThis(), e);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C61 RID: 3169
		public new const string MRFullTypeName = "Kitware.VTK.vtkOrientationRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C62 RID: 3170
		public new static readonly string MRClassNameKey = "class vtkOrientationRepresentation";

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp (i.e., support rendering).
		/// GetActors adds all the internal props used by this representation to the supplied collection.
		/// </summary>
		// Token: 0x02000343 RID: 835
		public enum Outside_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000C64 RID: 3172
			Outside,
			/// <summary>enum member</summary>
			// Token: 0x04000C65 RID: 3173
			RotatingX,
			/// <summary>enum member</summary>
			// Token: 0x04000C66 RID: 3174
			RotatingY,
			/// <summary>enum member</summary>
			// Token: 0x04000C67 RID: 3175
			RotatingZ
		}

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp (i.e., support rendering).
		/// GetActors adds all the internal props used by this representation to the supplied collection.
		/// </summary>
		// Token: 0x02000344 RID: 836
		public new enum Axis
		{
			/// <summary>enum member</summary>
			// Token: 0x04000C69 RID: 3177
			X_AXIS,
			/// <summary>enum member</summary>
			// Token: 0x04000C6A RID: 3178
			Y_AXIS,
			/// <summary>enum member</summary>
			// Token: 0x04000C6B RID: 3179
			Z_AXIS
		}
	}
}
