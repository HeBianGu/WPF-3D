using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFeatureEdges
	/// </summary>
	/// <remarks>
	///    extract interior, boundary, non-manifold, and/or
	///          sharp edges from polygonal data
	///
	/// vtkFeatureEdges is a filter to extract special types of edges from
	/// input polygonal data. These edges are either 1) boundary (used by
	/// one polygon) or a line cell; 2) non-manifold (used by three or more
	/// polygons); 3) feature edges (edges used by two triangles and whose
	/// dihedral angle &gt; FeatureAngle); or 4) manifold edges (edges used by
	/// exactly two polygons). These edges may be extracted in any
	/// combination. Edges may also be "colored" (i.e., scalar values assigned)
	/// based on edge type. The cell coloring is assigned to the cell data of
	/// the extracted edges.
	///
	/// @warning
	/// To see the coloring of the lines you may have to set the ScalarMode
	/// instance variable of the mapper to SetScalarModeToUseCellData(). (This
	/// is only a problem if there are point data scalars.)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkExtractEdges
	/// </seealso>
	// Token: 0x02000966 RID: 2406
	public class vtkFeatureEdges : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019050 RID: 102480 RVA: 0x0022E711 File Offset: 0x0022C911
		static vtkFeatureEdges()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFeatureEdges.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFeatureEdges"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019051 RID: 102481 RVA: 0x0022E739 File Offset: 0x0022C939
		public vtkFeatureEdges(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019052 RID: 102482
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFeatureEdges_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance with feature angle = 30; all types of edges
		/// (except manifold edges) are extracted and colored.
		/// </summary>
		// Token: 0x06019053 RID: 102483 RVA: 0x0022E748 File Offset: 0x0022C948
		public new static vtkFeatureEdges New()
		{
			vtkFeatureEdges result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFeatureEdges.vtkFeatureEdges_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFeatureEdges)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct an instance with feature angle = 30; all types of edges
		/// (except manifold edges) are extracted and colored.
		/// </summary>
		// Token: 0x06019054 RID: 102484 RVA: 0x0022E79C File Offset: 0x0022C99C
		public vtkFeatureEdges() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFeatureEdges.vtkFeatureEdges_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019055 RID: 102485 RVA: 0x0022E7E0 File Offset: 0x0022C9E0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019056 RID: 102486
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_BoundaryEdgesOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off the extraction of boundary edges.
		/// </summary>
		// Token: 0x06019057 RID: 102487 RVA: 0x0022E7EB File Offset: 0x0022C9EB
		public virtual void BoundaryEdgesOff()
		{
			vtkFeatureEdges.vtkFeatureEdges_BoundaryEdgesOff_01(base.GetCppThis());
		}

		// Token: 0x06019058 RID: 102488
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_BoundaryEdgesOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off the extraction of boundary edges.
		/// </summary>
		// Token: 0x06019059 RID: 102489 RVA: 0x0022E7FA File Offset: 0x0022C9FA
		public virtual void BoundaryEdgesOn()
		{
			vtkFeatureEdges.vtkFeatureEdges_BoundaryEdgesOn_02(base.GetCppThis());
		}

		// Token: 0x0601905A RID: 102490
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_ColoringOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off the coloring of edges by type.
		/// </summary>
		// Token: 0x0601905B RID: 102491 RVA: 0x0022E809 File Offset: 0x0022CA09
		public virtual void ColoringOff()
		{
			vtkFeatureEdges.vtkFeatureEdges_ColoringOff_03(base.GetCppThis());
		}

		// Token: 0x0601905C RID: 102492
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_ColoringOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off the coloring of edges by type.
		/// </summary>
		// Token: 0x0601905D RID: 102493 RVA: 0x0022E818 File Offset: 0x0022CA18
		public virtual void ColoringOn()
		{
			vtkFeatureEdges.vtkFeatureEdges_ColoringOn_04(base.GetCppThis());
		}

		// Token: 0x0601905E RID: 102494
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_CreateDefaultLocator_05(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified.
		/// </summary>
		// Token: 0x0601905F RID: 102495 RVA: 0x0022E827 File Offset: 0x0022CA27
		public void CreateDefaultLocator()
		{
			vtkFeatureEdges.vtkFeatureEdges_CreateDefaultLocator_05(base.GetCppThis());
		}

		// Token: 0x06019060 RID: 102496
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_ExtractAllEdgeTypesOff_06(HandleRef pThis);

		/// <summary>
		/// Methods for turning the extraction of all types of edges on;
		/// and turning the extraction of all types of edges off.
		/// </summary>
		// Token: 0x06019061 RID: 102497 RVA: 0x0022E836 File Offset: 0x0022CA36
		public void ExtractAllEdgeTypesOff()
		{
			vtkFeatureEdges.vtkFeatureEdges_ExtractAllEdgeTypesOff_06(base.GetCppThis());
		}

		// Token: 0x06019062 RID: 102498
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_ExtractAllEdgeTypesOn_07(HandleRef pThis);

		/// <summary>
		/// Methods for turning the extraction of all types of edges on;
		/// and turning the extraction of all types of edges off.
		/// </summary>
		// Token: 0x06019063 RID: 102499 RVA: 0x0022E845 File Offset: 0x0022CA45
		public void ExtractAllEdgeTypesOn()
		{
			vtkFeatureEdges.vtkFeatureEdges_ExtractAllEdgeTypesOn_07(base.GetCppThis());
		}

		// Token: 0x06019064 RID: 102500
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_FeatureEdgesOff_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off the extraction of feature edges.
		/// </summary>
		// Token: 0x06019065 RID: 102501 RVA: 0x0022E854 File Offset: 0x0022CA54
		public virtual void FeatureEdgesOff()
		{
			vtkFeatureEdges.vtkFeatureEdges_FeatureEdgesOff_08(base.GetCppThis());
		}

		// Token: 0x06019066 RID: 102502
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_FeatureEdgesOn_09(HandleRef pThis);

		/// <summary>
		/// Turn on/off the extraction of feature edges.
		/// </summary>
		// Token: 0x06019067 RID: 102503 RVA: 0x0022E863 File Offset: 0x0022CA63
		public virtual void FeatureEdgesOn()
		{
			vtkFeatureEdges.vtkFeatureEdges_FeatureEdgesOn_09(base.GetCppThis());
		}

		// Token: 0x06019068 RID: 102504
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFeatureEdges_GetBoundaryEdges_10(HandleRef pThis);

		/// <summary>
		/// Turn on/off the extraction of boundary edges.
		/// </summary>
		// Token: 0x06019069 RID: 102505 RVA: 0x0022E874 File Offset: 0x0022CA74
		public virtual bool GetBoundaryEdges()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetBoundaryEdges_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0601906A RID: 102506
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFeatureEdges_GetColoring_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off the coloring of edges by type.
		/// </summary>
		// Token: 0x0601906B RID: 102507 RVA: 0x0022E89C File Offset: 0x0022CA9C
		public virtual bool GetColoring()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetColoring_11(base.GetCppThis()) != 0;
		}

		// Token: 0x0601906C RID: 102508
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFeatureEdges_GetFeatureAngle_12(HandleRef pThis);

		/// <summary>
		/// Specify the feature angle for extracting feature edges.
		/// </summary>
		// Token: 0x0601906D RID: 102509 RVA: 0x0022E8C4 File Offset: 0x0022CAC4
		public virtual double GetFeatureAngle()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetFeatureAngle_12(base.GetCppThis());
		}

		// Token: 0x0601906E RID: 102510
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFeatureEdges_GetFeatureAngleMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Specify the feature angle for extracting feature edges.
		/// </summary>
		// Token: 0x0601906F RID: 102511 RVA: 0x0022E8E4 File Offset: 0x0022CAE4
		public virtual double GetFeatureAngleMaxValue()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetFeatureAngleMaxValue_13(base.GetCppThis());
		}

		// Token: 0x06019070 RID: 102512
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFeatureEdges_GetFeatureAngleMinValue_14(HandleRef pThis);

		/// <summary>
		/// Specify the feature angle for extracting feature edges.
		/// </summary>
		// Token: 0x06019071 RID: 102513 RVA: 0x0022E904 File Offset: 0x0022CB04
		public virtual double GetFeatureAngleMinValue()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetFeatureAngleMinValue_14(base.GetCppThis());
		}

		// Token: 0x06019072 RID: 102514
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFeatureEdges_GetFeatureEdges_15(HandleRef pThis);

		/// <summary>
		/// Turn on/off the extraction of feature edges.
		/// </summary>
		// Token: 0x06019073 RID: 102515 RVA: 0x0022E924 File Offset: 0x0022CB24
		public virtual bool GetFeatureEdges()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetFeatureEdges_15(base.GetCppThis()) != 0;
		}

		// Token: 0x06019074 RID: 102516
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFeatureEdges_GetLocator_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get a spatial locator for merging points. By
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06019075 RID: 102517 RVA: 0x0022E94C File Offset: 0x0022CB4C
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFeatureEdges.vtkFeatureEdges_GetLocator_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06019076 RID: 102518
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkFeatureEdges_GetMTime_17(HandleRef pThis);

		/// <summary>
		/// Return MTime also considering the locator.
		/// </summary>
		// Token: 0x06019077 RID: 102519 RVA: 0x0022E9BC File Offset: 0x0022CBBC
		public override ulong GetMTime()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetMTime_17(base.GetCppThis());
		}

		// Token: 0x06019078 RID: 102520
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFeatureEdges_GetManifoldEdges_18(HandleRef pThis);

		/// <summary>
		/// Turn on/off the extraction of manifold edges. This typically
		/// correspond to interior edges.
		/// </summary>
		// Token: 0x06019079 RID: 102521 RVA: 0x0022E9DC File Offset: 0x0022CBDC
		public virtual bool GetManifoldEdges()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetManifoldEdges_18(base.GetCppThis()) != 0;
		}

		// Token: 0x0601907A RID: 102522
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFeatureEdges_GetNonManifoldEdges_19(HandleRef pThis);

		/// <summary>
		/// Turn on/off the extraction of non-manifold edges.
		/// </summary>
		// Token: 0x0601907B RID: 102523 RVA: 0x0022EA04 File Offset: 0x0022CC04
		public virtual bool GetNonManifoldEdges()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetNonManifoldEdges_19(base.GetCppThis()) != 0;
		}

		// Token: 0x0601907C RID: 102524
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFeatureEdges_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601907D RID: 102525 RVA: 0x0022EA2C File Offset: 0x0022CC2C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x0601907E RID: 102526
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFeatureEdges_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601907F RID: 102527 RVA: 0x0022EA4C File Offset: 0x0022CC4C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x06019080 RID: 102528
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFeatureEdges_GetOutputPointsPrecision_22(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output point type. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019081 RID: 102529 RVA: 0x0022EA68 File Offset: 0x0022CC68
		public virtual int GetOutputPointsPrecision()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetOutputPointsPrecision_22(base.GetCppThis());
		}

		// Token: 0x06019082 RID: 102530
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFeatureEdges_GetPassLines_23(HandleRef pThis);

		/// <summary>
		/// Turn on/off passing input lines. If this flag is on, then all cells living inside the `Lines`
		/// cell array of the input are copied into the output.
		///
		/// @note Input poly lines are split into separate lines in the output.
		/// </summary>
		// Token: 0x06019083 RID: 102531 RVA: 0x0022EA88 File Offset: 0x0022CC88
		public virtual bool GetPassLines()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetPassLines_23(base.GetCppThis()) != 0;
		}

		// Token: 0x06019084 RID: 102532
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFeatureEdges_GetRemoveGhostInterfaces_24(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating edges at ghost interfaces. An edge is at a ghost interface
		/// if it belongs to at least one ghost cell. This is turned on by default.
		/// When turned off, only edges that solely belong to ghost cells are discarded from the output.
		/// When turned on, edges are discarded if the belong to at least one ghost cell.
		///
		/// @note In order for the interfaces between ranks to be removed, ghost cells must be first
		/// generated.
		/// @sa vtkGhostCellsGenerator
		/// </summary>
		// Token: 0x06019085 RID: 102533 RVA: 0x0022EAB0 File Offset: 0x0022CCB0
		public virtual bool GetRemoveGhostInterfaces()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetRemoveGhostInterfaces_24(base.GetCppThis()) != 0;
		}

		// Token: 0x06019086 RID: 102534
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFeatureEdges_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x06019087 RID: 102535 RVA: 0x0022EAD8 File Offset: 0x0022CCD8
		public override int IsA(string type)
		{
			return vtkFeatureEdges.vtkFeatureEdges_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x06019088 RID: 102536
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFeatureEdges_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x06019089 RID: 102537 RVA: 0x0022EAF8 File Offset: 0x0022CCF8
		public new static int IsTypeOf(string type)
		{
			return vtkFeatureEdges.vtkFeatureEdges_IsTypeOf_26(type);
		}

		// Token: 0x0601908A RID: 102538
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_ManifoldEdgesOff_27(HandleRef pThis);

		/// <summary>
		/// Turn on/off the extraction of manifold edges. This typically
		/// correspond to interior edges.
		/// </summary>
		// Token: 0x0601908B RID: 102539 RVA: 0x0022EB12 File Offset: 0x0022CD12
		public virtual void ManifoldEdgesOff()
		{
			vtkFeatureEdges.vtkFeatureEdges_ManifoldEdgesOff_27(base.GetCppThis());
		}

		// Token: 0x0601908C RID: 102540
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_ManifoldEdgesOn_28(HandleRef pThis);

		/// <summary>
		/// Turn on/off the extraction of manifold edges. This typically
		/// correspond to interior edges.
		/// </summary>
		// Token: 0x0601908D RID: 102541 RVA: 0x0022EB21 File Offset: 0x0022CD21
		public virtual void ManifoldEdgesOn()
		{
			vtkFeatureEdges.vtkFeatureEdges_ManifoldEdgesOn_28(base.GetCppThis());
		}

		// Token: 0x0601908E RID: 102542
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFeatureEdges_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601908F RID: 102543 RVA: 0x0022EB30 File Offset: 0x0022CD30
		public new vtkFeatureEdges NewInstance()
		{
			vtkFeatureEdges result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFeatureEdges.vtkFeatureEdges_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFeatureEdges)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019090 RID: 102544
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_NonManifoldEdgesOff_31(HandleRef pThis);

		/// <summary>
		/// Turn on/off the extraction of non-manifold edges.
		/// </summary>
		// Token: 0x06019091 RID: 102545 RVA: 0x0022EB8A File Offset: 0x0022CD8A
		public virtual void NonManifoldEdgesOff()
		{
			vtkFeatureEdges.vtkFeatureEdges_NonManifoldEdgesOff_31(base.GetCppThis());
		}

		// Token: 0x06019092 RID: 102546
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_NonManifoldEdgesOn_32(HandleRef pThis);

		/// <summary>
		/// Turn on/off the extraction of non-manifold edges.
		/// </summary>
		// Token: 0x06019093 RID: 102547 RVA: 0x0022EB99 File Offset: 0x0022CD99
		public virtual void NonManifoldEdgesOn()
		{
			vtkFeatureEdges.vtkFeatureEdges_NonManifoldEdgesOn_32(base.GetCppThis());
		}

		// Token: 0x06019094 RID: 102548
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_PassLinesOff_33(HandleRef pThis);

		/// <summary>
		/// Turn on/off passing input lines. If this flag is on, then all cells living inside the `Lines`
		/// cell array of the input are copied into the output.
		///
		/// @note Input poly lines are split into separate lines in the output.
		/// </summary>
		// Token: 0x06019095 RID: 102549 RVA: 0x0022EBA8 File Offset: 0x0022CDA8
		public virtual void PassLinesOff()
		{
			vtkFeatureEdges.vtkFeatureEdges_PassLinesOff_33(base.GetCppThis());
		}

		// Token: 0x06019096 RID: 102550
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_PassLinesOn_34(HandleRef pThis);

		/// <summary>
		/// Turn on/off passing input lines. If this flag is on, then all cells living inside the `Lines`
		/// cell array of the input are copied into the output.
		///
		/// @note Input poly lines are split into separate lines in the output.
		/// </summary>
		// Token: 0x06019097 RID: 102551 RVA: 0x0022EBB7 File Offset: 0x0022CDB7
		public virtual void PassLinesOn()
		{
			vtkFeatureEdges.vtkFeatureEdges_PassLinesOn_34(base.GetCppThis());
		}

		// Token: 0x06019098 RID: 102552
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_RemoveGhostInterfacesOff_35(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating edges at ghost interfaces. An edge is at a ghost interface
		/// if it belongs to at least one ghost cell. This is turned on by default.
		/// When turned off, only edges that solely belong to ghost cells are discarded from the output.
		/// When turned on, edges are discarded if the belong to at least one ghost cell.
		///
		/// @note In order for the interfaces between ranks to be removed, ghost cells must be first
		/// generated.
		/// @sa vtkGhostCellsGenerator
		/// </summary>
		// Token: 0x06019099 RID: 102553 RVA: 0x0022EBC6 File Offset: 0x0022CDC6
		public virtual void RemoveGhostInterfacesOff()
		{
			vtkFeatureEdges.vtkFeatureEdges_RemoveGhostInterfacesOff_35(base.GetCppThis());
		}

		// Token: 0x0601909A RID: 102554
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_RemoveGhostInterfacesOn_36(HandleRef pThis);

		/// <summary>
		/// Turn on/off creating edges at ghost interfaces. An edge is at a ghost interface
		/// if it belongs to at least one ghost cell. This is turned on by default.
		/// When turned off, only edges that solely belong to ghost cells are discarded from the output.
		/// When turned on, edges are discarded if the belong to at least one ghost cell.
		///
		/// @note In order for the interfaces between ranks to be removed, ghost cells must be first
		/// generated.
		/// @sa vtkGhostCellsGenerator
		/// </summary>
		// Token: 0x0601909B RID: 102555 RVA: 0x0022EBD5 File Offset: 0x0022CDD5
		public virtual void RemoveGhostInterfacesOn()
		{
			vtkFeatureEdges.vtkFeatureEdges_RemoveGhostInterfacesOn_36(base.GetCppThis());
		}

		// Token: 0x0601909C RID: 102556
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFeatureEdges_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601909D RID: 102557 RVA: 0x0022EBE4 File Offset: 0x0022CDE4
		public new static vtkFeatureEdges SafeDownCast(vtkObjectBase o)
		{
			vtkFeatureEdges vtkFeatureEdges = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFeatureEdges.vtkFeatureEdges_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFeatureEdges = (vtkFeatureEdges)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFeatureEdges.Register(null);
				}
			}
			return vtkFeatureEdges;
		}

		// Token: 0x0601909E RID: 102558
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_SetBoundaryEdges_38(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off the extraction of boundary edges.
		/// </summary>
		// Token: 0x0601909F RID: 102559 RVA: 0x0022EC63 File Offset: 0x0022CE63
		public virtual void SetBoundaryEdges(bool _arg)
		{
			vtkFeatureEdges.vtkFeatureEdges_SetBoundaryEdges_38(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060190A0 RID: 102560
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_SetColoring_39(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off the coloring of edges by type.
		/// </summary>
		// Token: 0x060190A1 RID: 102561 RVA: 0x0022EC7B File Offset: 0x0022CE7B
		public virtual void SetColoring(bool _arg)
		{
			vtkFeatureEdges.vtkFeatureEdges_SetColoring_39(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060190A2 RID: 102562
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_SetFeatureAngle_40(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the feature angle for extracting feature edges.
		/// </summary>
		// Token: 0x060190A3 RID: 102563 RVA: 0x0022EC93 File Offset: 0x0022CE93
		public virtual void SetFeatureAngle(double _arg)
		{
			vtkFeatureEdges.vtkFeatureEdges_SetFeatureAngle_40(base.GetCppThis(), _arg);
		}

		// Token: 0x060190A4 RID: 102564
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_SetFeatureEdges_41(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off the extraction of feature edges.
		/// </summary>
		// Token: 0x060190A5 RID: 102565 RVA: 0x0022ECA3 File Offset: 0x0022CEA3
		public virtual void SetFeatureEdges(bool _arg)
		{
			vtkFeatureEdges.vtkFeatureEdges_SetFeatureEdges_41(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060190A6 RID: 102566
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_SetLocator_42(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set / get a spatial locator for merging points. By
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x060190A7 RID: 102567 RVA: 0x0022ECBC File Offset: 0x0022CEBC
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkFeatureEdges.vtkFeatureEdges_SetLocator_42(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x060190A8 RID: 102568
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_SetManifoldEdges_43(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off the extraction of manifold edges. This typically
		/// correspond to interior edges.
		/// </summary>
		// Token: 0x060190A9 RID: 102569 RVA: 0x0022ECEB File Offset: 0x0022CEEB
		public virtual void SetManifoldEdges(bool _arg)
		{
			vtkFeatureEdges.vtkFeatureEdges_SetManifoldEdges_43(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060190AA RID: 102570
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_SetNonManifoldEdges_44(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off the extraction of non-manifold edges.
		/// </summary>
		// Token: 0x060190AB RID: 102571 RVA: 0x0022ED03 File Offset: 0x0022CF03
		public virtual void SetNonManifoldEdges(bool _arg)
		{
			vtkFeatureEdges.vtkFeatureEdges_SetNonManifoldEdges_44(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060190AC RID: 102572
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_SetOutputPointsPrecision_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output point type. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x060190AD RID: 102573 RVA: 0x0022ED1B File Offset: 0x0022CF1B
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkFeatureEdges.vtkFeatureEdges_SetOutputPointsPrecision_45(base.GetCppThis(), _arg);
		}

		// Token: 0x060190AE RID: 102574
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_SetPassLines_46(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off passing input lines. If this flag is on, then all cells living inside the `Lines`
		/// cell array of the input are copied into the output.
		///
		/// @note Input poly lines are split into separate lines in the output.
		/// </summary>
		// Token: 0x060190AF RID: 102575 RVA: 0x0022ED2B File Offset: 0x0022CF2B
		public virtual void SetPassLines(bool _arg)
		{
			vtkFeatureEdges.vtkFeatureEdges_SetPassLines_46(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060190B0 RID: 102576
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFeatureEdges_SetRemoveGhostInterfaces_47(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off creating edges at ghost interfaces. An edge is at a ghost interface
		/// if it belongs to at least one ghost cell. This is turned on by default.
		/// When turned off, only edges that solely belong to ghost cells are discarded from the output.
		/// When turned on, edges are discarded if the belong to at least one ghost cell.
		///
		/// @note In order for the interfaces between ranks to be removed, ghost cells must be first
		/// generated.
		/// @sa vtkGhostCellsGenerator
		/// </summary>
		// Token: 0x060190B1 RID: 102577 RVA: 0x0022ED43 File Offset: 0x0022CF43
		public virtual void SetRemoveGhostInterfaces(bool _arg)
		{
			vtkFeatureEdges.vtkFeatureEdges_SetRemoveGhostInterfaces_47(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B85 RID: 7045
		public new const string MRFullTypeName = "Kitware.VTK.vtkFeatureEdges";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B86 RID: 7046
		public new static readonly string MRClassNameKey = "class vtkFeatureEdges";
	}
}
