using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTableToSparseArray
	/// </summary>
	/// <remarks>
	///    converts a vtkTable into a sparse array.
	///
	///
	/// Converts a vtkTable into a sparse array.  Use AddCoordinateColumn() to
	/// designate one-to-many table columns that contain coordinates for each
	/// array value, and SetValueColumn() to designate the table column that
	/// contains array values.
	///
	/// Thus, the number of dimensions in the output array will equal the number
	/// of calls to AddCoordinateColumn().
	///
	/// The coordinate columns will also be used to populate dimension labels
	/// in the output array.
	///
	/// By default, the extent of the output array will be set to the range
	/// [0, largest coordinate + 1) along each dimension.  In some situations
	/// you may prefer to set the extents explicitly, using the
	/// SetOutputExtents() method.  This is useful when the output array should
	/// be larger than its largest coordinates, or when working with partitioned
	/// data.
	///
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
	/// </seealso>
	// Token: 0x02000696 RID: 1686
	public class vtkTableToSparseArray : vtkArrayDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601212B RID: 74027 RVA: 0x00194CD7 File Offset: 0x00192ED7
		static vtkTableToSparseArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableToSparseArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableToSparseArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601212C RID: 74028 RVA: 0x00194CFF File Offset: 0x00192EFF
		public vtkTableToSparseArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601212D RID: 74029
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToSparseArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601212E RID: 74030 RVA: 0x00194D10 File Offset: 0x00192F10
		public new static vtkTableToSparseArray New()
		{
			vtkTableToSparseArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToSparseArray.vtkTableToSparseArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToSparseArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601212F RID: 74031 RVA: 0x00194D64 File Offset: 0x00192F64
		public vtkTableToSparseArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTableToSparseArray.vtkTableToSparseArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012130 RID: 74032 RVA: 0x00194DA8 File Offset: 0x00192FA8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012131 RID: 74033
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToSparseArray_AddCoordinateColumn_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Specify the set of input table columns that will be mapped to coordinates
		/// in the output sparse array.
		/// </summary>
		// Token: 0x06012132 RID: 74034 RVA: 0x00194DB3 File Offset: 0x00192FB3
		public void AddCoordinateColumn(string name)
		{
			vtkTableToSparseArray.vtkTableToSparseArray_AddCoordinateColumn_01(base.GetCppThis(), name);
		}

		// Token: 0x06012133 RID: 74035
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToSparseArray_ClearCoordinateColumns_02(HandleRef pThis);

		/// <summary>
		/// Specify the set of input table columns that will be mapped to coordinates
		/// in the output sparse array.
		/// </summary>
		// Token: 0x06012134 RID: 74036 RVA: 0x00194DC3 File Offset: 0x00192FC3
		public void ClearCoordinateColumns()
		{
			vtkTableToSparseArray.vtkTableToSparseArray_ClearCoordinateColumns_02(base.GetCppThis());
		}

		// Token: 0x06012135 RID: 74037
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToSparseArray_ClearOutputExtents_03(HandleRef pThis);

		/// <summary>
		/// Explicitly specify the extents of the output array.
		/// </summary>
		// Token: 0x06012136 RID: 74038 RVA: 0x00194DD2 File Offset: 0x00192FD2
		public void ClearOutputExtents()
		{
			vtkTableToSparseArray.vtkTableToSparseArray_ClearOutputExtents_03(base.GetCppThis());
		}

		// Token: 0x06012137 RID: 74039
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableToSparseArray_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012138 RID: 74040 RVA: 0x00194DE4 File Offset: 0x00192FE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTableToSparseArray.vtkTableToSparseArray_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06012139 RID: 74041
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableToSparseArray_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601213A RID: 74042 RVA: 0x00194E04 File Offset: 0x00193004
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTableToSparseArray.vtkTableToSparseArray_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601213B RID: 74043
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToSparseArray_GetValueColumn_06(HandleRef pThis);

		/// <summary>
		/// Specify the input table column that will be mapped to values in the output array.
		/// </summary>
		// Token: 0x0601213C RID: 74044 RVA: 0x00194E20 File Offset: 0x00193020
		public string GetValueColumn()
		{
			string s = Marshal.PtrToStringAnsi(vtkTableToSparseArray.vtkTableToSparseArray_GetValueColumn_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601213D RID: 74045
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToSparseArray_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601213E RID: 74046 RVA: 0x00194E5C File Offset: 0x0019305C
		public override int IsA(string type)
		{
			return vtkTableToSparseArray.vtkTableToSparseArray_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601213F RID: 74047
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToSparseArray_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012140 RID: 74048 RVA: 0x00194E7C File Offset: 0x0019307C
		public new static int IsTypeOf(string type)
		{
			return vtkTableToSparseArray.vtkTableToSparseArray_IsTypeOf_08(type);
		}

		// Token: 0x06012141 RID: 74049
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToSparseArray_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012142 RID: 74050 RVA: 0x00194E98 File Offset: 0x00193098
		public new vtkTableToSparseArray NewInstance()
		{
			vtkTableToSparseArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToSparseArray.vtkTableToSparseArray_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToSparseArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012143 RID: 74051
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToSparseArray_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012144 RID: 74052 RVA: 0x00194EF4 File Offset: 0x001930F4
		public new static vtkTableToSparseArray SafeDownCast(vtkObjectBase o)
		{
			vtkTableToSparseArray vtkTableToSparseArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToSparseArray.vtkTableToSparseArray_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableToSparseArray = (vtkTableToSparseArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableToSparseArray.Register(null);
				}
			}
			return vtkTableToSparseArray;
		}

		// Token: 0x06012145 RID: 74053
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTableToSparseArray_SetValueColumn_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Specify the input table column that will be mapped to values in the output array.
		/// </summary>
		// Token: 0x06012146 RID: 74054 RVA: 0x00194F73 File Offset: 0x00193173
		public void SetValueColumn(string name)
		{
			vtkTableToSparseArray.vtkTableToSparseArray_SetValueColumn_12(base.GetCppThis(), name);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014D7 RID: 5335
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableToSparseArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014D8 RID: 5336
		public new static readonly string MRClassNameKey = "class vtkTableToSparseArray";
	}
}
