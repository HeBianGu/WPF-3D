using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDelimitedTextWriter
	/// </summary>
	/// <remarks>
	///    Delimited text writer for vtkTable
	/// Writes a vtkTable as a delimited text file (such as CSV).
	/// </remarks>
	// Token: 0x02000728 RID: 1832
	public class vtkDelimitedTextWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013247 RID: 78407 RVA: 0x001B0FCA File Offset: 0x001AF1CA
		static vtkDelimitedTextWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDelimitedTextWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDelimitedTextWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013248 RID: 78408 RVA: 0x001B0FF2 File Offset: 0x001AF1F2
		public vtkDelimitedTextWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013249 RID: 78409
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601324A RID: 78410 RVA: 0x001B1000 File Offset: 0x001AF200
		public new static vtkDelimitedTextWriter New()
		{
			vtkDelimitedTextWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDelimitedTextWriter.vtkDelimitedTextWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDelimitedTextWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601324B RID: 78411 RVA: 0x001B1054 File Offset: 0x001AF254
		public vtkDelimitedTextWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDelimitedTextWriter.vtkDelimitedTextWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601324C RID: 78412 RVA: 0x001B1098 File Offset: 0x001AF298
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601324D RID: 78413
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextWriter_GetFieldDelimiter_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the delimiter use to separate fields ("," by default.)
		/// </summary>
		// Token: 0x0601324E RID: 78414 RVA: 0x001B10A4 File Offset: 0x001AF2A4
		public virtual string GetFieldDelimiter()
		{
			string s = Marshal.PtrToStringAnsi(vtkDelimitedTextWriter.vtkDelimitedTextWriter_GetFieldDelimiter_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601324F RID: 78415
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextWriter_GetFileName_02(HandleRef pThis);

		/// <summary>
		/// Get/Set the filename for the file.
		/// </summary>
		// Token: 0x06013250 RID: 78416 RVA: 0x001B10E0 File Offset: 0x001AF2E0
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDelimitedTextWriter.vtkDelimitedTextWriter_GetFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013251 RID: 78417
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDelimitedTextWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013252 RID: 78418 RVA: 0x001B111C File Offset: 0x001AF31C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDelimitedTextWriter.vtkDelimitedTextWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06013253 RID: 78419
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDelimitedTextWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013254 RID: 78420 RVA: 0x001B113C File Offset: 0x001AF33C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDelimitedTextWriter.vtkDelimitedTextWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06013255 RID: 78421
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDelimitedTextWriter_GetString_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Internal method: Returns the "string" with the "StringDelimiter" if
		/// UseStringDelimiter is true.
		/// </summary>
		// Token: 0x06013256 RID: 78422 RVA: 0x001B1158 File Offset: 0x001AF358
		public string GetString(string arg0)
		{
			return vtkDelimitedTextWriter.vtkDelimitedTextWriter_GetString_05(base.GetCppThis(), arg0);
		}

		// Token: 0x06013257 RID: 78423
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextWriter_GetStringDelimiter_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the delimiter used for string data, if any
		/// eg. double quotes(").
		/// </summary>
		// Token: 0x06013258 RID: 78424 RVA: 0x001B1178 File Offset: 0x001AF378
		public virtual string GetStringDelimiter()
		{
			string s = Marshal.PtrToStringAnsi(vtkDelimitedTextWriter.vtkDelimitedTextWriter_GetStringDelimiter_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013259 RID: 78425
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDelimitedTextWriter_GetUseStringDelimiter_07(HandleRef pThis);

		/// <summary>
		/// Get/Set if StringDelimiter must be used for string data.
		/// True by default.
		/// </summary>
		// Token: 0x0601325A RID: 78426 RVA: 0x001B11B4 File Offset: 0x001AF3B4
		public virtual bool GetUseStringDelimiter()
		{
			return vtkDelimitedTextWriter.vtkDelimitedTextWriter_GetUseStringDelimiter_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0601325B RID: 78427
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDelimitedTextWriter_GetWriteToOutputString_08(HandleRef pThis);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// </summary>
		// Token: 0x0601325C RID: 78428 RVA: 0x001B11DC File Offset: 0x001AF3DC
		public virtual bool GetWriteToOutputString()
		{
			return vtkDelimitedTextWriter.vtkDelimitedTextWriter_GetWriteToOutputString_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0601325D RID: 78429
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelimitedTextWriter_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601325E RID: 78430 RVA: 0x001B1204 File Offset: 0x001AF404
		public override int IsA(string type)
		{
			return vtkDelimitedTextWriter.vtkDelimitedTextWriter_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601325F RID: 78431
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelimitedTextWriter_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013260 RID: 78432 RVA: 0x001B1224 File Offset: 0x001AF424
		public new static int IsTypeOf(string type)
		{
			return vtkDelimitedTextWriter.vtkDelimitedTextWriter_IsTypeOf_10(type);
		}

		// Token: 0x06013261 RID: 78433
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextWriter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013262 RID: 78434 RVA: 0x001B1240 File Offset: 0x001AF440
		public new vtkDelimitedTextWriter NewInstance()
		{
			vtkDelimitedTextWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDelimitedTextWriter.vtkDelimitedTextWriter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDelimitedTextWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013263 RID: 78435
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextWriter_RegisterAndGetOutputString_13(HandleRef pThis);

		/// <summary>
		/// This convenience method returns the string, sets the IVAR to nullptr,
		/// so that the user is responsible for deleting the string.
		/// </summary>
		// Token: 0x06013264 RID: 78436 RVA: 0x001B129C File Offset: 0x001AF49C
		public string RegisterAndGetOutputString()
		{
			string s = Marshal.PtrToStringAnsi(vtkDelimitedTextWriter.vtkDelimitedTextWriter_RegisterAndGetOutputString_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013265 RID: 78437
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelimitedTextWriter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013266 RID: 78438 RVA: 0x001B12D8 File Offset: 0x001AF4D8
		public new static vtkDelimitedTextWriter SafeDownCast(vtkObjectBase o)
		{
			vtkDelimitedTextWriter vtkDelimitedTextWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDelimitedTextWriter.vtkDelimitedTextWriter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDelimitedTextWriter = (vtkDelimitedTextWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDelimitedTextWriter.Register(null);
				}
			}
			return vtkDelimitedTextWriter;
		}

		// Token: 0x06013267 RID: 78439
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextWriter_SetFieldDelimiter_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the delimiter use to separate fields ("," by default.)
		/// </summary>
		// Token: 0x06013268 RID: 78440 RVA: 0x001B1357 File Offset: 0x001AF557
		public virtual void SetFieldDelimiter(string _arg)
		{
			vtkDelimitedTextWriter.vtkDelimitedTextWriter_SetFieldDelimiter_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06013269 RID: 78441
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextWriter_SetFileName_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the filename for the file.
		/// </summary>
		// Token: 0x0601326A RID: 78442 RVA: 0x001B1367 File Offset: 0x001AF567
		public virtual void SetFileName(string _arg)
		{
			vtkDelimitedTextWriter.vtkDelimitedTextWriter_SetFileName_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0601326B RID: 78443
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextWriter_SetStringDelimiter_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the delimiter used for string data, if any
		/// eg. double quotes(").
		/// </summary>
		// Token: 0x0601326C RID: 78444 RVA: 0x001B1377 File Offset: 0x001AF577
		public virtual void SetStringDelimiter(string _arg)
		{
			vtkDelimitedTextWriter.vtkDelimitedTextWriter_SetStringDelimiter_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0601326D RID: 78445
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextWriter_SetUseStringDelimiter_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set if StringDelimiter must be used for string data.
		/// True by default.
		/// </summary>
		// Token: 0x0601326E RID: 78446 RVA: 0x001B1387 File Offset: 0x001AF587
		public virtual void SetUseStringDelimiter(bool _arg)
		{
			vtkDelimitedTextWriter.vtkDelimitedTextWriter_SetUseStringDelimiter_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601326F RID: 78447
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextWriter_SetWriteToOutputString_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// </summary>
		// Token: 0x06013270 RID: 78448 RVA: 0x001B139F File Offset: 0x001AF59F
		public virtual void SetWriteToOutputString(bool _arg)
		{
			vtkDelimitedTextWriter.vtkDelimitedTextWriter_SetWriteToOutputString_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06013271 RID: 78449
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextWriter_WriteToOutputStringOff_20(HandleRef pThis);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// </summary>
		// Token: 0x06013272 RID: 78450 RVA: 0x001B13B7 File Offset: 0x001AF5B7
		public virtual void WriteToOutputStringOff()
		{
			vtkDelimitedTextWriter.vtkDelimitedTextWriter_WriteToOutputStringOff_20(base.GetCppThis());
		}

		// Token: 0x06013273 RID: 78451
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelimitedTextWriter_WriteToOutputStringOn_21(HandleRef pThis);

		/// <summary>
		/// Enable writing to an OutputString instead of the default, a file.
		/// </summary>
		// Token: 0x06013274 RID: 78452 RVA: 0x001B13C6 File Offset: 0x001AF5C6
		public virtual void WriteToOutputStringOn()
		{
			vtkDelimitedTextWriter.vtkDelimitedTextWriter_WriteToOutputStringOn_21(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400161C RID: 5660
		public new const string MRFullTypeName = "Kitware.VTK.vtkDelimitedTextWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400161D RID: 5661
		public new static readonly string MRClassNameKey = "class vtkDelimitedTextWriter";
	}
}
