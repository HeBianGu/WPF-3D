using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGlobFileNames
	/// </summary>
	/// <remarks>
	///    find files that match a wildcard pattern
	///
	/// vtkGlobFileNames is a utility for finding files and directories
	/// that match a given wildcard pattern.  Allowed wildcards are
	/// *, ?, [...], [!...]. The "*" wildcard matches any substring,
	/// the "?" matches any single character, the [...] matches any one of
	/// the enclosed characters, e.g. [abc] will match one of a, b, or c,
	/// while [0-9] will match any digit, and [!...] will match any single
	/// character except for the ones within the brackets.  Special
	/// treatment is given to "/" (or "\" on Windows) because these are
	/// path separators.  These are never matched by a wildcard, they are
	/// only matched with another file separator.
	/// @warning
	/// This function performs case-sensitive matches on UNIX and
	/// case-insensitive matches on Windows.
	/// </remarks>
	/// <seealso>
	///
	/// vtkDirectory
	/// </seealso>
	// Token: 0x0200072C RID: 1836
	public class vtkGlobFileNames : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060132AA RID: 78506 RVA: 0x001B190B File Offset: 0x001AFB0B
		static vtkGlobFileNames()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGlobFileNames.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGlobFileNames"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060132AB RID: 78507 RVA: 0x001B1933 File Offset: 0x001AFB33
		public vtkGlobFileNames(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060132AC RID: 78508
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlobFileNames_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a new vtkGlobFileNames object.
		/// </summary>
		// Token: 0x060132AD RID: 78509 RVA: 0x001B1944 File Offset: 0x001AFB44
		public new static vtkGlobFileNames New()
		{
			vtkGlobFileNames result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlobFileNames.vtkGlobFileNames_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlobFileNames)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create a new vtkGlobFileNames object.
		/// </summary>
		// Token: 0x060132AE RID: 78510 RVA: 0x001B1998 File Offset: 0x001AFB98
		public vtkGlobFileNames() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGlobFileNames.vtkGlobFileNames_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060132AF RID: 78511 RVA: 0x001B19DC File Offset: 0x001AFBDC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060132B0 RID: 78512
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlobFileNames_AddFileNames_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string pattern);

		/// <summary>
		/// Search for all files that match the given expression,
		/// sort them, and add them to the output.  This method can
		/// be called repeatedly to add files matching additional patterns.
		/// Returns 1 if successful, otherwise returns zero.
		/// </summary>
		// Token: 0x060132B1 RID: 78513 RVA: 0x001B19E8 File Offset: 0x001AFBE8
		public int AddFileNames(string pattern)
		{
			return vtkGlobFileNames.vtkGlobFileNames_AddFileNames_01(base.GetCppThis(), pattern);
		}

		// Token: 0x060132B2 RID: 78514
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlobFileNames_GetDirectory_02(HandleRef pThis);

		/// <summary>
		/// Set the directory in which to perform the glob.  If this is
		/// not set, then the current directory will be used.  Also, if
		/// you use a glob pattern that contains absolute path (one that
		/// starts with "/" or a drive letter) then that absolute path
		/// will be used and Directory will be ignored.
		/// </summary>
		// Token: 0x060132B3 RID: 78515 RVA: 0x001B1A08 File Offset: 0x001AFC08
		public virtual string GetDirectory()
		{
			string s = Marshal.PtrToStringAnsi(vtkGlobFileNames.vtkGlobFileNames_GetDirectory_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060132B4 RID: 78516
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlobFileNames_GetFileNames_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get an array that contains all the file names.
		/// </summary>
		// Token: 0x060132B5 RID: 78517 RVA: 0x001B1A44 File Offset: 0x001AFC44
		public virtual vtkStringArray GetFileNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlobFileNames.vtkGlobFileNames_GetFileNames_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060132B6 RID: 78518
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlobFileNames_GetNthFileName_04(HandleRef pThis, int index);

		/// <summary>
		/// Return the file at the given index, the indexing is 0 based.
		/// </summary>
		// Token: 0x060132B7 RID: 78519 RVA: 0x001B1AB4 File Offset: 0x001AFCB4
		public string GetNthFileName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkGlobFileNames.vtkGlobFileNames_GetNthFileName_04(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060132B8 RID: 78520
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlobFileNames_GetNumberOfFileNames_05(HandleRef pThis);

		/// <summary>
		/// Return the number of files found.
		/// </summary>
		// Token: 0x060132B9 RID: 78521 RVA: 0x001B1AF0 File Offset: 0x001AFCF0
		public int GetNumberOfFileNames()
		{
			return vtkGlobFileNames.vtkGlobFileNames_GetNumberOfFileNames_05(base.GetCppThis());
		}

		// Token: 0x060132BA RID: 78522
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGlobFileNames_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Return the class name as a string.
		/// </summary>
		// Token: 0x060132BB RID: 78523 RVA: 0x001B1B10 File Offset: 0x001AFD10
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGlobFileNames.vtkGlobFileNames_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060132BC RID: 78524
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGlobFileNames_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Return the class name as a string.
		/// </summary>
		// Token: 0x060132BD RID: 78525 RVA: 0x001B1B30 File Offset: 0x001AFD30
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGlobFileNames.vtkGlobFileNames_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060132BE RID: 78526
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlobFileNames_GetRecurse_08(HandleRef pThis);

		/// <summary>
		/// Recurse into subdirectories.
		/// </summary>
		// Token: 0x060132BF RID: 78527 RVA: 0x001B1B4C File Offset: 0x001AFD4C
		public virtual int GetRecurse()
		{
			return vtkGlobFileNames.vtkGlobFileNames_GetRecurse_08(base.GetCppThis());
		}

		// Token: 0x060132C0 RID: 78528
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlobFileNames_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Return the class name as a string.
		/// </summary>
		// Token: 0x060132C1 RID: 78529 RVA: 0x001B1B6C File Offset: 0x001AFD6C
		public override int IsA(string type)
		{
			return vtkGlobFileNames.vtkGlobFileNames_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x060132C2 RID: 78530
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlobFileNames_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Return the class name as a string.
		/// </summary>
		// Token: 0x060132C3 RID: 78531 RVA: 0x001B1B8C File Offset: 0x001AFD8C
		public new static int IsTypeOf(string type)
		{
			return vtkGlobFileNames.vtkGlobFileNames_IsTypeOf_10(type);
		}

		// Token: 0x060132C4 RID: 78532
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlobFileNames_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the class name as a string.
		/// </summary>
		// Token: 0x060132C5 RID: 78533 RVA: 0x001B1BA8 File Offset: 0x001AFDA8
		public new vtkGlobFileNames NewInstance()
		{
			vtkGlobFileNames result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlobFileNames.vtkGlobFileNames_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlobFileNames)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060132C6 RID: 78534
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlobFileNames_RecurseOff_13(HandleRef pThis);

		/// <summary>
		/// Recurse into subdirectories.
		/// </summary>
		// Token: 0x060132C7 RID: 78535 RVA: 0x001B1C02 File Offset: 0x001AFE02
		public virtual void RecurseOff()
		{
			vtkGlobFileNames.vtkGlobFileNames_RecurseOff_13(base.GetCppThis());
		}

		// Token: 0x060132C8 RID: 78536
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlobFileNames_RecurseOn_14(HandleRef pThis);

		/// <summary>
		/// Recurse into subdirectories.
		/// </summary>
		// Token: 0x060132C9 RID: 78537 RVA: 0x001B1C11 File Offset: 0x001AFE11
		public virtual void RecurseOn()
		{
			vtkGlobFileNames.vtkGlobFileNames_RecurseOn_14(base.GetCppThis());
		}

		// Token: 0x060132CA RID: 78538
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlobFileNames_Reset_15(HandleRef pThis);

		/// <summary>
		/// Reset the glob by clearing the list of output filenames.
		/// </summary>
		// Token: 0x060132CB RID: 78539 RVA: 0x001B1C20 File Offset: 0x001AFE20
		public void Reset()
		{
			vtkGlobFileNames.vtkGlobFileNames_Reset_15(base.GetCppThis());
		}

		// Token: 0x060132CC RID: 78540
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlobFileNames_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the class name as a string.
		/// </summary>
		// Token: 0x060132CD RID: 78541 RVA: 0x001B1C30 File Offset: 0x001AFE30
		public new static vtkGlobFileNames SafeDownCast(vtkObjectBase o)
		{
			vtkGlobFileNames vtkGlobFileNames = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlobFileNames.vtkGlobFileNames_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGlobFileNames = (vtkGlobFileNames)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGlobFileNames.Register(null);
				}
			}
			return vtkGlobFileNames;
		}

		// Token: 0x060132CE RID: 78542
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlobFileNames_SetDirectory_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the directory in which to perform the glob.  If this is
		/// not set, then the current directory will be used.  Also, if
		/// you use a glob pattern that contains absolute path (one that
		/// starts with "/" or a drive letter) then that absolute path
		/// will be used and Directory will be ignored.
		/// </summary>
		// Token: 0x060132CF RID: 78543 RVA: 0x001B1CAF File Offset: 0x001AFEAF
		public virtual void SetDirectory(string _arg)
		{
			vtkGlobFileNames.vtkGlobFileNames_SetDirectory_17(base.GetCppThis(), _arg);
		}

		// Token: 0x060132D0 RID: 78544
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlobFileNames_SetRecurse_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Recurse into subdirectories.
		/// </summary>
		// Token: 0x060132D1 RID: 78545 RVA: 0x001B1CBF File Offset: 0x001AFEBF
		public virtual void SetRecurse(int _arg)
		{
			vtkGlobFileNames.vtkGlobFileNames_SetRecurse_18(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001626 RID: 5670
		public new const string MRFullTypeName = "Kitware.VTK.vtkGlobFileNames";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001627 RID: 5671
		public new static readonly string MRClassNameKey = "class vtkGlobFileNames";
	}
}
