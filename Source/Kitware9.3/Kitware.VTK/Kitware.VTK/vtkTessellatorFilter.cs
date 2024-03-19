using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTessellatorFilter
	/// </summary>
	/// <remarks>
	///    approximate nonlinear FEM elements with simplices
	///
	/// This class approximates nonlinear FEM elements with linear simplices.
	///
	/// &lt;b&gt;Warning&lt;/b&gt;: This class is temporary and will go away at some point
	/// after ParaView 1.4.0.
	///
	/// This filter rifles through all the cells in an input vtkDataSet. It
	/// tesselates each cell and uses the vtkStreamingTessellator and
	/// vtkDataSetEdgeSubdivisionCriterion classes to generate simplices that
	/// approximate the nonlinear mesh using some approximation metric (encoded
	/// in the particular vtkDataSetEdgeSubdivisionCriterion::EvaluateLocationAndFields
	/// implementation). The simplices are placed into the filter's output
	/// vtkDataSet object by the callback routines AddATetrahedron,
	/// AddATriangle, and AddALine, which are registered with the triangulator.
	///
	/// The output mesh will have geometry and any fields specified as
	/// attributes in the input mesh's point data.  The attribute's copy flags
	/// are honored, except for normals.
	///
	///
	/// @par Internals:
	/// The filter's main member function is RequestData(). This function first
	/// calls SetupOutput() which allocates arrays and some temporary variables
	/// for the primitive callbacks (OutputTriangle and OutputLine which are
	/// called by AddATriangle and AddALine, respectively).  Each cell is given
	/// an initial tessellation, which results in one or more calls to
	/// OutputTetrahedron, OutputTriangle or OutputLine to add elements to the
	/// OutputMesh. Finally, Teardown() is called to free the filter's working
	/// space.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDataSetToUnstructuredGridFilter vtkDataSet vtkStreamingTessellator
	/// vtkDataSetEdgeSubdivisionCriterion
	/// </seealso>
	// Token: 0x020008F1 RID: 2289
	public class vtkTessellatorFilter : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017A5F RID: 96863 RVA: 0x00212843 File Offset: 0x00210A43
		static vtkTessellatorFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTessellatorFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTessellatorFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017A60 RID: 96864 RVA: 0x0021286B File Offset: 0x00210A6B
		public vtkTessellatorFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017A61 RID: 96865
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTessellatorFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017A62 RID: 96866 RVA: 0x0021287C File Offset: 0x00210A7C
		public new static vtkTessellatorFilter New()
		{
			vtkTessellatorFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTessellatorFilter.vtkTessellatorFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTessellatorFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017A63 RID: 96867 RVA: 0x002128D0 File Offset: 0x00210AD0
		public vtkTessellatorFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTessellatorFilter.vtkTessellatorFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017A64 RID: 96868 RVA: 0x00212914 File Offset: 0x00210B14
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017A65 RID: 96869
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTessellatorFilter_GetChordError_01(HandleRef pThis);

		/// <summary>
		/// These are convenience routines for setting properties maintained by the
		/// tessellator and subdivider. They are implemented here for ParaView's
		/// sake.
		/// </summary>
		// Token: 0x06017A66 RID: 96870 RVA: 0x00212920 File Offset: 0x00210B20
		public double GetChordError()
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_GetChordError_01(base.GetCppThis());
		}

		// Token: 0x06017A67 RID: 96871
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTessellatorFilter_GetMTime_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017A68 RID: 96872 RVA: 0x00212940 File Offset: 0x00210B40
		public override ulong GetMTime()
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x06017A69 RID: 96873
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTessellatorFilter_GetMaximumNumberOfSubdivisions_03(HandleRef pThis);

		/// <summary>
		/// These are convenience routines for setting properties maintained by the
		/// tessellator and subdivider. They are implemented here for ParaView's
		/// sake.
		/// </summary>
		// Token: 0x06017A6A RID: 96874 RVA: 0x00212960 File Offset: 0x00210B60
		public int GetMaximumNumberOfSubdivisions()
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_GetMaximumNumberOfSubdivisions_03(base.GetCppThis());
		}

		// Token: 0x06017A6B RID: 96875
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTessellatorFilter_GetMergePoints_04(HandleRef pThis);

		/// <summary>
		/// The adaptive tessellation will output vertices that are not shared
		/// among cells, even where they should be. This can be corrected to
		/// some extents with a vtkMergeFilter.
		/// By default, the filter is off and vertices will not be shared.
		/// </summary>
		// Token: 0x06017A6C RID: 96876 RVA: 0x00212980 File Offset: 0x00210B80
		public virtual int GetMergePoints()
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_GetMergePoints_04(base.GetCppThis());
		}

		// Token: 0x06017A6D RID: 96877
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTessellatorFilter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017A6E RID: 96878 RVA: 0x002129A0 File Offset: 0x00210BA0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06017A6F RID: 96879
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTessellatorFilter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017A70 RID: 96880 RVA: 0x002129C0 File Offset: 0x00210BC0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06017A71 RID: 96881
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTessellatorFilter_GetOutputDimension_07(HandleRef pThis);

		/// <summary>
		/// Set the dimension of the output tessellation.
		/// Cells in dimensions higher than the given value will have
		/// their boundaries of dimension \a OutputDimension tessellated.
		/// For example, if \a OutputDimension is 2, a hexahedron's
		/// quadrilateral faces would be tessellated rather than its
		/// interior.
		/// </summary>
		// Token: 0x06017A72 RID: 96882 RVA: 0x002129DC File Offset: 0x00210BDC
		public virtual int GetOutputDimension()
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_GetOutputDimension_07(base.GetCppThis());
		}

		// Token: 0x06017A73 RID: 96883
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTessellatorFilter_GetOutputDimensionMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set the dimension of the output tessellation.
		/// Cells in dimensions higher than the given value will have
		/// their boundaries of dimension \a OutputDimension tessellated.
		/// For example, if \a OutputDimension is 2, a hexahedron's
		/// quadrilateral faces would be tessellated rather than its
		/// interior.
		/// </summary>
		// Token: 0x06017A74 RID: 96884 RVA: 0x002129FC File Offset: 0x00210BFC
		public virtual int GetOutputDimensionMaxValue()
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_GetOutputDimensionMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06017A75 RID: 96885
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTessellatorFilter_GetOutputDimensionMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set the dimension of the output tessellation.
		/// Cells in dimensions higher than the given value will have
		/// their boundaries of dimension \a OutputDimension tessellated.
		/// For example, if \a OutputDimension is 2, a hexahedron's
		/// quadrilateral faces would be tessellated rather than its
		/// interior.
		/// </summary>
		// Token: 0x06017A76 RID: 96886 RVA: 0x00212A1C File Offset: 0x00210C1C
		public virtual int GetOutputDimensionMinValue()
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_GetOutputDimensionMinValue_09(base.GetCppThis());
		}

		// Token: 0x06017A77 RID: 96887
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTessellatorFilter_GetSubdivider_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017A78 RID: 96888 RVA: 0x00212A3C File Offset: 0x00210C3C
		public virtual vtkDataSetEdgeSubdivisionCriterion GetSubdivider()
		{
			vtkDataSetEdgeSubdivisionCriterion vtkDataSetEdgeSubdivisionCriterion = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTessellatorFilter.vtkTessellatorFilter_GetSubdivider_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06017A79 RID: 96889
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTessellatorFilter_GetTessellator_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017A7A RID: 96890 RVA: 0x00212AAC File Offset: 0x00210CAC
		public virtual vtkStreamingTessellator GetTessellator()
		{
			vtkStreamingTessellator vtkStreamingTessellator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTessellatorFilter.vtkTessellatorFilter_GetTessellator_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStreamingTessellator = (vtkStreamingTessellator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStreamingTessellator.Register(null);
				}
			}
			return vtkStreamingTessellator;
		}

		// Token: 0x06017A7B RID: 96891
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTessellatorFilter_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017A7C RID: 96892 RVA: 0x00212B1C File Offset: 0x00210D1C
		public override int IsA(string type)
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06017A7D RID: 96893
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTessellatorFilter_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017A7E RID: 96894 RVA: 0x00212B3C File Offset: 0x00210D3C
		public new static int IsTypeOf(string type)
		{
			return vtkTessellatorFilter.vtkTessellatorFilter_IsTypeOf_13(type);
		}

		// Token: 0x06017A7F RID: 96895
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatorFilter_MergePointsOff_14(HandleRef pThis);

		/// <summary>
		/// The adaptive tessellation will output vertices that are not shared
		/// among cells, even where they should be. This can be corrected to
		/// some extents with a vtkMergeFilter.
		/// By default, the filter is off and vertices will not be shared.
		/// </summary>
		// Token: 0x06017A80 RID: 96896 RVA: 0x00212B56 File Offset: 0x00210D56
		public virtual void MergePointsOff()
		{
			vtkTessellatorFilter.vtkTessellatorFilter_MergePointsOff_14(base.GetCppThis());
		}

		// Token: 0x06017A81 RID: 96897
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatorFilter_MergePointsOn_15(HandleRef pThis);

		/// <summary>
		/// The adaptive tessellation will output vertices that are not shared
		/// among cells, even where they should be. This can be corrected to
		/// some extents with a vtkMergeFilter.
		/// By default, the filter is off and vertices will not be shared.
		/// </summary>
		// Token: 0x06017A82 RID: 96898 RVA: 0x00212B65 File Offset: 0x00210D65
		public virtual void MergePointsOn()
		{
			vtkTessellatorFilter.vtkTessellatorFilter_MergePointsOn_15(base.GetCppThis());
		}

		// Token: 0x06017A83 RID: 96899
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTessellatorFilter_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017A84 RID: 96900 RVA: 0x00212B74 File Offset: 0x00210D74
		public new vtkTessellatorFilter NewInstance()
		{
			vtkTessellatorFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTessellatorFilter.vtkTessellatorFilter_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTessellatorFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017A85 RID: 96901
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatorFilter_ResetFieldCriteria_18(HandleRef pThis);

		/// <summary>
		/// These methods are for the ParaView client.
		/// </summary>
		// Token: 0x06017A86 RID: 96902 RVA: 0x00212BCE File Offset: 0x00210DCE
		public virtual void ResetFieldCriteria()
		{
			vtkTessellatorFilter.vtkTessellatorFilter_ResetFieldCriteria_18(base.GetCppThis());
		}

		// Token: 0x06017A87 RID: 96903
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTessellatorFilter_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017A88 RID: 96904 RVA: 0x00212BE0 File Offset: 0x00210DE0
		public new static vtkTessellatorFilter SafeDownCast(vtkObjectBase o)
		{
			vtkTessellatorFilter vtkTessellatorFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTessellatorFilter.vtkTessellatorFilter_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTessellatorFilter = (vtkTessellatorFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTessellatorFilter.Register(null);
				}
			}
			return vtkTessellatorFilter;
		}

		// Token: 0x06017A89 RID: 96905
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatorFilter_SetChordError_20(HandleRef pThis, double ce);

		/// <summary>
		/// These are convenience routines for setting properties maintained by the
		/// tessellator and subdivider. They are implemented here for ParaView's
		/// sake.
		/// </summary>
		// Token: 0x06017A8A RID: 96906 RVA: 0x00212C5F File Offset: 0x00210E5F
		public virtual void SetChordError(double ce)
		{
			vtkTessellatorFilter.vtkTessellatorFilter_SetChordError_20(base.GetCppThis(), ce);
		}

		// Token: 0x06017A8B RID: 96907
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatorFilter_SetFieldCriterion_21(HandleRef pThis, int field, double err);

		/// <summary>
		/// These methods are for the ParaView client.
		/// </summary>
		// Token: 0x06017A8C RID: 96908 RVA: 0x00212C6F File Offset: 0x00210E6F
		public virtual void SetFieldCriterion(int field, double err)
		{
			vtkTessellatorFilter.vtkTessellatorFilter_SetFieldCriterion_21(base.GetCppThis(), field, err);
		}

		// Token: 0x06017A8D RID: 96909
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatorFilter_SetMaximumNumberOfSubdivisions_22(HandleRef pThis, int num_subdiv_in);

		/// <summary>
		/// These are convenience routines for setting properties maintained by the
		/// tessellator and subdivider. They are implemented here for ParaView's
		/// sake.
		/// </summary>
		// Token: 0x06017A8E RID: 96910 RVA: 0x00212C80 File Offset: 0x00210E80
		public virtual void SetMaximumNumberOfSubdivisions(int num_subdiv_in)
		{
			vtkTessellatorFilter.vtkTessellatorFilter_SetMaximumNumberOfSubdivisions_22(base.GetCppThis(), num_subdiv_in);
		}

		// Token: 0x06017A8F RID: 96911
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatorFilter_SetMergePoints_23(HandleRef pThis, int _arg);

		/// <summary>
		/// The adaptive tessellation will output vertices that are not shared
		/// among cells, even where they should be. This can be corrected to
		/// some extents with a vtkMergeFilter.
		/// By default, the filter is off and vertices will not be shared.
		/// </summary>
		// Token: 0x06017A90 RID: 96912 RVA: 0x00212C90 File Offset: 0x00210E90
		public virtual void SetMergePoints(int _arg)
		{
			vtkTessellatorFilter.vtkTessellatorFilter_SetMergePoints_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06017A91 RID: 96913
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatorFilter_SetOutputDimension_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the dimension of the output tessellation.
		/// Cells in dimensions higher than the given value will have
		/// their boundaries of dimension \a OutputDimension tessellated.
		/// For example, if \a OutputDimension is 2, a hexahedron's
		/// quadrilateral faces would be tessellated rather than its
		/// interior.
		/// </summary>
		// Token: 0x06017A92 RID: 96914 RVA: 0x00212CA0 File Offset: 0x00210EA0
		public virtual void SetOutputDimension(int _arg)
		{
			vtkTessellatorFilter.vtkTessellatorFilter_SetOutputDimension_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06017A93 RID: 96915
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatorFilter_SetSubdivider_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017A94 RID: 96916 RVA: 0x00212CB0 File Offset: 0x00210EB0
		public virtual void SetSubdivider(vtkDataSetEdgeSubdivisionCriterion arg0)
		{
			vtkTessellatorFilter.vtkTessellatorFilter_SetSubdivider_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06017A95 RID: 96917
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTessellatorFilter_SetTessellator_26(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017A96 RID: 96918 RVA: 0x00212CE0 File Offset: 0x00210EE0
		public virtual void SetTessellator(vtkStreamingTessellator arg0)
		{
			vtkTessellatorFilter.vtkTessellatorFilter_SetTessellator_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A61 RID: 6753
		public new const string MRFullTypeName = "Kitware.VTK.vtkTessellatorFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A62 RID: 6754
		public new static readonly string MRClassNameKey = "class vtkTessellatorFilter";
	}
}
