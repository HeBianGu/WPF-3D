using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContourGrid
	/// </summary>
	/// <remarks>
	///    generate isosurfaces/isolines from scalar values (specialized for unstructured grids)
	///
	/// vtkContourGrid is a filter that takes as input datasets of type
	/// vtkUnstructuredGrid and generates on output isosurfaces and/or
	/// isolines. The exact form of the output depends upon the dimensionality of
	/// the input data.  Data consisting of 3D cells will generate isosurfaces,
	/// data consisting of 2D cells will generate isolines, and data with 1D or 0D
	/// cells will generate isopoints. Combinations of output type are possible if
	/// the input dimension is mixed.
	///
	/// To use this filter you must specify one or more contour values.
	/// You can either use the method SetValue() to specify each contour
	/// value, or use GenerateValues() to generate a series of evenly
	/// spaced contours. It is also possible to accelerate the operation of
	/// this filter (at the cost of extra memory) by using a
	/// vtkScalarTree. A scalar tree is used to quickly locate cells that
	/// contain a contour surface. This is especially effective if multiple
	/// contours are being extracted. If you want to use a scalar tree,
	/// invoke the method UseScalarTreeOn().
	///
	/// @warning
	/// If the input vtkUnstructuredGrid contains 3D linear cells, the class
	/// vtkContour3DLinearGrid is much faster and may be preferred in certain
	/// applications.
	///
	/// @warning
	/// For unstructured data or structured grids, normals and gradients
	/// are not computed. Use vtkPolyDataNormals to compute the surface
	/// normals of the resulting isosurface.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContour3DLinearGrid vtkContourFilter vtkMarchingContourFilter
	/// vtkFlyingEdges3D vtkMarchingCubes vtkSliceCubes vtkDividingCubes
	/// vtkMarchingSquares vtkImageMarchingCubes
	/// </seealso>
	// Token: 0x0200041D RID: 1053
	public class vtkContourGrid : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C66A RID: 50794 RVA: 0x00114131 File Offset: 0x00112331
		static vtkContourGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContourGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C66B RID: 50795 RVA: 0x00114159 File Offset: 0x00112359
		public vtkContourGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C66C RID: 50796
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with initial range (0,1) and single contour value
		/// of 0.0.
		/// </summary>
		// Token: 0x0600C66D RID: 50797 RVA: 0x00114168 File Offset: 0x00112368
		public new static vtkContourGrid New()
		{
			vtkContourGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourGrid.vtkContourGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with initial range (0,1) and single contour value
		/// of 0.0.
		/// </summary>
		// Token: 0x0600C66E RID: 50798 RVA: 0x001141BC File Offset: 0x001123BC
		public vtkContourGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkContourGrid.vtkContourGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C66F RID: 50799 RVA: 0x00114200 File Offset: 0x00112400
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C670 RID: 50800
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_ComputeNormalsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x0600C671 RID: 50801 RVA: 0x0011420B File Offset: 0x0011240B
		public virtual void ComputeNormalsOff()
		{
			vtkContourGrid.vtkContourGrid_ComputeNormalsOff_01(base.GetCppThis());
		}

		// Token: 0x0600C672 RID: 50802
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_ComputeNormalsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x0600C673 RID: 50803 RVA: 0x0011421A File Offset: 0x0011241A
		public virtual void ComputeNormalsOn()
		{
			vtkContourGrid.vtkContourGrid_ComputeNormalsOn_02(base.GetCppThis());
		}

		// Token: 0x0600C674 RID: 50804
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_ComputeScalarsOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x0600C675 RID: 50805 RVA: 0x00114229 File Offset: 0x00112429
		public virtual void ComputeScalarsOff()
		{
			vtkContourGrid.vtkContourGrid_ComputeScalarsOff_03(base.GetCppThis());
		}

		// Token: 0x0600C676 RID: 50806
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_ComputeScalarsOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x0600C677 RID: 50807 RVA: 0x00114238 File Offset: 0x00112438
		public virtual void ComputeScalarsOn()
		{
			vtkContourGrid.vtkContourGrid_ComputeScalarsOn_04(base.GetCppThis());
		}

		// Token: 0x0600C678 RID: 50808
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_CreateDefaultLocator_05(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is
		/// specified. The locator is used to merge coincident points.
		/// </summary>
		// Token: 0x0600C679 RID: 50809 RVA: 0x00114247 File Offset: 0x00112447
		public void CreateDefaultLocator()
		{
			vtkContourGrid.vtkContourGrid_CreateDefaultLocator_05(base.GetCppThis());
		}

		// Token: 0x0600C67A RID: 50810
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_GenerateTrianglesOff_06(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles otherwise,
		/// the output may be represented by one or more polygons. WARNING: if the
		/// resulting isocontour is not planar, and GenerateTriangles is false, the
		/// output may consist of some 3D polygons (i.e., which may be non-planar) -
		/// which might be nice to look at but hard to compute with downstream.
		/// </summary>
		// Token: 0x0600C67B RID: 50811 RVA: 0x00114256 File Offset: 0x00112456
		public virtual void GenerateTrianglesOff()
		{
			vtkContourGrid.vtkContourGrid_GenerateTrianglesOff_06(base.GetCppThis());
		}

		// Token: 0x0600C67C RID: 50812
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_GenerateTrianglesOn_07(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles otherwise,
		/// the output may be represented by one or more polygons. WARNING: if the
		/// resulting isocontour is not planar, and GenerateTriangles is false, the
		/// output may consist of some 3D polygons (i.e., which may be non-planar) -
		/// which might be nice to look at but hard to compute with downstream.
		/// </summary>
		// Token: 0x0600C67D RID: 50813 RVA: 0x00114265 File Offset: 0x00112465
		public virtual void GenerateTrianglesOn()
		{
			vtkContourGrid.vtkContourGrid_GenerateTrianglesOn_07(base.GetCppThis());
		}

		// Token: 0x0600C67E RID: 50814
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_GenerateValues_08(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0600C67F RID: 50815 RVA: 0x00114274 File Offset: 0x00112474
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkContourGrid.vtkContourGrid_GenerateValues_08(base.GetCppThis(), numContours, range);
		}

		// Token: 0x0600C680 RID: 50816
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_GenerateValues_09(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0600C681 RID: 50817 RVA: 0x00114285 File Offset: 0x00112485
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkContourGrid.vtkContourGrid_GenerateValues_09(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x0600C682 RID: 50818
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourGrid_GetComputeNormals_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x0600C683 RID: 50819 RVA: 0x00114298 File Offset: 0x00112498
		public virtual int GetComputeNormals()
		{
			return vtkContourGrid.vtkContourGrid_GetComputeNormals_10(base.GetCppThis());
		}

		// Token: 0x0600C684 RID: 50820
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourGrid_GetComputeScalars_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x0600C685 RID: 50821 RVA: 0x001142B8 File Offset: 0x001124B8
		public virtual int GetComputeScalars()
		{
			return vtkContourGrid.vtkContourGrid_GetComputeScalars_11(base.GetCppThis());
		}

		// Token: 0x0600C686 RID: 50822
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourGrid_GetGenerateTriangles_12(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles otherwise,
		/// the output may be represented by one or more polygons. WARNING: if the
		/// resulting isocontour is not planar, and GenerateTriangles is false, the
		/// output may consist of some 3D polygons (i.e., which may be non-planar) -
		/// which might be nice to look at but hard to compute with downstream.
		/// </summary>
		// Token: 0x0600C687 RID: 50823 RVA: 0x001142D8 File Offset: 0x001124D8
		public virtual int GetGenerateTriangles()
		{
			return vtkContourGrid.vtkContourGrid_GetGenerateTriangles_12(base.GetCppThis());
		}

		// Token: 0x0600C688 RID: 50824
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourGrid_GetLocator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600C689 RID: 50825 RVA: 0x001142F8 File Offset: 0x001124F8
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourGrid.vtkContourGrid_GetLocator_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		// Token: 0x0600C68A RID: 50826
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkContourGrid_GetMTime_14(HandleRef pThis);

		/// <summary>
		/// Modified GetMTime Because we delegate to vtkContourValues
		/// </summary>
		// Token: 0x0600C68B RID: 50827 RVA: 0x00114368 File Offset: 0x00112568
		public override ulong GetMTime()
		{
			return vtkContourGrid.vtkContourGrid_GetMTime_14(base.GetCppThis());
		}

		// Token: 0x0600C68C RID: 50828
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourGrid_GetNumberOfContours_15(HandleRef pThis);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0600C68D RID: 50829 RVA: 0x00114388 File Offset: 0x00112588
		public long GetNumberOfContours()
		{
			return vtkContourGrid.vtkContourGrid_GetNumberOfContours_15(base.GetCppThis());
		}

		// Token: 0x0600C68E RID: 50830
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourGrid_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C68F RID: 50831 RVA: 0x001143A8 File Offset: 0x001125A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContourGrid.vtkContourGrid_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0600C690 RID: 50832
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourGrid_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C691 RID: 50833 RVA: 0x001143C8 File Offset: 0x001125C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContourGrid.vtkContourGrid_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0600C692 RID: 50834
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourGrid_GetOutputPointsPrecision_18(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0600C693 RID: 50835 RVA: 0x001143E4 File Offset: 0x001125E4
		public int GetOutputPointsPrecision()
		{
			return vtkContourGrid.vtkContourGrid_GetOutputPointsPrecision_18(base.GetCppThis());
		}

		// Token: 0x0600C694 RID: 50836
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourGrid_GetScalarTree_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the instance of vtkScalarTree to use. If not specified
		/// and UseScalarTree is enabled, then a vtkSimpleScalarTree will be used.
		/// </summary>
		// Token: 0x0600C695 RID: 50837 RVA: 0x00114404 File Offset: 0x00112604
		public virtual vtkScalarTree GetScalarTree()
		{
			vtkScalarTree vtkScalarTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourGrid.vtkContourGrid_GetScalarTree_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarTree = (vtkScalarTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarTree.Register(null);
				}
			}
			return vtkScalarTree;
		}

		// Token: 0x0600C696 RID: 50838
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourGrid_GetUseScalarTree_20(HandleRef pThis);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction.
		/// </summary>
		// Token: 0x0600C697 RID: 50839 RVA: 0x00114474 File Offset: 0x00112674
		public virtual int GetUseScalarTree()
		{
			return vtkContourGrid.vtkContourGrid_GetUseScalarTree_20(base.GetCppThis());
		}

		// Token: 0x0600C698 RID: 50840
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkContourGrid_GetValue_21(HandleRef pThis, int i);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0600C699 RID: 50841 RVA: 0x00114494 File Offset: 0x00112694
		public double GetValue(int i)
		{
			return vtkContourGrid.vtkContourGrid_GetValue_21(base.GetCppThis(), i);
		}

		// Token: 0x0600C69A RID: 50842
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourGrid_GetValues_22(HandleRef pThis);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0600C69B RID: 50843 RVA: 0x001144B4 File Offset: 0x001126B4
		public IntPtr GetValues()
		{
			return vtkContourGrid.vtkContourGrid_GetValues_22(base.GetCppThis());
		}

		// Token: 0x0600C69C RID: 50844
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_GetValues_23(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0600C69D RID: 50845 RVA: 0x001144D3 File Offset: 0x001126D3
		public void GetValues(IntPtr contourValues)
		{
			vtkContourGrid.vtkContourGrid_GetValues_23(base.GetCppThis(), contourValues);
		}

		// Token: 0x0600C69E RID: 50846
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourGrid_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C69F RID: 50847 RVA: 0x001144E4 File Offset: 0x001126E4
		public override int IsA(string type)
		{
			return vtkContourGrid.vtkContourGrid_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0600C6A0 RID: 50848
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourGrid_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C6A1 RID: 50849 RVA: 0x00114504 File Offset: 0x00112704
		public new static int IsTypeOf(string type)
		{
			return vtkContourGrid.vtkContourGrid_IsTypeOf_25(type);
		}

		// Token: 0x0600C6A2 RID: 50850
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourGrid_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C6A3 RID: 50851 RVA: 0x00114520 File Offset: 0x00112720
		public new vtkContourGrid NewInstance()
		{
			vtkContourGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourGrid.vtkContourGrid_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C6A4 RID: 50852
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourGrid_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C6A5 RID: 50853 RVA: 0x0011457C File Offset: 0x0011277C
		public new static vtkContourGrid SafeDownCast(vtkObjectBase o)
		{
			vtkContourGrid vtkContourGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourGrid.vtkContourGrid_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourGrid = (vtkContourGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourGrid.Register(null);
				}
			}
			return vtkContourGrid;
		}

		// Token: 0x0600C6A6 RID: 50854
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_SetComputeNormals_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x0600C6A7 RID: 50855 RVA: 0x001145FB File Offset: 0x001127FB
		public virtual void SetComputeNormals(int _arg)
		{
			vtkContourGrid.vtkContourGrid_SetComputeNormals_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C6A8 RID: 50856
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_SetComputeScalars_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x0600C6A9 RID: 50857 RVA: 0x0011460B File Offset: 0x0011280B
		public virtual void SetComputeScalars(int _arg)
		{
			vtkContourGrid.vtkContourGrid_SetComputeScalars_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C6AA RID: 50858
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_SetGenerateTriangles_31(HandleRef pThis, int _arg);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles otherwise,
		/// the output may be represented by one or more polygons. WARNING: if the
		/// resulting isocontour is not planar, and GenerateTriangles is false, the
		/// output may consist of some 3D polygons (i.e., which may be non-planar) -
		/// which might be nice to look at but hard to compute with downstream.
		/// </summary>
		// Token: 0x0600C6AB RID: 50859 RVA: 0x0011461B File Offset: 0x0011281B
		public virtual void SetGenerateTriangles(int _arg)
		{
			vtkContourGrid.vtkContourGrid_SetGenerateTriangles_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C6AC RID: 50860
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_SetLocator_32(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set / get a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600C6AD RID: 50861 RVA: 0x0011462C File Offset: 0x0011282C
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkContourGrid.vtkContourGrid_SetLocator_32(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600C6AE RID: 50862
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_SetNumberOfContours_33(HandleRef pThis, int number);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0600C6AF RID: 50863 RVA: 0x0011465B File Offset: 0x0011285B
		public void SetNumberOfContours(int number)
		{
			vtkContourGrid.vtkContourGrid_SetNumberOfContours_33(base.GetCppThis(), number);
		}

		// Token: 0x0600C6B0 RID: 50864
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_SetOutputPointsPrecision_34(HandleRef pThis, int precision);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0600C6B1 RID: 50865 RVA: 0x0011466B File Offset: 0x0011286B
		public void SetOutputPointsPrecision(int precision)
		{
			vtkContourGrid.vtkContourGrid_SetOutputPointsPrecision_34(base.GetCppThis(), precision);
		}

		// Token: 0x0600C6B2 RID: 50866
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_SetScalarTree_35(HandleRef pThis, HandleRef sTree);

		/// <summary>
		/// Specify the instance of vtkScalarTree to use. If not specified
		/// and UseScalarTree is enabled, then a vtkSimpleScalarTree will be used.
		/// </summary>
		// Token: 0x0600C6B3 RID: 50867 RVA: 0x0011467C File Offset: 0x0011287C
		public void SetScalarTree(vtkScalarTree sTree)
		{
			vtkContourGrid.vtkContourGrid_SetScalarTree_35(base.GetCppThis(), (sTree == null) ? default(HandleRef) : sTree.GetCppThis());
		}

		// Token: 0x0600C6B4 RID: 50868
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_SetUseScalarTree_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction.
		/// </summary>
		// Token: 0x0600C6B5 RID: 50869 RVA: 0x001146AB File Offset: 0x001128AB
		public virtual void SetUseScalarTree(int _arg)
		{
			vtkContourGrid.vtkContourGrid_SetUseScalarTree_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C6B6 RID: 50870
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_SetValue_37(HandleRef pThis, int i, double value);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x0600C6B7 RID: 50871 RVA: 0x001146BB File Offset: 0x001128BB
		public void SetValue(int i, double value)
		{
			vtkContourGrid.vtkContourGrid_SetValue_37(base.GetCppThis(), i, value);
		}

		// Token: 0x0600C6B8 RID: 50872
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_UseScalarTreeOff_38(HandleRef pThis);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction.
		/// </summary>
		// Token: 0x0600C6B9 RID: 50873 RVA: 0x001146CC File Offset: 0x001128CC
		public virtual void UseScalarTreeOff()
		{
			vtkContourGrid.vtkContourGrid_UseScalarTreeOff_38(base.GetCppThis());
		}

		// Token: 0x0600C6BA RID: 50874
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourGrid_UseScalarTreeOn_39(HandleRef pThis);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction.
		/// </summary>
		// Token: 0x0600C6BB RID: 50875 RVA: 0x001146DB File Offset: 0x001128DB
		public virtual void UseScalarTreeOn()
		{
			vtkContourGrid.vtkContourGrid_UseScalarTreeOn_39(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ECB RID: 3787
		public new const string MRFullTypeName = "Kitware.VTK.vtkContourGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ECC RID: 3788
		public new static readonly string MRClassNameKey = "class vtkContourGrid";
	}
}
