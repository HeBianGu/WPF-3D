using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointLocator
	/// </summary>
	/// <remarks>
	///    quickly locate points in 3-space
	///
	/// vtkPointLocator is a spatial search object to quickly locate points in 3D.
	/// vtkPointLocator works by dividing a specified region of space into a regular
	/// array of "rectangular" buckets, and then keeping a list of points that
	/// lie in each bucket. Typical operation involves giving a position in 3D
	/// and finding the closest point.
	///
	/// vtkPointLocator has two distinct methods of interaction. In the first
	/// method, you supply it with a dataset, and it operates on the points in
	/// the dataset. In the second method, you supply it with an array of points,
	/// and the object operates on the array.
	///
	/// @warning
	/// Many other types of spatial locators have been developed such as
	/// octrees and kd-trees. These are often more efficient for the
	/// operations described here.
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
	/// vtkCellPicker vtkPointPicker vtkStaticPointLocator
	/// </seealso>
	// Token: 0x02000422 RID: 1058
	public class vtkPointLocator : vtkIncrementalPointLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C75D RID: 51037 RVA: 0x001153EB File Offset: 0x001135EB
		static vtkPointLocator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointLocator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C75E RID: 51038 RVA: 0x00115413 File Offset: 0x00113613
		public vtkPointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C75F RID: 51039
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with automatic computation of divisions, averaging
		/// 25 points per bucket.
		/// </summary>
		// Token: 0x0600C760 RID: 51040 RVA: 0x00115424 File Offset: 0x00113624
		public new static vtkPointLocator New()
		{
			vtkPointLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointLocator.vtkPointLocator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with automatic computation of divisions, averaging
		/// 25 points per bucket.
		/// </summary>
		// Token: 0x0600C761 RID: 51041 RVA: 0x00115478 File Offset: 0x00113678
		public vtkPointLocator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointLocator.vtkPointLocator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C762 RID: 51042 RVA: 0x001154BC File Offset: 0x001136BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C763 RID: 51043
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLocator_BuildLocator_01(HandleRef pThis);

		/// <summary>
		/// See vtkLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0600C764 RID: 51044 RVA: 0x001154C7 File Offset: 0x001136C7
		public override void BuildLocator()
		{
			vtkPointLocator.vtkPointLocator_BuildLocator_01(base.GetCppThis());
		}

		// Token: 0x0600C765 RID: 51045
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointLocator_FindClosestInsertedPoint_02(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Given a position x, return the id of the point closest to it. This method
		/// is used when performing incremental point insertion. Note that -1
		/// indicates that no point was found.
		/// This method is thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0600C766 RID: 51046 RVA: 0x001154D8 File Offset: 0x001136D8
		public override long FindClosestInsertedPoint(IntPtr x)
		{
			return vtkPointLocator.vtkPointLocator_FindClosestInsertedPoint_02(base.GetCppThis(), x);
		}

		// Token: 0x0600C767 RID: 51047
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLocator_FindClosestNPoints_03(HandleRef pThis, int N, IntPtr x, HandleRef result);

		/// <summary>
		/// Find the closest N points to a position. This returns the closest
		/// N points to a position. A faster method could be created that returned
		/// N close points to a position, but necessarily the exact N closest.
		/// The returned points are sorted from closest to farthest.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0600C768 RID: 51048 RVA: 0x001154F8 File Offset: 0x001136F8
		public override void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
		{
			vtkPointLocator.vtkPointLocator_FindClosestNPoints_03(base.GetCppThis(), N, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0600C769 RID: 51049
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointLocator_FindClosestPoint_04(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Given a position x, return the id of the point closest to it. Alternative
		/// method requires separate x-y-z values.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0600C76A RID: 51050 RVA: 0x0011552C File Offset: 0x0011372C
		public override long FindClosestPoint(IntPtr x)
		{
			return vtkPointLocator.vtkPointLocator_FindClosestPoint_04(base.GetCppThis(), x);
		}

		// Token: 0x0600C76B RID: 51051
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointLocator_FindClosestPointWithinRadius_05(HandleRef pThis, double radius, IntPtr x, ref double dist2);

		/// <summary>
		/// Given a position x and a radius r, return the id of the point
		/// closest to the point in that radius.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first. dist2 returns the squared
		/// distance to the point.
		/// </summary>
		// Token: 0x0600C76C RID: 51052 RVA: 0x0011554C File Offset: 0x0011374C
		public override long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
		{
			return vtkPointLocator.vtkPointLocator_FindClosestPointWithinRadius_05(base.GetCppThis(), radius, x, ref dist2);
		}

		// Token: 0x0600C76D RID: 51053
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointLocator_FindClosestPointWithinRadius_06(HandleRef pThis, double radius, IntPtr x, double inputDataLength, ref double dist2);

		/// <summary>
		/// Given a position x and a radius r, return the id of the point
		/// closest to the point in that radius.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first. dist2 returns the squared
		/// distance to the point.
		/// </summary>
		// Token: 0x0600C76E RID: 51054 RVA: 0x00115570 File Offset: 0x00113770
		public virtual long FindClosestPointWithinRadius(double radius, IntPtr x, double inputDataLength, ref double dist2)
		{
			return vtkPointLocator.vtkPointLocator_FindClosestPointWithinRadius_06(base.GetCppThis(), radius, x, inputDataLength, ref dist2);
		}

		// Token: 0x0600C76F RID: 51055
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLocator_FindDistributedPoints_07(HandleRef pThis, int N, IntPtr x, HandleRef result, int M);

		/// <summary>
		/// Find the closest points to a position such that each octant of
		/// space around the position contains at least N points. Loosely
		/// limit the search to a maximum number of points evaluated, M.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0600C770 RID: 51056 RVA: 0x00115594 File Offset: 0x00113794
		public virtual void FindDistributedPoints(int N, IntPtr x, vtkIdList result, int M)
		{
			vtkPointLocator.vtkPointLocator_FindDistributedPoints_07(base.GetCppThis(), N, x, (result == null) ? default(HandleRef) : result.GetCppThis(), M);
		}

		// Token: 0x0600C771 RID: 51057
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLocator_FindDistributedPoints_08(HandleRef pThis, int N, double x, double y, double z, HandleRef result, int M);

		/// <summary>
		/// Find the closest points to a position such that each octant of
		/// space around the position contains at least N points. Loosely
		/// limit the search to a maximum number of points evaluated, M.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0600C772 RID: 51058 RVA: 0x001155C8 File Offset: 0x001137C8
		public virtual void FindDistributedPoints(int N, double x, double y, double z, vtkIdList result, int M)
		{
			vtkPointLocator.vtkPointLocator_FindDistributedPoints_08(base.GetCppThis(), N, x, y, z, (result == null) ? default(HandleRef) : result.GetCppThis(), M);
		}

		// Token: 0x0600C773 RID: 51059
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLocator_FindPointsWithinRadius_09(HandleRef pThis, double R, IntPtr x, HandleRef result);

		/// <summary>
		/// Find all points within a specified radius R of position x.
		/// The result is not sorted in any specific manner.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0600C774 RID: 51060 RVA: 0x00115600 File Offset: 0x00113800
		public override void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
		{
			vtkPointLocator.vtkPointLocator_FindPointsWithinRadius_09(base.GetCppThis(), R, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0600C775 RID: 51061
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLocator_ForceBuildLocator_10(HandleRef pThis);

		/// <summary>
		/// See vtkLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0600C776 RID: 51062 RVA: 0x00115631 File Offset: 0x00113831
		public override void ForceBuildLocator()
		{
			vtkPointLocator.vtkPointLocator_ForceBuildLocator_10(base.GetCppThis());
		}

		// Token: 0x0600C777 RID: 51063
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLocator_FreeSearchStructure_11(HandleRef pThis);

		/// <summary>
		/// See vtkLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0600C778 RID: 51064 RVA: 0x00115640 File Offset: 0x00113840
		public override void FreeSearchStructure()
		{
			vtkPointLocator.vtkPointLocator_FreeSearchStructure_11(base.GetCppThis());
		}

		// Token: 0x0600C779 RID: 51065
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLocator_GenerateRepresentation_12(HandleRef pThis, int level, HandleRef pd);

		/// <summary>
		/// See vtkLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0600C77A RID: 51066 RVA: 0x00115650 File Offset: 0x00113850
		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkPointLocator.vtkPointLocator_GenerateRepresentation_12(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600C77B RID: 51067
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointLocator_GetDivisions_13(HandleRef pThis);

		/// <summary>
		/// Set the number of divisions in x-y-z directions.
		/// </summary>
		// Token: 0x0600C77C RID: 51068 RVA: 0x00115680 File Offset: 0x00113880
		public virtual int[] GetDivisions()
		{
			IntPtr intPtr = vtkPointLocator.vtkPointLocator_GetDivisions_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C77D RID: 51069
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLocator_GetDivisions_14(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the number of divisions in x-y-z directions.
		/// </summary>
		// Token: 0x0600C77E RID: 51070 RVA: 0x001156C8 File Offset: 0x001138C8
		public virtual void GetDivisions(IntPtr data)
		{
			vtkPointLocator.vtkPointLocator_GetDivisions_14(base.GetCppThis(), data);
		}

		// Token: 0x0600C77F RID: 51071
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointLocator_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type management and printing.
		/// </summary>
		// Token: 0x0600C780 RID: 51072 RVA: 0x001156D8 File Offset: 0x001138D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointLocator.vtkPointLocator_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x0600C781 RID: 51073
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointLocator_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type management and printing.
		/// </summary>
		// Token: 0x0600C782 RID: 51074 RVA: 0x001156F8 File Offset: 0x001138F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointLocator.vtkPointLocator_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x0600C783 RID: 51075
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointLocator_GetNumberOfPointsPerBucket_17(HandleRef pThis);

		/// <summary>
		/// Specify the average number of points in each bucket.
		/// </summary>
		// Token: 0x0600C784 RID: 51076 RVA: 0x00115714 File Offset: 0x00113914
		public virtual int GetNumberOfPointsPerBucket()
		{
			return vtkPointLocator.vtkPointLocator_GetNumberOfPointsPerBucket_17(base.GetCppThis());
		}

		// Token: 0x0600C785 RID: 51077
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointLocator_GetNumberOfPointsPerBucketMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Specify the average number of points in each bucket.
		/// </summary>
		// Token: 0x0600C786 RID: 51078 RVA: 0x00115734 File Offset: 0x00113934
		public virtual int GetNumberOfPointsPerBucketMaxValue()
		{
			return vtkPointLocator.vtkPointLocator_GetNumberOfPointsPerBucketMaxValue_18(base.GetCppThis());
		}

		// Token: 0x0600C787 RID: 51079
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointLocator_GetNumberOfPointsPerBucketMinValue_19(HandleRef pThis);

		/// <summary>
		/// Specify the average number of points in each bucket.
		/// </summary>
		// Token: 0x0600C788 RID: 51080 RVA: 0x00115754 File Offset: 0x00113954
		public virtual int GetNumberOfPointsPerBucketMinValue()
		{
			return vtkPointLocator.vtkPointLocator_GetNumberOfPointsPerBucketMinValue_19(base.GetCppThis());
		}

		// Token: 0x0600C789 RID: 51081
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointLocator_GetPoints_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Provide an accessor to the points.
		/// </summary>
		// Token: 0x0600C78A RID: 51082 RVA: 0x00115774 File Offset: 0x00113974
		public virtual vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointLocator.vtkPointLocator_GetPoints_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x0600C78B RID: 51083
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointLocator_GetPointsInBucket_21(HandleRef pThis, IntPtr x, IntPtr ijk, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a position x, return the list of points in the bucket that
		/// contains the point. It is possible that nullptr is returned. The user
		/// provides an ijk array that is the indices into the locator.
		/// This method is thread safe.
		/// </summary>
		// Token: 0x0600C78C RID: 51084 RVA: 0x001157E4 File Offset: 0x001139E4
		public virtual vtkIdList GetPointsInBucket(IntPtr x, IntPtr ijk)
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointLocator.vtkPointLocator_GetPointsInBucket_21(base.GetCppThis(), x, ijk, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		// Token: 0x0600C78D RID: 51085
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointLocator_InitPointInsertion_22(HandleRef pThis, HandleRef newPts, IntPtr bounds);

		/// <summary>
		/// Initialize the point insertion process. The newPts is an object
		/// representing point coordinates into which incremental insertion methods
		/// place their data. Bounds are the box that the points lie in.
		/// Not thread safe.
		/// </summary>
		// Token: 0x0600C78E RID: 51086 RVA: 0x00115858 File Offset: 0x00113A58
		public override int InitPointInsertion(vtkPoints newPts, IntPtr bounds)
		{
			return vtkPointLocator.vtkPointLocator_InitPointInsertion_22(base.GetCppThis(), (newPts == null) ? default(HandleRef) : newPts.GetCppThis(), bounds);
		}

		// Token: 0x0600C78F RID: 51087
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointLocator_InitPointInsertion_23(HandleRef pThis, HandleRef newPts, IntPtr bounds, long estNumPts);

		/// <summary>
		/// Initialize the point insertion process. The newPts is an object
		/// representing point coordinates into which incremental insertion methods
		/// place their data. Bounds are the box that the points lie in.
		/// Not thread safe.
		/// </summary>
		// Token: 0x0600C790 RID: 51088 RVA: 0x00115890 File Offset: 0x00113A90
		public override int InitPointInsertion(vtkPoints newPts, IntPtr bounds, long estNumPts)
		{
			return vtkPointLocator.vtkPointLocator_InitPointInsertion_23(base.GetCppThis(), (newPts == null) ? default(HandleRef) : newPts.GetCppThis(), bounds, estNumPts);
		}

		// Token: 0x0600C791 RID: 51089
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLocator_Initialize_24(HandleRef pThis);

		/// <summary>
		/// See vtkLocator interface documentation.
		/// These methods are not thread safe.
		/// </summary>
		// Token: 0x0600C792 RID: 51090 RVA: 0x001158C6 File Offset: 0x00113AC6
		public override void Initialize()
		{
			vtkPointLocator.vtkPointLocator_Initialize_24(base.GetCppThis());
		}

		// Token: 0x0600C793 RID: 51091
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointLocator_InsertNextPoint_25(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Incrementally insert a point into search structure. The method returns
		/// the insertion location (i.e., point id). You should use the method
		/// IsInsertedPoint() to see whether this point has already been
		/// inserted (that is, if you desire to prevent duplicate points).
		/// Before using this method you must make sure that newPts have been
		/// supplied, the bounds has been set properly, and that divs are
		/// properly set. (See InitPointInsertion().)
		/// Not thread safe.
		/// </summary>
		// Token: 0x0600C794 RID: 51092 RVA: 0x001158D8 File Offset: 0x00113AD8
		public override long InsertNextPoint(IntPtr x)
		{
			return vtkPointLocator.vtkPointLocator_InsertNextPoint_25(base.GetCppThis(), x);
		}

		// Token: 0x0600C795 RID: 51093
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLocator_InsertPoint_26(HandleRef pThis, long ptId, IntPtr x);

		/// <summary>
		/// Incrementally insert a point into search structure with a particular
		/// index value. You should use the method IsInsertedPoint() to see whether
		/// this point has already been inserted (that is, if you desire to prevent
		/// duplicate points). Before using this method you must make sure that
		/// newPts have been supplied, the bounds has been set properly, and that
		/// divs are properly set. (See InitPointInsertion().)
		/// Not thread safe.
		/// </summary>
		// Token: 0x0600C796 RID: 51094 RVA: 0x001158F8 File Offset: 0x00113AF8
		public override void InsertPoint(long ptId, IntPtr x)
		{
			vtkPointLocator.vtkPointLocator_InsertPoint_26(base.GetCppThis(), ptId, x);
		}

		// Token: 0x0600C797 RID: 51095
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointLocator_InsertUniquePoint_27(HandleRef pThis, IntPtr x, ref long ptId);

		/// <summary>
		/// Determine whether point given by x[3] has been inserted into points list.
		/// Return 0 if point was already in the list, otherwise return 1. If the
		/// point was not in the list, it will be ADDED.  In either case, the id of
		/// the point (newly inserted or not) is returned in the ptId argument.
		/// Note this combines the functionality of IsInsertedPoint() followed
		/// by a call to InsertNextPoint().
		/// This method is not thread safe.
		/// </summary>
		// Token: 0x0600C798 RID: 51096 RVA: 0x0011590C File Offset: 0x00113B0C
		public override int InsertUniquePoint(IntPtr x, ref long ptId)
		{
			return vtkPointLocator.vtkPointLocator_InsertUniquePoint_27(base.GetCppThis(), x, ref ptId);
		}

		// Token: 0x0600C799 RID: 51097
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointLocator_IsA_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type management and printing.
		/// </summary>
		// Token: 0x0600C79A RID: 51098 RVA: 0x00115930 File Offset: 0x00113B30
		public override int IsA(string type)
		{
			return vtkPointLocator.vtkPointLocator_IsA_28(base.GetCppThis(), type);
		}

		// Token: 0x0600C79B RID: 51099
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointLocator_IsInsertedPoint_29(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Determine whether point given by x[3] has been inserted into points list.
		/// Return id of previously inserted point if this is true, otherwise return
		/// -1. This method is thread safe.
		/// </summary>
		// Token: 0x0600C79C RID: 51100 RVA: 0x00115950 File Offset: 0x00113B50
		public override long IsInsertedPoint(double x, double y, double z)
		{
			return vtkPointLocator.vtkPointLocator_IsInsertedPoint_29(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600C79D RID: 51101
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointLocator_IsInsertedPoint_30(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Determine whether point given by x[3] has been inserted into points list.
		/// Return id of previously inserted point if this is true, otherwise return
		/// -1. This method is thread safe.
		/// </summary>
		// Token: 0x0600C79E RID: 51102 RVA: 0x00115974 File Offset: 0x00113B74
		public override long IsInsertedPoint(IntPtr x)
		{
			return vtkPointLocator.vtkPointLocator_IsInsertedPoint_30(base.GetCppThis(), x);
		}

		// Token: 0x0600C79F RID: 51103
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointLocator_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type management and printing.
		/// </summary>
		// Token: 0x0600C7A0 RID: 51104 RVA: 0x00115994 File Offset: 0x00113B94
		public new static int IsTypeOf(string type)
		{
			return vtkPointLocator.vtkPointLocator_IsTypeOf_31(type);
		}

		// Token: 0x0600C7A1 RID: 51105
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointLocator_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type management and printing.
		/// </summary>
		// Token: 0x0600C7A2 RID: 51106 RVA: 0x001159B0 File Offset: 0x00113BB0
		public new vtkPointLocator NewInstance()
		{
			vtkPointLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointLocator.vtkPointLocator_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C7A3 RID: 51107
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointLocator_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type management and printing.
		/// </summary>
		// Token: 0x0600C7A4 RID: 51108 RVA: 0x00115A0C File Offset: 0x00113C0C
		public new static vtkPointLocator SafeDownCast(vtkObjectBase o)
		{
			vtkPointLocator vtkPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointLocator.vtkPointLocator_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointLocator = (vtkPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointLocator.Register(null);
				}
			}
			return vtkPointLocator;
		}

		// Token: 0x0600C7A5 RID: 51109
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLocator_SetDivisions_35(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set the number of divisions in x-y-z directions.
		/// </summary>
		// Token: 0x0600C7A6 RID: 51110 RVA: 0x00115A8B File Offset: 0x00113C8B
		public virtual void SetDivisions(int _arg1, int _arg2, int _arg3)
		{
			vtkPointLocator.vtkPointLocator_SetDivisions_35(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600C7A7 RID: 51111
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLocator_SetDivisions_36(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the number of divisions in x-y-z directions.
		/// </summary>
		// Token: 0x0600C7A8 RID: 51112 RVA: 0x00115A9D File Offset: 0x00113C9D
		public virtual void SetDivisions(IntPtr _arg)
		{
			vtkPointLocator.vtkPointLocator_SetDivisions_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C7A9 RID: 51113
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointLocator_SetNumberOfPointsPerBucket_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the average number of points in each bucket.
		/// </summary>
		// Token: 0x0600C7AA RID: 51114 RVA: 0x00115AAD File Offset: 0x00113CAD
		public virtual void SetNumberOfPointsPerBucket(int _arg)
		{
			vtkPointLocator.vtkPointLocator_SetNumberOfPointsPerBucket_37(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ED5 RID: 3797
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointLocator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ED6 RID: 3798
		public new static readonly string MRClassNameKey = "class vtkPointLocator";
	}
}
