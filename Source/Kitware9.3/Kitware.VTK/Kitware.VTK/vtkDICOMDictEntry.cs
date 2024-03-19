using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x0200001C RID: 28
	public class vtkDICOMDictEntry : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600039A RID: 922 RVA: 0x0000C422 File Offset: 0x0000A622
		static vtkDICOMDictEntry()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMDictEntry.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMDictEntry"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600039B RID: 923 RVA: 0x0000C44A File Offset: 0x0000A64A
		public vtkDICOMDictEntry(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600039C RID: 924 RVA: 0x0000C458 File Offset: 0x0000A658
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600039D RID: 925
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDictEntry_GetName_01(HandleRef pThis);

		// Token: 0x0600039E RID: 926 RVA: 0x0000C464 File Offset: 0x0000A664
		public string GetName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMDictEntry.vtkDICOMDictEntry_GetName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600039F RID: 927
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDictEntry_GetTag_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060003A0 RID: 928 RVA: 0x0000C4A0 File Offset: 0x0000A6A0
		public vtkDICOMTag GetTag()
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDictEntry.vtkDICOMDictEntry_GetTag_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060003A1 RID: 929
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDICOMVM vtkDICOMDictEntry_GetVM_03(HandleRef pThis);

		// Token: 0x060003A2 RID: 930 RVA: 0x0000C4FC File Offset: 0x0000A6FC
		public vtkDICOMVM GetVM()
		{
			return vtkDICOMDictEntry.vtkDICOMDictEntry_GetVM_03(base.GetCppThis());
		}

		// Token: 0x060003A3 RID: 931
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDICOMVR vtkDICOMDictEntry_GetVR_04(HandleRef pThis);

		// Token: 0x060003A4 RID: 932 RVA: 0x0000C51C File Offset: 0x0000A71C
		public vtkDICOMVR GetVR()
		{
			return vtkDICOMDictEntry.vtkDICOMDictEntry_GetVR_04(base.GetCppThis());
		}

		// Token: 0x060003A5 RID: 933
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMDictEntry_IsRetired_05(HandleRef pThis);

		// Token: 0x060003A6 RID: 934 RVA: 0x0000C53C File Offset: 0x0000A73C
		public bool IsRetired()
		{
			return vtkDICOMDictEntry.vtkDICOMDictEntry_IsRetired_05(base.GetCppThis()) != 0;
		}

		// Token: 0x060003A7 RID: 935
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMDictEntry_IsValid_06(HandleRef pThis);

		// Token: 0x060003A8 RID: 936 RVA: 0x0000C564 File Offset: 0x0000A764
		public bool IsValid()
		{
			return vtkDICOMDictEntry.vtkDICOMDictEntry_IsValid_06(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000342 RID: 834
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMDictEntry";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000343 RID: 835
		public new static readonly string MRClassNameKey = "class vtkDICOMDictEntry";
	}
}
