using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSortFieldData
	/// </summary>
	/// <remarks>
	///    provides a method for sorting field data
	///
	///
	/// vtkSortFieldData is used to sort data, based on its value, or with an
	/// associated key, into either ascending or descending order. This is useful
	/// for operations like selection, or analysis, when evaluating and processing
	/// data.
	///
	/// This class, which extends the base functionality of vtkSortDataArray,
	/// is used to sort field data and its various subclasses (vtkFieldData,
	/// vtkDataSetAttributes, vtkPointData, vtkCellData, etc.)
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly on
	/// multi-core machines.
	///
	/// @warning
	/// The sort methods below are static, hence the sorting methods can be
	/// used without instantiating the class. All methods are thread safe.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSortDataArray
	/// </seealso>
	// Token: 0x02000AC2 RID: 2754
	public class vtkSortFieldData : vtkSortDataArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CFCA RID: 118730 RVA: 0x0028DF6F File Offset: 0x0028C16F
		static vtkSortFieldData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSortFieldData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSortFieldData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CFCB RID: 118731 RVA: 0x0028DF97 File Offset: 0x0028C197
		public vtkSortFieldData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CFCC RID: 118732
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSortFieldData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods for instantiating, managing type, and printing
		/// information about this class.
		/// </summary>
		// Token: 0x0601CFCD RID: 118733 RVA: 0x0028DFA8 File Offset: 0x0028C1A8
		public new static vtkSortFieldData New()
		{
			vtkSortFieldData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSortFieldData.vtkSortFieldData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSortFieldData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard VTK methods for instantiating, managing type, and printing
		/// information about this class.
		/// </summary>
		// Token: 0x0601CFCE RID: 118734 RVA: 0x0028DFFC File Offset: 0x0028C1FC
		public vtkSortFieldData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSortFieldData.vtkSortFieldData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CFCF RID: 118735 RVA: 0x0028E040 File Offset: 0x0028C240
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CFD0 RID: 118736
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSortFieldData_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for instantiating, managing type, and printing
		/// information about this class.
		/// </summary>
		// Token: 0x0601CFD1 RID: 118737 RVA: 0x0028E04C File Offset: 0x0028C24C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSortFieldData.vtkSortFieldData_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601CFD2 RID: 118738
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSortFieldData_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for instantiating, managing type, and printing
		/// information about this class.
		/// </summary>
		// Token: 0x0601CFD3 RID: 118739 RVA: 0x0028E06C File Offset: 0x0028C26C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSortFieldData.vtkSortFieldData_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601CFD4 RID: 118740
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSortFieldData_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for instantiating, managing type, and printing
		/// information about this class.
		/// </summary>
		// Token: 0x0601CFD5 RID: 118741 RVA: 0x0028E088 File Offset: 0x0028C288
		public override int IsA(string type)
		{
			return vtkSortFieldData.vtkSortFieldData_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601CFD6 RID: 118742
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSortFieldData_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for instantiating, managing type, and printing
		/// information about this class.
		/// </summary>
		// Token: 0x0601CFD7 RID: 118743 RVA: 0x0028E0A8 File Offset: 0x0028C2A8
		public new static int IsTypeOf(string type)
		{
			return vtkSortFieldData.vtkSortFieldData_IsTypeOf_04(type);
		}

		// Token: 0x0601CFD8 RID: 118744
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSortFieldData_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods for instantiating, managing type, and printing
		/// information about this class.
		/// </summary>
		// Token: 0x0601CFD9 RID: 118745 RVA: 0x0028E0C4 File Offset: 0x0028C2C4
		public new vtkSortFieldData NewInstance()
		{
			vtkSortFieldData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSortFieldData.vtkSortFieldData_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSortFieldData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CFDA RID: 118746
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSortFieldData_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods for instantiating, managing type, and printing
		/// information about this class.
		/// </summary>
		// Token: 0x0601CFDB RID: 118747 RVA: 0x0028E120 File Offset: 0x0028C320
		public new static vtkSortFieldData SafeDownCast(vtkObjectBase o)
		{
			vtkSortFieldData vtkSortFieldData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSortFieldData.vtkSortFieldData_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSortFieldData = (vtkSortFieldData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSortFieldData.Register(null);
				}
			}
			return vtkSortFieldData;
		}

		// Token: 0x0601CFDC RID: 118748
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSortFieldData_Sort_08(HandleRef fd, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int k, int returnIndices);

		/// <summary>
		/// Given field data (and derived classes such as point data and cell data),
		/// sort all the arrays in the field data given an array and a component
		/// number k from that array. In other words, if an array has n components,
		/// the kth component is used to sort the array and all of the other arrays
		/// in the field data.  Also note that the user can indicate whether the
		/// function returns the sort indices (returnIndices=1). If the indices are
		/// returned, then the user takes ownership of the data and must delete
		/// it. Note that the indices are in sorted (ascending) order, and indicate
		/// the final sorted position of the sort. So for example indices[0]=10
		/// indicates that the original data in position 10 in the field, was moved
		/// to position 0 after the sort. By default, returnIndices=0. (Other notes:
		/// if any array is not the same length as the sorting array, then it will
		/// be skipped and not sorted.)
		/// </summary>
		// Token: 0x0601CFDD RID: 118749 RVA: 0x0028E1A0 File Offset: 0x0028C3A0
		public static IntPtr Sort(vtkFieldData fd, string arrayName, int k, int returnIndices)
		{
			return vtkSortFieldData.vtkSortFieldData_Sort_08((fd == null) ? default(HandleRef) : fd.GetCppThis(), arrayName, k, returnIndices);
		}

		// Token: 0x0601CFDE RID: 118750
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSortFieldData_Sort_09(HandleRef fd, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int k, int returnIndices, int dir);

		/// <summary>
		/// Given field data (and derived classes such as point data and cell data),
		/// sort all the arrays in the field data given an array and a component
		/// number k from that array. In other words, if an array has n components,
		/// the kth component is used to sort the array and all of the other arrays
		/// in the field data.  The order of the sorted data is goven by dir: dir=0
		/// means sort in ascending order; dir=1 means sort in descending
		/// order. Also note that the user can indicate whether the function returns
		/// the sort indices (returnIndices=1). If the indices are returned, then
		/// the user takes ownership of the data and must delete it. Note that the
		/// indices are always in sorted (ascending) order, and indicate the final
		/// sorted position of the sort. So for example indices[0]=10 indicates that
		/// the original data in position 10 in the field, was moved to position 0
		/// after the sort (i.e., position 0 is the smallest value). However, if
		/// sort direction dir=1, the indices do not change but the final shuffle of
		/// the data is in reverse order (note idx[n-1] for n keys is the largest
		/// value). By default, returnIndices=0. (Other notes: if any array is not
		/// the same length as the sorting array, then it will be skipped and not
		/// sorted.)
		/// </summary>
		// Token: 0x0601CFDF RID: 118751 RVA: 0x0028E1D4 File Offset: 0x0028C3D4
		public static IntPtr Sort(vtkFieldData fd, string arrayName, int k, int returnIndices, int dir)
		{
			return vtkSortFieldData.vtkSortFieldData_Sort_09((fd == null) ? default(HandleRef) : fd.GetCppThis(), arrayName, k, returnIndices, dir);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EA0 RID: 7840
		public new const string MRFullTypeName = "Kitware.VTK.vtkSortFieldData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EA1 RID: 7841
		public new static readonly string MRClassNameKey = "class vtkSortFieldData";
	}
}
