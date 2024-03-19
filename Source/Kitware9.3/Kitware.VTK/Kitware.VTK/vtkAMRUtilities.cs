using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAMRUtilities
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
	// Token: 0x020004EF RID: 1263
	public class vtkAMRUtilities : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E421 RID: 58401 RVA: 0x0013D9D7 File Offset: 0x0013BBD7
		static vtkAMRUtilities()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMRUtilities.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRUtilities"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E422 RID: 58402 RVA: 0x0013D9FF File Offset: 0x0013BBFF
		public vtkAMRUtilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E423 RID: 58403 RVA: 0x0013DA0D File Offset: 0x0013BC0D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E424 RID: 58404
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRUtilities_BlankCells_01(HandleRef amr);

		/// <summary>
		/// Blank cells in overlapping AMR
		/// </summary>
		// Token: 0x0600E425 RID: 58405 RVA: 0x0013DA18 File Offset: 0x0013BC18
		public static void BlankCells(vtkOverlappingAMR amr)
		{
			vtkAMRUtilities.vtkAMRUtilities_BlankCells_01((amr == null) ? default(HandleRef) : amr.GetCppThis());
		}

		// Token: 0x0600E426 RID: 58406
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRUtilities_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E427 RID: 58407 RVA: 0x0013DA44 File Offset: 0x0013BC44
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMRUtilities.vtkAMRUtilities_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E428 RID: 58408
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRUtilities_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E429 RID: 58409 RVA: 0x0013DA64 File Offset: 0x0013BC64
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMRUtilities.vtkAMRUtilities_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E42A RID: 58410
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRUtilities_HasPartiallyOverlappingGhostCells_04(HandleRef amr);

		/// <summary>
		/// A quick test of whether partially overlapping ghost cells exist. This test
		/// starts from the highest-res boxes and checks if they have partially
		/// overlapping cells. The code returns with true once partially overlapping
		/// cells are detected. Otherwise, false is returned.
		/// </summary>
		// Token: 0x0600E42B RID: 58411 RVA: 0x0013DA80 File Offset: 0x0013BC80
		public static bool HasPartiallyOverlappingGhostCells(vtkOverlappingAMR amr)
		{
			return vtkAMRUtilities.vtkAMRUtilities_HasPartiallyOverlappingGhostCells_04((amr == null) ? default(HandleRef) : amr.GetCppThis()) != 0;
		}

		// Token: 0x0600E42C RID: 58412
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRUtilities_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E42D RID: 58413 RVA: 0x0013DAB8 File Offset: 0x0013BCB8
		public override int IsA(string type)
		{
			return vtkAMRUtilities.vtkAMRUtilities_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600E42E RID: 58414
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRUtilities_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E42F RID: 58415 RVA: 0x0013DAD8 File Offset: 0x0013BCD8
		public new static int IsTypeOf(string type)
		{
			return vtkAMRUtilities.vtkAMRUtilities_IsTypeOf_06(type);
		}

		// Token: 0x0600E430 RID: 58416
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRUtilities_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E431 RID: 58417 RVA: 0x0013DAF4 File Offset: 0x0013BCF4
		public new vtkAMRUtilities NewInstance()
		{
			vtkAMRUtilities result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRUtilities.vtkAMRUtilities_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E432 RID: 58418
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRUtilities_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E433 RID: 58419 RVA: 0x0013DB50 File Offset: 0x0013BD50
		public new static vtkAMRUtilities SafeDownCast(vtkObjectBase o)
		{
			vtkAMRUtilities vtkAMRUtilities = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRUtilities.vtkAMRUtilities_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMRUtilities = (vtkAMRUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMRUtilities.Register(null);
				}
			}
			return vtkAMRUtilities;
		}

		// Token: 0x0600E434 RID: 58420
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRUtilities_StripGhostLayers_09(HandleRef ghostedAMRData, HandleRef strippedAMRData);

		/// <summary>
		/// This method detects and strips partially overlapping cells from a
		/// given AMR dataset. If ghost layers are detected, they are removed and
		/// new grid instances are created to represent the stripped
		/// data-set otherwise, each block is shallow-copied.
		///
		/// .SECTION Assumptions
		/// 1) The ghosted AMR data must have complete metadata information.
		/// </summary>
		// Token: 0x0600E435 RID: 58421 RVA: 0x0013DBD0 File Offset: 0x0013BDD0
		public static void StripGhostLayers(vtkOverlappingAMR ghostedAMRData, vtkOverlappingAMR strippedAMRData)
		{
			vtkAMRUtilities.vtkAMRUtilities_StripGhostLayers_09((ghostedAMRData == null) ? default(HandleRef) : ghostedAMRData.GetCppThis(), (strippedAMRData == null) ? default(HandleRef) : strippedAMRData.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010C3 RID: 4291
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMRUtilities";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010C4 RID: 4292
		public new static readonly string MRClassNameKey = "class vtkAMRUtilities";
	}
}
