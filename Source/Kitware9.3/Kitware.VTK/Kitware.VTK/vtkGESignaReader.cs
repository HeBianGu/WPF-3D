using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGESignaReader
	/// </summary>
	/// <remarks>
	///    read GE Signa ximg files
	///
	/// vtkGESignaReader is a source object that reads some GE Signa ximg files It
	/// does support reading in pixel spacing, slice spacing and it computes an
	/// origin for the image in millimeters. It always produces greyscale unsigned
	/// short data and it supports reading in rectangular, packed, compressed, and
	/// packed&amp;compressed. It does not read in slice orientation, or position
	/// right now. To use it you just need to specify a filename or a file prefix
	/// and pattern.
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageReader2
	/// </seealso>
	// Token: 0x02000762 RID: 1890
	public class vtkGESignaReader : vtkMedicalImageReader2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013A11 RID: 80401 RVA: 0x001BBE47 File Offset: 0x001BA047
		static vtkGESignaReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGESignaReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGESignaReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013A12 RID: 80402 RVA: 0x001BBE6F File Offset: 0x001BA06F
		public vtkGESignaReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013A13 RID: 80403
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGESignaReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A14 RID: 80404 RVA: 0x001BBE80 File Offset: 0x001BA080
		public new static vtkGESignaReader New()
		{
			vtkGESignaReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGESignaReader.vtkGESignaReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGESignaReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A15 RID: 80405 RVA: 0x001BBED4 File Offset: 0x001BA0D4
		public vtkGESignaReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGESignaReader.vtkGESignaReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013A16 RID: 80406 RVA: 0x001BBF18 File Offset: 0x001BA118
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013A17 RID: 80407
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGESignaReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Is the given file a GESigna file?
		/// </summary>
		// Token: 0x06013A18 RID: 80408 RVA: 0x001BBF24 File Offset: 0x001BA124
		public override int CanReadFile(string fname)
		{
			return vtkGESignaReader.vtkGESignaReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		// Token: 0x06013A19 RID: 80409
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGESignaReader_GetDescriptiveName_02(HandleRef pThis);

		/// <summary>
		/// A descriptive name for this format
		/// </summary>
		// Token: 0x06013A1A RID: 80410 RVA: 0x001BBF44 File Offset: 0x001BA144
		public override string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGESignaReader.vtkGESignaReader_GetDescriptiveName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013A1B RID: 80411
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGESignaReader_GetFileExtensions_03(HandleRef pThis);

		/// <summary>
		/// Valid extentsions
		/// </summary>
		// Token: 0x06013A1C RID: 80412 RVA: 0x001BBF80 File Offset: 0x001BA180
		public override string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkGESignaReader.vtkGESignaReader_GetFileExtensions_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013A1D RID: 80413
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGESignaReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A1E RID: 80414 RVA: 0x001BBFBC File Offset: 0x001BA1BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGESignaReader.vtkGESignaReader_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06013A1F RID: 80415
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGESignaReader_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A20 RID: 80416 RVA: 0x001BBFDC File Offset: 0x001BA1DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGESignaReader.vtkGESignaReader_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06013A21 RID: 80417
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGESignaReader_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A22 RID: 80418 RVA: 0x001BBFF8 File Offset: 0x001BA1F8
		public override int IsA(string type)
		{
			return vtkGESignaReader.vtkGESignaReader_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06013A23 RID: 80419
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGESignaReader_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A24 RID: 80420 RVA: 0x001BC018 File Offset: 0x001BA218
		public new static int IsTypeOf(string type)
		{
			return vtkGESignaReader.vtkGESignaReader_IsTypeOf_07(type);
		}

		// Token: 0x06013A25 RID: 80421
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGESignaReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A26 RID: 80422 RVA: 0x001BC034 File Offset: 0x001BA234
		public new vtkGESignaReader NewInstance()
		{
			vtkGESignaReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGESignaReader.vtkGESignaReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGESignaReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013A27 RID: 80423
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGESignaReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A28 RID: 80424 RVA: 0x001BC090 File Offset: 0x001BA290
		public new static vtkGESignaReader SafeDownCast(vtkObjectBase o)
		{
			vtkGESignaReader vtkGESignaReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGESignaReader.vtkGESignaReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGESignaReader = (vtkGESignaReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGESignaReader.Register(null);
				}
			}
			return vtkGESignaReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016A2 RID: 5794
		public new const string MRFullTypeName = "Kitware.VTK.vtkGESignaReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016A3 RID: 5795
		public new static readonly string MRClassNameKey = "class vtkGESignaReader";
	}
}
