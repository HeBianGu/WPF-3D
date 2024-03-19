using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolygonalSurfacePointPlacer
	/// </summary>
	/// <remarks>
	///    Place points on the surface of polygonal data.
	///
	///
	/// vtkPolygonalSurfacePointPlacer places points on polygonal data and is
	/// meant to be used in conjunction with
	/// vtkPolygonalSurfaceContourLineInterpolator.
	///
	/// @warning
	/// You should have computed cell normals for the input polydata if you are
	/// specifying a distance offset.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointPlacer vtkPolyDataNormals
	/// </seealso>
	// Token: 0x02000359 RID: 857
	public class vtkPolygonalSurfacePointPlacer : vtkPolyDataPointPlacer
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009C00 RID: 39936 RVA: 0x000DCF78 File Offset: 0x000DB178
		static vtkPolygonalSurfacePointPlacer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolygonalSurfacePointPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolygonalSurfacePointPlacer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009C01 RID: 39937 RVA: 0x000DCFA0 File Offset: 0x000DB1A0
		public vtkPolygonalSurfacePointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009C02 RID: 39938
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolygonalSurfacePointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009C03 RID: 39939 RVA: 0x000DCFB0 File Offset: 0x000DB1B0
		public new static vtkPolygonalSurfacePointPlacer New()
		{
			vtkPolygonalSurfacePointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygonalSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009C04 RID: 39940 RVA: 0x000DD004 File Offset: 0x000DB204
		public vtkPolygonalSurfacePointPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009C05 RID: 39941 RVA: 0x000DD048 File Offset: 0x000DB248
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009C06 RID: 39942
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygonalSurfacePointPlacer_AddProp_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009C07 RID: 39943 RVA: 0x000DD054 File Offset: 0x000DB254
		public override void AddProp(vtkProp arg0)
		{
			vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_AddProp_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009C08 RID: 39944
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygonalSurfacePointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a renderer and a display position in pixel coordinates,
		/// compute the world position and orientation where this point
		/// will be placed. This method is typically used by the
		/// representation to place the point initially.
		/// For the Terrain point placer this computes world points that
		/// lie at the specified height above the terrain.
		/// </summary>
		// Token: 0x06009C09 RID: 39945 RVA: 0x000DD084 File Offset: 0x000DB284
		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_ComputeWorldPosition_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, worldPos, worldOrient);
		}

		// Token: 0x06009C0A RID: 39946
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygonalSurfacePointPlacer_ComputeWorldPosition_03(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a renderer, a display position, and a reference world
		/// position, compute the new world position and orientation
		/// of this point. This method is typically used by the
		/// representation to move the point.
		/// </summary>
		// Token: 0x06009C0B RID: 39947 RVA: 0x000DD0BC File Offset: 0x000DB2BC
		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_ComputeWorldPosition_03(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, refWorldPos, worldPos, worldOrient);
		}

		// Token: 0x06009C0C RID: 39948
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolygonalSurfacePointPlacer_GetCellPicker_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the Prop picker.
		/// </summary>
		// Token: 0x06009C0D RID: 39949 RVA: 0x000DD0F8 File Offset: 0x000DB2F8
		public virtual vtkCellPicker GetCellPicker()
		{
			vtkCellPicker vtkCellPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_GetCellPicker_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellPicker = (vtkCellPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellPicker.Register(null);
				}
			}
			return vtkCellPicker;
		}

		// Token: 0x06009C0E RID: 39950
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolygonalSurfacePointPlacer_GetDistanceOffset_05(HandleRef pThis);

		/// <summary>
		/// Height offset at which points may be placed on the polygonal surface.
		/// If you specify a non-zero value here, be sure to compute cell normals
		/// on your input polygonal data (easily done with vtkPolyDataNormals).
		/// </summary>
		// Token: 0x06009C0F RID: 39951 RVA: 0x000DD168 File Offset: 0x000DB368
		public virtual double GetDistanceOffset()
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_GetDistanceOffset_05(base.GetCppThis());
		}

		// Token: 0x06009C10 RID: 39952
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolygonalSurfacePointPlacer_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009C11 RID: 39953 RVA: 0x000DD188 File Offset: 0x000DB388
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06009C12 RID: 39954
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolygonalSurfacePointPlacer_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009C13 RID: 39955 RVA: 0x000DD1A8 File Offset: 0x000DB3A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06009C14 RID: 39956
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolygonalSurfacePointPlacer_GetPolys_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Be sure to add polydata on which you wish to place points to this list
		/// or they will not be considered for placement.
		/// </summary>
		// Token: 0x06009C15 RID: 39957 RVA: 0x000DD1C4 File Offset: 0x000DB3C4
		public virtual vtkPolyDataCollection GetPolys()
		{
			vtkPolyDataCollection vtkPolyDataCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_GetPolys_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataCollection = (vtkPolyDataCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataCollection.Register(null);
				}
			}
			return vtkPolyDataCollection;
		}

		// Token: 0x06009C16 RID: 39958
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygonalSurfacePointPlacer_GetSnapToClosestPoint_09(HandleRef pThis);

		/// <summary>
		/// Snap to the closest point on the surface ?
		/// This is useful for the vtkPolygonalSurfaceContourLineInterpolator, when
		/// drawing contours along the edges of a surface mesh.
		/// OFF by default.
		/// </summary>
		// Token: 0x06009C17 RID: 39959 RVA: 0x000DD234 File Offset: 0x000DB434
		public virtual int GetSnapToClosestPoint()
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_GetSnapToClosestPoint_09(base.GetCppThis());
		}

		// Token: 0x06009C18 RID: 39960
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygonalSurfacePointPlacer_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009C19 RID: 39961 RVA: 0x000DD254 File Offset: 0x000DB454
		public override int IsA(string type)
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06009C1A RID: 39962
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygonalSurfacePointPlacer_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009C1B RID: 39963 RVA: 0x000DD274 File Offset: 0x000DB474
		public new static int IsTypeOf(string type)
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_IsTypeOf_11(type);
		}

		// Token: 0x06009C1C RID: 39964
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolygonalSurfacePointPlacer_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009C1D RID: 39965 RVA: 0x000DD290 File Offset: 0x000DB490
		public new vtkPolygonalSurfacePointPlacer NewInstance()
		{
			vtkPolygonalSurfacePointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygonalSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009C1E RID: 39966
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygonalSurfacePointPlacer_RemoveAllProps_14(HandleRef pThis);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009C1F RID: 39967 RVA: 0x000DD2EA File Offset: 0x000DB4EA
		public override void RemoveAllProps()
		{
			vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_RemoveAllProps_14(base.GetCppThis());
		}

		// Token: 0x06009C20 RID: 39968
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygonalSurfacePointPlacer_RemoveViewProp_15(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009C21 RID: 39969 RVA: 0x000DD2FC File Offset: 0x000DB4FC
		public override void RemoveViewProp(vtkProp prop)
		{
			vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_RemoveViewProp_15(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06009C22 RID: 39970
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolygonalSurfacePointPlacer_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009C23 RID: 39971 RVA: 0x000DD32C File Offset: 0x000DB52C
		public new static vtkPolygonalSurfacePointPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkPolygonalSurfacePointPlacer vtkPolygonalSurfacePointPlacer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolygonalSurfacePointPlacer = (vtkPolygonalSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolygonalSurfacePointPlacer.Register(null);
				}
			}
			return vtkPolygonalSurfacePointPlacer;
		}

		// Token: 0x06009C24 RID: 39972
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygonalSurfacePointPlacer_SetDistanceOffset_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Height offset at which points may be placed on the polygonal surface.
		/// If you specify a non-zero value here, be sure to compute cell normals
		/// on your input polygonal data (easily done with vtkPolyDataNormals).
		/// </summary>
		// Token: 0x06009C25 RID: 39973 RVA: 0x000DD3AB File Offset: 0x000DB5AB
		public virtual void SetDistanceOffset(double _arg)
		{
			vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_SetDistanceOffset_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06009C26 RID: 39974
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygonalSurfacePointPlacer_SetSnapToClosestPoint_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Snap to the closest point on the surface ?
		/// This is useful for the vtkPolygonalSurfaceContourLineInterpolator, when
		/// drawing contours along the edges of a surface mesh.
		/// OFF by default.
		/// </summary>
		// Token: 0x06009C27 RID: 39975 RVA: 0x000DD3BB File Offset: 0x000DB5BB
		public virtual void SetSnapToClosestPoint(int _arg)
		{
			vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_SetSnapToClosestPoint_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06009C28 RID: 39976
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygonalSurfacePointPlacer_SnapToClosestPointOff_19(HandleRef pThis);

		/// <summary>
		/// Snap to the closest point on the surface ?
		/// This is useful for the vtkPolygonalSurfaceContourLineInterpolator, when
		/// drawing contours along the edges of a surface mesh.
		/// OFF by default.
		/// </summary>
		// Token: 0x06009C29 RID: 39977 RVA: 0x000DD3CB File Offset: 0x000DB5CB
		public virtual void SnapToClosestPointOff()
		{
			vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_SnapToClosestPointOff_19(base.GetCppThis());
		}

		// Token: 0x06009C2A RID: 39978
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolygonalSurfacePointPlacer_SnapToClosestPointOn_20(HandleRef pThis);

		/// <summary>
		/// Snap to the closest point on the surface ?
		/// This is useful for the vtkPolygonalSurfaceContourLineInterpolator, when
		/// drawing contours along the edges of a surface mesh.
		/// OFF by default.
		/// </summary>
		// Token: 0x06009C2B RID: 39979 RVA: 0x000DD3DA File Offset: 0x000DB5DA
		public virtual void SnapToClosestPointOn()
		{
			vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_SnapToClosestPointOn_20(base.GetCppThis());
		}

		// Token: 0x06009C2C RID: 39980
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygonalSurfacePointPlacer_UpdateNodeWorldPosition_21(HandleRef pThis, IntPtr worldPos, long nodePointId);

		/// <summary>
		/// Give the node a chance to update its auxiliary point id.
		/// </summary>
		// Token: 0x06009C2D RID: 39981 RVA: 0x000DD3EC File Offset: 0x000DB5EC
		public override int UpdateNodeWorldPosition(IntPtr worldPos, long nodePointId)
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_UpdateNodeWorldPosition_21(base.GetCppThis(), worldPos, nodePointId);
		}

		// Token: 0x06009C2E RID: 39982
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygonalSurfacePointPlacer_ValidateDisplayPosition_22(HandleRef pThis, HandleRef arg0, IntPtr displayPos);

		/// <summary>
		/// Given a display position, check the validity of this position.
		/// </summary>
		// Token: 0x06009C2F RID: 39983 RVA: 0x000DD410 File Offset: 0x000DB610
		public override int ValidateDisplayPosition(vtkRenderer arg0, IntPtr displayPos)
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_ValidateDisplayPosition_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), displayPos);
		}

		// Token: 0x06009C30 RID: 39984
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygonalSurfacePointPlacer_ValidateWorldPosition_23(HandleRef pThis, IntPtr worldPos);

		/// <summary>
		/// Given a world position check the validity of this
		/// position according to the constraints of the placer
		/// </summary>
		// Token: 0x06009C31 RID: 39985 RVA: 0x000DD448 File Offset: 0x000DB648
		public override int ValidateWorldPosition(IntPtr worldPos)
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_ValidateWorldPosition_23(base.GetCppThis(), worldPos);
		}

		// Token: 0x06009C32 RID: 39986
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolygonalSurfacePointPlacer_ValidateWorldPosition_24(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a world position and a world orientation,
		/// validate it according to the constraints of the placer.
		/// </summary>
		// Token: 0x06009C33 RID: 39987 RVA: 0x000DD468 File Offset: 0x000DB668
		public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPolygonalSurfacePointPlacer.vtkPolygonalSurfacePointPlacer_ValidateWorldPosition_24(base.GetCppThis(), worldPos, worldOrient);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CA5 RID: 3237
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolygonalSurfacePointPlacer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CA6 RID: 3238
		public new static readonly string MRClassNameKey = "class vtkPolygonalSurfacePointPlacer";
	}
}
