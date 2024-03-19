using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPSystemTools
	/// </summary>
	/// <remarks>
	///    System tools for file system introspection
	///
	/// A class with only static methods for doing parallel file system
	/// introspection. It limits doing file stats on process 0 and
	/// broadcasting the results to other processes. It is built on VTK's
	/// SystemTools class and uses the global controller for communication.
	/// It uses blocking collective communication operations.
	/// </remarks>
	// Token: 0x020006FB RID: 1787
	public class vtkPSystemTools : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012D14 RID: 77076 RVA: 0x001A7C9B File Offset: 0x001A5E9B
		static vtkPSystemTools()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPSystemTools.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPSystemTools"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012D15 RID: 77077 RVA: 0x001A7CC3 File Offset: 0x001A5EC3
		public vtkPSystemTools(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012D16 RID: 77078
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPSystemTools_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D17 RID: 77079 RVA: 0x001A7CD4 File Offset: 0x001A5ED4
		public new static vtkPSystemTools New()
		{
			vtkPSystemTools result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPSystemTools.vtkPSystemTools_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPSystemTools)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D18 RID: 77080 RVA: 0x001A7D28 File Offset: 0x001A5F28
		public vtkPSystemTools() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPSystemTools.vtkPSystemTools_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012D19 RID: 77081 RVA: 0x001A7D6C File Offset: 0x001A5F6C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012D1A RID: 77082
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPSystemTools_BroadcastString_01([MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, int proc);

		/// <summary>
		/// Given a string on process proc, broadcast that string to
		/// all of the other processes. This method does not have a
		/// correspondence to anything in SystemTools.
		/// </summary>
		// Token: 0x06012D1B RID: 77083 RVA: 0x001A7D77 File Offset: 0x001A5F77
		public static void BroadcastString(string arg0, int proc)
		{
			vtkPSystemTools.vtkPSystemTools_BroadcastString_01(arg0, proc);
		}

		// Token: 0x06012D1C RID: 77084
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPSystemTools_CollapseFullPath_02([MarshalAs(UnmanagedType.LPUTF8Str)] string in_relative);

		/// <summary>
		/// Given a path to a file or directory, convert it to a full path.
		/// This collapses away relative paths relative to the cwd argument
		/// (which defaults to the current working directory).  The full path
		/// is returned.
		/// </summary>
		// Token: 0x06012D1D RID: 77085 RVA: 0x001A7D84 File Offset: 0x001A5F84
		public static string CollapseFullPath(string in_relative)
		{
			return vtkPSystemTools.vtkPSystemTools_CollapseFullPath_02(in_relative);
		}

		// Token: 0x06012D1E RID: 77086
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPSystemTools_CollapseFullPath_03([MarshalAs(UnmanagedType.LPUTF8Str)] string in_relative, [MarshalAs(UnmanagedType.LPUTF8Str)] string in_base);

		/// <summary>
		/// Given a path to a file or directory, convert it to a full path.
		/// This collapses away relative paths relative to the cwd argument
		/// (which defaults to the current working directory).  The full path
		/// is returned.
		/// </summary>
		// Token: 0x06012D1F RID: 77087 RVA: 0x001A7DA0 File Offset: 0x001A5FA0
		public static string CollapseFullPath(string in_relative, string in_base)
		{
			return vtkPSystemTools.vtkPSystemTools_CollapseFullPath_03(in_relative, in_base);
		}

		// Token: 0x06012D20 RID: 77088
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPSystemTools_FileExists_04([MarshalAs(UnmanagedType.LPUTF8Str)] string filename, byte isFile);

		/// <summary>
		/// Return true if a file exists in the current directory.
		/// If isFile = true, then make sure the file is a file and
		/// not a directory.  If isFile = false, then return true
		/// if it is a file or a directory.  Note that the file will
		/// also be checked for read access.  (Currently, this check
		/// for read access is only done on POSIX systems.)
		/// </summary>
		// Token: 0x06012D21 RID: 77089 RVA: 0x001A7DBC File Offset: 0x001A5FBC
		public static bool FileExists(string filename, bool isFile)
		{
			return vtkPSystemTools.vtkPSystemTools_FileExists_04(filename, isFile ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x06012D22 RID: 77090
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPSystemTools_FileExists_05([MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		/// Return true if a file exists in the current directory.
		/// If isFile = true, then make sure the file is a file and
		/// not a directory.  If isFile = false, then return true
		/// if it is a file or a directory.  Note that the file will
		/// also be checked for read access.  (Currently, this check
		/// for read access is only done on POSIX systems.)
		/// </summary>
		// Token: 0x06012D23 RID: 77091 RVA: 0x001A7DE8 File Offset: 0x001A5FE8
		public static bool FileExists(string filename)
		{
			return vtkPSystemTools.vtkPSystemTools_FileExists_05(filename) != 0;
		}

		// Token: 0x06012D24 RID: 77092
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPSystemTools_FileIsDirectory_06([MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return true if the file is a directory
		/// </summary>
		// Token: 0x06012D25 RID: 77093 RVA: 0x001A7E0C File Offset: 0x001A600C
		public static bool FileIsDirectory(string name)
		{
			return vtkPSystemTools.vtkPSystemTools_FileIsDirectory_06(name) != 0;
		}

		// Token: 0x06012D26 RID: 77094
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPSystemTools_FindProgramPath_07([MarshalAs(UnmanagedType.LPUTF8Str)] string argv0, [MarshalAs(UnmanagedType.LPUTF8Str)] string pathOut, [MarshalAs(UnmanagedType.LPUTF8Str)] string errorMsg, [MarshalAs(UnmanagedType.LPUTF8Str)] string exeName, [MarshalAs(UnmanagedType.LPUTF8Str)] string buildDir, [MarshalAs(UnmanagedType.LPUTF8Str)] string installPrefix);

		/// <summary>
		/// Given argv[0] for a unix program find the full path to a running
		/// executable.  argv0 can be null for windows WinMain programs
		/// in this case GetModuleFileName will be used to find the path
		/// to the running executable.  If argv0 is not a full path,
		/// then this will try to find the full path.  If the path is not
		/// found false is returned, if found true is returned.  An error
		/// message of the attempted paths is stored in errorMsg.
		/// exeName is the name of the executable.
		/// buildDir is a possibly null path to the build directory.
		/// installPrefix is a possibly null pointer to the install directory.
		/// </summary>
		// Token: 0x06012D27 RID: 77095 RVA: 0x001A7E30 File Offset: 0x001A6030
		public static bool FindProgramPath(string argv0, string pathOut, string errorMsg, string exeName, string buildDir, string installPrefix)
		{
			return vtkPSystemTools.vtkPSystemTools_FindProgramPath_07(argv0, pathOut, errorMsg, exeName, buildDir, installPrefix) != 0;
		}

		// Token: 0x06012D28 RID: 77096
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPSystemTools_GetCurrentWorkingDirectory_08(byte collapse);

		/// <summary>
		/// Get current working directory CWD
		/// </summary>
		// Token: 0x06012D29 RID: 77097 RVA: 0x001A7E58 File Offset: 0x001A6058
		public static string GetCurrentWorkingDirectory(bool collapse)
		{
			return vtkPSystemTools.vtkPSystemTools_GetCurrentWorkingDirectory_08(collapse ? (byte)1 : (byte)0);
		}

		// Token: 0x06012D2A RID: 77098
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPSystemTools_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D2B RID: 77099 RVA: 0x001A7E7C File Offset: 0x001A607C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPSystemTools.vtkPSystemTools_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06012D2C RID: 77100
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPSystemTools_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D2D RID: 77101 RVA: 0x001A7E9C File Offset: 0x001A609C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPSystemTools.vtkPSystemTools_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06012D2E RID: 77102
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkPSystemTools_GetProgramPath_11([MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Given the path to a program executable, get the directory part of
		/// the path with the file stripped off.  If there is no directory
		/// part, the empty string is returned.
		/// </summary>
		// Token: 0x06012D2F RID: 77103 RVA: 0x001A7EB8 File Offset: 0x001A60B8
		public static string GetProgramPath(string arg0)
		{
			return vtkPSystemTools.vtkPSystemTools_GetProgramPath_11(arg0);
		}

		// Token: 0x06012D30 RID: 77104
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPSystemTools_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D31 RID: 77105 RVA: 0x001A7ED4 File Offset: 0x001A60D4
		public override int IsA(string type)
		{
			return vtkPSystemTools.vtkPSystemTools_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06012D32 RID: 77106
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPSystemTools_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D33 RID: 77107 RVA: 0x001A7EF4 File Offset: 0x001A60F4
		public new static int IsTypeOf(string type)
		{
			return vtkPSystemTools.vtkPSystemTools_IsTypeOf_13(type);
		}

		// Token: 0x06012D34 RID: 77108
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPSystemTools_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D35 RID: 77109 RVA: 0x001A7F10 File Offset: 0x001A6110
		public new vtkPSystemTools NewInstance()
		{
			vtkPSystemTools result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPSystemTools.vtkPSystemTools_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPSystemTools)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012D36 RID: 77110
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPSystemTools_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D37 RID: 77111 RVA: 0x001A7F6C File Offset: 0x001A616C
		public new static vtkPSystemTools SafeDownCast(vtkObjectBase o)
		{
			vtkPSystemTools vtkPSystemTools = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPSystemTools.vtkPSystemTools_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPSystemTools = (vtkPSystemTools)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPSystemTools.Register(null);
				}
			}
			return vtkPSystemTools;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015BD RID: 5565
		public new const string MRFullTypeName = "Kitware.VTK.vtkPSystemTools";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015BE RID: 5566
		public new static readonly string MRClassNameKey = "class vtkPSystemTools";
	}
}
