using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMatrixMathFilter
	/// </summary>
	/// <remarks>
	///    Calculate functions of quality of the elements
	///  of a mesh
	///
	///
	/// vtkMatrixMathFilter computes one or more functions of mathematical quality for the
	/// cells or points in a mesh. The per-cell or per-point quality is added to the
	/// mesh's cell data or point data, in an array with names varied with different
	/// quality being queried. Note this filter always assume the data associate with
	/// the cells or points are 3 by 3 matrix.
	/// </remarks>
	// Token: 0x02000900 RID: 2304
	public class vtkMatrixMathFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017D09 RID: 97545 RVA: 0x00215F0F File Offset: 0x0021410F
		static vtkMatrixMathFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMatrixMathFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMatrixMathFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017D0A RID: 97546 RVA: 0x00215F37 File Offset: 0x00214137
		public vtkMatrixMathFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017D0B RID: 97547
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrixMathFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017D0C RID: 97548 RVA: 0x00215F48 File Offset: 0x00214148
		public new static vtkMatrixMathFilter New()
		{
			vtkMatrixMathFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrixMathFilter.vtkMatrixMathFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrixMathFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017D0D RID: 97549 RVA: 0x00215F9C File Offset: 0x0021419C
		public vtkMatrixMathFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMatrixMathFilter.vtkMatrixMathFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017D0E RID: 97550 RVA: 0x00215FE0 File Offset: 0x002141E0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017D0F RID: 97551
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMatrixMathFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017D10 RID: 97552 RVA: 0x00215FEC File Offset: 0x002141EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMatrixMathFilter.vtkMatrixMathFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06017D11 RID: 97553
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMatrixMathFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017D12 RID: 97554 RVA: 0x0021600C File Offset: 0x0021420C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMatrixMathFilter.vtkMatrixMathFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06017D13 RID: 97555
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMatrixMathFilter_GetOperation_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of query.
		/// </summary>
		// Token: 0x06017D14 RID: 97556 RVA: 0x00216028 File Offset: 0x00214228
		public virtual int GetOperation()
		{
			return vtkMatrixMathFilter.vtkMatrixMathFilter_GetOperation_03(base.GetCppThis());
		}

		// Token: 0x06017D15 RID: 97557
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMatrixMathFilter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017D16 RID: 97558 RVA: 0x00216048 File Offset: 0x00214248
		public override int IsA(string type)
		{
			return vtkMatrixMathFilter.vtkMatrixMathFilter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06017D17 RID: 97559
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMatrixMathFilter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017D18 RID: 97560 RVA: 0x00216068 File Offset: 0x00214268
		public new static int IsTypeOf(string type)
		{
			return vtkMatrixMathFilter.vtkMatrixMathFilter_IsTypeOf_05(type);
		}

		// Token: 0x06017D19 RID: 97561
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrixMathFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017D1A RID: 97562 RVA: 0x00216084 File Offset: 0x00214284
		public new vtkMatrixMathFilter NewInstance()
		{
			vtkMatrixMathFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrixMathFilter.vtkMatrixMathFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrixMathFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017D1B RID: 97563
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrixMathFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017D1C RID: 97564 RVA: 0x002160E0 File Offset: 0x002142E0
		public new static vtkMatrixMathFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMatrixMathFilter vtkMatrixMathFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrixMathFilter.vtkMatrixMathFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrixMathFilter = (vtkMatrixMathFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrixMathFilter.Register(null);
				}
			}
			return vtkMatrixMathFilter;
		}

		// Token: 0x06017D1D RID: 97565
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrixMathFilter_SetOperation_09(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of query.
		/// </summary>
		// Token: 0x06017D1E RID: 97566 RVA: 0x0021615F File Offset: 0x0021435F
		public virtual void SetOperation(int _arg)
		{
			vtkMatrixMathFilter.vtkMatrixMathFilter_SetOperation_09(base.GetCppThis(), _arg);
		}

		// Token: 0x06017D1F RID: 97567
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrixMathFilter_SetOperationToDeterminant_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of query.
		/// </summary>
		// Token: 0x06017D20 RID: 97568 RVA: 0x0021616F File Offset: 0x0021436F
		public void SetOperationToDeterminant()
		{
			vtkMatrixMathFilter.vtkMatrixMathFilter_SetOperationToDeterminant_10(base.GetCppThis());
		}

		// Token: 0x06017D21 RID: 97569
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrixMathFilter_SetOperationToEigenvalue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of query.
		/// </summary>
		// Token: 0x06017D22 RID: 97570 RVA: 0x0021617E File Offset: 0x0021437E
		public void SetOperationToEigenvalue()
		{
			vtkMatrixMathFilter.vtkMatrixMathFilter_SetOperationToEigenvalue_11(base.GetCppThis());
		}

		// Token: 0x06017D23 RID: 97571
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrixMathFilter_SetOperationToEigenvector_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of query.
		/// </summary>
		// Token: 0x06017D24 RID: 97572 RVA: 0x0021618D File Offset: 0x0021438D
		public void SetOperationToEigenvector()
		{
			vtkMatrixMathFilter.vtkMatrixMathFilter_SetOperationToEigenvector_12(base.GetCppThis());
		}

		// Token: 0x06017D25 RID: 97573
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrixMathFilter_SetOperationToInverse_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of query.
		/// </summary>
		// Token: 0x06017D26 RID: 97574 RVA: 0x0021619C File Offset: 0x0021439C
		public void SetOperationToInverse()
		{
			vtkMatrixMathFilter.vtkMatrixMathFilter_SetOperationToInverse_13(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A7F RID: 6783
		public new const string MRFullTypeName = "Kitware.VTK.vtkMatrixMathFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A80 RID: 6784
		public new static readonly string MRClassNameKey = "class vtkMatrixMathFilter";
	}
}
