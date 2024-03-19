using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPassInputTypeAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce output of the same type as input
	///
	/// vtkPassInputTypeAlgorithm is a convenience class to make writing algorithms
	/// easier. It is also designed to help transition old algorithms to the new
	/// pipeline architecture. There are some assumptions and defaults made by this
	/// class you should be aware of. This class defaults such that your filter
	/// will have one input port and one output port. If that is not the case
	/// simply change it with SetNumberOfInputPorts etc. See this classes
	/// constructor for the default. This class also provides a FillInputPortInfo
	/// method that by default says that all inputs will be DataObject. If that isn't
	/// the case then please override this method in your subclass. This class
	/// breaks out the downstream requests into separate functions such as
	/// RequestDataObject RequestData and RequestInformation. The default
	/// implementation of RequestDataObject will create an output data of the
	/// same type as the input.
	/// </remarks>
	// Token: 0x0200005C RID: 92
	public class vtkPassInputTypeAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001062 RID: 4194 RVA: 0x0001DA37 File Offset: 0x0001BC37
		static vtkPassInputTypeAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPassInputTypeAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPassInputTypeAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001063 RID: 4195 RVA: 0x0001DA5F File Offset: 0x0001BC5F
		public vtkPassInputTypeAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001064 RID: 4196
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassInputTypeAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001065 RID: 4197 RVA: 0x0001DA70 File Offset: 0x0001BC70
		public new static vtkPassInputTypeAlgorithm New()
		{
			vtkPassInputTypeAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassInputTypeAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001066 RID: 4198 RVA: 0x0001DAC4 File Offset: 0x0001BCC4
		public vtkPassInputTypeAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001067 RID: 4199 RVA: 0x0001DB08 File Offset: 0x0001BD08
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001068 RID: 4200
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassInputTypeAlgorithm_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06001069 RID: 4201 RVA: 0x0001DB14 File Offset: 0x0001BD14
		public void AddInputData(vtkDataObject arg0)
		{
			vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600106A RID: 4202
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassInputTypeAlgorithm_AddInputData_02(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0600106B RID: 4203 RVA: 0x0001DB44 File Offset: 0x0001BD44
		public void AddInputData(int arg0, vtkDataObject arg1)
		{
			vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_AddInputData_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600106C RID: 4204
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassInputTypeAlgorithm_GetGraphOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a concrete type.
		/// </summary>
		// Token: 0x0600106D RID: 4205 RVA: 0x0001DB74 File Offset: 0x0001BD74
		public vtkGraph GetGraphOutput()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_GetGraphOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600106E RID: 4206
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassInputTypeAlgorithm_GetImageDataOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a concrete type.
		/// </summary>
		// Token: 0x0600106F RID: 4207 RVA: 0x0001DBE4 File Offset: 0x0001BDE4
		public vtkImageData GetImageDataOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_GetImageDataOutput_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06001070 RID: 4208
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassInputTypeAlgorithm_GetInput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input data object. This method is not recommended for use, but
		/// lots of old style filters use it.
		/// </summary>
		// Token: 0x06001071 RID: 4209 RVA: 0x0001DC54 File Offset: 0x0001BE54
		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_GetInput_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06001072 RID: 4210
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassInputTypeAlgorithm_GetMoleculeOutput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a concrete type.
		/// </summary>
		// Token: 0x06001073 RID: 4211 RVA: 0x0001DCC4 File Offset: 0x0001BEC4
		public vtkMolecule GetMoleculeOutput()
		{
			vtkMolecule vtkMolecule = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_GetMoleculeOutput_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMolecule = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMolecule.Register(null);
				}
			}
			return vtkMolecule;
		}

		// Token: 0x06001074 RID: 4212
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPassInputTypeAlgorithm_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001075 RID: 4213 RVA: 0x0001DD34 File Offset: 0x0001BF34
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06001076 RID: 4214
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPassInputTypeAlgorithm_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001077 RID: 4215 RVA: 0x0001DD54 File Offset: 0x0001BF54
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06001078 RID: 4216
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassInputTypeAlgorithm_GetOutput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06001079 RID: 4217 RVA: 0x0001DD70 File Offset: 0x0001BF70
		public vtkDataObject GetOutput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_GetOutput_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600107A RID: 4218
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassInputTypeAlgorithm_GetOutput_10(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x0600107B RID: 4219 RVA: 0x0001DDE0 File Offset: 0x0001BFE0
		public vtkDataObject GetOutput(int arg0)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_GetOutput_10(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600107C RID: 4220
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassInputTypeAlgorithm_GetPolyDataOutput_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a concrete type.
		/// </summary>
		// Token: 0x0600107D RID: 4221 RVA: 0x0001DE50 File Offset: 0x0001C050
		public vtkPolyData GetPolyDataOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_GetPolyDataOutput_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600107E RID: 4222
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassInputTypeAlgorithm_GetRectilinearGridOutput_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a concrete type.
		/// </summary>
		// Token: 0x0600107F RID: 4223 RVA: 0x0001DEC0 File Offset: 0x0001C0C0
		public vtkRectilinearGrid GetRectilinearGridOutput()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_GetRectilinearGridOutput_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06001080 RID: 4224
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassInputTypeAlgorithm_GetStructuredGridOutput_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a concrete type.
		/// </summary>
		// Token: 0x06001081 RID: 4225 RVA: 0x0001DF30 File Offset: 0x0001C130
		public vtkStructuredGrid GetStructuredGridOutput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_GetStructuredGridOutput_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06001082 RID: 4226
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassInputTypeAlgorithm_GetStructuredPointsOutput_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a concrete type.
		/// </summary>
		// Token: 0x06001083 RID: 4227 RVA: 0x0001DFA0 File Offset: 0x0001C1A0
		public vtkStructuredPoints GetStructuredPointsOutput()
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_GetStructuredPointsOutput_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06001084 RID: 4228
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassInputTypeAlgorithm_GetTableOutput_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a concrete type.
		/// </summary>
		// Token: 0x06001085 RID: 4229 RVA: 0x0001E010 File Offset: 0x0001C210
		public vtkTable GetTableOutput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_GetTableOutput_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x06001086 RID: 4230
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassInputTypeAlgorithm_GetUnstructuredGridOutput_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output as a concrete type.
		/// </summary>
		// Token: 0x06001087 RID: 4231 RVA: 0x0001E080 File Offset: 0x0001C280
		public vtkUnstructuredGrid GetUnstructuredGridOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_GetUnstructuredGridOutput_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06001088 RID: 4232
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPassInputTypeAlgorithm_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001089 RID: 4233 RVA: 0x0001E0F0 File Offset: 0x0001C2F0
		public override int IsA(string type)
		{
			return vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0600108A RID: 4234
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPassInputTypeAlgorithm_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600108B RID: 4235 RVA: 0x0001E110 File Offset: 0x0001C310
		public new static int IsTypeOf(string type)
		{
			return vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_IsTypeOf_18(type);
		}

		// Token: 0x0600108C RID: 4236
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassInputTypeAlgorithm_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600108D RID: 4237 RVA: 0x0001E12C File Offset: 0x0001C32C
		public new vtkPassInputTypeAlgorithm NewInstance()
		{
			vtkPassInputTypeAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassInputTypeAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600108E RID: 4238
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPassInputTypeAlgorithm_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600108F RID: 4239 RVA: 0x0001E188 File Offset: 0x0001C388
		public new static vtkPassInputTypeAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkPassInputTypeAlgorithm vtkPassInputTypeAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPassInputTypeAlgorithm = (vtkPassInputTypeAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPassInputTypeAlgorithm.Register(null);
				}
			}
			return vtkPassInputTypeAlgorithm;
		}

		// Token: 0x06001090 RID: 4240
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassInputTypeAlgorithm_SetInputData_22(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06001091 RID: 4241 RVA: 0x0001E208 File Offset: 0x0001C408
		public void SetInputData(vtkDataObject arg0)
		{
			vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_SetInputData_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06001092 RID: 4242
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPassInputTypeAlgorithm_SetInputData_23(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06001093 RID: 4243 RVA: 0x0001E238 File Offset: 0x0001C438
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkPassInputTypeAlgorithm.vtkPassInputTypeAlgorithm_SetInputData_23(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000438 RID: 1080
		public new const string MRFullTypeName = "Kitware.VTK.vtkPassInputTypeAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000439 RID: 1081
		public new static readonly string MRClassNameKey = "class vtkPassInputTypeAlgorithm";
	}
}
