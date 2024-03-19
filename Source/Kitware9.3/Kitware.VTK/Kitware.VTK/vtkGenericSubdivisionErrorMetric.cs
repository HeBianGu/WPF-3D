using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericSubdivisionErrorMetric
	/// </summary>
	/// <remarks>
	///    Objects that compute
	/// error during cell tessellation.
	///
	///
	/// Objects of that class answer the following question during the cell
	/// subdivision: "does the edge need to be subdivided?" through
	/// RequiresEdgeSubdivision().
	/// The answer depends on the criterium actually used in the subclass of this
	/// abstract class: a geometric-based error
	/// metric (variation of edge from a straight line), an attribute-based error
	/// metric (variation of the active attribute/component value from a linear
	/// ramp) , a view-depend error metric, ...
	/// Cell subdivision is performed in the context of the adaptor
	/// framework: higher-order, or complex cells, are automatically tessellated
	/// into simplices so that they can be processed with conventional
	/// visualization algorithms.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGenericCellTessellator
	/// </seealso>
	// Token: 0x02000806 RID: 2054
	public abstract class vtkGenericSubdivisionErrorMetric : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601516F RID: 86383 RVA: 0x001DD845 File Offset: 0x001DBA45
		static vtkGenericSubdivisionErrorMetric()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericSubdivisionErrorMetric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericSubdivisionErrorMetric"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015170 RID: 86384 RVA: 0x001DD86D File Offset: 0x001DBA6D
		public vtkGenericSubdivisionErrorMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015171 RID: 86385 RVA: 0x001DD87B File Offset: 0x001DBA7B
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015172 RID: 86386
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericSubdivisionErrorMetric_GetDataSet_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the dataset to be tessellated.
		/// </summary>
		// Token: 0x06015173 RID: 86387 RVA: 0x001DD888 File Offset: 0x001DBA88
		public virtual vtkGenericDataSet GetDataSet()
		{
			vtkGenericDataSet vtkGenericDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_GetDataSet_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericDataSet = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericDataSet.Register(null);
				}
			}
			return vtkGenericDataSet;
		}

		// Token: 0x06015174 RID: 86388
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericSubdivisionErrorMetric_GetError_02(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		/// <summary>
		/// Return the error at the mid-point. The type of error depends on the state
		/// of the concrete error metric. For instance, it can return an absolute
		/// or relative error metric.
		/// See RequiresEdgeSubdivision() for a description of the arguments.
		/// \pre leftPoint_exists: leftPoint!=0
		/// \pre midPoint_exists: midPoint!=0
		/// \pre rightPoint_exists: rightPoint!=0
		/// \pre clamped_alpha: alpha&gt;0 &amp;&amp; alpha&lt;1
		/// \pre valid_size: sizeof(leftPoint)=sizeof(midPoint)=sizeof(rightPoint)
		/// =GetAttributeCollection()-&gt;GetNumberOfPointCenteredComponents()+6
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x06015175 RID: 86389 RVA: 0x001DD8F8 File Offset: 0x001DBAF8
		public virtual double GetError(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_GetError_02(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		// Token: 0x06015176 RID: 86390
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericSubdivisionErrorMetric_GetGenericCell_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The cell that the edge belongs to.
		/// </summary>
		// Token: 0x06015177 RID: 86391 RVA: 0x001DD91C File Offset: 0x001DBB1C
		public virtual vtkGenericAdaptorCell GetGenericCell()
		{
			vtkGenericAdaptorCell vtkGenericAdaptorCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_GetGenericCell_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06015178 RID: 86392
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericSubdivisionErrorMetric_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x06015179 RID: 86393 RVA: 0x001DD98C File Offset: 0x001DBB8C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601517A RID: 86394
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericSubdivisionErrorMetric_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601517B RID: 86395 RVA: 0x001DD9AC File Offset: 0x001DBBAC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601517C RID: 86396
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericSubdivisionErrorMetric_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601517D RID: 86397 RVA: 0x001DD9C8 File Offset: 0x001DBBC8
		public override int IsA(string type)
		{
			return vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601517E RID: 86398
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericSubdivisionErrorMetric_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x0601517F RID: 86399 RVA: 0x001DD9E8 File Offset: 0x001DBBE8
		public new static int IsTypeOf(string type)
		{
			return vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_IsTypeOf_07(type);
		}

		// Token: 0x06015180 RID: 86400
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericSubdivisionErrorMetric_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x06015181 RID: 86401 RVA: 0x001DDA04 File Offset: 0x001DBC04
		public new vtkGenericSubdivisionErrorMetric NewInstance()
		{
			vtkGenericSubdivisionErrorMetric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericSubdivisionErrorMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015182 RID: 86402
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericSubdivisionErrorMetric_RequiresEdgeSubdivision_09(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		/// <summary>
		/// Does the edge need to be subdivided according to the implemented
		/// computation?
		/// The edge is defined by its `leftPoint' and its `rightPoint'.
		/// `leftPoint', `midPoint' and `rightPoint' have to be initialized before
		/// calling RequiresEdgeSubdivision().
		/// Their format is global coordinates, parametric coordinates and
		/// point centered attributes: xyx rst abc de...
		/// `alpha' is the normalized abscissa of the midpoint along the edge.
		/// (close to 0 means close to the left point, close to 1 means close to the
		/// right point)
		/// \pre leftPoint_exists: leftPoint!=0
		/// \pre midPoint_exists: midPoint!=0
		/// \pre rightPoint_exists: rightPoint!=0
		/// \pre clamped_alpha: alpha&gt;0 &amp;&amp; alpha&lt;1
		/// \pre valid_size: sizeof(leftPoint)=sizeof(midPoint)=sizeof(rightPoint)
		/// =GetAttributeCollection()-&gt;GetNumberOfPointCenteredComponents()+6
		/// </summary>
		// Token: 0x06015183 RID: 86403 RVA: 0x001DDA60 File Offset: 0x001DBC60
		public virtual int RequiresEdgeSubdivision(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_RequiresEdgeSubdivision_09(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		// Token: 0x06015184 RID: 86404
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericSubdivisionErrorMetric_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK type and error macros.
		/// </summary>
		// Token: 0x06015185 RID: 86405 RVA: 0x001DDA84 File Offset: 0x001DBC84
		public new static vtkGenericSubdivisionErrorMetric SafeDownCast(vtkObjectBase o)
		{
			vtkGenericSubdivisionErrorMetric vtkGenericSubdivisionErrorMetric = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericSubdivisionErrorMetric = (vtkGenericSubdivisionErrorMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericSubdivisionErrorMetric.Register(null);
				}
			}
			return vtkGenericSubdivisionErrorMetric;
		}

		// Token: 0x06015186 RID: 86406
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericSubdivisionErrorMetric_SetDataSet_11(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Set/Get the dataset to be tessellated.
		/// </summary>
		// Token: 0x06015187 RID: 86407 RVA: 0x001DDB04 File Offset: 0x001DBD04
		public void SetDataSet(vtkGenericDataSet ds)
		{
			vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_SetDataSet_11(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x06015188 RID: 86408
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericSubdivisionErrorMetric_SetGenericCell_12(HandleRef pThis, HandleRef cell);

		/// <summary>
		/// The cell that the edge belongs to.
		/// </summary>
		// Token: 0x06015189 RID: 86409 RVA: 0x001DDB34 File Offset: 0x001DBD34
		public void SetGenericCell(vtkGenericAdaptorCell cell)
		{
			vtkGenericSubdivisionErrorMetric.vtkGenericSubdivisionErrorMetric_SetGenericCell_12(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001853 RID: 6227
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericSubdivisionErrorMetric";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001854 RID: 6228
		public new static readonly string MRClassNameKey = "class vtkGenericSubdivisionErrorMetric";
	}
}
