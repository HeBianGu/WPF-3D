using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBase64OutputStream
	/// </summary>
	/// <remarks>
	///    Writes base64-encoded output to a stream.
	///
	/// vtkBase64OutputStream implements base64 encoding with the
	/// vtkOutputStream interface.
	/// </remarks>
	// Token: 0x02000725 RID: 1829
	public class vtkBase64OutputStream : vtkOutputStream
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060131F4 RID: 78324 RVA: 0x001B0765 File Offset: 0x001AE965
		static vtkBase64OutputStream()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBase64OutputStream.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBase64OutputStream"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060131F5 RID: 78325 RVA: 0x001B078D File Offset: 0x001AE98D
		public vtkBase64OutputStream(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060131F6 RID: 78326
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBase64OutputStream_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131F7 RID: 78327 RVA: 0x001B079C File Offset: 0x001AE99C
		public new static vtkBase64OutputStream New()
		{
			vtkBase64OutputStream result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBase64OutputStream.vtkBase64OutputStream_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBase64OutputStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131F8 RID: 78328 RVA: 0x001B07F0 File Offset: 0x001AE9F0
		public vtkBase64OutputStream() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBase64OutputStream.vtkBase64OutputStream_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060131F9 RID: 78329 RVA: 0x001B0834 File Offset: 0x001AEA34
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060131FA RID: 78330
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBase64OutputStream_EndWriting_01(HandleRef pThis);

		/// <summary>
		/// Called after all desired calls to Write have been made.  After
		/// this call, the caller is free to change the position of the
		/// stream.  Additional writes should not be done until after another
		/// call to StartWriting.
		/// </summary>
		// Token: 0x060131FB RID: 78331 RVA: 0x001B0840 File Offset: 0x001AEA40
		public override int EndWriting()
		{
			return vtkBase64OutputStream.vtkBase64OutputStream_EndWriting_01(base.GetCppThis());
		}

		// Token: 0x060131FC RID: 78332
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBase64OutputStream_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131FD RID: 78333 RVA: 0x001B0860 File Offset: 0x001AEA60
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBase64OutputStream.vtkBase64OutputStream_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060131FE RID: 78334
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBase64OutputStream_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131FF RID: 78335 RVA: 0x001B0880 File Offset: 0x001AEA80
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBase64OutputStream.vtkBase64OutputStream_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06013200 RID: 78336
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBase64OutputStream_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013201 RID: 78337 RVA: 0x001B089C File Offset: 0x001AEA9C
		public override int IsA(string type)
		{
			return vtkBase64OutputStream.vtkBase64OutputStream_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06013202 RID: 78338
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBase64OutputStream_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013203 RID: 78339 RVA: 0x001B08BC File Offset: 0x001AEABC
		public new static int IsTypeOf(string type)
		{
			return vtkBase64OutputStream.vtkBase64OutputStream_IsTypeOf_05(type);
		}

		// Token: 0x06013204 RID: 78340
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBase64OutputStream_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013205 RID: 78341 RVA: 0x001B08D8 File Offset: 0x001AEAD8
		public new vtkBase64OutputStream NewInstance()
		{
			vtkBase64OutputStream result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBase64OutputStream.vtkBase64OutputStream_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBase64OutputStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013206 RID: 78342
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBase64OutputStream_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013207 RID: 78343 RVA: 0x001B0934 File Offset: 0x001AEB34
		public new static vtkBase64OutputStream SafeDownCast(vtkObjectBase o)
		{
			vtkBase64OutputStream vtkBase64OutputStream = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBase64OutputStream.vtkBase64OutputStream_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBase64OutputStream = (vtkBase64OutputStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBase64OutputStream.Register(null);
				}
			}
			return vtkBase64OutputStream;
		}

		// Token: 0x06013208 RID: 78344
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBase64OutputStream_StartWriting_09(HandleRef pThis);

		/// <summary>
		/// Called after the stream position has been set by the caller, but
		/// before any Write calls.  The stream position should not be
		/// adjusted by the caller until after an EndWriting call.
		/// </summary>
		// Token: 0x06013209 RID: 78345 RVA: 0x001B09B4 File Offset: 0x001AEBB4
		public override int StartWriting()
		{
			return vtkBase64OutputStream.vtkBase64OutputStream_StartWriting_09(base.GetCppThis());
		}

		// Token: 0x0601320A RID: 78346
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBase64OutputStream_Write_10(HandleRef pThis, IntPtr data, ulong length);

		/// <summary>
		/// Write output data of the given length.
		/// </summary>
		// Token: 0x0601320B RID: 78347 RVA: 0x001B09D4 File Offset: 0x001AEBD4
		public override int Write(IntPtr data, ulong length)
		{
			return vtkBase64OutputStream.vtkBase64OutputStream_Write_10(base.GetCppThis(), data, length);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001616 RID: 5654
		public new const string MRFullTypeName = "Kitware.VTK.vtkBase64OutputStream";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001617 RID: 5655
		public new static readonly string MRClassNameKey = "class vtkBase64OutputStream";
	}
}
