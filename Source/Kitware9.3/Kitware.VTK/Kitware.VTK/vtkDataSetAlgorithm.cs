using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataSetAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce output of the same type as input
	///
	/// vtkDataSetAlgorithm is a convenience class to make writing algorithms
	/// easier. It is also designed to help transition old algorithms to the new
	/// pipeline architecture. There are some assumptions and defaults made by this
	/// class you should be aware of. This class defaults such that your filter
	/// will have one input port and one output port. If that is not the case
	/// simply change it with SetNumberOfInputPorts etc. See this classes
	/// constructor for the default. This class also provides a FillInputPortInfo
	/// method that by default says that all inputs will be DataSet. If that isn't
	/// the case then please override this method in your subclass. This class
	/// breaks out the downstream requests into separate functions such as
	/// RequestDataObject RequestData and RequestInformation. The default
	/// implementation of RequestDataObject will create an output data of the
	/// same type as the input.
	/// </remarks>
	// Token: 0x0200012F RID: 303
	public class vtkDataSetAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003D05 RID: 15621 RVA: 0x0005917F File Offset: 0x0005737F
		static vtkDataSetAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003D06 RID: 15622 RVA: 0x000591A7 File Offset: 0x000573A7
		public vtkDataSetAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003D07 RID: 15623
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D08 RID: 15624 RVA: 0x000591B8 File Offset: 0x000573B8
		public new static vtkDataSetAlgorithm New()
		{
			vtkDataSetAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAlgorithm.vtkDataSetAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D09 RID: 15625 RVA: 0x0005920C File Offset: 0x0005740C
		public vtkDataSetAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataSetAlgorithm.vtkDataSetAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003D0A RID: 15626 RVA: 0x00059250 File Offset: 0x00057450
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003D0B RID: 15627
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAlgorithm_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003D0C RID: 15628 RVA: 0x0005925C File Offset: 0x0005745C
		public void AddInputData(vtkDataObject arg0)
		{
			vtkDataSetAlgorithm.vtkDataSetAlgorithm_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003D0D RID: 15629
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAlgorithm_AddInputData_02(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003D0E RID: 15630 RVA: 0x0005928C File Offset: 0x0005748C
		public void AddInputData(vtkDataSet arg0)
		{
			vtkDataSetAlgorithm.vtkDataSetAlgorithm_AddInputData_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003D0F RID: 15631
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAlgorithm_AddInputData_03(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003D10 RID: 15632 RVA: 0x000592BC File Offset: 0x000574BC
		public void AddInputData(int arg0, vtkDataSet arg1)
		{
			vtkDataSetAlgorithm.vtkDataSetAlgorithm_AddInputData_03(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06003D11 RID: 15633
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAlgorithm_AddInputData_04(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003D12 RID: 15634 RVA: 0x000592EC File Offset: 0x000574EC
		public void AddInputData(int arg0, vtkDataObject arg1)
		{
			vtkDataSetAlgorithm.vtkDataSetAlgorithm_AddInputData_04(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06003D13 RID: 15635
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAlgorithm_GetImageDataOutput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as vtkStructuredPoints.
		/// </summary>
		// Token: 0x06003D14 RID: 15636 RVA: 0x0005931C File Offset: 0x0005751C
		public vtkImageData GetImageDataOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAlgorithm.vtkDataSetAlgorithm_GetImageDataOutput_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06003D15 RID: 15637
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAlgorithm_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input data object. This method is not recommended for use, but
		/// lots of old style filters use it.
		/// </summary>
		// Token: 0x06003D16 RID: 15638 RVA: 0x0005938C File Offset: 0x0005758C
		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAlgorithm.vtkDataSetAlgorithm_GetInput_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003D17 RID: 15639
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetAlgorithm_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D18 RID: 15640 RVA: 0x000593FC File Offset: 0x000575FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataSetAlgorithm.vtkDataSetAlgorithm_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06003D19 RID: 15641
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetAlgorithm_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D1A RID: 15642 RVA: 0x0005941C File Offset: 0x0005761C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataSetAlgorithm.vtkDataSetAlgorithm_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06003D1B RID: 15643
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAlgorithm_GetOutput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06003D1C RID: 15644 RVA: 0x00059438 File Offset: 0x00057638
		public vtkDataSet GetOutput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAlgorithm.vtkDataSetAlgorithm_GetOutput_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06003D1D RID: 15645
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAlgorithm_GetOutput_10(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06003D1E RID: 15646 RVA: 0x000594A8 File Offset: 0x000576A8
		public vtkDataSet GetOutput(int arg0)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAlgorithm.vtkDataSetAlgorithm_GetOutput_10(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06003D1F RID: 15647
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAlgorithm_GetPolyDataOutput_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as vtkPolyData.
		/// </summary>
		// Token: 0x06003D20 RID: 15648 RVA: 0x00059518 File Offset: 0x00057718
		public vtkPolyData GetPolyDataOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAlgorithm.vtkDataSetAlgorithm_GetPolyDataOutput_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003D21 RID: 15649
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAlgorithm_GetRectilinearGridOutput_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as vtkRectilinearGrid.
		/// </summary>
		// Token: 0x06003D22 RID: 15650 RVA: 0x00059588 File Offset: 0x00057788
		public vtkRectilinearGrid GetRectilinearGridOutput()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAlgorithm.vtkDataSetAlgorithm_GetRectilinearGridOutput_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		// Token: 0x06003D23 RID: 15651
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAlgorithm_GetStructuredGridOutput_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as vtkStructuredGrid.
		/// </summary>
		// Token: 0x06003D24 RID: 15652 RVA: 0x000595F8 File Offset: 0x000577F8
		public vtkStructuredGrid GetStructuredGridOutput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAlgorithm.vtkDataSetAlgorithm_GetStructuredGridOutput_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003D25 RID: 15653
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAlgorithm_GetStructuredPointsOutput_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as vtkStructuredPoints.
		/// </summary>
		// Token: 0x06003D26 RID: 15654 RVA: 0x00059668 File Offset: 0x00057868
		public vtkStructuredPoints GetStructuredPointsOutput()
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAlgorithm.vtkDataSetAlgorithm_GetStructuredPointsOutput_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPoints = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPoints.Register(null);
				}
			}
			return vtkStructuredPoints;
		}

		// Token: 0x06003D27 RID: 15655
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAlgorithm_GetUnstructuredGridOutput_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as vtkUnstructuredGrid.
		/// </summary>
		// Token: 0x06003D28 RID: 15656 RVA: 0x000596D8 File Offset: 0x000578D8
		public vtkUnstructuredGrid GetUnstructuredGridOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAlgorithm.vtkDataSetAlgorithm_GetUnstructuredGridOutput_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003D29 RID: 15657
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAlgorithm_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D2A RID: 15658 RVA: 0x00059748 File Offset: 0x00057948
		public override int IsA(string type)
		{
			return vtkDataSetAlgorithm.vtkDataSetAlgorithm_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06003D2B RID: 15659
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetAlgorithm_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D2C RID: 15660 RVA: 0x00059768 File Offset: 0x00057968
		public new static int IsTypeOf(string type)
		{
			return vtkDataSetAlgorithm.vtkDataSetAlgorithm_IsTypeOf_17(type);
		}

		// Token: 0x06003D2D RID: 15661
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAlgorithm_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D2E RID: 15662 RVA: 0x00059784 File Offset: 0x00057984
		public new vtkDataSetAlgorithm NewInstance()
		{
			vtkDataSetAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAlgorithm.vtkDataSetAlgorithm_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003D2F RID: 15663
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetAlgorithm_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003D30 RID: 15664 RVA: 0x000597E0 File Offset: 0x000579E0
		public new static vtkDataSetAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetAlgorithm vtkDataSetAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetAlgorithm.vtkDataSetAlgorithm_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAlgorithm = (vtkDataSetAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAlgorithm.Register(null);
				}
			}
			return vtkDataSetAlgorithm;
		}

		// Token: 0x06003D31 RID: 15665
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAlgorithm_SetInputData_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003D32 RID: 15666 RVA: 0x00059860 File Offset: 0x00057A60
		public void SetInputData(vtkDataObject arg0)
		{
			vtkDataSetAlgorithm.vtkDataSetAlgorithm_SetInputData_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003D33 RID: 15667
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAlgorithm_SetInputData_22(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003D34 RID: 15668 RVA: 0x00059890 File Offset: 0x00057A90
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkDataSetAlgorithm.vtkDataSetAlgorithm_SetInputData_22(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06003D35 RID: 15669
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAlgorithm_SetInputData_23(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003D36 RID: 15670 RVA: 0x000598C0 File Offset: 0x00057AC0
		public void SetInputData(vtkDataSet arg0)
		{
			vtkDataSetAlgorithm.vtkDataSetAlgorithm_SetInputData_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003D37 RID: 15671
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetAlgorithm_SetInputData_24(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003D38 RID: 15672 RVA: 0x000598F0 File Offset: 0x00057AF0
		public void SetInputData(int arg0, vtkDataSet arg1)
		{
			vtkDataSetAlgorithm.vtkDataSetAlgorithm_SetInputData_24(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000697 RID: 1687
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000698 RID: 1688
		public new static readonly string MRClassNameKey = "class vtkDataSetAlgorithm";
	}
}
