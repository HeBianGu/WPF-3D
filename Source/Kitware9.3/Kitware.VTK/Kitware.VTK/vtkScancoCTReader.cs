using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// \class vtkScancoCTReader
	/// \brief Read SCANCO ISQ and AIM medical image files
	///
	/// This class reads ISQ and AIM files, which are used for high-resolution
	/// computed tomography.  The information that it provides uses different
	/// units as compared to the original files: all distances are given in
	/// millimeters (instead of micrometers), times are given in milliseconds
	/// (instead of microseconds), voltage and current given in kV and mA
	/// (instead of volts and microamps).  If the scanner was calibrated, then
	/// the data values can be converted to calibrated units.  To convert
	/// to linear attenuation coefficients [cm^-1], simply divide the data
	/// values by the MuScaling.  To convert to density values, multiply
	/// the data values by the RescaleSlope and add the RescaleIntercept.
	/// To convert to Hounsfield units, multiply by 1000/(MuScaling*MuWater)
	/// and subtract 1000.
	///
	/// Created at the Calgary Image Processing and Analysis Centre (CIPAC).
	/// </summary>
	// Token: 0x02000051 RID: 81
	public class vtkScancoCTReader : vtkImageReader2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000DA3 RID: 3491 RVA: 0x0001A3AF File Offset: 0x000185AF
		static vtkScancoCTReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScancoCTReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScancoCTReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000DA4 RID: 3492 RVA: 0x0001A3D7 File Offset: 0x000185D7
		public vtkScancoCTReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000DA5 RID: 3493
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScancoCTReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DA6 RID: 3494 RVA: 0x0001A3E8 File Offset: 0x000185E8
		public new static vtkScancoCTReader New()
		{
			vtkScancoCTReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScancoCTReader.vtkScancoCTReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScancoCTReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DA7 RID: 3495 RVA: 0x0001A43C File Offset: 0x0001863C
		public vtkScancoCTReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkScancoCTReader.vtkScancoCTReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000DA8 RID: 3496 RVA: 0x0001A480 File Offset: 0x00018680
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000DA9 RID: 3497
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScancoCTReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DAA RID: 3498 RVA: 0x0001A48C File Offset: 0x0001868C
		public override int CanReadFile(string filename)
		{
			return vtkScancoCTReader.vtkScancoCTReader_CanReadFile_01(base.GetCppThis(), filename);
		}

		// Token: 0x06000DAB RID: 3499
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScancoCTReader_GetCalibrationData_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DAC RID: 3500 RVA: 0x0001A4AC File Offset: 0x000186AC
		public string GetCalibrationData()
		{
			string s = Marshal.PtrToStringAnsi(vtkScancoCTReader.vtkScancoCTReader_GetCalibrationData_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000DAD RID: 3501
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScancoCTReader_GetCreationDate_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DAE RID: 3502 RVA: 0x0001A4E8 File Offset: 0x000186E8
		public string GetCreationDate()
		{
			string s = Marshal.PtrToStringAnsi(vtkScancoCTReader.vtkScancoCTReader_GetCreationDate_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000DAF RID: 3503
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScancoCTReader_GetDataRange_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DB0 RID: 3504 RVA: 0x0001A524 File Offset: 0x00018724
		public virtual double[] GetDataRange()
		{
			IntPtr intPtr = vtkScancoCTReader.vtkScancoCTReader_GetDataRange_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000DB1 RID: 3505
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScancoCTReader_GetDataRange_05(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DB2 RID: 3506 RVA: 0x0001A56C File Offset: 0x0001876C
		public virtual void GetDataRange(ref double _arg1, ref double _arg2)
		{
			vtkScancoCTReader.vtkScancoCTReader_GetDataRange_05(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06000DB3 RID: 3507
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScancoCTReader_GetDataRange_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DB4 RID: 3508 RVA: 0x0001A57D File Offset: 0x0001877D
		public virtual void GetDataRange(IntPtr _arg)
		{
			vtkScancoCTReader.vtkScancoCTReader_GetDataRange_06(base.GetCppThis(), _arg);
		}

		// Token: 0x06000DB5 RID: 3509
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScancoCTReader_GetDescriptiveName_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DB6 RID: 3510 RVA: 0x0001A590 File Offset: 0x00018790
		public override string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkScancoCTReader.vtkScancoCTReader_GetDescriptiveName_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000DB7 RID: 3511
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScancoCTReader_GetEndPosition_08(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DB8 RID: 3512 RVA: 0x0001A5CC File Offset: 0x000187CC
		public double GetEndPosition()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetEndPosition_08(base.GetCppThis());
		}

		// Token: 0x06000DB9 RID: 3513
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScancoCTReader_GetEnergy_09(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DBA RID: 3514 RVA: 0x0001A5EC File Offset: 0x000187EC
		public double GetEnergy()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetEnergy_09(base.GetCppThis());
		}

		// Token: 0x06000DBB RID: 3515
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScancoCTReader_GetFileExtensions_10(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DBC RID: 3516 RVA: 0x0001A60C File Offset: 0x0001880C
		public override string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkScancoCTReader.vtkScancoCTReader_GetFileExtensions_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000DBD RID: 3517
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScancoCTReader_GetIntensity_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DBE RID: 3518 RVA: 0x0001A648 File Offset: 0x00018848
		public double GetIntensity()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetIntensity_11(base.GetCppThis());
		}

		// Token: 0x06000DBF RID: 3519
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScancoCTReader_GetMeasurementIndex_12(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DC0 RID: 3520 RVA: 0x0001A668 File Offset: 0x00018868
		public int GetMeasurementIndex()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetMeasurementIndex_12(base.GetCppThis());
		}

		// Token: 0x06000DC1 RID: 3521
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScancoCTReader_GetModificationDate_13(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DC2 RID: 3522 RVA: 0x0001A688 File Offset: 0x00018888
		public string GetModificationDate()
		{
			string s = Marshal.PtrToStringAnsi(vtkScancoCTReader.vtkScancoCTReader_GetModificationDate_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000DC3 RID: 3523
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScancoCTReader_GetMuScaling_14(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DC4 RID: 3524 RVA: 0x0001A6C4 File Offset: 0x000188C4
		public double GetMuScaling()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetMuScaling_14(base.GetCppThis());
		}

		// Token: 0x06000DC5 RID: 3525
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScancoCTReader_GetMuWater_15(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DC6 RID: 3526 RVA: 0x0001A6E4 File Offset: 0x000188E4
		public double GetMuWater()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetMuWater_15(base.GetCppThis());
		}

		// Token: 0x06000DC7 RID: 3527
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScancoCTReader_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DC8 RID: 3528 RVA: 0x0001A704 File Offset: 0x00018904
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x06000DC9 RID: 3529
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScancoCTReader_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DCA RID: 3530 RVA: 0x0001A724 File Offset: 0x00018924
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x06000DCB RID: 3531
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScancoCTReader_GetNumberOfProjections_18(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DCC RID: 3532 RVA: 0x0001A740 File Offset: 0x00018940
		public int GetNumberOfProjections()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetNumberOfProjections_18(base.GetCppThis());
		}

		// Token: 0x06000DCD RID: 3533
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScancoCTReader_GetNumberOfSamples_19(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DCE RID: 3534 RVA: 0x0001A760 File Offset: 0x00018960
		public int GetNumberOfSamples()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetNumberOfSamples_19(base.GetCppThis());
		}

		// Token: 0x06000DCF RID: 3535
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScancoCTReader_GetPatientIndex_20(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DD0 RID: 3536 RVA: 0x0001A780 File Offset: 0x00018980
		public int GetPatientIndex()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetPatientIndex_20(base.GetCppThis());
		}

		// Token: 0x06000DD1 RID: 3537
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScancoCTReader_GetPatientName_21(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DD2 RID: 3538 RVA: 0x0001A7A0 File Offset: 0x000189A0
		public string GetPatientName()
		{
			string s = Marshal.PtrToStringAnsi(vtkScancoCTReader.vtkScancoCTReader_GetPatientName_21(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000DD3 RID: 3539
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScancoCTReader_GetRawHeader_22(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DD4 RID: 3540 RVA: 0x0001A7DC File Offset: 0x000189DC
		public IntPtr GetRawHeader()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetRawHeader_22(base.GetCppThis());
		}

		// Token: 0x06000DD5 RID: 3541
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScancoCTReader_GetReconstructionAlg_23(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DD6 RID: 3542 RVA: 0x0001A7FC File Offset: 0x000189FC
		public int GetReconstructionAlg()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetReconstructionAlg_23(base.GetCppThis());
		}

		// Token: 0x06000DD7 RID: 3543
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScancoCTReader_GetReferenceLine_24(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DD8 RID: 3544 RVA: 0x0001A81C File Offset: 0x00018A1C
		public double GetReferenceLine()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetReferenceLine_24(base.GetCppThis());
		}

		// Token: 0x06000DD9 RID: 3545
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScancoCTReader_GetRescaleIntercept_25(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DDA RID: 3546 RVA: 0x0001A83C File Offset: 0x00018A3C
		public double GetRescaleIntercept()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetRescaleIntercept_25(base.GetCppThis());
		}

		// Token: 0x06000DDB RID: 3547
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScancoCTReader_GetRescaleSlope_26(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DDC RID: 3548 RVA: 0x0001A85C File Offset: 0x00018A5C
		public double GetRescaleSlope()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetRescaleSlope_26(base.GetCppThis());
		}

		// Token: 0x06000DDD RID: 3549
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScancoCTReader_GetRescaleType_27(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DDE RID: 3550 RVA: 0x0001A87C File Offset: 0x00018A7C
		public int GetRescaleType()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetRescaleType_27(base.GetCppThis());
		}

		// Token: 0x06000DDF RID: 3551
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScancoCTReader_GetRescaleUnits_28(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DE0 RID: 3552 RVA: 0x0001A89C File Offset: 0x00018A9C
		public string GetRescaleUnits()
		{
			string s = Marshal.PtrToStringAnsi(vtkScancoCTReader.vtkScancoCTReader_GetRescaleUnits_28(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000DE1 RID: 3553
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScancoCTReader_GetSampleTime_29(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DE2 RID: 3554 RVA: 0x0001A8D8 File Offset: 0x00018AD8
		public double GetSampleTime()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetSampleTime_29(base.GetCppThis());
		}

		// Token: 0x06000DE3 RID: 3555
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScancoCTReader_GetScanDimensionsPhysical_30(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DE4 RID: 3556 RVA: 0x0001A8F8 File Offset: 0x00018AF8
		public virtual double[] GetScanDimensionsPhysical()
		{
			IntPtr intPtr = vtkScancoCTReader.vtkScancoCTReader_GetScanDimensionsPhysical_30(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000DE5 RID: 3557
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScancoCTReader_GetScanDimensionsPhysical_31(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DE6 RID: 3558 RVA: 0x0001A940 File Offset: 0x00018B40
		public virtual void GetScanDimensionsPhysical(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkScancoCTReader.vtkScancoCTReader_GetScanDimensionsPhysical_31(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06000DE7 RID: 3559
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScancoCTReader_GetScanDimensionsPhysical_32(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DE8 RID: 3560 RVA: 0x0001A952 File Offset: 0x00018B52
		public virtual void GetScanDimensionsPhysical(IntPtr _arg)
		{
			vtkScancoCTReader.vtkScancoCTReader_GetScanDimensionsPhysical_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06000DE9 RID: 3561
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScancoCTReader_GetScanDimensionsPixels_33(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DEA RID: 3562 RVA: 0x0001A964 File Offset: 0x00018B64
		public virtual int[] GetScanDimensionsPixels()
		{
			IntPtr intPtr = vtkScancoCTReader.vtkScancoCTReader_GetScanDimensionsPixels_33(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000DEB RID: 3563
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScancoCTReader_GetScanDimensionsPixels_34(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DEC RID: 3564 RVA: 0x0001A9AC File Offset: 0x00018BAC
		public virtual void GetScanDimensionsPixels(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkScancoCTReader.vtkScancoCTReader_GetScanDimensionsPixels_34(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06000DED RID: 3565
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScancoCTReader_GetScanDimensionsPixels_35(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DEE RID: 3566 RVA: 0x0001A9BE File Offset: 0x00018BBE
		public virtual void GetScanDimensionsPixels(IntPtr _arg)
		{
			vtkScancoCTReader.vtkScancoCTReader_GetScanDimensionsPixels_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06000DEF RID: 3567
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScancoCTReader_GetScanDistance_36(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DF0 RID: 3568 RVA: 0x0001A9D0 File Offset: 0x00018BD0
		public double GetScanDistance()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetScanDistance_36(base.GetCppThis());
		}

		// Token: 0x06000DF1 RID: 3569
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScancoCTReader_GetScannerID_37(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DF2 RID: 3570 RVA: 0x0001A9F0 File Offset: 0x00018BF0
		public int GetScannerID()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetScannerID_37(base.GetCppThis());
		}

		// Token: 0x06000DF3 RID: 3571
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScancoCTReader_GetScannerType_38(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DF4 RID: 3572 RVA: 0x0001AA10 File Offset: 0x00018C10
		public int GetScannerType()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetScannerType_38(base.GetCppThis());
		}

		// Token: 0x06000DF5 RID: 3573
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScancoCTReader_GetSite_39(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DF6 RID: 3574 RVA: 0x0001AA30 File Offset: 0x00018C30
		public int GetSite()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetSite_39(base.GetCppThis());
		}

		// Token: 0x06000DF7 RID: 3575
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScancoCTReader_GetSliceIncrement_40(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DF8 RID: 3576 RVA: 0x0001AA50 File Offset: 0x00018C50
		public double GetSliceIncrement()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetSliceIncrement_40(base.GetCppThis());
		}

		// Token: 0x06000DF9 RID: 3577
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScancoCTReader_GetSliceThickness_41(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DFA RID: 3578 RVA: 0x0001AA70 File Offset: 0x00018C70
		public double GetSliceThickness()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetSliceThickness_41(base.GetCppThis());
		}

		// Token: 0x06000DFB RID: 3579
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScancoCTReader_GetStartPosition_42(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DFC RID: 3580 RVA: 0x0001AA90 File Offset: 0x00018C90
		public double GetStartPosition()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetStartPosition_42(base.GetCppThis());
		}

		// Token: 0x06000DFD RID: 3581
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScancoCTReader_GetVersion_43(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DFE RID: 3582 RVA: 0x0001AAB0 File Offset: 0x00018CB0
		public string GetVersion()
		{
			string s = Marshal.PtrToStringAnsi(vtkScancoCTReader.vtkScancoCTReader_GetVersion_43(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000DFF RID: 3583
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScancoCTReader_GetZPosition_44(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000E00 RID: 3584 RVA: 0x0001AAEC File Offset: 0x00018CEC
		public double GetZPosition()
		{
			return vtkScancoCTReader.vtkScancoCTReader_GetZPosition_44(base.GetCppThis());
		}

		// Token: 0x06000E01 RID: 3585
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScancoCTReader_IsA_45(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000E02 RID: 3586 RVA: 0x0001AB0C File Offset: 0x00018D0C
		public override int IsA(string type)
		{
			return vtkScancoCTReader.vtkScancoCTReader_IsA_45(base.GetCppThis(), type);
		}

		// Token: 0x06000E03 RID: 3587
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScancoCTReader_IsTypeOf_46([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000E04 RID: 3588 RVA: 0x0001AB2C File Offset: 0x00018D2C
		public new static int IsTypeOf(string type)
		{
			return vtkScancoCTReader.vtkScancoCTReader_IsTypeOf_46(type);
		}

		// Token: 0x06000E05 RID: 3589
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScancoCTReader_NewInstance_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000E06 RID: 3590 RVA: 0x0001AB48 File Offset: 0x00018D48
		public new vtkScancoCTReader NewInstance()
		{
			vtkScancoCTReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScancoCTReader.vtkScancoCTReader_NewInstance_48(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScancoCTReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000E07 RID: 3591
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScancoCTReader_SafeDownCast_49(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000E08 RID: 3592 RVA: 0x0001ABA4 File Offset: 0x00018DA4
		public new static vtkScancoCTReader SafeDownCast(vtkObjectBase o)
		{
			vtkScancoCTReader vtkScancoCTReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScancoCTReader.vtkScancoCTReader_SafeDownCast_49((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScancoCTReader = (vtkScancoCTReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScancoCTReader.Register(null);
				}
			}
			return vtkScancoCTReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000424 RID: 1060
		public new const string MRFullTypeName = "Kitware.VTK.vtkScancoCTReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000425 RID: 1061
		public new static readonly string MRClassNameKey = "class vtkScancoCTReader";
	}
}
