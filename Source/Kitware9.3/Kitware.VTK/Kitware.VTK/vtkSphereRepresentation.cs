using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSphereRepresentation
	/// </summary>
	/// <remarks>
	///    a class defining the representation for the vtkSphereWidget2
	///
	/// This class is a concrete representation for the vtkSphereWidget2. It
	/// represents a sphere with an optional handle.  Through interaction with the
	/// widget, the sphere can be arbitrarily positioned and scaled in 3D space;
	/// and the handle can be moved on the surface of the sphere. Typically the
	/// vtkSphereWidget2/vtkSphereRepresentation are used to position a sphere for
	/// the purpose of extracting, cutting or clipping data; or the handle is
	/// moved on the sphere to position a light or camera.
	///
	/// To use this representation, you normally use the PlaceWidget() method
	/// to position the widget at a specified region in space. It is also possible
	/// to set the center of the sphere, a radius, and/or a handle position.
	///
	/// @warning
	/// Note that the representation is overconstrained in that the center and radius
	/// of the sphere can be defined, this information plus the handle direction defines
	/// the geometry of the representation. Alternatively, the user may specify the center
	/// of the sphere plus the handle position.
	///
	/// @warning
	/// This class, and vtkSphereWidget2, are second generation VTK widgets. An
	/// earlier version of this functionality was defined in the class
	/// vtkSphereWidget.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSphereWidget2 vtkSphereWidget
	/// </seealso>
	// Token: 0x02000379 RID: 889
	public class vtkSphereRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A14D RID: 41293 RVA: 0x000E5069 File Offset: 0x000E3269
		static vtkSphereRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphereRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A14E RID: 41294 RVA: 0x000E5091 File Offset: 0x000E3291
		public vtkSphereRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A14F RID: 41295
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600A150 RID: 41296 RVA: 0x000E50A0 File Offset: 0x000E32A0
		public new static vtkSphereRepresentation New()
		{
			vtkSphereRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600A151 RID: 41297 RVA: 0x000E50F4 File Offset: 0x000E32F4
		public vtkSphereRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSphereRepresentation.vtkSphereRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A152 RID: 41298 RVA: 0x000E5138 File Offset: 0x000E3338
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A153 RID: 41299
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API. Note that a
		/// version of place widget is available where the center and handle position
		/// are specified.
		/// </summary>
		// Token: 0x0600A154 RID: 41300 RVA: 0x000E5143 File Offset: 0x000E3343
		public override void BuildRepresentation()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600A155 RID: 41301
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_CenterCursorOff_02(HandleRef pThis);

		/// <summary>
		/// Enable/disable a center cursor
		/// Default is disabled
		/// </summary>
		// Token: 0x0600A156 RID: 41302 RVA: 0x000E5152 File Offset: 0x000E3352
		public virtual void CenterCursorOff()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_CenterCursorOff_02(base.GetCppThis());
		}

		// Token: 0x0600A157 RID: 41303
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_CenterCursorOn_03(HandleRef pThis);

		/// <summary>
		/// Enable/disable a center cursor
		/// Default is disabled
		/// </summary>
		// Token: 0x0600A158 RID: 41304 RVA: 0x000E5161 File Offset: 0x000E3361
		public virtual void CenterCursorOn()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_CenterCursorOn_03(base.GetCppThis());
		}

		// Token: 0x0600A159 RID: 41305
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API. Note that a
		/// version of place widget is available where the center and handle position
		/// are specified.
		/// </summary>
		// Token: 0x0600A15A RID: 41306 RVA: 0x000E5170 File Offset: 0x000E3370
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_ComputeInteractionState_04(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x0600A15B RID: 41307
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereRepresentation_GetBounds_05(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API. Note that a
		/// version of place widget is available where the center and handle position
		/// are specified.
		/// </summary>
		// Token: 0x0600A15C RID: 41308 RVA: 0x000E5194 File Offset: 0x000E3394
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A15D RID: 41309
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereRepresentation_GetCenter_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the center position of the sphere. Note that this may
		/// adjust the direction from the handle to the center, as well as
		/// the radius of the sphere.
		/// </summary>
		// Token: 0x0600A15E RID: 41310 RVA: 0x000E51DC File Offset: 0x000E33DC
		public double[] GetCenter()
		{
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetCenter_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A15F RID: 41311
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_GetCenter_07(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set/Get the center position of the sphere. Note that this may
		/// adjust the direction from the handle to the center, as well as
		/// the radius of the sphere.
		/// </summary>
		// Token: 0x0600A160 RID: 41312 RVA: 0x000E5224 File Offset: 0x000E3424
		public void GetCenter(IntPtr xyz)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_GetCenter_07(base.GetCppThis(), xyz);
		}

		// Token: 0x0600A161 RID: 41313
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSphereRepresentation_GetCenterCursor_08(HandleRef pThis);

		/// <summary>
		/// Enable/disable a center cursor
		/// Default is disabled
		/// </summary>
		// Token: 0x0600A162 RID: 41314 RVA: 0x000E5234 File Offset: 0x000E3434
		public virtual bool GetCenterCursor()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetCenterCursor_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0600A163 RID: 41315
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereRepresentation_GetHandleDirection_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the direction vector of the handle relative to the center of
		/// the sphere. Setting the direction may affect the position of the handle
		/// but will not affect the radius or position of the sphere.
		/// </summary>
		// Token: 0x0600A164 RID: 41316 RVA: 0x000E525C File Offset: 0x000E345C
		public virtual double[] GetHandleDirection()
		{
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetHandleDirection_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A165 RID: 41317
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_GetHandleDirection_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the direction vector of the handle relative to the center of
		/// the sphere. Setting the direction may affect the position of the handle
		/// but will not affect the radius or position of the sphere.
		/// </summary>
		// Token: 0x0600A166 RID: 41318 RVA: 0x000E52A4 File Offset: 0x000E34A4
		public virtual void GetHandleDirection(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_GetHandleDirection_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600A167 RID: 41319
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_GetHandleDirection_11(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the direction vector of the handle relative to the center of
		/// the sphere. Setting the direction may affect the position of the handle
		/// but will not affect the radius or position of the sphere.
		/// </summary>
		// Token: 0x0600A168 RID: 41320 RVA: 0x000E52B6 File Offset: 0x000E34B6
		public virtual void GetHandleDirection(IntPtr _arg)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_GetHandleDirection_11(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A169 RID: 41321
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereRepresentation_GetHandlePosition_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of the handle. Note that this may adjust the radius
		/// of the sphere and the handle direction.
		/// </summary>
		// Token: 0x0600A16A RID: 41322 RVA: 0x000E52C8 File Offset: 0x000E34C8
		public virtual double[] GetHandlePosition()
		{
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetHandlePosition_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A16B RID: 41323
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_GetHandlePosition_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the position of the handle. Note that this may adjust the radius
		/// of the sphere and the handle direction.
		/// </summary>
		// Token: 0x0600A16C RID: 41324 RVA: 0x000E5310 File Offset: 0x000E3510
		public virtual void GetHandlePosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_GetHandlePosition_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600A16D RID: 41325
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_GetHandlePosition_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the position of the handle. Note that this may adjust the radius
		/// of the sphere and the handle direction.
		/// </summary>
		// Token: 0x0600A16E RID: 41326 RVA: 0x000E5322 File Offset: 0x000E3522
		public virtual void GetHandlePosition(IntPtr _arg)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_GetHandlePosition_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A16F RID: 41327
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereRepresentation_GetHandleProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little ball on the sphere is the
		/// handle). The properties of the handle when selected and unselected
		/// can be manipulated. Also applied to the center cursor.
		/// </summary>
		// Token: 0x0600A170 RID: 41328 RVA: 0x000E5334 File Offset: 0x000E3534
		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetHandleProperty_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A171 RID: 41329
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_GetHandleText_16(HandleRef pThis);

		/// <summary>
		/// Enable/disable a label that displays the location of the handle in
		/// spherical coordinates (radius,theta,phi). The two angles, theta and
		/// phi, are displayed in degrees. Note that phi is measured from the
		/// north pole down towards the equator; and theta is the angle around
		/// the north/south axis.
		/// </summary>
		// Token: 0x0600A172 RID: 41330 RVA: 0x000E53A4 File Offset: 0x000E35A4
		public virtual int GetHandleText()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetHandleText_16(base.GetCppThis());
		}

		// Token: 0x0600A173 RID: 41331
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereRepresentation_GetHandleTextProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle text property. This can be used to control the appearance
		/// of the handle text.
		/// </summary>
		// Token: 0x0600A174 RID: 41332 RVA: 0x000E53C4 File Offset: 0x000E35C4
		public virtual vtkTextProperty GetHandleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetHandleTextProperty_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A175 RID: 41333
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_GetHandleVisibility_18(HandleRef pThis);

		/// <summary>
		/// The handle sits on the surface of the sphere and may be moved around
		/// the surface by picking (left mouse) and then moving. The position
		/// of the handle can be retrieved, this is useful for positioning cameras
		/// and lights. By default, the handle is turned off.
		/// </summary>
		// Token: 0x0600A176 RID: 41334 RVA: 0x000E5434 File Offset: 0x000E3634
		public virtual int GetHandleVisibility()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetHandleVisibility_18(base.GetCppThis());
		}

		// Token: 0x0600A177 RID: 41335
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphereRepresentation_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and to print out the contents of the class.
		/// </summary>
		// Token: 0x0600A178 RID: 41336 RVA: 0x000E5454 File Offset: 0x000E3654
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x0600A179 RID: 41337
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphereRepresentation_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and to print out the contents of the class.
		/// </summary>
		// Token: 0x0600A17A RID: 41338 RVA: 0x000E5474 File Offset: 0x000E3674
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x0600A17B RID: 41339
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_GetPhiResolution_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the resolution of the sphere in the phi direction.
		/// </summary>
		// Token: 0x0600A17C RID: 41340 RVA: 0x000E5490 File Offset: 0x000E3690
		public int GetPhiResolution()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetPhiResolution_21(base.GetCppThis());
		}

		// Token: 0x0600A17D RID: 41341
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_GetPolyData_22(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata (including points) that defines the sphere.  The
		/// polydata consists of n+1 points, where n is the resolution of the
		/// sphere. These point values are guaranteed to be up-to-date when either the
		/// InteractionEvent or EndInteraction events are invoked. The user provides
		/// the vtkPolyData and the points and polysphere are added to it.
		/// </summary>
		// Token: 0x0600A17E RID: 41342 RVA: 0x000E54B0 File Offset: 0x000E36B0
		public void GetPolyData(vtkPolyData pd)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_GetPolyData_22(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600A17F RID: 41343
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_GetRadialLine_23(HandleRef pThis);

		/// <summary>
		/// Enable/disable a radial line segment that joins the center of the
		/// outer sphere and the handle.
		/// </summary>
		// Token: 0x0600A180 RID: 41344 RVA: 0x000E54E0 File Offset: 0x000E36E0
		public virtual int GetRadialLine()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetRadialLine_23(base.GetCppThis());
		}

		// Token: 0x0600A181 RID: 41345
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereRepresentation_GetRadialLineProperty_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property of the radial line. This can be used to control the
		/// appearance of the optional line connecting the center to the handle.
		/// </summary>
		// Token: 0x0600A182 RID: 41346 RVA: 0x000E5500 File Offset: 0x000E3700
		public virtual vtkProperty GetRadialLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetRadialLineProperty_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A183 RID: 41347
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSphereRepresentation_GetRadius_25(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius of sphere. Default is 0.5. Note that this may
		/// modify the position of the handle based on the handle direction.
		/// </summary>
		// Token: 0x0600A184 RID: 41348 RVA: 0x000E5570 File Offset: 0x000E3770
		public double GetRadius()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetRadius_25(base.GetCppThis());
		}

		// Token: 0x0600A185 RID: 41349
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_GetRepresentation_26(HandleRef pThis);

		/// <summary>
		/// Set the representation (i.e., appearance) of the sphere. Different
		/// representations are useful depending on the application.
		/// </summary>
		// Token: 0x0600A186 RID: 41350 RVA: 0x000E5590 File Offset: 0x000E3790
		public virtual int GetRepresentation()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetRepresentation_26(base.GetCppThis());
		}

		// Token: 0x0600A187 RID: 41351
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_GetRepresentationMaxValue_27(HandleRef pThis);

		/// <summary>
		/// Set the representation (i.e., appearance) of the sphere. Different
		/// representations are useful depending on the application.
		/// </summary>
		// Token: 0x0600A188 RID: 41352 RVA: 0x000E55B0 File Offset: 0x000E37B0
		public virtual int GetRepresentationMaxValue()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetRepresentationMaxValue_27(base.GetCppThis());
		}

		// Token: 0x0600A189 RID: 41353
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_GetRepresentationMinValue_28(HandleRef pThis);

		/// <summary>
		/// Set the representation (i.e., appearance) of the sphere. Different
		/// representations are useful depending on the application.
		/// </summary>
		// Token: 0x0600A18A RID: 41354 RVA: 0x000E55D0 File Offset: 0x000E37D0
		public virtual int GetRepresentationMinValue()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetRepresentationMinValue_28(base.GetCppThis());
		}

		// Token: 0x0600A18B RID: 41355
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereRepresentation_GetSelectedHandleProperty_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little ball on the sphere is the
		/// handle). The properties of the handle when selected and unselected
		/// can be manipulated. Also applied to the center cursor.
		/// </summary>
		// Token: 0x0600A18C RID: 41356 RVA: 0x000E55F0 File Offset: 0x000E37F0
		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetSelectedHandleProperty_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A18D RID: 41357
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereRepresentation_GetSelectedSphereProperty_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the sphere properties. The properties of the sphere when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600A18E RID: 41358 RVA: 0x000E5660 File Offset: 0x000E3860
		public virtual vtkProperty GetSelectedSphereProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetSelectedSphereProperty_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A18F RID: 41359
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_GetSphere_31(HandleRef pThis, HandleRef sphere);

		/// <summary>
		/// Get the spherical implicit function defined by this widget.  Note that
		/// vtkSphere is a subclass of vtkImplicitFunction, meaning that it can be
		/// used by a variety of filters to perform clipping, cutting, and selection
		/// of data.
		/// </summary>
		// Token: 0x0600A190 RID: 41360 RVA: 0x000E56D0 File Offset: 0x000E38D0
		public void GetSphere(vtkSphere sphere)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_GetSphere_31(base.GetCppThis(), (sphere == null) ? default(HandleRef) : sphere.GetCppThis());
		}

		// Token: 0x0600A191 RID: 41361
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereRepresentation_GetSphereProperty_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the sphere properties. The properties of the sphere when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x0600A192 RID: 41362 RVA: 0x000E5700 File Offset: 0x000E3900
		public virtual vtkProperty GetSphereProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_GetSphereProperty_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A193 RID: 41363
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_GetThetaResolution_33(HandleRef pThis);

		/// <summary>
		/// Set/Get the resolution of the sphere in the theta direction.
		/// </summary>
		// Token: 0x0600A194 RID: 41364 RVA: 0x000E5770 File Offset: 0x000E3970
		public int GetThetaResolution()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetThetaResolution_33(base.GetCppThis());
		}

		// Token: 0x0600A195 RID: 41365
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_GetTranslationAxis_34(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x0600A196 RID: 41366 RVA: 0x000E5790 File Offset: 0x000E3990
		public virtual int GetTranslationAxis()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetTranslationAxis_34(base.GetCppThis());
		}

		// Token: 0x0600A197 RID: 41367
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_GetTranslationAxisMaxValue_35(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x0600A198 RID: 41368 RVA: 0x000E57B0 File Offset: 0x000E39B0
		public virtual int GetTranslationAxisMaxValue()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetTranslationAxisMaxValue_35(base.GetCppThis());
		}

		// Token: 0x0600A199 RID: 41369
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_GetTranslationAxisMinValue_36(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x0600A19A RID: 41370 RVA: 0x000E57D0 File Offset: 0x000E39D0
		public virtual int GetTranslationAxisMinValue()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_GetTranslationAxisMinValue_36(base.GetCppThis());
		}

		// Token: 0x0600A19B RID: 41371
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_HandleTextOff_37(HandleRef pThis);

		/// <summary>
		/// Enable/disable a label that displays the location of the handle in
		/// spherical coordinates (radius,theta,phi). The two angles, theta and
		/// phi, are displayed in degrees. Note that phi is measured from the
		/// north pole down towards the equator; and theta is the angle around
		/// the north/south axis.
		/// </summary>
		// Token: 0x0600A19C RID: 41372 RVA: 0x000E57EF File Offset: 0x000E39EF
		public virtual void HandleTextOff()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_HandleTextOff_37(base.GetCppThis());
		}

		// Token: 0x0600A19D RID: 41373
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_HandleTextOn_38(HandleRef pThis);

		/// <summary>
		/// Enable/disable a label that displays the location of the handle in
		/// spherical coordinates (radius,theta,phi). The two angles, theta and
		/// phi, are displayed in degrees. Note that phi is measured from the
		/// north pole down towards the equator; and theta is the angle around
		/// the north/south axis.
		/// </summary>
		// Token: 0x0600A19E RID: 41374 RVA: 0x000E57FE File Offset: 0x000E39FE
		public virtual void HandleTextOn()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_HandleTextOn_38(base.GetCppThis());
		}

		// Token: 0x0600A19F RID: 41375
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_HandleVisibilityOff_39(HandleRef pThis);

		/// <summary>
		/// The handle sits on the surface of the sphere and may be moved around
		/// the surface by picking (left mouse) and then moving. The position
		/// of the handle can be retrieved, this is useful for positioning cameras
		/// and lights. By default, the handle is turned off.
		/// </summary>
		// Token: 0x0600A1A0 RID: 41376 RVA: 0x000E580D File Offset: 0x000E3A0D
		public virtual void HandleVisibilityOff()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_HandleVisibilityOff_39(base.GetCppThis());
		}

		// Token: 0x0600A1A1 RID: 41377
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_HandleVisibilityOn_40(HandleRef pThis);

		/// <summary>
		/// The handle sits on the surface of the sphere and may be moved around
		/// the surface by picking (left mouse) and then moving. The position
		/// of the handle can be retrieved, this is useful for positioning cameras
		/// and lights. By default, the handle is turned off.
		/// </summary>
		// Token: 0x0600A1A2 RID: 41378 RVA: 0x000E581C File Offset: 0x000E3A1C
		public virtual void HandleVisibilityOn()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_HandleVisibilityOn_40(base.GetCppThis());
		}

		// Token: 0x0600A1A3 RID: 41379
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_HasTranslucentPolygonalGeometry_41(HandleRef pThis);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x0600A1A4 RID: 41380 RVA: 0x000E582C File Offset: 0x000E3A2C
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_HasTranslucentPolygonalGeometry_41(base.GetCppThis());
		}

		// Token: 0x0600A1A5 RID: 41381
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_IsA_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and to print out the contents of the class.
		/// </summary>
		// Token: 0x0600A1A6 RID: 41382 RVA: 0x000E584C File Offset: 0x000E3A4C
		public override int IsA(string type)
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_IsA_42(base.GetCppThis(), type);
		}

		// Token: 0x0600A1A7 RID: 41383
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSphereRepresentation_IsTranslationConstrained_43(HandleRef pThis);

		/// <summary>
		/// Returns true if ConstrainedAxis
		/// </summary>
		// Token: 0x0600A1A8 RID: 41384 RVA: 0x000E586C File Offset: 0x000E3A6C
		public bool IsTranslationConstrained()
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_IsTranslationConstrained_43(base.GetCppThis()) != 0;
		}

		// Token: 0x0600A1A9 RID: 41385
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_IsTypeOf_44([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and to print out the contents of the class.
		/// </summary>
		// Token: 0x0600A1AA RID: 41386 RVA: 0x000E5894 File Offset: 0x000E3A94
		public new static int IsTypeOf(string type)
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_IsTypeOf_44(type);
		}

		// Token: 0x0600A1AB RID: 41387
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereRepresentation_NewInstance_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and to print out the contents of the class.
		/// </summary>
		// Token: 0x0600A1AC RID: 41388 RVA: 0x000E58B0 File Offset: 0x000E3AB0
		public new vtkSphereRepresentation NewInstance()
		{
			vtkSphereRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_NewInstance_46(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A1AD RID: 41389
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_PlaceWidget_47(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API. Note that a
		/// version of place widget is available where the center and handle position
		/// are specified.
		/// </summary>
		// Token: 0x0600A1AE RID: 41390 RVA: 0x000E590A File Offset: 0x000E3B0A
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_PlaceWidget_47(base.GetCppThis(), bounds);
		}

		// Token: 0x0600A1AF RID: 41391
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_PlaceWidget_48(HandleRef pThis, IntPtr center, IntPtr handlePosition);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API. Note that a
		/// version of place widget is available where the center and handle position
		/// are specified.
		/// </summary>
		// Token: 0x0600A1B0 RID: 41392 RVA: 0x000E591A File Offset: 0x000E3B1A
		public virtual void PlaceWidget(IntPtr center, IntPtr handlePosition)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_PlaceWidget_48(base.GetCppThis(), center, handlePosition);
		}

		// Token: 0x0600A1B1 RID: 41393
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_RadialLineOff_49(HandleRef pThis);

		/// <summary>
		/// Enable/disable a radial line segment that joins the center of the
		/// outer sphere and the handle.
		/// </summary>
		// Token: 0x0600A1B2 RID: 41394 RVA: 0x000E592B File Offset: 0x000E3B2B
		public virtual void RadialLineOff()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_RadialLineOff_49(base.GetCppThis());
		}

		// Token: 0x0600A1B3 RID: 41395
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_RadialLineOn_50(HandleRef pThis);

		/// <summary>
		/// Enable/disable a radial line segment that joins the center of the
		/// outer sphere and the handle.
		/// </summary>
		// Token: 0x0600A1B4 RID: 41396 RVA: 0x000E593A File Offset: 0x000E3B3A
		public virtual void RadialLineOn()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_RadialLineOn_50(base.GetCppThis());
		}

		// Token: 0x0600A1B5 RID: 41397
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_RegisterPickers_51(HandleRef pThis);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x0600A1B6 RID: 41398 RVA: 0x000E5949 File Offset: 0x000E3B49
		public override void RegisterPickers()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_RegisterPickers_51(base.GetCppThis());
		}

		// Token: 0x0600A1B7 RID: 41399
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_ReleaseGraphicsResources_52(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x0600A1B8 RID: 41400 RVA: 0x000E5958 File Offset: 0x000E3B58
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_ReleaseGraphicsResources_52(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A1B9 RID: 41401
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_RenderOpaqueGeometry_53(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x0600A1BA RID: 41402 RVA: 0x000E5988 File Offset: 0x000E3B88
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_RenderOpaqueGeometry_53(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A1BB RID: 41403
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_RenderOverlay_54(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x0600A1BC RID: 41404 RVA: 0x000E59BC File Offset: 0x000E3BBC
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_RenderOverlay_54(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A1BD RID: 41405
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphereRepresentation_RenderTranslucentPolygonalGeometry_55(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x0600A1BE RID: 41406 RVA: 0x000E59F0 File Offset: 0x000E3BF0
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkSphereRepresentation.vtkSphereRepresentation_RenderTranslucentPolygonalGeometry_55(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A1BF RID: 41407
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphereRepresentation_SafeDownCast_56(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and to print out the contents of the class.
		/// </summary>
		// Token: 0x0600A1C0 RID: 41408 RVA: 0x000E5A24 File Offset: 0x000E3C24
		public new static vtkSphereRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkSphereRepresentation vtkSphereRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphereRepresentation.vtkSphereRepresentation_SafeDownCast_56((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphereRepresentation = (vtkSphereRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphereRepresentation.Register(null);
				}
			}
			return vtkSphereRepresentation;
		}

		// Token: 0x0600A1C1 RID: 41409
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetCenter_57(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set/Get the center position of the sphere. Note that this may
		/// adjust the direction from the handle to the center, as well as
		/// the radius of the sphere.
		/// </summary>
		// Token: 0x0600A1C2 RID: 41410 RVA: 0x000E5AA3 File Offset: 0x000E3CA3
		public void SetCenter(IntPtr c)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetCenter_57(base.GetCppThis(), c);
		}

		// Token: 0x0600A1C3 RID: 41411
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetCenter_58(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the center position of the sphere. Note that this may
		/// adjust the direction from the handle to the center, as well as
		/// the radius of the sphere.
		/// </summary>
		// Token: 0x0600A1C4 RID: 41412 RVA: 0x000E5AB3 File Offset: 0x000E3CB3
		public void SetCenter(double x, double y, double z)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetCenter_58(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600A1C5 RID: 41413
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetCenterCursor_59(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/disable a center cursor
		/// Default is disabled
		/// </summary>
		// Token: 0x0600A1C6 RID: 41414 RVA: 0x000E5AC5 File Offset: 0x000E3CC5
		public virtual void SetCenterCursor(bool _arg)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetCenterCursor_59(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600A1C7 RID: 41415
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetForegroundColor_60(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the interaction color of sphere and handle. Set the handle color of the
		/// handle, center cursor and radial line. Foreground color applies to the sphere and text.
		/// </summary>
		// Token: 0x0600A1C8 RID: 41416 RVA: 0x000E5ADD File Offset: 0x000E3CDD
		public void SetForegroundColor(double arg0, double arg1, double arg2)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetForegroundColor_60(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x0600A1C9 RID: 41417
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetForegroundColor_61(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the interaction color of sphere and handle. Set the handle color of the
		/// handle, center cursor and radial line. Foreground color applies to the sphere and text.
		/// </summary>
		// Token: 0x0600A1CA RID: 41418 RVA: 0x000E5AEF File Offset: 0x000E3CEF
		public void SetForegroundColor(IntPtr c)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetForegroundColor_61(base.GetCppThis(), c);
		}

		// Token: 0x0600A1CB RID: 41419
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetHandleColor_62(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the interaction color of sphere and handle. Set the handle color of the
		/// handle, center cursor and radial line. Foreground color applies to the sphere and text.
		/// </summary>
		// Token: 0x0600A1CC RID: 41420 RVA: 0x000E5AFF File Offset: 0x000E3CFF
		public void SetHandleColor(double arg0, double arg1, double arg2)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetHandleColor_62(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x0600A1CD RID: 41421
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetHandleColor_63(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the interaction color of sphere and handle. Set the handle color of the
		/// handle, center cursor and radial line. Foreground color applies to the sphere and text.
		/// </summary>
		// Token: 0x0600A1CE RID: 41422 RVA: 0x000E5B11 File Offset: 0x000E3D11
		public void SetHandleColor(IntPtr c)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetHandleColor_63(base.GetCppThis(), c);
		}

		// Token: 0x0600A1CF RID: 41423
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetHandleDirection_64(HandleRef pThis, IntPtr dir);

		/// <summary>
		/// Set/Get the direction vector of the handle relative to the center of
		/// the sphere. Setting the direction may affect the position of the handle
		/// but will not affect the radius or position of the sphere.
		/// </summary>
		// Token: 0x0600A1D0 RID: 41424 RVA: 0x000E5B21 File Offset: 0x000E3D21
		public void SetHandleDirection(IntPtr dir)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetHandleDirection_64(base.GetCppThis(), dir);
		}

		// Token: 0x0600A1D1 RID: 41425
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetHandleDirection_65(HandleRef pThis, double dx, double dy, double dz);

		/// <summary>
		/// Set/Get the direction vector of the handle relative to the center of
		/// the sphere. Setting the direction may affect the position of the handle
		/// but will not affect the radius or position of the sphere.
		/// </summary>
		// Token: 0x0600A1D2 RID: 41426 RVA: 0x000E5B31 File Offset: 0x000E3D31
		public void SetHandleDirection(double dx, double dy, double dz)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetHandleDirection_65(base.GetCppThis(), dx, dy, dz);
		}

		// Token: 0x0600A1D3 RID: 41427
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetHandlePosition_66(HandleRef pThis, IntPtr handle);

		/// <summary>
		/// Set/Get the position of the handle. Note that this may adjust the radius
		/// of the sphere and the handle direction.
		/// </summary>
		// Token: 0x0600A1D4 RID: 41428 RVA: 0x000E5B43 File Offset: 0x000E3D43
		public void SetHandlePosition(IntPtr handle)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetHandlePosition_66(base.GetCppThis(), handle);
		}

		// Token: 0x0600A1D5 RID: 41429
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetHandlePosition_67(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the position of the handle. Note that this may adjust the radius
		/// of the sphere and the handle direction.
		/// </summary>
		// Token: 0x0600A1D6 RID: 41430 RVA: 0x000E5B53 File Offset: 0x000E3D53
		public void SetHandlePosition(double x, double y, double z)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetHandlePosition_67(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600A1D7 RID: 41431
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetHandleText_68(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable a label that displays the location of the handle in
		/// spherical coordinates (radius,theta,phi). The two angles, theta and
		/// phi, are displayed in degrees. Note that phi is measured from the
		/// north pole down towards the equator; and theta is the angle around
		/// the north/south axis.
		/// </summary>
		// Token: 0x0600A1D8 RID: 41432 RVA: 0x000E5B65 File Offset: 0x000E3D65
		public virtual void SetHandleText(int _arg)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetHandleText_68(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A1D9 RID: 41433
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetHandleVisibility_69(HandleRef pThis, int _arg);

		/// <summary>
		/// The handle sits on the surface of the sphere and may be moved around
		/// the surface by picking (left mouse) and then moving. The position
		/// of the handle can be retrieved, this is useful for positioning cameras
		/// and lights. By default, the handle is turned off.
		/// </summary>
		// Token: 0x0600A1DA RID: 41434 RVA: 0x000E5B75 File Offset: 0x000E3D75
		public virtual void SetHandleVisibility(int _arg)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetHandleVisibility_69(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A1DB RID: 41435
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetInteractionColor_70(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the interaction color of sphere and handle. Set the handle color of the
		/// handle, center cursor and radial line. Foreground color applies to the sphere and text.
		/// </summary>
		// Token: 0x0600A1DC RID: 41436 RVA: 0x000E5B85 File Offset: 0x000E3D85
		public void SetInteractionColor(double arg0, double arg1, double arg2)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetInteractionColor_70(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x0600A1DD RID: 41437
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetInteractionColor_71(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the interaction color of sphere and handle. Set the handle color of the
		/// handle, center cursor and radial line. Foreground color applies to the sphere and text.
		/// </summary>
		// Token: 0x0600A1DE RID: 41438 RVA: 0x000E5B97 File Offset: 0x000E3D97
		public void SetInteractionColor(IntPtr c)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetInteractionColor_71(base.GetCppThis(), c);
		}

		// Token: 0x0600A1DF RID: 41439
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetInteractionState_72(HandleRef pThis, int state);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., vtkSphereWidget2) or
		/// other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking
		/// process with the widget: First ComputeInteractionState() is invoked that
		/// returns a state based on geometric considerations (i.e., cursor near a
		/// widget feature), then based on events, the widget may modify this
		/// further.
		/// </summary>
		// Token: 0x0600A1E0 RID: 41440 RVA: 0x000E5BA7 File Offset: 0x000E3DA7
		public void SetInteractionState(int state)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetInteractionState_72(base.GetCppThis(), state);
		}

		// Token: 0x0600A1E1 RID: 41441
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetPhiResolution_73(HandleRef pThis, int r);

		/// <summary>
		/// Set/Get the resolution of the sphere in the phi direction.
		/// </summary>
		// Token: 0x0600A1E2 RID: 41442 RVA: 0x000E5BB7 File Offset: 0x000E3DB7
		public void SetPhiResolution(int r)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetPhiResolution_73(base.GetCppThis(), r);
		}

		// Token: 0x0600A1E3 RID: 41443
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetRadialLine_74(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable a radial line segment that joins the center of the
		/// outer sphere and the handle.
		/// </summary>
		// Token: 0x0600A1E4 RID: 41444 RVA: 0x000E5BC7 File Offset: 0x000E3DC7
		public virtual void SetRadialLine(int _arg)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetRadialLine_74(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A1E5 RID: 41445
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetRadius_75(HandleRef pThis, double r);

		/// <summary>
		/// Set/Get the radius of sphere. Default is 0.5. Note that this may
		/// modify the position of the handle based on the handle direction.
		/// </summary>
		// Token: 0x0600A1E6 RID: 41446 RVA: 0x000E5BD7 File Offset: 0x000E3DD7
		public void SetRadius(double r)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetRadius_75(base.GetCppThis(), r);
		}

		// Token: 0x0600A1E7 RID: 41447
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetRepresentation_76(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the representation (i.e., appearance) of the sphere. Different
		/// representations are useful depending on the application.
		/// </summary>
		// Token: 0x0600A1E8 RID: 41448 RVA: 0x000E5BE7 File Offset: 0x000E3DE7
		public virtual void SetRepresentation(int _arg)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetRepresentation_76(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A1E9 RID: 41449
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetRepresentationToOff_77(HandleRef pThis);

		/// <summary>
		/// Set the representation (i.e., appearance) of the sphere. Different
		/// representations are useful depending on the application.
		/// </summary>
		// Token: 0x0600A1EA RID: 41450 RVA: 0x000E5BF7 File Offset: 0x000E3DF7
		public void SetRepresentationToOff()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetRepresentationToOff_77(base.GetCppThis());
		}

		// Token: 0x0600A1EB RID: 41451
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetRepresentationToSurface_78(HandleRef pThis);

		/// <summary>
		/// Set the representation (i.e., appearance) of the sphere. Different
		/// representations are useful depending on the application.
		/// </summary>
		// Token: 0x0600A1EC RID: 41452 RVA: 0x000E5C06 File Offset: 0x000E3E06
		public void SetRepresentationToSurface()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetRepresentationToSurface_78(base.GetCppThis());
		}

		// Token: 0x0600A1ED RID: 41453
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetRepresentationToWireframe_79(HandleRef pThis);

		/// <summary>
		/// Set the representation (i.e., appearance) of the sphere. Different
		/// representations are useful depending on the application.
		/// </summary>
		// Token: 0x0600A1EE RID: 41454 RVA: 0x000E5C15 File Offset: 0x000E3E15
		public void SetRepresentationToWireframe()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetRepresentationToWireframe_79(base.GetCppThis());
		}

		// Token: 0x0600A1EF RID: 41455
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetThetaResolution_80(HandleRef pThis, int r);

		/// <summary>
		/// Set/Get the resolution of the sphere in the theta direction.
		/// </summary>
		// Token: 0x0600A1F0 RID: 41456 RVA: 0x000E5C24 File Offset: 0x000E3E24
		public void SetThetaResolution(int r)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetThetaResolution_80(base.GetCppThis(), r);
		}

		// Token: 0x0600A1F1 RID: 41457
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetTranslationAxis_81(HandleRef pThis, int _arg);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x0600A1F2 RID: 41458 RVA: 0x000E5C34 File Offset: 0x000E3E34
		public virtual void SetTranslationAxis(int _arg)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetTranslationAxis_81(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A1F3 RID: 41459
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetTranslationAxisOff_82(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x0600A1F4 RID: 41460 RVA: 0x000E5C44 File Offset: 0x000E3E44
		public void SetTranslationAxisOff()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetTranslationAxisOff_82(base.GetCppThis());
		}

		// Token: 0x0600A1F5 RID: 41461
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetXTranslationAxisOn_83(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x0600A1F6 RID: 41462 RVA: 0x000E5C53 File Offset: 0x000E3E53
		public void SetXTranslationAxisOn()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetXTranslationAxisOn_83(base.GetCppThis());
		}

		// Token: 0x0600A1F7 RID: 41463
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetYTranslationAxisOn_84(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x0600A1F8 RID: 41464 RVA: 0x000E5C62 File Offset: 0x000E3E62
		public void SetYTranslationAxisOn()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetYTranslationAxisOn_84(base.GetCppThis());
		}

		// Token: 0x0600A1F9 RID: 41465
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_SetZTranslationAxisOn_85(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x0600A1FA RID: 41466 RVA: 0x000E5C71 File Offset: 0x000E3E71
		public void SetZTranslationAxisOn()
		{
			vtkSphereRepresentation.vtkSphereRepresentation_SetZTranslationAxisOn_85(base.GetCppThis());
		}

		// Token: 0x0600A1FB RID: 41467
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_StartWidgetInteraction_86(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API. Note that a
		/// version of place widget is available where the center and handle position
		/// are specified.
		/// </summary>
		// Token: 0x0600A1FC RID: 41468 RVA: 0x000E5C80 File Offset: 0x000E3E80
		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_StartWidgetInteraction_86(base.GetCppThis(), e);
		}

		// Token: 0x0600A1FD RID: 41469
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSphereRepresentation_WidgetInteraction_87(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API. Note that a
		/// version of place widget is available where the center and handle position
		/// are specified.
		/// </summary>
		// Token: 0x0600A1FE RID: 41470 RVA: 0x000E5C90 File Offset: 0x000E3E90
		public override void WidgetInteraction(IntPtr e)
		{
			vtkSphereRepresentation.vtkSphereRepresentation_WidgetInteraction_87(base.GetCppThis(), e);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CFC RID: 3324
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphereRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CFD RID: 3325
		public new static readonly string MRClassNameKey = "class vtkSphereRepresentation";

		/// <summary>
		/// Standard methods for type information and to print out the contents of the class.
		/// </summary>
		// Token: 0x0200037A RID: 890
		public enum MovingHandle_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000CFF RID: 3327
			MovingHandle = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000D00 RID: 3328
			OnSphere,
			/// <summary>enum member</summary>
			// Token: 0x04000D01 RID: 3329
			Outside = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000D02 RID: 3330
			Scaling = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000D03 RID: 3331
			Translating = 3
		}
	}
}
