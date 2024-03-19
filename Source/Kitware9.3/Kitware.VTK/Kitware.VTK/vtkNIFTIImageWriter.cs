using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNIFTIImageWriter
	/// </summary>
	/// <remarks>
	///    Write NIfTI-1 and NIfTI-2 medical image files
	///
	/// This class writes NIFTI files, either in .nii format or as separate
	/// .img and .hdr files.  If told to write a file that ends in ".gz",
	/// then the writer will automatically compress the file with zlib.
	/// Images of type unsigned char that have 3 or 4 scalar components
	/// will automatically be written as RGB or RGBA respectively.  Images
	/// of type float or double that have 2 components will automatically be
	/// written as complex values.
	/// @par Thanks:
	/// This class was contributed to VTK by the Calgary Image Processing and
	/// Analysis Centre (CIPAC).
	/// </remarks>
	/// <seealso>
	///
	/// vtkNIFTIImageReader
	/// </seealso>
	// Token: 0x02000798 RID: 1944
	public class vtkNIFTIImageWriter : vtkImageWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013F6A RID: 81770 RVA: 0x001C3221 File Offset: 0x001C1421
		static vtkNIFTIImageWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNIFTIImageWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNIFTIImageWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013F6B RID: 81771 RVA: 0x001C3249 File Offset: 0x001C1449
		public vtkNIFTIImageWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013F6C RID: 81772
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013F6D RID: 81773 RVA: 0x001C3258 File Offset: 0x001C1458
		public new static vtkNIFTIImageWriter New()
		{
			vtkNIFTIImageWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIImageWriter.vtkNIFTIImageWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNIFTIImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013F6E RID: 81774 RVA: 0x001C32AC File Offset: 0x001C14AC
		public vtkNIFTIImageWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNIFTIImageWriter.vtkNIFTIImageWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013F6F RID: 81775 RVA: 0x001C32F0 File Offset: 0x001C14F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013F70 RID: 81776
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageWriter_GetDescription_01(HandleRef pThis);

		/// <summary>
		/// Set a short description (max 80 chars) of how the file was produced.
		/// The default description is "VTKX.Y" where X.Y is the VTK version.
		/// </summary>
		// Token: 0x06013F71 RID: 81777 RVA: 0x001C32FC File Offset: 0x001C14FC
		public virtual string GetDescription()
		{
			string s = Marshal.PtrToStringAnsi(vtkNIFTIImageWriter.vtkNIFTIImageWriter_GetDescription_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013F72 RID: 81778
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageWriter_GetNIFTIHeader_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the NIFTI header information to use when writing the file.
		/// The data dimensions and pixdim from the supplied header will be
		/// ignored.  Likewise, the QForm and SForm information in the supplied
		/// header will be ignored if you have called SetQFormMatrix() or
		/// SetSFormMatrix() to provide the orientation information for the file.
		/// </summary>
		// Token: 0x06013F73 RID: 81779 RVA: 0x001C3338 File Offset: 0x001C1538
		public vtkNIFTIImageHeader GetNIFTIHeader()
		{
			vtkNIFTIImageHeader vtkNIFTIImageHeader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIImageWriter.vtkNIFTIImageWriter_GetNIFTIHeader_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013F74 RID: 81780
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageWriter_GetNIFTIVersion_03(HandleRef pThis);

		/// <summary>
		/// Set the version number for the NIfTI file format to use.
		/// This can be 1, 2, or 0 (the default).  If set to zero, then it
		/// will save as NIfTI version 1 unless SetNIFTIHeader() provided
		/// header information from a NIfTI version 2 file.
		/// </summary>
		// Token: 0x06013F75 RID: 81781 RVA: 0x001C33A8 File Offset: 0x001C15A8
		public virtual int GetNIFTIVersion()
		{
			return vtkNIFTIImageWriter.vtkNIFTIImageWriter_GetNIFTIVersion_03(base.GetCppThis());
		}

		// Token: 0x06013F76 RID: 81782
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIImageWriter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013F77 RID: 81783 RVA: 0x001C33C8 File Offset: 0x001C15C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNIFTIImageWriter.vtkNIFTIImageWriter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06013F78 RID: 81784
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIImageWriter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013F79 RID: 81785 RVA: 0x001C33E8 File Offset: 0x001C15E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNIFTIImageWriter.vtkNIFTIImageWriter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06013F7A RID: 81786
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkNIFTIImageWriter_GetPlanarRGB_06(HandleRef pThis);

		/// <summary>
		/// Write planar RGB (separate R, G, and B planes), rather than packed RGB.
		/// Use this option with extreme caution: the NIFTI standard requires RGB
		/// pixels to be packed.  The Analyze format, however, was used to store
		/// both planar RGB and packed RGB depending on the software, without any
		/// indication in the header about which convention was being used.
		/// </summary>
		// Token: 0x06013F7B RID: 81787 RVA: 0x001C3404 File Offset: 0x001C1604
		public virtual bool GetPlanarRGB()
		{
			return vtkNIFTIImageWriter.vtkNIFTIImageWriter_GetPlanarRGB_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06013F7C RID: 81788
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageWriter_GetQFac_07(HandleRef pThis);

		/// <summary>
		/// The QFac sets the ordering of the slices in the NIFTI file.
		/// If QFac is -1, then the slice ordering in the file will be reversed
		/// as compared to VTK. Use with caution.
		/// </summary>
		// Token: 0x06013F7D RID: 81789 RVA: 0x001C342C File Offset: 0x001C162C
		public virtual double GetQFac()
		{
			return vtkNIFTIImageWriter.vtkNIFTIImageWriter_GetQFac_07(base.GetCppThis());
		}

		// Token: 0x06013F7E RID: 81790
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageWriter_GetQFormMatrix_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the "qform" orientation and offset for the image data.
		/// The 3x3 portion of the matrix must be orthonormal and have a
		/// positive determinant, it will be used to compute the quaternion.
		/// The last column of the matrix will be used for the offset.
		/// In the NIFTI header, the qform_code will be set to 1.
		/// </summary>
		// Token: 0x06013F7F RID: 81791 RVA: 0x001C344C File Offset: 0x001C164C
		public vtkMatrix4x4 GetQFormMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIImageWriter.vtkNIFTIImageWriter_GetQFormMatrix_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013F80 RID: 81792
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageWriter_GetRescaleIntercept_09(HandleRef pThis);

		/// <summary>
		/// Set the slope and intercept for calibrating the scalar values.
		/// Other programs that read the NIFTI file can use the equation
		/// v = u*RescaleSlope + RescaleIntercept to rescale the data to
		/// real values.  If both the slope and the intercept are zero,
		/// then the SclSlope and SclIntercept in the header info provided
		/// via SetNIFTIHeader() are used instead.
		/// </summary>
		// Token: 0x06013F81 RID: 81793 RVA: 0x001C34BC File Offset: 0x001C16BC
		public virtual double GetRescaleIntercept()
		{
			return vtkNIFTIImageWriter.vtkNIFTIImageWriter_GetRescaleIntercept_09(base.GetCppThis());
		}

		// Token: 0x06013F82 RID: 81794
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageWriter_GetRescaleSlope_10(HandleRef pThis);

		/// <summary>
		/// Set the slope and intercept for calibrating the scalar values.
		/// Other programs that read the NIFTI file can use the equation
		/// v = u*RescaleSlope + RescaleIntercept to rescale the data to
		/// real values.  If both the slope and the intercept are zero,
		/// then the SclSlope and SclIntercept in the header info provided
		/// via SetNIFTIHeader() are used instead.
		/// </summary>
		// Token: 0x06013F83 RID: 81795 RVA: 0x001C34DC File Offset: 0x001C16DC
		public virtual double GetRescaleSlope()
		{
			return vtkNIFTIImageWriter.vtkNIFTIImageWriter_GetRescaleSlope_10(base.GetCppThis());
		}

		// Token: 0x06013F84 RID: 81796
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageWriter_GetSFormMatrix_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set a matrix for the "sform" transformation stored in the file.
		/// Unlike the qform matrix, the sform matrix can contain scaling
		/// information.  Before being stored in the NIFTI header, the
		/// first three columns of the matrix will be multiplied by the voxel
		/// spacing. In the NIFTI header, the sform_code will be set to 2.
		/// </summary>
		// Token: 0x06013F85 RID: 81797 RVA: 0x001C34FC File Offset: 0x001C16FC
		public vtkMatrix4x4 GetSFormMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIImageWriter.vtkNIFTIImageWriter_GetSFormMatrix_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013F86 RID: 81798
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageWriter_GetTimeDimension_12(HandleRef pThis);

		/// <summary>
		/// Set the time dimension to use in the NIFTI file (or zero if none).
		/// The number of components of the input data must be divisible by the time
		/// dimension if the time dimension is not set to zero.  The vector dimension
		/// will be set to the number of components divided by the time dimension.
		/// </summary>
		// Token: 0x06013F87 RID: 81799 RVA: 0x001C356C File Offset: 0x001C176C
		public virtual int GetTimeDimension()
		{
			return vtkNIFTIImageWriter.vtkNIFTIImageWriter_GetTimeDimension_12(base.GetCppThis());
		}

		// Token: 0x06013F88 RID: 81800
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageWriter_GetTimeSpacing_13(HandleRef pThis);

		/// <summary>
		/// Set the time dimension to use in the NIFTI file (or zero if none).
		/// The number of components of the input data must be divisible by the time
		/// dimension if the time dimension is not set to zero.  The vector dimension
		/// will be set to the number of components divided by the time dimension.
		/// </summary>
		// Token: 0x06013F89 RID: 81801 RVA: 0x001C358C File Offset: 0x001C178C
		public virtual double GetTimeSpacing()
		{
			return vtkNIFTIImageWriter.vtkNIFTIImageWriter_GetTimeSpacing_13(base.GetCppThis());
		}

		// Token: 0x06013F8A RID: 81802
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageWriter_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013F8B RID: 81803 RVA: 0x001C35AC File Offset: 0x001C17AC
		public override int IsA(string type)
		{
			return vtkNIFTIImageWriter.vtkNIFTIImageWriter_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06013F8C RID: 81804
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageWriter_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013F8D RID: 81805 RVA: 0x001C35CC File Offset: 0x001C17CC
		public new static int IsTypeOf(string type)
		{
			return vtkNIFTIImageWriter.vtkNIFTIImageWriter_IsTypeOf_15(type);
		}

		// Token: 0x06013F8E RID: 81806
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageWriter_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013F8F RID: 81807 RVA: 0x001C35E8 File Offset: 0x001C17E8
		public new vtkNIFTIImageWriter NewInstance()
		{
			vtkNIFTIImageWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIImageWriter.vtkNIFTIImageWriter_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNIFTIImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013F90 RID: 81808
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageWriter_PlanarRGBOff_18(HandleRef pThis);

		/// <summary>
		/// Write planar RGB (separate R, G, and B planes), rather than packed RGB.
		/// Use this option with extreme caution: the NIFTI standard requires RGB
		/// pixels to be packed.  The Analyze format, however, was used to store
		/// both planar RGB and packed RGB depending on the software, without any
		/// indication in the header about which convention was being used.
		/// </summary>
		// Token: 0x06013F91 RID: 81809 RVA: 0x001C3642 File Offset: 0x001C1842
		public virtual void PlanarRGBOff()
		{
			vtkNIFTIImageWriter.vtkNIFTIImageWriter_PlanarRGBOff_18(base.GetCppThis());
		}

		// Token: 0x06013F92 RID: 81810
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageWriter_PlanarRGBOn_19(HandleRef pThis);

		/// <summary>
		/// Write planar RGB (separate R, G, and B planes), rather than packed RGB.
		/// Use this option with extreme caution: the NIFTI standard requires RGB
		/// pixels to be packed.  The Analyze format, however, was used to store
		/// both planar RGB and packed RGB depending on the software, without any
		/// indication in the header about which convention was being used.
		/// </summary>
		// Token: 0x06013F93 RID: 81811 RVA: 0x001C3651 File Offset: 0x001C1851
		public virtual void PlanarRGBOn()
		{
			vtkNIFTIImageWriter.vtkNIFTIImageWriter_PlanarRGBOn_19(base.GetCppThis());
		}

		// Token: 0x06013F94 RID: 81812
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageWriter_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013F95 RID: 81813 RVA: 0x001C3660 File Offset: 0x001C1860
		public new static vtkNIFTIImageWriter SafeDownCast(vtkObjectBase o)
		{
			vtkNIFTIImageWriter vtkNIFTIImageWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIImageWriter.vtkNIFTIImageWriter_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNIFTIImageWriter = (vtkNIFTIImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNIFTIImageWriter.Register(null);
				}
			}
			return vtkNIFTIImageWriter;
		}

		// Token: 0x06013F96 RID: 81814
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageWriter_SetDescription_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set a short description (max 80 chars) of how the file was produced.
		/// The default description is "VTKX.Y" where X.Y is the VTK version.
		/// </summary>
		// Token: 0x06013F97 RID: 81815 RVA: 0x001C36DF File Offset: 0x001C18DF
		public virtual void SetDescription(string _arg)
		{
			vtkNIFTIImageWriter.vtkNIFTIImageWriter_SetDescription_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F98 RID: 81816
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageWriter_SetNIFTIHeader_22(HandleRef pThis, HandleRef hdr);

		/// <summary>
		/// Set the NIFTI header information to use when writing the file.
		/// The data dimensions and pixdim from the supplied header will be
		/// ignored.  Likewise, the QForm and SForm information in the supplied
		/// header will be ignored if you have called SetQFormMatrix() or
		/// SetSFormMatrix() to provide the orientation information for the file.
		/// </summary>
		// Token: 0x06013F99 RID: 81817 RVA: 0x001C36F0 File Offset: 0x001C18F0
		public void SetNIFTIHeader(vtkNIFTIImageHeader hdr)
		{
			vtkNIFTIImageWriter.vtkNIFTIImageWriter_SetNIFTIHeader_22(base.GetCppThis(), (hdr == null) ? default(HandleRef) : hdr.GetCppThis());
		}

		// Token: 0x06013F9A RID: 81818
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageWriter_SetNIFTIVersion_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the version number for the NIfTI file format to use.
		/// This can be 1, 2, or 0 (the default).  If set to zero, then it
		/// will save as NIfTI version 1 unless SetNIFTIHeader() provided
		/// header information from a NIfTI version 2 file.
		/// </summary>
		// Token: 0x06013F9B RID: 81819 RVA: 0x001C371F File Offset: 0x001C191F
		public virtual void SetNIFTIVersion(int _arg)
		{
			vtkNIFTIImageWriter.vtkNIFTIImageWriter_SetNIFTIVersion_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F9C RID: 81820
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageWriter_SetPlanarRGB_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// Write planar RGB (separate R, G, and B planes), rather than packed RGB.
		/// Use this option with extreme caution: the NIFTI standard requires RGB
		/// pixels to be packed.  The Analyze format, however, was used to store
		/// both planar RGB and packed RGB depending on the software, without any
		/// indication in the header about which convention was being used.
		/// </summary>
		// Token: 0x06013F9D RID: 81821 RVA: 0x001C372F File Offset: 0x001C192F
		public virtual void SetPlanarRGB(bool _arg)
		{
			vtkNIFTIImageWriter.vtkNIFTIImageWriter_SetPlanarRGB_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06013F9E RID: 81822
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageWriter_SetQFac_25(HandleRef pThis, double _arg);

		/// <summary>
		/// The QFac sets the ordering of the slices in the NIFTI file.
		/// If QFac is -1, then the slice ordering in the file will be reversed
		/// as compared to VTK. Use with caution.
		/// </summary>
		// Token: 0x06013F9F RID: 81823 RVA: 0x001C3747 File Offset: 0x001C1947
		public virtual void SetQFac(double _arg)
		{
			vtkNIFTIImageWriter.vtkNIFTIImageWriter_SetQFac_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06013FA0 RID: 81824
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageWriter_SetQFormMatrix_26(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the "qform" orientation and offset for the image data.
		/// The 3x3 portion of the matrix must be orthonormal and have a
		/// positive determinant, it will be used to compute the quaternion.
		/// The last column of the matrix will be used for the offset.
		/// In the NIFTI header, the qform_code will be set to 1.
		/// </summary>
		// Token: 0x06013FA1 RID: 81825 RVA: 0x001C3758 File Offset: 0x001C1958
		public void SetQFormMatrix(vtkMatrix4x4 arg0)
		{
			vtkNIFTIImageWriter.vtkNIFTIImageWriter_SetQFormMatrix_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06013FA2 RID: 81826
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageWriter_SetRescaleIntercept_27(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the slope and intercept for calibrating the scalar values.
		/// Other programs that read the NIFTI file can use the equation
		/// v = u*RescaleSlope + RescaleIntercept to rescale the data to
		/// real values.  If both the slope and the intercept are zero,
		/// then the SclSlope and SclIntercept in the header info provided
		/// via SetNIFTIHeader() are used instead.
		/// </summary>
		// Token: 0x06013FA3 RID: 81827 RVA: 0x001C3787 File Offset: 0x001C1987
		public virtual void SetRescaleIntercept(double _arg)
		{
			vtkNIFTIImageWriter.vtkNIFTIImageWriter_SetRescaleIntercept_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06013FA4 RID: 81828
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageWriter_SetRescaleSlope_28(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the slope and intercept for calibrating the scalar values.
		/// Other programs that read the NIFTI file can use the equation
		/// v = u*RescaleSlope + RescaleIntercept to rescale the data to
		/// real values.  If both the slope and the intercept are zero,
		/// then the SclSlope and SclIntercept in the header info provided
		/// via SetNIFTIHeader() are used instead.
		/// </summary>
		// Token: 0x06013FA5 RID: 81829 RVA: 0x001C3797 File Offset: 0x001C1997
		public virtual void SetRescaleSlope(double _arg)
		{
			vtkNIFTIImageWriter.vtkNIFTIImageWriter_SetRescaleSlope_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06013FA6 RID: 81830
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageWriter_SetSFormMatrix_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set a matrix for the "sform" transformation stored in the file.
		/// Unlike the qform matrix, the sform matrix can contain scaling
		/// information.  Before being stored in the NIFTI header, the
		/// first three columns of the matrix will be multiplied by the voxel
		/// spacing. In the NIFTI header, the sform_code will be set to 2.
		/// </summary>
		// Token: 0x06013FA7 RID: 81831 RVA: 0x001C37A8 File Offset: 0x001C19A8
		public void SetSFormMatrix(vtkMatrix4x4 arg0)
		{
			vtkNIFTIImageWriter.vtkNIFTIImageWriter_SetSFormMatrix_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06013FA8 RID: 81832
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageWriter_SetTimeDimension_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the time dimension to use in the NIFTI file (or zero if none).
		/// The number of components of the input data must be divisible by the time
		/// dimension if the time dimension is not set to zero.  The vector dimension
		/// will be set to the number of components divided by the time dimension.
		/// </summary>
		// Token: 0x06013FA9 RID: 81833 RVA: 0x001C37D7 File Offset: 0x001C19D7
		public virtual void SetTimeDimension(int _arg)
		{
			vtkNIFTIImageWriter.vtkNIFTIImageWriter_SetTimeDimension_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06013FAA RID: 81834
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageWriter_SetTimeSpacing_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the time dimension to use in the NIFTI file (or zero if none).
		/// The number of components of the input data must be divisible by the time
		/// dimension if the time dimension is not set to zero.  The vector dimension
		/// will be set to the number of components divided by the time dimension.
		/// </summary>
		// Token: 0x06013FAB RID: 81835 RVA: 0x001C37E7 File Offset: 0x001C19E7
		public virtual void SetTimeSpacing(double _arg)
		{
			vtkNIFTIImageWriter.vtkNIFTIImageWriter_SetTimeSpacing_31(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001730 RID: 5936
		public new const string MRFullTypeName = "Kitware.VTK.vtkNIFTIImageWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001731 RID: 5937
		public new static readonly string MRClassNameKey = "class vtkNIFTIImageWriter";
	}
}
