using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkPExtractDataArraysOverTime
	/// </summary>
	/// <remarks>
	///  parallel version of vtkExtractDataArraysOverTime.
	///
	/// vtkPExtractDataArraysOverTime adds distributed data support to
	/// vtkExtractDataArraysOverTime.
	///
	/// It combines results from all ranks and produce non-empty result only on rank 0.
	///
	/// @section vtkPExtractDataArraysOverTime-caveats Caveats
	///
	/// This filter's behavior when `ReportStatisticsOnly` is true is buggy and will
	/// change in the future. When `ReportStatisticsOnly` currently, each rank
	/// computes separate stats for local data. Consequently, this filter preserves
	/// each processes results separately (by adding suffix &lt;tt&gt;rank=\&lt;rank num\&gt;&lt;/tt&gt; to each
	/// of the block names, as appropriate. In future, we plan to fix this to
	/// correctly compute stats in parallel for each block.
	/// </remarks>
	// Token: 0x02000510 RID: 1296
	public class vtkPExtractDataArraysOverTime : vtkExtractDataArraysOverTime
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E81E RID: 59422 RVA: 0x0014375F File Offset: 0x0014195F
		static vtkPExtractDataArraysOverTime()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPExtractDataArraysOverTime.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPExtractDataArraysOverTime"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E81F RID: 59423 RVA: 0x00143787 File Offset: 0x00141987
		public vtkPExtractDataArraysOverTime(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E820 RID: 59424
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPExtractDataArraysOverTime_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E821 RID: 59425 RVA: 0x00143798 File Offset: 0x00141998
		public new static vtkPExtractDataArraysOverTime New()
		{
			vtkPExtractDataArraysOverTime result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPExtractDataArraysOverTime.vtkPExtractDataArraysOverTime_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPExtractDataArraysOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E822 RID: 59426 RVA: 0x001437EC File Offset: 0x001419EC
		public vtkPExtractDataArraysOverTime() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPExtractDataArraysOverTime.vtkPExtractDataArraysOverTime_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E823 RID: 59427 RVA: 0x00143830 File Offset: 0x00141A30
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E824 RID: 59428
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPExtractDataArraysOverTime_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set and get the controller.
		/// </summary>
		// Token: 0x0600E825 RID: 59429 RVA: 0x0014383C File Offset: 0x00141A3C
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPExtractDataArraysOverTime.vtkPExtractDataArraysOverTime_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x0600E826 RID: 59430
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPExtractDataArraysOverTime_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E827 RID: 59431 RVA: 0x001438AC File Offset: 0x00141AAC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPExtractDataArraysOverTime.vtkPExtractDataArraysOverTime_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E828 RID: 59432
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPExtractDataArraysOverTime_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E829 RID: 59433 RVA: 0x001438CC File Offset: 0x00141ACC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPExtractDataArraysOverTime.vtkPExtractDataArraysOverTime_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E82A RID: 59434
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPExtractDataArraysOverTime_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E82B RID: 59435 RVA: 0x001438E8 File Offset: 0x00141AE8
		public override int IsA(string type)
		{
			return vtkPExtractDataArraysOverTime.vtkPExtractDataArraysOverTime_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600E82C RID: 59436
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPExtractDataArraysOverTime_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E82D RID: 59437 RVA: 0x00143908 File Offset: 0x00141B08
		public new static int IsTypeOf(string type)
		{
			return vtkPExtractDataArraysOverTime.vtkPExtractDataArraysOverTime_IsTypeOf_05(type);
		}

		// Token: 0x0600E82E RID: 59438
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPExtractDataArraysOverTime_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E82F RID: 59439 RVA: 0x00143924 File Offset: 0x00141B24
		public new vtkPExtractDataArraysOverTime NewInstance()
		{
			vtkPExtractDataArraysOverTime result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPExtractDataArraysOverTime.vtkPExtractDataArraysOverTime_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPExtractDataArraysOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E830 RID: 59440
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPExtractDataArraysOverTime_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E831 RID: 59441 RVA: 0x00143980 File Offset: 0x00141B80
		public new static vtkPExtractDataArraysOverTime SafeDownCast(vtkObjectBase o)
		{
			vtkPExtractDataArraysOverTime vtkPExtractDataArraysOverTime = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPExtractDataArraysOverTime.vtkPExtractDataArraysOverTime_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPExtractDataArraysOverTime = (vtkPExtractDataArraysOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPExtractDataArraysOverTime.Register(null);
				}
			}
			return vtkPExtractDataArraysOverTime;
		}

		// Token: 0x0600E832 RID: 59442
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPExtractDataArraysOverTime_SetController_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set and get the controller.
		/// </summary>
		// Token: 0x0600E833 RID: 59443 RVA: 0x00143A00 File Offset: 0x00141C00
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPExtractDataArraysOverTime.vtkPExtractDataArraysOverTime_SetController_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400110A RID: 4362
		public new const string MRFullTypeName = "Kitware.VTK.vtkPExtractDataArraysOverTime";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400110B RID: 4363
		public new static readonly string MRClassNameKey = "class vtkPExtractDataArraysOverTime";
	}
}
