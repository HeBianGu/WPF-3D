using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkClipDataSet
	/// </summary>
	/// <remarks>
	///    clip any dataset with user-specified implicit function or input scalar data
	///
	/// vtkClipDataSet is a filter that clips any type of dataset using either
	/// any subclass of vtkImplicitFunction, or the input scalar
	/// data. Clipping means that it actually "cuts" through the cells of
	/// the dataset, returning everything inside of the specified implicit
	/// function (or greater than the scalar value) including "pieces" of
	/// a cell. (Compare this with vtkExtractGeometry, which pulls out
	/// entire, uncut cells.) The output of this filter is an unstructured
	/// grid.
	///
	/// To use this filter, you must decide if you will be clipping with an
	/// implicit function, or whether you will be using the input scalar
	/// data.  If you want to clip with an implicit function, you must:
	/// 1) define an implicit function
	/// 2) set it with the SetClipFunction method
	/// 3) apply the GenerateClipScalarsOn method
	/// If a ClipFunction is not specified, or GenerateClipScalars is off
	/// (the default), then the input's scalar data will be used to clip
	/// the polydata.
	///
	/// You can also specify a scalar value, which is used to decide what is
	/// inside and outside of the implicit function. You can also reverse the
	/// sense of what inside/outside is by setting the InsideOut instance
	/// variable. (The clipping algorithm proceeds by computing an implicit
	/// function value or using the input scalar data for each point in the
	/// dataset. This is compared to the scalar value to determine
	/// inside/outside.)
	///
	/// This filter can be configured to compute a second output. The
	/// second output is the part of the cell that is clipped away. Set the
	/// GenerateClippedData boolean on if you wish to access this output data.
	///
	/// @warning
	/// vtkClipDataSet will triangulate all types of 3D cells (i.e., create
	/// tetrahedra). This is true even if the cell is not actually cut. This
	/// is necessary to preserve compatibility across face neighbors. 2D cells
	/// will only be triangulated if the cutting function passes through them.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitFunction vtkCutter vtkClipVolume vtkClipPolyData
	/// </seealso>
	// Token: 0x02000883 RID: 2179
	public class vtkClipDataSet : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060169DA RID: 92634 RVA: 0x001FD0AF File Offset: 0x001FB2AF
		static vtkClipDataSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClipDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClipDataSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060169DB RID: 92635 RVA: 0x001FD0D7 File Offset: 0x001FB2D7
		public vtkClipDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060169DC RID: 92636
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with user-specified implicit function; InsideOut turned off;
		/// value set to 0.0; and generate clip scalars turned off.
		/// </summary>
		// Token: 0x060169DD RID: 92637 RVA: 0x001FD0E8 File Offset: 0x001FB2E8
		public new static vtkClipDataSet New()
		{
			vtkClipDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipDataSet.vtkClipDataSet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with user-specified implicit function; InsideOut turned off;
		/// value set to 0.0; and generate clip scalars turned off.
		/// </summary>
		// Token: 0x060169DE RID: 92638 RVA: 0x001FD13C File Offset: 0x001FB33C
		public vtkClipDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkClipDataSet.vtkClipDataSet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060169DF RID: 92639 RVA: 0x001FD180 File Offset: 0x001FB380
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060169E0 RID: 92640
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_CreateDefaultLocator_01(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified. The
		/// locator is used to merge coincident points.
		/// </summary>
		// Token: 0x060169E1 RID: 92641 RVA: 0x001FD18B File Offset: 0x001FB38B
		public void CreateDefaultLocator()
		{
			vtkClipDataSet.vtkClipDataSet_CreateDefaultLocator_01(base.GetCppThis());
		}

		// Token: 0x060169E2 RID: 92642
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_GenerateClipScalarsOff_02(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the
		/// input scalar data. If you enable this flag but do not provide an
		/// implicit function an error will be reported.
		/// </summary>
		// Token: 0x060169E3 RID: 92643 RVA: 0x001FD19A File Offset: 0x001FB39A
		public virtual void GenerateClipScalarsOff()
		{
			vtkClipDataSet.vtkClipDataSet_GenerateClipScalarsOff_02(base.GetCppThis());
		}

		// Token: 0x060169E4 RID: 92644
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_GenerateClipScalarsOn_03(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the
		/// input scalar data. If you enable this flag but do not provide an
		/// implicit function an error will be reported.
		/// </summary>
		// Token: 0x060169E5 RID: 92645 RVA: 0x001FD1A9 File Offset: 0x001FB3A9
		public virtual void GenerateClipScalarsOn()
		{
			vtkClipDataSet.vtkClipDataSet_GenerateClipScalarsOn_03(base.GetCppThis());
		}

		// Token: 0x060169E6 RID: 92646
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_GenerateClippedOutputOff_04(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's been clipped away.
		/// </summary>
		// Token: 0x060169E7 RID: 92647 RVA: 0x001FD1B8 File Offset: 0x001FB3B8
		public virtual void GenerateClippedOutputOff()
		{
			vtkClipDataSet.vtkClipDataSet_GenerateClippedOutputOff_04(base.GetCppThis());
		}

		// Token: 0x060169E8 RID: 92648
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_GenerateClippedOutputOn_05(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's been clipped away.
		/// </summary>
		// Token: 0x060169E9 RID: 92649 RVA: 0x001FD1C7 File Offset: 0x001FB3C7
		public virtual void GenerateClippedOutputOn()
		{
			vtkClipDataSet.vtkClipDataSet_GenerateClippedOutputOn_05(base.GetCppThis());
		}

		// Token: 0x060169EA RID: 92650
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipDataSet_GetClipFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the implicit function with which to perform the
		/// clipping. If you do not define an implicit function,
		/// then the selected input scalar data will be used for clipping.
		/// </summary>
		// Token: 0x060169EB RID: 92651 RVA: 0x001FD1D8 File Offset: 0x001FB3D8
		public virtual vtkImplicitFunction GetClipFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipDataSet.vtkClipDataSet_GetClipFunction_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060169EC RID: 92652
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipDataSet_GetClippedOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the Clipped output.
		/// </summary>
		// Token: 0x060169ED RID: 92653 RVA: 0x001FD248 File Offset: 0x001FB448
		public vtkUnstructuredGrid GetClippedOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipDataSet.vtkClipDataSet_GetClippedOutput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060169EE RID: 92654
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipDataSet_GetGenerateClipScalars_08(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the
		/// input scalar data. If you enable this flag but do not provide an
		/// implicit function an error will be reported.
		/// </summary>
		// Token: 0x060169EF RID: 92655 RVA: 0x001FD2B8 File Offset: 0x001FB4B8
		public virtual int GetGenerateClipScalars()
		{
			return vtkClipDataSet.vtkClipDataSet_GetGenerateClipScalars_08(base.GetCppThis());
		}

		// Token: 0x060169F0 RID: 92656
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipDataSet_GetGenerateClippedOutput_09(HandleRef pThis);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's been clipped away.
		/// </summary>
		// Token: 0x060169F1 RID: 92657 RVA: 0x001FD2D8 File Offset: 0x001FB4D8
		public virtual int GetGenerateClippedOutput()
		{
			return vtkClipDataSet.vtkClipDataSet_GetGenerateClippedOutput_09(base.GetCppThis());
		}

		// Token: 0x060169F2 RID: 92658
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipDataSet_GetInsideOut_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, a vertex is considered
		/// inside the implicit function if its value is greater than the
		/// Value ivar. When InsideOutside is turned on, a vertex is
		/// considered inside the implicit function if its implicit function
		/// value is less than or equal to the Value ivar.  InsideOut is off
		/// by default.
		/// </summary>
		// Token: 0x060169F3 RID: 92659 RVA: 0x001FD2F8 File Offset: 0x001FB4F8
		public virtual int GetInsideOut()
		{
			return vtkClipDataSet.vtkClipDataSet_GetInsideOut_10(base.GetCppThis());
		}

		// Token: 0x060169F4 RID: 92660
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipDataSet_GetLocator_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a spatial locator for merging points. By default, an
		/// instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x060169F5 RID: 92661 RVA: 0x001FD318 File Offset: 0x001FB518
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipDataSet.vtkClipDataSet_GetLocator_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060169F6 RID: 92662
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkClipDataSet_GetMTime_12(HandleRef pThis);

		/// <summary>
		/// Return the mtime also considering the locator and clip function.
		/// </summary>
		// Token: 0x060169F7 RID: 92663 RVA: 0x001FD388 File Offset: 0x001FB588
		public override ulong GetMTime()
		{
			return vtkClipDataSet.vtkClipDataSet_GetMTime_12(base.GetCppThis());
		}

		// Token: 0x060169F8 RID: 92664
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClipDataSet_GetMergeTolerance_13(HandleRef pThis);

		/// <summary>
		/// Set the tolerance for merging clip intersection points that are near
		/// the vertices of cells. This tolerance is used to prevent the generation
		/// of degenerate primitives. Note that only 3D cells actually use this
		/// instance variable.
		/// </summary>
		// Token: 0x060169F9 RID: 92665 RVA: 0x001FD3A8 File Offset: 0x001FB5A8
		public virtual double GetMergeTolerance()
		{
			return vtkClipDataSet.vtkClipDataSet_GetMergeTolerance_13(base.GetCppThis());
		}

		// Token: 0x060169FA RID: 92666
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClipDataSet_GetMergeToleranceMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Set the tolerance for merging clip intersection points that are near
		/// the vertices of cells. This tolerance is used to prevent the generation
		/// of degenerate primitives. Note that only 3D cells actually use this
		/// instance variable.
		/// </summary>
		// Token: 0x060169FB RID: 92667 RVA: 0x001FD3C8 File Offset: 0x001FB5C8
		public virtual double GetMergeToleranceMaxValue()
		{
			return vtkClipDataSet.vtkClipDataSet_GetMergeToleranceMaxValue_14(base.GetCppThis());
		}

		// Token: 0x060169FC RID: 92668
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClipDataSet_GetMergeToleranceMinValue_15(HandleRef pThis);

		/// <summary>
		/// Set the tolerance for merging clip intersection points that are near
		/// the vertices of cells. This tolerance is used to prevent the generation
		/// of degenerate primitives. Note that only 3D cells actually use this
		/// instance variable.
		/// </summary>
		// Token: 0x060169FD RID: 92669 RVA: 0x001FD3E8 File Offset: 0x001FB5E8
		public virtual double GetMergeToleranceMinValue()
		{
			return vtkClipDataSet.vtkClipDataSet_GetMergeToleranceMinValue_15(base.GetCppThis());
		}

		// Token: 0x060169FE RID: 92670
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClipDataSet_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060169FF RID: 92671 RVA: 0x001FD408 File Offset: 0x001FB608
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkClipDataSet.vtkClipDataSet_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x06016A00 RID: 92672
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClipDataSet_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A01 RID: 92673 RVA: 0x001FD428 File Offset: 0x001FB628
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkClipDataSet.vtkClipDataSet_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x06016A02 RID: 92674
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipDataSet_GetOutputPointsPrecision_18(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06016A03 RID: 92675 RVA: 0x001FD444 File Offset: 0x001FB644
		public virtual int GetOutputPointsPrecision()
		{
			return vtkClipDataSet.vtkClipDataSet_GetOutputPointsPrecision_18(base.GetCppThis());
		}

		// Token: 0x06016A04 RID: 92676
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipDataSet_GetOutputPointsPrecisionMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06016A05 RID: 92677 RVA: 0x001FD464 File Offset: 0x001FB664
		public virtual int GetOutputPointsPrecisionMaxValue()
		{
			return vtkClipDataSet.vtkClipDataSet_GetOutputPointsPrecisionMaxValue_19(base.GetCppThis());
		}

		// Token: 0x06016A06 RID: 92678
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipDataSet_GetOutputPointsPrecisionMinValue_20(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06016A07 RID: 92679 RVA: 0x001FD484 File Offset: 0x001FB684
		public virtual int GetOutputPointsPrecisionMinValue()
		{
			return vtkClipDataSet.vtkClipDataSet_GetOutputPointsPrecisionMinValue_20(base.GetCppThis());
		}

		// Token: 0x06016A08 RID: 92680
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkClipDataSet_GetStableClipNonLinear_21(HandleRef pThis);

		/// <summary>
		/// Setter/Getter for stable clipping non-linear cells (default value is true)
		/// </summary>
		// Token: 0x06016A09 RID: 92681 RVA: 0x001FD4A4 File Offset: 0x001FB6A4
		public virtual bool GetStableClipNonLinear()
		{
			return vtkClipDataSet.vtkClipDataSet_GetStableClipNonLinear_21(base.GetCppThis()) != 0;
		}

		// Token: 0x06016A0A RID: 92682
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkClipDataSet_GetUseValueAsOffset_22(HandleRef pThis);

		/// <summary>
		/// If UseValueAsOffset is true, Value is used as an offset parameter to
		/// the implicit function. Otherwise, Value is used only when clipping
		/// using a scalar array. Default is true.
		/// </summary>
		// Token: 0x06016A0B RID: 92683 RVA: 0x001FD4CC File Offset: 0x001FB6CC
		public virtual bool GetUseValueAsOffset()
		{
			return vtkClipDataSet.vtkClipDataSet_GetUseValueAsOffset_22(base.GetCppThis()) != 0;
		}

		// Token: 0x06016A0C RID: 92684
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClipDataSet_GetValue_23(HandleRef pThis);

		/// <summary>
		/// Set the clipping value of the implicit function (if clipping with
		/// implicit function) or scalar value (if clipping with
		/// scalars). The default value is 0.0. This value is ignored if
		/// UseValueAsOffset is true and a clip function is defined.
		/// </summary>
		// Token: 0x06016A0D RID: 92685 RVA: 0x001FD4F4 File Offset: 0x001FB6F4
		public virtual double GetValue()
		{
			return vtkClipDataSet.vtkClipDataSet_GetValue_23(base.GetCppThis());
		}

		// Token: 0x06016A0E RID: 92686
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_InsideOutOff_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, a vertex is considered
		/// inside the implicit function if its value is greater than the
		/// Value ivar. When InsideOutside is turned on, a vertex is
		/// considered inside the implicit function if its implicit function
		/// value is less than or equal to the Value ivar.  InsideOut is off
		/// by default.
		/// </summary>
		// Token: 0x06016A0F RID: 92687 RVA: 0x001FD513 File Offset: 0x001FB713
		public virtual void InsideOutOff()
		{
			vtkClipDataSet.vtkClipDataSet_InsideOutOff_24(base.GetCppThis());
		}

		// Token: 0x06016A10 RID: 92688
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_InsideOutOn_25(HandleRef pThis);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, a vertex is considered
		/// inside the implicit function if its value is greater than the
		/// Value ivar. When InsideOutside is turned on, a vertex is
		/// considered inside the implicit function if its implicit function
		/// value is less than or equal to the Value ivar.  InsideOut is off
		/// by default.
		/// </summary>
		// Token: 0x06016A11 RID: 92689 RVA: 0x001FD522 File Offset: 0x001FB722
		public virtual void InsideOutOn()
		{
			vtkClipDataSet.vtkClipDataSet_InsideOutOn_25(base.GetCppThis());
		}

		// Token: 0x06016A12 RID: 92690
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipDataSet_IsA_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A13 RID: 92691 RVA: 0x001FD534 File Offset: 0x001FB734
		public override int IsA(string type)
		{
			return vtkClipDataSet.vtkClipDataSet_IsA_26(base.GetCppThis(), type);
		}

		// Token: 0x06016A14 RID: 92692
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipDataSet_IsTypeOf_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A15 RID: 92693 RVA: 0x001FD554 File Offset: 0x001FB754
		public new static int IsTypeOf(string type)
		{
			return vtkClipDataSet.vtkClipDataSet_IsTypeOf_27(type);
		}

		// Token: 0x06016A16 RID: 92694
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipDataSet_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A17 RID: 92695 RVA: 0x001FD570 File Offset: 0x001FB770
		public new vtkClipDataSet NewInstance()
		{
			vtkClipDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipDataSet.vtkClipDataSet_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016A18 RID: 92696
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipDataSet_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016A19 RID: 92697 RVA: 0x001FD5CC File Offset: 0x001FB7CC
		public new static vtkClipDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkClipDataSet vtkClipDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipDataSet.vtkClipDataSet_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClipDataSet = (vtkClipDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClipDataSet.Register(null);
				}
			}
			return vtkClipDataSet;
		}

		// Token: 0x06016A1A RID: 92698
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_SetClipFunction_31(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the implicit function with which to perform the
		/// clipping. If you do not define an implicit function,
		/// then the selected input scalar data will be used for clipping.
		/// </summary>
		// Token: 0x06016A1B RID: 92699 RVA: 0x001FD64C File Offset: 0x001FB84C
		public virtual void SetClipFunction(vtkImplicitFunction arg0)
		{
			vtkClipDataSet.vtkClipDataSet_SetClipFunction_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06016A1C RID: 92700
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_SetGenerateClipScalars_32(HandleRef pThis, int _arg);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the
		/// input scalar data. If you enable this flag but do not provide an
		/// implicit function an error will be reported.
		/// </summary>
		// Token: 0x06016A1D RID: 92701 RVA: 0x001FD67B File Offset: 0x001FB87B
		public virtual void SetGenerateClipScalars(int _arg)
		{
			vtkClipDataSet.vtkClipDataSet_SetGenerateClipScalars_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06016A1E RID: 92702
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_SetGenerateClippedOutput_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether a second output is generated. The second output
		/// contains the polygonal data that's been clipped away.
		/// </summary>
		// Token: 0x06016A1F RID: 92703 RVA: 0x001FD68B File Offset: 0x001FB88B
		public virtual void SetGenerateClippedOutput(int _arg)
		{
			vtkClipDataSet.vtkClipDataSet_SetGenerateClippedOutput_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06016A20 RID: 92704
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_SetInsideOut_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the InsideOut flag. When off, a vertex is considered
		/// inside the implicit function if its value is greater than the
		/// Value ivar. When InsideOutside is turned on, a vertex is
		/// considered inside the implicit function if its implicit function
		/// value is less than or equal to the Value ivar.  InsideOut is off
		/// by default.
		/// </summary>
		// Token: 0x06016A21 RID: 92705 RVA: 0x001FD69B File Offset: 0x001FB89B
		public virtual void SetInsideOut(int _arg)
		{
			vtkClipDataSet.vtkClipDataSet_SetInsideOut_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06016A22 RID: 92706
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_SetLocator_35(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a spatial locator for merging points. By default, an
		/// instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06016A23 RID: 92707 RVA: 0x001FD6AC File Offset: 0x001FB8AC
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkClipDataSet.vtkClipDataSet_SetLocator_35(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x06016A24 RID: 92708
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_SetMergeTolerance_36(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the tolerance for merging clip intersection points that are near
		/// the vertices of cells. This tolerance is used to prevent the generation
		/// of degenerate primitives. Note that only 3D cells actually use this
		/// instance variable.
		/// </summary>
		// Token: 0x06016A25 RID: 92709 RVA: 0x001FD6DB File Offset: 0x001FB8DB
		public virtual void SetMergeTolerance(double _arg)
		{
			vtkClipDataSet.vtkClipDataSet_SetMergeTolerance_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06016A26 RID: 92710
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_SetOutputPointsPrecision_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06016A27 RID: 92711 RVA: 0x001FD6EB File Offset: 0x001FB8EB
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkClipDataSet.vtkClipDataSet_SetOutputPointsPrecision_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06016A28 RID: 92712
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_SetStableClipNonLinear_38(HandleRef pThis, byte _arg);

		/// <summary>
		/// Setter/Getter for stable clipping non-linear cells (default value is true)
		/// </summary>
		// Token: 0x06016A29 RID: 92713 RVA: 0x001FD6FB File Offset: 0x001FB8FB
		public virtual void SetStableClipNonLinear(bool _arg)
		{
			vtkClipDataSet.vtkClipDataSet_SetStableClipNonLinear_38(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06016A2A RID: 92714
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_SetUseValueAsOffset_39(HandleRef pThis, byte _arg);

		/// <summary>
		/// If UseValueAsOffset is true, Value is used as an offset parameter to
		/// the implicit function. Otherwise, Value is used only when clipping
		/// using a scalar array. Default is true.
		/// </summary>
		// Token: 0x06016A2B RID: 92715 RVA: 0x001FD713 File Offset: 0x001FB913
		public virtual void SetUseValueAsOffset(bool _arg)
		{
			vtkClipDataSet.vtkClipDataSet_SetUseValueAsOffset_39(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06016A2C RID: 92716
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_SetValue_40(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the clipping value of the implicit function (if clipping with
		/// implicit function) or scalar value (if clipping with
		/// scalars). The default value is 0.0. This value is ignored if
		/// UseValueAsOffset is true and a clip function is defined.
		/// </summary>
		// Token: 0x06016A2D RID: 92717 RVA: 0x001FD72B File Offset: 0x001FB92B
		public virtual void SetValue(double _arg)
		{
			vtkClipDataSet.vtkClipDataSet_SetValue_40(base.GetCppThis(), _arg);
		}

		// Token: 0x06016A2E RID: 92718
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_StableClipNonLinearOff_41(HandleRef pThis);

		/// <summary>
		/// Setter/Getter for stable clipping non-linear cells (default value is true)
		/// </summary>
		// Token: 0x06016A2F RID: 92719 RVA: 0x001FD73B File Offset: 0x001FB93B
		public virtual void StableClipNonLinearOff()
		{
			vtkClipDataSet.vtkClipDataSet_StableClipNonLinearOff_41(base.GetCppThis());
		}

		// Token: 0x06016A30 RID: 92720
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_StableClipNonLinearOn_42(HandleRef pThis);

		/// <summary>
		/// Setter/Getter for stable clipping non-linear cells (default value is true)
		/// </summary>
		// Token: 0x06016A31 RID: 92721 RVA: 0x001FD74A File Offset: 0x001FB94A
		public virtual void StableClipNonLinearOn()
		{
			vtkClipDataSet.vtkClipDataSet_StableClipNonLinearOn_42(base.GetCppThis());
		}

		// Token: 0x06016A32 RID: 92722
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_UseValueAsOffsetOff_43(HandleRef pThis);

		/// <summary>
		/// If UseValueAsOffset is true, Value is used as an offset parameter to
		/// the implicit function. Otherwise, Value is used only when clipping
		/// using a scalar array. Default is true.
		/// </summary>
		// Token: 0x06016A33 RID: 92723 RVA: 0x001FD759 File Offset: 0x001FB959
		public virtual void UseValueAsOffsetOff()
		{
			vtkClipDataSet.vtkClipDataSet_UseValueAsOffsetOff_43(base.GetCppThis());
		}

		// Token: 0x06016A34 RID: 92724
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipDataSet_UseValueAsOffsetOn_44(HandleRef pThis);

		/// <summary>
		/// If UseValueAsOffset is true, Value is used as an offset parameter to
		/// the implicit function. Otherwise, Value is used only when clipping
		/// using a scalar array. Default is true.
		/// </summary>
		// Token: 0x06016A35 RID: 92725 RVA: 0x001FD768 File Offset: 0x001FB968
		public virtual void UseValueAsOffsetOn()
		{
			vtkClipDataSet.vtkClipDataSet_UseValueAsOffsetOn_44(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001967 RID: 6503
		public new const string MRFullTypeName = "Kitware.VTK.vtkClipDataSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001968 RID: 6504
		public new static readonly string MRClassNameKey = "class vtkClipDataSet";
	}
}
