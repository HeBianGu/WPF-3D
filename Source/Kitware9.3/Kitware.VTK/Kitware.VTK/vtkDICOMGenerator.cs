using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000022 RID: 34
	public class vtkDICOMGenerator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600054F RID: 1359 RVA: 0x0000EEFE File Offset: 0x0000D0FE
		static vtkDICOMGenerator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMGenerator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMGenerator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000550 RID: 1360 RVA: 0x0000EF26 File Offset: 0x0000D126
		public vtkDICOMGenerator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000551 RID: 1361
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMGenerator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000552 RID: 1362 RVA: 0x0000EF34 File Offset: 0x0000D134
		public new static vtkDICOMGenerator New()
		{
			vtkDICOMGenerator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMGenerator.vtkDICOMGenerator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0000EF88 File Offset: 0x0000D188
		public vtkDICOMGenerator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMGenerator.vtkDICOMGenerator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000554 RID: 1364 RVA: 0x0000EFCC File Offset: 0x0000D1CC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000555 RID: 1365
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_ExtendedOff_01(HandleRef pThis);

		// Token: 0x06000556 RID: 1366 RVA: 0x0000EFD7 File Offset: 0x0000D1D7
		public virtual void ExtendedOff()
		{
			vtkDICOMGenerator.vtkDICOMGenerator_ExtendedOff_01(base.GetCppThis());
		}

		// Token: 0x06000557 RID: 1367
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_ExtendedOn_02(HandleRef pThis);

		// Token: 0x06000558 RID: 1368 RVA: 0x0000EFE6 File Offset: 0x0000D1E6
		public virtual void ExtendedOn()
		{
			vtkDICOMGenerator.vtkDICOMGenerator_ExtendedOn_02(base.GetCppThis());
		}

		// Token: 0x06000559 RID: 1369
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMGenerator_GenerateInstance_03(HandleRef pThis, HandleRef arg0);

		// Token: 0x0600055A RID: 1370 RVA: 0x0000EFF8 File Offset: 0x0000D1F8
		public virtual bool GenerateInstance(vtkInformation arg0)
		{
			return vtkDICOMGenerator.vtkDICOMGenerator_GenerateInstance_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis()) != 0;
		}

		// Token: 0x0600055B RID: 1371
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMGenerator_GetComponentIndexArray_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600055C RID: 1372 RVA: 0x0000F034 File Offset: 0x0000D234
		public vtkIntArray GetComponentIndexArray()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMGenerator.vtkDICOMGenerator_GetComponentIndexArray_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600055D RID: 1373
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMGenerator_GetExtended_05(HandleRef pThis);

		// Token: 0x0600055E RID: 1374 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
		public virtual int GetExtended()
		{
			return vtkDICOMGenerator.vtkDICOMGenerator_GetExtended_05(base.GetCppThis());
		}

		// Token: 0x0600055F RID: 1375
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMGenerator_GetMetaData_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000560 RID: 1376 RVA: 0x0000F0C4 File Offset: 0x0000D2C4
		public vtkDICOMMetaData GetMetaData()
		{
			vtkDICOMMetaData vtkDICOMMetaData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMGenerator.vtkDICOMGenerator_GetMetaData_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000561 RID: 1377
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMGenerator_GetMultiFrame_07(HandleRef pThis);

		// Token: 0x06000562 RID: 1378 RVA: 0x0000F134 File Offset: 0x0000D334
		public virtual int GetMultiFrame()
		{
			return vtkDICOMGenerator.vtkDICOMGenerator_GetMultiFrame_07(base.GetCppThis());
		}

		// Token: 0x06000563 RID: 1379
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMGenerator_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000564 RID: 1380 RVA: 0x0000F154 File Offset: 0x0000D354
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMGenerator.vtkDICOMGenerator_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06000565 RID: 1381
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMGenerator_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000566 RID: 1382 RVA: 0x0000F174 File Offset: 0x0000D374
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMGenerator.vtkDICOMGenerator_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06000567 RID: 1383
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMGenerator_GetNumberOfOverlays_10(HandleRef pThis);

		// Token: 0x06000568 RID: 1384 RVA: 0x0000F190 File Offset: 0x0000D390
		public virtual int GetNumberOfOverlays()
		{
			return vtkDICOMGenerator.vtkDICOMGenerator_GetNumberOfOverlays_10(base.GetCppThis());
		}

		// Token: 0x06000569 RID: 1385
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMGenerator_GetOriginAtBottom_11(HandleRef pThis);

		// Token: 0x0600056A RID: 1386 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		public virtual int GetOriginAtBottom()
		{
			return vtkDICOMGenerator.vtkDICOMGenerator_GetOriginAtBottom_11(base.GetCppThis());
		}

		// Token: 0x0600056B RID: 1387
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMGenerator_GetPatientMatrix_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600056C RID: 1388 RVA: 0x0000F1D0 File Offset: 0x0000D3D0
		public vtkMatrix4x4 GetPatientMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMGenerator.vtkDICOMGenerator_GetPatientMatrix_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x0600056D RID: 1389
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDICOMGenerator_GetRescaleIntercept_13(HandleRef pThis);

		// Token: 0x0600056E RID: 1390 RVA: 0x0000F240 File Offset: 0x0000D440
		public virtual double GetRescaleIntercept()
		{
			return vtkDICOMGenerator.vtkDICOMGenerator_GetRescaleIntercept_13(base.GetCppThis());
		}

		// Token: 0x0600056F RID: 1391
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDICOMGenerator_GetRescaleSlope_14(HandleRef pThis);

		// Token: 0x06000570 RID: 1392 RVA: 0x0000F260 File Offset: 0x0000D460
		public virtual double GetRescaleSlope()
		{
			return vtkDICOMGenerator.vtkDICOMGenerator_GetRescaleSlope_14(base.GetCppThis());
		}

		// Token: 0x06000571 RID: 1393
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMGenerator_GetReverseSliceOrder_15(HandleRef pThis);

		// Token: 0x06000572 RID: 1394 RVA: 0x0000F280 File Offset: 0x0000D480
		public virtual int GetReverseSliceOrder()
		{
			return vtkDICOMGenerator.vtkDICOMGenerator_GetReverseSliceOrder_15(base.GetCppThis());
		}

		// Token: 0x06000573 RID: 1395
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMGenerator_GetSliceIndexArray_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000574 RID: 1396 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		public vtkIntArray GetSliceIndexArray()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMGenerator.vtkDICOMGenerator_GetSliceIndexArray_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000575 RID: 1397
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMGenerator_GetSourceMetaData_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000576 RID: 1398 RVA: 0x0000F310 File Offset: 0x0000D510
		public vtkDICOMMetaData GetSourceMetaData()
		{
			vtkDICOMMetaData vtkDICOMMetaData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMGenerator.vtkDICOMGenerator_GetSourceMetaData_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000577 RID: 1399
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMGenerator_GetTimeAsVector_18(HandleRef pThis);

		// Token: 0x06000578 RID: 1400 RVA: 0x0000F380 File Offset: 0x0000D580
		public virtual int GetTimeAsVector()
		{
			return vtkDICOMGenerator.vtkDICOMGenerator_GetTimeAsVector_18(base.GetCppThis());
		}

		// Token: 0x06000579 RID: 1401
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMGenerator_GetTimeDimension_19(HandleRef pThis);

		// Token: 0x0600057A RID: 1402 RVA: 0x0000F3A0 File Offset: 0x0000D5A0
		public virtual int GetTimeDimension()
		{
			return vtkDICOMGenerator.vtkDICOMGenerator_GetTimeDimension_19(base.GetCppThis());
		}

		// Token: 0x0600057B RID: 1403
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDICOMGenerator_GetTimeSpacing_20(HandleRef pThis);

		// Token: 0x0600057C RID: 1404 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
		public virtual double GetTimeSpacing()
		{
			return vtkDICOMGenerator.vtkDICOMGenerator_GetTimeSpacing_20(base.GetCppThis());
		}

		// Token: 0x0600057D RID: 1405
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMGenerator_GetUIDGenerator_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600057E RID: 1406 RVA: 0x0000F3E0 File Offset: 0x0000D5E0
		public vtkDICOMUIDGenerator GetUIDGenerator()
		{
			vtkDICOMUIDGenerator vtkDICOMUIDGenerator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMGenerator.vtkDICOMGenerator_GetUIDGenerator_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMUIDGenerator = (vtkDICOMUIDGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMUIDGenerator.Register(null);
				}
			}
			return vtkDICOMUIDGenerator;
		}

		// Token: 0x0600057F RID: 1407
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMGenerator_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000580 RID: 1408 RVA: 0x0000F450 File Offset: 0x0000D650
		public override int IsA(string type)
		{
			return vtkDICOMGenerator.vtkDICOMGenerator_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06000581 RID: 1409
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMGenerator_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000582 RID: 1410 RVA: 0x0000F470 File Offset: 0x0000D670
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMGenerator.vtkDICOMGenerator_IsTypeOf_23(type);
		}

		// Token: 0x06000583 RID: 1411
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_MultiFrameOff_24(HandleRef pThis);

		// Token: 0x06000584 RID: 1412 RVA: 0x0000F48A File Offset: 0x0000D68A
		public virtual void MultiFrameOff()
		{
			vtkDICOMGenerator.vtkDICOMGenerator_MultiFrameOff_24(base.GetCppThis());
		}

		// Token: 0x06000585 RID: 1413
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_MultiFrameOn_25(HandleRef pThis);

		// Token: 0x06000586 RID: 1414 RVA: 0x0000F499 File Offset: 0x0000D699
		public virtual void MultiFrameOn()
		{
			vtkDICOMGenerator.vtkDICOMGenerator_MultiFrameOn_25(base.GetCppThis());
		}

		// Token: 0x06000587 RID: 1415
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMGenerator_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000588 RID: 1416 RVA: 0x0000F4A8 File Offset: 0x0000D6A8
		public new vtkDICOMGenerator NewInstance()
		{
			vtkDICOMGenerator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMGenerator.vtkDICOMGenerator_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000589 RID: 1417
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMGenerator_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600058A RID: 1418 RVA: 0x0000F504 File Offset: 0x0000D704
		public new static vtkDICOMGenerator SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMGenerator vtkDICOMGenerator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMGenerator.vtkDICOMGenerator_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMGenerator = (vtkDICOMGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMGenerator.Register(null);
				}
			}
			return vtkDICOMGenerator;
		}

		// Token: 0x0600058B RID: 1419
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_SetExtended_29(HandleRef pThis, int _arg);

		// Token: 0x0600058C RID: 1420 RVA: 0x0000F583 File Offset: 0x0000D783
		public virtual void SetExtended(int _arg)
		{
			vtkDICOMGenerator.vtkDICOMGenerator_SetExtended_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600058D RID: 1421
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_SetMultiFrame_30(HandleRef pThis, int _arg);

		// Token: 0x0600058E RID: 1422 RVA: 0x0000F593 File Offset: 0x0000D793
		public virtual void SetMultiFrame(int _arg)
		{
			vtkDICOMGenerator.vtkDICOMGenerator_SetMultiFrame_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600058F RID: 1423
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_SetNumberOfOverlays_31(HandleRef pThis, int _arg);

		// Token: 0x06000590 RID: 1424 RVA: 0x0000F5A3 File Offset: 0x0000D7A3
		public virtual void SetNumberOfOverlays(int _arg)
		{
			vtkDICOMGenerator.vtkDICOMGenerator_SetNumberOfOverlays_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06000591 RID: 1425
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_SetOriginAtBottom_32(HandleRef pThis, int _arg);

		// Token: 0x06000592 RID: 1426 RVA: 0x0000F5B3 File Offset: 0x0000D7B3
		public virtual void SetOriginAtBottom(int _arg)
		{
			vtkDICOMGenerator.vtkDICOMGenerator_SetOriginAtBottom_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06000593 RID: 1427
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_SetPatientMatrix_33(HandleRef pThis, HandleRef arg0);

		// Token: 0x06000594 RID: 1428 RVA: 0x0000F5C4 File Offset: 0x0000D7C4
		public void SetPatientMatrix(vtkMatrix4x4 arg0)
		{
			vtkDICOMGenerator.vtkDICOMGenerator_SetPatientMatrix_33(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000595 RID: 1429
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_SetRescaleIntercept_34(HandleRef pThis, double _arg);

		// Token: 0x06000596 RID: 1430 RVA: 0x0000F5F3 File Offset: 0x0000D7F3
		public virtual void SetRescaleIntercept(double _arg)
		{
			vtkDICOMGenerator.vtkDICOMGenerator_SetRescaleIntercept_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06000597 RID: 1431
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_SetRescaleSlope_35(HandleRef pThis, double _arg);

		// Token: 0x06000598 RID: 1432 RVA: 0x0000F603 File Offset: 0x0000D803
		public virtual void SetRescaleSlope(double _arg)
		{
			vtkDICOMGenerator.vtkDICOMGenerator_SetRescaleSlope_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06000599 RID: 1433
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_SetReverseSliceOrder_36(HandleRef pThis, int _arg);

		// Token: 0x0600059A RID: 1434 RVA: 0x0000F613 File Offset: 0x0000D813
		public virtual void SetReverseSliceOrder(int _arg)
		{
			vtkDICOMGenerator.vtkDICOMGenerator_SetReverseSliceOrder_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600059B RID: 1435
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_SetSourceMetaData_37(HandleRef pThis, HandleRef arg0);

		// Token: 0x0600059C RID: 1436 RVA: 0x0000F624 File Offset: 0x0000D824
		public void SetSourceMetaData(vtkDICOMMetaData arg0)
		{
			vtkDICOMGenerator.vtkDICOMGenerator_SetSourceMetaData_37(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600059D RID: 1437
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_SetTimeAsVector_38(HandleRef pThis, int _arg);

		// Token: 0x0600059E RID: 1438 RVA: 0x0000F653 File Offset: 0x0000D853
		public virtual void SetTimeAsVector(int _arg)
		{
			vtkDICOMGenerator.vtkDICOMGenerator_SetTimeAsVector_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600059F RID: 1439
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_SetTimeDimension_39(HandleRef pThis, int _arg);

		// Token: 0x060005A0 RID: 1440 RVA: 0x0000F663 File Offset: 0x0000D863
		public virtual void SetTimeDimension(int _arg)
		{
			vtkDICOMGenerator.vtkDICOMGenerator_SetTimeDimension_39(base.GetCppThis(), _arg);
		}

		// Token: 0x060005A1 RID: 1441
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_SetTimeSpacing_40(HandleRef pThis, double _arg);

		// Token: 0x060005A2 RID: 1442 RVA: 0x0000F673 File Offset: 0x0000D873
		public virtual void SetTimeSpacing(double _arg)
		{
			vtkDICOMGenerator.vtkDICOMGenerator_SetTimeSpacing_40(base.GetCppThis(), _arg);
		}

		// Token: 0x060005A3 RID: 1443
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_SetUIDGenerator_41(HandleRef pThis, HandleRef arg0);

		// Token: 0x060005A4 RID: 1444 RVA: 0x0000F684 File Offset: 0x0000D884
		public void SetUIDGenerator(vtkDICOMUIDGenerator arg0)
		{
			vtkDICOMGenerator.vtkDICOMGenerator_SetUIDGenerator_41(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060005A5 RID: 1445
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_TimeAsVectorOff_42(HandleRef pThis);

		// Token: 0x060005A6 RID: 1446 RVA: 0x0000F6B3 File Offset: 0x0000D8B3
		public virtual void TimeAsVectorOff()
		{
			vtkDICOMGenerator.vtkDICOMGenerator_TimeAsVectorOff_42(base.GetCppThis());
		}

		// Token: 0x060005A7 RID: 1447
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMGenerator_TimeAsVectorOn_43(HandleRef pThis);

		// Token: 0x060005A8 RID: 1448 RVA: 0x0000F6C2 File Offset: 0x0000D8C2
		public virtual void TimeAsVectorOn()
		{
			vtkDICOMGenerator.vtkDICOMGenerator_TimeAsVectorOn_43(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000354 RID: 852
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMGenerator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000355 RID: 853
		public new static readonly string MRClassNameKey = "class vtkDICOMGenerator";
	}
}
