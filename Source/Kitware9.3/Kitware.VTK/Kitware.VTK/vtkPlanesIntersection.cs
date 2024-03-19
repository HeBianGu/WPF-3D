using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlanesIntersection
	/// </summary>
	/// <remarks>
	///    A vtkPlanesIntersection object is a
	///    vtkPlanes object that can compute whether the arbitrary convex region
	///    bounded by it's planes intersects an axis-aligned box.
	///
	///
	///    A subclass of vtkPlanes, this class determines whether it
	///    intersects an axis aligned box.   This is motivated by the
	///    need to intersect the axis aligned region of a spatial
	///    decomposition of volume data with various other regions.
	///    It uses the algorithm from Graphics Gems IV, page 81.
	///
	/// @par Caveat:
	///    An instance of vtkPlanes can be redefined by changing the planes,
	///    but this subclass then will not know if the region vertices are
	///    up to date.  (Region vertices can be specified in SetRegionVertices
	///    or computed by the subclass.)  So Delete and recreate if you want
	///    to change the set of planes.
	///
	/// </remarks>
	// Token: 0x02000A9A RID: 2714
	public class vtkPlanesIntersection : vtkPlanes
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C78D RID: 116621 RVA: 0x0027FDAB File Offset: 0x0027DFAB
		static vtkPlanesIntersection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlanesIntersection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlanesIntersection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C78E RID: 116622 RVA: 0x0027FDD3 File Offset: 0x0027DFD3
		public vtkPlanesIntersection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C78F RID: 116623
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlanesIntersection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C790 RID: 116624 RVA: 0x0027FDE4 File Offset: 0x0027DFE4
		public new static vtkPlanesIntersection New()
		{
			vtkPlanesIntersection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlanesIntersection.vtkPlanesIntersection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlanesIntersection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C791 RID: 116625 RVA: 0x0027FE38 File Offset: 0x0027E038
		public vtkPlanesIntersection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlanesIntersection.vtkPlanesIntersection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C792 RID: 116626 RVA: 0x0027FE7C File Offset: 0x0027E07C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C793 RID: 116627
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlanesIntersection_Convert3DCell_01(HandleRef cell, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Another convenience function provided by this class, returns
		/// the vtkPlanesIntersection object representing a 3D
		/// cell.  The point IDs for each face must be given in
		/// counter-clockwise order from the outside of the cell.
		/// </summary>
		// Token: 0x0601C794 RID: 116628 RVA: 0x0027FE88 File Offset: 0x0027E088
		public static vtkPlanesIntersection Convert3DCell(vtkCell cell)
		{
			vtkPlanesIntersection vtkPlanesIntersection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlanesIntersection.vtkPlanesIntersection_Convert3DCell_01((cell == null) ? default(HandleRef) : cell.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlanesIntersection = (vtkPlanesIntersection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlanesIntersection.Register(null);
				}
			}
			return vtkPlanesIntersection;
		}

		// Token: 0x0601C795 RID: 116629
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlanesIntersection_GetNumRegionVertices_02(HandleRef pThis);

		/// <summary>
		/// It helps if you know the vertices of the convex region.
		/// If you don't, we will calculate them.  Region vertices
		/// are 3-tuples.
		/// </summary>
		// Token: 0x0601C796 RID: 116630 RVA: 0x0027FF08 File Offset: 0x0027E108
		public int GetNumRegionVertices()
		{
			return vtkPlanesIntersection.vtkPlanesIntersection_GetNumRegionVertices_02(base.GetCppThis());
		}

		// Token: 0x0601C797 RID: 116631
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlanesIntersection_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C798 RID: 116632 RVA: 0x0027FF28 File Offset: 0x0027E128
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlanesIntersection.vtkPlanesIntersection_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601C799 RID: 116633
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlanesIntersection_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C79A RID: 116634 RVA: 0x0027FF48 File Offset: 0x0027E148
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlanesIntersection.vtkPlanesIntersection_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601C79B RID: 116635
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlanesIntersection_GetNumberOfRegionVertices_05(HandleRef pThis);

		/// <summary>
		/// It helps if you know the vertices of the convex region.
		/// If you don't, we will calculate them.  Region vertices
		/// are 3-tuples.
		/// </summary>
		// Token: 0x0601C79C RID: 116636 RVA: 0x0027FF64 File Offset: 0x0027E164
		public int GetNumberOfRegionVertices()
		{
			return vtkPlanesIntersection.vtkPlanesIntersection_GetNumberOfRegionVertices_05(base.GetCppThis());
		}

		// Token: 0x0601C79D RID: 116637
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlanesIntersection_GetRegionVertices_06(HandleRef pThis, IntPtr v, int nvertices);

		/// <summary>
		/// It helps if you know the vertices of the convex region.
		/// If you don't, we will calculate them.  Region vertices
		/// are 3-tuples.
		/// </summary>
		// Token: 0x0601C79E RID: 116638 RVA: 0x0027FF84 File Offset: 0x0027E184
		public int GetRegionVertices(IntPtr v, int nvertices)
		{
			return vtkPlanesIntersection.vtkPlanesIntersection_GetRegionVertices_06(base.GetCppThis(), v, nvertices);
		}

		// Token: 0x0601C79F RID: 116639
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlanesIntersection_IntersectsRegion_07(HandleRef pThis, HandleRef R);

		/// <summary>
		/// Return 1 if the axis aligned box defined by R intersects
		/// the region defined by the planes, or 0 otherwise.
		/// </summary>
		// Token: 0x0601C7A0 RID: 116640 RVA: 0x0027FFA8 File Offset: 0x0027E1A8
		public int IntersectsRegion(vtkPoints R)
		{
			return vtkPlanesIntersection.vtkPlanesIntersection_IntersectsRegion_07(base.GetCppThis(), (R == null) ? default(HandleRef) : R.GetCppThis());
		}

		// Token: 0x0601C7A1 RID: 116641
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlanesIntersection_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7A2 RID: 116642 RVA: 0x0027FFDC File Offset: 0x0027E1DC
		public override int IsA(string type)
		{
			return vtkPlanesIntersection.vtkPlanesIntersection_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601C7A3 RID: 116643
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlanesIntersection_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7A4 RID: 116644 RVA: 0x0027FFFC File Offset: 0x0027E1FC
		public new static int IsTypeOf(string type)
		{
			return vtkPlanesIntersection.vtkPlanesIntersection_IsTypeOf_09(type);
		}

		// Token: 0x0601C7A5 RID: 116645
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlanesIntersection_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7A6 RID: 116646 RVA: 0x00280018 File Offset: 0x0027E218
		public new vtkPlanesIntersection NewInstance()
		{
			vtkPlanesIntersection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlanesIntersection.vtkPlanesIntersection_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlanesIntersection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C7A7 RID: 116647
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlanesIntersection_PolygonIntersectsBBox_12(IntPtr bounds, HandleRef pts);

		/// <summary>
		/// A convenience function provided by this class, returns
		/// 1 if the polygon defined in pts intersects the bounding
		/// box defined in bounds, 0 otherwise.
		///
		/// The points must define a planar polygon.
		/// </summary>
		// Token: 0x0601C7A8 RID: 116648 RVA: 0x00280074 File Offset: 0x0027E274
		public static int PolygonIntersectsBBox(IntPtr bounds, vtkPoints pts)
		{
			return vtkPlanesIntersection.vtkPlanesIntersection_PolygonIntersectsBBox_12(bounds, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601C7A9 RID: 116649
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlanesIntersection_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7AA RID: 116650 RVA: 0x002800A4 File Offset: 0x0027E2A4
		public new static vtkPlanesIntersection SafeDownCast(vtkObjectBase o)
		{
			vtkPlanesIntersection vtkPlanesIntersection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlanesIntersection.vtkPlanesIntersection_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlanesIntersection = (vtkPlanesIntersection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlanesIntersection.Register(null);
				}
			}
			return vtkPlanesIntersection;
		}

		// Token: 0x0601C7AB RID: 116651
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlanesIntersection_SetRegionVertices_14(HandleRef pThis, HandleRef pts);

		/// <summary>
		/// It helps if you know the vertices of the convex region.
		/// If you don't, we will calculate them.  Region vertices
		/// are 3-tuples.
		/// </summary>
		// Token: 0x0601C7AC RID: 116652 RVA: 0x00280124 File Offset: 0x0027E324
		public void SetRegionVertices(vtkPoints pts)
		{
			vtkPlanesIntersection.vtkPlanesIntersection_SetRegionVertices_14(base.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601C7AD RID: 116653
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlanesIntersection_SetRegionVertices_15(HandleRef pThis, IntPtr v, int nvertices);

		/// <summary>
		/// It helps if you know the vertices of the convex region.
		/// If you don't, we will calculate them.  Region vertices
		/// are 3-tuples.
		/// </summary>
		// Token: 0x0601C7AE RID: 116654 RVA: 0x00280153 File Offset: 0x0027E353
		public void SetRegionVertices(IntPtr v, int nvertices)
		{
			vtkPlanesIntersection.vtkPlanesIntersection_SetRegionVertices_15(base.GetCppThis(), v, nvertices);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E35 RID: 7733
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlanesIntersection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E36 RID: 7734
		public new static readonly string MRClassNameKey = "class vtkPlanesIntersection";
	}
}
