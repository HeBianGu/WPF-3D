using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000035 RID: 53
	public class vtkDICOMValue : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060008C8 RID: 2248 RVA: 0x00013EDE File Offset: 0x000120DE
		static vtkDICOMValue()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMValue.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMValue"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060008C9 RID: 2249 RVA: 0x00013F06 File Offset: 0x00012106
		public vtkDICOMValue(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060008CA RID: 2250 RVA: 0x00013F14 File Offset: 0x00012114
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060008CB RID: 2251
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_AllocateCharData_01(HandleRef pThis, vtkDICOMVR vr, ulong vn);

		// Token: 0x060008CC RID: 2252 RVA: 0x00013F20 File Offset: 0x00012120
		public string AllocateCharData(vtkDICOMVR vr, ulong vn)
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMValue.vtkDICOMValue_AllocateCharData_01(base.GetCppThis(), vr, vn));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060008CD RID: 2253
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_AllocateCharData_02(HandleRef pThis, vtkDICOMVR vr, vtkDICOMCharacterSet cs, ulong vn);

		// Token: 0x060008CE RID: 2254 RVA: 0x00013F5C File Offset: 0x0001215C
		public string AllocateCharData(vtkDICOMVR vr, vtkDICOMCharacterSet cs, ulong vn)
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMValue.vtkDICOMValue_AllocateCharData_02(base.GetCppThis(), vr, cs, vn));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060008CF RID: 2255
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_AllocateDoubleData_03(HandleRef pThis, vtkDICOMVR vr, ulong vn);

		// Token: 0x060008D0 RID: 2256 RVA: 0x00013F9C File Offset: 0x0001219C
		public IntPtr AllocateDoubleData(vtkDICOMVR vr, ulong vn)
		{
			return vtkDICOMValue.vtkDICOMValue_AllocateDoubleData_03(base.GetCppThis(), vr, vn);
		}

		// Token: 0x060008D1 RID: 2257
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_AllocateFloatData_04(HandleRef pThis, vtkDICOMVR vr, ulong vn);

		// Token: 0x060008D2 RID: 2258 RVA: 0x00013FC0 File Offset: 0x000121C0
		public IntPtr AllocateFloatData(vtkDICOMVR vr, ulong vn)
		{
			return vtkDICOMValue.vtkDICOMValue_AllocateFloatData_04(base.GetCppThis(), vr, vn);
		}

		// Token: 0x060008D3 RID: 2259
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_AllocateInt64Data_05(HandleRef pThis, vtkDICOMVR vr, ulong vn);

		// Token: 0x060008D4 RID: 2260 RVA: 0x00013FE4 File Offset: 0x000121E4
		public IntPtr AllocateInt64Data(vtkDICOMVR vr, ulong vn)
		{
			return vtkDICOMValue.vtkDICOMValue_AllocateInt64Data_05(base.GetCppThis(), vr, vn);
		}

		// Token: 0x060008D5 RID: 2261
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_AllocateIntData_06(HandleRef pThis, vtkDICOMVR vr, ulong vn);

		// Token: 0x060008D6 RID: 2262 RVA: 0x00014008 File Offset: 0x00012208
		public IntPtr AllocateIntData(vtkDICOMVR vr, ulong vn)
		{
			return vtkDICOMValue.vtkDICOMValue_AllocateIntData_06(base.GetCppThis(), vr, vn);
		}

		// Token: 0x060008D7 RID: 2263
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_AllocateMultiplexData_07(HandleRef pThis, vtkDICOMVR vr, ulong vn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060008D8 RID: 2264 RVA: 0x0001402C File Offset: 0x0001222C
		public vtkDICOMValue AllocateMultiplexData(vtkDICOMVR vr, ulong vn)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMValue.vtkDICOMValue_AllocateMultiplexData_07(base.GetCppThis(), vr, vn, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		// Token: 0x060008D9 RID: 2265
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_AllocateSequenceData_08(HandleRef pThis, vtkDICOMVR vr, ulong vn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060008DA RID: 2266 RVA: 0x00014088 File Offset: 0x00012288
		public vtkDICOMItem AllocateSequenceData(vtkDICOMVR vr, ulong vn)
		{
			vtkDICOMItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMValue.vtkDICOMValue_AllocateSequenceData_08(base.GetCppThis(), vr, vn, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		// Token: 0x060008DB RID: 2267
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_AllocateShortData_09(HandleRef pThis, vtkDICOMVR vr, ulong vn);

		// Token: 0x060008DC RID: 2268 RVA: 0x000140E4 File Offset: 0x000122E4
		public IntPtr AllocateShortData(vtkDICOMVR vr, ulong vn)
		{
			return vtkDICOMValue.vtkDICOMValue_AllocateShortData_09(base.GetCppThis(), vr, vn);
		}

		// Token: 0x060008DD RID: 2269
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_AllocateTagData_10(HandleRef pThis, vtkDICOMVR vr, ulong vn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060008DE RID: 2270 RVA: 0x00014108 File Offset: 0x00012308
		public vtkDICOMTag AllocateTagData(vtkDICOMVR vr, ulong vn)
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMValue.vtkDICOMValue_AllocateTagData_10(base.GetCppThis(), vr, vn, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		// Token: 0x060008DF RID: 2271
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_AllocateUnsignedCharData_11(HandleRef pThis, vtkDICOMVR vr, ulong vn);

		// Token: 0x060008E0 RID: 2272 RVA: 0x00014164 File Offset: 0x00012364
		public IntPtr AllocateUnsignedCharData(vtkDICOMVR vr, ulong vn)
		{
			return vtkDICOMValue.vtkDICOMValue_AllocateUnsignedCharData_11(base.GetCppThis(), vr, vn);
		}

		// Token: 0x060008E1 RID: 2273
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_AllocateUnsignedInt64Data_12(HandleRef pThis, vtkDICOMVR vr, ulong vn);

		// Token: 0x060008E2 RID: 2274 RVA: 0x00014188 File Offset: 0x00012388
		public IntPtr AllocateUnsignedInt64Data(vtkDICOMVR vr, ulong vn)
		{
			return vtkDICOMValue.vtkDICOMValue_AllocateUnsignedInt64Data_12(base.GetCppThis(), vr, vn);
		}

		// Token: 0x060008E3 RID: 2275
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_AllocateUnsignedIntData_13(HandleRef pThis, vtkDICOMVR vr, ulong vn);

		// Token: 0x060008E4 RID: 2276 RVA: 0x000141AC File Offset: 0x000123AC
		public IntPtr AllocateUnsignedIntData(vtkDICOMVR vr, ulong vn)
		{
			return vtkDICOMValue.vtkDICOMValue_AllocateUnsignedIntData_13(base.GetCppThis(), vr, vn);
		}

		// Token: 0x060008E5 RID: 2277
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_AllocateUnsignedShortData_14(HandleRef pThis, vtkDICOMVR vr, ulong vn);

		// Token: 0x060008E6 RID: 2278 RVA: 0x000141D0 File Offset: 0x000123D0
		public IntPtr AllocateUnsignedShortData(vtkDICOMVR vr, ulong vn)
		{
			return vtkDICOMValue.vtkDICOMValue_AllocateUnsignedShortData_14(base.GetCppThis(), vr, vn);
		}

		// Token: 0x060008E7 RID: 2279
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMValue_AppendValueToSafeUTF8String_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, ulong i);

		// Token: 0x060008E8 RID: 2280 RVA: 0x000141F1 File Offset: 0x000123F1
		public void AppendValueToSafeUTF8String(string str, ulong i)
		{
			vtkDICOMValue.vtkDICOMValue_AppendValueToSafeUTF8String_15(base.GetCppThis(), str, i);
		}

		// Token: 0x060008E9 RID: 2281
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMValue_AppendValueToString_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, ulong i);

		// Token: 0x060008EA RID: 2282 RVA: 0x00014202 File Offset: 0x00012402
		public void AppendValueToString(string str, ulong i)
		{
			vtkDICOMValue.vtkDICOMValue_AppendValueToString_16(base.GetCppThis(), str, i);
		}

		// Token: 0x060008EB RID: 2283
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMValue_AppendValueToUTF8String_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, ulong i);

		// Token: 0x060008EC RID: 2284 RVA: 0x00014213 File Offset: 0x00012413
		public void AppendValueToUTF8String(string str, ulong i)
		{
			vtkDICOMValue.vtkDICOMValue_AppendValueToUTF8String_17(base.GetCppThis(), str, i);
		}

		// Token: 0x060008ED RID: 2285
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDICOMValue_AsDouble_18(HandleRef pThis);

		// Token: 0x060008EE RID: 2286 RVA: 0x00014224 File Offset: 0x00012424
		public double AsDouble()
		{
			return vtkDICOMValue.vtkDICOMValue_AsDouble_18(base.GetCppThis());
		}

		// Token: 0x060008EF RID: 2287
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkDICOMValue_AsFloat_19(HandleRef pThis);

		// Token: 0x060008F0 RID: 2288 RVA: 0x00014244 File Offset: 0x00012444
		public float AsFloat()
		{
			return vtkDICOMValue.vtkDICOMValue_AsFloat_19(base.GetCppThis());
		}

		// Token: 0x060008F1 RID: 2289
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMValue_AsInt_20(HandleRef pThis);

		// Token: 0x060008F2 RID: 2290 RVA: 0x00014264 File Offset: 0x00012464
		public int AsInt()
		{
			return vtkDICOMValue.vtkDICOMValue_AsInt_20(base.GetCppThis());
		}

		// Token: 0x060008F3 RID: 2291
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMValue_AsInt64_21(HandleRef pThis);

		// Token: 0x060008F4 RID: 2292 RVA: 0x00014284 File Offset: 0x00012484
		public long AsInt64()
		{
			return vtkDICOMValue.vtkDICOMValue_AsInt64_21(base.GetCppThis());
		}

		// Token: 0x060008F5 RID: 2293
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_AsItem_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060008F6 RID: 2294 RVA: 0x000142A4 File Offset: 0x000124A4
		public vtkDICOMItem AsItem()
		{
			vtkDICOMItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMValue.vtkDICOMValue_AsItem_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060008F7 RID: 2295
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern short vtkDICOMValue_AsShort_23(HandleRef pThis);

		// Token: 0x060008F8 RID: 2296 RVA: 0x00014300 File Offset: 0x00012500
		public short AsShort()
		{
			return vtkDICOMValue.vtkDICOMValue_AsShort_23(base.GetCppThis());
		}

		// Token: 0x060008F9 RID: 2297
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMValue_AsString_24(HandleRef pThis);

		// Token: 0x060008FA RID: 2298 RVA: 0x00014320 File Offset: 0x00012520
		public string AsString()
		{
			return vtkDICOMValue.vtkDICOMValue_AsString_24(base.GetCppThis());
		}

		// Token: 0x060008FB RID: 2299
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_AsTag_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060008FC RID: 2300 RVA: 0x00014340 File Offset: 0x00012540
		public vtkDICOMTag AsTag()
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMValue.vtkDICOMValue_AsTag_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060008FD RID: 2301
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMValue_AsUTF8String_26(HandleRef pThis);

		// Token: 0x060008FE RID: 2302 RVA: 0x0001439C File Offset: 0x0001259C
		public string AsUTF8String()
		{
			return vtkDICOMValue.vtkDICOMValue_AsUTF8String_26(base.GetCppThis());
		}

		// Token: 0x060008FF RID: 2303
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMValue_AsUnsignedChar_27(HandleRef pThis);

		// Token: 0x06000900 RID: 2304 RVA: 0x000143BC File Offset: 0x000125BC
		public byte AsUnsignedChar()
		{
			return vtkDICOMValue.vtkDICOMValue_AsUnsignedChar_27(base.GetCppThis());
		}

		// Token: 0x06000901 RID: 2305
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDICOMValue_AsUnsignedInt_28(HandleRef pThis);

		// Token: 0x06000902 RID: 2306 RVA: 0x000143DC File Offset: 0x000125DC
		public uint AsUnsignedInt()
		{
			return vtkDICOMValue.vtkDICOMValue_AsUnsignedInt_28(base.GetCppThis());
		}

		// Token: 0x06000903 RID: 2307
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDICOMValue_AsUnsignedInt64_29(HandleRef pThis);

		// Token: 0x06000904 RID: 2308 RVA: 0x000143FC File Offset: 0x000125FC
		public ulong AsUnsignedInt64()
		{
			return vtkDICOMValue.vtkDICOMValue_AsUnsignedInt64_29(base.GetCppThis());
		}

		// Token: 0x06000905 RID: 2309
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkDICOMValue_AsUnsignedShort_30(HandleRef pThis);

		// Token: 0x06000906 RID: 2310 RVA: 0x0001441C File Offset: 0x0001261C
		public ushort AsUnsignedShort()
		{
			return vtkDICOMValue.vtkDICOMValue_AsUnsignedShort_30(base.GetCppThis());
		}

		// Token: 0x06000907 RID: 2311
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMValue_Clear_31(HandleRef pThis);

		// Token: 0x06000908 RID: 2312 RVA: 0x0001443B File Offset: 0x0001263B
		public void Clear()
		{
			vtkDICOMValue.vtkDICOMValue_Clear_31(base.GetCppThis());
		}

		// Token: 0x06000909 RID: 2313
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMValue_ComputeNumberOfValuesForCharData_32(HandleRef pThis);

		// Token: 0x0600090A RID: 2314 RVA: 0x0001444A File Offset: 0x0001264A
		public void ComputeNumberOfValuesForCharData()
		{
			vtkDICOMValue.vtkDICOMValue_ComputeNumberOfValuesForCharData_32(base.GetCppThis());
		}

		// Token: 0x0600090B RID: 2315
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_FromUTF8String_33(vtkDICOMVR vr, vtkDICOMCharacterSet cs, [MarshalAs(UnmanagedType.LPUTF8Str)] string v, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600090C RID: 2316 RVA: 0x0001445C File Offset: 0x0001265C
		public static vtkDICOMValue FromUTF8String(vtkDICOMVR vr, vtkDICOMCharacterSet cs, string v)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMValue.vtkDICOMValue_FromUTF8String_33(vr, cs, v, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600090D RID: 2317
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_GetCharData_34(HandleRef pThis);

		// Token: 0x0600090E RID: 2318 RVA: 0x000144B4 File Offset: 0x000126B4
		public string GetCharData()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMValue.vtkDICOMValue_GetCharData_34(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600090F RID: 2319
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDICOMCharacterSet vtkDICOMValue_GetCharacterSet_35(HandleRef pThis);

		// Token: 0x06000910 RID: 2320 RVA: 0x000144F0 File Offset: 0x000126F0
		public vtkDICOMCharacterSet GetCharacterSet()
		{
			return vtkDICOMValue.vtkDICOMValue_GetCharacterSet_35(base.GetCppThis());
		}

		// Token: 0x06000911 RID: 2321
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDICOMValue_GetDouble_36(HandleRef pThis, ulong i);

		// Token: 0x06000912 RID: 2322 RVA: 0x00014510 File Offset: 0x00012710
		public double GetDouble(ulong i)
		{
			return vtkDICOMValue.vtkDICOMValue_GetDouble_36(base.GetCppThis(), i);
		}

		// Token: 0x06000913 RID: 2323
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_GetDoubleData_37(HandleRef pThis);

		// Token: 0x06000914 RID: 2324 RVA: 0x00014530 File Offset: 0x00012730
		public IntPtr GetDoubleData()
		{
			return vtkDICOMValue.vtkDICOMValue_GetDoubleData_37(base.GetCppThis());
		}

		// Token: 0x06000915 RID: 2325
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkDICOMValue_GetFloat_38(HandleRef pThis, ulong i);

		// Token: 0x06000916 RID: 2326 RVA: 0x00014550 File Offset: 0x00012750
		public float GetFloat(ulong i)
		{
			return vtkDICOMValue.vtkDICOMValue_GetFloat_38(base.GetCppThis(), i);
		}

		// Token: 0x06000917 RID: 2327
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_GetFloatData_39(HandleRef pThis);

		// Token: 0x06000918 RID: 2328 RVA: 0x00014570 File Offset: 0x00012770
		public IntPtr GetFloatData()
		{
			return vtkDICOMValue.vtkDICOMValue_GetFloatData_39(base.GetCppThis());
		}

		// Token: 0x06000919 RID: 2329
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMValue_GetInt_40(HandleRef pThis, ulong i);

		// Token: 0x0600091A RID: 2330 RVA: 0x00014590 File Offset: 0x00012790
		public int GetInt(ulong i)
		{
			return vtkDICOMValue.vtkDICOMValue_GetInt_40(base.GetCppThis(), i);
		}

		// Token: 0x0600091B RID: 2331
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMValue_GetInt64_41(HandleRef pThis, ulong i);

		// Token: 0x0600091C RID: 2332 RVA: 0x000145B0 File Offset: 0x000127B0
		public long GetInt64(ulong i)
		{
			return vtkDICOMValue.vtkDICOMValue_GetInt64_41(base.GetCppThis(), i);
		}

		// Token: 0x0600091D RID: 2333
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_GetInt64Data_42(HandleRef pThis);

		// Token: 0x0600091E RID: 2334 RVA: 0x000145D0 File Offset: 0x000127D0
		public IntPtr GetInt64Data()
		{
			return vtkDICOMValue.vtkDICOMValue_GetInt64Data_42(base.GetCppThis());
		}

		// Token: 0x0600091F RID: 2335
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_GetIntData_43(HandleRef pThis);

		// Token: 0x06000920 RID: 2336 RVA: 0x000145F0 File Offset: 0x000127F0
		public IntPtr GetIntData()
		{
			return vtkDICOMValue.vtkDICOMValue_GetIntData_43(base.GetCppThis());
		}

		// Token: 0x06000921 RID: 2337
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_GetItem_44(HandleRef pThis, ulong i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000922 RID: 2338 RVA: 0x00014610 File Offset: 0x00012810
		public vtkDICOMItem GetItem(ulong i)
		{
			vtkDICOMItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMValue.vtkDICOMValue_GetItem_44(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000923 RID: 2339
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_GetMultiplexData_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000924 RID: 2340 RVA: 0x0001466C File Offset: 0x0001286C
		public vtkDICOMValue GetMultiplexData()
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMValue.vtkDICOMValue_GetMultiplexData_45(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		// Token: 0x06000925 RID: 2341
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDICOMValue_GetNumberOfValues_46(HandleRef pThis);

		// Token: 0x06000926 RID: 2342 RVA: 0x000146C8 File Offset: 0x000128C8
		public ulong GetNumberOfValues()
		{
			return vtkDICOMValue.vtkDICOMValue_GetNumberOfValues_46(base.GetCppThis());
		}

		// Token: 0x06000927 RID: 2343
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_GetSequenceData_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000928 RID: 2344 RVA: 0x000146E8 File Offset: 0x000128E8
		public vtkDICOMItem GetSequenceData()
		{
			vtkDICOMItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMValue.vtkDICOMValue_GetSequenceData_47(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		// Token: 0x06000929 RID: 2345
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern short vtkDICOMValue_GetShort_48(HandleRef pThis, ulong i);

		// Token: 0x0600092A RID: 2346 RVA: 0x00014744 File Offset: 0x00012944
		public short GetShort(ulong i)
		{
			return vtkDICOMValue.vtkDICOMValue_GetShort_48(base.GetCppThis(), i);
		}

		// Token: 0x0600092B RID: 2347
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_GetShortData_49(HandleRef pThis);

		// Token: 0x0600092C RID: 2348 RVA: 0x00014764 File Offset: 0x00012964
		public IntPtr GetShortData()
		{
			return vtkDICOMValue.vtkDICOMValue_GetShortData_49(base.GetCppThis());
		}

		// Token: 0x0600092D RID: 2349
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMValue_GetString_50(HandleRef pThis, ulong i);

		// Token: 0x0600092E RID: 2350 RVA: 0x00014784 File Offset: 0x00012984
		public string GetString(ulong i)
		{
			return vtkDICOMValue.vtkDICOMValue_GetString_50(base.GetCppThis(), i);
		}

		// Token: 0x0600092F RID: 2351
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_GetTag_51(HandleRef pThis, ulong i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000930 RID: 2352 RVA: 0x000147A4 File Offset: 0x000129A4
		public vtkDICOMTag GetTag(ulong i)
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMValue.vtkDICOMValue_GetTag_51(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000931 RID: 2353
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_GetTagData_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000932 RID: 2354 RVA: 0x00014800 File Offset: 0x00012A00
		public vtkDICOMTag GetTagData()
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMValue.vtkDICOMValue_GetTagData_52(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		// Token: 0x06000933 RID: 2355
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMValue_GetUTF8String_53(HandleRef pThis, ulong i);

		// Token: 0x06000934 RID: 2356 RVA: 0x0001485C File Offset: 0x00012A5C
		public string GetUTF8String(ulong i)
		{
			return vtkDICOMValue.vtkDICOMValue_GetUTF8String_53(base.GetCppThis(), i);
		}

		// Token: 0x06000935 RID: 2357
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMValue_GetUnsignedChar_54(HandleRef pThis, ulong i);

		// Token: 0x06000936 RID: 2358 RVA: 0x0001487C File Offset: 0x00012A7C
		public byte GetUnsignedChar(ulong i)
		{
			return vtkDICOMValue.vtkDICOMValue_GetUnsignedChar_54(base.GetCppThis(), i);
		}

		// Token: 0x06000937 RID: 2359
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_GetUnsignedCharData_55(HandleRef pThis);

		// Token: 0x06000938 RID: 2360 RVA: 0x0001489C File Offset: 0x00012A9C
		public IntPtr GetUnsignedCharData()
		{
			return vtkDICOMValue.vtkDICOMValue_GetUnsignedCharData_55(base.GetCppThis());
		}

		// Token: 0x06000939 RID: 2361
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDICOMValue_GetUnsignedInt_56(HandleRef pThis, ulong i);

		// Token: 0x0600093A RID: 2362 RVA: 0x000148BC File Offset: 0x00012ABC
		public uint GetUnsignedInt(ulong i)
		{
			return vtkDICOMValue.vtkDICOMValue_GetUnsignedInt_56(base.GetCppThis(), i);
		}

		// Token: 0x0600093B RID: 2363
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDICOMValue_GetUnsignedInt64_57(HandleRef pThis, ulong i);

		// Token: 0x0600093C RID: 2364 RVA: 0x000148DC File Offset: 0x00012ADC
		public ulong GetUnsignedInt64(ulong i)
		{
			return vtkDICOMValue.vtkDICOMValue_GetUnsignedInt64_57(base.GetCppThis(), i);
		}

		// Token: 0x0600093D RID: 2365
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_GetUnsignedInt64Data_58(HandleRef pThis);

		// Token: 0x0600093E RID: 2366 RVA: 0x000148FC File Offset: 0x00012AFC
		public IntPtr GetUnsignedInt64Data()
		{
			return vtkDICOMValue.vtkDICOMValue_GetUnsignedInt64Data_58(base.GetCppThis());
		}

		// Token: 0x0600093F RID: 2367
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_GetUnsignedIntData_59(HandleRef pThis);

		// Token: 0x06000940 RID: 2368 RVA: 0x0001491C File Offset: 0x00012B1C
		public IntPtr GetUnsignedIntData()
		{
			return vtkDICOMValue.vtkDICOMValue_GetUnsignedIntData_59(base.GetCppThis());
		}

		// Token: 0x06000941 RID: 2369
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkDICOMValue_GetUnsignedShort_60(HandleRef pThis, ulong i);

		// Token: 0x06000942 RID: 2370 RVA: 0x0001493C File Offset: 0x00012B3C
		public ushort GetUnsignedShort(ulong i)
		{
			return vtkDICOMValue.vtkDICOMValue_GetUnsignedShort_60(base.GetCppThis(), i);
		}

		// Token: 0x06000943 RID: 2371
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_GetUnsignedShortData_61(HandleRef pThis);

		// Token: 0x06000944 RID: 2372 RVA: 0x0001495C File Offset: 0x00012B5C
		public IntPtr GetUnsignedShortData()
		{
			return vtkDICOMValue.vtkDICOMValue_GetUnsignedShortData_61(base.GetCppThis());
		}

		// Token: 0x06000945 RID: 2373
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDICOMValue_GetVL_62(HandleRef pThis);

		// Token: 0x06000946 RID: 2374 RVA: 0x0001497C File Offset: 0x00012B7C
		public uint GetVL()
		{
			return vtkDICOMValue.vtkDICOMValue_GetVL_62(base.GetCppThis());
		}

		// Token: 0x06000947 RID: 2375
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDICOMVR vtkDICOMValue_GetVR_63(HandleRef pThis);

		// Token: 0x06000948 RID: 2376 RVA: 0x0001499C File Offset: 0x00012B9C
		public vtkDICOMVR GetVR()
		{
			return vtkDICOMValue.vtkDICOMValue_GetVR_63(base.GetCppThis());
		}

		// Token: 0x06000949 RID: 2377
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMValue_GetValues_64(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string vb, ulong n, ulong i);

		// Token: 0x0600094A RID: 2378 RVA: 0x000149BB File Offset: 0x00012BBB
		public void GetValues(string vb, ulong n, ulong i)
		{
			vtkDICOMValue.vtkDICOMValue_GetValues_64(base.GetCppThis(), vb, n, i);
		}

		// Token: 0x0600094B RID: 2379
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMValue_GetValues_65(HandleRef pThis, IntPtr vb, ulong n, ulong i);

		// Token: 0x0600094C RID: 2380 RVA: 0x000149CD File Offset: 0x00012BCD
		public void GetValues(IntPtr vb, ulong n, ulong i)
		{
			vtkDICOMValue.vtkDICOMValue_GetValues_65(base.GetCppThis(), vb, n, i);
		}

		// Token: 0x0600094D RID: 2381
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMValue_GetValues_66(HandleRef pThis, HandleRef vb, ulong n, ulong i);

		// Token: 0x0600094E RID: 2382 RVA: 0x000149E0 File Offset: 0x00012BE0
		public void GetValues(vtkDICOMTag vb, ulong n, ulong i)
		{
			vtkDICOMValue.vtkDICOMValue_GetValues_66(base.GetCppThis(), (vb == null) ? default(HandleRef) : vb.GetCppThis(), n, i);
		}

		// Token: 0x0600094F RID: 2383
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMValue_IsValid_67(HandleRef pThis);

		// Token: 0x06000950 RID: 2384 RVA: 0x00014A14 File Offset: 0x00012C14
		public bool IsValid()
		{
			return vtkDICOMValue.vtkDICOMValue_IsValid_67(base.GetCppThis()) != 0;
		}

		// Token: 0x06000951 RID: 2385
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMValue_Matches_68(HandleRef pThis, HandleRef value);

		// Token: 0x06000952 RID: 2386 RVA: 0x00014A3C File Offset: 0x00012C3C
		public bool Matches(vtkDICOMValue value)
		{
			return vtkDICOMValue.vtkDICOMValue_Matches_68(base.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis()) != 0;
		}

		// Token: 0x06000953 RID: 2387
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMValue_Matches_69(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string v);

		// Token: 0x06000954 RID: 2388 RVA: 0x00014A78 File Offset: 0x00012C78
		public bool Matches(string v)
		{
			return vtkDICOMValue.vtkDICOMValue_Matches_69(base.GetCppThis(), v) != 0;
		}

		// Token: 0x06000955 RID: 2389
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMValue_Matches_70(HandleRef pThis, double v);

		// Token: 0x06000956 RID: 2390 RVA: 0x00014AA0 File Offset: 0x00012CA0
		public bool Matches(double v)
		{
			return vtkDICOMValue.vtkDICOMValue_Matches_70(base.GetCppThis(), v) != 0;
		}

		// Token: 0x06000957 RID: 2391
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_ReallocateUnsignedCharData_71(HandleRef pThis, ulong vn);

		// Token: 0x06000958 RID: 2392 RVA: 0x00014AC8 File Offset: 0x00012CC8
		public IntPtr ReallocateUnsignedCharData(ulong vn)
		{
			return vtkDICOMValue.vtkDICOMValue_ReallocateUnsignedCharData_71(base.GetCppThis(), vn);
		}

		// Token: 0x06000959 RID: 2393
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMValue_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, vtkDICOMTag tag);

		// Token: 0x0600095A RID: 2394 RVA: 0x00014AE8 File Offset: 0x00012CE8
		public vtkDICOMValue(vtkDICOMTag tag) : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMValue.vtkDICOMValue_New(ref num, ref maxValue, ref num2, tag);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000394 RID: 916
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMValue";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000395 RID: 917
		public new static readonly string MRClassNameKey = "class vtkDICOMValue";
	}
}
