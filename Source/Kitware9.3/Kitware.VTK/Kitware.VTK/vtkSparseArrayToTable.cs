using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSparseArrayToTable
	/// </summary>
	/// <remarks>
	///    Converts a sparse array to a vtkTable.
	///
	///
	/// Converts any sparse array to a vtkTable containing one row for each value
	/// stored in the array.  The table will contain one column of coordinates for each
	/// dimension in the source array, plus one column of array values.  A common use-case
	/// for vtkSparseArrayToTable would be converting a sparse array into a table
	/// suitable for use as an input to vtkTableToGraph.
	///
	/// The coordinate columns in the output table will be named using the dimension labels
	/// from the source array,  The value column name can be explicitly set using
	/// SetValueColumn().
	///
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
	/// </seealso>
	// Token: 0x02000690 RID: 1680
	public class vtkSparseArrayToTable : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601203D RID: 73789 RVA: 0x001938CB File Offset: 0x00191ACB
		static vtkSparseArrayToTable()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSparseArrayToTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSparseArrayToTable"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601203E RID: 73790 RVA: 0x001938F3 File Offset: 0x00191AF3
		public vtkSparseArrayToTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601203F RID: 73791
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSparseArrayToTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012040 RID: 73792 RVA: 0x00193904 File Offset: 0x00191B04
		public new static vtkSparseArrayToTable New()
		{
			vtkSparseArrayToTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSparseArrayToTable.vtkSparseArrayToTable_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSparseArrayToTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012041 RID: 73793 RVA: 0x00193958 File Offset: 0x00191B58
		public vtkSparseArrayToTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSparseArrayToTable.vtkSparseArrayToTable_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012042 RID: 73794 RVA: 0x0019399C File Offset: 0x00191B9C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012043 RID: 73795
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSparseArrayToTable_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012044 RID: 73796 RVA: 0x001939A8 File Offset: 0x00191BA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSparseArrayToTable.vtkSparseArrayToTable_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012045 RID: 73797
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSparseArrayToTable_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012046 RID: 73798 RVA: 0x001939C8 File Offset: 0x00191BC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSparseArrayToTable.vtkSparseArrayToTable_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012047 RID: 73799
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSparseArrayToTable_GetValueColumn_03(HandleRef pThis);

		/// <summary>
		/// Specify the name of the output table column that contains array values.
		/// Default: "value"
		/// </summary>
		// Token: 0x06012048 RID: 73800 RVA: 0x001939E4 File Offset: 0x00191BE4
		public virtual string GetValueColumn()
		{
			string s = Marshal.PtrToStringAnsi(vtkSparseArrayToTable.vtkSparseArrayToTable_GetValueColumn_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06012049 RID: 73801
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSparseArrayToTable_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601204A RID: 73802 RVA: 0x00193A20 File Offset: 0x00191C20
		public override int IsA(string type)
		{
			return vtkSparseArrayToTable.vtkSparseArrayToTable_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601204B RID: 73803
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSparseArrayToTable_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601204C RID: 73804 RVA: 0x00193A40 File Offset: 0x00191C40
		public new static int IsTypeOf(string type)
		{
			return vtkSparseArrayToTable.vtkSparseArrayToTable_IsTypeOf_05(type);
		}

		// Token: 0x0601204D RID: 73805
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSparseArrayToTable_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601204E RID: 73806 RVA: 0x00193A5C File Offset: 0x00191C5C
		public new vtkSparseArrayToTable NewInstance()
		{
			vtkSparseArrayToTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSparseArrayToTable.vtkSparseArrayToTable_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSparseArrayToTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601204F RID: 73807
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSparseArrayToTable_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012050 RID: 73808 RVA: 0x00193AB8 File Offset: 0x00191CB8
		public new static vtkSparseArrayToTable SafeDownCast(vtkObjectBase o)
		{
			vtkSparseArrayToTable vtkSparseArrayToTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSparseArrayToTable.vtkSparseArrayToTable_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSparseArrayToTable = (vtkSparseArrayToTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSparseArrayToTable.Register(null);
				}
			}
			return vtkSparseArrayToTable;
		}

		// Token: 0x06012051 RID: 73809
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSparseArrayToTable_SetValueColumn_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of the output table column that contains array values.
		/// Default: "value"
		/// </summary>
		// Token: 0x06012052 RID: 73810 RVA: 0x00193B37 File Offset: 0x00191D37
		public virtual void SetValueColumn(string _arg)
		{
			vtkSparseArrayToTable.vtkSparseArrayToTable_SetValueColumn_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014CB RID: 5323
		public new const string MRFullTypeName = "Kitware.VTK.vtkSparseArrayToTable";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014CC RID: 5324
		public new static readonly string MRClassNameKey = "class vtkSparseArrayToTable";
	}
}
