using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDemandDrivenPipeline
	/// </summary>
	/// <remarks>
	///    Executive supporting on-demand execution.
	///
	/// vtkDemandDrivenPipeline is an executive that will execute an
	/// algorithm only when its outputs are out-of-date with respect to its
	/// inputs.
	/// </remarks>
	// Token: 0x02000782 RID: 1922
	public class vtkDemandDrivenPipeline : vtkExecutive
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013BEA RID: 80874 RVA: 0x001BDEEE File Offset: 0x001BC0EE
		static vtkDemandDrivenPipeline()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDemandDrivenPipeline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDemandDrivenPipeline"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013BEB RID: 80875 RVA: 0x001BDF16 File Offset: 0x001BC116
		public vtkDemandDrivenPipeline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013BEC RID: 80876
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDemandDrivenPipeline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013BED RID: 80877 RVA: 0x001BDF24 File Offset: 0x001BC124
		public new static vtkDemandDrivenPipeline New()
		{
			vtkDemandDrivenPipeline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013BEE RID: 80878 RVA: 0x001BDF78 File Offset: 0x001BC178
		public vtkDemandDrivenPipeline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013BEF RID: 80879 RVA: 0x001BDFBC File Offset: 0x001BC1BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013BF0 RID: 80880
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDemandDrivenPipeline_DATA_NOT_GENERATED_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key to store a mark for an output that will not be generated.
		/// Algorithms use this to tell the executive that they will not
		/// generate certain outputs for a REQUEST_DATA.
		/// @ingroup InformationKeys
		/// </summary>
		// Token: 0x06013BF1 RID: 80881 RVA: 0x001BDFC8 File Offset: 0x001BC1C8
		public static vtkInformationIntegerKey DATA_NOT_GENERATED()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_DATA_NOT_GENERATED_01(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013BF2 RID: 80882
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDemandDrivenPipeline_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013BF3 RID: 80883 RVA: 0x001BE034 File Offset: 0x001BC234
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06013BF4 RID: 80884
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDemandDrivenPipeline_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013BF5 RID: 80885 RVA: 0x001BE054 File Offset: 0x001BC254
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06013BF6 RID: 80886
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDemandDrivenPipeline_GetPipelineMTime_04(HandleRef pThis);

		/// <summary>
		/// Get the PipelineMTime for this exective.
		/// </summary>
		// Token: 0x06013BF7 RID: 80887 RVA: 0x001BE070 File Offset: 0x001BC270
		public virtual ulong GetPipelineMTime()
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_GetPipelineMTime_04(base.GetCppThis());
		}

		// Token: 0x06013BF8 RID: 80888
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDemandDrivenPipeline_GetReleaseDataFlag_05(HandleRef pThis, int port);

		/// <summary>
		/// Get whether the given output port releases data when it is consumed.
		/// </summary>
		// Token: 0x06013BF9 RID: 80889 RVA: 0x001BE090 File Offset: 0x001BC290
		public virtual int GetReleaseDataFlag(int port)
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_GetReleaseDataFlag_05(base.GetCppThis(), port);
		}

		// Token: 0x06013BFA RID: 80890
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDemandDrivenPipeline_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013BFB RID: 80891 RVA: 0x001BE0B0 File Offset: 0x001BC2B0
		public override int IsA(string type)
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06013BFC RID: 80892
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDemandDrivenPipeline_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013BFD RID: 80893 RVA: 0x001BE0D0 File Offset: 0x001BC2D0
		public new static int IsTypeOf(string type)
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_IsTypeOf_07(type);
		}

		// Token: 0x06013BFE RID: 80894
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDemandDrivenPipeline_NewDataObject_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create (New) and return a data object of the given type.
		/// This is here for backwards compatibility. Use
		/// vtkDataObjectTypes::NewDataObject() instead.
		/// </summary>
		// Token: 0x06013BFF RID: 80895 RVA: 0x001BE0EC File Offset: 0x001BC2EC
		public static vtkDataObject NewDataObject(string type)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_NewDataObject_09(type, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06013C00 RID: 80896
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDemandDrivenPipeline_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C01 RID: 80897 RVA: 0x001BE158 File Offset: 0x001BC358
		public new vtkDemandDrivenPipeline NewInstance()
		{
			vtkDemandDrivenPipeline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013C02 RID: 80898
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDemandDrivenPipeline_RELEASE_DATA_11(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key to specify in pipeline information the request that data be
		/// released after it is used.
		/// @ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C03 RID: 80899 RVA: 0x001BE1B4 File Offset: 0x001BC3B4
		public static vtkInformationIntegerKey RELEASE_DATA()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_RELEASE_DATA_11(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013C04 RID: 80900
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDemandDrivenPipeline_REQUEST_DATA_12(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key defining a request to make sure the output data are up to date.
		/// @ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C05 RID: 80901 RVA: 0x001BE220 File Offset: 0x001BC420
		public static vtkInformationRequestKey REQUEST_DATA()
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_REQUEST_DATA_12(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013C06 RID: 80902
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDemandDrivenPipeline_REQUEST_DATA_NOT_GENERATED_13(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key defining a request to mark outputs that will NOT be generated
		/// during a REQUEST_DATA.
		/// @ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C07 RID: 80903 RVA: 0x001BE28C File Offset: 0x001BC48C
		public static vtkInformationRequestKey REQUEST_DATA_NOT_GENERATED()
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_REQUEST_DATA_NOT_GENERATED_13(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013C08 RID: 80904
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDemandDrivenPipeline_REQUEST_DATA_OBJECT_14(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key defining a request to make sure the output data objects exist.
		/// @ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C09 RID: 80905 RVA: 0x001BE2F8 File Offset: 0x001BC4F8
		public static vtkInformationRequestKey REQUEST_DATA_OBJECT()
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_REQUEST_DATA_OBJECT_14(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013C0A RID: 80906
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDemandDrivenPipeline_REQUEST_INFORMATION_15(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key defining a request to make sure the output information is up to date.
		/// @ingroup InformationKeys
		/// </summary>
		// Token: 0x06013C0B RID: 80907 RVA: 0x001BE364 File Offset: 0x001BC564
		public static vtkInformationRequestKey REQUEST_INFORMATION()
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_REQUEST_INFORMATION_15(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013C0C RID: 80908
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDemandDrivenPipeline_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C0D RID: 80909 RVA: 0x001BE3D0 File Offset: 0x001BC5D0
		public new static vtkDemandDrivenPipeline SafeDownCast(vtkObjectBase o)
		{
			vtkDemandDrivenPipeline vtkDemandDrivenPipeline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDemandDrivenPipeline = (vtkDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDemandDrivenPipeline.Register(null);
				}
			}
			return vtkDemandDrivenPipeline;
		}

		// Token: 0x06013C0E RID: 80910
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDemandDrivenPipeline_SetReleaseDataFlag_17(HandleRef pThis, int port, int n);

		/// <summary>
		/// Set whether the given output port releases data when it is
		/// consumed.  Returns 1 if the value changes and 0 otherwise.
		/// </summary>
		// Token: 0x06013C0F RID: 80911 RVA: 0x001BE450 File Offset: 0x001BC650
		public virtual int SetReleaseDataFlag(int port, int n)
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_SetReleaseDataFlag_17(base.GetCppThis(), port, n);
		}

		// Token: 0x06013C10 RID: 80912
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDemandDrivenPipeline_Update_18(HandleRef pThis);

		/// <summary>
		/// Bring the algorithm's outputs up-to-date.  Returns 1 for success
		/// and 0 for failure.
		/// </summary>
		// Token: 0x06013C11 RID: 80913 RVA: 0x001BE474 File Offset: 0x001BC674
		public override int Update()
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_Update_18(base.GetCppThis());
		}

		// Token: 0x06013C12 RID: 80914
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDemandDrivenPipeline_Update_19(HandleRef pThis, int port);

		/// <summary>
		/// Bring the algorithm's outputs up-to-date.  Returns 1 for success
		/// and 0 for failure.
		/// </summary>
		// Token: 0x06013C13 RID: 80915 RVA: 0x001BE494 File Offset: 0x001BC694
		public override int Update(int port)
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_Update_19(base.GetCppThis(), port);
		}

		// Token: 0x06013C14 RID: 80916
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDemandDrivenPipeline_UpdateData_20(HandleRef pThis, int outputPort);

		/// <summary>
		/// Bring the output data up to date.  This should be called only
		/// when information is up to date.  Use the Update method if it is
		/// not known that the information is up to date.
		/// </summary>
		// Token: 0x06013C15 RID: 80917 RVA: 0x001BE4B4 File Offset: 0x001BC6B4
		public virtual int UpdateData(int outputPort)
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_UpdateData_20(base.GetCppThis(), outputPort);
		}

		// Token: 0x06013C16 RID: 80918
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDemandDrivenPipeline_UpdateDataObject_21(HandleRef pThis);

		/// <summary>
		/// Bring the output data object's existence up to date.  This does
		/// not actually produce data, but does create the data object that
		/// will store data produced during the UpdateData step.
		/// </summary>
		// Token: 0x06013C17 RID: 80919 RVA: 0x001BE4D4 File Offset: 0x001BC6D4
		public virtual int UpdateDataObject()
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_UpdateDataObject_21(base.GetCppThis());
		}

		// Token: 0x06013C18 RID: 80920
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDemandDrivenPipeline_UpdateInformation_22(HandleRef pThis);

		/// <summary>
		/// Bring the output information up to date.
		/// </summary>
		// Token: 0x06013C19 RID: 80921 RVA: 0x001BE4F4 File Offset: 0x001BC6F4
		public override int UpdateInformation()
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_UpdateInformation_22(base.GetCppThis());
		}

		// Token: 0x06013C1A RID: 80922
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDemandDrivenPipeline_UpdatePipelineMTime_23(HandleRef pThis);

		/// <summary>
		/// Bring the PipelineMTime up to date.
		/// </summary>
		// Token: 0x06013C1B RID: 80923 RVA: 0x001BE514 File Offset: 0x001BC714
		public virtual int UpdatePipelineMTime()
		{
			return vtkDemandDrivenPipeline.vtkDemandDrivenPipeline_UpdatePipelineMTime_23(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016B5 RID: 5813
		public new const string MRFullTypeName = "Kitware.VTK.vtkDemandDrivenPipeline";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016B6 RID: 5814
		public new static readonly string MRClassNameKey = "class vtkDemandDrivenPipeline";
	}
}
