using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPDirectory
	///
	/// vtkPDirectory provides a portable way of finding the names of the files
	/// in a system directory where process 0 finds the information and
	/// broadcasts it to other processes. It tries to replicate the API for both
	/// Directory and vtkDirectory though there are slight mismatches between the
	/// two. This is a blocking collective operation.
	/// </summary>
	// Token: 0x020006F8 RID: 1784
	public class vtkPDirectory : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012CA9 RID: 76969 RVA: 0x001A71CB File Offset: 0x001A53CB
		static vtkPDirectory()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPDirectory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPDirectory"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012CAA RID: 76970 RVA: 0x001A71F3 File Offset: 0x001A53F3
		public vtkPDirectory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012CAB RID: 76971
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDirectory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CAC RID: 76972 RVA: 0x001A7204 File Offset: 0x001A5404
		public new static vtkPDirectory New()
		{
			vtkPDirectory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPDirectory.vtkPDirectory_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDirectory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CAD RID: 76973 RVA: 0x001A7258 File Offset: 0x001A5458
		public vtkPDirectory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPDirectory.vtkPDirectory_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012CAE RID: 76974 RVA: 0x001A729C File Offset: 0x001A549C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012CAF RID: 76975
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPDirectory_Clear_01(HandleRef pThis);

		/// <summary>
		/// Clear the internal structure. Used internally at beginning of Load(...)
		/// to clear the cache.
		/// </summary>
		// Token: 0x06012CB0 RID: 76976 RVA: 0x001A72A7 File Offset: 0x001A54A7
		public void Clear()
		{
			vtkPDirectory.vtkPDirectory_Clear_01(base.GetCppThis());
		}

		// Token: 0x06012CB1 RID: 76977
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDirectory_DeleteDirectory_02([MarshalAs(UnmanagedType.LPUTF8Str)] string dir);

		/// <summary>
		/// Remove a directory.
		/// </summary>
		// Token: 0x06012CB2 RID: 76978 RVA: 0x001A72B8 File Offset: 0x001A54B8
		public static int DeleteDirectory(string dir)
		{
			return vtkPDirectory.vtkPDirectory_DeleteDirectory_02(dir);
		}

		// Token: 0x06012CB3 RID: 76979
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDirectory_FileIsDirectory_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return true if the file is a directory.  If the file is not an
		/// absolute path, it is assumed to be relative to the opened
		/// directory. If no directory has been opened, it is assumed to
		/// be relative to the current working directory.
		/// </summary>
		// Token: 0x06012CB4 RID: 76980 RVA: 0x001A72D4 File Offset: 0x001A54D4
		public int FileIsDirectory(string name)
		{
			return vtkPDirectory.vtkPDirectory_FileIsDirectory_03(base.GetCppThis(), name);
		}

		// Token: 0x06012CB5 RID: 76981
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDirectory_GetCurrentWorkingDirectory_04([MarshalAs(UnmanagedType.LPUTF8Str)] string buf, uint len);

		/// <summary>
		/// Get the current working directory.
		/// </summary>
		// Token: 0x06012CB6 RID: 76982 RVA: 0x001A72F4 File Offset: 0x001A54F4
		public static string GetCurrentWorkingDirectory(string buf, uint len)
		{
			string s = Marshal.PtrToStringAnsi(vtkPDirectory.vtkPDirectory_GetCurrentWorkingDirectory_04(buf, len));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06012CB7 RID: 76983
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDirectory_GetFile_05(HandleRef pThis, long index);

		/// <summary>
		/// Return the file at the given index, the indexing is 0 based
		/// </summary>
		// Token: 0x06012CB8 RID: 76984 RVA: 0x001A732C File Offset: 0x001A552C
		public string GetFile(long index)
		{
			string s = Marshal.PtrToStringAnsi(vtkPDirectory.vtkPDirectory_GetFile_05(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06012CB9 RID: 76985
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDirectory_GetFiles_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get an array that contains all the file names.
		/// </summary>
		// Token: 0x06012CBA RID: 76986 RVA: 0x001A7368 File Offset: 0x001A5568
		public virtual vtkStringArray GetFiles()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPDirectory.vtkPDirectory_GetFiles_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012CBB RID: 76987
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPDirectory_GetNumberOfFiles_07(HandleRef pThis);

		/// <summary>
		/// Return the number of files in the current directory.
		/// </summary>
		// Token: 0x06012CBC RID: 76988 RVA: 0x001A73D8 File Offset: 0x001A55D8
		public long GetNumberOfFiles()
		{
			return vtkPDirectory.vtkPDirectory_GetNumberOfFiles_07(base.GetCppThis());
		}

		// Token: 0x06012CBD RID: 76989
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPDirectory_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CBE RID: 76990 RVA: 0x001A73F8 File Offset: 0x001A55F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPDirectory.vtkPDirectory_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06012CBF RID: 76991
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPDirectory_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CC0 RID: 76992 RVA: 0x001A7418 File Offset: 0x001A5618
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPDirectory.vtkPDirectory_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06012CC1 RID: 76993
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDirectory_GetPath_10(HandleRef pThis);

		/// <summary>
		/// Return the path to Open'ed directory
		/// </summary>
		// Token: 0x06012CC2 RID: 76994 RVA: 0x001A7434 File Offset: 0x001A5634
		public string GetPath()
		{
			string s = Marshal.PtrToStringAnsi(vtkPDirectory.vtkPDirectory_GetPath_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06012CC3 RID: 76995
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDirectory_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CC4 RID: 76996 RVA: 0x001A7470 File Offset: 0x001A5670
		public override int IsA(string type)
		{
			return vtkPDirectory.vtkPDirectory_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06012CC5 RID: 76997
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDirectory_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CC6 RID: 76998 RVA: 0x001A7490 File Offset: 0x001A5690
		public new static int IsTypeOf(string type)
		{
			return vtkPDirectory.vtkPDirectory_IsTypeOf_12(type);
		}

		// Token: 0x06012CC7 RID: 76999
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPDirectory_Load_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Open/Load the specified directory and load the names of the files
		/// in that directory. false/0 is returned if the directory can not be
		/// opened, true/1 if it is opened. The reason that there are two versions
		/// of this is that Directory uses Load() and vtkDirectory uses Open()
		/// for this functionality.
		/// </summary>
		// Token: 0x06012CC8 RID: 77000 RVA: 0x001A74AC File Offset: 0x001A56AC
		public bool Load(string arg0)
		{
			return vtkPDirectory.vtkPDirectory_Load_13(base.GetCppThis(), arg0) != 0;
		}

		// Token: 0x06012CC9 RID: 77001
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDirectory_MakeDirectory_14([MarshalAs(UnmanagedType.LPUTF8Str)] string dir);

		/// <summary>
		/// Create directory.
		/// </summary>
		// Token: 0x06012CCA RID: 77002 RVA: 0x001A74D4 File Offset: 0x001A56D4
		public static int MakeDirectory(string dir)
		{
			return vtkPDirectory.vtkPDirectory_MakeDirectory_14(dir);
		}

		// Token: 0x06012CCB RID: 77003
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDirectory_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CCC RID: 77004 RVA: 0x001A74F0 File Offset: 0x001A56F0
		public new vtkPDirectory NewInstance()
		{
			vtkPDirectory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPDirectory.vtkPDirectory_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDirectory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012CCD RID: 77005
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDirectory_Open_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string dir);

		/// <summary>
		/// Open/Load the specified directory and load the names of the files
		/// in that directory. false/0 is returned if the directory can not be
		/// opened, true/1 if it is opened. The reason that there are two versions
		/// of this is that Directory uses Load() and vtkDirectory uses Open()
		/// for this functionality.
		/// </summary>
		// Token: 0x06012CCE RID: 77006 RVA: 0x001A754C File Offset: 0x001A574C
		public int Open(string dir)
		{
			return vtkPDirectory.vtkPDirectory_Open_17(base.GetCppThis(), dir);
		}

		// Token: 0x06012CCF RID: 77007
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDirectory_Rename_18([MarshalAs(UnmanagedType.LPUTF8Str)] string oldname, [MarshalAs(UnmanagedType.LPUTF8Str)] string newname);

		/// <summary>
		/// Rename a file or directory.
		/// </summary>
		// Token: 0x06012CD0 RID: 77008 RVA: 0x001A756C File Offset: 0x001A576C
		public static int Rename(string oldname, string newname)
		{
			return vtkPDirectory.vtkPDirectory_Rename_18(oldname, newname);
		}

		// Token: 0x06012CD1 RID: 77009
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDirectory_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CD2 RID: 77010 RVA: 0x001A7588 File Offset: 0x001A5788
		public new static vtkPDirectory SafeDownCast(vtkObjectBase o)
		{
			vtkPDirectory vtkPDirectory = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPDirectory.vtkPDirectory_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPDirectory = (vtkPDirectory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPDirectory.Register(null);
				}
			}
			return vtkPDirectory;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015B7 RID: 5559
		public new const string MRFullTypeName = "Kitware.VTK.vtkPDirectory";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015B8 RID: 5560
		public new static readonly string MRClassNameKey = "class vtkPDirectory";
	}
}
