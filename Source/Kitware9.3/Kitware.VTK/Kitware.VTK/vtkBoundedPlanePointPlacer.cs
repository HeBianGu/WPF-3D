using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBoundedPlanePointPlacer
	/// </summary>
	/// <remarks>
	///    a placer that constrains a handle to a finite plane
	///
	/// vtkBoundedPlanePointPlacer is a type of point placer that constrains its
	/// points to a finite (i.e., bounded) plance.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointPlacer vtkHandleWidget vtkHandleRepresentation
	/// </seealso>
	// Token: 0x020002D4 RID: 724
	public class vtkBoundedPlanePointPlacer : vtkPointPlacer
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600822F RID: 33327 RVA: 0x000BA451 File Offset: 0x000B8651
		static vtkBoundedPlanePointPlacer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBoundedPlanePointPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoundedPlanePointPlacer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008230 RID: 33328 RVA: 0x000BA479 File Offset: 0x000B8679
		public vtkBoundedPlanePointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008231 RID: 33329
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoundedPlanePointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008232 RID: 33330 RVA: 0x000BA488 File Offset: 0x000B8688
		public new static vtkBoundedPlanePointPlacer New()
		{
			vtkBoundedPlanePointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoundedPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008233 RID: 33331 RVA: 0x000BA4DC File Offset: 0x000B86DC
		public vtkBoundedPlanePointPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008234 RID: 33332 RVA: 0x000BA520 File Offset: 0x000B8720
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008235 RID: 33333
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPlanePointPlacer_AddBoundingPlane_01(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x06008236 RID: 33334 RVA: 0x000BA52C File Offset: 0x000B872C
		public void AddBoundingPlane(vtkPlane plane)
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_AddBoundingPlane_01(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x06008237 RID: 33335
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoundedPlanePointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a renderer and a display position, compute the
		/// world position and world orientation for this point.
		/// A plane is defined by a combination of the
		/// ProjectionNormal, ProjectionOrigin, and ObliquePlane
		/// ivars. The display position is projected onto this
		/// plane to determine a world position, and the
		/// orientation is set to the normal of the plane. If
		/// the point cannot project onto the plane or if it
		/// falls outside the bounds imposed by the
		/// BoundingPlanes, then 0 is returned, otherwise 1 is
		/// returned to indicate a valid return position and
		/// orientation.
		/// </summary>
		// Token: 0x06008238 RID: 33336 RVA: 0x000BA55C File Offset: 0x000B875C
		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_ComputeWorldPosition_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, worldPos, worldOrient);
		}

		// Token: 0x06008239 RID: 33337
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoundedPlanePointPlacer_ComputeWorldPosition_03(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a renderer, a display position, and a reference world
		/// position, compute the new world position and orientation
		/// of this point. This method is typically used by the
		/// representation to move the point.
		/// </summary>
		// Token: 0x0600823A RID: 33338 RVA: 0x000BA594 File Offset: 0x000B8794
		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_ComputeWorldPosition_03(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, refWorldPos, worldPos, worldOrient);
		}

		// Token: 0x0600823B RID: 33339
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoundedPlanePointPlacer_GetBoundingPlanes_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x0600823C RID: 33340 RVA: 0x000BA5D0 File Offset: 0x000B87D0
		public virtual vtkPlaneCollection GetBoundingPlanes()
		{
			vtkPlaneCollection vtkPlaneCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_GetBoundingPlanes_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaneCollection = (vtkPlaneCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaneCollection.Register(null);
				}
			}
			return vtkPlaneCollection;
		}

		// Token: 0x0600823D RID: 33341
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoundedPlanePointPlacer_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600823E RID: 33342 RVA: 0x000BA640 File Offset: 0x000B8840
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600823F RID: 33343
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBoundedPlanePointPlacer_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008240 RID: 33344 RVA: 0x000BA660 File Offset: 0x000B8860
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06008241 RID: 33345
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoundedPlanePointPlacer_GetObliquePlane_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If the ProjectionNormal is set to Oblique, then this is the
		/// oblique plane used to constrain the handle position.
		/// </summary>
		// Token: 0x06008242 RID: 33346 RVA: 0x000BA67C File Offset: 0x000B887C
		public virtual vtkPlane GetObliquePlane()
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_GetObliquePlane_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		// Token: 0x06008243 RID: 33347
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoundedPlanePointPlacer_GetProjectionNormal_08(HandleRef pThis);

		/// <summary>
		/// Set the projection normal to lie along the x, y, or z axis,
		/// or to be oblique. If it is oblique, then the plane is
		/// defined in the ObliquePlane ivar.
		/// </summary>
		// Token: 0x06008244 RID: 33348 RVA: 0x000BA6EC File Offset: 0x000B88EC
		public virtual int GetProjectionNormal()
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_GetProjectionNormal_08(base.GetCppThis());
		}

		// Token: 0x06008245 RID: 33349
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoundedPlanePointPlacer_GetProjectionNormalMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Set the projection normal to lie along the x, y, or z axis,
		/// or to be oblique. If it is oblique, then the plane is
		/// defined in the ObliquePlane ivar.
		/// </summary>
		// Token: 0x06008246 RID: 33350 RVA: 0x000BA70C File Offset: 0x000B890C
		public virtual int GetProjectionNormalMaxValue()
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_GetProjectionNormalMaxValue_09(base.GetCppThis());
		}

		// Token: 0x06008247 RID: 33351
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoundedPlanePointPlacer_GetProjectionNormalMinValue_10(HandleRef pThis);

		/// <summary>
		/// Set the projection normal to lie along the x, y, or z axis,
		/// or to be oblique. If it is oblique, then the plane is
		/// defined in the ObliquePlane ivar.
		/// </summary>
		// Token: 0x06008248 RID: 33352 RVA: 0x000BA72C File Offset: 0x000B892C
		public virtual int GetProjectionNormalMinValue()
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_GetProjectionNormalMinValue_10(base.GetCppThis());
		}

		// Token: 0x06008249 RID: 33353
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBoundedPlanePointPlacer_GetProjectionPosition_11(HandleRef pThis);

		/// <summary>
		/// The position of the bounding plane from the origin along the
		/// normal. The origin and normal are defined in the oblique plane
		/// when the ProjectionNormal is oblique. For the X, Y, and Z
		/// axes projection normals, the normal is the axis direction, and
		/// the origin is (0,0,0).
		/// </summary>
		// Token: 0x0600824A RID: 33354 RVA: 0x000BA74C File Offset: 0x000B894C
		public virtual double GetProjectionPosition()
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_GetProjectionPosition_11(base.GetCppThis());
		}

		// Token: 0x0600824B RID: 33355
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoundedPlanePointPlacer_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600824C RID: 33356 RVA: 0x000BA76C File Offset: 0x000B896C
		public override int IsA(string type)
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0600824D RID: 33357
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoundedPlanePointPlacer_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600824E RID: 33358 RVA: 0x000BA78C File Offset: 0x000B898C
		public new static int IsTypeOf(string type)
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_IsTypeOf_13(type);
		}

		// Token: 0x0600824F RID: 33359
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoundedPlanePointPlacer_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008250 RID: 33360 RVA: 0x000BA7A8 File Offset: 0x000B89A8
		public new vtkBoundedPlanePointPlacer NewInstance()
		{
			vtkBoundedPlanePointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoundedPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008251 RID: 33361
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPlanePointPlacer_RemoveAllBoundingPlanes_16(HandleRef pThis);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x06008252 RID: 33362 RVA: 0x000BA802 File Offset: 0x000B8A02
		public void RemoveAllBoundingPlanes()
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_RemoveAllBoundingPlanes_16(base.GetCppThis());
		}

		// Token: 0x06008253 RID: 33363
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPlanePointPlacer_RemoveBoundingPlane_17(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x06008254 RID: 33364 RVA: 0x000BA814 File Offset: 0x000B8A14
		public void RemoveBoundingPlane(vtkPlane plane)
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_RemoveBoundingPlane_17(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x06008255 RID: 33365
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBoundedPlanePointPlacer_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008256 RID: 33366 RVA: 0x000BA844 File Offset: 0x000B8A44
		public new static vtkBoundedPlanePointPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkBoundedPlanePointPlacer vtkBoundedPlanePointPlacer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBoundedPlanePointPlacer = (vtkBoundedPlanePointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBoundedPlanePointPlacer.Register(null);
				}
			}
			return vtkBoundedPlanePointPlacer;
		}

		// Token: 0x06008257 RID: 33367
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPlanePointPlacer_SetBoundingPlanes_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x06008258 RID: 33368 RVA: 0x000BA8C4 File Offset: 0x000B8AC4
		public virtual void SetBoundingPlanes(vtkPlaneCollection arg0)
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetBoundingPlanes_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008259 RID: 33369
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPlanePointPlacer_SetBoundingPlanes_20(HandleRef pThis, HandleRef planes);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x0600825A RID: 33370 RVA: 0x000BA8F4 File Offset: 0x000B8AF4
		public void SetBoundingPlanes(vtkPlanes planes)
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetBoundingPlanes_20(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}

		// Token: 0x0600825B RID: 33371
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPlanePointPlacer_SetObliquePlane_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// If the ProjectionNormal is set to Oblique, then this is the
		/// oblique plane used to constrain the handle position.
		/// </summary>
		// Token: 0x0600825C RID: 33372 RVA: 0x000BA924 File Offset: 0x000B8B24
		public void SetObliquePlane(vtkPlane arg0)
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetObliquePlane_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600825D RID: 33373
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPlanePointPlacer_SetProjectionNormal_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the projection normal to lie along the x, y, or z axis,
		/// or to be oblique. If it is oblique, then the plane is
		/// defined in the ObliquePlane ivar.
		/// </summary>
		// Token: 0x0600825E RID: 33374 RVA: 0x000BA953 File Offset: 0x000B8B53
		public virtual void SetProjectionNormal(int _arg)
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetProjectionNormal_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600825F RID: 33375
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPlanePointPlacer_SetProjectionNormalToOblique_23(HandleRef pThis);

		/// <summary>
		/// Set the projection normal to lie along the x, y, or z axis,
		/// or to be oblique. If it is oblique, then the plane is
		/// defined in the ObliquePlane ivar.
		/// </summary>
		// Token: 0x06008260 RID: 33376 RVA: 0x000BA963 File Offset: 0x000B8B63
		public void SetProjectionNormalToOblique()
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetProjectionNormalToOblique_23(base.GetCppThis());
		}

		// Token: 0x06008261 RID: 33377
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPlanePointPlacer_SetProjectionNormalToXAxis_24(HandleRef pThis);

		/// <summary>
		/// Set the projection normal to lie along the x, y, or z axis,
		/// or to be oblique. If it is oblique, then the plane is
		/// defined in the ObliquePlane ivar.
		/// </summary>
		// Token: 0x06008262 RID: 33378 RVA: 0x000BA972 File Offset: 0x000B8B72
		public void SetProjectionNormalToXAxis()
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetProjectionNormalToXAxis_24(base.GetCppThis());
		}

		// Token: 0x06008263 RID: 33379
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPlanePointPlacer_SetProjectionNormalToYAxis_25(HandleRef pThis);

		/// <summary>
		/// Set the projection normal to lie along the x, y, or z axis,
		/// or to be oblique. If it is oblique, then the plane is
		/// defined in the ObliquePlane ivar.
		/// </summary>
		// Token: 0x06008264 RID: 33380 RVA: 0x000BA981 File Offset: 0x000B8B81
		public void SetProjectionNormalToYAxis()
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetProjectionNormalToYAxis_25(base.GetCppThis());
		}

		// Token: 0x06008265 RID: 33381
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPlanePointPlacer_SetProjectionNormalToZAxis_26(HandleRef pThis);

		/// <summary>
		/// Set the projection normal to lie along the x, y, or z axis,
		/// or to be oblique. If it is oblique, then the plane is
		/// defined in the ObliquePlane ivar.
		/// </summary>
		// Token: 0x06008266 RID: 33382 RVA: 0x000BA990 File Offset: 0x000B8B90
		public void SetProjectionNormalToZAxis()
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetProjectionNormalToZAxis_26(base.GetCppThis());
		}

		// Token: 0x06008267 RID: 33383
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBoundedPlanePointPlacer_SetProjectionPosition_27(HandleRef pThis, double position);

		/// <summary>
		/// The position of the bounding plane from the origin along the
		/// normal. The origin and normal are defined in the oblique plane
		/// when the ProjectionNormal is oblique. For the X, Y, and Z
		/// axes projection normals, the normal is the axis direction, and
		/// the origin is (0,0,0).
		/// </summary>
		// Token: 0x06008268 RID: 33384 RVA: 0x000BA99F File Offset: 0x000B8B9F
		public void SetProjectionPosition(double position)
		{
			vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_SetProjectionPosition_27(base.GetCppThis(), position);
		}

		// Token: 0x06008269 RID: 33385
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoundedPlanePointPlacer_UpdateWorldPosition_28(HandleRef pThis, HandleRef ren, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// If the constraints on this placer are changed, then
		/// this method will be called by the representation on
		/// each of its points. For this placer, the world
		/// position will be converted to a display position, then
		/// ComputeWorldPosition will be used to update the
		/// point.
		/// </summary>
		// Token: 0x0600826A RID: 33386 RVA: 0x000BA9B0 File Offset: 0x000B8BB0
		public override int UpdateWorldPosition(vtkRenderer ren, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_UpdateWorldPosition_28(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), worldPos, worldOrient);
		}

		// Token: 0x0600826B RID: 33387
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoundedPlanePointPlacer_ValidateWorldPosition_29(HandleRef pThis, IntPtr worldPos);

		/// <summary>
		/// Give a world position check if it is valid - does
		/// it lie on the plane and within the bounds? Returns
		/// 1 if it is valid, 0 otherwise.
		/// </summary>
		// Token: 0x0600826C RID: 33388 RVA: 0x000BA9E8 File Offset: 0x000B8BE8
		public override int ValidateWorldPosition(IntPtr worldPos)
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_ValidateWorldPosition_29(base.GetCppThis(), worldPos);
		}

		// Token: 0x0600826D RID: 33389
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBoundedPlanePointPlacer_ValidateWorldPosition_30(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Give a world position check if it is valid - does
		/// it lie on the plane and within the bounds? Returns
		/// 1 if it is valid, 0 otherwise.
		/// </summary>
		// Token: 0x0600826E RID: 33390 RVA: 0x000BAA08 File Offset: 0x000B8C08
		public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkBoundedPlanePointPlacer.vtkBoundedPlanePointPlacer_ValidateWorldPosition_30(base.GetCppThis(), worldPos, worldOrient);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B0F RID: 2831
		public new const string MRFullTypeName = "Kitware.VTK.vtkBoundedPlanePointPlacer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B10 RID: 2832
		public new static readonly string MRClassNameKey = "class vtkBoundedPlanePointPlacer";

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x020002D5 RID: 725
		public enum Oblique_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000B12 RID: 2834
			Oblique = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000B13 RID: 2835
			XAxis = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000B14 RID: 2836
			YAxis,
			/// <summary>enum member</summary>
			// Token: 0x04000B15 RID: 2837
			ZAxis
		}
	}
}
