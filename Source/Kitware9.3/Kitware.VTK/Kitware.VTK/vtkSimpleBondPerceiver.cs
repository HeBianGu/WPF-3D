using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSimpleBondPerceiver
	/// </summary>
	/// <remarks>
	///    Create a simple guess of a molecule's
	/// topology
	///
	///
	///
	/// vtkSimpleBondPerceiver performs a simple check of all interatomic distances
	/// and adds a single bond between atoms that are reasonably close. If the
	/// interatomic distance is less than the sum of the two atom's covalent radii
	/// plus a tolerance, a single bond is added.
	///
	///
	/// @warning
	/// This algorithm does not consider valences, hybridization, aromaticity, or
	/// anything other than atomic separations. It will not produce anything other
	/// than single bonds.
	/// </remarks>
	// Token: 0x0200062A RID: 1578
	public class vtkSimpleBondPerceiver : vtkMoleculeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601115A RID: 69978 RVA: 0x0017CFD3 File Offset: 0x0017B1D3
		static vtkSimpleBondPerceiver()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimpleBondPerceiver.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimpleBondPerceiver"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601115B RID: 69979 RVA: 0x0017CFFB File Offset: 0x0017B1FB
		public vtkSimpleBondPerceiver(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601115C RID: 69980
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleBondPerceiver_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601115D RID: 69981 RVA: 0x0017D00C File Offset: 0x0017B20C
		public new static vtkSimpleBondPerceiver New()
		{
			vtkSimpleBondPerceiver result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleBondPerceiver.vtkSimpleBondPerceiver_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleBondPerceiver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601115E RID: 69982 RVA: 0x0017D060 File Offset: 0x0017B260
		public vtkSimpleBondPerceiver() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSimpleBondPerceiver.vtkSimpleBondPerceiver_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601115F RID: 69983 RVA: 0x0017D0A4 File Offset: 0x0017B2A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011160 RID: 69984
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSimpleBondPerceiver_GetIsToleranceAbsolute_01(HandleRef pThis);

		/// <summary>
		/// Set/Get if the tolerance is absolute (i.e. added to radius)
		/// or not (i.e. multiplied with radius). Default is true.
		/// </summary>
		// Token: 0x06011161 RID: 69985 RVA: 0x0017D0B0 File Offset: 0x0017B2B0
		public virtual bool GetIsToleranceAbsolute()
		{
			return vtkSimpleBondPerceiver.vtkSimpleBondPerceiver_GetIsToleranceAbsolute_01(base.GetCppThis()) != 0;
		}

		// Token: 0x06011162 RID: 69986
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimpleBondPerceiver_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011163 RID: 69987 RVA: 0x0017D0D8 File Offset: 0x0017B2D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSimpleBondPerceiver.vtkSimpleBondPerceiver_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06011164 RID: 69988
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimpleBondPerceiver_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011165 RID: 69989 RVA: 0x0017D0F8 File Offset: 0x0017B2F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSimpleBondPerceiver.vtkSimpleBondPerceiver_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06011166 RID: 69990
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkSimpleBondPerceiver_GetTolerance_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the tolerance used in the comparisons. (Default: 0.45)
		/// </summary>
		// Token: 0x06011167 RID: 69991 RVA: 0x0017D114 File Offset: 0x0017B314
		public virtual float GetTolerance()
		{
			return vtkSimpleBondPerceiver.vtkSimpleBondPerceiver_GetTolerance_04(base.GetCppThis());
		}

		// Token: 0x06011168 RID: 69992
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleBondPerceiver_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011169 RID: 69993 RVA: 0x0017D134 File Offset: 0x0017B334
		public override int IsA(string type)
		{
			return vtkSimpleBondPerceiver.vtkSimpleBondPerceiver_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601116A RID: 69994
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleBondPerceiver_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601116B RID: 69995 RVA: 0x0017D154 File Offset: 0x0017B354
		public new static int IsTypeOf(string type)
		{
			return vtkSimpleBondPerceiver.vtkSimpleBondPerceiver_IsTypeOf_06(type);
		}

		// Token: 0x0601116C RID: 69996
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleBondPerceiver_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601116D RID: 69997 RVA: 0x0017D170 File Offset: 0x0017B370
		public new vtkSimpleBondPerceiver NewInstance()
		{
			vtkSimpleBondPerceiver result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleBondPerceiver.vtkSimpleBondPerceiver_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleBondPerceiver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601116E RID: 69998
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleBondPerceiver_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601116F RID: 69999 RVA: 0x0017D1CC File Offset: 0x0017B3CC
		public new static vtkSimpleBondPerceiver SafeDownCast(vtkObjectBase o)
		{
			vtkSimpleBondPerceiver vtkSimpleBondPerceiver = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleBondPerceiver.vtkSimpleBondPerceiver_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimpleBondPerceiver = (vtkSimpleBondPerceiver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimpleBondPerceiver.Register(null);
				}
			}
			return vtkSimpleBondPerceiver;
		}

		// Token: 0x06011170 RID: 70000
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleBondPerceiver_SetIsToleranceAbsolute_10(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if the tolerance is absolute (i.e. added to radius)
		/// or not (i.e. multiplied with radius). Default is true.
		/// </summary>
		// Token: 0x06011171 RID: 70001 RVA: 0x0017D24B File Offset: 0x0017B44B
		public virtual void SetIsToleranceAbsolute(bool _arg)
		{
			vtkSimpleBondPerceiver.vtkSimpleBondPerceiver_SetIsToleranceAbsolute_10(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011172 RID: 70002
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleBondPerceiver_SetTolerance_11(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the tolerance used in the comparisons. (Default: 0.45)
		/// </summary>
		// Token: 0x06011173 RID: 70003 RVA: 0x0017D263 File Offset: 0x0017B463
		public virtual void SetTolerance(float _arg)
		{
			vtkSimpleBondPerceiver.vtkSimpleBondPerceiver_SetTolerance_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013BA RID: 5050
		public new const string MRFullTypeName = "Kitware.VTK.vtkSimpleBondPerceiver";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013BB RID: 5051
		public new static readonly string MRClassNameKey = "class vtkSimpleBondPerceiver";
	}
}
