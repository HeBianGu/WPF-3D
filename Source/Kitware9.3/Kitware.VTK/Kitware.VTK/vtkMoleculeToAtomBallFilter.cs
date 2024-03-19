using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMoleculeToAtomBallFilter
	/// </summary>
	/// <remarks>
	///    Generate polydata with spheres
	/// representing atoms
	///
	///
	/// This filter is used to generate one sphere for each atom in the
	/// input vtkMolecule. Each sphere is centered at the atom center and
	/// can be scaled using either covalent or van der Waals radii. The
	/// point scalars of the output vtkPolyData contains the atomic number
	/// of the appropriate atom for color mapping.
	///
	/// \note Consider using the faster, simpler vtkMoleculeMapper class,
	/// rather than generating polydata manually via these filters.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMoleculeMapper vtkMoleculeToBondStickFilter
	/// </seealso>
	// Token: 0x02000621 RID: 1569
	public class vtkMoleculeToAtomBallFilter : vtkMoleculeToPolyDataFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011063 RID: 69731 RVA: 0x0017B66B File Offset: 0x0017986B
		static vtkMoleculeToAtomBallFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMoleculeToAtomBallFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMoleculeToAtomBallFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011064 RID: 69732 RVA: 0x0017B693 File Offset: 0x00179893
		public vtkMoleculeToAtomBallFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011065 RID: 69733
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeToAtomBallFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011066 RID: 69734 RVA: 0x0017B6A4 File Offset: 0x001798A4
		public new static vtkMoleculeToAtomBallFilter New()
		{
			vtkMoleculeToAtomBallFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeToAtomBallFilter.vtkMoleculeToAtomBallFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMoleculeToAtomBallFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011067 RID: 69735 RVA: 0x0017B6F8 File Offset: 0x001798F8
		public vtkMoleculeToAtomBallFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMoleculeToAtomBallFilter.vtkMoleculeToAtomBallFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011068 RID: 69736 RVA: 0x0017B73C File Offset: 0x0017993C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011069 RID: 69737
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMoleculeToAtomBallFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601106A RID: 69738 RVA: 0x0017B748 File Offset: 0x00179948
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMoleculeToAtomBallFilter.vtkMoleculeToAtomBallFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601106B RID: 69739
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMoleculeToAtomBallFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601106C RID: 69740 RVA: 0x0017B768 File Offset: 0x00179968
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMoleculeToAtomBallFilter.vtkMoleculeToAtomBallFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601106D RID: 69741
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMoleculeToAtomBallFilter_GetRadiusScale_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601106E RID: 69742 RVA: 0x0017B784 File Offset: 0x00179984
		public virtual double GetRadiusScale()
		{
			return vtkMoleculeToAtomBallFilter.vtkMoleculeToAtomBallFilter_GetRadiusScale_03(base.GetCppThis());
		}

		// Token: 0x0601106F RID: 69743
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeToAtomBallFilter_GetRadiusSource_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011070 RID: 69744 RVA: 0x0017B7A4 File Offset: 0x001799A4
		public virtual int GetRadiusSource()
		{
			return vtkMoleculeToAtomBallFilter.vtkMoleculeToAtomBallFilter_GetRadiusSource_04(base.GetCppThis());
		}

		// Token: 0x06011071 RID: 69745
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeToAtomBallFilter_GetResolution_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011072 RID: 69746 RVA: 0x0017B7C4 File Offset: 0x001799C4
		public virtual int GetResolution()
		{
			return vtkMoleculeToAtomBallFilter.vtkMoleculeToAtomBallFilter_GetResolution_05(base.GetCppThis());
		}

		// Token: 0x06011073 RID: 69747
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeToAtomBallFilter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011074 RID: 69748 RVA: 0x0017B7E4 File Offset: 0x001799E4
		public override int IsA(string type)
		{
			return vtkMoleculeToAtomBallFilter.vtkMoleculeToAtomBallFilter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06011075 RID: 69749
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeToAtomBallFilter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011076 RID: 69750 RVA: 0x0017B804 File Offset: 0x00179A04
		public new static int IsTypeOf(string type)
		{
			return vtkMoleculeToAtomBallFilter.vtkMoleculeToAtomBallFilter_IsTypeOf_07(type);
		}

		// Token: 0x06011077 RID: 69751
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeToAtomBallFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011078 RID: 69752 RVA: 0x0017B820 File Offset: 0x00179A20
		public new vtkMoleculeToAtomBallFilter NewInstance()
		{
			vtkMoleculeToAtomBallFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeToAtomBallFilter.vtkMoleculeToAtomBallFilter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMoleculeToAtomBallFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011079 RID: 69753
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeToAtomBallFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601107A RID: 69754 RVA: 0x0017B87C File Offset: 0x00179A7C
		public new static vtkMoleculeToAtomBallFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMoleculeToAtomBallFilter vtkMoleculeToAtomBallFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeToAtomBallFilter.vtkMoleculeToAtomBallFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMoleculeToAtomBallFilter = (vtkMoleculeToAtomBallFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMoleculeToAtomBallFilter.Register(null);
				}
			}
			return vtkMoleculeToAtomBallFilter;
		}

		// Token: 0x0601107B RID: 69755
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeToAtomBallFilter_SetRadiusScale_11(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601107C RID: 69756 RVA: 0x0017B8FB File Offset: 0x00179AFB
		public virtual void SetRadiusScale(double _arg)
		{
			vtkMoleculeToAtomBallFilter.vtkMoleculeToAtomBallFilter_SetRadiusScale_11(base.GetCppThis(), _arg);
		}

		// Token: 0x0601107D RID: 69757
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeToAtomBallFilter_SetRadiusSource_12(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601107E RID: 69758 RVA: 0x0017B90B File Offset: 0x00179B0B
		public virtual void SetRadiusSource(int _arg)
		{
			vtkMoleculeToAtomBallFilter.vtkMoleculeToAtomBallFilter_SetRadiusSource_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0601107F RID: 69759
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMoleculeToAtomBallFilter_SetResolution_13(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011080 RID: 69760 RVA: 0x0017B91B File Offset: 0x00179B1B
		public virtual void SetResolution(int _arg)
		{
			vtkMoleculeToAtomBallFilter.vtkMoleculeToAtomBallFilter_SetResolution_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013A6 RID: 5030
		public new const string MRFullTypeName = "Kitware.VTK.vtkMoleculeToAtomBallFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013A7 RID: 5031
		public new static readonly string MRClassNameKey = "class vtkMoleculeToAtomBallFilter";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000622 RID: 1570
		public enum CovalentRadius_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040013A9 RID: 5033
			CovalentRadius,
			/// <summary>enum member</summary>
			// Token: 0x040013AA RID: 5034
			UnitRadius = 2,
			/// <summary>enum member</summary>
			// Token: 0x040013AB RID: 5035
			VDWRadius = 1
		}
	}
}
