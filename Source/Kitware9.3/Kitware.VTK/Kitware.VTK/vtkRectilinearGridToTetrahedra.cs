using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRectilinearGridToTetrahedra
	/// </summary>
	/// <remarks>
	///    create a Tetrahedral mesh from a RectilinearGrid
	///
	/// vtkRectilinearGridToTetrahedra forms a mesh of Tetrahedra from a
	/// vtkRectilinearGrid.  The tetrahedra can be 5 per cell, 6 per cell,
	/// or a mixture of 5 or 12 per cell. The resulting mesh is consistent,
	/// meaning that there are no edge crossings and that each tetrahedron
	/// face is shared by two tetrahedra, except those tetrahedra on the
	/// boundary. All tetrahedra are right handed.
	///
	/// Note that 12 tetrahedra per cell means adding a point in the
	/// center of the cell.
	///
	/// In order to subdivide some cells into 5 and some cells into 12 tetrahedra:
	/// SetTetraPerCellTo5And12();
	/// Set the Scalars of the Input RectilinearGrid to be 5 or 12
	/// depending on what you want per cell of the RectilinearGrid.
	///
	/// If you set RememberVoxelId, the scalars of the tetrahedron
	/// will be set to the Id of the Cell in the RectilinearGrid from which
	/// the tetrahedron came.
	///
	/// @par Thanks:
	///    This class was developed by Samson J. Timoner of the
	///    MIT Artificial Intelligence Laboratory
	///
	/// </remarks>
	/// <seealso>
	///
	///    vtkDelaunay3D
	/// </seealso>
	// Token: 0x020008D6 RID: 2262
	public class vtkRectilinearGridToTetrahedra : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017639 RID: 95801 RVA: 0x0020D043 File Offset: 0x0020B243
		static vtkRectilinearGridToTetrahedra()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearGridToTetrahedra.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridToTetrahedra"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601763A RID: 95802 RVA: 0x0020D06B File Offset: 0x0020B26B
		public vtkRectilinearGridToTetrahedra(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601763B RID: 95803
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridToTetrahedra_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Form 5 Tetrahedra per cube. Do not RememberVoxelId.
		/// </summary>
		// Token: 0x0601763C RID: 95804 RVA: 0x0020D07C File Offset: 0x0020B27C
		public new static vtkRectilinearGridToTetrahedra New()
		{
			vtkRectilinearGridToTetrahedra result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridToTetrahedra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Form 5 Tetrahedra per cube. Do not RememberVoxelId.
		/// </summary>
		// Token: 0x0601763D RID: 95805 RVA: 0x0020D0D0 File Offset: 0x0020B2D0
		public vtkRectilinearGridToTetrahedra() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601763E RID: 95806 RVA: 0x0020D114 File Offset: 0x0020B314
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601763F RID: 95807
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridToTetrahedra_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017640 RID: 95808 RVA: 0x0020D120 File Offset: 0x0020B320
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06017641 RID: 95809
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridToTetrahedra_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017642 RID: 95810 RVA: 0x0020D140 File Offset: 0x0020B340
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06017643 RID: 95811
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridToTetrahedra_GetRememberVoxelId_03(HandleRef pThis);

		/// <summary>
		/// Should the tetrahedra have scalar data
		/// indicating which Voxel they came from in the vtkRectilinearGrid?
		/// </summary>
		// Token: 0x06017644 RID: 95812 RVA: 0x0020D15C File Offset: 0x0020B35C
		public virtual int GetRememberVoxelId()
		{
			return vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_GetRememberVoxelId_03(base.GetCppThis());
		}

		// Token: 0x06017645 RID: 95813
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridToTetrahedra_GetTetraPerCell_04(HandleRef pThis);

		/// <summary>
		/// Set the method to divide each cell (voxel) in the RectilinearGrid
		/// into tetrahedra.
		/// </summary>
		// Token: 0x06017646 RID: 95814 RVA: 0x0020D17C File Offset: 0x0020B37C
		public virtual int GetTetraPerCell()
		{
			return vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_GetTetraPerCell_04(base.GetCppThis());
		}

		// Token: 0x06017647 RID: 95815
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridToTetrahedra_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017648 RID: 95816 RVA: 0x0020D19C File Offset: 0x0020B39C
		public override int IsA(string type)
		{
			return vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06017649 RID: 95817
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridToTetrahedra_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601764A RID: 95818 RVA: 0x0020D1BC File Offset: 0x0020B3BC
		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_IsTypeOf_06(type);
		}

		// Token: 0x0601764B RID: 95819
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridToTetrahedra_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601764C RID: 95820 RVA: 0x0020D1D8 File Offset: 0x0020B3D8
		public new vtkRectilinearGridToTetrahedra NewInstance()
		{
			vtkRectilinearGridToTetrahedra result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridToTetrahedra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601764D RID: 95821
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridToTetrahedra_RememberVoxelIdOff_09(HandleRef pThis);

		/// <summary>
		/// Should the tetrahedra have scalar data
		/// indicating which Voxel they came from in the vtkRectilinearGrid?
		/// </summary>
		// Token: 0x0601764E RID: 95822 RVA: 0x0020D232 File Offset: 0x0020B432
		public virtual void RememberVoxelIdOff()
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_RememberVoxelIdOff_09(base.GetCppThis());
		}

		// Token: 0x0601764F RID: 95823
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridToTetrahedra_RememberVoxelIdOn_10(HandleRef pThis);

		/// <summary>
		/// Should the tetrahedra have scalar data
		/// indicating which Voxel they came from in the vtkRectilinearGrid?
		/// </summary>
		// Token: 0x06017650 RID: 95824 RVA: 0x0020D241 File Offset: 0x0020B441
		public virtual void RememberVoxelIdOn()
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_RememberVoxelIdOn_10(base.GetCppThis());
		}

		// Token: 0x06017651 RID: 95825
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridToTetrahedra_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017652 RID: 95826 RVA: 0x0020D250 File Offset: 0x0020B450
		public new static vtkRectilinearGridToTetrahedra SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearGridToTetrahedra vtkRectilinearGridToTetrahedra = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGridToTetrahedra = (vtkRectilinearGridToTetrahedra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGridToTetrahedra.Register(null);
				}
			}
			return vtkRectilinearGridToTetrahedra;
		}

		// Token: 0x06017653 RID: 95827
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridToTetrahedra_SetInput_12(HandleRef pThis, IntPtr Extent, IntPtr Spacing, double tol);

		/// <summary>
		/// This function for convenience for creating a Rectilinear Grid
		/// If Spacing does not fit evenly into extent, the last cell will
		/// have a different width (or height or depth).
		/// If Extent[i]/Spacing[i] is within tol of an integer, then
		/// assume the programmer meant an integer for direction i.
		/// </summary>
		// Token: 0x06017654 RID: 95828 RVA: 0x0020D2CF File Offset: 0x0020B4CF
		public void SetInput(IntPtr Extent, IntPtr Spacing, double tol)
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SetInput_12(base.GetCppThis(), Extent, Spacing, tol);
		}

		// Token: 0x06017655 RID: 95829
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridToTetrahedra_SetInput_13(HandleRef pThis, double ExtentX, double ExtentY, double ExtentZ, double SpacingX, double SpacingY, double SpacingZ, double tol);

		/// <summary>
		/// This version of the function for the wrappers
		/// </summary>
		// Token: 0x06017656 RID: 95830 RVA: 0x0020D2E1 File Offset: 0x0020B4E1
		public void SetInput(double ExtentX, double ExtentY, double ExtentZ, double SpacingX, double SpacingY, double SpacingZ, double tol)
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SetInput_13(base.GetCppThis(), ExtentX, ExtentY, ExtentZ, SpacingX, SpacingY, SpacingZ, tol);
		}

		// Token: 0x06017657 RID: 95831
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridToTetrahedra_SetRememberVoxelId_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Should the tetrahedra have scalar data
		/// indicating which Voxel they came from in the vtkRectilinearGrid?
		/// </summary>
		// Token: 0x06017658 RID: 95832 RVA: 0x0020D2FB File Offset: 0x0020B4FB
		public virtual void SetRememberVoxelId(int _arg)
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SetRememberVoxelId_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06017659 RID: 95833
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridToTetrahedra_SetTetraPerCell_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the method to divide each cell (voxel) in the RectilinearGrid
		/// into tetrahedra.
		/// </summary>
		// Token: 0x0601765A RID: 95834 RVA: 0x0020D30B File Offset: 0x0020B50B
		public virtual void SetTetraPerCell(int _arg)
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SetTetraPerCell_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0601765B RID: 95835
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridToTetrahedra_SetTetraPerCellTo12_16(HandleRef pThis);

		/// <summary>
		/// Set the method to divide each cell (voxel) in the RectilinearGrid
		/// into tetrahedra.
		/// </summary>
		// Token: 0x0601765C RID: 95836 RVA: 0x0020D31B File Offset: 0x0020B51B
		public void SetTetraPerCellTo12()
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SetTetraPerCellTo12_16(base.GetCppThis());
		}

		// Token: 0x0601765D RID: 95837
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridToTetrahedra_SetTetraPerCellTo5_17(HandleRef pThis);

		/// <summary>
		/// Set the method to divide each cell (voxel) in the RectilinearGrid
		/// into tetrahedra.
		/// </summary>
		// Token: 0x0601765E RID: 95838 RVA: 0x0020D32A File Offset: 0x0020B52A
		public void SetTetraPerCellTo5()
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SetTetraPerCellTo5_17(base.GetCppThis());
		}

		// Token: 0x0601765F RID: 95839
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridToTetrahedra_SetTetraPerCellTo5And12_18(HandleRef pThis);

		/// <summary>
		/// Set the method to divide each cell (voxel) in the RectilinearGrid
		/// into tetrahedra.
		/// </summary>
		// Token: 0x06017660 RID: 95840 RVA: 0x0020D339 File Offset: 0x0020B539
		public void SetTetraPerCellTo5And12()
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SetTetraPerCellTo5And12_18(base.GetCppThis());
		}

		// Token: 0x06017661 RID: 95841
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridToTetrahedra_SetTetraPerCellTo6_19(HandleRef pThis);

		/// <summary>
		/// Set the method to divide each cell (voxel) in the RectilinearGrid
		/// into tetrahedra.
		/// </summary>
		// Token: 0x06017662 RID: 95842 RVA: 0x0020D348 File Offset: 0x0020B548
		public void SetTetraPerCellTo6()
		{
			vtkRectilinearGridToTetrahedra.vtkRectilinearGridToTetrahedra_SetTetraPerCellTo6_19(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A1F RID: 6687
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridToTetrahedra";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A20 RID: 6688
		public new static readonly string MRClassNameKey = "class vtkRectilinearGridToTetrahedra";
	}
}
