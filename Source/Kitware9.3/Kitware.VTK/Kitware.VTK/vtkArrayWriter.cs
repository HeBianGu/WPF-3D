using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkArrayWriter
	/// </summary>
	/// <remarks>
	///    Serialize sparse and dense arrays to a file or stream.
	///
	///
	/// vtkArrayWriter serializes sparse and dense array data using a text-based
	/// format that is human-readable and easily parsed (default option).  The
	/// WriteBinary array option can be used to serialize the sparse and dense array data
	/// using a binary format that is optimized for rapid throughput.
	///
	/// vtkArrayWriter can be used in two distinct ways: first, it can be used as a
	/// normal pipeline filter, which writes its inputs to a file.  Alternatively, static
	/// methods are provided for writing vtkArray instances to files or arbitrary c++
	/// streams.
	///
	/// Inputs:
	///   Input port 0: (required) vtkArrayData object containing a single sparse or dense
	///                            array.
	///
	/// Output Format:
	///   See http://www.kitware.com/InfovisWiki/index.php/N-Way_Array_File_Formats for
	///   details on how vtkArrayWriter encodes data.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkArrayReader
	///
	/// @par Thanks:
	/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
	/// </seealso>
	// Token: 0x0200071F RID: 1823
	public class vtkArrayWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601314D RID: 78157 RVA: 0x001AF6E3 File Offset: 0x001AD8E3
		static vtkArrayWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601314E RID: 78158 RVA: 0x001AF70B File Offset: 0x001AD90B
		public vtkArrayWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601314F RID: 78159
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013150 RID: 78160 RVA: 0x001AF71C File Offset: 0x001AD91C
		public new static vtkArrayWriter New()
		{
			vtkArrayWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayWriter.vtkArrayWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013151 RID: 78161 RVA: 0x001AF770 File Offset: 0x001AD970
		public vtkArrayWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkArrayWriter.vtkArrayWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013152 RID: 78162 RVA: 0x001AF7B4 File Offset: 0x001AD9B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013153 RID: 78163
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayWriter_BinaryOff_01(HandleRef pThis);

		/// <summary>
		/// Get / set whether data will be written in binary format (when used as a filter).
		/// </summary>
		// Token: 0x06013154 RID: 78164 RVA: 0x001AF7BF File Offset: 0x001AD9BF
		public virtual void BinaryOff()
		{
			vtkArrayWriter.vtkArrayWriter_BinaryOff_01(base.GetCppThis());
		}

		// Token: 0x06013155 RID: 78165
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayWriter_BinaryOn_02(HandleRef pThis);

		/// <summary>
		/// Get / set whether data will be written in binary format (when used as a filter).
		/// </summary>
		// Token: 0x06013156 RID: 78166 RVA: 0x001AF7CE File Offset: 0x001AD9CE
		public virtual void BinaryOn()
		{
			vtkArrayWriter.vtkArrayWriter_BinaryOn_02(base.GetCppThis());
		}

		// Token: 0x06013157 RID: 78167
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayWriter_GetBinary_03(HandleRef pThis);

		/// <summary>
		/// Get / set whether data will be written in binary format (when used as a filter).
		/// </summary>
		// Token: 0x06013158 RID: 78168 RVA: 0x001AF7E0 File Offset: 0x001AD9E0
		public virtual int GetBinary()
		{
			return vtkArrayWriter.vtkArrayWriter_GetBinary_03(base.GetCppThis());
		}

		// Token: 0x06013159 RID: 78169
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayWriter_GetFileName_04(HandleRef pThis);

		/// <summary>
		/// Get / set the filename where data will be stored (when used as a filter).
		/// </summary>
		// Token: 0x0601315A RID: 78170 RVA: 0x001AF800 File Offset: 0x001ADA00
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayWriter.vtkArrayWriter_GetFileName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601315B RID: 78171
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayWriter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601315C RID: 78172 RVA: 0x001AF83C File Offset: 0x001ADA3C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkArrayWriter.vtkArrayWriter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601315D RID: 78173
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayWriter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601315E RID: 78174 RVA: 0x001AF85C File Offset: 0x001ADA5C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkArrayWriter.vtkArrayWriter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601315F RID: 78175
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkArrayWriter_GetOutputString_07(HandleRef pThis);

		/// <summary>
		/// The output string. This is only set when WriteToOutputString is set.
		/// </summary>
		// Token: 0x06013160 RID: 78176 RVA: 0x001AF878 File Offset: 0x001ADA78
		public virtual string GetOutputString()
		{
			return vtkArrayWriter.vtkArrayWriter_GetOutputString_07(base.GetCppThis());
		}

		// Token: 0x06013161 RID: 78177
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkArrayWriter_GetWriteToOutputString_08(HandleRef pThis);

		/// <summary>
		/// Whether to output to a string instead of to a file, which is the default.
		/// </summary>
		// Token: 0x06013162 RID: 78178 RVA: 0x001AF898 File Offset: 0x001ADA98
		public virtual bool GetWriteToOutputString()
		{
			return vtkArrayWriter.vtkArrayWriter_GetWriteToOutputString_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06013163 RID: 78179
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayWriter_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013164 RID: 78180 RVA: 0x001AF8C0 File Offset: 0x001ADAC0
		public override int IsA(string type)
		{
			return vtkArrayWriter.vtkArrayWriter_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06013165 RID: 78181
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayWriter_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013166 RID: 78182 RVA: 0x001AF8E0 File Offset: 0x001ADAE0
		public new static int IsTypeOf(string type)
		{
			return vtkArrayWriter.vtkArrayWriter_IsTypeOf_10(type);
		}

		// Token: 0x06013167 RID: 78183
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayWriter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013168 RID: 78184 RVA: 0x001AF8FC File Offset: 0x001ADAFC
		public new vtkArrayWriter NewInstance()
		{
			vtkArrayWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayWriter.vtkArrayWriter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013169 RID: 78185
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayWriter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601316A RID: 78186 RVA: 0x001AF958 File Offset: 0x001ADB58
		public new static vtkArrayWriter SafeDownCast(vtkObjectBase o)
		{
			vtkArrayWriter vtkArrayWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayWriter.vtkArrayWriter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayWriter = (vtkArrayWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayWriter.Register(null);
				}
			}
			return vtkArrayWriter;
		}

		// Token: 0x0601316B RID: 78187
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayWriter_SetBinary_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Get / set whether data will be written in binary format (when used as a filter).
		/// </summary>
		// Token: 0x0601316C RID: 78188 RVA: 0x001AF9D7 File Offset: 0x001ADBD7
		public virtual void SetBinary(int _arg)
		{
			vtkArrayWriter.vtkArrayWriter_SetBinary_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0601316D RID: 78189
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayWriter_SetFileName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get / set the filename where data will be stored (when used as a filter).
		/// </summary>
		// Token: 0x0601316E RID: 78190 RVA: 0x001AF9E7 File Offset: 0x001ADBE7
		public virtual void SetFileName(string _arg)
		{
			vtkArrayWriter.vtkArrayWriter_SetFileName_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0601316F RID: 78191
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayWriter_SetWriteToOutputString_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to output to a string instead of to a file, which is the default.
		/// </summary>
		// Token: 0x06013170 RID: 78192 RVA: 0x001AF9F7 File Offset: 0x001ADBF7
		public virtual void SetWriteToOutputString(bool _arg)
		{
			vtkArrayWriter.vtkArrayWriter_SetWriteToOutputString_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06013171 RID: 78193
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayWriter_Write_17(HandleRef pThis);

		/// <summary>
		/// Whether to output to a string instead of to a file, which is the default.
		/// </summary>
		// Token: 0x06013172 RID: 78194 RVA: 0x001AFA10 File Offset: 0x001ADC10
		public override int Write()
		{
			return vtkArrayWriter.vtkArrayWriter_Write_17(base.GetCppThis());
		}

		// Token: 0x06013173 RID: 78195
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkArrayWriter_Write_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string FileName, byte WriteBinary);

		/// <summary>
		/// Writes input port 0 data to a file, using an arbitrary filename and binary flag.
		/// </summary>
		// Token: 0x06013174 RID: 78196 RVA: 0x001AFA30 File Offset: 0x001ADC30
		public bool Write(string FileName, bool WriteBinary)
		{
			return vtkArrayWriter.vtkArrayWriter_Write_18(base.GetCppThis(), FileName, WriteBinary ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x06013175 RID: 78197
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkArrayWriter_Write_19(HandleRef array, [MarshalAs(UnmanagedType.LPUTF8Str)] string file_name, byte WriteBinary);

		/// <summary>
		/// Write an arbitrary array to a file, without using the pipeline.
		/// </summary>
		// Token: 0x06013176 RID: 78198 RVA: 0x001AFA60 File Offset: 0x001ADC60
		public static bool Write(vtkArray array, string file_name, bool WriteBinary)
		{
			return vtkArrayWriter.vtkArrayWriter_Write_19((array == null) ? default(HandleRef) : array.GetCppThis(), file_name, WriteBinary ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x06013177 RID: 78199
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkArrayWriter_Write_20(HandleRef pThis, byte WriteBinary);

		/// <summary>
		/// Write input port 0 data to a string. Note that the WriteBinary argument is not
		/// optional in order to not clash with the inherited Write() method.
		/// </summary>
		// Token: 0x06013178 RID: 78200 RVA: 0x001AFAA0 File Offset: 0x001ADCA0
		public string Write(bool WriteBinary)
		{
			return vtkArrayWriter.vtkArrayWriter_Write_20(base.GetCppThis(), WriteBinary ? (byte)1 : (byte)0);
		}

		// Token: 0x06013179 RID: 78201
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkArrayWriter_Write_21(HandleRef array, byte WriteBinary);

		/// <summary>
		/// Write arbitrary data to a string without using the pipeline.
		/// </summary>
		// Token: 0x0601317A RID: 78202 RVA: 0x001AFAC8 File Offset: 0x001ADCC8
		public static string Write(vtkArray array, bool WriteBinary)
		{
			return vtkArrayWriter.vtkArrayWriter_Write_21((array == null) ? default(HandleRef) : array.GetCppThis(), WriteBinary ? (byte)1 : (byte)0);
		}

		// Token: 0x0601317B RID: 78203
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayWriter_WriteToOutputStringOff_22(HandleRef pThis);

		/// <summary>
		/// Whether to output to a string instead of to a file, which is the default.
		/// </summary>
		// Token: 0x0601317C RID: 78204 RVA: 0x001AFAFF File Offset: 0x001ADCFF
		public virtual void WriteToOutputStringOff()
		{
			vtkArrayWriter.vtkArrayWriter_WriteToOutputStringOff_22(base.GetCppThis());
		}

		// Token: 0x0601317D RID: 78205
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayWriter_WriteToOutputStringOn_23(HandleRef pThis);

		/// <summary>
		/// Whether to output to a string instead of to a file, which is the default.
		/// </summary>
		// Token: 0x0601317E RID: 78206 RVA: 0x001AFB0E File Offset: 0x001ADD0E
		public virtual void WriteToOutputStringOn()
		{
			vtkArrayWriter.vtkArrayWriter_WriteToOutputStringOn_23(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400160A RID: 5642
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400160B RID: 5643
		public new static readonly string MRClassNameKey = "class vtkArrayWriter";
	}
}
