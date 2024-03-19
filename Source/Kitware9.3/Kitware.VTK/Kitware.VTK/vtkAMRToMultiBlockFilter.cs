using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAMRToMultiBlockFilter
	///
	///
	/// A filter that accepts as input an AMR dataset and produces a corresponding
	/// vtkMultiBlockDataset as output.
	///
	/// </summary>
	/// <seealso>
	///
	/// vtkOverlappingAMR vtkMultiBlockDataSet
	/// </seealso>
	// Token: 0x020004ED RID: 1261
	public class vtkAMRToMultiBlockFilter : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E3DD RID: 58333 RVA: 0x0013D317 File Offset: 0x0013B517
		static vtkAMRToMultiBlockFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMRToMultiBlockFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRToMultiBlockFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E3DE RID: 58334 RVA: 0x0013D33F File Offset: 0x0013B53F
		public vtkAMRToMultiBlockFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E3DF RID: 58335
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRToMultiBlockFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3E0 RID: 58336 RVA: 0x0013D350 File Offset: 0x0013B550
		public new static vtkAMRToMultiBlockFilter New()
		{
			vtkAMRToMultiBlockFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRToMultiBlockFilter.vtkAMRToMultiBlockFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRToMultiBlockFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3E1 RID: 58337 RVA: 0x0013D3A4 File Offset: 0x0013B5A4
		public vtkAMRToMultiBlockFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAMRToMultiBlockFilter.vtkAMRToMultiBlockFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E3E2 RID: 58338 RVA: 0x0013D3E8 File Offset: 0x0013B5E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E3E3 RID: 58339
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRToMultiBlockFilter_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Set/Get a multiprocess controller for parallel processing.
		/// By default this parameter is set to nullptr by the constructor.
		/// </summary>
		// Token: 0x0600E3E4 RID: 58340 RVA: 0x0013D3F4 File Offset: 0x0013B5F4
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkAMRToMultiBlockFilter.vtkAMRToMultiBlockFilter_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0600E3E5 RID: 58341
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRToMultiBlockFilter_FillOutputPortInformation_02(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Set/Get a multiprocess controller for parallel processing.
		/// By default this parameter is set to nullptr by the constructor.
		/// </summary>
		// Token: 0x0600E3E6 RID: 58342 RVA: 0x0013D42C File Offset: 0x0013B62C
		public virtual int FillOutputPortInformation(int port, vtkInformation info)
		{
			return vtkAMRToMultiBlockFilter.vtkAMRToMultiBlockFilter_FillOutputPortInformation_02(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0600E3E7 RID: 58343
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRToMultiBlockFilter_GetController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a multiprocess controller for parallel processing.
		/// By default this parameter is set to nullptr by the constructor.
		/// </summary>
		// Token: 0x0600E3E8 RID: 58344 RVA: 0x0013D464 File Offset: 0x0013B664
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRToMultiBlockFilter.vtkAMRToMultiBlockFilter_GetController_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E3E9 RID: 58345
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRToMultiBlockFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3EA RID: 58346 RVA: 0x0013D4D4 File Offset: 0x0013B6D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMRToMultiBlockFilter.vtkAMRToMultiBlockFilter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600E3EB RID: 58347
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRToMultiBlockFilter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3EC RID: 58348 RVA: 0x0013D4F4 File Offset: 0x0013B6F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMRToMultiBlockFilter.vtkAMRToMultiBlockFilter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600E3ED RID: 58349
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRToMultiBlockFilter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3EE RID: 58350 RVA: 0x0013D510 File Offset: 0x0013B710
		public override int IsA(string type)
		{
			return vtkAMRToMultiBlockFilter.vtkAMRToMultiBlockFilter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600E3EF RID: 58351
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRToMultiBlockFilter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3F0 RID: 58352 RVA: 0x0013D530 File Offset: 0x0013B730
		public new static int IsTypeOf(string type)
		{
			return vtkAMRToMultiBlockFilter.vtkAMRToMultiBlockFilter_IsTypeOf_07(type);
		}

		// Token: 0x0600E3F1 RID: 58353
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRToMultiBlockFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3F2 RID: 58354 RVA: 0x0013D54C File Offset: 0x0013B74C
		public new vtkAMRToMultiBlockFilter NewInstance()
		{
			vtkAMRToMultiBlockFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRToMultiBlockFilter.vtkAMRToMultiBlockFilter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRToMultiBlockFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E3F3 RID: 58355
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRToMultiBlockFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3F4 RID: 58356 RVA: 0x0013D5A8 File Offset: 0x0013B7A8
		public new static vtkAMRToMultiBlockFilter SafeDownCast(vtkObjectBase o)
		{
			vtkAMRToMultiBlockFilter vtkAMRToMultiBlockFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRToMultiBlockFilter.vtkAMRToMultiBlockFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMRToMultiBlockFilter = (vtkAMRToMultiBlockFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMRToMultiBlockFilter.Register(null);
				}
			}
			return vtkAMRToMultiBlockFilter;
		}

		// Token: 0x0600E3F5 RID: 58357
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRToMultiBlockFilter_SetController_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get a multiprocess controller for parallel processing.
		/// By default this parameter is set to nullptr by the constructor.
		/// </summary>
		// Token: 0x0600E3F6 RID: 58358 RVA: 0x0013D628 File Offset: 0x0013B828
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkAMRToMultiBlockFilter.vtkAMRToMultiBlockFilter_SetController_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010BF RID: 4287
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMRToMultiBlockFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010C0 RID: 4288
		public new static readonly string MRClassNameKey = "class vtkAMRToMultiBlockFilter";
	}
}
