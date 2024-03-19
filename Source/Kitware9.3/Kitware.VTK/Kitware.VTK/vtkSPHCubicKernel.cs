using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSPHCubicKernel
	/// </summary>
	/// <remarks>
	///    a cubic SPH interpolation kernel
	///
	///
	/// vtkSPHCubicKernel is an smooth particle hydrodynamics interpolation kernel as
	/// described by D.J. Price. This is a cubic formulation.
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
	// Token: 0x0200045D RID: 1117
	public class vtkSPHCubicKernel : vtkSPHKernel
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CFA2 RID: 53154 RVA: 0x00120C9B File Offset: 0x0011EE9B
		static vtkSPHCubicKernel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSPHCubicKernel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSPHCubicKernel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CFA3 RID: 53155 RVA: 0x00120CC3 File Offset: 0x0011EEC3
		public vtkSPHCubicKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CFA4 RID: 53156
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHCubicKernel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CFA5 RID: 53157 RVA: 0x00120CD4 File Offset: 0x0011EED4
		public new static vtkSPHCubicKernel New()
		{
			vtkSPHCubicKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHCubicKernel.vtkSPHCubicKernel_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSPHCubicKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CFA6 RID: 53158 RVA: 0x00120D28 File Offset: 0x0011EF28
		public vtkSPHCubicKernel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSPHCubicKernel.vtkSPHCubicKernel_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CFA7 RID: 53159 RVA: 0x00120D6C File Offset: 0x0011EF6C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CFA8 RID: 53160
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSPHCubicKernel_ComputeDerivWeight_01(HandleRef pThis, double d);

		/// <summary>
		/// Compute weighting factor for derivative quantities given a normalized
		/// distance from a sample point.
		/// </summary>
		// Token: 0x0600CFA9 RID: 53161 RVA: 0x00120D78 File Offset: 0x0011EF78
		public override double ComputeDerivWeight(double d)
		{
			return vtkSPHCubicKernel.vtkSPHCubicKernel_ComputeDerivWeight_01(base.GetCppThis(), d);
		}

		// Token: 0x0600CFAA RID: 53162
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSPHCubicKernel_ComputeFunctionWeight_02(HandleRef pThis, double d);

		/// <summary>
		/// Compute weighting factor given a normalized distance from a sample point.
		/// </summary>
		// Token: 0x0600CFAB RID: 53163 RVA: 0x00120D98 File Offset: 0x0011EF98
		public override double ComputeFunctionWeight(double d)
		{
			return vtkSPHCubicKernel.vtkSPHCubicKernel_ComputeFunctionWeight_02(base.GetCppThis(), d);
		}

		// Token: 0x0600CFAC RID: 53164
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSPHCubicKernel_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CFAD RID: 53165 RVA: 0x00120DB8 File Offset: 0x0011EFB8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSPHCubicKernel.vtkSPHCubicKernel_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600CFAE RID: 53166
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSPHCubicKernel_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CFAF RID: 53167 RVA: 0x00120DD8 File Offset: 0x0011EFD8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSPHCubicKernel.vtkSPHCubicKernel_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600CFB0 RID: 53168
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHCubicKernel_Initialize_05(HandleRef pThis, HandleRef loc, HandleRef ds, HandleRef pd);

		/// <summary>
		/// Produce the computational parameters for the kernel. Invoke this method
		/// after setting initial values like SpatialStep.
		/// </summary>
		// Token: 0x0600CFB1 RID: 53169 RVA: 0x00120DF4 File Offset: 0x0011EFF4
		public override void Initialize(vtkAbstractPointLocator loc, vtkDataSet ds, vtkPointData pd)
		{
			vtkSPHCubicKernel.vtkSPHCubicKernel_Initialize_05(base.GetCppThis(), (loc == null) ? default(HandleRef) : loc.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600CFB2 RID: 53170
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHCubicKernel_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CFB3 RID: 53171 RVA: 0x00120E50 File Offset: 0x0011F050
		public override int IsA(string type)
		{
			return vtkSPHCubicKernel.vtkSPHCubicKernel_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600CFB4 RID: 53172
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHCubicKernel_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CFB5 RID: 53173 RVA: 0x00120E70 File Offset: 0x0011F070
		public new static int IsTypeOf(string type)
		{
			return vtkSPHCubicKernel.vtkSPHCubicKernel_IsTypeOf_07(type);
		}

		// Token: 0x0600CFB6 RID: 53174
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHCubicKernel_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CFB7 RID: 53175 RVA: 0x00120E8C File Offset: 0x0011F08C
		public new vtkSPHCubicKernel NewInstance()
		{
			vtkSPHCubicKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHCubicKernel.vtkSPHCubicKernel_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSPHCubicKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CFB8 RID: 53176
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHCubicKernel_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CFB9 RID: 53177 RVA: 0x00120EE8 File Offset: 0x0011F0E8
		public new static vtkSPHCubicKernel SafeDownCast(vtkObjectBase o)
		{
			vtkSPHCubicKernel vtkSPHCubicKernel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHCubicKernel.vtkSPHCubicKernel_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSPHCubicKernel = (vtkSPHCubicKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSPHCubicKernel.Register(null);
				}
			}
			return vtkSPHCubicKernel;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F58 RID: 3928
		public new const string MRFullTypeName = "Kitware.VTK.vtkSPHCubicKernel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F59 RID: 3929
		public new static readonly string MRClassNameKey = "class vtkSPHCubicKernel";
	}
}
