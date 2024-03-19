using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMetaImageWriter
	/// </summary>
	/// <remarks>
	///    write a binary UNC meta image data
	///
	/// One of the formats for which a reader is already available in the toolkit is
	/// the MetaImage file format. This is a fairly simple yet powerful format
	/// consisting of a text header and a binary data section. The following
	/// instructions describe how you can write a MetaImage header for the data that
	/// you download from the BrainWeb page.
	///
	/// The minimal structure of the MetaImage header is the following:
	///
	///    NDims = 3
	///    DimSize = 181 217 181
	///    ElementType = MET_UCHAR
	///    ElementSpacing = 1.0 1.0 1.0
	///    ElementByteOrderMSB = False
	///    ElementDataFile = brainweb1.raw
	///
	///    * NDims indicate that this is a 3D image. ITK can handle images of
	///      arbitrary dimension.
	///    * DimSize indicates the size of the volume in pixels along each
	///      direction.
	///    * ElementType indicate the primitive type used for pixels. In this case
	///      is "unsigned char", implying that the data is digitized in 8 bits /
	///      pixel.
	///    * ElementSpacing indicates the physical separation between the center of
	///      one pixel and the center of the next pixel along each direction in space.
	///      The units used are millimeters.
	///    * ElementByteOrderMSB indicates is the data is encoded in little or big
	///      endian order. You might want to play with this value when moving data
	///      between different computer platforms.
	///    * ElementDataFile is the name of the file containing the raw binary data
	///      of the image. This file must be in the same directory as the header.
	///
	/// MetaImage headers are expected to have extension: ".mha" or ".mhd"
	///
	/// Once you write this header text file, it should be possible to read the
	/// image into your ITK based application using the itk::FileIOToImageFilter
	/// class.
	///
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageWriter vtkMetaImageReader
	/// </seealso>
	// Token: 0x0200078E RID: 1934
	public class vtkMetaImageWriter : vtkImageWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013E54 RID: 81492 RVA: 0x001C1CEF File Offset: 0x001BFEEF
		static vtkMetaImageWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMetaImageWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMetaImageWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013E55 RID: 81493 RVA: 0x001C1D17 File Offset: 0x001BFF17
		public vtkMetaImageWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013E56 RID: 81494
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E57 RID: 81495 RVA: 0x001C1D28 File Offset: 0x001BFF28
		public new static vtkMetaImageWriter New()
		{
			vtkMetaImageWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMetaImageWriter.vtkMetaImageWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMetaImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06013E58 RID: 81496 RVA: 0x001C1D7C File Offset: 0x001BFF7C
		public vtkMetaImageWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMetaImageWriter.vtkMetaImageWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013E59 RID: 81497 RVA: 0x001C1DC0 File Offset: 0x001BFFC0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013E5A RID: 81498
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMetaImageWriter_GetCompression_01(HandleRef pThis);

		/// <summary>
		/// Specify the file name of the raw image data.
		/// </summary>
		// Token: 0x06013E5B RID: 81499 RVA: 0x001C1DCC File Offset: 0x001BFFCC
		public virtual bool GetCompression()
		{
			return vtkMetaImageWriter.vtkMetaImageWriter_GetCompression_01(base.GetCppThis()) != 0;
		}

		// Token: 0x06013E5C RID: 81500
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageWriter_GetFileName_02(HandleRef pThis);

		/// <summary>
		/// Specify file name of meta file
		/// </summary>
		// Token: 0x06013E5D RID: 81501 RVA: 0x001C1DF4 File Offset: 0x001BFFF4
		public override string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMetaImageWriter.vtkMetaImageWriter_GetFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E5E RID: 81502
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMetaImageWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E5F RID: 81503 RVA: 0x001C1E30 File Offset: 0x001C0030
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMetaImageWriter.vtkMetaImageWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06013E60 RID: 81504
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMetaImageWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E61 RID: 81505 RVA: 0x001C1E50 File Offset: 0x001C0050
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMetaImageWriter.vtkMetaImageWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06013E62 RID: 81506
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageWriter_GetRAWFileName_05(HandleRef pThis);

		/// <summary>
		/// Specify the file name of the raw image data.
		/// </summary>
		// Token: 0x06013E63 RID: 81507 RVA: 0x001C1E6C File Offset: 0x001C006C
		public virtual string GetRAWFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMetaImageWriter.vtkMetaImageWriter_GetRAWFileName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013E64 RID: 81508
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMetaImageWriter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E65 RID: 81509 RVA: 0x001C1EA8 File Offset: 0x001C00A8
		public override int IsA(string type)
		{
			return vtkMetaImageWriter.vtkMetaImageWriter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06013E66 RID: 81510
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMetaImageWriter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E67 RID: 81511 RVA: 0x001C1EC8 File Offset: 0x001C00C8
		public new static int IsTypeOf(string type)
		{
			return vtkMetaImageWriter.vtkMetaImageWriter_IsTypeOf_07(type);
		}

		// Token: 0x06013E68 RID: 81512
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageWriter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E69 RID: 81513 RVA: 0x001C1EE4 File Offset: 0x001C00E4
		public new vtkMetaImageWriter NewInstance()
		{
			vtkMetaImageWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMetaImageWriter.vtkMetaImageWriter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMetaImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013E6A RID: 81514
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMetaImageWriter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013E6B RID: 81515 RVA: 0x001C1F40 File Offset: 0x001C0140
		public new static vtkMetaImageWriter SafeDownCast(vtkObjectBase o)
		{
			vtkMetaImageWriter vtkMetaImageWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMetaImageWriter.vtkMetaImageWriter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMetaImageWriter = (vtkMetaImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMetaImageWriter.Register(null);
				}
			}
			return vtkMetaImageWriter;
		}

		// Token: 0x06013E6C RID: 81516
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMetaImageWriter_SetCompression_11(HandleRef pThis, byte compress);

		/// <summary>
		/// Specify the file name of the raw image data.
		/// </summary>
		// Token: 0x06013E6D RID: 81517 RVA: 0x001C1FBF File Offset: 0x001C01BF
		public virtual void SetCompression(bool compress)
		{
			vtkMetaImageWriter.vtkMetaImageWriter_SetCompression_11(base.GetCppThis(), compress ? (byte)1 : (byte)0);
		}

		// Token: 0x06013E6E RID: 81518
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMetaImageWriter_SetFileName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Specify file name of meta file
		/// </summary>
		// Token: 0x06013E6F RID: 81519 RVA: 0x001C1FD7 File Offset: 0x001C01D7
		public override void SetFileName(string fname)
		{
			vtkMetaImageWriter.vtkMetaImageWriter_SetFileName_12(base.GetCppThis(), fname);
		}

		// Token: 0x06013E70 RID: 81520
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMetaImageWriter_SetRAWFileName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Specify the file name of the raw image data.
		/// </summary>
		// Token: 0x06013E71 RID: 81521 RVA: 0x001C1FE7 File Offset: 0x001C01E7
		public virtual void SetRAWFileName(string fname)
		{
			vtkMetaImageWriter.vtkMetaImageWriter_SetRAWFileName_13(base.GetCppThis(), fname);
		}

		// Token: 0x06013E72 RID: 81522
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMetaImageWriter_Write_14(HandleRef pThis);

		/// <summary>
		/// Specify the file name of the raw image data.
		/// </summary>
		// Token: 0x06013E73 RID: 81523 RVA: 0x001C1FF7 File Offset: 0x001C01F7
		public override void Write()
		{
			vtkMetaImageWriter.vtkMetaImageWriter_Write_14(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016D0 RID: 5840
		public new const string MRFullTypeName = "Kitware.VTK.vtkMetaImageWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016D1 RID: 5841
		public new static readonly string MRClassNameKey = "class vtkMetaImageWriter";
	}
}
