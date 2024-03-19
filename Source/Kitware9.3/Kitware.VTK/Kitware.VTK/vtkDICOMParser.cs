using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000029 RID: 41
	public class vtkDICOMParser : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060005EC RID: 1516 RVA: 0x0000FE97 File Offset: 0x0000E097
		static vtkDICOMParser()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMParser.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMParser"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060005ED RID: 1517 RVA: 0x0000FEBF File Offset: 0x0000E0BF
		public vtkDICOMParser(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060005EE RID: 1518
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMParser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060005EF RID: 1519 RVA: 0x0000FED0 File Offset: 0x0000E0D0
		public new static vtkDICOMParser New()
		{
			vtkDICOMParser result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMParser.vtkDICOMParser_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0000FF24 File Offset: 0x0000E124
		public vtkDICOMParser() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMParser.vtkDICOMParser_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060005F1 RID: 1521 RVA: 0x0000FF68 File Offset: 0x0000E168
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060005F2 RID: 1522
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMParser_GetBufferSize_01(HandleRef pThis);

		// Token: 0x060005F3 RID: 1523 RVA: 0x0000FF74 File Offset: 0x0000E174
		public int GetBufferSize()
		{
			return vtkDICOMParser.vtkDICOMParser_GetBufferSize_01(base.GetCppThis());
		}

		// Token: 0x060005F4 RID: 1524
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDICOMCharacterSet vtkDICOMParser_GetDefaultCharacterSet_02(HandleRef pThis);

		// Token: 0x060005F5 RID: 1525 RVA: 0x0000FF94 File Offset: 0x0000E194
		public vtkDICOMCharacterSet GetDefaultCharacterSet()
		{
			return vtkDICOMParser.vtkDICOMParser_GetDefaultCharacterSet_02(base.GetCppThis());
		}

		// Token: 0x060005F6 RID: 1526
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDICOMParser_GetErrorCode_03(HandleRef pThis);

		// Token: 0x060005F7 RID: 1527 RVA: 0x0000FFB4 File Offset: 0x0000E1B4
		public uint GetErrorCode()
		{
			return vtkDICOMParser.vtkDICOMParser_GetErrorCode_03(base.GetCppThis());
		}

		// Token: 0x060005F8 RID: 1528
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMParser_GetFileName_04(HandleRef pThis);

		// Token: 0x060005F9 RID: 1529 RVA: 0x0000FFD4 File Offset: 0x0000E1D4
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMParser.vtkDICOMParser_GetFileName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060005FA RID: 1530
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMParser_GetFileOffset_05(HandleRef pThis);

		// Token: 0x060005FB RID: 1531 RVA: 0x00010010 File Offset: 0x0000E210
		public long GetFileOffset()
		{
			return vtkDICOMParser.vtkDICOMParser_GetFileOffset_05(base.GetCppThis());
		}

		// Token: 0x060005FC RID: 1532
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMParser_GetFileSize_06(HandleRef pThis);

		// Token: 0x060005FD RID: 1533 RVA: 0x00010030 File Offset: 0x0000E230
		public long GetFileSize()
		{
			return vtkDICOMParser.vtkDICOMParser_GetFileSize_06(base.GetCppThis());
		}

		// Token: 0x060005FE RID: 1534
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMParser_GetGroups_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060005FF RID: 1535 RVA: 0x00010050 File Offset: 0x0000E250
		public vtkUnsignedShortArray GetGroups()
		{
			vtkUnsignedShortArray vtkUnsignedShortArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMParser.vtkDICOMParser_GetGroups_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedShortArray = (vtkUnsignedShortArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedShortArray.Register(null);
				}
			}
			return vtkUnsignedShortArray;
		}

		// Token: 0x06000600 RID: 1536
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMParser_GetIndex_08(HandleRef pThis);

		// Token: 0x06000601 RID: 1537 RVA: 0x000100C0 File Offset: 0x0000E2C0
		public int GetIndex()
		{
			return vtkDICOMParser.vtkDICOMParser_GetIndex_08(base.GetCppThis());
		}

		// Token: 0x06000602 RID: 1538
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMParser_GetMetaData_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000603 RID: 1539 RVA: 0x000100E0 File Offset: 0x0000E2E0
		public vtkDICOMMetaData GetMetaData()
		{
			vtkDICOMMetaData vtkDICOMMetaData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMParser.vtkDICOMParser_GetMetaData_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000604 RID: 1540
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMParser_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000605 RID: 1541 RVA: 0x00010150 File Offset: 0x0000E350
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMParser.vtkDICOMParser_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06000606 RID: 1542
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMParser_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000607 RID: 1543 RVA: 0x00010170 File Offset: 0x0000E370
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMParser.vtkDICOMParser_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06000608 RID: 1544
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMParser_GetOverrideCharacterSet_12(HandleRef pThis);

		// Token: 0x06000609 RID: 1545 RVA: 0x0001018C File Offset: 0x0000E38C
		public bool GetOverrideCharacterSet()
		{
			return vtkDICOMParser.vtkDICOMParser_GetOverrideCharacterSet_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0600060A RID: 1546
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMParser_GetPixelDataFound_13(HandleRef pThis);

		// Token: 0x0600060B RID: 1547 RVA: 0x000101B4 File Offset: 0x0000E3B4
		public bool GetPixelDataFound()
		{
			return vtkDICOMParser.vtkDICOMParser_GetPixelDataFound_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0600060C RID: 1548
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDICOMParser_GetPixelDataVL_14(HandleRef pThis);

		// Token: 0x0600060D RID: 1549 RVA: 0x000101DC File Offset: 0x0000E3DC
		public uint GetPixelDataVL()
		{
			return vtkDICOMParser.vtkDICOMParser_GetPixelDataVL_14(base.GetCppThis());
		}

		// Token: 0x0600060E RID: 1550
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMParser_GetQuery_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600060F RID: 1551 RVA: 0x000101FC File Offset: 0x0000E3FC
		public vtkDICOMMetaData GetQuery()
		{
			vtkDICOMMetaData vtkDICOMMetaData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMParser.vtkDICOMParser_GetQuery_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000610 RID: 1552
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMParser_GetQueryMatched_16(HandleRef pThis);

		// Token: 0x06000611 RID: 1553 RVA: 0x0001026C File Offset: 0x0000E46C
		public bool GetQueryMatched()
		{
			return vtkDICOMParser.vtkDICOMParser_GetQueryMatched_16(base.GetCppThis()) != 0;
		}

		// Token: 0x06000612 RID: 1554
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMParser_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000613 RID: 1555 RVA: 0x00010294 File Offset: 0x0000E494
		public override int IsA(string type)
		{
			return vtkDICOMParser.vtkDICOMParser_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x06000614 RID: 1556
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMParser_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000615 RID: 1557 RVA: 0x000102B4 File Offset: 0x0000E4B4
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMParser.vtkDICOMParser_IsTypeOf_18(type);
		}

		// Token: 0x06000616 RID: 1558
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMParser_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000617 RID: 1559 RVA: 0x000102D0 File Offset: 0x0000E4D0
		public new vtkDICOMParser NewInstance()
		{
			vtkDICOMParser result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMParser.vtkDICOMParser_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000618 RID: 1560
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMParser_OverrideCharacterSetOff_21(HandleRef pThis);

		// Token: 0x06000619 RID: 1561 RVA: 0x0001032A File Offset: 0x0000E52A
		public void OverrideCharacterSetOff()
		{
			vtkDICOMParser.vtkDICOMParser_OverrideCharacterSetOff_21(base.GetCppThis());
		}

		// Token: 0x0600061A RID: 1562
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMParser_OverrideCharacterSetOn_22(HandleRef pThis);

		// Token: 0x0600061B RID: 1563 RVA: 0x00010339 File Offset: 0x0000E539
		public void OverrideCharacterSetOn()
		{
			vtkDICOMParser.vtkDICOMParser_OverrideCharacterSetOn_22(base.GetCppThis());
		}

		// Token: 0x0600061C RID: 1564
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMParser_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600061D RID: 1565 RVA: 0x00010348 File Offset: 0x0000E548
		public new static vtkDICOMParser SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMParser vtkDICOMParser = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMParser.vtkDICOMParser_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMParser = (vtkDICOMParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMParser.Register(null);
				}
			}
			return vtkDICOMParser;
		}

		// Token: 0x0600061E RID: 1566
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMParser_SetBufferSize_24(HandleRef pThis, int size);

		// Token: 0x0600061F RID: 1567 RVA: 0x000103C7 File Offset: 0x0000E5C7
		public void SetBufferSize(int size)
		{
			vtkDICOMParser.vtkDICOMParser_SetBufferSize_24(base.GetCppThis(), size);
		}

		// Token: 0x06000620 RID: 1568
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMParser_SetDefaultCharacterSet_25(HandleRef pThis, vtkDICOMCharacterSet cs);

		// Token: 0x06000621 RID: 1569 RVA: 0x000103D7 File Offset: 0x0000E5D7
		public void SetDefaultCharacterSet(vtkDICOMCharacterSet cs)
		{
			vtkDICOMParser.vtkDICOMParser_SetDefaultCharacterSet_25(base.GetCppThis(), cs);
		}

		// Token: 0x06000622 RID: 1570
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMParser_SetFileName_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		// Token: 0x06000623 RID: 1571 RVA: 0x000103E7 File Offset: 0x0000E5E7
		public virtual void SetFileName(string _arg)
		{
			vtkDICOMParser.vtkDICOMParser_SetFileName_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06000624 RID: 1572
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMParser_SetGroups_27(HandleRef pThis, HandleRef groups);

		// Token: 0x06000625 RID: 1573 RVA: 0x000103F8 File Offset: 0x0000E5F8
		public void SetGroups(vtkUnsignedShortArray groups)
		{
			vtkDICOMParser.vtkDICOMParser_SetGroups_27(base.GetCppThis(), (groups == null) ? default(HandleRef) : groups.GetCppThis());
		}

		// Token: 0x06000626 RID: 1574
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMParser_SetIndex_28(HandleRef pThis, int _arg);

		// Token: 0x06000627 RID: 1575 RVA: 0x00010427 File Offset: 0x0000E627
		public virtual void SetIndex(int _arg)
		{
			vtkDICOMParser.vtkDICOMParser_SetIndex_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06000628 RID: 1576
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMParser_SetMetaData_29(HandleRef pThis, HandleRef arg0);

		// Token: 0x06000629 RID: 1577 RVA: 0x00010438 File Offset: 0x0000E638
		public void SetMetaData(vtkDICOMMetaData arg0)
		{
			vtkDICOMParser.vtkDICOMParser_SetMetaData_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600062A RID: 1578
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMParser_SetOverrideCharacterSet_30(HandleRef pThis, byte b);

		// Token: 0x0600062B RID: 1579 RVA: 0x00010467 File Offset: 0x0000E667
		public void SetOverrideCharacterSet(bool b)
		{
			vtkDICOMParser.vtkDICOMParser_SetOverrideCharacterSet_30(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x0600062C RID: 1580
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMParser_SetQuery_31(HandleRef pThis, HandleRef query);

		// Token: 0x0600062D RID: 1581 RVA: 0x00010480 File Offset: 0x0000E680
		public void SetQuery(vtkDICOMMetaData query)
		{
			vtkDICOMParser.vtkDICOMParser_SetQuery_31(base.GetCppThis(), (query == null) ? default(HandleRef) : query.GetCppThis());
		}

		// Token: 0x0600062E RID: 1582
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMParser_SetQueryItem_32(HandleRef pThis, HandleRef query);

		// Token: 0x0600062F RID: 1583 RVA: 0x000104B0 File Offset: 0x0000E6B0
		public void SetQueryItem(vtkDICOMItem query)
		{
			vtkDICOMParser.vtkDICOMParser_SetQueryItem_32(base.GetCppThis(), (query == null) ? default(HandleRef) : query.GetCppThis());
		}

		// Token: 0x06000630 RID: 1584
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMParser_Update_33(HandleRef pThis);

		// Token: 0x06000631 RID: 1585 RVA: 0x000104DF File Offset: 0x0000E6DF
		public virtual void Update()
		{
			vtkDICOMParser.vtkDICOMParser_Update_33(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400037A RID: 890
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMParser";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400037B RID: 891
		public new static readonly string MRClassNameKey = "class vtkDICOMParser";
	}
}
