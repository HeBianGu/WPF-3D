using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x0200000B RID: 11
	public class vtkDICOMDictionary : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060002C4 RID: 708 RVA: 0x0000B34F File Offset: 0x0000954F
		static vtkDICOMDictionary()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMDictionary.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMDictionary"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060002C5 RID: 709 RVA: 0x0000B377 File Offset: 0x00009577
		public vtkDICOMDictionary(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060002C6 RID: 710 RVA: 0x0000B385 File Offset: 0x00009585
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060002C7 RID: 711
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDictionary_FindDictEntry_01(HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060002C8 RID: 712 RVA: 0x0000B390 File Offset: 0x00009590
		public static vtkDICOMDictEntry FindDictEntry(vtkDICOMTag tag)
		{
			vtkDICOMDictEntry result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDictionary.vtkDICOMDictionary_FindDictEntry_01((tag == null) ? default(HandleRef) : tag.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMDictEntry)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060002C9 RID: 713
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDictionary_FindDictEntry_02([MarshalAs(UnmanagedType.LPUTF8Str)] string key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060002CA RID: 714 RVA: 0x0000B3FC File Offset: 0x000095FC
		public static vtkDICOMDictEntry FindDictEntry(string key)
		{
			vtkDICOMDictEntry result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDictionary.vtkDICOMDictionary_FindDictEntry_02(key, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMDictEntry)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060002CB RID: 715
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDictionary_FindDictEntry_03(HandleRef tag, [MarshalAs(UnmanagedType.LPUTF8Str)] string privateDict, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060002CC RID: 716 RVA: 0x0000B454 File Offset: 0x00009654
		public static vtkDICOMDictEntry FindDictEntry(vtkDICOMTag tag, string privateDict)
		{
			vtkDICOMDictEntry result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDictionary.vtkDICOMDictionary_FindDictEntry_03((tag == null) ? default(HandleRef) : tag.GetCppThis(), privateDict, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMDictEntry)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060002CD RID: 717
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDictionary_FindDictEntry_04([MarshalAs(UnmanagedType.LPUTF8Str)] string key, [MarshalAs(UnmanagedType.LPUTF8Str)] string privateDict, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060002CE RID: 718 RVA: 0x0000B4C0 File Offset: 0x000096C0
		public static vtkDICOMDictEntry FindDictEntry(string key, string privateDict)
		{
			vtkDICOMDictEntry result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDictionary.vtkDICOMDictionary_FindDictEntry_04(key, privateDict, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMDictEntry)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060002CF RID: 719
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMDictionary_RemovePrivateDictionary_05([MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		// Token: 0x060002D0 RID: 720 RVA: 0x0000B516 File Offset: 0x00009716
		public static void RemovePrivateDictionary(string name)
		{
			vtkDICOMDictionary.vtkDICOMDictionary_RemovePrivateDictionary_05(name);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000122 RID: 290
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMDictionary";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000123 RID: 291
		public new static readonly string MRClassNameKey = "class vtkDICOMDictionary";
	}
}
