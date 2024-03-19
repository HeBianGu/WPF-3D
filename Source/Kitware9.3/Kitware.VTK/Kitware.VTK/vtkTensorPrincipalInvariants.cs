using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTensorPrincipalInvariants
	/// </summary>
	/// <remarks>
	///    Compute principal values and directions from symmetric tensor
	///
	/// This filter computes principal values and vectors of symmetric tensors.
	/// The principal values are ordered from largest to smallest.
	/// The principal vectors can be scaled with the principal values.
	/// </remarks>
	// Token: 0x02000413 RID: 1043
	public class vtkTensorPrincipalInvariants : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C53A RID: 50490 RVA: 0x001123C3 File Offset: 0x001105C3
		static vtkTensorPrincipalInvariants()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTensorPrincipalInvariants.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTensorPrincipalInvariants"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C53B RID: 50491 RVA: 0x001123EB File Offset: 0x001105EB
		public vtkTensorPrincipalInvariants(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C53C RID: 50492
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorPrincipalInvariants_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C53D RID: 50493 RVA: 0x001123FC File Offset: 0x001105FC
		public new static vtkTensorPrincipalInvariants New()
		{
			vtkTensorPrincipalInvariants result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorPrincipalInvariants.vtkTensorPrincipalInvariants_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTensorPrincipalInvariants)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C53E RID: 50494 RVA: 0x00112450 File Offset: 0x00110650
		public vtkTensorPrincipalInvariants() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTensorPrincipalInvariants.vtkTensorPrincipalInvariants_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C53F RID: 50495 RVA: 0x00112494 File Offset: 0x00110694
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C540 RID: 50496
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorPrincipalInvariants_GetCellDataArraySelection_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the cell data array selection that specifies which cell data arrays
		/// should have their principal invariants computed.
		/// </summary>
		// Token: 0x0600C541 RID: 50497 RVA: 0x001124A0 File Offset: 0x001106A0
		public virtual vtkDataArraySelection GetCellDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorPrincipalInvariants.vtkTensorPrincipalInvariants_GetCellDataArraySelection_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x0600C542 RID: 50498
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTensorPrincipalInvariants_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C543 RID: 50499 RVA: 0x00112510 File Offset: 0x00110710
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTensorPrincipalInvariants.vtkTensorPrincipalInvariants_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C544 RID: 50500
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTensorPrincipalInvariants_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C545 RID: 50501 RVA: 0x00112530 File Offset: 0x00110730
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTensorPrincipalInvariants.vtkTensorPrincipalInvariants_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C546 RID: 50502
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorPrincipalInvariants_GetPointDataArraySelection_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the point data array selection that specifies which point data arrays
		/// should have their principal invariants computed.
		/// </summary>
		// Token: 0x0600C547 RID: 50503 RVA: 0x0011254C File Offset: 0x0011074C
		public virtual vtkDataArraySelection GetPointDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorPrincipalInvariants.vtkTensorPrincipalInvariants_GetPointDataArraySelection_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x0600C548 RID: 50504
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTensorPrincipalInvariants_GetScaleVectors_05(HandleRef pThis);

		/// <summary>
		/// Set/get whether the principal vectors should be scaled with the principal values.
		/// Default is false.
		/// </summary>
		// Token: 0x0600C549 RID: 50505 RVA: 0x001125BC File Offset: 0x001107BC
		public virtual bool GetScaleVectors()
		{
			return vtkTensorPrincipalInvariants.vtkTensorPrincipalInvariants_GetScaleVectors_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C54A RID: 50506
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkTensorPrincipalInvariants_GetSigmaValueArrayName_06([MarshalAs(UnmanagedType.LPUTF8Str)] string baseName, int index);

		/// <summary>
		/// Return the given array name with a suffix for principal values attached.
		/// </summary>
		// Token: 0x0600C54B RID: 50507 RVA: 0x001125E4 File Offset: 0x001107E4
		public static string GetSigmaValueArrayName(string baseName, int index)
		{
			return vtkTensorPrincipalInvariants.vtkTensorPrincipalInvariants_GetSigmaValueArrayName_06(baseName, index);
		}

		// Token: 0x0600C54C RID: 50508
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkTensorPrincipalInvariants_GetSigmaVectorArrayName_07([MarshalAs(UnmanagedType.LPUTF8Str)] string baseName, int index);

		/// <summary>
		/// Return the given array name with a suffix for principal vectors attached.
		/// </summary>
		// Token: 0x0600C54D RID: 50509 RVA: 0x00112600 File Offset: 0x00110800
		public static string GetSigmaVectorArrayName(string baseName, int index)
		{
			return vtkTensorPrincipalInvariants.vtkTensorPrincipalInvariants_GetSigmaVectorArrayName_07(baseName, index);
		}

		// Token: 0x0600C54E RID: 50510
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorPrincipalInvariants_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C54F RID: 50511 RVA: 0x0011261C File Offset: 0x0011081C
		public override int IsA(string type)
		{
			return vtkTensorPrincipalInvariants.vtkTensorPrincipalInvariants_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600C550 RID: 50512
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorPrincipalInvariants_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C551 RID: 50513 RVA: 0x0011263C File Offset: 0x0011083C
		public new static int IsTypeOf(string type)
		{
			return vtkTensorPrincipalInvariants.vtkTensorPrincipalInvariants_IsTypeOf_09(type);
		}

		// Token: 0x0600C552 RID: 50514
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorPrincipalInvariants_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C553 RID: 50515 RVA: 0x00112658 File Offset: 0x00110858
		public new vtkTensorPrincipalInvariants NewInstance()
		{
			vtkTensorPrincipalInvariants result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorPrincipalInvariants.vtkTensorPrincipalInvariants_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTensorPrincipalInvariants)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C554 RID: 50516
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorPrincipalInvariants_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C555 RID: 50517 RVA: 0x001126B4 File Offset: 0x001108B4
		public new static vtkTensorPrincipalInvariants SafeDownCast(vtkObjectBase o)
		{
			vtkTensorPrincipalInvariants vtkTensorPrincipalInvariants = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorPrincipalInvariants.vtkTensorPrincipalInvariants_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTensorPrincipalInvariants = (vtkTensorPrincipalInvariants)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTensorPrincipalInvariants.Register(null);
				}
			}
			return vtkTensorPrincipalInvariants;
		}

		// Token: 0x0600C556 RID: 50518
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorPrincipalInvariants_SetScaleVectors_13(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/get whether the principal vectors should be scaled with the principal values.
		/// Default is false.
		/// </summary>
		// Token: 0x0600C557 RID: 50519 RVA: 0x00112733 File Offset: 0x00110933
		public virtual void SetScaleVectors(bool _arg)
		{
			vtkTensorPrincipalInvariants.vtkTensorPrincipalInvariants_SetScaleVectors_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EB4 RID: 3764
		public new const string MRFullTypeName = "Kitware.VTK.vtkTensorPrincipalInvariants";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EB5 RID: 3765
		public new static readonly string MRClassNameKey = "class vtkTensorPrincipalInvariants";
	}
}
