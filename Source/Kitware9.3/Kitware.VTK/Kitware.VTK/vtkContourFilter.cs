using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContourFilter
	/// </summary>
	/// <remarks>
	///    generate isosurfaces/isolines from scalar values
	///
	/// vtkContourFilter is a filter that takes as input any dataset and
	/// generates on output isosurfaces and/or isolines. The exact form
	/// of the output depends upon the dimensionality of the input data.
	/// Data consisting of 3D cells will generate isosurfaces, data
	/// consisting of 2D cells will generate isolines, and data with 1D
	/// or 0D cells will generate isopoints. Combinations of output type
	/// are possible if the input dimension is mixed.
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
	/// For unstructured data or structured grids, normals and gradients
	/// are not computed. Use vtkPolyDataNormals to compute the surface
	/// normals.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFlyingEdges3D vtkFlyingEdges2D vtkDiscreteFlyingEdges3D
	/// vtkDiscreteFlyingEdges2D vtkMarchingContourFilter vtkMarchingCubes
	/// vtkSliceCubes vtkMarchingSquares vtkImageMarchingCubes vtkContour3DLinearGrid
	/// </seealso>
	// Token: 0x02000951 RID: 2385
	public class vtkContourFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018BEE RID: 101358 RVA: 0x00228BFA File Offset: 0x00226DFA
		static vtkContourFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContourFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018BEF RID: 101359 RVA: 0x00228C22 File Offset: 0x00226E22
		public vtkContourFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018BF0 RID: 101360
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with initial range (0,1) and single contour value
		/// of 0.0.
		/// </summary>
		// Token: 0x06018BF1 RID: 101361 RVA: 0x00228C30 File Offset: 0x00226E30
		public new static vtkContourFilter New()
		{
			vtkContourFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourFilter.vtkContourFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with initial range (0,1) and single contour value
		/// of 0.0.
		/// </summary>
		// Token: 0x06018BF2 RID: 101362 RVA: 0x00228C84 File Offset: 0x00226E84
		public vtkContourFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkContourFilter.vtkContourFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018BF3 RID: 101363 RVA: 0x00228CC8 File Offset: 0x00226EC8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018BF4 RID: 101364
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_ComputeGradientsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06018BF5 RID: 101365 RVA: 0x00228CD3 File Offset: 0x00226ED3
		public virtual void ComputeGradientsOff()
		{
			vtkContourFilter.vtkContourFilter_ComputeGradientsOff_01(base.GetCppThis());
		}

		// Token: 0x06018BF6 RID: 101366
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_ComputeGradientsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06018BF7 RID: 101367 RVA: 0x00228CE2 File Offset: 0x00226EE2
		public virtual void ComputeGradientsOn()
		{
			vtkContourFilter.vtkContourFilter_ComputeGradientsOn_02(base.GetCppThis());
		}

		// Token: 0x06018BF8 RID: 101368
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_ComputeNormalsOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// This setting defaults to On for vtkImageData, vtkRectilinearGrid,
		/// vtkStructuredGrid, and vtkUnstructuredGrid inputs.
		/// For others, it defaults to the special value -1 which indicates
		/// that the caller has made no explicit choice and will result in
		/// the normals being computed. This behaviour is a holdover for
		/// backwards compatibility and you really should set this to 0 or 1.
		/// </summary>
		// Token: 0x06018BF9 RID: 101369 RVA: 0x00228CF1 File Offset: 0x00226EF1
		public virtual void ComputeNormalsOff()
		{
			vtkContourFilter.vtkContourFilter_ComputeNormalsOff_03(base.GetCppThis());
		}

		// Token: 0x06018BFA RID: 101370
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_ComputeNormalsOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// This setting defaults to On for vtkImageData, vtkRectilinearGrid,
		/// vtkStructuredGrid, and vtkUnstructuredGrid inputs.
		/// For others, it defaults to the special value -1 which indicates
		/// that the caller has made no explicit choice and will result in
		/// the normals being computed. This behaviour is a holdover for
		/// backwards compatibility and you really should set this to 0 or 1.
		/// </summary>
		// Token: 0x06018BFB RID: 101371 RVA: 0x00228D00 File Offset: 0x00226F00
		public virtual void ComputeNormalsOn()
		{
			vtkContourFilter.vtkContourFilter_ComputeNormalsOn_04(base.GetCppThis());
		}

		// Token: 0x06018BFC RID: 101372
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_ComputeScalarsOff_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06018BFD RID: 101373 RVA: 0x00228D0F File Offset: 0x00226F0F
		public virtual void ComputeScalarsOff()
		{
			vtkContourFilter.vtkContourFilter_ComputeScalarsOff_05(base.GetCppThis());
		}

		// Token: 0x06018BFE RID: 101374
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_ComputeScalarsOn_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06018BFF RID: 101375 RVA: 0x00228D1E File Offset: 0x00226F1E
		public virtual void ComputeScalarsOn()
		{
			vtkContourFilter.vtkContourFilter_ComputeScalarsOn_06(base.GetCppThis());
		}

		// Token: 0x06018C00 RID: 101376
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_CreateDefaultLocator_07(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is
		/// specified. The locator is used to merge coincident points.
		/// </summary>
		// Token: 0x06018C01 RID: 101377 RVA: 0x00228D2D File Offset: 0x00226F2D
		public void CreateDefaultLocator()
		{
			vtkContourFilter.vtkContourFilter_CreateDefaultLocator_07(base.GetCppThis());
		}

		// Token: 0x06018C02 RID: 101378
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_FastModeOff_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off fast mode execution. If enabled, fast mode typically runs
		/// way faster because the internal algorithm FlyingEdges is multithreaded and the algorithm has
		/// performance optimizations, but is does not remove degenerate triangles. FastMode is only
		/// meaningful when the input is vtkImageData and GenerateTriangles is on.
		///
		/// Default is off.
		/// </summary>
		// Token: 0x06018C03 RID: 101379 RVA: 0x00228D3C File Offset: 0x00226F3C
		public virtual void FastModeOff()
		{
			vtkContourFilter.vtkContourFilter_FastModeOff_08(base.GetCppThis());
		}

		// Token: 0x06018C04 RID: 101380
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_FastModeOn_09(HandleRef pThis);

		/// <summary>
		/// Turn on/off fast mode execution. If enabled, fast mode typically runs
		/// way faster because the internal algorithm FlyingEdges is multithreaded and the algorithm has
		/// performance optimizations, but is does not remove degenerate triangles. FastMode is only
		/// meaningful when the input is vtkImageData and GenerateTriangles is on.
		///
		/// Default is off.
		/// </summary>
		// Token: 0x06018C05 RID: 101381 RVA: 0x00228D4B File Offset: 0x00226F4B
		public virtual void FastModeOn()
		{
			vtkContourFilter.vtkContourFilter_FastModeOn_09(base.GetCppThis());
		}

		// Token: 0x06018C06 RID: 101382
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_GenerateTrianglesOff_10(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygon
		/// WARNING: if the contour surface is not planar, the output
		/// polygon will not be planar, which might be nice to look at but hard
		/// to compute with downstream.
		/// </summary>
		// Token: 0x06018C07 RID: 101383 RVA: 0x00228D5A File Offset: 0x00226F5A
		public virtual void GenerateTrianglesOff()
		{
			vtkContourFilter.vtkContourFilter_GenerateTrianglesOff_10(base.GetCppThis());
		}

		// Token: 0x06018C08 RID: 101384
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_GenerateTrianglesOn_11(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygon
		/// WARNING: if the contour surface is not planar, the output
		/// polygon will not be planar, which might be nice to look at but hard
		/// to compute with downstream.
		/// </summary>
		// Token: 0x06018C09 RID: 101385 RVA: 0x00228D69 File Offset: 0x00226F69
		public virtual void GenerateTrianglesOn()
		{
			vtkContourFilter.vtkContourFilter_GenerateTrianglesOn_11(base.GetCppThis());
		}

		// Token: 0x06018C0A RID: 101386
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_GenerateValues_12(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06018C0B RID: 101387 RVA: 0x00228D78 File Offset: 0x00226F78
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkContourFilter.vtkContourFilter_GenerateValues_12(base.GetCppThis(), numContours, range);
		}

		// Token: 0x06018C0C RID: 101388
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_GenerateValues_13(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06018C0D RID: 101389 RVA: 0x00228D89 File Offset: 0x00226F89
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkContourFilter.vtkContourFilter_GenerateValues_13(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x06018C0E RID: 101390
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourFilter_GetArrayComponent_14(HandleRef pThis);

		/// <summary>
		/// Set/get which component of the scalar array to contour on; defaults to 0.
		/// Currently this feature only works if the input is a vtkImageData.
		/// </summary>
		// Token: 0x06018C0F RID: 101391 RVA: 0x00228D9C File Offset: 0x00226F9C
		public virtual int GetArrayComponent()
		{
			return vtkContourFilter.vtkContourFilter_GetArrayComponent_14(base.GetCppThis());
		}

		// Token: 0x06018C10 RID: 101392
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourFilter_GetComputeGradients_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06018C11 RID: 101393 RVA: 0x00228DBC File Offset: 0x00226FBC
		public virtual int GetComputeGradients()
		{
			return vtkContourFilter.vtkContourFilter_GetComputeGradients_15(base.GetCppThis());
		}

		// Token: 0x06018C12 RID: 101394
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourFilter_GetComputeNormals_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// This setting defaults to On for vtkImageData, vtkRectilinearGrid,
		/// vtkStructuredGrid, and vtkUnstructuredGrid inputs.
		/// For others, it defaults to the special value -1 which indicates
		/// that the caller has made no explicit choice and will result in
		/// the normals being computed. This behaviour is a holdover for
		/// backwards compatibility and you really should set this to 0 or 1.
		/// </summary>
		// Token: 0x06018C13 RID: 101395 RVA: 0x00228DDC File Offset: 0x00226FDC
		public virtual int GetComputeNormals()
		{
			return vtkContourFilter.vtkContourFilter_GetComputeNormals_16(base.GetCppThis());
		}

		// Token: 0x06018C14 RID: 101396
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourFilter_GetComputeScalars_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06018C15 RID: 101397 RVA: 0x00228DFC File Offset: 0x00226FFC
		public virtual int GetComputeScalars()
		{
			return vtkContourFilter.vtkContourFilter_GetComputeScalars_17(base.GetCppThis());
		}

		// Token: 0x06018C16 RID: 101398
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContourFilter_GetFastMode_18(HandleRef pThis);

		/// <summary>
		/// Turn on/off fast mode execution. If enabled, fast mode typically runs
		/// way faster because the internal algorithm FlyingEdges is multithreaded and the algorithm has
		/// performance optimizations, but is does not remove degenerate triangles. FastMode is only
		/// meaningful when the input is vtkImageData and GenerateTriangles is on.
		///
		/// Default is off.
		/// </summary>
		// Token: 0x06018C17 RID: 101399 RVA: 0x00228E1C File Offset: 0x0022701C
		public virtual bool GetFastMode()
		{
			return vtkContourFilter.vtkContourFilter_GetFastMode_18(base.GetCppThis()) != 0;
		}

		// Token: 0x06018C18 RID: 101400
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourFilter_GetGenerateTriangles_19(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygon
		/// WARNING: if the contour surface is not planar, the output
		/// polygon will not be planar, which might be nice to look at but hard
		/// to compute with downstream.
		/// </summary>
		// Token: 0x06018C19 RID: 101401 RVA: 0x00228E44 File Offset: 0x00227044
		public virtual int GetGenerateTriangles()
		{
			return vtkContourFilter.vtkContourFilter_GetGenerateTriangles_19(base.GetCppThis());
		}

		// Token: 0x06018C1A RID: 101402
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourFilter_GetLocator_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06018C1B RID: 101403 RVA: 0x00228E64 File Offset: 0x00227064
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourFilter.vtkContourFilter_GetLocator_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06018C1C RID: 101404
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkContourFilter_GetMTime_21(HandleRef pThis);

		/// <summary>
		/// Modified GetMTime Because we delegate to vtkContourValues
		/// </summary>
		// Token: 0x06018C1D RID: 101405 RVA: 0x00228ED4 File Offset: 0x002270D4
		public override ulong GetMTime()
		{
			return vtkContourFilter.vtkContourFilter_GetMTime_21(base.GetCppThis());
		}

		// Token: 0x06018C1E RID: 101406
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourFilter_GetNumberOfContours_22(HandleRef pThis);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06018C1F RID: 101407 RVA: 0x00228EF4 File Offset: 0x002270F4
		public long GetNumberOfContours()
		{
			return vtkContourFilter.vtkContourFilter_GetNumberOfContours_22(base.GetCppThis());
		}

		// Token: 0x06018C20 RID: 101408
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourFilter_GetNumberOfGenerationsFromBase_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C21 RID: 101409 RVA: 0x00228F14 File Offset: 0x00227114
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContourFilter.vtkContourFilter_GetNumberOfGenerationsFromBase_23(base.GetCppThis(), type);
		}

		// Token: 0x06018C22 RID: 101410
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourFilter_GetNumberOfGenerationsFromBaseType_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C23 RID: 101411 RVA: 0x00228F34 File Offset: 0x00227134
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContourFilter.vtkContourFilter_GetNumberOfGenerationsFromBaseType_24(type);
		}

		// Token: 0x06018C24 RID: 101412
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourFilter_GetOutputPointsPrecision_25(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x06018C25 RID: 101413 RVA: 0x00228F50 File Offset: 0x00227150
		public virtual int GetOutputPointsPrecision()
		{
			return vtkContourFilter.vtkContourFilter_GetOutputPointsPrecision_25(base.GetCppThis());
		}

		// Token: 0x06018C26 RID: 101414
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourFilter_GetScalarTree_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction.
		/// </summary>
		// Token: 0x06018C27 RID: 101415 RVA: 0x00228F70 File Offset: 0x00227170
		public virtual vtkScalarTree GetScalarTree()
		{
			vtkScalarTree vtkScalarTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourFilter.vtkContourFilter_GetScalarTree_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06018C28 RID: 101416
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourFilter_GetUseScalarTree_27(HandleRef pThis);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction. By
		/// default, an instance of vtkSpanSpace is created when needed.
		/// </summary>
		// Token: 0x06018C29 RID: 101417 RVA: 0x00228FE0 File Offset: 0x002271E0
		public virtual int GetUseScalarTree()
		{
			return vtkContourFilter.vtkContourFilter_GetUseScalarTree_27(base.GetCppThis());
		}

		// Token: 0x06018C2A RID: 101418
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkContourFilter_GetValue_28(HandleRef pThis, int i);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06018C2B RID: 101419 RVA: 0x00229000 File Offset: 0x00227200
		public double GetValue(int i)
		{
			return vtkContourFilter.vtkContourFilter_GetValue_28(base.GetCppThis(), i);
		}

		// Token: 0x06018C2C RID: 101420
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourFilter_GetValues_29(HandleRef pThis);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06018C2D RID: 101421 RVA: 0x00229020 File Offset: 0x00227220
		public IntPtr GetValues()
		{
			return vtkContourFilter.vtkContourFilter_GetValues_29(base.GetCppThis());
		}

		// Token: 0x06018C2E RID: 101422
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_GetValues_30(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06018C2F RID: 101423 RVA: 0x0022903F File Offset: 0x0022723F
		public void GetValues(IntPtr contourValues)
		{
			vtkContourFilter.vtkContourFilter_GetValues_30(base.GetCppThis(), contourValues);
		}

		// Token: 0x06018C30 RID: 101424
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourFilter_IsA_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C31 RID: 101425 RVA: 0x00229050 File Offset: 0x00227250
		public override int IsA(string type)
		{
			return vtkContourFilter.vtkContourFilter_IsA_31(base.GetCppThis(), type);
		}

		// Token: 0x06018C32 RID: 101426
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourFilter_IsTypeOf_32([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C33 RID: 101427 RVA: 0x00229070 File Offset: 0x00227270
		public new static int IsTypeOf(string type)
		{
			return vtkContourFilter.vtkContourFilter_IsTypeOf_32(type);
		}

		// Token: 0x06018C34 RID: 101428
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourFilter_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C35 RID: 101429 RVA: 0x0022908C File Offset: 0x0022728C
		public new vtkContourFilter NewInstance()
		{
			vtkContourFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourFilter.vtkContourFilter_NewInstance_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018C36 RID: 101430
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourFilter_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C37 RID: 101431 RVA: 0x002290E8 File Offset: 0x002272E8
		public new static vtkContourFilter SafeDownCast(vtkObjectBase o)
		{
			vtkContourFilter vtkContourFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourFilter.vtkContourFilter_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourFilter = (vtkContourFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourFilter.Register(null);
				}
			}
			return vtkContourFilter;
		}

		// Token: 0x06018C38 RID: 101432
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_SetArrayComponent_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get which component of the scalar array to contour on; defaults to 0.
		/// Currently this feature only works if the input is a vtkImageData.
		/// </summary>
		// Token: 0x06018C39 RID: 101433 RVA: 0x00229167 File Offset: 0x00227367
		public virtual void SetArrayComponent(int _arg)
		{
			vtkContourFilter.vtkContourFilter_SetArrayComponent_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06018C3A RID: 101434
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_SetComputeGradients_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06018C3B RID: 101435 RVA: 0x00229177 File Offset: 0x00227377
		public virtual void SetComputeGradients(int _arg)
		{
			vtkContourFilter.vtkContourFilter_SetComputeGradients_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06018C3C RID: 101436
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_SetComputeNormals_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// This setting defaults to On for vtkImageData, vtkRectilinearGrid,
		/// vtkStructuredGrid, and vtkUnstructuredGrid inputs.
		/// For others, it defaults to the special value -1 which indicates
		/// that the caller has made no explicit choice and will result in
		/// the normals being computed. This behaviour is a holdover for
		/// backwards compatibility and you really should set this to 0 or 1.
		/// </summary>
		// Token: 0x06018C3D RID: 101437 RVA: 0x00229187 File Offset: 0x00227387
		public virtual void SetComputeNormals(int _arg)
		{
			vtkContourFilter.vtkContourFilter_SetComputeNormals_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06018C3E RID: 101438
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_SetComputeScalars_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06018C3F RID: 101439 RVA: 0x00229197 File Offset: 0x00227397
		public virtual void SetComputeScalars(int _arg)
		{
			vtkContourFilter.vtkContourFilter_SetComputeScalars_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06018C40 RID: 101440
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_SetFastMode_40(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off fast mode execution. If enabled, fast mode typically runs
		/// way faster because the internal algorithm FlyingEdges is multithreaded and the algorithm has
		/// performance optimizations, but is does not remove degenerate triangles. FastMode is only
		/// meaningful when the input is vtkImageData and GenerateTriangles is on.
		///
		/// Default is off.
		/// </summary>
		// Token: 0x06018C41 RID: 101441 RVA: 0x002291A7 File Offset: 0x002273A7
		public virtual void SetFastMode(bool _arg)
		{
			vtkContourFilter.vtkContourFilter_SetFastMode_40(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06018C42 RID: 101442
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_SetGenerateTriangles_41(HandleRef pThis, int _arg);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygon
		/// WARNING: if the contour surface is not planar, the output
		/// polygon will not be planar, which might be nice to look at but hard
		/// to compute with downstream.
		/// </summary>
		// Token: 0x06018C43 RID: 101443 RVA: 0x002291BF File Offset: 0x002273BF
		public virtual void SetGenerateTriangles(int _arg)
		{
			vtkContourFilter.vtkContourFilter_SetGenerateTriangles_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06018C44 RID: 101444
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_SetLocator_42(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set / get a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06018C45 RID: 101445 RVA: 0x002291D0 File Offset: 0x002273D0
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkContourFilter.vtkContourFilter_SetLocator_42(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x06018C46 RID: 101446
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_SetNumberOfContours_43(HandleRef pThis, int number);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06018C47 RID: 101447 RVA: 0x002291FF File Offset: 0x002273FF
		public void SetNumberOfContours(int number)
		{
			vtkContourFilter.vtkContourFilter_SetNumberOfContours_43(base.GetCppThis(), number);
		}

		// Token: 0x06018C48 RID: 101448
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_SetOutputPointsPrecision_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x06018C49 RID: 101449 RVA: 0x0022920F File Offset: 0x0022740F
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkContourFilter.vtkContourFilter_SetOutputPointsPrecision_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06018C4A RID: 101450
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_SetScalarTree_45(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction.
		/// </summary>
		// Token: 0x06018C4B RID: 101451 RVA: 0x00229220 File Offset: 0x00227420
		public virtual void SetScalarTree(vtkScalarTree arg0)
		{
			vtkContourFilter.vtkContourFilter_SetScalarTree_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06018C4C RID: 101452
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_SetUseScalarTree_46(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction. By
		/// default, an instance of vtkSpanSpace is created when needed.
		/// </summary>
		// Token: 0x06018C4D RID: 101453 RVA: 0x0022924F File Offset: 0x0022744F
		public virtual void SetUseScalarTree(int _arg)
		{
			vtkContourFilter.vtkContourFilter_SetUseScalarTree_46(base.GetCppThis(), _arg);
		}

		// Token: 0x06018C4E RID: 101454
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_SetValue_47(HandleRef pThis, int i, double value);

		/// <summary>
		/// Methods to set / get contour values.
		/// </summary>
		// Token: 0x06018C4F RID: 101455 RVA: 0x0022925F File Offset: 0x0022745F
		public void SetValue(int i, double value)
		{
			vtkContourFilter.vtkContourFilter_SetValue_47(base.GetCppThis(), i, value);
		}

		// Token: 0x06018C50 RID: 101456
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_UseScalarTreeOff_48(HandleRef pThis);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction. By
		/// default, an instance of vtkSpanSpace is created when needed.
		/// </summary>
		// Token: 0x06018C51 RID: 101457 RVA: 0x00229270 File Offset: 0x00227470
		public virtual void UseScalarTreeOff()
		{
			vtkContourFilter.vtkContourFilter_UseScalarTreeOff_48(base.GetCppThis());
		}

		// Token: 0x06018C52 RID: 101458
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourFilter_UseScalarTreeOn_49(HandleRef pThis);

		/// <summary>
		/// Enable the use of a scalar tree to accelerate contour extraction. By
		/// default, an instance of vtkSpanSpace is created when needed.
		/// </summary>
		// Token: 0x06018C53 RID: 101459 RVA: 0x0022927F File Offset: 0x0022747F
		public virtual void UseScalarTreeOn()
		{
			vtkContourFilter.vtkContourFilter_UseScalarTreeOn_49(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B5B RID: 7003
		public new const string MRFullTypeName = "Kitware.VTK.vtkContourFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B5C RID: 7004
		public new static readonly string MRClassNameKey = "class vtkContourFilter";
	}
}
