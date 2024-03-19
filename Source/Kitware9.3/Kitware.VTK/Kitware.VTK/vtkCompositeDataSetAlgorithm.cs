using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositeDataSetAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce only vtkCompositeDataSet as output
	///
	/// Algorithms that take any type of data object (including composite dataset)
	/// and produce a vtkCompositeDataSet in the output can subclass from this
	/// class.
	/// </remarks>
	// Token: 0x0200046A RID: 1130
	public class vtkCompositeDataSetAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D1B0 RID: 53680 RVA: 0x001239D7 File Offset: 0x00121BD7
		static vtkCompositeDataSetAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeDataSetAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataSetAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D1B1 RID: 53681 RVA: 0x001239FF File Offset: 0x00121BFF
		public vtkCompositeDataSetAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D1B2 RID: 53682
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataSetAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1B3 RID: 53683 RVA: 0x00123A10 File Offset: 0x00121C10
		public new static vtkCompositeDataSetAlgorithm New()
		{
			vtkCompositeDataSetAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataSetAlgorithm.vtkCompositeDataSetAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataSetAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1B4 RID: 53684 RVA: 0x00123A64 File Offset: 0x00121C64
		public vtkCompositeDataSetAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositeDataSetAlgorithm.vtkCompositeDataSetAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D1B5 RID: 53685 RVA: 0x00123AA8 File Offset: 0x00121CA8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D1B6 RID: 53686
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataSetAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1B7 RID: 53687 RVA: 0x00123AB4 File Offset: 0x00121CB4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeDataSetAlgorithm.vtkCompositeDataSetAlgorithm_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600D1B8 RID: 53688
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataSetAlgorithm_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1B9 RID: 53689 RVA: 0x00123AD4 File Offset: 0x00121CD4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeDataSetAlgorithm.vtkCompositeDataSetAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600D1BA RID: 53690
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataSetAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x0600D1BB RID: 53691 RVA: 0x00123AF0 File Offset: 0x00121CF0
		public vtkCompositeDataSet GetOutput()
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataSetAlgorithm.vtkCompositeDataSetAlgorithm_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		// Token: 0x0600D1BC RID: 53692
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataSetAlgorithm_GetOutput_04(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x0600D1BD RID: 53693 RVA: 0x00123B60 File Offset: 0x00121D60
		public vtkCompositeDataSet GetOutput(int arg0)
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataSetAlgorithm.vtkCompositeDataSetAlgorithm_GetOutput_04(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		// Token: 0x0600D1BE RID: 53694
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataSetAlgorithm_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1BF RID: 53695 RVA: 0x00123BD0 File Offset: 0x00121DD0
		public override int IsA(string type)
		{
			return vtkCompositeDataSetAlgorithm.vtkCompositeDataSetAlgorithm_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600D1C0 RID: 53696
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataSetAlgorithm_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1C1 RID: 53697 RVA: 0x00123BF0 File Offset: 0x00121DF0
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeDataSetAlgorithm.vtkCompositeDataSetAlgorithm_IsTypeOf_06(type);
		}

		// Token: 0x0600D1C2 RID: 53698
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataSetAlgorithm_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1C3 RID: 53699 RVA: 0x00123C0C File Offset: 0x00121E0C
		public new vtkCompositeDataSetAlgorithm NewInstance()
		{
			vtkCompositeDataSetAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataSetAlgorithm.vtkCompositeDataSetAlgorithm_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataSetAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D1C4 RID: 53700
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataSetAlgorithm_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1C5 RID: 53701 RVA: 0x00123C68 File Offset: 0x00121E68
		public new static vtkCompositeDataSetAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeDataSetAlgorithm vtkCompositeDataSetAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataSetAlgorithm.vtkCompositeDataSetAlgorithm_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSetAlgorithm = (vtkCompositeDataSetAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSetAlgorithm.Register(null);
				}
			}
			return vtkCompositeDataSetAlgorithm;
		}

		// Token: 0x0600D1C6 RID: 53702
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataSetAlgorithm_SetInputData_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0600D1C7 RID: 53703 RVA: 0x00123CE8 File Offset: 0x00121EE8
		public void SetInputData(vtkDataObject arg0)
		{
			vtkCompositeDataSetAlgorithm.vtkCompositeDataSetAlgorithm_SetInputData_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D1C8 RID: 53704
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeDataSetAlgorithm_SetInputData_11(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0600D1C9 RID: 53705 RVA: 0x00123D18 File Offset: 0x00121F18
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkCompositeDataSetAlgorithm.vtkCompositeDataSetAlgorithm_SetInputData_11(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F75 RID: 3957
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataSetAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F76 RID: 3958
		public new static readonly string MRClassNameKey = "class vtkCompositeDataSetAlgorithm";
	}
}
