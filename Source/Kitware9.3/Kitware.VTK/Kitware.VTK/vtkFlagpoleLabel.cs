using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkFlagpoleLabel
	/// </summary>
	/// <remarks>
	///  Renders a flagpole (line) with a label at the top that faces the camera
	///
	/// This class draws a line from the base to the top of the flagpole. It then
	/// places a text annotation at the top, centered horizontally. The text is
	/// always oriented with the flagpole but will rotate aroundthe flagpole to
	/// face the camera.
	/// </remarks>
	// Token: 0x020007DE RID: 2014
	public class vtkFlagpoleLabel : vtkActor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014AD2 RID: 84690 RVA: 0x001D44C5 File Offset: 0x001D26C5
		static vtkFlagpoleLabel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFlagpoleLabel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFlagpoleLabel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014AD3 RID: 84691 RVA: 0x001D44ED File Offset: 0x001D26ED
		public vtkFlagpoleLabel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014AD4 RID: 84692
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlagpoleLabel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014AD5 RID: 84693 RVA: 0x001D44FC File Offset: 0x001D26FC
		public new static vtkFlagpoleLabel New()
		{
			vtkFlagpoleLabel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFlagpoleLabel.vtkFlagpoleLabel_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFlagpoleLabel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014AD6 RID: 84694 RVA: 0x001D4550 File Offset: 0x001D2750
		public vtkFlagpoleLabel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFlagpoleLabel.vtkFlagpoleLabel_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014AD7 RID: 84695 RVA: 0x001D4594 File Offset: 0x001D2794
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014AD8 RID: 84696
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlagpoleLabel_ForceOpaqueOff_01(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x06014AD9 RID: 84697 RVA: 0x001D459F File Offset: 0x001D279F
		public override void ForceOpaqueOff()
		{
			vtkFlagpoleLabel.vtkFlagpoleLabel_ForceOpaqueOff_01(base.GetCppThis());
		}

		// Token: 0x06014ADA RID: 84698
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlagpoleLabel_ForceOpaqueOn_02(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x06014ADB RID: 84699 RVA: 0x001D45AE File Offset: 0x001D27AE
		public override void ForceOpaqueOn()
		{
			vtkFlagpoleLabel.vtkFlagpoleLabel_ForceOpaqueOn_02(base.GetCppThis());
		}

		// Token: 0x06014ADC RID: 84700
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlagpoleLabel_ForceTranslucentOff_03(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x06014ADD RID: 84701 RVA: 0x001D45BD File Offset: 0x001D27BD
		public override void ForceTranslucentOff()
		{
			vtkFlagpoleLabel.vtkFlagpoleLabel_ForceTranslucentOff_03(base.GetCppThis());
		}

		// Token: 0x06014ADE RID: 84702
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlagpoleLabel_ForceTranslucentOn_04(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x06014ADF RID: 84703 RVA: 0x001D45CC File Offset: 0x001D27CC
		public override void ForceTranslucentOn()
		{
			vtkFlagpoleLabel.vtkFlagpoleLabel_ForceTranslucentOn_04(base.GetCppThis());
		}

		// Token: 0x06014AE0 RID: 84704
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlagpoleLabel_GetBasePosition_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the world coordinate position of the base
		/// </summary>
		// Token: 0x06014AE1 RID: 84705 RVA: 0x001D45DC File Offset: 0x001D27DC
		public virtual double[] GetBasePosition()
		{
			IntPtr intPtr = vtkFlagpoleLabel.vtkFlagpoleLabel_GetBasePosition_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014AE2 RID: 84706
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlagpoleLabel_GetBasePosition_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the world coordinate position of the base
		/// </summary>
		// Token: 0x06014AE3 RID: 84707 RVA: 0x001D4624 File Offset: 0x001D2824
		public virtual void GetBasePosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkFlagpoleLabel.vtkFlagpoleLabel_GetBasePosition_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06014AE4 RID: 84708
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlagpoleLabel_GetBasePosition_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the world coordinate position of the base
		/// </summary>
		// Token: 0x06014AE5 RID: 84709 RVA: 0x001D4636 File Offset: 0x001D2836
		public virtual void GetBasePosition(IntPtr _arg)
		{
			vtkFlagpoleLabel.vtkFlagpoleLabel_GetBasePosition_07(base.GetCppThis(), _arg);
		}

		// Token: 0x06014AE6 RID: 84710
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlagpoleLabel_GetBounds_08(HandleRef pThis);

		/// <summary>
		/// Just render in translucent pass, since it can execute multiple times
		/// (depth peeling, for instance).
		/// </summary>
		// Token: 0x06014AE7 RID: 84711 RVA: 0x001D4648 File Offset: 0x001D2848
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkFlagpoleLabel.vtkFlagpoleLabel_GetBounds_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014AE8 RID: 84712
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFlagpoleLabel_GetFlagSize_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the size of the flag. 1.0 is the default size
		/// which corresponds to a preset texels/window value. Adjust this
		/// to increase or decrease the default size.
		/// </summary>
		// Token: 0x06014AE9 RID: 84713 RVA: 0x001D4690 File Offset: 0x001D2890
		public virtual double GetFlagSize()
		{
			return vtkFlagpoleLabel.vtkFlagpoleLabel_GetFlagSize_09(base.GetCppThis());
		}

		// Token: 0x06014AEA RID: 84714
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFlagpoleLabel_GetForceOpaque_10(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x06014AEB RID: 84715 RVA: 0x001D46B0 File Offset: 0x001D28B0
		public override bool GetForceOpaque()
		{
			return vtkFlagpoleLabel.vtkFlagpoleLabel_GetForceOpaque_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06014AEC RID: 84716
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFlagpoleLabel_GetForceTranslucent_11(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x06014AED RID: 84717 RVA: 0x001D46D8 File Offset: 0x001D28D8
		public override bool GetForceTranslucent()
		{
			return vtkFlagpoleLabel.vtkFlagpoleLabel_GetForceTranslucent_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06014AEE RID: 84718
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlagpoleLabel_GetInput_12(HandleRef pThis);

		/// <summary>
		/// The UTF-8 encoded string to display.
		/// @{
		/// </summary>
		// Token: 0x06014AEF RID: 84719 RVA: 0x001D4700 File Offset: 0x001D2900
		public virtual string GetInput()
		{
			string s = Marshal.PtrToStringAnsi(vtkFlagpoleLabel.vtkFlagpoleLabel_GetInput_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014AF0 RID: 84720
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFlagpoleLabel_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014AF1 RID: 84721 RVA: 0x001D473C File Offset: 0x001D293C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFlagpoleLabel.vtkFlagpoleLabel_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06014AF2 RID: 84722
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFlagpoleLabel_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014AF3 RID: 84723 RVA: 0x001D475C File Offset: 0x001D295C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFlagpoleLabel.vtkFlagpoleLabel_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06014AF4 RID: 84724
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlagpoleLabel_GetTextProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The vtkTextProperty object that controls the rendered text.
		/// @{
		/// </summary>
		// Token: 0x06014AF5 RID: 84725 RVA: 0x001D4778 File Offset: 0x001D2978
		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFlagpoleLabel.vtkFlagpoleLabel_GetTextProperty_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06014AF6 RID: 84726
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlagpoleLabel_GetTopPosition_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the world coordinate position of the top
		/// </summary>
		// Token: 0x06014AF7 RID: 84727 RVA: 0x001D47E8 File Offset: 0x001D29E8
		public virtual double[] GetTopPosition()
		{
			IntPtr intPtr = vtkFlagpoleLabel.vtkFlagpoleLabel_GetTopPosition_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014AF8 RID: 84728
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlagpoleLabel_GetTopPosition_17(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the world coordinate position of the top
		/// </summary>
		// Token: 0x06014AF9 RID: 84729 RVA: 0x001D4830 File Offset: 0x001D2A30
		public virtual void GetTopPosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkFlagpoleLabel.vtkFlagpoleLabel_GetTopPosition_17(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06014AFA RID: 84730
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlagpoleLabel_GetTopPosition_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the world coordinate position of the top
		/// </summary>
		// Token: 0x06014AFB RID: 84731 RVA: 0x001D4842 File Offset: 0x001D2A42
		public virtual void GetTopPosition(IntPtr _arg)
		{
			vtkFlagpoleLabel.vtkFlagpoleLabel_GetTopPosition_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06014AFC RID: 84732
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlagpoleLabel_HasTranslucentPolygonalGeometry_19(HandleRef pThis);

		/// <summary>
		/// Defers to internal actor.
		/// </summary>
		// Token: 0x06014AFD RID: 84733 RVA: 0x001D4854 File Offset: 0x001D2A54
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkFlagpoleLabel.vtkFlagpoleLabel_HasTranslucentPolygonalGeometry_19(base.GetCppThis());
		}

		// Token: 0x06014AFE RID: 84734
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlagpoleLabel_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014AFF RID: 84735 RVA: 0x001D4874 File Offset: 0x001D2A74
		public override int IsA(string type)
		{
			return vtkFlagpoleLabel.vtkFlagpoleLabel_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x06014B00 RID: 84736
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlagpoleLabel_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B01 RID: 84737 RVA: 0x001D4894 File Offset: 0x001D2A94
		public new static int IsTypeOf(string type)
		{
			return vtkFlagpoleLabel.vtkFlagpoleLabel_IsTypeOf_21(type);
		}

		// Token: 0x06014B02 RID: 84738
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlagpoleLabel_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B03 RID: 84739 RVA: 0x001D48B0 File Offset: 0x001D2AB0
		public new vtkFlagpoleLabel NewInstance()
		{
			vtkFlagpoleLabel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFlagpoleLabel.vtkFlagpoleLabel_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFlagpoleLabel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014B04 RID: 84740
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlagpoleLabel_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef win);

		/// <summary>
		/// Just render in translucent pass, since it can execute multiple times
		/// (depth peeling, for instance).
		/// </summary>
		// Token: 0x06014B05 RID: 84741 RVA: 0x001D490C File Offset: 0x001D2B0C
		public override void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkFlagpoleLabel.vtkFlagpoleLabel_ReleaseGraphicsResources_24(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x06014B06 RID: 84742
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlagpoleLabel_RenderOpaqueGeometry_25(HandleRef pThis, HandleRef vp);

		/// <summary>
		/// Check/update geometry/texture in opaque pass, since it only happens once.
		/// </summary>
		// Token: 0x06014B07 RID: 84743 RVA: 0x001D493C File Offset: 0x001D2B3C
		public override int RenderOpaqueGeometry(vtkViewport vp)
		{
			return vtkFlagpoleLabel.vtkFlagpoleLabel_RenderOpaqueGeometry_25(base.GetCppThis(), (vp == null) ? default(HandleRef) : vp.GetCppThis());
		}

		// Token: 0x06014B08 RID: 84744
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlagpoleLabel_RenderTranslucentPolygonalGeometry_26(HandleRef pThis, HandleRef vp);

		/// <summary>
		/// Just render in translucent pass, since it can execute multiple times
		/// (depth peeling, for instance).
		/// </summary>
		// Token: 0x06014B09 RID: 84745 RVA: 0x001D4970 File Offset: 0x001D2B70
		public override int RenderTranslucentPolygonalGeometry(vtkViewport vp)
		{
			return vtkFlagpoleLabel.vtkFlagpoleLabel_RenderTranslucentPolygonalGeometry_26(base.GetCppThis(), (vp == null) ? default(HandleRef) : vp.GetCppThis());
		}

		// Token: 0x06014B0A RID: 84746
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlagpoleLabel_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B0B RID: 84747 RVA: 0x001D49A4 File Offset: 0x001D2BA4
		public new static vtkFlagpoleLabel SafeDownCast(vtkObjectBase o)
		{
			vtkFlagpoleLabel vtkFlagpoleLabel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFlagpoleLabel.vtkFlagpoleLabel_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFlagpoleLabel = (vtkFlagpoleLabel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFlagpoleLabel.Register(null);
				}
			}
			return vtkFlagpoleLabel;
		}

		// Token: 0x06014B0C RID: 84748
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlagpoleLabel_SetBasePosition_28(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the world coordinate position of the base
		/// </summary>
		// Token: 0x06014B0D RID: 84749 RVA: 0x001D4A23 File Offset: 0x001D2C23
		public void SetBasePosition(double x, double y, double z)
		{
			vtkFlagpoleLabel.vtkFlagpoleLabel_SetBasePosition_28(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06014B0E RID: 84750
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlagpoleLabel_SetFlagSize_29(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the size of the flag. 1.0 is the default size
		/// which corresponds to a preset texels/window value. Adjust this
		/// to increase or decrease the default size.
		/// </summary>
		// Token: 0x06014B0F RID: 84751 RVA: 0x001D4A35 File Offset: 0x001D2C35
		public virtual void SetFlagSize(double _arg)
		{
			vtkFlagpoleLabel.vtkFlagpoleLabel_SetFlagSize_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06014B10 RID: 84752
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlagpoleLabel_SetForceOpaque_30(HandleRef pThis, byte opaque);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x06014B11 RID: 84753 RVA: 0x001D4A45 File Offset: 0x001D2C45
		public override void SetForceOpaque(bool opaque)
		{
			vtkFlagpoleLabel.vtkFlagpoleLabel_SetForceOpaque_30(base.GetCppThis(), opaque ? (byte)1 : (byte)0);
		}

		// Token: 0x06014B12 RID: 84754
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlagpoleLabel_SetForceTranslucent_31(HandleRef pThis, byte trans);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x06014B13 RID: 84755 RVA: 0x001D4A5D File Offset: 0x001D2C5D
		public override void SetForceTranslucent(bool trans)
		{
			vtkFlagpoleLabel.vtkFlagpoleLabel_SetForceTranslucent_31(base.GetCppThis(), trans ? (byte)1 : (byte)0);
		}

		// Token: 0x06014B14 RID: 84756
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlagpoleLabel_SetInput_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// The UTF-8 encoded string to display.
		/// @{
		/// </summary>
		// Token: 0x06014B15 RID: 84757 RVA: 0x001D4A75 File Offset: 0x001D2C75
		public void SetInput(string arg0)
		{
			vtkFlagpoleLabel.vtkFlagpoleLabel_SetInput_32(base.GetCppThis(), arg0);
		}

		// Token: 0x06014B16 RID: 84758
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlagpoleLabel_SetTextProperty_33(HandleRef pThis, HandleRef tprop);

		/// <summary>
		/// The vtkTextProperty object that controls the rendered text.
		/// @{
		/// </summary>
		// Token: 0x06014B17 RID: 84759 RVA: 0x001D4A88 File Offset: 0x001D2C88
		public void SetTextProperty(vtkTextProperty tprop)
		{
			vtkFlagpoleLabel.vtkFlagpoleLabel_SetTextProperty_33(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		// Token: 0x06014B18 RID: 84760
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlagpoleLabel_SetTopPosition_34(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the world coordinate position of the top
		/// </summary>
		// Token: 0x06014B19 RID: 84761 RVA: 0x001D4AB7 File Offset: 0x001D2CB7
		public void SetTopPosition(double x, double y, double z)
		{
			vtkFlagpoleLabel.vtkFlagpoleLabel_SetTopPosition_34(base.GetCppThis(), x, y, z);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017E9 RID: 6121
		public new const string MRFullTypeName = "Kitware.VTK.vtkFlagpoleLabel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017EA RID: 6122
		public new static readonly string MRClassNameKey = "class vtkFlagpoleLabel";
	}
}
