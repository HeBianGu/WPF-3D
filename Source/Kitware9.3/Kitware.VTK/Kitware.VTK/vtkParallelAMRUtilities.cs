using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParallelAMRUtilities
	///
	///
	///  A concrete instance of vtkObject that employs a singleton design
	///  pattern and implements functionality for AMR specific operations.
	///
	/// </summary>
	/// <seealso>
	///
	///  vtkOverlappingAMR, vtkAMRBox
	/// </seealso>
	// Token: 0x020004F0 RID: 1264
	public class vtkParallelAMRUtilities : vtkAMRUtilities
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E436 RID: 58422 RVA: 0x0013DC0E File Offset: 0x0013BE0E
		static vtkParallelAMRUtilities()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelAMRUtilities.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelAMRUtilities"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E437 RID: 58423 RVA: 0x0013DC36 File Offset: 0x0013BE36
		public vtkParallelAMRUtilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E438 RID: 58424 RVA: 0x0013DC44 File Offset: 0x0013BE44
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E439 RID: 58425
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelAMRUtilities_BlankCells_01(HandleRef amr, HandleRef myController);

		/// <summary>
		/// Blank cells in overlapping AMR
		/// </summary>
		// Token: 0x0600E43A RID: 58426 RVA: 0x0013DC50 File Offset: 0x0013BE50
		public static void BlankCells(vtkOverlappingAMR amr, vtkMultiProcessController myController)
		{
			vtkParallelAMRUtilities.vtkParallelAMRUtilities_BlankCells_01((amr == null) ? default(HandleRef) : amr.GetCppThis(), (myController == null) ? default(HandleRef) : myController.GetCppThis());
		}

		// Token: 0x0600E43B RID: 58427
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelAMRUtilities_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E43C RID: 58428 RVA: 0x0013DC90 File Offset: 0x0013BE90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParallelAMRUtilities.vtkParallelAMRUtilities_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E43D RID: 58429
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelAMRUtilities_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E43E RID: 58430 RVA: 0x0013DCB0 File Offset: 0x0013BEB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParallelAMRUtilities.vtkParallelAMRUtilities_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E43F RID: 58431
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelAMRUtilities_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E440 RID: 58432 RVA: 0x0013DCCC File Offset: 0x0013BECC
		public override int IsA(string type)
		{
			return vtkParallelAMRUtilities.vtkParallelAMRUtilities_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600E441 RID: 58433
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelAMRUtilities_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E442 RID: 58434 RVA: 0x0013DCEC File Offset: 0x0013BEEC
		public new static int IsTypeOf(string type)
		{
			return vtkParallelAMRUtilities.vtkParallelAMRUtilities_IsTypeOf_05(type);
		}

		// Token: 0x0600E443 RID: 58435
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelAMRUtilities_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E444 RID: 58436 RVA: 0x0013DD08 File Offset: 0x0013BF08
		public new vtkParallelAMRUtilities NewInstance()
		{
			vtkParallelAMRUtilities result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelAMRUtilities.vtkParallelAMRUtilities_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelAMRUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E445 RID: 58437
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelAMRUtilities_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E446 RID: 58438 RVA: 0x0013DD64 File Offset: 0x0013BF64
		public new static vtkParallelAMRUtilities SafeDownCast(vtkObjectBase o)
		{
			vtkParallelAMRUtilities vtkParallelAMRUtilities = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelAMRUtilities.vtkParallelAMRUtilities_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelAMRUtilities = (vtkParallelAMRUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelAMRUtilities.Register(null);
				}
			}
			return vtkParallelAMRUtilities;
		}

		// Token: 0x0600E447 RID: 58439
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelAMRUtilities_StripGhostLayers_08(HandleRef ghostedAMRData, HandleRef strippedAMRData, HandleRef myController);

		/// <summary>
		/// This method detects and strips partially overlapping cells from a
		/// given AMR dataset. If ghost layers are detected, they are removed and
		/// new grid instances are created to represent the stripped
		/// data-set otherwise, each block is shallow-copied.
		///
		/// .SECTION Assumptions
		/// 1) The ghosted AMR data must have complete metadata information.
		/// </summary>
		// Token: 0x0600E448 RID: 58440 RVA: 0x0013DDE4 File Offset: 0x0013BFE4
		public static void StripGhostLayers(vtkOverlappingAMR ghostedAMRData, vtkOverlappingAMR strippedAMRData, vtkMultiProcessController myController)
		{
			vtkParallelAMRUtilities.vtkParallelAMRUtilities_StripGhostLayers_08((ghostedAMRData == null) ? default(HandleRef) : ghostedAMRData.GetCppThis(), (strippedAMRData == null) ? default(HandleRef) : strippedAMRData.GetCppThis(), (myController == null) ? default(HandleRef) : myController.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010C5 RID: 4293
		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelAMRUtilities";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010C6 RID: 4294
		public new static readonly string MRClassNameKey = "class vtkParallelAMRUtilities";
	}
}
