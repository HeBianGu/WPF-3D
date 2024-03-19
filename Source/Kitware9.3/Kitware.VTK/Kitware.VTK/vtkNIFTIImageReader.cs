using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNIFTIImageReader
	/// </summary>
	/// <remarks>
	///    Read NIfTI-1 and NIfTI-2 medical image files
	///
	/// This class reads NIFTI files, either in .nii format or as separate
	/// .img and .hdr files.  If two files are used, then they can be passed
	/// by using SetFileNames() instead of SetFileName().  Files ending in .gz
	/// are decompressed on-the-fly while they are being read.  Files with
	/// complex numbers or vector dimensions will be read as multi-component
	/// images.  If a NIFTI file has a time dimension, then by default only the
	/// first image in the time series will be read, but the TimeAsVector
	/// flag can be set to read the time steps as vector components.  Files in
	/// Analyze 7.5 format are also supported by this reader.
	/// @par Thanks:
	/// This class was contributed to VTK by the Calgary Image Processing and
	/// Analysis Centre (CIPAC).
	/// </remarks>
	/// <seealso>
	///
	/// vtkNIFTIImageWriter, vtkNIFTIImageHeader
	/// </seealso>
	// Token: 0x02000797 RID: 1943
	public class vtkNIFTIImageReader : vtkImageReader2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013F32 RID: 81714 RVA: 0x001C2CAF File Offset: 0x001C0EAF
		static vtkNIFTIImageReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNIFTIImageReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNIFTIImageReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013F33 RID: 81715 RVA: 0x001C2CD7 File Offset: 0x001C0ED7
		public vtkNIFTIImageReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013F34 RID: 81716
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013F35 RID: 81717 RVA: 0x001C2CE8 File Offset: 0x001C0EE8
		public new static vtkNIFTIImageReader New()
		{
			vtkNIFTIImageReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIImageReader.vtkNIFTIImageReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNIFTIImageReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013F36 RID: 81718 RVA: 0x001C2D3C File Offset: 0x001C0F3C
		public vtkNIFTIImageReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNIFTIImageReader.vtkNIFTIImageReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013F37 RID: 81719 RVA: 0x001C2D80 File Offset: 0x001C0F80
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013F38 RID: 81720
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		/// Return true if this reader can read the given file.
		/// </summary>
		// Token: 0x06013F39 RID: 81721 RVA: 0x001C2D8C File Offset: 0x001C0F8C
		public override int CanReadFile(string filename)
		{
			return vtkNIFTIImageReader.vtkNIFTIImageReader_CanReadFile_01(base.GetCppThis(), filename);
		}

		// Token: 0x06013F3A RID: 81722
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageReader_GetDescriptiveName_02(HandleRef pThis);

		/// <summary>
		/// Return a descriptive name that might be useful in a GUI.
		/// </summary>
		// Token: 0x06013F3B RID: 81723 RVA: 0x001C2DAC File Offset: 0x001C0FAC
		public override string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkNIFTIImageReader.vtkNIFTIImageReader_GetDescriptiveName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013F3C RID: 81724
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageReader_GetFileExtensions_03(HandleRef pThis);

		/// <summary>
		/// Valid extensions for this file type.
		/// </summary>
		// Token: 0x06013F3D RID: 81725 RVA: 0x001C2DE8 File Offset: 0x001C0FE8
		public override string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkNIFTIImageReader.vtkNIFTIImageReader_GetFileExtensions_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013F3E RID: 81726
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageReader_GetNIFTIHeader_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the raw header information from the NIfTI file.
		/// </summary>
		// Token: 0x06013F3F RID: 81727 RVA: 0x001C2E24 File Offset: 0x001C1024
		public vtkNIFTIImageHeader GetNIFTIHeader()
		{
			vtkNIFTIImageHeader vtkNIFTIImageHeader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIImageReader.vtkNIFTIImageReader_GetNIFTIHeader_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNIFTIImageHeader = (vtkNIFTIImageHeader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNIFTIImageHeader.Register(null);
				}
			}
			return vtkNIFTIImageHeader;
		}

		// Token: 0x06013F40 RID: 81728
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIImageReader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013F41 RID: 81729 RVA: 0x001C2E94 File Offset: 0x001C1094
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNIFTIImageReader.vtkNIFTIImageReader_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06013F42 RID: 81730
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIImageReader_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013F43 RID: 81731 RVA: 0x001C2EB4 File Offset: 0x001C10B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNIFTIImageReader.vtkNIFTIImageReader_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06013F44 RID: 81732
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkNIFTIImageReader_GetPlanarRGB_07(HandleRef pThis);

		/// <summary>
		/// Read planar RGB (separate R, G, and B planes), rather than packed RGB.
		/// The NIFTI format should always use packed RGB.  The Analyze format,
		/// however, was used to store both planar RGB and packed RGB depending
		/// on the software, without any indication in the header about which
		/// convention was being used.  Use this if you have a planar RGB file.
		/// </summary>
		// Token: 0x06013F45 RID: 81733 RVA: 0x001C2ED0 File Offset: 0x001C10D0
		public virtual bool GetPlanarRGB()
		{
			return vtkNIFTIImageReader.vtkNIFTIImageReader_GetPlanarRGB_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06013F46 RID: 81734
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageReader_GetQFac_08(HandleRef pThis);

		/// <summary>
		/// QFac gives the slice order in the NIFTI file versus the VTK image.
		/// If QFac is -1, then the VTK slice index K is related to the NIFTI
		/// slice index k by the equation K = (num_slices - k - 1).  VTK requires
		/// the slices to be ordered so that the voxel indices (I,J,K) provide a
		/// right-handed coordinate system, whereas NIFTI does not.  Instead,
		/// NIFTI stores a factor called "qfac" in the header to signal when the
		/// (i,j,k) indices form a left-handed coordinate system.  QFac will only
		/// ever have values of +1 or -1.
		/// </summary>
		// Token: 0x06013F47 RID: 81735 RVA: 0x001C2EF8 File Offset: 0x001C10F8
		public double GetQFac()
		{
			return vtkNIFTIImageReader.vtkNIFTIImageReader_GetQFac_08(base.GetCppThis());
		}

		// Token: 0x06013F48 RID: 81736
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageReader_GetQFormMatrix_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a matrix that gives the "qform" orientation and offset for the data.
		/// If no qform matrix was stored in the file, the return value is nullptr.
		/// This matrix will transform VTK data coordinates into the NIFTI oriented
		/// data coordinates, where +X points right, +Y points anterior (toward the
		/// front), and +Z points superior (toward the head). The qform matrix will
		/// always have a positive determinant. The offset that is stored in the
		/// matrix gives the position of the first pixel in the first slice of the
		/// VTK image data.  Note that if QFac is -1, then the first slice in the
		/// VTK image data is the last slice in the NIFTI file, and the Z offset
		/// will automatically be adjusted to compensate for this.
		/// </summary>
		// Token: 0x06013F49 RID: 81737 RVA: 0x001C2F18 File Offset: 0x001C1118
		public vtkMatrix4x4 GetQFormMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIImageReader.vtkNIFTIImageReader_GetQFormMatrix_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x06013F4A RID: 81738
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageReader_GetRescaleIntercept_10(HandleRef pThis);

		/// <summary>
		/// Get the slope and intercept for rescaling the scalar values.
		/// These values allow calibration of the data to real values.
		/// Use the equation v = u*RescaleSlope + RescaleIntercept.
		/// This directly returns the values stored in the scl_slope and
		/// scl_inter fields in the NIFTI header.
		/// </summary>
		// Token: 0x06013F4B RID: 81739 RVA: 0x001C2F88 File Offset: 0x001C1188
		public double GetRescaleIntercept()
		{
			return vtkNIFTIImageReader.vtkNIFTIImageReader_GetRescaleIntercept_10(base.GetCppThis());
		}

		// Token: 0x06013F4C RID: 81740
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageReader_GetRescaleSlope_11(HandleRef pThis);

		/// <summary>
		/// Get the slope and intercept for rescaling the scalar values.
		/// These values allow calibration of the data to real values.
		/// Use the equation v = u*RescaleSlope + RescaleIntercept.
		/// This directly returns the values stored in the scl_slope and
		/// scl_inter fields in the NIFTI header.
		/// </summary>
		// Token: 0x06013F4D RID: 81741 RVA: 0x001C2FA8 File Offset: 0x001C11A8
		public double GetRescaleSlope()
		{
			return vtkNIFTIImageReader.vtkNIFTIImageReader_GetRescaleSlope_11(base.GetCppThis());
		}

		// Token: 0x06013F4E RID: 81742
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageReader_GetSFormMatrix_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a matrix that gives the "sform" orientation and offset for the data.
		/// If no sform matrix was stored in the file, the return value is nullptr.
		/// Like the qform matrix, this matrix will transform VTK data coordinates
		/// into a NIFTI coordinate system.  Unlike the qform matrix, the sform
		/// matrix can contain scaling information and can even (rarely) have
		/// a negative determinant, i.e. a flip.  This matrix is modified slightly
		/// as compared to the sform matrix stored in the NIFTI header: the pixdim
		/// pixel spacing is factored out.  Also, if QFac is -1, then the VTK slices
		/// are in reverse order as compared to the NIFTI slices, hence as compared
		/// to the sform matrix stored in the header, the third column of this matrix
		/// is multiplied by -1 and the Z offset is shifted to compensate for the
		/// fact that the last slice has become the first.
		/// </summary>
		// Token: 0x06013F4F RID: 81743 RVA: 0x001C2FC8 File Offset: 0x001C11C8
		public vtkMatrix4x4 GetSFormMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIImageReader.vtkNIFTIImageReader_GetSFormMatrix_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x06013F50 RID: 81744
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkNIFTIImageReader_GetTimeAsVector_13(HandleRef pThis);

		/// <summary>
		/// Read the time dimension as scalar components (default: Off).
		/// If this is on, then each time point will be stored as a component in
		/// the image data.  If the file has both a time dimension and a vector
		/// dimension, then the number of components will be the product of these
		/// two dimensions, i.e. the components will store a sequence of vectors.
		/// </summary>
		// Token: 0x06013F51 RID: 81745 RVA: 0x001C3038 File Offset: 0x001C1238
		public virtual bool GetTimeAsVector()
		{
			return vtkNIFTIImageReader.vtkNIFTIImageReader_GetTimeAsVector_13(base.GetCppThis()) != 0;
		}

		// Token: 0x06013F52 RID: 81746
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageReader_GetTimeDimension_14(HandleRef pThis);

		/// <summary>
		/// Get the time dimension that was stored in the NIFTI header.
		/// </summary>
		// Token: 0x06013F53 RID: 81747 RVA: 0x001C3060 File Offset: 0x001C1260
		public int GetTimeDimension()
		{
			return vtkNIFTIImageReader.vtkNIFTIImageReader_GetTimeDimension_14(base.GetCppThis());
		}

		// Token: 0x06013F54 RID: 81748
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageReader_GetTimeSpacing_15(HandleRef pThis);

		/// <summary>
		/// Get the time dimension that was stored in the NIFTI header.
		/// </summary>
		// Token: 0x06013F55 RID: 81749 RVA: 0x001C3080 File Offset: 0x001C1280
		public double GetTimeSpacing()
		{
			return vtkNIFTIImageReader.vtkNIFTIImageReader_GetTimeSpacing_15(base.GetCppThis());
		}

		// Token: 0x06013F56 RID: 81750
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageReader_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013F57 RID: 81751 RVA: 0x001C30A0 File Offset: 0x001C12A0
		public override int IsA(string type)
		{
			return vtkNIFTIImageReader.vtkNIFTIImageReader_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06013F58 RID: 81752
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageReader_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013F59 RID: 81753 RVA: 0x001C30C0 File Offset: 0x001C12C0
		public new static int IsTypeOf(string type)
		{
			return vtkNIFTIImageReader.vtkNIFTIImageReader_IsTypeOf_17(type);
		}

		// Token: 0x06013F5A RID: 81754
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageReader_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013F5B RID: 81755 RVA: 0x001C30DC File Offset: 0x001C12DC
		public new vtkNIFTIImageReader NewInstance()
		{
			vtkNIFTIImageReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIImageReader.vtkNIFTIImageReader_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNIFTIImageReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013F5C RID: 81756
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageReader_PlanarRGBOff_20(HandleRef pThis);

		/// <summary>
		/// Read planar RGB (separate R, G, and B planes), rather than packed RGB.
		/// The NIFTI format should always use packed RGB.  The Analyze format,
		/// however, was used to store both planar RGB and packed RGB depending
		/// on the software, without any indication in the header about which
		/// convention was being used.  Use this if you have a planar RGB file.
		/// </summary>
		// Token: 0x06013F5D RID: 81757 RVA: 0x001C3136 File Offset: 0x001C1336
		public virtual void PlanarRGBOff()
		{
			vtkNIFTIImageReader.vtkNIFTIImageReader_PlanarRGBOff_20(base.GetCppThis());
		}

		// Token: 0x06013F5E RID: 81758
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageReader_PlanarRGBOn_21(HandleRef pThis);

		/// <summary>
		/// Read planar RGB (separate R, G, and B planes), rather than packed RGB.
		/// The NIFTI format should always use packed RGB.  The Analyze format,
		/// however, was used to store both planar RGB and packed RGB depending
		/// on the software, without any indication in the header about which
		/// convention was being used.  Use this if you have a planar RGB file.
		/// </summary>
		// Token: 0x06013F5F RID: 81759 RVA: 0x001C3145 File Offset: 0x001C1345
		public virtual void PlanarRGBOn()
		{
			vtkNIFTIImageReader.vtkNIFTIImageReader_PlanarRGBOn_21(base.GetCppThis());
		}

		// Token: 0x06013F60 RID: 81760
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageReader_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013F61 RID: 81761 RVA: 0x001C3154 File Offset: 0x001C1354
		public new static vtkNIFTIImageReader SafeDownCast(vtkObjectBase o)
		{
			vtkNIFTIImageReader vtkNIFTIImageReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIImageReader.vtkNIFTIImageReader_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNIFTIImageReader = (vtkNIFTIImageReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNIFTIImageReader.Register(null);
				}
			}
			return vtkNIFTIImageReader;
		}

		// Token: 0x06013F62 RID: 81762
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageReader_SetPlanarRGB_23(HandleRef pThis, byte _arg);

		/// <summary>
		/// Read planar RGB (separate R, G, and B planes), rather than packed RGB.
		/// The NIFTI format should always use packed RGB.  The Analyze format,
		/// however, was used to store both planar RGB and packed RGB depending
		/// on the software, without any indication in the header about which
		/// convention was being used.  Use this if you have a planar RGB file.
		/// </summary>
		// Token: 0x06013F63 RID: 81763 RVA: 0x001C31D3 File Offset: 0x001C13D3
		public virtual void SetPlanarRGB(bool _arg)
		{
			vtkNIFTIImageReader.vtkNIFTIImageReader_SetPlanarRGB_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06013F64 RID: 81764
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageReader_SetTimeAsVector_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// Read the time dimension as scalar components (default: Off).
		/// If this is on, then each time point will be stored as a component in
		/// the image data.  If the file has both a time dimension and a vector
		/// dimension, then the number of components will be the product of these
		/// two dimensions, i.e. the components will store a sequence of vectors.
		/// </summary>
		// Token: 0x06013F65 RID: 81765 RVA: 0x001C31EB File Offset: 0x001C13EB
		public virtual void SetTimeAsVector(bool _arg)
		{
			vtkNIFTIImageReader.vtkNIFTIImageReader_SetTimeAsVector_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06013F66 RID: 81766
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageReader_TimeAsVectorOff_25(HandleRef pThis);

		/// <summary>
		/// Read the time dimension as scalar components (default: Off).
		/// If this is on, then each time point will be stored as a component in
		/// the image data.  If the file has both a time dimension and a vector
		/// dimension, then the number of components will be the product of these
		/// two dimensions, i.e. the components will store a sequence of vectors.
		/// </summary>
		// Token: 0x06013F67 RID: 81767 RVA: 0x001C3203 File Offset: 0x001C1403
		public virtual void TimeAsVectorOff()
		{
			vtkNIFTIImageReader.vtkNIFTIImageReader_TimeAsVectorOff_25(base.GetCppThis());
		}

		// Token: 0x06013F68 RID: 81768
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageReader_TimeAsVectorOn_26(HandleRef pThis);

		/// <summary>
		/// Read the time dimension as scalar components (default: Off).
		/// If this is on, then each time point will be stored as a component in
		/// the image data.  If the file has both a time dimension and a vector
		/// dimension, then the number of components will be the product of these
		/// two dimensions, i.e. the components will store a sequence of vectors.
		/// </summary>
		// Token: 0x06013F69 RID: 81769 RVA: 0x001C3212 File Offset: 0x001C1412
		public virtual void TimeAsVectorOn()
		{
			vtkNIFTIImageReader.vtkNIFTIImageReader_TimeAsVectorOn_26(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400172E RID: 5934
		public new const string MRFullTypeName = "Kitware.VTK.vtkNIFTIImageReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400172F RID: 5935
		public new static readonly string MRClassNameKey = "class vtkNIFTIImageReader";
	}
}
