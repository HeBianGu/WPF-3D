using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDecimatePolylineFilter
	/// </summary>
	/// <remarks>
	///    reduce the number of lines in a polyline
	///
	/// vtkDecimatePolylineFilter is a filter to reduce the number of lines in a
	/// polyline. The algorithm functions by evaluating an error metric for each
	/// vertex (i.e., the distance of the vertex to a line defined from the two
	/// vertices on either side of the vertex). Then, these vertices are placed
	/// into a priority queue, and those with smaller errors are deleted first.
	/// The decimation continues until the target reduction is reached. While the
	/// filter will not delete end points, it will decimate closed loops down to a
	/// single line, thereby changing topology.
	///
	/// Note that a maximum error value (expressed in world coordinates) can also
	/// be specified. This may limit the amount of decimation so the target
	/// reduction may not be met. By setting the maximum error value to a very
	/// small number, colinear points can be eliminated.
	///
	/// @warning
	/// This algorithm is a very simple implementation that overlooks some
	/// potential complexities. For example, if a vertex is multiply connected,
	/// meaning that it is used by multiple distinct polylines, then the extra
	/// topological constraints are ignored. This can produce less than optimal
	/// results.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDecimate vtkDecimateProp vtkQuadricClustering vtkQuadricDecimation
	/// </seealso>
	// Token: 0x0200095A RID: 2394
	public class vtkDecimatePolylineFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018DE6 RID: 101862 RVA: 0x0022B399 File Offset: 0x00229599
		static vtkDecimatePolylineFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDecimatePolylineFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDecimatePolylineFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018DE7 RID: 101863 RVA: 0x0022B3C1 File Offset: 0x002295C1
		public vtkDecimatePolylineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018DE8 RID: 101864
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDecimatePolylineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this object with a target reduction of 0.90.
		/// </summary>
		// Token: 0x06018DE9 RID: 101865 RVA: 0x0022B3D0 File Offset: 0x002295D0
		public new static vtkDecimatePolylineFilter New()
		{
			vtkDecimatePolylineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDecimatePolylineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this object with a target reduction of 0.90.
		/// </summary>
		// Token: 0x06018DEA RID: 101866 RVA: 0x0022B424 File Offset: 0x00229624
		public vtkDecimatePolylineFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018DEB RID: 101867 RVA: 0x0022B468 File Offset: 0x00229668
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018DEC RID: 101868
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePolylineFilter_GetMaximumError_01(HandleRef pThis);

		/// <summary>
		/// Set the largest decimation error that is allowed during the decimation
		/// process. This may limit the maximum reduction that may be achieved. The
		/// maximum error is specified as a fraction of the maximum length of
		/// the input data bounding box.
		/// </summary>
		// Token: 0x06018DED RID: 101869 RVA: 0x0022B474 File Offset: 0x00229674
		public virtual double GetMaximumError()
		{
			return vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_GetMaximumError_01(base.GetCppThis());
		}

		// Token: 0x06018DEE RID: 101870
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePolylineFilter_GetMaximumErrorMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set the largest decimation error that is allowed during the decimation
		/// process. This may limit the maximum reduction that may be achieved. The
		/// maximum error is specified as a fraction of the maximum length of
		/// the input data bounding box.
		/// </summary>
		// Token: 0x06018DEF RID: 101871 RVA: 0x0022B494 File Offset: 0x00229694
		public virtual double GetMaximumErrorMaxValue()
		{
			return vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_GetMaximumErrorMaxValue_02(base.GetCppThis());
		}

		// Token: 0x06018DF0 RID: 101872
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePolylineFilter_GetMaximumErrorMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set the largest decimation error that is allowed during the decimation
		/// process. This may limit the maximum reduction that may be achieved. The
		/// maximum error is specified as a fraction of the maximum length of
		/// the input data bounding box.
		/// </summary>
		// Token: 0x06018DF1 RID: 101873 RVA: 0x0022B4B4 File Offset: 0x002296B4
		public virtual double GetMaximumErrorMinValue()
		{
			return vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_GetMaximumErrorMinValue_03(base.GetCppThis());
		}

		// Token: 0x06018DF2 RID: 101874
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDecimatePolylineFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x06018DF3 RID: 101875 RVA: 0x0022B4D4 File Offset: 0x002296D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06018DF4 RID: 101876
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDecimatePolylineFilter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x06018DF5 RID: 101877 RVA: 0x0022B4F4 File Offset: 0x002296F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06018DF6 RID: 101878
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDecimatePolylineFilter_GetOutputPointsPrecision_06(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018DF7 RID: 101879 RVA: 0x0022B510 File Offset: 0x00229710
		public virtual int GetOutputPointsPrecision()
		{
			return vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_GetOutputPointsPrecision_06(base.GetCppThis());
		}

		// Token: 0x06018DF8 RID: 101880
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePolylineFilter_GetTargetReduction_07(HandleRef pThis);

		/// <summary>
		/// Specify the desired reduction in the total number of polygons (e.g., if
		/// TargetReduction is set to 0.9, this filter will try to reduce the data set
		/// to 10% of its original size).
		/// </summary>
		// Token: 0x06018DF9 RID: 101881 RVA: 0x0022B530 File Offset: 0x00229730
		public virtual double GetTargetReduction()
		{
			return vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_GetTargetReduction_07(base.GetCppThis());
		}

		// Token: 0x06018DFA RID: 101882
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePolylineFilter_GetTargetReductionMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Specify the desired reduction in the total number of polygons (e.g., if
		/// TargetReduction is set to 0.9, this filter will try to reduce the data set
		/// to 10% of its original size).
		/// </summary>
		// Token: 0x06018DFB RID: 101883 RVA: 0x0022B550 File Offset: 0x00229750
		public virtual double GetTargetReductionMaxValue()
		{
			return vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_GetTargetReductionMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06018DFC RID: 101884
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePolylineFilter_GetTargetReductionMinValue_09(HandleRef pThis);

		/// <summary>
		/// Specify the desired reduction in the total number of polygons (e.g., if
		/// TargetReduction is set to 0.9, this filter will try to reduce the data set
		/// to 10% of its original size).
		/// </summary>
		// Token: 0x06018DFD RID: 101885 RVA: 0x0022B570 File Offset: 0x00229770
		public virtual double GetTargetReductionMinValue()
		{
			return vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_GetTargetReductionMinValue_09(base.GetCppThis());
		}

		// Token: 0x06018DFE RID: 101886
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDecimatePolylineFilter_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x06018DFF RID: 101887 RVA: 0x0022B590 File Offset: 0x00229790
		public override int IsA(string type)
		{
			return vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06018E00 RID: 101888
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDecimatePolylineFilter_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x06018E01 RID: 101889 RVA: 0x0022B5B0 File Offset: 0x002297B0
		public new static int IsTypeOf(string type)
		{
			return vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_IsTypeOf_11(type);
		}

		// Token: 0x06018E02 RID: 101890
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDecimatePolylineFilter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x06018E03 RID: 101891 RVA: 0x0022B5CC File Offset: 0x002297CC
		public new vtkDecimatePolylineFilter NewInstance()
		{
			vtkDecimatePolylineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDecimatePolylineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018E04 RID: 101892
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDecimatePolylineFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x06018E05 RID: 101893 RVA: 0x0022B628 File Offset: 0x00229828
		public new static vtkDecimatePolylineFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDecimatePolylineFilter vtkDecimatePolylineFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDecimatePolylineFilter = (vtkDecimatePolylineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDecimatePolylineFilter.Register(null);
				}
			}
			return vtkDecimatePolylineFilter;
		}

		// Token: 0x06018E06 RID: 101894
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePolylineFilter_SetMaximumError_15(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the largest decimation error that is allowed during the decimation
		/// process. This may limit the maximum reduction that may be achieved. The
		/// maximum error is specified as a fraction of the maximum length of
		/// the input data bounding box.
		/// </summary>
		// Token: 0x06018E07 RID: 101895 RVA: 0x0022B6A7 File Offset: 0x002298A7
		public virtual void SetMaximumError(double _arg)
		{
			vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_SetMaximumError_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06018E08 RID: 101896
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePolylineFilter_SetOutputPointsPrecision_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018E09 RID: 101897 RVA: 0x0022B6B7 File Offset: 0x002298B7
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_SetOutputPointsPrecision_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06018E0A RID: 101898
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePolylineFilter_SetTargetReduction_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the desired reduction in the total number of polygons (e.g., if
		/// TargetReduction is set to 0.9, this filter will try to reduce the data set
		/// to 10% of its original size).
		/// </summary>
		// Token: 0x06018E0B RID: 101899 RVA: 0x0022B6C7 File Offset: 0x002298C7
		public virtual void SetTargetReduction(double _arg)
		{
			vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_SetTargetReduction_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B6D RID: 7021
		public new const string MRFullTypeName = "Kitware.VTK.vtkDecimatePolylineFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B6E RID: 7022
		public new static readonly string MRClassNameKey = "class vtkDecimatePolylineFilter";
	}
}
