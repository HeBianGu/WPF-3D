using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkMultiTimeStepAlgorithm
	/// </summary>
	/// <remarks>
	///  Superclass for algorithms that would like to make multiple time requests
	///
	/// This class can be inherited by any algorithm that wishes to make multiple
	/// time requests upstream.
	///
	/// A subclass should override `RequestUpdateExtent` and use
	/// `vtkMultiTimeStepAlgorithm::UPDATE_TIME_STEPS` key to indicate which
	/// timesteps are to be requested. This class will then take care of executing
	/// the upstream pipeline to obtain the requested timesteps.
	///
	/// Subclasses can then override `Execute` which is provided a vector of input
	/// data objects corresponding to the requested timesteps.
	///
	/// In VTK 9.1 and earlier, subclasses overrode `RequestData` instead of
	/// `Execute`. RequestData was passed a `vtkMultiBlockDataSet` with blocks corresponding
	/// to the input timesteps. However, with addition of vtkPartitionedDataSet and
	/// vtkPartitionedDataSetCollection in VTK 9.2, it is not possible to package all
	/// input data types into a multiblock dataset. Hence, the method is deprecated
	/// and only used when `Execute` is not overridden.
	/// </remarks>
	// Token: 0x020004F1 RID: 1265
	public class vtkMultiTimeStepAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E449 RID: 58441 RVA: 0x0013DE37 File Offset: 0x0013C037
		static vtkMultiTimeStepAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiTimeStepAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiTimeStepAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E44A RID: 58442 RVA: 0x0013DE5F File Offset: 0x0013C05F
		public vtkMultiTimeStepAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E44B RID: 58443
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiTimeStepAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E44C RID: 58444 RVA: 0x0013DE70 File Offset: 0x0013C070
		public new static vtkMultiTimeStepAlgorithm New()
		{
			vtkMultiTimeStepAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiTimeStepAlgorithm.vtkMultiTimeStepAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiTimeStepAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E44D RID: 58445 RVA: 0x0013DEC4 File Offset: 0x0013C0C4
		public vtkMultiTimeStepAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMultiTimeStepAlgorithm.vtkMultiTimeStepAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E44E RID: 58446 RVA: 0x0013DF08 File Offset: 0x0013C108
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E44F RID: 58447
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiTimeStepAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E450 RID: 58448 RVA: 0x0013DF14 File Offset: 0x0013C114
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMultiTimeStepAlgorithm.vtkMultiTimeStepAlgorithm_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600E451 RID: 58449
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiTimeStepAlgorithm_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E452 RID: 58450 RVA: 0x0013DF34 File Offset: 0x0013C134
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMultiTimeStepAlgorithm.vtkMultiTimeStepAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600E453 RID: 58451
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiTimeStepAlgorithm_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E454 RID: 58452 RVA: 0x0013DF50 File Offset: 0x0013C150
		public override int IsA(string type)
		{
			return vtkMultiTimeStepAlgorithm.vtkMultiTimeStepAlgorithm_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600E455 RID: 58453
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiTimeStepAlgorithm_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E456 RID: 58454 RVA: 0x0013DF70 File Offset: 0x0013C170
		public new static int IsTypeOf(string type)
		{
			return vtkMultiTimeStepAlgorithm.vtkMultiTimeStepAlgorithm_IsTypeOf_04(type);
		}

		// Token: 0x0600E457 RID: 58455
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiTimeStepAlgorithm_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E458 RID: 58456 RVA: 0x0013DF8C File Offset: 0x0013C18C
		public new vtkMultiTimeStepAlgorithm NewInstance()
		{
			vtkMultiTimeStepAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiTimeStepAlgorithm.vtkMultiTimeStepAlgorithm_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiTimeStepAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E459 RID: 58457
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiTimeStepAlgorithm_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E45A RID: 58458 RVA: 0x0013DFE8 File Offset: 0x0013C1E8
		public new static vtkMultiTimeStepAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkMultiTimeStepAlgorithm vtkMultiTimeStepAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiTimeStepAlgorithm.vtkMultiTimeStepAlgorithm_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiTimeStepAlgorithm = (vtkMultiTimeStepAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiTimeStepAlgorithm.Register(null);
				}
			}
			return vtkMultiTimeStepAlgorithm;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010C7 RID: 4295
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiTimeStepAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010C8 RID: 4296
		public new static readonly string MRClassNameKey = "class vtkMultiTimeStepAlgorithm";
	}
}
