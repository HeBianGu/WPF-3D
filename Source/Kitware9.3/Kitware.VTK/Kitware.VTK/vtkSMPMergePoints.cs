﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSMPMergePoints
	/// </summary>
	/// <remarks>
	///    Class designed to help with merging of points in parallel
	///
	/// vtkSMPMergePoints is a subclass of vtkMergePoints designed to help
	/// with merging of points generated by using multiple locators in parallel.
	/// Its main functionality is provided by the Merge function. It also
	/// has a few additional convenience functions.
	/// Merge is thread safe as long as no two threads are merging the same
	/// bin. The common way of using vtkSMPMergePoints is:
	///  - Initialize with outLocator-&gt;InitializeMerge()
	///  - Allocate points with outLocator-&gt;GetPoints()-&gt;Resize(numPts) (numPts should be &gt;= total number
	/// of points)
	///  - Do bunch of merging with outLocator-&gt;Merge(inLocator[i], ...) (this can be done in parallel as
	/// long as no two bins are done at the same time)
	///  - Fix the size of points with outLocator-&gt;FixSizeOfPointArray()
	/// </remarks>
	// Token: 0x02000424 RID: 1060
	public class vtkSMPMergePoints : vtkMergePoints
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C7C3 RID: 51139 RVA: 0x00115D53 File Offset: 0x00113F53
		static vtkSMPMergePoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSMPMergePoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSMPMergePoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C7C4 RID: 51140 RVA: 0x00115D7B File Offset: 0x00113F7B
		public vtkSMPMergePoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C7C5 RID: 51141
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSMPMergePoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7C6 RID: 51142 RVA: 0x00115D8C File Offset: 0x00113F8C
		public new static vtkSMPMergePoints New()
		{
			vtkSMPMergePoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSMPMergePoints.vtkSMPMergePoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSMPMergePoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7C7 RID: 51143 RVA: 0x00115DE0 File Offset: 0x00113FE0
		public vtkSMPMergePoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSMPMergePoints.vtkSMPMergePoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C7C8 RID: 51144 RVA: 0x00115E24 File Offset: 0x00114024
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C7C9 RID: 51145
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSMPMergePoints_FixSizeOfPointArray_01(HandleRef pThis);

		/// <summary>
		/// At the of the merge, this can be called to set the MaxId of the
		/// points array to the maximum id in the locator. The current design
		/// usage is as follows:
		/// - Allocate points with points-&gt;Resize(numPts). NumPts should be &gt;= total number of points
		/// - Do bunch of merging with outLocator-&gt;Merge(inLocator[i], ...)
		/// - Fix the size of points with outLocator-&gt;FixSizeOfPointArray()
		/// </summary>
		// Token: 0x0600C7CA RID: 51146 RVA: 0x00115E2F File Offset: 0x0011402F
		public void FixSizeOfPointArray()
		{
			vtkSMPMergePoints.vtkSMPMergePoints_FixSizeOfPointArray_01(base.GetCppThis());
		}

		// Token: 0x0600C7CB RID: 51147
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSMPMergePoints_GetMaxId_02(HandleRef pThis);

		/// <summary>
		/// Returns the biggest id in the locator.
		/// </summary>
		// Token: 0x0600C7CC RID: 51148 RVA: 0x00115E40 File Offset: 0x00114040
		public long GetMaxId()
		{
			return vtkSMPMergePoints.vtkSMPMergePoints_GetMaxId_02(base.GetCppThis());
		}

		// Token: 0x0600C7CD RID: 51149
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSMPMergePoints_GetNumberOfBuckets_03(HandleRef pThis);

		/// <summary>
		/// Returns the number of bins.
		/// </summary>
		// Token: 0x0600C7CE RID: 51150 RVA: 0x00115E60 File Offset: 0x00114060
		public override long GetNumberOfBuckets()
		{
			return vtkSMPMergePoints.vtkSMPMergePoints_GetNumberOfBuckets_03(base.GetCppThis());
		}

		// Token: 0x0600C7CF RID: 51151
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSMPMergePoints_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7D0 RID: 51152 RVA: 0x00115E80 File Offset: 0x00114080
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSMPMergePoints.vtkSMPMergePoints_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C7D1 RID: 51153
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSMPMergePoints_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7D2 RID: 51154 RVA: 0x00115EA0 File Offset: 0x001140A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSMPMergePoints.vtkSMPMergePoints_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600C7D3 RID: 51155
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSMPMergePoints_GetNumberOfIdsInBucket_06(HandleRef pThis, long idx);

		/// <summary>
		/// Returns the number of points in a bin.
		/// </summary>
		// Token: 0x0600C7D4 RID: 51156 RVA: 0x00115EBC File Offset: 0x001140BC
		public long GetNumberOfIdsInBucket(long idx)
		{
			return vtkSMPMergePoints.vtkSMPMergePoints_GetNumberOfIdsInBucket_06(base.GetCppThis(), idx);
		}

		// Token: 0x0600C7D5 RID: 51157
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSMPMergePoints_InitializeMerge_07(HandleRef pThis);

		/// <summary>
		/// This should be called from 1 thread before any call to Merge.
		/// </summary>
		// Token: 0x0600C7D6 RID: 51158 RVA: 0x00115EDC File Offset: 0x001140DC
		public void InitializeMerge()
		{
			vtkSMPMergePoints.vtkSMPMergePoints_InitializeMerge_07(base.GetCppThis());
		}

		// Token: 0x0600C7D7 RID: 51159
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSMPMergePoints_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7D8 RID: 51160 RVA: 0x00115EEC File Offset: 0x001140EC
		public override int IsA(string type)
		{
			return vtkSMPMergePoints.vtkSMPMergePoints_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600C7D9 RID: 51161
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSMPMergePoints_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7DA RID: 51162 RVA: 0x00115F0C File Offset: 0x0011410C
		public new static int IsTypeOf(string type)
		{
			return vtkSMPMergePoints.vtkSMPMergePoints_IsTypeOf_09(type);
		}

		// Token: 0x0600C7DB RID: 51163
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSMPMergePoints_Merge_10(HandleRef pThis, HandleRef locator, long idx, HandleRef outPd, HandleRef inPd, HandleRef idList);

		/// <summary>
		/// Merge the points of one of the bins from the given locator to
		/// the same bin of the current locator. Note that this requires that
		/// the two locators have identical binning structures. This also
		/// merges point data given in the inPD argument to the outPd.
		/// Furthermore, it generates a map of the old ids of the input locator
		/// to the new ids. This is stored in the idList argument. The map
		/// is idList[oldId] = newId.
		/// </summary>
		// Token: 0x0600C7DC RID: 51164 RVA: 0x00115F28 File Offset: 0x00114128
		public void Merge(vtkSMPMergePoints locator, long idx, vtkPointData outPd, vtkPointData inPd, vtkIdList idList)
		{
			vtkSMPMergePoints.vtkSMPMergePoints_Merge_10(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), idx, (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (idList == null) ? default(HandleRef) : idList.GetCppThis());
		}

		// Token: 0x0600C7DD RID: 51165
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSMPMergePoints_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7DE RID: 51166 RVA: 0x00115F9C File Offset: 0x0011419C
		public new vtkSMPMergePoints NewInstance()
		{
			vtkSMPMergePoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSMPMergePoints.vtkSMPMergePoints_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSMPMergePoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C7DF RID: 51167
		[DllImport("Kitware.VTK.FiltersSMP.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSMPMergePoints_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7E0 RID: 51168 RVA: 0x00115FF8 File Offset: 0x001141F8
		public new static vtkSMPMergePoints SafeDownCast(vtkObjectBase o)
		{
			vtkSMPMergePoints vtkSMPMergePoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSMPMergePoints.vtkSMPMergePoints_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSMPMergePoints = (vtkSMPMergePoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSMPMergePoints.Register(null);
				}
			}
			return vtkSMPMergePoints;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ED9 RID: 3801
		public new const string MRFullTypeName = "Kitware.VTK.vtkSMPMergePoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EDA RID: 3802
		public new static readonly string MRClassNameKey = "class vtkSMPMergePoints";
	}
}
