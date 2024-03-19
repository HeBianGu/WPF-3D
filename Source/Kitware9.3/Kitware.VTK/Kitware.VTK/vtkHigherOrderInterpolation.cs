using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
	/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
	/// </summary>
	// Token: 0x02000A03 RID: 2563
	public abstract class vtkHigherOrderInterpolation : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A9CC RID: 109004 RVA: 0x00250380 File Offset: 0x0024E580
		static vtkHigherOrderInterpolation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHigherOrderInterpolation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHigherOrderInterpolation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A9CD RID: 109005 RVA: 0x002503A8 File Offset: 0x0024E5A8
		public vtkHigherOrderInterpolation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A9CE RID: 109006 RVA: 0x002503B6 File Offset: 0x0024E5B6
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A9CF RID: 109007
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderInterpolation_GetEdgeIndicesBoundingHexFace_01(int faceId);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601A9D0 RID: 109008 RVA: 0x002503C4 File Offset: 0x0024E5C4
		public static IntPtr GetEdgeIndicesBoundingHexFace(int faceId)
		{
			return vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetEdgeIndicesBoundingHexFace_01(faceId);
		}

		// Token: 0x0601A9D1 RID: 109009
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderInterpolation_GetEdgeIndicesBoundingWedgeFace_02(int faceId);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601A9D2 RID: 109010 RVA: 0x002503E0 File Offset: 0x0024E5E0
		public static IntPtr GetEdgeIndicesBoundingWedgeFace(int faceId)
		{
			return vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetEdgeIndicesBoundingWedgeFace_02(faceId);
		}

		// Token: 0x0601A9D3 RID: 109011
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderInterpolation_GetFixedParameterOfHexFace_03(int faceId);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601A9D4 RID: 109012 RVA: 0x002503FC File Offset: 0x0024E5FC
		public static int GetFixedParameterOfHexFace(int faceId)
		{
			return vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetFixedParameterOfHexFace_03(faceId);
		}

		// Token: 0x0601A9D5 RID: 109013
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderInterpolation_GetFixedParameterOfWedgeFace_04(int faceId);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601A9D6 RID: 109014 RVA: 0x00250418 File Offset: 0x0024E618
		public static int GetFixedParameterOfWedgeFace(int faceId)
		{
			return vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetFixedParameterOfWedgeFace_04(faceId);
		}

		// Token: 0x0601A9D7 RID: 109015
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderInterpolation_GetFixedParametersOfHexEdge_05(int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601A9D8 RID: 109016 RVA: 0x00250434 File Offset: 0x0024E634
		public static vtkVector2i GetFixedParametersOfHexEdge(int edgeId)
		{
			vtkVector2i result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetFixedParametersOfHexEdge_05(edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A9D9 RID: 109017
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderInterpolation_GetFixedParametersOfWedgeEdge_06(int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601A9DA RID: 109018 RVA: 0x0025048C File Offset: 0x0024E68C
		public static vtkVector2i GetFixedParametersOfWedgeEdge(int edgeId)
		{
			vtkVector2i result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetFixedParametersOfWedgeEdge_06(edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A9DB RID: 109019
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderInterpolation_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601A9DC RID: 109020 RVA: 0x002504E4 File Offset: 0x0024E6E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601A9DD RID: 109021
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHigherOrderInterpolation_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601A9DE RID: 109022 RVA: 0x00250504 File Offset: 0x0024E704
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601A9DF RID: 109023
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderInterpolation_GetParametricHexCoordinates_09(int vertexId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601A9E0 RID: 109024 RVA: 0x00250520 File Offset: 0x0024E720
		public static vtkVector3d GetParametricHexCoordinates(int vertexId)
		{
			vtkVector3d result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetParametricHexCoordinates_09(vertexId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector3d)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A9E1 RID: 109025
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderInterpolation_GetParametricWedgeCoordinates_10(int vertexId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601A9E2 RID: 109026 RVA: 0x00250578 File Offset: 0x0024E778
		public static vtkVector3d GetParametricWedgeCoordinates(int vertexId)
		{
			vtkVector3d result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetParametricWedgeCoordinates_10(vertexId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector3d)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A9E3 RID: 109027
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderInterpolation_GetPointIndicesBoundingHexEdge_11(int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601A9E4 RID: 109028 RVA: 0x002505D0 File Offset: 0x0024E7D0
		public static vtkVector2i GetPointIndicesBoundingHexEdge(int edgeId)
		{
			vtkVector2i result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetPointIndicesBoundingHexEdge_11(edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A9E5 RID: 109029
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderInterpolation_GetPointIndicesBoundingHexFace_12(int faceId);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601A9E6 RID: 109030 RVA: 0x00250628 File Offset: 0x0024E828
		public static IntPtr GetPointIndicesBoundingHexFace(int faceId)
		{
			return vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetPointIndicesBoundingHexFace_12(faceId);
		}

		// Token: 0x0601A9E7 RID: 109031
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderInterpolation_GetPointIndicesBoundingWedgeEdge_13(int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601A9E8 RID: 109032 RVA: 0x00250644 File Offset: 0x0024E844
		public static vtkVector2i GetPointIndicesBoundingWedgeEdge(int edgeId)
		{
			vtkVector2i result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetPointIndicesBoundingWedgeEdge_13(edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A9E9 RID: 109033
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderInterpolation_GetPointIndicesBoundingWedgeFace_14(int faceId);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601A9EA RID: 109034 RVA: 0x0025069C File Offset: 0x0024E89C
		public static IntPtr GetPointIndicesBoundingWedgeFace(int faceId)
		{
			return vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetPointIndicesBoundingWedgeFace_14(faceId);
		}

		// Token: 0x0601A9EB RID: 109035
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderInterpolation_GetVaryingParameterOfHexEdge_15(int edgeId);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601A9EC RID: 109036 RVA: 0x002506B8 File Offset: 0x0024E8B8
		public static int GetVaryingParameterOfHexEdge(int edgeId)
		{
			return vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetVaryingParameterOfHexEdge_15(edgeId);
		}

		// Token: 0x0601A9ED RID: 109037
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderInterpolation_GetVaryingParameterOfWedgeEdge_16(int edgeId);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601A9EE RID: 109038 RVA: 0x002506D4 File Offset: 0x0024E8D4
		public static int GetVaryingParameterOfWedgeEdge(int edgeId)
		{
			return vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetVaryingParameterOfWedgeEdge_16(edgeId);
		}

		// Token: 0x0601A9EF RID: 109039
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderInterpolation_GetVaryingParametersOfHexFace_17(int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601A9F0 RID: 109040 RVA: 0x002506F0 File Offset: 0x0024E8F0
		public static vtkVector2i GetVaryingParametersOfHexFace(int faceId)
		{
			vtkVector2i result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetVaryingParametersOfHexFace_17(faceId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A9F1 RID: 109041
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderInterpolation_GetVaryingParametersOfWedgeFace_18(int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601A9F2 RID: 109042 RVA: 0x00250748 File Offset: 0x0024E948
		public static vtkVector2i GetVaryingParametersOfWedgeFace(int faceId)
		{
			vtkVector2i result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_GetVaryingParametersOfWedgeFace_18(faceId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A9F3 RID: 109043
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderInterpolation_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601A9F4 RID: 109044 RVA: 0x002507A0 File Offset: 0x0024E9A0
		public override int IsA(string type)
		{
			return vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x0601A9F5 RID: 109045
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHigherOrderInterpolation_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601A9F6 RID: 109046 RVA: 0x002507C0 File Offset: 0x0024E9C0
		public new static int IsTypeOf(string type)
		{
			return vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_IsTypeOf_20(type);
		}

		// Token: 0x0601A9F7 RID: 109047
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderInterpolation_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601A9F8 RID: 109048 RVA: 0x002507DC File Offset: 0x0024E9DC
		public new vtkHigherOrderInterpolation NewInstance()
		{
			vtkHigherOrderInterpolation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHigherOrderInterpolation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A9F9 RID: 109049
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHigherOrderInterpolation_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601A9FA RID: 109050 RVA: 0x00250838 File Offset: 0x0024EA38
		public new static vtkHigherOrderInterpolation SafeDownCast(vtkObjectBase o)
		{
			vtkHigherOrderInterpolation vtkHigherOrderInterpolation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A9FB RID: 109051
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderInterpolation_Tensor3EvaluateDerivative_23(HandleRef pThis, IntPtr order, IntPtr pcoords, HandleRef points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs);

		// Token: 0x0601A9FC RID: 109052 RVA: 0x002508B8 File Offset: 0x0024EAB8
		public virtual void Tensor3EvaluateDerivative(IntPtr order, IntPtr pcoords, vtkPoints points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs)
		{
			vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_Tensor3EvaluateDerivative_23(base.GetCppThis(), order, pcoords, (points == null) ? default(HandleRef) : points.GetCppThis(), fieldVals, fieldDim, fieldDerivs);
		}

		// Token: 0x0601A9FD RID: 109053
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderInterpolation_WedgeEvaluate_24(HandleRef pThis, IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr fieldVals, int fieldDim, IntPtr fieldAtPCoords);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601A9FE RID: 109054 RVA: 0x002508EF File Offset: 0x0024EAEF
		public virtual void WedgeEvaluate(IntPtr order, long numberOfPoints, IntPtr pcoords, IntPtr fieldVals, int fieldDim, IntPtr fieldAtPCoords)
		{
			vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_WedgeEvaluate_24(base.GetCppThis(), order, numberOfPoints, pcoords, fieldVals, fieldDim, fieldAtPCoords);
		}

		// Token: 0x0601A9FF RID: 109055
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHigherOrderInterpolation_WedgeEvaluateDerivative_25(HandleRef pThis, IntPtr order, IntPtr pcoords, HandleRef points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs);

		/// <summary>
		/// Compute the inverse of the Jacobian and put the values in `inverse`. Returns
		/// 1 for success and 0 for failure (i.e. couldn't invert the Jacobian).
		/// </summary>
		// Token: 0x0601AA00 RID: 109056 RVA: 0x00250908 File Offset: 0x0024EB08
		public virtual void WedgeEvaluateDerivative(IntPtr order, IntPtr pcoords, vtkPoints points, IntPtr fieldVals, int fieldDim, IntPtr fieldDerivs)
		{
			vtkHigherOrderInterpolation.vtkHigherOrderInterpolation_WedgeEvaluateDerivative_25(base.GetCppThis(), order, pcoords, (points == null) ? default(HandleRef) : points.GetCppThis(), fieldVals, fieldDim, fieldDerivs);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CDE RID: 7390
		public new const string MRFullTypeName = "Kitware.VTK.vtkHigherOrderInterpolation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CDF RID: 7391
		public new static readonly string MRClassNameKey = "class vtkHigherOrderInterpolation";
	}
}
