using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProp3DFollower
	/// </summary>
	/// <remarks>
	///    a vtkProp3D that always faces the camera
	///
	/// vtkProp3DFollower is a type of vtkProp3D that always faces the camera.
	/// More specifically it will not change its position or scale,
	/// but it will continually update its orientation so that it is right side
	/// up and facing the camera. This is typically used for complex billboards
	/// or props that need to face the viewer at all times.
	///
	/// Note: All of the transformations that can be made to a vtkProp3D will take
	/// effect with the follower. Thus, if you change the orientation of the
	/// follower by 90 degrees, then it will follow the camera, but be off by 90
	/// degrees.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFollower vtkProp3D vtkCamera vtkProp3DAxisFollower
	/// </seealso>
	// Token: 0x020003D6 RID: 982
	public class vtkProp3DFollower : vtkProp3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600B902 RID: 47362 RVA: 0x0010398B File Offset: 0x00101B8B
		static vtkProp3DFollower()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProp3DFollower.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProp3DFollower"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600B903 RID: 47363 RVA: 0x001039B3 File Offset: 0x00101BB3
		public vtkProp3DFollower(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600B904 RID: 47364
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DFollower_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a follower with no camera set.
		/// </summary>
		// Token: 0x0600B905 RID: 47365 RVA: 0x001039C4 File Offset: 0x00101BC4
		public new static vtkProp3DFollower New()
		{
			vtkProp3DFollower result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DFollower.vtkProp3DFollower_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProp3DFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a follower with no camera set.
		/// </summary>
		// Token: 0x0600B906 RID: 47366 RVA: 0x00103A18 File Offset: 0x00101C18
		public vtkProp3DFollower() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProp3DFollower.vtkProp3DFollower_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600B907 RID: 47367 RVA: 0x00103A5C File Offset: 0x00101C5C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600B908 RID: 47368
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DFollower_ComputeMatrix_01(HandleRef pThis);

		/// <summary>
		/// Generate the matrix based on ivars. This method overloads its superclasses
		/// ComputeMatrix() method due to the special vtkProp3DFollower matrix operations.
		/// </summary>
		// Token: 0x0600B909 RID: 47369 RVA: 0x00103A67 File Offset: 0x00101C67
		public override void ComputeMatrix()
		{
			vtkProp3DFollower.vtkProp3DFollower_ComputeMatrix_01(base.GetCppThis());
		}

		// Token: 0x0600B90A RID: 47370
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DFollower_GetBounds_02(HandleRef pThis);

		/// <summary>
		/// Return the bounds of this vtkProp3D.
		/// </summary>
		// Token: 0x0600B90B RID: 47371 RVA: 0x00103A78 File Offset: 0x00101C78
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkProp3DFollower.vtkProp3DFollower_GetBounds_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B90C RID: 47372
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DFollower_GetCamera_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the camera to follow. If this is not set, then the follower
		/// won't know what to follow and will act like a normal vtkProp3D.
		/// </summary>
		// Token: 0x0600B90D RID: 47373 RVA: 0x00103AC0 File Offset: 0x00101CC0
		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DFollower.vtkProp3DFollower_GetCamera_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B90E RID: 47374
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DFollower_GetNextPath_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Overload vtkProp's method for setting up assembly paths. See
		/// the documentation for vtkProp.
		/// </summary>
		// Token: 0x0600B90F RID: 47375 RVA: 0x00103B30 File Offset: 0x00101D30
		public override vtkAssemblyPath GetNextPath()
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DFollower.vtkProp3DFollower_GetNextPath_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPath = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPath.Register(null);
				}
			}
			return vtkAssemblyPath;
		}

		// Token: 0x0600B910 RID: 47376
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProp3DFollower_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for type and printing.
		/// </summary>
		// Token: 0x0600B911 RID: 47377 RVA: 0x00103BA0 File Offset: 0x00101DA0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProp3DFollower.vtkProp3DFollower_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600B912 RID: 47378
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProp3DFollower_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for type and printing.
		/// </summary>
		// Token: 0x0600B913 RID: 47379 RVA: 0x00103BC0 File Offset: 0x00101DC0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProp3DFollower.vtkProp3DFollower_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600B914 RID: 47380
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DFollower_GetProp3D_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the vtkProp3D to control (i.e., face the camera).
		/// </summary>
		// Token: 0x0600B915 RID: 47381 RVA: 0x00103BDC File Offset: 0x00101DDC
		public virtual vtkProp3D GetProp3D()
		{
			vtkProp3D vtkProp3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DFollower.vtkProp3DFollower_GetProp3D_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3D = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3D.Register(null);
				}
			}
			return vtkProp3D;
		}

		// Token: 0x0600B916 RID: 47382
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DFollower_HasTranslucentPolygonalGeometry_08(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600B917 RID: 47383 RVA: 0x00103C4C File Offset: 0x00101E4C
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkProp3DFollower.vtkProp3DFollower_HasTranslucentPolygonalGeometry_08(base.GetCppThis());
		}

		// Token: 0x0600B918 RID: 47384
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DFollower_InitPathTraversal_09(HandleRef pThis);

		/// <summary>
		/// Overload vtkProp's method for setting up assembly paths. See
		/// the documentation for vtkProp.
		/// </summary>
		// Token: 0x0600B919 RID: 47385 RVA: 0x00103C6B File Offset: 0x00101E6B
		public override void InitPathTraversal()
		{
			vtkProp3DFollower.vtkProp3DFollower_InitPathTraversal_09(base.GetCppThis());
		}

		// Token: 0x0600B91A RID: 47386
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DFollower_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for type and printing.
		/// </summary>
		// Token: 0x0600B91B RID: 47387 RVA: 0x00103C7C File Offset: 0x00101E7C
		public override int IsA(string type)
		{
			return vtkProp3DFollower.vtkProp3DFollower_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600B91C RID: 47388
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DFollower_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for type and printing.
		/// </summary>
		// Token: 0x0600B91D RID: 47389 RVA: 0x00103C9C File Offset: 0x00101E9C
		public new static int IsTypeOf(string type)
		{
			return vtkProp3DFollower.vtkProp3DFollower_IsTypeOf_11(type);
		}

		// Token: 0x0600B91E RID: 47390
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DFollower_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods for type and printing.
		/// </summary>
		// Token: 0x0600B91F RID: 47391 RVA: 0x00103CB8 File Offset: 0x00101EB8
		public new vtkProp3DFollower NewInstance()
		{
			vtkProp3DFollower result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DFollower.vtkProp3DFollower_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProp3DFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600B920 RID: 47392
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DFollower_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources associated with this vtkProp3DFollower.
		/// </summary>
		// Token: 0x0600B921 RID: 47393 RVA: 0x00103D14 File Offset: 0x00101F14
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkProp3DFollower.vtkProp3DFollower_ReleaseGraphicsResources_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B922 RID: 47394
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DFollower_RenderOpaqueGeometry_15(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// This causes the actor to be rendered. It in turn will render the actor's
		/// property, texture map and then mapper. If a property hasn't been
		/// assigned, then the actor will create one automatically.
		/// </summary>
		// Token: 0x0600B923 RID: 47395 RVA: 0x00103D44 File Offset: 0x00101F44
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkProp3DFollower.vtkProp3DFollower_RenderOpaqueGeometry_15(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B924 RID: 47396
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DFollower_RenderTranslucentPolygonalGeometry_16(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// This causes the actor to be rendered. It in turn will render the actor's
		/// property, texture map and then mapper. If a property hasn't been
		/// assigned, then the actor will create one automatically.
		/// </summary>
		// Token: 0x0600B925 RID: 47397 RVA: 0x00103D78 File Offset: 0x00101F78
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkProp3DFollower.vtkProp3DFollower_RenderTranslucentPolygonalGeometry_16(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B926 RID: 47398
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DFollower_RenderVolumetricGeometry_17(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// This causes the actor to be rendered. It in turn will render the actor's
		/// property, texture map and then mapper. If a property hasn't been
		/// assigned, then the actor will create one automatically.
		/// </summary>
		// Token: 0x0600B927 RID: 47399 RVA: 0x00103DAC File Offset: 0x00101FAC
		public override int RenderVolumetricGeometry(vtkViewport viewport)
		{
			return vtkProp3DFollower.vtkProp3DFollower_RenderVolumetricGeometry_17(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B928 RID: 47400
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DFollower_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods for type and printing.
		/// </summary>
		// Token: 0x0600B929 RID: 47401 RVA: 0x00103DE0 File Offset: 0x00101FE0
		public new static vtkProp3DFollower SafeDownCast(vtkObjectBase o)
		{
			vtkProp3DFollower vtkProp3DFollower = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DFollower.vtkProp3DFollower_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3DFollower = (vtkProp3DFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3DFollower.Register(null);
				}
			}
			return vtkProp3DFollower;
		}

		// Token: 0x0600B92A RID: 47402
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DFollower_SetCamera_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the camera to follow. If this is not set, then the follower
		/// won't know what to follow and will act like a normal vtkProp3D.
		/// </summary>
		// Token: 0x0600B92B RID: 47403 RVA: 0x00103E60 File Offset: 0x00102060
		public virtual void SetCamera(vtkCamera arg0)
		{
			vtkProp3DFollower.vtkProp3DFollower_SetCamera_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B92C RID: 47404
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DFollower_SetProp3D_20(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Set/Get the vtkProp3D to control (i.e., face the camera).
		/// </summary>
		// Token: 0x0600B92D RID: 47405 RVA: 0x00103E90 File Offset: 0x00102090
		public virtual void SetProp3D(vtkProp3D prop)
		{
			vtkProp3DFollower.vtkProp3DFollower_SetProp3D_20(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x0600B92E RID: 47406
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DFollower_ShallowCopy_21(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of a follower. Overloads the virtual vtkProp method.
		/// </summary>
		// Token: 0x0600B92F RID: 47407 RVA: 0x00103EC0 File Offset: 0x001020C0
		public override void ShallowCopy(vtkProp prop)
		{
			vtkProp3DFollower.vtkProp3DFollower_ShallowCopy_21(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E0A RID: 3594
		public new const string MRFullTypeName = "Kitware.VTK.vtkProp3DFollower";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E0B RID: 3595
		public new static readonly string MRClassNameKey = "class vtkProp3DFollower";
	}
}
