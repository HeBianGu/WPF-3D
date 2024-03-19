using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkJSONDataSetWriter
	/// </summary>
	/// <remarks>
	///    write vtkDataSet using a vtkArchiver with a JSON meta file along
	///          with all the binary arrays written as standalone binary files.
	///          The generated format can be used by vtk.js using the reader below
	///          https://kitware.github.io/vtk-js/examples/HttpDataSetReader.html
	///
	/// vtkJSONDataSetWriter writes vtkImageData / vtkPolyData into a set of files
	/// representing each arrays that compose the dataset along with a JSON meta file
	/// that describe what they are and how they should be assembled into an actual
	/// vtkDataSet.
	///
	///
	/// @warning
	/// This writer assume LittleEndian by default. Additional work should be done to
	/// properly
	/// handle endianness.
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkArchiver
	/// </seealso>
	// Token: 0x020001E9 RID: 489
	public class vtkJSONDataSetWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005D1E RID: 23838 RVA: 0x00086EC7 File Offset: 0x000850C7
		static vtkJSONDataSetWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkJSONDataSetWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkJSONDataSetWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005D1F RID: 23839 RVA: 0x00086EEF File Offset: 0x000850EF
		public vtkJSONDataSetWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005D20 RID: 23840
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONDataSetWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// For backwards compatibility, this static method writes a data array's
		/// contents directly to a file.
		/// </summary>
		// Token: 0x06005D21 RID: 23841 RVA: 0x00086F00 File Offset: 0x00085100
		public new static vtkJSONDataSetWriter New()
		{
			vtkJSONDataSetWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJSONDataSetWriter.vtkJSONDataSetWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJSONDataSetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// For backwards compatibility, this static method writes a data array's
		/// contents directly to a file.
		/// </summary>
		// Token: 0x06005D22 RID: 23842 RVA: 0x00086F54 File Offset: 0x00085154
		public vtkJSONDataSetWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkJSONDataSetWriter.vtkJSONDataSetWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005D23 RID: 23843 RVA: 0x00086F98 File Offset: 0x00085198
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005D24 RID: 23844
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONDataSetWriter_ComputeMD5_01(IntPtr content, int size, [MarshalAs(UnmanagedType.LPUTF8Str)] string hash);

		/// <summary>
		/// Compute a MD5 digest of a void/(const unsigned char) pointer to compute a
		///  string hash
		/// </summary>
		// Token: 0x06005D25 RID: 23845 RVA: 0x00086FA3 File Offset: 0x000851A3
		public static void ComputeMD5(IntPtr content, int size, string hash)
		{
			vtkJSONDataSetWriter.vtkJSONDataSetWriter_ComputeMD5_01(content, size, hash);
		}

		// Token: 0x06005D26 RID: 23846
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONDataSetWriter_GetArchiver_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the Scene Archiver object
		/// </summary>
		// Token: 0x06005D27 RID: 23847 RVA: 0x00086FB0 File Offset: 0x000851B0
		public virtual vtkArchiver GetArchiver()
		{
			vtkArchiver vtkArchiver = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJSONDataSetWriter.vtkJSONDataSetWriter_GetArchiver_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArchiver = (vtkArchiver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArchiver.Register(null);
				}
			}
			return vtkArchiver;
		}

		// Token: 0x06005D28 RID: 23848
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONDataSetWriter_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06005D29 RID: 23849 RVA: 0x00087020 File Offset: 0x00085220
		public new vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJSONDataSetWriter.vtkJSONDataSetWriter_GetInput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06005D2A RID: 23850
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONDataSetWriter_GetInput_04(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06005D2B RID: 23851 RVA: 0x00087090 File Offset: 0x00085290
		public new vtkDataSet GetInput(int port)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJSONDataSetWriter.vtkJSONDataSetWriter_GetInput_04(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06005D2C RID: 23852
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkJSONDataSetWriter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// For backwards compatibility, this static method writes a data array's
		/// contents directly to a file.
		/// </summary>
		// Token: 0x06005D2D RID: 23853 RVA: 0x00087100 File Offset: 0x00085300
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkJSONDataSetWriter.vtkJSONDataSetWriter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06005D2E RID: 23854
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkJSONDataSetWriter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// For backwards compatibility, this static method writes a data array's
		/// contents directly to a file.
		/// </summary>
		// Token: 0x06005D2F RID: 23855 RVA: 0x00087120 File Offset: 0x00085320
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkJSONDataSetWriter.vtkJSONDataSetWriter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06005D30 RID: 23856
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkJSONDataSetWriter_GetShortType_07(HandleRef input, ref byte needConversion);

		/// <summary>
		/// Compute the target JavaScript typed array name for the given vtkDataArray
		/// (Uin8, Uint16, Uin32, Int8, Int16, Int32, Float32, Float64) or
		/// "xxx" if no match found
		///
		/// Since Uint64 and Int64 does not exist in JavaScript, the needConversion
		/// argument will be set to true and Uint32/Int32 will be returned instead.
		/// </summary>
		// Token: 0x06005D31 RID: 23857 RVA: 0x0008713C File Offset: 0x0008533C
		public static string GetShortType(vtkDataArray input, ref byte needConversion)
		{
			return vtkJSONDataSetWriter.vtkJSONDataSetWriter_GetShortType_07((input == null) ? default(HandleRef) : input.GetCppThis(), ref needConversion);
		}

		// Token: 0x06005D32 RID: 23858
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkJSONDataSetWriter_GetUID_08(HandleRef arg0, ref byte needConversion);

		/// <summary>
		/// Return a Unique identifier for that array
		/// (i.e.: Float32_356_13f880891af7b77262c49cae09a41e28 )
		/// </summary>
		// Token: 0x06005D33 RID: 23859 RVA: 0x0008716C File Offset: 0x0008536C
		public static string GetUID(vtkDataArray arg0, ref byte needConversion)
		{
			return vtkJSONDataSetWriter.vtkJSONDataSetWriter_GetUID_08((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), ref needConversion);
		}

		// Token: 0x06005D34 RID: 23860
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkJSONDataSetWriter_GetValidString_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Return a Unique identifier for any invalid string
		/// </summary>
		// Token: 0x06005D35 RID: 23861 RVA: 0x0008719C File Offset: 0x0008539C
		public string GetValidString(string arg0)
		{
			return vtkJSONDataSetWriter.vtkJSONDataSetWriter_GetValidString_09(base.GetCppThis(), arg0);
		}

		// Token: 0x06005D36 RID: 23862
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJSONDataSetWriter_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// For backwards compatibility, this static method writes a data array's
		/// contents directly to a file.
		/// </summary>
		// Token: 0x06005D37 RID: 23863 RVA: 0x000871BC File Offset: 0x000853BC
		public override int IsA(string type)
		{
			return vtkJSONDataSetWriter.vtkJSONDataSetWriter_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06005D38 RID: 23864
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkJSONDataSetWriter_IsDataSetValid_11(HandleRef pThis);

		/// <summary>
		/// Specify the Scene Archiver object
		/// </summary>
		// Token: 0x06005D39 RID: 23865 RVA: 0x000871DC File Offset: 0x000853DC
		public bool IsDataSetValid()
		{
			return vtkJSONDataSetWriter.vtkJSONDataSetWriter_IsDataSetValid_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06005D3A RID: 23866
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJSONDataSetWriter_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// For backwards compatibility, this static method writes a data array's
		/// contents directly to a file.
		/// </summary>
		// Token: 0x06005D3B RID: 23867 RVA: 0x00087204 File Offset: 0x00085404
		public new static int IsTypeOf(string type)
		{
			return vtkJSONDataSetWriter.vtkJSONDataSetWriter_IsTypeOf_12(type);
		}

		// Token: 0x06005D3C RID: 23868
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONDataSetWriter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// For backwards compatibility, this static method writes a data array's
		/// contents directly to a file.
		/// </summary>
		// Token: 0x06005D3D RID: 23869 RVA: 0x00087220 File Offset: 0x00085420
		public new vtkJSONDataSetWriter NewInstance()
		{
			vtkJSONDataSetWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJSONDataSetWriter.vtkJSONDataSetWriter_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJSONDataSetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005D3E RID: 23870
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONDataSetWriter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// For backwards compatibility, this static method writes a data array's
		/// contents directly to a file.
		/// </summary>
		// Token: 0x06005D3F RID: 23871 RVA: 0x0008727C File Offset: 0x0008547C
		public new static vtkJSONDataSetWriter SafeDownCast(vtkObjectBase o)
		{
			vtkJSONDataSetWriter vtkJSONDataSetWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJSONDataSetWriter.vtkJSONDataSetWriter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkJSONDataSetWriter = (vtkJSONDataSetWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkJSONDataSetWriter.Register(null);
				}
			}
			return vtkJSONDataSetWriter;
		}

		// Token: 0x06005D40 RID: 23872
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONDataSetWriter_SetArchiver_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the Scene Archiver object
		/// </summary>
		// Token: 0x06005D41 RID: 23873 RVA: 0x000872FC File Offset: 0x000854FC
		public virtual void SetArchiver(vtkArchiver arg0)
		{
			vtkJSONDataSetWriter.vtkJSONDataSetWriter_SetArchiver_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06005D42 RID: 23874
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONDataSetWriter_Write_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the Scene Archiver object
		/// </summary>
		// Token: 0x06005D43 RID: 23875 RVA: 0x0008732C File Offset: 0x0008552C
		public void Write(vtkDataSet arg0)
		{
			vtkJSONDataSetWriter.vtkJSONDataSetWriter_Write_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06005D44 RID: 23876
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkJSONDataSetWriter_WriteArrayAsRAW_18(HandleRef arg0, [MarshalAs(UnmanagedType.LPUTF8Str)] string filePath);

		/// <summary>
		/// For backwards compatibility, this static method writes a data array's
		/// contents directly to a file.
		/// </summary>
		// Token: 0x06005D45 RID: 23877 RVA: 0x0008735C File Offset: 0x0008555C
		public static bool WriteArrayAsRAW(vtkDataArray arg0, string filePath)
		{
			return vtkJSONDataSetWriter.vtkJSONDataSetWriter_WriteArrayAsRAW_18((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), filePath) != 0;
		}

		// Token: 0x06005D46 RID: 23878
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkJSONDataSetWriter_WriteArrayContents_19(HandleRef pThis, HandleRef arg0, [MarshalAs(UnmanagedType.LPUTF8Str)] string relativeFilePath);

		/// <summary>
		/// Write the contents of the vtkDataArray to disk based on the filePath
		/// provided without any extra information. Just the raw data will be
		/// written.
		///
		/// If vtkDataArray is a Uint64 or Int64, the data will be converted
		/// to Uint32 or Int32 before being written.
		/// </summary>
		// Token: 0x06005D47 RID: 23879 RVA: 0x00087394 File Offset: 0x00085594
		public bool WriteArrayContents(vtkDataArray arg0, string relativeFilePath)
		{
			return vtkJSONDataSetWriter.vtkJSONDataSetWriter_WriteArrayContents_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), relativeFilePath) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400089C RID: 2204
		public new const string MRFullTypeName = "Kitware.VTK.vtkJSONDataSetWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400089D RID: 2205
		public new static readonly string MRClassNameKey = "class vtkJSONDataSetWriter";
	}
}
