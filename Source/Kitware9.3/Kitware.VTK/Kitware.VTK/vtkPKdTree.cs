using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPKdTree
	/// </summary>
	/// <remarks>
	///    Build a k-d tree decomposition of a list of points.
	///
	///
	///      Build, in parallel, a k-d tree decomposition of one or more
	///      vtkDataSets distributed across processors.  We assume each
	///      process has read in one portion of a large distributed data set.
	///      When done, each process has access to the k-d tree structure,
	///      can obtain information about which process contains
	///      data for each spatial region, and can depth sort the spatial
	///      regions.
	///
	///      This class can also assign spatial regions to processors, based
	///      on one of several region assignment schemes.  By default
	///      a contiguous, convex region is assigned to each process.  Several
	///      queries return information about how many and what cells I have
	///      that lie in a region assigned to another process.
	///
	/// </remarks>
	/// <seealso>
	///
	///      vtkKdTree
	/// </seealso>
	// Token: 0x02000519 RID: 1305
	public class vtkPKdTree : vtkKdTree
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E9BE RID: 59838 RVA: 0x00145FBE File Offset: 0x001441BE
		static vtkPKdTree()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPKdTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPKdTree"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E9BF RID: 59839 RVA: 0x00145FE6 File Offset: 0x001441E6
		public vtkPKdTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E9C0 RID: 59840
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPKdTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E9C1 RID: 59841 RVA: 0x00145FF4 File Offset: 0x001441F4
		public new static vtkPKdTree New()
		{
			vtkPKdTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPKdTree.vtkPKdTree_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPKdTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E9C2 RID: 59842 RVA: 0x00146048 File Offset: 0x00144248
		public vtkPKdTree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPKdTree.vtkPKdTree_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E9C3 RID: 59843 RVA: 0x0014608C File Offset: 0x0014428C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E9C4 RID: 59844
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_AssignRegions_01(HandleRef pThis, IntPtr map, int numRegions);

		/// <summary>
		/// Assign spatial regions to processes via a user defined map.
		/// The user-supplied map is indexed by region ID, and provides a
		/// process ID for each region.
		/// </summary>
		// Token: 0x0600E9C5 RID: 59845 RVA: 0x00146098 File Offset: 0x00144298
		public int AssignRegions(IntPtr map, int numRegions)
		{
			return vtkPKdTree.vtkPKdTree_AssignRegions_01(base.GetCppThis(), map, numRegions);
		}

		// Token: 0x0600E9C6 RID: 59846
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_AssignRegionsContiguous_02(HandleRef pThis);

		/// <summary>
		/// Let the PKdTree class assign a process to each region
		/// by assigning contiguous sets of spatial regions to each
		/// process.  The set of regions assigned to each process will
		/// always have a union that is a convex space (a box).
		/// If the k-d tree has not yet been built, the regions
		/// will be assigned after BuildLocator executes.
		/// </summary>
		// Token: 0x0600E9C7 RID: 59847 RVA: 0x001460BC File Offset: 0x001442BC
		public int AssignRegionsContiguous()
		{
			return vtkPKdTree.vtkPKdTree_AssignRegionsContiguous_02(base.GetCppThis());
		}

		// Token: 0x0600E9C8 RID: 59848
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_AssignRegionsRoundRobin_03(HandleRef pThis);

		/// <summary>
		/// Let the PKdTree class assign a process to each region in a
		/// round robin fashion.  If the k-d tree has not yet been
		/// built, the regions will be assigned after BuildLocator executes.
		/// </summary>
		// Token: 0x0600E9C9 RID: 59849 RVA: 0x001460DC File Offset: 0x001442DC
		public int AssignRegionsRoundRobin()
		{
			return vtkPKdTree.vtkPKdTree_AssignRegionsRoundRobin_03(base.GetCppThis());
		}

		// Token: 0x0600E9CA RID: 59850
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPKdTree_BuildLocator_04(HandleRef pThis);

		/// <summary>
		/// Build the spatial decomposition.  Call this explicitly
		/// after changing any parameters affecting the build of the
		/// tree.  It must be called by all processes in the parallel
		/// application, or it will hang.
		/// </summary>
		// Token: 0x0600E9CB RID: 59851 RVA: 0x001460FB File Offset: 0x001442FB
		public override void BuildLocator()
		{
			vtkPKdTree.vtkPKdTree_BuildLocator_04(base.GetCppThis());
		}

		// Token: 0x0600E9CC RID: 59852
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_CreateGlobalDataArrayBounds_05(HandleRef pThis);

		/// <summary>
		/// A convenience function which compiles the global
		/// bounds of the data arrays across processes.
		/// These bounds can be accessed with
		/// "GetCellArrayGlobalRange" and "GetPointArrayGlobalRange".
		/// This method must be called by all processes or it will hang.
		/// Returns 1 on error, 0 when no error.
		/// </summary>
		// Token: 0x0600E9CD RID: 59853 RVA: 0x0014610C File Offset: 0x0014430C
		public int CreateGlobalDataArrayBounds()
		{
			return vtkPKdTree.vtkPKdTree_CreateGlobalDataArrayBounds_05(base.GetCppThis());
		}

		// Token: 0x0600E9CE RID: 59854
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_CreateProcessCellCountData_06(HandleRef pThis);

		/// <summary>
		/// Create tables of counts of cells per process per region.
		/// These tables can be accessed with queries like
		/// "HasData", "GetProcessCellCountForRegion", and so on.
		/// You must have called BuildLocator() beforehand.  This
		/// method must be called by all processes or it will hang.
		/// Returns 1 on error, 0 when no error.
		/// </summary>
		// Token: 0x0600E9CF RID: 59855 RVA: 0x0014612C File Offset: 0x0014432C
		public int CreateProcessCellCountData()
		{
			return vtkPKdTree.vtkPKdTree_CreateProcessCellCountData_06(base.GetCppThis());
		}

		// Token: 0x0600E9D0 RID: 59856
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPKdTree_GetAllProcessesBorderingOnPoint_07(HandleRef pThis, float x, float y, float z, HandleRef list);

		/// <summary>
		/// The k-d tree spatial regions have been assigned to processes.
		/// Given a point on the boundary of one of the regions, this
		/// method creates a list of all processes whose region
		/// boundaries include that point.  This may be required when
		/// looking for processes that have cells adjacent to the cells
		/// of a given process.
		/// </summary>
		// Token: 0x0600E9D1 RID: 59857 RVA: 0x0014614C File Offset: 0x0014434C
		public void GetAllProcessesBorderingOnPoint(float x, float y, float z, vtkIntArray list)
		{
			vtkPKdTree.vtkPKdTree_GetAllProcessesBorderingOnPoint_07(base.GetCppThis(), x, y, z, (list == null) ? default(HandleRef) : list.GetCppThis());
		}

		// Token: 0x0600E9D2 RID: 59858
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_GetCellArrayGlobalRange_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr range);

		/// <summary>
		/// An added feature of vtkPKdTree is that it will calculate the
		/// the global range of field arrays across all processes.  You
		/// call CreateGlobalDataArrayBounds() to do this calculation.
		/// Then the following methods return the ranges.
		/// Returns 1 on error, 0 otherwise.
		/// </summary>
		// Token: 0x0600E9D3 RID: 59859 RVA: 0x00146180 File Offset: 0x00144380
		public int GetCellArrayGlobalRange(string name, IntPtr range)
		{
			return vtkPKdTree.vtkPKdTree_GetCellArrayGlobalRange_08(base.GetCppThis(), name, range);
		}

		// Token: 0x0600E9D4 RID: 59860
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_GetCellArrayGlobalRange_09(HandleRef pThis, int arrayIndex, IntPtr range);

		/// <summary>
		/// An added feature of vtkPKdTree is that it will calculate the
		/// the global range of field arrays across all processes.  You
		/// call CreateGlobalDataArrayBounds() to do this calculation.
		/// Then the following methods return the ranges.
		/// Returns 1 on error, 0 otherwise.
		/// </summary>
		// Token: 0x0600E9D5 RID: 59861 RVA: 0x001461A4 File Offset: 0x001443A4
		public int GetCellArrayGlobalRange(int arrayIndex, IntPtr range)
		{
			return vtkPKdTree.vtkPKdTree_GetCellArrayGlobalRange_09(base.GetCppThis(), arrayIndex, range);
		}

		// Token: 0x0600E9D6 RID: 59862
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPKdTree_GetCellListsForProcessRegions_10(HandleRef pThis, int ProcessId, int set, HandleRef inRegionCells, HandleRef onBoundaryCells);

		/// <summary>
		/// After regions have been assigned to processes, I may want to know
		/// which cells I have that are in the regions assigned to a particular
		/// process.
		///
		/// This method takes a process ID and two vtkIdLists.  It
		/// writes to the first list the IDs of the cells
		/// contained in the process' regions.  (That is, their cell
		/// centroid is contained in the region.)  To the second list it
		/// write the IDs of the cells which intersect the process' regions
		/// but whose cell centroid lies elsewhere.
		///
		/// The total number of cell IDs written to both lists is returned.
		/// Either list pointer passed in can be nullptr, and it will be ignored.
		/// If there are multiple data sets, you must specify which data set
		/// you wish cell IDs for.
		///
		/// The caller should delete these two lists when done.  This method
		/// uses the cell lists created in vtkKdTree::CreateCellLists().
		/// If the cell lists for the process' regions do not exist, this
		/// method will first build the cell lists for all regions by calling
		/// CreateCellLists().  You must remember to DeleteCellLists() when
		/// done with all calls to this method, as cell lists can require a
		/// great deal of memory.
		/// </summary>
		// Token: 0x0600E9D7 RID: 59863 RVA: 0x001461C8 File Offset: 0x001443C8
		public long GetCellListsForProcessRegions(int ProcessId, int set, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
		{
			return vtkPKdTree.vtkPKdTree_GetCellListsForProcessRegions_10(base.GetCppThis(), ProcessId, set, (inRegionCells == null) ? default(HandleRef) : inRegionCells.GetCppThis(), (onBoundaryCells == null) ? default(HandleRef) : onBoundaryCells.GetCppThis());
		}

		// Token: 0x0600E9D8 RID: 59864
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPKdTree_GetCellListsForProcessRegions_11(HandleRef pThis, int ProcessId, HandleRef set, HandleRef inRegionCells, HandleRef onBoundaryCells);

		/// <summary>
		/// After regions have been assigned to processes, I may want to know
		/// which cells I have that are in the regions assigned to a particular
		/// process.
		///
		/// This method takes a process ID and two vtkIdLists.  It
		/// writes to the first list the IDs of the cells
		/// contained in the process' regions.  (That is, their cell
		/// centroid is contained in the region.)  To the second list it
		/// write the IDs of the cells which intersect the process' regions
		/// but whose cell centroid lies elsewhere.
		///
		/// The total number of cell IDs written to both lists is returned.
		/// Either list pointer passed in can be nullptr, and it will be ignored.
		/// If there are multiple data sets, you must specify which data set
		/// you wish cell IDs for.
		///
		/// The caller should delete these two lists when done.  This method
		/// uses the cell lists created in vtkKdTree::CreateCellLists().
		/// If the cell lists for the process' regions do not exist, this
		/// method will first build the cell lists for all regions by calling
		/// CreateCellLists().  You must remember to DeleteCellLists() when
		/// done with all calls to this method, as cell lists can require a
		/// great deal of memory.
		/// </summary>
		// Token: 0x0600E9D9 RID: 59865 RVA: 0x00146218 File Offset: 0x00144418
		public long GetCellListsForProcessRegions(int ProcessId, vtkDataSet set, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
		{
			return vtkPKdTree.vtkPKdTree_GetCellListsForProcessRegions_11(base.GetCppThis(), ProcessId, (set == null) ? default(HandleRef) : set.GetCppThis(), (inRegionCells == null) ? default(HandleRef) : inRegionCells.GetCppThis(), (onBoundaryCells == null) ? default(HandleRef) : onBoundaryCells.GetCppThis());
		}

		// Token: 0x0600E9DA RID: 59866
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPKdTree_GetCellListsForProcessRegions_12(HandleRef pThis, int ProcessId, HandleRef inRegionCells, HandleRef onBoundaryCells);

		/// <summary>
		/// After regions have been assigned to processes, I may want to know
		/// which cells I have that are in the regions assigned to a particular
		/// process.
		///
		/// This method takes a process ID and two vtkIdLists.  It
		/// writes to the first list the IDs of the cells
		/// contained in the process' regions.  (That is, their cell
		/// centroid is contained in the region.)  To the second list it
		/// write the IDs of the cells which intersect the process' regions
		/// but whose cell centroid lies elsewhere.
		///
		/// The total number of cell IDs written to both lists is returned.
		/// Either list pointer passed in can be nullptr, and it will be ignored.
		/// If there are multiple data sets, you must specify which data set
		/// you wish cell IDs for.
		///
		/// The caller should delete these two lists when done.  This method
		/// uses the cell lists created in vtkKdTree::CreateCellLists().
		/// If the cell lists for the process' regions do not exist, this
		/// method will first build the cell lists for all regions by calling
		/// CreateCellLists().  You must remember to DeleteCellLists() when
		/// done with all calls to this method, as cell lists can require a
		/// great deal of memory.
		/// </summary>
		// Token: 0x0600E9DB RID: 59867 RVA: 0x0014627C File Offset: 0x0014447C
		public long GetCellListsForProcessRegions(int ProcessId, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
		{
			return vtkPKdTree.vtkPKdTree_GetCellListsForProcessRegions_12(base.GetCppThis(), ProcessId, (inRegionCells == null) ? default(HandleRef) : inRegionCells.GetCppThis(), (onBoundaryCells == null) ? default(HandleRef) : onBoundaryCells.GetCppThis());
		}

		// Token: 0x0600E9DC RID: 59868
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPKdTree_GetController_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the communicator object
		/// </summary>
		// Token: 0x0600E9DD RID: 59869 RVA: 0x001462C8 File Offset: 0x001444C8
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPKdTree.vtkPKdTree_GetController_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E9DE RID: 59870
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPKdTree_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E9DF RID: 59871 RVA: 0x00146338 File Offset: 0x00144538
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPKdTree.vtkPKdTree_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0600E9E0 RID: 59872
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPKdTree_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E9E1 RID: 59873 RVA: 0x00146358 File Offset: 0x00144558
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPKdTree.vtkPKdTree_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0600E9E2 RID: 59874
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_GetPointArrayGlobalRange_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr range);

		/// <summary>
		/// An added feature of vtkPKdTree is that it will calculate the
		/// the global range of field arrays across all processes.  You
		/// call CreateGlobalDataArrayBounds() to do this calculation.
		/// Then the following methods return the ranges.
		/// Returns 1 on error, 0 otherwise.
		/// </summary>
		// Token: 0x0600E9E3 RID: 59875 RVA: 0x00146374 File Offset: 0x00144574
		public int GetPointArrayGlobalRange(string name, IntPtr range)
		{
			return vtkPKdTree.vtkPKdTree_GetPointArrayGlobalRange_16(base.GetCppThis(), name, range);
		}

		// Token: 0x0600E9E4 RID: 59876
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_GetPointArrayGlobalRange_17(HandleRef pThis, int arrayIndex, IntPtr range);

		/// <summary>
		/// An added feature of vtkPKdTree is that it will calculate the
		/// the global range of field arrays across all processes.  You
		/// call CreateGlobalDataArrayBounds() to do this calculation.
		/// Then the following methods return the ranges.
		/// Returns 1 on error, 0 otherwise.
		/// </summary>
		// Token: 0x0600E9E5 RID: 59877 RVA: 0x00146398 File Offset: 0x00144598
		public int GetPointArrayGlobalRange(int arrayIndex, IntPtr range)
		{
			return vtkPKdTree.vtkPKdTree_GetPointArrayGlobalRange_17(base.GetCppThis(), arrayIndex, range);
		}

		// Token: 0x0600E9E6 RID: 59878
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_GetProcessAssignedToRegion_18(HandleRef pThis, int regionId);

		/// <summary>
		/// Returns the ID of the process assigned to the region.
		/// </summary>
		// Token: 0x0600E9E7 RID: 59879 RVA: 0x001463BC File Offset: 0x001445BC
		public int GetProcessAssignedToRegion(int regionId)
		{
			return vtkPKdTree.vtkPKdTree_GetProcessAssignedToRegion_18(base.GetCppThis(), regionId);
		}

		// Token: 0x0600E9E8 RID: 59880
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_GetProcessCellCountForRegion_19(HandleRef pThis, int processId, int regionId);

		/// <summary>
		/// Returns the number of cells the specified process has in the
		/// specified region.
		/// </summary>
		// Token: 0x0600E9E9 RID: 59881 RVA: 0x001463DC File Offset: 0x001445DC
		public int GetProcessCellCountForRegion(int processId, int regionId)
		{
			return vtkPKdTree.vtkPKdTree_GetProcessCellCountForRegion_19(base.GetCppThis(), processId, regionId);
		}

		// Token: 0x0600E9EA RID: 59882
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_GetProcessListForRegion_20(HandleRef pThis, int regionId, HandleRef processes);

		/// <summary>
		/// Adds the list of processes having data for the given
		/// region to the supplied list, returns the number of
		/// processes added.
		/// </summary>
		// Token: 0x0600E9EB RID: 59883 RVA: 0x00146400 File Offset: 0x00144600
		public int GetProcessListForRegion(int regionId, vtkIntArray processes)
		{
			return vtkPKdTree.vtkPKdTree_GetProcessListForRegion_20(base.GetCppThis(), regionId, (processes == null) ? default(HandleRef) : processes.GetCppThis());
		}

		// Token: 0x0600E9EC RID: 59884
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_GetProcessesCellCountForRegion_21(HandleRef pThis, int regionId, IntPtr count, int len);

		/// <summary>
		/// Writes the number of cells each process has for the region
		/// to the supplied list of length len.  Returns the number of
		/// cell counts written.  The order of the cell counts corresponds
		/// to the order of process IDs in the process list returned by
		/// GetProcessListForRegion.
		/// </summary>
		// Token: 0x0600E9ED RID: 59885 RVA: 0x00146438 File Offset: 0x00144638
		public int GetProcessesCellCountForRegion(int regionId, IntPtr count, int len)
		{
			return vtkPKdTree.vtkPKdTree_GetProcessesCellCountForRegion_21(base.GetCppThis(), regionId, count, len);
		}

		// Token: 0x0600E9EE RID: 59886
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_GetRegionAssignment_22(HandleRef pThis);

		/// <summary>
		/// The PKdTree class can assign spatial regions to processors after
		/// building the k-d tree, using one of several partitioning criteria.
		/// These functions Set/Get whether this assignment is computed.
		/// The default is "Off", no assignment is computed.   If "On", and
		/// no assignment scheme is specified, contiguous assignment will be
		/// computed.  Specifying an assignment scheme (with AssignRegions*())
		/// automatically turns on RegionAssignment.
		/// </summary>
		// Token: 0x0600E9EF RID: 59887 RVA: 0x0014645C File Offset: 0x0014465C
		public virtual int GetRegionAssignment()
		{
			return vtkPKdTree.vtkPKdTree_GetRegionAssignment_22(base.GetCppThis());
		}

		// Token: 0x0600E9F0 RID: 59888
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_GetRegionAssignmentList_23(HandleRef pThis, int procId, HandleRef list);

		/// <summary>
		/// Writes the list of region IDs assigned to the specified
		/// process.  Regions IDs start at 0 and increase by 1 from there.
		/// Returns the number of regions in the list.
		/// </summary>
		// Token: 0x0600E9F1 RID: 59889 RVA: 0x0014647C File Offset: 0x0014467C
		public int GetRegionAssignmentList(int procId, vtkIntArray list)
		{
			return vtkPKdTree.vtkPKdTree_GetRegionAssignmentList_23(base.GetCppThis(), procId, (list == null) ? default(HandleRef) : list.GetCppThis());
		}

		// Token: 0x0600E9F2 RID: 59890
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPKdTree_GetRegionAssignmentMap_24(HandleRef pThis);

		/// <summary>
		/// Returns the region assignment map where index is the region and value is
		/// the processes id for that region.
		/// </summary>
		// Token: 0x0600E9F3 RID: 59891 RVA: 0x001464B4 File Offset: 0x001446B4
		public IntPtr GetRegionAssignmentMap()
		{
			return vtkPKdTree.vtkPKdTree_GetRegionAssignmentMap_24(base.GetCppThis());
		}

		// Token: 0x0600E9F4 RID: 59892
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_GetRegionAssignmentMapLength_25(HandleRef pThis);

		/// <summary>
		/// / Returns the number of regions in the region assignment map.
		/// </summary>
		// Token: 0x0600E9F5 RID: 59893 RVA: 0x001464D4 File Offset: 0x001446D4
		public int GetRegionAssignmentMapLength()
		{
			return vtkPKdTree.vtkPKdTree_GetRegionAssignmentMapLength_25(base.GetCppThis());
		}

		// Token: 0x0600E9F6 RID: 59894
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_GetRegionListForProcess_26(HandleRef pThis, int processId, HandleRef regions);

		/// <summary>
		/// Adds the region IDs for which this process has data to
		/// the supplied vtkIntArray.  Returns the number of regions.
		/// </summary>
		// Token: 0x0600E9F7 RID: 59895 RVA: 0x001464F4 File Offset: 0x001446F4
		public int GetRegionListForProcess(int processId, vtkIntArray regions)
		{
			return vtkPKdTree.vtkPKdTree_GetRegionListForProcess_26(base.GetCppThis(), processId, (regions == null) ? default(HandleRef) : regions.GetCppThis());
		}

		// Token: 0x0600E9F8 RID: 59896
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_GetRegionsCellCountForProcess_27(HandleRef pThis, int ProcessId, IntPtr count, int len);

		/// <summary>
		/// Writes to the supplied integer array the number of cells this
		/// process has for each region.  Returns the number of
		/// cell counts written.  The order of the cell counts corresponds
		/// to the order of region IDs in the region list returned by
		/// GetRegionListForProcess.
		/// </summary>
		// Token: 0x0600E9F9 RID: 59897 RVA: 0x0014652C File Offset: 0x0014472C
		public int GetRegionsCellCountForProcess(int ProcessId, IntPtr count, int len)
		{
			return vtkPKdTree.vtkPKdTree_GetRegionsCellCountForProcess_27(base.GetCppThis(), ProcessId, count, len);
		}

		// Token: 0x0600E9FA RID: 59898
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPKdTree_GetTotalNumberOfCells_28(HandleRef pThis);

		/// <summary>
		/// Get the total number of cells distributed across the data
		/// files read by all processes.  You must have called BuildLocator
		/// before calling this method.
		/// </summary>
		// Token: 0x0600E9FB RID: 59899 RVA: 0x00146550 File Offset: 0x00144750
		public long GetTotalNumberOfCells()
		{
			return vtkPKdTree.vtkPKdTree_GetTotalNumberOfCells_28(base.GetCppThis());
		}

		// Token: 0x0600E9FC RID: 59900
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_GetTotalProcessesInRegion_29(HandleRef pThis, int regionId);

		/// <summary>
		/// Returns the total number of processes that have data
		/// falling within this spatial region.
		/// </summary>
		// Token: 0x0600E9FD RID: 59901 RVA: 0x00146570 File Offset: 0x00144770
		public int GetTotalProcessesInRegion(int regionId)
		{
			return vtkPKdTree.vtkPKdTree_GetTotalProcessesInRegion_29(base.GetCppThis(), regionId);
		}

		// Token: 0x0600E9FE RID: 59902
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_GetTotalRegionsForProcess_30(HandleRef pThis, int processId);

		/// <summary>
		/// Returns the total number of spatial regions that a given
		/// process has data for.
		/// </summary>
		// Token: 0x0600E9FF RID: 59903 RVA: 0x00146590 File Offset: 0x00144790
		public int GetTotalRegionsForProcess(int processId)
		{
			return vtkPKdTree.vtkPKdTree_GetTotalRegionsForProcess_30(base.GetCppThis(), processId);
		}

		// Token: 0x0600EA00 RID: 59904
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_HasData_31(HandleRef pThis, int processId, int regionId);

		/// <summary>
		/// Returns 1 if the process has data for the given region,
		/// 0 otherwise.
		/// </summary>
		// Token: 0x0600EA01 RID: 59905 RVA: 0x001465B0 File Offset: 0x001447B0
		public int HasData(int processId, int regionId)
		{
			return vtkPKdTree.vtkPKdTree_HasData_31(base.GetCppThis(), processId, regionId);
		}

		// Token: 0x0600EA02 RID: 59906
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_IsA_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EA03 RID: 59907 RVA: 0x001465D4 File Offset: 0x001447D4
		public override int IsA(string type)
		{
			return vtkPKdTree.vtkPKdTree_IsA_32(base.GetCppThis(), type);
		}

		// Token: 0x0600EA04 RID: 59908
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_IsTypeOf_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EA05 RID: 59909 RVA: 0x001465F4 File Offset: 0x001447F4
		public new static int IsTypeOf(string type)
		{
			return vtkPKdTree.vtkPKdTree_IsTypeOf_33(type);
		}

		// Token: 0x0600EA06 RID: 59910
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPKdTree_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EA07 RID: 59911 RVA: 0x00146610 File Offset: 0x00144810
		public new vtkPKdTree NewInstance()
		{
			vtkPKdTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPKdTree.vtkPKdTree_NewInstance_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPKdTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EA08 RID: 59912
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPKdTree_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EA09 RID: 59913 RVA: 0x0014666C File Offset: 0x0014486C
		public new static vtkPKdTree SafeDownCast(vtkObjectBase o)
		{
			vtkPKdTree vtkPKdTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPKdTree.vtkPKdTree_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600EA0A RID: 59914
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPKdTree_SetController_37(HandleRef pThis, HandleRef c);

		/// <summary>
		/// Set/Get the communicator object
		/// </summary>
		// Token: 0x0600EA0B RID: 59915 RVA: 0x001466EC File Offset: 0x001448EC
		public void SetController(vtkMultiProcessController c)
		{
			vtkPKdTree.vtkPKdTree_SetController_37(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x0600EA0C RID: 59916
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_ViewOrderAllProcessesFromPosition_38(HandleRef pThis, IntPtr cameraPosition, HandleRef orderedList);

		/// <summary>
		/// Return a list of all processes in order from front to back given a
		/// camera position.  Use this to do visibility sorts in perspective
		/// projection mode. `orderedList' will be resized to the number
		/// of processes. The return value is the number of processes.
		/// \pre orderedList_exists: orderedList!=0
		/// </summary>
		// Token: 0x0600EA0D RID: 59917 RVA: 0x0014671C File Offset: 0x0014491C
		public int ViewOrderAllProcessesFromPosition(IntPtr cameraPosition, vtkIntArray orderedList)
		{
			return vtkPKdTree.vtkPKdTree_ViewOrderAllProcessesFromPosition_38(base.GetCppThis(), cameraPosition, (orderedList == null) ? default(HandleRef) : orderedList.GetCppThis());
		}

		// Token: 0x0600EA0E RID: 59918
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPKdTree_ViewOrderAllProcessesInDirection_39(HandleRef pThis, IntPtr directionOfProjection, HandleRef orderedList);

		/// <summary>
		/// Return a list of all processes in order from front to back given a
		/// vector direction of projection.  Use this to do visibility sorts
		/// in parallel projection mode. `orderedList' will be resized to the number
		/// of processes. The return value is the number of processes.
		/// \pre orderedList_exists: orderedList!=0
		/// </summary>
		// Token: 0x0600EA0F RID: 59919 RVA: 0x00146754 File Offset: 0x00144954
		public int ViewOrderAllProcessesInDirection(IntPtr directionOfProjection, vtkIntArray orderedList)
		{
			return vtkPKdTree.vtkPKdTree_ViewOrderAllProcessesInDirection_39(base.GetCppThis(), directionOfProjection, (orderedList == null) ? default(HandleRef) : orderedList.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400111C RID: 4380
		public new const string MRFullTypeName = "Kitware.VTK.vtkPKdTree";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400111D RID: 4381
		public new static readonly string MRClassNameKey = "class vtkPKdTree";
	}
}
