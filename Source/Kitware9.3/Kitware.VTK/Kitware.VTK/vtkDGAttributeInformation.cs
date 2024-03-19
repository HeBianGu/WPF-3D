using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDGAttributeInformation
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
	// Token: 0x020004DB RID: 1243
	public class vtkDGAttributeInformation : vtkCellAttributeInformation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E14C RID: 57676 RVA: 0x00138F83 File Offset: 0x00137183
		static vtkDGAttributeInformation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDGAttributeInformation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDGAttributeInformation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E14D RID: 57677 RVA: 0x00138FAB File Offset: 0x001371AB
		public vtkDGAttributeInformation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E14E RID: 57678
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGAttributeInformation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E14F RID: 57679 RVA: 0x00138FBC File Offset: 0x001371BC
		public new static vtkDGAttributeInformation New()
		{
			vtkDGAttributeInformation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGAttributeInformation.vtkDGAttributeInformation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGAttributeInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E150 RID: 57680 RVA: 0x00139010 File Offset: 0x00137210
		public vtkDGAttributeInformation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDGAttributeInformation.vtkDGAttributeInformation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E151 RID: 57681 RVA: 0x00139054 File Offset: 0x00137254
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E152 RID: 57682
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDGAttributeInformation_BasisShapeName_01(HandleRef cellType);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E153 RID: 57683 RVA: 0x00139060 File Offset: 0x00137260
		public static string BasisShapeName(vtkDGCell cellType)
		{
			return vtkDGAttributeInformation.vtkDGAttributeInformation_BasisShapeName_01((cellType == null) ? default(HandleRef) : cellType.GetCppThis());
		}

		// Token: 0x0600E154 RID: 57684
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDGAttributeInformation_GetBasisName_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E155 RID: 57685 RVA: 0x00139090 File Offset: 0x00137290
		public override string GetBasisName()
		{
			return vtkDGAttributeInformation.vtkDGAttributeInformation_GetBasisName_02(base.GetCppThis());
		}

		// Token: 0x0600E156 RID: 57686
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGAttributeInformation_GetBasisOrder_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E157 RID: 57687 RVA: 0x001390B0 File Offset: 0x001372B0
		public override int GetBasisOrder()
		{
			return vtkDGAttributeInformation.vtkDGAttributeInformation_GetBasisOrder_03(base.GetCppThis());
		}

		// Token: 0x0600E158 RID: 57688
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGAttributeInformation_GetBasisValueSize_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E159 RID: 57689 RVA: 0x001390D0 File Offset: 0x001372D0
		public override int GetBasisValueSize()
		{
			return vtkDGAttributeInformation.vtkDGAttributeInformation_GetBasisValueSize_04(base.GetCppThis());
		}

		// Token: 0x0600E15A RID: 57690
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGAttributeInformation_GetDegreeOfFreedomSize_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E15B RID: 57691 RVA: 0x001390F0 File Offset: 0x001372F0
		public override int GetDegreeOfFreedomSize()
		{
			return vtkDGAttributeInformation.vtkDGAttributeInformation_GetDegreeOfFreedomSize_05(base.GetCppThis());
		}

		// Token: 0x0600E15C RID: 57692
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGAttributeInformation_GetNumberOfBasisFunctions_06(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E15D RID: 57693 RVA: 0x00139110 File Offset: 0x00137310
		public override int GetNumberOfBasisFunctions()
		{
			return vtkDGAttributeInformation.vtkDGAttributeInformation_GetNumberOfBasisFunctions_06(base.GetCppThis());
		}

		// Token: 0x0600E15E RID: 57694
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGAttributeInformation_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E15F RID: 57695 RVA: 0x00139130 File Offset: 0x00137330
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDGAttributeInformation.vtkDGAttributeInformation_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600E160 RID: 57696
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGAttributeInformation_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E161 RID: 57697 RVA: 0x00139150 File Offset: 0x00137350
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDGAttributeInformation.vtkDGAttributeInformation_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600E162 RID: 57698
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDGAttributeInformation_GetSharedDegreesOfFreedom_09(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E163 RID: 57699 RVA: 0x0013916C File Offset: 0x0013736C
		public override bool GetSharedDegreesOfFreedom()
		{
			return vtkDGAttributeInformation.vtkDGAttributeInformation_GetSharedDegreesOfFreedom_09(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E164 RID: 57700
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGAttributeInformation_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E165 RID: 57701 RVA: 0x00139194 File Offset: 0x00137394
		public override int IsA(string type)
		{
			return vtkDGAttributeInformation.vtkDGAttributeInformation_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600E166 RID: 57702
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGAttributeInformation_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E167 RID: 57703 RVA: 0x001391B4 File Offset: 0x001373B4
		public new static int IsTypeOf(string type)
		{
			return vtkDGAttributeInformation.vtkDGAttributeInformation_IsTypeOf_11(type);
		}

		// Token: 0x0600E168 RID: 57704
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGAttributeInformation_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E169 RID: 57705 RVA: 0x001391D0 File Offset: 0x001373D0
		public new vtkDGAttributeInformation NewInstance()
		{
			vtkDGAttributeInformation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGAttributeInformation.vtkDGAttributeInformation_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGAttributeInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E16A RID: 57706
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGAttributeInformation_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E16B RID: 57707 RVA: 0x0013922C File Offset: 0x0013742C
		public new static vtkDGAttributeInformation SafeDownCast(vtkObjectBase o)
		{
			vtkDGAttributeInformation vtkDGAttributeInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGAttributeInformation.vtkDGAttributeInformation_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDGAttributeInformation = (vtkDGAttributeInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDGAttributeInformation.Register(null);
				}
			}
			return vtkDGAttributeInformation;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001091 RID: 4241
		public new const string MRFullTypeName = "Kitware.VTK.vtkDGAttributeInformation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001092 RID: 4242
		public new static readonly string MRClassNameKey = "class vtkDGAttributeInformation";
	}
}
