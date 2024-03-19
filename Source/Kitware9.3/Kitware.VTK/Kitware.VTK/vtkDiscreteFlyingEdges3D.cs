using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDiscreteFlyingEdges3D
	/// </summary>
	/// <remarks>
	///    generate isosurface from 3D image data (volume)
	///
	/// vtkDiscreteFlyingEdges3D creates output representations of label maps
	/// (e.g., segmented volumes) using a variation of the flying edges
	/// algorithm. The input is a 3D image (volume( where each point is labeled
	/// (integer labels are preferred to real values), and the output data is
	/// polygonal data representing labeled regions. (Note that on output each
	/// region [corresponding to a different contour value] is represented
	/// independently; i.e., points are not shared between regions even if they
	/// are coincident.)
	///
	/// This filter is similar to but produces different results than the filter
	/// vtkDiscreteMarchingCubes. This filter can produce output normals, and each
	/// labeled region is completely disconnected from neighboring regions
	/// (coincident points are not merged). Both algorithms interpolate edges at
	/// the halfway point between vertices with different segmentation labels.
	///
	/// See the paper "Flying Edges: A High-Performance Scalable Isocontouring
	/// Algorithm" by Schroeder, Maynard, Geveci. Proc. of LDAV 2015. Chicago, IL.
	///
	/// @warning
	/// This filter is specialized to 3D volumes. This implementation can produce
	/// degenerate triangles (i.e., zero-area triangles).
	///
	/// @warning
	/// See also vtkPackLabels which is a utility class for renumbering the labels
	/// found in the input segmentation mask to contiguous forms of smaller type.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDiscreteMarchingCubes vtkDiscreteFlyingEdges2D vtkDiscreteFlyingEdges3D
	/// vtkPackLabels
	/// </seealso>
	// Token: 0x02000895 RID: 2197
	public class vtkDiscreteFlyingEdges3D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016CF1 RID: 93425 RVA: 0x00201170 File Offset: 0x001FF370
		static vtkDiscreteFlyingEdges3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDiscreteFlyingEdges3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiscreteFlyingEdges3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016CF2 RID: 93426 RVA: 0x00201198 File Offset: 0x001FF398
		public vtkDiscreteFlyingEdges3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016CF3 RID: 93427
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscreteFlyingEdges3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016CF4 RID: 93428 RVA: 0x002011A8 File Offset: 0x001FF3A8
		public new static vtkDiscreteFlyingEdges3D New()
		{
			vtkDiscreteFlyingEdges3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiscreteFlyingEdges3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016CF5 RID: 93429 RVA: 0x002011FC File Offset: 0x001FF3FC
		public vtkDiscreteFlyingEdges3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016CF6 RID: 93430 RVA: 0x00201240 File Offset: 0x001FF440
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016CF7 RID: 93431
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_ComputeGradientsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly
		/// expensive in both time and storage. Note that if ComputeNormals is on,
		/// gradients will have to be calculated, but will not be stored in the
		/// output dataset. If the output data will be processed by filters that
		/// modify topology or geometry, it may be wise to turn Normals and
		/// Gradients off.
		/// </summary>
		// Token: 0x06016CF8 RID: 93432 RVA: 0x0020124B File Offset: 0x001FF44B
		public virtual void ComputeGradientsOff()
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_ComputeGradientsOff_01(base.GetCppThis());
		}

		// Token: 0x06016CF9 RID: 93433
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_ComputeGradientsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly
		/// expensive in both time and storage. Note that if ComputeNormals is on,
		/// gradients will have to be calculated, but will not be stored in the
		/// output dataset. If the output data will be processed by filters that
		/// modify topology or geometry, it may be wise to turn Normals and
		/// Gradients off.
		/// </summary>
		// Token: 0x06016CFA RID: 93434 RVA: 0x0020125A File Offset: 0x001FF45A
		public virtual void ComputeGradientsOn()
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_ComputeGradientsOn_02(base.GetCppThis());
		}

		// Token: 0x06016CFB RID: 93435
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_ComputeNormalsOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be processed
		/// by filters that modify topology or geometry, it may be wise to turn
		/// Normals and Gradients off.
		/// </summary>
		// Token: 0x06016CFC RID: 93436 RVA: 0x00201269 File Offset: 0x001FF469
		public virtual void ComputeNormalsOff()
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_ComputeNormalsOff_03(base.GetCppThis());
		}

		// Token: 0x06016CFD RID: 93437
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_ComputeNormalsOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be processed
		/// by filters that modify topology or geometry, it may be wise to turn
		/// Normals and Gradients off.
		/// </summary>
		// Token: 0x06016CFE RID: 93438 RVA: 0x00201278 File Offset: 0x001FF478
		public virtual void ComputeNormalsOn()
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_ComputeNormalsOn_04(base.GetCppThis());
		}

		// Token: 0x06016CFF RID: 93439
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_ComputeScalarsOff_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06016D00 RID: 93440 RVA: 0x00201287 File Offset: 0x001FF487
		public virtual void ComputeScalarsOff()
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_ComputeScalarsOff_05(base.GetCppThis());
		}

		// Token: 0x06016D01 RID: 93441
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_ComputeScalarsOn_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06016D02 RID: 93442 RVA: 0x00201296 File Offset: 0x001FF496
		public virtual void ComputeScalarsOn()
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_ComputeScalarsOn_06(base.GetCppThis());
		}

		// Token: 0x06016D03 RID: 93443
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_GenerateValues_07(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x06016D04 RID: 93444 RVA: 0x002012A5 File Offset: 0x001FF4A5
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_GenerateValues_07(base.GetCppThis(), numContours, range);
		}

		// Token: 0x06016D05 RID: 93445
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_GenerateValues_08(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x06016D06 RID: 93446 RVA: 0x002012B6 File Offset: 0x001FF4B6
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_GenerateValues_08(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x06016D07 RID: 93447
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteFlyingEdges3D_GetArrayComponent_09(HandleRef pThis);

		/// <summary>
		/// Set/get which component of the scalar array to contour on; defaults to 0.
		/// </summary>
		// Token: 0x06016D08 RID: 93448 RVA: 0x002012C8 File Offset: 0x001FF4C8
		public virtual int GetArrayComponent()
		{
			return vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_GetArrayComponent_09(base.GetCppThis());
		}

		// Token: 0x06016D09 RID: 93449
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteFlyingEdges3D_GetComputeGradients_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly
		/// expensive in both time and storage. Note that if ComputeNormals is on,
		/// gradients will have to be calculated, but will not be stored in the
		/// output dataset. If the output data will be processed by filters that
		/// modify topology or geometry, it may be wise to turn Normals and
		/// Gradients off.
		/// </summary>
		// Token: 0x06016D0A RID: 93450 RVA: 0x002012E8 File Offset: 0x001FF4E8
		public virtual int GetComputeGradients()
		{
			return vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_GetComputeGradients_10(base.GetCppThis());
		}

		// Token: 0x06016D0B RID: 93451
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteFlyingEdges3D_GetComputeNormals_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be processed
		/// by filters that modify topology or geometry, it may be wise to turn
		/// Normals and Gradients off.
		/// </summary>
		// Token: 0x06016D0C RID: 93452 RVA: 0x00201308 File Offset: 0x001FF508
		public virtual int GetComputeNormals()
		{
			return vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_GetComputeNormals_11(base.GetCppThis());
		}

		// Token: 0x06016D0D RID: 93453
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteFlyingEdges3D_GetComputeScalars_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06016D0E RID: 93454 RVA: 0x00201328 File Offset: 0x001FF528
		public virtual int GetComputeScalars()
		{
			return vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_GetComputeScalars_12(base.GetCppThis());
		}

		// Token: 0x06016D0F RID: 93455
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteFlyingEdges3D_GetInterpolateAttributes_13(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate other attribute data. That is, as the
		/// isosurface is generated, interpolate all point attribute data across
		/// the edge. This is independent of scalar interpolation, which is
		/// controlled by the ComputeScalars flag.
		/// </summary>
		// Token: 0x06016D10 RID: 93456 RVA: 0x00201348 File Offset: 0x001FF548
		public virtual int GetInterpolateAttributes()
		{
			return vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_GetInterpolateAttributes_13(base.GetCppThis());
		}

		// Token: 0x06016D11 RID: 93457
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDiscreteFlyingEdges3D_GetMTime_14(HandleRef pThis);

		/// <summary>
		/// Because we delegate to vtkContourValues.
		/// </summary>
		// Token: 0x06016D12 RID: 93458 RVA: 0x00201368 File Offset: 0x001FF568
		public override ulong GetMTime()
		{
			return vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_GetMTime_14(base.GetCppThis());
		}

		// Token: 0x06016D13 RID: 93459
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiscreteFlyingEdges3D_GetNumberOfContours_15(HandleRef pThis);

		/// <summary>
		/// Get the number of contours in the list of contour values.
		/// </summary>
		// Token: 0x06016D14 RID: 93460 RVA: 0x00201388 File Offset: 0x001FF588
		public long GetNumberOfContours()
		{
			return vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_GetNumberOfContours_15(base.GetCppThis());
		}

		// Token: 0x06016D15 RID: 93461
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiscreteFlyingEdges3D_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D16 RID: 93462 RVA: 0x002013A8 File Offset: 0x001FF5A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x06016D17 RID: 93463
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiscreteFlyingEdges3D_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D18 RID: 93464 RVA: 0x002013C8 File Offset: 0x001FF5C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x06016D19 RID: 93465
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDiscreteFlyingEdges3D_GetValue_18(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith contour value.
		/// </summary>
		// Token: 0x06016D1A RID: 93466 RVA: 0x002013E4 File Offset: 0x001FF5E4
		public double GetValue(int i)
		{
			return vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_GetValue_18(base.GetCppThis(), i);
		}

		// Token: 0x06016D1B RID: 93467
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscreteFlyingEdges3D_GetValues_19(HandleRef pThis);

		/// <summary>
		/// Get a pointer to an array of contour values. There will be
		/// GetNumberOfContours() values in the list.
		/// </summary>
		// Token: 0x06016D1C RID: 93468 RVA: 0x00201404 File Offset: 0x001FF604
		public IntPtr GetValues()
		{
			return vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_GetValues_19(base.GetCppThis());
		}

		// Token: 0x06016D1D RID: 93469
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_GetValues_20(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Fill a supplied list with contour values. There will be
		/// GetNumberOfContours() values in the list. Make sure you allocate
		/// enough memory to hold the list.
		/// </summary>
		// Token: 0x06016D1E RID: 93470 RVA: 0x00201423 File Offset: 0x001FF623
		public void GetValues(IntPtr contourValues)
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_GetValues_20(base.GetCppThis(), contourValues);
		}

		// Token: 0x06016D1F RID: 93471
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_InterpolateAttributesOff_21(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate other attribute data. That is, as the
		/// isosurface is generated, interpolate all point attribute data across
		/// the edge. This is independent of scalar interpolation, which is
		/// controlled by the ComputeScalars flag.
		/// </summary>
		// Token: 0x06016D20 RID: 93472 RVA: 0x00201433 File Offset: 0x001FF633
		public virtual void InterpolateAttributesOff()
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_InterpolateAttributesOff_21(base.GetCppThis());
		}

		// Token: 0x06016D21 RID: 93473
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_InterpolateAttributesOn_22(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate other attribute data. That is, as the
		/// isosurface is generated, interpolate all point attribute data across
		/// the edge. This is independent of scalar interpolation, which is
		/// controlled by the ComputeScalars flag.
		/// </summary>
		// Token: 0x06016D22 RID: 93474 RVA: 0x00201442 File Offset: 0x001FF642
		public virtual void InterpolateAttributesOn()
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_InterpolateAttributesOn_22(base.GetCppThis());
		}

		// Token: 0x06016D23 RID: 93475
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteFlyingEdges3D_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D24 RID: 93476 RVA: 0x00201454 File Offset: 0x001FF654
		public override int IsA(string type)
		{
			return vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x06016D25 RID: 93477
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteFlyingEdges3D_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D26 RID: 93478 RVA: 0x00201474 File Offset: 0x001FF674
		public new static int IsTypeOf(string type)
		{
			return vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_IsTypeOf_24(type);
		}

		// Token: 0x06016D27 RID: 93479
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscreteFlyingEdges3D_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D28 RID: 93480 RVA: 0x00201490 File Offset: 0x001FF690
		public new vtkDiscreteFlyingEdges3D NewInstance()
		{
			vtkDiscreteFlyingEdges3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiscreteFlyingEdges3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016D29 RID: 93481
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscreteFlyingEdges3D_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D2A RID: 93482 RVA: 0x002014EC File Offset: 0x001FF6EC
		public new static vtkDiscreteFlyingEdges3D SafeDownCast(vtkObjectBase o)
		{
			vtkDiscreteFlyingEdges3D vtkDiscreteFlyingEdges3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDiscreteFlyingEdges3D = (vtkDiscreteFlyingEdges3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDiscreteFlyingEdges3D.Register(null);
				}
			}
			return vtkDiscreteFlyingEdges3D;
		}

		// Token: 0x06016D2B RID: 93483
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_SetArrayComponent_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get which component of the scalar array to contour on; defaults to 0.
		/// </summary>
		// Token: 0x06016D2C RID: 93484 RVA: 0x0020156B File Offset: 0x001FF76B
		public virtual void SetArrayComponent(int _arg)
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_SetArrayComponent_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06016D2D RID: 93485
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_SetComputeGradients_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly
		/// expensive in both time and storage. Note that if ComputeNormals is on,
		/// gradients will have to be calculated, but will not be stored in the
		/// output dataset. If the output data will be processed by filters that
		/// modify topology or geometry, it may be wise to turn Normals and
		/// Gradients off.
		/// </summary>
		// Token: 0x06016D2E RID: 93486 RVA: 0x0020157B File Offset: 0x001FF77B
		public virtual void SetComputeGradients(int _arg)
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_SetComputeGradients_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06016D2F RID: 93487
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_SetComputeNormals_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be processed
		/// by filters that modify topology or geometry, it may be wise to turn
		/// Normals and Gradients off.
		/// </summary>
		// Token: 0x06016D30 RID: 93488 RVA: 0x0020158B File Offset: 0x001FF78B
		public virtual void SetComputeNormals(int _arg)
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_SetComputeNormals_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06016D31 RID: 93489
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_SetComputeScalars_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06016D32 RID: 93490 RVA: 0x0020159B File Offset: 0x001FF79B
		public virtual void SetComputeScalars(int _arg)
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_SetComputeScalars_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06016D33 RID: 93491
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_SetInterpolateAttributes_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether to interpolate other attribute data. That is, as the
		/// isosurface is generated, interpolate all point attribute data across
		/// the edge. This is independent of scalar interpolation, which is
		/// controlled by the ComputeScalars flag.
		/// </summary>
		// Token: 0x06016D34 RID: 93492 RVA: 0x002015AB File Offset: 0x001FF7AB
		public virtual void SetInterpolateAttributes(int _arg)
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_SetInterpolateAttributes_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06016D35 RID: 93493
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_SetNumberOfContours_33(HandleRef pThis, int number);

		/// <summary>
		/// Set the number of contours to place into the list. You only really
		/// need to use this method to reduce list size. The method SetValue()
		/// will automatically increase list size as needed.
		/// </summary>
		// Token: 0x06016D36 RID: 93494 RVA: 0x002015BB File Offset: 0x001FF7BB
		public void SetNumberOfContours(int number)
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_SetNumberOfContours_33(base.GetCppThis(), number);
		}

		// Token: 0x06016D37 RID: 93495
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteFlyingEdges3D_SetValue_34(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set a particular contour value at contour number i. The index i ranges
		/// between 0&lt;=i&lt;NumberOfContours.
		/// </summary>
		// Token: 0x06016D38 RID: 93496 RVA: 0x002015CB File Offset: 0x001FF7CB
		public void SetValue(int i, double value)
		{
			vtkDiscreteFlyingEdges3D.vtkDiscreteFlyingEdges3D_SetValue_34(base.GetCppThis(), i, value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400198B RID: 6539
		public new const string MRFullTypeName = "Kitware.VTK.vtkDiscreteFlyingEdges3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400198C RID: 6540
		public new static readonly string MRClassNameKey = "class vtkDiscreteFlyingEdges3D";
	}
}
