using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataWriter
	/// </summary>
	/// <remarks>
	///    helper class for objects that write VTK data files
	///
	/// vtkDataWriter is a helper class that opens and writes the VTK header and
	/// point data (e.g., scalars, vectors, normals, etc.) from a vtk data file.
	/// See the VTK textbook and online resources for various formats.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDataSetWriter vtkPolyDataWriter vtkStructuredGridWriter
	/// vtkStructuredPointsWriter vtkUnstructuredGridWriter
	/// vtkFieldDataWriter vtkRectilinearGridWriter
	/// </seealso>
	// Token: 0x0200015B RID: 347
	public class vtkDataWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004230 RID: 16944 RVA: 0x00061007 File Offset: 0x0005F207
		static vtkDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004231 RID: 16945 RVA: 0x0006102F File Offset: 0x0005F22F
		public vtkDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004232 RID: 16946
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create object with default header, ASCII format, and default names for
		/// scalars, vectors, tensors, normals, and texture coordinates.
		/// </summary>
		// Token: 0x06004233 RID: 16947 RVA: 0x00061040 File Offset: 0x0005F240
		public new static vtkDataWriter New()
		{
			vtkDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataWriter.vtkDataWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create object with default header, ASCII format, and default names for
		/// scalars, vectors, tensors, normals, and texture coordinates.
		/// </summary>
		// Token: 0x06004234 RID: 16948 RVA: 0x00061094 File Offset: 0x0005F294
		public vtkDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataWriter.vtkDataWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004235 RID: 16949 RVA: 0x000610D8 File Offset: 0x0005F2D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004236 RID: 16950
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_GetBinaryOutputString_01(HandleRef pThis);

		/// <summary>
		/// When WriteToOutputString in on, then a string is allocated, written to,
		/// and can be retrieved with these methods.  The string is deleted during
		/// the next call to write ...
		/// </summary>
		// Token: 0x06004237 RID: 16951 RVA: 0x000610E4 File Offset: 0x0005F2E4
		public IntPtr GetBinaryOutputString()
		{
			return vtkDataWriter.vtkDataWriter_GetBinaryOutputString_01(base.GetCppThis());
		}

		// Token: 0x06004238 RID: 16952
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_GetEdgeFlagsName_02(HandleRef pThis);

		/// <summary>
		/// Give a name to the edge flags data. If not specified, uses
		/// default name "edge_flags".
		/// </summary>
		// Token: 0x06004239 RID: 16953 RVA: 0x00061104 File Offset: 0x0005F304
		public virtual string GetEdgeFlagsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetEdgeFlagsName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600423A RID: 16954
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_GetFieldDataName_03(HandleRef pThis);

		/// <summary>
		/// Give a name to the field data. If not specified, uses default
		/// name "field".
		/// </summary>
		// Token: 0x0600423B RID: 16955 RVA: 0x00061140 File Offset: 0x0005F340
		public virtual string GetFieldDataName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetFieldDataName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600423C RID: 16956
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataWriter_GetFileMajorVersion_04(HandleRef pThis);

		/// <summary>
		/// Specify the VTK file version to write. See the enum documentation above
		/// (VTKFileVersion) for additional information about supported versions.
		/// It is possible to get the file major and minor versions separately.  See
		/// also vtkDataReader for related methods. (Note, the parsing of the
		/// FileVersion into major and minor version is as follows: the least
		/// significant digit is the minor version; the remaining digits are the
		/// major version.
		/// </summary>
		// Token: 0x0600423D RID: 16957 RVA: 0x0006117C File Offset: 0x0005F37C
		public virtual int GetFileMajorVersion()
		{
			return vtkDataWriter.vtkDataWriter_GetFileMajorVersion_04(base.GetCppThis());
		}

		// Token: 0x0600423E RID: 16958
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataWriter_GetFileMinorVersion_05(HandleRef pThis);

		/// <summary>
		/// Specify the VTK file version to write. See the enum documentation above
		/// (VTKFileVersion) for additional information about supported versions.
		/// It is possible to get the file major and minor versions separately.  See
		/// also vtkDataReader for related methods. (Note, the parsing of the
		/// FileVersion into major and minor version is as follows: the least
		/// significant digit is the minor version; the remaining digits are the
		/// major version.
		/// </summary>
		// Token: 0x0600423F RID: 16959 RVA: 0x0006119C File Offset: 0x0005F39C
		public virtual int GetFileMinorVersion()
		{
			return vtkDataWriter.vtkDataWriter_GetFileMinorVersion_05(base.GetCppThis());
		}

		// Token: 0x06004240 RID: 16960
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_GetFileName_06(HandleRef pThis);

		/// <summary>
		/// Specify the file name of VTK data file to write.
		/// </summary>
		// Token: 0x06004241 RID: 16961 RVA: 0x000611BC File Offset: 0x0005F3BC
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetFileName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004242 RID: 16962
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataWriter_GetFileType_07(HandleRef pThis);

		/// <summary>
		/// Specify the file type (ASCII or BINARY) of the VTK data file.
		/// </summary>
		// Token: 0x06004243 RID: 16963 RVA: 0x000611F8 File Offset: 0x0005F3F8
		public virtual int GetFileType()
		{
			return vtkDataWriter.vtkDataWriter_GetFileType_07(base.GetCppThis());
		}

		// Token: 0x06004244 RID: 16964
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataWriter_GetFileTypeMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Specify the file type (ASCII or BINARY) of the VTK data file.
		/// </summary>
		// Token: 0x06004245 RID: 16965 RVA: 0x00061218 File Offset: 0x0005F418
		public virtual int GetFileTypeMaxValue()
		{
			return vtkDataWriter.vtkDataWriter_GetFileTypeMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06004246 RID: 16966
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataWriter_GetFileTypeMinValue_09(HandleRef pThis);

		/// <summary>
		/// Specify the file type (ASCII or BINARY) of the VTK data file.
		/// </summary>
		// Token: 0x06004247 RID: 16967 RVA: 0x00061238 File Offset: 0x0005F438
		public virtual int GetFileTypeMinValue()
		{
			return vtkDataWriter.vtkDataWriter_GetFileTypeMinValue_09(base.GetCppThis());
		}

		// Token: 0x06004248 RID: 16968
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataWriter_GetFileVersion_10(HandleRef pThis);

		/// <summary>
		/// Specify the VTK file version to write. See the enum documentation above
		/// (VTKFileVersion) for additional information about supported versions.
		/// It is possible to get the file major and minor versions separately.  See
		/// also vtkDataReader for related methods. (Note, the parsing of the
		/// FileVersion into major and minor version is as follows: the least
		/// significant digit is the minor version; the remaining digits are the
		/// major version.
		/// </summary>
		// Token: 0x06004249 RID: 16969 RVA: 0x00061258 File Offset: 0x0005F458
		public virtual int GetFileVersion()
		{
			return vtkDataWriter.vtkDataWriter_GetFileVersion_10(base.GetCppThis());
		}

		// Token: 0x0600424A RID: 16970
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_GetGlobalIdsName_11(HandleRef pThis);

		/// <summary>
		/// Give a name to the global ids data. If not specified, uses
		/// default name "global_ids".
		/// </summary>
		// Token: 0x0600424B RID: 16971 RVA: 0x00061278 File Offset: 0x0005F478
		public virtual string GetGlobalIdsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetGlobalIdsName_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600424C RID: 16972
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_GetHeader_12(HandleRef pThis);

		/// <summary>
		/// Specify the header for the VTK data file.
		/// </summary>
		// Token: 0x0600424D RID: 16973 RVA: 0x000612B4 File Offset: 0x0005F4B4
		public virtual string GetHeader()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetHeader_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600424E RID: 16974
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_GetLookupTableName_13(HandleRef pThis);

		/// <summary>
		/// Give a name to the lookup table. If not specified, uses default
		/// name "lookupTable".
		/// </summary>
		// Token: 0x0600424F RID: 16975 RVA: 0x000612F0 File Offset: 0x0005F4F0
		public virtual string GetLookupTableName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetLookupTableName_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004250 RID: 16976
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_GetNormalsName_14(HandleRef pThis);

		/// <summary>
		/// Give a name to the normals data. If not specified, uses default
		/// name "normals".
		/// </summary>
		// Token: 0x06004251 RID: 16977 RVA: 0x0006132C File Offset: 0x0005F52C
		public virtual string GetNormalsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetNormalsName_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004252 RID: 16978
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataWriter_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x06004253 RID: 16979 RVA: 0x00061368 File Offset: 0x0005F568
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataWriter.vtkDataWriter_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x06004254 RID: 16980
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataWriter_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x06004255 RID: 16981 RVA: 0x00061388 File Offset: 0x0005F588
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataWriter.vtkDataWriter_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x06004256 RID: 16982
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDataWriter_GetOutputStdString_17(HandleRef pThis);

		/// <summary>
		/// When WriteToOutputString is on, this method returns a copy of the
		/// output string in a vtkStdString.
		/// </summary>
		// Token: 0x06004257 RID: 16983 RVA: 0x000613A4 File Offset: 0x0005F5A4
		public string GetOutputStdString()
		{
			return vtkDataWriter.vtkDataWriter_GetOutputStdString_17(base.GetCppThis());
		}

		// Token: 0x06004258 RID: 16984
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_GetOutputString_18(HandleRef pThis);

		/// <summary>
		/// When WriteToOutputString in on, then a string is allocated, written to,
		/// and can be retrieved with these methods.  The string is deleted during
		/// the next call to write ...
		/// </summary>
		// Token: 0x06004259 RID: 16985 RVA: 0x000613C4 File Offset: 0x0005F5C4
		public virtual string GetOutputString()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetOutputString_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600425A RID: 16986
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataWriter_GetOutputStringLength_19(HandleRef pThis);

		/// <summary>
		/// When WriteToOutputString in on, then a string is allocated, written to,
		/// and can be retrieved with these methods.  The string is deleted during
		/// the next call to write ...
		/// </summary>
		// Token: 0x0600425B RID: 16987 RVA: 0x00061400 File Offset: 0x0005F600
		public virtual long GetOutputStringLength()
		{
			return vtkDataWriter.vtkDataWriter_GetOutputStringLength_19(base.GetCppThis());
		}

		// Token: 0x0600425C RID: 16988
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_GetPedigreeIdsName_20(HandleRef pThis);

		/// <summary>
		/// Give a name to the pedigree ids data. If not specified, uses
		/// default name "pedigree_ids".
		/// </summary>
		// Token: 0x0600425D RID: 16989 RVA: 0x00061420 File Offset: 0x0005F620
		public virtual string GetPedigreeIdsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetPedigreeIdsName_20(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600425E RID: 16990
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_GetScalarsName_21(HandleRef pThis);

		/// <summary>
		/// Give a name to the scalar data. If not specified, uses default
		/// name "scalars".
		/// </summary>
		// Token: 0x0600425F RID: 16991 RVA: 0x0006145C File Offset: 0x0005F65C
		public virtual string GetScalarsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetScalarsName_21(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004260 RID: 16992
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_GetTCoordsName_22(HandleRef pThis);

		/// <summary>
		/// Give a name to the texture coordinates data. If not specified, uses
		/// default name "textureCoords".
		/// </summary>
		// Token: 0x06004261 RID: 16993 RVA: 0x00061498 File Offset: 0x0005F698
		public virtual string GetTCoordsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetTCoordsName_22(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004262 RID: 16994
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_GetTensorsName_23(HandleRef pThis);

		/// <summary>
		/// Give a name to the tensors data. If not specified, uses default
		/// name "tensors".
		/// </summary>
		// Token: 0x06004263 RID: 16995 RVA: 0x000614D4 File Offset: 0x0005F6D4
		public virtual string GetTensorsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetTensorsName_23(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004264 RID: 16996
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_GetVectorsName_24(HandleRef pThis);

		/// <summary>
		/// Give a name to the vector data. If not specified, uses default
		/// name "vectors".
		/// </summary>
		// Token: 0x06004265 RID: 16997 RVA: 0x00061510 File Offset: 0x0005F710
		public virtual string GetVectorsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetVectorsName_24(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004266 RID: 16998
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataWriter_GetWriteArrayMetaData_25(HandleRef pThis);

		/// <summary>
		/// If true, vtkInformation objects attached to arrays and array component
		/// nameswill be written to the output. The default is true.
		/// </summary>
		// Token: 0x06004267 RID: 16999 RVA: 0x0006154C File Offset: 0x0005F74C
		public virtual bool GetWriteArrayMetaData()
		{
			return vtkDataWriter.vtkDataWriter_GetWriteArrayMetaData_25(base.GetCppThis()) != 0;
		}

		// Token: 0x06004268 RID: 17000
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataWriter_GetWriteToOutputString_26(HandleRef pThis);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// </summary>
		// Token: 0x06004269 RID: 17001 RVA: 0x00061574 File Offset: 0x0005F774
		public virtual int GetWriteToOutputString()
		{
			return vtkDataWriter.vtkDataWriter_GetWriteToOutputString_26(base.GetCppThis());
		}

		// Token: 0x0600426A RID: 17002
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataWriter_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600426B RID: 17003 RVA: 0x00061594 File Offset: 0x0005F794
		public override int IsA(string type)
		{
			return vtkDataWriter.vtkDataWriter_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x0600426C RID: 17004
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataWriter_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600426D RID: 17005 RVA: 0x000615B4 File Offset: 0x0005F7B4
		public new static int IsTypeOf(string type)
		{
			return vtkDataWriter.vtkDataWriter_IsTypeOf_28(type);
		}

		// Token: 0x0600426E RID: 17006
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600426F RID: 17007 RVA: 0x000615D0 File Offset: 0x0005F7D0
		public new vtkDataWriter NewInstance()
		{
			vtkDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataWriter.vtkDataWriter_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004270 RID: 17008
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_RegisterAndGetOutputString_31(HandleRef pThis);

		/// <summary>
		/// This convenience method returns the string, sets the IVAR to nullptr,
		/// so that the user is responsible for deleting the string.
		/// I am not sure what the name should be, so it may change in the future.
		/// </summary>
		// Token: 0x06004271 RID: 17009 RVA: 0x0006162C File Offset: 0x0005F82C
		public string RegisterAndGetOutputString()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_RegisterAndGetOutputString_31(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004272 RID: 17010
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataWriter_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x06004273 RID: 17011 RVA: 0x00061668 File Offset: 0x0005F868
		public new static vtkDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkDataWriter vtkDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataWriter.vtkDataWriter_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataWriter = (vtkDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataWriter.Register(null);
				}
			}
			return vtkDataWriter;
		}

		// Token: 0x06004274 RID: 17012
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetEdgeFlagsName_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Give a name to the edge flags data. If not specified, uses
		/// default name "edge_flags".
		/// </summary>
		// Token: 0x06004275 RID: 17013 RVA: 0x000616E7 File Offset: 0x0005F8E7
		public virtual void SetEdgeFlagsName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetEdgeFlagsName_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06004276 RID: 17014
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetFieldDataName_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Give a name to the field data. If not specified, uses default
		/// name "field".
		/// </summary>
		// Token: 0x06004277 RID: 17015 RVA: 0x000616F7 File Offset: 0x0005F8F7
		public virtual void SetFieldDataName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetFieldDataName_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06004278 RID: 17016
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetFileName_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the file name of VTK data file to write.
		/// </summary>
		// Token: 0x06004279 RID: 17017 RVA: 0x00061707 File Offset: 0x0005F907
		public virtual void SetFileName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetFileName_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600427A RID: 17018
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetFileType_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the file type (ASCII or BINARY) of the VTK data file.
		/// </summary>
		// Token: 0x0600427B RID: 17019 RVA: 0x00061717 File Offset: 0x0005F917
		public virtual void SetFileType(int _arg)
		{
			vtkDataWriter.vtkDataWriter_SetFileType_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600427C RID: 17020
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetFileTypeToASCII_37(HandleRef pThis);

		/// <summary>
		/// Specify the file type (ASCII or BINARY) of the VTK data file.
		/// </summary>
		// Token: 0x0600427D RID: 17021 RVA: 0x00061727 File Offset: 0x0005F927
		public void SetFileTypeToASCII()
		{
			vtkDataWriter.vtkDataWriter_SetFileTypeToASCII_37(base.GetCppThis());
		}

		// Token: 0x0600427E RID: 17022
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetFileTypeToBinary_38(HandleRef pThis);

		/// <summary>
		/// Specify the file type (ASCII or BINARY) of the VTK data file.
		/// </summary>
		// Token: 0x0600427F RID: 17023 RVA: 0x00061736 File Offset: 0x0005F936
		public void SetFileTypeToBinary()
		{
			vtkDataWriter.vtkDataWriter_SetFileTypeToBinary_38(base.GetCppThis());
		}

		// Token: 0x06004280 RID: 17024
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetFileVersion_39(HandleRef pThis, int arg0);

		/// <summary>
		/// Specify the VTK file version to write. See the enum documentation above
		/// (VTKFileVersion) for additional information about supported versions.
		/// It is possible to get the file major and minor versions separately.  See
		/// also vtkDataReader for related methods. (Note, the parsing of the
		/// FileVersion into major and minor version is as follows: the least
		/// significant digit is the minor version; the remaining digits are the
		/// major version.
		/// </summary>
		// Token: 0x06004281 RID: 17025 RVA: 0x00061745 File Offset: 0x0005F945
		public void SetFileVersion(int arg0)
		{
			vtkDataWriter.vtkDataWriter_SetFileVersion_39(base.GetCppThis(), arg0);
		}

		// Token: 0x06004282 RID: 17026
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetGlobalIdsName_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Give a name to the global ids data. If not specified, uses
		/// default name "global_ids".
		/// </summary>
		// Token: 0x06004283 RID: 17027 RVA: 0x00061755 File Offset: 0x0005F955
		public virtual void SetGlobalIdsName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetGlobalIdsName_40(base.GetCppThis(), _arg);
		}

		// Token: 0x06004284 RID: 17028
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetHeader_41(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the header for the VTK data file.
		/// </summary>
		// Token: 0x06004285 RID: 17029 RVA: 0x00061765 File Offset: 0x0005F965
		public virtual void SetHeader(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetHeader_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06004286 RID: 17030
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetLookupTableName_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Give a name to the lookup table. If not specified, uses default
		/// name "lookupTable".
		/// </summary>
		// Token: 0x06004287 RID: 17031 RVA: 0x00061775 File Offset: 0x0005F975
		public virtual void SetLookupTableName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetLookupTableName_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06004288 RID: 17032
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetNormalsName_43(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Give a name to the normals data. If not specified, uses default
		/// name "normals".
		/// </summary>
		// Token: 0x06004289 RID: 17033 RVA: 0x00061785 File Offset: 0x0005F985
		public virtual void SetNormalsName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetNormalsName_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0600428A RID: 17034
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetPedigreeIdsName_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Give a name to the pedigree ids data. If not specified, uses
		/// default name "pedigree_ids".
		/// </summary>
		// Token: 0x0600428B RID: 17035 RVA: 0x00061795 File Offset: 0x0005F995
		public virtual void SetPedigreeIdsName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetPedigreeIdsName_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600428C RID: 17036
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetScalarsName_45(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Give a name to the scalar data. If not specified, uses default
		/// name "scalars".
		/// </summary>
		// Token: 0x0600428D RID: 17037 RVA: 0x000617A5 File Offset: 0x0005F9A5
		public virtual void SetScalarsName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetScalarsName_45(base.GetCppThis(), _arg);
		}

		// Token: 0x0600428E RID: 17038
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetTCoordsName_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Give a name to the texture coordinates data. If not specified, uses
		/// default name "textureCoords".
		/// </summary>
		// Token: 0x0600428F RID: 17039 RVA: 0x000617B5 File Offset: 0x0005F9B5
		public virtual void SetTCoordsName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetTCoordsName_46(base.GetCppThis(), _arg);
		}

		// Token: 0x06004290 RID: 17040
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetTensorsName_47(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Give a name to the tensors data. If not specified, uses default
		/// name "tensors".
		/// </summary>
		// Token: 0x06004291 RID: 17041 RVA: 0x000617C5 File Offset: 0x0005F9C5
		public virtual void SetTensorsName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetTensorsName_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06004292 RID: 17042
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetVectorsName_48(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Give a name to the vector data. If not specified, uses default
		/// name "vectors".
		/// </summary>
		// Token: 0x06004293 RID: 17043 RVA: 0x000617D5 File Offset: 0x0005F9D5
		public virtual void SetVectorsName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetVectorsName_48(base.GetCppThis(), _arg);
		}

		// Token: 0x06004294 RID: 17044
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetWriteArrayMetaData_49(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true, vtkInformation objects attached to arrays and array component
		/// nameswill be written to the output. The default is true.
		/// </summary>
		// Token: 0x06004295 RID: 17045 RVA: 0x000617E5 File Offset: 0x0005F9E5
		public virtual void SetWriteArrayMetaData(bool _arg)
		{
			vtkDataWriter.vtkDataWriter_SetWriteArrayMetaData_49(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06004296 RID: 17046
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_SetWriteToOutputString_50(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// </summary>
		// Token: 0x06004297 RID: 17047 RVA: 0x000617FD File Offset: 0x0005F9FD
		public virtual void SetWriteToOutputString(int _arg)
		{
			vtkDataWriter.vtkDataWriter_SetWriteToOutputString_50(base.GetCppThis(), _arg);
		}

		// Token: 0x06004298 RID: 17048
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_WriteArrayMetaDataOff_51(HandleRef pThis);

		/// <summary>
		/// If true, vtkInformation objects attached to arrays and array component
		/// nameswill be written to the output. The default is true.
		/// </summary>
		// Token: 0x06004299 RID: 17049 RVA: 0x0006180D File Offset: 0x0005FA0D
		public virtual void WriteArrayMetaDataOff()
		{
			vtkDataWriter.vtkDataWriter_WriteArrayMetaDataOff_51(base.GetCppThis());
		}

		// Token: 0x0600429A RID: 17050
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_WriteArrayMetaDataOn_52(HandleRef pThis);

		/// <summary>
		/// If true, vtkInformation objects attached to arrays and array component
		/// nameswill be written to the output. The default is true.
		/// </summary>
		// Token: 0x0600429B RID: 17051 RVA: 0x0006181C File Offset: 0x0005FA1C
		public virtual void WriteArrayMetaDataOn()
		{
			vtkDataWriter.vtkDataWriter_WriteArrayMetaDataOn_52(base.GetCppThis());
		}

		// Token: 0x0600429C RID: 17052
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_WriteToOutputStringOff_53(HandleRef pThis);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// </summary>
		// Token: 0x0600429D RID: 17053 RVA: 0x0006182B File Offset: 0x0005FA2B
		public virtual void WriteToOutputStringOff()
		{
			vtkDataWriter.vtkDataWriter_WriteToOutputStringOff_53(base.GetCppThis());
		}

		// Token: 0x0600429E RID: 17054
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataWriter_WriteToOutputStringOn_54(HandleRef pThis);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// </summary>
		// Token: 0x0600429F RID: 17055 RVA: 0x0006183A File Offset: 0x0005FA3A
		public virtual void WriteToOutputStringOn()
		{
			vtkDataWriter.vtkDataWriter_WriteToOutputStringOn_54(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006FB RID: 1787
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006FC RID: 1788
		public new static readonly string MRClassNameKey = "class vtkDataWriter";

		/// <summary>
		/// Specify the file name of VTK data file to write.
		/// </summary>
		// Token: 0x0200015C RID: 348
		public enum VTKFileVersion
		{
			/// <summary>enum member</summary>
			// Token: 0x040006FE RID: 1790
			VTK_LEGACY_READER_VERSION_4_2 = 42,
			/// <summary>enum member</summary>
			// Token: 0x040006FF RID: 1791
			VTK_LEGACY_READER_VERSION_5_1 = 51
		}
	}
}
