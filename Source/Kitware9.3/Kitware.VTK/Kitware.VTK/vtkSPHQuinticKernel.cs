using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSPHQuinticKernel
	/// </summary>
	/// <remarks>
	///    a quintic SPH interpolation kernel
	///
	///
	/// vtkSPHQuinticKernel is an smooth particle hydrodynamics interpolation kernel as
	/// described by D.J. Price. This is a quintic formulation.
	///
	/// @warning
	/// FOr more information see D.J. Price, Smoothed particle hydrodynamics and
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
	// Token: 0x02000461 RID: 1121
	public class vtkSPHQuinticKernel : vtkSPHKernel
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D054 RID: 53332 RVA: 0x00121ACB File Offset: 0x0011FCCB
		static vtkSPHQuinticKernel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSPHQuinticKernel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSPHQuinticKernel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D055 RID: 53333 RVA: 0x00121AF3 File Offset: 0x0011FCF3
		public vtkSPHQuinticKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D056 RID: 53334
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHQuinticKernel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D057 RID: 53335 RVA: 0x00121B04 File Offset: 0x0011FD04
		public new static vtkSPHQuinticKernel New()
		{
			vtkSPHQuinticKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHQuinticKernel.vtkSPHQuinticKernel_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSPHQuinticKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D058 RID: 53336 RVA: 0x00121B58 File Offset: 0x0011FD58
		public vtkSPHQuinticKernel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSPHQuinticKernel.vtkSPHQuinticKernel_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D059 RID: 53337 RVA: 0x00121B9C File Offset: 0x0011FD9C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D05A RID: 53338
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSPHQuinticKernel_ComputeDerivWeight_01(HandleRef pThis, double d);

		/// <summary>
		/// Compute weighting factor for derivative quantities given a normalized
		/// distance from a sample point.
		/// </summary>
		// Token: 0x0600D05B RID: 53339 RVA: 0x00121BA8 File Offset: 0x0011FDA8
		public override double ComputeDerivWeight(double d)
		{
			return vtkSPHQuinticKernel.vtkSPHQuinticKernel_ComputeDerivWeight_01(base.GetCppThis(), d);
		}

		// Token: 0x0600D05C RID: 53340
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSPHQuinticKernel_ComputeFunctionWeight_02(HandleRef pThis, double d);

		/// <summary>
		/// Compute weighting factor given a normalized distance from a sample point.
		/// </summary>
		// Token: 0x0600D05D RID: 53341 RVA: 0x00121BC8 File Offset: 0x0011FDC8
		public override double ComputeFunctionWeight(double d)
		{
			return vtkSPHQuinticKernel.vtkSPHQuinticKernel_ComputeFunctionWeight_02(base.GetCppThis(), d);
		}

		// Token: 0x0600D05E RID: 53342
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSPHQuinticKernel_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D05F RID: 53343 RVA: 0x00121BE8 File Offset: 0x0011FDE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSPHQuinticKernel.vtkSPHQuinticKernel_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600D060 RID: 53344
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSPHQuinticKernel_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D061 RID: 53345 RVA: 0x00121C08 File Offset: 0x0011FE08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSPHQuinticKernel.vtkSPHQuinticKernel_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600D062 RID: 53346
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHQuinticKernel_Initialize_05(HandleRef pThis, HandleRef loc, HandleRef ds, HandleRef pd);

		/// <summary>
		/// Produce the computational parameters for the kernel. Invoke this method
		/// after setting initial values like SpatialStep.
		/// </summary>
		// Token: 0x0600D063 RID: 53347 RVA: 0x00121C24 File Offset: 0x0011FE24
		public override void Initialize(vtkAbstractPointLocator loc, vtkDataSet ds, vtkPointData pd)
		{
			vtkSPHQuinticKernel.vtkSPHQuinticKernel_Initialize_05(base.GetCppThis(), (loc == null) ? default(HandleRef) : loc.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600D064 RID: 53348
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHQuinticKernel_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D065 RID: 53349 RVA: 0x00121C80 File Offset: 0x0011FE80
		public override int IsA(string type)
		{
			return vtkSPHQuinticKernel.vtkSPHQuinticKernel_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600D066 RID: 53350
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHQuinticKernel_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D067 RID: 53351 RVA: 0x00121CA0 File Offset: 0x0011FEA0
		public new static int IsTypeOf(string type)
		{
			return vtkSPHQuinticKernel.vtkSPHQuinticKernel_IsTypeOf_07(type);
		}

		// Token: 0x0600D068 RID: 53352
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHQuinticKernel_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D069 RID: 53353 RVA: 0x00121CBC File Offset: 0x0011FEBC
		public new vtkSPHQuinticKernel NewInstance()
		{
			vtkSPHQuinticKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHQuinticKernel.vtkSPHQuinticKernel_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSPHQuinticKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D06A RID: 53354
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHQuinticKernel_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D06B RID: 53355 RVA: 0x00121D18 File Offset: 0x0011FF18
		public new static vtkSPHQuinticKernel SafeDownCast(vtkObjectBase o)
		{
			vtkSPHQuinticKernel vtkSPHQuinticKernel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHQuinticKernel.vtkSPHQuinticKernel_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSPHQuinticKernel = (vtkSPHQuinticKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSPHQuinticKernel.Register(null);
				}
			}
			return vtkSPHQuinticKernel;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F61 RID: 3937
		public new const string MRFullTypeName = "Kitware.VTK.vtkSPHQuinticKernel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F62 RID: 3938
		public new static readonly string MRClassNameKey = "class vtkSPHQuinticKernel";
	}
}
