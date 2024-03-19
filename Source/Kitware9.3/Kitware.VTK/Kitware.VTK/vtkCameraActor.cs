using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCameraActor
	/// </summary>
	/// <remarks>
	///    a frustum to represent a camera.
	///
	/// vtkCameraActor is an actor used to represent a camera by its wireframe
	/// frustum.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLight vtkConeSource vtkFrustumSource vtkCameraActor
	/// </seealso>
	// Token: 0x020007CA RID: 1994
	public class vtkCameraActor : vtkProp3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601466A RID: 83562 RVA: 0x001CE093 File Offset: 0x001CC293
		static vtkCameraActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCameraActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601466B RID: 83563 RVA: 0x001CE0BB File Offset: 0x001CC2BB
		public vtkCameraActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601466C RID: 83564
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601466D RID: 83565 RVA: 0x001CE0CC File Offset: 0x001CC2CC
		public new static vtkCameraActor New()
		{
			vtkCameraActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraActor.vtkCameraActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601466E RID: 83566 RVA: 0x001CE120 File Offset: 0x001CC320
		public vtkCameraActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCameraActor.vtkCameraActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601466F RID: 83567 RVA: 0x001CE164 File Offset: 0x001CC364
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014670 RID: 83568
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraActor_GetBounds_01(HandleRef pThis);

		/// <summary>
		/// Get the bounds for this Actor as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
		/// </summary>
		// Token: 0x06014671 RID: 83569 RVA: 0x001CE170 File Offset: 0x001CC370
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkCameraActor.vtkCameraActor_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014672 RID: 83570
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraActor_GetCamera_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The camera to represent. Initial value is NULL.
		/// </summary>
		// Token: 0x06014673 RID: 83571 RVA: 0x001CE1B8 File Offset: 0x001CC3B8
		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraActor.vtkCameraActor_GetCamera_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		// Token: 0x06014674 RID: 83572
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkCameraActor_GetMTime_03(HandleRef pThis);

		/// <summary>
		/// Get the actors mtime plus consider its properties and texture if set.
		/// </summary>
		// Token: 0x06014675 RID: 83573 RVA: 0x001CE228 File Offset: 0x001CC428
		public override ulong GetMTime()
		{
			return vtkCameraActor.vtkCameraActor_GetMTime_03(base.GetCppThis());
		}

		// Token: 0x06014676 RID: 83574
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraActor_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014677 RID: 83575 RVA: 0x001CE248 File Offset: 0x001CC448
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCameraActor.vtkCameraActor_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06014678 RID: 83576
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraActor_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014679 RID: 83577 RVA: 0x001CE268 File Offset: 0x001CC468
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCameraActor.vtkCameraActor_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601467A RID: 83578
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraActor_GetProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get property of the internal actor.
		/// </summary>
		// Token: 0x0601467B RID: 83579 RVA: 0x001CE284 File Offset: 0x001CC484
		public vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraActor.vtkCameraActor_GetProperty_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601467C RID: 83580
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCameraActor_GetWidthByHeightRatio_07(HandleRef pThis);

		/// <summary>
		/// Ratio between the width and the height of the frustum. Initial value is
		/// 1.0 (square)
		/// </summary>
		// Token: 0x0601467D RID: 83581 RVA: 0x001CE2F4 File Offset: 0x001CC4F4
		public virtual double GetWidthByHeightRatio()
		{
			return vtkCameraActor.vtkCameraActor_GetWidthByHeightRatio_07(base.GetCppThis());
		}

		// Token: 0x0601467E RID: 83582
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraActor_HasTranslucentPolygonalGeometry_08(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry? No.
		/// </summary>
		// Token: 0x0601467F RID: 83583 RVA: 0x001CE314 File Offset: 0x001CC514
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCameraActor.vtkCameraActor_HasTranslucentPolygonalGeometry_08(base.GetCppThis());
		}

		// Token: 0x06014680 RID: 83584
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraActor_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014681 RID: 83585 RVA: 0x001CE334 File Offset: 0x001CC534
		public override int IsA(string type)
		{
			return vtkCameraActor.vtkCameraActor_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06014682 RID: 83586
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraActor_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014683 RID: 83587 RVA: 0x001CE354 File Offset: 0x001CC554
		public new static int IsTypeOf(string type)
		{
			return vtkCameraActor.vtkCameraActor_IsTypeOf_10(type);
		}

		// Token: 0x06014684 RID: 83588
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraActor_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014685 RID: 83589 RVA: 0x001CE370 File Offset: 0x001CC570
		public new vtkCameraActor NewInstance()
		{
			vtkCameraActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraActor.vtkCameraActor_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014686 RID: 83590
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraActor_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06014687 RID: 83591 RVA: 0x001CE3CC File Offset: 0x001CC5CC
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCameraActor.vtkCameraActor_ReleaseGraphicsResources_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06014688 RID: 83592
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraActor_RenderOpaqueGeometry_14(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x06014689 RID: 83593 RVA: 0x001CE3FC File Offset: 0x001CC5FC
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkCameraActor.vtkCameraActor_RenderOpaqueGeometry_14(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0601468A RID: 83594
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraActor_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601468B RID: 83595 RVA: 0x001CE430 File Offset: 0x001CC630
		public new static vtkCameraActor SafeDownCast(vtkObjectBase o)
		{
			vtkCameraActor vtkCameraActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraActor.vtkCameraActor_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraActor = (vtkCameraActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraActor.Register(null);
				}
			}
			return vtkCameraActor;
		}

		// Token: 0x0601468C RID: 83596
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraActor_SetCamera_16(HandleRef pThis, HandleRef camera);

		/// <summary>
		/// The camera to represent. Initial value is NULL.
		/// </summary>
		// Token: 0x0601468D RID: 83597 RVA: 0x001CE4B0 File Offset: 0x001CC6B0
		public void SetCamera(vtkCamera camera)
		{
			vtkCameraActor.vtkCameraActor_SetCamera_16(base.GetCppThis(), (camera == null) ? default(HandleRef) : camera.GetCppThis());
		}

		// Token: 0x0601468E RID: 83598
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraActor_SetProperty_17(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set property of the internal actor.
		/// </summary>
		// Token: 0x0601468F RID: 83599 RVA: 0x001CE4E0 File Offset: 0x001CC6E0
		public void SetProperty(vtkProperty p)
		{
			vtkCameraActor.vtkCameraActor_SetProperty_17(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x06014690 RID: 83600
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraActor_SetWidthByHeightRatio_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Ratio between the width and the height of the frustum. Initial value is
		/// 1.0 (square)
		/// </summary>
		// Token: 0x06014691 RID: 83601 RVA: 0x001CE50F File Offset: 0x001CC70F
		public virtual void SetWidthByHeightRatio(double _arg)
		{
			vtkCameraActor.vtkCameraActor_SetWidthByHeightRatio_18(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017B2 RID: 6066
		public new const string MRFullTypeName = "Kitware.VTK.vtkCameraActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017B3 RID: 6067
		public new static readonly string MRClassNameKey = "class vtkCameraActor";
	}
}
