using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointOccupancyFilter
	/// </summary>
	/// <remarks>
	///    produce occupancy bit mask from input point cloud
	///
	/// vtkPointOccupancyFilter is a filter that generates an occupancy mask on a
	/// volume from a point cloud. The output of the filter is an image/volume
	/// that indicates for each pixel/voxel whether a point exists within the
	/// pixel/voxel.
	///
	/// To use this filter, specify an input of type vtkPointSet (i.e., has an
	/// explicit representation of points). Then define the occupancy volume by
	/// specifying the sample dimensions and bounds. Optionally you can specify
	/// unsigned char values used to indicate whether a voxel is empty or occupied.
	///
	/// @warning
	/// During processing, if a point is found to be outside of the occupancy volume,
	/// then it is skipped (i.e., it does not affect the occupancy mask).
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointDensityFilter vtkPointMaskFilter
	/// </seealso>
	// Token: 0x02000452 RID: 1106
	public class vtkPointOccupancyFilter : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CDD3 RID: 52691 RVA: 0x0011E423 File Offset: 0x0011C623
		static vtkPointOccupancyFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointOccupancyFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointOccupancyFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CDD4 RID: 52692 RVA: 0x0011E44B File Offset: 0x0011C64B
		public vtkPointOccupancyFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CDD5 RID: 52693
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointOccupancyFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CDD6 RID: 52694 RVA: 0x0011E45C File Offset: 0x0011C65C
		public new static vtkPointOccupancyFilter New()
		{
			vtkPointOccupancyFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointOccupancyFilter.vtkPointOccupancyFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointOccupancyFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CDD7 RID: 52695 RVA: 0x0011E4B0 File Offset: 0x0011C6B0
		public vtkPointOccupancyFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointOccupancyFilter.vtkPointOccupancyFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CDD8 RID: 52696 RVA: 0x0011E4F4 File Offset: 0x0011C6F4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CDD9 RID: 52697
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointOccupancyFilter_GetEmptyValue_01(HandleRef pThis);

		/// <summary>
		/// Set / get the values indicating whether a voxel is empty (i.e., does not
		/// contain any points) or occupied. By default, an empty voxel has a zero
		/// value; an occupied voxel has a value of one.
		/// </summary>
		// Token: 0x0600CDDA RID: 52698 RVA: 0x0011E500 File Offset: 0x0011C700
		public virtual byte GetEmptyValue()
		{
			return vtkPointOccupancyFilter.vtkPointOccupancyFilter_GetEmptyValue_01(base.GetCppThis());
		}

		// Token: 0x0600CDDB RID: 52699
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointOccupancyFilter_GetModelBounds_02(HandleRef pThis);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600CDDC RID: 52700 RVA: 0x0011E520 File Offset: 0x0011C720
		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkPointOccupancyFilter.vtkPointOccupancyFilter_GetModelBounds_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600CDDD RID: 52701
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointOccupancyFilter_GetModelBounds_03(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600CDDE RID: 52702 RVA: 0x0011E568 File Offset: 0x0011C768
		public virtual void GetModelBounds(IntPtr data)
		{
			vtkPointOccupancyFilter.vtkPointOccupancyFilter_GetModelBounds_03(base.GetCppThis(), data);
		}

		// Token: 0x0600CDDF RID: 52703
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointOccupancyFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CDE0 RID: 52704 RVA: 0x0011E578 File Offset: 0x0011C778
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointOccupancyFilter.vtkPointOccupancyFilter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600CDE1 RID: 52705
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointOccupancyFilter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CDE2 RID: 52706 RVA: 0x0011E598 File Offset: 0x0011C798
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointOccupancyFilter.vtkPointOccupancyFilter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600CDE3 RID: 52707
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointOccupancyFilter_GetOccupiedValue_06(HandleRef pThis);

		/// <summary>
		/// Set / get the values indicating whether a voxel is empty (i.e., does not
		/// contain any points) or occupied. By default, an empty voxel has a zero
		/// value; an occupied voxel has a value of one.
		/// </summary>
		// Token: 0x0600CDE4 RID: 52708 RVA: 0x0011E5B4 File Offset: 0x0011C7B4
		public virtual byte GetOccupiedValue()
		{
			return vtkPointOccupancyFilter.vtkPointOccupancyFilter_GetOccupiedValue_06(base.GetCppThis());
		}

		// Token: 0x0600CDE5 RID: 52709
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointOccupancyFilter_GetSampleDimensions_07(HandleRef pThis);

		/// <summary>
		/// Set / get the dimensions of the occupancy volume. Higher values generally
		/// produce better results but may be much slower.
		/// </summary>
		// Token: 0x0600CDE6 RID: 52710 RVA: 0x0011E5D4 File Offset: 0x0011C7D4
		public virtual int[] GetSampleDimensions()
		{
			IntPtr intPtr = vtkPointOccupancyFilter.vtkPointOccupancyFilter_GetSampleDimensions_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600CDE7 RID: 52711
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointOccupancyFilter_GetSampleDimensions_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the dimensions of the occupancy volume. Higher values generally
		/// produce better results but may be much slower.
		/// </summary>
		// Token: 0x0600CDE8 RID: 52712 RVA: 0x0011E61C File Offset: 0x0011C81C
		public virtual void GetSampleDimensions(IntPtr data)
		{
			vtkPointOccupancyFilter.vtkPointOccupancyFilter_GetSampleDimensions_08(base.GetCppThis(), data);
		}

		// Token: 0x0600CDE9 RID: 52713
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointOccupancyFilter_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CDEA RID: 52714 RVA: 0x0011E62C File Offset: 0x0011C82C
		public override int IsA(string type)
		{
			return vtkPointOccupancyFilter.vtkPointOccupancyFilter_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600CDEB RID: 52715
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointOccupancyFilter_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CDEC RID: 52716 RVA: 0x0011E64C File Offset: 0x0011C84C
		public new static int IsTypeOf(string type)
		{
			return vtkPointOccupancyFilter.vtkPointOccupancyFilter_IsTypeOf_10(type);
		}

		// Token: 0x0600CDED RID: 52717
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointOccupancyFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CDEE RID: 52718 RVA: 0x0011E668 File Offset: 0x0011C868
		public new vtkPointOccupancyFilter NewInstance()
		{
			vtkPointOccupancyFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointOccupancyFilter.vtkPointOccupancyFilter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointOccupancyFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CDEF RID: 52719
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointOccupancyFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CDF0 RID: 52720 RVA: 0x0011E6C4 File Offset: 0x0011C8C4
		public new static vtkPointOccupancyFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPointOccupancyFilter vtkPointOccupancyFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointOccupancyFilter.vtkPointOccupancyFilter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointOccupancyFilter = (vtkPointOccupancyFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointOccupancyFilter.Register(null);
				}
			}
			return vtkPointOccupancyFilter;
		}

		// Token: 0x0600CDF1 RID: 52721
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointOccupancyFilter_SetEmptyValue_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set / get the values indicating whether a voxel is empty (i.e., does not
		/// contain any points) or occupied. By default, an empty voxel has a zero
		/// value; an occupied voxel has a value of one.
		/// </summary>
		// Token: 0x0600CDF2 RID: 52722 RVA: 0x0011E743 File Offset: 0x0011C943
		public virtual void SetEmptyValue(byte _arg)
		{
			vtkPointOccupancyFilter.vtkPointOccupancyFilter_SetEmptyValue_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CDF3 RID: 52723
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointOccupancyFilter_SetModelBounds_15(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600CDF4 RID: 52724 RVA: 0x0011E753 File Offset: 0x0011C953
		public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkPointOccupancyFilter.vtkPointOccupancyFilter_SetModelBounds_15(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600CDF5 RID: 52725
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointOccupancyFilter_SetModelBounds_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600CDF6 RID: 52726 RVA: 0x0011E76B File Offset: 0x0011C96B
		public virtual void SetModelBounds(IntPtr _arg)
		{
			vtkPointOccupancyFilter.vtkPointOccupancyFilter_SetModelBounds_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CDF7 RID: 52727
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointOccupancyFilter_SetOccupiedValue_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set / get the values indicating whether a voxel is empty (i.e., does not
		/// contain any points) or occupied. By default, an empty voxel has a zero
		/// value; an occupied voxel has a value of one.
		/// </summary>
		// Token: 0x0600CDF8 RID: 52728 RVA: 0x0011E77B File Offset: 0x0011C97B
		public virtual void SetOccupiedValue(byte _arg)
		{
			vtkPointOccupancyFilter.vtkPointOccupancyFilter_SetOccupiedValue_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CDF9 RID: 52729
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointOccupancyFilter_SetSampleDimensions_18(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Set / get the dimensions of the occupancy volume. Higher values generally
		/// produce better results but may be much slower.
		/// </summary>
		// Token: 0x0600CDFA RID: 52730 RVA: 0x0011E78B File Offset: 0x0011C98B
		public void SetSampleDimensions(int i, int j, int k)
		{
			vtkPointOccupancyFilter.vtkPointOccupancyFilter_SetSampleDimensions_18(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0600CDFB RID: 52731
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointOccupancyFilter_SetSampleDimensions_19(HandleRef pThis, IntPtr dim);

		/// <summary>
		/// Set / get the dimensions of the occupancy volume. Higher values generally
		/// produce better results but may be much slower.
		/// </summary>
		// Token: 0x0600CDFC RID: 52732 RVA: 0x0011E79D File Offset: 0x0011C99D
		public void SetSampleDimensions(IntPtr dim)
		{
			vtkPointOccupancyFilter.vtkPointOccupancyFilter_SetSampleDimensions_19(base.GetCppThis(), dim);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F37 RID: 3895
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointOccupancyFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F38 RID: 3896
		public new static readonly string MRClassNameKey = "class vtkPointOccupancyFilter";
	}
}
