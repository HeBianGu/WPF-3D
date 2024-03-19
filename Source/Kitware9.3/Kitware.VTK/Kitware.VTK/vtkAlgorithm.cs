using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for all sources, filters, and sinks in VTK.
	///
	/// vtkAlgorithm is the superclass for all sources, filters, and sinks
	/// in VTK.  It defines a generalized interface for executing data
	/// processing algorithms.  Pipeline connections are associated with
	/// input and output ports that are independent of the type of data
	/// passing through the connections.
	///
	/// Instances may be used independently or within pipelines with a
	/// variety of architectures and update mechanisms.  Pipelines are
	/// controlled by instances of vtkExecutive.  Every vtkAlgorithm
	/// instance has an associated vtkExecutive when it is used in a
	/// pipeline.  The executive is responsible for data flow.
	/// </remarks>
	// Token: 0x0200001D RID: 29
	public class vtkAlgorithm : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060003A9 RID: 937 RVA: 0x0000C58A File Offset: 0x0000A78A
		static vtkAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060003AA RID: 938 RVA: 0x0000C5B2 File Offset: 0x0000A7B2
		public vtkAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060003AB RID: 939
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060003AC RID: 940 RVA: 0x0000C5C0 File Offset: 0x0000A7C0
		public new static vtkAlgorithm New()
		{
			vtkAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060003AD RID: 941 RVA: 0x0000C614 File Offset: 0x0000A814
		public vtkAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAlgorithm.vtkAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060003AE RID: 942 RVA: 0x0000C658 File Offset: 0x0000A858
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060003AF RID: 943
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_ABORTED_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x060003B0 RID: 944 RVA: 0x0000C664 File Offset: 0x0000A864
		public static vtkInformationIntegerKey ABORTED()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_ABORTED_01(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060003B1 RID: 945
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_AbortExecuteOff_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the AbortExecute flag for the process object. Process objects
		/// may handle premature termination of execution in different ways.
		/// </summary>
		// Token: 0x060003B2 RID: 946 RVA: 0x0000C6CD File Offset: 0x0000A8CD
		public virtual void AbortExecuteOff()
		{
			vtkAlgorithm.vtkAlgorithm_AbortExecuteOff_02(base.GetCppThis());
		}

		// Token: 0x060003B3 RID: 947
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_AbortExecuteOn_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the AbortExecute flag for the process object. Process objects
		/// may handle premature termination of execution in different ways.
		/// </summary>
		// Token: 0x060003B4 RID: 948 RVA: 0x0000C6DC File Offset: 0x0000A8DC
		public virtual void AbortExecuteOn()
		{
			vtkAlgorithm.vtkAlgorithm_AbortExecuteOn_03(base.GetCppThis());
		}

		// Token: 0x060003B5 RID: 949
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_AddInputConnection_04(HandleRef pThis, int port, HandleRef input);

		/// <summary>
		/// Add a connection to the given input port index.  See
		/// SetInputConnection() for details on input connections.  This
		/// method is the complement to RemoveInputConnection() in that it
		/// adds only the connection specified without affecting other
		/// connections.  Typical usage is
		///
		/// filter2-&gt;AddInputConnection(0, filter1-&gt;GetOutputPort(0)).
		/// </summary>
		// Token: 0x060003B6 RID: 950 RVA: 0x0000C6EC File Offset: 0x0000A8EC
		public virtual void AddInputConnection(int port, vtkAlgorithmOutput input)
		{
			vtkAlgorithm.vtkAlgorithm_AddInputConnection_04(base.GetCppThis(), port, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x060003B7 RID: 951
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_AddInputConnection_05(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Add a connection to the given input port index.  See
		/// SetInputConnection() for details on input connections.  This
		/// method is the complement to RemoveInputConnection() in that it
		/// adds only the connection specified without affecting other
		/// connections.  Typical usage is
		///
		/// filter2-&gt;AddInputConnection(0, filter1-&gt;GetOutputPort(0)).
		/// </summary>
		// Token: 0x060003B8 RID: 952 RVA: 0x0000C71C File Offset: 0x0000A91C
		public virtual void AddInputConnection(vtkAlgorithmOutput input)
		{
			vtkAlgorithm.vtkAlgorithm_AddInputConnection_05(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x060003B9 RID: 953
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_AddInputDataObject_06(HandleRef pThis, int port, HandleRef data);

		/// <summary>
		/// Add the data-object as an input to this given port. This will add a new
		/// input connection on the specified port without affecting any existing
		/// connections on the same input port.
		/// </summary>
		// Token: 0x060003BA RID: 954 RVA: 0x0000C74C File Offset: 0x0000A94C
		public virtual void AddInputDataObject(int port, vtkDataObject data)
		{
			vtkAlgorithm.vtkAlgorithm_AddInputDataObject_06(base.GetCppThis(), port, (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x060003BB RID: 955
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_AddInputDataObject_07(HandleRef pThis, HandleRef data);

		/// <summary>
		/// Add the data-object as an input to this given port. This will add a new
		/// input connection on the specified port without affecting any existing
		/// connections on the same input port.
		/// </summary>
		// Token: 0x060003BC RID: 956 RVA: 0x0000C77C File Offset: 0x0000A97C
		public virtual void AddInputDataObject(vtkDataObject data)
		{
			vtkAlgorithm.vtkAlgorithm_AddInputDataObject_07(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x060003BD RID: 957
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_CAN_HANDLE_PIECE_REQUEST_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key that tells the pipeline that a particular algorithm
		/// can or cannot handle piece request. If a filter cannot handle
		/// piece requests and is asked for a piece, the executive will
		/// flag an error. If a structured data source cannot handle piece
		/// requests but can produce sub-extents (CAN_PRODUCE_SUB_EXTENT),
		/// the executive will use an extent translator to split the extent
		/// into pieces. Otherwise, if a source cannot handle piece requests,
		/// the executive will ask for the whole data for piece 0 and not
		/// execute the source for other pieces.
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x060003BE RID: 958 RVA: 0x0000C7AC File Offset: 0x0000A9AC
		public static vtkInformationIntegerKey CAN_HANDLE_PIECE_REQUEST()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_CAN_HANDLE_PIECE_REQUEST_08(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060003BF RID: 959
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_CAN_PRODUCE_SUB_EXTENT_09(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This key tells the executive that a particular output port
		/// is capable of producing an arbitrary subextent of the whole
		/// extent. Many image sources and readers fall into this category
		/// but some such as the legacy structured data readers cannot
		/// support this feature.
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x060003C0 RID: 960 RVA: 0x0000C818 File Offset: 0x0000AA18
		public static vtkInformationIntegerKey CAN_PRODUCE_SUB_EXTENT()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_CAN_PRODUCE_SUB_EXTENT_09(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060003C1 RID: 961
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAlgorithm_CheckAbort_10(HandleRef pThis);

		/// <summary>
		/// Checks to see if this filter should abort.
		/// </summary>
		// Token: 0x060003C2 RID: 962 RVA: 0x0000C884 File Offset: 0x0000AA84
		public bool CheckAbort()
		{
			return vtkAlgorithm.vtkAlgorithm_CheckAbort_10(base.GetCppThis()) != 0;
		}

		// Token: 0x060003C3 RID: 963
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_ConvertTotalInputToPortConnection_11(HandleRef pThis, int ind, ref int port, ref int conn);

		/// <summary>
		/// Convenience routine to convert from a linear ordering of input
		/// connections to a port/connection pair.
		/// </summary>
		// Token: 0x060003C4 RID: 964 RVA: 0x0000C8AA File Offset: 0x0000AAAA
		public void ConvertTotalInputToPortConnection(int ind, ref int port, ref int conn)
		{
			vtkAlgorithm.vtkAlgorithm_ConvertTotalInputToPortConnection_11(base.GetCppThis(), ind, ref port, ref conn);
		}

		// Token: 0x060003C5 RID: 965
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_GetAbortExecute_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the AbortExecute flag for the process object. Process objects
		/// may handle premature termination of execution in different ways.
		/// </summary>
		// Token: 0x060003C6 RID: 966 RVA: 0x0000C8BC File Offset: 0x0000AABC
		public virtual int GetAbortExecute()
		{
			return vtkAlgorithm.vtkAlgorithm_GetAbortExecute_12(base.GetCppThis());
		}

		// Token: 0x060003C7 RID: 967
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAlgorithm_GetAbortOutput_13(HandleRef pThis);

		/// <summary>
		/// Set/Get an internal variable used to communicate between the algorithm and
		/// executive. If the executive sees this value is set, it will initialize
		/// the output data and pass the ABORTED flag downstream.
		///
		/// CheckAbort sets this value to true if the function returns true.
		/// </summary>
		// Token: 0x060003C8 RID: 968 RVA: 0x0000C8DC File Offset: 0x0000AADC
		public virtual bool GetAbortOutput()
		{
			return vtkAlgorithm.vtkAlgorithm_GetAbortOutput_13(base.GetCppThis()) != 0;
		}

		// Token: 0x060003C9 RID: 969
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetContainerAlgorithm_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get a Container algorithm for this algorithm. Allows this algorithm
		/// to check to abort status of its Container algorithm as well as have access
		/// to its Container's information.
		/// </summary>
		// Token: 0x060003CA RID: 970 RVA: 0x0000C904 File Offset: 0x0000AB04
		public vtkAlgorithm GetContainerAlgorithm()
		{
			vtkAlgorithm vtkAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetContainerAlgorithm_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithm = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithm.Register(null);
				}
			}
			return vtkAlgorithm;
		}

		// Token: 0x060003CB RID: 971
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkAlgorithm_GetErrorCode_15(HandleRef pThis);

		/// <summary>
		/// The error code contains a possible error that occurred while
		/// reading or writing the file.
		/// </summary>
		// Token: 0x060003CC RID: 972 RVA: 0x0000C974 File Offset: 0x0000AB74
		public virtual uint GetErrorCode()
		{
			return vtkAlgorithm.vtkAlgorithm_GetErrorCode_15(base.GetCppThis());
		}

		// Token: 0x060003CD RID: 973
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetExecutive_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get this algorithm's executive.  If it has none, a default
		/// executive will be created.
		/// </summary>
		// Token: 0x060003CE RID: 974 RVA: 0x0000C994 File Offset: 0x0000AB94
		public vtkExecutive GetExecutive()
		{
			vtkExecutive vtkExecutive = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetExecutive_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExecutive = (vtkExecutive)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExecutive.Register(null);
				}
			}
			return vtkExecutive;
		}

		// Token: 0x060003CF RID: 975
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetInformation_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the information object associated with this algorithm.
		/// </summary>
		// Token: 0x060003D0 RID: 976 RVA: 0x0000CA04 File Offset: 0x0000AC04
		public virtual vtkInformation GetInformation()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetInformation_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x060003D1 RID: 977
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetInputAlgorithm_18(HandleRef pThis, int port, int index, ref int algPort, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the algorithm and the output port index of
		/// that algorithm connected to a port-index pair.
		/// </summary>
		// Token: 0x060003D2 RID: 978 RVA: 0x0000CA74 File Offset: 0x0000AC74
		public vtkAlgorithm GetInputAlgorithm(int port, int index, ref int algPort)
		{
			vtkAlgorithm vtkAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetInputAlgorithm_18(base.GetCppThis(), port, index, ref algPort, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithm = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithm.Register(null);
				}
			}
			return vtkAlgorithm;
		}

		// Token: 0x060003D3 RID: 979
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetInputAlgorithm_19(HandleRef pThis, int port, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the algorithm connected to a port-index pair.
		/// </summary>
		// Token: 0x060003D4 RID: 980 RVA: 0x0000CAE8 File Offset: 0x0000ACE8
		public vtkAlgorithm GetInputAlgorithm(int port, int index)
		{
			vtkAlgorithm vtkAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetInputAlgorithm_19(base.GetCppThis(), port, index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithm = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithm.Register(null);
				}
			}
			return vtkAlgorithm;
		}

		// Token: 0x060003D5 RID: 981
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetInputAlgorithm_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Equivalent to GetInputAlgorithm(0, 0).
		/// </summary>
		// Token: 0x060003D6 RID: 982 RVA: 0x0000CB5C File Offset: 0x0000AD5C
		public vtkAlgorithm GetInputAlgorithm()
		{
			vtkAlgorithm vtkAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetInputAlgorithm_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithm = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithm.Register(null);
				}
			}
			return vtkAlgorithm;
		}

		// Token: 0x060003D7 RID: 983
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetInputArrayInformation_21(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the info object for the specified input array to this algorithm
		/// </summary>
		// Token: 0x060003D8 RID: 984 RVA: 0x0000CBCC File Offset: 0x0000ADCC
		public vtkInformation GetInputArrayInformation(int idx)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetInputArrayInformation_21(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x060003D9 RID: 985
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetInputConnection_22(HandleRef pThis, int port, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the algorithm output port connected to an input port.
		/// </summary>
		// Token: 0x060003DA RID: 986 RVA: 0x0000CC3C File Offset: 0x0000AE3C
		public vtkAlgorithmOutput GetInputConnection(int port, int index)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetInputConnection_22(base.GetCppThis(), port, index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x060003DB RID: 987
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetInputDataObject_23(HandleRef pThis, int port, int connection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data object that will contain the algorithm input for the given
		/// port and given connection.
		/// </summary>
		// Token: 0x060003DC RID: 988 RVA: 0x0000CCB0 File Offset: 0x0000AEB0
		public vtkDataObject GetInputDataObject(int port, int connection)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetInputDataObject_23(base.GetCppThis(), port, connection, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060003DD RID: 989
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetInputExecutive_24(HandleRef pThis, int port, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the executive associated with a particular input
		/// connection.
		/// </summary>
		// Token: 0x060003DE RID: 990 RVA: 0x0000CD24 File Offset: 0x0000AF24
		public vtkExecutive GetInputExecutive(int port, int index)
		{
			vtkExecutive vtkExecutive = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetInputExecutive_24(base.GetCppThis(), port, index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExecutive = (vtkExecutive)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExecutive.Register(null);
				}
			}
			return vtkExecutive;
		}

		// Token: 0x060003DF RID: 991
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetInputExecutive_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Equivalent to GetInputExecutive(0, 0)
		/// </summary>
		// Token: 0x060003E0 RID: 992 RVA: 0x0000CD98 File Offset: 0x0000AF98
		public vtkExecutive GetInputExecutive()
		{
			vtkExecutive vtkExecutive = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetInputExecutive_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExecutive = (vtkExecutive)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExecutive.Register(null);
				}
			}
			return vtkExecutive;
		}

		// Token: 0x060003E1 RID: 993
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetInputInformation_26(HandleRef pThis, int port, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the information object that is associated with
		/// a particular input connection. This can be used to get
		/// meta-data coming from the REQUEST_INFORMATION pass and set
		/// requests for the REQUEST_UPDATE_EXTENT pass. NOTE:
		/// Do not use this in any of the pipeline passes. Use
		/// the information objects passed as arguments instead.
		/// </summary>
		// Token: 0x060003E2 RID: 994 RVA: 0x0000CE08 File Offset: 0x0000B008
		public vtkInformation GetInputInformation(int port, int index)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetInputInformation_26(base.GetCppThis(), port, index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x060003E3 RID: 995
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetInputInformation_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Equivalent to GetInputInformation(0, 0)
		/// </summary>
		// Token: 0x060003E4 RID: 996 RVA: 0x0000CE7C File Offset: 0x0000B07C
		public vtkInformation GetInputInformation()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetInputInformation_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x060003E5 RID: 997
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetInputPortInformation_28(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the information object associated with an input port.  There
		/// is one input port per kind of input to the algorithm.  Each input
		/// port tells executives what kind of data and downstream requests
		/// this algorithm can handle for that input.
		/// </summary>
		// Token: 0x060003E6 RID: 998 RVA: 0x0000CEEC File Offset: 0x0000B0EC
		public vtkInformation GetInputPortInformation(int port)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetInputPortInformation_28(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x060003E7 RID: 999
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAlgorithm_GetNumberOfGenerationsFromBase_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060003E8 RID: 1000 RVA: 0x0000CF5C File Offset: 0x0000B15C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAlgorithm.vtkAlgorithm_GetNumberOfGenerationsFromBase_29(base.GetCppThis(), type);
		}

		// Token: 0x060003E9 RID: 1001
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAlgorithm_GetNumberOfGenerationsFromBaseType_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060003EA RID: 1002 RVA: 0x0000CF7C File Offset: 0x0000B17C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAlgorithm.vtkAlgorithm_GetNumberOfGenerationsFromBaseType_30(type);
		}

		// Token: 0x060003EB RID: 1003
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_GetNumberOfInputConnections_31(HandleRef pThis, int port);

		/// <summary>
		/// Get the number of inputs currently connected to a port.
		/// </summary>
		// Token: 0x060003EC RID: 1004 RVA: 0x0000CF98 File Offset: 0x0000B198
		public int GetNumberOfInputConnections(int port)
		{
			return vtkAlgorithm.vtkAlgorithm_GetNumberOfInputConnections_31(base.GetCppThis(), port);
		}

		// Token: 0x060003ED RID: 1005
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_GetNumberOfInputPorts_32(HandleRef pThis);

		/// <summary>
		/// Get the number of input ports used by the algorithm.
		/// </summary>
		// Token: 0x060003EE RID: 1006 RVA: 0x0000CFB8 File Offset: 0x0000B1B8
		public int GetNumberOfInputPorts()
		{
			return vtkAlgorithm.vtkAlgorithm_GetNumberOfInputPorts_32(base.GetCppThis());
		}

		// Token: 0x060003EF RID: 1007
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_GetNumberOfOutputPorts_33(HandleRef pThis);

		/// <summary>
		/// Get the number of output ports provided by the algorithm.
		/// </summary>
		// Token: 0x060003F0 RID: 1008 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		public int GetNumberOfOutputPorts()
		{
			return vtkAlgorithm.vtkAlgorithm_GetNumberOfOutputPorts_33(base.GetCppThis());
		}

		// Token: 0x060003F1 RID: 1009
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetOutputDataObject_34(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data object that will contain the algorithm output for
		/// the given port.
		/// </summary>
		// Token: 0x060003F2 RID: 1010 RVA: 0x0000CFF8 File Offset: 0x0000B1F8
		public vtkDataObject GetOutputDataObject(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetOutputDataObject_34(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060003F3 RID: 1011
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetOutputInformation_35(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the information object that is associated with
		/// a particular output port. This can be used to set
		/// meta-data coming during the REQUEST_INFORMATION. NOTE:
		/// Do not use this in any of the pipeline passes. Use
		/// the information objects passed as arguments instead.
		/// </summary>
		// Token: 0x060003F4 RID: 1012 RVA: 0x0000D068 File Offset: 0x0000B268
		public vtkInformation GetOutputInformation(int port)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetOutputInformation_35(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x060003F5 RID: 1013
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetOutputPort_36(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a proxy object corresponding to the given output port of this
		/// algorithm.  The proxy object can be passed to another algorithm's
		/// SetInputConnection(), AddInputConnection(), and
		/// RemoveInputConnection() methods to modify pipeline connectivity.
		/// </summary>
		// Token: 0x060003F6 RID: 1014 RVA: 0x0000D0D8 File Offset: 0x0000B2D8
		public vtkAlgorithmOutput GetOutputPort(int index)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetOutputPort_36(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x060003F7 RID: 1015
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetOutputPort_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a proxy object corresponding to the given output port of this
		/// algorithm.  The proxy object can be passed to another algorithm's
		/// SetInputConnection(), AddInputConnection(), and
		/// RemoveInputConnection() methods to modify pipeline connectivity.
		/// </summary>
		// Token: 0x060003F8 RID: 1016 RVA: 0x0000D148 File Offset: 0x0000B348
		public vtkAlgorithmOutput GetOutputPort()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetOutputPort_37(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x060003F9 RID: 1017
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetOutputPortInformation_38(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the information object associated with an output port.  There
		/// is one output port per output from the algorithm.  Each output
		/// port tells executives what kind of upstream requests this
		/// algorithm can handle for that output.
		/// </summary>
		// Token: 0x060003FA RID: 1018 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		public vtkInformation GetOutputPortInformation(int port)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetOutputPortInformation_38(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x060003FB RID: 1019
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAlgorithm_GetProgress_39(HandleRef pThis);

		/// <summary>
		/// Get the execution progress of a process object.
		/// </summary>
		// Token: 0x060003FC RID: 1020 RVA: 0x0000D228 File Offset: 0x0000B428
		public virtual double GetProgress()
		{
			return vtkAlgorithm.vtkAlgorithm_GetProgress_39(base.GetCppThis());
		}

		// Token: 0x060003FD RID: 1021
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetProgressObserver_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If an ProgressObserver is set, the algorithm will report
		/// progress through it rather than directly. This means that
		/// it will call UpdateProgress() on the ProgressObserver rather
		/// than itself report it and set progress.
		/// This is most useful in situations where multiple threads
		/// are executing an algorithm at the same time and want to
		/// handle progress locally.
		/// </summary>
		// Token: 0x060003FE RID: 1022 RVA: 0x0000D248 File Offset: 0x0000B448
		public virtual vtkProgressObserver GetProgressObserver()
		{
			vtkProgressObserver vtkProgressObserver = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetProgressObserver_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProgressObserver = (vtkProgressObserver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProgressObserver.Register(null);
				}
			}
			return vtkProgressObserver;
		}

		// Token: 0x060003FF RID: 1023
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAlgorithm_GetProgressScale_41(HandleRef pThis);

		/// <summary>
		/// Specify the shift and scale values to use to apply to the progress amount
		/// when `UpdateProgress` is called. By default shift is set to 0, and scale is
		/// set to 1.0. This is useful when the vtkAlgorithm instance is used as an
		/// internal algorithm to solve only a part of a whole problem.
		///
		/// If calling on a internal vtkAlgorithm, make sure you take into
		/// consideration that values set of the outer vtkAlgorithm as well since the
		/// outer vtkAlgorithm itself may be nested in another algorithm.
		///
		/// @note SetProgressShiftScale does not modify the MTime of the algorithm.
		/// </summary>
		// Token: 0x06000400 RID: 1024 RVA: 0x0000D2B8 File Offset: 0x0000B4B8
		public virtual double GetProgressScale()
		{
			return vtkAlgorithm.vtkAlgorithm_GetProgressScale_41(base.GetCppThis());
		}

		// Token: 0x06000401 RID: 1025
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAlgorithm_GetProgressShift_42(HandleRef pThis);

		/// <summary>
		/// Specify the shift and scale values to use to apply to the progress amount
		/// when `UpdateProgress` is called. By default shift is set to 0, and scale is
		/// set to 1.0. This is useful when the vtkAlgorithm instance is used as an
		/// internal algorithm to solve only a part of a whole problem.
		///
		/// If calling on a internal vtkAlgorithm, make sure you take into
		/// consideration that values set of the outer vtkAlgorithm as well since the
		/// outer vtkAlgorithm itself may be nested in another algorithm.
		///
		/// @note SetProgressShiftScale does not modify the MTime of the algorithm.
		/// </summary>
		// Token: 0x06000402 RID: 1026 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		public virtual double GetProgressShift()
		{
			return vtkAlgorithm.vtkAlgorithm_GetProgressShift_42(base.GetCppThis());
		}

		// Token: 0x06000403 RID: 1027
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetProgressText_43(HandleRef pThis);

		/// <summary>
		/// Set the current text message associated with the progress state.
		/// This may be used by a calling process/GUI.
		/// Note: Because SetProgressText() is called from inside RequestData()
		/// it does not modify the algorithm object. Algorithms are not
		/// allowed to modify themselves from inside RequestData().
		/// </summary>
		// Token: 0x06000404 RID: 1028 RVA: 0x0000D2F8 File Offset: 0x0000B4F8
		public virtual string GetProgressText()
		{
			string s = Marshal.PtrToStringAnsi(vtkAlgorithm.vtkAlgorithm_GetProgressText_43(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000405 RID: 1029
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_GetReleaseDataFlag_44(HandleRef pThis);

		/// <summary>
		/// Turn release data flag on or off for all output ports.
		/// </summary>
		// Token: 0x06000406 RID: 1030 RVA: 0x0000D334 File Offset: 0x0000B534
		public virtual int GetReleaseDataFlag()
		{
			return vtkAlgorithm.vtkAlgorithm_GetReleaseDataFlag_44(base.GetCppThis());
		}

		// Token: 0x06000407 RID: 1031
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_GetTotalNumberOfInputConnections_45(HandleRef pThis);

		/// <summary>
		/// Get the total number of inputs for this algorithm
		/// </summary>
		// Token: 0x06000408 RID: 1032 RVA: 0x0000D354 File Offset: 0x0000B554
		public int GetTotalNumberOfInputConnections()
		{
			return vtkAlgorithm.vtkAlgorithm_GetTotalNumberOfInputConnections_45(base.GetCppThis());
		}

		// Token: 0x06000409 RID: 1033
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetUpdateExtent_46(HandleRef pThis);

		/// <summary>
		/// These functions return the update extent for output ports that
		/// use 3D extents. Where port is not specified, it is assumed to
		/// be 0.
		/// </summary>
		// Token: 0x0600040A RID: 1034 RVA: 0x0000D374 File Offset: 0x0000B574
		public int[] GetUpdateExtent()
		{
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetUpdateExtent_46(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600040B RID: 1035
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_GetUpdateExtent_47(HandleRef pThis, int port);

		/// <summary>
		/// These functions return the update extent for output ports that
		/// use 3D extents. Where port is not specified, it is assumed to
		/// be 0.
		/// </summary>
		// Token: 0x0600040C RID: 1036 RVA: 0x0000D3BC File Offset: 0x0000B5BC
		public int[] GetUpdateExtent(int port)
		{
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetUpdateExtent_47(base.GetCppThis(), port);
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600040D RID: 1037
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_GetUpdateExtent_48(HandleRef pThis, ref int x0, ref int x1, ref int y0, ref int y1, ref int z0, ref int z1);

		/// <summary>
		/// These functions return the update extent for output ports that
		/// use 3D extents. Where port is not specified, it is assumed to
		/// be 0.
		/// </summary>
		// Token: 0x0600040E RID: 1038 RVA: 0x0000D405 File Offset: 0x0000B605
		public void GetUpdateExtent(ref int x0, ref int x1, ref int y0, ref int y1, ref int z0, ref int z1)
		{
			vtkAlgorithm.vtkAlgorithm_GetUpdateExtent_48(base.GetCppThis(), ref x0, ref x1, ref y0, ref y1, ref z0, ref z1);
		}

		// Token: 0x0600040F RID: 1039
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_GetUpdateExtent_49(HandleRef pThis, int port, ref int x0, ref int x1, ref int y0, ref int y1, ref int z0, ref int z1);

		/// <summary>
		/// These functions return the update extent for output ports that
		/// use 3D extents. Where port is not specified, it is assumed to
		/// be 0.
		/// </summary>
		// Token: 0x06000410 RID: 1040 RVA: 0x0000D41D File Offset: 0x0000B61D
		public void GetUpdateExtent(int port, ref int x0, ref int x1, ref int y0, ref int y1, ref int z0, ref int z1)
		{
			vtkAlgorithm.vtkAlgorithm_GetUpdateExtent_49(base.GetCppThis(), port, ref x0, ref x1, ref y0, ref y1, ref z0, ref z1);
		}

		// Token: 0x06000411 RID: 1041
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_GetUpdateExtent_50(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// These functions return the update extent for output ports that
		/// use 3D extents. Where port is not specified, it is assumed to
		/// be 0.
		/// </summary>
		// Token: 0x06000412 RID: 1042 RVA: 0x0000D437 File Offset: 0x0000B637
		public void GetUpdateExtent(IntPtr extent)
		{
			vtkAlgorithm.vtkAlgorithm_GetUpdateExtent_50(base.GetCppThis(), extent);
		}

		// Token: 0x06000413 RID: 1043
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_GetUpdateExtent_51(HandleRef pThis, int port, IntPtr extent);

		/// <summary>
		/// These functions return the update extent for output ports that
		/// use 3D extents. Where port is not specified, it is assumed to
		/// be 0.
		/// </summary>
		// Token: 0x06000414 RID: 1044 RVA: 0x0000D447 File Offset: 0x0000B647
		public void GetUpdateExtent(int port, IntPtr extent)
		{
			vtkAlgorithm.vtkAlgorithm_GetUpdateExtent_51(base.GetCppThis(), port, extent);
		}

		// Token: 0x06000415 RID: 1045
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_GetUpdateGhostLevel_52(HandleRef pThis);

		/// <summary>
		/// These functions return the update extent for output ports that
		/// use piece extents. Where port is not specified, it is assumed to
		/// be 0.
		/// </summary>
		// Token: 0x06000416 RID: 1046 RVA: 0x0000D458 File Offset: 0x0000B658
		public int GetUpdateGhostLevel()
		{
			return vtkAlgorithm.vtkAlgorithm_GetUpdateGhostLevel_52(base.GetCppThis());
		}

		// Token: 0x06000417 RID: 1047
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_GetUpdateGhostLevel_53(HandleRef pThis, int port);

		/// <summary>
		/// These functions return the update extent for output ports that
		/// use piece extents. Where port is not specified, it is assumed to
		/// be 0.
		/// </summary>
		// Token: 0x06000418 RID: 1048 RVA: 0x0000D478 File Offset: 0x0000B678
		public int GetUpdateGhostLevel(int port)
		{
			return vtkAlgorithm.vtkAlgorithm_GetUpdateGhostLevel_53(base.GetCppThis(), port);
		}

		// Token: 0x06000419 RID: 1049
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_GetUpdateNumberOfPieces_54(HandleRef pThis);

		/// <summary>
		/// These functions return the update extent for output ports that
		/// use piece extents. Where port is not specified, it is assumed to
		/// be 0.
		/// </summary>
		// Token: 0x0600041A RID: 1050 RVA: 0x0000D498 File Offset: 0x0000B698
		public int GetUpdateNumberOfPieces()
		{
			return vtkAlgorithm.vtkAlgorithm_GetUpdateNumberOfPieces_54(base.GetCppThis());
		}

		// Token: 0x0600041B RID: 1051
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_GetUpdateNumberOfPieces_55(HandleRef pThis, int port);

		/// <summary>
		/// These functions return the update extent for output ports that
		/// use piece extents. Where port is not specified, it is assumed to
		/// be 0.
		/// </summary>
		// Token: 0x0600041C RID: 1052 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		public int GetUpdateNumberOfPieces(int port)
		{
			return vtkAlgorithm.vtkAlgorithm_GetUpdateNumberOfPieces_55(base.GetCppThis(), port);
		}

		// Token: 0x0600041D RID: 1053
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_GetUpdatePiece_56(HandleRef pThis);

		/// <summary>
		/// These functions return the update extent for output ports that
		/// use piece extents. Where port is not specified, it is assumed to
		/// be 0.
		/// </summary>
		// Token: 0x0600041E RID: 1054 RVA: 0x0000D4D8 File Offset: 0x0000B6D8
		public int GetUpdatePiece()
		{
			return vtkAlgorithm.vtkAlgorithm_GetUpdatePiece_56(base.GetCppThis());
		}

		// Token: 0x0600041F RID: 1055
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_GetUpdatePiece_57(HandleRef pThis, int port);

		/// <summary>
		/// These functions return the update extent for output ports that
		/// use piece extents. Where port is not specified, it is assumed to
		/// be 0.
		/// </summary>
		// Token: 0x06000420 RID: 1056 RVA: 0x0000D4F8 File Offset: 0x0000B6F8
		public int GetUpdatePiece(int port)
		{
			return vtkAlgorithm.vtkAlgorithm_GetUpdatePiece_57(base.GetCppThis(), port);
		}

		// Token: 0x06000421 RID: 1057
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_HasExecutive_58(HandleRef pThis);

		/// <summary>
		/// Check whether this algorithm has an assigned executive.  This
		/// will NOT create a default executive.
		/// </summary>
		// Token: 0x06000422 RID: 1058 RVA: 0x0000D518 File Offset: 0x0000B718
		public int HasExecutive()
		{
			return vtkAlgorithm.vtkAlgorithm_HasExecutive_58(base.GetCppThis());
		}

		// Token: 0x06000423 RID: 1059
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_INPUT_ARRAYS_TO_PROCESS_59(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06000424 RID: 1060 RVA: 0x0000D538 File Offset: 0x0000B738
		public static vtkInformationInformationVectorKey INPUT_ARRAYS_TO_PROCESS()
		{
			vtkInformationInformationVectorKey vtkInformationInformationVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_INPUT_ARRAYS_TO_PROCESS_59(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationVectorKey = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationVectorKey.Register(null);
				}
			}
			return vtkInformationInformationVectorKey;
		}

		// Token: 0x06000425 RID: 1061
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_INPUT_CONNECTION_60(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06000426 RID: 1062 RVA: 0x0000D5A4 File Offset: 0x0000B7A4
		public static vtkInformationIntegerKey INPUT_CONNECTION()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_INPUT_CONNECTION_60(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000427 RID: 1063
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_INPUT_IS_OPTIONAL_61(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Keys used to specify input port requirements.
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06000428 RID: 1064 RVA: 0x0000D610 File Offset: 0x0000B810
		public static vtkInformationIntegerKey INPUT_IS_OPTIONAL()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_INPUT_IS_OPTIONAL_61(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000429 RID: 1065
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_INPUT_IS_REPEATABLE_62(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x0600042A RID: 1066 RVA: 0x0000D67C File Offset: 0x0000B87C
		public static vtkInformationIntegerKey INPUT_IS_REPEATABLE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_INPUT_IS_REPEATABLE_62(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600042B RID: 1067
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_INPUT_PORT_63(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x0600042C RID: 1068 RVA: 0x0000D6E8 File Offset: 0x0000B8E8
		public static vtkInformationIntegerKey INPUT_PORT()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_INPUT_PORT_63(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600042D RID: 1069
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_INPUT_REQUIRED_DATA_TYPE_64(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x0600042E RID: 1070 RVA: 0x0000D754 File Offset: 0x0000B954
		public static vtkInformationStringVectorKey INPUT_REQUIRED_DATA_TYPE()
		{
			vtkInformationStringVectorKey vtkInformationStringVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_INPUT_REQUIRED_DATA_TYPE_64(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringVectorKey = (vtkInformationStringVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringVectorKey.Register(null);
				}
			}
			return vtkInformationStringVectorKey;
		}

		// Token: 0x0600042F RID: 1071
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_INPUT_REQUIRED_FIELDS_65(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// \ingroup InformationKeys
		/// </summary>
		// Token: 0x06000430 RID: 1072 RVA: 0x0000D7C0 File Offset: 0x0000B9C0
		public static vtkInformationInformationVectorKey INPUT_REQUIRED_FIELDS()
		{
			vtkInformationInformationVectorKey vtkInformationInformationVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_INPUT_REQUIRED_FIELDS_65(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationVectorKey = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationVectorKey.Register(null);
				}
			}
			return vtkInformationInformationVectorKey;
		}

		// Token: 0x06000431 RID: 1073
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_IsA_66(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000432 RID: 1074 RVA: 0x0000D82C File Offset: 0x0000BA2C
		public override int IsA(string type)
		{
			return vtkAlgorithm.vtkAlgorithm_IsA_66(base.GetCppThis(), type);
		}

		// Token: 0x06000433 RID: 1075
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_IsTypeOf_67([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000434 RID: 1076 RVA: 0x0000D84C File Offset: 0x0000BA4C
		public new static int IsTypeOf(string type)
		{
			return vtkAlgorithm.vtkAlgorithm_IsTypeOf_67(type);
		}

		// Token: 0x06000435 RID: 1077
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_ModifyRequest_68(HandleRef pThis, HandleRef request, int when);

		/// <summary>
		/// This method gives the algorithm a chance to modify the contents of a
		/// request before or after (specified in the when argument) it is
		/// forwarded. The default implementation is empty. Returns 1 on success,
		/// 0 on failure. When can be either vtkExecutive::BeforeForward or
		/// vtkExecutive::AfterForward.
		/// </summary>
		// Token: 0x06000436 RID: 1078 RVA: 0x0000D868 File Offset: 0x0000BA68
		public virtual int ModifyRequest(vtkInformation request, int when)
		{
			return vtkAlgorithm.vtkAlgorithm_ModifyRequest_68(base.GetCppThis(), (request == null) ? default(HandleRef) : request.GetCppThis(), when);
		}

		// Token: 0x06000437 RID: 1079
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_NewInstance_70(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000438 RID: 1080 RVA: 0x0000D8A0 File Offset: 0x0000BAA0
		public new vtkAlgorithm NewInstance()
		{
			vtkAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_NewInstance_70(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000439 RID: 1081
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_ProcessRequest_71(HandleRef pThis, HandleRef request, HandleRef inInfo, HandleRef outInfo);

		/// <summary>
		/// Version of ProcessRequest() that is wrapped. This converts the
		/// collection to an array and calls the other version.
		/// </summary>
		// Token: 0x0600043A RID: 1082 RVA: 0x0000D8FC File Offset: 0x0000BAFC
		public int ProcessRequest(vtkInformation request, vtkCollection inInfo, vtkInformationVector outInfo)
		{
			return vtkAlgorithm.vtkAlgorithm_ProcessRequest_71(base.GetCppThis(), (request == null) ? default(HandleRef) : request.GetCppThis(), (inInfo == null) ? default(HandleRef) : inInfo.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis());
		}

		// Token: 0x0600043B RID: 1083
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_PropagateUpdateExtent_72(HandleRef pThis);

		/// <summary>
		/// Propagate meta-data upstream.
		/// </summary>
		// Token: 0x0600043C RID: 1084 RVA: 0x0000D95A File Offset: 0x0000BB5A
		public virtual void PropagateUpdateExtent()
		{
			vtkAlgorithm.vtkAlgorithm_PropagateUpdateExtent_72(base.GetCppThis());
		}

		// Token: 0x0600043D RID: 1085
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_ReleaseDataFlagOff_73(HandleRef pThis);

		/// <summary>
		/// Turn release data flag on or off for all output ports.
		/// </summary>
		// Token: 0x0600043E RID: 1086 RVA: 0x0000D969 File Offset: 0x0000BB69
		public void ReleaseDataFlagOff()
		{
			vtkAlgorithm.vtkAlgorithm_ReleaseDataFlagOff_73(base.GetCppThis());
		}

		// Token: 0x0600043F RID: 1087
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_ReleaseDataFlagOn_74(HandleRef pThis);

		/// <summary>
		/// Turn release data flag on or off for all output ports.
		/// </summary>
		// Token: 0x06000440 RID: 1088 RVA: 0x0000D978 File Offset: 0x0000BB78
		public void ReleaseDataFlagOn()
		{
			vtkAlgorithm.vtkAlgorithm_ReleaseDataFlagOn_74(base.GetCppThis());
		}

		// Token: 0x06000441 RID: 1089
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_RemoveAllInputConnections_75(HandleRef pThis, int port);

		/// <summary>
		/// Removes all input connections.
		/// </summary>
		// Token: 0x06000442 RID: 1090 RVA: 0x0000D987 File Offset: 0x0000BB87
		public virtual void RemoveAllInputConnections(int port)
		{
			vtkAlgorithm.vtkAlgorithm_RemoveAllInputConnections_75(base.GetCppThis(), port);
		}

		// Token: 0x06000443 RID: 1091
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_RemoveAllInputs_76(HandleRef pThis);

		/// <summary>
		/// Remove all the input data.
		/// </summary>
		// Token: 0x06000444 RID: 1092 RVA: 0x0000D997 File Offset: 0x0000BB97
		public void RemoveAllInputs()
		{
			vtkAlgorithm.vtkAlgorithm_RemoveAllInputs_76(base.GetCppThis());
		}

		// Token: 0x06000445 RID: 1093
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_RemoveInputConnection_77(HandleRef pThis, int port, HandleRef input);

		/// <summary>
		/// Remove a connection from the given input port index.  See
		/// SetInputConnection() for details on input connection.  This
		/// method is the complement to AddInputConnection() in that it
		/// removes only the connection specified without affecting other
		/// connections.  Typical usage is
		///
		/// filter2-&gt;RemoveInputConnection(0, filter1-&gt;GetOutputPort(0)).
		/// </summary>
		// Token: 0x06000446 RID: 1094 RVA: 0x0000D9A8 File Offset: 0x0000BBA8
		public virtual void RemoveInputConnection(int port, vtkAlgorithmOutput input)
		{
			vtkAlgorithm.vtkAlgorithm_RemoveInputConnection_77(base.GetCppThis(), port, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06000447 RID: 1095
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_RemoveInputConnection_78(HandleRef pThis, int port, int idx);

		/// <summary>
		/// Remove a connection given by index idx.
		/// </summary>
		// Token: 0x06000448 RID: 1096 RVA: 0x0000D9D8 File Offset: 0x0000BBD8
		public virtual void RemoveInputConnection(int port, int idx)
		{
			vtkAlgorithm.vtkAlgorithm_RemoveInputConnection_78(base.GetCppThis(), port, idx);
		}

		// Token: 0x06000449 RID: 1097
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_RemoveNoPriorTemporalAccessInformationKey_79(HandleRef pThis);

		/// <summary>
		/// Removes any information key `vtkStreamingDemandDrivenPipeline::NO_PRIOR_TEMPORAL_ACCESS()`
		/// to all output ports of this `vtkAlgorithm`.
		/// </summary>
		// Token: 0x0600044A RID: 1098 RVA: 0x0000D9E9 File Offset: 0x0000BBE9
		public void RemoveNoPriorTemporalAccessInformationKey()
		{
			vtkAlgorithm.vtkAlgorithm_RemoveNoPriorTemporalAccessInformationKey_79(base.GetCppThis());
		}

		// Token: 0x0600044B RID: 1099
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAlgorithm_SafeDownCast_80(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600044C RID: 1100 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		public new static vtkAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkAlgorithm vtkAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_SafeDownCast_80((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithm = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithm.Register(null);
				}
			}
			return vtkAlgorithm;
		}

		// Token: 0x0600044D RID: 1101
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetAbortExecute_81(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the AbortExecute flag for the process object. Process objects
		/// may handle premature termination of execution in different ways.
		/// </summary>
		// Token: 0x0600044E RID: 1102 RVA: 0x0000DA77 File Offset: 0x0000BC77
		public virtual void SetAbortExecute(int _arg)
		{
			vtkAlgorithm.vtkAlgorithm_SetAbortExecute_81(base.GetCppThis(), _arg);
		}

		// Token: 0x0600044F RID: 1103
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetAbortExecuteAndUpdateTime_82(HandleRef pThis);

		/// <summary>
		///  Set AbortExecute Flag and update LastAbortTime.
		/// </summary>
		// Token: 0x06000450 RID: 1104 RVA: 0x0000DA87 File Offset: 0x0000BC87
		public void SetAbortExecuteAndUpdateTime()
		{
			vtkAlgorithm.vtkAlgorithm_SetAbortExecuteAndUpdateTime_82(base.GetCppThis());
		}

		// Token: 0x06000451 RID: 1105
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetAbortOutput_83(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get an internal variable used to communicate between the algorithm and
		/// executive. If the executive sees this value is set, it will initialize
		/// the output data and pass the ABORTED flag downstream.
		///
		/// CheckAbort sets this value to true if the function returns true.
		/// </summary>
		// Token: 0x06000452 RID: 1106 RVA: 0x0000DA96 File Offset: 0x0000BC96
		public virtual void SetAbortOutput(bool _arg)
		{
			vtkAlgorithm.vtkAlgorithm_SetAbortOutput_83(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06000453 RID: 1107
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetContainerAlgorithm_84(HandleRef pThis, HandleRef containerAlg);

		/// <summary>
		/// Set/get a Container algorithm for this algorithm. Allows this algorithm
		/// to check to abort status of its Container algorithm as well as have access
		/// to its Container's information.
		/// </summary>
		// Token: 0x06000454 RID: 1108 RVA: 0x0000DAB0 File Offset: 0x0000BCB0
		public void SetContainerAlgorithm(vtkAlgorithm containerAlg)
		{
			vtkAlgorithm.vtkAlgorithm_SetContainerAlgorithm_84(base.GetCppThis(), (containerAlg == null) ? default(HandleRef) : containerAlg.GetCppThis());
		}

		// Token: 0x06000455 RID: 1109
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetDefaultExecutivePrototype_85(HandleRef proto);

		/// <summary>
		/// If the DefaultExecutivePrototype is set, a copy of it is created
		/// in CreateDefaultExecutive() using NewInstance().
		/// </summary>
		// Token: 0x06000456 RID: 1110 RVA: 0x0000DAE0 File Offset: 0x0000BCE0
		public static void SetDefaultExecutivePrototype(vtkExecutive proto)
		{
			vtkAlgorithm.vtkAlgorithm_SetDefaultExecutivePrototype_85((proto == null) ? default(HandleRef) : proto.GetCppThis());
		}

		// Token: 0x06000457 RID: 1111
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetExecutive_86(HandleRef pThis, HandleRef executive);

		/// <summary>
		/// Set this algorithm's executive.  This algorithm is removed from
		/// any executive to which it has previously been assigned and then
		/// assigned to the given executive.
		/// </summary>
		// Token: 0x06000458 RID: 1112 RVA: 0x0000DB0C File Offset: 0x0000BD0C
		public virtual void SetExecutive(vtkExecutive executive)
		{
			vtkAlgorithm.vtkAlgorithm_SetExecutive_86(base.GetCppThis(), (executive == null) ? default(HandleRef) : executive.GetCppThis());
		}

		// Token: 0x06000459 RID: 1113
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetInformation_87(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the information object associated with this algorithm.
		/// </summary>
		// Token: 0x0600045A RID: 1114 RVA: 0x0000DB3C File Offset: 0x0000BD3C
		public virtual void SetInformation(vtkInformation arg0)
		{
			vtkAlgorithm.vtkAlgorithm_SetInformation_87(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600045B RID: 1115
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetInputArrayToProcess_88(HandleRef pThis, int idx, int port, int connection, int fieldAssociation, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the input data arrays that this algorithm will
		/// process. Specifically the idx array that this algorithm will process
		/// (starting from 0) is the array on port, connection with the specified
		/// association and name or attribute type (such as SCALARS). The
		/// fieldAssociation refers to which field in the data object the array is
		/// stored. See vtkDataObject::FieldAssociations for detail.
		/// </summary>
		// Token: 0x0600045C RID: 1116 RVA: 0x0000DB6B File Offset: 0x0000BD6B
		public virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, string name)
		{
			vtkAlgorithm.vtkAlgorithm_SetInputArrayToProcess_88(base.GetCppThis(), idx, port, connection, fieldAssociation, name);
		}

		// Token: 0x0600045D RID: 1117
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetInputArrayToProcess_89(HandleRef pThis, int idx, int port, int connection, int fieldAssociation, int fieldAttributeType);

		/// <summary>
		/// Set the input data arrays that this algorithm will
		/// process. Specifically the idx array that this algorithm will process
		/// (starting from 0) is the array on port, connection with the specified
		/// association and name or attribute type (such as SCALARS). The
		/// fieldAssociation refers to which field in the data object the array is
		/// stored. See vtkDataObject::FieldAssociations for detail.
		/// </summary>
		// Token: 0x0600045E RID: 1118 RVA: 0x0000DB81 File Offset: 0x0000BD81
		public virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)
		{
			vtkAlgorithm.vtkAlgorithm_SetInputArrayToProcess_89(base.GetCppThis(), idx, port, connection, fieldAssociation, fieldAttributeType);
		}

		// Token: 0x0600045F RID: 1119
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetInputArrayToProcess_90(HandleRef pThis, int idx, HandleRef info);

		/// <summary>
		/// Set the input data arrays that this algorithm will
		/// process. Specifically the idx array that this algorithm will process
		/// (starting from 0) is the array on port, connection with the specified
		/// association and name or attribute type (such as SCALARS). The
		/// fieldAssociation refers to which field in the data object the array is
		/// stored. See vtkDataObject::FieldAssociations for detail.
		/// </summary>
		// Token: 0x06000460 RID: 1120 RVA: 0x0000DB98 File Offset: 0x0000BD98
		public virtual void SetInputArrayToProcess(int idx, vtkInformation info)
		{
			vtkAlgorithm.vtkAlgorithm_SetInputArrayToProcess_90(base.GetCppThis(), idx, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x06000461 RID: 1121
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetInputArrayToProcess_91(HandleRef pThis, int idx, int port, int connection, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldAssociation, [MarshalAs(UnmanagedType.LPUTF8Str)] string attributeTypeorName);

		/// <summary>
		/// String based versions of SetInputArrayToProcess(). Because
		/// fieldAssociation and fieldAttributeType are enums, they cannot be
		/// easily accessed from scripting language. These methods provides an
		/// easy and safe way of passing association and attribute type
		/// information. Field association is one of the following:
		/// @verbatim
		/// vtkDataObject::FIELD_ASSOCIATION_POINTS
		/// vtkDataObject::FIELD_ASSOCIATION_CELLS
		/// vtkDataObject::FIELD_ASSOCIATION_NONE
		/// vtkDataObject::FIELD_ASSOCIATION_POINTS_THEN_CELLS
		/// @endverbatim
		/// Attribute type is one of the following:
		/// @verbatim
		/// vtkDataSetAttributes::SCALARS
		/// vtkDataSetAttributes::VECTORS
		/// vtkDataSetAttributes::NORMALS
		/// vtkDataSetAttributes::TCOORDS
		/// vtkDataSetAttributes::TENSORS
		/// @endverbatim
		/// If the last argument is not an attribute type, it is assumed to
		/// be an array name.
		/// </summary>
		// Token: 0x06000462 RID: 1122 RVA: 0x0000DBC8 File Offset: 0x0000BDC8
		public virtual void SetInputArrayToProcess(int idx, int port, int connection, string fieldAssociation, string attributeTypeorName)
		{
			vtkAlgorithm.vtkAlgorithm_SetInputArrayToProcess_91(base.GetCppThis(), idx, port, connection, fieldAssociation, attributeTypeorName);
		}

		// Token: 0x06000463 RID: 1123
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetInputConnection_92(HandleRef pThis, int port, HandleRef input);

		/// <summary>
		/// Set the connection for the given input port index.  Each input
		/// port of a filter has a specific purpose.  A port may have zero or
		/// more connections and the required number is specified by each
		/// filter.  Setting the connection with this method removes all
		/// other connections from the port.  To add more than one connection
		/// use AddInputConnection().
		///
		/// The input for the connection is the output port of another
		/// filter, which is obtained with GetOutputPort().  Typical usage is
		///
		/// filter2-&gt;SetInputConnection(0, filter1-&gt;GetOutputPort(0)).
		/// </summary>
		// Token: 0x06000464 RID: 1124 RVA: 0x0000DBE0 File Offset: 0x0000BDE0
		public virtual void SetInputConnection(int port, vtkAlgorithmOutput input)
		{
			vtkAlgorithm.vtkAlgorithm_SetInputConnection_92(base.GetCppThis(), port, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06000465 RID: 1125
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetInputConnection_93(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the connection for the given input port index.  Each input
		/// port of a filter has a specific purpose.  A port may have zero or
		/// more connections and the required number is specified by each
		/// filter.  Setting the connection with this method removes all
		/// other connections from the port.  To add more than one connection
		/// use AddInputConnection().
		///
		/// The input for the connection is the output port of another
		/// filter, which is obtained with GetOutputPort().  Typical usage is
		///
		/// filter2-&gt;SetInputConnection(0, filter1-&gt;GetOutputPort(0)).
		/// </summary>
		// Token: 0x06000466 RID: 1126 RVA: 0x0000DC10 File Offset: 0x0000BE10
		public virtual void SetInputConnection(vtkAlgorithmOutput input)
		{
			vtkAlgorithm.vtkAlgorithm_SetInputConnection_93(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06000467 RID: 1127
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetInputDataObject_94(HandleRef pThis, int port, HandleRef data);

		/// <summary>
		/// Sets the data-object as an input on the given port index. Setting the input with
		/// this method removes all other connections from the port. Internally, this
		/// method creates a vtkTrivialProducer instance and sets that as the
		/// input-connection for the given port. It is safe to call this method repeatedly
		/// with the same input data object. The MTime of the vtkAlgorithm will not
		/// change unless the data object changed.
		/// </summary>
		// Token: 0x06000468 RID: 1128 RVA: 0x0000DC40 File Offset: 0x0000BE40
		public virtual void SetInputDataObject(int port, vtkDataObject data)
		{
			vtkAlgorithm.vtkAlgorithm_SetInputDataObject_94(base.GetCppThis(), port, (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x06000469 RID: 1129
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetInputDataObject_95(HandleRef pThis, HandleRef data);

		/// <summary>
		/// Sets the data-object as an input on the given port index. Setting the input with
		/// this method removes all other connections from the port. Internally, this
		/// method creates a vtkTrivialProducer instance and sets that as the
		/// input-connection for the given port. It is safe to call this method repeatedly
		/// with the same input data object. The MTime of the vtkAlgorithm will not
		/// change unless the data object changed.
		/// </summary>
		// Token: 0x0600046A RID: 1130 RVA: 0x0000DC70 File Offset: 0x0000BE70
		public virtual void SetInputDataObject(vtkDataObject data)
		{
			vtkAlgorithm.vtkAlgorithm_SetInputDataObject_95(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x0600046B RID: 1131
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetNoPriorTemporalAccessInformationKey_96(HandleRef pThis, int key);

		/// <summary>
		/// Set to all output ports of this algorithm the information key
		/// `vtkStreamingDemandDrivenPipeline::NO_PRIOR_TEMPORAL_ACCESS()`. This should
		/// be set on sources of pipelines for which all timesteps are not necessarily
		/// all available at once. This is typically the case for visualization in situ.
		///
		/// @note Default value in `vtkStreamingDemandDrivenPipeline::NO_PRIOR_TEMPORAL_ACCESS_RESET`.
		/// `vtkStreamingDemandDrivenPipeline` will set it to `NO_PRIOR_TEMPORAL_ACCESS_CONTINUE' after
		/// execution of the first time step.
		/// </summary>
		// Token: 0x0600046C RID: 1132 RVA: 0x0000DC9F File Offset: 0x0000BE9F
		public void SetNoPriorTemporalAccessInformationKey(int key)
		{
			vtkAlgorithm.vtkAlgorithm_SetNoPriorTemporalAccessInformationKey_96(base.GetCppThis(), key);
		}

		// Token: 0x0600046D RID: 1133
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetNoPriorTemporalAccessInformationKey_97(HandleRef pThis);

		/// <summary>
		/// Set to all output ports of this algorithm the information key
		/// `vtkStreamingDemandDrivenPipeline::NO_PRIOR_TEMPORAL_ACCESS()`. This should
		/// be set on sources of pipelines for which all timesteps are not necessarily
		/// all available at once. This is typically the case for visualization in situ.
		///
		/// @note Default value in `vtkStreamingDemandDrivenPipeline::NO_PRIOR_TEMPORAL_ACCESS_RESET`.
		/// `vtkStreamingDemandDrivenPipeline` will set it to `NO_PRIOR_TEMPORAL_ACCESS_CONTINUE' after
		/// execution of the first time step.
		/// </summary>
		// Token: 0x0600046E RID: 1134 RVA: 0x0000DCAF File Offset: 0x0000BEAF
		public void SetNoPriorTemporalAccessInformationKey()
		{
			vtkAlgorithm.vtkAlgorithm_SetNoPriorTemporalAccessInformationKey_97(base.GetCppThis());
		}

		// Token: 0x0600046F RID: 1135
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetProgressObserver_98(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// If an ProgressObserver is set, the algorithm will report
		/// progress through it rather than directly. This means that
		/// it will call UpdateProgress() on the ProgressObserver rather
		/// than itself report it and set progress.
		/// This is most useful in situations where multiple threads
		/// are executing an algorithm at the same time and want to
		/// handle progress locally.
		/// </summary>
		// Token: 0x06000470 RID: 1136 RVA: 0x0000DCC0 File Offset: 0x0000BEC0
		public void SetProgressObserver(vtkProgressObserver arg0)
		{
			vtkAlgorithm.vtkAlgorithm_SetProgressObserver_98(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000471 RID: 1137
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetProgressShiftScale_99(HandleRef pThis, double shift, double scale);

		/// <summary>
		/// Specify the shift and scale values to use to apply to the progress amount
		/// when `UpdateProgress` is called. By default shift is set to 0, and scale is
		/// set to 1.0. This is useful when the vtkAlgorithm instance is used as an
		/// internal algorithm to solve only a part of a whole problem.
		///
		/// If calling on a internal vtkAlgorithm, make sure you take into
		/// consideration that values set of the outer vtkAlgorithm as well since the
		/// outer vtkAlgorithm itself may be nested in another algorithm.
		///
		/// @note SetProgressShiftScale does not modify the MTime of the algorithm.
		/// </summary>
		// Token: 0x06000472 RID: 1138 RVA: 0x0000DCEF File Offset: 0x0000BEEF
		public void SetProgressShiftScale(double shift, double scale)
		{
			vtkAlgorithm.vtkAlgorithm_SetProgressShiftScale_99(base.GetCppThis(), shift, scale);
		}

		// Token: 0x06000473 RID: 1139
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetProgressText_100(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string ptext);

		/// <summary>
		/// Set the current text message associated with the progress state.
		/// This may be used by a calling process/GUI.
		/// Note: Because SetProgressText() is called from inside RequestData()
		/// it does not modify the algorithm object. Algorithms are not
		/// allowed to modify themselves from inside RequestData().
		/// </summary>
		// Token: 0x06000474 RID: 1140 RVA: 0x0000DD00 File Offset: 0x0000BF00
		public void SetProgressText(string ptext)
		{
			vtkAlgorithm.vtkAlgorithm_SetProgressText_100(base.GetCppThis(), ptext);
		}

		// Token: 0x06000475 RID: 1141
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_SetReleaseDataFlag_101(HandleRef pThis, int arg0);

		/// <summary>
		/// Turn release data flag on or off for all output ports.
		/// </summary>
		// Token: 0x06000476 RID: 1142 RVA: 0x0000DD10 File Offset: 0x0000BF10
		public virtual void SetReleaseDataFlag(int arg0)
		{
			vtkAlgorithm.vtkAlgorithm_SetReleaseDataFlag_101(base.GetCppThis(), arg0);
		}

		// Token: 0x06000477 RID: 1143
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_Update_102(HandleRef pThis, int port, HandleRef requests);

		/// <summary>
		/// This method enables the passing of data requests to the algorithm
		/// to be used during execution (in addition to bringing a particular
		/// port up-to-date). The requests argument should contain an information
		/// object for each port that requests need to be passed. For each
		/// of those, the pipeline will copy all keys to the output information
		/// before execution. This is equivalent to:
		/// \verbatim
		/// algorithm-&gt;UpdateInformation();
		/// for (int i=0; i&lt;algorithm-&gt;GetNumberOfOutputPorts(); i++)
		/// {
		/// vtkInformation* portRequests = requests-&gt;GetInformationObject(i);
		/// if (portRequests)
		/// {
		/// algorithm-&gt;GetOutputInformation(i)-&gt;Append(portRequests);
		/// }
		/// }
		/// algorithm-&gt;Update();
		/// \endverbatim
		/// Available requests include UPDATE_PIECE_NUMBER(), UPDATE_NUMBER_OF_PIECES()
		/// UPDATE_EXTENT() etc etc.
		/// </summary>
		// Token: 0x06000478 RID: 1144 RVA: 0x0000DD20 File Offset: 0x0000BF20
		public virtual int Update(int port, vtkInformationVector requests)
		{
			return vtkAlgorithm.vtkAlgorithm_Update_102(base.GetCppThis(), port, (requests == null) ? default(HandleRef) : requests.GetCppThis());
		}

		// Token: 0x06000479 RID: 1145
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_Update_103(HandleRef pThis, HandleRef requests);

		/// <summary>
		/// Convenience method to update an algorithm after passing requests
		/// to its first output port. See documentation for
		/// Update(int port, vtkInformationVector* requests) for details.
		/// </summary>
		// Token: 0x0600047A RID: 1146 RVA: 0x0000DD58 File Offset: 0x0000BF58
		public virtual int Update(vtkInformation requests)
		{
			return vtkAlgorithm.vtkAlgorithm_Update_103(base.GetCppThis(), (requests == null) ? default(HandleRef) : requests.GetCppThis());
		}

		// Token: 0x0600047B RID: 1147
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_Update_104(HandleRef pThis, int port);

		/// <summary>
		/// Bring this algorithm's outputs up-to-date.
		/// </summary>
		// Token: 0x0600047C RID: 1148 RVA: 0x0000DD8C File Offset: 0x0000BF8C
		public virtual void Update(int port)
		{
			vtkAlgorithm.vtkAlgorithm_Update_104(base.GetCppThis(), port);
		}

		// Token: 0x0600047D RID: 1149
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_Update_105(HandleRef pThis);

		/// <summary>
		/// Bring this algorithm's outputs up-to-date.
		/// </summary>
		// Token: 0x0600047E RID: 1150 RVA: 0x0000DD9C File Offset: 0x0000BF9C
		public virtual void Update()
		{
			vtkAlgorithm.vtkAlgorithm_Update_105(base.GetCppThis());
		}

		// Token: 0x0600047F RID: 1151
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_UpdateDataObject_106(HandleRef pThis);

		/// <summary>
		/// Create output object(s).
		/// </summary>
		// Token: 0x06000480 RID: 1152 RVA: 0x0000DDAB File Offset: 0x0000BFAB
		public virtual void UpdateDataObject()
		{
			vtkAlgorithm.vtkAlgorithm_UpdateDataObject_106(base.GetCppThis());
		}

		// Token: 0x06000481 RID: 1153
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_UpdateExtent_107(HandleRef pThis, IntPtr extents);

		/// <summary>
		/// Convenience method to update an algorithm after passing requests
		/// to its first output port.
		/// Supports extent request.
		/// </summary>
		// Token: 0x06000482 RID: 1154 RVA: 0x0000DDBC File Offset: 0x0000BFBC
		public virtual int UpdateExtent(IntPtr extents)
		{
			return vtkAlgorithm.vtkAlgorithm_UpdateExtent_107(base.GetCppThis(), extents);
		}

		// Token: 0x06000483 RID: 1155
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_UpdateExtentIsEmpty_108(HandleRef pThis, HandleRef pinfo, HandleRef output);

		/// <summary>
		/// This detects when the UpdateExtent will generate no data
		/// This condition is satisfied when the UpdateExtent has
		/// zero volume (0,-1,...) or the UpdateNumberOfPieces is 0.
		/// The source uses this call to determine whether to call Execute.
		/// </summary>
		// Token: 0x06000484 RID: 1156 RVA: 0x0000DDDC File Offset: 0x0000BFDC
		public int UpdateExtentIsEmpty(vtkInformation pinfo, vtkDataObject output)
		{
			return vtkAlgorithm.vtkAlgorithm_UpdateExtentIsEmpty_108(base.GetCppThis(), (pinfo == null) ? default(HandleRef) : pinfo.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06000485 RID: 1157
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_UpdateExtentIsEmpty_109(HandleRef pThis, HandleRef pinfo, int extentType);

		/// <summary>
		/// This detects when the UpdateExtent will generate no data
		/// This condition is satisfied when the UpdateExtent has
		/// zero volume (0,-1,...) or the UpdateNumberOfPieces is 0.
		/// The source uses this call to determine whether to call Execute.
		/// </summary>
		// Token: 0x06000486 RID: 1158 RVA: 0x0000DE28 File Offset: 0x0000C028
		public int UpdateExtentIsEmpty(vtkInformation pinfo, int extentType)
		{
			return vtkAlgorithm.vtkAlgorithm_UpdateExtentIsEmpty_109(base.GetCppThis(), (pinfo == null) ? default(HandleRef) : pinfo.GetCppThis(), extentType);
		}

		// Token: 0x06000487 RID: 1159
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_UpdateInformation_110(HandleRef pThis);

		/// <summary>
		/// Bring the algorithm's information up-to-date.
		/// </summary>
		// Token: 0x06000488 RID: 1160 RVA: 0x0000DE5D File Offset: 0x0000C05D
		public virtual void UpdateInformation()
		{
			vtkAlgorithm.vtkAlgorithm_UpdateInformation_110(base.GetCppThis());
		}

		// Token: 0x06000489 RID: 1161
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_UpdatePiece_111(HandleRef pThis, int piece, int numPieces, int ghostLevels, IntPtr extents);

		/// <summary>
		/// Convenience method to update an algorithm after passing requests
		/// to its first output port. See documentation for
		/// Update(int port, vtkInformationVector* requests) for details.
		/// Supports piece and extent (optional) requests.
		/// </summary>
		// Token: 0x0600048A RID: 1162 RVA: 0x0000DE6C File Offset: 0x0000C06C
		public virtual int UpdatePiece(int piece, int numPieces, int ghostLevels, IntPtr extents)
		{
			return vtkAlgorithm.vtkAlgorithm_UpdatePiece_111(base.GetCppThis(), piece, numPieces, ghostLevels, extents);
		}

		// Token: 0x0600048B RID: 1163
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_UpdateProgress_112(HandleRef pThis, double amount);

		/// <summary>
		/// Update the progress of the process object. If a ProgressMethod exists,
		/// executes it.  Then set the Progress ivar to amount. The parameter amount
		/// should range between (0,1).
		/// </summary>
		// Token: 0x0600048C RID: 1164 RVA: 0x0000DE90 File Offset: 0x0000C090
		public void UpdateProgress(double amount)
		{
			vtkAlgorithm.vtkAlgorithm_UpdateProgress_112(base.GetCppThis(), amount);
		}

		// Token: 0x0600048D RID: 1165
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAlgorithm_UpdateTimeStep_113(HandleRef pThis, double time, int piece, int numPieces, int ghostLevels, IntPtr extents);

		/// <summary>
		/// Convenience method to update an algorithm after passing requests
		/// to its first output port. See documentation for
		/// Update(int port, vtkInformationVector* requests) for details.
		/// Supports time, piece (optional) and extent (optional) requests.
		/// </summary>
		// Token: 0x0600048E RID: 1166 RVA: 0x0000DEA0 File Offset: 0x0000C0A0
		public virtual int UpdateTimeStep(double time, int piece, int numPieces, int ghostLevels, IntPtr extents)
		{
			return vtkAlgorithm.vtkAlgorithm_UpdateTimeStep_113(base.GetCppThis(), time, piece, numPieces, ghostLevels, extents);
		}

		// Token: 0x0600048F RID: 1167
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAlgorithm_UpdateWholeExtent_114(HandleRef pThis);

		/// <summary>
		/// Bring this algorithm's outputs up-to-date.
		/// </summary>
		// Token: 0x06000490 RID: 1168 RVA: 0x0000DEC6 File Offset: 0x0000C0C6
		public virtual void UpdateWholeExtent()
		{
			vtkAlgorithm.vtkAlgorithm_UpdateWholeExtent_114(base.GetCppThis());
		}

		// Token: 0x06000491 RID: 1169
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAlgorithm_UsesGarbageCollector_115(HandleRef pThis);

		/// <summary>
		/// Participate in garbage collection.
		/// </summary>
		// Token: 0x06000492 RID: 1170 RVA: 0x0000DED8 File Offset: 0x0000C0D8
		public override bool UsesGarbageCollector()
		{
			return vtkAlgorithm.vtkAlgorithm_UsesGarbageCollector_115(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000344 RID: 836
		public new const string MRFullTypeName = "Kitware.VTK.vtkAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000345 RID: 837
		public new static readonly string MRClassNameKey = "class vtkAlgorithm";

		/// <summary>
		/// Values used for setting the desired output precision for various
		/// algorithms. Currently, the following algorithms support changing their
		/// output precision: vtkAppendPolyData, vtkCleanPolyData, vtkClipPolyData,
		/// vtkConnectivityFilter, vtkDecimatePolylineFilter, vtkDecimatePro, vtkDelaunay3D,
		/// vtkFeatureEdges, vtkGlyph3D, vtkHedgeHog, vtkMaskPoints, vtkPolyDataConnectivityFilter,
		/// vtkSmoothPolyDataFilter, vtkStaticCleanPolyData, vtkThresholdPoints, vtkTubeFilter,
		/// vtkAppendPoints, vtkTransformFilter, vtkTransformPolyDataFilter,
		/// vtkLinearToQuadraticCellsFilter, vtkProcrustesAlignmentFilter,
		/// vtkAdaptiveSubdivisionFilter, vtkBoundedPointSource, vtkArcSource, vtkConeSource,
		/// vtkCubeSource, vtkCylinderSource, vtkDiskSource, vtkEllipseArcSource,
		/// vtkEllipticalButtonSource, vtkFrustumSource, vtkGlyphSource2D, vtkLineSource,
		/// vtkOutlineSource, vtkParametricFunctionSource, vtkPlaneSource, vtkPlatonicSolidSource,
		/// vtkPointSource, vtkRectangularButtonSource, vtkRegularPolygonSource, vtkSphereSource,
		/// vtkSuperquadricSource, vtkTessellatedBoxSource, vtkTextSource, vtkTexturedSphereSource,
		/// vtkImageToPoints, vtkDepthImageToPointCloud.
		/// SINGLE_PRECISION - Output single-precision floating-point (i.e. float)
		/// DOUBLE_PRECISION - Output double-precision floating-point (i.e. double)
		/// DEFAULT_PRECISION - Output precision should match the input precision.
		/// </summary>
		// Token: 0x0200001E RID: 30
		public enum DesiredOutputPrecision
		{
			/// <summary>enum member</summary>
			// Token: 0x04000347 RID: 839
			DEFAULT_PRECISION = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000348 RID: 840
			DOUBLE_PRECISION = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000349 RID: 841
			SINGLE_PRECISION = 0
		}
	}
}
