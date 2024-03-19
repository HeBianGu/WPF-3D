using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHexagonalPrism
	/// </summary>
	/// <remarks>
	///    a 3D cell that represents a prism with
	/// hexagonal base
	///
	/// vtkHexagonalPrism is a concrete implementation of vtkCell to represent a
	/// linear 3D prism with hexagonal base. Such prism is defined by the twelve points
	/// (0-12) where (0,1,2,3,4,5) is the base of the prism which, using the right
	/// hand rule, forms a hexagon whose normal points is in the direction of the
	/// opposite face (6,7,8,9,10,11).
	///
	/// @par Thanks:
	/// Thanks to Philippe Guerville who developed this class.
	/// Thanks to Charles Pignerol (CEA-DAM, France) who ported this class under
	/// VTK 4.
	/// Thanks to Jean Favre (CSCS, Switzerland) who contributed to integrate this
	/// class in VTK.
	/// Please address all comments to Jean Favre (jfavre at cscs.ch).
	/// </remarks>
	// Token: 0x02000A56 RID: 2646
	public class vtkHexagonalPrism : vtkCell3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B9FE RID: 113150 RVA: 0x0026AA73 File Offset: 0x00268C73
		static vtkHexagonalPrism()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHexagonalPrism.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHexagonalPrism"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B9FF RID: 113151 RVA: 0x0026AA9B File Offset: 0x00268C9B
		public vtkHexagonalPrism(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BA00 RID: 113152
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexagonalPrism_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA01 RID: 113153 RVA: 0x0026AAAC File Offset: 0x00268CAC
		public new static vtkHexagonalPrism New()
		{
			vtkHexagonalPrism result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHexagonalPrism.vtkHexagonalPrism_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHexagonalPrism)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA02 RID: 113154 RVA: 0x0026AB00 File Offset: 0x00268D00
		public vtkHexagonalPrism() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHexagonalPrism.vtkHexagonalPrism_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BA03 RID: 113155 RVA: 0x0026AB44 File Offset: 0x00268D44
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BA04 RID: 113156
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexagonalPrism_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA05 RID: 113157 RVA: 0x0026AB50 File Offset: 0x00268D50
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601BA06 RID: 113158
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHexagonalPrism_ComputeCentroid_02(HandleRef points, IntPtr pointIds, IntPtr centroid);

		/// <summary>
		/// Static method version of GetCentroid.
		/// </summary>
		// Token: 0x0601BA07 RID: 113159 RVA: 0x0026AB88 File Offset: 0x00268D88
		public static bool ComputeCentroid(vtkPoints points, IntPtr pointIds, IntPtr centroid)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_ComputeCentroid_02((points == null) ? default(HandleRef) : points.GetCppThis(), pointIds, centroid) != 0;
		}

		// Token: 0x0601BA08 RID: 113160
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHexagonalPrism_Derivatives_03(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA09 RID: 113161 RVA: 0x0026ABBF File Offset: 0x00268DBF
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkHexagonalPrism.vtkHexagonalPrism_Derivatives_03(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601BA0A RID: 113162
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHexagonalPrism_EvaluateLocation_04(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA0B RID: 113163 RVA: 0x0026ABD5 File Offset: 0x00268DD5
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkHexagonalPrism.vtkHexagonalPrism_EvaluateLocation_04(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601BA0C RID: 113164
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexagonalPrism_EvaluatePosition_05(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA0D RID: 113165 RVA: 0x0026ABEC File Offset: 0x00268DEC
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_EvaluatePosition_05(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601BA0E RID: 113166
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexagonalPrism_GetCellDimension_06(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA0F RID: 113167 RVA: 0x0026AC14 File Offset: 0x00268E14
		public override int GetCellDimension()
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetCellDimension_06(base.GetCppThis());
		}

		// Token: 0x0601BA10 RID: 113168
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexagonalPrism_GetCellType_07(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA11 RID: 113169 RVA: 0x0026AC34 File Offset: 0x00268E34
		public override int GetCellType()
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetCellType_07(base.GetCppThis());
		}

		// Token: 0x0601BA12 RID: 113170
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHexagonalPrism_GetCentroid_08(HandleRef pThis, IntPtr centroid);

		/// <summary>
		/// See vtkCell3D API for description of these methods.
		/// </summary>
		// Token: 0x0601BA13 RID: 113171 RVA: 0x0026AC54 File Offset: 0x00268E54
		public override bool GetCentroid(IntPtr centroid)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetCentroid_08(base.GetCppThis(), centroid) != 0;
		}

		// Token: 0x0601BA14 RID: 113172
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexagonalPrism_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA15 RID: 113173 RVA: 0x0026AC7C File Offset: 0x00268E7C
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHexagonalPrism.vtkHexagonalPrism_GetEdge_09(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601BA16 RID: 113174
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexagonalPrism_GetEdgeArray_10(long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
		/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
		/// </summary>
		// Token: 0x0601BA17 RID: 113175 RVA: 0x0026ACEC File Offset: 0x00268EEC
		public static IntPtr GetEdgeArray(long edgeId)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetEdgeArray_10(edgeId);
		}

		// Token: 0x0601BA18 RID: 113176
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexagonalPrism_GetEdgeToAdjacentFacesArray_11(long edgeId);

		/// <summary>
		/// Static method version of GetEdgeToAdjacentFaces.
		/// </summary>
		// Token: 0x0601BA19 RID: 113177 RVA: 0x0026AD08 File Offset: 0x00268F08
		public static IntPtr GetEdgeToAdjacentFacesArray(long edgeId)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetEdgeToAdjacentFacesArray_11(edgeId);
		}

		// Token: 0x0601BA1A RID: 113178
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexagonalPrism_GetFace_12(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA1B RID: 113179 RVA: 0x0026AD24 File Offset: 0x00268F24
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHexagonalPrism.vtkHexagonalPrism_GetFace_12(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601BA1C RID: 113180
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexagonalPrism_GetFaceArray_13(long faceId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
		/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
		/// </summary>
		// Token: 0x0601BA1D RID: 113181 RVA: 0x0026AD94 File Offset: 0x00268F94
		public static IntPtr GetFaceArray(long faceId)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetFaceArray_13(faceId);
		}

		// Token: 0x0601BA1E RID: 113182
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexagonalPrism_GetFaceToAdjacentFacesArray_14(long faceId);

		/// <summary>
		/// Static method version of GetFaceToAdjacentFaces.
		/// </summary>
		// Token: 0x0601BA1F RID: 113183 RVA: 0x0026ADB0 File Offset: 0x00268FB0
		public static IntPtr GetFaceToAdjacentFacesArray(long faceId)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetFaceToAdjacentFacesArray_14(faceId);
		}

		// Token: 0x0601BA20 RID: 113184
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexagonalPrism_GetNumberOfEdges_15(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA21 RID: 113185 RVA: 0x0026ADCC File Offset: 0x00268FCC
		public override int GetNumberOfEdges()
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetNumberOfEdges_15(base.GetCppThis());
		}

		// Token: 0x0601BA22 RID: 113186
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexagonalPrism_GetNumberOfFaces_16(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA23 RID: 113187 RVA: 0x0026ADEC File Offset: 0x00268FEC
		public override int GetNumberOfFaces()
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetNumberOfFaces_16(base.GetCppThis());
		}

		// Token: 0x0601BA24 RID: 113188
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHexagonalPrism_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA25 RID: 113189 RVA: 0x0026AE0C File Offset: 0x0026900C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0601BA26 RID: 113190
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHexagonalPrism_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA27 RID: 113191 RVA: 0x0026AE2C File Offset: 0x0026902C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x0601BA28 RID: 113192
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexagonalPrism_GetParametricCenter_19(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601BA29 RID: 113193 RVA: 0x0026AE48 File Offset: 0x00269048
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetParametricCenter_19(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601BA2A RID: 113194
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexagonalPrism_GetParametricCoords_20(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA2B RID: 113195 RVA: 0x0026AE68 File Offset: 0x00269068
		public override IntPtr GetParametricCoords()
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetParametricCoords_20(base.GetCppThis());
		}

		// Token: 0x0601BA2C RID: 113196
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexagonalPrism_GetPointToIncidentEdgesArray_21(long pointId);

		/// <summary>
		/// Static method version of GetPointToIncidentEdgesArray.
		/// </summary>
		// Token: 0x0601BA2D RID: 113197 RVA: 0x0026AE88 File Offset: 0x00269088
		public static IntPtr GetPointToIncidentEdgesArray(long pointId)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetPointToIncidentEdgesArray_21(pointId);
		}

		// Token: 0x0601BA2E RID: 113198
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexagonalPrism_GetPointToIncidentFacesArray_22(long pointId);

		/// <summary>
		/// Static method version of GetPointToIncidentFacesArray.
		/// </summary>
		// Token: 0x0601BA2F RID: 113199 RVA: 0x0026AEA4 File Offset: 0x002690A4
		public static IntPtr GetPointToIncidentFacesArray(long pointId)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetPointToIncidentFacesArray_22(pointId);
		}

		// Token: 0x0601BA30 RID: 113200
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexagonalPrism_GetPointToOneRingPointsArray_23(long pointId);

		/// <summary>
		/// Static method version of GetPointToOneRingPoints.
		/// </summary>
		// Token: 0x0601BA31 RID: 113201 RVA: 0x0026AEC0 File Offset: 0x002690C0
		public static IntPtr GetPointToOneRingPointsArray(long pointId)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetPointToOneRingPointsArray_23(pointId);
		}

		// Token: 0x0601BA32 RID: 113202
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHexagonalPrism_InterpolateDerivs_24(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601BA33 RID: 113203 RVA: 0x0026AEDA File Offset: 0x002690DA
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkHexagonalPrism.vtkHexagonalPrism_InterpolateDerivs_24(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601BA34 RID: 113204
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHexagonalPrism_InterpolateFunctions_25(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601BA35 RID: 113205 RVA: 0x0026AEEB File Offset: 0x002690EB
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkHexagonalPrism.vtkHexagonalPrism_InterpolateFunctions_25(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601BA36 RID: 113206
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHexagonalPrism_InterpolationDerivs_26(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Return the center of the wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601BA37 RID: 113207 RVA: 0x0026AEFC File Offset: 0x002690FC
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkHexagonalPrism.vtkHexagonalPrism_InterpolationDerivs_26(pcoords, derivs);
		}

		// Token: 0x0601BA38 RID: 113208
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHexagonalPrism_InterpolationFunctions_27(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Return the center of the wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601BA39 RID: 113209 RVA: 0x0026AF07 File Offset: 0x00269107
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkHexagonalPrism.vtkHexagonalPrism_InterpolationFunctions_27(pcoords, weights);
		}

		// Token: 0x0601BA3A RID: 113210
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexagonalPrism_IntersectWithLine_28(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA3B RID: 113211 RVA: 0x0026AF14 File Offset: 0x00269114
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_IntersectWithLine_28(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601BA3C RID: 113212
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexagonalPrism_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA3D RID: 113213 RVA: 0x0026AF40 File Offset: 0x00269140
		public override int IsA(string type)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x0601BA3E RID: 113214
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHexagonalPrism_IsInsideOut_30(HandleRef pThis);

		/// <summary>
		/// See vtkCell3D API for description of these methods.
		/// </summary>
		// Token: 0x0601BA3F RID: 113215 RVA: 0x0026AF60 File Offset: 0x00269160
		public override bool IsInsideOut()
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_IsInsideOut_30(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BA40 RID: 113216
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexagonalPrism_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA41 RID: 113217 RVA: 0x0026AF88 File Offset: 0x00269188
		public new static int IsTypeOf(string type)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_IsTypeOf_31(type);
		}

		// Token: 0x0601BA42 RID: 113218
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexagonalPrism_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA43 RID: 113219 RVA: 0x0026AFA4 File Offset: 0x002691A4
		public new vtkHexagonalPrism NewInstance()
		{
			vtkHexagonalPrism result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHexagonalPrism.vtkHexagonalPrism_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHexagonalPrism)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BA44 RID: 113220
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHexagonalPrism_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BA45 RID: 113221 RVA: 0x0026B000 File Offset: 0x00269200
		public new static vtkHexagonalPrism SafeDownCast(vtkObjectBase o)
		{
			vtkHexagonalPrism vtkHexagonalPrism = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHexagonalPrism.vtkHexagonalPrism_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHexagonalPrism = (vtkHexagonalPrism)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHexagonalPrism.Register(null);
				}
			}
			return vtkHexagonalPrism;
		}

		// Token: 0x0601BA46 RID: 113222
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHexagonalPrism_TriangulateLocalIds_35(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601BA47 RID: 113223 RVA: 0x0026B080 File Offset: 0x00269280
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_TriangulateLocalIds_35(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DA0 RID: 7584
		public new const string MRFullTypeName = "Kitware.VTK.vtkHexagonalPrism";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DA1 RID: 7585
		public new static readonly string MRClassNameKey = "class vtkHexagonalPrism";
	}
}
