using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkCGNSFileSeriesReader
	/// </summary>
	/// <remarks>
	///  Adds support for reading temporal or partitioned CGNS files.
	///
	/// vtkCGNSFileSeriesReader is a meta-reader that add support for reading
	/// CGNS file series using vtkCGNSReader. We encounter two types of file series
	/// with CGNS:
	/// \li 1. temporal file series - where each file is simply a single timestep.
	/// \li 2. partitioned file series - where each file corresponds to data dumped
	///        out from a rank but has all timesteps.
	///
	///  vtkCGNSFileSeriesReader determines the nature of the file series
	///  encountered and reads the files accordingly. For partitioned files, the
	///  files are distributed among data-processing ranks, while for temporal file
	///  series, blocks are distributed among data-processing ranks (using logic in
	///  vtkCGNSReader itself).
	///
	/// </remarks>
	/// <seealso>
	///   vtkFileSeriesHelper
	/// </seealso>
	// Token: 0x020001E2 RID: 482
	public class vtkCGNSFileSeriesReader : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005BB2 RID: 23474 RVA: 0x00085045 File Offset: 0x00083245
		static vtkCGNSFileSeriesReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCGNSFileSeriesReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCGNSFileSeriesReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005BB3 RID: 23475 RVA: 0x0008506D File Offset: 0x0008326D
		public vtkCGNSFileSeriesReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005BB4 RID: 23476
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSFileSeriesReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005BB5 RID: 23477 RVA: 0x0008507C File Offset: 0x0008327C
		public new static vtkCGNSFileSeriesReader New()
		{
			vtkCGNSFileSeriesReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCGNSFileSeriesReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005BB6 RID: 23478 RVA: 0x000850D0 File Offset: 0x000832D0
		public vtkCGNSFileSeriesReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005BB7 RID: 23479 RVA: 0x00085114 File Offset: 0x00083314
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005BB8 RID: 23480
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSFileSeriesReader_AddFileName_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Add/remove files names in the file series.
		/// </summary>
		// Token: 0x06005BB9 RID: 23481 RVA: 0x0008511F File Offset: 0x0008331F
		public void AddFileName(string fname)
		{
			vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_AddFileName_01(base.GetCppThis(), fname);
		}

		// Token: 0x06005BBA RID: 23482
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSFileSeriesReader_CanReadFile_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		/// Test a file for readability. Ensure that vtkCGNSFileSeriesReader::SetReader
		/// is called before using this method.
		/// </summary>
		// Token: 0x06005BBB RID: 23483 RVA: 0x00085130 File Offset: 0x00083330
		public int CanReadFile(string filename)
		{
			return vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_CanReadFile_02(base.GetCppThis(), filename);
		}

		// Token: 0x06005BBC RID: 23484
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSFileSeriesReader_GetController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the controller.
		/// </summary>
		// Token: 0x06005BBD RID: 23485 RVA: 0x00085150 File Offset: 0x00083350
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_GetController_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x06005BBE RID: 23486
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSFileSeriesReader_GetCurrentFileName_04(HandleRef pThis);

		/// <summary>
		/// Returns the filename being used for current timesteps.
		/// This is only reasonable for temporal file series. For a partitioned file
		/// series, this will return the filename being used on the current rank.
		/// </summary>
		// Token: 0x06005BBF RID: 23487 RVA: 0x000851C0 File Offset: 0x000833C0
		public string GetCurrentFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_GetCurrentFileName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005BC0 RID: 23488
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCGNSFileSeriesReader_GetIgnoreReaderTime_05(HandleRef pThis);

		/// <summary>
		/// If true, then treat file series like it does not contain any time step
		/// values. False by default.
		/// </summary>
		// Token: 0x06005BC1 RID: 23489 RVA: 0x000851FC File Offset: 0x000833FC
		public virtual bool GetIgnoreReaderTime()
		{
			return vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_GetIgnoreReaderTime_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06005BC2 RID: 23490
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCGNSFileSeriesReader_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005BC3 RID: 23491 RVA: 0x00085224 File Offset: 0x00083424
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06005BC4 RID: 23492
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCGNSFileSeriesReader_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005BC5 RID: 23493 RVA: 0x00085244 File Offset: 0x00083444
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06005BC6 RID: 23494
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSFileSeriesReader_GetReader_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the reader.
		/// </summary>
		// Token: 0x06005BC7 RID: 23495 RVA: 0x00085260 File Offset: 0x00083460
		public virtual vtkCGNSReader GetReader()
		{
			vtkCGNSReader vtkCGNSReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_GetReader_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCGNSReader = (vtkCGNSReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCGNSReader.Register(null);
				}
			}
			return vtkCGNSReader;
		}

		// Token: 0x06005BC8 RID: 23496
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSFileSeriesReader_IgnoreReaderTimeOff_09(HandleRef pThis);

		/// <summary>
		/// If true, then treat file series like it does not contain any time step
		/// values. False by default.
		/// </summary>
		// Token: 0x06005BC9 RID: 23497 RVA: 0x000852CF File Offset: 0x000834CF
		public virtual void IgnoreReaderTimeOff()
		{
			vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_IgnoreReaderTimeOff_09(base.GetCppThis());
		}

		// Token: 0x06005BCA RID: 23498
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSFileSeriesReader_IgnoreReaderTimeOn_10(HandleRef pThis);

		/// <summary>
		/// If true, then treat file series like it does not contain any time step
		/// values. False by default.
		/// </summary>
		// Token: 0x06005BCB RID: 23499 RVA: 0x000852DE File Offset: 0x000834DE
		public virtual void IgnoreReaderTimeOn()
		{
			vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_IgnoreReaderTimeOn_10(base.GetCppThis());
		}

		// Token: 0x06005BCC RID: 23500
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSFileSeriesReader_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005BCD RID: 23501 RVA: 0x000852F0 File Offset: 0x000834F0
		public override int IsA(string type)
		{
			return vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06005BCE RID: 23502
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSFileSeriesReader_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005BCF RID: 23503 RVA: 0x00085310 File Offset: 0x00083510
		public new static int IsTypeOf(string type)
		{
			return vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_IsTypeOf_12(type);
		}

		// Token: 0x06005BD0 RID: 23504
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSFileSeriesReader_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005BD1 RID: 23505 RVA: 0x0008532C File Offset: 0x0008352C
		public new vtkCGNSFileSeriesReader NewInstance()
		{
			vtkCGNSFileSeriesReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCGNSFileSeriesReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005BD2 RID: 23506
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSFileSeriesReader_RemoveAllFileNames_15(HandleRef pThis);

		/// <summary>
		/// Add/remove files names in the file series.
		/// </summary>
		// Token: 0x06005BD3 RID: 23507 RVA: 0x00085386 File Offset: 0x00083586
		public void RemoveAllFileNames()
		{
			vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_RemoveAllFileNames_15(base.GetCppThis());
		}

		// Token: 0x06005BD4 RID: 23508
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSFileSeriesReader_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005BD5 RID: 23509 RVA: 0x00085398 File Offset: 0x00083598
		public new static vtkCGNSFileSeriesReader SafeDownCast(vtkObjectBase o)
		{
			vtkCGNSFileSeriesReader vtkCGNSFileSeriesReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCGNSFileSeriesReader = (vtkCGNSFileSeriesReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCGNSFileSeriesReader.Register(null);
				}
			}
			return vtkCGNSFileSeriesReader;
		}

		// Token: 0x06005BD6 RID: 23510
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSFileSeriesReader_SetController_17(HandleRef pThis, HandleRef controller);

		/// <summary>
		/// Get/Set the controller.
		/// </summary>
		// Token: 0x06005BD7 RID: 23511 RVA: 0x00085418 File Offset: 0x00083618
		public void SetController(vtkMultiProcessController controller)
		{
			vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_SetController_17(base.GetCppThis(), (controller == null) ? default(HandleRef) : controller.GetCppThis());
		}

		// Token: 0x06005BD8 RID: 23512
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSFileSeriesReader_SetIgnoreReaderTime_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true, then treat file series like it does not contain any time step
		/// values. False by default.
		/// </summary>
		// Token: 0x06005BD9 RID: 23513 RVA: 0x00085447 File Offset: 0x00083647
		public virtual void SetIgnoreReaderTime(bool _arg)
		{
			vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_SetIgnoreReaderTime_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005BDA RID: 23514
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSFileSeriesReader_SetReader_19(HandleRef pThis, HandleRef reader);

		/// <summary>
		/// Get/Set the reader.
		/// </summary>
		// Token: 0x06005BDB RID: 23515 RVA: 0x00085460 File Offset: 0x00083660
		public virtual void SetReader(vtkCGNSReader reader)
		{
			vtkCGNSFileSeriesReader.vtkCGNSFileSeriesReader_SetReader_19(base.GetCppThis(), (reader == null) ? default(HandleRef) : reader.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400088D RID: 2189
		public new const string MRFullTypeName = "Kitware.VTK.vtkCGNSFileSeriesReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400088E RID: 2190
		public new static readonly string MRClassNameKey = "class vtkCGNSFileSeriesReader";
	}
}
