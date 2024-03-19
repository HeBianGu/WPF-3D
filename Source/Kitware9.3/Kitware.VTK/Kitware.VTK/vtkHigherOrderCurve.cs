using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x020009FF RID: 2559
	public abstract class vtkHigherOrderCurve : vtkNonLinearCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A8E4 RID: 108772 RVA: 0x0024EA54 File Offset: 0x0024CC54
		static vtkHigherOrderCurve()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHigherOrderCurve.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHigherOrderCurve"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A8E5 RID: 108773 RVA: 0x0024EA7C File Offset: 0x0024CC7C
		public vtkHigherOrderCurve(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A8E6 RID: 108774 RVA: 0x0024EA8A File Offset: 0x0024CC8A
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A8E7 RID: 108775
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderCurve_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		// Token: 0x0601A8E8 RID: 108776 RVA: 0x0024EA98 File Offset: 0x0024CC98
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601A8E9 RID: 108777
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderCurve_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		// Token: 0x0601A8EA RID: 108778 RVA: 0x0024EAD0 File Offset: 0x0024CCD0
		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkHigherOrderCurve.vtkHigherOrderCurve_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601A8EB RID: 108779
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderCurve_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		// Token: 0x0601A8EC RID: 108780 RVA: 0x0024EB8C File Offset: 0x0024CD8C
		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkHigherOrderCurve.vtkHigherOrderCurve_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601A8ED RID: 108781
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderCurve_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		// Token: 0x0601A8EE RID: 108782 RVA: 0x0024EC74 File Offset: 0x0024CE74
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkHigherOrderCurve.vtkHigherOrderCurve_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601A8EF RID: 108783
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderCurve_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		// Token: 0x0601A8F0 RID: 108784 RVA: 0x0024EC8A File Offset: 0x0024CE8A
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkHigherOrderCurve.vtkHigherOrderCurve_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601A8F1 RID: 108785
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderCurve_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		// Token: 0x0601A8F2 RID: 108786 RVA: 0x0024ECA0 File Offset: 0x0024CEA0
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601A8F3 RID: 108787
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderCurve_GetCellDimension_07(HandleRef pThis);

		// Token: 0x0601A8F4 RID: 108788 RVA: 0x0024ECC8 File Offset: 0x0024CEC8
		public override int GetCellDimension()
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_GetCellDimension_07(base.GetCppThis());
		}

		// Token: 0x0601A8F5 RID: 108789
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderCurve_GetCellType_08(HandleRef pThis);

		// Token: 0x0601A8F6 RID: 108790 RVA: 0x0024ECE8 File Offset: 0x0024CEE8
		public override int GetCellType()
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x0601A8F7 RID: 108791
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderCurve_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601A8F8 RID: 108792 RVA: 0x0024ED08 File Offset: 0x0024CF08
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderCurve.vtkHigherOrderCurve_GetEdge_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A8F9 RID: 108793
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderCurve_GetFace_10(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601A8FA RID: 108794 RVA: 0x0024ED78 File Offset: 0x0024CF78
		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderCurve.vtkHigherOrderCurve_GetFace_10(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A8FB RID: 108795
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderCurve_GetNumberOfEdges_11(HandleRef pThis);

		// Token: 0x0601A8FC RID: 108796 RVA: 0x0024EDE8 File Offset: 0x0024CFE8
		public override int GetNumberOfEdges()
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_GetNumberOfEdges_11(base.GetCppThis());
		}

		// Token: 0x0601A8FD RID: 108797
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderCurve_GetNumberOfFaces_12(HandleRef pThis);

		// Token: 0x0601A8FE RID: 108798 RVA: 0x0024EE08 File Offset: 0x0024D008
		public override int GetNumberOfFaces()
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_GetNumberOfFaces_12(base.GetCppThis());
		}

		// Token: 0x0601A8FF RID: 108799
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderCurve_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601A900 RID: 108800 RVA: 0x0024EE28 File Offset: 0x0024D028
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601A901 RID: 108801
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderCurve_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601A902 RID: 108802 RVA: 0x0024EE48 File Offset: 0x0024D048
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601A903 RID: 108803
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderCurve_GetOrder_15(HandleRef pThis);

		// Token: 0x0601A904 RID: 108804 RVA: 0x0024EE64 File Offset: 0x0024D064
		public IntPtr GetOrder()
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_GetOrder_15(base.GetCppThis());
		}

		// Token: 0x0601A905 RID: 108805
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderCurve_GetOrder_16(HandleRef pThis, int i);

		// Token: 0x0601A906 RID: 108806 RVA: 0x0024EE84 File Offset: 0x0024D084
		public int GetOrder(int i)
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_GetOrder_16(base.GetCppThis(), i);
		}

		// Token: 0x0601A907 RID: 108807
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderCurve_GetParametricCenter_17(HandleRef pThis, IntPtr center);

		// Token: 0x0601A908 RID: 108808 RVA: 0x0024EEA4 File Offset: 0x0024D0A4
		public override int GetParametricCenter(IntPtr center)
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_GetParametricCenter_17(base.GetCppThis(), center);
		}

		// Token: 0x0601A909 RID: 108809
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderCurve_GetParametricCoords_18(HandleRef pThis);

		// Token: 0x0601A90A RID: 108810 RVA: 0x0024EEC4 File Offset: 0x0024D0C4
		public override IntPtr GetParametricCoords()
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_GetParametricCoords_18(base.GetCppThis());
		}

		// Token: 0x0601A90B RID: 108811
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHigherOrderCurve_GetParametricDistance_19(HandleRef pThis, IntPtr pcoords);

		// Token: 0x0601A90C RID: 108812 RVA: 0x0024EEE4 File Offset: 0x0024D0E4
		public override double GetParametricDistance(IntPtr pcoords)
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_GetParametricDistance_19(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601A90D RID: 108813
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderCurve_Initialize_20(HandleRef pThis);

		// Token: 0x0601A90E RID: 108814 RVA: 0x0024EF04 File Offset: 0x0024D104
		public override void Initialize()
		{
			vtkHigherOrderCurve.vtkHigherOrderCurve_Initialize_20(base.GetCppThis());
		}

		// Token: 0x0601A90F RID: 108815
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderCurve_InterpolateDerivs_21(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		// Token: 0x0601A910 RID: 108816 RVA: 0x0024EF13 File Offset: 0x0024D113
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkHigherOrderCurve.vtkHigherOrderCurve_InterpolateDerivs_21(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601A911 RID: 108817
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderCurve_InterpolateFunctions_22(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		// Token: 0x0601A912 RID: 108818 RVA: 0x0024EF24 File Offset: 0x0024D124
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkHigherOrderCurve.vtkHigherOrderCurve_InterpolateFunctions_22(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601A913 RID: 108819
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderCurve_IntersectWithLine_23(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		// Token: 0x0601A914 RID: 108820 RVA: 0x0024EF38 File Offset: 0x0024D138
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_IntersectWithLine_23(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601A915 RID: 108821
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderCurve_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601A916 RID: 108822 RVA: 0x0024EF64 File Offset: 0x0024D164
		public override int IsA(string type)
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0601A917 RID: 108823
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderCurve_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601A918 RID: 108824 RVA: 0x0024EF84 File Offset: 0x0024D184
		public new static int IsTypeOf(string type)
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_IsTypeOf_25(type);
		}

		// Token: 0x0601A919 RID: 108825
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderCurve_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601A91A RID: 108826 RVA: 0x0024EFA0 File Offset: 0x0024D1A0
		public new vtkHigherOrderCurve NewInstance()
		{
			vtkHigherOrderCurve result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderCurve.vtkHigherOrderCurve_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHigherOrderCurve)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A91B RID: 108827
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderCurve_PointCountSupportsUniformOrder_27(long pointsPerCell);

		// Token: 0x0601A91C RID: 108828 RVA: 0x0024EFFC File Offset: 0x0024D1FC
		public static bool PointCountSupportsUniformOrder(long pointsPerCell)
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_PointCountSupportsUniformOrder_27(pointsPerCell) != 0;
		}

		// Token: 0x0601A91D RID: 108829
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderCurve_PointIndexFromIJK_28(HandleRef pThis, int i, int arg1, int arg2);

		// Token: 0x0601A91E RID: 108830 RVA: 0x0024F020 File Offset: 0x0024D220
		public int PointIndexFromIJK(int i, int arg1, int arg2)
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_PointIndexFromIJK_28(base.GetCppThis(), i, arg1, arg2);
		}

		// Token: 0x0601A91F RID: 108831
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderCurve_RequiresInitialization_29(HandleRef pThis);

		// Token: 0x0601A920 RID: 108832 RVA: 0x0024F044 File Offset: 0x0024D244
		public override int RequiresInitialization()
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_RequiresInitialization_29(base.GetCppThis());
		}

		// Token: 0x0601A921 RID: 108833
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderCurve_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601A922 RID: 108834 RVA: 0x0024F064 File Offset: 0x0024D264
		public new static vtkHigherOrderCurve SafeDownCast(vtkObjectBase o)
		{
			vtkHigherOrderCurve vtkHigherOrderCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderCurve.vtkHigherOrderCurve_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A923 RID: 108835
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderCurve_SetParametricCoords_31(HandleRef pThis);

		// Token: 0x0601A924 RID: 108836 RVA: 0x0024F0E3 File Offset: 0x0024D2E3
		public void SetParametricCoords()
		{
			vtkHigherOrderCurve.vtkHigherOrderCurve_SetParametricCoords_31(base.GetCppThis());
		}

		// Token: 0x0601A925 RID: 108837
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderCurve_SubCellCoordinatesFromId_32(HandleRef pThis, vtkVector3i ijk, int subId);

		// Token: 0x0601A926 RID: 108838 RVA: 0x0024F0F4 File Offset: 0x0024D2F4
		public bool SubCellCoordinatesFromId(vtkVector3i ijk, int subId)
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_SubCellCoordinatesFromId_32(base.GetCppThis(), ijk, subId) != 0;
		}

		// Token: 0x0601A927 RID: 108839
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderCurve_SubCellCoordinatesFromId_33(HandleRef pThis, ref int i, int subId);

		// Token: 0x0601A928 RID: 108840 RVA: 0x0024F11C File Offset: 0x0024D31C
		public bool SubCellCoordinatesFromId(ref int i, int subId)
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_SubCellCoordinatesFromId_33(base.GetCppThis(), ref i, subId) != 0;
		}

		// Token: 0x0601A929 RID: 108841
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHigherOrderCurve_TransformApproxToCellParams_34(HandleRef pThis, int subCell, IntPtr pcoords);

		// Token: 0x0601A92A RID: 108842 RVA: 0x0024F144 File Offset: 0x0024D344
		public bool TransformApproxToCellParams(int subCell, IntPtr pcoords)
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_TransformApproxToCellParams_34(base.GetCppThis(), subCell, pcoords) != 0;
		}

		// Token: 0x0601A92B RID: 108843
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderCurve_TriangulateLocalIds_35(HandleRef pThis, int index, HandleRef ptIds);

		// Token: 0x0601A92C RID: 108844 RVA: 0x0024F16C File Offset: 0x0024D36C
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkHigherOrderCurve.vtkHigherOrderCurve_TriangulateLocalIds_35(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CD6 RID: 7382
		public new const string MRFullTypeName = "Kitware.VTK.vtkHigherOrderCurve";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CD7 RID: 7383
		public new static readonly string MRClassNameKey = "class vtkHigherOrderCurve";
	}
}
