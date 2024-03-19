using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPImageDataReader
	/// </summary>
	/// <remarks>
	///    Read PVTK XML ImageData files.
	///
	/// vtkXMLPImageDataReader reads the PVTK XML ImageData file format.
	/// This reads the parallel format's summary file and then uses
	/// vtkXMLImageDataReader to read data from the individual ImageData
	/// piece files.  Streaming is supported.  The standard extension for
	/// this reader's file format is "pvti".
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLImageDataReader
	/// </seealso>
	// Token: 0x020006D6 RID: 1750
	public class vtkXMLPImageDataReader : vtkXMLPStructuredDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060128DC RID: 75996 RVA: 0x001A0753 File Offset: 0x0019E953
		static vtkXMLPImageDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPImageDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPImageDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060128DD RID: 75997 RVA: 0x001A077B File Offset: 0x0019E97B
		public vtkXMLPImageDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060128DE RID: 75998
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPImageDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128DF RID: 75999 RVA: 0x001A078C File Offset: 0x0019E98C
		public new static vtkXMLPImageDataReader New()
		{
			vtkXMLPImageDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPImageDataReader.vtkXMLPImageDataReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPImageDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128E0 RID: 76000 RVA: 0x001A07E0 File Offset: 0x0019E9E0
		public vtkXMLPImageDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPImageDataReader.vtkXMLPImageDataReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060128E1 RID: 76001 RVA: 0x001A0824 File Offset: 0x0019EA24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060128E2 RID: 76002
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLPImageDataReader_CopyOutputInformation_01(HandleRef pThis, HandleRef outInfo, int port);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x060128E3 RID: 76003 RVA: 0x001A0830 File Offset: 0x0019EA30
		public override void CopyOutputInformation(vtkInformation outInfo, int port)
		{
			vtkXMLPImageDataReader.vtkXMLPImageDataReader_CopyOutputInformation_01(base.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), port);
		}

		// Token: 0x060128E4 RID: 76004
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPImageDataReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128E5 RID: 76005 RVA: 0x001A0860 File Offset: 0x0019EA60
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPImageDataReader.vtkXMLPImageDataReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060128E6 RID: 76006
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPImageDataReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128E7 RID: 76007 RVA: 0x001A0880 File Offset: 0x0019EA80
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPImageDataReader.vtkXMLPImageDataReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060128E8 RID: 76008
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPImageDataReader_GetOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x060128E9 RID: 76009 RVA: 0x001A089C File Offset: 0x0019EA9C
		public vtkImageData GetOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPImageDataReader.vtkXMLPImageDataReader_GetOutput_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060128EA RID: 76010
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPImageDataReader_GetOutput_05(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x060128EB RID: 76011 RVA: 0x001A090C File Offset: 0x0019EB0C
		public vtkImageData GetOutput(int idx)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPImageDataReader.vtkXMLPImageDataReader_GetOutput_05(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060128EC RID: 76012
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPImageDataReader_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128ED RID: 76013 RVA: 0x001A097C File Offset: 0x0019EB7C
		public override int IsA(string type)
		{
			return vtkXMLPImageDataReader.vtkXMLPImageDataReader_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060128EE RID: 76014
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPImageDataReader_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128EF RID: 76015 RVA: 0x001A099C File Offset: 0x0019EB9C
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPImageDataReader.vtkXMLPImageDataReader_IsTypeOf_07(type);
		}

		// Token: 0x060128F0 RID: 76016
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPImageDataReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128F1 RID: 76017 RVA: 0x001A09B8 File Offset: 0x0019EBB8
		public new vtkXMLPImageDataReader NewInstance()
		{
			vtkXMLPImageDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPImageDataReader.vtkXMLPImageDataReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPImageDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060128F2 RID: 76018
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPImageDataReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128F3 RID: 76019 RVA: 0x001A0A14 File Offset: 0x0019EC14
		public new static vtkXMLPImageDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPImageDataReader vtkXMLPImageDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPImageDataReader.vtkXMLPImageDataReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPImageDataReader = (vtkXMLPImageDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPImageDataReader.Register(null);
				}
			}
			return vtkXMLPImageDataReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400155D RID: 5469
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPImageDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400155E RID: 5470
		public new static readonly string MRClassNameKey = "class vtkXMLPImageDataReader";
	}
}
