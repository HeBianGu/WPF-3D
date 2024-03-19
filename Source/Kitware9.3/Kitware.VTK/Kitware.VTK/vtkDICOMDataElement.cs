using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x0200001B RID: 27
	public class vtkDICOMDataElement : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600038B RID: 907 RVA: 0x0000C264 File Offset: 0x0000A464
		static vtkDICOMDataElement()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMDataElement.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMDataElement"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600038C RID: 908 RVA: 0x0000C28C File Offset: 0x0000A48C
		public vtkDICOMDataElement(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600038D RID: 909 RVA: 0x0000C29A File Offset: 0x0000A49A
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600038E RID: 910
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMDataElement_GetNumberOfInstances_01(HandleRef pThis);

		// Token: 0x0600038F RID: 911 RVA: 0x0000C2A8 File Offset: 0x0000A4A8
		public int GetNumberOfInstances()
		{
			return vtkDICOMDataElement.vtkDICOMDataElement_GetNumberOfInstances_01(base.GetCppThis());
		}

		// Token: 0x06000390 RID: 912
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDataElement_GetTag_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000391 RID: 913 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
		public vtkDICOMTag GetTag()
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDataElement.vtkDICOMDataElement_GetTag_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000392 RID: 914
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDICOMVR vtkDICOMDataElement_GetVR_03(HandleRef pThis);

		// Token: 0x06000393 RID: 915 RVA: 0x0000C324 File Offset: 0x0000A524
		public vtkDICOMVR GetVR()
		{
			return vtkDICOMDataElement.vtkDICOMDataElement_GetVR_03(base.GetCppThis());
		}

		// Token: 0x06000394 RID: 916
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDataElement_GetValue_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000395 RID: 917 RVA: 0x0000C344 File Offset: 0x0000A544
		public vtkDICOMValue GetValue()
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDataElement.vtkDICOMDataElement_GetValue_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000396 RID: 918
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDataElement_GetValue_05(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000397 RID: 919 RVA: 0x0000C3A0 File Offset: 0x0000A5A0
		public vtkDICOMValue GetValue(int i)
		{
			vtkDICOMValue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDataElement.vtkDICOMDataElement_GetValue_05(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000398 RID: 920
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMDataElement_IsPerInstance_06(HandleRef pThis);

		// Token: 0x06000399 RID: 921 RVA: 0x0000C3FC File Offset: 0x0000A5FC
		public bool IsPerInstance()
		{
			return vtkDICOMDataElement.vtkDICOMDataElement_IsPerInstance_06(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000340 RID: 832
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMDataElement";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000341 RID: 833
		public new static readonly string MRClassNameKey = "class vtkDICOMDataElement";
	}
}
