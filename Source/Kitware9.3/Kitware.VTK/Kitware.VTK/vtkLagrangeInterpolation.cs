using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000A79 RID: 2681
	public class vtkLagrangeInterpolation : vtkHigherOrderInterpolation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C182 RID: 115074 RVA: 0x00276243 File Offset: 0x00274443
		static vtkLagrangeInterpolation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLagrangeInterpolation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLagrangeInterpolation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C183 RID: 115075 RVA: 0x0027626B File Offset: 0x0027446B
		public vtkLagrangeInterpolation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C184 RID: 115076
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeInterpolation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601C185 RID: 115077 RVA: 0x0027627C File Offset: 0x0027447C
		public new static vtkLagrangeInterpolation New()
		{
			vtkLagrangeInterpolation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeInterpolation.vtkLagrangeInterpolation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangeInterpolation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C186 RID: 115078 RVA: 0x002762D0 File Offset: 0x002744D0
		public vtkLagrangeInterpolation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLagrangeInterpolation.vtkLagrangeInterpolation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C187 RID: 115079 RVA: 0x00276314 File Offset: 0x00274514
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C188 RID: 115080
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeInterpolation_EvaluateShapeAndGradient_01(int order, double pcoord, IntPtr shape, IntPtr grad);

		// Token: 0x0601C189 RID: 115081 RVA: 0x0027631F File Offset: 0x0027451F
		public static void EvaluateShapeAndGradient(int order, double pcoord, IntPtr shape, IntPtr grad)
		{
			vtkLagrangeInterpolation.vtkLagrangeInterpolation_EvaluateShapeAndGradient_01(order, pcoord, shape, grad);
		}

		// Token: 0x0601C18A RID: 115082
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeInterpolation_EvaluateShapeFunctions_02(int order, double pcoord, IntPtr shape);

		// Token: 0x0601C18B RID: 115083 RVA: 0x0027632C File Offset: 0x0027452C
		public static void EvaluateShapeFunctions(int order, double pcoord, IntPtr shape)
		{
			vtkLagrangeInterpolation.vtkLagrangeInterpolation_EvaluateShapeFunctions_02(order, pcoord, shape);
		}

		// Token: 0x0601C18C RID: 115084
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangeInterpolation_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601C18D RID: 115085 RVA: 0x00276338 File Offset: 0x00274538
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLagrangeInterpolation.vtkLagrangeInterpolation_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601C18E RID: 115086
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangeInterpolation_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601C18F RID: 115087 RVA: 0x00276358 File Offset: 0x00274558
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLagrangeInterpolation.vtkLagrangeInterpolation_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601C190 RID: 115088
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeInterpolation_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601C191 RID: 115089 RVA: 0x00276374 File Offset: 0x00274574
		public override int IsA(string type)
		{
			return vtkLagrangeInterpolation.vtkLagrangeInterpolation_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601C192 RID: 115090
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeInterpolation_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601C193 RID: 115091 RVA: 0x00276394 File Offset: 0x00274594
		public new static int IsTypeOf(string type)
		{
			return vtkLagrangeInterpolation.vtkLagrangeInterpolation_IsTypeOf_06(type);
		}

		// Token: 0x0601C194 RID: 115092
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeInterpolation_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601C195 RID: 115093 RVA: 0x002763B0 File Offset: 0x002745B0
		public new vtkLagrangeInterpolation NewInstance()
		{
			vtkLagrangeInterpolation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeInterpolation.vtkLagrangeInterpolation_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangeInterpolation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C196 RID: 115094
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeInterpolation_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601C197 RID: 115095 RVA: 0x0027640C File Offset: 0x0027460C
		public new static vtkLagrangeInterpolation SafeDownCast(vtkObjectBase o)
		{
			vtkLagrangeInterpolation vtkLagrangeInterpolation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeInterpolation.vtkLagrangeInterpolation_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLagrangeInterpolation = (vtkLagrangeInterpolation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLagrangeInterpolation.Register(null);
				}
			}
			return vtkLagrangeInterpolation;
		}

		// Token: 0x0601C198 RID: 115096
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeInterpolation_Tensor1ShapeDerivatives_10(IntPtr order, IntPtr pcoords, IntPtr derivs);

		// Token: 0x0601C199 RID: 115097 RVA: 0x0027648C File Offset: 0x0027468C
		public static int Tensor1ShapeDerivatives(IntPtr order, IntPtr pcoords, IntPtr derivs)
		{
			return vtkLagrangeInterpolation.vtkLagrangeInterpolation_Tensor1ShapeDerivatives_10(order, pcoords, derivs);
		}

		// Token: 0x0601C19A RID: 115098
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeInterpolation_Tensor1ShapeFunctions_11(IntPtr order, IntPtr pcoords, IntPtr shape);

		// Token: 0x0601C19B RID: 115099 RVA: 0x002764A8 File Offset: 0x002746A8
		public static int Tensor1ShapeFunctions(IntPtr order, IntPtr pcoords, IntPtr shape)
		{
			return vtkLagrangeInterpolation.vtkLagrangeInterpolation_Tensor1ShapeFunctions_11(order, pcoords, shape);
		}

		// Token: 0x0601C19C RID: 115100
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeInterpolation_Tensor2ShapeDerivatives_12(IntPtr order, IntPtr pcoords, IntPtr derivs);

		// Token: 0x0601C19D RID: 115101 RVA: 0x002764C4 File Offset: 0x002746C4
		public static int Tensor2ShapeDerivatives(IntPtr order, IntPtr pcoords, IntPtr derivs)
		{
			return vtkLagrangeInterpolation.vtkLagrangeInterpolation_Tensor2ShapeDerivatives_12(order, pcoords, derivs);
		}

		// Token: 0x0601C19E RID: 115102
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeInterpolation_Tensor2ShapeFunctions_13(IntPtr order, IntPtr pcoords, IntPtr shape);

		// Token: 0x0601C19F RID: 115103 RVA: 0x002764E0 File Offset: 0x002746E0
		public static int Tensor2ShapeFunctions(IntPtr order, IntPtr pcoords, IntPtr shape)
		{
			return vtkLagrangeInterpolation.vtkLagrangeInterpolation_Tensor2ShapeFunctions_13(order, pcoords, shape);
		}

		// Token: 0x0601C1A0 RID: 115104
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeInterpolation_Tensor3EvaluateDerivative_14(HandleRef pThis, IntPtr order, IntPtr pcoords, HandleRef points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs);

		// Token: 0x0601C1A1 RID: 115105 RVA: 0x002764FC File Offset: 0x002746FC
		public override void Tensor3EvaluateDerivative(IntPtr order, IntPtr pcoords, vtkPoints points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs)
		{
			vtkLagrangeInterpolation.vtkLagrangeInterpolation_Tensor3EvaluateDerivative_14(base.GetCppThis(), order, pcoords, (points == null) ? default(HandleRef) : points.GetCppThis(), fieldVals, fieldDim, fieldDerivs);
		}

		// Token: 0x0601C1A2 RID: 115106
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeInterpolation_Tensor3ShapeDerivatives_15(IntPtr order, IntPtr pcoords, IntPtr derivs);

		// Token: 0x0601C1A3 RID: 115107 RVA: 0x00276534 File Offset: 0x00274734
		public static int Tensor3ShapeDerivatives(IntPtr order, IntPtr pcoords, IntPtr derivs)
		{
			return vtkLagrangeInterpolation.vtkLagrangeInterpolation_Tensor3ShapeDerivatives_15(order, pcoords, derivs);
		}

		// Token: 0x0601C1A4 RID: 115108
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeInterpolation_Tensor3ShapeFunctions_16(IntPtr order, IntPtr pcoords, IntPtr shape);

		// Token: 0x0601C1A5 RID: 115109 RVA: 0x00276550 File Offset: 0x00274750
		public static int Tensor3ShapeFunctions(IntPtr order, IntPtr pcoords, IntPtr shape)
		{
			return vtkLagrangeInterpolation.vtkLagrangeInterpolation_Tensor3ShapeFunctions_16(order, pcoords, shape);
		}

		// Token: 0x0601C1A6 RID: 115110
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeInterpolation_WedgeEvaluate_17(HandleRef pThis, IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr fieldVals, int fieldDim, IntPtr fieldAtPCoords);

		// Token: 0x0601C1A7 RID: 115111 RVA: 0x0027656C File Offset: 0x0027476C
		public override void WedgeEvaluate(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr fieldVals, int fieldDim, IntPtr fieldAtPCoords)
		{
			vtkLagrangeInterpolation.vtkLagrangeInterpolation_WedgeEvaluate_17(base.GetCppThis(), order, numberOfPoints, pcoords, fieldVals, fieldDim, fieldAtPCoords);
		}

		// Token: 0x0601C1A8 RID: 115112
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeInterpolation_WedgeEvaluateDerivative_18(HandleRef pThis, IntPtr order, IntPtr pcoords, HandleRef points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs);

		// Token: 0x0601C1A9 RID: 115113 RVA: 0x00276584 File Offset: 0x00274784
		public override void WedgeEvaluateDerivative(IntPtr order, IntPtr pcoords, vtkPoints points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs)
		{
			vtkLagrangeInterpolation.vtkLagrangeInterpolation_WedgeEvaluateDerivative_18(base.GetCppThis(), order, pcoords, (points == null) ? default(HandleRef) : points.GetCppThis(), fieldVals, fieldDim, fieldDerivs);
		}

		// Token: 0x0601C1AA RID: 115114
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeInterpolation_WedgeShapeDerivatives_19(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr derivs);

		// Token: 0x0601C1AB RID: 115115 RVA: 0x002765BB File Offset: 0x002747BB
		public static void WedgeShapeDerivatives(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr derivs)
		{
			vtkLagrangeInterpolation.vtkLagrangeInterpolation_WedgeShapeDerivatives_19(order, numberOfPoints, pcoords, derivs);
		}

		// Token: 0x0601C1AC RID: 115116
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeInterpolation_WedgeShapeFunctions_20(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr shape);

		// Token: 0x0601C1AD RID: 115117 RVA: 0x002765C8 File Offset: 0x002747C8
		public static void WedgeShapeFunctions(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr shape)
		{
			vtkLagrangeInterpolation.vtkLagrangeInterpolation_WedgeShapeFunctions_20(order, numberOfPoints, pcoords, shape);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DE9 RID: 7657
		public new const string MRFullTypeName = "Kitware.VTK.vtkLagrangeInterpolation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DEA RID: 7658
		public new static readonly string MRClassNameKey = "class vtkLagrangeInterpolation";
	}
}
