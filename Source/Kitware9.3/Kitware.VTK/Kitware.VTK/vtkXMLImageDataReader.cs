using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLImageDataReader
	/// </summary>
	/// <remarks>
	///    Read VTK XML ImageData files.
	///
	/// vtkXMLImageDataReader reads the VTK XML ImageData file format.  One
	/// image data file can be read to produce one output.  Streaming is
	/// supported.  The standard extension for this reader's file format is
	/// "vti".  This reader is also used to read a single piece of the
	/// parallel file format.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPImageDataReader
	/// </seealso>
	// Token: 0x020006D0 RID: 1744
	public class vtkXMLImageDataReader : vtkXMLStructuredDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012856 RID: 75862 RVA: 0x0019F941 File Offset: 0x0019DB41
		static vtkXMLImageDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLImageDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLImageDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012857 RID: 75863 RVA: 0x0019F969 File Offset: 0x0019DB69
		public vtkXMLImageDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012858 RID: 75864
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLImageDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012859 RID: 75865 RVA: 0x0019F978 File Offset: 0x0019DB78
		public new static vtkXMLImageDataReader New()
		{
			vtkXMLImageDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLImageDataReader.vtkXMLImageDataReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLImageDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601285A RID: 75866 RVA: 0x0019F9CC File Offset: 0x0019DBCC
		public vtkXMLImageDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLImageDataReader.vtkXMLImageDataReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601285B RID: 75867 RVA: 0x0019FA10 File Offset: 0x0019DC10
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601285C RID: 75868
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLImageDataReader_CopyOutputInformation_01(HandleRef pThis, HandleRef outInfo, int port);

		/// <summary>
		/// For the specified port, copy the information this reader sets up in
		/// SetupOutputInformation to outInfo
		/// </summary>
		// Token: 0x0601285D RID: 75869 RVA: 0x0019FA1C File Offset: 0x0019DC1C
		public override void CopyOutputInformation(vtkInformation outInfo, int port)
		{
			vtkXMLImageDataReader.vtkXMLImageDataReader_CopyOutputInformation_01(base.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), port);
		}

		// Token: 0x0601285E RID: 75870
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLImageDataReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601285F RID: 75871 RVA: 0x0019FA4C File Offset: 0x0019DC4C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLImageDataReader.vtkXMLImageDataReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06012860 RID: 75872
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLImageDataReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012861 RID: 75873 RVA: 0x0019FA6C File Offset: 0x0019DC6C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLImageDataReader.vtkXMLImageDataReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06012862 RID: 75874
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLImageDataReader_GetOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x06012863 RID: 75875 RVA: 0x0019FA88 File Offset: 0x0019DC88
		public vtkImageData GetOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLImageDataReader.vtkXMLImageDataReader_GetOutput_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012864 RID: 75876
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLImageDataReader_GetOutput_05(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x06012865 RID: 75877 RVA: 0x0019FAF8 File Offset: 0x0019DCF8
		public vtkImageData GetOutput(int idx)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLImageDataReader.vtkXMLImageDataReader_GetOutput_05(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012866 RID: 75878
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLImageDataReader_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012867 RID: 75879 RVA: 0x0019FB68 File Offset: 0x0019DD68
		public override int IsA(string type)
		{
			return vtkXMLImageDataReader.vtkXMLImageDataReader_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06012868 RID: 75880
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLImageDataReader_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012869 RID: 75881 RVA: 0x0019FB88 File Offset: 0x0019DD88
		public new static int IsTypeOf(string type)
		{
			return vtkXMLImageDataReader.vtkXMLImageDataReader_IsTypeOf_07(type);
		}

		// Token: 0x0601286A RID: 75882
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLImageDataReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601286B RID: 75883 RVA: 0x0019FBA4 File Offset: 0x0019DDA4
		public new vtkXMLImageDataReader NewInstance()
		{
			vtkXMLImageDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLImageDataReader.vtkXMLImageDataReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLImageDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601286C RID: 75884
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLImageDataReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601286D RID: 75885 RVA: 0x0019FC00 File Offset: 0x0019DE00
		public new static vtkXMLImageDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLImageDataReader vtkXMLImageDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLImageDataReader.vtkXMLImageDataReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLImageDataReader = (vtkXMLImageDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLImageDataReader.Register(null);
				}
			}
			return vtkXMLImageDataReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001551 RID: 5457
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLImageDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001552 RID: 5458
		public new static readonly string MRClassNameKey = "class vtkXMLImageDataReader";
	}
}
