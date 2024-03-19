using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMergeTables
	/// </summary>
	/// <remarks>
	///    combine two tables
	///
	///
	/// Combines the columns of two tables into one larger table.
	/// The number of rows in the resulting table is the sum of the number of
	/// rows in each of the input tables.
	/// The number of columns in the output is generally the sum of the number
	/// of columns in each input table, except in the case where column names
	/// are duplicated in both tables.
	/// In this case, if MergeColumnsByName is on (the default), the two columns
	/// will be merged into a single column of the same name.
	/// If MergeColumnsByName is off, both columns will exist in the output.
	/// You may set the FirstTablePrefix and SecondTablePrefix to define how
	/// the columns named are modified.  One of these prefixes may be the empty
	/// string, but they must be different.
	/// </remarks>
	// Token: 0x02000685 RID: 1669
	public class vtkMergeTables : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011ED9 RID: 73433 RVA: 0x001917D9 File Offset: 0x0018F9D9
		static vtkMergeTables()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergeTables.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeTables"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011EDA RID: 73434 RVA: 0x00191801 File Offset: 0x0018FA01
		public vtkMergeTables(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011EDB RID: 73435
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeTables_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EDC RID: 73436 RVA: 0x00191810 File Offset: 0x0018FA10
		public new static vtkMergeTables New()
		{
			vtkMergeTables result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeTables.vtkMergeTables_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeTables)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EDD RID: 73437 RVA: 0x00191864 File Offset: 0x0018FA64
		public vtkMergeTables() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMergeTables.vtkMergeTables_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011EDE RID: 73438 RVA: 0x001918A8 File Offset: 0x0018FAA8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011EDF RID: 73439
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeTables_GetFirstTablePrefix_01(HandleRef pThis);

		/// <summary>
		/// The prefix to give to same-named fields from the first table.
		/// Default is "Table1.".
		/// </summary>
		// Token: 0x06011EE0 RID: 73440 RVA: 0x001918B4 File Offset: 0x0018FAB4
		public virtual string GetFirstTablePrefix()
		{
			string s = Marshal.PtrToStringAnsi(vtkMergeTables.vtkMergeTables_GetFirstTablePrefix_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011EE1 RID: 73441
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMergeTables_GetMergeColumnsByName_02(HandleRef pThis);

		/// <summary>
		/// If on, merges columns with the same name.
		/// If off, keeps both columns, but calls one
		/// FirstTablePrefix + name, and the other SecondTablePrefix + name.
		/// Default is on.
		/// </summary>
		// Token: 0x06011EE2 RID: 73442 RVA: 0x001918F0 File Offset: 0x0018FAF0
		public virtual bool GetMergeColumnsByName()
		{
			return vtkMergeTables.vtkMergeTables_GetMergeColumnsByName_02(base.GetCppThis()) != 0;
		}

		// Token: 0x06011EE3 RID: 73443
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeTables_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EE4 RID: 73444 RVA: 0x00191918 File Offset: 0x0018FB18
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMergeTables.vtkMergeTables_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06011EE5 RID: 73445
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeTables_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EE6 RID: 73446 RVA: 0x00191938 File Offset: 0x0018FB38
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMergeTables.vtkMergeTables_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06011EE7 RID: 73447
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMergeTables_GetPrefixAllButMerged_05(HandleRef pThis);

		/// <summary>
		/// If on, all columns will have prefixes except merged columns.
		/// If off, only unmerged columns with the same name will have prefixes.
		/// Default is off.
		/// </summary>
		// Token: 0x06011EE8 RID: 73448 RVA: 0x00191954 File Offset: 0x0018FB54
		public virtual bool GetPrefixAllButMerged()
		{
			return vtkMergeTables.vtkMergeTables_GetPrefixAllButMerged_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06011EE9 RID: 73449
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeTables_GetSecondTablePrefix_06(HandleRef pThis);

		/// <summary>
		/// The prefix to give to same-named fields from the second table.
		/// Default is "Table2.".
		/// </summary>
		// Token: 0x06011EEA RID: 73450 RVA: 0x0019197C File Offset: 0x0018FB7C
		public virtual string GetSecondTablePrefix()
		{
			string s = Marshal.PtrToStringAnsi(vtkMergeTables.vtkMergeTables_GetSecondTablePrefix_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011EEB RID: 73451
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeTables_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EEC RID: 73452 RVA: 0x001919B8 File Offset: 0x0018FBB8
		public override int IsA(string type)
		{
			return vtkMergeTables.vtkMergeTables_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06011EED RID: 73453
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeTables_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EEE RID: 73454 RVA: 0x001919D8 File Offset: 0x0018FBD8
		public new static int IsTypeOf(string type)
		{
			return vtkMergeTables.vtkMergeTables_IsTypeOf_08(type);
		}

		// Token: 0x06011EEF RID: 73455
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeTables_MergeColumnsByNameOff_09(HandleRef pThis);

		/// <summary>
		/// If on, merges columns with the same name.
		/// If off, keeps both columns, but calls one
		/// FirstTablePrefix + name, and the other SecondTablePrefix + name.
		/// Default is on.
		/// </summary>
		// Token: 0x06011EF0 RID: 73456 RVA: 0x001919F2 File Offset: 0x0018FBF2
		public virtual void MergeColumnsByNameOff()
		{
			vtkMergeTables.vtkMergeTables_MergeColumnsByNameOff_09(base.GetCppThis());
		}

		// Token: 0x06011EF1 RID: 73457
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeTables_MergeColumnsByNameOn_10(HandleRef pThis);

		/// <summary>
		/// If on, merges columns with the same name.
		/// If off, keeps both columns, but calls one
		/// FirstTablePrefix + name, and the other SecondTablePrefix + name.
		/// Default is on.
		/// </summary>
		// Token: 0x06011EF2 RID: 73458 RVA: 0x00191A01 File Offset: 0x0018FC01
		public virtual void MergeColumnsByNameOn()
		{
			vtkMergeTables.vtkMergeTables_MergeColumnsByNameOn_10(base.GetCppThis());
		}

		// Token: 0x06011EF3 RID: 73459
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeTables_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EF4 RID: 73460 RVA: 0x00191A10 File Offset: 0x0018FC10
		public new vtkMergeTables NewInstance()
		{
			vtkMergeTables result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeTables.vtkMergeTables_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeTables)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011EF5 RID: 73461
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeTables_PrefixAllButMergedOff_13(HandleRef pThis);

		/// <summary>
		/// If on, all columns will have prefixes except merged columns.
		/// If off, only unmerged columns with the same name will have prefixes.
		/// Default is off.
		/// </summary>
		// Token: 0x06011EF6 RID: 73462 RVA: 0x00191A6A File Offset: 0x0018FC6A
		public virtual void PrefixAllButMergedOff()
		{
			vtkMergeTables.vtkMergeTables_PrefixAllButMergedOff_13(base.GetCppThis());
		}

		// Token: 0x06011EF7 RID: 73463
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeTables_PrefixAllButMergedOn_14(HandleRef pThis);

		/// <summary>
		/// If on, all columns will have prefixes except merged columns.
		/// If off, only unmerged columns with the same name will have prefixes.
		/// Default is off.
		/// </summary>
		// Token: 0x06011EF8 RID: 73464 RVA: 0x00191A79 File Offset: 0x0018FC79
		public virtual void PrefixAllButMergedOn()
		{
			vtkMergeTables.vtkMergeTables_PrefixAllButMergedOn_14(base.GetCppThis());
		}

		// Token: 0x06011EF9 RID: 73465
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeTables_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EFA RID: 73466 RVA: 0x00191A88 File Offset: 0x0018FC88
		public new static vtkMergeTables SafeDownCast(vtkObjectBase o)
		{
			vtkMergeTables vtkMergeTables = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeTables.vtkMergeTables_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergeTables = (vtkMergeTables)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergeTables.Register(null);
				}
			}
			return vtkMergeTables;
		}

		// Token: 0x06011EFB RID: 73467
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeTables_SetFirstTablePrefix_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The prefix to give to same-named fields from the first table.
		/// Default is "Table1.".
		/// </summary>
		// Token: 0x06011EFC RID: 73468 RVA: 0x00191B07 File Offset: 0x0018FD07
		public virtual void SetFirstTablePrefix(string _arg)
		{
			vtkMergeTables.vtkMergeTables_SetFirstTablePrefix_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06011EFD RID: 73469
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeTables_SetMergeColumnsByName_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on, merges columns with the same name.
		/// If off, keeps both columns, but calls one
		/// FirstTablePrefix + name, and the other SecondTablePrefix + name.
		/// Default is on.
		/// </summary>
		// Token: 0x06011EFE RID: 73470 RVA: 0x00191B17 File Offset: 0x0018FD17
		public virtual void SetMergeColumnsByName(bool _arg)
		{
			vtkMergeTables.vtkMergeTables_SetMergeColumnsByName_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011EFF RID: 73471
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeTables_SetPrefixAllButMerged_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on, all columns will have prefixes except merged columns.
		/// If off, only unmerged columns with the same name will have prefixes.
		/// Default is off.
		/// </summary>
		// Token: 0x06011F00 RID: 73472 RVA: 0x00191B2F File Offset: 0x0018FD2F
		public virtual void SetPrefixAllButMerged(bool _arg)
		{
			vtkMergeTables.vtkMergeTables_SetPrefixAllButMerged_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011F01 RID: 73473
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeTables_SetSecondTablePrefix_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The prefix to give to same-named fields from the second table.
		/// Default is "Table2.".
		/// </summary>
		// Token: 0x06011F02 RID: 73474 RVA: 0x00191B47 File Offset: 0x0018FD47
		public virtual void SetSecondTablePrefix(string _arg)
		{
			vtkMergeTables.vtkMergeTables_SetSecondTablePrefix_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014B3 RID: 5299
		public new const string MRFullTypeName = "Kitware.VTK.vtkMergeTables";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014B4 RID: 5300
		public new static readonly string MRClassNameKey = "class vtkMergeTables";
	}
}
