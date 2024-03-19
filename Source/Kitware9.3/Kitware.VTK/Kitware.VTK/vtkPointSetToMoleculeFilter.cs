using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// Get/Set if the filter should look for lines in input cells and convert them
	/// into bonds.
	/// default is ON.
	/// </summary>
	// Token: 0x02000626 RID: 1574
	public class vtkPointSetToMoleculeFilter : vtkMoleculeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060110CB RID: 69835 RVA: 0x0017C16F File Offset: 0x0017A36F
		static vtkPointSetToMoleculeFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointSetToMoleculeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSetToMoleculeFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060110CC RID: 69836 RVA: 0x0017C197 File Offset: 0x0017A397
		public vtkPointSetToMoleculeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060110CD RID: 69837
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetToMoleculeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060110CE RID: 69838 RVA: 0x0017C1A8 File Offset: 0x0017A3A8
		public new static vtkPointSetToMoleculeFilter New()
		{
			vtkPointSetToMoleculeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetToMoleculeFilter.vtkPointSetToMoleculeFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSetToMoleculeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060110CF RID: 69839 RVA: 0x0017C1FC File Offset: 0x0017A3FC
		public vtkPointSetToMoleculeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointSetToMoleculeFilter.vtkPointSetToMoleculeFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060110D0 RID: 69840 RVA: 0x0017C240 File Offset: 0x0017A440
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060110D1 RID: 69841
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToMoleculeFilter_ConvertLinesIntoBondsOff_01(HandleRef pThis);

		/// <summary>
		/// Get/Set if the filter should look for lines in input cells and convert them
		/// into bonds.
		/// default is ON.
		/// </summary>
		// Token: 0x060110D2 RID: 69842 RVA: 0x0017C24B File Offset: 0x0017A44B
		public virtual void ConvertLinesIntoBondsOff()
		{
			vtkPointSetToMoleculeFilter.vtkPointSetToMoleculeFilter_ConvertLinesIntoBondsOff_01(base.GetCppThis());
		}

		// Token: 0x060110D3 RID: 69843
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToMoleculeFilter_ConvertLinesIntoBondsOn_02(HandleRef pThis);

		/// <summary>
		/// Get/Set if the filter should look for lines in input cells and convert them
		/// into bonds.
		/// default is ON.
		/// </summary>
		// Token: 0x060110D4 RID: 69844 RVA: 0x0017C25A File Offset: 0x0017A45A
		public virtual void ConvertLinesIntoBondsOn()
		{
			vtkPointSetToMoleculeFilter.vtkPointSetToMoleculeFilter_ConvertLinesIntoBondsOn_02(base.GetCppThis());
		}

		// Token: 0x060110D5 RID: 69845
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointSetToMoleculeFilter_GetConvertLinesIntoBonds_03(HandleRef pThis);

		/// <summary>
		/// Get/Set if the filter should look for lines in input cells and convert them
		/// into bonds.
		/// default is ON.
		/// </summary>
		// Token: 0x060110D6 RID: 69846 RVA: 0x0017C26C File Offset: 0x0017A46C
		public virtual bool GetConvertLinesIntoBonds()
		{
			return vtkPointSetToMoleculeFilter.vtkPointSetToMoleculeFilter_GetConvertLinesIntoBonds_03(base.GetCppThis()) != 0;
		}

		// Token: 0x060110D7 RID: 69847
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSetToMoleculeFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060110D8 RID: 69848 RVA: 0x0017C294 File Offset: 0x0017A494
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointSetToMoleculeFilter.vtkPointSetToMoleculeFilter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060110D9 RID: 69849
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSetToMoleculeFilter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060110DA RID: 69850 RVA: 0x0017C2B4 File Offset: 0x0017A4B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointSetToMoleculeFilter.vtkPointSetToMoleculeFilter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060110DB RID: 69851
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetToMoleculeFilter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060110DC RID: 69852 RVA: 0x0017C2D0 File Offset: 0x0017A4D0
		public override int IsA(string type)
		{
			return vtkPointSetToMoleculeFilter.vtkPointSetToMoleculeFilter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060110DD RID: 69853
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetToMoleculeFilter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060110DE RID: 69854 RVA: 0x0017C2F0 File Offset: 0x0017A4F0
		public new static int IsTypeOf(string type)
		{
			return vtkPointSetToMoleculeFilter.vtkPointSetToMoleculeFilter_IsTypeOf_07(type);
		}

		// Token: 0x060110DF RID: 69855
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetToMoleculeFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060110E0 RID: 69856 RVA: 0x0017C30C File Offset: 0x0017A50C
		public new vtkPointSetToMoleculeFilter NewInstance()
		{
			vtkPointSetToMoleculeFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetToMoleculeFilter.vtkPointSetToMoleculeFilter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSetToMoleculeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060110E1 RID: 69857
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetToMoleculeFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060110E2 RID: 69858 RVA: 0x0017C368 File Offset: 0x0017A568
		public new static vtkPointSetToMoleculeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPointSetToMoleculeFilter vtkPointSetToMoleculeFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetToMoleculeFilter.vtkPointSetToMoleculeFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointSetToMoleculeFilter = (vtkPointSetToMoleculeFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointSetToMoleculeFilter.Register(null);
				}
			}
			return vtkPointSetToMoleculeFilter;
		}

		// Token: 0x060110E3 RID: 69859
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetToMoleculeFilter_SetConvertLinesIntoBonds_11(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set if the filter should look for lines in input cells and convert them
		/// into bonds.
		/// default is ON.
		/// </summary>
		// Token: 0x060110E4 RID: 69860 RVA: 0x0017C3E7 File Offset: 0x0017A5E7
		public virtual void SetConvertLinesIntoBonds(bool _arg)
		{
			vtkPointSetToMoleculeFilter.vtkPointSetToMoleculeFilter_SetConvertLinesIntoBonds_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013B2 RID: 5042
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointSetToMoleculeFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013B3 RID: 5043
		public new static readonly string MRClassNameKey = "class vtkPointSetToMoleculeFilter";
	}
}
