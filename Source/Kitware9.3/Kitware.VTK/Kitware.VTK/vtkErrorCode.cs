using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkErrorCode
	/// </summary>
	/// <remarks>
	///    superclass for error codes
	///
	/// vtkErrorCode is an mechanism for (currently) reader object to
	/// return errors during reading file.
	/// </remarks>
	// Token: 0x02000AFF RID: 2815
	public class vtkErrorCode : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D93F RID: 121151 RVA: 0x0029C6F0 File Offset: 0x0029A8F0
		static vtkErrorCode()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkErrorCode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkErrorCode"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D940 RID: 121152 RVA: 0x0029C718 File Offset: 0x0029A918
		public vtkErrorCode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D941 RID: 121153 RVA: 0x0029C726 File Offset: 0x0029A926
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D942 RID: 121154
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkErrorCode_GetErrorCodeFromString_01([MarshalAs(UnmanagedType.LPUTF8Str)] string error);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D943 RID: 121155 RVA: 0x0029C734 File Offset: 0x0029A934
		public static uint GetErrorCodeFromString(string error)
		{
			return vtkErrorCode.vtkErrorCode_GetErrorCodeFromString_01(error);
		}

		// Token: 0x0601D944 RID: 121156
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkErrorCode_GetLastSystemError_02();

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D945 RID: 121157 RVA: 0x0029C750 File Offset: 0x0029A950
		public static uint GetLastSystemError()
		{
			return vtkErrorCode.vtkErrorCode_GetLastSystemError_02();
		}

		// Token: 0x0601D946 RID: 121158
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkErrorCode_GetStringFromErrorCode_03(uint error);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D947 RID: 121159 RVA: 0x0029C76C File Offset: 0x0029A96C
		public static string GetStringFromErrorCode(uint error)
		{
			string s = Marshal.PtrToStringAnsi(vtkErrorCode.vtkErrorCode_GetStringFromErrorCode_03(error));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F25 RID: 7973
		public new const string MRFullTypeName = "Kitware.VTK.vtkErrorCode";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F26 RID: 7974
		public new static readonly string MRClassNameKey = "class vtkErrorCode";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000B00 RID: 2816
		public enum ErrorIds
		{
			/// <summary>enum member</summary>
			// Token: 0x04001F28 RID: 7976
			CannotOpenFileError = 20002,
			/// <summary>enum member</summary>
			// Token: 0x04001F29 RID: 7977
			FileFormatError = 20005,
			/// <summary>enum member</summary>
			// Token: 0x04001F2A RID: 7978
			FileNotFoundError = 20001,
			/// <summary>enum member</summary>
			// Token: 0x04001F2B RID: 7979
			FirstVTKErrorCode = 20000,
			/// <summary>enum member</summary>
			// Token: 0x04001F2C RID: 7980
			NoError = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001F2D RID: 7981
			NoFileNameError = 20006,
			/// <summary>enum member</summary>
			// Token: 0x04001F2E RID: 7982
			OutOfDiskSpaceError,
			/// <summary>enum member</summary>
			// Token: 0x04001F2F RID: 7983
			PrematureEndOfFileError = 20004,
			/// <summary>enum member</summary>
			// Token: 0x04001F30 RID: 7984
			UnknownError = 20008,
			/// <summary>enum member</summary>
			// Token: 0x04001F31 RID: 7985
			UnrecognizedFileTypeError = 20003,
			/// <summary>enum member</summary>
			// Token: 0x04001F32 RID: 7986
			UserError = 40000
		}
	}
}
