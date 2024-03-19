using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolygonalSurfaceContourLineInterpolator
	/// </summary>
	/// <remarks>
	///    Contour interpolator for to place points on polygonal surfaces.
	///
	///
	/// vtkPolygonalSurfaceContourLineInterpolator interpolates and places
	/// contour points on polygonal surfaces. The class interpolates nodes by
	/// computing a \em graph \em geodesic laying on the polygonal data. By \em
	/// graph \em Geodesic, we mean that the line interpolating the two end
	/// points traverses along on the mesh edges so as to form the shortest
	/// path. A Dijkstra algorithm is used to compute the path. See
	/// vtkDijkstraGraphGeodesicPath.
	///
	/// The class is mean to be used in conjunction with
	/// vtkPolygonalSurfacePointPlacer. The reason for this weak coupling is a
	/// performance issue, both classes need to perform a cell pick, and
	/// coupling avoids multiple cell picks (cell picks are slow).
	///
	/// @warning
	/// You should have computed cell normals for the input polydata.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDijkstraGraphGeodesicPath, vtkPolyDataNormals
	/// </seealso>
	// Token: 0x02000358 RID: 856
	public class vtkPolygonalSurfaceContourLineInterpolator : vtkPolyDataContourLineInterpolator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009BE4 RID: 39908 RVA: 0x000DCC3D File Offset: 0x000DAE3D
		static vtkPolygonalSurfaceContourLineInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolygonalSurfaceContourLineInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolygonalSurfaceContourLineInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009BE5 RID: 39909 RVA: 0x000DCC65 File Offset: 0x000DAE65
		public vtkPolygonalSurfaceContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009BE6 RID: 39910
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolygonalSurfaceContourLineInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BE7 RID: 39911 RVA: 0x000DCC74 File Offset: 0x000DAE74
		public new static vtkPolygonalSurfaceContourLineInterpolator New()
		{
			vtkPolygonalSurfaceContourLineInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygonalSurfaceContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BE8 RID: 39912 RVA: 0x000DCCC8 File Offset: 0x000DAEC8
		public vtkPolygonalSurfaceContourLineInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009BE9 RID: 39913 RVA: 0x000DCD0C File Offset: 0x000DAF0C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009BEA RID: 39914
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygonalSurfaceContourLineInterpolator_GetContourPointIds_01(HandleRef pThis, HandleRef rep, HandleRef ids);

		/// <summary>
		/// Get the contour point ids. These point ids correspond to those on the
		/// polygonal surface
		/// </summary>
		// Token: 0x06009BEB RID: 39915 RVA: 0x000DCD18 File Offset: 0x000DAF18
		public void GetContourPointIds(vtkContourRepresentation rep, vtkIdList ids)
		{
			vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_GetContourPointIds_01(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis(), (ids == null) ? default(HandleRef) : ids.GetCppThis());
		}

		// Token: 0x06009BEC RID: 39916
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolygonalSurfaceContourLineInterpolator_GetDistanceOffset_02(HandleRef pThis);

		/// <summary>
		/// Height offset at which points may be placed on the polygonal surface.
		/// If you specify a non-zero value here, be sure to have computed vertex
		/// normals on your input polygonal data. (easily done with
		/// vtkPolyDataNormals).
		/// </summary>
		// Token: 0x06009BED RID: 39917 RVA: 0x000DCD5C File Offset: 0x000DAF5C
		public virtual double GetDistanceOffset()
		{
			return vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_GetDistanceOffset_02(base.GetCppThis());
		}

		// Token: 0x06009BEE RID: 39918
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolygonalSurfaceContourLineInterpolator_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BEF RID: 39919 RVA: 0x000DCD7C File Offset: 0x000DAF7C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06009BF0 RID: 39920
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolygonalSurfaceContourLineInterpolator_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BF1 RID: 39921 RVA: 0x000DCD9C File Offset: 0x000DAF9C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06009BF2 RID: 39922
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygonalSurfaceContourLineInterpolator_InterpolateLine_05(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

		/// <summary>
		/// Subclasses that wish to interpolate a line segment must implement this.
		/// For instance vtkBezierContourLineInterpolator adds nodes between idx1
		/// and idx2, that allow the contour to adhere to a bezier curve.
		/// </summary>
		// Token: 0x06009BF3 RID: 39923 RVA: 0x000DCDB8 File Offset: 0x000DAFB8
		public override int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
		{
			return vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_InterpolateLine_05(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis(), idx1, idx2);
		}

		// Token: 0x06009BF4 RID: 39924
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygonalSurfaceContourLineInterpolator_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BF5 RID: 39925 RVA: 0x000DCE04 File Offset: 0x000DB004
		public override int IsA(string type)
		{
			return vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06009BF6 RID: 39926
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygonalSurfaceContourLineInterpolator_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BF7 RID: 39927 RVA: 0x000DCE24 File Offset: 0x000DB024
		public new static int IsTypeOf(string type)
		{
			return vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_IsTypeOf_07(type);
		}

		// Token: 0x06009BF8 RID: 39928
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolygonalSurfaceContourLineInterpolator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BF9 RID: 39929 RVA: 0x000DCE40 File Offset: 0x000DB040
		public new vtkPolygonalSurfaceContourLineInterpolator NewInstance()
		{
			vtkPolygonalSurfaceContourLineInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygonalSurfaceContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009BFA RID: 39930
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolygonalSurfaceContourLineInterpolator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009BFB RID: 39931 RVA: 0x000DCE9C File Offset: 0x000DB09C
		public new static vtkPolygonalSurfaceContourLineInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkPolygonalSurfaceContourLineInterpolator vtkPolygonalSurfaceContourLineInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolygonalSurfaceContourLineInterpolator = (vtkPolygonalSurfaceContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolygonalSurfaceContourLineInterpolator.Register(null);
				}
			}
			return vtkPolygonalSurfaceContourLineInterpolator;
		}

		// Token: 0x06009BFC RID: 39932
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygonalSurfaceContourLineInterpolator_SetDistanceOffset_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Height offset at which points may be placed on the polygonal surface.
		/// If you specify a non-zero value here, be sure to have computed vertex
		/// normals on your input polygonal data. (easily done with
		/// vtkPolyDataNormals).
		/// </summary>
		// Token: 0x06009BFD RID: 39933 RVA: 0x000DCF1B File Offset: 0x000DB11B
		public virtual void SetDistanceOffset(double _arg)
		{
			vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_SetDistanceOffset_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06009BFE RID: 39934
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygonalSurfaceContourLineInterpolator_UpdateNode_12(HandleRef pThis, HandleRef arg0, HandleRef arg1, IntPtr arg2, int arg3);

		/// <summary>
		/// The interpolator is given a chance to update the node.
		/// vtkImageContourLineInterpolator updates the idx'th node in the contour,
		/// so it automatically sticks to edges in the vicinity as the user
		/// constructs the contour.
		/// Returns 0 if the node (world position) is unchanged.
		/// </summary>
		// Token: 0x06009BFF RID: 39935 RVA: 0x000DCF2C File Offset: 0x000DB12C
		public override int UpdateNode(vtkRenderer arg0, vtkContourRepresentation arg1, IntPtr arg2, int arg3)
		{
			return vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_UpdateNode_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2, arg3);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CA3 RID: 3235
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolygonalSurfaceContourLineInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CA4 RID: 3236
		public new static readonly string MRClassNameKey = "class vtkPolygonalSurfaceContourLineInterpolator";
	}
}
