using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRectilinearGridAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce only rectilinear grid as output
	///
	///
	/// vtkRectilinearGridAlgorithm is a convenience class to make writing algorithms
	/// easier. It is also designed to help transition old algorithms to the new
	/// pipeline architecture. There are some assumptions and defaults made by this
	/// class you should be aware of. This class defaults such that your filter
	/// will have one input port and one output port. If that is not the case
	/// simply change it with SetNumberOfInputPorts etc. See this classes
	/// constructor for the default. This class also provides a FillInputPortInfo
	/// method that by default says that all inputs will be RectilinearGrid. If that
	/// isn't the case then please override this method in your subclass.
	/// You should implement the subclass's algorithm into
	/// RequestData( request, inputVec, outputVec).
	/// </remarks>
	// Token: 0x0200012B RID: 299
	public class vtkRectilinearGridAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003C6D RID: 15469 RVA: 0x000580DF File Offset: 0x000562DF
		static vtkRectilinearGridAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearGridAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003C6E RID: 15470 RVA: 0x00058107 File Offset: 0x00056307
		public vtkRectilinearGridAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003C6F RID: 15471
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C70 RID: 15472 RVA: 0x00058118 File Offset: 0x00056318
		public new static vtkRectilinearGridAlgorithm New()
		{
			vtkRectilinearGridAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C71 RID: 15473 RVA: 0x0005816C File Offset: 0x0005636C
		public vtkRectilinearGridAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003C72 RID: 15474 RVA: 0x000581B0 File Offset: 0x000563B0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003C73 RID: 15475
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridAlgorithm_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003C74 RID: 15476 RVA: 0x000581BC File Offset: 0x000563BC
		public void AddInputData(vtkDataObject arg0)
		{
			vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003C75 RID: 15477
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridAlgorithm_AddInputData_02(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003C76 RID: 15478 RVA: 0x000581EC File Offset: 0x000563EC
		public void AddInputData(int arg0, vtkDataObject arg1)
		{
			vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_AddInputData_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06003C77 RID: 15479
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridAlgorithm_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x06003C78 RID: 15480 RVA: 0x0005821C File Offset: 0x0005641C
		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_GetInput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003C79 RID: 15481
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridAlgorithm_GetInput_04(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x06003C7A RID: 15482 RVA: 0x0005828C File Offset: 0x0005648C
		public vtkDataObject GetInput(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_GetInput_04(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003C7B RID: 15483
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridAlgorithm_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C7C RID: 15484 RVA: 0x000582FC File Offset: 0x000564FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06003C7D RID: 15485
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridAlgorithm_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C7E RID: 15486 RVA: 0x0005831C File Offset: 0x0005651C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06003C7F RID: 15487
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridAlgorithm_GetOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06003C80 RID: 15488 RVA: 0x00058338 File Offset: 0x00056538
		public vtkRectilinearGrid GetOutput()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_GetOutput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003C81 RID: 15489
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridAlgorithm_GetOutput_08(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06003C82 RID: 15490 RVA: 0x000583A8 File Offset: 0x000565A8
		public vtkRectilinearGrid GetOutput(int arg0)
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_GetOutput_08(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003C83 RID: 15491
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridAlgorithm_GetRectilinearGridInput_09(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x06003C84 RID: 15492 RVA: 0x00058418 File Offset: 0x00056618
		public vtkRectilinearGrid GetRectilinearGridInput(int port)
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_GetRectilinearGridInput_09(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003C85 RID: 15493
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridAlgorithm_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C86 RID: 15494 RVA: 0x00058488 File Offset: 0x00056688
		public override int IsA(string type)
		{
			return vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06003C87 RID: 15495
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridAlgorithm_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C88 RID: 15496 RVA: 0x000584A8 File Offset: 0x000566A8
		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_IsTypeOf_11(type);
		}

		// Token: 0x06003C89 RID: 15497
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridAlgorithm_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C8A RID: 15498 RVA: 0x000584C4 File Offset: 0x000566C4
		public new vtkRectilinearGridAlgorithm NewInstance()
		{
			vtkRectilinearGridAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003C8B RID: 15499
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridAlgorithm_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003C8C RID: 15500 RVA: 0x00058520 File Offset: 0x00056720
		public new static vtkRectilinearGridAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearGridAlgorithm vtkRectilinearGridAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGridAlgorithm = (vtkRectilinearGridAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGridAlgorithm.Register(null);
				}
			}
			return vtkRectilinearGridAlgorithm;
		}

		// Token: 0x06003C8D RID: 15501
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridAlgorithm_SetInputData_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003C8E RID: 15502 RVA: 0x000585A0 File Offset: 0x000567A0
		public void SetInputData(vtkDataObject arg0)
		{
			vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_SetInputData_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003C8F RID: 15503
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridAlgorithm_SetInputData_16(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003C90 RID: 15504 RVA: 0x000585D0 File Offset: 0x000567D0
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_SetInputData_16(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06003C91 RID: 15505
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearGridAlgorithm_SetOutput_17(HandleRef pThis, HandleRef d);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06003C92 RID: 15506 RVA: 0x00058600 File Offset: 0x00056800
		public virtual void SetOutput(vtkDataObject d)
		{
			vtkRectilinearGridAlgorithm.vtkRectilinearGridAlgorithm_SetOutput_17(base.GetCppThis(), (d == null) ? default(HandleRef) : d.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400068F RID: 1679
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000690 RID: 1680
		public new static readonly string MRClassNameKey = "class vtkRectilinearGridAlgorithm";
	}
}
