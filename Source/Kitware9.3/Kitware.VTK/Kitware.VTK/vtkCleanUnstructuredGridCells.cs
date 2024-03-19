using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCleanUnstructuredGridCells
	/// </summary>
	/// <remarks>
	///    remove duplicate/degenerate cells
	///
	///
	/// Merges degenerate cells. Assumes the input grid does not contain duplicate
	/// points. You may want to run vtkCleanUnstructuredGrid first to assert it. If
	/// duplicated cells are found they are removed in the output. The filter also
	/// handles the case, where a cell may contain degenerate nodes (i.e. one and
	/// the same node is referenced by a cell more than once).
	///
	/// Programmed 2010 by Dominik Szczerba &lt;dominik@itis.ethz.ch&gt;
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCleanPolyData
	/// </seealso>
	// Token: 0x02000880 RID: 2176
	public class vtkCleanUnstructuredGridCells : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016944 RID: 92484 RVA: 0x001FC4A9 File Offset: 0x001FA6A9
		static vtkCleanUnstructuredGridCells()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCleanUnstructuredGridCells.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCleanUnstructuredGridCells"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016945 RID: 92485 RVA: 0x001FC4D1 File Offset: 0x001FA6D1
		public vtkCleanUnstructuredGridCells(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016946 RID: 92486
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCleanUnstructuredGridCells_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016947 RID: 92487 RVA: 0x001FC4E0 File Offset: 0x001FA6E0
		public new static vtkCleanUnstructuredGridCells New()
		{
			vtkCleanUnstructuredGridCells result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCleanUnstructuredGridCells.vtkCleanUnstructuredGridCells_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCleanUnstructuredGridCells)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016948 RID: 92488 RVA: 0x001FC534 File Offset: 0x001FA734
		public vtkCleanUnstructuredGridCells() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCleanUnstructuredGridCells.vtkCleanUnstructuredGridCells_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016949 RID: 92489 RVA: 0x001FC578 File Offset: 0x001FA778
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601694A RID: 92490
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCleanUnstructuredGridCells_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601694B RID: 92491 RVA: 0x001FC584 File Offset: 0x001FA784
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCleanUnstructuredGridCells.vtkCleanUnstructuredGridCells_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601694C RID: 92492
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCleanUnstructuredGridCells_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601694D RID: 92493 RVA: 0x001FC5A4 File Offset: 0x001FA7A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCleanUnstructuredGridCells.vtkCleanUnstructuredGridCells_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601694E RID: 92494
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCleanUnstructuredGridCells_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601694F RID: 92495 RVA: 0x001FC5C0 File Offset: 0x001FA7C0
		public override int IsA(string type)
		{
			return vtkCleanUnstructuredGridCells.vtkCleanUnstructuredGridCells_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06016950 RID: 92496
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCleanUnstructuredGridCells_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016951 RID: 92497 RVA: 0x001FC5E0 File Offset: 0x001FA7E0
		public new static int IsTypeOf(string type)
		{
			return vtkCleanUnstructuredGridCells.vtkCleanUnstructuredGridCells_IsTypeOf_04(type);
		}

		// Token: 0x06016952 RID: 92498
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCleanUnstructuredGridCells_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016953 RID: 92499 RVA: 0x001FC5FC File Offset: 0x001FA7FC
		public new vtkCleanUnstructuredGridCells NewInstance()
		{
			vtkCleanUnstructuredGridCells result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCleanUnstructuredGridCells.vtkCleanUnstructuredGridCells_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCleanUnstructuredGridCells)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016954 RID: 92500
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCleanUnstructuredGridCells_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016955 RID: 92501 RVA: 0x001FC658 File Offset: 0x001FA858
		public new static vtkCleanUnstructuredGridCells SafeDownCast(vtkObjectBase o)
		{
			vtkCleanUnstructuredGridCells vtkCleanUnstructuredGridCells = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCleanUnstructuredGridCells.vtkCleanUnstructuredGridCells_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCleanUnstructuredGridCells = (vtkCleanUnstructuredGridCells)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCleanUnstructuredGridCells.Register(null);
				}
			}
			return vtkCleanUnstructuredGridCells;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001961 RID: 6497
		public new const string MRFullTypeName = "Kitware.VTK.vtkCleanUnstructuredGridCells";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001962 RID: 6498
		public new static readonly string MRClassNameKey = "class vtkCleanUnstructuredGridCells";
	}
}
