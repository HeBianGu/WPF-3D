using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkByteSwap
	/// </summary>
	/// <remarks>
	///    perform machine dependent byte swapping
	///
	/// vtkByteSwap is used by other classes to perform machine dependent byte
	/// swapping. Byte swapping is often used when reading or writing binary
	/// files.
	/// </remarks>
	// Token: 0x02000B47 RID: 2887
	public class vtkByteSwap : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E2D8 RID: 123608 RVA: 0x002AB0E7 File Offset: 0x002A92E7
		static vtkByteSwap()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkByteSwap.MRClassNameKey, Type.GetType("Kitware.VTK.vtkByteSwap"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E2D9 RID: 123609 RVA: 0x002AB10F File Offset: 0x002A930F
		public vtkByteSwap(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E2DA RID: 123610
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkByteSwap_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E2DB RID: 123611 RVA: 0x002AB120 File Offset: 0x002A9320
		public new static vtkByteSwap New()
		{
			vtkByteSwap result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkByteSwap.vtkByteSwap_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkByteSwap)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E2DC RID: 123612 RVA: 0x002AB174 File Offset: 0x002A9374
		public vtkByteSwap() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkByteSwap.vtkByteSwap_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E2DD RID: 123613 RVA: 0x002AB1B8 File Offset: 0x002A93B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E2DE RID: 123614
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkByteSwap_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E2DF RID: 123615 RVA: 0x002AB1C4 File Offset: 0x002A93C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkByteSwap.vtkByteSwap_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601E2E0 RID: 123616
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkByteSwap_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E2E1 RID: 123617 RVA: 0x002AB1E4 File Offset: 0x002A93E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkByteSwap.vtkByteSwap_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601E2E2 RID: 123618
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkByteSwap_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E2E3 RID: 123619 RVA: 0x002AB200 File Offset: 0x002A9400
		public override int IsA(string type)
		{
			return vtkByteSwap.vtkByteSwap_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601E2E4 RID: 123620
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkByteSwap_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E2E5 RID: 123621 RVA: 0x002AB220 File Offset: 0x002A9420
		public new static int IsTypeOf(string type)
		{
			return vtkByteSwap.vtkByteSwap_IsTypeOf_04(type);
		}

		// Token: 0x0601E2E6 RID: 123622
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkByteSwap_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E2E7 RID: 123623 RVA: 0x002AB23C File Offset: 0x002A943C
		public new vtkByteSwap NewInstance()
		{
			vtkByteSwap result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkByteSwap.vtkByteSwap_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkByteSwap)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E2E8 RID: 123624
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkByteSwap_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E2E9 RID: 123625 RVA: 0x002AB298 File Offset: 0x002A9498
		public new static vtkByteSwap SafeDownCast(vtkObjectBase o)
		{
			vtkByteSwap vtkByteSwap = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkByteSwap.vtkByteSwap_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkByteSwap = (vtkByteSwap)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkByteSwap.Register(null);
				}
			}
			return vtkByteSwap;
		}

		// Token: 0x0601E2EA RID: 123626
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_Swap2BE_08(IntPtr p);

		/// <summary>
		/// Swap 2, 4, or 8 bytes for storage as Big Endian.
		/// </summary>
		// Token: 0x0601E2EB RID: 123627 RVA: 0x002AB317 File Offset: 0x002A9517
		public static void Swap2BE(IntPtr p)
		{
			vtkByteSwap.vtkByteSwap_Swap2BE_08(p);
		}

		// Token: 0x0601E2EC RID: 123628
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_Swap2BERange_09(IntPtr p, ulong num);

		/// <summary>
		/// Swap a block of 2-, 4-, or 8-byte segments for storage as Big Endian.
		/// </summary>
		// Token: 0x0601E2ED RID: 123629 RVA: 0x002AB321 File Offset: 0x002A9521
		public static void Swap2BERange(IntPtr p, ulong num)
		{
			vtkByteSwap.vtkByteSwap_Swap2BERange_09(p, num);
		}

		// Token: 0x0601E2EE RID: 123630
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_Swap2LE_10(IntPtr p);

		/// <summary>
		/// Swap 2, 4, or 8 bytes for storage as Little Endian.
		/// </summary>
		// Token: 0x0601E2EF RID: 123631 RVA: 0x002AB32C File Offset: 0x002A952C
		public static void Swap2LE(IntPtr p)
		{
			vtkByteSwap.vtkByteSwap_Swap2LE_10(p);
		}

		// Token: 0x0601E2F0 RID: 123632
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_Swap2LERange_11(IntPtr p, ulong num);

		/// <summary>
		/// Swap a block of 2-, 4-, or 8-byte segments for storage as Little Endian.
		/// </summary>
		// Token: 0x0601E2F1 RID: 123633 RVA: 0x002AB336 File Offset: 0x002A9536
		public static void Swap2LERange(IntPtr p, ulong num)
		{
			vtkByteSwap.vtkByteSwap_Swap2LERange_11(p, num);
		}

		// Token: 0x0601E2F2 RID: 123634
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_Swap4BE_12(IntPtr p);

		/// <summary>
		/// Swap 2, 4, or 8 bytes for storage as Big Endian.
		/// </summary>
		// Token: 0x0601E2F3 RID: 123635 RVA: 0x002AB341 File Offset: 0x002A9541
		public static void Swap4BE(IntPtr p)
		{
			vtkByteSwap.vtkByteSwap_Swap4BE_12(p);
		}

		// Token: 0x0601E2F4 RID: 123636
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_Swap4BERange_13(IntPtr p, ulong num);

		/// <summary>
		/// Swap a block of 2-, 4-, or 8-byte segments for storage as Big Endian.
		/// </summary>
		// Token: 0x0601E2F5 RID: 123637 RVA: 0x002AB34B File Offset: 0x002A954B
		public static void Swap4BERange(IntPtr p, ulong num)
		{
			vtkByteSwap.vtkByteSwap_Swap4BERange_13(p, num);
		}

		// Token: 0x0601E2F6 RID: 123638
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_Swap4LE_14(IntPtr p);

		/// <summary>
		/// Swap 2, 4, or 8 bytes for storage as Little Endian.
		/// </summary>
		// Token: 0x0601E2F7 RID: 123639 RVA: 0x002AB356 File Offset: 0x002A9556
		public static void Swap4LE(IntPtr p)
		{
			vtkByteSwap.vtkByteSwap_Swap4LE_14(p);
		}

		// Token: 0x0601E2F8 RID: 123640
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_Swap4LERange_15(IntPtr p, ulong num);

		/// <summary>
		/// Swap a block of 2-, 4-, or 8-byte segments for storage as Little Endian.
		/// </summary>
		// Token: 0x0601E2F9 RID: 123641 RVA: 0x002AB360 File Offset: 0x002A9560
		public static void Swap4LERange(IntPtr p, ulong num)
		{
			vtkByteSwap.vtkByteSwap_Swap4LERange_15(p, num);
		}

		// Token: 0x0601E2FA RID: 123642
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_Swap8BE_16(IntPtr p);

		/// <summary>
		/// Swap 2, 4, or 8 bytes for storage as Big Endian.
		/// </summary>
		// Token: 0x0601E2FB RID: 123643 RVA: 0x002AB36B File Offset: 0x002A956B
		public static void Swap8BE(IntPtr p)
		{
			vtkByteSwap.vtkByteSwap_Swap8BE_16(p);
		}

		// Token: 0x0601E2FC RID: 123644
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_Swap8BERange_17(IntPtr p, ulong num);

		/// <summary>
		/// Swap a block of 2-, 4-, or 8-byte segments for storage as Big Endian.
		/// </summary>
		// Token: 0x0601E2FD RID: 123645 RVA: 0x002AB375 File Offset: 0x002A9575
		public static void Swap8BERange(IntPtr p, ulong num)
		{
			vtkByteSwap.vtkByteSwap_Swap8BERange_17(p, num);
		}

		// Token: 0x0601E2FE RID: 123646
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_Swap8LE_18(IntPtr p);

		/// <summary>
		/// Swap 2, 4, or 8 bytes for storage as Little Endian.
		/// </summary>
		// Token: 0x0601E2FF RID: 123647 RVA: 0x002AB380 File Offset: 0x002A9580
		public static void Swap8LE(IntPtr p)
		{
			vtkByteSwap.vtkByteSwap_Swap8LE_18(p);
		}

		// Token: 0x0601E300 RID: 123648
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_Swap8LERange_19(IntPtr p, ulong num);

		/// <summary>
		/// Swap a block of 2-, 4-, or 8-byte segments for storage as Little Endian.
		/// </summary>
		// Token: 0x0601E301 RID: 123649 RVA: 0x002AB38A File Offset: 0x002A958A
		public static void Swap8LERange(IntPtr p, ulong num)
		{
			vtkByteSwap.vtkByteSwap_Swap8LERange_19(p, num);
		}

		// Token: 0x0601E302 RID: 123650
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_SwapBE_20(IntPtr p);

		/// <summary>
		/// Type-safe swap signatures to swap for storage in either Little
		/// Endian or Big Endian format.  Swapping is performed according to
		/// the true size of the type given.
		/// </summary>
		// Token: 0x0601E303 RID: 123651 RVA: 0x002AB395 File Offset: 0x002A9595
		public static void SwapBE(IntPtr p)
		{
			vtkByteSwap.vtkByteSwap_SwapBE_20(p);
		}

		// Token: 0x0601E304 RID: 123652
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_SwapBE_21([MarshalAs(UnmanagedType.LPUTF8Str)] string p);

		/// <summary>
		/// Type-safe swap signatures to swap for storage in either Little
		/// Endian or Big Endian format.  Swapping is performed according to
		/// the true size of the type given.
		/// </summary>
		// Token: 0x0601E305 RID: 123653 RVA: 0x002AB39F File Offset: 0x002A959F
		public static void SwapBE(string p)
		{
			vtkByteSwap.vtkByteSwap_SwapBE_21(p);
		}

		// Token: 0x0601E306 RID: 123654
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_SwapBERange_22(IntPtr p, ulong num);

		/// <summary>
		/// Type-safe swap signatures to swap for storage in either Little
		/// Endian or Big Endian format.  Swapping is performed according to
		/// the true size of the type given.
		/// </summary>
		// Token: 0x0601E307 RID: 123655 RVA: 0x002AB3A9 File Offset: 0x002A95A9
		public static void SwapBERange(IntPtr p, ulong num)
		{
			vtkByteSwap.vtkByteSwap_SwapBERange_22(p, num);
		}

		// Token: 0x0601E308 RID: 123656
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_SwapBERange_23([MarshalAs(UnmanagedType.LPUTF8Str)] string p, ulong num);

		/// <summary>
		/// Type-safe swap signatures to swap for storage in either Little
		/// Endian or Big Endian format.  Swapping is performed according to
		/// the true size of the type given.
		/// </summary>
		// Token: 0x0601E309 RID: 123657 RVA: 0x002AB3B4 File Offset: 0x002A95B4
		public static void SwapBERange(string p, ulong num)
		{
			vtkByteSwap.vtkByteSwap_SwapBERange_23(p, num);
		}

		// Token: 0x0601E30A RID: 123658
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_SwapLE_24(IntPtr p);

		/// <summary>
		/// Type-safe swap signatures to swap for storage in either Little
		/// Endian or Big Endian format.  Swapping is performed according to
		/// the true size of the type given.
		/// </summary>
		// Token: 0x0601E30B RID: 123659 RVA: 0x002AB3BF File Offset: 0x002A95BF
		public static void SwapLE(IntPtr p)
		{
			vtkByteSwap.vtkByteSwap_SwapLE_24(p);
		}

		// Token: 0x0601E30C RID: 123660
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_SwapLE_25([MarshalAs(UnmanagedType.LPUTF8Str)] string p);

		/// <summary>
		/// Type-safe swap signatures to swap for storage in either Little
		/// Endian or Big Endian format.  Swapping is performed according to
		/// the true size of the type given.
		/// </summary>
		// Token: 0x0601E30D RID: 123661 RVA: 0x002AB3C9 File Offset: 0x002A95C9
		public static void SwapLE(string p)
		{
			vtkByteSwap.vtkByteSwap_SwapLE_25(p);
		}

		// Token: 0x0601E30E RID: 123662
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_SwapLERange_26(IntPtr p, ulong num);

		/// <summary>
		/// Type-safe swap signatures to swap for storage in either Little
		/// Endian or Big Endian format.  Swapping is performed according to
		/// the true size of the type given.
		/// </summary>
		// Token: 0x0601E30F RID: 123663 RVA: 0x002AB3D3 File Offset: 0x002A95D3
		public static void SwapLERange(IntPtr p, ulong num)
		{
			vtkByteSwap.vtkByteSwap_SwapLERange_26(p, num);
		}

		// Token: 0x0601E310 RID: 123664
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_SwapLERange_27([MarshalAs(UnmanagedType.LPUTF8Str)] string p, ulong num);

		/// <summary>
		/// Type-safe swap signatures to swap for storage in either Little
		/// Endian or Big Endian format.  Swapping is performed according to
		/// the true size of the type given.
		/// </summary>
		// Token: 0x0601E311 RID: 123665 RVA: 0x002AB3DE File Offset: 0x002A95DE
		public static void SwapLERange(string p, ulong num)
		{
			vtkByteSwap.vtkByteSwap_SwapLERange_27(p, num);
		}

		// Token: 0x0601E312 RID: 123666
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkByteSwap_SwapVoidRange_28(IntPtr buffer, ulong numWords, ulong wordSize);

		/// <summary>
		/// Swaps the bytes of a buffer.  Uses an arbitrary word size, but
		/// assumes the word size is divisible by two.
		/// </summary>
		// Token: 0x0601E313 RID: 123667 RVA: 0x002AB3E9 File Offset: 0x002A95E9
		public static void SwapVoidRange(IntPtr buffer, ulong numWords, ulong wordSize)
		{
			vtkByteSwap.vtkByteSwap_SwapVoidRange_28(buffer, numWords, wordSize);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FE1 RID: 8161
		public new const string MRFullTypeName = "Kitware.VTK.vtkByteSwap";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FE2 RID: 8162
		public new static readonly string MRClassNameKey = "class vtkByteSwap";
	}
}
