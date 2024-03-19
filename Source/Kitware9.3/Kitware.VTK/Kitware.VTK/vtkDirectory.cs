using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDirectory
	/// </summary>
	/// <remarks>
	///    OS independent class for access and manipulation of system directories
	///
	/// vtkDirectory provides a portable way of finding the names of the files
	/// in a system directory.  It also provides methods of manipulating directories.
	///
	/// @warning
	/// vtkDirectory works with windows and unix only.
	/// </remarks>
	// Token: 0x02000AF9 RID: 2809
	public class vtkDirectory : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D847 RID: 120903 RVA: 0x0029B19B File Offset: 0x0029939B
		static vtkDirectory()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDirectory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDirectory"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D848 RID: 120904 RVA: 0x0029B1C3 File Offset: 0x002993C3
		public vtkDirectory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D849 RID: 120905
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a new vtkDirectory object.
		/// </summary>
		// Token: 0x0601D84A RID: 120906 RVA: 0x0029B1D4 File Offset: 0x002993D4
		public new static vtkDirectory New()
		{
			vtkDirectory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectory.vtkDirectory_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDirectory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create a new vtkDirectory object.
		/// </summary>
		// Token: 0x0601D84B RID: 120907 RVA: 0x0029B228 File Offset: 0x00299428
		public vtkDirectory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDirectory.vtkDirectory_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D84C RID: 120908 RVA: 0x0029B26C File Offset: 0x0029946C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D84D RID: 120909
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectory_DeleteDirectory_01([MarshalAs(UnmanagedType.LPUTF8Str)] string dir);

		/// <summary>
		/// Remove a directory.
		/// </summary>
		// Token: 0x0601D84E RID: 120910 RVA: 0x0029B278 File Offset: 0x00299478
		public static int DeleteDirectory(string dir)
		{
			return vtkDirectory.vtkDirectory_DeleteDirectory_01(dir);
		}

		// Token: 0x0601D84F RID: 120911
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectory_FileIsDirectory_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return true if the file is a directory.  If the file is not an
		/// absolute path, it is assumed to be relative to the opened
		/// directory. If no directory has been opened, it is assumed to
		/// be relative to the current working directory.
		/// </summary>
		// Token: 0x0601D850 RID: 120912 RVA: 0x0029B294 File Offset: 0x00299494
		public int FileIsDirectory(string name)
		{
			return vtkDirectory.vtkDirectory_FileIsDirectory_02(base.GetCppThis(), name);
		}

		// Token: 0x0601D851 RID: 120913
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectory_GetCurrentWorkingDirectory_03([MarshalAs(UnmanagedType.LPUTF8Str)] string buf, uint len);

		/// <summary>
		/// Get the current working directory.
		/// </summary>
		// Token: 0x0601D852 RID: 120914 RVA: 0x0029B2B4 File Offset: 0x002994B4
		public static string GetCurrentWorkingDirectory(string buf, uint len)
		{
			string s = Marshal.PtrToStringAnsi(vtkDirectory.vtkDirectory_GetCurrentWorkingDirectory_03(buf, len));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601D853 RID: 120915
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectory_GetFile_04(HandleRef pThis, long index);

		/// <summary>
		/// Return the file at the given index, the indexing is 0 based
		/// </summary>
		// Token: 0x0601D854 RID: 120916 RVA: 0x0029B2EC File Offset: 0x002994EC
		public string GetFile(long index)
		{
			string s = Marshal.PtrToStringAnsi(vtkDirectory.vtkDirectory_GetFile_04(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601D855 RID: 120917
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectory_GetFiles_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get an array that contains all the file names.
		/// </summary>
		// Token: 0x0601D856 RID: 120918 RVA: 0x0029B328 File Offset: 0x00299528
		public virtual vtkStringArray GetFiles()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectory.vtkDirectory_GetFiles_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D857 RID: 120919
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDirectory_GetNumberOfFiles_06(HandleRef pThis);

		/// <summary>
		/// Return the number of files in the current directory.
		/// </summary>
		// Token: 0x0601D858 RID: 120920 RVA: 0x0029B398 File Offset: 0x00299598
		public long GetNumberOfFiles()
		{
			return vtkDirectory.vtkDirectory_GetNumberOfFiles_06(base.GetCppThis());
		}

		// Token: 0x0601D859 RID: 120921
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDirectory_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Return the class name as a string.
		/// </summary>
		// Token: 0x0601D85A RID: 120922 RVA: 0x0029B3B8 File Offset: 0x002995B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDirectory.vtkDirectory_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601D85B RID: 120923
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDirectory_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Return the class name as a string.
		/// </summary>
		// Token: 0x0601D85C RID: 120924 RVA: 0x0029B3D8 File Offset: 0x002995D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDirectory.vtkDirectory_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601D85D RID: 120925
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectory_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Return the class name as a string.
		/// </summary>
		// Token: 0x0601D85E RID: 120926 RVA: 0x0029B3F4 File Offset: 0x002995F4
		public override int IsA(string type)
		{
			return vtkDirectory.vtkDirectory_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601D85F RID: 120927
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectory_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Return the class name as a string.
		/// </summary>
		// Token: 0x0601D860 RID: 120928 RVA: 0x0029B414 File Offset: 0x00299614
		public new static int IsTypeOf(string type)
		{
			return vtkDirectory.vtkDirectory_IsTypeOf_10(type);
		}

		// Token: 0x0601D861 RID: 120929
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectory_MakeDirectory_11([MarshalAs(UnmanagedType.LPUTF8Str)] string dir);

		/// <summary>
		/// Create directory.
		/// </summary>
		// Token: 0x0601D862 RID: 120930 RVA: 0x0029B430 File Offset: 0x00299630
		public static int MakeDirectory(string dir)
		{
			return vtkDirectory.vtkDirectory_MakeDirectory_11(dir);
		}

		// Token: 0x0601D863 RID: 120931
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectory_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the class name as a string.
		/// </summary>
		// Token: 0x0601D864 RID: 120932 RVA: 0x0029B44C File Offset: 0x0029964C
		public new vtkDirectory NewInstance()
		{
			vtkDirectory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectory.vtkDirectory_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDirectory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D865 RID: 120933
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectory_Open_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string dir);

		/// <summary>
		/// Open the specified directory and load the names of the files
		/// in that directory. 0 is returned if the directory can not be
		/// opened, 1 if it is opened.
		/// </summary>
		// Token: 0x0601D866 RID: 120934 RVA: 0x0029B4A8 File Offset: 0x002996A8
		public int Open(string dir)
		{
			return vtkDirectory.vtkDirectory_Open_14(base.GetCppThis(), dir);
		}

		// Token: 0x0601D867 RID: 120935
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectory_Rename_15([MarshalAs(UnmanagedType.LPUTF8Str)] string oldname, [MarshalAs(UnmanagedType.LPUTF8Str)] string newname);

		/// <summary>
		/// Rename a file or directory.
		/// </summary>
		// Token: 0x0601D868 RID: 120936 RVA: 0x0029B4C8 File Offset: 0x002996C8
		public static int Rename(string oldname, string newname)
		{
			return vtkDirectory.vtkDirectory_Rename_15(oldname, newname);
		}

		// Token: 0x0601D869 RID: 120937
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectory_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the class name as a string.
		/// </summary>
		// Token: 0x0601D86A RID: 120938 RVA: 0x0029B4E4 File Offset: 0x002996E4
		public new static vtkDirectory SafeDownCast(vtkObjectBase o)
		{
			vtkDirectory vtkDirectory = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectory.vtkDirectory_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectory = (vtkDirectory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectory.Register(null);
				}
			}
			return vtkDirectory;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F19 RID: 7961
		public new const string MRFullTypeName = "Kitware.VTK.vtkDirectory";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F1A RID: 7962
		public new static readonly string MRClassNameKey = "class vtkDirectory";
	}
}
