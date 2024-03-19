using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellDataToPointData
	/// </summary>
	/// <remarks>
	///    map cell data to point data
	///
	/// vtkCellDataToPointData is a filter that transforms cell data (i.e., data
	/// specified per cell) into point data (i.e., data specified at cell
	/// points). The method of transformation is based on averaging the data
	/// values of all cells using each point. For large datasets with
	/// several cell data arrays, the filter optionally supports selective
	/// processing to speed up processing. Optionally, the input cell data can
	/// be passed through to the output as well.
	///
	/// Options exist to control which cells are used to perform the averaging
	/// operation. Since unstructured grids and polydata can contain cells of
	/// different dimensions, in some cases it is desirable to perform cell
	/// averaging using cells of a specified dimension. The available options to
	/// control this functionality are All (default), Patch and DataSetMax. Patch
	/// uses only the highest dimension cells attached to a point. DataSetMax uses
	/// the highest cell dimension in the entire data set.
	///
	/// @warning
	/// This filter is an abstract filter, that is, the output is an abstract type
	/// (i.e., vtkDataSet). Use the convenience methods (e.g.,
	/// GetPolyDataOutput(), GetStructuredPointsOutput(), etc.) to get the type
	/// of output you want.
	///
	/// @warning
	/// For maximum performance, use the ContributingCellOption=All. Other options
	/// significantly, negatively impact performance (on the order of &gt;10x).
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential execution type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointData vtkCellData vtkPointDataToCellData
	/// </seealso>
	// Token: 0x0200050A RID: 1290
	public class vtkCellDataToPointData : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E784 RID: 59268 RVA: 0x001428EB File Offset: 0x00140AEB
		static vtkCellDataToPointData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellDataToPointData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellDataToPointData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E785 RID: 59269 RVA: 0x00142913 File Offset: 0x00140B13
		public vtkCellDataToPointData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E786 RID: 59270
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellDataToPointData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600E787 RID: 59271 RVA: 0x00142924 File Offset: 0x00140B24
		public new static vtkCellDataToPointData New()
		{
			vtkCellDataToPointData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellDataToPointData.vtkCellDataToPointData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellDataToPointData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600E788 RID: 59272 RVA: 0x00142978 File Offset: 0x00140B78
		public vtkCellDataToPointData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellDataToPointData.vtkCellDataToPointData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E789 RID: 59273 RVA: 0x001429BC File Offset: 0x00140BBC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E78A RID: 59274
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDataToPointData_AddCellDataArray_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Adds an array to be processed. This only has an effect if the
		/// ProcessAllArrays option is turned off. If a name is already present,
		/// nothing happens.
		/// </summary>
		// Token: 0x0600E78B RID: 59275 RVA: 0x001429C7 File Offset: 0x00140BC7
		public virtual void AddCellDataArray(string name)
		{
			vtkCellDataToPointData.vtkCellDataToPointData_AddCellDataArray_01(base.GetCppThis(), name);
		}

		// Token: 0x0600E78C RID: 59276
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDataToPointData_ClearCellDataArrays_02(HandleRef pThis);

		/// <summary>
		/// Removes all arrays to be processed from the list. This only has an effect
		/// if the ProcessAllArrays option is turned off.
		/// </summary>
		// Token: 0x0600E78D RID: 59277 RVA: 0x001429D7 File Offset: 0x00140BD7
		public virtual void ClearCellDataArrays()
		{
			vtkCellDataToPointData.vtkCellDataToPointData_ClearCellDataArrays_02(base.GetCppThis());
		}

		// Token: 0x0600E78E RID: 59278
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellDataToPointData_GetContributingCellOption_03(HandleRef pThis);

		/// <summary>
		/// Option to specify what cells to include in the cell-averaging computation.
		/// Options are all cells (All, Patch and DataSetMax). The default is All.
		/// </summary>
		// Token: 0x0600E78F RID: 59279 RVA: 0x001429E8 File Offset: 0x00140BE8
		public virtual int GetContributingCellOption()
		{
			return vtkCellDataToPointData.vtkCellDataToPointData_GetContributingCellOption_03(base.GetCppThis());
		}

		// Token: 0x0600E790 RID: 59280
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellDataToPointData_GetContributingCellOptionMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Option to specify what cells to include in the cell-averaging computation.
		/// Options are all cells (All, Patch and DataSetMax). The default is All.
		/// </summary>
		// Token: 0x0600E791 RID: 59281 RVA: 0x00142A08 File Offset: 0x00140C08
		public virtual int GetContributingCellOptionMaxValue()
		{
			return vtkCellDataToPointData.vtkCellDataToPointData_GetContributingCellOptionMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0600E792 RID: 59282
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellDataToPointData_GetContributingCellOptionMinValue_05(HandleRef pThis);

		/// <summary>
		/// Option to specify what cells to include in the cell-averaging computation.
		/// Options are all cells (All, Patch and DataSetMax). The default is All.
		/// </summary>
		// Token: 0x0600E793 RID: 59283 RVA: 0x00142A28 File Offset: 0x00140C28
		public virtual int GetContributingCellOptionMinValue()
		{
			return vtkCellDataToPointData.vtkCellDataToPointData_GetContributingCellOptionMinValue_05(base.GetCppThis());
		}

		// Token: 0x0600E794 RID: 59284
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellDataToPointData_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600E795 RID: 59285 RVA: 0x00142A48 File Offset: 0x00140C48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellDataToPointData.vtkCellDataToPointData_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600E796 RID: 59286
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellDataToPointData_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600E797 RID: 59287 RVA: 0x00142A68 File Offset: 0x00140C68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellDataToPointData.vtkCellDataToPointData_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600E798 RID: 59288
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellDataToPointData_GetPassCellData_08(HandleRef pThis);

		/// <summary>
		/// Control whether the input cell data is to be passed to the output. If
		/// on, then the input cell data is passed through to the output; otherwise,
		/// only generated point data is placed into the output. The default is false.
		/// </summary>
		// Token: 0x0600E799 RID: 59289 RVA: 0x00142A84 File Offset: 0x00140C84
		public virtual bool GetPassCellData()
		{
			return vtkCellDataToPointData.vtkCellDataToPointData_GetPassCellData_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E79A RID: 59290
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellDataToPointData_GetPieceInvariant_09(HandleRef pThis);

		/// <summary>
		/// To get piece invariance, this filter has to request an
		/// extra ghost level.  By default piece invariance is on.
		/// </summary>
		// Token: 0x0600E79B RID: 59291 RVA: 0x00142AAC File Offset: 0x00140CAC
		public virtual bool GetPieceInvariant()
		{
			return vtkCellDataToPointData.vtkCellDataToPointData_GetPieceInvariant_09(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E79C RID: 59292
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellDataToPointData_GetProcessAllArrays_10(HandleRef pThis);

		/// <summary>
		/// Activate selective processing of arrays. If false, only arrays selected
		/// by the user will be considered by this filter. The default is true.
		/// </summary>
		// Token: 0x0600E79D RID: 59293 RVA: 0x00142AD4 File Offset: 0x00140CD4
		public virtual bool GetProcessAllArrays()
		{
			return vtkCellDataToPointData.vtkCellDataToPointData_GetProcessAllArrays_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E79E RID: 59294
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellDataToPointData_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600E79F RID: 59295 RVA: 0x00142AFC File Offset: 0x00140CFC
		public override int IsA(string type)
		{
			return vtkCellDataToPointData.vtkCellDataToPointData_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600E7A0 RID: 59296
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellDataToPointData_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600E7A1 RID: 59297 RVA: 0x00142B1C File Offset: 0x00140D1C
		public new static int IsTypeOf(string type)
		{
			return vtkCellDataToPointData.vtkCellDataToPointData_IsTypeOf_12(type);
		}

		// Token: 0x0600E7A2 RID: 59298
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellDataToPointData_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600E7A3 RID: 59299 RVA: 0x00142B38 File Offset: 0x00140D38
		public new vtkCellDataToPointData NewInstance()
		{
			vtkCellDataToPointData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellDataToPointData.vtkCellDataToPointData_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellDataToPointData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E7A4 RID: 59300
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDataToPointData_PassCellDataOff_15(HandleRef pThis);

		/// <summary>
		/// Control whether the input cell data is to be passed to the output. If
		/// on, then the input cell data is passed through to the output; otherwise,
		/// only generated point data is placed into the output. The default is false.
		/// </summary>
		// Token: 0x0600E7A5 RID: 59301 RVA: 0x00142B92 File Offset: 0x00140D92
		public virtual void PassCellDataOff()
		{
			vtkCellDataToPointData.vtkCellDataToPointData_PassCellDataOff_15(base.GetCppThis());
		}

		// Token: 0x0600E7A6 RID: 59302
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDataToPointData_PassCellDataOn_16(HandleRef pThis);

		/// <summary>
		/// Control whether the input cell data is to be passed to the output. If
		/// on, then the input cell data is passed through to the output; otherwise,
		/// only generated point data is placed into the output. The default is false.
		/// </summary>
		// Token: 0x0600E7A7 RID: 59303 RVA: 0x00142BA1 File Offset: 0x00140DA1
		public virtual void PassCellDataOn()
		{
			vtkCellDataToPointData.vtkCellDataToPointData_PassCellDataOn_16(base.GetCppThis());
		}

		// Token: 0x0600E7A8 RID: 59304
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDataToPointData_PieceInvariantOff_17(HandleRef pThis);

		/// <summary>
		/// To get piece invariance, this filter has to request an
		/// extra ghost level.  By default piece invariance is on.
		/// </summary>
		// Token: 0x0600E7A9 RID: 59305 RVA: 0x00142BB0 File Offset: 0x00140DB0
		public virtual void PieceInvariantOff()
		{
			vtkCellDataToPointData.vtkCellDataToPointData_PieceInvariantOff_17(base.GetCppThis());
		}

		// Token: 0x0600E7AA RID: 59306
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDataToPointData_PieceInvariantOn_18(HandleRef pThis);

		/// <summary>
		/// To get piece invariance, this filter has to request an
		/// extra ghost level.  By default piece invariance is on.
		/// </summary>
		// Token: 0x0600E7AB RID: 59307 RVA: 0x00142BBF File Offset: 0x00140DBF
		public virtual void PieceInvariantOn()
		{
			vtkCellDataToPointData.vtkCellDataToPointData_PieceInvariantOn_18(base.GetCppThis());
		}

		// Token: 0x0600E7AC RID: 59308
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDataToPointData_ProcessAllArraysOff_19(HandleRef pThis);

		/// <summary>
		/// Activate selective processing of arrays. If false, only arrays selected
		/// by the user will be considered by this filter. The default is true.
		/// </summary>
		// Token: 0x0600E7AD RID: 59309 RVA: 0x00142BCE File Offset: 0x00140DCE
		public virtual void ProcessAllArraysOff()
		{
			vtkCellDataToPointData.vtkCellDataToPointData_ProcessAllArraysOff_19(base.GetCppThis());
		}

		// Token: 0x0600E7AE RID: 59310
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDataToPointData_ProcessAllArraysOn_20(HandleRef pThis);

		/// <summary>
		/// Activate selective processing of arrays. If false, only arrays selected
		/// by the user will be considered by this filter. The default is true.
		/// </summary>
		// Token: 0x0600E7AF RID: 59311 RVA: 0x00142BDD File Offset: 0x00140DDD
		public virtual void ProcessAllArraysOn()
		{
			vtkCellDataToPointData.vtkCellDataToPointData_ProcessAllArraysOn_20(base.GetCppThis());
		}

		// Token: 0x0600E7B0 RID: 59312
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDataToPointData_RemoveCellDataArray_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Removes an array to be processed. This only has an effect if the
		/// ProcessAllArrays option is turned off. If the specified name is not
		/// present, nothing happens.
		/// </summary>
		// Token: 0x0600E7B1 RID: 59313 RVA: 0x00142BEC File Offset: 0x00140DEC
		public virtual void RemoveCellDataArray(string name)
		{
			vtkCellDataToPointData.vtkCellDataToPointData_RemoveCellDataArray_21(base.GetCppThis(), name);
		}

		// Token: 0x0600E7B2 RID: 59314
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellDataToPointData_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600E7B3 RID: 59315 RVA: 0x00142BFC File Offset: 0x00140DFC
		public new static vtkCellDataToPointData SafeDownCast(vtkObjectBase o)
		{
			vtkCellDataToPointData vtkCellDataToPointData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellDataToPointData.vtkCellDataToPointData_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellDataToPointData = (vtkCellDataToPointData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellDataToPointData.Register(null);
				}
			}
			return vtkCellDataToPointData;
		}

		// Token: 0x0600E7B4 RID: 59316
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDataToPointData_SetContributingCellOption_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Option to specify what cells to include in the cell-averaging computation.
		/// Options are all cells (All, Patch and DataSetMax). The default is All.
		/// </summary>
		// Token: 0x0600E7B5 RID: 59317 RVA: 0x00142C7B File Offset: 0x00140E7B
		public virtual void SetContributingCellOption(int _arg)
		{
			vtkCellDataToPointData.vtkCellDataToPointData_SetContributingCellOption_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E7B6 RID: 59318
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDataToPointData_SetPassCellData_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// Control whether the input cell data is to be passed to the output. If
		/// on, then the input cell data is passed through to the output; otherwise,
		/// only generated point data is placed into the output. The default is false.
		/// </summary>
		// Token: 0x0600E7B7 RID: 59319 RVA: 0x00142C8B File Offset: 0x00140E8B
		public virtual void SetPassCellData(bool _arg)
		{
			vtkCellDataToPointData.vtkCellDataToPointData_SetPassCellData_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E7B8 RID: 59320
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDataToPointData_SetPieceInvariant_25(HandleRef pThis, byte _arg);

		/// <summary>
		/// To get piece invariance, this filter has to request an
		/// extra ghost level.  By default piece invariance is on.
		/// </summary>
		// Token: 0x0600E7B9 RID: 59321 RVA: 0x00142CA3 File Offset: 0x00140EA3
		public virtual void SetPieceInvariant(bool _arg)
		{
			vtkCellDataToPointData.vtkCellDataToPointData_SetPieceInvariant_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E7BA RID: 59322
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDataToPointData_SetProcessAllArrays_26(HandleRef pThis, byte _arg);

		/// <summary>
		/// Activate selective processing of arrays. If false, only arrays selected
		/// by the user will be considered by this filter. The default is true.
		/// </summary>
		// Token: 0x0600E7BB RID: 59323 RVA: 0x00142CBB File Offset: 0x00140EBB
		public virtual void SetProcessAllArrays(bool _arg)
		{
			vtkCellDataToPointData.vtkCellDataToPointData_SetProcessAllArrays_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010FC RID: 4348
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellDataToPointData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010FD RID: 4349
		public new static readonly string MRClassNameKey = "class vtkCellDataToPointData";

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0200050B RID: 1291
		public enum ContributingCellEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040010FF RID: 4351
			All,
			/// <summary>enum member</summary>
			// Token: 0x04001100 RID: 4352
			DataSetMax = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001101 RID: 4353
			Patch = 1
		}
	}
}
