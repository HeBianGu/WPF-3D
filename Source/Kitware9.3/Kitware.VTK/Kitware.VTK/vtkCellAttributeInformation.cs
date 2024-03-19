using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellAttributeInformation
	/// </summary>
	/// <remarks>
	///    Provide information about a cell attribute's basis functions on one cell type.
	///
	/// Note that some of the methods may be unable to return meaningful
	/// information about some attribute types; this class has methods
	/// that may be specific to subclasses of vtkDGCell. If this API does
	/// not fit your cell type or attribute type; do not register a
	/// calculator subclass of this type.
	/// Instead, it is up to consuming code to ensure a non-null calculator
	/// is returned.
	///
	/// This calculator assumes interpolation is performed as a weighted sum
	/// of basis functions evaluated at some parameter value.
	///
	/// \f[
	///    f_j = \sum_i B_i(r) w_{i,j}
	/// \f]
	///
	/// where \f$i\in[0, M - 1]\f$ and \f$j\in[0,N - 1[\f$.
	/// + \f$M\f$ is GetNumberOfBasisFunctions().
	/// + \f$N\f$ is NumberOfComponentsPerDegreeOfFreedom().
	/// </remarks>
	// Token: 0x020004D9 RID: 1241
	public abstract class vtkCellAttributeInformation : vtkCellAttributeCalculator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E11D RID: 57629 RVA: 0x00138ACF File Offset: 0x00136CCF
		static vtkCellAttributeInformation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellAttributeInformation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellAttributeInformation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E11E RID: 57630 RVA: 0x00138AF7 File Offset: 0x00136CF7
		public vtkCellAttributeInformation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E11F RID: 57631 RVA: 0x00138B05 File Offset: 0x00136D05
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E120 RID: 57632
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkCellAttributeInformation_GetBasisName_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E121 RID: 57633 RVA: 0x00138B10 File Offset: 0x00136D10
		public virtual string GetBasisName()
		{
			return vtkCellAttributeInformation.vtkCellAttributeInformation_GetBasisName_01(base.GetCppThis());
		}

		// Token: 0x0600E122 RID: 57634
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellAttributeInformation_GetBasisOrder_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E123 RID: 57635 RVA: 0x00138B30 File Offset: 0x00136D30
		public virtual int GetBasisOrder()
		{
			return vtkCellAttributeInformation.vtkCellAttributeInformation_GetBasisOrder_02(base.GetCppThis());
		}

		// Token: 0x0600E124 RID: 57636
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellAttributeInformation_GetBasisValueSize_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E125 RID: 57637 RVA: 0x00138B50 File Offset: 0x00136D50
		public virtual int GetBasisValueSize()
		{
			return vtkCellAttributeInformation.vtkCellAttributeInformation_GetBasisValueSize_03(base.GetCppThis());
		}

		// Token: 0x0600E126 RID: 57638
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellAttributeInformation_GetDegreeOfFreedomSize_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E127 RID: 57639 RVA: 0x00138B70 File Offset: 0x00136D70
		public virtual int GetDegreeOfFreedomSize()
		{
			return vtkCellAttributeInformation.vtkCellAttributeInformation_GetDegreeOfFreedomSize_04(base.GetCppThis());
		}

		// Token: 0x0600E128 RID: 57640
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellAttributeInformation_GetNumberOfBasisFunctions_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E129 RID: 57641 RVA: 0x00138B90 File Offset: 0x00136D90
		public virtual int GetNumberOfBasisFunctions()
		{
			return vtkCellAttributeInformation.vtkCellAttributeInformation_GetNumberOfBasisFunctions_05(base.GetCppThis());
		}

		// Token: 0x0600E12A RID: 57642
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellAttributeInformation_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E12B RID: 57643 RVA: 0x00138BB0 File Offset: 0x00136DB0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellAttributeInformation.vtkCellAttributeInformation_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600E12C RID: 57644
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellAttributeInformation_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E12D RID: 57645 RVA: 0x00138BD0 File Offset: 0x00136DD0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellAttributeInformation.vtkCellAttributeInformation_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600E12E RID: 57646
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellAttributeInformation_GetSharedDegreesOfFreedom_08(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E12F RID: 57647 RVA: 0x00138BEC File Offset: 0x00136DEC
		public virtual bool GetSharedDegreesOfFreedom()
		{
			return vtkCellAttributeInformation.vtkCellAttributeInformation_GetSharedDegreesOfFreedom_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E130 RID: 57648
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellAttributeInformation_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E131 RID: 57649 RVA: 0x00138C14 File Offset: 0x00136E14
		public override int IsA(string type)
		{
			return vtkCellAttributeInformation.vtkCellAttributeInformation_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600E132 RID: 57650
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellAttributeInformation_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E133 RID: 57651 RVA: 0x00138C34 File Offset: 0x00136E34
		public new static int IsTypeOf(string type)
		{
			return vtkCellAttributeInformation.vtkCellAttributeInformation_IsTypeOf_10(type);
		}

		// Token: 0x0600E134 RID: 57652
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellAttributeInformation_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E135 RID: 57653 RVA: 0x00138C50 File Offset: 0x00136E50
		public new vtkCellAttributeInformation NewInstance()
		{
			vtkCellAttributeInformation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellAttributeInformation.vtkCellAttributeInformation_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellAttributeInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E136 RID: 57654
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellAttributeInformation_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E137 RID: 57655 RVA: 0x00138CAC File Offset: 0x00136EAC
		public new static vtkCellAttributeInformation SafeDownCast(vtkObjectBase o)
		{
			vtkCellAttributeInformation vtkCellAttributeInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellAttributeInformation.vtkCellAttributeInformation_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellAttributeInformation = (vtkCellAttributeInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellAttributeInformation.Register(null);
				}
			}
			return vtkCellAttributeInformation;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400108D RID: 4237
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellAttributeInformation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400108E RID: 4238
		public new static readonly string MRClassNameKey = "class vtkCellAttributeInformation";
	}
}
