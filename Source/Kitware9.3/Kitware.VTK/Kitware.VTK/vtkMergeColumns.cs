using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMergeColumns
	/// </summary>
	/// <remarks>
	///    merge two columns into a single column
	///
	///
	/// vtkMergeColumns replaces two columns in a table with a single column
	/// containing data in both columns.  The columns are set using
	///
	///   SetInputArrayToProcess(0, 0, 0, vtkDataObject::FIELD_ASSOCIATION_ROWS, "col1")
	///
	/// and
	///
	///   SetInputArrayToProcess(1, 0, 0, vtkDataObject::FIELD_ASSOCIATION_ROWS, "col2")
	///
	/// where "col1" and "col2" are the names of the columns to merge.
	/// The user may also specify the name of the merged column.
	/// The arrays must be of the same type.
	/// If the arrays are numeric, the values are summed in the merged column.
	/// If the arrays are strings, the values are concatenated.  The strings are
	/// separated by a space if they are both nonempty.
	/// </remarks>
	// Token: 0x02000683 RID: 1667
	public class vtkMergeColumns : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011E9F RID: 73375 RVA: 0x00191207 File Offset: 0x0018F407
		static vtkMergeColumns()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergeColumns.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeColumns"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011EA0 RID: 73376 RVA: 0x0019122F File Offset: 0x0018F42F
		public vtkMergeColumns(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011EA1 RID: 73377
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeColumns_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EA2 RID: 73378 RVA: 0x00191240 File Offset: 0x0018F440
		public new static vtkMergeColumns New()
		{
			vtkMergeColumns result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeColumns.vtkMergeColumns_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeColumns)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EA3 RID: 73379 RVA: 0x00191294 File Offset: 0x0018F494
		public vtkMergeColumns() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMergeColumns.vtkMergeColumns_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011EA4 RID: 73380 RVA: 0x001912D8 File Offset: 0x0018F4D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011EA5 RID: 73381
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeColumns_GetMergedColumnName_01(HandleRef pThis);

		/// <summary>
		/// The name to give the merged column created by this filter.
		/// </summary>
		// Token: 0x06011EA6 RID: 73382 RVA: 0x001912E4 File Offset: 0x0018F4E4
		public virtual string GetMergedColumnName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMergeColumns.vtkMergeColumns_GetMergedColumnName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011EA7 RID: 73383
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeColumns_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EA8 RID: 73384 RVA: 0x00191320 File Offset: 0x0018F520
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMergeColumns.vtkMergeColumns_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06011EA9 RID: 73385
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeColumns_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EAA RID: 73386 RVA: 0x00191340 File Offset: 0x0018F540
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMergeColumns.vtkMergeColumns_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06011EAB RID: 73387
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeColumns_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EAC RID: 73388 RVA: 0x0019135C File Offset: 0x0018F55C
		public override int IsA(string type)
		{
			return vtkMergeColumns.vtkMergeColumns_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06011EAD RID: 73389
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeColumns_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EAE RID: 73390 RVA: 0x0019137C File Offset: 0x0018F57C
		public new static int IsTypeOf(string type)
		{
			return vtkMergeColumns.vtkMergeColumns_IsTypeOf_05(type);
		}

		// Token: 0x06011EAF RID: 73391
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeColumns_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EB0 RID: 73392 RVA: 0x00191398 File Offset: 0x0018F598
		public new vtkMergeColumns NewInstance()
		{
			vtkMergeColumns result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeColumns.vtkMergeColumns_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeColumns)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011EB1 RID: 73393
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeColumns_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EB2 RID: 73394 RVA: 0x001913F4 File Offset: 0x0018F5F4
		public new static vtkMergeColumns SafeDownCast(vtkObjectBase o)
		{
			vtkMergeColumns vtkMergeColumns = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeColumns.vtkMergeColumns_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergeColumns = (vtkMergeColumns)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergeColumns.Register(null);
				}
			}
			return vtkMergeColumns;
		}

		// Token: 0x06011EB3 RID: 73395
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeColumns_SetMergedColumnName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name to give the merged column created by this filter.
		/// </summary>
		// Token: 0x06011EB4 RID: 73396 RVA: 0x00191473 File Offset: 0x0018F673
		public virtual void SetMergedColumnName(string _arg)
		{
			vtkMergeColumns.vtkMergeColumns_SetMergedColumnName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014AF RID: 5295
		public new const string MRFullTypeName = "Kitware.VTK.vtkMergeColumns";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014B0 RID: 5296
		public new static readonly string MRClassNameKey = "class vtkMergeColumns";
	}
}
