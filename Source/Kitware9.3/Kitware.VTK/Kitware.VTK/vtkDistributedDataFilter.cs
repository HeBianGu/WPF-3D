using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDistributedDataFilter
	/// </summary>
	/// <remarks>
	///    Serial stand-in for parallel filter that distributes data among processors
	///
	/// This filter is a serial implementation of the vtkPDistributedDataFilter
	/// filter with the intent that it can be used in non-MPI builds. This filter
	/// acts almost as a "pass-through" filter when run in serial, though when the
	/// input is a non-composite dataset, the output will be an vtkUnstructuredGrid
	/// to be consistent with the parallel filter. The combination of this filter and
	/// its parallel counterpart serves to unify the API for serial and parallel
	/// builds.
	///
	/// </remarks>
	/// <seealso>
	///  vtkPDistributedDataFilter
	/// </seealso>
	// Token: 0x020004FD RID: 1277
	public class vtkDistributedDataFilter : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E5D8 RID: 58840 RVA: 0x001402F5 File Offset: 0x0013E4F5
		static vtkDistributedDataFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDistributedDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistributedDataFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E5D9 RID: 58841 RVA: 0x0014031D File Offset: 0x0013E51D
		public vtkDistributedDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E5DA RID: 58842
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistributedDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E5DB RID: 58843 RVA: 0x0014032C File Offset: 0x0013E52C
		public new static vtkDistributedDataFilter New()
		{
			vtkDistributedDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistributedDataFilter.vtkDistributedDataFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistributedDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E5DC RID: 58844 RVA: 0x00140380 File Offset: 0x0013E580
		public vtkDistributedDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDistributedDataFilter.vtkDistributedDataFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E5DD RID: 58845 RVA: 0x001403C4 File Offset: 0x0013E5C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E5DE RID: 58846
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_ClipCellsOff_01(HandleRef pThis);

		/// <summary>
		/// Set this variable if you want the cells of the output
		/// vtkUnstructuredGrid to be clipped to the spatial region
		/// boundaries.  By default this is off.
		/// </summary>
		// Token: 0x0600E5DF RID: 58847 RVA: 0x001403CF File Offset: 0x0013E5CF
		public virtual void ClipCellsOff()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_ClipCellsOff_01(base.GetCppThis());
		}

		// Token: 0x0600E5E0 RID: 58848
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_ClipCellsOn_02(HandleRef pThis);

		/// <summary>
		/// Set this variable if you want the cells of the output
		/// vtkUnstructuredGrid to be clipped to the spatial region
		/// boundaries.  By default this is off.
		/// </summary>
		// Token: 0x0600E5E1 RID: 58849 RVA: 0x001403DE File Offset: 0x0013E5DE
		public virtual void ClipCellsOn()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_ClipCellsOn_02(base.GetCppThis());
		}

		// Token: 0x0600E5E2 RID: 58850
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistributedDataFilter_GetBoundaryMode_03(HandleRef pThis);

		/// <summary>
		/// Handling of ClipCells and IncludeAllIntersectingCells.
		/// </summary>
		// Token: 0x0600E5E3 RID: 58851 RVA: 0x001403F0 File Offset: 0x0013E5F0
		public int GetBoundaryMode()
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_GetBoundaryMode_03(base.GetCppThis());
		}

		// Token: 0x0600E5E4 RID: 58852
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistributedDataFilter_GetClipCells_04(HandleRef pThis);

		/// <summary>
		/// Set this variable if you want the cells of the output
		/// vtkUnstructuredGrid to be clipped to the spatial region
		/// boundaries.  By default this is off.
		/// </summary>
		// Token: 0x0600E5E5 RID: 58853 RVA: 0x00140410 File Offset: 0x0013E610
		public virtual int GetClipCells()
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_GetClipCells_04(base.GetCppThis());
		}

		// Token: 0x0600E5E6 RID: 58854
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistributedDataFilter_GetController_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the communicator object
		/// </summary>
		// Token: 0x0600E5E7 RID: 58855 RVA: 0x00140430 File Offset: 0x0013E630
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistributedDataFilter.vtkDistributedDataFilter_GetController_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E5E8 RID: 58856
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistributedDataFilter_GetCuts_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// You can set the k-d tree decomposition, rather than
		/// have D3 compute it.  This allows you to divide a dataset using
		/// the decomposition computed for another dataset.  Obtain a description
		/// of the k-d tree cuts this way:
		///
		/// vtkBSPCuts *cuts = D3Object1-&gt;GetCuts()
		///
		/// And set it this way:
		///
		/// D3Object2-&gt;SetCuts(cuts)
		/// </summary>
		// Token: 0x0600E5E9 RID: 58857 RVA: 0x001404A0 File Offset: 0x0013E6A0
		public vtkBSPCuts GetCuts()
		{
			vtkBSPCuts vtkBSPCuts = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistributedDataFilter.vtkDistributedDataFilter_GetCuts_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBSPCuts = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBSPCuts.Register(null);
				}
			}
			return vtkBSPCuts;
		}

		// Token: 0x0600E5EA RID: 58858
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistributedDataFilter_GetIncludeAllIntersectingCells_07(HandleRef pThis);

		/// <summary>
		/// Each cell in the data set is associated with one of the
		/// spatial regions of the k-d tree decomposition.  In particular,
		/// the cell belongs to the region that it's centroid lies in.
		/// When the new vtkUnstructuredGrid is created, by default it
		/// is composed of the cells associated with the region(s)
		/// assigned to this process.  If you also want it to contain
		/// cells that intersect these regions, but have their centroid
		/// elsewhere, then set this variable on.  By default it is off.
		/// </summary>
		// Token: 0x0600E5EB RID: 58859 RVA: 0x00140510 File Offset: 0x0013E710
		public virtual int GetIncludeAllIntersectingCells()
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_GetIncludeAllIntersectingCells_07(base.GetCppThis());
		}

		// Token: 0x0600E5EC RID: 58860
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistributedDataFilter_GetKdtree_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to the parallel k-d tree object.  Required for changing
		/// default behavior for region assignment, changing default depth of tree,
		/// or other tree building default parameters.  See vtkPKdTree and
		/// vtkKdTree for more information about these options.
		/// NOTE: Changing the tree returned by this method does NOT change
		/// the d3 filter. Make sure to call Modified() on the d3 object if
		/// you want it to re-execute.
		/// </summary>
		// Token: 0x0600E5ED RID: 58861 RVA: 0x00140530 File Offset: 0x0013E730
		public vtkPKdTree GetKdtree()
		{
			vtkPKdTree vtkPKdTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistributedDataFilter.vtkDistributedDataFilter_GetKdtree_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPKdTree = (vtkPKdTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPKdTree.Register(null);
				}
			}
			return vtkPKdTree;
		}

		// Token: 0x0600E5EE RID: 58862
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistributedDataFilter_GetMinimumGhostLevel_09(HandleRef pThis);

		/// <summary>
		/// The minimum number of ghost levels to add to each processor's output. If
		/// the pipeline also requests ghost levels, the larger value will be used.
		/// </summary>
		// Token: 0x0600E5EF RID: 58863 RVA: 0x001405A0 File Offset: 0x0013E7A0
		public virtual int GetMinimumGhostLevel()
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_GetMinimumGhostLevel_09(base.GetCppThis());
		}

		// Token: 0x0600E5F0 RID: 58864
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistributedDataFilter_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E5F1 RID: 58865 RVA: 0x001405C0 File Offset: 0x0013E7C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0600E5F2 RID: 58866
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistributedDataFilter_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E5F3 RID: 58867 RVA: 0x001405E0 File Offset: 0x0013E7E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0600E5F4 RID: 58868
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistributedDataFilter_GetRetainKdtree_12(HandleRef pThis);

		/// <summary>
		/// When this filter executes, it creates a vtkPKdTree (K-d tree)
		/// data structure in parallel which divides the total distributed
		/// data set into spatial regions.  The K-d tree object also creates
		/// tables describing which processes have data for which
		/// regions.  Only then does this filter redistribute
		/// the data according to the region assignment scheme.  By default,
		/// the K-d tree structure and it's associated tables are deleted
		/// after the filter executes.  If you anticipate changing only the
		/// region assignment scheme (input is unchanged) and explicitly
		/// re-executing, then RetainKdTreeOn, and the K-d tree structure and
		/// tables will be saved.  Then, when you re-execute, this filter will
		/// skip the k-d tree build phase and go straight to redistributing
		/// the data according to region assignment.  See vtkPKdTree for
		/// more information about region assignment.
		/// </summary>
		// Token: 0x0600E5F5 RID: 58869 RVA: 0x001405FC File Offset: 0x0013E7FC
		public virtual int GetRetainKdtree()
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_GetRetainKdtree_12(base.GetCppThis());
		}

		// Token: 0x0600E5F6 RID: 58870
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistributedDataFilter_GetTiming_13(HandleRef pThis);

		/// <summary>
		/// Turn on collection of timing data
		/// </summary>
		// Token: 0x0600E5F7 RID: 58871 RVA: 0x0014061C File Offset: 0x0013E81C
		public virtual int GetTiming()
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_GetTiming_13(base.GetCppThis());
		}

		// Token: 0x0600E5F8 RID: 58872
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistributedDataFilter_GetUseMinimalMemory_14(HandleRef pThis);

		/// <summary>
		/// This class does a great deal of all-to-all communication
		/// when exchanging portions of data sets and building new sub
		/// grids.
		/// By default it will do fast communication.  It can instead
		/// use communication routines that use the least possible
		/// amount of memory, but these are slower.  Set this option
		/// ON to choose these latter routines.
		/// </summary>
		// Token: 0x0600E5F9 RID: 58873 RVA: 0x0014063C File Offset: 0x0013E83C
		public virtual int GetUseMinimalMemory()
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_GetUseMinimalMemory_14(base.GetCppThis());
		}

		// Token: 0x0600E5FA RID: 58874
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_IncludeAllIntersectingCellsOff_15(HandleRef pThis);

		/// <summary>
		/// Each cell in the data set is associated with one of the
		/// spatial regions of the k-d tree decomposition.  In particular,
		/// the cell belongs to the region that it's centroid lies in.
		/// When the new vtkUnstructuredGrid is created, by default it
		/// is composed of the cells associated with the region(s)
		/// assigned to this process.  If you also want it to contain
		/// cells that intersect these regions, but have their centroid
		/// elsewhere, then set this variable on.  By default it is off.
		/// </summary>
		// Token: 0x0600E5FB RID: 58875 RVA: 0x0014065B File Offset: 0x0013E85B
		public virtual void IncludeAllIntersectingCellsOff()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_IncludeAllIntersectingCellsOff_15(base.GetCppThis());
		}

		// Token: 0x0600E5FC RID: 58876
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_IncludeAllIntersectingCellsOn_16(HandleRef pThis);

		/// <summary>
		/// Each cell in the data set is associated with one of the
		/// spatial regions of the k-d tree decomposition.  In particular,
		/// the cell belongs to the region that it's centroid lies in.
		/// When the new vtkUnstructuredGrid is created, by default it
		/// is composed of the cells associated with the region(s)
		/// assigned to this process.  If you also want it to contain
		/// cells that intersect these regions, but have their centroid
		/// elsewhere, then set this variable on.  By default it is off.
		/// </summary>
		// Token: 0x0600E5FD RID: 58877 RVA: 0x0014066A File Offset: 0x0013E86A
		public virtual void IncludeAllIntersectingCellsOn()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_IncludeAllIntersectingCellsOn_16(base.GetCppThis());
		}

		// Token: 0x0600E5FE RID: 58878
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistributedDataFilter_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E5FF RID: 58879 RVA: 0x0014067C File Offset: 0x0013E87C
		public override int IsA(string type)
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0600E600 RID: 58880
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistributedDataFilter_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E601 RID: 58881 RVA: 0x0014069C File Offset: 0x0013E89C
		public new static int IsTypeOf(string type)
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_IsTypeOf_18(type);
		}

		// Token: 0x0600E602 RID: 58882
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistributedDataFilter_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E603 RID: 58883 RVA: 0x001406B8 File Offset: 0x0013E8B8
		public new vtkDistributedDataFilter NewInstance()
		{
			vtkDistributedDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistributedDataFilter.vtkDistributedDataFilter_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistributedDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E604 RID: 58884
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_RetainKdtreeOff_21(HandleRef pThis);

		/// <summary>
		/// When this filter executes, it creates a vtkPKdTree (K-d tree)
		/// data structure in parallel which divides the total distributed
		/// data set into spatial regions.  The K-d tree object also creates
		/// tables describing which processes have data for which
		/// regions.  Only then does this filter redistribute
		/// the data according to the region assignment scheme.  By default,
		/// the K-d tree structure and it's associated tables are deleted
		/// after the filter executes.  If you anticipate changing only the
		/// region assignment scheme (input is unchanged) and explicitly
		/// re-executing, then RetainKdTreeOn, and the K-d tree structure and
		/// tables will be saved.  Then, when you re-execute, this filter will
		/// skip the k-d tree build phase and go straight to redistributing
		/// the data according to region assignment.  See vtkPKdTree for
		/// more information about region assignment.
		/// </summary>
		// Token: 0x0600E605 RID: 58885 RVA: 0x00140712 File Offset: 0x0013E912
		public virtual void RetainKdtreeOff()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_RetainKdtreeOff_21(base.GetCppThis());
		}

		// Token: 0x0600E606 RID: 58886
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_RetainKdtreeOn_22(HandleRef pThis);

		/// <summary>
		/// When this filter executes, it creates a vtkPKdTree (K-d tree)
		/// data structure in parallel which divides the total distributed
		/// data set into spatial regions.  The K-d tree object also creates
		/// tables describing which processes have data for which
		/// regions.  Only then does this filter redistribute
		/// the data according to the region assignment scheme.  By default,
		/// the K-d tree structure and it's associated tables are deleted
		/// after the filter executes.  If you anticipate changing only the
		/// region assignment scheme (input is unchanged) and explicitly
		/// re-executing, then RetainKdTreeOn, and the K-d tree structure and
		/// tables will be saved.  Then, when you re-execute, this filter will
		/// skip the k-d tree build phase and go straight to redistributing
		/// the data according to region assignment.  See vtkPKdTree for
		/// more information about region assignment.
		/// </summary>
		// Token: 0x0600E607 RID: 58887 RVA: 0x00140721 File Offset: 0x0013E921
		public virtual void RetainKdtreeOn()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_RetainKdtreeOn_22(base.GetCppThis());
		}

		// Token: 0x0600E608 RID: 58888
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistributedDataFilter_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E609 RID: 58889 RVA: 0x00140730 File Offset: 0x0013E930
		public new static vtkDistributedDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDistributedDataFilter vtkDistributedDataFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistributedDataFilter.vtkDistributedDataFilter_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistributedDataFilter = (vtkDistributedDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistributedDataFilter.Register(null);
				}
			}
			return vtkDistributedDataFilter;
		}

		// Token: 0x0600E60A RID: 58890
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_SetBoundaryMode_24(HandleRef pThis, int mode);

		/// <summary>
		/// Handling of ClipCells and IncludeAllIntersectingCells.
		/// </summary>
		// Token: 0x0600E60B RID: 58891 RVA: 0x001407AF File Offset: 0x0013E9AF
		public void SetBoundaryMode(int mode)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetBoundaryMode_24(base.GetCppThis(), mode);
		}

		// Token: 0x0600E60C RID: 58892
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_SetBoundaryModeToAssignToAllIntersectingRegions_25(HandleRef pThis);

		/// <summary>
		/// Handling of ClipCells and IncludeAllIntersectingCells.
		/// </summary>
		// Token: 0x0600E60D RID: 58893 RVA: 0x001407BF File Offset: 0x0013E9BF
		public void SetBoundaryModeToAssignToAllIntersectingRegions()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetBoundaryModeToAssignToAllIntersectingRegions_25(base.GetCppThis());
		}

		// Token: 0x0600E60E RID: 58894
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_SetBoundaryModeToAssignToOneRegion_26(HandleRef pThis);

		/// <summary>
		/// Handling of ClipCells and IncludeAllIntersectingCells.
		/// </summary>
		// Token: 0x0600E60F RID: 58895 RVA: 0x001407CE File Offset: 0x0013E9CE
		public void SetBoundaryModeToAssignToOneRegion()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetBoundaryModeToAssignToOneRegion_26(base.GetCppThis());
		}

		// Token: 0x0600E610 RID: 58896
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_SetBoundaryModeToSplitBoundaryCells_27(HandleRef pThis);

		/// <summary>
		/// Handling of ClipCells and IncludeAllIntersectingCells.
		/// </summary>
		// Token: 0x0600E611 RID: 58897 RVA: 0x001407DD File Offset: 0x0013E9DD
		public void SetBoundaryModeToSplitBoundaryCells()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetBoundaryModeToSplitBoundaryCells_27(base.GetCppThis());
		}

		// Token: 0x0600E612 RID: 58898
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_SetClipCells_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Set this variable if you want the cells of the output
		/// vtkUnstructuredGrid to be clipped to the spatial region
		/// boundaries.  By default this is off.
		/// </summary>
		// Token: 0x0600E613 RID: 58899 RVA: 0x001407EC File Offset: 0x0013E9EC
		public virtual void SetClipCells(int _arg)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetClipCells_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E614 RID: 58900
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_SetController_29(HandleRef pThis, HandleRef c);

		/// <summary>
		/// Set/Get the communicator object
		/// </summary>
		// Token: 0x0600E615 RID: 58901 RVA: 0x001407FC File Offset: 0x0013E9FC
		public void SetController(vtkMultiProcessController c)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetController_29(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x0600E616 RID: 58902
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_SetCuts_30(HandleRef pThis, HandleRef cuts);

		/// <summary>
		/// You can set the k-d tree decomposition, rather than
		/// have D3 compute it.  This allows you to divide a dataset using
		/// the decomposition computed for another dataset.  Obtain a description
		/// of the k-d tree cuts this way:
		///
		/// vtkBSPCuts *cuts = D3Object1-&gt;GetCuts()
		///
		/// And set it this way:
		///
		/// D3Object2-&gt;SetCuts(cuts)
		/// </summary>
		// Token: 0x0600E617 RID: 58903 RVA: 0x0014082C File Offset: 0x0013EA2C
		public void SetCuts(vtkBSPCuts cuts)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetCuts_30(base.GetCppThis(), (cuts == null) ? default(HandleRef) : cuts.GetCppThis());
		}

		// Token: 0x0600E618 RID: 58904
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_SetIncludeAllIntersectingCells_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Each cell in the data set is associated with one of the
		/// spatial regions of the k-d tree decomposition.  In particular,
		/// the cell belongs to the region that it's centroid lies in.
		/// When the new vtkUnstructuredGrid is created, by default it
		/// is composed of the cells associated with the region(s)
		/// assigned to this process.  If you also want it to contain
		/// cells that intersect these regions, but have their centroid
		/// elsewhere, then set this variable on.  By default it is off.
		/// </summary>
		// Token: 0x0600E619 RID: 58905 RVA: 0x0014085B File Offset: 0x0013EA5B
		public virtual void SetIncludeAllIntersectingCells(int _arg)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetIncludeAllIntersectingCells_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E61A RID: 58906
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_SetMinimumGhostLevel_32(HandleRef pThis, int _arg);

		/// <summary>
		/// The minimum number of ghost levels to add to each processor's output. If
		/// the pipeline also requests ghost levels, the larger value will be used.
		/// </summary>
		// Token: 0x0600E61B RID: 58907 RVA: 0x0014086B File Offset: 0x0013EA6B
		public virtual void SetMinimumGhostLevel(int _arg)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetMinimumGhostLevel_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E61C RID: 58908
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_SetRetainKdtree_33(HandleRef pThis, int _arg);

		/// <summary>
		/// When this filter executes, it creates a vtkPKdTree (K-d tree)
		/// data structure in parallel which divides the total distributed
		/// data set into spatial regions.  The K-d tree object also creates
		/// tables describing which processes have data for which
		/// regions.  Only then does this filter redistribute
		/// the data according to the region assignment scheme.  By default,
		/// the K-d tree structure and it's associated tables are deleted
		/// after the filter executes.  If you anticipate changing only the
		/// region assignment scheme (input is unchanged) and explicitly
		/// re-executing, then RetainKdTreeOn, and the K-d tree structure and
		/// tables will be saved.  Then, when you re-execute, this filter will
		/// skip the k-d tree build phase and go straight to redistributing
		/// the data according to region assignment.  See vtkPKdTree for
		/// more information about region assignment.
		/// </summary>
		// Token: 0x0600E61D RID: 58909 RVA: 0x0014087B File Offset: 0x0013EA7B
		public virtual void SetRetainKdtree(int _arg)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetRetainKdtree_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E61E RID: 58910
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_SetTiming_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on collection of timing data
		/// </summary>
		// Token: 0x0600E61F RID: 58911 RVA: 0x0014088B File Offset: 0x0013EA8B
		public virtual void SetTiming(int _arg)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetTiming_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E620 RID: 58912
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_SetUseMinimalMemory_35(HandleRef pThis, int _arg);

		/// <summary>
		/// This class does a great deal of all-to-all communication
		/// when exchanging portions of data sets and building new sub
		/// grids.
		/// By default it will do fast communication.  It can instead
		/// use communication routines that use the least possible
		/// amount of memory, but these are slower.  Set this option
		/// ON to choose these latter routines.
		/// </summary>
		// Token: 0x0600E621 RID: 58913 RVA: 0x0014089B File Offset: 0x0013EA9B
		public virtual void SetUseMinimalMemory(int _arg)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetUseMinimalMemory_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E622 RID: 58914
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_SetUserRegionAssignments_36(HandleRef pThis, IntPtr map, int numRegions);

		/// <summary>
		/// vtkBSPCuts doesn't have information about process assignments for the cuts.
		/// Typically D3 filter simply reassigns the processes for each cut. However,
		/// that may not always work, sometimes the processes have be pre-assigned and
		/// we want to preserve that partitioning. In that case, one sets the region
		/// assignments explicitly. Look at vtkPKdTree::AssignRegions for details about
		/// the arguments. Calling SetUserRegionAssignments(nullptr, 0) will revert to
		/// default behavior i.e. letting the KdTree come up with the assignments.
		/// </summary>
		// Token: 0x0600E623 RID: 58915 RVA: 0x001408AB File Offset: 0x0013EAAB
		public void SetUserRegionAssignments(IntPtr map, int numRegions)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetUserRegionAssignments_36(base.GetCppThis(), map, numRegions);
		}

		// Token: 0x0600E624 RID: 58916
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_TimingOff_37(HandleRef pThis);

		/// <summary>
		/// Turn on collection of timing data
		/// </summary>
		// Token: 0x0600E625 RID: 58917 RVA: 0x001408BC File Offset: 0x0013EABC
		public virtual void TimingOff()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_TimingOff_37(base.GetCppThis());
		}

		// Token: 0x0600E626 RID: 58918
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_TimingOn_38(HandleRef pThis);

		/// <summary>
		/// Turn on collection of timing data
		/// </summary>
		// Token: 0x0600E627 RID: 58919 RVA: 0x001408CB File Offset: 0x0013EACB
		public virtual void TimingOn()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_TimingOn_38(base.GetCppThis());
		}

		// Token: 0x0600E628 RID: 58920
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_UseMinimalMemoryOff_39(HandleRef pThis);

		/// <summary>
		/// This class does a great deal of all-to-all communication
		/// when exchanging portions of data sets and building new sub
		/// grids.
		/// By default it will do fast communication.  It can instead
		/// use communication routines that use the least possible
		/// amount of memory, but these are slower.  Set this option
		/// ON to choose these latter routines.
		/// </summary>
		// Token: 0x0600E629 RID: 58921 RVA: 0x001408DA File Offset: 0x0013EADA
		public virtual void UseMinimalMemoryOff()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_UseMinimalMemoryOff_39(base.GetCppThis());
		}

		// Token: 0x0600E62A RID: 58922
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedDataFilter_UseMinimalMemoryOn_40(HandleRef pThis);

		/// <summary>
		/// This class does a great deal of all-to-all communication
		/// when exchanging portions of data sets and building new sub
		/// grids.
		/// By default it will do fast communication.  It can instead
		/// use communication routines that use the least possible
		/// amount of memory, but these are slower.  Set this option
		/// ON to choose these latter routines.
		/// </summary>
		// Token: 0x0600E62B RID: 58923 RVA: 0x001408E9 File Offset: 0x0013EAE9
		public virtual void UseMinimalMemoryOn()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_UseMinimalMemoryOn_40(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010E1 RID: 4321
		public new const string MRFullTypeName = "Kitware.VTK.vtkDistributedDataFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010E2 RID: 4322
		public new static readonly string MRClassNameKey = "class vtkDistributedDataFilter";

		/// <summary>
		/// Set this variable if you want the cells of the output
		/// vtkUnstructuredGrid to be clipped to the spatial region
		/// boundaries.  By default this is off.
		/// </summary>
		// Token: 0x020004FE RID: 1278
		public enum BoundaryModes
		{
			/// <summary>enum member</summary>
			// Token: 0x040010E4 RID: 4324
			ASSIGN_TO_ALL_INTERSECTING_REGIONS = 1,
			/// <summary>enum member</summary>
			// Token: 0x040010E5 RID: 4325
			ASSIGN_TO_ONE_REGION = 0,
			/// <summary>enum member</summary>
			// Token: 0x040010E6 RID: 4326
			SPLIT_BOUNDARY_CELLS = 2
		}
	}
}
