using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProbabilisticVoronoiKernel
	/// </summary>
	/// <remarks>
	///    interpolate from the weighted closest point
	///
	///
	/// vtkProbabilisticVoronoiKernel is an interpolation kernel that interpolates
	/// from the closest weighted point from a neighborhood of points. The weights
	/// refer to the probabilistic weighting that can be provided to the
	/// ComputeWeights() method.
	///
	/// Note that the local neighborhood is taken from the kernel footprint
	/// specified in the superclass vtkGeneralizedKernel.
	///
	/// @warning
	/// If probability weightings are not defined, then the kernel provides the
	/// same results as vtkVoronoiKernel, except a less efficiently.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInterpolationKernel vtkGeneralizedKernel vtkVoronoiKernel
	/// </seealso>
	// Token: 0x02000458 RID: 1112
	public class vtkProbabilisticVoronoiKernel : vtkGeneralizedKernel
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CEEF RID: 52975 RVA: 0x0011FBFB File Offset: 0x0011DDFB
		static vtkProbabilisticVoronoiKernel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProbabilisticVoronoiKernel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProbabilisticVoronoiKernel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CEF0 RID: 52976 RVA: 0x0011FC23 File Offset: 0x0011DE23
		public vtkProbabilisticVoronoiKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CEF1 RID: 52977
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbabilisticVoronoiKernel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CEF2 RID: 52978 RVA: 0x0011FC34 File Offset: 0x0011DE34
		public new static vtkProbabilisticVoronoiKernel New()
		{
			vtkProbabilisticVoronoiKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProbabilisticVoronoiKernel.vtkProbabilisticVoronoiKernel_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProbabilisticVoronoiKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CEF3 RID: 52979 RVA: 0x0011FC88 File Offset: 0x0011DE88
		public vtkProbabilisticVoronoiKernel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProbabilisticVoronoiKernel.vtkProbabilisticVoronoiKernel_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CEF4 RID: 52980 RVA: 0x0011FCCC File Offset: 0x0011DECC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CEF5 RID: 52981
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProbabilisticVoronoiKernel_ComputeWeights_01(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef prob, HandleRef weights);

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
		// Token: 0x0600CEF6 RID: 52982 RVA: 0x0011FCD8 File Offset: 0x0011DED8
		public override long ComputeWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray prob, vtkDoubleArray weights)
		{
			return vtkProbabilisticVoronoiKernel.vtkProbabilisticVoronoiKernel_ComputeWeights_01(base.GetCppThis(), x, (pIds == null) ? default(HandleRef) : pIds.GetCppThis(), (prob == null) ? default(HandleRef) : prob.GetCppThis(), (weights == null) ? default(HandleRef) : weights.GetCppThis());
		}

		// Token: 0x0600CEF7 RID: 52983
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProbabilisticVoronoiKernel_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CEF8 RID: 52984 RVA: 0x0011FD3C File Offset: 0x0011DF3C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProbabilisticVoronoiKernel.vtkProbabilisticVoronoiKernel_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600CEF9 RID: 52985
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProbabilisticVoronoiKernel_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CEFA RID: 52986 RVA: 0x0011FD5C File Offset: 0x0011DF5C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProbabilisticVoronoiKernel.vtkProbabilisticVoronoiKernel_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600CEFB RID: 52987
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProbabilisticVoronoiKernel_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CEFC RID: 52988 RVA: 0x0011FD78 File Offset: 0x0011DF78
		public override int IsA(string type)
		{
			return vtkProbabilisticVoronoiKernel.vtkProbabilisticVoronoiKernel_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600CEFD RID: 52989
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProbabilisticVoronoiKernel_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CEFE RID: 52990 RVA: 0x0011FD98 File Offset: 0x0011DF98
		public new static int IsTypeOf(string type)
		{
			return vtkProbabilisticVoronoiKernel.vtkProbabilisticVoronoiKernel_IsTypeOf_05(type);
		}

		// Token: 0x0600CEFF RID: 52991
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbabilisticVoronoiKernel_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CF00 RID: 52992 RVA: 0x0011FDB4 File Offset: 0x0011DFB4
		public new vtkProbabilisticVoronoiKernel NewInstance()
		{
			vtkProbabilisticVoronoiKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProbabilisticVoronoiKernel.vtkProbabilisticVoronoiKernel_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProbabilisticVoronoiKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CF01 RID: 52993
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbabilisticVoronoiKernel_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CF02 RID: 52994 RVA: 0x0011FE10 File Offset: 0x0011E010
		public new static vtkProbabilisticVoronoiKernel SafeDownCast(vtkObjectBase o)
		{
			vtkProbabilisticVoronoiKernel vtkProbabilisticVoronoiKernel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProbabilisticVoronoiKernel.vtkProbabilisticVoronoiKernel_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProbabilisticVoronoiKernel = (vtkProbabilisticVoronoiKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProbabilisticVoronoiKernel.Register(null);
				}
			}
			return vtkProbabilisticVoronoiKernel;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F49 RID: 3913
		public new const string MRFullTypeName = "Kitware.VTK.vtkProbabilisticVoronoiKernel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F4A RID: 3914
		public new static readonly string MRClassNameKey = "class vtkProbabilisticVoronoiKernel";
	}
}
