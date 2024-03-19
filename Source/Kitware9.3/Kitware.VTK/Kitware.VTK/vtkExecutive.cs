using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExecutive
	/// </summary>
	/// <remarks>
	///    Superclass for all pipeline executives in VTK.
	///
	/// vtkExecutive is the superclass for all pipeline executives in VTK.
	/// A VTK executive is responsible for controlling one instance of
	/// vtkAlgorithm.  A pipeline consists of one or more executives that
	/// control data flow.  Every reader, source, writer, or data
	/// processing algorithm in the pipeline is implemented in an instance
	/// of vtkAlgorithm.
	/// </remarks>
	// Token: 0x0200077F RID: 1919
	public abstract class vtkExecutive : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013BA7 RID: 80807 RVA: 0x001BD4DD File Offset: 0x001BB6DD
		static vtkExecutive()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExecutive.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExecutive"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013BA8 RID: 80808 RVA: 0x001BD505 File Offset: 0x001BB705
		public vtkExecutive(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013BA9 RID: 80809 RVA: 0x001BD513 File Offset: 0x001BB713
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013BAA RID: 80810
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_ALGORITHM_AFTER_FORWARD_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Keys to program vtkExecutive::ProcessRequest with the default
		/// behavior for unknown requests.
		/// </summary>
		// Token: 0x06013BAB RID: 80811 RVA: 0x001BD520 File Offset: 0x001BB720
		public static vtkInformationIntegerKey ALGORITHM_AFTER_FORWARD()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_ALGORITHM_AFTER_FORWARD_01(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013BAC RID: 80812
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_ALGORITHM_BEFORE_FORWARD_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Keys to program vtkExecutive::ProcessRequest with the default
		/// behavior for unknown requests.
		/// </summary>
		// Token: 0x06013BAD RID: 80813 RVA: 0x001BD58C File Offset: 0x001BB78C
		public static vtkInformationIntegerKey ALGORITHM_BEFORE_FORWARD()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_ALGORITHM_BEFORE_FORWARD_02(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013BAE RID: 80814
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_ALGORITHM_DIRECTION_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Keys to program vtkExecutive::ProcessRequest with the default
		/// behavior for unknown requests.
		/// </summary>
		// Token: 0x06013BAF RID: 80815 RVA: 0x001BD5F8 File Offset: 0x001BB7F8
		public static vtkInformationIntegerKey ALGORITHM_DIRECTION()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_ALGORITHM_DIRECTION_03(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013BB0 RID: 80816
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_CONSUMERS_04(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Information key to store the executive/port number pairs
		/// consuming an information object.
		/// </summary>
		// Token: 0x06013BB1 RID: 80817 RVA: 0x001BD664 File Offset: 0x001BB864
		public static vtkInformationExecutivePortVectorKey CONSUMERS()
		{
			vtkInformationExecutivePortVectorKey vtkInformationExecutivePortVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_CONSUMERS_04(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationExecutivePortVectorKey = (vtkInformationExecutivePortVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationExecutivePortVectorKey.Register(null);
				}
			}
			return vtkInformationExecutivePortVectorKey;
		}

		// Token: 0x06013BB2 RID: 80818
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_FORWARD_DIRECTION_05(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Keys to program vtkExecutive::ProcessRequest with the default
		/// behavior for unknown requests.
		/// </summary>
		// Token: 0x06013BB3 RID: 80819 RVA: 0x001BD6D0 File Offset: 0x001BB8D0
		public static vtkInformationIntegerKey FORWARD_DIRECTION()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_FORWARD_DIRECTION_05(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013BB4 RID: 80820
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_FROM_OUTPUT_PORT_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Information key to store the output port number from which a
		/// request is made.
		/// </summary>
		// Token: 0x06013BB5 RID: 80821 RVA: 0x001BD73C File Offset: 0x001BB93C
		public static vtkInformationIntegerKey FROM_OUTPUT_PORT()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_FROM_OUTPUT_PORT_06(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013BB6 RID: 80822
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_GetAlgorithm_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the algorithm to which this executive has been assigned.
		/// </summary>
		// Token: 0x06013BB7 RID: 80823 RVA: 0x001BD7A8 File Offset: 0x001BB9A8
		public vtkAlgorithm GetAlgorithm()
		{
			vtkAlgorithm vtkAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_GetAlgorithm_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013BB8 RID: 80824
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_GetInputData_08(HandleRef pThis, int port, int connection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data object for an input port of the algorithm.
		/// </summary>
		// Token: 0x06013BB9 RID: 80825 RVA: 0x001BD818 File Offset: 0x001BBA18
		public virtual vtkDataObject GetInputData(int port, int connection)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_GetInputData_08(base.GetCppThis(), port, connection, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013BBA RID: 80826
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_GetInputExecutive_09(HandleRef pThis, int port, int connection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the executive managing the given input connection.
		/// </summary>
		// Token: 0x06013BBB RID: 80827 RVA: 0x001BD88C File Offset: 0x001BBA8C
		public vtkExecutive GetInputExecutive(int port, int connection)
		{
			vtkExecutive vtkExecutive = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_GetInputExecutive_09(base.GetCppThis(), port, connection, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013BBC RID: 80828
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_GetInputInformation_10(HandleRef pThis, int port, int connection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the pipeline information for the given input connection.
		/// </summary>
		// Token: 0x06013BBD RID: 80829 RVA: 0x001BD900 File Offset: 0x001BBB00
		public vtkInformation GetInputInformation(int port, int connection)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_GetInputInformation_10(base.GetCppThis(), port, connection, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013BBE RID: 80830
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_GetInputInformation_11(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the pipeline information vectors for the given input port.
		/// </summary>
		// Token: 0x06013BBF RID: 80831 RVA: 0x001BD974 File Offset: 0x001BBB74
		public vtkInformationVector GetInputInformation(int port)
		{
			vtkInformationVector vtkInformationVector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_GetInputInformation_11(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationVector = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationVector.Register(null);
				}
			}
			return vtkInformationVector;
		}

		// Token: 0x06013BC0 RID: 80832
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExecutive_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013BC1 RID: 80833 RVA: 0x001BD9E4 File Offset: 0x001BBBE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExecutive.vtkExecutive_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06013BC2 RID: 80834
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExecutive_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013BC3 RID: 80835 RVA: 0x001BDA04 File Offset: 0x001BBC04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExecutive.vtkExecutive_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06013BC4 RID: 80836
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExecutive_GetNumberOfInputConnections_14(HandleRef pThis, int port);

		/// <summary>
		/// Get the number of input connections on the given port.
		/// </summary>
		// Token: 0x06013BC5 RID: 80837 RVA: 0x001BDA20 File Offset: 0x001BBC20
		public int GetNumberOfInputConnections(int port)
		{
			return vtkExecutive.vtkExecutive_GetNumberOfInputConnections_14(base.GetCppThis(), port);
		}

		// Token: 0x06013BC6 RID: 80838
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExecutive_GetNumberOfInputPorts_15(HandleRef pThis);

		/// <summary>
		/// Get the number of input/output ports for the algorithm associated
		/// with this executive.  Returns 0 if no algorithm is set.
		/// </summary>
		// Token: 0x06013BC7 RID: 80839 RVA: 0x001BDA40 File Offset: 0x001BBC40
		public int GetNumberOfInputPorts()
		{
			return vtkExecutive.vtkExecutive_GetNumberOfInputPorts_15(base.GetCppThis());
		}

		// Token: 0x06013BC8 RID: 80840
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExecutive_GetNumberOfOutputPorts_16(HandleRef pThis);

		/// <summary>
		/// Get the number of input/output ports for the algorithm associated
		/// with this executive.  Returns 0 if no algorithm is set.
		/// </summary>
		// Token: 0x06013BC9 RID: 80841 RVA: 0x001BDA60 File Offset: 0x001BBC60
		public int GetNumberOfOutputPorts()
		{
			return vtkExecutive.vtkExecutive_GetNumberOfOutputPorts_16(base.GetCppThis());
		}

		// Token: 0x06013BCA RID: 80842
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_GetOutputData_17(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the data object for an output port of the algorithm.
		/// </summary>
		// Token: 0x06013BCB RID: 80843 RVA: 0x001BDA80 File Offset: 0x001BBC80
		public virtual vtkDataObject GetOutputData(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_GetOutputData_17(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013BCC RID: 80844
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_GetOutputInformation_18(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the pipeline information object for the given output port.
		/// </summary>
		// Token: 0x06013BCD RID: 80845 RVA: 0x001BDAF0 File Offset: 0x001BBCF0
		public virtual vtkInformation GetOutputInformation(int port)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_GetOutputInformation_18(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013BCE RID: 80846
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_GetOutputInformation_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the pipeline information object for all output ports.
		/// </summary>
		// Token: 0x06013BCF RID: 80847 RVA: 0x001BDB60 File Offset: 0x001BBD60
		public vtkInformationVector GetOutputInformation()
		{
			vtkInformationVector vtkInformationVector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_GetOutputInformation_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationVector = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationVector.Register(null);
				}
			}
			return vtkInformationVector;
		}

		// Token: 0x06013BD0 RID: 80848
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExecutive_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013BD1 RID: 80849 RVA: 0x001BDBD0 File Offset: 0x001BBDD0
		public override int IsA(string type)
		{
			return vtkExecutive.vtkExecutive_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x06013BD2 RID: 80850
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExecutive_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013BD3 RID: 80851 RVA: 0x001BDBF0 File Offset: 0x001BBDF0
		public new static int IsTypeOf(string type)
		{
			return vtkExecutive.vtkExecutive_IsTypeOf_21(type);
		}

		// Token: 0x06013BD4 RID: 80852
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_KEYS_TO_COPY_22(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Keys to program vtkExecutive::ProcessRequest with the default
		/// behavior for unknown requests.
		/// </summary>
		// Token: 0x06013BD5 RID: 80853 RVA: 0x001BDC0C File Offset: 0x001BBE0C
		public static vtkInformationKeyVectorKey KEYS_TO_COPY()
		{
			vtkInformationKeyVectorKey vtkInformationKeyVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_KEYS_TO_COPY_22(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKeyVectorKey = (vtkInformationKeyVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKeyVectorKey.Register(null);
				}
			}
			return vtkInformationKeyVectorKey;
		}

		// Token: 0x06013BD6 RID: 80854
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013BD7 RID: 80855 RVA: 0x001BDC78 File Offset: 0x001BBE78
		public new vtkExecutive NewInstance()
		{
			vtkExecutive result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExecutive)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013BD8 RID: 80856
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_PRODUCER_24(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Information key to store the executive/port number producing an
		/// information object.
		/// </summary>
		// Token: 0x06013BD9 RID: 80857 RVA: 0x001BDCD4 File Offset: 0x001BBED4
		public static vtkInformationExecutivePortKey PRODUCER()
		{
			vtkInformationExecutivePortKey vtkInformationExecutivePortKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_PRODUCER_24(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationExecutivePortKey = (vtkInformationExecutivePortKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationExecutivePortKey.Register(null);
				}
			}
			return vtkInformationExecutivePortKey;
		}

		// Token: 0x06013BDA RID: 80858
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutive_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013BDB RID: 80859 RVA: 0x001BDD40 File Offset: 0x001BBF40
		public new static vtkExecutive SafeDownCast(vtkObjectBase o)
		{
			vtkExecutive vtkExecutive = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutive.vtkExecutive_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013BDC RID: 80860
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExecutive_SetOutputData_26(HandleRef pThis, int port, HandleRef arg1, HandleRef info);

		/// <summary>
		/// Get/Set the data object for an output port of the algorithm.
		/// </summary>
		// Token: 0x06013BDD RID: 80861 RVA: 0x001BDDC0 File Offset: 0x001BBFC0
		public virtual void SetOutputData(int port, vtkDataObject arg1, vtkInformation info)
		{
			vtkExecutive.vtkExecutive_SetOutputData_26(base.GetCppThis(), port, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x06013BDE RID: 80862
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExecutive_SetOutputData_27(HandleRef pThis, int port, HandleRef arg1);

		/// <summary>
		/// Get/Set the data object for an output port of the algorithm.
		/// </summary>
		// Token: 0x06013BDF RID: 80863 RVA: 0x001BDE08 File Offset: 0x001BC008
		public virtual void SetOutputData(int port, vtkDataObject arg1)
		{
			vtkExecutive.vtkExecutive_SetOutputData_27(base.GetCppThis(), port, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06013BE0 RID: 80864
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExecutive_SetSharedOutputInformation_28(HandleRef pThis, HandleRef outInfoVec);

		/// <summary>
		/// Set a pointer to an outside instance of input or output
		/// information vectors.  No references are held to the given
		/// vectors, and setting this does not change the executive object
		/// modification time.  This is a preliminary interface to use in
		/// implementing filters with internal pipelines, and may change
		/// without notice when a future interface is created.
		/// </summary>
		// Token: 0x06013BE1 RID: 80865 RVA: 0x001BDE38 File Offset: 0x001BC038
		public void SetSharedOutputInformation(vtkInformationVector outInfoVec)
		{
			vtkExecutive.vtkExecutive_SetSharedOutputInformation_28(base.GetCppThis(), (outInfoVec == null) ? default(HandleRef) : outInfoVec.GetCppThis());
		}

		// Token: 0x06013BE2 RID: 80866
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExecutive_Update_29(HandleRef pThis);

		/// <summary>
		/// Bring the algorithm's outputs up-to-date.  Returns 1 for success
		/// and 0 for failure.
		/// </summary>
		// Token: 0x06013BE3 RID: 80867 RVA: 0x001BDE68 File Offset: 0x001BC068
		public virtual int Update()
		{
			return vtkExecutive.vtkExecutive_Update_29(base.GetCppThis());
		}

		// Token: 0x06013BE4 RID: 80868
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExecutive_Update_30(HandleRef pThis, int port);

		/// <summary>
		/// Bring the algorithm's outputs up-to-date.  Returns 1 for success
		/// and 0 for failure.
		/// </summary>
		// Token: 0x06013BE5 RID: 80869 RVA: 0x001BDE88 File Offset: 0x001BC088
		public virtual int Update(int port)
		{
			return vtkExecutive.vtkExecutive_Update_30(base.GetCppThis(), port);
		}

		// Token: 0x06013BE6 RID: 80870
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExecutive_UpdateInformation_31(HandleRef pThis);

		/// <summary>
		/// Bring the output information up to date.
		/// </summary>
		// Token: 0x06013BE7 RID: 80871 RVA: 0x001BDEA8 File Offset: 0x001BC0A8
		public virtual int UpdateInformation()
		{
			return vtkExecutive.vtkExecutive_UpdateInformation_31(base.GetCppThis());
		}

		// Token: 0x06013BE8 RID: 80872
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExecutive_UsesGarbageCollector_32(HandleRef pThis);

		/// <summary>
		/// Participate in garbage collection.
		/// </summary>
		// Token: 0x06013BE9 RID: 80873 RVA: 0x001BDEC8 File Offset: 0x001BC0C8
		public override bool UsesGarbageCollector()
		{
			return vtkExecutive.vtkExecutive_UsesGarbageCollector_32(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016AD RID: 5805
		public new const string MRFullTypeName = "Kitware.VTK.vtkExecutive";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016AE RID: 5806
		public new static readonly string MRClassNameKey = "class vtkExecutive";

		/// <summary>
		/// Keys to program vtkExecutive::ProcessRequest with the default
		/// behavior for unknown requests.
		/// </summary>
		// Token: 0x02000780 RID: 1920
		public enum RequestDownstream_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040016B0 RID: 5808
			RequestDownstream = 1,
			/// <summary>enum member</summary>
			// Token: 0x040016B1 RID: 5809
			RequestUpstream = 0
		}

		/// <summary>
		/// Keys to program vtkExecutive::ProcessRequest with the default
		/// behavior for unknown requests.
		/// </summary>
		// Token: 0x02000781 RID: 1921
		public enum AfterForward_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040016B3 RID: 5811
			AfterForward = 1,
			/// <summary>enum member</summary>
			// Token: 0x040016B4 RID: 5812
			BeforeForward = 0
		}
	}
}
