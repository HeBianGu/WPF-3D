using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOrientedGlyphFocalPlaneContourRepresentation
	/// </summary>
	/// <remarks>
	///    Contours constrained
	/// to a focal plane.
	///
	///
	/// This class is used to represent a contour drawn on the focal plane (usually
	/// overlaid on top of an image or volume widget).
	/// The class was written in order to be able to draw contours on a volume widget
	/// and have the contours overlaid on the focal plane in order to do contour
	/// segmentation.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkOrientedGlyphContourRepresentation
	/// </seealso>
	// Token: 0x02000347 RID: 839
	public class vtkOrientedGlyphFocalPlaneContourRepresentation : vtkFocalPlaneContourRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600988D RID: 39053 RVA: 0x000D806F File Offset: 0x000D626F
		static vtkOrientedGlyphFocalPlaneContourRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOrientedGlyphFocalPlaneContourRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrientedGlyphFocalPlaneContourRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600988E RID: 39054 RVA: 0x000D8097 File Offset: 0x000D6297
		public vtkOrientedGlyphFocalPlaneContourRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600988F RID: 39055
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009890 RID: 39056 RVA: 0x000D80A8 File Offset: 0x000D62A8
		public new static vtkOrientedGlyphFocalPlaneContourRepresentation New()
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientedGlyphFocalPlaneContourRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009891 RID: 39057 RVA: 0x000D80FC File Offset: 0x000D62FC
		public vtkOrientedGlyphFocalPlaneContourRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009892 RID: 39058 RVA: 0x000D8140 File Offset: 0x000D6340
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009893 RID: 39059
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Subclasses of vtkOrientedGlyphFocalPlaneContourRepresentation must implement these methods.
		/// These are the methods that the widget and its representation use to communicate with each
		/// other.
		/// </summary>
		// Token: 0x06009894 RID: 39060 RVA: 0x000D814B File Offset: 0x000D634B
		public override void BuildRepresentation()
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009895 RID: 39061
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modified);

		/// <summary>
		/// Subclasses of vtkOrientedGlyphFocalPlaneContourRepresentation must implement these methods.
		/// These are the methods that the widget and its representation use to communicate with each
		/// other.
		/// </summary>
		// Token: 0x06009896 RID: 39062 RVA: 0x000D815C File Offset: 0x000D635C
		public override int ComputeInteractionState(int X, int Y, int modified)
		{
			return vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modified);
		}

		// Token: 0x06009897 RID: 39063
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetActiveCursorShape_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the shape of the cursor (handle) when it is active.
		/// This is the geometry that will be used when the mouse is
		/// close to the handle or if the user is manipulating the handle.
		/// </summary>
		// Token: 0x06009898 RID: 39064 RVA: 0x000D8180 File Offset: 0x000D6380
		public vtkPolyData GetActiveCursorShape()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetActiveCursorShape_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009899 RID: 39065
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetActiveProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This is the property used when the user is interacting
		/// with the handle.
		/// </summary>
		// Token: 0x0600989A RID: 39066 RVA: 0x000D81F0 File Offset: 0x000D63F0
		public virtual vtkProperty2D GetActiveProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetActiveProperty_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600989B RID: 39067
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_GetActors2D_05(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x0600989C RID: 39068 RVA: 0x000D8260 File Offset: 0x000D6460
		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetActors2D_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600989D RID: 39069
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetContourPlaneDirectionCosines_06(HandleRef pThis, IntPtr origin, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Direction cosines of the plane on which the contour lies
		/// on in world coordinates. This would be the same matrix that would be
		/// set in vtkImageReslice or vtkImagePlaneWidget if there were a plane
		/// passing through the contour points. The origin must be the origin of the
		/// data under the contour.
		/// </summary>
		// Token: 0x0600989E RID: 39070 RVA: 0x000D8290 File Offset: 0x000D6490
		public vtkMatrix4x4 GetContourPlaneDirectionCosines(IntPtr origin)
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetContourPlaneDirectionCosines_06(base.GetCppThis(), origin, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x0600989F RID: 39071
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetContourRepresentationAsPolyData_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the points in this contour as a vtkPolyData.
		/// </summary>
		// Token: 0x060098A0 RID: 39072 RVA: 0x000D8300 File Offset: 0x000D6500
		public override vtkPolyData GetContourRepresentationAsPolyData()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetContourRepresentationAsPolyData_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060098A1 RID: 39073
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetCursorShape_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the cursor shape. Keep in mind that the shape will be
		/// aligned with the constraining plane by orienting it such that
		/// the x axis of the geometry lies along the normal of the plane.
		/// </summary>
		// Token: 0x060098A2 RID: 39074 RVA: 0x000D8370 File Offset: 0x000D6570
		public vtkPolyData GetCursorShape()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetCursorShape_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060098A3 RID: 39075
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetLinesProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This is the property used by the lines.
		/// </summary>
		// Token: 0x060098A4 RID: 39076 RVA: 0x000D83E0 File Offset: 0x000D65E0
		public virtual vtkProperty2D GetLinesProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetLinesProperty_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060098A5 RID: 39077
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrientedGlyphFocalPlaneContourRepresentation_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060098A6 RID: 39078 RVA: 0x000D8450 File Offset: 0x000D6650
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x060098A7 RID: 39079
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrientedGlyphFocalPlaneContourRepresentation_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060098A8 RID: 39080 RVA: 0x000D8470 File Offset: 0x000D6670
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x060098A9 RID: 39081
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This is the property used when the handle is not active
		/// (the mouse is not near the handle)
		/// </summary>
		// Token: 0x060098AA RID: 39082 RVA: 0x000D848C File Offset: 0x000D668C
		public virtual vtkProperty2D GetProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetProperty_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060098AB RID: 39083
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_HasTranslucentPolygonalGeometry_13(HandleRef pThis);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x060098AC RID: 39084 RVA: 0x000D84FC File Offset: 0x000D66FC
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_HasTranslucentPolygonalGeometry_13(base.GetCppThis());
		}

		// Token: 0x060098AD RID: 39085
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060098AE RID: 39086 RVA: 0x000D851C File Offset: 0x000D671C
		public override int IsA(string type)
		{
			return vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x060098AF RID: 39087
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060098B0 RID: 39088 RVA: 0x000D853C File Offset: 0x000D673C
		public new static int IsTypeOf(string type)
		{
			return vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_IsTypeOf_15(type);
		}

		// Token: 0x060098B1 RID: 39089
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060098B2 RID: 39090 RVA: 0x000D8558 File Offset: 0x000D6758
		public new vtkOrientedGlyphFocalPlaneContourRepresentation NewInstance()
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientedGlyphFocalPlaneContourRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060098B3 RID: 39091
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_ReleaseGraphicsResources_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x060098B4 RID: 39092 RVA: 0x000D85B4 File Offset: 0x000D67B4
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_ReleaseGraphicsResources_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060098B5 RID: 39093
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_RenderOpaqueGeometry_19(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x060098B6 RID: 39094 RVA: 0x000D85E4 File Offset: 0x000D67E4
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_RenderOpaqueGeometry_19(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060098B7 RID: 39095
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_RenderOverlay_20(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x060098B8 RID: 39096 RVA: 0x000D8618 File Offset: 0x000D6818
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_RenderOverlay_20(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060098B9 RID: 39097
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_RenderTranslucentPolygonalGeometry_21(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x060098BA RID: 39098 RVA: 0x000D864C File Offset: 0x000D684C
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_RenderTranslucentPolygonalGeometry_21(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060098BB RID: 39099
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x060098BC RID: 39100 RVA: 0x000D8680 File Offset: 0x000D6880
		public new static vtkOrientedGlyphFocalPlaneContourRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation vtkOrientedGlyphFocalPlaneContourRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOrientedGlyphFocalPlaneContourRepresentation = (vtkOrientedGlyphFocalPlaneContourRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOrientedGlyphFocalPlaneContourRepresentation.Register(null);
				}
			}
			return vtkOrientedGlyphFocalPlaneContourRepresentation;
		}

		// Token: 0x060098BD RID: 39101
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_SetActiveCursorShape_23(HandleRef pThis, HandleRef activeShape);

		/// <summary>
		/// Specify the shape of the cursor (handle) when it is active.
		/// This is the geometry that will be used when the mouse is
		/// close to the handle or if the user is manipulating the handle.
		/// </summary>
		// Token: 0x060098BE RID: 39102 RVA: 0x000D8700 File Offset: 0x000D6900
		public void SetActiveCursorShape(vtkPolyData activeShape)
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_SetActiveCursorShape_23(base.GetCppThis(), (activeShape == null) ? default(HandleRef) : activeShape.GetCppThis());
		}

		// Token: 0x060098BF RID: 39103
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_SetCursorShape_24(HandleRef pThis, HandleRef cursorShape);

		/// <summary>
		/// Specify the cursor shape. Keep in mind that the shape will be
		/// aligned with the constraining plane by orienting it such that
		/// the x axis of the geometry lies along the normal of the plane.
		/// </summary>
		// Token: 0x060098C0 RID: 39104 RVA: 0x000D8730 File Offset: 0x000D6930
		public void SetCursorShape(vtkPolyData cursorShape)
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_SetCursorShape_24(base.GetCppThis(), (cursorShape == null) ? default(HandleRef) : cursorShape.GetCppThis());
		}

		// Token: 0x060098C1 RID: 39105
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_SetRenderer_25(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Subclasses of vtkOrientedGlyphFocalPlaneContourRepresentation must implement these methods.
		/// These are the methods that the widget and its representation use to communicate with each
		/// other.
		/// </summary>
		// Token: 0x060098C2 RID: 39106 RVA: 0x000D8760 File Offset: 0x000D6960
		public override void SetRenderer(vtkRenderer ren)
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_SetRenderer_25(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x060098C3 RID: 39107
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_StartWidgetInteraction_26(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Subclasses of vtkOrientedGlyphFocalPlaneContourRepresentation must implement these methods.
		/// These are the methods that the widget and its representation use to communicate with each
		/// other.
		/// </summary>
		// Token: 0x060098C4 RID: 39108 RVA: 0x000D878F File Offset: 0x000D698F
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_StartWidgetInteraction_26(base.GetCppThis(), eventPos);
		}

		// Token: 0x060098C5 RID: 39109
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_WidgetInteraction_27(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Subclasses of vtkOrientedGlyphFocalPlaneContourRepresentation must implement these methods.
		/// These are the methods that the widget and its representation use to communicate with each
		/// other.
		/// </summary>
		// Token: 0x060098C6 RID: 39110 RVA: 0x000D879F File Offset: 0x000D699F
		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_WidgetInteraction_27(base.GetCppThis(), eventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C70 RID: 3184
		public new const string MRFullTypeName = "Kitware.VTK.vtkOrientedGlyphFocalPlaneContourRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C71 RID: 3185
		public new static readonly string MRClassNameKey = "class vtkOrientedGlyphFocalPlaneContourRepresentation";
	}
}
