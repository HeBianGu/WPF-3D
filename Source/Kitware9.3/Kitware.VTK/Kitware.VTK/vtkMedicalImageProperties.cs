using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMedicalImageProperties
	/// </summary>
	/// <remarks>
	///    some medical image properties.
	///
	/// vtkMedicalImageProperties is a helper class that can be used by medical
	/// image readers and applications to encapsulate medical image/acquisition
	/// properties. Later on, this should probably be extended to add
	/// any user-defined property.
	/// </remarks>
	/// <seealso>
	///
	/// vtkMedicalImageReader2
	/// </seealso>
	// Token: 0x0200078B RID: 1931
	public class vtkMedicalImageProperties : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013D22 RID: 81186 RVA: 0x001C046A File Offset: 0x001BE66A
		static vtkMedicalImageProperties()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMedicalImageProperties.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMedicalImageProperties"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013D23 RID: 81187 RVA: 0x001C0492 File Offset: 0x001BE692
		public vtkMedicalImageProperties(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013D24 RID: 81188
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013D25 RID: 81189 RVA: 0x001C04A0 File Offset: 0x001BE6A0
		public new static vtkMedicalImageProperties New()
		{
			vtkMedicalImageProperties result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMedicalImageProperties.vtkMedicalImageProperties_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMedicalImageProperties)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013D26 RID: 81190 RVA: 0x001C04F4 File Offset: 0x001BE6F4
		public vtkMedicalImageProperties() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMedicalImageProperties.vtkMedicalImageProperties_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013D27 RID: 81191 RVA: 0x001C0538 File Offset: 0x001BE738
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013D28 RID: 81192
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_AddUserDefinedValue_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Get the direction cosine (default to 1,0,0,0,1,0)
		/// </summary>
		// Token: 0x06013D29 RID: 81193 RVA: 0x001C0543 File Offset: 0x001BE743
		public virtual void AddUserDefinedValue(string name, string value)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_AddUserDefinedValue_01(base.GetCppThis(), name, value);
		}

		// Token: 0x06013D2A RID: 81194
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_AddWindowLevelPreset_02(HandleRef pThis, double w, double l);

		/// <summary>
		/// Add/Remove/Query the window/level presets that may have been associated
		/// to a medical image. Window is also known as 'width', level is also known
		/// as 'center'. The same window/level pair can not be added twice.
		/// As a convenience, a comment (aka Explanation) can be associated to
		/// a preset.
		/// For ex:
		/// \verbatim
		/// DICOM Window Center (0028,1050) = 00045\000470
		/// DICOM Window Width  (0028,1051) = 0106\03412
		/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
		/// \endverbatim
		/// </summary>
		// Token: 0x06013D2B RID: 81195 RVA: 0x001C0554 File Offset: 0x001BE754
		public virtual int AddWindowLevelPreset(double w, double l)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_AddWindowLevelPreset_02(base.GetCppThis(), w, l);
		}

		// Token: 0x06013D2C RID: 81196
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_Clear_03(HandleRef pThis);

		/// <summary>
		/// Convenience method to reset all fields to an empty string/value
		/// </summary>
		// Token: 0x06013D2D RID: 81197 RVA: 0x001C0575 File Offset: 0x001BE775
		public virtual void Clear()
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_Clear_03(base.GetCppThis());
		}

		// Token: 0x06013D2E RID: 81198
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_DeepCopy_04(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Copy the contents of p to this instance.
		/// </summary>
		// Token: 0x06013D2F RID: 81199 RVA: 0x001C0584 File Offset: 0x001BE784
		public virtual void DeepCopy(vtkMedicalImageProperties p)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_DeepCopy_04(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x06013D30 RID: 81200
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetAcquisitionDate_05(HandleRef pThis);

		/// <summary>
		/// Acquisition Date
		/// Format: yyyymmdd
		/// For ex: DICOM (0008,0022) = 20030617
		/// </summary>
		// Token: 0x06013D31 RID: 81201 RVA: 0x001C05B4 File Offset: 0x001BE7B4
		public virtual string GetAcquisitionDate()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetAcquisitionDate_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D32 RID: 81202
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetAcquisitionDateDay_06(HandleRef pThis);

		/// <summary>
		/// Acquisition Date
		/// Format: yyyymmdd
		/// For ex: DICOM (0008,0022) = 20030617
		/// </summary>
		// Token: 0x06013D33 RID: 81203 RVA: 0x001C05F0 File Offset: 0x001BE7F0
		public int GetAcquisitionDateDay()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetAcquisitionDateDay_06(base.GetCppThis());
		}

		// Token: 0x06013D34 RID: 81204
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetAcquisitionDateMonth_07(HandleRef pThis);

		/// <summary>
		/// Acquisition Date
		/// Format: yyyymmdd
		/// For ex: DICOM (0008,0022) = 20030617
		/// </summary>
		// Token: 0x06013D35 RID: 81205 RVA: 0x001C0610 File Offset: 0x001BE810
		public int GetAcquisitionDateMonth()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetAcquisitionDateMonth_07(base.GetCppThis());
		}

		// Token: 0x06013D36 RID: 81206
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetAcquisitionDateYear_08(HandleRef pThis);

		/// <summary>
		/// Acquisition Date
		/// Format: yyyymmdd
		/// For ex: DICOM (0008,0022) = 20030617
		/// </summary>
		// Token: 0x06013D37 RID: 81207 RVA: 0x001C0630 File Offset: 0x001BE830
		public int GetAcquisitionDateYear()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetAcquisitionDateYear_08(base.GetCppThis());
		}

		// Token: 0x06013D38 RID: 81208
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetAcquisitionTime_09(HandleRef pThis);

		/// <summary>
		/// Acquisition time
		/// Format: hhmmss.frac (any trailing component(s) can be omitted)
		/// For ex: DICOM (0008,0032) = 162552.0705 or 230012, or 0012
		/// </summary>
		// Token: 0x06013D39 RID: 81209 RVA: 0x001C0650 File Offset: 0x001BE850
		public virtual string GetAcquisitionTime()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetAcquisitionTime_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D3A RID: 81210
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetAgeAsFields_10([MarshalAs(UnmanagedType.LPUTF8Str)] string age, ref int year, ref int month, ref int week, ref int day);

		/// <summary>
		/// Take as input a string in VR=AS (DICOM PS3.5) and extract either
		/// different fields namely: year month week day
		/// Return 0 on error, 1 on success
		/// One can test fields if they are different from -1 upon success
		/// </summary>
		// Token: 0x06013D3B RID: 81211 RVA: 0x001C068C File Offset: 0x001BE88C
		public static int GetAgeAsFields(string age, ref int year, ref int month, ref int week, ref int day)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetAgeAsFields_10(age, ref year, ref month, ref week, ref day);
		}

		// Token: 0x06013D3C RID: 81212
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetConvolutionKernel_11(HandleRef pThis);

		/// <summary>
		/// Convolution Kernel (or algorithm used to reconstruct the data)
		/// For ex: DICOM (0018,1210) = Bone
		/// </summary>
		// Token: 0x06013D3D RID: 81213 RVA: 0x001C06AC File Offset: 0x001BE8AC
		public virtual string GetConvolutionKernel()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetConvolutionKernel_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D3E RID: 81214
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetDateAsFields_12([MarshalAs(UnmanagedType.LPUTF8Str)] string date, ref int year, ref int month, ref int day);

		/// <summary>
		/// Take as input a string in ISO 8601 date (YYYY/MM/DD) and extract the
		/// different fields namely: year month day
		/// Return 0 on error, 1 on success
		/// </summary>
		// Token: 0x06013D3F RID: 81215 RVA: 0x001C06E8 File Offset: 0x001BE8E8
		public static int GetDateAsFields(string date, ref int year, ref int month, ref int day)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetDateAsFields_12(date, ref year, ref month, ref day);
		}

		// Token: 0x06013D40 RID: 81216
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetDateAsLocale_13([MarshalAs(UnmanagedType.LPUTF8Str)] string date, [MarshalAs(UnmanagedType.LPUTF8Str)] string locale);

		/// <summary>
		/// Take as input a string in ISO 8601 date (YYYY/MM/DD) and construct a
		/// locale date based on the different fields (see GetDateAsFields to extract
		/// different fields)
		/// Return 0 on error, 1 on success
		/// </summary>
		// Token: 0x06013D41 RID: 81217 RVA: 0x001C0708 File Offset: 0x001BE908
		public static int GetDateAsLocale(string date, string locale)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetDateAsLocale_13(date, locale);
		}

		// Token: 0x06013D42 RID: 81218
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetDirectionCosine_14(HandleRef pThis);

		/// <summary>
		/// Get the direction cosine (default to 1,0,0,0,1,0)
		/// </summary>
		// Token: 0x06013D43 RID: 81219 RVA: 0x001C0724 File Offset: 0x001BE924
		public virtual double[] GetDirectionCosine()
		{
			IntPtr intPtr = vtkMedicalImageProperties.vtkMedicalImageProperties_GetDirectionCosine_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013D44 RID: 81220
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_GetDirectionCosine_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		/// <summary>
		/// Get the direction cosine (default to 1,0,0,0,1,0)
		/// </summary>
		// Token: 0x06013D45 RID: 81221 RVA: 0x001C076C File Offset: 0x001BE96C
		public virtual void GetDirectionCosine(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_GetDirectionCosine_15(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06013D46 RID: 81222
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_GetDirectionCosine_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the direction cosine (default to 1,0,0,0,1,0)
		/// </summary>
		// Token: 0x06013D47 RID: 81223 RVA: 0x001C0784 File Offset: 0x001BE984
		public virtual void GetDirectionCosine(IntPtr _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_GetDirectionCosine_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06013D48 RID: 81224
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetEchoTime_17(HandleRef pThis);

		/// <summary>
		/// Echo Time
		/// (Time in ms between the middle of the excitation pulse and the peak of
		/// the echo produced)
		/// For ex: DICOM (0018,0081) = 105
		/// </summary>
		// Token: 0x06013D49 RID: 81225 RVA: 0x001C0794 File Offset: 0x001BE994
		public virtual string GetEchoTime()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetEchoTime_17(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D4A RID: 81226
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetEchoTrainLength_18(HandleRef pThis);

		/// <summary>
		/// Echo Train Length
		/// (Number of lines in k-space acquired per excitation per image)
		/// For ex: DICOM (0018,0091) = 35
		/// </summary>
		// Token: 0x06013D4B RID: 81227 RVA: 0x001C07D0 File Offset: 0x001BE9D0
		public virtual string GetEchoTrainLength()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetEchoTrainLength_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D4C RID: 81228
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetExposure_19(HandleRef pThis);

		/// <summary>
		/// Exposure (The exposure expressed in mAs, for example calculated
		/// from Exposure Time and X-ray Tube Current)
		/// For ex: DICOM (0018,1152) = 114
		/// </summary>
		// Token: 0x06013D4D RID: 81229 RVA: 0x001C080C File Offset: 0x001BEA0C
		public virtual string GetExposure()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetExposure_19(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D4E RID: 81230
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetExposureTime_20(HandleRef pThis);

		/// <summary>
		/// Exposure time (time of x-ray exposure in msec)
		/// For ex: DICOM (0018,1150) = 5
		/// </summary>
		// Token: 0x06013D4F RID: 81231 RVA: 0x001C0848 File Offset: 0x001BEA48
		public virtual string GetExposureTime()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetExposureTime_20(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D50 RID: 81232
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetGantryTilt_21(HandleRef pThis);

		/// <summary>
		/// Gantry/Detector tilt (Nominal angle of tilt in degrees of the scanning
		/// gantry.)
		/// For ex: DICOM (0018,1120) = 15
		/// </summary>
		// Token: 0x06013D51 RID: 81233 RVA: 0x001C0884 File Offset: 0x001BEA84
		public virtual string GetGantryTilt()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetGantryTilt_21(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D52 RID: 81234
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMedicalImageProperties_GetGantryTiltAsDouble_22(HandleRef pThis);

		/// <summary>
		/// Gantry/Detector tilt (Nominal angle of tilt in degrees of the scanning
		/// gantry.)
		/// For ex: DICOM (0018,1120) = 15
		/// </summary>
		// Token: 0x06013D53 RID: 81235 RVA: 0x001C08C0 File Offset: 0x001BEAC0
		public virtual double GetGantryTiltAsDouble()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetGantryTiltAsDouble_22(base.GetCppThis());
		}

		// Token: 0x06013D54 RID: 81236
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetImageDate_23(HandleRef pThis);

		/// <summary>
		/// Image Date aka Content Date
		/// Format: yyyymmdd
		/// For ex: DICOM (0008,0023) = 20030617
		/// </summary>
		// Token: 0x06013D55 RID: 81237 RVA: 0x001C08E0 File Offset: 0x001BEAE0
		public virtual string GetImageDate()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetImageDate_23(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D56 RID: 81238
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetImageDateDay_24(HandleRef pThis);

		/// <summary>
		/// Image Date aka Content Date
		/// Format: yyyymmdd
		/// For ex: DICOM (0008,0023) = 20030617
		/// </summary>
		// Token: 0x06013D57 RID: 81239 RVA: 0x001C091C File Offset: 0x001BEB1C
		public int GetImageDateDay()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetImageDateDay_24(base.GetCppThis());
		}

		// Token: 0x06013D58 RID: 81240
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetImageDateMonth_25(HandleRef pThis);

		/// <summary>
		/// Image Date aka Content Date
		/// Format: yyyymmdd
		/// For ex: DICOM (0008,0023) = 20030617
		/// </summary>
		// Token: 0x06013D59 RID: 81241 RVA: 0x001C093C File Offset: 0x001BEB3C
		public int GetImageDateMonth()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetImageDateMonth_25(base.GetCppThis());
		}

		// Token: 0x06013D5A RID: 81242
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetImageDateYear_26(HandleRef pThis);

		/// <summary>
		/// Image Date aka Content Date
		/// Format: yyyymmdd
		/// For ex: DICOM (0008,0023) = 20030617
		/// </summary>
		// Token: 0x06013D5B RID: 81243 RVA: 0x001C095C File Offset: 0x001BEB5C
		public int GetImageDateYear()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetImageDateYear_26(base.GetCppThis());
		}

		// Token: 0x06013D5C RID: 81244
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetImageNumber_27(HandleRef pThis);

		/// <summary>
		/// Image number
		/// For ex: DICOM (0020,0013) = 1
		/// </summary>
		// Token: 0x06013D5D RID: 81245 RVA: 0x001C097C File Offset: 0x001BEB7C
		public virtual string GetImageNumber()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetImageNumber_27(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D5E RID: 81246
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetImageTime_28(HandleRef pThis);

		/// <summary>
		/// Image Time
		/// Format: hhmmss.frac (any trailing component(s) can be omitted)
		/// For ex: DICOM (0008,0033) = 162552.0705 or 230012, or 0012
		/// </summary>
		// Token: 0x06013D5F RID: 81247 RVA: 0x001C09B8 File Offset: 0x001BEBB8
		public virtual string GetImageTime()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetImageTime_28(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D60 RID: 81248
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetInstanceUIDFromSliceID_29(HandleRef pThis, int volumeidx, int sliceid);

		/// <summary>
		/// Mapping from a sliceidx within a volumeidx into a DICOM Instance UID
		/// Some DICOM reader can populate this structure so that later on from
		/// a slice index in a vtkImageData volume we can backtrack and find out
		/// which 2d slice it was coming from
		/// </summary>
		// Token: 0x06013D61 RID: 81249 RVA: 0x001C09F4 File Offset: 0x001BEBF4
		public string GetInstanceUIDFromSliceID(int volumeidx, int sliceid)
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetInstanceUIDFromSliceID_29(base.GetCppThis(), volumeidx, sliceid));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D62 RID: 81250
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetInstitutionName_30(HandleRef pThis);

		/// <summary>
		/// Institution Name
		/// For ex: DICOM (0008,0080) = FooCity Medical Center
		/// </summary>
		// Token: 0x06013D63 RID: 81251 RVA: 0x001C0A30 File Offset: 0x001BEC30
		public virtual string GetInstitutionName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetInstitutionName_30(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D64 RID: 81252
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetKVP_31(HandleRef pThis);

		/// <summary>
		/// Peak kilo voltage output of the (x-ray) generator used
		/// For ex: DICOM (0018,0060) = 120
		/// </summary>
		// Token: 0x06013D65 RID: 81253 RVA: 0x001C0A6C File Offset: 0x001BEC6C
		public virtual string GetKVP()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetKVP_31(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D66 RID: 81254
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetManufacturer_32(HandleRef pThis);

		/// <summary>
		/// Manufacturer
		/// For ex: DICOM (0008,0070) = Siemens
		/// </summary>
		// Token: 0x06013D67 RID: 81255 RVA: 0x001C0AA8 File Offset: 0x001BECA8
		public virtual string GetManufacturer()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetManufacturer_32(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D68 RID: 81256
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetManufacturerModelName_33(HandleRef pThis);

		/// <summary>
		/// Manufacturer's Model Name
		/// For ex: DICOM (0008,1090) = LightSpeed QX/i
		/// </summary>
		// Token: 0x06013D69 RID: 81257 RVA: 0x001C0AE4 File Offset: 0x001BECE4
		public virtual string GetManufacturerModelName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetManufacturerModelName_33(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D6A RID: 81258
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetModality_34(HandleRef pThis);

		/// <summary>
		/// Modality
		/// For ex: DICOM (0008,0060)= CT
		/// </summary>
		// Token: 0x06013D6B RID: 81259 RVA: 0x001C0B20 File Offset: 0x001BED20
		public virtual string GetModality()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetModality_34(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D6C RID: 81260
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetNthWindowLevelPreset_35(HandleRef pThis, int idx, IntPtr w, IntPtr l);

		/// <summary>
		/// Add/Remove/Query the window/level presets that may have been associated
		/// to a medical image. Window is also known as 'width', level is also known
		/// as 'center'. The same window/level pair can not be added twice.
		/// As a convenience, a comment (aka Explanation) can be associated to
		/// a preset.
		/// For ex:
		/// \verbatim
		/// DICOM Window Center (0028,1050) = 00045\000470
		/// DICOM Window Width  (0028,1051) = 0106\03412
		/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
		/// \endverbatim
		/// </summary>
		// Token: 0x06013D6D RID: 81261 RVA: 0x001C0B5C File Offset: 0x001BED5C
		public virtual int GetNthWindowLevelPreset(int idx, IntPtr w, IntPtr l)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetNthWindowLevelPreset_35(base.GetCppThis(), idx, w, l);
		}

		// Token: 0x06013D6E RID: 81262
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetNthWindowLevelPreset_36(HandleRef pThis, int idx);

		/// <summary>
		/// Add/Remove/Query the window/level presets that may have been associated
		/// to a medical image. Window is also known as 'width', level is also known
		/// as 'center'. The same window/level pair can not be added twice.
		/// As a convenience, a comment (aka Explanation) can be associated to
		/// a preset.
		/// For ex:
		/// \verbatim
		/// DICOM Window Center (0028,1050) = 00045\000470
		/// DICOM Window Width  (0028,1051) = 0106\03412
		/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
		/// \endverbatim
		/// </summary>
		// Token: 0x06013D6F RID: 81263 RVA: 0x001C0B80 File Offset: 0x001BED80
		public virtual double[] GetNthWindowLevelPreset(int idx)
		{
			IntPtr intPtr = vtkMedicalImageProperties.vtkMedicalImageProperties_GetNthWindowLevelPreset_36(base.GetCppThis(), idx);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013D70 RID: 81264
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetNthWindowLevelPresetComment_37(HandleRef pThis, int idx);

		/// <summary>
		/// Add/Remove/Query the window/level presets that may have been associated
		/// to a medical image. Window is also known as 'width', level is also known
		/// as 'center'. The same window/level pair can not be added twice.
		/// As a convenience, a comment (aka Explanation) can be associated to
		/// a preset.
		/// For ex:
		/// \verbatim
		/// DICOM Window Center (0028,1050) = 00045\000470
		/// DICOM Window Width  (0028,1051) = 0106\03412
		/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
		/// \endverbatim
		/// </summary>
		// Token: 0x06013D71 RID: 81265 RVA: 0x001C0BCC File Offset: 0x001BEDCC
		public virtual string GetNthWindowLevelPresetComment(int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetNthWindowLevelPresetComment_37(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D72 RID: 81266
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMedicalImageProperties_GetNumberOfGenerationsFromBase_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013D73 RID: 81267 RVA: 0x001C0C08 File Offset: 0x001BEE08
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetNumberOfGenerationsFromBase_38(base.GetCppThis(), type);
		}

		// Token: 0x06013D74 RID: 81268
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMedicalImageProperties_GetNumberOfGenerationsFromBaseType_39([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013D75 RID: 81269 RVA: 0x001C0C28 File Offset: 0x001BEE28
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetNumberOfGenerationsFromBaseType_39(type);
		}

		// Token: 0x06013D76 RID: 81270
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkMedicalImageProperties_GetNumberOfUserDefinedValues_40(HandleRef pThis);

		/// <summary>
		/// Get the direction cosine (default to 1,0,0,0,1,0)
		/// </summary>
		// Token: 0x06013D77 RID: 81271 RVA: 0x001C0C44 File Offset: 0x001BEE44
		public virtual uint GetNumberOfUserDefinedValues()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetNumberOfUserDefinedValues_40(base.GetCppThis());
		}

		// Token: 0x06013D78 RID: 81272
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetNumberOfWindowLevelPresets_41(HandleRef pThis);

		/// <summary>
		/// Add/Remove/Query the window/level presets that may have been associated
		/// to a medical image. Window is also known as 'width', level is also known
		/// as 'center'. The same window/level pair can not be added twice.
		/// As a convenience, a comment (aka Explanation) can be associated to
		/// a preset.
		/// For ex:
		/// \verbatim
		/// DICOM Window Center (0028,1050) = 00045\000470
		/// DICOM Window Width  (0028,1051) = 0106\03412
		/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
		/// \endverbatim
		/// </summary>
		// Token: 0x06013D79 RID: 81273 RVA: 0x001C0C64 File Offset: 0x001BEE64
		public virtual int GetNumberOfWindowLevelPresets()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetNumberOfWindowLevelPresets_41(base.GetCppThis());
		}

		// Token: 0x06013D7A RID: 81274
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetOrientationType_42(HandleRef pThis, int volumeidx);

		/// <summary>
		/// Provides the inverse mapping. Returns -1 if a slice for this uid is
		/// not found.
		/// </summary>
		// Token: 0x06013D7B RID: 81275 RVA: 0x001C0C84 File Offset: 0x001BEE84
		public int GetOrientationType(int volumeidx)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetOrientationType_42(base.GetCppThis(), volumeidx);
		}

		// Token: 0x06013D7C RID: 81276
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetPatientAge_43(HandleRef pThis);

		/// <summary>
		/// Patient age
		/// Format: nnnD, nnW, nnnM or nnnY (eventually nnD, nnW, nnY)
		/// with D (day), M (month), W (week), Y (year)
		/// For ex: DICOM (0010,1010) = 031Y
		/// </summary>
		// Token: 0x06013D7D RID: 81277 RVA: 0x001C0CA4 File Offset: 0x001BEEA4
		public virtual string GetPatientAge()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientAge_43(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D7E RID: 81278
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetPatientAgeDay_44(HandleRef pThis);

		/// <summary>
		/// Take as input a string in VR=AS (DICOM PS3.5) and extract either
		/// different fields namely: year month week day
		/// Return 0 on error, 1 on success
		/// One can test fields if they are different from -1 upon success
		/// </summary>
		// Token: 0x06013D7F RID: 81279 RVA: 0x001C0CE0 File Offset: 0x001BEEE0
		public int GetPatientAgeDay()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientAgeDay_44(base.GetCppThis());
		}

		// Token: 0x06013D80 RID: 81280
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetPatientAgeMonth_45(HandleRef pThis);

		/// <summary>
		/// Take as input a string in VR=AS (DICOM PS3.5) and extract either
		/// different fields namely: year month week day
		/// Return 0 on error, 1 on success
		/// One can test fields if they are different from -1 upon success
		/// </summary>
		// Token: 0x06013D81 RID: 81281 RVA: 0x001C0D00 File Offset: 0x001BEF00
		public int GetPatientAgeMonth()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientAgeMonth_45(base.GetCppThis());
		}

		// Token: 0x06013D82 RID: 81282
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetPatientAgeWeek_46(HandleRef pThis);

		/// <summary>
		/// Take as input a string in VR=AS (DICOM PS3.5) and extract either
		/// different fields namely: year month week day
		/// Return 0 on error, 1 on success
		/// One can test fields if they are different from -1 upon success
		/// </summary>
		// Token: 0x06013D83 RID: 81283 RVA: 0x001C0D20 File Offset: 0x001BEF20
		public int GetPatientAgeWeek()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientAgeWeek_46(base.GetCppThis());
		}

		// Token: 0x06013D84 RID: 81284
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetPatientAgeYear_47(HandleRef pThis);

		/// <summary>
		/// Take as input a string in VR=AS (DICOM PS3.5) and extract either
		/// different fields namely: year month week day
		/// Return 0 on error, 1 on success
		/// One can test fields if they are different from -1 upon success
		/// </summary>
		// Token: 0x06013D85 RID: 81285 RVA: 0x001C0D40 File Offset: 0x001BEF40
		public int GetPatientAgeYear()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientAgeYear_47(base.GetCppThis());
		}

		// Token: 0x06013D86 RID: 81286
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetPatientBirthDate_48(HandleRef pThis);

		/// <summary>
		/// Patient birth date
		/// Format: yyyymmdd
		/// For ex: DICOM (0010,0030) = 19680427
		/// </summary>
		// Token: 0x06013D87 RID: 81287 RVA: 0x001C0D60 File Offset: 0x001BEF60
		public virtual string GetPatientBirthDate()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientBirthDate_48(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D88 RID: 81288
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetPatientBirthDateDay_49(HandleRef pThis);

		/// <summary>
		/// Patient birth date
		/// Format: yyyymmdd
		/// For ex: DICOM (0010,0030) = 19680427
		/// </summary>
		// Token: 0x06013D89 RID: 81289 RVA: 0x001C0D9C File Offset: 0x001BEF9C
		public int GetPatientBirthDateDay()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientBirthDateDay_49(base.GetCppThis());
		}

		// Token: 0x06013D8A RID: 81290
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetPatientBirthDateMonth_50(HandleRef pThis);

		/// <summary>
		/// Patient birth date
		/// Format: yyyymmdd
		/// For ex: DICOM (0010,0030) = 19680427
		/// </summary>
		// Token: 0x06013D8B RID: 81291 RVA: 0x001C0DBC File Offset: 0x001BEFBC
		public int GetPatientBirthDateMonth()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientBirthDateMonth_50(base.GetCppThis());
		}

		// Token: 0x06013D8C RID: 81292
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetPatientBirthDateYear_51(HandleRef pThis);

		/// <summary>
		/// Patient birth date
		/// Format: yyyymmdd
		/// For ex: DICOM (0010,0030) = 19680427
		/// </summary>
		// Token: 0x06013D8D RID: 81293 RVA: 0x001C0DDC File Offset: 0x001BEFDC
		public int GetPatientBirthDateYear()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientBirthDateYear_51(base.GetCppThis());
		}

		// Token: 0x06013D8E RID: 81294
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetPatientID_52(HandleRef pThis);

		/// <summary>
		/// Patient ID
		/// For ex: DICOM (0010,0020) = 1933197
		/// </summary>
		// Token: 0x06013D8F RID: 81295 RVA: 0x001C0DFC File Offset: 0x001BEFFC
		public virtual string GetPatientID()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientID_52(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D90 RID: 81296
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetPatientName_53(HandleRef pThis);

		/// <summary>
		/// Patient name
		/// For ex: DICOM (0010,0010) = DOE,JOHN
		/// </summary>
		// Token: 0x06013D91 RID: 81297 RVA: 0x001C0E38 File Offset: 0x001BF038
		public virtual string GetPatientName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientName_53(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D92 RID: 81298
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetPatientSex_54(HandleRef pThis);

		/// <summary>
		/// Patient sex
		/// For ex: DICOM (0010,0040) = M
		/// </summary>
		// Token: 0x06013D93 RID: 81299 RVA: 0x001C0E74 File Offset: 0x001BF074
		public virtual string GetPatientSex()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetPatientSex_54(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D94 RID: 81300
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetRepetitionTime_55(HandleRef pThis);

		/// <summary>
		/// Repetition Time
		/// The period of time in msec between the beginning of a pulse sequence and
		/// the beginning of the succeeding (essentially identical) pulse sequence.
		/// For ex: DICOM (0018,0080) = 2040
		/// </summary>
		// Token: 0x06013D95 RID: 81301 RVA: 0x001C0EB0 File Offset: 0x001BF0B0
		public virtual string GetRepetitionTime()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetRepetitionTime_55(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D96 RID: 81302
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetSeriesDescription_56(HandleRef pThis);

		/// <summary>
		/// Series Description
		/// User provided description of the Series
		/// For ex: DICOM (0008,103e) = SCOUT
		/// </summary>
		// Token: 0x06013D97 RID: 81303 RVA: 0x001C0EEC File Offset: 0x001BF0EC
		public virtual string GetSeriesDescription()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetSeriesDescription_56(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D98 RID: 81304
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetSeriesNumber_57(HandleRef pThis);

		/// <summary>
		/// Series number
		/// For ex: DICOM (0020,0011) = 902
		/// </summary>
		// Token: 0x06013D99 RID: 81305 RVA: 0x001C0F28 File Offset: 0x001BF128
		public virtual string GetSeriesNumber()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetSeriesNumber_57(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D9A RID: 81306
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetSliceIDFromInstanceUID_58(HandleRef pThis, ref int volumeidx, [MarshalAs(UnmanagedType.LPUTF8Str)] string uid);

		/// <summary>
		/// Provides the inverse mapping. Returns -1 if a slice for this uid is
		/// not found.
		/// </summary>
		// Token: 0x06013D9B RID: 81307 RVA: 0x001C0F64 File Offset: 0x001BF164
		public int GetSliceIDFromInstanceUID(ref int volumeidx, string uid)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetSliceIDFromInstanceUID_58(base.GetCppThis(), ref volumeidx, uid);
		}

		// Token: 0x06013D9C RID: 81308
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetSliceThickness_59(HandleRef pThis);

		/// <summary>
		/// Slice Thickness (Nominal reconstructed slice thickness, in mm)
		/// For ex: DICOM (0018,0050) = 0.273438
		/// </summary>
		// Token: 0x06013D9D RID: 81309 RVA: 0x001C0F88 File Offset: 0x001BF188
		public virtual string GetSliceThickness()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetSliceThickness_59(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D9E RID: 81310
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMedicalImageProperties_GetSliceThicknessAsDouble_60(HandleRef pThis);

		/// <summary>
		/// Slice Thickness (Nominal reconstructed slice thickness, in mm)
		/// For ex: DICOM (0018,0050) = 0.273438
		/// </summary>
		// Token: 0x06013D9F RID: 81311 RVA: 0x001C0FC4 File Offset: 0x001BF1C4
		public virtual double GetSliceThicknessAsDouble()
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetSliceThicknessAsDouble_60(base.GetCppThis());
		}

		// Token: 0x06013DA0 RID: 81312
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetStationName_61(HandleRef pThis);

		/// <summary>
		/// Station Name
		/// For ex: DICOM (0008,1010) = LSPD_OC8
		/// </summary>
		// Token: 0x06013DA1 RID: 81313 RVA: 0x001C0FE4 File Offset: 0x001BF1E4
		public virtual string GetStationName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetStationName_61(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013DA2 RID: 81314
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetStringFromOrientationType_62(uint type);

		/// <summary>
		/// Provides the inverse mapping. Returns -1 if a slice for this uid is
		/// not found.
		/// </summary>
		// Token: 0x06013DA3 RID: 81315 RVA: 0x001C1020 File Offset: 0x001BF220
		public static string GetStringFromOrientationType(uint type)
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetStringFromOrientationType_62(type));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013DA4 RID: 81316
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetStudyDate_63(HandleRef pThis);

		/// <summary>
		/// Study Date
		/// Format: yyyymmdd
		/// For ex: DICOM (0008,0020) = 20030617
		/// </summary>
		// Token: 0x06013DA5 RID: 81317 RVA: 0x001C1058 File Offset: 0x001BF258
		public virtual string GetStudyDate()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetStudyDate_63(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013DA6 RID: 81318
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetStudyDescription_64(HandleRef pThis);

		/// <summary>
		/// Study description
		/// For ex: DICOM (0008,1030) = BRAIN/C-SP/FACIAL
		/// </summary>
		// Token: 0x06013DA7 RID: 81319 RVA: 0x001C1094 File Offset: 0x001BF294
		public virtual string GetStudyDescription()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetStudyDescription_64(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013DA8 RID: 81320
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetStudyID_65(HandleRef pThis);

		/// <summary>
		/// Study ID
		/// For ex: DICOM (0020,0010) = 37481
		/// </summary>
		// Token: 0x06013DA9 RID: 81321 RVA: 0x001C10D0 File Offset: 0x001BF2D0
		public virtual string GetStudyID()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetStudyID_65(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013DAA RID: 81322
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetStudyTime_66(HandleRef pThis);

		/// <summary>
		/// Study Time
		/// Format: hhmmss.frac (any trailing component(s) can be omitted)
		/// For ex: DICOM (0008,0030) = 162552.0705 or 230012, or 0012
		/// </summary>
		// Token: 0x06013DAB RID: 81323 RVA: 0x001C110C File Offset: 0x001BF30C
		public virtual string GetStudyTime()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetStudyTime_66(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013DAC RID: 81324
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetTimeAsFields_67([MarshalAs(UnmanagedType.LPUTF8Str)] string time, ref int hour, ref int minute, ref int second);

		/// <summary>
		/// Take as input a string in VR:TM format (HHMMSS) and extract the
		/// different fields namely: hour, minute and second
		/// Return 0 on error, 1 on success
		/// </summary>
		// Token: 0x06013DAD RID: 81325 RVA: 0x001C1148 File Offset: 0x001BF348
		public static int GetTimeAsFields(string time, ref int hour, ref int minute, ref int second)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetTimeAsFields_67(time, ref hour, ref minute, ref second);
		}

		// Token: 0x06013DAE RID: 81326
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetUserDefinedNameByIndex_68(HandleRef pThis, uint idx);

		/// <summary>
		/// Get the direction cosine (default to 1,0,0,0,1,0)
		/// </summary>
		// Token: 0x06013DAF RID: 81327 RVA: 0x001C1168 File Offset: 0x001BF368
		public virtual string GetUserDefinedNameByIndex(uint idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetUserDefinedNameByIndex_68(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013DB0 RID: 81328
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetUserDefinedValue_69(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get the direction cosine (default to 1,0,0,0,1,0)
		/// </summary>
		// Token: 0x06013DB1 RID: 81329 RVA: 0x001C11A4 File Offset: 0x001BF3A4
		public virtual string GetUserDefinedValue(string name)
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetUserDefinedValue_69(base.GetCppThis(), name));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013DB2 RID: 81330
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetUserDefinedValueByIndex_70(HandleRef pThis, uint idx);

		/// <summary>
		/// Get the direction cosine (default to 1,0,0,0,1,0)
		/// </summary>
		// Token: 0x06013DB3 RID: 81331 RVA: 0x001C11E0 File Offset: 0x001BF3E0
		public virtual string GetUserDefinedValueByIndex(uint idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetUserDefinedValueByIndex_70(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013DB4 RID: 81332
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_GetWindowLevelPresetIndex_71(HandleRef pThis, double w, double l);

		/// <summary>
		/// Add/Remove/Query the window/level presets that may have been associated
		/// to a medical image. Window is also known as 'width', level is also known
		/// as 'center'. The same window/level pair can not be added twice.
		/// As a convenience, a comment (aka Explanation) can be associated to
		/// a preset.
		/// For ex:
		/// \verbatim
		/// DICOM Window Center (0028,1050) = 00045\000470
		/// DICOM Window Width  (0028,1051) = 0106\03412
		/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
		/// \endverbatim
		/// </summary>
		// Token: 0x06013DB5 RID: 81333 RVA: 0x001C121C File Offset: 0x001BF41C
		public virtual int GetWindowLevelPresetIndex(double w, double l)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_GetWindowLevelPresetIndex_71(base.GetCppThis(), w, l);
		}

		// Token: 0x06013DB6 RID: 81334
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_GetXRayTubeCurrent_72(HandleRef pThis);

		/// <summary>
		/// X-ray tube current (in mA)
		/// For ex: DICOM (0018,1151) = 400
		/// </summary>
		// Token: 0x06013DB7 RID: 81335 RVA: 0x001C1240 File Offset: 0x001BF440
		public virtual string GetXRayTubeCurrent()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageProperties.vtkMedicalImageProperties_GetXRayTubeCurrent_72(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013DB8 RID: 81336
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_HasWindowLevelPreset_73(HandleRef pThis, double w, double l);

		/// <summary>
		/// Add/Remove/Query the window/level presets that may have been associated
		/// to a medical image. Window is also known as 'width', level is also known
		/// as 'center'. The same window/level pair can not be added twice.
		/// As a convenience, a comment (aka Explanation) can be associated to
		/// a preset.
		/// For ex:
		/// \verbatim
		/// DICOM Window Center (0028,1050) = 00045\000470
		/// DICOM Window Width  (0028,1051) = 0106\03412
		/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
		/// \endverbatim
		/// </summary>
		// Token: 0x06013DB9 RID: 81337 RVA: 0x001C127C File Offset: 0x001BF47C
		public virtual int HasWindowLevelPreset(double w, double l)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_HasWindowLevelPreset_73(base.GetCppThis(), w, l);
		}

		// Token: 0x06013DBA RID: 81338
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_IsA_74(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013DBB RID: 81339 RVA: 0x001C12A0 File Offset: 0x001BF4A0
		public override int IsA(string type)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_IsA_74(base.GetCppThis(), type);
		}

		// Token: 0x06013DBC RID: 81340
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageProperties_IsTypeOf_75([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013DBD RID: 81341 RVA: 0x001C12C0 File Offset: 0x001BF4C0
		public new static int IsTypeOf(string type)
		{
			return vtkMedicalImageProperties.vtkMedicalImageProperties_IsTypeOf_75(type);
		}

		// Token: 0x06013DBE RID: 81342
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_NewInstance_77(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013DBF RID: 81343 RVA: 0x001C12DC File Offset: 0x001BF4DC
		public new vtkMedicalImageProperties NewInstance()
		{
			vtkMedicalImageProperties result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMedicalImageProperties.vtkMedicalImageProperties_NewInstance_77(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMedicalImageProperties)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013DC0 RID: 81344
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_RemoveAllUserDefinedValues_78(HandleRef pThis);

		/// <summary>
		/// Get the direction cosine (default to 1,0,0,0,1,0)
		/// </summary>
		// Token: 0x06013DC1 RID: 81345 RVA: 0x001C1336 File Offset: 0x001BF536
		public virtual void RemoveAllUserDefinedValues()
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_RemoveAllUserDefinedValues_78(base.GetCppThis());
		}

		// Token: 0x06013DC2 RID: 81346
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_RemoveAllWindowLevelPresets_79(HandleRef pThis);

		/// <summary>
		/// Add/Remove/Query the window/level presets that may have been associated
		/// to a medical image. Window is also known as 'width', level is also known
		/// as 'center'. The same window/level pair can not be added twice.
		/// As a convenience, a comment (aka Explanation) can be associated to
		/// a preset.
		/// For ex:
		/// \verbatim
		/// DICOM Window Center (0028,1050) = 00045\000470
		/// DICOM Window Width  (0028,1051) = 0106\03412
		/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
		/// \endverbatim
		/// </summary>
		// Token: 0x06013DC3 RID: 81347 RVA: 0x001C1345 File Offset: 0x001BF545
		public virtual void RemoveAllWindowLevelPresets()
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_RemoveAllWindowLevelPresets_79(base.GetCppThis());
		}

		// Token: 0x06013DC4 RID: 81348
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_RemoveWindowLevelPreset_80(HandleRef pThis, double w, double l);

		/// <summary>
		/// Add/Remove/Query the window/level presets that may have been associated
		/// to a medical image. Window is also known as 'width', level is also known
		/// as 'center'. The same window/level pair can not be added twice.
		/// As a convenience, a comment (aka Explanation) can be associated to
		/// a preset.
		/// For ex:
		/// \verbatim
		/// DICOM Window Center (0028,1050) = 00045\000470
		/// DICOM Window Width  (0028,1051) = 0106\03412
		/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
		/// \endverbatim
		/// </summary>
		// Token: 0x06013DC5 RID: 81349 RVA: 0x001C1354 File Offset: 0x001BF554
		public virtual void RemoveWindowLevelPreset(double w, double l)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_RemoveWindowLevelPreset_80(base.GetCppThis(), w, l);
		}

		// Token: 0x06013DC6 RID: 81350
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageProperties_SafeDownCast_81(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013DC7 RID: 81351 RVA: 0x001C1368 File Offset: 0x001BF568
		public new static vtkMedicalImageProperties SafeDownCast(vtkObjectBase o)
		{
			vtkMedicalImageProperties vtkMedicalImageProperties = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMedicalImageProperties.vtkMedicalImageProperties_SafeDownCast_81((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013DC8 RID: 81352
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetAcquisitionDate_82(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Acquisition Date
		/// Format: yyyymmdd
		/// For ex: DICOM (0008,0022) = 20030617
		/// </summary>
		// Token: 0x06013DC9 RID: 81353 RVA: 0x001C13E7 File Offset: 0x001BF5E7
		public virtual void SetAcquisitionDate(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetAcquisitionDate_82(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DCA RID: 81354
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetAcquisitionTime_83(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Acquisition time
		/// Format: hhmmss.frac (any trailing component(s) can be omitted)
		/// For ex: DICOM (0008,0032) = 162552.0705 or 230012, or 0012
		/// </summary>
		// Token: 0x06013DCB RID: 81355 RVA: 0x001C13F7 File Offset: 0x001BF5F7
		public virtual void SetAcquisitionTime(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetAcquisitionTime_83(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DCC RID: 81356
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetConvolutionKernel_84(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Convolution Kernel (or algorithm used to reconstruct the data)
		/// For ex: DICOM (0018,1210) = Bone
		/// </summary>
		// Token: 0x06013DCD RID: 81357 RVA: 0x001C1407 File Offset: 0x001BF607
		public virtual void SetConvolutionKernel(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetConvolutionKernel_84(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DCE RID: 81358
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetDirectionCosine_85(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Get the direction cosine (default to 1,0,0,0,1,0)
		/// </summary>
		// Token: 0x06013DCF RID: 81359 RVA: 0x001C1417 File Offset: 0x001BF617
		public virtual void SetDirectionCosine(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetDirectionCosine_85(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06013DD0 RID: 81360
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetDirectionCosine_86(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the direction cosine (default to 1,0,0,0,1,0)
		/// </summary>
		// Token: 0x06013DD1 RID: 81361 RVA: 0x001C142F File Offset: 0x001BF62F
		public virtual void SetDirectionCosine(IntPtr _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetDirectionCosine_86(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DD2 RID: 81362
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetEchoTime_87(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Echo Time
		/// (Time in ms between the middle of the excitation pulse and the peak of
		/// the echo produced)
		/// For ex: DICOM (0018,0081) = 105
		/// </summary>
		// Token: 0x06013DD3 RID: 81363 RVA: 0x001C143F File Offset: 0x001BF63F
		public virtual void SetEchoTime(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetEchoTime_87(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DD4 RID: 81364
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetEchoTrainLength_88(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Echo Train Length
		/// (Number of lines in k-space acquired per excitation per image)
		/// For ex: DICOM (0018,0091) = 35
		/// </summary>
		// Token: 0x06013DD5 RID: 81365 RVA: 0x001C144F File Offset: 0x001BF64F
		public virtual void SetEchoTrainLength(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetEchoTrainLength_88(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DD6 RID: 81366
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetExposure_89(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Exposure (The exposure expressed in mAs, for example calculated
		/// from Exposure Time and X-ray Tube Current)
		/// For ex: DICOM (0018,1152) = 114
		/// </summary>
		// Token: 0x06013DD7 RID: 81367 RVA: 0x001C145F File Offset: 0x001BF65F
		public virtual void SetExposure(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetExposure_89(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DD8 RID: 81368
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetExposureTime_90(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Exposure time (time of x-ray exposure in msec)
		/// For ex: DICOM (0018,1150) = 5
		/// </summary>
		// Token: 0x06013DD9 RID: 81369 RVA: 0x001C146F File Offset: 0x001BF66F
		public virtual void SetExposureTime(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetExposureTime_90(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DDA RID: 81370
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetGantryTilt_91(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Gantry/Detector tilt (Nominal angle of tilt in degrees of the scanning
		/// gantry.)
		/// For ex: DICOM (0018,1120) = 15
		/// </summary>
		// Token: 0x06013DDB RID: 81371 RVA: 0x001C147F File Offset: 0x001BF67F
		public virtual void SetGantryTilt(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetGantryTilt_91(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DDC RID: 81372
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetImageDate_92(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Image Date aka Content Date
		/// Format: yyyymmdd
		/// For ex: DICOM (0008,0023) = 20030617
		/// </summary>
		// Token: 0x06013DDD RID: 81373 RVA: 0x001C148F File Offset: 0x001BF68F
		public virtual void SetImageDate(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetImageDate_92(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DDE RID: 81374
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetImageNumber_93(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Image number
		/// For ex: DICOM (0020,0013) = 1
		/// </summary>
		// Token: 0x06013DDF RID: 81375 RVA: 0x001C149F File Offset: 0x001BF69F
		public virtual void SetImageNumber(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetImageNumber_93(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DE0 RID: 81376
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetImageTime_94(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Image Time
		/// Format: hhmmss.frac (any trailing component(s) can be omitted)
		/// For ex: DICOM (0008,0033) = 162552.0705 or 230012, or 0012
		/// </summary>
		// Token: 0x06013DE1 RID: 81377 RVA: 0x001C14AF File Offset: 0x001BF6AF
		public virtual void SetImageTime(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetImageTime_94(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DE2 RID: 81378
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetInstanceUIDFromSliceID_95(HandleRef pThis, int volumeidx, int sliceid, [MarshalAs(UnmanagedType.LPUTF8Str)] string uid);

		/// <summary>
		/// Mapping from a sliceidx within a volumeidx into a DICOM Instance UID
		/// Some DICOM reader can populate this structure so that later on from
		/// a slice index in a vtkImageData volume we can backtrack and find out
		/// which 2d slice it was coming from
		/// </summary>
		// Token: 0x06013DE3 RID: 81379 RVA: 0x001C14BF File Offset: 0x001BF6BF
		public void SetInstanceUIDFromSliceID(int volumeidx, int sliceid, string uid)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetInstanceUIDFromSliceID_95(base.GetCppThis(), volumeidx, sliceid, uid);
		}

		// Token: 0x06013DE4 RID: 81380
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetInstitutionName_96(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Institution Name
		/// For ex: DICOM (0008,0080) = FooCity Medical Center
		/// </summary>
		// Token: 0x06013DE5 RID: 81381 RVA: 0x001C14D1 File Offset: 0x001BF6D1
		public virtual void SetInstitutionName(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetInstitutionName_96(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DE6 RID: 81382
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetKVP_97(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Peak kilo voltage output of the (x-ray) generator used
		/// For ex: DICOM (0018,0060) = 120
		/// </summary>
		// Token: 0x06013DE7 RID: 81383 RVA: 0x001C14E1 File Offset: 0x001BF6E1
		public virtual void SetKVP(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetKVP_97(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DE8 RID: 81384
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetManufacturer_98(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Manufacturer
		/// For ex: DICOM (0008,0070) = Siemens
		/// </summary>
		// Token: 0x06013DE9 RID: 81385 RVA: 0x001C14F1 File Offset: 0x001BF6F1
		public virtual void SetManufacturer(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetManufacturer_98(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DEA RID: 81386
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetManufacturerModelName_99(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Manufacturer's Model Name
		/// For ex: DICOM (0008,1090) = LightSpeed QX/i
		/// </summary>
		// Token: 0x06013DEB RID: 81387 RVA: 0x001C1501 File Offset: 0x001BF701
		public virtual void SetManufacturerModelName(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetManufacturerModelName_99(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DEC RID: 81388
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetModality_100(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Modality
		/// For ex: DICOM (0008,0060)= CT
		/// </summary>
		// Token: 0x06013DED RID: 81389 RVA: 0x001C1511 File Offset: 0x001BF711
		public virtual void SetModality(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetModality_100(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DEE RID: 81390
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetNthWindowLevelPresetComment_101(HandleRef pThis, int idx, [MarshalAs(UnmanagedType.LPUTF8Str)] string comment);

		/// <summary>
		/// Add/Remove/Query the window/level presets that may have been associated
		/// to a medical image. Window is also known as 'width', level is also known
		/// as 'center'. The same window/level pair can not be added twice.
		/// As a convenience, a comment (aka Explanation) can be associated to
		/// a preset.
		/// For ex:
		/// \verbatim
		/// DICOM Window Center (0028,1050) = 00045\000470
		/// DICOM Window Width  (0028,1051) = 0106\03412
		/// DICOM Window Center Width Explanation (0028,1055) = WINDOW1\WINDOW2
		/// \endverbatim
		/// </summary>
		// Token: 0x06013DEF RID: 81391 RVA: 0x001C1521 File Offset: 0x001BF721
		public virtual void SetNthWindowLevelPresetComment(int idx, string comment)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetNthWindowLevelPresetComment_101(base.GetCppThis(), idx, comment);
		}

		// Token: 0x06013DF0 RID: 81392
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetOrientationType_102(HandleRef pThis, int volumeidx, int orientation);

		/// <summary>
		/// Provides the inverse mapping. Returns -1 if a slice for this uid is
		/// not found.
		/// </summary>
		// Token: 0x06013DF1 RID: 81393 RVA: 0x001C1532 File Offset: 0x001BF732
		public void SetOrientationType(int volumeidx, int orientation)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetOrientationType_102(base.GetCppThis(), volumeidx, orientation);
		}

		// Token: 0x06013DF2 RID: 81394
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetPatientAge_103(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Patient age
		/// Format: nnnD, nnW, nnnM or nnnY (eventually nnD, nnW, nnY)
		/// with D (day), M (month), W (week), Y (year)
		/// For ex: DICOM (0010,1010) = 031Y
		/// </summary>
		// Token: 0x06013DF3 RID: 81395 RVA: 0x001C1543 File Offset: 0x001BF743
		public virtual void SetPatientAge(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetPatientAge_103(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DF4 RID: 81396
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetPatientBirthDate_104(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Patient birth date
		/// Format: yyyymmdd
		/// For ex: DICOM (0010,0030) = 19680427
		/// </summary>
		// Token: 0x06013DF5 RID: 81397 RVA: 0x001C1553 File Offset: 0x001BF753
		public virtual void SetPatientBirthDate(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetPatientBirthDate_104(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DF6 RID: 81398
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetPatientID_105(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Patient ID
		/// For ex: DICOM (0010,0020) = 1933197
		/// </summary>
		// Token: 0x06013DF7 RID: 81399 RVA: 0x001C1563 File Offset: 0x001BF763
		public virtual void SetPatientID(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetPatientID_105(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DF8 RID: 81400
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetPatientName_106(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Patient name
		/// For ex: DICOM (0010,0010) = DOE,JOHN
		/// </summary>
		// Token: 0x06013DF9 RID: 81401 RVA: 0x001C1573 File Offset: 0x001BF773
		public virtual void SetPatientName(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetPatientName_106(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DFA RID: 81402
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetPatientSex_107(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Patient sex
		/// For ex: DICOM (0010,0040) = M
		/// </summary>
		// Token: 0x06013DFB RID: 81403 RVA: 0x001C1583 File Offset: 0x001BF783
		public virtual void SetPatientSex(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetPatientSex_107(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DFC RID: 81404
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetRepetitionTime_108(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Repetition Time
		/// The period of time in msec between the beginning of a pulse sequence and
		/// the beginning of the succeeding (essentially identical) pulse sequence.
		/// For ex: DICOM (0018,0080) = 2040
		/// </summary>
		// Token: 0x06013DFD RID: 81405 RVA: 0x001C1593 File Offset: 0x001BF793
		public virtual void SetRepetitionTime(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetRepetitionTime_108(base.GetCppThis(), _arg);
		}

		// Token: 0x06013DFE RID: 81406
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetSeriesDescription_109(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Series Description
		/// User provided description of the Series
		/// For ex: DICOM (0008,103e) = SCOUT
		/// </summary>
		// Token: 0x06013DFF RID: 81407 RVA: 0x001C15A3 File Offset: 0x001BF7A3
		public virtual void SetSeriesDescription(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetSeriesDescription_109(base.GetCppThis(), _arg);
		}

		// Token: 0x06013E00 RID: 81408
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetSeriesNumber_110(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Series number
		/// For ex: DICOM (0020,0011) = 902
		/// </summary>
		// Token: 0x06013E01 RID: 81409 RVA: 0x001C15B3 File Offset: 0x001BF7B3
		public virtual void SetSeriesNumber(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetSeriesNumber_110(base.GetCppThis(), _arg);
		}

		// Token: 0x06013E02 RID: 81410
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetSliceThickness_111(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Slice Thickness (Nominal reconstructed slice thickness, in mm)
		/// For ex: DICOM (0018,0050) = 0.273438
		/// </summary>
		// Token: 0x06013E03 RID: 81411 RVA: 0x001C15C3 File Offset: 0x001BF7C3
		public virtual void SetSliceThickness(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetSliceThickness_111(base.GetCppThis(), _arg);
		}

		// Token: 0x06013E04 RID: 81412
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetStationName_112(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Station Name
		/// For ex: DICOM (0008,1010) = LSPD_OC8
		/// </summary>
		// Token: 0x06013E05 RID: 81413 RVA: 0x001C15D3 File Offset: 0x001BF7D3
		public virtual void SetStationName(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetStationName_112(base.GetCppThis(), _arg);
		}

		// Token: 0x06013E06 RID: 81414
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetStudyDate_113(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Study Date
		/// Format: yyyymmdd
		/// For ex: DICOM (0008,0020) = 20030617
		/// </summary>
		// Token: 0x06013E07 RID: 81415 RVA: 0x001C15E3 File Offset: 0x001BF7E3
		public virtual void SetStudyDate(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetStudyDate_113(base.GetCppThis(), _arg);
		}

		// Token: 0x06013E08 RID: 81416
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetStudyDescription_114(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Study description
		/// For ex: DICOM (0008,1030) = BRAIN/C-SP/FACIAL
		/// </summary>
		// Token: 0x06013E09 RID: 81417 RVA: 0x001C15F3 File Offset: 0x001BF7F3
		public virtual void SetStudyDescription(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetStudyDescription_114(base.GetCppThis(), _arg);
		}

		// Token: 0x06013E0A RID: 81418
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetStudyID_115(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Study ID
		/// For ex: DICOM (0020,0010) = 37481
		/// </summary>
		// Token: 0x06013E0B RID: 81419 RVA: 0x001C1603 File Offset: 0x001BF803
		public virtual void SetStudyID(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetStudyID_115(base.GetCppThis(), _arg);
		}

		// Token: 0x06013E0C RID: 81420
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetStudyTime_116(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Study Time
		/// Format: hhmmss.frac (any trailing component(s) can be omitted)
		/// For ex: DICOM (0008,0030) = 162552.0705 or 230012, or 0012
		/// </summary>
		// Token: 0x06013E0D RID: 81421 RVA: 0x001C1613 File Offset: 0x001BF813
		public virtual void SetStudyTime(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetStudyTime_116(base.GetCppThis(), _arg);
		}

		// Token: 0x06013E0E RID: 81422
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageProperties_SetXRayTubeCurrent_117(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// X-ray tube current (in mA)
		/// For ex: DICOM (0018,1151) = 400
		/// </summary>
		// Token: 0x06013E0F RID: 81423 RVA: 0x001C1623 File Offset: 0x001BF823
		public virtual void SetXRayTubeCurrent(string _arg)
		{
			vtkMedicalImageProperties.vtkMedicalImageProperties_SetXRayTubeCurrent_117(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016C8 RID: 5832
		public new const string MRFullTypeName = "Kitware.VTK.vtkMedicalImageProperties";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016C9 RID: 5833
		public new static readonly string MRClassNameKey = "class vtkMedicalImageProperties";

		/// <summary>
		/// Provides the inverse mapping. Returns -1 if a slice for this uid is
		/// not found.
		/// </summary>
		// Token: 0x0200078C RID: 1932
		public enum OrientationType
		{
			/// <summary>enum member</summary>
			// Token: 0x040016CB RID: 5835
			AXIAL,
			/// <summary>enum member</summary>
			// Token: 0x040016CC RID: 5836
			CORONAL,
			/// <summary>enum member</summary>
			// Token: 0x040016CD RID: 5837
			SAGITTAL
		}
	}
}
