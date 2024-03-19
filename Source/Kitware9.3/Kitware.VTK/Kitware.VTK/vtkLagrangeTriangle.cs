using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLagrangeTriangle
	/// </summary>
	/// <remarks>
	///    A 2D cell that represents an arbitrary order Lagrange triangle
	///
	/// vtkLagrangeTriangle is a concrete implementation of vtkCell to represent a
	/// 2D triangle using Lagrange shape functions of user specified order.
	///
	/// The number of points in a Lagrange cell determines the order over which they
	/// are iterated relative to the parametric coordinate system of the cell. The
	/// first points that are reported are vertices. They appear in the same order in
	/// which they would appear in linear cells. Mid-edge points are reported next.
	/// They are reported in sequence. For two- and three-dimensional (3D) cells, the
	/// following set of points to be reported are face points. Finally, 3D cells
	/// report points interior to their volume.
	/// </remarks>
	// Token: 0x02000A7C RID: 2684
	public class vtkLagrangeTriangle : vtkHigherOrderTriangle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C1EA RID: 115178 RVA: 0x00276D53 File Offset: 0x00274F53
		static vtkLagrangeTriangle()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLagrangeTriangle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLagrangeTriangle"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C1EB RID: 115179 RVA: 0x00276D7B File Offset: 0x00274F7B
		public vtkLagrangeTriangle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C1EC RID: 115180
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeTriangle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1ED RID: 115181 RVA: 0x00276D8C File Offset: 0x00274F8C
		public new static vtkLagrangeTriangle New()
		{
			vtkLagrangeTriangle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeTriangle.vtkLagrangeTriangle_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangeTriangle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1EE RID: 115182 RVA: 0x00276DE0 File Offset: 0x00274FE0
		public vtkLagrangeTriangle() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLagrangeTriangle.vtkLagrangeTriangle_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C1EF RID: 115183 RVA: 0x00276E24 File Offset: 0x00275024
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C1F0 RID: 115184
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeTriangle_GetCellType_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1F1 RID: 115185 RVA: 0x00276E30 File Offset: 0x00275030
		public override int GetCellType()
		{
			return vtkLagrangeTriangle.vtkLagrangeTriangle_GetCellType_01(base.GetCppThis());
		}

		// Token: 0x0601C1F2 RID: 115186
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeTriangle_GetEdge_02(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1F3 RID: 115187 RVA: 0x00276E50 File Offset: 0x00275050
		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeTriangle.vtkLagrangeTriangle_GetEdge_02(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C1F4 RID: 115188
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeTriangle_GetEdgeCell_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1F5 RID: 115189 RVA: 0x00276EC0 File Offset: 0x002750C0
		public override vtkHigherOrderCurve GetEdgeCell()
		{
			vtkHigherOrderCurve vtkHigherOrderCurve = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeTriangle.vtkLagrangeTriangle_GetEdgeCell_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C1F6 RID: 115190
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangeTriangle_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1F7 RID: 115191 RVA: 0x00276F30 File Offset: 0x00275130
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLagrangeTriangle.vtkLagrangeTriangle_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601C1F8 RID: 115192
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLagrangeTriangle_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1F9 RID: 115193 RVA: 0x00276F50 File Offset: 0x00275150
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLagrangeTriangle.vtkLagrangeTriangle_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601C1FA RID: 115194
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeTriangle_InterpolateDerivs_06(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1FB RID: 115195 RVA: 0x00276F6A File Offset: 0x0027516A
		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkLagrangeTriangle.vtkLagrangeTriangle_InterpolateDerivs_06(base.GetCppThis(), pcoords, derivs);
		}

		// Token: 0x0601C1FC RID: 115196
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLagrangeTriangle_InterpolateFunctions_07(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1FD RID: 115197 RVA: 0x00276F7B File Offset: 0x0027517B
		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkLagrangeTriangle.vtkLagrangeTriangle_InterpolateFunctions_07(base.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0601C1FE RID: 115198
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeTriangle_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C1FF RID: 115199 RVA: 0x00276F8C File Offset: 0x0027518C
		public override int IsA(string type)
		{
			return vtkLagrangeTriangle.vtkLagrangeTriangle_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601C200 RID: 115200
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLagrangeTriangle_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C201 RID: 115201 RVA: 0x00276FAC File Offset: 0x002751AC
		public new static int IsTypeOf(string type)
		{
			return vtkLagrangeTriangle.vtkLagrangeTriangle_IsTypeOf_09(type);
		}

		// Token: 0x0601C202 RID: 115202
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeTriangle_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C203 RID: 115203 RVA: 0x00276FC8 File Offset: 0x002751C8
		public new vtkLagrangeTriangle NewInstance()
		{
			vtkLagrangeTriangle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeTriangle.vtkLagrangeTriangle_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLagrangeTriangle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C204 RID: 115204
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLagrangeTriangle_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C205 RID: 115205 RVA: 0x00277024 File Offset: 0x00275224
		public new static vtkLagrangeTriangle SafeDownCast(vtkObjectBase o)
		{
			vtkLagrangeTriangle vtkLagrangeTriangle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLagrangeTriangle.vtkLagrangeTriangle_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLagrangeTriangle = (vtkLagrangeTriangle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLagrangeTriangle.Register(null);
				}
			}
			return vtkLagrangeTriangle;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DEF RID: 7663
		public new const string MRFullTypeName = "Kitware.VTK.vtkLagrangeTriangle";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DF0 RID: 7664
		public new static readonly string MRClassNameKey = "class vtkLagrangeTriangle";
	}
}
