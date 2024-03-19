using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x0200000A RID: 10
	public class vtkDICOMMetaData : vtkDataObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600022E RID: 558 RVA: 0x0000A0A5 File Offset: 0x000082A5
		static vtkDICOMMetaData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMMetaData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMMetaData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600022F RID: 559 RVA: 0x0000A0CD File Offset: 0x000082CD
		public vtkDICOMMetaData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000230 RID: 560
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000231 RID: 561 RVA: 0x0000A0DC File Offset: 0x000082DC
		public new static vtkDICOMMetaData New()
		{
			vtkDICOMMetaData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMMetaData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000A130 File Offset: 0x00008330
		public vtkDICOMMetaData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMMetaData.vtkDICOMMetaData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000233 RID: 563 RVA: 0x0000A174 File Offset: 0x00008374
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000234 RID: 564
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_Begin_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000235 RID: 565 RVA: 0x0000A180 File Offset: 0x00008380
		public vtkDICOMDataElementIterator Begin()
		{
			vtkDICOMDataElementIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_Begin_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMDataElementIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000236 RID: 566
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_Clear_02(HandleRef pThis);

		// Token: 0x06000237 RID: 567 RVA: 0x0000A1DA File Offset: 0x000083DA
		public void Clear()
		{
			vtkDICOMMetaData.vtkDICOMMetaData_Clear_02(base.GetCppThis());
		}

		// Token: 0x06000238 RID: 568
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_CopyAttributes_03(HandleRef pThis, HandleRef source);

		// Token: 0x06000239 RID: 569 RVA: 0x0000A1EC File Offset: 0x000083EC
		public void CopyAttributes(vtkDICOMMetaData source)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_CopyAttributes_03(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0600023A RID: 570
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_DeepCopy_04(HandleRef pThis, HandleRef source);

		// Token: 0x0600023B RID: 571 RVA: 0x0000A21C File Offset: 0x0000841C
		public override void DeepCopy(vtkDataObject source)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_DeepCopy_04(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0600023C RID: 572
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_End_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600023D RID: 573 RVA: 0x0000A24C File Offset: 0x0000844C
		public vtkDICOMDataElementIterator End()
		{
			vtkDICOMDataElementIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_End_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMDataElementIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600023E RID: 574
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_Erase_06(HandleRef pThis, HandleRef tag);

		// Token: 0x0600023F RID: 575 RVA: 0x0000A2A8 File Offset: 0x000084A8
		public void Erase(vtkDICOMTag tag)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_Erase_06(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis());
		}

		// Token: 0x06000240 RID: 576
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_Find_07(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000241 RID: 577 RVA: 0x0000A2D8 File Offset: 0x000084D8
		public vtkDICOMDataElementIterator Find(vtkDICOMTag tag)
		{
			vtkDICOMDataElementIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_Find_07(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMDataElementIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000242 RID: 578
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_FindDictEntry_08(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000243 RID: 579 RVA: 0x0000A348 File Offset: 0x00008548
		public vtkDICOMDictEntry FindDictEntry(vtkDICOMTag tag)
		{
			vtkDICOMDictEntry result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_FindDictEntry_08(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMDictEntry)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000244 RID: 580
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDICOMVR vtkDICOMMetaData_FindDictVR_09(HandleRef pThis, int idx, HandleRef tag);

		// Token: 0x06000245 RID: 581 RVA: 0x0000A3B8 File Offset: 0x000085B8
		public vtkDICOMVR FindDictVR(int idx, vtkDICOMTag tag)
		{
			return vtkDICOMMetaData.vtkDICOMMetaData_FindDictVR_09(base.GetCppThis(), idx, (tag == null) ? default(HandleRef) : tag.GetCppThis());
		}

		// Token: 0x06000246 RID: 582
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_Get_10(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000247 RID: 583 RVA: 0x0000A3F0 File Offset: 0x000085F0
		public vtkDICOMValue Get(vtkDICOMTag tag)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_Get_10(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000248 RID: 584
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_Get_11(HandleRef pThis, vtkDICOMTagPath p, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000249 RID: 585 RVA: 0x0000A460 File Offset: 0x00008660
		public vtkDICOMValue Get(vtkDICOMTagPath p)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_Get_11(base.GetCppThis(), p, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600024A RID: 586
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_Get_12(HandleRef pThis, int idx, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600024B RID: 587 RVA: 0x0000A4BC File Offset: 0x000086BC
		public vtkDICOMValue Get(int idx, vtkDICOMTag tag)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_Get_12(base.GetCppThis(), idx, (tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600024C RID: 588
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_Get_13(HandleRef pThis, int idx, vtkDICOMTagPath p, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600024D RID: 589 RVA: 0x0000A530 File Offset: 0x00008730
		public vtkDICOMValue Get(int idx, vtkDICOMTagPath p)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_Get_13(base.GetCppThis(), idx, p, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600024E RID: 590
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_Get_14(HandleRef pThis, int idx, int frame, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600024F RID: 591 RVA: 0x0000A58C File Offset: 0x0000878C
		public vtkDICOMValue Get(int idx, int frame, vtkDICOMTag tag)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_Get_14(base.GetCppThis(), idx, frame, (tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000250 RID: 592
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_Get_15(HandleRef pThis, int idx, int frame, vtkDICOMTagPath p, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000251 RID: 593 RVA: 0x0000A600 File Offset: 0x00008800
		public vtkDICOMValue Get(int idx, int frame, vtkDICOMTagPath p)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_Get_15(base.GetCppThis(), idx, frame, p, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000252 RID: 594
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_GetAttributeValue_16(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000253 RID: 595 RVA: 0x0000A660 File Offset: 0x00008860
		public vtkDICOMValue GetAttributeValue(vtkDICOMTag tag)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_GetAttributeValue_16(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000254 RID: 596
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_GetAttributeValue_17(HandleRef pThis, vtkDICOMTagPath p, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000255 RID: 597 RVA: 0x0000A6D0 File Offset: 0x000088D0
		public vtkDICOMValue GetAttributeValue(vtkDICOMTagPath p)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_GetAttributeValue_17(base.GetCppThis(), p, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000256 RID: 598
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_GetAttributeValue_18(HandleRef pThis, int idx, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000257 RID: 599 RVA: 0x0000A72C File Offset: 0x0000892C
		public vtkDICOMValue GetAttributeValue(int idx, vtkDICOMTag tag)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_GetAttributeValue_18(base.GetCppThis(), idx, (tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000258 RID: 600
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_GetAttributeValue_19(HandleRef pThis, int idx, vtkDICOMTagPath p, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000259 RID: 601 RVA: 0x0000A7A0 File Offset: 0x000089A0
		public vtkDICOMValue GetAttributeValue(int idx, vtkDICOMTagPath p)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_GetAttributeValue_19(base.GetCppThis(), idx, p, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600025A RID: 602
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_GetAttributeValue_20(HandleRef pThis, int idx, int frame, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600025B RID: 603 RVA: 0x0000A7FC File Offset: 0x000089FC
		public vtkDICOMValue GetAttributeValue(int idx, int frame, vtkDICOMTag tag)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_GetAttributeValue_20(base.GetCppThis(), idx, frame, (tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600025C RID: 604
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_GetAttributeValue_21(HandleRef pThis, int idx, int frame, vtkDICOMTagPath p, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600025D RID: 605 RVA: 0x0000A870 File Offset: 0x00008A70
		public vtkDICOMValue GetAttributeValue(int idx, int frame, vtkDICOMTagPath p)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_GetAttributeValue_21(base.GetCppThis(), idx, frame, p, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600025E RID: 606
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMMetaData_GetFileIndex_22(HandleRef pThis, int sliceIdx, int compIdx, int numComps);

		// Token: 0x0600025F RID: 607 RVA: 0x0000A8D0 File Offset: 0x00008AD0
		public int GetFileIndex(int sliceIdx, int compIdx, int numComps)
		{
			return vtkDICOMMetaData.vtkDICOMMetaData_GetFileIndex_22(base.GetCppThis(), sliceIdx, compIdx, numComps);
		}

		// Token: 0x06000260 RID: 608
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMMetaData_GetFileIndex_23(HandleRef pThis, int sliceIdx);

		// Token: 0x06000261 RID: 609 RVA: 0x0000A8F4 File Offset: 0x00008AF4
		public int GetFileIndex(int sliceIdx)
		{
			return vtkDICOMMetaData.vtkDICOMMetaData_GetFileIndex_23(base.GetCppThis(), sliceIdx);
		}

		// Token: 0x06000262 RID: 610
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_GetFileIndexArray_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000263 RID: 611 RVA: 0x0000A914 File Offset: 0x00008B14
		public vtkIntArray GetFileIndexArray()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_GetFileIndexArray_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000264 RID: 612
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMMetaData_GetFrameIndex_25(HandleRef pThis, int sliceIdx, int compIdx, int numComps);

		// Token: 0x06000265 RID: 613 RVA: 0x0000A984 File Offset: 0x00008B84
		public int GetFrameIndex(int sliceIdx, int compIdx, int numComps)
		{
			return vtkDICOMMetaData.vtkDICOMMetaData_GetFrameIndex_25(base.GetCppThis(), sliceIdx, compIdx, numComps);
		}

		// Token: 0x06000266 RID: 614
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMMetaData_GetFrameIndex_26(HandleRef pThis, int sliceIdx);

		// Token: 0x06000267 RID: 615 RVA: 0x0000A9A8 File Offset: 0x00008BA8
		public int GetFrameIndex(int sliceIdx)
		{
			return vtkDICOMMetaData.vtkDICOMMetaData_GetFrameIndex_26(base.GetCppThis(), sliceIdx);
		}

		// Token: 0x06000268 RID: 616
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_GetFrameIndexArray_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000269 RID: 617 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		public vtkIntArray GetFrameIndexArray()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_GetFrameIndexArray_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600026A RID: 618
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMMetaData_GetNumberOfDataElements_28(HandleRef pThis);

		// Token: 0x0600026B RID: 619 RVA: 0x0000AA38 File Offset: 0x00008C38
		public int GetNumberOfDataElements()
		{
			return vtkDICOMMetaData.vtkDICOMMetaData_GetNumberOfDataElements_28(base.GetCppThis());
		}

		// Token: 0x0600026C RID: 620
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMMetaData_GetNumberOfGenerationsFromBase_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0600026D RID: 621 RVA: 0x0000AA58 File Offset: 0x00008C58
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMMetaData.vtkDICOMMetaData_GetNumberOfGenerationsFromBase_29(base.GetCppThis(), type);
		}

		// Token: 0x0600026E RID: 622
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMMetaData_GetNumberOfGenerationsFromBaseType_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0600026F RID: 623 RVA: 0x0000AA78 File Offset: 0x00008C78
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMMetaData.vtkDICOMMetaData_GetNumberOfGenerationsFromBaseType_30(type);
		}

		// Token: 0x06000270 RID: 624
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMMetaData_GetNumberOfInstances_31(HandleRef pThis);

		// Token: 0x06000271 RID: 625 RVA: 0x0000AA94 File Offset: 0x00008C94
		public int GetNumberOfInstances()
		{
			return vtkDICOMMetaData.vtkDICOMMetaData_GetNumberOfInstances_31(base.GetCppThis());
		}

		// Token: 0x06000272 RID: 626
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMMetaData_Has_32(HandleRef pThis, HandleRef tag);

		// Token: 0x06000273 RID: 627 RVA: 0x0000AAB4 File Offset: 0x00008CB4
		public bool Has(vtkDICOMTag tag)
		{
			return vtkDICOMMetaData.vtkDICOMMetaData_Has_32(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis()) != 0;
		}

		// Token: 0x06000274 RID: 628
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMMetaData_HasAttribute_33(HandleRef pThis, HandleRef tag);

		// Token: 0x06000275 RID: 629 RVA: 0x0000AAF0 File Offset: 0x00008CF0
		public bool HasAttribute(vtkDICOMTag tag)
		{
			return vtkDICOMMetaData.vtkDICOMMetaData_HasAttribute_33(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis()) != 0;
		}

		// Token: 0x06000276 RID: 630
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_Initialize_34(HandleRef pThis);

		// Token: 0x06000277 RID: 631 RVA: 0x0000AB2B File Offset: 0x00008D2B
		public override void Initialize()
		{
			vtkDICOMMetaData.vtkDICOMMetaData_Initialize_34(base.GetCppThis());
		}

		// Token: 0x06000278 RID: 632
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMMetaData_IsA_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000279 RID: 633 RVA: 0x0000AB3C File Offset: 0x00008D3C
		public override int IsA(string type)
		{
			return vtkDICOMMetaData.vtkDICOMMetaData_IsA_35(base.GetCppThis(), type);
		}

		// Token: 0x0600027A RID: 634
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMMetaData_IsTypeOf_36([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0600027B RID: 635 RVA: 0x0000AB5C File Offset: 0x00008D5C
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMMetaData.vtkDICOMMetaData_IsTypeOf_36(type);
		}

		// Token: 0x0600027C RID: 636
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_MakeValueWithSpecificCharacterSet_37(HandleRef pThis, vtkDICOMVR vr, [MarshalAs(UnmanagedType.LPUTF8Str)] string v, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600027D RID: 637 RVA: 0x0000AB78 File Offset: 0x00008D78
		public vtkDICOMValue MakeValueWithSpecificCharacterSet(vtkDICOMVR vr, string v)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_MakeValueWithSpecificCharacterSet_37(base.GetCppThis(), vr, v, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600027E RID: 638
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600027F RID: 639 RVA: 0x0000ABD4 File Offset: 0x00008DD4
		public new vtkDICOMMetaData NewInstance()
		{
			vtkDICOMMetaData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_NewInstance_39(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMMetaData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000280 RID: 640
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_RemoveAttribute_40(HandleRef pThis, HandleRef tag);

		// Token: 0x06000281 RID: 641 RVA: 0x0000AC30 File Offset: 0x00008E30
		public void RemoveAttribute(vtkDICOMTag tag)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_RemoveAttribute_40(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis());
		}

		// Token: 0x06000282 RID: 642
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_ResolvePrivateTag_41(HandleRef pThis, HandleRef ptag, [MarshalAs(UnmanagedType.LPUTF8Str)] string creator, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000283 RID: 643 RVA: 0x0000AC60 File Offset: 0x00008E60
		public vtkDICOMTag ResolvePrivateTag(vtkDICOMTag ptag, string creator)
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_ResolvePrivateTag_41(base.GetCppThis(), (ptag == null) ? default(HandleRef) : ptag.GetCppThis(), creator, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000284 RID: 644
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_ResolvePrivateTag_42(HandleRef pThis, int idx, HandleRef ptag, [MarshalAs(UnmanagedType.LPUTF8Str)] string creator, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000285 RID: 645 RVA: 0x0000ACD4 File Offset: 0x00008ED4
		public vtkDICOMTag ResolvePrivateTag(int idx, vtkDICOMTag ptag, string creator)
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_ResolvePrivateTag_42(base.GetCppThis(), idx, (ptag == null) ? default(HandleRef) : ptag.GetCppThis(), creator, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000286 RID: 646
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_ResolvePrivateTagForWriting_43(HandleRef pThis, HandleRef ptag, [MarshalAs(UnmanagedType.LPUTF8Str)] string creator, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000287 RID: 647 RVA: 0x0000AD48 File Offset: 0x00008F48
		public vtkDICOMTag ResolvePrivateTagForWriting(vtkDICOMTag ptag, string creator)
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_ResolvePrivateTagForWriting_43(base.GetCppThis(), (ptag == null) ? default(HandleRef) : ptag.GetCppThis(), creator, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000288 RID: 648
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_ResolvePrivateTagForWriting_44(HandleRef pThis, int idx, HandleRef ptag, [MarshalAs(UnmanagedType.LPUTF8Str)] string creator, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000289 RID: 649 RVA: 0x0000ADBC File Offset: 0x00008FBC
		public vtkDICOMTag ResolvePrivateTagForWriting(int idx, vtkDICOMTag ptag, string creator)
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_ResolvePrivateTagForWriting_44(base.GetCppThis(), idx, (ptag == null) ? default(HandleRef) : ptag.GetCppThis(), creator, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600028A RID: 650
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaData_SafeDownCast_45(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600028B RID: 651 RVA: 0x0000AE30 File Offset: 0x00009030
		public new static vtkDICOMMetaData SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMMetaData vtkDICOMMetaData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaData.vtkDICOMMetaData_SafeDownCast_45((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600028C RID: 652
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_Set_46(HandleRef pThis, int idx, HandleRef tag, HandleRef v);

		// Token: 0x0600028D RID: 653 RVA: 0x0000AEB0 File Offset: 0x000090B0
		public void Set(int idx, vtkDICOMTag tag, vtkDICOMValue v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_Set_46(base.GetCppThis(), idx, (tag == null) ? default(HandleRef) : tag.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x0600028E RID: 654
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_Set_47(HandleRef pThis, int idx, HandleRef tag, double v);

		// Token: 0x0600028F RID: 655 RVA: 0x0000AEF8 File Offset: 0x000090F8
		public void Set(int idx, vtkDICOMTag tag, double v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_Set_47(base.GetCppThis(), idx, (tag == null) ? default(HandleRef) : tag.GetCppThis(), v);
		}

		// Token: 0x06000290 RID: 656
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_Set_48(HandleRef pThis, int idx, HandleRef tag, [MarshalAs(UnmanagedType.LPUTF8Str)] string v);

		// Token: 0x06000291 RID: 657 RVA: 0x0000AF2C File Offset: 0x0000912C
		public void Set(int idx, vtkDICOMTag tag, string v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_Set_48(base.GetCppThis(), idx, (tag == null) ? default(HandleRef) : tag.GetCppThis(), v);
		}

		// Token: 0x06000292 RID: 658
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_Set_49(HandleRef pThis, HandleRef tag, HandleRef v);

		// Token: 0x06000293 RID: 659 RVA: 0x0000AF60 File Offset: 0x00009160
		public void Set(vtkDICOMTag tag, vtkDICOMValue v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_Set_49(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x06000294 RID: 660
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_Set_50(HandleRef pThis, HandleRef tag, double v);

		// Token: 0x06000295 RID: 661 RVA: 0x0000AFA4 File Offset: 0x000091A4
		public void Set(vtkDICOMTag tag, double v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_Set_50(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), v);
		}

		// Token: 0x06000296 RID: 662
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_Set_51(HandleRef pThis, HandleRef tag, [MarshalAs(UnmanagedType.LPUTF8Str)] string v);

		// Token: 0x06000297 RID: 663 RVA: 0x0000AFD4 File Offset: 0x000091D4
		public void Set(vtkDICOMTag tag, string v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_Set_51(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), v);
		}

		// Token: 0x06000298 RID: 664
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_Set_52(HandleRef pThis, int idx, vtkDICOMTagPath tag, HandleRef v);

		// Token: 0x06000299 RID: 665 RVA: 0x0000B004 File Offset: 0x00009204
		public void Set(int idx, vtkDICOMTagPath tag, vtkDICOMValue v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_Set_52(base.GetCppThis(), idx, tag, (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x0600029A RID: 666
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_Set_53(HandleRef pThis, int idx, vtkDICOMTagPath tag, double v);

		// Token: 0x0600029B RID: 667 RVA: 0x0000B035 File Offset: 0x00009235
		public void Set(int idx, vtkDICOMTagPath tag, double v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_Set_53(base.GetCppThis(), idx, tag, v);
		}

		// Token: 0x0600029C RID: 668
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_Set_54(HandleRef pThis, int idx, vtkDICOMTagPath tag, [MarshalAs(UnmanagedType.LPUTF8Str)] string v);

		// Token: 0x0600029D RID: 669 RVA: 0x0000B047 File Offset: 0x00009247
		public void Set(int idx, vtkDICOMTagPath tag, string v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_Set_54(base.GetCppThis(), idx, tag, v);
		}

		// Token: 0x0600029E RID: 670
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_Set_55(HandleRef pThis, vtkDICOMTagPath tag, HandleRef v);

		// Token: 0x0600029F RID: 671 RVA: 0x0000B05C File Offset: 0x0000925C
		public void Set(vtkDICOMTagPath tag, vtkDICOMValue v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_Set_55(base.GetCppThis(), tag, (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x060002A0 RID: 672
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_Set_56(HandleRef pThis, vtkDICOMTagPath tag, double v);

		// Token: 0x060002A1 RID: 673 RVA: 0x0000B08C File Offset: 0x0000928C
		public void Set(vtkDICOMTagPath tag, double v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_Set_56(base.GetCppThis(), tag, v);
		}

		// Token: 0x060002A2 RID: 674
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_Set_57(HandleRef pThis, vtkDICOMTagPath tag, [MarshalAs(UnmanagedType.LPUTF8Str)] string v);

		// Token: 0x060002A3 RID: 675 RVA: 0x0000B09D File Offset: 0x0000929D
		public void Set(vtkDICOMTagPath tag, string v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_Set_57(base.GetCppThis(), tag, v);
		}

		// Token: 0x060002A4 RID: 676
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_SetAttributeValue_58(HandleRef pThis, int idx, HandleRef tag, HandleRef v);

		// Token: 0x060002A5 RID: 677 RVA: 0x0000B0B0 File Offset: 0x000092B0
		public void SetAttributeValue(int idx, vtkDICOMTag tag, vtkDICOMValue v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_SetAttributeValue_58(base.GetCppThis(), idx, (tag == null) ? default(HandleRef) : tag.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x060002A6 RID: 678
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_SetAttributeValue_59(HandleRef pThis, int idx, HandleRef tag, double v);

		// Token: 0x060002A7 RID: 679 RVA: 0x0000B0F8 File Offset: 0x000092F8
		public void SetAttributeValue(int idx, vtkDICOMTag tag, double v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_SetAttributeValue_59(base.GetCppThis(), idx, (tag == null) ? default(HandleRef) : tag.GetCppThis(), v);
		}

		// Token: 0x060002A8 RID: 680
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_SetAttributeValue_60(HandleRef pThis, int idx, HandleRef tag, [MarshalAs(UnmanagedType.LPUTF8Str)] string v);

		// Token: 0x060002A9 RID: 681 RVA: 0x0000B12C File Offset: 0x0000932C
		public void SetAttributeValue(int idx, vtkDICOMTag tag, string v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_SetAttributeValue_60(base.GetCppThis(), idx, (tag == null) ? default(HandleRef) : tag.GetCppThis(), v);
		}

		// Token: 0x060002AA RID: 682
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_SetAttributeValue_61(HandleRef pThis, HandleRef tag, HandleRef v);

		// Token: 0x060002AB RID: 683 RVA: 0x0000B160 File Offset: 0x00009360
		public void SetAttributeValue(vtkDICOMTag tag, vtkDICOMValue v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_SetAttributeValue_61(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x060002AC RID: 684
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_SetAttributeValue_62(HandleRef pThis, HandleRef tag, double v);

		// Token: 0x060002AD RID: 685 RVA: 0x0000B1A4 File Offset: 0x000093A4
		public void SetAttributeValue(vtkDICOMTag tag, double v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_SetAttributeValue_62(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), v);
		}

		// Token: 0x060002AE RID: 686
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_SetAttributeValue_63(HandleRef pThis, HandleRef tag, [MarshalAs(UnmanagedType.LPUTF8Str)] string v);

		// Token: 0x060002AF RID: 687 RVA: 0x0000B1D4 File Offset: 0x000093D4
		public void SetAttributeValue(vtkDICOMTag tag, string v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_SetAttributeValue_63(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), v);
		}

		// Token: 0x060002B0 RID: 688
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_SetAttributeValue_64(HandleRef pThis, int idx, vtkDICOMTagPath tag, HandleRef v);

		// Token: 0x060002B1 RID: 689 RVA: 0x0000B204 File Offset: 0x00009404
		public void SetAttributeValue(int idx, vtkDICOMTagPath tag, vtkDICOMValue v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_SetAttributeValue_64(base.GetCppThis(), idx, tag, (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x060002B2 RID: 690
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_SetAttributeValue_65(HandleRef pThis, int idx, vtkDICOMTagPath tag, double v);

		// Token: 0x060002B3 RID: 691 RVA: 0x0000B235 File Offset: 0x00009435
		public void SetAttributeValue(int idx, vtkDICOMTagPath tag, double v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_SetAttributeValue_65(base.GetCppThis(), idx, tag, v);
		}

		// Token: 0x060002B4 RID: 692
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_SetAttributeValue_66(HandleRef pThis, int idx, vtkDICOMTagPath tag, [MarshalAs(UnmanagedType.LPUTF8Str)] string v);

		// Token: 0x060002B5 RID: 693 RVA: 0x0000B247 File Offset: 0x00009447
		public void SetAttributeValue(int idx, vtkDICOMTagPath tag, string v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_SetAttributeValue_66(base.GetCppThis(), idx, tag, v);
		}

		// Token: 0x060002B6 RID: 694
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_SetAttributeValue_67(HandleRef pThis, vtkDICOMTagPath tag, HandleRef v);

		// Token: 0x060002B7 RID: 695 RVA: 0x0000B25C File Offset: 0x0000945C
		public void SetAttributeValue(vtkDICOMTagPath tag, vtkDICOMValue v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_SetAttributeValue_67(base.GetCppThis(), tag, (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x060002B8 RID: 696
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_SetAttributeValue_68(HandleRef pThis, vtkDICOMTagPath tag, double v);

		// Token: 0x060002B9 RID: 697 RVA: 0x0000B28C File Offset: 0x0000948C
		public void SetAttributeValue(vtkDICOMTagPath tag, double v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_SetAttributeValue_68(base.GetCppThis(), tag, v);
		}

		// Token: 0x060002BA RID: 698
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_SetAttributeValue_69(HandleRef pThis, vtkDICOMTagPath tag, [MarshalAs(UnmanagedType.LPUTF8Str)] string v);

		// Token: 0x060002BB RID: 699 RVA: 0x0000B29D File Offset: 0x0000949D
		public void SetAttributeValue(vtkDICOMTagPath tag, string v)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_SetAttributeValue_69(base.GetCppThis(), tag, v);
		}

		// Token: 0x060002BC RID: 700
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_SetFileIndexArray_70(HandleRef pThis, HandleRef fileArray);

		// Token: 0x060002BD RID: 701 RVA: 0x0000B2B0 File Offset: 0x000094B0
		public void SetFileIndexArray(vtkIntArray fileArray)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_SetFileIndexArray_70(base.GetCppThis(), (fileArray == null) ? default(HandleRef) : fileArray.GetCppThis());
		}

		// Token: 0x060002BE RID: 702
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_SetFrameIndexArray_71(HandleRef pThis, HandleRef frameArray);

		// Token: 0x060002BF RID: 703 RVA: 0x0000B2E0 File Offset: 0x000094E0
		public void SetFrameIndexArray(vtkIntArray frameArray)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_SetFrameIndexArray_71(base.GetCppThis(), (frameArray == null) ? default(HandleRef) : frameArray.GetCppThis());
		}

		// Token: 0x060002C0 RID: 704
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_SetNumberOfInstances_72(HandleRef pThis, int n);

		// Token: 0x060002C1 RID: 705 RVA: 0x0000B30F File Offset: 0x0000950F
		public void SetNumberOfInstances(int n)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_SetNumberOfInstances_72(base.GetCppThis(), n);
		}

		// Token: 0x060002C2 RID: 706
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMMetaData_ShallowCopy_73(HandleRef pThis, HandleRef source);

		// Token: 0x060002C3 RID: 707 RVA: 0x0000B320 File Offset: 0x00009520
		public override void ShallowCopy(vtkDataObject source)
		{
			vtkDICOMMetaData.vtkDICOMMetaData_ShallowCopy_73(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000120 RID: 288
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMMetaData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000121 RID: 289
		public new static readonly string MRClassNameKey = "class vtkDICOMMetaData";
	}
}
