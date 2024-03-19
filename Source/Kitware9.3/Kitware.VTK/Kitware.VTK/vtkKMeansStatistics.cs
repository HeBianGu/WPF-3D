using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkKMeansStatistics
	/// </summary>
	/// <remarks>
	///    A class for KMeans clustering
	///
	///
	/// This class takes as input an optional vtkTable on port LEARN_PARAMETERS
	/// specifying initial  set(s) of cluster values of the following form:
	/// &lt;pre&gt;
	///           K     | Col1            |  ...    | ColN
	///      -----------+-----------------+---------+---------------
	///           M     |clustCoord(1, 1) |  ...    | clustCoord(1, N)
	///           M     |clustCoord(2, 1) |  ...    | clustCoord(2, N)
	///           .     |       .         |   .     |        .
	///           .     |       .         |   .     |        .
	///           .     |       .         |   .     |        .
	///           M     |clustCoord(M, 1) |  ...    | clustCoord(M, N)
	///           L     |clustCoord(1, 1) |  ...    | clustCoord(1, N)
	///           L     |clustCoord(2, 1) |  ...    | clustCoord(2, N)
	///           .     |       .         |   .     |        .
	///           .     |       .         |   .     |        .
	///           .     |       .         |   .     |        .
	///           L     |clustCoord(L, 1) |  ...    | clustCoord(L, N)
	/// &lt;/pre&gt;
	///
	/// Because the desired value of K is often not known in advance and the
	/// results of the algorithm are dependent on the initial cluster centers,
	/// we provide a mechanism for the user to test multiple runs or sets of cluster centers
	/// within a single call to the Learn phase.  The first column of the table identifies
	/// the number of clusters K in the particular run (the entries in this column should be
	/// of type vtkIdType), while the remaining columns are a
	/// subset of the columns contained in the table on port INPUT_DATA.  We require that
	/// all user specified clusters be of the same dimension N and consequently, that the
	/// LEARN_PARAMETERS table have N+1 columns. Due to this restriction, only one request
	/// can be processed for each call to the Learn phase and subsequent requests are
	/// silently ignored. Note that, if the first column of the LEARN_PARAMETERS table is not
	/// of type vtkIdType, then the table will be ignored and a single run will be performed using
	/// the first DefaultNumberOfClusters input data observations as initial cluster centers.
	///
	/// When the user does not supply an initial set of clusters, then the first
	/// DefaultNumberOfClusters input data observations are used as initial cluster
	/// centers and a single run is performed.
	///
	///
	/// This class provides the following functionalities, depending on the operation
	/// in which it is executed:
	/// * Learn: calculates new cluster centers for each run.  The output metadata on
	///   port OUTPUT_MODEL is a multiblock dataset containing at a minimum
	///   one vtkTable with columns specifying the following for each run:
	///   the run ID, number of clusters, number of iterations required for convergence,
	///   total error associated with the cluster (sum of squared Euclidean distance from each
	/// observation to its nearest cluster center), the cardinality of the cluster, and the new cluster
	/// coordinates.
	///
	/// * Derive:  An additional vtkTable is stored in the multiblock dataset output on port
	/// OUTPUT_MODEL. This table contains columns that store for each run: the runID, number of clusters,
	///   total error for all clusters in the run, local rank, and global rank.
	///   The local rank is computed by comparing squared Euclidean errors of all runs with
	///   the same number of clusters.  The global rank is computed analagously across all runs.
	///
	/// * Assess: This requires a multiblock dataset (as computed from Learn and Derive) on input port
	/// INPUT_MODEL and tabular data on input port INPUT_DATA that contains column names matching those
	///   of the tables on input port INPUT_MODEL. The assess mode reports the closest cluster center
	///   and associated squared Euclidean distance of each observation in port INPUT_DATA's table to the
	/// cluster centers for each run in the multiblock dataset provided on port INPUT_MODEL.
	///
	/// The code can handle a wide variety of data types as it operates on vtkAbstractArrays
	/// and is not limited to vtkDataArrays.  A default distance functor that
	/// computes the sum of the squares of the Euclidean distance between two objects is provided
	/// (vtkKMeansDistanceFunctor). The default distance functor can be overridden to use alternative
	/// distance metrics.
	///
	/// @par Thanks:
	/// Thanks to Janine Bennett, David Thompson, and Philippe Pebay of
	/// Sandia National Laboratories for implementing this class.
	/// Updated by Philippe Pebay, Kitware SAS 2012
	/// </remarks>
	// Token: 0x02000748 RID: 1864
	public class vtkKMeansStatistics : vtkStatisticsAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060135FB RID: 79355 RVA: 0x001B688F File Offset: 0x001B4A8F
		static vtkKMeansStatistics()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKMeansStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKMeansStatistics"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060135FC RID: 79356 RVA: 0x001B68B7 File Offset: 0x001B4AB7
		public vtkKMeansStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060135FD RID: 79357
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKMeansStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135FE RID: 79358 RVA: 0x001B68C8 File Offset: 0x001B4AC8
		public new static vtkKMeansStatistics New()
		{
			vtkKMeansStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKMeansStatistics.vtkKMeansStatistics_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKMeansStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135FF RID: 79359 RVA: 0x001B691C File Offset: 0x001B4B1C
		public vtkKMeansStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkKMeansStatistics.vtkKMeansStatistics_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013600 RID: 79360 RVA: 0x001B6960 File Offset: 0x001B4B60
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013601 RID: 79361
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKMeansStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Given a collection of models, calculate aggregate model
		/// NB: not implemented
		/// </summary>
		// Token: 0x06013602 RID: 79362 RVA: 0x001B696C File Offset: 0x001B4B6C
		public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkKMeansStatistics.vtkKMeansStatistics_Aggregate_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06013603 RID: 79363
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKMeansStatistics_GetDefaultNumberOfClusters_02(HandleRef pThis);

		/// <summary>
		/// Set/get the \a DefaultNumberOfClusters, used when no initial cluster coordinates are specified.
		/// </summary>
		// Token: 0x06013604 RID: 79364 RVA: 0x001B69B0 File Offset: 0x001B4BB0
		public virtual int GetDefaultNumberOfClusters()
		{
			return vtkKMeansStatistics.vtkKMeansStatistics_GetDefaultNumberOfClusters_02(base.GetCppThis());
		}

		// Token: 0x06013605 RID: 79365
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKMeansStatistics_GetDistanceFunctor_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the DistanceFunctor.
		/// </summary>
		// Token: 0x06013606 RID: 79366 RVA: 0x001B69D0 File Offset: 0x001B4BD0
		public virtual vtkKMeansDistanceFunctor GetDistanceFunctor()
		{
			vtkKMeansDistanceFunctor vtkKMeansDistanceFunctor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKMeansStatistics.vtkKMeansStatistics_GetDistanceFunctor_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKMeansDistanceFunctor = (vtkKMeansDistanceFunctor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKMeansDistanceFunctor.Register(null);
				}
			}
			return vtkKMeansDistanceFunctor;
		}

		// Token: 0x06013607 RID: 79367
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkKMeansStatistics_GetGhostsToSkip_04(HandleRef pThis);

		/// <summary>
		/// If there is a ghost array in the input, then ghosts matching `GhostsToSkip` mask
		/// will be skipped. It is set to 0xff by default (every ghosts types are skipped).
		///
		/// @sa
		/// vtkDataSetAttributes
		/// vtkFieldData
		/// vtkPointData
		/// vtkCellData
		/// </summary>
		// Token: 0x06013608 RID: 79368 RVA: 0x001B6A40 File Offset: 0x001B4C40
		public virtual byte GetGhostsToSkip()
		{
			return vtkKMeansStatistics.vtkKMeansStatistics_GetGhostsToSkip_04(base.GetCppThis());
		}

		// Token: 0x06013609 RID: 79369
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKMeansStatistics_GetKValuesArrayName_05(HandleRef pThis);

		/// <summary>
		/// Set/get the KValuesArrayName.
		/// </summary>
		// Token: 0x0601360A RID: 79370 RVA: 0x001B6A60 File Offset: 0x001B4C60
		public virtual string GetKValuesArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkKMeansStatistics.vtkKMeansStatistics_GetKValuesArrayName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601360B RID: 79371
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKMeansStatistics_GetMaxNumIterations_06(HandleRef pThis);

		/// <summary>
		/// Set/get the MaxNumIterations used to terminate iterations on
		/// cluster center coordinates when the relative tolerance can not be met.
		/// </summary>
		// Token: 0x0601360C RID: 79372 RVA: 0x001B6A9C File Offset: 0x001B4C9C
		public virtual int GetMaxNumIterations()
		{
			return vtkKMeansStatistics.vtkKMeansStatistics_GetMaxNumIterations_06(base.GetCppThis());
		}

		// Token: 0x0601360D RID: 79373
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKMeansStatistics_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601360E RID: 79374 RVA: 0x001B6ABC File Offset: 0x001B4CBC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkKMeansStatistics.vtkKMeansStatistics_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601360F RID: 79375
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKMeansStatistics_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013610 RID: 79376 RVA: 0x001B6ADC File Offset: 0x001B4CDC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkKMeansStatistics.vtkKMeansStatistics_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06013611 RID: 79377
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkKMeansStatistics_GetTolerance_09(HandleRef pThis);

		/// <summary>
		/// Set/get the relative \a Tolerance used to terminate iterations on
		/// cluster center coordinates.
		/// </summary>
		// Token: 0x06013612 RID: 79378 RVA: 0x001B6AF8 File Offset: 0x001B4CF8
		public virtual double GetTolerance()
		{
			return vtkKMeansStatistics.vtkKMeansStatistics_GetTolerance_09(base.GetCppThis());
		}

		// Token: 0x06013613 RID: 79379
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKMeansStatistics_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013614 RID: 79380 RVA: 0x001B6B18 File Offset: 0x001B4D18
		public override int IsA(string type)
		{
			return vtkKMeansStatistics.vtkKMeansStatistics_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06013615 RID: 79381
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKMeansStatistics_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013616 RID: 79382 RVA: 0x001B6B38 File Offset: 0x001B4D38
		public new static int IsTypeOf(string type)
		{
			return vtkKMeansStatistics.vtkKMeansStatistics_IsTypeOf_11(type);
		}

		// Token: 0x06013617 RID: 79383
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKMeansStatistics_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013618 RID: 79384 RVA: 0x001B6B54 File Offset: 0x001B4D54
		public new vtkKMeansStatistics NewInstance()
		{
			vtkKMeansStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKMeansStatistics.vtkKMeansStatistics_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKMeansStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013619 RID: 79385
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKMeansStatistics_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601361A RID: 79386 RVA: 0x001B6BB0 File Offset: 0x001B4DB0
		public new static vtkKMeansStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkKMeansStatistics vtkKMeansStatistics = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKMeansStatistics.vtkKMeansStatistics_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKMeansStatistics = (vtkKMeansStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKMeansStatistics.Register(null);
				}
			}
			return vtkKMeansStatistics;
		}

		// Token: 0x0601361B RID: 79387
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKMeansStatistics_SetDefaultNumberOfClusters_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the \a DefaultNumberOfClusters, used when no initial cluster coordinates are specified.
		/// </summary>
		// Token: 0x0601361C RID: 79388 RVA: 0x001B6C2F File Offset: 0x001B4E2F
		public virtual void SetDefaultNumberOfClusters(int _arg)
		{
			vtkKMeansStatistics.vtkKMeansStatistics_SetDefaultNumberOfClusters_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0601361D RID: 79389
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKMeansStatistics_SetDistanceFunctor_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the DistanceFunctor.
		/// </summary>
		// Token: 0x0601361E RID: 79390 RVA: 0x001B6C40 File Offset: 0x001B4E40
		public virtual void SetDistanceFunctor(vtkKMeansDistanceFunctor arg0)
		{
			vtkKMeansStatistics.vtkKMeansStatistics_SetDistanceFunctor_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601361F RID: 79391
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKMeansStatistics_SetGhostsToSkip_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// If there is a ghost array in the input, then ghosts matching `GhostsToSkip` mask
		/// will be skipped. It is set to 0xff by default (every ghosts types are skipped).
		///
		/// @sa
		/// vtkDataSetAttributes
		/// vtkFieldData
		/// vtkPointData
		/// vtkCellData
		/// </summary>
		// Token: 0x06013620 RID: 79392 RVA: 0x001B6C6F File Offset: 0x001B4E6F
		public virtual void SetGhostsToSkip(byte _arg)
		{
			vtkKMeansStatistics.vtkKMeansStatistics_SetGhostsToSkip_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06013621 RID: 79393
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKMeansStatistics_SetKValuesArrayName_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the KValuesArrayName.
		/// </summary>
		// Token: 0x06013622 RID: 79394 RVA: 0x001B6C7F File Offset: 0x001B4E7F
		public virtual void SetKValuesArrayName(string _arg)
		{
			vtkKMeansStatistics.vtkKMeansStatistics_SetKValuesArrayName_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06013623 RID: 79395
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKMeansStatistics_SetMaxNumIterations_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the MaxNumIterations used to terminate iterations on
		/// cluster center coordinates when the relative tolerance can not be met.
		/// </summary>
		// Token: 0x06013624 RID: 79396 RVA: 0x001B6C8F File Offset: 0x001B4E8F
		public virtual void SetMaxNumIterations(int _arg)
		{
			vtkKMeansStatistics.vtkKMeansStatistics_SetMaxNumIterations_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06013625 RID: 79397
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkKMeansStatistics_SetParameter_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string parameter, int index, HandleRef value);

		/// <summary>
		/// A convenience method for setting properties by name.
		/// </summary>
		// Token: 0x06013626 RID: 79398 RVA: 0x001B6CA0 File Offset: 0x001B4EA0
		public override bool SetParameter(string parameter, int index, vtkVariant value)
		{
			return vtkKMeansStatistics.vtkKMeansStatistics_SetParameter_20(base.GetCppThis(), parameter, index, (value == null) ? default(HandleRef) : value.GetCppThis()) != 0;
		}

		// Token: 0x06013627 RID: 79399
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKMeansStatistics_SetTolerance_21(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the relative \a Tolerance used to terminate iterations on
		/// cluster center coordinates.
		/// </summary>
		// Token: 0x06013628 RID: 79400 RVA: 0x001B6CDD File Offset: 0x001B4EDD
		public virtual void SetTolerance(double _arg)
		{
			vtkKMeansStatistics.vtkKMeansStatistics_SetTolerance_21(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001660 RID: 5728
		public new const string MRFullTypeName = "Kitware.VTK.vtkKMeansStatistics";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001661 RID: 5729
		public new static readonly string MRClassNameKey = "class vtkKMeansStatistics";
	}
}
