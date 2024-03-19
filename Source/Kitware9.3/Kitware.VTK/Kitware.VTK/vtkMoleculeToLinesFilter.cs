using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMoleculeToLinesFilter
	/// </summary>
	/// <remarks>
	///  Convert a molecule into a simple polydata with lines.
	///
	/// vtkMoleculeToLinesFilter is a filter class that takes vtkMolecule as input and
	/// generates polydata on output.
	/// Conversion is done following this rules:
	///  - 1 atom == 1 point
	///  - 1 bond == 1 line (cell of type VTK_LINE)
	///  - atom data is copied as point data
	///  - bond data is copied as cell data
	/// </remarks>
	// Token: 0x02000624 RID: 1572
	public class vtkMoleculeToLinesFilter : vtkMoleculeToPolyDataFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011093 RID: 69779 RVA: 0x0017BB5B File Offset: 0x00179D5B
		static vtkMoleculeToLinesFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMoleculeToLinesFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMoleculeToLinesFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011094 RID: 69780 RVA: 0x0017BB83 File Offset: 0x00179D83
		public vtkMoleculeToLinesFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011095 RID: 69781
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeToLinesFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011096 RID: 69782 RVA: 0x0017BB94 File Offset: 0x00179D94
		public new static vtkMoleculeToLinesFilter New()
		{
			vtkMoleculeToLinesFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeToLinesFilter.vtkMoleculeToLinesFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMoleculeToLinesFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011097 RID: 69783 RVA: 0x0017BBE8 File Offset: 0x00179DE8
		public vtkMoleculeToLinesFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMoleculeToLinesFilter.vtkMoleculeToLinesFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011098 RID: 69784 RVA: 0x0017BC2C File Offset: 0x00179E2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011099 RID: 69785
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMoleculeToLinesFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601109A RID: 69786 RVA: 0x0017BC38 File Offset: 0x00179E38
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMoleculeToLinesFilter.vtkMoleculeToLinesFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601109B RID: 69787
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMoleculeToLinesFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601109C RID: 69788 RVA: 0x0017BC58 File Offset: 0x00179E58
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMoleculeToLinesFilter.vtkMoleculeToLinesFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601109D RID: 69789
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeToLinesFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601109E RID: 69790 RVA: 0x0017BC74 File Offset: 0x00179E74
		public override int IsA(string type)
		{
			return vtkMoleculeToLinesFilter.vtkMoleculeToLinesFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601109F RID: 69791
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeToLinesFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060110A0 RID: 69792 RVA: 0x0017BC94 File Offset: 0x00179E94
		public new static int IsTypeOf(string type)
		{
			return vtkMoleculeToLinesFilter.vtkMoleculeToLinesFilter_IsTypeOf_04(type);
		}

		// Token: 0x060110A1 RID: 69793
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeToLinesFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060110A2 RID: 69794 RVA: 0x0017BCB0 File Offset: 0x00179EB0
		public new vtkMoleculeToLinesFilter NewInstance()
		{
			vtkMoleculeToLinesFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeToLinesFilter.vtkMoleculeToLinesFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMoleculeToLinesFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060110A3 RID: 69795
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeToLinesFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060110A4 RID: 69796 RVA: 0x0017BD0C File Offset: 0x00179F0C
		public new static vtkMoleculeToLinesFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMoleculeToLinesFilter vtkMoleculeToLinesFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeToLinesFilter.vtkMoleculeToLinesFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMoleculeToLinesFilter = (vtkMoleculeToLinesFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMoleculeToLinesFilter.Register(null);
				}
			}
			return vtkMoleculeToLinesFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013AE RID: 5038
		public new const string MRFullTypeName = "Kitware.VTK.vtkMoleculeToLinesFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013AF RID: 5039
		public new static readonly string MRClassNameKey = "class vtkMoleculeToLinesFilter";
	}
}
