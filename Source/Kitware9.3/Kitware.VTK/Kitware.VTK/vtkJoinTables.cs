using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkJoinTables
	/// </summary>
	/// <remarks>
	///    SQL-style Join operation on two tables.
	///
	///
	/// vtkJoinTables is a filter that operates on two vtkTable objects to perform an
	/// SQL-style Join operation. It outputs one vtkTable object. The goal is to combine the rows of both
	/// tables into one bigger table based on a related column between them (both inputs have their "key
	/// column"). The two input tables are referred to as left and right. In each input table, the values
	/// in the key column act like unique IDs for their respective  rows. During the merge, the
	/// attributes of each item will be given with respect to its ID.
	/// </remarks>
	// Token: 0x020008B2 RID: 2226
	public class vtkJoinTables : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017180 RID: 94592 RVA: 0x00206D37 File Offset: 0x00204F37
		static vtkJoinTables()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkJoinTables.MRClassNameKey, Type.GetType("Kitware.VTK.vtkJoinTables"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017181 RID: 94593 RVA: 0x00206D5F File Offset: 0x00204F5F
		public vtkJoinTables(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017182 RID: 94594
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJoinTables_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017183 RID: 94595 RVA: 0x00206D70 File Offset: 0x00204F70
		public new static vtkJoinTables New()
		{
			vtkJoinTables result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJoinTables.vtkJoinTables_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJoinTables)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017184 RID: 94596 RVA: 0x00206DC4 File Offset: 0x00204FC4
		public vtkJoinTables() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkJoinTables.vtkJoinTables_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017185 RID: 94597 RVA: 0x00206E08 File Offset: 0x00205008
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017186 RID: 94598
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJoinTables_GetLeftKey_01(HandleRef pThis);

		/// <summary>
		/// Specifies which column of the left table to use for the join operation.
		/// </summary>
		// Token: 0x06017187 RID: 94599 RVA: 0x00206E14 File Offset: 0x00205014
		public virtual string GetLeftKey()
		{
			string s = Marshal.PtrToStringAnsi(vtkJoinTables.vtkJoinTables_GetLeftKey_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06017188 RID: 94600
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJoinTables_GetMode_02(HandleRef pThis);

		/// <summary>
		/// The mode of the Join Tables filter. This is meaningful when the two key columns do not share
		/// exactly the same set of values. The different Join modes that this filter implements are :
		/// - INTERSECTION : Keeps only the keys that are in both columns.
		/// - UNION : Keeps all of the keys from both tables.
		/// - LEFT : Keeps the keys from the left table.
		/// - RIGHT : Keeps the keys from the right table.
		/// </summary>
		// Token: 0x06017189 RID: 94601 RVA: 0x00206E50 File Offset: 0x00205050
		public virtual int GetMode()
		{
			return vtkJoinTables.vtkJoinTables_GetMode_02(base.GetCppThis());
		}

		// Token: 0x0601718A RID: 94602
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJoinTables_GetModeMaxValue_03(HandleRef pThis);

		/// <summary>
		/// The mode of the Join Tables filter. This is meaningful when the two key columns do not share
		/// exactly the same set of values. The different Join modes that this filter implements are :
		/// - INTERSECTION : Keeps only the keys that are in both columns.
		/// - UNION : Keeps all of the keys from both tables.
		/// - LEFT : Keeps the keys from the left table.
		/// - RIGHT : Keeps the keys from the right table.
		/// </summary>
		// Token: 0x0601718B RID: 94603 RVA: 0x00206E70 File Offset: 0x00205070
		public virtual int GetModeMaxValue()
		{
			return vtkJoinTables.vtkJoinTables_GetModeMaxValue_03(base.GetCppThis());
		}

		// Token: 0x0601718C RID: 94604
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJoinTables_GetModeMinValue_04(HandleRef pThis);

		/// <summary>
		/// The mode of the Join Tables filter. This is meaningful when the two key columns do not share
		/// exactly the same set of values. The different Join modes that this filter implements are :
		/// - INTERSECTION : Keeps only the keys that are in both columns.
		/// - UNION : Keeps all of the keys from both tables.
		/// - LEFT : Keeps the keys from the left table.
		/// - RIGHT : Keeps the keys from the right table.
		/// </summary>
		// Token: 0x0601718D RID: 94605 RVA: 0x00206E90 File Offset: 0x00205090
		public virtual int GetModeMinValue()
		{
			return vtkJoinTables.vtkJoinTables_GetModeMinValue_04(base.GetCppThis());
		}

		// Token: 0x0601718E RID: 94606
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkJoinTables_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601718F RID: 94607 RVA: 0x00206EB0 File Offset: 0x002050B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkJoinTables.vtkJoinTables_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06017190 RID: 94608
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkJoinTables_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017191 RID: 94609 RVA: 0x00206ED0 File Offset: 0x002050D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkJoinTables.vtkJoinTables_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06017192 RID: 94610
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkJoinTables_GetReplacementValue_07(HandleRef pThis);

		/// <summary>
		/// Value to be imputed in numeric columns of the output when the data for a given key in a given
		/// column is unknown.
		/// </summary>
		// Token: 0x06017193 RID: 94611 RVA: 0x00206EEC File Offset: 0x002050EC
		public virtual double GetReplacementValue()
		{
			return vtkJoinTables.vtkJoinTables_GetReplacementValue_07(base.GetCppThis());
		}

		// Token: 0x06017194 RID: 94612
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJoinTables_GetRightKey_08(HandleRef pThis);

		/// <summary>
		/// Specifies which column of the right table to use for the join operation.
		/// </summary>
		// Token: 0x06017195 RID: 94613 RVA: 0x00206F0C File Offset: 0x0020510C
		public virtual string GetRightKey()
		{
			string s = Marshal.PtrToStringAnsi(vtkJoinTables.vtkJoinTables_GetRightKey_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06017196 RID: 94614
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJoinTables_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017197 RID: 94615 RVA: 0x00206F48 File Offset: 0x00205148
		public override int IsA(string type)
		{
			return vtkJoinTables.vtkJoinTables_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06017198 RID: 94616
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJoinTables_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017199 RID: 94617 RVA: 0x00206F68 File Offset: 0x00205168
		public new static int IsTypeOf(string type)
		{
			return vtkJoinTables.vtkJoinTables_IsTypeOf_10(type);
		}

		// Token: 0x0601719A RID: 94618
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJoinTables_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601719B RID: 94619 RVA: 0x00206F84 File Offset: 0x00205184
		public new vtkJoinTables NewInstance()
		{
			vtkJoinTables result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJoinTables.vtkJoinTables_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJoinTables)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601719C RID: 94620
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJoinTables_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601719D RID: 94621 RVA: 0x00206FE0 File Offset: 0x002051E0
		public new static vtkJoinTables SafeDownCast(vtkObjectBase o)
		{
			vtkJoinTables vtkJoinTables = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJoinTables.vtkJoinTables_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkJoinTables = (vtkJoinTables)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkJoinTables.Register(null);
				}
			}
			return vtkJoinTables;
		}

		// Token: 0x0601719E RID: 94622
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJoinTables_SetLeftKey_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Specifies which column of the left table to use for the join operation.
		/// </summary>
		// Token: 0x0601719F RID: 94623 RVA: 0x0020705F File Offset: 0x0020525F
		public virtual void SetLeftKey(string arg)
		{
			vtkJoinTables.vtkJoinTables_SetLeftKey_14(base.GetCppThis(), arg);
		}

		// Token: 0x060171A0 RID: 94624
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJoinTables_SetMode_15(HandleRef pThis, int _arg);

		/// <summary>
		/// The mode of the Join Tables filter. This is meaningful when the two key columns do not share
		/// exactly the same set of values. The different Join modes that this filter implements are :
		/// - INTERSECTION : Keeps only the keys that are in both columns.
		/// - UNION : Keeps all of the keys from both tables.
		/// - LEFT : Keeps the keys from the left table.
		/// - RIGHT : Keeps the keys from the right table.
		/// </summary>
		// Token: 0x060171A1 RID: 94625 RVA: 0x0020706F File Offset: 0x0020526F
		public virtual void SetMode(int _arg)
		{
			vtkJoinTables.vtkJoinTables_SetMode_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060171A2 RID: 94626
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJoinTables_SetReplacementValue_16(HandleRef pThis, double _arg);

		/// <summary>
		/// Value to be imputed in numeric columns of the output when the data for a given key in a given
		/// column is unknown.
		/// </summary>
		// Token: 0x060171A3 RID: 94627 RVA: 0x0020707F File Offset: 0x0020527F
		public virtual void SetReplacementValue(double _arg)
		{
			vtkJoinTables.vtkJoinTables_SetReplacementValue_16(base.GetCppThis(), _arg);
		}

		// Token: 0x060171A4 RID: 94628
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJoinTables_SetRightKey_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Specifies which column of the right table to use for the join operation.
		/// </summary>
		// Token: 0x060171A5 RID: 94629 RVA: 0x0020708F File Offset: 0x0020528F
		public virtual void SetRightKey(string arg)
		{
			vtkJoinTables.vtkJoinTables_SetRightKey_17(base.GetCppThis(), arg);
		}

		// Token: 0x060171A6 RID: 94630
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJoinTables_SetSourceConnection_18(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Set a pipeline connection on port 1 for the right table. This method is equivalent
		/// to SetInputConnection(1, source).
		/// </summary>
		// Token: 0x060171A7 RID: 94631 RVA: 0x002070A0 File Offset: 0x002052A0
		public void SetSourceConnection(vtkAlgorithmOutput source)
		{
			vtkJoinTables.vtkJoinTables_SetSourceConnection_18(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x060171A8 RID: 94632
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJoinTables_SetSourceData_19(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify input data on port 1 for the right table. This method is equivalent
		/// to SetInputData(1, source).
		/// </summary>
		// Token: 0x060171A9 RID: 94633 RVA: 0x002070D0 File Offset: 0x002052D0
		public void SetSourceData(vtkTable source)
		{
			vtkJoinTables.vtkJoinTables_SetSourceData_19(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019CA RID: 6602
		public new const string MRFullTypeName = "Kitware.VTK.vtkJoinTables";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019CB RID: 6603
		public new static readonly string MRClassNameKey = "class vtkJoinTables";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020008B3 RID: 2227
		public enum JoinMode
		{
			/// <summary>enum member</summary>
			// Token: 0x040019CD RID: 6605
			INTERSECTION,
			/// <summary>enum member</summary>
			// Token: 0x040019CE RID: 6606
			LEFT = 2,
			/// <summary>enum member</summary>
			// Token: 0x040019CF RID: 6607
			RIGHT,
			/// <summary>enum member</summary>
			// Token: 0x040019D0 RID: 6608
			UNION = 1
		}
	}
}
