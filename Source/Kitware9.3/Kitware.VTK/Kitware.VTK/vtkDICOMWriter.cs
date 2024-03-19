using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// \class vtkDICOMWriter
	/// \brief Write DICOM image files.
	///
	/// This class writes a series of one or more DICOM files.  The default
	/// behavior is to write a series of Secondary Capture files with no
	/// modality-specific information.  To write other kinds of DICOM files,
	/// use the SetGenerator() method to supply a generator for the type of
	/// data set that you wish to write.  Currently, there are generators for
	/// MR and CT data sets.
	/// </summary>
	// Token: 0x02000037 RID: 55
	public class vtkDICOMWriter : vtkImageWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000983 RID: 2435 RVA: 0x00014EFE File Offset: 0x000130FE
		static vtkDICOMWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000984 RID: 2436 RVA: 0x00014F26 File Offset: 0x00013126
		public vtkDICOMWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000985 RID: 2437
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000986 RID: 2438 RVA: 0x00014F34 File Offset: 0x00013134
		public new static vtkDICOMWriter New()
		{
			vtkDICOMWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMWriter.vtkDICOMWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000987 RID: 2439 RVA: 0x00014F88 File Offset: 0x00013188
		public vtkDICOMWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMWriter.vtkDICOMWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000988 RID: 2440 RVA: 0x00014FCC File Offset: 0x000131CC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000989 RID: 2441
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMWriter_GetFileSliceOrder_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600098A RID: 2442 RVA: 0x00014FD8 File Offset: 0x000131D8
		public int GetFileSliceOrder()
		{
			return vtkDICOMWriter.vtkDICOMWriter_GetFileSliceOrder_01(base.GetCppThis());
		}

		// Token: 0x0600098B RID: 2443
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMWriter_GetFileSliceOrderAsString_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600098C RID: 2444 RVA: 0x00014FF8 File Offset: 0x000131F8
		public string GetFileSliceOrderAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMWriter.vtkDICOMWriter_GetFileSliceOrderAsString_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600098D RID: 2445
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMWriter_GetGenerator_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600098E RID: 2446 RVA: 0x00015034 File Offset: 0x00013234
		public vtkDICOMGenerator GetGenerator()
		{
			vtkDICOMGenerator vtkDICOMGenerator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMWriter.vtkDICOMWriter_GetGenerator_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMGenerator = (vtkDICOMGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMGenerator.Register(null);
				}
			}
			return vtkDICOMGenerator;
		}

		// Token: 0x0600098F RID: 2447
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMWriter_GetImageType_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000990 RID: 2448 RVA: 0x000150A4 File Offset: 0x000132A4
		public virtual string GetImageType()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMWriter.vtkDICOMWriter_GetImageType_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000991 RID: 2449
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMWriter_GetMemoryRowOrder_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000992 RID: 2450 RVA: 0x000150E0 File Offset: 0x000132E0
		public int GetMemoryRowOrder()
		{
			return vtkDICOMWriter.vtkDICOMWriter_GetMemoryRowOrder_05(base.GetCppThis());
		}

		// Token: 0x06000993 RID: 2451
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMWriter_GetMemoryRowOrderAsString_06(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000994 RID: 2452 RVA: 0x00015100 File Offset: 0x00013300
		public string GetMemoryRowOrderAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMWriter.vtkDICOMWriter_GetMemoryRowOrderAsString_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000995 RID: 2453
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMWriter_GetMetaData_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000996 RID: 2454 RVA: 0x0001513C File Offset: 0x0001333C
		public vtkDICOMMetaData GetMetaData()
		{
			vtkDICOMMetaData vtkDICOMMetaData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMWriter.vtkDICOMWriter_GetMetaData_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMMetaData = (vtkDICOMMetaData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMMetaData.Register(null);
				}
			}
			return vtkDICOMMetaData;
		}

		// Token: 0x06000997 RID: 2455
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMWriter_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000998 RID: 2456 RVA: 0x000151AC File Offset: 0x000133AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMWriter.vtkDICOMWriter_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06000999 RID: 2457
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMWriter_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600099A RID: 2458 RVA: 0x000151CC File Offset: 0x000133CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMWriter.vtkDICOMWriter_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600099B RID: 2459
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMWriter_GetOverlayInput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600099C RID: 2460 RVA: 0x000151E8 File Offset: 0x000133E8
		public vtkImageData GetOverlayInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMWriter.vtkDICOMWriter_GetOverlayInput_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600099D RID: 2461
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMWriter_GetOverlayType_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600099E RID: 2462 RVA: 0x00015258 File Offset: 0x00013458
		public virtual int GetOverlayType()
		{
			return vtkDICOMWriter.vtkDICOMWriter_GetOverlayType_11(base.GetCppThis());
		}

		// Token: 0x0600099F RID: 2463
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMWriter_GetPatientMatrix_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009A0 RID: 2464 RVA: 0x00015278 File Offset: 0x00013478
		public vtkMatrix4x4 GetPatientMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMWriter.vtkDICOMWriter_GetPatientMatrix_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x060009A1 RID: 2465
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDICOMWriter_GetRescaleIntercept_13(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009A2 RID: 2466 RVA: 0x000152E8 File Offset: 0x000134E8
		public virtual double GetRescaleIntercept()
		{
			return vtkDICOMWriter.vtkDICOMWriter_GetRescaleIntercept_13(base.GetCppThis());
		}

		// Token: 0x060009A3 RID: 2467
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDICOMWriter_GetRescaleSlope_14(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009A4 RID: 2468 RVA: 0x00015308 File Offset: 0x00013508
		public virtual double GetRescaleSlope()
		{
			return vtkDICOMWriter.vtkDICOMWriter_GetRescaleSlope_14(base.GetCppThis());
		}

		// Token: 0x060009A5 RID: 2469
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMWriter_GetSeriesDescription_15(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009A6 RID: 2470 RVA: 0x00015328 File Offset: 0x00013528
		public virtual string GetSeriesDescription()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMWriter.vtkDICOMWriter_GetSeriesDescription_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060009A7 RID: 2471
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMWriter_GetStreaming_16(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009A8 RID: 2472 RVA: 0x00015364 File Offset: 0x00013564
		public virtual int GetStreaming()
		{
			return vtkDICOMWriter.vtkDICOMWriter_GetStreaming_16(base.GetCppThis());
		}

		// Token: 0x060009A9 RID: 2473
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMWriter_GetTimeAsVector_17(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009AA RID: 2474 RVA: 0x00015384 File Offset: 0x00013584
		public virtual int GetTimeAsVector()
		{
			return vtkDICOMWriter.vtkDICOMWriter_GetTimeAsVector_17(base.GetCppThis());
		}

		// Token: 0x060009AB RID: 2475
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMWriter_GetTimeDimension_18(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009AC RID: 2476 RVA: 0x000153A4 File Offset: 0x000135A4
		public virtual int GetTimeDimension()
		{
			return vtkDICOMWriter.vtkDICOMWriter_GetTimeDimension_18(base.GetCppThis());
		}

		// Token: 0x060009AD RID: 2477
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDICOMWriter_GetTimeSpacing_19(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009AE RID: 2478 RVA: 0x000153C4 File Offset: 0x000135C4
		public virtual double GetTimeSpacing()
		{
			return vtkDICOMWriter.vtkDICOMWriter_GetTimeSpacing_19(base.GetCppThis());
		}

		// Token: 0x060009AF RID: 2479
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMWriter_GetTransferSyntaxUID_20(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009B0 RID: 2480 RVA: 0x000153E4 File Offset: 0x000135E4
		public virtual string GetTransferSyntaxUID()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMWriter.vtkDICOMWriter_GetTransferSyntaxUID_20(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060009B1 RID: 2481
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMWriter_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009B2 RID: 2482 RVA: 0x00015420 File Offset: 0x00013620
		public override int IsA(string type)
		{
			return vtkDICOMWriter.vtkDICOMWriter_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x060009B3 RID: 2483
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMWriter_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009B4 RID: 2484 RVA: 0x00015440 File Offset: 0x00013640
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMWriter.vtkDICOMWriter_IsTypeOf_22(type);
		}

		// Token: 0x060009B5 RID: 2485
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMWriter_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009B6 RID: 2486 RVA: 0x0001545C File Offset: 0x0001365C
		public new vtkDICOMWriter NewInstance()
		{
			vtkDICOMWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMWriter.vtkDICOMWriter_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060009B7 RID: 2487
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMWriter_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009B8 RID: 2488 RVA: 0x000154B8 File Offset: 0x000136B8
		public new static vtkDICOMWriter SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMWriter vtkDICOMWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMWriter.vtkDICOMWriter_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMWriter = (vtkDICOMWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMWriter.Register(null);
				}
			}
			return vtkDICOMWriter;
		}

		// Token: 0x060009B9 RID: 2489
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetFileSliceOrder_26(HandleRef pThis, int order);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009BA RID: 2490 RVA: 0x00015537 File Offset: 0x00013737
		public void SetFileSliceOrder(int order)
		{
			vtkDICOMWriter.vtkDICOMWriter_SetFileSliceOrder_26(base.GetCppThis(), order);
		}

		// Token: 0x060009BB RID: 2491
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetFileSliceOrderToLHR_27(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009BC RID: 2492 RVA: 0x00015547 File Offset: 0x00013747
		public void SetFileSliceOrderToLHR()
		{
			vtkDICOMWriter.vtkDICOMWriter_SetFileSliceOrderToLHR_27(base.GetCppThis());
		}

		// Token: 0x060009BD RID: 2493
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetFileSliceOrderToRHR_28(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009BE RID: 2494 RVA: 0x00015556 File Offset: 0x00013756
		public void SetFileSliceOrderToRHR()
		{
			vtkDICOMWriter.vtkDICOMWriter_SetFileSliceOrderToRHR_28(base.GetCppThis());
		}

		// Token: 0x060009BF RID: 2495
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetFileSliceOrderToReverse_29(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009C0 RID: 2496 RVA: 0x00015565 File Offset: 0x00013765
		public void SetFileSliceOrderToReverse()
		{
			vtkDICOMWriter.vtkDICOMWriter_SetFileSliceOrderToReverse_29(base.GetCppThis());
		}

		// Token: 0x060009C1 RID: 2497
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetFileSliceOrderToSame_30(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009C2 RID: 2498 RVA: 0x00015574 File Offset: 0x00013774
		public void SetFileSliceOrderToSame()
		{
			vtkDICOMWriter.vtkDICOMWriter_SetFileSliceOrderToSame_30(base.GetCppThis());
		}

		// Token: 0x060009C3 RID: 2499
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetGenerator_31(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009C4 RID: 2500 RVA: 0x00015584 File Offset: 0x00013784
		public void SetGenerator(vtkDICOMGenerator arg0)
		{
			vtkDICOMWriter.vtkDICOMWriter_SetGenerator_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060009C5 RID: 2501
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetImageType_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009C6 RID: 2502 RVA: 0x000155B3 File Offset: 0x000137B3
		public virtual void SetImageType(string _arg)
		{
			vtkDICOMWriter.vtkDICOMWriter_SetImageType_32(base.GetCppThis(), _arg);
		}

		// Token: 0x060009C7 RID: 2503
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetMemoryRowOrder_33(HandleRef pThis, int order);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009C8 RID: 2504 RVA: 0x000155C3 File Offset: 0x000137C3
		public void SetMemoryRowOrder(int order)
		{
			vtkDICOMWriter.vtkDICOMWriter_SetMemoryRowOrder_33(base.GetCppThis(), order);
		}

		// Token: 0x060009C9 RID: 2505
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetMemoryRowOrderToBottomUp_34(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009CA RID: 2506 RVA: 0x000155D3 File Offset: 0x000137D3
		public void SetMemoryRowOrderToBottomUp()
		{
			vtkDICOMWriter.vtkDICOMWriter_SetMemoryRowOrderToBottomUp_34(base.GetCppThis());
		}

		// Token: 0x060009CB RID: 2507
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetMemoryRowOrderToFileNative_35(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009CC RID: 2508 RVA: 0x000155E2 File Offset: 0x000137E2
		public void SetMemoryRowOrderToFileNative()
		{
			vtkDICOMWriter.vtkDICOMWriter_SetMemoryRowOrderToFileNative_35(base.GetCppThis());
		}

		// Token: 0x060009CD RID: 2509
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetMemoryRowOrderToTopDown_36(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009CE RID: 2510 RVA: 0x000155F1 File Offset: 0x000137F1
		public void SetMemoryRowOrderToTopDown()
		{
			vtkDICOMWriter.vtkDICOMWriter_SetMemoryRowOrderToTopDown_36(base.GetCppThis());
		}

		// Token: 0x060009CF RID: 2511
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetMetaData_37(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009D0 RID: 2512 RVA: 0x00015600 File Offset: 0x00013800
		public void SetMetaData(vtkDICOMMetaData arg0)
		{
			vtkDICOMWriter.vtkDICOMWriter_SetMetaData_37(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060009D1 RID: 2513
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetOverlayInputConnection_38(HandleRef pThis, HandleRef data);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009D2 RID: 2514 RVA: 0x00015630 File Offset: 0x00013830
		public void SetOverlayInputConnection(vtkAlgorithmOutput data)
		{
			vtkDICOMWriter.vtkDICOMWriter_SetOverlayInputConnection_38(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x060009D3 RID: 2515
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetOverlayInputData_39(HandleRef pThis, HandleRef data);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009D4 RID: 2516 RVA: 0x00015660 File Offset: 0x00013860
		public void SetOverlayInputData(vtkImageData data)
		{
			vtkDICOMWriter.vtkDICOMWriter_SetOverlayInputData_39(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x060009D5 RID: 2517
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetOverlayType_40(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009D6 RID: 2518 RVA: 0x0001568F File Offset: 0x0001388F
		public virtual void SetOverlayType(int _arg)
		{
			vtkDICOMWriter.vtkDICOMWriter_SetOverlayType_40(base.GetCppThis(), _arg);
		}

		// Token: 0x060009D7 RID: 2519
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetOverlayTypeToGraphics_41(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009D8 RID: 2520 RVA: 0x0001569F File Offset: 0x0001389F
		public void SetOverlayTypeToGraphics()
		{
			vtkDICOMWriter.vtkDICOMWriter_SetOverlayTypeToGraphics_41(base.GetCppThis());
		}

		// Token: 0x060009D9 RID: 2521
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetOverlayTypeToROI_42(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009DA RID: 2522 RVA: 0x000156AE File Offset: 0x000138AE
		public void SetOverlayTypeToROI()
		{
			vtkDICOMWriter.vtkDICOMWriter_SetOverlayTypeToROI_42(base.GetCppThis());
		}

		// Token: 0x060009DB RID: 2523
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetPatientMatrix_43(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009DC RID: 2524 RVA: 0x000156C0 File Offset: 0x000138C0
		public void SetPatientMatrix(vtkMatrix4x4 arg0)
		{
			vtkDICOMWriter.vtkDICOMWriter_SetPatientMatrix_43(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060009DD RID: 2525
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetRescaleIntercept_44(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009DE RID: 2526 RVA: 0x000156EF File Offset: 0x000138EF
		public virtual void SetRescaleIntercept(double _arg)
		{
			vtkDICOMWriter.vtkDICOMWriter_SetRescaleIntercept_44(base.GetCppThis(), _arg);
		}

		// Token: 0x060009DF RID: 2527
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetRescaleSlope_45(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009E0 RID: 2528 RVA: 0x000156FF File Offset: 0x000138FF
		public virtual void SetRescaleSlope(double _arg)
		{
			vtkDICOMWriter.vtkDICOMWriter_SetRescaleSlope_45(base.GetCppThis(), _arg);
		}

		// Token: 0x060009E1 RID: 2529
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetSeriesDescription_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009E2 RID: 2530 RVA: 0x0001570F File Offset: 0x0001390F
		public virtual void SetSeriesDescription(string _arg)
		{
			vtkDICOMWriter.vtkDICOMWriter_SetSeriesDescription_46(base.GetCppThis(), _arg);
		}

		// Token: 0x060009E3 RID: 2531
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetStreaming_47(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009E4 RID: 2532 RVA: 0x0001571F File Offset: 0x0001391F
		public virtual void SetStreaming(int _arg)
		{
			vtkDICOMWriter.vtkDICOMWriter_SetStreaming_47(base.GetCppThis(), _arg);
		}

		// Token: 0x060009E5 RID: 2533
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetTimeAsVector_48(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009E6 RID: 2534 RVA: 0x0001572F File Offset: 0x0001392F
		public virtual void SetTimeAsVector(int _arg)
		{
			vtkDICOMWriter.vtkDICOMWriter_SetTimeAsVector_48(base.GetCppThis(), _arg);
		}

		// Token: 0x060009E7 RID: 2535
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetTimeDimension_49(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009E8 RID: 2536 RVA: 0x0001573F File Offset: 0x0001393F
		public virtual void SetTimeDimension(int _arg)
		{
			vtkDICOMWriter.vtkDICOMWriter_SetTimeDimension_49(base.GetCppThis(), _arg);
		}

		// Token: 0x060009E9 RID: 2537
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetTimeSpacing_50(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009EA RID: 2538 RVA: 0x0001574F File Offset: 0x0001394F
		public virtual void SetTimeSpacing(double _arg)
		{
			vtkDICOMWriter.vtkDICOMWriter_SetTimeSpacing_50(base.GetCppThis(), _arg);
		}

		// Token: 0x060009EB RID: 2539
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_SetTransferSyntaxUID_51(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009EC RID: 2540 RVA: 0x0001575F File Offset: 0x0001395F
		public virtual void SetTransferSyntaxUID(string _arg)
		{
			vtkDICOMWriter.vtkDICOMWriter_SetTransferSyntaxUID_51(base.GetCppThis(), _arg);
		}

		// Token: 0x060009ED RID: 2541
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_StreamingOff_52(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009EE RID: 2542 RVA: 0x0001576F File Offset: 0x0001396F
		public virtual void StreamingOff()
		{
			vtkDICOMWriter.vtkDICOMWriter_StreamingOff_52(base.GetCppThis());
		}

		// Token: 0x060009EF RID: 2543
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_StreamingOn_53(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009F0 RID: 2544 RVA: 0x0001577E File Offset: 0x0001397E
		public virtual void StreamingOn()
		{
			vtkDICOMWriter.vtkDICOMWriter_StreamingOn_53(base.GetCppThis());
		}

		// Token: 0x060009F1 RID: 2545
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_TimeAsVectorOff_54(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009F2 RID: 2546 RVA: 0x0001578D File Offset: 0x0001398D
		public virtual void TimeAsVectorOff()
		{
			vtkDICOMWriter.vtkDICOMWriter_TimeAsVectorOff_54(base.GetCppThis());
		}

		// Token: 0x060009F3 RID: 2547
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_TimeAsVectorOn_55(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009F4 RID: 2548 RVA: 0x0001579C File Offset: 0x0001399C
		public virtual void TimeAsVectorOn()
		{
			vtkDICOMWriter.vtkDICOMWriter_TimeAsVectorOn_55(base.GetCppThis());
		}

		// Token: 0x060009F5 RID: 2549
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMWriter_Write_56(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060009F6 RID: 2550 RVA: 0x000157AB File Offset: 0x000139AB
		public override void Write()
		{
			vtkDICOMWriter.vtkDICOMWriter_Write_56(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000398 RID: 920
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000399 RID: 921
		public new static readonly string MRClassNameKey = "class vtkDICOMWriter";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000038 RID: 56
		public enum RowOrder
		{
			/// <summary>enum member</summary>
			// Token: 0x0400039B RID: 923
			BottomUp = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400039C RID: 924
			FileNative = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400039D RID: 925
			TopDown
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000039 RID: 57
		public enum SliceOrder
		{
			/// <summary>enum member</summary>
			// Token: 0x0400039F RID: 927
			LHR = 1,
			/// <summary>enum member</summary>
			// Token: 0x040003A0 RID: 928
			RHR = 0,
			/// <summary>enum member</summary>
			// Token: 0x040003A1 RID: 929
			Reverse = 3,
			/// <summary>enum member</summary>
			// Token: 0x040003A2 RID: 930
			Same = 2
		}
	}
}
