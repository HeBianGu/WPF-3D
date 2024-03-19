using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRectilinearWipeRepresentation
	/// </summary>
	/// <remarks>
	///    represent a vtkRectilinearWipeWidget
	///
	/// This class is used to represent and render a vtkRectilinearWipeWidget. To
	/// use this class, you need to specify an instance of a
	/// vtkImageRectilinearWipe and vtkImageActor. This provides the information
	/// for this representation to construct and place itself.
	///
	/// The class may be subclassed so that alternative representations can
	/// be created.  The class defines an API and a default implementation that
	/// the vtkRectilinearWipeWidget interacts with to render itself in the scene.
	///
	/// @warning
	/// The separation of the widget event handling and representation enables
	/// users and developers to create new appearances for the widget. It also
	/// facilitates parallel processing, where the client application handles
	/// events, and remote representations of the widget are slaves to the
	/// client (and do not handle events).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRectilinearWipeWidget vtkWidgetRepresentation vtkAbstractWidget
	/// </seealso>
	// Token: 0x0200035F RID: 863
	public class vtkRectilinearWipeRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009D10 RID: 40208 RVA: 0x000DE86B File Offset: 0x000DCA6B
		static vtkRectilinearWipeRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearWipeRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearWipeRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009D11 RID: 40209 RVA: 0x000DE893 File Offset: 0x000DCA93
		public vtkRectilinearWipeRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009D12 RID: 40210
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearWipeRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009D13 RID: 40211 RVA: 0x000DE8A4 File Offset: 0x000DCAA4
		public new static vtkRectilinearWipeRepresentation New()
		{
			vtkRectilinearWipeRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearWipeRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009D14 RID: 40212 RVA: 0x000DE8F8 File Offset: 0x000DCAF8
		public vtkRectilinearWipeRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009D15 RID: 40213 RVA: 0x000DE93C File Offset: 0x000DCB3C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009D16 RID: 40214
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearWipeRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Subclasses of vtkRectilinearWipeRepresentation must implement these methods. These
		/// are the methods that the widget and its representation use to
		/// communicate with each other.
		/// </summary>
		// Token: 0x06009D17 RID: 40215 RVA: 0x000DE947 File Offset: 0x000DCB47
		public override void BuildRepresentation()
		{
			vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009D18 RID: 40216
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearWipeRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Subclasses of vtkRectilinearWipeRepresentation must implement these methods. These
		/// are the methods that the widget and its representation use to
		/// communicate with each other.
		/// </summary>
		// Token: 0x06009D19 RID: 40217 RVA: 0x000DE958 File Offset: 0x000DCB58
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x06009D1A RID: 40218
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearWipeRepresentation_GetActors2D_03(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009D1B RID: 40219 RVA: 0x000DE97C File Offset: 0x000DCB7C
		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_GetActors2D_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009D1C RID: 40220
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearWipeRepresentation_GetImageActor_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify an instance of vtkImageActor to decorate.
		/// </summary>
		// Token: 0x06009D1D RID: 40221 RVA: 0x000DE9AC File Offset: 0x000DCBAC
		public virtual vtkImageActor GetImageActor()
		{
			vtkImageActor vtkImageActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_GetImageActor_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageActor = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageActor.Register(null);
				}
			}
			return vtkImageActor;
		}

		// Token: 0x06009D1E RID: 40222
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearWipeRepresentation_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009D1F RID: 40223 RVA: 0x000DEA1C File Offset: 0x000DCC1C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06009D20 RID: 40224
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearWipeRepresentation_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009D21 RID: 40225 RVA: 0x000DEA3C File Offset: 0x000DCC3C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06009D22 RID: 40226
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearWipeRepresentation_GetProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties for the widget. This can be manipulated to set
		/// different colors, line widths, etc.
		/// </summary>
		// Token: 0x06009D23 RID: 40227 RVA: 0x000DEA58 File Offset: 0x000DCC58
		public virtual vtkProperty2D GetProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_GetProperty_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009D24 RID: 40228
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearWipeRepresentation_GetRectilinearWipe_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify an instance of vtkImageRectilinearWipe to manipulate.
		/// </summary>
		// Token: 0x06009D25 RID: 40229 RVA: 0x000DEAC8 File Offset: 0x000DCCC8
		public virtual vtkImageRectilinearWipe GetRectilinearWipe()
		{
			vtkImageRectilinearWipe vtkImageRectilinearWipe = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_GetRectilinearWipe_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageRectilinearWipe = (vtkImageRectilinearWipe)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageRectilinearWipe.Register(null);
				}
			}
			return vtkImageRectilinearWipe;
		}

		// Token: 0x06009D26 RID: 40230
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearWipeRepresentation_GetTolerance_09(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered to be on the widget, or on a
		/// widget feature (e.g., a corner point or edge).
		/// </summary>
		// Token: 0x06009D27 RID: 40231 RVA: 0x000DEB38 File Offset: 0x000DCD38
		public virtual int GetTolerance()
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_GetTolerance_09(base.GetCppThis());
		}

		// Token: 0x06009D28 RID: 40232
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearWipeRepresentation_GetToleranceMaxValue_10(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered to be on the widget, or on a
		/// widget feature (e.g., a corner point or edge).
		/// </summary>
		// Token: 0x06009D29 RID: 40233 RVA: 0x000DEB58 File Offset: 0x000DCD58
		public virtual int GetToleranceMaxValue()
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_GetToleranceMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06009D2A RID: 40234
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearWipeRepresentation_GetToleranceMinValue_11(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered to be on the widget, or on a
		/// widget feature (e.g., a corner point or edge).
		/// </summary>
		// Token: 0x06009D2B RID: 40235 RVA: 0x000DEB78 File Offset: 0x000DCD78
		public virtual int GetToleranceMinValue()
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_GetToleranceMinValue_11(base.GetCppThis());
		}

		// Token: 0x06009D2C RID: 40236
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearWipeRepresentation_HasTranslucentPolygonalGeometry_12(HandleRef pThis);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009D2D RID: 40237 RVA: 0x000DEB98 File Offset: 0x000DCD98
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_HasTranslucentPolygonalGeometry_12(base.GetCppThis());
		}

		// Token: 0x06009D2E RID: 40238
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearWipeRepresentation_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009D2F RID: 40239 RVA: 0x000DEBB8 File Offset: 0x000DCDB8
		public override int IsA(string type)
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06009D30 RID: 40240
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearWipeRepresentation_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009D31 RID: 40241 RVA: 0x000DEBD8 File Offset: 0x000DCDD8
		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_IsTypeOf_14(type);
		}

		// Token: 0x06009D32 RID: 40242
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearWipeRepresentation_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009D33 RID: 40243 RVA: 0x000DEBF4 File Offset: 0x000DCDF4
		public new vtkRectilinearWipeRepresentation NewInstance()
		{
			vtkRectilinearWipeRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearWipeRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009D34 RID: 40244
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearWipeRepresentation_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009D35 RID: 40245 RVA: 0x000DEC50 File Offset: 0x000DCE50
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_ReleaseGraphicsResources_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009D36 RID: 40246
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearWipeRepresentation_RenderOpaqueGeometry_18(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009D37 RID: 40247 RVA: 0x000DEC80 File Offset: 0x000DCE80
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_RenderOpaqueGeometry_18(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06009D38 RID: 40248
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearWipeRepresentation_RenderOverlay_19(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009D39 RID: 40249 RVA: 0x000DECB4 File Offset: 0x000DCEB4
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_RenderOverlay_19(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06009D3A RID: 40250
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearWipeRepresentation_RenderTranslucentPolygonalGeometry_20(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods to make this class behave as a vtkProp.
		/// </summary>
		// Token: 0x06009D3B RID: 40251 RVA: 0x000DECE8 File Offset: 0x000DCEE8
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_RenderTranslucentPolygonalGeometry_20(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06009D3C RID: 40252
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearWipeRepresentation_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of this class.
		/// </summary>
		// Token: 0x06009D3D RID: 40253 RVA: 0x000DED1C File Offset: 0x000DCF1C
		public new static vtkRectilinearWipeRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearWipeRepresentation vtkRectilinearWipeRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearWipeRepresentation = (vtkRectilinearWipeRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearWipeRepresentation.Register(null);
				}
			}
			return vtkRectilinearWipeRepresentation;
		}

		// Token: 0x06009D3E RID: 40254
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearWipeRepresentation_SetImageActor_22(HandleRef pThis, HandleRef imageActor);

		/// <summary>
		/// Specify an instance of vtkImageActor to decorate.
		/// </summary>
		// Token: 0x06009D3F RID: 40255 RVA: 0x000DED9C File Offset: 0x000DCF9C
		public void SetImageActor(vtkImageActor imageActor)
		{
			vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_SetImageActor_22(base.GetCppThis(), (imageActor == null) ? default(HandleRef) : imageActor.GetCppThis());
		}

		// Token: 0x06009D40 RID: 40256
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearWipeRepresentation_SetRectilinearWipe_23(HandleRef pThis, HandleRef wipe);

		/// <summary>
		/// Specify an instance of vtkImageRectilinearWipe to manipulate.
		/// </summary>
		// Token: 0x06009D41 RID: 40257 RVA: 0x000DEDCC File Offset: 0x000DCFCC
		public void SetRectilinearWipe(vtkImageRectilinearWipe wipe)
		{
			vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_SetRectilinearWipe_23(base.GetCppThis(), (wipe == null) ? default(HandleRef) : wipe.GetCppThis());
		}

		// Token: 0x06009D42 RID: 40258
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearWipeRepresentation_SetTolerance_24(HandleRef pThis, int _arg);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered to be on the widget, or on a
		/// widget feature (e.g., a corner point or edge).
		/// </summary>
		// Token: 0x06009D43 RID: 40259 RVA: 0x000DEDFB File Offset: 0x000DCFFB
		public virtual void SetTolerance(int _arg)
		{
			vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_SetTolerance_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06009D44 RID: 40260
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearWipeRepresentation_StartWidgetInteraction_25(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Subclasses of vtkRectilinearWipeRepresentation must implement these methods. These
		/// are the methods that the widget and its representation use to
		/// communicate with each other.
		/// </summary>
		// Token: 0x06009D45 RID: 40261 RVA: 0x000DEE0B File Offset: 0x000DD00B
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_StartWidgetInteraction_25(base.GetCppThis(), eventPos);
		}

		// Token: 0x06009D46 RID: 40262
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearWipeRepresentation_WidgetInteraction_26(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Subclasses of vtkRectilinearWipeRepresentation must implement these methods. These
		/// are the methods that the widget and its representation use to
		/// communicate with each other.
		/// </summary>
		// Token: 0x06009D47 RID: 40263 RVA: 0x000DEE1B File Offset: 0x000DD01B
		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_WidgetInteraction_26(base.GetCppThis(), eventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CB1 RID: 3249
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearWipeRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CB2 RID: 3250
		public new static readonly string MRClassNameKey = "class vtkRectilinearWipeRepresentation";

		/// <summary>
		/// Subclasses of vtkRectilinearWipeRepresentation must implement these methods. These
		/// are the methods that the widget and its representation use to
		/// communicate with each other.
		/// </summary>
		// Token: 0x02000360 RID: 864
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000CB4 RID: 3252
			MovingCenter = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000CB5 RID: 3253
			MovingHPane = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000CB6 RID: 3254
			MovingVPane,
			/// <summary>enum member</summary>
			// Token: 0x04000CB7 RID: 3255
			Outside = 0
		}
	}
}
