using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataObjectWriter
	/// </summary>
	/// <remarks>
	///    write vtk field data
	///
	/// vtkDataObjectWriter is a source object that writes ASCII or binary
	/// field data files in vtk format. Field data is a general form of data in
	/// matrix form.
	///
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFieldData vtkFieldDataReader
	/// </seealso>
	// Token: 0x02000706 RID: 1798
	public class vtkDataObjectWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012E64 RID: 77412 RVA: 0x001A9E1B File Offset: 0x001A801B
		static vtkDataObjectWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObjectWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012E65 RID: 77413 RVA: 0x001A9E43 File Offset: 0x001A8043
		public vtkDataObjectWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012E66 RID: 77414
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E67 RID: 77415 RVA: 0x001A9E54 File Offset: 0x001A8054
		public new static vtkDataObjectWriter New()
		{
			vtkDataObjectWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectWriter.vtkDataObjectWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E68 RID: 77416 RVA: 0x001A9EA8 File Offset: 0x001A80A8
		public vtkDataObjectWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataObjectWriter.vtkDataObjectWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012E69 RID: 77417 RVA: 0x001A9EEC File Offset: 0x001A80EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012E6A RID: 77418
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectWriter_GetBinaryOutputString_01(HandleRef pThis);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E6B RID: 77419 RVA: 0x001A9EF8 File Offset: 0x001A80F8
		public IntPtr GetBinaryOutputString()
		{
			return vtkDataObjectWriter.vtkDataObjectWriter_GetBinaryOutputString_01(base.GetCppThis());
		}

		// Token: 0x06012E6C RID: 77420
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectWriter_GetFieldDataName_02(HandleRef pThis);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E6D RID: 77421 RVA: 0x001A9F18 File Offset: 0x001A8118
		public string GetFieldDataName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataObjectWriter.vtkDataObjectWriter_GetFieldDataName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06012E6E RID: 77422
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectWriter_GetFileName_03(HandleRef pThis);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E6F RID: 77423 RVA: 0x001A9F54 File Offset: 0x001A8154
		public string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataObjectWriter.vtkDataObjectWriter_GetFileName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06012E70 RID: 77424
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectWriter_GetFileType_04(HandleRef pThis);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E71 RID: 77425 RVA: 0x001A9F90 File Offset: 0x001A8190
		public int GetFileType()
		{
			return vtkDataObjectWriter.vtkDataObjectWriter_GetFileType_04(base.GetCppThis());
		}

		// Token: 0x06012E72 RID: 77426
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectWriter_GetHeader_05(HandleRef pThis);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E73 RID: 77427 RVA: 0x001A9FB0 File Offset: 0x001A81B0
		public string GetHeader()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataObjectWriter.vtkDataObjectWriter_GetHeader_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06012E74 RID: 77428
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectWriter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E75 RID: 77429 RVA: 0x001A9FEC File Offset: 0x001A81EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataObjectWriter.vtkDataObjectWriter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06012E76 RID: 77430
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectWriter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E77 RID: 77431 RVA: 0x001AA00C File Offset: 0x001A820C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataObjectWriter.vtkDataObjectWriter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06012E78 RID: 77432
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDataObjectWriter_GetOutputStdString_08(HandleRef pThis);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E79 RID: 77433 RVA: 0x001AA028 File Offset: 0x001A8228
		public string GetOutputStdString()
		{
			return vtkDataObjectWriter.vtkDataObjectWriter_GetOutputStdString_08(base.GetCppThis());
		}

		// Token: 0x06012E7A RID: 77434
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectWriter_GetOutputString_09(HandleRef pThis);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E7B RID: 77435 RVA: 0x001AA048 File Offset: 0x001A8248
		public string GetOutputString()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataObjectWriter.vtkDataObjectWriter_GetOutputString_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06012E7C RID: 77436
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectWriter_GetOutputStringLength_10(HandleRef pThis);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E7D RID: 77437 RVA: 0x001AA084 File Offset: 0x001A8284
		public long GetOutputStringLength()
		{
			return vtkDataObjectWriter.vtkDataObjectWriter_GetOutputStringLength_10(base.GetCppThis());
		}

		// Token: 0x06012E7E RID: 77438
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectWriter_GetWriteToOutputString_11(HandleRef pThis);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E7F RID: 77439 RVA: 0x001AA0A4 File Offset: 0x001A82A4
		public int GetWriteToOutputString()
		{
			return vtkDataObjectWriter.vtkDataObjectWriter_GetWriteToOutputString_11(base.GetCppThis());
		}

		// Token: 0x06012E80 RID: 77440
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectWriter_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E81 RID: 77441 RVA: 0x001AA0C4 File Offset: 0x001A82C4
		public override int IsA(string type)
		{
			return vtkDataObjectWriter.vtkDataObjectWriter_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06012E82 RID: 77442
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectWriter_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E83 RID: 77443 RVA: 0x001AA0E4 File Offset: 0x001A82E4
		public new static int IsTypeOf(string type)
		{
			return vtkDataObjectWriter.vtkDataObjectWriter_IsTypeOf_13(type);
		}

		// Token: 0x06012E84 RID: 77444
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectWriter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E85 RID: 77445 RVA: 0x001AA100 File Offset: 0x001A8300
		public new vtkDataObjectWriter NewInstance()
		{
			vtkDataObjectWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectWriter.vtkDataObjectWriter_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012E86 RID: 77446
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectWriter_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E87 RID: 77447 RVA: 0x001AA15C File Offset: 0x001A835C
		public new static vtkDataObjectWriter SafeDownCast(vtkObjectBase o)
		{
			vtkDataObjectWriter vtkDataObjectWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectWriter.vtkDataObjectWriter_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectWriter = (vtkDataObjectWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectWriter.Register(null);
				}
			}
			return vtkDataObjectWriter;
		}

		// Token: 0x06012E88 RID: 77448
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectWriter_SetFieldDataName_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldname);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E89 RID: 77449 RVA: 0x001AA1DB File Offset: 0x001A83DB
		public void SetFieldDataName(string fieldname)
		{
			vtkDataObjectWriter.vtkDataObjectWriter_SetFieldDataName_17(base.GetCppThis(), fieldname);
		}

		// Token: 0x06012E8A RID: 77450
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectWriter_SetFileName_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E8B RID: 77451 RVA: 0x001AA1EB File Offset: 0x001A83EB
		public void SetFileName(string filename)
		{
			vtkDataObjectWriter.vtkDataObjectWriter_SetFileName_18(base.GetCppThis(), filename);
		}

		// Token: 0x06012E8C RID: 77452
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectWriter_SetFileType_19(HandleRef pThis, int type);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E8D RID: 77453 RVA: 0x001AA1FB File Offset: 0x001A83FB
		public void SetFileType(int type)
		{
			vtkDataObjectWriter.vtkDataObjectWriter_SetFileType_19(base.GetCppThis(), type);
		}

		// Token: 0x06012E8E RID: 77454
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectWriter_SetFileTypeToASCII_20(HandleRef pThis);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E8F RID: 77455 RVA: 0x001AA20B File Offset: 0x001A840B
		public void SetFileTypeToASCII()
		{
			vtkDataObjectWriter.vtkDataObjectWriter_SetFileTypeToASCII_20(base.GetCppThis());
		}

		// Token: 0x06012E90 RID: 77456
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectWriter_SetFileTypeToBinary_21(HandleRef pThis);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E91 RID: 77457 RVA: 0x001AA21A File Offset: 0x001A841A
		public void SetFileTypeToBinary()
		{
			vtkDataObjectWriter.vtkDataObjectWriter_SetFileTypeToBinary_21(base.GetCppThis());
		}

		// Token: 0x06012E92 RID: 77458
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectWriter_SetHeader_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string header);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E93 RID: 77459 RVA: 0x001AA229 File Offset: 0x001A8429
		public void SetHeader(string header)
		{
			vtkDataObjectWriter.vtkDataObjectWriter_SetHeader_22(base.GetCppThis(), header);
		}

		// Token: 0x06012E94 RID: 77460
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectWriter_SetWriteToOutputString_23(HandleRef pThis, int b);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E95 RID: 77461 RVA: 0x001AA239 File Offset: 0x001A8439
		public void SetWriteToOutputString(int b)
		{
			vtkDataObjectWriter.vtkDataObjectWriter_SetWriteToOutputString_23(base.GetCppThis(), b);
		}

		// Token: 0x06012E96 RID: 77462
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectWriter_WriteToOutputStringOff_24(HandleRef pThis);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E97 RID: 77463 RVA: 0x001AA249 File Offset: 0x001A8449
		public void WriteToOutputStringOff()
		{
			vtkDataObjectWriter.vtkDataObjectWriter_WriteToOutputStringOff_24(base.GetCppThis());
		}

		// Token: 0x06012E98 RID: 77464
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectWriter_WriteToOutputStringOn_25(HandleRef pThis);

		/// <summary>
		/// Methods delegated to vtkDataWriter, see vtkDataWriter.
		/// </summary>
		// Token: 0x06012E99 RID: 77465 RVA: 0x001AA258 File Offset: 0x001A8458
		public void WriteToOutputStringOn()
		{
			vtkDataObjectWriter.vtkDataObjectWriter_WriteToOutputStringOn_25(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015D8 RID: 5592
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015D9 RID: 5593
		public new static readonly string MRClassNameKey = "class vtkDataObjectWriter";
	}
}
