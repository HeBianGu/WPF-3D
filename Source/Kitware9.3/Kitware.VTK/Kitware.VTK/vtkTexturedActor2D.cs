using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTexturedActor2D
	/// </summary>
	/// <remarks>
	///    actor that draws 2D data with texture support
	///
	/// vtkTexturedActor2D is an Actor2D which has additional support for
	/// textures, just like vtkActor. To use textures, the geometry must have
	/// texture coordinates, and the texture must be set with SetTexture().
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor2D vtkProp vtkMapper2D vtkProperty2D
	/// </seealso>
	// Token: 0x020005CE RID: 1486
	public class vtkTexturedActor2D : vtkActor2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060103A3 RID: 66467 RVA: 0x001699CF File Offset: 0x00167BCF
		static vtkTexturedActor2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTexturedActor2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTexturedActor2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060103A4 RID: 66468 RVA: 0x001699F7 File Offset: 0x00167BF7
		public vtkTexturedActor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060103A5 RID: 66469
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedActor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060103A6 RID: 66470 RVA: 0x00169A08 File Offset: 0x00167C08
		public new static vtkTexturedActor2D New()
		{
			vtkTexturedActor2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedActor2D.vtkTexturedActor2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexturedActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060103A7 RID: 66471 RVA: 0x00169A5C File Offset: 0x00167C5C
		public vtkTexturedActor2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTexturedActor2D.vtkTexturedActor2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060103A8 RID: 66472 RVA: 0x00169AA0 File Offset: 0x00167CA0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060103A9 RID: 66473
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTexturedActor2D_GetMTime_01(HandleRef pThis);

		/// <summary>
		/// Return this object's modified time.
		/// </summary>
		// Token: 0x060103AA RID: 66474 RVA: 0x00169AAC File Offset: 0x00167CAC
		public override ulong GetMTime()
		{
			return vtkTexturedActor2D.vtkTexturedActor2D_GetMTime_01(base.GetCppThis());
		}

		// Token: 0x060103AB RID: 66475
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTexturedActor2D_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060103AC RID: 66476 RVA: 0x00169ACC File Offset: 0x00167CCC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTexturedActor2D.vtkTexturedActor2D_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060103AD RID: 66477
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTexturedActor2D_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060103AE RID: 66478 RVA: 0x00169AEC File Offset: 0x00167CEC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTexturedActor2D.vtkTexturedActor2D_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060103AF RID: 66479
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedActor2D_GetTexture_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the texture object to control rendering texture maps.  This will
		/// be a vtkTexture object. An actor does not need to have an associated
		/// texture map and multiple actors can share one texture.
		/// </summary>
		// Token: 0x060103B0 RID: 66480 RVA: 0x00169B08 File Offset: 0x00167D08
		public virtual vtkTexture GetTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedActor2D.vtkTexturedActor2D_GetTexture_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		// Token: 0x060103B1 RID: 66481
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedActor2D_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060103B2 RID: 66482 RVA: 0x00169B78 File Offset: 0x00167D78
		public override int IsA(string type)
		{
			return vtkTexturedActor2D.vtkTexturedActor2D_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060103B3 RID: 66483
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedActor2D_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060103B4 RID: 66484 RVA: 0x00169B98 File Offset: 0x00167D98
		public new static int IsTypeOf(string type)
		{
			return vtkTexturedActor2D.vtkTexturedActor2D_IsTypeOf_06(type);
		}

		// Token: 0x060103B5 RID: 66485
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedActor2D_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060103B6 RID: 66486 RVA: 0x00169BB4 File Offset: 0x00167DB4
		public new vtkTexturedActor2D NewInstance()
		{
			vtkTexturedActor2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedActor2D.vtkTexturedActor2D_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexturedActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060103B7 RID: 66487
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedActor2D_ReleaseGraphicsResources_09(HandleRef pThis, HandleRef win);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x060103B8 RID: 66488 RVA: 0x00169C10 File Offset: 0x00167E10
		public override void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkTexturedActor2D.vtkTexturedActor2D_ReleaseGraphicsResources_09(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x060103B9 RID: 66489
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedActor2D_RenderOpaqueGeometry_10(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x060103BA RID: 66490 RVA: 0x00169C40 File Offset: 0x00167E40
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkTexturedActor2D.vtkTexturedActor2D_RenderOpaqueGeometry_10(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060103BB RID: 66491
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedActor2D_RenderOverlay_11(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x060103BC RID: 66492 RVA: 0x00169C74 File Offset: 0x00167E74
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkTexturedActor2D.vtkTexturedActor2D_RenderOverlay_11(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060103BD RID: 66493
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedActor2D_RenderTranslucentPolygonalGeometry_12(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Support the standard render methods.
		/// </summary>
		// Token: 0x060103BE RID: 66494 RVA: 0x00169CA8 File Offset: 0x00167EA8
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkTexturedActor2D.vtkTexturedActor2D_RenderTranslucentPolygonalGeometry_12(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060103BF RID: 66495
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedActor2D_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060103C0 RID: 66496 RVA: 0x00169CDC File Offset: 0x00167EDC
		public new static vtkTexturedActor2D SafeDownCast(vtkObjectBase o)
		{
			vtkTexturedActor2D vtkTexturedActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedActor2D.vtkTexturedActor2D_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexturedActor2D = (vtkTexturedActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexturedActor2D.Register(null);
				}
			}
			return vtkTexturedActor2D;
		}

		// Token: 0x060103C1 RID: 66497
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedActor2D_SetTexture_14(HandleRef pThis, HandleRef texture);

		/// <summary>
		/// Set/Get the texture object to control rendering texture maps.  This will
		/// be a vtkTexture object. An actor does not need to have an associated
		/// texture map and multiple actors can share one texture.
		/// </summary>
		// Token: 0x060103C2 RID: 66498 RVA: 0x00169D5C File Offset: 0x00167F5C
		public virtual void SetTexture(vtkTexture texture)
		{
			vtkTexturedActor2D.vtkTexturedActor2D_SetTexture_14(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		// Token: 0x060103C3 RID: 66499
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedActor2D_ShallowCopy_15(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of this vtkTexturedActor2D. Overrides vtkActor2D method.
		/// </summary>
		// Token: 0x060103C4 RID: 66500 RVA: 0x00169D8C File Offset: 0x00167F8C
		public override void ShallowCopy(vtkProp prop)
		{
			vtkTexturedActor2D.vtkTexturedActor2D_ShallowCopy_15(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012E1 RID: 4833
		public new const string MRFullTypeName = "Kitware.VTK.vtkTexturedActor2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012E2 RID: 4834
		public new static readonly string MRClassNameKey = "class vtkTexturedActor2D";
	}
}
