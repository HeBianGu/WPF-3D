using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000023 RID: 35
	public class vtkDICOMImageCodec : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060005A9 RID: 1449 RVA: 0x0000F6D1 File Offset: 0x0000D8D1
		static vtkDICOMImageCodec()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMImageCodec.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMImageCodec"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060005AA RID: 1450 RVA: 0x0000F6F9 File Offset: 0x0000D8F9
		public vtkDICOMImageCodec(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060005AB RID: 1451 RVA: 0x0000F707 File Offset: 0x0000D907
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060005AC RID: 1452
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMImageCodec_GetKey_01(HandleRef pThis);

		// Token: 0x060005AD RID: 1453 RVA: 0x0000F714 File Offset: 0x0000D914
		public byte GetKey()
		{
			return vtkDICOMImageCodec.vtkDICOMImageCodec_GetKey_01(base.GetCppThis());
		}

		// Token: 0x060005AE RID: 1454
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMImageCodec_GetTransferSyntaxUID_02(HandleRef pThis);

		// Token: 0x060005AF RID: 1455 RVA: 0x0000F734 File Offset: 0x0000D934
		public string GetTransferSyntaxUID()
		{
			return vtkDICOMImageCodec.vtkDICOMImageCodec_GetTransferSyntaxUID_02(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000356 RID: 854
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMImageCodec";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000357 RID: 855
		public new static readonly string MRClassNameKey = "class vtkDICOMImageCodec";

		// Token: 0x02000024 RID: 36
		public enum EnumType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000359 RID: 857
			BigEndian = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400035A RID: 858
			HEVCM10PL51 = 19,
			/// <summary>enum member</summary>
			// Token: 0x0400035B RID: 859
			HEVCMPL51 = 18,
			/// <summary>enum member</summary>
			// Token: 0x0400035C RID: 860
			JPEG2K = 9,
			/// <summary>enum member</summary>
			// Token: 0x0400035D RID: 861
			JPEG2KLossless,
			/// <summary>enum member</summary>
			// Token: 0x0400035E RID: 862
			JPEGBaseline = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400035F RID: 863
			JPEGExtended,
			/// <summary>enum member</summary>
			// Token: 0x04000360 RID: 864
			JPEGLS = 7,
			/// <summary>enum member</summary>
			// Token: 0x04000361 RID: 865
			JPEGLSConstrained,
			/// <summary>enum member</summary>
			// Token: 0x04000362 RID: 866
			JPEGLossless = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000363 RID: 867
			JPEGPrediction,
			/// <summary>enum member</summary>
			// Token: 0x04000364 RID: 868
			LittleEndian = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000365 RID: 869
			MPEG2HL = 12,
			/// <summary>enum member</summary>
			// Token: 0x04000366 RID: 870
			MPEG2ML = 11,
			/// <summary>enum member</summary>
			// Token: 0x04000367 RID: 871
			MPEG4HPL41 = 13,
			/// <summary>enum member</summary>
			// Token: 0x04000368 RID: 872
			MPEG4HPL41BD,
			/// <summary>enum member</summary>
			// Token: 0x04000369 RID: 873
			MPEG4HPL42Stereo = 17,
			/// <summary>enum member</summary>
			// Token: 0x0400036A RID: 874
			MPEG4HPL42V2D = 15,
			/// <summary>enum member</summary>
			// Token: 0x0400036B RID: 875
			MPEG4HPL42V3D,
			/// <summary>enum member</summary>
			// Token: 0x0400036C RID: 876
			NumberOfCodecs = 20,
			/// <summary>enum member</summary>
			// Token: 0x0400036D RID: 877
			RLE = 2
		}

		// Token: 0x02000025 RID: 37
		public enum ErrorCode
		{
			/// <summary>enum member</summary>
			// Token: 0x0400036F RID: 879
			BadPixelFormat = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000370 RID: 880
			MissingCodec = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000371 RID: 881
			MissingData = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000372 RID: 882
			NoError = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000373 RID: 883
			UnknownError = 4
		}
	}
}
