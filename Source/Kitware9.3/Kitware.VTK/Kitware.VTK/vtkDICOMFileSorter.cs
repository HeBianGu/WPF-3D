using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000021 RID: 33
	public class vtkDICOMFileSorter : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600051B RID: 1307 RVA: 0x0000E9CD File Offset: 0x0000CBCD
		static vtkDICOMFileSorter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMFileSorter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMFileSorter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600051C RID: 1308 RVA: 0x0000E9F5 File Offset: 0x0000CBF5
		public vtkDICOMFileSorter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600051D RID: 1309
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMFileSorter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600051E RID: 1310 RVA: 0x0000EA04 File Offset: 0x0000CC04
		public new static vtkDICOMFileSorter New()
		{
			vtkDICOMFileSorter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMFileSorter.vtkDICOMFileSorter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMFileSorter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0000EA58 File Offset: 0x0000CC58
		public vtkDICOMFileSorter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMFileSorter.vtkDICOMFileSorter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000520 RID: 1312 RVA: 0x0000EA9C File Offset: 0x0000CC9C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000521 RID: 1313
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDICOMFileSorter_GetErrorCode_01(HandleRef pThis);

		// Token: 0x06000522 RID: 1314 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		public uint GetErrorCode()
		{
			return vtkDICOMFileSorter.vtkDICOMFileSorter_GetErrorCode_01(base.GetCppThis());
		}

		// Token: 0x06000523 RID: 1315
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMFileSorter_GetFileNamesForSeries_02(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000524 RID: 1316 RVA: 0x0000EAC8 File Offset: 0x0000CCC8
		public vtkStringArray GetFileNamesForSeries(int i)
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMFileSorter.vtkDICOMFileSorter_GetFileNamesForSeries_02(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000525 RID: 1317
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMFileSorter_GetFirstSeriesForStudy_03(HandleRef pThis, int study);

		// Token: 0x06000526 RID: 1318 RVA: 0x0000EB38 File Offset: 0x0000CD38
		public int GetFirstSeriesForStudy(int study)
		{
			return vtkDICOMFileSorter.vtkDICOMFileSorter_GetFirstSeriesForStudy_03(base.GetCppThis(), study);
		}

		// Token: 0x06000527 RID: 1319
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMFileSorter_GetInputFileName_04(HandleRef pThis);

		// Token: 0x06000528 RID: 1320 RVA: 0x0000EB58 File Offset: 0x0000CD58
		public string GetInputFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMFileSorter.vtkDICOMFileSorter_GetInputFileName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000529 RID: 1321
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMFileSorter_GetInputFileNames_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600052A RID: 1322 RVA: 0x0000EB94 File Offset: 0x0000CD94
		public vtkStringArray GetInputFileNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMFileSorter.vtkDICOMFileSorter_GetInputFileNames_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600052B RID: 1323
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMFileSorter_GetInternalFileName_06(HandleRef pThis);

		// Token: 0x0600052C RID: 1324 RVA: 0x0000EC04 File Offset: 0x0000CE04
		public string GetInternalFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMFileSorter.vtkDICOMFileSorter_GetInternalFileName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600052D RID: 1325
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMFileSorter_GetLastSeriesForStudy_07(HandleRef pThis, int study);

		// Token: 0x0600052E RID: 1326 RVA: 0x0000EC40 File Offset: 0x0000CE40
		public int GetLastSeriesForStudy(int study)
		{
			return vtkDICOMFileSorter.vtkDICOMFileSorter_GetLastSeriesForStudy_07(base.GetCppThis(), study);
		}

		// Token: 0x0600052F RID: 1327
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMFileSorter_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000530 RID: 1328 RVA: 0x0000EC60 File Offset: 0x0000CE60
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMFileSorter.vtkDICOMFileSorter_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06000531 RID: 1329
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMFileSorter_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000532 RID: 1330 RVA: 0x0000EC80 File Offset: 0x0000CE80
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMFileSorter.vtkDICOMFileSorter_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06000533 RID: 1331
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMFileSorter_GetNumberOfSeries_10(HandleRef pThis);

		// Token: 0x06000534 RID: 1332 RVA: 0x0000EC9C File Offset: 0x0000CE9C
		public int GetNumberOfSeries()
		{
			return vtkDICOMFileSorter.vtkDICOMFileSorter_GetNumberOfSeries_10(base.GetCppThis());
		}

		// Token: 0x06000535 RID: 1333
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMFileSorter_GetNumberOfStudies_11(HandleRef pThis);

		// Token: 0x06000536 RID: 1334 RVA: 0x0000ECBC File Offset: 0x0000CEBC
		public int GetNumberOfStudies()
		{
			return vtkDICOMFileSorter.vtkDICOMFileSorter_GetNumberOfStudies_11(base.GetCppThis());
		}

		// Token: 0x06000537 RID: 1335
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMFileSorter_GetOutputFileNames_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000538 RID: 1336 RVA: 0x0000ECDC File Offset: 0x0000CEDC
		public vtkStringArray GetOutputFileNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMFileSorter.vtkDICOMFileSorter_GetOutputFileNames_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000539 RID: 1337
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMFileSorter_GetRequirePixelData_13(HandleRef pThis);

		// Token: 0x0600053A RID: 1338 RVA: 0x0000ED4C File Offset: 0x0000CF4C
		public int GetRequirePixelData()
		{
			return vtkDICOMFileSorter.vtkDICOMFileSorter_GetRequirePixelData_13(base.GetCppThis());
		}

		// Token: 0x0600053B RID: 1339
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMFileSorter_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0600053C RID: 1340 RVA: 0x0000ED6C File Offset: 0x0000CF6C
		public override int IsA(string type)
		{
			return vtkDICOMFileSorter.vtkDICOMFileSorter_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0600053D RID: 1341
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMFileSorter_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0600053E RID: 1342 RVA: 0x0000ED8C File Offset: 0x0000CF8C
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMFileSorter.vtkDICOMFileSorter_IsTypeOf_15(type);
		}

		// Token: 0x0600053F RID: 1343
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMFileSorter_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000540 RID: 1344 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
		public new vtkDICOMFileSorter NewInstance()
		{
			vtkDICOMFileSorter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMFileSorter.vtkDICOMFileSorter_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMFileSorter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000541 RID: 1345
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMFileSorter_RequirePixelDataOff_18(HandleRef pThis);

		// Token: 0x06000542 RID: 1346 RVA: 0x0000EE02 File Offset: 0x0000D002
		public virtual void RequirePixelDataOff()
		{
			vtkDICOMFileSorter.vtkDICOMFileSorter_RequirePixelDataOff_18(base.GetCppThis());
		}

		// Token: 0x06000543 RID: 1347
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMFileSorter_RequirePixelDataOn_19(HandleRef pThis);

		// Token: 0x06000544 RID: 1348 RVA: 0x0000EE11 File Offset: 0x0000D011
		public virtual void RequirePixelDataOn()
		{
			vtkDICOMFileSorter.vtkDICOMFileSorter_RequirePixelDataOn_19(base.GetCppThis());
		}

		// Token: 0x06000545 RID: 1349
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMFileSorter_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000546 RID: 1350 RVA: 0x0000EE20 File Offset: 0x0000D020
		public new static vtkDICOMFileSorter SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMFileSorter vtkDICOMFileSorter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMFileSorter.vtkDICOMFileSorter_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMFileSorter = (vtkDICOMFileSorter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMFileSorter.Register(null);
				}
			}
			return vtkDICOMFileSorter;
		}

		// Token: 0x06000547 RID: 1351
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMFileSorter_SetInputFileName_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		// Token: 0x06000548 RID: 1352 RVA: 0x0000EE9F File Offset: 0x0000D09F
		public void SetInputFileName(string name)
		{
			vtkDICOMFileSorter.vtkDICOMFileSorter_SetInputFileName_21(base.GetCppThis(), name);
		}

		// Token: 0x06000549 RID: 1353
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMFileSorter_SetInputFileNames_22(HandleRef pThis, HandleRef input);

		// Token: 0x0600054A RID: 1354 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		public void SetInputFileNames(vtkStringArray input)
		{
			vtkDICOMFileSorter.vtkDICOMFileSorter_SetInputFileNames_22(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0600054B RID: 1355
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMFileSorter_SetRequirePixelData_23(HandleRef pThis, int _arg);

		// Token: 0x0600054C RID: 1356 RVA: 0x0000EEDF File Offset: 0x0000D0DF
		public virtual void SetRequirePixelData(int _arg)
		{
			vtkDICOMFileSorter.vtkDICOMFileSorter_SetRequirePixelData_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600054D RID: 1357
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMFileSorter_Update_24(HandleRef pThis);

		// Token: 0x0600054E RID: 1358 RVA: 0x0000EEEF File Offset: 0x0000D0EF
		public virtual void Update()
		{
			vtkDICOMFileSorter.vtkDICOMFileSorter_Update_24(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000352 RID: 850
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMFileSorter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000353 RID: 851
		public new static readonly string MRClassNameKey = "class vtkDICOMFileSorter";
	}
}
