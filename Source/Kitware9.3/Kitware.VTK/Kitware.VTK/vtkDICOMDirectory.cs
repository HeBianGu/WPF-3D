using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x0200001F RID: 31
	public class vtkDICOMDirectory : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000493 RID: 1171 RVA: 0x0000DEFE File Offset: 0x0000C0FE
		static vtkDICOMDirectory()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMDirectory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMDirectory"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000494 RID: 1172 RVA: 0x0000DF26 File Offset: 0x0000C126
		public vtkDICOMDirectory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000495 RID: 1173
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDirectory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000496 RID: 1174 RVA: 0x0000DF34 File Offset: 0x0000C134
		public new static vtkDICOMDirectory New()
		{
			vtkDICOMDirectory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDirectory.vtkDICOMDirectory_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMDirectory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000DF88 File Offset: 0x0000C188
		public vtkDICOMDirectory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMDirectory.vtkDICOMDirectory_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000498 RID: 1176 RVA: 0x0000DFCC File Offset: 0x0000C1CC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000499 RID: 1177
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_AddInputFileNames_01(HandleRef pThis, HandleRef sa);

		// Token: 0x0600049A RID: 1178 RVA: 0x0000DFD8 File Offset: 0x0000C1D8
		public void AddInputFileNames(vtkStringArray sa)
		{
			vtkDICOMDirectory.vtkDICOMDirectory_AddInputFileNames_01(base.GetCppThis(), (sa == null) ? default(HandleRef) : sa.GetCppThis());
		}

		// Token: 0x0600049B RID: 1179
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_FollowSymlinksOff_02(HandleRef pThis);

		// Token: 0x0600049C RID: 1180 RVA: 0x0000E007 File Offset: 0x0000C207
		public virtual void FollowSymlinksOff()
		{
			vtkDICOMDirectory.vtkDICOMDirectory_FollowSymlinksOff_02(base.GetCppThis());
		}

		// Token: 0x0600049D RID: 1181
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_FollowSymlinksOn_03(HandleRef pThis);

		// Token: 0x0600049E RID: 1182 RVA: 0x0000E016 File Offset: 0x0000C216
		public virtual void FollowSymlinksOn()
		{
			vtkDICOMDirectory.vtkDICOMDirectory_FollowSymlinksOn_03(base.GetCppThis());
		}

		// Token: 0x0600049F RID: 1183
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDICOMCharacterSet vtkDICOMDirectory_GetDefaultCharacterSet_04(HandleRef pThis);

		// Token: 0x060004A0 RID: 1184 RVA: 0x0000E028 File Offset: 0x0000C228
		public vtkDICOMCharacterSet GetDefaultCharacterSet()
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_GetDefaultCharacterSet_04(base.GetCppThis());
		}

		// Token: 0x060004A1 RID: 1185
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDirectory_GetDirectoryName_05(HandleRef pThis);

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000E048 File Offset: 0x0000C248
		public string GetDirectoryName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMDirectory.vtkDICOMDirectory_GetDirectoryName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060004A3 RID: 1187
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDirectory_GetFileNamesForSeries_06(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060004A4 RID: 1188 RVA: 0x0000E084 File Offset: 0x0000C284
		public vtkStringArray GetFileNamesForSeries(int i)
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDirectory.vtkDICOMDirectory_GetFileNamesForSeries_06(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x060004A5 RID: 1189
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDirectory_GetFilePattern_07(HandleRef pThis);

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000E0F4 File Offset: 0x0000C2F4
		public string GetFilePattern()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMDirectory.vtkDICOMDirectory_GetFilePattern_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060004A7 RID: 1191
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDirectory_GetFileSetID_08(HandleRef pThis);

		// Token: 0x060004A8 RID: 1192 RVA: 0x0000E130 File Offset: 0x0000C330
		public string GetFileSetID()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMDirectory.vtkDICOMDirectory_GetFileSetID_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060004A9 RID: 1193
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMDirectory_GetFindLevel_09(HandleRef pThis);

		// Token: 0x060004AA RID: 1194 RVA: 0x0000E16C File Offset: 0x0000C36C
		public int GetFindLevel()
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_GetFindLevel_09(base.GetCppThis());
		}

		// Token: 0x060004AB RID: 1195
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMDirectory_GetFirstSeriesForStudy_10(HandleRef pThis, int study);

		// Token: 0x060004AC RID: 1196 RVA: 0x0000E18C File Offset: 0x0000C38C
		public int GetFirstSeriesForStudy(int study)
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_GetFirstSeriesForStudy_10(base.GetCppThis(), study);
		}

		// Token: 0x060004AD RID: 1197
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMDirectory_GetFollowSymlinks_11(HandleRef pThis);

		// Token: 0x060004AE RID: 1198 RVA: 0x0000E1AC File Offset: 0x0000C3AC
		public int GetFollowSymlinks()
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_GetFollowSymlinks_11(base.GetCppThis());
		}

		// Token: 0x060004AF RID: 1199
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMDirectory_GetIgnoreDicomdir_12(HandleRef pThis);

		// Token: 0x060004B0 RID: 1200 RVA: 0x0000E1CC File Offset: 0x0000C3CC
		public int GetIgnoreDicomdir()
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_GetIgnoreDicomdir_12(base.GetCppThis());
		}

		// Token: 0x060004B1 RID: 1201
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDirectory_GetInputFileNames_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060004B2 RID: 1202 RVA: 0x0000E1EC File Offset: 0x0000C3EC
		public vtkStringArray GetInputFileNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDirectory.vtkDICOMDirectory_GetInputFileNames_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x060004B3 RID: 1203
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDirectory_GetInternalFileName_14(HandleRef pThis);

		// Token: 0x060004B4 RID: 1204 RVA: 0x0000E25C File Offset: 0x0000C45C
		public string GetInternalFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMDirectory.vtkDICOMDirectory_GetInternalFileName_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060004B5 RID: 1205
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMDirectory_GetLastSeriesForStudy_15(HandleRef pThis, int study);

		// Token: 0x060004B6 RID: 1206 RVA: 0x0000E298 File Offset: 0x0000C498
		public int GetLastSeriesForStudy(int study)
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_GetLastSeriesForStudy_15(base.GetCppThis(), study);
		}

		// Token: 0x060004B7 RID: 1207
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDirectory_GetMetaDataForSeries_16(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060004B8 RID: 1208 RVA: 0x0000E2B8 File Offset: 0x0000C4B8
		public vtkDICOMMetaData GetMetaDataForSeries(int i)
		{
			vtkDICOMMetaData vtkDICOMMetaData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDirectory.vtkDICOMDirectory_GetMetaDataForSeries_16(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMMetaData = (vtkDICOMMetaData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMMetaData.Register(null);
				}
			}
			return vtkDICOMMetaData;
		}

		// Token: 0x060004B9 RID: 1209
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMDirectory_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060004BA RID: 1210 RVA: 0x0000E328 File Offset: 0x0000C528
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x060004BB RID: 1211
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMDirectory_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060004BC RID: 1212 RVA: 0x0000E348 File Offset: 0x0000C548
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x060004BD RID: 1213
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMDirectory_GetNumberOfPatients_19(HandleRef pThis);

		// Token: 0x060004BE RID: 1214 RVA: 0x0000E364 File Offset: 0x0000C564
		public int GetNumberOfPatients()
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_GetNumberOfPatients_19(base.GetCppThis());
		}

		// Token: 0x060004BF RID: 1215
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMDirectory_GetNumberOfSeries_20(HandleRef pThis);

		// Token: 0x060004C0 RID: 1216 RVA: 0x0000E384 File Offset: 0x0000C584
		public int GetNumberOfSeries()
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_GetNumberOfSeries_20(base.GetCppThis());
		}

		// Token: 0x060004C1 RID: 1217
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMDirectory_GetNumberOfStudies_21(HandleRef pThis);

		// Token: 0x060004C2 RID: 1218 RVA: 0x0000E3A4 File Offset: 0x0000C5A4
		public int GetNumberOfStudies()
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_GetNumberOfStudies_21(base.GetCppThis());
		}

		// Token: 0x060004C3 RID: 1219
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMDirectory_GetOverrideCharacterSet_22(HandleRef pThis);

		// Token: 0x060004C4 RID: 1220 RVA: 0x0000E3C4 File Offset: 0x0000C5C4
		public bool GetOverrideCharacterSet()
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_GetOverrideCharacterSet_22(base.GetCppThis()) != 0;
		}

		// Token: 0x060004C5 RID: 1221
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDirectory_GetPatientRecord_23(HandleRef pThis, int patient, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060004C6 RID: 1222 RVA: 0x0000E3EC File Offset: 0x0000C5EC
		public vtkDICOMItem GetPatientRecord(int patient)
		{
			vtkDICOMItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDirectory.vtkDICOMDirectory_GetPatientRecord_23(base.GetCppThis(), patient, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060004C7 RID: 1223
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDirectory_GetPatientRecordForStudy_24(HandleRef pThis, int study, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060004C8 RID: 1224 RVA: 0x0000E448 File Offset: 0x0000C648
		public vtkDICOMItem GetPatientRecordForStudy(int study)
		{
			vtkDICOMItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDirectory.vtkDICOMDirectory_GetPatientRecordForStudy_24(base.GetCppThis(), study, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060004C9 RID: 1225
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMDirectory_GetQueryFiles_25(HandleRef pThis);

		// Token: 0x060004CA RID: 1226 RVA: 0x0000E4A4 File Offset: 0x0000C6A4
		public int GetQueryFiles()
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_GetQueryFiles_25(base.GetCppThis());
		}

		// Token: 0x060004CB RID: 1227
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMDirectory_GetRequirePixelData_26(HandleRef pThis);

		// Token: 0x060004CC RID: 1228 RVA: 0x0000E4C4 File Offset: 0x0000C6C4
		public int GetRequirePixelData()
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_GetRequirePixelData_26(base.GetCppThis());
		}

		// Token: 0x060004CD RID: 1229
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMDirectory_GetScanDepth_27(HandleRef pThis);

		// Token: 0x060004CE RID: 1230 RVA: 0x0000E4E4 File Offset: 0x0000C6E4
		public int GetScanDepth()
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_GetScanDepth_27(base.GetCppThis());
		}

		// Token: 0x060004CF RID: 1231
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDirectory_GetSeriesRecord_28(HandleRef pThis, int series, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060004D0 RID: 1232 RVA: 0x0000E504 File Offset: 0x0000C704
		public vtkDICOMItem GetSeriesRecord(int series)
		{
			vtkDICOMItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDirectory.vtkDICOMDirectory_GetSeriesRecord_28(base.GetCppThis(), series, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060004D1 RID: 1233
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMDirectory_GetShowHidden_29(HandleRef pThis);

		// Token: 0x060004D2 RID: 1234 RVA: 0x0000E560 File Offset: 0x0000C760
		public int GetShowHidden()
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_GetShowHidden_29(base.GetCppThis());
		}

		// Token: 0x060004D3 RID: 1235
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDirectory_GetStudiesForPatient_30(HandleRef pThis, int patient, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060004D4 RID: 1236 RVA: 0x0000E580 File Offset: 0x0000C780
		public vtkIntArray GetStudiesForPatient(int patient)
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDirectory.vtkDICOMDirectory_GetStudiesForPatient_30(base.GetCppThis(), patient, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		// Token: 0x060004D5 RID: 1237
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDirectory_GetStudyRecord_31(HandleRef pThis, int study, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060004D6 RID: 1238 RVA: 0x0000E5F0 File Offset: 0x0000C7F0
		public vtkDICOMItem GetStudyRecord(int study)
		{
			vtkDICOMItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDirectory.vtkDICOMDirectory_GetStudyRecord_31(base.GetCppThis(), study, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060004D7 RID: 1239
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_IgnoreDicomdirOff_32(HandleRef pThis);

		// Token: 0x060004D8 RID: 1240 RVA: 0x0000E64B File Offset: 0x0000C84B
		public virtual void IgnoreDicomdirOff()
		{
			vtkDICOMDirectory.vtkDICOMDirectory_IgnoreDicomdirOff_32(base.GetCppThis());
		}

		// Token: 0x060004D9 RID: 1241
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_IgnoreDicomdirOn_33(HandleRef pThis);

		// Token: 0x060004DA RID: 1242 RVA: 0x0000E65A File Offset: 0x0000C85A
		public virtual void IgnoreDicomdirOn()
		{
			vtkDICOMDirectory.vtkDICOMDirectory_IgnoreDicomdirOn_33(base.GetCppThis());
		}

		// Token: 0x060004DB RID: 1243
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMDirectory_IsA_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060004DC RID: 1244 RVA: 0x0000E66C File Offset: 0x0000C86C
		public override int IsA(string type)
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_IsA_34(base.GetCppThis(), type);
		}

		// Token: 0x060004DD RID: 1245
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMDirectory_IsTypeOf_35([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060004DE RID: 1246 RVA: 0x0000E68C File Offset: 0x0000C88C
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_IsTypeOf_35(type);
		}

		// Token: 0x060004DF RID: 1247
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDirectory_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060004E0 RID: 1248 RVA: 0x0000E6A8 File Offset: 0x0000C8A8
		public new vtkDICOMDirectory NewInstance()
		{
			vtkDICOMDirectory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDirectory.vtkDICOMDirectory_NewInstance_37(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMDirectory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060004E1 RID: 1249
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_OverrideCharacterSetOff_38(HandleRef pThis);

		// Token: 0x060004E2 RID: 1250 RVA: 0x0000E702 File Offset: 0x0000C902
		public virtual void OverrideCharacterSetOff()
		{
			vtkDICOMDirectory.vtkDICOMDirectory_OverrideCharacterSetOff_38(base.GetCppThis());
		}

		// Token: 0x060004E3 RID: 1251
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_OverrideCharacterSetOn_39(HandleRef pThis);

		// Token: 0x060004E4 RID: 1252 RVA: 0x0000E711 File Offset: 0x0000C911
		public virtual void OverrideCharacterSetOn()
		{
			vtkDICOMDirectory.vtkDICOMDirectory_OverrideCharacterSetOn_39(base.GetCppThis());
		}

		// Token: 0x060004E5 RID: 1253
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_RequirePixelDataOff_40(HandleRef pThis);

		// Token: 0x060004E6 RID: 1254 RVA: 0x0000E720 File Offset: 0x0000C920
		public virtual void RequirePixelDataOff()
		{
			vtkDICOMDirectory.vtkDICOMDirectory_RequirePixelDataOff_40(base.GetCppThis());
		}

		// Token: 0x060004E7 RID: 1255
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_RequirePixelDataOn_41(HandleRef pThis);

		// Token: 0x060004E8 RID: 1256 RVA: 0x0000E72F File Offset: 0x0000C92F
		public virtual void RequirePixelDataOn()
		{
			vtkDICOMDirectory.vtkDICOMDirectory_RequirePixelDataOn_41(base.GetCppThis());
		}

		// Token: 0x060004E9 RID: 1257
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDirectory_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060004EA RID: 1258 RVA: 0x0000E740 File Offset: 0x0000C940
		public new static vtkDICOMDirectory SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMDirectory vtkDICOMDirectory = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDirectory.vtkDICOMDirectory_SafeDownCast_42((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMDirectory = (vtkDICOMDirectory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMDirectory.Register(null);
				}
			}
			return vtkDICOMDirectory;
		}

		// Token: 0x060004EB RID: 1259
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetDefaultCharacterSet_43(HandleRef pThis, vtkDICOMCharacterSet cs);

		// Token: 0x060004EC RID: 1260 RVA: 0x0000E7BF File Offset: 0x0000C9BF
		public void SetDefaultCharacterSet(vtkDICOMCharacterSet cs)
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetDefaultCharacterSet_43(base.GetCppThis(), cs);
		}

		// Token: 0x060004ED RID: 1261
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetDirectoryName_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		// Token: 0x060004EE RID: 1262 RVA: 0x0000E7CF File Offset: 0x0000C9CF
		public void SetDirectoryName(string name)
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetDirectoryName_44(base.GetCppThis(), name);
		}

		// Token: 0x060004EF RID: 1263
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetFilePattern_45(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string pattern);

		// Token: 0x060004F0 RID: 1264 RVA: 0x0000E7DF File Offset: 0x0000C9DF
		public void SetFilePattern(string pattern)
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetFilePattern_45(base.GetCppThis(), pattern);
		}

		// Token: 0x060004F1 RID: 1265
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetFindLevel_46(HandleRef pThis, int level);

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000E7EF File Offset: 0x0000C9EF
		public void SetFindLevel(int level)
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetFindLevel_46(base.GetCppThis(), level);
		}

		// Token: 0x060004F3 RID: 1267
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetFindLevelToImage_47(HandleRef pThis);

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000E7FF File Offset: 0x0000C9FF
		public void SetFindLevelToImage()
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetFindLevelToImage_47(base.GetCppThis());
		}

		// Token: 0x060004F5 RID: 1269
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetFindLevelToSeries_48(HandleRef pThis);

		// Token: 0x060004F6 RID: 1270 RVA: 0x0000E80E File Offset: 0x0000CA0E
		public void SetFindLevelToSeries()
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetFindLevelToSeries_48(base.GetCppThis());
		}

		// Token: 0x060004F7 RID: 1271
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetFindQuery_49(HandleRef pThis, HandleRef query);

		// Token: 0x060004F8 RID: 1272 RVA: 0x0000E820 File Offset: 0x0000CA20
		public void SetFindQuery(vtkDICOMItem query)
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetFindQuery_49(base.GetCppThis(), (query == null) ? default(HandleRef) : query.GetCppThis());
		}

		// Token: 0x060004F9 RID: 1273
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetFollowSymlinks_50(HandleRef pThis, int _arg);

		// Token: 0x060004FA RID: 1274 RVA: 0x0000E84F File Offset: 0x0000CA4F
		public virtual void SetFollowSymlinks(int _arg)
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetFollowSymlinks_50(base.GetCppThis(), _arg);
		}

		// Token: 0x060004FB RID: 1275
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetIgnoreDicomdir_51(HandleRef pThis, int _arg);

		// Token: 0x060004FC RID: 1276 RVA: 0x0000E85F File Offset: 0x0000CA5F
		public virtual void SetIgnoreDicomdir(int _arg)
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetIgnoreDicomdir_51(base.GetCppThis(), _arg);
		}

		// Token: 0x060004FD RID: 1277
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetInputFileNames_52(HandleRef pThis, HandleRef sa);

		// Token: 0x060004FE RID: 1278 RVA: 0x0000E870 File Offset: 0x0000CA70
		public void SetInputFileNames(vtkStringArray sa)
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetInputFileNames_52(base.GetCppThis(), (sa == null) ? default(HandleRef) : sa.GetCppThis());
		}

		// Token: 0x060004FF RID: 1279
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetOverrideCharacterSet_53(HandleRef pThis, byte _arg);

		// Token: 0x06000500 RID: 1280 RVA: 0x0000E89F File Offset: 0x0000CA9F
		public virtual void SetOverrideCharacterSet(bool _arg)
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetOverrideCharacterSet_53(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06000501 RID: 1281
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetQueryFiles_54(HandleRef pThis, int _arg);

		// Token: 0x06000502 RID: 1282 RVA: 0x0000E8B7 File Offset: 0x0000CAB7
		public virtual void SetQueryFiles(int _arg)
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetQueryFiles_54(base.GetCppThis(), _arg);
		}

		// Token: 0x06000503 RID: 1283
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetQueryFilesToAlways_55(HandleRef pThis);

		// Token: 0x06000504 RID: 1284 RVA: 0x0000E8C7 File Offset: 0x0000CAC7
		public void SetQueryFilesToAlways()
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetQueryFilesToAlways_55(base.GetCppThis());
		}

		// Token: 0x06000505 RID: 1285
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetQueryFilesToDefault_56(HandleRef pThis);

		// Token: 0x06000506 RID: 1286 RVA: 0x0000E8D6 File Offset: 0x0000CAD6
		public void SetQueryFilesToDefault()
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetQueryFilesToDefault_56(base.GetCppThis());
		}

		// Token: 0x06000507 RID: 1287
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetQueryFilesToNever_57(HandleRef pThis);

		// Token: 0x06000508 RID: 1288 RVA: 0x0000E8E5 File Offset: 0x0000CAE5
		public void SetQueryFilesToNever()
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetQueryFilesToNever_57(base.GetCppThis());
		}

		// Token: 0x06000509 RID: 1289
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetRequirePixelData_58(HandleRef pThis, int _arg);

		// Token: 0x0600050A RID: 1290 RVA: 0x0000E8F4 File Offset: 0x0000CAF4
		public virtual void SetRequirePixelData(int _arg)
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetRequirePixelData_58(base.GetCppThis(), _arg);
		}

		// Token: 0x0600050B RID: 1291
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetScanDepth_59(HandleRef pThis, int _arg);

		// Token: 0x0600050C RID: 1292 RVA: 0x0000E904 File Offset: 0x0000CB04
		public virtual void SetScanDepth(int _arg)
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetScanDepth_59(base.GetCppThis(), _arg);
		}

		// Token: 0x0600050D RID: 1293
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_SetShowHidden_60(HandleRef pThis, int _arg);

		// Token: 0x0600050E RID: 1294 RVA: 0x0000E914 File Offset: 0x0000CB14
		public virtual void SetShowHidden(int _arg)
		{
			vtkDICOMDirectory.vtkDICOMDirectory_SetShowHidden_60(base.GetCppThis(), _arg);
		}

		// Token: 0x0600050F RID: 1295
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_ShowHiddenOff_61(HandleRef pThis);

		// Token: 0x06000510 RID: 1296 RVA: 0x0000E924 File Offset: 0x0000CB24
		public virtual void ShowHiddenOff()
		{
			vtkDICOMDirectory.vtkDICOMDirectory_ShowHiddenOff_61(base.GetCppThis());
		}

		// Token: 0x06000511 RID: 1297
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_ShowHiddenOn_62(HandleRef pThis);

		// Token: 0x06000512 RID: 1298 RVA: 0x0000E933 File Offset: 0x0000CB33
		public virtual void ShowHiddenOn()
		{
			vtkDICOMDirectory.vtkDICOMDirectory_ShowHiddenOn_62(base.GetCppThis());
		}

		// Token: 0x06000513 RID: 1299
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_Update_63(HandleRef pThis);

		// Token: 0x06000514 RID: 1300 RVA: 0x0000E942 File Offset: 0x0000CB42
		public override void Update()
		{
			vtkDICOMDirectory.vtkDICOMDirectory_Update_63(base.GetCppThis());
		}

		// Token: 0x06000515 RID: 1301
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDirectory_Update_64(HandleRef pThis, int arg0);

		// Token: 0x06000516 RID: 1302 RVA: 0x0000E951 File Offset: 0x0000CB51
		public override void Update(int arg0)
		{
			vtkDICOMDirectory.vtkDICOMDirectory_Update_64(base.GetCppThis(), arg0);
		}

		// Token: 0x06000517 RID: 1303
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMDirectory_Update_65(HandleRef pThis, HandleRef arg0);

		// Token: 0x06000518 RID: 1304 RVA: 0x0000E964 File Offset: 0x0000CB64
		public override int Update(vtkInformation arg0)
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_Update_65(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000519 RID: 1305
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMDirectory_Update_66(HandleRef pThis, int i, HandleRef arg1);

		// Token: 0x0600051A RID: 1306 RVA: 0x0000E998 File Offset: 0x0000CB98
		public override int Update(int i, vtkInformationVector arg1)
		{
			return vtkDICOMDirectory.vtkDICOMDirectory_Update_66(base.GetCppThis(), i, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400034A RID: 842
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMDirectory";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400034B RID: 843
		public new static readonly string MRClassNameKey = "class vtkDICOMDirectory";

		// Token: 0x02000020 RID: 32
		public enum FRAME_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400034D RID: 845
			FRAME = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400034E RID: 846
			IMAGE = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400034F RID: 847
			PATIENT = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000350 RID: 848
			SERIES = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000351 RID: 849
			STUDY = 1
		}
	}
}
