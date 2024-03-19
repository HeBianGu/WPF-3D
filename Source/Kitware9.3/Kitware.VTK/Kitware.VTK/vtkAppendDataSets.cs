using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAppendDataSets
	/// </summary>
	/// <remarks>
	///    Appends one or more datasets together into a single output vtkPointSet.
	///
	/// vtkAppendDataSets is a filter that appends one of more datasets into a single output
	/// point set. The type of the output is set with the OutputDataSetType option. Only inputs
	/// that can be converted to the selected output dataset type are appended to the output.
	/// By default, the output is vtkUnstructuredGrid, and all input types can be appended to it.
	/// If the OutputDataSetType is set to produce vtkPolyData, then only datasets that can be
	/// converted to vtkPolyData (i.e., vtkPolyData) are appended to the output.
	///
	/// All cells are extracted and appended, but point and cell attributes (i.e., scalars,
	/// vectors, normals, field data, etc.) are extracted and appended only if all datasets
	/// have the same point and/or cell attributes available. (For example, if one dataset
	/// has scalars but another does not, scalars will not be appended.)
	///
	/// Points can be merged if MergePoints is set to true. In this case, points are
	/// really merged if there are no ghost cells and no global point ids, or if
	/// there are global point ids. In the case of the presence of global point ids,
	/// the filter exclusively relies on those ids, not checking if points are
	/// coincident. It assumes that the global ids were properly set. In the case of
	/// the absence of global ids, points within Tolerance are merged.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAppendFilter vtkAppendPolyData
	/// </seealso>
	// Token: 0x02000938 RID: 2360
	public class vtkAppendDataSets : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060186E4 RID: 100068 RVA: 0x00222CCF File Offset: 0x00220ECF
		static vtkAppendDataSets()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAppendDataSets.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendDataSets"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060186E5 RID: 100069 RVA: 0x00222CF7 File Offset: 0x00220EF7
		public vtkAppendDataSets(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060186E6 RID: 100070
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendDataSets_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186E7 RID: 100071 RVA: 0x00222D08 File Offset: 0x00220F08
		public new static vtkAppendDataSets New()
		{
			vtkAppendDataSets result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendDataSets.vtkAppendDataSets_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendDataSets)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186E8 RID: 100072 RVA: 0x00222D5C File Offset: 0x00220F5C
		public vtkAppendDataSets() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAppendDataSets.vtkAppendDataSets_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060186E9 RID: 100073 RVA: 0x00222DA0 File Offset: 0x00220FA0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060186EA RID: 100074
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAppendDataSets_GetMergePoints_01(HandleRef pThis);

		/// <summary>
		/// Get/Set if the filter should merge coincidental points
		/// Note: The filter will only merge points if the ghost cell array doesn't exist
		/// Defaults to Off
		/// </summary>
		// Token: 0x060186EB RID: 100075 RVA: 0x00222DAC File Offset: 0x00220FAC
		public virtual bool GetMergePoints()
		{
			return vtkAppendDataSets.vtkAppendDataSets_GetMergePoints_01(base.GetCppThis()) != 0;
		}

		// Token: 0x060186EC RID: 100076
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAppendDataSets_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186ED RID: 100077 RVA: 0x00222DD4 File Offset: 0x00220FD4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAppendDataSets.vtkAppendDataSets_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060186EE RID: 100078
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAppendDataSets_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186EF RID: 100079 RVA: 0x00222DF4 File Offset: 0x00220FF4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAppendDataSets.vtkAppendDataSets_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060186F0 RID: 100080
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendDataSets_GetOutputDataSetType_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the output type produced by this filter. Only input datasets compatible with the
		/// output type will be merged in the output. For example, if the output type is vtkPolyData, then
		/// blocks of type vtkImageData, vtkStructuredGrid, etc. will not be merged - only vtkPolyData
		/// can be merged into a vtkPolyData. On the other hand, if the output type is
		/// vtkUnstructuredGrid, then blocks of almost any type will be merged in the output.
		/// Valid values are VTK_POLY_DATA and VTK_UNSTRUCTURED_GRID defined in vtkType.h.
		/// Defaults to VTK_UNSTRUCTURED_GRID.
		/// </summary>
		// Token: 0x060186F1 RID: 100081 RVA: 0x00222E10 File Offset: 0x00221010
		public virtual int GetOutputDataSetType()
		{
			return vtkAppendDataSets.vtkAppendDataSets_GetOutputDataSetType_04(base.GetCppThis());
		}

		// Token: 0x060186F2 RID: 100082
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendDataSets_GetOutputPointsPrecision_05(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x060186F3 RID: 100083 RVA: 0x00222E30 File Offset: 0x00221030
		public virtual int GetOutputPointsPrecision()
		{
			return vtkAppendDataSets.vtkAppendDataSets_GetOutputPointsPrecision_05(base.GetCppThis());
		}

		// Token: 0x060186F4 RID: 100084
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendDataSets_GetOutputPointsPrecisionMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x060186F5 RID: 100085 RVA: 0x00222E50 File Offset: 0x00221050
		public virtual int GetOutputPointsPrecisionMaxValue()
		{
			return vtkAppendDataSets.vtkAppendDataSets_GetOutputPointsPrecisionMaxValue_06(base.GetCppThis());
		}

		// Token: 0x060186F6 RID: 100086
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendDataSets_GetOutputPointsPrecisionMinValue_07(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x060186F7 RID: 100087 RVA: 0x00222E70 File Offset: 0x00221070
		public virtual int GetOutputPointsPrecisionMinValue()
		{
			return vtkAppendDataSets.vtkAppendDataSets_GetOutputPointsPrecisionMinValue_07(base.GetCppThis());
		}

		// Token: 0x060186F8 RID: 100088
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAppendDataSets_GetTolerance_08(HandleRef pThis);

		/// <summary>
		/// Get/Set the tolerance to use to find coincident points when `MergePoints`
		/// is `true`. Default is 0.0.
		///
		/// This is simply passed on to the internal vtkLocator used to merge points.
		/// @sa `vtkLocator::SetTolerance`.
		/// </summary>
		// Token: 0x060186F9 RID: 100089 RVA: 0x00222E90 File Offset: 0x00221090
		public virtual double GetTolerance()
		{
			return vtkAppendDataSets.vtkAppendDataSets_GetTolerance_08(base.GetCppThis());
		}

		// Token: 0x060186FA RID: 100090
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAppendDataSets_GetToleranceIsAbsolute_09(HandleRef pThis);

		/// <summary>
		/// Get/Set whether Tolerance is treated as an absolute or relative tolerance.
		/// The default is to treat it as an absolute tolerance. When off, the
		/// tolerance is multiplied by the diagonal of the bounding box of the input.
		/// </summary>
		// Token: 0x060186FB RID: 100091 RVA: 0x00222EB0 File Offset: 0x002210B0
		public virtual bool GetToleranceIsAbsolute()
		{
			return vtkAppendDataSets.vtkAppendDataSets_GetToleranceIsAbsolute_09(base.GetCppThis()) != 0;
		}

		// Token: 0x060186FC RID: 100092
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAppendDataSets_GetToleranceMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the tolerance to use to find coincident points when `MergePoints`
		/// is `true`. Default is 0.0.
		///
		/// This is simply passed on to the internal vtkLocator used to merge points.
		/// @sa `vtkLocator::SetTolerance`.
		/// </summary>
		// Token: 0x060186FD RID: 100093 RVA: 0x00222ED8 File Offset: 0x002210D8
		public virtual double GetToleranceMaxValue()
		{
			return vtkAppendDataSets.vtkAppendDataSets_GetToleranceMaxValue_10(base.GetCppThis());
		}

		// Token: 0x060186FE RID: 100094
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAppendDataSets_GetToleranceMinValue_11(HandleRef pThis);

		/// <summary>
		/// Get/Set the tolerance to use to find coincident points when `MergePoints`
		/// is `true`. Default is 0.0.
		///
		/// This is simply passed on to the internal vtkLocator used to merge points.
		/// @sa `vtkLocator::SetTolerance`.
		/// </summary>
		// Token: 0x060186FF RID: 100095 RVA: 0x00222EF8 File Offset: 0x002210F8
		public virtual double GetToleranceMinValue()
		{
			return vtkAppendDataSets.vtkAppendDataSets_GetToleranceMinValue_11(base.GetCppThis());
		}

		// Token: 0x06018700 RID: 100096
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendDataSets_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018701 RID: 100097 RVA: 0x00222F18 File Offset: 0x00221118
		public override int IsA(string type)
		{
			return vtkAppendDataSets.vtkAppendDataSets_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06018702 RID: 100098
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendDataSets_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018703 RID: 100099 RVA: 0x00222F38 File Offset: 0x00221138
		public new static int IsTypeOf(string type)
		{
			return vtkAppendDataSets.vtkAppendDataSets_IsTypeOf_13(type);
		}

		// Token: 0x06018704 RID: 100100
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendDataSets_MergePointsOff_14(HandleRef pThis);

		/// <summary>
		/// Get/Set if the filter should merge coincidental points
		/// Note: The filter will only merge points if the ghost cell array doesn't exist
		/// Defaults to Off
		/// </summary>
		// Token: 0x06018705 RID: 100101 RVA: 0x00222F52 File Offset: 0x00221152
		public virtual void MergePointsOff()
		{
			vtkAppendDataSets.vtkAppendDataSets_MergePointsOff_14(base.GetCppThis());
		}

		// Token: 0x06018706 RID: 100102
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendDataSets_MergePointsOn_15(HandleRef pThis);

		/// <summary>
		/// Get/Set if the filter should merge coincidental points
		/// Note: The filter will only merge points if the ghost cell array doesn't exist
		/// Defaults to Off
		/// </summary>
		// Token: 0x06018707 RID: 100103 RVA: 0x00222F61 File Offset: 0x00221161
		public virtual void MergePointsOn()
		{
			vtkAppendDataSets.vtkAppendDataSets_MergePointsOn_15(base.GetCppThis());
		}

		// Token: 0x06018708 RID: 100104
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendDataSets_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018709 RID: 100105 RVA: 0x00222F70 File Offset: 0x00221170
		public new vtkAppendDataSets NewInstance()
		{
			vtkAppendDataSets result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendDataSets.vtkAppendDataSets_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendDataSets)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601870A RID: 100106
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendDataSets_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601870B RID: 100107 RVA: 0x00222FCC File Offset: 0x002211CC
		public new static vtkAppendDataSets SafeDownCast(vtkObjectBase o)
		{
			vtkAppendDataSets vtkAppendDataSets = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendDataSets.vtkAppendDataSets_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAppendDataSets = (vtkAppendDataSets)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAppendDataSets.Register(null);
				}
			}
			return vtkAppendDataSets;
		}

		// Token: 0x0601870C RID: 100108
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendDataSets_SetMergePoints_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set if the filter should merge coincidental points
		/// Note: The filter will only merge points if the ghost cell array doesn't exist
		/// Defaults to Off
		/// </summary>
		// Token: 0x0601870D RID: 100109 RVA: 0x0022304B File Offset: 0x0022124B
		public virtual void SetMergePoints(bool _arg)
		{
			vtkAppendDataSets.vtkAppendDataSets_SetMergePoints_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601870E RID: 100110
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendDataSets_SetOutputDataSetType_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the output type produced by this filter. Only input datasets compatible with the
		/// output type will be merged in the output. For example, if the output type is vtkPolyData, then
		/// blocks of type vtkImageData, vtkStructuredGrid, etc. will not be merged - only vtkPolyData
		/// can be merged into a vtkPolyData. On the other hand, if the output type is
		/// vtkUnstructuredGrid, then blocks of almost any type will be merged in the output.
		/// Valid values are VTK_POLY_DATA and VTK_UNSTRUCTURED_GRID defined in vtkType.h.
		/// Defaults to VTK_UNSTRUCTURED_GRID.
		/// </summary>
		// Token: 0x0601870F RID: 100111 RVA: 0x00223063 File Offset: 0x00221263
		public virtual void SetOutputDataSetType(int _arg)
		{
			vtkAppendDataSets.vtkAppendDataSets_SetOutputDataSetType_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06018710 RID: 100112
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendDataSets_SetOutputPointsPrecision_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x06018711 RID: 100113 RVA: 0x00223073 File Offset: 0x00221273
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkAppendDataSets.vtkAppendDataSets_SetOutputPointsPrecision_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06018712 RID: 100114
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendDataSets_SetTolerance_22(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set the tolerance to use to find coincident points when `MergePoints`
		/// is `true`. Default is 0.0.
		///
		/// This is simply passed on to the internal vtkLocator used to merge points.
		/// @sa `vtkLocator::SetTolerance`.
		/// </summary>
		// Token: 0x06018713 RID: 100115 RVA: 0x00223083 File Offset: 0x00221283
		public virtual void SetTolerance(double _arg)
		{
			vtkAppendDataSets.vtkAppendDataSets_SetTolerance_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06018714 RID: 100116
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendDataSets_SetToleranceIsAbsolute_23(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set whether Tolerance is treated as an absolute or relative tolerance.
		/// The default is to treat it as an absolute tolerance. When off, the
		/// tolerance is multiplied by the diagonal of the bounding box of the input.
		/// </summary>
		// Token: 0x06018715 RID: 100117 RVA: 0x00223093 File Offset: 0x00221293
		public virtual void SetToleranceIsAbsolute(bool _arg)
		{
			vtkAppendDataSets.vtkAppendDataSets_SetToleranceIsAbsolute_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06018716 RID: 100118
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendDataSets_ToleranceIsAbsoluteOff_24(HandleRef pThis);

		/// <summary>
		/// Get/Set whether Tolerance is treated as an absolute or relative tolerance.
		/// The default is to treat it as an absolute tolerance. When off, the
		/// tolerance is multiplied by the diagonal of the bounding box of the input.
		/// </summary>
		// Token: 0x06018717 RID: 100119 RVA: 0x002230AB File Offset: 0x002212AB
		public virtual void ToleranceIsAbsoluteOff()
		{
			vtkAppendDataSets.vtkAppendDataSets_ToleranceIsAbsoluteOff_24(base.GetCppThis());
		}

		// Token: 0x06018718 RID: 100120
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendDataSets_ToleranceIsAbsoluteOn_25(HandleRef pThis);

		/// <summary>
		/// Get/Set whether Tolerance is treated as an absolute or relative tolerance.
		/// The default is to treat it as an absolute tolerance. When off, the
		/// tolerance is multiplied by the diagonal of the bounding box of the input.
		/// </summary>
		// Token: 0x06018719 RID: 100121 RVA: 0x002230BA File Offset: 0x002212BA
		public virtual void ToleranceIsAbsoluteOn()
		{
			vtkAppendDataSets.vtkAppendDataSets_ToleranceIsAbsoluteOn_25(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B1A RID: 6938
		public new const string MRFullTypeName = "Kitware.VTK.vtkAppendDataSets";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B1B RID: 6939
		public new static readonly string MRClassNameKey = "class vtkAppendDataSets";
	}
}
