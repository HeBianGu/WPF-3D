using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridToExplicitStructuredGrid
	/// </summary>
	/// <remarks>
	///    Filter which converts an unstructured grid data into an explicit structured grid.
	///          The input grid must have a structured coordinates int cell array.
	///          Moreover, its cell must be listed in the i-j-k order (k varying more often)
	/// </remarks>
	// Token: 0x020009BE RID: 2494
	public class vtkUnstructuredGridToExplicitStructuredGrid : vtkExplicitStructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A0ED RID: 106733 RVA: 0x00241ED7 File Offset: 0x002400D7
		static vtkUnstructuredGridToExplicitStructuredGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridToExplicitStructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridToExplicitStructuredGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A0EE RID: 106734 RVA: 0x00241EFF File Offset: 0x002400FF
		public vtkUnstructuredGridToExplicitStructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A0EF RID: 106735
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridToExplicitStructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A0F0 RID: 106736 RVA: 0x00241F10 File Offset: 0x00240110
		public new static vtkUnstructuredGridToExplicitStructuredGrid New()
		{
			vtkUnstructuredGridToExplicitStructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridToExplicitStructuredGrid.vtkUnstructuredGridToExplicitStructuredGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridToExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A0F1 RID: 106737 RVA: 0x00241F64 File Offset: 0x00240164
		public vtkUnstructuredGridToExplicitStructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnstructuredGridToExplicitStructuredGrid.vtkUnstructuredGridToExplicitStructuredGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A0F2 RID: 106738 RVA: 0x00241FA8 File Offset: 0x002401A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A0F3 RID: 106739
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridToExplicitStructuredGrid_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A0F4 RID: 106740 RVA: 0x00241FB4 File Offset: 0x002401B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridToExplicitStructuredGrid.vtkUnstructuredGridToExplicitStructuredGrid_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A0F5 RID: 106741
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridToExplicitStructuredGrid_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A0F6 RID: 106742 RVA: 0x00241FD4 File Offset: 0x002401D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridToExplicitStructuredGrid.vtkUnstructuredGridToExplicitStructuredGrid_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A0F7 RID: 106743
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridToExplicitStructuredGrid_GetWholeExtent_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the whole extents for the grid to produce. The size of the grid
		/// must match the number of cells in the input.
		/// </summary>
		// Token: 0x0601A0F8 RID: 106744 RVA: 0x00241FF0 File Offset: 0x002401F0
		public virtual int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkUnstructuredGridToExplicitStructuredGrid.vtkUnstructuredGridToExplicitStructuredGrid_GetWholeExtent_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601A0F9 RID: 106745
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridToExplicitStructuredGrid_GetWholeExtent_04(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Get/Set the whole extents for the grid to produce. The size of the grid
		/// must match the number of cells in the input.
		/// </summary>
		// Token: 0x0601A0FA RID: 106746 RVA: 0x00242038 File Offset: 0x00240238
		public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkUnstructuredGridToExplicitStructuredGrid.vtkUnstructuredGridToExplicitStructuredGrid_GetWholeExtent_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0601A0FB RID: 106747
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridToExplicitStructuredGrid_GetWholeExtent_05(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the whole extents for the grid to produce. The size of the grid
		/// must match the number of cells in the input.
		/// </summary>
		// Token: 0x0601A0FC RID: 106748 RVA: 0x00242050 File Offset: 0x00240250
		public virtual void GetWholeExtent(IntPtr _arg)
		{
			vtkUnstructuredGridToExplicitStructuredGrid.vtkUnstructuredGridToExplicitStructuredGrid_GetWholeExtent_05(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A0FD RID: 106749
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridToExplicitStructuredGrid_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A0FE RID: 106750 RVA: 0x00242060 File Offset: 0x00240260
		public override int IsA(string type)
		{
			return vtkUnstructuredGridToExplicitStructuredGrid.vtkUnstructuredGridToExplicitStructuredGrid_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601A0FF RID: 106751
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridToExplicitStructuredGrid_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A100 RID: 106752 RVA: 0x00242080 File Offset: 0x00240280
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridToExplicitStructuredGrid.vtkUnstructuredGridToExplicitStructuredGrid_IsTypeOf_07(type);
		}

		// Token: 0x0601A101 RID: 106753
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridToExplicitStructuredGrid_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A102 RID: 106754 RVA: 0x0024209C File Offset: 0x0024029C
		public new vtkUnstructuredGridToExplicitStructuredGrid NewInstance()
		{
			vtkUnstructuredGridToExplicitStructuredGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridToExplicitStructuredGrid.vtkUnstructuredGridToExplicitStructuredGrid_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridToExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A103 RID: 106755
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridToExplicitStructuredGrid_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A104 RID: 106756 RVA: 0x002420F8 File Offset: 0x002402F8
		public new static vtkUnstructuredGridToExplicitStructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridToExplicitStructuredGrid vtkUnstructuredGridToExplicitStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridToExplicitStructuredGrid.vtkUnstructuredGridToExplicitStructuredGrid_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridToExplicitStructuredGrid = (vtkUnstructuredGridToExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridToExplicitStructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGridToExplicitStructuredGrid;
		}

		// Token: 0x0601A105 RID: 106757
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridToExplicitStructuredGrid_SetWholeExtent_11(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Get/Set the whole extents for the grid to produce. The size of the grid
		/// must match the number of cells in the input.
		/// </summary>
		// Token: 0x0601A106 RID: 106758 RVA: 0x00242177 File Offset: 0x00240377
		public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkUnstructuredGridToExplicitStructuredGrid.vtkUnstructuredGridToExplicitStructuredGrid_SetWholeExtent_11(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0601A107 RID: 106759
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridToExplicitStructuredGrid_SetWholeExtent_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the whole extents for the grid to produce. The size of the grid
		/// must match the number of cells in the input.
		/// </summary>
		// Token: 0x0601A108 RID: 106760 RVA: 0x0024218F File Offset: 0x0024038F
		public virtual void SetWholeExtent(IntPtr _arg)
		{
			vtkUnstructuredGridToExplicitStructuredGrid.vtkUnstructuredGridToExplicitStructuredGrid_SetWholeExtent_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C45 RID: 7237
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridToExplicitStructuredGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C46 RID: 7238
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridToExplicitStructuredGrid";
	}
}
