using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPNMReader
	/// </summary>
	/// <remarks>
	///    read pnm (i.e., portable anymap) files
	///
	///
	/// vtkPNMReader is a source object that reads pnm (portable anymap) files.
	/// This includes .pbm (bitmap), .pgm (grayscale), and .ppm (pixmap) files.
	/// (Currently this object only reads binary versions of these files.)
	///
	/// PNMReader creates structured point datasets. The dimension of the
	/// dataset depends upon the number of files read. Reading a single file
	/// results in a 2D image, while reading more than one file results in a
	/// 3D volume.
	///
	/// To read a volume, files must be of the form "FileName.&lt;number&gt;" (e.g.,
	/// foo.ppm.0, foo.ppm.1, ...). You must also specify the DataExtent.  The
	/// fifth and sixth values of the DataExtent specify the beginning and ending
	/// files to read.
	/// </remarks>
	// Token: 0x0200079E RID: 1950
	public class vtkPNMReader : vtkImageReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014066 RID: 82022 RVA: 0x001C49AC File Offset: 0x001C2BAC
		static vtkPNMReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPNMReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPNMReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014067 RID: 82023 RVA: 0x001C49D4 File Offset: 0x001C2BD4
		public vtkPNMReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014068 RID: 82024
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNMReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014069 RID: 82025 RVA: 0x001C49E4 File Offset: 0x001C2BE4
		public new static vtkPNMReader New()
		{
			vtkPNMReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPNMReader.vtkPNMReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPNMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601406A RID: 82026 RVA: 0x001C4A38 File Offset: 0x001C2C38
		public vtkPNMReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPNMReader.vtkPNMReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601406B RID: 82027 RVA: 0x001C4A7C File Offset: 0x001C2C7C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601406C RID: 82028
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPNMReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601406D RID: 82029 RVA: 0x001C4A88 File Offset: 0x001C2C88
		public override int CanReadFile(string fname)
		{
			return vtkPNMReader.vtkPNMReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		// Token: 0x0601406E RID: 82030
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNMReader_GetDescriptiveName_02(HandleRef pThis);

		/// <summary>
		/// PNM
		/// </summary>
		// Token: 0x0601406F RID: 82031 RVA: 0x001C4AA8 File Offset: 0x001C2CA8
		public override string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkPNMReader.vtkPNMReader_GetDescriptiveName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014070 RID: 82032
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNMReader_GetFileExtensions_03(HandleRef pThis);

		/// <summary>
		/// .pnm .pgm .ppm
		/// </summary>
		// Token: 0x06014071 RID: 82033 RVA: 0x001C4AE4 File Offset: 0x001C2CE4
		public override string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkPNMReader.vtkPNMReader_GetFileExtensions_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014072 RID: 82034
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPNMReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014073 RID: 82035 RVA: 0x001C4B20 File Offset: 0x001C2D20
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPNMReader.vtkPNMReader_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06014074 RID: 82036
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPNMReader_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014075 RID: 82037 RVA: 0x001C4B40 File Offset: 0x001C2D40
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPNMReader.vtkPNMReader_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06014076 RID: 82038
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPNMReader_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014077 RID: 82039 RVA: 0x001C4B5C File Offset: 0x001C2D5C
		public override int IsA(string type)
		{
			return vtkPNMReader.vtkPNMReader_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06014078 RID: 82040
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPNMReader_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014079 RID: 82041 RVA: 0x001C4B7C File Offset: 0x001C2D7C
		public new static int IsTypeOf(string type)
		{
			return vtkPNMReader.vtkPNMReader_IsTypeOf_07(type);
		}

		// Token: 0x0601407A RID: 82042
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNMReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601407B RID: 82043 RVA: 0x001C4B98 File Offset: 0x001C2D98
		public new vtkPNMReader NewInstance()
		{
			vtkPNMReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPNMReader.vtkPNMReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPNMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601407C RID: 82044
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNMReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601407D RID: 82045 RVA: 0x001C4BF4 File Offset: 0x001C2DF4
		public new static vtkPNMReader SafeDownCast(vtkObjectBase o)
		{
			vtkPNMReader vtkPNMReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPNMReader.vtkPNMReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPNMReader = (vtkPNMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPNMReader.Register(null);
				}
			}
			return vtkPNMReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400173C RID: 5948
		public new const string MRFullTypeName = "Kitware.VTK.vtkPNMReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400173D RID: 5949
		public new static readonly string MRClassNameKey = "class vtkPNMReader";
	}
}
