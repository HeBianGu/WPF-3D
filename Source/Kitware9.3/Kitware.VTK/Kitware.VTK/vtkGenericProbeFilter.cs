using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericProbeFilter
	/// </summary>
	/// <remarks>
	///    sample data values at specified point locations
	///
	/// vtkGenericProbeFilter is a filter that computes point attributes (e.g., scalars,
	/// vectors, etc.) at specified point positions. The filter has two inputs:
	/// the Input and Source. The Input geometric structure is passed through the
	/// filter. The point attributes are computed at the Input point positions
	/// by interpolating into the source data. For example, we can compute data
	/// values on a plane (plane specified as Input) from a volume (Source).
	///
	/// This filter can be used to resample data, or convert one dataset form into
	/// another. For example, a generic dataset can be probed with a volume
	/// (three-dimensional vtkImageData), and then volume rendering techniques can
	/// be used to visualize the results. Another example: a line or curve can be
	/// used to probe data to produce x-y plots along that line or curve.
	///
	/// This filter has been implemented to operate on generic datasets, rather
	/// than the typical vtkDataSet (and subclasses). vtkGenericDataSet is a more
	/// complex cousin of vtkDataSet, typically consisting of nonlinear,
	/// higher-order cells. To process this type of data, generic cells are
	/// automatically tessellated into linear cells prior to isocontouring.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGenericProbeFilter vtkProbeFilter vtkGenericDataSet
	/// </seealso>
	// Token: 0x0200049F RID: 1183
	public class vtkGenericProbeFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DA38 RID: 55864 RVA: 0x0012EE37 File Offset: 0x0012D037
		static vtkGenericProbeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericProbeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericProbeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DA39 RID: 55865 RVA: 0x0012EE5F File Offset: 0x0012D05F
		public vtkGenericProbeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DA3A RID: 55866
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericProbeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA3B RID: 55867 RVA: 0x0012EE70 File Offset: 0x0012D070
		public new static vtkGenericProbeFilter New()
		{
			vtkGenericProbeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericProbeFilter.vtkGenericProbeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA3C RID: 55868 RVA: 0x0012EEC4 File Offset: 0x0012D0C4
		public vtkGenericProbeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericProbeFilter.vtkGenericProbeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DA3D RID: 55869 RVA: 0x0012EF08 File Offset: 0x0012D108
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DA3E RID: 55870
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericProbeFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA3F RID: 55871 RVA: 0x0012EF14 File Offset: 0x0012D114
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericProbeFilter.vtkGenericProbeFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600DA40 RID: 55872
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericProbeFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA41 RID: 55873 RVA: 0x0012EF34 File Offset: 0x0012D134
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericProbeFilter.vtkGenericProbeFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600DA42 RID: 55874
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericProbeFilter_GetSource_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the point locations used to probe input. A generic dataset
		/// type is assumed.
		/// </summary>
		// Token: 0x0600DA43 RID: 55875 RVA: 0x0012EF50 File Offset: 0x0012D150
		public vtkGenericDataSet GetSource()
		{
			vtkGenericDataSet vtkGenericDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericProbeFilter.vtkGenericProbeFilter_GetSource_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericDataSet = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericDataSet.Register(null);
				}
			}
			return vtkGenericDataSet;
		}

		// Token: 0x0600DA44 RID: 55876
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericProbeFilter_GetValidPoints_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the list of point ids in the output that contain attribute data
		/// interpolated from the source.
		/// </summary>
		// Token: 0x0600DA45 RID: 55877 RVA: 0x0012EFC0 File Offset: 0x0012D1C0
		public virtual vtkIdTypeArray GetValidPoints()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericProbeFilter.vtkGenericProbeFilter_GetValidPoints_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x0600DA46 RID: 55878
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericProbeFilter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA47 RID: 55879 RVA: 0x0012F030 File Offset: 0x0012D230
		public override int IsA(string type)
		{
			return vtkGenericProbeFilter.vtkGenericProbeFilter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600DA48 RID: 55880
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericProbeFilter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA49 RID: 55881 RVA: 0x0012F050 File Offset: 0x0012D250
		public new static int IsTypeOf(string type)
		{
			return vtkGenericProbeFilter.vtkGenericProbeFilter_IsTypeOf_06(type);
		}

		// Token: 0x0600DA4A RID: 55882
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericProbeFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA4B RID: 55883 RVA: 0x0012F06C File Offset: 0x0012D26C
		public new vtkGenericProbeFilter NewInstance()
		{
			vtkGenericProbeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericProbeFilter.vtkGenericProbeFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DA4C RID: 55884
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericProbeFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA4D RID: 55885 RVA: 0x0012F0C8 File Offset: 0x0012D2C8
		public new static vtkGenericProbeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGenericProbeFilter vtkGenericProbeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericProbeFilter.vtkGenericProbeFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericProbeFilter = (vtkGenericProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericProbeFilter.Register(null);
				}
			}
			return vtkGenericProbeFilter;
		}

		// Token: 0x0600DA4E RID: 55886
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericProbeFilter_SetSourceData_10(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the point locations used to probe input. A generic dataset
		/// type is assumed.
		/// </summary>
		// Token: 0x0600DA4F RID: 55887 RVA: 0x0012F148 File Offset: 0x0012D348
		public void SetSourceData(vtkGenericDataSet source)
		{
			vtkGenericProbeFilter.vtkGenericProbeFilter_SetSourceData_10(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FE6 RID: 4070
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericProbeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FE7 RID: 4071
		public new static readonly string MRClassNameKey = "class vtkGenericProbeFilter";
	}
}
