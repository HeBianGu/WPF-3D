using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVolume16Reader
	/// </summary>
	/// <remarks>
	///    read 16 bit image files
	///
	/// vtkVolume16Reader is a source object that reads 16 bit image files.
	///
	/// Volume16Reader creates structured point datasets. The dimension of the
	/// dataset depends upon the number of files read. Reading a single file
	/// results in a 2D image, while reading more than one file results in a
	/// 3D volume.
	///
	/// File names are created using FilePattern and FilePrefix as follows:
	/// snprintf (filename, sizeof(filename), FilePattern, FilePrefix, number);
	/// where number is in the range ImageRange[0] to ImageRange[1]. If
	/// ImageRange[1] &lt;= ImageRange[0], then slice number ImageRange[0] is
	/// read. Thus to read an image set ImageRange[0] = ImageRange[1] = slice
	/// number. The default behavior is to read a single file (i.e., image slice 1).
	///
	/// The DataMask instance variable is used to read data files with embedded
	/// connectivity or segmentation information. For example, some data has
	/// the high order bit set to indicate connected surface. The DataMask allows
	/// you to select this data. Other important ivars include HeaderSize, which
	/// allows you to skip over initial info, and SwapBytes, which turns on/off
	/// byte swapping.
	///
	/// The Transform instance variable specifies a permutation transformation
	/// to map slice space into world space. vtkImageReader has replaced the
	/// functionality of this class and should be used instead.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSliceCubes vtkMarchingCubes vtkImageReader
	/// </seealso>
	// Token: 0x020007A7 RID: 1959
	public class vtkVolume16Reader : vtkVolumeReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014167 RID: 82279 RVA: 0x001C6288 File Offset: 0x001C4488
		static vtkVolume16Reader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolume16Reader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolume16Reader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014168 RID: 82280 RVA: 0x001C62B0 File Offset: 0x001C44B0
		public vtkVolume16Reader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014169 RID: 82281
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume16Reader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with nullptr file prefix; file pattern "%s.%d"; image range
		/// set to (1,1); data origin (0,0,0); data spacing (1,1,1); no data mask;
		/// header size 0; and byte swapping turned off.
		/// </summary>
		// Token: 0x0601416A RID: 82282 RVA: 0x001C62C0 File Offset: 0x001C44C0
		public new static vtkVolume16Reader New()
		{
			vtkVolume16Reader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolume16Reader.vtkVolume16Reader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolume16Reader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with nullptr file prefix; file pattern "%s.%d"; image range
		/// set to (1,1); data origin (0,0,0); data spacing (1,1,1); no data mask;
		/// header size 0; and byte swapping turned off.
		/// </summary>
		// Token: 0x0601416B RID: 82283 RVA: 0x001C6314 File Offset: 0x001C4514
		public vtkVolume16Reader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVolume16Reader.vtkVolume16Reader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601416C RID: 82284 RVA: 0x001C6358 File Offset: 0x001C4558
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601416D RID: 82285
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolume16Reader_GetDataByteOrder_01(HandleRef pThis);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
		/// SetDataByteOrderToBigEndian.
		/// </summary>
		// Token: 0x0601416E RID: 82286 RVA: 0x001C6364 File Offset: 0x001C4564
		public int GetDataByteOrder()
		{
			return vtkVolume16Reader.vtkVolume16Reader_GetDataByteOrder_01(base.GetCppThis());
		}

		// Token: 0x0601416F RID: 82287
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume16Reader_GetDataByteOrderAsString_02(HandleRef pThis);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
		/// SetDataByteOrderToBigEndian.
		/// </summary>
		// Token: 0x06014170 RID: 82288 RVA: 0x001C6384 File Offset: 0x001C4584
		public string GetDataByteOrderAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkVolume16Reader.vtkVolume16Reader_GetDataByteOrderAsString_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014171 RID: 82289
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume16Reader_GetDataDimensions_03(HandleRef pThis);

		/// <summary>
		/// Specify the dimensions for the data.
		/// </summary>
		// Token: 0x06014172 RID: 82290 RVA: 0x001C63C0 File Offset: 0x001C45C0
		public virtual int[] GetDataDimensions()
		{
			IntPtr intPtr = vtkVolume16Reader.vtkVolume16Reader_GetDataDimensions_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014173 RID: 82291
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume16Reader_GetDataDimensions_04(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the dimensions for the data.
		/// </summary>
		// Token: 0x06014174 RID: 82292 RVA: 0x001C6408 File Offset: 0x001C4608
		public virtual void GetDataDimensions(IntPtr data)
		{
			vtkVolume16Reader.vtkVolume16Reader_GetDataDimensions_04(base.GetCppThis(), data);
		}

		// Token: 0x06014175 RID: 82293
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkVolume16Reader_GetDataMask_05(HandleRef pThis);

		/// <summary>
		/// Specify a mask used to eliminate data in the data file (e.g.,
		/// connectivity bits).
		/// </summary>
		// Token: 0x06014176 RID: 82294 RVA: 0x001C6418 File Offset: 0x001C4618
		public virtual ushort GetDataMask()
		{
			return vtkVolume16Reader.vtkVolume16Reader_GetDataMask_05(base.GetCppThis());
		}

		// Token: 0x06014177 RID: 82295
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolume16Reader_GetHeaderSize_06(HandleRef pThis);

		/// <summary>
		/// Specify the number of bytes to seek over at start of image.
		/// </summary>
		// Token: 0x06014178 RID: 82296 RVA: 0x001C6438 File Offset: 0x001C4638
		public virtual int GetHeaderSize()
		{
			return vtkVolume16Reader.vtkVolume16Reader_GetHeaderSize_06(base.GetCppThis());
		}

		// Token: 0x06014179 RID: 82297
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume16Reader_GetImage_07(HandleRef pThis, int ImageNumber, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Other objects make use of these methods
		/// </summary>
		// Token: 0x0601417A RID: 82298 RVA: 0x001C6458 File Offset: 0x001C4658
		public override vtkImageData GetImage(int ImageNumber)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolume16Reader.vtkVolume16Reader_GetImage_07(base.GetCppThis(), ImageNumber, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601417B RID: 82299
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolume16Reader_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601417C RID: 82300 RVA: 0x001C64C8 File Offset: 0x001C46C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVolume16Reader.vtkVolume16Reader_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0601417D RID: 82301
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolume16Reader_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601417E RID: 82302 RVA: 0x001C64E8 File Offset: 0x001C46E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVolume16Reader.vtkVolume16Reader_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0601417F RID: 82303
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolume16Reader_GetSwapBytes_10(HandleRef pThis);

		/// <summary>
		/// Turn on/off byte swapping.
		/// </summary>
		// Token: 0x06014180 RID: 82304 RVA: 0x001C6504 File Offset: 0x001C4704
		public virtual int GetSwapBytes()
		{
			return vtkVolume16Reader.vtkVolume16Reader_GetSwapBytes_10(base.GetCppThis());
		}

		// Token: 0x06014181 RID: 82305
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume16Reader_GetTransform_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get transformation matrix to transform the data from slice space
		/// into world space. This matrix must be a permutation matrix. To qualify,
		/// the sums of the rows must be + or - 1.
		/// </summary>
		// Token: 0x06014182 RID: 82306 RVA: 0x001C6524 File Offset: 0x001C4724
		public virtual vtkTransform GetTransform()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolume16Reader.vtkVolume16Reader_GetTransform_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		// Token: 0x06014183 RID: 82307
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolume16Reader_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014184 RID: 82308 RVA: 0x001C6594 File Offset: 0x001C4794
		public override int IsA(string type)
		{
			return vtkVolume16Reader.vtkVolume16Reader_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06014185 RID: 82309
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolume16Reader_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014186 RID: 82310 RVA: 0x001C65B4 File Offset: 0x001C47B4
		public new static int IsTypeOf(string type)
		{
			return vtkVolume16Reader.vtkVolume16Reader_IsTypeOf_13(type);
		}

		// Token: 0x06014187 RID: 82311
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume16Reader_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014188 RID: 82312 RVA: 0x001C65D0 File Offset: 0x001C47D0
		public new vtkVolume16Reader NewInstance()
		{
			vtkVolume16Reader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolume16Reader.vtkVolume16Reader_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolume16Reader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014189 RID: 82313
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolume16Reader_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601418A RID: 82314 RVA: 0x001C662C File Offset: 0x001C482C
		public new static vtkVolume16Reader SafeDownCast(vtkObjectBase o)
		{
			vtkVolume16Reader vtkVolume16Reader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolume16Reader.vtkVolume16Reader_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolume16Reader = (vtkVolume16Reader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolume16Reader.Register(null);
				}
			}
			return vtkVolume16Reader;
		}

		// Token: 0x0601418B RID: 82315
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume16Reader_SetDataByteOrder_17(HandleRef pThis, int arg0);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
		/// SetDataByteOrderToBigEndian.
		/// </summary>
		// Token: 0x0601418C RID: 82316 RVA: 0x001C66AB File Offset: 0x001C48AB
		public void SetDataByteOrder(int arg0)
		{
			vtkVolume16Reader.vtkVolume16Reader_SetDataByteOrder_17(base.GetCppThis(), arg0);
		}

		// Token: 0x0601418D RID: 82317
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume16Reader_SetDataByteOrderToBigEndian_18(HandleRef pThis);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
		/// SetDataByteOrderToBigEndian.
		/// </summary>
		// Token: 0x0601418E RID: 82318 RVA: 0x001C66BB File Offset: 0x001C48BB
		public void SetDataByteOrderToBigEndian()
		{
			vtkVolume16Reader.vtkVolume16Reader_SetDataByteOrderToBigEndian_18(base.GetCppThis());
		}

		// Token: 0x0601418F RID: 82319
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume16Reader_SetDataByteOrderToLittleEndian_19(HandleRef pThis);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
		/// SetDataByteOrderToBigEndian.
		/// </summary>
		// Token: 0x06014190 RID: 82320 RVA: 0x001C66CA File Offset: 0x001C48CA
		public void SetDataByteOrderToLittleEndian()
		{
			vtkVolume16Reader.vtkVolume16Reader_SetDataByteOrderToLittleEndian_19(base.GetCppThis());
		}

		// Token: 0x06014191 RID: 82321
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume16Reader_SetDataDimensions_20(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Specify the dimensions for the data.
		/// </summary>
		// Token: 0x06014192 RID: 82322 RVA: 0x001C66D9 File Offset: 0x001C48D9
		public virtual void SetDataDimensions(int _arg1, int _arg2)
		{
			vtkVolume16Reader.vtkVolume16Reader_SetDataDimensions_20(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06014193 RID: 82323
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume16Reader_SetDataDimensions_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the dimensions for the data.
		/// </summary>
		// Token: 0x06014194 RID: 82324 RVA: 0x001C66EA File Offset: 0x001C48EA
		public void SetDataDimensions(IntPtr _arg)
		{
			vtkVolume16Reader.vtkVolume16Reader_SetDataDimensions_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06014195 RID: 82325
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume16Reader_SetDataMask_22(HandleRef pThis, ushort _arg);

		/// <summary>
		/// Specify a mask used to eliminate data in the data file (e.g.,
		/// connectivity bits).
		/// </summary>
		// Token: 0x06014196 RID: 82326 RVA: 0x001C66FA File Offset: 0x001C48FA
		public virtual void SetDataMask(ushort _arg)
		{
			vtkVolume16Reader.vtkVolume16Reader_SetDataMask_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06014197 RID: 82327
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume16Reader_SetHeaderSize_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the number of bytes to seek over at start of image.
		/// </summary>
		// Token: 0x06014198 RID: 82328 RVA: 0x001C670A File Offset: 0x001C490A
		public virtual void SetHeaderSize(int _arg)
		{
			vtkVolume16Reader.vtkVolume16Reader_SetHeaderSize_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06014199 RID: 82329
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume16Reader_SetSwapBytes_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off byte swapping.
		/// </summary>
		// Token: 0x0601419A RID: 82330 RVA: 0x001C671A File Offset: 0x001C491A
		public virtual void SetSwapBytes(int _arg)
		{
			vtkVolume16Reader.vtkVolume16Reader_SetSwapBytes_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0601419B RID: 82331
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume16Reader_SetTransform_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get transformation matrix to transform the data from slice space
		/// into world space. This matrix must be a permutation matrix. To qualify,
		/// the sums of the rows must be + or - 1.
		/// </summary>
		// Token: 0x0601419C RID: 82332 RVA: 0x001C672C File Offset: 0x001C492C
		public virtual void SetTransform(vtkTransform arg0)
		{
			vtkVolume16Reader.vtkVolume16Reader_SetTransform_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601419D RID: 82333
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume16Reader_SwapBytesOff_26(HandleRef pThis);

		/// <summary>
		/// Turn on/off byte swapping.
		/// </summary>
		// Token: 0x0601419E RID: 82334 RVA: 0x001C675B File Offset: 0x001C495B
		public virtual void SwapBytesOff()
		{
			vtkVolume16Reader.vtkVolume16Reader_SwapBytesOff_26(base.GetCppThis());
		}

		// Token: 0x0601419F RID: 82335
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolume16Reader_SwapBytesOn_27(HandleRef pThis);

		/// <summary>
		/// Turn on/off byte swapping.
		/// </summary>
		// Token: 0x060141A0 RID: 82336 RVA: 0x001C676A File Offset: 0x001C496A
		public virtual void SwapBytesOn()
		{
			vtkVolume16Reader.vtkVolume16Reader_SwapBytesOn_27(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001752 RID: 5970
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolume16Reader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001753 RID: 5971
		public new static readonly string MRClassNameKey = "class vtkVolume16Reader";
	}
}
