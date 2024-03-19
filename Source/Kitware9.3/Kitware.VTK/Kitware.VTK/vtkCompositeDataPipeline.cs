using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositeDataPipeline
	/// </summary>
	/// <remarks>
	///    Executive supporting composite datasets.
	///
	/// vtkCompositeDataPipeline is an executive that supports the processing of
	/// composite dataset. It supports algorithms that are aware of composite
	/// dataset as well as those that are not. Type checking is performed at run
	/// time. Algorithms that are not composite dataset-aware have to support
	/// all dataset types contained in the composite dataset. The pipeline
	/// execution can be summarized as follows:
	///
	/// * REQUEST_INFORMATION: The producers have to provide information about
	/// the contents of the composite dataset in this pass.
	/// Sources that can produce more than one piece (note that a piece is
	/// different than a block; each piece consists of 0 or more blocks) should
	/// set CAN_HANDLE_PIECE_REQUEST.
	///
	/// * REQUEST_UPDATE_EXTENT: This pass is identical to the one implemented
	/// in vtkStreamingDemandDrivenPipeline
	///
	/// * REQUEST_DATA: This is where the algorithms execute. If the
	/// vtkCompositeDataPipeline is assigned to a simple filter,
	/// it will invoke the  vtkStreamingDemandDrivenPipeline passes in a loop,
	/// passing a different block each time and will collect the results in a
	/// composite dataset.
	/// </remarks>
	/// <seealso>
	///
	///  vtkCompositeDataSet
	/// </seealso>
	// Token: 0x020009CA RID: 2506
	public class vtkCompositeDataPipeline : vtkStreamingDemandDrivenPipeline
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A280 RID: 107136 RVA: 0x0024408B File Offset: 0x0024228B
		static vtkCompositeDataPipeline()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeDataPipeline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataPipeline"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A281 RID: 107137 RVA: 0x002440B3 File Offset: 0x002422B3
		public vtkCompositeDataPipeline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A282 RID: 107138
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataPipeline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A283 RID: 107139 RVA: 0x002440C4 File Offset: 0x002422C4
		public new static vtkCompositeDataPipeline New()
		{
			vtkCompositeDataPipeline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataPipeline.vtkCompositeDataPipeline_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A284 RID: 107140 RVA: 0x00244118 File Offset: 0x00242318
		public vtkCompositeDataPipeline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositeDataPipeline.vtkCompositeDataPipeline_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A285 RID: 107141 RVA: 0x0024415C File Offset: 0x0024235C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A286 RID: 107142
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataPipeline_BLOCK_AMOUNT_OF_DETAIL_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// BLOCK_AMOUNT_OF_DETAIL is a key placed in the information about a multi-block
		/// dataset that indicates how complex the block is.  It is intended to work with
		/// multi-resolution streaming code.  For example in a multi-resolution dataset of
		/// points, this key might store the number of points.
		/// *** THIS IS AN EXPERIMENTAL FEATURE. IT MAY CHANGE WITHOUT NOTICE ***
		/// </summary>
		// Token: 0x0601A287 RID: 107143 RVA: 0x00244168 File Offset: 0x00242368
		public static vtkInformationDoubleKey BLOCK_AMOUNT_OF_DETAIL()
		{
			vtkInformationDoubleKey vtkInformationDoubleKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataPipeline.vtkCompositeDataPipeline_BLOCK_AMOUNT_OF_DETAIL_01(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A288 RID: 107144
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataPipeline_COMPOSITE_DATA_META_DATA_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// COMPOSITE_DATA_META_DATA is a key placed in the output-port information by
		/// readers/sources producing composite datasets. This meta-data provides
		/// information about the structure of the composite dataset and things like
		/// data-bounds etc.
		/// *** THIS IS AN EXPERIMENTAL FEATURE. IT MAY CHANGE WITHOUT NOTICE ***
		/// </summary>
		// Token: 0x0601A289 RID: 107145 RVA: 0x002441D4 File Offset: 0x002423D4
		public static vtkInformationObjectBaseKey COMPOSITE_DATA_META_DATA()
		{
			vtkInformationObjectBaseKey vtkInformationObjectBaseKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataPipeline.vtkCompositeDataPipeline_COMPOSITE_DATA_META_DATA_02(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseKey = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseKey.Register(null);
				}
			}
			return vtkInformationObjectBaseKey;
		}

		// Token: 0x0601A28A RID: 107146
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataPipeline_GetCompositeOutputData_03(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the data object stored with the DATA_OBJECT() in the
		/// output port
		/// </summary>
		// Token: 0x0601A28B RID: 107147 RVA: 0x00244240 File Offset: 0x00242440
		public vtkDataObject GetCompositeOutputData(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataPipeline.vtkCompositeDataPipeline_GetCompositeOutputData_03(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A28C RID: 107148
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataPipeline_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A28D RID: 107149 RVA: 0x002442B0 File Offset: 0x002424B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeDataPipeline.vtkCompositeDataPipeline_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601A28E RID: 107150
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataPipeline_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A28F RID: 107151 RVA: 0x002442D0 File Offset: 0x002424D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeDataPipeline.vtkCompositeDataPipeline_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601A290 RID: 107152
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataPipeline_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A291 RID: 107153 RVA: 0x002442EC File Offset: 0x002424EC
		public override int IsA(string type)
		{
			return vtkCompositeDataPipeline.vtkCompositeDataPipeline_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601A292 RID: 107154
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataPipeline_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A293 RID: 107155 RVA: 0x0024430C File Offset: 0x0024250C
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeDataPipeline.vtkCompositeDataPipeline_IsTypeOf_07(type);
		}

		// Token: 0x0601A294 RID: 107156
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataPipeline_LOAD_REQUESTED_BLOCKS_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// An integer key that indicates to the source to load all requested
		/// blocks specified in UPDATE_COMPOSITE_INDICES.
		/// </summary>
		// Token: 0x0601A295 RID: 107157 RVA: 0x00244328 File Offset: 0x00242528
		public static vtkInformationIntegerKey LOAD_REQUESTED_BLOCKS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataPipeline.vtkCompositeDataPipeline_LOAD_REQUESTED_BLOCKS_08(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A296 RID: 107158
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataPipeline_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A297 RID: 107159 RVA: 0x00244394 File Offset: 0x00242594
		public new vtkCompositeDataPipeline NewInstance()
		{
			vtkCompositeDataPipeline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataPipeline.vtkCompositeDataPipeline_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A298 RID: 107160
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataPipeline_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A299 RID: 107161 RVA: 0x002443F0 File Offset: 0x002425F0
		public new static vtkCompositeDataPipeline SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeDataPipeline vtkCompositeDataPipeline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataPipeline.vtkCompositeDataPipeline_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataPipeline = (vtkCompositeDataPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataPipeline.Register(null);
				}
			}
			return vtkCompositeDataPipeline;
		}

		// Token: 0x0601A29A RID: 107162
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataPipeline_UPDATE_COMPOSITE_INDICES_12(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// UPDATE_COMPOSITE_INDICES is a key placed in the request to request a set of
		/// composite indices from a reader/source producing composite dataset.
		/// Typically, the reader publishes its structure using
		/// COMPOSITE_DATA_META_DATA() and then the sink requests blocks of interest
		/// using UPDATE_COMPOSITE_INDICES().
		/// Note that UPDATE_COMPOSITE_INDICES has to be sorted vector with increasing
		/// indices.
		/// *** THIS IS AN EXPERIMENTAL FEATURE. IT MAY CHANGE WITHOUT NOTICE ***
		/// </summary>
		// Token: 0x0601A29B RID: 107163 RVA: 0x00244470 File Offset: 0x00242670
		public static vtkInformationIntegerVectorKey UPDATE_COMPOSITE_INDICES()
		{
			vtkInformationIntegerVectorKey vtkInformationIntegerVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataPipeline.vtkCompositeDataPipeline_UPDATE_COMPOSITE_INDICES_12(ref mteStatus, ref maxValue, ref rawRefCount);
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
		// Token: 0x04001C61 RID: 7265
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataPipeline";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C62 RID: 7266
		public new static readonly string MRClassNameKey = "class vtkCompositeDataPipeline";
	}
}
