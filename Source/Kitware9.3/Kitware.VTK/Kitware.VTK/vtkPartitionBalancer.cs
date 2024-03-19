using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkPartitionBalancer
	/// </summary>
	/// <remarks>
	///  Balances input partitioned data sets so each rank has the same number of data sets.
	///
	/// This filter can be applied on `vtkPartitionedDataSet` or `vtkPartitionedDataSetCollection`.
	///
	/// * Given an input `vtkPartitionedDataSet`, this filter adds
	/// `nullptr` instances in the output `vtkPartitionedDataSet` following a pattern specified
	/// as parameter. The output partitioned data set will have the same number of partitions across
	/// all ranks.
	/// * Given an input `vtkPartitionedDataSetCollection`, this filter is applied on each partitioned
	/// data set separately, and is producing a `vtkPartitioneDataSetCollection`.
	///
	/// If some input partitions are `nullptr`, the output will see this partition squeezed out.
	/// The filter will treat the input partitioned data set as if this `nullptr` partition was non
	/// existent.
	///
	/// The way the output is laid out is driven by the parameter `Mode`;
	/// * `Mode::Expand` generates, per partitioned data set, as many partitions as there are partitions
	/// in the input across all ranks.
	/// Given a valid partition (not `nullptr`) in the output partitioned data set at index
	/// n in rank i, all partitioned data set of all ranks but i have a `nullptr` instance as index n.
	/// Output partitions are sorted by rank number. i.e., for i &lt; j, partition at rank i are indexed
	/// before partitions of rank j. Here is an example. of what would be generated for a
	/// given input. PDC holds for Partitioned Dataset Collection, and PD holds for Partitioned Dataset.
	/// @verbatim
	/// Input:
	/// rank 0: PDC [ PD (DS0, DS1,     DS2) ] [PD (nullptr, DS100) ]
	/// rank 1: PDC [ PD (DS3, nullptr, DS4) ] [PD ()               ]
	///
	/// Output:
	/// rank 0: PDC [ PD (DS0,     DS1,     DS2,     nullptr, nullptr) ] [PD (DS100)   ]
	/// rank 1: PDC [ PD (nullptr, nullptr, nullptr, DS3,     DS4)     ] [PD (nullptr) ]
	/// @endverbatim
	/// * `Mode::Squash` generates, per input partitioned data set, the minimum number of partitions
	/// possible, appending `nullptr` in ranks lacking partitions. Using the same example as above:
	/// @verbatim
	/// Input:
	/// rank 0: PDC [ PD (DS0, DS1,     DS2) ] [PD (nullptr, DS100) ]
	/// rank 1: PDC [ PD (DS3, nullptr, DS4) ] [PD ()               ]
	///
	/// Output:
	/// rank 0: PDC [ PD (DS0, DS1, DS2)     ] [PD (DS100)   ]
	/// rank 1: PDC [ PD (DS3, DS4, nullptr) ] [PD (nullptr) ]
	/// @endverbatim
	/// </remarks>
	// Token: 0x0200052F RID: 1327
	public class vtkPartitionBalancer : vtkPartitionedDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600ED01 RID: 60673 RVA: 0x0014A6FF File Offset: 0x001488FF
		static vtkPartitionBalancer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPartitionBalancer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPartitionBalancer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600ED02 RID: 60674 RVA: 0x0014A727 File Offset: 0x00148927
		public vtkPartitionBalancer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600ED03 RID: 60675
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionBalancer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ED04 RID: 60676 RVA: 0x0014A738 File Offset: 0x00148938
		public new static vtkPartitionBalancer New()
		{
			vtkPartitionBalancer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionBalancer.vtkPartitionBalancer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPartitionBalancer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ED05 RID: 60677 RVA: 0x0014A78C File Offset: 0x0014898C
		public vtkPartitionBalancer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPartitionBalancer.vtkPartitionBalancer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600ED06 RID: 60678 RVA: 0x0014A7D0 File Offset: 0x001489D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600ED07 RID: 60679
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionBalancer_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the controller to use. By default
		/// vtkMultiProcessController::GlobalController will be used.
		/// </summary>
		// Token: 0x0600ED08 RID: 60680 RVA: 0x0014A7DC File Offset: 0x001489DC
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionBalancer.vtkPartitionBalancer_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600ED09 RID: 60681
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionBalancer_GetMode_02(HandleRef pThis);

		/// <summary>
		/// Set / Get current layout of the output. Default value is `vtkPartitionBalancer::Squash`.
		/// </summary>
		// Token: 0x0600ED0A RID: 60682 RVA: 0x0014A84C File Offset: 0x00148A4C
		public virtual int GetMode()
		{
			return vtkPartitionBalancer.vtkPartitionBalancer_GetMode_02(base.GetCppThis());
		}

		// Token: 0x0600ED0B RID: 60683
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionBalancer_GetModeMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Set / Get current layout of the output. Default value is `vtkPartitionBalancer::Squash`.
		/// </summary>
		// Token: 0x0600ED0C RID: 60684 RVA: 0x0014A86C File Offset: 0x00148A6C
		public virtual int GetModeMaxValue()
		{
			return vtkPartitionBalancer.vtkPartitionBalancer_GetModeMaxValue_03(base.GetCppThis());
		}

		// Token: 0x0600ED0D RID: 60685
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionBalancer_GetModeMinValue_04(HandleRef pThis);

		/// <summary>
		/// Set / Get current layout of the output. Default value is `vtkPartitionBalancer::Squash`.
		/// </summary>
		// Token: 0x0600ED0E RID: 60686 RVA: 0x0014A88C File Offset: 0x00148A8C
		public virtual int GetModeMinValue()
		{
			return vtkPartitionBalancer.vtkPartitionBalancer_GetModeMinValue_04(base.GetCppThis());
		}

		// Token: 0x0600ED0F RID: 60687
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPartitionBalancer_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ED10 RID: 60688 RVA: 0x0014A8AC File Offset: 0x00148AAC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPartitionBalancer.vtkPartitionBalancer_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600ED11 RID: 60689
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPartitionBalancer_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ED12 RID: 60690 RVA: 0x0014A8CC File Offset: 0x00148ACC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPartitionBalancer.vtkPartitionBalancer_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600ED13 RID: 60691
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionBalancer_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ED14 RID: 60692 RVA: 0x0014A8E8 File Offset: 0x00148AE8
		public override int IsA(string type)
		{
			return vtkPartitionBalancer.vtkPartitionBalancer_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600ED15 RID: 60693
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionBalancer_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ED16 RID: 60694 RVA: 0x0014A908 File Offset: 0x00148B08
		public new static int IsTypeOf(string type)
		{
			return vtkPartitionBalancer.vtkPartitionBalancer_IsTypeOf_08(type);
		}

		// Token: 0x0600ED17 RID: 60695
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionBalancer_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ED18 RID: 60696 RVA: 0x0014A924 File Offset: 0x00148B24
		public new vtkPartitionBalancer NewInstance()
		{
			vtkPartitionBalancer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionBalancer.vtkPartitionBalancer_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPartitionBalancer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600ED19 RID: 60697
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionBalancer_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ED1A RID: 60698 RVA: 0x0014A980 File Offset: 0x00148B80
		public new static vtkPartitionBalancer SafeDownCast(vtkObjectBase o)
		{
			vtkPartitionBalancer vtkPartitionBalancer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionBalancer.vtkPartitionBalancer_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPartitionBalancer = (vtkPartitionBalancer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPartitionBalancer.Register(null);
				}
			}
			return vtkPartitionBalancer;
		}

		// Token: 0x0600ED1B RID: 60699
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionBalancer_SetController_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the controller to use. By default
		/// vtkMultiProcessController::GlobalController will be used.
		/// </summary>
		// Token: 0x0600ED1C RID: 60700 RVA: 0x0014AA00 File Offset: 0x00148C00
		public void SetController(vtkMultiProcessController arg0)
		{
			vtkPartitionBalancer.vtkPartitionBalancer_SetController_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600ED1D RID: 60701
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionBalancer_SetMode_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Set / Get current layout of the output. Default value is `vtkPartitionBalancer::Squash`.
		/// </summary>
		// Token: 0x0600ED1E RID: 60702 RVA: 0x0014AA2F File Offset: 0x00148C2F
		public virtual void SetMode(int _arg)
		{
			vtkPartitionBalancer.vtkPartitionBalancer_SetMode_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ED1F RID: 60703
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionBalancer_SetModeToExpand_14(HandleRef pThis);

		/// <summary>
		/// Sets filter to expand mode. See example below.
		///
		/// @verbatim
		/// Input:
		/// rank 0: PDC [ PD (DS0, DS1,     DS2) ] [PD (nullptr, DS100) ]
		/// rank 1: PDC [ PD (DS3, nullptr, DS4) ] [PD ()               ]
		///
		/// Output:
		/// rank 0: PDC [ PD (DS0,     DS1,     DS2,     nullptr, nullptr) ] [PD (DS100)   ]
		/// rank 1: PDC [ PD (nullptr, nullptr, nullptr, DS3,     DS4)     ] [PD (nullptr) ]
		/// @endverbatim
		/// </summary>
		// Token: 0x0600ED20 RID: 60704 RVA: 0x0014AA3F File Offset: 0x00148C3F
		public void SetModeToExpand()
		{
			vtkPartitionBalancer.vtkPartitionBalancer_SetModeToExpand_14(base.GetCppThis());
		}

		// Token: 0x0600ED21 RID: 60705
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionBalancer_SetModeToSquash_15(HandleRef pThis);

		/// <summary>
		/// Sets filter to squash mode. See example below.
		///
		/// @verbatim
		/// Input:
		/// rank 0: PDC [ PD (DS0, DS1,     DS2) ] [PD (nullptr, DS100) ]
		/// rank 1: PDC [ PD (DS3, nullptr, DS4) ] [PD ()               ]
		///
		/// Output:
		/// rank 0: PDC [ PD (DS0, DS1, DS2)     ] [PD (DS100)   ]
		/// rank 1: PDC [ PD (DS3, DS4, nullptr) ] [PD (nullptr) ]
		/// @endverbatim
		/// </summary>
		// Token: 0x0600ED22 RID: 60706 RVA: 0x0014AA4E File Offset: 0x00148C4E
		public void SetModeToSquash()
		{
			vtkPartitionBalancer.vtkPartitionBalancer_SetModeToSquash_15(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001155 RID: 4437
		public new const string MRFullTypeName = "Kitware.VTK.vtkPartitionBalancer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001156 RID: 4438
		public new static readonly string MRClassNameKey = "class vtkPartitionBalancer";

		/// <summary>
		/// Modes defining the layout of the output.
		/// </summary>
		// Token: 0x02000530 RID: 1328
		public enum Mode
		{
			/// <summary>enum member</summary>
			// Token: 0x04001158 RID: 4440
			Expand,
			/// <summary>enum member</summary>
			// Token: 0x04001159 RID: 4441
			Squash
		}
	}
}
