using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkResourceFileLocator
	/// </summary>
	/// <remarks>
	///  utility to locate resource files.
	///
	/// VTK based application often need to locate resource files, such configuration
	/// files, Python modules, etc. vtkResourceFileLocator provides methods that can
	/// be used to locate such resource files at runtime.
	///
	/// Using `Locate`, one can locate files relative to an
	/// anchor directory such as the executable directory, or the library directory.
	///
	/// `GetLibraryPathForSymbolUnix` and `GetLibraryPathForSymbolWin32` methods can
	/// be used to locate the library that provides a particular symbol. For example,
	/// this is used by `vtkPythonInterpreter` to ensure that the `vtk` Python package
	/// is located relative the VTK libraries, irrespective of the application location.
	/// </remarks>
	// Token: 0x02000B05 RID: 2821
	public class vtkResourceFileLocator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DA37 RID: 121399 RVA: 0x0029D8B6 File Offset: 0x0029BAB6
		static vtkResourceFileLocator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkResourceFileLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkResourceFileLocator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DA38 RID: 121400 RVA: 0x0029D8DE File Offset: 0x0029BADE
		public vtkResourceFileLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DA39 RID: 121401
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResourceFileLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA3A RID: 121402 RVA: 0x0029D8EC File Offset: 0x0029BAEC
		public new static vtkResourceFileLocator New()
		{
			vtkResourceFileLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResourceFileLocator.vtkResourceFileLocator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResourceFileLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA3B RID: 121403 RVA: 0x0029D940 File Offset: 0x0029BB40
		public vtkResourceFileLocator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkResourceFileLocator.vtkResourceFileLocator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DA3C RID: 121404 RVA: 0x0029D984 File Offset: 0x0029BB84
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DA3D RID: 121405
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkResourceFileLocator_GetLibraryPathForSymbolUnix_01([MarshalAs(UnmanagedType.LPUTF8Str)] string symbolname);

		/// <summary>
		/// Returns the name of the library providing the symbol. For example, if you
		/// want to locate where the VTK libraries located call
		/// `GetLibraryPathForSymbolUnix("GetVTKVersion")` on Unixes and
		/// `GetLibraryPathForSymbolWin32(GetVTKVersion)` on Windows. Alternatively, you
		/// can simply use the `vtkGetLibraryPathForSymbol(GetVTKVersion)` macro
		/// that makes the appropriate call as per the current platform.
		/// </summary>
		// Token: 0x0601DA3E RID: 121406 RVA: 0x0029D990 File Offset: 0x0029BB90
		public static string GetLibraryPathForSymbolUnix(string symbolname)
		{
			return vtkResourceFileLocator.vtkResourceFileLocator_GetLibraryPathForSymbolUnix_01(symbolname);
		}

		// Token: 0x0601DA3F RID: 121407
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkResourceFileLocator_GetLibraryPathForSymbolWin32_02(IntPtr fptr);

		/// <summary>
		/// Returns the name of the library providing the symbol. For example, if you
		/// want to locate where the VTK libraries located call
		/// `GetLibraryPathForSymbolUnix("GetVTKVersion")` on Unixes and
		/// `GetLibraryPathForSymbolWin32(GetVTKVersion)` on Windows. Alternatively, you
		/// can simply use the `vtkGetLibraryPathForSymbol(GetVTKVersion)` macro
		/// that makes the appropriate call as per the current platform.
		/// </summary>
		// Token: 0x0601DA40 RID: 121408 RVA: 0x0029D9AC File Offset: 0x0029BBAC
		public static string GetLibraryPathForSymbolWin32(IntPtr fptr)
		{
			return vtkResourceFileLocator.vtkResourceFileLocator_GetLibraryPathForSymbolWin32_02(fptr);
		}

		// Token: 0x0601DA41 RID: 121409
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResourceFileLocator_GetLogVerbosity_03(HandleRef pThis);

		/// <summary>
		/// The log verbosity to use when logging information about the resource
		/// searching. Default is `vtkLogger::VERBOSITY_TRACE`.
		/// </summary>
		// Token: 0x0601DA42 RID: 121410 RVA: 0x0029D9C8 File Offset: 0x0029BBC8
		public virtual int GetLogVerbosity()
		{
			return vtkResourceFileLocator.vtkResourceFileLocator_GetLogVerbosity_03(base.GetCppThis());
		}

		// Token: 0x0601DA43 RID: 121411
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResourceFileLocator_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA44 RID: 121412 RVA: 0x0029D9E8 File Offset: 0x0029BBE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkResourceFileLocator.vtkResourceFileLocator_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601DA45 RID: 121413
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResourceFileLocator_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA46 RID: 121414 RVA: 0x0029DA08 File Offset: 0x0029BC08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkResourceFileLocator.vtkResourceFileLocator_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601DA47 RID: 121415
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResourceFileLocator_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA48 RID: 121416 RVA: 0x0029DA24 File Offset: 0x0029BC24
		public override int IsA(string type)
		{
			return vtkResourceFileLocator.vtkResourceFileLocator_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601DA49 RID: 121417
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResourceFileLocator_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA4A RID: 121418 RVA: 0x0029DA44 File Offset: 0x0029BC44
		public new static int IsTypeOf(string type)
		{
			return vtkResourceFileLocator.vtkResourceFileLocator_IsTypeOf_07(type);
		}

		// Token: 0x0601DA4B RID: 121419
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkResourceFileLocator_Locate_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string anchor, [MarshalAs(UnmanagedType.LPUTF8Str)] string landmark, [MarshalAs(UnmanagedType.LPUTF8Str)] string defaultDir);

		/// <summary>
		/// Given a starting anchor directory, look for the landmark file relative to
		/// the anchor. If found return the anchor. If not found, go one directory up
		/// and then look the landmark file again.
		/// </summary>
		// Token: 0x0601DA4C RID: 121420 RVA: 0x0029DA60 File Offset: 0x0029BC60
		public virtual string Locate(string anchor, string landmark, string defaultDir)
		{
			return vtkResourceFileLocator.vtkResourceFileLocator_Locate_08(base.GetCppThis(), anchor, landmark, defaultDir);
		}

		// Token: 0x0601DA4D RID: 121421
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResourceFileLocator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA4E RID: 121422 RVA: 0x0029DA84 File Offset: 0x0029BC84
		public new vtkResourceFileLocator NewInstance()
		{
			vtkResourceFileLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResourceFileLocator.vtkResourceFileLocator_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResourceFileLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DA4F RID: 121423
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResourceFileLocator_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DA50 RID: 121424 RVA: 0x0029DAE0 File Offset: 0x0029BCE0
		public new static vtkResourceFileLocator SafeDownCast(vtkObjectBase o)
		{
			vtkResourceFileLocator vtkResourceFileLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResourceFileLocator.vtkResourceFileLocator_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResourceFileLocator = (vtkResourceFileLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResourceFileLocator.Register(null);
				}
			}
			return vtkResourceFileLocator;
		}

		// Token: 0x0601DA51 RID: 121425
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResourceFileLocator_SetLogVerbosity_12(HandleRef pThis, int _arg);

		/// <summary>
		/// The log verbosity to use when logging information about the resource
		/// searching. Default is `vtkLogger::VERBOSITY_TRACE`.
		/// </summary>
		// Token: 0x0601DA52 RID: 121426 RVA: 0x0029DB5F File Offset: 0x0029BD5F
		public virtual void SetLogVerbosity(int _arg)
		{
			vtkResourceFileLocator.vtkResourceFileLocator_SetLogVerbosity_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F3B RID: 7995
		public new const string MRFullTypeName = "Kitware.VTK.vtkResourceFileLocator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F3C RID: 7996
		public new static readonly string MRClassNameKey = "class vtkResourceFileLocator";
	}
}
