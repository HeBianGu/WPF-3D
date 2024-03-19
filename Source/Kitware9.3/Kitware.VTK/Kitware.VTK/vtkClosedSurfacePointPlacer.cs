using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkClosedSurfacePointPlacer
	/// </summary>
	/// <remarks>
	///    PointPlacer to constrain validity within a set of convex planes
	///
	/// This placer takes a set of boudning planes and constraints the validity
	/// within the supplied convex planes. It is used by the
	/// ParallelopPipedRepresentation to place constraints on the motion the
	/// handles within the parallelopiped.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkParallelopipedRepresentation
	/// </seealso>
	// Token: 0x020002F7 RID: 759
	public class vtkClosedSurfacePointPlacer : vtkPointPlacer
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060087EE RID: 34798 RVA: 0x000C2417 File Offset: 0x000C0617
		static vtkClosedSurfacePointPlacer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClosedSurfacePointPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClosedSurfacePointPlacer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060087EF RID: 34799 RVA: 0x000C243F File Offset: 0x000C063F
		public vtkClosedSurfacePointPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060087F0 RID: 34800
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClosedSurfacePointPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060087F1 RID: 34801 RVA: 0x000C2450 File Offset: 0x000C0650
		public new static vtkClosedSurfacePointPlacer New()
		{
			vtkClosedSurfacePointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClosedSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060087F2 RID: 34802 RVA: 0x000C24A4 File Offset: 0x000C06A4
		public vtkClosedSurfacePointPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060087F3 RID: 34803 RVA: 0x000C24E8 File Offset: 0x000C06E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060087F4 RID: 34804
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClosedSurfacePointPlacer_AddBoundingPlane_01(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x060087F5 RID: 34805 RVA: 0x000C24F4 File Offset: 0x000C06F4
		public void AddBoundingPlane(vtkPlane plane)
		{
			vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_AddBoundingPlane_01(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x060087F6 RID: 34806
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClosedSurfacePointPlacer_ComputeWorldPosition_02(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient);

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
		// Token: 0x060087F7 RID: 34807 RVA: 0x000C2524 File Offset: 0x000C0724
		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_ComputeWorldPosition_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, worldPos, worldOrient);
		}

		// Token: 0x060087F8 RID: 34808
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClosedSurfacePointPlacer_ComputeWorldPosition_03(HandleRef pThis, HandleRef ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Given a renderer, a display position and a reference position, "worldPos"
		/// is calculated as :
		/// Consider the line "L" that passes through the supplied "displayPos" and
		/// is parallel to the direction of projection of the camera. Clip this line
		/// segment with the parallelopiped, let's call it "L_segment". The computed
		/// world position, "worldPos" will be the point on "L_segment" that is
		/// closest to refWorldPos.
		/// NOTE: Note that a set of bounding planes must be supplied. The Oblique
		/// plane, if supplied is ignored.
		/// </summary>
		// Token: 0x060087F9 RID: 34809 RVA: 0x000C255C File Offset: 0x000C075C
		public override int ComputeWorldPosition(vtkRenderer ren, IntPtr displayPos, IntPtr refWorldPos, IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_ComputeWorldPosition_03(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), displayPos, refWorldPos, worldPos, worldOrient);
		}

		// Token: 0x060087FA RID: 34810
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClosedSurfacePointPlacer_GetBoundingPlanes_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x060087FB RID: 34811 RVA: 0x000C2598 File Offset: 0x000C0798
		public virtual vtkPlaneCollection GetBoundingPlanes()
		{
			vtkPlaneCollection vtkPlaneCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_GetBoundingPlanes_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060087FC RID: 34812
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClosedSurfacePointPlacer_GetMinimumDistance_05(HandleRef pThis);

		/// <summary>
		/// Give a world position check if it is valid - does
		/// it lie on the plane and within the bounds? Returns
		/// 1 if it is valid, 0 otherwise.
		/// </summary>
		// Token: 0x060087FD RID: 34813 RVA: 0x000C2608 File Offset: 0x000C0808
		public virtual double GetMinimumDistance()
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_GetMinimumDistance_05(base.GetCppThis());
		}

		// Token: 0x060087FE RID: 34814
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClosedSurfacePointPlacer_GetMinimumDistanceMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Give a world position check if it is valid - does
		/// it lie on the plane and within the bounds? Returns
		/// 1 if it is valid, 0 otherwise.
		/// </summary>
		// Token: 0x060087FF RID: 34815 RVA: 0x000C2628 File Offset: 0x000C0828
		public virtual double GetMinimumDistanceMaxValue()
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_GetMinimumDistanceMaxValue_06(base.GetCppThis());
		}

		// Token: 0x06008800 RID: 34816
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClosedSurfacePointPlacer_GetMinimumDistanceMinValue_07(HandleRef pThis);

		/// <summary>
		/// Give a world position check if it is valid - does
		/// it lie on the plane and within the bounds? Returns
		/// 1 if it is valid, 0 otherwise.
		/// </summary>
		// Token: 0x06008801 RID: 34817 RVA: 0x000C2648 File Offset: 0x000C0848
		public virtual double GetMinimumDistanceMinValue()
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_GetMinimumDistanceMinValue_07(base.GetCppThis());
		}

		// Token: 0x06008802 RID: 34818
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClosedSurfacePointPlacer_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008803 RID: 34819 RVA: 0x000C2668 File Offset: 0x000C0868
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06008804 RID: 34820
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClosedSurfacePointPlacer_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008805 RID: 34821 RVA: 0x000C2688 File Offset: 0x000C0888
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06008806 RID: 34822
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClosedSurfacePointPlacer_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008807 RID: 34823 RVA: 0x000C26A4 File Offset: 0x000C08A4
		public override int IsA(string type)
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06008808 RID: 34824
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClosedSurfacePointPlacer_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008809 RID: 34825 RVA: 0x000C26C4 File Offset: 0x000C08C4
		public new static int IsTypeOf(string type)
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_IsTypeOf_11(type);
		}

		// Token: 0x0600880A RID: 34826
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClosedSurfacePointPlacer_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x0600880B RID: 34827 RVA: 0x000C26E0 File Offset: 0x000C08E0
		public new vtkClosedSurfacePointPlacer NewInstance()
		{
			vtkClosedSurfacePointPlacer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClosedSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600880C RID: 34828
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClosedSurfacePointPlacer_RemoveAllBoundingPlanes_14(HandleRef pThis);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x0600880D RID: 34829 RVA: 0x000C273A File Offset: 0x000C093A
		public void RemoveAllBoundingPlanes()
		{
			vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_RemoveAllBoundingPlanes_14(base.GetCppThis());
		}

		// Token: 0x0600880E RID: 34830
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClosedSurfacePointPlacer_RemoveBoundingPlane_15(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x0600880F RID: 34831 RVA: 0x000C274C File Offset: 0x000C094C
		public void RemoveBoundingPlane(vtkPlane plane)
		{
			vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_RemoveBoundingPlane_15(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x06008810 RID: 34832
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClosedSurfacePointPlacer_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008811 RID: 34833 RVA: 0x000C277C File Offset: 0x000C097C
		public new static vtkClosedSurfacePointPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkClosedSurfacePointPlacer vtkClosedSurfacePointPlacer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClosedSurfacePointPlacer = (vtkClosedSurfacePointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClosedSurfacePointPlacer.Register(null);
				}
			}
			return vtkClosedSurfacePointPlacer;
		}

		// Token: 0x06008812 RID: 34834
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClosedSurfacePointPlacer_SetBoundingPlanes_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x06008813 RID: 34835 RVA: 0x000C27FC File Offset: 0x000C09FC
		public virtual void SetBoundingPlanes(vtkPlaneCollection arg0)
		{
			vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_SetBoundingPlanes_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008814 RID: 34836
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClosedSurfacePointPlacer_SetBoundingPlanes_18(HandleRef pThis, HandleRef planes);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x06008815 RID: 34837 RVA: 0x000C282C File Offset: 0x000C0A2C
		public void SetBoundingPlanes(vtkPlanes planes)
		{
			vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_SetBoundingPlanes_18(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}

		// Token: 0x06008816 RID: 34838
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClosedSurfacePointPlacer_SetMinimumDistance_19(HandleRef pThis, double _arg);

		/// <summary>
		/// Give a world position check if it is valid - does
		/// it lie on the plane and within the bounds? Returns
		/// 1 if it is valid, 0 otherwise.
		/// </summary>
		// Token: 0x06008817 RID: 34839 RVA: 0x000C285B File Offset: 0x000C0A5B
		public virtual void SetMinimumDistance(double _arg)
		{
			vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_SetMinimumDistance_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06008818 RID: 34840
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClosedSurfacePointPlacer_ValidateWorldPosition_20(HandleRef pThis, IntPtr worldPos);

		/// <summary>
		/// Give a world position check if it is valid - does
		/// it lie on the plane and within the bounds? Returns
		/// 1 if it is valid, 0 otherwise.
		/// </summary>
		// Token: 0x06008819 RID: 34841 RVA: 0x000C286C File Offset: 0x000C0A6C
		public override int ValidateWorldPosition(IntPtr worldPos)
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_ValidateWorldPosition_20(base.GetCppThis(), worldPos);
		}

		// Token: 0x0600881A RID: 34842
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClosedSurfacePointPlacer_ValidateWorldPosition_21(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Give a world position check if it is valid - does
		/// it lie on the plane and within the bounds? Returns
		/// 1 if it is valid, 0 otherwise.
		/// </summary>
		// Token: 0x0600881B RID: 34843 RVA: 0x000C288C File Offset: 0x000C0A8C
		public override int ValidateWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkClosedSurfacePointPlacer.vtkClosedSurfacePointPlacer_ValidateWorldPosition_21(base.GetCppThis(), worldPos, worldOrient);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B78 RID: 2936
		public new const string MRFullTypeName = "Kitware.VTK.vtkClosedSurfacePointPlacer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B79 RID: 2937
		public new static readonly string MRClassNameKey = "class vtkClosedSurfacePointPlacer";
	}
}
