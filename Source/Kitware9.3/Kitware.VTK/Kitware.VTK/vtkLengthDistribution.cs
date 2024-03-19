using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLengthDistribution
	/// </summary>
	/// <remarks>
	///    Sample the distribution of representative "cell lengths"
	///  of a mesh.
	///
	/// vtkLengthDistribution chooses a subset of N cells and, for each one, chooses
	/// two random connectivity entries of the cell. Then it computes the distance
	/// between the corresponding points and inserts the distance into an ordered set.
	/// The result is a cumulative distribution function (CDF) of lengths which are
	/// representative of the length scales present in the dataset.
	/// Quantiles (other than the extremal values) of this distribution should be
	/// relatively stable estimates of length scales compared to moment-based
	/// estimates that may be skewed by outlier elements.
	///
	/// This filter produces a vtkTable as its result, with N rows containing
	/// monotonically increasing length values. Only polydata and unstructured
	/// grids are accepted; other dataset types will produce an empty table
	/// and a warning.
	/// </remarks>
	// Token: 0x02000749 RID: 1865
	public class vtkLengthDistribution : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013629 RID: 79401 RVA: 0x001B6CED File Offset: 0x001B4EED
		static vtkLengthDistribution()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLengthDistribution.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLengthDistribution"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601362A RID: 79402 RVA: 0x001B6D15 File Offset: 0x001B4F15
		public vtkLengthDistribution(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601362B RID: 79403
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLengthDistribution_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601362C RID: 79404 RVA: 0x001B6D24 File Offset: 0x001B4F24
		public new static vtkLengthDistribution New()
		{
			vtkLengthDistribution result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLengthDistribution.vtkLengthDistribution_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLengthDistribution)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601362D RID: 79405 RVA: 0x001B6D78 File Offset: 0x001B4F78
		public vtkLengthDistribution() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLengthDistribution.vtkLengthDistribution_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601362E RID: 79406 RVA: 0x001B6DBC File Offset: 0x001B4FBC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601362F RID: 79407
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLengthDistribution_GetLengthQuantile_01(HandleRef pThis, double qq);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013630 RID: 79408 RVA: 0x001B6DC8 File Offset: 0x001B4FC8
		public double GetLengthQuantile(double qq)
		{
			return vtkLengthDistribution.vtkLengthDistribution_GetLengthQuantile_01(base.GetCppThis(), qq);
		}

		// Token: 0x06013631 RID: 79409
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLengthDistribution_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013632 RID: 79410 RVA: 0x001B6DE8 File Offset: 0x001B4FE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLengthDistribution.vtkLengthDistribution_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06013633 RID: 79411
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLengthDistribution_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013634 RID: 79412 RVA: 0x001B6E08 File Offset: 0x001B5008
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLengthDistribution.vtkLengthDistribution_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06013635 RID: 79413
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLengthDistribution_GetSampleSize_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013636 RID: 79414 RVA: 0x001B6E24 File Offset: 0x001B5024
		public virtual long GetSampleSize()
		{
			return vtkLengthDistribution.vtkLengthDistribution_GetSampleSize_04(base.GetCppThis());
		}

		// Token: 0x06013637 RID: 79415
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLengthDistribution_GetSortSample_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013638 RID: 79416 RVA: 0x001B6E44 File Offset: 0x001B5044
		public virtual bool GetSortSample()
		{
			return vtkLengthDistribution.vtkLengthDistribution_GetSortSample_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06013639 RID: 79417
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLengthDistribution_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601363A RID: 79418 RVA: 0x001B6E6C File Offset: 0x001B506C
		public override int IsA(string type)
		{
			return vtkLengthDistribution.vtkLengthDistribution_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601363B RID: 79419
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLengthDistribution_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601363C RID: 79420 RVA: 0x001B6E8C File Offset: 0x001B508C
		public new static int IsTypeOf(string type)
		{
			return vtkLengthDistribution.vtkLengthDistribution_IsTypeOf_07(type);
		}

		// Token: 0x0601363D RID: 79421
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLengthDistribution_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601363E RID: 79422 RVA: 0x001B6EA8 File Offset: 0x001B50A8
		public new vtkLengthDistribution NewInstance()
		{
			vtkLengthDistribution result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLengthDistribution.vtkLengthDistribution_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLengthDistribution)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601363F RID: 79423
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLengthDistribution_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013640 RID: 79424 RVA: 0x001B6F04 File Offset: 0x001B5104
		public new static vtkLengthDistribution SafeDownCast(vtkObjectBase o)
		{
			vtkLengthDistribution vtkLengthDistribution = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLengthDistribution.vtkLengthDistribution_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLengthDistribution = (vtkLengthDistribution)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLengthDistribution.Register(null);
				}
			}
			return vtkLengthDistribution;
		}

		// Token: 0x06013641 RID: 79425
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLengthDistribution_SetSampleSize_11(HandleRef pThis, long _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013642 RID: 79426 RVA: 0x001B6F83 File Offset: 0x001B5183
		public virtual void SetSampleSize(long _arg)
		{
			vtkLengthDistribution.vtkLengthDistribution_SetSampleSize_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06013643 RID: 79427
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLengthDistribution_SetSortSample_12(HandleRef pThis, byte _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013644 RID: 79428 RVA: 0x001B6F93 File Offset: 0x001B5193
		public virtual void SetSortSample(bool _arg)
		{
			vtkLengthDistribution.vtkLengthDistribution_SetSortSample_12(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06013645 RID: 79429
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLengthDistribution_SortSampleOff_13(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013646 RID: 79430 RVA: 0x001B6FAB File Offset: 0x001B51AB
		public virtual void SortSampleOff()
		{
			vtkLengthDistribution.vtkLengthDistribution_SortSampleOff_13(base.GetCppThis());
		}

		// Token: 0x06013647 RID: 79431
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLengthDistribution_SortSampleOn_14(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013648 RID: 79432 RVA: 0x001B6FBA File Offset: 0x001B51BA
		public virtual void SortSampleOn()
		{
			vtkLengthDistribution.vtkLengthDistribution_SortSampleOn_14(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001662 RID: 5730
		public new const string MRFullTypeName = "Kitware.VTK.vtkLengthDistribution";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001663 RID: 5731
		public new static readonly string MRClassNameKey = "class vtkLengthDistribution";
	}
}
