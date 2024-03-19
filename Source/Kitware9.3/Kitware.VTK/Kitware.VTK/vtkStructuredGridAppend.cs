using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredGridAppend
	/// </summary>
	/// <remarks>
	///    Collects data from multiple inputs into one structured grid.
	///
	/// vtkStructuredGridAppend takes the components from multiple inputs and merges
	/// them into one output. All inputs must have the same number of scalar components.
	/// All inputs must have the same scalar type.
	/// </remarks>
	// Token: 0x020009A8 RID: 2472
	public class vtkStructuredGridAppend : vtkStructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019D01 RID: 105729 RVA: 0x0023D7B3 File Offset: 0x0023B9B3
		static vtkStructuredGridAppend()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredGridAppend.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridAppend"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019D02 RID: 105730 RVA: 0x0023D7DB File Offset: 0x0023B9DB
		public vtkStructuredGridAppend(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019D03 RID: 105731
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridAppend_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019D04 RID: 105732 RVA: 0x0023D7EC File Offset: 0x0023B9EC
		public new static vtkStructuredGridAppend New()
		{
			vtkStructuredGridAppend result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridAppend.vtkStructuredGridAppend_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridAppend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019D05 RID: 105733 RVA: 0x0023D840 File Offset: 0x0023BA40
		public vtkStructuredGridAppend() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredGridAppend.vtkStructuredGridAppend_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019D06 RID: 105734 RVA: 0x0023D884 File Offset: 0x0023BA84
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019D07 RID: 105735
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridAppend_GetInput_01(HandleRef pThis, int num, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get one input to this filter. This method is only for support of
		/// old-style pipeline connections.  When writing new code you should
		/// use vtkAlgorithm::GetInputConnection(0, num).
		/// </summary>
		// Token: 0x06019D08 RID: 105736 RVA: 0x0023D890 File Offset: 0x0023BA90
		public new vtkDataObject GetInput(int num)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridAppend.vtkStructuredGridAppend_GetInput_01(base.GetCppThis(), num, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06019D09 RID: 105737
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridAppend_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get one input to this filter. This method is only for support of
		/// old-style pipeline connections.  When writing new code you should
		/// use vtkAlgorithm::GetInputConnection(0, num).
		/// </summary>
		// Token: 0x06019D0A RID: 105738 RVA: 0x0023D900 File Offset: 0x0023BB00
		public new vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridAppend.vtkStructuredGridAppend_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06019D0B RID: 105739
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridAppend_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019D0C RID: 105740 RVA: 0x0023D970 File Offset: 0x0023BB70
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredGridAppend.vtkStructuredGridAppend_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06019D0D RID: 105741
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridAppend_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019D0E RID: 105742 RVA: 0x0023D990 File Offset: 0x0023BB90
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredGridAppend.vtkStructuredGridAppend_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06019D0F RID: 105743
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridAppend_GetNumberOfInputs_05(HandleRef pThis);

		/// <summary>
		/// Get the number of inputs to this filter. This method is only for
		/// support of old-style pipeline connections.  When writing new code
		/// you should use vtkAlgorithm::GetNumberOfInputConnections(0).
		/// </summary>
		// Token: 0x06019D10 RID: 105744 RVA: 0x0023D9AC File Offset: 0x0023BBAC
		public int GetNumberOfInputs()
		{
			return vtkStructuredGridAppend.vtkStructuredGridAppend_GetNumberOfInputs_05(base.GetCppThis());
		}

		// Token: 0x06019D11 RID: 105745
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridAppend_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019D12 RID: 105746 RVA: 0x0023D9CC File Offset: 0x0023BBCC
		public override int IsA(string type)
		{
			return vtkStructuredGridAppend.vtkStructuredGridAppend_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06019D13 RID: 105747
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridAppend_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019D14 RID: 105748 RVA: 0x0023D9EC File Offset: 0x0023BBEC
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredGridAppend.vtkStructuredGridAppend_IsTypeOf_07(type);
		}

		// Token: 0x06019D15 RID: 105749
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridAppend_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019D16 RID: 105750 RVA: 0x0023DA08 File Offset: 0x0023BC08
		public new vtkStructuredGridAppend NewInstance()
		{
			vtkStructuredGridAppend result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridAppend.vtkStructuredGridAppend_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridAppend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019D17 RID: 105751
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridAppend_ReplaceNthInputConnection_10(HandleRef pThis, int idx, HandleRef input);

		/// <summary>
		/// Replace one of the input connections with a new input.  You can
		/// only replace input connections that you previously created with
		/// AddInputConnection() or, in the case of the first input,
		/// with SetInputConnection().
		/// </summary>
		// Token: 0x06019D18 RID: 105752 RVA: 0x0023DA64 File Offset: 0x0023BC64
		public virtual void ReplaceNthInputConnection(int idx, vtkAlgorithmOutput input)
		{
			vtkStructuredGridAppend.vtkStructuredGridAppend_ReplaceNthInputConnection_10(base.GetCppThis(), idx, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06019D19 RID: 105753
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridAppend_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019D1A RID: 105754 RVA: 0x0023DA94 File Offset: 0x0023BC94
		public new static vtkStructuredGridAppend SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredGridAppend vtkStructuredGridAppend = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridAppend.vtkStructuredGridAppend_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGridAppend = (vtkStructuredGridAppend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGridAppend.Register(null);
				}
			}
			return vtkStructuredGridAppend;
		}

		// Token: 0x06019D1B RID: 105755
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridAppend_SetInputData_12(HandleRef pThis, int num, HandleRef input);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06019D1C RID: 105756 RVA: 0x0023DB14 File Offset: 0x0023BD14
		public new void SetInputData(int num, vtkDataObject input)
		{
			vtkStructuredGridAppend.vtkStructuredGridAppend_SetInputData_12(base.GetCppThis(), num, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06019D1D RID: 105757
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridAppend_SetInputData_13(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06019D1E RID: 105758 RVA: 0x0023DB44 File Offset: 0x0023BD44
		public new void SetInputData(vtkDataObject input)
		{
			vtkStructuredGridAppend.vtkStructuredGridAppend_SetInputData_13(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C0D RID: 7181
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridAppend";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C0E RID: 7182
		public new static readonly string MRClassNameKey = "class vtkStructuredGridAppend";
	}
}
