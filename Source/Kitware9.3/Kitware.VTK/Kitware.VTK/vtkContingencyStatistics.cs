using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContingencyStatistics
	/// </summary>
	/// <remarks>
	///    A class for bivariate correlation contigency
	/// tables, conditional probabilities, and information entropy
	///
	///
	/// Given a pair of columns of interest, this class provides the
	/// following functionalities, depending on the operation in which it is executed:
	/// * Learn: calculate contigency tables and corresponding discrete joint
	///   probability distribution.
	/// * Derive: calculate conditional probabilities, information entropies, and
	///   pointwise mutual information.
	/// * Assess: given two columns of interest with the same number of entries as
	///   input in port INPUT_DATA, and a corresponding bivariate probability distribution,
	/// * Test: calculate Chi-square independence statistic and, if VTK to R interface is available,
	///   retrieve corresponding p-value for independence testing.
	///
	/// @par Thanks:
	/// Thanks to Philippe Pebay and David Thompson from Sandia National Laboratories
	/// for implementing this class.
	/// Updated by Philippe Pebay, Kitware SAS 2012
	/// </remarks>
	// Token: 0x02000740 RID: 1856
	public class vtkContingencyStatistics : vtkStatisticsAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060134D1 RID: 79057 RVA: 0x001B4C2F File Offset: 0x001B2E2F
		static vtkContingencyStatistics()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContingencyStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContingencyStatistics"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060134D2 RID: 79058 RVA: 0x001B4C57 File Offset: 0x001B2E57
		public vtkContingencyStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060134D3 RID: 79059
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContingencyStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134D4 RID: 79060 RVA: 0x001B4C68 File Offset: 0x001B2E68
		public new static vtkContingencyStatistics New()
		{
			vtkContingencyStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContingencyStatistics.vtkContingencyStatistics_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContingencyStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134D5 RID: 79061 RVA: 0x001B4CBC File Offset: 0x001B2EBC
		public vtkContingencyStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkContingencyStatistics.vtkContingencyStatistics_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060134D6 RID: 79062 RVA: 0x001B4D00 File Offset: 0x001B2F00
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060134D7 RID: 79063
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContingencyStatistics_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Given a collection of models, calculate aggregate model
		/// NB: not implemented
		/// </summary>
		// Token: 0x060134D8 RID: 79064 RVA: 0x001B4D0C File Offset: 0x001B2F0C
		public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkContingencyStatistics.vtkContingencyStatistics_Aggregate_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060134D9 RID: 79065
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContingencyStatistics_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134DA RID: 79066 RVA: 0x001B4D50 File Offset: 0x001B2F50
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContingencyStatistics.vtkContingencyStatistics_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060134DB RID: 79067
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContingencyStatistics_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134DC RID: 79068 RVA: 0x001B4D70 File Offset: 0x001B2F70
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContingencyStatistics.vtkContingencyStatistics_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060134DD RID: 79069
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContingencyStatistics_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134DE RID: 79070 RVA: 0x001B4D8C File Offset: 0x001B2F8C
		public override int IsA(string type)
		{
			return vtkContingencyStatistics.vtkContingencyStatistics_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060134DF RID: 79071
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContingencyStatistics_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134E0 RID: 79072 RVA: 0x001B4DAC File Offset: 0x001B2FAC
		public new static int IsTypeOf(string type)
		{
			return vtkContingencyStatistics.vtkContingencyStatistics_IsTypeOf_05(type);
		}

		// Token: 0x060134E1 RID: 79073
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContingencyStatistics_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134E2 RID: 79074 RVA: 0x001B4DC8 File Offset: 0x001B2FC8
		public new vtkContingencyStatistics NewInstance()
		{
			vtkContingencyStatistics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContingencyStatistics.vtkContingencyStatistics_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContingencyStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060134E3 RID: 79075
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContingencyStatistics_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060134E4 RID: 79076 RVA: 0x001B4E24 File Offset: 0x001B3024
		public new static vtkContingencyStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkContingencyStatistics vtkContingencyStatistics = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContingencyStatistics.vtkContingencyStatistics_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContingencyStatistics = (vtkContingencyStatistics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContingencyStatistics.Register(null);
				}
			}
			return vtkContingencyStatistics;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001650 RID: 5712
		public new const string MRFullTypeName = "Kitware.VTK.vtkContingencyStatistics";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001651 RID: 5713
		public new static readonly string MRClassNameKey = "class vtkContingencyStatistics";
	}
}
