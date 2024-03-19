using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLagrangeHexahedron
	/// </summary>
	/// <remarks>
	///    A 3D cell that represents an arbitrary order Lagrange hex
	///
	/// vtkLagrangeHexahedron is a concrete implementation of vtkCell to represent a
	/// 3D hexahedron using Lagrange shape functions of user specified order.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHexahedron
	/// </seealso>
	// Token: 0x02000A78 RID: 2680
	public class vtkLagrangeHexahedron : vtkHigherOrderHexahedron
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C160 RID: 115040 RVA: 0x00275DA3 File Offset: 0x00273FA3
		static vtkLagrangeHexahedron()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLagrangeHexahedron.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLagrangeHexahedron"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C161 RID: 115041 RVA: 0x00275DCB File Offset: 0x00273FCB
		public vtkLagrangeHexahedron(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C162 RID: 115042
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeHexahedron_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C163 RID: 115043 RVA: 0x00275DDC File Offset: 0x00273FDC
		public new static vtkLagrangeHexahedron New()
		{
			vtkLagrangeHexahedron result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeHexahedron.vtkLagrangeHexahedron_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangeHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C164 RID: 115044 RVA: 0x00275E30 File Offset: 0x00274030
		public vtkLagrangeHexahedron() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLagrangeHexahedron.vtkLagrangeHexahedron_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C165 RID: 115045 RVA: 0x00275E74 File Offset: 0x00274074
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C166 RID: 115046
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeHexahedron_GetCellType_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C167 RID: 115047 RVA: 0x00275E80 File Offset: 0x00274080
		public override int GetCellType()
		{
			return vtkLagrangeHexahedron.vtkLagrangeHexahedron_GetCellType_01(base.GetCppThis());
		}

		// Token: 0x0601C168 RID: 115048
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeHexahedron_GetEdge_02(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C169 RID: 115049 RVA: 0x00275EA0 File Offset: 0x002740A0
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeHexahedron.vtkLagrangeHexahedron_GetEdge_02(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C16A RID: 115050
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeHexahedron_GetEdgeCell_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C16B RID: 115051 RVA: 0x00275F10 File Offset: 0x00274110
		public override vtkHigherOrderCurve GetEdgeCell()
		{
			vtkHigherOrderCurve vtkHigherOrderCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeHexahedron.vtkLagrangeHexahedron_GetEdgeCell_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C16C RID: 115052
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeHexahedron_GetFace_04(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C16D RID: 115053 RVA: 0x00275F80 File Offset: 0x00274180
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeHexahedron.vtkLagrangeHexahedron_GetFace_04(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C16E RID: 115054
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeHexahedron_GetFaceCell_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C16F RID: 115055 RVA: 0x00275FF0 File Offset: 0x002741F0
		public override vtkHigherOrderQuadrilateral GetFaceCell()
		{
			vtkHigherOrderQuadrilateral vtkHigherOrderQuadrilateral = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeHexahedron.vtkLagrangeHexahedron_GetFaceCell_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C170 RID: 115056
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeHexahedron_GetInterpolation_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C171 RID: 115057 RVA: 0x00276060 File Offset: 0x00274260
		public override vtkHigherOrderInterpolation GetInterpolation()
		{
			vtkHigherOrderInterpolation vtkHigherOrderInterpolation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeHexahedron.vtkLagrangeHexahedron_GetInterpolation_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C172 RID: 115058
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangeHexahedron_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C173 RID: 115059 RVA: 0x002760D0 File Offset: 0x002742D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLagrangeHexahedron.vtkLagrangeHexahedron_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601C174 RID: 115060
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangeHexahedron_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C175 RID: 115061 RVA: 0x002760F0 File Offset: 0x002742F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLagrangeHexahedron.vtkLagrangeHexahedron_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601C176 RID: 115062
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeHexahedron_InterpolateDerivs_09(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C177 RID: 115063 RVA: 0x0027610A File Offset: 0x0027430A
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkLagrangeHexahedron.vtkLagrangeHexahedron_InterpolateDerivs_09(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601C178 RID: 115064
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeHexahedron_InterpolateFunctions_10(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C179 RID: 115065 RVA: 0x0027611B File Offset: 0x0027431B
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkLagrangeHexahedron.vtkLagrangeHexahedron_InterpolateFunctions_10(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601C17A RID: 115066
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeHexahedron_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C17B RID: 115067 RVA: 0x0027612C File Offset: 0x0027432C
		public override int IsA(string type)
		{
			return vtkLagrangeHexahedron.vtkLagrangeHexahedron_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0601C17C RID: 115068
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeHexahedron_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C17D RID: 115069 RVA: 0x0027614C File Offset: 0x0027434C
		public new static int IsTypeOf(string type)
		{
			return vtkLagrangeHexahedron.vtkLagrangeHexahedron_IsTypeOf_12(type);
		}

		// Token: 0x0601C17E RID: 115070
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeHexahedron_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C17F RID: 115071 RVA: 0x00276168 File Offset: 0x00274368
		public new vtkLagrangeHexahedron NewInstance()
		{
			vtkLagrangeHexahedron result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeHexahedron.vtkLagrangeHexahedron_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangeHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C180 RID: 115072
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeHexahedron_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C181 RID: 115073 RVA: 0x002761C4 File Offset: 0x002743C4
		public new static vtkLagrangeHexahedron SafeDownCast(vtkObjectBase o)
		{
			vtkLagrangeHexahedron vtkLagrangeHexahedron = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeHexahedron.vtkLagrangeHexahedron_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLagrangeHexahedron = (vtkLagrangeHexahedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLagrangeHexahedron.Register(null);
				}
			}
			return vtkLagrangeHexahedron;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DE7 RID: 7655
		public new const string MRFullTypeName = "Kitware.VTK.vtkLagrangeHexahedron";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DE8 RID: 7656
		public new static readonly string MRClassNameKey = "class vtkLagrangeHexahedron";
	}
}
