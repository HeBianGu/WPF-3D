using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkComputeQuantiles
	/// </summary>
	/// <remarks>
	///    Extract Ntiles and extremum values
	/// of all columns of a table or all fields of a dataset.
	///
	/// vtkComputeQuantiles accepts any vtkDataObject as input and produces a vtkTable data as output
	/// containing the extrema and quantiles.
	///
	/// The filter internally uses vtkOrderStatistics to divide the dataset into N intervals; so to
	/// compute quartiles set the number of intervals to 4, for deciles set the number of intervals to 10
	/// etc. The output table has the same number of columns as the input data set and has N+1 number of
	/// rows to store the intervals and extrema.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTableAlgorithm vtkOrderStatistics
	///
	/// @par Thanks:
	/// This class was written by Kitware SAS and supported by EDF - www.edf.fr
	/// </seealso>
	// Token: 0x0200073E RID: 1854
	public class vtkComputeQuantiles : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060134A9 RID: 79017 RVA: 0x001B47A2 File Offset: 0x001B29A2
		static vtkComputeQuantiles()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkComputeQuantiles.MRClassNameKey, Type.GetType("Kitware.VTK.vtkComputeQuantiles"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060134AA RID: 79018 RVA: 0x001B47CA File Offset: 0x001B29CA
		public vtkComputeQuantiles(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060134AB RID: 79019
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkComputeQuantiles_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134AC RID: 79020 RVA: 0x001B47D8 File Offset: 0x001B29D8
		public new static vtkComputeQuantiles New()
		{
			vtkComputeQuantiles result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkComputeQuantiles.vtkComputeQuantiles_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkComputeQuantiles)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134AD RID: 79021 RVA: 0x001B482C File Offset: 0x001B2A2C
		public vtkComputeQuantiles() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkComputeQuantiles.vtkComputeQuantiles_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060134AE RID: 79022 RVA: 0x001B4870 File Offset: 0x001B2A70
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060134AF RID: 79023
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkComputeQuantiles_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134B0 RID: 79024 RVA: 0x001B487C File Offset: 0x001B2A7C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkComputeQuantiles.vtkComputeQuantiles_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060134B1 RID: 79025
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkComputeQuantiles_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134B2 RID: 79026 RVA: 0x001B489C File Offset: 0x001B2A9C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkComputeQuantiles.vtkComputeQuantiles_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060134B3 RID: 79027
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkComputeQuantiles_GetNumberOfIntervals_03(HandleRef pThis);

		/// <summary>
		/// Set/get the number of intervals into which the data is to be divided.
		/// Default is 4.
		/// </summary>
		// Token: 0x060134B4 RID: 79028 RVA: 0x001B48B8 File Offset: 0x001B2AB8
		public virtual int GetNumberOfIntervals()
		{
			return vtkComputeQuantiles.vtkComputeQuantiles_GetNumberOfIntervals_03(base.GetCppThis());
		}

		// Token: 0x060134B5 RID: 79029
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkComputeQuantiles_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134B6 RID: 79030 RVA: 0x001B48D8 File Offset: 0x001B2AD8
		public override int IsA(string type)
		{
			return vtkComputeQuantiles.vtkComputeQuantiles_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060134B7 RID: 79031
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkComputeQuantiles_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134B8 RID: 79032 RVA: 0x001B48F8 File Offset: 0x001B2AF8
		public new static int IsTypeOf(string type)
		{
			return vtkComputeQuantiles.vtkComputeQuantiles_IsTypeOf_05(type);
		}

		// Token: 0x060134B9 RID: 79033
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkComputeQuantiles_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134BA RID: 79034 RVA: 0x001B4914 File Offset: 0x001B2B14
		public new vtkComputeQuantiles NewInstance()
		{
			vtkComputeQuantiles result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkComputeQuantiles.vtkComputeQuantiles_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkComputeQuantiles)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060134BB RID: 79035
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkComputeQuantiles_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134BC RID: 79036 RVA: 0x001B4970 File Offset: 0x001B2B70
		public new static vtkComputeQuantiles SafeDownCast(vtkObjectBase o)
		{
			vtkComputeQuantiles vtkComputeQuantiles = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkComputeQuantiles.vtkComputeQuantiles_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkComputeQuantiles = (vtkComputeQuantiles)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkComputeQuantiles.Register(null);
				}
			}
			return vtkComputeQuantiles;
		}

		// Token: 0x060134BD RID: 79037
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkComputeQuantiles_SetNumberOfIntervals_09(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the number of intervals into which the data is to be divided.
		/// Default is 4.
		/// </summary>
		// Token: 0x060134BE RID: 79038 RVA: 0x001B49EF File Offset: 0x001B2BEF
		public virtual void SetNumberOfIntervals(int _arg)
		{
			vtkComputeQuantiles.vtkComputeQuantiles_SetNumberOfIntervals_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400164C RID: 5708
		public new const string MRFullTypeName = "Kitware.VTK.vtkComputeQuantiles";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400164D RID: 5709
		public new static readonly string MRClassNameKey = "class vtkComputeQuantiles";
	}
}
