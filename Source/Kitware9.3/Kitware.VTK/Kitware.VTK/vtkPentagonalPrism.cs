using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPentagonalPrism
	/// </summary>
	/// <remarks>
	///    a 3D cell that represents a convex prism with
	/// pentagonal base
	///
	/// vtkPentagonalPrism is a concrete implementation of vtkCell to represent a
	/// linear convex 3D prism with pentagonal base. Such prism is defined by the
	/// ten points (0-9), where (0,1,2,3,4) is the base of the prism which, using
	/// the right hand rule, forms a pentagon whose normal points is in the direction
	/// of the opposite face (5,6,7,8,9).
	///
	/// @par Thanks:
	/// Thanks to Philippe Guerville who developed this class.
	/// Thanks to Charles Pignerol (CEA-DAM, France) who ported this class under
	/// VTK 4. &lt;br&gt;
	/// Thanks to Jean Favre (CSCS, Switzerland) who contributed to integrate this
	/// class in VTK. &lt;br&gt;
	/// Please address all comments to Jean Favre (jfavre at cscs.ch).
	///
	/// @par Thanks:
	/// The Interpolation functions and derivatives were changed in June
	/// 2015 by Bill Lorensen. These changes follow the formulation in:
	/// http://dilbert.engr.ucdavis.edu/~suku/nem/papers/polyelas.pdf
	/// NOTE: An additional copy of this paper is located at:
	/// http://www.vtk.org/Wiki/File:ApplicationOfPolygonalFiniteElementsInLinearElasticity.pdf
	/// </remarks>
	// Token: 0x02000A91 RID: 2705
	public class vtkPentagonalPrism : vtkCell3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C596 RID: 116118 RVA: 0x0027D44B File Offset: 0x0027B64B
		static vtkPentagonalPrism()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPentagonalPrism.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPentagonalPrism"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C597 RID: 116119 RVA: 0x0027D473 File Offset: 0x0027B673
		public vtkPentagonalPrism(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C598 RID: 116120
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPentagonalPrism_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C599 RID: 116121 RVA: 0x0027D484 File Offset: 0x0027B684
		public new static vtkPentagonalPrism New()
		{
			vtkPentagonalPrism result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPentagonalPrism.vtkPentagonalPrism_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPentagonalPrism)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C59A RID: 116122 RVA: 0x0027D4D8 File Offset: 0x0027B6D8
		public vtkPentagonalPrism() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPentagonalPrism.vtkPentagonalPrism_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C59B RID: 116123 RVA: 0x0027D51C File Offset: 0x0027B71C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C59C RID: 116124
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPentagonalPrism_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// See the vtkCell3D API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C59D RID: 116125 RVA: 0x0027D528 File Offset: 0x0027B728
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601C59E RID: 116126
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPentagonalPrism_ComputeCentroid_02(HandleRef points, IntPtr pointIds, IntPtr centroid);

		/// <summary>
		/// Static method version of GetCentroid.
		/// </summary>
		// Token: 0x0601C59F RID: 116127 RVA: 0x0027D560 File Offset: 0x0027B760
		public static bool ComputeCentroid(vtkPoints points, IntPtr pointIds, IntPtr centroid)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_ComputeCentroid_02((points == null) ? default(HandleRef) : points.GetCppThis(), pointIds, centroid) != 0;
		}

		// Token: 0x0601C5A0 RID: 116128
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPentagonalPrism_Derivatives_03(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// See the vtkCell3D API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C5A1 RID: 116129 RVA: 0x0027D597 File Offset: 0x0027B797
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkPentagonalPrism.vtkPentagonalPrism_Derivatives_03(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601C5A2 RID: 116130
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPentagonalPrism_EvaluateLocation_04(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// See the vtkCell3D API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C5A3 RID: 116131 RVA: 0x0027D5AD File Offset: 0x0027B7AD
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkPentagonalPrism.vtkPentagonalPrism_EvaluateLocation_04(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601C5A4 RID: 116132
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPentagonalPrism_EvaluatePosition_05(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// See the vtkCell3D API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C5A5 RID: 116133 RVA: 0x0027D5C4 File Offset: 0x0027B7C4
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_EvaluatePosition_05(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601C5A6 RID: 116134
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPentagonalPrism_GetCellDimension_06(HandleRef pThis);

		/// <summary>
		/// See the vtkCell3D API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C5A7 RID: 116135 RVA: 0x0027D5EC File Offset: 0x0027B7EC
		public override int GetCellDimension()
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_GetCellDimension_06(base.GetCppThis());
		}

		// Token: 0x0601C5A8 RID: 116136
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPentagonalPrism_GetCellType_07(HandleRef pThis);

		/// <summary>
		/// See the vtkCell3D API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C5A9 RID: 116137 RVA: 0x0027D60C File Offset: 0x0027B80C
		public override int GetCellType()
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_GetCellType_07(base.GetCppThis());
		}

		// Token: 0x0601C5AA RID: 116138
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPentagonalPrism_GetCentroid_08(HandleRef pThis, IntPtr centroid);

		/// <summary>
		/// See vtkCell3D API for description of these methods.
		/// </summary>
		// Token: 0x0601C5AB RID: 116139 RVA: 0x0027D62C File Offset: 0x0027B82C
		public override bool GetCentroid(IntPtr centroid)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_GetCentroid_08(base.GetCppThis(), centroid) != 0;
		}

		// Token: 0x0601C5AC RID: 116140
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPentagonalPrism_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell3D API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C5AD RID: 116141 RVA: 0x0027D654 File Offset: 0x0027B854
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPentagonalPrism.vtkPentagonalPrism_GetEdge_09(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C5AE RID: 116142
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPentagonalPrism_GetEdgeArray_10(long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
		/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
		/// </summary>
		// Token: 0x0601C5AF RID: 116143 RVA: 0x0027D6C4 File Offset: 0x0027B8C4
		public static IntPtr GetEdgeArray(long edgeId)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_GetEdgeArray_10(edgeId);
		}

		// Token: 0x0601C5B0 RID: 116144
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPentagonalPrism_GetEdgeToAdjacentFacesArray_11(long edgeId);

		/// <summary>
		/// Static method version of GetEdgeToAdjacentFaces.
		/// </summary>
		// Token: 0x0601C5B1 RID: 116145 RVA: 0x0027D6E0 File Offset: 0x0027B8E0
		public static IntPtr GetEdgeToAdjacentFacesArray(long edgeId)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_GetEdgeToAdjacentFacesArray_11(edgeId);
		}

		// Token: 0x0601C5B2 RID: 116146
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPentagonalPrism_GetFace_12(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// See the vtkCell3D API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C5B3 RID: 116147 RVA: 0x0027D6FC File Offset: 0x0027B8FC
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPentagonalPrism.vtkPentagonalPrism_GetFace_12(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C5B4 RID: 116148
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPentagonalPrism_GetFaceArray_13(long faceId);

		/// <summary>
		/// Return the ids of the vertices defining edge/face (`edgeId`/`faceId').
		/// Ids are related to the cell, not to the dataset.
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
		/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
		/// </summary>
		// Token: 0x0601C5B5 RID: 116149 RVA: 0x0027D76C File Offset: 0x0027B96C
		public static IntPtr GetFaceArray(long faceId)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_GetFaceArray_13(faceId);
		}

		// Token: 0x0601C5B6 RID: 116150
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPentagonalPrism_GetFaceToAdjacentFacesArray_14(long faceId);

		/// <summary>
		/// Static method version of GetFaceToAdjacentFaces.
		/// </summary>
		// Token: 0x0601C5B7 RID: 116151 RVA: 0x0027D788 File Offset: 0x0027B988
		public static IntPtr GetFaceToAdjacentFacesArray(long faceId)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_GetFaceToAdjacentFacesArray_14(faceId);
		}

		// Token: 0x0601C5B8 RID: 116152
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPentagonalPrism_GetNumberOfEdges_15(HandleRef pThis);

		/// <summary>
		/// See the vtkCell3D API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C5B9 RID: 116153 RVA: 0x0027D7A4 File Offset: 0x0027B9A4
		public override int GetNumberOfEdges()
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_GetNumberOfEdges_15(base.GetCppThis());
		}

		// Token: 0x0601C5BA RID: 116154
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPentagonalPrism_GetNumberOfFaces_16(HandleRef pThis);

		/// <summary>
		/// See the vtkCell3D API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C5BB RID: 116155 RVA: 0x0027D7C4 File Offset: 0x0027B9C4
		public override int GetNumberOfFaces()
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_GetNumberOfFaces_16(base.GetCppThis());
		}

		// Token: 0x0601C5BC RID: 116156
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPentagonalPrism_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C5BD RID: 116157 RVA: 0x0027D7E4 File Offset: 0x0027B9E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0601C5BE RID: 116158
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPentagonalPrism_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C5BF RID: 116159 RVA: 0x0027D804 File Offset: 0x0027BA04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x0601C5C0 RID: 116160
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPentagonalPrism_GetParametricCenter_19(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601C5C1 RID: 116161 RVA: 0x0027D820 File Offset: 0x0027BA20
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_GetParametricCenter_19(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601C5C2 RID: 116162
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPentagonalPrism_GetParametricCoords_20(HandleRef pThis);

		/// <summary>
		/// See the vtkCell3D API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C5C3 RID: 116163 RVA: 0x0027D840 File Offset: 0x0027BA40
		public override IntPtr GetParametricCoords()
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_GetParametricCoords_20(base.GetCppThis());
		}

		// Token: 0x0601C5C4 RID: 116164
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPentagonalPrism_GetPointToIncidentEdgesArray_21(long pointId);

		/// <summary>
		/// Static method version of GetPointToIncidentEdgesArray.
		/// </summary>
		// Token: 0x0601C5C5 RID: 116165 RVA: 0x0027D860 File Offset: 0x0027BA60
		public static IntPtr GetPointToIncidentEdgesArray(long pointId)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_GetPointToIncidentEdgesArray_21(pointId);
		}

		// Token: 0x0601C5C6 RID: 116166
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPentagonalPrism_GetPointToIncidentFacesArray_22(long pointId);

		/// <summary>
		/// Static method version of GetPointToIncidentFacesArray.
		/// </summary>
		// Token: 0x0601C5C7 RID: 116167 RVA: 0x0027D87C File Offset: 0x0027BA7C
		public static IntPtr GetPointToIncidentFacesArray(long pointId)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_GetPointToIncidentFacesArray_22(pointId);
		}

		// Token: 0x0601C5C8 RID: 116168
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPentagonalPrism_GetPointToOneRingPointsArray_23(long pointId);

		/// <summary>
		/// Static method version of GetPointToOneRingPoints.
		/// </summary>
		// Token: 0x0601C5C9 RID: 116169 RVA: 0x0027D898 File Offset: 0x0027BA98
		public static IntPtr GetPointToOneRingPointsArray(long pointId)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_GetPointToOneRingPointsArray_23(pointId);
		}

		// Token: 0x0601C5CA RID: 116170
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPentagonalPrism_InterpolateDerivs_24(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601C5CB RID: 116171 RVA: 0x0027D8B2 File Offset: 0x0027BAB2
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkPentagonalPrism.vtkPentagonalPrism_InterpolateDerivs_24(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601C5CC RID: 116172
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPentagonalPrism_InterpolateFunctions_25(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// </summary>
		// Token: 0x0601C5CD RID: 116173 RVA: 0x0027D8C3 File Offset: 0x0027BAC3
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkPentagonalPrism.vtkPentagonalPrism_InterpolateFunctions_25(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601C5CE RID: 116174
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPentagonalPrism_InterpolationDerivs_26(IntPtr pcoords, IntPtr derivs);

		/// <summary>
		/// Return the center of the wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601C5CF RID: 116175 RVA: 0x0027D8D4 File Offset: 0x0027BAD4
		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkPentagonalPrism.vtkPentagonalPrism_InterpolationDerivs_26(pcoords, derivs);
		}

		// Token: 0x0601C5D0 RID: 116176
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPentagonalPrism_InterpolationFunctions_27(IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Return the center of the wedge in parametric coordinates.
		/// </summary>
		// Token: 0x0601C5D1 RID: 116177 RVA: 0x0027D8DF File Offset: 0x0027BADF
		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkPentagonalPrism.vtkPentagonalPrism_InterpolationFunctions_27(pcoords, weights);
		}

		// Token: 0x0601C5D2 RID: 116178
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPentagonalPrism_IntersectWithLine_28(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// See the vtkCell3D API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C5D3 RID: 116179 RVA: 0x0027D8EC File Offset: 0x0027BAEC
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_IntersectWithLine_28(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601C5D4 RID: 116180
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPentagonalPrism_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C5D5 RID: 116181 RVA: 0x0027D918 File Offset: 0x0027BB18
		public override int IsA(string type)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x0601C5D6 RID: 116182
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPentagonalPrism_IsInsideOut_30(HandleRef pThis);

		/// <summary>
		/// See vtkCell3D API for description of these methods.
		/// </summary>
		// Token: 0x0601C5D7 RID: 116183 RVA: 0x0027D938 File Offset: 0x0027BB38
		public override bool IsInsideOut()
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_IsInsideOut_30(base.GetCppThis()) != 0;
		}

		// Token: 0x0601C5D8 RID: 116184
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPentagonalPrism_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C5D9 RID: 116185 RVA: 0x0027D960 File Offset: 0x0027BB60
		public new static int IsTypeOf(string type)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_IsTypeOf_31(type);
		}

		// Token: 0x0601C5DA RID: 116186
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPentagonalPrism_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C5DB RID: 116187 RVA: 0x0027D97C File Offset: 0x0027BB7C
		public new vtkPentagonalPrism NewInstance()
		{
			vtkPentagonalPrism result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPentagonalPrism.vtkPentagonalPrism_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPentagonalPrism)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C5DC RID: 116188
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPentagonalPrism_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C5DD RID: 116189 RVA: 0x0027D9D8 File Offset: 0x0027BBD8
		public new static vtkPentagonalPrism SafeDownCast(vtkObjectBase o)
		{
			vtkPentagonalPrism vtkPentagonalPrism = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPentagonalPrism.vtkPentagonalPrism_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPentagonalPrism = (vtkPentagonalPrism)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPentagonalPrism.Register(null);
				}
			}
			return vtkPentagonalPrism;
		}

		// Token: 0x0601C5DE RID: 116190
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPentagonalPrism_TriangulateLocalIds_35(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// See the vtkCell3D API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601C5DF RID: 116191 RVA: 0x0027DA58 File Offset: 0x0027BC58
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkPentagonalPrism.vtkPentagonalPrism_TriangulateLocalIds_35(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E21 RID: 7713
		public new const string MRFullTypeName = "Kitware.VTK.vtkPentagonalPrism";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E22 RID: 7714
		public new static readonly string MRClassNameKey = "class vtkPentagonalPrism";
	}
}
