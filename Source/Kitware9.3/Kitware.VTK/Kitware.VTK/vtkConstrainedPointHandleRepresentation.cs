using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkConstrainedPointHandleRepresentation
	/// </summary>
	/// <remarks>
	///    point representation constrained to a 2D plane
	///
	/// This class is used to represent a vtkHandleWidget. It represents a
	/// position in 3D world coordinates that is constrained to a specified plane.
	/// The default look is to draw a white point when this widget is not selected
	/// or active, a thin green circle when it is highlighted, and a thicker cyan
	/// circle when it is active (being positioned). Defaults can be adjusted - but
	/// take care to define cursor geometry that makes sense for this widget.
	/// The geometry will be aligned on the constraining plane, with the plane
	/// normal aligned with the X axis of the geometry (similar behavior to
	/// vtkGlyph3D).
	///
	/// TODO: still need to work on
	/// 1) translation when mouse is outside bounding planes
	/// 2) size of the widget
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHandleRepresentation vtkHandleWidget
	/// </seealso>
	// Token: 0x020002FD RID: 765
	public class vtkConstrainedPointHandleRepresentation : vtkHandleRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060088BF RID: 35007 RVA: 0x000C35BB File Offset: 0x000C17BB
		static vtkConstrainedPointHandleRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConstrainedPointHandleRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConstrainedPointHandleRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060088C0 RID: 35008 RVA: 0x000C35E3 File Offset: 0x000C17E3
		public vtkConstrainedPointHandleRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060088C1 RID: 35009
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060088C2 RID: 35010 RVA: 0x000C35F4 File Offset: 0x000C17F4
		public new static vtkConstrainedPointHandleRepresentation New()
		{
			vtkConstrainedPointHandleRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConstrainedPointHandleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060088C3 RID: 35011 RVA: 0x000C3648 File Offset: 0x000C1848
		public vtkConstrainedPointHandleRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060088C4 RID: 35012 RVA: 0x000C368C File Offset: 0x000C188C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060088C5 RID: 35013
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_AddBoundingPlane_01(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x060088C6 RID: 35014 RVA: 0x000C3698 File Offset: 0x000C1898
		public void AddBoundingPlane(vtkPlane plane)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_AddBoundingPlane_01(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x060088C7 RID: 35015
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_BuildRepresentation_02(HandleRef pThis);

		/// <summary>
		/// Subclasses of vtkConstrainedPointHandleRepresentation must implement these methods. These
		/// are the methods that the widget and its representation use to
		/// communicate with each other.
		/// </summary>
		// Token: 0x060088C8 RID: 35016 RVA: 0x000C36C7 File Offset: 0x000C18C7
		public override void BuildRepresentation()
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_BuildRepresentation_02(base.GetCppThis());
		}

		// Token: 0x060088C9 RID: 35017
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedPointHandleRepresentation_CheckConstraint_03(HandleRef pThis, HandleRef renderer, IntPtr pos);

		/// <summary>
		/// Overridden from the base class. It converts the display
		/// coordinates to world coordinates. It returns 1 if the point lies
		/// within the constrained region, otherwise return 0
		/// </summary>
		// Token: 0x060088CA RID: 35018 RVA: 0x000C36D8 File Offset: 0x000C18D8
		public override int CheckConstraint(vtkRenderer renderer, IntPtr pos)
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_CheckConstraint_03(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), pos);
		}

		// Token: 0x060088CB RID: 35019
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedPointHandleRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Subclasses of vtkConstrainedPointHandleRepresentation must implement these methods. These
		/// are the methods that the widget and its representation use to
		/// communicate with each other.
		/// </summary>
		// Token: 0x060088CC RID: 35020 RVA: 0x000C3710 File Offset: 0x000C1910
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_ComputeInteractionState_04(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x060088CD RID: 35021
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetActiveCursorShape_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the shape of the cursor (handle) when it is active.
		/// This is the geometry that will be used when the mouse is
		/// close to the handle or if the user is manipulating the handle.
		/// </summary>
		// Token: 0x060088CE RID: 35022 RVA: 0x000C3734 File Offset: 0x000C1934
		public vtkPolyData GetActiveCursorShape()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetActiveCursorShape_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060088CF RID: 35023
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetActiveProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This is the property used when the user is interacting
		/// with the handle.
		/// </summary>
		// Token: 0x060088D0 RID: 35024 RVA: 0x000C37A4 File Offset: 0x000C19A4
		public virtual vtkProperty GetActiveProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetActiveProperty_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060088D1 RID: 35025
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_GetActors_07(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x060088D2 RID: 35026 RVA: 0x000C3814 File Offset: 0x000C1A14
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetActors_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060088D3 RID: 35027
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetBoundingPlanes_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x060088D4 RID: 35028 RVA: 0x000C3844 File Offset: 0x000C1A44
		public virtual vtkPlaneCollection GetBoundingPlanes()
		{
			vtkPlaneCollection vtkPlaneCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetBoundingPlanes_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaneCollection = (vtkPlaneCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaneCollection.Register(null);
				}
			}
			return vtkPlaneCollection;
		}

		// Token: 0x060088D5 RID: 35029
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetCursorShape_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the cursor shape. Keep in mind that the shape will be
		/// aligned with the constraining plane by orienting it such that
		/// the x axis of the geometry lies along the normal of the plane.
		/// </summary>
		// Token: 0x060088D6 RID: 35030 RVA: 0x000C38B4 File Offset: 0x000C1AB4
		public vtkPolyData GetCursorShape()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetCursorShape_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060088D7 RID: 35031
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConstrainedPointHandleRepresentation_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060088D8 RID: 35032 RVA: 0x000C3924 File Offset: 0x000C1B24
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x060088D9 RID: 35033
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConstrainedPointHandleRepresentation_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060088DA RID: 35034 RVA: 0x000C3944 File Offset: 0x000C1B44
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x060088DB RID: 35035
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetObliquePlane_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If the ProjectionNormal is set to Oblique, then this is the
		/// oblique plane used to constrain the handle position
		/// </summary>
		// Token: 0x060088DC RID: 35036 RVA: 0x000C3960 File Offset: 0x000C1B60
		public virtual vtkPlane GetObliquePlane()
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetObliquePlane_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		// Token: 0x060088DD RID: 35037
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetPosition_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of the point in display coordinates.  These are
		/// convenience methods that extend the superclasses' GetHandlePosition()
		/// method. Note that only the x-y coordinate values are used
		/// </summary>
		// Token: 0x060088DE RID: 35038 RVA: 0x000C39D0 File Offset: 0x000C1BD0
		public IntPtr GetPosition()
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetPosition_13(base.GetCppThis());
		}

		// Token: 0x060088DF RID: 35039
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_GetPosition_14(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set/Get the position of the point in display coordinates.  These are
		/// convenience methods that extend the superclasses' GetHandlePosition()
		/// method. Note that only the x-y coordinate values are used
		/// </summary>
		// Token: 0x060088E0 RID: 35040 RVA: 0x000C39EF File Offset: 0x000C1BEF
		public void GetPosition(IntPtr xyz)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetPosition_14(base.GetCppThis(), xyz);
		}

		// Token: 0x060088E1 RID: 35041
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedPointHandleRepresentation_GetProjectionNormal_15(HandleRef pThis);

		/// <summary>
		/// Set the projection normal to lie along the x, y, or z axis,
		/// or to be oblique. If it is oblique, then the plane is
		/// defined in the ObliquePlane ivar.
		/// </summary>
		// Token: 0x060088E2 RID: 35042 RVA: 0x000C3A00 File Offset: 0x000C1C00
		public virtual int GetProjectionNormal()
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetProjectionNormal_15(base.GetCppThis());
		}

		// Token: 0x060088E3 RID: 35043
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedPointHandleRepresentation_GetProjectionNormalMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Set the projection normal to lie along the x, y, or z axis,
		/// or to be oblique. If it is oblique, then the plane is
		/// defined in the ObliquePlane ivar.
		/// </summary>
		// Token: 0x060088E4 RID: 35044 RVA: 0x000C3A20 File Offset: 0x000C1C20
		public virtual int GetProjectionNormalMaxValue()
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetProjectionNormalMaxValue_16(base.GetCppThis());
		}

		// Token: 0x060088E5 RID: 35045
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedPointHandleRepresentation_GetProjectionNormalMinValue_17(HandleRef pThis);

		/// <summary>
		/// Set the projection normal to lie along the x, y, or z axis,
		/// or to be oblique. If it is oblique, then the plane is
		/// defined in the ObliquePlane ivar.
		/// </summary>
		// Token: 0x060088E6 RID: 35046 RVA: 0x000C3A40 File Offset: 0x000C1C40
		public virtual int GetProjectionNormalMinValue()
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetProjectionNormalMinValue_17(base.GetCppThis());
		}

		// Token: 0x060088E7 RID: 35047
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConstrainedPointHandleRepresentation_GetProjectionPosition_18(HandleRef pThis);

		/// <summary>
		/// The position of the bounding plane from the origin along the
		/// normal. The origin and normal are defined in the oblique plane
		/// when the ProjectionNormal is Oblique. For the X, Y, and Z
		/// axes projection normals, the normal is the axis direction, and
		/// the origin is (0,0,0).
		/// </summary>
		// Token: 0x060088E8 RID: 35048 RVA: 0x000C3A60 File Offset: 0x000C1C60
		public virtual double GetProjectionPosition()
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetProjectionPosition_18(base.GetCppThis());
		}

		// Token: 0x060088E9 RID: 35049
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetProperty_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This is the property used when the handle is not active
		/// (the mouse is not near the handle)
		/// </summary>
		// Token: 0x060088EA RID: 35050 RVA: 0x000C3A80 File Offset: 0x000C1C80
		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetProperty_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060088EB RID: 35051
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_GetSelectedProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This is the property used when the mouse is near the
		/// handle (but the user is not yet interacting with it)
		/// </summary>
		// Token: 0x060088EC RID: 35052 RVA: 0x000C3AF0 File Offset: 0x000C1CF0
		public virtual vtkProperty GetSelectedProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_GetSelectedProperty_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060088ED RID: 35053
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedPointHandleRepresentation_HasTranslucentPolygonalGeometry_21(HandleRef pThis);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x060088EE RID: 35054 RVA: 0x000C3B60 File Offset: 0x000C1D60
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_HasTranslucentPolygonalGeometry_21(base.GetCppThis());
		}

		// Token: 0x060088EF RID: 35055
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_Highlight_22(HandleRef pThis, int highlight);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x060088F0 RID: 35056 RVA: 0x000C3B7F File Offset: 0x000C1D7F
		public override void Highlight(int highlight)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_Highlight_22(base.GetCppThis(), highlight);
		}

		// Token: 0x060088F1 RID: 35057
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedPointHandleRepresentation_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060088F2 RID: 35058 RVA: 0x000C3B90 File Offset: 0x000C1D90
		public override int IsA(string type)
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x060088F3 RID: 35059
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedPointHandleRepresentation_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060088F4 RID: 35060 RVA: 0x000C3BB0 File Offset: 0x000C1DB0
		public new static int IsTypeOf(string type)
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_IsTypeOf_24(type);
		}

		// Token: 0x060088F5 RID: 35061
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060088F6 RID: 35062 RVA: 0x000C3BCC File Offset: 0x000C1DCC
		public new vtkConstrainedPointHandleRepresentation NewInstance()
		{
			vtkConstrainedPointHandleRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConstrainedPointHandleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060088F7 RID: 35063
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_ReleaseGraphicsResources_27(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x060088F8 RID: 35064 RVA: 0x000C3C28 File Offset: 0x000C1E28
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_ReleaseGraphicsResources_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060088F9 RID: 35065
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_RemoveAllBoundingPlanes_28(HandleRef pThis);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x060088FA RID: 35066 RVA: 0x000C3C57 File Offset: 0x000C1E57
		public void RemoveAllBoundingPlanes()
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_RemoveAllBoundingPlanes_28(base.GetCppThis());
		}

		// Token: 0x060088FB RID: 35067
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_RemoveBoundingPlane_29(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x060088FC RID: 35068 RVA: 0x000C3C68 File Offset: 0x000C1E68
		public void RemoveBoundingPlane(vtkPlane plane)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_RemoveBoundingPlane_29(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x060088FD RID: 35069
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedPointHandleRepresentation_RenderOpaqueGeometry_30(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x060088FE RID: 35070 RVA: 0x000C3C98 File Offset: 0x000C1E98
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_RenderOpaqueGeometry_30(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060088FF RID: 35071
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedPointHandleRepresentation_RenderOverlay_31(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06008900 RID: 35072 RVA: 0x000C3CCC File Offset: 0x000C1ECC
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_RenderOverlay_31(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06008901 RID: 35073
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConstrainedPointHandleRepresentation_RenderTranslucentPolygonalGeometry_32(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06008902 RID: 35074 RVA: 0x000C3D00 File Offset: 0x000C1F00
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_RenderTranslucentPolygonalGeometry_32(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06008903 RID: 35075
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConstrainedPointHandleRepresentation_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06008904 RID: 35076 RVA: 0x000C3D34 File Offset: 0x000C1F34
		public new static vtkConstrainedPointHandleRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkConstrainedPointHandleRepresentation vtkConstrainedPointHandleRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConstrainedPointHandleRepresentation = (vtkConstrainedPointHandleRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConstrainedPointHandleRepresentation.Register(null);
				}
			}
			return vtkConstrainedPointHandleRepresentation;
		}

		// Token: 0x06008905 RID: 35077
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetActiveCursorShape_34(HandleRef pThis, HandleRef activeShape);

		/// <summary>
		/// Specify the shape of the cursor (handle) when it is active.
		/// This is the geometry that will be used when the mouse is
		/// close to the handle or if the user is manipulating the handle.
		/// </summary>
		// Token: 0x06008906 RID: 35078 RVA: 0x000C3DB4 File Offset: 0x000C1FB4
		public void SetActiveCursorShape(vtkPolyData activeShape)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetActiveCursorShape_34(base.GetCppThis(), (activeShape == null) ? default(HandleRef) : activeShape.GetCppThis());
		}

		// Token: 0x06008907 RID: 35079
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetBoundingPlanes_35(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x06008908 RID: 35080 RVA: 0x000C3DE4 File Offset: 0x000C1FE4
		public virtual void SetBoundingPlanes(vtkPlaneCollection arg0)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetBoundingPlanes_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008909 RID: 35081
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetBoundingPlanes_36(HandleRef pThis, HandleRef planes);

		/// <summary>
		/// A collection of plane equations used to bound the position of the point.
		/// This is in addition to confining the point to a plane - these constraints
		/// are meant to, for example, keep a point within the extent of an image.
		/// Using a set of plane equations allows for more complex bounds (such as
		/// bounding a point to an oblique reliced image that has hexagonal shape)
		/// than a simple extent.
		/// </summary>
		// Token: 0x0600890A RID: 35082 RVA: 0x000C3E14 File Offset: 0x000C2014
		public void SetBoundingPlanes(vtkPlanes planes)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetBoundingPlanes_36(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}

		// Token: 0x0600890B RID: 35083
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetCursorShape_37(HandleRef pThis, HandleRef cursorShape);

		/// <summary>
		/// Specify the cursor shape. Keep in mind that the shape will be
		/// aligned with the constraining plane by orienting it such that
		/// the x axis of the geometry lies along the normal of the plane.
		/// </summary>
		// Token: 0x0600890C RID: 35084 RVA: 0x000C3E44 File Offset: 0x000C2044
		public void SetCursorShape(vtkPolyData cursorShape)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetCursorShape_37(base.GetCppThis(), (cursorShape == null) ? default(HandleRef) : cursorShape.GetCppThis());
		}

		// Token: 0x0600890D RID: 35085
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetDisplayPosition_38(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Method overridden from Superclass. computes the world
		/// coordinates using GetIntersectionPosition()
		/// </summary>
		// Token: 0x0600890E RID: 35086 RVA: 0x000C3E73 File Offset: 0x000C2073
		public override void SetDisplayPosition(IntPtr pos)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetDisplayPosition_38(base.GetCppThis(), pos);
		}

		// Token: 0x0600890F RID: 35087
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetObliquePlane_39(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// If the ProjectionNormal is set to Oblique, then this is the
		/// oblique plane used to constrain the handle position
		/// </summary>
		// Token: 0x06008910 RID: 35088 RVA: 0x000C3E84 File Offset: 0x000C2084
		public void SetObliquePlane(vtkPlane arg0)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetObliquePlane_39(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008911 RID: 35089
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetPosition_40(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the position of the point in display coordinates.  These are
		/// convenience methods that extend the superclasses' GetHandlePosition()
		/// method. Note that only the x-y coordinate values are used
		/// </summary>
		// Token: 0x06008912 RID: 35090 RVA: 0x000C3EB3 File Offset: 0x000C20B3
		public void SetPosition(double x, double y, double z)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetPosition_40(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06008913 RID: 35091
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetPosition_41(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set/Get the position of the point in display coordinates.  These are
		/// convenience methods that extend the superclasses' GetHandlePosition()
		/// method. Note that only the x-y coordinate values are used
		/// </summary>
		// Token: 0x06008914 RID: 35092 RVA: 0x000C3EC5 File Offset: 0x000C20C5
		public void SetPosition(IntPtr xyz)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetPosition_41(base.GetCppThis(), xyz);
		}

		// Token: 0x06008915 RID: 35093
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionNormal_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the projection normal to lie along the x, y, or z axis,
		/// or to be oblique. If it is oblique, then the plane is
		/// defined in the ObliquePlane ivar.
		/// </summary>
		// Token: 0x06008916 RID: 35094 RVA: 0x000C3ED5 File Offset: 0x000C20D5
		public virtual void SetProjectionNormal(int _arg)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetProjectionNormal_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06008917 RID: 35095
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionNormalToOblique_43(HandleRef pThis);

		/// <summary>
		/// Set the projection normal to lie along the x, y, or z axis,
		/// or to be oblique. If it is oblique, then the plane is
		/// defined in the ObliquePlane ivar.
		/// </summary>
		// Token: 0x06008918 RID: 35096 RVA: 0x000C3EE5 File Offset: 0x000C20E5
		public void SetProjectionNormalToOblique()
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetProjectionNormalToOblique_43(base.GetCppThis());
		}

		// Token: 0x06008919 RID: 35097
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionNormalToXAxis_44(HandleRef pThis);

		/// <summary>
		/// Set the projection normal to lie along the x, y, or z axis,
		/// or to be oblique. If it is oblique, then the plane is
		/// defined in the ObliquePlane ivar.
		/// </summary>
		// Token: 0x0600891A RID: 35098 RVA: 0x000C3EF4 File Offset: 0x000C20F4
		public void SetProjectionNormalToXAxis()
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetProjectionNormalToXAxis_44(base.GetCppThis());
		}

		// Token: 0x0600891B RID: 35099
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionNormalToYAxis_45(HandleRef pThis);

		/// <summary>
		/// Set the projection normal to lie along the x, y, or z axis,
		/// or to be oblique. If it is oblique, then the plane is
		/// defined in the ObliquePlane ivar.
		/// </summary>
		// Token: 0x0600891C RID: 35100 RVA: 0x000C3F03 File Offset: 0x000C2103
		public void SetProjectionNormalToYAxis()
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetProjectionNormalToYAxis_45(base.GetCppThis());
		}

		// Token: 0x0600891D RID: 35101
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionNormalToZAxis_46(HandleRef pThis);

		/// <summary>
		/// Set the projection normal to lie along the x, y, or z axis,
		/// or to be oblique. If it is oblique, then the plane is
		/// defined in the ObliquePlane ivar.
		/// </summary>
		// Token: 0x0600891E RID: 35102 RVA: 0x000C3F12 File Offset: 0x000C2112
		public void SetProjectionNormalToZAxis()
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetProjectionNormalToZAxis_46(base.GetCppThis());
		}

		// Token: 0x0600891F RID: 35103
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetProjectionPosition_47(HandleRef pThis, double position);

		/// <summary>
		/// The position of the bounding plane from the origin along the
		/// normal. The origin and normal are defined in the oblique plane
		/// when the ProjectionNormal is Oblique. For the X, Y, and Z
		/// axes projection normals, the normal is the axis direction, and
		/// the origin is (0,0,0).
		/// </summary>
		// Token: 0x06008920 RID: 35104 RVA: 0x000C3F21 File Offset: 0x000C2121
		public void SetProjectionPosition(double position)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetProjectionPosition_47(base.GetCppThis(), position);
		}

		// Token: 0x06008921 RID: 35105
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_SetRenderer_48(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Subclasses of vtkConstrainedPointHandleRepresentation must implement these methods. These
		/// are the methods that the widget and its representation use to
		/// communicate with each other.
		/// </summary>
		// Token: 0x06008922 RID: 35106 RVA: 0x000C3F34 File Offset: 0x000C2134
		public override void SetRenderer(vtkRenderer ren)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_SetRenderer_48(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06008923 RID: 35107
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_ShallowCopy_49(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06008924 RID: 35108 RVA: 0x000C3F64 File Offset: 0x000C2164
		public override void ShallowCopy(vtkProp prop)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_ShallowCopy_49(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06008925 RID: 35109
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_StartWidgetInteraction_50(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Subclasses of vtkConstrainedPointHandleRepresentation must implement these methods. These
		/// are the methods that the widget and its representation use to
		/// communicate with each other.
		/// </summary>
		// Token: 0x06008926 RID: 35110 RVA: 0x000C3F93 File Offset: 0x000C2193
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_StartWidgetInteraction_50(base.GetCppThis(), eventPos);
		}

		// Token: 0x06008927 RID: 35111
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConstrainedPointHandleRepresentation_WidgetInteraction_51(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Subclasses of vtkConstrainedPointHandleRepresentation must implement these methods. These
		/// are the methods that the widget and its representation use to
		/// communicate with each other.
		/// </summary>
		// Token: 0x06008928 RID: 35112 RVA: 0x000C3FA3 File Offset: 0x000C21A3
		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkConstrainedPointHandleRepresentation.vtkConstrainedPointHandleRepresentation_WidgetInteraction_51(base.GetCppThis(), eventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B8E RID: 2958
		public new const string MRFullTypeName = "Kitware.VTK.vtkConstrainedPointHandleRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B8F RID: 2959
		public new static readonly string MRClassNameKey = "class vtkConstrainedPointHandleRepresentation";

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x020002FE RID: 766
		public enum Oblique_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000B91 RID: 2961
			Oblique = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000B92 RID: 2962
			XAxis = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000B93 RID: 2963
			YAxis,
			/// <summary>enum member</summary>
			// Token: 0x04000B94 RID: 2964
			ZAxis
		}
	}
}
