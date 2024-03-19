using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce only graph as output
	///
	///
	/// vtkGraphAlgorithm is a convenience class to make writing algorithms
	/// easier. It is also designed to help transition old algorithms to the new
	/// pipeline architecture. There are some assumptions and defaults made by this
	/// class you should be aware of. This class defaults such that your filter
	/// will have one input port and one output port. If that is not the case
	/// simply change it with SetNumberOfInputPorts etc. See this class
	/// constructor for the default. This class also provides a FillInputPortInfo
	/// method that by default says that all inputs will be Graph. If that
	/// isn't the case then please override this method in your subclass.
	/// You should implement the subclass's algorithm into
	/// RequestData( request, inputVec, outputVec).
	///
	/// @par Thanks:
	/// Thanks to Patricia Crossno, Ken Moreland, Andrew Wilson and Brian Wylie from
	/// Sandia National Laboratories for their help in developing this class.
	/// </remarks>
	// Token: 0x02000199 RID: 409
	public class vtkGraphAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600505B RID: 20571 RVA: 0x00074984 File Offset: 0x00072B84
		static vtkGraphAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600505C RID: 20572 RVA: 0x000749AC File Offset: 0x00072BAC
		public vtkGraphAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600505D RID: 20573
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600505E RID: 20574 RVA: 0x000749BC File Offset: 0x00072BBC
		public new static vtkGraphAlgorithm New()
		{
			vtkGraphAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphAlgorithm.vtkGraphAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600505F RID: 20575 RVA: 0x00074A10 File Offset: 0x00072C10
		public vtkGraphAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGraphAlgorithm.vtkGraphAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005060 RID: 20576 RVA: 0x00074A54 File Offset: 0x00072C54
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005061 RID: 20577
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005062 RID: 20578 RVA: 0x00074A60 File Offset: 0x00072C60
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphAlgorithm.vtkGraphAlgorithm_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06005063 RID: 20579
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphAlgorithm_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005064 RID: 20580 RVA: 0x00074A80 File Offset: 0x00072C80
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphAlgorithm.vtkGraphAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06005065 RID: 20581
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06005066 RID: 20582 RVA: 0x00074A9C File Offset: 0x00072C9C
		public vtkGraph GetOutput()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphAlgorithm.vtkGraphAlgorithm_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		// Token: 0x06005067 RID: 20583
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphAlgorithm_GetOutput_04(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06005068 RID: 20584 RVA: 0x00074B0C File Offset: 0x00072D0C
		public vtkGraph GetOutput(int index)
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphAlgorithm.vtkGraphAlgorithm_GetOutput_04(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		// Token: 0x06005069 RID: 20585
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphAlgorithm_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600506A RID: 20586 RVA: 0x00074B7C File Offset: 0x00072D7C
		public override int IsA(string type)
		{
			return vtkGraphAlgorithm.vtkGraphAlgorithm_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600506B RID: 20587
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphAlgorithm_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600506C RID: 20588 RVA: 0x00074B9C File Offset: 0x00072D9C
		public new static int IsTypeOf(string type)
		{
			return vtkGraphAlgorithm.vtkGraphAlgorithm_IsTypeOf_06(type);
		}

		// Token: 0x0600506D RID: 20589
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphAlgorithm_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600506E RID: 20590 RVA: 0x00074BB8 File Offset: 0x00072DB8
		public new vtkGraphAlgorithm NewInstance()
		{
			vtkGraphAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphAlgorithm.vtkGraphAlgorithm_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600506F RID: 20591
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphAlgorithm_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005070 RID: 20592 RVA: 0x00074C14 File Offset: 0x00072E14
		public new static vtkGraphAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkGraphAlgorithm vtkGraphAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphAlgorithm.vtkGraphAlgorithm_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphAlgorithm = (vtkGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphAlgorithm.Register(null);
				}
			}
			return vtkGraphAlgorithm;
		}

		// Token: 0x06005071 RID: 20593
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphAlgorithm_SetInputData_10(HandleRef pThis, HandleRef obj);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06005072 RID: 20594 RVA: 0x00074C94 File Offset: 0x00072E94
		public void SetInputData(vtkDataObject obj)
		{
			vtkGraphAlgorithm.vtkGraphAlgorithm_SetInputData_10(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		// Token: 0x06005073 RID: 20595
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphAlgorithm_SetInputData_11(HandleRef pThis, int index, HandleRef obj);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06005074 RID: 20596 RVA: 0x00074CC4 File Offset: 0x00072EC4
		public void SetInputData(int index, vtkDataObject obj)
		{
			vtkGraphAlgorithm.vtkGraphAlgorithm_SetInputData_11(base.GetCppThis(), index, (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000795 RID: 1941
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000796 RID: 1942
		public new static readonly string MRClassNameKey = "class vtkGraphAlgorithm";
	}
}
