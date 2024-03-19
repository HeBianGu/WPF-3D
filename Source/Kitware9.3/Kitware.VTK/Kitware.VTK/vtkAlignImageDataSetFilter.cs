using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkAlignImageDataSetFilter
	/// </summary>
	/// <remarks>
	///  align collection of image datasets to use a global origin
	///
	/// When dealing with a collection of image datasets, either in a composite
	/// dataset or in a distributed environment, it is not uncommon to have each
	/// dataset have its own unique origin such that the extents for each start at 0.
	/// However, if the images are parts of a whole, then several filters like
	/// vtkExtractVOI that simply use extents fail to execute correctly. Such
	/// filters require that all parts use the same global origin and set local
	/// extents accordingly. This filter can be used to align such image
	/// datasets. Essentially, this filter ensures all image datasets have the same
	/// origin and each blocks extents are set relative to that origin. This requires
	/// that all images have the same spacing.
	/// </remarks>
	// Token: 0x020004F5 RID: 1269
	public class vtkAlignImageDataSetFilter : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E4A9 RID: 58537 RVA: 0x0013E823 File Offset: 0x0013CA23
		static vtkAlignImageDataSetFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAlignImageDataSetFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAlignImageDataSetFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E4AA RID: 58538 RVA: 0x0013E84B File Offset: 0x0013CA4B
		public vtkAlignImageDataSetFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E4AB RID: 58539
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlignImageDataSetFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4AC RID: 58540 RVA: 0x0013E85C File Offset: 0x0013CA5C
		public new static vtkAlignImageDataSetFilter New()
		{
			vtkAlignImageDataSetFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlignImageDataSetFilter.vtkAlignImageDataSetFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAlignImageDataSetFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4AD RID: 58541 RVA: 0x0013E8B0 File Offset: 0x0013CAB0
		public vtkAlignImageDataSetFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAlignImageDataSetFilter.vtkAlignImageDataSetFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E4AE RID: 58542 RVA: 0x0013E8F4 File Offset: 0x0013CAF4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E4AF RID: 58543
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlignImageDataSetFilter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the controller to use. By default
		/// vtkMultiProcessController::GlobalController will be used.
		/// </summary>
		// Token: 0x0600E4B0 RID: 58544 RVA: 0x0013E900 File Offset: 0x0013CB00
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlignImageDataSetFilter.vtkAlignImageDataSetFilter_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E4B1 RID: 58545
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlignImageDataSetFilter_GetMinimumExtent_02(HandleRef pThis);

		/// <summary>
		/// Specify the global minimum extent to use. By default this is set to `(0,0,0)`.
		/// </summary>
		// Token: 0x0600E4B2 RID: 58546 RVA: 0x0013E970 File Offset: 0x0013CB70
		public virtual int[] GetMinimumExtent()
		{
			IntPtr intPtr = vtkAlignImageDataSetFilter.vtkAlignImageDataSetFilter_GetMinimumExtent_02(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600E4B3 RID: 58547
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlignImageDataSetFilter_GetMinimumExtent_03(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Specify the global minimum extent to use. By default this is set to `(0,0,0)`.
		/// </summary>
		// Token: 0x0600E4B4 RID: 58548 RVA: 0x0013E9B8 File Offset: 0x0013CBB8
		public virtual void GetMinimumExtent(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkAlignImageDataSetFilter.vtkAlignImageDataSetFilter_GetMinimumExtent_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600E4B5 RID: 58549
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlignImageDataSetFilter_GetMinimumExtent_04(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the global minimum extent to use. By default this is set to `(0,0,0)`.
		/// </summary>
		// Token: 0x0600E4B6 RID: 58550 RVA: 0x0013E9CA File Offset: 0x0013CBCA
		public virtual void GetMinimumExtent(IntPtr _arg)
		{
			vtkAlignImageDataSetFilter.vtkAlignImageDataSetFilter_GetMinimumExtent_04(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E4B7 RID: 58551
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAlignImageDataSetFilter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4B8 RID: 58552 RVA: 0x0013E9DC File Offset: 0x0013CBDC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAlignImageDataSetFilter.vtkAlignImageDataSetFilter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600E4B9 RID: 58553
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAlignImageDataSetFilter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4BA RID: 58554 RVA: 0x0013E9FC File Offset: 0x0013CBFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAlignImageDataSetFilter.vtkAlignImageDataSetFilter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600E4BB RID: 58555
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlignImageDataSetFilter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4BC RID: 58556 RVA: 0x0013EA18 File Offset: 0x0013CC18
		public override int IsA(string type)
		{
			return vtkAlignImageDataSetFilter.vtkAlignImageDataSetFilter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600E4BD RID: 58557
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlignImageDataSetFilter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4BE RID: 58558 RVA: 0x0013EA38 File Offset: 0x0013CC38
		public new static int IsTypeOf(string type)
		{
			return vtkAlignImageDataSetFilter.vtkAlignImageDataSetFilter_IsTypeOf_08(type);
		}

		// Token: 0x0600E4BF RID: 58559
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlignImageDataSetFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4C0 RID: 58560 RVA: 0x0013EA54 File Offset: 0x0013CC54
		public new vtkAlignImageDataSetFilter NewInstance()
		{
			vtkAlignImageDataSetFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlignImageDataSetFilter.vtkAlignImageDataSetFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAlignImageDataSetFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E4C1 RID: 58561
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlignImageDataSetFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E4C2 RID: 58562 RVA: 0x0013EAB0 File Offset: 0x0013CCB0
		public new static vtkAlignImageDataSetFilter SafeDownCast(vtkObjectBase o)
		{
			vtkAlignImageDataSetFilter vtkAlignImageDataSetFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlignImageDataSetFilter.vtkAlignImageDataSetFilter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlignImageDataSetFilter = (vtkAlignImageDataSetFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlignImageDataSetFilter.Register(null);
				}
			}
			return vtkAlignImageDataSetFilter;
		}

		// Token: 0x0600E4C3 RID: 58563
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlignImageDataSetFilter_SetController_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the controller to use. By default
		/// vtkMultiProcessController::GlobalController will be used.
		/// </summary>
		// Token: 0x0600E4C4 RID: 58564 RVA: 0x0013EB30 File Offset: 0x0013CD30
		public void SetController(vtkMultiProcessController arg0)
		{
			vtkAlignImageDataSetFilter.vtkAlignImageDataSetFilter_SetController_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600E4C5 RID: 58565
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlignImageDataSetFilter_SetMinimumExtent_13(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Specify the global minimum extent to use. By default this is set to `(0,0,0)`.
		/// </summary>
		// Token: 0x0600E4C6 RID: 58566 RVA: 0x0013EB5F File Offset: 0x0013CD5F
		public virtual void SetMinimumExtent(int _arg1, int _arg2, int _arg3)
		{
			vtkAlignImageDataSetFilter.vtkAlignImageDataSetFilter_SetMinimumExtent_13(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600E4C7 RID: 58567
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlignImageDataSetFilter_SetMinimumExtent_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the global minimum extent to use. By default this is set to `(0,0,0)`.
		/// </summary>
		// Token: 0x0600E4C8 RID: 58568 RVA: 0x0013EB71 File Offset: 0x0013CD71
		public virtual void SetMinimumExtent(IntPtr _arg)
		{
			vtkAlignImageDataSetFilter.vtkAlignImageDataSetFilter_SetMinimumExtent_14(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010CF RID: 4303
		public new const string MRFullTypeName = "Kitware.VTK.vtkAlignImageDataSetFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010D0 RID: 4304
		public new static readonly string MRClassNameKey = "class vtkAlignImageDataSetFilter";
	}
}
