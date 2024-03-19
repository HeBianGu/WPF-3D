using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBMPReader
	/// </summary>
	/// <remarks>
	///    read Windows BMP files
	///
	/// vtkBMPReader is a source object that reads Windows BMP files.
	/// This includes indexed and 24bit bitmaps
	/// Usually, all BMPs are converted to 24bit RGB, but BMPs may be output
	/// as 8bit images with a LookupTable if the Allow8BitBMP flag is set.
	///
	/// BMPReader creates structured point datasets. The dimension of the
	/// dataset depends upon the number of files read. Reading a single file
	/// results in a 2D image, while reading more than one file results in a
	/// 3D volume.
	///
	/// To read a volume, files must be of the form "FileName.&lt;number&gt;"
	/// (e.g., foo.bmp.0, foo.bmp.1, ...). You must also specify the image
	/// range. This range specifies the beginning and ending files to read (range
	/// can be any pair of non-negative numbers).
	///
	/// The default behavior is to read a single file. In this case, the form
	/// of the file is simply "FileName" (e.g., foo.bmp).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBMPWriter
	/// </seealso>
	// Token: 0x0200075C RID: 1884
	public class vtkBMPReader : vtkImageReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013919 RID: 80153 RVA: 0x001BA6C3 File Offset: 0x001B88C3
		static vtkBMPReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBMPReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBMPReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601391A RID: 80154 RVA: 0x001BA6EB File Offset: 0x001B88EB
		public vtkBMPReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601391B RID: 80155
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBMPReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601391C RID: 80156 RVA: 0x001BA6FC File Offset: 0x001B88FC
		public new static vtkBMPReader New()
		{
			vtkBMPReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBMPReader.vtkBMPReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBMPReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601391D RID: 80157 RVA: 0x001BA750 File Offset: 0x001B8950
		public vtkBMPReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBMPReader.vtkBMPReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601391E RID: 80158 RVA: 0x001BA794 File Offset: 0x001B8994
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601391F RID: 80159
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBMPReader_Allow8BitBMPOff_01(HandleRef pThis);

		/// <summary>
		/// If this flag is set and the BMP reader encounters an 8bit file,
		/// the data will be kept as unsigned chars and a lookuptable will be
		/// exported
		/// </summary>
		// Token: 0x06013920 RID: 80160 RVA: 0x001BA79F File Offset: 0x001B899F
		public virtual void Allow8BitBMPOff()
		{
			vtkBMPReader.vtkBMPReader_Allow8BitBMPOff_01(base.GetCppThis());
		}

		// Token: 0x06013921 RID: 80161
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBMPReader_Allow8BitBMPOn_02(HandleRef pThis);

		/// <summary>
		/// If this flag is set and the BMP reader encounters an 8bit file,
		/// the data will be kept as unsigned chars and a lookuptable will be
		/// exported
		/// </summary>
		// Token: 0x06013922 RID: 80162 RVA: 0x001BA7AE File Offset: 0x001B89AE
		public virtual void Allow8BitBMPOn()
		{
			vtkBMPReader.vtkBMPReader_Allow8BitBMPOn_02(base.GetCppThis());
		}

		// Token: 0x06013923 RID: 80163
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBMPReader_CanReadFile_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Is the given file a BMP file?
		/// </summary>
		// Token: 0x06013924 RID: 80164 RVA: 0x001BA7C0 File Offset: 0x001B89C0
		public override int CanReadFile(string fname)
		{
			return vtkBMPReader.vtkBMPReader_CanReadFile_03(base.GetCppThis(), fname);
		}

		// Token: 0x06013925 RID: 80165
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBMPReader_GetAllow8BitBMP_04(HandleRef pThis);

		/// <summary>
		/// If this flag is set and the BMP reader encounters an 8bit file,
		/// the data will be kept as unsigned chars and a lookuptable will be
		/// exported
		/// </summary>
		// Token: 0x06013926 RID: 80166 RVA: 0x001BA7E0 File Offset: 0x001B89E0
		public virtual int GetAllow8BitBMP()
		{
			return vtkBMPReader.vtkBMPReader_GetAllow8BitBMP_04(base.GetCppThis());
		}

		// Token: 0x06013927 RID: 80167
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBMPReader_GetColors_05(HandleRef pThis);

		/// <summary>
		/// Returns the color lut.
		/// </summary>
		// Token: 0x06013928 RID: 80168 RVA: 0x001BA800 File Offset: 0x001B8A00
		public virtual IntPtr GetColors()
		{
			return vtkBMPReader.vtkBMPReader_GetColors_05(base.GetCppThis());
		}

		// Token: 0x06013929 RID: 80169
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBMPReader_GetDepth_06(HandleRef pThis);

		/// <summary>
		/// Returns the depth of the BMP, either 8 or 24.
		/// </summary>
		// Token: 0x0601392A RID: 80170 RVA: 0x001BA820 File Offset: 0x001B8A20
		public virtual int GetDepth()
		{
			return vtkBMPReader.vtkBMPReader_GetDepth_06(base.GetCppThis());
		}

		// Token: 0x0601392B RID: 80171
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBMPReader_GetDescriptiveName_07(HandleRef pThis);

		/// <summary>
		/// Return a descriptive name for the file format that might be useful in a GUI.
		/// </summary>
		// Token: 0x0601392C RID: 80172 RVA: 0x001BA840 File Offset: 0x001B8A40
		public override string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkBMPReader.vtkBMPReader_GetDescriptiveName_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601392D RID: 80173
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBMPReader_GetFileExtensions_08(HandleRef pThis);

		/// <summary>
		/// Get the file extensions for this format.
		/// Returns a string with a space separated list of extensions in
		/// the format .extension
		/// </summary>
		// Token: 0x0601392E RID: 80174 RVA: 0x001BA87C File Offset: 0x001B8A7C
		public override string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkBMPReader.vtkBMPReader_GetFileExtensions_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601392F RID: 80175
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBMPReader_GetLookupTable_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If this flag is set and the BMP reader encounters an 8bit file,
		/// the data will be kept as unsigned chars and a lookuptable will be
		/// exported
		/// </summary>
		// Token: 0x06013930 RID: 80176 RVA: 0x001BA8B8 File Offset: 0x001B8AB8
		public virtual vtkLookupTable GetLookupTable()
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBMPReader.vtkBMPReader_GetLookupTable_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		// Token: 0x06013931 RID: 80177
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBMPReader_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013932 RID: 80178 RVA: 0x001BA928 File Offset: 0x001B8B28
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBMPReader.vtkBMPReader_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06013933 RID: 80179
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBMPReader_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013934 RID: 80180 RVA: 0x001BA948 File Offset: 0x001B8B48
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBMPReader.vtkBMPReader_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06013935 RID: 80181
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBMPReader_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013936 RID: 80182 RVA: 0x001BA964 File Offset: 0x001B8B64
		public override int IsA(string type)
		{
			return vtkBMPReader.vtkBMPReader_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06013937 RID: 80183
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBMPReader_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013938 RID: 80184 RVA: 0x001BA984 File Offset: 0x001B8B84
		public new static int IsTypeOf(string type)
		{
			return vtkBMPReader.vtkBMPReader_IsTypeOf_13(type);
		}

		// Token: 0x06013939 RID: 80185
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBMPReader_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601393A RID: 80186 RVA: 0x001BA9A0 File Offset: 0x001B8BA0
		public new vtkBMPReader NewInstance()
		{
			vtkBMPReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBMPReader.vtkBMPReader_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBMPReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601393B RID: 80187
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBMPReader_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601393C RID: 80188 RVA: 0x001BA9FC File Offset: 0x001B8BFC
		public new static vtkBMPReader SafeDownCast(vtkObjectBase o)
		{
			vtkBMPReader vtkBMPReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBMPReader.vtkBMPReader_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBMPReader = (vtkBMPReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBMPReader.Register(null);
				}
			}
			return vtkBMPReader;
		}

		// Token: 0x0601393D RID: 80189
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBMPReader_SetAllow8BitBMP_17(HandleRef pThis, int _arg);

		/// <summary>
		/// If this flag is set and the BMP reader encounters an 8bit file,
		/// the data will be kept as unsigned chars and a lookuptable will be
		/// exported
		/// </summary>
		// Token: 0x0601393E RID: 80190 RVA: 0x001BAA7B File Offset: 0x001B8C7B
		public virtual void SetAllow8BitBMP(int _arg)
		{
			vtkBMPReader.vtkBMPReader_SetAllow8BitBMP_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001695 RID: 5781
		public new const string MRFullTypeName = "Kitware.VTK.vtkBMPReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001696 RID: 5782
		public new static readonly string MRClassNameKey = "class vtkBMPReader";
	}
}
