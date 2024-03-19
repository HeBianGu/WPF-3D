using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAngleRepresentation3D
	/// </summary>
	/// <remarks>
	///    represent the vtkAngleWidget
	///
	/// The vtkAngleRepresentation3D is a representation for the
	/// vtkAngleWidget. This representation consists of two rays and three
	/// vtkHandleRepresentations to place and manipulate the three points defining
	/// the angle representation. (Note: the three points are referred to as Point1,
	/// Center, and Point2, at the two end points (Point1 and Point2) and Center
	/// (around which the angle is measured). This particular implementation is a
	/// 3D representation, meaning that it draws in the overlay plane.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAngleWidget vtkHandleRepresentation
	/// </seealso>
	// Token: 0x020002BA RID: 698
	public class vtkAngleRepresentation3D : vtkAngleRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007E53 RID: 32339 RVA: 0x000B53CB File Offset: 0x000B35CB
		static vtkAngleRepresentation3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAngleRepresentation3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAngleRepresentation3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007E54 RID: 32340 RVA: 0x000B53F3 File Offset: 0x000B35F3
		public vtkAngleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007E55 RID: 32341
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x06007E56 RID: 32342 RVA: 0x000B5404 File Offset: 0x000B3604
		public new static vtkAngleRepresentation3D New()
		{
			vtkAngleRepresentation3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation3D.vtkAngleRepresentation3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAngleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x06007E57 RID: 32343 RVA: 0x000B5458 File Offset: 0x000B3658
		public vtkAngleRepresentation3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAngleRepresentation3D.vtkAngleRepresentation3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007E58 RID: 32344 RVA: 0x000B549C File Offset: 0x000B369C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007E59 RID: 32345
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation3D_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Method defined by vtkWidgetRepresentation superclass and
		/// needed here.
		/// </summary>
		// Token: 0x06007E5A RID: 32346 RVA: 0x000B54A7 File Offset: 0x000B36A7
		public override void BuildRepresentation()
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06007E5B RID: 32347
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAngleRepresentation3D_GetAngle_02(HandleRef pThis);

		/// <summary>
		/// Satisfy the superclasses API. Angle returned is in radians.
		/// </summary>
		// Token: 0x06007E5C RID: 32348 RVA: 0x000B54B8 File Offset: 0x000B36B8
		public override double GetAngle()
		{
			return vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetAngle_02(base.GetCppThis());
		}

		// Token: 0x06007E5D RID: 32349
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation3D_GetArc_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the three leaders used to create this representation.
		/// By obtaining these leaders the user can set the appropriate
		/// properties, etc.
		/// </summary>
		// Token: 0x06007E5E RID: 32350 RVA: 0x000B54D8 File Offset: 0x000B36D8
		public virtual vtkActor GetArc()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetArc_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		// Token: 0x06007E5F RID: 32351
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation3D_GetCenterDisplayPosition_04(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E60 RID: 32352 RVA: 0x000B5547 File Offset: 0x000B3747
		public override void GetCenterDisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetCenterDisplayPosition_04(base.GetCppThis(), pos);
		}

		// Token: 0x06007E61 RID: 32353
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation3D_GetCenterWorldPosition_05(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E62 RID: 32354 RVA: 0x000B5557 File Offset: 0x000B3757
		public override void GetCenterWorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetCenterWorldPosition_05(base.GetCppThis(), pos);
		}

		// Token: 0x06007E63 RID: 32355
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAngleRepresentation3D_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007E64 RID: 32356 RVA: 0x000B5568 File Offset: 0x000B3768
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06007E65 RID: 32357
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAngleRepresentation3D_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007E66 RID: 32358 RVA: 0x000B5588 File Offset: 0x000B3788
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06007E67 RID: 32359
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation3D_GetPoint1DisplayPosition_08(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E68 RID: 32360 RVA: 0x000B55A2 File Offset: 0x000B37A2
		public override void GetPoint1DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetPoint1DisplayPosition_08(base.GetCppThis(), pos);
		}

		// Token: 0x06007E69 RID: 32361
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation3D_GetPoint1WorldPosition_09(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E6A RID: 32362 RVA: 0x000B55B2 File Offset: 0x000B37B2
		public override void GetPoint1WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetPoint1WorldPosition_09(base.GetCppThis(), pos);
		}

		// Token: 0x06007E6B RID: 32363
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation3D_GetPoint2DisplayPosition_10(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E6C RID: 32364 RVA: 0x000B55C2 File Offset: 0x000B37C2
		public override void GetPoint2DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetPoint2DisplayPosition_10(base.GetCppThis(), pos);
		}

		// Token: 0x06007E6D RID: 32365
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation3D_GetPoint2WorldPosition_11(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E6E RID: 32366 RVA: 0x000B55D2 File Offset: 0x000B37D2
		public override void GetPoint2WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetPoint2WorldPosition_11(base.GetCppThis(), pos);
		}

		// Token: 0x06007E6F RID: 32367
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation3D_GetRay1_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the three leaders used to create this representation.
		/// By obtaining these leaders the user can set the appropriate
		/// properties, etc.
		/// </summary>
		// Token: 0x06007E70 RID: 32368 RVA: 0x000B55E4 File Offset: 0x000B37E4
		public virtual vtkActor GetRay1()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetRay1_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		// Token: 0x06007E71 RID: 32369
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation3D_GetRay2_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the three leaders used to create this representation.
		/// By obtaining these leaders the user can set the appropriate
		/// properties, etc.
		/// </summary>
		// Token: 0x06007E72 RID: 32370 RVA: 0x000B5654 File Offset: 0x000B3854
		public virtual vtkActor GetRay2()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetRay2_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		// Token: 0x06007E73 RID: 32371
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation3D_GetTextActor_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the three leaders used to create this representation.
		/// By obtaining these leaders the user can set the appropriate
		/// properties, etc.
		/// </summary>
		// Token: 0x06007E74 RID: 32372 RVA: 0x000B56C4 File Offset: 0x000B38C4
		public virtual vtkFollower GetTextActor()
		{
			vtkFollower vtkFollower = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetTextActor_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFollower = (vtkFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFollower.Register(null);
				}
			}
			return vtkFollower;
		}

		// Token: 0x06007E75 RID: 32373
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation3D_GetTextActorScale_15(HandleRef pThis);

		/// <summary>
		/// Scale text.
		/// </summary>
		// Token: 0x06007E76 RID: 32374 RVA: 0x000B5734 File Offset: 0x000B3934
		public virtual IntPtr GetTextActorScale()
		{
			return vtkAngleRepresentation3D.vtkAngleRepresentation3D_GetTextActorScale_15(base.GetCppThis());
		}

		// Token: 0x06007E77 RID: 32375
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleRepresentation3D_HasTranslucentPolygonalGeometry_16(HandleRef pThis);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06007E78 RID: 32376 RVA: 0x000B5754 File Offset: 0x000B3954
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkAngleRepresentation3D.vtkAngleRepresentation3D_HasTranslucentPolygonalGeometry_16(base.GetCppThis());
		}

		// Token: 0x06007E79 RID: 32377
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleRepresentation3D_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007E7A RID: 32378 RVA: 0x000B5774 File Offset: 0x000B3974
		public override int IsA(string type)
		{
			return vtkAngleRepresentation3D.vtkAngleRepresentation3D_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x06007E7B RID: 32379
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleRepresentation3D_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007E7C RID: 32380 RVA: 0x000B5794 File Offset: 0x000B3994
		public new static int IsTypeOf(string type)
		{
			return vtkAngleRepresentation3D.vtkAngleRepresentation3D_IsTypeOf_18(type);
		}

		// Token: 0x06007E7D RID: 32381
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation3D_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007E7E RID: 32382 RVA: 0x000B57B0 File Offset: 0x000B39B0
		public new vtkAngleRepresentation3D NewInstance()
		{
			vtkAngleRepresentation3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation3D.vtkAngleRepresentation3D_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAngleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007E7F RID: 32383
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation3D_ReleaseGraphicsResources_21(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06007E80 RID: 32384 RVA: 0x000B580C File Offset: 0x000B3A0C
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_ReleaseGraphicsResources_21(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x06007E81 RID: 32385
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleRepresentation3D_RenderOpaqueGeometry_22(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06007E82 RID: 32386 RVA: 0x000B583C File Offset: 0x000B3A3C
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkAngleRepresentation3D.vtkAngleRepresentation3D_RenderOpaqueGeometry_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06007E83 RID: 32387
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleRepresentation3D_RenderTranslucentPolygonalGeometry_23(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06007E84 RID: 32388 RVA: 0x000B5870 File Offset: 0x000B3A70
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkAngleRepresentation3D.vtkAngleRepresentation3D_RenderTranslucentPolygonalGeometry_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06007E85 RID: 32389
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation3D_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007E86 RID: 32390 RVA: 0x000B58A4 File Offset: 0x000B3AA4
		public new static vtkAngleRepresentation3D SafeDownCast(vtkObjectBase o)
		{
			vtkAngleRepresentation3D vtkAngleRepresentation3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation3D.vtkAngleRepresentation3D_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAngleRepresentation3D = (vtkAngleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAngleRepresentation3D.Register(null);
				}
			}
			return vtkAngleRepresentation3D;
		}

		// Token: 0x06007E87 RID: 32391
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation3D_SetCenterDisplayPosition_25(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E88 RID: 32392 RVA: 0x000B5923 File Offset: 0x000B3B23
		public override void SetCenterDisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_SetCenterDisplayPosition_25(base.GetCppThis(), pos);
		}

		// Token: 0x06007E89 RID: 32393
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation3D_SetCenterWorldPosition_26(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E8A RID: 32394 RVA: 0x000B5933 File Offset: 0x000B3B33
		public virtual void SetCenterWorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_SetCenterWorldPosition_26(base.GetCppThis(), pos);
		}

		// Token: 0x06007E8B RID: 32395
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation3D_SetPoint1DisplayPosition_27(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E8C RID: 32396 RVA: 0x000B5943 File Offset: 0x000B3B43
		public override void SetPoint1DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_SetPoint1DisplayPosition_27(base.GetCppThis(), pos);
		}

		// Token: 0x06007E8D RID: 32397
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation3D_SetPoint1WorldPosition_28(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E8E RID: 32398 RVA: 0x000B5953 File Offset: 0x000B3B53
		public virtual void SetPoint1WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_SetPoint1WorldPosition_28(base.GetCppThis(), pos);
		}

		// Token: 0x06007E8F RID: 32399
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation3D_SetPoint2DisplayPosition_29(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E90 RID: 32400 RVA: 0x000B5963 File Offset: 0x000B3B63
		public override void SetPoint2DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_SetPoint2DisplayPosition_29(base.GetCppThis(), pos);
		}

		// Token: 0x06007E91 RID: 32401
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation3D_SetPoint2WorldPosition_30(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E92 RID: 32402 RVA: 0x000B5973 File Offset: 0x000B3B73
		public virtual void SetPoint2WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_SetPoint2WorldPosition_30(base.GetCppThis(), pos);
		}

		// Token: 0x06007E93 RID: 32403
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation3D_SetTextActorScale_31(HandleRef pThis, IntPtr scale);

		/// <summary>
		/// Scale text.
		/// </summary>
		// Token: 0x06007E94 RID: 32404 RVA: 0x000B5983 File Offset: 0x000B3B83
		public virtual void SetTextActorScale(IntPtr scale)
		{
			vtkAngleRepresentation3D.vtkAngleRepresentation3D_SetTextActorScale_31(base.GetCppThis(), scale);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000AA8 RID: 2728
		public new const string MRFullTypeName = "Kitware.VTK.vtkAngleRepresentation3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000AA9 RID: 2729
		public new static readonly string MRClassNameKey = "class vtkAngleRepresentation3D";
	}
}
