using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMarchingSquares
	/// </summary>
	/// <remarks>
	///    generate isoline(s) from structured points set
	///
	/// vtkMarchingSquares is a filter that takes as input a structured points set
	/// and generates on output one or more isolines.  One or more contour values
	/// must be specified to generate the isolines.  Alternatively, you can specify
	/// a min/max scalar range and the number of contours to generate a series of
	/// evenly spaced contour values.
	///
	/// To generate contour lines the input data must be of topological dimension 2
	/// (i.e., an image). If not, you can use the ImageRange ivar to select an
	/// image plane from an input volume. This avoids having to extract a plane first
	/// (using vtkExtractSubVolume).  The filter deals with this by first
	/// trying to use the input data directly, and if not a 2D image, then uses the
	/// ImageRange ivar to reduce it to an image.
	///
	/// @warning
	/// This filter is specialized to images. If you are interested in
	/// contouring other types of data, use the general vtkContourFilter.
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourFilter vtkMarchingCubes vtkSliceCubes vtkDividingCubes
	/// </seealso>
	// Token: 0x02000978 RID: 2424
	public class vtkMarchingSquares : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019443 RID: 103491 RVA: 0x0023335F File Offset: 0x0023155F
		static vtkMarchingSquares()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMarchingSquares.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMarchingSquares"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019444 RID: 103492 RVA: 0x00233387 File Offset: 0x00231587
		public vtkMarchingSquares(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019445 RID: 103493
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarchingSquares_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019446 RID: 103494 RVA: 0x00233398 File Offset: 0x00231598
		public new static vtkMarchingSquares New()
		{
			vtkMarchingSquares result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMarchingSquares.vtkMarchingSquares_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMarchingSquares)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019447 RID: 103495 RVA: 0x002333EC File Offset: 0x002315EC
		public vtkMarchingSquares() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMarchingSquares.vtkMarchingSquares_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019448 RID: 103496 RVA: 0x00233430 File Offset: 0x00231630
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019449 RID: 103497
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingSquares_CreateDefaultLocator_01(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified.
		/// The locator is used to merge coincident points.
		/// </summary>
		// Token: 0x0601944A RID: 103498 RVA: 0x0023343B File Offset: 0x0023163B
		public void CreateDefaultLocator()
		{
			vtkMarchingSquares.vtkMarchingSquares_CreateDefaultLocator_01(base.GetCppThis());
		}

		// Token: 0x0601944B RID: 103499
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingSquares_GenerateValues_02(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Methods to set contour values
		/// </summary>
		// Token: 0x0601944C RID: 103500 RVA: 0x0023344A File Offset: 0x0023164A
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkMarchingSquares.vtkMarchingSquares_GenerateValues_02(base.GetCppThis(), numContours, range);
		}

		// Token: 0x0601944D RID: 103501
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingSquares_GenerateValues_03(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Methods to set contour values
		/// </summary>
		// Token: 0x0601944E RID: 103502 RVA: 0x0023345B File Offset: 0x0023165B
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkMarchingSquares.vtkMarchingSquares_GenerateValues_03(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x0601944F RID: 103503
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarchingSquares_GetImageRange_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the i-j-k index range which define a plane on which to generate
		/// contour lines. Using this ivar it is possible to input a 3D volume
		/// directly and then generate contour lines on one of the i-j-k planes, or
		/// a portion of a plane.
		/// </summary>
		// Token: 0x06019450 RID: 103504 RVA: 0x00233470 File Offset: 0x00231670
		public virtual int[] GetImageRange()
		{
			IntPtr intPtr = vtkMarchingSquares.vtkMarchingSquares_GetImageRange_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06019451 RID: 103505
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingSquares_GetImageRange_05(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the i-j-k index range which define a plane on which to generate
		/// contour lines. Using this ivar it is possible to input a 3D volume
		/// directly and then generate contour lines on one of the i-j-k planes, or
		/// a portion of a plane.
		/// </summary>
		// Token: 0x06019452 RID: 103506 RVA: 0x002334B8 File Offset: 0x002316B8
		public virtual void GetImageRange(IntPtr data)
		{
			vtkMarchingSquares.vtkMarchingSquares_GetImageRange_05(base.GetCppThis(), data);
		}

		// Token: 0x06019453 RID: 103507
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarchingSquares_GetLocator_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Because we delegate to vtkContourValues
		/// </summary>
		// Token: 0x06019454 RID: 103508 RVA: 0x002334C8 File Offset: 0x002316C8
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMarchingSquares.vtkMarchingSquares_GetLocator_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06019455 RID: 103509
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkMarchingSquares_GetMTime_07(HandleRef pThis);

		/// <summary>
		/// Because we delegate to vtkContourValues
		/// </summary>
		// Token: 0x06019456 RID: 103510 RVA: 0x00233538 File Offset: 0x00231738
		public override ulong GetMTime()
		{
			return vtkMarchingSquares.vtkMarchingSquares_GetMTime_07(base.GetCppThis());
		}

		// Token: 0x06019457 RID: 103511
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMarchingSquares_GetNumberOfContours_08(HandleRef pThis);

		/// <summary>
		/// Methods to set contour values
		/// </summary>
		// Token: 0x06019458 RID: 103512 RVA: 0x00233558 File Offset: 0x00231758
		public long GetNumberOfContours()
		{
			return vtkMarchingSquares.vtkMarchingSquares_GetNumberOfContours_08(base.GetCppThis());
		}

		// Token: 0x06019459 RID: 103513
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMarchingSquares_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601945A RID: 103514 RVA: 0x00233578 File Offset: 0x00231778
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMarchingSquares.vtkMarchingSquares_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0601945B RID: 103515
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMarchingSquares_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601945C RID: 103516 RVA: 0x00233598 File Offset: 0x00231798
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMarchingSquares.vtkMarchingSquares_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0601945D RID: 103517
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMarchingSquares_GetValue_11(HandleRef pThis, int i);

		/// <summary>
		/// Methods to set contour values
		/// </summary>
		// Token: 0x0601945E RID: 103518 RVA: 0x002335B4 File Offset: 0x002317B4
		public double GetValue(int i)
		{
			return vtkMarchingSquares.vtkMarchingSquares_GetValue_11(base.GetCppThis(), i);
		}

		// Token: 0x0601945F RID: 103519
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarchingSquares_GetValues_12(HandleRef pThis);

		/// <summary>
		/// Methods to set contour values
		/// </summary>
		// Token: 0x06019460 RID: 103520 RVA: 0x002335D4 File Offset: 0x002317D4
		public IntPtr GetValues()
		{
			return vtkMarchingSquares.vtkMarchingSquares_GetValues_12(base.GetCppThis());
		}

		// Token: 0x06019461 RID: 103521
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingSquares_GetValues_13(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Methods to set contour values
		/// </summary>
		// Token: 0x06019462 RID: 103522 RVA: 0x002335F3 File Offset: 0x002317F3
		public void GetValues(IntPtr contourValues)
		{
			vtkMarchingSquares.vtkMarchingSquares_GetValues_13(base.GetCppThis(), contourValues);
		}

		// Token: 0x06019463 RID: 103523
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMarchingSquares_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019464 RID: 103524 RVA: 0x00233604 File Offset: 0x00231804
		public override int IsA(string type)
		{
			return vtkMarchingSquares.vtkMarchingSquares_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06019465 RID: 103525
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMarchingSquares_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019466 RID: 103526 RVA: 0x00233624 File Offset: 0x00231824
		public new static int IsTypeOf(string type)
		{
			return vtkMarchingSquares.vtkMarchingSquares_IsTypeOf_15(type);
		}

		// Token: 0x06019467 RID: 103527
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarchingSquares_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019468 RID: 103528 RVA: 0x00233640 File Offset: 0x00231840
		public new vtkMarchingSquares NewInstance()
		{
			vtkMarchingSquares result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMarchingSquares.vtkMarchingSquares_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMarchingSquares)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019469 RID: 103529
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMarchingSquares_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601946A RID: 103530 RVA: 0x0023369C File Offset: 0x0023189C
		public new static vtkMarchingSquares SafeDownCast(vtkObjectBase o)
		{
			vtkMarchingSquares vtkMarchingSquares = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMarchingSquares.vtkMarchingSquares_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMarchingSquares = (vtkMarchingSquares)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMarchingSquares.Register(null);
				}
			}
			return vtkMarchingSquares;
		}

		// Token: 0x0601946B RID: 103531
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingSquares_SetImageRange_19(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the i-j-k index range which define a plane on which to generate
		/// contour lines. Using this ivar it is possible to input a 3D volume
		/// directly and then generate contour lines on one of the i-j-k planes, or
		/// a portion of a plane.
		/// </summary>
		// Token: 0x0601946C RID: 103532 RVA: 0x0023371B File Offset: 0x0023191B
		public virtual void SetImageRange(IntPtr data)
		{
			vtkMarchingSquares.vtkMarchingSquares_SetImageRange_19(base.GetCppThis(), data);
		}

		// Token: 0x0601946D RID: 103533
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingSquares_SetImageRange_20(HandleRef pThis, int imin, int imax, int jmin, int jmax, int kmin, int kmax);

		/// <summary>
		/// Set/Get the i-j-k index range which define a plane on which to generate
		/// contour lines. Using this ivar it is possible to input a 3D volume
		/// directly and then generate contour lines on one of the i-j-k planes, or
		/// a portion of a plane.
		/// </summary>
		// Token: 0x0601946E RID: 103534 RVA: 0x0023372B File Offset: 0x0023192B
		public void SetImageRange(int imin, int imax, int jmin, int jmax, int kmin, int kmax)
		{
			vtkMarchingSquares.vtkMarchingSquares_SetImageRange_20(base.GetCppThis(), imin, imax, jmin, jmax, kmin, kmax);
		}

		// Token: 0x0601946F RID: 103535
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingSquares_SetLocator_21(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Because we delegate to vtkContourValues
		/// </summary>
		// Token: 0x06019470 RID: 103536 RVA: 0x00233744 File Offset: 0x00231944
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkMarchingSquares.vtkMarchingSquares_SetLocator_21(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x06019471 RID: 103537
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingSquares_SetNumberOfContours_22(HandleRef pThis, int number);

		/// <summary>
		/// Methods to set contour values
		/// </summary>
		// Token: 0x06019472 RID: 103538 RVA: 0x00233773 File Offset: 0x00231973
		public void SetNumberOfContours(int number)
		{
			vtkMarchingSquares.vtkMarchingSquares_SetNumberOfContours_22(base.GetCppThis(), number);
		}

		// Token: 0x06019473 RID: 103539
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMarchingSquares_SetValue_23(HandleRef pThis, int i, double value);

		/// <summary>
		/// Methods to set contour values
		/// </summary>
		// Token: 0x06019474 RID: 103540 RVA: 0x00233783 File Offset: 0x00231983
		public void SetValue(int i, double value)
		{
			vtkMarchingSquares.vtkMarchingSquares_SetValue_23(base.GetCppThis(), i, value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BAA RID: 7082
		public new const string MRFullTypeName = "Kitware.VTK.vtkMarchingSquares";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BAB RID: 7083
		public new static readonly string MRClassNameKey = "class vtkMarchingSquares";
	}
}
