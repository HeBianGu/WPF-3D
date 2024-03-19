using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOverlappingAMRAlgorithm
	/// </summary>
	/// <remarks>
	///    A base class for all algorithms that take as input vtkOverlappingAMR and
	///  produce vtkOverlappingAMR.
	/// </remarks>
	// Token: 0x02000223 RID: 547
	public class vtkOverlappingAMRAlgorithm : vtkUniformGridAMRAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600670E RID: 26382 RVA: 0x00094A88 File Offset: 0x00092C88
		static vtkOverlappingAMRAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOverlappingAMRAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOverlappingAMRAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600670F RID: 26383 RVA: 0x00094AB0 File Offset: 0x00092CB0
		public vtkOverlappingAMRAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006710 RID: 26384
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMRAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006711 RID: 26385 RVA: 0x00094AC0 File Offset: 0x00092CC0
		public new static vtkOverlappingAMRAlgorithm New()
		{
			vtkOverlappingAMRAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlappingAMRAlgorithm.vtkOverlappingAMRAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverlappingAMRAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006712 RID: 26386 RVA: 0x00094B14 File Offset: 0x00092D14
		public vtkOverlappingAMRAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOverlappingAMRAlgorithm.vtkOverlappingAMRAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006713 RID: 26387 RVA: 0x00094B58 File Offset: 0x00092D58
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006714 RID: 26388
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOverlappingAMRAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006715 RID: 26389 RVA: 0x00094B64 File Offset: 0x00092D64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOverlappingAMRAlgorithm.vtkOverlappingAMRAlgorithm_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06006716 RID: 26390
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOverlappingAMRAlgorithm_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006717 RID: 26391 RVA: 0x00094B84 File Offset: 0x00092D84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOverlappingAMRAlgorithm.vtkOverlappingAMRAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06006718 RID: 26392
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMRAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm
		/// </summary>
		// Token: 0x06006719 RID: 26393 RVA: 0x00094BA0 File Offset: 0x00092DA0
		public new vtkOverlappingAMR GetOutput()
		{
			vtkOverlappingAMR vtkOverlappingAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlappingAMRAlgorithm.vtkOverlappingAMRAlgorithm_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOverlappingAMR = (vtkOverlappingAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOverlappingAMR.Register(null);
				}
			}
			return vtkOverlappingAMR;
		}

		// Token: 0x0600671A RID: 26394
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMRAlgorithm_GetOutput_04(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm
		/// </summary>
		// Token: 0x0600671B RID: 26395 RVA: 0x00094C10 File Offset: 0x00092E10
		public new vtkOverlappingAMR GetOutput(int arg0)
		{
			vtkOverlappingAMR vtkOverlappingAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlappingAMRAlgorithm.vtkOverlappingAMRAlgorithm_GetOutput_04(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOverlappingAMR = (vtkOverlappingAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOverlappingAMR.Register(null);
				}
			}
			return vtkOverlappingAMR;
		}

		// Token: 0x0600671C RID: 26396
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOverlappingAMRAlgorithm_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600671D RID: 26397 RVA: 0x00094C80 File Offset: 0x00092E80
		public override int IsA(string type)
		{
			return vtkOverlappingAMRAlgorithm.vtkOverlappingAMRAlgorithm_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600671E RID: 26398
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOverlappingAMRAlgorithm_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600671F RID: 26399 RVA: 0x00094CA0 File Offset: 0x00092EA0
		public new static int IsTypeOf(string type)
		{
			return vtkOverlappingAMRAlgorithm.vtkOverlappingAMRAlgorithm_IsTypeOf_06(type);
		}

		// Token: 0x06006720 RID: 26400
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMRAlgorithm_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006721 RID: 26401 RVA: 0x00094CBC File Offset: 0x00092EBC
		public new vtkOverlappingAMRAlgorithm NewInstance()
		{
			vtkOverlappingAMRAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlappingAMRAlgorithm.vtkOverlappingAMRAlgorithm_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverlappingAMRAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006722 RID: 26402
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMRAlgorithm_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006723 RID: 26403 RVA: 0x00094D18 File Offset: 0x00092F18
		public new static vtkOverlappingAMRAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkOverlappingAMRAlgorithm vtkOverlappingAMRAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlappingAMRAlgorithm.vtkOverlappingAMRAlgorithm_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOverlappingAMRAlgorithm = (vtkOverlappingAMRAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOverlappingAMRAlgorithm.Register(null);
				}
			}
			return vtkOverlappingAMRAlgorithm;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400092D RID: 2349
		public new const string MRFullTypeName = "Kitware.VTK.vtkOverlappingAMRAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400092E RID: 2350
		public new static readonly string MRClassNameKey = "class vtkOverlappingAMRAlgorithm";
	}
}
