using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStatisticsAlgorithm
	/// </summary>
	/// <remarks>
	///    Base class for statistics algorithms
	///
	///
	/// All statistics algorithms can conceptually be operated with several operations:
	/// * Learn: given an input data set, calculate a minimal statistical model (e.g.,
	///   sums, raw moments, joint probabilities).
	/// * Derive: given an input minimal statistical model, derive the full model
	///   (e.g., descriptive statistics, quantiles, correlations, conditional
	///    probabilities).
	///   NB: It may be, or not be, a problem that a full model was not derived. For
	///   instance, when doing parallel calculations, one only wants to derive the full
	///   model after all partial calculations have completed. On the other hand, one
	///   can also directly provide a full model, that was previously calculated or
	///   guessed, and not derive a new one.
	/// * Assess: given an input data set, input statistics, and some form of
	///   threshold, assess a subset of the data set.
	/// * Test: perform at least one statistical test.
	/// Therefore, a vtkStatisticsAlgorithm has the following ports
	/// * 3 optional input ports:
	///   * Data (vtkTable)
	///   * Parameters to the learn operation (vtkTable)
	///   * Input model (vtkMultiBlockDataSet)
	/// * 3 output ports:
	///   * Data (input annotated with assessments when the Assess operation is ON).
	///   * Output model (identical to the input model when Learn operation is OFF).
	///   * Output of statistical tests. Some engines do not offer such tests yet, in
	///     which case this output will always be empty even when the Test operation is ON.
	///
	/// @par Thanks:
	/// Thanks to Philippe Pebay and David Thompson from Sandia National Laboratories
	/// for implementing this class.
	/// Updated by Philippe Pebay, Kitware SAS 2012
	/// </remarks>
	// Token: 0x02000472 RID: 1138
	public abstract class vtkStatisticsAlgorithm : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D240 RID: 53824 RVA: 0x00124B07 File Offset: 0x00122D07
		static vtkStatisticsAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStatisticsAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStatisticsAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D241 RID: 53825 RVA: 0x00124B2F File Offset: 0x00122D2F
		public vtkStatisticsAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D242 RID: 53826 RVA: 0x00124B3D File Offset: 0x00122D3D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D243 RID: 53827
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticsAlgorithm_AddColumn_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string namCol);

		/// <summary>
		/// Convenience method to create a request with a single column name \p namCol in a single
		/// call; this is the preferred method to select columns, ensuring selection consistency
		/// (a single column per request).
		/// Warning: no name checking is performed on \p namCol; it is the user's
		/// responsibility to use valid column names.
		/// </summary>
		// Token: 0x0600D244 RID: 53828 RVA: 0x00124B48 File Offset: 0x00122D48
		public void AddColumn(string namCol)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_AddColumn_01(base.GetCppThis(), namCol);
		}

		// Token: 0x0600D245 RID: 53829
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticsAlgorithm_AddColumnPair_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string namColX, [MarshalAs(UnmanagedType.LPUTF8Str)] string namColY);

		/// <summary>
		/// Convenience method to create a request with a single column name pair
		/// (\p namColX, \p namColY) in a single call; this is the preferred method to select
		/// columns pairs, ensuring selection consistency (a pair of columns per request).
		///
		/// Unlike SetColumnStatus(), you need not call RequestSelectedColumns() after AddColumnPair().
		///
		/// Warning: \p namColX and \p namColY are only checked for their validity as strings;
		/// no check is made that either are valid column names.
		/// </summary>
		// Token: 0x0600D246 RID: 53830 RVA: 0x00124B58 File Offset: 0x00122D58
		public void AddColumnPair(string namColX, string namColY)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_AddColumnPair_02(base.GetCppThis(), namColX, namColY);
		}

		// Token: 0x0600D247 RID: 53831
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticsAlgorithm_Aggregate_03(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Given a collection of models, calculate aggregate model
		/// </summary>
		// Token: 0x0600D248 RID: 53832 RVA: 0x00124B6C File Offset: 0x00122D6C
		public virtual void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_Aggregate_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600D249 RID: 53833
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStatisticsAlgorithm_GetAssessNames_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get assessment names.
		/// </summary>
		// Token: 0x0600D24A RID: 53834 RVA: 0x00124BB0 File Offset: 0x00122DB0
		public virtual vtkStringArray GetAssessNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetAssessNames_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600D24B RID: 53835
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStatisticsAlgorithm_GetAssessOption_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the Assess operation.
		/// </summary>
		// Token: 0x0600D24C RID: 53836 RVA: 0x00124C20 File Offset: 0x00122E20
		public virtual bool GetAssessOption()
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetAssessOption_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0600D24D RID: 53837
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStatisticsAlgorithm_GetColumnForRequest_06(HandleRef pThis, long r, long c);

		/// <summary>
		/// Provide the name of the \a c-th column for the \a r-th request.
		///
		/// For the version of this routine that returns an integer,
		/// if the request or column does not exist because \a r or \a c is out of bounds,
		/// this routine returns 0 and the value of \a columnName is unspecified.
		/// Otherwise, it returns 1 and the value of \a columnName is set.
		///
		/// For the version of this routine that returns const char*,
		/// if the request or column does not exist because \a r or \a c is out of bounds,
		/// the routine returns nullptr. Otherwise it returns the column name.
		/// This version is not thread-safe.
		/// </summary>
		// Token: 0x0600D24E RID: 53838 RVA: 0x00124C48 File Offset: 0x00122E48
		public virtual string GetColumnForRequest(long r, long c)
		{
			string s = Marshal.PtrToStringAnsi(vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetColumnForRequest_06(base.GetCppThis(), r, c));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600D24F RID: 53839
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStatisticsAlgorithm_GetColumnForRequest_07(HandleRef pThis, long r, long c, [MarshalAs(UnmanagedType.LPUTF8Str)] string columnName);

		/// <summary>
		/// Provide the name of the \a c-th column for the \a r-th request.
		///
		/// For the version of this routine that returns an integer,
		/// if the request or column does not exist because \a r or \a c is out of bounds,
		/// this routine returns 0 and the value of \a columnName is unspecified.
		/// Otherwise, it returns 1 and the value of \a columnName is set.
		///
		/// For the version of this routine that returns const char*,
		/// if the request or column does not exist because \a r or \a c is out of bounds,
		/// the routine returns nullptr. Otherwise it returns the column name.
		/// This version is not thread-safe.
		/// </summary>
		// Token: 0x0600D250 RID: 53840 RVA: 0x00124C84 File Offset: 0x00122E84
		public virtual int GetColumnForRequest(long r, long c, string columnName)
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetColumnForRequest_07(base.GetCppThis(), r, c, columnName);
		}

		// Token: 0x0600D251 RID: 53841
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStatisticsAlgorithm_GetDeriveOption_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the Derive operation.
		/// </summary>
		// Token: 0x0600D252 RID: 53842 RVA: 0x00124CA8 File Offset: 0x00122EA8
		public virtual bool GetDeriveOption()
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetDeriveOption_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0600D253 RID: 53843
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStatisticsAlgorithm_GetLearnOption_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the Learn operation.
		/// </summary>
		// Token: 0x0600D254 RID: 53844 RVA: 0x00124CD0 File Offset: 0x00122ED0
		public virtual bool GetLearnOption()
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetLearnOption_09(base.GetCppThis()) != 0;
		}

		// Token: 0x0600D255 RID: 53845
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStatisticsAlgorithm_GetNumberOfColumnsForRequest_10(HandleRef pThis, long request);

		/// <summary>
		/// Return the number of columns for a given request.
		/// </summary>
		// Token: 0x0600D256 RID: 53846 RVA: 0x00124CF8 File Offset: 0x00122EF8
		public virtual long GetNumberOfColumnsForRequest(long request)
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetNumberOfColumnsForRequest_10(base.GetCppThis(), request);
		}

		// Token: 0x0600D257 RID: 53847
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStatisticsAlgorithm_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D258 RID: 53848 RVA: 0x00124D18 File Offset: 0x00122F18
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0600D259 RID: 53849
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStatisticsAlgorithm_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D25A RID: 53850 RVA: 0x00124D38 File Offset: 0x00122F38
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0600D25B RID: 53851
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStatisticsAlgorithm_GetNumberOfPrimaryTables_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of tables in the primary model.
		/// </summary>
		// Token: 0x0600D25C RID: 53852 RVA: 0x00124D54 File Offset: 0x00122F54
		public virtual long GetNumberOfPrimaryTables()
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetNumberOfPrimaryTables_13(base.GetCppThis());
		}

		// Token: 0x0600D25D RID: 53853
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStatisticsAlgorithm_GetNumberOfRequests_14(HandleRef pThis);

		/// <summary>
		/// Return the number of requests.
		/// This does not include any request that is in the column-status buffer
		/// but for which RequestSelectedColumns() has not yet been called (even though
		/// it is possible this request will be honored when the filter is run -- see SetColumnStatus()
		/// for more information).
		/// </summary>
		// Token: 0x0600D25E RID: 53854 RVA: 0x00124D74 File Offset: 0x00122F74
		public virtual long GetNumberOfRequests()
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetNumberOfRequests_14(base.GetCppThis());
		}

		// Token: 0x0600D25F RID: 53855
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStatisticsAlgorithm_GetTestOption_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the Test operation.
		/// </summary>
		// Token: 0x0600D260 RID: 53856 RVA: 0x00124D94 File Offset: 0x00122F94
		public virtual bool GetTestOption()
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_GetTestOption_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0600D261 RID: 53857
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStatisticsAlgorithm_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D262 RID: 53858 RVA: 0x00124DBC File Offset: 0x00122FBC
		public override int IsA(string type)
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0600D263 RID: 53859
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStatisticsAlgorithm_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D264 RID: 53860 RVA: 0x00124DDC File Offset: 0x00122FDC
		public new static int IsTypeOf(string type)
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_IsTypeOf_17(type);
		}

		// Token: 0x0600D265 RID: 53861
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStatisticsAlgorithm_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D266 RID: 53862 RVA: 0x00124DF8 File Offset: 0x00122FF8
		public new vtkStatisticsAlgorithm NewInstance()
		{
			vtkStatisticsAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStatisticsAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D267 RID: 53863
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStatisticsAlgorithm_RequestSelectedColumns_19(HandleRef pThis);

		/// <summary>
		/// Use the current column status values to produce a new request for statistics
		/// to be produced when RequestData() is called. See SetColumnStatus() for more information.
		/// </summary>
		// Token: 0x0600D268 RID: 53864 RVA: 0x00124E54 File Offset: 0x00123054
		public virtual int RequestSelectedColumns()
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_RequestSelectedColumns_19(base.GetCppThis());
		}

		// Token: 0x0600D269 RID: 53865
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticsAlgorithm_ResetAllColumnStates_20(HandleRef pThis);

		/// <summary>
		/// Set the status of each and every column in the current request to OFF (0).
		/// </summary>
		// Token: 0x0600D26A RID: 53866 RVA: 0x00124E73 File Offset: 0x00123073
		public virtual void ResetAllColumnStates()
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_ResetAllColumnStates_20(base.GetCppThis());
		}

		// Token: 0x0600D26B RID: 53867
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticsAlgorithm_ResetRequests_21(HandleRef pThis);

		/// <summary>
		/// Empty the list of current requests.
		/// </summary>
		// Token: 0x0600D26C RID: 53868 RVA: 0x00124E82 File Offset: 0x00123082
		public virtual void ResetRequests()
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_ResetRequests_21(base.GetCppThis());
		}

		// Token: 0x0600D26D RID: 53869
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStatisticsAlgorithm_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D26E RID: 53870 RVA: 0x00124E94 File Offset: 0x00123094
		public new static vtkStatisticsAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkStatisticsAlgorithm vtkStatisticsAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStatisticsAlgorithm = (vtkStatisticsAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStatisticsAlgorithm.Register(null);
				}
			}
			return vtkStatisticsAlgorithm;
		}

		// Token: 0x0600D26F RID: 53871
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticsAlgorithm_SetAssessNames_23(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/get assessment names.
		/// </summary>
		// Token: 0x0600D270 RID: 53872 RVA: 0x00124F14 File Offset: 0x00123114
		public virtual void SetAssessNames(vtkStringArray arg0)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetAssessNames_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D271 RID: 53873
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticsAlgorithm_SetAssessOption_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the Assess operation.
		/// </summary>
		// Token: 0x0600D272 RID: 53874 RVA: 0x00124F43 File Offset: 0x00123143
		public virtual void SetAssessOption(bool _arg)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetAssessOption_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600D273 RID: 53875
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticsAlgorithm_SetColumnStatus_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string namCol, int status);

		/// <summary>
		/// Add or remove a column from the current analysis request.
		/// Once all the column status values are set, call RequestSelectedColumns()
		/// before selecting another set of columns for a different analysis request.
		/// The way that columns selections are used varies from algorithm to algorithm.
		///
		/// Note: the set of selected columns is maintained in vtkStatisticsAlgorithmPrivate::Buffer
		/// until RequestSelectedColumns() is called, at which point the set is appended
		/// to vtkStatisticsAlgorithmPrivate::Requests.
		/// If there are any columns in vtkStatisticsAlgorithmPrivate::Buffer at the time
		/// RequestData() is called, RequestSelectedColumns() will be called and the
		/// selection added to the list of requests.
		/// </summary>
		// Token: 0x0600D274 RID: 53876 RVA: 0x00124F5B File Offset: 0x0012315B
		public virtual void SetColumnStatus(string namCol, int status)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetColumnStatus_25(base.GetCppThis(), namCol, status);
		}

		// Token: 0x0600D275 RID: 53877
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticsAlgorithm_SetDeriveOption_26(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the Derive operation.
		/// </summary>
		// Token: 0x0600D276 RID: 53878 RVA: 0x00124F6C File Offset: 0x0012316C
		public virtual void SetDeriveOption(bool _arg)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetDeriveOption_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600D277 RID: 53879
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticsAlgorithm_SetInputModel_27(HandleRef pThis, HandleRef model);

		/// <summary>
		/// A convenience method for setting the input model (if one is expected or allowed).
		/// It is equivalent to calling SetInputData( 2, model );
		/// </summary>
		// Token: 0x0600D278 RID: 53880 RVA: 0x00124F84 File Offset: 0x00123184
		public virtual void SetInputModel(vtkDataObject model)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetInputModel_27(base.GetCppThis(), (model == null) ? default(HandleRef) : model.GetCppThis());
		}

		// Token: 0x0600D279 RID: 53881
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticsAlgorithm_SetInputModelConnection_28(HandleRef pThis, HandleRef model);

		/// <summary>
		/// A convenience method for setting the input model connection (if one is expected or allowed).
		/// It is equivalent to calling SetInputConnection( 2, model );
		/// </summary>
		// Token: 0x0600D27A RID: 53882 RVA: 0x00124FB4 File Offset: 0x001231B4
		public virtual void SetInputModelConnection(vtkAlgorithmOutput model)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetInputModelConnection_28(base.GetCppThis(), (model == null) ? default(HandleRef) : model.GetCppThis());
		}

		// Token: 0x0600D27B RID: 53883
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticsAlgorithm_SetLearnOption_29(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the Learn operation.
		/// </summary>
		// Token: 0x0600D27C RID: 53884 RVA: 0x00124FE3 File Offset: 0x001231E3
		public virtual void SetLearnOption(bool _arg)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetLearnOption_29(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600D27D RID: 53885
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticsAlgorithm_SetLearnOptionParameterConnection_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// A convenience method for setting learn input parameters (if one is expected or allowed).
		/// It is equivalent to calling SetInputConnection( 1, params );
		/// </summary>
		// Token: 0x0600D27E RID: 53886 RVA: 0x00124FFC File Offset: 0x001231FC
		public virtual void SetLearnOptionParameterConnection(vtkAlgorithmOutput arg0)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetLearnOptionParameterConnection_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D27F RID: 53887
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticsAlgorithm_SetLearnOptionParameters_31(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// A convenience method for setting learn input parameters (if one is expected or allowed).
		/// It is equivalent to calling SetInputData( 1, params );
		/// </summary>
		// Token: 0x0600D280 RID: 53888 RVA: 0x0012502C File Offset: 0x0012322C
		public virtual void SetLearnOptionParameters(vtkDataObject arg0)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetLearnOptionParameters_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D281 RID: 53889
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticsAlgorithm_SetNumberOfPrimaryTables_32(HandleRef pThis, long _arg);

		/// <summary>
		/// Set/Get the number of tables in the primary model.
		/// </summary>
		// Token: 0x0600D282 RID: 53890 RVA: 0x0012505B File Offset: 0x0012325B
		public virtual void SetNumberOfPrimaryTables(long _arg)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetNumberOfPrimaryTables_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D283 RID: 53891
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStatisticsAlgorithm_SetParameter_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string parameter, int index, HandleRef value);

		/// <summary>
		/// A convenience method (in particular for access from other applications) to
		/// set parameter values of Learn mode.
		/// Return true if setting of requested parameter name was executed, false otherwise.
		/// NB: default method (which is sufficient for most statistics algorithms) does not
		/// have any Learn parameters to set and always returns false.
		/// </summary>
		// Token: 0x0600D284 RID: 53892 RVA: 0x0012506C File Offset: 0x0012326C
		public virtual bool SetParameter(string parameter, int index, vtkVariant value)
		{
			return vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetParameter_33(base.GetCppThis(), parameter, index, (value == null) ? default(HandleRef) : value.GetCppThis()) != 0;
		}

		// Token: 0x0600D285 RID: 53893
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStatisticsAlgorithm_SetTestOption_34(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the Test operation.
		/// </summary>
		// Token: 0x0600D286 RID: 53894 RVA: 0x001250A9 File Offset: 0x001232A9
		public virtual void SetTestOption(bool _arg)
		{
			vtkStatisticsAlgorithm.vtkStatisticsAlgorithm_SetTestOption_34(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F88 RID: 3976
		public new const string MRFullTypeName = "Kitware.VTK.vtkStatisticsAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F89 RID: 3977
		public new static readonly string MRClassNameKey = "class vtkStatisticsAlgorithm";

		/// <summary>
		/// enumeration values to specify input port types
		/// </summary>
		// Token: 0x02000473 RID: 1139
		public enum InputPorts
		{
			/// <summary>enum member</summary>
			// Token: 0x04000F8B RID: 3979
			INPUT_DATA,
			/// <summary>enum member</summary>
			// Token: 0x04000F8C RID: 3980
			INPUT_MODEL = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000F8D RID: 3981
			LEARN_PARAMETERS = 1
		}

		/// <summary>
		/// enumeration values to specify output port types
		/// </summary>
		// Token: 0x02000474 RID: 1140
		public enum OutputIndices
		{
			/// <summary>enum member</summary>
			// Token: 0x04000F8F RID: 3983
			OUTPUT_DATA,
			/// <summary>enum member</summary>
			// Token: 0x04000F90 RID: 3984
			OUTPUT_MODEL,
			/// <summary>enum member</summary>
			// Token: 0x04000F91 RID: 3985
			OUTPUT_TEST
		}
	}
}
