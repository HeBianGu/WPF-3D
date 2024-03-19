using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGradientFilter
	/// </summary>
	/// <remarks>
	///    A general filter for gradient estimation.
	///
	///
	/// This filter estimates the gradient of a field in a data set.  The gradient
	/// calculation is dependent on the input dataset type.  The created gradient
	/// array is of the same type as the array it is calculated from (e.g. point
	/// data or cell data) but the data type will be either float or double.  At
	/// the boundary the gradient does not use central differencing.  The output
	/// gradient array has 3*number of components of the input data array.  The
	/// ordering for the output gradient tuple will be {du/dx, du/dy, du/dz,
	/// dv/dx, dv/dy, dv/dz, dw/dx, dw/dy, dw/dz} for an input array {u, v,
	/// w}. There are also the options to additionally compute the vorticity and Q
	/// criterion of a vector field.  Unstructured grids and polydata can have
	/// cells of different dimensions.  To handle different use cases in this
	/// situation, the user can specify which cells contribute to the
	/// computation. The options for this are All (default), Patch and
	/// DataSetMax. Patch uses only the highest dimension cells attached to a
	/// point. DataSetMax uses the highest cell dimension in the entire data
	/// set. For Patch or DataSetMax it is possible that some values will not be
	/// computed. The ReplacementValueOption specifies what to use for these
	/// values.
	///
	/// </remarks>
	// Token: 0x020008A0 RID: 2208
	public class vtkGradientFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016EB1 RID: 93873 RVA: 0x002035DF File Offset: 0x002017DF
		static vtkGradientFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGradientFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGradientFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016EB2 RID: 93874 RVA: 0x00203607 File Offset: 0x00201807
		public vtkGradientFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016EB3 RID: 93875
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGradientFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016EB4 RID: 93876 RVA: 0x00203618 File Offset: 0x00201818
		public new static vtkGradientFilter New()
		{
			vtkGradientFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGradientFilter.vtkGradientFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGradientFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016EB5 RID: 93877 RVA: 0x0020366C File Offset: 0x0020186C
		public vtkGradientFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGradientFilter.vtkGradientFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016EB6 RID: 93878 RVA: 0x002036B0 File Offset: 0x002018B0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016EB7 RID: 93879
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_ComputeDivergenceOff_01(HandleRef pThis);

		/// <summary>
		/// Add divergence to the output field data.  The name of the array
		/// will be DivergenceArrayName and will be the same type as the input
		/// array.  The input array must have 3 components in order to
		/// compute this. The default is off.
		/// </summary>
		// Token: 0x06016EB8 RID: 93880 RVA: 0x002036BB File Offset: 0x002018BB
		public virtual void ComputeDivergenceOff()
		{
			vtkGradientFilter.vtkGradientFilter_ComputeDivergenceOff_01(base.GetCppThis());
		}

		// Token: 0x06016EB9 RID: 93881
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_ComputeDivergenceOn_02(HandleRef pThis);

		/// <summary>
		/// Add divergence to the output field data.  The name of the array
		/// will be DivergenceArrayName and will be the same type as the input
		/// array.  The input array must have 3 components in order to
		/// compute this. The default is off.
		/// </summary>
		// Token: 0x06016EBA RID: 93882 RVA: 0x002036CA File Offset: 0x002018CA
		public virtual void ComputeDivergenceOn()
		{
			vtkGradientFilter.vtkGradientFilter_ComputeDivergenceOn_02(base.GetCppThis());
		}

		// Token: 0x06016EBB RID: 93883
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_ComputeGradientOff_03(HandleRef pThis);

		/// <summary>
		/// Add the gradient to the output field data.  The name of the array
		/// will be ResultArrayName and will be the same type as the input
		/// array. The default is on.
		/// </summary>
		// Token: 0x06016EBC RID: 93884 RVA: 0x002036D9 File Offset: 0x002018D9
		public virtual void ComputeGradientOff()
		{
			vtkGradientFilter.vtkGradientFilter_ComputeGradientOff_03(base.GetCppThis());
		}

		// Token: 0x06016EBD RID: 93885
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_ComputeGradientOn_04(HandleRef pThis);

		/// <summary>
		/// Add the gradient to the output field data.  The name of the array
		/// will be ResultArrayName and will be the same type as the input
		/// array. The default is on.
		/// </summary>
		// Token: 0x06016EBE RID: 93886 RVA: 0x002036E8 File Offset: 0x002018E8
		public virtual void ComputeGradientOn()
		{
			vtkGradientFilter.vtkGradientFilter_ComputeGradientOn_04(base.GetCppThis());
		}

		// Token: 0x06016EBF RID: 93887
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_ComputeQCriterionOff_05(HandleRef pThis);

		/// <summary>
		/// Add Q-criterion to the output field data.  The name of the array
		/// will be QCriterionArrayName and will be the same type as the input
		/// array.  The input array must have 3 components in order to
		/// compute this.  Note that Q-citerion is a balance of the rate
		/// of vorticity and the rate of strain. The default is off.
		/// </summary>
		// Token: 0x06016EC0 RID: 93888 RVA: 0x002036F7 File Offset: 0x002018F7
		public virtual void ComputeQCriterionOff()
		{
			vtkGradientFilter.vtkGradientFilter_ComputeQCriterionOff_05(base.GetCppThis());
		}

		// Token: 0x06016EC1 RID: 93889
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_ComputeQCriterionOn_06(HandleRef pThis);

		/// <summary>
		/// Add Q-criterion to the output field data.  The name of the array
		/// will be QCriterionArrayName and will be the same type as the input
		/// array.  The input array must have 3 components in order to
		/// compute this.  Note that Q-citerion is a balance of the rate
		/// of vorticity and the rate of strain. The default is off.
		/// </summary>
		// Token: 0x06016EC2 RID: 93890 RVA: 0x00203706 File Offset: 0x00201906
		public virtual void ComputeQCriterionOn()
		{
			vtkGradientFilter.vtkGradientFilter_ComputeQCriterionOn_06(base.GetCppThis());
		}

		// Token: 0x06016EC3 RID: 93891
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_ComputeVorticityOff_07(HandleRef pThis);

		/// <summary>
		/// Add voriticity/curl to the output field data.  The name of the array
		/// will be VorticityArrayName and will be the same type as the input
		/// array.  The input array must have 3 components in order to
		/// compute this. The default is off.
		/// </summary>
		// Token: 0x06016EC4 RID: 93892 RVA: 0x00203715 File Offset: 0x00201915
		public virtual void ComputeVorticityOff()
		{
			vtkGradientFilter.vtkGradientFilter_ComputeVorticityOff_07(base.GetCppThis());
		}

		// Token: 0x06016EC5 RID: 93893
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_ComputeVorticityOn_08(HandleRef pThis);

		/// <summary>
		/// Add voriticity/curl to the output field data.  The name of the array
		/// will be VorticityArrayName and will be the same type as the input
		/// array.  The input array must have 3 components in order to
		/// compute this. The default is off.
		/// </summary>
		// Token: 0x06016EC6 RID: 93894 RVA: 0x00203724 File Offset: 0x00201924
		public virtual void ComputeVorticityOn()
		{
			vtkGradientFilter.vtkGradientFilter_ComputeVorticityOn_08(base.GetCppThis());
		}

		// Token: 0x06016EC7 RID: 93895
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_FasterApproximationOff_09(HandleRef pThis);

		/// <summary>
		/// When this flag is on (default is off), the gradient filter will provide a
		/// less accurate (but close) algorithm that performs fewer derivative
		/// calculations (and is therefore faster).  The error contains some smoothing
		/// of the output data and some possible errors on the boundary.  This
		/// parameter has no effect when performing the gradient of cell data.
		/// This only applies if the input grid is a vtkUnstructuredGrid or a
		/// vtkPolyData, and when point gradients are computed.
		/// </summary>
		// Token: 0x06016EC8 RID: 93896 RVA: 0x00203733 File Offset: 0x00201933
		public virtual void FasterApproximationOff()
		{
			vtkGradientFilter.vtkGradientFilter_FasterApproximationOff_09(base.GetCppThis());
		}

		// Token: 0x06016EC9 RID: 93897
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_FasterApproximationOn_10(HandleRef pThis);

		/// <summary>
		/// When this flag is on (default is off), the gradient filter will provide a
		/// less accurate (but close) algorithm that performs fewer derivative
		/// calculations (and is therefore faster).  The error contains some smoothing
		/// of the output data and some possible errors on the boundary.  This
		/// parameter has no effect when performing the gradient of cell data.
		/// This only applies if the input grid is a vtkUnstructuredGrid or a
		/// vtkPolyData, and when point gradients are computed.
		/// </summary>
		// Token: 0x06016ECA RID: 93898 RVA: 0x00203742 File Offset: 0x00201942
		public virtual void FasterApproximationOn()
		{
			vtkGradientFilter.vtkGradientFilter_FasterApproximationOn_10(base.GetCppThis());
		}

		// Token: 0x06016ECB RID: 93899
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGradientFilter_GetComputeDivergence_11(HandleRef pThis);

		/// <summary>
		/// Add divergence to the output field data.  The name of the array
		/// will be DivergenceArrayName and will be the same type as the input
		/// array.  The input array must have 3 components in order to
		/// compute this. The default is off.
		/// </summary>
		// Token: 0x06016ECC RID: 93900 RVA: 0x00203754 File Offset: 0x00201954
		public virtual int GetComputeDivergence()
		{
			return vtkGradientFilter.vtkGradientFilter_GetComputeDivergence_11(base.GetCppThis());
		}

		// Token: 0x06016ECD RID: 93901
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGradientFilter_GetComputeGradient_12(HandleRef pThis);

		/// <summary>
		/// Add the gradient to the output field data.  The name of the array
		/// will be ResultArrayName and will be the same type as the input
		/// array. The default is on.
		/// </summary>
		// Token: 0x06016ECE RID: 93902 RVA: 0x00203774 File Offset: 0x00201974
		public virtual int GetComputeGradient()
		{
			return vtkGradientFilter.vtkGradientFilter_GetComputeGradient_12(base.GetCppThis());
		}

		// Token: 0x06016ECF RID: 93903
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGradientFilter_GetComputeQCriterion_13(HandleRef pThis);

		/// <summary>
		/// Add Q-criterion to the output field data.  The name of the array
		/// will be QCriterionArrayName and will be the same type as the input
		/// array.  The input array must have 3 components in order to
		/// compute this.  Note that Q-citerion is a balance of the rate
		/// of vorticity and the rate of strain. The default is off.
		/// </summary>
		// Token: 0x06016ED0 RID: 93904 RVA: 0x00203794 File Offset: 0x00201994
		public virtual int GetComputeQCriterion()
		{
			return vtkGradientFilter.vtkGradientFilter_GetComputeQCriterion_13(base.GetCppThis());
		}

		// Token: 0x06016ED1 RID: 93905
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGradientFilter_GetComputeVorticity_14(HandleRef pThis);

		/// <summary>
		/// Add voriticity/curl to the output field data.  The name of the array
		/// will be VorticityArrayName and will be the same type as the input
		/// array.  The input array must have 3 components in order to
		/// compute this. The default is off.
		/// </summary>
		// Token: 0x06016ED2 RID: 93906 RVA: 0x002037B4 File Offset: 0x002019B4
		public virtual int GetComputeVorticity()
		{
			return vtkGradientFilter.vtkGradientFilter_GetComputeVorticity_14(base.GetCppThis());
		}

		// Token: 0x06016ED3 RID: 93907
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGradientFilter_GetContributingCellOption_15(HandleRef pThis);

		/// <summary>
		/// Option to specify what cells to include in the gradient computation.
		/// Options are all cells (All, Patch and DataSetMax). The default is All.
		/// </summary>
		// Token: 0x06016ED4 RID: 93908 RVA: 0x002037D4 File Offset: 0x002019D4
		public virtual int GetContributingCellOption()
		{
			return vtkGradientFilter.vtkGradientFilter_GetContributingCellOption_15(base.GetCppThis());
		}

		// Token: 0x06016ED5 RID: 93909
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGradientFilter_GetContributingCellOptionMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Option to specify what cells to include in the gradient computation.
		/// Options are all cells (All, Patch and DataSetMax). The default is All.
		/// </summary>
		// Token: 0x06016ED6 RID: 93910 RVA: 0x002037F4 File Offset: 0x002019F4
		public virtual int GetContributingCellOptionMaxValue()
		{
			return vtkGradientFilter.vtkGradientFilter_GetContributingCellOptionMaxValue_16(base.GetCppThis());
		}

		// Token: 0x06016ED7 RID: 93911
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGradientFilter_GetContributingCellOptionMinValue_17(HandleRef pThis);

		/// <summary>
		/// Option to specify what cells to include in the gradient computation.
		/// Options are all cells (All, Patch and DataSetMax). The default is All.
		/// </summary>
		// Token: 0x06016ED8 RID: 93912 RVA: 0x00203814 File Offset: 0x00201A14
		public virtual int GetContributingCellOptionMinValue()
		{
			return vtkGradientFilter.vtkGradientFilter_GetContributingCellOptionMinValue_17(base.GetCppThis());
		}

		// Token: 0x06016ED9 RID: 93913
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGradientFilter_GetDivergenceArrayName_18(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the divergence array to create. This is only
		/// used if ComputeDivergence is non-zero. If nullptr (the
		/// default) then the output array will be named "Divergence".
		/// </summary>
		// Token: 0x06016EDA RID: 93914 RVA: 0x00203834 File Offset: 0x00201A34
		public virtual string GetDivergenceArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGradientFilter.vtkGradientFilter_GetDivergenceArrayName_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06016EDB RID: 93915
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGradientFilter_GetFasterApproximation_19(HandleRef pThis);

		/// <summary>
		/// When this flag is on (default is off), the gradient filter will provide a
		/// less accurate (but close) algorithm that performs fewer derivative
		/// calculations (and is therefore faster).  The error contains some smoothing
		/// of the output data and some possible errors on the boundary.  This
		/// parameter has no effect when performing the gradient of cell data.
		/// This only applies if the input grid is a vtkUnstructuredGrid or a
		/// vtkPolyData, and when point gradients are computed.
		/// </summary>
		// Token: 0x06016EDC RID: 93916 RVA: 0x00203870 File Offset: 0x00201A70
		public virtual int GetFasterApproximation()
		{
			return vtkGradientFilter.vtkGradientFilter_GetFasterApproximation_19(base.GetCppThis());
		}

		// Token: 0x06016EDD RID: 93917
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGradientFilter_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016EDE RID: 93918 RVA: 0x00203890 File Offset: 0x00201A90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGradientFilter.vtkGradientFilter_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x06016EDF RID: 93919
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGradientFilter_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016EE0 RID: 93920 RVA: 0x002038B0 File Offset: 0x00201AB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGradientFilter.vtkGradientFilter_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x06016EE1 RID: 93921
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGradientFilter_GetQCriterionArrayName_22(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the Q criterion array to create. This is only
		/// used if ComputeQCriterion is non-zero. If nullptr (the
		/// default) then the output array will be named "Q-criterion".
		/// </summary>
		// Token: 0x06016EE2 RID: 93922 RVA: 0x002038CC File Offset: 0x00201ACC
		public virtual string GetQCriterionArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGradientFilter.vtkGradientFilter_GetQCriterionArrayName_22(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06016EE3 RID: 93923
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGradientFilter_GetReplacementValueOption_23(HandleRef pThis);

		/// <summary>
		/// Option to specify what replacement value or entities that don't have any gradient computed
		/// over them based on the ContributingCellOption. Options are (Zero, NaN, DataTypeMin,
		/// DataTypeMax). The default is Zero.
		/// </summary>
		// Token: 0x06016EE4 RID: 93924 RVA: 0x00203908 File Offset: 0x00201B08
		public virtual int GetReplacementValueOption()
		{
			return vtkGradientFilter.vtkGradientFilter_GetReplacementValueOption_23(base.GetCppThis());
		}

		// Token: 0x06016EE5 RID: 93925
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGradientFilter_GetReplacementValueOptionMaxValue_24(HandleRef pThis);

		/// <summary>
		/// Option to specify what replacement value or entities that don't have any gradient computed
		/// over them based on the ContributingCellOption. Options are (Zero, NaN, DataTypeMin,
		/// DataTypeMax). The default is Zero.
		/// </summary>
		// Token: 0x06016EE6 RID: 93926 RVA: 0x00203928 File Offset: 0x00201B28
		public virtual int GetReplacementValueOptionMaxValue()
		{
			return vtkGradientFilter.vtkGradientFilter_GetReplacementValueOptionMaxValue_24(base.GetCppThis());
		}

		// Token: 0x06016EE7 RID: 93927
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGradientFilter_GetReplacementValueOptionMinValue_25(HandleRef pThis);

		/// <summary>
		/// Option to specify what replacement value or entities that don't have any gradient computed
		/// over them based on the ContributingCellOption. Options are (Zero, NaN, DataTypeMin,
		/// DataTypeMax). The default is Zero.
		/// </summary>
		// Token: 0x06016EE8 RID: 93928 RVA: 0x00203948 File Offset: 0x00201B48
		public virtual int GetReplacementValueOptionMinValue()
		{
			return vtkGradientFilter.vtkGradientFilter_GetReplacementValueOptionMinValue_25(base.GetCppThis());
		}

		// Token: 0x06016EE9 RID: 93929
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGradientFilter_GetResultArrayName_26(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the gradient array to create.  This is only
		/// used if ComputeGradient is non-zero. If nullptr (the
		/// default) then the output array will be named "Gradients".
		/// </summary>
		// Token: 0x06016EEA RID: 93930 RVA: 0x00203968 File Offset: 0x00201B68
		public virtual string GetResultArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGradientFilter.vtkGradientFilter_GetResultArrayName_26(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06016EEB RID: 93931
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGradientFilter_GetVorticityArrayName_27(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the vorticity array to create. This is only
		/// used if ComputeVorticity is non-zero. If nullptr (the
		/// default) then the output array will be named "Vorticity".
		/// </summary>
		// Token: 0x06016EEC RID: 93932 RVA: 0x002039A4 File Offset: 0x00201BA4
		public virtual string GetVorticityArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGradientFilter.vtkGradientFilter_GetVorticityArrayName_27(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06016EED RID: 93933
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGradientFilter_IsA_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016EEE RID: 93934 RVA: 0x002039E0 File Offset: 0x00201BE0
		public override int IsA(string type)
		{
			return vtkGradientFilter.vtkGradientFilter_IsA_28(base.GetCppThis(), type);
		}

		// Token: 0x06016EEF RID: 93935
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGradientFilter_IsTypeOf_29([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016EF0 RID: 93936 RVA: 0x00203A00 File Offset: 0x00201C00
		public new static int IsTypeOf(string type)
		{
			return vtkGradientFilter.vtkGradientFilter_IsTypeOf_29(type);
		}

		// Token: 0x06016EF1 RID: 93937
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGradientFilter_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016EF2 RID: 93938 RVA: 0x00203A1C File Offset: 0x00201C1C
		public new vtkGradientFilter NewInstance()
		{
			vtkGradientFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGradientFilter.vtkGradientFilter_NewInstance_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGradientFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016EF3 RID: 93939
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGradientFilter_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016EF4 RID: 93940 RVA: 0x00203A78 File Offset: 0x00201C78
		public new static vtkGradientFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGradientFilter vtkGradientFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGradientFilter.vtkGradientFilter_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGradientFilter = (vtkGradientFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGradientFilter.Register(null);
				}
			}
			return vtkGradientFilter;
		}

		// Token: 0x06016EF5 RID: 93941
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_SetComputeDivergence_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Add divergence to the output field data.  The name of the array
		/// will be DivergenceArrayName and will be the same type as the input
		/// array.  The input array must have 3 components in order to
		/// compute this. The default is off.
		/// </summary>
		// Token: 0x06016EF6 RID: 93942 RVA: 0x00203AF7 File Offset: 0x00201CF7
		public virtual void SetComputeDivergence(int _arg)
		{
			vtkGradientFilter.vtkGradientFilter_SetComputeDivergence_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06016EF7 RID: 93943
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_SetComputeGradient_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Add the gradient to the output field data.  The name of the array
		/// will be ResultArrayName and will be the same type as the input
		/// array. The default is on.
		/// </summary>
		// Token: 0x06016EF8 RID: 93944 RVA: 0x00203B07 File Offset: 0x00201D07
		public virtual void SetComputeGradient(int _arg)
		{
			vtkGradientFilter.vtkGradientFilter_SetComputeGradient_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06016EF9 RID: 93945
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_SetComputeQCriterion_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Add Q-criterion to the output field data.  The name of the array
		/// will be QCriterionArrayName and will be the same type as the input
		/// array.  The input array must have 3 components in order to
		/// compute this.  Note that Q-citerion is a balance of the rate
		/// of vorticity and the rate of strain. The default is off.
		/// </summary>
		// Token: 0x06016EFA RID: 93946 RVA: 0x00203B17 File Offset: 0x00201D17
		public virtual void SetComputeQCriterion(int _arg)
		{
			vtkGradientFilter.vtkGradientFilter_SetComputeQCriterion_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06016EFB RID: 93947
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_SetComputeVorticity_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Add voriticity/curl to the output field data.  The name of the array
		/// will be VorticityArrayName and will be the same type as the input
		/// array.  The input array must have 3 components in order to
		/// compute this. The default is off.
		/// </summary>
		// Token: 0x06016EFC RID: 93948 RVA: 0x00203B27 File Offset: 0x00201D27
		public virtual void SetComputeVorticity(int _arg)
		{
			vtkGradientFilter.vtkGradientFilter_SetComputeVorticity_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06016EFD RID: 93949
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_SetContributingCellOption_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Option to specify what cells to include in the gradient computation.
		/// Options are all cells (All, Patch and DataSetMax). The default is All.
		/// </summary>
		// Token: 0x06016EFE RID: 93950 RVA: 0x00203B37 File Offset: 0x00201D37
		public virtual void SetContributingCellOption(int _arg)
		{
			vtkGradientFilter.vtkGradientFilter_SetContributingCellOption_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06016EFF RID: 93951
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_SetDivergenceArrayName_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the divergence array to create. This is only
		/// used if ComputeDivergence is non-zero. If nullptr (the
		/// default) then the output array will be named "Divergence".
		/// </summary>
		// Token: 0x06016F00 RID: 93952 RVA: 0x00203B47 File Offset: 0x00201D47
		public virtual void SetDivergenceArrayName(string _arg)
		{
			vtkGradientFilter.vtkGradientFilter_SetDivergenceArrayName_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06016F01 RID: 93953
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_SetFasterApproximation_39(HandleRef pThis, int _arg);

		/// <summary>
		/// When this flag is on (default is off), the gradient filter will provide a
		/// less accurate (but close) algorithm that performs fewer derivative
		/// calculations (and is therefore faster).  The error contains some smoothing
		/// of the output data and some possible errors on the boundary.  This
		/// parameter has no effect when performing the gradient of cell data.
		/// This only applies if the input grid is a vtkUnstructuredGrid or a
		/// vtkPolyData, and when point gradients are computed.
		/// </summary>
		// Token: 0x06016F02 RID: 93954 RVA: 0x00203B57 File Offset: 0x00201D57
		public virtual void SetFasterApproximation(int _arg)
		{
			vtkGradientFilter.vtkGradientFilter_SetFasterApproximation_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06016F03 RID: 93955
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_SetInputScalars_40(HandleRef pThis, int fieldAssociation, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// These are basically a convenience method that calls SetInputArrayToProcess
		/// to set the array used as the input scalars.  The fieldAssociation comes
		/// from the vtkDataObject::FieldAssociations enum.  The fieldAttributeType
		/// comes from the vtkDataSetAttributes::AttributeTypes enum.
		/// </summary>
		// Token: 0x06016F04 RID: 93956 RVA: 0x00203B67 File Offset: 0x00201D67
		public virtual void SetInputScalars(int fieldAssociation, string name)
		{
			vtkGradientFilter.vtkGradientFilter_SetInputScalars_40(base.GetCppThis(), fieldAssociation, name);
		}

		// Token: 0x06016F05 RID: 93957
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_SetInputScalars_41(HandleRef pThis, int fieldAssociation, int fieldAttributeType);

		/// <summary>
		/// These are basically a convenience method that calls SetInputArrayToProcess
		/// to set the array used as the input scalars.  The fieldAssociation comes
		/// from the vtkDataObject::FieldAssociations enum.  The fieldAttributeType
		/// comes from the vtkDataSetAttributes::AttributeTypes enum.
		/// </summary>
		// Token: 0x06016F06 RID: 93958 RVA: 0x00203B78 File Offset: 0x00201D78
		public virtual void SetInputScalars(int fieldAssociation, int fieldAttributeType)
		{
			vtkGradientFilter.vtkGradientFilter_SetInputScalars_41(base.GetCppThis(), fieldAssociation, fieldAttributeType);
		}

		// Token: 0x06016F07 RID: 93959
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_SetQCriterionArrayName_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the Q criterion array to create. This is only
		/// used if ComputeQCriterion is non-zero. If nullptr (the
		/// default) then the output array will be named "Q-criterion".
		/// </summary>
		// Token: 0x06016F08 RID: 93960 RVA: 0x00203B89 File Offset: 0x00201D89
		public virtual void SetQCriterionArrayName(string _arg)
		{
			vtkGradientFilter.vtkGradientFilter_SetQCriterionArrayName_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06016F09 RID: 93961
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_SetReplacementValueOption_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Option to specify what replacement value or entities that don't have any gradient computed
		/// over them based on the ContributingCellOption. Options are (Zero, NaN, DataTypeMin,
		/// DataTypeMax). The default is Zero.
		/// </summary>
		// Token: 0x06016F0A RID: 93962 RVA: 0x00203B99 File Offset: 0x00201D99
		public virtual void SetReplacementValueOption(int _arg)
		{
			vtkGradientFilter.vtkGradientFilter_SetReplacementValueOption_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06016F0B RID: 93963
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_SetResultArrayName_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the gradient array to create.  This is only
		/// used if ComputeGradient is non-zero. If nullptr (the
		/// default) then the output array will be named "Gradients".
		/// </summary>
		// Token: 0x06016F0C RID: 93964 RVA: 0x00203BA9 File Offset: 0x00201DA9
		public virtual void SetResultArrayName(string _arg)
		{
			vtkGradientFilter.vtkGradientFilter_SetResultArrayName_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06016F0D RID: 93965
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGradientFilter_SetVorticityArrayName_45(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the vorticity array to create. This is only
		/// used if ComputeVorticity is non-zero. If nullptr (the
		/// default) then the output array will be named "Vorticity".
		/// </summary>
		// Token: 0x06016F0E RID: 93966 RVA: 0x00203BB9 File Offset: 0x00201DB9
		public virtual void SetVorticityArrayName(string _arg)
		{
			vtkGradientFilter.vtkGradientFilter_SetVorticityArrayName_45(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019A1 RID: 6561
		public new const string MRFullTypeName = "Kitware.VTK.vtkGradientFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019A2 RID: 6562
		public new static readonly string MRClassNameKey = "class vtkGradientFilter";

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x020008A1 RID: 2209
		public enum ContributingCellEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040019A4 RID: 6564
			All,
			/// <summary>enum member</summary>
			// Token: 0x040019A5 RID: 6565
			DataSetMax = 2,
			/// <summary>enum member</summary>
			// Token: 0x040019A6 RID: 6566
			Patch = 1
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x020008A2 RID: 2210
		public enum ReplacementValueEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040019A8 RID: 6568
			DataTypeMax = 3,
			/// <summary>enum member</summary>
			// Token: 0x040019A9 RID: 6569
			DataTypeMin = 2,
			/// <summary>enum member</summary>
			// Token: 0x040019AA RID: 6570
			NaN = 1,
			/// <summary>enum member</summary>
			// Token: 0x040019AB RID: 6571
			Zero = 0
		}
	}
}
