using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageMarchingCubes
	/// </summary>
	/// <remarks>
	///    generate isosurface(s) from volume/images
	///
	/// vtkImageMarchingCubes is a filter that takes as input images (e.g., 3D
	/// image region) and generates on output one or more isosurfaces.
	/// One or more contour values must be specified to generate the isosurfaces.
	/// Alternatively, you can specify a min/max scalar range and the number of
	/// contours to generate a series of evenly spaced contour values.
	/// This filter can stream, so that the entire volume need not be loaded at
	/// once.  Streaming is controlled using the instance variable
	/// InputMemoryLimit, which has units KBytes.
	///
	/// @warning
	/// This filter is specialized to volumes. If you are interested in
	/// contouring other types of data, use the general vtkContourFilter. If you
	/// want to contour an image (i.e., a volume slice), use vtkMarchingSquares.
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourFilter vtkSliceCubes vtkMarchingSquares vtkSynchronizedTemplates3D
	/// </seealso>
	// Token: 0x020008AF RID: 2223
	public class vtkImageMarchingCubes : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060170D0 RID: 94416 RVA: 0x002060C7 File Offset: 0x002042C7
		static vtkImageMarchingCubes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMarchingCubes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMarchingCubes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060170D1 RID: 94417 RVA: 0x002060EF File Offset: 0x002042EF
		public vtkImageMarchingCubes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060170D2 RID: 94418
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMarchingCubes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060170D3 RID: 94419 RVA: 0x00206100 File Offset: 0x00204300
		public new static vtkImageMarchingCubes New()
		{
			vtkImageMarchingCubes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMarchingCubes.vtkImageMarchingCubes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMarchingCubes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060170D4 RID: 94420 RVA: 0x00206154 File Offset: 0x00204354
		public vtkImageMarchingCubes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageMarchingCubes.vtkImageMarchingCubes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060170D5 RID: 94421 RVA: 0x00206198 File Offset: 0x00204398
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060170D6 RID: 94422
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMarchingCubes_AddLocatorPoint_01(HandleRef pThis, int cellX, int cellY, int edge, long ptId);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly expensive
		/// in both time and storage. Note that if ComputeNormals is on, gradients will
		/// have to be calculated, but will not be stored in the output dataset.
		/// If the output data will be processed by filters that modify topology or
		/// geometry, it may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060170D7 RID: 94423 RVA: 0x002061A3 File Offset: 0x002043A3
		public void AddLocatorPoint(int cellX, int cellY, int edge, long ptId)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_AddLocatorPoint_01(base.GetCppThis(), cellX, cellY, edge, ptId);
		}

		// Token: 0x060170D8 RID: 94424
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMarchingCubes_ComputeGradientsOff_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly expensive
		/// in both time and storage. Note that if ComputeNormals is on, gradients will
		/// have to be calculated, but will not be stored in the output dataset.
		/// If the output data will be processed by filters that modify topology or
		/// geometry, it may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060170D9 RID: 94425 RVA: 0x002061B7 File Offset: 0x002043B7
		public virtual void ComputeGradientsOff()
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_ComputeGradientsOff_02(base.GetCppThis());
		}

		// Token: 0x060170DA RID: 94426
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMarchingCubes_ComputeGradientsOn_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly expensive
		/// in both time and storage. Note that if ComputeNormals is on, gradients will
		/// have to be calculated, but will not be stored in the output dataset.
		/// If the output data will be processed by filters that modify topology or
		/// geometry, it may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060170DB RID: 94427 RVA: 0x002061C6 File Offset: 0x002043C6
		public virtual void ComputeGradientsOn()
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_ComputeGradientsOn_03(base.GetCppThis());
		}

		// Token: 0x060170DC RID: 94428
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMarchingCubes_ComputeNormalsOff_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly expensive
		/// in both time and storage. If the output data will be processed by filters
		/// that modify topology or geometry, it may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060170DD RID: 94429 RVA: 0x002061D5 File Offset: 0x002043D5
		public virtual void ComputeNormalsOff()
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_ComputeNormalsOff_04(base.GetCppThis());
		}

		// Token: 0x060170DE RID: 94430
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMarchingCubes_ComputeNormalsOn_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly expensive
		/// in both time and storage. If the output data will be processed by filters
		/// that modify topology or geometry, it may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060170DF RID: 94431 RVA: 0x002061E4 File Offset: 0x002043E4
		public virtual void ComputeNormalsOn()
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_ComputeNormalsOn_05(base.GetCppThis());
		}

		// Token: 0x060170E0 RID: 94432
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMarchingCubes_ComputeScalarsOff_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x060170E1 RID: 94433 RVA: 0x002061F3 File Offset: 0x002043F3
		public virtual void ComputeScalarsOff()
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_ComputeScalarsOff_06(base.GetCppThis());
		}

		// Token: 0x060170E2 RID: 94434
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMarchingCubes_ComputeScalarsOn_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x060170E3 RID: 94435 RVA: 0x00206202 File Offset: 0x00204402
		public virtual void ComputeScalarsOn()
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_ComputeScalarsOn_07(base.GetCppThis());
		}

		// Token: 0x060170E4 RID: 94436
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMarchingCubes_GenerateValues_08(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Methods to set contour values
		/// </summary>
		// Token: 0x060170E5 RID: 94437 RVA: 0x00206211 File Offset: 0x00204411
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_GenerateValues_08(base.GetCppThis(), numContours, range);
		}

		// Token: 0x060170E6 RID: 94438
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMarchingCubes_GenerateValues_09(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Methods to set contour values
		/// </summary>
		// Token: 0x060170E7 RID: 94439 RVA: 0x00206222 File Offset: 0x00204422
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_GenerateValues_09(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x060170E8 RID: 94440
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMarchingCubes_GetComputeGradients_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly expensive
		/// in both time and storage. Note that if ComputeNormals is on, gradients will
		/// have to be calculated, but will not be stored in the output dataset.
		/// If the output data will be processed by filters that modify topology or
		/// geometry, it may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060170E9 RID: 94441 RVA: 0x00206234 File Offset: 0x00204434
		public virtual int GetComputeGradients()
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetComputeGradients_10(base.GetCppThis());
		}

		// Token: 0x060170EA RID: 94442
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMarchingCubes_GetComputeNormals_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly expensive
		/// in both time and storage. If the output data will be processed by filters
		/// that modify topology or geometry, it may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060170EB RID: 94443 RVA: 0x00206254 File Offset: 0x00204454
		public virtual int GetComputeNormals()
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetComputeNormals_11(base.GetCppThis());
		}

		// Token: 0x060170EC RID: 94444
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMarchingCubes_GetComputeScalars_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x060170ED RID: 94445 RVA: 0x00206274 File Offset: 0x00204474
		public virtual int GetComputeScalars()
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetComputeScalars_12(base.GetCppThis());
		}

		// Token: 0x060170EE RID: 94446
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMarchingCubes_GetInputMemoryLimit_13(HandleRef pThis);

		/// <summary>
		/// The InputMemoryLimit determines the chunk size (the number of slices
		/// requested at each iteration).  The units of this limit is KiloBytes.
		/// For now, only the Z axis is split.
		/// </summary>
		// Token: 0x060170EF RID: 94447 RVA: 0x00206294 File Offset: 0x00204494
		public virtual long GetInputMemoryLimit()
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetInputMemoryLimit_13(base.GetCppThis());
		}

		// Token: 0x060170F0 RID: 94448
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMarchingCubes_GetLocatorPoint_14(HandleRef pThis, int cellX, int cellY, int edge);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly expensive
		/// in both time and storage. Note that if ComputeNormals is on, gradients will
		/// have to be calculated, but will not be stored in the output dataset.
		/// If the output data will be processed by filters that modify topology or
		/// geometry, it may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x060170F1 RID: 94449 RVA: 0x002062B4 File Offset: 0x002044B4
		public long GetLocatorPoint(int cellX, int cellY, int edge)
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetLocatorPoint_14(base.GetCppThis(), cellX, cellY, edge);
		}

		// Token: 0x060170F2 RID: 94450
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImageMarchingCubes_GetMTime_15(HandleRef pThis);

		/// <summary>
		/// Because we delegate to vtkContourValues &amp; refer to vtkImplicitFunction
		/// </summary>
		// Token: 0x060170F3 RID: 94451 RVA: 0x002062D8 File Offset: 0x002044D8
		public override ulong GetMTime()
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetMTime_15(base.GetCppThis());
		}

		// Token: 0x060170F4 RID: 94452
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMarchingCubes_GetNumberOfContours_16(HandleRef pThis);

		/// <summary>
		/// Methods to set contour values
		/// </summary>
		// Token: 0x060170F5 RID: 94453 RVA: 0x002062F8 File Offset: 0x002044F8
		public long GetNumberOfContours()
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetNumberOfContours_16(base.GetCppThis());
		}

		// Token: 0x060170F6 RID: 94454
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMarchingCubes_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060170F7 RID: 94455 RVA: 0x00206318 File Offset: 0x00204518
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x060170F8 RID: 94456
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMarchingCubes_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060170F9 RID: 94457 RVA: 0x00206338 File Offset: 0x00204538
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x060170FA RID: 94458
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageMarchingCubes_GetValue_19(HandleRef pThis, int i);

		/// <summary>
		/// Methods to set contour values
		/// </summary>
		// Token: 0x060170FB RID: 94459 RVA: 0x00206354 File Offset: 0x00204554
		public double GetValue(int i)
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetValue_19(base.GetCppThis(), i);
		}

		// Token: 0x060170FC RID: 94460
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMarchingCubes_GetValues_20(HandleRef pThis);

		/// <summary>
		/// Methods to set contour values
		/// </summary>
		// Token: 0x060170FD RID: 94461 RVA: 0x00206374 File Offset: 0x00204574
		public IntPtr GetValues()
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetValues_20(base.GetCppThis());
		}

		// Token: 0x060170FE RID: 94462
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMarchingCubes_GetValues_21(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Methods to set contour values
		/// </summary>
		// Token: 0x060170FF RID: 94463 RVA: 0x00206393 File Offset: 0x00204593
		public void GetValues(IntPtr contourValues)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_GetValues_21(base.GetCppThis(), contourValues);
		}

		// Token: 0x06017100 RID: 94464
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMarchingCubes_IncrementLocatorZ_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly expensive
		/// in both time and storage. Note that if ComputeNormals is on, gradients will
		/// have to be calculated, but will not be stored in the output dataset.
		/// If the output data will be processed by filters that modify topology or
		/// geometry, it may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x06017101 RID: 94465 RVA: 0x002063A3 File Offset: 0x002045A3
		public void IncrementLocatorZ()
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_IncrementLocatorZ_22(base.GetCppThis());
		}

		// Token: 0x06017102 RID: 94466
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMarchingCubes_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017103 RID: 94467 RVA: 0x002063B4 File Offset: 0x002045B4
		public override int IsA(string type)
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x06017104 RID: 94468
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMarchingCubes_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017105 RID: 94469 RVA: 0x002063D4 File Offset: 0x002045D4
		public new static int IsTypeOf(string type)
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_IsTypeOf_24(type);
		}

		// Token: 0x06017106 RID: 94470
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMarchingCubes_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017107 RID: 94471 RVA: 0x002063F0 File Offset: 0x002045F0
		public new vtkImageMarchingCubes NewInstance()
		{
			vtkImageMarchingCubes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMarchingCubes.vtkImageMarchingCubes_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMarchingCubes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017108 RID: 94472
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMarchingCubes_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017109 RID: 94473 RVA: 0x0020644C File Offset: 0x0020464C
		public new static vtkImageMarchingCubes SafeDownCast(vtkObjectBase o)
		{
			vtkImageMarchingCubes vtkImageMarchingCubes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMarchingCubes.vtkImageMarchingCubes_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMarchingCubes = (vtkImageMarchingCubes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMarchingCubes.Register(null);
				}
			}
			return vtkImageMarchingCubes;
		}

		// Token: 0x0601710A RID: 94474
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMarchingCubes_SetComputeGradients_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly expensive
		/// in both time and storage. Note that if ComputeNormals is on, gradients will
		/// have to be calculated, but will not be stored in the output dataset.
		/// If the output data will be processed by filters that modify topology or
		/// geometry, it may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x0601710B RID: 94475 RVA: 0x002064CB File Offset: 0x002046CB
		public virtual void SetComputeGradients(int _arg)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_SetComputeGradients_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0601710C RID: 94476
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMarchingCubes_SetComputeNormals_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly expensive
		/// in both time and storage. If the output data will be processed by filters
		/// that modify topology or geometry, it may be wise to turn Normals and Gradients off.
		/// </summary>
		// Token: 0x0601710D RID: 94477 RVA: 0x002064DB File Offset: 0x002046DB
		public virtual void SetComputeNormals(int _arg)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_SetComputeNormals_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0601710E RID: 94478
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMarchingCubes_SetComputeScalars_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x0601710F RID: 94479 RVA: 0x002064EB File Offset: 0x002046EB
		public virtual void SetComputeScalars(int _arg)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_SetComputeScalars_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06017110 RID: 94480
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMarchingCubes_SetInputMemoryLimit_31(HandleRef pThis, long _arg);

		/// <summary>
		/// The InputMemoryLimit determines the chunk size (the number of slices
		/// requested at each iteration).  The units of this limit is KiloBytes.
		/// For now, only the Z axis is split.
		/// </summary>
		// Token: 0x06017111 RID: 94481 RVA: 0x002064FB File Offset: 0x002046FB
		public virtual void SetInputMemoryLimit(long _arg)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_SetInputMemoryLimit_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06017112 RID: 94482
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMarchingCubes_SetNumberOfContours_32(HandleRef pThis, int number);

		/// <summary>
		/// Methods to set contour values
		/// </summary>
		// Token: 0x06017113 RID: 94483 RVA: 0x0020650B File Offset: 0x0020470B
		public void SetNumberOfContours(int number)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_SetNumberOfContours_32(base.GetCppThis(), number);
		}

		// Token: 0x06017114 RID: 94484
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMarchingCubes_SetValue_33(HandleRef pThis, int i, double value);

		/// <summary>
		/// Methods to set contour values
		/// </summary>
		// Token: 0x06017115 RID: 94485 RVA: 0x0020651B File Offset: 0x0020471B
		public void SetValue(int i, double value)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_SetValue_33(base.GetCppThis(), i, value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019C4 RID: 6596
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMarchingCubes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019C5 RID: 6597
		public new static readonly string MRClassNameKey = "class vtkImageMarchingCubes";
	}
}
