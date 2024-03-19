using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///             \brief A registrar for cell types contained in this modul
	/// </summary>
	// Token: 0x020001D8 RID: 472
	public class vtkIOCellGrid : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005A8A RID: 23178 RVA: 0x00082E73 File Offset: 0x00081073
		static vtkIOCellGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIOCellGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIOCellGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005A8B RID: 23179 RVA: 0x00082E9B File Offset: 0x0008109B
		public vtkIOCellGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005A8C RID: 23180 RVA: 0x00082EA9 File Offset: 0x000810A9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005A8D RID: 23181
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIOCellGrid_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A8E RID: 23182 RVA: 0x00082EB4 File Offset: 0x000810B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIOCellGrid.vtkIOCellGrid_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06005A8F RID: 23183
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIOCellGrid_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A90 RID: 23184 RVA: 0x00082ED4 File Offset: 0x000810D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIOCellGrid.vtkIOCellGrid_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06005A91 RID: 23185
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOCellGrid_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A92 RID: 23186 RVA: 0x00082EF0 File Offset: 0x000810F0
		public override int IsA(string type)
		{
			return vtkIOCellGrid.vtkIOCellGrid_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06005A93 RID: 23187
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIOCellGrid_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A94 RID: 23188 RVA: 0x00082F10 File Offset: 0x00081110
		public new static int IsTypeOf(string type)
		{
			return vtkIOCellGrid.vtkIOCellGrid_IsTypeOf_04(type);
		}

		// Token: 0x06005A95 RID: 23189
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOCellGrid_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A96 RID: 23190 RVA: 0x00082F2C File Offset: 0x0008112C
		public new vtkIOCellGrid NewInstance()
		{
			vtkIOCellGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOCellGrid.vtkIOCellGrid_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIOCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005A97 RID: 23191
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkIOCellGrid_RegisterCellsAndResponders_06();

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A98 RID: 23192 RVA: 0x00082F88 File Offset: 0x00081188
		public static bool RegisterCellsAndResponders()
		{
			return vtkIOCellGrid.vtkIOCellGrid_RegisterCellsAndResponders_06() != 0;
		}

		// Token: 0x06005A99 RID: 23193
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIOCellGrid_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A9A RID: 23194 RVA: 0x00082FA8 File Offset: 0x000811A8
		public new static vtkIOCellGrid SafeDownCast(vtkObjectBase o)
		{
			vtkIOCellGrid vtkIOCellGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIOCellGrid.vtkIOCellGrid_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIOCellGrid = (vtkIOCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIOCellGrid.Register(null);
				}
			}
			return vtkIOCellGrid;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000879 RID: 2169
		public new const string MRFullTypeName = "Kitware.VTK.vtkIOCellGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400087A RID: 2170
		public new static readonly string MRClassNameKey = "class vtkIOCellGrid";
	}
}
