using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMetaImageReader
	/// </summary>
	/// <remarks>
	///    read binary UNC meta image data
	///
	/// One of the formats for which a reader is already available in the toolkit is
	/// the MetaImage file format. This is a fairly simple yet powerful format
	/// consisting of a text header and a binary data section. The following
	/// instructions describe how you can write a MetaImage header for the data that
	/// you download from the BrainWeb page.
	///
	/// The minimal structure of the MetaImage header is the following:
	///
	///    NDims = 3
	///    DimSize = 181 217 181
	///    ElementType = MET_UCHAR
	///    ElementSpacing = 1.0 1.0 1.0
	///    ElementByteOrderMSB = False
	///    ElementDataFile = brainweb1.raw
	///
	///    * NDims indicate that this is a 3D image. ITK can handle images of
	///      arbitrary dimension.
	///    * DimSize indicates the size of the volume in pixels along each
	///      direction.
	///    * ElementType indicate the primitive type used for pixels. In this case
	///      is "unsigned char", implying that the data is digitized in 8 bits /
	///      pixel.
	///    * ElementSpacing indicates the physical separation between the center of
	///      one pixel and the center of the next pixel along each direction in space.
	///      The units used are millimeters.
	///    * ElementByteOrderMSB indicates is the data is encoded in little or big
	///      endian order. You might want to play with this value when moving data
	///      between different computer platforms.
	///    * ElementDataFile is the name of the file containing the raw binary data
	///      of the image. This file must be in the same directory as the header.
	///
	/// MetaImage headers are expected to have extension: ".mha" or ".mhd"
	///
	/// Once you write this header text file, it should be possible to read the
	/// image into your ITK based application using the itk::FileIOToImageFilter
	/// class.
	///
	///
	///
	/// </remarks>
	// Token: 0x0200078D RID: 1933
	public class vtkMetaImageReader : vtkImageReader2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013E10 RID: 81424 RVA: 0x001C1633 File Offset: 0x001BF833
		static vtkMetaImageReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMetaImageReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMetaImageReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013E11 RID: 81425 RVA: 0x001C165B File Offset: 0x001BF85B
		public vtkMetaImageReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013E12 RID: 81426
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E13 RID: 81427 RVA: 0x001C166C File Offset: 0x001BF86C
		public new static vtkMetaImageReader New()
		{
			vtkMetaImageReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMetaImageReader.vtkMetaImageReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMetaImageReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E14 RID: 81428 RVA: 0x001C16C0 File Offset: 0x001BF8C0
		public vtkMetaImageReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMetaImageReader.vtkMetaImageReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013E15 RID: 81429 RVA: 0x001C1704 File Offset: 0x001BF904
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013E16 RID: 81430
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMetaImageReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Test whether the file with the given name can be read by this
		/// reader.
		/// </summary>
		// Token: 0x06013E17 RID: 81431 RVA: 0x001C1710 File Offset: 0x001BF910
		public override int CanReadFile(string name)
		{
			return vtkMetaImageReader.vtkMetaImageReader_CanReadFile_01(base.GetCppThis(), name);
		}

		// Token: 0x06013E18 RID: 81432
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_GetAnatomicalOrientation_02(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E19 RID: 81433 RVA: 0x001C1730 File Offset: 0x001BF930
		public virtual string GetAnatomicalOrientation()
		{
			string s = Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetAnatomicalOrientation_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E1A RID: 81434
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMetaImageReader_GetBitsAllocated_03(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E1B RID: 81435 RVA: 0x001C176C File Offset: 0x001BF96C
		public virtual int GetBitsAllocated()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetBitsAllocated_03(base.GetCppThis());
		}

		// Token: 0x06013E1C RID: 81436
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMetaImageReader_GetDataByteOrder_04(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E1D RID: 81437 RVA: 0x001C178C File Offset: 0x001BF98C
		public override int GetDataByteOrder()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetDataByteOrder_04(base.GetCppThis());
		}

		// Token: 0x06013E1E RID: 81438
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_GetDate_05(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E1F RID: 81439 RVA: 0x001C17AC File Offset: 0x001BF9AC
		public virtual string GetDate()
		{
			string s = Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetDate_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E20 RID: 81440
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_GetDescriptiveName_06(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E21 RID: 81441 RVA: 0x001C17E8 File Offset: 0x001BF9E8
		public override string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetDescriptiveName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E22 RID: 81442
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_GetDistanceUnits_07(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E23 RID: 81443 RVA: 0x001C1824 File Offset: 0x001BFA24
		public virtual string GetDistanceUnits()
		{
			string s = Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetDistanceUnits_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E24 RID: 81444
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_GetFileExtensions_08(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E25 RID: 81445 RVA: 0x001C1860 File Offset: 0x001BFA60
		public override string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetFileExtensions_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E26 RID: 81446
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMetaImageReader_GetGantryAngle_09(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E27 RID: 81447 RVA: 0x001C189C File Offset: 0x001BFA9C
		public virtual double GetGantryAngle()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetGantryAngle_09(base.GetCppThis());
		}

		// Token: 0x06013E28 RID: 81448
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMetaImageReader_GetHeight_10(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E29 RID: 81449 RVA: 0x001C18BC File Offset: 0x001BFABC
		public int GetHeight()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetHeight_10(base.GetCppThis());
		}

		// Token: 0x06013E2A RID: 81450
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_GetImageNumber_11(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E2B RID: 81451 RVA: 0x001C18DC File Offset: 0x001BFADC
		public virtual string GetImageNumber()
		{
			string s = Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetImageNumber_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E2C RID: 81452
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_GetImagePositionPatient_12(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E2D RID: 81453 RVA: 0x001C1918 File Offset: 0x001BFB18
		public IntPtr GetImagePositionPatient()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetImagePositionPatient_12(base.GetCppThis());
		}

		// Token: 0x06013E2E RID: 81454
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_GetModality_13(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E2F RID: 81455 RVA: 0x001C1938 File Offset: 0x001BFB38
		public virtual string GetModality()
		{
			string s = Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetModality_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E30 RID: 81456
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMetaImageReader_GetNumberOfComponents_14(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E31 RID: 81457 RVA: 0x001C1974 File Offset: 0x001BFB74
		public int GetNumberOfComponents()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetNumberOfComponents_14(base.GetCppThis());
		}

		// Token: 0x06013E32 RID: 81458
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMetaImageReader_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E33 RID: 81459 RVA: 0x001C1994 File Offset: 0x001BFB94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x06013E34 RID: 81460
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMetaImageReader_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E35 RID: 81461 RVA: 0x001C19B4 File Offset: 0x001BFBB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x06013E36 RID: 81462
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_GetPatientID_17(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E37 RID: 81463 RVA: 0x001C19D0 File Offset: 0x001BFBD0
		public virtual string GetPatientID()
		{
			string s = Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetPatientID_17(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E38 RID: 81464
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_GetPatientName_18(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E39 RID: 81465 RVA: 0x001C1A0C File Offset: 0x001BFC0C
		public virtual string GetPatientName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetPatientName_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E3A RID: 81466
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMetaImageReader_GetPixelRepresentation_19(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E3B RID: 81467 RVA: 0x001C1A48 File Offset: 0x001BFC48
		public int GetPixelRepresentation()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetPixelRepresentation_19(base.GetCppThis());
		}

		// Token: 0x06013E3C RID: 81468
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_GetPixelSpacing_20(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E3D RID: 81469 RVA: 0x001C1A68 File Offset: 0x001BFC68
		public IntPtr GetPixelSpacing()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetPixelSpacing_20(base.GetCppThis());
		}

		// Token: 0x06013E3E RID: 81470
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMetaImageReader_GetRescaleOffset_21(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E3F RID: 81471 RVA: 0x001C1A88 File Offset: 0x001BFC88
		public virtual double GetRescaleOffset()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetRescaleOffset_21(base.GetCppThis());
		}

		// Token: 0x06013E40 RID: 81472
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMetaImageReader_GetRescaleSlope_22(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E41 RID: 81473 RVA: 0x001C1AA8 File Offset: 0x001BFCA8
		public virtual double GetRescaleSlope()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetRescaleSlope_22(base.GetCppThis());
		}

		// Token: 0x06013E42 RID: 81474
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_GetSeries_23(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E43 RID: 81475 RVA: 0x001C1AC8 File Offset: 0x001BFCC8
		public virtual string GetSeries()
		{
			string s = Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetSeries_23(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E44 RID: 81476
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_GetStudyID_24(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E45 RID: 81477 RVA: 0x001C1B04 File Offset: 0x001BFD04
		public virtual string GetStudyID()
		{
			string s = Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetStudyID_24(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E46 RID: 81478
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_GetStudyUID_25(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E47 RID: 81479 RVA: 0x001C1B40 File Offset: 0x001BFD40
		public virtual string GetStudyUID()
		{
			string s = Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetStudyUID_25(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E48 RID: 81480
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_GetTransferSyntaxUID_26(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E49 RID: 81481 RVA: 0x001C1B7C File Offset: 0x001BFD7C
		public virtual string GetTransferSyntaxUID()
		{
			string s = Marshal.PtrToStringAnsi(vtkMetaImageReader.vtkMetaImageReader_GetTransferSyntaxUID_26(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E4A RID: 81482
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMetaImageReader_GetWidth_27(HandleRef pThis);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E4B RID: 81483 RVA: 0x001C1BB8 File Offset: 0x001BFDB8
		public int GetWidth()
		{
			return vtkMetaImageReader.vtkMetaImageReader_GetWidth_27(base.GetCppThis());
		}

		// Token: 0x06013E4C RID: 81484
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMetaImageReader_IsA_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E4D RID: 81485 RVA: 0x001C1BD8 File Offset: 0x001BFDD8
		public override int IsA(string type)
		{
			return vtkMetaImageReader.vtkMetaImageReader_IsA_28(base.GetCppThis(), type);
		}

		// Token: 0x06013E4E RID: 81486
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMetaImageReader_IsTypeOf_29([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E4F RID: 81487 RVA: 0x001C1BF8 File Offset: 0x001BFDF8
		public new static int IsTypeOf(string type)
		{
			return vtkMetaImageReader.vtkMetaImageReader_IsTypeOf_29(type);
		}

		// Token: 0x06013E50 RID: 81488
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E51 RID: 81489 RVA: 0x001C1C14 File Offset: 0x001BFE14
		public new vtkMetaImageReader NewInstance()
		{
			vtkMetaImageReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMetaImageReader.vtkMetaImageReader_NewInstance_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMetaImageReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013E52 RID: 81490
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageReader_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E53 RID: 81491 RVA: 0x001C1C70 File Offset: 0x001BFE70
		public new static vtkMetaImageReader SafeDownCast(vtkObjectBase o)
		{
			vtkMetaImageReader vtkMetaImageReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMetaImageReader.vtkMetaImageReader_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMetaImageReader = (vtkMetaImageReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMetaImageReader.Register(null);
				}
			}
			return vtkMetaImageReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016CE RID: 5838
		public new const string MRFullTypeName = "Kitware.VTK.vtkMetaImageReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016CF RID: 5839
		public new static readonly string MRClassNameKey = "class vtkMetaImageReader";
	}
}
