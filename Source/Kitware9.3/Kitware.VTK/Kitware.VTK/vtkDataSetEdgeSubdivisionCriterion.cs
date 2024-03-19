using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataSetEdgeSubdivisionCriterion
	/// </summary>
	/// <remarks>
	///    a subclass of vtkEdgeSubdivisionCriterion for vtkDataSet objects.
	///
	///
	/// This is a subclass of vtkEdgeSubdivisionCriterion that is used for
	/// tessellating cells of a vtkDataSet, particularly nonlinear
	/// cells.
	///
	/// It provides functions for setting the current cell being tessellated and a
	/// convenience routine, \a EvaluateFields() to evaluate field values at a
	/// point. You should call \a EvaluateFields() from inside \a EvaluateLocationAndFields()
	/// whenever the result of \a EvaluateLocationAndFields() will be true. Otherwise, do
	/// not call \a EvaluateFields() as the midpoint is about to be discarded.
	/// (&lt;i&gt;Implementor's note&lt;/i&gt;: This isn't true if UGLY_ASPECT_RATIO_HACK
	/// has been defined. But in that case, we don't want the exact field values;
	/// we need the linearly interpolated ones at the midpoint for continuity.)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkEdgeSubdivisionCriterion
	/// </seealso>
	// Token: 0x02000958 RID: 2392
	public class vtkDataSetEdgeSubdivisionCriterion : vtkEdgeSubdivisionCriterion
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018D6C RID: 101740 RVA: 0x0022AAD3 File Offset: 0x00228CD3
		static vtkDataSetEdgeSubdivisionCriterion()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetEdgeSubdivisionCriterion.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetEdgeSubdivisionCriterion"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018D6D RID: 101741 RVA: 0x0022AAFB File Offset: 0x00228CFB
		public vtkDataSetEdgeSubdivisionCriterion(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018D6E RID: 101742
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D6F RID: 101743 RVA: 0x0022AB0C File Offset: 0x00228D0C
		public new static vtkDataSetEdgeSubdivisionCriterion New()
		{
			vtkDataSetEdgeSubdivisionCriterion result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetEdgeSubdivisionCriterion)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D70 RID: 101744 RVA: 0x0022AB60 File Offset: 0x00228D60
		public vtkDataSetEdgeSubdivisionCriterion() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018D71 RID: 101745 RVA: 0x0022ABA4 File Offset: 0x00228DA4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018D72 RID: 101746
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetEdgeSubdivisionCriterion_EvaluateCellDataField_01(HandleRef pThis, IntPtr result, IntPtr weights, int field);

		/// <summary>
		/// Evaluate either a cell or nodal field.
		/// This exists because of the funky way that Exodus data will be handled.
		/// Sure, it's a hack, but what are ya gonna do?
		/// </summary>
		// Token: 0x06018D73 RID: 101747 RVA: 0x0022ABAF File Offset: 0x00228DAF
		public void EvaluateCellDataField(IntPtr result, IntPtr weights, int field)
		{
			vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_EvaluateCellDataField_01(base.GetCppThis(), result, weights, field);
		}

		// Token: 0x06018D74 RID: 101748
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_EvaluateFields_02(HandleRef pThis, IntPtr vertex, IntPtr weights, int field_start);

		/// <summary>
		/// Evaluate all of the fields that should be output with the
		/// given \a vertex and store them just past the parametric coordinates
		/// of \a vertex, at the offsets given by
		/// \p vtkEdgeSubdivisionCriterion::GetFieldOffsets() plus \a field_start.
		/// \a field_start contains the number of world-space coordinates (always 3)
		/// plus the embedding dimension (the size of the parameter-space in which
		/// the cell is embedded). It will range between 3 and 6, inclusive.
		///
		/// You must have called SetCellId() before calling this routine or there
		/// will not be a mesh over which to evaluate the fields.
		///
		/// You must have called \p vtkEdgeSubdivisionCriterion::PassDefaultFields()
		/// or \p vtkEdgeSubdivisionCriterion::PassField() or there will be no fields
		/// defined for the output vertex.
		///
		/// This routine is public and returns its input argument so that it
		/// may be used as an argument to
		/// \p vtkStreamingTessellator::AdaptivelySamplekFacet():
		/// @verbatim
		/// vtkStreamingTessellator* t = vtkStreamingTessellator::New();
		/// vtkEdgeSubdivisionCriterion* s;
		/// ...
		/// t-&gt;AdaptivelySample1Facet( s-&gt;EvaluateFields( p0 ), s-&gt;EvaluateFields( p1 ) );
		/// ...
		/// @endverbatim
		/// Although this will work, using \p EvaluateFields() in this manner
		/// should be avoided. It's much more efficient to fetch the corner values
		/// for each attribute and copy them into \a p0, \a p1, ... as opposed to
		/// performing shape function evaluations. The only case where you wouldn't
		/// want to do this is when the field you are interpolating is discontinuous
		/// at cell borders, such as with a discontinuous galerkin method or when
		/// all the Gauss points for quadrature are interior to the cell.
		///
		/// The final argument, \a weights, is the array of weights to apply to each
		/// point's data when interpolating the field. This is returned by
		/// \a vtkCell::EvaluateLocation() when evaluating the geometry.
		/// </summary>
		// Token: 0x06018D75 RID: 101749 RVA: 0x0022ABC4 File Offset: 0x00228DC4
		public IntPtr EvaluateFields(IntPtr vertex, IntPtr weights, int field_start)
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_EvaluateFields_02(base.GetCppThis(), vertex, weights, field_start);
		}

		// Token: 0x06018D76 RID: 101750
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataSetEdgeSubdivisionCriterion_EvaluateLocationAndFields_03(HandleRef pThis, IntPtr midpt, int field_start);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D77 RID: 101751 RVA: 0x0022ABE8 File Offset: 0x00228DE8
		public override bool EvaluateLocationAndFields(IntPtr midpt, int field_start)
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_EvaluateLocationAndFields_03(base.GetCppThis(), midpt, field_start) != 0;
		}

		// Token: 0x06018D78 RID: 101752
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetEdgeSubdivisionCriterion_EvaluatePointDataField_04(HandleRef pThis, IntPtr result, IntPtr weights, int field);

		/// <summary>
		/// Evaluate either a cell or nodal field.
		/// This exists because of the funky way that Exodus data will be handled.
		/// Sure, it's a hack, but what are ya gonna do?
		/// </summary>
		// Token: 0x06018D79 RID: 101753 RVA: 0x0022AC10 File Offset: 0x00228E10
		public void EvaluatePointDataField(IntPtr result, IntPtr weights, int field)
		{
			vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_EvaluatePointDataField_04(base.GetCppThis(), result, weights, field);
		}

		// Token: 0x06018D7A RID: 101754
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetEdgeSubdivisionCriterion_GetActiveFieldCriteria_05(HandleRef pThis);

		/// <summary>
		/// Return a bitfield specifying which FieldError2 criteria are positive (i.e., actively
		/// used to decide edge subdivisions).
		/// This is stored as separate state to make subdivisions go faster.
		/// </summary>
		// Token: 0x06018D7B RID: 101755 RVA: 0x0022AC24 File Offset: 0x00228E24
		public virtual int GetActiveFieldCriteria()
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_GetActiveFieldCriteria_05(base.GetCppThis());
		}

		// Token: 0x06018D7C RID: 101756
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_GetCell_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D7D RID: 101757 RVA: 0x0022AC44 File Offset: 0x00228E44
		public vtkCell GetCell()
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_GetCell_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x06018D7E RID: 101758
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetEdgeSubdivisionCriterion_GetCellId_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D7F RID: 101759 RVA: 0x0022ACB4 File Offset: 0x00228EB4
		public long GetCellId()
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_GetCellId_07(base.GetCppThis());
		}

		// Token: 0x06018D80 RID: 101760
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDataSetEdgeSubdivisionCriterion_GetChordError2_08(HandleRef pThis);

		/// <summary>
		/// Get/Set the square of the allowable chord error at any edge's midpoint.
		/// This value is used by EvaluateLocationAndFields.
		/// </summary>
		// Token: 0x06018D81 RID: 101761 RVA: 0x0022ACD4 File Offset: 0x00228ED4
		public virtual double GetChordError2()
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_GetChordError2_08(base.GetCppThis());
		}

		// Token: 0x06018D82 RID: 101762
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDataSetEdgeSubdivisionCriterion_GetFieldError2_09(HandleRef pThis, int s);

		/// <summary>
		/// Get/Set the square of the allowable error magnitude for the
		/// scalar field \a s at any edge's midpoint.
		/// A value less than or equal to 0 indicates that the field
		/// should not be used as a criterion for subdivision.
		/// </summary>
		// Token: 0x06018D83 RID: 101763 RVA: 0x0022ACF4 File Offset: 0x00228EF4
		public double GetFieldError2(int s)
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_GetFieldError2_09(base.GetCppThis(), s);
		}

		// Token: 0x06018D84 RID: 101764
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_GetMesh_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D85 RID: 101765 RVA: 0x0022AD14 File Offset: 0x00228F14
		public vtkDataSet GetMesh()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_GetMesh_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06018D86 RID: 101766
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetEdgeSubdivisionCriterion_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D87 RID: 101767 RVA: 0x0022AD84 File Offset: 0x00228F84
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06018D88 RID: 101768
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetEdgeSubdivisionCriterion_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D89 RID: 101769 RVA: 0x0022ADA4 File Offset: 0x00228FA4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06018D8A RID: 101770
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetEdgeSubdivisionCriterion_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D8B RID: 101771 RVA: 0x0022ADC0 File Offset: 0x00228FC0
		public override int IsA(string type)
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06018D8C RID: 101772
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetEdgeSubdivisionCriterion_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D8D RID: 101773 RVA: 0x0022ADE0 File Offset: 0x00228FE0
		public new static int IsTypeOf(string type)
		{
			return vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_IsTypeOf_14(type);
		}

		// Token: 0x06018D8E RID: 101774
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D8F RID: 101775 RVA: 0x0022ADFC File Offset: 0x00228FFC
		public new vtkDataSetEdgeSubdivisionCriterion NewInstance()
		{
			vtkDataSetEdgeSubdivisionCriterion result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetEdgeSubdivisionCriterion)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018D90 RID: 101776
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetEdgeSubdivisionCriterion_ResetFieldError2_17(HandleRef pThis);

		/// <summary>
		/// Tell the subdivider not to use any field values as subdivision criteria.
		/// Effectively calls SetFieldError2( a, -1. ) for all fields.
		/// </summary>
		// Token: 0x06018D91 RID: 101777 RVA: 0x0022AE56 File Offset: 0x00229056
		public virtual void ResetFieldError2()
		{
			vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_ResetFieldError2_17(base.GetCppThis());
		}

		// Token: 0x06018D92 RID: 101778
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetEdgeSubdivisionCriterion_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D93 RID: 101779 RVA: 0x0022AE68 File Offset: 0x00229068
		public new static vtkDataSetEdgeSubdivisionCriterion SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetEdgeSubdivisionCriterion vtkDataSetEdgeSubdivisionCriterion = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetEdgeSubdivisionCriterion = (vtkDataSetEdgeSubdivisionCriterion)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetEdgeSubdivisionCriterion.Register(null);
				}
			}
			return vtkDataSetEdgeSubdivisionCriterion;
		}

		// Token: 0x06018D94 RID: 101780
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetEdgeSubdivisionCriterion_SetCellId_19(HandleRef pThis, long cell);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D95 RID: 101781 RVA: 0x0022AEE7 File Offset: 0x002290E7
		public virtual void SetCellId(long cell)
		{
			vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_SetCellId_19(base.GetCppThis(), cell);
		}

		// Token: 0x06018D96 RID: 101782
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetEdgeSubdivisionCriterion_SetChordError2_20(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set the square of the allowable chord error at any edge's midpoint.
		/// This value is used by EvaluateLocationAndFields.
		/// </summary>
		// Token: 0x06018D97 RID: 101783 RVA: 0x0022AEF7 File Offset: 0x002290F7
		public virtual void SetChordError2(double _arg)
		{
			vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_SetChordError2_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06018D98 RID: 101784
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetEdgeSubdivisionCriterion_SetFieldError2_21(HandleRef pThis, int s, double err);

		/// <summary>
		/// Get/Set the square of the allowable error magnitude for the
		/// scalar field \a s at any edge's midpoint.
		/// A value less than or equal to 0 indicates that the field
		/// should not be used as a criterion for subdivision.
		/// </summary>
		// Token: 0x06018D99 RID: 101785 RVA: 0x0022AF07 File Offset: 0x00229107
		public virtual void SetFieldError2(int s, double err)
		{
			vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_SetFieldError2_21(base.GetCppThis(), s, err);
		}

		// Token: 0x06018D9A RID: 101786
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetEdgeSubdivisionCriterion_SetMesh_22(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D9B RID: 101787 RVA: 0x0022AF18 File Offset: 0x00229118
		public virtual void SetMesh(vtkDataSet arg0)
		{
			vtkDataSetEdgeSubdivisionCriterion.vtkDataSetEdgeSubdivisionCriterion_SetMesh_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B69 RID: 7017
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetEdgeSubdivisionCriterion";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B6A RID: 7018
		public new static readonly string MRClassNameKey = "class vtkDataSetEdgeSubdivisionCriterion";
	}
}
