using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///             \brief A registrar for cell types contained in this modul
	/// </summary>
	// Token: 0x0200012A RID: 298
	public class vtkRenderingCellGrid : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003C5C RID: 15452 RVA: 0x00057F2B File Offset: 0x0005612B
		static vtkRenderingCellGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderingCellGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderingCellGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003C5D RID: 15453 RVA: 0x00057F53 File Offset: 0x00056153
		public vtkRenderingCellGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003C5E RID: 15454 RVA: 0x00057F61 File Offset: 0x00056161
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003C5F RID: 15455
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderingCellGrid_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C60 RID: 15456 RVA: 0x00057F6C File Offset: 0x0005616C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderingCellGrid.vtkRenderingCellGrid_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06003C61 RID: 15457
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderingCellGrid_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C62 RID: 15458 RVA: 0x00057F8C File Offset: 0x0005618C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderingCellGrid.vtkRenderingCellGrid_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06003C63 RID: 15459
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderingCellGrid_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C64 RID: 15460 RVA: 0x00057FA8 File Offset: 0x000561A8
		public override int IsA(string type)
		{
			return vtkRenderingCellGrid.vtkRenderingCellGrid_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06003C65 RID: 15461
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderingCellGrid_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C66 RID: 15462 RVA: 0x00057FC8 File Offset: 0x000561C8
		public new static int IsTypeOf(string type)
		{
			return vtkRenderingCellGrid.vtkRenderingCellGrid_IsTypeOf_04(type);
		}

		// Token: 0x06003C67 RID: 15463
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderingCellGrid_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C68 RID: 15464 RVA: 0x00057FE4 File Offset: 0x000561E4
		public new vtkRenderingCellGrid NewInstance()
		{
			vtkRenderingCellGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderingCellGrid.vtkRenderingCellGrid_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderingCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003C69 RID: 15465
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderingCellGrid_RegisterCellsAndResponders_06();

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C6A RID: 15466 RVA: 0x00058040 File Offset: 0x00056240
		public static bool RegisterCellsAndResponders()
		{
			return vtkRenderingCellGrid.vtkRenderingCellGrid_RegisterCellsAndResponders_06() != 0;
		}

		// Token: 0x06003C6B RID: 15467
		[DllImport("Kitware.VTK.RenderingCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderingCellGrid_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C6C RID: 15468 RVA: 0x00058060 File Offset: 0x00056260
		public new static vtkRenderingCellGrid SafeDownCast(vtkObjectBase o)
		{
			vtkRenderingCellGrid vtkRenderingCellGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderingCellGrid.vtkRenderingCellGrid_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderingCellGrid = (vtkRenderingCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderingCellGrid.Register(null);
				}
			}
			return vtkRenderingCellGrid;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400068D RID: 1677
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderingCellGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400068E RID: 1678
		public new static readonly string MRClassNameKey = "class vtkRenderingCellGrid";
	}
}
