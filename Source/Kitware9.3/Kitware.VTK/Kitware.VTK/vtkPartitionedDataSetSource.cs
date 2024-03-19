using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkPartitionedDataSetSource
	/// </summary>
	/// <remarks>
	///  a source that produces a vtkPartitionedDataSet.
	///
	/// vtkPartitionedDataSetSource generates a vtkPartitionedDataSet which is
	/// composed of partitions of a given vtkParametricFunction.
	/// The resulting partitioned dataset is split among ranks in an even fashion
	/// by default.
	///
	/// The user can pass the parametric function to be used using SetParametricFunction.
	/// Otherwise it will default to vtkParametricKlein as its Parametric function.
	///
	/// The partitioning scheme for the produced vtkPartitionedDataSet can be controlled
	/// with the methods: SetNumberOfPartitiones, EnableRank, DisableRank, EnableAllRanks,
	/// DisableAllRanks.
	///
	/// @see vtkParametricFunction
	/// @see vtkPartitionedDataSet
	/// </remarks>
	// Token: 0x02000833 RID: 2099
	public class vtkPartitionedDataSetSource : vtkPartitionedDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015B7A RID: 88954 RVA: 0x001EA58D File Offset: 0x001E878D
		static vtkPartitionedDataSetSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPartitionedDataSetSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPartitionedDataSetSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015B7B RID: 88955 RVA: 0x001EA5B5 File Offset: 0x001E87B5
		public vtkPartitionedDataSetSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015B7C RID: 88956
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B7D RID: 88957 RVA: 0x001EA5C4 File Offset: 0x001E87C4
		public new static vtkPartitionedDataSetSource New()
		{
			vtkPartitionedDataSetSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPartitionedDataSetSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B7E RID: 88958 RVA: 0x001EA618 File Offset: 0x001E8818
		public vtkPartitionedDataSetSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015B7F RID: 88959 RVA: 0x001EA65C File Offset: 0x001E885C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015B80 RID: 88960
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetSource_DisableAllRanks_01(HandleRef pThis);

		/// <summary>
		/// Enable/Disable ranks.
		///
		/// By default every rank is enabled, this default policy will be
		/// changed if DisableAllRanks is used, and again reverted when
		/// EnableAllRanks is used.
		///
		/// EnableRank/DisableRank are used to specify individual exceptions
		/// of the default policy.
		/// </summary>
		// Token: 0x06015B81 RID: 88961 RVA: 0x001EA667 File Offset: 0x001E8867
		public void DisableAllRanks()
		{
			vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_DisableAllRanks_01(base.GetCppThis());
		}

		// Token: 0x06015B82 RID: 88962
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetSource_DisableRank_02(HandleRef pThis, int rank);

		/// <summary>
		/// Enable/Disable ranks.
		///
		/// By default every rank is enabled, this default policy will be
		/// changed if DisableAllRanks is used, and again reverted when
		/// EnableAllRanks is used.
		///
		/// EnableRank/DisableRank are used to specify individual exceptions
		/// of the default policy.
		/// </summary>
		// Token: 0x06015B83 RID: 88963 RVA: 0x001EA676 File Offset: 0x001E8876
		public void DisableRank(int rank)
		{
			vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_DisableRank_02(base.GetCppThis(), rank);
		}

		// Token: 0x06015B84 RID: 88964
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetSource_EnableAllRanks_03(HandleRef pThis);

		/// <summary>
		/// Enable/Disable ranks.
		///
		/// By default every rank is enabled, this default policy will be
		/// changed if DisableAllRanks is used, and again reverted when
		/// EnableAllRanks is used.
		///
		/// EnableRank/DisableRank are used to specify individual exceptions
		/// of the default policy.
		/// </summary>
		// Token: 0x06015B85 RID: 88965 RVA: 0x001EA686 File Offset: 0x001E8886
		public void EnableAllRanks()
		{
			vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_EnableAllRanks_03(base.GetCppThis());
		}

		// Token: 0x06015B86 RID: 88966
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetSource_EnableRank_04(HandleRef pThis, int rank);

		/// <summary>
		/// Enable/Disable ranks.
		///
		/// By default every rank is enabled, this default policy will be
		/// changed if DisableAllRanks is used, and again reverted when
		/// EnableAllRanks is used.
		///
		/// EnableRank/DisableRank are used to specify individual exceptions
		/// of the default policy.
		/// </summary>
		// Token: 0x06015B87 RID: 88967 RVA: 0x001EA695 File Offset: 0x001E8895
		public void EnableRank(int rank)
		{
			vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_EnableRank_04(base.GetCppThis(), rank);
		}

		// Token: 0x06015B88 RID: 88968
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPartitionedDataSetSource_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B89 RID: 88969 RVA: 0x001EA6A8 File Offset: 0x001E88A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06015B8A RID: 88970
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPartitionedDataSetSource_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B8B RID: 88971 RVA: 0x001EA6C8 File Offset: 0x001E88C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06015B8C RID: 88972
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetSource_GetNumberOfPartitions_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of partitions of the resulting PartitionedDataSet.
		/// If not specified, the number of partitions will be the number of enabled
		/// ranks.
		///
		/// SetNumberOfPartitions(0) means auto in this context, the implementation
		/// will decided the optimal number of partitions which by default will be
		/// one partition per each rank.
		/// </summary>
		// Token: 0x06015B8D RID: 88973 RVA: 0x001EA6E4 File Offset: 0x001E88E4
		public virtual int GetNumberOfPartitions()
		{
			return vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_GetNumberOfPartitions_07(base.GetCppThis());
		}

		// Token: 0x06015B8E RID: 88974
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetSource_GetNumberOfPartitionsMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of partitions of the resulting PartitionedDataSet.
		/// If not specified, the number of partitions will be the number of enabled
		/// ranks.
		///
		/// SetNumberOfPartitions(0) means auto in this context, the implementation
		/// will decided the optimal number of partitions which by default will be
		/// one partition per each rank.
		/// </summary>
		// Token: 0x06015B8F RID: 88975 RVA: 0x001EA704 File Offset: 0x001E8904
		public virtual int GetNumberOfPartitionsMaxValue()
		{
			return vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_GetNumberOfPartitionsMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06015B90 RID: 88976
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetSource_GetNumberOfPartitionsMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of partitions of the resulting PartitionedDataSet.
		/// If not specified, the number of partitions will be the number of enabled
		/// ranks.
		///
		/// SetNumberOfPartitions(0) means auto in this context, the implementation
		/// will decided the optimal number of partitions which by default will be
		/// one partition per each rank.
		/// </summary>
		// Token: 0x06015B91 RID: 88977 RVA: 0x001EA724 File Offset: 0x001E8924
		public virtual int GetNumberOfPartitionsMinValue()
		{
			return vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_GetNumberOfPartitionsMinValue_09(base.GetCppThis());
		}

		// Token: 0x06015B92 RID: 88978
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetSource_GetParametricFunction_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the parametric function to be used for this source.
		/// </summary>
		// Token: 0x06015B93 RID: 88979 RVA: 0x001EA744 File Offset: 0x001E8944
		public virtual vtkParametricFunction GetParametricFunction()
		{
			vtkParametricFunction vtkParametricFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_GetParametricFunction_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricFunction = (vtkParametricFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricFunction.Register(null);
				}
			}
			return vtkParametricFunction;
		}

		// Token: 0x06015B94 RID: 88980
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetSource_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B95 RID: 88981 RVA: 0x001EA7B4 File Offset: 0x001E89B4
		public override int IsA(string type)
		{
			return vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06015B96 RID: 88982
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPartitionedDataSetSource_IsEnabledRank_12(HandleRef pThis, int rank);

		/// <summary>
		/// Enable/Disable ranks.
		///
		/// By default every rank is enabled, this default policy will be
		/// changed if DisableAllRanks is used, and again reverted when
		/// EnableAllRanks is used.
		///
		/// EnableRank/DisableRank are used to specify individual exceptions
		/// of the default policy.
		/// </summary>
		// Token: 0x06015B97 RID: 88983 RVA: 0x001EA7D4 File Offset: 0x001E89D4
		public bool IsEnabledRank(int rank)
		{
			return vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_IsEnabledRank_12(base.GetCppThis(), rank) != 0;
		}

		// Token: 0x06015B98 RID: 88984
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetSource_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B99 RID: 88985 RVA: 0x001EA7FC File Offset: 0x001E89FC
		public new static int IsTypeOf(string type)
		{
			return vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_IsTypeOf_13(type);
		}

		// Token: 0x06015B9A RID: 88986
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetSource_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B9B RID: 88987 RVA: 0x001EA818 File Offset: 0x001E8A18
		public new vtkPartitionedDataSetSource NewInstance()
		{
			vtkPartitionedDataSetSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPartitionedDataSetSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015B9C RID: 88988
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetSource_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015B9D RID: 88989 RVA: 0x001EA874 File Offset: 0x001E8A74
		public new static vtkPartitionedDataSetSource SafeDownCast(vtkObjectBase o)
		{
			vtkPartitionedDataSetSource vtkPartitionedDataSetSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPartitionedDataSetSource = (vtkPartitionedDataSetSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPartitionedDataSetSource.Register(null);
				}
			}
			return vtkPartitionedDataSetSource;
		}

		// Token: 0x06015B9E RID: 88990
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetSource_SetNumberOfPartitions_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of partitions of the resulting PartitionedDataSet.
		/// If not specified, the number of partitions will be the number of enabled
		/// ranks.
		///
		/// SetNumberOfPartitions(0) means auto in this context, the implementation
		/// will decided the optimal number of partitions which by default will be
		/// one partition per each rank.
		/// </summary>
		// Token: 0x06015B9F RID: 88991 RVA: 0x001EA8F3 File Offset: 0x001E8AF3
		public virtual void SetNumberOfPartitions(int _arg)
		{
			vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_SetNumberOfPartitions_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06015BA0 RID: 88992
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetSource_SetParametricFunction_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the parametric function to be used for this source.
		/// </summary>
		// Token: 0x06015BA1 RID: 88993 RVA: 0x001EA904 File Offset: 0x001E8B04
		public void SetParametricFunction(vtkParametricFunction arg0)
		{
			vtkPartitionedDataSetSource.vtkPartitionedDataSetSource_SetParametricFunction_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018BD RID: 6333
		public new const string MRFullTypeName = "Kitware.VTK.vtkPartitionedDataSetSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018BE RID: 6334
		public new static readonly string MRClassNameKey = "class vtkPartitionedDataSetSource";
	}
}
