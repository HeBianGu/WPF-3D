using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSphereWidget
	/// </summary>
	/// <remarks>
	///    3D widget for manipulating a sphere
	///
	/// This 3D widget defines a sphere that can be interactively placed in a
	/// scene.
	///
	/// To use this object, just invoke SetInteractor() with the argument of the
	/// method a vtkRenderWindowInteractor.  You may also wish to invoke
	/// "PlaceWidget()" to initially position the widget. The interactor will act
	/// normally until the "i" key (for "interactor") is pressed, at which point the
	/// vtkSphereWidget will appear. (See superclass documentation for information
	/// about changing this behavior.)
	/// Events that occur outside of the widget (i.e., no part of
	/// the widget is picked) are propagated to any other registered obsevers
	/// (such as the interaction style).  Turn off the widget by pressing the "i"
	/// key again (or invoke the Off() method).
	///
	/// The vtkSphereWidget has several methods that can be used in conjunction
	/// with other VTK objects. The Set/GetThetaResolution() and
	/// Set/GetPhiResolution() methods control the number of subdivisions of the
	/// sphere in the theta and phi directions; the GetPolyData() method can be
	/// used to get the polygonal representation and can be used for things like
	/// seeding streamlines. The GetSphere() method returns a sphere implicit
	/// function that can be used for cutting and clipping. Typical usage of the
	/// widget is to make use of the StartInteractionEvent, InteractionEvent, and
	/// EndInteractionEvent events. The InteractionEvent is called on mouse
	/// motion; the other two events are called on button down and button up
	/// (any mouse button).
	///
	/// Some additional features of this class include the ability to control the
	/// properties of the widget. You can set the properties of the selected and
	/// unselected representations of the sphere.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DWidget vtkLineWidget vtkBoxWidget vtkPlaneWidget
	/// </seealso>
	// Token: 0x0200037B RID: 891
	public class vtkSphereWidget : vtk3DWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A1FF RID: 41471 RVA: 0x000E5CA0 File Offset: 0x000E3EA0
		static vtkSphereWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphereWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A200 RID: 41472 RVA: 0x000E5CC8 File Offset: 0x000E3EC8
		public vtkSphereWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A201 RID: 41473
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A202 RID: 41474 RVA: 0x000E5CD8 File Offset: 0x000E3ED8
		public new static vtkSphereWidget New()
		{
			vtkSphereWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A203 RID: 41475 RVA: 0x000E5D2C File Offset: 0x000E3F2C
		public vtkSphereWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSphereWidget.vtkSphereWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A204 RID: 41476 RVA: 0x000E5D70 File Offset: 0x000E3F70
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A205 RID: 41477
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereWidget_GetCenter_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the center of the sphere.
		/// </summary>
		// Token: 0x0600A206 RID: 41478 RVA: 0x000E5D7C File Offset: 0x000E3F7C
		public double[] GetCenter()
		{
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A207 RID: 41479
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_GetCenter_02(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set/Get the center of the sphere.
		/// </summary>
		// Token: 0x0600A208 RID: 41480 RVA: 0x000E5DC4 File Offset: 0x000E3FC4
		public void GetCenter(IntPtr xyz)
		{
			vtkSphereWidget.vtkSphereWidget_GetCenter_02(base.GetCppThis(), xyz);
		}

		// Token: 0x0600A209 RID: 41481
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereWidget_GetHandleDirection_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the direction vector of the handle relative to the center of
		/// the sphere. The direction of the handle is from the sphere center to
		/// the handle position.
		/// </summary>
		// Token: 0x0600A20A RID: 41482 RVA: 0x000E5DD4 File Offset: 0x000E3FD4
		public virtual double[] GetHandleDirection()
		{
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_GetHandleDirection_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A20B RID: 41483
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_GetHandleDirection_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the direction vector of the handle relative to the center of
		/// the sphere. The direction of the handle is from the sphere center to
		/// the handle position.
		/// </summary>
		// Token: 0x0600A20C RID: 41484 RVA: 0x000E5E1C File Offset: 0x000E401C
		public virtual void GetHandleDirection(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkSphereWidget.vtkSphereWidget_GetHandleDirection_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600A20D RID: 41485
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_GetHandleDirection_05(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the direction vector of the handle relative to the center of
		/// the sphere. The direction of the handle is from the sphere center to
		/// the handle position.
		/// </summary>
		// Token: 0x0600A20E RID: 41486 RVA: 0x000E5E2E File Offset: 0x000E402E
		public virtual void GetHandleDirection(IntPtr _arg)
		{
			vtkSphereWidget.vtkSphereWidget_GetHandleDirection_05(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A20F RID: 41487
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereWidget_GetHandlePosition_06(HandleRef pThis);

		/// <summary>
		/// Get the position of the handle.
		/// </summary>
		// Token: 0x0600A210 RID: 41488 RVA: 0x000E5E40 File Offset: 0x000E4040
		public virtual double[] GetHandlePosition()
		{
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_GetHandlePosition_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A211 RID: 41489
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_GetHandlePosition_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get the position of the handle.
		/// </summary>
		// Token: 0x0600A212 RID: 41490 RVA: 0x000E5E88 File Offset: 0x000E4088
		public virtual void GetHandlePosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkSphereWidget.vtkSphereWidget_GetHandlePosition_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600A213 RID: 41491
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_GetHandlePosition_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the position of the handle.
		/// </summary>
		// Token: 0x0600A214 RID: 41492 RVA: 0x000E5E9A File Offset: 0x000E409A
		public virtual void GetHandlePosition(IntPtr _arg)
		{
			vtkSphereWidget.vtkSphereWidget_GetHandlePosition_08(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A215 RID: 41493
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereWidget_GetHandleProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little ball on the sphere is the
		/// handle). The properties of the handle when selected and unselected
		/// can be manipulated.
		/// </summary>
		// Token: 0x0600A216 RID: 41494 RVA: 0x000E5EAC File Offset: 0x000E40AC
		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_GetHandleProperty_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A217 RID: 41495
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereWidget_GetHandleVisibility_10(HandleRef pThis);

		/// <summary>
		/// The handle sits on the surface of the sphere and may be moved around
		/// the surface by picking (left mouse) and then moving. The position
		/// of the handle can be retrieved, this is useful for positioning cameras
		/// and lights. By default, the handle is turned off.
		/// </summary>
		// Token: 0x0600A218 RID: 41496 RVA: 0x000E5F1C File Offset: 0x000E411C
		public virtual int GetHandleVisibility()
		{
			return vtkSphereWidget.vtkSphereWidget_GetHandleVisibility_10(base.GetCppThis());
		}

		// Token: 0x0600A219 RID: 41497
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphereWidget_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A21A RID: 41498 RVA: 0x000E5F3C File Offset: 0x000E413C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSphereWidget.vtkSphereWidget_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0600A21B RID: 41499
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphereWidget_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A21C RID: 41500 RVA: 0x000E5F5C File Offset: 0x000E415C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSphereWidget.vtkSphereWidget_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0600A21D RID: 41501
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereWidget_GetPhiResolution_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the resolution of the sphere in the Phi direction.
		/// The default is 8.
		/// </summary>
		// Token: 0x0600A21E RID: 41502 RVA: 0x000E5F78 File Offset: 0x000E4178
		public int GetPhiResolution()
		{
			return vtkSphereWidget.vtkSphereWidget_GetPhiResolution_13(base.GetCppThis());
		}

		// Token: 0x0600A21F RID: 41503
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_GetPolyData_14(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata (including points) that defines the sphere.  The
		/// polydata consists of n+1 points, where n is the resolution of the
		/// sphere. These point values are guaranteed to be up-to-date when either the
		/// InteractionEvent or EndInteraction events are invoked. The user provides
		/// the vtkPolyData and the points and polysphere are added to it.
		/// </summary>
		// Token: 0x0600A220 RID: 41504 RVA: 0x000E5F98 File Offset: 0x000E4198
		public void GetPolyData(vtkPolyData pd)
		{
			vtkSphereWidget.vtkSphereWidget_GetPolyData_14(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600A221 RID: 41505
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereWidget_GetRadius_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius of sphere. Default is .5.
		/// </summary>
		// Token: 0x0600A222 RID: 41506 RVA: 0x000E5FC8 File Offset: 0x000E41C8
		public double GetRadius()
		{
			return vtkSphereWidget.vtkSphereWidget_GetRadius_15(base.GetCppThis());
		}

		// Token: 0x0600A223 RID: 41507
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereWidget_GetRepresentation_16(HandleRef pThis);

		/// <summary>
		/// Set the representation of the sphere. Different representations are
		/// useful depending on the application. The default is
		/// VTK_SPHERE_WIREFRAME.
		/// </summary>
		// Token: 0x0600A224 RID: 41508 RVA: 0x000E5FE8 File Offset: 0x000E41E8
		public virtual int GetRepresentation()
		{
			return vtkSphereWidget.vtkSphereWidget_GetRepresentation_16(base.GetCppThis());
		}

		// Token: 0x0600A225 RID: 41509
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereWidget_GetRepresentationMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Set the representation of the sphere. Different representations are
		/// useful depending on the application. The default is
		/// VTK_SPHERE_WIREFRAME.
		/// </summary>
		// Token: 0x0600A226 RID: 41510 RVA: 0x000E6008 File Offset: 0x000E4208
		public virtual int GetRepresentationMaxValue()
		{
			return vtkSphereWidget.vtkSphereWidget_GetRepresentationMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0600A227 RID: 41511
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereWidget_GetRepresentationMinValue_18(HandleRef pThis);

		/// <summary>
		/// Set the representation of the sphere. Different representations are
		/// useful depending on the application. The default is
		/// VTK_SPHERE_WIREFRAME.
		/// </summary>
		// Token: 0x0600A228 RID: 41512 RVA: 0x000E6028 File Offset: 0x000E4228
		public virtual int GetRepresentationMinValue()
		{
			return vtkSphereWidget.vtkSphereWidget_GetRepresentationMinValue_18(base.GetCppThis());
		}

		// Token: 0x0600A229 RID: 41513
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereWidget_GetScale_19(HandleRef pThis);

		/// <summary>
		/// Enable translation and scaling of the widget. By default, the widget
		/// can be translated and rotated.
		/// </summary>
		// Token: 0x0600A22A RID: 41514 RVA: 0x000E6048 File Offset: 0x000E4248
		public virtual int GetScale()
		{
			return vtkSphereWidget.vtkSphereWidget_GetScale_19(base.GetCppThis());
		}

		// Token: 0x0600A22B RID: 41515
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereWidget_GetSelectedHandleProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little ball on the sphere is the
		/// handle). The properties of the handle when selected and unselected
		/// can be manipulated.
		/// </summary>
		// Token: 0x0600A22C RID: 41516 RVA: 0x000E6068 File Offset: 0x000E4268
		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_GetSelectedHandleProperty_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A22D RID: 41517
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereWidget_GetSelectedSphereProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the sphere properties. The properties of the sphere when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600A22E RID: 41518 RVA: 0x000E60D8 File Offset: 0x000E42D8
		public virtual vtkProperty GetSelectedSphereProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_GetSelectedSphereProperty_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A22F RID: 41519
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_GetSphere_22(HandleRef pThis, HandleRef sphere);

		/// <summary>
		/// Get the spherical implicit function defined by this widget.  Note that
		/// vtkSphere is a subclass of vtkImplicitFunction, meaning that it can be
		/// used by a variety of filters to perform clipping, cutting, and selection
		/// of data.
		/// </summary>
		// Token: 0x0600A230 RID: 41520 RVA: 0x000E6148 File Offset: 0x000E4348
		public void GetSphere(vtkSphere sphere)
		{
			vtkSphereWidget.vtkSphereWidget_GetSphere_22(base.GetCppThis(), (sphere == null) ? default(HandleRef) : sphere.GetCppThis());
		}

		// Token: 0x0600A231 RID: 41521
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereWidget_GetSphereProperty_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the sphere properties. The properties of the sphere when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600A232 RID: 41522 RVA: 0x000E6178 File Offset: 0x000E4378
		public virtual vtkProperty GetSphereProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_GetSphereProperty_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A233 RID: 41523
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereWidget_GetThetaResolution_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the resolution of the sphere in the Theta direction.
		/// The default is 16.
		/// </summary>
		// Token: 0x0600A234 RID: 41524 RVA: 0x000E61E8 File Offset: 0x000E43E8
		public int GetThetaResolution()
		{
			return vtkSphereWidget.vtkSphereWidget_GetThetaResolution_24(base.GetCppThis());
		}

		// Token: 0x0600A235 RID: 41525
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereWidget_GetTranslation_25(HandleRef pThis);

		/// <summary>
		/// Enable translation and scaling of the widget. By default, the widget
		/// can be translated and rotated.
		/// </summary>
		// Token: 0x0600A236 RID: 41526 RVA: 0x000E6208 File Offset: 0x000E4408
		public virtual int GetTranslation()
		{
			return vtkSphereWidget.vtkSphereWidget_GetTranslation_25(base.GetCppThis());
		}

		// Token: 0x0600A237 RID: 41527
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_HandleVisibilityOff_26(HandleRef pThis);

		/// <summary>
		/// The handle sits on the surface of the sphere and may be moved around
		/// the surface by picking (left mouse) and then moving. The position
		/// of the handle can be retrieved, this is useful for positioning cameras
		/// and lights. By default, the handle is turned off.
		/// </summary>
		// Token: 0x0600A238 RID: 41528 RVA: 0x000E6227 File Offset: 0x000E4427
		public virtual void HandleVisibilityOff()
		{
			vtkSphereWidget.vtkSphereWidget_HandleVisibilityOff_26(base.GetCppThis());
		}

		// Token: 0x0600A239 RID: 41529
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_HandleVisibilityOn_27(HandleRef pThis);

		/// <summary>
		/// The handle sits on the surface of the sphere and may be moved around
		/// the surface by picking (left mouse) and then moving. The position
		/// of the handle can be retrieved, this is useful for positioning cameras
		/// and lights. By default, the handle is turned off.
		/// </summary>
		// Token: 0x0600A23A RID: 41530 RVA: 0x000E6236 File Offset: 0x000E4436
		public virtual void HandleVisibilityOn()
		{
			vtkSphereWidget.vtkSphereWidget_HandleVisibilityOn_27(base.GetCppThis());
		}

		// Token: 0x0600A23B RID: 41531
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereWidget_IsA_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A23C RID: 41532 RVA: 0x000E6248 File Offset: 0x000E4448
		public override int IsA(string type)
		{
			return vtkSphereWidget.vtkSphereWidget_IsA_28(base.GetCppThis(), type);
		}

		// Token: 0x0600A23D RID: 41533
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereWidget_IsTypeOf_29([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A23E RID: 41534 RVA: 0x000E6268 File Offset: 0x000E4468
		public new static int IsTypeOf(string type)
		{
			return vtkSphereWidget.vtkSphereWidget_IsTypeOf_29(type);
		}

		// Token: 0x0600A23F RID: 41535
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereWidget_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A240 RID: 41536 RVA: 0x000E6284 File Offset: 0x000E4484
		public new vtkSphereWidget NewInstance()
		{
			vtkSphereWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_NewInstance_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A241 RID: 41537
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_PlaceWidget_32(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600A242 RID: 41538 RVA: 0x000E62DE File Offset: 0x000E44DE
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkSphereWidget.vtkSphereWidget_PlaceWidget_32(base.GetCppThis(), bounds);
		}

		// Token: 0x0600A243 RID: 41539
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_PlaceWidget_33(HandleRef pThis);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600A244 RID: 41540 RVA: 0x000E62EE File Offset: 0x000E44EE
		public override void PlaceWidget()
		{
			vtkSphereWidget.vtkSphereWidget_PlaceWidget_33(base.GetCppThis());
		}

		// Token: 0x0600A245 RID: 41541
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_PlaceWidget_34(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600A246 RID: 41542 RVA: 0x000E62FD File Offset: 0x000E44FD
		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkSphereWidget.vtkSphereWidget_PlaceWidget_34(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x0600A247 RID: 41543
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereWidget_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A248 RID: 41544 RVA: 0x000E6318 File Offset: 0x000E4518
		public new static vtkSphereWidget SafeDownCast(vtkObjectBase o)
		{
			vtkSphereWidget vtkSphereWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereWidget.vtkSphereWidget_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphereWidget = (vtkSphereWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphereWidget.Register(null);
				}
			}
			return vtkSphereWidget;
		}

		// Token: 0x0600A249 RID: 41545
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_ScaleOff_36(HandleRef pThis);

		/// <summary>
		/// Enable translation and scaling of the widget. By default, the widget
		/// can be translated and rotated.
		/// </summary>
		// Token: 0x0600A24A RID: 41546 RVA: 0x000E6397 File Offset: 0x000E4597
		public virtual void ScaleOff()
		{
			vtkSphereWidget.vtkSphereWidget_ScaleOff_36(base.GetCppThis());
		}

		// Token: 0x0600A24B RID: 41547
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_ScaleOn_37(HandleRef pThis);

		/// <summary>
		/// Enable translation and scaling of the widget. By default, the widget
		/// can be translated and rotated.
		/// </summary>
		// Token: 0x0600A24C RID: 41548 RVA: 0x000E63A6 File Offset: 0x000E45A6
		public virtual void ScaleOn()
		{
			vtkSphereWidget.vtkSphereWidget_ScaleOn_37(base.GetCppThis());
		}

		// Token: 0x0600A24D RID: 41549
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_SetCenter_38(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the center of the sphere.
		/// </summary>
		// Token: 0x0600A24E RID: 41550 RVA: 0x000E63B5 File Offset: 0x000E45B5
		public void SetCenter(double x, double y, double z)
		{
			vtkSphereWidget.vtkSphereWidget_SetCenter_38(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600A24F RID: 41551
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_SetCenter_39(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Set/Get the center of the sphere.
		/// </summary>
		// Token: 0x0600A250 RID: 41552 RVA: 0x000E63C7 File Offset: 0x000E45C7
		public void SetCenter(IntPtr x)
		{
			vtkSphereWidget.vtkSphereWidget_SetCenter_39(base.GetCppThis(), x);
		}

		// Token: 0x0600A251 RID: 41553
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_SetEnabled_40(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x0600A252 RID: 41554 RVA: 0x000E63D7 File Offset: 0x000E45D7
		public override void SetEnabled(int arg0)
		{
			vtkSphereWidget.vtkSphereWidget_SetEnabled_40(base.GetCppThis(), arg0);
		}

		// Token: 0x0600A253 RID: 41555
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_SetHandleDirection_41(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the direction vector of the handle relative to the center of
		/// the sphere. The direction of the handle is from the sphere center to
		/// the handle position.
		/// </summary>
		// Token: 0x0600A254 RID: 41556 RVA: 0x000E63E7 File Offset: 0x000E45E7
		public virtual void SetHandleDirection(double _arg1, double _arg2, double _arg3)
		{
			vtkSphereWidget.vtkSphereWidget_SetHandleDirection_41(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600A255 RID: 41557
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_SetHandleDirection_42(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the direction vector of the handle relative to the center of
		/// the sphere. The direction of the handle is from the sphere center to
		/// the handle position.
		/// </summary>
		// Token: 0x0600A256 RID: 41558 RVA: 0x000E63F9 File Offset: 0x000E45F9
		public virtual void SetHandleDirection(IntPtr _arg)
		{
			vtkSphereWidget.vtkSphereWidget_SetHandleDirection_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A257 RID: 41559
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_SetHandleVisibility_43(HandleRef pThis, int _arg);

		/// <summary>
		/// The handle sits on the surface of the sphere and may be moved around
		/// the surface by picking (left mouse) and then moving. The position
		/// of the handle can be retrieved, this is useful for positioning cameras
		/// and lights. By default, the handle is turned off.
		/// </summary>
		// Token: 0x0600A258 RID: 41560 RVA: 0x000E6409 File Offset: 0x000E4609
		public virtual void SetHandleVisibility(int _arg)
		{
			vtkSphereWidget.vtkSphereWidget_SetHandleVisibility_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A259 RID: 41561
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_SetPhiResolution_44(HandleRef pThis, int r);

		/// <summary>
		/// Set/Get the resolution of the sphere in the Phi direction.
		/// The default is 8.
		/// </summary>
		// Token: 0x0600A25A RID: 41562 RVA: 0x000E6419 File Offset: 0x000E4619
		public void SetPhiResolution(int r)
		{
			vtkSphereWidget.vtkSphereWidget_SetPhiResolution_44(base.GetCppThis(), r);
		}

		// Token: 0x0600A25B RID: 41563
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_SetRadius_45(HandleRef pThis, double r);

		/// <summary>
		/// Set/Get the radius of sphere. Default is .5.
		/// </summary>
		// Token: 0x0600A25C RID: 41564 RVA: 0x000E6429 File Offset: 0x000E4629
		public void SetRadius(double r)
		{
			vtkSphereWidget.vtkSphereWidget_SetRadius_45(base.GetCppThis(), r);
		}

		// Token: 0x0600A25D RID: 41565
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_SetRepresentation_46(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the representation of the sphere. Different representations are
		/// useful depending on the application. The default is
		/// VTK_SPHERE_WIREFRAME.
		/// </summary>
		// Token: 0x0600A25E RID: 41566 RVA: 0x000E6439 File Offset: 0x000E4639
		public virtual void SetRepresentation(int _arg)
		{
			vtkSphereWidget.vtkSphereWidget_SetRepresentation_46(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A25F RID: 41567
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_SetRepresentationToOff_47(HandleRef pThis);

		/// <summary>
		/// Set the representation of the sphere. Different representations are
		/// useful depending on the application. The default is
		/// VTK_SPHERE_WIREFRAME.
		/// </summary>
		// Token: 0x0600A260 RID: 41568 RVA: 0x000E6449 File Offset: 0x000E4649
		public void SetRepresentationToOff()
		{
			vtkSphereWidget.vtkSphereWidget_SetRepresentationToOff_47(base.GetCppThis());
		}

		// Token: 0x0600A261 RID: 41569
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_SetRepresentationToSurface_48(HandleRef pThis);

		/// <summary>
		/// Set the representation of the sphere. Different representations are
		/// useful depending on the application. The default is
		/// VTK_SPHERE_WIREFRAME.
		/// </summary>
		// Token: 0x0600A262 RID: 41570 RVA: 0x000E6458 File Offset: 0x000E4658
		public void SetRepresentationToSurface()
		{
			vtkSphereWidget.vtkSphereWidget_SetRepresentationToSurface_48(base.GetCppThis());
		}

		// Token: 0x0600A263 RID: 41571
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_SetRepresentationToWireframe_49(HandleRef pThis);

		/// <summary>
		/// Set the representation of the sphere. Different representations are
		/// useful depending on the application. The default is
		/// VTK_SPHERE_WIREFRAME.
		/// </summary>
		// Token: 0x0600A264 RID: 41572 RVA: 0x000E6467 File Offset: 0x000E4667
		public void SetRepresentationToWireframe()
		{
			vtkSphereWidget.vtkSphereWidget_SetRepresentationToWireframe_49(base.GetCppThis());
		}

		// Token: 0x0600A265 RID: 41573
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_SetScale_50(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable translation and scaling of the widget. By default, the widget
		/// can be translated and rotated.
		/// </summary>
		// Token: 0x0600A266 RID: 41574 RVA: 0x000E6476 File Offset: 0x000E4676
		public virtual void SetScale(int _arg)
		{
			vtkSphereWidget.vtkSphereWidget_SetScale_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A267 RID: 41575
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_SetThetaResolution_51(HandleRef pThis, int r);

		/// <summary>
		/// Set/Get the resolution of the sphere in the Theta direction.
		/// The default is 16.
		/// </summary>
		// Token: 0x0600A268 RID: 41576 RVA: 0x000E6486 File Offset: 0x000E4686
		public void SetThetaResolution(int r)
		{
			vtkSphereWidget.vtkSphereWidget_SetThetaResolution_51(base.GetCppThis(), r);
		}

		// Token: 0x0600A269 RID: 41577
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_SetTranslation_52(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable translation and scaling of the widget. By default, the widget
		/// can be translated and rotated.
		/// </summary>
		// Token: 0x0600A26A RID: 41578 RVA: 0x000E6496 File Offset: 0x000E4696
		public virtual void SetTranslation(int _arg)
		{
			vtkSphereWidget.vtkSphereWidget_SetTranslation_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A26B RID: 41579
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_TranslationOff_53(HandleRef pThis);

		/// <summary>
		/// Enable translation and scaling of the widget. By default, the widget
		/// can be translated and rotated.
		/// </summary>
		// Token: 0x0600A26C RID: 41580 RVA: 0x000E64A6 File Offset: 0x000E46A6
		public virtual void TranslationOff()
		{
			vtkSphereWidget.vtkSphereWidget_TranslationOff_53(base.GetCppThis());
		}

		// Token: 0x0600A26D RID: 41581
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereWidget_TranslationOn_54(HandleRef pThis);

		/// <summary>
		/// Enable translation and scaling of the widget. By default, the widget
		/// can be translated and rotated.
		/// </summary>
		// Token: 0x0600A26E RID: 41582 RVA: 0x000E64B5 File Offset: 0x000E46B5
		public virtual void TranslationOn()
		{
			vtkSphereWidget.vtkSphereWidget_TranslationOn_54(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D04 RID: 3332
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphereWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D05 RID: 3333
		public new static readonly string MRClassNameKey = "class vtkSphereWidget";
	}
}
