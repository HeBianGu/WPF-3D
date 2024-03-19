using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDirectedGraphAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce only directed graph as output
	///
	///
	/// vtkDirectedGraphAlgorithm is a convenience class to make writing algorithms
	/// easier. It is also designed to help transition old algorithms to the new
	/// pipeline edgehitecture. There are some assumptions and defaults made by this
	/// class you should be aware of. This class defaults such that your filter
	/// will have one input port and one output port. If that is not the case
	/// simply change it with SetNumberOfInputPorts etc. See this class
	/// constructor for the default. This class also provides a FillInputPortInfo
	/// method that by default says that all inputs will be Graph. If that
	/// isn't the case then please override this method in your subclass.
	/// You should implement the subclass's algorithm into
	/// RequestData( request, inputVec, outputVec).
	///
	///
	/// @par Thanks:
	/// Thanks to Patricia Crossno, Ken Moreland, Andrew Wilson and Brian Wylie from
	/// Sandia National Laboratories for their help in developing this class.
	/// </remarks>
	// Token: 0x02000688 RID: 1672
	public class vtkDirectedGraphAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011F3B RID: 73531 RVA: 0x001921B7 File Offset: 0x001903B7
		static vtkDirectedGraphAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDirectedGraphAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDirectedGraphAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011F3C RID: 73532 RVA: 0x001921DF File Offset: 0x001903DF
		public vtkDirectedGraphAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011F3D RID: 73533
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectedGraphAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F3E RID: 73534 RVA: 0x001921F0 File Offset: 0x001903F0
		public new static vtkDirectedGraphAlgorithm New()
		{
			vtkDirectedGraphAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDirectedGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F3F RID: 73535 RVA: 0x00192244 File Offset: 0x00190444
		public vtkDirectedGraphAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011F40 RID: 73536 RVA: 0x00192288 File Offset: 0x00190488
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011F41 RID: 73537
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDirectedGraphAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F42 RID: 73538 RVA: 0x00192294 File Offset: 0x00190494
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06011F43 RID: 73539
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDirectedGraphAlgorithm_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F44 RID: 73540 RVA: 0x001922B4 File Offset: 0x001904B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06011F45 RID: 73541
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectedGraphAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06011F46 RID: 73542 RVA: 0x001922D0 File Offset: 0x001904D0
		public vtkDirectedGraph GetOutput()
		{
			vtkDirectedGraph vtkDirectedGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectedGraph = (vtkDirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectedGraph.Register(null);
				}
			}
			return vtkDirectedGraph;
		}

		// Token: 0x06011F47 RID: 73543
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectedGraphAlgorithm_GetOutput_04(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06011F48 RID: 73544 RVA: 0x00192340 File Offset: 0x00190540
		public vtkDirectedGraph GetOutput(int index)
		{
			vtkDirectedGraph vtkDirectedGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_GetOutput_04(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectedGraph = (vtkDirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectedGraph.Register(null);
				}
			}
			return vtkDirectedGraph;
		}

		// Token: 0x06011F49 RID: 73545
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectedGraphAlgorithm_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F4A RID: 73546 RVA: 0x001923B0 File Offset: 0x001905B0
		public override int IsA(string type)
		{
			return vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06011F4B RID: 73547
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectedGraphAlgorithm_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F4C RID: 73548 RVA: 0x001923D0 File Offset: 0x001905D0
		public new static int IsTypeOf(string type)
		{
			return vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_IsTypeOf_06(type);
		}

		// Token: 0x06011F4D RID: 73549
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectedGraphAlgorithm_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F4E RID: 73550 RVA: 0x001923EC File Offset: 0x001905EC
		public new vtkDirectedGraphAlgorithm NewInstance()
		{
			vtkDirectedGraphAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDirectedGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011F4F RID: 73551
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectedGraphAlgorithm_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F50 RID: 73552 RVA: 0x00192448 File Offset: 0x00190648
		public new static vtkDirectedGraphAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkDirectedGraphAlgorithm vtkDirectedGraphAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectedGraphAlgorithm = (vtkDirectedGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectedGraphAlgorithm.Register(null);
				}
			}
			return vtkDirectedGraphAlgorithm;
		}

		// Token: 0x06011F51 RID: 73553
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDirectedGraphAlgorithm_SetInputData_10(HandleRef pThis, HandleRef obj);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06011F52 RID: 73554 RVA: 0x001924C8 File Offset: 0x001906C8
		public void SetInputData(vtkDataObject obj)
		{
			vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_SetInputData_10(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		// Token: 0x06011F53 RID: 73555
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDirectedGraphAlgorithm_SetInputData_11(HandleRef pThis, int index, HandleRef obj);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06011F54 RID: 73556 RVA: 0x001924F8 File Offset: 0x001906F8
		public void SetInputData(int index, vtkDataObject obj)
		{
			vtkDirectedGraphAlgorithm.vtkDirectedGraphAlgorithm_SetInputData_11(base.GetCppThis(), index, (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014B9 RID: 5305
		public new const string MRFullTypeName = "Kitware.VTK.vtkDirectedGraphAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014BA RID: 5306
		public new static readonly string MRClassNameKey = "class vtkDirectedGraphAlgorithm";
	}
}
