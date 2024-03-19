using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkPExtractExodusGlobalTemporalVariables
	/// </summary>
	/// <remarks>
	///  parallel version of vtkExtractExodusGlobalTemporalVariables.
	///
	/// vtkPExtractExodusGlobalTemporalVariables is a parallel version of
	/// vtkExtractExodusGlobalTemporalVariables that handles synchronization between
	/// multiple ranks. Since vtkPExodusIIReader has explicit sycnchronization
	/// between ranks its essential that downstream filters make consistent requests
	/// on all ranks to avoid deadlocks. Since global variables need not be provided
	/// on all ranks, without explicit coordination
	/// vtkExtractExodusGlobalTemporalVariables may end up not making requests on
	/// certain ranks causing deadlocks.
	/// </remarks>
	// Token: 0x02000512 RID: 1298
	public class vtkPExtractExodusGlobalTemporalVariables : vtkExtractExodusGlobalTemporalVariables
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E84E RID: 59470 RVA: 0x00143CBF File Offset: 0x00141EBF
		static vtkPExtractExodusGlobalTemporalVariables()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPExtractExodusGlobalTemporalVariables.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPExtractExodusGlobalTemporalVariables"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E84F RID: 59471 RVA: 0x00143CE7 File Offset: 0x00141EE7
		public vtkPExtractExodusGlobalTemporalVariables(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E850 RID: 59472
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPExtractExodusGlobalTemporalVariables_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E851 RID: 59473 RVA: 0x00143CF8 File Offset: 0x00141EF8
		public new static vtkPExtractExodusGlobalTemporalVariables New()
		{
			vtkPExtractExodusGlobalTemporalVariables result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPExtractExodusGlobalTemporalVariables.vtkPExtractExodusGlobalTemporalVariables_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPExtractExodusGlobalTemporalVariables)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E852 RID: 59474 RVA: 0x00143D4C File Offset: 0x00141F4C
		public vtkPExtractExodusGlobalTemporalVariables() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPExtractExodusGlobalTemporalVariables.vtkPExtractExodusGlobalTemporalVariables_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E853 RID: 59475 RVA: 0x00143D90 File Offset: 0x00141F90
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E854 RID: 59476
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPExtractExodusGlobalTemporalVariables_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the controller to use. By default
		/// `vtkMultiProcessController::GlobalController` will be used.
		/// </summary>
		// Token: 0x0600E855 RID: 59477 RVA: 0x00143D9C File Offset: 0x00141F9C
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPExtractExodusGlobalTemporalVariables.vtkPExtractExodusGlobalTemporalVariables_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E856 RID: 59478
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPExtractExodusGlobalTemporalVariables_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E857 RID: 59479 RVA: 0x00143E0C File Offset: 0x0014200C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPExtractExodusGlobalTemporalVariables.vtkPExtractExodusGlobalTemporalVariables_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E858 RID: 59480
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPExtractExodusGlobalTemporalVariables_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E859 RID: 59481 RVA: 0x00143E2C File Offset: 0x0014202C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPExtractExodusGlobalTemporalVariables.vtkPExtractExodusGlobalTemporalVariables_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E85A RID: 59482
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPExtractExodusGlobalTemporalVariables_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E85B RID: 59483 RVA: 0x00143E48 File Offset: 0x00142048
		public override int IsA(string type)
		{
			return vtkPExtractExodusGlobalTemporalVariables.vtkPExtractExodusGlobalTemporalVariables_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600E85C RID: 59484
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPExtractExodusGlobalTemporalVariables_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E85D RID: 59485 RVA: 0x00143E68 File Offset: 0x00142068
		public new static int IsTypeOf(string type)
		{
			return vtkPExtractExodusGlobalTemporalVariables.vtkPExtractExodusGlobalTemporalVariables_IsTypeOf_05(type);
		}

		// Token: 0x0600E85E RID: 59486
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPExtractExodusGlobalTemporalVariables_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E85F RID: 59487 RVA: 0x00143E84 File Offset: 0x00142084
		public new vtkPExtractExodusGlobalTemporalVariables NewInstance()
		{
			vtkPExtractExodusGlobalTemporalVariables result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPExtractExodusGlobalTemporalVariables.vtkPExtractExodusGlobalTemporalVariables_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPExtractExodusGlobalTemporalVariables)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E860 RID: 59488
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPExtractExodusGlobalTemporalVariables_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E861 RID: 59489 RVA: 0x00143EE0 File Offset: 0x001420E0
		public new static vtkPExtractExodusGlobalTemporalVariables SafeDownCast(vtkObjectBase o)
		{
			vtkPExtractExodusGlobalTemporalVariables vtkPExtractExodusGlobalTemporalVariables = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPExtractExodusGlobalTemporalVariables.vtkPExtractExodusGlobalTemporalVariables_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPExtractExodusGlobalTemporalVariables = (vtkPExtractExodusGlobalTemporalVariables)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPExtractExodusGlobalTemporalVariables.Register(null);
				}
			}
			return vtkPExtractExodusGlobalTemporalVariables;
		}

		// Token: 0x0600E862 RID: 59490
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPExtractExodusGlobalTemporalVariables_SetController_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the controller to use. By default
		/// `vtkMultiProcessController::GlobalController` will be used.
		/// </summary>
		// Token: 0x0600E863 RID: 59491 RVA: 0x00143F60 File Offset: 0x00142160
		public void SetController(vtkMultiProcessController arg0)
		{
			vtkPExtractExodusGlobalTemporalVariables.vtkPExtractExodusGlobalTemporalVariables_SetController_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400110E RID: 4366
		public new const string MRFullTypeName = "Kitware.VTK.vtkPExtractExodusGlobalTemporalVariables";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400110F RID: 4367
		public new static readonly string MRClassNameKey = "class vtkPExtractExodusGlobalTemporalVariables";
	}
}
