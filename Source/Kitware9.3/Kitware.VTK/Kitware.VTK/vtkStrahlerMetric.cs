using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStrahlerMetric
	/// </summary>
	/// <remarks>
	///    compute Strahler metric for a tree
	///
	/// The Strahler metric is a value assigned to each vertex of a
	/// tree that characterizes the structural complexity of the
	/// sub-tree rooted at that node.  The metric originated in the
	/// study of river systems, but has been applied to other tree-
	/// structured systes,  Details of the metric and the rationale
	/// for using it in infovis can be found in:
	///
	/// Tree Visualization and Navigation Clues for Information
	/// Visualization, I. Herman, M. Delest, and G. Melancon,
	/// Computer Graphics Forum, Vol 17(2), Blackwell, 1998.
	///
	/// The input tree is copied to the output, but with a new array
	/// added to the output vertex data.
	///
	/// @par Thanks:
	/// Thanks to David Duke from the University of Leeds for providing this
	/// implementation.
	/// </remarks>
	// Token: 0x02000750 RID: 1872
	public class vtkStrahlerMetric : vtkTreeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060136D9 RID: 79577 RVA: 0x001B7C97 File Offset: 0x001B5E97
		static vtkStrahlerMetric()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStrahlerMetric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStrahlerMetric"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060136DA RID: 79578 RVA: 0x001B7CBF File Offset: 0x001B5EBF
		public vtkStrahlerMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060136DB RID: 79579
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStrahlerMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060136DC RID: 79580 RVA: 0x001B7CD0 File Offset: 0x001B5ED0
		public new static vtkStrahlerMetric New()
		{
			vtkStrahlerMetric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStrahlerMetric.vtkStrahlerMetric_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStrahlerMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060136DD RID: 79581 RVA: 0x001B7D24 File Offset: 0x001B5F24
		public vtkStrahlerMetric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStrahlerMetric.vtkStrahlerMetric_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060136DE RID: 79582 RVA: 0x001B7D68 File Offset: 0x001B5F68
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060136DF RID: 79583
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkStrahlerMetric_GetMaxStrahler_01(HandleRef pThis);

		/// <summary>
		/// Get the maximum strahler value for the tree.
		/// </summary>
		// Token: 0x060136E0 RID: 79584 RVA: 0x001B7D74 File Offset: 0x001B5F74
		public virtual float GetMaxStrahler()
		{
			return vtkStrahlerMetric.vtkStrahlerMetric_GetMaxStrahler_01(base.GetCppThis());
		}

		// Token: 0x060136E1 RID: 79585
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStrahlerMetric_GetNormalize_02(HandleRef pThis);

		/// <summary>
		/// Set/get setting of normalize flag.  If this is set, the
		/// Strahler values are scaled into the range [0..1].
		/// Default is for normalization to be OFF.
		/// </summary>
		// Token: 0x060136E2 RID: 79586 RVA: 0x001B7D94 File Offset: 0x001B5F94
		public virtual int GetNormalize()
		{
			return vtkStrahlerMetric.vtkStrahlerMetric_GetNormalize_02(base.GetCppThis());
		}

		// Token: 0x060136E3 RID: 79587
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStrahlerMetric_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060136E4 RID: 79588 RVA: 0x001B7DB4 File Offset: 0x001B5FB4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStrahlerMetric.vtkStrahlerMetric_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060136E5 RID: 79589
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStrahlerMetric_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060136E6 RID: 79590 RVA: 0x001B7DD4 File Offset: 0x001B5FD4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStrahlerMetric.vtkStrahlerMetric_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060136E7 RID: 79591
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStrahlerMetric_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060136E8 RID: 79592 RVA: 0x001B7DF0 File Offset: 0x001B5FF0
		public override int IsA(string type)
		{
			return vtkStrahlerMetric.vtkStrahlerMetric_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060136E9 RID: 79593
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStrahlerMetric_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060136EA RID: 79594 RVA: 0x001B7E10 File Offset: 0x001B6010
		public new static int IsTypeOf(string type)
		{
			return vtkStrahlerMetric.vtkStrahlerMetric_IsTypeOf_06(type);
		}

		// Token: 0x060136EB RID: 79595
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStrahlerMetric_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060136EC RID: 79596 RVA: 0x001B7E2C File Offset: 0x001B602C
		public new vtkStrahlerMetric NewInstance()
		{
			vtkStrahlerMetric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStrahlerMetric.vtkStrahlerMetric_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStrahlerMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060136ED RID: 79597
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStrahlerMetric_NormalizeOff_09(HandleRef pThis);

		/// <summary>
		/// Set/get setting of normalize flag.  If this is set, the
		/// Strahler values are scaled into the range [0..1].
		/// Default is for normalization to be OFF.
		/// </summary>
		// Token: 0x060136EE RID: 79598 RVA: 0x001B7E86 File Offset: 0x001B6086
		public virtual void NormalizeOff()
		{
			vtkStrahlerMetric.vtkStrahlerMetric_NormalizeOff_09(base.GetCppThis());
		}

		// Token: 0x060136EF RID: 79599
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStrahlerMetric_NormalizeOn_10(HandleRef pThis);

		/// <summary>
		/// Set/get setting of normalize flag.  If this is set, the
		/// Strahler values are scaled into the range [0..1].
		/// Default is for normalization to be OFF.
		/// </summary>
		// Token: 0x060136F0 RID: 79600 RVA: 0x001B7E95 File Offset: 0x001B6095
		public virtual void NormalizeOn()
		{
			vtkStrahlerMetric.vtkStrahlerMetric_NormalizeOn_10(base.GetCppThis());
		}

		// Token: 0x060136F1 RID: 79601
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStrahlerMetric_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060136F2 RID: 79602 RVA: 0x001B7EA4 File Offset: 0x001B60A4
		public new static vtkStrahlerMetric SafeDownCast(vtkObjectBase o)
		{
			vtkStrahlerMetric vtkStrahlerMetric = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStrahlerMetric.vtkStrahlerMetric_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStrahlerMetric = (vtkStrahlerMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStrahlerMetric.Register(null);
				}
			}
			return vtkStrahlerMetric;
		}

		// Token: 0x060136F3 RID: 79603
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStrahlerMetric_SetMetricArrayName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the name of the array in which the Strahler values will
		/// be stored within the output vertex data.
		/// Default is "Strahler"
		/// </summary>
		// Token: 0x060136F4 RID: 79604 RVA: 0x001B7F23 File Offset: 0x001B6123
		public virtual void SetMetricArrayName(string _arg)
		{
			vtkStrahlerMetric.vtkStrahlerMetric_SetMetricArrayName_12(base.GetCppThis(), _arg);
		}

		// Token: 0x060136F5 RID: 79605
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStrahlerMetric_SetNormalize_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get setting of normalize flag.  If this is set, the
		/// Strahler values are scaled into the range [0..1].
		/// Default is for normalization to be OFF.
		/// </summary>
		// Token: 0x060136F6 RID: 79606 RVA: 0x001B7F33 File Offset: 0x001B6133
		public virtual void SetNormalize(int _arg)
		{
			vtkStrahlerMetric.vtkStrahlerMetric_SetNormalize_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001679 RID: 5753
		public new const string MRFullTypeName = "Kitware.VTK.vtkStrahlerMetric";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400167A RID: 5754
		public new static readonly string MRClassNameKey = "class vtkStrahlerMetric";
	}
}
