using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMultiBlockDataSetAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce only vtkMultiBlockDataSet as output
	///
	/// Algorithms that take any type of data object (including composite dataset)
	/// and produce a vtkMultiBlockDataSet in the output can subclass from this
	/// class.
	/// </remarks>
	// Token: 0x02000160 RID: 352
	public class vtkMultiBlockDataSetAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004300 RID: 17152 RVA: 0x00062203 File Offset: 0x00060403
		static vtkMultiBlockDataSetAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiBlockDataSetAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiBlockDataSetAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004301 RID: 17153 RVA: 0x0006222B File Offset: 0x0006042B
		public vtkMultiBlockDataSetAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004302 RID: 17154
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockDataSetAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004303 RID: 17155 RVA: 0x0006223C File Offset: 0x0006043C
		public new static vtkMultiBlockDataSetAlgorithm New()
		{
			vtkMultiBlockDataSetAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockDataSetAlgorithm.vtkMultiBlockDataSetAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockDataSetAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004304 RID: 17156 RVA: 0x00062290 File Offset: 0x00060490
		public vtkMultiBlockDataSetAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMultiBlockDataSetAlgorithm.vtkMultiBlockDataSetAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004305 RID: 17157 RVA: 0x000622D4 File Offset: 0x000604D4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004306 RID: 17158
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiBlockDataSetAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004307 RID: 17159 RVA: 0x000622E0 File Offset: 0x000604E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMultiBlockDataSetAlgorithm.vtkMultiBlockDataSetAlgorithm_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06004308 RID: 17160
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiBlockDataSetAlgorithm_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004309 RID: 17161 RVA: 0x00062300 File Offset: 0x00060500
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMultiBlockDataSetAlgorithm.vtkMultiBlockDataSetAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600430A RID: 17162
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockDataSetAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x0600430B RID: 17163 RVA: 0x0006231C File Offset: 0x0006051C
		public vtkMultiBlockDataSet GetOutput()
		{
			vtkMultiBlockDataSet vtkMultiBlockDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockDataSetAlgorithm.vtkMultiBlockDataSetAlgorithm_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockDataSet = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockDataSet.Register(null);
				}
			}
			return vtkMultiBlockDataSet;
		}

		// Token: 0x0600430C RID: 17164
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockDataSetAlgorithm_GetOutput_04(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x0600430D RID: 17165 RVA: 0x0006238C File Offset: 0x0006058C
		public vtkMultiBlockDataSet GetOutput(int arg0)
		{
			vtkMultiBlockDataSet vtkMultiBlockDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockDataSetAlgorithm.vtkMultiBlockDataSetAlgorithm_GetOutput_04(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockDataSet = (vtkMultiBlockDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockDataSet.Register(null);
				}
			}
			return vtkMultiBlockDataSet;
		}

		// Token: 0x0600430E RID: 17166
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockDataSetAlgorithm_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600430F RID: 17167 RVA: 0x000623FC File Offset: 0x000605FC
		public override int IsA(string type)
		{
			return vtkMultiBlockDataSetAlgorithm.vtkMultiBlockDataSetAlgorithm_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06004310 RID: 17168
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiBlockDataSetAlgorithm_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004311 RID: 17169 RVA: 0x0006241C File Offset: 0x0006061C
		public new static int IsTypeOf(string type)
		{
			return vtkMultiBlockDataSetAlgorithm.vtkMultiBlockDataSetAlgorithm_IsTypeOf_06(type);
		}

		// Token: 0x06004312 RID: 17170
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockDataSetAlgorithm_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004313 RID: 17171 RVA: 0x00062438 File Offset: 0x00060638
		public new vtkMultiBlockDataSetAlgorithm NewInstance()
		{
			vtkMultiBlockDataSetAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockDataSetAlgorithm.vtkMultiBlockDataSetAlgorithm_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockDataSetAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004314 RID: 17172
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiBlockDataSetAlgorithm_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004315 RID: 17173 RVA: 0x00062494 File Offset: 0x00060694
		public new static vtkMultiBlockDataSetAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkMultiBlockDataSetAlgorithm vtkMultiBlockDataSetAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiBlockDataSetAlgorithm.vtkMultiBlockDataSetAlgorithm_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockDataSetAlgorithm = (vtkMultiBlockDataSetAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockDataSetAlgorithm.Register(null);
				}
			}
			return vtkMultiBlockDataSetAlgorithm;
		}

		// Token: 0x06004316 RID: 17174
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockDataSetAlgorithm_SetInputData_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06004317 RID: 17175 RVA: 0x00062514 File Offset: 0x00060714
		public void SetInputData(vtkDataObject arg0)
		{
			vtkMultiBlockDataSetAlgorithm.vtkMultiBlockDataSetAlgorithm_SetInputData_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06004318 RID: 17176
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiBlockDataSetAlgorithm_SetInputData_11(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06004319 RID: 17177 RVA: 0x00062544 File Offset: 0x00060744
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkMultiBlockDataSetAlgorithm.vtkMultiBlockDataSetAlgorithm_SetInputData_11(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000706 RID: 1798
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiBlockDataSetAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000707 RID: 1799
		public new static readonly string MRClassNameKey = "class vtkMultiBlockDataSetAlgorithm";
	}
}
