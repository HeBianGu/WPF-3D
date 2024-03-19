using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointPlacer
	/// </summary>
	/// <remarks>
	///    Abstract interface to translate 2D display positions to world coordinates
	///
	/// Most widgets in VTK have a need to translate of 2D display coordinates (as
	/// reported by the RenderWindowInteractor) to 3D world coordinates. This class
	/// is an abstraction of this functionality. A few subclasses are listed below:
	/// &lt;p&gt;1) vtkFocalPlanePointPlacer: This class converts 2D display positions to
	/// world positions such that they lie on the focal plane.
	/// &lt;p&gt;2) vtkPolygonalSurfacePointPlacer: Converts 2D display positions to
	/// world positions such that they lie on the surface of one or more specified
	/// polydatas.
	/// &lt;p&gt;3) vtkImageActorPointPlacer: Converts 2D display positions to world
	/// positions such that they lie on an ImageActor
	/// &lt;p&gt;4) vtkBoundedPlanePointPlacer: Converts 2D display positions to world
	/// positions such that they lie within a set of specified bounding planes.
	/// &lt;p&gt;5) vtkTerrainDataPointPlacer: Converts 2D display positions to world
	/// positions such that they lie on a height field.
	/// &lt;p&gt; Point placers provide an extensible framework to specify constraints on
	/// points. The methods ComputeWorldPosition, ValidateDisplayPosition and
	/// ValidateWorldPosition may be overridden to dictate whether a world or
	/// display position is allowed. These classes are currently used by the
	/// HandleWidget and the ContourWidget to allow various constraints to be
	/// enforced on the placement of their handles.
	/// </remarks>
	// Token: 0x020002D3 RID: 723
	public class vtkPointPlacer : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060081FD RID: 33277 RVA: 0x000B9FD7 File Offset: 0x000B81D7
		static vtkPointPlacer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointPlacer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060081FE RID: 33278 RVA: 0x000B9FFF File Offset: 0x000B81FF
		public vtkPointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060081FF RID: 33279
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008200 RID: 33280 RVA: 0x000BA010 File Offset: 0x000B8210
		public new static vtkPointPlacer New()
		{
			vtkPointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointPlacer.vtkPointPlacer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008201 RID: 33281 RVA: 0x000BA064 File Offset: 0x000B8264
		public vtkPointPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointPlacer.vtkPointPlacer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008202 RID: 33282 RVA: 0x000BA0A8 File Offset: 0x000B82A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008203 RID: 33283
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointPlacer_ComputeWorldPosition_01(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a renderer and a display position in pixel coordinates,
		/// compute the world position and orientation where this point
		/// will be placed. This method is typically used by the
		/// representation to place the point initially. A return value of 1
		/// indicates that constraints of the placer are met.
		/// </summary>
		// Token: 0x06008204 RID: 33284 RVA: 0x000BA0B4 File Offset: 0x000B82B4
		public virtual int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPointPlacer.vtkPointPlacer_ComputeWorldPosition_01(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, worldPos, worldOrient);
		}

		// Token: 0x06008205 RID: 33285
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a renderer, a display position, and a reference world
		/// position, compute the new world position and orientation
		/// of this point. This method is typically used by the
		/// representation to move the point. A return value of 1 indicates that
		/// constraints of the placer are met.
		/// </summary>
		// Token: 0x06008206 RID: 33286 RVA: 0x000BA0EC File Offset: 0x000B82EC
		public virtual int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPointPlacer.vtkPointPlacer_ComputeWorldPosition_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, refWorldPos, worldPos, worldOrient);
		}

		// Token: 0x06008207 RID: 33287
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointPlacer_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008208 RID: 33288 RVA: 0x000BA128 File Offset: 0x000B8328
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointPlacer.vtkPointPlacer_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06008209 RID: 33289
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointPlacer_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600820A RID: 33290 RVA: 0x000BA148 File Offset: 0x000B8348
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointPlacer.vtkPointPlacer_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600820B RID: 33291
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointPlacer_GetPixelTolerance_05(HandleRef pThis);

		/// <summary>
		/// Set/get the tolerance used when performing computations
		/// in display coordinates.
		/// </summary>
		// Token: 0x0600820C RID: 33292 RVA: 0x000BA164 File Offset: 0x000B8364
		public virtual int GetPixelTolerance()
		{
			return vtkPointPlacer.vtkPointPlacer_GetPixelTolerance_05(base.GetCppThis());
		}

		// Token: 0x0600820D RID: 33293
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointPlacer_GetPixelToleranceMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Set/get the tolerance used when performing computations
		/// in display coordinates.
		/// </summary>
		// Token: 0x0600820E RID: 33294 RVA: 0x000BA184 File Offset: 0x000B8384
		public virtual int GetPixelToleranceMaxValue()
		{
			return vtkPointPlacer.vtkPointPlacer_GetPixelToleranceMaxValue_06(base.GetCppThis());
		}

		// Token: 0x0600820F RID: 33295
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointPlacer_GetPixelToleranceMinValue_07(HandleRef pThis);

		/// <summary>
		/// Set/get the tolerance used when performing computations
		/// in display coordinates.
		/// </summary>
		// Token: 0x06008210 RID: 33296 RVA: 0x000BA1A4 File Offset: 0x000B83A4
		public virtual int GetPixelToleranceMinValue()
		{
			return vtkPointPlacer.vtkPointPlacer_GetPixelToleranceMinValue_07(base.GetCppThis());
		}

		// Token: 0x06008211 RID: 33297
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointPlacer_GetWorldTolerance_08(HandleRef pThis);

		/// <summary>
		/// Set/get the tolerance used when performing computations
		/// in world coordinates.
		/// </summary>
		// Token: 0x06008212 RID: 33298 RVA: 0x000BA1C4 File Offset: 0x000B83C4
		public virtual double GetWorldTolerance()
		{
			return vtkPointPlacer.vtkPointPlacer_GetWorldTolerance_08(base.GetCppThis());
		}

		// Token: 0x06008213 RID: 33299
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointPlacer_GetWorldToleranceMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Set/get the tolerance used when performing computations
		/// in world coordinates.
		/// </summary>
		// Token: 0x06008214 RID: 33300 RVA: 0x000BA1E4 File Offset: 0x000B83E4
		public virtual double GetWorldToleranceMaxValue()
		{
			return vtkPointPlacer.vtkPointPlacer_GetWorldToleranceMaxValue_09(base.GetCppThis());
		}

		// Token: 0x06008215 RID: 33301
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointPlacer_GetWorldToleranceMinValue_10(HandleRef pThis);

		/// <summary>
		/// Set/get the tolerance used when performing computations
		/// in world coordinates.
		/// </summary>
		// Token: 0x06008216 RID: 33302 RVA: 0x000BA204 File Offset: 0x000B8404
		public virtual double GetWorldToleranceMinValue()
		{
			return vtkPointPlacer.vtkPointPlacer_GetWorldToleranceMinValue_10(base.GetCppThis());
		}

		// Token: 0x06008217 RID: 33303
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointPlacer_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008218 RID: 33304 RVA: 0x000BA224 File Offset: 0x000B8424
		public override int IsA(string type)
		{
			return vtkPointPlacer.vtkPointPlacer_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06008219 RID: 33305
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointPlacer_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600821A RID: 33306 RVA: 0x000BA244 File Offset: 0x000B8444
		public new static int IsTypeOf(string type)
		{
			return vtkPointPlacer.vtkPointPlacer_IsTypeOf_12(type);
		}

		// Token: 0x0600821B RID: 33307
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointPlacer_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600821C RID: 33308 RVA: 0x000BA260 File Offset: 0x000B8460
		public new vtkPointPlacer NewInstance()
		{
			vtkPointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointPlacer.vtkPointPlacer_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600821D RID: 33309
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointPlacer_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600821E RID: 33310 RVA: 0x000BA2BC File Offset: 0x000B84BC
		public new static vtkPointPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkPointPlacer vtkPointPlacer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointPlacer.vtkPointPlacer_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointPlacer = (vtkPointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointPlacer.Register(null);
				}
			}
			return vtkPointPlacer;
		}

		// Token: 0x0600821F RID: 33311
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointPlacer_SetPixelTolerance_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the tolerance used when performing computations
		/// in display coordinates.
		/// </summary>
		// Token: 0x06008220 RID: 33312 RVA: 0x000BA33B File Offset: 0x000B853B
		public virtual void SetPixelTolerance(int _arg)
		{
			vtkPointPlacer.vtkPointPlacer_SetPixelTolerance_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06008221 RID: 33313
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointPlacer_SetWorldTolerance_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the tolerance used when performing computations
		/// in world coordinates.
		/// </summary>
		// Token: 0x06008222 RID: 33314 RVA: 0x000BA34B File Offset: 0x000B854B
		public virtual void SetWorldTolerance(double _arg)
		{
			vtkPointPlacer.vtkPointPlacer_SetWorldTolerance_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06008223 RID: 33315
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointPlacer_UpdateInternalState_18(HandleRef pThis);

		/// <summary>
		/// Called by the representation to give the placer a chance
		/// to update itself.
		/// </summary>
		// Token: 0x06008224 RID: 33316 RVA: 0x000BA35C File Offset: 0x000B855C
		public virtual int UpdateInternalState()
		{
			return vtkPointPlacer.vtkPointPlacer_UpdateInternalState_18(base.GetCppThis());
		}

		// Token: 0x06008225 RID: 33317
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointPlacer_UpdateNodeWorldPosition_19(HandleRef pThis, IntPtr worldPos, long nodePointId);

		/// <summary>
		/// Give the placer a chance to update the node information, if any. Most
		/// placers do not maintain any cached node information.
		/// vtkPolygonalSurfacePointPlacer is one that does. It stores the point
		/// id (id on the surface mesh) on which its drawn. The second argument
		/// may be used to pass that in.
		/// Update world position
		/// </summary>
		// Token: 0x06008226 RID: 33318 RVA: 0x000BA37C File Offset: 0x000B857C
		public virtual int UpdateNodeWorldPosition(IntPtr worldPos, long nodePointId)
		{
			return vtkPointPlacer.vtkPointPlacer_UpdateNodeWorldPosition_19(base.GetCppThis(), worldPos, nodePointId);
		}

		// Token: 0x06008227 RID: 33319
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointPlacer_UpdateWorldPosition_20(HandleRef pThis, HandleRef ren, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a current renderer, world position and orientation,
		/// update them according to the constraints of the placer.
		/// This method is typically used when UpdateContour is called
		/// on the representation, which must be called after changes
		/// are made to the constraints in the placer. A return
		/// value of 1 indicates that the point has been updated. A
		/// return value of 0 indicates that the point could not
		/// be updated and was left alone. By default this is a no-op -
		/// leaving the point as is.
		/// </summary>
		// Token: 0x06008228 RID: 33320 RVA: 0x000BA3A0 File Offset: 0x000B85A0
		public virtual int UpdateWorldPosition(vtkRenderer ren, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPointPlacer.vtkPointPlacer_UpdateWorldPosition_20(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), worldPos, worldOrient);
		}

		// Token: 0x06008229 RID: 33321
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointPlacer_ValidateDisplayPosition_21(HandleRef pThis, HandleRef arg0, IntPtr displayPos);

		/// <summary>
		/// Given a display position, check the validity of this position.
		/// </summary>
		// Token: 0x0600822A RID: 33322 RVA: 0x000BA3D8 File Offset: 0x000B85D8
		public virtual int ValidateDisplayPosition(vtkRenderer arg0, IntPtr displayPos)
		{
			return vtkPointPlacer.vtkPointPlacer_ValidateDisplayPosition_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), displayPos);
		}

		// Token: 0x0600822B RID: 33323
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointPlacer_ValidateWorldPosition_22(HandleRef pThis, IntPtr worldPos);

		/// <summary>
		/// Given a world position check the validity of this
		/// position according to the constraints of the placer.
		/// </summary>
		// Token: 0x0600822C RID: 33324 RVA: 0x000BA410 File Offset: 0x000B8610
		public virtual int ValidateWorldPosition(IntPtr worldPos)
		{
			return vtkPointPlacer.vtkPointPlacer_ValidateWorldPosition_22(base.GetCppThis(), worldPos);
		}

		// Token: 0x0600822D RID: 33325
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointPlacer_ValidateWorldPosition_23(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a world position and a world orientation,
		/// validate it according to the constraints of the placer.
		/// </summary>
		// Token: 0x0600822E RID: 33326 RVA: 0x000BA430 File Offset: 0x000B8630
		public virtual int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkPointPlacer.vtkPointPlacer_ValidateWorldPosition_23(base.GetCppThis(), worldPos, worldOrient);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B0D RID: 2829
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointPlacer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B0E RID: 2830
		public new static readonly string MRClassNameKey = "class vtkPointPlacer";
	}
}
