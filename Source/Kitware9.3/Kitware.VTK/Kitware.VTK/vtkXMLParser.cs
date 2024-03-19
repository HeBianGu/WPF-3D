using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLParser
	/// </summary>
	/// <remarks>
	///    Parse XML to handle element tags and attributes.
	///
	/// vtkXMLParser reads a stream and parses XML element tags and corresponding
	/// attributes.  Each element begin tag and its attributes are sent to
	/// the StartElement method.  Each element end tag is sent to the
	/// EndElement method.  Subclasses should replace these methods to actually
	/// use the tags.
	/// </remarks>
	// Token: 0x02000182 RID: 386
	public class vtkXMLParser : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004A5E RID: 19038 RVA: 0x0006C42E File Offset: 0x0006A62E
		static vtkXMLParser()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLParser.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLParser"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004A5F RID: 19039 RVA: 0x0006C456 File Offset: 0x0006A656
		public vtkXMLParser(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004A60 RID: 19040
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLParser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A61 RID: 19041 RVA: 0x0006C464 File Offset: 0x0006A664
		public new static vtkXMLParser New()
		{
			vtkXMLParser result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLParser.vtkXMLParser_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A62 RID: 19042 RVA: 0x0006C4B8 File Offset: 0x0006A6B8
		public vtkXMLParser() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLParser.vtkXMLParser_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004A63 RID: 19043 RVA: 0x0006C4FC File Offset: 0x0006A6FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004A64 RID: 19044
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLParser_CleanupParser_01(HandleRef pThis);

		/// <summary>
		/// When parsing fragments of XML, or when streaming XML,
		/// use the following three methods:
		/// - InitializeParser() initializes the parser
		/// but does not perform any actual parsing.
		/// - ParseChunk() parses a fragment of XML;
		/// this has to match to what was already parsed.
		/// - CleanupParser() finishes parsing;
		/// if there were errors, it will report them.
		/// </summary>
		// Token: 0x06004A65 RID: 19045 RVA: 0x0006C508 File Offset: 0x0006A708
		public virtual int CleanupParser()
		{
			return vtkXMLParser.vtkXMLParser_CleanupParser_01(base.GetCppThis());
		}

		// Token: 0x06004A66 RID: 19046
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLParser_GetEncoding_02(HandleRef pThis);

		/// <summary>
		/// Set and get the encoding the parser should expect (nullptr defaults to
		/// Expat's own default encoder, i.e UTF-8).
		/// This should be set before parsing (i.e. a call to Parse()) or
		/// even initializing the parser (i.e. a call to InitializeParser())
		/// </summary>
		// Token: 0x06004A67 RID: 19047 RVA: 0x0006C528 File Offset: 0x0006A728
		public virtual string GetEncoding()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLParser.vtkXMLParser_GetEncoding_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004A68 RID: 19048
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLParser_GetFileName_03(HandleRef pThis);

		/// <summary>
		/// Set and get file name.
		/// </summary>
		// Token: 0x06004A69 RID: 19049 RVA: 0x0006C564 File Offset: 0x0006A764
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLParser.vtkXMLParser_GetFileName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004A6A RID: 19050
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLParser_GetIgnoreCharacterData_04(HandleRef pThis);

		/// <summary>
		/// If this is off (the default), CharacterDataHandler will be called to
		/// process text within XML Elements. If this is on, the text will be
		/// ignored.
		/// </summary>
		// Token: 0x06004A6B RID: 19051 RVA: 0x0006C5A0 File Offset: 0x0006A7A0
		public virtual int GetIgnoreCharacterData()
		{
			return vtkXMLParser.vtkXMLParser_GetIgnoreCharacterData_04(base.GetCppThis());
		}

		// Token: 0x06004A6C RID: 19052
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLParser_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A6D RID: 19053 RVA: 0x0006C5C0 File Offset: 0x0006A7C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLParser.vtkXMLParser_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06004A6E RID: 19054
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLParser_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A6F RID: 19055 RVA: 0x0006C5E0 File Offset: 0x0006A7E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLParser.vtkXMLParser_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06004A70 RID: 19056
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLParser_InitializeParser_07(HandleRef pThis);

		/// <summary>
		/// When parsing fragments of XML, or when streaming XML,
		/// use the following three methods:
		/// - InitializeParser() initializes the parser
		/// but does not perform any actual parsing.
		/// - ParseChunk() parses a fragment of XML;
		/// this has to match to what was already parsed.
		/// - CleanupParser() finishes parsing;
		/// if there were errors, it will report them.
		/// </summary>
		// Token: 0x06004A71 RID: 19057 RVA: 0x0006C5FC File Offset: 0x0006A7FC
		public virtual int InitializeParser()
		{
			return vtkXMLParser.vtkXMLParser_InitializeParser_07(base.GetCppThis());
		}

		// Token: 0x06004A72 RID: 19058
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLParser_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A73 RID: 19059 RVA: 0x0006C61C File Offset: 0x0006A81C
		public override int IsA(string type)
		{
			return vtkXMLParser.vtkXMLParser_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06004A74 RID: 19060
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLParser_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A75 RID: 19061 RVA: 0x0006C63C File Offset: 0x0006A83C
		public new static int IsTypeOf(string type)
		{
			return vtkXMLParser.vtkXMLParser_IsTypeOf_09(type);
		}

		// Token: 0x06004A76 RID: 19062
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLParser_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A77 RID: 19063 RVA: 0x0006C658 File Offset: 0x0006A858
		public new vtkXMLParser NewInstance()
		{
			vtkXMLParser result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLParser.vtkXMLParser_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004A78 RID: 19064
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLParser_Parse_12(HandleRef pThis);

		/// <summary>
		/// Parse the XML input.
		/// </summary>
		// Token: 0x06004A79 RID: 19065 RVA: 0x0006C6B4 File Offset: 0x0006A8B4
		public virtual int Parse()
		{
			return vtkXMLParser.vtkXMLParser_Parse_12(base.GetCppThis());
		}

		// Token: 0x06004A7A RID: 19066
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLParser_Parse_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string inputString);

		/// <summary>
		/// Parse the XML message. If length is specified, parse only the
		/// first "length" characters
		/// </summary>
		// Token: 0x06004A7B RID: 19067 RVA: 0x0006C6D4 File Offset: 0x0006A8D4
		public virtual int Parse(string inputString)
		{
			return vtkXMLParser.vtkXMLParser_Parse_13(base.GetCppThis(), inputString);
		}

		// Token: 0x06004A7C RID: 19068
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLParser_Parse_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string inputString, uint length);

		/// <summary>
		/// Parse the XML message. If length is specified, parse only the
		/// first "length" characters
		/// </summary>
		// Token: 0x06004A7D RID: 19069 RVA: 0x0006C6F4 File Offset: 0x0006A8F4
		public virtual int Parse(string inputString, uint length)
		{
			return vtkXMLParser.vtkXMLParser_Parse_14(base.GetCppThis(), inputString, length);
		}

		// Token: 0x06004A7E RID: 19070
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLParser_ParseChunk_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string inputString, uint length);

		/// <summary>
		/// When parsing fragments of XML, or when streaming XML,
		/// use the following three methods:
		/// - InitializeParser() initializes the parser
		/// but does not perform any actual parsing.
		/// - ParseChunk() parses a fragment of XML;
		/// this has to match to what was already parsed.
		/// - CleanupParser() finishes parsing;
		/// if there were errors, it will report them.
		/// </summary>
		// Token: 0x06004A7F RID: 19071 RVA: 0x0006C718 File Offset: 0x0006A918
		public virtual int ParseChunk(string inputString, uint length)
		{
			return vtkXMLParser.vtkXMLParser_ParseChunk_15(base.GetCppThis(), inputString, length);
		}

		// Token: 0x06004A80 RID: 19072
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLParser_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A81 RID: 19073 RVA: 0x0006C73C File Offset: 0x0006A93C
		public new static vtkXMLParser SafeDownCast(vtkObjectBase o)
		{
			vtkXMLParser vtkXMLParser = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLParser.vtkXMLParser_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLParser = (vtkXMLParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLParser.Register(null);
				}
			}
			return vtkXMLParser;
		}

		// Token: 0x06004A82 RID: 19074
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLParser_SeekG_17(HandleRef pThis, long position);

		/// <summary>
		/// Used by subclasses and their supporting classes.  These methods
		/// wrap around the tellg and seekg methods of the input stream to
		/// work-around stream bugs on various platforms.
		/// </summary>
		// Token: 0x06004A83 RID: 19075 RVA: 0x0006C7BB File Offset: 0x0006A9BB
		public void SeekG(long position)
		{
			vtkXMLParser.vtkXMLParser_SeekG_17(base.GetCppThis(), position);
		}

		// Token: 0x06004A84 RID: 19076
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLParser_SetEncoding_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set and get the encoding the parser should expect (nullptr defaults to
		/// Expat's own default encoder, i.e UTF-8).
		/// This should be set before parsing (i.e. a call to Parse()) or
		/// even initializing the parser (i.e. a call to InitializeParser())
		/// </summary>
		// Token: 0x06004A85 RID: 19077 RVA: 0x0006C7CB File Offset: 0x0006A9CB
		public virtual void SetEncoding(string _arg)
		{
			vtkXMLParser.vtkXMLParser_SetEncoding_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06004A86 RID: 19078
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLParser_SetFileName_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set and get file name.
		/// </summary>
		// Token: 0x06004A87 RID: 19079 RVA: 0x0006C7DB File Offset: 0x0006A9DB
		public virtual void SetFileName(string _arg)
		{
			vtkXMLParser.vtkXMLParser_SetFileName_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06004A88 RID: 19080
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLParser_SetIgnoreCharacterData_20(HandleRef pThis, int _arg);

		/// <summary>
		/// If this is off (the default), CharacterDataHandler will be called to
		/// process text within XML Elements. If this is on, the text will be
		/// ignored.
		/// </summary>
		// Token: 0x06004A89 RID: 19081 RVA: 0x0006C7EB File Offset: 0x0006A9EB
		public virtual void SetIgnoreCharacterData(int _arg)
		{
			vtkXMLParser.vtkXMLParser_SetIgnoreCharacterData_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06004A8A RID: 19082
		[DllImport("Kitware.VTK.IOXMLParser.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLParser_TellG_21(HandleRef pThis);

		/// <summary>
		/// Used by subclasses and their supporting classes.  These methods
		/// wrap around the tellg and seekg methods of the input stream to
		/// work-around stream bugs on various platforms.
		/// </summary>
		// Token: 0x06004A8B RID: 19083 RVA: 0x0006C7FC File Offset: 0x0006A9FC
		public long TellG()
		{
			return vtkXMLParser.vtkXMLParser_TellG_21(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000755 RID: 1877
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLParser";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000756 RID: 1878
		public new static readonly string MRClassNameKey = "class vtkXMLParser";
	}
}
