using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000014 RID: 20
	public class vtkDICOMTagPath : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600032D RID: 813 RVA: 0x0000BB8E File Offset: 0x00009D8E
		static vtkDICOMTagPath()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMTagPath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMTagPath"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600032E RID: 814 RVA: 0x0000BBB6 File Offset: 0x00009DB6
		public vtkDICOMTagPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600032F RID: 815 RVA: 0x0000BBC4 File Offset: 0x00009DC4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000330 RID: 816
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMTagPath_GetHead_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000331 RID: 817 RVA: 0x0000BBD0 File Offset: 0x00009DD0
		public vtkDICOMTag GetHead()
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMTagPath.vtkDICOMTagPath_GetHead_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000332 RID: 818
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDICOMTagPath_GetIndex_02(HandleRef pThis);

		// Token: 0x06000333 RID: 819 RVA: 0x0000BC2C File Offset: 0x00009E2C
		public uint GetIndex()
		{
			return vtkDICOMTagPath.vtkDICOMTagPath_GetIndex_02(base.GetCppThis());
		}

		// Token: 0x06000334 RID: 820
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDICOMTagPath_GetIndex_03(HandleRef pThis, uint i);

		// Token: 0x06000335 RID: 821 RVA: 0x0000BC4C File Offset: 0x00009E4C
		public uint GetIndex(uint i)
		{
			return vtkDICOMTagPath.vtkDICOMTagPath_GetIndex_03(base.GetCppThis(), i);
		}

		// Token: 0x06000336 RID: 822
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDICOMTagPath_GetSize_04(HandleRef pThis);

		// Token: 0x06000337 RID: 823 RVA: 0x0000BC6C File Offset: 0x00009E6C
		public uint GetSize()
		{
			return vtkDICOMTagPath.vtkDICOMTagPath_GetSize_04(base.GetCppThis());
		}

		// Token: 0x06000338 RID: 824
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMTagPath_GetTag_05(HandleRef pThis, uint i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000339 RID: 825 RVA: 0x0000BC8C File Offset: 0x00009E8C
		public vtkDICOMTag GetTag(uint i)
		{
			vtkDICOMTag result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMTagPath.vtkDICOMTagPath_GetTag_05(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600033A RID: 826
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDICOMTagPath vtkDICOMTagPath_GetTail_06(HandleRef pThis);

		// Token: 0x0600033B RID: 827 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		public vtkDICOMTagPath GetTail()
		{
			return vtkDICOMTagPath.vtkDICOMTagPath_GetTail_06(base.GetCppThis());
		}

		// Token: 0x0600033C RID: 828
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMTagPath_HasTail_07(HandleRef pThis);

		// Token: 0x0600033D RID: 829 RVA: 0x0000BD08 File Offset: 0x00009F08
		public bool HasTail()
		{
			return vtkDICOMTagPath.vtkDICOMTagPath_HasTail_07(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000142 RID: 322
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMTagPath";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000143 RID: 323
		public new static readonly string MRClassNameKey = "class vtkDICOMTagPath";
	}
}
