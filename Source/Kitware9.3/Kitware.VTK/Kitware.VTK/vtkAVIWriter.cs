using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAVIWriter
	/// </summary>
	/// <remarks>
	///    Writes Windows AVI files.
	///
	/// vtkAVIWriter writes AVI files. Note that this class in only available
	/// on the Microsoft Windows platform. The data type of the file is
	/// unsigned char regardless of the input type.
	/// </remarks>
	/// <seealso>
	///
	/// vtkGenericMovieWriter
	/// </seealso>
	// Token: 0x0200018E RID: 398
	public class vtkAVIWriter : vtkGenericMovieWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004DDF RID: 19935 RVA: 0x00071309 File Offset: 0x0006F509
		static vtkAVIWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAVIWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAVIWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004DE0 RID: 19936 RVA: 0x00071331 File Offset: 0x0006F531
		public vtkAVIWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004DE1 RID: 19937
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAVIWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004DE2 RID: 19938 RVA: 0x00071340 File Offset: 0x0006F540
		public new static vtkAVIWriter New()
		{
			vtkAVIWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAVIWriter.vtkAVIWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAVIWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004DE3 RID: 19939 RVA: 0x00071394 File Offset: 0x0006F594
		public vtkAVIWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAVIWriter.vtkAVIWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004DE4 RID: 19940 RVA: 0x000713D8 File Offset: 0x0006F5D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004DE5 RID: 19941
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVIWriter_End_01(HandleRef pThis);

		/// <summary>
		/// These methods start writing an AVI file, write a frame to the file
		/// and then end the writing process.
		/// </summary>
		// Token: 0x06004DE6 RID: 19942 RVA: 0x000713E3 File Offset: 0x0006F5E3
		public override void End()
		{
			vtkAVIWriter.vtkAVIWriter_End_01(base.GetCppThis());
		}

		// Token: 0x06004DE7 RID: 19943
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAVIWriter_GetCompressorFourCC_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the compressor FourCC.
		/// A FourCC (literally, four-character code) is a sequence of four bytes
		/// used to uniquely identify data formats. [...] One of the most well-known
		/// uses of FourCCs is to identify the video codec used in AVI files.
		/// Common identifiers include DIVX, XVID, and H264.
		/// http://en.wikipedia.org/wiki/FourCC.
		/// Default value is:
		/// - MSVC
		/// Other examples include:
		/// - DIB: Full Frames (Uncompressed)
		/// - LAGS: Lagarith Lossless Codec
		/// - MJPG: M-JPG, aka Motion JPEG (say, Pegasus Imaging PicVideo M-JPEG)
		/// Links:
		/// - http://www.fourcc.org/
		/// - http://www.microsoft.com/whdc/archive/fourcc.mspx
		/// - http://abcavi.kibi.ru/fourcc.php
		/// </summary>
		// Token: 0x06004DE8 RID: 19944 RVA: 0x000713F4 File Offset: 0x0006F5F4
		public virtual string GetCompressorFourCC()
		{
			string s = Marshal.PtrToStringAnsi(vtkAVIWriter.vtkAVIWriter_GetCompressorFourCC_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004DE9 RID: 19945
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAVIWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004DEA RID: 19946 RVA: 0x00071430 File Offset: 0x0006F630
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAVIWriter.vtkAVIWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06004DEB RID: 19947
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAVIWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004DEC RID: 19948 RVA: 0x00071450 File Offset: 0x0006F650
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAVIWriter.vtkAVIWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06004DED RID: 19949
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVIWriter_GetPromptCompressionOptions_05(HandleRef pThis);

		/// <summary>
		/// Set/Get if the user should be prompted for compression options, i.e.
		/// pick a compressor, set the compression rate (override Rate), etc.).
		/// Default is OFF (legacy).
		/// </summary>
		// Token: 0x06004DEE RID: 19950 RVA: 0x0007146C File Offset: 0x0006F66C
		public virtual int GetPromptCompressionOptions()
		{
			return vtkAVIWriter.vtkAVIWriter_GetPromptCompressionOptions_05(base.GetCppThis());
		}

		// Token: 0x06004DEF RID: 19951
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVIWriter_GetQuality_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the compression quality.
		/// 0 means worst quality and smallest file size
		/// 2 means best quality and largest file size
		/// </summary>
		// Token: 0x06004DF0 RID: 19952 RVA: 0x0007148C File Offset: 0x0006F68C
		public virtual int GetQuality()
		{
			return vtkAVIWriter.vtkAVIWriter_GetQuality_06(base.GetCppThis());
		}

		// Token: 0x06004DF1 RID: 19953
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVIWriter_GetQualityMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the compression quality.
		/// 0 means worst quality and smallest file size
		/// 2 means best quality and largest file size
		/// </summary>
		// Token: 0x06004DF2 RID: 19954 RVA: 0x000714AC File Offset: 0x0006F6AC
		public virtual int GetQualityMaxValue()
		{
			return vtkAVIWriter.vtkAVIWriter_GetQualityMaxValue_07(base.GetCppThis());
		}

		// Token: 0x06004DF3 RID: 19955
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVIWriter_GetQualityMinValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the compression quality.
		/// 0 means worst quality and smallest file size
		/// 2 means best quality and largest file size
		/// </summary>
		// Token: 0x06004DF4 RID: 19956 RVA: 0x000714CC File Offset: 0x0006F6CC
		public virtual int GetQualityMinValue()
		{
			return vtkAVIWriter.vtkAVIWriter_GetQualityMinValue_08(base.GetCppThis());
		}

		// Token: 0x06004DF5 RID: 19957
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVIWriter_GetRate_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the frame rate, in frame/s.
		/// </summary>
		// Token: 0x06004DF6 RID: 19958 RVA: 0x000714EC File Offset: 0x0006F6EC
		public virtual int GetRate()
		{
			return vtkAVIWriter.vtkAVIWriter_GetRate_09(base.GetCppThis());
		}

		// Token: 0x06004DF7 RID: 19959
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVIWriter_GetRateMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the frame rate, in frame/s.
		/// </summary>
		// Token: 0x06004DF8 RID: 19960 RVA: 0x0007150C File Offset: 0x0006F70C
		public virtual int GetRateMaxValue()
		{
			return vtkAVIWriter.vtkAVIWriter_GetRateMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06004DF9 RID: 19961
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVIWriter_GetRateMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the frame rate, in frame/s.
		/// </summary>
		// Token: 0x06004DFA RID: 19962 RVA: 0x0007152C File Offset: 0x0006F72C
		public virtual int GetRateMinValue()
		{
			return vtkAVIWriter.vtkAVIWriter_GetRateMinValue_11(base.GetCppThis());
		}

		// Token: 0x06004DFB RID: 19963
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVIWriter_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004DFC RID: 19964 RVA: 0x0007154C File Offset: 0x0006F74C
		public override int IsA(string type)
		{
			return vtkAVIWriter.vtkAVIWriter_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06004DFD RID: 19965
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAVIWriter_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004DFE RID: 19966 RVA: 0x0007156C File Offset: 0x0006F76C
		public new static int IsTypeOf(string type)
		{
			return vtkAVIWriter.vtkAVIWriter_IsTypeOf_13(type);
		}

		// Token: 0x06004DFF RID: 19967
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAVIWriter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E00 RID: 19968 RVA: 0x00071588 File Offset: 0x0006F788
		public new vtkAVIWriter NewInstance()
		{
			vtkAVIWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAVIWriter.vtkAVIWriter_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAVIWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004E01 RID: 19969
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVIWriter_PromptCompressionOptionsOff_16(HandleRef pThis);

		/// <summary>
		/// Set/Get if the user should be prompted for compression options, i.e.
		/// pick a compressor, set the compression rate (override Rate), etc.).
		/// Default is OFF (legacy).
		/// </summary>
		// Token: 0x06004E02 RID: 19970 RVA: 0x000715E2 File Offset: 0x0006F7E2
		public virtual void PromptCompressionOptionsOff()
		{
			vtkAVIWriter.vtkAVIWriter_PromptCompressionOptionsOff_16(base.GetCppThis());
		}

		// Token: 0x06004E03 RID: 19971
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVIWriter_PromptCompressionOptionsOn_17(HandleRef pThis);

		/// <summary>
		/// Set/Get if the user should be prompted for compression options, i.e.
		/// pick a compressor, set the compression rate (override Rate), etc.).
		/// Default is OFF (legacy).
		/// </summary>
		// Token: 0x06004E04 RID: 19972 RVA: 0x000715F1 File Offset: 0x0006F7F1
		public virtual void PromptCompressionOptionsOn()
		{
			vtkAVIWriter.vtkAVIWriter_PromptCompressionOptionsOn_17(base.GetCppThis());
		}

		// Token: 0x06004E05 RID: 19973
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAVIWriter_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004E06 RID: 19974 RVA: 0x00071600 File Offset: 0x0006F800
		public new static vtkAVIWriter SafeDownCast(vtkObjectBase o)
		{
			vtkAVIWriter vtkAVIWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAVIWriter.vtkAVIWriter_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAVIWriter = (vtkAVIWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAVIWriter.Register(null);
				}
			}
			return vtkAVIWriter;
		}

		// Token: 0x06004E07 RID: 19975
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVIWriter_SetCompressorFourCC_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the compressor FourCC.
		/// A FourCC (literally, four-character code) is a sequence of four bytes
		/// used to uniquely identify data formats. [...] One of the most well-known
		/// uses of FourCCs is to identify the video codec used in AVI files.
		/// Common identifiers include DIVX, XVID, and H264.
		/// http://en.wikipedia.org/wiki/FourCC.
		/// Default value is:
		/// - MSVC
		/// Other examples include:
		/// - DIB: Full Frames (Uncompressed)
		/// - LAGS: Lagarith Lossless Codec
		/// - MJPG: M-JPG, aka Motion JPEG (say, Pegasus Imaging PicVideo M-JPEG)
		/// Links:
		/// - http://www.fourcc.org/
		/// - http://www.microsoft.com/whdc/archive/fourcc.mspx
		/// - http://abcavi.kibi.ru/fourcc.php
		/// </summary>
		// Token: 0x06004E08 RID: 19976 RVA: 0x0007167F File Offset: 0x0006F87F
		public virtual void SetCompressorFourCC(string _arg)
		{
			vtkAVIWriter.vtkAVIWriter_SetCompressorFourCC_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06004E09 RID: 19977
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVIWriter_SetPromptCompressionOptions_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get if the user should be prompted for compression options, i.e.
		/// pick a compressor, set the compression rate (override Rate), etc.).
		/// Default is OFF (legacy).
		/// </summary>
		// Token: 0x06004E0A RID: 19978 RVA: 0x0007168F File Offset: 0x0006F88F
		public virtual void SetPromptCompressionOptions(int _arg)
		{
			vtkAVIWriter.vtkAVIWriter_SetPromptCompressionOptions_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06004E0B RID: 19979
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVIWriter_SetQuality_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the compression quality.
		/// 0 means worst quality and smallest file size
		/// 2 means best quality and largest file size
		/// </summary>
		// Token: 0x06004E0C RID: 19980 RVA: 0x0007169F File Offset: 0x0006F89F
		public virtual void SetQuality(int _arg)
		{
			vtkAVIWriter.vtkAVIWriter_SetQuality_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06004E0D RID: 19981
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVIWriter_SetRate_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the frame rate, in frame/s.
		/// </summary>
		// Token: 0x06004E0E RID: 19982 RVA: 0x000716AF File Offset: 0x0006F8AF
		public virtual void SetRate(int _arg)
		{
			vtkAVIWriter.vtkAVIWriter_SetRate_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06004E0F RID: 19983
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVIWriter_Start_23(HandleRef pThis);

		/// <summary>
		/// These methods start writing an AVI file, write a frame to the file
		/// and then end the writing process.
		/// </summary>
		// Token: 0x06004E10 RID: 19984 RVA: 0x000716BF File Offset: 0x0006F8BF
		public override void Start()
		{
			vtkAVIWriter.vtkAVIWriter_Start_23(base.GetCppThis());
		}

		// Token: 0x06004E11 RID: 19985
		[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAVIWriter_Write_24(HandleRef pThis);

		/// <summary>
		/// These methods start writing an AVI file, write a frame to the file
		/// and then end the writing process.
		/// </summary>
		// Token: 0x06004E12 RID: 19986 RVA: 0x000716CE File Offset: 0x0006F8CE
		public override void Write()
		{
			vtkAVIWriter.vtkAVIWriter_Write_24(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400077D RID: 1917
		public new const string MRFullTypeName = "Kitware.VTK.vtkAVIWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400077E RID: 1918
		public new static readonly string MRClassNameKey = "class vtkAVIWriter";
	}
}
