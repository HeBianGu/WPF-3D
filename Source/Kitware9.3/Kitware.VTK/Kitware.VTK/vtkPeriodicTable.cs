using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPeriodicTable
	/// </summary>
	/// <remarks>
	///    Access to information about the elements.
	///
	///
	/// Sourced from the Blue Obelisk Data Repository
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBlueObeliskData vtkBlueObeliskDataParser
	/// </seealso>
	// Token: 0x02000625 RID: 1573
	public class vtkPeriodicTable : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060110A5 RID: 69797 RVA: 0x0017BD8B File Offset: 0x00179F8B
		static vtkPeriodicTable()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPeriodicTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPeriodicTable"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060110A6 RID: 69798 RVA: 0x0017BDB3 File Offset: 0x00179FB3
		public vtkPeriodicTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060110A7 RID: 69799
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPeriodicTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060110A8 RID: 69800 RVA: 0x0017BDC4 File Offset: 0x00179FC4
		public new static vtkPeriodicTable New()
		{
			vtkPeriodicTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPeriodicTable.vtkPeriodicTable_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPeriodicTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060110A9 RID: 69801 RVA: 0x0017BE18 File Offset: 0x0017A018
		public vtkPeriodicTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPeriodicTable.vtkPeriodicTable_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060110AA RID: 69802 RVA: 0x0017BE5C File Offset: 0x0017A05C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060110AB RID: 69803
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkPeriodicTable_GetAtomicNumber_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str);

		/// <summary>
		/// Given a case-insensitive string that contains the symbol or name
		/// of an element, return the corresponding atomic number.
		/// </summary>
		// Token: 0x060110AC RID: 69804 RVA: 0x0017BE68 File Offset: 0x0017A068
		public ushort GetAtomicNumber(string str)
		{
			return vtkPeriodicTable.vtkPeriodicTable_GetAtomicNumber_01(base.GetCppThis(), str);
		}

		// Token: 0x060110AD RID: 69805
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkPeriodicTable_GetCovalentRadius_02(HandleRef pThis, ushort atomicNum);

		/// <summary>
		/// Given an atomic number, return the covalent radius of the atom
		/// </summary>
		// Token: 0x060110AE RID: 69806 RVA: 0x0017BE88 File Offset: 0x0017A088
		public float GetCovalentRadius(ushort atomicNum)
		{
			return vtkPeriodicTable.vtkPeriodicTable_GetCovalentRadius_02(base.GetCppThis(), atomicNum);
		}

		// Token: 0x060110AF RID: 69807
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPeriodicTable_GetDefaultLUT_03(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Fill the given vtkLookupTable to map atomic numbers to the
		/// familiar RGB tuples provided by the Blue Obelisk Data Repository
		/// </summary>
		// Token: 0x060110B0 RID: 69808 RVA: 0x0017BEA8 File Offset: 0x0017A0A8
		public void GetDefaultLUT(vtkLookupTable arg0)
		{
			vtkPeriodicTable.vtkPeriodicTable_GetDefaultLUT_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060110B1 RID: 69809
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPeriodicTable_GetDefaultRGBTuple_04(HandleRef pThis, ushort atomicNum, IntPtr rgb);

		/// <summary>
		/// Given an atomic number, return the familiar RGB tuple provided by
		/// the Blue Obelisk Data Repository
		/// </summary>
		// Token: 0x060110B2 RID: 69810 RVA: 0x0017BED7 File Offset: 0x0017A0D7
		public void GetDefaultRGBTuple(ushort atomicNum, IntPtr rgb)
		{
			vtkPeriodicTable.vtkPeriodicTable_GetDefaultRGBTuple_04(base.GetCppThis(), atomicNum, rgb);
		}

		// Token: 0x060110B3 RID: 69811
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPeriodicTable_GetDefaultRGBTuple_05(HandleRef pThis, ushort atomicNum, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given an atomic number, return the familiar RGB tuple provided by
		/// the Blue Obelisk Data Repository
		/// </summary>
		// Token: 0x060110B4 RID: 69812 RVA: 0x0017BEE8 File Offset: 0x0017A0E8
		public vtkColor3f GetDefaultRGBTuple(ushort atomicNum)
		{
			vtkColor3f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPeriodicTable.vtkPeriodicTable_GetDefaultRGBTuple_05(base.GetCppThis(), atomicNum, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor3f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060110B5 RID: 69813
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPeriodicTable_GetElementName_06(HandleRef pThis, ushort atomicNum);

		/// <summary>
		/// Given an atomic number, returns the name of the element
		/// </summary>
		// Token: 0x060110B6 RID: 69814 RVA: 0x0017BF44 File Offset: 0x0017A144
		public string GetElementName(ushort atomicNum)
		{
			string s = Marshal.PtrToStringAnsi(vtkPeriodicTable.vtkPeriodicTable_GetElementName_06(base.GetCppThis(), atomicNum));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060110B7 RID: 69815
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkPeriodicTable_GetMaxVDWRadius_07(HandleRef pThis);

		/// <summary>
		/// Given an atomic number, returns the van der Waals radius of the
		/// atom
		/// </summary>
		// Token: 0x060110B8 RID: 69816 RVA: 0x0017BF80 File Offset: 0x0017A180
		public float GetMaxVDWRadius()
		{
			return vtkPeriodicTable.vtkPeriodicTable_GetMaxVDWRadius_07(base.GetCppThis());
		}

		// Token: 0x060110B9 RID: 69817
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkPeriodicTable_GetNumberOfElements_08(HandleRef pThis);

		/// <summary>
		/// Returns the number of elements in the periodic table.
		/// </summary>
		// Token: 0x060110BA RID: 69818 RVA: 0x0017BFA0 File Offset: 0x0017A1A0
		public ushort GetNumberOfElements()
		{
			return vtkPeriodicTable.vtkPeriodicTable_GetNumberOfElements_08(base.GetCppThis());
		}

		// Token: 0x060110BB RID: 69819
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPeriodicTable_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060110BC RID: 69820 RVA: 0x0017BFC0 File Offset: 0x0017A1C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPeriodicTable.vtkPeriodicTable_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x060110BD RID: 69821
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPeriodicTable_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060110BE RID: 69822 RVA: 0x0017BFE0 File Offset: 0x0017A1E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPeriodicTable.vtkPeriodicTable_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x060110BF RID: 69823
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPeriodicTable_GetSymbol_11(HandleRef pThis, ushort atomicNum);

		/// <summary>
		/// Given an atomic number, returns the symbol associated with the
		/// element
		/// </summary>
		// Token: 0x060110C0 RID: 69824 RVA: 0x0017BFFC File Offset: 0x0017A1FC
		public string GetSymbol(ushort atomicNum)
		{
			string s = Marshal.PtrToStringAnsi(vtkPeriodicTable.vtkPeriodicTable_GetSymbol_11(base.GetCppThis(), atomicNum));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060110C1 RID: 69825
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkPeriodicTable_GetVDWRadius_12(HandleRef pThis, ushort atomicNum);

		/// <summary>
		/// Given an atomic number, returns the van der Waals radius of the
		/// atom
		/// </summary>
		// Token: 0x060110C2 RID: 69826 RVA: 0x0017C038 File Offset: 0x0017A238
		public float GetVDWRadius(ushort atomicNum)
		{
			return vtkPeriodicTable.vtkPeriodicTable_GetVDWRadius_12(base.GetCppThis(), atomicNum);
		}

		// Token: 0x060110C3 RID: 69827
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPeriodicTable_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060110C4 RID: 69828 RVA: 0x0017C058 File Offset: 0x0017A258
		public override int IsA(string type)
		{
			return vtkPeriodicTable.vtkPeriodicTable_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x060110C5 RID: 69829
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPeriodicTable_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060110C6 RID: 69830 RVA: 0x0017C078 File Offset: 0x0017A278
		public new static int IsTypeOf(string type)
		{
			return vtkPeriodicTable.vtkPeriodicTable_IsTypeOf_14(type);
		}

		// Token: 0x060110C7 RID: 69831
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPeriodicTable_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060110C8 RID: 69832 RVA: 0x0017C094 File Offset: 0x0017A294
		public new vtkPeriodicTable NewInstance()
		{
			vtkPeriodicTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPeriodicTable.vtkPeriodicTable_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPeriodicTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060110C9 RID: 69833
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPeriodicTable_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060110CA RID: 69834 RVA: 0x0017C0F0 File Offset: 0x0017A2F0
		public new static vtkPeriodicTable SafeDownCast(vtkObjectBase o)
		{
			vtkPeriodicTable vtkPeriodicTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPeriodicTable.vtkPeriodicTable_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPeriodicTable = (vtkPeriodicTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPeriodicTable.Register(null);
				}
			}
			return vtkPeriodicTable;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013B0 RID: 5040
		public new const string MRFullTypeName = "Kitware.VTK.vtkPeriodicTable";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013B1 RID: 5041
		public new static readonly string MRClassNameKey = "class vtkPeriodicTable";
	}
}
