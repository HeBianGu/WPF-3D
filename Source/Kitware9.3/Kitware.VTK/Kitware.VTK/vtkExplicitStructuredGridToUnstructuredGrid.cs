using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExplicitStructuredGridToUnstructuredGrid
	/// </summary>
	/// <remarks>
	///    Filter which converts an explicit structured grid into an unstructured grid.
	/// </remarks>
	// Token: 0x02000962 RID: 2402
	public class vtkExplicitStructuredGridToUnstructuredGrid : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018FC4 RID: 102340 RVA: 0x0022DA7C File Offset: 0x0022BC7C
		static vtkExplicitStructuredGridToUnstructuredGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExplicitStructuredGridToUnstructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExplicitStructuredGridToUnstructuredGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018FC5 RID: 102341 RVA: 0x0022DAA4 File Offset: 0x0022BCA4
		public vtkExplicitStructuredGridToUnstructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018FC6 RID: 102342
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridToUnstructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018FC7 RID: 102343 RVA: 0x0022DAB4 File Offset: 0x0022BCB4
		public new static vtkExplicitStructuredGridToUnstructuredGrid New()
		{
			vtkExplicitStructuredGridToUnstructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGridToUnstructuredGrid.vtkExplicitStructuredGridToUnstructuredGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExplicitStructuredGridToUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018FC8 RID: 102344 RVA: 0x0022DB08 File Offset: 0x0022BD08
		public vtkExplicitStructuredGridToUnstructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExplicitStructuredGridToUnstructuredGrid.vtkExplicitStructuredGridToUnstructuredGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018FC9 RID: 102345 RVA: 0x0022DB4C File Offset: 0x0022BD4C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018FCA RID: 102346
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExplicitStructuredGridToUnstructuredGrid_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018FCB RID: 102347 RVA: 0x0022DB58 File Offset: 0x0022BD58
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExplicitStructuredGridToUnstructuredGrid.vtkExplicitStructuredGridToUnstructuredGrid_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06018FCC RID: 102348
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExplicitStructuredGridToUnstructuredGrid_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018FCD RID: 102349 RVA: 0x0022DB78 File Offset: 0x0022BD78
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExplicitStructuredGridToUnstructuredGrid.vtkExplicitStructuredGridToUnstructuredGrid_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06018FCE RID: 102350
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGridToUnstructuredGrid_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018FCF RID: 102351 RVA: 0x0022DB94 File Offset: 0x0022BD94
		public override int IsA(string type)
		{
			return vtkExplicitStructuredGridToUnstructuredGrid.vtkExplicitStructuredGridToUnstructuredGrid_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06018FD0 RID: 102352
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGridToUnstructuredGrid_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018FD1 RID: 102353 RVA: 0x0022DBB4 File Offset: 0x0022BDB4
		public new static int IsTypeOf(string type)
		{
			return vtkExplicitStructuredGridToUnstructuredGrid.vtkExplicitStructuredGridToUnstructuredGrid_IsTypeOf_04(type);
		}

		// Token: 0x06018FD2 RID: 102354
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridToUnstructuredGrid_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018FD3 RID: 102355 RVA: 0x0022DBD0 File Offset: 0x0022BDD0
		public new vtkExplicitStructuredGridToUnstructuredGrid NewInstance()
		{
			vtkExplicitStructuredGridToUnstructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGridToUnstructuredGrid.vtkExplicitStructuredGridToUnstructuredGrid_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExplicitStructuredGridToUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018FD4 RID: 102356
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridToUnstructuredGrid_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018FD5 RID: 102357 RVA: 0x0022DC2C File Offset: 0x0022BE2C
		public new static vtkExplicitStructuredGridToUnstructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkExplicitStructuredGridToUnstructuredGrid vtkExplicitStructuredGridToUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGridToUnstructuredGrid.vtkExplicitStructuredGridToUnstructuredGrid_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExplicitStructuredGridToUnstructuredGrid = (vtkExplicitStructuredGridToUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExplicitStructuredGridToUnstructuredGrid.Register(null);
				}
			}
			return vtkExplicitStructuredGridToUnstructuredGrid;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B7D RID: 7037
		public new const string MRFullTypeName = "Kitware.VTK.vtkExplicitStructuredGridToUnstructuredGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B7E RID: 7038
		public new static readonly string MRClassNameKey = "class vtkExplicitStructuredGridToUnstructuredGrid";
	}
}
