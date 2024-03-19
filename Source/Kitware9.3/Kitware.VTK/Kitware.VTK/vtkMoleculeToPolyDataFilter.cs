using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMoleculeToPolyDataFilter
	/// </summary>
	/// <remarks>
	///    abstract filter class
	///
	/// vtkMoleculeToPolyDataFilter is an abstract filter class whose
	/// subclasses take as input datasets of type vtkMolecule and
	/// generate polygonal data on output.
	/// </remarks>
	// Token: 0x02000620 RID: 1568
	public class vtkMoleculeToPolyDataFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011052 RID: 69714 RVA: 0x0017B464 File Offset: 0x00179664
		static vtkMoleculeToPolyDataFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMoleculeToPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMoleculeToPolyDataFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011053 RID: 69715 RVA: 0x0017B48C File Offset: 0x0017968C
		public vtkMoleculeToPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011054 RID: 69716 RVA: 0x0017B49A File Offset: 0x0017969A
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011055 RID: 69717
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeToPolyDataFilter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011056 RID: 69718 RVA: 0x0017B4A8 File Offset: 0x001796A8
		public new vtkMolecule GetInput()
		{
			vtkMolecule vtkMolecule = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeToPolyDataFilter.vtkMoleculeToPolyDataFilter_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMolecule = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMolecule.Register(null);
				}
			}
			return vtkMolecule;
		}

		// Token: 0x06011057 RID: 69719
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMoleculeToPolyDataFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011058 RID: 69720 RVA: 0x0017B518 File Offset: 0x00179718
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMoleculeToPolyDataFilter.vtkMoleculeToPolyDataFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06011059 RID: 69721
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMoleculeToPolyDataFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601105A RID: 69722 RVA: 0x0017B538 File Offset: 0x00179738
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMoleculeToPolyDataFilter.vtkMoleculeToPolyDataFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601105B RID: 69723
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeToPolyDataFilter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601105C RID: 69724 RVA: 0x0017B554 File Offset: 0x00179754
		public override int IsA(string type)
		{
			return vtkMoleculeToPolyDataFilter.vtkMoleculeToPolyDataFilter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601105D RID: 69725
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeToPolyDataFilter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601105E RID: 69726 RVA: 0x0017B574 File Offset: 0x00179774
		public new static int IsTypeOf(string type)
		{
			return vtkMoleculeToPolyDataFilter.vtkMoleculeToPolyDataFilter_IsTypeOf_05(type);
		}

		// Token: 0x0601105F RID: 69727
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeToPolyDataFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011060 RID: 69728 RVA: 0x0017B590 File Offset: 0x00179790
		public new vtkMoleculeToPolyDataFilter NewInstance()
		{
			vtkMoleculeToPolyDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeToPolyDataFilter.vtkMoleculeToPolyDataFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMoleculeToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011061 RID: 69729
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeToPolyDataFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011062 RID: 69730 RVA: 0x0017B5EC File Offset: 0x001797EC
		public new static vtkMoleculeToPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMoleculeToPolyDataFilter vtkMoleculeToPolyDataFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeToPolyDataFilter.vtkMoleculeToPolyDataFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMoleculeToPolyDataFilter = (vtkMoleculeToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMoleculeToPolyDataFilter.Register(null);
				}
			}
			return vtkMoleculeToPolyDataFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013A4 RID: 5028
		public new const string MRFullTypeName = "Kitware.VTK.vtkMoleculeToPolyDataFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013A5 RID: 5029
		public new static readonly string MRClassNameKey = "class vtkMoleculeToPolyDataFilter";
	}
}
