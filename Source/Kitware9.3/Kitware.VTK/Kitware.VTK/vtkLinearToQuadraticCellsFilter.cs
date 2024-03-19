using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLinearToQuadraticCellsFilter
	/// </summary>
	/// <remarks>
	///    degree elevate the cells of a linear unstructured grid.
	///
	///
	/// vtkLinearToQuadraticCellsFilter takes an unstructured grid comprised of
	/// linear cells and degree elevates each of the cells to quadratic. Additional
	/// points are simply interpolated from the existing points (there is no snapping
	/// to an external model).
	/// </remarks>
	// Token: 0x0200090E RID: 2318
	public class vtkLinearToQuadraticCellsFilter : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018080 RID: 98432 RVA: 0x00219FCB File Offset: 0x002181CB
		static vtkLinearToQuadraticCellsFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLinearToQuadraticCellsFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearToQuadraticCellsFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018081 RID: 98433 RVA: 0x00219FF3 File Offset: 0x002181F3
		public vtkLinearToQuadraticCellsFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018082 RID: 98434
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearToQuadraticCellsFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018083 RID: 98435 RVA: 0x0021A004 File Offset: 0x00218204
		public new static vtkLinearToQuadraticCellsFilter New()
		{
			vtkLinearToQuadraticCellsFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearToQuadraticCellsFilter.vtkLinearToQuadraticCellsFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearToQuadraticCellsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018084 RID: 98436 RVA: 0x0021A058 File Offset: 0x00218258
		public vtkLinearToQuadraticCellsFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLinearToQuadraticCellsFilter.vtkLinearToQuadraticCellsFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018085 RID: 98437 RVA: 0x0021A09C File Offset: 0x0021829C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018086 RID: 98438
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearToQuadraticCellsFilter_CreateDefaultLocator_01(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified. The
		/// locator is used to merge coincident points.
		/// </summary>
		// Token: 0x06018087 RID: 98439 RVA: 0x0021A0A7 File Offset: 0x002182A7
		public void CreateDefaultLocator()
		{
			vtkLinearToQuadraticCellsFilter.vtkLinearToQuadraticCellsFilter_CreateDefaultLocator_01(base.GetCppThis());
		}

		// Token: 0x06018088 RID: 98440
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearToQuadraticCellsFilter_GetLocator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a spatial locator for merging points. By default, an
		/// instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06018089 RID: 98441 RVA: 0x0021A0B8 File Offset: 0x002182B8
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearToQuadraticCellsFilter.vtkLinearToQuadraticCellsFilter_GetLocator_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		// Token: 0x0601808A RID: 98442
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkLinearToQuadraticCellsFilter_GetMTime_03(HandleRef pThis);

		/// <summary>
		/// Return the mtime also considering the locator.
		/// </summary>
		// Token: 0x0601808B RID: 98443 RVA: 0x0021A128 File Offset: 0x00218328
		public override ulong GetMTime()
		{
			return vtkLinearToQuadraticCellsFilter.vtkLinearToQuadraticCellsFilter_GetMTime_03(base.GetCppThis());
		}

		// Token: 0x0601808C RID: 98444
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearToQuadraticCellsFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601808D RID: 98445 RVA: 0x0021A148 File Offset: 0x00218348
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLinearToQuadraticCellsFilter.vtkLinearToQuadraticCellsFilter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601808E RID: 98446
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearToQuadraticCellsFilter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601808F RID: 98447 RVA: 0x0021A168 File Offset: 0x00218368
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLinearToQuadraticCellsFilter.vtkLinearToQuadraticCellsFilter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06018090 RID: 98448
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearToQuadraticCellsFilter_GetOutputPointsPrecision_06(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// OutputPointsPrecision is DEFAULT_PRECISION by default.
		/// </summary>
		// Token: 0x06018091 RID: 98449 RVA: 0x0021A184 File Offset: 0x00218384
		public virtual int GetOutputPointsPrecision()
		{
			return vtkLinearToQuadraticCellsFilter.vtkLinearToQuadraticCellsFilter_GetOutputPointsPrecision_06(base.GetCppThis());
		}

		// Token: 0x06018092 RID: 98450
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearToQuadraticCellsFilter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018093 RID: 98451 RVA: 0x0021A1A4 File Offset: 0x002183A4
		public override int IsA(string type)
		{
			return vtkLinearToQuadraticCellsFilter.vtkLinearToQuadraticCellsFilter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06018094 RID: 98452
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearToQuadraticCellsFilter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018095 RID: 98453 RVA: 0x0021A1C4 File Offset: 0x002183C4
		public new static int IsTypeOf(string type)
		{
			return vtkLinearToQuadraticCellsFilter.vtkLinearToQuadraticCellsFilter_IsTypeOf_08(type);
		}

		// Token: 0x06018096 RID: 98454
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearToQuadraticCellsFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018097 RID: 98455 RVA: 0x0021A1E0 File Offset: 0x002183E0
		public new vtkLinearToQuadraticCellsFilter NewInstance()
		{
			vtkLinearToQuadraticCellsFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearToQuadraticCellsFilter.vtkLinearToQuadraticCellsFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearToQuadraticCellsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018098 RID: 98456
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearToQuadraticCellsFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018099 RID: 98457 RVA: 0x0021A23C File Offset: 0x0021843C
		public new static vtkLinearToQuadraticCellsFilter SafeDownCast(vtkObjectBase o)
		{
			vtkLinearToQuadraticCellsFilter vtkLinearToQuadraticCellsFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearToQuadraticCellsFilter.vtkLinearToQuadraticCellsFilter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinearToQuadraticCellsFilter = (vtkLinearToQuadraticCellsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinearToQuadraticCellsFilter.Register(null);
				}
			}
			return vtkLinearToQuadraticCellsFilter;
		}

		// Token: 0x0601809A RID: 98458
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearToQuadraticCellsFilter_SetLocator_12(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a spatial locator for merging points. By default, an
		/// instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0601809B RID: 98459 RVA: 0x0021A2BC File Offset: 0x002184BC
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkLinearToQuadraticCellsFilter.vtkLinearToQuadraticCellsFilter_SetLocator_12(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0601809C RID: 98460
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearToQuadraticCellsFilter_SetOutputPointsPrecision_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// OutputPointsPrecision is DEFAULT_PRECISION by default.
		/// </summary>
		// Token: 0x0601809D RID: 98461 RVA: 0x0021A2EB File Offset: 0x002184EB
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkLinearToQuadraticCellsFilter.vtkLinearToQuadraticCellsFilter_SetOutputPointsPrecision_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AC6 RID: 6854
		public new const string MRFullTypeName = "Kitware.VTK.vtkLinearToQuadraticCellsFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AC7 RID: 6855
		public new static readonly string MRClassNameKey = "class vtkLinearToQuadraticCellsFilter";
	}
}
