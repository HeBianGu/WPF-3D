using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredGridConnectivity
	///
	///
	///  vtkStructuredGridConnectivity is a concrete instance of vtkObject that
	///  implements functionality for computing the neighboring topology within a
	///  single partitioned structured grid dataset. This class implementation does
	///  not have any support for distributed data. For the parallel implementation
	///  see vtkPStructuredGridConnectivity.
	///
	/// </summary>
	/// <seealso>
	///
	///  vtkPStructuredGridConnectivity
	/// </seealso>
	// Token: 0x02000914 RID: 2324
	public class vtkStructuredGridConnectivity : vtkAbstractGridConnectivity
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018142 RID: 98626 RVA: 0x0021B2D7 File Offset: 0x002194D7
		static vtkStructuredGridConnectivity()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredGridConnectivity.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridConnectivity"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018143 RID: 98627 RVA: 0x0021B2FF File Offset: 0x002194FF
		public vtkStructuredGridConnectivity(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018144 RID: 98628
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridConnectivity_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018145 RID: 98629 RVA: 0x0021B310 File Offset: 0x00219510
		public new static vtkStructuredGridConnectivity New()
		{
			vtkStructuredGridConnectivity result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridConnectivity)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018146 RID: 98630 RVA: 0x0021B364 File Offset: 0x00219564
		public vtkStructuredGridConnectivity() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018147 RID: 98631 RVA: 0x0021B3A8 File Offset: 0x002195A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018148 RID: 98632
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridConnectivity_ComputeNeighbors_01(HandleRef pThis);

		/// <summary>
		/// Computes neighboring information
		/// </summary>
		// Token: 0x06018149 RID: 98633 RVA: 0x0021B3B3 File Offset: 0x002195B3
		public override void ComputeNeighbors()
		{
			vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_ComputeNeighbors_01(base.GetCppThis());
		}

		// Token: 0x0601814A RID: 98634
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridConnectivity_CreateGhostLayers_02(HandleRef pThis, int N);

		/// <summary>
		/// Creates ghost layers.
		/// </summary>
		// Token: 0x0601814B RID: 98635 RVA: 0x0021B3C2 File Offset: 0x002195C2
		public override void CreateGhostLayers(int N)
		{
			vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_CreateGhostLayers_02(base.GetCppThis(), N);
		}

		// Token: 0x0601814C RID: 98636
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridConnectivity_FillGhostArrays_03(HandleRef pThis, int gridID, HandleRef nodesArray, HandleRef cellsArray);

		/// <summary>
		/// Fills the mesh property arrays, nodes and cells, for the grid
		/// corresponding to the given grid ID.
		/// NOTE: this method assumes that ComputeNeighbors() has been called.
		/// </summary>
		// Token: 0x0601814D RID: 98637 RVA: 0x0021B3D4 File Offset: 0x002195D4
		public virtual void FillGhostArrays(int gridID, vtkUnsignedCharArray nodesArray, vtkUnsignedCharArray cellsArray)
		{
			vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_FillGhostArrays_03(base.GetCppThis(), gridID, (nodesArray == null) ? default(HandleRef) : nodesArray.GetCppThis(), (cellsArray == null) ? default(HandleRef) : cellsArray.GetCppThis());
		}

		// Token: 0x0601814E RID: 98638
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridConnectivity_GetDataDimension_04(HandleRef pThis);

		/// <summary>
		/// Returns the data dimension based on the whole extent
		/// </summary>
		// Token: 0x0601814F RID: 98639 RVA: 0x0021B41C File Offset: 0x0021961C
		public virtual int GetDataDimension()
		{
			return vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_GetDataDimension_04(base.GetCppThis());
		}

		// Token: 0x06018150 RID: 98640
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridConnectivity_GetGhostedGridExtent_05(HandleRef pThis, int gridID, IntPtr ext);

		/// <summary>
		/// Returns the ghosted grid extent for the block corresponding the
		/// </summary>
		// Token: 0x06018151 RID: 98641 RVA: 0x0021B43B File Offset: 0x0021963B
		public void GetGhostedGridExtent(int gridID, IntPtr ext)
		{
			vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_GetGhostedGridExtent_05(base.GetCppThis(), gridID, ext);
		}

		// Token: 0x06018152 RID: 98642
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridConnectivity_GetGridExtent_06(HandleRef pThis, int gridID, IntPtr extent);

		/// <summary>
		/// Returns the grid extent of the grid corresponding to the given grid ID.
		/// </summary>
		// Token: 0x06018153 RID: 98643 RVA: 0x0021B44C File Offset: 0x0021964C
		public void GetGridExtent(int gridID, IntPtr extent)
		{
			vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_GetGridExtent_06(base.GetCppThis(), gridID, extent);
		}

		// Token: 0x06018154 RID: 98644
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridConnectivity_GetNeighbors_07(HandleRef pThis, int gridID, IntPtr extents, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the list of neighboring blocks for the given grid and the
		/// corresponding overlapping extents are filled in the 1-D flat array
		/// strided by 6.
		///
		/// NOTE: the flat array extents must be pre-allocated.
		/// </summary>
		// Token: 0x06018155 RID: 98645 RVA: 0x0021B460 File Offset: 0x00219660
		public vtkIdList GetNeighbors(int gridID, IntPtr extents)
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_GetNeighbors_07(base.GetCppThis(), gridID, extents, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		// Token: 0x06018156 RID: 98646
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridConnectivity_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018157 RID: 98647 RVA: 0x0021B4D4 File Offset: 0x002196D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06018158 RID: 98648
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridConnectivity_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018159 RID: 98649 RVA: 0x0021B4F4 File Offset: 0x002196F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0601815A RID: 98650
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridConnectivity_GetNumberOfNeighbors_10(HandleRef pThis, int gridID);

		/// <summary>
		/// Returns the number of neighbors for the grid corresponding to the given
		/// grid ID.
		/// </summary>
		// Token: 0x0601815B RID: 98651 RVA: 0x0021B510 File Offset: 0x00219710
		public int GetNumberOfNeighbors(int gridID)
		{
			return vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_GetNumberOfNeighbors_10(base.GetCppThis(), gridID);
		}

		// Token: 0x0601815C RID: 98652
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridConnectivity_GetWholeExtent_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the whole extent of the grid
		/// </summary>
		// Token: 0x0601815D RID: 98653 RVA: 0x0021B530 File Offset: 0x00219730
		public virtual int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_GetWholeExtent_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601815E RID: 98654
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridConnectivity_GetWholeExtent_12(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set/Get the whole extent of the grid
		/// </summary>
		// Token: 0x0601815F RID: 98655 RVA: 0x0021B578 File Offset: 0x00219778
		public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_GetWholeExtent_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06018160 RID: 98656
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridConnectivity_GetWholeExtent_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the whole extent of the grid
		/// </summary>
		// Token: 0x06018161 RID: 98657 RVA: 0x0021B590 File Offset: 0x00219790
		public virtual void GetWholeExtent(IntPtr _arg)
		{
			vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_GetWholeExtent_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06018162 RID: 98658
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridConnectivity_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018163 RID: 98659 RVA: 0x0021B5A0 File Offset: 0x002197A0
		public override int IsA(string type)
		{
			return vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06018164 RID: 98660
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridConnectivity_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018165 RID: 98661 RVA: 0x0021B5C0 File Offset: 0x002197C0
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_IsTypeOf_15(type);
		}

		// Token: 0x06018166 RID: 98662
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridConnectivity_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018167 RID: 98663 RVA: 0x0021B5DC File Offset: 0x002197DC
		public new vtkStructuredGridConnectivity NewInstance()
		{
			vtkStructuredGridConnectivity result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridConnectivity)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018168 RID: 98664
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridConnectivity_RegisterGrid_18(HandleRef pThis, int gridID, IntPtr extents, HandleRef nodesGhostArray, HandleRef cellGhostArray, HandleRef pointData, HandleRef cellData, HandleRef gridNodes);

		/// <summary>
		/// Registers the current grid corresponding to the grid ID by its global
		/// extent w.r.t. the whole extent.
		/// </summary>
		// Token: 0x06018169 RID: 98665 RVA: 0x0021B638 File Offset: 0x00219838
		public virtual void RegisterGrid(int gridID, IntPtr extents, vtkUnsignedCharArray nodesGhostArray, vtkUnsignedCharArray cellGhostArray, vtkPointData pointData, vtkCellData cellData, vtkPoints gridNodes)
		{
			vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_RegisterGrid_18(base.GetCppThis(), gridID, extents, (nodesGhostArray == null) ? default(HandleRef) : nodesGhostArray.GetCppThis(), (cellGhostArray == null) ? default(HandleRef) : cellGhostArray.GetCppThis(), (pointData == null) ? default(HandleRef) : pointData.GetCppThis(), (cellData == null) ? default(HandleRef) : cellData.GetCppThis(), (gridNodes == null) ? default(HandleRef) : gridNodes.GetCppThis());
		}

		// Token: 0x0601816A RID: 98666
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridConnectivity_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601816B RID: 98667 RVA: 0x0021B6C8 File Offset: 0x002198C8
		public new static vtkStructuredGridConnectivity SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredGridConnectivity vtkStructuredGridConnectivity = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGridConnectivity = (vtkStructuredGridConnectivity)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGridConnectivity.Register(null);
				}
			}
			return vtkStructuredGridConnectivity;
		}

		// Token: 0x0601816C RID: 98668
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridConnectivity_SetGhostedGridExtent_20(HandleRef pThis, int gridID, IntPtr ext);

		/// <summary>
		/// Sets the ghosted grid extent for the grid corresponding to the given
		/// grid ID to the given extent.
		/// </summary>
		// Token: 0x0601816D RID: 98669 RVA: 0x0021B747 File Offset: 0x00219947
		public void SetGhostedGridExtent(int gridID, IntPtr ext)
		{
			vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_SetGhostedGridExtent_20(base.GetCppThis(), gridID, ext);
		}

		// Token: 0x0601816E RID: 98670
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridConnectivity_SetNumberOfGrids_21(HandleRef pThis, uint N);

		/// <summary>
		/// Set/Get the total number of domains distributed among processors
		/// </summary>
		// Token: 0x0601816F RID: 98671 RVA: 0x0021B758 File Offset: 0x00219958
		public override void SetNumberOfGrids(uint N)
		{
			vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_SetNumberOfGrids_21(base.GetCppThis(), N);
		}

		// Token: 0x06018170 RID: 98672
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridConnectivity_SetWholeExtent_22(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Set/Get the whole extent of the grid
		/// </summary>
		// Token: 0x06018171 RID: 98673 RVA: 0x0021B768 File Offset: 0x00219968
		public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_SetWholeExtent_22(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06018172 RID: 98674
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridConnectivity_SetWholeExtent_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the whole extent of the grid
		/// </summary>
		// Token: 0x06018173 RID: 98675 RVA: 0x0021B780 File Offset: 0x00219980
		public virtual void SetWholeExtent(IntPtr _arg)
		{
			vtkStructuredGridConnectivity.vtkStructuredGridConnectivity_SetWholeExtent_23(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AD2 RID: 6866
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridConnectivity";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AD3 RID: 6867
		public new static readonly string MRClassNameKey = "class vtkStructuredGridConnectivity";
	}
}
