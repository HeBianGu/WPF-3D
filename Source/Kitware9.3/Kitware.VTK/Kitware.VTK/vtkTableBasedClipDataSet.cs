using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTableBasedClipDataSet
	/// </summary>
	/// <remarks>
	///    Clip any dataset with a user-specified
	///  implicit function or an input scalar point data array.
	///
	///
	///  vtkTableBasedClipDataSet is a filter that clips any type of dataset using
	///  either any subclass of vtkImplicitFunction or an input scalar point data
	///  array. Clipping means that it actually "cuts" through the cells of the
	///  dataset, returning everything outside the specified implicit function (or
	///  greater than the scalar value) including "pieces" of a cell (Note to compare
	///  this with vtkExtractGeometry, which pulls out entire, uncut cells). The
	///  output of this filter is a vtkUnstructuredGrid data.
	///
	///  To use this filter, you need to decide whether an implicit function or an
	///  input scalar point data array is used for clipping. For the former case,
	///  1) define an implicit function
	///  2) provide it to this filter via SetClipFunction()
	///  If a clipping function is not specified, or GenerateClipScalars is off( the
	///  default), the input scalar point data array is then employed for clipping.
	///
	///  You can also specify a scalar (iso-)value, which is used to decide what is
	///  inside and outside the implicit function. You can also reverse the sense of
	///  what inside/outside is by setting IVAR InsideOut. The clipping algorithm
	///  proceeds by computing an implicit function value or using the input scalar
	///  point data value for each point in the dataset. This is compared against the
	///  scalar (iso-)value to determine the inside/outside status.
	///
	///  Although this filter sometimes (but rarely) may resort to the sibling class
	///  vtkClipDataSet for handling some special grids (such as cylinders or cones
	///  with capping faces in the form of a vtkPolyData), it itself is able to deal
	///  with most grids. It is worth mentioning that vtkTableBasedClipDataSet is
	///  capable of addressing the artifacts that may occur with vtkClipDataSet due
	///  to the possibly inconsistent triangulation modes between neighboring cells.
	///  In addition, the former is much faster than the latter. Furthermore, the
	///  former produces less cells (with ratio usually being 5~6) than by the latter
	///  in the output. In other words, this filter retains the original cells (i.e.,
	///  without triangulation / tetrahedralization) wherever possible. All these
	///  advantages are gained by adopting the unique clipping and triangulation tables
	///  proposed by VisIt.
	///
	/// @warning
	///  vtkTableBasedClipDataSet makes use of a hash table (that is provided by class
	///  maintained by internal class vtkTableBasedClipperDataSetFromVolume) to achieve
	///  rapid removal of duplicate points. The hash-based mechanism simply compares the
	///  point Ids, without considering the actual inter-point distance (vtkClipDataSet
	///  adopts vtkMergePoints that though considers the inter-point distance for robust
	///  points merging ). As a result, some duplicate points may be present in the output.
	///  This problem occurs when some boundary (cut-through cells) happen to have faces
	///  EXACTLY aligned with the clipping plane (such as Plane, Box, or other implicit
	///  functions with planar shapes). The occurrence (though very rare) of duplicate
	///  points produces degenerate cells, which can be fixed by post-processing the
	///  output with a filter like vtkCleanGrid.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// @par Thanks:
	///  This filter was adapted from the VisIt clipper (vtkVisItClipper).
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkClipDataSet vtkClipVolume vtkClipPolyData vtkCutter vtkImplicitFunction
	/// </seealso>
	// Token: 0x020008EA RID: 2282
	public class vtkTableBasedClipDataSet : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060178B1 RID: 96433 RVA: 0x00210953 File Offset: 0x0020EB53
		static vtkTableBasedClipDataSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableBasedClipDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableBasedClipDataSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060178B2 RID: 96434 RVA: 0x0021097B File Offset: 0x0020EB7B
		public vtkTableBasedClipDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060178B3 RID: 96435
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableBasedClipDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create an instance with a user-specified implicit function, turning off
		/// IVARs InsideOut and GenerateClipScalars and setting IVAR Value to 0.0.
		/// </summary>
		// Token: 0x060178B4 RID: 96436 RVA: 0x0021098C File Offset: 0x0020EB8C
		public new static vtkTableBasedClipDataSet New()
		{
			vtkTableBasedClipDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableBasedClipDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create an instance with a user-specified implicit function, turning off
		/// IVARs InsideOut and GenerateClipScalars and setting IVAR Value to 0.0.
		/// </summary>
		// Token: 0x060178B5 RID: 96437 RVA: 0x002109E0 File Offset: 0x0020EBE0
		public vtkTableBasedClipDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060178B6 RID: 96438 RVA: 0x00210A24 File Offset: 0x0020EC24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060178B7 RID: 96439
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_GenerateClipScalarsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get flag GenerateClipScalars, with 0 as the default value. With this
		/// flag on, the scalar point data values obtained by evaluating the implicit
		/// function will be exported to the output. Note that this flag requiries that
		/// an implicit function be provided.
		/// </summary>
		// Token: 0x060178B8 RID: 96440 RVA: 0x00210A2F File Offset: 0x0020EC2F
		public virtual void GenerateClipScalarsOff()
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GenerateClipScalarsOff_01(base.GetCppThis());
		}

		// Token: 0x060178B9 RID: 96441
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_GenerateClipScalarsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get flag GenerateClipScalars, with 0 as the default value. With this
		/// flag on, the scalar point data values obtained by evaluating the implicit
		/// function will be exported to the output. Note that this flag requiries that
		/// an implicit function be provided.
		/// </summary>
		// Token: 0x060178BA RID: 96442 RVA: 0x00210A3E File Offset: 0x0020EC3E
		public virtual void GenerateClipScalarsOn()
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GenerateClipScalarsOn_02(base.GetCppThis());
		}

		// Token: 0x060178BB RID: 96443
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_GenerateClippedOutputOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get whether a second output is generated. The second output contains the
		/// polygonal data that is clipped away by the iso-surface.
		/// </summary>
		// Token: 0x060178BC RID: 96444 RVA: 0x00210A4D File Offset: 0x0020EC4D
		public virtual void GenerateClippedOutputOff()
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GenerateClippedOutputOff_03(base.GetCppThis());
		}

		// Token: 0x060178BD RID: 96445
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_GenerateClippedOutputOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get whether a second output is generated. The second output contains the
		/// polygonal data that is clipped away by the iso-surface.
		/// </summary>
		// Token: 0x060178BE RID: 96446 RVA: 0x00210A5C File Offset: 0x0020EC5C
		public virtual void GenerateClippedOutputOn()
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GenerateClippedOutputOn_04(base.GetCppThis());
		}

		// Token: 0x060178BF RID: 96447
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkTableBasedClipDataSet_GetBatchSize_05(HandleRef pThis);

		/// <summary>
		/// Specify the number of input cells in a batch, where a batch defines
		/// a subset of the input cells operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload).
		///
		/// Default is 1000.
		/// </summary>
		// Token: 0x060178C0 RID: 96448 RVA: 0x00210A6C File Offset: 0x0020EC6C
		public virtual uint GetBatchSize()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetBatchSize_05(base.GetCppThis());
		}

		// Token: 0x060178C1 RID: 96449
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkTableBasedClipDataSet_GetBatchSizeMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Specify the number of input cells in a batch, where a batch defines
		/// a subset of the input cells operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload).
		///
		/// Default is 1000.
		/// </summary>
		// Token: 0x060178C2 RID: 96450 RVA: 0x00210A8C File Offset: 0x0020EC8C
		public virtual uint GetBatchSizeMaxValue()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetBatchSizeMaxValue_06(base.GetCppThis());
		}

		// Token: 0x060178C3 RID: 96451
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkTableBasedClipDataSet_GetBatchSizeMinValue_07(HandleRef pThis);

		/// <summary>
		/// Specify the number of input cells in a batch, where a batch defines
		/// a subset of the input cells operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload).
		///
		/// Default is 1000.
		/// </summary>
		// Token: 0x060178C4 RID: 96452 RVA: 0x00210AAC File Offset: 0x0020ECAC
		public virtual uint GetBatchSizeMinValue()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetBatchSizeMinValue_07(base.GetCppThis());
		}

		// Token: 0x060178C5 RID: 96453
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableBasedClipDataSet_GetClipFunction_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the implicit function with which to perform the clipping operation.
		/// Unless an implicit function is defined, the specified input scalar data will
		/// be used for clipping.
		/// </summary>
		// Token: 0x060178C6 RID: 96454 RVA: 0x00210ACC File Offset: 0x0020ECCC
		public virtual vtkImplicitFunction GetClipFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetClipFunction_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		// Token: 0x060178C7 RID: 96455
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableBasedClipDataSet_GetClippedOutput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the clipped output.
		/// </summary>
		// Token: 0x060178C8 RID: 96456 RVA: 0x00210B3C File Offset: 0x0020ED3C
		public vtkUnstructuredGrid GetClippedOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetClippedOutput_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060178C9 RID: 96457
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableBasedClipDataSet_GetGenerateClipScalars_10(HandleRef pThis);

		/// <summary>
		/// Set/Get flag GenerateClipScalars, with 0 as the default value. With this
		/// flag on, the scalar point data values obtained by evaluating the implicit
		/// function will be exported to the output. Note that this flag requiries that
		/// an implicit function be provided.
		/// </summary>
		// Token: 0x060178CA RID: 96458 RVA: 0x00210BAC File Offset: 0x0020EDAC
		public virtual int GetGenerateClipScalars()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetGenerateClipScalars_10(base.GetCppThis());
		}

		// Token: 0x060178CB RID: 96459
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableBasedClipDataSet_GetGenerateClippedOutput_11(HandleRef pThis);

		/// <summary>
		/// Set/Get whether a second output is generated. The second output contains the
		/// polygonal data that is clipped away by the iso-surface.
		/// </summary>
		// Token: 0x060178CC RID: 96460 RVA: 0x00210BCC File Offset: 0x0020EDCC
		public virtual int GetGenerateClippedOutput()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetGenerateClippedOutput_11(base.GetCppThis());
		}

		// Token: 0x060178CD RID: 96461
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableBasedClipDataSet_GetInsideOut_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. With this flag off, a vertex is considered
		/// inside (the implicit function or the isosurface) if the (function or scalar)
		/// value is greater than IVAR Value. With this flag on, a vertex is considered
		/// inside (the implicit function or the isosurface) if the (function or scalar)
		/// value is less than or equal to IVAR Value. This flag is off by default.
		/// </summary>
		// Token: 0x060178CE RID: 96462 RVA: 0x00210BEC File Offset: 0x0020EDEC
		public virtual int GetInsideOut()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetInsideOut_12(base.GetCppThis());
		}

		// Token: 0x060178CF RID: 96463
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableBasedClipDataSet_GetLocator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a spatial locator for merging points.
		/// Forwarded to vtkClipDataSet.
		/// </summary>
		// Token: 0x060178D0 RID: 96464 RVA: 0x00210C0C File Offset: 0x0020EE0C
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetLocator_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060178D1 RID: 96465
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTableBasedClipDataSet_GetMTime_14(HandleRef pThis);

		/// <summary>
		/// Get the MTime for which the clip function are considered.
		/// </summary>
		// Token: 0x060178D2 RID: 96466 RVA: 0x00210C7C File Offset: 0x0020EE7C
		public override ulong GetMTime()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetMTime_14(base.GetCppThis());
		}

		// Token: 0x060178D3 RID: 96467
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTableBasedClipDataSet_GetMergeTolerance_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the tolerance used for merging duplicate points near the clipping
		/// intersection cells. This tolerance may prevent the generation of degenerate
		/// primitives. Note that only 3D cells actually use this IVAR when vtkClipDataSet
		/// is invoked as last resort.
		/// </summary>
		// Token: 0x060178D4 RID: 96468 RVA: 0x00210C9C File Offset: 0x0020EE9C
		public virtual double GetMergeTolerance()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetMergeTolerance_15(base.GetCppThis());
		}

		// Token: 0x060178D5 RID: 96469
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTableBasedClipDataSet_GetMergeToleranceMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the tolerance used for merging duplicate points near the clipping
		/// intersection cells. This tolerance may prevent the generation of degenerate
		/// primitives. Note that only 3D cells actually use this IVAR when vtkClipDataSet
		/// is invoked as last resort.
		/// </summary>
		// Token: 0x060178D6 RID: 96470 RVA: 0x00210CBC File Offset: 0x0020EEBC
		public virtual double GetMergeToleranceMaxValue()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetMergeToleranceMaxValue_16(base.GetCppThis());
		}

		// Token: 0x060178D7 RID: 96471
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTableBasedClipDataSet_GetMergeToleranceMinValue_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the tolerance used for merging duplicate points near the clipping
		/// intersection cells. This tolerance may prevent the generation of degenerate
		/// primitives. Note that only 3D cells actually use this IVAR when vtkClipDataSet
		/// is invoked as last resort.
		/// </summary>
		// Token: 0x060178D8 RID: 96472 RVA: 0x00210CDC File Offset: 0x0020EEDC
		public virtual double GetMergeToleranceMinValue()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetMergeToleranceMinValue_17(base.GetCppThis());
		}

		// Token: 0x060178D9 RID: 96473
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableBasedClipDataSet_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060178DA RID: 96474 RVA: 0x00210CFC File Offset: 0x0020EEFC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x060178DB RID: 96475
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableBasedClipDataSet_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060178DC RID: 96476 RVA: 0x00210D1C File Offset: 0x0020EF1C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x060178DD RID: 96477
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableBasedClipDataSet_GetOutputPointsPrecision_20(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x060178DE RID: 96478 RVA: 0x00210D38 File Offset: 0x0020EF38
		public virtual int GetOutputPointsPrecision()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetOutputPointsPrecision_20(base.GetCppThis());
		}

		// Token: 0x060178DF RID: 96479
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableBasedClipDataSet_GetOutputPointsPrecisionMaxValue_21(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x060178E0 RID: 96480 RVA: 0x00210D58 File Offset: 0x0020EF58
		public virtual int GetOutputPointsPrecisionMaxValue()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetOutputPointsPrecisionMaxValue_21(base.GetCppThis());
		}

		// Token: 0x060178E1 RID: 96481
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableBasedClipDataSet_GetOutputPointsPrecisionMinValue_22(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x060178E2 RID: 96482 RVA: 0x00210D78 File Offset: 0x0020EF78
		public virtual int GetOutputPointsPrecisionMinValue()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetOutputPointsPrecisionMinValue_22(base.GetCppThis());
		}

		// Token: 0x060178E3 RID: 96483
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTableBasedClipDataSet_GetUseValueAsOffset_23(HandleRef pThis);

		/// <summary>
		/// Set/Get flag UseValueAsOffset, with true as the default value. With this flag
		/// on, IVAR Value is used as an offset parameter to the implicit function. Value
		/// is used only when clipping using a scalar array.
		/// </summary>
		// Token: 0x060178E4 RID: 96484 RVA: 0x00210D98 File Offset: 0x0020EF98
		public virtual bool GetUseValueAsOffset()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetUseValueAsOffset_23(base.GetCppThis()) != 0;
		}

		// Token: 0x060178E5 RID: 96485
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTableBasedClipDataSet_GetValue_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the clipping value of the implicit function (if an implicit function
		/// is applied) or scalar data array (if a scalar data array is used), with 0.0
		/// as the default value. This value is ignored if flag UseValueAsOffset is true
		/// AND a clip function is defined.
		/// </summary>
		// Token: 0x060178E6 RID: 96486 RVA: 0x00210DC0 File Offset: 0x0020EFC0
		public virtual double GetValue()
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_GetValue_24(base.GetCppThis());
		}

		// Token: 0x060178E7 RID: 96487
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_InsideOutOff_25(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. With this flag off, a vertex is considered
		/// inside (the implicit function or the isosurface) if the (function or scalar)
		/// value is greater than IVAR Value. With this flag on, a vertex is considered
		/// inside (the implicit function or the isosurface) if the (function or scalar)
		/// value is less than or equal to IVAR Value. This flag is off by default.
		/// </summary>
		// Token: 0x060178E8 RID: 96488 RVA: 0x00210DDF File Offset: 0x0020EFDF
		public virtual void InsideOutOff()
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_InsideOutOff_25(base.GetCppThis());
		}

		// Token: 0x060178E9 RID: 96489
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_InsideOutOn_26(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. With this flag off, a vertex is considered
		/// inside (the implicit function or the isosurface) if the (function or scalar)
		/// value is greater than IVAR Value. With this flag on, a vertex is considered
		/// inside (the implicit function or the isosurface) if the (function or scalar)
		/// value is less than or equal to IVAR Value. This flag is off by default.
		/// </summary>
		// Token: 0x060178EA RID: 96490 RVA: 0x00210DEE File Offset: 0x0020EFEE
		public virtual void InsideOutOn()
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_InsideOutOn_26(base.GetCppThis());
		}

		// Token: 0x060178EB RID: 96491
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableBasedClipDataSet_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060178EC RID: 96492 RVA: 0x00210E00 File Offset: 0x0020F000
		public override int IsA(string type)
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x060178ED RID: 96493
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableBasedClipDataSet_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060178EE RID: 96494 RVA: 0x00210E20 File Offset: 0x0020F020
		public new static int IsTypeOf(string type)
		{
			return vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_IsTypeOf_28(type);
		}

		// Token: 0x060178EF RID: 96495
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableBasedClipDataSet_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060178F0 RID: 96496 RVA: 0x00210E3C File Offset: 0x0020F03C
		public new vtkTableBasedClipDataSet NewInstance()
		{
			vtkTableBasedClipDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableBasedClipDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060178F1 RID: 96497
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableBasedClipDataSet_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060178F2 RID: 96498 RVA: 0x00210E98 File Offset: 0x0020F098
		public new static vtkTableBasedClipDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkTableBasedClipDataSet vtkTableBasedClipDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableBasedClipDataSet = (vtkTableBasedClipDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableBasedClipDataSet.Register(null);
				}
			}
			return vtkTableBasedClipDataSet;
		}

		// Token: 0x060178F3 RID: 96499
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_SetBatchSize_32(HandleRef pThis, uint _arg);

		/// <summary>
		/// Specify the number of input cells in a batch, where a batch defines
		/// a subset of the input cells operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload).
		///
		/// Default is 1000.
		/// </summary>
		// Token: 0x060178F4 RID: 96500 RVA: 0x00210F17 File Offset: 0x0020F117
		public virtual void SetBatchSize(uint _arg)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetBatchSize_32(base.GetCppThis(), _arg);
		}

		// Token: 0x060178F5 RID: 96501
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_SetClipFunction_33(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the implicit function with which to perform the clipping operation.
		/// Unless an implicit function is defined, the specified input scalar data will
		/// be used for clipping.
		/// </summary>
		// Token: 0x060178F6 RID: 96502 RVA: 0x00210F28 File Offset: 0x0020F128
		public virtual void SetClipFunction(vtkImplicitFunction arg0)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetClipFunction_33(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060178F7 RID: 96503
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_SetGenerateClipScalars_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get flag GenerateClipScalars, with 0 as the default value. With this
		/// flag on, the scalar point data values obtained by evaluating the implicit
		/// function will be exported to the output. Note that this flag requiries that
		/// an implicit function be provided.
		/// </summary>
		// Token: 0x060178F8 RID: 96504 RVA: 0x00210F57 File Offset: 0x0020F157
		public virtual void SetGenerateClipScalars(int _arg)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetGenerateClipScalars_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060178F9 RID: 96505
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_SetGenerateClippedOutput_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether a second output is generated. The second output contains the
		/// polygonal data that is clipped away by the iso-surface.
		/// </summary>
		// Token: 0x060178FA RID: 96506 RVA: 0x00210F67 File Offset: 0x0020F167
		public virtual void SetGenerateClippedOutput(int _arg)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetGenerateClippedOutput_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060178FB RID: 96507
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_SetInsideOut_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the InsideOut flag. With this flag off, a vertex is considered
		/// inside (the implicit function or the isosurface) if the (function or scalar)
		/// value is greater than IVAR Value. With this flag on, a vertex is considered
		/// inside (the implicit function or the isosurface) if the (function or scalar)
		/// value is less than or equal to IVAR Value. This flag is off by default.
		/// </summary>
		// Token: 0x060178FC RID: 96508 RVA: 0x00210F77 File Offset: 0x0020F177
		public virtual void SetInsideOut(int _arg)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetInsideOut_36(base.GetCppThis(), _arg);
		}

		// Token: 0x060178FD RID: 96509
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_SetLocator_37(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a spatial locator for merging points.
		/// Forwarded to vtkClipDataSet.
		/// </summary>
		// Token: 0x060178FE RID: 96510 RVA: 0x00210F88 File Offset: 0x0020F188
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetLocator_37(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x060178FF RID: 96511
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_SetMergeTolerance_38(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the tolerance used for merging duplicate points near the clipping
		/// intersection cells. This tolerance may prevent the generation of degenerate
		/// primitives. Note that only 3D cells actually use this IVAR when vtkClipDataSet
		/// is invoked as last resort.
		/// </summary>
		// Token: 0x06017900 RID: 96512 RVA: 0x00210FB7 File Offset: 0x0020F1B7
		public virtual void SetMergeTolerance(double _arg)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetMergeTolerance_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06017901 RID: 96513
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_SetOutputPointsPrecision_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x06017902 RID: 96514 RVA: 0x00210FC7 File Offset: 0x0020F1C7
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetOutputPointsPrecision_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06017903 RID: 96515
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_SetUseValueAsOffset_40(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get flag UseValueAsOffset, with true as the default value. With this flag
		/// on, IVAR Value is used as an offset parameter to the implicit function. Value
		/// is used only when clipping using a scalar array.
		/// </summary>
		// Token: 0x06017904 RID: 96516 RVA: 0x00210FD7 File Offset: 0x0020F1D7
		public virtual void SetUseValueAsOffset(bool _arg)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetUseValueAsOffset_40(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017905 RID: 96517
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_SetValue_41(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the clipping value of the implicit function (if an implicit function
		/// is applied) or scalar data array (if a scalar data array is used), with 0.0
		/// as the default value. This value is ignored if flag UseValueAsOffset is true
		/// AND a clip function is defined.
		/// </summary>
		// Token: 0x06017906 RID: 96518 RVA: 0x00210FEF File Offset: 0x0020F1EF
		public virtual void SetValue(double _arg)
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_SetValue_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06017907 RID: 96519
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_UseValueAsOffsetOff_42(HandleRef pThis);

		/// <summary>
		/// Set/Get flag UseValueAsOffset, with true as the default value. With this flag
		/// on, IVAR Value is used as an offset parameter to the implicit function. Value
		/// is used only when clipping using a scalar array.
		/// </summary>
		// Token: 0x06017908 RID: 96520 RVA: 0x00210FFF File Offset: 0x0020F1FF
		public virtual void UseValueAsOffsetOff()
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_UseValueAsOffsetOff_42(base.GetCppThis());
		}

		// Token: 0x06017909 RID: 96521
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableBasedClipDataSet_UseValueAsOffsetOn_43(HandleRef pThis);

		/// <summary>
		/// Set/Get flag UseValueAsOffset, with true as the default value. With this flag
		/// on, IVAR Value is used as an offset parameter to the implicit function. Value
		/// is used only when clipping using a scalar array.
		/// </summary>
		// Token: 0x0601790A RID: 96522 RVA: 0x0021100E File Offset: 0x0020F20E
		public virtual void UseValueAsOffsetOn()
		{
			vtkTableBasedClipDataSet.vtkTableBasedClipDataSet_UseValueAsOffsetOn_43(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A4E RID: 6734
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableBasedClipDataSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A4F RID: 6735
		public new static readonly string MRClassNameKey = "class vtkTableBasedClipDataSet";
	}
}
