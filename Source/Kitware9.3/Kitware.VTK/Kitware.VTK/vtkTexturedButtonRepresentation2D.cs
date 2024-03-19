using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTexturedButtonRepresentation2D
	/// </summary>
	/// <remarks>
	///    defines a representation for a vtkButtonWidget
	///
	/// This class implements one type of vtkButtonRepresentation. It changes the
	/// appearance of a user-provided polydata by assigning textures according to
	/// the current button state. It also provides highlighting (when hovering and
	/// selecting the button) by fiddling with the actor's property. Since this is
	/// a 2D version, the button is rendered in the overlay plane. Typically it is
	/// positioned in display coordinates, but it can be anchored to a world
	/// position so it will appear to move as the camera moves.
	///
	/// To use this representation, always begin by specifying the number of
	/// button states.  Then provide a polydata (the polydata should have associated
	/// texture coordinates), and a list of textures corresponding to the button
	/// states. Optionally, the HoveringProperty and SelectionProperty can be
	/// adjusted to obtain the appropriate appearance.
	///
	/// @warning
	/// There are two variants of the PlaceWidget() method. The first PlaceWidget(bds[6])
	/// allows the widget to be placed in the display coordinates fixed to the overlay
	/// plane. The second PlaceWidget(anchor[3],size[2]) places the widget in world space;
	/// hence it will appear to move as the camera moves around the scene.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkButtonWidget vtkButtonRepresentation vtkTexturedButtonRepresentation
	/// vtkProp3DButtonRepresentation
	/// </seealso>
	// Token: 0x02000388 RID: 904
	public class vtkTexturedButtonRepresentation2D : vtkButtonRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A4FD RID: 42237 RVA: 0x000E9E43 File Offset: 0x000E8043
		static vtkTexturedButtonRepresentation2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTexturedButtonRepresentation2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTexturedButtonRepresentation2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A4FE RID: 42238 RVA: 0x000E9E6B File Offset: 0x000E806B
		public vtkTexturedButtonRepresentation2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A4FF RID: 42239
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600A500 RID: 42240 RVA: 0x000E9E7C File Offset: 0x000E807C
		public new static vtkTexturedButtonRepresentation2D New()
		{
			vtkTexturedButtonRepresentation2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexturedButtonRepresentation2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600A501 RID: 42241 RVA: 0x000E9ED0 File Offset: 0x000E80D0
		public vtkTexturedButtonRepresentation2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A502 RID: 42242 RVA: 0x000E9F14 File Offset: 0x000E8114
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A503 RID: 42243
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation2D_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
		/// </summary>
		// Token: 0x0600A504 RID: 42244 RVA: 0x000E9F1F File Offset: 0x000E811F
		public override void BuildRepresentation()
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600A505 RID: 42245
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedButtonRepresentation2D_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
		/// </summary>
		// Token: 0x0600A506 RID: 42246 RVA: 0x000E9F30 File Offset: 0x000E8130
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x0600A507 RID: 42247
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation2D_GetActors_03(HandleRef pThis, HandleRef pc);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x0600A508 RID: 42248 RVA: 0x000E9F54 File Offset: 0x000E8154
		public override void GetActors(vtkPropCollection pc)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_GetActors_03(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		// Token: 0x0600A509 RID: 42249
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetBalloon_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Grab the underlying vtkBalloonRepresentation used to position and display
		/// the button texture.
		/// </summary>
		// Token: 0x0600A50A RID: 42250 RVA: 0x000E9F84 File Offset: 0x000E8184
		public vtkBalloonRepresentation GetBalloon()
		{
			vtkBalloonRepresentation vtkBalloonRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_GetBalloon_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBalloonRepresentation = (vtkBalloonRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBalloonRepresentation.Register(null);
				}
			}
			return vtkBalloonRepresentation;
		}

		// Token: 0x0600A50B RID: 42251
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetBounds_05(HandleRef pThis);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x0600A50C RID: 42252 RVA: 0x000E9FF4 File Offset: 0x000E81F4
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A50D RID: 42253
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetButtonTexture_06(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Add the ith texture corresponding to the ith button state.
		/// The parameter i should be 0&lt;=i&lt;NumberOfStates.
		/// </summary>
		// Token: 0x0600A50E RID: 42254 RVA: 0x000EA03C File Offset: 0x000E823C
		public vtkImageData GetButtonTexture(int i)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_GetButtonTexture_06(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x0600A50F RID: 42255
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetHoveringProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the property to use when the hovering over the button.
		/// </summary>
		// Token: 0x0600A510 RID: 42256 RVA: 0x000EA0AC File Offset: 0x000E82AC
		public virtual vtkProperty2D GetHoveringProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_GetHoveringProperty_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		// Token: 0x0600A511 RID: 42257
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTexturedButtonRepresentation2D_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A512 RID: 42258 RVA: 0x000EA11C File Offset: 0x000E831C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600A513 RID: 42259
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTexturedButtonRepresentation2D_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A514 RID: 42260 RVA: 0x000EA13C File Offset: 0x000E833C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600A515 RID: 42261
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the property to use when the button is to appear "normal"
		/// i.e., the mouse pointer is not hovering or selecting the button.
		/// </summary>
		// Token: 0x0600A516 RID: 42262 RVA: 0x000EA158 File Offset: 0x000E8358
		public virtual vtkProperty2D GetProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_GetProperty_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		// Token: 0x0600A517 RID: 42263
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetSelectingProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the property to use when selecting the button.
		/// </summary>
		// Token: 0x0600A518 RID: 42264 RVA: 0x000EA1C8 File Offset: 0x000E83C8
		public virtual vtkProperty2D GetSelectingProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_GetSelectingProperty_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		// Token: 0x0600A519 RID: 42265
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedButtonRepresentation2D_HasTranslucentPolygonalGeometry_12(HandleRef pThis);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x0600A51A RID: 42266 RVA: 0x000EA238 File Offset: 0x000E8438
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_HasTranslucentPolygonalGeometry_12(base.GetCppThis());
		}

		// Token: 0x0600A51B RID: 42267
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation2D_Highlight_13(HandleRef pThis, int state);

		/// <summary>
		/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
		/// </summary>
		// Token: 0x0600A51C RID: 42268 RVA: 0x000EA257 File Offset: 0x000E8457
		public override void Highlight(int state)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_Highlight_13(base.GetCppThis(), state);
		}

		// Token: 0x0600A51D RID: 42269
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedButtonRepresentation2D_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A51E RID: 42270 RVA: 0x000EA268 File Offset: 0x000E8468
		public override int IsA(string type)
		{
			return vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0600A51F RID: 42271
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedButtonRepresentation2D_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A520 RID: 42272 RVA: 0x000EA288 File Offset: 0x000E8488
		public new static int IsTypeOf(string type)
		{
			return vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_IsTypeOf_15(type);
		}

		// Token: 0x0600A521 RID: 42273
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A522 RID: 42274 RVA: 0x000EA2A4 File Offset: 0x000E84A4
		public new vtkTexturedButtonRepresentation2D NewInstance()
		{
			vtkTexturedButtonRepresentation2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexturedButtonRepresentation2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A523 RID: 42275
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation2D_PlaceWidget_18(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Conventional PlaceWidget() method to satisfy the vtkWidgetRepresentation API.
		/// In this version, bounds[6] specifies a rectangle in *display* coordinates
		/// in which to place the button. The values for bounds[4] and bounds[5] can be
		/// set to zero. Note that PlaceWidget() is typically called at the end of configuring
		/// the button representation.
		/// </summary>
		// Token: 0x0600A524 RID: 42276 RVA: 0x000EA2FE File Offset: 0x000E84FE
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_PlaceWidget_18(base.GetCppThis(), bounds);
		}

		// Token: 0x0600A525 RID: 42277
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation2D_PlaceWidget_19(HandleRef pThis, IntPtr anchor, IntPtr size);

		/// <summary>
		/// This alternative PlaceWidget() method can be used to anchor the button
		/// to a 3D point. In this case, the button representation will move around
		/// the screen as the camera moves around the world space. The first
		/// parameter anchor[3] is the world point anchor position (attached to the
		/// lower left portion of the button by default); and the size[2] parameter
		/// defines a x-y box in display coordinates in which the button will
		/// fit. Note that you can grab the vtkBalloonRepresentation and set an
		/// offset value if the anchor point is to be elsewhere on the button.
		/// </summary>
		// Token: 0x0600A526 RID: 42278 RVA: 0x000EA30E File Offset: 0x000E850E
		public virtual void PlaceWidget(IntPtr anchor, IntPtr size)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_PlaceWidget_19(base.GetCppThis(), anchor, size);
		}

		// Token: 0x0600A527 RID: 42279
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation2D_ReleaseGraphicsResources_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x0600A528 RID: 42280 RVA: 0x000EA320 File Offset: 0x000E8520
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_ReleaseGraphicsResources_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A529 RID: 42281
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedButtonRepresentation2D_RenderOverlay_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x0600A52A RID: 42282 RVA: 0x000EA350 File Offset: 0x000E8550
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_RenderOverlay_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A52B RID: 42283
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600A52C RID: 42284 RVA: 0x000EA384 File Offset: 0x000E8584
		public new static vtkTexturedButtonRepresentation2D SafeDownCast(vtkObjectBase o)
		{
			vtkTexturedButtonRepresentation2D vtkTexturedButtonRepresentation2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexturedButtonRepresentation2D = (vtkTexturedButtonRepresentation2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexturedButtonRepresentation2D.Register(null);
				}
			}
			return vtkTexturedButtonRepresentation2D;
		}

		// Token: 0x0600A52D RID: 42285
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation2D_SetButtonTexture_23(HandleRef pThis, int i, HandleRef image);

		/// <summary>
		/// Add the ith texture corresponding to the ith button state.
		/// The parameter i should be 0&lt;=i&lt;NumberOfStates.
		/// </summary>
		// Token: 0x0600A52E RID: 42286 RVA: 0x000EA404 File Offset: 0x000E8604
		public void SetButtonTexture(int i, vtkImageData image)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_SetButtonTexture_23(base.GetCppThis(), i, (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		// Token: 0x0600A52F RID: 42287
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation2D_SetHoveringProperty_24(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Specify the property to use when the hovering over the button.
		/// </summary>
		// Token: 0x0600A530 RID: 42288 RVA: 0x000EA434 File Offset: 0x000E8634
		public virtual void SetHoveringProperty(vtkProperty2D p)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_SetHoveringProperty_24(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600A531 RID: 42289
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation2D_SetProperty_25(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Specify the property to use when the button is to appear "normal"
		/// i.e., the mouse pointer is not hovering or selecting the button.
		/// </summary>
		// Token: 0x0600A532 RID: 42290 RVA: 0x000EA464 File Offset: 0x000E8664
		public virtual void SetProperty(vtkProperty2D p)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_SetProperty_25(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600A533 RID: 42291
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation2D_SetSelectingProperty_26(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Specify the property to use when selecting the button.
		/// </summary>
		// Token: 0x0600A534 RID: 42292 RVA: 0x000EA494 File Offset: 0x000E8694
		public virtual void SetSelectingProperty(vtkProperty2D p)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_SetSelectingProperty_26(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600A535 RID: 42293
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation2D_ShallowCopy_27(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x0600A536 RID: 42294 RVA: 0x000EA4C4 File Offset: 0x000E86C4
		public override void ShallowCopy(vtkProp prop)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_ShallowCopy_27(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D27 RID: 3367
		public new const string MRFullTypeName = "Kitware.VTK.vtkTexturedButtonRepresentation2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D28 RID: 3368
		public new static readonly string MRClassNameKey = "class vtkTexturedButtonRepresentation2D";
	}
}
