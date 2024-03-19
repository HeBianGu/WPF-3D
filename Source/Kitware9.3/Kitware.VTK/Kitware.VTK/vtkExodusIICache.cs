using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// This is the difference between the capacity and the size of the cache.
	/// The result is in MiB.
	/// </summary>
	// Token: 0x020001B7 RID: 439
	public class vtkExodusIICache : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600544C RID: 21580 RVA: 0x0007AC63 File Offset: 0x00078E63
		static vtkExodusIICache()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExodusIICache.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExodusIICache"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600544D RID: 21581 RVA: 0x0007AC8B File Offset: 0x00078E8B
		public vtkExodusIICache(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600544E RID: 21582
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIICache_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600544F RID: 21583 RVA: 0x0007AC9C File Offset: 0x00078E9C
		public new static vtkExodusIICache New()
		{
			vtkExodusIICache result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExodusIICache.vtkExodusIICache_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusIICache)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005450 RID: 21584 RVA: 0x0007ACF0 File Offset: 0x00078EF0
		public vtkExodusIICache() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExodusIICache.vtkExodusIICache_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005451 RID: 21585 RVA: 0x0007AD34 File Offset: 0x00078F34
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005452 RID: 21586
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIICache_Clear_01(HandleRef pThis);

		// Token: 0x06005453 RID: 21587 RVA: 0x0007AD3F File Offset: 0x00078F3F
		public void Clear()
		{
			vtkExodusIICache.vtkExodusIICache_Clear_01(base.GetCppThis());
		}

		// Token: 0x06005454 RID: 21588
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExodusIICache_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06005455 RID: 21589 RVA: 0x0007AD50 File Offset: 0x00078F50
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExodusIICache.vtkExodusIICache_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06005456 RID: 21590
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExodusIICache_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06005457 RID: 21591 RVA: 0x0007AD70 File Offset: 0x00078F70
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExodusIICache.vtkExodusIICache_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06005458 RID: 21592
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExodusIICache_GetSpaceLeft_04(HandleRef pThis);

		/// <summary>
		/// This is the difference between the capacity and the size of the cache.
		/// The result is in MiB.
		/// </summary>
		// Token: 0x06005459 RID: 21593 RVA: 0x0007AD8C File Offset: 0x00078F8C
		public double GetSpaceLeft()
		{
			return vtkExodusIICache.vtkExodusIICache_GetSpaceLeft_04(base.GetCppThis());
		}

		// Token: 0x0600545A RID: 21594
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIICache_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0600545B RID: 21595 RVA: 0x0007ADAC File Offset: 0x00078FAC
		public override int IsA(string type)
		{
			return vtkExodusIICache.vtkExodusIICache_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600545C RID: 21596
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIICache_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0600545D RID: 21597 RVA: 0x0007ADCC File Offset: 0x00078FCC
		public new static int IsTypeOf(string type)
		{
			return vtkExodusIICache.vtkExodusIICache_IsTypeOf_06(type);
		}

		// Token: 0x0600545E RID: 21598
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIICache_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600545F RID: 21599 RVA: 0x0007ADE8 File Offset: 0x00078FE8
		public new vtkExodusIICache NewInstance()
		{
			vtkExodusIICache result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExodusIICache.vtkExodusIICache_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusIICache)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005460 RID: 21600
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExodusIICache_ReduceToSize_09(HandleRef pThis, double newSize);

		/// <summary>
		/// Returns a nonzero value if deletions were required.
		/// </summary>
		// Token: 0x06005461 RID: 21601 RVA: 0x0007AE44 File Offset: 0x00079044
		public int ReduceToSize(double newSize)
		{
			return vtkExodusIICache.vtkExodusIICache_ReduceToSize_09(base.GetCppThis(), newSize);
		}

		// Token: 0x06005462 RID: 21602
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExodusIICache_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06005463 RID: 21603 RVA: 0x0007AE64 File Offset: 0x00079064
		public new static vtkExodusIICache SafeDownCast(vtkObjectBase o)
		{
			vtkExodusIICache vtkExodusIICache = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExodusIICache.vtkExodusIICache_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExodusIICache = (vtkExodusIICache)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExodusIICache.Register(null);
				}
			}
			return vtkExodusIICache;
		}

		// Token: 0x06005464 RID: 21604
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExodusIICache_SetCacheCapacity_11(HandleRef pThis, double sizeInMiB);

		// Token: 0x06005465 RID: 21605 RVA: 0x0007AEE3 File Offset: 0x000790E3
		public void SetCacheCapacity(double sizeInMiB)
		{
			vtkExodusIICache.vtkExodusIICache_SetCacheCapacity_11(base.GetCppThis(), sizeInMiB);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007DB RID: 2011
		public new const string MRFullTypeName = "Kitware.VTK.vtkExodusIICache";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007DC RID: 2012
		public new static readonly string MRClassNameKey = "class vtkExodusIICache";
	}
}
