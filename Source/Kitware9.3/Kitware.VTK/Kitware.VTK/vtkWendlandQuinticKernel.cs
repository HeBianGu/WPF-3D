using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWendlandQuinticKernel
	/// </summary>
	/// <remarks>
	///    a quintic SPH interpolation kernel
	///
	///
	/// vtkWendlandQuinticKernel is an smooth particle hydrodynamics interpolation kernel as
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
	// Token: 0x02000469 RID: 1129
	public class vtkWendlandQuinticKernel : vtkSPHKernel
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D198 RID: 53656 RVA: 0x0012370D File Offset: 0x0012190D
		static vtkWendlandQuinticKernel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWendlandQuinticKernel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWendlandQuinticKernel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D199 RID: 53657 RVA: 0x00123735 File Offset: 0x00121935
		public vtkWendlandQuinticKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D19A RID: 53658
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWendlandQuinticKernel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D19B RID: 53659 RVA: 0x00123744 File Offset: 0x00121944
		public new static vtkWendlandQuinticKernel New()
		{
			vtkWendlandQuinticKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWendlandQuinticKernel.vtkWendlandQuinticKernel_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWendlandQuinticKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D19C RID: 53660 RVA: 0x00123798 File Offset: 0x00121998
		public vtkWendlandQuinticKernel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWendlandQuinticKernel.vtkWendlandQuinticKernel_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D19D RID: 53661 RVA: 0x001237DC File Offset: 0x001219DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D19E RID: 53662
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWendlandQuinticKernel_ComputeDerivWeight_01(HandleRef pThis, double d);

		/// <summary>
		/// Compute weighting factor for derivative quantities given a normalized
		/// distance from a sample point.
		/// </summary>
		// Token: 0x0600D19F RID: 53663 RVA: 0x001237E8 File Offset: 0x001219E8
		public override double ComputeDerivWeight(double d)
		{
			return vtkWendlandQuinticKernel.vtkWendlandQuinticKernel_ComputeDerivWeight_01(base.GetCppThis(), d);
		}

		// Token: 0x0600D1A0 RID: 53664
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWendlandQuinticKernel_ComputeFunctionWeight_02(HandleRef pThis, double d);

		/// <summary>
		/// Compute weighting factor given a normalized distance from a sample point.
		/// Note that the formulation is slightly different to avoid an extra operation
		/// (which has the effect of affecting the NormFactor by 1/16).
		/// </summary>
		// Token: 0x0600D1A1 RID: 53665 RVA: 0x00123808 File Offset: 0x00121A08
		public override double ComputeFunctionWeight(double d)
		{
			return vtkWendlandQuinticKernel.vtkWendlandQuinticKernel_ComputeFunctionWeight_02(base.GetCppThis(), d);
		}

		// Token: 0x0600D1A2 RID: 53666
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWendlandQuinticKernel_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D1A3 RID: 53667 RVA: 0x00123828 File Offset: 0x00121A28
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWendlandQuinticKernel.vtkWendlandQuinticKernel_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600D1A4 RID: 53668
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWendlandQuinticKernel_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D1A5 RID: 53669 RVA: 0x00123848 File Offset: 0x00121A48
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWendlandQuinticKernel.vtkWendlandQuinticKernel_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600D1A6 RID: 53670
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWendlandQuinticKernel_Initialize_05(HandleRef pThis, HandleRef loc, HandleRef ds, HandleRef pd);

		/// <summary>
		/// Produce the computational parameters for the kernel. Invoke this method
		/// after setting initial values like SpatialStep.
		/// </summary>
		// Token: 0x0600D1A7 RID: 53671 RVA: 0x00123864 File Offset: 0x00121A64
		public override void Initialize(vtkAbstractPointLocator loc, vtkDataSet ds, vtkPointData pd)
		{
			vtkWendlandQuinticKernel.vtkWendlandQuinticKernel_Initialize_05(base.GetCppThis(), (loc == null) ? default(HandleRef) : loc.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600D1A8 RID: 53672
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWendlandQuinticKernel_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D1A9 RID: 53673 RVA: 0x001238C0 File Offset: 0x00121AC0
		public override int IsA(string type)
		{
			return vtkWendlandQuinticKernel.vtkWendlandQuinticKernel_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600D1AA RID: 53674
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWendlandQuinticKernel_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D1AB RID: 53675 RVA: 0x001238E0 File Offset: 0x00121AE0
		public new static int IsTypeOf(string type)
		{
			return vtkWendlandQuinticKernel.vtkWendlandQuinticKernel_IsTypeOf_07(type);
		}

		// Token: 0x0600D1AC RID: 53676
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWendlandQuinticKernel_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D1AD RID: 53677 RVA: 0x001238FC File Offset: 0x00121AFC
		public new vtkWendlandQuinticKernel NewInstance()
		{
			vtkWendlandQuinticKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWendlandQuinticKernel.vtkWendlandQuinticKernel_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWendlandQuinticKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D1AE RID: 53678
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWendlandQuinticKernel_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600D1AF RID: 53679 RVA: 0x00123958 File Offset: 0x00121B58
		public new static vtkWendlandQuinticKernel SafeDownCast(vtkObjectBase o)
		{
			vtkWendlandQuinticKernel vtkWendlandQuinticKernel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWendlandQuinticKernel.vtkWendlandQuinticKernel_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWendlandQuinticKernel = (vtkWendlandQuinticKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWendlandQuinticKernel.Register(null);
				}
			}
			return vtkWendlandQuinticKernel;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F73 RID: 3955
		public new const string MRFullTypeName = "Kitware.VTK.vtkWendlandQuinticKernel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F74 RID: 3956
		public new static readonly string MRClassNameKey = "class vtkWendlandQuinticKernel";
	}
}
