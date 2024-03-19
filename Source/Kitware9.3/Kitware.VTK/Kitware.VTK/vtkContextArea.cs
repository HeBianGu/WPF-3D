using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContextArea
	/// </summary>
	/// <remarks>
	///    Clipped, transformed area with axes for context items.
	///
	///
	/// vtkContextArea provides an clipped drawing area surrounded by four axes.
	/// The drawing area is transformed to map the 2D area described by
	/// DrawAreaBounds into pixel coordinates. DrawAreaBounds is also used to
	/// configure the axes. Item to be rendered in the draw area should be added
	/// to the context item returned by GetDrawAreaItem().
	///
	/// The size and shape of the draw area is configured by the following member
	/// variables:
	/// - Geometry: The rect (pixel coordinates) defining the location of the context
	///   area in the scene. This includes the draw area and axis ticks/labels.
	/// - FillViewport: If true (default), Geometry is set to span the size returned
	///   by vtkContextDevice2D::GetViewportSize().
	/// - DrawAreaResizeBehavior: Controls how the draw area should be shaped.
	///   Available options: Expand (default), FixedAspect, FixedRect, FixedMargins.
	/// - FixedAspect: Aspect ratio to enforce for FixedAspect resize behavior.
	/// - FixedRect: Rect used to enforce for FixedRect resize behavior.
	/// - FixedMargins: Margins to enforce for FixedMargins resize behavior.
	/// </remarks>
	// Token: 0x0200064E RID: 1614
	public class vtkContextArea : vtkAbstractContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601179A RID: 71578 RVA: 0x00186137 File Offset: 0x00184337
		static vtkContextArea()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContextArea.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextArea"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601179B RID: 71579 RVA: 0x0018615F File Offset: 0x0018435F
		public vtkContextArea(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601179C RID: 71580
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextArea_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601179D RID: 71581 RVA: 0x00186170 File Offset: 0x00184370
		public new static vtkContextArea New()
		{
			vtkContextArea result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextArea.vtkContextArea_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextArea)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601179E RID: 71582 RVA: 0x001861C4 File Offset: 0x001843C4
		public vtkContextArea() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkContextArea.vtkContextArea_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601179F RID: 71583 RVA: 0x00186208 File Offset: 0x00184408
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060117A0 RID: 71584
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextArea_FillViewportOff_01(HandleRef pThis);

		/// <summary>
		/// If true, Geometry is set to (0, 0, vpSize[0], vpSize[1]) at the start
		/// of each Paint call. vpSize is vtkContextDevice2D::GetViewportSize. Default
		/// is true.
		/// </summary>
		// Token: 0x060117A1 RID: 71585 RVA: 0x00186213 File Offset: 0x00184413
		public virtual void FillViewportOff()
		{
			vtkContextArea.vtkContextArea_FillViewportOff_01(base.GetCppThis());
		}

		// Token: 0x060117A2 RID: 71586
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextArea_FillViewportOn_02(HandleRef pThis);

		/// <summary>
		/// If true, Geometry is set to (0, 0, vpSize[0], vpSize[1]) at the start
		/// of each Paint call. vpSize is vtkContextDevice2D::GetViewportSize. Default
		/// is true.
		/// </summary>
		// Token: 0x060117A3 RID: 71587 RVA: 0x00186222 File Offset: 0x00184422
		public virtual void FillViewportOn()
		{
			vtkContextArea.vtkContextArea_FillViewportOn_02(base.GetCppThis());
		}

		// Token: 0x060117A4 RID: 71588
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextArea_GetAxis_03(HandleRef pThis, vtkAxis.Location location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkAxis associated with the specified location.
		/// </summary>
		// Token: 0x060117A5 RID: 71589 RVA: 0x00186234 File Offset: 0x00184434
		public vtkAxis GetAxis(vtkAxis.Location location)
		{
			vtkAxis vtkAxis = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextArea.vtkContextArea_GetAxis_03(base.GetCppThis(), location, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxis = (vtkAxis)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxis.Register(null);
				}
			}
			return vtkAxis;
		}

		// Token: 0x060117A6 RID: 71590
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextArea_GetDrawAreaBounds_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The data bounds of the clipped and transformed area inside of the axes.
		/// This is used to configure the axes labels and setup the transform.
		/// </summary>
		// Token: 0x060117A7 RID: 71591 RVA: 0x001862A4 File Offset: 0x001844A4
		public virtual vtkRectd GetDrawAreaBounds()
		{
			vtkRectd result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextArea.vtkContextArea_GetDrawAreaBounds_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectd)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060117A8 RID: 71592
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextArea_GetDrawAreaItem_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the vtkAbstractContextItem that will draw in the clipped,
		/// transformed space. This is the item to add children for.
		/// </summary>
		// Token: 0x060117A9 RID: 71593 RVA: 0x00186300 File Offset: 0x00184500
		public vtkAbstractContextItem GetDrawAreaItem()
		{
			vtkAbstractContextItem vtkAbstractContextItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextArea.vtkContextArea_GetDrawAreaItem_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractContextItem = (vtkAbstractContextItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractContextItem.Register(null);
				}
			}
			return vtkAbstractContextItem;
		}

		// Token: 0x060117AA RID: 71594
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkContextArea.DrawAreaResizeBehaviorType vtkContextArea_GetDrawAreaResizeBehavior_06(HandleRef pThis);

		/// <summary>
		/// Set the resize behavior for the draw area:
		/// - @a Expand: The default behavior. The draw area will automatically resize
		/// to take up as much of @a Geometry as possible. Margin sizes are
		/// minimized based on the space required for axis labels/tick marks.
		/// - FixedAspect: Same as Expand, but a fixed aspect ratio is enforced.
		/// See SetFixedAspect.
		/// - FixedRect: Draw area is always constrained to a fixed rectangle.
		/// See SetFixedRect.
		/// - FixMargins: The draw area expands to fill @a Geometry, but margins
		/// (axis labels, etc) are fixed, rather than dynamically sized.
		/// See SetFixedMargins.
		/// </summary>
		// Token: 0x060117AB RID: 71595 RVA: 0x00186370 File Offset: 0x00184570
		public virtual vtkContextArea.DrawAreaResizeBehaviorType GetDrawAreaResizeBehavior()
		{
			return vtkContextArea.vtkContextArea_GetDrawAreaResizeBehavior_06(base.GetCppThis());
		}

		// Token: 0x060117AC RID: 71596
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContextArea_GetFillViewport_07(HandleRef pThis);

		/// <summary>
		/// If true, Geometry is set to (0, 0, vpSize[0], vpSize[1]) at the start
		/// of each Paint call. vpSize is vtkContextDevice2D::GetViewportSize. Default
		/// is true.
		/// </summary>
		// Token: 0x060117AD RID: 71597 RVA: 0x00186390 File Offset: 0x00184590
		public virtual bool GetFillViewport()
		{
			return vtkContextArea.vtkContextArea_GetFillViewport_07(base.GetCppThis()) != 0;
		}

		// Token: 0x060117AE RID: 71598
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkContextArea_GetFixedAspect_08(HandleRef pThis);

		/// <summary>
		/// The fixed aspect ratio, if DrawAreaResizeBehavior is FixedAspect.
		/// Defined as width/height. Default is 1.
		/// Setting the aspect ratio will also set DrawAreaResizeBehavior to
		/// FixedAspect.
		/// </summary>
		// Token: 0x060117AF RID: 71599 RVA: 0x001863B8 File Offset: 0x001845B8
		public virtual float GetFixedAspect()
		{
			return vtkContextArea.vtkContextArea_GetFixedAspect_08(base.GetCppThis());
		}

		// Token: 0x060117B0 RID: 71600
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextArea_GetFixedMarginsArray_09(HandleRef pThis, IntPtr margins);

		/// <summary>
		/// The left, right, bottom, and top margins for the draw area, if
		/// DrawAreaResizeBehavior is FixedMargins. Units are in pixels, default is
		/// { 0, 0, 0, 0 }.
		/// Setting the fixed margins will also set DrawAreaResizeBehavior to
		/// FixedMargins.
		/// </summary>
		// Token: 0x060117B1 RID: 71601 RVA: 0x001863D7 File Offset: 0x001845D7
		public virtual void GetFixedMarginsArray(IntPtr margins)
		{
			vtkContextArea.vtkContextArea_GetFixedMarginsArray_09(base.GetCppThis(), margins);
		}

		// Token: 0x060117B2 RID: 71602
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextArea_GetFixedMarginsArray_10(HandleRef pThis);

		/// <summary>
		/// The left, right, bottom, and top margins for the draw area, if
		/// DrawAreaResizeBehavior is FixedMargins. Units are in pixels, default is
		/// { 0, 0, 0, 0 }.
		/// Setting the fixed margins will also set DrawAreaResizeBehavior to
		/// FixedMargins.
		/// </summary>
		// Token: 0x060117B3 RID: 71603 RVA: 0x001863E8 File Offset: 0x001845E8
		public virtual IntPtr GetFixedMarginsArray()
		{
			return vtkContextArea.vtkContextArea_GetFixedMarginsArray_10(base.GetCppThis());
		}

		// Token: 0x060117B4 RID: 71604
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextArea_GetFixedRect_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The fixed rect to use for the draw area, if DrawAreaResizeBehavior is
		/// FixedRect. Units are in pixels, default is 300x300+0+0.
		/// Setting the fixed rect will also set DrawAreaResizeBehavior to
		/// FixedRect.
		/// </summary>
		// Token: 0x060117B5 RID: 71605 RVA: 0x00186408 File Offset: 0x00184608
		public virtual vtkRecti GetFixedRect()
		{
			vtkRecti result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextArea.vtkContextArea_GetFixedRect_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRecti)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060117B6 RID: 71606
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextArea_GetGeometry_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The rect defining the pixel location and size of the entire vtkContextArea,
		/// including axis labels, title, etc. Note that this will be updated to the
		/// window geometry if FillWindow is true.
		/// </summary>
		// Token: 0x060117B7 RID: 71607 RVA: 0x00186464 File Offset: 0x00184664
		public virtual vtkRecti GetGeometry()
		{
			vtkRecti result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextArea.vtkContextArea_GetGeometry_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRecti)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060117B8 RID: 71608
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextArea_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060117B9 RID: 71609 RVA: 0x001864C0 File Offset: 0x001846C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContextArea.vtkContextArea_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x060117BA RID: 71610
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextArea_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060117BB RID: 71611 RVA: 0x001864E0 File Offset: 0x001846E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContextArea.vtkContextArea_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x060117BC RID: 71612
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContextArea_GetShowGrid_15(HandleRef pThis);

		/// <summary>
		/// Turn on/off grid visibility.
		/// </summary>
		// Token: 0x060117BD RID: 71613 RVA: 0x001864FC File Offset: 0x001846FC
		public virtual bool GetShowGrid()
		{
			return vtkContextArea.vtkContextArea_GetShowGrid_15(base.GetCppThis()) != 0;
		}

		// Token: 0x060117BE RID: 71614
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextArea_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060117BF RID: 71615 RVA: 0x00186524 File Offset: 0x00184724
		public override int IsA(string type)
		{
			return vtkContextArea.vtkContextArea_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x060117C0 RID: 71616
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextArea_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060117C1 RID: 71617 RVA: 0x00186544 File Offset: 0x00184744
		public new static int IsTypeOf(string type)
		{
			return vtkContextArea.vtkContextArea_IsTypeOf_17(type);
		}

		// Token: 0x060117C2 RID: 71618
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextArea_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060117C3 RID: 71619 RVA: 0x00186560 File Offset: 0x00184760
		public new vtkContextArea NewInstance()
		{
			vtkContextArea result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextArea.vtkContextArea_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextArea)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060117C4 RID: 71620
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkContextArea_Paint_20(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the item, called whenever the item needs to be drawn.
		/// </summary>
		// Token: 0x060117C5 RID: 71621 RVA: 0x001865BC File Offset: 0x001847BC
		public override bool Paint(vtkContext2D painter)
		{
			return vtkContextArea.vtkContextArea_Paint_20(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060117C6 RID: 71622
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextArea_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060117C7 RID: 71623 RVA: 0x001865F8 File Offset: 0x001847F8
		public new static vtkContextArea SafeDownCast(vtkObjectBase o)
		{
			vtkContextArea vtkContextArea = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextArea.vtkContextArea_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextArea = (vtkContextArea)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextArea.Register(null);
				}
			}
			return vtkContextArea;
		}

		// Token: 0x060117C8 RID: 71624
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextArea_SetDrawAreaBounds_22(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// The data bounds of the clipped and transformed area inside of the axes.
		/// This is used to configure the axes labels and setup the transform.
		/// </summary>
		// Token: 0x060117C9 RID: 71625 RVA: 0x00186678 File Offset: 0x00184878
		public virtual void SetDrawAreaBounds(vtkRectd _arg)
		{
			vtkContextArea.vtkContextArea_SetDrawAreaBounds_22(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x060117CA RID: 71626
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextArea_SetDrawAreaResizeBehavior_23(HandleRef pThis, vtkContextArea.DrawAreaResizeBehaviorType _arg);

		/// <summary>
		/// Set the resize behavior for the draw area:
		/// - @a Expand: The default behavior. The draw area will automatically resize
		/// to take up as much of @a Geometry as possible. Margin sizes are
		/// minimized based on the space required for axis labels/tick marks.
		/// - FixedAspect: Same as Expand, but a fixed aspect ratio is enforced.
		/// See SetFixedAspect.
		/// - FixedRect: Draw area is always constrained to a fixed rectangle.
		/// See SetFixedRect.
		/// - FixMargins: The draw area expands to fill @a Geometry, but margins
		/// (axis labels, etc) are fixed, rather than dynamically sized.
		/// See SetFixedMargins.
		/// </summary>
		// Token: 0x060117CB RID: 71627 RVA: 0x001866A7 File Offset: 0x001848A7
		public virtual void SetDrawAreaResizeBehavior(vtkContextArea.DrawAreaResizeBehaviorType _arg)
		{
			vtkContextArea.vtkContextArea_SetDrawAreaResizeBehavior_23(base.GetCppThis(), _arg);
		}

		// Token: 0x060117CC RID: 71628
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextArea_SetFillViewport_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true, Geometry is set to (0, 0, vpSize[0], vpSize[1]) at the start
		/// of each Paint call. vpSize is vtkContextDevice2D::GetViewportSize. Default
		/// is true.
		/// </summary>
		// Token: 0x060117CD RID: 71629 RVA: 0x001866B7 File Offset: 0x001848B7
		public virtual void SetFillViewport(bool _arg)
		{
			vtkContextArea.vtkContextArea_SetFillViewport_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060117CE RID: 71630
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextArea_SetFixedAspect_25(HandleRef pThis, float aspect);

		/// <summary>
		/// The fixed aspect ratio, if DrawAreaResizeBehavior is FixedAspect.
		/// Defined as width/height. Default is 1.
		/// Setting the aspect ratio will also set DrawAreaResizeBehavior to
		/// FixedAspect.
		/// </summary>
		// Token: 0x060117CF RID: 71631 RVA: 0x001866CF File Offset: 0x001848CF
		public virtual void SetFixedAspect(float aspect)
		{
			vtkContextArea.vtkContextArea_SetFixedAspect_25(base.GetCppThis(), aspect);
		}

		// Token: 0x060117D0 RID: 71632
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextArea_SetFixedMargins_26(HandleRef pThis, IntPtr margins);

		/// <summary>
		/// The left, right, bottom, and top margins for the draw area, if
		/// DrawAreaResizeBehavior is FixedMargins. Units are in pixels, default is
		/// { 0, 0, 0, 0 }.
		/// Setting the fixed margins will also set DrawAreaResizeBehavior to
		/// FixedMargins.
		/// </summary>
		// Token: 0x060117D1 RID: 71633 RVA: 0x001866DF File Offset: 0x001848DF
		public virtual void SetFixedMargins(IntPtr margins)
		{
			vtkContextArea.vtkContextArea_SetFixedMargins_26(base.GetCppThis(), margins);
		}

		// Token: 0x060117D2 RID: 71634
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextArea_SetFixedMargins_27(HandleRef pThis, int left, int right, int bottom, int top);

		/// <summary>
		/// The left, right, bottom, and top margins for the draw area, if
		/// DrawAreaResizeBehavior is FixedMargins. Units are in pixels, default is
		/// { 0, 0, 0, 0 }.
		/// Setting the fixed margins will also set DrawAreaResizeBehavior to
		/// FixedMargins.
		/// </summary>
		// Token: 0x060117D3 RID: 71635 RVA: 0x001866EF File Offset: 0x001848EF
		public virtual void SetFixedMargins(int left, int right, int bottom, int top)
		{
			vtkContextArea.vtkContextArea_SetFixedMargins_27(base.GetCppThis(), left, right, bottom, top);
		}

		// Token: 0x060117D4 RID: 71636
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextArea_SetFixedRect_28(HandleRef pThis, HandleRef rect);

		/// <summary>
		/// The fixed rect to use for the draw area, if DrawAreaResizeBehavior is
		/// FixedRect. Units are in pixels, default is 300x300+0+0.
		/// Setting the fixed rect will also set DrawAreaResizeBehavior to
		/// FixedRect.
		/// </summary>
		// Token: 0x060117D5 RID: 71637 RVA: 0x00186704 File Offset: 0x00184904
		public virtual void SetFixedRect(vtkRecti rect)
		{
			vtkContextArea.vtkContextArea_SetFixedRect_28(base.GetCppThis(), (rect == null) ? default(HandleRef) : rect.GetCppThis());
		}

		// Token: 0x060117D6 RID: 71638
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextArea_SetFixedRect_29(HandleRef pThis, int x, int y, int width, int height);

		/// <summary>
		/// The fixed rect to use for the draw area, if DrawAreaResizeBehavior is
		/// FixedRect. Units are in pixels, default is 300x300+0+0.
		/// Setting the fixed rect will also set DrawAreaResizeBehavior to
		/// FixedRect.
		/// </summary>
		// Token: 0x060117D7 RID: 71639 RVA: 0x00186733 File Offset: 0x00184933
		public virtual void SetFixedRect(int x, int y, int width, int height)
		{
			vtkContextArea.vtkContextArea_SetFixedRect_29(base.GetCppThis(), x, y, width, height);
		}

		// Token: 0x060117D8 RID: 71640
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextArea_SetGeometry_30(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// The rect defining the pixel location and size of the entire vtkContextArea,
		/// including axis labels, title, etc. Note that this will be updated to the
		/// window geometry if FillWindow is true.
		/// </summary>
		// Token: 0x060117D9 RID: 71641 RVA: 0x00186748 File Offset: 0x00184948
		public virtual void SetGeometry(vtkRecti _arg)
		{
			vtkContextArea.vtkContextArea_SetGeometry_30(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x060117DA RID: 71642
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextArea_SetShowGrid_31(HandleRef pThis, byte show);

		/// <summary>
		/// Turn on/off grid visibility.
		/// </summary>
		// Token: 0x060117DB RID: 71643 RVA: 0x00186777 File Offset: 0x00184977
		public virtual void SetShowGrid(bool show)
		{
			vtkContextArea.vtkContextArea_SetShowGrid_31(base.GetCppThis(), show ? (byte)1 : (byte)0);
		}

		// Token: 0x060117DC RID: 71644
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextArea_ShowGridOff_32(HandleRef pThis);

		/// <summary>
		/// Turn on/off grid visibility.
		/// </summary>
		// Token: 0x060117DD RID: 71645 RVA: 0x0018678F File Offset: 0x0018498F
		public virtual void ShowGridOff()
		{
			vtkContextArea.vtkContextArea_ShowGridOff_32(base.GetCppThis());
		}

		// Token: 0x060117DE RID: 71646
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextArea_ShowGridOn_33(HandleRef pThis);

		/// <summary>
		/// Turn on/off grid visibility.
		/// </summary>
		// Token: 0x060117DF RID: 71647 RVA: 0x0018679E File Offset: 0x0018499E
		public virtual void ShowGridOn()
		{
			vtkContextArea.vtkContextArea_ShowGridOn_33(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001429 RID: 5161
		public new const string MRFullTypeName = "Kitware.VTK.vtkContextArea";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400142A RID: 5162
		public new static readonly string MRClassNameKey = "class vtkContextArea";

		/// <summary>
		/// The data bounds of the clipped and transformed area inside of the axes.
		/// This is used to configure the axes labels and setup the transform.
		/// </summary>
		// Token: 0x0200064F RID: 1615
		public enum DrawAreaResizeBehaviorType
		{
			/// <summary>enum member</summary>
			// Token: 0x0400142C RID: 5164
			DARB_Expand,
			/// <summary>enum member</summary>
			// Token: 0x0400142D RID: 5165
			DARB_FixedAspect,
			/// <summary>enum member</summary>
			// Token: 0x0400142E RID: 5166
			DARB_FixedMargins = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400142F RID: 5167
			DARB_FixedRect = 2
		}
	}
}
