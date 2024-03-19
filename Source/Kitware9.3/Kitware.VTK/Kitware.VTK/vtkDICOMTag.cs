using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000013 RID: 19
	public class vtkDICOMTag : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000320 RID: 800 RVA: 0x0000BA87 File Offset: 0x00009C87
		static vtkDICOMTag()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMTag.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMTag"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000321 RID: 801 RVA: 0x0000BAAF File Offset: 0x00009CAF
		public vtkDICOMTag(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000322 RID: 802 RVA: 0x0000BABD File Offset: 0x00009CBD
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000323 RID: 803
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDICOMTag_ComputeHash_01(HandleRef pThis);

		// Token: 0x06000324 RID: 804 RVA: 0x0000BAC8 File Offset: 0x00009CC8
		public uint ComputeHash()
		{
			return vtkDICOMTag.vtkDICOMTag_ComputeHash_01(base.GetCppThis());
		}

		// Token: 0x06000325 RID: 805
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkDICOMTag_GetElement_02(HandleRef pThis);

		// Token: 0x06000326 RID: 806 RVA: 0x0000BAE8 File Offset: 0x00009CE8
		public ushort GetElement()
		{
			return vtkDICOMTag.vtkDICOMTag_GetElement_02(base.GetCppThis());
		}

		// Token: 0x06000327 RID: 807
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkDICOMTag_GetGroup_03(HandleRef pThis);

		// Token: 0x06000328 RID: 808 RVA: 0x0000BB08 File Offset: 0x00009D08
		public ushort GetGroup()
		{
			return vtkDICOMTag.vtkDICOMTag_GetGroup_03(base.GetCppThis());
		}

		// Token: 0x06000329 RID: 809
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDICOMTag_GetKey_04(HandleRef pThis);

		// Token: 0x0600032A RID: 810 RVA: 0x0000BB28 File Offset: 0x00009D28
		public uint GetKey()
		{
			return vtkDICOMTag.vtkDICOMTag_GetKey_04(base.GetCppThis());
		}

		// Token: 0x0600032B RID: 811
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMTag_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount, int group, int element);

		// Token: 0x0600032C RID: 812 RVA: 0x0000BB48 File Offset: 0x00009D48
		public vtkDICOMTag(int group, int element) : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMTag.vtkDICOMTag_New(ref num, ref maxValue, ref num2, group, element);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000140 RID: 320
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMTag";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000141 RID: 321
		public new static readonly string MRClassNameKey = "class vtkDICOMTag";
	}
}
