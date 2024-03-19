using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredAMRGridConnectivity
	///  grid connectivity.
	///
	///
	///  A concrete instance of vtkAbstractGridConnectivity that implements
	///  functionality for computing the neighboring topology within a structured
	///  AMR grid, as well as, generating ghost-layers. Support is provided for
	///  1-D, 2-D (XY,XZ,YZ) and 3-D cell-centered datasets. This implementation
	///  does not have any support for distributed data. For the parallel
	///  implementation see vtkPStructuredAMRGridConnectivity.
	///
	/// </summary>
	/// <seealso>
	///
	///  vtkPStructuredAMRGridConnectivity vtkAbstractGridConnectivity
	/// </seealso>
	// Token: 0x02000913 RID: 2323
	public class vtkStructuredAMRGridConnectivity : vtkAbstractGridConnectivity
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018116 RID: 98582 RVA: 0x0021AE5F File Offset: 0x0021905F
		static vtkStructuredAMRGridConnectivity()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredAMRGridConnectivity.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredAMRGridConnectivity"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018117 RID: 98583 RVA: 0x0021AE87 File Offset: 0x00219087
		public vtkStructuredAMRGridConnectivity(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018118 RID: 98584
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredAMRGridConnectivity_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018119 RID: 98585 RVA: 0x0021AE98 File Offset: 0x00219098
		public new static vtkStructuredAMRGridConnectivity New()
		{
			vtkStructuredAMRGridConnectivity result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredAMRGridConnectivity)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601811A RID: 98586 RVA: 0x0021AEEC File Offset: 0x002190EC
		public vtkStructuredAMRGridConnectivity() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601811B RID: 98587 RVA: 0x0021AF30 File Offset: 0x00219130
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601811C RID: 98588
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredAMRGridConnectivity_ComputeNeighbors_01(HandleRef pThis);

		/// <summary>
		/// Computes neighboring information.
		/// </summary>
		// Token: 0x0601811D RID: 98589 RVA: 0x0021AF3B File Offset: 0x0021913B
		public override void ComputeNeighbors()
		{
			vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_ComputeNeighbors_01(base.GetCppThis());
		}

		// Token: 0x0601811E RID: 98590
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredAMRGridConnectivity_CreateGhostLayers_02(HandleRef pThis, int N);

		/// <summary>
		/// Creates ghost layers.
		/// </summary>
		// Token: 0x0601811F RID: 98591 RVA: 0x0021AF4A File Offset: 0x0021914A
		public override void CreateGhostLayers(int N)
		{
			vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_CreateGhostLayers_02(base.GetCppThis(), N);
		}

		// Token: 0x06018120 RID: 98592
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredAMRGridConnectivity_GetBalancedRefinement_03(HandleRef pThis);

		/// <summary>
		/// Get/Set macro for BalancedRefinement property, default is true. If the
		/// refinement is balanced, then, adjacent grids in the AMR hierarchy can
		/// only differ by one level. By default, a balanced refinement is assumed.
		/// </summary>
		// Token: 0x06018121 RID: 98593 RVA: 0x0021AF5C File Offset: 0x0021915C
		public virtual bool GetBalancedRefinement()
		{
			return vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_GetBalancedRefinement_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06018122 RID: 98594
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredAMRGridConnectivity_GetCellCentered_04(HandleRef pThis);

		/// <summary>
		/// Get/Set CellCentered property which indicates if the data is cell-centered
		/// By default, cell-centered is set to true.
		/// </summary>
		// Token: 0x06018123 RID: 98595 RVA: 0x0021AF84 File Offset: 0x00219184
		public virtual bool GetCellCentered()
		{
			return vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_GetCellCentered_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06018124 RID: 98596
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredAMRGridConnectivity_GetGhostedExtent_05(HandleRef pThis, int gridID, IntPtr ext);

		/// <summary>
		/// Returns the ghost extend for the grid corresponding to the given grid ID.
		/// </summary>
		// Token: 0x06018125 RID: 98597 RVA: 0x0021AFAA File Offset: 0x002191AA
		public void GetGhostedExtent(int gridID, IntPtr ext)
		{
			vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_GetGhostedExtent_05(base.GetCppThis(), gridID, ext);
		}

		// Token: 0x06018126 RID: 98598
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredAMRGridConnectivity_GetNodeCentered_06(HandleRef pThis);

		/// <summary>
		/// Get/Set macro NodeCentered property which indicates if the data is
		/// node-centered or cell-centered. By default, node-centered is set to false
		/// since AMR datasets are primarily cell-centered.
		/// </summary>
		// Token: 0x06018127 RID: 98599 RVA: 0x0021AFBC File Offset: 0x002191BC
		public virtual bool GetNodeCentered()
		{
			return vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_GetNodeCentered_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06018128 RID: 98600
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredAMRGridConnectivity_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018129 RID: 98601 RVA: 0x0021AFE4 File Offset: 0x002191E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601812A RID: 98602
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredAMRGridConnectivity_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601812B RID: 98603 RVA: 0x0021B004 File Offset: 0x00219204
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601812C RID: 98604
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredAMRGridConnectivity_GetNumberOfNeighbors_09(HandleRef pThis, int gridID);

		/// <summary>
		/// Returns the number of neighbors for the grid corresponding to the given
		/// grid ID.
		/// </summary>
		// Token: 0x0601812D RID: 98605 RVA: 0x0021B020 File Offset: 0x00219220
		public int GetNumberOfNeighbors(int gridID)
		{
			return vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_GetNumberOfNeighbors_09(base.GetCppThis(), gridID);
		}

		// Token: 0x0601812E RID: 98606
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredAMRGridConnectivity_Initialize_10(HandleRef pThis, uint NumberOfLevels, uint N, int RefinementRatio);

		/// <summary>
		/// Initializes this instance of vtkStructuredAMRGridConnectivity where N
		/// is the total number of grids in the AMR hierarchy. Optionally, if the
		/// AMR dataset has a constant refinement, it should be specified during
		/// initialization as the code optimizes for it. If a -1 or no refinement
		/// ratio is specified a varying refinement ratio is assumed.
		/// </summary>
		// Token: 0x0601812F RID: 98607 RVA: 0x0021B040 File Offset: 0x00219240
		public void Initialize(uint NumberOfLevels, uint N, int RefinementRatio)
		{
			vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_Initialize_10(base.GetCppThis(), NumberOfLevels, N, RefinementRatio);
		}

		// Token: 0x06018130 RID: 98608
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredAMRGridConnectivity_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018131 RID: 98609 RVA: 0x0021B054 File Offset: 0x00219254
		public override int IsA(string type)
		{
			return vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06018132 RID: 98610
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredAMRGridConnectivity_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018133 RID: 98611 RVA: 0x0021B074 File Offset: 0x00219274
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_IsTypeOf_12(type);
		}

		// Token: 0x06018134 RID: 98612
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredAMRGridConnectivity_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018135 RID: 98613 RVA: 0x0021B090 File Offset: 0x00219290
		public new vtkStructuredAMRGridConnectivity NewInstance()
		{
			vtkStructuredAMRGridConnectivity result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredAMRGridConnectivity)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018136 RID: 98614
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredAMRGridConnectivity_RegisterGrid_15(HandleRef pThis, int gridIdx, int level, int refinementRatio, IntPtr extents, HandleRef nodesGhostArray, HandleRef cellGhostArray, HandleRef pointData, HandleRef cellData, HandleRef gridNodes);

		/// <summary>
		/// Registers the AMR grid with the given global linear grid ID (starting
		/// numbering from 0) and level and refinement ratio. This method is to be
		/// used when the refinement ratio is not constant.
		/// </summary>
		// Token: 0x06018137 RID: 98615 RVA: 0x0021B0EC File Offset: 0x002192EC
		public virtual void RegisterGrid(int gridIdx, int level, int refinementRatio, IntPtr extents, vtkUnsignedCharArray nodesGhostArray, vtkUnsignedCharArray cellGhostArray, vtkPointData pointData, vtkCellData cellData, vtkPoints gridNodes)
		{
			vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_RegisterGrid_15(base.GetCppThis(), gridIdx, level, refinementRatio, extents, (nodesGhostArray == null) ? default(HandleRef) : nodesGhostArray.GetCppThis(), (cellGhostArray == null) ? default(HandleRef) : cellGhostArray.GetCppThis(), (pointData == null) ? default(HandleRef) : pointData.GetCppThis(), (cellData == null) ? default(HandleRef) : cellData.GetCppThis(), (gridNodes == null) ? default(HandleRef) : gridNodes.GetCppThis());
		}

		// Token: 0x06018138 RID: 98616
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredAMRGridConnectivity_RegisterGrid_16(HandleRef pThis, int gridIdx, int level, IntPtr extents, HandleRef nodesGhostArray, HandleRef cellGhostArray, HandleRef pointData, HandleRef cellData, HandleRef gridNodes);

		/// <summary>
		/// Registers the AMR grid with the given global linear grid ID (starting
		/// numbering from 0) and level. The extents of the grid are expected to be
		/// global node extents.
		/// </summary>
		// Token: 0x06018139 RID: 98617 RVA: 0x0021B180 File Offset: 0x00219380
		public virtual void RegisterGrid(int gridIdx, int level, IntPtr extents, vtkUnsignedCharArray nodesGhostArray, vtkUnsignedCharArray cellGhostArray, vtkPointData pointData, vtkCellData cellData, vtkPoints gridNodes)
		{
			vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_RegisterGrid_16(base.GetCppThis(), gridIdx, level, extents, (nodesGhostArray == null) ? default(HandleRef) : nodesGhostArray.GetCppThis(), (cellGhostArray == null) ? default(HandleRef) : cellGhostArray.GetCppThis(), (pointData == null) ? default(HandleRef) : pointData.GetCppThis(), (cellData == null) ? default(HandleRef) : cellData.GetCppThis(), (gridNodes == null) ? default(HandleRef) : gridNodes.GetCppThis());
		}

		// Token: 0x0601813A RID: 98618
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredAMRGridConnectivity_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601813B RID: 98619 RVA: 0x0021B210 File Offset: 0x00219410
		public new static vtkStructuredAMRGridConnectivity SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredAMRGridConnectivity vtkStructuredAMRGridConnectivity = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredAMRGridConnectivity = (vtkStructuredAMRGridConnectivity)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredAMRGridConnectivity.Register(null);
				}
			}
			return vtkStructuredAMRGridConnectivity;
		}

		// Token: 0x0601813C RID: 98620
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredAMRGridConnectivity_SetBalancedRefinement_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set macro for BalancedRefinement property, default is true. If the
		/// refinement is balanced, then, adjacent grids in the AMR hierarchy can
		/// only differ by one level. By default, a balanced refinement is assumed.
		/// </summary>
		// Token: 0x0601813D RID: 98621 RVA: 0x0021B28F File Offset: 0x0021948F
		public virtual void SetBalancedRefinement(bool _arg)
		{
			vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_SetBalancedRefinement_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601813E RID: 98622
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredAMRGridConnectivity_SetCellCentered_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set CellCentered property which indicates if the data is cell-centered
		/// By default, cell-centered is set to true.
		/// </summary>
		// Token: 0x0601813F RID: 98623 RVA: 0x0021B2A7 File Offset: 0x002194A7
		public virtual void SetCellCentered(bool _arg)
		{
			vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_SetCellCentered_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06018140 RID: 98624
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredAMRGridConnectivity_SetNodeCentered_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set macro NodeCentered property which indicates if the data is
		/// node-centered or cell-centered. By default, node-centered is set to false
		/// since AMR datasets are primarily cell-centered.
		/// </summary>
		// Token: 0x06018141 RID: 98625 RVA: 0x0021B2BF File Offset: 0x002194BF
		public virtual void SetNodeCentered(bool _arg)
		{
			vtkStructuredAMRGridConnectivity.vtkStructuredAMRGridConnectivity_SetNodeCentered_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AD0 RID: 6864
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredAMRGridConnectivity";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AD1 RID: 6865
		public new static readonly string MRClassNameKey = "class vtkStructuredAMRGridConnectivity";
	}
}
