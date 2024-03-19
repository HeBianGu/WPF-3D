using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageWeightedSum
	/// </summary>
	/// <remarks>
	///     adds any number of images, weighting
	/// each according to the weight set using this-&gt;SetWeights(i,w).
	///
	///
	/// All weights are normalized so they will sum to 1.
	/// Images must have the same extents. Output is
	///
	/// @par Thanks:
	/// The original author of this class is Lauren O'Donnell (MIT) for Slicer
	/// </remarks>
	// Token: 0x02000259 RID: 601
	public class vtkImageWeightedSum : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006F1C RID: 28444 RVA: 0x000A015E File Offset: 0x0009E35E
		static vtkImageWeightedSum()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageWeightedSum.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageWeightedSum"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006F1D RID: 28445 RVA: 0x000A0186 File Offset: 0x0009E386
		public vtkImageWeightedSum(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006F1E RID: 28446
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageWeightedSum_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F1F RID: 28447 RVA: 0x000A0194 File Offset: 0x0009E394
		public new static vtkImageWeightedSum New()
		{
			vtkImageWeightedSum result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageWeightedSum.vtkImageWeightedSum_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageWeightedSum)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F20 RID: 28448 RVA: 0x000A01E8 File Offset: 0x0009E3E8
		public vtkImageWeightedSum() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageWeightedSum.vtkImageWeightedSum_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006F21 RID: 28449 RVA: 0x000A022C File Offset: 0x0009E42C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006F22 RID: 28450
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageWeightedSum_CalculateTotalWeight_01(HandleRef pThis);

		/// <summary>
		/// Compute the total value of all the weight
		/// </summary>
		// Token: 0x06006F23 RID: 28451 RVA: 0x000A0238 File Offset: 0x0009E438
		public double CalculateTotalWeight()
		{
			return vtkImageWeightedSum.vtkImageWeightedSum_CalculateTotalWeight_01(base.GetCppThis());
		}

		// Token: 0x06006F24 RID: 28452
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageWeightedSum_GetNormalizeByWeight_02(HandleRef pThis);

		/// <summary>
		/// Setting NormalizeByWeight on will divide the
		/// final result by the total weight of the component functions.
		/// This process does not otherwise normalize the weighted sum
		/// By default, NormalizeByWeight is on.
		/// </summary>
		// Token: 0x06006F25 RID: 28453 RVA: 0x000A0258 File Offset: 0x0009E458
		public virtual int GetNormalizeByWeight()
		{
			return vtkImageWeightedSum.vtkImageWeightedSum_GetNormalizeByWeight_02(base.GetCppThis());
		}

		// Token: 0x06006F26 RID: 28454
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageWeightedSum_GetNormalizeByWeightMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Setting NormalizeByWeight on will divide the
		/// final result by the total weight of the component functions.
		/// This process does not otherwise normalize the weighted sum
		/// By default, NormalizeByWeight is on.
		/// </summary>
		// Token: 0x06006F27 RID: 28455 RVA: 0x000A0278 File Offset: 0x0009E478
		public virtual int GetNormalizeByWeightMaxValue()
		{
			return vtkImageWeightedSum.vtkImageWeightedSum_GetNormalizeByWeightMaxValue_03(base.GetCppThis());
		}

		// Token: 0x06006F28 RID: 28456
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageWeightedSum_GetNormalizeByWeightMinValue_04(HandleRef pThis);

		/// <summary>
		/// Setting NormalizeByWeight on will divide the
		/// final result by the total weight of the component functions.
		/// This process does not otherwise normalize the weighted sum
		/// By default, NormalizeByWeight is on.
		/// </summary>
		// Token: 0x06006F29 RID: 28457 RVA: 0x000A0298 File Offset: 0x0009E498
		public virtual int GetNormalizeByWeightMinValue()
		{
			return vtkImageWeightedSum.vtkImageWeightedSum_GetNormalizeByWeightMinValue_04(base.GetCppThis());
		}

		// Token: 0x06006F2A RID: 28458
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageWeightedSum_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F2B RID: 28459 RVA: 0x000A02B8 File Offset: 0x0009E4B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageWeightedSum.vtkImageWeightedSum_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06006F2C RID: 28460
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageWeightedSum_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F2D RID: 28461 RVA: 0x000A02D8 File Offset: 0x0009E4D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageWeightedSum.vtkImageWeightedSum_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06006F2E RID: 28462
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageWeightedSum_GetWeights_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The weights control the contribution of each input to the sum.
		/// They will be normalized to sum to 1 before filter execution.
		/// </summary>
		// Token: 0x06006F2F RID: 28463 RVA: 0x000A02F4 File Offset: 0x0009E4F4
		public virtual vtkDoubleArray GetWeights()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageWeightedSum.vtkImageWeightedSum_GetWeights_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x06006F30 RID: 28464
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageWeightedSum_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F31 RID: 28465 RVA: 0x000A0364 File Offset: 0x0009E564
		public override int IsA(string type)
		{
			return vtkImageWeightedSum.vtkImageWeightedSum_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06006F32 RID: 28466
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageWeightedSum_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F33 RID: 28467 RVA: 0x000A0384 File Offset: 0x0009E584
		public new static int IsTypeOf(string type)
		{
			return vtkImageWeightedSum.vtkImageWeightedSum_IsTypeOf_09(type);
		}

		// Token: 0x06006F34 RID: 28468
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageWeightedSum_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F35 RID: 28469 RVA: 0x000A03A0 File Offset: 0x0009E5A0
		public new vtkImageWeightedSum NewInstance()
		{
			vtkImageWeightedSum result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageWeightedSum.vtkImageWeightedSum_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageWeightedSum)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006F36 RID: 28470
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageWeightedSum_NormalizeByWeightOff_12(HandleRef pThis);

		/// <summary>
		/// Setting NormalizeByWeight on will divide the
		/// final result by the total weight of the component functions.
		/// This process does not otherwise normalize the weighted sum
		/// By default, NormalizeByWeight is on.
		/// </summary>
		// Token: 0x06006F37 RID: 28471 RVA: 0x000A03FA File Offset: 0x0009E5FA
		public virtual void NormalizeByWeightOff()
		{
			vtkImageWeightedSum.vtkImageWeightedSum_NormalizeByWeightOff_12(base.GetCppThis());
		}

		// Token: 0x06006F38 RID: 28472
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageWeightedSum_NormalizeByWeightOn_13(HandleRef pThis);

		/// <summary>
		/// Setting NormalizeByWeight on will divide the
		/// final result by the total weight of the component functions.
		/// This process does not otherwise normalize the weighted sum
		/// By default, NormalizeByWeight is on.
		/// </summary>
		// Token: 0x06006F39 RID: 28473 RVA: 0x000A0409 File Offset: 0x0009E609
		public virtual void NormalizeByWeightOn()
		{
			vtkImageWeightedSum.vtkImageWeightedSum_NormalizeByWeightOn_13(base.GetCppThis());
		}

		// Token: 0x06006F3A RID: 28474
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageWeightedSum_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006F3B RID: 28475 RVA: 0x000A0418 File Offset: 0x0009E618
		public new static vtkImageWeightedSum SafeDownCast(vtkObjectBase o)
		{
			vtkImageWeightedSum vtkImageWeightedSum = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageWeightedSum.vtkImageWeightedSum_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageWeightedSum = (vtkImageWeightedSum)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageWeightedSum.Register(null);
				}
			}
			return vtkImageWeightedSum;
		}

		// Token: 0x06006F3C RID: 28476
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageWeightedSum_SetNormalizeByWeight_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Setting NormalizeByWeight on will divide the
		/// final result by the total weight of the component functions.
		/// This process does not otherwise normalize the weighted sum
		/// By default, NormalizeByWeight is on.
		/// </summary>
		// Token: 0x06006F3D RID: 28477 RVA: 0x000A0497 File Offset: 0x0009E697
		public virtual void SetNormalizeByWeight(int _arg)
		{
			vtkImageWeightedSum.vtkImageWeightedSum_SetNormalizeByWeight_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06006F3E RID: 28478
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageWeightedSum_SetWeight_16(HandleRef pThis, long id, double weight);

		/// <summary>
		/// Change a specific weight. Reallocation is done
		/// </summary>
		// Token: 0x06006F3F RID: 28479 RVA: 0x000A04A7 File Offset: 0x0009E6A7
		public virtual void SetWeight(long id, double weight)
		{
			vtkImageWeightedSum.vtkImageWeightedSum_SetWeight_16(base.GetCppThis(), id, weight);
		}

		// Token: 0x06006F40 RID: 28480
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageWeightedSum_SetWeights_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// The weights control the contribution of each input to the sum.
		/// They will be normalized to sum to 1 before filter execution.
		/// </summary>
		// Token: 0x06006F41 RID: 28481 RVA: 0x000A04B8 File Offset: 0x0009E6B8
		public virtual void SetWeights(vtkDoubleArray arg0)
		{
			vtkImageWeightedSum.vtkImageWeightedSum_SetWeights_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009A7 RID: 2471
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageWeightedSum";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009A8 RID: 2472
		public new static readonly string MRClassNameKey = "class vtkImageWeightedSum";
	}
}
