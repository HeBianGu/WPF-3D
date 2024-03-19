using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStaticPointLocator
	/// </summary>
	/// <remarks>
	///    quickly locate points in 3-space
	///
	/// vtkStaticPointLocator is a spatial search object to quickly locate points
	/// in 3D.  vtkStaticPointLocator works by dividing a specified region of
	/// space into a regular array of cuboid buckets, and then keeping a
	/// list of points that lie in each bucket. Typical operation involves giving
	/// a position in 3D and finding the closest point; or finding the N closest
	/// points.
	///
	/// vtkStaticPointLocator is an accelerated version of vtkPointLocator. It is
	/// threaded (via vtkSMPTools), and supports one-time static construction
	/// (i.e., incremental point insertion is not supported). If you need to
	/// incrementally insert points, use the vtkPointLocator or its kin to do so.
	///
	/// @warning
	/// This class is templated. It may run slower than serial execution if the code
	/// is not optimized during compilation. Build in Release or ReleaseWithDebugInfo.
	///
	/// @warning
	/// Make sure that you review the documentation for the superclasses
	/// vtkAbstactPointLocator and vtkLocator. In particular the Automatic
	/// data member can be used to automatically determine divisions based
	/// on the average number of points per bucket.
	///
	/// @warning
	/// Other types of spatial locators have been developed such as octrees and
	/// kd-trees. These are often more efficient for the operations described
	/// here.
	///
	/// @warning
	/// Frequently vtkStaticPointLocator is used in lieu of vtkPointLocator.
	/// They are very similar in terms of algorithmic approach, however
	/// vtkStaticCellLocator is threaded and is typically much faster for
	/// a large number of points (on the order of 3-5x faster). For small numbers
	/// of points, vtkPointLocator is just as fast as vtkStaticPointLocator.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointLocator vtkCellLocator vtkLocator vtkAbstractPointLocator
	/// </seealso>
	// Token: 0x02000AC9 RID: 2761
	public class vtkStaticPointLocator : vtkAbstractPointLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D0AA RID: 118954 RVA: 0x0028F52B File Offset: 0x0028D72B
		static vtkStaticPointLocator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStaticPointLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStaticPointLocator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D0AB RID: 118955 RVA: 0x0028F553 File Offset: 0x0028D753
		public vtkStaticPointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D0AC RID: 118956
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticPointLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with automatic computation of divisions, averaging
		/// 5 points per bucket.
		/// </summary>
		// Token: 0x0601D0AD RID: 118957 RVA: 0x0028F564 File Offset: 0x0028D764
		public new static vtkStaticPointLocator New()
		{
			vtkStaticPointLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStaticPointLocator.vtkStaticPointLocator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStaticPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with automatic computation of divisions, averaging
		/// 5 points per bucket.
		/// </summary>
		// Token: 0x0601D0AE RID: 118958 RVA: 0x0028F5B8 File Offset: 0x0028D7B8
		public vtkStaticPointLocator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStaticPointLocator.vtkStaticPointLocator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D0AF RID: 118959 RVA: 0x0028F5FC File Offset: 0x0028D7FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D0B0 RID: 118960
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_BuildLocator_01(HandleRef pThis);

		/// <summary>
		/// See vtkLocator and vtkAbstractPointLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0601D0B1 RID: 118961 RVA: 0x0028F607 File Offset: 0x0028D807
		public override void BuildLocator()
		{
			vtkStaticPointLocator.vtkStaticPointLocator_BuildLocator_01(base.GetCppThis());
		}

		// Token: 0x0601D0B2 RID: 118962
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_BuildLocator_02(HandleRef pThis, IntPtr inBounds);

		/// <summary>
		/// See vtkLocator and vtkAbstractPointLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0601D0B3 RID: 118963 RVA: 0x0028F616 File Offset: 0x0028D816
		public void BuildLocator(IntPtr inBounds)
		{
			vtkStaticPointLocator.vtkStaticPointLocator_BuildLocator_02(base.GetCppThis(), inBounds);
		}

		// Token: 0x0601D0B4 RID: 118964
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_FindClosestNPoints_03(HandleRef pThis, int N, IntPtr x, HandleRef result);

		/// <summary>
		/// Find the closest N points to a position. This returns the closest N
		/// points to a position. A faster method could be created that returned N
		/// close points to a position, but necessarily the exact N closest.  The
		/// returned points are sorted from closest to farthest.  These methods are
		/// thread safe if BuildLocator() is directly or indirectly called from a
		/// single thread first.
		/// </summary>
		// Token: 0x0601D0B5 RID: 118965 RVA: 0x0028F628 File Offset: 0x0028D828
		public override void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
		{
			vtkStaticPointLocator.vtkStaticPointLocator_FindClosestNPoints_03(base.GetCppThis(), N, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0601D0B6 RID: 118966
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator_FindClosestPoint_04(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Given a position x, return the id of the point closest to it, or (-1) if
		/// no point found. An alternative method (defined in the superclass)
		/// requires separate x-y-z values. These methods are thread safe if
		/// BuildLocator() is directly or indirectly called from a single thread
		/// first.
		/// </summary>
		// Token: 0x0601D0B7 RID: 118967 RVA: 0x0028F65C File Offset: 0x0028D85C
		public override long FindClosestPoint(IntPtr x)
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_FindClosestPoint_04(base.GetCppThis(), x);
		}

		// Token: 0x0601D0B8 RID: 118968
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator_FindClosestPointWithinRadius_05(HandleRef pThis, double radius, IntPtr x, ref double dist2);

		/// <summary>
		/// Given a position x and a radius r, return the id of the point closest to
		/// the point in that radius, or (-1) if nothing found.  These methods are
		/// thread safe if BuildLocator() is directly or indirectly called from a
		/// single thread first. dist2 returns the squared distance to the
		/// point. Note that if multiple points are located the same distance away,
		/// the actual point returned is a function in which order the points are
		/// processed (i.e., indeterminate).
		/// </summary>
		// Token: 0x0601D0B9 RID: 118969 RVA: 0x0028F67C File Offset: 0x0028D87C
		public override long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_FindClosestPointWithinRadius_05(base.GetCppThis(), radius, x, ref dist2);
		}

		// Token: 0x0601D0BA RID: 118970
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator_FindClosestPointWithinRadius_06(HandleRef pThis, double radius, IntPtr x, double inputDataLength, ref double dist2);

		/// <summary>
		/// Given a position x and a radius r, return the id of the point closest to
		/// the point in that radius, or (-1) if nothing found.  These methods are
		/// thread safe if BuildLocator() is directly or indirectly called from a
		/// single thread first. dist2 returns the squared distance to the
		/// point. Note that if multiple points are located the same distance away,
		/// the actual point returned is a function in which order the points are
		/// processed (i.e., indeterminate).
		/// </summary>
		// Token: 0x0601D0BB RID: 118971 RVA: 0x0028F6A0 File Offset: 0x0028D8A0
		public virtual long FindClosestPointWithinRadius(double radius, IntPtr x, double inputDataLength, ref double dist2)
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_FindClosestPointWithinRadius_06(base.GetCppThis(), radius, x, inputDataLength, ref dist2);
		}

		// Token: 0x0601D0BC RID: 118972
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_FindPointsWithinRadius_07(HandleRef pThis, double R, IntPtr x, HandleRef result);

		/// <summary>
		/// Find all points within a specified radius R of position x.
		/// The result is not sorted in any specific manner.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0601D0BD RID: 118973 RVA: 0x0028F6C4 File Offset: 0x0028D8C4
		public override void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
		{
			vtkStaticPointLocator.vtkStaticPointLocator_FindPointsWithinRadius_07(base.GetCppThis(), R, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0601D0BE RID: 118974
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_ForceBuildLocator_08(HandleRef pThis);

		/// <summary>
		/// See vtkLocator and vtkAbstractPointLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0601D0BF RID: 118975 RVA: 0x0028F6F5 File Offset: 0x0028D8F5
		public override void ForceBuildLocator()
		{
			vtkStaticPointLocator.vtkStaticPointLocator_ForceBuildLocator_08(base.GetCppThis());
		}

		// Token: 0x0601D0C0 RID: 118976
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_FreeSearchStructure_09(HandleRef pThis);

		/// <summary>
		/// See vtkLocator and vtkAbstractPointLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0601D0C1 RID: 118977 RVA: 0x0028F704 File Offset: 0x0028D904
		public override void FreeSearchStructure()
		{
			vtkStaticPointLocator.vtkStaticPointLocator_FreeSearchStructure_09(base.GetCppThis());
		}

		// Token: 0x0601D0C2 RID: 118978
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_GenerateRepresentation_10(HandleRef pThis, int level, HandleRef pd);

		/// <summary>
		/// Populate a polydata with the faces of the bins that potentially contain cells.
		/// Note that the level parameter has no effect on this method as there is no
		/// hierarchy built (i.e., uniform binning). Typically this is used for debugging.
		/// </summary>
		// Token: 0x0601D0C3 RID: 118979 RVA: 0x0028F714 File Offset: 0x0028D914
		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkStaticPointLocator.vtkStaticPointLocator_GenerateRepresentation_10(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0601D0C4 RID: 118980
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_GetBucketIds_11(HandleRef pThis, long bNum, HandleRef bList);

		/// <summary>
		/// Given a bucket number bNum between 0 &lt;= bNum &lt; this-&gt;GetNumberOfBuckets(),
		/// return a list of point ids contained within the bucket. The user must
		/// provide an instance of vtkIdList to contain the result.
		/// </summary>
		// Token: 0x0601D0C5 RID: 118981 RVA: 0x0028F744 File Offset: 0x0028D944
		public void GetBucketIds(long bNum, vtkIdList bList)
		{
			vtkStaticPointLocator.vtkStaticPointLocator_GetBucketIds_11(base.GetCppThis(), bNum, (bList == null) ? default(HandleRef) : bList.GetCppThis());
		}

		// Token: 0x0601D0C6 RID: 118982
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticPointLocator_GetDivisions_12(HandleRef pThis);

		/// <summary>
		/// Set the number of divisions in x-y-z directions. If the Automatic data
		/// member is enabled, the Divisions are set according to the
		/// NumberOfPointsPerBucket and MaxNumberOfBuckets data members. The number
		/// of divisions must be &gt;= 1 in each direction.
		/// </summary>
		// Token: 0x0601D0C7 RID: 118983 RVA: 0x0028F774 File Offset: 0x0028D974
		public virtual int[] GetDivisions()
		{
			IntPtr intPtr = vtkStaticPointLocator.vtkStaticPointLocator_GetDivisions_12(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601D0C8 RID: 118984
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_GetDivisions_13(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the number of divisions in x-y-z directions. If the Automatic data
		/// member is enabled, the Divisions are set according to the
		/// NumberOfPointsPerBucket and MaxNumberOfBuckets data members. The number
		/// of divisions must be &gt;= 1 in each direction.
		/// </summary>
		// Token: 0x0601D0C9 RID: 118985 RVA: 0x0028F7BC File Offset: 0x0028D9BC
		public virtual void GetDivisions(IntPtr data)
		{
			vtkStaticPointLocator.vtkStaticPointLocator_GetDivisions_13(base.GetCppThis(), data);
		}

		// Token: 0x0601D0CA RID: 118986
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStaticPointLocator_GetLargeIds_14(HandleRef pThis);

		/// <summary>
		/// Inform the user as to whether large ids are being used. This flag only
		/// has meaning after the locator has been built. Large ids are used when the
		/// number of binned points, or the number of bins, is &gt;= the maximum number
		/// of buckets (specified by the user). Note that LargeIds are only available
		/// on 64-bit architectures.
		/// </summary>
		// Token: 0x0601D0CB RID: 118987 RVA: 0x0028F7CC File Offset: 0x0028D9CC
		public bool GetLargeIds()
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_GetLargeIds_14(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D0CC RID: 118988
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator_GetMaxNumberOfBuckets_15(HandleRef pThis);

		/// <summary>
		/// Set the maximum number of buckets in the locator. By default the value
		/// is set to VTK_INT_MAX. Note that there are significant performance
		/// implications at work here. If the number of buckets is set very large
		/// (meaning &gt; VTK_INT_MAX) then internal sorting may be performed using
		/// 64-bit integers (which is much slower than using a 32-bit int). Of
		/// course, memory requirements may dramatically increase as well.  It is
		/// recommended that the default value be used; but for extremely large data
		/// it may be desired to create a locator with an exceptionally large number
		/// of buckets. Note also that during initialization of the locator if the
		/// MaxNumberOfBuckets threshold is exceeded, the Divisions are scaled down
		/// in such a way as not to exceed the MaxNumberOfBuckets proportionally to
		/// the size of the bounding box in the x-y-z directions.
		/// </summary>
		// Token: 0x0601D0CD RID: 118989 RVA: 0x0028F7F4 File Offset: 0x0028D9F4
		public virtual long GetMaxNumberOfBuckets()
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_GetMaxNumberOfBuckets_15(base.GetCppThis());
		}

		// Token: 0x0601D0CE RID: 118990
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator_GetMaxNumberOfBucketsMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Set the maximum number of buckets in the locator. By default the value
		/// is set to VTK_INT_MAX. Note that there are significant performance
		/// implications at work here. If the number of buckets is set very large
		/// (meaning &gt; VTK_INT_MAX) then internal sorting may be performed using
		/// 64-bit integers (which is much slower than using a 32-bit int). Of
		/// course, memory requirements may dramatically increase as well.  It is
		/// recommended that the default value be used; but for extremely large data
		/// it may be desired to create a locator with an exceptionally large number
		/// of buckets. Note also that during initialization of the locator if the
		/// MaxNumberOfBuckets threshold is exceeded, the Divisions are scaled down
		/// in such a way as not to exceed the MaxNumberOfBuckets proportionally to
		/// the size of the bounding box in the x-y-z directions.
		/// </summary>
		// Token: 0x0601D0CF RID: 118991 RVA: 0x0028F814 File Offset: 0x0028DA14
		public virtual long GetMaxNumberOfBucketsMaxValue()
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_GetMaxNumberOfBucketsMaxValue_16(base.GetCppThis());
		}

		// Token: 0x0601D0D0 RID: 118992
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator_GetMaxNumberOfBucketsMinValue_17(HandleRef pThis);

		/// <summary>
		/// Set the maximum number of buckets in the locator. By default the value
		/// is set to VTK_INT_MAX. Note that there are significant performance
		/// implications at work here. If the number of buckets is set very large
		/// (meaning &gt; VTK_INT_MAX) then internal sorting may be performed using
		/// 64-bit integers (which is much slower than using a 32-bit int). Of
		/// course, memory requirements may dramatically increase as well.  It is
		/// recommended that the default value be used; but for extremely large data
		/// it may be desired to create a locator with an exceptionally large number
		/// of buckets. Note also that during initialization of the locator if the
		/// MaxNumberOfBuckets threshold is exceeded, the Divisions are scaled down
		/// in such a way as not to exceed the MaxNumberOfBuckets proportionally to
		/// the size of the bounding box in the x-y-z directions.
		/// </summary>
		// Token: 0x0601D0D1 RID: 118993 RVA: 0x0028F834 File Offset: 0x0028DA34
		public virtual long GetMaxNumberOfBucketsMinValue()
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_GetMaxNumberOfBucketsMinValue_17(base.GetCppThis());
		}

		// Token: 0x0601D0D2 RID: 118994
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601D0D3 RID: 118995 RVA: 0x0028F854 File Offset: 0x0028DA54
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x0601D0D4 RID: 118996
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601D0D5 RID: 118997 RVA: 0x0028F874 File Offset: 0x0028DA74
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x0601D0D6 RID: 118998
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator_GetNumberOfPointsInBucket_20(HandleRef pThis, long bNum);

		/// <summary>
		/// Given a bucket number bNum between 0 &lt;= bNum &lt; this-&gt;GetNumberOfBuckets(),
		/// return the number of points found in the bucket.
		/// </summary>
		// Token: 0x0601D0D7 RID: 118999 RVA: 0x0028F890 File Offset: 0x0028DA90
		public long GetNumberOfPointsInBucket(long bNum)
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_GetNumberOfPointsInBucket_20(base.GetCppThis(), bNum);
		}

		// Token: 0x0601D0D8 RID: 119000
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticPointLocator_GetNumberOfPointsPerBucket_21(HandleRef pThis);

		/// <summary>
		/// Specify the average number of points in each bucket. This data member is
		/// used in conjunction with the Automatic data member (if enabled) to
		/// determine the number of locator x-y-z divisions.
		/// </summary>
		// Token: 0x0601D0D9 RID: 119001 RVA: 0x0028F8B0 File Offset: 0x0028DAB0
		public virtual int GetNumberOfPointsPerBucket()
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_GetNumberOfPointsPerBucket_21(base.GetCppThis());
		}

		// Token: 0x0601D0DA RID: 119002
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticPointLocator_GetNumberOfPointsPerBucketMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Specify the average number of points in each bucket. This data member is
		/// used in conjunction with the Automatic data member (if enabled) to
		/// determine the number of locator x-y-z divisions.
		/// </summary>
		// Token: 0x0601D0DB RID: 119003 RVA: 0x0028F8D0 File Offset: 0x0028DAD0
		public virtual int GetNumberOfPointsPerBucketMaxValue()
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_GetNumberOfPointsPerBucketMaxValue_22(base.GetCppThis());
		}

		// Token: 0x0601D0DC RID: 119004
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticPointLocator_GetNumberOfPointsPerBucketMinValue_23(HandleRef pThis);

		/// <summary>
		/// Specify the average number of points in each bucket. This data member is
		/// used in conjunction with the Automatic data member (if enabled) to
		/// determine the number of locator x-y-z divisions.
		/// </summary>
		// Token: 0x0601D0DD RID: 119005 RVA: 0x0028F8F0 File Offset: 0x0028DAF0
		public virtual int GetNumberOfPointsPerBucketMinValue()
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_GetNumberOfPointsPerBucketMinValue_23(base.GetCppThis());
		}

		// Token: 0x0601D0DE RID: 119006
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticPointLocator_GetSpacing_24(HandleRef pThis);

		/// <summary>
		/// Provide an accessor to the bucket spacing. Valid after the locator is
		/// built.
		/// </summary>
		// Token: 0x0601D0DF RID: 119007 RVA: 0x0028F910 File Offset: 0x0028DB10
		public virtual IntPtr GetSpacing()
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_GetSpacing_24(base.GetCppThis());
		}

		// Token: 0x0601D0E0 RID: 119008
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_GetSpacing_25(HandleRef pThis, IntPtr spacing);

		/// <summary>
		/// Provide an accessor to the bucket spacing. Valid after the locator is
		/// built.
		/// </summary>
		// Token: 0x0601D0E1 RID: 119009 RVA: 0x0028F92F File Offset: 0x0028DB2F
		public virtual void GetSpacing(IntPtr spacing)
		{
			vtkStaticPointLocator.vtkStaticPointLocator_GetSpacing_25(base.GetCppThis(), spacing);
		}

		// Token: 0x0601D0E2 RID: 119010
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticPointLocator_GetTraversalOrder_26(HandleRef pThis);

		/// <summary>
		/// Specify the manner in which points are processed when a non-zero merge
		/// tolerance is specified. By default, BIN_ORDER is used (i.e., threaded
		/// using bin checkerboard traversal) versus POINT_ORDER, which is a serial traversal.
		/// </summary>
		// Token: 0x0601D0E3 RID: 119011 RVA: 0x0028F940 File Offset: 0x0028DB40
		public virtual int GetTraversalOrder()
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_GetTraversalOrder_26(base.GetCppThis());
		}

		// Token: 0x0601D0E4 RID: 119012
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticPointLocator_GetTraversalOrderMaxValue_27(HandleRef pThis);

		/// <summary>
		/// Specify the manner in which points are processed when a non-zero merge
		/// tolerance is specified. By default, BIN_ORDER is used (i.e., threaded
		/// using bin checkerboard traversal) versus POINT_ORDER, which is a serial traversal.
		/// </summary>
		// Token: 0x0601D0E5 RID: 119013 RVA: 0x0028F960 File Offset: 0x0028DB60
		public virtual int GetTraversalOrderMaxValue()
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_GetTraversalOrderMaxValue_27(base.GetCppThis());
		}

		// Token: 0x0601D0E6 RID: 119014
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticPointLocator_GetTraversalOrderMinValue_28(HandleRef pThis);

		/// <summary>
		/// Specify the manner in which points are processed when a non-zero merge
		/// tolerance is specified. By default, BIN_ORDER is used (i.e., threaded
		/// using bin checkerboard traversal) versus POINT_ORDER, which is a serial traversal.
		/// </summary>
		// Token: 0x0601D0E7 RID: 119015 RVA: 0x0028F980 File Offset: 0x0028DB80
		public virtual int GetTraversalOrderMinValue()
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_GetTraversalOrderMinValue_28(base.GetCppThis());
		}

		// Token: 0x0601D0E8 RID: 119016
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_Initialize_29(HandleRef pThis);

		/// <summary>
		/// See vtkLocator and vtkAbstractPointLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0601D0E9 RID: 119017 RVA: 0x0028F99F File Offset: 0x0028DB9F
		public override void Initialize()
		{
			vtkStaticPointLocator.vtkStaticPointLocator_Initialize_29(base.GetCppThis());
		}

		// Token: 0x0601D0EA RID: 119018
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticPointLocator_IntersectWithLine_30(HandleRef pThis, IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr lineX, IntPtr ptX, ref long ptId);

		/// <summary>
		/// Intersect the points contained in the locator with the line defined by
		/// (a0,a1). Return the point within the tolerance tol that is closest to a0
		/// (tol measured in the world coordinate system). If an intersection occurs
		/// (i.e., the method returns nonzero), then the parametric location along
		/// the line t, the closest position along the line lineX, and the coordinates
		/// of the picked ptId is returned in ptX. (This method is thread safe after
		/// the locator is built.)
		/// </summary>
		// Token: 0x0601D0EB RID: 119019 RVA: 0x0028F9B0 File Offset: 0x0028DBB0
		public int IntersectWithLine(IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr lineX, IntPtr ptX, ref long ptId)
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_IntersectWithLine_30(base.GetCppThis(), a0, a1, tol, ref t, lineX, ptX, ref ptId);
		}

		// Token: 0x0601D0EC RID: 119020
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticPointLocator_IsA_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601D0ED RID: 119021 RVA: 0x0028F9DC File Offset: 0x0028DBDC
		public override int IsA(string type)
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_IsA_31(base.GetCppThis(), type);
		}

		// Token: 0x0601D0EE RID: 119022
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticPointLocator_IsTypeOf_32([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601D0EF RID: 119023 RVA: 0x0028F9FC File Offset: 0x0028DBFC
		public new static int IsTypeOf(string type)
		{
			return vtkStaticPointLocator.vtkStaticPointLocator_IsTypeOf_32(type);
		}

		// Token: 0x0601D0F0 RID: 119024
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_MergePoints_33(HandleRef pThis, double tol, IntPtr mergeMap);

		/// <summary>
		/// Merge points in the locator given a tolerance. Return a merge map which
		/// maps all points to the points to which they were merged. Note the number
		/// of points in the merge map is the number of points the locator was built
		/// with. The user is expected to pass in an allocated mergeMap. Note that
		/// when tol!=0, the traversal order of threading can be specified using the
		/// SetTraversalOrder() method. The traversal order is needed to generate
		/// deterministic output (i.e., output independent of thread execution
		/// order).
		/// </summary>
		// Token: 0x0601D0F1 RID: 119025 RVA: 0x0028FA16 File Offset: 0x0028DC16
		public void MergePoints(double tol, IntPtr mergeMap)
		{
			vtkStaticPointLocator.vtkStaticPointLocator_MergePoints_33(base.GetCppThis(), tol, mergeMap);
		}

		// Token: 0x0601D0F2 RID: 119026
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_MergePointsWithData_34(HandleRef pThis, HandleRef data, IntPtr mergeMap);

		/// <summary>
		/// Merge points and associated data in the locator. Return a merge map
		/// which maps all points to the points to which they were merged. Note the
		/// number of points in the merge map is the number of points the locator
		/// was built with. Merging occurs when both the points and the associated
		/// point data (represented by the data array) are equal. The user is
		/// expected to pass in an allocated mergeMap, and the size of the data
		/// array should be number of points in the locator. The data array may
		/// have an arbitrary number of components.
		/// </summary>
		// Token: 0x0601D0F3 RID: 119027 RVA: 0x0028FA28 File Offset: 0x0028DC28
		public void MergePointsWithData(vtkDataArray data, IntPtr mergeMap)
		{
			vtkStaticPointLocator.vtkStaticPointLocator_MergePointsWithData_34(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), mergeMap);
		}

		// Token: 0x0601D0F4 RID: 119028
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticPointLocator_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601D0F5 RID: 119029 RVA: 0x0028FA58 File Offset: 0x0028DC58
		public new vtkStaticPointLocator NewInstance()
		{
			vtkStaticPointLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStaticPointLocator.vtkStaticPointLocator_NewInstance_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStaticPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D0F6 RID: 119030
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticPointLocator_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601D0F7 RID: 119031 RVA: 0x0028FAB4 File Offset: 0x0028DCB4
		public new static vtkStaticPointLocator SafeDownCast(vtkObjectBase o)
		{
			vtkStaticPointLocator vtkStaticPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStaticPointLocator.vtkStaticPointLocator_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStaticPointLocator = (vtkStaticPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStaticPointLocator.Register(null);
				}
			}
			return vtkStaticPointLocator;
		}

		// Token: 0x0601D0F8 RID: 119032
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_SetDivisions_38(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set the number of divisions in x-y-z directions. If the Automatic data
		/// member is enabled, the Divisions are set according to the
		/// NumberOfPointsPerBucket and MaxNumberOfBuckets data members. The number
		/// of divisions must be &gt;= 1 in each direction.
		/// </summary>
		// Token: 0x0601D0F9 RID: 119033 RVA: 0x0028FB33 File Offset: 0x0028DD33
		public virtual void SetDivisions(int _arg1, int _arg2, int _arg3)
		{
			vtkStaticPointLocator.vtkStaticPointLocator_SetDivisions_38(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601D0FA RID: 119034
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_SetDivisions_39(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the number of divisions in x-y-z directions. If the Automatic data
		/// member is enabled, the Divisions are set according to the
		/// NumberOfPointsPerBucket and MaxNumberOfBuckets data members. The number
		/// of divisions must be &gt;= 1 in each direction.
		/// </summary>
		// Token: 0x0601D0FB RID: 119035 RVA: 0x0028FB45 File Offset: 0x0028DD45
		public virtual void SetDivisions(IntPtr _arg)
		{
			vtkStaticPointLocator.vtkStaticPointLocator_SetDivisions_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D0FC RID: 119036
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_SetMaxNumberOfBuckets_40(HandleRef pThis, long _arg);

		/// <summary>
		/// Set the maximum number of buckets in the locator. By default the value
		/// is set to VTK_INT_MAX. Note that there are significant performance
		/// implications at work here. If the number of buckets is set very large
		/// (meaning &gt; VTK_INT_MAX) then internal sorting may be performed using
		/// 64-bit integers (which is much slower than using a 32-bit int). Of
		/// course, memory requirements may dramatically increase as well.  It is
		/// recommended that the default value be used; but for extremely large data
		/// it may be desired to create a locator with an exceptionally large number
		/// of buckets. Note also that during initialization of the locator if the
		/// MaxNumberOfBuckets threshold is exceeded, the Divisions are scaled down
		/// in such a way as not to exceed the MaxNumberOfBuckets proportionally to
		/// the size of the bounding box in the x-y-z directions.
		/// </summary>
		// Token: 0x0601D0FD RID: 119037 RVA: 0x0028FB55 File Offset: 0x0028DD55
		public virtual void SetMaxNumberOfBuckets(long _arg)
		{
			vtkStaticPointLocator.vtkStaticPointLocator_SetMaxNumberOfBuckets_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D0FE RID: 119038
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_SetNumberOfPointsPerBucket_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the average number of points in each bucket. This data member is
		/// used in conjunction with the Automatic data member (if enabled) to
		/// determine the number of locator x-y-z divisions.
		/// </summary>
		// Token: 0x0601D0FF RID: 119039 RVA: 0x0028FB65 File Offset: 0x0028DD65
		public virtual void SetNumberOfPointsPerBucket(int _arg)
		{
			vtkStaticPointLocator.vtkStaticPointLocator_SetNumberOfPointsPerBucket_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D100 RID: 119040
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_SetTraversalOrder_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the manner in which points are processed when a non-zero merge
		/// tolerance is specified. By default, BIN_ORDER is used (i.e., threaded
		/// using bin checkerboard traversal) versus POINT_ORDER, which is a serial traversal.
		/// </summary>
		// Token: 0x0601D101 RID: 119041 RVA: 0x0028FB75 File Offset: 0x0028DD75
		public virtual void SetTraversalOrder(int _arg)
		{
			vtkStaticPointLocator.vtkStaticPointLocator_SetTraversalOrder_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D102 RID: 119042
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_SetTraversalOrderToBinOrder_43(HandleRef pThis);

		/// <summary>
		/// Specify the manner in which points are processed when a non-zero merge
		/// tolerance is specified. By default, BIN_ORDER is used (i.e., threaded
		/// using bin checkerboard traversal) versus POINT_ORDER, which is a serial traversal.
		/// </summary>
		// Token: 0x0601D103 RID: 119043 RVA: 0x0028FB85 File Offset: 0x0028DD85
		public void SetTraversalOrderToBinOrder()
		{
			vtkStaticPointLocator.vtkStaticPointLocator_SetTraversalOrderToBinOrder_43(base.GetCppThis());
		}

		// Token: 0x0601D104 RID: 119044
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator_SetTraversalOrderToPointOrder_44(HandleRef pThis);

		/// <summary>
		/// Specify the manner in which points are processed when a non-zero merge
		/// tolerance is specified. By default, BIN_ORDER is used (i.e., threaded
		/// using bin checkerboard traversal) versus POINT_ORDER, which is a serial traversal.
		/// </summary>
		// Token: 0x0601D105 RID: 119045 RVA: 0x0028FB94 File Offset: 0x0028DD94
		public void SetTraversalOrderToPointOrder()
		{
			vtkStaticPointLocator.vtkStaticPointLocator_SetTraversalOrderToPointOrder_44(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EB7 RID: 7863
		public new const string MRFullTypeName = "Kitware.VTK.vtkStaticPointLocator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EB8 RID: 7864
		public new static readonly string MRClassNameKey = "class vtkStaticPointLocator";

		/// <summary>
		/// Point merging is inherently an order-dependent process. Because naive
		/// threaded execution can non-deterministically change the ordering of
		/// merged points, threaded point merging for tolerances != 0.0 requires
		/// some level of serialization of the merging process to produce
		/// deterministic results. POINT_ORDER is completely serialized: two
		/// points with ids p0,p1 are merged if they are within tolerance of one
		/// another, with p1-&gt;p0 (p1 merged to p0) if p0&lt;p1. IN BIN_ORDER, a
		/// threaded checkerboarding approach is used so that p1-&gt;p0 when p0&lt;p1 in
		/// the local bin neighborhood and p1 not yet merged.
		/// </summary>
		// Token: 0x02000ACA RID: 2762
		public enum TraversalOrderType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001EBA RID: 7866
			BIN_ORDER = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001EBB RID: 7867
			POINT_ORDER = 0
		}
	}
}
