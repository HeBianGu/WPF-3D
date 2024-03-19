using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000A04 RID: 2564
	public class vtkBezierInterpolation : vtkHigherOrderInterpolation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AA01 RID: 109057 RVA: 0x0025093F File Offset: 0x0024EB3F
		static vtkBezierInterpolation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBezierInterpolation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBezierInterpolation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AA02 RID: 109058 RVA: 0x00250967 File Offset: 0x0024EB67
		public vtkBezierInterpolation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601AA03 RID: 109059
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierInterpolation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601AA04 RID: 109060 RVA: 0x00250978 File Offset: 0x0024EB78
		public new static vtkBezierInterpolation New()
		{
			vtkBezierInterpolation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierInterpolation.vtkBezierInterpolation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierInterpolation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AA05 RID: 109061 RVA: 0x002509CC File Offset: 0x0024EBCC
		public vtkBezierInterpolation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBezierInterpolation.vtkBezierInterpolation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AA06 RID: 109062 RVA: 0x00250A10 File Offset: 0x0024EC10
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AA07 RID: 109063
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierInterpolation_DeCasteljauSimplex_01(int dim, int deg, IntPtr pcoords, IntPtr weights);

		// Token: 0x0601AA08 RID: 109064 RVA: 0x00250A1B File Offset: 0x0024EC1B
		public static void DeCasteljauSimplex(int dim, int deg, IntPtr pcoords, IntPtr weights)
		{
			vtkBezierInterpolation.vtkBezierInterpolation_DeCasteljauSimplex_01(dim, deg, pcoords, weights);
		}

		// Token: 0x0601AA09 RID: 109065
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierInterpolation_DeCasteljauSimplexDeriv_02(int dim, int deg, IntPtr pcoords, IntPtr weights);

		// Token: 0x0601AA0A RID: 109066 RVA: 0x00250A28 File Offset: 0x0024EC28
		public static void DeCasteljauSimplexDeriv(int dim, int deg, IntPtr pcoords, IntPtr weights)
		{
			vtkBezierInterpolation.vtkBezierInterpolation_DeCasteljauSimplexDeriv_02(dim, deg, pcoords, weights);
		}

		// Token: 0x0601AA0B RID: 109067
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierInterpolation_EvaluateShapeAndGradient_03(int order, double pcoord, IntPtr shape, IntPtr grad);

		// Token: 0x0601AA0C RID: 109068 RVA: 0x00250A35 File Offset: 0x0024EC35
		public static void EvaluateShapeAndGradient(int order, double pcoord, IntPtr shape, IntPtr grad)
		{
			vtkBezierInterpolation.vtkBezierInterpolation_EvaluateShapeAndGradient_03(order, pcoord, shape, grad);
		}

		// Token: 0x0601AA0D RID: 109069
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierInterpolation_EvaluateShapeFunctions_04(int order, double pcoord, IntPtr shape);

		// Token: 0x0601AA0E RID: 109070 RVA: 0x00250A42 File Offset: 0x0024EC42
		public static void EvaluateShapeFunctions(int order, double pcoord, IntPtr shape)
		{
			vtkBezierInterpolation.vtkBezierInterpolation_EvaluateShapeFunctions_04(order, pcoord, shape);
		}

		// Token: 0x0601AA0F RID: 109071
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierInterpolation_FlattenSimplex_05(int dim, int deg, vtkVector3i coord);

		// Token: 0x0601AA10 RID: 109072 RVA: 0x00250A50 File Offset: 0x0024EC50
		public static int FlattenSimplex(int dim, int deg, vtkVector3i coord)
		{
			return vtkBezierInterpolation.vtkBezierInterpolation_FlattenSimplex_05(dim, deg, coord);
		}

		// Token: 0x0601AA11 RID: 109073
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBezierInterpolation_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601AA12 RID: 109074 RVA: 0x00250A6C File Offset: 0x0024EC6C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBezierInterpolation.vtkBezierInterpolation_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601AA13 RID: 109075
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBezierInterpolation_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601AA14 RID: 109076 RVA: 0x00250A8C File Offset: 0x0024EC8C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBezierInterpolation.vtkBezierInterpolation_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601AA15 RID: 109077
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierInterpolation_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601AA16 RID: 109078 RVA: 0x00250AA8 File Offset: 0x0024ECA8
		public override int IsA(string type)
		{
			return vtkBezierInterpolation.vtkBezierInterpolation_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601AA17 RID: 109079
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierInterpolation_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601AA18 RID: 109080 RVA: 0x00250AC8 File Offset: 0x0024ECC8
		public new static int IsTypeOf(string type)
		{
			return vtkBezierInterpolation.vtkBezierInterpolation_IsTypeOf_09(type);
		}

		// Token: 0x0601AA19 RID: 109081
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierInterpolation_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601AA1A RID: 109082 RVA: 0x00250AE4 File Offset: 0x0024ECE4
		public new vtkBezierInterpolation NewInstance()
		{
			vtkBezierInterpolation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierInterpolation.vtkBezierInterpolation_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierInterpolation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AA1B RID: 109083
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBezierInterpolation_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601AA1C RID: 109084 RVA: 0x00250B40 File Offset: 0x0024ED40
		public new static vtkBezierInterpolation SafeDownCast(vtkObjectBase o)
		{
			vtkBezierInterpolation vtkBezierInterpolation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBezierInterpolation.vtkBezierInterpolation_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBezierInterpolation = (vtkBezierInterpolation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBezierInterpolation.Register(null);
				}
			}
			return vtkBezierInterpolation;
		}

		// Token: 0x0601AA1D RID: 109085
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierInterpolation_Tensor1ShapeDerivatives_13(IntPtr order, IntPtr pcoords, IntPtr derivs);

		// Token: 0x0601AA1E RID: 109086 RVA: 0x00250BC0 File Offset: 0x0024EDC0
		public static int Tensor1ShapeDerivatives(IntPtr order, IntPtr pcoords, IntPtr derivs)
		{
			return vtkBezierInterpolation.vtkBezierInterpolation_Tensor1ShapeDerivatives_13(order, pcoords, derivs);
		}

		// Token: 0x0601AA1F RID: 109087
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierInterpolation_Tensor1ShapeFunctions_14(IntPtr order, IntPtr pcoords, IntPtr shape);

		// Token: 0x0601AA20 RID: 109088 RVA: 0x00250BDC File Offset: 0x0024EDDC
		public static int Tensor1ShapeFunctions(IntPtr order, IntPtr pcoords, IntPtr shape)
		{
			return vtkBezierInterpolation.vtkBezierInterpolation_Tensor1ShapeFunctions_14(order, pcoords, shape);
		}

		// Token: 0x0601AA21 RID: 109089
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierInterpolation_Tensor2ShapeDerivatives_15(IntPtr order, IntPtr pcoords, IntPtr derivs);

		// Token: 0x0601AA22 RID: 109090 RVA: 0x00250BF8 File Offset: 0x0024EDF8
		public static int Tensor2ShapeDerivatives(IntPtr order, IntPtr pcoords, IntPtr derivs)
		{
			return vtkBezierInterpolation.vtkBezierInterpolation_Tensor2ShapeDerivatives_15(order, pcoords, derivs);
		}

		// Token: 0x0601AA23 RID: 109091
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierInterpolation_Tensor2ShapeFunctions_16(IntPtr order, IntPtr pcoords, IntPtr shape);

		// Token: 0x0601AA24 RID: 109092 RVA: 0x00250C14 File Offset: 0x0024EE14
		public static int Tensor2ShapeFunctions(IntPtr order, IntPtr pcoords, IntPtr shape)
		{
			return vtkBezierInterpolation.vtkBezierInterpolation_Tensor2ShapeFunctions_16(order, pcoords, shape);
		}

		// Token: 0x0601AA25 RID: 109093
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierInterpolation_Tensor3EvaluateDerivative_17(HandleRef pThis, IntPtr order, IntPtr pcoords, HandleRef points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs);

		// Token: 0x0601AA26 RID: 109094 RVA: 0x00250C30 File Offset: 0x0024EE30
		public override void Tensor3EvaluateDerivative(IntPtr order, IntPtr pcoords, vtkPoints points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs)
		{
			vtkBezierInterpolation.vtkBezierInterpolation_Tensor3EvaluateDerivative_17(base.GetCppThis(), order, pcoords, (points == null) ? default(HandleRef) : points.GetCppThis(), fieldVals, fieldDim, fieldDerivs);
		}

		// Token: 0x0601AA27 RID: 109095
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierInterpolation_Tensor3ShapeDerivatives_18(IntPtr order, IntPtr pcoords, IntPtr derivs);

		// Token: 0x0601AA28 RID: 109096 RVA: 0x00250C68 File Offset: 0x0024EE68
		public static int Tensor3ShapeDerivatives(IntPtr order, IntPtr pcoords, IntPtr derivs)
		{
			return vtkBezierInterpolation.vtkBezierInterpolation_Tensor3ShapeDerivatives_18(order, pcoords, derivs);
		}

		// Token: 0x0601AA29 RID: 109097
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBezierInterpolation_Tensor3ShapeFunctions_19(IntPtr order, IntPtr pcoords, IntPtr shape);

		// Token: 0x0601AA2A RID: 109098 RVA: 0x00250C84 File Offset: 0x0024EE84
		public static int Tensor3ShapeFunctions(IntPtr order, IntPtr pcoords, IntPtr shape)
		{
			return vtkBezierInterpolation.vtkBezierInterpolation_Tensor3ShapeFunctions_19(order, pcoords, shape);
		}

		// Token: 0x0601AA2B RID: 109099
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkVector3i vtkBezierInterpolation_UnFlattenSimplex_20(int dim, int deg, long flat);

		// Token: 0x0601AA2C RID: 109100 RVA: 0x00250CA0 File Offset: 0x0024EEA0
		public static vtkVector3i UnFlattenSimplex(int dim, int deg, long flat)
		{
			return vtkBezierInterpolation.vtkBezierInterpolation_UnFlattenSimplex_20(dim, deg, flat);
		}

		// Token: 0x0601AA2D RID: 109101
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierInterpolation_WedgeEvaluate_21(HandleRef pThis, IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr fieldVals, int fieldDim, IntPtr fieldAtPCoords);

		// Token: 0x0601AA2E RID: 109102 RVA: 0x00250CBC File Offset: 0x0024EEBC
		public override void WedgeEvaluate(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr fieldVals, int fieldDim, IntPtr fieldAtPCoords)
		{
			vtkBezierInterpolation.vtkBezierInterpolation_WedgeEvaluate_21(base.GetCppThis(), order, numberOfPoints, pcoords, fieldVals, fieldDim, fieldAtPCoords);
		}

		// Token: 0x0601AA2F RID: 109103
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierInterpolation_WedgeEvaluateDerivative_22(HandleRef pThis, IntPtr order, IntPtr pcoords, HandleRef points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs);

		// Token: 0x0601AA30 RID: 109104 RVA: 0x00250CD4 File Offset: 0x0024EED4
		public override void WedgeEvaluateDerivative(IntPtr order, IntPtr pcoords, vtkPoints points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs)
		{
			vtkBezierInterpolation.vtkBezierInterpolation_WedgeEvaluateDerivative_22(base.GetCppThis(), order, pcoords, (points == null) ? default(HandleRef) : points.GetCppThis(), fieldVals, fieldDim, fieldDerivs);
		}

		// Token: 0x0601AA31 RID: 109105
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierInterpolation_WedgeShapeDerivatives_23(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr derivs);

		// Token: 0x0601AA32 RID: 109106 RVA: 0x00250D0B File Offset: 0x0024EF0B
		public static void WedgeShapeDerivatives(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr derivs)
		{
			vtkBezierInterpolation.vtkBezierInterpolation_WedgeShapeDerivatives_23(order, numberOfPoints, pcoords, derivs);
		}

		// Token: 0x0601AA33 RID: 109107
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBezierInterpolation_WedgeShapeFunctions_24(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr shape);

		// Token: 0x0601AA34 RID: 109108 RVA: 0x00250D18 File Offset: 0x0024EF18
		public static void WedgeShapeFunctions(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr shape)
		{
			vtkBezierInterpolation.vtkBezierInterpolation_WedgeShapeFunctions_24(order, numberOfPoints, pcoords, shape);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CE0 RID: 7392
		public new const string MRFullTypeName = "Kitware.VTK.vtkBezierInterpolation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CE1 RID: 7393
		public new static readonly string MRClassNameKey = "class vtkBezierInterpolation";
	}
}
