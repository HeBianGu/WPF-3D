using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridBaseAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that
	/// produce only vtkUnstructureGridBase subclasses as output
	///
	/// vtkUnstructuredGridBaseAlgorithm is a convenience class to make writing
	/// algorithms easier. There are some assumptions and defaults made by this
	/// class you should be aware of. This class defaults such that your filter
	/// will have one input port and one output port. If that is not the case
	/// simply change it with SetNumberOfInputPorts etc. See this classes
	/// constructor for the default. This class also provides a FillInputPortInfo
	/// method that by default says that all inputs will be UnstructuredGridBase. If
	/// that isn't the case then please override this method in your subclass.
	/// </remarks>
	// Token: 0x02000918 RID: 2328
	public class vtkUnstructuredGridBaseAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060181C2 RID: 98754 RVA: 0x0021BF4F File Offset: 0x0021A14F
		static vtkUnstructuredGridBaseAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridBaseAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridBaseAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060181C3 RID: 98755 RVA: 0x0021BF77 File Offset: 0x0021A177
		public vtkUnstructuredGridBaseAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060181C4 RID: 98756
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridBaseAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181C5 RID: 98757 RVA: 0x0021BF88 File Offset: 0x0021A188
		public new static vtkUnstructuredGridBaseAlgorithm New()
		{
			vtkUnstructuredGridBaseAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridBaseAlgorithm.vtkUnstructuredGridBaseAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridBaseAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181C6 RID: 98758 RVA: 0x0021BFDC File Offset: 0x0021A1DC
		public vtkUnstructuredGridBaseAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnstructuredGridBaseAlgorithm.vtkUnstructuredGridBaseAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060181C7 RID: 98759 RVA: 0x0021C020 File Offset: 0x0021A220
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060181C8 RID: 98760
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridBaseAlgorithm_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x060181C9 RID: 98761 RVA: 0x0021C02C File Offset: 0x0021A22C
		public void AddInputData(vtkDataObject arg0)
		{
			vtkUnstructuredGridBaseAlgorithm.vtkUnstructuredGridBaseAlgorithm_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060181CA RID: 98762
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridBaseAlgorithm_AddInputData_02(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x060181CB RID: 98763 RVA: 0x0021C05C File Offset: 0x0021A25C
		public void AddInputData(int arg0, vtkDataObject arg1)
		{
			vtkUnstructuredGridBaseAlgorithm.vtkUnstructuredGridBaseAlgorithm_AddInputData_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060181CC RID: 98764
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridBaseAlgorithm_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181CD RID: 98765 RVA: 0x0021C08C File Offset: 0x0021A28C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridBaseAlgorithm.vtkUnstructuredGridBaseAlgorithm_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060181CE RID: 98766
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridBaseAlgorithm_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181CF RID: 98767 RVA: 0x0021C0AC File Offset: 0x0021A2AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridBaseAlgorithm.vtkUnstructuredGridBaseAlgorithm_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060181D0 RID: 98768
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridBaseAlgorithm_GetOutput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x060181D1 RID: 98769 RVA: 0x0021C0C8 File Offset: 0x0021A2C8
		public vtkUnstructuredGridBase GetOutput()
		{
			vtkUnstructuredGridBase vtkUnstructuredGridBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridBaseAlgorithm.vtkUnstructuredGridBaseAlgorithm_GetOutput_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridBase = (vtkUnstructuredGridBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridBase.Register(null);
				}
			}
			return vtkUnstructuredGridBase;
		}

		// Token: 0x060181D2 RID: 98770
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridBaseAlgorithm_GetOutput_06(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x060181D3 RID: 98771 RVA: 0x0021C138 File Offset: 0x0021A338
		public vtkUnstructuredGridBase GetOutput(int arg0)
		{
			vtkUnstructuredGridBase vtkUnstructuredGridBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridBaseAlgorithm.vtkUnstructuredGridBaseAlgorithm_GetOutput_06(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridBase = (vtkUnstructuredGridBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridBase.Register(null);
				}
			}
			return vtkUnstructuredGridBase;
		}

		// Token: 0x060181D4 RID: 98772
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridBaseAlgorithm_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181D5 RID: 98773 RVA: 0x0021C1A8 File Offset: 0x0021A3A8
		public override int IsA(string type)
		{
			return vtkUnstructuredGridBaseAlgorithm.vtkUnstructuredGridBaseAlgorithm_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060181D6 RID: 98774
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridBaseAlgorithm_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181D7 RID: 98775 RVA: 0x0021C1C8 File Offset: 0x0021A3C8
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridBaseAlgorithm.vtkUnstructuredGridBaseAlgorithm_IsTypeOf_08(type);
		}

		// Token: 0x060181D8 RID: 98776
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridBaseAlgorithm_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181D9 RID: 98777 RVA: 0x0021C1E4 File Offset: 0x0021A3E4
		public new vtkUnstructuredGridBaseAlgorithm NewInstance()
		{
			vtkUnstructuredGridBaseAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridBaseAlgorithm.vtkUnstructuredGridBaseAlgorithm_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridBaseAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060181DA RID: 98778
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridBaseAlgorithm_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181DB RID: 98779 RVA: 0x0021C240 File Offset: 0x0021A440
		public new static vtkUnstructuredGridBaseAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridBaseAlgorithm vtkUnstructuredGridBaseAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridBaseAlgorithm.vtkUnstructuredGridBaseAlgorithm_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridBaseAlgorithm = (vtkUnstructuredGridBaseAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridBaseAlgorithm.Register(null);
				}
			}
			return vtkUnstructuredGridBaseAlgorithm;
		}

		// Token: 0x060181DC RID: 98780
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridBaseAlgorithm_SetInputData_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x060181DD RID: 98781 RVA: 0x0021C2C0 File Offset: 0x0021A4C0
		public void SetInputData(vtkDataObject arg0)
		{
			vtkUnstructuredGridBaseAlgorithm.vtkUnstructuredGridBaseAlgorithm_SetInputData_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060181DE RID: 98782
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridBaseAlgorithm_SetInputData_13(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x060181DF RID: 98783 RVA: 0x0021C2F0 File Offset: 0x0021A4F0
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkUnstructuredGridBaseAlgorithm.vtkUnstructuredGridBaseAlgorithm_SetInputData_13(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x060181E0 RID: 98784
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridBaseAlgorithm_SetOutput_14(HandleRef pThis, HandleRef d);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x060181E1 RID: 98785 RVA: 0x0021C320 File Offset: 0x0021A520
		public virtual void SetOutput(vtkDataObject d)
		{
			vtkUnstructuredGridBaseAlgorithm.vtkUnstructuredGridBaseAlgorithm_SetOutput_14(base.GetCppThis(), (d == null) ? default(HandleRef) : d.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ADA RID: 6874
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridBaseAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ADB RID: 6875
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridBaseAlgorithm";
	}
}
