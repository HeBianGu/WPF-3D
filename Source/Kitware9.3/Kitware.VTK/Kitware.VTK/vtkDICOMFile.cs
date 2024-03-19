using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x0200000D RID: 13
	public class vtkDICOMFile : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060002F2 RID: 754 RVA: 0x0000B744 File Offset: 0x00009944
		static vtkDICOMFile()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMFile.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMFile"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060002F3 RID: 755 RVA: 0x0000B76C File Offset: 0x0000996C
		public vtkDICOMFile(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060002F4 RID: 756 RVA: 0x0000B77A File Offset: 0x0000997A
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060002F5 RID: 757
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMFile_Access_01([MarshalAs(UnmanagedType.LPUTF8Str)] string filename, vtkDICOMFile.Mode mode);

		// Token: 0x060002F6 RID: 758 RVA: 0x0000B788 File Offset: 0x00009988
		public static int Access(string filename, vtkDICOMFile.Mode mode)
		{
			return vtkDICOMFile.vtkDICOMFile_Access_01(filename, mode);
		}

		// Token: 0x060002F7 RID: 759
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMFile_Close_02(HandleRef pThis);

		// Token: 0x060002F8 RID: 760 RVA: 0x0000B7A3 File Offset: 0x000099A3
		public void Close()
		{
			vtkDICOMFile.vtkDICOMFile_Close_02(base.GetCppThis());
		}

		// Token: 0x060002F9 RID: 761
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMFile_EndOfFile_03(HandleRef pThis);

		// Token: 0x060002FA RID: 762 RVA: 0x0000B7B4 File Offset: 0x000099B4
		public bool EndOfFile()
		{
			return vtkDICOMFile.vtkDICOMFile_EndOfFile_03(base.GetCppThis()) != 0;
		}

		// Token: 0x060002FB RID: 763
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMFile_GetError_04(HandleRef pThis);

		// Token: 0x060002FC RID: 764 RVA: 0x0000B7DC File Offset: 0x000099DC
		public int GetError()
		{
			return vtkDICOMFile.vtkDICOMFile_GetError_04(base.GetCppThis());
		}

		// Token: 0x060002FD RID: 765
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDICOMFile_GetSize_05(HandleRef pThis);

		// Token: 0x060002FE RID: 766 RVA: 0x0000B7FC File Offset: 0x000099FC
		public ulong GetSize()
		{
			return vtkDICOMFile.vtkDICOMFile_GetSize_05(base.GetCppThis());
		}

		// Token: 0x060002FF RID: 767
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDICOMFile_Read_06(HandleRef pThis, IntPtr data, ulong size);

		// Token: 0x06000300 RID: 768 RVA: 0x0000B81C File Offset: 0x00009A1C
		public ulong Read(IntPtr data, ulong size)
		{
			return vtkDICOMFile.vtkDICOMFile_Read_06(base.GetCppThis(), data, size);
		}

		// Token: 0x06000301 RID: 769
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMFile_Remove_07([MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		// Token: 0x06000302 RID: 770 RVA: 0x0000B840 File Offset: 0x00009A40
		public static int Remove(string filename)
		{
			return vtkDICOMFile.vtkDICOMFile_Remove_07(filename);
		}

		// Token: 0x06000303 RID: 771
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMFile_SameFile_08([MarshalAs(UnmanagedType.LPUTF8Str)] string file1, [MarshalAs(UnmanagedType.LPUTF8Str)] string file2);

		// Token: 0x06000304 RID: 772 RVA: 0x0000B85C File Offset: 0x00009A5C
		public static bool SameFile(string file1, string file2)
		{
			return vtkDICOMFile.vtkDICOMFile_SameFile_08(file1, file2) != 0;
		}

		// Token: 0x06000305 RID: 773
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMFile_SetPosition_09(HandleRef pThis, ulong offset);

		// Token: 0x06000306 RID: 774 RVA: 0x0000B880 File Offset: 0x00009A80
		public bool SetPosition(ulong offset)
		{
			return vtkDICOMFile.vtkDICOMFile_SetPosition_09(base.GetCppThis(), offset) != 0;
		}

		// Token: 0x06000307 RID: 775
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDICOMFile_Write_10(HandleRef pThis, IntPtr data, ulong size);

		// Token: 0x06000308 RID: 776 RVA: 0x0000B8A8 File Offset: 0x00009AA8
		public ulong Write(IntPtr data, ulong size)
		{
			return vtkDICOMFile.vtkDICOMFile_Write_10(base.GetCppThis(), data, size);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000126 RID: 294
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMFile";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000127 RID: 295
		public new static readonly string MRClassNameKey = "class vtkDICOMFile";

		// Token: 0x0200000E RID: 14
		public enum Code
		{
			/// <summary>enum member</summary>
			// Token: 0x04000129 RID: 297
			AccessDenied = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400012A RID: 298
			FileIsDirectory,
			/// <summary>enum member</summary>
			// Token: 0x0400012B RID: 299
			FileNotFound = 5,
			/// <summary>enum member</summary>
			// Token: 0x0400012C RID: 300
			Good = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400012D RID: 301
			ImpossiblePath = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400012E RID: 302
			OutOfSpace = 6,
			/// <summary>enum member</summary>
			// Token: 0x0400012F RID: 303
			UnknownError = 1
		}

		// Token: 0x0200000F RID: 15
		public enum Mode
		{
			/// <summary>enum member</summary>
			// Token: 0x04000131 RID: 305
			In,
			/// <summary>enum member</summary>
			// Token: 0x04000132 RID: 306
			Out
		}
	}
}
