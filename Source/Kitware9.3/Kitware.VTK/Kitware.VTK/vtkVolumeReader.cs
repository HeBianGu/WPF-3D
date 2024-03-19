using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVolumeReader
	/// </summary>
	/// <remarks>
	///    read image files
	///
	/// vtkVolumeReader is a source object that reads image files.
	///
	/// VolumeReader creates structured point datasets. The dimension of the
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
	/// byte swapping. Consider using vtkImageReader as a replacement.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSliceCubes vtkMarchingCubes vtkPNMReader vtkVolume16Reader
	/// vtkImageReader
	/// </seealso>
	// Token: 0x020007A6 RID: 1958
	public abstract class vtkVolumeReader : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014136 RID: 82230 RVA: 0x001C5E7D File Offset: 0x001C407D
		static vtkVolumeReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014137 RID: 82231 RVA: 0x001C5EA5 File Offset: 0x001C40A5
		public vtkVolumeReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014138 RID: 82232 RVA: 0x001C5EB3 File Offset: 0x001C40B3
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014139 RID: 82233
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeReader_GetDataOrigin_01(HandleRef pThis);

		/// <summary>
		/// Specify the origin for the data.
		/// </summary>
		// Token: 0x0601413A RID: 82234 RVA: 0x001C5EC0 File Offset: 0x001C40C0
		public virtual double[] GetDataOrigin()
		{
			IntPtr intPtr = vtkVolumeReader.vtkVolumeReader_GetDataOrigin_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601413B RID: 82235
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeReader_GetDataOrigin_02(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the origin for the data.
		/// </summary>
		// Token: 0x0601413C RID: 82236 RVA: 0x001C5F08 File Offset: 0x001C4108
		public virtual void GetDataOrigin(IntPtr data)
		{
			vtkVolumeReader.vtkVolumeReader_GetDataOrigin_02(base.GetCppThis(), data);
		}

		// Token: 0x0601413D RID: 82237
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeReader_GetDataSpacing_03(HandleRef pThis);

		/// <summary>
		/// Specify the spacing for the data.
		/// </summary>
		// Token: 0x0601413E RID: 82238 RVA: 0x001C5F18 File Offset: 0x001C4118
		public virtual double[] GetDataSpacing()
		{
			IntPtr intPtr = vtkVolumeReader.vtkVolumeReader_GetDataSpacing_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601413F RID: 82239
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeReader_GetDataSpacing_04(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the spacing for the data.
		/// </summary>
		// Token: 0x06014140 RID: 82240 RVA: 0x001C5F60 File Offset: 0x001C4160
		public virtual void GetDataSpacing(IntPtr data)
		{
			vtkVolumeReader.vtkVolumeReader_GetDataSpacing_04(base.GetCppThis(), data);
		}

		// Token: 0x06014141 RID: 82241
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeReader_GetFilePattern_05(HandleRef pThis);

		/// <summary>
		/// The snprintf format used to build filename from FilePrefix and number.
		/// </summary>
		// Token: 0x06014142 RID: 82242 RVA: 0x001C5F70 File Offset: 0x001C4170
		public virtual string GetFilePattern()
		{
			string s = Marshal.PtrToStringAnsi(vtkVolumeReader.vtkVolumeReader_GetFilePattern_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014143 RID: 82243
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeReader_GetFilePrefix_06(HandleRef pThis);

		/// <summary>
		/// Specify file prefix for the image file(s).
		/// </summary>
		// Token: 0x06014144 RID: 82244 RVA: 0x001C5FAC File Offset: 0x001C41AC
		public virtual string GetFilePrefix()
		{
			string s = Marshal.PtrToStringAnsi(vtkVolumeReader.vtkVolumeReader_GetFilePrefix_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014145 RID: 82245
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeReader_GetImage_07(HandleRef pThis, int ImageNumber, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Other objects make use of this method.
		/// </summary>
		// Token: 0x06014146 RID: 82246 RVA: 0x001C5FE8 File Offset: 0x001C41E8
		public virtual vtkImageData GetImage(int ImageNumber)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeReader.vtkVolumeReader_GetImage_07(base.GetCppThis(), ImageNumber, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06014147 RID: 82247
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeReader_GetImageRange_08(HandleRef pThis);

		/// <summary>
		/// Set the range of files to read.
		/// </summary>
		// Token: 0x06014148 RID: 82248 RVA: 0x001C6058 File Offset: 0x001C4258
		public virtual int[] GetImageRange()
		{
			IntPtr intPtr = vtkVolumeReader.vtkVolumeReader_GetImageRange_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014149 RID: 82249
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeReader_GetImageRange_09(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the range of files to read.
		/// </summary>
		// Token: 0x0601414A RID: 82250 RVA: 0x001C60A0 File Offset: 0x001C42A0
		public virtual void GetImageRange(IntPtr data)
		{
			vtkVolumeReader.vtkVolumeReader_GetImageRange_09(base.GetCppThis(), data);
		}

		// Token: 0x0601414B RID: 82251
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeReader_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601414C RID: 82252 RVA: 0x001C60B0 File Offset: 0x001C42B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVolumeReader.vtkVolumeReader_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0601414D RID: 82253
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeReader_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601414E RID: 82254 RVA: 0x001C60D0 File Offset: 0x001C42D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVolumeReader.vtkVolumeReader_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0601414F RID: 82255
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeReader_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014150 RID: 82256 RVA: 0x001C60EC File Offset: 0x001C42EC
		public override int IsA(string type)
		{
			return vtkVolumeReader.vtkVolumeReader_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06014151 RID: 82257
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeReader_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014152 RID: 82258 RVA: 0x001C610C File Offset: 0x001C430C
		public new static int IsTypeOf(string type)
		{
			return vtkVolumeReader.vtkVolumeReader_IsTypeOf_13(type);
		}

		// Token: 0x06014153 RID: 82259
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeReader_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014154 RID: 82260 RVA: 0x001C6128 File Offset: 0x001C4328
		public new vtkVolumeReader NewInstance()
		{
			vtkVolumeReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeReader.vtkVolumeReader_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014155 RID: 82261
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeReader_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014156 RID: 82262 RVA: 0x001C6184 File Offset: 0x001C4384
		public new static vtkVolumeReader SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeReader vtkVolumeReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeReader.vtkVolumeReader_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeReader = (vtkVolumeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeReader.Register(null);
				}
			}
			return vtkVolumeReader;
		}

		// Token: 0x06014157 RID: 82263
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeReader_SetDataOrigin_16(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify the origin for the data.
		/// </summary>
		// Token: 0x06014158 RID: 82264 RVA: 0x001C6203 File Offset: 0x001C4403
		public virtual void SetDataOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkVolumeReader.vtkVolumeReader_SetDataOrigin_16(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06014159 RID: 82265
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeReader_SetDataOrigin_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the origin for the data.
		/// </summary>
		// Token: 0x0601415A RID: 82266 RVA: 0x001C6215 File Offset: 0x001C4415
		public virtual void SetDataOrigin(IntPtr _arg)
		{
			vtkVolumeReader.vtkVolumeReader_SetDataOrigin_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0601415B RID: 82267
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeReader_SetDataSpacing_18(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify the spacing for the data.
		/// </summary>
		// Token: 0x0601415C RID: 82268 RVA: 0x001C6225 File Offset: 0x001C4425
		public virtual void SetDataSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkVolumeReader.vtkVolumeReader_SetDataSpacing_18(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601415D RID: 82269
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeReader_SetDataSpacing_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the spacing for the data.
		/// </summary>
		// Token: 0x0601415E RID: 82270 RVA: 0x001C6237 File Offset: 0x001C4437
		public virtual void SetDataSpacing(IntPtr _arg)
		{
			vtkVolumeReader.vtkVolumeReader_SetDataSpacing_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0601415F RID: 82271
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeReader_SetFilePattern_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The snprintf format used to build filename from FilePrefix and number.
		/// </summary>
		// Token: 0x06014160 RID: 82272 RVA: 0x001C6247 File Offset: 0x001C4447
		public virtual void SetFilePattern(string _arg)
		{
			vtkVolumeReader.vtkVolumeReader_SetFilePattern_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06014161 RID: 82273
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeReader_SetFilePrefix_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file prefix for the image file(s).
		/// </summary>
		// Token: 0x06014162 RID: 82274 RVA: 0x001C6257 File Offset: 0x001C4457
		public virtual void SetFilePrefix(string _arg)
		{
			vtkVolumeReader.vtkVolumeReader_SetFilePrefix_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06014163 RID: 82275
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeReader_SetImageRange_22(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set the range of files to read.
		/// </summary>
		// Token: 0x06014164 RID: 82276 RVA: 0x001C6267 File Offset: 0x001C4467
		public virtual void SetImageRange(int _arg1, int _arg2)
		{
			vtkVolumeReader.vtkVolumeReader_SetImageRange_22(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06014165 RID: 82277
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeReader_SetImageRange_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the range of files to read.
		/// </summary>
		// Token: 0x06014166 RID: 82278 RVA: 0x001C6278 File Offset: 0x001C4478
		public void SetImageRange(IntPtr _arg)
		{
			vtkVolumeReader.vtkVolumeReader_SetImageRange_23(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001750 RID: 5968
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001751 RID: 5969
		public new static readonly string MRClassNameKey = "class vtkVolumeReader";
	}
}
