using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCaptionRepresentation
	/// </summary>
	/// <remarks>
	///    represents vtkCaptionWidget in the scene
	///
	/// This class represents vtkCaptionWidget. A caption is defined by some text
	/// with a leader (e.g., arrow) that points from the text to a point in the
	/// scene. The caption is defined by an instance of vtkCaptionActor2D. It uses
	/// the event bindings of its superclass (vtkBorderWidget) to control the
	/// placement of the text, and adds the ability to move the attachment point
	/// around. In addition, when the caption text is selected, the widget emits a
	/// ActivateEvent that observers can watch for. This is useful for opening GUI
	/// dialogoues to adjust font characteristics, etc. (Please see the superclass
	/// for a description of event bindings.)
	///
	/// Note that this widget extends the behavior of its superclass
	/// vtkBorderRepresentation.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCaptionWidget vtkBorderWidget vtkBorderRepresentation vtkCaptionActor
	/// </seealso>
	// Token: 0x020002EC RID: 748
	public class vtkCaptionRepresentation : vtkBorderRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600865D RID: 34397 RVA: 0x000BFCFB File Offset: 0x000BDEFB
		static vtkCaptionRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCaptionRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCaptionRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600865E RID: 34398 RVA: 0x000BFD23 File Offset: 0x000BDF23
		public vtkCaptionRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600865F RID: 34399
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008660 RID: 34400 RVA: 0x000BFD34 File Offset: 0x000BDF34
		public new static vtkCaptionRepresentation New()
		{
			vtkCaptionRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCaptionRepresentation.vtkCaptionRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCaptionRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008661 RID: 34401 RVA: 0x000BFD88 File Offset: 0x000BDF88
		public vtkCaptionRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCaptionRepresentation.vtkCaptionRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008662 RID: 34402 RVA: 0x000BFDCC File Offset: 0x000BDFCC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008663 RID: 34403
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Satisfy the superclasses API.
		/// </summary>
		// Token: 0x06008664 RID: 34404 RVA: 0x000BFDD7 File Offset: 0x000BDFD7
		public override void BuildRepresentation()
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008665 RID: 34405
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionRepresentation_GetActors2D_02(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06008666 RID: 34406 RVA: 0x000BFDE8 File Offset: 0x000BDFE8
		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_GetActors2D_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008667 RID: 34407
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionRepresentation_GetAnchorPosition_03(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Specify the position of the anchor (i.e., the point that the caption is anchored to).
		/// Note that the position should be specified in world coordinates.
		/// </summary>
		// Token: 0x06008668 RID: 34408 RVA: 0x000BFE17 File Offset: 0x000BE017
		public void GetAnchorPosition(IntPtr pos)
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_GetAnchorPosition_03(base.GetCppThis(), pos);
		}

		// Token: 0x06008669 RID: 34409
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionRepresentation_GetAnchorRepresentation_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set and get the instances of vtkPointHandleRepresentation3D used to implement this
		/// representation. Normally default representations are created, but you can
		/// specify the ones you want to use.
		/// </summary>
		// Token: 0x0600866A RID: 34410 RVA: 0x000BFE28 File Offset: 0x000BE028
		public virtual vtkPointHandleRepresentation3D GetAnchorRepresentation()
		{
			vtkPointHandleRepresentation3D vtkPointHandleRepresentation3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCaptionRepresentation.vtkCaptionRepresentation_GetAnchorRepresentation_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointHandleRepresentation3D = (vtkPointHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointHandleRepresentation3D.Register(null);
				}
			}
			return vtkPointHandleRepresentation3D;
		}

		// Token: 0x0600866B RID: 34411
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionRepresentation_GetCaptionActor2D_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the vtkCaptionActor2D to manage. If not specified, then one
		/// is automatically created.
		/// </summary>
		// Token: 0x0600866C RID: 34412 RVA: 0x000BFE98 File Offset: 0x000BE098
		public virtual vtkCaptionActor2D GetCaptionActor2D()
		{
			vtkCaptionActor2D vtkCaptionActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCaptionRepresentation.vtkCaptionRepresentation_GetCaptionActor2D_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCaptionActor2D = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCaptionActor2D.Register(null);
				}
			}
			return vtkCaptionActor2D;
		}

		// Token: 0x0600866D RID: 34413
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCaptionRepresentation_GetFontFactor_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts
		/// of the caption when the text actor's ScaledText is OFF
		/// </summary>
		// Token: 0x0600866E RID: 34414 RVA: 0x000BFF08 File Offset: 0x000BE108
		public virtual double GetFontFactor()
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_GetFontFactor_06(base.GetCppThis());
		}

		// Token: 0x0600866F RID: 34415
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCaptionRepresentation_GetFontFactorMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts
		/// of the caption when the text actor's ScaledText is OFF
		/// </summary>
		// Token: 0x06008670 RID: 34416 RVA: 0x000BFF28 File Offset: 0x000BE128
		public virtual double GetFontFactorMaxValue()
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_GetFontFactorMaxValue_07(base.GetCppThis());
		}

		// Token: 0x06008671 RID: 34417
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCaptionRepresentation_GetFontFactorMinValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts
		/// of the caption when the text actor's ScaledText is OFF
		/// </summary>
		// Token: 0x06008672 RID: 34418 RVA: 0x000BFF48 File Offset: 0x000BE148
		public virtual double GetFontFactorMinValue()
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_GetFontFactorMinValue_08(base.GetCppThis());
		}

		// Token: 0x06008673 RID: 34419
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCaptionRepresentation_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06008674 RID: 34420 RVA: 0x000BFF68 File Offset: 0x000BE168
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06008675 RID: 34421
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCaptionRepresentation_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06008676 RID: 34422 RVA: 0x000BFF88 File Offset: 0x000BE188
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06008677 RID: 34423
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionRepresentation_GetSize_11(HandleRef pThis, IntPtr size);

		/// <summary>
		/// Satisfy the superclasses API.
		/// </summary>
		// Token: 0x06008678 RID: 34424 RVA: 0x000BFFA2 File Offset: 0x000BE1A2
		public override void GetSize(IntPtr size)
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_GetSize_11(base.GetCppThis(), size);
		}

		// Token: 0x06008679 RID: 34425
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionRepresentation_HasTranslucentPolygonalGeometry_12(HandleRef pThis);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x0600867A RID: 34426 RVA: 0x000BFFB4 File Offset: 0x000BE1B4
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_HasTranslucentPolygonalGeometry_12(base.GetCppThis());
		}

		// Token: 0x0600867B RID: 34427
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionRepresentation_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x0600867C RID: 34428 RVA: 0x000BFFD4 File Offset: 0x000BE1D4
		public override int IsA(string type)
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0600867D RID: 34429
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionRepresentation_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x0600867E RID: 34430 RVA: 0x000BFFF4 File Offset: 0x000BE1F4
		public new static int IsTypeOf(string type)
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_IsTypeOf_14(type);
		}

		// Token: 0x0600867F RID: 34431
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionRepresentation_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06008680 RID: 34432 RVA: 0x000C0010 File Offset: 0x000BE210
		public new vtkCaptionRepresentation NewInstance()
		{
			vtkCaptionRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCaptionRepresentation.vtkCaptionRepresentation_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCaptionRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008681 RID: 34433
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionRepresentation_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06008682 RID: 34434 RVA: 0x000C006C File Offset: 0x000BE26C
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_ReleaseGraphicsResources_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008683 RID: 34435
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionRepresentation_RenderOpaqueGeometry_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06008684 RID: 34436 RVA: 0x000C009C File Offset: 0x000BE29C
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_RenderOpaqueGeometry_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008685 RID: 34437
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionRepresentation_RenderOverlay_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06008686 RID: 34438 RVA: 0x000C00D0 File Offset: 0x000BE2D0
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_RenderOverlay_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008687 RID: 34439
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionRepresentation_RenderTranslucentPolygonalGeometry_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06008688 RID: 34440 RVA: 0x000C0104 File Offset: 0x000BE304
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_RenderTranslucentPolygonalGeometry_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008689 RID: 34441
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionRepresentation_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x0600868A RID: 34442 RVA: 0x000C0138 File Offset: 0x000BE338
		public new static vtkCaptionRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkCaptionRepresentation vtkCaptionRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCaptionRepresentation.vtkCaptionRepresentation_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCaptionRepresentation = (vtkCaptionRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCaptionRepresentation.Register(null);
				}
			}
			return vtkCaptionRepresentation;
		}

		// Token: 0x0600868B RID: 34443
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionRepresentation_SetAnchorPosition_22(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Specify the position of the anchor (i.e., the point that the caption is anchored to).
		/// Note that the position should be specified in world coordinates.
		/// </summary>
		// Token: 0x0600868C RID: 34444 RVA: 0x000C01B7 File Offset: 0x000BE3B7
		public void SetAnchorPosition(IntPtr pos)
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_SetAnchorPosition_22(base.GetCppThis(), pos);
		}

		// Token: 0x0600868D RID: 34445
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionRepresentation_SetAnchorRepresentation_23(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set and get the instances of vtkPointHandleRepresentation3D used to implement this
		/// representation. Normally default representations are created, but you can
		/// specify the ones you want to use.
		/// </summary>
		// Token: 0x0600868E RID: 34446 RVA: 0x000C01C8 File Offset: 0x000BE3C8
		public void SetAnchorRepresentation(vtkPointHandleRepresentation3D arg0)
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_SetAnchorRepresentation_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600868F RID: 34447
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionRepresentation_SetCaptionActor2D_24(HandleRef pThis, HandleRef captionActor);

		/// <summary>
		/// Specify the vtkCaptionActor2D to manage. If not specified, then one
		/// is automatically created.
		/// </summary>
		// Token: 0x06008690 RID: 34448 RVA: 0x000C01F8 File Offset: 0x000BE3F8
		public void SetCaptionActor2D(vtkCaptionActor2D captionActor)
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_SetCaptionActor2D_24(base.GetCppThis(), (captionActor == null) ? default(HandleRef) : captionActor.GetCppThis());
		}

		// Token: 0x06008691 RID: 34449
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionRepresentation_SetFontFactor_25(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts
		/// of the caption when the text actor's ScaledText is OFF
		/// </summary>
		// Token: 0x06008692 RID: 34450 RVA: 0x000C0227 File Offset: 0x000BE427
		public virtual void SetFontFactor(double _arg)
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_SetFontFactor_25(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B59 RID: 2905
		public new const string MRFullTypeName = "Kitware.VTK.vtkCaptionRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B5A RID: 2906
		public new static readonly string MRClassNameKey = "class vtkCaptionRepresentation";
	}
}
