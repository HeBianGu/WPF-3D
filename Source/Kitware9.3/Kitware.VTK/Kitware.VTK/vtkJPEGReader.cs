using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkJPEGReader
	/// </summary>
	/// <remarks>
	///    read JPEG files
	///
	/// vtkJPEGReader is a source object that reads JPEG files.
	/// The reader can also read an image from a memory buffer,
	/// see vtkImageReader2::MemoryBuffer.
	/// It should be able to read most any JPEG file.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkJPEGWriter
	/// </seealso>
	// Token: 0x02000788 RID: 1928
	public class vtkJPEGReader : vtkImageReader2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013CBA RID: 81082 RVA: 0x001BFAB3 File Offset: 0x001BDCB3
		static vtkJPEGReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkJPEGReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkJPEGReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013CBB RID: 81083 RVA: 0x001BFADB File Offset: 0x001BDCDB
		public vtkJPEGReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013CBC RID: 81084
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJPEGReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CBD RID: 81085 RVA: 0x001BFAEC File Offset: 0x001BDCEC
		public new static vtkJPEGReader New()
		{
			vtkJPEGReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJPEGReader.vtkJPEGReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJPEGReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CBE RID: 81086 RVA: 0x001BFB40 File Offset: 0x001BDD40
		public vtkJPEGReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkJPEGReader.vtkJPEGReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013CBF RID: 81087 RVA: 0x001BFB84 File Offset: 0x001BDD84
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013CC0 RID: 81088
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJPEGReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Is the given file a JPEG file?
		/// </summary>
		// Token: 0x06013CC1 RID: 81089 RVA: 0x001BFB90 File Offset: 0x001BDD90
		public override int CanReadFile(string fname)
		{
			return vtkJPEGReader.vtkJPEGReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		// Token: 0x06013CC2 RID: 81090
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJPEGReader_GetDescriptiveName_02(HandleRef pThis);

		/// <summary>
		/// Return a descriptive name for the file format that might be useful in a GUI.
		/// </summary>
		// Token: 0x06013CC3 RID: 81091 RVA: 0x001BFBB0 File Offset: 0x001BDDB0
		public override string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkJPEGReader.vtkJPEGReader_GetDescriptiveName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013CC4 RID: 81092
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJPEGReader_GetFileExtensions_03(HandleRef pThis);

		/// <summary>
		/// Get the file extensions for this format.
		/// Returns a string with a space separated list of extensions in
		/// the format .extension
		/// </summary>
		// Token: 0x06013CC5 RID: 81093 RVA: 0x001BFBEC File Offset: 0x001BDDEC
		public override string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkJPEGReader.vtkJPEGReader_GetFileExtensions_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013CC6 RID: 81094
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkJPEGReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CC7 RID: 81095 RVA: 0x001BFC28 File Offset: 0x001BDE28
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkJPEGReader.vtkJPEGReader_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06013CC8 RID: 81096
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkJPEGReader_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CC9 RID: 81097 RVA: 0x001BFC48 File Offset: 0x001BDE48
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkJPEGReader.vtkJPEGReader_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06013CCA RID: 81098
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJPEGReader_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CCB RID: 81099 RVA: 0x001BFC64 File Offset: 0x001BDE64
		public override int IsA(string type)
		{
			return vtkJPEGReader.vtkJPEGReader_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06013CCC RID: 81100
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJPEGReader_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CCD RID: 81101 RVA: 0x001BFC84 File Offset: 0x001BDE84
		public new static int IsTypeOf(string type)
		{
			return vtkJPEGReader.vtkJPEGReader_IsTypeOf_07(type);
		}

		// Token: 0x06013CCE RID: 81102
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJPEGReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CCF RID: 81103 RVA: 0x001BFCA0 File Offset: 0x001BDEA0
		public new vtkJPEGReader NewInstance()
		{
			vtkJPEGReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJPEGReader.vtkJPEGReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJPEGReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013CD0 RID: 81104
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJPEGReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CD1 RID: 81105 RVA: 0x001BFCFC File Offset: 0x001BDEFC
		public new static vtkJPEGReader SafeDownCast(vtkObjectBase o)
		{
			vtkJPEGReader vtkJPEGReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJPEGReader.vtkJPEGReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkJPEGReader = (vtkJPEGReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkJPEGReader.Register(null);
				}
			}
			return vtkJPEGReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016C2 RID: 5826
		public new const string MRFullTypeName = "Kitware.VTK.vtkJPEGReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016C3 RID: 5827
		public new static readonly string MRClassNameKey = "class vtkJPEGReader";
	}
}
