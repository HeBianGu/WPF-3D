using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// \class vtkDICOMReader
	/// \brief Read DICOM image files.
	///
	/// This class reads a series of DICOM files into a vtkImageData object,
	/// and also provides access to the DICOM meta data for each file.
	/// </summary>
	// Token: 0x0200002D RID: 45
	public class vtkDICOMReader : vtkImageReader2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000751 RID: 1873 RVA: 0x00011AD5 File Offset: 0x0000FCD5
		static vtkDICOMReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000752 RID: 1874 RVA: 0x00011AFD File Offset: 0x0000FCFD
		public vtkDICOMReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000753 RID: 1875
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000754 RID: 1876 RVA: 0x00011B0C File Offset: 0x0000FD0C
		public new static vtkDICOMReader New()
		{
			vtkDICOMReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMReader.vtkDICOMReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000755 RID: 1877 RVA: 0x00011B60 File Offset: 0x0000FD60
		public vtkDICOMReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMReader.vtkDICOMReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000756 RID: 1878 RVA: 0x00011BA4 File Offset: 0x0000FDA4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000757 RID: 1879
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_AutoRescaleOff_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000758 RID: 1880 RVA: 0x00011BAF File Offset: 0x0000FDAF
		public virtual void AutoRescaleOff()
		{
			vtkDICOMReader.vtkDICOMReader_AutoRescaleOff_01(base.GetCppThis());
		}

		// Token: 0x06000759 RID: 1881
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_AutoRescaleOn_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600075A RID: 1882 RVA: 0x00011BBE File Offset: 0x0000FDBE
		public virtual void AutoRescaleOn()
		{
			vtkDICOMReader.vtkDICOMReader_AutoRescaleOn_02(base.GetCppThis());
		}

		// Token: 0x0600075B RID: 1883
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_AutoYBRToRGBOff_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600075C RID: 1884 RVA: 0x00011BCD File Offset: 0x0000FDCD
		public virtual void AutoYBRToRGBOff()
		{
			vtkDICOMReader.vtkDICOMReader_AutoYBRToRGBOff_03(base.GetCppThis());
		}

		// Token: 0x0600075D RID: 1885
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_AutoYBRToRGBOn_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600075E RID: 1886 RVA: 0x00011BDC File Offset: 0x0000FDDC
		public virtual void AutoYBRToRGBOn()
		{
			vtkDICOMReader.vtkDICOMReader_AutoYBRToRGBOn_04(base.GetCppThis());
		}

		// Token: 0x0600075F RID: 1887
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMReader_CanReadFile_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000760 RID: 1888 RVA: 0x00011BEC File Offset: 0x0000FDEC
		public override int CanReadFile(string filename)
		{
			return vtkDICOMReader.vtkDICOMReader_CanReadFile_05(base.GetCppThis(), filename);
		}

		// Token: 0x06000761 RID: 1889
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMReader_GetAutoRescale_06(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000762 RID: 1890 RVA: 0x00011C0C File Offset: 0x0000FE0C
		public virtual int GetAutoRescale()
		{
			return vtkDICOMReader.vtkDICOMReader_GetAutoRescale_06(base.GetCppThis());
		}

		// Token: 0x06000763 RID: 1891
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMReader_GetAutoYBRToRGB_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000764 RID: 1892 RVA: 0x00011C2C File Offset: 0x0000FE2C
		public virtual int GetAutoYBRToRGB()
		{
			return vtkDICOMReader.vtkDICOMReader_GetAutoYBRToRGB_07(base.GetCppThis());
		}

		// Token: 0x06000765 RID: 1893
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDICOMCharacterSet vtkDICOMReader_GetDefaultCharacterSet_08(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000766 RID: 1894 RVA: 0x00011C4C File Offset: 0x0000FE4C
		public vtkDICOMCharacterSet GetDefaultCharacterSet()
		{
			return vtkDICOMReader.vtkDICOMReader_GetDefaultCharacterSet_08(base.GetCppThis());
		}

		// Token: 0x06000767 RID: 1895
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMReader_GetDescriptiveName_09(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000768 RID: 1896 RVA: 0x00011C6C File Offset: 0x0000FE6C
		public override string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMReader.vtkDICOMReader_GetDescriptiveName_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000769 RID: 1897
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMReader_GetDesiredStackID_10(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600076A RID: 1898 RVA: 0x00011CA8 File Offset: 0x0000FEA8
		public string GetDesiredStackID()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMReader.vtkDICOMReader_GetDesiredStackID_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600076B RID: 1899
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMReader_GetDesiredTimeIndex_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600076C RID: 1900 RVA: 0x00011CE4 File Offset: 0x0000FEE4
		public virtual int GetDesiredTimeIndex()
		{
			return vtkDICOMReader.vtkDICOMReader_GetDesiredTimeIndex_11(base.GetCppThis());
		}

		// Token: 0x0600076D RID: 1901
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMReader_GetFileExtensions_12(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600076E RID: 1902 RVA: 0x00011D04 File Offset: 0x0000FF04
		public override string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMReader.vtkDICOMReader_GetFileExtensions_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600076F RID: 1903
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMReader_GetFileIndexArray_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000770 RID: 1904 RVA: 0x00011D40 File Offset: 0x0000FF40
		public vtkIntArray GetFileIndexArray()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMReader.vtkDICOMReader_GetFileIndexArray_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		// Token: 0x06000771 RID: 1905
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMReader_GetFrameIndexArray_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000772 RID: 1906 RVA: 0x00011DB0 File Offset: 0x0000FFB0
		public vtkIntArray GetFrameIndexArray()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMReader.vtkDICOMReader_GetFrameIndexArray_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		// Token: 0x06000773 RID: 1907
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMReader_GetMedicalImageProperties_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000774 RID: 1908 RVA: 0x00011E20 File Offset: 0x00010020
		public vtkMedicalImageProperties GetMedicalImageProperties()
		{
			vtkMedicalImageProperties vtkMedicalImageProperties = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMReader.vtkDICOMReader_GetMedicalImageProperties_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMedicalImageProperties = (vtkMedicalImageProperties)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMedicalImageProperties.Register(null);
				}
			}
			return vtkMedicalImageProperties;
		}

		// Token: 0x06000775 RID: 1909
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMReader_GetMemoryRowOrder_16(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000776 RID: 1910 RVA: 0x00011E90 File Offset: 0x00010090
		public int GetMemoryRowOrder()
		{
			return vtkDICOMReader.vtkDICOMReader_GetMemoryRowOrder_16(base.GetCppThis());
		}

		// Token: 0x06000777 RID: 1911
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMReader_GetMemoryRowOrderAsString_17(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000778 RID: 1912 RVA: 0x00011EB0 File Offset: 0x000100B0
		public string GetMemoryRowOrderAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMReader.vtkDICOMReader_GetMemoryRowOrderAsString_17(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000779 RID: 1913
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMReader_GetMetaData_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600077A RID: 1914 RVA: 0x00011EEC File Offset: 0x000100EC
		public vtkDICOMMetaData GetMetaData()
		{
			vtkDICOMMetaData vtkDICOMMetaData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMReader.vtkDICOMReader_GetMetaData_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMMetaData = (vtkDICOMMetaData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMMetaData.Register(null);
				}
			}
			return vtkDICOMMetaData;
		}

		// Token: 0x0600077B RID: 1915
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMReader_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600077C RID: 1916 RVA: 0x00011F5C File Offset: 0x0001015C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMReader.vtkDICOMReader_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x0600077D RID: 1917
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMReader_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600077E RID: 1918 RVA: 0x00011F7C File Offset: 0x0001017C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMReader.vtkDICOMReader_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x0600077F RID: 1919
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMReader_GetOutputScalarType_21(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000780 RID: 1920 RVA: 0x00011F98 File Offset: 0x00010198
		public virtual int GetOutputScalarType()
		{
			return vtkDICOMReader.vtkDICOMReader_GetOutputScalarType_21(base.GetCppThis());
		}

		// Token: 0x06000781 RID: 1921
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkDICOMReader_GetOverlayBitfield_22(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000782 RID: 1922 RVA: 0x00011FB8 File Offset: 0x000101B8
		public ushort GetOverlayBitfield()
		{
			return vtkDICOMReader.vtkDICOMReader_GetOverlayBitfield_22(base.GetCppThis());
		}

		// Token: 0x06000783 RID: 1923
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMReader_GetOverlayOutput_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000784 RID: 1924 RVA: 0x00011FD8 File Offset: 0x000101D8
		public vtkImageData GetOverlayOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMReader.vtkDICOMReader_GetOverlayOutput_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06000785 RID: 1925
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMReader_GetOverlayOutputPort_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000786 RID: 1926 RVA: 0x00012048 File Offset: 0x00010248
		public vtkAlgorithmOutput GetOverlayOutputPort()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMReader.vtkDICOMReader_GetOverlayOutputPort_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x06000787 RID: 1927
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMReader_GetOverrideCharacterSet_25(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000788 RID: 1928 RVA: 0x000120B8 File Offset: 0x000102B8
		public bool GetOverrideCharacterSet()
		{
			return vtkDICOMReader.vtkDICOMReader_GetOverrideCharacterSet_25(base.GetCppThis()) != 0;
		}

		// Token: 0x06000789 RID: 1929
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMReader_GetPatientMatrix_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600078A RID: 1930 RVA: 0x000120E0 File Offset: 0x000102E0
		public vtkMatrix4x4 GetPatientMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMReader.vtkDICOMReader_GetPatientMatrix_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600078B RID: 1931
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDICOMReader_GetRescaleIntercept_27(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600078C RID: 1932 RVA: 0x00012150 File Offset: 0x00010350
		public double GetRescaleIntercept()
		{
			return vtkDICOMReader.vtkDICOMReader_GetRescaleIntercept_27(base.GetCppThis());
		}

		// Token: 0x0600078D RID: 1933
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDICOMReader_GetRescaleSlope_28(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600078E RID: 1934 RVA: 0x00012170 File Offset: 0x00010370
		public double GetRescaleSlope()
		{
			return vtkDICOMReader.vtkDICOMReader_GetRescaleSlope_28(base.GetCppThis());
		}

		// Token: 0x0600078F RID: 1935
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMReader_GetSorter_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000790 RID: 1936 RVA: 0x00012190 File Offset: 0x00010390
		public vtkDICOMSliceSorter GetSorter()
		{
			vtkDICOMSliceSorter vtkDICOMSliceSorter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMReader.vtkDICOMReader_GetSorter_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMSliceSorter = (vtkDICOMSliceSorter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMSliceSorter.Register(null);
				}
			}
			return vtkDICOMSliceSorter;
		}

		// Token: 0x06000791 RID: 1937
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMReader_GetSorting_30(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000792 RID: 1938 RVA: 0x00012200 File Offset: 0x00010400
		public virtual int GetSorting()
		{
			return vtkDICOMReader.vtkDICOMReader_GetSorting_30(base.GetCppThis());
		}

		// Token: 0x06000793 RID: 1939
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMReader_GetStackIDs_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000794 RID: 1940 RVA: 0x00012220 File Offset: 0x00010420
		public vtkStringArray GetStackIDs()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMReader.vtkDICOMReader_GetStackIDs_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x06000795 RID: 1941
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMReader_GetTimeAsVector_32(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000796 RID: 1942 RVA: 0x00012290 File Offset: 0x00010490
		public virtual int GetTimeAsVector()
		{
			return vtkDICOMReader.vtkDICOMReader_GetTimeAsVector_32(base.GetCppThis());
		}

		// Token: 0x06000797 RID: 1943
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMReader_GetTimeDimension_33(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000798 RID: 1944 RVA: 0x000122B0 File Offset: 0x000104B0
		public int GetTimeDimension()
		{
			return vtkDICOMReader.vtkDICOMReader_GetTimeDimension_33(base.GetCppThis());
		}

		// Token: 0x06000799 RID: 1945
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDICOMReader_GetTimeSpacing_34(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600079A RID: 1946 RVA: 0x000122D0 File Offset: 0x000104D0
		public double GetTimeSpacing()
		{
			return vtkDICOMReader.vtkDICOMReader_GetTimeSpacing_34(base.GetCppThis());
		}

		// Token: 0x0600079B RID: 1947
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMReader_HasOverlay_35(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600079C RID: 1948 RVA: 0x000122F0 File Offset: 0x000104F0
		public bool HasOverlay()
		{
			return vtkDICOMReader.vtkDICOMReader_HasOverlay_35(base.GetCppThis()) != 0;
		}

		// Token: 0x0600079D RID: 1949
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMReader_IsA_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600079E RID: 1950 RVA: 0x00012318 File Offset: 0x00010518
		public override int IsA(string type)
		{
			return vtkDICOMReader.vtkDICOMReader_IsA_36(base.GetCppThis(), type);
		}

		// Token: 0x0600079F RID: 1951
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMReader_IsTypeOf_37([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007A0 RID: 1952 RVA: 0x00012338 File Offset: 0x00010538
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMReader.vtkDICOMReader_IsTypeOf_37(type);
		}

		// Token: 0x060007A1 RID: 1953
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMReader_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007A2 RID: 1954 RVA: 0x00012354 File Offset: 0x00010554
		public new vtkDICOMReader NewInstance()
		{
			vtkDICOMReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMReader.vtkDICOMReader_NewInstance_39(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060007A3 RID: 1955
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_OverrideCharacterSetOff_40(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007A4 RID: 1956 RVA: 0x000123AE File Offset: 0x000105AE
		public virtual void OverrideCharacterSetOff()
		{
			vtkDICOMReader.vtkDICOMReader_OverrideCharacterSetOff_40(base.GetCppThis());
		}

		// Token: 0x060007A5 RID: 1957
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_OverrideCharacterSetOn_41(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007A6 RID: 1958 RVA: 0x000123BD File Offset: 0x000105BD
		public virtual void OverrideCharacterSetOn()
		{
			vtkDICOMReader.vtkDICOMReader_OverrideCharacterSetOn_41(base.GetCppThis());
		}

		// Token: 0x060007A7 RID: 1959
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMReader_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007A8 RID: 1960 RVA: 0x000123CC File Offset: 0x000105CC
		public new static vtkDICOMReader SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMReader vtkDICOMReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMReader.vtkDICOMReader_SafeDownCast_42((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMReader = (vtkDICOMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMReader.Register(null);
				}
			}
			return vtkDICOMReader;
		}

		// Token: 0x060007A9 RID: 1961
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_SetAutoRescale_43(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007AA RID: 1962 RVA: 0x0001244B File Offset: 0x0001064B
		public virtual void SetAutoRescale(int _arg)
		{
			vtkDICOMReader.vtkDICOMReader_SetAutoRescale_43(base.GetCppThis(), _arg);
		}

		// Token: 0x060007AB RID: 1963
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_SetAutoYBRToRGB_44(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007AC RID: 1964 RVA: 0x0001245B File Offset: 0x0001065B
		public virtual void SetAutoYBRToRGB(int _arg)
		{
			vtkDICOMReader.vtkDICOMReader_SetAutoYBRToRGB_44(base.GetCppThis(), _arg);
		}

		// Token: 0x060007AD RID: 1965
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_SetDefaultCharacterSet_45(HandleRef pThis, vtkDICOMCharacterSet cs);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007AE RID: 1966 RVA: 0x0001246B File Offset: 0x0001066B
		public void SetDefaultCharacterSet(vtkDICOMCharacterSet cs)
		{
			vtkDICOMReader.vtkDICOMReader_SetDefaultCharacterSet_45(base.GetCppThis(), cs);
		}

		// Token: 0x060007AF RID: 1967
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_SetDesiredStackID_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string stackId);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007B0 RID: 1968 RVA: 0x0001247B File Offset: 0x0001067B
		public void SetDesiredStackID(string stackId)
		{
			vtkDICOMReader.vtkDICOMReader_SetDesiredStackID_46(base.GetCppThis(), stackId);
		}

		// Token: 0x060007B1 RID: 1969
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_SetDesiredTimeIndex_47(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007B2 RID: 1970 RVA: 0x0001248B File Offset: 0x0001068B
		public virtual void SetDesiredTimeIndex(int _arg)
		{
			vtkDICOMReader.vtkDICOMReader_SetDesiredTimeIndex_47(base.GetCppThis(), _arg);
		}

		// Token: 0x060007B3 RID: 1971
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_SetMemoryRowOrder_48(HandleRef pThis, int order);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007B4 RID: 1972 RVA: 0x0001249B File Offset: 0x0001069B
		public void SetMemoryRowOrder(int order)
		{
			vtkDICOMReader.vtkDICOMReader_SetMemoryRowOrder_48(base.GetCppThis(), order);
		}

		// Token: 0x060007B5 RID: 1973
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_SetMemoryRowOrderToBottomUp_49(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007B6 RID: 1974 RVA: 0x000124AB File Offset: 0x000106AB
		public void SetMemoryRowOrderToBottomUp()
		{
			vtkDICOMReader.vtkDICOMReader_SetMemoryRowOrderToBottomUp_49(base.GetCppThis());
		}

		// Token: 0x060007B7 RID: 1975
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_SetMemoryRowOrderToFileNative_50(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007B8 RID: 1976 RVA: 0x000124BA File Offset: 0x000106BA
		public void SetMemoryRowOrderToFileNative()
		{
			vtkDICOMReader.vtkDICOMReader_SetMemoryRowOrderToFileNative_50(base.GetCppThis());
		}

		// Token: 0x060007B9 RID: 1977
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_SetMemoryRowOrderToTopDown_51(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007BA RID: 1978 RVA: 0x000124C9 File Offset: 0x000106C9
		public void SetMemoryRowOrderToTopDown()
		{
			vtkDICOMReader.vtkDICOMReader_SetMemoryRowOrderToTopDown_51(base.GetCppThis());
		}

		// Token: 0x060007BB RID: 1979
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_SetOutputScalarType_52(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007BC RID: 1980 RVA: 0x000124D8 File Offset: 0x000106D8
		public virtual void SetOutputScalarType(int _arg)
		{
			vtkDICOMReader.vtkDICOMReader_SetOutputScalarType_52(base.GetCppThis(), _arg);
		}

		// Token: 0x060007BD RID: 1981
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_SetOverlayOutput_53(HandleRef pThis, HandleRef data);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007BE RID: 1982 RVA: 0x000124E8 File Offset: 0x000106E8
		public void SetOverlayOutput(vtkImageData data)
		{
			vtkDICOMReader.vtkDICOMReader_SetOverlayOutput_53(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x060007BF RID: 1983
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_SetOverrideCharacterSet_54(HandleRef pThis, byte _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007C0 RID: 1984 RVA: 0x00012517 File Offset: 0x00010717
		public virtual void SetOverrideCharacterSet(bool _arg)
		{
			vtkDICOMReader.vtkDICOMReader_SetOverrideCharacterSet_54(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060007C1 RID: 1985
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_SetSorter_55(HandleRef pThis, HandleRef sorter);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007C2 RID: 1986 RVA: 0x00012530 File Offset: 0x00010730
		public void SetSorter(vtkDICOMSliceSorter sorter)
		{
			vtkDICOMReader.vtkDICOMReader_SetSorter_55(base.GetCppThis(), (sorter == null) ? default(HandleRef) : sorter.GetCppThis());
		}

		// Token: 0x060007C3 RID: 1987
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_SetSorting_56(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007C4 RID: 1988 RVA: 0x0001255F File Offset: 0x0001075F
		public virtual void SetSorting(int _arg)
		{
			vtkDICOMReader.vtkDICOMReader_SetSorting_56(base.GetCppThis(), _arg);
		}

		// Token: 0x060007C5 RID: 1989
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_SetTimeAsVector_57(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007C6 RID: 1990 RVA: 0x0001256F File Offset: 0x0001076F
		public virtual void SetTimeAsVector(int _arg)
		{
			vtkDICOMReader.vtkDICOMReader_SetTimeAsVector_57(base.GetCppThis(), _arg);
		}

		// Token: 0x060007C7 RID: 1991
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_SortingOff_58(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007C8 RID: 1992 RVA: 0x0001257F File Offset: 0x0001077F
		public virtual void SortingOff()
		{
			vtkDICOMReader.vtkDICOMReader_SortingOff_58(base.GetCppThis());
		}

		// Token: 0x060007C9 RID: 1993
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_SortingOn_59(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007CA RID: 1994 RVA: 0x0001258E File Offset: 0x0001078E
		public virtual void SortingOn()
		{
			vtkDICOMReader.vtkDICOMReader_SortingOn_59(base.GetCppThis());
		}

		// Token: 0x060007CB RID: 1995
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_TimeAsVectorOff_60(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007CC RID: 1996 RVA: 0x0001259D File Offset: 0x0001079D
		public virtual void TimeAsVectorOff()
		{
			vtkDICOMReader.vtkDICOMReader_TimeAsVectorOff_60(base.GetCppThis());
		}

		// Token: 0x060007CD RID: 1997
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_TimeAsVectorOn_61(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007CE RID: 1998 RVA: 0x000125AC File Offset: 0x000107AC
		public virtual void TimeAsVectorOn()
		{
			vtkDICOMReader.vtkDICOMReader_TimeAsVectorOn_61(base.GetCppThis());
		}

		// Token: 0x060007CF RID: 1999
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMReader_Update_62(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060007D0 RID: 2000 RVA: 0x000125BB File Offset: 0x000107BB
		public override void Update()
		{
			vtkDICOMReader.vtkDICOMReader_Update_62(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000382 RID: 898
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000383 RID: 899
		public new static readonly string MRClassNameKey = "class vtkDICOMReader";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200002E RID: 46
		public enum RowOrder
		{
			/// <summary>enum member</summary>
			// Token: 0x04000385 RID: 901
			BottomUp = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000386 RID: 902
			FileNative = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000387 RID: 903
			TopDown
		}
	}
}
