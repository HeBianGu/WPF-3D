using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTecplotTableReader
	/// </summary>
	/// <remarks>
	///    reads in Tecplot tabular data
	/// and outputs a vtkTable data structure.
	///
	///
	/// vtkTecplotTableReader is an interface for reading tabulat data in Tecplot
	/// ascii format.
	///
	/// @par Thanks:
	/// Thanks to vtkDelimitedTextReader authors.
	///
	/// </remarks>
	// Token: 0x0200012E RID: 302
	public class vtkTecplotTableReader : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003CC9 RID: 15561 RVA: 0x00058D1C File Offset: 0x00056F1C
		static vtkTecplotTableReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTecplotTableReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTecplotTableReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003CCA RID: 15562 RVA: 0x00058D44 File Offset: 0x00056F44
		public vtkTecplotTableReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003CCB RID: 15563
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTecplotTableReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003CCC RID: 15564 RVA: 0x00058D54 File Offset: 0x00056F54
		public new static vtkTecplotTableReader New()
		{
			vtkTecplotTableReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTecplotTableReader.vtkTecplotTableReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTecplotTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003CCD RID: 15565 RVA: 0x00058DA8 File Offset: 0x00056FA8
		public vtkTecplotTableReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTecplotTableReader.vtkTecplotTableReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003CCE RID: 15566 RVA: 0x00058DEC File Offset: 0x00056FEC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003CCF RID: 15567
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTecplotTableReader_GeneratePedigreeIdsOff_01(HandleRef pThis);

		/// <summary>
		/// If on (default), generates pedigree ids automatically.
		/// If off, assign one of the arrays to be the pedigree id.
		/// </summary>
		// Token: 0x06003CD0 RID: 15568 RVA: 0x00058DF7 File Offset: 0x00056FF7
		public virtual void GeneratePedigreeIdsOff()
		{
			vtkTecplotTableReader.vtkTecplotTableReader_GeneratePedigreeIdsOff_01(base.GetCppThis());
		}

		// Token: 0x06003CD1 RID: 15569
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTecplotTableReader_GeneratePedigreeIdsOn_02(HandleRef pThis);

		/// <summary>
		/// If on (default), generates pedigree ids automatically.
		/// If off, assign one of the arrays to be the pedigree id.
		/// </summary>
		// Token: 0x06003CD2 RID: 15570 RVA: 0x00058E06 File Offset: 0x00057006
		public virtual void GeneratePedigreeIdsOn()
		{
			vtkTecplotTableReader.vtkTecplotTableReader_GeneratePedigreeIdsOn_02(base.GetCppThis());
		}

		// Token: 0x06003CD3 RID: 15571
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTecplotTableReader_GetColumnNamesOnLine_03(HandleRef pThis);

		/// <summary>
		/// Specifies the line number that holds the column names. Default is 1.
		/// </summary>
		// Token: 0x06003CD4 RID: 15572 RVA: 0x00058E18 File Offset: 0x00057018
		public virtual long GetColumnNamesOnLine()
		{
			return vtkTecplotTableReader.vtkTecplotTableReader_GetColumnNamesOnLine_03(base.GetCppThis());
		}

		// Token: 0x06003CD5 RID: 15573
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTecplotTableReader_GetFileName_04(HandleRef pThis);

		/// <summary>
		/// Specifies the delimited text file to be loaded.
		/// </summary>
		// Token: 0x06003CD6 RID: 15574 RVA: 0x00058E38 File Offset: 0x00057038
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTecplotTableReader.vtkTecplotTableReader_GetFileName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003CD7 RID: 15575
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTecplotTableReader_GetGeneratePedigreeIds_05(HandleRef pThis);

		/// <summary>
		/// If on (default), generates pedigree ids automatically.
		/// If off, assign one of the arrays to be the pedigree id.
		/// </summary>
		// Token: 0x06003CD8 RID: 15576 RVA: 0x00058E74 File Offset: 0x00057074
		public virtual bool GetGeneratePedigreeIds()
		{
			return vtkTecplotTableReader.vtkTecplotTableReader_GetGeneratePedigreeIds_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06003CD9 RID: 15577
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTecplotTableReader_GetHeaderLines_06(HandleRef pThis);

		/// <summary>
		/// Specifies the number of lines that form the header of the file. Default is 2.
		/// </summary>
		// Token: 0x06003CDA RID: 15578 RVA: 0x00058E9C File Offset: 0x0005709C
		public virtual long GetHeaderLines()
		{
			return vtkTecplotTableReader.vtkTecplotTableReader_GetHeaderLines_06(base.GetCppThis());
		}

		// Token: 0x06003CDB RID: 15579
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkTecplotTableReader_GetLastError_07(HandleRef pThis);

		/// <summary>
		/// Returns a human-readable description of the most recent error, if any.
		/// Otherwise, returns an empty string.  Note that the result is only valid
		/// after calling Update().
		/// </summary>
		// Token: 0x06003CDC RID: 15580 RVA: 0x00058EBC File Offset: 0x000570BC
		public string GetLastError()
		{
			return vtkTecplotTableReader.vtkTecplotTableReader_GetLastError_07(base.GetCppThis());
		}

		// Token: 0x06003CDD RID: 15581
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTecplotTableReader_GetMaxRecords_08(HandleRef pThis);

		/// <summary>
		/// Specifies the maximum number of records to read from the file.  Limiting the
		/// number of records to read is useful for previewing the contents of a file.
		/// </summary>
		// Token: 0x06003CDE RID: 15582 RVA: 0x00058EDC File Offset: 0x000570DC
		public virtual long GetMaxRecords()
		{
			return vtkTecplotTableReader.vtkTecplotTableReader_GetMaxRecords_08(base.GetCppThis());
		}

		// Token: 0x06003CDF RID: 15583
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTecplotTableReader_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003CE0 RID: 15584 RVA: 0x00058EFC File Offset: 0x000570FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTecplotTableReader.vtkTecplotTableReader_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06003CE1 RID: 15585
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTecplotTableReader_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003CE2 RID: 15586 RVA: 0x00058F1C File Offset: 0x0005711C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTecplotTableReader.vtkTecplotTableReader_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06003CE3 RID: 15587
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTecplotTableReader_GetOutputPedigreeIds_11(HandleRef pThis);

		/// <summary>
		/// If on, assigns pedigree ids to output. Defaults to off.
		/// </summary>
		// Token: 0x06003CE4 RID: 15588 RVA: 0x00058F38 File Offset: 0x00057138
		public virtual bool GetOutputPedigreeIds()
		{
			return vtkTecplotTableReader.vtkTecplotTableReader_GetOutputPedigreeIds_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06003CE5 RID: 15589
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTecplotTableReader_GetPedigreeIdArrayName_12(HandleRef pThis);

		/// <summary>
		/// The name of the array for generating or assigning pedigree ids
		/// (default "id").
		/// </summary>
		// Token: 0x06003CE6 RID: 15590 RVA: 0x00058F60 File Offset: 0x00057160
		public virtual string GetPedigreeIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTecplotTableReader.vtkTecplotTableReader_GetPedigreeIdArrayName_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003CE7 RID: 15591
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTecplotTableReader_GetSkipColumnNames_13(HandleRef pThis);

		/// <summary>
		/// Specifies the number of fields to skip while reading the column names. Default is 1.
		/// </summary>
		// Token: 0x06003CE8 RID: 15592 RVA: 0x00058F9C File Offset: 0x0005719C
		public virtual long GetSkipColumnNames()
		{
			return vtkTecplotTableReader.vtkTecplotTableReader_GetSkipColumnNames_13(base.GetCppThis());
		}

		// Token: 0x06003CE9 RID: 15593
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTecplotTableReader_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003CEA RID: 15594 RVA: 0x00058FBC File Offset: 0x000571BC
		public override int IsA(string type)
		{
			return vtkTecplotTableReader.vtkTecplotTableReader_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06003CEB RID: 15595
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTecplotTableReader_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003CEC RID: 15596 RVA: 0x00058FDC File Offset: 0x000571DC
		public new static int IsTypeOf(string type)
		{
			return vtkTecplotTableReader.vtkTecplotTableReader_IsTypeOf_15(type);
		}

		// Token: 0x06003CED RID: 15597
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTecplotTableReader_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003CEE RID: 15598 RVA: 0x00058FF8 File Offset: 0x000571F8
		public new vtkTecplotTableReader NewInstance()
		{
			vtkTecplotTableReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTecplotTableReader.vtkTecplotTableReader_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTecplotTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003CEF RID: 15599
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTecplotTableReader_OutputPedigreeIdsOff_18(HandleRef pThis);

		/// <summary>
		/// If on, assigns pedigree ids to output. Defaults to off.
		/// </summary>
		// Token: 0x06003CF0 RID: 15600 RVA: 0x00059052 File Offset: 0x00057252
		public virtual void OutputPedigreeIdsOff()
		{
			vtkTecplotTableReader.vtkTecplotTableReader_OutputPedigreeIdsOff_18(base.GetCppThis());
		}

		// Token: 0x06003CF1 RID: 15601
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTecplotTableReader_OutputPedigreeIdsOn_19(HandleRef pThis);

		/// <summary>
		/// If on, assigns pedigree ids to output. Defaults to off.
		/// </summary>
		// Token: 0x06003CF2 RID: 15602 RVA: 0x00059061 File Offset: 0x00057261
		public virtual void OutputPedigreeIdsOn()
		{
			vtkTecplotTableReader.vtkTecplotTableReader_OutputPedigreeIdsOn_19(base.GetCppThis());
		}

		// Token: 0x06003CF3 RID: 15603
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTecplotTableReader_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003CF4 RID: 15604 RVA: 0x00059070 File Offset: 0x00057270
		public new static vtkTecplotTableReader SafeDownCast(vtkObjectBase o)
		{
			vtkTecplotTableReader vtkTecplotTableReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTecplotTableReader.vtkTecplotTableReader_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTecplotTableReader = (vtkTecplotTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTecplotTableReader.Register(null);
				}
			}
			return vtkTecplotTableReader;
		}

		// Token: 0x06003CF5 RID: 15605
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTecplotTableReader_SetColumnNamesOnLine_21(HandleRef pThis, long _arg);

		/// <summary>
		/// Specifies the line number that holds the column names. Default is 1.
		/// </summary>
		// Token: 0x06003CF6 RID: 15606 RVA: 0x000590EF File Offset: 0x000572EF
		public virtual void SetColumnNamesOnLine(long _arg)
		{
			vtkTecplotTableReader.vtkTecplotTableReader_SetColumnNamesOnLine_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06003CF7 RID: 15607
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTecplotTableReader_SetFileName_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specifies the delimited text file to be loaded.
		/// </summary>
		// Token: 0x06003CF8 RID: 15608 RVA: 0x000590FF File Offset: 0x000572FF
		public virtual void SetFileName(string _arg)
		{
			vtkTecplotTableReader.vtkTecplotTableReader_SetFileName_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06003CF9 RID: 15609
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTecplotTableReader_SetGeneratePedigreeIds_23(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on (default), generates pedigree ids automatically.
		/// If off, assign one of the arrays to be the pedigree id.
		/// </summary>
		// Token: 0x06003CFA RID: 15610 RVA: 0x0005910F File Offset: 0x0005730F
		public virtual void SetGeneratePedigreeIds(bool _arg)
		{
			vtkTecplotTableReader.vtkTecplotTableReader_SetGeneratePedigreeIds_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06003CFB RID: 15611
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTecplotTableReader_SetHeaderLines_24(HandleRef pThis, long _arg);

		/// <summary>
		/// Specifies the number of lines that form the header of the file. Default is 2.
		/// </summary>
		// Token: 0x06003CFC RID: 15612 RVA: 0x00059127 File Offset: 0x00057327
		public virtual void SetHeaderLines(long _arg)
		{
			vtkTecplotTableReader.vtkTecplotTableReader_SetHeaderLines_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06003CFD RID: 15613
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTecplotTableReader_SetMaxRecords_25(HandleRef pThis, long _arg);

		/// <summary>
		/// Specifies the maximum number of records to read from the file.  Limiting the
		/// number of records to read is useful for previewing the contents of a file.
		/// </summary>
		// Token: 0x06003CFE RID: 15614 RVA: 0x00059137 File Offset: 0x00057337
		public virtual void SetMaxRecords(long _arg)
		{
			vtkTecplotTableReader.vtkTecplotTableReader_SetMaxRecords_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06003CFF RID: 15615
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTecplotTableReader_SetOutputPedigreeIds_26(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on, assigns pedigree ids to output. Defaults to off.
		/// </summary>
		// Token: 0x06003D00 RID: 15616 RVA: 0x00059147 File Offset: 0x00057347
		public virtual void SetOutputPedigreeIds(bool _arg)
		{
			vtkTecplotTableReader.vtkTecplotTableReader_SetOutputPedigreeIds_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06003D01 RID: 15617
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTecplotTableReader_SetPedigreeIdArrayName_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the array for generating or assigning pedigree ids
		/// (default "id").
		/// </summary>
		// Token: 0x06003D02 RID: 15618 RVA: 0x0005915F File Offset: 0x0005735F
		public virtual void SetPedigreeIdArrayName(string _arg)
		{
			vtkTecplotTableReader.vtkTecplotTableReader_SetPedigreeIdArrayName_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06003D03 RID: 15619
		[DllImport("Kitware.VTK.IOTecplotTable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTecplotTableReader_SetSkipColumnNames_28(HandleRef pThis, long _arg);

		/// <summary>
		/// Specifies the number of fields to skip while reading the column names. Default is 1.
		/// </summary>
		// Token: 0x06003D04 RID: 15620 RVA: 0x0005916F File Offset: 0x0005736F
		public virtual void SetSkipColumnNames(long _arg)
		{
			vtkTecplotTableReader.vtkTecplotTableReader_SetSkipColumnNames_28(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000695 RID: 1685
		public new const string MRFullTypeName = "Kitware.VTK.vtkTecplotTableReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000696 RID: 1686
		public new static readonly string MRClassNameKey = "class vtkTecplotTableReader";
	}
}
