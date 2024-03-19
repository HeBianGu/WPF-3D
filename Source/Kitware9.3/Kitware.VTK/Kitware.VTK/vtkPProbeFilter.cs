using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPProbeFilter
	/// </summary>
	/// <remarks>
	///    probe dataset in parallel
	///
	/// This filter works correctly only if the whole geometry dataset
	/// (that specify the point locations used to probe input) is available on all
	/// nodes.
	/// </remarks>
	// Token: 0x02000528 RID: 1320
	public class vtkPProbeFilter : vtkCompositeDataProbeFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EC27 RID: 60455 RVA: 0x00149387 File Offset: 0x00147587
		static vtkPProbeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPProbeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPProbeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EC28 RID: 60456 RVA: 0x001493AF File Offset: 0x001475AF
		public vtkPProbeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EC29 RID: 60457
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPProbeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC2A RID: 60458 RVA: 0x001493C0 File Offset: 0x001475C0
		public new static vtkPProbeFilter New()
		{
			vtkPProbeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPProbeFilter.vtkPProbeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC2B RID: 60459 RVA: 0x00149414 File Offset: 0x00147614
		public vtkPProbeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPProbeFilter.vtkPProbeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EC2C RID: 60460 RVA: 0x00149458 File Offset: 0x00147658
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EC2D RID: 60461
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPProbeFilter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set and get the controller.
		/// </summary>
		// Token: 0x0600EC2E RID: 60462 RVA: 0x00149464 File Offset: 0x00147664
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPProbeFilter.vtkPProbeFilter_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600EC2F RID: 60463
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPProbeFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC30 RID: 60464 RVA: 0x001494D4 File Offset: 0x001476D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPProbeFilter.vtkPProbeFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600EC31 RID: 60465
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPProbeFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC32 RID: 60466 RVA: 0x001494F4 File Offset: 0x001476F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPProbeFilter.vtkPProbeFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600EC33 RID: 60467
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPProbeFilter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC34 RID: 60468 RVA: 0x00149510 File Offset: 0x00147710
		public override int IsA(string type)
		{
			return vtkPProbeFilter.vtkPProbeFilter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600EC35 RID: 60469
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPProbeFilter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC36 RID: 60470 RVA: 0x00149530 File Offset: 0x00147730
		public new static int IsTypeOf(string type)
		{
			return vtkPProbeFilter.vtkPProbeFilter_IsTypeOf_05(type);
		}

		// Token: 0x0600EC37 RID: 60471
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPProbeFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC38 RID: 60472 RVA: 0x0014954C File Offset: 0x0014774C
		public new vtkPProbeFilter NewInstance()
		{
			vtkPProbeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPProbeFilter.vtkPProbeFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EC39 RID: 60473
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPProbeFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EC3A RID: 60474 RVA: 0x001495A8 File Offset: 0x001477A8
		public new static vtkPProbeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPProbeFilter vtkPProbeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPProbeFilter.vtkPProbeFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPProbeFilter = (vtkPProbeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPProbeFilter.Register(null);
				}
			}
			return vtkPProbeFilter;
		}

		// Token: 0x0600EC3B RID: 60475
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPProbeFilter_SetController_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set and get the controller.
		/// </summary>
		// Token: 0x0600EC3C RID: 60476 RVA: 0x00149628 File Offset: 0x00147828
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPProbeFilter.vtkPProbeFilter_SetController_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400113F RID: 4415
		public new const string MRFullTypeName = "Kitware.VTK.vtkPProbeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001140 RID: 4416
		public new static readonly string MRClassNameKey = "class vtkPProbeFilter";
	}
}
