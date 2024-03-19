using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleFlight
	/// </summary>
	/// <remarks>
	///    provides flight motion routines
	///
	///
	/// Left  mouse button press produces forward motion.
	/// Right mouse button press produces reverse motion.
	/// Moving mouse during motion steers user in desired direction.
	/// Keyboard controls are:
	/// Left/Right/Up/Down Arrows for steering direction
	/// 'A' forward, 'Z' reverse motion
	/// Ctrl Key causes sidestep instead of steering in mouse and key modes
	/// Shift key is accelerator in mouse and key modes
	/// Ctrl and Shift together causes Roll in mouse and key modes
	///
	/// By default, one "step" of motion corresponds to 1/250th of the diagonal
	/// of bounding box of visible actors, '+' and '-' keys allow user to
	/// increase or decrease step size.
	/// </remarks>
	// Token: 0x020003F9 RID: 1017
	public class vtkInteractorStyleFlight : vtkInteractorStyle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C1FD RID: 49661 RVA: 0x0010E507 File Offset: 0x0010C707
		static vtkInteractorStyleFlight()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleFlight.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleFlight"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C1FE RID: 49662 RVA: 0x0010E52F File Offset: 0x0010C72F
		public vtkInteractorStyleFlight(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C1FF RID: 49663
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleFlight_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C200 RID: 49664 RVA: 0x0010E540 File Offset: 0x0010C740
		public new static vtkInteractorStyleFlight New()
		{
			vtkInteractorStyleFlight result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleFlight.vtkInteractorStyleFlight_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleFlight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C201 RID: 49665 RVA: 0x0010E594 File Offset: 0x0010C794
		public vtkInteractorStyleFlight() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleFlight.vtkInteractorStyleFlight_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C202 RID: 49666 RVA: 0x0010E5D8 File Offset: 0x0010C7D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C203 RID: 49667
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_DisableMotionOff_01(HandleRef pThis);

		/// <summary>
		/// Disable motion (temporarily - for viewing etc)
		/// </summary>
		// Token: 0x0600C204 RID: 49668 RVA: 0x0010E5E3 File Offset: 0x0010C7E3
		public virtual void DisableMotionOff()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_DisableMotionOff_01(base.GetCppThis());
		}

		// Token: 0x0600C205 RID: 49669
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_DisableMotionOn_02(HandleRef pThis);

		/// <summary>
		/// Disable motion (temporarily - for viewing etc)
		/// </summary>
		// Token: 0x0600C206 RID: 49670 RVA: 0x0010E5F2 File Offset: 0x0010C7F2
		public virtual void DisableMotionOn()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_DisableMotionOn_02(base.GetCppThis());
		}

		// Token: 0x0600C207 RID: 49671
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_EndForwardFly_03(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of Keyboard event bindings for flight
		/// </summary>
		// Token: 0x0600C208 RID: 49672 RVA: 0x0010E601 File Offset: 0x0010C801
		public virtual void EndForwardFly()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_EndForwardFly_03(base.GetCppThis());
		}

		// Token: 0x0600C209 RID: 49673
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_EndReverseFly_04(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of Keyboard event bindings for flight
		/// </summary>
		// Token: 0x0600C20A RID: 49674 RVA: 0x0010E610 File Offset: 0x0010C810
		public virtual void EndReverseFly()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_EndReverseFly_04(base.GetCppThis());
		}

		// Token: 0x0600C20B RID: 49675
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_ForwardFly_05(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of Keyboard event bindings for flight
		/// </summary>
		// Token: 0x0600C20C RID: 49676 RVA: 0x0010E61F File Offset: 0x0010C81F
		public virtual void ForwardFly()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_ForwardFly_05(base.GetCppThis());
		}

		// Token: 0x0600C20D RID: 49677
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkInteractorStyleFlight_GetAngleAccelerationFactor_06(HandleRef pThis);

		/// <summary>
		/// Set angular acceleration when shift key is applied : default 5
		/// </summary>
		// Token: 0x0600C20E RID: 49678 RVA: 0x0010E630 File Offset: 0x0010C830
		public virtual double GetAngleAccelerationFactor()
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetAngleAccelerationFactor_06(base.GetCppThis());
		}

		// Token: 0x0600C20F RID: 49679
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkInteractorStyleFlight_GetAngleStepSize_07(HandleRef pThis);

		/// <summary>
		/// Set the basic angular unit for turning : default 1 degree
		/// </summary>
		// Token: 0x0600C210 RID: 49680 RVA: 0x0010E650 File Offset: 0x0010C850
		public virtual double GetAngleStepSize()
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetAngleStepSize_07(base.GetCppThis());
		}

		// Token: 0x0600C211 RID: 49681
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleFlight_GetDefaultUpVector_08(HandleRef pThis);

		/// <summary>
		/// When flying, apply a restorative force to the "Up" vector.
		/// This is activated when the current 'up' is close to the actual 'up'
		/// (as defined in DefaultUpVector). This prevents excessive twisting forces
		/// when viewing from arbitrary angles, but keep the horizon level when
		/// the user is flying over terrain.
		/// </summary>
		// Token: 0x0600C212 RID: 49682 RVA: 0x0010E670 File Offset: 0x0010C870
		public virtual double[] GetDefaultUpVector()
		{
			IntPtr intPtr = vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetDefaultUpVector_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C213 RID: 49683
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_GetDefaultUpVector_09(HandleRef pThis, IntPtr data);

		/// <summary>
		/// When flying, apply a restorative force to the "Up" vector.
		/// This is activated when the current 'up' is close to the actual 'up'
		/// (as defined in DefaultUpVector). This prevents excessive twisting forces
		/// when viewing from arbitrary angles, but keep the horizon level when
		/// the user is flying over terrain.
		/// </summary>
		// Token: 0x0600C214 RID: 49684 RVA: 0x0010E6B8 File Offset: 0x0010C8B8
		public virtual void GetDefaultUpVector(IntPtr data)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetDefaultUpVector_09(base.GetCppThis(), data);
		}

		// Token: 0x0600C215 RID: 49685
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleFlight_GetDisableMotion_10(HandleRef pThis);

		/// <summary>
		/// Disable motion (temporarily - for viewing etc)
		/// </summary>
		// Token: 0x0600C216 RID: 49686 RVA: 0x0010E6C8 File Offset: 0x0010C8C8
		public virtual int GetDisableMotion()
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetDisableMotion_10(base.GetCppThis());
		}

		// Token: 0x0600C217 RID: 49687
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkInteractorStyleFlight_GetMotionAccelerationFactor_11(HandleRef pThis);

		/// <summary>
		/// Set acceleration factor when shift key is applied : default 10
		/// </summary>
		// Token: 0x0600C218 RID: 49688 RVA: 0x0010E6E8 File Offset: 0x0010C8E8
		public virtual double GetMotionAccelerationFactor()
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetMotionAccelerationFactor_11(base.GetCppThis());
		}

		// Token: 0x0600C219 RID: 49689
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkInteractorStyleFlight_GetMotionStepSize_12(HandleRef pThis);

		/// <summary>
		/// Set the basic unit step size : by default 1/250 of bounding diagonal
		/// </summary>
		// Token: 0x0600C21A RID: 49690 RVA: 0x0010E708 File Offset: 0x0010C908
		public virtual double GetMotionStepSize()
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetMotionStepSize_12(base.GetCppThis());
		}

		// Token: 0x0600C21B RID: 49691
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleFlight_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C21C RID: 49692 RVA: 0x0010E728 File Offset: 0x0010C928
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0600C21D RID: 49693
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleFlight_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C21E RID: 49694 RVA: 0x0010E748 File Offset: 0x0010C948
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0600C21F RID: 49695
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleFlight_GetRestoreUpVector_15(HandleRef pThis);

		/// <summary>
		/// When flying, apply a restorative force to the "Up" vector.
		/// This is activated when the current 'up' is close to the actual 'up'
		/// (as defined in DefaultUpVector). This prevents excessive twisting forces
		/// when viewing from arbitrary angles, but keep the horizon level when
		/// the user is flying over terrain.
		/// </summary>
		// Token: 0x0600C220 RID: 49696 RVA: 0x0010E764 File Offset: 0x0010C964
		public virtual int GetRestoreUpVector()
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_GetRestoreUpVector_15(base.GetCppThis());
		}

		// Token: 0x0600C221 RID: 49697
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleFlight_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C222 RID: 49698 RVA: 0x0010E784 File Offset: 0x0010C984
		public override int IsA(string type)
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0600C223 RID: 49699
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleFlight_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C224 RID: 49700 RVA: 0x0010E7A4 File Offset: 0x0010C9A4
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleFlight.vtkInteractorStyleFlight_IsTypeOf_17(type);
		}

		// Token: 0x0600C225 RID: 49701
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_JumpTo_18(HandleRef pThis, IntPtr campos, IntPtr focpos);

		/// <summary>
		/// Move the Eye/Camera to a specific location (no intermediate
		/// steps are taken
		/// </summary>
		// Token: 0x0600C226 RID: 49702 RVA: 0x0010E7BE File Offset: 0x0010C9BE
		public void JumpTo(IntPtr campos, IntPtr focpos)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_JumpTo_18(base.GetCppThis(), campos, focpos);
		}

		// Token: 0x0600C227 RID: 49703
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleFlight_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C228 RID: 49704 RVA: 0x0010E7D0 File Offset: 0x0010C9D0
		public new vtkInteractorStyleFlight NewInstance()
		{
			vtkInteractorStyleFlight result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleFlight.vtkInteractorStyleFlight_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleFlight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C229 RID: 49705
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_OnChar_21(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of Keyboard event bindings for flight
		/// </summary>
		// Token: 0x0600C22A RID: 49706 RVA: 0x0010E82A File Offset: 0x0010CA2A
		public override void OnChar()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnChar_21(base.GetCppThis());
		}

		// Token: 0x0600C22B RID: 49707
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_OnKeyDown_22(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of Keyboard event bindings for flight
		/// </summary>
		// Token: 0x0600C22C RID: 49708 RVA: 0x0010E839 File Offset: 0x0010CA39
		public override void OnKeyDown()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnKeyDown_22(base.GetCppThis());
		}

		// Token: 0x0600C22D RID: 49709
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_OnKeyUp_23(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of Keyboard event bindings for flight
		/// </summary>
		// Token: 0x0600C22E RID: 49710 RVA: 0x0010E848 File Offset: 0x0010CA48
		public override void OnKeyUp()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnKeyUp_23(base.GetCppThis());
		}

		// Token: 0x0600C22F RID: 49711
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_OnLeftButtonDown_24(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of Mouse event bindings for flight
		/// </summary>
		// Token: 0x0600C230 RID: 49712 RVA: 0x0010E857 File Offset: 0x0010CA57
		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnLeftButtonDown_24(base.GetCppThis());
		}

		// Token: 0x0600C231 RID: 49713
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_OnLeftButtonUp_25(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of Mouse event bindings for flight
		/// </summary>
		// Token: 0x0600C232 RID: 49714 RVA: 0x0010E866 File Offset: 0x0010CA66
		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnLeftButtonUp_25(base.GetCppThis());
		}

		// Token: 0x0600C233 RID: 49715
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_OnMiddleButtonDown_26(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of Mouse event bindings for flight
		/// </summary>
		// Token: 0x0600C234 RID: 49716 RVA: 0x0010E875 File Offset: 0x0010CA75
		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnMiddleButtonDown_26(base.GetCppThis());
		}

		// Token: 0x0600C235 RID: 49717
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_OnMiddleButtonUp_27(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of Mouse event bindings for flight
		/// </summary>
		// Token: 0x0600C236 RID: 49718 RVA: 0x0010E884 File Offset: 0x0010CA84
		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnMiddleButtonUp_27(base.GetCppThis());
		}

		// Token: 0x0600C237 RID: 49719
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_OnMouseMove_28(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of Mouse event bindings for flight
		/// </summary>
		// Token: 0x0600C238 RID: 49720 RVA: 0x0010E893 File Offset: 0x0010CA93
		public override void OnMouseMove()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnMouseMove_28(base.GetCppThis());
		}

		// Token: 0x0600C239 RID: 49721
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_OnRightButtonDown_29(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of Mouse event bindings for flight
		/// </summary>
		// Token: 0x0600C23A RID: 49722 RVA: 0x0010E8A2 File Offset: 0x0010CAA2
		public override void OnRightButtonDown()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnRightButtonDown_29(base.GetCppThis());
		}

		// Token: 0x0600C23B RID: 49723
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_OnRightButtonUp_30(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of Mouse event bindings for flight
		/// </summary>
		// Token: 0x0600C23C RID: 49724 RVA: 0x0010E8B1 File Offset: 0x0010CAB1
		public override void OnRightButtonUp()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnRightButtonUp_30(base.GetCppThis());
		}

		// Token: 0x0600C23D RID: 49725
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_OnTimer_31(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of Keyboard event bindings for flight
		/// </summary>
		// Token: 0x0600C23E RID: 49726 RVA: 0x0010E8C0 File Offset: 0x0010CAC0
		public override void OnTimer()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_OnTimer_31(base.GetCppThis());
		}

		// Token: 0x0600C23F RID: 49727
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_RestoreUpVectorOff_32(HandleRef pThis);

		/// <summary>
		/// When flying, apply a restorative force to the "Up" vector.
		/// This is activated when the current 'up' is close to the actual 'up'
		/// (as defined in DefaultUpVector). This prevents excessive twisting forces
		/// when viewing from arbitrary angles, but keep the horizon level when
		/// the user is flying over terrain.
		/// </summary>
		// Token: 0x0600C240 RID: 49728 RVA: 0x0010E8CF File Offset: 0x0010CACF
		public virtual void RestoreUpVectorOff()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_RestoreUpVectorOff_32(base.GetCppThis());
		}

		// Token: 0x0600C241 RID: 49729
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_RestoreUpVectorOn_33(HandleRef pThis);

		/// <summary>
		/// When flying, apply a restorative force to the "Up" vector.
		/// This is activated when the current 'up' is close to the actual 'up'
		/// (as defined in DefaultUpVector). This prevents excessive twisting forces
		/// when viewing from arbitrary angles, but keep the horizon level when
		/// the user is flying over terrain.
		/// </summary>
		// Token: 0x0600C242 RID: 49730 RVA: 0x0010E8DE File Offset: 0x0010CADE
		public virtual void RestoreUpVectorOn()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_RestoreUpVectorOn_33(base.GetCppThis());
		}

		// Token: 0x0600C243 RID: 49731
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_ReverseFly_34(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of Keyboard event bindings for flight
		/// </summary>
		// Token: 0x0600C244 RID: 49732 RVA: 0x0010E8ED File Offset: 0x0010CAED
		public virtual void ReverseFly()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_ReverseFly_34(base.GetCppThis());
		}

		// Token: 0x0600C245 RID: 49733
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleFlight_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C246 RID: 49734 RVA: 0x0010E8FC File Offset: 0x0010CAFC
		public new static vtkInteractorStyleFlight SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleFlight vtkInteractorStyleFlight = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleFlight.vtkInteractorStyleFlight_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleFlight = (vtkInteractorStyleFlight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleFlight.Register(null);
				}
			}
			return vtkInteractorStyleFlight;
		}

		// Token: 0x0600C247 RID: 49735
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_SetAngleAccelerationFactor_36(HandleRef pThis, double _arg);

		/// <summary>
		/// Set angular acceleration when shift key is applied : default 5
		/// </summary>
		// Token: 0x0600C248 RID: 49736 RVA: 0x0010E97B File Offset: 0x0010CB7B
		public virtual void SetAngleAccelerationFactor(double _arg)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_SetAngleAccelerationFactor_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C249 RID: 49737
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_SetAngleStepSize_37(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the basic angular unit for turning : default 1 degree
		/// </summary>
		// Token: 0x0600C24A RID: 49738 RVA: 0x0010E98B File Offset: 0x0010CB8B
		public virtual void SetAngleStepSize(double _arg)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_SetAngleStepSize_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C24B RID: 49739
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_SetDefaultUpVector_38(HandleRef pThis, IntPtr data);

		/// <summary>
		/// When flying, apply a restorative force to the "Up" vector.
		/// This is activated when the current 'up' is close to the actual 'up'
		/// (as defined in DefaultUpVector). This prevents excessive twisting forces
		/// when viewing from arbitrary angles, but keep the horizon level when
		/// the user is flying over terrain.
		/// </summary>
		// Token: 0x0600C24C RID: 49740 RVA: 0x0010E99B File Offset: 0x0010CB9B
		public virtual void SetDefaultUpVector(IntPtr data)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_SetDefaultUpVector_38(base.GetCppThis(), data);
		}

		// Token: 0x0600C24D RID: 49741
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_SetDisableMotion_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Disable motion (temporarily - for viewing etc)
		/// </summary>
		// Token: 0x0600C24E RID: 49742 RVA: 0x0010E9AB File Offset: 0x0010CBAB
		public virtual void SetDisableMotion(int _arg)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_SetDisableMotion_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C24F RID: 49743
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_SetMotionAccelerationFactor_40(HandleRef pThis, double _arg);

		/// <summary>
		/// Set acceleration factor when shift key is applied : default 10
		/// </summary>
		// Token: 0x0600C250 RID: 49744 RVA: 0x0010E9BB File Offset: 0x0010CBBB
		public virtual void SetMotionAccelerationFactor(double _arg)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_SetMotionAccelerationFactor_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C251 RID: 49745
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_SetMotionStepSize_41(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the basic unit step size : by default 1/250 of bounding diagonal
		/// </summary>
		// Token: 0x0600C252 RID: 49746 RVA: 0x0010E9CB File Offset: 0x0010CBCB
		public virtual void SetMotionStepSize(double _arg)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_SetMotionStepSize_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C253 RID: 49747
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_SetRestoreUpVector_42(HandleRef pThis, int _arg);

		/// <summary>
		/// When flying, apply a restorative force to the "Up" vector.
		/// This is activated when the current 'up' is close to the actual 'up'
		/// (as defined in DefaultUpVector). This prevents excessive twisting forces
		/// when viewing from arbitrary angles, but keep the horizon level when
		/// the user is flying over terrain.
		/// </summary>
		// Token: 0x0600C254 RID: 49748 RVA: 0x0010E9DB File Offset: 0x0010CBDB
		public virtual void SetRestoreUpVector(int _arg)
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_SetRestoreUpVector_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C255 RID: 49749
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_StartForwardFly_43(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of Keyboard event bindings for flight
		/// </summary>
		// Token: 0x0600C256 RID: 49750 RVA: 0x0010E9EB File Offset: 0x0010CBEB
		public virtual void StartForwardFly()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_StartForwardFly_43(base.GetCppThis());
		}

		// Token: 0x0600C257 RID: 49751
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleFlight_StartReverseFly_44(HandleRef pThis);

		/// <summary>
		/// Concrete implementation of Keyboard event bindings for flight
		/// </summary>
		// Token: 0x0600C258 RID: 49752 RVA: 0x0010E9FA File Offset: 0x0010CBFA
		public virtual void StartReverseFly()
		{
			vtkInteractorStyleFlight.vtkInteractorStyleFlight_StartReverseFly_44(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E5F RID: 3679
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleFlight";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E60 RID: 3680
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleFlight";
	}
}
