using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAdaptiveTemporalInterpolator
	/// </summary>
	/// <remarks>
	///    interpolate datasets between time steps to produce a new dataset
	///
	/// vtkAdaptiveTemporalInterpolator extends vtkTemporalInterpolator to
	/// interpolate between timesteps when mesh topology appears to be different.
	/// </remarks>
	// Token: 0x020004F3 RID: 1267
	public class vtkAdaptiveTemporalInterpolator : vtkTemporalInterpolator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E479 RID: 58489 RVA: 0x0013E337 File Offset: 0x0013C537
		static vtkAdaptiveTemporalInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAdaptiveTemporalInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAdaptiveTemporalInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E47A RID: 58490 RVA: 0x0013E35F File Offset: 0x0013C55F
		public vtkAdaptiveTemporalInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E47B RID: 58491
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdaptiveTemporalInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E47C RID: 58492 RVA: 0x0013E370 File Offset: 0x0013C570
		public new static vtkAdaptiveTemporalInterpolator New()
		{
			vtkAdaptiveTemporalInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdaptiveTemporalInterpolator.vtkAdaptiveTemporalInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAdaptiveTemporalInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E47D RID: 58493 RVA: 0x0013E3C4 File Offset: 0x0013C5C4
		public vtkAdaptiveTemporalInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAdaptiveTemporalInterpolator.vtkAdaptiveTemporalInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E47E RID: 58494 RVA: 0x0013E408 File Offset: 0x0013C608
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E47F RID: 58495
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdaptiveTemporalInterpolator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E480 RID: 58496 RVA: 0x0013E414 File Offset: 0x0013C614
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAdaptiveTemporalInterpolator.vtkAdaptiveTemporalInterpolator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600E481 RID: 58497
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdaptiveTemporalInterpolator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E482 RID: 58498 RVA: 0x0013E434 File Offset: 0x0013C634
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAdaptiveTemporalInterpolator.vtkAdaptiveTemporalInterpolator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600E483 RID: 58499
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAdaptiveTemporalInterpolator_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E484 RID: 58500 RVA: 0x0013E450 File Offset: 0x0013C650
		public override int IsA(string type)
		{
			return vtkAdaptiveTemporalInterpolator.vtkAdaptiveTemporalInterpolator_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600E485 RID: 58501
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAdaptiveTemporalInterpolator_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E486 RID: 58502 RVA: 0x0013E470 File Offset: 0x0013C670
		public new static int IsTypeOf(string type)
		{
			return vtkAdaptiveTemporalInterpolator.vtkAdaptiveTemporalInterpolator_IsTypeOf_04(type);
		}

		// Token: 0x0600E487 RID: 58503
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdaptiveTemporalInterpolator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E488 RID: 58504 RVA: 0x0013E48C File Offset: 0x0013C68C
		public new vtkAdaptiveTemporalInterpolator NewInstance()
		{
			vtkAdaptiveTemporalInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdaptiveTemporalInterpolator.vtkAdaptiveTemporalInterpolator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAdaptiveTemporalInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E489 RID: 58505
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdaptiveTemporalInterpolator_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E48A RID: 58506 RVA: 0x0013E4E8 File Offset: 0x0013C6E8
		public new static vtkAdaptiveTemporalInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkAdaptiveTemporalInterpolator vtkAdaptiveTemporalInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdaptiveTemporalInterpolator.vtkAdaptiveTemporalInterpolator_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAdaptiveTemporalInterpolator = (vtkAdaptiveTemporalInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAdaptiveTemporalInterpolator.Register(null);
				}
			}
			return vtkAdaptiveTemporalInterpolator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010CB RID: 4299
		public new const string MRFullTypeName = "Kitware.VTK.vtkAdaptiveTemporalInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010CC RID: 4300
		public new static readonly string MRClassNameKey = "class vtkAdaptiveTemporalInterpolator";
	}
}
