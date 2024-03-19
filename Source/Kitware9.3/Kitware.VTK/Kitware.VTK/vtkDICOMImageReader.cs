using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDICOMImageReader
	/// </summary>
	/// <remarks>
	///    Reads some DICOM images
	///
	/// DICOM (stands for Digital Imaging in COmmunications and Medicine)
	/// is a medical image file format widely used to exchange data, provided
	/// by various modalities.
	/// @warning
	/// This reader might eventually handle ACR-NEMA file (predecessor of the DICOM
	/// format for medical images).
	/// This reader does not handle encapsulated format, only plain raw file are
	/// handled. This reader also does not handle multi-frames DICOM datasets.
	/// @warning
	/// Internally DICOMParser assumes the x,y pixel spacing is stored in 0028,0030 and
	/// that z spacing is stored in Slice Thickness (correct only when slice were acquired
	/// contiguous): 0018,0050. Which means this is only valid for some rare
	/// MR Image Storage
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBMPReader vtkPNMReader vtkTIFFReader
	/// </seealso>
	// Token: 0x02000760 RID: 1888
	public class vtkDICOMImageReader : vtkImageReader2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060139A5 RID: 80293 RVA: 0x001BB3A9 File Offset: 0x001B95A9
		static vtkDICOMImageReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMImageReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMImageReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060139A6 RID: 80294 RVA: 0x001BB3D1 File Offset: 0x001B95D1
		public vtkDICOMImageReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060139A7 RID: 80295
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMImageReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x060139A8 RID: 80296 RVA: 0x001BB3E0 File Offset: 0x001B95E0
		public new static vtkDICOMImageReader New()
		{
			vtkDICOMImageReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMImageReader.vtkDICOMImageReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMImageReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x060139A9 RID: 80297 RVA: 0x001BB434 File Offset: 0x001B9634
		public vtkDICOMImageReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMImageReader.vtkDICOMImageReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060139AA RID: 80298 RVA: 0x001BB478 File Offset: 0x001B9678
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060139AB RID: 80299
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMImageReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Get the gantry angle for the last image processed.
		/// </summary>
		// Token: 0x060139AC RID: 80300 RVA: 0x001BB484 File Offset: 0x001B9684
		public override int CanReadFile(string fname)
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		// Token: 0x060139AD RID: 80301
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMImageReader_GetBitsAllocated_02(HandleRef pThis);

		/// <summary>
		/// Get the number of bits allocated for each pixel in the file.
		/// </summary>
		// Token: 0x060139AE RID: 80302 RVA: 0x001BB4A4 File Offset: 0x001B96A4
		public int GetBitsAllocated()
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetBitsAllocated_02(base.GetCppThis());
		}

		// Token: 0x060139AF RID: 80303
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMImageReader_GetDescriptiveName_03(HandleRef pThis);

		/// <summary>
		/// Return a descriptive name for the file format that might be useful in a GUI.
		/// </summary>
		// Token: 0x060139B0 RID: 80304 RVA: 0x001BB4C4 File Offset: 0x001B96C4
		public override string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMImageReader.vtkDICOMImageReader_GetDescriptiveName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060139B1 RID: 80305
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMImageReader_GetDirectoryName_04(HandleRef pThis);

		/// <summary>
		/// Returns the directory name.
		/// </summary>
		// Token: 0x060139B2 RID: 80306 RVA: 0x001BB500 File Offset: 0x001B9700
		public virtual string GetDirectoryName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMImageReader.vtkDICOMImageReader_GetDirectoryName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060139B3 RID: 80307
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMImageReader_GetFileExtensions_05(HandleRef pThis);

		/// <summary>
		/// Get the gantry angle for the last image processed.
		/// </summary>
		// Token: 0x060139B4 RID: 80308 RVA: 0x001BB53C File Offset: 0x001B973C
		public override string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMImageReader.vtkDICOMImageReader_GetFileExtensions_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060139B5 RID: 80309
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkDICOMImageReader_GetGantryAngle_06(HandleRef pThis);

		/// <summary>
		/// Get the gantry angle for the last image processed.
		/// </summary>
		// Token: 0x060139B6 RID: 80310 RVA: 0x001BB578 File Offset: 0x001B9778
		public float GetGantryAngle()
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetGantryAngle_06(base.GetCppThis());
		}

		// Token: 0x060139B7 RID: 80311
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMImageReader_GetHeight_07(HandleRef pThis);

		/// <summary>
		/// Returns the image height.
		/// </summary>
		// Token: 0x060139B8 RID: 80312 RVA: 0x001BB598 File Offset: 0x001B9798
		public int GetHeight()
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetHeight_07(base.GetCppThis());
		}

		// Token: 0x060139B9 RID: 80313
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMImageReader_GetImageOrientationPatient_08(HandleRef pThis);

		/// <summary>
		/// Get the (DICOM) directions cosines. It consist of the components
		/// of the first two vectors. The third vector needs to be computed
		/// to form an orthonormal basis.
		/// </summary>
		// Token: 0x060139BA RID: 80314 RVA: 0x001BB5B8 File Offset: 0x001B97B8
		public float[] GetImageOrientationPatient()
		{
			IntPtr intPtr = vtkDICOMImageReader.vtkDICOMImageReader_GetImageOrientationPatient_08(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060139BB RID: 80315
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMImageReader_GetImagePositionPatient_09(HandleRef pThis);

		/// <summary>
		/// Get the (DICOM) x,y,z coordinates of the first pixel in the
		/// image (upper left hand corner) of the last image processed by the
		/// DICOMParser
		/// </summary>
		// Token: 0x060139BC RID: 80316 RVA: 0x001BB600 File Offset: 0x001B9800
		public float[] GetImagePositionPatient()
		{
			IntPtr intPtr = vtkDICOMImageReader.vtkDICOMImageReader_GetImagePositionPatient_09(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060139BD RID: 80317
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMImageReader_GetNumberOfComponents_10(HandleRef pThis);

		/// <summary>
		/// Get the number of components of the image data for the last
		/// image processed.
		/// </summary>
		// Token: 0x060139BE RID: 80318 RVA: 0x001BB648 File Offset: 0x001B9848
		public int GetNumberOfComponents()
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetNumberOfComponents_10(base.GetCppThis());
		}

		// Token: 0x060139BF RID: 80319
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMImageReader_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x060139C0 RID: 80320 RVA: 0x001BB668 File Offset: 0x001B9868
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x060139C1 RID: 80321
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMImageReader_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x060139C2 RID: 80322 RVA: 0x001BB688 File Offset: 0x001B9888
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x060139C3 RID: 80323
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMImageReader_GetPatientName_13(HandleRef pThis);

		/// <summary>
		/// Get the patient name for the last image processed.
		/// </summary>
		// Token: 0x060139C4 RID: 80324 RVA: 0x001BB6A4 File Offset: 0x001B98A4
		public string GetPatientName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMImageReader.vtkDICOMImageReader_GetPatientName_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060139C5 RID: 80325
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMImageReader_GetPixelRepresentation_14(HandleRef pThis);

		/// <summary>
		/// Get the pixel representation of the last image processed by the
		/// DICOMParser. A zero is a unsigned quantity.  A one indicates a
		/// signed quantity
		/// </summary>
		// Token: 0x060139C6 RID: 80326 RVA: 0x001BB6E0 File Offset: 0x001B98E0
		public int GetPixelRepresentation()
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetPixelRepresentation_14(base.GetCppThis());
		}

		// Token: 0x060139C7 RID: 80327
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMImageReader_GetPixelSpacing_15(HandleRef pThis);

		/// <summary>
		/// Returns the pixel spacing (in X, Y, Z).
		/// Note: if there is only one slice, the Z spacing is set to the slice
		/// thickness. If there is more than one slice, it is set to the distance
		/// between the first two slices.
		/// </summary>
		// Token: 0x060139C8 RID: 80328 RVA: 0x001BB700 File Offset: 0x001B9900
		public double[] GetPixelSpacing()
		{
			IntPtr intPtr = vtkDICOMImageReader.vtkDICOMImageReader_GetPixelSpacing_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060139C9 RID: 80329
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkDICOMImageReader_GetRescaleOffset_16(HandleRef pThis);

		/// <summary>
		/// Get the rescale offset for the pixel data.
		/// </summary>
		// Token: 0x060139CA RID: 80330 RVA: 0x001BB748 File Offset: 0x001B9948
		public float GetRescaleOffset()
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetRescaleOffset_16(base.GetCppThis());
		}

		// Token: 0x060139CB RID: 80331
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkDICOMImageReader_GetRescaleSlope_17(HandleRef pThis);

		/// <summary>
		/// Get the rescale slope for the pixel data.
		/// </summary>
		// Token: 0x060139CC RID: 80332 RVA: 0x001BB768 File Offset: 0x001B9968
		public float GetRescaleSlope()
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetRescaleSlope_17(base.GetCppThis());
		}

		// Token: 0x060139CD RID: 80333
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMImageReader_GetStudyID_18(HandleRef pThis);

		/// <summary>
		/// Get the Study ID for the last image processed.
		/// </summary>
		// Token: 0x060139CE RID: 80334 RVA: 0x001BB788 File Offset: 0x001B9988
		public string GetStudyID()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMImageReader.vtkDICOMImageReader_GetStudyID_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060139CF RID: 80335
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMImageReader_GetStudyUID_19(HandleRef pThis);

		/// <summary>
		/// Get the study uid for the last image processed.
		/// </summary>
		// Token: 0x060139D0 RID: 80336 RVA: 0x001BB7C4 File Offset: 0x001B99C4
		public string GetStudyUID()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMImageReader.vtkDICOMImageReader_GetStudyUID_19(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060139D1 RID: 80337
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMImageReader_GetTransferSyntaxUID_20(HandleRef pThis);

		/// <summary>
		/// Get the transfer syntax UID for the last image processed.
		/// </summary>
		// Token: 0x060139D2 RID: 80338 RVA: 0x001BB800 File Offset: 0x001B9A00
		public string GetTransferSyntaxUID()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMImageReader.vtkDICOMImageReader_GetTransferSyntaxUID_20(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060139D3 RID: 80339
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMImageReader_GetWidth_21(HandleRef pThis);

		/// <summary>
		/// Returns the image width.
		/// </summary>
		// Token: 0x060139D4 RID: 80340 RVA: 0x001BB83C File Offset: 0x001B9A3C
		public int GetWidth()
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_GetWidth_21(base.GetCppThis());
		}

		// Token: 0x060139D5 RID: 80341
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMImageReader_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x060139D6 RID: 80342 RVA: 0x001BB85C File Offset: 0x001B9A5C
		public override int IsA(string type)
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x060139D7 RID: 80343
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMImageReader_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x060139D8 RID: 80344 RVA: 0x001BB87C File Offset: 0x001B9A7C
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMImageReader.vtkDICOMImageReader_IsTypeOf_23(type);
		}

		// Token: 0x060139D9 RID: 80345
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMImageReader_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x060139DA RID: 80346 RVA: 0x001BB898 File Offset: 0x001B9A98
		public new vtkDICOMImageReader NewInstance()
		{
			vtkDICOMImageReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMImageReader.vtkDICOMImageReader_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMImageReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060139DB RID: 80347
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMImageReader_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x060139DC RID: 80348 RVA: 0x001BB8F4 File Offset: 0x001B9AF4
		public new static vtkDICOMImageReader SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMImageReader vtkDICOMImageReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMImageReader.vtkDICOMImageReader_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMImageReader = (vtkDICOMImageReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMImageReader.Register(null);
				}
			}
			return vtkDICOMImageReader;
		}

		// Token: 0x060139DD RID: 80349
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMImageReader_SetDirectoryName_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string dn);

		/// <summary>
		/// Set the directory name for the reader to look in for DICOM
		/// files. If this method is used, the reader will try to find
		/// all the DICOM files in a directory. It will select the subset
		/// corresponding to the first series UID it stumbles across and
		/// it will try to build an ordered volume from them based on
		/// the slice number. The volume building will be upgraded to
		/// something more sophisticated in the future.
		/// </summary>
		// Token: 0x060139DE RID: 80350 RVA: 0x001BB973 File Offset: 0x001B9B73
		public void SetDirectoryName(string dn)
		{
			vtkDICOMImageReader.vtkDICOMImageReader_SetDirectoryName_27(base.GetCppThis(), dn);
		}

		// Token: 0x060139DF RID: 80351
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMImageReader_SetFileName_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fn);

		/// <summary>
		/// Set the filename for the file to read. If this method is used,
		/// the reader will only read a single file.
		/// </summary>
		// Token: 0x060139E0 RID: 80352 RVA: 0x001BB983 File Offset: 0x001B9B83
		public override void SetFileName(string fn)
		{
			vtkDICOMImageReader.vtkDICOMImageReader_SetFileName_28(base.GetCppThis(), fn);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400169E RID: 5790
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMImageReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400169F RID: 5791
		public new static readonly string MRClassNameKey = "class vtkDICOMImageReader";
	}
}
