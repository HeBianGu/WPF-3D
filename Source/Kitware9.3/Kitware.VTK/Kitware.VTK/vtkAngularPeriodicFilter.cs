using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAngularPeriodicFilter
	/// </summary>
	/// <remarks>
	///    A filter to produce mapped angular periodic
	/// multiblock dataset from a single block, by rotation.
	///
	///
	/// Generate angular periodic dataset by rotating points, vectors and tensors
	/// data arrays from an original data array.
	/// The generated dataset is of the same type than the input (float or double).
	/// To compute the rotation this filter needs
	/// i) a number of periods, which can be the maximum, i.e. a full period,
	/// ii) an angle, which can be fetched from a field data array in radian or directly
	/// in degrees; iii) the axis (X, Y or Z) and the center of rotation.
	/// Point coordinates are transformed, as well as all vectors (3-components) and
	/// tensors (9 components) in points and cell data arrays.
	/// The generated multiblock will have the same tree architecture than the input,
	/// except transformed leaves are replaced by a vtkMultipieceDataSet.
	/// Supported input leaf dataset type are: vtkPolyData, vtkStructuredGrid
	/// and vtkUnstructuredGrid. Other data objects are rotated using the
	/// transform filter (at a high cost!).
	/// </remarks>
	// Token: 0x020004F7 RID: 1271
	public class vtkAngularPeriodicFilter : vtkPeriodicFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E4EE RID: 58606 RVA: 0x0013EE05 File Offset: 0x0013D005
		static vtkAngularPeriodicFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAngularPeriodicFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAngularPeriodicFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E4EF RID: 58607 RVA: 0x0013EE2D File Offset: 0x0013D02D
		public vtkAngularPeriodicFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E4F0 RID: 58608
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngularPeriodicFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4F1 RID: 58609 RVA: 0x0013EE3C File Offset: 0x0013D03C
		public new static vtkAngularPeriodicFilter New()
		{
			vtkAngularPeriodicFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAngularPeriodicFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4F2 RID: 58610 RVA: 0x0013EE90 File Offset: 0x0013D090
		public vtkAngularPeriodicFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E4F3 RID: 58611 RVA: 0x0013EED4 File Offset: 0x0013D0D4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E4F4 RID: 58612
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngularPeriodicFilter_ComputeRotationsOnTheFlyOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the rotated array values should be computed
		/// on-the-fly (default), which is compute-intensive, or the arrays should be
		/// explicitly generated and stored, at the cost of using more memory.
		/// </summary>
		// Token: 0x0600E4F5 RID: 58613 RVA: 0x0013EEDF File Offset: 0x0013D0DF
		public virtual void ComputeRotationsOnTheFlyOff()
		{
			vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_ComputeRotationsOnTheFlyOff_01(base.GetCppThis());
		}

		// Token: 0x0600E4F6 RID: 58614
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngularPeriodicFilter_ComputeRotationsOnTheFlyOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the rotated array values should be computed
		/// on-the-fly (default), which is compute-intensive, or the arrays should be
		/// explicitly generated and stored, at the cost of using more memory.
		/// </summary>
		// Token: 0x0600E4F7 RID: 58615 RVA: 0x0013EEEE File Offset: 0x0013D0EE
		public virtual void ComputeRotationsOnTheFlyOn()
		{
			vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_ComputeRotationsOnTheFlyOn_02(base.GetCppThis());
		}

		// Token: 0x0600E4F8 RID: 58616
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngularPeriodicFilter_GetCenter_03(HandleRef pThis);

		/// <summary>
		/// Set/Get Rotation Center
		/// </summary>
		// Token: 0x0600E4F9 RID: 58617 RVA: 0x0013EF00 File Offset: 0x0013D100
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_GetCenter_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600E4FA RID: 58618
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngularPeriodicFilter_GetCenter_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get Rotation Center
		/// </summary>
		// Token: 0x0600E4FB RID: 58619 RVA: 0x0013EF48 File Offset: 0x0013D148
		public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_GetCenter_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600E4FC RID: 58620
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngularPeriodicFilter_GetCenter_05(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get Rotation Center
		/// </summary>
		// Token: 0x0600E4FD RID: 58621 RVA: 0x0013EF5A File Offset: 0x0013D15A
		public virtual void GetCenter(IntPtr _arg)
		{
			vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_GetCenter_05(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E4FE RID: 58622
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAngularPeriodicFilter_GetComputeRotationsOnTheFly_06(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the rotated array values should be computed
		/// on-the-fly (default), which is compute-intensive, or the arrays should be
		/// explicitly generated and stored, at the cost of using more memory.
		/// </summary>
		// Token: 0x0600E4FF RID: 58623 RVA: 0x0013EF6C File Offset: 0x0013D16C
		public virtual bool GetComputeRotationsOnTheFly()
		{
			return vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_GetComputeRotationsOnTheFly_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E500 RID: 58624
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAngularPeriodicFilter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E501 RID: 58625 RVA: 0x0013EF94 File Offset: 0x0013D194
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600E502 RID: 58626
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAngularPeriodicFilter_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E503 RID: 58627 RVA: 0x0013EFB4 File Offset: 0x0013D1B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600E504 RID: 58628
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAngularPeriodicFilter_GetRotationAngle_09(HandleRef pThis);

		/// <summary>
		/// Set/Get Rotation angle, in degrees.
		/// Used only with VTK_ROTATION_MODE_DIRECT_ANGLE.
		/// Default is 180.
		/// </summary>
		// Token: 0x0600E505 RID: 58629 RVA: 0x0013EFD0 File Offset: 0x0013D1D0
		public virtual double GetRotationAngle()
		{
			return vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_GetRotationAngle_09(base.GetCppThis());
		}

		// Token: 0x0600E506 RID: 58630
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngularPeriodicFilter_GetRotationArrayName_10(HandleRef pThis);

		/// <summary>
		/// Set/Get Name of array to get the angle from.
		/// Used only with VTK_ROTATION_MODE_ARRAY_VALUE.
		/// </summary>
		// Token: 0x0600E507 RID: 58631 RVA: 0x0013EFF0 File Offset: 0x0013D1F0
		public virtual string GetRotationArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_GetRotationArrayName_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600E508 RID: 58632
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngularPeriodicFilter_GetRotationAxis_11(HandleRef pThis);

		/// <summary>
		/// Set/Get Rotation Axis, 0 for X, 1 for Y, 2 for Z
		/// </summary>
		// Token: 0x0600E509 RID: 58633 RVA: 0x0013F02C File Offset: 0x0013D22C
		public virtual int GetRotationAxis()
		{
			return vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_GetRotationAxis_11(base.GetCppThis());
		}

		// Token: 0x0600E50A RID: 58634
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngularPeriodicFilter_GetRotationAxisMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get Rotation Axis, 0 for X, 1 for Y, 2 for Z
		/// </summary>
		// Token: 0x0600E50B RID: 58635 RVA: 0x0013F04C File Offset: 0x0013D24C
		public virtual int GetRotationAxisMaxValue()
		{
			return vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_GetRotationAxisMaxValue_12(base.GetCppThis());
		}

		// Token: 0x0600E50C RID: 58636
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngularPeriodicFilter_GetRotationAxisMinValue_13(HandleRef pThis);

		/// <summary>
		/// Set/Get Rotation Axis, 0 for X, 1 for Y, 2 for Z
		/// </summary>
		// Token: 0x0600E50D RID: 58637 RVA: 0x0013F06C File Offset: 0x0013D26C
		public virtual int GetRotationAxisMinValue()
		{
			return vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_GetRotationAxisMinValue_13(base.GetCppThis());
		}

		// Token: 0x0600E50E RID: 58638
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngularPeriodicFilter_GetRotationMode_14(HandleRef pThis);

		/// <summary>
		/// Set/Get The rotation mode.
		/// VTK_ROTATION_MODE_DIRECT_ANGLE to specify an angle value (default),
		/// VTK_ROTATION_MODE_ARRAY_VALUE to use value from an array in the input dataset.
		/// </summary>
		// Token: 0x0600E50F RID: 58639 RVA: 0x0013F08C File Offset: 0x0013D28C
		public virtual int GetRotationMode()
		{
			return vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_GetRotationMode_14(base.GetCppThis());
		}

		// Token: 0x0600E510 RID: 58640
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngularPeriodicFilter_GetRotationModeMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Set/Get The rotation mode.
		/// VTK_ROTATION_MODE_DIRECT_ANGLE to specify an angle value (default),
		/// VTK_ROTATION_MODE_ARRAY_VALUE to use value from an array in the input dataset.
		/// </summary>
		// Token: 0x0600E511 RID: 58641 RVA: 0x0013F0AC File Offset: 0x0013D2AC
		public virtual int GetRotationModeMaxValue()
		{
			return vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_GetRotationModeMaxValue_15(base.GetCppThis());
		}

		// Token: 0x0600E512 RID: 58642
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngularPeriodicFilter_GetRotationModeMinValue_16(HandleRef pThis);

		/// <summary>
		/// Set/Get The rotation mode.
		/// VTK_ROTATION_MODE_DIRECT_ANGLE to specify an angle value (default),
		/// VTK_ROTATION_MODE_ARRAY_VALUE to use value from an array in the input dataset.
		/// </summary>
		// Token: 0x0600E513 RID: 58643 RVA: 0x0013F0CC File Offset: 0x0013D2CC
		public virtual int GetRotationModeMinValue()
		{
			return vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_GetRotationModeMinValue_16(base.GetCppThis());
		}

		// Token: 0x0600E514 RID: 58644
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngularPeriodicFilter_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E515 RID: 58645 RVA: 0x0013F0EC File Offset: 0x0013D2EC
		public override int IsA(string type)
		{
			return vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0600E516 RID: 58646
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngularPeriodicFilter_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E517 RID: 58647 RVA: 0x0013F10C File Offset: 0x0013D30C
		public new static int IsTypeOf(string type)
		{
			return vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_IsTypeOf_18(type);
		}

		// Token: 0x0600E518 RID: 58648
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngularPeriodicFilter_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E519 RID: 58649 RVA: 0x0013F128 File Offset: 0x0013D328
		public new vtkAngularPeriodicFilter NewInstance()
		{
			vtkAngularPeriodicFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAngularPeriodicFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E51A RID: 58650
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngularPeriodicFilter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E51B RID: 58651 RVA: 0x0013F184 File Offset: 0x0013D384
		public new static vtkAngularPeriodicFilter SafeDownCast(vtkObjectBase o)
		{
			vtkAngularPeriodicFilter vtkAngularPeriodicFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAngularPeriodicFilter = (vtkAngularPeriodicFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAngularPeriodicFilter.Register(null);
				}
			}
			return vtkAngularPeriodicFilter;
		}

		// Token: 0x0600E51C RID: 58652
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngularPeriodicFilter_SetCenter_22(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get Rotation Center
		/// </summary>
		// Token: 0x0600E51D RID: 58653 RVA: 0x0013F203 File Offset: 0x0013D403
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_SetCenter_22(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600E51E RID: 58654
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngularPeriodicFilter_SetCenter_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get Rotation Center
		/// </summary>
		// Token: 0x0600E51F RID: 58655 RVA: 0x0013F215 File Offset: 0x0013D415
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_SetCenter_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E520 RID: 58656
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngularPeriodicFilter_SetComputeRotationsOnTheFly_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether the rotated array values should be computed
		/// on-the-fly (default), which is compute-intensive, or the arrays should be
		/// explicitly generated and stored, at the cost of using more memory.
		/// </summary>
		// Token: 0x0600E521 RID: 58657 RVA: 0x0013F225 File Offset: 0x0013D425
		public virtual void SetComputeRotationsOnTheFly(bool _arg)
		{
			vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_SetComputeRotationsOnTheFly_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E522 RID: 58658
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngularPeriodicFilter_SetRotationAngle_25(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get Rotation angle, in degrees.
		/// Used only with VTK_ROTATION_MODE_DIRECT_ANGLE.
		/// Default is 180.
		/// </summary>
		// Token: 0x0600E523 RID: 58659 RVA: 0x0013F23D File Offset: 0x0013D43D
		public virtual void SetRotationAngle(double _arg)
		{
			vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_SetRotationAngle_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E524 RID: 58660
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngularPeriodicFilter_SetRotationArrayName_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get Name of array to get the angle from.
		/// Used only with VTK_ROTATION_MODE_ARRAY_VALUE.
		/// </summary>
		// Token: 0x0600E525 RID: 58661 RVA: 0x0013F24D File Offset: 0x0013D44D
		public virtual void SetRotationArrayName(string _arg)
		{
			vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_SetRotationArrayName_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E526 RID: 58662
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngularPeriodicFilter_SetRotationAxis_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get Rotation Axis, 0 for X, 1 for Y, 2 for Z
		/// </summary>
		// Token: 0x0600E527 RID: 58663 RVA: 0x0013F25D File Offset: 0x0013D45D
		public virtual void SetRotationAxis(int _arg)
		{
			vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_SetRotationAxis_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E528 RID: 58664
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngularPeriodicFilter_SetRotationAxisToX_28(HandleRef pThis);

		/// <summary>
		/// Set/Get Rotation Axis, 0 for X, 1 for Y, 2 for Z
		/// </summary>
		// Token: 0x0600E529 RID: 58665 RVA: 0x0013F26D File Offset: 0x0013D46D
		public void SetRotationAxisToX()
		{
			vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_SetRotationAxisToX_28(base.GetCppThis());
		}

		// Token: 0x0600E52A RID: 58666
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngularPeriodicFilter_SetRotationAxisToY_29(HandleRef pThis);

		/// <summary>
		/// Set/Get Rotation Axis, 0 for X, 1 for Y, 2 for Z
		/// </summary>
		// Token: 0x0600E52B RID: 58667 RVA: 0x0013F27C File Offset: 0x0013D47C
		public void SetRotationAxisToY()
		{
			vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_SetRotationAxisToY_29(base.GetCppThis());
		}

		// Token: 0x0600E52C RID: 58668
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngularPeriodicFilter_SetRotationAxisToZ_30(HandleRef pThis);

		/// <summary>
		/// Set/Get Rotation Axis, 0 for X, 1 for Y, 2 for Z
		/// </summary>
		// Token: 0x0600E52D RID: 58669 RVA: 0x0013F28B File Offset: 0x0013D48B
		public void SetRotationAxisToZ()
		{
			vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_SetRotationAxisToZ_30(base.GetCppThis());
		}

		// Token: 0x0600E52E RID: 58670
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngularPeriodicFilter_SetRotationMode_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get The rotation mode.
		/// VTK_ROTATION_MODE_DIRECT_ANGLE to specify an angle value (default),
		/// VTK_ROTATION_MODE_ARRAY_VALUE to use value from an array in the input dataset.
		/// </summary>
		// Token: 0x0600E52F RID: 58671 RVA: 0x0013F29A File Offset: 0x0013D49A
		public virtual void SetRotationMode(int _arg)
		{
			vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_SetRotationMode_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E530 RID: 58672
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngularPeriodicFilter_SetRotationModeToArrayValue_32(HandleRef pThis);

		/// <summary>
		/// Set/Get The rotation mode.
		/// VTK_ROTATION_MODE_DIRECT_ANGLE to specify an angle value (default),
		/// VTK_ROTATION_MODE_ARRAY_VALUE to use value from an array in the input dataset.
		/// </summary>
		// Token: 0x0600E531 RID: 58673 RVA: 0x0013F2AA File Offset: 0x0013D4AA
		public void SetRotationModeToArrayValue()
		{
			vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_SetRotationModeToArrayValue_32(base.GetCppThis());
		}

		// Token: 0x0600E532 RID: 58674
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngularPeriodicFilter_SetRotationModeToDirectAngle_33(HandleRef pThis);

		/// <summary>
		/// Set/Get The rotation mode.
		/// VTK_ROTATION_MODE_DIRECT_ANGLE to specify an angle value (default),
		/// VTK_ROTATION_MODE_ARRAY_VALUE to use value from an array in the input dataset.
		/// </summary>
		// Token: 0x0600E533 RID: 58675 RVA: 0x0013F2B9 File Offset: 0x0013D4B9
		public void SetRotationModeToDirectAngle()
		{
			vtkAngularPeriodicFilter.vtkAngularPeriodicFilter_SetRotationModeToDirectAngle_33(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010D3 RID: 4307
		public new const string MRFullTypeName = "Kitware.VTK.vtkAngularPeriodicFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010D4 RID: 4308
		public new static readonly string MRClassNameKey = "class vtkAngularPeriodicFilter";
	}
}
