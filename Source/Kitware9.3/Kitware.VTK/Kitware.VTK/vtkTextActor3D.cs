using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTextActor3D
	/// </summary>
	/// <remarks>
	///    An actor that displays text.
	///
	/// The input text is rendered into a buffer, which in turn is used as a
	/// texture applied onto a quad (a vtkImageActor is used under the hood).
	/// @warning
	/// This class is experimental at the moment.
	/// - The orientation is not optimized, the quad should be oriented, not
	///   the text itself when it is rendered in the buffer (we end up with
	///   excessively big textures for 45 degrees angles).
	///   This will be fixed first.
	/// - No checking is done at the moment regarding hardware texture size limits.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkProp3D
	/// </seealso>
	// Token: 0x020005D2 RID: 1490
	public class vtkTextActor3D : vtkProp3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601043F RID: 66623 RVA: 0x0016A883 File Offset: 0x00168A83
		static vtkTextActor3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextActor3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextActor3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010440 RID: 66624 RVA: 0x0016A8AB File Offset: 0x00168AAB
		public vtkTextActor3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010441 RID: 66625
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextActor3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010442 RID: 66626 RVA: 0x0016A8BC File Offset: 0x00168ABC
		public new static vtkTextActor3D New()
		{
			vtkTextActor3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextActor3D.vtkTextActor3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextActor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010443 RID: 66627 RVA: 0x0016A910 File Offset: 0x00168B10
		public vtkTextActor3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTextActor3D.vtkTextActor3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010444 RID: 66628 RVA: 0x0016A954 File Offset: 0x00168B54
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010445 RID: 66629
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor3D_ForceOpaqueOff_01(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x06010446 RID: 66630 RVA: 0x0016A95F File Offset: 0x00168B5F
		public virtual void ForceOpaqueOff()
		{
			vtkTextActor3D.vtkTextActor3D_ForceOpaqueOff_01(base.GetCppThis());
		}

		// Token: 0x06010447 RID: 66631
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor3D_ForceOpaqueOn_02(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x06010448 RID: 66632 RVA: 0x0016A96E File Offset: 0x00168B6E
		public virtual void ForceOpaqueOn()
		{
			vtkTextActor3D.vtkTextActor3D_ForceOpaqueOn_02(base.GetCppThis());
		}

		// Token: 0x06010449 RID: 66633
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor3D_ForceTranslucentOff_03(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x0601044A RID: 66634 RVA: 0x0016A97D File Offset: 0x00168B7D
		public virtual void ForceTranslucentOff()
		{
			vtkTextActor3D.vtkTextActor3D_ForceTranslucentOff_03(base.GetCppThis());
		}

		// Token: 0x0601044B RID: 66635
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor3D_ForceTranslucentOn_04(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x0601044C RID: 66636 RVA: 0x0016A98C File Offset: 0x00168B8C
		public virtual void ForceTranslucentOn()
		{
			vtkTextActor3D.vtkTextActor3D_ForceTranslucentOn_04(base.GetCppThis());
		}

		// Token: 0x0601044D RID: 66637
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor3D_GetBoundingBox_05(HandleRef pThis, IntPtr bbox);

		/// <summary>
		/// Get the vtkTextRenderer-derived bounding box for the given vtkTextProperty
		/// and text string str.  Results are returned in the four element bbox int
		/// array.  This call can be used for sizing other elements.
		/// </summary>
		// Token: 0x0601044E RID: 66638 RVA: 0x0016A99C File Offset: 0x00168B9C
		public int GetBoundingBox(IntPtr bbox)
		{
			return vtkTextActor3D.vtkTextActor3D_GetBoundingBox_05(base.GetCppThis(), bbox);
		}

		// Token: 0x0601044F RID: 66639
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextActor3D_GetBounds_06(HandleRef pThis);

		/// <summary>
		/// Get the bounds for this Prop3D as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
		/// </summary>
		// Token: 0x06010450 RID: 66640 RVA: 0x0016A9BC File Offset: 0x00168BBC
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkTextActor3D.vtkTextActor3D_GetBounds_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06010451 RID: 66641
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor3D_GetBounds_07(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds for this Prop3D as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
		/// </summary>
		// Token: 0x06010452 RID: 66642 RVA: 0x0016AA04 File Offset: 0x00168C04
		public new void GetBounds(IntPtr bounds)
		{
			vtkTextActor3D.vtkTextActor3D_GetBounds_07(base.GetCppThis(), bounds);
		}

		// Token: 0x06010453 RID: 66643
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTextActor3D_GetForceOpaque_08(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x06010454 RID: 66644 RVA: 0x0016AA14 File Offset: 0x00168C14
		public virtual bool GetForceOpaque()
		{
			return vtkTextActor3D.vtkTextActor3D_GetForceOpaque_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06010455 RID: 66645
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTextActor3D_GetForceTranslucent_09(HandleRef pThis);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x06010456 RID: 66646 RVA: 0x0016AA3C File Offset: 0x00168C3C
		public virtual bool GetForceTranslucent()
		{
			return vtkTextActor3D.vtkTextActor3D_GetForceTranslucent_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06010457 RID: 66647
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextActor3D_GetInput_10(HandleRef pThis);

		/// <summary>
		/// Set the text string to be displayed.
		/// </summary>
		// Token: 0x06010458 RID: 66648 RVA: 0x0016AA64 File Offset: 0x00168C64
		public virtual string GetInput()
		{
			string s = Marshal.PtrToStringAnsi(vtkTextActor3D.vtkTextActor3D_GetInput_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06010459 RID: 66649
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextActor3D_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601045A RID: 66650 RVA: 0x0016AAA0 File Offset: 0x00168CA0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTextActor3D.vtkTextActor3D_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0601045B RID: 66651
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextActor3D_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601045C RID: 66652 RVA: 0x0016AAC0 File Offset: 0x00168CC0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTextActor3D.vtkTextActor3D_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0601045D RID: 66653
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor3D_GetRenderedDPI_13();

		/// <summary>
		/// Since a 3D text actor is not pixel-aligned and positioned in 3D space,
		/// the text is rendered at a constant DPI, rather than using the current
		/// window DPI. This static method returns the DPI value used to produce the
		/// text images.
		/// </summary>
		// Token: 0x0601045E RID: 66654 RVA: 0x0016AADC File Offset: 0x00168CDC
		public static int GetRenderedDPI()
		{
			return vtkTextActor3D.vtkTextActor3D_GetRenderedDPI_13();
		}

		// Token: 0x0601045F RID: 66655
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextActor3D_GetTextProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the text property.
		/// </summary>
		// Token: 0x06010460 RID: 66656 RVA: 0x0016AAF8 File Offset: 0x00168CF8
		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextActor3D.vtkTextActor3D_GetTextProperty_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06010461 RID: 66657
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor3D_HasTranslucentPolygonalGeometry_15(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x06010462 RID: 66658 RVA: 0x0016AB68 File Offset: 0x00168D68
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkTextActor3D.vtkTextActor3D_HasTranslucentPolygonalGeometry_15(base.GetCppThis());
		}

		// Token: 0x06010463 RID: 66659
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor3D_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010464 RID: 66660 RVA: 0x0016AB88 File Offset: 0x00168D88
		public override int IsA(string type)
		{
			return vtkTextActor3D.vtkTextActor3D_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06010465 RID: 66661
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor3D_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010466 RID: 66662 RVA: 0x0016ABA8 File Offset: 0x00168DA8
		public new static int IsTypeOf(string type)
		{
			return vtkTextActor3D.vtkTextActor3D_IsTypeOf_17(type);
		}

		// Token: 0x06010467 RID: 66663
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextActor3D_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010468 RID: 66664 RVA: 0x0016ABC4 File Offset: 0x00168DC4
		public new vtkTextActor3D NewInstance()
		{
			vtkTextActor3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextActor3D.vtkTextActor3D_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextActor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010469 RID: 66665
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor3D_ReleaseGraphicsResources_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0601046A RID: 66666 RVA: 0x0016AC20 File Offset: 0x00168E20
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkTextActor3D.vtkTextActor3D_ReleaseGraphicsResources_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601046B RID: 66667
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor3D_RenderOpaqueGeometry_21(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
		/// Draw the text actor to the screen.
		/// </summary>
		// Token: 0x0601046C RID: 66668 RVA: 0x0016AC50 File Offset: 0x00168E50
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkTextActor3D.vtkTextActor3D_RenderOpaqueGeometry_21(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0601046D RID: 66669
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor3D_RenderOverlay_22(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
		/// Draw the text actor to the screen.
		/// </summary>
		// Token: 0x0601046E RID: 66670 RVA: 0x0016AC84 File Offset: 0x00168E84
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkTextActor3D.vtkTextActor3D_RenderOverlay_22(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0601046F RID: 66671
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextActor3D_RenderTranslucentPolygonalGeometry_23(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
		/// Draw the text actor to the screen.
		/// </summary>
		// Token: 0x06010470 RID: 66672 RVA: 0x0016ACB8 File Offset: 0x00168EB8
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkTextActor3D.vtkTextActor3D_RenderTranslucentPolygonalGeometry_23(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06010471 RID: 66673
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextActor3D_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010472 RID: 66674 RVA: 0x0016ACEC File Offset: 0x00168EEC
		public new static vtkTextActor3D SafeDownCast(vtkObjectBase o)
		{
			vtkTextActor3D vtkTextActor3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextActor3D.vtkTextActor3D_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextActor3D = (vtkTextActor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextActor3D.Register(null);
				}
			}
			return vtkTextActor3D;
		}

		// Token: 0x06010473 RID: 66675
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor3D_SetForceOpaque_25(HandleRef pThis, byte opaque);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x06010474 RID: 66676 RVA: 0x0016AD6B File Offset: 0x00168F6B
		public virtual void SetForceOpaque(bool opaque)
		{
			vtkTextActor3D.vtkTextActor3D_SetForceOpaque_25(base.GetCppThis(), opaque ? (byte)1 : (byte)0);
		}

		// Token: 0x06010475 RID: 66677
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor3D_SetForceTranslucent_26(HandleRef pThis, byte trans);

		/// <summary>
		/// Force the actor to render during the opaque or translucent pass.
		/// @{
		/// </summary>
		// Token: 0x06010476 RID: 66678 RVA: 0x0016AD83 File Offset: 0x00168F83
		public virtual void SetForceTranslucent(bool trans)
		{
			vtkTextActor3D.vtkTextActor3D_SetForceTranslucent_26(base.GetCppThis(), trans ? (byte)1 : (byte)0);
		}

		// Token: 0x06010477 RID: 66679
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor3D_SetInput_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the text string to be displayed.
		/// </summary>
		// Token: 0x06010478 RID: 66680 RVA: 0x0016AD9B File Offset: 0x00168F9B
		public virtual void SetInput(string _arg)
		{
			vtkTextActor3D.vtkTextActor3D_SetInput_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06010479 RID: 66681
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor3D_SetTextProperty_28(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the text property.
		/// </summary>
		// Token: 0x0601047A RID: 66682 RVA: 0x0016ADAC File Offset: 0x00168FAC
		public virtual void SetTextProperty(vtkTextProperty p)
		{
			vtkTextActor3D.vtkTextActor3D_SetTextProperty_28(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0601047B RID: 66683
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextActor3D_ShallowCopy_29(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of this text actor. Overloads the virtual
		/// vtkProp method.
		/// </summary>
		// Token: 0x0601047C RID: 66684 RVA: 0x0016ADDC File Offset: 0x00168FDC
		public override void ShallowCopy(vtkProp prop)
		{
			vtkTextActor3D.vtkTextActor3D_ShallowCopy_29(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012EB RID: 4843
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextActor3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012EC RID: 4844
		public new static readonly string MRClassNameKey = "class vtkTextActor3D";
	}
}
