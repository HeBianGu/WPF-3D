using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFollower
	/// </summary>
	/// <remarks>
	///    a subclass of actor that always faces the camera
	///
	/// vtkFollower is a subclass of vtkActor that always follows its specified
	/// camera. More specifically it will not change its position or scale,
	/// but it will continually update its orientation so that it is right side
	/// up and facing the camera. This is typically used for text labels in a
	/// scene. All of the adjustments that can be made to an actor also will
	/// take effect with a follower.  So, if you change the orientation of the
	/// follower by 90 degrees, then it will follow the camera, but be off by
	/// 90 degrees.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor vtkCamera vtkAxisFollower vtkProp3DFollower
	/// </seealso>
	// Token: 0x020000BA RID: 186
	public class vtkFollower : vtkActor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600291E RID: 10526 RVA: 0x0003C7F7 File Offset: 0x0003A9F7
		static vtkFollower()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFollower.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFollower"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600291F RID: 10527 RVA: 0x0003C81F File Offset: 0x0003AA1F
		public vtkFollower(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002920 RID: 10528
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFollower_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a follower with no camera set
		/// </summary>
		// Token: 0x06002921 RID: 10529 RVA: 0x0003C830 File Offset: 0x0003AA30
		public new static vtkFollower New()
		{
			vtkFollower result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFollower.vtkFollower_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a follower with no camera set
		/// </summary>
		// Token: 0x06002922 RID: 10530 RVA: 0x0003C884 File Offset: 0x0003AA84
		public vtkFollower() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFollower.vtkFollower_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002923 RID: 10531 RVA: 0x0003C8C8 File Offset: 0x0003AAC8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002924 RID: 10532
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFollower_ComputeMatrix_01(HandleRef pThis);

		/// <summary>
		/// Generate the matrix based on ivars. This method overloads its superclasses
		/// ComputeMatrix() method due to the special vtkFollower matrix operations.
		/// </summary>
		// Token: 0x06002925 RID: 10533 RVA: 0x0003C8D3 File Offset: 0x0003AAD3
		public override void ComputeMatrix()
		{
			vtkFollower.vtkFollower_ComputeMatrix_01(base.GetCppThis());
		}

		// Token: 0x06002926 RID: 10534
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFollower_GetCamera_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the camera to follow. If this is not set, then the follower
		/// won't know who to follow.
		/// </summary>
		// Token: 0x06002927 RID: 10535 RVA: 0x0003C8E4 File Offset: 0x0003AAE4
		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFollower.vtkFollower_GetCamera_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002928 RID: 10536
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFollower_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002929 RID: 10537 RVA: 0x0003C954 File Offset: 0x0003AB54
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFollower.vtkFollower_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600292A RID: 10538
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFollower_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600292B RID: 10539 RVA: 0x0003C974 File Offset: 0x0003AB74
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFollower.vtkFollower_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600292C RID: 10540
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFollower_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600292D RID: 10541 RVA: 0x0003C990 File Offset: 0x0003AB90
		public override int IsA(string type)
		{
			return vtkFollower.vtkFollower_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600292E RID: 10542
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFollower_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600292F RID: 10543 RVA: 0x0003C9B0 File Offset: 0x0003ABB0
		public new static int IsTypeOf(string type)
		{
			return vtkFollower.vtkFollower_IsTypeOf_06(type);
		}

		// Token: 0x06002930 RID: 10544
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFollower_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002931 RID: 10545 RVA: 0x0003C9CC File Offset: 0x0003ABCC
		public new vtkFollower NewInstance()
		{
			vtkFollower result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFollower.vtkFollower_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002932 RID: 10546
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFollower_ReleaseGraphicsResources_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources associated with this vtkProp3DFollower.
		/// </summary>
		// Token: 0x06002933 RID: 10547 RVA: 0x0003CA28 File Offset: 0x0003AC28
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkFollower.vtkFollower_ReleaseGraphicsResources_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002934 RID: 10548
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFollower_Render_10(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// This causes the actor to be rendered. It in turn will render the actor's
		/// property, texture map and then mapper. If a property hasn't been
		/// assigned, then the actor will create one automatically.
		/// </summary>
		// Token: 0x06002935 RID: 10549 RVA: 0x0003CA58 File Offset: 0x0003AC58
		public virtual void Render(vtkRenderer ren)
		{
			vtkFollower.vtkFollower_Render_10(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06002936 RID: 10550
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFollower_RenderOpaqueGeometry_11(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// This causes the actor to be rendered. It in turn will render the actor's
		/// property, texture map and then mapper. If a property hasn't been
		/// assigned, then the actor will create one automatically.
		/// </summary>
		// Token: 0x06002937 RID: 10551 RVA: 0x0003CA88 File Offset: 0x0003AC88
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkFollower.vtkFollower_RenderOpaqueGeometry_11(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06002938 RID: 10552
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFollower_RenderTranslucentPolygonalGeometry_12(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// This causes the actor to be rendered. It in turn will render the actor's
		/// property, texture map and then mapper. If a property hasn't been
		/// assigned, then the actor will create one automatically.
		/// </summary>
		// Token: 0x06002939 RID: 10553 RVA: 0x0003CABC File Offset: 0x0003ACBC
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkFollower.vtkFollower_RenderTranslucentPolygonalGeometry_12(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600293A RID: 10554
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFollower_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600293B RID: 10555 RVA: 0x0003CAF0 File Offset: 0x0003ACF0
		public new static vtkFollower SafeDownCast(vtkObjectBase o)
		{
			vtkFollower vtkFollower = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFollower.vtkFollower_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600293C RID: 10556
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFollower_SetCamera_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the camera to follow. If this is not set, then the follower
		/// won't know who to follow.
		/// </summary>
		// Token: 0x0600293D RID: 10557 RVA: 0x0003CB70 File Offset: 0x0003AD70
		public virtual void SetCamera(vtkCamera arg0)
		{
			vtkFollower.vtkFollower_SetCamera_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600293E RID: 10558
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFollower_ShallowCopy_15(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of a follower. Overloads the virtual vtkProp method.
		/// </summary>
		// Token: 0x0600293F RID: 10559 RVA: 0x0003CBA0 File Offset: 0x0003ADA0
		public override void ShallowCopy(vtkProp prop)
		{
			vtkFollower.vtkFollower_ShallowCopy_15(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000560 RID: 1376
		public new const string MRFullTypeName = "Kitware.VTK.vtkFollower";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000561 RID: 1377
		public new static readonly string MRClassNameKey = "class vtkFollower";
	}
}
