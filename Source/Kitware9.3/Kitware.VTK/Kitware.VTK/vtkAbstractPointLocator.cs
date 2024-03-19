using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractPointLocator
	/// </summary>
	/// <remarks>
	///    abstract class to quickly locate points in 3-space
	///
	/// vtkAbstractPointLocator is an abstract spatial search object to quickly locate points
	/// in 3D. vtkAbstractPointLocator works by dividing a specified region of space into
	/// "rectangular" buckets, and then keeping a list of points that
	/// lie in each bucket. Typical operation involves giving a position in 3D
	/// and finding the closest point.  The points are provided from the specified
	/// dataset input.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointLocator vtkStaticPointLocator vtkMergePoints
	/// </seealso>
	// Token: 0x02000420 RID: 1056
	public abstract class vtkAbstractPointLocator : vtkLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C71B RID: 50971 RVA: 0x00114E06 File Offset: 0x00113006
		static vtkAbstractPointLocator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractPointLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractPointLocator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C71C RID: 50972 RVA: 0x00114E2E File Offset: 0x0011302E
		public vtkAbstractPointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C71D RID: 50973 RVA: 0x00114E3C File Offset: 0x0011303C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C71E RID: 50974
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPointLocator_FindClosestNPoints_01(HandleRef pThis, int N, IntPtr x, HandleRef result);

		/// <summary>
		/// Find the closest N points to a position. This returns the closest
		/// N points to a position. A faster method could be created that returned
		/// N close points to a position, but necessarily the exact N closest.
		/// The returned points are sorted from closest to farthest.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0600C71F RID: 50975 RVA: 0x00114E48 File Offset: 0x00113048
		public virtual void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
		{
			vtkAbstractPointLocator.vtkAbstractPointLocator_FindClosestNPoints_01(base.GetCppThis(), N, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0600C720 RID: 50976
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPointLocator_FindClosestNPoints_02(HandleRef pThis, int N, double x, double y, double z, HandleRef result);

		/// <summary>
		/// Find the closest N points to a position. This returns the closest
		/// N points to a position. A faster method could be created that returned
		/// N close points to a position, but necessarily the exact N closest.
		/// The returned points are sorted from closest to farthest.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0600C721 RID: 50977 RVA: 0x00114E7C File Offset: 0x0011307C
		public void FindClosestNPoints(int N, double x, double y, double z, vtkIdList result)
		{
			vtkAbstractPointLocator.vtkAbstractPointLocator_FindClosestNPoints_02(base.GetCppThis(), N, x, y, z, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0600C722 RID: 50978
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractPointLocator_FindClosestPoint_03(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Given a position x, return the id of the point closest to it. Alternative
		/// method requires separate x-y-z values.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0600C723 RID: 50979 RVA: 0x00114EB4 File Offset: 0x001130B4
		public virtual long FindClosestPoint(IntPtr x)
		{
			return vtkAbstractPointLocator.vtkAbstractPointLocator_FindClosestPoint_03(base.GetCppThis(), x);
		}

		// Token: 0x0600C724 RID: 50980
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractPointLocator_FindClosestPoint_04(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Given a position x, return the id of the point closest to it. Alternative
		/// method requires separate x-y-z values.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0600C725 RID: 50981 RVA: 0x00114ED4 File Offset: 0x001130D4
		public long FindClosestPoint(double x, double y, double z)
		{
			return vtkAbstractPointLocator.vtkAbstractPointLocator_FindClosestPoint_04(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600C726 RID: 50982
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractPointLocator_FindClosestPointWithinRadius_05(HandleRef pThis, double radius, IntPtr x, ref double dist2);

		/// <summary>
		/// Given a position x and a radius r, return the id of the point
		/// closest to the point in that radius.
		/// dist2 returns the squared distance to the point.
		/// </summary>
		// Token: 0x0600C727 RID: 50983 RVA: 0x00114EF8 File Offset: 0x001130F8
		public virtual long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
		{
			return vtkAbstractPointLocator.vtkAbstractPointLocator_FindClosestPointWithinRadius_05(base.GetCppThis(), radius, x, ref dist2);
		}

		// Token: 0x0600C728 RID: 50984
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPointLocator_FindPointsWithinRadius_06(HandleRef pThis, double R, IntPtr x, HandleRef result);

		/// <summary>
		/// Find all points within a specified radius R of position x.
		/// The result is not sorted in any specific manner.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0600C729 RID: 50985 RVA: 0x00114F1C File Offset: 0x0011311C
		public virtual void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
		{
			vtkAbstractPointLocator.vtkAbstractPointLocator_FindPointsWithinRadius_06(base.GetCppThis(), R, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0600C72A RID: 50986
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPointLocator_FindPointsWithinRadius_07(HandleRef pThis, double R, double x, double y, double z, HandleRef result);

		/// <summary>
		/// Find all points within a specified radius R of position x.
		/// The result is not sorted in any specific manner.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0600C72B RID: 50987 RVA: 0x00114F50 File Offset: 0x00113150
		public void FindPointsWithinRadius(double R, double x, double y, double z, vtkIdList result)
		{
			vtkAbstractPointLocator.vtkAbstractPointLocator_FindPointsWithinRadius_07(base.GetCppThis(), R, x, y, z, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0600C72C RID: 50988
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPointLocator_GetBounds_08(HandleRef pThis);

		/// <summary>
		/// Provide an accessor to the bounds. Valid after the locator is built.
		/// </summary>
		// Token: 0x0600C72D RID: 50989 RVA: 0x00114F88 File Offset: 0x00113188
		public virtual IntPtr GetBounds()
		{
			return vtkAbstractPointLocator.vtkAbstractPointLocator_GetBounds_08(base.GetCppThis());
		}

		// Token: 0x0600C72E RID: 50990
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPointLocator_GetBounds_09(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Provide an accessor to the bounds. Valid after the locator is built.
		/// </summary>
		// Token: 0x0600C72F RID: 50991 RVA: 0x00114FA7 File Offset: 0x001131A7
		public virtual void GetBounds(IntPtr arg0)
		{
			vtkAbstractPointLocator.vtkAbstractPointLocator_GetBounds_09(base.GetCppThis(), arg0);
		}

		// Token: 0x0600C730 RID: 50992
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractPointLocator_GetNumberOfBuckets_10(HandleRef pThis);

		/// <summary>
		/// Return the total number of buckets in the locator. This has meaning only
		/// after the locator is constructed.
		/// </summary>
		// Token: 0x0600C731 RID: 50993 RVA: 0x00114FB8 File Offset: 0x001131B8
		public virtual long GetNumberOfBuckets()
		{
			return vtkAbstractPointLocator.vtkAbstractPointLocator_GetNumberOfBuckets_10(base.GetCppThis());
		}

		// Token: 0x0600C732 RID: 50994
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractPointLocator_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600C733 RID: 50995 RVA: 0x00114FD8 File Offset: 0x001131D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractPointLocator.vtkAbstractPointLocator_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0600C734 RID: 50996
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractPointLocator_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600C735 RID: 50997 RVA: 0x00114FF8 File Offset: 0x001131F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractPointLocator.vtkAbstractPointLocator_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0600C736 RID: 50998
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPointLocator_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600C737 RID: 50999 RVA: 0x00115014 File Offset: 0x00113214
		public override int IsA(string type)
		{
			return vtkAbstractPointLocator.vtkAbstractPointLocator_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0600C738 RID: 51000
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPointLocator_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600C739 RID: 51001 RVA: 0x00115034 File Offset: 0x00113234
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractPointLocator.vtkAbstractPointLocator_IsTypeOf_14(type);
		}

		// Token: 0x0600C73A RID: 51002
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPointLocator_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600C73B RID: 51003 RVA: 0x00115050 File Offset: 0x00113250
		public new vtkAbstractPointLocator NewInstance()
		{
			vtkAbstractPointLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPointLocator.vtkAbstractPointLocator_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C73C RID: 51004
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPointLocator_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0600C73D RID: 51005 RVA: 0x001150AC File Offset: 0x001132AC
		public new static vtkAbstractPointLocator SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractPointLocator vtkAbstractPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPointLocator.vtkAbstractPointLocator_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPointLocator = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPointLocator.Register(null);
				}
			}
			return vtkAbstractPointLocator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ED1 RID: 3793
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractPointLocator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ED2 RID: 3794
		public new static readonly string MRClassNameKey = "class vtkAbstractPointLocator";
	}
}
