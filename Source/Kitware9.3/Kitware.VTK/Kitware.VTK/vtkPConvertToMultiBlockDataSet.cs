using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkPConvertToMultiBlockDataSet
	/// </summary>
	/// <remarks>
	///  parallel version of vtkConvertToMultiBlockDataSet
	///
	/// vtkPConvertToMultiBlockDataSet is the MPI-aware version of
	/// vtkConvertToMultiBlockDataSet.
	///
	/// The extra work this filter does it to ensure that each `vtkPartitionedDataSet` instance
	/// in the input when replaced by a `vtkMultiPieceDataSet in the output,
	/// `vtkMultiPieceDataSet` has piece counts across ranks such the output
	/// multiblock structure is identical on all ranks. `vtkPartitionedDataSet` /
	/// `vtkPartitionedDataSetCollection` doesn't have this requirement and hence the
	/// number of partitions in a `vtkPartitionedDataSet` in the input may not be
	/// identical on all ranks. Hence, this extra check is needed.
	/// </remarks>
	// Token: 0x0200050E RID: 1294
	public class vtkPConvertToMultiBlockDataSet : vtkConvertToMultiBlockDataSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E7E0 RID: 59360 RVA: 0x00143133 File Offset: 0x00141333
		static vtkPConvertToMultiBlockDataSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPConvertToMultiBlockDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPConvertToMultiBlockDataSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E7E1 RID: 59361 RVA: 0x0014315B File Offset: 0x0014135B
		public vtkPConvertToMultiBlockDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E7E2 RID: 59362
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPConvertToMultiBlockDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7E3 RID: 59363 RVA: 0x0014316C File Offset: 0x0014136C
		public new static vtkPConvertToMultiBlockDataSet New()
		{
			vtkPConvertToMultiBlockDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPConvertToMultiBlockDataSet.vtkPConvertToMultiBlockDataSet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPConvertToMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7E4 RID: 59364 RVA: 0x001431C0 File Offset: 0x001413C0
		public vtkPConvertToMultiBlockDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPConvertToMultiBlockDataSet.vtkPConvertToMultiBlockDataSet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E7E5 RID: 59365 RVA: 0x00143204 File Offset: 0x00141404
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E7E6 RID: 59366
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPConvertToMultiBlockDataSet_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the controller to use. By default, initialized to
		/// `vtkMultiProcessController::GetGlobalController` in the constructor.
		/// </summary>
		// Token: 0x0600E7E7 RID: 59367 RVA: 0x00143210 File Offset: 0x00141410
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPConvertToMultiBlockDataSet.vtkPConvertToMultiBlockDataSet_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E7E8 RID: 59368
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPConvertToMultiBlockDataSet_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7E9 RID: 59369 RVA: 0x00143280 File Offset: 0x00141480
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPConvertToMultiBlockDataSet.vtkPConvertToMultiBlockDataSet_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E7EA RID: 59370
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPConvertToMultiBlockDataSet_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7EB RID: 59371 RVA: 0x001432A0 File Offset: 0x001414A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPConvertToMultiBlockDataSet.vtkPConvertToMultiBlockDataSet_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E7EC RID: 59372
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPConvertToMultiBlockDataSet_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7ED RID: 59373 RVA: 0x001432BC File Offset: 0x001414BC
		public override int IsA(string type)
		{
			return vtkPConvertToMultiBlockDataSet.vtkPConvertToMultiBlockDataSet_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600E7EE RID: 59374
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPConvertToMultiBlockDataSet_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7EF RID: 59375 RVA: 0x001432DC File Offset: 0x001414DC
		public new static int IsTypeOf(string type)
		{
			return vtkPConvertToMultiBlockDataSet.vtkPConvertToMultiBlockDataSet_IsTypeOf_05(type);
		}

		// Token: 0x0600E7F0 RID: 59376
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPConvertToMultiBlockDataSet_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7F1 RID: 59377 RVA: 0x001432F8 File Offset: 0x001414F8
		public new vtkPConvertToMultiBlockDataSet NewInstance()
		{
			vtkPConvertToMultiBlockDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPConvertToMultiBlockDataSet.vtkPConvertToMultiBlockDataSet_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPConvertToMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E7F2 RID: 59378
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPConvertToMultiBlockDataSet_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E7F3 RID: 59379 RVA: 0x00143354 File Offset: 0x00141554
		public new static vtkPConvertToMultiBlockDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkPConvertToMultiBlockDataSet vtkPConvertToMultiBlockDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPConvertToMultiBlockDataSet.vtkPConvertToMultiBlockDataSet_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPConvertToMultiBlockDataSet = (vtkPConvertToMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPConvertToMultiBlockDataSet.Register(null);
				}
			}
			return vtkPConvertToMultiBlockDataSet;
		}

		// Token: 0x0600E7F4 RID: 59380
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPConvertToMultiBlockDataSet_SetController_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the controller to use. By default, initialized to
		/// `vtkMultiProcessController::GetGlobalController` in the constructor.
		/// </summary>
		// Token: 0x0600E7F5 RID: 59381 RVA: 0x001433D4 File Offset: 0x001415D4
		public void SetController(vtkMultiProcessController arg0)
		{
			vtkPConvertToMultiBlockDataSet.vtkPConvertToMultiBlockDataSet_SetController_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001106 RID: 4358
		public new const string MRFullTypeName = "Kitware.VTK.vtkPConvertToMultiBlockDataSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001107 RID: 4359
		public new static readonly string MRClassNameKey = "class vtkPConvertToMultiBlockDataSet";
	}
}
