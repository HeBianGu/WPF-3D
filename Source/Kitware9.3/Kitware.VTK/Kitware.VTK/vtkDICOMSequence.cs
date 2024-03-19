using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000030 RID: 48
	public class vtkDICOMSequence : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600081D RID: 2077 RVA: 0x00012CD4 File Offset: 0x00010ED4
		static vtkDICOMSequence()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMSequence.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMSequence"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600081E RID: 2078 RVA: 0x00012CFC File Offset: 0x00010EFC
		public vtkDICOMSequence(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600081F RID: 2079 RVA: 0x00012D0A File Offset: 0x00010F0A
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000820 RID: 2080
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSequence_AddItem_01(HandleRef pThis, HandleRef item);

		// Token: 0x06000821 RID: 2081 RVA: 0x00012D18 File Offset: 0x00010F18
		public void AddItem(vtkDICOMItem item)
		{
			vtkDICOMSequence.vtkDICOMSequence_AddItem_01(base.GetCppThis(), (item == null) ? default(HandleRef) : item.GetCppThis());
		}

		// Token: 0x06000822 RID: 2082
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSequence_Clear_02(HandleRef pThis);

		// Token: 0x06000823 RID: 2083 RVA: 0x00012D47 File Offset: 0x00010F47
		public void Clear()
		{
			vtkDICOMSequence.vtkDICOMSequence_Clear_02(base.GetCppThis());
		}

		// Token: 0x06000824 RID: 2084
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSequence_Get_03(HandleRef pThis, ulong i, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000825 RID: 2085 RVA: 0x00012D58 File Offset: 0x00010F58
		public vtkDICOMValue Get(ulong i, vtkDICOMTag tag)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSequence.vtkDICOMSequence_Get_03(base.GetCppThis(), i, (tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000826 RID: 2086
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSequence_Get_04(HandleRef pThis, ulong i, vtkDICOMTagPath p, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000827 RID: 2087 RVA: 0x00012DCC File Offset: 0x00010FCC
		public vtkDICOMValue Get(ulong i, vtkDICOMTagPath p)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSequence.vtkDICOMSequence_Get_04(base.GetCppThis(), i, p, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000828 RID: 2088
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSequence_GetAttributeValue_05(HandleRef pThis, ulong i, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000829 RID: 2089 RVA: 0x00012E28 File Offset: 0x00011028
		public vtkDICOMValue GetAttributeValue(ulong i, vtkDICOMTag tag)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSequence.vtkDICOMSequence_GetAttributeValue_05(base.GetCppThis(), i, (tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600082A RID: 2090
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSequence_GetAttributeValue_06(HandleRef pThis, ulong i, vtkDICOMTagPath p, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600082B RID: 2091 RVA: 0x00012E9C File Offset: 0x0001109C
		public vtkDICOMValue GetAttributeValue(ulong i, vtkDICOMTagPath p)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSequence.vtkDICOMSequence_GetAttributeValue_06(base.GetCppThis(), i, p, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600082C RID: 2092
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSequence_GetItem_07(HandleRef pThis, ulong i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0600082D RID: 2093 RVA: 0x00012EF8 File Offset: 0x000110F8
		public vtkDICOMItem GetItem(ulong i)
		{
			vtkDICOMItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSequence.vtkDICOMSequence_GetItem_07(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600082E RID: 2094
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDICOMSequence_GetNumberOfItems_08(HandleRef pThis);

		// Token: 0x0600082F RID: 2095 RVA: 0x00012F54 File Offset: 0x00011154
		public ulong GetNumberOfItems()
		{
			return vtkDICOMSequence.vtkDICOMSequence_GetNumberOfItems_08(base.GetCppThis());
		}

		// Token: 0x06000830 RID: 2096
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSequence_GetSequenceData_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000831 RID: 2097 RVA: 0x00012F74 File Offset: 0x00011174
		public vtkDICOMItem GetSequenceData()
		{
			vtkDICOMItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSequence.vtkDICOMSequence_GetSequenceData_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		// Token: 0x06000832 RID: 2098
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMSequence_IsValid_10(HandleRef pThis);

		// Token: 0x06000833 RID: 2099 RVA: 0x00012FD0 File Offset: 0x000111D0
		public bool IsValid()
		{
			return vtkDICOMSequence.vtkDICOMSequence_IsValid_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06000834 RID: 2100
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMSequence_SetItem_11(HandleRef pThis, ulong i, HandleRef item);

		// Token: 0x06000835 RID: 2101 RVA: 0x00012FF8 File Offset: 0x000111F8
		public void SetItem(ulong i, vtkDICOMItem item)
		{
			vtkDICOMSequence.vtkDICOMSequence_SetItem_11(base.GetCppThis(), i, (item == null) ? default(HandleRef) : item.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400038A RID: 906
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMSequence";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400038B RID: 907
		public new static readonly string MRClassNameKey = "class vtkDICOMSequence";
	}
}
