using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000010 RID: 16
	public class vtkDICOMFileDirectory : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000309 RID: 777 RVA: 0x0000B8C9 File Offset: 0x00009AC9
		static vtkDICOMFileDirectory()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMFileDirectory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMFileDirectory"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600030A RID: 778 RVA: 0x0000B8F1 File Offset: 0x00009AF1
		public vtkDICOMFileDirectory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600030B RID: 779 RVA: 0x0000B8FF File Offset: 0x00009AFF
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600030C RID: 780
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMFileDirectory_Access_01([MarshalAs(UnmanagedType.LPUTF8Str)] string dirname, vtkDICOMFileDirectory.Mode mode);

		// Token: 0x0600030D RID: 781 RVA: 0x0000B90C File Offset: 0x00009B0C
		public static int Access(string dirname, vtkDICOMFileDirectory.Mode mode)
		{
			return vtkDICOMFileDirectory.vtkDICOMFileDirectory_Access_01(dirname, mode);
		}

		// Token: 0x0600030E RID: 782
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMFileDirectory_Create_02([MarshalAs(UnmanagedType.LPUTF8Str)] string dirname);

		// Token: 0x0600030F RID: 783 RVA: 0x0000B928 File Offset: 0x00009B28
		public static int Create(string dirname)
		{
			return vtkDICOMFileDirectory.vtkDICOMFileDirectory_Create_02(dirname);
		}

		// Token: 0x06000310 RID: 784
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMFileDirectory_GetEntry_03(HandleRef pThis, int i);

		// Token: 0x06000311 RID: 785 RVA: 0x0000B944 File Offset: 0x00009B44
		public string GetEntry(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMFileDirectory.vtkDICOMFileDirectory_GetEntry_03(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000312 RID: 786
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMFileDirectory_GetError_04(HandleRef pThis);

		// Token: 0x06000313 RID: 787 RVA: 0x0000B980 File Offset: 0x00009B80
		public int GetError()
		{
			return vtkDICOMFileDirectory.vtkDICOMFileDirectory_GetError_04(base.GetCppThis());
		}

		// Token: 0x06000314 RID: 788
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMFileDirectory_GetNumberOfEntries_05(HandleRef pThis);

		// Token: 0x06000315 RID: 789 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		public int GetNumberOfEntries()
		{
			return vtkDICOMFileDirectory.vtkDICOMFileDirectory_GetNumberOfEntries_05(base.GetCppThis());
		}

		// Token: 0x06000316 RID: 790
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMFileDirectory_IsBroken_06(HandleRef pThis, int i);

		// Token: 0x06000317 RID: 791 RVA: 0x0000B9C0 File Offset: 0x00009BC0
		public bool IsBroken(int i)
		{
			return vtkDICOMFileDirectory.vtkDICOMFileDirectory_IsBroken_06(base.GetCppThis(), i) != 0;
		}

		// Token: 0x06000318 RID: 792
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMFileDirectory_IsDirectory_07(HandleRef pThis, int i);

		// Token: 0x06000319 RID: 793 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		public bool IsDirectory(int i)
		{
			return vtkDICOMFileDirectory.vtkDICOMFileDirectory_IsDirectory_07(base.GetCppThis(), i) != 0;
		}

		// Token: 0x0600031A RID: 794
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMFileDirectory_IsHidden_08(HandleRef pThis, int i);

		// Token: 0x0600031B RID: 795 RVA: 0x0000BA10 File Offset: 0x00009C10
		public bool IsHidden(int i)
		{
			return vtkDICOMFileDirectory.vtkDICOMFileDirectory_IsHidden_08(base.GetCppThis(), i) != 0;
		}

		// Token: 0x0600031C RID: 796
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMFileDirectory_IsSpecial_09(HandleRef pThis, int i);

		// Token: 0x0600031D RID: 797 RVA: 0x0000BA38 File Offset: 0x00009C38
		public bool IsSpecial(int i)
		{
			return vtkDICOMFileDirectory.vtkDICOMFileDirectory_IsSpecial_09(base.GetCppThis(), i) != 0;
		}

		// Token: 0x0600031E RID: 798
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMFileDirectory_IsSymlink_10(HandleRef pThis, int i);

		// Token: 0x0600031F RID: 799 RVA: 0x0000BA60 File Offset: 0x00009C60
		public bool IsSymlink(int i)
		{
			return vtkDICOMFileDirectory.vtkDICOMFileDirectory_IsSymlink_10(base.GetCppThis(), i) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000133 RID: 307
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMFileDirectory";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000134 RID: 308
		public new static readonly string MRClassNameKey = "class vtkDICOMFileDirectory";

		// Token: 0x02000011 RID: 17
		public enum Code
		{
			/// <summary>enum member</summary>
			// Token: 0x04000136 RID: 310
			AccessDenied = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000137 RID: 311
			FileNotFound = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000138 RID: 312
			Good = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000139 RID: 313
			ImpossiblePath = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400013A RID: 314
			OutOfSpace = 6,
			/// <summary>enum member</summary>
			// Token: 0x0400013B RID: 315
			Reserved = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400013C RID: 316
			UnknownError = 1
		}

		// Token: 0x02000012 RID: 18
		public enum Mode
		{
			/// <summary>enum member</summary>
			// Token: 0x0400013E RID: 318
			In,
			/// <summary>enum member</summary>
			// Token: 0x0400013F RID: 319
			Out
		}
	}
}
