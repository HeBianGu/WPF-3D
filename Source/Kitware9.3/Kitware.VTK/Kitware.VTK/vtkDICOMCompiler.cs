using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x0200002A RID: 42
	public class vtkDICOMCompiler : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000632 RID: 1586 RVA: 0x000104EE File Offset: 0x0000E6EE
		static vtkDICOMCompiler()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMCompiler.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMCompiler"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000633 RID: 1587 RVA: 0x00010516 File Offset: 0x0000E716
		public vtkDICOMCompiler(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000634 RID: 1588
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCompiler_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000635 RID: 1589 RVA: 0x00010524 File Offset: 0x0000E724
		public new static vtkDICOMCompiler New()
		{
			vtkDICOMCompiler result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMCompiler.vtkDICOMCompiler_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMCompiler)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00010578 File Offset: 0x0000E778
		public vtkDICOMCompiler() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMCompiler.vtkDICOMCompiler_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000637 RID: 1591 RVA: 0x000105BC File Offset: 0x0000E7BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000638 RID: 1592
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_Close_01(HandleRef pThis);

		// Token: 0x06000639 RID: 1593 RVA: 0x000105C7 File Offset: 0x0000E7C7
		public virtual void Close()
		{
			vtkDICOMCompiler.vtkDICOMCompiler_Close_01(base.GetCppThis());
		}

		// Token: 0x0600063A RID: 1594
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_CloseAndRemove_02(HandleRef pThis);

		// Token: 0x0600063B RID: 1595 RVA: 0x000105D6 File Offset: 0x0000E7D6
		public virtual void CloseAndRemove()
		{
			vtkDICOMCompiler.vtkDICOMCompiler_CloseAndRemove_02(base.GetCppThis());
		}

		// Token: 0x0600063C RID: 1596
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_GenerateSeriesUIDs_03(HandleRef pThis);

		// Token: 0x0600063D RID: 1597 RVA: 0x000105E5 File Offset: 0x0000E7E5
		public void GenerateSeriesUIDs()
		{
			vtkDICOMCompiler.vtkDICOMCompiler_GenerateSeriesUIDs_03(base.GetCppThis());
		}

		// Token: 0x0600063E RID: 1598
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMCompiler_GetBufferSize_04(HandleRef pThis);

		// Token: 0x0600063F RID: 1599 RVA: 0x000105F4 File Offset: 0x0000E7F4
		public int GetBufferSize()
		{
			return vtkDICOMCompiler.vtkDICOMCompiler_GetBufferSize_04(base.GetCppThis());
		}

		// Token: 0x06000640 RID: 1600
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDICOMCompiler_GetErrorCode_05(HandleRef pThis);

		// Token: 0x06000641 RID: 1601 RVA: 0x00010614 File Offset: 0x0000E814
		public uint GetErrorCode()
		{
			return vtkDICOMCompiler.vtkDICOMCompiler_GetErrorCode_05(base.GetCppThis());
		}

		// Token: 0x06000642 RID: 1602
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCompiler_GetFileName_06(HandleRef pThis);

		// Token: 0x06000643 RID: 1603 RVA: 0x00010634 File Offset: 0x0000E834
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMCompiler.vtkDICOMCompiler_GetFileName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000644 RID: 1604
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCompiler_GetImplementationClassUID_07(HandleRef pThis);

		// Token: 0x06000645 RID: 1605 RVA: 0x00010670 File Offset: 0x0000E870
		public virtual string GetImplementationClassUID()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMCompiler.vtkDICOMCompiler_GetImplementationClassUID_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000646 RID: 1606
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCompiler_GetImplementationVersionName_08(HandleRef pThis);

		// Token: 0x06000647 RID: 1607 RVA: 0x000106AC File Offset: 0x0000E8AC
		public virtual string GetImplementationVersionName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMCompiler.vtkDICOMCompiler_GetImplementationVersionName_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000648 RID: 1608
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMCompiler_GetIndex_09(HandleRef pThis);

		// Token: 0x06000649 RID: 1609 RVA: 0x000106E8 File Offset: 0x0000E8E8
		public int GetIndex()
		{
			return vtkDICOMCompiler.vtkDICOMCompiler_GetIndex_09(base.GetCppThis());
		}

		// Token: 0x0600064A RID: 1610
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMCompiler_GetKeepOriginalPixelDataVR_10(HandleRef pThis);

		// Token: 0x0600064B RID: 1611 RVA: 0x00010708 File Offset: 0x0000E908
		public virtual bool GetKeepOriginalPixelDataVR()
		{
			return vtkDICOMCompiler.vtkDICOMCompiler_GetKeepOriginalPixelDataVR_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0600064C RID: 1612
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCompiler_GetMetaData_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600064D RID: 1613 RVA: 0x00010730 File Offset: 0x0000E930
		public vtkDICOMMetaData GetMetaData()
		{
			vtkDICOMMetaData vtkDICOMMetaData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMCompiler.vtkDICOMCompiler_GetMetaData_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600064E RID: 1614
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMCompiler_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0600064F RID: 1615 RVA: 0x000107A0 File Offset: 0x0000E9A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMCompiler.vtkDICOMCompiler_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06000650 RID: 1616
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMCompiler_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000651 RID: 1617 RVA: 0x000107C0 File Offset: 0x0000E9C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMCompiler.vtkDICOMCompiler_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06000652 RID: 1618
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCompiler_GetSOPInstanceUID_14(HandleRef pThis);

		// Token: 0x06000653 RID: 1619 RVA: 0x000107DC File Offset: 0x0000E9DC
		public virtual string GetSOPInstanceUID()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMCompiler.vtkDICOMCompiler_GetSOPInstanceUID_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000654 RID: 1620
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCompiler_GetSeriesInstanceUID_15(HandleRef pThis);

		// Token: 0x06000655 RID: 1621 RVA: 0x00010818 File Offset: 0x0000EA18
		public virtual string GetSeriesInstanceUID()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMCompiler.vtkDICOMCompiler_GetSeriesInstanceUID_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000656 RID: 1622
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCompiler_GetSourceApplicationEntityTitle_16(HandleRef pThis);

		// Token: 0x06000657 RID: 1623 RVA: 0x00010854 File Offset: 0x0000EA54
		public virtual string GetSourceApplicationEntityTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMCompiler.vtkDICOMCompiler_GetSourceApplicationEntityTitle_16(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000658 RID: 1624
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCompiler_GetStudyInstanceUID_17(HandleRef pThis);

		// Token: 0x06000659 RID: 1625 RVA: 0x00010890 File Offset: 0x0000EA90
		public virtual string GetStudyInstanceUID()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMCompiler.vtkDICOMCompiler_GetStudyInstanceUID_17(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600065A RID: 1626
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCompiler_GetTransferSyntaxUID_18(HandleRef pThis);

		// Token: 0x0600065B RID: 1627 RVA: 0x000108CC File Offset: 0x0000EACC
		public virtual string GetTransferSyntaxUID()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMCompiler.vtkDICOMCompiler_GetTransferSyntaxUID_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600065C RID: 1628
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMCompiler_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0600065D RID: 1629 RVA: 0x00010908 File Offset: 0x0000EB08
		public override int IsA(string type)
		{
			return vtkDICOMCompiler.vtkDICOMCompiler_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x0600065E RID: 1630
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMCompiler_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0600065F RID: 1631 RVA: 0x00010928 File Offset: 0x0000EB28
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMCompiler.vtkDICOMCompiler_IsTypeOf_20(type);
		}

		// Token: 0x06000660 RID: 1632
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_KeepOriginalPixelDataVROff_21(HandleRef pThis);

		// Token: 0x06000661 RID: 1633 RVA: 0x00010942 File Offset: 0x0000EB42
		public virtual void KeepOriginalPixelDataVROff()
		{
			vtkDICOMCompiler.vtkDICOMCompiler_KeepOriginalPixelDataVROff_21(base.GetCppThis());
		}

		// Token: 0x06000662 RID: 1634
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_KeepOriginalPixelDataVROn_22(HandleRef pThis);

		// Token: 0x06000663 RID: 1635 RVA: 0x00010951 File Offset: 0x0000EB51
		public virtual void KeepOriginalPixelDataVROn()
		{
			vtkDICOMCompiler.vtkDICOMCompiler_KeepOriginalPixelDataVROn_22(base.GetCppThis());
		}

		// Token: 0x06000664 RID: 1636
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCompiler_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000665 RID: 1637 RVA: 0x00010960 File Offset: 0x0000EB60
		public new vtkDICOMCompiler NewInstance()
		{
			vtkDICOMCompiler result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMCompiler.vtkDICOMCompiler_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMCompiler)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000666 RID: 1638
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCompiler_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000667 RID: 1639 RVA: 0x000109BC File Offset: 0x0000EBBC
		public new static vtkDICOMCompiler SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMCompiler vtkDICOMCompiler = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMCompiler.vtkDICOMCompiler_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMCompiler = (vtkDICOMCompiler)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMCompiler.Register(null);
				}
			}
			return vtkDICOMCompiler;
		}

		// Token: 0x06000668 RID: 1640
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_SetBufferSize_26(HandleRef pThis, int size);

		// Token: 0x06000669 RID: 1641 RVA: 0x00010A3B File Offset: 0x0000EC3B
		public void SetBufferSize(int size)
		{
			vtkDICOMCompiler.vtkDICOMCompiler_SetBufferSize_26(base.GetCppThis(), size);
		}

		// Token: 0x0600066A RID: 1642
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_SetFileName_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		// Token: 0x0600066B RID: 1643 RVA: 0x00010A4B File Offset: 0x0000EC4B
		public virtual void SetFileName(string _arg)
		{
			vtkDICOMCompiler.vtkDICOMCompiler_SetFileName_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600066C RID: 1644
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_SetImplementationClassUID_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		// Token: 0x0600066D RID: 1645 RVA: 0x00010A5B File Offset: 0x0000EC5B
		public virtual void SetImplementationClassUID(string _arg)
		{
			vtkDICOMCompiler.vtkDICOMCompiler_SetImplementationClassUID_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600066E RID: 1646
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_SetImplementationVersionName_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		// Token: 0x0600066F RID: 1647 RVA: 0x00010A6B File Offset: 0x0000EC6B
		public virtual void SetImplementationVersionName(string _arg)
		{
			vtkDICOMCompiler.vtkDICOMCompiler_SetImplementationVersionName_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06000670 RID: 1648
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_SetIndex_30(HandleRef pThis, int _arg);

		// Token: 0x06000671 RID: 1649 RVA: 0x00010A7B File Offset: 0x0000EC7B
		public virtual void SetIndex(int _arg)
		{
			vtkDICOMCompiler.vtkDICOMCompiler_SetIndex_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06000672 RID: 1650
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_SetKeepOriginalPixelDataVR_31(HandleRef pThis, byte _arg);

		// Token: 0x06000673 RID: 1651 RVA: 0x00010A8B File Offset: 0x0000EC8B
		public virtual void SetKeepOriginalPixelDataVR(bool _arg)
		{
			vtkDICOMCompiler.vtkDICOMCompiler_SetKeepOriginalPixelDataVR_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06000674 RID: 1652
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_SetMetaData_32(HandleRef pThis, HandleRef arg0);

		// Token: 0x06000675 RID: 1653 RVA: 0x00010AA4 File Offset: 0x0000ECA4
		public void SetMetaData(vtkDICOMMetaData arg0)
		{
			vtkDICOMCompiler.vtkDICOMCompiler_SetMetaData_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000676 RID: 1654
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_SetSOPInstanceUID_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		// Token: 0x06000677 RID: 1655 RVA: 0x00010AD3 File Offset: 0x0000ECD3
		public virtual void SetSOPInstanceUID(string _arg)
		{
			vtkDICOMCompiler.vtkDICOMCompiler_SetSOPInstanceUID_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06000678 RID: 1656
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_SetSeriesInstanceUID_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		// Token: 0x06000679 RID: 1657 RVA: 0x00010AE3 File Offset: 0x0000ECE3
		public virtual void SetSeriesInstanceUID(string _arg)
		{
			vtkDICOMCompiler.vtkDICOMCompiler_SetSeriesInstanceUID_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600067A RID: 1658
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_SetSourceApplicationEntityTitle_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		// Token: 0x0600067B RID: 1659 RVA: 0x00010AF3 File Offset: 0x0000ECF3
		public virtual void SetSourceApplicationEntityTitle(string _arg)
		{
			vtkDICOMCompiler.vtkDICOMCompiler_SetSourceApplicationEntityTitle_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600067C RID: 1660
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_SetStudyInstanceUID_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		// Token: 0x0600067D RID: 1661 RVA: 0x00010B03 File Offset: 0x0000ED03
		public virtual void SetStudyInstanceUID(string _arg)
		{
			vtkDICOMCompiler.vtkDICOMCompiler_SetStudyInstanceUID_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600067E RID: 1662
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_SetTransferSyntaxUID_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		// Token: 0x0600067F RID: 1663 RVA: 0x00010B13 File Offset: 0x0000ED13
		public virtual void SetTransferSyntaxUID(string _arg)
		{
			vtkDICOMCompiler.vtkDICOMCompiler_SetTransferSyntaxUID_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06000680 RID: 1664
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_WriteFrame_38(HandleRef pThis, IntPtr cp, long size);

		// Token: 0x06000681 RID: 1665 RVA: 0x00010B23 File Offset: 0x0000ED23
		public virtual void WriteFrame(IntPtr cp, long size)
		{
			vtkDICOMCompiler.vtkDICOMCompiler_WriteFrame_38(base.GetCppThis(), cp, size);
		}

		// Token: 0x06000682 RID: 1666
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_WriteHeader_39(HandleRef pThis);

		// Token: 0x06000683 RID: 1667 RVA: 0x00010B34 File Offset: 0x0000ED34
		public virtual void WriteHeader()
		{
			vtkDICOMCompiler.vtkDICOMCompiler_WriteHeader_39(base.GetCppThis());
		}

		// Token: 0x06000684 RID: 1668
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCompiler_WritePixelData_40(HandleRef pThis, IntPtr cp, long size);

		// Token: 0x06000685 RID: 1669 RVA: 0x00010B43 File Offset: 0x0000ED43
		public virtual void WritePixelData(IntPtr cp, long size)
		{
			vtkDICOMCompiler.vtkDICOMCompiler_WritePixelData_40(base.GetCppThis(), cp, size);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400037C RID: 892
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMCompiler";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400037D RID: 893
		public new static readonly string MRClassNameKey = "class vtkDICOMCompiler";
	}
}
