using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAxis
	/// </summary>
	/// <remarks>
	///    takes care of drawing 2D axes
	///
	///
	/// The vtkAxis is drawn in screen coordinates. It is usually one of the last
	/// elements of a chart to be drawn. It renders the axis label, tick marks and
	/// tick labels.
	/// The tick marks and labels span the range of values between
	/// \a Minimum and \a Maximum.
	/// The \a Minimum and \a Maximum values are not allowed to extend beyond the
	/// \a MinimumLimit and \a MaximumLimit values, respectively.
	///
	/// Note that many other chart elements (e.g., vtkPlotPoints) refer to
	/// vtkAxis instances to determine how to scale raw data for presentation.
	/// In particular, care must be taken with logarithmic scaling.
	/// The axis Minimum, Maximum, and Limit values are stored both unscaled
	/// and scaled (with log(x) applied when GetLogScaleActive() returns true).
	/// User interfaces will most likely present the unscaled values as they
	/// represent the values provided by the user.
	/// Other chart elements may need the scaled values in order to draw
	/// in the same coordinate system.
	///
	/// Just because LogScale is set to true does not guarantee that the axis
	/// will use logarithmic scaling -- the Minimum and Maximum values for the
	/// axis must both lie to the same side of origin (and not include the origin).
	/// Also, this switch from linear- to log-scaling may occur during a rendering
	/// pass if autoscaling is enabled.
	/// Because the log and pow functions are not invertible and the axis itself
	/// decides when to switch between them without offering any external class
	/// managing the axis a chance to save the old values, it saves
	/// old Limit values in NonLogUnscaled{Min,Max}Limit so that behavior is
	/// consistent when LogScale is changed from false to true and back again.
	/// </remarks>
	// Token: 0x0200062B RID: 1579
	public class vtkAxis : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011174 RID: 70004 RVA: 0x0017D273 File Offset: 0x0017B473
		static vtkAxis()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAxis.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxis"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011175 RID: 70005 RVA: 0x0017D29B File Offset: 0x0017B49B
		public vtkAxis(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011176 RID: 70006
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxis_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x06011177 RID: 70007 RVA: 0x0017D2AC File Offset: 0x0017B4AC
		public new static vtkAxis New()
		{
			vtkAxis result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxis.vtkAxis_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxis)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x06011178 RID: 70008 RVA: 0x0017D300 File Offset: 0x0017B500
		public vtkAxis() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAxis.vtkAxis_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011179 RID: 70009 RVA: 0x0017D344 File Offset: 0x0017B544
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601117A RID: 70010
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_AutoScale_01(HandleRef pThis);

		/// <summary>
		/// Use this function to autoscale the axes after setting the minimum and
		/// maximum values. This will cause the axes to select the nicest numbers
		/// that enclose the minimum and maximum values, and to select an appropriate
		/// number of tick marks.
		/// </summary>
		// Token: 0x0601117B RID: 70011 RVA: 0x0017D34F File Offset: 0x0017B54F
		public virtual void AutoScale()
		{
			vtkAxis.vtkAxis_AutoScale_01(base.GetCppThis());
		}

		// Token: 0x0601117C RID: 70012
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkAxis_GenerateSimpleLabel_02(HandleRef pThis, double val);

		/// <summary>
		/// Generate a single label using the current settings when TickLabelAlgorithm
		/// is TICK_SIMPLE.
		/// </summary>
		// Token: 0x0601117D RID: 70013 RVA: 0x0017D360 File Offset: 0x0017B560
		public virtual string GenerateSimpleLabel(double val)
		{
			return vtkAxis.vtkAxis_GenerateSimpleLabel_02(base.GetCppThis(), val);
		}

		// Token: 0x0601117E RID: 70014
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxis_GetAxisVisible_03(HandleRef pThis);

		/// <summary>
		/// Get/set whether the axis line should be visible.
		/// </summary>
		// Token: 0x0601117F RID: 70015 RVA: 0x0017D380 File Offset: 0x0017B580
		public virtual bool GetAxisVisible()
		{
			return vtkAxis.vtkAxis_GetAxisVisible_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06011180 RID: 70016
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxis_GetBehavior_04(HandleRef pThis);

		/// <summary>
		/// Get/set the behavior of the axis (auto or fixed). The default is 0 (auto).
		/// </summary>
		// Token: 0x06011181 RID: 70017 RVA: 0x0017D3A8 File Offset: 0x0017B5A8
		public virtual int GetBehavior()
		{
			return vtkAxis.vtkAxis_GetBehavior_04(base.GetCppThis());
		}

		// Token: 0x06011182 RID: 70018
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxis_GetBoundingRect_05(HandleRef pThis, HandleRef painter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Request the space the axes require to be drawn. This is returned as a
		/// vtkRectf, with the corner being the offset from Point1, and the width/
		/// height being the total width/height required by the axis. In order to
		/// ensure the numbers are correct, Update() should be called on the axis.
		/// </summary>
		// Token: 0x06011183 RID: 70019 RVA: 0x0017D3C8 File Offset: 0x0017B5C8
		public vtkRectf GetBoundingRect(vtkContext2D painter)
		{
			vtkRectf result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxis.vtkAxis_GetBoundingRect_05(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectf)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011184 RID: 70020
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxis_GetGridPen_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the vtkPen object that controls the way this axis is drawn.
		/// </summary>
		// Token: 0x06011185 RID: 70021 RVA: 0x0017D438 File Offset: 0x0017B638
		public virtual vtkPen GetGridPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxis.vtkAxis_GetGridPen_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPen = (vtkPen)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPen.Register(null);
				}
			}
			return vtkPen;
		}

		// Token: 0x06011186 RID: 70022
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxis_GetGridVisible_07(HandleRef pThis);

		/// <summary>
		/// Get/set whether the axis grid lines should be drawn, default is true.
		/// </summary>
		// Token: 0x06011187 RID: 70023 RVA: 0x0017D4A8 File Offset: 0x0017B6A8
		public virtual bool GetGridVisible()
		{
			return vtkAxis.vtkAxis_GetGridVisible_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06011188 RID: 70024
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkAxis_GetLabelFormat_08(HandleRef pThis);

		/// <summary>
		/// Get/Set the printf-style format string used when TickLabelAlgorithm is
		/// TICK_SIMPLE and Notation is PRINTF_NOTATION. The default is "%g".
		/// </summary>
		// Token: 0x06011189 RID: 70025 RVA: 0x0017D4D0 File Offset: 0x0017B6D0
		public virtual string GetLabelFormat()
		{
			return vtkAxis.vtkAxis_GetLabelFormat_08(base.GetCppThis());
		}

		// Token: 0x0601118A RID: 70026
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkAxis_GetLabelOffset_09(HandleRef pThis);

		/// <summary>
		/// Get/set the offset (in pixels) of the label text position from the axis
		/// </summary>
		// Token: 0x0601118B RID: 70027 RVA: 0x0017D4F0 File Offset: 0x0017B6F0
		public virtual float GetLabelOffset()
		{
			return vtkAxis.vtkAxis_GetLabelOffset_09(base.GetCppThis());
		}

		// Token: 0x0601118C RID: 70028
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxis_GetLabelProperties_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkTextProperty that governs how the axis labels are displayed.
		/// Note that the alignment properties are not used.
		/// </summary>
		// Token: 0x0601118D RID: 70029 RVA: 0x0017D510 File Offset: 0x0017B710
		public virtual vtkTextProperty GetLabelProperties()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxis.vtkAxis_GetLabelProperties_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601118E RID: 70030
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxis_GetLabelsVisible_11(HandleRef pThis);

		/// <summary>
		/// Get/set whether the axis labels should be visible.
		/// </summary>
		// Token: 0x0601118F RID: 70031 RVA: 0x0017D580 File Offset: 0x0017B780
		public virtual bool GetLabelsVisible()
		{
			return vtkAxis.vtkAxis_GetLabelsVisible_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06011190 RID: 70032
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxis_GetLogScale_12(HandleRef pThis);

		/// <summary>
		/// Get/set whether the axis should &lt;b&gt;attempt&lt;/b&gt; to use a log scale.
		///
		/// The default is false.
		/// \sa{LogScaleActive}.
		/// </summary>
		// Token: 0x06011191 RID: 70033 RVA: 0x0017D5A8 File Offset: 0x0017B7A8
		public virtual bool GetLogScale()
		{
			return vtkAxis.vtkAxis_GetLogScale_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06011192 RID: 70034
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxis_GetLogScaleActive_13(HandleRef pThis);

		/// <summary>
		/// Get whether the axis is using a log scale.
		/// This will always be false when LogScale is false.
		/// It is only true when LogScale is true &lt;b&gt;and&lt;/b&gt; the \a UnscaledRange
		/// does not cross or include the origin (zero).
		///
		/// The limits (\a MinimumLimit, \a MaximumLimit, and their
		/// unscaled counterparts) do not prevent LogScaleActive from becoming
		/// true; they are adjusted if they cross or include the origin
		/// and the original limits are preserved for when LogScaleActive
		/// becomes false again.
		/// </summary>
		// Token: 0x06011193 RID: 70035 RVA: 0x0017D5D0 File Offset: 0x0017B7D0
		public virtual bool GetLogScaleActive()
		{
			return vtkAxis.vtkAxis_GetLogScaleActive_13(base.GetCppThis()) != 0;
		}

		// Token: 0x06011194 RID: 70036
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxis_GetMargins_14(HandleRef pThis);

		/// <summary>
		/// Get the margins of the axis, in pixels.
		/// </summary>
		// Token: 0x06011195 RID: 70037 RVA: 0x0017D5F8 File Offset: 0x0017B7F8
		public virtual int[] GetMargins()
		{
			IntPtr intPtr = vtkAxis.vtkAxis_GetMargins_14(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06011196 RID: 70038
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_GetMargins_15(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get the margins of the axis, in pixels.
		/// </summary>
		// Token: 0x06011197 RID: 70039 RVA: 0x0017D640 File Offset: 0x0017B840
		public virtual void GetMargins(ref int _arg1, ref int _arg2)
		{
			vtkAxis.vtkAxis_GetMargins_15(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06011198 RID: 70040
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_GetMargins_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the margins of the axis, in pixels.
		/// </summary>
		// Token: 0x06011199 RID: 70041 RVA: 0x0017D651 File Offset: 0x0017B851
		public virtual void GetMargins(IntPtr _arg)
		{
			vtkAxis.vtkAxis_GetMargins_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0601119A RID: 70042
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxis_GetMaximum_17(HandleRef pThis);

		/// <summary>
		/// Get the logical maximum value of the axis, in plot coordinates.
		/// If LogScaleActive is true (not just LogScale), then this
		/// returns the maximum base-10 &lt;b&gt;exponent&lt;/b&gt;.
		/// </summary>
		// Token: 0x0601119B RID: 70043 RVA: 0x0017D664 File Offset: 0x0017B864
		public virtual double GetMaximum()
		{
			return vtkAxis.vtkAxis_GetMaximum_17(base.GetCppThis());
		}

		// Token: 0x0601119C RID: 70044
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxis_GetMaximumLimit_18(HandleRef pThis);

		/// <summary>
		/// Get the logical highest possible value for \a Maximum, in plot coordinates.
		/// </summary>
		// Token: 0x0601119D RID: 70045 RVA: 0x0017D684 File Offset: 0x0017B884
		public virtual double GetMaximumLimit()
		{
			return vtkAxis.vtkAxis_GetMaximumLimit_18(base.GetCppThis());
		}

		// Token: 0x0601119E RID: 70046
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxis_GetMinimum_19(HandleRef pThis);

		/// <summary>
		/// Get the logical minimum value of the axis, in plot coordinates.
		/// If LogScaleActive is true (not just LogScale), then this
		/// returns the minimum base-10 &lt;b&gt;exponent&lt;/b&gt;.
		/// </summary>
		// Token: 0x0601119F RID: 70047 RVA: 0x0017D6A4 File Offset: 0x0017B8A4
		public virtual double GetMinimum()
		{
			return vtkAxis.vtkAxis_GetMinimum_19(base.GetCppThis());
		}

		// Token: 0x060111A0 RID: 70048
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxis_GetMinimumLimit_20(HandleRef pThis);

		/// <summary>
		/// Get the logical lowest possible value for \a Minimum, in plot coordinates.
		/// </summary>
		// Token: 0x060111A1 RID: 70049 RVA: 0x0017D6C4 File Offset: 0x0017B8C4
		public virtual double GetMinimumLimit()
		{
			return vtkAxis.vtkAxis_GetMinimumLimit_20(base.GetCppThis());
		}

		// Token: 0x060111A2 RID: 70050
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxis_GetNotation_21(HandleRef pThis);

		/// <summary>
		/// Get/set the numerical notation, standard, scientific, fixed, or a
		/// printf-style format string.
		/// \sa SetPrecision SetLabelFormat
		/// </summary>
		// Token: 0x060111A3 RID: 70051 RVA: 0x0017D6E4 File Offset: 0x0017B8E4
		public virtual int GetNotation()
		{
			return vtkAxis.vtkAxis_GetNotation_21(base.GetCppThis());
		}

		// Token: 0x060111A4 RID: 70052
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxis_GetNumberOfGenerationsFromBase_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060111A5 RID: 70053 RVA: 0x0017D704 File Offset: 0x0017B904
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAxis.vtkAxis_GetNumberOfGenerationsFromBase_22(base.GetCppThis(), type);
		}

		// Token: 0x060111A6 RID: 70054
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxis_GetNumberOfGenerationsFromBaseType_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060111A7 RID: 70055 RVA: 0x0017D724 File Offset: 0x0017B924
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAxis.vtkAxis_GetNumberOfGenerationsFromBaseType_23(type);
		}

		// Token: 0x060111A8 RID: 70056
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxis_GetNumberOfTicks_24(HandleRef pThis);

		/// <summary>
		/// Get the number of tick marks for this axis.
		/// </summary>
		// Token: 0x060111A9 RID: 70057 RVA: 0x0017D740 File Offset: 0x0017B940
		public virtual int GetNumberOfTicks()
		{
			return vtkAxis.vtkAxis_GetNumberOfTicks_24(base.GetCppThis());
		}

		// Token: 0x060111AA RID: 70058
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxis_GetPen_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the vtkPen object that controls the way this axis is drawn.
		/// </summary>
		// Token: 0x060111AB RID: 70059 RVA: 0x0017D760 File Offset: 0x0017B960
		public virtual vtkPen GetPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxis.vtkAxis_GetPen_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPen = (vtkPen)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPen.Register(null);
				}
			}
			return vtkPen;
		}

		// Token: 0x060111AC RID: 70060
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxis_GetPoint1_26(HandleRef pThis);

		/// <summary>
		/// Get point 1 of the axis (in pixels), this is usually the origin.
		/// </summary>
		// Token: 0x060111AD RID: 70061 RVA: 0x0017D7D0 File Offset: 0x0017B9D0
		public virtual float[] GetPoint1()
		{
			IntPtr intPtr = vtkAxis.vtkAxis_GetPoint1_26(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060111AE RID: 70062
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_GetPoint1_27(HandleRef pThis, ref float _arg1, ref float _arg2);

		/// <summary>
		/// Get point 1 of the axis (in pixels), this is usually the origin.
		/// </summary>
		// Token: 0x060111AF RID: 70063 RVA: 0x0017D818 File Offset: 0x0017BA18
		public virtual void GetPoint1(ref float _arg1, ref float _arg2)
		{
			vtkAxis.vtkAxis_GetPoint1_27(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060111B0 RID: 70064
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_GetPoint1_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get point 1 of the axis (in pixels), this is usually the origin.
		/// </summary>
		// Token: 0x060111B1 RID: 70065 RVA: 0x0017D829 File Offset: 0x0017BA29
		public virtual void GetPoint1(IntPtr _arg)
		{
			vtkAxis.vtkAxis_GetPoint1_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060111B2 RID: 70066
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxis_GetPoint2_29(HandleRef pThis);

		/// <summary>
		/// Get point 2 of the axis (in pixels), this is usually the terminus.
		/// </summary>
		// Token: 0x060111B3 RID: 70067 RVA: 0x0017D83C File Offset: 0x0017BA3C
		public virtual float[] GetPoint2()
		{
			IntPtr intPtr = vtkAxis.vtkAxis_GetPoint2_29(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060111B4 RID: 70068
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_GetPoint2_30(HandleRef pThis, ref float _arg1, ref float _arg2);

		/// <summary>
		/// Get point 2 of the axis (in pixels), this is usually the terminus.
		/// </summary>
		// Token: 0x060111B5 RID: 70069 RVA: 0x0017D884 File Offset: 0x0017BA84
		public virtual void GetPoint2(ref float _arg1, ref float _arg2)
		{
			vtkAxis.vtkAxis_GetPoint2_30(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060111B6 RID: 70070
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_GetPoint2_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get point 2 of the axis (in pixels), this is usually the terminus.
		/// </summary>
		// Token: 0x060111B7 RID: 70071 RVA: 0x0017D895 File Offset: 0x0017BA95
		public virtual void GetPoint2(IntPtr _arg)
		{
			vtkAxis.vtkAxis_GetPoint2_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060111B8 RID: 70072
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxis_GetPosition_32(HandleRef pThis);

		/// <summary>
		/// Get/set the position of the axis (LEFT, BOTTOM, RIGHT, TOP, PARALLEL).
		/// </summary>
		// Token: 0x060111B9 RID: 70073 RVA: 0x0017D8A8 File Offset: 0x0017BAA8
		public virtual int GetPosition()
		{
			return vtkAxis.vtkAxis_GetPosition_32(base.GetCppThis());
		}

		// Token: 0x060111BA RID: 70074
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxis_GetPosition1_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get point 1 of the axis (in pixels), this is usually the origin.
		/// </summary>
		// Token: 0x060111BB RID: 70075 RVA: 0x0017D8C8 File Offset: 0x0017BAC8
		public vtkVector2f GetPosition1()
		{
			vtkVector2f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxis.vtkAxis_GetPosition1_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060111BC RID: 70076
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxis_GetPosition2_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get point 2 of the axis (in pixels), this is usually the terminus.
		/// </summary>
		// Token: 0x060111BD RID: 70077 RVA: 0x0017D924 File Offset: 0x0017BB24
		public vtkVector2f GetPosition2()
		{
			vtkVector2f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxis.vtkAxis_GetPosition2_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060111BE RID: 70078
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxis_GetPrecision_35(HandleRef pThis);

		/// <summary>
		/// Get/set the numerical precision to use, default is 2. This is ignored
		/// when Notation is STANDARD_NOTATION or PRINTF_NOTATION.
		/// </summary>
		// Token: 0x060111BF RID: 70079 RVA: 0x0017D980 File Offset: 0x0017BB80
		public virtual int GetPrecision()
		{
			return vtkAxis.vtkAxis_GetPrecision_35(base.GetCppThis());
		}

		// Token: 0x060111C0 RID: 70080
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_GetRange_36(HandleRef pThis, IntPtr range);

		/// <summary>
		/// Get the logical range of the axis, in plot coordinates.
		///
		/// The unscaled range will always be in the same coordinate system of
		/// the data being plotted, regardless of whether LogScale is true or false.
		/// Calling GetRange() when LogScale is true will return the log10({min, max}).
		/// </summary>
		// Token: 0x060111C1 RID: 70081 RVA: 0x0017D99F File Offset: 0x0017BB9F
		public virtual void GetRange(IntPtr range)
		{
			vtkAxis.vtkAxis_GetRange_36(base.GetCppThis(), range);
		}

		// Token: 0x060111C2 RID: 70082
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkAxis_GetRangeLabelFormat_37(HandleRef pThis);

		/// <summary>
		/// Get/Set the printf-style format string used for range labels.
		/// This format is always used regardless of TickLabelAlgorithm and
		/// Notation. Default is "%g".
		/// </summary>
		// Token: 0x060111C3 RID: 70083 RVA: 0x0017D9B0 File Offset: 0x0017BBB0
		public virtual string GetRangeLabelFormat()
		{
			return vtkAxis.vtkAxis_GetRangeLabelFormat_37(base.GetCppThis());
		}

		// Token: 0x060111C4 RID: 70084
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxis_GetRangeLabelsVisible_38(HandleRef pThis);

		/// <summary>
		/// Get/set whether the labels for the range should be visible.
		/// </summary>
		// Token: 0x060111C5 RID: 70085 RVA: 0x0017D9D0 File Offset: 0x0017BBD0
		public virtual bool GetRangeLabelsVisible()
		{
			return vtkAxis.vtkAxis_GetRangeLabelsVisible_38(base.GetCppThis()) != 0;
		}

		// Token: 0x060111C6 RID: 70086
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxis_GetScalingFactor_39(HandleRef pThis);

		/// <summary>
		/// Get/set the scaling factor used for the axis, this defaults to 1.0 (no
		/// scaling), and is used to coordinate scaling with the plots, charts, etc.
		/// </summary>
		// Token: 0x060111C7 RID: 70087 RVA: 0x0017D9F8 File Offset: 0x0017BBF8
		public virtual double GetScalingFactor()
		{
			return vtkAxis.vtkAxis_GetScalingFactor_39(base.GetCppThis());
		}

		// Token: 0x060111C8 RID: 70088
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxis_GetShift_40(HandleRef pThis);

		/// <summary>
		/// Get/set the scaling factor used for the axis, this defaults to 1.0 (no
		/// scaling), and is used to coordinate scaling with the plots, charts, etc.
		/// </summary>
		// Token: 0x060111C9 RID: 70089 RVA: 0x0017DA18 File Offset: 0x0017BC18
		public virtual double GetShift()
		{
			return vtkAxis.vtkAxis_GetShift_40(base.GetCppThis());
		}

		// Token: 0x060111CA RID: 70090
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxis_GetTickLabelAlgorithm_41(HandleRef pThis);

		/// <summary>
		/// Get/set the tick label algorithm that is used to calculate the min, max
		/// and tick spacing. There are currently two algorithms, vtkAxis::TICK_SIMPLE
		/// is the default and uses a simple algorithm. The second option is
		/// vtkAxis::TICK_WILKINSON which uses an extended Wilkinson algorithm to find
		/// the optimal range, spacing and font parameters.
		/// </summary>
		// Token: 0x060111CB RID: 70091 RVA: 0x0017DA38 File Offset: 0x0017BC38
		public virtual int GetTickLabelAlgorithm()
		{
			return vtkAxis.vtkAxis_GetTickLabelAlgorithm_41(base.GetCppThis());
		}

		// Token: 0x060111CC RID: 70092
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxis_GetTickLabels_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A string array containing the tick labels for the axis.
		/// </summary>
		// Token: 0x060111CD RID: 70093 RVA: 0x0017DA58 File Offset: 0x0017BC58
		public virtual vtkStringArray GetTickLabels()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxis.vtkAxis_GetTickLabels_42(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x060111CE RID: 70094
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkAxis_GetTickLength_43(HandleRef pThis);

		/// <summary>
		/// Get/set the length of tick marks (in pixels).
		/// </summary>
		// Token: 0x060111CF RID: 70095 RVA: 0x0017DAC8 File Offset: 0x0017BCC8
		public virtual float GetTickLength()
		{
			return vtkAxis.vtkAxis_GetTickLength_43(base.GetCppThis());
		}

		// Token: 0x060111D0 RID: 70096
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxis_GetTickPositions_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// An array with the positions of the tick marks along the axis line.
		/// The positions are specified in the plot coordinates of the axis.
		/// </summary>
		// Token: 0x060111D1 RID: 70097 RVA: 0x0017DAE8 File Offset: 0x0017BCE8
		public virtual vtkDoubleArray GetTickPositions()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxis.vtkAxis_GetTickPositions_44(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x060111D2 RID: 70098
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxis_GetTickScenePositions_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// An array with the positions of the tick marks along the axis line.
		/// The positions are specified in scene coordinates.
		/// </summary>
		// Token: 0x060111D3 RID: 70099 RVA: 0x0017DB58 File Offset: 0x0017BD58
		public virtual vtkFloatArray GetTickScenePositions()
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxis.vtkAxis_GetTickScenePositions_45(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		// Token: 0x060111D4 RID: 70100
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxis_GetTicksVisible_46(HandleRef pThis);

		/// <summary>
		/// Get/set whether the tick marks should be visible.
		/// </summary>
		// Token: 0x060111D5 RID: 70101 RVA: 0x0017DBC8 File Offset: 0x0017BDC8
		public virtual bool GetTicksVisible()
		{
			return vtkAxis.vtkAxis_GetTicksVisible_46(base.GetCppThis()) != 0;
		}

		// Token: 0x060111D6 RID: 70102
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkAxis_GetTitle_47(HandleRef pThis);

		/// <summary>
		/// Get/set the title text of the axis.
		/// </summary>
		// Token: 0x060111D7 RID: 70103 RVA: 0x0017DBF0 File Offset: 0x0017BDF0
		public virtual string GetTitle()
		{
			return vtkAxis.vtkAxis_GetTitle_47(base.GetCppThis());
		}

		// Token: 0x060111D8 RID: 70104
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxis_GetTitleProperties_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkTextProperty that governs how the axis title is displayed.
		/// </summary>
		// Token: 0x060111D9 RID: 70105 RVA: 0x0017DC10 File Offset: 0x0017BE10
		public virtual vtkTextProperty GetTitleProperties()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxis.vtkAxis_GetTitleProperties_48(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060111DA RID: 70106
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxis_GetTitleVisible_49(HandleRef pThis);

		/// <summary>
		/// Get/set whether the axis title should be visible.
		/// </summary>
		// Token: 0x060111DB RID: 70107 RVA: 0x0017DC80 File Offset: 0x0017BE80
		public virtual bool GetTitleVisible()
		{
			return vtkAxis.vtkAxis_GetTitleVisible_49(base.GetCppThis()) != 0;
		}

		// Token: 0x060111DC RID: 70108
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxis_GetUnscaledMaximum_50(HandleRef pThis);

		/// <summary>
		/// Get the logical maximum value of the axis, in plot coordinates.
		/// </summary>
		// Token: 0x060111DD RID: 70109 RVA: 0x0017DCA8 File Offset: 0x0017BEA8
		public virtual double GetUnscaledMaximum()
		{
			return vtkAxis.vtkAxis_GetUnscaledMaximum_50(base.GetCppThis());
		}

		// Token: 0x060111DE RID: 70110
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxis_GetUnscaledMaximumLimit_51(HandleRef pThis);

		/// <summary>
		/// Get the logical highest possible value for \a Maximum, in plot coordinates.
		/// </summary>
		// Token: 0x060111DF RID: 70111 RVA: 0x0017DCC8 File Offset: 0x0017BEC8
		public virtual double GetUnscaledMaximumLimit()
		{
			return vtkAxis.vtkAxis_GetUnscaledMaximumLimit_51(base.GetCppThis());
		}

		// Token: 0x060111E0 RID: 70112
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxis_GetUnscaledMinimum_52(HandleRef pThis);

		/// <summary>
		/// Get the logical minimum value of the axis, in plot coordinates.
		/// </summary>
		// Token: 0x060111E1 RID: 70113 RVA: 0x0017DCE8 File Offset: 0x0017BEE8
		public virtual double GetUnscaledMinimum()
		{
			return vtkAxis.vtkAxis_GetUnscaledMinimum_52(base.GetCppThis());
		}

		// Token: 0x060111E2 RID: 70114
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxis_GetUnscaledMinimumLimit_53(HandleRef pThis);

		/// <summary>
		/// Get the logical lowest possible value for \a Minimum, in plot coordinates.
		/// </summary>
		// Token: 0x060111E3 RID: 70115 RVA: 0x0017DD08 File Offset: 0x0017BF08
		public virtual double GetUnscaledMinimumLimit()
		{
			return vtkAxis.vtkAxis_GetUnscaledMinimumLimit_53(base.GetCppThis());
		}

		// Token: 0x060111E4 RID: 70116
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_GetUnscaledRange_54(HandleRef pThis, IntPtr range);

		/// <summary>
		/// Get the logical range of the axis, in plot coordinates.
		///
		/// The unscaled range will always be in the same coordinate system of
		/// the data being plotted, regardless of whether LogScale is true or false.
		/// Calling GetRange() when LogScale is true will return the log10({min, max}).
		/// </summary>
		// Token: 0x060111E5 RID: 70117 RVA: 0x0017DD27 File Offset: 0x0017BF27
		public virtual void GetUnscaledRange(IntPtr range)
		{
			vtkAxis.vtkAxis_GetUnscaledRange_54(base.GetCppThis(), range);
		}

		// Token: 0x060111E6 RID: 70118
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxis_IsA_55(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060111E7 RID: 70119 RVA: 0x0017DD38 File Offset: 0x0017BF38
		public override int IsA(string type)
		{
			return vtkAxis.vtkAxis_IsA_55(base.GetCppThis(), type);
		}

		// Token: 0x060111E8 RID: 70120
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxis_IsTypeOf_56([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060111E9 RID: 70121 RVA: 0x0017DD58 File Offset: 0x0017BF58
		public new static int IsTypeOf(string type)
		{
			return vtkAxis.vtkAxis_IsTypeOf_56(type);
		}

		// Token: 0x060111EA RID: 70122
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_LogScaleOff_57(HandleRef pThis);

		/// <summary>
		/// Get/set whether the axis should &lt;b&gt;attempt&lt;/b&gt; to use a log scale.
		///
		/// The default is false.
		/// \sa{LogScaleActive}.
		/// </summary>
		// Token: 0x060111EB RID: 70123 RVA: 0x0017DD72 File Offset: 0x0017BF72
		public virtual void LogScaleOff()
		{
			vtkAxis.vtkAxis_LogScaleOff_57(base.GetCppThis());
		}

		// Token: 0x060111EC RID: 70124
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_LogScaleOn_58(HandleRef pThis);

		/// <summary>
		/// Get/set whether the axis should &lt;b&gt;attempt&lt;/b&gt; to use a log scale.
		///
		/// The default is false.
		/// \sa{LogScaleActive}.
		/// </summary>
		// Token: 0x060111ED RID: 70125 RVA: 0x0017DD81 File Offset: 0x0017BF81
		public virtual void LogScaleOn()
		{
			vtkAxis.vtkAxis_LogScaleOn_58(base.GetCppThis());
		}

		// Token: 0x060111EE RID: 70126
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxis_NewInstance_60(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060111EF RID: 70127 RVA: 0x0017DD90 File Offset: 0x0017BF90
		public new vtkAxis NewInstance()
		{
			vtkAxis result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxis.vtkAxis_NewInstance_60(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxis)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060111F0 RID: 70128
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxis_NiceMinMax_61(ref double min, ref double max, float pixelRange, float tickPixelSpacing);

		/// <summary>
		/// Static function to calculate "nice" minimum, maximum, and tick spacing
		/// values.
		/// </summary>
		// Token: 0x060111F1 RID: 70129 RVA: 0x0017DDEC File Offset: 0x0017BFEC
		public static double NiceMinMax(ref double min, ref double max, float pixelRange, float tickPixelSpacing)
		{
			return vtkAxis.vtkAxis_NiceMinMax_61(ref min, ref max, pixelRange, tickPixelSpacing);
		}

		// Token: 0x060111F2 RID: 70130
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxis_NiceNumber_62(double number, byte roundUp);

		/// <summary>
		/// Return a "nice number", often defined as 1, 2 or 5. If roundUp is true then
		/// the nice number will be rounded up, false it is rounded down. The supplied
		/// number should be between 0.0 and 9.9.
		/// </summary>
		// Token: 0x060111F3 RID: 70131 RVA: 0x0017DE0C File Offset: 0x0017C00C
		public static double NiceNumber(double number, bool roundUp)
		{
			return vtkAxis.vtkAxis_NiceNumber_62(number, roundUp ? (byte)1 : (byte)0);
		}

		// Token: 0x060111F4 RID: 70132
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxis_Paint_63(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the axis, called whenever the axis needs to be drawn.
		/// </summary>
		// Token: 0x060111F5 RID: 70133 RVA: 0x0017DE30 File Offset: 0x0017C030
		public override bool Paint(vtkContext2D painter)
		{
			return vtkAxis.vtkAxis_Paint_63(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060111F6 RID: 70134
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_RecalculateTickSpacing_64(HandleRef pThis);

		/// <summary>
		/// Recalculate the spacing of the tick marks - typically useful to do after
		/// scaling the axis.
		/// </summary>
		// Token: 0x060111F7 RID: 70135 RVA: 0x0017DE6B File Offset: 0x0017C06B
		public virtual void RecalculateTickSpacing()
		{
			vtkAxis.vtkAxis_RecalculateTickSpacing_64(base.GetCppThis());
		}

		// Token: 0x060111F8 RID: 70136
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxis_SafeDownCast_65(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060111F9 RID: 70137 RVA: 0x0017DE7C File Offset: 0x0017C07C
		public new static vtkAxis SafeDownCast(vtkObjectBase o)
		{
			vtkAxis vtkAxis = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxis.vtkAxis_SafeDownCast_65((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxis = (vtkAxis)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxis.Register(null);
				}
			}
			return vtkAxis;
		}

		// Token: 0x060111FA RID: 70138
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetAxisVisible_66(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/set whether the axis line should be visible.
		/// </summary>
		// Token: 0x060111FB RID: 70139 RVA: 0x0017DEFB File Offset: 0x0017C0FB
		public virtual void SetAxisVisible(bool _arg)
		{
			vtkAxis.vtkAxis_SetAxisVisible_66(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060111FC RID: 70140
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetBehavior_67(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/set the behavior of the axis (auto or fixed). The default is 0 (auto).
		/// </summary>
		// Token: 0x060111FD RID: 70141 RVA: 0x0017DF13 File Offset: 0x0017C113
		public virtual void SetBehavior(int _arg)
		{
			vtkAxis.vtkAxis_SetBehavior_67(base.GetCppThis(), _arg);
		}

		// Token: 0x060111FE RID: 70142
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAxis_SetCustomTickPositions_68(HandleRef pThis, HandleRef positions, HandleRef labels);

		/// <summary>
		/// Set the tick positions, and optionally custom tick labels. If the labels
		/// and positions are null then automatic tick labels will be assigned. If
		/// only positions are supplied then appropriate labels will be generated
		/// according to the axis settings. If positions and labels are supplied they
		/// must be of the same length. Returns true on success, false on failure.
		/// </summary>
		// Token: 0x060111FF RID: 70143 RVA: 0x0017DF24 File Offset: 0x0017C124
		public virtual bool SetCustomTickPositions(vtkDoubleArray positions, vtkStringArray labels)
		{
			return vtkAxis.vtkAxis_SetCustomTickPositions_68(base.GetCppThis(), (positions == null) ? default(HandleRef) : positions.GetCppThis(), (labels == null) ? default(HandleRef) : labels.GetCppThis()) != 0;
		}

		// Token: 0x06011200 RID: 70144
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetGridPen_69(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Set/get the vtkPen object that controls the way this axis is drawn.
		/// </summary>
		// Token: 0x06011201 RID: 70145 RVA: 0x0017DF74 File Offset: 0x0017C174
		public virtual void SetGridPen(vtkPen _arg)
		{
			vtkAxis.vtkAxis_SetGridPen_69(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x06011202 RID: 70146
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetGridVisible_70(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/set whether the axis grid lines should be drawn, default is true.
		/// </summary>
		// Token: 0x06011203 RID: 70147 RVA: 0x0017DFA3 File Offset: 0x0017C1A3
		public virtual void SetGridVisible(bool _arg)
		{
			vtkAxis.vtkAxis_SetGridVisible_70(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011204 RID: 70148
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetLabelFormat_71(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fmt);

		/// <summary>
		/// Get/Set the printf-style format string used when TickLabelAlgorithm is
		/// TICK_SIMPLE and Notation is PRINTF_NOTATION. The default is "%g".
		/// </summary>
		// Token: 0x06011205 RID: 70149 RVA: 0x0017DFBB File Offset: 0x0017C1BB
		public virtual void SetLabelFormat(string fmt)
		{
			vtkAxis.vtkAxis_SetLabelFormat_71(base.GetCppThis(), fmt);
		}

		// Token: 0x06011206 RID: 70150
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetLabelOffset_72(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/set the offset (in pixels) of the label text position from the axis
		/// </summary>
		// Token: 0x06011207 RID: 70151 RVA: 0x0017DFCB File Offset: 0x0017C1CB
		public virtual void SetLabelOffset(float _arg)
		{
			vtkAxis.vtkAxis_SetLabelOffset_72(base.GetCppThis(), _arg);
		}

		// Token: 0x06011208 RID: 70152
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetLabelsVisible_73(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/set whether the axis labels should be visible.
		/// </summary>
		// Token: 0x06011209 RID: 70153 RVA: 0x0017DFDB File Offset: 0x0017C1DB
		public virtual void SetLabelsVisible(bool _arg)
		{
			vtkAxis.vtkAxis_SetLabelsVisible_73(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601120A RID: 70154
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetLogScale_74(HandleRef pThis, byte logScale);

		/// <summary>
		/// Get/set whether the axis should &lt;b&gt;attempt&lt;/b&gt; to use a log scale.
		///
		/// The default is false.
		/// \sa{LogScaleActive}.
		/// </summary>
		// Token: 0x0601120B RID: 70155 RVA: 0x0017DFF3 File Offset: 0x0017C1F3
		public virtual void SetLogScale(bool logScale)
		{
			vtkAxis.vtkAxis_SetLogScale_74(base.GetCppThis(), logScale ? (byte)1 : (byte)0);
		}

		// Token: 0x0601120C RID: 70156
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetMargins_75(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set the margins of the axis, in pixels.
		/// </summary>
		// Token: 0x0601120D RID: 70157 RVA: 0x0017E00B File Offset: 0x0017C20B
		public virtual void SetMargins(int _arg1, int _arg2)
		{
			vtkAxis.vtkAxis_SetMargins_75(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0601120E RID: 70158
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetMargins_76(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the margins of the axis, in pixels.
		/// </summary>
		// Token: 0x0601120F RID: 70159 RVA: 0x0017E01C File Offset: 0x0017C21C
		public void SetMargins(IntPtr _arg)
		{
			vtkAxis.vtkAxis_SetMargins_76(base.GetCppThis(), _arg);
		}

		// Token: 0x06011210 RID: 70160
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetMaximum_77(HandleRef pThis, double maximum);

		/// <summary>
		/// Set the logical maximum value of the axis, in plot coordinates.
		/// If LogScaleActive is true (not just LogScale), then this
		/// sets the maximum base-10 &lt;b&gt;exponent&lt;/b&gt;.
		/// </summary>
		// Token: 0x06011211 RID: 70161 RVA: 0x0017E02C File Offset: 0x0017C22C
		public virtual void SetMaximum(double maximum)
		{
			vtkAxis.vtkAxis_SetMaximum_77(base.GetCppThis(), maximum);
		}

		// Token: 0x06011212 RID: 70162
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetMaximumLimit_78(HandleRef pThis, double highest);

		/// <summary>
		/// Set the logical highest possible value for \a Maximum, in plot coordinates.
		/// </summary>
		// Token: 0x06011213 RID: 70163 RVA: 0x0017E03C File Offset: 0x0017C23C
		public virtual void SetMaximumLimit(double highest)
		{
			vtkAxis.vtkAxis_SetMaximumLimit_78(base.GetCppThis(), highest);
		}

		// Token: 0x06011214 RID: 70164
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetMinimum_79(HandleRef pThis, double minimum);

		/// <summary>
		/// Set the logical minimum value of the axis, in plot coordinates.
		/// If LogScaleActive is true (not just LogScale), then this
		/// sets the minimum base-10 &lt;b&gt;exponent&lt;/b&gt;.
		/// </summary>
		// Token: 0x06011215 RID: 70165 RVA: 0x0017E04C File Offset: 0x0017C24C
		public virtual void SetMinimum(double minimum)
		{
			vtkAxis.vtkAxis_SetMinimum_79(base.GetCppThis(), minimum);
		}

		// Token: 0x06011216 RID: 70166
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetMinimumLimit_80(HandleRef pThis, double lowest);

		/// <summary>
		/// Set the logical lowest possible value for \a Minimum, in plot coordinates.
		/// </summary>
		// Token: 0x06011217 RID: 70167 RVA: 0x0017E05C File Offset: 0x0017C25C
		public virtual void SetMinimumLimit(double lowest)
		{
			vtkAxis.vtkAxis_SetMinimumLimit_80(base.GetCppThis(), lowest);
		}

		// Token: 0x06011218 RID: 70168
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetNotation_81(HandleRef pThis, int notation);

		/// <summary>
		/// Get/set the numerical notation, standard, scientific, fixed, or a
		/// printf-style format string.
		/// \sa SetPrecision SetLabelFormat
		/// </summary>
		// Token: 0x06011219 RID: 70169 RVA: 0x0017E06C File Offset: 0x0017C26C
		public virtual void SetNotation(int notation)
		{
			vtkAxis.vtkAxis_SetNotation_81(base.GetCppThis(), notation);
		}

		// Token: 0x0601121A RID: 70170
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetNumberOfTicks_82(HandleRef pThis, int numberOfTicks);

		/// <summary>
		/// Set the number of tick marks for this axis. Default is -1, which leads to
		/// automatic calculation of nicely spaced tick marks.
		/// </summary>
		// Token: 0x0601121B RID: 70171 RVA: 0x0017E07C File Offset: 0x0017C27C
		public virtual void SetNumberOfTicks(int numberOfTicks)
		{
			vtkAxis.vtkAxis_SetNumberOfTicks_82(base.GetCppThis(), numberOfTicks);
		}

		// Token: 0x0601121C RID: 70172
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetPen_83(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Set/get the vtkPen object that controls the way this axis is drawn.
		/// </summary>
		// Token: 0x0601121D RID: 70173 RVA: 0x0017E08C File Offset: 0x0017C28C
		public virtual void SetPen(vtkPen _arg)
		{
			vtkAxis.vtkAxis_SetPen_83(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x0601121E RID: 70174
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetPoint1_84(HandleRef pThis, HandleRef pos);

		/// <summary>
		/// Set point 1 of the axis (in pixels), this is usually the origin.
		/// </summary>
		// Token: 0x0601121F RID: 70175 RVA: 0x0017E0BC File Offset: 0x0017C2BC
		public void SetPoint1(vtkVector2f pos)
		{
			vtkAxis.vtkAxis_SetPoint1_84(base.GetCppThis(), (pos == null) ? default(HandleRef) : pos.GetCppThis());
		}

		// Token: 0x06011220 RID: 70176
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetPoint1_85(HandleRef pThis, float x, float y);

		/// <summary>
		/// Set point 1 of the axis (in pixels), this is usually the origin.
		/// </summary>
		// Token: 0x06011221 RID: 70177 RVA: 0x0017E0EB File Offset: 0x0017C2EB
		public void SetPoint1(float x, float y)
		{
			vtkAxis.vtkAxis_SetPoint1_85(base.GetCppThis(), x, y);
		}

		// Token: 0x06011222 RID: 70178
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetPoint2_86(HandleRef pThis, HandleRef pos);

		/// <summary>
		/// Set point 2 of the axis (in pixels), this is usually the terminus.
		/// </summary>
		// Token: 0x06011223 RID: 70179 RVA: 0x0017E0FC File Offset: 0x0017C2FC
		public void SetPoint2(vtkVector2f pos)
		{
			vtkAxis.vtkAxis_SetPoint2_86(base.GetCppThis(), (pos == null) ? default(HandleRef) : pos.GetCppThis());
		}

		// Token: 0x06011224 RID: 70180
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetPoint2_87(HandleRef pThis, float x, float y);

		/// <summary>
		/// Set point 2 of the axis (in pixels), this is usually the terminus.
		/// </summary>
		// Token: 0x06011225 RID: 70181 RVA: 0x0017E12B File Offset: 0x0017C32B
		public void SetPoint2(float x, float y)
		{
			vtkAxis.vtkAxis_SetPoint2_87(base.GetCppThis(), x, y);
		}

		// Token: 0x06011226 RID: 70182
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetPosition_88(HandleRef pThis, int position);

		/// <summary>
		/// Get/set the position of the axis (LEFT, BOTTOM, RIGHT, TOP, PARALLEL).
		/// </summary>
		// Token: 0x06011227 RID: 70183 RVA: 0x0017E13C File Offset: 0x0017C33C
		public virtual void SetPosition(int position)
		{
			vtkAxis.vtkAxis_SetPosition_88(base.GetCppThis(), position);
		}

		// Token: 0x06011228 RID: 70184
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetPrecision_89(HandleRef pThis, int precision);

		/// <summary>
		/// Get/set the numerical precision to use, default is 2. This is ignored
		/// when Notation is STANDARD_NOTATION or PRINTF_NOTATION.
		/// </summary>
		// Token: 0x06011229 RID: 70185 RVA: 0x0017E14C File Offset: 0x0017C34C
		public virtual void SetPrecision(int precision)
		{
			vtkAxis.vtkAxis_SetPrecision_89(base.GetCppThis(), precision);
		}

		// Token: 0x0601122A RID: 70186
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetRange_90(HandleRef pThis, double minimum, double maximum);

		/// <summary>
		/// Set the logical range of the axis, in plot coordinates.
		///
		/// The unscaled range will always be in the same coordinate system of
		/// the data being plotted, regardless of whether LogScale is true or false.
		/// When calling SetRange() and LogScale is true, the range must be specified
		/// in logarithmic coordinates.
		/// Using SetUnscaledRange(), you may ignore the value of LogScale.
		/// </summary>
		// Token: 0x0601122B RID: 70187 RVA: 0x0017E15C File Offset: 0x0017C35C
		public virtual void SetRange(double minimum, double maximum)
		{
			vtkAxis.vtkAxis_SetRange_90(base.GetCppThis(), minimum, maximum);
		}

		// Token: 0x0601122C RID: 70188
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetRange_91(HandleRef pThis, IntPtr range);

		/// <summary>
		/// Set the logical range of the axis, in plot coordinates.
		///
		/// The unscaled range will always be in the same coordinate system of
		/// the data being plotted, regardless of whether LogScale is true or false.
		/// When calling SetRange() and LogScale is true, the range must be specified
		/// in logarithmic coordinates.
		/// Using SetUnscaledRange(), you may ignore the value of LogScale.
		/// </summary>
		// Token: 0x0601122D RID: 70189 RVA: 0x0017E16D File Offset: 0x0017C36D
		public virtual void SetRange(IntPtr range)
		{
			vtkAxis.vtkAxis_SetRange_91(base.GetCppThis(), range);
		}

		// Token: 0x0601122E RID: 70190
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetRangeLabelFormat_92(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the printf-style format string used for range labels.
		/// This format is always used regardless of TickLabelAlgorithm and
		/// Notation. Default is "%g".
		/// </summary>
		// Token: 0x0601122F RID: 70191 RVA: 0x0017E17D File Offset: 0x0017C37D
		public virtual void SetRangeLabelFormat(string _arg)
		{
			vtkAxis.vtkAxis_SetRangeLabelFormat_92(base.GetCppThis(), _arg);
		}

		// Token: 0x06011230 RID: 70192
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetRangeLabelsVisible_93(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/set whether the labels for the range should be visible.
		/// </summary>
		// Token: 0x06011231 RID: 70193 RVA: 0x0017E18D File Offset: 0x0017C38D
		public virtual void SetRangeLabelsVisible(bool _arg)
		{
			vtkAxis.vtkAxis_SetRangeLabelsVisible_93(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011232 RID: 70194
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetScalingFactor_94(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/set the scaling factor used for the axis, this defaults to 1.0 (no
		/// scaling), and is used to coordinate scaling with the plots, charts, etc.
		/// </summary>
		// Token: 0x06011233 RID: 70195 RVA: 0x0017E1A5 File Offset: 0x0017C3A5
		public virtual void SetScalingFactor(double _arg)
		{
			vtkAxis.vtkAxis_SetScalingFactor_94(base.GetCppThis(), _arg);
		}

		// Token: 0x06011234 RID: 70196
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetShift_95(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/set the scaling factor used for the axis, this defaults to 1.0 (no
		/// scaling), and is used to coordinate scaling with the plots, charts, etc.
		/// </summary>
		// Token: 0x06011235 RID: 70197 RVA: 0x0017E1B5 File Offset: 0x0017C3B5
		public virtual void SetShift(double _arg)
		{
			vtkAxis.vtkAxis_SetShift_95(base.GetCppThis(), _arg);
		}

		// Token: 0x06011236 RID: 70198
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetTickLabelAlgorithm_96(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/set the tick label algorithm that is used to calculate the min, max
		/// and tick spacing. There are currently two algorithms, vtkAxis::TICK_SIMPLE
		/// is the default and uses a simple algorithm. The second option is
		/// vtkAxis::TICK_WILKINSON which uses an extended Wilkinson algorithm to find
		/// the optimal range, spacing and font parameters.
		/// </summary>
		// Token: 0x06011237 RID: 70199 RVA: 0x0017E1C5 File Offset: 0x0017C3C5
		public virtual void SetTickLabelAlgorithm(int _arg)
		{
			vtkAxis.vtkAxis_SetTickLabelAlgorithm_96(base.GetCppThis(), _arg);
		}

		// Token: 0x06011238 RID: 70200
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetTickLength_97(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/set the length of tick marks (in pixels).
		/// </summary>
		// Token: 0x06011239 RID: 70201 RVA: 0x0017E1D5 File Offset: 0x0017C3D5
		public virtual void SetTickLength(float _arg)
		{
			vtkAxis.vtkAxis_SetTickLength_97(base.GetCppThis(), _arg);
		}

		// Token: 0x0601123A RID: 70202
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetTicksVisible_98(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/set whether the tick marks should be visible.
		/// </summary>
		// Token: 0x0601123B RID: 70203 RVA: 0x0017E1E5 File Offset: 0x0017C3E5
		public virtual void SetTicksVisible(bool _arg)
		{
			vtkAxis.vtkAxis_SetTicksVisible_98(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601123C RID: 70204
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetTitle_99(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string title);

		/// <summary>
		/// Get/set the title text of the axis.
		/// </summary>
		// Token: 0x0601123D RID: 70205 RVA: 0x0017E1FD File Offset: 0x0017C3FD
		public virtual void SetTitle(string title)
		{
			vtkAxis.vtkAxis_SetTitle_99(base.GetCppThis(), title);
		}

		// Token: 0x0601123E RID: 70206
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetTitleVisible_100(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/set whether the axis title should be visible.
		/// </summary>
		// Token: 0x0601123F RID: 70207 RVA: 0x0017E20D File Offset: 0x0017C40D
		public virtual void SetTitleVisible(bool _arg)
		{
			vtkAxis.vtkAxis_SetTitleVisible_100(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011240 RID: 70208
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetUnscaledMaximum_101(HandleRef pThis, double maximum);

		/// <summary>
		/// Set the logical maximum value of the axis, in plot coordinates.
		/// </summary>
		// Token: 0x06011241 RID: 70209 RVA: 0x0017E225 File Offset: 0x0017C425
		public virtual void SetUnscaledMaximum(double maximum)
		{
			vtkAxis.vtkAxis_SetUnscaledMaximum_101(base.GetCppThis(), maximum);
		}

		// Token: 0x06011242 RID: 70210
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetUnscaledMaximumLimit_102(HandleRef pThis, double highest);

		/// <summary>
		/// Set the logical highest possible value for \a Maximum, in plot coordinates.
		/// </summary>
		// Token: 0x06011243 RID: 70211 RVA: 0x0017E235 File Offset: 0x0017C435
		public virtual void SetUnscaledMaximumLimit(double highest)
		{
			vtkAxis.vtkAxis_SetUnscaledMaximumLimit_102(base.GetCppThis(), highest);
		}

		// Token: 0x06011244 RID: 70212
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetUnscaledMinimum_103(HandleRef pThis, double minimum);

		/// <summary>
		/// Set the logical, unscaled minimum value of the axis, in plot coordinates.
		/// Use this instead of SetMinimum() if you wish to provide the actual minimum
		/// instead of log10(the minimum) as part of the axis scale.
		/// </summary>
		// Token: 0x06011245 RID: 70213 RVA: 0x0017E245 File Offset: 0x0017C445
		public virtual void SetUnscaledMinimum(double minimum)
		{
			vtkAxis.vtkAxis_SetUnscaledMinimum_103(base.GetCppThis(), minimum);
		}

		// Token: 0x06011246 RID: 70214
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetUnscaledMinimumLimit_104(HandleRef pThis, double lowest);

		/// <summary>
		/// Set the logical lowest possible value for \a Minimum, in plot coordinates.
		/// </summary>
		// Token: 0x06011247 RID: 70215 RVA: 0x0017E255 File Offset: 0x0017C455
		public virtual void SetUnscaledMinimumLimit(double lowest)
		{
			vtkAxis.vtkAxis_SetUnscaledMinimumLimit_104(base.GetCppThis(), lowest);
		}

		// Token: 0x06011248 RID: 70216
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetUnscaledRange_105(HandleRef pThis, double minimum, double maximum);

		/// <summary>
		/// Set the logical range of the axis, in plot coordinates.
		///
		/// The unscaled range will always be in the same coordinate system of
		/// the data being plotted, regardless of whether LogScale is true or false.
		/// When calling SetRange() and LogScale is true, the range must be specified
		/// in logarithmic coordinates.
		/// Using SetUnscaledRange(), you may ignore the value of LogScale.
		/// </summary>
		// Token: 0x06011249 RID: 70217 RVA: 0x0017E265 File Offset: 0x0017C465
		public virtual void SetUnscaledRange(double minimum, double maximum)
		{
			vtkAxis.vtkAxis_SetUnscaledRange_105(base.GetCppThis(), minimum, maximum);
		}

		// Token: 0x0601124A RID: 70218
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_SetUnscaledRange_106(HandleRef pThis, IntPtr range);

		/// <summary>
		/// Set the logical range of the axis, in plot coordinates.
		///
		/// The unscaled range will always be in the same coordinate system of
		/// the data being plotted, regardless of whether LogScale is true or false.
		/// When calling SetRange() and LogScale is true, the range must be specified
		/// in logarithmic coordinates.
		/// Using SetUnscaledRange(), you may ignore the value of LogScale.
		/// </summary>
		// Token: 0x0601124B RID: 70219 RVA: 0x0017E276 File Offset: 0x0017C476
		public virtual void SetUnscaledRange(IntPtr range)
		{
			vtkAxis.vtkAxis_SetUnscaledRange_106(base.GetCppThis(), range);
		}

		// Token: 0x0601124C RID: 70220
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxis_Update_107(HandleRef pThis);

		/// <summary>
		/// Update the geometry of the axis. Takes care of setting up the tick mark
		/// locations etc. Should be called by the scene before rendering.
		/// </summary>
		// Token: 0x0601124D RID: 70221 RVA: 0x0017E286 File Offset: 0x0017C486
		public override void Update()
		{
			vtkAxis.vtkAxis_Update_107(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013BC RID: 5052
		public new const string MRFullTypeName = "Kitware.VTK.vtkAxis";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013BD RID: 5053
		public new static readonly string MRClassNameKey = "class vtkAxis";

		/// <summary>
		/// Enumeration of the axis behaviors.
		/// </summary>
		// Token: 0x0200062C RID: 1580
		public enum AUTO_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040013BF RID: 5055
			AUTO,
			/// <summary>enum member</summary>
			// Token: 0x040013C0 RID: 5056
			CUSTOM = 2,
			/// <summary>enum member</summary>
			// Token: 0x040013C1 RID: 5057
			FIXED = 1
		}

		/// <summary>
		/// Enumeration of the axis locations in a conventional XY chart. Other
		/// layouts are possible.
		/// </summary>
		// Token: 0x0200062D RID: 1581
		public enum TICK_SIMPLE_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040013C3 RID: 5059
			TICK_SIMPLE,
			/// <summary>enum member</summary>
			// Token: 0x040013C4 RID: 5060
			TICK_WILKINSON_EXTENDED
		}

		/// <summary>
		/// Enumeration of the axis notations available.
		/// </summary>
		// Token: 0x0200062E RID: 1582
		public enum FIXED_NOTATION_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040013C6 RID: 5062
			FIXED_NOTATION = 2,
			/// <summary>enum member</summary>
			// Token: 0x040013C7 RID: 5063
			PRINTF_NOTATION,
			/// <summary>enum member</summary>
			// Token: 0x040013C8 RID: 5064
			SCIENTIFIC_NOTATION = 1,
			/// <summary>enum member</summary>
			// Token: 0x040013C9 RID: 5065
			STANDARD_NOTATION = 0
		}

		/// <summary>
		/// Enumeration of the axis locations in a conventional XY chart. Other
		/// layouts are possible.
		/// </summary>
		// Token: 0x0200062F RID: 1583
		public enum Location
		{
			/// <summary>enum member</summary>
			// Token: 0x040013CB RID: 5067
			BOTTOM = 1,
			/// <summary>enum member</summary>
			// Token: 0x040013CC RID: 5068
			LEFT = 0,
			/// <summary>enum member</summary>
			// Token: 0x040013CD RID: 5069
			PARALLEL = 4,
			/// <summary>enum member</summary>
			// Token: 0x040013CE RID: 5070
			RIGHT = 2,
			/// <summary>enum member</summary>
			// Token: 0x040013CF RID: 5071
			TOP
		}
	}
}
