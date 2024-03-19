using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// \class vtkNIFTIHeader
	/// \brief Store NIfTI header information.
	///
	/// This class stores the header of a NIfTI file in a VTK-friendly format.
	/// By using this class, it is possible to specify the header information
	/// that will be stored in a file written by the vtkNIFTIWriter.  Note
	/// that the SForm and QForm orientation information in this class will be
	/// ignored by the writer if an SForm and QForm have been explicitly set
	/// via the writer's SetSForm and SetQForm methods.  Also note that all
	/// info like Dim, PixDim, DataType, etc. will be ignored by the writer
	/// because this information must instead be taken from the vtkImageData
	/// information.  Finally, note that the vtkNIFTIWriter will ignore the
	/// Descrip field, since it has its own SetDescription method.
	///
	/// This class was contributed to VTK by the Calgary Image Processing and
	/// Analysis Centre (CIPAC).
	///
	/// \sa vtkNIFTIReader, vtkNIFTIWriter
	/// </summary>
	// Token: 0x02000047 RID: 71
	public class vtkNIFTIHeader : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000C79 RID: 3193 RVA: 0x00018DF9 File Offset: 0x00016FF9
		static vtkNIFTIHeader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNIFTIHeader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNIFTIHeader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000C7A RID: 3194 RVA: 0x00018E21 File Offset: 0x00017021
		public vtkNIFTIHeader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000C7B RID: 3195
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIHeader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C7C RID: 3196 RVA: 0x00018E30 File Offset: 0x00017030
		public new static vtkNIFTIHeader New()
		{
			vtkNIFTIHeader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIHeader.vtkNIFTIHeader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNIFTIHeader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C7D RID: 3197 RVA: 0x00018E84 File Offset: 0x00017084
		public vtkNIFTIHeader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNIFTIHeader.vtkNIFTIHeader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000C7E RID: 3198 RVA: 0x00018EC8 File Offset: 0x000170C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000C7F RID: 3199
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_DeepCopy_01(HandleRef pThis, HandleRef o);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C80 RID: 3200 RVA: 0x00018ED4 File Offset: 0x000170D4
		public void DeepCopy(vtkNIFTIHeader o)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_DeepCopy_01(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis());
		}

		// Token: 0x06000C81 RID: 3201
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIHeader_GetAuxFile_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C82 RID: 3202 RVA: 0x00018F04 File Offset: 0x00017104
		public string GetAuxFile()
		{
			string s = Marshal.PtrToStringAnsi(vtkNIFTIHeader.vtkNIFTIHeader_GetAuxFile_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000C83 RID: 3203
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIHeader_GetBitPix_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C84 RID: 3204 RVA: 0x00018F40 File Offset: 0x00017140
		public int GetBitPix()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetBitPix_03(base.GetCppThis());
		}

		// Token: 0x06000C85 RID: 3205
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIHeader_GetCalMax_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C86 RID: 3206 RVA: 0x00018F60 File Offset: 0x00017160
		public double GetCalMax()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetCalMax_04(base.GetCppThis());
		}

		// Token: 0x06000C87 RID: 3207
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIHeader_GetCalMin_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C88 RID: 3208 RVA: 0x00018F80 File Offset: 0x00017180
		public double GetCalMin()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetCalMin_05(base.GetCppThis());
		}

		// Token: 0x06000C89 RID: 3209
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIHeader_GetDataType_06(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C8A RID: 3210 RVA: 0x00018FA0 File Offset: 0x000171A0
		public int GetDataType()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetDataType_06(base.GetCppThis());
		}

		// Token: 0x06000C8B RID: 3211
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIHeader_GetDescrip_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C8C RID: 3212 RVA: 0x00018FC0 File Offset: 0x000171C0
		public string GetDescrip()
		{
			string s = Marshal.PtrToStringAnsi(vtkNIFTIHeader.vtkNIFTIHeader_GetDescrip_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000C8D RID: 3213
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIHeader_GetDim_08(HandleRef pThis, int i);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C8E RID: 3214 RVA: 0x00018FFC File Offset: 0x000171FC
		public long GetDim(int i)
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetDim_08(base.GetCppThis(), i);
		}

		// Token: 0x06000C8F RID: 3215
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIHeader_GetDimInfo_09(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C90 RID: 3216 RVA: 0x0001901C File Offset: 0x0001721C
		public int GetDimInfo()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetDimInfo_09(base.GetCppThis());
		}

		// Token: 0x06000C91 RID: 3217
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIHeader_GetIntentCode_10(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C92 RID: 3218 RVA: 0x0001903C File Offset: 0x0001723C
		public int GetIntentCode()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetIntentCode_10(base.GetCppThis());
		}

		// Token: 0x06000C93 RID: 3219
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIHeader_GetIntentName_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C94 RID: 3220 RVA: 0x0001905C File Offset: 0x0001725C
		public string GetIntentName()
		{
			string s = Marshal.PtrToStringAnsi(vtkNIFTIHeader.vtkNIFTIHeader_GetIntentName_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000C95 RID: 3221
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIHeader_GetIntentP1_12(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C96 RID: 3222 RVA: 0x00019098 File Offset: 0x00017298
		public double GetIntentP1()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetIntentP1_12(base.GetCppThis());
		}

		// Token: 0x06000C97 RID: 3223
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIHeader_GetIntentP2_13(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C98 RID: 3224 RVA: 0x000190B8 File Offset: 0x000172B8
		public double GetIntentP2()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetIntentP2_13(base.GetCppThis());
		}

		// Token: 0x06000C99 RID: 3225
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIHeader_GetIntentP3_14(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C9A RID: 3226 RVA: 0x000190D8 File Offset: 0x000172D8
		public double GetIntentP3()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetIntentP3_14(base.GetCppThis());
		}

		// Token: 0x06000C9B RID: 3227
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIHeader_GetMagic_15(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C9C RID: 3228 RVA: 0x000190F8 File Offset: 0x000172F8
		public string GetMagic()
		{
			string s = Marshal.PtrToStringAnsi(vtkNIFTIHeader.vtkNIFTIHeader_GetMagic_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000C9D RID: 3229
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIHeader_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C9E RID: 3230 RVA: 0x00019134 File Offset: 0x00017334
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x06000C9F RID: 3231
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIHeader_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CA0 RID: 3232 RVA: 0x00019154 File Offset: 0x00017354
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x06000CA1 RID: 3233
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIHeader_GetPixDim_18(HandleRef pThis, int i);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CA2 RID: 3234 RVA: 0x00019170 File Offset: 0x00017370
		public double GetPixDim(int i)
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetPixDim_18(base.GetCppThis(), i);
		}

		// Token: 0x06000CA3 RID: 3235
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIHeader_GetQFormCode_19(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CA4 RID: 3236 RVA: 0x00019190 File Offset: 0x00017390
		public int GetQFormCode()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetQFormCode_19(base.GetCppThis());
		}

		// Token: 0x06000CA5 RID: 3237
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIHeader_GetQOffsetX_20(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CA6 RID: 3238 RVA: 0x000191B0 File Offset: 0x000173B0
		public double GetQOffsetX()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetQOffsetX_20(base.GetCppThis());
		}

		// Token: 0x06000CA7 RID: 3239
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIHeader_GetQOffsetY_21(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CA8 RID: 3240 RVA: 0x000191D0 File Offset: 0x000173D0
		public double GetQOffsetY()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetQOffsetY_21(base.GetCppThis());
		}

		// Token: 0x06000CA9 RID: 3241
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIHeader_GetQOffsetZ_22(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CAA RID: 3242 RVA: 0x000191F0 File Offset: 0x000173F0
		public double GetQOffsetZ()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetQOffsetZ_22(base.GetCppThis());
		}

		// Token: 0x06000CAB RID: 3243
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIHeader_GetQuaternB_23(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CAC RID: 3244 RVA: 0x00019210 File Offset: 0x00017410
		public double GetQuaternB()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetQuaternB_23(base.GetCppThis());
		}

		// Token: 0x06000CAD RID: 3245
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIHeader_GetQuaternC_24(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CAE RID: 3246 RVA: 0x00019230 File Offset: 0x00017430
		public double GetQuaternC()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetQuaternC_24(base.GetCppThis());
		}

		// Token: 0x06000CAF RID: 3247
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIHeader_GetQuaternD_25(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CB0 RID: 3248 RVA: 0x00019250 File Offset: 0x00017450
		public double GetQuaternD()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetQuaternD_25(base.GetCppThis());
		}

		// Token: 0x06000CB1 RID: 3249
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIHeader_GetSFormCode_26(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CB2 RID: 3250 RVA: 0x00019270 File Offset: 0x00017470
		public int GetSFormCode()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetSFormCode_26(base.GetCppThis());
		}

		// Token: 0x06000CB3 RID: 3251
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIHeader_GetSRowX_27(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CB4 RID: 3252 RVA: 0x00019290 File Offset: 0x00017490
		public virtual double[] GetSRowX()
		{
			IntPtr intPtr = vtkNIFTIHeader.vtkNIFTIHeader_GetSRowX_27(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000CB5 RID: 3253
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_GetSRowX_28(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CB6 RID: 3254 RVA: 0x000192D8 File Offset: 0x000174D8
		public virtual void GetSRowX(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_GetSRowX_28(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x06000CB7 RID: 3255
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_GetSRowX_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CB8 RID: 3256 RVA: 0x000192EC File Offset: 0x000174EC
		public virtual void GetSRowX(IntPtr _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_GetSRowX_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06000CB9 RID: 3257
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIHeader_GetSRowY_30(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CBA RID: 3258 RVA: 0x000192FC File Offset: 0x000174FC
		public virtual double[] GetSRowY()
		{
			IntPtr intPtr = vtkNIFTIHeader.vtkNIFTIHeader_GetSRowY_30(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000CBB RID: 3259
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_GetSRowY_31(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CBC RID: 3260 RVA: 0x00019344 File Offset: 0x00017544
		public virtual void GetSRowY(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_GetSRowY_31(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x06000CBD RID: 3261
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_GetSRowY_32(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CBE RID: 3262 RVA: 0x00019358 File Offset: 0x00017558
		public virtual void GetSRowY(IntPtr _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_GetSRowY_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06000CBF RID: 3263
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_GetSRowZ_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CC0 RID: 3264 RVA: 0x00019368 File Offset: 0x00017568
		public virtual void GetSRowZ(IntPtr _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_GetSRowZ_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06000CC1 RID: 3265
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIHeader_GetSRowZ_34(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CC2 RID: 3266 RVA: 0x00019378 File Offset: 0x00017578
		public virtual double[] GetSRowZ()
		{
			IntPtr intPtr = vtkNIFTIHeader.vtkNIFTIHeader_GetSRowZ_34(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000CC3 RID: 3267
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_GetSRowZ_35(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CC4 RID: 3268 RVA: 0x000193C0 File Offset: 0x000175C0
		public virtual void GetSRowZ(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_GetSRowZ_35(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x06000CC5 RID: 3269
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIHeader_GetSclInter_36(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CC6 RID: 3270 RVA: 0x000193D4 File Offset: 0x000175D4
		public double GetSclInter()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetSclInter_36(base.GetCppThis());
		}

		// Token: 0x06000CC7 RID: 3271
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIHeader_GetSclSlope_37(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CC8 RID: 3272 RVA: 0x000193F4 File Offset: 0x000175F4
		public double GetSclSlope()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetSclSlope_37(base.GetCppThis());
		}

		// Token: 0x06000CC9 RID: 3273
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIHeader_GetSliceCode_38(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CCA RID: 3274 RVA: 0x00019414 File Offset: 0x00017614
		public int GetSliceCode()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetSliceCode_38(base.GetCppThis());
		}

		// Token: 0x06000CCB RID: 3275
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIHeader_GetSliceDuration_39(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CCC RID: 3276 RVA: 0x00019434 File Offset: 0x00017634
		public double GetSliceDuration()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetSliceDuration_39(base.GetCppThis());
		}

		// Token: 0x06000CCD RID: 3277
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIHeader_GetSliceEnd_40(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CCE RID: 3278 RVA: 0x00019454 File Offset: 0x00017654
		public long GetSliceEnd()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetSliceEnd_40(base.GetCppThis());
		}

		// Token: 0x06000CCF RID: 3279
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIHeader_GetSliceStart_41(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CD0 RID: 3280 RVA: 0x00019474 File Offset: 0x00017674
		public long GetSliceStart()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetSliceStart_41(base.GetCppThis());
		}

		// Token: 0x06000CD1 RID: 3281
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIHeader_GetTOffset_42(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CD2 RID: 3282 RVA: 0x00019494 File Offset: 0x00017694
		public double GetTOffset()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetTOffset_42(base.GetCppThis());
		}

		// Token: 0x06000CD3 RID: 3283
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIHeader_GetVoxOffset_43(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CD4 RID: 3284 RVA: 0x000194B4 File Offset: 0x000176B4
		public long GetVoxOffset()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetVoxOffset_43(base.GetCppThis());
		}

		// Token: 0x06000CD5 RID: 3285
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIHeader_GetXYZTUnits_44(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CD6 RID: 3286 RVA: 0x000194D4 File Offset: 0x000176D4
		public int GetXYZTUnits()
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_GetXYZTUnits_44(base.GetCppThis());
		}

		// Token: 0x06000CD7 RID: 3287
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_Initialize_45(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CD8 RID: 3288 RVA: 0x000194F3 File Offset: 0x000176F3
		public void Initialize()
		{
			vtkNIFTIHeader.vtkNIFTIHeader_Initialize_45(base.GetCppThis());
		}

		// Token: 0x06000CD9 RID: 3289
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIHeader_IsA_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CDA RID: 3290 RVA: 0x00019504 File Offset: 0x00017704
		public override int IsA(string type)
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_IsA_46(base.GetCppThis(), type);
		}

		// Token: 0x06000CDB RID: 3291
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIHeader_IsTypeOf_47([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CDC RID: 3292 RVA: 0x00019524 File Offset: 0x00017724
		public new static int IsTypeOf(string type)
		{
			return vtkNIFTIHeader.vtkNIFTIHeader_IsTypeOf_47(type);
		}

		// Token: 0x06000CDD RID: 3293
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIHeader_NewInstance_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CDE RID: 3294 RVA: 0x00019540 File Offset: 0x00017740
		public new vtkNIFTIHeader NewInstance()
		{
			vtkNIFTIHeader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIHeader.vtkNIFTIHeader_NewInstance_49(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNIFTIHeader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000CDF RID: 3295
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIHeader_SafeDownCast_50(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CE0 RID: 3296 RVA: 0x0001959C File Offset: 0x0001779C
		public new static vtkNIFTIHeader SafeDownCast(vtkObjectBase o)
		{
			vtkNIFTIHeader vtkNIFTIHeader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIHeader.vtkNIFTIHeader_SafeDownCast_50((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNIFTIHeader = (vtkNIFTIHeader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNIFTIHeader.Register(null);
				}
			}
			return vtkNIFTIHeader;
		}

		// Token: 0x06000CE1 RID: 3297
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetAuxFile_51(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string auxfile);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CE2 RID: 3298 RVA: 0x0001961B File Offset: 0x0001781B
		public void SetAuxFile(string auxfile)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetAuxFile_51(base.GetCppThis(), auxfile);
		}

		// Token: 0x06000CE3 RID: 3299
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetCalMax_52(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CE4 RID: 3300 RVA: 0x0001962B File Offset: 0x0001782B
		public virtual void SetCalMax(double _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetCalMax_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06000CE5 RID: 3301
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetCalMin_53(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CE6 RID: 3302 RVA: 0x0001963B File Offset: 0x0001783B
		public virtual void SetCalMin(double _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetCalMin_53(base.GetCppThis(), _arg);
		}

		// Token: 0x06000CE7 RID: 3303
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetDescrip_54(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string descrip);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CE8 RID: 3304 RVA: 0x0001964B File Offset: 0x0001784B
		public void SetDescrip(string descrip)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetDescrip_54(base.GetCppThis(), descrip);
		}

		// Token: 0x06000CE9 RID: 3305
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetDimInfo_55(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CEA RID: 3306 RVA: 0x0001965B File Offset: 0x0001785B
		public virtual void SetDimInfo(int _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetDimInfo_55(base.GetCppThis(), _arg);
		}

		// Token: 0x06000CEB RID: 3307
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetIntentCode_56(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CEC RID: 3308 RVA: 0x0001966B File Offset: 0x0001786B
		public virtual void SetIntentCode(int _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetIntentCode_56(base.GetCppThis(), _arg);
		}

		// Token: 0x06000CED RID: 3309
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetIntentName_57(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CEE RID: 3310 RVA: 0x0001967B File Offset: 0x0001787B
		public void SetIntentName(string name)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetIntentName_57(base.GetCppThis(), name);
		}

		// Token: 0x06000CEF RID: 3311
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetIntentP1_58(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CF0 RID: 3312 RVA: 0x0001968B File Offset: 0x0001788B
		public virtual void SetIntentP1(double _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetIntentP1_58(base.GetCppThis(), _arg);
		}

		// Token: 0x06000CF1 RID: 3313
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetIntentP2_59(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CF2 RID: 3314 RVA: 0x0001969B File Offset: 0x0001789B
		public virtual void SetIntentP2(double _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetIntentP2_59(base.GetCppThis(), _arg);
		}

		// Token: 0x06000CF3 RID: 3315
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetIntentP3_60(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CF4 RID: 3316 RVA: 0x000196AB File Offset: 0x000178AB
		public virtual void SetIntentP3(double _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetIntentP3_60(base.GetCppThis(), _arg);
		}

		// Token: 0x06000CF5 RID: 3317
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetQFormCode_61(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CF6 RID: 3318 RVA: 0x000196BB File Offset: 0x000178BB
		public virtual void SetQFormCode(int _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetQFormCode_61(base.GetCppThis(), _arg);
		}

		// Token: 0x06000CF7 RID: 3319
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetQOffsetX_62(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CF8 RID: 3320 RVA: 0x000196CB File Offset: 0x000178CB
		public virtual void SetQOffsetX(double _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetQOffsetX_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06000CF9 RID: 3321
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetQOffsetY_63(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CFA RID: 3322 RVA: 0x000196DB File Offset: 0x000178DB
		public virtual void SetQOffsetY(double _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetQOffsetY_63(base.GetCppThis(), _arg);
		}

		// Token: 0x06000CFB RID: 3323
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetQOffsetZ_64(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CFC RID: 3324 RVA: 0x000196EB File Offset: 0x000178EB
		public virtual void SetQOffsetZ(double _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetQOffsetZ_64(base.GetCppThis(), _arg);
		}

		// Token: 0x06000CFD RID: 3325
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetQuaternB_65(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000CFE RID: 3326 RVA: 0x000196FB File Offset: 0x000178FB
		public virtual void SetQuaternB(double _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetQuaternB_65(base.GetCppThis(), _arg);
		}

		// Token: 0x06000CFF RID: 3327
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetQuaternC_66(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D00 RID: 3328 RVA: 0x0001970B File Offset: 0x0001790B
		public virtual void SetQuaternC(double _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetQuaternC_66(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D01 RID: 3329
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetQuaternD_67(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D02 RID: 3330 RVA: 0x0001971B File Offset: 0x0001791B
		public virtual void SetQuaternD(double _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetQuaternD_67(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D03 RID: 3331
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetSFormCode_68(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D04 RID: 3332 RVA: 0x0001972B File Offset: 0x0001792B
		public virtual void SetSFormCode(int _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetSFormCode_68(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D05 RID: 3333
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetSRowX_69(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D06 RID: 3334 RVA: 0x0001973B File Offset: 0x0001793B
		public virtual void SetSRowX(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetSRowX_69(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x06000D07 RID: 3335
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetSRowX_70(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D08 RID: 3336 RVA: 0x0001974F File Offset: 0x0001794F
		public virtual void SetSRowX(IntPtr _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetSRowX_70(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D09 RID: 3337
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetSRowY_71(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D0A RID: 3338 RVA: 0x0001975F File Offset: 0x0001795F
		public virtual void SetSRowY(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetSRowY_71(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x06000D0B RID: 3339
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetSRowY_72(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D0C RID: 3340 RVA: 0x00019773 File Offset: 0x00017973
		public virtual void SetSRowY(IntPtr _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetSRowY_72(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D0D RID: 3341
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetSRowZ_73(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D0E RID: 3342 RVA: 0x00019783 File Offset: 0x00017983
		public virtual void SetSRowZ(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetSRowZ_73(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x06000D0F RID: 3343
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetSRowZ_74(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D10 RID: 3344 RVA: 0x00019797 File Offset: 0x00017997
		public virtual void SetSRowZ(IntPtr _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetSRowZ_74(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D11 RID: 3345
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetSclInter_75(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D12 RID: 3346 RVA: 0x000197A7 File Offset: 0x000179A7
		public virtual void SetSclInter(double _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetSclInter_75(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D13 RID: 3347
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetSclSlope_76(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D14 RID: 3348 RVA: 0x000197B7 File Offset: 0x000179B7
		public virtual void SetSclSlope(double _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetSclSlope_76(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D15 RID: 3349
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetSliceCode_77(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D16 RID: 3350 RVA: 0x000197C7 File Offset: 0x000179C7
		public virtual void SetSliceCode(int _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetSliceCode_77(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D17 RID: 3351
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetSliceDuration_78(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D18 RID: 3352 RVA: 0x000197D7 File Offset: 0x000179D7
		public virtual void SetSliceDuration(double _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetSliceDuration_78(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D19 RID: 3353
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetSliceEnd_79(HandleRef pThis, long _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D1A RID: 3354 RVA: 0x000197E7 File Offset: 0x000179E7
		public virtual void SetSliceEnd(long _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetSliceEnd_79(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D1B RID: 3355
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetSliceStart_80(HandleRef pThis, long _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D1C RID: 3356 RVA: 0x000197F7 File Offset: 0x000179F7
		public virtual void SetSliceStart(long _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetSliceStart_80(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D1D RID: 3357
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetTOffset_81(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D1E RID: 3358 RVA: 0x00019807 File Offset: 0x00017A07
		public virtual void SetTOffset(double _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetTOffset_81(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D1F RID: 3359
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIHeader_SetXYZTUnits_82(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D20 RID: 3360 RVA: 0x00019817 File Offset: 0x00017A17
		public virtual void SetXYZTUnits(int _arg)
		{
			vtkNIFTIHeader.vtkNIFTIHeader_SetXYZTUnits_82(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003C2 RID: 962
		public new const string MRFullTypeName = "Kitware.VTK.vtkNIFTIHeader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003C3 RID: 963
		public new static readonly string MRClassNameKey = "class vtkNIFTIHeader";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000048 RID: 72
		public enum DataTypeEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040003C5 RID: 965
			TypeComplex128 = 1792,
			/// <summary>enum member</summary>
			// Token: 0x040003C6 RID: 966
			TypeComplex256 = 2048,
			/// <summary>enum member</summary>
			// Token: 0x040003C7 RID: 967
			TypeComplex64 = 32,
			/// <summary>enum member</summary>
			// Token: 0x040003C8 RID: 968
			TypeFloat128 = 1536,
			/// <summary>enum member</summary>
			// Token: 0x040003C9 RID: 969
			TypeFloat32 = 16,
			/// <summary>enum member</summary>
			// Token: 0x040003CA RID: 970
			TypeFloat64 = 64,
			/// <summary>enum member</summary>
			// Token: 0x040003CB RID: 971
			TypeInt16 = 4,
			/// <summary>enum member</summary>
			// Token: 0x040003CC RID: 972
			TypeInt32 = 8,
			/// <summary>enum member</summary>
			// Token: 0x040003CD RID: 973
			TypeInt64 = 1024,
			/// <summary>enum member</summary>
			// Token: 0x040003CE RID: 974
			TypeInt8 = 256,
			/// <summary>enum member</summary>
			// Token: 0x040003CF RID: 975
			TypeRGB24 = 128,
			/// <summary>enum member</summary>
			// Token: 0x040003D0 RID: 976
			TypeRGBA32 = 2304,
			/// <summary>enum member</summary>
			// Token: 0x040003D1 RID: 977
			TypeUInt16 = 512,
			/// <summary>enum member</summary>
			// Token: 0x040003D2 RID: 978
			TypeUInt32 = 768,
			/// <summary>enum member</summary>
			// Token: 0x040003D3 RID: 979
			TypeUInt64 = 1280,
			/// <summary>enum member</summary>
			// Token: 0x040003D4 RID: 980
			TypeUInt8 = 2
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000049 RID: 73
		public enum HeaderSizeEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040003D6 RID: 982
			Nifti1HeaderSize = 348,
			/// <summary>enum member</summary>
			// Token: 0x040003D7 RID: 983
			Nifti2HeaderSize = 540
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200004A RID: 74
		public enum IntentCodeEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040003D9 RID: 985
			IntentBeta = 7,
			/// <summary>enum member</summary>
			// Token: 0x040003DA RID: 986
			IntentBinom,
			/// <summary>enum member</summary>
			// Token: 0x040003DB RID: 987
			IntentChi = 19,
			/// <summary>enum member</summary>
			// Token: 0x040003DC RID: 988
			IntentChiSQ = 6,
			/// <summary>enum member</summary>
			// Token: 0x040003DD RID: 989
			IntentChiSQNonc = 13,
			/// <summary>enum member</summary>
			// Token: 0x040003DE RID: 990
			IntentCorrel = 2,
			/// <summary>enum member</summary>
			// Token: 0x040003DF RID: 991
			IntentDimless = 1011,
			/// <summary>enum member</summary>
			// Token: 0x040003E0 RID: 992
			IntentDispVect = 1006,
			/// <summary>enum member</summary>
			// Token: 0x040003E1 RID: 993
			IntentEstimate = 1001,
			/// <summary>enum member</summary>
			// Token: 0x040003E2 RID: 994
			IntentExtVal = 21,
			/// <summary>enum member</summary>
			// Token: 0x040003E3 RID: 995
			IntentFTest = 4,
			/// <summary>enum member</summary>
			// Token: 0x040003E4 RID: 996
			IntentFTestNonc = 12,
			/// <summary>enum member</summary>
			// Token: 0x040003E5 RID: 997
			IntentGamma = 9,
			/// <summary>enum member</summary>
			// Token: 0x040003E6 RID: 998
			IntentGenMatrix = 1004,
			/// <summary>enum member</summary>
			// Token: 0x040003E7 RID: 999
			IntentInvGauss = 20,
			/// <summary>enum member</summary>
			// Token: 0x040003E8 RID: 1000
			IntentLabel = 1002,
			/// <summary>enum member</summary>
			// Token: 0x040003E9 RID: 1001
			IntentLaplace = 15,
			/// <summary>enum member</summary>
			// Token: 0x040003EA RID: 1002
			IntentLog10PVal = 24,
			/// <summary>enum member</summary>
			// Token: 0x040003EB RID: 1003
			IntentLogPVal = 23,
			/// <summary>enum member</summary>
			// Token: 0x040003EC RID: 1004
			IntentLogistic = 14,
			/// <summary>enum member</summary>
			// Token: 0x040003ED RID: 1005
			IntentNeuroName = 1003,
			/// <summary>enum member</summary>
			// Token: 0x040003EE RID: 1006
			IntentNodeIndex = 2002,
			/// <summary>enum member</summary>
			// Token: 0x040003EF RID: 1007
			IntentNone = 0,
			/// <summary>enum member</summary>
			// Token: 0x040003F0 RID: 1008
			IntentNormal = 11,
			/// <summary>enum member</summary>
			// Token: 0x040003F1 RID: 1009
			IntentPVal = 22,
			/// <summary>enum member</summary>
			// Token: 0x040003F2 RID: 1010
			IntentPointSet = 1008,
			/// <summary>enum member</summary>
			// Token: 0x040003F3 RID: 1011
			IntentPoisson = 10,
			/// <summary>enum member</summary>
			// Token: 0x040003F4 RID: 1012
			IntentQuaternion = 1010,
			/// <summary>enum member</summary>
			// Token: 0x040003F5 RID: 1013
			IntentRGBAVector = 2004,
			/// <summary>enum member</summary>
			// Token: 0x040003F6 RID: 1014
			IntentRGBVector = 2003,
			/// <summary>enum member</summary>
			// Token: 0x040003F7 RID: 1015
			IntentShape = 2005,
			/// <summary>enum member</summary>
			// Token: 0x040003F8 RID: 1016
			IntentSymMatrix = 1005,
			/// <summary>enum member</summary>
			// Token: 0x040003F9 RID: 1017
			IntentTTest = 3,
			/// <summary>enum member</summary>
			// Token: 0x040003FA RID: 1018
			IntentTTestNonc = 17,
			/// <summary>enum member</summary>
			// Token: 0x040003FB RID: 1019
			IntentTimeSeries = 2001,
			/// <summary>enum member</summary>
			// Token: 0x040003FC RID: 1020
			IntentTriangle = 1009,
			/// <summary>enum member</summary>
			// Token: 0x040003FD RID: 1021
			IntentUniform = 16,
			/// <summary>enum member</summary>
			// Token: 0x040003FE RID: 1022
			IntentVector = 1007,
			/// <summary>enum member</summary>
			// Token: 0x040003FF RID: 1023
			IntentWeibull = 18,
			/// <summary>enum member</summary>
			// Token: 0x04000400 RID: 1024
			IntentZScore = 5
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200004B RID: 75
		public enum SliceCodeEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000402 RID: 1026
			SliceAltDec = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000403 RID: 1027
			SliceAltDec2 = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000404 RID: 1028
			SliceAltInc = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000405 RID: 1029
			SliceAltInc2 = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000406 RID: 1030
			SliceSeqDec = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000407 RID: 1031
			SliceSeqInc = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000408 RID: 1032
			SliceUnknown = 0
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200004C RID: 76
		public enum UnitsXYZTEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400040A RID: 1034
			UnitsHz = 32,
			/// <summary>enum member</summary>
			// Token: 0x0400040B RID: 1035
			UnitsMM = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400040C RID: 1036
			UnitsMSec = 16,
			/// <summary>enum member</summary>
			// Token: 0x0400040D RID: 1037
			UnitsMeter = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400040E RID: 1038
			UnitsMicron = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400040F RID: 1039
			UnitsPPM = 40,
			/// <summary>enum member</summary>
			// Token: 0x04000410 RID: 1040
			UnitsRads = 48,
			/// <summary>enum member</summary>
			// Token: 0x04000411 RID: 1041
			UnitsSec = 8,
			/// <summary>enum member</summary>
			// Token: 0x04000412 RID: 1042
			UnitsSpace = 7,
			/// <summary>enum member</summary>
			// Token: 0x04000413 RID: 1043
			UnitsTime = 56,
			/// <summary>enum member</summary>
			// Token: 0x04000414 RID: 1044
			UnitsUSec = 24,
			/// <summary>enum member</summary>
			// Token: 0x04000415 RID: 1045
			UnitsUnknown = 0
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200004D RID: 77
		public enum XFormCodeEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000417 RID: 1047
			XFormAlignedAnat = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000418 RID: 1048
			XFormMNI152 = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000419 RID: 1049
			XFormScannerAnat = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400041A RID: 1050
			XFormTalairach = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400041B RID: 1051
			XFormTemplateOther = 5,
			/// <summary>enum member</summary>
			// Token: 0x0400041C RID: 1052
			XFormUnkown = 0
		}
	}
}
