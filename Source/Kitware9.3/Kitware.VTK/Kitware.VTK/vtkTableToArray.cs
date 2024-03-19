using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTableToArray
	/// </summary>
	/// <remarks>
	///    converts a vtkTable to a matrix.
	///
	///
	/// Converts a vtkTable into a dense matrix.  Use AddColumn() to
	/// designate one-to-many table columns that will become columns in the
	/// output matrix.a
	///
	/// Using AddColumn() it is possible to duplicate / reorder columns in
	/// arbitrary ways.
	///
	/// @warning
	/// Only produces vtkDenseArray&lt;double&gt;, regardless of the input table column types.
	///
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
	/// </seealso>
	// Token: 0x02000694 RID: 1684
	public class vtkTableToArray : vtkArrayDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060120E5 RID: 73957 RVA: 0x0019464D File Offset: 0x0019284D
		static vtkTableToArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableToArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableToArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060120E6 RID: 73958 RVA: 0x00194675 File Offset: 0x00192875
		public vtkTableToArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060120E7 RID: 73959
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060120E8 RID: 73960 RVA: 0x00194684 File Offset: 0x00192884
		public new static vtkTableToArray New()
		{
			vtkTableToArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToArray.vtkTableToArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060120E9 RID: 73961 RVA: 0x001946D8 File Offset: 0x001928D8
		public vtkTableToArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTableToArray.vtkTableToArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060120EA RID: 73962 RVA: 0x0019471C File Offset: 0x0019291C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060120EB RID: 73963
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToArray_AddAllColumns_01(HandleRef pThis);

		/// <summary>
		/// Add every input table column to the output matrix.
		/// </summary>
		// Token: 0x060120EC RID: 73964 RVA: 0x00194727 File Offset: 0x00192927
		public void AddAllColumns()
		{
			vtkTableToArray.vtkTableToArray_AddAllColumns_01(base.GetCppThis());
		}

		// Token: 0x060120ED RID: 73965
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToArray_AddColumn_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Add a column by name to the list of input table columns that will be
		/// mapped to columns in the output matrix.
		/// </summary>
		// Token: 0x060120EE RID: 73966 RVA: 0x00194736 File Offset: 0x00192936
		public void AddColumn(string name)
		{
			vtkTableToArray.vtkTableToArray_AddColumn_02(base.GetCppThis(), name);
		}

		// Token: 0x060120EF RID: 73967
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToArray_AddColumn_03(HandleRef pThis, long index);

		/// <summary>
		/// Add a column by index to the list of input table columns that will be
		/// mapped to columns in the output matrix.
		/// </summary>
		// Token: 0x060120F0 RID: 73968 RVA: 0x00194746 File Offset: 0x00192946
		public void AddColumn(long index)
		{
			vtkTableToArray.vtkTableToArray_AddColumn_03(base.GetCppThis(), index);
		}

		// Token: 0x060120F1 RID: 73969
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToArray_ClearColumns_04(HandleRef pThis);

		/// <summary>
		/// Reset the list of input table columns that will be mapped to columns
		/// in the output matrix.
		/// </summary>
		// Token: 0x060120F2 RID: 73970 RVA: 0x00194756 File Offset: 0x00192956
		public void ClearColumns()
		{
			vtkTableToArray.vtkTableToArray_ClearColumns_04(base.GetCppThis());
		}

		// Token: 0x060120F3 RID: 73971
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableToArray_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060120F4 RID: 73972 RVA: 0x00194768 File Offset: 0x00192968
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTableToArray.vtkTableToArray_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060120F5 RID: 73973
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableToArray_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060120F6 RID: 73974 RVA: 0x00194788 File Offset: 0x00192988
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTableToArray.vtkTableToArray_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060120F7 RID: 73975
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToArray_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060120F8 RID: 73976 RVA: 0x001947A4 File Offset: 0x001929A4
		public override int IsA(string type)
		{
			return vtkTableToArray.vtkTableToArray_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060120F9 RID: 73977
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToArray_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060120FA RID: 73978 RVA: 0x001947C4 File Offset: 0x001929C4
		public new static int IsTypeOf(string type)
		{
			return vtkTableToArray.vtkTableToArray_IsTypeOf_08(type);
		}

		// Token: 0x060120FB RID: 73979
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToArray_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060120FC RID: 73980 RVA: 0x001947E0 File Offset: 0x001929E0
		public new vtkTableToArray NewInstance()
		{
			vtkTableToArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToArray.vtkTableToArray_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060120FD RID: 73981
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToArray_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060120FE RID: 73982 RVA: 0x0019483C File Offset: 0x00192A3C
		public new static vtkTableToArray SafeDownCast(vtkObjectBase o)
		{
			vtkTableToArray vtkTableToArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToArray.vtkTableToArray_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableToArray = (vtkTableToArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableToArray.Register(null);
				}
			}
			return vtkTableToArray;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014D3 RID: 5331
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableToArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014D4 RID: 5332
		public new static readonly string MRClassNameKey = "class vtkTableToArray";
	}
}
