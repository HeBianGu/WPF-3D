using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkBillboardTextActor3D
	/// </summary>
	/// <remarks>
	///  Renders pixel-aligned text, facing the camera, anchored at a 3D point.
	/// </remarks>
	// Token: 0x0200059E RID: 1438
	public class vtkBillboardTextActor3D : vtkProp3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FC5D RID: 64605 RVA: 0x0015F993 File Offset: 0x0015DB93
		static vtkBillboardTextActor3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBillboardTextActor3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBillboardTextActor3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FC5E RID: 64606 RVA: 0x0015F9BB File Offset: 0x0015DBBB
		public vtkBillboardTextActor3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FC5F RID: 64607
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBillboardTextActor3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC60 RID: 64608 RVA: 0x0015F9CC File Offset: 0x0015DBCC
		public new static vtkBillboardTextActor3D New()
		{
			vtkBillboardTextActor3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBillboardTextActor3D.vtkBillboardTextActor3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBillboardTextActor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC61 RID: 64609 RVA: 0x0015FA20 File Offset: 0x0015DC20
		public vtkBillboardTextActor3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBillboardTextActor3D.vtkBillboardTextActor3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FC62 RID: 64610 RVA: 0x0015FA64 File Offset: 0x0015DC64
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FC63 RID: 64611
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBillboardTextActor3D_ForceOpaqueOff_01(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x0600FC64 RID: 64612 RVA: 0x0015FA6F File Offset: 0x0015DC6F
		public virtual void ForceOpaqueOff()
		{
			vtkBillboardTextActor3D.vtkBillboardTextActor3D_ForceOpaqueOff_01(base.GetCppThis());
		}

		// Token: 0x0600FC65 RID: 64613
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBillboardTextActor3D_ForceOpaqueOn_02(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x0600FC66 RID: 64614 RVA: 0x0015FA7E File Offset: 0x0015DC7E
		public virtual void ForceOpaqueOn()
		{
			vtkBillboardTextActor3D.vtkBillboardTextActor3D_ForceOpaqueOn_02(base.GetCppThis());
		}

		// Token: 0x0600FC67 RID: 64615
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBillboardTextActor3D_ForceTranslucentOff_03(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x0600FC68 RID: 64616 RVA: 0x0015FA8D File Offset: 0x0015DC8D
		public virtual void ForceTranslucentOff()
		{
			vtkBillboardTextActor3D.vtkBillboardTextActor3D_ForceTranslucentOff_03(base.GetCppThis());
		}

		// Token: 0x0600FC69 RID: 64617
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBillboardTextActor3D_ForceTranslucentOn_04(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x0600FC6A RID: 64618 RVA: 0x0015FA9C File Offset: 0x0015DC9C
		public virtual void ForceTranslucentOn()
		{
			vtkBillboardTextActor3D.vtkBillboardTextActor3D_ForceTranslucentOn_04(base.GetCppThis());
		}

		// Token: 0x0600FC6B RID: 64619
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBillboardTextActor3D_GetActors_05(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// For some exporters and other other operations we must be
		/// able to collect all the actors or volumes. These methods
		/// are used in that process.
		/// In case the viewport is not a consumer of this prop:
		/// call UpdateGeometry() first for updated viewport-specific
		/// billboard geometry.
		/// </summary>
		// Token: 0x0600FC6C RID: 64620 RVA: 0x0015FAAC File Offset: 0x0015DCAC
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkBillboardTextActor3D.vtkBillboardTextActor3D_GetActors_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600FC6D RID: 64621
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBillboardTextActor3D_GetAnchorDC_06(HandleRef pThis);

		/// <summary>
		/// Returns the anchor position in display coordinates, with depth in NDC.
		/// Valid after calling RenderOpaqueGeometry.
		/// </summary>
		// Token: 0x0600FC6E RID: 64622 RVA: 0x0015FADC File Offset: 0x0015DCDC
		public virtual double[] GetAnchorDC()
		{
			IntPtr intPtr = vtkBillboardTextActor3D.vtkBillboardTextActor3D_GetAnchorDC_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600FC6F RID: 64623
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBillboardTextActor3D_GetAnchorDC_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Returns the anchor position in display coordinates, with depth in NDC.
		/// Valid after calling RenderOpaqueGeometry.
		/// </summary>
		// Token: 0x0600FC70 RID: 64624 RVA: 0x0015FB24 File Offset: 0x0015DD24
		public virtual void GetAnchorDC(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkBillboardTextActor3D.vtkBillboardTextActor3D_GetAnchorDC_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600FC71 RID: 64625
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBillboardTextActor3D_GetAnchorDC_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Returns the anchor position in display coordinates, with depth in NDC.
		/// Valid after calling RenderOpaqueGeometry.
		/// </summary>
		// Token: 0x0600FC72 RID: 64626 RVA: 0x0015FB36 File Offset: 0x0015DD36
		public virtual void GetAnchorDC(IntPtr _arg)
		{
			vtkBillboardTextActor3D.vtkBillboardTextActor3D_GetAnchorDC_08(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FC73 RID: 64627
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBillboardTextActor3D_GetBounds_09(HandleRef pThis);

		/// <summary>
		/// Just render in translucent pass, since it can execute multiple times
		/// (depth peeling, for instance).
		/// </summary>
		// Token: 0x0600FC74 RID: 64628 RVA: 0x0015FB48 File Offset: 0x0015DD48
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkBillboardTextActor3D.vtkBillboardTextActor3D_GetBounds_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600FC75 RID: 64629
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBillboardTextActor3D_GetDisplayOffset_10(HandleRef pThis);

		/// <summary>
		/// Can be used to set a fixed offset from the anchor point.
		/// Use display coordinates.
		/// @{
		/// </summary>
		// Token: 0x0600FC76 RID: 64630 RVA: 0x0015FB90 File Offset: 0x0015DD90
		public virtual int[] GetDisplayOffset()
		{
			IntPtr intPtr = vtkBillboardTextActor3D.vtkBillboardTextActor3D_GetDisplayOffset_10(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600FC77 RID: 64631
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBillboardTextActor3D_GetDisplayOffset_11(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Can be used to set a fixed offset from the anchor point.
		/// Use display coordinates.
		/// @{
		/// </summary>
		// Token: 0x0600FC78 RID: 64632 RVA: 0x0015FBD8 File Offset: 0x0015DDD8
		public virtual void GetDisplayOffset(ref int _arg1, ref int _arg2)
		{
			vtkBillboardTextActor3D.vtkBillboardTextActor3D_GetDisplayOffset_11(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600FC79 RID: 64633
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBillboardTextActor3D_GetDisplayOffset_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Can be used to set a fixed offset from the anchor point.
		/// Use display coordinates.
		/// @{
		/// </summary>
		// Token: 0x0600FC7A RID: 64634 RVA: 0x0015FBE9 File Offset: 0x0015DDE9
		public virtual void GetDisplayOffset(IntPtr _arg)
		{
			vtkBillboardTextActor3D.vtkBillboardTextActor3D_GetDisplayOffset_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FC7B RID: 64635
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBillboardTextActor3D_GetForceOpaque_13(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x0600FC7C RID: 64636 RVA: 0x0015FBFC File Offset: 0x0015DDFC
		public virtual bool GetForceOpaque()
		{
			return vtkBillboardTextActor3D.vtkBillboardTextActor3D_GetForceOpaque_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FC7D RID: 64637
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBillboardTextActor3D_GetForceTranslucent_14(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x0600FC7E RID: 64638 RVA: 0x0015FC24 File Offset: 0x0015DE24
		public virtual bool GetForceTranslucent()
		{
			return vtkBillboardTextActor3D.vtkBillboardTextActor3D_GetForceTranslucent_14(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FC7F RID: 64639
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBillboardTextActor3D_GetInput_15(HandleRef pThis);

		/// <summary>
		/// The UTF-8 encoded string to display.
		/// @{
		/// </summary>
		// Token: 0x0600FC80 RID: 64640 RVA: 0x0015FC4C File Offset: 0x0015DE4C
		public virtual string GetInput()
		{
			string s = Marshal.PtrToStringAnsi(vtkBillboardTextActor3D.vtkBillboardTextActor3D_GetInput_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600FC81 RID: 64641
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBillboardTextActor3D_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC82 RID: 64642 RVA: 0x0015FC88 File Offset: 0x0015DE88
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBillboardTextActor3D.vtkBillboardTextActor3D_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0600FC83 RID: 64643
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBillboardTextActor3D_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC84 RID: 64644 RVA: 0x0015FCA8 File Offset: 0x0015DEA8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBillboardTextActor3D.vtkBillboardTextActor3D_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0600FC85 RID: 64645
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBillboardTextActor3D_GetTextProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The vtkTextProperty object that controls the rendered text.
		/// @{
		/// </summary>
		// Token: 0x0600FC86 RID: 64646 RVA: 0x0015FCC4 File Offset: 0x0015DEC4
		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBillboardTextActor3D.vtkBillboardTextActor3D_GetTextProperty_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600FC87 RID: 64647
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBillboardTextActor3D_HasTranslucentPolygonalGeometry_19(HandleRef pThis);

		/// <summary>
		/// Defers to internal actor.
		/// </summary>
		// Token: 0x0600FC88 RID: 64648 RVA: 0x0015FD34 File Offset: 0x0015DF34
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkBillboardTextActor3D.vtkBillboardTextActor3D_HasTranslucentPolygonalGeometry_19(base.GetCppThis());
		}

		// Token: 0x0600FC89 RID: 64649
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBillboardTextActor3D_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC8A RID: 64650 RVA: 0x0015FD54 File Offset: 0x0015DF54
		public override int IsA(string type)
		{
			return vtkBillboardTextActor3D.vtkBillboardTextActor3D_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x0600FC8B RID: 64651
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBillboardTextActor3D_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC8C RID: 64652 RVA: 0x0015FD74 File Offset: 0x0015DF74
		public new static int IsTypeOf(string type)
		{
			return vtkBillboardTextActor3D.vtkBillboardTextActor3D_IsTypeOf_21(type);
		}

		// Token: 0x0600FC8D RID: 64653
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBillboardTextActor3D_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC8E RID: 64654 RVA: 0x0015FD90 File Offset: 0x0015DF90
		public new vtkBillboardTextActor3D NewInstance()
		{
			vtkBillboardTextActor3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBillboardTextActor3D.vtkBillboardTextActor3D_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBillboardTextActor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FC8F RID: 64655
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBillboardTextActor3D_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef win);

		/// <summary>
		/// Just render in translucent pass, since it can execute multiple times
		/// (depth peeling, for instance).
		/// </summary>
		// Token: 0x0600FC90 RID: 64656 RVA: 0x0015FDEC File Offset: 0x0015DFEC
		public override void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkBillboardTextActor3D.vtkBillboardTextActor3D_ReleaseGraphicsResources_24(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x0600FC91 RID: 64657
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBillboardTextActor3D_RenderOpaqueGeometry_25(HandleRef pThis, HandleRef vp);

		/// <summary>
		/// Check/update geometry/texture in opaque pass, since it only happens once.
		/// </summary>
		// Token: 0x0600FC92 RID: 64658 RVA: 0x0015FE1C File Offset: 0x0015E01C
		public override int RenderOpaqueGeometry(vtkViewport vp)
		{
			return vtkBillboardTextActor3D.vtkBillboardTextActor3D_RenderOpaqueGeometry_25(base.GetCppThis(), (vp == null) ? default(HandleRef) : vp.GetCppThis());
		}

		// Token: 0x0600FC93 RID: 64659
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBillboardTextActor3D_RenderTranslucentPolygonalGeometry_26(HandleRef pThis, HandleRef vp);

		/// <summary>
		/// Just render in translucent pass, since it can execute multiple times
		/// (depth peeling, for instance).
		/// </summary>
		// Token: 0x0600FC94 RID: 64660 RVA: 0x0015FE50 File Offset: 0x0015E050
		public override int RenderTranslucentPolygonalGeometry(vtkViewport vp)
		{
			return vtkBillboardTextActor3D.vtkBillboardTextActor3D_RenderTranslucentPolygonalGeometry_26(base.GetCppThis(), (vp == null) ? default(HandleRef) : vp.GetCppThis());
		}

		// Token: 0x0600FC95 RID: 64661
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBillboardTextActor3D_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC96 RID: 64662 RVA: 0x0015FE84 File Offset: 0x0015E084
		public new static vtkBillboardTextActor3D SafeDownCast(vtkObjectBase o)
		{
			vtkBillboardTextActor3D vtkBillboardTextActor3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBillboardTextActor3D.vtkBillboardTextActor3D_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBillboardTextActor3D = (vtkBillboardTextActor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBillboardTextActor3D.Register(null);
				}
			}
			return vtkBillboardTextActor3D;
		}

		// Token: 0x0600FC97 RID: 64663
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBillboardTextActor3D_SetDisplayOffset_28(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Can be used to set a fixed offset from the anchor point.
		/// Use display coordinates.
		/// @{
		/// </summary>
		// Token: 0x0600FC98 RID: 64664 RVA: 0x0015FF03 File Offset: 0x0015E103
		public virtual void SetDisplayOffset(int _arg1, int _arg2)
		{
			vtkBillboardTextActor3D.vtkBillboardTextActor3D_SetDisplayOffset_28(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600FC99 RID: 64665
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBillboardTextActor3D_SetDisplayOffset_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Can be used to set a fixed offset from the anchor point.
		/// Use display coordinates.
		/// @{
		/// </summary>
		// Token: 0x0600FC9A RID: 64666 RVA: 0x0015FF14 File Offset: 0x0015E114
		public void SetDisplayOffset(IntPtr _arg)
		{
			vtkBillboardTextActor3D.vtkBillboardTextActor3D_SetDisplayOffset_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FC9B RID: 64667
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBillboardTextActor3D_SetForceOpaque_30(HandleRef pThis, byte opaque);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x0600FC9C RID: 64668 RVA: 0x0015FF24 File Offset: 0x0015E124
		public virtual void SetForceOpaque(bool opaque)
		{
			vtkBillboardTextActor3D.vtkBillboardTextActor3D_SetForceOpaque_30(base.GetCppThis(), opaque ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FC9D RID: 64669
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBillboardTextActor3D_SetForceTranslucent_31(HandleRef pThis, byte trans);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x0600FC9E RID: 64670 RVA: 0x0015FF3C File Offset: 0x0015E13C
		public virtual void SetForceTranslucent(bool trans)
		{
			vtkBillboardTextActor3D.vtkBillboardTextActor3D_SetForceTranslucent_31(base.GetCppThis(), trans ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FC9F RID: 64671
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBillboardTextActor3D_SetInput_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// The UTF-8 encoded string to display.
		/// @{
		/// </summary>
		// Token: 0x0600FCA0 RID: 64672 RVA: 0x0015FF54 File Offset: 0x0015E154
		public void SetInput(string arg0)
		{
			vtkBillboardTextActor3D.vtkBillboardTextActor3D_SetInput_32(base.GetCppThis(), arg0);
		}

		// Token: 0x0600FCA1 RID: 64673
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBillboardTextActor3D_SetTextProperty_33(HandleRef pThis, HandleRef tprop);

		/// <summary>
		/// The vtkTextProperty object that controls the rendered text.
		/// @{
		/// </summary>
		// Token: 0x0600FCA2 RID: 64674 RVA: 0x0015FF64 File Offset: 0x0015E164
		public void SetTextProperty(vtkTextProperty tprop)
		{
			vtkBillboardTextActor3D.vtkBillboardTextActor3D_SetTextProperty_33(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		// Token: 0x0600FCA3 RID: 64675
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBillboardTextActor3D_UpdateGeometry_34(HandleRef pThis, HandleRef vp);

		/// <summary>
		/// Updates the billboard geometry without performing any rendering,
		/// to assist GetActors().
		/// </summary>
		// Token: 0x0600FCA4 RID: 64676 RVA: 0x0015FF94 File Offset: 0x0015E194
		public void UpdateGeometry(vtkViewport vp)
		{
			vtkBillboardTextActor3D.vtkBillboardTextActor3D_UpdateGeometry_34(base.GetCppThis(), (vp == null) ? default(HandleRef) : vp.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001265 RID: 4709
		public new const string MRFullTypeName = "Kitware.VTK.vtkBillboardTextActor3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001266 RID: 4710
		public new static readonly string MRClassNameKey = "class vtkBillboardTextActor3D";
	}
}
