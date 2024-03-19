using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMergeCells
	/// </summary>
	/// <remarks>
	///    merges any number of vtkDataSets back into a single
	///   vtkUnstructuredGrid
	///
	///
	///    Designed to work with distributed vtkDataSets, this class will take
	///    vtkDataSets and merge them back into a single vtkUnstructuredGrid.
	///
	///    The vtkPoints object of the unstructured grid will have data type
	///    VTK_FLOAT if input is not of type vtkPointSet, otherwise it will have same
	///    data type than the input point set.
	///
	///    It is assumed the different DataSets have the same field arrays.  If
	///    the name of a global point ID array is provided, this class will
	///    refrain from including duplicate points in the merged Ugrid.  This
	///    class differs from vtkAppendFilter in these ways: (1) it uses less
	///    memory than that class (which uses memory equal to twice the size
	///    of the final Ugrid) but requires that you know the size of the
	///    final Ugrid in advance (2) this class assumes the individual DataSets have
	///    the same field arrays, while vtkAppendFilter intersects the field
	///    arrays (3) this class knows duplicate points may be appearing in
	///    the DataSets and can filter those out, (4) this class is not a filter.
	/// </remarks>
	// Token: 0x020008BA RID: 2234
	public class vtkMergeCells : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601725A RID: 94810 RVA: 0x00207EAF File Offset: 0x002060AF
		static vtkMergeCells()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergeCells.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeCells"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601725B RID: 94811 RVA: 0x00207ED7 File Offset: 0x002060D7
		public vtkMergeCells(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601725C RID: 94812
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeCells_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601725D RID: 94813 RVA: 0x00207EE8 File Offset: 0x002060E8
		public new static vtkMergeCells New()
		{
			vtkMergeCells result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeCells.vtkMergeCells_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeCells)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601725E RID: 94814 RVA: 0x00207F3C File Offset: 0x0020613C
		public vtkMergeCells() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMergeCells.vtkMergeCells_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601725F RID: 94815 RVA: 0x00207F80 File Offset: 0x00206180
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017260 RID: 94816
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeCells_Finish_01(HandleRef pThis);

		/// <summary>
		/// Call Finish() after merging last DataSet to free unneeded memory and to
		/// make sure the ugrid's GetNumberOfPoints() reflects the actual
		/// number of points set, not the number allocated.
		/// </summary>
		// Token: 0x06017261 RID: 94817 RVA: 0x00207F8B File Offset: 0x0020618B
		public void Finish()
		{
			vtkMergeCells.vtkMergeCells_Finish_01(base.GetCppThis());
		}

		// Token: 0x06017262 RID: 94818
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMergeCells_GetMergeDuplicatePoints_02(HandleRef pThis);

		/// <summary>
		/// vtkMergeCells attempts eliminate duplicate points when merging
		/// data sets.  If for some reason you don't want it to do this,
		/// than MergeDuplicatePointsOff().
		/// </summary>
		// Token: 0x06017263 RID: 94819 RVA: 0x00207F9C File Offset: 0x0020619C
		public virtual bool GetMergeDuplicatePoints()
		{
			return vtkMergeCells.vtkMergeCells_GetMergeDuplicatePoints_02(base.GetCppThis()) != 0;
		}

		// Token: 0x06017264 RID: 94820
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeCells_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017265 RID: 94821 RVA: 0x00207FC4 File Offset: 0x002061C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMergeCells.vtkMergeCells_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06017266 RID: 94822
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeCells_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017267 RID: 94823 RVA: 0x00207FE4 File Offset: 0x002061E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMergeCells.vtkMergeCells_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06017268 RID: 94824
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeCells_GetOutputPointsPrecision_05(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06017269 RID: 94825 RVA: 0x00208000 File Offset: 0x00206200
		public virtual int GetOutputPointsPrecision()
		{
			return vtkMergeCells.vtkMergeCells_GetOutputPointsPrecision_05(base.GetCppThis());
		}

		// Token: 0x0601726A RID: 94826
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMergeCells_GetPointMergeTolerance_06(HandleRef pThis);

		/// <summary>
		/// vtkMergeCells attempts eliminate duplicate points when merging
		/// data sets.  If no global point ID field array name is provided,
		/// it will use a point locator to find duplicate points.  You can
		/// set a tolerance for that locator here.  The default tolerance
		/// is 10e-4.
		/// </summary>
		// Token: 0x0601726B RID: 94827 RVA: 0x00208020 File Offset: 0x00206220
		public virtual double GetPointMergeTolerance()
		{
			return vtkMergeCells.vtkMergeCells_GetPointMergeTolerance_06(base.GetCppThis());
		}

		// Token: 0x0601726C RID: 94828
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMergeCells_GetPointMergeToleranceMaxValue_07(HandleRef pThis);

		/// <summary>
		/// vtkMergeCells attempts eliminate duplicate points when merging
		/// data sets.  If no global point ID field array name is provided,
		/// it will use a point locator to find duplicate points.  You can
		/// set a tolerance for that locator here.  The default tolerance
		/// is 10e-4.
		/// </summary>
		// Token: 0x0601726D RID: 94829 RVA: 0x00208040 File Offset: 0x00206240
		public virtual double GetPointMergeToleranceMaxValue()
		{
			return vtkMergeCells.vtkMergeCells_GetPointMergeToleranceMaxValue_07(base.GetCppThis());
		}

		// Token: 0x0601726E RID: 94830
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMergeCells_GetPointMergeToleranceMinValue_08(HandleRef pThis);

		/// <summary>
		/// vtkMergeCells attempts eliminate duplicate points when merging
		/// data sets.  If no global point ID field array name is provided,
		/// it will use a point locator to find duplicate points.  You can
		/// set a tolerance for that locator here.  The default tolerance
		/// is 10e-4.
		/// </summary>
		// Token: 0x0601726F RID: 94831 RVA: 0x00208060 File Offset: 0x00206260
		public virtual double GetPointMergeToleranceMinValue()
		{
			return vtkMergeCells.vtkMergeCells_GetPointMergeToleranceMinValue_08(base.GetCppThis());
		}

		// Token: 0x06017270 RID: 94832
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeCells_GetTotalNumberOfCells_09(HandleRef pThis);

		/// <summary>
		/// Specify the total number of cells in the final vtkUnstructuredGrid.
		/// Make this call before any call to MergeDataSet().
		/// </summary>
		// Token: 0x06017271 RID: 94833 RVA: 0x00208080 File Offset: 0x00206280
		public virtual long GetTotalNumberOfCells()
		{
			return vtkMergeCells.vtkMergeCells_GetTotalNumberOfCells_09(base.GetCppThis());
		}

		// Token: 0x06017272 RID: 94834
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeCells_GetTotalNumberOfDataSets_10(HandleRef pThis);

		/// <summary>
		/// We need to know the number of different data sets that will
		/// be merged into one so we can pre-allocate some arrays.
		/// This can be an upper bound, not necessarily exact.
		/// </summary>
		// Token: 0x06017273 RID: 94835 RVA: 0x002080A0 File Offset: 0x002062A0
		public virtual int GetTotalNumberOfDataSets()
		{
			return vtkMergeCells.vtkMergeCells_GetTotalNumberOfDataSets_10(base.GetCppThis());
		}

		// Token: 0x06017274 RID: 94836
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeCells_GetTotalNumberOfPoints_11(HandleRef pThis);

		/// <summary>
		/// Specify the total number of points in the final vtkUnstructuredGrid
		/// Make this call before any call to MergeDataSet().  This is an
		/// upper bound, since some points may be duplicates.
		/// </summary>
		// Token: 0x06017275 RID: 94837 RVA: 0x002080C0 File Offset: 0x002062C0
		public virtual long GetTotalNumberOfPoints()
		{
			return vtkMergeCells.vtkMergeCells_GetTotalNumberOfPoints_11(base.GetCppThis());
		}

		// Token: 0x06017276 RID: 94838
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeCells_GetUnstructuredGrid_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the vtkUnstructuredGrid object that will become the
		/// union of the DataSets specified in MergeDataSet calls.
		/// vtkMergeCells assumes this grid is empty at first.
		/// </summary>
		// Token: 0x06017277 RID: 94839 RVA: 0x002080E0 File Offset: 0x002062E0
		public virtual vtkUnstructuredGrid GetUnstructuredGrid()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeCells.vtkMergeCells_GetUnstructuredGrid_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		// Token: 0x06017278 RID: 94840
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeCells_GetUseGlobalCellIds_13(HandleRef pThis);

		/// <summary>
		/// vtkMergeCells will detect and filter out duplicate cells if you
		/// provide it the name of a global cell ID array.
		/// </summary>
		// Token: 0x06017279 RID: 94841 RVA: 0x00208150 File Offset: 0x00206350
		public virtual int GetUseGlobalCellIds()
		{
			return vtkMergeCells.vtkMergeCells_GetUseGlobalCellIds_13(base.GetCppThis());
		}

		// Token: 0x0601727A RID: 94842
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeCells_GetUseGlobalIds_14(HandleRef pThis);

		/// <summary>
		/// vtkMergeCells attempts eliminate duplicate points when merging
		/// data sets.  This is done most efficiently if a global point ID
		/// field array is available.  Set the name of the point array if you
		/// have one.
		/// </summary>
		// Token: 0x0601727B RID: 94843 RVA: 0x00208170 File Offset: 0x00206370
		public virtual int GetUseGlobalIds()
		{
			return vtkMergeCells.vtkMergeCells_GetUseGlobalIds_14(base.GetCppThis());
		}

		// Token: 0x0601727C RID: 94844
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeCells_InvalidateCachedLocator_15(HandleRef pThis);

		/// <summary>
		/// Clear the Locator and set it to nullptr.
		/// </summary>
		// Token: 0x0601727D RID: 94845 RVA: 0x0020818F File Offset: 0x0020638F
		public void InvalidateCachedLocator()
		{
			vtkMergeCells.vtkMergeCells_InvalidateCachedLocator_15(base.GetCppThis());
		}

		// Token: 0x0601727E RID: 94846
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeCells_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601727F RID: 94847 RVA: 0x002081A0 File Offset: 0x002063A0
		public override int IsA(string type)
		{
			return vtkMergeCells.vtkMergeCells_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06017280 RID: 94848
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeCells_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017281 RID: 94849 RVA: 0x002081C0 File Offset: 0x002063C0
		public new static int IsTypeOf(string type)
		{
			return vtkMergeCells.vtkMergeCells_IsTypeOf_17(type);
		}

		// Token: 0x06017282 RID: 94850
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeCells_MergeDataSet_18(HandleRef pThis, HandleRef set);

		/// <summary>
		/// Provide a DataSet to be merged in to the final UnstructuredGrid.
		/// This call returns after the merge has completed.  Be sure to call
		/// SetTotalNumberOfCells, SetTotalNumberOfPoints, and SetTotalNumberOfDataSets
		/// before making this call.  Return 0 if OK, -1 if error.
		/// </summary>
		// Token: 0x06017283 RID: 94851 RVA: 0x002081DC File Offset: 0x002063DC
		public int MergeDataSet(vtkDataSet set)
		{
			return vtkMergeCells.vtkMergeCells_MergeDataSet_18(base.GetCppThis(), (set == null) ? default(HandleRef) : set.GetCppThis());
		}

		// Token: 0x06017284 RID: 94852
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeCells_MergeDuplicatePointsOff_19(HandleRef pThis);

		/// <summary>
		/// vtkMergeCells attempts eliminate duplicate points when merging
		/// data sets.  If for some reason you don't want it to do this,
		/// than MergeDuplicatePointsOff().
		/// </summary>
		// Token: 0x06017285 RID: 94853 RVA: 0x00208210 File Offset: 0x00206410
		public virtual void MergeDuplicatePointsOff()
		{
			vtkMergeCells.vtkMergeCells_MergeDuplicatePointsOff_19(base.GetCppThis());
		}

		// Token: 0x06017286 RID: 94854
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeCells_MergeDuplicatePointsOn_20(HandleRef pThis);

		/// <summary>
		/// vtkMergeCells attempts eliminate duplicate points when merging
		/// data sets.  If for some reason you don't want it to do this,
		/// than MergeDuplicatePointsOff().
		/// </summary>
		// Token: 0x06017287 RID: 94855 RVA: 0x0020821F File Offset: 0x0020641F
		public virtual void MergeDuplicatePointsOn()
		{
			vtkMergeCells.vtkMergeCells_MergeDuplicatePointsOn_20(base.GetCppThis());
		}

		// Token: 0x06017288 RID: 94856
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeCells_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017289 RID: 94857 RVA: 0x00208230 File Offset: 0x00206430
		public new vtkMergeCells NewInstance()
		{
			vtkMergeCells result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeCells.vtkMergeCells_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeCells)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601728A RID: 94858
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeCells_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601728B RID: 94859 RVA: 0x0020828C File Offset: 0x0020648C
		public new static vtkMergeCells SafeDownCast(vtkObjectBase o)
		{
			vtkMergeCells vtkMergeCells = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeCells.vtkMergeCells_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergeCells = (vtkMergeCells)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergeCells.Register(null);
				}
			}
			return vtkMergeCells;
		}

		// Token: 0x0601728C RID: 94860
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeCells_SetMergeDuplicatePoints_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// vtkMergeCells attempts eliminate duplicate points when merging
		/// data sets.  If for some reason you don't want it to do this,
		/// than MergeDuplicatePointsOff().
		/// </summary>
		// Token: 0x0601728D RID: 94861 RVA: 0x0020830B File Offset: 0x0020650B
		public virtual void SetMergeDuplicatePoints(bool _arg)
		{
			vtkMergeCells.vtkMergeCells_SetMergeDuplicatePoints_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601728E RID: 94862
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeCells_SetOutputPointsPrecision_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0601728F RID: 94863 RVA: 0x00208323 File Offset: 0x00206523
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkMergeCells.vtkMergeCells_SetOutputPointsPrecision_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06017290 RID: 94864
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeCells_SetPointMergeTolerance_26(HandleRef pThis, double _arg);

		/// <summary>
		/// vtkMergeCells attempts eliminate duplicate points when merging
		/// data sets.  If no global point ID field array name is provided,
		/// it will use a point locator to find duplicate points.  You can
		/// set a tolerance for that locator here.  The default tolerance
		/// is 10e-4.
		/// </summary>
		// Token: 0x06017291 RID: 94865 RVA: 0x00208333 File Offset: 0x00206533
		public virtual void SetPointMergeTolerance(double _arg)
		{
			vtkMergeCells.vtkMergeCells_SetPointMergeTolerance_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06017292 RID: 94866
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeCells_SetTotalNumberOfCells_27(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the total number of cells in the final vtkUnstructuredGrid.
		/// Make this call before any call to MergeDataSet().
		/// </summary>
		// Token: 0x06017293 RID: 94867 RVA: 0x00208343 File Offset: 0x00206543
		public virtual void SetTotalNumberOfCells(long _arg)
		{
			vtkMergeCells.vtkMergeCells_SetTotalNumberOfCells_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06017294 RID: 94868
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeCells_SetTotalNumberOfDataSets_28(HandleRef pThis, int _arg);

		/// <summary>
		/// We need to know the number of different data sets that will
		/// be merged into one so we can pre-allocate some arrays.
		/// This can be an upper bound, not necessarily exact.
		/// </summary>
		// Token: 0x06017295 RID: 94869 RVA: 0x00208353 File Offset: 0x00206553
		public virtual void SetTotalNumberOfDataSets(int _arg)
		{
			vtkMergeCells.vtkMergeCells_SetTotalNumberOfDataSets_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06017296 RID: 94870
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeCells_SetTotalNumberOfPoints_29(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the total number of points in the final vtkUnstructuredGrid
		/// Make this call before any call to MergeDataSet().  This is an
		/// upper bound, since some points may be duplicates.
		/// </summary>
		// Token: 0x06017297 RID: 94871 RVA: 0x00208363 File Offset: 0x00206563
		public virtual void SetTotalNumberOfPoints(long _arg)
		{
			vtkMergeCells.vtkMergeCells_SetTotalNumberOfPoints_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06017298 RID: 94872
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeCells_SetUnstructuredGrid_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the vtkUnstructuredGrid object that will become the
		/// union of the DataSets specified in MergeDataSet calls.
		/// vtkMergeCells assumes this grid is empty at first.
		/// </summary>
		// Token: 0x06017299 RID: 94873 RVA: 0x00208374 File Offset: 0x00206574
		public virtual void SetUnstructuredGrid(vtkUnstructuredGrid arg0)
		{
			vtkMergeCells.vtkMergeCells_SetUnstructuredGrid_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601729A RID: 94874
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeCells_SetUseGlobalCellIds_31(HandleRef pThis, int _arg);

		/// <summary>
		/// vtkMergeCells will detect and filter out duplicate cells if you
		/// provide it the name of a global cell ID array.
		/// </summary>
		// Token: 0x0601729B RID: 94875 RVA: 0x002083A3 File Offset: 0x002065A3
		public virtual void SetUseGlobalCellIds(int _arg)
		{
			vtkMergeCells.vtkMergeCells_SetUseGlobalCellIds_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0601729C RID: 94876
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeCells_SetUseGlobalIds_32(HandleRef pThis, int _arg);

		/// <summary>
		/// vtkMergeCells attempts eliminate duplicate points when merging
		/// data sets.  This is done most efficiently if a global point ID
		/// field array is available.  Set the name of the point array if you
		/// have one.
		/// </summary>
		// Token: 0x0601729D RID: 94877 RVA: 0x002083B3 File Offset: 0x002065B3
		public virtual void SetUseGlobalIds(int _arg)
		{
			vtkMergeCells.vtkMergeCells_SetUseGlobalIds_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0601729E RID: 94878
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeCells_UseGlobalCellIdsOff_33(HandleRef pThis);

		/// <summary>
		/// vtkMergeCells will detect and filter out duplicate cells if you
		/// provide it the name of a global cell ID array.
		/// </summary>
		// Token: 0x0601729F RID: 94879 RVA: 0x002083C3 File Offset: 0x002065C3
		public virtual void UseGlobalCellIdsOff()
		{
			vtkMergeCells.vtkMergeCells_UseGlobalCellIdsOff_33(base.GetCppThis());
		}

		// Token: 0x060172A0 RID: 94880
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeCells_UseGlobalCellIdsOn_34(HandleRef pThis);

		/// <summary>
		/// vtkMergeCells will detect and filter out duplicate cells if you
		/// provide it the name of a global cell ID array.
		/// </summary>
		// Token: 0x060172A1 RID: 94881 RVA: 0x002083D2 File Offset: 0x002065D2
		public virtual void UseGlobalCellIdsOn()
		{
			vtkMergeCells.vtkMergeCells_UseGlobalCellIdsOn_34(base.GetCppThis());
		}

		// Token: 0x060172A2 RID: 94882
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeCells_UseGlobalIdsOff_35(HandleRef pThis);

		/// <summary>
		/// vtkMergeCells attempts eliminate duplicate points when merging
		/// data sets.  This is done most efficiently if a global point ID
		/// field array is available.  Set the name of the point array if you
		/// have one.
		/// </summary>
		// Token: 0x060172A3 RID: 94883 RVA: 0x002083E1 File Offset: 0x002065E1
		public virtual void UseGlobalIdsOff()
		{
			vtkMergeCells.vtkMergeCells_UseGlobalIdsOff_35(base.GetCppThis());
		}

		// Token: 0x060172A4 RID: 94884
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeCells_UseGlobalIdsOn_36(HandleRef pThis);

		/// <summary>
		/// vtkMergeCells attempts eliminate duplicate points when merging
		/// data sets.  This is done most efficiently if a global point ID
		/// field array is available.  Set the name of the point array if you
		/// have one.
		/// </summary>
		// Token: 0x060172A5 RID: 94885 RVA: 0x002083F0 File Offset: 0x002065F0
		public virtual void UseGlobalIdsOn()
		{
			vtkMergeCells.vtkMergeCells_UseGlobalIdsOn_36(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019E2 RID: 6626
		public new const string MRFullTypeName = "Kitware.VTK.vtkMergeCells";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019E3 RID: 6627
		public new static readonly string MRClassNameKey = "class vtkMergeCells";
	}
}
