using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEdgeSubdivisionCriterion
	/// </summary>
	/// <remarks>
	///    how to decide whether a linear approximation to nonlinear geometry or field should be
	/// subdivided
	///
	///
	/// Descendants of this abstract class are used to decide whether a
	/// piecewise linear approximation (triangles, lines, ... ) to some
	/// nonlinear geometry should be subdivided. This decision may be
	/// based on an absolute error metric (chord error) or on some
	/// view-dependent metric (chord error compared to device resolution)
	/// or on some abstract metric (color error). Or anything else, really.
	/// Just so long as you implement the EvaluateLocationAndFields member, all will
	/// be well.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDataSetSubdivisionAlgorithm vtkStreamingTessellator
	/// </seealso>
	// Token: 0x02000957 RID: 2391
	public abstract class vtkEdgeSubdivisionCriterion : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018D4D RID: 101709 RVA: 0x0022A813 File Offset: 0x00228A13
		static vtkEdgeSubdivisionCriterion()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEdgeSubdivisionCriterion.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEdgeSubdivisionCriterion"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018D4E RID: 101710 RVA: 0x0022A83B File Offset: 0x00228A3B
		public vtkEdgeSubdivisionCriterion(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018D4F RID: 101711 RVA: 0x0022A849 File Offset: 0x00228A49
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018D50 RID: 101712
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkEdgeSubdivisionCriterion_DontPassField_01(HandleRef pThis, int sourceId, HandleRef t);

		/// <summary>
		/// This does the opposite of \p PassField(); it removes a field from
		/// the output (assuming the field was set to be passed).
		/// Returns true if any action was taken, false otherwise.
		/// </summary>
		// Token: 0x06018D51 RID: 101713 RVA: 0x0022A854 File Offset: 0x00228A54
		public virtual bool DontPassField(int sourceId, vtkStreamingTessellator t)
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_DontPassField_01(base.GetCppThis(), sourceId, (t == null) ? default(HandleRef) : t.GetCppThis()) != 0;
		}

		// Token: 0x06018D52 RID: 101714
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkEdgeSubdivisionCriterion_EvaluateLocationAndFields_02(HandleRef pThis, IntPtr p1, int field_start);

		/// <summary>
		/// You must implement this member function in a subclass.
		/// It will be called by \p vtkStreamingTessellator for each
		/// edge in each primitive that vtkStreamingTessellator generates.
		/// </summary>
		// Token: 0x06018D53 RID: 101715 RVA: 0x0022A890 File Offset: 0x00228A90
		public virtual bool EvaluateLocationAndFields(IntPtr p1, int field_start)
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_EvaluateLocationAndFields_02(base.GetCppThis(), p1, field_start) != 0;
		}

		// Token: 0x06018D54 RID: 101716
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeSubdivisionCriterion_GetFieldIds_03(HandleRef pThis);

		/// <summary>
		/// Return the map from output field id to input field ids.
		/// That is, field \a i of any output vertex from vtkStreamingTessellator
		/// will be associated with \p GetFieldIds()[\a i] on the input mesh.
		/// </summary>
		// Token: 0x06018D55 RID: 101717 RVA: 0x0022A8B8 File Offset: 0x00228AB8
		public IntPtr GetFieldIds()
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_GetFieldIds_03(base.GetCppThis());
		}

		// Token: 0x06018D56 RID: 101718
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeSubdivisionCriterion_GetFieldOffsets_04(HandleRef pThis);

		/// <summary>
		/// Return the offset into an output vertex array of all fields.
		/// That is, field \a i of any output vertex, \a p, from vtkStreamingTessellator
		/// will have its first entry at \a p[\p GetFieldOffsets()[\a i] ] .
		/// </summary>
		// Token: 0x06018D57 RID: 101719 RVA: 0x0022A8D8 File Offset: 0x00228AD8
		public IntPtr GetFieldOffsets()
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_GetFieldOffsets_04(base.GetCppThis());
		}

		// Token: 0x06018D58 RID: 101720
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeSubdivisionCriterion_GetNumberOfFields_05(HandleRef pThis);

		/// <summary>
		/// Return the number of fields being evaluated at each output vertex.
		/// This is the length of the arrays returned by \p GetFieldIds() and
		/// \p GetFieldOffsets().
		/// </summary>
		// Token: 0x06018D59 RID: 101721 RVA: 0x0022A8F8 File Offset: 0x00228AF8
		public int GetNumberOfFields()
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_GetNumberOfFields_05(base.GetCppThis());
		}

		// Token: 0x06018D5A RID: 101722
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgeSubdivisionCriterion_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D5B RID: 101723 RVA: 0x0022A918 File Offset: 0x00228B18
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06018D5C RID: 101724
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgeSubdivisionCriterion_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D5D RID: 101725 RVA: 0x0022A938 File Offset: 0x00228B38
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06018D5E RID: 101726
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeSubdivisionCriterion_GetOutputField_08(HandleRef pThis, int fieldId);

		/// <summary>
		/// Return the output ID of an input field.
		/// Returns -1 if \a fieldId is not set to be passed to the output.
		/// </summary>
		// Token: 0x06018D5F RID: 101727 RVA: 0x0022A954 File Offset: 0x00228B54
		public int GetOutputField(int fieldId)
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_GetOutputField_08(base.GetCppThis(), fieldId);
		}

		// Token: 0x06018D60 RID: 101728
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeSubdivisionCriterion_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D61 RID: 101729 RVA: 0x0022A974 File Offset: 0x00228B74
		public override int IsA(string type)
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06018D62 RID: 101730
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeSubdivisionCriterion_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D63 RID: 101731 RVA: 0x0022A994 File Offset: 0x00228B94
		public new static int IsTypeOf(string type)
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_IsTypeOf_10(type);
		}

		// Token: 0x06018D64 RID: 101732
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeSubdivisionCriterion_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D65 RID: 101733 RVA: 0x0022A9B0 File Offset: 0x00228BB0
		public new vtkEdgeSubdivisionCriterion NewInstance()
		{
			vtkEdgeSubdivisionCriterion result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeSubdivisionCriterion)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018D66 RID: 101734
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeSubdivisionCriterion_PassField_12(HandleRef pThis, int sourceId, int sourceSize, HandleRef t);

		/// <summary>
		/// This is a helper routine called by \p PassFields() which
		/// you may also call directly; it adds \a sourceSize to the size of
		/// the output vertex field values. The offset of the \a sourceId
		/// field in the output vertex array is returned.
		/// -1 is returned if \a sourceSize would force the output to have more
		/// than \a vtkStreamingTessellator::MaxFieldSize field values per vertex.
		/// </summary>
		// Token: 0x06018D67 RID: 101735 RVA: 0x0022AA0C File Offset: 0x00228C0C
		public virtual int PassField(int sourceId, int sourceSize, vtkStreamingTessellator t)
		{
			return vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_PassField_12(base.GetCppThis(), sourceId, sourceSize, (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		// Token: 0x06018D68 RID: 101736
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEdgeSubdivisionCriterion_ResetFieldList_13(HandleRef pThis);

		/// <summary>
		/// Don't pass any field values in the vertex pointer.
		/// This is used to reset the list of fields to pass after a
		/// successful run of vtkStreamingTessellator.
		/// </summary>
		// Token: 0x06018D69 RID: 101737 RVA: 0x0022AA42 File Offset: 0x00228C42
		public virtual void ResetFieldList()
		{
			vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_ResetFieldList_13(base.GetCppThis());
		}

		// Token: 0x06018D6A RID: 101738
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeSubdivisionCriterion_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D6B RID: 101739 RVA: 0x0022AA54 File Offset: 0x00228C54
		public new static vtkEdgeSubdivisionCriterion SafeDownCast(vtkObjectBase o)
		{
			vtkEdgeSubdivisionCriterion vtkEdgeSubdivisionCriterion = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeSubdivisionCriterion.vtkEdgeSubdivisionCriterion_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEdgeSubdivisionCriterion = (vtkEdgeSubdivisionCriterion)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEdgeSubdivisionCriterion.Register(null);
				}
			}
			return vtkEdgeSubdivisionCriterion;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B67 RID: 7015
		public new const string MRFullTypeName = "Kitware.VTK.vtkEdgeSubdivisionCriterion";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B68 RID: 7016
		public new static readonly string MRClassNameKey = "class vtkEdgeSubdivisionCriterion";
	}
}
