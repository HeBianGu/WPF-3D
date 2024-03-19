using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBase64InputStream
	/// </summary>
	/// <remarks>
	///    Reads base64-encoded input from a stream.
	///
	/// vtkBase64InputStream implements base64 decoding with the
	/// vtkInputStream interface.
	/// </remarks>
	// Token: 0x02000723 RID: 1827
	public class vtkBase64InputStream : vtkInputStream
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060131C2 RID: 78274 RVA: 0x001B023F File Offset: 0x001AE43F
		static vtkBase64InputStream()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBase64InputStream.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBase64InputStream"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060131C3 RID: 78275 RVA: 0x001B0267 File Offset: 0x001AE467
		public vtkBase64InputStream(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060131C4 RID: 78276
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBase64InputStream_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131C5 RID: 78277 RVA: 0x001B0278 File Offset: 0x001AE478
		public new static vtkBase64InputStream New()
		{
			vtkBase64InputStream result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBase64InputStream.vtkBase64InputStream_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBase64InputStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131C6 RID: 78278 RVA: 0x001B02CC File Offset: 0x001AE4CC
		public vtkBase64InputStream() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBase64InputStream.vtkBase64InputStream_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060131C7 RID: 78279 RVA: 0x001B0310 File Offset: 0x001AE510
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060131C8 RID: 78280
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBase64InputStream_EndReading_01(HandleRef pThis);

		/// <summary>
		/// Called after all desired calls to Seek and Read have been made.
		/// After this call, the caller is free to change the position of the
		/// stream.  Additional reads should not be done until after another
		/// call to StartReading.
		/// </summary>
		// Token: 0x060131C9 RID: 78281 RVA: 0x001B031B File Offset: 0x001AE51B
		public override void EndReading()
		{
			vtkBase64InputStream.vtkBase64InputStream_EndReading_01(base.GetCppThis());
		}

		// Token: 0x060131CA RID: 78282
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBase64InputStream_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131CB RID: 78283 RVA: 0x001B032C File Offset: 0x001AE52C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBase64InputStream.vtkBase64InputStream_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060131CC RID: 78284
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBase64InputStream_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131CD RID: 78285 RVA: 0x001B034C File Offset: 0x001AE54C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBase64InputStream.vtkBase64InputStream_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060131CE RID: 78286
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBase64InputStream_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131CF RID: 78287 RVA: 0x001B0368 File Offset: 0x001AE568
		public override int IsA(string type)
		{
			return vtkBase64InputStream.vtkBase64InputStream_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060131D0 RID: 78288
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBase64InputStream_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131D1 RID: 78289 RVA: 0x001B0388 File Offset: 0x001AE588
		public new static int IsTypeOf(string type)
		{
			return vtkBase64InputStream.vtkBase64InputStream_IsTypeOf_05(type);
		}

		// Token: 0x060131D2 RID: 78290
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBase64InputStream_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131D3 RID: 78291 RVA: 0x001B03A4 File Offset: 0x001AE5A4
		public new vtkBase64InputStream NewInstance()
		{
			vtkBase64InputStream result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBase64InputStream.vtkBase64InputStream_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBase64InputStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060131D4 RID: 78292
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkBase64InputStream_Read_08(HandleRef pThis, IntPtr data, ulong length);

		/// <summary>
		/// Read input data of the given length.  Returns amount actually
		/// read.
		/// </summary>
		// Token: 0x060131D5 RID: 78293 RVA: 0x001B0400 File Offset: 0x001AE600
		public override ulong Read(IntPtr data, ulong length)
		{
			return vtkBase64InputStream.vtkBase64InputStream_Read_08(base.GetCppThis(), data, length);
		}

		// Token: 0x060131D6 RID: 78294
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBase64InputStream_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131D7 RID: 78295 RVA: 0x001B0424 File Offset: 0x001AE624
		public new static vtkBase64InputStream SafeDownCast(vtkObjectBase o)
		{
			vtkBase64InputStream vtkBase64InputStream = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBase64InputStream.vtkBase64InputStream_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBase64InputStream = (vtkBase64InputStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBase64InputStream.Register(null);
				}
			}
			return vtkBase64InputStream;
		}

		// Token: 0x060131D8 RID: 78296
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBase64InputStream_Seek_10(HandleRef pThis, long offset);

		/// <summary>
		/// Seek to the given offset in the input data.  Returns 1 for
		/// success, 0 for failure.
		/// </summary>
		// Token: 0x060131D9 RID: 78297 RVA: 0x001B04A4 File Offset: 0x001AE6A4
		public override int Seek(long offset)
		{
			return vtkBase64InputStream.vtkBase64InputStream_Seek_10(base.GetCppThis(), offset);
		}

		// Token: 0x060131DA RID: 78298
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBase64InputStream_StartReading_11(HandleRef pThis);

		/// <summary>
		/// Called after the stream position has been set by the caller, but
		/// before any Seek or Read calls.  The stream position should not be
		/// adjusted by the caller until after an EndReading call.
		/// </summary>
		// Token: 0x060131DB RID: 78299 RVA: 0x001B04C4 File Offset: 0x001AE6C4
		public override void StartReading()
		{
			vtkBase64InputStream.vtkBase64InputStream_StartReading_11(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001612 RID: 5650
		public new const string MRFullTypeName = "Kitware.VTK.vtkBase64InputStream";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001613 RID: 5651
		public new static readonly string MRClassNameKey = "class vtkBase64InputStream";
	}
}
