using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTGAReader
	/// </summary>
	/// <remarks>
	///    read PNG files
	///
	/// vtkTGAReader is a source object that reads Targa files.
	/// It supports uncompressed 24 and 32 bits formats.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageReader2
	/// </seealso>
	// Token: 0x020007A3 RID: 1955
	public class vtkTGAReader : vtkImageReader2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060140F8 RID: 82168 RVA: 0x001C58BB File Offset: 0x001C3ABB
		static vtkTGAReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTGAReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTGAReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060140F9 RID: 82169 RVA: 0x001C58E3 File Offset: 0x001C3AE3
		public vtkTGAReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060140FA RID: 82170
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTGAReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140FB RID: 82171 RVA: 0x001C58F4 File Offset: 0x001C3AF4
		public new static vtkTGAReader New()
		{
			vtkTGAReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTGAReader.vtkTGAReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTGAReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140FC RID: 82172 RVA: 0x001C5948 File Offset: 0x001C3B48
		public vtkTGAReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTGAReader.vtkTGAReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060140FD RID: 82173 RVA: 0x001C598C File Offset: 0x001C3B8C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060140FE RID: 82174
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTGAReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Is the given file a valid TGA file?
		/// </summary>
		// Token: 0x060140FF RID: 82175 RVA: 0x001C5998 File Offset: 0x001C3B98
		public override int CanReadFile(string fname)
		{
			return vtkTGAReader.vtkTGAReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		// Token: 0x06014100 RID: 82176
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTGAReader_GetDescriptiveName_02(HandleRef pThis);

		/// <summary>
		/// Return a descriptive name for the file format that might be useful in a GUI.
		/// </summary>
		// Token: 0x06014101 RID: 82177 RVA: 0x001C59B8 File Offset: 0x001C3BB8
		public override string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTGAReader.vtkTGAReader_GetDescriptiveName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014102 RID: 82178
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTGAReader_GetFileExtensions_03(HandleRef pThis);

		/// <summary>
		/// Get the file extensions for this format.
		/// Returns a string with a space separated list of extensions in
		/// the format .extension
		/// </summary>
		// Token: 0x06014103 RID: 82179 RVA: 0x001C59F4 File Offset: 0x001C3BF4
		public override string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkTGAReader.vtkTGAReader_GetFileExtensions_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014104 RID: 82180
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTGAReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014105 RID: 82181 RVA: 0x001C5A30 File Offset: 0x001C3C30
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTGAReader.vtkTGAReader_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06014106 RID: 82182
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTGAReader_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014107 RID: 82183 RVA: 0x001C5A50 File Offset: 0x001C3C50
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTGAReader.vtkTGAReader_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06014108 RID: 82184
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTGAReader_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014109 RID: 82185 RVA: 0x001C5A6C File Offset: 0x001C3C6C
		public override int IsA(string type)
		{
			return vtkTGAReader.vtkTGAReader_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601410A RID: 82186
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTGAReader_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601410B RID: 82187 RVA: 0x001C5A8C File Offset: 0x001C3C8C
		public new static int IsTypeOf(string type)
		{
			return vtkTGAReader.vtkTGAReader_IsTypeOf_07(type);
		}

		// Token: 0x0601410C RID: 82188
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTGAReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601410D RID: 82189 RVA: 0x001C5AA8 File Offset: 0x001C3CA8
		public new vtkTGAReader NewInstance()
		{
			vtkTGAReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTGAReader.vtkTGAReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTGAReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601410E RID: 82190
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTGAReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601410F RID: 82191 RVA: 0x001C5B04 File Offset: 0x001C3D04
		public new static vtkTGAReader SafeDownCast(vtkObjectBase o)
		{
			vtkTGAReader vtkTGAReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTGAReader.vtkTGAReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTGAReader = (vtkTGAReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTGAReader.Register(null);
				}
			}
			return vtkTGAReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001746 RID: 5958
		public new const string MRFullTypeName = "Kitware.VTK.vtkTGAReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001747 RID: 5959
		public new static readonly string MRClassNameKey = "class vtkTGAReader";
	}
}
