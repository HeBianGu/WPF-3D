using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBSPIntersections
	/// </summary>
	/// <remarks>
	///    Perform calculations (mostly intersection
	///   calculations) on regions of a 3D binary spatial partitioning.
	///
	///
	///    Given an axis aligned binary spatial partitioning described by a
	///    vtkBSPCuts object, perform intersection queries on various
	///    geometric entities with regions of the spatial partitioning.
	///
	/// </remarks>
	/// <seealso>
	///
	///    vtkBSPCuts  vtkKdTree
	/// </seealso>
	// Token: 0x020009FC RID: 2556
	public class vtkBSPIntersections : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A836 RID: 108598 RVA: 0x0024D88B File Offset: 0x0024BA8B
		static vtkBSPIntersections()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBSPIntersections.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBSPIntersections"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A837 RID: 108599 RVA: 0x0024D8B3 File Offset: 0x0024BAB3
		public vtkBSPIntersections(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A838 RID: 108600
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBSPIntersections_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A839 RID: 108601 RVA: 0x0024D8C4 File Offset: 0x0024BAC4
		public new static vtkBSPIntersections New()
		{
			vtkBSPIntersections result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBSPIntersections.vtkBSPIntersections_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBSPIntersections)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A83A RID: 108602 RVA: 0x0024D918 File Offset: 0x0024BB18
		public vtkBSPIntersections() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBSPIntersections.vtkBSPIntersections_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A83B RID: 108603 RVA: 0x0024D95C File Offset: 0x0024BB5C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A83C RID: 108604
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSPIntersections_ComputeIntersectionsUsingDataBoundsOff_01(HandleRef pThis);

		/// <summary>
		/// When computing the intersection of k-d tree regions with other
		/// objects, we use the spatial bounds of the region.  To use the
		/// tighter bound of the bounding box of the data within the region,
		/// set this variable ON.  (Specifying data bounds in the vtkBSPCuts
		/// object is optional.  If data bounds were not specified, this
		/// option has no meaning.)
		/// </summary>
		// Token: 0x0601A83D RID: 108605 RVA: 0x0024D967 File Offset: 0x0024BB67
		public void ComputeIntersectionsUsingDataBoundsOff()
		{
			vtkBSPIntersections.vtkBSPIntersections_ComputeIntersectionsUsingDataBoundsOff_01(base.GetCppThis());
		}

		// Token: 0x0601A83E RID: 108606
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSPIntersections_ComputeIntersectionsUsingDataBoundsOn_02(HandleRef pThis);

		/// <summary>
		/// When computing the intersection of k-d tree regions with other
		/// objects, we use the spatial bounds of the region.  To use the
		/// tighter bound of the bounding box of the data within the region,
		/// set this variable ON.  (Specifying data bounds in the vtkBSPCuts
		/// object is optional.  If data bounds were not specified, this
		/// option has no meaning.)
		/// </summary>
		// Token: 0x0601A83F RID: 108607 RVA: 0x0024D976 File Offset: 0x0024BB76
		public void ComputeIntersectionsUsingDataBoundsOn()
		{
			vtkBSPIntersections.vtkBSPIntersections_ComputeIntersectionsUsingDataBoundsOn_02(base.GetCppThis());
		}

		// Token: 0x0601A840 RID: 108608
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPIntersections_GetBounds_03(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds of the whole space (xmin, xmax, ymin, ymax, zmin, zmax)
		/// Return 0 if OK, 1 on error.
		/// </summary>
		// Token: 0x0601A841 RID: 108609 RVA: 0x0024D988 File Offset: 0x0024BB88
		public int GetBounds(IntPtr bounds)
		{
			return vtkBSPIntersections.vtkBSPIntersections_GetBounds_03(base.GetCppThis(), bounds);
		}

		// Token: 0x0601A842 RID: 108610
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPIntersections_GetComputeIntersectionsUsingDataBounds_04(HandleRef pThis);

		/// <summary>
		/// When computing the intersection of k-d tree regions with other
		/// objects, we use the spatial bounds of the region.  To use the
		/// tighter bound of the bounding box of the data within the region,
		/// set this variable ON.  (Specifying data bounds in the vtkBSPCuts
		/// object is optional.  If data bounds were not specified, this
		/// option has no meaning.)
		/// </summary>
		// Token: 0x0601A843 RID: 108611 RVA: 0x0024D9A8 File Offset: 0x0024BBA8
		public virtual int GetComputeIntersectionsUsingDataBounds()
		{
			return vtkBSPIntersections.vtkBSPIntersections_GetComputeIntersectionsUsingDataBounds_04(base.GetCppThis());
		}

		// Token: 0x0601A844 RID: 108612
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBSPIntersections_GetCuts_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Define the binary spatial partitioning.
		/// </summary>
		// Token: 0x0601A845 RID: 108613 RVA: 0x0024D9C8 File Offset: 0x0024BBC8
		public virtual vtkBSPCuts GetCuts()
		{
			vtkBSPCuts vtkBSPCuts = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBSPIntersections.vtkBSPIntersections_GetCuts_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBSPCuts = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBSPCuts.Register(null);
				}
			}
			return vtkBSPCuts;
		}

		// Token: 0x0601A846 RID: 108614
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBSPIntersections_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A847 RID: 108615 RVA: 0x0024DA38 File Offset: 0x0024BC38
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBSPIntersections.vtkBSPIntersections_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601A848 RID: 108616
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBSPIntersections_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A849 RID: 108617 RVA: 0x0024DA58 File Offset: 0x0024BC58
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBSPIntersections.vtkBSPIntersections_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601A84A RID: 108618
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPIntersections_GetNumberOfRegions_08(HandleRef pThis);

		/// <summary>
		/// The number of regions in the binary spatial partitioning
		/// </summary>
		// Token: 0x0601A84B RID: 108619 RVA: 0x0024DA74 File Offset: 0x0024BC74
		public int GetNumberOfRegions()
		{
			return vtkBSPIntersections.vtkBSPIntersections_GetNumberOfRegions_08(base.GetCppThis());
		}

		// Token: 0x0601A84C RID: 108620
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPIntersections_GetRegionBounds_09(HandleRef pThis, int regionID, IntPtr bounds);

		/// <summary>
		/// Get the spatial bounds of a particular region
		/// Return 0 if OK, 1 on error.
		/// </summary>
		// Token: 0x0601A84D RID: 108621 RVA: 0x0024DA94 File Offset: 0x0024BC94
		public int GetRegionBounds(int regionID, IntPtr bounds)
		{
			return vtkBSPIntersections.vtkBSPIntersections_GetRegionBounds_09(base.GetCppThis(), regionID, bounds);
		}

		// Token: 0x0601A84E RID: 108622
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPIntersections_GetRegionDataBounds_10(HandleRef pThis, int regionID, IntPtr bounds);

		/// <summary>
		/// Get the bounds of the data within the k-d tree region, possibly
		/// smaller than the bounds of the region.
		/// Return 0 if OK, 1 on error.
		/// </summary>
		// Token: 0x0601A84F RID: 108623 RVA: 0x0024DAB8 File Offset: 0x0024BCB8
		public int GetRegionDataBounds(int regionID, IntPtr bounds)
		{
			return vtkBSPIntersections.vtkBSPIntersections_GetRegionDataBounds_10(base.GetCppThis(), regionID, bounds);
		}

		// Token: 0x0601A850 RID: 108624
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPIntersections_IntersectsBox_11(HandleRef pThis, int regionId, IntPtr x);

		/// <summary>
		/// Determine whether a region of the spatial decomposition
		/// intersects an axis aligned box.
		/// </summary>
		// Token: 0x0601A851 RID: 108625 RVA: 0x0024DADC File Offset: 0x0024BCDC
		public int IntersectsBox(int regionId, IntPtr x)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IntersectsBox_11(base.GetCppThis(), regionId, x);
		}

		// Token: 0x0601A852 RID: 108626
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPIntersections_IntersectsBox_12(HandleRef pThis, int regionId, double x0, double x1, double y0, double y1, double z0, double z1);

		/// <summary>
		/// Determine whether a region of the spatial decomposition
		/// intersects an axis aligned box.
		/// </summary>
		// Token: 0x0601A853 RID: 108627 RVA: 0x0024DB00 File Offset: 0x0024BD00
		public int IntersectsBox(int regionId, double x0, double x1, double y0, double y1, double z0, double z1)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IntersectsBox_12(base.GetCppThis(), regionId, x0, x1, y0, y1, z0, z1);
		}

		// Token: 0x0601A854 RID: 108628
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPIntersections_IntersectsBox_13(HandleRef pThis, IntPtr ids, int len, IntPtr x);

		/// <summary>
		/// Compute a list of the Ids of all regions that
		/// intersect the specified axis aligned box.
		/// Returns: the number of ids in the list.
		/// </summary>
		// Token: 0x0601A855 RID: 108629 RVA: 0x0024DB2C File Offset: 0x0024BD2C
		public int IntersectsBox(IntPtr ids, int len, IntPtr x)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IntersectsBox_13(base.GetCppThis(), ids, len, x);
		}

		// Token: 0x0601A856 RID: 108630
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPIntersections_IntersectsBox_14(HandleRef pThis, IntPtr ids, int len, double x0, double x1, double y0, double y1, double z0, double z1);

		/// <summary>
		/// Compute a list of the Ids of all regions that
		/// intersect the specified axis aligned box.
		/// Returns: the number of ids in the list.
		/// </summary>
		// Token: 0x0601A857 RID: 108631 RVA: 0x0024DB50 File Offset: 0x0024BD50
		public int IntersectsBox(IntPtr ids, int len, double x0, double x1, double y0, double y1, double z0, double z1)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IntersectsBox_14(base.GetCppThis(), ids, len, x0, x1, y0, y1, z0, z1);
		}

		// Token: 0x0601A858 RID: 108632
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPIntersections_IntersectsCell_15(HandleRef pThis, int regionId, HandleRef cell, int cellRegion);

		/// <summary>
		/// Determine whether a region of the spatial decomposition
		/// intersects the given cell.  If you already
		/// know the region that the cell centroid lies in, provide
		/// that as the last argument to make the computation quicker.
		/// </summary>
		// Token: 0x0601A859 RID: 108633 RVA: 0x0024DB7C File Offset: 0x0024BD7C
		public int IntersectsCell(int regionId, vtkCell cell, int cellRegion)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IntersectsCell_15(base.GetCppThis(), regionId, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellRegion);
		}

		// Token: 0x0601A85A RID: 108634
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPIntersections_IntersectsCell_16(HandleRef pThis, IntPtr ids, int len, HandleRef cell, int cellRegion);

		/// <summary>
		/// Compute a list of the Ids of all regions that
		/// intersect the given cell.  If you already
		/// know the region that the cell centroid lies in, provide
		/// that as the last argument to make the computation quicker.
		/// Returns the number of regions the cell intersects.
		/// </summary>
		// Token: 0x0601A85B RID: 108635 RVA: 0x0024DBB4 File Offset: 0x0024BDB4
		public int IntersectsCell(IntPtr ids, int len, vtkCell cell, int cellRegion)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IntersectsCell_16(base.GetCppThis(), ids, len, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellRegion);
		}

		// Token: 0x0601A85C RID: 108636
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPIntersections_IntersectsSphere2_17(HandleRef pThis, int regionId, double x, double y, double z, double rSquared);

		/// <summary>
		/// Determine whether a region of the spatial decomposition
		/// intersects a sphere, given the center of the sphere
		/// and the square of it's radius.
		/// </summary>
		// Token: 0x0601A85D RID: 108637 RVA: 0x0024DBEC File Offset: 0x0024BDEC
		public int IntersectsSphere2(int regionId, double x, double y, double z, double rSquared)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IntersectsSphere2_17(base.GetCppThis(), regionId, x, y, z, rSquared);
		}

		// Token: 0x0601A85E RID: 108638
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPIntersections_IntersectsSphere2_18(HandleRef pThis, IntPtr ids, int len, double x, double y, double z, double rSquared);

		/// <summary>
		/// Compute a list of the Ids of all regions that
		/// intersect the specified sphere.  The sphere is given
		/// by it's center and the square of it's radius.
		/// Returns: the number of ids in the list.
		/// </summary>
		// Token: 0x0601A85F RID: 108639 RVA: 0x0024DC14 File Offset: 0x0024BE14
		public int IntersectsSphere2(IntPtr ids, int len, double x, double y, double z, double rSquared)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IntersectsSphere2_18(base.GetCppThis(), ids, len, x, y, z, rSquared);
		}

		// Token: 0x0601A860 RID: 108640
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPIntersections_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A861 RID: 108641 RVA: 0x0024DC3C File Offset: 0x0024BE3C
		public override int IsA(string type)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x0601A862 RID: 108642
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSPIntersections_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A863 RID: 108643 RVA: 0x0024DC5C File Offset: 0x0024BE5C
		public new static int IsTypeOf(string type)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IsTypeOf_20(type);
		}

		// Token: 0x0601A864 RID: 108644
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBSPIntersections_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A865 RID: 108645 RVA: 0x0024DC78 File Offset: 0x0024BE78
		public new vtkBSPIntersections NewInstance()
		{
			vtkBSPIntersections result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBSPIntersections.vtkBSPIntersections_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBSPIntersections)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A866 RID: 108646
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBSPIntersections_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A867 RID: 108647 RVA: 0x0024DCD4 File Offset: 0x0024BED4
		public new static vtkBSPIntersections SafeDownCast(vtkObjectBase o)
		{
			vtkBSPIntersections vtkBSPIntersections = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBSPIntersections.vtkBSPIntersections_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBSPIntersections = (vtkBSPIntersections)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBSPIntersections.Register(null);
				}
			}
			return vtkBSPIntersections;
		}

		// Token: 0x0601A868 RID: 108648
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSPIntersections_SetComputeIntersectionsUsingDataBounds_24(HandleRef pThis, int c);

		/// <summary>
		/// When computing the intersection of k-d tree regions with other
		/// objects, we use the spatial bounds of the region.  To use the
		/// tighter bound of the bounding box of the data within the region,
		/// set this variable ON.  (Specifying data bounds in the vtkBSPCuts
		/// object is optional.  If data bounds were not specified, this
		/// option has no meaning.)
		/// </summary>
		// Token: 0x0601A869 RID: 108649 RVA: 0x0024DD53 File Offset: 0x0024BF53
		public void SetComputeIntersectionsUsingDataBounds(int c)
		{
			vtkBSPIntersections.vtkBSPIntersections_SetComputeIntersectionsUsingDataBounds_24(base.GetCppThis(), c);
		}

		// Token: 0x0601A86A RID: 108650
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSPIntersections_SetCuts_25(HandleRef pThis, HandleRef cuts);

		/// <summary>
		/// Define the binary spatial partitioning.
		/// </summary>
		// Token: 0x0601A86B RID: 108651 RVA: 0x0024DD64 File Offset: 0x0024BF64
		public void SetCuts(vtkBSPCuts cuts)
		{
			vtkBSPIntersections.vtkBSPIntersections_SetCuts_25(base.GetCppThis(), (cuts == null) ? default(HandleRef) : cuts.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CD0 RID: 7376
		public new const string MRFullTypeName = "Kitware.VTK.vtkBSPIntersections";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CD1 RID: 7377
		public new static readonly string MRClassNameKey = "class vtkBSPIntersections";
	}
}
