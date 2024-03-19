using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStaticPointLocator2D
	/// </summary>
	/// <remarks>
	///    quickly locate points in 2-space
	///
	/// vtkStaticPointLocator2D is a spatial search object to quickly locate points
	/// in 2D.  vtkStaticPointLocator2D works by dividing a specified region of
	/// space into a regular array of rectilinear buckets, and then keeping a
	/// list of points that lie in each bucket. Typical operation involves giving
	/// a position in 2D and finding the closest point; or finding the N closest
	/// points. (Note that the more general vtkStaticPointLocator is available
	/// for 3D operations.) Other specialized methods for 2D have also been provided.
	///
	/// vtkStaticPointLocator2D is an accelerated version of vtkPointLocator. It is
	/// threaded (via vtkSMPTools), and supports one-time static construction
	/// (i.e., incremental point insertion is not supported). If you need to
	/// incrementally insert points, use the vtkPointLocator or its kin to do so.
	///
	/// Note that to satisfy the superclass's API, methods often assume a 3D point
	/// is provided. However, only the x,y values are used for processing. The
	/// z-value is only used to define location of the 2D plane.
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
	/// </remarks>
	/// <seealso>
	///
	/// vtkStaticPointLocator vtkPointLocator vtkCellLocator vtkLocator
	/// vtkAbstractPointLocator
	/// </seealso>
	// Token: 0x02000ACB RID: 2763
	public class vtkStaticPointLocator2D : vtkAbstractPointLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D106 RID: 119046 RVA: 0x0028FBA3 File Offset: 0x0028DDA3
		static vtkStaticPointLocator2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStaticPointLocator2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStaticPointLocator2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D107 RID: 119047 RVA: 0x0028FBCB File Offset: 0x0028DDCB
		public vtkStaticPointLocator2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D108 RID: 119048
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticPointLocator2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with automatic computation of divisions, averaging
		/// 5 points per bucket.
		/// </summary>
		// Token: 0x0601D109 RID: 119049 RVA: 0x0028FBDC File Offset: 0x0028DDDC
		public new static vtkStaticPointLocator2D New()
		{
			vtkStaticPointLocator2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStaticPointLocator2D.vtkStaticPointLocator2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStaticPointLocator2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with automatic computation of divisions, averaging
		/// 5 points per bucket.
		/// </summary>
		// Token: 0x0601D10A RID: 119050 RVA: 0x0028FC30 File Offset: 0x0028DE30
		public vtkStaticPointLocator2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStaticPointLocator2D.vtkStaticPointLocator2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D10B RID: 119051 RVA: 0x0028FC74 File Offset: 0x0028DE74
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D10C RID: 119052
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator2D_BuildLocator_01(HandleRef pThis);

		/// <summary>
		/// See vtkLocator and vtkAbstractPointLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0601D10D RID: 119053 RVA: 0x0028FC7F File Offset: 0x0028DE7F
		public override void BuildLocator()
		{
			vtkStaticPointLocator2D.vtkStaticPointLocator2D_BuildLocator_01(base.GetCppThis());
		}

		// Token: 0x0601D10E RID: 119054
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStaticPointLocator2D_FindCloseNBoundedPoints_02(HandleRef pThis, int N, IntPtr x, HandleRef result);

		/// <summary>
		/// Special method for 2D operations (e.g., vtkVoronoi2D). The method
		/// returns the approximate number of points requested, returning the radius
		/// R of the furthest point, with the guarantee that all points are included
		/// that are closer than &lt;=R.
		/// </summary>
		// Token: 0x0601D10F RID: 119055 RVA: 0x0028FC90 File Offset: 0x0028DE90
		public double FindCloseNBoundedPoints(int N, IntPtr x, vtkIdList result)
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_FindCloseNBoundedPoints_02(base.GetCppThis(), N, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0601D110 RID: 119056
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator2D_FindClosestNPoints_03(HandleRef pThis, int N, IntPtr x, HandleRef result);

		/// <summary>
		/// Find the closest N points to a position. This returns the closest N
		/// points to a position. A faster method could be created that returned N
		/// close points to a position, but necessarily the exact N closest.  The
		/// returned points are sorted from closest to farthest.  These methods are
		/// thread safe if BuildLocator() is directly or indirectly called from a
		/// single thread first.
		/// </summary>
		// Token: 0x0601D111 RID: 119057 RVA: 0x0028FCC8 File Offset: 0x0028DEC8
		public override void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
		{
			vtkStaticPointLocator2D.vtkStaticPointLocator2D_FindClosestNPoints_03(base.GetCppThis(), N, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0601D112 RID: 119058
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator2D_FindClosestPoint_04(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Given a position x, return the id of the point closest to it. An
		/// alternative method (defined in the superclass) requires separate x-y-z
		/// values. These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first. (Note in the 2D locator
		/// the z-value is ignored.)
		/// </summary>
		// Token: 0x0601D113 RID: 119059 RVA: 0x0028FCFC File Offset: 0x0028DEFC
		public override long FindClosestPoint(IntPtr x)
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_FindClosestPoint_04(base.GetCppThis(), x);
		}

		// Token: 0x0601D114 RID: 119060
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator2D_FindClosestPointWithinRadius_05(HandleRef pThis, double radius, IntPtr x, ref double dist2);

		/// <summary>
		/// Given a position x and a radius r, return the id of the point closest to
		/// the point within that radius.  These methods are thread safe if
		/// BuildLocator() is directly or indirectly called from a single thread
		/// first. dist2 returns the squared distance to the point. Note that if multiple
		/// points are located the same distance away, the actual point returned is a
		/// function in which order the points are processed (i.e., indeterminate).
		/// </summary>
		// Token: 0x0601D115 RID: 119061 RVA: 0x0028FD1C File Offset: 0x0028DF1C
		public override long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_FindClosestPointWithinRadius_05(base.GetCppThis(), radius, x, ref dist2);
		}

		// Token: 0x0601D116 RID: 119062
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator2D_FindClosestPointWithinRadius_06(HandleRef pThis, double radius, IntPtr x, double inputDataLength, ref double dist2);

		/// <summary>
		/// Given a position x and a radius r, return the id of the point closest to
		/// the point within that radius.  These methods are thread safe if
		/// BuildLocator() is directly or indirectly called from a single thread
		/// first. dist2 returns the squared distance to the point. Note that if multiple
		/// points are located the same distance away, the actual point returned is a
		/// function in which order the points are processed (i.e., indeterminate).
		/// </summary>
		// Token: 0x0601D117 RID: 119063 RVA: 0x0028FD40 File Offset: 0x0028DF40
		public virtual long FindClosestPointWithinRadius(double radius, IntPtr x, double inputDataLength, ref double dist2)
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_FindClosestPointWithinRadius_06(base.GetCppThis(), radius, x, inputDataLength, ref dist2);
		}

		// Token: 0x0601D118 RID: 119064
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator2D_FindPointsWithinRadius_07(HandleRef pThis, double R, IntPtr x, HandleRef result);

		/// <summary>
		/// Find all points within a specified radius R of position x.
		/// The result is not sorted in any specific manner.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0601D119 RID: 119065 RVA: 0x0028FD64 File Offset: 0x0028DF64
		public override void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
		{
			vtkStaticPointLocator2D.vtkStaticPointLocator2D_FindPointsWithinRadius_07(base.GetCppThis(), R, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0601D11A RID: 119066
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator2D_ForceBuildLocator_08(HandleRef pThis);

		/// <summary>
		/// See vtkLocator and vtkAbstractPointLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0601D11B RID: 119067 RVA: 0x0028FD95 File Offset: 0x0028DF95
		public override void ForceBuildLocator()
		{
			vtkStaticPointLocator2D.vtkStaticPointLocator2D_ForceBuildLocator_08(base.GetCppThis());
		}

		// Token: 0x0601D11C RID: 119068
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator2D_FreeSearchStructure_09(HandleRef pThis);

		/// <summary>
		/// See vtkLocator and vtkAbstractPointLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0601D11D RID: 119069 RVA: 0x0028FDA4 File Offset: 0x0028DFA4
		public override void FreeSearchStructure()
		{
			vtkStaticPointLocator2D.vtkStaticPointLocator2D_FreeSearchStructure_09(base.GetCppThis());
		}

		// Token: 0x0601D11E RID: 119070
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator2D_GenerateRepresentation_10(HandleRef pThis, int level, HandleRef pd);

		/// <summary>
		/// Populate a polydata with the faces of the bins that potentially contain cells.
		/// Note that the level parameter has no effect on this method as there is no
		/// hierarchy built (i.e., uniform binning). Typically this is used for debugging.
		/// </summary>
		// Token: 0x0601D11F RID: 119071 RVA: 0x0028FDB4 File Offset: 0x0028DFB4
		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkStaticPointLocator2D.vtkStaticPointLocator2D_GenerateRepresentation_10(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0601D120 RID: 119072
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator2D_GetBounds_11(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Provide an accessor to the bounds. Valid after the locator is built.
		/// </summary>
		// Token: 0x0601D121 RID: 119073 RVA: 0x0028FDE4 File Offset: 0x0028DFE4
		public override void GetBounds(IntPtr bounds)
		{
			vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetBounds_11(base.GetCppThis(), bounds);
		}

		// Token: 0x0601D122 RID: 119074
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator2D_GetBucketIds_12(HandleRef pThis, long bNum, HandleRef bList);

		/// <summary>
		/// Given a bucket number bNum between 0 &lt;= bNum &lt; this-&gt;GetNumberOfBuckets(),
		/// return a list of point ids contained within the bucket. The user must
		/// provide an instance of vtkIdList to contain the result.
		/// </summary>
		// Token: 0x0601D123 RID: 119075 RVA: 0x0028FDF4 File Offset: 0x0028DFF4
		public void GetBucketIds(long bNum, vtkIdList bList)
		{
			vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetBucketIds_12(base.GetCppThis(), bNum, (bList == null) ? default(HandleRef) : bList.GetCppThis());
		}

		// Token: 0x0601D124 RID: 119076
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator2D_GetBucketIndex_13(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Given a point x[3], return the locator index (i,j) which contains the
		/// point. This method is meant to be fast, so error checking is not
		/// performed. This method should only be called after the locator is built.
		/// </summary>
		// Token: 0x0601D125 RID: 119077 RVA: 0x0028FE24 File Offset: 0x0028E024
		public long GetBucketIndex(IntPtr x)
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetBucketIndex_13(base.GetCppThis(), x);
		}

		// Token: 0x0601D126 RID: 119078
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator2D_GetBucketIndices_14(HandleRef pThis, IntPtr x, IntPtr ij);

		/// <summary>
		/// Given a point x[3], return the locator index (i,j) which contains the
		/// point. This method is meant to be fast, so error checking is not
		/// performed. This method should only be called after the locator is built.
		/// </summary>
		// Token: 0x0601D127 RID: 119079 RVA: 0x0028FE44 File Offset: 0x0028E044
		public void GetBucketIndices(IntPtr x, IntPtr ij)
		{
			vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetBucketIndices_14(base.GetCppThis(), x, ij);
		}

		// Token: 0x0601D128 RID: 119080
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticPointLocator2D_GetDivisions_15(HandleRef pThis);

		/// <summary>
		/// Set the number of divisions in x-y directions. If the Automatic data
		/// member is enabled, the Divisions are set according to the
		/// NumberOfPointsPerBucket and MaxNumberOfBuckets data members. The number
		/// of divisions must be &gt;= 1 in each direction.
		/// </summary>
		// Token: 0x0601D129 RID: 119081 RVA: 0x0028FE58 File Offset: 0x0028E058
		public virtual int[] GetDivisions()
		{
			IntPtr intPtr = vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetDivisions_15(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601D12A RID: 119082
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator2D_GetDivisions_16(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the number of divisions in x-y directions. If the Automatic data
		/// member is enabled, the Divisions are set according to the
		/// NumberOfPointsPerBucket and MaxNumberOfBuckets data members. The number
		/// of divisions must be &gt;= 1 in each direction.
		/// </summary>
		// Token: 0x0601D12B RID: 119083 RVA: 0x0028FEA0 File Offset: 0x0028E0A0
		public virtual void GetDivisions(IntPtr data)
		{
			vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetDivisions_16(base.GetCppThis(), data);
		}

		// Token: 0x0601D12C RID: 119084
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStaticPointLocator2D_GetLargeIds_17(HandleRef pThis);

		/// <summary>
		/// Inform the user as to whether large ids are being used. This flag only
		/// has meaning after the locator has been built. Large ids are used when the
		/// number of binned points, or the number of bins, is &gt;= the maximum number
		/// of buckets (specified by the user). Note that LargeIds are only available
		/// on 64-bit architectures.
		/// </summary>
		// Token: 0x0601D12D RID: 119085 RVA: 0x0028FEB0 File Offset: 0x0028E0B0
		public bool GetLargeIds()
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetLargeIds_17(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D12E RID: 119086
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator2D_GetMaxNumberOfBuckets_18(HandleRef pThis);

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
		// Token: 0x0601D12F RID: 119087 RVA: 0x0028FED8 File Offset: 0x0028E0D8
		public virtual long GetMaxNumberOfBuckets()
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetMaxNumberOfBuckets_18(base.GetCppThis());
		}

		// Token: 0x0601D130 RID: 119088
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator2D_GetMaxNumberOfBucketsMaxValue_19(HandleRef pThis);

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
		// Token: 0x0601D131 RID: 119089 RVA: 0x0028FEF8 File Offset: 0x0028E0F8
		public virtual long GetMaxNumberOfBucketsMaxValue()
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetMaxNumberOfBucketsMaxValue_19(base.GetCppThis());
		}

		// Token: 0x0601D132 RID: 119090
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator2D_GetMaxNumberOfBucketsMinValue_20(HandleRef pThis);

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
		// Token: 0x0601D133 RID: 119091 RVA: 0x0028FF18 File Offset: 0x0028E118
		public virtual long GetMaxNumberOfBucketsMinValue()
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetMaxNumberOfBucketsMinValue_20(base.GetCppThis());
		}

		// Token: 0x0601D134 RID: 119092
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator2D_GetNumberOfGenerationsFromBase_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601D135 RID: 119093 RVA: 0x0028FF38 File Offset: 0x0028E138
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetNumberOfGenerationsFromBase_21(base.GetCppThis(), type);
		}

		// Token: 0x0601D136 RID: 119094
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator2D_GetNumberOfGenerationsFromBaseType_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601D137 RID: 119095 RVA: 0x0028FF58 File Offset: 0x0028E158
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetNumberOfGenerationsFromBaseType_22(type);
		}

		// Token: 0x0601D138 RID: 119096
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticPointLocator2D_GetNumberOfPointsInBucket_23(HandleRef pThis, long bNum);

		/// <summary>
		/// Given a bucket number bNum between 0 &lt;= bNum &lt; this-&gt;GetNumberOfBuckets(),
		/// return the number of points found in the bucket. Note that a bucket can
		/// also be specified with locator indices (i,j) which converts to a the
		/// bucket number bNum=i+this-&gt;Divisions[0]*j.
		/// </summary>
		// Token: 0x0601D139 RID: 119097 RVA: 0x0028FF74 File Offset: 0x0028E174
		public long GetNumberOfPointsInBucket(long bNum)
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetNumberOfPointsInBucket_23(base.GetCppThis(), bNum);
		}

		// Token: 0x0601D13A RID: 119098
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticPointLocator2D_GetNumberOfPointsPerBucket_24(HandleRef pThis);

		/// <summary>
		/// Specify the average number of points in each bucket. This data member is
		/// used in conjunction with the Automatic data member (if enabled) to
		/// determine the number of locator x-y divisions.
		/// </summary>
		// Token: 0x0601D13B RID: 119099 RVA: 0x0028FF94 File Offset: 0x0028E194
		public virtual int GetNumberOfPointsPerBucket()
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetNumberOfPointsPerBucket_24(base.GetCppThis());
		}

		// Token: 0x0601D13C RID: 119100
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticPointLocator2D_GetNumberOfPointsPerBucketMaxValue_25(HandleRef pThis);

		/// <summary>
		/// Specify the average number of points in each bucket. This data member is
		/// used in conjunction with the Automatic data member (if enabled) to
		/// determine the number of locator x-y divisions.
		/// </summary>
		// Token: 0x0601D13D RID: 119101 RVA: 0x0028FFB4 File Offset: 0x0028E1B4
		public virtual int GetNumberOfPointsPerBucketMaxValue()
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetNumberOfPointsPerBucketMaxValue_25(base.GetCppThis());
		}

		// Token: 0x0601D13E RID: 119102
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticPointLocator2D_GetNumberOfPointsPerBucketMinValue_26(HandleRef pThis);

		/// <summary>
		/// Specify the average number of points in each bucket. This data member is
		/// used in conjunction with the Automatic data member (if enabled) to
		/// determine the number of locator x-y divisions.
		/// </summary>
		// Token: 0x0601D13F RID: 119103 RVA: 0x0028FFD4 File Offset: 0x0028E1D4
		public virtual int GetNumberOfPointsPerBucketMinValue()
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetNumberOfPointsPerBucketMinValue_26(base.GetCppThis());
		}

		// Token: 0x0601D140 RID: 119104
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticPointLocator2D_GetSpacing_27(HandleRef pThis);

		/// <summary>
		/// Provide an accessor to the bucket spacing. Valid after the locator is
		/// built.
		/// </summary>
		// Token: 0x0601D141 RID: 119105 RVA: 0x0028FFF4 File Offset: 0x0028E1F4
		public virtual IntPtr GetSpacing()
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetSpacing_27(base.GetCppThis());
		}

		// Token: 0x0601D142 RID: 119106
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator2D_GetSpacing_28(HandleRef pThis, IntPtr spacing);

		/// <summary>
		/// Provide an accessor to the bucket spacing. Valid after the locator is
		/// built.
		/// </summary>
		// Token: 0x0601D143 RID: 119107 RVA: 0x00290013 File Offset: 0x0028E213
		public virtual void GetSpacing(IntPtr spacing)
		{
			vtkStaticPointLocator2D.vtkStaticPointLocator2D_GetSpacing_28(base.GetCppThis(), spacing);
		}

		// Token: 0x0601D144 RID: 119108
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator2D_Initialize_29(HandleRef pThis);

		/// <summary>
		/// See vtkLocator and vtkAbstractPointLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0601D145 RID: 119109 RVA: 0x00290023 File Offset: 0x0028E223
		public override void Initialize()
		{
			vtkStaticPointLocator2D.vtkStaticPointLocator2D_Initialize_29(base.GetCppThis());
		}

		// Token: 0x0601D146 RID: 119110
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticPointLocator2D_IntersectWithLine_30(HandleRef pThis, IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr lineX, IntPtr ptX, ref long ptId);

		/// <summary>
		/// Intersect the points contained in the locator with the line defined by
		/// (a0,a1). Return the point within the tolerance tol that is closest to a0
		/// (tol measured in the world coordinate system). If an intersection occurs
		/// (i.e., the method returns nonzero), then the parametric location along
		/// the line t, the closest position along the line lineX, and the coordinates
		/// of the picked ptId is returned in ptX. (This method is thread safe after
		/// the locator is built.)
		/// </summary>
		// Token: 0x0601D147 RID: 119111 RVA: 0x00290034 File Offset: 0x0028E234
		public int IntersectWithLine(IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr lineX, IntPtr ptX, ref long ptId)
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_IntersectWithLine_30(base.GetCppThis(), a0, a1, tol, ref t, lineX, ptX, ref ptId);
		}

		// Token: 0x0601D148 RID: 119112
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticPointLocator2D_IsA_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601D149 RID: 119113 RVA: 0x00290060 File Offset: 0x0028E260
		public override int IsA(string type)
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_IsA_31(base.GetCppThis(), type);
		}

		// Token: 0x0601D14A RID: 119114
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticPointLocator2D_IsTypeOf_32([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601D14B RID: 119115 RVA: 0x00290080 File Offset: 0x0028E280
		public new static int IsTypeOf(string type)
		{
			return vtkStaticPointLocator2D.vtkStaticPointLocator2D_IsTypeOf_32(type);
		}

		// Token: 0x0601D14C RID: 119116
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator2D_MergePoints_33(HandleRef pThis, double tol, IntPtr mergeMap);

		/// <summary>
		/// Merge points in the locator given a tolerance. Return a merge map which
		/// represents the mapping of "concident" point ids to a single point. Note
		/// the number of points in the merge map is the number of points the
		/// locator was built with. The user is expected to pass in an allocated
		/// mergeMap.
		/// </summary>
		// Token: 0x0601D14D RID: 119117 RVA: 0x0029009A File Offset: 0x0028E29A
		public void MergePoints(double tol, IntPtr mergeMap)
		{
			vtkStaticPointLocator2D.vtkStaticPointLocator2D_MergePoints_33(base.GetCppThis(), tol, mergeMap);
		}

		// Token: 0x0601D14E RID: 119118
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticPointLocator2D_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601D14F RID: 119119 RVA: 0x002900AC File Offset: 0x0028E2AC
		public new vtkStaticPointLocator2D NewInstance()
		{
			vtkStaticPointLocator2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStaticPointLocator2D.vtkStaticPointLocator2D_NewInstance_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStaticPointLocator2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D150 RID: 119120
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticPointLocator2D_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601D151 RID: 119121 RVA: 0x00290108 File Offset: 0x0028E308
		public new static vtkStaticPointLocator2D SafeDownCast(vtkObjectBase o)
		{
			vtkStaticPointLocator2D vtkStaticPointLocator2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStaticPointLocator2D.vtkStaticPointLocator2D_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStaticPointLocator2D = (vtkStaticPointLocator2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStaticPointLocator2D.Register(null);
				}
			}
			return vtkStaticPointLocator2D;
		}

		// Token: 0x0601D152 RID: 119122
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator2D_SetDivisions_37(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set the number of divisions in x-y directions. If the Automatic data
		/// member is enabled, the Divisions are set according to the
		/// NumberOfPointsPerBucket and MaxNumberOfBuckets data members. The number
		/// of divisions must be &gt;= 1 in each direction.
		/// </summary>
		// Token: 0x0601D153 RID: 119123 RVA: 0x00290187 File Offset: 0x0028E387
		public virtual void SetDivisions(int _arg1, int _arg2)
		{
			vtkStaticPointLocator2D.vtkStaticPointLocator2D_SetDivisions_37(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0601D154 RID: 119124
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator2D_SetDivisions_38(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the number of divisions in x-y directions. If the Automatic data
		/// member is enabled, the Divisions are set according to the
		/// NumberOfPointsPerBucket and MaxNumberOfBuckets data members. The number
		/// of divisions must be &gt;= 1 in each direction.
		/// </summary>
		// Token: 0x0601D155 RID: 119125 RVA: 0x00290198 File Offset: 0x0028E398
		public void SetDivisions(IntPtr _arg)
		{
			vtkStaticPointLocator2D.vtkStaticPointLocator2D_SetDivisions_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D156 RID: 119126
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator2D_SetMaxNumberOfBuckets_39(HandleRef pThis, long _arg);

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
		// Token: 0x0601D157 RID: 119127 RVA: 0x002901A8 File Offset: 0x0028E3A8
		public virtual void SetMaxNumberOfBuckets(long _arg)
		{
			vtkStaticPointLocator2D.vtkStaticPointLocator2D_SetMaxNumberOfBuckets_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D158 RID: 119128
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticPointLocator2D_SetNumberOfPointsPerBucket_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the average number of points in each bucket. This data member is
		/// used in conjunction with the Automatic data member (if enabled) to
		/// determine the number of locator x-y divisions.
		/// </summary>
		// Token: 0x0601D159 RID: 119129 RVA: 0x002901B8 File Offset: 0x0028E3B8
		public virtual void SetNumberOfPointsPerBucket(int _arg)
		{
			vtkStaticPointLocator2D.vtkStaticPointLocator2D_SetNumberOfPointsPerBucket_40(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EBC RID: 7868
		public new const string MRFullTypeName = "Kitware.VTK.vtkStaticPointLocator2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EBD RID: 7869
		public new static readonly string MRClassNameKey = "class vtkStaticPointLocator2D";
	}
}
