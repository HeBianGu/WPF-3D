using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVolumeOfRevolutionFilter
	/// </summary>
	/// <remarks>
	///    sweep data about a line to create a volume
	///
	/// vtkVolumeOfRevolutionFilter is a modeling filter. It takes a 2-dimensional
	/// dataset as input and generates an unstructured grid on output. The input
	/// dataset is swept around the axis of rotation to create dimension-elevated
	/// primitives. For example, sweeping a vertex creates a series of lines;
	/// sweeping a line creates a series of quads, etc.
	///
	/// @warning
	/// The user must take care to ensure that the axis of revolution does not cross
	/// through the geometry, otherwise there will be intersecting cells in the
	/// output.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRotationalExtrusionFilter
	/// </seealso>
	// Token: 0x02000576 RID: 1398
	public class vtkVolumeOfRevolutionFilter : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F78C RID: 63372 RVA: 0x00158257 File Offset: 0x00156457
		static vtkVolumeOfRevolutionFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeOfRevolutionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeOfRevolutionFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F78D RID: 63373 RVA: 0x0015827F File Offset: 0x0015647F
		public vtkVolumeOfRevolutionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F78E RID: 63374
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeOfRevolutionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create object with sweep angle of 360 degrees, resolution = 12,
		/// axis position (0,0,0) and axis direction (0,0,1).
		/// </summary>
		// Token: 0x0600F78F RID: 63375 RVA: 0x00158290 File Offset: 0x00156490
		public new static vtkVolumeOfRevolutionFilter New()
		{
			vtkVolumeOfRevolutionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeOfRevolutionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create object with sweep angle of 360 degrees, resolution = 12,
		/// axis position (0,0,0) and axis direction (0,0,1).
		/// </summary>
		// Token: 0x0600F790 RID: 63376 RVA: 0x001582E4 File Offset: 0x001564E4
		public vtkVolumeOfRevolutionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F791 RID: 63377 RVA: 0x00158328 File Offset: 0x00156528
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F792 RID: 63378
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeOfRevolutionFilter_GetAxisDirection_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the direction of the axis of revolution.
		/// </summary>
		// Token: 0x0600F793 RID: 63379 RVA: 0x00158334 File Offset: 0x00156534
		public virtual double[] GetAxisDirection()
		{
			IntPtr intPtr = vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_GetAxisDirection_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F794 RID: 63380
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOfRevolutionFilter_GetAxisDirection_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the direction of the axis of revolution.
		/// </summary>
		// Token: 0x0600F795 RID: 63381 RVA: 0x0015837C File Offset: 0x0015657C
		public virtual void GetAxisDirection(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_GetAxisDirection_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600F796 RID: 63382
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOfRevolutionFilter_GetAxisDirection_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the direction of the axis of revolution.
		/// </summary>
		// Token: 0x0600F797 RID: 63383 RVA: 0x0015838E File Offset: 0x0015658E
		public virtual void GetAxisDirection(IntPtr _arg)
		{
			vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_GetAxisDirection_03(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F798 RID: 63384
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeOfRevolutionFilter_GetAxisPosition_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of the axis of revolution.
		/// </summary>
		// Token: 0x0600F799 RID: 63385 RVA: 0x001583A0 File Offset: 0x001565A0
		public virtual double[] GetAxisPosition()
		{
			IntPtr intPtr = vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_GetAxisPosition_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F79A RID: 63386
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOfRevolutionFilter_GetAxisPosition_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the position of the axis of revolution.
		/// </summary>
		// Token: 0x0600F79B RID: 63387 RVA: 0x001583E8 File Offset: 0x001565E8
		public virtual void GetAxisPosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_GetAxisPosition_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600F79C RID: 63388
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOfRevolutionFilter_GetAxisPosition_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the position of the axis of revolution.
		/// </summary>
		// Token: 0x0600F79D RID: 63389 RVA: 0x001583FA File Offset: 0x001565FA
		public virtual void GetAxisPosition(IntPtr _arg)
		{
			vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_GetAxisPosition_06(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F79E RID: 63390
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeOfRevolutionFilter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F79F RID: 63391 RVA: 0x0015840C File Offset: 0x0015660C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600F7A0 RID: 63392
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeOfRevolutionFilter_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F7A1 RID: 63393 RVA: 0x0015842C File Offset: 0x0015662C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600F7A2 RID: 63394
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeOfRevolutionFilter_GetOutputPointsPrecision_09(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0600F7A3 RID: 63395 RVA: 0x00158448 File Offset: 0x00156648
		public virtual int GetOutputPointsPrecision()
		{
			return vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_GetOutputPointsPrecision_09(base.GetCppThis());
		}

		// Token: 0x0600F7A4 RID: 63396
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeOfRevolutionFilter_GetOutputPointsPrecisionMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0600F7A5 RID: 63397 RVA: 0x00158468 File Offset: 0x00156668
		public virtual int GetOutputPointsPrecisionMaxValue()
		{
			return vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_GetOutputPointsPrecisionMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0600F7A6 RID: 63398
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeOfRevolutionFilter_GetOutputPointsPrecisionMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0600F7A7 RID: 63399 RVA: 0x00158488 File Offset: 0x00156688
		public virtual int GetOutputPointsPrecisionMinValue()
		{
			return vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_GetOutputPointsPrecisionMinValue_11(base.GetCppThis());
		}

		// Token: 0x0600F7A8 RID: 63400
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeOfRevolutionFilter_GetResolution_12(HandleRef pThis);

		/// <summary>
		/// Set/Get resolution of sweep operation. Resolution controls the number
		/// of intermediate node points.
		/// </summary>
		// Token: 0x0600F7A9 RID: 63401 RVA: 0x001584A8 File Offset: 0x001566A8
		public virtual int GetResolution()
		{
			return vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_GetResolution_12(base.GetCppThis());
		}

		// Token: 0x0600F7AA RID: 63402
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeOfRevolutionFilter_GetResolutionMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Set/Get resolution of sweep operation. Resolution controls the number
		/// of intermediate node points.
		/// </summary>
		// Token: 0x0600F7AB RID: 63403 RVA: 0x001584C8 File Offset: 0x001566C8
		public virtual int GetResolutionMaxValue()
		{
			return vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_GetResolutionMaxValue_13(base.GetCppThis());
		}

		// Token: 0x0600F7AC RID: 63404
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeOfRevolutionFilter_GetResolutionMinValue_14(HandleRef pThis);

		/// <summary>
		/// Set/Get resolution of sweep operation. Resolution controls the number
		/// of intermediate node points.
		/// </summary>
		// Token: 0x0600F7AD RID: 63405 RVA: 0x001584E8 File Offset: 0x001566E8
		public virtual int GetResolutionMinValue()
		{
			return vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_GetResolutionMinValue_14(base.GetCppThis());
		}

		// Token: 0x0600F7AE RID: 63406
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolumeOfRevolutionFilter_GetSweepAngle_15(HandleRef pThis);

		/// <summary>
		/// Set/Get angle of rotation in degrees.
		/// </summary>
		// Token: 0x0600F7AF RID: 63407 RVA: 0x00158508 File Offset: 0x00156708
		public virtual double GetSweepAngle()
		{
			return vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_GetSweepAngle_15(base.GetCppThis());
		}

		// Token: 0x0600F7B0 RID: 63408
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolumeOfRevolutionFilter_GetSweepAngleMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Set/Get angle of rotation in degrees.
		/// </summary>
		// Token: 0x0600F7B1 RID: 63409 RVA: 0x00158528 File Offset: 0x00156728
		public virtual double GetSweepAngleMaxValue()
		{
			return vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_GetSweepAngleMaxValue_16(base.GetCppThis());
		}

		// Token: 0x0600F7B2 RID: 63410
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVolumeOfRevolutionFilter_GetSweepAngleMinValue_17(HandleRef pThis);

		/// <summary>
		/// Set/Get angle of rotation in degrees.
		/// </summary>
		// Token: 0x0600F7B3 RID: 63411 RVA: 0x00158548 File Offset: 0x00156748
		public virtual double GetSweepAngleMinValue()
		{
			return vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_GetSweepAngleMinValue_17(base.GetCppThis());
		}

		// Token: 0x0600F7B4 RID: 63412
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeOfRevolutionFilter_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F7B5 RID: 63413 RVA: 0x00158568 File Offset: 0x00156768
		public override int IsA(string type)
		{
			return vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0600F7B6 RID: 63414
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeOfRevolutionFilter_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F7B7 RID: 63415 RVA: 0x00158588 File Offset: 0x00156788
		public new static int IsTypeOf(string type)
		{
			return vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_IsTypeOf_19(type);
		}

		// Token: 0x0600F7B8 RID: 63416
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeOfRevolutionFilter_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F7B9 RID: 63417 RVA: 0x001585A4 File Offset: 0x001567A4
		public new vtkVolumeOfRevolutionFilter NewInstance()
		{
			vtkVolumeOfRevolutionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeOfRevolutionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F7BA RID: 63418
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeOfRevolutionFilter_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F7BB RID: 63419 RVA: 0x00158600 File Offset: 0x00156800
		public new static vtkVolumeOfRevolutionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeOfRevolutionFilter vtkVolumeOfRevolutionFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeOfRevolutionFilter = (vtkVolumeOfRevolutionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeOfRevolutionFilter.Register(null);
				}
			}
			return vtkVolumeOfRevolutionFilter;
		}

		// Token: 0x0600F7BC RID: 63420
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOfRevolutionFilter_SetAxisDirection_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the direction of the axis of revolution.
		/// </summary>
		// Token: 0x0600F7BD RID: 63421 RVA: 0x0015867F File Offset: 0x0015687F
		public virtual void SetAxisDirection(double _arg1, double _arg2, double _arg3)
		{
			vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_SetAxisDirection_23(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600F7BE RID: 63422
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOfRevolutionFilter_SetAxisDirection_24(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the direction of the axis of revolution.
		/// </summary>
		// Token: 0x0600F7BF RID: 63423 RVA: 0x00158691 File Offset: 0x00156891
		public virtual void SetAxisDirection(IntPtr _arg)
		{
			vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_SetAxisDirection_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F7C0 RID: 63424
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOfRevolutionFilter_SetAxisPosition_25(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the position of the axis of revolution.
		/// </summary>
		// Token: 0x0600F7C1 RID: 63425 RVA: 0x001586A1 File Offset: 0x001568A1
		public virtual void SetAxisPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_SetAxisPosition_25(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600F7C2 RID: 63426
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOfRevolutionFilter_SetAxisPosition_26(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the position of the axis of revolution.
		/// </summary>
		// Token: 0x0600F7C3 RID: 63427 RVA: 0x001586B3 File Offset: 0x001568B3
		public virtual void SetAxisPosition(IntPtr _arg)
		{
			vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_SetAxisPosition_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F7C4 RID: 63428
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOfRevolutionFilter_SetOutputPointsPrecision_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0600F7C5 RID: 63429 RVA: 0x001586C3 File Offset: 0x001568C3
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_SetOutputPointsPrecision_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F7C6 RID: 63430
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOfRevolutionFilter_SetResolution_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get resolution of sweep operation. Resolution controls the number
		/// of intermediate node points.
		/// </summary>
		// Token: 0x0600F7C7 RID: 63431 RVA: 0x001586D3 File Offset: 0x001568D3
		public virtual void SetResolution(int _arg)
		{
			vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_SetResolution_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F7C8 RID: 63432
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOfRevolutionFilter_SetSweepAngle_29(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get angle of rotation in degrees.
		/// </summary>
		// Token: 0x0600F7C9 RID: 63433 RVA: 0x001586E3 File Offset: 0x001568E3
		public virtual void SetSweepAngle(double _arg)
		{
			vtkVolumeOfRevolutionFilter.vtkVolumeOfRevolutionFilter_SetSweepAngle_29(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001201 RID: 4609
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeOfRevolutionFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001202 RID: 4610
		public new static readonly string MRClassNameKey = "class vtkVolumeOfRevolutionFilter";
	}
}
