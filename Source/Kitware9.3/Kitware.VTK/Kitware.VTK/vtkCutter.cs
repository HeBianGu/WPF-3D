using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCutter
	/// </summary>
	/// <remarks>
	///    Cut vtkDataSet with user-specified implicit function
	///
	/// vtkCutter is a filter to cut through data using any subclass of
	/// vtkImplicitFunction. That is, a polygonal surface is created
	/// corresponding to the implicit function F(x,y,z) = value(s), where
	/// you can specify one or more values used to cut with.
	///
	/// In VTK, cutting means reducing a cell of dimension N to a cut surface
	/// of dimension N-1. For example, a tetrahedron when cut by a plane (i.e.,
	/// vtkPlane implicit function) will generate triangles. (In comparison,
	/// clipping takes a N dimensional cell and creates N dimension primitives.)
	///
	/// vtkCutter is generally used to "slice-through" a dataset, generating
	/// a surface that can be visualized. It is also possible to use vtkCutter
	/// to do a form of volume rendering. vtkCutter does this by generating
	/// multiple cut surfaces (usually planes) which are ordered (and rendered)
	/// from back-to-front. The surfaces are set translucent to give a
	/// volumetric rendering effect.
	///
	/// Note that data can be cut using either 1) the scalar values associated
	/// with the dataset or 2) an implicit function associated with this class.
	/// By default, if an implicit function is set it is used to clip the data
	/// set, otherwise the dataset scalars are used to perform the clipping.
	///
	/// Note that this class delegates to vtkPlaneCutter whenever possible since
	/// it's specialized for planes and it's faster because it's multithreaded, and in some
	/// cases also algorithmically faster.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitFunction vtkClipPolyData vtkPlaneCutter
	/// </seealso>
	// Token: 0x0200094A RID: 2378
	public class vtkCutter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018A66 RID: 100966 RVA: 0x00227157 File Offset: 0x00225357
		static vtkCutter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCutter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCutter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018A67 RID: 100967 RVA: 0x0022717F File Offset: 0x0022537F
		public vtkCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018A68 RID: 100968
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with user-specified implicit function; initial value of 0.0; and
		/// generating cut scalars turned off.
		/// </summary>
		// Token: 0x06018A69 RID: 100969 RVA: 0x00227190 File Offset: 0x00225390
		public new static vtkCutter New()
		{
			vtkCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCutter.vtkCutter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with user-specified implicit function; initial value of 0.0; and
		/// generating cut scalars turned off.
		/// </summary>
		// Token: 0x06018A6A RID: 100970 RVA: 0x002271E4 File Offset: 0x002253E4
		public vtkCutter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCutter.vtkCutter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018A6B RID: 100971 RVA: 0x00227228 File Offset: 0x00225428
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018A6C RID: 100972
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_CreateDefaultLocator_01(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified. The
		/// locator is used to merge coincident points.
		/// </summary>
		// Token: 0x06018A6D RID: 100973 RVA: 0x00227233 File Offset: 0x00225433
		public void CreateDefaultLocator()
		{
			vtkCutter.vtkCutter_CreateDefaultLocator_01(base.GetCppThis());
		}

		// Token: 0x06018A6E RID: 100974
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_GenerateCutScalarsOff_02(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the input scalar
		/// data.
		/// </summary>
		// Token: 0x06018A6F RID: 100975 RVA: 0x00227242 File Offset: 0x00225442
		public virtual void GenerateCutScalarsOff()
		{
			vtkCutter.vtkCutter_GenerateCutScalarsOff_02(base.GetCppThis());
		}

		// Token: 0x06018A70 RID: 100976
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_GenerateCutScalarsOn_03(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the input scalar
		/// data.
		/// </summary>
		// Token: 0x06018A71 RID: 100977 RVA: 0x00227251 File Offset: 0x00225451
		public virtual void GenerateCutScalarsOn()
		{
			vtkCutter.vtkCutter_GenerateCutScalarsOn_03(base.GetCppThis());
		}

		// Token: 0x06018A72 RID: 100978
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_GenerateTrianglesOff_04(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygons
		/// WARNING: if the cutting function is not a plane, the output
		/// will be 3D polygons, which might be nice to look at but hard
		/// to compute with downstream.
		/// </summary>
		// Token: 0x06018A73 RID: 100979 RVA: 0x00227260 File Offset: 0x00225460
		public virtual void GenerateTrianglesOff()
		{
			vtkCutter.vtkCutter_GenerateTrianglesOff_04(base.GetCppThis());
		}

		// Token: 0x06018A74 RID: 100980
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_GenerateTrianglesOn_05(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygons
		/// WARNING: if the cutting function is not a plane, the output
		/// will be 3D polygons, which might be nice to look at but hard
		/// to compute with downstream.
		/// </summary>
		// Token: 0x06018A75 RID: 100981 RVA: 0x0022726F File Offset: 0x0022546F
		public virtual void GenerateTrianglesOn()
		{
			vtkCutter.vtkCutter_GenerateTrianglesOn_05(base.GetCppThis());
		}

		// Token: 0x06018A76 RID: 100982
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_GenerateValues_06(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x06018A77 RID: 100983 RVA: 0x0022727E File Offset: 0x0022547E
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkCutter.vtkCutter_GenerateValues_06(base.GetCppThis(), numContours, range);
		}

		// Token: 0x06018A78 RID: 100984
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_GenerateValues_07(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x06018A79 RID: 100985 RVA: 0x0022728F File Offset: 0x0022548F
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkCutter.vtkCutter_GenerateValues_07(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x06018A7A RID: 100986
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_GetCellTypeDimensions_08(IntPtr cellTypeDimensions);

		/// <summary>
		/// Normally I would put this in a different class, but since
		/// This is a temporary fix until we convert this class and contour filter
		/// to generate unstructured grid output instead of poly data, I am leaving it here.
		/// </summary>
		// Token: 0x06018A7B RID: 100987 RVA: 0x002272A1 File Offset: 0x002254A1
		public static void GetCellTypeDimensions(IntPtr cellTypeDimensions)
		{
			vtkCutter.vtkCutter_GetCellTypeDimensions_08(cellTypeDimensions);
		}

		// Token: 0x06018A7C RID: 100988
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCutter_GetCutFunction_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the implicit function to perform the cutting.
		/// </summary>
		// Token: 0x06018A7D RID: 100989 RVA: 0x002272AC File Offset: 0x002254AC
		public virtual vtkImplicitFunction GetCutFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCutter.vtkCutter_GetCutFunction_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		// Token: 0x06018A7E RID: 100990
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCutter_GetGenerateCutScalars_10(HandleRef pThis);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the input scalar
		/// data.
		/// </summary>
		// Token: 0x06018A7F RID: 100991 RVA: 0x0022731C File Offset: 0x0022551C
		public virtual int GetGenerateCutScalars()
		{
			return vtkCutter.vtkCutter_GetGenerateCutScalars_10(base.GetCppThis());
		}

		// Token: 0x06018A80 RID: 100992
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCutter_GetGenerateTriangles_11(HandleRef pThis);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygons
		/// WARNING: if the cutting function is not a plane, the output
		/// will be 3D polygons, which might be nice to look at but hard
		/// to compute with downstream.
		/// </summary>
		// Token: 0x06018A81 RID: 100993 RVA: 0x0022733C File Offset: 0x0022553C
		public virtual int GetGenerateTriangles()
		{
			return vtkCutter.vtkCutter_GetGenerateTriangles_11(base.GetCppThis());
		}

		// Token: 0x06018A82 RID: 100994
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCutter_GetLocator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06018A83 RID: 100995 RVA: 0x0022735C File Offset: 0x0022555C
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCutter.vtkCutter_GetLocator_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06018A84 RID: 100996
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkCutter_GetMTime_13(HandleRef pThis);

		/// <summary>
		/// Override GetMTime because we delegate to vtkContourValues and refer to
		/// vtkImplicitFunction.
		/// </summary>
		// Token: 0x06018A85 RID: 100997 RVA: 0x002273CC File Offset: 0x002255CC
		public override ulong GetMTime()
		{
			return vtkCutter.vtkCutter_GetMTime_13(base.GetCppThis());
		}

		// Token: 0x06018A86 RID: 100998
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCutter_GetNumberOfContours_14(HandleRef pThis);

		/// <summary>
		/// Get the number of contours in the list of contour values.
		/// </summary>
		// Token: 0x06018A87 RID: 100999 RVA: 0x002273EC File Offset: 0x002255EC
		public long GetNumberOfContours()
		{
			return vtkCutter.vtkCutter_GetNumberOfContours_14(base.GetCppThis());
		}

		// Token: 0x06018A88 RID: 101000
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCutter_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018A89 RID: 101001 RVA: 0x0022740C File Offset: 0x0022560C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCutter.vtkCutter_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x06018A8A RID: 101002
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCutter_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018A8B RID: 101003 RVA: 0x0022742C File Offset: 0x0022562C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCutter.vtkCutter_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x06018A8C RID: 101004
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCutter_GetOutputPointsPrecision_17(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018A8D RID: 101005 RVA: 0x00227448 File Offset: 0x00225648
		public virtual int GetOutputPointsPrecision()
		{
			return vtkCutter.vtkCutter_GetOutputPointsPrecision_17(base.GetCppThis());
		}

		// Token: 0x06018A8E RID: 101006
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCutter_GetOutputPointsPrecisionMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018A8F RID: 101007 RVA: 0x00227468 File Offset: 0x00225668
		public virtual int GetOutputPointsPrecisionMaxValue()
		{
			return vtkCutter.vtkCutter_GetOutputPointsPrecisionMaxValue_18(base.GetCppThis());
		}

		// Token: 0x06018A90 RID: 101008
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCutter_GetOutputPointsPrecisionMinValue_19(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018A91 RID: 101009 RVA: 0x00227488 File Offset: 0x00225688
		public virtual int GetOutputPointsPrecisionMinValue()
		{
			return vtkCutter.vtkCutter_GetOutputPointsPrecisionMinValue_19(base.GetCppThis());
		}

		// Token: 0x06018A92 RID: 101010
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCutter_GetSortBy_20(HandleRef pThis);

		/// <summary>
		/// Set the sorting order for the generated polydata. There are two
		/// possibilities:
		/// Sort by value = 0 - This is the most efficient sort. For each cell,
		/// all contour values are processed. This is the default.
		/// Sort by cell = 1 - For each contour value, all cells are processed.
		/// This order should be used if the extracted polygons must be rendered
		/// in a back-to-front or front-to-back order. This is very problem
		/// dependent.
		/// For most applications, the default order is fine (and faster).
		///
		/// Sort by cell is going to have a problem if the input has 2D and 3D cells.
		/// Cell data will be scrambled because with
		/// vtkPolyData output, verts and lines have lower cell ids than triangles.
		/// </summary>
		// Token: 0x06018A93 RID: 101011 RVA: 0x002274A8 File Offset: 0x002256A8
		public virtual int GetSortBy()
		{
			return vtkCutter.vtkCutter_GetSortBy_20(base.GetCppThis());
		}

		// Token: 0x06018A94 RID: 101012
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCutter_GetSortByAsString_21(HandleRef pThis);

		/// <summary>
		/// Set the sorting order for the generated polydata. There are two
		/// possibilities:
		/// Sort by value = 0 - This is the most efficient sort. For each cell,
		/// all contour values are processed. This is the default.
		/// Sort by cell = 1 - For each contour value, all cells are processed.
		/// This order should be used if the extracted polygons must be rendered
		/// in a back-to-front or front-to-back order. This is very problem
		/// dependent.
		/// For most applications, the default order is fine (and faster).
		///
		/// Sort by cell is going to have a problem if the input has 2D and 3D cells.
		/// Cell data will be scrambled because with
		/// vtkPolyData output, verts and lines have lower cell ids than triangles.
		/// </summary>
		// Token: 0x06018A95 RID: 101013 RVA: 0x002274C8 File Offset: 0x002256C8
		public string GetSortByAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkCutter.vtkCutter_GetSortByAsString_21(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018A96 RID: 101014
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCutter_GetSortByMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Set the sorting order for the generated polydata. There are two
		/// possibilities:
		/// Sort by value = 0 - This is the most efficient sort. For each cell,
		/// all contour values are processed. This is the default.
		/// Sort by cell = 1 - For each contour value, all cells are processed.
		/// This order should be used if the extracted polygons must be rendered
		/// in a back-to-front or front-to-back order. This is very problem
		/// dependent.
		/// For most applications, the default order is fine (and faster).
		///
		/// Sort by cell is going to have a problem if the input has 2D and 3D cells.
		/// Cell data will be scrambled because with
		/// vtkPolyData output, verts and lines have lower cell ids than triangles.
		/// </summary>
		// Token: 0x06018A97 RID: 101015 RVA: 0x00227504 File Offset: 0x00225704
		public virtual int GetSortByMaxValue()
		{
			return vtkCutter.vtkCutter_GetSortByMaxValue_22(base.GetCppThis());
		}

		// Token: 0x06018A98 RID: 101016
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCutter_GetSortByMinValue_23(HandleRef pThis);

		/// <summary>
		/// Set the sorting order for the generated polydata. There are two
		/// possibilities:
		/// Sort by value = 0 - This is the most efficient sort. For each cell,
		/// all contour values are processed. This is the default.
		/// Sort by cell = 1 - For each contour value, all cells are processed.
		/// This order should be used if the extracted polygons must be rendered
		/// in a back-to-front or front-to-back order. This is very problem
		/// dependent.
		/// For most applications, the default order is fine (and faster).
		///
		/// Sort by cell is going to have a problem if the input has 2D and 3D cells.
		/// Cell data will be scrambled because with
		/// vtkPolyData output, verts and lines have lower cell ids than triangles.
		/// </summary>
		// Token: 0x06018A99 RID: 101017 RVA: 0x00227524 File Offset: 0x00225724
		public virtual int GetSortByMinValue()
		{
			return vtkCutter.vtkCutter_GetSortByMinValue_23(base.GetCppThis());
		}

		// Token: 0x06018A9A RID: 101018
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCutter_GetValue_24(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith contour value.
		/// </summary>
		// Token: 0x06018A9B RID: 101019 RVA: 0x00227544 File Offset: 0x00225744
		public double GetValue(int i)
		{
			return vtkCutter.vtkCutter_GetValue_24(base.GetCppThis(), i);
		}

		// Token: 0x06018A9C RID: 101020
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCutter_GetValues_25(HandleRef pThis);

		/// <summary>
		/// Get a pointer to an array of contour values. There will be
		/// GetNumberOfContours() values in the list.
		/// </summary>
		// Token: 0x06018A9D RID: 101021 RVA: 0x00227564 File Offset: 0x00225764
		public IntPtr GetValues()
		{
			return vtkCutter.vtkCutter_GetValues_25(base.GetCppThis());
		}

		// Token: 0x06018A9E RID: 101022
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_GetValues_26(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Fill a supplied list with contour values. There will be
		/// GetNumberOfContours() values in the list. Make sure you allocate
		/// enough memory to hold the list.
		/// </summary>
		// Token: 0x06018A9F RID: 101023 RVA: 0x00227583 File Offset: 0x00225783
		public void GetValues(IntPtr contourValues)
		{
			vtkCutter.vtkCutter_GetValues_26(base.GetCppThis(), contourValues);
		}

		// Token: 0x06018AA0 RID: 101024
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCutter_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018AA1 RID: 101025 RVA: 0x00227594 File Offset: 0x00225794
		public override int IsA(string type)
		{
			return vtkCutter.vtkCutter_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x06018AA2 RID: 101026
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCutter_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018AA3 RID: 101027 RVA: 0x002275B4 File Offset: 0x002257B4
		public new static int IsTypeOf(string type)
		{
			return vtkCutter.vtkCutter_IsTypeOf_28(type);
		}

		// Token: 0x06018AA4 RID: 101028
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCutter_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018AA5 RID: 101029 RVA: 0x002275D0 File Offset: 0x002257D0
		public new vtkCutter NewInstance()
		{
			vtkCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCutter.vtkCutter_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018AA6 RID: 101030
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCutter_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018AA7 RID: 101031 RVA: 0x0022762C File Offset: 0x0022582C
		public new static vtkCutter SafeDownCast(vtkObjectBase o)
		{
			vtkCutter vtkCutter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCutter.vtkCutter_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCutter = (vtkCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCutter.Register(null);
				}
			}
			return vtkCutter;
		}

		// Token: 0x06018AA8 RID: 101032
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_SetCutFunction_32(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the implicit function to perform the cutting.
		/// </summary>
		// Token: 0x06018AA9 RID: 101033 RVA: 0x002276AC File Offset: 0x002258AC
		public virtual void SetCutFunction(vtkImplicitFunction arg0)
		{
			vtkCutter.vtkCutter_SetCutFunction_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06018AAA RID: 101034
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_SetGenerateCutScalars_33(HandleRef pThis, int _arg);

		/// <summary>
		/// If this flag is enabled, then the output scalar values will be
		/// interpolated from the implicit function values, and not the input scalar
		/// data.
		/// </summary>
		// Token: 0x06018AAB RID: 101035 RVA: 0x002276DB File Offset: 0x002258DB
		public virtual void SetGenerateCutScalars(int _arg)
		{
			vtkCutter.vtkCutter_SetGenerateCutScalars_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06018AAC RID: 101036
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_SetGenerateTriangles_34(HandleRef pThis, int _arg);

		/// <summary>
		/// If this is enabled (by default), the output will be triangles
		/// otherwise, the output will be the intersection polygons
		/// WARNING: if the cutting function is not a plane, the output
		/// will be 3D polygons, which might be nice to look at but hard
		/// to compute with downstream.
		/// </summary>
		// Token: 0x06018AAD RID: 101037 RVA: 0x002276EB File Offset: 0x002258EB
		public virtual void SetGenerateTriangles(int _arg)
		{
			vtkCutter.vtkCutter_SetGenerateTriangles_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06018AAE RID: 101038
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_SetLocator_35(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06018AAF RID: 101039 RVA: 0x002276FC File Offset: 0x002258FC
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkCutter.vtkCutter_SetLocator_35(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x06018AB0 RID: 101040
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_SetNumberOfContours_36(HandleRef pThis, int number);

		/// <summary>
		/// Set the number of contours to place into the list. You only really
		/// need to use this method to reduce list size. The method SetValue()
		/// will automatically increase list size as needed.
		/// </summary>
		// Token: 0x06018AB1 RID: 101041 RVA: 0x0022772B File Offset: 0x0022592B
		public void SetNumberOfContours(int number)
		{
			vtkCutter.vtkCutter_SetNumberOfContours_36(base.GetCppThis(), number);
		}

		// Token: 0x06018AB2 RID: 101042
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_SetOutputPointsPrecision_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018AB3 RID: 101043 RVA: 0x0022773B File Offset: 0x0022593B
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkCutter.vtkCutter_SetOutputPointsPrecision_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06018AB4 RID: 101044
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_SetSortBy_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the sorting order for the generated polydata. There are two
		/// possibilities:
		/// Sort by value = 0 - This is the most efficient sort. For each cell,
		/// all contour values are processed. This is the default.
		/// Sort by cell = 1 - For each contour value, all cells are processed.
		/// This order should be used if the extracted polygons must be rendered
		/// in a back-to-front or front-to-back order. This is very problem
		/// dependent.
		/// For most applications, the default order is fine (and faster).
		///
		/// Sort by cell is going to have a problem if the input has 2D and 3D cells.
		/// Cell data will be scrambled because with
		/// vtkPolyData output, verts and lines have lower cell ids than triangles.
		/// </summary>
		// Token: 0x06018AB5 RID: 101045 RVA: 0x0022774B File Offset: 0x0022594B
		public virtual void SetSortBy(int _arg)
		{
			vtkCutter.vtkCutter_SetSortBy_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06018AB6 RID: 101046
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_SetSortByToSortByCell_39(HandleRef pThis);

		/// <summary>
		/// Set the sorting order for the generated polydata. There are two
		/// possibilities:
		/// Sort by value = 0 - This is the most efficient sort. For each cell,
		/// all contour values are processed. This is the default.
		/// Sort by cell = 1 - For each contour value, all cells are processed.
		/// This order should be used if the extracted polygons must be rendered
		/// in a back-to-front or front-to-back order. This is very problem
		/// dependent.
		/// For most applications, the default order is fine (and faster).
		///
		/// Sort by cell is going to have a problem if the input has 2D and 3D cells.
		/// Cell data will be scrambled because with
		/// vtkPolyData output, verts and lines have lower cell ids than triangles.
		/// </summary>
		// Token: 0x06018AB7 RID: 101047 RVA: 0x0022775B File Offset: 0x0022595B
		public void SetSortByToSortByCell()
		{
			vtkCutter.vtkCutter_SetSortByToSortByCell_39(base.GetCppThis());
		}

		// Token: 0x06018AB8 RID: 101048
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_SetSortByToSortByValue_40(HandleRef pThis);

		/// <summary>
		/// Set the sorting order for the generated polydata. There are two
		/// possibilities:
		/// Sort by value = 0 - This is the most efficient sort. For each cell,
		/// all contour values are processed. This is the default.
		/// Sort by cell = 1 - For each contour value, all cells are processed.
		/// This order should be used if the extracted polygons must be rendered
		/// in a back-to-front or front-to-back order. This is very problem
		/// dependent.
		/// For most applications, the default order is fine (and faster).
		///
		/// Sort by cell is going to have a problem if the input has 2D and 3D cells.
		/// Cell data will be scrambled because with
		/// vtkPolyData output, verts and lines have lower cell ids than triangles.
		/// </summary>
		// Token: 0x06018AB9 RID: 101049 RVA: 0x0022776A File Offset: 0x0022596A
		public void SetSortByToSortByValue()
		{
			vtkCutter.vtkCutter_SetSortByToSortByValue_40(base.GetCppThis());
		}

		// Token: 0x06018ABA RID: 101050
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCutter_SetValue_41(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set a particular contour value at contour number i. The index i ranges
		/// between 0&lt;=i&lt;NumberOfContours.
		/// </summary>
		// Token: 0x06018ABB RID: 101051 RVA: 0x00227779 File Offset: 0x00225979
		public void SetValue(int i, double value)
		{
			vtkCutter.vtkCutter_SetValue_41(base.GetCppThis(), i, value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B48 RID: 6984
		public new const string MRFullTypeName = "Kitware.VTK.vtkCutter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B49 RID: 6985
		public new static readonly string MRClassNameKey = "class vtkCutter";
	}
}
