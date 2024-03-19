using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHDRReader
	/// </summary>
	/// <remarks>
	///    read Radiance HDR files
	///
	/// vtkHDRReader is a source object that reads Radiance HDR files.
	/// HDR files are converted into 32 bit images.
	/// </remarks>
	// Token: 0x02000763 RID: 1891
	public class vtkHDRReader : vtkImageReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013A29 RID: 80425 RVA: 0x001BC10F File Offset: 0x001BA30F
		static vtkHDRReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHDRReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHDRReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013A2A RID: 80426 RVA: 0x001BC137 File Offset: 0x001BA337
		public vtkHDRReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013A2B RID: 80427
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHDRReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A2C RID: 80428 RVA: 0x001BC148 File Offset: 0x001BA348
		public new static vtkHDRReader New()
		{
			vtkHDRReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHDRReader.vtkHDRReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHDRReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A2D RID: 80429 RVA: 0x001BC19C File Offset: 0x001BA39C
		public vtkHDRReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHDRReader.vtkHDRReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013A2E RID: 80430 RVA: 0x001BC1E0 File Offset: 0x001BA3E0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013A2F RID: 80431
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHDRReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Is the given file a HDR file?
		/// </summary>
		// Token: 0x06013A30 RID: 80432 RVA: 0x001BC1EC File Offset: 0x001BA3EC
		public override int CanReadFile(string fname)
		{
			return vtkHDRReader.vtkHDRReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		// Token: 0x06013A31 RID: 80433
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHDRReader_GetDescriptiveName_02(HandleRef pThis);

		/// <summary>
		/// Return a descriptive name for the file format that might be useful in a GUI.
		/// </summary>
		// Token: 0x06013A32 RID: 80434 RVA: 0x001BC20C File Offset: 0x001BA40C
		public override string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkHDRReader.vtkHDRReader_GetDescriptiveName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013A33 RID: 80435
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHDRReader_GetExposure_03(HandleRef pThis);

		/// <summary>
		/// Get exposure.
		/// Default value is 1.0.
		/// </summary>
		// Token: 0x06013A34 RID: 80436 RVA: 0x001BC248 File Offset: 0x001BA448
		public virtual double GetExposure()
		{
			return vtkHDRReader.vtkHDRReader_GetExposure_03(base.GetCppThis());
		}

		// Token: 0x06013A35 RID: 80437
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHDRReader_GetFileExtensions_04(HandleRef pThis);

		/// <summary>
		/// Get the file extensions for this format.
		/// Returns a string with a space separated list of extensions in
		/// the format .extension
		/// </summary>
		// Token: 0x06013A36 RID: 80438 RVA: 0x001BC268 File Offset: 0x001BA468
		public override string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkHDRReader.vtkHDRReader_GetFileExtensions_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013A37 RID: 80439
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHDRReader_GetFormat_05(HandleRef pThis);

		/// <summary>
		/// Format is either 32-bit_rle_rgbe or 32-bit_rle_xyze.
		/// </summary>
		// Token: 0x06013A38 RID: 80440 RVA: 0x001BC2A4 File Offset: 0x001BA4A4
		public virtual int GetFormat()
		{
			return vtkHDRReader.vtkHDRReader_GetFormat_05(base.GetCppThis());
		}

		// Token: 0x06013A39 RID: 80441
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHDRReader_GetGamma_06(HandleRef pThis);

		/// <summary>
		/// Get gamma correction.
		/// Default value is 1.0.
		/// </summary>
		// Token: 0x06013A3A RID: 80442 RVA: 0x001BC2C4 File Offset: 0x001BA4C4
		public virtual double GetGamma()
		{
			return vtkHDRReader.vtkHDRReader_GetGamma_06(base.GetCppThis());
		}

		// Token: 0x06013A3B RID: 80443
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHDRReader_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A3C RID: 80444 RVA: 0x001BC2E4 File Offset: 0x001BA4E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHDRReader.vtkHDRReader_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06013A3D RID: 80445
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHDRReader_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A3E RID: 80446 RVA: 0x001BC304 File Offset: 0x001BA504
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHDRReader.vtkHDRReader_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06013A3F RID: 80447
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHDRReader_GetPixelAspect_09(HandleRef pThis);

		/// <summary>
		/// Get pixel aspect, the ratio of height by the width of a pixel.
		/// Default value is 1.0.
		/// </summary>
		// Token: 0x06013A40 RID: 80448 RVA: 0x001BC320 File Offset: 0x001BA520
		public virtual double GetPixelAspect()
		{
			return vtkHDRReader.vtkHDRReader_GetPixelAspect_09(base.GetCppThis());
		}

		// Token: 0x06013A41 RID: 80449
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHDRReader_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A42 RID: 80450 RVA: 0x001BC340 File Offset: 0x001BA540
		public override int IsA(string type)
		{
			return vtkHDRReader.vtkHDRReader_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06013A43 RID: 80451
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHDRReader_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A44 RID: 80452 RVA: 0x001BC360 File Offset: 0x001BA560
		public new static int IsTypeOf(string type)
		{
			return vtkHDRReader.vtkHDRReader_IsTypeOf_11(type);
		}

		// Token: 0x06013A45 RID: 80453
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHDRReader_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A46 RID: 80454 RVA: 0x001BC37C File Offset: 0x001BA57C
		public new vtkHDRReader NewInstance()
		{
			vtkHDRReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHDRReader.vtkHDRReader_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHDRReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013A47 RID: 80455
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHDRReader_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A48 RID: 80456 RVA: 0x001BC3D8 File Offset: 0x001BA5D8
		public new static vtkHDRReader SafeDownCast(vtkObjectBase o)
		{
			vtkHDRReader vtkHDRReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHDRReader.vtkHDRReader_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHDRReader = (vtkHDRReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHDRReader.Register(null);
				}
			}
			return vtkHDRReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016A4 RID: 5796
		public new const string MRFullTypeName = "Kitware.VTK.vtkHDRReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016A5 RID: 5797
		public new static readonly string MRClassNameKey = "class vtkHDRReader";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000764 RID: 1892
		public enum FormatType
		{
			/// <summary>enum member</summary>
			// Token: 0x040016A7 RID: 5799
			FORMAT_32BIT_RLE_RGBE,
			/// <summary>enum member</summary>
			// Token: 0x040016A8 RID: 5800
			FORMAT_32BIT_RLE_XYZE
		}
	}
}
