using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkResampleWithDataSet
	/// </summary>
	/// <remarks>
	///    sample point and cell data of a dataset on
	/// points from another dataset.
	///
	/// Similar to vtkCompositeDataProbeFilter, vtkResampleWithDataSet takes two
	/// inputs - Input and Source, and samples the point and cell values of Source
	/// on to the point locations of Input. The output has the same structure as
	/// Input but its point data have the resampled values from Source. Unlike
	/// vtkCompositeDataProbeFilter, this filter support composite datasets for both
	/// Input and Source.
	/// </remarks>
	/// <seealso>
	///
	/// vtkCompositeDataProbeFilter vtkResampleToImage
	/// </seealso>
	// Token: 0x02000999 RID: 2457
	public class vtkResampleWithDataSet : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019A0D RID: 104973 RVA: 0x0023A387 File Offset: 0x00238587
		static vtkResampleWithDataSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkResampleWithDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkResampleWithDataSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019A0E RID: 104974 RVA: 0x0023A3AF File Offset: 0x002385AF
		public vtkResampleWithDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019A0F RID: 104975
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResampleWithDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019A10 RID: 104976 RVA: 0x0023A3C0 File Offset: 0x002385C0
		public new static vtkResampleWithDataSet New()
		{
			vtkResampleWithDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResampleWithDataSet.vtkResampleWithDataSet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResampleWithDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019A11 RID: 104977 RVA: 0x0023A414 File Offset: 0x00238614
		public vtkResampleWithDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkResampleWithDataSet.vtkResampleWithDataSet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019A12 RID: 104978 RVA: 0x0023A458 File Offset: 0x00238658
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019A13 RID: 104979
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_ComputeToleranceOff_01(HandleRef pThis);

		/// <summary>
		/// Set whether to use the Tolerance field or precompute the tolerance.
		/// When on, the tolerance will be computed and the field
		/// value is ignored. On by default.
		/// </summary>
		// Token: 0x06019A14 RID: 104980 RVA: 0x0023A463 File Offset: 0x00238663
		public virtual void ComputeToleranceOff()
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_ComputeToleranceOff_01(base.GetCppThis());
		}

		// Token: 0x06019A15 RID: 104981
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_ComputeToleranceOn_02(HandleRef pThis);

		/// <summary>
		/// Set whether to use the Tolerance field or precompute the tolerance.
		/// When on, the tolerance will be computed and the field
		/// value is ignored. On by default.
		/// </summary>
		// Token: 0x06019A16 RID: 104982 RVA: 0x0023A472 File Offset: 0x00238672
		public virtual void ComputeToleranceOn()
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_ComputeToleranceOn_02(base.GetCppThis());
		}

		// Token: 0x06019A17 RID: 104983
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkResampleWithDataSet_GetCategoricalData_03(HandleRef pThis);

		/// <summary>
		/// Control whether the source point data is to be treated as categorical. If
		/// the data is categorical, then the resultant data will be determined by
		/// a nearest neighbor interpolation scheme.
		/// </summary>
		// Token: 0x06019A18 RID: 104984 RVA: 0x0023A484 File Offset: 0x00238684
		public bool GetCategoricalData()
		{
			return vtkResampleWithDataSet.vtkResampleWithDataSet_GetCategoricalData_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06019A19 RID: 104985
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResampleWithDataSet_GetCellLocatorPrototype_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
		/// FindCell is executed.
		///
		/// Default is off.
		///
		/// Note: This is useful only when the source is a vtkPointSet.
		/// </summary>
		// Token: 0x06019A1A RID: 104986 RVA: 0x0023A4AC File Offset: 0x002386AC
		public virtual vtkAbstractCellLocator GetCellLocatorPrototype()
		{
			vtkAbstractCellLocator vtkAbstractCellLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResampleWithDataSet.vtkResampleWithDataSet_GetCellLocatorPrototype_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractCellLocator = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractCellLocator.Register(null);
				}
			}
			return vtkAbstractCellLocator;
		}

		// Token: 0x06019A1B RID: 104987
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkResampleWithDataSet_GetComputeTolerance_05(HandleRef pThis);

		/// <summary>
		/// Set whether to use the Tolerance field or precompute the tolerance.
		/// When on, the tolerance will be computed and the field
		/// value is ignored. On by default.
		/// </summary>
		// Token: 0x06019A1C RID: 104988 RVA: 0x0023A51C File Offset: 0x0023871C
		public bool GetComputeTolerance()
		{
			return vtkResampleWithDataSet.vtkResampleWithDataSet_GetComputeTolerance_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06019A1D RID: 104989
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkResampleWithDataSet_GetMTime_06(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
		/// FindCell is executed.
		///
		/// Default is off.
		///
		/// Note: This is useful only when the source is a vtkPointSet.
		/// </summary>
		// Token: 0x06019A1E RID: 104990 RVA: 0x0023A544 File Offset: 0x00238744
		public override ulong GetMTime()
		{
			return vtkResampleWithDataSet.vtkResampleWithDataSet_GetMTime_06(base.GetCppThis());
		}

		// Token: 0x06019A1F RID: 104991
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkResampleWithDataSet_GetMarkBlankPointsAndCells_07(HandleRef pThis);

		/// <summary>
		/// Set whether points without resampled values, and their corresponding cells,
		/// should be marked as Blank. Default is On.
		/// </summary>
		// Token: 0x06019A20 RID: 104992 RVA: 0x0023A564 File Offset: 0x00238764
		public virtual bool GetMarkBlankPointsAndCells()
		{
			return vtkResampleWithDataSet.vtkResampleWithDataSet_GetMarkBlankPointsAndCells_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06019A21 RID: 104993
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResampleWithDataSet_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019A22 RID: 104994 RVA: 0x0023A58C File Offset: 0x0023878C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkResampleWithDataSet.vtkResampleWithDataSet_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06019A23 RID: 104995
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResampleWithDataSet_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019A24 RID: 104996 RVA: 0x0023A5AC File Offset: 0x002387AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkResampleWithDataSet.vtkResampleWithDataSet_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06019A25 RID: 104997
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkResampleWithDataSet_GetPassCellArrays_10(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input cell data arrays to the output.
		/// Off by default.
		/// </summary>
		// Token: 0x06019A26 RID: 104998 RVA: 0x0023A5C8 File Offset: 0x002387C8
		public bool GetPassCellArrays()
		{
			return vtkResampleWithDataSet.vtkResampleWithDataSet_GetPassCellArrays_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06019A27 RID: 104999
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkResampleWithDataSet_GetPassFieldArrays_11(HandleRef pThis);

		/// <summary>
		/// Set whether to pass the field-data arrays from the Input i.e. the input
		/// providing the geometry to the output. On by default.
		/// </summary>
		// Token: 0x06019A28 RID: 105000 RVA: 0x0023A5F0 File Offset: 0x002387F0
		public bool GetPassFieldArrays()
		{
			return vtkResampleWithDataSet.vtkResampleWithDataSet_GetPassFieldArrays_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06019A29 RID: 105001
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkResampleWithDataSet_GetPassPartialArrays_12(HandleRef pThis);

		/// <summary>
		/// When sampling from composite datasets, partial arrays are common i.e.
		/// data-arrays that are not available in all of the blocks. By default, this
		/// filter only passes those point and cell data-arrays that are available in
		/// all the blocks i.e. partial arrays are removed.  When PassPartialArrays is
		/// turned on, this behavior is changed to take a union of all arrays present
		/// thus partial arrays are passed as well. However, for composite dataset
		/// input, this filter still produces a non-composite output. For all those
		/// locations in a block of where a particular data array is missing, this
		/// filter uses vtkMath::Nan() for double and float arrays, and 0 for all
		/// other types of arrays e.g. int, char, etc. Off by default.
		/// </summary>
		// Token: 0x06019A2A RID: 105002 RVA: 0x0023A618 File Offset: 0x00238818
		public bool GetPassPartialArrays()
		{
			return vtkResampleWithDataSet.vtkResampleWithDataSet_GetPassPartialArrays_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06019A2B RID: 105003
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkResampleWithDataSet_GetPassPointArrays_13(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input point data arrays to the output
		/// Off by default.
		/// </summary>
		// Token: 0x06019A2C RID: 105004 RVA: 0x0023A640 File Offset: 0x00238840
		public bool GetPassPointArrays()
		{
			return vtkResampleWithDataSet.vtkResampleWithDataSet_GetPassPointArrays_13(base.GetCppThis()) != 0;
		}

		// Token: 0x06019A2D RID: 105005
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkResampleWithDataSet_GetSnapToCellWithClosestPoint_14(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
		/// FindCell is executed.
		///
		/// Default is off.
		///
		/// Note: This is useful only when the source is a vtkPointSet.
		/// </summary>
		// Token: 0x06019A2E RID: 105006 RVA: 0x0023A668 File Offset: 0x00238868
		public bool GetSnapToCellWithClosestPoint()
		{
			return vtkResampleWithDataSet.vtkResampleWithDataSet_GetSnapToCellWithClosestPoint_14(base.GetCppThis()) != 0;
		}

		// Token: 0x06019A2F RID: 105007
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkResampleWithDataSet_GetTolerance_15(HandleRef pThis);

		/// <summary>
		/// Set the tolerance used to compute whether a point in the
		/// source is in a cell of the input.  This value is only used
		/// if ComputeTolerance is off.
		/// </summary>
		// Token: 0x06019A30 RID: 105008 RVA: 0x0023A690 File Offset: 0x00238890
		public double GetTolerance()
		{
			return vtkResampleWithDataSet.vtkResampleWithDataSet_GetTolerance_15(base.GetCppThis());
		}

		// Token: 0x06019A31 RID: 105009
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResampleWithDataSet_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019A32 RID: 105010 RVA: 0x0023A6B0 File Offset: 0x002388B0
		public override int IsA(string type)
		{
			return vtkResampleWithDataSet.vtkResampleWithDataSet_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06019A33 RID: 105011
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResampleWithDataSet_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019A34 RID: 105012 RVA: 0x0023A6D0 File Offset: 0x002388D0
		public new static int IsTypeOf(string type)
		{
			return vtkResampleWithDataSet.vtkResampleWithDataSet_IsTypeOf_17(type);
		}

		// Token: 0x06019A35 RID: 105013
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_MarkBlankPointsAndCellsOff_18(HandleRef pThis);

		/// <summary>
		/// Set whether points without resampled values, and their corresponding cells,
		/// should be marked as Blank. Default is On.
		/// </summary>
		// Token: 0x06019A36 RID: 105014 RVA: 0x0023A6EA File Offset: 0x002388EA
		public virtual void MarkBlankPointsAndCellsOff()
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_MarkBlankPointsAndCellsOff_18(base.GetCppThis());
		}

		// Token: 0x06019A37 RID: 105015
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_MarkBlankPointsAndCellsOn_19(HandleRef pThis);

		/// <summary>
		/// Set whether points without resampled values, and their corresponding cells,
		/// should be marked as Blank. Default is On.
		/// </summary>
		// Token: 0x06019A38 RID: 105016 RVA: 0x0023A6F9 File Offset: 0x002388F9
		public virtual void MarkBlankPointsAndCellsOn()
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_MarkBlankPointsAndCellsOn_19(base.GetCppThis());
		}

		// Token: 0x06019A39 RID: 105017
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResampleWithDataSet_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019A3A RID: 105018 RVA: 0x0023A708 File Offset: 0x00238908
		public new vtkResampleWithDataSet NewInstance()
		{
			vtkResampleWithDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResampleWithDataSet.vtkResampleWithDataSet_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResampleWithDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019A3B RID: 105019
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_PassCellArraysOff_22(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input cell data arrays to the output.
		/// Off by default.
		/// </summary>
		// Token: 0x06019A3C RID: 105020 RVA: 0x0023A762 File Offset: 0x00238962
		public virtual void PassCellArraysOff()
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_PassCellArraysOff_22(base.GetCppThis());
		}

		// Token: 0x06019A3D RID: 105021
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_PassCellArraysOn_23(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input cell data arrays to the output.
		/// Off by default.
		/// </summary>
		// Token: 0x06019A3E RID: 105022 RVA: 0x0023A771 File Offset: 0x00238971
		public virtual void PassCellArraysOn()
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_PassCellArraysOn_23(base.GetCppThis());
		}

		// Token: 0x06019A3F RID: 105023
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_PassFieldArraysOff_24(HandleRef pThis);

		/// <summary>
		/// Set whether to pass the field-data arrays from the Input i.e. the input
		/// providing the geometry to the output. On by default.
		/// </summary>
		// Token: 0x06019A40 RID: 105024 RVA: 0x0023A780 File Offset: 0x00238980
		public virtual void PassFieldArraysOff()
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_PassFieldArraysOff_24(base.GetCppThis());
		}

		// Token: 0x06019A41 RID: 105025
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_PassFieldArraysOn_25(HandleRef pThis);

		/// <summary>
		/// Set whether to pass the field-data arrays from the Input i.e. the input
		/// providing the geometry to the output. On by default.
		/// </summary>
		// Token: 0x06019A42 RID: 105026 RVA: 0x0023A78F File Offset: 0x0023898F
		public virtual void PassFieldArraysOn()
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_PassFieldArraysOn_25(base.GetCppThis());
		}

		// Token: 0x06019A43 RID: 105027
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_PassPartialArraysOff_26(HandleRef pThis);

		/// <summary>
		/// When sampling from composite datasets, partial arrays are common i.e.
		/// data-arrays that are not available in all of the blocks. By default, this
		/// filter only passes those point and cell data-arrays that are available in
		/// all the blocks i.e. partial arrays are removed.  When PassPartialArrays is
		/// turned on, this behavior is changed to take a union of all arrays present
		/// thus partial arrays are passed as well. However, for composite dataset
		/// input, this filter still produces a non-composite output. For all those
		/// locations in a block of where a particular data array is missing, this
		/// filter uses vtkMath::Nan() for double and float arrays, and 0 for all
		/// other types of arrays e.g. int, char, etc. Off by default.
		/// </summary>
		// Token: 0x06019A44 RID: 105028 RVA: 0x0023A79E File Offset: 0x0023899E
		public virtual void PassPartialArraysOff()
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_PassPartialArraysOff_26(base.GetCppThis());
		}

		// Token: 0x06019A45 RID: 105029
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_PassPartialArraysOn_27(HandleRef pThis);

		/// <summary>
		/// When sampling from composite datasets, partial arrays are common i.e.
		/// data-arrays that are not available in all of the blocks. By default, this
		/// filter only passes those point and cell data-arrays that are available in
		/// all the blocks i.e. partial arrays are removed.  When PassPartialArrays is
		/// turned on, this behavior is changed to take a union of all arrays present
		/// thus partial arrays are passed as well. However, for composite dataset
		/// input, this filter still produces a non-composite output. For all those
		/// locations in a block of where a particular data array is missing, this
		/// filter uses vtkMath::Nan() for double and float arrays, and 0 for all
		/// other types of arrays e.g. int, char, etc. Off by default.
		/// </summary>
		// Token: 0x06019A46 RID: 105030 RVA: 0x0023A7AD File Offset: 0x002389AD
		public virtual void PassPartialArraysOn()
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_PassPartialArraysOn_27(base.GetCppThis());
		}

		// Token: 0x06019A47 RID: 105031
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_PassPointArraysOff_28(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input point data arrays to the output
		/// Off by default.
		/// </summary>
		// Token: 0x06019A48 RID: 105032 RVA: 0x0023A7BC File Offset: 0x002389BC
		public virtual void PassPointArraysOff()
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_PassPointArraysOff_28(base.GetCppThis());
		}

		// Token: 0x06019A49 RID: 105033
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_PassPointArraysOn_29(HandleRef pThis);

		/// <summary>
		/// Shallow copy the input point data arrays to the output
		/// Off by default.
		/// </summary>
		// Token: 0x06019A4A RID: 105034 RVA: 0x0023A7CB File Offset: 0x002389CB
		public virtual void PassPointArraysOn()
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_PassPointArraysOn_29(base.GetCppThis());
		}

		// Token: 0x06019A4B RID: 105035
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResampleWithDataSet_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019A4C RID: 105036 RVA: 0x0023A7DC File Offset: 0x002389DC
		public new static vtkResampleWithDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkResampleWithDataSet vtkResampleWithDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResampleWithDataSet.vtkResampleWithDataSet_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResampleWithDataSet = (vtkResampleWithDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResampleWithDataSet.Register(null);
				}
			}
			return vtkResampleWithDataSet;
		}

		// Token: 0x06019A4D RID: 105037
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_SetCategoricalData_31(HandleRef pThis, byte arg);

		/// <summary>
		/// Control whether the source point data is to be treated as categorical. If
		/// the data is categorical, then the resultant data will be determined by
		/// a nearest neighbor interpolation scheme.
		/// </summary>
		// Token: 0x06019A4E RID: 105038 RVA: 0x0023A85B File Offset: 0x00238A5B
		public void SetCategoricalData(bool arg)
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_SetCategoricalData_31(base.GetCppThis(), arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019A4F RID: 105039
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_SetCellLocatorPrototype_32(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
		/// FindCell is executed.
		///
		/// Default is off.
		///
		/// Note: This is useful only when the source is a vtkPointSet.
		/// </summary>
		// Token: 0x06019A50 RID: 105040 RVA: 0x0023A874 File Offset: 0x00238A74
		public virtual void SetCellLocatorPrototype(vtkAbstractCellLocator arg0)
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_SetCellLocatorPrototype_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06019A51 RID: 105041
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_SetComputeTolerance_33(HandleRef pThis, byte arg);

		/// <summary>
		/// Set whether to use the Tolerance field or precompute the tolerance.
		/// When on, the tolerance will be computed and the field
		/// value is ignored. On by default.
		/// </summary>
		// Token: 0x06019A52 RID: 105042 RVA: 0x0023A8A3 File Offset: 0x00238AA3
		public void SetComputeTolerance(bool arg)
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_SetComputeTolerance_33(base.GetCppThis(), arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019A53 RID: 105043
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_SetMarkBlankPointsAndCells_34(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set whether points without resampled values, and their corresponding cells,
		/// should be marked as Blank. Default is On.
		/// </summary>
		// Token: 0x06019A54 RID: 105044 RVA: 0x0023A8BB File Offset: 0x00238ABB
		public virtual void SetMarkBlankPointsAndCells(bool _arg)
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_SetMarkBlankPointsAndCells_34(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019A55 RID: 105045
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_SetPassCellArrays_35(HandleRef pThis, byte arg);

		/// <summary>
		/// Shallow copy the input cell data arrays to the output.
		/// Off by default.
		/// </summary>
		// Token: 0x06019A56 RID: 105046 RVA: 0x0023A8D3 File Offset: 0x00238AD3
		public void SetPassCellArrays(bool arg)
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_SetPassCellArrays_35(base.GetCppThis(), arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019A57 RID: 105047
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_SetPassFieldArrays_36(HandleRef pThis, byte arg);

		/// <summary>
		/// Set whether to pass the field-data arrays from the Input i.e. the input
		/// providing the geometry to the output. On by default.
		/// </summary>
		// Token: 0x06019A58 RID: 105048 RVA: 0x0023A8EB File Offset: 0x00238AEB
		public void SetPassFieldArrays(bool arg)
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_SetPassFieldArrays_36(base.GetCppThis(), arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019A59 RID: 105049
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_SetPassPartialArrays_37(HandleRef pThis, byte arg);

		/// <summary>
		/// When sampling from composite datasets, partial arrays are common i.e.
		/// data-arrays that are not available in all of the blocks. By default, this
		/// filter only passes those point and cell data-arrays that are available in
		/// all the blocks i.e. partial arrays are removed.  When PassPartialArrays is
		/// turned on, this behavior is changed to take a union of all arrays present
		/// thus partial arrays are passed as well. However, for composite dataset
		/// input, this filter still produces a non-composite output. For all those
		/// locations in a block of where a particular data array is missing, this
		/// filter uses vtkMath::Nan() for double and float arrays, and 0 for all
		/// other types of arrays e.g. int, char, etc. Off by default.
		/// </summary>
		// Token: 0x06019A5A RID: 105050 RVA: 0x0023A903 File Offset: 0x00238B03
		public void SetPassPartialArrays(bool arg)
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_SetPassPartialArrays_37(base.GetCppThis(), arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019A5B RID: 105051
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_SetPassPointArrays_38(HandleRef pThis, byte arg);

		/// <summary>
		/// Shallow copy the input point data arrays to the output
		/// Off by default.
		/// </summary>
		// Token: 0x06019A5C RID: 105052 RVA: 0x0023A91B File Offset: 0x00238B1B
		public void SetPassPointArrays(bool arg)
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_SetPassPointArrays_38(base.GetCppThis(), arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019A5D RID: 105053
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_SetSnapToCellWithClosestPoint_39(HandleRef pThis, byte arg);

		/// <summary>
		/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
		/// FindCell is executed.
		///
		/// Default is off.
		///
		/// Note: This is useful only when the source is a vtkPointSet.
		/// </summary>
		// Token: 0x06019A5E RID: 105054 RVA: 0x0023A933 File Offset: 0x00238B33
		public void SetSnapToCellWithClosestPoint(bool arg)
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_SetSnapToCellWithClosestPoint_39(base.GetCppThis(), arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019A5F RID: 105055
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_SetSourceConnection_40(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the data set that will be probed at the input points.
		/// The Input gives the geometry (the points and cells) for the output,
		/// while the Source is probed (interpolated) to generate the scalars,
		/// vectors, etc. for the output points based on the point locations.
		/// </summary>
		// Token: 0x06019A60 RID: 105056 RVA: 0x0023A94C File Offset: 0x00238B4C
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_SetSourceConnection_40(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06019A61 RID: 105057
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_SetSourceData_41(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the data set that will be probed at the input points.
		/// The Input gives the geometry (the points and cells) for the output,
		/// while the Source is probed (interpolated) to generate the scalars,
		/// vectors, etc. for the output points based on the point locations.
		/// </summary>
		// Token: 0x06019A62 RID: 105058 RVA: 0x0023A97C File Offset: 0x00238B7C
		public void SetSourceData(vtkDataObject source)
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_SetSourceData_41(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x06019A63 RID: 105059
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_SetTolerance_42(HandleRef pThis, double arg);

		/// <summary>
		/// Set the tolerance used to compute whether a point in the
		/// source is in a cell of the input.  This value is only used
		/// if ComputeTolerance is off.
		/// </summary>
		// Token: 0x06019A64 RID: 105060 RVA: 0x0023A9AB File Offset: 0x00238BAB
		public void SetTolerance(double arg)
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_SetTolerance_42(base.GetCppThis(), arg);
		}

		// Token: 0x06019A65 RID: 105061
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_SnapToCellWithClosestPointOff_43(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
		/// FindCell is executed.
		///
		/// Default is off.
		///
		/// Note: This is useful only when the source is a vtkPointSet.
		/// </summary>
		// Token: 0x06019A66 RID: 105062 RVA: 0x0023A9BB File Offset: 0x00238BBB
		public virtual void SnapToCellWithClosestPointOff()
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_SnapToCellWithClosestPointOff_43(base.GetCppThis());
		}

		// Token: 0x06019A67 RID: 105063
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResampleWithDataSet_SnapToCellWithClosestPointOn_44(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to snap to the cell with the closest point, if no cell has been found while
		/// FindCell is executed.
		///
		/// Default is off.
		///
		/// Note: This is useful only when the source is a vtkPointSet.
		/// </summary>
		// Token: 0x06019A68 RID: 105064 RVA: 0x0023A9CA File Offset: 0x00238BCA
		public virtual void SnapToCellWithClosestPointOn()
		{
			vtkResampleWithDataSet.vtkResampleWithDataSet_SnapToCellWithClosestPointOn_44(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BF7 RID: 7159
		public new const string MRFullTypeName = "Kitware.VTK.vtkResampleWithDataSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BF8 RID: 7160
		public new static readonly string MRClassNameKey = "class vtkResampleWithDataSet";
	}
}
