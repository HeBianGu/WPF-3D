using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDelimitedTextReader
	/// </summary>
	/// <remarks>
	///    reads in delimited ascii or unicode text files
	/// and outputs a vtkTable data structure.
	///
	///
	/// vtkDelimitedTextReader is an interface for pulling in data from a
	/// flat, delimited ascii or unicode text file (delimiter can be any character).
	///
	/// The behavior of the reader with respect to ascii or unicode input
	/// is controlled by the SetUnicodeCharacterSet() method.  By default
	/// (without calling SetUnicodeCharacterSet()), the reader will expect
	/// to read ascii text and will output vtkStdString columns.  Use the
	/// Set and Get methods to set delimiters that do not contain UTF8 in
	/// the name when operating the reader in default ascii mode.  If the
	/// SetUnicodeCharacterSet() method is called, the reader will output
	/// vtkStdString columns in the output table.  In addition, it is
	/// necessary to use the Set and Get methods that contain UTF8 in the
	/// name to specify delimiters when operating in unicode mode.
	///
	/// There is also a special character set US-ASCII-WITH-FALLBACK that
	/// will treat the input text as ASCII no matter what.  If and when it
	/// encounters a character with its 8th bit set it will replace that
	/// character with the code point ReplacementCharacter.  You may use
	/// this if you have text that belongs to a code page like LATIN9 or
	/// ISO-8859-1 or friends: mostly ASCII but not entirely.  Eventually
	/// this class will acquire the ability to read gracefully text from
	/// any code page, making this option obsolete.
	///
	/// This class emits ProgressEvent for every 100 lines it reads.
	///
	/// @par Thanks:
	/// Thanks to Andy Wilson, Brian Wylie, Tim Shead, and Thomas Otahal
	/// from Sandia National Laboratories for implementing this class.
	///
	///
	/// @warning
	/// This reader assumes that the first line in the file (whether that's
	/// headers or the first document) contains at least as many fields as
	/// any other line in the file.
	/// </remarks>
	// Token: 0x02000198 RID: 408
	public class vtkDelimitedTextReader : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004FC3 RID: 20419 RVA: 0x00074037 File Offset: 0x00072237
		static vtkDelimitedTextReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDelimitedTextReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDelimitedTextReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004FC4 RID: 20420 RVA: 0x0007405F File Offset: 0x0007225F
		public vtkDelimitedTextReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004FC5 RID: 20421
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004FC6 RID: 20422 RVA: 0x00074070 File Offset: 0x00072270
		public new static vtkDelimitedTextReader New()
		{
			vtkDelimitedTextReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDelimitedTextReader.vtkDelimitedTextReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDelimitedTextReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004FC7 RID: 20423 RVA: 0x000740C4 File Offset: 0x000722C4
		public vtkDelimitedTextReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDelimitedTextReader.vtkDelimitedTextReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004FC8 RID: 20424 RVA: 0x00074108 File Offset: 0x00072308
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004FC9 RID: 20425
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_AddTabFieldDelimiterOff_01(HandleRef pThis);

		/// <summary>
		/// If on, also add in the tab (i.e. \c '\\t') character as a field delimiter.
		/// We add this specially since applications may have a more
		/// difficult time doing this. Defaults to off.
		/// </summary>
		// Token: 0x06004FCA RID: 20426 RVA: 0x00074113 File Offset: 0x00072313
		public virtual void AddTabFieldDelimiterOff()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_AddTabFieldDelimiterOff_01(base.GetCppThis());
		}

		// Token: 0x06004FCB RID: 20427
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_AddTabFieldDelimiterOn_02(HandleRef pThis);

		/// <summary>
		/// If on, also add in the tab (i.e. \c '\\t') character as a field delimiter.
		/// We add this specially since applications may have a more
		/// difficult time doing this. Defaults to off.
		/// </summary>
		// Token: 0x06004FCC RID: 20428 RVA: 0x00074122 File Offset: 0x00072322
		public virtual void AddTabFieldDelimiterOn()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_AddTabFieldDelimiterOn_02(base.GetCppThis());
		}

		// Token: 0x06004FCD RID: 20429
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_DetectNumericColumnsOff_03(HandleRef pThis);

		/// <summary>
		/// When set to true, the reader will detect numeric columns and create
		/// vtkDoubleArray or vtkIntArray for those instead of vtkStringArray. Default
		/// is off.
		/// </summary>
		// Token: 0x06004FCE RID: 20430 RVA: 0x00074131 File Offset: 0x00072331
		public virtual void DetectNumericColumnsOff()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_DetectNumericColumnsOff_03(base.GetCppThis());
		}

		// Token: 0x06004FCF RID: 20431
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_DetectNumericColumnsOn_04(HandleRef pThis);

		/// <summary>
		/// When set to true, the reader will detect numeric columns and create
		/// vtkDoubleArray or vtkIntArray for those instead of vtkStringArray. Default
		/// is off.
		/// </summary>
		// Token: 0x06004FD0 RID: 20432 RVA: 0x00074140 File Offset: 0x00072340
		public virtual void DetectNumericColumnsOn()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_DetectNumericColumnsOn_04(base.GetCppThis());
		}

		// Token: 0x06004FD1 RID: 20433
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_ForceDoubleOff_05(HandleRef pThis);

		/// <summary>
		/// When set to true and DetectNumericColumns is also true, forces all
		/// numeric columns to vtkDoubleArray even if they contain only
		/// integer values. Default is off.
		/// </summary>
		// Token: 0x06004FD2 RID: 20434 RVA: 0x0007414F File Offset: 0x0007234F
		public virtual void ForceDoubleOff()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_ForceDoubleOff_05(base.GetCppThis());
		}

		// Token: 0x06004FD3 RID: 20435
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_ForceDoubleOn_06(HandleRef pThis);

		/// <summary>
		/// When set to true and DetectNumericColumns is also true, forces all
		/// numeric columns to vtkDoubleArray even if they contain only
		/// integer values. Default is off.
		/// </summary>
		// Token: 0x06004FD4 RID: 20436 RVA: 0x0007415E File Offset: 0x0007235E
		public virtual void ForceDoubleOn()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_ForceDoubleOn_06(base.GetCppThis());
		}

		// Token: 0x06004FD5 RID: 20437
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_GeneratePedigreeIdsOff_07(HandleRef pThis);

		/// <summary>
		/// If on (default), generates pedigree ids automatically.
		/// If off, assign one of the arrays to be the pedigree id.
		/// </summary>
		// Token: 0x06004FD6 RID: 20438 RVA: 0x0007416D File Offset: 0x0007236D
		public virtual void GeneratePedigreeIdsOff()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_GeneratePedigreeIdsOff_07(base.GetCppThis());
		}

		// Token: 0x06004FD7 RID: 20439
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_GeneratePedigreeIdsOn_08(HandleRef pThis);

		/// <summary>
		/// If on (default), generates pedigree ids automatically.
		/// If off, assign one of the arrays to be the pedigree id.
		/// </summary>
		// Token: 0x06004FD8 RID: 20440 RVA: 0x0007417C File Offset: 0x0007237C
		public virtual void GeneratePedigreeIdsOn()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_GeneratePedigreeIdsOn_08(base.GetCppThis());
		}

		// Token: 0x06004FD9 RID: 20441
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDelimitedTextReader_GetAddTabFieldDelimiter_09(HandleRef pThis);

		/// <summary>
		/// If on, also add in the tab (i.e. \c '\\t') character as a field delimiter.
		/// We add this specially since applications may have a more
		/// difficult time doing this. Defaults to off.
		/// </summary>
		// Token: 0x06004FDA RID: 20442 RVA: 0x0007418C File Offset: 0x0007238C
		public virtual bool GetAddTabFieldDelimiter()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetAddTabFieldDelimiter_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06004FDB RID: 20443
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelimitedTextReader_GetDefaultDoubleValue_10(HandleRef pThis);

		/// <summary>
		/// When DetectNumericColumns is set to true, the reader use this value to populate
		/// the vtkDoubleArray where empty strings are found. Default is 0.0
		/// </summary>
		// Token: 0x06004FDC RID: 20444 RVA: 0x000741B4 File Offset: 0x000723B4
		public virtual double GetDefaultDoubleValue()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetDefaultDoubleValue_10(base.GetCppThis());
		}

		// Token: 0x06004FDD RID: 20445
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelimitedTextReader_GetDefaultIntegerValue_11(HandleRef pThis);

		/// <summary>
		/// When DetectNumericColumns is set to true, the reader use this value to populate
		/// the vtkIntArray where empty strings are found. Default is 0.
		/// </summary>
		// Token: 0x06004FDE RID: 20446 RVA: 0x000741D4 File Offset: 0x000723D4
		public virtual int GetDefaultIntegerValue()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetDefaultIntegerValue_11(base.GetCppThis());
		}

		// Token: 0x06004FDF RID: 20447
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDelimitedTextReader_GetDetectNumericColumns_12(HandleRef pThis);

		/// <summary>
		/// When set to true, the reader will detect numeric columns and create
		/// vtkDoubleArray or vtkIntArray for those instead of vtkStringArray. Default
		/// is off.
		/// </summary>
		// Token: 0x06004FE0 RID: 20448 RVA: 0x000741F4 File Offset: 0x000723F4
		public virtual bool GetDetectNumericColumns()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetDetectNumericColumns_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06004FE1 RID: 20449
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextReader_GetFieldDelimiterCharacters_13(HandleRef pThis);

		/// <summary>
		/// Specify the character(s) that will be used to separate fields.  For
		/// example, set this to "," for a comma-separated value file.  Set
		/// it to ".:;" for a file where columns can be separated by a
		/// period, colon or semicolon.  The order of the characters in the
		/// string does not matter.  Defaults to a comma.
		/// </summary>
		// Token: 0x06004FE2 RID: 20450 RVA: 0x0007421C File Offset: 0x0007241C
		public virtual string GetFieldDelimiterCharacters()
		{
			string s = Marshal.PtrToStringAnsi(vtkDelimitedTextReader.vtkDelimitedTextReader_GetFieldDelimiterCharacters_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004FE3 RID: 20451
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextReader_GetFileName_14(HandleRef pThis);

		/// <summary>
		/// Specifies the delimited text file to be loaded.
		/// </summary>
		// Token: 0x06004FE4 RID: 20452 RVA: 0x00074258 File Offset: 0x00072458
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDelimitedTextReader.vtkDelimitedTextReader_GetFileName_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004FE5 RID: 20453
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDelimitedTextReader_GetForceDouble_15(HandleRef pThis);

		/// <summary>
		/// When set to true and DetectNumericColumns is also true, forces all
		/// numeric columns to vtkDoubleArray even if they contain only
		/// integer values. Default is off.
		/// </summary>
		// Token: 0x06004FE6 RID: 20454 RVA: 0x00074294 File Offset: 0x00072494
		public virtual bool GetForceDouble()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetForceDouble_15(base.GetCppThis()) != 0;
		}

		// Token: 0x06004FE7 RID: 20455
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDelimitedTextReader_GetGeneratePedigreeIds_16(HandleRef pThis);

		/// <summary>
		/// If on (default), generates pedigree ids automatically.
		/// If off, assign one of the arrays to be the pedigree id.
		/// </summary>
		// Token: 0x06004FE8 RID: 20456 RVA: 0x000742BC File Offset: 0x000724BC
		public virtual bool GetGeneratePedigreeIds()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetGeneratePedigreeIds_16(base.GetCppThis()) != 0;
		}

		// Token: 0x06004FE9 RID: 20457
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDelimitedTextReader_GetHaveHeaders_17(HandleRef pThis);

		/// <summary>
		/// Set/get whether to treat the first line of the file as headers.
		/// The default is false (no headers).
		/// </summary>
		// Token: 0x06004FEA RID: 20458 RVA: 0x000742E4 File Offset: 0x000724E4
		public virtual bool GetHaveHeaders()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetHaveHeaders_17(base.GetCppThis()) != 0;
		}

		// Token: 0x06004FEB RID: 20459
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextReader_GetInputString_18(HandleRef pThis);

		/// <summary>
		/// Specify the InputString for use when reading from a character array.
		/// Optionally include the length for binary strings. Note that a copy
		/// of the string is made and stored. If this causes exceedingly large
		/// memory consumption, consider using InputArray instead.
		/// </summary>
		// Token: 0x06004FEC RID: 20460 RVA: 0x0007430C File Offset: 0x0007250C
		public virtual string GetInputString()
		{
			string s = Marshal.PtrToStringAnsi(vtkDelimitedTextReader.vtkDelimitedTextReader_GetInputString_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004FED RID: 20461
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelimitedTextReader_GetInputStringLength_19(HandleRef pThis);

		/// <summary>
		/// Specify the InputString for use when reading from a character array.
		/// Optionally include the length for binary strings. Note that a copy
		/// of the string is made and stored. If this causes exceedingly large
		/// memory consumption, consider using InputArray instead.
		/// </summary>
		// Token: 0x06004FEE RID: 20462 RVA: 0x00074348 File Offset: 0x00072548
		public virtual int GetInputStringLength()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetInputStringLength_19(base.GetCppThis());
		}

		// Token: 0x06004FEF RID: 20463
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDelimitedTextReader_GetLastError_20(HandleRef pThis);

		/// <summary>
		/// Returns a human-readable description of the most recent error, if any.
		/// Otherwise, returns an empty string.  Note that the result is only valid
		/// after calling Update().
		/// </summary>
		// Token: 0x06004FF0 RID: 20464 RVA: 0x00074368 File Offset: 0x00072568
		public string GetLastError()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetLastError_20(base.GetCppThis());
		}

		// Token: 0x06004FF1 RID: 20465
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDelimitedTextReader_GetMaxRecords_21(HandleRef pThis);

		/// <summary>
		/// Specifies the maximum number of records to read from the file.  Limiting the
		/// number of records to read is useful for previewing the contents of a file.
		/// </summary>
		// Token: 0x06004FF2 RID: 20466 RVA: 0x00074388 File Offset: 0x00072588
		public virtual long GetMaxRecords()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetMaxRecords_21(base.GetCppThis());
		}

		// Token: 0x06004FF3 RID: 20467
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDelimitedTextReader_GetMergeConsecutiveDelimiters_22(HandleRef pThis);

		/// <summary>
		/// Set/get whether to merge successive delimiters.  Use this if (for
		/// example) your fields are separated by spaces but you don't know
		/// exactly how many.
		/// </summary>
		// Token: 0x06004FF4 RID: 20468 RVA: 0x000743A8 File Offset: 0x000725A8
		public virtual bool GetMergeConsecutiveDelimiters()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetMergeConsecutiveDelimiters_22(base.GetCppThis()) != 0;
		}

		// Token: 0x06004FF5 RID: 20469
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDelimitedTextReader_GetNumberOfGenerationsFromBase_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004FF6 RID: 20470 RVA: 0x000743D0 File Offset: 0x000725D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetNumberOfGenerationsFromBase_23(base.GetCppThis(), type);
		}

		// Token: 0x06004FF7 RID: 20471
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDelimitedTextReader_GetNumberOfGenerationsFromBaseType_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004FF8 RID: 20472 RVA: 0x000743F0 File Offset: 0x000725F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetNumberOfGenerationsFromBaseType_24(type);
		}

		// Token: 0x06004FF9 RID: 20473
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDelimitedTextReader_GetOutputPedigreeIds_25(HandleRef pThis);

		/// <summary>
		/// If on, assigns pedigree ids to output. Defaults to off.
		/// </summary>
		// Token: 0x06004FFA RID: 20474 RVA: 0x0007440C File Offset: 0x0007260C
		public virtual bool GetOutputPedigreeIds()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetOutputPedigreeIds_25(base.GetCppThis()) != 0;
		}

		// Token: 0x06004FFB RID: 20475
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextReader_GetPedigreeIdArrayName_26(HandleRef pThis);

		/// <summary>
		/// The name of the array for generating or assigning pedigree ids
		/// (default "id").
		/// </summary>
		// Token: 0x06004FFC RID: 20476 RVA: 0x00074434 File Offset: 0x00072634
		public virtual string GetPedigreeIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDelimitedTextReader.vtkDelimitedTextReader_GetPedigreeIdArrayName_26(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004FFD RID: 20477
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelimitedTextReader_GetReadFromInputString_27(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputString or InputArray instead of the default,
		/// a file.
		/// </summary>
		// Token: 0x06004FFE RID: 20478 RVA: 0x00074470 File Offset: 0x00072670
		public virtual int GetReadFromInputString()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetReadFromInputString_27(base.GetCppThis());
		}

		// Token: 0x06004FFF RID: 20479
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDelimitedTextReader_GetReplacementCharacter_28(HandleRef pThis);

		/// <summary>
		/// Fallback character for use in the US-ASCII-WITH-FALLBACK
		/// character set.  Any characters that have their 8th bit set will
		/// be replaced with this code point.  Defaults to 'x'.
		/// </summary>
		// Token: 0x06005000 RID: 20480 RVA: 0x00074490 File Offset: 0x00072690
		public virtual uint GetReplacementCharacter()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetReplacementCharacter_28(base.GetCppThis());
		}

		// Token: 0x06005001 RID: 20481
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkDelimitedTextReader_GetStringDelimiter_29(HandleRef pThis);

		/// <summary>
		/// Get/set the character that will begin and end strings.  Microsoft
		/// Excel, for example, will export the following format:
		///
		/// "First Field","Second Field","Field, With, Commas","Fourth Field"
		///
		/// The third field has a comma in it.  By using a string delimiter,
		/// this will be correctly read.  The delimiter defaults to '"'.
		/// </summary>
		// Token: 0x06005002 RID: 20482 RVA: 0x000744B0 File Offset: 0x000726B0
		public virtual sbyte GetStringDelimiter()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetStringDelimiter_29(base.GetCppThis());
		}

		// Token: 0x06005003 RID: 20483
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDelimitedTextReader_GetTrimWhitespacePriorToNumericConversion_30(HandleRef pThis);

		/// <summary>
		/// When DetectNumericColumns is set to true, whether to trim whitespace from
		/// strings prior to conversion to a numeric.
		/// Default is false to preserve backward compatibility.
		///
		/// vtkVariant handles whitespace inconsistently, so trim it before we try to
		/// convert it.  For example:
		///
		/// vtkVariant("  2.0").ToDouble() == 2.0 &lt;-- leading whitespace is not a problem
		/// vtkVariant("  2.0  ").ToDouble() == NaN &lt;-- trailing whitespace is a problem
		/// vtkVariant("  infinity  ").ToDouble() == NaN &lt;-- any whitespace is a problem
		///
		/// In these cases, trimming the whitespace gives us the result we expect:
		/// 2.0 and INF respectively.
		/// </summary>
		// Token: 0x06005004 RID: 20484 RVA: 0x000744D0 File Offset: 0x000726D0
		public virtual bool GetTrimWhitespacePriorToNumericConversion()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetTrimWhitespacePriorToNumericConversion_30(base.GetCppThis()) != 0;
		}

		// Token: 0x06005005 RID: 20485
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextReader_GetUTF8FieldDelimiters_31(HandleRef pThis);

		/// <summary>
		/// Specify the character(s) that will be used to separate fields.  For
		/// example, set this to "," for a comma-separated value file.  Set
		/// it to ".:;" for a file where columns can be separated by a
		/// period, colon or semicolon.  The order of the characters in the
		/// string does not matter.  Defaults to a comma.
		/// </summary>
		// Token: 0x06005006 RID: 20486 RVA: 0x000744F8 File Offset: 0x000726F8
		public string GetUTF8FieldDelimiters()
		{
			string s = Marshal.PtrToStringAnsi(vtkDelimitedTextReader.vtkDelimitedTextReader_GetUTF8FieldDelimiters_31(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005007 RID: 20487
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextReader_GetUTF8RecordDelimiters_32(HandleRef pThis);

		/// <summary>
		/// Specify the character(s) that will be used to separate records.
		/// The order of characters in the string does not matter.  Defaults
		/// to "\r\n".
		/// </summary>
		// Token: 0x06005008 RID: 20488 RVA: 0x00074534 File Offset: 0x00072734
		public string GetUTF8RecordDelimiters()
		{
			string s = Marshal.PtrToStringAnsi(vtkDelimitedTextReader.vtkDelimitedTextReader_GetUTF8RecordDelimiters_32(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005009 RID: 20489
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextReader_GetUTF8StringDelimiters_33(HandleRef pThis);

		/// <summary>
		/// Get/set the character that will begin and end strings.  Microsoft
		/// Excel, for example, will export the following format:
		///
		/// "First Field","Second Field","Field, With, Commas","Fourth Field"
		///
		/// The third field has a comma in it.  By using a string delimiter,
		/// this will be correctly read.  The delimiter defaults to '"'.
		/// </summary>
		// Token: 0x0600500A RID: 20490 RVA: 0x00074570 File Offset: 0x00072770
		public string GetUTF8StringDelimiters()
		{
			string s = Marshal.PtrToStringAnsi(vtkDelimitedTextReader.vtkDelimitedTextReader_GetUTF8StringDelimiters_33(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600500B RID: 20491
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextReader_GetUnicodeCharacterSet_34(HandleRef pThis);

		/// <summary>
		/// Specifies the character set used in the input file.  Valid character set
		/// names will be drawn from the list maintained by the Internet Assigned Name
		/// Authority at
		///
		/// http://www.iana.org/assignments/character-sets
		///
		/// Where multiple aliases are provided for a character set, the preferred MIME name
		/// will be used.  vtkUnicodeDelimitedTextReader currently supports "US-ASCII", "UTF-8",
		/// "UTF-16", "UTF-16BE", and "UTF-16LE" character sets.
		/// </summary>
		// Token: 0x0600500C RID: 20492 RVA: 0x000745AC File Offset: 0x000727AC
		public virtual string GetUnicodeCharacterSet()
		{
			string s = Marshal.PtrToStringAnsi(vtkDelimitedTextReader.vtkDelimitedTextReader_GetUnicodeCharacterSet_34(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600500D RID: 20493
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDelimitedTextReader_GetUseStringDelimiter_35(HandleRef pThis);

		/// <summary>
		/// Set/get whether to use the string delimiter.  Defaults to on.
		/// </summary>
		// Token: 0x0600500E RID: 20494 RVA: 0x000745E8 File Offset: 0x000727E8
		public virtual bool GetUseStringDelimiter()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetUseStringDelimiter_35(base.GetCppThis()) != 0;
		}

		// Token: 0x0600500F RID: 20495
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelimitedTextReader_IsA_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005010 RID: 20496 RVA: 0x00074610 File Offset: 0x00072810
		public override int IsA(string type)
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_IsA_36(base.GetCppThis(), type);
		}

		// Token: 0x06005011 RID: 20497
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelimitedTextReader_IsTypeOf_37([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005012 RID: 20498 RVA: 0x00074630 File Offset: 0x00072830
		public new static int IsTypeOf(string type)
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_IsTypeOf_37(type);
		}

		// Token: 0x06005013 RID: 20499
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_MergeConsecutiveDelimitersOff_38(HandleRef pThis);

		/// <summary>
		/// Set/get whether to merge successive delimiters.  Use this if (for
		/// example) your fields are separated by spaces but you don't know
		/// exactly how many.
		/// </summary>
		// Token: 0x06005014 RID: 20500 RVA: 0x0007464A File Offset: 0x0007284A
		public virtual void MergeConsecutiveDelimitersOff()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_MergeConsecutiveDelimitersOff_38(base.GetCppThis());
		}

		// Token: 0x06005015 RID: 20501
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_MergeConsecutiveDelimitersOn_39(HandleRef pThis);

		/// <summary>
		/// Set/get whether to merge successive delimiters.  Use this if (for
		/// example) your fields are separated by spaces but you don't know
		/// exactly how many.
		/// </summary>
		// Token: 0x06005016 RID: 20502 RVA: 0x00074659 File Offset: 0x00072859
		public virtual void MergeConsecutiveDelimitersOn()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_MergeConsecutiveDelimitersOn_39(base.GetCppThis());
		}

		// Token: 0x06005017 RID: 20503
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextReader_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005018 RID: 20504 RVA: 0x00074668 File Offset: 0x00072868
		public new vtkDelimitedTextReader NewInstance()
		{
			vtkDelimitedTextReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDelimitedTextReader.vtkDelimitedTextReader_NewInstance_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDelimitedTextReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005019 RID: 20505
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_OutputPedigreeIdsOff_42(HandleRef pThis);

		/// <summary>
		/// If on, assigns pedigree ids to output. Defaults to off.
		/// </summary>
		// Token: 0x0600501A RID: 20506 RVA: 0x000746C2 File Offset: 0x000728C2
		public virtual void OutputPedigreeIdsOff()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_OutputPedigreeIdsOff_42(base.GetCppThis());
		}

		// Token: 0x0600501B RID: 20507
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_OutputPedigreeIdsOn_43(HandleRef pThis);

		/// <summary>
		/// If on, assigns pedigree ids to output. Defaults to off.
		/// </summary>
		// Token: 0x0600501C RID: 20508 RVA: 0x000746D1 File Offset: 0x000728D1
		public virtual void OutputPedigreeIdsOn()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_OutputPedigreeIdsOn_43(base.GetCppThis());
		}

		// Token: 0x0600501D RID: 20509
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_ReadFromInputStringOff_44(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputString or InputArray instead of the default,
		/// a file.
		/// </summary>
		// Token: 0x0600501E RID: 20510 RVA: 0x000746E0 File Offset: 0x000728E0
		public virtual void ReadFromInputStringOff()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_ReadFromInputStringOff_44(base.GetCppThis());
		}

		// Token: 0x0600501F RID: 20511
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_ReadFromInputStringOn_45(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputString or InputArray instead of the default,
		/// a file.
		/// </summary>
		// Token: 0x06005020 RID: 20512 RVA: 0x000746EF File Offset: 0x000728EF
		public virtual void ReadFromInputStringOn()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_ReadFromInputStringOn_45(base.GetCppThis());
		}

		// Token: 0x06005021 RID: 20513
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextReader_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005022 RID: 20514 RVA: 0x00074700 File Offset: 0x00072900
		public new static vtkDelimitedTextReader SafeDownCast(vtkObjectBase o)
		{
			vtkDelimitedTextReader vtkDelimitedTextReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDelimitedTextReader.vtkDelimitedTextReader_SafeDownCast_46((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDelimitedTextReader = (vtkDelimitedTextReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDelimitedTextReader.Register(null);
				}
			}
			return vtkDelimitedTextReader;
		}

		// Token: 0x06005023 RID: 20515
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetAddTabFieldDelimiter_47(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on, also add in the tab (i.e. \c '\\t') character as a field delimiter.
		/// We add this specially since applications may have a more
		/// difficult time doing this. Defaults to off.
		/// </summary>
		// Token: 0x06005024 RID: 20516 RVA: 0x0007477F File Offset: 0x0007297F
		public virtual void SetAddTabFieldDelimiter(bool _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetAddTabFieldDelimiter_47(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005025 RID: 20517
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetDefaultDoubleValue_48(HandleRef pThis, double _arg);

		/// <summary>
		/// When DetectNumericColumns is set to true, the reader use this value to populate
		/// the vtkDoubleArray where empty strings are found. Default is 0.0
		/// </summary>
		// Token: 0x06005026 RID: 20518 RVA: 0x00074797 File Offset: 0x00072997
		public virtual void SetDefaultDoubleValue(double _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetDefaultDoubleValue_48(base.GetCppThis(), _arg);
		}

		// Token: 0x06005027 RID: 20519
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetDefaultIntegerValue_49(HandleRef pThis, int _arg);

		/// <summary>
		/// When DetectNumericColumns is set to true, the reader use this value to populate
		/// the vtkIntArray where empty strings are found. Default is 0.
		/// </summary>
		// Token: 0x06005028 RID: 20520 RVA: 0x000747A7 File Offset: 0x000729A7
		public virtual void SetDefaultIntegerValue(int _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetDefaultIntegerValue_49(base.GetCppThis(), _arg);
		}

		// Token: 0x06005029 RID: 20521
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetDetectNumericColumns_50(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true, the reader will detect numeric columns and create
		/// vtkDoubleArray or vtkIntArray for those instead of vtkStringArray. Default
		/// is off.
		/// </summary>
		// Token: 0x0600502A RID: 20522 RVA: 0x000747B7 File Offset: 0x000729B7
		public virtual void SetDetectNumericColumns(bool _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetDetectNumericColumns_50(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600502B RID: 20523
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetFieldDelimiterCharacters_51(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the character(s) that will be used to separate fields.  For
		/// example, set this to "," for a comma-separated value file.  Set
		/// it to ".:;" for a file where columns can be separated by a
		/// period, colon or semicolon.  The order of the characters in the
		/// string does not matter.  Defaults to a comma.
		/// </summary>
		// Token: 0x0600502C RID: 20524 RVA: 0x000747CF File Offset: 0x000729CF
		public virtual void SetFieldDelimiterCharacters(string _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetFieldDelimiterCharacters_51(base.GetCppThis(), _arg);
		}

		// Token: 0x0600502D RID: 20525
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetFileName_52(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specifies the delimited text file to be loaded.
		/// </summary>
		// Token: 0x0600502E RID: 20526 RVA: 0x000747DF File Offset: 0x000729DF
		public virtual void SetFileName(string _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetFileName_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0600502F RID: 20527
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetForceDouble_53(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true and DetectNumericColumns is also true, forces all
		/// numeric columns to vtkDoubleArray even if they contain only
		/// integer values. Default is off.
		/// </summary>
		// Token: 0x06005030 RID: 20528 RVA: 0x000747EF File Offset: 0x000729EF
		public virtual void SetForceDouble(bool _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetForceDouble_53(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005031 RID: 20529
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetGeneratePedigreeIds_54(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on (default), generates pedigree ids automatically.
		/// If off, assign one of the arrays to be the pedigree id.
		/// </summary>
		// Token: 0x06005032 RID: 20530 RVA: 0x00074807 File Offset: 0x00072A07
		public virtual void SetGeneratePedigreeIds(bool _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetGeneratePedigreeIds_54(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005033 RID: 20531
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetHaveHeaders_55(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/get whether to treat the first line of the file as headers.
		/// The default is false (no headers).
		/// </summary>
		// Token: 0x06005034 RID: 20532 RVA: 0x0007481F File Offset: 0x00072A1F
		public virtual void SetHaveHeaders(bool _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetHaveHeaders_55(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005035 RID: 20533
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetInputString_56(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Specify the InputString for use when reading from a character array.
		/// Optionally include the length for binary strings. Note that a copy
		/// of the string is made and stored. If this causes exceedingly large
		/// memory consumption, consider using InputArray instead.
		/// </summary>
		// Token: 0x06005036 RID: 20534 RVA: 0x00074837 File Offset: 0x00072A37
		public void SetInputString(string arg0)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetInputString_56(base.GetCppThis(), arg0);
		}

		// Token: 0x06005037 RID: 20535
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetInputString_57(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, int len);

		/// <summary>
		/// Specify the InputString for use when reading from a character array.
		/// Optionally include the length for binary strings. Note that a copy
		/// of the string is made and stored. If this causes exceedingly large
		/// memory consumption, consider using InputArray instead.
		/// </summary>
		// Token: 0x06005038 RID: 20536 RVA: 0x00074847 File Offset: 0x00072A47
		public void SetInputString(string arg0, int len)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetInputString_57(base.GetCppThis(), arg0, len);
		}

		// Token: 0x06005039 RID: 20537
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetMaxRecords_58(HandleRef pThis, long _arg);

		/// <summary>
		/// Specifies the maximum number of records to read from the file.  Limiting the
		/// number of records to read is useful for previewing the contents of a file.
		/// </summary>
		// Token: 0x0600503A RID: 20538 RVA: 0x00074858 File Offset: 0x00072A58
		public virtual void SetMaxRecords(long _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetMaxRecords_58(base.GetCppThis(), _arg);
		}

		// Token: 0x0600503B RID: 20539
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetMergeConsecutiveDelimiters_59(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/get whether to merge successive delimiters.  Use this if (for
		/// example) your fields are separated by spaces but you don't know
		/// exactly how many.
		/// </summary>
		// Token: 0x0600503C RID: 20540 RVA: 0x00074868 File Offset: 0x00072A68
		public virtual void SetMergeConsecutiveDelimiters(bool _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetMergeConsecutiveDelimiters_59(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600503D RID: 20541
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetOutputPedigreeIds_60(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on, assigns pedigree ids to output. Defaults to off.
		/// </summary>
		// Token: 0x0600503E RID: 20542 RVA: 0x00074880 File Offset: 0x00072A80
		public virtual void SetOutputPedigreeIds(bool _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetOutputPedigreeIds_60(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600503F RID: 20543
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetPedigreeIdArrayName_61(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the array for generating or assigning pedigree ids
		/// (default "id").
		/// </summary>
		// Token: 0x06005040 RID: 20544 RVA: 0x00074898 File Offset: 0x00072A98
		public virtual void SetPedigreeIdArrayName(string _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetPedigreeIdArrayName_61(base.GetCppThis(), _arg);
		}

		// Token: 0x06005041 RID: 20545
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetReadFromInputString_62(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable reading from an InputString or InputArray instead of the default,
		/// a file.
		/// </summary>
		// Token: 0x06005042 RID: 20546 RVA: 0x000748A8 File Offset: 0x00072AA8
		public virtual void SetReadFromInputString(int _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetReadFromInputString_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06005043 RID: 20547
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetReplacementCharacter_63(HandleRef pThis, uint _arg);

		/// <summary>
		/// Fallback character for use in the US-ASCII-WITH-FALLBACK
		/// character set.  Any characters that have their 8th bit set will
		/// be replaced with this code point.  Defaults to 'x'.
		/// </summary>
		// Token: 0x06005044 RID: 20548 RVA: 0x000748B8 File Offset: 0x00072AB8
		public virtual void SetReplacementCharacter(uint _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetReplacementCharacter_63(base.GetCppThis(), _arg);
		}

		// Token: 0x06005045 RID: 20549
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetStringDelimiter_64(HandleRef pThis, sbyte _arg);

		/// <summary>
		/// Get/set the character that will begin and end strings.  Microsoft
		/// Excel, for example, will export the following format:
		///
		/// "First Field","Second Field","Field, With, Commas","Fourth Field"
		///
		/// The third field has a comma in it.  By using a string delimiter,
		/// this will be correctly read.  The delimiter defaults to '"'.
		/// </summary>
		// Token: 0x06005046 RID: 20550 RVA: 0x000748C8 File Offset: 0x00072AC8
		public virtual void SetStringDelimiter(sbyte _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetStringDelimiter_64(base.GetCppThis(), _arg);
		}

		// Token: 0x06005047 RID: 20551
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetTrimWhitespacePriorToNumericConversion_65(HandleRef pThis, byte _arg);

		/// <summary>
		/// When DetectNumericColumns is set to true, whether to trim whitespace from
		/// strings prior to conversion to a numeric.
		/// Default is false to preserve backward compatibility.
		///
		/// vtkVariant handles whitespace inconsistently, so trim it before we try to
		/// convert it.  For example:
		///
		/// vtkVariant("  2.0").ToDouble() == 2.0 &lt;-- leading whitespace is not a problem
		/// vtkVariant("  2.0  ").ToDouble() == NaN &lt;-- trailing whitespace is a problem
		/// vtkVariant("  infinity  ").ToDouble() == NaN &lt;-- any whitespace is a problem
		///
		/// In these cases, trimming the whitespace gives us the result we expect:
		/// 2.0 and INF respectively.
		/// </summary>
		// Token: 0x06005048 RID: 20552 RVA: 0x000748D8 File Offset: 0x00072AD8
		public virtual void SetTrimWhitespacePriorToNumericConversion(bool _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetTrimWhitespacePriorToNumericConversion_65(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005049 RID: 20553
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetUTF8FieldDelimiters_66(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string delimiters);

		/// <summary>
		/// Specify the character(s) that will be used to separate fields.  For
		/// example, set this to "," for a comma-separated value file.  Set
		/// it to ".:;" for a file where columns can be separated by a
		/// period, colon or semicolon.  The order of the characters in the
		/// string does not matter.  Defaults to a comma.
		/// </summary>
		// Token: 0x0600504A RID: 20554 RVA: 0x000748F0 File Offset: 0x00072AF0
		public void SetUTF8FieldDelimiters(string delimiters)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetUTF8FieldDelimiters_66(base.GetCppThis(), delimiters);
		}

		// Token: 0x0600504B RID: 20555
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetUTF8RecordDelimiters_67(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string delimiters);

		/// <summary>
		/// Specify the character(s) that will be used to separate records.
		/// The order of characters in the string does not matter.  Defaults
		/// to "\r\n".
		/// </summary>
		// Token: 0x0600504C RID: 20556 RVA: 0x00074900 File Offset: 0x00072B00
		public void SetUTF8RecordDelimiters(string delimiters)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetUTF8RecordDelimiters_67(base.GetCppThis(), delimiters);
		}

		// Token: 0x0600504D RID: 20557
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetUTF8StringDelimiters_68(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string delimiters);

		/// <summary>
		/// Get/set the character that will begin and end strings.  Microsoft
		/// Excel, for example, will export the following format:
		///
		/// "First Field","Second Field","Field, With, Commas","Fourth Field"
		///
		/// The third field has a comma in it.  By using a string delimiter,
		/// this will be correctly read.  The delimiter defaults to '"'.
		/// </summary>
		// Token: 0x0600504E RID: 20558 RVA: 0x00074910 File Offset: 0x00072B10
		public void SetUTF8StringDelimiters(string delimiters)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetUTF8StringDelimiters_68(base.GetCppThis(), delimiters);
		}

		// Token: 0x0600504F RID: 20559
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetUnicodeCharacterSet_69(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specifies the character set used in the input file.  Valid character set
		/// names will be drawn from the list maintained by the Internet Assigned Name
		/// Authority at
		///
		/// http://www.iana.org/assignments/character-sets
		///
		/// Where multiple aliases are provided for a character set, the preferred MIME name
		/// will be used.  vtkUnicodeDelimitedTextReader currently supports "US-ASCII", "UTF-8",
		/// "UTF-16", "UTF-16BE", and "UTF-16LE" character sets.
		/// </summary>
		// Token: 0x06005050 RID: 20560 RVA: 0x00074920 File Offset: 0x00072B20
		public virtual void SetUnicodeCharacterSet(string _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetUnicodeCharacterSet_69(base.GetCppThis(), _arg);
		}

		// Token: 0x06005051 RID: 20561
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_SetUseStringDelimiter_70(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/get whether to use the string delimiter.  Defaults to on.
		/// </summary>
		// Token: 0x06005052 RID: 20562 RVA: 0x00074930 File Offset: 0x00072B30
		public virtual void SetUseStringDelimiter(bool _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetUseStringDelimiter_70(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005053 RID: 20563
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_TrimWhitespacePriorToNumericConversionOff_71(HandleRef pThis);

		/// <summary>
		/// When DetectNumericColumns is set to true, whether to trim whitespace from
		/// strings prior to conversion to a numeric.
		/// Default is false to preserve backward compatibility.
		///
		/// vtkVariant handles whitespace inconsistently, so trim it before we try to
		/// convert it.  For example:
		///
		/// vtkVariant("  2.0").ToDouble() == 2.0 &lt;-- leading whitespace is not a problem
		/// vtkVariant("  2.0  ").ToDouble() == NaN &lt;-- trailing whitespace is a problem
		/// vtkVariant("  infinity  ").ToDouble() == NaN &lt;-- any whitespace is a problem
		///
		/// In these cases, trimming the whitespace gives us the result we expect:
		/// 2.0 and INF respectively.
		/// </summary>
		// Token: 0x06005054 RID: 20564 RVA: 0x00074948 File Offset: 0x00072B48
		public virtual void TrimWhitespacePriorToNumericConversionOff()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_TrimWhitespacePriorToNumericConversionOff_71(base.GetCppThis());
		}

		// Token: 0x06005055 RID: 20565
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_TrimWhitespacePriorToNumericConversionOn_72(HandleRef pThis);

		/// <summary>
		/// When DetectNumericColumns is set to true, whether to trim whitespace from
		/// strings prior to conversion to a numeric.
		/// Default is false to preserve backward compatibility.
		///
		/// vtkVariant handles whitespace inconsistently, so trim it before we try to
		/// convert it.  For example:
		///
		/// vtkVariant("  2.0").ToDouble() == 2.0 &lt;-- leading whitespace is not a problem
		/// vtkVariant("  2.0  ").ToDouble() == NaN &lt;-- trailing whitespace is a problem
		/// vtkVariant("  infinity  ").ToDouble() == NaN &lt;-- any whitespace is a problem
		///
		/// In these cases, trimming the whitespace gives us the result we expect:
		/// 2.0 and INF respectively.
		/// </summary>
		// Token: 0x06005056 RID: 20566 RVA: 0x00074957 File Offset: 0x00072B57
		public virtual void TrimWhitespacePriorToNumericConversionOn()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_TrimWhitespacePriorToNumericConversionOn_72(base.GetCppThis());
		}

		// Token: 0x06005057 RID: 20567
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_UseStringDelimiterOff_73(HandleRef pThis);

		/// <summary>
		/// Set/get whether to use the string delimiter.  Defaults to on.
		/// </summary>
		// Token: 0x06005058 RID: 20568 RVA: 0x00074966 File Offset: 0x00072B66
		public virtual void UseStringDelimiterOff()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_UseStringDelimiterOff_73(base.GetCppThis());
		}

		// Token: 0x06005059 RID: 20569
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextReader_UseStringDelimiterOn_74(HandleRef pThis);

		/// <summary>
		/// Set/get whether to use the string delimiter.  Defaults to on.
		/// </summary>
		// Token: 0x0600505A RID: 20570 RVA: 0x00074975 File Offset: 0x00072B75
		public virtual void UseStringDelimiterOn()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_UseStringDelimiterOn_74(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000793 RID: 1939
		public new const string MRFullTypeName = "Kitware.VTK.vtkDelimitedTextReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000794 RID: 1940
		public new static readonly string MRClassNameKey = "class vtkDelimitedTextReader";
	}
}
