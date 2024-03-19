using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLagrangeTetra
	/// </summary>
	/// <remarks>
	///    A 3D cell that represents an arbitrary order Lagrange tetrahedron
	///
	/// vtkLagrangeTetra is a concrete implementation of vtkCell to represent a
	/// 3D tetrahedron using Lagrange shape functions of user specified order.
	///
	/// The number of points in a Lagrange cell determines the order over which they
	/// are iterated relative to the parametric coordinate system of the cell. The
	/// first points that are reported are vertices. They appear in the same order in
	/// which they would appear in linear cells. Mid-edge points are reported next.
	/// They are reported in sequence. For two- and three-dimensional (3D) cells, the
	/// following set of points to be reported are face points. Finally, 3D cells
	/// report points interior to their volume.
	/// </remarks>
	// Token: 0x02000A7B RID: 2683
	public class vtkLagrangeTetra : vtkHigherOrderTetra
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C1CA RID: 115146 RVA: 0x00276923 File Offset: 0x00274B23
		static vtkLagrangeTetra()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLagrangeTetra.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLagrangeTetra"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C1CB RID: 115147 RVA: 0x0027694B File Offset: 0x00274B4B
		public vtkLagrangeTetra(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C1CC RID: 115148
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeTetra_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1CD RID: 115149 RVA: 0x0027695C File Offset: 0x00274B5C
		public new static vtkLagrangeTetra New()
		{
			vtkLagrangeTetra result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeTetra.vtkLagrangeTetra_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangeTetra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1CE RID: 115150 RVA: 0x002769B0 File Offset: 0x00274BB0
		public vtkLagrangeTetra() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLagrangeTetra.vtkLagrangeTetra_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C1CF RID: 115151 RVA: 0x002769F4 File Offset: 0x00274BF4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C1D0 RID: 115152
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeTetra_GetCellType_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1D1 RID: 115153 RVA: 0x00276A00 File Offset: 0x00274C00
		public override int GetCellType()
		{
			return vtkLagrangeTetra.vtkLagrangeTetra_GetCellType_01(base.GetCppThis());
		}

		// Token: 0x0601C1D2 RID: 115154
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeTetra_GetEdge_02(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1D3 RID: 115155 RVA: 0x00276A20 File Offset: 0x00274C20
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeTetra.vtkLagrangeTetra_GetEdge_02(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C1D4 RID: 115156
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeTetra_GetEdgeCell_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1D5 RID: 115157 RVA: 0x00276A90 File Offset: 0x00274C90
		public override vtkHigherOrderCurve GetEdgeCell()
		{
			vtkHigherOrderCurve vtkHigherOrderCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeTetra.vtkLagrangeTetra_GetEdgeCell_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C1D6 RID: 115158
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeTetra_GetFace_04(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1D7 RID: 115159 RVA: 0x00276B00 File Offset: 0x00274D00
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeTetra.vtkLagrangeTetra_GetFace_04(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C1D8 RID: 115160
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeTetra_GetFaceCell_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1D9 RID: 115161 RVA: 0x00276B70 File Offset: 0x00274D70
		public override vtkHigherOrderTriangle GetFaceCell()
		{
			vtkHigherOrderTriangle vtkHigherOrderTriangle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeTetra.vtkLagrangeTetra_GetFaceCell_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHigherOrderTriangle = (vtkHigherOrderTriangle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHigherOrderTriangle.Register(null);
				}
			}
			return vtkHigherOrderTriangle;
		}

		// Token: 0x0601C1DA RID: 115162
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangeTetra_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1DB RID: 115163 RVA: 0x00276BE0 File Offset: 0x00274DE0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLagrangeTetra.vtkLagrangeTetra_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601C1DC RID: 115164
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangeTetra_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1DD RID: 115165 RVA: 0x00276C00 File Offset: 0x00274E00
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLagrangeTetra.vtkLagrangeTetra_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601C1DE RID: 115166
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeTetra_InterpolateDerivs_08(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1DF RID: 115167 RVA: 0x00276C1A File Offset: 0x00274E1A
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkLagrangeTetra.vtkLagrangeTetra_InterpolateDerivs_08(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601C1E0 RID: 115168
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeTetra_InterpolateFunctions_09(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1E1 RID: 115169 RVA: 0x00276C2B File Offset: 0x00274E2B
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkLagrangeTetra.vtkLagrangeTetra_InterpolateFunctions_09(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601C1E2 RID: 115170
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeTetra_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1E3 RID: 115171 RVA: 0x00276C3C File Offset: 0x00274E3C
		public override int IsA(string type)
		{
			return vtkLagrangeTetra.vtkLagrangeTetra_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601C1E4 RID: 115172
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeTetra_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1E5 RID: 115173 RVA: 0x00276C5C File Offset: 0x00274E5C
		public new static int IsTypeOf(string type)
		{
			return vtkLagrangeTetra.vtkLagrangeTetra_IsTypeOf_11(type);
		}

		// Token: 0x0601C1E6 RID: 115174
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeTetra_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1E7 RID: 115175 RVA: 0x00276C78 File Offset: 0x00274E78
		public new vtkLagrangeTetra NewInstance()
		{
			vtkLagrangeTetra result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeTetra.vtkLagrangeTetra_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangeTetra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C1E8 RID: 115176
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeTetra_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1E9 RID: 115177 RVA: 0x00276CD4 File Offset: 0x00274ED4
		public new static vtkLagrangeTetra SafeDownCast(vtkObjectBase o)
		{
			vtkLagrangeTetra vtkLagrangeTetra = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeTetra.vtkLagrangeTetra_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLagrangeTetra = (vtkLagrangeTetra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLagrangeTetra.Register(null);
				}
			}
			return vtkLagrangeTetra;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DED RID: 7661
		public new const string MRFullTypeName = "Kitware.VTK.vtkLagrangeTetra";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DEE RID: 7662
		public new static readonly string MRClassNameKey = "class vtkLagrangeTetra";
	}
}
