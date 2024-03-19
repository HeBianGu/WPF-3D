using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAppendFilter
	/// </summary>
	/// <remarks>
	///    appends one or more datasets together into a single unstructured grid
	///
	/// vtkAppendFilter is a filter that appends one of more datasets into a single
	/// unstructured grid. All geometry is extracted and appended, but point
	/// attributes (i.e., scalars, vectors, normals, field data, etc.) are extracted
	/// and appended only if all datasets have the point attributes available.
	/// (For example, if one dataset has scalars but another does not, scalars will
	/// not be appended.)
	///
	/// You can decide to merge points that are coincident by setting
	/// `MergePoints`. If this flag is set, points are merged if they are within
	/// `Tolerance` radius. If a point global id array is available (point data named
	/// "GlobalPointIds"), then two points are merged if they share the same point global id,
	/// without checking for coincident point.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAppendPolyData
	/// </seealso>
	// Token: 0x02000939 RID: 2361
	public class vtkAppendFilter : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601871A RID: 100122 RVA: 0x002230C9 File Offset: 0x002212C9
		static vtkAppendFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAppendFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601871B RID: 100123 RVA: 0x002230F1 File Offset: 0x002212F1
		public vtkAppendFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601871C RID: 100124
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601871D RID: 100125 RVA: 0x00223100 File Offset: 0x00221300
		public new static vtkAppendFilter New()
		{
			vtkAppendFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendFilter.vtkAppendFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601871E RID: 100126 RVA: 0x00223154 File Offset: 0x00221354
		public vtkAppendFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAppendFilter.vtkAppendFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601871F RID: 100127 RVA: 0x00223198 File Offset: 0x00221398
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018720 RID: 100128
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendFilter_GetInput_01(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get any input of this filter.
		/// </summary>
		// Token: 0x06018721 RID: 100129 RVA: 0x002231A4 File Offset: 0x002213A4
		public new vtkDataSet GetInput(int idx)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendFilter.vtkAppendFilter_GetInput_01(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06018722 RID: 100130
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendFilter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get any input of this filter.
		/// </summary>
		// Token: 0x06018723 RID: 100131 RVA: 0x00223214 File Offset: 0x00221414
		public new vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendFilter.vtkAppendFilter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06018724 RID: 100132
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendFilter_GetInputList_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns a copy of the input array.  Modifications to this list
		/// will not be reflected in the actual inputs.
		/// </summary>
		// Token: 0x06018725 RID: 100133 RVA: 0x00223284 File Offset: 0x00221484
		public vtkDataSetCollection GetInputList()
		{
			vtkDataSetCollection vtkDataSetCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendFilter.vtkAppendFilter_GetInputList_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetCollection = (vtkDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetCollection.Register(null);
				}
			}
			return vtkDataSetCollection;
		}

		// Token: 0x06018726 RID: 100134
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendFilter_GetMergePoints_04(HandleRef pThis);

		/// <summary>
		/// Get/Set if the filter should merge coincidental points
		/// Note: The filter will only merge points if the ghost cell array doesn't exist
		/// Defaults to Off
		/// </summary>
		// Token: 0x06018727 RID: 100135 RVA: 0x002232F4 File Offset: 0x002214F4
		public virtual int GetMergePoints()
		{
			return vtkAppendFilter.vtkAppendFilter_GetMergePoints_04(base.GetCppThis());
		}

		// Token: 0x06018728 RID: 100136
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAppendFilter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018729 RID: 100137 RVA: 0x00223314 File Offset: 0x00221514
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAppendFilter.vtkAppendFilter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601872A RID: 100138
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAppendFilter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601872B RID: 100139 RVA: 0x00223334 File Offset: 0x00221534
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAppendFilter.vtkAppendFilter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601872C RID: 100140
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendFilter_GetOutputPointsPrecision_07(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x0601872D RID: 100141 RVA: 0x00223350 File Offset: 0x00221550
		public virtual int GetOutputPointsPrecision()
		{
			return vtkAppendFilter.vtkAppendFilter_GetOutputPointsPrecision_07(base.GetCppThis());
		}

		// Token: 0x0601872E RID: 100142
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendFilter_GetOutputPointsPrecisionMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x0601872F RID: 100143 RVA: 0x00223370 File Offset: 0x00221570
		public virtual int GetOutputPointsPrecisionMaxValue()
		{
			return vtkAppendFilter.vtkAppendFilter_GetOutputPointsPrecisionMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06018730 RID: 100144
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendFilter_GetOutputPointsPrecisionMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x06018731 RID: 100145 RVA: 0x00223390 File Offset: 0x00221590
		public virtual int GetOutputPointsPrecisionMinValue()
		{
			return vtkAppendFilter.vtkAppendFilter_GetOutputPointsPrecisionMinValue_09(base.GetCppThis());
		}

		// Token: 0x06018732 RID: 100146
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAppendFilter_GetTolerance_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the tolerance to use to find coincident points when `MergePoints`
		/// is `true`. Default is 0.0.
		///
		/// This is simply passed on to the internal vtkLocator used to merge points.
		/// @sa `vtkLocator::SetTolerance`.
		/// </summary>
		// Token: 0x06018733 RID: 100147 RVA: 0x002233B0 File Offset: 0x002215B0
		public virtual double GetTolerance()
		{
			return vtkAppendFilter.vtkAppendFilter_GetTolerance_10(base.GetCppThis());
		}

		// Token: 0x06018734 RID: 100148
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAppendFilter_GetToleranceIsAbsolute_11(HandleRef pThis);

		/// <summary>
		/// Get/Set whether Tolerance is treated as an absolute or relative tolerance.
		/// The default is to treat it as an absolute tolerance. When off, the
		/// tolerance is multiplied by the diagonal of the bounding box of the input.
		/// </summary>
		// Token: 0x06018735 RID: 100149 RVA: 0x002233D0 File Offset: 0x002215D0
		public virtual bool GetToleranceIsAbsolute()
		{
			return vtkAppendFilter.vtkAppendFilter_GetToleranceIsAbsolute_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06018736 RID: 100150
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAppendFilter_GetToleranceMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Get/Set the tolerance to use to find coincident points when `MergePoints`
		/// is `true`. Default is 0.0.
		///
		/// This is simply passed on to the internal vtkLocator used to merge points.
		/// @sa `vtkLocator::SetTolerance`.
		/// </summary>
		// Token: 0x06018737 RID: 100151 RVA: 0x002233F8 File Offset: 0x002215F8
		public virtual double GetToleranceMaxValue()
		{
			return vtkAppendFilter.vtkAppendFilter_GetToleranceMaxValue_12(base.GetCppThis());
		}

		// Token: 0x06018738 RID: 100152
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAppendFilter_GetToleranceMinValue_13(HandleRef pThis);

		/// <summary>
		/// Get/Set the tolerance to use to find coincident points when `MergePoints`
		/// is `true`. Default is 0.0.
		///
		/// This is simply passed on to the internal vtkLocator used to merge points.
		/// @sa `vtkLocator::SetTolerance`.
		/// </summary>
		// Token: 0x06018739 RID: 100153 RVA: 0x00223418 File Offset: 0x00221618
		public virtual double GetToleranceMinValue()
		{
			return vtkAppendFilter.vtkAppendFilter_GetToleranceMinValue_13(base.GetCppThis());
		}

		// Token: 0x0601873A RID: 100154
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendFilter_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601873B RID: 100155 RVA: 0x00223438 File Offset: 0x00221638
		public override int IsA(string type)
		{
			return vtkAppendFilter.vtkAppendFilter_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0601873C RID: 100156
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendFilter_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601873D RID: 100157 RVA: 0x00223458 File Offset: 0x00221658
		public new static int IsTypeOf(string type)
		{
			return vtkAppendFilter.vtkAppendFilter_IsTypeOf_15(type);
		}

		// Token: 0x0601873E RID: 100158
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendFilter_MergePointsOff_16(HandleRef pThis);

		/// <summary>
		/// Get/Set if the filter should merge coincidental points
		/// Note: The filter will only merge points if the ghost cell array doesn't exist
		/// Defaults to Off
		/// </summary>
		// Token: 0x0601873F RID: 100159 RVA: 0x00223472 File Offset: 0x00221672
		public virtual void MergePointsOff()
		{
			vtkAppendFilter.vtkAppendFilter_MergePointsOff_16(base.GetCppThis());
		}

		// Token: 0x06018740 RID: 100160
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendFilter_MergePointsOn_17(HandleRef pThis);

		/// <summary>
		/// Get/Set if the filter should merge coincidental points
		/// Note: The filter will only merge points if the ghost cell array doesn't exist
		/// Defaults to Off
		/// </summary>
		// Token: 0x06018741 RID: 100161 RVA: 0x00223481 File Offset: 0x00221681
		public virtual void MergePointsOn()
		{
			vtkAppendFilter.vtkAppendFilter_MergePointsOn_17(base.GetCppThis());
		}

		// Token: 0x06018742 RID: 100162
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendFilter_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018743 RID: 100163 RVA: 0x00223490 File Offset: 0x00221690
		public new vtkAppendFilter NewInstance()
		{
			vtkAppendFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendFilter.vtkAppendFilter_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018744 RID: 100164
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendFilter_RemoveInputData_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove a dataset from the list of data to append.
		/// </summary>
		// Token: 0x06018745 RID: 100165 RVA: 0x002234EC File Offset: 0x002216EC
		public void RemoveInputData(vtkDataSet arg0)
		{
			vtkAppendFilter.vtkAppendFilter_RemoveInputData_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06018746 RID: 100166
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendFilter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018747 RID: 100167 RVA: 0x0022351C File Offset: 0x0022171C
		public new static vtkAppendFilter SafeDownCast(vtkObjectBase o)
		{
			vtkAppendFilter vtkAppendFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendFilter.vtkAppendFilter_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAppendFilter = (vtkAppendFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAppendFilter.Register(null);
				}
			}
			return vtkAppendFilter;
		}

		// Token: 0x06018748 RID: 100168
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendFilter_SetMergePoints_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set if the filter should merge coincidental points
		/// Note: The filter will only merge points if the ghost cell array doesn't exist
		/// Defaults to Off
		/// </summary>
		// Token: 0x06018749 RID: 100169 RVA: 0x0022359B File Offset: 0x0022179B
		public virtual void SetMergePoints(int _arg)
		{
			vtkAppendFilter.vtkAppendFilter_SetMergePoints_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0601874A RID: 100170
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendFilter_SetOutputPointsPrecision_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x0601874B RID: 100171 RVA: 0x002235AB File Offset: 0x002217AB
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkAppendFilter.vtkAppendFilter_SetOutputPointsPrecision_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0601874C RID: 100172
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendFilter_SetTolerance_24(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set the tolerance to use to find coincident points when `MergePoints`
		/// is `true`. Default is 0.0.
		///
		/// This is simply passed on to the internal vtkLocator used to merge points.
		/// @sa `vtkLocator::SetTolerance`.
		/// </summary>
		// Token: 0x0601874D RID: 100173 RVA: 0x002235BB File Offset: 0x002217BB
		public virtual void SetTolerance(double _arg)
		{
			vtkAppendFilter.vtkAppendFilter_SetTolerance_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0601874E RID: 100174
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendFilter_SetToleranceIsAbsolute_25(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set whether Tolerance is treated as an absolute or relative tolerance.
		/// The default is to treat it as an absolute tolerance. When off, the
		/// tolerance is multiplied by the diagonal of the bounding box of the input.
		/// </summary>
		// Token: 0x0601874F RID: 100175 RVA: 0x002235CB File Offset: 0x002217CB
		public virtual void SetToleranceIsAbsolute(bool _arg)
		{
			vtkAppendFilter.vtkAppendFilter_SetToleranceIsAbsolute_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06018750 RID: 100176
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendFilter_ToleranceIsAbsoluteOff_26(HandleRef pThis);

		/// <summary>
		/// Get/Set whether Tolerance is treated as an absolute or relative tolerance.
		/// The default is to treat it as an absolute tolerance. When off, the
		/// tolerance is multiplied by the diagonal of the bounding box of the input.
		/// </summary>
		// Token: 0x06018751 RID: 100177 RVA: 0x002235E3 File Offset: 0x002217E3
		public virtual void ToleranceIsAbsoluteOff()
		{
			vtkAppendFilter.vtkAppendFilter_ToleranceIsAbsoluteOff_26(base.GetCppThis());
		}

		// Token: 0x06018752 RID: 100178
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendFilter_ToleranceIsAbsoluteOn_27(HandleRef pThis);

		/// <summary>
		/// Get/Set whether Tolerance is treated as an absolute or relative tolerance.
		/// The default is to treat it as an absolute tolerance. When off, the
		/// tolerance is multiplied by the diagonal of the bounding box of the input.
		/// </summary>
		// Token: 0x06018753 RID: 100179 RVA: 0x002235F2 File Offset: 0x002217F2
		public virtual void ToleranceIsAbsoluteOn()
		{
			vtkAppendFilter.vtkAppendFilter_ToleranceIsAbsoluteOn_27(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B1C RID: 6940
		public new const string MRFullTypeName = "Kitware.VTK.vtkAppendFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B1D RID: 6941
		public new static readonly string MRClassNameKey = "class vtkAppendFilter";
	}
}
