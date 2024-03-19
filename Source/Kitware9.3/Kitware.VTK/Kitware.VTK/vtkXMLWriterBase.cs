using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkXMLWriterBase
	/// </summary>
	/// <remarks>
	///  Abstract base class for VTK-XML writers.
	///
	/// vtkXMLWriterBase class was created to help refactor XML writers
	/// (vtkXMLWriter and subclasses). Get/Set API on vtkXMLWriter is moved here while
	/// all the gory implementation details are left in vtkXMLWriter. This enables use to create
	/// a sibling hierarchy to vtkXMLWriter that uses a cleaner design to implement
	/// the IO capabilities. Eventually, we vtkXMLWriter and its children will be
	/// substituted by a parallel hierarchy at which point this class may merge with
	/// it's new subclass.
	/// </remarks>
	// Token: 0x02000134 RID: 308
	public abstract class vtkXMLWriterBase : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003D91 RID: 15761 RVA: 0x0005A07A File Offset: 0x0005827A
		static vtkXMLWriterBase()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLWriterBase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLWriterBase"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003D92 RID: 15762 RVA: 0x0005A0A2 File Offset: 0x000582A2
		public vtkXMLWriterBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003D93 RID: 15763 RVA: 0x0005A0B0 File Offset: 0x000582B0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003D94 RID: 15764
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_EncodeAppendedDataOff_01(HandleRef pThis);

		/// <summary>
		/// Get/Set whether the appended data section is base64 encoded.  If
		/// encoded, reading and writing will be slower, but the file will be
		/// fully valid XML and text-only.  If not encoded, the XML
		/// specification will be violated, but reading and writing will be
		/// fast.  The default is to do the encoding.
		/// </summary>
		// Token: 0x06003D95 RID: 15765 RVA: 0x0005A0BB File Offset: 0x000582BB
		public virtual void EncodeAppendedDataOff()
		{
			vtkXMLWriterBase.vtkXMLWriterBase_EncodeAppendedDataOff_01(base.GetCppThis());
		}

		// Token: 0x06003D96 RID: 15766
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_EncodeAppendedDataOn_02(HandleRef pThis);

		/// <summary>
		/// Get/Set whether the appended data section is base64 encoded.  If
		/// encoded, reading and writing will be slower, but the file will be
		/// fully valid XML and text-only.  If not encoded, the XML
		/// specification will be violated, but reading and writing will be
		/// fast.  The default is to do the encoding.
		/// </summary>
		// Token: 0x06003D97 RID: 15767 RVA: 0x0005A0CA File Offset: 0x000582CA
		public virtual void EncodeAppendedDataOn()
		{
			vtkXMLWriterBase.vtkXMLWriterBase_EncodeAppendedDataOn_02(base.GetCppThis());
		}

		// Token: 0x06003D98 RID: 15768
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkXMLWriterBase_GetBlockSize_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the block size used in compression.  When reading, this
		/// controls the granularity of how much extra information must be
		/// read when only part of the data are requested.  The value should
		/// be a multiple of the largest scalar data type.
		/// </summary>
		// Token: 0x06003D99 RID: 15769 RVA: 0x0005A0DC File Offset: 0x000582DC
		public virtual ulong GetBlockSize()
		{
			return vtkXMLWriterBase.vtkXMLWriterBase_GetBlockSize_03(base.GetCppThis());
		}

		// Token: 0x06003D9A RID: 15770
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLWriterBase_GetByteOrder_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the byte order of data written to the file.  The default
		/// is the machine's hardware byte order.
		/// </summary>
		// Token: 0x06003D9B RID: 15771 RVA: 0x0005A0FC File Offset: 0x000582FC
		public virtual int GetByteOrder()
		{
			return vtkXMLWriterBase.vtkXMLWriterBase_GetByteOrder_04(base.GetCppThis());
		}

		// Token: 0x06003D9C RID: 15772
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLWriterBase_GetCompressionLevel_05(HandleRef pThis);

		/// <summary>
		/// Get/Set compression level.
		/// 1 (worst compression, fastest) ... 9 (best compression, slowest).
		/// </summary>
		// Token: 0x06003D9D RID: 15773 RVA: 0x0005A11C File Offset: 0x0005831C
		public virtual int GetCompressionLevel()
		{
			return vtkXMLWriterBase.vtkXMLWriterBase_GetCompressionLevel_05(base.GetCppThis());
		}

		// Token: 0x06003D9E RID: 15774
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLWriterBase_GetCompressor_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the compressor used to compress binary and appended data
		/// before writing to the file.  Default is a vtkZLibDataCompressor.
		/// </summary>
		// Token: 0x06003D9F RID: 15775 RVA: 0x0005A13C File Offset: 0x0005833C
		public virtual vtkDataCompressor GetCompressor()
		{
			vtkDataCompressor vtkDataCompressor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLWriterBase.vtkXMLWriterBase_GetCompressor_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003DA0 RID: 15776
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLWriterBase_GetDataMode_07(HandleRef pThis);

		/// <summary>
		/// Get/Set the data mode used for the file's data.  The options are
		/// vtkXMLWriter::Ascii, vtkXMLWriter::Binary, and
		/// vtkXMLWriter::Appended.
		/// </summary>
		// Token: 0x06003DA1 RID: 15777 RVA: 0x0005A1AC File Offset: 0x000583AC
		public virtual int GetDataMode()
		{
			return vtkXMLWriterBase.vtkXMLWriterBase_GetDataMode_07(base.GetCppThis());
		}

		// Token: 0x06003DA2 RID: 15778
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLWriterBase_GetDefaultFileExtension_08(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x06003DA3 RID: 15779 RVA: 0x0005A1CC File Offset: 0x000583CC
		public virtual string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLWriterBase.vtkXMLWriterBase_GetDefaultFileExtension_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003DA4 RID: 15780
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkXMLWriterBase_GetEncodeAppendedData_09(HandleRef pThis);

		/// <summary>
		/// Get/Set whether the appended data section is base64 encoded.  If
		/// encoded, reading and writing will be slower, but the file will be
		/// fully valid XML and text-only.  If not encoded, the XML
		/// specification will be violated, but reading and writing will be
		/// fast.  The default is to do the encoding.
		/// </summary>
		// Token: 0x06003DA5 RID: 15781 RVA: 0x0005A208 File Offset: 0x00058408
		public virtual bool GetEncodeAppendedData()
		{
			return vtkXMLWriterBase.vtkXMLWriterBase_GetEncodeAppendedData_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06003DA6 RID: 15782
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLWriterBase_GetFileName_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the output file.
		/// </summary>
		// Token: 0x06003DA7 RID: 15783 RVA: 0x0005A230 File Offset: 0x00058430
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLWriterBase.vtkXMLWriterBase_GetFileName_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003DA8 RID: 15784
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLWriterBase_GetHeaderType_11(HandleRef pThis);

		/// <summary>
		/// Get/Set the binary data header word type.  The default is UInt32.
		/// Set to UInt64 when storing arrays requiring 64-bit indexing.
		/// </summary>
		// Token: 0x06003DA9 RID: 15785 RVA: 0x0005A26C File Offset: 0x0005846C
		public virtual int GetHeaderType()
		{
			return vtkXMLWriterBase.vtkXMLWriterBase_GetHeaderType_11(base.GetCppThis());
		}

		// Token: 0x06003DAA RID: 15786
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLWriterBase_GetIdType_12(HandleRef pThis);

		/// <summary>
		/// Get/Set the size of the vtkIdType values stored in the file.  The
		/// default is the real size of vtkIdType.
		/// </summary>
		// Token: 0x06003DAB RID: 15787 RVA: 0x0005A28C File Offset: 0x0005848C
		public virtual int GetIdType()
		{
			return vtkXMLWriterBase.vtkXMLWriterBase_GetIdType_12(base.GetCppThis());
		}

		// Token: 0x06003DAC RID: 15788
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLWriterBase_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003DAD RID: 15789 RVA: 0x0005A2AC File Offset: 0x000584AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLWriterBase.vtkXMLWriterBase_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06003DAE RID: 15790
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLWriterBase_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003DAF RID: 15791 RVA: 0x0005A2CC File Offset: 0x000584CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLWriterBase.vtkXMLWriterBase_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06003DB0 RID: 15792
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkXMLWriterBase_GetOutputString_15(HandleRef pThis);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// </summary>
		// Token: 0x06003DB1 RID: 15793 RVA: 0x0005A2E8 File Offset: 0x000584E8
		public string GetOutputString()
		{
			return vtkXMLWriterBase.vtkXMLWriterBase_GetOutputString_15(base.GetCppThis());
		}

		// Token: 0x06003DB2 RID: 15794
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkXMLWriterBase_GetWriteToOutputString_16(HandleRef pThis);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// </summary>
		// Token: 0x06003DB3 RID: 15795 RVA: 0x0005A308 File Offset: 0x00058508
		public virtual bool GetWriteToOutputString()
		{
			return vtkXMLWriterBase.vtkXMLWriterBase_GetWriteToOutputString_16(base.GetCppThis()) != 0;
		}

		// Token: 0x06003DB4 RID: 15796
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLWriterBase_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003DB5 RID: 15797 RVA: 0x0005A330 File Offset: 0x00058530
		public override int IsA(string type)
		{
			return vtkXMLWriterBase.vtkXMLWriterBase_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x06003DB6 RID: 15798
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLWriterBase_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003DB7 RID: 15799 RVA: 0x0005A350 File Offset: 0x00058550
		public new static int IsTypeOf(string type)
		{
			return vtkXMLWriterBase.vtkXMLWriterBase_IsTypeOf_18(type);
		}

		// Token: 0x06003DB8 RID: 15800
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLWriterBase_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003DB9 RID: 15801 RVA: 0x0005A36C File Offset: 0x0005856C
		public new vtkXMLWriterBase NewInstance()
		{
			vtkXMLWriterBase result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLWriterBase.vtkXMLWriterBase_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLWriterBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003DBA RID: 15802
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLWriterBase_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003DBB RID: 15803 RVA: 0x0005A3C8 File Offset: 0x000585C8
		public new static vtkXMLWriterBase SafeDownCast(vtkObjectBase o)
		{
			vtkXMLWriterBase vtkXMLWriterBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLWriterBase.vtkXMLWriterBase_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLWriterBase = (vtkXMLWriterBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLWriterBase.Register(null);
				}
			}
			return vtkXMLWriterBase;
		}

		// Token: 0x06003DBC RID: 15804
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetBlockSize_21(HandleRef pThis, ulong blockSize);

		/// <summary>
		/// Get/Set the block size used in compression.  When reading, this
		/// controls the granularity of how much extra information must be
		/// read when only part of the data are requested.  The value should
		/// be a multiple of the largest scalar data type.
		/// </summary>
		// Token: 0x06003DBD RID: 15805 RVA: 0x0005A447 File Offset: 0x00058647
		public virtual void SetBlockSize(ulong blockSize)
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetBlockSize_21(base.GetCppThis(), blockSize);
		}

		// Token: 0x06003DBE RID: 15806
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetByteOrder_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the byte order of data written to the file.  The default
		/// is the machine's hardware byte order.
		/// </summary>
		// Token: 0x06003DBF RID: 15807 RVA: 0x0005A457 File Offset: 0x00058657
		public virtual void SetByteOrder(int _arg)
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetByteOrder_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06003DC0 RID: 15808
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetByteOrderToBigEndian_23(HandleRef pThis);

		/// <summary>
		/// Get/Set the byte order of data written to the file.  The default
		/// is the machine's hardware byte order.
		/// </summary>
		// Token: 0x06003DC1 RID: 15809 RVA: 0x0005A467 File Offset: 0x00058667
		public void SetByteOrderToBigEndian()
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetByteOrderToBigEndian_23(base.GetCppThis());
		}

		// Token: 0x06003DC2 RID: 15810
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetByteOrderToLittleEndian_24(HandleRef pThis);

		/// <summary>
		/// Get/Set the byte order of data written to the file.  The default
		/// is the machine's hardware byte order.
		/// </summary>
		// Token: 0x06003DC3 RID: 15811 RVA: 0x0005A476 File Offset: 0x00058676
		public void SetByteOrderToLittleEndian()
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetByteOrderToLittleEndian_24(base.GetCppThis());
		}

		// Token: 0x06003DC4 RID: 15812
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetCompressionLevel_25(HandleRef pThis, int compressorLevel);

		/// <summary>
		/// Get/Set compression level.
		/// 1 (worst compression, fastest) ... 9 (best compression, slowest).
		/// </summary>
		// Token: 0x06003DC5 RID: 15813 RVA: 0x0005A485 File Offset: 0x00058685
		public void SetCompressionLevel(int compressorLevel)
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetCompressionLevel_25(base.GetCppThis(), compressorLevel);
		}

		// Token: 0x06003DC6 RID: 15814
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetCompressor_26(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the compressor used to compress binary and appended data
		/// before writing to the file.  Default is a vtkZLibDataCompressor.
		/// </summary>
		// Token: 0x06003DC7 RID: 15815 RVA: 0x0005A498 File Offset: 0x00058698
		public virtual void SetCompressor(vtkDataCompressor arg0)
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetCompressor_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003DC8 RID: 15816
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetCompressorType_27(HandleRef pThis, int compressorType);

		/// <summary>
		/// Convenience functions to set the compressor to certain known types.
		/// </summary>
		// Token: 0x06003DC9 RID: 15817 RVA: 0x0005A4C7 File Offset: 0x000586C7
		public void SetCompressorType(int compressorType)
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetCompressorType_27(base.GetCppThis(), compressorType);
		}

		// Token: 0x06003DCA RID: 15818
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetCompressorTypeToLZ4_28(HandleRef pThis);

		/// <summary>
		/// Convenience functions to set the compressor to certain known types.
		/// </summary>
		// Token: 0x06003DCB RID: 15819 RVA: 0x0005A4D7 File Offset: 0x000586D7
		public void SetCompressorTypeToLZ4()
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetCompressorTypeToLZ4_28(base.GetCppThis());
		}

		// Token: 0x06003DCC RID: 15820
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetCompressorTypeToLZMA_29(HandleRef pThis);

		/// <summary>
		/// Convenience functions to set the compressor to certain known types.
		/// </summary>
		// Token: 0x06003DCD RID: 15821 RVA: 0x0005A4E6 File Offset: 0x000586E6
		public void SetCompressorTypeToLZMA()
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetCompressorTypeToLZMA_29(base.GetCppThis());
		}

		// Token: 0x06003DCE RID: 15822
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetCompressorTypeToNone_30(HandleRef pThis);

		/// <summary>
		/// Convenience functions to set the compressor to certain known types.
		/// </summary>
		// Token: 0x06003DCF RID: 15823 RVA: 0x0005A4F5 File Offset: 0x000586F5
		public void SetCompressorTypeToNone()
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetCompressorTypeToNone_30(base.GetCppThis());
		}

		// Token: 0x06003DD0 RID: 15824
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetCompressorTypeToZLib_31(HandleRef pThis);

		/// <summary>
		/// Convenience functions to set the compressor to certain known types.
		/// </summary>
		// Token: 0x06003DD1 RID: 15825 RVA: 0x0005A504 File Offset: 0x00058704
		public void SetCompressorTypeToZLib()
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetCompressorTypeToZLib_31(base.GetCppThis());
		}

		// Token: 0x06003DD2 RID: 15826
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetDataMode_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the data mode used for the file's data.  The options are
		/// vtkXMLWriter::Ascii, vtkXMLWriter::Binary, and
		/// vtkXMLWriter::Appended.
		/// </summary>
		// Token: 0x06003DD3 RID: 15827 RVA: 0x0005A513 File Offset: 0x00058713
		public virtual void SetDataMode(int _arg)
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetDataMode_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06003DD4 RID: 15828
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetDataModeToAppended_33(HandleRef pThis);

		/// <summary>
		/// Get/Set the data mode used for the file's data.  The options are
		/// vtkXMLWriter::Ascii, vtkXMLWriter::Binary, and
		/// vtkXMLWriter::Appended.
		/// </summary>
		// Token: 0x06003DD5 RID: 15829 RVA: 0x0005A523 File Offset: 0x00058723
		public void SetDataModeToAppended()
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetDataModeToAppended_33(base.GetCppThis());
		}

		// Token: 0x06003DD6 RID: 15830
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetDataModeToAscii_34(HandleRef pThis);

		/// <summary>
		/// Get/Set the data mode used for the file's data.  The options are
		/// vtkXMLWriter::Ascii, vtkXMLWriter::Binary, and
		/// vtkXMLWriter::Appended.
		/// </summary>
		// Token: 0x06003DD7 RID: 15831 RVA: 0x0005A532 File Offset: 0x00058732
		public void SetDataModeToAscii()
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetDataModeToAscii_34(base.GetCppThis());
		}

		// Token: 0x06003DD8 RID: 15832
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetDataModeToBinary_35(HandleRef pThis);

		/// <summary>
		/// Get/Set the data mode used for the file's data.  The options are
		/// vtkXMLWriter::Ascii, vtkXMLWriter::Binary, and
		/// vtkXMLWriter::Appended.
		/// </summary>
		// Token: 0x06003DD9 RID: 15833 RVA: 0x0005A541 File Offset: 0x00058741
		public void SetDataModeToBinary()
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetDataModeToBinary_35(base.GetCppThis());
		}

		// Token: 0x06003DDA RID: 15834
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetEncodeAppendedData_36(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set whether the appended data section is base64 encoded.  If
		/// encoded, reading and writing will be slower, but the file will be
		/// fully valid XML and text-only.  If not encoded, the XML
		/// specification will be violated, but reading and writing will be
		/// fast.  The default is to do the encoding.
		/// </summary>
		// Token: 0x06003DDB RID: 15835 RVA: 0x0005A550 File Offset: 0x00058750
		public virtual void SetEncodeAppendedData(bool _arg)
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetEncodeAppendedData_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06003DDC RID: 15836
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetFileName_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the output file.
		/// </summary>
		// Token: 0x06003DDD RID: 15837 RVA: 0x0005A568 File Offset: 0x00058768
		public virtual void SetFileName(string _arg)
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetFileName_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06003DDE RID: 15838
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetHeaderType_38(HandleRef pThis, int arg0);

		/// <summary>
		/// Get/Set the binary data header word type.  The default is UInt32.
		/// Set to UInt64 when storing arrays requiring 64-bit indexing.
		/// </summary>
		// Token: 0x06003DDF RID: 15839 RVA: 0x0005A578 File Offset: 0x00058778
		public virtual void SetHeaderType(int arg0)
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetHeaderType_38(base.GetCppThis(), arg0);
		}

		// Token: 0x06003DE0 RID: 15840
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetHeaderTypeToUInt32_39(HandleRef pThis);

		/// <summary>
		/// Get/Set the binary data header word type.  The default is UInt32.
		/// Set to UInt64 when storing arrays requiring 64-bit indexing.
		/// </summary>
		// Token: 0x06003DE1 RID: 15841 RVA: 0x0005A588 File Offset: 0x00058788
		public void SetHeaderTypeToUInt32()
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetHeaderTypeToUInt32_39(base.GetCppThis());
		}

		// Token: 0x06003DE2 RID: 15842
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetHeaderTypeToUInt64_40(HandleRef pThis);

		/// <summary>
		/// Get/Set the binary data header word type.  The default is UInt32.
		/// Set to UInt64 when storing arrays requiring 64-bit indexing.
		/// </summary>
		// Token: 0x06003DE3 RID: 15843 RVA: 0x0005A597 File Offset: 0x00058797
		public void SetHeaderTypeToUInt64()
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetHeaderTypeToUInt64_40(base.GetCppThis());
		}

		// Token: 0x06003DE4 RID: 15844
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetIdType_41(HandleRef pThis, int arg0);

		/// <summary>
		/// Get/Set the size of the vtkIdType values stored in the file.  The
		/// default is the real size of vtkIdType.
		/// </summary>
		// Token: 0x06003DE5 RID: 15845 RVA: 0x0005A5A6 File Offset: 0x000587A6
		public virtual void SetIdType(int arg0)
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetIdType_41(base.GetCppThis(), arg0);
		}

		// Token: 0x06003DE6 RID: 15846
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetIdTypeToInt32_42(HandleRef pThis);

		/// <summary>
		/// Get/Set the size of the vtkIdType values stored in the file.  The
		/// default is the real size of vtkIdType.
		/// </summary>
		// Token: 0x06003DE7 RID: 15847 RVA: 0x0005A5B6 File Offset: 0x000587B6
		public void SetIdTypeToInt32()
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetIdTypeToInt32_42(base.GetCppThis());
		}

		// Token: 0x06003DE8 RID: 15848
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetIdTypeToInt64_43(HandleRef pThis);

		/// <summary>
		/// Get/Set the size of the vtkIdType values stored in the file.  The
		/// default is the real size of vtkIdType.
		/// </summary>
		// Token: 0x06003DE9 RID: 15849 RVA: 0x0005A5C5 File Offset: 0x000587C5
		public void SetIdTypeToInt64()
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetIdTypeToInt64_43(base.GetCppThis());
		}

		// Token: 0x06003DEA RID: 15850
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_SetWriteToOutputString_44(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// </summary>
		// Token: 0x06003DEB RID: 15851 RVA: 0x0005A5D4 File Offset: 0x000587D4
		public virtual void SetWriteToOutputString(bool _arg)
		{
			vtkXMLWriterBase.vtkXMLWriterBase_SetWriteToOutputString_44(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06003DEC RID: 15852
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLWriterBase_Write_45(HandleRef pThis);

		/// <summary>
		/// Invoke the writer.  Returns 1 for success, 0 for failure.
		/// </summary>
		// Token: 0x06003DED RID: 15853 RVA: 0x0005A5EC File Offset: 0x000587EC
		public int Write()
		{
			return vtkXMLWriterBase.vtkXMLWriterBase_Write_45(base.GetCppThis());
		}

		// Token: 0x06003DEE RID: 15854
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_WriteToOutputStringOff_46(HandleRef pThis);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// </summary>
		// Token: 0x06003DEF RID: 15855 RVA: 0x0005A60B File Offset: 0x0005880B
		public virtual void WriteToOutputStringOff()
		{
			vtkXMLWriterBase.vtkXMLWriterBase_WriteToOutputStringOff_46(base.GetCppThis());
		}

		// Token: 0x06003DF0 RID: 15856
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriterBase_WriteToOutputStringOn_47(HandleRef pThis);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// </summary>
		// Token: 0x06003DF1 RID: 15857 RVA: 0x0005A61A File Offset: 0x0005881A
		public virtual void WriteToOutputStringOn()
		{
			vtkXMLWriterBase.vtkXMLWriterBase_WriteToOutputStringOn_47(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006A4 RID: 1700
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLWriterBase";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006A5 RID: 1701
		public new static readonly string MRClassNameKey = "class vtkXMLWriterBase";

		/// <summary>
		/// Enumerate big and little endian byte order settings.
		/// </summary>
		// Token: 0x02000135 RID: 309
		public enum BigEndian_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040006A7 RID: 1703
			BigEndian,
			/// <summary>enum member</summary>
			// Token: 0x040006A8 RID: 1704
			LittleEndian
		}

		/// <summary>
		/// Enumerate the supported data modes.
		/// Ascii = Inline ascii data.
		/// Binary = Inline binary data (base64 encoded, possibly compressed).
		/// Appended = Appended binary data (possibly compressed and/or base64).
		/// </summary>
		// Token: 0x02000136 RID: 310
		public enum Appended_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040006AA RID: 1706
			Appended = 2,
			/// <summary>enum member</summary>
			// Token: 0x040006AB RID: 1707
			Ascii = 0,
			/// <summary>enum member</summary>
			// Token: 0x040006AC RID: 1708
			Binary
		}

		/// <summary>
		/// Enumerate the supported vtkIdType bit lengths.
		/// Int32 = File stores 32-bit values for vtkIdType.
		/// Int64 = File stores 64-bit values for vtkIdType.
		/// </summary>
		// Token: 0x02000137 RID: 311
		public enum Int32_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040006AE RID: 1710
			Int32 = 32,
			/// <summary>enum member</summary>
			// Token: 0x040006AF RID: 1711
			Int64 = 64
		}

		/// <summary>
		/// Enumerate the supported binary data header bit lengths.
		/// UInt32 = File stores 32-bit binary data header elements.
		/// UInt64 = File stores 64-bit binary data header elements.
		/// </summary>
		// Token: 0x02000138 RID: 312
		public enum UInt32_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040006B1 RID: 1713
			UInt32 = 32,
			/// <summary>enum member</summary>
			// Token: 0x040006B2 RID: 1714
			UInt64 = 64
		}

		/// <summary>
		/// Get/Set the compressor used to compress binary and appended data
		/// before writing to the file.  Default is a vtkZLibDataCompressor.
		/// </summary>
		// Token: 0x02000139 RID: 313
		public enum CompressorType
		{
			/// <summary>enum member</summary>
			// Token: 0x040006B4 RID: 1716
			LZ4 = 2,
			/// <summary>enum member</summary>
			// Token: 0x040006B5 RID: 1717
			LZMA,
			/// <summary>enum member</summary>
			// Token: 0x040006B6 RID: 1718
			NONE = 0,
			/// <summary>enum member</summary>
			// Token: 0x040006B7 RID: 1719
			ZLIB
		}
	}
}
