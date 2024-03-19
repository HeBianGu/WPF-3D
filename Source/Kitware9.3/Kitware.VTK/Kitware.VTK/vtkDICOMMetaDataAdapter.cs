using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000045 RID: 69
	public class vtkDICOMMetaDataAdapter : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000C44 RID: 3140 RVA: 0x0001868E File Offset: 0x0001688E
		static vtkDICOMMetaDataAdapter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMMetaDataAdapter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMMetaDataAdapter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000C45 RID: 3141 RVA: 0x000186B6 File Offset: 0x000168B6
		public vtkDICOMMetaDataAdapter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000C46 RID: 3142 RVA: 0x000186C4 File Offset: 0x000168C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000C47 RID: 3143
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaDataAdapter_Get_01(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000C48 RID: 3144 RVA: 0x000186D0 File Offset: 0x000168D0
		public vtkDICOMValue Get(vtkDICOMTag tag)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaDataAdapter.vtkDICOMMetaDataAdapter_Get_01(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000C49 RID: 3145
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaDataAdapter_Get_02(HandleRef pThis, int idx, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000C4A RID: 3146 RVA: 0x00018740 File Offset: 0x00016940
		public vtkDICOMValue Get(int idx, vtkDICOMTag tag)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaDataAdapter.vtkDICOMMetaDataAdapter_Get_02(base.GetCppThis(), idx, (tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000C4B RID: 3147
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaDataAdapter_GetAttributeValue_03(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000C4C RID: 3148 RVA: 0x000187B4 File Offset: 0x000169B4
		public vtkDICOMValue GetAttributeValue(vtkDICOMTag tag)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaDataAdapter.vtkDICOMMetaDataAdapter_GetAttributeValue_03(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000C4D RID: 3149
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaDataAdapter_GetAttributeValue_04(HandleRef pThis, int idx, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000C4E RID: 3150 RVA: 0x00018824 File Offset: 0x00016A24
		public vtkDICOMValue GetAttributeValue(int idx, vtkDICOMTag tag)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaDataAdapter.vtkDICOMMetaDataAdapter_GetAttributeValue_04(base.GetCppThis(), idx, (tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000C4F RID: 3151
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMMetaDataAdapter_GetNumberOfInstances_05(HandleRef pThis);

		// Token: 0x06000C50 RID: 3152 RVA: 0x00018898 File Offset: 0x00016A98
		public int GetNumberOfInstances()
		{
			return vtkDICOMMetaDataAdapter.vtkDICOMMetaDataAdapter_GetNumberOfInstances_05(base.GetCppThis());
		}

		// Token: 0x06000C51 RID: 3153
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMMetaDataAdapter_Has_06(HandleRef pThis, HandleRef tag);

		// Token: 0x06000C52 RID: 3154 RVA: 0x000188B8 File Offset: 0x00016AB8
		public bool Has(vtkDICOMTag tag)
		{
			return vtkDICOMMetaDataAdapter.vtkDICOMMetaDataAdapter_Has_06(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis()) != 0;
		}

		// Token: 0x06000C53 RID: 3155
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMMetaDataAdapter_HasAttribute_07(HandleRef pThis, HandleRef tag);

		// Token: 0x06000C54 RID: 3156 RVA: 0x000188F4 File Offset: 0x00016AF4
		public bool HasAttribute(vtkDICOMTag tag)
		{
			return vtkDICOMMetaDataAdapter.vtkDICOMMetaDataAdapter_HasAttribute_07(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis()) != 0;
		}

		// Token: 0x06000C55 RID: 3157
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaDataAdapter_ResolvePrivateTag_08(HandleRef pThis, HandleRef ptag, [MarshalAs(UnmanagedType.LPUTF8Str)] string creator, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000C56 RID: 3158 RVA: 0x00018930 File Offset: 0x00016B30
		public vtkDICOMTag ResolvePrivateTag(vtkDICOMTag ptag, string creator)
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaDataAdapter.vtkDICOMMetaDataAdapter_ResolvePrivateTag_08(base.GetCppThis(), (ptag == null) ? default(HandleRef) : ptag.GetCppThis(), creator, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000C57 RID: 3159
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaDataAdapter_ResolvePrivateTag_09(HandleRef pThis, int idx, HandleRef ptag, [MarshalAs(UnmanagedType.LPUTF8Str)] string creator, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000C58 RID: 3160 RVA: 0x000189A4 File Offset: 0x00016BA4
		public vtkDICOMTag ResolvePrivateTag(int idx, vtkDICOMTag ptag, string creator)
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMetaDataAdapter.vtkDICOMMetaDataAdapter_ResolvePrivateTag_09(base.GetCppThis(), idx, (ptag == null) ? default(HandleRef) : ptag.GetCppThis(), creator, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000C59 RID: 3161
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMetaDataAdapter_New(HandleRef meta, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000C5A RID: 3162 RVA: 0x00018A18 File Offset: 0x00016C18
		public vtkDICOMMetaDataAdapter(vtkDICOMMetaData meta) : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMMetaDataAdapter.vtkDICOMMetaDataAdapter_New((meta == null) ? default(HandleRef) : meta.GetCppThis(), ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003BE RID: 958
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMMetaDataAdapter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003BF RID: 959
		public new static readonly string MRClassNameKey = "class vtkDICOMMetaDataAdapter";
	}
}
