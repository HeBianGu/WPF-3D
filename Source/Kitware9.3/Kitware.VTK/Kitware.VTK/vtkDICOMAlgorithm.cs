using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// \class vtkDICOMAlgorithm
	/// \brief Superclass for DICOM image filters
	///
	/// This class allows the DICOM meta data to be carried by the VTK pipeline.
	/// Subclasses should always call Superclass::RequestInformation() and
	/// Superclass::RequestData within their own RequestInformation and
	/// RequestData methods.
	/// </summary>
	// Token: 0x0200003B RID: 59
	public class vtkDICOMAlgorithm : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000A36 RID: 2614 RVA: 0x00015BF7 File Offset: 0x00013DF7
		static vtkDICOMAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000A37 RID: 2615 RVA: 0x00015C1F File Offset: 0x00013E1F
		public vtkDICOMAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000A38 RID: 2616
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A39 RID: 2617 RVA: 0x00015C30 File Offset: 0x00013E30
		public new static vtkDICOMAlgorithm New()
		{
			vtkDICOMAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMAlgorithm.vtkDICOMAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A3A RID: 2618 RVA: 0x00015C84 File Offset: 0x00013E84
		public vtkDICOMAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMAlgorithm.vtkDICOMAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000A3B RID: 2619 RVA: 0x00015CC8 File Offset: 0x00013EC8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000A3C RID: 2620
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A3D RID: 2621 RVA: 0x00015CD4 File Offset: 0x00013ED4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMAlgorithm.vtkDICOMAlgorithm_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06000A3E RID: 2622
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMAlgorithm_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A3F RID: 2623 RVA: 0x00015CF4 File Offset: 0x00013EF4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMAlgorithm.vtkDICOMAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06000A40 RID: 2624
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMAlgorithm_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A41 RID: 2625 RVA: 0x00015D10 File Offset: 0x00013F10
		public override int IsA(string type)
		{
			return vtkDICOMAlgorithm.vtkDICOMAlgorithm_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06000A42 RID: 2626
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMAlgorithm_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A43 RID: 2627 RVA: 0x00015D30 File Offset: 0x00013F30
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMAlgorithm.vtkDICOMAlgorithm_IsTypeOf_04(type);
		}

		// Token: 0x06000A44 RID: 2628
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMAlgorithm_META_DATA_05(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A45 RID: 2629 RVA: 0x00015D4C File Offset: 0x00013F4C
		public static vtkInformationDataObjectKey META_DATA()
		{
			vtkInformationDataObjectKey vtkInformationDataObjectKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMAlgorithm.vtkDICOMAlgorithm_META_DATA_05(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDataObjectKey = (vtkInformationDataObjectKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDataObjectKey.Register(null);
				}
			}
			return vtkInformationDataObjectKey;
		}

		// Token: 0x06000A46 RID: 2630
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMAlgorithm_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A47 RID: 2631 RVA: 0x00015DB8 File Offset: 0x00013FB8
		public new vtkDICOMAlgorithm NewInstance()
		{
			vtkDICOMAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMAlgorithm.vtkDICOMAlgorithm_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000A48 RID: 2632
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMAlgorithm_PATIENT_MATRIX_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A49 RID: 2633 RVA: 0x00015E14 File Offset: 0x00014014
		public static vtkInformationDoubleVectorKey PATIENT_MATRIX()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMAlgorithm.vtkDICOMAlgorithm_PATIENT_MATRIX_08(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		// Token: 0x06000A4A RID: 2634
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMAlgorithm_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A4B RID: 2635 RVA: 0x00015E80 File Offset: 0x00014080
		public new static vtkDICOMAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMAlgorithm vtkDICOMAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMAlgorithm.vtkDICOMAlgorithm_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMAlgorithm = (vtkDICOMAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMAlgorithm.Register(null);
				}
			}
			return vtkDICOMAlgorithm;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003A5 RID: 933
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003A6 RID: 934
		public new static readonly string MRClassNameKey = "class vtkDICOMAlgorithm";
	}
}
