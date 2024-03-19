using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCorrelativeStatistics
	/// </summary>
	/// <remarks>
	///    A class for bivariate linear correlation
	///
	///
	/// Given a selection of pairs of columns of interest, this class provides the
	/// following functionalities, depending on the chosen execution options:
	/// * Learn: calculate sample mean and M2 aggregates for each pair of variables
	///   (cf. P. Pebay, Formulas for robust, one-pass parallel computation of covariances
	///   and Arbitrary-Order Statistical Moments, Sandia Report SAND2008-6212, Sep 2008,
	///   http://infoserve.sandia.gov/sand_doc/2008/086212.pdf for details)
	/// * Derive: calculate unbiased covariance matrix estimators and its determinant,
	///   linear regressions, and Pearson correlation coefficient.
	/// * Assess: given an input data set, two means and a 2x2 covariance matrix,
	///   mark each datum with corresponding relative deviation (2-dimensional Mahlanobis
	///   distance).
	/// * Test: Perform Jarque-Bera-Srivastava test of 2-d normality
	///
	/// @par Thanks:
	/// Thanks to Philippe Pebay and David Thompson from Sandia National Laboratories
	/// for implementing this class.
	/// Updated by Philippe Pebay, Kitware SAS 2012
	/// </remarks>
	// Token: 0x02000741 RID: 1857
	public class vtkCorrelativeStatistics : vtkStatisticsAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060134E5 RID: 79077 RVA: 0x001B4EA3 File Offset: 0x001B30A3
		static vtkCorrelativeStatistics()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCorrelativeStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCorrelativeStatistics"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060134E6 RID: 79078 RVA: 0x001B4ECB File Offset: 0x001B30CB
		public vtkCorrelativeStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060134E7 RID: 79079
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCorrelativeStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134E8 RID: 79080 RVA: 0x001B4EDC File Offset: 0x001B30DC
		public new static vtkCorrelativeStatistics New()
		{
			vtkCorrelativeStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCorrelativeStatistics.vtkCorrelativeStatistics_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134E9 RID: 79081 RVA: 0x001B4F30 File Offset: 0x001B3130
		public vtkCorrelativeStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCorrelativeStatistics.vtkCorrelativeStatistics_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060134EA RID: 79082 RVA: 0x001B4F74 File Offset: 0x001B3174
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060134EB RID: 79083
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCorrelativeStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Given a collection of models, calculate aggregate model
		/// </summary>
		// Token: 0x060134EC RID: 79084 RVA: 0x001B4F80 File Offset: 0x001B3180
		public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkCorrelativeStatistics.vtkCorrelativeStatistics_Aggregate_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060134ED RID: 79085
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCorrelativeStatistics_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134EE RID: 79086 RVA: 0x001B4FC4 File Offset: 0x001B31C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCorrelativeStatistics.vtkCorrelativeStatistics_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060134EF RID: 79087
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCorrelativeStatistics_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134F0 RID: 79088 RVA: 0x001B4FE4 File Offset: 0x001B31E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCorrelativeStatistics.vtkCorrelativeStatistics_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060134F1 RID: 79089
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCorrelativeStatistics_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134F2 RID: 79090 RVA: 0x001B5000 File Offset: 0x001B3200
		public override int IsA(string type)
		{
			return vtkCorrelativeStatistics.vtkCorrelativeStatistics_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060134F3 RID: 79091
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCorrelativeStatistics_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134F4 RID: 79092 RVA: 0x001B5020 File Offset: 0x001B3220
		public new static int IsTypeOf(string type)
		{
			return vtkCorrelativeStatistics.vtkCorrelativeStatistics_IsTypeOf_05(type);
		}

		// Token: 0x060134F5 RID: 79093
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCorrelativeStatistics_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134F6 RID: 79094 RVA: 0x001B503C File Offset: 0x001B323C
		public new vtkCorrelativeStatistics NewInstance()
		{
			vtkCorrelativeStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCorrelativeStatistics.vtkCorrelativeStatistics_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060134F7 RID: 79095
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCorrelativeStatistics_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134F8 RID: 79096 RVA: 0x001B5098 File Offset: 0x001B3298
		public new static vtkCorrelativeStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkCorrelativeStatistics vtkCorrelativeStatistics = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCorrelativeStatistics.vtkCorrelativeStatistics_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCorrelativeStatistics = (vtkCorrelativeStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCorrelativeStatistics.Register(null);
				}
			}
			return vtkCorrelativeStatistics;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001652 RID: 5714
		public new const string MRFullTypeName = "Kitware.VTK.vtkCorrelativeStatistics";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001653 RID: 5715
		public new static readonly string MRClassNameKey = "class vtkCorrelativeStatistics";
	}
}
