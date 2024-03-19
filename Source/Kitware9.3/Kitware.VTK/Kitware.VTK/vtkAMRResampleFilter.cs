using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAMRResampleFilter
	///
	///
	///  This filter is a concrete instance of vtkMultiBlockDataSetAlgorithm and
	///  provides functionality for extracting portion of the AMR dataset, specified
	///  by a bounding box, in a uniform grid of the desired level of resolution.
	///  The resulting uniform grid is stored in a vtkMultiBlockDataSet where the
	///  number of blocks correspond to the number of processors utilized for the
	///  operation.
	///
	/// @warning
	///  Data of the input AMR dataset is assumed to be cell-centered.
	///
	/// </summary>
	/// <seealso>
	///
	///  vtkOverlappingAMR, vtkUniformGrid
	/// </seealso>
	// Token: 0x020004EA RID: 1258
	public class vtkAMRResampleFilter : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E365 RID: 58213 RVA: 0x0013C8FF File Offset: 0x0013AAFF
		static vtkAMRResampleFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMRResampleFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRResampleFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E366 RID: 58214 RVA: 0x0013C927 File Offset: 0x0013AB27
		public vtkAMRResampleFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E367 RID: 58215
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRResampleFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E368 RID: 58216 RVA: 0x0013C938 File Offset: 0x0013AB38
		public new static vtkAMRResampleFilter New()
		{
			vtkAMRResampleFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRResampleFilter.vtkAMRResampleFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRResampleFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E369 RID: 58217 RVA: 0x0013C98C File Offset: 0x0013AB8C
		public vtkAMRResampleFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAMRResampleFilter.vtkAMRResampleFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E36A RID: 58218 RVA: 0x0013C9D0 File Offset: 0x0013ABD0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E36B RID: 58219
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRResampleFilter_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Gets the metadata from upstream module and determines which blocks
		/// should be loaded by this instance.
		/// </summary>
		// Token: 0x0600E36C RID: 58220 RVA: 0x0013C9DC File Offset: 0x0013ABDC
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkAMRResampleFilter.vtkAMRResampleFilter_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0600E36D RID: 58221
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRResampleFilter_FillOutputPortInformation_02(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Gets the metadata from upstream module and determines which blocks
		/// should be loaded by this instance.
		/// </summary>
		// Token: 0x0600E36E RID: 58222 RVA: 0x0013CA14 File Offset: 0x0013AC14
		public virtual int FillOutputPortInformation(int port, vtkInformation info)
		{
			return vtkAMRResampleFilter.vtkAMRResampleFilter_FillOutputPortInformation_02(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0600E36F RID: 58223
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRResampleFilter_GetBiasVector_03(HandleRef pThis);

		/// <summary>
		/// Set and Get the bias vector.  If UseBiasVector is true
		/// then the largest component of this vector can not have
		/// the max number of samples
		/// </summary>
		// Token: 0x0600E370 RID: 58224 RVA: 0x0013CA4C File Offset: 0x0013AC4C
		public virtual double[] GetBiasVector()
		{
			IntPtr intPtr = vtkAMRResampleFilter.vtkAMRResampleFilter_GetBiasVector_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600E371 RID: 58225
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_GetBiasVector_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set and Get the bias vector.  If UseBiasVector is true
		/// then the largest component of this vector can not have
		/// the max number of samples
		/// </summary>
		// Token: 0x0600E372 RID: 58226 RVA: 0x0013CA94 File Offset: 0x0013AC94
		public virtual void GetBiasVector(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_GetBiasVector_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600E373 RID: 58227
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_GetBiasVector_05(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set and Get the bias vector.  If UseBiasVector is true
		/// then the largest component of this vector can not have
		/// the max number of samples
		/// </summary>
		// Token: 0x0600E374 RID: 58228 RVA: 0x0013CAA6 File Offset: 0x0013ACA6
		public virtual void GetBiasVector(IntPtr _arg)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_GetBiasVector_05(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E375 RID: 58229
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRResampleFilter_GetController_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set &amp; Get macro for the multi-process controller
		/// </summary>
		// Token: 0x0600E376 RID: 58230 RVA: 0x0013CAB8 File Offset: 0x0013ACB8
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRResampleFilter.vtkAMRResampleFilter_GetController_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E377 RID: 58231
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRResampleFilter_GetDemandDrivenMode_07(HandleRef pThis);

		/// <summary>
		/// Set &amp; Get macro to allow the filter to operate in both demand-driven
		/// and standard modes
		/// </summary>
		// Token: 0x0600E378 RID: 58232 RVA: 0x0013CB28 File Offset: 0x0013AD28
		public virtual int GetDemandDrivenMode()
		{
			return vtkAMRResampleFilter.vtkAMRResampleFilter_GetDemandDrivenMode_07(base.GetCppThis());
		}

		// Token: 0x0600E379 RID: 58233
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRResampleFilter_GetMax_08(HandleRef pThis);

		/// <summary>
		/// Set and Get the max corner
		/// </summary>
		// Token: 0x0600E37A RID: 58234 RVA: 0x0013CB48 File Offset: 0x0013AD48
		public virtual double[] GetMax()
		{
			IntPtr intPtr = vtkAMRResampleFilter.vtkAMRResampleFilter_GetMax_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600E37B RID: 58235
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_GetMax_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set and Get the max corner
		/// </summary>
		// Token: 0x0600E37C RID: 58236 RVA: 0x0013CB90 File Offset: 0x0013AD90
		public virtual void GetMax(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_GetMax_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600E37D RID: 58237
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_GetMax_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set and Get the max corner
		/// </summary>
		// Token: 0x0600E37E RID: 58238 RVA: 0x0013CBA2 File Offset: 0x0013ADA2
		public virtual void GetMax(IntPtr _arg)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_GetMax_10(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E37F RID: 58239
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRResampleFilter_GetMin_11(HandleRef pThis);

		/// <summary>
		/// Set and Get the min corner
		/// </summary>
		// Token: 0x0600E380 RID: 58240 RVA: 0x0013CBB4 File Offset: 0x0013ADB4
		public virtual double[] GetMin()
		{
			IntPtr intPtr = vtkAMRResampleFilter.vtkAMRResampleFilter_GetMin_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600E381 RID: 58241
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_GetMin_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set and Get the min corner
		/// </summary>
		// Token: 0x0600E382 RID: 58242 RVA: 0x0013CBFC File Offset: 0x0013ADFC
		public virtual void GetMin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_GetMin_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600E383 RID: 58243
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_GetMin_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set and Get the min corner
		/// </summary>
		// Token: 0x0600E384 RID: 58244 RVA: 0x0013CC0E File Offset: 0x0013AE0E
		public virtual void GetMin(IntPtr _arg)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_GetMin_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E385 RID: 58245
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRResampleFilter_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E386 RID: 58246 RVA: 0x0013CC20 File Offset: 0x0013AE20
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMRResampleFilter.vtkAMRResampleFilter_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0600E387 RID: 58247
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRResampleFilter_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E388 RID: 58248 RVA: 0x0013CC40 File Offset: 0x0013AE40
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMRResampleFilter.vtkAMRResampleFilter_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0600E389 RID: 58249
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRResampleFilter_GetNumberOfPartitions_16(HandleRef pThis);

		/// <summary>
		/// Set &amp; Get macro for the number of subdivisions
		/// </summary>
		// Token: 0x0600E38A RID: 58250 RVA: 0x0013CC5C File Offset: 0x0013AE5C
		public virtual int GetNumberOfPartitions()
		{
			return vtkAMRResampleFilter.vtkAMRResampleFilter_GetNumberOfPartitions_16(base.GetCppThis());
		}

		// Token: 0x0600E38B RID: 58251
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRResampleFilter_GetNumberOfSamples_17(HandleRef pThis);

		/// <summary>
		/// Set &amp; Get macro for the number of samples (cells) in each dimension.
		/// Nominal value for the number of samples is 10x10x10.
		/// </summary>
		// Token: 0x0600E38C RID: 58252 RVA: 0x0013CC7C File Offset: 0x0013AE7C
		public virtual int[] GetNumberOfSamples()
		{
			IntPtr intPtr = vtkAMRResampleFilter.vtkAMRResampleFilter_GetNumberOfSamples_17(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600E38D RID: 58253
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_GetNumberOfSamples_18(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Set &amp; Get macro for the number of samples (cells) in each dimension.
		/// Nominal value for the number of samples is 10x10x10.
		/// </summary>
		// Token: 0x0600E38E RID: 58254 RVA: 0x0013CCC4 File Offset: 0x0013AEC4
		public virtual void GetNumberOfSamples(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_GetNumberOfSamples_18(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600E38F RID: 58255
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_GetNumberOfSamples_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set &amp; Get macro for the number of samples (cells) in each dimension.
		/// Nominal value for the number of samples is 10x10x10.
		/// </summary>
		// Token: 0x0600E390 RID: 58256 RVA: 0x0013CCD6 File Offset: 0x0013AED6
		public virtual void GetNumberOfSamples(IntPtr _arg)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_GetNumberOfSamples_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E391 RID: 58257
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRResampleFilter_GetTransferToNodes_20(HandleRef pThis);

		/// <summary>
		/// Set &amp; Get macro for the TransferToNodes flag
		/// </summary>
		// Token: 0x0600E392 RID: 58258 RVA: 0x0013CCE8 File Offset: 0x0013AEE8
		public virtual int GetTransferToNodes()
		{
			return vtkAMRResampleFilter.vtkAMRResampleFilter_GetTransferToNodes_20(base.GetCppThis());
		}

		// Token: 0x0600E393 RID: 58259
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRResampleFilter_GetUseBiasVector_21(HandleRef pThis);

		/// <summary>
		/// Set &amp; Get macro for the number of subdivisions
		/// </summary>
		// Token: 0x0600E394 RID: 58260 RVA: 0x0013CD08 File Offset: 0x0013AF08
		public virtual bool GetUseBiasVector()
		{
			return vtkAMRResampleFilter.vtkAMRResampleFilter_GetUseBiasVector_21(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E395 RID: 58261
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRResampleFilter_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E396 RID: 58262 RVA: 0x0013CD30 File Offset: 0x0013AF30
		public override int IsA(string type)
		{
			return vtkAMRResampleFilter.vtkAMRResampleFilter_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0600E397 RID: 58263
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRResampleFilter_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E398 RID: 58264 RVA: 0x0013CD50 File Offset: 0x0013AF50
		public new static int IsTypeOf(string type)
		{
			return vtkAMRResampleFilter.vtkAMRResampleFilter_IsTypeOf_23(type);
		}

		// Token: 0x0600E399 RID: 58265
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRResampleFilter_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E39A RID: 58266 RVA: 0x0013CD6C File Offset: 0x0013AF6C
		public new vtkAMRResampleFilter NewInstance()
		{
			vtkAMRResampleFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRResampleFilter.vtkAMRResampleFilter_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRResampleFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E39B RID: 58267
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRResampleFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E39C RID: 58268 RVA: 0x0013CDC8 File Offset: 0x0013AFC8
		public new static vtkAMRResampleFilter SafeDownCast(vtkObjectBase o)
		{
			vtkAMRResampleFilter vtkAMRResampleFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRResampleFilter.vtkAMRResampleFilter_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMRResampleFilter = (vtkAMRResampleFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMRResampleFilter.Register(null);
				}
			}
			return vtkAMRResampleFilter;
		}

		// Token: 0x0600E39D RID: 58269
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_SetBiasVector_27(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set and Get the bias vector.  If UseBiasVector is true
		/// then the largest component of this vector can not have
		/// the max number of samples
		/// </summary>
		// Token: 0x0600E39E RID: 58270 RVA: 0x0013CE47 File Offset: 0x0013B047
		public virtual void SetBiasVector(double _arg1, double _arg2, double _arg3)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_SetBiasVector_27(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600E39F RID: 58271
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_SetBiasVector_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set and Get the bias vector.  If UseBiasVector is true
		/// then the largest component of this vector can not have
		/// the max number of samples
		/// </summary>
		// Token: 0x0600E3A0 RID: 58272 RVA: 0x0013CE59 File Offset: 0x0013B059
		public virtual void SetBiasVector(IntPtr _arg)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_SetBiasVector_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E3A1 RID: 58273
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_SetController_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set &amp; Get macro for the multi-process controller
		/// </summary>
		// Token: 0x0600E3A2 RID: 58274 RVA: 0x0013CE6C File Offset: 0x0013B06C
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_SetController_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600E3A3 RID: 58275
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_SetDemandDrivenMode_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set &amp; Get macro to allow the filter to operate in both demand-driven
		/// and standard modes
		/// </summary>
		// Token: 0x0600E3A4 RID: 58276 RVA: 0x0013CE9B File Offset: 0x0013B09B
		public virtual void SetDemandDrivenMode(int _arg)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_SetDemandDrivenMode_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E3A5 RID: 58277
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_SetMax_31(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set and Get the max corner
		/// </summary>
		// Token: 0x0600E3A6 RID: 58278 RVA: 0x0013CEAB File Offset: 0x0013B0AB
		public virtual void SetMax(double _arg1, double _arg2, double _arg3)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_SetMax_31(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600E3A7 RID: 58279
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_SetMax_32(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set and Get the max corner
		/// </summary>
		// Token: 0x0600E3A8 RID: 58280 RVA: 0x0013CEBD File Offset: 0x0013B0BD
		public virtual void SetMax(IntPtr _arg)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_SetMax_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E3A9 RID: 58281
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_SetMin_33(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set and Get the min corner
		/// </summary>
		// Token: 0x0600E3AA RID: 58282 RVA: 0x0013CECD File Offset: 0x0013B0CD
		public virtual void SetMin(double _arg1, double _arg2, double _arg3)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_SetMin_33(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600E3AB RID: 58283
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_SetMin_34(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set and Get the min corner
		/// </summary>
		// Token: 0x0600E3AC RID: 58284 RVA: 0x0013CEDF File Offset: 0x0013B0DF
		public virtual void SetMin(IntPtr _arg)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_SetMin_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E3AD RID: 58285
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_SetNumberOfPartitions_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Set &amp; Get macro for the number of subdivisions
		/// </summary>
		// Token: 0x0600E3AE RID: 58286 RVA: 0x0013CEEF File Offset: 0x0013B0EF
		public virtual void SetNumberOfPartitions(int _arg)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_SetNumberOfPartitions_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E3AF RID: 58287
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_SetNumberOfSamples_36(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set &amp; Get macro for the number of samples (cells) in each dimension.
		/// Nominal value for the number of samples is 10x10x10.
		/// </summary>
		// Token: 0x0600E3B0 RID: 58288 RVA: 0x0013CEFF File Offset: 0x0013B0FF
		public virtual void SetNumberOfSamples(int _arg1, int _arg2, int _arg3)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_SetNumberOfSamples_36(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600E3B1 RID: 58289
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_SetNumberOfSamples_37(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set &amp; Get macro for the number of samples (cells) in each dimension.
		/// Nominal value for the number of samples is 10x10x10.
		/// </summary>
		// Token: 0x0600E3B2 RID: 58290 RVA: 0x0013CF11 File Offset: 0x0013B111
		public virtual void SetNumberOfSamples(IntPtr _arg)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_SetNumberOfSamples_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E3B3 RID: 58291
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_SetTransferToNodes_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Set &amp; Get macro for the TransferToNodes flag
		/// </summary>
		// Token: 0x0600E3B4 RID: 58292 RVA: 0x0013CF21 File Offset: 0x0013B121
		public virtual void SetTransferToNodes(int _arg)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_SetTransferToNodes_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E3B5 RID: 58293
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRResampleFilter_SetUseBiasVector_39(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set &amp; Get macro for the number of subdivisions
		/// </summary>
		// Token: 0x0600E3B6 RID: 58294 RVA: 0x0013CF31 File Offset: 0x0013B131
		public virtual void SetUseBiasVector(bool _arg)
		{
			vtkAMRResampleFilter.vtkAMRResampleFilter_SetUseBiasVector_39(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010B7 RID: 4279
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMRResampleFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010B8 RID: 4280
		public new static readonly string MRClassNameKey = "class vtkAMRResampleFilter";
	}
}
