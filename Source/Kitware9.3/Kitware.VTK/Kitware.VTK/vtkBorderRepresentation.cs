using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBorderRepresentation
	/// </summary>
	/// <remarks>
	///    represent a vtkBorderWidget
	///
	/// This class is used to represent and render a vtBorderWidget. To
	/// use this class, you need to specify the two corners of a rectangular
	/// region.
	///
	/// The class is typically subclassed so that specialized representations can
	/// be created.  The class defines an API and a default implementation that
	/// the vtkBorderRepresentation interacts with to render itself in the scene.
	///
	/// @warning
	/// The separation of the widget event handling (e.g., vtkBorderWidget) from
	/// the representation (vtkBorderRepresentation) enables users and developers
	/// to create new appearances for the widget. It also facilitates parallel
	/// processing, where the client application handles events, and remote
	/// representations of the widget are slaves to the client (and do not handle
	/// events).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBorderWidget vtkTextWidget
	/// </seealso>
	// Token: 0x020002CE RID: 718
	public class vtkBorderRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060080D9 RID: 32985 RVA: 0x000B8CCD File Offset: 0x000B6ECD
		static vtkBorderRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBorderRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBorderRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060080DA RID: 32986 RVA: 0x000B8CF5 File Offset: 0x000B6EF5
		public vtkBorderRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060080DB RID: 32987
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060080DC RID: 32988 RVA: 0x000B8D04 File Offset: 0x000B6F04
		public new static vtkBorderRepresentation New()
		{
			vtkBorderRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBorderRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060080DD RID: 32989 RVA: 0x000B8D58 File Offset: 0x000B6F58
		public vtkBorderRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBorderRepresentation.vtkBorderRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060080DE RID: 32990 RVA: 0x000B8D9C File Offset: 0x000B6F9C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060080DF RID: 32991
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Subclasses should implement these methods. See the superclasses'
		/// documentation for more information.
		/// </summary>
		// Token: 0x060080E0 RID: 32992 RVA: 0x000B8DA7 File Offset: 0x000B6FA7
		public override void BuildRepresentation()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x060080E1 RID: 32993
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Subclasses should implement these methods. See the superclasses'
		/// documentation for more information.
		/// </summary>
		// Token: 0x060080E2 RID: 32994 RVA: 0x000B8DB8 File Offset: 0x000B6FB8
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x060080E3 RID: 32995
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_EnforceNormalizedViewportBoundsOff_03(HandleRef pThis);

		/// <summary>
		/// Whether to enforce the minimum normalized viewport size and limit
		/// the normalized viewport coordinates to [0.0 -&gt; 1.0]. This keeps
		/// widgets from being moved offscreen or being scaled down past their
		/// minimum viewport size.
		///
		/// Off by Default.
		///
		/// Note: ProportionalResize must be off for this function to take effect.
		/// </summary>
		// Token: 0x060080E4 RID: 32996 RVA: 0x000B8DDA File Offset: 0x000B6FDA
		public virtual void EnforceNormalizedViewportBoundsOff()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_EnforceNormalizedViewportBoundsOff_03(base.GetCppThis());
		}

		// Token: 0x060080E5 RID: 32997
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_EnforceNormalizedViewportBoundsOn_04(HandleRef pThis);

		/// <summary>
		/// Whether to enforce the minimum normalized viewport size and limit
		/// the normalized viewport coordinates to [0.0 -&gt; 1.0]. This keeps
		/// widgets from being moved offscreen or being scaled down past their
		/// minimum viewport size.
		///
		/// Off by Default.
		///
		/// Note: ProportionalResize must be off for this function to take effect.
		/// </summary>
		// Token: 0x060080E6 RID: 32998 RVA: 0x000B8DE9 File Offset: 0x000B6FE9
		public virtual void EnforceNormalizedViewportBoundsOn()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_EnforceNormalizedViewportBoundsOn_04(base.GetCppThis());
		}

		// Token: 0x060080E7 RID: 32999
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_GetActors2D_05(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x060080E8 RID: 33000 RVA: 0x000B8DF8 File Offset: 0x000B6FF8
		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetActors2D_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060080E9 RID: 33001
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderRepresentation_GetBorderColor_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the RGB color of the border.
		/// Default is white (1.0, 1.0, 1.0).
		/// </summary>
		// Token: 0x060080EA RID: 33002 RVA: 0x000B8E28 File Offset: 0x000B7028
		public virtual double[] GetBorderColor()
		{
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetBorderColor_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060080EB RID: 33003
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_GetBorderColor_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the RGB color of the border.
		/// Default is white (1.0, 1.0, 1.0).
		/// </summary>
		// Token: 0x060080EC RID: 33004 RVA: 0x000B8E70 File Offset: 0x000B7070
		public virtual void GetBorderColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetBorderColor_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060080ED RID: 33005
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_GetBorderColor_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the RGB color of the border.
		/// Default is white (1.0, 1.0, 1.0).
		/// </summary>
		// Token: 0x060080EE RID: 33006 RVA: 0x000B8E82 File Offset: 0x000B7082
		public virtual void GetBorderColor(IntPtr _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetBorderColor_08(base.GetCppThis(), _arg);
		}

		// Token: 0x060080EF RID: 33007
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderRepresentation_GetBorderProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the properties of the border.
		/// </summary>
		// Token: 0x060080F0 RID: 33008 RVA: 0x000B8E94 File Offset: 0x000B7094
		public virtual vtkProperty2D GetBorderProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetBorderProperty_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		// Token: 0x060080F1 RID: 33009
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkBorderRepresentation_GetBorderThickness_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the thickness of the border in screen units.
		/// Default is 1.0.
		/// </summary>
		// Token: 0x060080F2 RID: 33010 RVA: 0x000B8F04 File Offset: 0x000B7104
		public virtual float GetBorderThickness()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetBorderThickness_10(base.GetCppThis());
		}

		// Token: 0x060080F3 RID: 33011
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkBorderRepresentation_GetBorderThicknessMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the thickness of the border in screen units.
		/// Default is 1.0.
		/// </summary>
		// Token: 0x060080F4 RID: 33012 RVA: 0x000B8F24 File Offset: 0x000B7124
		public virtual float GetBorderThicknessMaxValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetBorderThicknessMaxValue_11(base.GetCppThis());
		}

		// Token: 0x060080F5 RID: 33013
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkBorderRepresentation_GetBorderThicknessMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the thickness of the border in screen units.
		/// Default is 1.0.
		/// </summary>
		// Token: 0x060080F6 RID: 33014 RVA: 0x000B8F44 File Offset: 0x000B7144
		public virtual float GetBorderThicknessMinValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetBorderThicknessMinValue_12(base.GetCppThis());
		}

		// Token: 0x060080F7 RID: 33015
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBorderRepresentation_GetCornerRadiusStrength_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio between no radius and maximum radius.
		/// In order to compute round corners, we create 2 points
		/// in each side of the corner. The maximum radius is then
		/// the minimum length of the two sides of each corners.
		/// This maximum radius is scaled by the CornerRadiusStrength.
		/// Default is 0.0 (no radius).
		/// </summary>
		// Token: 0x060080F8 RID: 33016 RVA: 0x000B8F64 File Offset: 0x000B7164
		public virtual double GetCornerRadiusStrength()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetCornerRadiusStrength_13(base.GetCppThis());
		}

		// Token: 0x060080F9 RID: 33017
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBorderRepresentation_GetCornerRadiusStrengthMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio between no radius and maximum radius.
		/// In order to compute round corners, we create 2 points
		/// in each side of the corner. The maximum radius is then
		/// the minimum length of the two sides of each corners.
		/// This maximum radius is scaled by the CornerRadiusStrength.
		/// Default is 0.0 (no radius).
		/// </summary>
		// Token: 0x060080FA RID: 33018 RVA: 0x000B8F84 File Offset: 0x000B7184
		public virtual double GetCornerRadiusStrengthMaxValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetCornerRadiusStrengthMaxValue_14(base.GetCppThis());
		}

		// Token: 0x060080FB RID: 33019
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBorderRepresentation_GetCornerRadiusStrengthMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the ratio between no radius and maximum radius.
		/// In order to compute round corners, we create 2 points
		/// in each side of the corner. The maximum radius is then
		/// the minimum length of the two sides of each corners.
		/// This maximum radius is scaled by the CornerRadiusStrength.
		/// Default is 0.0 (no radius).
		/// </summary>
		// Token: 0x060080FC RID: 33020 RVA: 0x000B8FA4 File Offset: 0x000B71A4
		public virtual double GetCornerRadiusStrengthMinValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetCornerRadiusStrengthMinValue_15(base.GetCppThis());
		}

		// Token: 0x060080FD RID: 33021
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetCornerResolution_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of points that define each round corners.
		/// A high value increase the resolution of the corners.
		/// Default is 20.
		/// </summary>
		// Token: 0x060080FE RID: 33022 RVA: 0x000B8FC4 File Offset: 0x000B71C4
		public virtual int GetCornerResolution()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetCornerResolution_16(base.GetCppThis());
		}

		// Token: 0x060080FF RID: 33023
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetCornerResolutionMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of points that define each round corners.
		/// A high value increase the resolution of the corners.
		/// Default is 20.
		/// </summary>
		// Token: 0x06008100 RID: 33024 RVA: 0x000B8FE4 File Offset: 0x000B71E4
		public virtual int GetCornerResolutionMaxValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetCornerResolutionMaxValue_17(base.GetCppThis());
		}

		// Token: 0x06008101 RID: 33025
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetCornerResolutionMinValue_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of points that define each round corners.
		/// A high value increase the resolution of the corners.
		/// Default is 20.
		/// </summary>
		// Token: 0x06008102 RID: 33026 RVA: 0x000B9004 File Offset: 0x000B7204
		public virtual int GetCornerResolutionMinValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetCornerResolutionMinValue_18(base.GetCppThis());
		}

		// Token: 0x06008103 RID: 33027
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetEnforceNormalizedViewportBounds_19(HandleRef pThis);

		/// <summary>
		/// Whether to enforce the minimum normalized viewport size and limit
		/// the normalized viewport coordinates to [0.0 -&gt; 1.0]. This keeps
		/// widgets from being moved offscreen or being scaled down past their
		/// minimum viewport size.
		///
		/// Off by Default.
		///
		/// Note: ProportionalResize must be off for this function to take effect.
		/// </summary>
		// Token: 0x06008104 RID: 33028 RVA: 0x000B9024 File Offset: 0x000B7224
		public virtual int GetEnforceNormalizedViewportBounds()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetEnforceNormalizedViewportBounds_19(base.GetCppThis());
		}

		// Token: 0x06008105 RID: 33029
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetInteractionStateMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Define the various states that the representation can be in.
		/// </summary>
		// Token: 0x06008106 RID: 33030 RVA: 0x000B9044 File Offset: 0x000B7244
		public virtual int GetInteractionStateMaxValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetInteractionStateMaxValue_20(base.GetCppThis());
		}

		// Token: 0x06008107 RID: 33031
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetInteractionStateMinValue_21(HandleRef pThis);

		/// <summary>
		/// Define the various states that the representation can be in.
		/// </summary>
		// Token: 0x06008108 RID: 33032 RVA: 0x000B9064 File Offset: 0x000B7264
		public virtual int GetInteractionStateMinValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetInteractionStateMinValue_21(base.GetCppThis());
		}

		// Token: 0x06008109 RID: 33033
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkBorderRepresentation_GetMTime_22(HandleRef pThis);

		/// <summary>
		/// Return the MTime of this object. It takes into account MTimes
		/// of position coordinates and border's property.
		/// </summary>
		// Token: 0x0600810A RID: 33034 RVA: 0x000B9084 File Offset: 0x000B7284
		public override ulong GetMTime()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetMTime_22(base.GetCppThis());
		}

		// Token: 0x0600810B RID: 33035
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderRepresentation_GetMaximumSize_23(HandleRef pThis);

		/// <summary>
		/// Specify a minimum and/or maximum size (in pixels) that this representation
		/// can take. These methods require two values: size values in the x and y
		/// directions, respectively.
		///
		/// Default is { 1, 1 }.
		/// </summary>
		// Token: 0x0600810C RID: 33036 RVA: 0x000B90A4 File Offset: 0x000B72A4
		public virtual int[] GetMaximumSize()
		{
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetMaximumSize_23(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600810D RID: 33037
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_GetMaximumSize_24(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Specify a minimum and/or maximum size (in pixels) that this representation
		/// can take. These methods require two values: size values in the x and y
		/// directions, respectively.
		///
		/// Default is { 1, 1 }.
		/// </summary>
		// Token: 0x0600810E RID: 33038 RVA: 0x000B90EC File Offset: 0x000B72EC
		public virtual void GetMaximumSize(ref int _arg1, ref int _arg2)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetMaximumSize_24(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600810F RID: 33039
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_GetMaximumSize_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a minimum and/or maximum size (in pixels) that this representation
		/// can take. These methods require two values: size values in the x and y
		/// directions, respectively.
		///
		/// Default is { 1, 1 }.
		/// </summary>
		// Token: 0x06008110 RID: 33040 RVA: 0x000B90FD File Offset: 0x000B72FD
		public virtual void GetMaximumSize(IntPtr _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetMaximumSize_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06008111 RID: 33041
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderRepresentation_GetMinimumNormalizedViewportSize_26(HandleRef pThis);

		/// <summary>
		/// Specify a minimum and/or maximum size [0.0 -&gt; 1.0] that this representation
		/// can take. These methods require two values: size values in the x and y
		/// directions, respectively.
		///
		/// Default is { 0.0, 0.0 }.
		/// </summary>
		// Token: 0x06008112 RID: 33042 RVA: 0x000B9110 File Offset: 0x000B7310
		public virtual double[] GetMinimumNormalizedViewportSize()
		{
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetMinimumNormalizedViewportSize_26(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008113 RID: 33043
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_GetMinimumNormalizedViewportSize_27(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Specify a minimum and/or maximum size [0.0 -&gt; 1.0] that this representation
		/// can take. These methods require two values: size values in the x and y
		/// directions, respectively.
		///
		/// Default is { 0.0, 0.0 }.
		/// </summary>
		// Token: 0x06008114 RID: 33044 RVA: 0x000B9158 File Offset: 0x000B7358
		public virtual void GetMinimumNormalizedViewportSize(ref double _arg1, ref double _arg2)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetMinimumNormalizedViewportSize_27(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06008115 RID: 33045
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_GetMinimumNormalizedViewportSize_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a minimum and/or maximum size [0.0 -&gt; 1.0] that this representation
		/// can take. These methods require two values: size values in the x and y
		/// directions, respectively.
		///
		/// Default is { 0.0, 0.0 }.
		/// </summary>
		// Token: 0x06008116 RID: 33046 RVA: 0x000B9169 File Offset: 0x000B7369
		public virtual void GetMinimumNormalizedViewportSize(IntPtr _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetMinimumNormalizedViewportSize_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06008117 RID: 33047
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderRepresentation_GetMinimumSize_29(HandleRef pThis);

		/// <summary>
		/// Specify a minimum and/or maximum size (in pixels) that this representation
		/// can take. These methods require two values: size values in the x and y
		/// directions, respectively.
		///
		/// Default is { 1, 1 }.
		/// </summary>
		// Token: 0x06008118 RID: 33048 RVA: 0x000B917C File Offset: 0x000B737C
		public virtual int[] GetMinimumSize()
		{
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetMinimumSize_29(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008119 RID: 33049
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_GetMinimumSize_30(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Specify a minimum and/or maximum size (in pixels) that this representation
		/// can take. These methods require two values: size values in the x and y
		/// directions, respectively.
		///
		/// Default is { 1, 1 }.
		/// </summary>
		// Token: 0x0600811A RID: 33050 RVA: 0x000B91C4 File Offset: 0x000B73C4
		public virtual void GetMinimumSize(ref int _arg1, ref int _arg2)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetMinimumSize_30(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600811B RID: 33051
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_GetMinimumSize_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a minimum and/or maximum size (in pixels) that this representation
		/// can take. These methods require two values: size values in the x and y
		/// directions, respectively.
		///
		/// Default is { 1, 1 }.
		/// </summary>
		// Token: 0x0600811C RID: 33052 RVA: 0x000B91D5 File Offset: 0x000B73D5
		public virtual void GetMinimumSize(IntPtr _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetMinimumSize_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600811D RID: 33053
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetMoving_32(HandleRef pThis);

		/// <summary>
		/// This is a modifier of the interaction state. When set, widget interaction
		/// allows the border (and stuff inside of it) to be translated with mouse
		/// motion.
		/// </summary>
		// Token: 0x0600811E RID: 33054 RVA: 0x000B91E8 File Offset: 0x000B73E8
		public virtual int GetMoving()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetMoving_32(base.GetCppThis());
		}

		// Token: 0x0600811F RID: 33055
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBorderRepresentation_GetNumberOfGenerationsFromBase_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Define standard methods.
		/// </summary>
		// Token: 0x06008120 RID: 33056 RVA: 0x000B9208 File Offset: 0x000B7408
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetNumberOfGenerationsFromBase_33(base.GetCppThis(), type);
		}

		// Token: 0x06008121 RID: 33057
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBorderRepresentation_GetNumberOfGenerationsFromBaseType_34([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Define standard methods.
		/// </summary>
		// Token: 0x06008122 RID: 33058 RVA: 0x000B9228 File Offset: 0x000B7428
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetNumberOfGenerationsFromBaseType_34(type);
		}

		// Token: 0x06008123 RID: 33059
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderRepresentation_GetPolygonColor_35(HandleRef pThis);

		/// <summary>
		/// Set/Get the RGB color of the background polygon.
		/// Default is white (1.0, 1.0, 1.0).
		/// </summary>
		// Token: 0x06008124 RID: 33060 RVA: 0x000B9244 File Offset: 0x000B7444
		public virtual double[] GetPolygonColor()
		{
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetPolygonColor_35(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008125 RID: 33061
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_GetPolygonColor_36(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the RGB color of the background polygon.
		/// Default is white (1.0, 1.0, 1.0).
		/// </summary>
		// Token: 0x06008126 RID: 33062 RVA: 0x000B928C File Offset: 0x000B748C
		public virtual void GetPolygonColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetPolygonColor_36(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06008127 RID: 33063
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_GetPolygonColor_37(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the RGB color of the background polygon.
		/// Default is white (1.0, 1.0, 1.0).
		/// </summary>
		// Token: 0x06008128 RID: 33064 RVA: 0x000B929E File Offset: 0x000B749E
		public virtual void GetPolygonColor(IntPtr _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetPolygonColor_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06008129 RID: 33065
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBorderRepresentation_GetPolygonOpacity_38(HandleRef pThis);

		/// <summary>
		/// Set/Get the opacity of the background color.
		/// Default is 0.0.
		/// </summary>
		// Token: 0x0600812A RID: 33066 RVA: 0x000B92B0 File Offset: 0x000B74B0
		public virtual double GetPolygonOpacity()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetPolygonOpacity_38(base.GetCppThis());
		}

		// Token: 0x0600812B RID: 33067
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBorderRepresentation_GetPolygonOpacityMaxValue_39(HandleRef pThis);

		/// <summary>
		/// Set/Get the opacity of the background color.
		/// Default is 0.0.
		/// </summary>
		// Token: 0x0600812C RID: 33068 RVA: 0x000B92D0 File Offset: 0x000B74D0
		public virtual double GetPolygonOpacityMaxValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetPolygonOpacityMaxValue_39(base.GetCppThis());
		}

		// Token: 0x0600812D RID: 33069
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBorderRepresentation_GetPolygonOpacityMinValue_40(HandleRef pThis);

		/// <summary>
		/// Set/Get the opacity of the background color.
		/// Default is 0.0.
		/// </summary>
		// Token: 0x0600812E RID: 33070 RVA: 0x000B92F0 File Offset: 0x000B74F0
		public virtual double GetPolygonOpacityMinValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetPolygonOpacityMinValue_40(base.GetCppThis());
		}

		// Token: 0x0600812F RID: 33071
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_GetPolygonRGBA_41(HandleRef pThis, IntPtr rgba);

		/// <summary>
		/// Convenience method to get the background color and the opacity at once
		/// </summary>
		// Token: 0x06008130 RID: 33072 RVA: 0x000B930F File Offset: 0x000B750F
		public void GetPolygonRGBA(IntPtr rgba)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetPolygonRGBA_41(base.GetCppThis(), rgba);
		}

		// Token: 0x06008131 RID: 33073
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_GetPolygonRGBA_42(HandleRef pThis, ref double r, ref double g, ref double b, ref double a);

		/// <summary>
		/// Convenience method to get the background color and the opacity at once
		/// </summary>
		// Token: 0x06008132 RID: 33074 RVA: 0x000B931F File Offset: 0x000B751F
		public void GetPolygonRGBA(ref double r, ref double g, ref double b, ref double a)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetPolygonRGBA_42(base.GetCppThis(), ref r, ref g, ref b, ref a);
		}

		// Token: 0x06008133 RID: 33075
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderRepresentation_GetPosition_43(HandleRef pThis);

		/// <summary>
		/// Specify opposite corners of the box defining the boundary of the
		/// widget. By default, these coordinates are in the normalized viewport
		/// coordinate system, with Position the lower left of the outline, and
		/// Position2 relative to Position. Note that using these methods are
		/// affected by the ProportionalResize flag. That is, if the aspect ratio of
		/// the representation is to be preserved (e.g., ProportionalResize is on),
		/// then the rectangle (Position,Position2) is a bounding rectangle.
		/// </summary>
		// Token: 0x06008134 RID: 33076 RVA: 0x000B9334 File Offset: 0x000B7534
		public virtual double[] GetPosition()
		{
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetPosition_43(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008135 RID: 33077
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderRepresentation_GetPosition2_44(HandleRef pThis);

		/// <summary>
		/// Specify opposite corners of the box defining the boundary of the
		/// widget. By default, these coordinates are in the normalized viewport
		/// coordinate system, with Position the lower left of the outline, and
		/// Position2 relative to Position. Note that using these methods are
		/// affected by the ProportionalResize flag. That is, if the aspect ratio of
		/// the representation is to be preserved (e.g., ProportionalResize is on),
		/// then the rectangle (Position,Position2) is a bounding rectangle.
		/// </summary>
		// Token: 0x06008136 RID: 33078 RVA: 0x000B937C File Offset: 0x000B757C
		public virtual double[] GetPosition2()
		{
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetPosition2_44(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008137 RID: 33079
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderRepresentation_GetPosition2Coordinate_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify opposite corners of the box defining the boundary of the
		/// widget. By default, these coordinates are in the normalized viewport
		/// coordinate system, with Position the lower left of the outline, and
		/// Position2 relative to Position. Note that using these methods are
		/// affected by the ProportionalResize flag. That is, if the aspect ratio of
		/// the representation is to be preserved (e.g., ProportionalResize is on),
		/// then the rectangle (Position,Position2) is a bounding rectangle.
		/// </summary>
		// Token: 0x06008138 RID: 33080 RVA: 0x000B93C4 File Offset: 0x000B75C4
		public virtual vtkCoordinate GetPosition2Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetPosition2Coordinate_45(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		// Token: 0x06008139 RID: 33081
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderRepresentation_GetPositionCoordinate_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify opposite corners of the box defining the boundary of the
		/// widget. By default, these coordinates are in the normalized viewport
		/// coordinate system, with Position the lower left of the outline, and
		/// Position2 relative to Position. Note that using these methods are
		/// affected by the ProportionalResize flag. That is, if the aspect ratio of
		/// the representation is to be preserved (e.g., ProportionalResize is on),
		/// then the rectangle (Position,Position2) is a bounding rectangle.
		/// </summary>
		// Token: 0x0600813A RID: 33082 RVA: 0x000B9434 File Offset: 0x000B7634
		public virtual vtkCoordinate GetPositionCoordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetPositionCoordinate_46(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		// Token: 0x0600813B RID: 33083
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetProportionalResize_47(HandleRef pThis);

		/// <summary>
		/// Indicate whether resizing operations should keep the x-y directions
		/// proportional to one another. Also, if ProportionalResize is on, then
		/// the rectangle (Position,Position2) is a bounding rectangle, and the
		/// representation will be placed in the rectangle in such a way as to
		/// preserve the aspect ratio of the representation.
		///
		/// Off by Default.
		/// </summary>
		// Token: 0x0600813C RID: 33084 RVA: 0x000B94A4 File Offset: 0x000B76A4
		public virtual int GetProportionalResize()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetProportionalResize_47(base.GetCppThis());
		}

		// Token: 0x0600813D RID: 33085
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderRepresentation_GetSelectionPoint_48(HandleRef pThis);

		/// <summary>
		/// After a selection event within the region interior to the border; the
		/// normalized selection coordinates may be obtained.
		/// </summary>
		// Token: 0x0600813E RID: 33086 RVA: 0x000B94C4 File Offset: 0x000B76C4
		public virtual double[] GetSelectionPoint()
		{
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_GetSelectionPoint_48(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600813F RID: 33087
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_GetSelectionPoint_49(HandleRef pThis, IntPtr data);

		/// <summary>
		/// After a selection event within the region interior to the border; the
		/// normalized selection coordinates may be obtained.
		/// </summary>
		// Token: 0x06008140 RID: 33088 RVA: 0x000B950C File Offset: 0x000B770C
		public virtual void GetSelectionPoint(IntPtr data)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetSelectionPoint_49(base.GetCppThis(), data);
		}

		// Token: 0x06008141 RID: 33089
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetShowBorder_50(HandleRef pThis);

		/// <summary>
		/// Specify when and if the border should appear. If ShowBorder is "on",
		/// then the border will always appear. If ShowBorder is "off" then the
		/// border will never appear.  If ShowBorder is "active" then the border
		/// will appear when the mouse pointer enters the region bounded by the
		/// border widget.
		/// This method is provided as conveniency to set both horizontal and
		/// vertical borders, and the polygon background.
		/// BORDER_ON by default.
		/// See Also: SetShowHorizontalBorder(), SetShowVerticalBorder(), SetShowPolygon()
		/// </summary>
		// Token: 0x06008142 RID: 33090 RVA: 0x000B951C File Offset: 0x000B771C
		public virtual int GetShowBorder()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetShowBorder_50(base.GetCppThis());
		}

		// Token: 0x06008143 RID: 33091
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetShowBorderMaxValue_51(HandleRef pThis);

		/// <summary>
		/// Specify when and if the border should appear. If ShowBorder is "on",
		/// then the border will always appear. If ShowBorder is "off" then the
		/// border will never appear.  If ShowBorder is "active" then the border
		/// will appear when the mouse pointer enters the region bounded by the
		/// border widget.
		/// This method is provided as conveniency to set both horizontal and
		/// vertical borders, and the polygon background.
		/// BORDER_ON by default.
		/// See Also: SetShowHorizontalBorder(), SetShowVerticalBorder(), SetShowPolygon()
		/// </summary>
		// Token: 0x06008144 RID: 33092 RVA: 0x000B953C File Offset: 0x000B773C
		public virtual int GetShowBorderMaxValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetShowBorderMaxValue_51(base.GetCppThis());
		}

		// Token: 0x06008145 RID: 33093
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetShowBorderMinValue_52(HandleRef pThis);

		/// <summary>
		/// Specify when and if the border should appear. If ShowBorder is "on",
		/// then the border will always appear. If ShowBorder is "off" then the
		/// border will never appear.  If ShowBorder is "active" then the border
		/// will appear when the mouse pointer enters the region bounded by the
		/// border widget.
		/// This method is provided as conveniency to set both horizontal and
		/// vertical borders, and the polygon background.
		/// BORDER_ON by default.
		/// See Also: SetShowHorizontalBorder(), SetShowVerticalBorder(), SetShowPolygon()
		/// </summary>
		// Token: 0x06008146 RID: 33094 RVA: 0x000B955C File Offset: 0x000B775C
		public virtual int GetShowBorderMinValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetShowBorderMinValue_52(base.GetCppThis());
		}

		// Token: 0x06008147 RID: 33095
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetShowHorizontalBorder_53(HandleRef pThis);

		/// <summary>
		/// Specify when and if the horizontal border should appear.
		/// BORDER_ON by default.
		/// See Also: SetShowBorder(), SetShowVerticalBorder()
		/// </summary>
		// Token: 0x06008148 RID: 33096 RVA: 0x000B957C File Offset: 0x000B777C
		public virtual int GetShowHorizontalBorder()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetShowHorizontalBorder_53(base.GetCppThis());
		}

		// Token: 0x06008149 RID: 33097
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetShowHorizontalBorderMaxValue_54(HandleRef pThis);

		/// <summary>
		/// Specify when and if the horizontal border should appear.
		/// BORDER_ON by default.
		/// See Also: SetShowBorder(), SetShowVerticalBorder()
		/// </summary>
		// Token: 0x0600814A RID: 33098 RVA: 0x000B959C File Offset: 0x000B779C
		public virtual int GetShowHorizontalBorderMaxValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetShowHorizontalBorderMaxValue_54(base.GetCppThis());
		}

		// Token: 0x0600814B RID: 33099
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetShowHorizontalBorderMinValue_55(HandleRef pThis);

		/// <summary>
		/// Specify when and if the horizontal border should appear.
		/// BORDER_ON by default.
		/// See Also: SetShowBorder(), SetShowVerticalBorder()
		/// </summary>
		// Token: 0x0600814C RID: 33100 RVA: 0x000B95BC File Offset: 0x000B77BC
		public virtual int GetShowHorizontalBorderMinValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetShowHorizontalBorderMinValue_55(base.GetCppThis());
		}

		// Token: 0x0600814D RID: 33101
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetShowPolygon_56(HandleRef pThis);

		/// <summary>
		/// Specify when and if the border's polygon background should appear.
		/// BORDER_ON by default.
		/// See Also: SetShowBorder()
		/// </summary>
		// Token: 0x0600814E RID: 33102 RVA: 0x000B95DC File Offset: 0x000B77DC
		public virtual int GetShowPolygon()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetShowPolygon_56(base.GetCppThis());
		}

		// Token: 0x0600814F RID: 33103
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetShowPolygonBackground_57(HandleRef pThis);

		/// <summary>
		/// Specify when and if the border polygon background should appear.
		/// BORDER_ON by default.
		/// See Also: SetShowBorder(), SetShowPolygon()
		/// </summary>
		// Token: 0x06008150 RID: 33104 RVA: 0x000B95FC File Offset: 0x000B77FC
		public virtual int GetShowPolygonBackground()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetShowPolygonBackground_57(base.GetCppThis());
		}

		// Token: 0x06008151 RID: 33105
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetShowPolygonBackgroundMaxValue_58(HandleRef pThis);

		/// <summary>
		/// Specify when and if the border polygon background should appear.
		/// BORDER_ON by default.
		/// See Also: SetShowBorder(), SetShowPolygon()
		/// </summary>
		// Token: 0x06008152 RID: 33106 RVA: 0x000B961C File Offset: 0x000B781C
		public virtual int GetShowPolygonBackgroundMaxValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetShowPolygonBackgroundMaxValue_58(base.GetCppThis());
		}

		// Token: 0x06008153 RID: 33107
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetShowPolygonBackgroundMinValue_59(HandleRef pThis);

		/// <summary>
		/// Specify when and if the border polygon background should appear.
		/// BORDER_ON by default.
		/// See Also: SetShowBorder(), SetShowPolygon()
		/// </summary>
		// Token: 0x06008154 RID: 33108 RVA: 0x000B963C File Offset: 0x000B783C
		public virtual int GetShowPolygonBackgroundMinValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetShowPolygonBackgroundMinValue_59(base.GetCppThis());
		}

		// Token: 0x06008155 RID: 33109
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetShowVerticalBorder_60(HandleRef pThis);

		/// <summary>
		/// Specify when and if the vertical border should appear.
		/// BORDER_ON by default.
		/// See Also: SetShowBorder(), SetShowHorizontalBorder()
		/// </summary>
		// Token: 0x06008156 RID: 33110 RVA: 0x000B965C File Offset: 0x000B785C
		public virtual int GetShowVerticalBorder()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetShowVerticalBorder_60(base.GetCppThis());
		}

		// Token: 0x06008157 RID: 33111
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetShowVerticalBorderMaxValue_61(HandleRef pThis);

		/// <summary>
		/// Specify when and if the vertical border should appear.
		/// BORDER_ON by default.
		/// See Also: SetShowBorder(), SetShowHorizontalBorder()
		/// </summary>
		// Token: 0x06008158 RID: 33112 RVA: 0x000B967C File Offset: 0x000B787C
		public virtual int GetShowVerticalBorderMaxValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetShowVerticalBorderMaxValue_61(base.GetCppThis());
		}

		// Token: 0x06008159 RID: 33113
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetShowVerticalBorderMinValue_62(HandleRef pThis);

		/// <summary>
		/// Specify when and if the vertical border should appear.
		/// BORDER_ON by default.
		/// See Also: SetShowBorder(), SetShowHorizontalBorder()
		/// </summary>
		// Token: 0x0600815A RID: 33114 RVA: 0x000B969C File Offset: 0x000B789C
		public virtual int GetShowVerticalBorderMinValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetShowVerticalBorderMinValue_62(base.GetCppThis());
		}

		// Token: 0x0600815B RID: 33115
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_GetSize_63(HandleRef pThis, IntPtr size);

		/// <summary>
		/// Subclasses should implement these methods. See the superclasses'
		/// documentation for more information.
		/// </summary>
		// Token: 0x0600815C RID: 33116 RVA: 0x000B96BB File Offset: 0x000B78BB
		public virtual void GetSize(IntPtr size)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_GetSize_63(base.GetCppThis(), size);
		}

		// Token: 0x0600815D RID: 33117
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetTolerance_64(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered to be on the widget, or on a
		/// widget feature (e.g., a corner point or edge).
		///
		/// Default is 3.
		/// </summary>
		// Token: 0x0600815E RID: 33118 RVA: 0x000B96CC File Offset: 0x000B78CC
		public virtual int GetTolerance()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetTolerance_64(base.GetCppThis());
		}

		// Token: 0x0600815F RID: 33119
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetToleranceMaxValue_65(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered to be on the widget, or on a
		/// widget feature (e.g., a corner point or edge).
		///
		/// Default is 3.
		/// </summary>
		// Token: 0x06008160 RID: 33120 RVA: 0x000B96EC File Offset: 0x000B78EC
		public virtual int GetToleranceMaxValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetToleranceMaxValue_65(base.GetCppThis());
		}

		// Token: 0x06008161 RID: 33121
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetToleranceMinValue_66(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered to be on the widget, or on a
		/// widget feature (e.g., a corner point or edge).
		///
		/// Default is 3.
		/// </summary>
		// Token: 0x06008162 RID: 33122 RVA: 0x000B970C File Offset: 0x000B790C
		public virtual int GetToleranceMinValue()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetToleranceMinValue_66(base.GetCppThis());
		}

		// Token: 0x06008163 RID: 33123
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_GetWindowLocation_67(HandleRef pThis);

		/// <summary>
		/// Set the representation position, by enumeration (
		/// AnyLocation = 0,
		/// LowerLeftCorner,
		/// LowerRightCorner,
		/// LowerCenter,
		/// UpperLeftCorner,
		/// UpperRightCorner,
		/// UpperCenter)
		/// related to the render window
		/// </summary>
		// Token: 0x06008164 RID: 33124 RVA: 0x000B972C File Offset: 0x000B792C
		public virtual int GetWindowLocation()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_GetWindowLocation_67(base.GetCppThis());
		}

		// Token: 0x06008165 RID: 33125
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_HasTranslucentPolygonalGeometry_68(HandleRef pThis);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06008166 RID: 33126 RVA: 0x000B974C File Offset: 0x000B794C
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_HasTranslucentPolygonalGeometry_68(base.GetCppThis());
		}

		// Token: 0x06008167 RID: 33127
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_IsA_69(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Define standard methods.
		/// </summary>
		// Token: 0x06008168 RID: 33128 RVA: 0x000B976C File Offset: 0x000B796C
		public override int IsA(string type)
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_IsA_69(base.GetCppThis(), type);
		}

		// Token: 0x06008169 RID: 33129
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_IsTypeOf_70([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Define standard methods.
		/// </summary>
		// Token: 0x0600816A RID: 33130 RVA: 0x000B978C File Offset: 0x000B798C
		public new static int IsTypeOf(string type)
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_IsTypeOf_70(type);
		}

		// Token: 0x0600816B RID: 33131
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_MovingOff_71(HandleRef pThis);

		/// <summary>
		/// This is a modifier of the interaction state. When set, widget interaction
		/// allows the border (and stuff inside of it) to be translated with mouse
		/// motion.
		/// </summary>
		// Token: 0x0600816C RID: 33132 RVA: 0x000B97A6 File Offset: 0x000B79A6
		public virtual void MovingOff()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_MovingOff_71(base.GetCppThis());
		}

		// Token: 0x0600816D RID: 33133
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_MovingOn_72(HandleRef pThis);

		/// <summary>
		/// This is a modifier of the interaction state. When set, widget interaction
		/// allows the border (and stuff inside of it) to be translated with mouse
		/// motion.
		/// </summary>
		// Token: 0x0600816E RID: 33134 RVA: 0x000B97B5 File Offset: 0x000B79B5
		public virtual void MovingOn()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_MovingOn_72(base.GetCppThis());
		}

		// Token: 0x0600816F RID: 33135
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderRepresentation_NewInstance_74(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Define standard methods.
		/// </summary>
		// Token: 0x06008170 RID: 33136 RVA: 0x000B97C4 File Offset: 0x000B79C4
		public new vtkBorderRepresentation NewInstance()
		{
			vtkBorderRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_NewInstance_74(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBorderRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008171 RID: 33137
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_ProportionalResizeOff_75(HandleRef pThis);

		/// <summary>
		/// Indicate whether resizing operations should keep the x-y directions
		/// proportional to one another. Also, if ProportionalResize is on, then
		/// the rectangle (Position,Position2) is a bounding rectangle, and the
		/// representation will be placed in the rectangle in such a way as to
		/// preserve the aspect ratio of the representation.
		///
		/// Off by Default.
		/// </summary>
		// Token: 0x06008172 RID: 33138 RVA: 0x000B981E File Offset: 0x000B7A1E
		public virtual void ProportionalResizeOff()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_ProportionalResizeOff_75(base.GetCppThis());
		}

		// Token: 0x06008173 RID: 33139
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_ProportionalResizeOn_76(HandleRef pThis);

		/// <summary>
		/// Indicate whether resizing operations should keep the x-y directions
		/// proportional to one another. Also, if ProportionalResize is on, then
		/// the rectangle (Position,Position2) is a bounding rectangle, and the
		/// representation will be placed in the rectangle in such a way as to
		/// preserve the aspect ratio of the representation.
		///
		/// Off by Default.
		/// </summary>
		// Token: 0x06008174 RID: 33140 RVA: 0x000B982D File Offset: 0x000B7A2D
		public virtual void ProportionalResizeOn()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_ProportionalResizeOn_76(base.GetCppThis());
		}

		// Token: 0x06008175 RID: 33141
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_ReleaseGraphicsResources_77(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06008176 RID: 33142 RVA: 0x000B983C File Offset: 0x000B7A3C
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_ReleaseGraphicsResources_77(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008177 RID: 33143
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_RenderOpaqueGeometry_78(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06008178 RID: 33144 RVA: 0x000B986C File Offset: 0x000B7A6C
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_RenderOpaqueGeometry_78(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008179 RID: 33145
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_RenderOverlay_79(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x0600817A RID: 33146 RVA: 0x000B98A0 File Offset: 0x000B7AA0
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_RenderOverlay_79(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600817B RID: 33147
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBorderRepresentation_RenderTranslucentPolygonalGeometry_80(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x0600817C RID: 33148 RVA: 0x000B98D4 File Offset: 0x000B7AD4
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkBorderRepresentation.vtkBorderRepresentation_RenderTranslucentPolygonalGeometry_80(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600817D RID: 33149
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBorderRepresentation_SafeDownCast_81(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Define standard methods.
		/// </summary>
		// Token: 0x0600817E RID: 33150 RVA: 0x000B9908 File Offset: 0x000B7B08
		public new static vtkBorderRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkBorderRepresentation vtkBorderRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBorderRepresentation.vtkBorderRepresentation_SafeDownCast_81((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBorderRepresentation = (vtkBorderRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBorderRepresentation.Register(null);
				}
			}
			return vtkBorderRepresentation;
		}

		// Token: 0x0600817F RID: 33151
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetBWActorDisplayOverlayEdges_82(HandleRef pThis, byte arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06008180 RID: 33152 RVA: 0x000B9987 File Offset: 0x000B7B87
		public void SetBWActorDisplayOverlayEdges(bool arg0)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetBWActorDisplayOverlayEdges_82(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x06008181 RID: 33153
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetBWActorDisplayOverlayPolygon_83(HandleRef pThis, byte arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06008182 RID: 33154 RVA: 0x000B999F File Offset: 0x000B7B9F
		public void SetBWActorDisplayOverlayPolygon(bool arg0)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetBWActorDisplayOverlayPolygon_83(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x06008183 RID: 33155
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetBorderColor_84(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the RGB color of the border.
		/// Default is white (1.0, 1.0, 1.0).
		/// </summary>
		// Token: 0x06008184 RID: 33156 RVA: 0x000B99B7 File Offset: 0x000B7BB7
		public virtual void SetBorderColor(double _arg1, double _arg2, double _arg3)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetBorderColor_84(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06008185 RID: 33157
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetBorderColor_85(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the RGB color of the border.
		/// Default is white (1.0, 1.0, 1.0).
		/// </summary>
		// Token: 0x06008186 RID: 33158 RVA: 0x000B99C9 File Offset: 0x000B7BC9
		public virtual void SetBorderColor(IntPtr _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetBorderColor_85(base.GetCppThis(), _arg);
		}

		// Token: 0x06008187 RID: 33159
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetBorderThickness_86(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the thickness of the border in screen units.
		/// Default is 1.0.
		/// </summary>
		// Token: 0x06008188 RID: 33160 RVA: 0x000B99D9 File Offset: 0x000B7BD9
		public virtual void SetBorderThickness(float _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetBorderThickness_86(base.GetCppThis(), _arg);
		}

		// Token: 0x06008189 RID: 33161
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetCornerRadiusStrength_87(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the ratio between no radius and maximum radius.
		/// In order to compute round corners, we create 2 points
		/// in each side of the corner. The maximum radius is then
		/// the minimum length of the two sides of each corners.
		/// This maximum radius is scaled by the CornerRadiusStrength.
		/// Default is 0.0 (no radius).
		/// </summary>
		// Token: 0x0600818A RID: 33162 RVA: 0x000B99E9 File Offset: 0x000B7BE9
		public virtual void SetCornerRadiusStrength(double _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetCornerRadiusStrength_87(base.GetCppThis(), _arg);
		}

		// Token: 0x0600818B RID: 33163
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetCornerResolution_88(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of points that define each round corners.
		/// A high value increase the resolution of the corners.
		/// Default is 20.
		/// </summary>
		// Token: 0x0600818C RID: 33164 RVA: 0x000B99F9 File Offset: 0x000B7BF9
		public virtual void SetCornerResolution(int _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetCornerResolution_88(base.GetCppThis(), _arg);
		}

		// Token: 0x0600818D RID: 33165
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetEnforceNormalizedViewportBounds_89(HandleRef pThis, int _arg);

		/// <summary>
		/// Whether to enforce the minimum normalized viewport size and limit
		/// the normalized viewport coordinates to [0.0 -&gt; 1.0]. This keeps
		/// widgets from being moved offscreen or being scaled down past their
		/// minimum viewport size.
		///
		/// Off by Default.
		///
		/// Note: ProportionalResize must be off for this function to take effect.
		/// </summary>
		// Token: 0x0600818E RID: 33166 RVA: 0x000B9A09 File Offset: 0x000B7C09
		public virtual void SetEnforceNormalizedViewportBounds(int _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetEnforceNormalizedViewportBounds_89(base.GetCppThis(), _arg);
		}

		// Token: 0x0600818F RID: 33167
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetInteractionState_90(HandleRef pThis, int _arg);

		/// <summary>
		/// Define the various states that the representation can be in.
		/// </summary>
		// Token: 0x06008190 RID: 33168 RVA: 0x000B9A19 File Offset: 0x000B7C19
		public virtual void SetInteractionState(int _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetInteractionState_90(base.GetCppThis(), _arg);
		}

		// Token: 0x06008191 RID: 33169
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetMaximumSize_91(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Specify a minimum and/or maximum size (in pixels) that this representation
		/// can take. These methods require two values: size values in the x and y
		/// directions, respectively.
		///
		/// Default is { 1, 1 }.
		/// </summary>
		// Token: 0x06008192 RID: 33170 RVA: 0x000B9A29 File Offset: 0x000B7C29
		public virtual void SetMaximumSize(int _arg1, int _arg2)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetMaximumSize_91(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06008193 RID: 33171
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetMaximumSize_92(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a minimum and/or maximum size (in pixels) that this representation
		/// can take. These methods require two values: size values in the x and y
		/// directions, respectively.
		///
		/// Default is { 1, 1 }.
		/// </summary>
		// Token: 0x06008194 RID: 33172 RVA: 0x000B9A3A File Offset: 0x000B7C3A
		public void SetMaximumSize(IntPtr _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetMaximumSize_92(base.GetCppThis(), _arg);
		}

		// Token: 0x06008195 RID: 33173
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetMinimumNormalizedViewportSize_93(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Specify a minimum and/or maximum size [0.0 -&gt; 1.0] that this representation
		/// can take. These methods require two values: size values in the x and y
		/// directions, respectively.
		///
		/// Default is { 0.0, 0.0 }.
		/// </summary>
		// Token: 0x06008196 RID: 33174 RVA: 0x000B9A4A File Offset: 0x000B7C4A
		public virtual void SetMinimumNormalizedViewportSize(double _arg1, double _arg2)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetMinimumNormalizedViewportSize_93(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06008197 RID: 33175
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetMinimumNormalizedViewportSize_94(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a minimum and/or maximum size [0.0 -&gt; 1.0] that this representation
		/// can take. These methods require two values: size values in the x and y
		/// directions, respectively.
		///
		/// Default is { 0.0, 0.0 }.
		/// </summary>
		// Token: 0x06008198 RID: 33176 RVA: 0x000B9A5B File Offset: 0x000B7C5B
		public void SetMinimumNormalizedViewportSize(IntPtr _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetMinimumNormalizedViewportSize_94(base.GetCppThis(), _arg);
		}

		// Token: 0x06008199 RID: 33177
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetMinimumSize_95(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Specify a minimum and/or maximum size (in pixels) that this representation
		/// can take. These methods require two values: size values in the x and y
		/// directions, respectively.
		///
		/// Default is { 1, 1 }.
		/// </summary>
		// Token: 0x0600819A RID: 33178 RVA: 0x000B9A6B File Offset: 0x000B7C6B
		public virtual void SetMinimumSize(int _arg1, int _arg2)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetMinimumSize_95(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600819B RID: 33179
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetMinimumSize_96(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a minimum and/or maximum size (in pixels) that this representation
		/// can take. These methods require two values: size values in the x and y
		/// directions, respectively.
		///
		/// Default is { 1, 1 }.
		/// </summary>
		// Token: 0x0600819C RID: 33180 RVA: 0x000B9A7C File Offset: 0x000B7C7C
		public void SetMinimumSize(IntPtr _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetMinimumSize_96(base.GetCppThis(), _arg);
		}

		// Token: 0x0600819D RID: 33181
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetMoving_97(HandleRef pThis, int _arg);

		/// <summary>
		/// This is a modifier of the interaction state. When set, widget interaction
		/// allows the border (and stuff inside of it) to be translated with mouse
		/// motion.
		/// </summary>
		// Token: 0x0600819E RID: 33182 RVA: 0x000B9A8C File Offset: 0x000B7C8C
		public virtual void SetMoving(int _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetMoving_97(base.GetCppThis(), _arg);
		}

		// Token: 0x0600819F RID: 33183
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetPolygonColor_98(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the RGB color of the background polygon.
		/// Default is white (1.0, 1.0, 1.0).
		/// </summary>
		// Token: 0x060081A0 RID: 33184 RVA: 0x000B9A9C File Offset: 0x000B7C9C
		public virtual void SetPolygonColor(double _arg1, double _arg2, double _arg3)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetPolygonColor_98(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060081A1 RID: 33185
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetPolygonColor_99(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the RGB color of the background polygon.
		/// Default is white (1.0, 1.0, 1.0).
		/// </summary>
		// Token: 0x060081A2 RID: 33186 RVA: 0x000B9AAE File Offset: 0x000B7CAE
		public virtual void SetPolygonColor(IntPtr _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetPolygonColor_99(base.GetCppThis(), _arg);
		}

		// Token: 0x060081A3 RID: 33187
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetPolygonOpacity_100(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the opacity of the background color.
		/// Default is 0.0.
		/// </summary>
		// Token: 0x060081A4 RID: 33188 RVA: 0x000B9ABE File Offset: 0x000B7CBE
		public virtual void SetPolygonOpacity(double _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetPolygonOpacity_100(base.GetCppThis(), _arg);
		}

		// Token: 0x060081A5 RID: 33189
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetPolygonRGBA_101(HandleRef pThis, IntPtr rgba);

		/// <summary>
		/// Convenience method to set the background color and the opacity at once
		/// </summary>
		// Token: 0x060081A6 RID: 33190 RVA: 0x000B9ACE File Offset: 0x000B7CCE
		public void SetPolygonRGBA(IntPtr rgba)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetPolygonRGBA_101(base.GetCppThis(), rgba);
		}

		// Token: 0x060081A7 RID: 33191
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetPolygonRGBA_102(HandleRef pThis, double r, double g, double b, double a);

		/// <summary>
		/// Convenience method to set the background color and the opacity at once
		/// </summary>
		// Token: 0x060081A8 RID: 33192 RVA: 0x000B9ADE File Offset: 0x000B7CDE
		public void SetPolygonRGBA(double r, double g, double b, double a)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetPolygonRGBA_102(base.GetCppThis(), r, g, b, a);
		}

		// Token: 0x060081A9 RID: 33193
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetPosition_103(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Specify opposite corners of the box defining the boundary of the
		/// widget. By default, these coordinates are in the normalized viewport
		/// coordinate system, with Position the lower left of the outline, and
		/// Position2 relative to Position. Note that using these methods are
		/// affected by the ProportionalResize flag. That is, if the aspect ratio of
		/// the representation is to be preserved (e.g., ProportionalResize is on),
		/// then the rectangle (Position,Position2) is a bounding rectangle.
		/// </summary>
		// Token: 0x060081AA RID: 33194 RVA: 0x000B9AF2 File Offset: 0x000B7CF2
		public virtual void SetPosition(IntPtr x)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetPosition_103(base.GetCppThis(), x);
		}

		// Token: 0x060081AB RID: 33195
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetPosition_104(HandleRef pThis, double x, double y);

		/// <summary>
		/// Specify opposite corners of the box defining the boundary of the
		/// widget. By default, these coordinates are in the normalized viewport
		/// coordinate system, with Position the lower left of the outline, and
		/// Position2 relative to Position. Note that using these methods are
		/// affected by the ProportionalResize flag. That is, if the aspect ratio of
		/// the representation is to be preserved (e.g., ProportionalResize is on),
		/// then the rectangle (Position,Position2) is a bounding rectangle.
		/// </summary>
		// Token: 0x060081AC RID: 33196 RVA: 0x000B9B02 File Offset: 0x000B7D02
		public virtual void SetPosition(double x, double y)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetPosition_104(base.GetCppThis(), x, y);
		}

		// Token: 0x060081AD RID: 33197
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetPosition2_105(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Specify opposite corners of the box defining the boundary of the
		/// widget. By default, these coordinates are in the normalized viewport
		/// coordinate system, with Position the lower left of the outline, and
		/// Position2 relative to Position. Note that using these methods are
		/// affected by the ProportionalResize flag. That is, if the aspect ratio of
		/// the representation is to be preserved (e.g., ProportionalResize is on),
		/// then the rectangle (Position,Position2) is a bounding rectangle.
		/// </summary>
		// Token: 0x060081AE RID: 33198 RVA: 0x000B9B13 File Offset: 0x000B7D13
		public virtual void SetPosition2(IntPtr x)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetPosition2_105(base.GetCppThis(), x);
		}

		// Token: 0x060081AF RID: 33199
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetPosition2_106(HandleRef pThis, double x, double y);

		/// <summary>
		/// Specify opposite corners of the box defining the boundary of the
		/// widget. By default, these coordinates are in the normalized viewport
		/// coordinate system, with Position the lower left of the outline, and
		/// Position2 relative to Position. Note that using these methods are
		/// affected by the ProportionalResize flag. That is, if the aspect ratio of
		/// the representation is to be preserved (e.g., ProportionalResize is on),
		/// then the rectangle (Position,Position2) is a bounding rectangle.
		/// </summary>
		// Token: 0x060081B0 RID: 33200 RVA: 0x000B9B23 File Offset: 0x000B7D23
		public virtual void SetPosition2(double x, double y)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetPosition2_106(base.GetCppThis(), x, y);
		}

		// Token: 0x060081B1 RID: 33201
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetProportionalResize_107(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether resizing operations should keep the x-y directions
		/// proportional to one another. Also, if ProportionalResize is on, then
		/// the rectangle (Position,Position2) is a bounding rectangle, and the
		/// representation will be placed in the rectangle in such a way as to
		/// preserve the aspect ratio of the representation.
		///
		/// Off by Default.
		/// </summary>
		// Token: 0x060081B2 RID: 33202 RVA: 0x000B9B34 File Offset: 0x000B7D34
		public virtual void SetProportionalResize(int _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetProportionalResize_107(base.GetCppThis(), _arg);
		}

		// Token: 0x060081B3 RID: 33203
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetShowBorder_108(HandleRef pThis, int border);

		/// <summary>
		/// Specify when and if the border should appear. If ShowBorder is "on",
		/// then the border will always appear. If ShowBorder is "off" then the
		/// border will never appear.  If ShowBorder is "active" then the border
		/// will appear when the mouse pointer enters the region bounded by the
		/// border widget.
		/// This method is provided as conveniency to set both horizontal and
		/// vertical borders, and the polygon background.
		/// BORDER_ON by default.
		/// See Also: SetShowHorizontalBorder(), SetShowVerticalBorder(), SetShowPolygon()
		/// </summary>
		// Token: 0x060081B4 RID: 33204 RVA: 0x000B9B44 File Offset: 0x000B7D44
		public virtual void SetShowBorder(int border)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetShowBorder_108(base.GetCppThis(), border);
		}

		// Token: 0x060081B5 RID: 33205
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetShowBorderToActive_109(HandleRef pThis);

		/// <summary>
		/// Specify when and if the border should appear. If ShowBorder is "on",
		/// then the border will always appear. If ShowBorder is "off" then the
		/// border will never appear.  If ShowBorder is "active" then the border
		/// will appear when the mouse pointer enters the region bounded by the
		/// border widget.
		/// This method is provided as conveniency to set both horizontal and
		/// vertical borders, and the polygon background.
		/// BORDER_ON by default.
		/// See Also: SetShowHorizontalBorder(), SetShowVerticalBorder(), SetShowPolygon()
		/// </summary>
		// Token: 0x060081B6 RID: 33206 RVA: 0x000B9B54 File Offset: 0x000B7D54
		public void SetShowBorderToActive()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetShowBorderToActive_109(base.GetCppThis());
		}

		// Token: 0x060081B7 RID: 33207
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetShowBorderToOff_110(HandleRef pThis);

		/// <summary>
		/// Specify when and if the border should appear. If ShowBorder is "on",
		/// then the border will always appear. If ShowBorder is "off" then the
		/// border will never appear.  If ShowBorder is "active" then the border
		/// will appear when the mouse pointer enters the region bounded by the
		/// border widget.
		/// This method is provided as conveniency to set both horizontal and
		/// vertical borders, and the polygon background.
		/// BORDER_ON by default.
		/// See Also: SetShowHorizontalBorder(), SetShowVerticalBorder(), SetShowPolygon()
		/// </summary>
		// Token: 0x060081B8 RID: 33208 RVA: 0x000B9B63 File Offset: 0x000B7D63
		public void SetShowBorderToOff()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetShowBorderToOff_110(base.GetCppThis());
		}

		// Token: 0x060081B9 RID: 33209
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetShowBorderToOn_111(HandleRef pThis);

		/// <summary>
		/// Specify when and if the border should appear. If ShowBorder is "on",
		/// then the border will always appear. If ShowBorder is "off" then the
		/// border will never appear.  If ShowBorder is "active" then the border
		/// will appear when the mouse pointer enters the region bounded by the
		/// border widget.
		/// This method is provided as conveniency to set both horizontal and
		/// vertical borders, and the polygon background.
		/// BORDER_ON by default.
		/// See Also: SetShowHorizontalBorder(), SetShowVerticalBorder(), SetShowPolygon()
		/// </summary>
		// Token: 0x060081BA RID: 33210 RVA: 0x000B9B72 File Offset: 0x000B7D72
		public void SetShowBorderToOn()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetShowBorderToOn_111(base.GetCppThis());
		}

		// Token: 0x060081BB RID: 33211
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetShowHorizontalBorder_112(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify when and if the horizontal border should appear.
		/// BORDER_ON by default.
		/// See Also: SetShowBorder(), SetShowVerticalBorder()
		/// </summary>
		// Token: 0x060081BC RID: 33212 RVA: 0x000B9B81 File Offset: 0x000B7D81
		public virtual void SetShowHorizontalBorder(int _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetShowHorizontalBorder_112(base.GetCppThis(), _arg);
		}

		// Token: 0x060081BD RID: 33213
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetShowPolygon_113(HandleRef pThis, int border);

		/// <summary>
		/// Specify when and if the border's polygon background should appear.
		/// BORDER_ON by default.
		/// See Also: SetShowBorder()
		/// </summary>
		// Token: 0x060081BE RID: 33214 RVA: 0x000B9B91 File Offset: 0x000B7D91
		public virtual void SetShowPolygon(int border)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetShowPolygon_113(base.GetCppThis(), border);
		}

		// Token: 0x060081BF RID: 33215
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetShowPolygonBackground_114(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify when and if the border polygon background should appear.
		/// BORDER_ON by default.
		/// See Also: SetShowBorder(), SetShowPolygon()
		/// </summary>
		// Token: 0x060081C0 RID: 33216 RVA: 0x000B9BA1 File Offset: 0x000B7DA1
		public virtual void SetShowPolygonBackground(int _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetShowPolygonBackground_114(base.GetCppThis(), _arg);
		}

		// Token: 0x060081C1 RID: 33217
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetShowPolygonToActive_115(HandleRef pThis);

		/// <summary>
		/// Specify when and if the border's polygon background should appear.
		/// BORDER_ON by default.
		/// See Also: SetShowBorder()
		/// </summary>
		// Token: 0x060081C2 RID: 33218 RVA: 0x000B9BB1 File Offset: 0x000B7DB1
		public void SetShowPolygonToActive()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetShowPolygonToActive_115(base.GetCppThis());
		}

		// Token: 0x060081C3 RID: 33219
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetShowPolygonToOff_116(HandleRef pThis);

		/// <summary>
		/// Specify when and if the border's polygon background should appear.
		/// BORDER_ON by default.
		/// See Also: SetShowBorder()
		/// </summary>
		// Token: 0x060081C4 RID: 33220 RVA: 0x000B9BC0 File Offset: 0x000B7DC0
		public void SetShowPolygonToOff()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetShowPolygonToOff_116(base.GetCppThis());
		}

		// Token: 0x060081C5 RID: 33221
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetShowPolygonToOn_117(HandleRef pThis);

		/// <summary>
		/// Specify when and if the border's polygon background should appear.
		/// BORDER_ON by default.
		/// See Also: SetShowBorder()
		/// </summary>
		// Token: 0x060081C6 RID: 33222 RVA: 0x000B9BCF File Offset: 0x000B7DCF
		public void SetShowPolygonToOn()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetShowPolygonToOn_117(base.GetCppThis());
		}

		// Token: 0x060081C7 RID: 33223
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetShowVerticalBorder_118(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify when and if the vertical border should appear.
		/// BORDER_ON by default.
		/// See Also: SetShowBorder(), SetShowHorizontalBorder()
		/// </summary>
		// Token: 0x060081C8 RID: 33224 RVA: 0x000B9BDE File Offset: 0x000B7DDE
		public virtual void SetShowVerticalBorder(int _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetShowVerticalBorder_118(base.GetCppThis(), _arg);
		}

		// Token: 0x060081C9 RID: 33225
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetTolerance_119(HandleRef pThis, int _arg);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered to be on the widget, or on a
		/// widget feature (e.g., a corner point or edge).
		///
		/// Default is 3.
		/// </summary>
		// Token: 0x060081CA RID: 33226 RVA: 0x000B9BEE File Offset: 0x000B7DEE
		public virtual void SetTolerance(int _arg)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetTolerance_119(base.GetCppThis(), _arg);
		}

		// Token: 0x060081CB RID: 33227
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_SetWindowLocation_120(HandleRef pThis, int enumLocation);

		/// <summary>
		/// Set the representation position, by enumeration (
		/// AnyLocation = 0,
		/// LowerLeftCorner,
		/// LowerRightCorner,
		/// LowerCenter,
		/// UpperLeftCorner,
		/// UpperRightCorner,
		/// UpperCenter)
		/// related to the render window
		/// </summary>
		// Token: 0x060081CC RID: 33228 RVA: 0x000B9BFE File Offset: 0x000B7DFE
		public virtual void SetWindowLocation(int enumLocation)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_SetWindowLocation_120(base.GetCppThis(), enumLocation);
		}

		// Token: 0x060081CD RID: 33229
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_StartWidgetInteraction_121(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Subclasses should implement these methods. See the superclasses'
		/// documentation for more information.
		/// </summary>
		// Token: 0x060081CE RID: 33230 RVA: 0x000B9C0E File Offset: 0x000B7E0E
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_StartWidgetInteraction_121(base.GetCppThis(), eventPos);
		}

		// Token: 0x060081CF RID: 33231
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_UpdateWindowLocation_122(HandleRef pThis);

		/// <summary>
		/// Update window location if a window location is set.
		///
		/// This function was made public for VTK issue #18987.
		/// Positioning and scaling needs a better API.
		/// </summary>
		// Token: 0x060081D0 RID: 33232 RVA: 0x000B9C1E File Offset: 0x000B7E1E
		public virtual void UpdateWindowLocation()
		{
			vtkBorderRepresentation.vtkBorderRepresentation_UpdateWindowLocation_122(base.GetCppThis());
		}

		// Token: 0x060081D1 RID: 33233
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBorderRepresentation_WidgetInteraction_123(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Subclasses should implement these methods. See the superclasses'
		/// documentation for more information.
		/// </summary>
		// Token: 0x060081D2 RID: 33234 RVA: 0x000B9C2D File Offset: 0x000B7E2D
		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkBorderRepresentation.vtkBorderRepresentation_WidgetInteraction_123(base.GetCppThis(), eventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000AF2 RID: 2802
		public new const string MRFullTypeName = "Kitware.VTK.vtkBorderRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000AF3 RID: 2803
		public new static readonly string MRClassNameKey = "class vtkBorderRepresentation";

		/// <summary>
		/// Specify opposite corners of the box defining the boundary of the
		/// widget. By default, these coordinates are in the normalized viewport
		/// coordinate system, with Position the lower left of the outline, and
		/// Position2 relative to Position. Note that using these methods are
		/// affected by the ProportionalResize flag. That is, if the aspect ratio of
		/// the representation is to be preserved (e.g., ProportionalResize is on),
		/// then the rectangle (Position,Position2) is a bounding rectangle.
		/// </summary>
		// Token: 0x020002CF RID: 719
		public enum BORDER_ACTIVE_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000AF5 RID: 2805
			BORDER_ACTIVE = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000AF6 RID: 2806
			BORDER_OFF = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000AF7 RID: 2807
			BORDER_ON
		}

		/// <summary>
		/// This is a modifier of the interaction state. When set, widget interaction
		/// allows the border (and stuff inside of it) to be translated with mouse
		/// motion.
		/// </summary>
		// Token: 0x020002D0 RID: 720
		public enum AnyLocation_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000AF9 RID: 2809
			AnyLocation,
			/// <summary>enum member</summary>
			// Token: 0x04000AFA RID: 2810
			LowerCenter = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000AFB RID: 2811
			LowerLeftCorner = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000AFC RID: 2812
			LowerRightCorner,
			/// <summary>enum member</summary>
			// Token: 0x04000AFD RID: 2813
			UpperCenter = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000AFE RID: 2814
			UpperLeftCorner = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000AFF RID: 2815
			UpperRightCorner
		}

		/// <summary>
		/// Define the various states that the representation can be in.
		/// </summary>
		// Token: 0x020002D1 RID: 721
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000B01 RID: 2817
			AdjustingE0 = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000B02 RID: 2818
			AdjustingE1,
			/// <summary>enum member</summary>
			// Token: 0x04000B03 RID: 2819
			AdjustingE2,
			/// <summary>enum member</summary>
			// Token: 0x04000B04 RID: 2820
			AdjustingE3,
			/// <summary>enum member</summary>
			// Token: 0x04000B05 RID: 2821
			AdjustingP0 = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000B06 RID: 2822
			AdjustingP1,
			/// <summary>enum member</summary>
			// Token: 0x04000B07 RID: 2823
			AdjustingP2,
			/// <summary>enum member</summary>
			// Token: 0x04000B08 RID: 2824
			AdjustingP3,
			/// <summary>enum member</summary>
			// Token: 0x04000B09 RID: 2825
			Inside = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000B0A RID: 2826
			Outside = 0
		}
	}
}
