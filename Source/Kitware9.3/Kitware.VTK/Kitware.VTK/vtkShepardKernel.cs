using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkShepardKernel
	/// </summary>
	/// <remarks>
	///    a Shepard method interpolation kernel
	///
	///
	/// vtkShepardKernel is an interpolation kernel that uses the method of
	/// Shepard to perform interpolation. The weights are computed as 1/r^p, where
	/// r is the distance to a neighbor point within the kernel radius R; and p
	/// (the power parameter) is a positive exponent (typically p=2).
	///
	/// @warning
	/// The weights are normalized sp that SUM(Wi) = 1. If a neighbor point p
	/// precisely lies on the point to be interpolated, then the interpolated
	/// point takes on the values associated with p.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointInterpolator vtkPointInterpolator2D vtkInterpolationKernel
	/// vtkGaussianKernel vtkSPHKernel vtkShepardKernel
	/// </seealso>
	// Token: 0x02000462 RID: 1122
	public class vtkShepardKernel : vtkGeneralizedKernel
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D06C RID: 53356 RVA: 0x00121D97 File Offset: 0x0011FF97
		static vtkShepardKernel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShepardKernel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShepardKernel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D06D RID: 53357 RVA: 0x00121DBF File Offset: 0x0011FFBF
		public vtkShepardKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D06E RID: 53358
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShepardKernel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D06F RID: 53359 RVA: 0x00121DD0 File Offset: 0x0011FFD0
		public new static vtkShepardKernel New()
		{
			vtkShepardKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShepardKernel.vtkShepardKernel_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShepardKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D070 RID: 53360 RVA: 0x00121E24 File Offset: 0x00120024
		public vtkShepardKernel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkShepardKernel.vtkShepardKernel_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D071 RID: 53361 RVA: 0x00121E68 File Offset: 0x00120068
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D072 RID: 53362
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShepardKernel_ComputeWeights_01(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef prob, HandleRef weights);

		/// <summary>
		/// Given a point x, a list of basis points pIds, and a probability
		/// weighting function prob, compute interpolation weights associated with
		/// these basis points.  Note that basis points list pIds, the probability
		/// weighting prob, and the weights array are provided by the caller of the
		/// method, and may be dynamically resized as necessary. The method returns
		/// the number of weights (pIds may be resized in some cases). Typically
		/// this method is called after ComputeBasis(), although advanced users can
		/// invoke ComputeWeights() and provide the interpolation basis points pIds
		/// directly. The probably weighting prob are numbers 0&lt;=prob&lt;=1 which are
		/// multiplied against the interpolation weights before normalization. They
		/// are estimates of local confidence of weights. The prob may be nullptr in
		/// which all probabilities are considered =1.
		/// </summary>
		// Token: 0x0600D073 RID: 53363 RVA: 0x00121E74 File Offset: 0x00120074
		public override long ComputeWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray prob, vtkDoubleArray weights)
		{
			return vtkShepardKernel.vtkShepardKernel_ComputeWeights_01(base.GetCppThis(), x, (pIds == null) ? default(HandleRef) : pIds.GetCppThis(), (prob == null) ? default(HandleRef) : prob.GetCppThis(), (weights == null) ? default(HandleRef) : weights.GetCppThis());
		}

		// Token: 0x0600D074 RID: 53364
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShepardKernel_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D075 RID: 53365 RVA: 0x00121ED8 File Offset: 0x001200D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkShepardKernel.vtkShepardKernel_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600D076 RID: 53366
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShepardKernel_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D077 RID: 53367 RVA: 0x00121EF8 File Offset: 0x001200F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkShepardKernel.vtkShepardKernel_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600D078 RID: 53368
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkShepardKernel_GetPowerParameter_04(HandleRef pThis);

		/// <summary>
		/// Set / Get the power parameter p. By default p=2. Values (which must be
		/// a positive, real value) != 2 may affect performance significantly.
		/// </summary>
		// Token: 0x0600D079 RID: 53369 RVA: 0x00121F14 File Offset: 0x00120114
		public virtual double GetPowerParameter()
		{
			return vtkShepardKernel.vtkShepardKernel_GetPowerParameter_04(base.GetCppThis());
		}

		// Token: 0x0600D07A RID: 53370
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkShepardKernel_GetPowerParameterMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set / Get the power parameter p. By default p=2. Values (which must be
		/// a positive, real value) != 2 may affect performance significantly.
		/// </summary>
		// Token: 0x0600D07B RID: 53371 RVA: 0x00121F34 File Offset: 0x00120134
		public virtual double GetPowerParameterMaxValue()
		{
			return vtkShepardKernel.vtkShepardKernel_GetPowerParameterMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600D07C RID: 53372
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkShepardKernel_GetPowerParameterMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set / Get the power parameter p. By default p=2. Values (which must be
		/// a positive, real value) != 2 may affect performance significantly.
		/// </summary>
		// Token: 0x0600D07D RID: 53373 RVA: 0x00121F54 File Offset: 0x00120154
		public virtual double GetPowerParameterMinValue()
		{
			return vtkShepardKernel.vtkShepardKernel_GetPowerParameterMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600D07E RID: 53374
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShepardKernel_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D07F RID: 53375 RVA: 0x00121F74 File Offset: 0x00120174
		public override int IsA(string type)
		{
			return vtkShepardKernel.vtkShepardKernel_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600D080 RID: 53376
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShepardKernel_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D081 RID: 53377 RVA: 0x00121F94 File Offset: 0x00120194
		public new static int IsTypeOf(string type)
		{
			return vtkShepardKernel.vtkShepardKernel_IsTypeOf_08(type);
		}

		// Token: 0x0600D082 RID: 53378
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShepardKernel_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D083 RID: 53379 RVA: 0x00121FB0 File Offset: 0x001201B0
		public new vtkShepardKernel NewInstance()
		{
			vtkShepardKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShepardKernel.vtkShepardKernel_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShepardKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D084 RID: 53380
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShepardKernel_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D085 RID: 53381 RVA: 0x0012200C File Offset: 0x0012020C
		public new static vtkShepardKernel SafeDownCast(vtkObjectBase o)
		{
			vtkShepardKernel vtkShepardKernel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShepardKernel.vtkShepardKernel_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShepardKernel = (vtkShepardKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShepardKernel.Register(null);
				}
			}
			return vtkShepardKernel;
		}

		// Token: 0x0600D086 RID: 53382
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShepardKernel_SetPowerParameter_12(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / Get the power parameter p. By default p=2. Values (which must be
		/// a positive, real value) != 2 may affect performance significantly.
		/// </summary>
		// Token: 0x0600D087 RID: 53383 RVA: 0x0012208B File Offset: 0x0012028B
		public virtual void SetPowerParameter(double _arg)
		{
			vtkShepardKernel.vtkShepardKernel_SetPowerParameter_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F63 RID: 3939
		public new const string MRFullTypeName = "Kitware.VTK.vtkShepardKernel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F64 RID: 3940
		public new static readonly string MRClassNameKey = "class vtkShepardKernel";
	}
}
