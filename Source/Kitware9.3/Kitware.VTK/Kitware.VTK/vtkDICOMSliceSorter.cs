using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x0200002F RID: 47
	public class vtkDICOMSliceSorter : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060007D1 RID: 2001 RVA: 0x000125CA File Offset: 0x000107CA
		static vtkDICOMSliceSorter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMSliceSorter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMSliceSorter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060007D2 RID: 2002 RVA: 0x000125F2 File Offset: 0x000107F2
		public vtkDICOMSliceSorter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060007D3 RID: 2003
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSliceSorter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060007D4 RID: 2004 RVA: 0x00012600 File Offset: 0x00010800
		public new static vtkDICOMSliceSorter New()
		{
			vtkDICOMSliceSorter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSliceSorter.vtkDICOMSliceSorter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMSliceSorter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00012654 File Offset: 0x00010854
		public vtkDICOMSliceSorter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMSliceSorter.vtkDICOMSliceSorter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060007D6 RID: 2006 RVA: 0x00012698 File Offset: 0x00010898
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060007D7 RID: 2007
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSliceSorter_GetDesiredStackID_01(HandleRef pThis);

		// Token: 0x060007D8 RID: 2008 RVA: 0x000126A4 File Offset: 0x000108A4
		public string GetDesiredStackID()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMSliceSorter.vtkDICOMSliceSorter_GetDesiredStackID_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060007D9 RID: 2009
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMSliceSorter_GetDesiredTimeIndex_02(HandleRef pThis);

		// Token: 0x060007DA RID: 2010 RVA: 0x000126E0 File Offset: 0x000108E0
		public virtual int GetDesiredTimeIndex()
		{
			return vtkDICOMSliceSorter.vtkDICOMSliceSorter_GetDesiredTimeIndex_02(base.GetCppThis());
		}

		// Token: 0x060007DB RID: 2011
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSliceSorter_GetFileIndexArray_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060007DC RID: 2012 RVA: 0x00012700 File Offset: 0x00010900
		public vtkIntArray GetFileIndexArray()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSliceSorter.vtkDICOMSliceSorter_GetFileIndexArray_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060007DD RID: 2013
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSliceSorter_GetFrameIndexArray_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060007DE RID: 2014 RVA: 0x00012770 File Offset: 0x00010970
		public vtkIntArray GetFrameIndexArray()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSliceSorter.vtkDICOMSliceSorter_GetFrameIndexArray_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060007DF RID: 2015
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSliceSorter_GetMetaData_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060007E0 RID: 2016 RVA: 0x000127E0 File Offset: 0x000109E0
		public vtkDICOMMetaData GetMetaData()
		{
			vtkDICOMMetaData vtkDICOMMetaData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSliceSorter.vtkDICOMSliceSorter_GetMetaData_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060007E1 RID: 2017
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMSliceSorter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060007E2 RID: 2018 RVA: 0x00012850 File Offset: 0x00010A50
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMSliceSorter.vtkDICOMSliceSorter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060007E3 RID: 2019
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMSliceSorter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060007E4 RID: 2020 RVA: 0x00012870 File Offset: 0x00010A70
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMSliceSorter.vtkDICOMSliceSorter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060007E5 RID: 2021
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMSliceSorter_GetRepeatsAsTime_08(HandleRef pThis);

		// Token: 0x060007E6 RID: 2022 RVA: 0x0001288C File Offset: 0x00010A8C
		public virtual int GetRepeatsAsTime()
		{
			return vtkDICOMSliceSorter.vtkDICOMSliceSorter_GetRepeatsAsTime_08(base.GetCppThis());
		}

		// Token: 0x060007E7 RID: 2023
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMSliceSorter_GetReverseSlices_09(HandleRef pThis);

		// Token: 0x060007E8 RID: 2024 RVA: 0x000128AC File Offset: 0x00010AAC
		public virtual int GetReverseSlices()
		{
			return vtkDICOMSliceSorter.vtkDICOMSliceSorter_GetReverseSlices_09(base.GetCppThis());
		}

		// Token: 0x060007E9 RID: 2025
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDICOMSliceSorter_GetSliceSpacing_10(HandleRef pThis);

		// Token: 0x060007EA RID: 2026 RVA: 0x000128CC File Offset: 0x00010ACC
		public double GetSliceSpacing()
		{
			return vtkDICOMSliceSorter.vtkDICOMSliceSorter_GetSliceSpacing_10(base.GetCppThis());
		}

		// Token: 0x060007EB RID: 2027
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSliceSorter_GetStackIDs_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060007EC RID: 2028 RVA: 0x000128EC File Offset: 0x00010AEC
		public vtkStringArray GetStackIDs()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSliceSorter.vtkDICOMSliceSorter_GetStackIDs_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060007ED RID: 2029
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMSliceSorter_GetTimeAsVector_12(HandleRef pThis);

		// Token: 0x060007EE RID: 2030 RVA: 0x0001295C File Offset: 0x00010B5C
		public virtual int GetTimeAsVector()
		{
			return vtkDICOMSliceSorter.vtkDICOMSliceSorter_GetTimeAsVector_12(base.GetCppThis());
		}

		// Token: 0x060007EF RID: 2031
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMSliceSorter_GetTimeDimension_13(HandleRef pThis);

		// Token: 0x060007F0 RID: 2032 RVA: 0x0001297C File Offset: 0x00010B7C
		public int GetTimeDimension()
		{
			return vtkDICOMSliceSorter.vtkDICOMSliceSorter_GetTimeDimension_13(base.GetCppThis());
		}

		// Token: 0x060007F1 RID: 2033
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSliceSorter_GetTimeSequence_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060007F2 RID: 2034 RVA: 0x0001299C File Offset: 0x00010B9C
		public vtkDICOMTag GetTimeSequence()
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSliceSorter.vtkDICOMSliceSorter_GetTimeSequence_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060007F3 RID: 2035
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDICOMSliceSorter_GetTimeSpacing_15(HandleRef pThis);

		// Token: 0x060007F4 RID: 2036 RVA: 0x000129F8 File Offset: 0x00010BF8
		public double GetTimeSpacing()
		{
			return vtkDICOMSliceSorter.vtkDICOMSliceSorter_GetTimeSpacing_15(base.GetCppThis());
		}

		// Token: 0x060007F5 RID: 2037
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSliceSorter_GetTimeTag_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060007F6 RID: 2038 RVA: 0x00012A18 File Offset: 0x00010C18
		public vtkDICOMTag GetTimeTag()
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSliceSorter.vtkDICOMSliceSorter_GetTimeTag_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060007F7 RID: 2039
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMSliceSorter_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060007F8 RID: 2040 RVA: 0x00012A74 File Offset: 0x00010C74
		public override int IsA(string type)
		{
			return vtkDICOMSliceSorter.vtkDICOMSliceSorter_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x060007F9 RID: 2041
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMSliceSorter_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060007FA RID: 2042 RVA: 0x00012A94 File Offset: 0x00010C94
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMSliceSorter.vtkDICOMSliceSorter_IsTypeOf_18(type);
		}

		// Token: 0x060007FB RID: 2043
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSliceSorter_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060007FC RID: 2044 RVA: 0x00012AB0 File Offset: 0x00010CB0
		public new vtkDICOMSliceSorter NewInstance()
		{
			vtkDICOMSliceSorter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSliceSorter.vtkDICOMSliceSorter_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMSliceSorter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060007FD RID: 2045
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSliceSorter_RepeatsAsTimeOff_21(HandleRef pThis);

		// Token: 0x060007FE RID: 2046 RVA: 0x00012B0A File Offset: 0x00010D0A
		public virtual void RepeatsAsTimeOff()
		{
			vtkDICOMSliceSorter.vtkDICOMSliceSorter_RepeatsAsTimeOff_21(base.GetCppThis());
		}

		// Token: 0x060007FF RID: 2047
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSliceSorter_RepeatsAsTimeOn_22(HandleRef pThis);

		// Token: 0x06000800 RID: 2048 RVA: 0x00012B19 File Offset: 0x00010D19
		public virtual void RepeatsAsTimeOn()
		{
			vtkDICOMSliceSorter.vtkDICOMSliceSorter_RepeatsAsTimeOn_22(base.GetCppThis());
		}

		// Token: 0x06000801 RID: 2049
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSliceSorter_ReverseSlicesOff_23(HandleRef pThis);

		// Token: 0x06000802 RID: 2050 RVA: 0x00012B28 File Offset: 0x00010D28
		public virtual void ReverseSlicesOff()
		{
			vtkDICOMSliceSorter.vtkDICOMSliceSorter_ReverseSlicesOff_23(base.GetCppThis());
		}

		// Token: 0x06000803 RID: 2051
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSliceSorter_ReverseSlicesOn_24(HandleRef pThis);

		// Token: 0x06000804 RID: 2052 RVA: 0x00012B37 File Offset: 0x00010D37
		public virtual void ReverseSlicesOn()
		{
			vtkDICOMSliceSorter.vtkDICOMSliceSorter_ReverseSlicesOn_24(base.GetCppThis());
		}

		// Token: 0x06000805 RID: 2053
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSliceSorter_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000806 RID: 2054 RVA: 0x00012B48 File Offset: 0x00010D48
		public new static vtkDICOMSliceSorter SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMSliceSorter vtkDICOMSliceSorter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSliceSorter.vtkDICOMSliceSorter_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMSliceSorter = (vtkDICOMSliceSorter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMSliceSorter.Register(null);
				}
			}
			return vtkDICOMSliceSorter;
		}

		// Token: 0x06000807 RID: 2055
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSliceSorter_SetDesiredStackID_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string stackId);

		// Token: 0x06000808 RID: 2056 RVA: 0x00012BC7 File Offset: 0x00010DC7
		public void SetDesiredStackID(string stackId)
		{
			vtkDICOMSliceSorter.vtkDICOMSliceSorter_SetDesiredStackID_26(base.GetCppThis(), stackId);
		}

		// Token: 0x06000809 RID: 2057
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSliceSorter_SetDesiredTimeIndex_27(HandleRef pThis, int _arg);

		// Token: 0x0600080A RID: 2058 RVA: 0x00012BD7 File Offset: 0x00010DD7
		public virtual void SetDesiredTimeIndex(int _arg)
		{
			vtkDICOMSliceSorter.vtkDICOMSliceSorter_SetDesiredTimeIndex_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600080B RID: 2059
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSliceSorter_SetMetaData_28(HandleRef pThis, HandleRef meta);

		// Token: 0x0600080C RID: 2060 RVA: 0x00012BE8 File Offset: 0x00010DE8
		public void SetMetaData(vtkDICOMMetaData meta)
		{
			vtkDICOMSliceSorter.vtkDICOMSliceSorter_SetMetaData_28(base.GetCppThis(), (meta == null) ? default(HandleRef) : meta.GetCppThis());
		}

		// Token: 0x0600080D RID: 2061
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSliceSorter_SetRepeatsAsTime_29(HandleRef pThis, int _arg);

		// Token: 0x0600080E RID: 2062 RVA: 0x00012C17 File Offset: 0x00010E17
		public virtual void SetRepeatsAsTime(int _arg)
		{
			vtkDICOMSliceSorter.vtkDICOMSliceSorter_SetRepeatsAsTime_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600080F RID: 2063
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSliceSorter_SetReverseSlices_30(HandleRef pThis, int _arg);

		// Token: 0x06000810 RID: 2064 RVA: 0x00012C27 File Offset: 0x00010E27
		public virtual void SetReverseSlices(int _arg)
		{
			vtkDICOMSliceSorter.vtkDICOMSliceSorter_SetReverseSlices_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06000811 RID: 2065
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSliceSorter_SetTimeAsVector_31(HandleRef pThis, int _arg);

		// Token: 0x06000812 RID: 2066 RVA: 0x00012C37 File Offset: 0x00010E37
		public virtual void SetTimeAsVector(int _arg)
		{
			vtkDICOMSliceSorter.vtkDICOMSliceSorter_SetTimeAsVector_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06000813 RID: 2067
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSliceSorter_SetTimeSequence_32(HandleRef pThis, HandleRef tag);

		// Token: 0x06000814 RID: 2068 RVA: 0x00012C48 File Offset: 0x00010E48
		public void SetTimeSequence(vtkDICOMTag tag)
		{
			vtkDICOMSliceSorter.vtkDICOMSliceSorter_SetTimeSequence_32(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis());
		}

		// Token: 0x06000815 RID: 2069
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSliceSorter_SetTimeTag_33(HandleRef pThis, HandleRef tag);

		// Token: 0x06000816 RID: 2070 RVA: 0x00012C78 File Offset: 0x00010E78
		public void SetTimeTag(vtkDICOMTag tag)
		{
			vtkDICOMSliceSorter.vtkDICOMSliceSorter_SetTimeTag_33(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis());
		}

		// Token: 0x06000817 RID: 2071
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSliceSorter_TimeAsVectorOff_34(HandleRef pThis);

		// Token: 0x06000818 RID: 2072 RVA: 0x00012CA7 File Offset: 0x00010EA7
		public virtual void TimeAsVectorOff()
		{
			vtkDICOMSliceSorter.vtkDICOMSliceSorter_TimeAsVectorOff_34(base.GetCppThis());
		}

		// Token: 0x06000819 RID: 2073
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSliceSorter_TimeAsVectorOn_35(HandleRef pThis);

		// Token: 0x0600081A RID: 2074 RVA: 0x00012CB6 File Offset: 0x00010EB6
		public virtual void TimeAsVectorOn()
		{
			vtkDICOMSliceSorter.vtkDICOMSliceSorter_TimeAsVectorOn_35(base.GetCppThis());
		}

		// Token: 0x0600081B RID: 2075
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSliceSorter_Update_36(HandleRef pThis);

		// Token: 0x0600081C RID: 2076 RVA: 0x00012CC5 File Offset: 0x00010EC5
		public void Update()
		{
			vtkDICOMSliceSorter.vtkDICOMSliceSorter_Update_36(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000388 RID: 904
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMSliceSorter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000389 RID: 905
		public new static readonly string MRClassNameKey = "class vtkDICOMSliceSorter";
	}
}
