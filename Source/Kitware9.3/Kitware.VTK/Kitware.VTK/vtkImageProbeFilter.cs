using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageProbeFilter
	/// </summary>
	/// <remarks>
	///    sample image values at specified point positions
	///
	/// vtkImageProbeFilter interpolates an image at specified point positions.
	/// This filter has two inputs: the Input and Source. The Input geometric
	/// structure is passed through the filter, and the Output point scalars
	/// are interpolated from the Source image.
	///
	/// This filter can be used to resample an image onto a set of arbitrarily
	/// placed sample points.  For example, if you have a surface data set
	/// (i.e. a vtkPolyData that has been tessellated so that its points are
	/// very closely spaced), you can color the polydata from the image points.
	///
	/// In general, this filter is similar to vtkProbeFilter except that the
	/// Source data is always an image.  The advantages that it provides over
	/// vtkProbeFilter is that it is faster, and it can take advantage of the
	/// advanced interpolation methods offered by vtkAbstractImageInterpolator
	/// subclasses.
	/// </remarks>
	// Token: 0x02000860 RID: 2144
	public class vtkImageProbeFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016380 RID: 91008 RVA: 0x001F470C File Offset: 0x001F290C
		static vtkImageProbeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageProbeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageProbeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016381 RID: 91009 RVA: 0x001F4734 File Offset: 0x001F2934
		public vtkImageProbeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016382 RID: 91010
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageProbeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016383 RID: 91011 RVA: 0x001F4744 File Offset: 0x001F2944
		public new static vtkImageProbeFilter New()
		{
			vtkImageProbeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageProbeFilter.vtkImageProbeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016384 RID: 91012 RVA: 0x001F4798 File Offset: 0x001F2998
		public vtkImageProbeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageProbeFilter.vtkImageProbeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016385 RID: 91013 RVA: 0x001F47DC File Offset: 0x001F29DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016386 RID: 91014
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageProbeFilter_GetInterpolator_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the interpolator to use.  If this is not set, then nearest-neighbor
		/// interpolation will be used, with the tolerance of the interpolator set
		/// to 0.5 (half the voxel size).
		/// </summary>
		// Token: 0x06016387 RID: 91015 RVA: 0x001F47E8 File Offset: 0x001F29E8
		public virtual vtkAbstractImageInterpolator GetInterpolator()
		{
			vtkAbstractImageInterpolator vtkAbstractImageInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageProbeFilter.vtkImageProbeFilter_GetInterpolator_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractImageInterpolator = (vtkAbstractImageInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractImageInterpolator.Register(null);
				}
			}
			return vtkAbstractImageInterpolator;
		}

		// Token: 0x06016388 RID: 91016
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageProbeFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016389 RID: 91017 RVA: 0x001F4858 File Offset: 0x001F2A58
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageProbeFilter.vtkImageProbeFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601638A RID: 91018
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageProbeFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601638B RID: 91019 RVA: 0x001F4878 File Offset: 0x001F2A78
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageProbeFilter.vtkImageProbeFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601638C RID: 91020
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageProbeFilter_GetSource_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the data set that will be probed at the input points.
		/// The Input gives the geometry (the points and cells) for the output,
		/// while the Source is probed (interpolated) to generate the scalars,
		/// vectors, etc. for the output points based on the point locations.
		/// </summary>
		// Token: 0x0601638D RID: 91021 RVA: 0x001F4894 File Offset: 0x001F2A94
		public vtkDataObject GetSource()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageProbeFilter.vtkImageProbeFilter_GetSource_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0601638E RID: 91022
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageProbeFilter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601638F RID: 91023 RVA: 0x001F4904 File Offset: 0x001F2B04
		public override int IsA(string type)
		{
			return vtkImageProbeFilter.vtkImageProbeFilter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06016390 RID: 91024
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageProbeFilter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016391 RID: 91025 RVA: 0x001F4924 File Offset: 0x001F2B24
		public new static int IsTypeOf(string type)
		{
			return vtkImageProbeFilter.vtkImageProbeFilter_IsTypeOf_06(type);
		}

		// Token: 0x06016392 RID: 91026
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageProbeFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016393 RID: 91027 RVA: 0x001F4940 File Offset: 0x001F2B40
		public new vtkImageProbeFilter NewInstance()
		{
			vtkImageProbeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageProbeFilter.vtkImageProbeFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016394 RID: 91028
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageProbeFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016395 RID: 91029 RVA: 0x001F499C File Offset: 0x001F2B9C
		public new static vtkImageProbeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageProbeFilter vtkImageProbeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageProbeFilter.vtkImageProbeFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageProbeFilter = (vtkImageProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageProbeFilter.Register(null);
				}
			}
			return vtkImageProbeFilter;
		}

		// Token: 0x06016396 RID: 91030
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProbeFilter_SetInterpolator_10(HandleRef pThis, HandleRef interpolator);

		/// <summary>
		/// Set the interpolator to use.  If this is not set, then nearest-neighbor
		/// interpolation will be used, with the tolerance of the interpolator set
		/// to 0.5 (half the voxel size).
		/// </summary>
		// Token: 0x06016397 RID: 91031 RVA: 0x001F4A1C File Offset: 0x001F2C1C
		public virtual void SetInterpolator(vtkAbstractImageInterpolator interpolator)
		{
			vtkImageProbeFilter.vtkImageProbeFilter_SetInterpolator_10(base.GetCppThis(), (interpolator == null) ? default(HandleRef) : interpolator.GetCppThis());
		}

		// Token: 0x06016398 RID: 91032
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProbeFilter_SetSourceConnection_11(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the data set that will be probed at the input points.
		/// The Input gives the geometry (the points and cells) for the output,
		/// while the Source is probed (interpolated) to generate the scalars,
		/// vectors, etc. for the output points based on the point locations.
		/// </summary>
		// Token: 0x06016399 RID: 91033 RVA: 0x001F4A4C File Offset: 0x001F2C4C
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkImageProbeFilter.vtkImageProbeFilter_SetSourceConnection_11(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0601639A RID: 91034
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageProbeFilter_SetSourceData_12(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the data set that will be probed at the input points.
		/// The Input gives the geometry (the points and cells) for the output,
		/// while the Source is probed (interpolated) to generate the scalars,
		/// vectors, etc. for the output points based on the point locations.
		/// </summary>
		// Token: 0x0601639B RID: 91035 RVA: 0x001F4A7C File Offset: 0x001F2C7C
		public void SetSourceData(vtkDataObject source)
		{
			vtkImageProbeFilter.vtkImageProbeFilter_SetSourceData_12(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001914 RID: 6420
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageProbeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001915 RID: 6421
		public new static readonly string MRClassNameKey = "class vtkImageProbeFilter";
	}
}
