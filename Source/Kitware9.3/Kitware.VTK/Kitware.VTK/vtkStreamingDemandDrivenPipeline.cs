using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStreamingDemandDrivenPipeline
	/// </summary>
	/// <remarks>
	///    Executive supporting partial updates.
	///
	/// vtkStreamingDemandDrivenPipeline is an executive that supports
	/// updating only a portion of the data set in the pipeline.  This is
	/// the style of pipeline update that is provided by the old-style VTK
	/// 4.x pipeline.  Instead of always updating an entire data set, this
	/// executive supports asking for pieces or sub-extents.
	/// </remarks>
	// Token: 0x02000783 RID: 1923
	public class vtkStreamingDemandDrivenPipeline : vtkDemandDrivenPipeline
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013C1C RID: 80924 RVA: 0x001BE533 File Offset: 0x001BC733
		static vtkStreamingDemandDrivenPipeline()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStreamingDemandDrivenPipeline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreamingDemandDrivenPipeline"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013C1D RID: 80925 RVA: 0x001BE55B File Offset: 0x001BC75B
		public vtkStreamingDemandDrivenPipeline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013C1E RID: 80926
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C1F RID: 80927 RVA: 0x001BE56C File Offset: 0x001BC76C
		public new static vtkStreamingDemandDrivenPipeline New()
		{
			vtkStreamingDemandDrivenPipeline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamingDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C20 RID: 80928 RVA: 0x001BE5C0 File Offset: 0x001BC7C0
		public vtkStreamingDemandDrivenPipeline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013C21 RID: 80929 RVA: 0x001BE604 File Offset: 0x001BC804
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013C22 RID: 80930
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_BOUNDS_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// key to record the bounds of a dataset.
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C23 RID: 80931 RVA: 0x001BE610 File Offset: 0x001BC810
		public static vtkInformationDoubleVectorKey BOUNDS()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_BOUNDS_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		// Token: 0x06013C24 RID: 80932
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_COMBINED_UPDATE_EXTENT_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key for combining the update extents requested by all consumers,
		/// so that the final extent that is produced satisfies all consumers.
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C25 RID: 80933 RVA: 0x001BE67C File Offset: 0x001BC87C
		public static vtkInformationIntegerVectorKey COMBINED_UPDATE_EXTENT()
		{
			vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_COMBINED_UPDATE_EXTENT_02(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerVectorKey = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerVectorKey.Register(null);
				}
			}
			return vtkInformationIntegerVectorKey;
		}

		// Token: 0x06013C26 RID: 80934
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_CONTINUE_EXECUTING_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key for an algorithm to store in a request to tell this executive
		/// to keep executing it.
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C27 RID: 80935 RVA: 0x001BE6E8 File Offset: 0x001BC8E8
		public static vtkInformationIntegerKey CONTINUE_EXECUTING()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_CONTINUE_EXECUTING_03(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x06013C28 RID: 80936
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_EXACT_EXTENT_04(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key to specify the request for exact extent in pipeline information.
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C29 RID: 80937 RVA: 0x001BE754 File Offset: 0x001BC954
		public static vtkInformationIntegerKey EXACT_EXTENT()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_EXACT_EXTENT_04(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x06013C2A RID: 80938
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStreamingDemandDrivenPipeline_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C2B RID: 80939 RVA: 0x001BE7C0 File Offset: 0x001BC9C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06013C2C RID: 80940
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStreamingDemandDrivenPipeline_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C2D RID: 80941 RVA: 0x001BE7E0 File Offset: 0x001BC9E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06013C2E RID: 80942
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamingDemandDrivenPipeline_GetRequestExactExtent_07(HandleRef pThis, int port);

		/// <summary>
		/// This request flag indicates whether the requester can handle more
		/// data than requested for the given port.  Right now it is used in
		/// vtkImageData.  Image filters can return more data than requested.
		/// The consumer cannot handle this (i.e. DataSetToDataSetfilter)
		/// the image will crop itself.  This functionality used to be in
		/// ImageToStructuredPoints.
		/// </summary>
		// Token: 0x06013C2F RID: 80943 RVA: 0x001BE7FC File Offset: 0x001BC9FC
		public int GetRequestExactExtent(int port)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetRequestExactExtent_07(base.GetCppThis(), port);
		}

		// Token: 0x06013C30 RID: 80944
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamingDemandDrivenPipeline_GetUpdateExtent_08(HandleRef arg0, IntPtr extent);

		/// <summary>
		/// Get/Set the update extent for output ports that use 3D extents.
		/// </summary>
		// Token: 0x06013C31 RID: 80945 RVA: 0x001BE81C File Offset: 0x001BCA1C
		public static void GetUpdateExtent(vtkInformation arg0, IntPtr extent)
		{
			vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetUpdateExtent_08((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), extent);
		}

		// Token: 0x06013C32 RID: 80946
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_GetUpdateExtent_09(HandleRef arg0);

		/// <summary>
		/// Get/Set the update extent for output ports that use 3D extents.
		/// </summary>
		// Token: 0x06013C33 RID: 80947 RVA: 0x001BE848 File Offset: 0x001BCA48
		public static IntPtr GetUpdateExtent(vtkInformation arg0)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetUpdateExtent_09((arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06013C34 RID: 80948
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamingDemandDrivenPipeline_GetUpdateGhostLevel_10(HandleRef arg0);

		/// <summary>
		/// Set/Get the update piece, update number of pieces, and update
		/// number of ghost levels for an output port.  Similar to update
		/// extent in 3D.
		/// </summary>
		// Token: 0x06013C35 RID: 80949 RVA: 0x001BE878 File Offset: 0x001BCA78
		public static int GetUpdateGhostLevel(vtkInformation arg0)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetUpdateGhostLevel_10((arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06013C36 RID: 80950
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamingDemandDrivenPipeline_GetUpdateNumberOfPieces_11(HandleRef arg0);

		/// <summary>
		/// Set/Get the update piece, update number of pieces, and update
		/// number of ghost levels for an output port.  Similar to update
		/// extent in 3D.
		/// </summary>
		// Token: 0x06013C37 RID: 80951 RVA: 0x001BE8A8 File Offset: 0x001BCAA8
		public static int GetUpdateNumberOfPieces(vtkInformation arg0)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetUpdateNumberOfPieces_11((arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06013C38 RID: 80952
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamingDemandDrivenPipeline_GetUpdatePiece_12(HandleRef arg0);

		/// <summary>
		/// Set/Get the update piece, update number of pieces, and update
		/// number of ghost levels for an output port.  Similar to update
		/// extent in 3D.
		/// </summary>
		// Token: 0x06013C39 RID: 80953 RVA: 0x001BE8D8 File Offset: 0x001BCAD8
		public static int GetUpdatePiece(vtkInformation arg0)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetUpdatePiece_12((arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06013C3A RID: 80954
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamingDemandDrivenPipeline_GetWholeExtent_13(HandleRef arg0, IntPtr extent);

		/// <summary>
		/// Set/Get the whole extent of an output port.  The whole extent is
		/// meta data for structured data sets.  It gets set by the algorithm
		/// during the update information pass.
		/// </summary>
		// Token: 0x06013C3B RID: 80955 RVA: 0x001BE908 File Offset: 0x001BCB08
		public static void GetWholeExtent(vtkInformation arg0, IntPtr extent)
		{
			vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetWholeExtent_13((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), extent);
		}

		// Token: 0x06013C3C RID: 80956
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_GetWholeExtent_14(HandleRef arg0);

		/// <summary>
		/// Set/Get the whole extent of an output port.  The whole extent is
		/// meta data for structured data sets.  It gets set by the algorithm
		/// during the update information pass.
		/// </summary>
		// Token: 0x06013C3D RID: 80957 RVA: 0x001BE934 File Offset: 0x001BCB34
		public static int[] GetWholeExtent(vtkInformation arg0)
		{
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_GetWholeExtent_14((arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013C3E RID: 80958
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamingDemandDrivenPipeline_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C3F RID: 80959 RVA: 0x001BE990 File Offset: 0x001BCB90
		public override int IsA(string type)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06013C40 RID: 80960
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamingDemandDrivenPipeline_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C41 RID: 80961 RVA: 0x001BE9B0 File Offset: 0x001BCBB0
		public new static int IsTypeOf(string type)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_IsTypeOf_16(type);
		}

		// Token: 0x06013C42 RID: 80962
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_NO_PRIOR_TEMPORAL_ACCESS_17(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key to tell whether the data has all its time steps generated.
		/// It is typically used for in situ, where you want to be able to visualize
		/// a simulation while it is running. It effectively tells the downstream
		/// algorithms integrating over all the timesteps
		/// that the current set of available timesteps is not necessarily
		/// complete. As a result, they will produce a valid output for each requested timestep
		/// and keep some cache helping them to retrieve upcoming timesteps as they arrive.
		///
		/// @note One should check the actual value of this key. Possible values are listed
		/// in `NO_PRIOR_TEMPORAL_ACCESS_STATES`.
		/// </summary>
		// Token: 0x06013C43 RID: 80963 RVA: 0x001BE9CC File Offset: 0x001BCBCC
		public static vtkInformationIntegerKey NO_PRIOR_TEMPORAL_ACCESS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_NO_PRIOR_TEMPORAL_ACCESS_17(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x06013C44 RID: 80964
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C45 RID: 80965 RVA: 0x001BEA38 File Offset: 0x001BCC38
		public new vtkStreamingDemandDrivenPipeline NewInstance()
		{
			vtkStreamingDemandDrivenPipeline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamingDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013C46 RID: 80966
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamingDemandDrivenPipeline_PropagateTime_20(HandleRef pThis, int outputPort);

		/// <summary>
		/// Propagate time through the pipeline. this is a special pass
		/// only necessary if there is temporal meta data that must be updated
		/// </summary>
		// Token: 0x06013C47 RID: 80967 RVA: 0x001BEA94 File Offset: 0x001BCC94
		public int PropagateTime(int outputPort)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_PropagateTime_20(base.GetCppThis(), outputPort);
		}

		// Token: 0x06013C48 RID: 80968
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamingDemandDrivenPipeline_PropagateUpdateExtent_21(HandleRef pThis, int outputPort);

		/// <summary>
		/// Propagate the update request from the given output port back
		/// through the pipeline.  Should be called only when information is
		/// up to date.
		/// </summary>
		// Token: 0x06013C49 RID: 80969 RVA: 0x001BEAB4 File Offset: 0x001BCCB4
		public int PropagateUpdateExtent(int outputPort)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_PropagateUpdateExtent_21(base.GetCppThis(), outputPort);
		}

		// Token: 0x06013C4A RID: 80970
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_REQUEST_TIME_DEPENDENT_INFORMATION_22(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key defining a request to make sure the meta information is up to date.
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C4B RID: 80971 RVA: 0x001BEAD4 File Offset: 0x001BCCD4
		public static vtkInformationRequestKey REQUEST_TIME_DEPENDENT_INFORMATION()
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_REQUEST_TIME_DEPENDENT_INFORMATION_22(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationRequestKey = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationRequestKey.Register(null);
				}
			}
			return vtkInformationRequestKey;
		}

		// Token: 0x06013C4C RID: 80972
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_REQUEST_UPDATE_EXTENT_23(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key defining a request to propagate the update extent upstream.
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C4D RID: 80973 RVA: 0x001BEB40 File Offset: 0x001BCD40
		public static vtkInformationRequestKey REQUEST_UPDATE_EXTENT()
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_REQUEST_UPDATE_EXTENT_23(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationRequestKey = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationRequestKey.Register(null);
				}
			}
			return vtkInformationRequestKey;
		}

		// Token: 0x06013C4E RID: 80974
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_REQUEST_UPDATE_TIME_24(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key defining a request to propagate the update extent upstream.
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C4F RID: 80975 RVA: 0x001BEBAC File Offset: 0x001BCDAC
		public static vtkInformationRequestKey REQUEST_UPDATE_TIME()
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_REQUEST_UPDATE_TIME_24(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationRequestKey = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationRequestKey.Register(null);
				}
			}
			return vtkInformationRequestKey;
		}

		// Token: 0x06013C50 RID: 80976
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C51 RID: 80977 RVA: 0x001BEC18 File Offset: 0x001BCE18
		public new static vtkStreamingDemandDrivenPipeline SafeDownCast(vtkObjectBase o)
		{
			vtkStreamingDemandDrivenPipeline vtkStreamingDemandDrivenPipeline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStreamingDemandDrivenPipeline = (vtkStreamingDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStreamingDemandDrivenPipeline.Register(null);
				}
			}
			return vtkStreamingDemandDrivenPipeline;
		}

		// Token: 0x06013C52 RID: 80978
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetRequestExactExtent_26(HandleRef pThis, int port, int flag);

		/// <summary>
		/// This request flag indicates whether the requester can handle more
		/// data than requested for the given port.  Right now it is used in
		/// vtkImageData.  Image filters can return more data than requested.
		/// The consumer cannot handle this (i.e. DataSetToDataSetfilter)
		/// the image will crop itself.  This functionality used to be in
		/// ImageToStructuredPoints.
		/// </summary>
		// Token: 0x06013C53 RID: 80979 RVA: 0x001BEC98 File Offset: 0x001BCE98
		public int SetRequestExactExtent(int port, int flag)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetRequestExactExtent_26(base.GetCppThis(), port, flag);
		}

		// Token: 0x06013C54 RID: 80980
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamingDemandDrivenPipeline_SetWholeExtent_27(HandleRef arg0, IntPtr extent);

		/// <summary>
		/// Set/Get the whole extent of an output port.  The whole extent is
		/// meta data for structured data sets.  It gets set by the algorithm
		/// during the update information pass.
		/// </summary>
		// Token: 0x06013C55 RID: 80981 RVA: 0x001BECBC File Offset: 0x001BCEBC
		public static int SetWholeExtent(vtkInformation arg0, IntPtr extent)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_SetWholeExtent_27((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), extent);
		}

		// Token: 0x06013C56 RID: 80982
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_TIME_DEPENDENT_INFORMATION_28(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Whether there are time dependent meta information
		/// if there is, the pipeline will perform two extra passes
		/// to gather the time dependent information
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C57 RID: 80983 RVA: 0x001BECEC File Offset: 0x001BCEEC
		public static vtkInformationIntegerKey TIME_DEPENDENT_INFORMATION()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_TIME_DEPENDENT_INFORMATION_28(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x06013C58 RID: 80984
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_TIME_RANGE_29(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key to store available time range for continuous sources.
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C59 RID: 80985 RVA: 0x001BED58 File Offset: 0x001BCF58
		public static vtkInformationDoubleVectorKey TIME_RANGE()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_TIME_RANGE_29(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		// Token: 0x06013C5A RID: 80986
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_TIME_STEPS_30(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key to store available time steps.
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C5B RID: 80987 RVA: 0x001BEDC4 File Offset: 0x001BCFC4
		public static vtkInformationDoubleVectorKey TIME_STEPS()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_TIME_STEPS_30(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		// Token: 0x06013C5C RID: 80988
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UNRESTRICTED_UPDATE_EXTENT_31(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This is set if the update extent is not restricted to the
		/// whole extent, for sources that can generate an extent of
		/// any requested size.
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C5D RID: 80989 RVA: 0x001BEE30 File Offset: 0x001BD030
		public static vtkInformationIntegerKey UNRESTRICTED_UPDATE_EXTENT()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UNRESTRICTED_UPDATE_EXTENT_31(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x06013C5E RID: 80990
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_EXTENT_32(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C5F RID: 80991 RVA: 0x001BEE9C File Offset: 0x001BD09C
		public static vtkInformationIntegerVectorKey UPDATE_EXTENT()
		{
			vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UPDATE_EXTENT_32(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerVectorKey = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerVectorKey.Register(null);
				}
			}
			return vtkInformationIntegerVectorKey;
		}

		// Token: 0x06013C60 RID: 80992
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_EXTENT_INITIALIZED_33(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Keys to store an update request in pipeline information.
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C61 RID: 80993 RVA: 0x001BEF08 File Offset: 0x001BD108
		public static vtkInformationIntegerKey UPDATE_EXTENT_INITIALIZED()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UPDATE_EXTENT_INITIALIZED_33(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x06013C62 RID: 80994
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_NUMBER_OF_GHOST_LEVELS_34(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C63 RID: 80995 RVA: 0x001BEF74 File Offset: 0x001BD174
		public static vtkInformationIntegerKey UPDATE_NUMBER_OF_GHOST_LEVELS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UPDATE_NUMBER_OF_GHOST_LEVELS_34(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x06013C64 RID: 80996
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_NUMBER_OF_PIECES_35(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C65 RID: 80997 RVA: 0x001BEFE0 File Offset: 0x001BD1E0
		public static vtkInformationIntegerKey UPDATE_NUMBER_OF_PIECES()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UPDATE_NUMBER_OF_PIECES_35(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x06013C66 RID: 80998
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_PIECE_NUMBER_36(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C67 RID: 80999 RVA: 0x001BF04C File Offset: 0x001BD24C
		public static vtkInformationIntegerKey UPDATE_PIECE_NUMBER()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UPDATE_PIECE_NUMBER_36(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x06013C68 RID: 81000
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_UPDATE_TIME_STEP_37(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Update time steps requested by the pipeline.
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C69 RID: 81001 RVA: 0x001BF0B8 File Offset: 0x001BD2B8
		public static vtkInformationDoubleKey UPDATE_TIME_STEP()
		{
			vtkInformationDoubleKey vtkInformationDoubleKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UPDATE_TIME_STEP_37(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleKey = (vtkInformationDoubleKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleKey.Register(null);
				}
			}
			return vtkInformationDoubleKey;
		}

		// Token: 0x06013C6A RID: 81002
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamingDemandDrivenPipeline_Update_38(HandleRef pThis);

		/// <summary>
		/// Bring the outputs up-to-date.
		/// </summary>
		// Token: 0x06013C6B RID: 81003 RVA: 0x001BF124 File Offset: 0x001BD324
		public override int Update()
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_Update_38(base.GetCppThis());
		}

		// Token: 0x06013C6C RID: 81004
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamingDemandDrivenPipeline_Update_39(HandleRef pThis, int port);

		/// <summary>
		/// Bring the outputs up-to-date.
		/// </summary>
		// Token: 0x06013C6D RID: 81005 RVA: 0x001BF144 File Offset: 0x001BD344
		public override int Update(int port)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_Update_39(base.GetCppThis(), port);
		}

		// Token: 0x06013C6E RID: 81006
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamingDemandDrivenPipeline_Update_40(HandleRef pThis, int port, HandleRef requests);

		/// <summary>
		/// This method enables the passing of data requests to the algorithm
		/// to be used during execution (in addition to bringing a particular
		/// port up-to-date). The requests argument should contain an information
		/// object for each port that requests need to be passed. For each
		/// of those, the pipeline will copy all keys to the output information
		/// before execution. This is equivalent to:
		/// \verbatim
		/// executive-&gt;UpdateInformation();
		/// for (int i=0; i&lt;executive-&gt;GetNumberOfOutputPorts(); i++)
		/// {
		/// vtkInformation* portRequests = requests-&gt;GetInformationObject(i);
		/// if (portRequests)
		/// {
		/// executive-&gt;GetOutputInformation(i)-&gt;Append(portRequests);
		/// }
		/// }
		/// executive-&gt;Update();
		/// \endverbatim
		/// Available requests include UPDATE_PIECE_NUMBER(), UPDATE_NUMBER_OF_PIECES()
		/// UPDATE_EXTENT() etc etc.
		/// </summary>
		// Token: 0x06013C6F RID: 81007 RVA: 0x001BF164 File Offset: 0x001BD364
		public virtual int Update(int port, vtkInformationVector requests)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_Update_40(base.GetCppThis(), port, (requests == null) ? default(HandleRef) : requests.GetCppThis());
		}

		// Token: 0x06013C70 RID: 81008
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamingDemandDrivenPipeline_UpdateTimeDependentInformation_41(HandleRef pThis, int outputPort);

		/// <summary>
		/// Propagate time through the pipeline. this is a special pass
		/// only necessary if there is temporal meta data that must be updated
		/// </summary>
		// Token: 0x06013C71 RID: 81009 RVA: 0x001BF19C File Offset: 0x001BD39C
		public int UpdateTimeDependentInformation(int outputPort)
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UpdateTimeDependentInformation_41(base.GetCppThis(), outputPort);
		}

		// Token: 0x06013C72 RID: 81010
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamingDemandDrivenPipeline_UpdateWholeExtent_42(HandleRef pThis);

		/// <summary>
		/// Bring the outputs up-to-date.
		/// </summary>
		// Token: 0x06013C73 RID: 81011 RVA: 0x001BF1BC File Offset: 0x001BD3BC
		public virtual int UpdateWholeExtent()
		{
			return vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_UpdateWholeExtent_42(base.GetCppThis());
		}

		// Token: 0x06013C74 RID: 81012
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamingDemandDrivenPipeline_WHOLE_EXTENT_43(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key to store the whole extent provided in pipeline information.
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C75 RID: 81013 RVA: 0x001BF1DC File Offset: 0x001BD3DC
		public static vtkInformationIntegerVectorKey WHOLE_EXTENT()
		{
			vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamingDemandDrivenPipeline.vtkStreamingDemandDrivenPipeline_WHOLE_EXTENT_43(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerVectorKey = (vtkInformationIntegerVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerVectorKey.Register(null);
				}
			}
			return vtkInformationIntegerVectorKey;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016B7 RID: 5815
		public new const string MRFullTypeName = "Kitware.VTK.vtkStreamingDemandDrivenPipeline";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016B8 RID: 5816
		public new static readonly string MRClassNameKey = "class vtkStreamingDemandDrivenPipeline";

		/// <summary>
		/// States that the information key `NO_PRIOR_TEMPORAL_ACCESS` can have.
		/// </summary>
		// Token: 0x02000784 RID: 1924
		public enum NO_PRIOR_TEMPORAL_ACCESS_STATES
		{
			/// <summary>enum member</summary>
			// Token: 0x040016BA RID: 5818
			NO_PRIOR_TEMPORAL_ACCESS_CONTINUE = 1,
			/// <summary>enum member</summary>
			// Token: 0x040016BB RID: 5819
			NO_PRIOR_TEMPORAL_ACCESS_RESET
		}
	}
}
