using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x0200000C RID: 12
	public class vtkDICOMFilePath : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060002D1 RID: 721 RVA: 0x0000B520 File Offset: 0x00009720
		static vtkDICOMFilePath()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMFilePath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMFilePath"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060002D2 RID: 722 RVA: 0x0000B548 File Offset: 0x00009748
		public vtkDICOMFilePath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060002D3 RID: 723 RVA: 0x0000B556 File Offset: 0x00009756
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060002D4 RID: 724
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMFilePath_AsString_01(HandleRef pThis);

		// Token: 0x060002D5 RID: 725 RVA: 0x0000B564 File Offset: 0x00009764
		public string AsString()
		{
			return vtkDICOMFilePath.vtkDICOMFilePath_AsString_01(base.GetCppThis());
		}

		// Token: 0x060002D6 RID: 726
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMFilePath_GetBack_02(HandleRef pThis);

		// Token: 0x060002D7 RID: 727 RVA: 0x0000B584 File Offset: 0x00009784
		public string GetBack()
		{
			return vtkDICOMFilePath.vtkDICOMFilePath_GetBack_02(base.GetCppThis());
		}

		// Token: 0x060002D8 RID: 728
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMFilePath_GetExtension_03(HandleRef pThis);

		// Token: 0x060002D9 RID: 729 RVA: 0x0000B5A4 File Offset: 0x000097A4
		public string GetExtension()
		{
			return vtkDICOMFilePath.vtkDICOMFilePath_GetExtension_03(base.GetCppThis());
		}

		// Token: 0x060002DA RID: 730
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMFilePath_GetRealPath_04(HandleRef pThis);

		// Token: 0x060002DB RID: 731 RVA: 0x0000B5C4 File Offset: 0x000097C4
		public string GetRealPath()
		{
			return vtkDICOMFilePath.vtkDICOMFilePath_GetRealPath_04(base.GetCppThis());
		}

		// Token: 0x060002DC RID: 732
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMFilePath_IsDirectory_05(HandleRef pThis);

		// Token: 0x060002DD RID: 733 RVA: 0x0000B5E4 File Offset: 0x000097E4
		public bool IsDirectory()
		{
			return vtkDICOMFilePath.vtkDICOMFilePath_IsDirectory_05(base.GetCppThis()) != 0;
		}

		// Token: 0x060002DE RID: 734
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMFilePath_IsEmpty_06(HandleRef pThis);

		// Token: 0x060002DF RID: 735 RVA: 0x0000B60C File Offset: 0x0000980C
		public bool IsEmpty()
		{
			return vtkDICOMFilePath.vtkDICOMFilePath_IsEmpty_06(base.GetCppThis()) != 0;
		}

		// Token: 0x060002E0 RID: 736
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMFilePath_IsRoot_07(HandleRef pThis);

		// Token: 0x060002E1 RID: 737 RVA: 0x0000B634 File Offset: 0x00009834
		public bool IsRoot()
		{
			return vtkDICOMFilePath.vtkDICOMFilePath_IsRoot_07(base.GetCppThis()) != 0;
		}

		// Token: 0x060002E2 RID: 738
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMFilePath_IsSpecial_08(HandleRef pThis);

		// Token: 0x060002E3 RID: 739 RVA: 0x0000B65C File Offset: 0x0000985C
		public bool IsSpecial()
		{
			return vtkDICOMFilePath.vtkDICOMFilePath_IsSpecial_08(base.GetCppThis()) != 0;
		}

		// Token: 0x060002E4 RID: 740
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMFilePath_IsSymlink_09(HandleRef pThis);

		// Token: 0x060002E5 RID: 741 RVA: 0x0000B684 File Offset: 0x00009884
		public bool IsSymlink()
		{
			return vtkDICOMFilePath.vtkDICOMFilePath_IsSymlink_09(base.GetCppThis()) != 0;
		}

		// Token: 0x060002E6 RID: 742
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMFilePath_Join_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string second);

		// Token: 0x060002E7 RID: 743 RVA: 0x0000B6AC File Offset: 0x000098AC
		public string Join(string second)
		{
			return vtkDICOMFilePath.vtkDICOMFilePath_Join_10(base.GetCppThis(), second);
		}

		// Token: 0x060002E8 RID: 744
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMFilePath_Local_11(HandleRef pThis);

		// Token: 0x060002E9 RID: 745 RVA: 0x0000B6CC File Offset: 0x000098CC
		public string Local()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMFilePath.vtkDICOMFilePath_Local_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060002EA RID: 746
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMFilePath_PopBack_12(HandleRef pThis);

		// Token: 0x060002EB RID: 747 RVA: 0x0000B706 File Offset: 0x00009906
		public void PopBack()
		{
			vtkDICOMFilePath.vtkDICOMFilePath_PopBack_12(base.GetCppThis());
		}

		// Token: 0x060002EC RID: 748
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMFilePath_PopExtension_13(HandleRef pThis);

		// Token: 0x060002ED RID: 749 RVA: 0x0000B715 File Offset: 0x00009915
		public void PopExtension()
		{
			vtkDICOMFilePath.vtkDICOMFilePath_PopExtension_13(base.GetCppThis());
		}

		// Token: 0x060002EE RID: 750
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMFilePath_PushBack_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string path);

		// Token: 0x060002EF RID: 751 RVA: 0x0000B724 File Offset: 0x00009924
		public void PushBack(string path)
		{
			vtkDICOMFilePath.vtkDICOMFilePath_PushBack_14(base.GetCppThis(), path);
		}

		// Token: 0x060002F0 RID: 752
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMFilePath_PushExtension_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string path);

		// Token: 0x060002F1 RID: 753 RVA: 0x0000B734 File Offset: 0x00009934
		public void PushExtension(string path)
		{
			vtkDICOMFilePath.vtkDICOMFilePath_PushExtension_15(base.GetCppThis(), path);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000124 RID: 292
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMFilePath";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000125 RID: 293
		public new static readonly string MRClassNameKey = "class vtkDICOMFilePath";
	}
}
