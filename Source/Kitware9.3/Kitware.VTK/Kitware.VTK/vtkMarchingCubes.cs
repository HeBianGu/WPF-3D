using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMarchingCubes
	/// </summary>
	/// <remarks>
	///    generate isosurface(s) from volume
	///
	/// vtkMarchingCubes is a filter that takes as input a volume (e.g., 3D
	/// structured point set) and generates on output one or more isosurfaces.
	/// One or more contour values must be specified to generate the isosurfaces.
	/// Alternatively, you can specify a min/max scalar range and the number of
	/// contours to generate a series of evenly spaced contour values.
	///
	/// @warning
	/// This filter is specialized to volumes. If you are interested in
	/// contouring other types of data, use the general vtkContourFilter. If you
	/// want to contour an image (i.e., a volume slice), use vtkMarchingSquares.
	///
	/// </remarks>
	/// <seealso>
	///
	/// Much faster implementations for isocontouring are available. In
	/// particular, vtkFlyingEdges3D and vtkFlyingEdges2D are much faster
	/// and if built with the right options, multithreaded, and scale well
	/// with additional processors.
	///
	///
	/// If you are interested in extracting surfaces from label maps,
	/// consider using vtkDiscreteFlyingEdges3D, vtkDiscreteFlyingEdges2D, or
	/// vtkDiscreteMarchingCubes.
	///
	///
	/// vtkFlyingEdges3D vtkFlyingEdges2D vtkSynchronizedTemplates3D
	/// vtkSynchronizedTemplates2D vtkContourFilter vtkSliceCubes
	/// vtkMarchingSquares vtkDividingCubes vtkDiscreteMarchingCubes
	/// </seealso>
	// Token: 0x02000897 RID: 2199
	public class vtkMarchingCubes : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016D69 RID: 93545 RVA: 0x0020195C File Offset: 0x001FFB5C
		static vtkMarchingCubes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMarchingCubes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMarchingCubes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016D6A RID: 93546 RVA: 0x00201984 File Offset: 0x001FFB84
		public vtkMarchingCubes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016D6B RID: 93547
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarchingCubes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D6C RID: 93548 RVA: 0x00201994 File Offset: 0x001FFB94
		public new static vtkMarchingCubes New()
		{
			vtkMarchingCubes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMarchingCubes.vtkMarchingCubes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMarchingCubes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D6D RID: 93549 RVA: 0x002019E8 File Offset: 0x001FFBE8
		public vtkMarchingCubes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMarchingCubes.vtkMarchingCubes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016D6E RID: 93550 RVA: 0x00201A2C File Offset: 0x001FFC2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016D6F RID: 93551
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingCubes_ComputeGradientsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06016D70 RID: 93552 RVA: 0x00201A37 File Offset: 0x001FFC37
		public virtual void ComputeGradientsOff()
		{
			vtkMarchingCubes.vtkMarchingCubes_ComputeGradientsOff_01(base.GetCppThis());
		}

		// Token: 0x06016D71 RID: 93553
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingCubes_ComputeGradientsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06016D72 RID: 93554 RVA: 0x00201A46 File Offset: 0x001FFC46
		public virtual void ComputeGradientsOn()
		{
			vtkMarchingCubes.vtkMarchingCubes_ComputeGradientsOn_02(base.GetCppThis());
		}

		// Token: 0x06016D73 RID: 93555
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingCubes_ComputeNormalsOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06016D74 RID: 93556 RVA: 0x00201A55 File Offset: 0x001FFC55
		public virtual void ComputeNormalsOff()
		{
			vtkMarchingCubes.vtkMarchingCubes_ComputeNormalsOff_03(base.GetCppThis());
		}

		// Token: 0x06016D75 RID: 93557
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingCubes_ComputeNormalsOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06016D76 RID: 93558 RVA: 0x00201A64 File Offset: 0x001FFC64
		public virtual void ComputeNormalsOn()
		{
			vtkMarchingCubes.vtkMarchingCubes_ComputeNormalsOn_04(base.GetCppThis());
		}

		// Token: 0x06016D77 RID: 93559
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingCubes_ComputeScalarsOff_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06016D78 RID: 93560 RVA: 0x00201A73 File Offset: 0x001FFC73
		public virtual void ComputeScalarsOff()
		{
			vtkMarchingCubes.vtkMarchingCubes_ComputeScalarsOff_05(base.GetCppThis());
		}

		// Token: 0x06016D79 RID: 93561
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingCubes_ComputeScalarsOn_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06016D7A RID: 93562 RVA: 0x00201A82 File Offset: 0x001FFC82
		public virtual void ComputeScalarsOn()
		{
			vtkMarchingCubes.vtkMarchingCubes_ComputeScalarsOn_06(base.GetCppThis());
		}

		// Token: 0x06016D7B RID: 93563
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingCubes_CreateDefaultLocator_07(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is
		/// specified. The locator is used to merge coincident points.
		/// </summary>
		// Token: 0x06016D7C RID: 93564 RVA: 0x00201A91 File Offset: 0x001FFC91
		public void CreateDefaultLocator()
		{
			vtkMarchingCubes.vtkMarchingCubes_CreateDefaultLocator_07(base.GetCppThis());
		}

		// Token: 0x06016D7D RID: 93565
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingCubes_GenerateValues_08(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D7E RID: 93566 RVA: 0x00201AA0 File Offset: 0x001FFCA0
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkMarchingCubes.vtkMarchingCubes_GenerateValues_08(base.GetCppThis(), numContours, range);
		}

		// Token: 0x06016D7F RID: 93567
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingCubes_GenerateValues_09(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D80 RID: 93568 RVA: 0x00201AB1 File Offset: 0x001FFCB1
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkMarchingCubes.vtkMarchingCubes_GenerateValues_09(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x06016D81 RID: 93569
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMarchingCubes_GetComputeGradients_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06016D82 RID: 93570 RVA: 0x00201AC4 File Offset: 0x001FFCC4
		public virtual int GetComputeGradients()
		{
			return vtkMarchingCubes.vtkMarchingCubes_GetComputeGradients_10(base.GetCppThis());
		}

		// Token: 0x06016D83 RID: 93571
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMarchingCubes_GetComputeNormals_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06016D84 RID: 93572 RVA: 0x00201AE4 File Offset: 0x001FFCE4
		public virtual int GetComputeNormals()
		{
			return vtkMarchingCubes.vtkMarchingCubes_GetComputeNormals_11(base.GetCppThis());
		}

		// Token: 0x06016D85 RID: 93573
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMarchingCubes_GetComputeScalars_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06016D86 RID: 93574 RVA: 0x00201B04 File Offset: 0x001FFD04
		public virtual int GetComputeScalars()
		{
			return vtkMarchingCubes.vtkMarchingCubes_GetComputeScalars_12(base.GetCppThis());
		}

		// Token: 0x06016D87 RID: 93575
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarchingCubes_GetLocator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// override the default locator.  Useful for changing the number of
		/// bins for performance or specifying a more aggressive locator.
		/// </summary>
		// Token: 0x06016D88 RID: 93576 RVA: 0x00201B24 File Offset: 0x001FFD24
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMarchingCubes.vtkMarchingCubes_GetLocator_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06016D89 RID: 93577
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkMarchingCubes_GetMTime_14(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D8A RID: 93578 RVA: 0x00201B94 File Offset: 0x001FFD94
		public override ulong GetMTime()
		{
			return vtkMarchingCubes.vtkMarchingCubes_GetMTime_14(base.GetCppThis());
		}

		// Token: 0x06016D8B RID: 93579
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMarchingCubes_GetNumberOfContours_15(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D8C RID: 93580 RVA: 0x00201BB4 File Offset: 0x001FFDB4
		public long GetNumberOfContours()
		{
			return vtkMarchingCubes.vtkMarchingCubes_GetNumberOfContours_15(base.GetCppThis());
		}

		// Token: 0x06016D8D RID: 93581
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMarchingCubes_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D8E RID: 93582 RVA: 0x00201BD4 File Offset: 0x001FFDD4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMarchingCubes.vtkMarchingCubes_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x06016D8F RID: 93583
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMarchingCubes_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D90 RID: 93584 RVA: 0x00201BF4 File Offset: 0x001FFDF4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMarchingCubes.vtkMarchingCubes_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x06016D91 RID: 93585
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMarchingCubes_GetValue_18(HandleRef pThis, int i);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D92 RID: 93586 RVA: 0x00201C10 File Offset: 0x001FFE10
		public double GetValue(int i)
		{
			return vtkMarchingCubes.vtkMarchingCubes_GetValue_18(base.GetCppThis(), i);
		}

		// Token: 0x06016D93 RID: 93587
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarchingCubes_GetValues_19(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D94 RID: 93588 RVA: 0x00201C30 File Offset: 0x001FFE30
		public IntPtr GetValues()
		{
			return vtkMarchingCubes.vtkMarchingCubes_GetValues_19(base.GetCppThis());
		}

		// Token: 0x06016D95 RID: 93589
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingCubes_GetValues_20(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D96 RID: 93590 RVA: 0x00201C4F File Offset: 0x001FFE4F
		public void GetValues(IntPtr contourValues)
		{
			vtkMarchingCubes.vtkMarchingCubes_GetValues_20(base.GetCppThis(), contourValues);
		}

		// Token: 0x06016D97 RID: 93591
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMarchingCubes_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D98 RID: 93592 RVA: 0x00201C60 File Offset: 0x001FFE60
		public override int IsA(string type)
		{
			return vtkMarchingCubes.vtkMarchingCubes_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x06016D99 RID: 93593
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMarchingCubes_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D9A RID: 93594 RVA: 0x00201C80 File Offset: 0x001FFE80
		public new static int IsTypeOf(string type)
		{
			return vtkMarchingCubes.vtkMarchingCubes_IsTypeOf_22(type);
		}

		// Token: 0x06016D9B RID: 93595
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarchingCubes_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D9C RID: 93596 RVA: 0x00201C9C File Offset: 0x001FFE9C
		public new vtkMarchingCubes NewInstance()
		{
			vtkMarchingCubes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMarchingCubes.vtkMarchingCubes_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMarchingCubes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016D9D RID: 93597
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarchingCubes_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016D9E RID: 93598 RVA: 0x00201CF8 File Offset: 0x001FFEF8
		public new static vtkMarchingCubes SafeDownCast(vtkObjectBase o)
		{
			vtkMarchingCubes vtkMarchingCubes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMarchingCubes.vtkMarchingCubes_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMarchingCubes = (vtkMarchingCubes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMarchingCubes.Register(null);
				}
			}
			return vtkMarchingCubes;
		}

		// Token: 0x06016D9F RID: 93599
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingCubes_SetComputeGradients_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is
		/// fairly expensive in both time and storage. Note that if
		/// ComputeNormals is on, gradients will have to be calculated, but
		/// will not be stored in the output dataset.  If the output data
		/// will be processed by filters that modify topology or geometry, it
		/// may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06016DA0 RID: 93600 RVA: 0x00201D77 File Offset: 0x001FFF77
		public virtual void SetComputeGradients(int _arg)
		{
			vtkMarchingCubes.vtkMarchingCubes_SetComputeGradients_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06016DA1 RID: 93601
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingCubes_SetComputeNormals_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be
		/// processed by filters that modify topology or geometry, it may be
		/// wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06016DA2 RID: 93602 RVA: 0x00201D87 File Offset: 0x001FFF87
		public virtual void SetComputeNormals(int _arg)
		{
			vtkMarchingCubes.vtkMarchingCubes_SetComputeNormals_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06016DA3 RID: 93603
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingCubes_SetComputeScalars_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x06016DA4 RID: 93604 RVA: 0x00201D97 File Offset: 0x001FFF97
		public virtual void SetComputeScalars(int _arg)
		{
			vtkMarchingCubes.vtkMarchingCubes_SetComputeScalars_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06016DA5 RID: 93605
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingCubes_SetLocator_29(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// override the default locator.  Useful for changing the number of
		/// bins for performance or specifying a more aggressive locator.
		/// </summary>
		// Token: 0x06016DA6 RID: 93606 RVA: 0x00201DA8 File Offset: 0x001FFFA8
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkMarchingCubes.vtkMarchingCubes_SetLocator_29(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x06016DA7 RID: 93607
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingCubes_SetNumberOfContours_30(HandleRef pThis, int number);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016DA8 RID: 93608 RVA: 0x00201DD7 File Offset: 0x001FFFD7
		public void SetNumberOfContours(int number)
		{
			vtkMarchingCubes.vtkMarchingCubes_SetNumberOfContours_30(base.GetCppThis(), number);
		}

		// Token: 0x06016DA9 RID: 93609
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingCubes_SetValue_31(HandleRef pThis, int i, double value);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016DAA RID: 93610 RVA: 0x00201DE7 File Offset: 0x001FFFE7
		public void SetValue(int i, double value)
		{
			vtkMarchingCubes.vtkMarchingCubes_SetValue_31(base.GetCppThis(), i, value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400198F RID: 6543
		public new const string MRFullTypeName = "Kitware.VTK.vtkMarchingCubes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001990 RID: 6544
		public new static readonly string MRClassNameKey = "class vtkMarchingCubes";
	}
}
