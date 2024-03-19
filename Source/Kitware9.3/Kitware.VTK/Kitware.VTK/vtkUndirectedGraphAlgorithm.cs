using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUndirectedGraphAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce undirected graph as output
	///
	///
	/// vtkUndirectedGraphAlgorithm is a convenience class to make writing algorithms
	/// easier. It is also designed to help transition old algorithms to the new
	/// pipeline edgehitecture. There are some assumptions and defaults made by this
	/// class you should be aware of. This class defaults such that your filter
	/// will have one input port and one output port. If that is not the case
	/// simply change it with SetNumberOfInputPorts etc. See this class
	/// constructor for the default. This class also provides a FillInputPortInfo
	/// method that by default says that all inputs will be Graph. If that
	/// isn't the case then please override this method in your subclass.
	///
	/// @par Thanks:
	/// Thanks to Patricia Crossno, Ken Moreland, Andrew Wilson and Brian Wylie from
	/// Sandia National Laboratories for their help in developing this class.
	/// </remarks>
	// Token: 0x02000196 RID: 406
	public class vtkUndirectedGraphAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004F93 RID: 20371 RVA: 0x00073A4B File Offset: 0x00071C4B
		static vtkUndirectedGraphAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUndirectedGraphAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUndirectedGraphAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004F94 RID: 20372 RVA: 0x00073A73 File Offset: 0x00071C73
		public vtkUndirectedGraphAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004F95 RID: 20373
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUndirectedGraphAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F96 RID: 20374 RVA: 0x00073A84 File Offset: 0x00071C84
		public new static vtkUndirectedGraphAlgorithm New()
		{
			vtkUndirectedGraphAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUndirectedGraphAlgorithm.vtkUndirectedGraphAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUndirectedGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F97 RID: 20375 RVA: 0x00073AD8 File Offset: 0x00071CD8
		public vtkUndirectedGraphAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUndirectedGraphAlgorithm.vtkUndirectedGraphAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004F98 RID: 20376 RVA: 0x00073B1C File Offset: 0x00071D1C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004F99 RID: 20377
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUndirectedGraphAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F9A RID: 20378 RVA: 0x00073B28 File Offset: 0x00071D28
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUndirectedGraphAlgorithm.vtkUndirectedGraphAlgorithm_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06004F9B RID: 20379
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUndirectedGraphAlgorithm_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004F9C RID: 20380 RVA: 0x00073B48 File Offset: 0x00071D48
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUndirectedGraphAlgorithm.vtkUndirectedGraphAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06004F9D RID: 20381
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUndirectedGraphAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06004F9E RID: 20382 RVA: 0x00073B64 File Offset: 0x00071D64
		public vtkUndirectedGraph GetOutput()
		{
			vtkUndirectedGraph vtkUndirectedGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUndirectedGraphAlgorithm.vtkUndirectedGraphAlgorithm_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUndirectedGraph = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUndirectedGraph.Register(null);
				}
			}
			return vtkUndirectedGraph;
		}

		// Token: 0x06004F9F RID: 20383
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUndirectedGraphAlgorithm_GetOutput_04(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06004FA0 RID: 20384 RVA: 0x00073BD4 File Offset: 0x00071DD4
		public vtkUndirectedGraph GetOutput(int index)
		{
			vtkUndirectedGraph vtkUndirectedGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUndirectedGraphAlgorithm.vtkUndirectedGraphAlgorithm_GetOutput_04(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUndirectedGraph = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUndirectedGraph.Register(null);
				}
			}
			return vtkUndirectedGraph;
		}

		// Token: 0x06004FA1 RID: 20385
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUndirectedGraphAlgorithm_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004FA2 RID: 20386 RVA: 0x00073C44 File Offset: 0x00071E44
		public override int IsA(string type)
		{
			return vtkUndirectedGraphAlgorithm.vtkUndirectedGraphAlgorithm_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06004FA3 RID: 20387
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUndirectedGraphAlgorithm_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004FA4 RID: 20388 RVA: 0x00073C64 File Offset: 0x00071E64
		public new static int IsTypeOf(string type)
		{
			return vtkUndirectedGraphAlgorithm.vtkUndirectedGraphAlgorithm_IsTypeOf_06(type);
		}

		// Token: 0x06004FA5 RID: 20389
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUndirectedGraphAlgorithm_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004FA6 RID: 20390 RVA: 0x00073C80 File Offset: 0x00071E80
		public new vtkUndirectedGraphAlgorithm NewInstance()
		{
			vtkUndirectedGraphAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUndirectedGraphAlgorithm.vtkUndirectedGraphAlgorithm_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUndirectedGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004FA7 RID: 20391
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUndirectedGraphAlgorithm_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004FA8 RID: 20392 RVA: 0x00073CDC File Offset: 0x00071EDC
		public new static vtkUndirectedGraphAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkUndirectedGraphAlgorithm vtkUndirectedGraphAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUndirectedGraphAlgorithm.vtkUndirectedGraphAlgorithm_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUndirectedGraphAlgorithm = (vtkUndirectedGraphAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUndirectedGraphAlgorithm.Register(null);
				}
			}
			return vtkUndirectedGraphAlgorithm;
		}

		// Token: 0x06004FA9 RID: 20393
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUndirectedGraphAlgorithm_SetInputData_10(HandleRef pThis, HandleRef obj);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06004FAA RID: 20394 RVA: 0x00073D5C File Offset: 0x00071F5C
		public void SetInputData(vtkDataObject obj)
		{
			vtkUndirectedGraphAlgorithm.vtkUndirectedGraphAlgorithm_SetInputData_10(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		// Token: 0x06004FAB RID: 20395
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUndirectedGraphAlgorithm_SetInputData_11(HandleRef pThis, int index, HandleRef obj);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06004FAC RID: 20396 RVA: 0x00073D8C File Offset: 0x00071F8C
		public void SetInputData(int index, vtkDataObject obj)
		{
			vtkUndirectedGraphAlgorithm.vtkUndirectedGraphAlgorithm_SetInputData_11(base.GetCppThis(), index, (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400078F RID: 1935
		public new const string MRFullTypeName = "Kitware.VTK.vtkUndirectedGraphAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000790 RID: 1936
		public new static readonly string MRClassNameKey = "class vtkUndirectedGraphAlgorithm";
	}
}
