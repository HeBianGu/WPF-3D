using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///             \brief A registrar for cell types contained in this modul
	/// </summary>
	// Token: 0x020004CB RID: 1227
	public class vtkFiltersCellGrid : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DFDF RID: 57311 RVA: 0x00136807 File Offset: 0x00134A07
		static vtkFiltersCellGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFiltersCellGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFiltersCellGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DFE0 RID: 57312 RVA: 0x0013682F File Offset: 0x00134A2F
		public vtkFiltersCellGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DFE1 RID: 57313 RVA: 0x0013683D File Offset: 0x00134A3D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DFE2 RID: 57314
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFiltersCellGrid_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFE3 RID: 57315 RVA: 0x00136848 File Offset: 0x00134A48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFiltersCellGrid.vtkFiltersCellGrid_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600DFE4 RID: 57316
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFiltersCellGrid_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFE5 RID: 57317 RVA: 0x00136868 File Offset: 0x00134A68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFiltersCellGrid.vtkFiltersCellGrid_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600DFE6 RID: 57318
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFiltersCellGrid_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFE7 RID: 57319 RVA: 0x00136884 File Offset: 0x00134A84
		public override int IsA(string type)
		{
			return vtkFiltersCellGrid.vtkFiltersCellGrid_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600DFE8 RID: 57320
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFiltersCellGrid_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFE9 RID: 57321 RVA: 0x001368A4 File Offset: 0x00134AA4
		public new static int IsTypeOf(string type)
		{
			return vtkFiltersCellGrid.vtkFiltersCellGrid_IsTypeOf_04(type);
		}

		// Token: 0x0600DFEA RID: 57322
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFiltersCellGrid_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFEB RID: 57323 RVA: 0x001368C0 File Offset: 0x00134AC0
		public new vtkFiltersCellGrid NewInstance()
		{
			vtkFiltersCellGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFiltersCellGrid.vtkFiltersCellGrid_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFiltersCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DFEC RID: 57324
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFiltersCellGrid_RegisterCellsAndResponders_06();

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFED RID: 57325 RVA: 0x0013691C File Offset: 0x00134B1C
		public static bool RegisterCellsAndResponders()
		{
			return vtkFiltersCellGrid.vtkFiltersCellGrid_RegisterCellsAndResponders_06() != 0;
		}

		// Token: 0x0600DFEE RID: 57326
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFiltersCellGrid_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DFEF RID: 57327 RVA: 0x0013693C File Offset: 0x00134B3C
		public new static vtkFiltersCellGrid SafeDownCast(vtkObjectBase o)
		{
			vtkFiltersCellGrid vtkFiltersCellGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFiltersCellGrid.vtkFiltersCellGrid_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFiltersCellGrid = (vtkFiltersCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFiltersCellGrid.Register(null);
				}
			}
			return vtkFiltersCellGrid;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001071 RID: 4209
		public new const string MRFullTypeName = "Kitware.VTK.vtkFiltersCellGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001072 RID: 4210
		public new static readonly string MRClassNameKey = "class vtkFiltersCellGrid";
	}
}
