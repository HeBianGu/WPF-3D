using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOggTheoraWriter
	/// </summary>
	/// <remarks>
	///    Uses the ogg and theora libraries to write video
	/// files.
	///
	/// vtkOggTheoraWriter is an adapter that allows VTK to use the ogg and theora
	/// libraries to write movie files.  This class creates .ogv files containing
	/// theora encoded video without audio.
	///
	/// This implementation is based on vtkFFMPEGWriter and uses some code derived
	/// from the encoder example distributed with libtheora.
	///
	/// </remarks>
	// Token: 0x0200016A RID: 362
	public class vtkOggTheoraWriter : vtkGenericMovieWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060044EC RID: 17644 RVA: 0x000647D9 File Offset: 0x000629D9
		static vtkOggTheoraWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOggTheoraWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOggTheoraWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060044ED RID: 17645 RVA: 0x00064801 File Offset: 0x00062A01
		public vtkOggTheoraWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060044EE RID: 17646
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOggTheoraWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060044EF RID: 17647 RVA: 0x00064810 File Offset: 0x00062A10
		public new static vtkOggTheoraWriter New()
		{
			vtkOggTheoraWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOggTheoraWriter.vtkOggTheoraWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOggTheoraWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060044F0 RID: 17648 RVA: 0x00064864 File Offset: 0x00062A64
		public vtkOggTheoraWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOggTheoraWriter.vtkOggTheoraWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060044F1 RID: 17649 RVA: 0x000648A8 File Offset: 0x00062AA8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060044F2 RID: 17650
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOggTheoraWriter_End_01(HandleRef pThis);

		/// <summary>
		/// These methods start writing an Movie file, write a frame to the file
		/// and then end the writing process.
		/// </summary>
		// Token: 0x060044F3 RID: 17651 RVA: 0x000648B3 File Offset: 0x00062AB3
		public override void End()
		{
			vtkOggTheoraWriter.vtkOggTheoraWriter_End_01(base.GetCppThis());
		}

		// Token: 0x060044F4 RID: 17652
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOggTheoraWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060044F5 RID: 17653 RVA: 0x000648C4 File Offset: 0x00062AC4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOggTheoraWriter.vtkOggTheoraWriter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060044F6 RID: 17654
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOggTheoraWriter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060044F7 RID: 17655 RVA: 0x000648E4 File Offset: 0x00062AE4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOggTheoraWriter.vtkOggTheoraWriter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060044F8 RID: 17656
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOggTheoraWriter_GetQuality_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the compression quality.
		/// 0 means worst quality and smallest file size
		/// 2 means best quality and largest file size
		/// </summary>
		// Token: 0x060044F9 RID: 17657 RVA: 0x00064900 File Offset: 0x00062B00
		public virtual int GetQuality()
		{
			return vtkOggTheoraWriter.vtkOggTheoraWriter_GetQuality_04(base.GetCppThis());
		}

		// Token: 0x060044FA RID: 17658
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOggTheoraWriter_GetQualityMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the compression quality.
		/// 0 means worst quality and smallest file size
		/// 2 means best quality and largest file size
		/// </summary>
		// Token: 0x060044FB RID: 17659 RVA: 0x00064920 File Offset: 0x00062B20
		public virtual int GetQualityMaxValue()
		{
			return vtkOggTheoraWriter.vtkOggTheoraWriter_GetQualityMaxValue_05(base.GetCppThis());
		}

		// Token: 0x060044FC RID: 17660
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOggTheoraWriter_GetQualityMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the compression quality.
		/// 0 means worst quality and smallest file size
		/// 2 means best quality and largest file size
		/// </summary>
		// Token: 0x060044FD RID: 17661 RVA: 0x00064940 File Offset: 0x00062B40
		public virtual int GetQualityMinValue()
		{
			return vtkOggTheoraWriter.vtkOggTheoraWriter_GetQualityMinValue_06(base.GetCppThis());
		}

		// Token: 0x060044FE RID: 17662
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOggTheoraWriter_GetRate_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the frame rate, in frame/s.
		/// </summary>
		// Token: 0x060044FF RID: 17663 RVA: 0x00064960 File Offset: 0x00062B60
		public virtual int GetRate()
		{
			return vtkOggTheoraWriter.vtkOggTheoraWriter_GetRate_07(base.GetCppThis());
		}

		// Token: 0x06004500 RID: 17664
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOggTheoraWriter_GetRateMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the frame rate, in frame/s.
		/// </summary>
		// Token: 0x06004501 RID: 17665 RVA: 0x00064980 File Offset: 0x00062B80
		public virtual int GetRateMaxValue()
		{
			return vtkOggTheoraWriter.vtkOggTheoraWriter_GetRateMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06004502 RID: 17666
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOggTheoraWriter_GetRateMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the frame rate, in frame/s.
		/// </summary>
		// Token: 0x06004503 RID: 17667 RVA: 0x000649A0 File Offset: 0x00062BA0
		public virtual int GetRateMinValue()
		{
			return vtkOggTheoraWriter.vtkOggTheoraWriter_GetRateMinValue_09(base.GetCppThis());
		}

		// Token: 0x06004504 RID: 17668
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOggTheoraWriter_GetSubsampling_10(HandleRef pThis);

		/// <summary>
		/// Is the video to be encoded using 4:2:0 subsampling?
		/// </summary>
		// Token: 0x06004505 RID: 17669 RVA: 0x000649C0 File Offset: 0x00062BC0
		public virtual int GetSubsampling()
		{
			return vtkOggTheoraWriter.vtkOggTheoraWriter_GetSubsampling_10(base.GetCppThis());
		}

		// Token: 0x06004506 RID: 17670
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOggTheoraWriter_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004507 RID: 17671 RVA: 0x000649E0 File Offset: 0x00062BE0
		public override int IsA(string type)
		{
			return vtkOggTheoraWriter.vtkOggTheoraWriter_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06004508 RID: 17672
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOggTheoraWriter_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004509 RID: 17673 RVA: 0x00064A00 File Offset: 0x00062C00
		public new static int IsTypeOf(string type)
		{
			return vtkOggTheoraWriter.vtkOggTheoraWriter_IsTypeOf_12(type);
		}

		// Token: 0x0600450A RID: 17674
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOggTheoraWriter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600450B RID: 17675 RVA: 0x00064A1C File Offset: 0x00062C1C
		public new vtkOggTheoraWriter NewInstance()
		{
			vtkOggTheoraWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOggTheoraWriter.vtkOggTheoraWriter_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOggTheoraWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600450C RID: 17676
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOggTheoraWriter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600450D RID: 17677 RVA: 0x00064A78 File Offset: 0x00062C78
		public new static vtkOggTheoraWriter SafeDownCast(vtkObjectBase o)
		{
			vtkOggTheoraWriter vtkOggTheoraWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOggTheoraWriter.vtkOggTheoraWriter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOggTheoraWriter = (vtkOggTheoraWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOggTheoraWriter.Register(null);
				}
			}
			return vtkOggTheoraWriter;
		}

		// Token: 0x0600450E RID: 17678
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOggTheoraWriter_SetQuality_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the compression quality.
		/// 0 means worst quality and smallest file size
		/// 2 means best quality and largest file size
		/// </summary>
		// Token: 0x0600450F RID: 17679 RVA: 0x00064AF7 File Offset: 0x00062CF7
		public virtual void SetQuality(int _arg)
		{
			vtkOggTheoraWriter.vtkOggTheoraWriter_SetQuality_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06004510 RID: 17680
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOggTheoraWriter_SetRate_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the frame rate, in frame/s.
		/// </summary>
		// Token: 0x06004511 RID: 17681 RVA: 0x00064B07 File Offset: 0x00062D07
		public virtual void SetRate(int _arg)
		{
			vtkOggTheoraWriter.vtkOggTheoraWriter_SetRate_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06004512 RID: 17682
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOggTheoraWriter_SetSubsampling_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Is the video to be encoded using 4:2:0 subsampling?
		/// </summary>
		// Token: 0x06004513 RID: 17683 RVA: 0x00064B17 File Offset: 0x00062D17
		public virtual void SetSubsampling(int _arg)
		{
			vtkOggTheoraWriter.vtkOggTheoraWriter_SetSubsampling_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06004514 RID: 17684
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOggTheoraWriter_Start_19(HandleRef pThis);

		/// <summary>
		/// These methods start writing an Movie file, write a frame to the file
		/// and then end the writing process.
		/// </summary>
		// Token: 0x06004515 RID: 17685 RVA: 0x00064B27 File Offset: 0x00062D27
		public override void Start()
		{
			vtkOggTheoraWriter.vtkOggTheoraWriter_Start_19(base.GetCppThis());
		}

		// Token: 0x06004516 RID: 17686
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOggTheoraWriter_SubsamplingOff_20(HandleRef pThis);

		/// <summary>
		/// Is the video to be encoded using 4:2:0 subsampling?
		/// </summary>
		// Token: 0x06004517 RID: 17687 RVA: 0x00064B36 File Offset: 0x00062D36
		public virtual void SubsamplingOff()
		{
			vtkOggTheoraWriter.vtkOggTheoraWriter_SubsamplingOff_20(base.GetCppThis());
		}

		// Token: 0x06004518 RID: 17688
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOggTheoraWriter_SubsamplingOn_21(HandleRef pThis);

		/// <summary>
		/// Is the video to be encoded using 4:2:0 subsampling?
		/// </summary>
		// Token: 0x06004519 RID: 17689 RVA: 0x00064B45 File Offset: 0x00062D45
		public virtual void SubsamplingOn()
		{
			vtkOggTheoraWriter.vtkOggTheoraWriter_SubsamplingOn_21(base.GetCppThis());
		}

		// Token: 0x0600451A RID: 17690
		[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOggTheoraWriter_Write_22(HandleRef pThis);

		/// <summary>
		/// These methods start writing an Movie file, write a frame to the file
		/// and then end the writing process.
		/// </summary>
		// Token: 0x0600451B RID: 17691 RVA: 0x00064B54 File Offset: 0x00062D54
		public override void Write()
		{
			vtkOggTheoraWriter.vtkOggTheoraWriter_Write_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000720 RID: 1824
		public new const string MRFullTypeName = "Kitware.VTK.vtkOggTheoraWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000721 RID: 1825
		public new static readonly string MRClassNameKey = "class vtkOggTheoraWriter";
	}
}
