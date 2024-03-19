using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMagnifierRepresentation
	/// </summary>
	/// <remarks>
	///    represent a vtkBorderWidget
	///
	/// This class is used to represent and render a vtkMagnifierWidget.  To use
	/// this class, you need to specify a renderer in which to place the
	/// magnifier, and a magnification factor. Optionally, you can specify the
	/// size of the magnifier window, whether it has a border, and the particular
	/// actors to render.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMagnifierWidget
	/// </seealso>
	// Token: 0x0200033D RID: 829
	public class vtkMagnifierRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009661 RID: 38497 RVA: 0x000D5137 File Offset: 0x000D3337
		static vtkMagnifierRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMagnifierRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMagnifierRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009662 RID: 38498 RVA: 0x000D515F File Offset: 0x000D335F
		public vtkMagnifierRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009663 RID: 38499
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMagnifierRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009664 RID: 38500 RVA: 0x000D5170 File Offset: 0x000D3370
		public new static vtkMagnifierRepresentation New()
		{
			vtkMagnifierRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMagnifierRepresentation.vtkMagnifierRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMagnifierRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009665 RID: 38501 RVA: 0x000D51C4 File Offset: 0x000D33C4
		public vtkMagnifierRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMagnifierRepresentation.vtkMagnifierRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009666 RID: 38502 RVA: 0x000D5208 File Offset: 0x000D3408
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009667 RID: 38503
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierRepresentation_AddViewProp_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Optionally specify and maintain the list of view props (e.g., actors,
		/// volumes, etc).  By default, if nothing is specified, then the view props
		/// from the associated renderer are used. Note, by using view props
		/// different than that of the associated renderer, it is possible to create
		/// special effects and/or remove props from what is shown in the magnifier.
		/// </summary>
		// Token: 0x06009668 RID: 38504 RVA: 0x000D5214 File Offset: 0x000D3414
		public void AddViewProp(vtkProp arg0)
		{
			vtkMagnifierRepresentation.vtkMagnifierRepresentation_AddViewProp_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009669 RID: 38505
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierRepresentation_BorderOff_02(HandleRef pThis);

		/// <summary>
		/// Optionally specify whether a border should be drawn on the outer edge of
		/// the magnifier viewport. By default this is off.
		/// </summary>
		// Token: 0x0600966A RID: 38506 RVA: 0x000D5243 File Offset: 0x000D3443
		public virtual void BorderOff()
		{
			vtkMagnifierRepresentation.vtkMagnifierRepresentation_BorderOff_02(base.GetCppThis());
		}

		// Token: 0x0600966B RID: 38507
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierRepresentation_BorderOn_03(HandleRef pThis);

		/// <summary>
		/// Optionally specify whether a border should be drawn on the outer edge of
		/// the magnifier viewport. By default this is off.
		/// </summary>
		// Token: 0x0600966C RID: 38508 RVA: 0x000D5252 File Offset: 0x000D3452
		public virtual void BorderOn()
		{
			vtkMagnifierRepresentation.vtkMagnifierRepresentation_BorderOn_03(base.GetCppThis());
		}

		// Token: 0x0600966D RID: 38509
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierRepresentation_BuildRepresentation_04(HandleRef pThis);

		/// <summary>
		/// Subclasses should implement these methods. See the superclasses'
		/// documentation for more information.
		/// </summary>
		// Token: 0x0600966E RID: 38510 RVA: 0x000D5261 File Offset: 0x000D3461
		public override void BuildRepresentation()
		{
			vtkMagnifierRepresentation.vtkMagnifierRepresentation_BuildRepresentation_04(base.GetCppThis());
		}

		// Token: 0x0600966F RID: 38511
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMagnifierRepresentation_GetBorder_05(HandleRef pThis);

		/// <summary>
		/// Optionally specify whether a border should be drawn on the outer edge of
		/// the magnifier viewport. By default this is off.
		/// </summary>
		// Token: 0x06009670 RID: 38512 RVA: 0x000D5270 File Offset: 0x000D3470
		public virtual bool GetBorder()
		{
			return vtkMagnifierRepresentation.vtkMagnifierRepresentation_GetBorder_05(base.GetCppThis()) != 0;
		}

		// Token: 0x06009671 RID: 38513
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMagnifierRepresentation_GetBorderProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the properties of the border.
		/// </summary>
		// Token: 0x06009672 RID: 38514 RVA: 0x000D5298 File Offset: 0x000D3498
		public virtual vtkProperty2D GetBorderProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMagnifierRepresentation.vtkMagnifierRepresentation_GetBorderProperty_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009673 RID: 38515
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMagnifierRepresentation_GetInteractionStateMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Specify the interaction state of the widget. This is generally performed
		/// by the associated vtkMagnifierWidget. (It is necessary for the widget
		/// to specify the interaction state in order to remove the internal
		/// magnification renderer from the render window).
		/// </summary>
		// Token: 0x06009674 RID: 38516 RVA: 0x000D5308 File Offset: 0x000D3508
		public virtual int GetInteractionStateMaxValue()
		{
			return vtkMagnifierRepresentation.vtkMagnifierRepresentation_GetInteractionStateMaxValue_07(base.GetCppThis());
		}

		// Token: 0x06009675 RID: 38517
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMagnifierRepresentation_GetInteractionStateMinValue_08(HandleRef pThis);

		/// <summary>
		/// Specify the interaction state of the widget. This is generally performed
		/// by the associated vtkMagnifierWidget. (It is necessary for the widget
		/// to specify the interaction state in order to remove the internal
		/// magnification renderer from the render window).
		/// </summary>
		// Token: 0x06009676 RID: 38518 RVA: 0x000D5328 File Offset: 0x000D3528
		public virtual int GetInteractionStateMinValue()
		{
			return vtkMagnifierRepresentation.vtkMagnifierRepresentation_GetInteractionStateMinValue_08(base.GetCppThis());
		}

		// Token: 0x06009677 RID: 38519
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkMagnifierRepresentation_GetMTime_09(HandleRef pThis);

		/// <summary>
		/// Return the MTime of this object. It takes into account MTimes
		/// of the border's property.
		/// </summary>
		// Token: 0x06009678 RID: 38520 RVA: 0x000D5348 File Offset: 0x000D3548
		public override ulong GetMTime()
		{
			return vtkMagnifierRepresentation.vtkMagnifierRepresentation_GetMTime_09(base.GetCppThis());
		}

		// Token: 0x06009679 RID: 38521
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMagnifierRepresentation_GetMagnificationFactor_10(HandleRef pThis);

		/// <summary>
		/// Methods to control the magnification factor. The magnification factor
		/// is relative to the associated renderer's camera. The bump method
		/// enables small increments of magnification to be applied. If the bump
		/// is positive, it increases the magnification; if negative it decreases
		/// the magnification.
		/// </summary>
		// Token: 0x0600967A RID: 38522 RVA: 0x000D5368 File Offset: 0x000D3568
		public virtual double GetMagnificationFactor()
		{
			return vtkMagnifierRepresentation.vtkMagnifierRepresentation_GetMagnificationFactor_10(base.GetCppThis());
		}

		// Token: 0x0600967B RID: 38523
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMagnifierRepresentation_GetMagnificationFactorMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Methods to control the magnification factor. The magnification factor
		/// is relative to the associated renderer's camera. The bump method
		/// enables small increments of magnification to be applied. If the bump
		/// is positive, it increases the magnification; if negative it decreases
		/// the magnification.
		/// </summary>
		// Token: 0x0600967C RID: 38524 RVA: 0x000D5388 File Offset: 0x000D3588
		public virtual double GetMagnificationFactorMaxValue()
		{
			return vtkMagnifierRepresentation.vtkMagnifierRepresentation_GetMagnificationFactorMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600967D RID: 38525
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMagnifierRepresentation_GetMagnificationFactorMinValue_12(HandleRef pThis);

		/// <summary>
		/// Methods to control the magnification factor. The magnification factor
		/// is relative to the associated renderer's camera. The bump method
		/// enables small increments of magnification to be applied. If the bump
		/// is positive, it increases the magnification; if negative it decreases
		/// the magnification.
		/// </summary>
		// Token: 0x0600967E RID: 38526 RVA: 0x000D53A8 File Offset: 0x000D35A8
		public virtual double GetMagnificationFactorMinValue()
		{
			return vtkMagnifierRepresentation.vtkMagnifierRepresentation_GetMagnificationFactorMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600967F RID: 38527
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMagnifierRepresentation_GetMagnificationRenderer_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Provide access to the magnification renderer. This is so
		/// properties like background color can be set.
		/// </summary>
		// Token: 0x06009680 RID: 38528 RVA: 0x000D53C8 File Offset: 0x000D35C8
		public vtkRenderer GetMagnificationRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMagnifierRepresentation.vtkMagnifierRepresentation_GetMagnificationRenderer_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x06009681 RID: 38529
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMagnifierRepresentation_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Define standard methods.
		/// </summary>
		// Token: 0x06009682 RID: 38530 RVA: 0x000D5438 File Offset: 0x000D3638
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMagnifierRepresentation.vtkMagnifierRepresentation_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x06009683 RID: 38531
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMagnifierRepresentation_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Define standard methods.
		/// </summary>
		// Token: 0x06009684 RID: 38532 RVA: 0x000D5458 File Offset: 0x000D3658
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMagnifierRepresentation.vtkMagnifierRepresentation_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x06009685 RID: 38533
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMagnifierRepresentation_GetSize_16(HandleRef pThis);

		/// <summary>
		/// Specify the size of the magnifier viewport in pixels.
		/// </summary>
		// Token: 0x06009686 RID: 38534 RVA: 0x000D5474 File Offset: 0x000D3674
		public virtual int[] GetSize()
		{
			IntPtr intPtr = vtkMagnifierRepresentation.vtkMagnifierRepresentation_GetSize_16(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009687 RID: 38535
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierRepresentation_GetSize_17(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Specify the size of the magnifier viewport in pixels.
		/// </summary>
		// Token: 0x06009688 RID: 38536 RVA: 0x000D54BC File Offset: 0x000D36BC
		public virtual void GetSize(ref int _arg1, ref int _arg2)
		{
			vtkMagnifierRepresentation.vtkMagnifierRepresentation_GetSize_17(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06009689 RID: 38537
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierRepresentation_GetSize_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the size of the magnifier viewport in pixels.
		/// </summary>
		// Token: 0x0600968A RID: 38538 RVA: 0x000D54CD File Offset: 0x000D36CD
		public virtual void GetSize(IntPtr _arg)
		{
			vtkMagnifierRepresentation.vtkMagnifierRepresentation_GetSize_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0600968B RID: 38539
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMagnifierRepresentation_GetViewProps_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Optionally specify and maintain the list of view props (e.g., actors,
		/// volumes, etc).  By default, if nothing is specified, then the view props
		/// from the associated renderer are used. Note, by using view props
		/// different than that of the associated renderer, it is possible to create
		/// special effects and/or remove props from what is shown in the magnifier.
		/// </summary>
		// Token: 0x0600968C RID: 38540 RVA: 0x000D54E0 File Offset: 0x000D36E0
		public vtkPropCollection GetViewProps()
		{
			vtkPropCollection vtkPropCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMagnifierRepresentation.vtkMagnifierRepresentation_GetViewProps_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPropCollection = (vtkPropCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPropCollection.Register(null);
				}
			}
			return vtkPropCollection;
		}

		// Token: 0x0600968D RID: 38541
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMagnifierRepresentation_HasTranslucentPolygonalGeometry_20(HandleRef pThis);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x0600968E RID: 38542 RVA: 0x000D5550 File Offset: 0x000D3750
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkMagnifierRepresentation.vtkMagnifierRepresentation_HasTranslucentPolygonalGeometry_20(base.GetCppThis());
		}

		// Token: 0x0600968F RID: 38543
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMagnifierRepresentation_HasViewProp_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Optionally specify and maintain the list of view props (e.g., actors,
		/// volumes, etc).  By default, if nothing is specified, then the view props
		/// from the associated renderer are used. Note, by using view props
		/// different than that of the associated renderer, it is possible to create
		/// special effects and/or remove props from what is shown in the magnifier.
		/// </summary>
		// Token: 0x06009690 RID: 38544 RVA: 0x000D5570 File Offset: 0x000D3770
		public int HasViewProp(vtkProp arg0)
		{
			return vtkMagnifierRepresentation.vtkMagnifierRepresentation_HasViewProp_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009691 RID: 38545
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMagnifierRepresentation_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Define standard methods.
		/// </summary>
		// Token: 0x06009692 RID: 38546 RVA: 0x000D55A4 File Offset: 0x000D37A4
		public override int IsA(string type)
		{
			return vtkMagnifierRepresentation.vtkMagnifierRepresentation_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06009693 RID: 38547
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMagnifierRepresentation_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Define standard methods.
		/// </summary>
		// Token: 0x06009694 RID: 38548 RVA: 0x000D55C4 File Offset: 0x000D37C4
		public new static int IsTypeOf(string type)
		{
			return vtkMagnifierRepresentation.vtkMagnifierRepresentation_IsTypeOf_23(type);
		}

		// Token: 0x06009695 RID: 38549
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMagnifierRepresentation_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Define standard methods.
		/// </summary>
		// Token: 0x06009696 RID: 38550 RVA: 0x000D55E0 File Offset: 0x000D37E0
		public new vtkMagnifierRepresentation NewInstance()
		{
			vtkMagnifierRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMagnifierRepresentation.vtkMagnifierRepresentation_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMagnifierRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009697 RID: 38551
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierRepresentation_ReleaseGraphicsResources_26(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06009698 RID: 38552 RVA: 0x000D563C File Offset: 0x000D383C
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkMagnifierRepresentation.vtkMagnifierRepresentation_ReleaseGraphicsResources_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009699 RID: 38553
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierRepresentation_RemoveAllViewProps_27(HandleRef pThis);

		/// <summary>
		/// Optionally specify and maintain the list of view props (e.g., actors,
		/// volumes, etc).  By default, if nothing is specified, then the view props
		/// from the associated renderer are used. Note, by using view props
		/// different than that of the associated renderer, it is possible to create
		/// special effects and/or remove props from what is shown in the magnifier.
		/// </summary>
		// Token: 0x0600969A RID: 38554 RVA: 0x000D566B File Offset: 0x000D386B
		public void RemoveAllViewProps()
		{
			vtkMagnifierRepresentation.vtkMagnifierRepresentation_RemoveAllViewProps_27(base.GetCppThis());
		}

		// Token: 0x0600969B RID: 38555
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierRepresentation_RemoveViewProp_28(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Optionally specify and maintain the list of view props (e.g., actors,
		/// volumes, etc).  By default, if nothing is specified, then the view props
		/// from the associated renderer are used. Note, by using view props
		/// different than that of the associated renderer, it is possible to create
		/// special effects and/or remove props from what is shown in the magnifier.
		/// </summary>
		// Token: 0x0600969C RID: 38556 RVA: 0x000D567C File Offset: 0x000D387C
		public void RemoveViewProp(vtkProp arg0)
		{
			vtkMagnifierRepresentation.vtkMagnifierRepresentation_RemoveViewProp_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600969D RID: 38557
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMagnifierRepresentation_RenderOpaqueGeometry_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x0600969E RID: 38558 RVA: 0x000D56AC File Offset: 0x000D38AC
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkMagnifierRepresentation.vtkMagnifierRepresentation_RenderOpaqueGeometry_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600969F RID: 38559
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMagnifierRepresentation_RenderOverlay_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x060096A0 RID: 38560 RVA: 0x000D56E0 File Offset: 0x000D38E0
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkMagnifierRepresentation.vtkMagnifierRepresentation_RenderOverlay_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060096A1 RID: 38561
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMagnifierRepresentation_RenderTranslucentPolygonalGeometry_31(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x060096A2 RID: 38562 RVA: 0x000D5714 File Offset: 0x000D3914
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkMagnifierRepresentation.vtkMagnifierRepresentation_RenderTranslucentPolygonalGeometry_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060096A3 RID: 38563
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMagnifierRepresentation_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Define standard methods.
		/// </summary>
		// Token: 0x060096A4 RID: 38564 RVA: 0x000D5748 File Offset: 0x000D3948
		public new static vtkMagnifierRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkMagnifierRepresentation vtkMagnifierRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMagnifierRepresentation.vtkMagnifierRepresentation_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMagnifierRepresentation = (vtkMagnifierRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMagnifierRepresentation.Register(null);
				}
			}
			return vtkMagnifierRepresentation;
		}

		// Token: 0x060096A5 RID: 38565
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierRepresentation_SetBorder_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// Optionally specify whether a border should be drawn on the outer edge of
		/// the magnifier viewport. By default this is off.
		/// </summary>
		// Token: 0x060096A6 RID: 38566 RVA: 0x000D57C7 File Offset: 0x000D39C7
		public virtual void SetBorder(bool _arg)
		{
			vtkMagnifierRepresentation.vtkMagnifierRepresentation_SetBorder_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060096A7 RID: 38567
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierRepresentation_SetInteractionState_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the interaction state of the widget. This is generally performed
		/// by the associated vtkMagnifierWidget. (It is necessary for the widget
		/// to specify the interaction state in order to remove the internal
		/// magnification renderer from the render window).
		/// </summary>
		// Token: 0x060096A8 RID: 38568 RVA: 0x000D57DF File Offset: 0x000D39DF
		public virtual void SetInteractionState(int _arg)
		{
			vtkMagnifierRepresentation.vtkMagnifierRepresentation_SetInteractionState_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060096A9 RID: 38569
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierRepresentation_SetMagnificationFactor_35(HandleRef pThis, double _arg);

		/// <summary>
		/// Methods to control the magnification factor. The magnification factor
		/// is relative to the associated renderer's camera. The bump method
		/// enables small increments of magnification to be applied. If the bump
		/// is positive, it increases the magnification; if negative it decreases
		/// the magnification.
		/// </summary>
		// Token: 0x060096AA RID: 38570 RVA: 0x000D57EF File Offset: 0x000D39EF
		public virtual void SetMagnificationFactor(double _arg)
		{
			vtkMagnifierRepresentation.vtkMagnifierRepresentation_SetMagnificationFactor_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060096AB RID: 38571
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierRepresentation_SetRenderer_36(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Specify the renderer viewport in which to place the magnifier.
		/// </summary>
		// Token: 0x060096AC RID: 38572 RVA: 0x000D5800 File Offset: 0x000D3A00
		public override void SetRenderer(vtkRenderer ren)
		{
			vtkMagnifierRepresentation.vtkMagnifierRepresentation_SetRenderer_36(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x060096AD RID: 38573
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierRepresentation_SetSize_37(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Specify the size of the magnifier viewport in pixels.
		/// </summary>
		// Token: 0x060096AE RID: 38574 RVA: 0x000D582F File Offset: 0x000D3A2F
		public virtual void SetSize(int _arg1, int _arg2)
		{
			vtkMagnifierRepresentation.vtkMagnifierRepresentation_SetSize_37(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060096AF RID: 38575
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierRepresentation_SetSize_38(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the size of the magnifier viewport in pixels.
		/// </summary>
		// Token: 0x060096B0 RID: 38576 RVA: 0x000D5840 File Offset: 0x000D3A40
		public void SetSize(IntPtr _arg)
		{
			vtkMagnifierRepresentation.vtkMagnifierRepresentation_SetSize_38(base.GetCppThis(), _arg);
		}

		// Token: 0x060096B1 RID: 38577
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierRepresentation_WidgetInteraction_39(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Subclasses should implement these methods. See the superclasses'
		/// documentation for more information.
		/// </summary>
		// Token: 0x060096B2 RID: 38578 RVA: 0x000D5850 File Offset: 0x000D3A50
		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkMagnifierRepresentation.vtkMagnifierRepresentation_WidgetInteraction_39(base.GetCppThis(), eventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C56 RID: 3158
		public new const string MRFullTypeName = "Kitware.VTK.vtkMagnifierRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C57 RID: 3159
		public new static readonly string MRClassNameKey = "class vtkMagnifierRepresentation";

		/// <summary>
		/// Define the various states that the representation can be in.
		/// </summary>
		// Token: 0x0200033E RID: 830
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000C59 RID: 3161
			Invisible,
			/// <summary>enum member</summary>
			// Token: 0x04000C5A RID: 3162
			Visible
		}
	}
}
