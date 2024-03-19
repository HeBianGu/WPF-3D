using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLDataParser
	/// </summary>
	/// <remarks>
	///    Used by vtkXMLReader to parse VTK XML files.
	///
	/// vtkXMLDataParser provides a subclass of vtkXMLParser that
	/// constructs a representation of an XML data format's file using
	/// vtkXMLDataElement to represent each XML element.  This
	/// representation is then used by vtkXMLReader and its subclasses to
	/// traverse the structure of the file and extract data.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLDataElement
	/// </seealso>
	// Token: 0x020006EB RID: 1771
	public class vtkXMLDataParser : vtkXMLParser
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012AC7 RID: 76487 RVA: 0x001A43DB File Offset: 0x001A25DB
		static vtkXMLDataParser()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLDataParser.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLDataParser"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012AC8 RID: 76488 RVA: 0x001A4403 File Offset: 0x001A2603
		public vtkXMLDataParser(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012AC9 RID: 76489
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataParser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012ACA RID: 76490 RVA: 0x001A4414 File Offset: 0x001A2614
		public new static vtkXMLDataParser New()
		{
			vtkXMLDataParser result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataParser.vtkXMLDataParser_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLDataParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012ACB RID: 76491 RVA: 0x001A4468 File Offset: 0x001A2668
		public vtkXMLDataParser() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLDataParser.vtkXMLDataParser_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012ACC RID: 76492 RVA: 0x001A44AC File Offset: 0x001A26AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012ACD RID: 76493
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataParser_CharacterDataHandler_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string data, int length);

		/// <summary>
		/// If you need the text inside XMLElements, turn IgnoreCharacterData off.
		/// This method will then be called when the file is parsed, and the text
		/// will be stored in each XMLDataElement. VTK XML Readers store the
		/// information elsewhere, so the default is to ignore it.
		/// </summary>
		// Token: 0x06012ACE RID: 76494 RVA: 0x001A44B7 File Offset: 0x001A26B7
		public virtual void CharacterDataHandler(string data, int length)
		{
			vtkXMLDataParser.vtkXMLDataParser_CharacterDataHandler_01(base.GetCppThis(), data, length);
		}

		// Token: 0x06012ACF RID: 76495
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataParser_GetAbort_02(HandleRef pThis);

		/// <summary>
		/// Get/Set flag to abort reading of data.  This may be set by a
		/// progress event observer.
		/// </summary>
		// Token: 0x06012AD0 RID: 76496 RVA: 0x001A44C8 File Offset: 0x001A26C8
		public virtual int GetAbort()
		{
			return vtkXMLDataParser.vtkXMLDataParser_GetAbort_02(base.GetCppThis());
		}

		// Token: 0x06012AD1 RID: 76497
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLDataParser_GetAppendedDataPosition_03(HandleRef pThis);

		/// <summary>
		/// Returns the byte index of where appended data starts (if the
		/// file is using appended data). Valid after the XML is parsed.
		/// </summary>
		// Token: 0x06012AD2 RID: 76498 RVA: 0x001A44E8 File Offset: 0x001A26E8
		public long GetAppendedDataPosition()
		{
			return vtkXMLDataParser.vtkXMLDataParser_GetAppendedDataPosition_03(base.GetCppThis());
		}

		// Token: 0x06012AD3 RID: 76499
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataParser_GetAttributesEncoding_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the character encoding that will be used to set the attributes's
		/// encoding type of each vtkXMLDataElement created by this parser (i.e.,
		/// the data element attributes will use that encoding internally).
		/// If set to VTK_ENCODING_NONE (default), the attribute encoding type will
		/// not be changed and will default to the vtkXMLDataElement default encoding
		/// type (see vtkXMLDataElement::AttributeEncoding).
		/// </summary>
		// Token: 0x06012AD4 RID: 76500 RVA: 0x001A4508 File Offset: 0x001A2708
		public virtual int GetAttributesEncoding()
		{
			return vtkXMLDataParser.vtkXMLDataParser_GetAttributesEncoding_04(base.GetCppThis());
		}

		// Token: 0x06012AD5 RID: 76501
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataParser_GetAttributesEncodingMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the character encoding that will be used to set the attributes's
		/// encoding type of each vtkXMLDataElement created by this parser (i.e.,
		/// the data element attributes will use that encoding internally).
		/// If set to VTK_ENCODING_NONE (default), the attribute encoding type will
		/// not be changed and will default to the vtkXMLDataElement default encoding
		/// type (see vtkXMLDataElement::AttributeEncoding).
		/// </summary>
		// Token: 0x06012AD6 RID: 76502 RVA: 0x001A4528 File Offset: 0x001A2728
		public virtual int GetAttributesEncodingMaxValue()
		{
			return vtkXMLDataParser.vtkXMLDataParser_GetAttributesEncodingMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06012AD7 RID: 76503
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataParser_GetAttributesEncodingMinValue_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the character encoding that will be used to set the attributes's
		/// encoding type of each vtkXMLDataElement created by this parser (i.e.,
		/// the data element attributes will use that encoding internally).
		/// If set to VTK_ENCODING_NONE (default), the attribute encoding type will
		/// not be changed and will default to the vtkXMLDataElement default encoding
		/// type (see vtkXMLDataElement::AttributeEncoding).
		/// </summary>
		// Token: 0x06012AD8 RID: 76504 RVA: 0x001A4548 File Offset: 0x001A2748
		public virtual int GetAttributesEncodingMinValue()
		{
			return vtkXMLDataParser.vtkXMLDataParser_GetAttributesEncodingMinValue_06(base.GetCppThis());
		}

		// Token: 0x06012AD9 RID: 76505
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataParser_GetCompressor_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the compressor used to decompress binary and appended data
		/// after reading from the file.
		/// </summary>
		// Token: 0x06012ADA RID: 76506 RVA: 0x001A4568 File Offset: 0x001A2768
		public virtual vtkDataCompressor GetCompressor()
		{
			vtkDataCompressor vtkDataCompressor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataParser.vtkXMLDataParser_GetCompressor_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataCompressor = (vtkDataCompressor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataCompressor.Register(null);
				}
			}
			return vtkDataCompressor;
		}

		// Token: 0x06012ADB RID: 76507
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLDataParser_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012ADC RID: 76508 RVA: 0x001A45D8 File Offset: 0x001A27D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLDataParser.vtkXMLDataParser_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06012ADD RID: 76509
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLDataParser_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012ADE RID: 76510 RVA: 0x001A45F8 File Offset: 0x001A27F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLDataParser.vtkXMLDataParser_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06012ADF RID: 76511
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkXMLDataParser_GetProgress_10(HandleRef pThis);

		/// <summary>
		/// Get/Set progress of reading data.  This may be checked by a
		/// progress event observer.
		/// </summary>
		// Token: 0x06012AE0 RID: 76512 RVA: 0x001A4614 File Offset: 0x001A2814
		public virtual float GetProgress()
		{
			return vtkXMLDataParser.vtkXMLDataParser_GetProgress_10(base.GetCppThis());
		}

		// Token: 0x06012AE1 RID: 76513
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataParser_GetRootElement_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the root element from the XML document.
		/// </summary>
		// Token: 0x06012AE2 RID: 76514 RVA: 0x001A4634 File Offset: 0x001A2834
		public vtkXMLDataElement GetRootElement()
		{
			vtkXMLDataElement vtkXMLDataElement = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataParser.vtkXMLDataParser_GetRootElement_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataElement = (vtkXMLDataElement)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataElement.Register(null);
				}
			}
			return vtkXMLDataElement;
		}

		// Token: 0x06012AE3 RID: 76515
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkXMLDataParser_GetWordTypeSize_12(HandleRef pThis, int wordType);

		/// <summary>
		/// Get the size of a word of the given type.
		/// </summary>
		// Token: 0x06012AE4 RID: 76516 RVA: 0x001A46A4 File Offset: 0x001A28A4
		public ulong GetWordTypeSize(int wordType)
		{
			return vtkXMLDataParser.vtkXMLDataParser_GetWordTypeSize_12(base.GetCppThis(), wordType);
		}

		// Token: 0x06012AE5 RID: 76517
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataParser_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012AE6 RID: 76518 RVA: 0x001A46C4 File Offset: 0x001A28C4
		public override int IsA(string type)
		{
			return vtkXMLDataParser.vtkXMLDataParser_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06012AE7 RID: 76519
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataParser_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012AE8 RID: 76520 RVA: 0x001A46E4 File Offset: 0x001A28E4
		public new static int IsTypeOf(string type)
		{
			return vtkXMLDataParser.vtkXMLDataParser_IsTypeOf_14(type);
		}

		// Token: 0x06012AE9 RID: 76521
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataParser_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012AEA RID: 76522 RVA: 0x001A4700 File Offset: 0x001A2900
		public new vtkXMLDataParser NewInstance()
		{
			vtkXMLDataParser result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataParser.vtkXMLDataParser_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLDataParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012AEB RID: 76523
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLDataParser_Parse_17(HandleRef pThis);

		/// <summary>
		/// Parse the XML input and check that the file is safe to read.
		/// Returns 1 for okay, 0 for error.
		/// </summary>
		// Token: 0x06012AEC RID: 76524 RVA: 0x001A475C File Offset: 0x001A295C
		public override int Parse()
		{
			return vtkXMLDataParser.vtkXMLDataParser_Parse_17(base.GetCppThis());
		}

		// Token: 0x06012AED RID: 76525
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkXMLDataParser_ReadAppendedData_18(HandleRef pThis, long offset, IntPtr buffer, ulong startWord, ulong numWords, int wordType);

		/// <summary>
		/// Read from an appended data section starting at the given appended
		/// data offset.  Returns the number of words read.
		/// </summary>
		// Token: 0x06012AEE RID: 76526 RVA: 0x001A477C File Offset: 0x001A297C
		public ulong ReadAppendedData(long offset, IntPtr buffer, ulong startWord, ulong numWords, int wordType)
		{
			return vtkXMLDataParser.vtkXMLDataParser_ReadAppendedData_18(base.GetCppThis(), offset, buffer, startWord, numWords, wordType);
		}

		// Token: 0x06012AEF RID: 76527
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkXMLDataParser_ReadAppendedData_19(HandleRef pThis, long offset, [MarshalAs(UnmanagedType.LPUTF8Str)] string buffer, ulong startWord, ulong numWords);

		/// <summary>
		/// Read from an appended data section starting at the given appended
		/// data offset.  Returns the number of words read.
		/// </summary>
		// Token: 0x06012AF0 RID: 76528 RVA: 0x001A47A4 File Offset: 0x001A29A4
		public ulong ReadAppendedData(long offset, string buffer, ulong startWord, ulong numWords)
		{
			return vtkXMLDataParser.vtkXMLDataParser_ReadAppendedData_19(base.GetCppThis(), offset, buffer, startWord, numWords);
		}

		// Token: 0x06012AF1 RID: 76529
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkXMLDataParser_ReadAsciiData_20(HandleRef pThis, IntPtr buffer, ulong startWord, ulong numWords, int wordType);

		/// <summary>
		/// Read from an ascii data section starting at the current position in
		/// the stream.  Returns the number of words read.
		/// </summary>
		// Token: 0x06012AF2 RID: 76530 RVA: 0x001A47C8 File Offset: 0x001A29C8
		public ulong ReadAsciiData(IntPtr buffer, ulong startWord, ulong numWords, int wordType)
		{
			return vtkXMLDataParser.vtkXMLDataParser_ReadAsciiData_20(base.GetCppThis(), buffer, startWord, numWords, wordType);
		}

		// Token: 0x06012AF3 RID: 76531
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkXMLDataParser_ReadBinaryData_21(HandleRef pThis, IntPtr buffer, ulong startWord, ulong maxWords, int wordType);

		/// <summary>
		/// Read from a data section starting at the current position in the
		/// stream.  Returns the number of words read.
		/// </summary>
		// Token: 0x06012AF4 RID: 76532 RVA: 0x001A47EC File Offset: 0x001A29EC
		public ulong ReadBinaryData(IntPtr buffer, ulong startWord, ulong maxWords, int wordType)
		{
			return vtkXMLDataParser.vtkXMLDataParser_ReadBinaryData_21(base.GetCppThis(), buffer, startWord, maxWords, wordType);
		}

		// Token: 0x06012AF5 RID: 76533
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkXMLDataParser_ReadInlineData_22(HandleRef pThis, HandleRef element, int isAscii, IntPtr buffer, ulong startWord, ulong numWords, int wordType);

		/// <summary>
		/// Read inline data from inside the given element.  Returns the
		/// number of words read.
		/// </summary>
		// Token: 0x06012AF6 RID: 76534 RVA: 0x001A4810 File Offset: 0x001A2A10
		public ulong ReadInlineData(vtkXMLDataElement element, int isAscii, IntPtr buffer, ulong startWord, ulong numWords, int wordType)
		{
			return vtkXMLDataParser.vtkXMLDataParser_ReadInlineData_22(base.GetCppThis(), (element == null) ? default(HandleRef) : element.GetCppThis(), isAscii, buffer, startWord, numWords, wordType);
		}

		// Token: 0x06012AF7 RID: 76535
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkXMLDataParser_ReadInlineData_23(HandleRef pThis, HandleRef element, int isAscii, [MarshalAs(UnmanagedType.LPUTF8Str)] string buffer, ulong startWord, ulong numWords);

		/// <summary>
		/// Read inline data from inside the given element.  Returns the
		/// number of words read.
		/// </summary>
		// Token: 0x06012AF8 RID: 76536 RVA: 0x001A484C File Offset: 0x001A2A4C
		public ulong ReadInlineData(vtkXMLDataElement element, int isAscii, string buffer, ulong startWord, ulong numWords)
		{
			return vtkXMLDataParser.vtkXMLDataParser_ReadInlineData_23(base.GetCppThis(), (element == null) ? default(HandleRef) : element.GetCppThis(), isAscii, buffer, startWord, numWords);
		}

		// Token: 0x06012AF9 RID: 76537
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLDataParser_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012AFA RID: 76538 RVA: 0x001A4888 File Offset: 0x001A2A88
		public new static vtkXMLDataParser SafeDownCast(vtkObjectBase o)
		{
			vtkXMLDataParser vtkXMLDataParser = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLDataParser.vtkXMLDataParser_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataParser = (vtkXMLDataParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataParser.Register(null);
				}
			}
			return vtkXMLDataParser;
		}

		// Token: 0x06012AFB RID: 76539
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataParser_SetAbort_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set flag to abort reading of data.  This may be set by a
		/// progress event observer.
		/// </summary>
		// Token: 0x06012AFC RID: 76540 RVA: 0x001A4907 File Offset: 0x001A2B07
		public virtual void SetAbort(int _arg)
		{
			vtkXMLDataParser.vtkXMLDataParser_SetAbort_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06012AFD RID: 76541
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataParser_SetAttributesEncoding_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the character encoding that will be used to set the attributes's
		/// encoding type of each vtkXMLDataElement created by this parser (i.e.,
		/// the data element attributes will use that encoding internally).
		/// If set to VTK_ENCODING_NONE (default), the attribute encoding type will
		/// not be changed and will default to the vtkXMLDataElement default encoding
		/// type (see vtkXMLDataElement::AttributeEncoding).
		/// </summary>
		// Token: 0x06012AFE RID: 76542 RVA: 0x001A4917 File Offset: 0x001A2B17
		public virtual void SetAttributesEncoding(int _arg)
		{
			vtkXMLDataParser.vtkXMLDataParser_SetAttributesEncoding_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06012AFF RID: 76543
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataParser_SetCompressor_27(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the compressor used to decompress binary and appended data
		/// after reading from the file.
		/// </summary>
		// Token: 0x06012B00 RID: 76544 RVA: 0x001A4928 File Offset: 0x001A2B28
		public virtual void SetCompressor(vtkDataCompressor arg0)
		{
			vtkXMLDataParser.vtkXMLDataParser_SetCompressor_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06012B01 RID: 76545
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLDataParser_SetProgress_28(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/Set progress of reading data.  This may be checked by a
		/// progress event observer.
		/// </summary>
		// Token: 0x06012B02 RID: 76546 RVA: 0x001A4957 File Offset: 0x001A2B57
		public virtual void SetProgress(float _arg)
		{
			vtkXMLDataParser.vtkXMLDataParser_SetProgress_28(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001587 RID: 5511
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLDataParser";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001588 RID: 5512
		public new static readonly string MRClassNameKey = "class vtkXMLDataParser";

		/// <summary>
		/// Enumerate big and little endian byte order settings.
		/// </summary>
		// Token: 0x020006EC RID: 1772
		public enum BigEndian_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400158A RID: 5514
			BigEndian,
			/// <summary>enum member</summary>
			// Token: 0x0400158B RID: 5515
			LittleEndian
		}
	}
}
