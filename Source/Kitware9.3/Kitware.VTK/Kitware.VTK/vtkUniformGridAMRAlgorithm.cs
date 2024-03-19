using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUniformGridAMRAlgorithm
	///  vtkUniformGridAMR as output.
	///
	///
	///  A base class for all algorithms that take as input any type of data object
	///  including composite datasets and produce vtkUniformGridAMR in the output.
	/// </summary>
	// Token: 0x02000222 RID: 546
	public class vtkUniformGridAMRAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060066F4 RID: 26356 RVA: 0x00094718 File Offset: 0x00092918
		static vtkUniformGridAMRAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUniformGridAMRAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUniformGridAMRAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060066F5 RID: 26357 RVA: 0x00094740 File Offset: 0x00092940
		public vtkUniformGridAMRAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060066F6 RID: 26358
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMRAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066F7 RID: 26359 RVA: 0x00094750 File Offset: 0x00092950
		public new static vtkUniformGridAMRAlgorithm New()
		{
			vtkUniformGridAMRAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMRAlgorithm.vtkUniformGridAMRAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUniformGridAMRAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066F8 RID: 26360 RVA: 0x000947A4 File Offset: 0x000929A4
		public vtkUniformGridAMRAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUniformGridAMRAlgorithm.vtkUniformGridAMRAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060066F9 RID: 26361 RVA: 0x000947E8 File Offset: 0x000929E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060066FA RID: 26362
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUniformGridAMRAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066FB RID: 26363 RVA: 0x000947F4 File Offset: 0x000929F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUniformGridAMRAlgorithm.vtkUniformGridAMRAlgorithm_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060066FC RID: 26364
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUniformGridAMRAlgorithm_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066FD RID: 26365 RVA: 0x00094814 File Offset: 0x00092A14
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUniformGridAMRAlgorithm.vtkUniformGridAMRAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060066FE RID: 26366
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMRAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm
		/// </summary>
		// Token: 0x060066FF RID: 26367 RVA: 0x00094830 File Offset: 0x00092A30
		public vtkUniformGridAMR GetOutput()
		{
			vtkUniformGridAMR vtkUniformGridAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMRAlgorithm.vtkUniformGridAMRAlgorithm_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniformGridAMR = (vtkUniformGridAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniformGridAMR.Register(null);
				}
			}
			return vtkUniformGridAMR;
		}

		// Token: 0x06006700 RID: 26368
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMRAlgorithm_GetOutput_04(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm
		/// </summary>
		// Token: 0x06006701 RID: 26369 RVA: 0x000948A0 File Offset: 0x00092AA0
		public vtkUniformGridAMR GetOutput(int arg0)
		{
			vtkUniformGridAMR vtkUniformGridAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMRAlgorithm.vtkUniformGridAMRAlgorithm_GetOutput_04(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniformGridAMR = (vtkUniformGridAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniformGridAMR.Register(null);
				}
			}
			return vtkUniformGridAMR;
		}

		// Token: 0x06006702 RID: 26370
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGridAMRAlgorithm_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006703 RID: 26371 RVA: 0x00094910 File Offset: 0x00092B10
		public override int IsA(string type)
		{
			return vtkUniformGridAMRAlgorithm.vtkUniformGridAMRAlgorithm_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06006704 RID: 26372
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGridAMRAlgorithm_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006705 RID: 26373 RVA: 0x00094930 File Offset: 0x00092B30
		public new static int IsTypeOf(string type)
		{
			return vtkUniformGridAMRAlgorithm.vtkUniformGridAMRAlgorithm_IsTypeOf_06(type);
		}

		// Token: 0x06006706 RID: 26374
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMRAlgorithm_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006707 RID: 26375 RVA: 0x0009494C File Offset: 0x00092B4C
		public new vtkUniformGridAMRAlgorithm NewInstance()
		{
			vtkUniformGridAMRAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMRAlgorithm.vtkUniformGridAMRAlgorithm_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUniformGridAMRAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006708 RID: 26376
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMRAlgorithm_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006709 RID: 26377 RVA: 0x000949A8 File Offset: 0x00092BA8
		public new static vtkUniformGridAMRAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkUniformGridAMRAlgorithm vtkUniformGridAMRAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMRAlgorithm.vtkUniformGridAMRAlgorithm_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniformGridAMRAlgorithm = (vtkUniformGridAMRAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniformGridAMRAlgorithm.Register(null);
				}
			}
			return vtkUniformGridAMRAlgorithm;
		}

		// Token: 0x0600670A RID: 26378
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridAMRAlgorithm_SetInputData_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set an input of this algorithm.
		/// </summary>
		// Token: 0x0600670B RID: 26379 RVA: 0x00094A28 File Offset: 0x00092C28
		public void SetInputData(vtkDataObject arg0)
		{
			vtkUniformGridAMRAlgorithm.vtkUniformGridAMRAlgorithm_SetInputData_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600670C RID: 26380
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridAMRAlgorithm_SetInputData_11(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Set an input of this algorithm.
		/// </summary>
		// Token: 0x0600670D RID: 26381 RVA: 0x00094A58 File Offset: 0x00092C58
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkUniformGridAMRAlgorithm.vtkUniformGridAMRAlgorithm_SetInputData_11(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400092B RID: 2347
		public new const string MRFullTypeName = "Kitware.VTK.vtkUniformGridAMRAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400092C RID: 2348
		public new static readonly string MRClassNameKey = "class vtkUniformGridAMRAlgorithm";
	}
}
