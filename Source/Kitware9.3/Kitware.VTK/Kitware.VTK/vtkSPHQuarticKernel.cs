using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSPHQuarticKernel
	/// </summary>
	/// <remarks>
	///    a quartic SPH interpolation kernel
	///
	///
	/// vtkSPHQuarticKernel is an smooth particle hydrodynamics interpolation kernel as
	/// described by D.J. Price. This is a quartic formulation.
	///
	/// @warning
	/// For more information see D.J. Price, Smoothed particle hydrodynamics and
	/// magnetohydrodynamics, J. Comput. Phys. 231:759-794, 2012. Especially
	/// equation 49.
	///
	/// @par Acknowledgments:
	/// The following work has been generously supported by Altair Engineering
	/// and FluiDyna GmbH. Please contact Steve Cosgrove or Milos Stanic for
	/// more information.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSPHKernel vtkSPHInterpolator
	/// </seealso>
	// Token: 0x02000460 RID: 1120
	public class vtkSPHQuarticKernel : vtkSPHKernel
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D03C RID: 53308 RVA: 0x00121801 File Offset: 0x0011FA01
		static vtkSPHQuarticKernel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSPHQuarticKernel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSPHQuarticKernel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D03D RID: 53309 RVA: 0x00121829 File Offset: 0x0011FA29
		public vtkSPHQuarticKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D03E RID: 53310
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHQuarticKernel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D03F RID: 53311 RVA: 0x00121838 File Offset: 0x0011FA38
		public new static vtkSPHQuarticKernel New()
		{
			vtkSPHQuarticKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHQuarticKernel.vtkSPHQuarticKernel_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSPHQuarticKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D040 RID: 53312 RVA: 0x0012188C File Offset: 0x0011FA8C
		public vtkSPHQuarticKernel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSPHQuarticKernel.vtkSPHQuarticKernel_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D041 RID: 53313 RVA: 0x001218D0 File Offset: 0x0011FAD0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D042 RID: 53314
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSPHQuarticKernel_ComputeDerivWeight_01(HandleRef pThis, double d);

		/// <summary>
		/// Compute weighting factor for derivative quantities given a normalized
		/// distance from a sample point.
		/// </summary>
		// Token: 0x0600D043 RID: 53315 RVA: 0x001218DC File Offset: 0x0011FADC
		public override double ComputeDerivWeight(double d)
		{
			return vtkSPHQuarticKernel.vtkSPHQuarticKernel_ComputeDerivWeight_01(base.GetCppThis(), d);
		}

		// Token: 0x0600D044 RID: 53316
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSPHQuarticKernel_ComputeFunctionWeight_02(HandleRef pThis, double d);

		/// <summary>
		/// Compute weighting factor given a normalized distance from a sample point.
		/// </summary>
		// Token: 0x0600D045 RID: 53317 RVA: 0x001218FC File Offset: 0x0011FAFC
		public override double ComputeFunctionWeight(double d)
		{
			return vtkSPHQuarticKernel.vtkSPHQuarticKernel_ComputeFunctionWeight_02(base.GetCppThis(), d);
		}

		// Token: 0x0600D046 RID: 53318
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSPHQuarticKernel_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D047 RID: 53319 RVA: 0x0012191C File Offset: 0x0011FB1C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSPHQuarticKernel.vtkSPHQuarticKernel_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600D048 RID: 53320
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSPHQuarticKernel_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D049 RID: 53321 RVA: 0x0012193C File Offset: 0x0011FB3C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSPHQuarticKernel.vtkSPHQuarticKernel_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600D04A RID: 53322
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHQuarticKernel_Initialize_05(HandleRef pThis, HandleRef loc, HandleRef ds, HandleRef pd);

		/// <summary>
		/// Produce the computational parameters for the kernel. Invoke this method
		/// after setting initial values like SpatialStep.
		/// </summary>
		// Token: 0x0600D04B RID: 53323 RVA: 0x00121958 File Offset: 0x0011FB58
		public override void Initialize(vtkAbstractPointLocator loc, vtkDataSet ds, vtkPointData pd)
		{
			vtkSPHQuarticKernel.vtkSPHQuarticKernel_Initialize_05(base.GetCppThis(), (loc == null) ? default(HandleRef) : loc.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600D04C RID: 53324
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHQuarticKernel_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D04D RID: 53325 RVA: 0x001219B4 File Offset: 0x0011FBB4
		public override int IsA(string type)
		{
			return vtkSPHQuarticKernel.vtkSPHQuarticKernel_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600D04E RID: 53326
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHQuarticKernel_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D04F RID: 53327 RVA: 0x001219D4 File Offset: 0x0011FBD4
		public new static int IsTypeOf(string type)
		{
			return vtkSPHQuarticKernel.vtkSPHQuarticKernel_IsTypeOf_07(type);
		}

		// Token: 0x0600D050 RID: 53328
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHQuarticKernel_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D051 RID: 53329 RVA: 0x001219F0 File Offset: 0x0011FBF0
		public new vtkSPHQuarticKernel NewInstance()
		{
			vtkSPHQuarticKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHQuarticKernel.vtkSPHQuarticKernel_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSPHQuarticKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D052 RID: 53330
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHQuarticKernel_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D053 RID: 53331 RVA: 0x00121A4C File Offset: 0x0011FC4C
		public new static vtkSPHQuarticKernel SafeDownCast(vtkObjectBase o)
		{
			vtkSPHQuarticKernel vtkSPHQuarticKernel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHQuarticKernel.vtkSPHQuarticKernel_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSPHQuarticKernel = (vtkSPHQuarticKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSPHQuarticKernel.Register(null);
				}
			}
			return vtkSPHQuarticKernel;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F5F RID: 3935
		public new const string MRFullTypeName = "Kitware.VTK.vtkSPHQuarticKernel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F60 RID: 3936
		public new static readonly string MRClassNameKey = "class vtkSPHQuarticKernel";
	}
}
