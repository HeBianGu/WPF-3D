using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageWriter
	/// </summary>
	/// <remarks>
	///    Writes images to files.
	///
	/// vtkImageWriter writes images to files with any data type. The data type of
	/// the file is the same scalar type as the input.  The dimensionality
	/// determines whether the data will be written in one or multiple files.
	/// This class is used as the superclass of most image writing classes
	/// such as vtkBMPWriter etc. It supports streaming.
	/// </remarks>
	// Token: 0x02000036 RID: 54
	public class vtkImageWriter : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600095B RID: 2395 RVA: 0x00014B2D File Offset: 0x00012D2D
		static vtkImageWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600095C RID: 2396 RVA: 0x00014B55 File Offset: 0x00012D55
		public vtkImageWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600095D RID: 2397
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600095E RID: 2398 RVA: 0x00014B64 File Offset: 0x00012D64
		public new static vtkImageWriter New()
		{
			vtkImageWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageWriter.vtkImageWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600095F RID: 2399 RVA: 0x00014BB8 File Offset: 0x00012DB8
		public vtkImageWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageWriter.vtkImageWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000960 RID: 2400 RVA: 0x00014BFC File Offset: 0x00012DFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000961 RID: 2401
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageWriter_DeleteFiles_01(HandleRef pThis);

		/// <summary>
		/// The main interface which triggers the writer to start.
		/// </summary>
		// Token: 0x06000962 RID: 2402 RVA: 0x00014C07 File Offset: 0x00012E07
		public void DeleteFiles()
		{
			vtkImageWriter.vtkImageWriter_DeleteFiles_01(base.GetCppThis());
		}

		// Token: 0x06000963 RID: 2403
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageWriter_GetFileDimensionality_02(HandleRef pThis);

		/// <summary>
		/// What dimension are the files to be written. Usually this is 2, or 3.
		/// If it is 2 and the input is a volume then the volume will be
		/// written as a series of 2d slices.
		/// </summary>
		// Token: 0x06000964 RID: 2404 RVA: 0x00014C18 File Offset: 0x00012E18
		public virtual int GetFileDimensionality()
		{
			return vtkImageWriter.vtkImageWriter_GetFileDimensionality_02(base.GetCppThis());
		}

		// Token: 0x06000965 RID: 2405
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageWriter_GetFileName_03(HandleRef pThis);

		/// <summary>
		/// Specify file name for the image file. You should specify either
		/// a FileName or a FilePrefix. Use FilePrefix if the data is stored
		/// in multiple files.
		/// </summary>
		// Token: 0x06000966 RID: 2406 RVA: 0x00014C38 File Offset: 0x00012E38
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageWriter.vtkImageWriter_GetFileName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000967 RID: 2407
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageWriter_GetFilePattern_04(HandleRef pThis);

		/// <summary>
		/// The snprintf format used to build filename from FilePrefix and number.
		/// </summary>
		// Token: 0x06000968 RID: 2408 RVA: 0x00014C74 File Offset: 0x00012E74
		public virtual string GetFilePattern()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageWriter.vtkImageWriter_GetFilePattern_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000969 RID: 2409
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageWriter_GetFilePrefix_05(HandleRef pThis);

		/// <summary>
		/// Specify file prefix for the image file(s).You should specify either
		/// a FileName or FilePrefix. Use FilePrefix if the data is stored
		/// in multiple files.
		/// </summary>
		// Token: 0x0600096A RID: 2410 RVA: 0x00014CB0 File Offset: 0x00012EB0
		public virtual string GetFilePrefix()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageWriter.vtkImageWriter_GetFilePrefix_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600096B RID: 2411
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageWriter_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the input object from the image pipeline.
		/// </summary>
		// Token: 0x0600096C RID: 2412 RVA: 0x00014CEC File Offset: 0x00012EEC
		public new vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageWriter.vtkImageWriter_GetInput_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600096D RID: 2413
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageWriter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600096E RID: 2414 RVA: 0x00014D5C File Offset: 0x00012F5C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageWriter.vtkImageWriter_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600096F RID: 2415
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageWriter_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000970 RID: 2416 RVA: 0x00014D7C File Offset: 0x00012F7C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageWriter.vtkImageWriter_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06000971 RID: 2417
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageWriter_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000972 RID: 2418 RVA: 0x00014D98 File Offset: 0x00012F98
		public override int IsA(string type)
		{
			return vtkImageWriter.vtkImageWriter_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06000973 RID: 2419
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageWriter_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000974 RID: 2420 RVA: 0x00014DB8 File Offset: 0x00012FB8
		public new static int IsTypeOf(string type)
		{
			return vtkImageWriter.vtkImageWriter_IsTypeOf_10(type);
		}

		// Token: 0x06000975 RID: 2421
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageWriter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000976 RID: 2422 RVA: 0x00014DD4 File Offset: 0x00012FD4
		public new vtkImageWriter NewInstance()
		{
			vtkImageWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageWriter.vtkImageWriter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000977 RID: 2423
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageWriter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000978 RID: 2424 RVA: 0x00014E30 File Offset: 0x00013030
		public new static vtkImageWriter SafeDownCast(vtkObjectBase o)
		{
			vtkImageWriter vtkImageWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageWriter.vtkImageWriter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageWriter = (vtkImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageWriter.Register(null);
				}
			}
			return vtkImageWriter;
		}

		// Token: 0x06000979 RID: 2425
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageWriter_SetFileDimensionality_14(HandleRef pThis, int _arg);

		/// <summary>
		/// What dimension are the files to be written. Usually this is 2, or 3.
		/// If it is 2 and the input is a volume then the volume will be
		/// written as a series of 2d slices.
		/// </summary>
		// Token: 0x0600097A RID: 2426 RVA: 0x00014EAF File Offset: 0x000130AF
		public virtual void SetFileDimensionality(int _arg)
		{
			vtkImageWriter.vtkImageWriter_SetFileDimensionality_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600097B RID: 2427
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageWriter_SetFileName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name for the image file. You should specify either
		/// a FileName or a FilePrefix. Use FilePrefix if the data is stored
		/// in multiple files.
		/// </summary>
		// Token: 0x0600097C RID: 2428 RVA: 0x00014EBF File Offset: 0x000130BF
		public virtual void SetFileName(string _arg)
		{
			vtkImageWriter.vtkImageWriter_SetFileName_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600097D RID: 2429
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageWriter_SetFilePattern_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The snprintf format used to build filename from FilePrefix and number.
		/// </summary>
		// Token: 0x0600097E RID: 2430 RVA: 0x00014ECF File Offset: 0x000130CF
		public virtual void SetFilePattern(string _arg)
		{
			vtkImageWriter.vtkImageWriter_SetFilePattern_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600097F RID: 2431
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageWriter_SetFilePrefix_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file prefix for the image file(s).You should specify either
		/// a FileName or FilePrefix. Use FilePrefix if the data is stored
		/// in multiple files.
		/// </summary>
		// Token: 0x06000980 RID: 2432 RVA: 0x00014EDF File Offset: 0x000130DF
		public virtual void SetFilePrefix(string _arg)
		{
			vtkImageWriter.vtkImageWriter_SetFilePrefix_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06000981 RID: 2433
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageWriter_Write_18(HandleRef pThis);

		/// <summary>
		/// The main interface which triggers the writer to start.
		/// </summary>
		// Token: 0x06000982 RID: 2434 RVA: 0x00014EEF File Offset: 0x000130EF
		public virtual void Write()
		{
			vtkImageWriter.vtkImageWriter_Write_18(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000396 RID: 918
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000397 RID: 919
		public new static readonly string MRClassNameKey = "class vtkImageWriter";
	}
}
