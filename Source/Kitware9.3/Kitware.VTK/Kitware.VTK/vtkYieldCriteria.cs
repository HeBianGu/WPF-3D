using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkYieldCriteria
	/// </summary>
	/// <remarks>
	///    Compute principal stress and yield criteria from symmetric tensor
	///
	/// This filter computes various yield criteria from symmetric tensors including:
	///   - Principal stress values and vectors
	///   - Tresca criterion
	///   - Von Mises criterion
	///
	/// The principal values are ordered from largest to smallest.
	///   - sigmaN value: Nth principal stress eigenvalue
	///   - sigmaN vector: Nth principal stress vector (can be scaled with the value)
	///   - Tresca criterion : |sigma3 - sigma1|
	///   - Von Mises criterion:
	///     sqrt( (sigma1 - sigma2)^2 + (sigma2 - sigma3)^2 + (sigma1 - sigma3)^2 ) / sqrt(2)
	/// </remarks>
	// Token: 0x02000414 RID: 1044
	public class vtkYieldCriteria : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C558 RID: 50520 RVA: 0x0011274B File Offset: 0x0011094B
		static vtkYieldCriteria()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkYieldCriteria.MRClassNameKey, Type.GetType("Kitware.VTK.vtkYieldCriteria"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C559 RID: 50521 RVA: 0x00112773 File Offset: 0x00110973
		public vtkYieldCriteria(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C55A RID: 50522
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkYieldCriteria_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C55B RID: 50523 RVA: 0x00112784 File Offset: 0x00110984
		public new static vtkYieldCriteria New()
		{
			vtkYieldCriteria result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkYieldCriteria.vtkYieldCriteria_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkYieldCriteria)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C55C RID: 50524 RVA: 0x001127D8 File Offset: 0x001109D8
		public vtkYieldCriteria() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkYieldCriteria.vtkYieldCriteria_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C55D RID: 50525 RVA: 0x0011281C File Offset: 0x00110A1C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C55E RID: 50526
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkYieldCriteria_GetCellDataArraySelection_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the cell data array selection that specifies which cell data arrays
		/// should have their yield criteria computed.
		/// </summary>
		// Token: 0x0600C55F RID: 50527 RVA: 0x00112828 File Offset: 0x00110A28
		public virtual vtkDataArraySelection GetCellDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkYieldCriteria.vtkYieldCriteria_GetCellDataArraySelection_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600C560 RID: 50528
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkYieldCriteria_GetCriteriaSelection_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the selection of yield criteria to compute.
		/// </summary>
		// Token: 0x0600C561 RID: 50529 RVA: 0x00112898 File Offset: 0x00110A98
		public virtual vtkDataArraySelection GetCriteriaSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkYieldCriteria.vtkYieldCriteria_GetCriteriaSelection_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600C562 RID: 50530
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkYieldCriteria_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C563 RID: 50531 RVA: 0x00112908 File Offset: 0x00110B08
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkYieldCriteria.vtkYieldCriteria_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600C564 RID: 50532
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkYieldCriteria_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C565 RID: 50533 RVA: 0x00112928 File Offset: 0x00110B28
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkYieldCriteria.vtkYieldCriteria_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600C566 RID: 50534
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkYieldCriteria_GetPointDataArraySelection_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the point data array selection that specifies which point data arrays
		/// should have their yield criteria computed.
		/// </summary>
		// Token: 0x0600C567 RID: 50535 RVA: 0x00112944 File Offset: 0x00110B44
		public virtual vtkDataArraySelection GetPointDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkYieldCriteria.vtkYieldCriteria_GetPointDataArraySelection_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600C568 RID: 50536
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkYieldCriteria_GetScaleVectors_06(HandleRef pThis);

		/// <summary>
		/// Set/get whether the principal vectors should be scaled with the principal values.
		/// Default is false.
		/// </summary>
		// Token: 0x0600C569 RID: 50537 RVA: 0x001129B4 File Offset: 0x00110BB4
		public virtual bool GetScaleVectors()
		{
			return vtkYieldCriteria.vtkYieldCriteria_GetScaleVectors_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C56A RID: 50538
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkYieldCriteria_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C56B RID: 50539 RVA: 0x001129DC File Offset: 0x00110BDC
		public override int IsA(string type)
		{
			return vtkYieldCriteria.vtkYieldCriteria_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600C56C RID: 50540
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkYieldCriteria_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C56D RID: 50541 RVA: 0x001129FC File Offset: 0x00110BFC
		public new static int IsTypeOf(string type)
		{
			return vtkYieldCriteria.vtkYieldCriteria_IsTypeOf_08(type);
		}

		// Token: 0x0600C56E RID: 50542
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkYieldCriteria_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C56F RID: 50543 RVA: 0x00112A18 File Offset: 0x00110C18
		public new vtkYieldCriteria NewInstance()
		{
			vtkYieldCriteria result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkYieldCriteria.vtkYieldCriteria_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkYieldCriteria)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C570 RID: 50544
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkYieldCriteria_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C571 RID: 50545 RVA: 0x00112A74 File Offset: 0x00110C74
		public new static vtkYieldCriteria SafeDownCast(vtkObjectBase o)
		{
			vtkYieldCriteria vtkYieldCriteria = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkYieldCriteria.vtkYieldCriteria_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkYieldCriteria = (vtkYieldCriteria)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkYieldCriteria.Register(null);
				}
			}
			return vtkYieldCriteria;
		}

		// Token: 0x0600C572 RID: 50546
		[DllImport("Kitware.VTK.FiltersTensor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkYieldCriteria_SetScaleVectors_12(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/get whether the principal vectors should be scaled with the principal values.
		/// Default is false.
		/// </summary>
		// Token: 0x0600C573 RID: 50547 RVA: 0x00112AF3 File Offset: 0x00110CF3
		public virtual void SetScaleVectors(bool _arg)
		{
			vtkYieldCriteria.vtkYieldCriteria_SetScaleVectors_12(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EB6 RID: 3766
		public new const string MRFullTypeName = "Kitware.VTK.vtkYieldCriteria";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EB7 RID: 3767
		public new static readonly string MRClassNameKey = "class vtkYieldCriteria";

		/// <summary>
		/// Enum of supported yield criteria.
		/// </summary>
		// Token: 0x02000415 RID: 1045
		public enum Criterion
		{
			/// <summary>enum member</summary>
			// Token: 0x04000EB9 RID: 3769
			PrincipalStress,
			/// <summary>enum member</summary>
			// Token: 0x04000EBA RID: 3770
			Tresca,
			/// <summary>enum member</summary>
			// Token: 0x04000EBB RID: 3771
			VonMises
		}
	}
}
