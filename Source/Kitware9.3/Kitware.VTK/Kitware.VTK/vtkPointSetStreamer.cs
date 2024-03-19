using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointSetStreamer
	/// </summary>
	/// <remarks>
	///    stream points as buckets
	///
	/// vtkPointSetStreamer is a filter that sorts points into buckets and it returns the points
	/// included in the chosen bucket. The bucket is chosen by setting the BucketId. The purpose
	/// of this class is to allow streaming of points. The bucket size is determined by the
	/// NumberOfPointsPerBucket.
	///
	/// The typical usage is to call this filter the first time to perform the sorting and get the points
	/// in the first bucket and then to call it again to get the points in the remaining buckets. The
	/// sorting is performed only the first time, assuming that the dataset or NumberOfPointsPerBucket
	/// don't change. The number of buckets can be obtained by calling GetNumberOfBuckets.
	///
	/// </remarks>
	/// <seealso>
	///  vtkPointSetToOctreeImageFilter vtkStaticPointLocator
	/// </seealso>
	// Token: 0x02000497 RID: 1175
	public class vtkPointSetStreamer : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D81C RID: 55324 RVA: 0x0012C63F File Offset: 0x0012A83F
		static vtkPointSetStreamer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointSetStreamer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSetStreamer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D81D RID: 55325 RVA: 0x0012C667 File Offset: 0x0012A867
		public vtkPointSetStreamer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D81E RID: 55326
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetStreamer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D81F RID: 55327 RVA: 0x0012C678 File Offset: 0x0012A878
		public new static vtkPointSetStreamer New()
		{
			vtkPointSetStreamer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetStreamer.vtkPointSetStreamer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSetStreamer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D820 RID: 55328 RVA: 0x0012C6CC File Offset: 0x0012A8CC
		public vtkPointSetStreamer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointSetStreamer.vtkPointSetStreamer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D821 RID: 55329 RVA: 0x0012C710 File Offset: 0x0012A910
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D822 RID: 55330
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetStreamer_CreateVerticesCellArrayOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get if a cell array of vertices will be created.
		///
		/// The default is on.
		/// </summary>
		// Token: 0x0600D823 RID: 55331 RVA: 0x0012C71B File Offset: 0x0012A91B
		public virtual void CreateVerticesCellArrayOff()
		{
			vtkPointSetStreamer.vtkPointSetStreamer_CreateVerticesCellArrayOff_01(base.GetCppThis());
		}

		// Token: 0x0600D824 RID: 55332
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetStreamer_CreateVerticesCellArrayOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get if a cell array of vertices will be created.
		///
		/// The default is on.
		/// </summary>
		// Token: 0x0600D825 RID: 55333 RVA: 0x0012C72A File Offset: 0x0012A92A
		public virtual void CreateVerticesCellArrayOn()
		{
			vtkPointSetStreamer.vtkPointSetStreamer_CreateVerticesCellArrayOn_02(base.GetCppThis());
		}

		// Token: 0x0600D826 RID: 55334
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSetStreamer_GetBucketId_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the bucket id to stream.
		/// This data member is used to determine the number of buckets.
		///
		/// The default is 0.
		/// </summary>
		// Token: 0x0600D827 RID: 55335 RVA: 0x0012C73C File Offset: 0x0012A93C
		public virtual long GetBucketId()
		{
			return vtkPointSetStreamer.vtkPointSetStreamer_GetBucketId_03(base.GetCppThis());
		}

		// Token: 0x0600D828 RID: 55336
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSetStreamer_GetBucketIdMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the bucket id to stream.
		/// This data member is used to determine the number of buckets.
		///
		/// The default is 0.
		/// </summary>
		// Token: 0x0600D829 RID: 55337 RVA: 0x0012C75C File Offset: 0x0012A95C
		public virtual long GetBucketIdMaxValue()
		{
			return vtkPointSetStreamer.vtkPointSetStreamer_GetBucketIdMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0600D82A RID: 55338
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSetStreamer_GetBucketIdMinValue_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the bucket id to stream.
		/// This data member is used to determine the number of buckets.
		///
		/// The default is 0.
		/// </summary>
		// Token: 0x0600D82B RID: 55339 RVA: 0x0012C77C File Offset: 0x0012A97C
		public virtual long GetBucketIdMinValue()
		{
			return vtkPointSetStreamer.vtkPointSetStreamer_GetBucketIdMinValue_05(base.GetCppThis());
		}

		// Token: 0x0600D82C RID: 55340
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointSetStreamer_GetCreateVerticesCellArray_06(HandleRef pThis);

		/// <summary>
		/// Set/Get if a cell array of vertices will be created.
		///
		/// The default is on.
		/// </summary>
		// Token: 0x0600D82D RID: 55341 RVA: 0x0012C79C File Offset: 0x0012A99C
		public virtual bool GetCreateVerticesCellArray()
		{
			return vtkPointSetStreamer.vtkPointSetStreamer_GetCreateVerticesCellArray_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0600D82E RID: 55342
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSetStreamer_GetNumberOfBuckets_07(HandleRef pThis);

		/// <summary>
		/// Get the number of buckets.
		///
		/// Note: This method must be called after the first pass.
		/// </summary>
		// Token: 0x0600D82F RID: 55343 RVA: 0x0012C7C4 File Offset: 0x0012A9C4
		public virtual long GetNumberOfBuckets()
		{
			return vtkPointSetStreamer.vtkPointSetStreamer_GetNumberOfBuckets_07(base.GetCppThis());
		}

		// Token: 0x0600D830 RID: 55344
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSetStreamer_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D831 RID: 55345 RVA: 0x0012C7E4 File Offset: 0x0012A9E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointSetStreamer.vtkPointSetStreamer_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600D832 RID: 55346
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSetStreamer_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D833 RID: 55347 RVA: 0x0012C804 File Offset: 0x0012AA04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointSetStreamer.vtkPointSetStreamer_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600D834 RID: 55348
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetStreamer_GetNumberOfPointsPerBucket_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the average number of points in each bucket.
		/// This data member is used to determine the number of buckets.
		///
		/// The default is 1.
		/// </summary>
		// Token: 0x0600D835 RID: 55349 RVA: 0x0012C820 File Offset: 0x0012AA20
		public virtual int GetNumberOfPointsPerBucket()
		{
			return vtkPointSetStreamer.vtkPointSetStreamer_GetNumberOfPointsPerBucket_10(base.GetCppThis());
		}

		// Token: 0x0600D836 RID: 55350
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetStreamer_GetNumberOfPointsPerBucketMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the average number of points in each bucket.
		/// This data member is used to determine the number of buckets.
		///
		/// The default is 1.
		/// </summary>
		// Token: 0x0600D837 RID: 55351 RVA: 0x0012C840 File Offset: 0x0012AA40
		public virtual int GetNumberOfPointsPerBucketMaxValue()
		{
			return vtkPointSetStreamer.vtkPointSetStreamer_GetNumberOfPointsPerBucketMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600D838 RID: 55352
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetStreamer_GetNumberOfPointsPerBucketMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the average number of points in each bucket.
		/// This data member is used to determine the number of buckets.
		///
		/// The default is 1.
		/// </summary>
		// Token: 0x0600D839 RID: 55353 RVA: 0x0012C860 File Offset: 0x0012AA60
		public virtual int GetNumberOfPointsPerBucketMinValue()
		{
			return vtkPointSetStreamer.vtkPointSetStreamer_GetNumberOfPointsPerBucketMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600D83A RID: 55354
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetStreamer_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D83B RID: 55355 RVA: 0x0012C880 File Offset: 0x0012AA80
		public override int IsA(string type)
		{
			return vtkPointSetStreamer.vtkPointSetStreamer_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0600D83C RID: 55356
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetStreamer_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D83D RID: 55357 RVA: 0x0012C8A0 File Offset: 0x0012AAA0
		public new static int IsTypeOf(string type)
		{
			return vtkPointSetStreamer.vtkPointSetStreamer_IsTypeOf_14(type);
		}

		// Token: 0x0600D83E RID: 55358
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetStreamer_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D83F RID: 55359 RVA: 0x0012C8BC File Offset: 0x0012AABC
		public new vtkPointSetStreamer NewInstance()
		{
			vtkPointSetStreamer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetStreamer.vtkPointSetStreamer_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSetStreamer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D840 RID: 55360
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetStreamer_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D841 RID: 55361 RVA: 0x0012C918 File Offset: 0x0012AB18
		public new static vtkPointSetStreamer SafeDownCast(vtkObjectBase o)
		{
			vtkPointSetStreamer vtkPointSetStreamer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetStreamer.vtkPointSetStreamer_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointSetStreamer = (vtkPointSetStreamer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointSetStreamer.Register(null);
				}
			}
			return vtkPointSetStreamer;
		}

		// Token: 0x0600D842 RID: 55362
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetStreamer_SetBucketId_18(HandleRef pThis, long _arg);

		/// <summary>
		/// Set/Get the bucket id to stream.
		/// This data member is used to determine the number of buckets.
		///
		/// The default is 0.
		/// </summary>
		// Token: 0x0600D843 RID: 55363 RVA: 0x0012C997 File Offset: 0x0012AB97
		public virtual void SetBucketId(long _arg)
		{
			vtkPointSetStreamer.vtkPointSetStreamer_SetBucketId_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D844 RID: 55364
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetStreamer_SetCreateVerticesCellArray_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if a cell array of vertices will be created.
		///
		/// The default is on.
		/// </summary>
		// Token: 0x0600D845 RID: 55365 RVA: 0x0012C9A7 File Offset: 0x0012ABA7
		public virtual void SetCreateVerticesCellArray(bool _arg)
		{
			vtkPointSetStreamer.vtkPointSetStreamer_SetCreateVerticesCellArray_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600D846 RID: 55366
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetStreamer_SetNumberOfPointsPerBucket_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the average number of points in each bucket.
		/// This data member is used to determine the number of buckets.
		///
		/// The default is 1.
		/// </summary>
		// Token: 0x0600D847 RID: 55367 RVA: 0x0012C9BF File Offset: 0x0012ABBF
		public virtual void SetNumberOfPointsPerBucket(int _arg)
		{
			vtkPointSetStreamer.vtkPointSetStreamer_SetNumberOfPointsPerBucket_20(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FD6 RID: 4054
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointSetStreamer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FD7 RID: 4055
		public new static readonly string MRClassNameKey = "class vtkPointSetStreamer";
	}
}
