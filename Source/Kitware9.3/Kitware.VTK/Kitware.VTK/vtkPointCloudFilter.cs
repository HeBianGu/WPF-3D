using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointCloudFilter
	/// </summary>
	/// <remarks>
	///    abstract class for filtering a point cloud
	///
	///
	/// vtkPointCloudFilter serves as a base for classes that filter point clouds.
	/// It takes as input any vtkPointSet (which represents points explicitly
	/// using vtkPoints) and produces as output an explicit representation of
	/// filtered points via a vtkPolyData. This output vtkPolyData will populate
	/// its instance of vtkPoints, and typically no cells will be defined (i.e.,
	/// no vtkVertex or vtkPolyVertex are contained in the output unless
	/// explicitly requested). Also, after filter execution, the user can request
	/// a vtkIdType* point map which indicates how the input points were mapped to
	/// the output. A value of PointMap[i] &lt; 0 (where i is the ith input point)
	/// means that the ith input point was removed. Otherwise PointMap[i]
	/// indicates the position in the output vtkPoints array (point cloud).
	///
	/// Optionally the filter may produce a second output. This second output is
	/// another vtkPolyData with a vtkPoints that contains the points that were
	/// removed during processing. To produce this second output, you must enable
	/// GenerateOutliers. If this optional, second output is created, then the
	/// contents of the PointMap are modified as well. In this case, a PointMap[i]
	/// &lt; 0 means that the ith input point has been mapped to the (-PointMap[i])-1
	/// position in the second output's vtkPoints.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// @warning
	/// The filter copies point attributes from input to output consistent
	/// with the filtering operation.
	///
	/// @warning
	/// It is convenient to use vtkPointGaussianMapper to render the points (since
	/// this mapper does not require cells to be defined, and it is quite fast).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRadiusOutlierRemoval vtkPointGaussianMapper vtkThresholdPoints
	/// </seealso>
	// Token: 0x0200043E RID: 1086
	public abstract class vtkPointCloudFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CB08 RID: 51976 RVA: 0x0011A5E8 File Offset: 0x001187E8
		static vtkPointCloudFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointCloudFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointCloudFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CB09 RID: 51977 RVA: 0x0011A610 File Offset: 0x00118810
		public vtkPointCloudFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CB0A RID: 51978 RVA: 0x0011A61E File Offset: 0x0011881E
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CB0B RID: 51979
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudFilter_GenerateOutliersOff_01(HandleRef pThis);

		/// <summary>
		/// If this method is enabled (true), then a second output will be created
		/// that contains the outlier points. By default this is off (false).  Note
		/// that if enabled, the PointMap is modified as well: the outlier points
		/// are listed as well, with similar meaning, except their value is negated
		/// and shifted by -1.
		/// </summary>
		// Token: 0x0600CB0C RID: 51980 RVA: 0x0011A629 File Offset: 0x00118829
		public virtual void GenerateOutliersOff()
		{
			vtkPointCloudFilter.vtkPointCloudFilter_GenerateOutliersOff_01(base.GetCppThis());
		}

		// Token: 0x0600CB0D RID: 51981
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudFilter_GenerateOutliersOn_02(HandleRef pThis);

		/// <summary>
		/// If this method is enabled (true), then a second output will be created
		/// that contains the outlier points. By default this is off (false).  Note
		/// that if enabled, the PointMap is modified as well: the outlier points
		/// are listed as well, with similar meaning, except their value is negated
		/// and shifted by -1.
		/// </summary>
		// Token: 0x0600CB0E RID: 51982 RVA: 0x0011A638 File Offset: 0x00118838
		public virtual void GenerateOutliersOn()
		{
			vtkPointCloudFilter.vtkPointCloudFilter_GenerateOutliersOn_02(base.GetCppThis());
		}

		// Token: 0x0600CB0F RID: 51983
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudFilter_GenerateVerticesOff_03(HandleRef pThis);

		/// <summary>
		/// If this method is enabled (true), then the outputs will contain a vertex
		/// cells (i.e., a vtkPolyVertex for each output). This takes a lot more
		/// memory but some VTK filters need cells to function properly. By default
		/// this is off (false).
		/// </summary>
		// Token: 0x0600CB10 RID: 51984 RVA: 0x0011A647 File Offset: 0x00118847
		public virtual void GenerateVerticesOff()
		{
			vtkPointCloudFilter.vtkPointCloudFilter_GenerateVerticesOff_03(base.GetCppThis());
		}

		// Token: 0x0600CB11 RID: 51985
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudFilter_GenerateVerticesOn_04(HandleRef pThis);

		/// <summary>
		/// If this method is enabled (true), then the outputs will contain a vertex
		/// cells (i.e., a vtkPolyVertex for each output). This takes a lot more
		/// memory but some VTK filters need cells to function properly. By default
		/// this is off (false).
		/// </summary>
		// Token: 0x0600CB12 RID: 51986 RVA: 0x0011A656 File Offset: 0x00118856
		public virtual void GenerateVerticesOn()
		{
			vtkPointCloudFilter.vtkPointCloudFilter_GenerateVerticesOn_04(base.GetCppThis());
		}

		// Token: 0x0600CB13 RID: 51987
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointCloudFilter_GetGenerateOutliers_05(HandleRef pThis);

		/// <summary>
		/// If this method is enabled (true), then a second output will be created
		/// that contains the outlier points. By default this is off (false).  Note
		/// that if enabled, the PointMap is modified as well: the outlier points
		/// are listed as well, with similar meaning, except their value is negated
		/// and shifted by -1.
		/// </summary>
		// Token: 0x0600CB14 RID: 51988 RVA: 0x0011A668 File Offset: 0x00118868
		public virtual bool GetGenerateOutliers()
		{
			return vtkPointCloudFilter.vtkPointCloudFilter_GetGenerateOutliers_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CB15 RID: 51989
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointCloudFilter_GetGenerateVertices_06(HandleRef pThis);

		/// <summary>
		/// If this method is enabled (true), then the outputs will contain a vertex
		/// cells (i.e., a vtkPolyVertex for each output). This takes a lot more
		/// memory but some VTK filters need cells to function properly. By default
		/// this is off (false).
		/// </summary>
		// Token: 0x0600CB16 RID: 51990 RVA: 0x0011A690 File Offset: 0x00118890
		public virtual bool GetGenerateVertices()
		{
			return vtkPointCloudFilter.vtkPointCloudFilter_GetGenerateVertices_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CB17 RID: 51991
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointCloudFilter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to obtain type information, and print information.
		/// </summary>
		// Token: 0x0600CB18 RID: 51992 RVA: 0x0011A6B8 File Offset: 0x001188B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointCloudFilter.vtkPointCloudFilter_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600CB19 RID: 51993
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointCloudFilter_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to obtain type information, and print information.
		/// </summary>
		// Token: 0x0600CB1A RID: 51994 RVA: 0x0011A6D8 File Offset: 0x001188D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointCloudFilter.vtkPointCloudFilter_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600CB1B RID: 51995
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointCloudFilter_GetNumberOfPointsRemoved_09(HandleRef pThis);

		/// <summary>
		/// Return the number of points removed after filter execution. The
		/// information returned is valid only after the filter executes.
		/// </summary>
		// Token: 0x0600CB1C RID: 51996 RVA: 0x0011A6F4 File Offset: 0x001188F4
		public long GetNumberOfPointsRemoved()
		{
			return vtkPointCloudFilter.vtkPointCloudFilter_GetNumberOfPointsRemoved_09(base.GetCppThis());
		}

		// Token: 0x0600CB1D RID: 51997
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointCloudFilter_GetPointMap_10(HandleRef pThis);

		/// <summary>
		/// Retrieve a map which indicates, on a point-by-point basis, where each
		/// input point was placed into the output. In other words, map[i] indicates
		/// where the ith input point is located in the output array of points. If
		/// map[i] &lt; 0, then the ith input point was removed during filter
		/// execution.  This method returns valid information only after the filter
		/// executes.
		/// </summary>
		// Token: 0x0600CB1E RID: 51998 RVA: 0x0011A714 File Offset: 0x00118914
		public IntPtr GetPointMap()
		{
			return vtkPointCloudFilter.vtkPointCloudFilter_GetPointMap_10(base.GetCppThis());
		}

		// Token: 0x0600CB1F RID: 51999
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointCloudFilter_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to obtain type information, and print information.
		/// </summary>
		// Token: 0x0600CB20 RID: 52000 RVA: 0x0011A734 File Offset: 0x00118934
		public override int IsA(string type)
		{
			return vtkPointCloudFilter.vtkPointCloudFilter_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600CB21 RID: 52001
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointCloudFilter_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to obtain type information, and print information.
		/// </summary>
		// Token: 0x0600CB22 RID: 52002 RVA: 0x0011A754 File Offset: 0x00118954
		public new static int IsTypeOf(string type)
		{
			return vtkPointCloudFilter.vtkPointCloudFilter_IsTypeOf_12(type);
		}

		// Token: 0x0600CB23 RID: 52003
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointCloudFilter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to obtain type information, and print information.
		/// </summary>
		// Token: 0x0600CB24 RID: 52004 RVA: 0x0011A770 File Offset: 0x00118970
		public new vtkPointCloudFilter NewInstance()
		{
			vtkPointCloudFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointCloudFilter.vtkPointCloudFilter_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointCloudFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CB25 RID: 52005
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointCloudFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to obtain type information, and print information.
		/// </summary>
		// Token: 0x0600CB26 RID: 52006 RVA: 0x0011A7CC File Offset: 0x001189CC
		public new static vtkPointCloudFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPointCloudFilter vtkPointCloudFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointCloudFilter.vtkPointCloudFilter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointCloudFilter = (vtkPointCloudFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointCloudFilter.Register(null);
				}
			}
			return vtkPointCloudFilter;
		}

		// Token: 0x0600CB27 RID: 52007
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudFilter_SetGenerateOutliers_15(HandleRef pThis, byte _arg);

		/// <summary>
		/// If this method is enabled (true), then a second output will be created
		/// that contains the outlier points. By default this is off (false).  Note
		/// that if enabled, the PointMap is modified as well: the outlier points
		/// are listed as well, with similar meaning, except their value is negated
		/// and shifted by -1.
		/// </summary>
		// Token: 0x0600CB28 RID: 52008 RVA: 0x0011A84B File Offset: 0x00118A4B
		public virtual void SetGenerateOutliers(bool _arg)
		{
			vtkPointCloudFilter.vtkPointCloudFilter_SetGenerateOutliers_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CB29 RID: 52009
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudFilter_SetGenerateVertices_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// If this method is enabled (true), then the outputs will contain a vertex
		/// cells (i.e., a vtkPolyVertex for each output). This takes a lot more
		/// memory but some VTK filters need cells to function properly. By default
		/// this is off (false).
		/// </summary>
		// Token: 0x0600CB2A RID: 52010 RVA: 0x0011A863 File Offset: 0x00118A63
		public virtual void SetGenerateVertices(bool _arg)
		{
			vtkPointCloudFilter.vtkPointCloudFilter_SetGenerateVertices_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F09 RID: 3849
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointCloudFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F0A RID: 3850
		public new static readonly string MRClassNameKey = "class vtkPointCloudFilter";
	}
}
