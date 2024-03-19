using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHierarchicalBoxDataSetAlgorithm
	/// </summary>
	/// <remarks>
	///    superclass for algorithms that
	/// produce vtkHierarchicalBoxDataSet as output.
	///
	/// Algorithms that take any type of data object (including composite dataset)
	/// and produce a vtkHierarchicalBoxDataSet in the output can subclass from this
	/// class.
	/// </remarks>
	// Token: 0x020009D4 RID: 2516
	public class vtkHierarchicalBoxDataSetAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A3A2 RID: 107426 RVA: 0x00245C57 File Offset: 0x00243E57
		static vtkHierarchicalBoxDataSetAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalBoxDataSetAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalBoxDataSetAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A3A3 RID: 107427 RVA: 0x00245C7F File Offset: 0x00243E7F
		public vtkHierarchicalBoxDataSetAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A3A4 RID: 107428
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBoxDataSetAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3A5 RID: 107429 RVA: 0x00245C90 File Offset: 0x00243E90
		public new static vtkHierarchicalBoxDataSetAlgorithm New()
		{
			vtkHierarchicalBoxDataSetAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalBoxDataSetAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3A6 RID: 107430 RVA: 0x00245CE4 File Offset: 0x00243EE4
		public vtkHierarchicalBoxDataSetAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A3A7 RID: 107431 RVA: 0x00245D28 File Offset: 0x00243F28
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A3A8 RID: 107432
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalBoxDataSetAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3A9 RID: 107433 RVA: 0x00245D34 File Offset: 0x00243F34
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A3AA RID: 107434
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalBoxDataSetAlgorithm_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3AB RID: 107435 RVA: 0x00245D54 File Offset: 0x00243F54
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A3AC RID: 107436
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBoxDataSetAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x0601A3AD RID: 107437 RVA: 0x00245D70 File Offset: 0x00243F70
		public vtkHierarchicalBoxDataSet GetOutput()
		{
			vtkHierarchicalBoxDataSet vtkHierarchicalBoxDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalBoxDataSet = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalBoxDataSet.Register(null);
				}
			}
			return vtkHierarchicalBoxDataSet;
		}

		// Token: 0x0601A3AE RID: 107438
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBoxDataSetAlgorithm_GetOutput_04(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x0601A3AF RID: 107439 RVA: 0x00245DE0 File Offset: 0x00243FE0
		public vtkHierarchicalBoxDataSet GetOutput(int arg0)
		{
			vtkHierarchicalBoxDataSet vtkHierarchicalBoxDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_GetOutput_04(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalBoxDataSet = (vtkHierarchicalBoxDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalBoxDataSet.Register(null);
				}
			}
			return vtkHierarchicalBoxDataSet;
		}

		// Token: 0x0601A3B0 RID: 107440
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalBoxDataSetAlgorithm_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3B1 RID: 107441 RVA: 0x00245E50 File Offset: 0x00244050
		public override int IsA(string type)
		{
			return vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601A3B2 RID: 107442
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalBoxDataSetAlgorithm_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3B3 RID: 107443 RVA: 0x00245E70 File Offset: 0x00244070
		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_IsTypeOf_06(type);
		}

		// Token: 0x0601A3B4 RID: 107444
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBoxDataSetAlgorithm_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3B5 RID: 107445 RVA: 0x00245E8C File Offset: 0x0024408C
		public new vtkHierarchicalBoxDataSetAlgorithm NewInstance()
		{
			vtkHierarchicalBoxDataSetAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalBoxDataSetAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A3B6 RID: 107446
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBoxDataSetAlgorithm_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A3B7 RID: 107447 RVA: 0x00245EE8 File Offset: 0x002440E8
		public new static vtkHierarchicalBoxDataSetAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalBoxDataSetAlgorithm vtkHierarchicalBoxDataSetAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalBoxDataSetAlgorithm = (vtkHierarchicalBoxDataSetAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalBoxDataSetAlgorithm.Register(null);
				}
			}
			return vtkHierarchicalBoxDataSetAlgorithm;
		}

		// Token: 0x0601A3B8 RID: 107448
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalBoxDataSetAlgorithm_SetInputData_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0601A3B9 RID: 107449 RVA: 0x00245F68 File Offset: 0x00244168
		public void SetInputData(vtkDataObject arg0)
		{
			vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_SetInputData_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601A3BA RID: 107450
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalBoxDataSetAlgorithm_SetInputData_11(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0601A3BB RID: 107451 RVA: 0x00245F98 File Offset: 0x00244198
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkHierarchicalBoxDataSetAlgorithm.vtkHierarchicalBoxDataSetAlgorithm_SetInputData_11(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C78 RID: 7288
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalBoxDataSetAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C79 RID: 7289
		public new static readonly string MRClassNameKey = "class vtkHierarchicalBoxDataSetAlgorithm";
	}
}
