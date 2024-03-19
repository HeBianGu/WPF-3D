using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTemporalDataSetCache
	/// </summary>
	/// <remarks>
	///    cache time steps
	///
	/// vtkTemporalDataSetCache cache time step requests of a temporal dataset,
	/// when cached data is requested it is returned using a shallow copy.
	/// @par Thanks:
	/// Ken Martin (Kitware) and John Bidiscombe of
	/// CSCS - Swiss National Supercomputing Centre
	/// for creating and contributing this class.
	/// For related material, please refer to :
	/// John Biddiscombe, Berk Geveci, Ken Martin, Kenneth Moreland, David Thompson,
	/// "Time Dependent Processing in a Parallel Pipeline Architecture",
	/// IEEE Visualization 2007.
	/// </remarks>
	// Token: 0x02000619 RID: 1561
	public class vtkTemporalDataSetCache : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010F16 RID: 69398 RVA: 0x00179C53 File Offset: 0x00177E53
		static vtkTemporalDataSetCache()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalDataSetCache.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalDataSetCache"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010F17 RID: 69399 RVA: 0x00179C7B File Offset: 0x00177E7B
		public vtkTemporalDataSetCache(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010F18 RID: 69400
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalDataSetCache_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F19 RID: 69401 RVA: 0x00179C8C File Offset: 0x00177E8C
		public new static vtkTemporalDataSetCache New()
		{
			vtkTemporalDataSetCache result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalDataSetCache.vtkTemporalDataSetCache_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalDataSetCache)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F1A RID: 69402 RVA: 0x00179CE0 File Offset: 0x00177EE0
		public vtkTemporalDataSetCache() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTemporalDataSetCache.vtkTemporalDataSetCache_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010F1B RID: 69403 RVA: 0x00179D24 File Offset: 0x00177F24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010F1C RID: 69404
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalDataSetCache_CacheInMemkindOff_01(HandleRef pThis);

		/// <summary>
		/// Tells the filter that it should store the dataobjects it holds in memkind
		/// extended memory space rather than in normal memory space.
		/// </summary>
		// Token: 0x06010F1D RID: 69405 RVA: 0x00179D2F File Offset: 0x00177F2F
		public virtual void CacheInMemkindOff()
		{
			vtkTemporalDataSetCache.vtkTemporalDataSetCache_CacheInMemkindOff_01(base.GetCppThis());
		}

		// Token: 0x06010F1E RID: 69406
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalDataSetCache_CacheInMemkindOn_02(HandleRef pThis);

		/// <summary>
		/// Tells the filter that it should store the dataobjects it holds in memkind
		/// extended memory space rather than in normal memory space.
		/// </summary>
		// Token: 0x06010F1F RID: 69407 RVA: 0x00179D3E File Offset: 0x00177F3E
		public virtual void CacheInMemkindOn()
		{
			vtkTemporalDataSetCache.vtkTemporalDataSetCache_CacheInMemkindOn_02(base.GetCppThis());
		}

		// Token: 0x06010F20 RID: 69408
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTemporalDataSetCache_GetCacheInMemkind_03(HandleRef pThis);

		/// <summary>
		/// Tells the filter that it should store the dataobjects it holds in memkind
		/// extended memory space rather than in normal memory space.
		/// </summary>
		// Token: 0x06010F21 RID: 69409 RVA: 0x00179D50 File Offset: 0x00177F50
		public virtual bool GetCacheInMemkind()
		{
			return vtkTemporalDataSetCache.vtkTemporalDataSetCache_GetCacheInMemkind_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06010F22 RID: 69410
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalDataSetCache_GetCacheSize_04(HandleRef pThis);

		/// <summary>
		/// This is the maximum number of time steps that can be retained in memory.
		/// it defaults to 10.
		/// </summary>
		// Token: 0x06010F23 RID: 69411 RVA: 0x00179D78 File Offset: 0x00177F78
		public virtual int GetCacheSize()
		{
			return vtkTemporalDataSetCache.vtkTemporalDataSetCache_GetCacheSize_04(base.GetCppThis());
		}

		// Token: 0x06010F24 RID: 69412
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTemporalDataSetCache_GetIsASource_05(HandleRef pThis);

		/// <summary>
		/// Tells the filter that needs to act as a pipeline source rather than a midpipline filter. In
		/// that situation it needs to react differently in a few cases.
		/// </summary>
		// Token: 0x06010F25 RID: 69413 RVA: 0x00179D98 File Offset: 0x00177F98
		public virtual bool GetIsASource()
		{
			return vtkTemporalDataSetCache.vtkTemporalDataSetCache_GetIsASource_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06010F26 RID: 69414
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalDataSetCache_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F27 RID: 69415 RVA: 0x00179DC0 File Offset: 0x00177FC0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTemporalDataSetCache.vtkTemporalDataSetCache_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06010F28 RID: 69416
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalDataSetCache_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F29 RID: 69417 RVA: 0x00179DE0 File Offset: 0x00177FE0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTemporalDataSetCache.vtkTemporalDataSetCache_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06010F2A RID: 69418
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalDataSetCache_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F2B RID: 69419 RVA: 0x00179DFC File Offset: 0x00177FFC
		public override int IsA(string type)
		{
			return vtkTemporalDataSetCache.vtkTemporalDataSetCache_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06010F2C RID: 69420
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalDataSetCache_IsASourceOff_09(HandleRef pThis);

		/// <summary>
		/// Tells the filter that needs to act as a pipeline source rather than a midpipline filter. In
		/// that situation it needs to react differently in a few cases.
		/// </summary>
		// Token: 0x06010F2D RID: 69421 RVA: 0x00179E1C File Offset: 0x0017801C
		public virtual void IsASourceOff()
		{
			vtkTemporalDataSetCache.vtkTemporalDataSetCache_IsASourceOff_09(base.GetCppThis());
		}

		// Token: 0x06010F2E RID: 69422
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalDataSetCache_IsASourceOn_10(HandleRef pThis);

		/// <summary>
		/// Tells the filter that needs to act as a pipeline source rather than a midpipline filter. In
		/// that situation it needs to react differently in a few cases.
		/// </summary>
		// Token: 0x06010F2F RID: 69423 RVA: 0x00179E2B File Offset: 0x0017802B
		public virtual void IsASourceOn()
		{
			vtkTemporalDataSetCache.vtkTemporalDataSetCache_IsASourceOn_10(base.GetCppThis());
		}

		// Token: 0x06010F30 RID: 69424
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalDataSetCache_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F31 RID: 69425 RVA: 0x00179E3C File Offset: 0x0017803C
		public new static int IsTypeOf(string type)
		{
			return vtkTemporalDataSetCache.vtkTemporalDataSetCache_IsTypeOf_11(type);
		}

		// Token: 0x06010F32 RID: 69426
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalDataSetCache_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F33 RID: 69427 RVA: 0x00179E58 File Offset: 0x00178058
		public new vtkTemporalDataSetCache NewInstance()
		{
			vtkTemporalDataSetCache result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalDataSetCache.vtkTemporalDataSetCache_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalDataSetCache)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010F34 RID: 69428
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalDataSetCache_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010F35 RID: 69429 RVA: 0x00179EB4 File Offset: 0x001780B4
		public new static vtkTemporalDataSetCache SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalDataSetCache vtkTemporalDataSetCache = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalDataSetCache.vtkTemporalDataSetCache_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalDataSetCache = (vtkTemporalDataSetCache)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalDataSetCache.Register(null);
				}
			}
			return vtkTemporalDataSetCache;
		}

		// Token: 0x06010F36 RID: 69430
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalDataSetCache_SetCacheInMemkind_15(HandleRef pThis, byte _arg);

		/// <summary>
		/// Tells the filter that it should store the dataobjects it holds in memkind
		/// extended memory space rather than in normal memory space.
		/// </summary>
		// Token: 0x06010F37 RID: 69431 RVA: 0x00179F33 File Offset: 0x00178133
		public virtual void SetCacheInMemkind(bool _arg)
		{
			vtkTemporalDataSetCache.vtkTemporalDataSetCache_SetCacheInMemkind_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06010F38 RID: 69432
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalDataSetCache_SetCacheSize_16(HandleRef pThis, int size);

		/// <summary>
		/// This is the maximum number of time steps that can be retained in memory.
		/// it defaults to 10.
		/// </summary>
		// Token: 0x06010F39 RID: 69433 RVA: 0x00179F4B File Offset: 0x0017814B
		public void SetCacheSize(int size)
		{
			vtkTemporalDataSetCache.vtkTemporalDataSetCache_SetCacheSize_16(base.GetCppThis(), size);
		}

		// Token: 0x06010F3A RID: 69434
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalDataSetCache_SetIsASource_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// Tells the filter that needs to act as a pipeline source rather than a midpipline filter. In
		/// that situation it needs to react differently in a few cases.
		/// </summary>
		// Token: 0x06010F3B RID: 69435 RVA: 0x00179F5B File Offset: 0x0017815B
		public virtual void SetIsASource(bool _arg)
		{
			vtkTemporalDataSetCache.vtkTemporalDataSetCache_SetIsASource_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001394 RID: 5012
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalDataSetCache";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001395 RID: 5013
		public new static readonly string MRClassNameKey = "class vtkTemporalDataSetCache";
	}
}
