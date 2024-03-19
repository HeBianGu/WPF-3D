using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBase64Utilities
	/// </summary>
	/// <remarks>
	///    base64 encode and decode utilities.
	///
	/// vtkBase64Utilities implements base64 encoding and decoding.
	/// </remarks>
	// Token: 0x02000726 RID: 1830
	public class vtkBase64Utilities : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601320C RID: 78348 RVA: 0x001B09F5 File Offset: 0x001AEBF5
		static vtkBase64Utilities()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBase64Utilities.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBase64Utilities"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601320D RID: 78349 RVA: 0x001B0A1D File Offset: 0x001AEC1D
		public vtkBase64Utilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601320E RID: 78350
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBase64Utilities_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601320F RID: 78351 RVA: 0x001B0A2C File Offset: 0x001AEC2C
		public new static vtkBase64Utilities New()
		{
			vtkBase64Utilities result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBase64Utilities.vtkBase64Utilities_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBase64Utilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013210 RID: 78352 RVA: 0x001B0A80 File Offset: 0x001AEC80
		public vtkBase64Utilities() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBase64Utilities.vtkBase64Utilities_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013211 RID: 78353 RVA: 0x001B0AC4 File Offset: 0x001AECC4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013212 RID: 78354
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkBase64Utilities_DecodeSafely_01(IntPtr input, ulong inputLen, IntPtr output, ulong outputLen);

		/// <summary>
		/// Decode 4 bytes at a time from the input buffer and store the decoded
		/// stream into the output buffer. The required output buffer size must be
		/// determined and allocated by the caller. The needed output space is
		/// always less than the input buffer size, so a good first order
		/// approximation is to allocate the same size. Base64 encoding is about
		/// 4/3 overhead, so a tighter bound is possible.
		/// Return the number of bytes atually placed into the output buffer.
		/// </summary>
		// Token: 0x06013213 RID: 78355 RVA: 0x001B0AD0 File Offset: 0x001AECD0
		public static ulong DecodeSafely(IntPtr input, ulong inputLen, IntPtr output, ulong outputLen)
		{
			return vtkBase64Utilities.vtkBase64Utilities_DecodeSafely_01(input, inputLen, output, outputLen);
		}

		// Token: 0x06013214 RID: 78356
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBase64Utilities_DecodeTriplet_02(byte i0, byte i1, byte i2, byte i3, IntPtr o0, IntPtr o1, IntPtr o2);

		/// <summary>
		/// Decode 4 bytes into 3 bytes.
		/// Return the number of bytes actually decoded (0 to 3, inclusive).
		/// </summary>
		// Token: 0x06013215 RID: 78357 RVA: 0x001B0AF0 File Offset: 0x001AECF0
		public static int DecodeTriplet(byte i0, byte i1, byte i2, byte i3, IntPtr o0, IntPtr o1, IntPtr o2)
		{
			return vtkBase64Utilities.vtkBase64Utilities_DecodeTriplet_02(i0, i1, i2, i3, o0, o1, o2);
		}

		// Token: 0x06013216 RID: 78358
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkBase64Utilities_Encode_03(IntPtr input, uint length, IntPtr output, int mark_end);

		/// <summary>
		/// Encode 'length' bytes from the input buffer and store the
		/// encoded stream into the output buffer. Return the length of
		/// the encoded stream. Note that the output buffer must be allocated
		/// by the caller (length * 1.5 should be a safe estimate).
		/// If 'mark_end' is true then an extra set of 4 bytes is added
		/// to the end of the stream if the input is a multiple of 3 bytes.
		/// These bytes are invalid chars and therefore they will stop the decoder
		/// thus enabling the caller to decode a stream without actually knowing
		/// how much data to expect (if the input is not a multiple of 3 bytes then
		/// the extra padding needed to complete the encode 4 bytes will stop the
		/// decoding anyway).
		/// </summary>
		// Token: 0x06013217 RID: 78359 RVA: 0x001B0B14 File Offset: 0x001AED14
		public static uint Encode(IntPtr input, uint length, IntPtr output, int mark_end)
		{
			return vtkBase64Utilities.vtkBase64Utilities_Encode_03(input, length, output, mark_end);
		}

		// Token: 0x06013218 RID: 78360
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBase64Utilities_EncodePair_04(byte i0, byte i1, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3);

		/// <summary>
		/// Encode 2 bytes into 4 bytes
		/// </summary>
		// Token: 0x06013219 RID: 78361 RVA: 0x001B0B31 File Offset: 0x001AED31
		public static void EncodePair(byte i0, byte i1, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3)
		{
			vtkBase64Utilities.vtkBase64Utilities_EncodePair_04(i0, i1, o0, o1, o2, o3);
		}

		// Token: 0x0601321A RID: 78362
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBase64Utilities_EncodeSingle_05(byte i0, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3);

		/// <summary>
		/// Encode 1 byte into 4 bytes
		/// </summary>
		// Token: 0x0601321B RID: 78363 RVA: 0x001B0B42 File Offset: 0x001AED42
		public static void EncodeSingle(byte i0, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3)
		{
			vtkBase64Utilities.vtkBase64Utilities_EncodeSingle_05(i0, o0, o1, o2, o3);
		}

		// Token: 0x0601321C RID: 78364
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBase64Utilities_EncodeTriplet_06(byte i0, byte i1, byte i2, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3);

		/// <summary>
		/// Encode 3 bytes into 4 bytes
		/// </summary>
		// Token: 0x0601321D RID: 78365 RVA: 0x001B0B51 File Offset: 0x001AED51
		public static void EncodeTriplet(byte i0, byte i1, byte i2, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3)
		{
			vtkBase64Utilities.vtkBase64Utilities_EncodeTriplet_06(i0, i1, i2, o0, o1, o2, o3);
		}

		// Token: 0x0601321E RID: 78366
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBase64Utilities_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601321F RID: 78367 RVA: 0x001B0B64 File Offset: 0x001AED64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBase64Utilities.vtkBase64Utilities_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06013220 RID: 78368
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBase64Utilities_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013221 RID: 78369 RVA: 0x001B0B84 File Offset: 0x001AED84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBase64Utilities.vtkBase64Utilities_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06013222 RID: 78370
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBase64Utilities_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013223 RID: 78371 RVA: 0x001B0BA0 File Offset: 0x001AEDA0
		public override int IsA(string type)
		{
			return vtkBase64Utilities.vtkBase64Utilities_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06013224 RID: 78372
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBase64Utilities_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013225 RID: 78373 RVA: 0x001B0BC0 File Offset: 0x001AEDC0
		public new static int IsTypeOf(string type)
		{
			return vtkBase64Utilities.vtkBase64Utilities_IsTypeOf_10(type);
		}

		// Token: 0x06013226 RID: 78374
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBase64Utilities_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013227 RID: 78375 RVA: 0x001B0BDC File Offset: 0x001AEDDC
		public new vtkBase64Utilities NewInstance()
		{
			vtkBase64Utilities result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBase64Utilities.vtkBase64Utilities_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBase64Utilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013228 RID: 78376
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBase64Utilities_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013229 RID: 78377 RVA: 0x001B0C38 File Offset: 0x001AEE38
		public new static vtkBase64Utilities SafeDownCast(vtkObjectBase o)
		{
			vtkBase64Utilities vtkBase64Utilities = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBase64Utilities.vtkBase64Utilities_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBase64Utilities = (vtkBase64Utilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBase64Utilities.Register(null);
				}
			}
			return vtkBase64Utilities;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001618 RID: 5656
		public new const string MRFullTypeName = "Kitware.VTK.vtkBase64Utilities";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001619 RID: 5657
		public new static readonly string MRClassNameKey = "class vtkBase64Utilities";
	}
}
