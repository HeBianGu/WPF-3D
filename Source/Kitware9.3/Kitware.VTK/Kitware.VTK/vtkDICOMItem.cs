using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000031 RID: 49
	public class vtkDICOMItem : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000836 RID: 2102 RVA: 0x00013028 File Offset: 0x00011228
		static vtkDICOMItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000837 RID: 2103 RVA: 0x00013050 File Offset: 0x00011250
		public vtkDICOMItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000838 RID: 2104 RVA: 0x0001305E File Offset: 0x0001125E
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000839 RID: 2105
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMItem_Begin_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600083A RID: 2106 RVA: 0x0001306C File Offset: 0x0001126C
		public vtkDICOMDataElementIterator Begin()
		{
			vtkDICOMDataElementIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMItem.vtkDICOMItem_Begin_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMDataElementIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600083B RID: 2107
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMItem_Clear_02(HandleRef pThis);

		// Token: 0x0600083C RID: 2108 RVA: 0x000130C6 File Offset: 0x000112C6
		public void Clear()
		{
			vtkDICOMItem.vtkDICOMItem_Clear_02(base.GetCppThis());
		}

		// Token: 0x0600083D RID: 2109
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMItem_End_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600083E RID: 2110 RVA: 0x000130D8 File Offset: 0x000112D8
		public vtkDICOMDataElementIterator End()
		{
			vtkDICOMDataElementIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMItem.vtkDICOMItem_End_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMDataElementIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600083F RID: 2111
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMItem_FindDictEntry_04(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000840 RID: 2112 RVA: 0x00013134 File Offset: 0x00011334
		public vtkDICOMDictEntry FindDictEntry(vtkDICOMTag tag)
		{
			vtkDICOMDictEntry result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMItem.vtkDICOMItem_FindDictEntry_04(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMDictEntry)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000841 RID: 2113
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDICOMVR vtkDICOMItem_FindDictVR_05(HandleRef pThis, HandleRef tag);

		// Token: 0x06000842 RID: 2114 RVA: 0x000131A4 File Offset: 0x000113A4
		public vtkDICOMVR FindDictVR(vtkDICOMTag tag)
		{
			return vtkDICOMItem.vtkDICOMItem_FindDictVR_05(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis());
		}

		// Token: 0x06000843 RID: 2115
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMItem_Get_06(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000844 RID: 2116 RVA: 0x000131D8 File Offset: 0x000113D8
		public vtkDICOMValue Get(vtkDICOMTag tag)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMItem.vtkDICOMItem_Get_06(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000845 RID: 2117
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMItem_Get_07(HandleRef pThis, vtkDICOMTagPath tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000846 RID: 2118 RVA: 0x00013248 File Offset: 0x00011448
		public vtkDICOMValue Get(vtkDICOMTagPath tag)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMItem.vtkDICOMItem_Get_07(base.GetCppThis(), tag, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000847 RID: 2119
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMItem_GetAttributeValue_08(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000848 RID: 2120 RVA: 0x000132A4 File Offset: 0x000114A4
		public vtkDICOMValue GetAttributeValue(vtkDICOMTag tag)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMItem.vtkDICOMItem_GetAttributeValue_08(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000849 RID: 2121
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMItem_GetAttributeValue_09(HandleRef pThis, vtkDICOMTagPath tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600084A RID: 2122 RVA: 0x00013314 File Offset: 0x00011514
		public vtkDICOMValue GetAttributeValue(vtkDICOMTagPath tag)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMItem.vtkDICOMItem_GetAttributeValue_09(base.GetCppThis(), tag, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600084B RID: 2123
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDICOMItem_GetByteOffset_10(HandleRef pThis);

		// Token: 0x0600084C RID: 2124 RVA: 0x00013370 File Offset: 0x00011570
		public uint GetByteOffset()
		{
			return vtkDICOMItem.vtkDICOMItem_GetByteOffset_10(base.GetCppThis());
		}

		// Token: 0x0600084D RID: 2125
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMItem_GetNumberOfDataElements_11(HandleRef pThis);

		// Token: 0x0600084E RID: 2126 RVA: 0x00013390 File Offset: 0x00011590
		public int GetNumberOfDataElements()
		{
			return vtkDICOMItem.vtkDICOMItem_GetNumberOfDataElements_11(base.GetCppThis());
		}

		// Token: 0x0600084F RID: 2127
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMItem_IsDelimited_12(HandleRef pThis);

		// Token: 0x06000850 RID: 2128 RVA: 0x000133B0 File Offset: 0x000115B0
		public bool IsDelimited()
		{
			return vtkDICOMItem.vtkDICOMItem_IsDelimited_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06000851 RID: 2129
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMItem_IsEmpty_13(HandleRef pThis);

		// Token: 0x06000852 RID: 2130 RVA: 0x000133D8 File Offset: 0x000115D8
		public bool IsEmpty()
		{
			return vtkDICOMItem.vtkDICOMItem_IsEmpty_13(base.GetCppThis()) != 0;
		}

		// Token: 0x06000853 RID: 2131
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMItem_ResolvePrivateTag_14(HandleRef pThis, HandleRef ptag, [MarshalAs(UnmanagedType.LPUTF8Str)] string creator, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000854 RID: 2132 RVA: 0x00013400 File Offset: 0x00011600
		public vtkDICOMTag ResolvePrivateTag(vtkDICOMTag ptag, string creator)
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMItem.vtkDICOMItem_ResolvePrivateTag_14(base.GetCppThis(), (ptag == null) ? default(HandleRef) : ptag.GetCppThis(), creator, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000855 RID: 2133
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMItem_ResolvePrivateTagForWriting_15(HandleRef pThis, HandleRef ptag, [MarshalAs(UnmanagedType.LPUTF8Str)] string creator, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000856 RID: 2134 RVA: 0x00013474 File Offset: 0x00011674
		public vtkDICOMTag ResolvePrivateTagForWriting(vtkDICOMTag ptag, string creator)
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMItem.vtkDICOMItem_ResolvePrivateTagForWriting_15(base.GetCppThis(), (ptag == null) ? default(HandleRef) : ptag.GetCppThis(), creator, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000857 RID: 2135
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMItem_Set_16(HandleRef pThis, HandleRef tag, HandleRef v);

		// Token: 0x06000858 RID: 2136 RVA: 0x000134E8 File Offset: 0x000116E8
		public void Set(vtkDICOMTag tag, vtkDICOMValue v)
		{
			vtkDICOMItem.vtkDICOMItem_Set_16(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x06000859 RID: 2137
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMItem_Set_17(HandleRef pThis, HandleRef tag, double v);

		// Token: 0x0600085A RID: 2138 RVA: 0x0001352C File Offset: 0x0001172C
		public void Set(vtkDICOMTag tag, double v)
		{
			vtkDICOMItem.vtkDICOMItem_Set_17(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), v);
		}

		// Token: 0x0600085B RID: 2139
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMItem_Set_18(HandleRef pThis, HandleRef tag, [MarshalAs(UnmanagedType.LPUTF8Str)] string v);

		// Token: 0x0600085C RID: 2140 RVA: 0x0001355C File Offset: 0x0001175C
		public void Set(vtkDICOMTag tag, string v)
		{
			vtkDICOMItem.vtkDICOMItem_Set_18(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), v);
		}

		// Token: 0x0600085D RID: 2141
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMItem_Set_19(HandleRef pThis, vtkDICOMTagPath tag, HandleRef v);

		// Token: 0x0600085E RID: 2142 RVA: 0x0001358C File Offset: 0x0001178C
		public void Set(vtkDICOMTagPath tag, vtkDICOMValue v)
		{
			vtkDICOMItem.vtkDICOMItem_Set_19(base.GetCppThis(), tag, (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x0600085F RID: 2143
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMItem_Set_20(HandleRef pThis, vtkDICOMTagPath tag, double v);

		// Token: 0x06000860 RID: 2144 RVA: 0x000135BC File Offset: 0x000117BC
		public void Set(vtkDICOMTagPath tag, double v)
		{
			vtkDICOMItem.vtkDICOMItem_Set_20(base.GetCppThis(), tag, v);
		}

		// Token: 0x06000861 RID: 2145
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMItem_Set_21(HandleRef pThis, vtkDICOMTagPath tag, [MarshalAs(UnmanagedType.LPUTF8Str)] string v);

		// Token: 0x06000862 RID: 2146 RVA: 0x000135CD File Offset: 0x000117CD
		public void Set(vtkDICOMTagPath tag, string v)
		{
			vtkDICOMItem.vtkDICOMItem_Set_21(base.GetCppThis(), tag, v);
		}

		// Token: 0x06000863 RID: 2147
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMItem_SetAttributeValue_22(HandleRef pThis, HandleRef tag, HandleRef v);

		// Token: 0x06000864 RID: 2148 RVA: 0x000135E0 File Offset: 0x000117E0
		public void SetAttributeValue(vtkDICOMTag tag, vtkDICOMValue v)
		{
			vtkDICOMItem.vtkDICOMItem_SetAttributeValue_22(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x06000865 RID: 2149
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMItem_SetAttributeValue_23(HandleRef pThis, HandleRef tag, double v);

		// Token: 0x06000866 RID: 2150 RVA: 0x00013624 File Offset: 0x00011824
		public void SetAttributeValue(vtkDICOMTag tag, double v)
		{
			vtkDICOMItem.vtkDICOMItem_SetAttributeValue_23(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), v);
		}

		// Token: 0x06000867 RID: 2151
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMItem_SetAttributeValue_24(HandleRef pThis, HandleRef tag, [MarshalAs(UnmanagedType.LPUTF8Str)] string v);

		// Token: 0x06000868 RID: 2152 RVA: 0x00013654 File Offset: 0x00011854
		public void SetAttributeValue(vtkDICOMTag tag, string v)
		{
			vtkDICOMItem.vtkDICOMItem_SetAttributeValue_24(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), v);
		}

		// Token: 0x06000869 RID: 2153
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMItem_SetAttributeValue_25(HandleRef pThis, vtkDICOMTagPath tag, HandleRef v);

		// Token: 0x0600086A RID: 2154 RVA: 0x00013684 File Offset: 0x00011884
		public void SetAttributeValue(vtkDICOMTagPath tag, vtkDICOMValue v)
		{
			vtkDICOMItem.vtkDICOMItem_SetAttributeValue_25(base.GetCppThis(), tag, (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x0600086B RID: 2155
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMItem_SetAttributeValue_26(HandleRef pThis, vtkDICOMTagPath tag, double v);

		// Token: 0x0600086C RID: 2156 RVA: 0x000136B4 File Offset: 0x000118B4
		public void SetAttributeValue(vtkDICOMTagPath tag, double v)
		{
			vtkDICOMItem.vtkDICOMItem_SetAttributeValue_26(base.GetCppThis(), tag, v);
		}

		// Token: 0x0600086D RID: 2157
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMItem_SetAttributeValue_27(HandleRef pThis, vtkDICOMTagPath tag, [MarshalAs(UnmanagedType.LPUTF8Str)] string v);

		// Token: 0x0600086E RID: 2158 RVA: 0x000136C5 File Offset: 0x000118C5
		public void SetAttributeValue(vtkDICOMTagPath tag, string v)
		{
			vtkDICOMItem.vtkDICOMItem_SetAttributeValue_27(base.GetCppThis(), tag, v);
		}

		// Token: 0x0600086F RID: 2159
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000870 RID: 2160 RVA: 0x000136D8 File Offset: 0x000118D8
		public vtkDICOMItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMItem.vtkDICOMItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400038C RID: 908
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400038D RID: 909
		public new static readonly string MRClassNameKey = "class vtkDICOMItem";
	}
}
