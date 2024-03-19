using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBooleanOperationPolyDataFilter
	///
	///
	/// Computes the boundary of the union, intersection, or difference
	/// volume computed from the volumes defined by two input surfaces. The
	/// two surfaces do not need to be manifold, but if they are not,
	/// unexpected results may be obtained. The resulting surface is
	/// available in the first output of the filter. The second output
	/// contains a set of polylines that represent the intersection between
	/// the two input surfaces.
	///
	/// @warning This filter is not designed to perform 2D boolean operations,
	/// and in fact relies on the inputs having no co-planar, overlapping cells.
	///
	/// This code was contributed in the VTK Journal paper:
	/// "Boolean Operations on Surfaces in VTK Without External Libraries"
	/// by Cory Quammen, Chris Weigle C., Russ Taylor
	/// http://hdl.handle.net/10380/3262
	/// http://www.midasjournal.org/browse/publication/797
	/// </summary>
	// Token: 0x02000877 RID: 2167
	public class vtkBooleanOperationPolyDataFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060167B4 RID: 92084 RVA: 0x001F9D97 File Offset: 0x001F7F97
		static vtkBooleanOperationPolyDataFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBooleanOperationPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBooleanOperationPolyDataFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060167B5 RID: 92085 RVA: 0x001F9DBF File Offset: 0x001F7FBF
		public vtkBooleanOperationPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060167B6 RID: 92086
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBooleanOperationPolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object that computes the boolean surface.
		/// </summary>
		// Token: 0x060167B7 RID: 92087 RVA: 0x001F9DD0 File Offset: 0x001F7FD0
		public new static vtkBooleanOperationPolyDataFilter New()
		{
			vtkBooleanOperationPolyDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBooleanOperationPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object that computes the boolean surface.
		/// </summary>
		// Token: 0x060167B8 RID: 92088 RVA: 0x001F9E24 File Offset: 0x001F8024
		public vtkBooleanOperationPolyDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060167B9 RID: 92089 RVA: 0x001F9E68 File Offset: 0x001F8068
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060167BA RID: 92090
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBooleanOperationPolyDataFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object that computes the boolean surface.
		/// </summary>
		// Token: 0x060167BB RID: 92091 RVA: 0x001F9E74 File Offset: 0x001F8074
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060167BC RID: 92092
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBooleanOperationPolyDataFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object that computes the boolean surface.
		/// </summary>
		// Token: 0x060167BD RID: 92093 RVA: 0x001F9E94 File Offset: 0x001F8094
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060167BE RID: 92094
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBooleanOperationPolyDataFilter_GetOperation_03(HandleRef pThis);

		/// <summary>
		/// Set the boolean operation to perform. Defaults to union.
		/// </summary>
		// Token: 0x060167BF RID: 92095 RVA: 0x001F9EB0 File Offset: 0x001F80B0
		public virtual int GetOperation()
		{
			return vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_GetOperation_03(base.GetCppThis());
		}

		// Token: 0x060167C0 RID: 92096
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBooleanOperationPolyDataFilter_GetOperationMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Set the boolean operation to perform. Defaults to union.
		/// </summary>
		// Token: 0x060167C1 RID: 92097 RVA: 0x001F9ED0 File Offset: 0x001F80D0
		public virtual int GetOperationMaxValue()
		{
			return vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_GetOperationMaxValue_04(base.GetCppThis());
		}

		// Token: 0x060167C2 RID: 92098
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBooleanOperationPolyDataFilter_GetOperationMinValue_05(HandleRef pThis);

		/// <summary>
		/// Set the boolean operation to perform. Defaults to union.
		/// </summary>
		// Token: 0x060167C3 RID: 92099 RVA: 0x001F9EF0 File Offset: 0x001F80F0
		public virtual int GetOperationMinValue()
		{
			return vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_GetOperationMinValue_05(base.GetCppThis());
		}

		// Token: 0x060167C4 RID: 92100
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBooleanOperationPolyDataFilter_GetReorientDifferenceCells_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off cell reorientation of the intersection portion of the
		/// surface when the operation is set to DIFFERENCE. Defaults to on.
		/// </summary>
		// Token: 0x060167C5 RID: 92101 RVA: 0x001F9F10 File Offset: 0x001F8110
		public virtual int GetReorientDifferenceCells()
		{
			return vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_GetReorientDifferenceCells_06(base.GetCppThis());
		}

		// Token: 0x060167C6 RID: 92102
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBooleanOperationPolyDataFilter_GetTolerance_07(HandleRef pThis);

		/// <summary>
		/// Set/get the tolerance used to determine when a point's absolute
		/// distance is considered to be zero. Defaults to 1e-6.
		/// </summary>
		// Token: 0x060167C7 RID: 92103 RVA: 0x001F9F30 File Offset: 0x001F8130
		public virtual double GetTolerance()
		{
			return vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_GetTolerance_07(base.GetCppThis());
		}

		// Token: 0x060167C8 RID: 92104
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBooleanOperationPolyDataFilter_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object that computes the boolean surface.
		/// </summary>
		// Token: 0x060167C9 RID: 92105 RVA: 0x001F9F50 File Offset: 0x001F8150
		public override int IsA(string type)
		{
			return vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x060167CA RID: 92106
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBooleanOperationPolyDataFilter_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object that computes the boolean surface.
		/// </summary>
		// Token: 0x060167CB RID: 92107 RVA: 0x001F9F70 File Offset: 0x001F8170
		public new static int IsTypeOf(string type)
		{
			return vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_IsTypeOf_09(type);
		}

		// Token: 0x060167CC RID: 92108
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBooleanOperationPolyDataFilter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object that computes the boolean surface.
		/// </summary>
		// Token: 0x060167CD RID: 92109 RVA: 0x001F9F8C File Offset: 0x001F818C
		public new vtkBooleanOperationPolyDataFilter NewInstance()
		{
			vtkBooleanOperationPolyDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBooleanOperationPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060167CE RID: 92110
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanOperationPolyDataFilter_ReorientDifferenceCellsOff_12(HandleRef pThis);

		/// <summary>
		/// Turn on/off cell reorientation of the intersection portion of the
		/// surface when the operation is set to DIFFERENCE. Defaults to on.
		/// </summary>
		// Token: 0x060167CF RID: 92111 RVA: 0x001F9FE6 File Offset: 0x001F81E6
		public virtual void ReorientDifferenceCellsOff()
		{
			vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_ReorientDifferenceCellsOff_12(base.GetCppThis());
		}

		// Token: 0x060167D0 RID: 92112
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanOperationPolyDataFilter_ReorientDifferenceCellsOn_13(HandleRef pThis);

		/// <summary>
		/// Turn on/off cell reorientation of the intersection portion of the
		/// surface when the operation is set to DIFFERENCE. Defaults to on.
		/// </summary>
		// Token: 0x060167D1 RID: 92113 RVA: 0x001F9FF5 File Offset: 0x001F81F5
		public virtual void ReorientDifferenceCellsOn()
		{
			vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_ReorientDifferenceCellsOn_13(base.GetCppThis());
		}

		// Token: 0x060167D2 RID: 92114
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBooleanOperationPolyDataFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object that computes the boolean surface.
		/// </summary>
		// Token: 0x060167D3 RID: 92115 RVA: 0x001FA004 File Offset: 0x001F8204
		public new static vtkBooleanOperationPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkBooleanOperationPolyDataFilter vtkBooleanOperationPolyDataFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBooleanOperationPolyDataFilter = (vtkBooleanOperationPolyDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBooleanOperationPolyDataFilter.Register(null);
				}
			}
			return vtkBooleanOperationPolyDataFilter;
		}

		// Token: 0x060167D4 RID: 92116
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanOperationPolyDataFilter_SetOperation_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the boolean operation to perform. Defaults to union.
		/// </summary>
		// Token: 0x060167D5 RID: 92117 RVA: 0x001FA083 File Offset: 0x001F8283
		public virtual void SetOperation(int _arg)
		{
			vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_SetOperation_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060167D6 RID: 92118
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanOperationPolyDataFilter_SetOperationToDifference_16(HandleRef pThis);

		/// <summary>
		/// Set the boolean operation to perform. Defaults to union.
		/// </summary>
		// Token: 0x060167D7 RID: 92119 RVA: 0x001FA093 File Offset: 0x001F8293
		public void SetOperationToDifference()
		{
			vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_SetOperationToDifference_16(base.GetCppThis());
		}

		// Token: 0x060167D8 RID: 92120
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanOperationPolyDataFilter_SetOperationToIntersection_17(HandleRef pThis);

		/// <summary>
		/// Set the boolean operation to perform. Defaults to union.
		/// </summary>
		// Token: 0x060167D9 RID: 92121 RVA: 0x001FA0A2 File Offset: 0x001F82A2
		public void SetOperationToIntersection()
		{
			vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_SetOperationToIntersection_17(base.GetCppThis());
		}

		// Token: 0x060167DA RID: 92122
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanOperationPolyDataFilter_SetOperationToUnion_18(HandleRef pThis);

		/// <summary>
		/// Set the boolean operation to perform. Defaults to union.
		/// </summary>
		// Token: 0x060167DB RID: 92123 RVA: 0x001FA0B1 File Offset: 0x001F82B1
		public void SetOperationToUnion()
		{
			vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_SetOperationToUnion_18(base.GetCppThis());
		}

		// Token: 0x060167DC RID: 92124
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanOperationPolyDataFilter_SetReorientDifferenceCells_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off cell reorientation of the intersection portion of the
		/// surface when the operation is set to DIFFERENCE. Defaults to on.
		/// </summary>
		// Token: 0x060167DD RID: 92125 RVA: 0x001FA0C0 File Offset: 0x001F82C0
		public virtual void SetReorientDifferenceCells(int _arg)
		{
			vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_SetReorientDifferenceCells_19(base.GetCppThis(), _arg);
		}

		// Token: 0x060167DE RID: 92126
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBooleanOperationPolyDataFilter_SetTolerance_20(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the tolerance used to determine when a point's absolute
		/// distance is considered to be zero. Defaults to 1e-6.
		/// </summary>
		// Token: 0x060167DF RID: 92127 RVA: 0x001FA0D0 File Offset: 0x001F82D0
		public virtual void SetTolerance(double _arg)
		{
			vtkBooleanOperationPolyDataFilter.vtkBooleanOperationPolyDataFilter_SetTolerance_20(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001944 RID: 6468
		public new const string MRFullTypeName = "Kitware.VTK.vtkBooleanOperationPolyDataFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001945 RID: 6469
		public new static readonly string MRClassNameKey = "class vtkBooleanOperationPolyDataFilter";

		/// <summary>
		/// Construct object that computes the boolean surface.
		/// </summary>
		// Token: 0x02000878 RID: 2168
		public enum OperationType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001947 RID: 6471
			VTK_DIFFERENCE = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001948 RID: 6472
			VTK_INTERSECTION = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001949 RID: 6473
			VTK_UNION = 0
		}
	}
}
