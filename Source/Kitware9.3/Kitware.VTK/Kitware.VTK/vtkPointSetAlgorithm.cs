using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointSetAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce output of the same type as input
	///
	/// vtkPointSetAlgorithm is a convenience class to make writing algorithms
	/// easier. It is also designed to help transition old algorithms to the new
	/// pipeline architecture. There are some assumptions and defaults made by this
	/// class you should be aware of. This class defaults such that your filter
	/// will have one input port and one output port. If that is not the case
	/// simply change it with SetNumberOfInputPorts etc. See this classes
	/// constructor for the default. This class also provides a FillInputPortInfo
	/// method that by default says that all inputs will be PointSet. If that
	/// isn't the case then please override this method in your subclass.
	/// You should implement the subclass's algorithm into
	/// RequestData( request, inputVec, outputVec).
	/// </remarks>
	// Token: 0x02000453 RID: 1107
	public class vtkPointSetAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CDFD RID: 52733 RVA: 0x0011E7AD File Offset: 0x0011C9AD
		static vtkPointSetAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointSetAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSetAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CDFE RID: 52734 RVA: 0x0011E7D5 File Offset: 0x0011C9D5
		public vtkPointSetAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CDFF RID: 52735
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600CE00 RID: 52736 RVA: 0x0011E7E4 File Offset: 0x0011C9E4
		public new static vtkPointSetAlgorithm New()
		{
			vtkPointSetAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetAlgorithm.vtkPointSetAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSetAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600CE01 RID: 52737 RVA: 0x0011E838 File Offset: 0x0011CA38
		public vtkPointSetAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointSetAlgorithm.vtkPointSetAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CE02 RID: 52738 RVA: 0x0011E87C File Offset: 0x0011CA7C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CE03 RID: 52739
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetAlgorithm_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0600CE04 RID: 52740 RVA: 0x0011E888 File Offset: 0x0011CA88
		public void AddInputData(vtkDataObject arg0)
		{
			vtkPointSetAlgorithm.vtkPointSetAlgorithm_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600CE05 RID: 52741
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetAlgorithm_AddInputData_02(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0600CE06 RID: 52742 RVA: 0x0011E8B8 File Offset: 0x0011CAB8
		public void AddInputData(vtkPointSet arg0)
		{
			vtkPointSetAlgorithm.vtkPointSetAlgorithm_AddInputData_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600CE07 RID: 52743
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetAlgorithm_AddInputData_03(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0600CE08 RID: 52744 RVA: 0x0011E8E8 File Offset: 0x0011CAE8
		public void AddInputData(int arg0, vtkPointSet arg1)
		{
			vtkPointSetAlgorithm.vtkPointSetAlgorithm_AddInputData_03(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600CE09 RID: 52745
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetAlgorithm_AddInputData_04(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0600CE0A RID: 52746 RVA: 0x0011E918 File Offset: 0x0011CB18
		public void AddInputData(int arg0, vtkDataObject arg1)
		{
			vtkPointSetAlgorithm.vtkPointSetAlgorithm_AddInputData_04(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600CE0B RID: 52747
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetAlgorithm_GetInput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0600CE0C RID: 52748 RVA: 0x0011E948 File Offset: 0x0011CB48
		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetAlgorithm.vtkPointSetAlgorithm_GetInput_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600CE0D RID: 52749
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSetAlgorithm_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600CE0E RID: 52750 RVA: 0x0011E9B8 File Offset: 0x0011CBB8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointSetAlgorithm.vtkPointSetAlgorithm_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600CE0F RID: 52751
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSetAlgorithm_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600CE10 RID: 52752 RVA: 0x0011E9D8 File Offset: 0x0011CBD8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointSetAlgorithm.vtkPointSetAlgorithm_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600CE11 RID: 52753
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetAlgorithm_GetOutput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x0600CE12 RID: 52754 RVA: 0x0011E9F4 File Offset: 0x0011CBF4
		public vtkPointSet GetOutput()
		{
			vtkPointSet vtkPointSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetAlgorithm.vtkPointSetAlgorithm_GetOutput_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointSet = (vtkPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointSet.Register(null);
				}
			}
			return vtkPointSet;
		}

		// Token: 0x0600CE13 RID: 52755
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetAlgorithm_GetOutput_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x0600CE14 RID: 52756 RVA: 0x0011EA64 File Offset: 0x0011CC64
		public vtkPointSet GetOutput(int arg0)
		{
			vtkPointSet vtkPointSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetAlgorithm.vtkPointSetAlgorithm_GetOutput_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointSet = (vtkPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointSet.Register(null);
				}
			}
			return vtkPointSet;
		}

		// Token: 0x0600CE15 RID: 52757
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetAlgorithm_GetPolyDataOutput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as vtkPolyData.
		/// </summary>
		// Token: 0x0600CE16 RID: 52758 RVA: 0x0011EAD4 File Offset: 0x0011CCD4
		public vtkPolyData GetPolyDataOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetAlgorithm.vtkPointSetAlgorithm_GetPolyDataOutput_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0600CE17 RID: 52759
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetAlgorithm_GetStructuredGridOutput_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as vtkStructuredGrid.
		/// </summary>
		// Token: 0x0600CE18 RID: 52760 RVA: 0x0011EB44 File Offset: 0x0011CD44
		public vtkStructuredGrid GetStructuredGridOutput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetAlgorithm.vtkPointSetAlgorithm_GetStructuredGridOutput_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		// Token: 0x0600CE19 RID: 52761
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetAlgorithm_GetUnstructuredGridOutput_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as vtkUnstructuredGrid.
		/// </summary>
		// Token: 0x0600CE1A RID: 52762 RVA: 0x0011EBB4 File Offset: 0x0011CDB4
		public vtkUnstructuredGrid GetUnstructuredGridOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetAlgorithm.vtkPointSetAlgorithm_GetUnstructuredGridOutput_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		// Token: 0x0600CE1B RID: 52763
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetAlgorithm_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600CE1C RID: 52764 RVA: 0x0011EC24 File Offset: 0x0011CE24
		public override int IsA(string type)
		{
			return vtkPointSetAlgorithm.vtkPointSetAlgorithm_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0600CE1D RID: 52765
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSetAlgorithm_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600CE1E RID: 52766 RVA: 0x0011EC44 File Offset: 0x0011CE44
		public new static int IsTypeOf(string type)
		{
			return vtkPointSetAlgorithm.vtkPointSetAlgorithm_IsTypeOf_14(type);
		}

		// Token: 0x0600CE1F RID: 52767
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetAlgorithm_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600CE20 RID: 52768 RVA: 0x0011EC60 File Offset: 0x0011CE60
		public new vtkPointSetAlgorithm NewInstance()
		{
			vtkPointSetAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetAlgorithm.vtkPointSetAlgorithm_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSetAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CE21 RID: 52769
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSetAlgorithm_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600CE22 RID: 52770 RVA: 0x0011ECBC File Offset: 0x0011CEBC
		public new static vtkPointSetAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkPointSetAlgorithm vtkPointSetAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSetAlgorithm.vtkPointSetAlgorithm_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointSetAlgorithm = (vtkPointSetAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointSetAlgorithm.Register(null);
				}
			}
			return vtkPointSetAlgorithm;
		}

		// Token: 0x0600CE23 RID: 52771
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetAlgorithm_SetInputData_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0600CE24 RID: 52772 RVA: 0x0011ED3C File Offset: 0x0011CF3C
		public void SetInputData(vtkDataObject arg0)
		{
			vtkPointSetAlgorithm.vtkPointSetAlgorithm_SetInputData_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600CE25 RID: 52773
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetAlgorithm_SetInputData_19(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0600CE26 RID: 52774 RVA: 0x0011ED6C File Offset: 0x0011CF6C
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkPointSetAlgorithm.vtkPointSetAlgorithm_SetInputData_19(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600CE27 RID: 52775
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetAlgorithm_SetInputData_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0600CE28 RID: 52776 RVA: 0x0011ED9C File Offset: 0x0011CF9C
		public void SetInputData(vtkPointSet arg0)
		{
			vtkPointSetAlgorithm.vtkPointSetAlgorithm_SetInputData_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600CE29 RID: 52777
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSetAlgorithm_SetInputData_21(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0600CE2A RID: 52778 RVA: 0x0011EDCC File Offset: 0x0011CFCC
		public void SetInputData(int arg0, vtkPointSet arg1)
		{
			vtkPointSetAlgorithm.vtkPointSetAlgorithm_SetInputData_21(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F39 RID: 3897
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointSetAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F3A RID: 3898
		public new static readonly string MRClassNameKey = "class vtkPointSetAlgorithm";
	}
}
