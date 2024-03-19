using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellValidator
	/// </summary>
	/// <remarks>
	///    validates cells in a dataset
	///
	///
	/// vtkCellValidator accepts as input a dataset and adds integral cell data
	/// to it corresponding to the "validity" of each cell. The validity field
	/// encodes a bitfield for identifying problems that prevent a cell from standard
	/// use, including:
	///
	///   WrongNumberOfPoints: filters assume that a cell has access to the
	///                        appropriate number of points that comprise it. This
	///                        assumption is often tacit, resulting in unexpected
	///                        behavior when the condition is not met. This check
	///                        simply confirms that the cell has the minimum number
	///                        of points needed to describe it.
	///
	///   IntersectingEdges: cells that incorrectly describe the order of their
	///                      points often manifest with intersecting edges or
	///                      intersecting faces. Given a tolerance, this check
	///                      ensures that two edges from a two-dimensional cell
	///                      are separated by at least the tolerance (discounting
	///                      end-to-end connections).
	///
	///   IntersectingFaces: cells that incorrectly describe the order of their
	///                      points often manifest with intersecting edges or
	///                      intersecting faces. Given a tolerance, this check
	///                      ensures that two faces from a three-dimensional cell
	///                      do not intersect.
	///
	///   NoncontiguousEdges: another symptom of incorrect point ordering within a
	///                       cell is the presence of noncontiguous edges where
	///                       contiguous edges are otherwise expected. Given a
	///                       tolerance, this check ensures that edges around the
	///                       perimeter of a two-dimensional cell are contiguous.
	///
	///   Nonconvex: many algorithms implicitly require that all input three-
	///              dimensional cells be convex. This check uses the generic
	///              convexity checkers implemented in vtkPolygon and vtkPolyhedron
	///              to test this requirement.
	///
	///   FacesAreOrientedIncorrectly: All three-dimensional cells have an implicit
	///                                expectation for the orientation of their
	///                                faces. While the convention is unfortunately
	///                                inconsistent across cell types, it is usually
	///                                required that cell faces point outward. This
	///                                check tests that the faces of a cell point in
	///                                the direction required by the cell type,
	///                                taking into account the cell types with
	///                                nonstandard orientation requirements.
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCellQuality
	/// </seealso>
	// Token: 0x0200087C RID: 2172
	public class vtkCellValidator : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016880 RID: 92288 RVA: 0x001FB360 File Offset: 0x001F9560
		static vtkCellValidator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellValidator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellValidator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016881 RID: 92289 RVA: 0x001FB388 File Offset: 0x001F9588
		public vtkCellValidator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016882 RID: 92290
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellValidator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016883 RID: 92291 RVA: 0x001FB398 File Offset: 0x001F9598
		public new static vtkCellValidator New()
		{
			vtkCellValidator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellValidator.vtkCellValidator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellValidator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016884 RID: 92292 RVA: 0x001FB3EC File Offset: 0x001F95EC
		public vtkCellValidator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellValidator.vtkCellValidator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016885 RID: 92293 RVA: 0x001FB430 File Offset: 0x001F9630
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016886 RID: 92294
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_01(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016887 RID: 92295 RVA: 0x001FB43C File Offset: 0x001F963C
		public static vtkCellValidator.State Check(vtkGenericCell arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_01((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x06016888 RID: 92296
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_02(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016889 RID: 92297 RVA: 0x001FB46C File Offset: 0x001F966C
		public static vtkCellValidator.State Check(vtkCell arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_02((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x0601688A RID: 92298
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_03(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601688B RID: 92299 RVA: 0x001FB49C File Offset: 0x001F969C
		public static vtkCellValidator.State Check(vtkEmptyCell arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_03((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x0601688C RID: 92300
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_04(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601688D RID: 92301 RVA: 0x001FB4CC File Offset: 0x001F96CC
		public static vtkCellValidator.State Check(vtkVertex arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_04((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x0601688E RID: 92302
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_05(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601688F RID: 92303 RVA: 0x001FB4FC File Offset: 0x001F96FC
		public static vtkCellValidator.State Check(vtkPolyVertex arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_05((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x06016890 RID: 92304
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_06(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016891 RID: 92305 RVA: 0x001FB52C File Offset: 0x001F972C
		public static vtkCellValidator.State Check(vtkLine arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_06((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x06016892 RID: 92306
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_07(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016893 RID: 92307 RVA: 0x001FB55C File Offset: 0x001F975C
		public static vtkCellValidator.State Check(vtkPolyLine arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_07((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x06016894 RID: 92308
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_08(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016895 RID: 92309 RVA: 0x001FB58C File Offset: 0x001F978C
		public static vtkCellValidator.State Check(vtkTriangle arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_08((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x06016896 RID: 92310
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_09(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016897 RID: 92311 RVA: 0x001FB5BC File Offset: 0x001F97BC
		public static vtkCellValidator.State Check(vtkTriangleStrip arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_09((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x06016898 RID: 92312
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_10(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016899 RID: 92313 RVA: 0x001FB5EC File Offset: 0x001F97EC
		public static vtkCellValidator.State Check(vtkPolygon arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_10((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x0601689A RID: 92314
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_11(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601689B RID: 92315 RVA: 0x001FB61C File Offset: 0x001F981C
		public static vtkCellValidator.State Check(vtkPixel arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_11((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x0601689C RID: 92316
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_12(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601689D RID: 92317 RVA: 0x001FB64C File Offset: 0x001F984C
		public static vtkCellValidator.State Check(vtkQuad arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_12((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x0601689E RID: 92318
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_13(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601689F RID: 92319 RVA: 0x001FB67C File Offset: 0x001F987C
		public static vtkCellValidator.State Check(vtkTetra arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_13((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168A0 RID: 92320
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_14(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168A1 RID: 92321 RVA: 0x001FB6AC File Offset: 0x001F98AC
		public static vtkCellValidator.State Check(vtkVoxel arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_14((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168A2 RID: 92322
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_15(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168A3 RID: 92323 RVA: 0x001FB6DC File Offset: 0x001F98DC
		public static vtkCellValidator.State Check(vtkHexahedron arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_15((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168A4 RID: 92324
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_16(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168A5 RID: 92325 RVA: 0x001FB70C File Offset: 0x001F990C
		public static vtkCellValidator.State Check(vtkWedge arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_16((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168A6 RID: 92326
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_17(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168A7 RID: 92327 RVA: 0x001FB73C File Offset: 0x001F993C
		public static vtkCellValidator.State Check(vtkPyramid arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_17((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168A8 RID: 92328
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_18(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168A9 RID: 92329 RVA: 0x001FB76C File Offset: 0x001F996C
		public static vtkCellValidator.State Check(vtkPentagonalPrism arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_18((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168AA RID: 92330
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_19(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168AB RID: 92331 RVA: 0x001FB79C File Offset: 0x001F999C
		public static vtkCellValidator.State Check(vtkHexagonalPrism arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_19((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168AC RID: 92332
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_20(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168AD RID: 92333 RVA: 0x001FB7CC File Offset: 0x001F99CC
		public static vtkCellValidator.State Check(vtkQuadraticEdge arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_20((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168AE RID: 92334
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_21(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168AF RID: 92335 RVA: 0x001FB7FC File Offset: 0x001F99FC
		public static vtkCellValidator.State Check(vtkQuadraticTriangle arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_21((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168B0 RID: 92336
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_22(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168B1 RID: 92337 RVA: 0x001FB82C File Offset: 0x001F9A2C
		public static vtkCellValidator.State Check(vtkQuadraticQuad arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_22((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168B2 RID: 92338
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_23(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168B3 RID: 92339 RVA: 0x001FB85C File Offset: 0x001F9A5C
		public static vtkCellValidator.State Check(vtkQuadraticPolygon arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_23((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168B4 RID: 92340
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_24(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168B5 RID: 92341 RVA: 0x001FB88C File Offset: 0x001F9A8C
		public static vtkCellValidator.State Check(vtkQuadraticTetra arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_24((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168B6 RID: 92342
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_25(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168B7 RID: 92343 RVA: 0x001FB8BC File Offset: 0x001F9ABC
		public static vtkCellValidator.State Check(vtkQuadraticHexahedron arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_25((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168B8 RID: 92344
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_26(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168B9 RID: 92345 RVA: 0x001FB8EC File Offset: 0x001F9AEC
		public static vtkCellValidator.State Check(vtkQuadraticWedge arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_26((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168BA RID: 92346
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_27(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168BB RID: 92347 RVA: 0x001FB91C File Offset: 0x001F9B1C
		public static vtkCellValidator.State Check(vtkQuadraticPyramid arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_27((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168BC RID: 92348
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_28(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168BD RID: 92349 RVA: 0x001FB94C File Offset: 0x001F9B4C
		public static vtkCellValidator.State Check(vtkBiQuadraticQuad arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_28((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168BE RID: 92350
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_29(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168BF RID: 92351 RVA: 0x001FB97C File Offset: 0x001F9B7C
		public static vtkCellValidator.State Check(vtkTriQuadraticHexahedron arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_29((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168C0 RID: 92352
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_30(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168C1 RID: 92353 RVA: 0x001FB9AC File Offset: 0x001F9BAC
		public static vtkCellValidator.State Check(vtkTriQuadraticPyramid arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_30((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168C2 RID: 92354
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_31(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168C3 RID: 92355 RVA: 0x001FB9DC File Offset: 0x001F9BDC
		public static vtkCellValidator.State Check(vtkQuadraticLinearQuad arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_31((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168C4 RID: 92356
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_32(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168C5 RID: 92357 RVA: 0x001FBA0C File Offset: 0x001F9C0C
		public static vtkCellValidator.State Check(vtkQuadraticLinearWedge arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_32((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168C6 RID: 92358
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_33(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168C7 RID: 92359 RVA: 0x001FBA3C File Offset: 0x001F9C3C
		public static vtkCellValidator.State Check(vtkBiQuadraticQuadraticWedge arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_33((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168C8 RID: 92360
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_34(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168C9 RID: 92361 RVA: 0x001FBA6C File Offset: 0x001F9C6C
		public static vtkCellValidator.State Check(vtkBiQuadraticQuadraticHexahedron arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_34((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168CA RID: 92362
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_35(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168CB RID: 92363 RVA: 0x001FBA9C File Offset: 0x001F9C9C
		public static vtkCellValidator.State Check(vtkBiQuadraticTriangle arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_35((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168CC RID: 92364
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_36(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168CD RID: 92365 RVA: 0x001FBACC File Offset: 0x001F9CCC
		public static vtkCellValidator.State Check(vtkCubicLine arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_36((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168CE RID: 92366
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_37(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168CF RID: 92367 RVA: 0x001FBAFC File Offset: 0x001F9CFC
		public static vtkCellValidator.State Check(vtkConvexPointSet arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_37((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168D0 RID: 92368
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_38(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168D1 RID: 92369 RVA: 0x001FBB2C File Offset: 0x001F9D2C
		public static vtkCellValidator.State Check(vtkPolyhedron arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_38((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168D2 RID: 92370
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_39(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168D3 RID: 92371 RVA: 0x001FBB5C File Offset: 0x001F9D5C
		public static vtkCellValidator.State Check(vtkLagrangeCurve arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_39((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168D4 RID: 92372
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_40(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168D5 RID: 92373 RVA: 0x001FBB8C File Offset: 0x001F9D8C
		public static vtkCellValidator.State Check(vtkLagrangeTriangle arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_40((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168D6 RID: 92374
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_41(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168D7 RID: 92375 RVA: 0x001FBBBC File Offset: 0x001F9DBC
		public static vtkCellValidator.State Check(vtkLagrangeQuadrilateral arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_41((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168D8 RID: 92376
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_42(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168D9 RID: 92377 RVA: 0x001FBBEC File Offset: 0x001F9DEC
		public static vtkCellValidator.State Check(vtkLagrangeTetra arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_42((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168DA RID: 92378
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_43(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168DB RID: 92379 RVA: 0x001FBC1C File Offset: 0x001F9E1C
		public static vtkCellValidator.State Check(vtkLagrangeHexahedron arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_43((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168DC RID: 92380
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_44(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168DD RID: 92381 RVA: 0x001FBC4C File Offset: 0x001F9E4C
		public static vtkCellValidator.State Check(vtkLagrangeWedge arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_44((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168DE RID: 92382
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_45(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168DF RID: 92383 RVA: 0x001FBC7C File Offset: 0x001F9E7C
		public static vtkCellValidator.State Check(vtkBezierCurve arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_45((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168E0 RID: 92384
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_46(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168E1 RID: 92385 RVA: 0x001FBCAC File Offset: 0x001F9EAC
		public static vtkCellValidator.State Check(vtkBezierTriangle arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_46((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168E2 RID: 92386
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_47(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168E3 RID: 92387 RVA: 0x001FBCDC File Offset: 0x001F9EDC
		public static vtkCellValidator.State Check(vtkBezierQuadrilateral arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_47((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168E4 RID: 92388
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_48(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168E5 RID: 92389 RVA: 0x001FBD0C File Offset: 0x001F9F0C
		public static vtkCellValidator.State Check(vtkBezierTetra arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_48((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168E6 RID: 92390
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_49(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168E7 RID: 92391 RVA: 0x001FBD3C File Offset: 0x001F9F3C
		public static vtkCellValidator.State Check(vtkBezierHexahedron arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_49((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168E8 RID: 92392
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCellValidator.State vtkCellValidator_Check_50(HandleRef arg0, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168E9 RID: 92393 RVA: 0x001FBD6C File Offset: 0x001F9F6C
		public static vtkCellValidator.State Check(vtkBezierWedge arg0, double tolerance)
		{
			return vtkCellValidator.vtkCellValidator_Check_50((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), tolerance);
		}

		// Token: 0x060168EA RID: 92394
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellValidator_GetNumberOfGenerationsFromBase_51(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168EB RID: 92395 RVA: 0x001FBD9C File Offset: 0x001F9F9C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellValidator.vtkCellValidator_GetNumberOfGenerationsFromBase_51(base.GetCppThis(), type);
		}

		// Token: 0x060168EC RID: 92396
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellValidator_GetNumberOfGenerationsFromBaseType_52([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168ED RID: 92397 RVA: 0x001FBDBC File Offset: 0x001F9FBC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellValidator.vtkCellValidator_GetNumberOfGenerationsFromBaseType_52(type);
		}

		// Token: 0x060168EE RID: 92398
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCellValidator_GetTolerance_53(HandleRef pThis);

		/// <summary>
		/// Set/Get the tolerance. This value is used as an epsilon for floating point
		/// equality checks throughout the cell checking process. The default value is
		/// FLT_EPSILON.
		/// </summary>
		// Token: 0x060168EF RID: 92399 RVA: 0x001FBDD8 File Offset: 0x001F9FD8
		public virtual double GetTolerance()
		{
			return vtkCellValidator.vtkCellValidator_GetTolerance_53(base.GetCppThis());
		}

		// Token: 0x060168F0 RID: 92400
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCellValidator_GetToleranceMaxValue_54(HandleRef pThis);

		/// <summary>
		/// Set/Get the tolerance. This value is used as an epsilon for floating point
		/// equality checks throughout the cell checking process. The default value is
		/// FLT_EPSILON.
		/// </summary>
		// Token: 0x060168F1 RID: 92401 RVA: 0x001FBDF8 File Offset: 0x001F9FF8
		public virtual double GetToleranceMaxValue()
		{
			return vtkCellValidator.vtkCellValidator_GetToleranceMaxValue_54(base.GetCppThis());
		}

		// Token: 0x060168F2 RID: 92402
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCellValidator_GetToleranceMinValue_55(HandleRef pThis);

		/// <summary>
		/// Set/Get the tolerance. This value is used as an epsilon for floating point
		/// equality checks throughout the cell checking process. The default value is
		/// FLT_EPSILON.
		/// </summary>
		// Token: 0x060168F3 RID: 92403 RVA: 0x001FBE18 File Offset: 0x001FA018
		public virtual double GetToleranceMinValue()
		{
			return vtkCellValidator.vtkCellValidator_GetToleranceMinValue_55(base.GetCppThis());
		}

		// Token: 0x060168F4 RID: 92404
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellValidator_IsA_56(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168F5 RID: 92405 RVA: 0x001FBE38 File Offset: 0x001FA038
		public override int IsA(string type)
		{
			return vtkCellValidator.vtkCellValidator_IsA_56(base.GetCppThis(), type);
		}

		// Token: 0x060168F6 RID: 92406
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellValidator_IsTypeOf_57([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168F7 RID: 92407 RVA: 0x001FBE58 File Offset: 0x001FA058
		public new static int IsTypeOf(string type)
		{
			return vtkCellValidator.vtkCellValidator_IsTypeOf_57(type);
		}

		// Token: 0x060168F8 RID: 92408
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellValidator_NewInstance_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168F9 RID: 92409 RVA: 0x001FBE74 File Offset: 0x001FA074
		public new vtkCellValidator NewInstance()
		{
			vtkCellValidator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellValidator.vtkCellValidator_NewInstance_59(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellValidator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060168FA RID: 92410
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellValidator_SafeDownCast_60(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060168FB RID: 92411 RVA: 0x001FBED0 File Offset: 0x001FA0D0
		public new static vtkCellValidator SafeDownCast(vtkObjectBase o)
		{
			vtkCellValidator vtkCellValidator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellValidator.vtkCellValidator_SafeDownCast_60((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellValidator = (vtkCellValidator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellValidator.Register(null);
				}
			}
			return vtkCellValidator;
		}

		// Token: 0x060168FC RID: 92412
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellValidator_SetTolerance_61(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the tolerance. This value is used as an epsilon for floating point
		/// equality checks throughout the cell checking process. The default value is
		/// FLT_EPSILON.
		/// </summary>
		// Token: 0x060168FD RID: 92413 RVA: 0x001FBF4F File Offset: 0x001FA14F
		public virtual void SetTolerance(double _arg)
		{
			vtkCellValidator.vtkCellValidator_SetTolerance_61(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001950 RID: 6480
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellValidator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001951 RID: 6481
		public new static readonly string MRClassNameKey = "class vtkCellValidator";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200087D RID: 2173
		public enum State
		{
			/// <summary>enum member</summary>
			// Token: 0x04001953 RID: 6483
			FacesAreOrientedIncorrectly = 32,
			/// <summary>enum member</summary>
			// Token: 0x04001954 RID: 6484
			IntersectingEdges = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001955 RID: 6485
			IntersectingFaces = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001956 RID: 6486
			NoncontiguousEdges = 8,
			/// <summary>enum member</summary>
			// Token: 0x04001957 RID: 6487
			Nonconvex = 16,
			/// <summary>enum member</summary>
			// Token: 0x04001958 RID: 6488
			Valid = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001959 RID: 6489
			WrongNumberOfPoints
		}
	}
}
