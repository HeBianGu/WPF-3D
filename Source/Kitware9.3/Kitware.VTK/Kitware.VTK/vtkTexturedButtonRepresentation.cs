using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTexturedButtonRepresentation
	/// </summary>
	/// <remarks>
	///    defines a representation for a vtkButtonWidget
	///
	/// This class implements one type of vtkButtonRepresentation. It changes the
	/// appearance of a user-provided polydata by assigning textures according to the
	/// current button state. It also provides highlighting (when hovering and
	/// selecting the button) by fiddling with the actor's property.
	///
	/// To use this representation, always begin by specifying the number of
	/// button states.  Then provide a polydata (the polydata should have associated
	/// texture coordinates), and a list of textures corresponding to the button
	/// states. Optionally, the HoveringProperty and SelectionProperty can be
	/// adjusted to obtain the appropriate appearance.
	///
	/// This widget representation has two placement methods. The conventional
	/// PlaceWidget() method is used to locate the textured button inside of a
	/// user-specified bounding box (note that the button geometry is uniformly
	/// scaled to fit, thus two of the three dimensions can be "large" and the
	/// third used to perform the scaling). However this PlaceWidget() method will
	/// align the geometry within x-y-z oriented bounds. To further control the
	/// placement, use the additional PlaceWidget(scale,point,normal) method. This
	/// scales the geometry, places its center at the specified point position,
	/// and orients the geometry's z-direction parallel to the specified normal.
	/// This can be used to attach "sticky notes" or "sticky buttons" to the
	/// surface of objects.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkButtonWidget vtkButtonRepresentation vtkButtonSource vtkEllipticalButtonSource
	/// vtkRectangularButtonSource
	/// </seealso>
	// Token: 0x02000387 RID: 903
	public class vtkTexturedButtonRepresentation : vtkButtonRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A4B3 RID: 42163 RVA: 0x000E96A3 File Offset: 0x000E78A3
		static vtkTexturedButtonRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTexturedButtonRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTexturedButtonRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A4B4 RID: 42164 RVA: 0x000E96CB File Offset: 0x000E78CB
		public vtkTexturedButtonRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A4B5 RID: 42165
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600A4B6 RID: 42166 RVA: 0x000E96DC File Offset: 0x000E78DC
		public new static vtkTexturedButtonRepresentation New()
		{
			vtkTexturedButtonRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexturedButtonRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600A4B7 RID: 42167 RVA: 0x000E9730 File Offset: 0x000E7930
		public vtkTexturedButtonRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A4B8 RID: 42168 RVA: 0x000E9774 File Offset: 0x000E7974
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A4B9 RID: 42169
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
		/// </summary>
		// Token: 0x0600A4BA RID: 42170 RVA: 0x000E977F File Offset: 0x000E797F
		public override void BuildRepresentation()
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600A4BB RID: 42171
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedButtonRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
		/// </summary>
		// Token: 0x0600A4BC RID: 42172 RVA: 0x000E9790 File Offset: 0x000E7990
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x0600A4BD RID: 42173
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation_FollowCameraOff_03(HandleRef pThis);

		/// <summary>
		/// Specify whether the button should always face the camera. If enabled,
		/// the button rotates as the camera moves.
		/// </summary>
		// Token: 0x0600A4BE RID: 42174 RVA: 0x000E97B2 File Offset: 0x000E79B2
		public virtual void FollowCameraOff()
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_FollowCameraOff_03(base.GetCppThis());
		}

		// Token: 0x0600A4BF RID: 42175
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation_FollowCameraOn_04(HandleRef pThis);

		/// <summary>
		/// Specify whether the button should always face the camera. If enabled,
		/// the button rotates as the camera moves.
		/// </summary>
		// Token: 0x0600A4C0 RID: 42176 RVA: 0x000E97C1 File Offset: 0x000E79C1
		public virtual void FollowCameraOn()
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_FollowCameraOn_04(base.GetCppThis());
		}

		// Token: 0x0600A4C1 RID: 42177
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation_GetActors_05(HandleRef pThis, HandleRef pc);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x0600A4C2 RID: 42178 RVA: 0x000E97D0 File Offset: 0x000E79D0
		public override void GetActors(vtkPropCollection pc)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetActors_05(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		// Token: 0x0600A4C3 RID: 42179
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation_GetBounds_06(HandleRef pThis);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x0600A4C4 RID: 42180 RVA: 0x000E9800 File Offset: 0x000E7A00
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetBounds_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A4C5 RID: 42181
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation_GetButtonGeometry_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the polydata which defines the button geometry.
		/// </summary>
		// Token: 0x0600A4C6 RID: 42182 RVA: 0x000E9848 File Offset: 0x000E7A48
		public vtkPolyData GetButtonGeometry()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetButtonGeometry_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0600A4C7 RID: 42183
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation_GetButtonTexture_08(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Add the ith texture corresponding to the ith button state.
		/// The parameter i should be (0 &lt;= i &lt; NumberOfStates).
		/// </summary>
		// Token: 0x0600A4C8 RID: 42184 RVA: 0x000E98B8 File Offset: 0x000E7AB8
		public vtkImageData GetButtonTexture(int i)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetButtonTexture_08(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A4C9 RID: 42185
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedButtonRepresentation_GetFollowCamera_09(HandleRef pThis);

		/// <summary>
		/// Specify whether the button should always face the camera. If enabled,
		/// the button rotates as the camera moves.
		/// </summary>
		// Token: 0x0600A4CA RID: 42186 RVA: 0x000E9928 File Offset: 0x000E7B28
		public virtual int GetFollowCamera()
		{
			return vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetFollowCamera_09(base.GetCppThis());
		}

		// Token: 0x0600A4CB RID: 42187
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation_GetHoveringProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the property to use when the hovering over the button.
		/// </summary>
		// Token: 0x0600A4CC RID: 42188 RVA: 0x000E9948 File Offset: 0x000E7B48
		public virtual vtkProperty GetHoveringProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetHoveringProperty_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A4CD RID: 42189
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTexturedButtonRepresentation_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of the class.
		/// </summary>
		// Token: 0x0600A4CE RID: 42190 RVA: 0x000E99B8 File Offset: 0x000E7BB8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0600A4CF RID: 42191
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTexturedButtonRepresentation_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of the class.
		/// </summary>
		// Token: 0x0600A4D0 RID: 42192 RVA: 0x000E99D8 File Offset: 0x000E7BD8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0600A4D1 RID: 42193
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation_GetProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the property to use when the button is to appear "normal"
		/// i.e., the mouse pointer is not hovering or selecting the button.
		/// </summary>
		// Token: 0x0600A4D2 RID: 42194 RVA: 0x000E99F4 File Offset: 0x000E7BF4
		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetProperty_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A4D3 RID: 42195
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation_GetSelectingProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the property to use when selecting the button.
		/// </summary>
		// Token: 0x0600A4D4 RID: 42196 RVA: 0x000E9A64 File Offset: 0x000E7C64
		public virtual vtkProperty GetSelectingProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_GetSelectingProperty_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A4D5 RID: 42197
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedButtonRepresentation_HasTranslucentPolygonalGeometry_15(HandleRef pThis);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x0600A4D6 RID: 42198 RVA: 0x000E9AD4 File Offset: 0x000E7CD4
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_HasTranslucentPolygonalGeometry_15(base.GetCppThis());
		}

		// Token: 0x0600A4D7 RID: 42199
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation_Highlight_16(HandleRef pThis, int state);

		/// <summary>
		/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
		/// </summary>
		// Token: 0x0600A4D8 RID: 42200 RVA: 0x000E9AF3 File Offset: 0x000E7CF3
		public override void Highlight(int state)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_Highlight_16(base.GetCppThis(), state);
		}

		// Token: 0x0600A4D9 RID: 42201
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedButtonRepresentation_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of the class.
		/// </summary>
		// Token: 0x0600A4DA RID: 42202 RVA: 0x000E9B04 File Offset: 0x000E7D04
		public override int IsA(string type)
		{
			return vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0600A4DB RID: 42203
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedButtonRepresentation_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of the class.
		/// </summary>
		// Token: 0x0600A4DC RID: 42204 RVA: 0x000E9B24 File Offset: 0x000E7D24
		public new static int IsTypeOf(string type)
		{
			return vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_IsTypeOf_18(type);
		}

		// Token: 0x0600A4DD RID: 42205
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of the class.
		/// </summary>
		// Token: 0x0600A4DE RID: 42206 RVA: 0x000E9B40 File Offset: 0x000E7D40
		public new vtkTexturedButtonRepresentation NewInstance()
		{
			vtkTexturedButtonRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexturedButtonRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A4DF RID: 42207
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation_PlaceWidget_21(HandleRef pThis, double scale, IntPtr point, IntPtr normal);

		/// <summary>
		/// Alternative method for placing a button at a given position (defined by
		/// point[3]); at a given orientation (normal[3], where the z-axis of the
		/// button geometry is parallel to the normal); and scaled by the scale
		/// parameter. This method can bs used to attach "sticky notes" or "sticky
		/// buttons" to objects. A great way to attach interactive meta-data to 3D
		/// actors.
		/// </summary>
		// Token: 0x0600A4E0 RID: 42208 RVA: 0x000E9B9A File Offset: 0x000E7D9A
		public virtual void PlaceWidget(double scale, IntPtr point, IntPtr normal)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_PlaceWidget_21(base.GetCppThis(), scale, point, normal);
		}

		// Token: 0x0600A4E1 RID: 42209
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation_PlaceWidget_22(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
		/// </summary>
		// Token: 0x0600A4E2 RID: 42210 RVA: 0x000E9BAC File Offset: 0x000E7DAC
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_PlaceWidget_22(base.GetCppThis(), bounds);
		}

		// Token: 0x0600A4E3 RID: 42211
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation_RegisterPickers_23(HandleRef pThis);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x0600A4E4 RID: 42212 RVA: 0x000E9BBC File Offset: 0x000E7DBC
		public override void RegisterPickers()
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_RegisterPickers_23(base.GetCppThis());
		}

		// Token: 0x0600A4E5 RID: 42213
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x0600A4E6 RID: 42214 RVA: 0x000E9BCC File Offset: 0x000E7DCC
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_ReleaseGraphicsResources_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A4E7 RID: 42215
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedButtonRepresentation_RenderOpaqueGeometry_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x0600A4E8 RID: 42216 RVA: 0x000E9BFC File Offset: 0x000E7DFC
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_RenderOpaqueGeometry_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A4E9 RID: 42217
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTexturedButtonRepresentation_RenderTranslucentPolygonalGeometry_26(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x0600A4EA RID: 42218 RVA: 0x000E9C30 File Offset: 0x000E7E30
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_RenderTranslucentPolygonalGeometry_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A4EB RID: 42219
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTexturedButtonRepresentation_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of the class.
		/// </summary>
		// Token: 0x0600A4EC RID: 42220 RVA: 0x000E9C64 File Offset: 0x000E7E64
		public new static vtkTexturedButtonRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkTexturedButtonRepresentation vtkTexturedButtonRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexturedButtonRepresentation = (vtkTexturedButtonRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexturedButtonRepresentation.Register(null);
				}
			}
			return vtkTexturedButtonRepresentation;
		}

		// Token: 0x0600A4ED RID: 42221
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation_SetButtonGeometry_28(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Set/Get the polydata which defines the button geometry.
		/// </summary>
		// Token: 0x0600A4EE RID: 42222 RVA: 0x000E9CE4 File Offset: 0x000E7EE4
		public void SetButtonGeometry(vtkPolyData pd)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_SetButtonGeometry_28(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600A4EF RID: 42223
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation_SetButtonGeometryConnection_29(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Set/Get the polydata which defines the button geometry.
		/// </summary>
		// Token: 0x0600A4F0 RID: 42224 RVA: 0x000E9D14 File Offset: 0x000E7F14
		public void SetButtonGeometryConnection(vtkAlgorithmOutput algOutput)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_SetButtonGeometryConnection_29(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0600A4F1 RID: 42225
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation_SetButtonTexture_30(HandleRef pThis, int i, HandleRef image);

		/// <summary>
		/// Add the ith texture corresponding to the ith button state.
		/// The parameter i should be (0 &lt;= i &lt; NumberOfStates).
		/// </summary>
		// Token: 0x0600A4F2 RID: 42226 RVA: 0x000E9D44 File Offset: 0x000E7F44
		public void SetButtonTexture(int i, vtkImageData image)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_SetButtonTexture_30(base.GetCppThis(), i, (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		// Token: 0x0600A4F3 RID: 42227
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation_SetFollowCamera_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether the button should always face the camera. If enabled,
		/// the button rotates as the camera moves.
		/// </summary>
		// Token: 0x0600A4F4 RID: 42228 RVA: 0x000E9D74 File Offset: 0x000E7F74
		public virtual void SetFollowCamera(int _arg)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_SetFollowCamera_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A4F5 RID: 42229
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation_SetHoveringProperty_32(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Specify the property to use when the hovering over the button.
		/// </summary>
		// Token: 0x0600A4F6 RID: 42230 RVA: 0x000E9D84 File Offset: 0x000E7F84
		public virtual void SetHoveringProperty(vtkProperty p)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_SetHoveringProperty_32(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600A4F7 RID: 42231
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation_SetProperty_33(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Specify the property to use when the button is to appear "normal"
		/// i.e., the mouse pointer is not hovering or selecting the button.
		/// </summary>
		// Token: 0x0600A4F8 RID: 42232 RVA: 0x000E9DB4 File Offset: 0x000E7FB4
		public virtual void SetProperty(vtkProperty p)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_SetProperty_33(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600A4F9 RID: 42233
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation_SetSelectingProperty_34(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Specify the property to use when selecting the button.
		/// </summary>
		// Token: 0x0600A4FA RID: 42234 RVA: 0x000E9DE4 File Offset: 0x000E7FE4
		public virtual void SetSelectingProperty(vtkProperty p)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_SetSelectingProperty_34(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600A4FB RID: 42235
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTexturedButtonRepresentation_ShallowCopy_35(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x0600A4FC RID: 42236 RVA: 0x000E9E14 File Offset: 0x000E8014
		public override void ShallowCopy(vtkProp prop)
		{
			vtkTexturedButtonRepresentation.vtkTexturedButtonRepresentation_ShallowCopy_35(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D25 RID: 3365
		public new const string MRFullTypeName = "Kitware.VTK.vtkTexturedButtonRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D26 RID: 3366
		public new static readonly string MRClassNameKey = "class vtkTexturedButtonRepresentation";
	}
}
