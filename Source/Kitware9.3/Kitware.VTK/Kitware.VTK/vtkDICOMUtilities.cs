using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000034 RID: 52
	public class vtkDICOMUtilities : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600088A RID: 2186 RVA: 0x000139CC File Offset: 0x00011BCC
		static vtkDICOMUtilities()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMUtilities.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMUtilities"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600088B RID: 2187 RVA: 0x000139F4 File Offset: 0x00011BF4
		public vtkDICOMUtilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600088C RID: 2188
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMUtilities_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600088D RID: 2189 RVA: 0x00013A04 File Offset: 0x00011C04
		public new static vtkDICOMUtilities New()
		{
			vtkDICOMUtilities result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMUtilities.vtkDICOMUtilities_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00013A58 File Offset: 0x00011C58
		public vtkDICOMUtilities() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMUtilities.vtkDICOMUtilities_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600088F RID: 2191 RVA: 0x00013A9C File Offset: 0x00011C9C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000890 RID: 2192
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMUtilities_CompareUIDs_01([MarshalAs(UnmanagedType.LPUTF8Str)] string u1, [MarshalAs(UnmanagedType.LPUTF8Str)] string u2);

		// Token: 0x06000891 RID: 2193 RVA: 0x00013AA8 File Offset: 0x00011CA8
		public static int CompareUIDs(string u1, string u2)
		{
			return vtkDICOMUtilities.vtkDICOMUtilities_CompareUIDs_01(u1, u2);
		}

		// Token: 0x06000892 RID: 2194
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMUtilities_ConvertDateTime_02([MarshalAs(UnmanagedType.LPUTF8Str)] string datetime);

		// Token: 0x06000893 RID: 2195 RVA: 0x00013AC4 File Offset: 0x00011CC4
		public static long ConvertDateTime(string datetime)
		{
			return vtkDICOMUtilities.vtkDICOMUtilities_ConvertDateTime_02(datetime);
		}

		// Token: 0x06000894 RID: 2196
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMUtilities_GenerateDateTime_03([MarshalAs(UnmanagedType.LPUTF8Str)] string zone);

		// Token: 0x06000895 RID: 2197 RVA: 0x00013AE0 File Offset: 0x00011CE0
		public static string GenerateDateTime(string zone)
		{
			return vtkDICOMUtilities.vtkDICOMUtilities_GenerateDateTime_03(zone);
		}

		// Token: 0x06000896 RID: 2198
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMUtilities_GenerateDateTime_04(long microsecs, [MarshalAs(UnmanagedType.LPUTF8Str)] string zone);

		// Token: 0x06000897 RID: 2199 RVA: 0x00013AFC File Offset: 0x00011CFC
		public static string GenerateDateTime(long microsecs, string zone)
		{
			return vtkDICOMUtilities.vtkDICOMUtilities_GenerateDateTime_04(microsecs, zone);
		}

		// Token: 0x06000898 RID: 2200
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMUtilities_GenerateUID_05(HandleRef tag);

		// Token: 0x06000899 RID: 2201 RVA: 0x00013B18 File Offset: 0x00011D18
		public static string GenerateUID(vtkDICOMTag tag)
		{
			return vtkDICOMUtilities.vtkDICOMUtilities_GenerateUID_05((tag == null) ? default(HandleRef) : tag.GetCppThis());
		}

		// Token: 0x0600089A RID: 2202
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMUtilities_GenerateUIDs_06(HandleRef tag, HandleRef uids);

		// Token: 0x0600089B RID: 2203 RVA: 0x00013B48 File Offset: 0x00011D48
		public static void GenerateUIDs(vtkDICOMTag tag, vtkStringArray uids)
		{
			vtkDICOMUtilities.vtkDICOMUtilities_GenerateUIDs_06((tag == null) ? default(HandleRef) : tag.GetCppThis(), (uids == null) ? default(HandleRef) : uids.GetCppThis());
		}

		// Token: 0x0600089C RID: 2204
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkDICOMUtilities_GetCIDFromUID_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string uid);

		// Token: 0x0600089D RID: 2205 RVA: 0x00013B88 File Offset: 0x00011D88
		public ushort GetCIDFromUID(string uid)
		{
			return vtkDICOMUtilities.vtkDICOMUtilities_GetCIDFromUID_07(base.GetCppThis(), uid);
		}

		// Token: 0x0600089E RID: 2206
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMUtilities_GetImplementationClassUID_08();

		// Token: 0x0600089F RID: 2207 RVA: 0x00013BA8 File Offset: 0x00011DA8
		public static string GetImplementationClassUID()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMUtilities.vtkDICOMUtilities_GetImplementationClassUID_08());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060008A0 RID: 2208
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMUtilities_GetImplementationVersionName_09();

		// Token: 0x060008A1 RID: 2209 RVA: 0x00013BDC File Offset: 0x00011DDC
		public static string GetImplementationVersionName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMUtilities.vtkDICOMUtilities_GetImplementationVersionName_09());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060008A2 RID: 2210
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMUtilities_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060008A3 RID: 2211 RVA: 0x00013C10 File Offset: 0x00011E10
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMUtilities.vtkDICOMUtilities_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x060008A4 RID: 2212
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMUtilities_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060008A5 RID: 2213 RVA: 0x00013C30 File Offset: 0x00011E30
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMUtilities.vtkDICOMUtilities_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x060008A6 RID: 2214
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMUtilities_GetUIDName_12([MarshalAs(UnmanagedType.LPUTF8Str)] string uid);

		// Token: 0x060008A7 RID: 2215 RVA: 0x00013C4C File Offset: 0x00011E4C
		public static string GetUIDName(string uid)
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMUtilities.vtkDICOMUtilities_GetUIDName_12(uid));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060008A8 RID: 2216
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMUtilities_GetUIDPrefix_13();

		// Token: 0x060008A9 RID: 2217 RVA: 0x00013C84 File Offset: 0x00011E84
		public static string GetUIDPrefix()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMUtilities.vtkDICOMUtilities_GetUIDPrefix_13());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060008AA RID: 2218
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMUtilities_GetUTC_14(IntPtr offset);

		// Token: 0x060008AB RID: 2219 RVA: 0x00013CB8 File Offset: 0x00011EB8
		public static long GetUTC(IntPtr offset)
		{
			return vtkDICOMUtilities.vtkDICOMUtilities_GetUTC_14(offset);
		}

		// Token: 0x060008AC RID: 2220
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMUtilities_GetUniversalTime_15();

		// Token: 0x060008AD RID: 2221 RVA: 0x00013CD4 File Offset: 0x00011ED4
		public static long GetUniversalTime()
		{
			return vtkDICOMUtilities.vtkDICOMUtilities_GetUniversalTime_15();
		}

		// Token: 0x060008AE RID: 2222
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMUtilities_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060008AF RID: 2223 RVA: 0x00013CF0 File Offset: 0x00011EF0
		public override int IsA(string type)
		{
			return vtkDICOMUtilities.vtkDICOMUtilities_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x060008B0 RID: 2224
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMUtilities_IsDICOMFile_17([MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		// Token: 0x060008B1 RID: 2225 RVA: 0x00013D10 File Offset: 0x00011F10
		public static bool IsDICOMFile(string filename)
		{
			return vtkDICOMUtilities.vtkDICOMUtilities_IsDICOMFile_17(filename) != 0;
		}

		// Token: 0x060008B2 RID: 2226
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMUtilities_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060008B3 RID: 2227 RVA: 0x00013D34 File Offset: 0x00011F34
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMUtilities.vtkDICOMUtilities_IsTypeOf_18(type);
		}

		// Token: 0x060008B4 RID: 2228
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMUtilities_IsValidUTF8_19([MarshalAs(UnmanagedType.LPUTF8Str)] string text, ulong l);

		// Token: 0x060008B5 RID: 2229 RVA: 0x00013D50 File Offset: 0x00011F50
		public static bool IsValidUTF8(string text, ulong l)
		{
			return vtkDICOMUtilities.vtkDICOMUtilities_IsValidUTF8_19(text, l) != 0;
		}

		// Token: 0x060008B6 RID: 2230
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMUtilities_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060008B7 RID: 2231 RVA: 0x00013D74 File Offset: 0x00011F74
		public new vtkDICOMUtilities NewInstance()
		{
			vtkDICOMUtilities result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMUtilities.vtkDICOMUtilities_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060008B8 RID: 2232
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMUtilities_PackUnsignedInt_22(uint i, IntPtr cp);

		// Token: 0x060008B9 RID: 2233 RVA: 0x00013DCE File Offset: 0x00011FCE
		public static void PackUnsignedInt(uint i, IntPtr cp)
		{
			vtkDICOMUtilities.vtkDICOMUtilities_PackUnsignedInt_22(i, cp);
		}

		// Token: 0x060008BA RID: 2234
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMUtilities_PatternMatches_23([MarshalAs(UnmanagedType.LPUTF8Str)] string pattern, [MarshalAs(UnmanagedType.LPUTF8Str)] string val);

		// Token: 0x060008BB RID: 2235 RVA: 0x00013DDC File Offset: 0x00011FDC
		public static bool PatternMatches(string pattern, string val)
		{
			return vtkDICOMUtilities.vtkDICOMUtilities_PatternMatches_23(pattern, val) != 0;
		}

		// Token: 0x060008BC RID: 2236
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMUtilities_PatternMatches_24([MarshalAs(UnmanagedType.LPUTF8Str)] string pattern, ulong pl, [MarshalAs(UnmanagedType.LPUTF8Str)] string val, ulong vl);

		// Token: 0x060008BD RID: 2237 RVA: 0x00013E00 File Offset: 0x00012000
		public static bool PatternMatches(string pattern, ulong pl, string val, ulong vl)
		{
			return vtkDICOMUtilities.vtkDICOMUtilities_PatternMatches_24(pattern, pl, val, vl) != 0;
		}

		// Token: 0x060008BE RID: 2238
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMUtilities_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060008BF RID: 2239 RVA: 0x00013E24 File Offset: 0x00012024
		public new static vtkDICOMUtilities SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMUtilities vtkDICOMUtilities = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMUtilities.vtkDICOMUtilities_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMUtilities = (vtkDICOMUtilities)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMUtilities.Register(null);
				}
			}
			return vtkDICOMUtilities;
		}

		// Token: 0x060008C0 RID: 2240
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMUtilities_SetImplementationClassUID_26([MarshalAs(UnmanagedType.LPUTF8Str)] string uid);

		// Token: 0x060008C1 RID: 2241 RVA: 0x00013EA3 File Offset: 0x000120A3
		public static void SetImplementationClassUID(string uid)
		{
			vtkDICOMUtilities.vtkDICOMUtilities_SetImplementationClassUID_26(uid);
		}

		// Token: 0x060008C2 RID: 2242
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMUtilities_SetImplementationVersionName_27([MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		// Token: 0x060008C3 RID: 2243 RVA: 0x00013EAD File Offset: 0x000120AD
		public static void SetImplementationVersionName(string name)
		{
			vtkDICOMUtilities.vtkDICOMUtilities_SetImplementationVersionName_27(name);
		}

		// Token: 0x060008C4 RID: 2244
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMUtilities_SetUIDPrefix_28([MarshalAs(UnmanagedType.LPUTF8Str)] string prefix);

		// Token: 0x060008C5 RID: 2245 RVA: 0x00013EB7 File Offset: 0x000120B7
		public static void SetUIDPrefix(string prefix)
		{
			vtkDICOMUtilities.vtkDICOMUtilities_SetUIDPrefix_28(prefix);
		}

		// Token: 0x060008C6 RID: 2246
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDICOMUtilities_UnpackUnsignedInt_29(IntPtr cp);

		// Token: 0x060008C7 RID: 2247 RVA: 0x00013EC4 File Offset: 0x000120C4
		public static uint UnpackUnsignedInt(IntPtr cp)
		{
			return vtkDICOMUtilities.vtkDICOMUtilities_UnpackUnsignedInt_29(cp);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000392 RID: 914
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMUtilities";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000393 RID: 915
		public new static readonly string MRClassNameKey = "class vtkDICOMUtilities";
	}
}
