using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkArrayDataWriter
	/// </summary>
	/// <remarks>
	///    Serialize vtkArrayData to a file or stream.
	///
	///
	/// vtkArrayDataWriter serializes vtkArrayData using a text-based
	/// format that is human-readable and easily parsed (default option).  The
	/// WriteBinary array option can be used to serialize the vtkArrayData
	/// using a binary format that is optimized for rapid throughput.
	///
	/// vtkArrayDataWriter can be used in two distinct ways: first, it can be used as a
	/// normal pipeline filter, which writes its inputs to a file.  Alternatively, static
	/// methods are provided for writing vtkArrayData instances to files or arbitrary c++
	/// streams.
	///
	/// Inputs:
	///   Input port 0: (required) vtkArrayData object.
	///
	/// Output Format:
	///   See http://www.kitware.com/InfovisWiki/index.php/N-Way_Array_File_Formats for
	///   details on how vtkArrayDataWriter encodes data.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkArrayDataReader
	///
	/// @par Thanks:
	/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
	/// </seealso>
	// Token: 0x0200071D RID: 1821
	public class vtkArrayDataWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060130F7 RID: 78071 RVA: 0x001AEF37 File Offset: 0x001AD137
		static vtkArrayDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060130F8 RID: 78072 RVA: 0x001AEF5F File Offset: 0x001AD15F
		public vtkArrayDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060130F9 RID: 78073
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130FA RID: 78074 RVA: 0x001AEF70 File Offset: 0x001AD170
		public new static vtkArrayDataWriter New()
		{
			vtkArrayDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayDataWriter.vtkArrayDataWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130FB RID: 78075 RVA: 0x001AEFC4 File Offset: 0x001AD1C4
		public vtkArrayDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkArrayDataWriter.vtkArrayDataWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060130FC RID: 78076 RVA: 0x001AF008 File Offset: 0x001AD208
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060130FD RID: 78077
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayDataWriter_BinaryOff_01(HandleRef pThis);

		/// <summary>
		/// Get / set whether data will be written in binary format (when used as a filter).
		/// </summary>
		// Token: 0x060130FE RID: 78078 RVA: 0x001AF013 File Offset: 0x001AD213
		public virtual void BinaryOff()
		{
			vtkArrayDataWriter.vtkArrayDataWriter_BinaryOff_01(base.GetCppThis());
		}

		// Token: 0x060130FF RID: 78079
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayDataWriter_BinaryOn_02(HandleRef pThis);

		/// <summary>
		/// Get / set whether data will be written in binary format (when used as a filter).
		/// </summary>
		// Token: 0x06013100 RID: 78080 RVA: 0x001AF022 File Offset: 0x001AD222
		public virtual void BinaryOn()
		{
			vtkArrayDataWriter.vtkArrayDataWriter_BinaryOn_02(base.GetCppThis());
		}

		// Token: 0x06013101 RID: 78081
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayDataWriter_GetBinary_03(HandleRef pThis);

		/// <summary>
		/// Get / set whether data will be written in binary format (when used as a filter).
		/// </summary>
		// Token: 0x06013102 RID: 78082 RVA: 0x001AF034 File Offset: 0x001AD234
		public virtual int GetBinary()
		{
			return vtkArrayDataWriter.vtkArrayDataWriter_GetBinary_03(base.GetCppThis());
		}

		// Token: 0x06013103 RID: 78083
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayDataWriter_GetFileName_04(HandleRef pThis);

		/// <summary>
		/// Get / set the filename where data will be stored (when used as a filter).
		/// </summary>
		// Token: 0x06013104 RID: 78084 RVA: 0x001AF054 File Offset: 0x001AD254
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayDataWriter.vtkArrayDataWriter_GetFileName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013105 RID: 78085
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayDataWriter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013106 RID: 78086 RVA: 0x001AF090 File Offset: 0x001AD290
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkArrayDataWriter.vtkArrayDataWriter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06013107 RID: 78087
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayDataWriter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013108 RID: 78088 RVA: 0x001AF0B0 File Offset: 0x001AD2B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkArrayDataWriter.vtkArrayDataWriter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06013109 RID: 78089
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkArrayDataWriter_GetOutputString_07(HandleRef pThis);

		/// <summary>
		/// The output string. This is only set when WriteToOutputString is set.
		/// </summary>
		// Token: 0x0601310A RID: 78090 RVA: 0x001AF0CC File Offset: 0x001AD2CC
		public virtual string GetOutputString()
		{
			return vtkArrayDataWriter.vtkArrayDataWriter_GetOutputString_07(base.GetCppThis());
		}

		// Token: 0x0601310B RID: 78091
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkArrayDataWriter_GetWriteToOutputString_08(HandleRef pThis);

		/// <summary>
		/// Whether to output to a string instead of to a file, which is the default.
		/// </summary>
		// Token: 0x0601310C RID: 78092 RVA: 0x001AF0EC File Offset: 0x001AD2EC
		public virtual bool GetWriteToOutputString()
		{
			return vtkArrayDataWriter.vtkArrayDataWriter_GetWriteToOutputString_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0601310D RID: 78093
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayDataWriter_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601310E RID: 78094 RVA: 0x001AF114 File Offset: 0x001AD314
		public override int IsA(string type)
		{
			return vtkArrayDataWriter.vtkArrayDataWriter_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601310F RID: 78095
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayDataWriter_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013110 RID: 78096 RVA: 0x001AF134 File Offset: 0x001AD334
		public new static int IsTypeOf(string type)
		{
			return vtkArrayDataWriter.vtkArrayDataWriter_IsTypeOf_10(type);
		}

		// Token: 0x06013111 RID: 78097
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayDataWriter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013112 RID: 78098 RVA: 0x001AF150 File Offset: 0x001AD350
		public new vtkArrayDataWriter NewInstance()
		{
			vtkArrayDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayDataWriter.vtkArrayDataWriter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013113 RID: 78099
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayDataWriter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013114 RID: 78100 RVA: 0x001AF1AC File Offset: 0x001AD3AC
		public new static vtkArrayDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkArrayDataWriter vtkArrayDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayDataWriter.vtkArrayDataWriter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayDataWriter = (vtkArrayDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayDataWriter.Register(null);
				}
			}
			return vtkArrayDataWriter;
		}

		// Token: 0x06013115 RID: 78101
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayDataWriter_SetBinary_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Get / set whether data will be written in binary format (when used as a filter).
		/// </summary>
		// Token: 0x06013116 RID: 78102 RVA: 0x001AF22B File Offset: 0x001AD42B
		public virtual void SetBinary(int _arg)
		{
			vtkArrayDataWriter.vtkArrayDataWriter_SetBinary_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06013117 RID: 78103
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayDataWriter_SetFileName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get / set the filename where data will be stored (when used as a filter).
		/// </summary>
		// Token: 0x06013118 RID: 78104 RVA: 0x001AF23B File Offset: 0x001AD43B
		public virtual void SetFileName(string _arg)
		{
			vtkArrayDataWriter.vtkArrayDataWriter_SetFileName_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06013119 RID: 78105
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayDataWriter_SetWriteToOutputString_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to output to a string instead of to a file, which is the default.
		/// </summary>
		// Token: 0x0601311A RID: 78106 RVA: 0x001AF24B File Offset: 0x001AD44B
		public virtual void SetWriteToOutputString(bool _arg)
		{
			vtkArrayDataWriter.vtkArrayDataWriter_SetWriteToOutputString_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601311B RID: 78107
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayDataWriter_Write_17(HandleRef pThis);

		/// <summary>
		/// Whether to output to a string instead of to a file, which is the default.
		/// </summary>
		// Token: 0x0601311C RID: 78108 RVA: 0x001AF264 File Offset: 0x001AD464
		public override int Write()
		{
			return vtkArrayDataWriter.vtkArrayDataWriter_Write_17(base.GetCppThis());
		}

		// Token: 0x0601311D RID: 78109
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkArrayDataWriter_Write_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string FileName, byte WriteBinary);

		/// <summary>
		/// Writes input port 0 data to a file, using an arbitrary filename and binary flag.
		/// </summary>
		// Token: 0x0601311E RID: 78110 RVA: 0x001AF284 File Offset: 0x001AD484
		public bool Write(string FileName, bool WriteBinary)
		{
			return vtkArrayDataWriter.vtkArrayDataWriter_Write_18(base.GetCppThis(), FileName, WriteBinary ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x0601311F RID: 78111
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkArrayDataWriter_Write_19(HandleRef array, [MarshalAs(UnmanagedType.LPUTF8Str)] string file_name, byte WriteBinary);

		/// <summary>
		/// Write an arbitrary array to a file, without using the pipeline.
		/// </summary>
		// Token: 0x06013120 RID: 78112 RVA: 0x001AF2B4 File Offset: 0x001AD4B4
		public static bool Write(vtkArrayData array, string file_name, bool WriteBinary)
		{
			return vtkArrayDataWriter.vtkArrayDataWriter_Write_19((array == null) ? default(HandleRef) : array.GetCppThis(), file_name, WriteBinary ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x06013121 RID: 78113
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkArrayDataWriter_Write_20(HandleRef pThis, byte WriteBinary);

		/// <summary>
		/// Write input port 0 data to a string. Note that the WriteBinary argument is not
		/// optional in order to not clash with the inherited Write() method.
		/// </summary>
		// Token: 0x06013122 RID: 78114 RVA: 0x001AF2F4 File Offset: 0x001AD4F4
		public string Write(bool WriteBinary)
		{
			return vtkArrayDataWriter.vtkArrayDataWriter_Write_20(base.GetCppThis(), WriteBinary ? (byte)1 : (byte)0);
		}

		// Token: 0x06013123 RID: 78115
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkArrayDataWriter_Write_21(HandleRef array, byte WriteBinary);

		/// <summary>
		/// Write arbitrary data to a string without using the pipeline.
		/// </summary>
		// Token: 0x06013124 RID: 78116 RVA: 0x001AF31C File Offset: 0x001AD51C
		public static string Write(vtkArrayData array, bool WriteBinary)
		{
			return vtkArrayDataWriter.vtkArrayDataWriter_Write_21((array == null) ? default(HandleRef) : array.GetCppThis(), WriteBinary ? (byte)1 : (byte)0);
		}

		// Token: 0x06013125 RID: 78117
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayDataWriter_WriteToOutputStringOff_22(HandleRef pThis);

		/// <summary>
		/// Whether to output to a string instead of to a file, which is the default.
		/// </summary>
		// Token: 0x06013126 RID: 78118 RVA: 0x001AF353 File Offset: 0x001AD553
		public virtual void WriteToOutputStringOff()
		{
			vtkArrayDataWriter.vtkArrayDataWriter_WriteToOutputStringOff_22(base.GetCppThis());
		}

		// Token: 0x06013127 RID: 78119
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayDataWriter_WriteToOutputStringOn_23(HandleRef pThis);

		/// <summary>
		/// Whether to output to a string instead of to a file, which is the default.
		/// </summary>
		// Token: 0x06013128 RID: 78120 RVA: 0x001AF362 File Offset: 0x001AD562
		public virtual void WriteToOutputStringOn()
		{
			vtkArrayDataWriter.vtkArrayDataWriter_WriteToOutputStringOn_23(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001606 RID: 5638
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001607 RID: 5639
		public new static readonly string MRClassNameKey = "class vtkArrayDataWriter";
	}
}
