using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSphericalPointIterator
	/// </summary>
	/// <remarks>
	///    Traverse a collection of points in spherical ordering.
	///
	///
	/// vtkSphericalPointIterator is a state-based iterator for traversing a set
	/// of points (i.e., a neighborhood of points) in a dataset, providing a point
	/// traversal order across user-defined "axes" which span a 2D or 3D space
	/// (typically a circle or sphere). The points along each axes may be sorted
	/// in increasing radial order. To define the points, specify a dataset (i.e.,
	/// its associated points, whether the points are represented implicitly or
	/// explicitly) and an associated neighborhood over which to iterate. Methods
	/// for iterating over the points are provided.
	///
	/// For example, consider the axes of iteration to be the four rays emanating
	/// from the center of a square and passing through the center of each of the
	/// four edges of the square. Points to be iterated over are associated (using
	/// a dot product) with each of the four axes, and then can be sorted along
	/// each axis. Then the order of iteration is then: (axis0,pt0), (axis1,pt0),
	/// (axis2,pt0), (axis3,pt0), (axis0,pt1), (axis1,pt1), (axis2,pt1),
	/// (axis3,pt1), (axis0,pt2), (axis1,pt2), (axis2,pt2), (axis3,pt2), and so on
	/// in a "spiraling" fashion until all points are visited. Thus the order of
	/// visitation is: iteration i visits all N axes in order, returning the jth
	/// point sorted along each of the N axes (i.e., i increases the fastest).
	/// Alternatively, methods exist to randomly access points, or points
	/// associated with an axes, so that custom iteration methods can be defined.
	///
	/// The iterator can be defined with any number of axes (defined by 3D
	/// vectors). The axes must not be coincident, and typically are equally
	/// spaced from one another. The order which the axes are defined determines
	/// the order in which the axes (and hence the points) are traversed. So for
	/// example, in a 2D sphere, four axes in the (-x,+x,-y,+y) directions would
	/// provide a "ping pong" iteration, while four axes ordered in the
	/// (+x,+y,-x,-y) directions would provide a counterclockwise rotation
	/// iteration.
	///
	/// The iterator provides thread-safe iteration of dataset points. It supports
	/// both random and forward iteration.
	///
	/// @warning
	/// The behavior of the iterator depends on the ordering of the iteration
	/// axes. It is possible to obtain a wide variety of iteration patterns
	/// depending on these axes. For example, if only one axis is defined, then a
	/// "linear" pattern is possible (i.e., visiting points in the half space
	/// defined by the vector); if two axes, then a "diagonal" iteration pattern;
	/// and so on. Note that points are sorted along the iteration axes depending
	/// on the their projection onto them (e.g., using the dot product). Because
	/// only points with positive projection are associated with an axis, it is
	/// possible that some points in the neighborhood will not be processed (i.e.,
	/// if a point in the neighborhood does not positively project onto any of the
	/// axes, then it will not be iterated over). Thus if all points are to be
	/// iterated over, then the axes must form a basis which covers all points
	/// using positive projections.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVoronoi2D vtkVoronoi3D vtkStaticPointLocator vtkPointLocator
	/// </seealso>
	// Token: 0x02000AC5 RID: 2757
	public class vtkSphericalPointIterator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D02A RID: 118826 RVA: 0x0028E99F File Offset: 0x0028CB9F
		static vtkSphericalPointIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphericalPointIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphericalPointIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D02B RID: 118827 RVA: 0x0028E9C7 File Offset: 0x0028CBC7
		public vtkSphericalPointIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D02C RID: 118828
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphericalPointIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, obtain type information, and
		/// print information about an instance of the class.
		/// </summary>
		// Token: 0x0601D02D RID: 118829 RVA: 0x0028E9D8 File Offset: 0x0028CBD8
		public new static vtkSphericalPointIterator New()
		{
			vtkSphericalPointIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphericalPointIterator.vtkSphericalPointIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphericalPointIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods to instantiate, obtain type information, and
		/// print information about an instance of the class.
		/// </summary>
		// Token: 0x0601D02E RID: 118830 RVA: 0x0028EA2C File Offset: 0x0028CC2C
		public vtkSphericalPointIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSphericalPointIterator.vtkSphericalPointIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D02F RID: 118831 RVA: 0x0028EA70 File Offset: 0x0028CC70
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D030 RID: 118832
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphericalPointIterator_BuildRepresentation_01(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// A convenience method that produces a geometric representation of the
		/// iterator (e.g., axes + center). The representation simply draws lines
		/// for each of the axes emanating from the center point. Each line (or line
		/// cell) is assigned cell data which is the axis number. This is typically
		/// used for debugging or educational purposes. Note that the method
		/// is valid only after Initialize() has been invoked.
		/// </summary>
		// Token: 0x0601D031 RID: 118833 RVA: 0x0028EA7C File Offset: 0x0028CC7C
		public void BuildRepresentation(vtkPolyData pd)
		{
			vtkSphericalPointIterator.vtkSphericalPointIterator_BuildRepresentation_01(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0601D032 RID: 118834
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphericalPointIterator_GetAxes_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Define the axes for the point iterator. This only needs to be defined
		/// once (typically immediately after instantiation). The axes data array
		/// must be a 3-component array, where each 3-tuple defines a vector
		/// defining a axis. The number of axes is limited to 100,000 or less
		/// (typically the numbers of axes are &lt;=20). The order in which the axes
		/// are defined determines the order in which the axes are
		/// traversed. Depending on the order, it's possible to create a variety of
		/// traversal patterns, ranging from clockwise/counterclockwise to spiral to
		/// ping pong (e.g., -x,+x, -y,+y, -z,+z). Note: the defining axes need not
		/// be normalized, they are normalized and copied into internal iterator
		/// storage in the Initialize() method.
		/// </summary>
		// Token: 0x0601D033 RID: 118835 RVA: 0x0028EAAC File Offset: 0x0028CCAC
		public virtual vtkDoubleArray GetAxes()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphericalPointIterator.vtkSphericalPointIterator_GetAxes_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x0601D034 RID: 118836
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphericalPointIterator_GetCurrentPoint_03(HandleRef pThis, ref long ptId, IntPtr x);

		/// <summary>
		/// Get the current point (point id and coordinates) during
		/// forward iteration.
		/// </summary>
		// Token: 0x0601D035 RID: 118837 RVA: 0x0028EB1B File Offset: 0x0028CD1B
		public void GetCurrentPoint(ref long ptId, IntPtr x)
		{
			vtkSphericalPointIterator.vtkSphericalPointIterator_GetCurrentPoint_03(base.GetCppThis(), ref ptId, x);
		}

		// Token: 0x0601D036 RID: 118838
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphericalPointIterator_GetCurrentPoint_04(HandleRef pThis);

		/// <summary>
		/// Return the current point id during forward iteration.
		/// </summary>
		// Token: 0x0601D037 RID: 118839 RVA: 0x0028EB2C File Offset: 0x0028CD2C
		public long GetCurrentPoint()
		{
			return vtkSphericalPointIterator.vtkSphericalPointIterator_GetCurrentPoint_04(base.GetCppThis());
		}

		// Token: 0x0601D038 RID: 118840
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphericalPointIterator_GetDataSet_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Define the dataset and its associated points over which to iterate.
		/// </summary>
		// Token: 0x0601D039 RID: 118841 RVA: 0x0028EB4C File Offset: 0x0028CD4C
		public virtual vtkDataSet GetDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphericalPointIterator.vtkSphericalPointIterator_GetDataSet_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601D03A RID: 118842
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphericalPointIterator_GetNumberOfAxes_06(HandleRef pThis);

		/// <summary>
		/// Return the number of axes defined. The value returned is valid only
		/// after Initialize() is invoked.
		/// </summary>
		// Token: 0x0601D03B RID: 118843 RVA: 0x0028EBBC File Offset: 0x0028CDBC
		public long GetNumberOfAxes()
		{
			return vtkSphericalPointIterator.vtkSphericalPointIterator_GetNumberOfAxes_06(base.GetCppThis());
		}

		// Token: 0x0601D03C RID: 118844
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphericalPointIterator_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, obtain type information, and
		/// print information about an instance of the class.
		/// </summary>
		// Token: 0x0601D03D RID: 118845 RVA: 0x0028EBDC File Offset: 0x0028CDDC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSphericalPointIterator.vtkSphericalPointIterator_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601D03E RID: 118846
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphericalPointIterator_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, obtain type information, and
		/// print information about an instance of the class.
		/// </summary>
		// Token: 0x0601D03F RID: 118847 RVA: 0x0028EBFC File Offset: 0x0028CDFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSphericalPointIterator.vtkSphericalPointIterator_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601D040 RID: 118848
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphericalPointIterator_GetPoint_09(HandleRef pThis, int axis, int ptIdx);

		/// <summary>
		/// Provide random access to the jth point of the ith axis. Returns the point id
		/// located at (axis,ptIdx); or a value &lt;0 if the requested point does not exist.
		/// </summary>
		// Token: 0x0601D041 RID: 118849 RVA: 0x0028EC18 File Offset: 0x0028CE18
		public long GetPoint(int axis, int ptIdx)
		{
			return vtkSphericalPointIterator.vtkSphericalPointIterator_GetPoint_09(base.GetCppThis(), axis, ptIdx);
		}

		// Token: 0x0601D042 RID: 118850
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphericalPointIterator_GetSorting_10(HandleRef pThis);

		/// <summary>
		/// Specify whether points along each axis are radially sorted, and if so,
		/// whether in an ascending or descending direction. (Note that some
		/// operators such as the locator query FindClosestNPoints() return radially
		/// sorted neighborhoods in ascending direction and often do not need
		/// sorting - this can save significant time.)
		/// </summary>
		// Token: 0x0601D043 RID: 118851 RVA: 0x0028EC3C File Offset: 0x0028CE3C
		public virtual int GetSorting()
		{
			return vtkSphericalPointIterator.vtkSphericalPointIterator_GetSorting_10(base.GetCppThis());
		}

		// Token: 0x0601D044 RID: 118852
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphericalPointIterator_GetSortingMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Specify whether points along each axis are radially sorted, and if so,
		/// whether in an ascending or descending direction. (Note that some
		/// operators such as the locator query FindClosestNPoints() return radially
		/// sorted neighborhoods in ascending direction and often do not need
		/// sorting - this can save significant time.)
		/// </summary>
		// Token: 0x0601D045 RID: 118853 RVA: 0x0028EC5C File Offset: 0x0028CE5C
		public virtual int GetSortingMaxValue()
		{
			return vtkSphericalPointIterator.vtkSphericalPointIterator_GetSortingMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0601D046 RID: 118854
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphericalPointIterator_GetSortingMinValue_12(HandleRef pThis);

		/// <summary>
		/// Specify whether points along each axis are radially sorted, and if so,
		/// whether in an ascending or descending direction. (Note that some
		/// operators such as the locator query FindClosestNPoints() return radially
		/// sorted neighborhoods in ascending direction and often do not need
		/// sorting - this can save significant time.)
		/// </summary>
		// Token: 0x0601D047 RID: 118855 RVA: 0x0028EC7C File Offset: 0x0028CE7C
		public virtual int GetSortingMinValue()
		{
			return vtkSphericalPointIterator.vtkSphericalPointIterator_GetSortingMinValue_12(base.GetCppThis());
		}

		// Token: 0x0601D048 RID: 118856
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphericalPointIterator_GoToFirstPoint_13(HandleRef pThis);

		/// <summary>
		/// Begin iterating over the neighborhood of points. It is possible that
		/// not all points are iterated over - those points not projecting onto
		/// any axis with a positive dot product are not visited.
		/// </summary>
		// Token: 0x0601D049 RID: 118857 RVA: 0x0028EC9B File Offset: 0x0028CE9B
		public void GoToFirstPoint()
		{
			vtkSphericalPointIterator.vtkSphericalPointIterator_GoToFirstPoint_13(base.GetCppThis());
		}

		// Token: 0x0601D04A RID: 118858
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphericalPointIterator_GoToNextPoint_14(HandleRef pThis);

		/// <summary>
		/// Go to the next point in the neighborhood. This is only valid when
		/// IsDoneWithTraversal() returns false;
		/// </summary>
		// Token: 0x0601D04B RID: 118859 RVA: 0x0028ECAA File Offset: 0x0028CEAA
		public void GoToNextPoint()
		{
			vtkSphericalPointIterator.vtkSphericalPointIterator_GoToNextPoint_14(base.GetCppThis());
		}

		// Token: 0x0601D04C RID: 118860
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSphericalPointIterator_Initialize_15(HandleRef pThis, IntPtr center, HandleRef neighborhood);

		/// <summary>
		/// Initialize the iteration process around a position [x], over a set of
		/// points (the neighborhood) defined by a list of numNei point ids. (The
		/// point ids refer to the points contained in the dataset.) If
		/// initialization fails (because the Axes or the DataSet have not been
		/// defined) then false is returned; true otherwise. One of the Initialize()
		/// variants enables iteration over all points in the dataset.
		/// </summary>
		// Token: 0x0601D04D RID: 118861 RVA: 0x0028ECBC File Offset: 0x0028CEBC
		public bool Initialize(IntPtr center, vtkIdList neighborhood)
		{
			return vtkSphericalPointIterator.vtkSphericalPointIterator_Initialize_15(base.GetCppThis(), center, (neighborhood == null) ? default(HandleRef) : neighborhood.GetCppThis()) != 0;
		}

		// Token: 0x0601D04E RID: 118862
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSphericalPointIterator_Initialize_16(HandleRef pThis, IntPtr center, long numNei, IntPtr neighborhood);

		/// <summary>
		/// Initialize the iteration process around a position [x], over a set of
		/// points (the neighborhood) defined by a list of numNei point ids. (The
		/// point ids refer to the points contained in the dataset.) If
		/// initialization fails (because the Axes or the DataSet have not been
		/// defined) then false is returned; true otherwise. One of the Initialize()
		/// variants enables iteration over all points in the dataset.
		/// </summary>
		// Token: 0x0601D04F RID: 118863 RVA: 0x0028ECF8 File Offset: 0x0028CEF8
		public bool Initialize(IntPtr center, long numNei, IntPtr neighborhood)
		{
			return vtkSphericalPointIterator.vtkSphericalPointIterator_Initialize_16(base.GetCppThis(), center, numNei, neighborhood) != 0;
		}

		// Token: 0x0601D050 RID: 118864
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSphericalPointIterator_Initialize_17(HandleRef pThis, IntPtr center);

		/// <summary>
		/// Initialize the iteration process around a position [x], over a set of
		/// points (the neighborhood) defined by a list of numNei point ids. (The
		/// point ids refer to the points contained in the dataset.) If
		/// initialization fails (because the Axes or the DataSet have not been
		/// defined) then false is returned; true otherwise. One of the Initialize()
		/// variants enables iteration over all points in the dataset.
		/// </summary>
		// Token: 0x0601D051 RID: 118865 RVA: 0x0028ED24 File Offset: 0x0028CF24
		public bool Initialize(IntPtr center)
		{
			return vtkSphericalPointIterator.vtkSphericalPointIterator_Initialize_17(base.GetCppThis(), center) != 0;
		}

		// Token: 0x0601D052 RID: 118866
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphericalPointIterator_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, obtain type information, and
		/// print information about an instance of the class.
		/// </summary>
		// Token: 0x0601D053 RID: 118867 RVA: 0x0028ED4C File Offset: 0x0028CF4C
		public override int IsA(string type)
		{
			return vtkSphericalPointIterator.vtkSphericalPointIterator_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0601D054 RID: 118868
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSphericalPointIterator_IsDoneWithTraversal_19(HandleRef pThis);

		/// <summary>
		/// Return true if set traversal is completed. Otherwise false.
		/// </summary>
		// Token: 0x0601D055 RID: 118869 RVA: 0x0028ED6C File Offset: 0x0028CF6C
		public bool IsDoneWithTraversal()
		{
			return vtkSphericalPointIterator.vtkSphericalPointIterator_IsDoneWithTraversal_19(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D056 RID: 118870
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphericalPointIterator_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, obtain type information, and
		/// print information about an instance of the class.
		/// </summary>
		// Token: 0x0601D057 RID: 118871 RVA: 0x0028ED94 File Offset: 0x0028CF94
		public new static int IsTypeOf(string type)
		{
			return vtkSphericalPointIterator.vtkSphericalPointIterator_IsTypeOf_20(type);
		}

		// Token: 0x0601D058 RID: 118872
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphericalPointIterator_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, obtain type information, and
		/// print information about an instance of the class.
		/// </summary>
		// Token: 0x0601D059 RID: 118873 RVA: 0x0028EDB0 File Offset: 0x0028CFB0
		public new vtkSphericalPointIterator NewInstance()
		{
			vtkSphericalPointIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphericalPointIterator.vtkSphericalPointIterator_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphericalPointIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D05A RID: 118874
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphericalPointIterator_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, obtain type information, and
		/// print information about an instance of the class.
		/// </summary>
		// Token: 0x0601D05B RID: 118875 RVA: 0x0028EE0C File Offset: 0x0028D00C
		public new static vtkSphericalPointIterator SafeDownCast(vtkObjectBase o)
		{
			vtkSphericalPointIterator vtkSphericalPointIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphericalPointIterator.vtkSphericalPointIterator_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphericalPointIterator = (vtkSphericalPointIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphericalPointIterator.Register(null);
				}
			}
			return vtkSphericalPointIterator;
		}

		// Token: 0x0601D05C RID: 118876
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphericalPointIterator_SetAxes_24(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Define the axes for the point iterator. This only needs to be defined
		/// once (typically immediately after instantiation). The axes data array
		/// must be a 3-component array, where each 3-tuple defines a vector
		/// defining a axis. The number of axes is limited to 100,000 or less
		/// (typically the numbers of axes are &lt;=20). The order in which the axes
		/// are defined determines the order in which the axes are
		/// traversed. Depending on the order, it's possible to create a variety of
		/// traversal patterns, ranging from clockwise/counterclockwise to spiral to
		/// ping pong (e.g., -x,+x, -y,+y, -z,+z). Note: the defining axes need not
		/// be normalized, they are normalized and copied into internal iterator
		/// storage in the Initialize() method.
		/// </summary>
		// Token: 0x0601D05D RID: 118877 RVA: 0x0028EE8C File Offset: 0x0028D08C
		public virtual void SetAxes(vtkDoubleArray _arg)
		{
			vtkSphericalPointIterator.vtkSphericalPointIterator_SetAxes_24(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x0601D05E RID: 118878
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphericalPointIterator_SetAxes_25(HandleRef pThis, int axesType, int resolution);

		/// <summary>
		/// A convenience method to set the iterator axes from the predefined set
		/// enumerated above.  The resolution parameter is optional in some cases -
		/// it is used by axes types that are non-fixed such as rotation of a vector
		/// around a center point in the plane (e.g., x-y plane).
		/// </summary>
		// Token: 0x0601D05F RID: 118879 RVA: 0x0028EEBB File Offset: 0x0028D0BB
		public void SetAxes(int axesType, int resolution)
		{
			vtkSphericalPointIterator.vtkSphericalPointIterator_SetAxes_25(base.GetCppThis(), axesType, resolution);
		}

		// Token: 0x0601D060 RID: 118880
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphericalPointIterator_SetDataSet_26(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Define the dataset and its associated points over which to iterate.
		/// </summary>
		// Token: 0x0601D061 RID: 118881 RVA: 0x0028EECC File Offset: 0x0028D0CC
		public virtual void SetDataSet(vtkDataSet _arg)
		{
			vtkSphericalPointIterator.vtkSphericalPointIterator_SetDataSet_26(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x0601D062 RID: 118882
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphericalPointIterator_SetSortTypeToAscending_27(HandleRef pThis);

		/// <summary>
		/// Specify whether points along each axis are radially sorted, and if so,
		/// whether in an ascending or descending direction. (Note that some
		/// operators such as the locator query FindClosestNPoints() return radially
		/// sorted neighborhoods in ascending direction and often do not need
		/// sorting - this can save significant time.)
		/// </summary>
		// Token: 0x0601D063 RID: 118883 RVA: 0x0028EEFB File Offset: 0x0028D0FB
		public void SetSortTypeToAscending()
		{
			vtkSphericalPointIterator.vtkSphericalPointIterator_SetSortTypeToAscending_27(base.GetCppThis());
		}

		// Token: 0x0601D064 RID: 118884
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphericalPointIterator_SetSortTypeToDescending_28(HandleRef pThis);

		/// <summary>
		/// Specify whether points along each axis are radially sorted, and if so,
		/// whether in an ascending or descending direction. (Note that some
		/// operators such as the locator query FindClosestNPoints() return radially
		/// sorted neighborhoods in ascending direction and often do not need
		/// sorting - this can save significant time.)
		/// </summary>
		// Token: 0x0601D065 RID: 118885 RVA: 0x0028EF0A File Offset: 0x0028D10A
		public void SetSortTypeToDescending()
		{
			vtkSphericalPointIterator.vtkSphericalPointIterator_SetSortTypeToDescending_28(base.GetCppThis());
		}

		// Token: 0x0601D066 RID: 118886
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphericalPointIterator_SetSortTypeToNone_29(HandleRef pThis);

		/// <summary>
		/// Specify whether points along each axis are radially sorted, and if so,
		/// whether in an ascending or descending direction. (Note that some
		/// operators such as the locator query FindClosestNPoints() return radially
		/// sorted neighborhoods in ascending direction and often do not need
		/// sorting - this can save significant time.)
		/// </summary>
		// Token: 0x0601D067 RID: 118887 RVA: 0x0028EF19 File Offset: 0x0028D119
		public void SetSortTypeToNone()
		{
			vtkSphericalPointIterator.vtkSphericalPointIterator_SetSortTypeToNone_29(base.GetCppThis());
		}

		// Token: 0x0601D068 RID: 118888
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphericalPointIterator_SetSorting_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether points along each axis are radially sorted, and if so,
		/// whether in an ascending or descending direction. (Note that some
		/// operators such as the locator query FindClosestNPoints() return radially
		/// sorted neighborhoods in ascending direction and often do not need
		/// sorting - this can save significant time.)
		/// </summary>
		// Token: 0x0601D069 RID: 118889 RVA: 0x0028EF28 File Offset: 0x0028D128
		public virtual void SetSorting(int _arg)
		{
			vtkSphericalPointIterator.vtkSphericalPointIterator_SetSorting_30(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EA6 RID: 7846
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphericalPointIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EA7 RID: 7847
		public new static readonly string MRClassNameKey = "class vtkSphericalPointIterator";

		/// <summary>
		/// While the axes can be arbitrarily specified, it is possible to select
		/// axes from a menu of predefined axes sets. For example, XY_CW_AXES refer
		/// to axes that rotate in clockwise direction starting with the first axis
		/// parallel to the x-axis; with the total number of axes given by the
		/// resolution.  Some 3D regular polyhedral solids are also referred to: the
		/// axes pass through the center of the faces of the solid. So DODECAHEDRON
		/// axes refer to the 12 axes that pass through the center of the 12 faces
		/// of the dodecahedron. In some cases the resolution parameter need not be
		/// specified.
		/// </summary>
		// Token: 0x02000AC6 RID: 2758
		public enum AxesType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001EA9 RID: 7849
			CUBE_AXES = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001EAA RID: 7850
			CUBE_OCTAHEDRON_AXES = 5,
			/// <summary>enum member</summary>
			// Token: 0x04001EAB RID: 7851
			DODECAHEDRON_AXES,
			/// <summary>enum member</summary>
			// Token: 0x04001EAC RID: 7852
			ICOSAHEDRON_AXES,
			/// <summary>enum member</summary>
			// Token: 0x04001EAD RID: 7853
			OCTAHEDRON_AXES = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001EAE RID: 7854
			XY_CCW_AXES = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001EAF RID: 7855
			XY_CW_AXES = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001EB0 RID: 7856
			XY_SQUARE_AXES = 2
		}

		/// <summary>
		/// Points can be sorted along each axis. By default, no sorting is
		/// performed.  Other options are ascending and descending radial
		/// order. Ascended sorting results in point traversal starting near the
		/// center of the iterator, and proceeding radially outward. Descended
		/// sorting results in point traversal starting away from the center of the
		/// iterator, and proceeding radially inward.
		/// </summary>
		// Token: 0x02000AC7 RID: 2759
		public enum SortType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001EB2 RID: 7858
			SORT_ASCENDING = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001EB3 RID: 7859
			SORT_DESCENDING,
			/// <summary>enum member</summary>
			// Token: 0x04001EB4 RID: 7860
			SORT_NONE = 0
		}
	}
}
