using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractGridConnectivity
	///
	///
	///  A superclass that defines the interface to be implemented by all
	///  concrete grid connectivity classes. Grid connectivity classes provide the
	///  mechanism to achieve the following:
	///  &lt;ul&gt;
	///    &lt;li&gt;
	///      &lt;b&gt; Handling of partitioned/distributed data &lt;/b&gt;
	///      &lt;p&gt;
	///       Construct the neighboring topology information for each partition,e.g.,
	///       used for creating communication lists and in computing statistics,i.e.,
	///       average, mean, etc.
	///      &lt;/p&gt;
	///      &lt;b&gt; Creation of ghost layers &lt;/b&gt;
	///      &lt;p&gt;
	///       Provides the mechanism for automatically generating ghost information
	///       given a partitioned/distributed grid configuration.
	///      &lt;/p&gt;
	///    &lt;/li&gt;
	///  &lt;/ul&gt;
	///
	/// </summary>
	/// <seealso>
	///
	///  vtkStructuredGridConnectivity vtkStructuredAMRGridConnectivity
	/// </seealso>
	// Token: 0x02000903 RID: 2307
	public abstract class vtkAbstractGridConnectivity : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017EF9 RID: 98041 RVA: 0x00217E2E File Offset: 0x0021602E
		static vtkAbstractGridConnectivity()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractGridConnectivity.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractGridConnectivity"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017EFA RID: 98042 RVA: 0x00217E56 File Offset: 0x00216056
		public vtkAbstractGridConnectivity(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017EFB RID: 98043 RVA: 0x00217E64 File Offset: 0x00216064
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017EFC RID: 98044
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractGridConnectivity_ComputeNeighbors_01(HandleRef pThis);

		/// <summary>
		/// Computes the grid neighboring topology for the domain
		/// </summary>
		// Token: 0x06017EFD RID: 98045 RVA: 0x00217E6F File Offset: 0x0021606F
		public virtual void ComputeNeighbors()
		{
			vtkAbstractGridConnectivity.vtkAbstractGridConnectivity_ComputeNeighbors_01(base.GetCppThis());
		}

		// Token: 0x06017EFE RID: 98046
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractGridConnectivity_CreateGhostLayers_02(HandleRef pThis, int N);

		/// <summary>
		/// Creates N layers of ghost layers where N is the number of cells that will
		/// be added to each grid. If no parameter is supplied, N has a nominal value
		/// of 1, in which case 1 layer of cells would be added.
		/// NOTE: This method is implemented by concrete implementations
		/// </summary>
		// Token: 0x06017EFF RID: 98047 RVA: 0x00217E7E File Offset: 0x0021607E
		public virtual void CreateGhostLayers(int N)
		{
			vtkAbstractGridConnectivity.vtkAbstractGridConnectivity_CreateGhostLayers_02(base.GetCppThis(), N);
		}

		// Token: 0x06017F00 RID: 98048
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractGridConnectivity_GetGhostedCellGhostArray_03(HandleRef pThis, int gridID, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the ghosted cells ghost array for the grid associated with the
		/// given grid ID. The return pointer is a shallow-copy of the internal
		/// data-structure. The pointer may be nullptr iff there is no ghosted cells
		/// ghost array for the requested grid.
		/// </summary>
		// Token: 0x06017F01 RID: 98049 RVA: 0x00217E90 File Offset: 0x00216090
		public vtkUnsignedCharArray GetGhostedCellGhostArray(int gridID)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractGridConnectivity.vtkAbstractGridConnectivity_GetGhostedCellGhostArray_03(base.GetCppThis(), gridID, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x06017F02 RID: 98050
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractGridConnectivity_GetGhostedGridCellData_04(HandleRef pThis, int gridID, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the ghosted grid cell data for the grid associated with the
		/// given grid ID. The return pointer is a shallow-copy of the internal
		/// data-structure. The pointer may be nullptr iff there is no ghosted cell
		/// data for the requested grid.
		/// </summary>
		// Token: 0x06017F03 RID: 98051 RVA: 0x00217F00 File Offset: 0x00216100
		public vtkCellData GetGhostedGridCellData(int gridID)
		{
			vtkCellData vtkCellData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractGridConnectivity.vtkAbstractGridConnectivity_GetGhostedGridCellData_04(base.GetCppThis(), gridID, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellData = (vtkCellData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellData.Register(null);
				}
			}
			return vtkCellData;
		}

		// Token: 0x06017F04 RID: 98052
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractGridConnectivity_GetGhostedGridPointData_05(HandleRef pThis, int gridID, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the ghosted grid point data for the grid associated with the
		/// given grid ID. The return pointer is a shallow-copy of the internal
		/// data-structure. The pointer may be nullptr iff there is no ghosted point
		/// data for the requested grid.
		/// </summary>
		// Token: 0x06017F05 RID: 98053 RVA: 0x00217F70 File Offset: 0x00216170
		public vtkPointData GetGhostedGridPointData(int gridID)
		{
			vtkPointData vtkPointData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractGridConnectivity.vtkAbstractGridConnectivity_GetGhostedGridPointData_05(base.GetCppThis(), gridID, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointData = (vtkPointData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointData.Register(null);
				}
			}
			return vtkPointData;
		}

		// Token: 0x06017F06 RID: 98054
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractGridConnectivity_GetGhostedPointGhostArray_06(HandleRef pThis, int gridID, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the ghosted points ghost array for the grid associated with the
		/// given grid ID. The return pointer is a shallow-copy of the internal
		/// data-structure. The pointer may be nullptr iff there is no ghosted points
		/// ghost array for the requested grid.
		/// </summary>
		// Token: 0x06017F07 RID: 98055 RVA: 0x00217FE0 File Offset: 0x002161E0
		public vtkUnsignedCharArray GetGhostedPointGhostArray(int gridID)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractGridConnectivity.vtkAbstractGridConnectivity_GetGhostedPointGhostArray_06(base.GetCppThis(), gridID, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x06017F08 RID: 98056
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractGridConnectivity_GetGhostedPoints_07(HandleRef pThis, int gridID, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the ghosted grid points for the grid associated with the given
		/// grid ID. The return pointer is a shallow-copy of the internal data
		/// structure. The pointer may be nullptr iff there are no ghosted points
		/// created for the requested grid.
		/// </summary>
		// Token: 0x06017F09 RID: 98057 RVA: 0x00218050 File Offset: 0x00216250
		public vtkPoints GetGhostedPoints(int gridID)
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractGridConnectivity.vtkAbstractGridConnectivity_GetGhostedPoints_07(base.GetCppThis(), gridID, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x06017F0A RID: 98058
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractGridConnectivity_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017F0B RID: 98059 RVA: 0x002180C0 File Offset: 0x002162C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractGridConnectivity.vtkAbstractGridConnectivity_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06017F0C RID: 98060
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractGridConnectivity_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017F0D RID: 98061 RVA: 0x002180E0 File Offset: 0x002162E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractGridConnectivity.vtkAbstractGridConnectivity_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06017F0E RID: 98062
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkAbstractGridConnectivity_GetNumberOfGhostLayers_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of ghost layers
		/// </summary>
		// Token: 0x06017F0F RID: 98063 RVA: 0x002180FC File Offset: 0x002162FC
		public virtual uint GetNumberOfGhostLayers()
		{
			return vtkAbstractGridConnectivity.vtkAbstractGridConnectivity_GetNumberOfGhostLayers_10(base.GetCppThis());
		}

		// Token: 0x06017F10 RID: 98064
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkAbstractGridConnectivity_GetNumberOfGrids_11(HandleRef pThis);

		/// <summary>
		/// Returns the total number of grids.
		/// </summary>
		// Token: 0x06017F11 RID: 98065 RVA: 0x0021811C File Offset: 0x0021631C
		public uint GetNumberOfGrids()
		{
			return vtkAbstractGridConnectivity.vtkAbstractGridConnectivity_GetNumberOfGrids_11(base.GetCppThis());
		}

		// Token: 0x06017F12 RID: 98066
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractGridConnectivity_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017F13 RID: 98067 RVA: 0x0021813C File Offset: 0x0021633C
		public override int IsA(string type)
		{
			return vtkAbstractGridConnectivity.vtkAbstractGridConnectivity_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06017F14 RID: 98068
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractGridConnectivity_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017F15 RID: 98069 RVA: 0x0021815C File Offset: 0x0021635C
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractGridConnectivity.vtkAbstractGridConnectivity_IsTypeOf_13(type);
		}

		// Token: 0x06017F16 RID: 98070
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractGridConnectivity_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017F17 RID: 98071 RVA: 0x00218178 File Offset: 0x00216378
		public new vtkAbstractGridConnectivity NewInstance()
		{
			vtkAbstractGridConnectivity result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractGridConnectivity.vtkAbstractGridConnectivity_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractGridConnectivity)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017F18 RID: 98072
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractGridConnectivity_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017F19 RID: 98073 RVA: 0x002181D4 File Offset: 0x002163D4
		public new static vtkAbstractGridConnectivity SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractGridConnectivity vtkAbstractGridConnectivity = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractGridConnectivity.vtkAbstractGridConnectivity_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractGridConnectivity = (vtkAbstractGridConnectivity)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractGridConnectivity.Register(null);
				}
			}
			return vtkAbstractGridConnectivity;
		}

		// Token: 0x06017F1A RID: 98074
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractGridConnectivity_SetNumberOfGhostLayers_16(HandleRef pThis, uint _arg);

		/// <summary>
		/// Set/Get the number of ghost layers
		/// </summary>
		// Token: 0x06017F1B RID: 98075 RVA: 0x00218253 File Offset: 0x00216453
		public virtual void SetNumberOfGhostLayers(uint _arg)
		{
			vtkAbstractGridConnectivity.vtkAbstractGridConnectivity_SetNumberOfGhostLayers_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06017F1C RID: 98076
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractGridConnectivity_SetNumberOfGrids_17(HandleRef pThis, uint N);

		/// <summary>
		/// Sets the total number of grids in the domain.
		/// Note: This method is implemented by concrete classes.
		/// NOTE: Concrete classes implementing this pure virtual method must
		/// set the number of grids and call AllocateUserRegisterDataStructures
		/// in addition to defining any other additional functionality.
		/// </summary>
		// Token: 0x06017F1D RID: 98077 RVA: 0x00218263 File Offset: 0x00216463
		public virtual void SetNumberOfGrids(uint N)
		{
			vtkAbstractGridConnectivity.vtkAbstractGridConnectivity_SetNumberOfGrids_17(base.GetCppThis(), N);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AAB RID: 6827
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractGridConnectivity";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AAC RID: 6828
		public new static readonly string MRClassNameKey = "class vtkAbstractGridConnectivity";
	}
}
