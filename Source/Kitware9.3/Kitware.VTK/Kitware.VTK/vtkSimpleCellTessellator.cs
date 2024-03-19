using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSimpleCellTessellator
	/// </summary>
	/// <remarks>
	///    helper class to perform cell tessellation
	///
	/// vtkSimpleCellTessellator is a helper class to perform adaptive tessellation
	/// of particular cell topologies. The major purpose for this class is to
	/// transform higher-order cell types (e.g., higher-order finite elements)
	/// into linear cells that can then be easily visualized by VTK. This class
	/// works in conjunction with the vtkGenericDataSet and vtkGenericAdaptorCell
	/// classes.
	///
	/// This algorithm is based on edge subdivision. An error metric along each
	/// edge is evaluated, and if the error is greater than some tolerance, the
	/// edge is subdivided (as well as all connected 2D and 3D cells). The process
	/// repeats until the error metric is satisfied. Since the algorithm is based
	/// on edge subdivision it inherently avoid T-junctions.
	///
	/// A significant issue addressed by this algorithm is to ensure face
	/// compatibility across neighboring cells. That is, diagonals due to face
	/// triangulation must match to ensure that the mesh is compatible. The
	/// algorithm employs a precomputed table to accelerate the tessellation
	/// process. The table was generated with the help of vtkOrderedTriangulator
	/// the basic idea is that the choice of diagonal is made only by considering the
	/// relative value of the point ids.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGenericCellTessellator vtkGenericSubdivisionErrorMetric vtkAttributesErrorMetric
	/// vtkGeometricErrorMetric vtkViewDependentErrorMetric
	/// </seealso>
	// Token: 0x02000ABF RID: 2751
	public class vtkSimpleCellTessellator : vtkGenericCellTessellator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CF58 RID: 118616 RVA: 0x0028D2F5 File Offset: 0x0028B4F5
		static vtkSimpleCellTessellator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimpleCellTessellator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimpleCellTessellator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CF59 RID: 118617 RVA: 0x0028D31D File Offset: 0x0028B51D
		public vtkSimpleCellTessellator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CF5A RID: 118618
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleCellTessellator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CF5B RID: 118619 RVA: 0x0028D32C File Offset: 0x0028B52C
		public new static vtkSimpleCellTessellator New()
		{
			vtkSimpleCellTessellator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleCellTessellator.vtkSimpleCellTessellator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleCellTessellator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CF5C RID: 118620 RVA: 0x0028D380 File Offset: 0x0028B580
		public vtkSimpleCellTessellator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSimpleCellTessellator.vtkSimpleCellTessellator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CF5D RID: 118621 RVA: 0x0028D3C4 File Offset: 0x0028B5C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CF5E RID: 118622
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleCellTessellator_GetFixedSubdivisions_01(HandleRef pThis);

		/// <summary>
		/// Return the number of fixed subdivisions. It is used to prevent from
		/// infinite loop in degenerated cases. For order 3 or higher, if the
		/// inflection point is exactly on the mid-point, error metric will not
		/// detect that a subdivision is required. 0 means no fixed subdivision:
		/// there will be only adaptive subdivisions.
		///
		/// The algorithm first performs `GetFixedSubdivisions' non adaptive
		/// subdivisions followed by at most `GetMaxAdaptiveSubdivisions' adaptive
		/// subdivisions. Hence, there are at most `GetMaxSubdivisionLevel'
		/// subdivisions.
		/// \post positive_result: result&gt;=0 &amp;&amp; result&lt;=GetMaxSubdivisionLevel()
		/// </summary>
		// Token: 0x0601CF5F RID: 118623 RVA: 0x0028D3D0 File Offset: 0x0028B5D0
		public int GetFixedSubdivisions()
		{
			return vtkSimpleCellTessellator.vtkSimpleCellTessellator_GetFixedSubdivisions_01(base.GetCppThis());
		}

		// Token: 0x0601CF60 RID: 118624
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleCellTessellator_GetGenericCell_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the higher order cell in order to access the evaluation function.
		/// </summary>
		// Token: 0x0601CF61 RID: 118625 RVA: 0x0028D3F0 File Offset: 0x0028B5F0
		public virtual vtkGenericAdaptorCell GetGenericCell()
		{
			vtkGenericAdaptorCell vtkGenericAdaptorCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleCellTessellator.vtkSimpleCellTessellator_GetGenericCell_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericAdaptorCell = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericAdaptorCell.Register(null);
				}
			}
			return vtkGenericAdaptorCell;
		}

		// Token: 0x0601CF62 RID: 118626
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleCellTessellator_GetMaxAdaptiveSubdivisions_03(HandleRef pThis);

		/// <summary>
		/// Return the maximum number of adaptive subdivisions.
		/// \post valid_result: result==GetMaxSubdivisionLevel()-GetFixedSubdivisions()
		/// </summary>
		// Token: 0x0601CF63 RID: 118627 RVA: 0x0028D460 File Offset: 0x0028B660
		public int GetMaxAdaptiveSubdivisions()
		{
			return vtkSimpleCellTessellator.vtkSimpleCellTessellator_GetMaxAdaptiveSubdivisions_03(base.GetCppThis());
		}

		// Token: 0x0601CF64 RID: 118628
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleCellTessellator_GetMaxSubdivisionLevel_04(HandleRef pThis);

		/// <summary>
		/// Return the maximum level of subdivision. It is used to prevent from
		/// infinite loop in degenerated cases. For order 3 or higher, if the
		/// inflection point is exactly on the mid-point, error metric will not
		/// detect that a subdivision is required. 0 means no subdivision,
		/// neither fixed nor adaptive.
		/// \post positive_result: result&gt;=GetFixedSubdivisions()
		/// </summary>
		// Token: 0x0601CF65 RID: 118629 RVA: 0x0028D480 File Offset: 0x0028B680
		public int GetMaxSubdivisionLevel()
		{
			return vtkSimpleCellTessellator.vtkSimpleCellTessellator_GetMaxSubdivisionLevel_04(base.GetCppThis());
		}

		// Token: 0x0601CF66 RID: 118630
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimpleCellTessellator_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CF67 RID: 118631 RVA: 0x0028D4A0 File Offset: 0x0028B6A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSimpleCellTessellator.vtkSimpleCellTessellator_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601CF68 RID: 118632
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimpleCellTessellator_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CF69 RID: 118633 RVA: 0x0028D4C0 File Offset: 0x0028B6C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSimpleCellTessellator.vtkSimpleCellTessellator_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601CF6A RID: 118634
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleCellTessellator_Initialize_07(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Initialize the tessellator with a data set `ds'.
		/// </summary>
		// Token: 0x0601CF6B RID: 118635 RVA: 0x0028D4DC File Offset: 0x0028B6DC
		public override void Initialize(vtkGenericDataSet ds)
		{
			vtkSimpleCellTessellator.vtkSimpleCellTessellator_Initialize_07(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x0601CF6C RID: 118636
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleCellTessellator_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CF6D RID: 118637 RVA: 0x0028D50C File Offset: 0x0028B70C
		public override int IsA(string type)
		{
			return vtkSimpleCellTessellator.vtkSimpleCellTessellator_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601CF6E RID: 118638
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimpleCellTessellator_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CF6F RID: 118639 RVA: 0x0028D52C File Offset: 0x0028B72C
		public new static int IsTypeOf(string type)
		{
			return vtkSimpleCellTessellator.vtkSimpleCellTessellator_IsTypeOf_09(type);
		}

		// Token: 0x0601CF70 RID: 118640
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleCellTessellator_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CF71 RID: 118641 RVA: 0x0028D548 File Offset: 0x0028B748
		public new vtkSimpleCellTessellator NewInstance()
		{
			vtkSimpleCellTessellator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleCellTessellator.vtkSimpleCellTessellator_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleCellTessellator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CF72 RID: 118642
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleCellTessellator_Reset_12(HandleRef pThis);

		/// <summary>
		/// Reset the output for repeated use of this class.
		/// </summary>
		// Token: 0x0601CF73 RID: 118643 RVA: 0x0028D5A2 File Offset: 0x0028B7A2
		public void Reset()
		{
			vtkSimpleCellTessellator.vtkSimpleCellTessellator_Reset_12(base.GetCppThis());
		}

		// Token: 0x0601CF74 RID: 118644
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimpleCellTessellator_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CF75 RID: 118645 RVA: 0x0028D5B4 File Offset: 0x0028B7B4
		public new static vtkSimpleCellTessellator SafeDownCast(vtkObjectBase o)
		{
			vtkSimpleCellTessellator vtkSimpleCellTessellator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimpleCellTessellator.vtkSimpleCellTessellator_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimpleCellTessellator = (vtkSimpleCellTessellator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimpleCellTessellator.Register(null);
				}
			}
			return vtkSimpleCellTessellator;
		}

		// Token: 0x0601CF76 RID: 118646
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleCellTessellator_SetFixedSubdivisions_14(HandleRef pThis, int level);

		/// <summary>
		/// Set the number of fixed subdivisions. See GetFixedSubdivisions() for
		/// more explanations.
		/// \pre positive_level: level&gt;=0 &amp;&amp; level&lt;=GetMaxSubdivisionLevel()
		/// \post is_set: GetFixedSubdivisions()==level
		/// </summary>
		// Token: 0x0601CF77 RID: 118647 RVA: 0x0028D633 File Offset: 0x0028B833
		public void SetFixedSubdivisions(int level)
		{
			vtkSimpleCellTessellator.vtkSimpleCellTessellator_SetFixedSubdivisions_14(base.GetCppThis(), level);
		}

		// Token: 0x0601CF78 RID: 118648
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleCellTessellator_SetMaxSubdivisionLevel_15(HandleRef pThis, int level);

		/// <summary>
		/// Set the maximum level of subdivision. See GetMaxSubdivisionLevel() for
		/// more explanations.
		/// \pre positive_level: level&gt;=GetFixedSubdivisions()
		/// \post is_set: level==GetMaxSubdivisionLevel()
		/// </summary>
		// Token: 0x0601CF79 RID: 118649 RVA: 0x0028D643 File Offset: 0x0028B843
		public void SetMaxSubdivisionLevel(int level)
		{
			vtkSimpleCellTessellator.vtkSimpleCellTessellator_SetMaxSubdivisionLevel_15(base.GetCppThis(), level);
		}

		// Token: 0x0601CF7A RID: 118650
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleCellTessellator_SetSubdivisionLevels_16(HandleRef pThis, int arg0, int maxLevel);

		/// <summary>
		/// Set both the number of fixed subdivisions and the maximum level of
		/// subdivisions. See GetFixedSubdivisions(), GetMaxSubdivisionLevel() and
		/// GetMaxAdaptiveSubdivisions() for more explanations.
		/// \pre positive_fixed: fixed&gt;=0
		/// \pre valid_range: fixed&lt;=maxLevel
		/// \post fixed_is_set: fixed==GetFixedSubdivisions()
		/// \post maxLevel_is_set: maxLevel==GetMaxSubdivisionLevel()
		/// </summary>
		// Token: 0x0601CF7B RID: 118651 RVA: 0x0028D653 File Offset: 0x0028B853
		public void SetSubdivisionLevels(int arg0, int maxLevel)
		{
			vtkSimpleCellTessellator.vtkSimpleCellTessellator_SetSubdivisionLevels_16(base.GetCppThis(), arg0, maxLevel);
		}

		// Token: 0x0601CF7C RID: 118652
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleCellTessellator_Tessellate_17(HandleRef pThis, HandleRef cell, HandleRef att, HandleRef points, HandleRef cellArray, HandleRef internalPd);

		/// <summary>
		/// Tessellate a 3D `cell'. The result is a set of smaller linear
		/// tetrahedra in `cellArray' with `points' and point data `internalPd'.
		/// \pre cell_exists: cell!=0
		/// \pre valid_dimension: cell-&gt;GetDimension()==3
		/// \pre att_exists: att!=0
		/// \pre points_exists: points!=0
		/// \pre cellArray_exists: cellArray!=0
		/// \pre internalPd_exists: internalPd!=0
		/// </summary>
		// Token: 0x0601CF7D RID: 118653 RVA: 0x0028D664 File Offset: 0x0028B864
		public override void Tessellate(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
		{
			vtkSimpleCellTessellator.vtkSimpleCellTessellator_Tessellate_17(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (att == null) ? default(HandleRef) : att.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis());
		}

		// Token: 0x0601CF7E RID: 118654
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleCellTessellator_TessellateFace_18(HandleRef pThis, HandleRef cell, HandleRef att, long index, HandleRef points, HandleRef cellArray, HandleRef internalPd);

		/// <summary>
		/// Tessellate a face of a 3D `cell'. The face is specified by the
		/// index value.
		/// The result is a set of smaller linear triangles in `cellArray' with
		/// `points' and point data `internalPd'.
		/// \pre cell_exists: cell!=0
		/// \pre valid_dimension: cell-&gt;GetDimension()==3
		/// \pre valid_index_range: (index&gt;=0) &amp;&amp; (index&lt;cell-&gt;GetNumberOfBoundaries(2))
		/// \pre att_exists: att!=0
		/// \pre points_exists: points!=0
		/// \pre cellArray_exists: cellArray!=0
		/// \pre internalPd_exists: internalPd!=0
		/// </summary>
		// Token: 0x0601CF7F RID: 118655 RVA: 0x0028D6EC File Offset: 0x0028B8EC
		public override void TessellateFace(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, long index, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
		{
			vtkSimpleCellTessellator.vtkSimpleCellTessellator_TessellateFace_18(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (att == null) ? default(HandleRef) : att.GetCppThis(), index, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis());
		}

		// Token: 0x0601CF80 RID: 118656
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimpleCellTessellator_Triangulate_19(HandleRef pThis, HandleRef cell, HandleRef att, HandleRef points, HandleRef cellArray, HandleRef internalPd);

		/// <summary>
		/// Triangulate a 2D `cell'. The result is a set of smaller linear triangles
		/// in `cellArray' with `points' and point data `internalPd'.
		/// \pre cell_exists: cell!=0
		/// \pre valid_dimension: cell-&gt;GetDimension()==2
		/// \pre att_exists: att!=0
		/// \pre points_exists: points!=0
		/// \pre cellArray_exists: cellArray!=0
		/// \pre internalPd_exists: internalPd!=0
		/// </summary>
		// Token: 0x0601CF81 RID: 118657 RVA: 0x0028D778 File Offset: 0x0028B978
		public override void Triangulate(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
		{
			vtkSimpleCellTessellator.vtkSimpleCellTessellator_Triangulate_19(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (att == null) ? default(HandleRef) : att.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E9A RID: 7834
		public new const string MRFullTypeName = "Kitware.VTK.vtkSimpleCellTessellator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E9B RID: 7835
		public new static readonly string MRClassNameKey = "class vtkSimpleCellTessellator";
	}
}
