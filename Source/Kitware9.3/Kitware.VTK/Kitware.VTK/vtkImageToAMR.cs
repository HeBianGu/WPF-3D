using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageToAMR
	/// </summary>
	/// <remarks>
	///    filter to convert any vtkImageData to a
	/// vtkOverlappingAMR.
	///
	/// vtkImageToAMR is a simple filter that converts any vtkImageData to a
	/// vtkOverlappingAMR dataset. The input vtkImageData is treated as the highest
	/// refinement available for the highest level. The lower refinements and the
	/// number of blocks is controlled properties specified on the filter.
	/// </remarks>
	// Token: 0x020004EE RID: 1262
	public class vtkImageToAMR : vtkOverlappingAMRAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E3F7 RID: 58359 RVA: 0x0013D657 File Offset: 0x0013B857
		static vtkImageToAMR()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageToAMR.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageToAMR"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E3F8 RID: 58360 RVA: 0x0013D67F File Offset: 0x0013B87F
		public vtkImageToAMR(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E3F9 RID: 58361
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToAMR_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3FA RID: 58362 RVA: 0x0013D690 File Offset: 0x0013B890
		public new static vtkImageToAMR New()
		{
			vtkImageToAMR result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToAMR.vtkImageToAMR_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageToAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E3FB RID: 58363 RVA: 0x0013D6E4 File Offset: 0x0013B8E4
		public vtkImageToAMR() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageToAMR.vtkImageToAMR_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E3FC RID: 58364 RVA: 0x0013D728 File Offset: 0x0013B928
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E3FD RID: 58365
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToAMR_GetMaximumNumberOfBlocks_01(HandleRef pThis);

		/// <summary>
		/// Set the maximum number of blocks in the output
		/// </summary>
		// Token: 0x0600E3FE RID: 58366 RVA: 0x0013D734 File Offset: 0x0013B934
		public virtual int GetMaximumNumberOfBlocks()
		{
			return vtkImageToAMR.vtkImageToAMR_GetMaximumNumberOfBlocks_01(base.GetCppThis());
		}

		// Token: 0x0600E3FF RID: 58367
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToAMR_GetMaximumNumberOfBlocksMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set the maximum number of blocks in the output
		/// </summary>
		// Token: 0x0600E400 RID: 58368 RVA: 0x0013D754 File Offset: 0x0013B954
		public virtual int GetMaximumNumberOfBlocksMaxValue()
		{
			return vtkImageToAMR.vtkImageToAMR_GetMaximumNumberOfBlocksMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0600E401 RID: 58369
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToAMR_GetMaximumNumberOfBlocksMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set the maximum number of blocks in the output
		/// </summary>
		// Token: 0x0600E402 RID: 58370 RVA: 0x0013D774 File Offset: 0x0013B974
		public virtual int GetMaximumNumberOfBlocksMinValue()
		{
			return vtkImageToAMR.vtkImageToAMR_GetMaximumNumberOfBlocksMinValue_03(base.GetCppThis());
		}

		// Token: 0x0600E403 RID: 58371
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageToAMR_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E404 RID: 58372 RVA: 0x0013D794 File Offset: 0x0013B994
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageToAMR.vtkImageToAMR_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600E405 RID: 58373
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageToAMR_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E406 RID: 58374 RVA: 0x0013D7B4 File Offset: 0x0013B9B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageToAMR.vtkImageToAMR_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600E407 RID: 58375
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToAMR_GetNumberOfLevels_06(HandleRef pThis);

		/// <summary>
		/// Set the maximum number of levels in the generated Overlapping-AMR.
		/// </summary>
		// Token: 0x0600E408 RID: 58376 RVA: 0x0013D7D0 File Offset: 0x0013B9D0
		public virtual int GetNumberOfLevels()
		{
			return vtkImageToAMR.vtkImageToAMR_GetNumberOfLevels_06(base.GetCppThis());
		}

		// Token: 0x0600E409 RID: 58377
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToAMR_GetNumberOfLevelsMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Set the maximum number of levels in the generated Overlapping-AMR.
		/// </summary>
		// Token: 0x0600E40A RID: 58378 RVA: 0x0013D7F0 File Offset: 0x0013B9F0
		public virtual int GetNumberOfLevelsMaxValue()
		{
			return vtkImageToAMR.vtkImageToAMR_GetNumberOfLevelsMaxValue_07(base.GetCppThis());
		}

		// Token: 0x0600E40B RID: 58379
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToAMR_GetNumberOfLevelsMinValue_08(HandleRef pThis);

		/// <summary>
		/// Set the maximum number of levels in the generated Overlapping-AMR.
		/// </summary>
		// Token: 0x0600E40C RID: 58380 RVA: 0x0013D810 File Offset: 0x0013BA10
		public virtual int GetNumberOfLevelsMinValue()
		{
			return vtkImageToAMR.vtkImageToAMR_GetNumberOfLevelsMinValue_08(base.GetCppThis());
		}

		// Token: 0x0600E40D RID: 58381
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToAMR_GetRefinementRatio_09(HandleRef pThis);

		/// <summary>
		/// Set the refinement ratio for levels. This refinement ratio is used for all
		/// levels.
		/// </summary>
		// Token: 0x0600E40E RID: 58382 RVA: 0x0013D830 File Offset: 0x0013BA30
		public virtual int GetRefinementRatio()
		{
			return vtkImageToAMR.vtkImageToAMR_GetRefinementRatio_09(base.GetCppThis());
		}

		// Token: 0x0600E40F RID: 58383
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToAMR_GetRefinementRatioMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set the refinement ratio for levels. This refinement ratio is used for all
		/// levels.
		/// </summary>
		// Token: 0x0600E410 RID: 58384 RVA: 0x0013D850 File Offset: 0x0013BA50
		public virtual int GetRefinementRatioMaxValue()
		{
			return vtkImageToAMR.vtkImageToAMR_GetRefinementRatioMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0600E411 RID: 58385
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToAMR_GetRefinementRatioMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set the refinement ratio for levels. This refinement ratio is used for all
		/// levels.
		/// </summary>
		// Token: 0x0600E412 RID: 58386 RVA: 0x0013D870 File Offset: 0x0013BA70
		public virtual int GetRefinementRatioMinValue()
		{
			return vtkImageToAMR.vtkImageToAMR_GetRefinementRatioMinValue_11(base.GetCppThis());
		}

		// Token: 0x0600E413 RID: 58387
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToAMR_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E414 RID: 58388 RVA: 0x0013D890 File Offset: 0x0013BA90
		public override int IsA(string type)
		{
			return vtkImageToAMR.vtkImageToAMR_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0600E415 RID: 58389
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToAMR_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E416 RID: 58390 RVA: 0x0013D8B0 File Offset: 0x0013BAB0
		public new static int IsTypeOf(string type)
		{
			return vtkImageToAMR.vtkImageToAMR_IsTypeOf_13(type);
		}

		// Token: 0x0600E417 RID: 58391
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToAMR_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E418 RID: 58392 RVA: 0x0013D8CC File Offset: 0x0013BACC
		public new vtkImageToAMR NewInstance()
		{
			vtkImageToAMR result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToAMR.vtkImageToAMR_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageToAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E419 RID: 58393
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToAMR_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E41A RID: 58394 RVA: 0x0013D928 File Offset: 0x0013BB28
		public new static vtkImageToAMR SafeDownCast(vtkObjectBase o)
		{
			vtkImageToAMR vtkImageToAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToAMR.vtkImageToAMR_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageToAMR = (vtkImageToAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageToAMR.Register(null);
				}
			}
			return vtkImageToAMR;
		}

		// Token: 0x0600E41B RID: 58395
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToAMR_SetMaximumNumberOfBlocks_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the maximum number of blocks in the output
		/// </summary>
		// Token: 0x0600E41C RID: 58396 RVA: 0x0013D9A7 File Offset: 0x0013BBA7
		public virtual void SetMaximumNumberOfBlocks(int _arg)
		{
			vtkImageToAMR.vtkImageToAMR_SetMaximumNumberOfBlocks_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E41D RID: 58397
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToAMR_SetNumberOfLevels_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the maximum number of levels in the generated Overlapping-AMR.
		/// </summary>
		// Token: 0x0600E41E RID: 58398 RVA: 0x0013D9B7 File Offset: 0x0013BBB7
		public virtual void SetNumberOfLevels(int _arg)
		{
			vtkImageToAMR.vtkImageToAMR_SetNumberOfLevels_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E41F RID: 58399
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToAMR_SetRefinementRatio_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the refinement ratio for levels. This refinement ratio is used for all
		/// levels.
		/// </summary>
		// Token: 0x0600E420 RID: 58400 RVA: 0x0013D9C7 File Offset: 0x0013BBC7
		public virtual void SetRefinementRatio(int _arg)
		{
			vtkImageToAMR.vtkImageToAMR_SetRefinementRatio_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010C1 RID: 4289
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageToAMR";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010C2 RID: 4290
		public new static readonly string MRClassNameKey = "class vtkImageToAMR";
	}
}
