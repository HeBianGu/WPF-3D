using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPeriodicFilter
	/// </summary>
	/// <remarks>
	///    A filter to produce mapped  periodic
	/// multiblock dataset from a single block
	///
	///
	/// Generate periodic dataset by transforming points, vectors, tensors
	/// data arrays from an original data array.
	/// The generated dataset is of the same type than the input (float or double).
	/// This is an abstract class which do not implement the actual transformation.
	/// Point coordinates are transformed, as well as all vectors (3-components) and
	/// tensors (9 components) in points and cell data arrays.
	/// The generated multiblock will have the same tree architecture than the input,
	/// except transformed leaves are replaced by a vtkMultipieceDataSet.
	/// Supported input leaf dataset type are: vtkPolyData, vtkStructuredGrid
	/// and vtkUnstructuredGrid. Other data objects are transformed using the
	/// transform filter (at a high cost!).
	/// </remarks>
	// Token: 0x020004F6 RID: 1270
	public abstract class vtkPeriodicFilter : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E4C9 RID: 58569 RVA: 0x0013EB81 File Offset: 0x0013CD81
		static vtkPeriodicFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPeriodicFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPeriodicFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E4CA RID: 58570 RVA: 0x0013EBA9 File Offset: 0x0013CDA9
		public vtkPeriodicFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E4CB RID: 58571 RVA: 0x0013EBB7 File Offset: 0x0013CDB7
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E4CC RID: 58572
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPeriodicFilter_AddIndex_01(HandleRef pThis, uint index);

		/// <summary>
		/// Select the periodic pieces indices.
		/// Each node in the multi - block tree is identified by an \c index. The index can
		/// be obtained by performing a preorder traversal of the tree (including empty
		/// nodes). eg. A(B (D, E), C(F, G)).
		/// Inorder traversal yields: A, B, D, E, C, F, G
		/// Index of A is 0, while index of C is 4.
		/// </summary>
		// Token: 0x0600E4CD RID: 58573 RVA: 0x0013EBC2 File Offset: 0x0013CDC2
		public virtual void AddIndex(uint index)
		{
			vtkPeriodicFilter.vtkPeriodicFilter_AddIndex_01(base.GetCppThis(), index);
		}

		// Token: 0x0600E4CE RID: 58574
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPeriodicFilter_GetIterationMode_02(HandleRef pThis);

		/// <summary>
		/// Set/Get Iteration mode.
		/// VTK_ITERATION_MODE_DIRECT_NB to specify the number of periods,
		/// VTK_ITERATION_MODE_MAX to generate a full period (default).
		/// </summary>
		// Token: 0x0600E4CF RID: 58575 RVA: 0x0013EBD4 File Offset: 0x0013CDD4
		public virtual int GetIterationMode()
		{
			return vtkPeriodicFilter.vtkPeriodicFilter_GetIterationMode_02(base.GetCppThis());
		}

		// Token: 0x0600E4D0 RID: 58576
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPeriodicFilter_GetIterationModeMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Set/Get Iteration mode.
		/// VTK_ITERATION_MODE_DIRECT_NB to specify the number of periods,
		/// VTK_ITERATION_MODE_MAX to generate a full period (default).
		/// </summary>
		// Token: 0x0600E4D1 RID: 58577 RVA: 0x0013EBF4 File Offset: 0x0013CDF4
		public virtual int GetIterationModeMaxValue()
		{
			return vtkPeriodicFilter.vtkPeriodicFilter_GetIterationModeMaxValue_03(base.GetCppThis());
		}

		// Token: 0x0600E4D2 RID: 58578
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPeriodicFilter_GetIterationModeMinValue_04(HandleRef pThis);

		/// <summary>
		/// Set/Get Iteration mode.
		/// VTK_ITERATION_MODE_DIRECT_NB to specify the number of periods,
		/// VTK_ITERATION_MODE_MAX to generate a full period (default).
		/// </summary>
		// Token: 0x0600E4D3 RID: 58579 RVA: 0x0013EC14 File Offset: 0x0013CE14
		public virtual int GetIterationModeMinValue()
		{
			return vtkPeriodicFilter.vtkPeriodicFilter_GetIterationModeMinValue_04(base.GetCppThis());
		}

		// Token: 0x0600E4D4 RID: 58580
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPeriodicFilter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4D5 RID: 58581 RVA: 0x0013EC34 File Offset: 0x0013CE34
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPeriodicFilter.vtkPeriodicFilter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600E4D6 RID: 58582
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPeriodicFilter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4D7 RID: 58583 RVA: 0x0013EC54 File Offset: 0x0013CE54
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPeriodicFilter.vtkPeriodicFilter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600E4D8 RID: 58584
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPeriodicFilter_GetNumberOfPeriods_07(HandleRef pThis);

		/// <summary>
		/// Set/Get Number of periods.
		/// Used only with ITERATION_MODE_DIRECT_NB.
		/// </summary>
		// Token: 0x0600E4D9 RID: 58585 RVA: 0x0013EC70 File Offset: 0x0013CE70
		public virtual int GetNumberOfPeriods()
		{
			return vtkPeriodicFilter.vtkPeriodicFilter_GetNumberOfPeriods_07(base.GetCppThis());
		}

		// Token: 0x0600E4DA RID: 58586
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPeriodicFilter_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4DB RID: 58587 RVA: 0x0013EC90 File Offset: 0x0013CE90
		public override int IsA(string type)
		{
			return vtkPeriodicFilter.vtkPeriodicFilter_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600E4DC RID: 58588
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPeriodicFilter_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4DD RID: 58589 RVA: 0x0013ECB0 File Offset: 0x0013CEB0
		public new static int IsTypeOf(string type)
		{
			return vtkPeriodicFilter.vtkPeriodicFilter_IsTypeOf_09(type);
		}

		// Token: 0x0600E4DE RID: 58590
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPeriodicFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4DF RID: 58591 RVA: 0x0013ECCC File Offset: 0x0013CECC
		public new vtkPeriodicFilter NewInstance()
		{
			vtkPeriodicFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPeriodicFilter.vtkPeriodicFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPeriodicFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E4E0 RID: 58592
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPeriodicFilter_RemoveAllIndices_11(HandleRef pThis);

		/// <summary>
		/// Clear selected indices tree
		/// </summary>
		// Token: 0x0600E4E1 RID: 58593 RVA: 0x0013ED26 File Offset: 0x0013CF26
		public virtual void RemoveAllIndices()
		{
			vtkPeriodicFilter.vtkPeriodicFilter_RemoveAllIndices_11(base.GetCppThis());
		}

		// Token: 0x0600E4E2 RID: 58594
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPeriodicFilter_RemoveIndex_12(HandleRef pThis, uint index);

		/// <summary>
		/// Remove an index from selected indices tress
		/// </summary>
		// Token: 0x0600E4E3 RID: 58595 RVA: 0x0013ED35 File Offset: 0x0013CF35
		public virtual void RemoveIndex(uint index)
		{
			vtkPeriodicFilter.vtkPeriodicFilter_RemoveIndex_12(base.GetCppThis(), index);
		}

		// Token: 0x0600E4E4 RID: 58596
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPeriodicFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4E5 RID: 58597 RVA: 0x0013ED48 File Offset: 0x0013CF48
		public new static vtkPeriodicFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPeriodicFilter vtkPeriodicFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPeriodicFilter.vtkPeriodicFilter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPeriodicFilter = (vtkPeriodicFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPeriodicFilter.Register(null);
				}
			}
			return vtkPeriodicFilter;
		}

		// Token: 0x0600E4E6 RID: 58598
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPeriodicFilter_SetIterationMode_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get Iteration mode.
		/// VTK_ITERATION_MODE_DIRECT_NB to specify the number of periods,
		/// VTK_ITERATION_MODE_MAX to generate a full period (default).
		/// </summary>
		// Token: 0x0600E4E7 RID: 58599 RVA: 0x0013EDC7 File Offset: 0x0013CFC7
		public virtual void SetIterationMode(int _arg)
		{
			vtkPeriodicFilter.vtkPeriodicFilter_SetIterationMode_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E4E8 RID: 58600
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPeriodicFilter_SetIterationModeToDirectNb_15(HandleRef pThis);

		/// <summary>
		/// Set/Get Iteration mode.
		/// VTK_ITERATION_MODE_DIRECT_NB to specify the number of periods,
		/// VTK_ITERATION_MODE_MAX to generate a full period (default).
		/// </summary>
		// Token: 0x0600E4E9 RID: 58601 RVA: 0x0013EDD7 File Offset: 0x0013CFD7
		public void SetIterationModeToDirectNb()
		{
			vtkPeriodicFilter.vtkPeriodicFilter_SetIterationModeToDirectNb_15(base.GetCppThis());
		}

		// Token: 0x0600E4EA RID: 58602
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPeriodicFilter_SetIterationModeToMax_16(HandleRef pThis);

		/// <summary>
		/// Set/Get Iteration mode.
		/// VTK_ITERATION_MODE_DIRECT_NB to specify the number of periods,
		/// VTK_ITERATION_MODE_MAX to generate a full period (default).
		/// </summary>
		// Token: 0x0600E4EB RID: 58603 RVA: 0x0013EDE6 File Offset: 0x0013CFE6
		public void SetIterationModeToMax()
		{
			vtkPeriodicFilter.vtkPeriodicFilter_SetIterationModeToMax_16(base.GetCppThis());
		}

		// Token: 0x0600E4EC RID: 58604
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPeriodicFilter_SetNumberOfPeriods_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get Number of periods.
		/// Used only with ITERATION_MODE_DIRECT_NB.
		/// </summary>
		// Token: 0x0600E4ED RID: 58605 RVA: 0x0013EDF5 File Offset: 0x0013CFF5
		public virtual void SetNumberOfPeriods(int _arg)
		{
			vtkPeriodicFilter.vtkPeriodicFilter_SetNumberOfPeriods_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010D1 RID: 4305
		public new const string MRFullTypeName = "Kitware.VTK.vtkPeriodicFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010D2 RID: 4306
		public new static readonly string MRClassNameKey = "class vtkPeriodicFilter";
	}
}
