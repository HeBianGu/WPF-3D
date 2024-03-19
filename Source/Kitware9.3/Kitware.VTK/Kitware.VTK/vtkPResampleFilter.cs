using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPResampleFilter
	/// </summary>
	/// <remarks>
	///    probe dataset in parallel using a vtkImageData
	///
	/// </remarks>
	// Token: 0x0200052E RID: 1326
	public class vtkPResampleFilter : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600ECCF RID: 60623 RVA: 0x0014A2BB File Offset: 0x001484BB
		static vtkPResampleFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPResampleFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPResampleFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600ECD0 RID: 60624 RVA: 0x0014A2E3 File Offset: 0x001484E3
		public vtkPResampleFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600ECD1 RID: 60625
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPResampleFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ECD2 RID: 60626 RVA: 0x0014A2F4 File Offset: 0x001484F4
		public new static vtkPResampleFilter New()
		{
			vtkPResampleFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPResampleFilter.vtkPResampleFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPResampleFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ECD3 RID: 60627 RVA: 0x0014A348 File Offset: 0x00148548
		public vtkPResampleFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPResampleFilter.vtkPResampleFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600ECD4 RID: 60628 RVA: 0x0014A38C File Offset: 0x0014858C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600ECD5 RID: 60629
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPResampleFilter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set and get the controller.
		/// </summary>
		// Token: 0x0600ECD6 RID: 60630 RVA: 0x0014A398 File Offset: 0x00148598
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPResampleFilter.vtkPResampleFilter_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x0600ECD7 RID: 60631
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPResampleFilter_GetCustomSamplingBounds_02(HandleRef pThis);

		/// <summary>
		/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
		/// bounds won't be used.
		/// </summary>
		// Token: 0x0600ECD8 RID: 60632 RVA: 0x0014A408 File Offset: 0x00148608
		public virtual double[] GetCustomSamplingBounds()
		{
			IntPtr intPtr = vtkPResampleFilter.vtkPResampleFilter_GetCustomSamplingBounds_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600ECD9 RID: 60633
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPResampleFilter_GetCustomSamplingBounds_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		/// <summary>
		/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
		/// bounds won't be used.
		/// </summary>
		// Token: 0x0600ECDA RID: 60634 RVA: 0x0014A450 File Offset: 0x00148650
		public virtual void GetCustomSamplingBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkPResampleFilter.vtkPResampleFilter_GetCustomSamplingBounds_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0600ECDB RID: 60635
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPResampleFilter_GetCustomSamplingBounds_04(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
		/// bounds won't be used.
		/// </summary>
		// Token: 0x0600ECDC RID: 60636 RVA: 0x0014A468 File Offset: 0x00148668
		public virtual void GetCustomSamplingBounds(IntPtr _arg)
		{
			vtkPResampleFilter.vtkPResampleFilter_GetCustomSamplingBounds_04(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ECDD RID: 60637
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPResampleFilter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ECDE RID: 60638 RVA: 0x0014A478 File Offset: 0x00148678
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPResampleFilter.vtkPResampleFilter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600ECDF RID: 60639
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPResampleFilter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ECE0 RID: 60640 RVA: 0x0014A498 File Offset: 0x00148698
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPResampleFilter.vtkPResampleFilter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600ECE1 RID: 60641
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPResampleFilter_GetSamplingDimension_07(HandleRef pThis);

		/// <summary>
		/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
		/// </summary>
		// Token: 0x0600ECE2 RID: 60642 RVA: 0x0014A4B4 File Offset: 0x001486B4
		public virtual int[] GetSamplingDimension()
		{
			IntPtr intPtr = vtkPResampleFilter.vtkPResampleFilter_GetSamplingDimension_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600ECE3 RID: 60643
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPResampleFilter_GetSamplingDimension_08(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
		/// </summary>
		// Token: 0x0600ECE4 RID: 60644 RVA: 0x0014A4FC File Offset: 0x001486FC
		public virtual void GetSamplingDimension(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkPResampleFilter.vtkPResampleFilter_GetSamplingDimension_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600ECE5 RID: 60645
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPResampleFilter_GetSamplingDimension_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
		/// </summary>
		// Token: 0x0600ECE6 RID: 60646 RVA: 0x0014A50E File Offset: 0x0014870E
		public virtual void GetSamplingDimension(IntPtr _arg)
		{
			vtkPResampleFilter.vtkPResampleFilter_GetSamplingDimension_09(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ECE7 RID: 60647
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPResampleFilter_GetUseInputBounds_10(HandleRef pThis);

		/// <summary>
		/// Set/Get if the filter should use Input bounds to sub-sample the data.
		/// By default it is set to 1.
		/// </summary>
		// Token: 0x0600ECE8 RID: 60648 RVA: 0x0014A520 File Offset: 0x00148720
		public virtual int GetUseInputBounds()
		{
			return vtkPResampleFilter.vtkPResampleFilter_GetUseInputBounds_10(base.GetCppThis());
		}

		// Token: 0x0600ECE9 RID: 60649
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPResampleFilter_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ECEA RID: 60650 RVA: 0x0014A540 File Offset: 0x00148740
		public override int IsA(string type)
		{
			return vtkPResampleFilter.vtkPResampleFilter_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600ECEB RID: 60651
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPResampleFilter_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ECEC RID: 60652 RVA: 0x0014A560 File Offset: 0x00148760
		public new static int IsTypeOf(string type)
		{
			return vtkPResampleFilter.vtkPResampleFilter_IsTypeOf_12(type);
		}

		// Token: 0x0600ECED RID: 60653
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPResampleFilter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ECEE RID: 60654 RVA: 0x0014A57C File Offset: 0x0014877C
		public new vtkPResampleFilter NewInstance()
		{
			vtkPResampleFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPResampleFilter.vtkPResampleFilter_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPResampleFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600ECEF RID: 60655
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPResampleFilter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ECF0 RID: 60656 RVA: 0x0014A5D8 File Offset: 0x001487D8
		public new static vtkPResampleFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPResampleFilter vtkPResampleFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPResampleFilter.vtkPResampleFilter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPResampleFilter = (vtkPResampleFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPResampleFilter.Register(null);
				}
			}
			return vtkPResampleFilter;
		}

		// Token: 0x0600ECF1 RID: 60657
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPResampleFilter_SetController_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set and get the controller.
		/// </summary>
		// Token: 0x0600ECF2 RID: 60658 RVA: 0x0014A658 File Offset: 0x00148858
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPResampleFilter.vtkPResampleFilter_SetController_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600ECF3 RID: 60659
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPResampleFilter_SetCustomSamplingBounds_17(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
		/// bounds won't be used.
		/// </summary>
		// Token: 0x0600ECF4 RID: 60660 RVA: 0x0014A687 File Offset: 0x00148887
		public virtual void SetCustomSamplingBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkPResampleFilter.vtkPResampleFilter_SetCustomSamplingBounds_17(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600ECF5 RID: 60661
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPResampleFilter_SetCustomSamplingBounds_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get sampling bounds. If (UseInputBounds == 1) then the sampling
		/// bounds won't be used.
		/// </summary>
		// Token: 0x0600ECF6 RID: 60662 RVA: 0x0014A69F File Offset: 0x0014889F
		public virtual void SetCustomSamplingBounds(IntPtr _arg)
		{
			vtkPResampleFilter.vtkPResampleFilter_SetCustomSamplingBounds_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ECF7 RID: 60663
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPResampleFilter_SetSamplingDimension_19(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
		/// </summary>
		// Token: 0x0600ECF8 RID: 60664 RVA: 0x0014A6AF File Offset: 0x001488AF
		public virtual void SetSamplingDimension(int _arg1, int _arg2, int _arg3)
		{
			vtkPResampleFilter.vtkPResampleFilter_SetSamplingDimension_19(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600ECF9 RID: 60665
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPResampleFilter_SetSamplingDimension_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get sampling dimension along each axis. Default will be [10,10,10]
		/// </summary>
		// Token: 0x0600ECFA RID: 60666 RVA: 0x0014A6C1 File Offset: 0x001488C1
		public virtual void SetSamplingDimension(IntPtr _arg)
		{
			vtkPResampleFilter.vtkPResampleFilter_SetSamplingDimension_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ECFB RID: 60667
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPResampleFilter_SetUseInputBounds_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get if the filter should use Input bounds to sub-sample the data.
		/// By default it is set to 1.
		/// </summary>
		// Token: 0x0600ECFC RID: 60668 RVA: 0x0014A6D1 File Offset: 0x001488D1
		public virtual void SetUseInputBounds(int _arg)
		{
			vtkPResampleFilter.vtkPResampleFilter_SetUseInputBounds_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ECFD RID: 60669
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPResampleFilter_UseInputBoundsOff_22(HandleRef pThis);

		/// <summary>
		/// Set/Get if the filter should use Input bounds to sub-sample the data.
		/// By default it is set to 1.
		/// </summary>
		// Token: 0x0600ECFE RID: 60670 RVA: 0x0014A6E1 File Offset: 0x001488E1
		public virtual void UseInputBoundsOff()
		{
			vtkPResampleFilter.vtkPResampleFilter_UseInputBoundsOff_22(base.GetCppThis());
		}

		// Token: 0x0600ECFF RID: 60671
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPResampleFilter_UseInputBoundsOn_23(HandleRef pThis);

		/// <summary>
		/// Set/Get if the filter should use Input bounds to sub-sample the data.
		/// By default it is set to 1.
		/// </summary>
		// Token: 0x0600ED00 RID: 60672 RVA: 0x0014A6F0 File Offset: 0x001488F0
		public virtual void UseInputBoundsOn()
		{
			vtkPResampleFilter.vtkPResampleFilter_UseInputBoundsOn_23(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001153 RID: 4435
		public new const string MRFullTypeName = "Kitware.VTK.vtkPResampleFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001154 RID: 4436
		public new static readonly string MRClassNameKey = "class vtkPResampleFilter";
	}
}
