using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000019 RID: 25
	public class vtkDICOMCharacterSet : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600035C RID: 860 RVA: 0x0000BF82 File Offset: 0x0000A182
		static vtkDICOMCharacterSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMCharacterSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMCharacterSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600035D RID: 861 RVA: 0x0000BFAA File Offset: 0x0000A1AA
		public vtkDICOMCharacterSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600035E RID: 862 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600035F RID: 863
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMCharacterSet_CaseFoldedUTF8_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string text, ulong l);

		// Token: 0x06000360 RID: 864 RVA: 0x0000BFC4 File Offset: 0x0000A1C4
		public string CaseFoldedUTF8(string text, ulong l)
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_CaseFoldedUTF8_01(base.GetCppThis(), text, l);
		}

		// Token: 0x06000361 RID: 865
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMCharacterSet_CaseFoldedUTF8_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string text);

		// Token: 0x06000362 RID: 866 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		public string CaseFoldedUTF8(string text)
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_CaseFoldedUTF8_02(base.GetCppThis(), text);
		}

		// Token: 0x06000363 RID: 867
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMCharacterSet_ConvertToUTF8_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string text, ulong l);

		// Token: 0x06000364 RID: 868 RVA: 0x0000C008 File Offset: 0x0000A208
		public string ConvertToUTF8(string text, ulong l)
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_ConvertToUTF8_03(base.GetCppThis(), text, l);
		}

		// Token: 0x06000365 RID: 869
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDICOMCharacterSet_CountBackslashes_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string text, ulong l);

		// Token: 0x06000366 RID: 870 RVA: 0x0000C02C File Offset: 0x0000A22C
		public uint CountBackslashes(string text, ulong l)
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_CountBackslashes_04(base.GetCppThis(), text, l);
		}

		// Token: 0x06000367 RID: 871
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMCharacterSet_FromUTF8_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string text, ulong l, IntPtr lp);

		// Token: 0x06000368 RID: 872 RVA: 0x0000C050 File Offset: 0x0000A250
		public string FromUTF8(string text, ulong l, IntPtr lp)
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_FromUTF8_05(base.GetCppThis(), text, l, lp);
		}

		// Token: 0x06000369 RID: 873
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMCharacterSet_FromUTF8_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string text);

		// Token: 0x0600036A RID: 874 RVA: 0x0000C074 File Offset: 0x0000A274
		public string FromUTF8(string text)
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_FromUTF8_06(base.GetCppThis(), text);
		}

		// Token: 0x0600036B RID: 875
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMCharacterSet_GetCharacterSetString_07(HandleRef pThis);

		// Token: 0x0600036C RID: 876 RVA: 0x0000C094 File Offset: 0x0000A294
		public string GetCharacterSetString()
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_GetCharacterSetString_07(base.GetCppThis());
		}

		// Token: 0x0600036D RID: 877
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDICOMCharacterSet vtkDICOMCharacterSet_GetGlobalDefault_08();

		// Token: 0x0600036E RID: 878 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
		public static vtkDICOMCharacterSet GetGlobalDefault()
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_GetGlobalDefault_08();
		}

		// Token: 0x0600036F RID: 879
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMCharacterSet_GetGlobalOverride_09();

		// Token: 0x06000370 RID: 880 RVA: 0x0000C0D0 File Offset: 0x0000A2D0
		public static bool GetGlobalOverride()
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_GetGlobalOverride_09() != 0;
		}

		// Token: 0x06000371 RID: 881
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMCharacterSet_GetKey_10(HandleRef pThis);

		// Token: 0x06000372 RID: 882 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		public byte GetKey()
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_GetKey_10(base.GetCppThis());
		}

		// Token: 0x06000373 RID: 883
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCharacterSet_GlobalOverrideOff_11();

		// Token: 0x06000374 RID: 884 RVA: 0x0000C10F File Offset: 0x0000A30F
		public static void GlobalOverrideOff()
		{
			vtkDICOMCharacterSet.vtkDICOMCharacterSet_GlobalOverrideOff_11();
		}

		// Token: 0x06000375 RID: 885
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCharacterSet_GlobalOverrideOn_12();

		// Token: 0x06000376 RID: 886 RVA: 0x0000C118 File Offset: 0x0000A318
		public static void GlobalOverrideOn()
		{
			vtkDICOMCharacterSet.vtkDICOMCharacterSet_GlobalOverrideOn_12();
		}

		// Token: 0x06000377 RID: 887
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMCharacterSet_IsBiDirectional_13(HandleRef pThis);

		// Token: 0x06000378 RID: 888 RVA: 0x0000C124 File Offset: 0x0000A324
		public bool IsBiDirectional()
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_IsBiDirectional_13(base.GetCppThis()) != 0;
		}

		// Token: 0x06000379 RID: 889
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMCharacterSet_IsISO2022_14(HandleRef pThis);

		// Token: 0x0600037A RID: 890 RVA: 0x0000C14C File Offset: 0x0000A34C
		public bool IsISO2022()
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_IsISO2022_14(base.GetCppThis()) != 0;
		}

		// Token: 0x0600037B RID: 891
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMCharacterSet_IsISO8859_15(HandleRef pThis);

		// Token: 0x0600037C RID: 892 RVA: 0x0000C174 File Offset: 0x0000A374
		public bool IsISO8859()
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_IsISO8859_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0600037D RID: 893
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDICOMCharacterSet_NextBackslash_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string text, [MarshalAs(UnmanagedType.LPUTF8Str)] string end);

		// Token: 0x0600037E RID: 894 RVA: 0x0000C19C File Offset: 0x0000A39C
		public ulong NextBackslash(string text, string end)
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_NextBackslash_16(base.GetCppThis(), text, end);
		}

		// Token: 0x0600037F RID: 895
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCharacterSet_SetGlobalDefault_17(vtkDICOMCharacterSet cs);

		// Token: 0x06000380 RID: 896 RVA: 0x0000C1BD File Offset: 0x0000A3BD
		public static void SetGlobalDefault(vtkDICOMCharacterSet cs)
		{
			vtkDICOMCharacterSet.vtkDICOMCharacterSet_SetGlobalDefault_17(cs);
		}

		// Token: 0x06000381 RID: 897
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCharacterSet_SetGlobalOverride_18(byte b);

		// Token: 0x06000382 RID: 898 RVA: 0x0000C1C7 File Offset: 0x0000A3C7
		public static void SetGlobalOverride(bool b)
		{
			vtkDICOMCharacterSet.vtkDICOMCharacterSet_SetGlobalOverride_18(b ? (byte)1 : (byte)0);
		}

		// Token: 0x06000383 RID: 899
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMCharacterSet_ToSafeUTF8_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string text, ulong l);

		// Token: 0x06000384 RID: 900 RVA: 0x0000C1DC File Offset: 0x0000A3DC
		public string ToSafeUTF8(string text, ulong l)
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_ToSafeUTF8_19(base.GetCppThis(), text, l);
		}

		// Token: 0x06000385 RID: 901
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMCharacterSet_ToSafeUTF8_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string text);

		// Token: 0x06000386 RID: 902 RVA: 0x0000C200 File Offset: 0x0000A400
		public string ToSafeUTF8(string text)
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_ToSafeUTF8_20(base.GetCppThis(), text);
		}

		// Token: 0x06000387 RID: 903
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMCharacterSet_ToUTF8_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string text, ulong l, IntPtr lp);

		// Token: 0x06000388 RID: 904 RVA: 0x0000C220 File Offset: 0x0000A420
		public string ToUTF8(string text, ulong l, IntPtr lp)
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_ToUTF8_21(base.GetCppThis(), text, l, lp);
		}

		// Token: 0x06000389 RID: 905
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMCharacterSet_ToUTF8_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string text);

		// Token: 0x0600038A RID: 906 RVA: 0x0000C244 File Offset: 0x0000A444
		public string ToUTF8(string text)
		{
			return vtkDICOMCharacterSet.vtkDICOMCharacterSet_ToUTF8_22(base.GetCppThis(), text);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000306 RID: 774
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMCharacterSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000307 RID: 775
		public new static readonly string MRClassNameKey = "class vtkDICOMCharacterSet";

		// Token: 0x0200001A RID: 26
		public enum EnumType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000309 RID: 777
			GB18030 = 65,
			/// <summary>enum member</summary>
			// Token: 0x0400030A RID: 778
			GBK,
			/// <summary>enum member</summary>
			// Token: 0x0400030B RID: 779
			ISO_2022_IR_100 = 40,
			/// <summary>enum member</summary>
			// Token: 0x0400030C RID: 780
			ISO_2022_IR_101,
			/// <summary>enum member</summary>
			// Token: 0x0400030D RID: 781
			ISO_2022_IR_109,
			/// <summary>enum member</summary>
			// Token: 0x0400030E RID: 782
			ISO_2022_IR_110,
			/// <summary>enum member</summary>
			// Token: 0x0400030F RID: 783
			ISO_2022_IR_126 = 46,
			/// <summary>enum member</summary>
			// Token: 0x04000310 RID: 784
			ISO_2022_IR_127 = 45,
			/// <summary>enum member</summary>
			// Token: 0x04000311 RID: 785
			ISO_2022_IR_13 = 33,
			/// <summary>enum member</summary>
			// Token: 0x04000312 RID: 786
			ISO_2022_IR_138 = 47,
			/// <summary>enum member</summary>
			// Token: 0x04000313 RID: 787
			ISO_2022_IR_144 = 44,
			/// <summary>enum member</summary>
			// Token: 0x04000314 RID: 788
			ISO_2022_IR_148 = 48,
			/// <summary>enum member</summary>
			// Token: 0x04000315 RID: 789
			ISO_2022_IR_149 = 56,
			/// <summary>enum member</summary>
			// Token: 0x04000316 RID: 790
			ISO_2022_IR_159 = 36,
			/// <summary>enum member</summary>
			// Token: 0x04000317 RID: 791
			ISO_2022_IR_166 = 50,
			/// <summary>enum member</summary>
			// Token: 0x04000318 RID: 792
			ISO_2022_IR_203 = 53,
			/// <summary>enum member</summary>
			// Token: 0x04000319 RID: 793
			ISO_2022_IR_58 = 57,
			/// <summary>enum member</summary>
			// Token: 0x0400031A RID: 794
			ISO_2022_IR_6 = 32,
			/// <summary>enum member</summary>
			// Token: 0x0400031B RID: 795
			ISO_2022_IR_87 = 34,
			/// <summary>enum member</summary>
			// Token: 0x0400031C RID: 796
			ISO_IR_100 = 8,
			/// <summary>enum member</summary>
			// Token: 0x0400031D RID: 797
			ISO_IR_101,
			/// <summary>enum member</summary>
			// Token: 0x0400031E RID: 798
			ISO_IR_109,
			/// <summary>enum member</summary>
			// Token: 0x0400031F RID: 799
			ISO_IR_110,
			/// <summary>enum member</summary>
			// Token: 0x04000320 RID: 800
			ISO_IR_126 = 14,
			/// <summary>enum member</summary>
			// Token: 0x04000321 RID: 801
			ISO_IR_127 = 13,
			/// <summary>enum member</summary>
			// Token: 0x04000322 RID: 802
			ISO_IR_13 = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000323 RID: 803
			ISO_IR_138 = 15,
			/// <summary>enum member</summary>
			// Token: 0x04000324 RID: 804
			ISO_IR_144 = 12,
			/// <summary>enum member</summary>
			// Token: 0x04000325 RID: 805
			ISO_IR_148 = 16,
			/// <summary>enum member</summary>
			// Token: 0x04000326 RID: 806
			ISO_IR_166 = 18,
			/// <summary>enum member</summary>
			// Token: 0x04000327 RID: 807
			ISO_IR_192 = 64,
			/// <summary>enum member</summary>
			// Token: 0x04000328 RID: 808
			ISO_IR_203 = 21,
			/// <summary>enum member</summary>
			// Token: 0x04000329 RID: 809
			ISO_IR_6 = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400032A RID: 810
			Unknown = 255,
			/// <summary>enum member</summary>
			// Token: 0x0400032B RID: 811
			X_BIG5 = 67,
			/// <summary>enum member</summary>
			// Token: 0x0400032C RID: 812
			X_CP1250 = 80,
			/// <summary>enum member</summary>
			// Token: 0x0400032D RID: 813
			X_CP1251,
			/// <summary>enum member</summary>
			// Token: 0x0400032E RID: 814
			X_CP1252,
			/// <summary>enum member</summary>
			// Token: 0x0400032F RID: 815
			X_CP1253,
			/// <summary>enum member</summary>
			// Token: 0x04000330 RID: 816
			X_CP1254,
			/// <summary>enum member</summary>
			// Token: 0x04000331 RID: 817
			X_CP1255,
			/// <summary>enum member</summary>
			// Token: 0x04000332 RID: 818
			X_CP1256,
			/// <summary>enum member</summary>
			// Token: 0x04000333 RID: 819
			X_CP1257,
			/// <summary>enum member</summary>
			// Token: 0x04000334 RID: 820
			X_CP1258,
			/// <summary>enum member</summary>
			// Token: 0x04000335 RID: 821
			X_CP874 = 76,
			/// <summary>enum member</summary>
			// Token: 0x04000336 RID: 822
			X_EUCJP = 69,
			/// <summary>enum member</summary>
			// Token: 0x04000337 RID: 823
			X_EUCKR = 24,
			/// <summary>enum member</summary>
			// Token: 0x04000338 RID: 824
			X_GB2312,
			/// <summary>enum member</summary>
			// Token: 0x04000339 RID: 825
			X_KOI8 = 90,
			/// <summary>enum member</summary>
			// Token: 0x0400033A RID: 826
			X_LATIN10 = 22,
			/// <summary>enum member</summary>
			// Token: 0x0400033B RID: 827
			X_LATIN6 = 17,
			/// <summary>enum member</summary>
			// Token: 0x0400033C RID: 828
			X_LATIN7 = 19,
			/// <summary>enum member</summary>
			// Token: 0x0400033D RID: 829
			X_LATIN8,
			/// <summary>enum member</summary>
			// Token: 0x0400033E RID: 830
			X_LATIN9,
			/// <summary>enum member</summary>
			// Token: 0x0400033F RID: 831
			X_SJIS = 70
		}
	}
}
