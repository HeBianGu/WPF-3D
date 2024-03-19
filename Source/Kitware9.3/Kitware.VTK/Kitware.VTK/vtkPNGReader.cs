using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPNGReader
	/// </summary>
	/// <remarks>
	///    read PNG files
	///
	/// vtkPNGReader is a source object that reads PNG files.
	/// It should be able to read most any PNG file
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPNGWriter
	/// </seealso>
	// Token: 0x0200079C RID: 1948
	public class vtkPNGReader : vtkImageReader2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601400E RID: 81934 RVA: 0x001C4143 File Offset: 0x001C2343
		static vtkPNGReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPNGReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPNGReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601400F RID: 81935 RVA: 0x001C416B File Offset: 0x001C236B
		public vtkPNGReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014010 RID: 81936
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNGReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014011 RID: 81937 RVA: 0x001C417C File Offset: 0x001C237C
		public new static vtkPNGReader New()
		{
			vtkPNGReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPNGReader.vtkPNGReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPNGReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014012 RID: 81938 RVA: 0x001C41D0 File Offset: 0x001C23D0
		public vtkPNGReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPNGReader.vtkPNGReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014013 RID: 81939 RVA: 0x001C4214 File Offset: 0x001C2414
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014014 RID: 81940
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPNGReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Is the given file a PNG file?
		/// </summary>
		// Token: 0x06014015 RID: 81941 RVA: 0x001C4220 File Offset: 0x001C2420
		public override int CanReadFile(string fname)
		{
			return vtkPNGReader.vtkPNGReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		// Token: 0x06014016 RID: 81942
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNGReader_GetDescriptiveName_02(HandleRef pThis);

		/// <summary>
		/// Return a descriptive name for the file format that might be useful in a GUI.
		/// </summary>
		// Token: 0x06014017 RID: 81943 RVA: 0x001C4240 File Offset: 0x001C2440
		public override string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkPNGReader.vtkPNGReader_GetDescriptiveName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014018 RID: 81944
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNGReader_GetFileExtensions_03(HandleRef pThis);

		/// <summary>
		/// Get the file extensions for this format.
		/// Returns a string with a space separated list of extensions in
		/// the format .extension
		/// </summary>
		// Token: 0x06014019 RID: 81945 RVA: 0x001C427C File Offset: 0x001C247C
		public override string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkPNGReader.vtkPNGReader_GetFileExtensions_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601401A RID: 81946
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPNGReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601401B RID: 81947 RVA: 0x001C42B8 File Offset: 0x001C24B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPNGReader.vtkPNGReader_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601401C RID: 81948
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPNGReader_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601401D RID: 81949 RVA: 0x001C42D8 File Offset: 0x001C24D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPNGReader.vtkPNGReader_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601401E RID: 81950
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPNGReader_GetNumberOfTextChunks_06(HandleRef pThis);

		/// <summary>
		/// Return the number of text chunks in the PNG file.
		/// Note that we don't process compressed or international text entries
		/// </summary>
		// Token: 0x0601401F RID: 81951 RVA: 0x001C42F4 File Offset: 0x001C24F4
		public ulong GetNumberOfTextChunks()
		{
			return vtkPNGReader.vtkPNGReader_GetNumberOfTextChunks_06(base.GetCppThis());
		}

		// Token: 0x06014020 RID: 81952
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPNGReader_GetReadSpacingFromFile_07(HandleRef pThis);

		/// <summary>
		/// Set/Get if data spacing should be calculated from the PNG file.
		/// Use default spacing if the PNG file don't have valid pixel per meter parameters.
		/// Default is false.
		/// </summary>
		// Token: 0x06014021 RID: 81953 RVA: 0x001C4314 File Offset: 0x001C2514
		public virtual bool GetReadSpacingFromFile()
		{
			return vtkPNGReader.vtkPNGReader_GetReadSpacingFromFile_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06014022 RID: 81954
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPNGReader_GetTextChunks_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string key, IntPtr beginEndIndex);

		/// <summary>
		/// Given a 'key' for the text chunks, fills in 'beginEndIndex'
		/// with the begin and end indexes. Values are stored between
		/// [begin, end) indexes.
		/// </summary>
		// Token: 0x06014023 RID: 81955 RVA: 0x001C433A File Offset: 0x001C253A
		public void GetTextChunks(string key, IntPtr beginEndIndex)
		{
			vtkPNGReader.vtkPNGReader_GetTextChunks_08(base.GetCppThis(), key, beginEndIndex);
		}

		// Token: 0x06014024 RID: 81956
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNGReader_GetTextKey_09(HandleRef pThis, int index);

		/// <summary>
		/// Returns the text key stored at 'index'.
		/// </summary>
		// Token: 0x06014025 RID: 81957 RVA: 0x001C434C File Offset: 0x001C254C
		public string GetTextKey(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkPNGReader.vtkPNGReader_GetTextKey_09(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014026 RID: 81958
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNGReader_GetTextKeys_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the text key stored at 'index'.
		/// </summary>
		// Token: 0x06014027 RID: 81959 RVA: 0x001C4388 File Offset: 0x001C2588
		public vtkStringArray GetTextKeys()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPNGReader.vtkPNGReader_GetTextKeys_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x06014028 RID: 81960
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNGReader_GetTextValue_11(HandleRef pThis, int index);

		/// <summary>
		/// Returns the text value stored at 'index'. A range of indexes
		/// that store values for a certain key can be obtained by calling
		/// GetTextChunks.
		/// </summary>
		// Token: 0x06014029 RID: 81961 RVA: 0x001C43F8 File Offset: 0x001C25F8
		public string GetTextValue(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkPNGReader.vtkPNGReader_GetTextValue_11(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601402A RID: 81962
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNGReader_GetTextValues_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the text value stored at 'index'. A range of indexes
		/// that store values for a certain key can be obtained by calling
		/// GetTextChunks.
		/// </summary>
		// Token: 0x0601402B RID: 81963 RVA: 0x001C4434 File Offset: 0x001C2634
		public vtkStringArray GetTextValues()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPNGReader.vtkPNGReader_GetTextValues_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x0601402C RID: 81964
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPNGReader_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601402D RID: 81965 RVA: 0x001C44A4 File Offset: 0x001C26A4
		public override int IsA(string type)
		{
			return vtkPNGReader.vtkPNGReader_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0601402E RID: 81966
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPNGReader_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601402F RID: 81967 RVA: 0x001C44C4 File Offset: 0x001C26C4
		public new static int IsTypeOf(string type)
		{
			return vtkPNGReader.vtkPNGReader_IsTypeOf_14(type);
		}

		// Token: 0x06014030 RID: 81968
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNGReader_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014031 RID: 81969 RVA: 0x001C44E0 File Offset: 0x001C26E0
		public new vtkPNGReader NewInstance()
		{
			vtkPNGReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPNGReader.vtkPNGReader_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPNGReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014032 RID: 81970
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPNGReader_ReadSpacingFromFileOff_17(HandleRef pThis);

		/// <summary>
		/// Set/Get if data spacing should be calculated from the PNG file.
		/// Use default spacing if the PNG file don't have valid pixel per meter parameters.
		/// Default is false.
		/// </summary>
		// Token: 0x06014033 RID: 81971 RVA: 0x001C453A File Offset: 0x001C273A
		public virtual void ReadSpacingFromFileOff()
		{
			vtkPNGReader.vtkPNGReader_ReadSpacingFromFileOff_17(base.GetCppThis());
		}

		// Token: 0x06014034 RID: 81972
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPNGReader_ReadSpacingFromFileOn_18(HandleRef pThis);

		/// <summary>
		/// Set/Get if data spacing should be calculated from the PNG file.
		/// Use default spacing if the PNG file don't have valid pixel per meter parameters.
		/// Default is false.
		/// </summary>
		// Token: 0x06014035 RID: 81973 RVA: 0x001C4549 File Offset: 0x001C2749
		public virtual void ReadSpacingFromFileOn()
		{
			vtkPNGReader.vtkPNGReader_ReadSpacingFromFileOn_18(base.GetCppThis());
		}

		// Token: 0x06014036 RID: 81974
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNGReader_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014037 RID: 81975 RVA: 0x001C4558 File Offset: 0x001C2758
		public new static vtkPNGReader SafeDownCast(vtkObjectBase o)
		{
			vtkPNGReader vtkPNGReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPNGReader.vtkPNGReader_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPNGReader = (vtkPNGReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPNGReader.Register(null);
				}
			}
			return vtkPNGReader;
		}

		// Token: 0x06014038 RID: 81976
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPNGReader_SetReadSpacingFromFile_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if data spacing should be calculated from the PNG file.
		/// Use default spacing if the PNG file don't have valid pixel per meter parameters.
		/// Default is false.
		/// </summary>
		// Token: 0x06014039 RID: 81977 RVA: 0x001C45D7 File Offset: 0x001C27D7
		public virtual void SetReadSpacingFromFile(bool _arg)
		{
			vtkPNGReader.vtkPNGReader_SetReadSpacingFromFile_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001738 RID: 5944
		public new const string MRFullTypeName = "Kitware.VTK.vtkPNGReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001739 RID: 5945
		public new static readonly string MRClassNameKey = "class vtkPNGReader";
	}
}
