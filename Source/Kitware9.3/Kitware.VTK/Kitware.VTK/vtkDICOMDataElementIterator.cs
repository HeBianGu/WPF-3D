using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000052 RID: 82
	public class vtkDICOMDataElementIterator : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000E09 RID: 3593 RVA: 0x0001AC23 File Offset: 0x00018E23
		static vtkDICOMDataElementIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMDataElementIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMDataElementIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000E0A RID: 3594 RVA: 0x0001AC4B File Offset: 0x00018E4B
		public vtkDICOMDataElementIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000E0B RID: 3595 RVA: 0x0001AC59 File Offset: 0x00018E59
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000E0C RID: 3596
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDataElementIterator_Get(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000E0D RID: 3597 RVA: 0x0001AC64 File Offset: 0x00018E64
		public vtkDICOMDataElement Get()
		{
			vtkDICOMDataElement result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDataElementIterator.vtkDICOMDataElementIterator_Get(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMDataElement)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000E0E RID: 3598
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMDataElementIterator_Next(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000E0F RID: 3599 RVA: 0x0001ACC0 File Offset: 0x00018EC0
		public vtkDICOMDataElementIterator Next()
		{
			vtkDICOMDataElementIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMDataElementIterator.vtkDICOMDataElementIterator_Next(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMDataElementIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000E10 RID: 3600
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMDataElementIterator_NotEqual(HandleRef pThis, HandleRef pOther);

		// Token: 0x06000E11 RID: 3601 RVA: 0x0001AD1C File Offset: 0x00018F1C
		public static bool operator !=(vtkDICOMDataElementIterator a, vtkDICOMDataElementIterator b)
		{
			return vtkDICOMDataElementIterator.vtkDICOMDataElementIterator_NotEqual(a.GetCppThis(), b.GetCppThis()) != 0;
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x0001AD48 File Offset: 0x00018F48
		public static bool operator ==(vtkDICOMDataElementIterator a, vtkDICOMDataElementIterator b)
		{
			bool flag = vtkDICOMDataElementIterator.vtkDICOMDataElementIterator_NotEqual(a.GetCppThis(), b.GetCppThis()) != 0;
			return !flag;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000426 RID: 1062
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMDataElementIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000427 RID: 1063
		public new static readonly string MRClassNameKey = "class vtkDICOMDataElementIterator";
	}
}
