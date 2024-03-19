using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkThreadedImageAlgorithm
	/// </summary>
	/// <remarks>
	///    Generic filter that has one input.
	///
	/// vtkThreadedImageAlgorithm is a filter superclass that hides much of the
	/// pipeline complexity. It handles breaking the pipeline execution
	/// into smaller extents so that the vtkImageData limits are observed. It
	/// also provides support for multithreading. If you don't need any of this
	/// functionality, consider using vtkSimpleImageToImageAlgorithm instead.
	/// </remarks>
	/// <seealso>
	///
	/// vtkSimpleImageToImageAlgorithm
	/// </seealso>
	// Token: 0x0200003A RID: 58
	public class vtkThreadedImageAlgorithm : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060009F7 RID: 2551 RVA: 0x000157BA File Offset: 0x000139BA
		static vtkThreadedImageAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThreadedImageAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThreadedImageAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060009F8 RID: 2552 RVA: 0x000157E2 File Offset: 0x000139E2
		public vtkThreadedImageAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060009F9 RID: 2553 RVA: 0x000157F0 File Offset: 0x000139F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060009FA RID: 2554
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThreadedImageAlgorithm_GetDesiredBytesPerPiece_01(HandleRef pThis);

		/// <summary>
		/// The desired bytes per piece when volume is split for execution.
		/// When SMP is enabled, this is used to subdivide the volume into pieces.
		/// Smaller pieces allow for better dynamic load balancing, but increase
		/// the total overhead. The default is 65536 bytes.
		/// </summary>
		// Token: 0x060009FB RID: 2555 RVA: 0x000157FC File Offset: 0x000139FC
		public virtual long GetDesiredBytesPerPiece()
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_GetDesiredBytesPerPiece_01(base.GetCppThis());
		}

		// Token: 0x060009FC RID: 2556
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkThreadedImageAlgorithm_GetEnableSMP_02(HandleRef pThis);

		/// <summary>
		/// Enable/Disable SMP for threading.
		/// </summary>
		// Token: 0x060009FD RID: 2557 RVA: 0x0001581C File Offset: 0x00013A1C
		public virtual bool GetEnableSMP()
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_GetEnableSMP_02(base.GetCppThis()) != 0;
		}

		// Token: 0x060009FE RID: 2558
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkThreadedImageAlgorithm_GetGlobalDefaultEnableSMP_03();

		/// <summary>
		/// Global Disable SMP for all derived Imaging filters.
		/// </summary>
		// Token: 0x060009FF RID: 2559 RVA: 0x00015844 File Offset: 0x00013A44
		public static bool GetGlobalDefaultEnableSMP()
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_GetGlobalDefaultEnableSMP_03() != 0;
		}

		// Token: 0x06000A00 RID: 2560
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThreadedImageAlgorithm_GetMinimumPieceSize_04(HandleRef pThis);

		/// <summary>
		/// The minimum piece size when volume is split for execution.
		/// By default, the minimum size is (16,1,1).
		/// </summary>
		// Token: 0x06000A01 RID: 2561 RVA: 0x00015864 File Offset: 0x00013A64
		public virtual int[] GetMinimumPieceSize()
		{
			IntPtr intPtr = vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_GetMinimumPieceSize_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000A02 RID: 2562
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedImageAlgorithm_GetMinimumPieceSize_05(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// The minimum piece size when volume is split for execution.
		/// By default, the minimum size is (16,1,1).
		/// </summary>
		// Token: 0x06000A03 RID: 2563 RVA: 0x000158AC File Offset: 0x00013AAC
		public virtual void GetMinimumPieceSize(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_GetMinimumPieceSize_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06000A04 RID: 2564
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedImageAlgorithm_GetMinimumPieceSize_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The minimum piece size when volume is split for execution.
		/// By default, the minimum size is (16,1,1).
		/// </summary>
		// Token: 0x06000A05 RID: 2565 RVA: 0x000158BE File Offset: 0x00013ABE
		public virtual void GetMinimumPieceSize(IntPtr _arg)
		{
			vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_GetMinimumPieceSize_06(base.GetCppThis(), _arg);
		}

		// Token: 0x06000A06 RID: 2566
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThreadedImageAlgorithm_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A07 RID: 2567 RVA: 0x000158D0 File Offset: 0x00013AD0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06000A08 RID: 2568
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThreadedImageAlgorithm_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A09 RID: 2569 RVA: 0x000158F0 File Offset: 0x00013AF0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06000A0A RID: 2570
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreadedImageAlgorithm_GetNumberOfThreads_09(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of threads to create when rendering.
		/// This is ignored if EnableSMP is On.
		/// </summary>
		// Token: 0x06000A0B RID: 2571 RVA: 0x0001590C File Offset: 0x00013B0C
		public virtual int GetNumberOfThreads()
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_GetNumberOfThreads_09(base.GetCppThis());
		}

		// Token: 0x06000A0C RID: 2572
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreadedImageAlgorithm_GetNumberOfThreadsMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of threads to create when rendering.
		/// This is ignored if EnableSMP is On.
		/// </summary>
		// Token: 0x06000A0D RID: 2573 RVA: 0x0001592C File Offset: 0x00013B2C
		public virtual int GetNumberOfThreadsMaxValue()
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_GetNumberOfThreadsMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06000A0E RID: 2574
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreadedImageAlgorithm_GetNumberOfThreadsMinValue_11(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of threads to create when rendering.
		/// This is ignored if EnableSMP is On.
		/// </summary>
		// Token: 0x06000A0F RID: 2575 RVA: 0x0001594C File Offset: 0x00013B4C
		public virtual int GetNumberOfThreadsMinValue()
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_GetNumberOfThreadsMinValue_11(base.GetCppThis());
		}

		// Token: 0x06000A10 RID: 2576
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreadedImageAlgorithm_GetSplitMode_12(HandleRef pThis);

		/// <summary>
		/// Set the method used to divide the volume into pieces.
		/// Slab mode splits the volume along the Z direction first,
		/// Beam mode splits evenly along the Z and Y directions, and
		/// Block mode splits evenly along all three directions.
		/// Most filters use Slab mode as the default.
		/// </summary>
		// Token: 0x06000A11 RID: 2577 RVA: 0x0001596C File Offset: 0x00013B6C
		public virtual int GetSplitMode()
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_GetSplitMode_12(base.GetCppThis());
		}

		// Token: 0x06000A12 RID: 2578
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreadedImageAlgorithm_GetSplitModeMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Set the method used to divide the volume into pieces.
		/// Slab mode splits the volume along the Z direction first,
		/// Beam mode splits evenly along the Z and Y directions, and
		/// Block mode splits evenly along all three directions.
		/// Most filters use Slab mode as the default.
		/// </summary>
		// Token: 0x06000A13 RID: 2579 RVA: 0x0001598C File Offset: 0x00013B8C
		public virtual int GetSplitModeMaxValue()
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_GetSplitModeMaxValue_13(base.GetCppThis());
		}

		// Token: 0x06000A14 RID: 2580
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreadedImageAlgorithm_GetSplitModeMinValue_14(HandleRef pThis);

		/// <summary>
		/// Set the method used to divide the volume into pieces.
		/// Slab mode splits the volume along the Z direction first,
		/// Beam mode splits evenly along the Z and Y directions, and
		/// Block mode splits evenly along all three directions.
		/// Most filters use Slab mode as the default.
		/// </summary>
		// Token: 0x06000A15 RID: 2581 RVA: 0x000159AC File Offset: 0x00013BAC
		public virtual int GetSplitModeMinValue()
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_GetSplitModeMinValue_14(base.GetCppThis());
		}

		// Token: 0x06000A16 RID: 2582
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreadedImageAlgorithm_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A17 RID: 2583 RVA: 0x000159CC File Offset: 0x00013BCC
		public override int IsA(string type)
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06000A18 RID: 2584
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreadedImageAlgorithm_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A19 RID: 2585 RVA: 0x000159EC File Offset: 0x00013BEC
		public new static int IsTypeOf(string type)
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_IsTypeOf_16(type);
		}

		// Token: 0x06000A1A RID: 2586
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThreadedImageAlgorithm_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A1B RID: 2587 RVA: 0x00015A08 File Offset: 0x00013C08
		public new vtkThreadedImageAlgorithm NewInstance()
		{
			vtkThreadedImageAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThreadedImageAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000A1C RID: 2588
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThreadedImageAlgorithm_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A1D RID: 2589 RVA: 0x00015A64 File Offset: 0x00013C64
		public new static vtkThreadedImageAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkThreadedImageAlgorithm vtkThreadedImageAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThreadedImageAlgorithm = (vtkThreadedImageAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThreadedImageAlgorithm.Register(null);
				}
			}
			return vtkThreadedImageAlgorithm;
		}

		// Token: 0x06000A1E RID: 2590
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedImageAlgorithm_SetDesiredBytesPerPiece_19(HandleRef pThis, long _arg);

		/// <summary>
		/// The desired bytes per piece when volume is split for execution.
		/// When SMP is enabled, this is used to subdivide the volume into pieces.
		/// Smaller pieces allow for better dynamic load balancing, but increase
		/// the total overhead. The default is 65536 bytes.
		/// </summary>
		// Token: 0x06000A1F RID: 2591 RVA: 0x00015AE3 File Offset: 0x00013CE3
		public virtual void SetDesiredBytesPerPiece(long _arg)
		{
			vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_SetDesiredBytesPerPiece_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06000A20 RID: 2592
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedImageAlgorithm_SetEnableSMP_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/Disable SMP for threading.
		/// </summary>
		// Token: 0x06000A21 RID: 2593 RVA: 0x00015AF3 File Offset: 0x00013CF3
		public virtual void SetEnableSMP(bool _arg)
		{
			vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_SetEnableSMP_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06000A22 RID: 2594
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedImageAlgorithm_SetGlobalDefaultEnableSMP_21(byte enable);

		/// <summary>
		/// Global Disable SMP for all derived Imaging filters.
		/// </summary>
		// Token: 0x06000A23 RID: 2595 RVA: 0x00015B0B File Offset: 0x00013D0B
		public static void SetGlobalDefaultEnableSMP(bool enable)
		{
			vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_SetGlobalDefaultEnableSMP_21(enable ? (byte)1 : (byte)0);
		}

		// Token: 0x06000A24 RID: 2596
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedImageAlgorithm_SetMinimumPieceSize_22(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// The minimum piece size when volume is split for execution.
		/// By default, the minimum size is (16,1,1).
		/// </summary>
		// Token: 0x06000A25 RID: 2597 RVA: 0x00015B1D File Offset: 0x00013D1D
		public virtual void SetMinimumPieceSize(int _arg1, int _arg2, int _arg3)
		{
			vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_SetMinimumPieceSize_22(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06000A26 RID: 2598
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedImageAlgorithm_SetMinimumPieceSize_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The minimum piece size when volume is split for execution.
		/// By default, the minimum size is (16,1,1).
		/// </summary>
		// Token: 0x06000A27 RID: 2599 RVA: 0x00015B2F File Offset: 0x00013D2F
		public virtual void SetMinimumPieceSize(IntPtr _arg)
		{
			vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_SetMinimumPieceSize_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06000A28 RID: 2600
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedImageAlgorithm_SetNumberOfThreads_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the number of threads to create when rendering.
		/// This is ignored if EnableSMP is On.
		/// </summary>
		// Token: 0x06000A29 RID: 2601 RVA: 0x00015B3F File Offset: 0x00013D3F
		public virtual void SetNumberOfThreads(int _arg)
		{
			vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_SetNumberOfThreads_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06000A2A RID: 2602
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedImageAlgorithm_SetSplitMode_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the method used to divide the volume into pieces.
		/// Slab mode splits the volume along the Z direction first,
		/// Beam mode splits evenly along the Z and Y directions, and
		/// Block mode splits evenly along all three directions.
		/// Most filters use Slab mode as the default.
		/// </summary>
		// Token: 0x06000A2B RID: 2603 RVA: 0x00015B4F File Offset: 0x00013D4F
		public virtual void SetSplitMode(int _arg)
		{
			vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_SetSplitMode_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06000A2C RID: 2604
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedImageAlgorithm_SetSplitModeToBeam_26(HandleRef pThis);

		/// <summary>
		/// Set the method used to divide the volume into pieces.
		/// Slab mode splits the volume along the Z direction first,
		/// Beam mode splits evenly along the Z and Y directions, and
		/// Block mode splits evenly along all three directions.
		/// Most filters use Slab mode as the default.
		/// </summary>
		// Token: 0x06000A2D RID: 2605 RVA: 0x00015B5F File Offset: 0x00013D5F
		public void SetSplitModeToBeam()
		{
			vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_SetSplitModeToBeam_26(base.GetCppThis());
		}

		// Token: 0x06000A2E RID: 2606
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedImageAlgorithm_SetSplitModeToBlock_27(HandleRef pThis);

		/// <summary>
		/// Set the method used to divide the volume into pieces.
		/// Slab mode splits the volume along the Z direction first,
		/// Beam mode splits evenly along the Z and Y directions, and
		/// Block mode splits evenly along all three directions.
		/// Most filters use Slab mode as the default.
		/// </summary>
		// Token: 0x06000A2F RID: 2607 RVA: 0x00015B6E File Offset: 0x00013D6E
		public void SetSplitModeToBlock()
		{
			vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_SetSplitModeToBlock_27(base.GetCppThis());
		}

		// Token: 0x06000A30 RID: 2608
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedImageAlgorithm_SetSplitModeToSlab_28(HandleRef pThis);

		/// <summary>
		/// Set the method used to divide the volume into pieces.
		/// Slab mode splits the volume along the Z direction first,
		/// Beam mode splits evenly along the Z and Y directions, and
		/// Block mode splits evenly along all three directions.
		/// Most filters use Slab mode as the default.
		/// </summary>
		// Token: 0x06000A31 RID: 2609 RVA: 0x00015B7D File Offset: 0x00013D7D
		public void SetSplitModeToSlab()
		{
			vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_SetSplitModeToSlab_28(base.GetCppThis());
		}

		// Token: 0x06000A32 RID: 2610
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreadedImageAlgorithm_SplitExtent_29(HandleRef pThis, IntPtr splitExt, IntPtr startExt, int num, int total);

		/// <summary>
		/// Putting this here until I merge graphics and imaging streaming.
		/// </summary>
		// Token: 0x06000A33 RID: 2611 RVA: 0x00015B8C File Offset: 0x00013D8C
		public virtual int SplitExtent(IntPtr splitExt, IntPtr startExt, int num, int total)
		{
			return vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_SplitExtent_29(base.GetCppThis(), splitExt, startExt, num, total);
		}

		// Token: 0x06000A34 RID: 2612
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedImageAlgorithm_ThreadedExecute_30(HandleRef pThis, HandleRef inData, HandleRef outData, IntPtr extent, int threadId);

		/// <summary>
		/// If the subclass does not define an Execute method, then the task
		/// will be broken up, multiple threads will be spawned, and each thread
		/// will call this method. It is public so that the thread functions
		/// can call this method.
		/// </summary>
		// Token: 0x06000A35 RID: 2613 RVA: 0x00015BB0 File Offset: 0x00013DB0
		public virtual void ThreadedExecute(vtkImageData inData, vtkImageData outData, IntPtr extent, int threadId)
		{
			vtkThreadedImageAlgorithm.vtkThreadedImageAlgorithm_ThreadedExecute_30(base.GetCppThis(), (inData == null) ? default(HandleRef) : inData.GetCppThis(), (outData == null) ? default(HandleRef) : outData.GetCppThis(), extent, threadId);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003A3 RID: 931
		public new const string MRFullTypeName = "Kitware.VTK.vtkThreadedImageAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003A4 RID: 932
		public new static readonly string MRClassNameKey = "class vtkThreadedImageAlgorithm";
	}
}
