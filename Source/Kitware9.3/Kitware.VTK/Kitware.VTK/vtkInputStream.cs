using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInputStream
	/// </summary>
	/// <remarks>
	///    Wraps a binary input stream with a VTK interface.
	///
	/// vtkInputStream provides a VTK-style interface wrapping around a
	/// standard input stream.  The access methods are virtual so that
	/// subclasses can transparently provide decoding of an encoded stream.
	/// Data lengths for Seek and Read calls refer to the length of the
	/// input data.  The actual length in the stream may differ for
	/// subclasses that implement an encoding scheme.
	/// </remarks>
	// Token: 0x02000722 RID: 1826
	public class vtkInputStream : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060131A8 RID: 78248 RVA: 0x001AFFAB File Offset: 0x001AE1AB
		static vtkInputStream()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInputStream.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInputStream"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060131A9 RID: 78249 RVA: 0x001AFFD3 File Offset: 0x001AE1D3
		public vtkInputStream(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060131AA RID: 78250
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInputStream_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131AB RID: 78251 RVA: 0x001AFFE4 File Offset: 0x001AE1E4
		public new static vtkInputStream New()
		{
			vtkInputStream result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInputStream.vtkInputStream_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInputStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131AC RID: 78252 RVA: 0x001B0038 File Offset: 0x001AE238
		public vtkInputStream() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInputStream.vtkInputStream_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060131AD RID: 78253 RVA: 0x001B007C File Offset: 0x001AE27C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060131AE RID: 78254
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInputStream_EndReading_01(HandleRef pThis);

		/// <summary>
		/// Called after all desired calls to Seek and Read have been made.
		/// After this call, the caller is free to change the position of the
		/// stream.  Additional reads should not be done until after another
		/// call to StartReading.
		/// </summary>
		// Token: 0x060131AF RID: 78255 RVA: 0x001B0087 File Offset: 0x001AE287
		public virtual void EndReading()
		{
			vtkInputStream.vtkInputStream_EndReading_01(base.GetCppThis());
		}

		// Token: 0x060131B0 RID: 78256
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInputStream_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131B1 RID: 78257 RVA: 0x001B0098 File Offset: 0x001AE298
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInputStream.vtkInputStream_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060131B2 RID: 78258
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInputStream_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131B3 RID: 78259 RVA: 0x001B00B8 File Offset: 0x001AE2B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInputStream.vtkInputStream_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060131B4 RID: 78260
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInputStream_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131B5 RID: 78261 RVA: 0x001B00D4 File Offset: 0x001AE2D4
		public override int IsA(string type)
		{
			return vtkInputStream.vtkInputStream_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060131B6 RID: 78262
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInputStream_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131B7 RID: 78263 RVA: 0x001B00F4 File Offset: 0x001AE2F4
		public new static int IsTypeOf(string type)
		{
			return vtkInputStream.vtkInputStream_IsTypeOf_05(type);
		}

		// Token: 0x060131B8 RID: 78264
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInputStream_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131B9 RID: 78265 RVA: 0x001B0110 File Offset: 0x001AE310
		public new vtkInputStream NewInstance()
		{
			vtkInputStream result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInputStream.vtkInputStream_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInputStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060131BA RID: 78266
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkInputStream_Read_08(HandleRef pThis, IntPtr data, ulong length);

		/// <summary>
		/// Read input data of the given length.  Returns amount actually
		/// read.
		/// </summary>
		// Token: 0x060131BB RID: 78267 RVA: 0x001B016C File Offset: 0x001AE36C
		public virtual ulong Read(IntPtr data, ulong length)
		{
			return vtkInputStream.vtkInputStream_Read_08(base.GetCppThis(), data, length);
		}

		// Token: 0x060131BC RID: 78268
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInputStream_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131BD RID: 78269 RVA: 0x001B0190 File Offset: 0x001AE390
		public new static vtkInputStream SafeDownCast(vtkObjectBase o)
		{
			vtkInputStream vtkInputStream = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInputStream.vtkInputStream_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInputStream = (vtkInputStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInputStream.Register(null);
				}
			}
			return vtkInputStream;
		}

		// Token: 0x060131BE RID: 78270
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInputStream_Seek_10(HandleRef pThis, long offset);

		/// <summary>
		/// Seek to the given offset in the input data.  Returns 1 for
		/// success, 0 for failure.
		/// </summary>
		// Token: 0x060131BF RID: 78271 RVA: 0x001B0210 File Offset: 0x001AE410
		public virtual int Seek(long offset)
		{
			return vtkInputStream.vtkInputStream_Seek_10(base.GetCppThis(), offset);
		}

		// Token: 0x060131C0 RID: 78272
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInputStream_StartReading_11(HandleRef pThis);

		/// <summary>
		/// Called after the stream position has been set by the caller, but
		/// before any Seek or Read calls.  The stream position should not be
		/// adjusted by the caller until after an EndReading call.
		/// </summary>
		// Token: 0x060131C1 RID: 78273 RVA: 0x001B0230 File Offset: 0x001AE430
		public virtual void StartReading()
		{
			vtkInputStream.vtkInputStream_StartReading_11(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001610 RID: 5648
		public new const string MRFullTypeName = "Kitware.VTK.vtkInputStream";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001611 RID: 5649
		public new static readonly string MRClassNameKey = "class vtkInputStream";
	}
}
