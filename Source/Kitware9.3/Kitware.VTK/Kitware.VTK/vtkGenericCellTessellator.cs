using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericCellTessellator
	/// </summary>
	/// <remarks>
	///    helper class to perform cell tessellation
	///
	/// vtkGenericCellTessellator is a helper class to perform adaptive tessellation
	/// of particular cell topologies. The major purpose for this class is to
	/// transform higher-order cell types (e.g., higher-order finite elements)
	/// into linear cells that can then be easily visualized by VTK. This class
	/// works in conjunction with the vtkGenericDataSet and vtkGenericAdaptorCell
	/// classes.
	///
	/// This algorithm is based on edge subdivision. An error metric along each
	/// edge is evaluated, and if the error is greater than some tolerance, the
	/// edge is subdivided (as well as all connected 2D and 3D cells). The process
	/// repeats until the error metric is satisfied.
	///
	/// A significant issue addressed by this algorithm is to ensure face
	/// compatibility across neighboring cells. That is, diagonals due to face
	/// triangulation must match to ensure that the mesh is compatible. The
	/// algorithm employs a precomputed table to accelerate the tessellation
	/// process. The table was generated with the help of vtkOrderedTriangulator;
	/// the basic idea is that the choice of diagonal is made by considering the
	/// relative value of the point ids.
	/// </remarks>
	// Token: 0x02000A4E RID: 2638
	public abstract class vtkGenericCellTessellator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B8CB RID: 112843 RVA: 0x00268BF7 File Offset: 0x00266DF7
		static vtkGenericCellTessellator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericCellTessellator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericCellTessellator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B8CC RID: 112844 RVA: 0x00268C1F File Offset: 0x00266E1F
		public vtkGenericCellTessellator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B8CD RID: 112845 RVA: 0x00268C2D File Offset: 0x00266E2D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B8CE RID: 112846
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCellTessellator_GetErrorMetrics_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the list of error metrics used to decide if an edge has to be
		/// split or not. It is a collection of vtkGenericSubdivisionErrorMetric-s.
		/// </summary>
		// Token: 0x0601B8CF RID: 112847 RVA: 0x00268C38 File Offset: 0x00266E38
		public virtual vtkCollection GetErrorMetrics()
		{
			vtkCollection vtkCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCellTessellator.vtkGenericCellTessellator_GetErrorMetrics_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollection = (vtkCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollection.Register(null);
				}
			}
			return vtkCollection;
		}

		// Token: 0x0601B8D0 RID: 112848
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCellTessellator_GetMaxErrors_02(HandleRef pThis, IntPtr errors);

		/// <summary>
		/// Get the maximum error measured after the fixed subdivision.
		/// \pre errors_exists: errors!=0
		/// \pre valid_size: sizeof(errors)==GetErrorMetrics()-&gt;GetNumberOfItems()
		/// </summary>
		// Token: 0x0601B8D1 RID: 112849 RVA: 0x00268CA7 File Offset: 0x00266EA7
		public void GetMaxErrors(IntPtr errors)
		{
			vtkGenericCellTessellator.vtkGenericCellTessellator_GetMaxErrors_02(base.GetCppThis(), errors);
		}

		// Token: 0x0601B8D2 RID: 112850
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCellTessellator_GetMeasurement_03(HandleRef pThis);

		/// <summary>
		/// If true, measure the quality of the fixed subdivision.
		/// </summary>
		// Token: 0x0601B8D3 RID: 112851 RVA: 0x00268CB8 File Offset: 0x00266EB8
		public virtual int GetMeasurement()
		{
			return vtkGenericCellTessellator.vtkGenericCellTessellator_GetMeasurement_03(base.GetCppThis());
		}

		// Token: 0x0601B8D4 RID: 112852
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericCellTessellator_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B8D5 RID: 112853 RVA: 0x00268CD8 File Offset: 0x00266ED8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericCellTessellator.vtkGenericCellTessellator_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601B8D6 RID: 112854
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericCellTessellator_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B8D7 RID: 112855 RVA: 0x00268CF8 File Offset: 0x00266EF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericCellTessellator.vtkGenericCellTessellator_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601B8D8 RID: 112856
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCellTessellator_InitErrorMetrics_06(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Init the error metric with the dataset. Should be called in each filter
		/// before any tessellation of any cell.
		/// </summary>
		// Token: 0x0601B8D9 RID: 112857 RVA: 0x00268D14 File Offset: 0x00266F14
		public void InitErrorMetrics(vtkGenericDataSet ds)
		{
			vtkGenericCellTessellator.vtkGenericCellTessellator_InitErrorMetrics_06(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x0601B8DA RID: 112858
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCellTessellator_Initialize_07(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Initialize the tessellator with a data set `ds'.
		/// </summary>
		// Token: 0x0601B8DB RID: 112859 RVA: 0x00268D44 File Offset: 0x00266F44
		public virtual void Initialize(vtkGenericDataSet ds)
		{
			vtkGenericCellTessellator.vtkGenericCellTessellator_Initialize_07(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x0601B8DC RID: 112860
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCellTessellator_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B8DD RID: 112861 RVA: 0x00268D74 File Offset: 0x00266F74
		public override int IsA(string type)
		{
			return vtkGenericCellTessellator.vtkGenericCellTessellator_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601B8DE RID: 112862
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCellTessellator_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B8DF RID: 112863 RVA: 0x00268D94 File Offset: 0x00266F94
		public new static int IsTypeOf(string type)
		{
			return vtkGenericCellTessellator.vtkGenericCellTessellator_IsTypeOf_09(type);
		}

		// Token: 0x0601B8E0 RID: 112864
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCellTessellator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B8E1 RID: 112865 RVA: 0x00268DB0 File Offset: 0x00266FB0
		public new vtkGenericCellTessellator NewInstance()
		{
			vtkGenericCellTessellator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCellTessellator.vtkGenericCellTessellator_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericCellTessellator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B8E2 RID: 112866
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCellTessellator_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B8E3 RID: 112867 RVA: 0x00268E0C File Offset: 0x0026700C
		public new static vtkGenericCellTessellator SafeDownCast(vtkObjectBase o)
		{
			vtkGenericCellTessellator vtkGenericCellTessellator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCellTessellator.vtkGenericCellTessellator_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericCellTessellator = (vtkGenericCellTessellator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericCellTessellator.Register(null);
				}
			}
			return vtkGenericCellTessellator;
		}

		// Token: 0x0601B8E4 RID: 112868
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCellTessellator_SetErrorMetrics_12(HandleRef pThis, HandleRef someErrorMetrics);

		/// <summary>
		/// Specify the list of error metrics used to decide if an edge has to be
		/// split or not. It is a collection of vtkGenericSubdivisionErrorMetric-s.
		/// </summary>
		// Token: 0x0601B8E5 RID: 112869 RVA: 0x00268E8C File Offset: 0x0026708C
		public virtual void SetErrorMetrics(vtkCollection someErrorMetrics)
		{
			vtkGenericCellTessellator.vtkGenericCellTessellator_SetErrorMetrics_12(base.GetCppThis(), (someErrorMetrics == null) ? default(HandleRef) : someErrorMetrics.GetCppThis());
		}

		// Token: 0x0601B8E6 RID: 112870
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCellTessellator_SetMeasurement_13(HandleRef pThis, int _arg);

		/// <summary>
		/// If true, measure the quality of the fixed subdivision.
		/// </summary>
		// Token: 0x0601B8E7 RID: 112871 RVA: 0x00268EBB File Offset: 0x002670BB
		public virtual void SetMeasurement(int _arg)
		{
			vtkGenericCellTessellator.vtkGenericCellTessellator_SetMeasurement_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B8E8 RID: 112872
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCellTessellator_Tessellate_14(HandleRef pThis, HandleRef cell, HandleRef att, HandleRef points, HandleRef cellArray, HandleRef internalPd);

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
		// Token: 0x0601B8E9 RID: 112873 RVA: 0x00268ECC File Offset: 0x002670CC
		public virtual void Tessellate(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
		{
			vtkGenericCellTessellator.vtkGenericCellTessellator_Tessellate_14(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (att == null) ? default(HandleRef) : att.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis());
		}

		// Token: 0x0601B8EA RID: 112874
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCellTessellator_TessellateFace_15(HandleRef pThis, HandleRef cell, HandleRef att, long index, HandleRef points, HandleRef cellArray, HandleRef internalPd);

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
		// Token: 0x0601B8EB RID: 112875 RVA: 0x00268F54 File Offset: 0x00267154
		public virtual void TessellateFace(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, long index, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
		{
			vtkGenericCellTessellator.vtkGenericCellTessellator_TessellateFace_15(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (att == null) ? default(HandleRef) : att.GetCppThis(), index, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis());
		}

		// Token: 0x0601B8EC RID: 112876
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCellTessellator_Triangulate_16(HandleRef pThis, HandleRef cell, HandleRef att, HandleRef points, HandleRef cellArray, HandleRef internalPd);

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
		// Token: 0x0601B8ED RID: 112877 RVA: 0x00268FE0 File Offset: 0x002671E0
		public virtual void Triangulate(vtkGenericAdaptorCell cell, vtkGenericAttributeCollection att, vtkDoubleArray points, vtkCellArray cellArray, vtkPointData internalPd)
		{
			vtkGenericCellTessellator.vtkGenericCellTessellator_Triangulate_16(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (att == null) ? default(HandleRef) : att.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D90 RID: 7568
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericCellTessellator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D91 RID: 7569
		public new static readonly string MRClassNameKey = "class vtkGenericCellTessellator";
	}
}
