using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellGridAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce only polydata as output
	///
	///
	/// vtkCellGridAlgorithm is a convenience class to make writing algorithms
	/// easier. It is also designed to help transition old algorithms to the new
	/// pipeline architecture. There are some assumptions and defaults made by this
	/// class you should be aware of. This class defaults such that your filter
	/// will have one input port and one output port. If that is not the case
	/// simply change it with SetNumberOfInputPorts etc. See this class
	/// constructor for the default. This class also provides a FillInputPortInfo
	/// method that by default says that all inputs will be PolyData. If that
	/// isn't the case then please override this method in your subclass.
	/// </remarks>
	// Token: 0x020001DB RID: 475
	public class vtkCellGridAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005AC8 RID: 23240 RVA: 0x00083487 File Offset: 0x00081687
		static vtkCellGridAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGridAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGridAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005AC9 RID: 23241 RVA: 0x000834AF File Offset: 0x000816AF
		public vtkCellGridAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005ACA RID: 23242
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005ACB RID: 23243 RVA: 0x000834C0 File Offset: 0x000816C0
		public new static vtkCellGridAlgorithm New()
		{
			vtkCellGridAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridAlgorithm.vtkCellGridAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005ACC RID: 23244 RVA: 0x00083514 File Offset: 0x00081714
		public vtkCellGridAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellGridAlgorithm.vtkCellGridAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005ACD RID: 23245 RVA: 0x00083558 File Offset: 0x00081758
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005ACE RID: 23246
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridAlgorithm_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06005ACF RID: 23247 RVA: 0x00083564 File Offset: 0x00081764
		public void AddInputData(vtkDataObject arg0)
		{
			vtkCellGridAlgorithm.vtkCellGridAlgorithm_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06005AD0 RID: 23248
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridAlgorithm_AddInputData_02(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06005AD1 RID: 23249 RVA: 0x00083594 File Offset: 0x00081794
		public void AddInputData(int arg0, vtkDataObject arg1)
		{
			vtkCellGridAlgorithm.vtkCellGridAlgorithm_AddInputData_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06005AD2 RID: 23250
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridAlgorithm_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x06005AD3 RID: 23251 RVA: 0x000835C4 File Offset: 0x000817C4
		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridAlgorithm.vtkCellGridAlgorithm_GetInput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06005AD4 RID: 23252
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridAlgorithm_GetInput_04(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x06005AD5 RID: 23253 RVA: 0x00083634 File Offset: 0x00081834
		public vtkDataObject GetInput(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridAlgorithm.vtkCellGridAlgorithm_GetInput_04(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06005AD6 RID: 23254
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridAlgorithm_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AD7 RID: 23255 RVA: 0x000836A4 File Offset: 0x000818A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGridAlgorithm.vtkCellGridAlgorithm_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06005AD8 RID: 23256
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridAlgorithm_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AD9 RID: 23257 RVA: 0x000836C4 File Offset: 0x000818C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGridAlgorithm.vtkCellGridAlgorithm_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06005ADA RID: 23258
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridAlgorithm_GetOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06005ADB RID: 23259 RVA: 0x000836E0 File Offset: 0x000818E0
		public vtkCellGrid GetOutput()
		{
			vtkCellGrid vtkCellGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridAlgorithm.vtkCellGridAlgorithm_GetOutput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGrid = (vtkCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGrid.Register(null);
				}
			}
			return vtkCellGrid;
		}

		// Token: 0x06005ADC RID: 23260
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridAlgorithm_GetOutput_08(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06005ADD RID: 23261 RVA: 0x00083750 File Offset: 0x00081950
		public vtkCellGrid GetOutput(int arg0)
		{
			vtkCellGrid vtkCellGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridAlgorithm.vtkCellGridAlgorithm_GetOutput_08(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGrid = (vtkCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGrid.Register(null);
				}
			}
			return vtkCellGrid;
		}

		// Token: 0x06005ADE RID: 23262
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridAlgorithm_GetPolyDataInput_09(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x06005ADF RID: 23263 RVA: 0x000837C0 File Offset: 0x000819C0
		public vtkCellGrid GetPolyDataInput(int port)
		{
			vtkCellGrid vtkCellGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridAlgorithm.vtkCellGridAlgorithm_GetPolyDataInput_09(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGrid = (vtkCellGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGrid.Register(null);
				}
			}
			return vtkCellGrid;
		}

		// Token: 0x06005AE0 RID: 23264
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridAlgorithm_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AE1 RID: 23265 RVA: 0x00083830 File Offset: 0x00081A30
		public override int IsA(string type)
		{
			return vtkCellGridAlgorithm.vtkCellGridAlgorithm_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06005AE2 RID: 23266
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridAlgorithm_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AE3 RID: 23267 RVA: 0x00083850 File Offset: 0x00081A50
		public new static int IsTypeOf(string type)
		{
			return vtkCellGridAlgorithm.vtkCellGridAlgorithm_IsTypeOf_11(type);
		}

		// Token: 0x06005AE4 RID: 23268
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridAlgorithm_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AE5 RID: 23269 RVA: 0x0008386C File Offset: 0x00081A6C
		public new vtkCellGridAlgorithm NewInstance()
		{
			vtkCellGridAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridAlgorithm.vtkCellGridAlgorithm_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005AE6 RID: 23270
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridAlgorithm_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AE7 RID: 23271 RVA: 0x000838C8 File Offset: 0x00081AC8
		public new static vtkCellGridAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkCellGridAlgorithm vtkCellGridAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridAlgorithm.vtkCellGridAlgorithm_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridAlgorithm = (vtkCellGridAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridAlgorithm.Register(null);
				}
			}
			return vtkCellGridAlgorithm;
		}

		// Token: 0x06005AE8 RID: 23272
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridAlgorithm_SetInputData_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06005AE9 RID: 23273 RVA: 0x00083948 File Offset: 0x00081B48
		public void SetInputData(vtkDataObject arg0)
		{
			vtkCellGridAlgorithm.vtkCellGridAlgorithm_SetInputData_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06005AEA RID: 23274
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridAlgorithm_SetInputData_16(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06005AEB RID: 23275 RVA: 0x00083978 File Offset: 0x00081B78
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkCellGridAlgorithm.vtkCellGridAlgorithm_SetInputData_16(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06005AEC RID: 23276
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridAlgorithm_SetOutput_17(HandleRef pThis, HandleRef d);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06005AED RID: 23277 RVA: 0x000839A8 File Offset: 0x00081BA8
		public virtual void SetOutput(vtkDataObject d)
		{
			vtkCellGridAlgorithm.vtkCellGridAlgorithm_SetOutput_17(base.GetCppThis(), (d == null) ? default(HandleRef) : d.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400087F RID: 2175
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGridAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000880 RID: 2176
		public new static readonly string MRClassNameKey = "class vtkCellGridAlgorithm";
	}
}
