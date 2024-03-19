using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// \class vtkNIFTIWriter
	/// \brief Write NIfTI-1 and NIfTI-2 medical image files
	///
	/// This class writes NIFTI files, either in .nii format or as separate
	/// .img and .hdr files.  If told to write a file that ends in ".gz",
	/// then the writer will automatically compress the file with zlib.
	/// Images of type unsigned char that have 3 or 4 scalar components
	/// will automatically be written as RGB or RGBA respectively.  Images
	/// of type float or double that have 2 components will automatically be
	/// written as complex values.
	///
	/// This class was contributed to VTK by the Calgary Image Processing and
	/// Analysis Centre (CIPAC).
	///
	/// \sa vtkNIFTIReader
	/// </summary>
	// Token: 0x0200004F RID: 79
	public class vtkNIFTIWriter : vtkImageWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000D59 RID: 3417 RVA: 0x00019D89 File Offset: 0x00017F89
		static vtkNIFTIWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNIFTIWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNIFTIWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000D5A RID: 3418 RVA: 0x00019DB1 File Offset: 0x00017FB1
		public vtkNIFTIWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000D5B RID: 3419
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D5C RID: 3420 RVA: 0x00019DC0 File Offset: 0x00017FC0
		public new static vtkNIFTIWriter New()
		{
			vtkNIFTIWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIWriter.vtkNIFTIWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNIFTIWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D5D RID: 3421 RVA: 0x00019E14 File Offset: 0x00018014
		public vtkNIFTIWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNIFTIWriter.vtkNIFTIWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000D5E RID: 3422 RVA: 0x00019E58 File Offset: 0x00018058
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000D5F RID: 3423
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkNIFTIWriter.EndianEnum vtkNIFTIWriter_GetDataByteOrder_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D60 RID: 3424 RVA: 0x00019E64 File Offset: 0x00018064
		public virtual vtkNIFTIWriter.EndianEnum GetDataByteOrder()
		{
			return vtkNIFTIWriter.vtkNIFTIWriter_GetDataByteOrder_01(base.GetCppThis());
		}

		// Token: 0x06000D61 RID: 3425
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIWriter_GetDescription_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D62 RID: 3426 RVA: 0x00019E84 File Offset: 0x00018084
		public virtual string GetDescription()
		{
			string s = Marshal.PtrToStringAnsi(vtkNIFTIWriter.vtkNIFTIWriter_GetDescription_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000D63 RID: 3427
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIWriter_GetNIFTIHeader_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D64 RID: 3428 RVA: 0x00019EC0 File Offset: 0x000180C0
		public vtkNIFTIHeader GetNIFTIHeader()
		{
			vtkNIFTIHeader vtkNIFTIHeader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIWriter.vtkNIFTIWriter_GetNIFTIHeader_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000D65 RID: 3429
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIWriter_GetNIFTIVersion_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D66 RID: 3430 RVA: 0x00019F30 File Offset: 0x00018130
		public virtual int GetNIFTIVersion()
		{
			return vtkNIFTIWriter.vtkNIFTIWriter_GetNIFTIVersion_04(base.GetCppThis());
		}

		// Token: 0x06000D67 RID: 3431
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIWriter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D68 RID: 3432 RVA: 0x00019F50 File Offset: 0x00018150
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNIFTIWriter.vtkNIFTIWriter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06000D69 RID: 3433
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNIFTIWriter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D6A RID: 3434 RVA: 0x00019F70 File Offset: 0x00018170
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNIFTIWriter.vtkNIFTIWriter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06000D6B RID: 3435
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkNIFTIWriter_GetPlanarRGB_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D6C RID: 3436 RVA: 0x00019F8C File Offset: 0x0001818C
		public virtual bool GetPlanarRGB()
		{
			return vtkNIFTIWriter.vtkNIFTIWriter_GetPlanarRGB_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06000D6D RID: 3437
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIWriter_GetQFac_08(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D6E RID: 3438 RVA: 0x00019FB4 File Offset: 0x000181B4
		public virtual double GetQFac()
		{
			return vtkNIFTIWriter.vtkNIFTIWriter_GetQFac_08(base.GetCppThis());
		}

		// Token: 0x06000D6F RID: 3439
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIWriter_GetQFormMatrix_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D70 RID: 3440 RVA: 0x00019FD4 File Offset: 0x000181D4
		public vtkMatrix4x4 GetQFormMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIWriter.vtkNIFTIWriter_GetQFormMatrix_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000D71 RID: 3441
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIWriter_GetRescaleIntercept_10(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D72 RID: 3442 RVA: 0x0001A044 File Offset: 0x00018244
		public virtual double GetRescaleIntercept()
		{
			return vtkNIFTIWriter.vtkNIFTIWriter_GetRescaleIntercept_10(base.GetCppThis());
		}

		// Token: 0x06000D73 RID: 3443
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIWriter_GetRescaleSlope_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D74 RID: 3444 RVA: 0x0001A064 File Offset: 0x00018264
		public virtual double GetRescaleSlope()
		{
			return vtkNIFTIWriter.vtkNIFTIWriter_GetRescaleSlope_11(base.GetCppThis());
		}

		// Token: 0x06000D75 RID: 3445
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIWriter_GetSFormMatrix_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D76 RID: 3446 RVA: 0x0001A084 File Offset: 0x00018284
		public vtkMatrix4x4 GetSFormMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIWriter.vtkNIFTIWriter_GetSFormMatrix_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000D77 RID: 3447
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIWriter_GetTimeDimension_13(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D78 RID: 3448 RVA: 0x0001A0F4 File Offset: 0x000182F4
		public virtual int GetTimeDimension()
		{
			return vtkNIFTIWriter.vtkNIFTIWriter_GetTimeDimension_13(base.GetCppThis());
		}

		// Token: 0x06000D79 RID: 3449
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNIFTIWriter_GetTimeSpacing_14(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D7A RID: 3450 RVA: 0x0001A114 File Offset: 0x00018314
		public virtual double GetTimeSpacing()
		{
			return vtkNIFTIWriter.vtkNIFTIWriter_GetTimeSpacing_14(base.GetCppThis());
		}

		// Token: 0x06000D7B RID: 3451
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIWriter_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D7C RID: 3452 RVA: 0x0001A134 File Offset: 0x00018334
		public override int IsA(string type)
		{
			return vtkNIFTIWriter.vtkNIFTIWriter_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06000D7D RID: 3453
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNIFTIWriter_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D7E RID: 3454 RVA: 0x0001A154 File Offset: 0x00018354
		public new static int IsTypeOf(string type)
		{
			return vtkNIFTIWriter.vtkNIFTIWriter_IsTypeOf_16(type);
		}

		// Token: 0x06000D7F RID: 3455
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIWriter_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D80 RID: 3456 RVA: 0x0001A170 File Offset: 0x00018370
		public new vtkNIFTIWriter NewInstance()
		{
			vtkNIFTIWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIWriter.vtkNIFTIWriter_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNIFTIWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000D81 RID: 3457
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIWriter_PlanarRGBOff_19(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D82 RID: 3458 RVA: 0x0001A1CA File Offset: 0x000183CA
		public virtual void PlanarRGBOff()
		{
			vtkNIFTIWriter.vtkNIFTIWriter_PlanarRGBOff_19(base.GetCppThis());
		}

		// Token: 0x06000D83 RID: 3459
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIWriter_PlanarRGBOn_20(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D84 RID: 3460 RVA: 0x0001A1D9 File Offset: 0x000183D9
		public virtual void PlanarRGBOn()
		{
			vtkNIFTIWriter.vtkNIFTIWriter_PlanarRGBOn_20(base.GetCppThis());
		}

		// Token: 0x06000D85 RID: 3461
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNIFTIWriter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D86 RID: 3462 RVA: 0x0001A1E8 File Offset: 0x000183E8
		public new static vtkNIFTIWriter SafeDownCast(vtkObjectBase o)
		{
			vtkNIFTIWriter vtkNIFTIWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNIFTIWriter.vtkNIFTIWriter_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNIFTIWriter = (vtkNIFTIWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNIFTIWriter.Register(null);
				}
			}
			return vtkNIFTIWriter;
		}

		// Token: 0x06000D87 RID: 3463
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIWriter_SetDataByteOrder_22(HandleRef pThis, vtkNIFTIWriter.EndianEnum _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D88 RID: 3464 RVA: 0x0001A267 File Offset: 0x00018467
		public virtual void SetDataByteOrder(vtkNIFTIWriter.EndianEnum _arg)
		{
			vtkNIFTIWriter.vtkNIFTIWriter_SetDataByteOrder_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D89 RID: 3465
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIWriter_SetDataByteOrderToBigEndian_23(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D8A RID: 3466 RVA: 0x0001A277 File Offset: 0x00018477
		public void SetDataByteOrderToBigEndian()
		{
			vtkNIFTIWriter.vtkNIFTIWriter_SetDataByteOrderToBigEndian_23(base.GetCppThis());
		}

		// Token: 0x06000D8B RID: 3467
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIWriter_SetDataByteOrderToLittleEndian_24(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D8C RID: 3468 RVA: 0x0001A286 File Offset: 0x00018486
		public void SetDataByteOrderToLittleEndian()
		{
			vtkNIFTIWriter.vtkNIFTIWriter_SetDataByteOrderToLittleEndian_24(base.GetCppThis());
		}

		// Token: 0x06000D8D RID: 3469
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIWriter_SetDescription_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D8E RID: 3470 RVA: 0x0001A295 File Offset: 0x00018495
		public virtual void SetDescription(string _arg)
		{
			vtkNIFTIWriter.vtkNIFTIWriter_SetDescription_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D8F RID: 3471
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIWriter_SetNIFTIHeader_26(HandleRef pThis, HandleRef hdr);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D90 RID: 3472 RVA: 0x0001A2A8 File Offset: 0x000184A8
		public void SetNIFTIHeader(vtkNIFTIHeader hdr)
		{
			vtkNIFTIWriter.vtkNIFTIWriter_SetNIFTIHeader_26(base.GetCppThis(), (hdr == null) ? default(HandleRef) : hdr.GetCppThis());
		}

		// Token: 0x06000D91 RID: 3473
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIWriter_SetNIFTIVersion_27(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D92 RID: 3474 RVA: 0x0001A2D7 File Offset: 0x000184D7
		public virtual void SetNIFTIVersion(int _arg)
		{
			vtkNIFTIWriter.vtkNIFTIWriter_SetNIFTIVersion_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D93 RID: 3475
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIWriter_SetPlanarRGB_28(HandleRef pThis, byte _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D94 RID: 3476 RVA: 0x0001A2E7 File Offset: 0x000184E7
		public virtual void SetPlanarRGB(bool _arg)
		{
			vtkNIFTIWriter.vtkNIFTIWriter_SetPlanarRGB_28(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06000D95 RID: 3477
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIWriter_SetQFac_29(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D96 RID: 3478 RVA: 0x0001A2FF File Offset: 0x000184FF
		public virtual void SetQFac(double _arg)
		{
			vtkNIFTIWriter.vtkNIFTIWriter_SetQFac_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D97 RID: 3479
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIWriter_SetQFormMatrix_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D98 RID: 3480 RVA: 0x0001A310 File Offset: 0x00018510
		public void SetQFormMatrix(vtkMatrix4x4 arg0)
		{
			vtkNIFTIWriter.vtkNIFTIWriter_SetQFormMatrix_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000D99 RID: 3481
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIWriter_SetRescaleIntercept_31(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D9A RID: 3482 RVA: 0x0001A33F File Offset: 0x0001853F
		public virtual void SetRescaleIntercept(double _arg)
		{
			vtkNIFTIWriter.vtkNIFTIWriter_SetRescaleIntercept_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D9B RID: 3483
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIWriter_SetRescaleSlope_32(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D9C RID: 3484 RVA: 0x0001A34F File Offset: 0x0001854F
		public virtual void SetRescaleSlope(double _arg)
		{
			vtkNIFTIWriter.vtkNIFTIWriter_SetRescaleSlope_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06000D9D RID: 3485
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIWriter_SetSFormMatrix_33(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000D9E RID: 3486 RVA: 0x0001A360 File Offset: 0x00018560
		public void SetSFormMatrix(vtkMatrix4x4 arg0)
		{
			vtkNIFTIWriter.vtkNIFTIWriter_SetSFormMatrix_33(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000D9F RID: 3487
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIWriter_SetTimeDimension_34(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DA0 RID: 3488 RVA: 0x0001A38F File Offset: 0x0001858F
		public virtual void SetTimeDimension(int _arg)
		{
			vtkNIFTIWriter.vtkNIFTIWriter_SetTimeDimension_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06000DA1 RID: 3489
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNIFTIWriter_SetTimeSpacing_35(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000DA2 RID: 3490 RVA: 0x0001A39F File Offset: 0x0001859F
		public virtual void SetTimeSpacing(double _arg)
		{
			vtkNIFTIWriter.vtkNIFTIWriter_SetTimeSpacing_35(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400041F RID: 1055
		public new const string MRFullTypeName = "Kitware.VTK.vtkNIFTIWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000420 RID: 1056
		public new static readonly string MRClassNameKey = "class vtkNIFTIWriter";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000050 RID: 80
		public enum EndianEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000422 RID: 1058
			BigEndian,
			/// <summary>enum member</summary>
			// Token: 0x04000423 RID: 1059
			LittleEndian
		}
	}
}
