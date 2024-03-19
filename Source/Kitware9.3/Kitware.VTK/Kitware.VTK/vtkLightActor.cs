using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLightActor
	/// </summary>
	/// <remarks>
	///    a cone and a frustum to represent a spotlight.
	///
	/// vtkLightActor is a composite actor used to represent a spotlight. The cone
	/// angle is equal to the spotlight angle, the cone apex is at the position of
	/// the light, the direction of the light goes from the cone apex to the center
	/// of the base of the cone. The square frustum position is the light position,
	/// the frustum focal point is in the direction of the light direction. The
	/// frustum vertical view angle (aperture) (this is also the horizontal view
	/// angle as the frustum is square) is equal to twice the cone angle. The
	/// clipping range of the frustum is arbitrary set by the user
	/// (initially at 0.5,11.0).
	///
	/// @warning
	/// Right now only spotlight are supported but directional light might be
	/// supported in the future.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLight vtkConeSource vtkFrustumSource vtkCameraActor
	/// </seealso>
	// Token: 0x020007EC RID: 2028
	public class vtkLightActor : vtkProp3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014DAA RID: 85418 RVA: 0x001D7F82 File Offset: 0x001D6182
		static vtkLightActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLightActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLightActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014DAB RID: 85419 RVA: 0x001D7FAA File Offset: 0x001D61AA
		public vtkLightActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014DAC RID: 85420
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DAD RID: 85421 RVA: 0x001D7FB8 File Offset: 0x001D61B8
		public new static vtkLightActor New()
		{
			vtkLightActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightActor.vtkLightActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DAE RID: 85422 RVA: 0x001D800C File Offset: 0x001D620C
		public vtkLightActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLightActor.vtkLightActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014DAF RID: 85423 RVA: 0x001D8050 File Offset: 0x001D6250
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014DB0 RID: 85424
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightActor_GetBounds_01(HandleRef pThis);

		/// <summary>
		/// Get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
		/// </summary>
		// Token: 0x06014DB1 RID: 85425 RVA: 0x001D805C File Offset: 0x001D625C
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkLightActor.vtkLightActor_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014DB2 RID: 85426
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightActor_GetClippingRange_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of the near and far clipping planes along the
		/// direction of projection.  Both of these values must be positive.
		/// Initial values are  (0.5,11.0)
		/// </summary>
		// Token: 0x06014DB3 RID: 85427 RVA: 0x001D80A4 File Offset: 0x001D62A4
		public virtual double[] GetClippingRange()
		{
			IntPtr intPtr = vtkLightActor.vtkLightActor_GetClippingRange_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014DB4 RID: 85428
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightActor_GetClippingRange_03(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set/Get the location of the near and far clipping planes along the
		/// direction of projection.  Both of these values must be positive.
		/// Initial values are  (0.5,11.0)
		/// </summary>
		// Token: 0x06014DB5 RID: 85429 RVA: 0x001D80EC File Offset: 0x001D62EC
		public virtual void GetClippingRange(ref double _arg1, ref double _arg2)
		{
			vtkLightActor.vtkLightActor_GetClippingRange_03(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06014DB6 RID: 85430
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightActor_GetClippingRange_04(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the location of the near and far clipping planes along the
		/// direction of projection.  Both of these values must be positive.
		/// Initial values are  (0.5,11.0)
		/// </summary>
		// Token: 0x06014DB7 RID: 85431 RVA: 0x001D80FD File Offset: 0x001D62FD
		public virtual void GetClippingRange(IntPtr _arg)
		{
			vtkLightActor.vtkLightActor_GetClippingRange_04(base.GetCppThis(), _arg);
		}

		// Token: 0x06014DB8 RID: 85432
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightActor_GetConeProperty_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get properties of the different actors used to represent
		/// the camera
		/// </summary>
		// Token: 0x06014DB9 RID: 85433 RVA: 0x001D8110 File Offset: 0x001D6310
		public vtkProperty GetConeProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightActor.vtkLightActor_GetConeProperty_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06014DBA RID: 85434
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightActor_GetFrustumProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get properties of the different actors used to represent
		/// the camera
		/// </summary>
		// Token: 0x06014DBB RID: 85435 RVA: 0x001D8180 File Offset: 0x001D6380
		public vtkProperty GetFrustumProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightActor.vtkLightActor_GetFrustumProperty_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06014DBC RID: 85436
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightActor_GetLight_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The spotlight to represent. Initial value is NULL.
		/// </summary>
		// Token: 0x06014DBD RID: 85437 RVA: 0x001D81F0 File Offset: 0x001D63F0
		public virtual vtkLight GetLight()
		{
			vtkLight vtkLight = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightActor.vtkLightActor_GetLight_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLight = (vtkLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLight.Register(null);
				}
			}
			return vtkLight;
		}

		// Token: 0x06014DBE RID: 85438
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkLightActor_GetMTime_08(HandleRef pThis);

		/// <summary>
		/// Get the actors mtime plus consider its properties and texture if set.
		/// </summary>
		// Token: 0x06014DBF RID: 85439 RVA: 0x001D8260 File Offset: 0x001D6460
		public override ulong GetMTime()
		{
			return vtkLightActor.vtkLightActor_GetMTime_08(base.GetCppThis());
		}

		// Token: 0x06014DC0 RID: 85440
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLightActor_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DC1 RID: 85441 RVA: 0x001D8280 File Offset: 0x001D6480
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLightActor.vtkLightActor_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06014DC2 RID: 85442
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLightActor_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DC3 RID: 85443 RVA: 0x001D82A0 File Offset: 0x001D64A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLightActor.vtkLightActor_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06014DC4 RID: 85444
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightActor_HasTranslucentPolygonalGeometry_11(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry? No.
		/// </summary>
		// Token: 0x06014DC5 RID: 85445 RVA: 0x001D82BC File Offset: 0x001D64BC
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkLightActor.vtkLightActor_HasTranslucentPolygonalGeometry_11(base.GetCppThis());
		}

		// Token: 0x06014DC6 RID: 85446
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightActor_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DC7 RID: 85447 RVA: 0x001D82DC File Offset: 0x001D64DC
		public override int IsA(string type)
		{
			return vtkLightActor.vtkLightActor_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06014DC8 RID: 85448
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightActor_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DC9 RID: 85449 RVA: 0x001D82FC File Offset: 0x001D64FC
		public new static int IsTypeOf(string type)
		{
			return vtkLightActor.vtkLightActor_IsTypeOf_13(type);
		}

		// Token: 0x06014DCA RID: 85450
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightActor_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DCB RID: 85451 RVA: 0x001D8318 File Offset: 0x001D6518
		public new vtkLightActor NewInstance()
		{
			vtkLightActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightActor.vtkLightActor_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014DCC RID: 85452
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightActor_ReleaseGraphicsResources_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06014DCD RID: 85453 RVA: 0x001D8374 File Offset: 0x001D6574
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLightActor.vtkLightActor_ReleaseGraphicsResources_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06014DCE RID: 85454
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightActor_RenderOpaqueGeometry_17(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x06014DCF RID: 85455 RVA: 0x001D83A4 File Offset: 0x001D65A4
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkLightActor.vtkLightActor_RenderOpaqueGeometry_17(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06014DD0 RID: 85456
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightActor_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DD1 RID: 85457 RVA: 0x001D83D8 File Offset: 0x001D65D8
		public new static vtkLightActor SafeDownCast(vtkObjectBase o)
		{
			vtkLightActor vtkLightActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightActor.vtkLightActor_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLightActor = (vtkLightActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLightActor.Register(null);
				}
			}
			return vtkLightActor;
		}

		// Token: 0x06014DD2 RID: 85458
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightActor_SetClippingRange_19(HandleRef pThis, double dNear, double dFar);

		/// <summary>
		/// Set/Get the location of the near and far clipping planes along the
		/// direction of projection.  Both of these values must be positive.
		/// Initial values are  (0.5,11.0)
		/// </summary>
		// Token: 0x06014DD3 RID: 85459 RVA: 0x001D8457 File Offset: 0x001D6657
		public void SetClippingRange(double dNear, double dFar)
		{
			vtkLightActor.vtkLightActor_SetClippingRange_19(base.GetCppThis(), dNear, dFar);
		}

		// Token: 0x06014DD4 RID: 85460
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightActor_SetClippingRange_20(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set/Get the location of the near and far clipping planes along the
		/// direction of projection.  Both of these values must be positive.
		/// Initial values are  (0.5,11.0)
		/// </summary>
		// Token: 0x06014DD5 RID: 85461 RVA: 0x001D8468 File Offset: 0x001D6668
		public void SetClippingRange(IntPtr a)
		{
			vtkLightActor.vtkLightActor_SetClippingRange_20(base.GetCppThis(), a);
		}

		// Token: 0x06014DD6 RID: 85462
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightActor_SetLight_21(HandleRef pThis, HandleRef light);

		/// <summary>
		/// The spotlight to represent. Initial value is NULL.
		/// </summary>
		// Token: 0x06014DD7 RID: 85463 RVA: 0x001D8478 File Offset: 0x001D6678
		public void SetLight(vtkLight light)
		{
			vtkLightActor.vtkLightActor_SetLight_21(base.GetCppThis(), (light == null) ? default(HandleRef) : light.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400180E RID: 6158
		public new const string MRFullTypeName = "Kitware.VTK.vtkLightActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400180F RID: 6159
		public new static readonly string MRClassNameKey = "class vtkLightActor";
	}
}
