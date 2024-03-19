using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAngleRepresentation2D
	/// </summary>
	/// <remarks>
	///    represent the vtkAngleWidget
	///
	/// The vtkAngleRepresentation2D is a representation for the
	/// vtkAngleWidget. This representation consists of two rays and three
	/// vtkHandleRepresentations to place and manipulate the three points defining
	/// the angle representation. (Note: the three points are referred to as Point1,
	/// Center, and Point2, at the two end points (Point1 and Point2) and Center
	/// (around which the angle is measured). This particular implementation is a
	/// 2D representation, meaning that it draws in the overlay plane.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAngleWidget vtkHandleRepresentation
	/// </seealso>
	// Token: 0x020002B9 RID: 697
	public class vtkAngleRepresentation2D : vtkAngleRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007E17 RID: 32279 RVA: 0x000B4EB7 File Offset: 0x000B30B7
		static vtkAngleRepresentation2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAngleRepresentation2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAngleRepresentation2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007E18 RID: 32280 RVA: 0x000B4EDF File Offset: 0x000B30DF
		public vtkAngleRepresentation2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007E19 RID: 32281
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x06007E1A RID: 32282 RVA: 0x000B4EF0 File Offset: 0x000B30F0
		public new static vtkAngleRepresentation2D New()
		{
			vtkAngleRepresentation2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation2D.vtkAngleRepresentation2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAngleRepresentation2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x06007E1B RID: 32283 RVA: 0x000B4F44 File Offset: 0x000B3144
		public vtkAngleRepresentation2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAngleRepresentation2D.vtkAngleRepresentation2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007E1C RID: 32284 RVA: 0x000B4F88 File Offset: 0x000B3188
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007E1D RID: 32285
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation2D_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Method defined by vtkWidgetRepresentation superclass and
		/// needed here.
		/// </summary>
		// Token: 0x06007E1E RID: 32286 RVA: 0x000B4F93 File Offset: 0x000B3193
		public override void BuildRepresentation()
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06007E1F RID: 32287
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAngleRepresentation2D_GetAngle_02(HandleRef pThis);

		/// <summary>
		/// Satisfy the superclasses API.
		/// </summary>
		// Token: 0x06007E20 RID: 32288 RVA: 0x000B4FA4 File Offset: 0x000B31A4
		public override double GetAngle()
		{
			return vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetAngle_02(base.GetCppThis());
		}

		// Token: 0x06007E21 RID: 32289
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation2D_GetArc_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the three leaders used to create this representation.
		/// By obtaining these leaders the user can set the appropriate
		/// properties, etc.
		/// </summary>
		// Token: 0x06007E22 RID: 32290 RVA: 0x000B4FC4 File Offset: 0x000B31C4
		public virtual vtkLeaderActor2D GetArc()
		{
			vtkLeaderActor2D vtkLeaderActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetArc_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLeaderActor2D = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLeaderActor2D.Register(null);
				}
			}
			return vtkLeaderActor2D;
		}

		// Token: 0x06007E23 RID: 32291
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation2D_GetCenterDisplayPosition_04(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E24 RID: 32292 RVA: 0x000B5033 File Offset: 0x000B3233
		public override void GetCenterDisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetCenterDisplayPosition_04(base.GetCppThis(), pos);
		}

		// Token: 0x06007E25 RID: 32293
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation2D_GetCenterWorldPosition_05(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E26 RID: 32294 RVA: 0x000B5043 File Offset: 0x000B3243
		public override void GetCenterWorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetCenterWorldPosition_05(base.GetCppThis(), pos);
		}

		// Token: 0x06007E27 RID: 32295
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAngleRepresentation2D_GetForce3DArcPlacement_06(HandleRef pThis);

		/// <summary>
		/// Set/Get if the widget should use screen space or world space coordinates
		/// when trying to place the arc. Screen space may produce nicer results but
		/// breaks easily when interacting with the camera.
		///
		/// Default is false (screen space)
		/// </summary>
		// Token: 0x06007E28 RID: 32296 RVA: 0x000B5054 File Offset: 0x000B3254
		public virtual bool GetForce3DArcPlacement()
		{
			return vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetForce3DArcPlacement_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06007E29 RID: 32297
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAngleRepresentation2D_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007E2A RID: 32298 RVA: 0x000B507C File Offset: 0x000B327C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06007E2B RID: 32299
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAngleRepresentation2D_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007E2C RID: 32300 RVA: 0x000B509C File Offset: 0x000B329C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06007E2D RID: 32301
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation2D_GetPoint1DisplayPosition_09(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E2E RID: 32302 RVA: 0x000B50B6 File Offset: 0x000B32B6
		public override void GetPoint1DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetPoint1DisplayPosition_09(base.GetCppThis(), pos);
		}

		// Token: 0x06007E2F RID: 32303
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation2D_GetPoint1WorldPosition_10(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E30 RID: 32304 RVA: 0x000B50C6 File Offset: 0x000B32C6
		public override void GetPoint1WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetPoint1WorldPosition_10(base.GetCppThis(), pos);
		}

		// Token: 0x06007E31 RID: 32305
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation2D_GetPoint2DisplayPosition_11(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E32 RID: 32306 RVA: 0x000B50D6 File Offset: 0x000B32D6
		public override void GetPoint2DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetPoint2DisplayPosition_11(base.GetCppThis(), pos);
		}

		// Token: 0x06007E33 RID: 32307
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation2D_GetPoint2WorldPosition_12(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E34 RID: 32308 RVA: 0x000B50E6 File Offset: 0x000B32E6
		public override void GetPoint2WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetPoint2WorldPosition_12(base.GetCppThis(), pos);
		}

		// Token: 0x06007E35 RID: 32309
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation2D_GetRay1_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the three leaders used to create this representation.
		/// By obtaining these leaders the user can set the appropriate
		/// properties, etc.
		/// </summary>
		// Token: 0x06007E36 RID: 32310 RVA: 0x000B50F8 File Offset: 0x000B32F8
		public virtual vtkLeaderActor2D GetRay1()
		{
			vtkLeaderActor2D vtkLeaderActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetRay1_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLeaderActor2D = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLeaderActor2D.Register(null);
				}
			}
			return vtkLeaderActor2D;
		}

		// Token: 0x06007E37 RID: 32311
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation2D_GetRay2_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the three leaders used to create this representation.
		/// By obtaining these leaders the user can set the appropriate
		/// properties, etc.
		/// </summary>
		// Token: 0x06007E38 RID: 32312 RVA: 0x000B5168 File Offset: 0x000B3368
		public virtual vtkLeaderActor2D GetRay2()
		{
			vtkLeaderActor2D vtkLeaderActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation2D.vtkAngleRepresentation2D_GetRay2_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLeaderActor2D = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLeaderActor2D.Register(null);
				}
			}
			return vtkLeaderActor2D;
		}

		// Token: 0x06007E39 RID: 32313
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleRepresentation2D_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007E3A RID: 32314 RVA: 0x000B51D8 File Offset: 0x000B33D8
		public override int IsA(string type)
		{
			return vtkAngleRepresentation2D.vtkAngleRepresentation2D_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06007E3B RID: 32315
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleRepresentation2D_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007E3C RID: 32316 RVA: 0x000B51F8 File Offset: 0x000B33F8
		public new static int IsTypeOf(string type)
		{
			return vtkAngleRepresentation2D.vtkAngleRepresentation2D_IsTypeOf_16(type);
		}

		// Token: 0x06007E3D RID: 32317
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation2D_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007E3E RID: 32318 RVA: 0x000B5214 File Offset: 0x000B3414
		public new vtkAngleRepresentation2D NewInstance()
		{
			vtkAngleRepresentation2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation2D.vtkAngleRepresentation2D_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAngleRepresentation2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007E3F RID: 32319
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation2D_ReleaseGraphicsResources_19(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06007E40 RID: 32320 RVA: 0x000B5270 File Offset: 0x000B3470
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_ReleaseGraphicsResources_19(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x06007E41 RID: 32321
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAngleRepresentation2D_RenderOverlay_20(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06007E42 RID: 32322 RVA: 0x000B52A0 File Offset: 0x000B34A0
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkAngleRepresentation2D.vtkAngleRepresentation2D_RenderOverlay_20(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06007E43 RID: 32323
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAngleRepresentation2D_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06007E44 RID: 32324 RVA: 0x000B52D4 File Offset: 0x000B34D4
		public new static vtkAngleRepresentation2D SafeDownCast(vtkObjectBase o)
		{
			vtkAngleRepresentation2D vtkAngleRepresentation2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAngleRepresentation2D.vtkAngleRepresentation2D_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAngleRepresentation2D = (vtkAngleRepresentation2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAngleRepresentation2D.Register(null);
				}
			}
			return vtkAngleRepresentation2D;
		}

		// Token: 0x06007E45 RID: 32325
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation2D_SetCenterDisplayPosition_22(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E46 RID: 32326 RVA: 0x000B5353 File Offset: 0x000B3553
		public override void SetCenterDisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_SetCenterDisplayPosition_22(base.GetCppThis(), pos);
		}

		// Token: 0x06007E47 RID: 32327
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation2D_SetCenterWorldPosition_23(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E48 RID: 32328 RVA: 0x000B5363 File Offset: 0x000B3563
		public void SetCenterWorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_SetCenterWorldPosition_23(base.GetCppThis(), pos);
		}

		// Token: 0x06007E49 RID: 32329
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation2D_SetForce3DArcPlacement_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if the widget should use screen space or world space coordinates
		/// when trying to place the arc. Screen space may produce nicer results but
		/// breaks easily when interacting with the camera.
		///
		/// Default is false (screen space)
		/// </summary>
		// Token: 0x06007E4A RID: 32330 RVA: 0x000B5373 File Offset: 0x000B3573
		public virtual void SetForce3DArcPlacement(bool _arg)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_SetForce3DArcPlacement_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06007E4B RID: 32331
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation2D_SetPoint1DisplayPosition_25(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E4C RID: 32332 RVA: 0x000B538B File Offset: 0x000B358B
		public override void SetPoint1DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_SetPoint1DisplayPosition_25(base.GetCppThis(), pos);
		}

		// Token: 0x06007E4D RID: 32333
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation2D_SetPoint1WorldPosition_26(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E4E RID: 32334 RVA: 0x000B539B File Offset: 0x000B359B
		public void SetPoint1WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_SetPoint1WorldPosition_26(base.GetCppThis(), pos);
		}

		// Token: 0x06007E4F RID: 32335
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation2D_SetPoint2DisplayPosition_27(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E50 RID: 32336 RVA: 0x000B53AB File Offset: 0x000B35AB
		public override void SetPoint2DisplayPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_SetPoint2DisplayPosition_27(base.GetCppThis(), pos);
		}

		// Token: 0x06007E51 RID: 32337
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAngleRepresentation2D_SetPoint2WorldPosition_28(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06007E52 RID: 32338 RVA: 0x000B53BB File Offset: 0x000B35BB
		public void SetPoint2WorldPosition(IntPtr pos)
		{
			vtkAngleRepresentation2D.vtkAngleRepresentation2D_SetPoint2WorldPosition_28(base.GetCppThis(), pos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000AA6 RID: 2726
		public new const string MRFullTypeName = "Kitware.VTK.vtkAngleRepresentation2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000AA7 RID: 2727
		public new static readonly string MRClassNameKey = "class vtkAngleRepresentation2D";
	}
}
