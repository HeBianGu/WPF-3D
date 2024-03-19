using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// \class vtkNIFTIReader
	/// \brief Read NIfTI-1 and NIfTI-2 medical image files
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
	///
	/// This class was contributed to VTK by the Calgary Image Processing and
	/// Analysis Centre (CIPAC).
	///
	/// \sa vtkNIFTIWriter, vtkNIFTIHeader
	/// </summary>
	// Token: 0x0200004E RID: 78
	public class vtkNIFTIReader : vtkImageReader2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000D21 RID: 3361 RVA: 0x00019827 File Offset: 0x00017A27
		static vtkNIFTIReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNIFTIReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNIFTIReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000D22 RID: 3362 RVA: 0x0001984F File Offset: 0x00017A4F
		public vtkNIFTIReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000D23 RID: 3363
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D24 RID: 3364 RVA: 0x00019860 File Offset: 0x00017A60
		public new static vtkNIFTIReader New()
		{
			vtkNIFTIReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIReader.vtkNIFTIReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNIFTIReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D25 RID: 3365 RVA: 0x000198B4 File Offset: 0x00017AB4
		public vtkNIFTIReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNIFTIReader.vtkNIFTIReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000D26 RID: 3366 RVA: 0x000198F8 File Offset: 0x00017AF8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000D27 RID: 3367
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D28 RID: 3368 RVA: 0x00019904 File Offset: 0x00017B04
		public override int CanReadFile(string filename)
		{
			return vtkNIFTIReader.vtkNIFTIReader_CanReadFile_01(base.GetCppThis(), filename);
		}

		// Token: 0x06000D29 RID: 3369
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIReader_GetDescriptiveName_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D2A RID: 3370 RVA: 0x00019924 File Offset: 0x00017B24
		public override string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkNIFTIReader.vtkNIFTIReader_GetDescriptiveName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000D2B RID: 3371
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIReader_GetFileExtensions_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D2C RID: 3372 RVA: 0x00019960 File Offset: 0x00017B60
		public override string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkNIFTIReader.vtkNIFTIReader_GetFileExtensions_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000D2D RID: 3373
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIReader_GetNIFTIHeader_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D2E RID: 3374 RVA: 0x0001999C File Offset: 0x00017B9C
		public vtkNIFTIHeader GetNIFTIHeader()
		{
			vtkNIFTIHeader vtkNIFTIHeader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIReader.vtkNIFTIReader_GetNIFTIHeader_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000D2F RID: 3375
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIReader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D30 RID: 3376 RVA: 0x00019A0C File Offset: 0x00017C0C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNIFTIReader.vtkNIFTIReader_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06000D31 RID: 3377
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIReader_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D32 RID: 3378 RVA: 0x00019A2C File Offset: 0x00017C2C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNIFTIReader.vtkNIFTIReader_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06000D33 RID: 3379
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkNIFTIReader_GetPlanarRGB_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D34 RID: 3380 RVA: 0x00019A48 File Offset: 0x00017C48
		public virtual bool GetPlanarRGB()
		{
			return vtkNIFTIReader.vtkNIFTIReader_GetPlanarRGB_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06000D35 RID: 3381
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIReader_GetQFac_08(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D36 RID: 3382 RVA: 0x00019A70 File Offset: 0x00017C70
		public double GetQFac()
		{
			return vtkNIFTIReader.vtkNIFTIReader_GetQFac_08(base.GetCppThis());
		}

		// Token: 0x06000D37 RID: 3383
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIReader_GetQFormMatrix_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D38 RID: 3384 RVA: 0x00019A90 File Offset: 0x00017C90
		public vtkMatrix4x4 GetQFormMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIReader.vtkNIFTIReader_GetQFormMatrix_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000D39 RID: 3385
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIReader_GetRescaleIntercept_10(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D3A RID: 3386 RVA: 0x00019B00 File Offset: 0x00017D00
		public double GetRescaleIntercept()
		{
			return vtkNIFTIReader.vtkNIFTIReader_GetRescaleIntercept_10(base.GetCppThis());
		}

		// Token: 0x06000D3B RID: 3387
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIReader_GetRescaleSlope_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D3C RID: 3388 RVA: 0x00019B20 File Offset: 0x00017D20
		public double GetRescaleSlope()
		{
			return vtkNIFTIReader.vtkNIFTIReader_GetRescaleSlope_11(base.GetCppThis());
		}

		// Token: 0x06000D3D RID: 3389
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIReader_GetSFormMatrix_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D3E RID: 3390 RVA: 0x00019B40 File Offset: 0x00017D40
		public vtkMatrix4x4 GetSFormMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIReader.vtkNIFTIReader_GetSFormMatrix_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000D3F RID: 3391
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIReader_GetTimeAsVector_13(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D40 RID: 3392 RVA: 0x00019BB0 File Offset: 0x00017DB0
		public virtual int GetTimeAsVector()
		{
			return vtkNIFTIReader.vtkNIFTIReader_GetTimeAsVector_13(base.GetCppThis());
		}

		// Token: 0x06000D41 RID: 3393
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIReader_GetTimeDimension_14(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D42 RID: 3394 RVA: 0x00019BD0 File Offset: 0x00017DD0
		public int GetTimeDimension()
		{
			return vtkNIFTIReader.vtkNIFTIReader_GetTimeDimension_14(base.GetCppThis());
		}

		// Token: 0x06000D43 RID: 3395
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIReader_GetTimeSpacing_15(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D44 RID: 3396 RVA: 0x00019BF0 File Offset: 0x00017DF0
		public double GetTimeSpacing()
		{
			return vtkNIFTIReader.vtkNIFTIReader_GetTimeSpacing_15(base.GetCppThis());
		}

		// Token: 0x06000D45 RID: 3397
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIReader_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D46 RID: 3398 RVA: 0x00019C10 File Offset: 0x00017E10
		public override int IsA(string type)
		{
			return vtkNIFTIReader.vtkNIFTIReader_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06000D47 RID: 3399
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIReader_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D48 RID: 3400 RVA: 0x00019C30 File Offset: 0x00017E30
		public new static int IsTypeOf(string type)
		{
			return vtkNIFTIReader.vtkNIFTIReader_IsTypeOf_17(type);
		}

		// Token: 0x06000D49 RID: 3401
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIReader_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D4A RID: 3402 RVA: 0x00019C4C File Offset: 0x00017E4C
		public new vtkNIFTIReader NewInstance()
		{
			vtkNIFTIReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIReader.vtkNIFTIReader_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNIFTIReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000D4B RID: 3403
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIReader_PlanarRGBOff_20(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D4C RID: 3404 RVA: 0x00019CA6 File Offset: 0x00017EA6
		public virtual void PlanarRGBOff()
		{
			vtkNIFTIReader.vtkNIFTIReader_PlanarRGBOff_20(base.GetCppThis());
		}

		// Token: 0x06000D4D RID: 3405
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIReader_PlanarRGBOn_21(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D4E RID: 3406 RVA: 0x00019CB5 File Offset: 0x00017EB5
		public virtual void PlanarRGBOn()
		{
			vtkNIFTIReader.vtkNIFTIReader_PlanarRGBOn_21(base.GetCppThis());
		}

		// Token: 0x06000D4F RID: 3407
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIReader_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D50 RID: 3408 RVA: 0x00019CC4 File Offset: 0x00017EC4
		public new static vtkNIFTIReader SafeDownCast(vtkObjectBase o)
		{
			vtkNIFTIReader vtkNIFTIReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIReader.vtkNIFTIReader_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNIFTIReader = (vtkNIFTIReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNIFTIReader.Register(null);
				}
			}
			return vtkNIFTIReader;
		}

		// Token: 0x06000D51 RID: 3409
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIReader_SetPlanarRGB_23(HandleRef pThis, byte _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D52 RID: 3410 RVA: 0x00019D43 File Offset: 0x00017F43
		public virtual void SetPlanarRGB(bool _arg)
		{
			vtkNIFTIReader.vtkNIFTIReader_SetPlanarRGB_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06000D53 RID: 3411
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIReader_SetTimeAsVector_24(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D54 RID: 3412 RVA: 0x00019D5B File Offset: 0x00017F5B
		public virtual void SetTimeAsVector(int _arg)
		{
			vtkNIFTIReader.vtkNIFTIReader_SetTimeAsVector_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D55 RID: 3413
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIReader_TimeAsVectorOff_25(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D56 RID: 3414 RVA: 0x00019D6B File Offset: 0x00017F6B
		public virtual void TimeAsVectorOff()
		{
			vtkNIFTIReader.vtkNIFTIReader_TimeAsVectorOff_25(base.GetCppThis());
		}

		// Token: 0x06000D57 RID: 3415
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIReader_TimeAsVectorOn_26(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D58 RID: 3416 RVA: 0x00019D7A File Offset: 0x00017F7A
		public virtual void TimeAsVectorOn()
		{
			vtkNIFTIReader.vtkNIFTIReader_TimeAsVectorOn_26(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400041D RID: 1053
		public new const string MRFullTypeName = "Kitware.VTK.vtkNIFTIReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400041E RID: 1054
		public new static readonly string MRClassNameKey = "class vtkNIFTIReader";
	}
}
