using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLeaderActor2D
	/// </summary>
	/// <remarks>
	///    create a leader with optional label and arrows
	///
	/// vtkLeaderActor2D creates a leader with an optional label and arrows. (A
	/// leader is typically used to indicate distance between points.)
	/// vtkLeaderActor2D is a type of vtkActor2D; that is, it is drawn on the
	/// overlay plane and is not occluded by 3D geometry. To use this class, you
	/// typically specify two points defining the start and end points of the line
	/// (x-y definition using vtkCoordinate class), whether to place arrows on one
	/// or both end points, and whether to label the leader. Also, this class has a
	/// special feature that allows curved leaders to be created by specifying a
	/// radius.
	///
	/// Use the vtkLeaderActor2D uses its superclass vtkActor2D instance variables
	/// Position and Position2 vtkCoordinates to place an instance of
	/// vtkLeaderActor2D (i.e., these two data members represent the start and end
	/// points of the leader).  Using these vtkCoordinates you can specify the position
	/// of the leader in a variety of coordinate systems.
	///
	/// To control the appearance of the actor, use the superclasses
	/// vtkActor2D::vtkProperty2D and the vtkTextProperty objects associated with
	/// this actor.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAxisActor2D vtkActor2D vtkCoordinate vtkTextProperty
	/// </seealso>
	// Token: 0x020003CB RID: 971
	public class vtkLeaderActor2D : vtkActor2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600B4EE RID: 46318 RVA: 0x000FEF47 File Offset: 0x000FD147
		static vtkLeaderActor2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLeaderActor2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLeaderActor2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600B4EF RID: 46319 RVA: 0x000FEF6F File Offset: 0x000FD16F
		public vtkLeaderActor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600B4F0 RID: 46320
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLeaderActor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x0600B4F1 RID: 46321 RVA: 0x000FEF80 File Offset: 0x000FD180
		public new static vtkLeaderActor2D New()
		{
			vtkLeaderActor2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLeaderActor2D.vtkLeaderActor2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x0600B4F2 RID: 46322 RVA: 0x000FEFD4 File Offset: 0x000FD1D4
		public vtkLeaderActor2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLeaderActor2D.vtkLeaderActor2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600B4F3 RID: 46323 RVA: 0x000FF018 File Offset: 0x000FD218
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600B4F4 RID: 46324
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_AutoLabelOff_01(HandleRef pThis);

		/// <summary>
		/// Enable auto-labelling. In this mode, the label is automatically updated
		/// based on distance (in world coordinates) between the two end points; or
		/// if a curved leader is being generated, the angle in degrees between the
		/// two points.
		/// </summary>
		// Token: 0x0600B4F5 RID: 46325 RVA: 0x000FF023 File Offset: 0x000FD223
		public virtual void AutoLabelOff()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_AutoLabelOff_01(base.GetCppThis());
		}

		// Token: 0x0600B4F6 RID: 46326
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_AutoLabelOn_02(HandleRef pThis);

		/// <summary>
		/// Enable auto-labelling. In this mode, the label is automatically updated
		/// based on distance (in world coordinates) between the two end points; or
		/// if a curved leader is being generated, the angle in degrees between the
		/// two points.
		/// </summary>
		// Token: 0x0600B4F7 RID: 46327 RVA: 0x000FF032 File Offset: 0x000FD232
		public virtual void AutoLabelOn()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_AutoLabelOn_02(base.GetCppThis());
		}

		// Token: 0x0600B4F8 RID: 46328
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetAngle_03(HandleRef pThis);

		/// <summary>
		/// Obtain the length of the leader if the leader is not curved,
		/// otherwise obtain the angle that the leader circumscribes.
		/// </summary>
		// Token: 0x0600B4F9 RID: 46329 RVA: 0x000FF044 File Offset: 0x000FD244
		public virtual double GetAngle()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetAngle_03(base.GetCppThis());
		}

		// Token: 0x0600B4FA RID: 46330
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetArrowLength_04(HandleRef pThis);

		/// <summary>
		/// Specify the arrow length and base width (in normalized viewport
		/// coordinates).
		/// </summary>
		// Token: 0x0600B4FB RID: 46331 RVA: 0x000FF064 File Offset: 0x000FD264
		public virtual double GetArrowLength()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowLength_04(base.GetCppThis());
		}

		// Token: 0x0600B4FC RID: 46332
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetArrowLengthMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Specify the arrow length and base width (in normalized viewport
		/// coordinates).
		/// </summary>
		// Token: 0x0600B4FD RID: 46333 RVA: 0x000FF084 File Offset: 0x000FD284
		public virtual double GetArrowLengthMaxValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowLengthMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600B4FE RID: 46334
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetArrowLengthMinValue_06(HandleRef pThis);

		/// <summary>
		/// Specify the arrow length and base width (in normalized viewport
		/// coordinates).
		/// </summary>
		// Token: 0x0600B4FF RID: 46335 RVA: 0x000FF0A4 File Offset: 0x000FD2A4
		public virtual double GetArrowLengthMinValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowLengthMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600B500 RID: 46336
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLeaderActor2D_GetArrowPlacement_07(HandleRef pThis);

		/// <summary>
		/// Control whether arrow heads are drawn on the leader. Arrows may be
		/// drawn on one end, both ends, or not at all.
		/// </summary>
		// Token: 0x0600B501 RID: 46337 RVA: 0x000FF0C4 File Offset: 0x000FD2C4
		public virtual int GetArrowPlacement()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowPlacement_07(base.GetCppThis());
		}

		// Token: 0x0600B502 RID: 46338
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLeaderActor2D_GetArrowPlacementMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Control whether arrow heads are drawn on the leader. Arrows may be
		/// drawn on one end, both ends, or not at all.
		/// </summary>
		// Token: 0x0600B503 RID: 46339 RVA: 0x000FF0E4 File Offset: 0x000FD2E4
		public virtual int GetArrowPlacementMaxValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowPlacementMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0600B504 RID: 46340
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLeaderActor2D_GetArrowPlacementMinValue_09(HandleRef pThis);

		/// <summary>
		/// Control whether arrow heads are drawn on the leader. Arrows may be
		/// drawn on one end, both ends, or not at all.
		/// </summary>
		// Token: 0x0600B505 RID: 46341 RVA: 0x000FF104 File Offset: 0x000FD304
		public virtual int GetArrowPlacementMinValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowPlacementMinValue_09(base.GetCppThis());
		}

		// Token: 0x0600B506 RID: 46342
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLeaderActor2D_GetArrowStyle_10(HandleRef pThis);

		/// <summary>
		/// Control the appearance of the arrow heads. A solid arrow head is a filled
		/// triangle; a open arrow looks like a "V"; and a hollow arrow looks like a
		/// non-filled triangle.
		/// </summary>
		// Token: 0x0600B507 RID: 46343 RVA: 0x000FF124 File Offset: 0x000FD324
		public virtual int GetArrowStyle()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowStyle_10(base.GetCppThis());
		}

		// Token: 0x0600B508 RID: 46344
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLeaderActor2D_GetArrowStyleMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Control the appearance of the arrow heads. A solid arrow head is a filled
		/// triangle; a open arrow looks like a "V"; and a hollow arrow looks like a
		/// non-filled triangle.
		/// </summary>
		// Token: 0x0600B509 RID: 46345 RVA: 0x000FF144 File Offset: 0x000FD344
		public virtual int GetArrowStyleMaxValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowStyleMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600B50A RID: 46346
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLeaderActor2D_GetArrowStyleMinValue_12(HandleRef pThis);

		/// <summary>
		/// Control the appearance of the arrow heads. A solid arrow head is a filled
		/// triangle; a open arrow looks like a "V"; and a hollow arrow looks like a
		/// non-filled triangle.
		/// </summary>
		// Token: 0x0600B50B RID: 46347 RVA: 0x000FF164 File Offset: 0x000FD364
		public virtual int GetArrowStyleMinValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowStyleMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600B50C RID: 46348
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetArrowWidth_13(HandleRef pThis);

		/// <summary>
		/// Specify the arrow length and base width (in normalized viewport
		/// coordinates).
		/// </summary>
		// Token: 0x0600B50D RID: 46349 RVA: 0x000FF184 File Offset: 0x000FD384
		public virtual double GetArrowWidth()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowWidth_13(base.GetCppThis());
		}

		// Token: 0x0600B50E RID: 46350
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetArrowWidthMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Specify the arrow length and base width (in normalized viewport
		/// coordinates).
		/// </summary>
		// Token: 0x0600B50F RID: 46351 RVA: 0x000FF1A4 File Offset: 0x000FD3A4
		public virtual double GetArrowWidthMaxValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowWidthMaxValue_14(base.GetCppThis());
		}

		// Token: 0x0600B510 RID: 46352
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetArrowWidthMinValue_15(HandleRef pThis);

		/// <summary>
		/// Specify the arrow length and base width (in normalized viewport
		/// coordinates).
		/// </summary>
		// Token: 0x0600B511 RID: 46353 RVA: 0x000FF1C4 File Offset: 0x000FD3C4
		public virtual double GetArrowWidthMinValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetArrowWidthMinValue_15(base.GetCppThis());
		}

		// Token: 0x0600B512 RID: 46354
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLeaderActor2D_GetAutoLabel_16(HandleRef pThis);

		/// <summary>
		/// Enable auto-labelling. In this mode, the label is automatically updated
		/// based on distance (in world coordinates) between the two end points; or
		/// if a curved leader is being generated, the angle in degrees between the
		/// two points.
		/// </summary>
		// Token: 0x0600B513 RID: 46355 RVA: 0x000FF1E4 File Offset: 0x000FD3E4
		public virtual int GetAutoLabel()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetAutoLabel_16(base.GetCppThis());
		}

		// Token: 0x0600B514 RID: 46356
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLeaderActor2D_GetLabel_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the label for the leader. If the label is an empty string, then
		/// it will not be drawn.
		/// </summary>
		// Token: 0x0600B515 RID: 46357 RVA: 0x000FF204 File Offset: 0x000FD404
		public virtual string GetLabel()
		{
			string s = Marshal.PtrToStringAnsi(vtkLeaderActor2D.vtkLeaderActor2D_GetLabel_17(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B516 RID: 46358
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetLabelFactor_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts used
		/// to label the leader.
		/// </summary>
		// Token: 0x0600B517 RID: 46359 RVA: 0x000FF240 File Offset: 0x000FD440
		public virtual double GetLabelFactor()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetLabelFactor_18(base.GetCppThis());
		}

		// Token: 0x0600B518 RID: 46360
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetLabelFactorMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts used
		/// to label the leader.
		/// </summary>
		// Token: 0x0600B519 RID: 46361 RVA: 0x000FF260 File Offset: 0x000FD460
		public virtual double GetLabelFactorMaxValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetLabelFactorMaxValue_19(base.GetCppThis());
		}

		// Token: 0x0600B51A RID: 46362
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetLabelFactorMinValue_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts used
		/// to label the leader.
		/// </summary>
		// Token: 0x0600B51B RID: 46363 RVA: 0x000FF280 File Offset: 0x000FD480
		public virtual double GetLabelFactorMinValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetLabelFactorMinValue_20(base.GetCppThis());
		}

		// Token: 0x0600B51C RID: 46364
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLeaderActor2D_GetLabelFormat_21(HandleRef pThis);

		/// <summary>
		/// Specify the format to use for auto-labelling.
		/// </summary>
		// Token: 0x0600B51D RID: 46365 RVA: 0x000FF2A0 File Offset: 0x000FD4A0
		public virtual string GetLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkLeaderActor2D.vtkLeaderActor2D_GetLabelFormat_21(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B51E RID: 46366
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLeaderActor2D_GetLabelTextProperty_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the text property of the label.
		/// </summary>
		// Token: 0x0600B51F RID: 46367 RVA: 0x000FF2DC File Offset: 0x000FD4DC
		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLeaderActor2D.vtkLeaderActor2D_GetLabelTextProperty_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B520 RID: 46368
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetLength_23(HandleRef pThis);

		/// <summary>
		/// Obtain the length of the leader if the leader is not curved,
		/// otherwise obtain the angle that the leader circumscribes.
		/// </summary>
		// Token: 0x0600B521 RID: 46369 RVA: 0x000FF34C File Offset: 0x000FD54C
		public virtual double GetLength()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetLength_23(base.GetCppThis());
		}

		// Token: 0x0600B522 RID: 46370
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetMaximumArrowSize_24(HandleRef pThis);

		/// <summary>
		/// Limit the minimum and maximum size of the arrows. These values are
		/// expressed in pixels and clamp the minimum/maximum possible size for the
		/// width/length of the arrow head. (When clamped, the ratio between length
		/// and width is preserved.)
		/// </summary>
		// Token: 0x0600B523 RID: 46371 RVA: 0x000FF36C File Offset: 0x000FD56C
		public virtual double GetMaximumArrowSize()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetMaximumArrowSize_24(base.GetCppThis());
		}

		// Token: 0x0600B524 RID: 46372
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetMaximumArrowSizeMaxValue_25(HandleRef pThis);

		/// <summary>
		/// Limit the minimum and maximum size of the arrows. These values are
		/// expressed in pixels and clamp the minimum/maximum possible size for the
		/// width/length of the arrow head. (When clamped, the ratio between length
		/// and width is preserved.)
		/// </summary>
		// Token: 0x0600B525 RID: 46373 RVA: 0x000FF38C File Offset: 0x000FD58C
		public virtual double GetMaximumArrowSizeMaxValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetMaximumArrowSizeMaxValue_25(base.GetCppThis());
		}

		// Token: 0x0600B526 RID: 46374
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetMaximumArrowSizeMinValue_26(HandleRef pThis);

		/// <summary>
		/// Limit the minimum and maximum size of the arrows. These values are
		/// expressed in pixels and clamp the minimum/maximum possible size for the
		/// width/length of the arrow head. (When clamped, the ratio between length
		/// and width is preserved.)
		/// </summary>
		// Token: 0x0600B527 RID: 46375 RVA: 0x000FF3AC File Offset: 0x000FD5AC
		public virtual double GetMaximumArrowSizeMinValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetMaximumArrowSizeMinValue_26(base.GetCppThis());
		}

		// Token: 0x0600B528 RID: 46376
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetMinimumArrowSize_27(HandleRef pThis);

		/// <summary>
		/// Limit the minimum and maximum size of the arrows. These values are
		/// expressed in pixels and clamp the minimum/maximum possible size for the
		/// width/length of the arrow head. (When clamped, the ratio between length
		/// and width is preserved.)
		/// </summary>
		// Token: 0x0600B529 RID: 46377 RVA: 0x000FF3CC File Offset: 0x000FD5CC
		public virtual double GetMinimumArrowSize()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetMinimumArrowSize_27(base.GetCppThis());
		}

		// Token: 0x0600B52A RID: 46378
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetMinimumArrowSizeMaxValue_28(HandleRef pThis);

		/// <summary>
		/// Limit the minimum and maximum size of the arrows. These values are
		/// expressed in pixels and clamp the minimum/maximum possible size for the
		/// width/length of the arrow head. (When clamped, the ratio between length
		/// and width is preserved.)
		/// </summary>
		// Token: 0x0600B52B RID: 46379 RVA: 0x000FF3EC File Offset: 0x000FD5EC
		public virtual double GetMinimumArrowSizeMaxValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetMinimumArrowSizeMaxValue_28(base.GetCppThis());
		}

		// Token: 0x0600B52C RID: 46380
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetMinimumArrowSizeMinValue_29(HandleRef pThis);

		/// <summary>
		/// Limit the minimum and maximum size of the arrows. These values are
		/// expressed in pixels and clamp the minimum/maximum possible size for the
		/// width/length of the arrow head. (When clamped, the ratio between length
		/// and width is preserved.)
		/// </summary>
		// Token: 0x0600B52D RID: 46381 RVA: 0x000FF40C File Offset: 0x000FD60C
		public virtual double GetMinimumArrowSizeMinValue()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetMinimumArrowSizeMinValue_29(base.GetCppThis());
		}

		// Token: 0x0600B52E RID: 46382
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLeaderActor2D_GetNumberOfGenerationsFromBase_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B52F RID: 46383 RVA: 0x000FF42C File Offset: 0x000FD62C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetNumberOfGenerationsFromBase_30(base.GetCppThis(), type);
		}

		// Token: 0x0600B530 RID: 46384
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLeaderActor2D_GetNumberOfGenerationsFromBaseType_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B531 RID: 46385 RVA: 0x000FF44C File Offset: 0x000FD64C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetNumberOfGenerationsFromBaseType_31(type);
		}

		// Token: 0x0600B532 RID: 46386
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLeaderActor2D_GetRadius_32(HandleRef pThis);

		/// <summary>
		/// Set/Get a radius which can be used to curve the leader.  If a radius is
		/// specified whose absolute value is greater than one half the distance
		/// between the two points defined by the superclasses' Position and
		/// Position2 ivars, then the leader will be curved. A positive radius will
		/// produce a curve such that the center is to the right of the line from
		/// Position and Position2; a negative radius will produce a curve in the
		/// opposite sense. By default, the radius is set to zero and thus there
		/// is no curvature. Note that the radius is expresses as a multiple of
		/// the distance between (Position,Position2); this avoids issues relative
		/// to coordinate system transformations.
		/// </summary>
		// Token: 0x0600B533 RID: 46387 RVA: 0x000FF468 File Offset: 0x000FD668
		public virtual double GetRadius()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetRadius_32(base.GetCppThis());
		}

		// Token: 0x0600B534 RID: 46388
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLeaderActor2D_GetUseFontSizeFromProperty_33(HandleRef pThis);

		/// <summary>
		/// By default the LeaderActor2D controls the font size of the label. If this
		/// option is set to true, it will instead use whatever font size is set in the
		/// vtkTextProperty, allowing external control of the font size.
		/// </summary>
		// Token: 0x0600B535 RID: 46389 RVA: 0x000FF488 File Offset: 0x000FD688
		public virtual int GetUseFontSizeFromProperty()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_GetUseFontSizeFromProperty_33(base.GetCppThis());
		}

		// Token: 0x0600B536 RID: 46390
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLeaderActor2D_HasTranslucentPolygonalGeometry_34(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600B537 RID: 46391 RVA: 0x000FF4A8 File Offset: 0x000FD6A8
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_HasTranslucentPolygonalGeometry_34(base.GetCppThis());
		}

		// Token: 0x0600B538 RID: 46392
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLeaderActor2D_IsA_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B539 RID: 46393 RVA: 0x000FF4C8 File Offset: 0x000FD6C8
		public override int IsA(string type)
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_IsA_35(base.GetCppThis(), type);
		}

		// Token: 0x0600B53A RID: 46394
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLeaderActor2D_IsTypeOf_36([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B53B RID: 46395 RVA: 0x000FF4E8 File Offset: 0x000FD6E8
		public new static int IsTypeOf(string type)
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_IsTypeOf_36(type);
		}

		// Token: 0x0600B53C RID: 46396
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLeaderActor2D_NewInstance_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B53D RID: 46397 RVA: 0x000FF504 File Offset: 0x000FD704
		public new vtkLeaderActor2D NewInstance()
		{
			vtkLeaderActor2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLeaderActor2D.vtkLeaderActor2D_NewInstance_38(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600B53E RID: 46398
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_ReleaseGraphicsResources_39(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600B53F RID: 46399 RVA: 0x000FF560 File Offset: 0x000FD760
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_ReleaseGraphicsResources_39(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B540 RID: 46400
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLeaderActor2D_RenderOpaqueGeometry_40(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp and vtkActor2D superclasses.
		/// </summary>
		// Token: 0x0600B541 RID: 46401 RVA: 0x000FF590 File Offset: 0x000FD790
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_RenderOpaqueGeometry_40(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B542 RID: 46402
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLeaderActor2D_RenderOverlay_41(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp and vtkActor2D superclasses.
		/// </summary>
		// Token: 0x0600B543 RID: 46403 RVA: 0x000FF5C4 File Offset: 0x000FD7C4
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_RenderOverlay_41(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B544 RID: 46404
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLeaderActor2D_RenderTranslucentPolygonalGeometry_42(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods required by vtkProp and vtkActor2D superclasses.
		/// </summary>
		// Token: 0x0600B545 RID: 46405 RVA: 0x000FF5F8 File Offset: 0x000FD7F8
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkLeaderActor2D.vtkLeaderActor2D_RenderTranslucentPolygonalGeometry_42(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B546 RID: 46406
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLeaderActor2D_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B547 RID: 46407 RVA: 0x000FF62C File Offset: 0x000FD82C
		public new static vtkLeaderActor2D SafeDownCast(vtkObjectBase o)
		{
			vtkLeaderActor2D vtkLeaderActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLeaderActor2D.vtkLeaderActor2D_SafeDownCast_43((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLeaderActor2D = (vtkLeaderActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLeaderActor2D.Register(null);
				}
			}
			return vtkLeaderActor2D;
		}

		// Token: 0x0600B548 RID: 46408
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetArrowLength_44(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the arrow length and base width (in normalized viewport
		/// coordinates).
		/// </summary>
		// Token: 0x0600B549 RID: 46409 RVA: 0x000FF6AB File Offset: 0x000FD8AB
		public virtual void SetArrowLength(double _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowLength_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B54A RID: 46410
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetArrowPlacement_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether arrow heads are drawn on the leader. Arrows may be
		/// drawn on one end, both ends, or not at all.
		/// </summary>
		// Token: 0x0600B54B RID: 46411 RVA: 0x000FF6BB File Offset: 0x000FD8BB
		public virtual void SetArrowPlacement(int _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowPlacement_45(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B54C RID: 46412
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetArrowPlacementToBoth_46(HandleRef pThis);

		/// <summary>
		/// Control whether arrow heads are drawn on the leader. Arrows may be
		/// drawn on one end, both ends, or not at all.
		/// </summary>
		// Token: 0x0600B54D RID: 46413 RVA: 0x000FF6CB File Offset: 0x000FD8CB
		public void SetArrowPlacementToBoth()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowPlacementToBoth_46(base.GetCppThis());
		}

		// Token: 0x0600B54E RID: 46414
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetArrowPlacementToNone_47(HandleRef pThis);

		/// <summary>
		/// Control whether arrow heads are drawn on the leader. Arrows may be
		/// drawn on one end, both ends, or not at all.
		/// </summary>
		// Token: 0x0600B54F RID: 46415 RVA: 0x000FF6DA File Offset: 0x000FD8DA
		public void SetArrowPlacementToNone()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowPlacementToNone_47(base.GetCppThis());
		}

		// Token: 0x0600B550 RID: 46416
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetArrowPlacementToPoint1_48(HandleRef pThis);

		/// <summary>
		/// Control whether arrow heads are drawn on the leader. Arrows may be
		/// drawn on one end, both ends, or not at all.
		/// </summary>
		// Token: 0x0600B551 RID: 46417 RVA: 0x000FF6E9 File Offset: 0x000FD8E9
		public void SetArrowPlacementToPoint1()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowPlacementToPoint1_48(base.GetCppThis());
		}

		// Token: 0x0600B552 RID: 46418
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetArrowPlacementToPoint2_49(HandleRef pThis);

		/// <summary>
		/// Control whether arrow heads are drawn on the leader. Arrows may be
		/// drawn on one end, both ends, or not at all.
		/// </summary>
		// Token: 0x0600B553 RID: 46419 RVA: 0x000FF6F8 File Offset: 0x000FD8F8
		public void SetArrowPlacementToPoint2()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowPlacementToPoint2_49(base.GetCppThis());
		}

		// Token: 0x0600B554 RID: 46420
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetArrowStyle_50(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the appearance of the arrow heads. A solid arrow head is a filled
		/// triangle; a open arrow looks like a "V"; and a hollow arrow looks like a
		/// non-filled triangle.
		/// </summary>
		// Token: 0x0600B555 RID: 46421 RVA: 0x000FF707 File Offset: 0x000FD907
		public virtual void SetArrowStyle(int _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowStyle_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B556 RID: 46422
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetArrowStyleToFilled_51(HandleRef pThis);

		/// <summary>
		/// Control the appearance of the arrow heads. A solid arrow head is a filled
		/// triangle; a open arrow looks like a "V"; and a hollow arrow looks like a
		/// non-filled triangle.
		/// </summary>
		// Token: 0x0600B557 RID: 46423 RVA: 0x000FF717 File Offset: 0x000FD917
		public void SetArrowStyleToFilled()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowStyleToFilled_51(base.GetCppThis());
		}

		// Token: 0x0600B558 RID: 46424
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetArrowStyleToHollow_52(HandleRef pThis);

		/// <summary>
		/// Control the appearance of the arrow heads. A solid arrow head is a filled
		/// triangle; a open arrow looks like a "V"; and a hollow arrow looks like a
		/// non-filled triangle.
		/// </summary>
		// Token: 0x0600B559 RID: 46425 RVA: 0x000FF726 File Offset: 0x000FD926
		public void SetArrowStyleToHollow()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowStyleToHollow_52(base.GetCppThis());
		}

		// Token: 0x0600B55A RID: 46426
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetArrowStyleToOpen_53(HandleRef pThis);

		/// <summary>
		/// Control the appearance of the arrow heads. A solid arrow head is a filled
		/// triangle; a open arrow looks like a "V"; and a hollow arrow looks like a
		/// non-filled triangle.
		/// </summary>
		// Token: 0x0600B55B RID: 46427 RVA: 0x000FF735 File Offset: 0x000FD935
		public void SetArrowStyleToOpen()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowStyleToOpen_53(base.GetCppThis());
		}

		// Token: 0x0600B55C RID: 46428
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetArrowWidth_54(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the arrow length and base width (in normalized viewport
		/// coordinates).
		/// </summary>
		// Token: 0x0600B55D RID: 46429 RVA: 0x000FF744 File Offset: 0x000FD944
		public virtual void SetArrowWidth(double _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetArrowWidth_54(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B55E RID: 46430
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetAutoLabel_55(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable auto-labelling. In this mode, the label is automatically updated
		/// based on distance (in world coordinates) between the two end points; or
		/// if a curved leader is being generated, the angle in degrees between the
		/// two points.
		/// </summary>
		// Token: 0x0600B55F RID: 46431 RVA: 0x000FF754 File Offset: 0x000FD954
		public virtual void SetAutoLabel(int _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetAutoLabel_55(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B560 RID: 46432
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetLabel_56(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the label for the leader. If the label is an empty string, then
		/// it will not be drawn.
		/// </summary>
		// Token: 0x0600B561 RID: 46433 RVA: 0x000FF764 File Offset: 0x000FD964
		public virtual void SetLabel(string _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetLabel_56(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B562 RID: 46434
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetLabelFactor_57(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts used
		/// to label the leader.
		/// </summary>
		// Token: 0x0600B563 RID: 46435 RVA: 0x000FF774 File Offset: 0x000FD974
		public virtual void SetLabelFactor(double _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetLabelFactor_57(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B564 RID: 46436
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetLabelFormat_58(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the format to use for auto-labelling.
		/// </summary>
		// Token: 0x0600B565 RID: 46437 RVA: 0x000FF784 File Offset: 0x000FD984
		public virtual void SetLabelFormat(string _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetLabelFormat_58(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B566 RID: 46438
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetLabelTextProperty_59(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the text property of the label.
		/// </summary>
		// Token: 0x0600B567 RID: 46439 RVA: 0x000FF794 File Offset: 0x000FD994
		public virtual void SetLabelTextProperty(vtkTextProperty p)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetLabelTextProperty_59(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B568 RID: 46440
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetMaximumArrowSize_60(HandleRef pThis, double _arg);

		/// <summary>
		/// Limit the minimum and maximum size of the arrows. These values are
		/// expressed in pixels and clamp the minimum/maximum possible size for the
		/// width/length of the arrow head. (When clamped, the ratio between length
		/// and width is preserved.)
		/// </summary>
		// Token: 0x0600B569 RID: 46441 RVA: 0x000FF7C3 File Offset: 0x000FD9C3
		public virtual void SetMaximumArrowSize(double _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetMaximumArrowSize_60(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B56A RID: 46442
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetMinimumArrowSize_61(HandleRef pThis, double _arg);

		/// <summary>
		/// Limit the minimum and maximum size of the arrows. These values are
		/// expressed in pixels and clamp the minimum/maximum possible size for the
		/// width/length of the arrow head. (When clamped, the ratio between length
		/// and width is preserved.)
		/// </summary>
		// Token: 0x0600B56B RID: 46443 RVA: 0x000FF7D3 File Offset: 0x000FD9D3
		public virtual void SetMinimumArrowSize(double _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetMinimumArrowSize_61(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B56C RID: 46444
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetRadius_62(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get a radius which can be used to curve the leader.  If a radius is
		/// specified whose absolute value is greater than one half the distance
		/// between the two points defined by the superclasses' Position and
		/// Position2 ivars, then the leader will be curved. A positive radius will
		/// produce a curve such that the center is to the right of the line from
		/// Position and Position2; a negative radius will produce a curve in the
		/// opposite sense. By default, the radius is set to zero and thus there
		/// is no curvature. Note that the radius is expresses as a multiple of
		/// the distance between (Position,Position2); this avoids issues relative
		/// to coordinate system transformations.
		/// </summary>
		// Token: 0x0600B56D RID: 46445 RVA: 0x000FF7E3 File Offset: 0x000FD9E3
		public virtual void SetRadius(double _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetRadius_62(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B56E RID: 46446
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_SetUseFontSizeFromProperty_63(HandleRef pThis, int _arg);

		/// <summary>
		/// By default the LeaderActor2D controls the font size of the label. If this
		/// option is set to true, it will instead use whatever font size is set in the
		/// vtkTextProperty, allowing external control of the font size.
		/// </summary>
		// Token: 0x0600B56F RID: 46447 RVA: 0x000FF7F3 File Offset: 0x000FD9F3
		public virtual void SetUseFontSizeFromProperty(int _arg)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_SetUseFontSizeFromProperty_63(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B570 RID: 46448
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_ShallowCopy_64(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600B571 RID: 46449 RVA: 0x000FF804 File Offset: 0x000FDA04
		public override void ShallowCopy(vtkProp prop)
		{
			vtkLeaderActor2D.vtkLeaderActor2D_ShallowCopy_64(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x0600B572 RID: 46450
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_UseFontSizeFromPropertyOff_65(HandleRef pThis);

		/// <summary>
		/// By default the LeaderActor2D controls the font size of the label. If this
		/// option is set to true, it will instead use whatever font size is set in the
		/// vtkTextProperty, allowing external control of the font size.
		/// </summary>
		// Token: 0x0600B573 RID: 46451 RVA: 0x000FF833 File Offset: 0x000FDA33
		public virtual void UseFontSizeFromPropertyOff()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_UseFontSizeFromPropertyOff_65(base.GetCppThis());
		}

		// Token: 0x0600B574 RID: 46452
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLeaderActor2D_UseFontSizeFromPropertyOn_66(HandleRef pThis);

		/// <summary>
		/// By default the LeaderActor2D controls the font size of the label. If this
		/// option is set to true, it will instead use whatever font size is set in the
		/// vtkTextProperty, allowing external control of the font size.
		/// </summary>
		// Token: 0x0600B575 RID: 46453 RVA: 0x000FF842 File Offset: 0x000FDA42
		public virtual void UseFontSizeFromPropertyOn()
		{
			vtkLeaderActor2D.vtkLeaderActor2D_UseFontSizeFromPropertyOn_66(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DEB RID: 3563
		public new const string MRFullTypeName = "Kitware.VTK.vtkLeaderActor2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DEC RID: 3564
		public new static readonly string MRClassNameKey = "class vtkLeaderActor2D";

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts used
		/// to label the leader.
		/// </summary>
		// Token: 0x020003CC RID: 972
		public enum VTK_ARROW_BOTH_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000DEE RID: 3566
			VTK_ARROW_BOTH = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000DEF RID: 3567
			VTK_ARROW_NONE = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000DF0 RID: 3568
			VTK_ARROW_POINT1,
			/// <summary>enum member</summary>
			// Token: 0x04000DF1 RID: 3569
			VTK_ARROW_POINT2
		}

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts used
		/// to label the leader.
		/// </summary>
		// Token: 0x020003CD RID: 973
		public enum VTK_ARROW_FILLED_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000DF3 RID: 3571
			VTK_ARROW_FILLED,
			/// <summary>enum member</summary>
			// Token: 0x04000DF4 RID: 3572
			VTK_ARROW_HOLLOW = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000DF5 RID: 3573
			VTK_ARROW_OPEN = 1
		}
	}
}
