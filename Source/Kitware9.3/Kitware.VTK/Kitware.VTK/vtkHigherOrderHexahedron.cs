using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHigherOrderHexahedron
	/// </summary>
	/// <remarks>
	///    A 3D cell that represents an arbitrary order HigherOrder hex
	///
	/// vtkHigherOrderHexahedron is a concrete implementation of vtkCell to represent a
	/// 3D hexahedron using HigherOrder shape functions of user specified order.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHexahedron
	/// </seealso>
	// Token: 0x02000A01 RID: 2561
	public abstract class vtkHigherOrderHexahedron : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A949 RID: 108873 RVA: 0x0024F4B4 File Offset: 0x0024D6B4
		static vtkHigherOrderHexahedron()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHigherOrderHexahedron.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHigherOrderHexahedron"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A94A RID: 108874 RVA: 0x0024F4DC File Offset: 0x0024D6DC
		public vtkHigherOrderHexahedron(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A94B RID: 108875 RVA: 0x0024F4EA File Offset: 0x0024D6EA
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A94C RID: 108876
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderHexahedron_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A94D RID: 108877 RVA: 0x0024F4F8 File Offset: 0x0024D6F8
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601A94E RID: 108878
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderHexahedron_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A94F RID: 108879 RVA: 0x0024F530 File Offset: 0x0024D730
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601A950 RID: 108880
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderHexahedron_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A951 RID: 108881 RVA: 0x0024F5EC File Offset: 0x0024D7EC
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601A952 RID: 108882
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderHexahedron_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A953 RID: 108883 RVA: 0x0024F6D4 File Offset: 0x0024D8D4
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601A954 RID: 108884
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderHexahedron_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A955 RID: 108885 RVA: 0x0024F6EA File Offset: 0x0024D8EA
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601A956 RID: 108886
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderHexahedron_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A957 RID: 108887 RVA: 0x0024F700 File Offset: 0x0024D900
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601A958 RID: 108888
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderHexahedron_GetCellDimension_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A959 RID: 108889 RVA: 0x0024F728 File Offset: 0x0024D928
		public override int GetCellDimension()
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601A95A RID: 108890
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderHexahedron_GetCellType_08(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A95B RID: 108891 RVA: 0x0024F748 File Offset: 0x0024D948
		public override int GetCellType()
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601A95C RID: 108892
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderHexahedron_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A95D RID: 108893 RVA: 0x0024F768 File Offset: 0x0024D968
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_GetEdge_09(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601A95E RID: 108894
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderHexahedron_GetEdgeCell_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A95F RID: 108895 RVA: 0x0024F7D8 File Offset: 0x0024D9D8
		public virtual vtkHigherOrderCurve GetEdgeCell()
		{
			vtkHigherOrderCurve vtkHigherOrderCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_GetEdgeCell_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderCurve = (vtkHigherOrderCurve)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderCurve.Register(null);
				}
			}
			return vtkHigherOrderCurve;
		}

		// Token: 0x0601A960 RID: 108896
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderHexahedron_GetFace_11(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A961 RID: 108897 RVA: 0x0024F848 File Offset: 0x0024DA48
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_GetFace_11(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601A962 RID: 108898
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderHexahedron_GetFaceCell_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A963 RID: 108899 RVA: 0x0024F8B8 File Offset: 0x0024DAB8
		public virtual vtkHigherOrderQuadrilateral GetFaceCell()
		{
			vtkHigherOrderQuadrilateral vtkHigherOrderQuadrilateral = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_GetFaceCell_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderQuadrilateral = (vtkHigherOrderQuadrilateral)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderQuadrilateral.Register(null);
				}
			}
			return vtkHigherOrderQuadrilateral;
		}

		// Token: 0x0601A964 RID: 108900
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderHexahedron_GetInterpolation_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A965 RID: 108901 RVA: 0x0024F928 File Offset: 0x0024DB28
		public virtual vtkHigherOrderInterpolation GetInterpolation()
		{
			vtkHigherOrderInterpolation vtkHigherOrderInterpolation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_GetInterpolation_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderInterpolation = (vtkHigherOrderInterpolation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderInterpolation.Register(null);
				}
			}
			return vtkHigherOrderInterpolation;
		}

		// Token: 0x0601A966 RID: 108902
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderHexahedron_GetNumberOfEdges_14(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A967 RID: 108903 RVA: 0x0024F998 File Offset: 0x0024DB98
		public override int GetNumberOfEdges()
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_GetNumberOfEdges_14(base.GetCppThis());
		}

		// Token: 0x0601A968 RID: 108904
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderHexahedron_GetNumberOfFaces_15(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A969 RID: 108905 RVA: 0x0024F9B8 File Offset: 0x0024DBB8
		public override int GetNumberOfFaces()
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_GetNumberOfFaces_15(base.GetCppThis());
		}

		// Token: 0x0601A96A RID: 108906
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderHexahedron_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A96B RID: 108907 RVA: 0x0024F9D8 File Offset: 0x0024DBD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0601A96C RID: 108908
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderHexahedron_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A96D RID: 108909 RVA: 0x0024F9F8 File Offset: 0x0024DBF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0601A96E RID: 108910
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderHexahedron_GetOrder_18(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A96F RID: 108911 RVA: 0x0024FA14 File Offset: 0x0024DC14
		public virtual IntPtr GetOrder()
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_GetOrder_18(base.GetCppThis());
		}

		// Token: 0x0601A970 RID: 108912
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderHexahedron_GetOrder_19(HandleRef pThis, int i);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A971 RID: 108913 RVA: 0x0024FA34 File Offset: 0x0024DC34
		public virtual int GetOrder(int i)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_GetOrder_19(base.GetCppThis(), i);
		}

		// Token: 0x0601A972 RID: 108914
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderHexahedron_GetParametricCenter_20(HandleRef pThis, IntPtr center);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A973 RID: 108915 RVA: 0x0024FA54 File Offset: 0x0024DC54
		public override int GetParametricCenter(IntPtr center)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_GetParametricCenter_20(base.GetCppThis(), center);
		}

		// Token: 0x0601A974 RID: 108916
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderHexahedron_GetParametricCoords_21(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A975 RID: 108917 RVA: 0x0024FA74 File Offset: 0x0024DC74
		public override IntPtr GetParametricCoords()
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_GetParametricCoords_21(base.GetCppThis());
		}

		// Token: 0x0601A976 RID: 108918
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHigherOrderHexahedron_GetParametricDistance_22(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A977 RID: 108919 RVA: 0x0024FA94 File Offset: 0x0024DC94
		public override double GetParametricDistance(IntPtr pcoords)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_GetParametricDistance_22(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601A978 RID: 108920
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderHexahedron_Initialize_23(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A979 RID: 108921 RVA: 0x0024FAB4 File Offset: 0x0024DCB4
		public override void Initialize()
		{
			vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_Initialize_23(base.GetCppThis());
		}

		// Token: 0x0601A97A RID: 108922
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderHexahedron_InterpolateDerivs_24(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A97B RID: 108923 RVA: 0x0024FAC3 File Offset: 0x0024DCC3
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_InterpolateDerivs_24(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601A97C RID: 108924
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderHexahedron_InterpolateFunctions_25(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A97D RID: 108925 RVA: 0x0024FAD4 File Offset: 0x0024DCD4
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_InterpolateFunctions_25(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601A97E RID: 108926
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderHexahedron_IntersectWithLine_26(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A97F RID: 108927 RVA: 0x0024FAE8 File Offset: 0x0024DCE8
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_IntersectWithLine_26(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601A980 RID: 108928
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderHexahedron_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A981 RID: 108929 RVA: 0x0024FB14 File Offset: 0x0024DD14
		public override int IsA(string type)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x0601A982 RID: 108930
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderHexahedron_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A983 RID: 108931 RVA: 0x0024FB34 File Offset: 0x0024DD34
		public new static int IsTypeOf(string type)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_IsTypeOf_28(type);
		}

		// Token: 0x0601A984 RID: 108932
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderHexahedron_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A985 RID: 108933 RVA: 0x0024FB50 File Offset: 0x0024DD50
		public new vtkHigherOrderHexahedron NewInstance()
		{
			vtkHigherOrderHexahedron result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHigherOrderHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A986 RID: 108934
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderHexahedron_NodeNumberingMappingFromVTK8To9_30(IntPtr order, long node_id_vtk8);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A987 RID: 108935 RVA: 0x0024FBAC File Offset: 0x0024DDAC
		public static long NodeNumberingMappingFromVTK8To9(IntPtr order, long node_id_vtk8)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_NodeNumberingMappingFromVTK8To9_30(order, node_id_vtk8);
		}

		// Token: 0x0601A988 RID: 108936
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderHexahedron_PointCountSupportsUniformOrder_31(long pointsPerCell);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A989 RID: 108937 RVA: 0x0024FBC8 File Offset: 0x0024DDC8
		public static bool PointCountSupportsUniformOrder(long pointsPerCell)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_PointCountSupportsUniformOrder_31(pointsPerCell) != 0;
		}

		// Token: 0x0601A98A RID: 108938
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderHexahedron_PointIndexFromIJK_32(int i, int j, int k, IntPtr order);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A98B RID: 108939 RVA: 0x0024FBEC File Offset: 0x0024DDEC
		public static int PointIndexFromIJK(int i, int j, int k, IntPtr order)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_PointIndexFromIJK_32(i, j, k, order);
		}

		// Token: 0x0601A98C RID: 108940
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderHexahedron_PointIndexFromIJK_33(HandleRef pThis, int i, int j, int k);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A98D RID: 108941 RVA: 0x0024FC0C File Offset: 0x0024DE0C
		public int PointIndexFromIJK(int i, int j, int k)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_PointIndexFromIJK_33(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0601A98E RID: 108942
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderHexahedron_RequiresInitialization_34(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A98F RID: 108943 RVA: 0x0024FC30 File Offset: 0x0024DE30
		public override int RequiresInitialization()
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_RequiresInitialization_34(base.GetCppThis());
		}

		// Token: 0x0601A990 RID: 108944
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderHexahedron_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A991 RID: 108945 RVA: 0x0024FC50 File Offset: 0x0024DE50
		public new static vtkHigherOrderHexahedron SafeDownCast(vtkObjectBase o)
		{
			vtkHigherOrderHexahedron vtkHigherOrderHexahedron = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderHexahedron = (vtkHigherOrderHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderHexahedron.Register(null);
				}
			}
			return vtkHigherOrderHexahedron;
		}

		// Token: 0x0601A992 RID: 108946
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderHexahedron_SetOrder_36(HandleRef pThis, int s, int t, int u);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A993 RID: 108947 RVA: 0x0024FCCF File Offset: 0x0024DECF
		public virtual void SetOrder(int s, int t, int u)
		{
			vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_SetOrder_36(base.GetCppThis(), s, t, u);
		}

		// Token: 0x0601A994 RID: 108948
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderHexahedron_SetOrderFromCellData_37(HandleRef pThis, HandleRef cell_data, long numPts, long cell_id);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A995 RID: 108949 RVA: 0x0024FCE4 File Offset: 0x0024DEE4
		public virtual void SetOrderFromCellData(vtkCellData cell_data, long numPts, long cell_id)
		{
			vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_SetOrderFromCellData_37(base.GetCppThis(), (cell_data == null) ? default(HandleRef) : cell_data.GetCppThis(), numPts, cell_id);
		}

		// Token: 0x0601A996 RID: 108950
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderHexahedron_SetOrderFromCellData_38(HandleRef cell_data, long numPts, long cell_id, IntPtr order);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A997 RID: 108951 RVA: 0x0024FD18 File Offset: 0x0024DF18
		public static void SetOrderFromCellData(vtkCellData cell_data, long numPts, long cell_id, IntPtr order)
		{
			vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_SetOrderFromCellData_38((cell_data == null) ? default(HandleRef) : cell_data.GetCppThis(), numPts, cell_id, order);
		}

		// Token: 0x0601A998 RID: 108952
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderHexahedron_SetParametricCoords_39(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A999 RID: 108953 RVA: 0x0024FD44 File Offset: 0x0024DF44
		public void SetParametricCoords()
		{
			vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_SetParametricCoords_39(base.GetCppThis());
		}

		// Token: 0x0601A99A RID: 108954
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderHexahedron_SetUniformOrderFromNumPoints_40(HandleRef pThis, long numPts);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A99B RID: 108955 RVA: 0x0024FD53 File Offset: 0x0024DF53
		public virtual void SetUniformOrderFromNumPoints(long numPts)
		{
			vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_SetUniformOrderFromNumPoints_40(base.GetCppThis(), numPts);
		}

		// Token: 0x0601A99C RID: 108956
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderHexahedron_SubCellCoordinatesFromId_41(HandleRef pThis, vtkVector3i ijk, int subId);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A99D RID: 108957 RVA: 0x0024FD64 File Offset: 0x0024DF64
		public bool SubCellCoordinatesFromId(vtkVector3i ijk, int subId)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_SubCellCoordinatesFromId_41(base.GetCppThis(), ijk, subId) != 0;
		}

		// Token: 0x0601A99E RID: 108958
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderHexahedron_SubCellCoordinatesFromId_42(HandleRef pThis, ref int i, ref int j, ref int k, int subId);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A99F RID: 108959 RVA: 0x0024FD8C File Offset: 0x0024DF8C
		public bool SubCellCoordinatesFromId(ref int i, ref int j, ref int k, int subId)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_SubCellCoordinatesFromId_42(base.GetCppThis(), ref i, ref j, ref k, subId) != 0;
		}

		// Token: 0x0601A9A0 RID: 108960
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderHexahedron_TransformApproxToCellParams_43(HandleRef pThis, int subCell, IntPtr pcoords);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9A1 RID: 108961 RVA: 0x0024FDB8 File Offset: 0x0024DFB8
		public bool TransformApproxToCellParams(int subCell, IntPtr pcoords)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_TransformApproxToCellParams_43(base.GetCppThis(), subCell, pcoords) != 0;
		}

		// Token: 0x0601A9A2 RID: 108962
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderHexahedron_TransformFaceToCellParams_44(HandleRef pThis, int bdyFace, IntPtr pcoords);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9A3 RID: 108963 RVA: 0x0024FDE0 File Offset: 0x0024DFE0
		public bool TransformFaceToCellParams(int bdyFace, IntPtr pcoords)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_TransformFaceToCellParams_44(base.GetCppThis(), bdyFace, pcoords) != 0;
		}

		// Token: 0x0601A9A4 RID: 108964
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderHexahedron_TriangulateLocalIds_45(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A9A5 RID: 108965 RVA: 0x0024FE08 File Offset: 0x0024E008
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkHigherOrderHexahedron.vtkHigherOrderHexahedron_TriangulateLocalIds_45(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CDA RID: 7386
		public new const string MRFullTypeName = "Kitware.VTK.vtkHigherOrderHexahedron";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CDB RID: 7387
		public new static readonly string MRClassNameKey = "class vtkHigherOrderHexahedron";
	}
}
