using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNIFTIImageHeader
	/// </summary>
	/// <remarks>
	///    Store NIfTI header information.
	///
	/// This class stores the header of a NIfTI file in a VTK-friendly format.
	/// By using this class, it is possible to specify the header information
	/// that will be stored in a file written by the vtkNIFTIImageWriter.  Note
	/// that the SForm and QForm orientation information in this class will be
	/// ignored by the writer if an SForm and QForm have been explicitly set
	/// via the writer's SetSForm and SetQForm methods.  Also note that all
	/// info like Dim, PixDim, DataType, etc. will be ignored by the writer
	/// because this information must instead be taken from the vtkImageData
	/// information.  Finally, note that the vtkNIFTIImageWriter will ignore the
	/// Descrip field, since it has its own SetDescription method.
	/// @par Thanks:
	/// This class was contributed to VTK by the Calgary Image Processing and
	/// Analysis Centre (CIPAC).
	/// </remarks>
	/// <seealso>
	///
	/// vtkNIFTIImageReader, vtkNIFTIImageWriter
	/// </seealso>
	// Token: 0x02000790 RID: 1936
	public class vtkNIFTIImageHeader : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013E8A RID: 81546 RVA: 0x001C227F File Offset: 0x001C047F
		static vtkNIFTIImageHeader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNIFTIImageHeader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNIFTIImageHeader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013E8B RID: 81547 RVA: 0x001C22A7 File Offset: 0x001C04A7
		public vtkNIFTIImageHeader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013E8C RID: 81548
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageHeader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013E8D RID: 81549 RVA: 0x001C22B8 File Offset: 0x001C04B8
		public new static vtkNIFTIImageHeader New()
		{
			vtkNIFTIImageHeader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIImageHeader.vtkNIFTIImageHeader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNIFTIImageHeader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013E8E RID: 81550 RVA: 0x001C230C File Offset: 0x001C050C
		public vtkNIFTIImageHeader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNIFTIImageHeader.vtkNIFTIImageHeader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013E8F RID: 81551 RVA: 0x001C2350 File Offset: 0x001C0550
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013E90 RID: 81552
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_DeepCopy_01(HandleRef pThis, HandleRef o);

		/// <summary>
		/// Make a copy of the header.
		/// </summary>
		// Token: 0x06013E91 RID: 81553 RVA: 0x001C235C File Offset: 0x001C055C
		public void DeepCopy(vtkNIFTIImageHeader o)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_DeepCopy_01(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis());
		}

		// Token: 0x06013E92 RID: 81554
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageHeader_GetAuxFile_02(HandleRef pThis);

		/// <summary>
		/// Get an auxiliary file, e.g. a color table, that is associated
		/// with this data.  The length of the filename must be a maximum of
		/// 24 characters, and it will be assumed to be in the same directory
		/// as the NIFTI file.
		/// </summary>
		// Token: 0x06013E93 RID: 81555 RVA: 0x001C238C File Offset: 0x001C058C
		public string GetAuxFile()
		{
			string s = Marshal.PtrToStringAnsi(vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetAuxFile_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E94 RID: 81556
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageHeader_GetBitPix_03(HandleRef pThis);

		/// <summary>
		/// Get the number of bits per pixel.
		/// </summary>
		// Token: 0x06013E95 RID: 81557 RVA: 0x001C23C8 File Offset: 0x001C05C8
		public int GetBitPix()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetBitPix_03(base.GetCppThis());
		}

		// Token: 0x06013E96 RID: 81558
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageHeader_GetCalMax_04(HandleRef pThis);

		/// <summary>
		/// Get the calibrated range of the data, i.e. the values stored in the
		/// cal_min and cal_max fields in the header.
		/// </summary>
		// Token: 0x06013E97 RID: 81559 RVA: 0x001C23E8 File Offset: 0x001C05E8
		public double GetCalMax()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetCalMax_04(base.GetCppThis());
		}

		// Token: 0x06013E98 RID: 81560
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageHeader_GetCalMin_05(HandleRef pThis);

		/// <summary>
		/// Get the calibrated range of the data, i.e. the values stored in the
		/// cal_min and cal_max fields in the header.
		/// </summary>
		// Token: 0x06013E99 RID: 81561 RVA: 0x001C2408 File Offset: 0x001C0608
		public double GetCalMin()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetCalMin_05(base.GetCppThis());
		}

		// Token: 0x06013E9A RID: 81562
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageHeader_GetDataType_06(HandleRef pThis);

		/// <summary>
		/// Get the data type.
		/// </summary>
		// Token: 0x06013E9B RID: 81563 RVA: 0x001C2428 File Offset: 0x001C0628
		public int GetDataType()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetDataType_06(base.GetCppThis());
		}

		// Token: 0x06013E9C RID: 81564
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageHeader_GetDescrip_07(HandleRef pThis);

		/// <summary>
		/// Get a null-terminated file descriptor, this usually gives the
		/// name of the software that wrote the file. It will have a maximum
		/// length of 80 characters.  Use ASCII to ensure compatibility with
		/// all NIFTI software, the NIFTI standard itself does not specify what
		/// encodings are permitted.
		/// </summary>
		// Token: 0x06013E9D RID: 81565 RVA: 0x001C2448 File Offset: 0x001C0648
		public string GetDescrip()
		{
			string s = Marshal.PtrToStringAnsi(vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetDescrip_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E9E RID: 81566
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIImageHeader_GetDim_08(HandleRef pThis, int i);

		/// <summary>
		/// Get the nth dimension of the data, where GetDim(0) returns the
		/// number of dimensions that are defined for the file.
		/// </summary>
		// Token: 0x06013E9F RID: 81567 RVA: 0x001C2484 File Offset: 0x001C0684
		public long GetDim(int i)
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetDim_08(base.GetCppThis(), i);
		}

		// Token: 0x06013EA0 RID: 81568
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageHeader_GetDimInfo_09(HandleRef pThis);

		/// <summary>
		/// Get a bitfield with extra information about the dimensions, it
		/// states which dimensions are the phase encode, frequency encode,
		/// and slice encode dimensions for MRI acquisitions.
		/// </summary>
		// Token: 0x06013EA1 RID: 81569 RVA: 0x001C24A4 File Offset: 0x001C06A4
		public int GetDimInfo()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetDimInfo_09(base.GetCppThis());
		}

		// Token: 0x06013EA2 RID: 81570
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageHeader_GetIntentCode_10(HandleRef pThis);

		/// <summary>
		/// Get the NIFTI intent code.  This is an enumerated value in the NIFTI
		/// header that states what the data is intended to be used for.
		/// </summary>
		// Token: 0x06013EA3 RID: 81571 RVA: 0x001C24C4 File Offset: 0x001C06C4
		public int GetIntentCode()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetIntentCode_10(base.GetCppThis());
		}

		// Token: 0x06013EA4 RID: 81572
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageHeader_GetIntentName_11(HandleRef pThis);

		/// <summary>
		/// Get the intent name.  This should match the intent code.
		/// </summary>
		// Token: 0x06013EA5 RID: 81573 RVA: 0x001C24E4 File Offset: 0x001C06E4
		public string GetIntentName()
		{
			string s = Marshal.PtrToStringAnsi(vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetIntentName_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013EA6 RID: 81574
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageHeader_GetIntentP1_12(HandleRef pThis);

		/// <summary>
		/// Get one of the NIFTI intent parameters.  The definition of these
		/// parameters varies according to the IntentCode.
		/// </summary>
		// Token: 0x06013EA7 RID: 81575 RVA: 0x001C2520 File Offset: 0x001C0720
		public double GetIntentP1()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetIntentP1_12(base.GetCppThis());
		}

		// Token: 0x06013EA8 RID: 81576
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageHeader_GetIntentP2_13(HandleRef pThis);

		/// <summary>
		/// Get one of the NIFTI intent parameters.  The definition of these
		/// parameters varies according to the IntentCode.
		/// </summary>
		// Token: 0x06013EA9 RID: 81577 RVA: 0x001C2540 File Offset: 0x001C0740
		public double GetIntentP2()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetIntentP2_13(base.GetCppThis());
		}

		// Token: 0x06013EAA RID: 81578
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageHeader_GetIntentP3_14(HandleRef pThis);

		/// <summary>
		/// Get one of the NIFTI intent parameters.  The definition of these
		/// parameters varies according to the IntentCode.
		/// </summary>
		// Token: 0x06013EAB RID: 81579 RVA: 0x001C2560 File Offset: 0x001C0760
		public double GetIntentP3()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetIntentP3_14(base.GetCppThis());
		}

		// Token: 0x06013EAC RID: 81580
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageHeader_GetMagic_15(HandleRef pThis);

		/// <summary>
		/// Get the magic number for the NIFTI file as a null-terminated string.
		/// </summary>
		// Token: 0x06013EAD RID: 81581 RVA: 0x001C2580 File Offset: 0x001C0780
		public string GetMagic()
		{
			string s = Marshal.PtrToStringAnsi(vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetMagic_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013EAE RID: 81582
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIImageHeader_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013EAF RID: 81583 RVA: 0x001C25BC File Offset: 0x001C07BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x06013EB0 RID: 81584
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIImageHeader_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013EB1 RID: 81585 RVA: 0x001C25DC File Offset: 0x001C07DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x06013EB2 RID: 81586
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageHeader_GetPixDim_18(HandleRef pThis, int i);

		/// <summary>
		/// Get the sample spacing in the nth dimension. If GetPixDim(0) is
		/// negative, then the quaternion for the qform describes the correct
		/// orientation only after the slice ordering has been reversed.
		/// </summary>
		// Token: 0x06013EB3 RID: 81587 RVA: 0x001C25F8 File Offset: 0x001C07F8
		public double GetPixDim(int i)
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetPixDim_18(base.GetCppThis(), i);
		}

		// Token: 0x06013EB4 RID: 81588
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageHeader_GetQFormCode_19(HandleRef pThis);

		/// <summary>
		/// Get the QForm or SForm code.
		/// </summary>
		// Token: 0x06013EB5 RID: 81589 RVA: 0x001C2618 File Offset: 0x001C0818
		public int GetQFormCode()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetQFormCode_19(base.GetCppThis());
		}

		// Token: 0x06013EB6 RID: 81590
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageHeader_GetQOffsetX_20(HandleRef pThis);

		/// <summary>
		/// Get information about the quaternion transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
		/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
		/// </summary>
		// Token: 0x06013EB7 RID: 81591 RVA: 0x001C2638 File Offset: 0x001C0838
		public double GetQOffsetX()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetQOffsetX_20(base.GetCppThis());
		}

		// Token: 0x06013EB8 RID: 81592
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageHeader_GetQOffsetY_21(HandleRef pThis);

		/// <summary>
		/// Get information about the quaternion transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
		/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
		/// </summary>
		// Token: 0x06013EB9 RID: 81593 RVA: 0x001C2658 File Offset: 0x001C0858
		public double GetQOffsetY()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetQOffsetY_21(base.GetCppThis());
		}

		// Token: 0x06013EBA RID: 81594
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageHeader_GetQOffsetZ_22(HandleRef pThis);

		/// <summary>
		/// Get information about the quaternion transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
		/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
		/// </summary>
		// Token: 0x06013EBB RID: 81595 RVA: 0x001C2678 File Offset: 0x001C0878
		public double GetQOffsetZ()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetQOffsetZ_22(base.GetCppThis());
		}

		// Token: 0x06013EBC RID: 81596
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageHeader_GetQuaternB_23(HandleRef pThis);

		/// <summary>
		/// Get information about the quaternion transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
		/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
		/// </summary>
		// Token: 0x06013EBD RID: 81597 RVA: 0x001C2698 File Offset: 0x001C0898
		public double GetQuaternB()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetQuaternB_23(base.GetCppThis());
		}

		// Token: 0x06013EBE RID: 81598
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageHeader_GetQuaternC_24(HandleRef pThis);

		/// <summary>
		/// Get information about the quaternion transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
		/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
		/// </summary>
		// Token: 0x06013EBF RID: 81599 RVA: 0x001C26B8 File Offset: 0x001C08B8
		public double GetQuaternC()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetQuaternC_24(base.GetCppThis());
		}

		// Token: 0x06013EC0 RID: 81600
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageHeader_GetQuaternD_25(HandleRef pThis);

		/// <summary>
		/// Get information about the quaternion transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
		/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
		/// </summary>
		// Token: 0x06013EC1 RID: 81601 RVA: 0x001C26D8 File Offset: 0x001C08D8
		public double GetQuaternD()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetQuaternD_25(base.GetCppThis());
		}

		// Token: 0x06013EC2 RID: 81602
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageHeader_GetSFormCode_26(HandleRef pThis);

		/// <summary>
		/// Get the QForm or SForm code.
		/// </summary>
		// Token: 0x06013EC3 RID: 81603 RVA: 0x001C26F8 File Offset: 0x001C08F8
		public int GetSFormCode()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetSFormCode_26(base.GetCppThis());
		}

		// Token: 0x06013EC4 RID: 81604
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageHeader_GetSRowX_27(HandleRef pThis);

		/// <summary>
		/// Get information about the matrix transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
		/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
		/// </summary>
		// Token: 0x06013EC5 RID: 81605 RVA: 0x001C2718 File Offset: 0x001C0918
		public virtual double[] GetSRowX()
		{
			IntPtr intPtr = vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetSRowX_27(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013EC6 RID: 81606
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_GetSRowX_28(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Get information about the matrix transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
		/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
		/// </summary>
		// Token: 0x06013EC7 RID: 81607 RVA: 0x001C2760 File Offset: 0x001C0960
		public virtual void GetSRowX(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetSRowX_28(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x06013EC8 RID: 81608
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_GetSRowX_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get information about the matrix transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
		/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
		/// </summary>
		// Token: 0x06013EC9 RID: 81609 RVA: 0x001C2774 File Offset: 0x001C0974
		public virtual void GetSRowX(IntPtr _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetSRowX_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06013ECA RID: 81610
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageHeader_GetSRowY_30(HandleRef pThis);

		/// <summary>
		/// Get information about the matrix transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
		/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
		/// </summary>
		// Token: 0x06013ECB RID: 81611 RVA: 0x001C2784 File Offset: 0x001C0984
		public virtual double[] GetSRowY()
		{
			IntPtr intPtr = vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetSRowY_30(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013ECC RID: 81612
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_GetSRowY_31(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Get information about the matrix transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
		/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
		/// </summary>
		// Token: 0x06013ECD RID: 81613 RVA: 0x001C27CC File Offset: 0x001C09CC
		public virtual void GetSRowY(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetSRowY_31(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x06013ECE RID: 81614
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_GetSRowY_32(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get information about the matrix transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
		/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
		/// </summary>
		// Token: 0x06013ECF RID: 81615 RVA: 0x001C27E0 File Offset: 0x001C09E0
		public virtual void GetSRowY(IntPtr _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetSRowY_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06013ED0 RID: 81616
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_GetSRowZ_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get information about the matrix transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
		/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
		/// </summary>
		// Token: 0x06013ED1 RID: 81617 RVA: 0x001C27F0 File Offset: 0x001C09F0
		public virtual void GetSRowZ(IntPtr _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetSRowZ_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06013ED2 RID: 81618
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageHeader_GetSRowZ_34(HandleRef pThis);

		/// <summary>
		/// Get information about the matrix transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
		/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
		/// </summary>
		// Token: 0x06013ED3 RID: 81619 RVA: 0x001C2800 File Offset: 0x001C0A00
		public virtual double[] GetSRowZ()
		{
			IntPtr intPtr = vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetSRowZ_34(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013ED4 RID: 81620
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_GetSRowZ_35(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Get information about the matrix transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
		/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
		/// </summary>
		// Token: 0x06013ED5 RID: 81621 RVA: 0x001C2848 File Offset: 0x001C0A48
		public virtual void GetSRowZ(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetSRowZ_35(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x06013ED6 RID: 81622
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageHeader_GetSclInter_36(HandleRef pThis);

		/// <summary>
		/// Get the scale and slope to apply to the data in order to get
		/// the real-valued data values.
		/// </summary>
		// Token: 0x06013ED7 RID: 81623 RVA: 0x001C285C File Offset: 0x001C0A5C
		public double GetSclInter()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetSclInter_36(base.GetCppThis());
		}

		// Token: 0x06013ED8 RID: 81624
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageHeader_GetSclSlope_37(HandleRef pThis);

		/// <summary>
		/// Get the scale and slope to apply to the data in order to get
		/// the real-valued data values.
		/// </summary>
		// Token: 0x06013ED9 RID: 81625 RVA: 0x001C287C File Offset: 0x001C0A7C
		public double GetSclSlope()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetSclSlope_37(base.GetCppThis());
		}

		// Token: 0x06013EDA RID: 81626
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageHeader_GetSliceCode_38(HandleRef pThis);

		/// <summary>
		/// Get the slice code for the data.
		/// </summary>
		// Token: 0x06013EDB RID: 81627 RVA: 0x001C289C File Offset: 0x001C0A9C
		public int GetSliceCode()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetSliceCode_38(base.GetCppThis());
		}

		// Token: 0x06013EDC RID: 81628
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageHeader_GetSliceDuration_39(HandleRef pThis);

		/// <summary>
		/// Get the slice_duration and toffset from the header.
		/// </summary>
		// Token: 0x06013EDD RID: 81629 RVA: 0x001C28BC File Offset: 0x001C0ABC
		public double GetSliceDuration()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetSliceDuration_39(base.GetCppThis());
		}

		// Token: 0x06013EDE RID: 81630
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIImageHeader_GetSliceEnd_40(HandleRef pThis);

		/// <summary>
		/// Get the slice range for the data.
		/// </summary>
		// Token: 0x06013EDF RID: 81631 RVA: 0x001C28DC File Offset: 0x001C0ADC
		public long GetSliceEnd()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetSliceEnd_40(base.GetCppThis());
		}

		// Token: 0x06013EE0 RID: 81632
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIImageHeader_GetSliceStart_41(HandleRef pThis);

		/// <summary>
		/// Get the slice range for the data.
		/// </summary>
		// Token: 0x06013EE1 RID: 81633 RVA: 0x001C28FC File Offset: 0x001C0AFC
		public long GetSliceStart()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetSliceStart_41(base.GetCppThis());
		}

		// Token: 0x06013EE2 RID: 81634
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIImageHeader_GetTOffset_42(HandleRef pThis);

		/// <summary>
		/// Get the slice_duration and toffset from the header.
		/// </summary>
		// Token: 0x06013EE3 RID: 81635 RVA: 0x001C291C File Offset: 0x001C0B1C
		public double GetTOffset()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetTOffset_42(base.GetCppThis());
		}

		// Token: 0x06013EE4 RID: 81636
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIImageHeader_GetVoxOffset_43(HandleRef pThis);

		/// <summary>
		/// Get the offset to the pixel data within the file.
		/// </summary>
		// Token: 0x06013EE5 RID: 81637 RVA: 0x001C293C File Offset: 0x001C0B3C
		public long GetVoxOffset()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetVoxOffset_43(base.GetCppThis());
		}

		// Token: 0x06013EE6 RID: 81638
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageHeader_GetXYZTUnits_44(HandleRef pThis);

		/// <summary>
		/// Get a bitfield that describes the units for the first 4 dims.
		/// </summary>
		// Token: 0x06013EE7 RID: 81639 RVA: 0x001C295C File Offset: 0x001C0B5C
		public int GetXYZTUnits()
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_GetXYZTUnits_44(base.GetCppThis());
		}

		// Token: 0x06013EE8 RID: 81640
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_Initialize_45(HandleRef pThis);

		/// <summary>
		/// Initialize the header to default values.
		/// </summary>
		// Token: 0x06013EE9 RID: 81641 RVA: 0x001C297B File Offset: 0x001C0B7B
		public void Initialize()
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_Initialize_45(base.GetCppThis());
		}

		// Token: 0x06013EEA RID: 81642
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageHeader_IsA_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013EEB RID: 81643 RVA: 0x001C298C File Offset: 0x001C0B8C
		public override int IsA(string type)
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_IsA_46(base.GetCppThis(), type);
		}

		// Token: 0x06013EEC RID: 81644
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIImageHeader_IsTypeOf_47([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013EED RID: 81645 RVA: 0x001C29AC File Offset: 0x001C0BAC
		public new static int IsTypeOf(string type)
		{
			return vtkNIFTIImageHeader.vtkNIFTIImageHeader_IsTypeOf_47(type);
		}

		// Token: 0x06013EEE RID: 81646
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageHeader_NewInstance_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013EEF RID: 81647 RVA: 0x001C29C8 File Offset: 0x001C0BC8
		public new vtkNIFTIImageHeader NewInstance()
		{
			vtkNIFTIImageHeader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIImageHeader.vtkNIFTIImageHeader_NewInstance_49(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNIFTIImageHeader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013EF0 RID: 81648
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIImageHeader_SafeDownCast_50(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Static method for construction.
		/// </summary>
		// Token: 0x06013EF1 RID: 81649 RVA: 0x001C2A24 File Offset: 0x001C0C24
		public new static vtkNIFTIImageHeader SafeDownCast(vtkObjectBase o)
		{
			vtkNIFTIImageHeader vtkNIFTIImageHeader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIImageHeader.vtkNIFTIImageHeader_SafeDownCast_50((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013EF2 RID: 81650
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetAuxFile_51(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string auxfile);

		/// <summary>
		/// Get an auxiliary file, e.g. a color table, that is associated
		/// with this data.  The length of the filename must be a maximum of
		/// 24 characters, and it will be assumed to be in the same directory
		/// as the NIFTI file.
		/// </summary>
		// Token: 0x06013EF3 RID: 81651 RVA: 0x001C2AA3 File Offset: 0x001C0CA3
		public void SetAuxFile(string auxfile)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetAuxFile_51(base.GetCppThis(), auxfile);
		}

		// Token: 0x06013EF4 RID: 81652
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetCalMax_52(HandleRef pThis, double _arg);

		/// <summary>
		/// Get the calibrated range of the data, i.e. the values stored in the
		/// cal_min and cal_max fields in the header.
		/// </summary>
		// Token: 0x06013EF5 RID: 81653 RVA: 0x001C2AB3 File Offset: 0x001C0CB3
		public virtual void SetCalMax(double _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetCalMax_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06013EF6 RID: 81654
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetCalMin_53(HandleRef pThis, double _arg);

		/// <summary>
		/// Get the calibrated range of the data, i.e. the values stored in the
		/// cal_min and cal_max fields in the header.
		/// </summary>
		// Token: 0x06013EF7 RID: 81655 RVA: 0x001C2AC3 File Offset: 0x001C0CC3
		public virtual void SetCalMin(double _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetCalMin_53(base.GetCppThis(), _arg);
		}

		// Token: 0x06013EF8 RID: 81656
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetDescrip_54(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string descrip);

		/// <summary>
		/// Get a null-terminated file descriptor, this usually gives the
		/// name of the software that wrote the file. It will have a maximum
		/// length of 80 characters.  Use ASCII to ensure compatibility with
		/// all NIFTI software, the NIFTI standard itself does not specify what
		/// encodings are permitted.
		/// </summary>
		// Token: 0x06013EF9 RID: 81657 RVA: 0x001C2AD3 File Offset: 0x001C0CD3
		public void SetDescrip(string descrip)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetDescrip_54(base.GetCppThis(), descrip);
		}

		// Token: 0x06013EFA RID: 81658
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetDimInfo_55(HandleRef pThis, int _arg);

		/// <summary>
		/// Get a bitfield with extra information about the dimensions, it
		/// states which dimensions are the phase encode, frequency encode,
		/// and slice encode dimensions for MRI acquisitions.
		/// </summary>
		// Token: 0x06013EFB RID: 81659 RVA: 0x001C2AE3 File Offset: 0x001C0CE3
		public virtual void SetDimInfo(int _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetDimInfo_55(base.GetCppThis(), _arg);
		}

		// Token: 0x06013EFC RID: 81660
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetIntentCode_56(HandleRef pThis, int _arg);

		/// <summary>
		/// Get the NIFTI intent code.  This is an enumerated value in the NIFTI
		/// header that states what the data is intended to be used for.
		/// </summary>
		// Token: 0x06013EFD RID: 81661 RVA: 0x001C2AF3 File Offset: 0x001C0CF3
		public virtual void SetIntentCode(int _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetIntentCode_56(base.GetCppThis(), _arg);
		}

		// Token: 0x06013EFE RID: 81662
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetIntentName_57(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get the intent name.  This should match the intent code.
		/// </summary>
		// Token: 0x06013EFF RID: 81663 RVA: 0x001C2B03 File Offset: 0x001C0D03
		public void SetIntentName(string name)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetIntentName_57(base.GetCppThis(), name);
		}

		// Token: 0x06013F00 RID: 81664
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetIntentP1_58(HandleRef pThis, double _arg);

		/// <summary>
		/// Get one of the NIFTI intent parameters.  The definition of these
		/// parameters varies according to the IntentCode.
		/// </summary>
		// Token: 0x06013F01 RID: 81665 RVA: 0x001C2B13 File Offset: 0x001C0D13
		public virtual void SetIntentP1(double _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetIntentP1_58(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F02 RID: 81666
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetIntentP2_59(HandleRef pThis, double _arg);

		/// <summary>
		/// Get one of the NIFTI intent parameters.  The definition of these
		/// parameters varies according to the IntentCode.
		/// </summary>
		// Token: 0x06013F03 RID: 81667 RVA: 0x001C2B23 File Offset: 0x001C0D23
		public virtual void SetIntentP2(double _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetIntentP2_59(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F04 RID: 81668
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetIntentP3_60(HandleRef pThis, double _arg);

		/// <summary>
		/// Get one of the NIFTI intent parameters.  The definition of these
		/// parameters varies according to the IntentCode.
		/// </summary>
		// Token: 0x06013F05 RID: 81669 RVA: 0x001C2B33 File Offset: 0x001C0D33
		public virtual void SetIntentP3(double _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetIntentP3_60(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F06 RID: 81670
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetQFormCode_61(HandleRef pThis, int _arg);

		/// <summary>
		/// Get the QForm or SForm code.
		/// </summary>
		// Token: 0x06013F07 RID: 81671 RVA: 0x001C2B43 File Offset: 0x001C0D43
		public virtual void SetQFormCode(int _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetQFormCode_61(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F08 RID: 81672
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetQOffsetX_62(HandleRef pThis, double _arg);

		/// <summary>
		/// Get information about the quaternion transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
		/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
		/// </summary>
		// Token: 0x06013F09 RID: 81673 RVA: 0x001C2B53 File Offset: 0x001C0D53
		public virtual void SetQOffsetX(double _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetQOffsetX_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F0A RID: 81674
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetQOffsetY_63(HandleRef pThis, double _arg);

		/// <summary>
		/// Get information about the quaternion transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
		/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
		/// </summary>
		// Token: 0x06013F0B RID: 81675 RVA: 0x001C2B63 File Offset: 0x001C0D63
		public virtual void SetQOffsetY(double _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetQOffsetY_63(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F0C RID: 81676
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetQOffsetZ_64(HandleRef pThis, double _arg);

		/// <summary>
		/// Get information about the quaternion transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
		/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
		/// </summary>
		// Token: 0x06013F0D RID: 81677 RVA: 0x001C2B73 File Offset: 0x001C0D73
		public virtual void SetQOffsetZ(double _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetQOffsetZ_64(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F0E RID: 81678
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetQuaternB_65(HandleRef pThis, double _arg);

		/// <summary>
		/// Get information about the quaternion transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
		/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
		/// </summary>
		// Token: 0x06013F0F RID: 81679 RVA: 0x001C2B83 File Offset: 0x001C0D83
		public virtual void SetQuaternB(double _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetQuaternB_65(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F10 RID: 81680
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetQuaternC_66(HandleRef pThis, double _arg);

		/// <summary>
		/// Get information about the quaternion transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
		/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
		/// </summary>
		// Token: 0x06013F11 RID: 81681 RVA: 0x001C2B93 File Offset: 0x001C0D93
		public virtual void SetQuaternC(double _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetQuaternC_66(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F12 RID: 81682
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetQuaternD_67(HandleRef pThis, double _arg);

		/// <summary>
		/// Get information about the quaternion transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a quaternion
		/// has been set via vtkNIFTIImageWriter::SetQFormMatrix().
		/// </summary>
		// Token: 0x06013F13 RID: 81683 RVA: 0x001C2BA3 File Offset: 0x001C0DA3
		public virtual void SetQuaternD(double _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetQuaternD_67(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F14 RID: 81684
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetSFormCode_68(HandleRef pThis, int _arg);

		/// <summary>
		/// Get the QForm or SForm code.
		/// </summary>
		// Token: 0x06013F15 RID: 81685 RVA: 0x001C2BB3 File Offset: 0x001C0DB3
		public virtual void SetSFormCode(int _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetSFormCode_68(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F16 RID: 81686
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetSRowX_69(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Get information about the matrix transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
		/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
		/// </summary>
		// Token: 0x06013F17 RID: 81687 RVA: 0x001C2BC3 File Offset: 0x001C0DC3
		public virtual void SetSRowX(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetSRowX_69(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x06013F18 RID: 81688
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetSRowX_70(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get information about the matrix transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
		/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
		/// </summary>
		// Token: 0x06013F19 RID: 81689 RVA: 0x001C2BD7 File Offset: 0x001C0DD7
		public virtual void SetSRowX(IntPtr _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetSRowX_70(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F1A RID: 81690
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetSRowY_71(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Get information about the matrix transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
		/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
		/// </summary>
		// Token: 0x06013F1B RID: 81691 RVA: 0x001C2BE7 File Offset: 0x001C0DE7
		public virtual void SetSRowY(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetSRowY_71(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x06013F1C RID: 81692
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetSRowY_72(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get information about the matrix transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
		/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
		/// </summary>
		// Token: 0x06013F1D RID: 81693 RVA: 0x001C2BFB File Offset: 0x001C0DFB
		public virtual void SetSRowY(IntPtr _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetSRowY_72(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F1E RID: 81694
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetSRowZ_73(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Get information about the matrix transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
		/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
		/// </summary>
		// Token: 0x06013F1F RID: 81695 RVA: 0x001C2C0B File Offset: 0x001C0E0B
		public virtual void SetSRowZ(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetSRowZ_73(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x06013F20 RID: 81696
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetSRowZ_74(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get information about the matrix transformation.  Note that
		/// the vtkNIFTIImageWriter ignores this part of the header if a matrix
		/// has been set via vtkNIFTIImageWriter::SetSFormMatrix().
		/// </summary>
		// Token: 0x06013F21 RID: 81697 RVA: 0x001C2C1F File Offset: 0x001C0E1F
		public virtual void SetSRowZ(IntPtr _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetSRowZ_74(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F22 RID: 81698
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetSclInter_75(HandleRef pThis, double _arg);

		/// <summary>
		/// Get the scale and slope to apply to the data in order to get
		/// the real-valued data values.
		/// </summary>
		// Token: 0x06013F23 RID: 81699 RVA: 0x001C2C2F File Offset: 0x001C0E2F
		public virtual void SetSclInter(double _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetSclInter_75(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F24 RID: 81700
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetSclSlope_76(HandleRef pThis, double _arg);

		/// <summary>
		/// Get the scale and slope to apply to the data in order to get
		/// the real-valued data values.
		/// </summary>
		// Token: 0x06013F25 RID: 81701 RVA: 0x001C2C3F File Offset: 0x001C0E3F
		public virtual void SetSclSlope(double _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetSclSlope_76(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F26 RID: 81702
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetSliceCode_77(HandleRef pThis, int _arg);

		/// <summary>
		/// Get the slice code for the data.
		/// </summary>
		// Token: 0x06013F27 RID: 81703 RVA: 0x001C2C4F File Offset: 0x001C0E4F
		public virtual void SetSliceCode(int _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetSliceCode_77(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F28 RID: 81704
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetSliceDuration_78(HandleRef pThis, double _arg);

		/// <summary>
		/// Get the slice_duration and toffset from the header.
		/// </summary>
		// Token: 0x06013F29 RID: 81705 RVA: 0x001C2C5F File Offset: 0x001C0E5F
		public virtual void SetSliceDuration(double _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetSliceDuration_78(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F2A RID: 81706
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetSliceEnd_79(HandleRef pThis, long _arg);

		/// <summary>
		/// Get the slice range for the data.
		/// </summary>
		// Token: 0x06013F2B RID: 81707 RVA: 0x001C2C6F File Offset: 0x001C0E6F
		public virtual void SetSliceEnd(long _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetSliceEnd_79(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F2C RID: 81708
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetSliceStart_80(HandleRef pThis, long _arg);

		/// <summary>
		/// Get the slice range for the data.
		/// </summary>
		// Token: 0x06013F2D RID: 81709 RVA: 0x001C2C7F File Offset: 0x001C0E7F
		public virtual void SetSliceStart(long _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetSliceStart_80(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F2E RID: 81710
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetTOffset_81(HandleRef pThis, double _arg);

		/// <summary>
		/// Get the slice_duration and toffset from the header.
		/// </summary>
		// Token: 0x06013F2F RID: 81711 RVA: 0x001C2C8F File Offset: 0x001C0E8F
		public virtual void SetTOffset(double _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetTOffset_81(base.GetCppThis(), _arg);
		}

		// Token: 0x06013F30 RID: 81712
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIImageHeader_SetXYZTUnits_82(HandleRef pThis, int _arg);

		/// <summary>
		/// Get a bitfield that describes the units for the first 4 dims.
		/// </summary>
		// Token: 0x06013F31 RID: 81713 RVA: 0x001C2C9F File Offset: 0x001C0E9F
		public virtual void SetXYZTUnits(int _arg)
		{
			vtkNIFTIImageHeader.vtkNIFTIImageHeader_SetXYZTUnits_82(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016D4 RID: 5844
		public new const string MRFullTypeName = "Kitware.VTK.vtkNIFTIImageHeader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016D5 RID: 5845
		public new static readonly string MRClassNameKey = "class vtkNIFTIImageHeader";

		/// <summary>
		/// NIFTI data types.
		/// Types RGB24 and RGB32 are represented in VTK as a multi-component
		/// unsigned char image.  Complex values are represented as two-component
		/// images.  The NIFTI types Float128 and Complex256 are not supported.
		/// </summary>
		// Token: 0x02000791 RID: 1937
		public enum DataTypeEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040016D7 RID: 5847
			TypeComplex128 = 1792,
			/// <summary>enum member</summary>
			// Token: 0x040016D8 RID: 5848
			TypeComplex256 = 2048,
			/// <summary>enum member</summary>
			// Token: 0x040016D9 RID: 5849
			TypeComplex64 = 32,
			/// <summary>enum member</summary>
			// Token: 0x040016DA RID: 5850
			TypeFloat128 = 1536,
			/// <summary>enum member</summary>
			// Token: 0x040016DB RID: 5851
			TypeFloat32 = 16,
			/// <summary>enum member</summary>
			// Token: 0x040016DC RID: 5852
			TypeFloat64 = 64,
			/// <summary>enum member</summary>
			// Token: 0x040016DD RID: 5853
			TypeInt16 = 4,
			/// <summary>enum member</summary>
			// Token: 0x040016DE RID: 5854
			TypeInt32 = 8,
			/// <summary>enum member</summary>
			// Token: 0x040016DF RID: 5855
			TypeInt64 = 1024,
			/// <summary>enum member</summary>
			// Token: 0x040016E0 RID: 5856
			TypeInt8 = 256,
			/// <summary>enum member</summary>
			// Token: 0x040016E1 RID: 5857
			TypeRGB24 = 128,
			/// <summary>enum member</summary>
			// Token: 0x040016E2 RID: 5858
			TypeRGBA32 = 2304,
			/// <summary>enum member</summary>
			// Token: 0x040016E3 RID: 5859
			TypeUInt16 = 512,
			/// <summary>enum member</summary>
			// Token: 0x040016E4 RID: 5860
			TypeUInt32 = 768,
			/// <summary>enum member</summary>
			// Token: 0x040016E5 RID: 5861
			TypeUInt64 = 1280,
			/// <summary>enum member</summary>
			// Token: 0x040016E6 RID: 5862
			TypeUInt8 = 2
		}

		/// <summary>
		/// NIFTI header sizes.
		/// </summary>
		// Token: 0x02000792 RID: 1938
		public enum HeaderSizeEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040016E8 RID: 5864
			NIFTI1HeaderSize = 348,
			/// <summary>enum member</summary>
			// Token: 0x040016E9 RID: 5865
			NIFTI2HeaderSize = 540
		}

		/// <summary>
		/// NIFTI intent codes.
		/// </summary>
		// Token: 0x02000793 RID: 1939
		public enum IntentCodeEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040016EB RID: 5867
			IntentBeta = 7,
			/// <summary>enum member</summary>
			// Token: 0x040016EC RID: 5868
			IntentBinom,
			/// <summary>enum member</summary>
			// Token: 0x040016ED RID: 5869
			IntentChi = 19,
			/// <summary>enum member</summary>
			// Token: 0x040016EE RID: 5870
			IntentChiSQ = 6,
			/// <summary>enum member</summary>
			// Token: 0x040016EF RID: 5871
			IntentChiSQNonc = 13,
			/// <summary>enum member</summary>
			// Token: 0x040016F0 RID: 5872
			IntentCorrel = 2,
			/// <summary>enum member</summary>
			// Token: 0x040016F1 RID: 5873
			IntentDimless = 1011,
			/// <summary>enum member</summary>
			// Token: 0x040016F2 RID: 5874
			IntentDispVect = 1006,
			/// <summary>enum member</summary>
			// Token: 0x040016F3 RID: 5875
			IntentEstimate = 1001,
			/// <summary>enum member</summary>
			// Token: 0x040016F4 RID: 5876
			IntentExtVal = 21,
			/// <summary>enum member</summary>
			// Token: 0x040016F5 RID: 5877
			IntentFTest = 4,
			/// <summary>enum member</summary>
			// Token: 0x040016F6 RID: 5878
			IntentFTestNonc = 12,
			/// <summary>enum member</summary>
			// Token: 0x040016F7 RID: 5879
			IntentGamma = 9,
			/// <summary>enum member</summary>
			// Token: 0x040016F8 RID: 5880
			IntentGenMatrix = 1004,
			/// <summary>enum member</summary>
			// Token: 0x040016F9 RID: 5881
			IntentInvGauss = 20,
			/// <summary>enum member</summary>
			// Token: 0x040016FA RID: 5882
			IntentLabel = 1002,
			/// <summary>enum member</summary>
			// Token: 0x040016FB RID: 5883
			IntentLaplace = 15,
			/// <summary>enum member</summary>
			// Token: 0x040016FC RID: 5884
			IntentLog10PVal = 24,
			/// <summary>enum member</summary>
			// Token: 0x040016FD RID: 5885
			IntentLogPVal = 23,
			/// <summary>enum member</summary>
			// Token: 0x040016FE RID: 5886
			IntentLogistic = 14,
			/// <summary>enum member</summary>
			// Token: 0x040016FF RID: 5887
			IntentNeuroName = 1003,
			/// <summary>enum member</summary>
			// Token: 0x04001700 RID: 5888
			IntentNodeIndex = 2002,
			/// <summary>enum member</summary>
			// Token: 0x04001701 RID: 5889
			IntentNone = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001702 RID: 5890
			IntentNormal = 11,
			/// <summary>enum member</summary>
			// Token: 0x04001703 RID: 5891
			IntentPVal = 22,
			/// <summary>enum member</summary>
			// Token: 0x04001704 RID: 5892
			IntentPointSet = 1008,
			/// <summary>enum member</summary>
			// Token: 0x04001705 RID: 5893
			IntentPoisson = 10,
			/// <summary>enum member</summary>
			// Token: 0x04001706 RID: 5894
			IntentQuaternion = 1010,
			/// <summary>enum member</summary>
			// Token: 0x04001707 RID: 5895
			IntentRGBAVector = 2004,
			/// <summary>enum member</summary>
			// Token: 0x04001708 RID: 5896
			IntentRGBVector = 2003,
			/// <summary>enum member</summary>
			// Token: 0x04001709 RID: 5897
			IntentShape = 2005,
			/// <summary>enum member</summary>
			// Token: 0x0400170A RID: 5898
			IntentSymMatrix = 1005,
			/// <summary>enum member</summary>
			// Token: 0x0400170B RID: 5899
			IntentTTest = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400170C RID: 5900
			IntentTTestNonc = 17,
			/// <summary>enum member</summary>
			// Token: 0x0400170D RID: 5901
			IntentTimeSeries = 2001,
			/// <summary>enum member</summary>
			// Token: 0x0400170E RID: 5902
			IntentTriangle = 1009,
			/// <summary>enum member</summary>
			// Token: 0x0400170F RID: 5903
			IntentUniform = 16,
			/// <summary>enum member</summary>
			// Token: 0x04001710 RID: 5904
			IntentVector = 1007,
			/// <summary>enum member</summary>
			// Token: 0x04001711 RID: 5905
			IntentWeibull = 18,
			/// <summary>enum member</summary>
			// Token: 0x04001712 RID: 5906
			IntentZScore = 5
		}

		/// <summary>
		/// NIFTI slice codes.
		/// </summary>
		// Token: 0x02000794 RID: 1940
		public enum SliceCodeEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001714 RID: 5908
			SliceAltDec = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001715 RID: 5909
			SliceAltDec2 = 6,
			/// <summary>enum member</summary>
			// Token: 0x04001716 RID: 5910
			SliceAltInc = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001717 RID: 5911
			SliceAltInc2 = 5,
			/// <summary>enum member</summary>
			// Token: 0x04001718 RID: 5912
			SliceSeqDec = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001719 RID: 5913
			SliceSeqInc = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400171A RID: 5914
			SliceUnknown = 0
		}

		/// <summary>
		/// NIFTI unit codes.
		/// </summary>
		// Token: 0x02000795 RID: 1941
		public enum UnitsXYZTEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400171C RID: 5916
			UnitsHz = 32,
			/// <summary>enum member</summary>
			// Token: 0x0400171D RID: 5917
			UnitsMM = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400171E RID: 5918
			UnitsMSec = 16,
			/// <summary>enum member</summary>
			// Token: 0x0400171F RID: 5919
			UnitsMeter = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001720 RID: 5920
			UnitsMicron = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001721 RID: 5921
			UnitsPPM = 40,
			/// <summary>enum member</summary>
			// Token: 0x04001722 RID: 5922
			UnitsRads = 48,
			/// <summary>enum member</summary>
			// Token: 0x04001723 RID: 5923
			UnitsSec = 8,
			/// <summary>enum member</summary>
			// Token: 0x04001724 RID: 5924
			UnitsSpace = 7,
			/// <summary>enum member</summary>
			// Token: 0x04001725 RID: 5925
			UnitsTime = 56,
			/// <summary>enum member</summary>
			// Token: 0x04001726 RID: 5926
			UnitsUSec = 24,
			/// <summary>enum member</summary>
			// Token: 0x04001727 RID: 5927
			UnitsUnknown = 0
		}

		/// <summary>
		/// NIFTI transform codes.
		/// </summary>
		// Token: 0x02000796 RID: 1942
		public enum XFormCodeEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001729 RID: 5929
			XFormAlignedAnat = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400172A RID: 5930
			XFormMNI152 = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400172B RID: 5931
			XFormScannerAnat = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400172C RID: 5932
			XFormTalairach = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400172D RID: 5933
			XFormUnkown = 0
		}
	}
}
