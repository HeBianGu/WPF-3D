using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLegendBoxActor
	/// </summary>
	/// <remarks>
	///    draw symbols with text
	///
	/// vtkLegendBoxActor is used to associate a symbol with a text string.
	/// The user specifies a vtkPolyData to use as the symbol, and a string
	/// associated with the symbol. The actor can then be placed in the scene
	/// in the same way that any other vtkActor2D can be used.
	///
	/// To use this class, you must define the position of the legend box by using
	/// the superclasses' vtkActor2D::Position coordinate and
	/// Position2 coordinate. Then define the set of symbols and text strings that
	/// make up the menu box. The font attributes of the entries can be set through
	/// the vtkTextProperty associated to this actor. The class will
	/// scale the symbols and text to fit in the legend box defined by
	/// (Position,Position2). Optional features like turning on a border line and
	/// setting the spacing between the border and the symbols/text can also be
	/// set.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXYPlotActor vtkActor2D vtkGlyphSource2D
	/// </seealso>
	// Token: 0x020003CE RID: 974
	public class vtkLegendBoxActor : vtkActor2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600B576 RID: 46454 RVA: 0x000FF851 File Offset: 0x000FDA51
		static vtkLegendBoxActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLegendBoxActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLegendBoxActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600B577 RID: 46455 RVA: 0x000FF879 File Offset: 0x000FDA79
		public vtkLegendBoxActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600B578 RID: 46456
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendBoxActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with a rectangle in normaled view coordinates
		/// of (0.2,0.85, 0.8, 0.95).
		/// </summary>
		// Token: 0x0600B579 RID: 46457 RVA: 0x000FF888 File Offset: 0x000FDA88
		public new static vtkLegendBoxActor New()
		{
			vtkLegendBoxActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLegendBoxActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object with a rectangle in normaled view coordinates
		/// of (0.2,0.85, 0.8, 0.95).
		/// </summary>
		// Token: 0x0600B57A RID: 46458 RVA: 0x000FF8DC File Offset: 0x000FDADC
		public vtkLegendBoxActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLegendBoxActor.vtkLegendBoxActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600B57B RID: 46459 RVA: 0x000FF920 File Offset: 0x000FDB20
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600B57C RID: 46460
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_BorderOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that controls whether a border will be drawn
		/// around the legend box.
		/// </summary>
		// Token: 0x0600B57D RID: 46461 RVA: 0x000FF92B File Offset: 0x000FDB2B
		public virtual void BorderOff()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_BorderOff_01(base.GetCppThis());
		}

		// Token: 0x0600B57E RID: 46462
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_BorderOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that controls whether a border will be drawn
		/// around the legend box.
		/// </summary>
		// Token: 0x0600B57F RID: 46463 RVA: 0x000FF93A File Offset: 0x000FDB3A
		public virtual void BorderOn()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_BorderOn_02(base.GetCppThis());
		}

		// Token: 0x0600B580 RID: 46464
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_BoxOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that controls whether a box will be drawn/filled
		/// corresponding to the legend box.
		/// </summary>
		// Token: 0x0600B581 RID: 46465 RVA: 0x000FF949 File Offset: 0x000FDB49
		public virtual void BoxOff()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_BoxOff_03(base.GetCppThis());
		}

		// Token: 0x0600B582 RID: 46466
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_BoxOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that controls whether a box will be drawn/filled
		/// corresponding to the legend box.
		/// </summary>
		// Token: 0x0600B583 RID: 46467 RVA: 0x000FF958 File Offset: 0x000FDB58
		public virtual void BoxOn()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_BoxOn_04(base.GetCppThis());
		}

		// Token: 0x0600B584 RID: 46468
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendBoxActor_GetBackgroundColor_05(HandleRef pThis);

		/// <summary>
		/// Set/Get background color.
		/// Default is: (0.3, 0.3, 0.3).
		/// </summary>
		// Token: 0x0600B585 RID: 46469 RVA: 0x000FF968 File Offset: 0x000FDB68
		public virtual double[] GetBackgroundColor()
		{
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_GetBackgroundColor_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B586 RID: 46470
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_GetBackgroundColor_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get background color.
		/// Default is: (0.3, 0.3, 0.3).
		/// </summary>
		// Token: 0x0600B587 RID: 46471 RVA: 0x000FF9B0 File Offset: 0x000FDBB0
		public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_GetBackgroundColor_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600B588 RID: 46472
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_GetBackgroundColor_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get background color.
		/// Default is: (0.3, 0.3, 0.3).
		/// </summary>
		// Token: 0x0600B589 RID: 46473 RVA: 0x000FF9C2 File Offset: 0x000FDBC2
		public virtual void GetBackgroundColor(IntPtr _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_GetBackgroundColor_07(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B58A RID: 46474
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLegendBoxActor_GetBackgroundOpacity_08(HandleRef pThis);

		/// <summary>
		/// Set/Get background opacity.
		/// Default is: 1.0
		/// </summary>
		// Token: 0x0600B58B RID: 46475 RVA: 0x000FF9D4 File Offset: 0x000FDBD4
		public virtual double GetBackgroundOpacity()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetBackgroundOpacity_08(base.GetCppThis());
		}

		// Token: 0x0600B58C RID: 46476
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLegendBoxActor_GetBackgroundOpacityMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get background opacity.
		/// Default is: 1.0
		/// </summary>
		// Token: 0x0600B58D RID: 46477 RVA: 0x000FF9F4 File Offset: 0x000FDBF4
		public virtual double GetBackgroundOpacityMaxValue()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetBackgroundOpacityMaxValue_09(base.GetCppThis());
		}

		// Token: 0x0600B58E RID: 46478
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLegendBoxActor_GetBackgroundOpacityMinValue_10(HandleRef pThis);

		/// <summary>
		/// Set/Get background opacity.
		/// Default is: 1.0
		/// </summary>
		// Token: 0x0600B58F RID: 46479 RVA: 0x000FFA14 File Offset: 0x000FDC14
		public virtual double GetBackgroundOpacityMinValue()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetBackgroundOpacityMinValue_10(base.GetCppThis());
		}

		// Token: 0x0600B590 RID: 46480
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendBoxActor_GetBorder_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that controls whether a border will be drawn
		/// around the legend box.
		/// </summary>
		// Token: 0x0600B591 RID: 46481 RVA: 0x000FFA34 File Offset: 0x000FDC34
		public virtual int GetBorder()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetBorder_11(base.GetCppThis());
		}

		// Token: 0x0600B592 RID: 46482
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendBoxActor_GetBox_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that controls whether a box will be drawn/filled
		/// corresponding to the legend box.
		/// </summary>
		// Token: 0x0600B593 RID: 46483 RVA: 0x000FFA54 File Offset: 0x000FDC54
		public virtual int GetBox()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetBox_12(base.GetCppThis());
		}

		// Token: 0x0600B594 RID: 46484
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendBoxActor_GetBoxProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the box vtkProperty2D.
		/// </summary>
		// Token: 0x0600B595 RID: 46485 RVA: 0x000FFA74 File Offset: 0x000FDC74
		public vtkProperty2D GetBoxProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_GetBoxProperty_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B596 RID: 46486
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendBoxActor_GetEntryColor_14(HandleRef pThis, int i);

		/// <summary>
		/// Add an entry to the legend box. You must supply a vtkPolyData to be
		/// used as a symbol (it can be NULL) and a text string (which also can
		/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
		/// and the text is assumed to be a single line in height. Note that when
		/// this method is invoked previous entries are deleted. Also supply a text
		/// string and optionally a color. (If a color is not specified, then the
		/// entry color is the same as this actor's color.) (Note: use the set
		/// methods when you use SetNumberOfEntries().)
		/// </summary>
		// Token: 0x0600B597 RID: 46487 RVA: 0x000FFAE4 File Offset: 0x000FDCE4
		public double[] GetEntryColor(int i)
		{
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_GetEntryColor_14(base.GetCppThis(), i);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B598 RID: 46488
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendBoxActor_GetEntryIcon_15(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Add an entry to the legend box. You must supply a vtkPolyData to be
		/// used as a symbol (it can be NULL) and a text string (which also can
		/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
		/// and the text is assumed to be a single line in height. Note that when
		/// this method is invoked previous entries are deleted. Also supply a text
		/// string and optionally a color. (If a color is not specified, then the
		/// entry color is the same as this actor's color.) (Note: use the set
		/// methods when you use SetNumberOfEntries().)
		/// </summary>
		// Token: 0x0600B599 RID: 46489 RVA: 0x000FFB30 File Offset: 0x000FDD30
		public vtkImageData GetEntryIcon(int i)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_GetEntryIcon_15(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B59A RID: 46490
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendBoxActor_GetEntryString_16(HandleRef pThis, int i);

		/// <summary>
		/// Add an entry to the legend box. You must supply a vtkPolyData to be
		/// used as a symbol (it can be NULL) and a text string (which also can
		/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
		/// and the text is assumed to be a single line in height. Note that when
		/// this method is invoked previous entries are deleted. Also supply a text
		/// string and optionally a color. (If a color is not specified, then the
		/// entry color is the same as this actor's color.) (Note: use the set
		/// methods when you use SetNumberOfEntries().)
		/// </summary>
		// Token: 0x0600B59B RID: 46491 RVA: 0x000FFBA0 File Offset: 0x000FDDA0
		public string GetEntryString(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkLegendBoxActor.vtkLegendBoxActor_GetEntryString_16(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B59C RID: 46492
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendBoxActor_GetEntrySymbol_17(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Add an entry to the legend box. You must supply a vtkPolyData to be
		/// used as a symbol (it can be NULL) and a text string (which also can
		/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
		/// and the text is assumed to be a single line in height. Note that when
		/// this method is invoked previous entries are deleted. Also supply a text
		/// string and optionally a color. (If a color is not specified, then the
		/// entry color is the same as this actor's color.) (Note: use the set
		/// methods when you use SetNumberOfEntries().)
		/// </summary>
		// Token: 0x0600B59D RID: 46493 RVA: 0x000FFBDC File Offset: 0x000FDDDC
		public vtkPolyData GetEntrySymbol(int i)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_GetEntrySymbol_17(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B59E RID: 46494
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendBoxActor_GetEntryTextProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the text property.
		/// </summary>
		// Token: 0x0600B59F RID: 46495 RVA: 0x000FFC4C File Offset: 0x000FDE4C
		public virtual vtkTextProperty GetEntryTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_GetEntryTextProperty_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B5A0 RID: 46496
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendBoxActor_GetLockBorder_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that controls whether the border and legend
		/// placement is locked into the rectangle defined by (Position,Position2).
		/// If off, then the legend box will adjust its size so that the border
		/// fits nicely around the text and symbols. (The ivar is off by default.)
		/// Note: the legend box is guaranteed to lie within the original border
		/// definition.
		/// </summary>
		// Token: 0x0600B5A1 RID: 46497 RVA: 0x000FFCBC File Offset: 0x000FDEBC
		public virtual int GetLockBorder()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetLockBorder_19(base.GetCppThis());
		}

		// Token: 0x0600B5A2 RID: 46498
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendBoxActor_GetNumberOfEntries_20(HandleRef pThis);

		/// <summary>
		/// Specify the number of entries in the legend box.
		/// </summary>
		// Token: 0x0600B5A3 RID: 46499 RVA: 0x000FFCDC File Offset: 0x000FDEDC
		public int GetNumberOfEntries()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetNumberOfEntries_20(base.GetCppThis());
		}

		// Token: 0x0600B5A4 RID: 46500
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLegendBoxActor_GetNumberOfGenerationsFromBase_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B5A5 RID: 46501 RVA: 0x000FFCFC File Offset: 0x000FDEFC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetNumberOfGenerationsFromBase_21(base.GetCppThis(), type);
		}

		// Token: 0x0600B5A6 RID: 46502
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLegendBoxActor_GetNumberOfGenerationsFromBaseType_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B5A7 RID: 46503 RVA: 0x000FFD1C File Offset: 0x000FDF1C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetNumberOfGenerationsFromBaseType_22(type);
		}

		// Token: 0x0600B5A8 RID: 46504
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendBoxActor_GetPadding_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the legend entries and the border. The value
		/// is specified in pixels.
		/// </summary>
		// Token: 0x0600B5A9 RID: 46505 RVA: 0x000FFD38 File Offset: 0x000FDF38
		public virtual int GetPadding()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetPadding_23(base.GetCppThis());
		}

		// Token: 0x0600B5AA RID: 46506
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendBoxActor_GetPaddingMaxValue_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the legend entries and the border. The value
		/// is specified in pixels.
		/// </summary>
		// Token: 0x0600B5AB RID: 46507 RVA: 0x000FFD58 File Offset: 0x000FDF58
		public virtual int GetPaddingMaxValue()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetPaddingMaxValue_24(base.GetCppThis());
		}

		// Token: 0x0600B5AC RID: 46508
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendBoxActor_GetPaddingMinValue_25(HandleRef pThis);

		/// <summary>
		/// Set/Get the padding between the legend entries and the border. The value
		/// is specified in pixels.
		/// </summary>
		// Token: 0x0600B5AD RID: 46509 RVA: 0x000FFD78 File Offset: 0x000FDF78
		public virtual int GetPaddingMinValue()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetPaddingMinValue_25(base.GetCppThis());
		}

		// Token: 0x0600B5AE RID: 46510
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendBoxActor_GetScalarVisibility_26(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether the symbol's scalar data
		/// is used to color the symbol. If off, the color of the
		/// vtkLegendBoxActor is used.
		/// </summary>
		// Token: 0x0600B5AF RID: 46511 RVA: 0x000FFD98 File Offset: 0x000FDF98
		public virtual int GetScalarVisibility()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetScalarVisibility_26(base.GetCppThis());
		}

		// Token: 0x0600B5B0 RID: 46512
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendBoxActor_GetUseBackground_27(HandleRef pThis);

		/// <summary>
		/// Turn on/off background.
		/// </summary>
		// Token: 0x0600B5B1 RID: 46513 RVA: 0x000FFDB8 File Offset: 0x000FDFB8
		public virtual int GetUseBackground()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_GetUseBackground_27(base.GetCppThis());
		}

		// Token: 0x0600B5B2 RID: 46514
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendBoxActor_HasTranslucentPolygonalGeometry_28(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600B5B3 RID: 46515 RVA: 0x000FFDD8 File Offset: 0x000FDFD8
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_HasTranslucentPolygonalGeometry_28(base.GetCppThis());
		}

		// Token: 0x0600B5B4 RID: 46516
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendBoxActor_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B5B5 RID: 46517 RVA: 0x000FFDF8 File Offset: 0x000FDFF8
		public override int IsA(string type)
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x0600B5B6 RID: 46518
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendBoxActor_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B5B7 RID: 46519 RVA: 0x000FFE18 File Offset: 0x000FE018
		public new static int IsTypeOf(string type)
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_IsTypeOf_30(type);
		}

		// Token: 0x0600B5B8 RID: 46520
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_LockBorderOff_31(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that controls whether the border and legend
		/// placement is locked into the rectangle defined by (Position,Position2).
		/// If off, then the legend box will adjust its size so that the border
		/// fits nicely around the text and symbols. (The ivar is off by default.)
		/// Note: the legend box is guaranteed to lie within the original border
		/// definition.
		/// </summary>
		// Token: 0x0600B5B9 RID: 46521 RVA: 0x000FFE32 File Offset: 0x000FE032
		public virtual void LockBorderOff()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_LockBorderOff_31(base.GetCppThis());
		}

		// Token: 0x0600B5BA RID: 46522
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_LockBorderOn_32(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that controls whether the border and legend
		/// placement is locked into the rectangle defined by (Position,Position2).
		/// If off, then the legend box will adjust its size so that the border
		/// fits nicely around the text and symbols. (The ivar is off by default.)
		/// Note: the legend box is guaranteed to lie within the original border
		/// definition.
		/// </summary>
		// Token: 0x0600B5BB RID: 46523 RVA: 0x000FFE41 File Offset: 0x000FE041
		public virtual void LockBorderOn()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_LockBorderOn_32(base.GetCppThis());
		}

		// Token: 0x0600B5BC RID: 46524
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendBoxActor_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B5BD RID: 46525 RVA: 0x000FFE50 File Offset: 0x000FE050
		public new vtkLegendBoxActor NewInstance()
		{
			vtkLegendBoxActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_NewInstance_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLegendBoxActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600B5BE RID: 46526
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_ReleaseGraphicsResources_35(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600B5BF RID: 46527 RVA: 0x000FFEAC File Offset: 0x000FE0AC
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_ReleaseGraphicsResources_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B5C0 RID: 46528
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendBoxActor_RenderOpaqueGeometry_36(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
		/// Draw the legend box to the screen.
		/// </summary>
		// Token: 0x0600B5C1 RID: 46529 RVA: 0x000FFEDC File Offset: 0x000FE0DC
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_RenderOpaqueGeometry_36(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B5C2 RID: 46530
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendBoxActor_RenderOverlay_37(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
		/// Draw the legend box to the screen.
		/// </summary>
		// Token: 0x0600B5C3 RID: 46531 RVA: 0x000FFF10 File Offset: 0x000FE110
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_RenderOverlay_37(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B5C4 RID: 46532
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLegendBoxActor_RenderTranslucentPolygonalGeometry_38(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
		/// Draw the legend box to the screen.
		/// </summary>
		// Token: 0x0600B5C5 RID: 46533 RVA: 0x000FFF44 File Offset: 0x000FE144
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkLegendBoxActor.vtkLegendBoxActor_RenderTranslucentPolygonalGeometry_38(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B5C6 RID: 46534
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLegendBoxActor_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B5C7 RID: 46535 RVA: 0x000FFF78 File Offset: 0x000FE178
		public new static vtkLegendBoxActor SafeDownCast(vtkObjectBase o)
		{
			vtkLegendBoxActor vtkLegendBoxActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLegendBoxActor.vtkLegendBoxActor_SafeDownCast_39((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLegendBoxActor = (vtkLegendBoxActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLegendBoxActor.Register(null);
				}
			}
			return vtkLegendBoxActor;
		}

		// Token: 0x0600B5C8 RID: 46536
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_ScalarVisibilityOff_40(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether the symbol's scalar data
		/// is used to color the symbol. If off, the color of the
		/// vtkLegendBoxActor is used.
		/// </summary>
		// Token: 0x0600B5C9 RID: 46537 RVA: 0x000FFFF7 File Offset: 0x000FE1F7
		public virtual void ScalarVisibilityOff()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_ScalarVisibilityOff_40(base.GetCppThis());
		}

		// Token: 0x0600B5CA RID: 46538
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_ScalarVisibilityOn_41(HandleRef pThis);

		/// <summary>
		/// Turn on/off flag to control whether the symbol's scalar data
		/// is used to color the symbol. If off, the color of the
		/// vtkLegendBoxActor is used.
		/// </summary>
		// Token: 0x0600B5CB RID: 46539 RVA: 0x00100006 File Offset: 0x000FE206
		public virtual void ScalarVisibilityOn()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_ScalarVisibilityOn_41(base.GetCppThis());
		}

		// Token: 0x0600B5CC RID: 46540
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetBackgroundColor_42(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get background color.
		/// Default is: (0.3, 0.3, 0.3).
		/// </summary>
		// Token: 0x0600B5CD RID: 46541 RVA: 0x00100015 File Offset: 0x000FE215
		public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetBackgroundColor_42(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600B5CE RID: 46542
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetBackgroundColor_43(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get background color.
		/// Default is: (0.3, 0.3, 0.3).
		/// </summary>
		// Token: 0x0600B5CF RID: 46543 RVA: 0x00100027 File Offset: 0x000FE227
		public virtual void SetBackgroundColor(IntPtr _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetBackgroundColor_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B5D0 RID: 46544
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetBackgroundOpacity_44(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get background opacity.
		/// Default is: 1.0
		/// </summary>
		// Token: 0x0600B5D1 RID: 46545 RVA: 0x00100037 File Offset: 0x000FE237
		public virtual void SetBackgroundOpacity(double _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetBackgroundOpacity_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B5D2 RID: 46546
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetBorder_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag that controls whether a border will be drawn
		/// around the legend box.
		/// </summary>
		// Token: 0x0600B5D3 RID: 46547 RVA: 0x00100047 File Offset: 0x000FE247
		public virtual void SetBorder(int _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetBorder_45(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B5D4 RID: 46548
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetBox_46(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag that controls whether a box will be drawn/filled
		/// corresponding to the legend box.
		/// </summary>
		// Token: 0x0600B5D5 RID: 46549 RVA: 0x00100057 File Offset: 0x000FE257
		public virtual void SetBox(int _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetBox_46(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B5D6 RID: 46550
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetEntry_47(HandleRef pThis, int i, HandleRef symbol, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg2, IntPtr color);

		/// <summary>
		/// Add an entry to the legend box. You must supply a vtkPolyData to be
		/// used as a symbol (it can be NULL) and a text string (which also can
		/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
		/// and the text is assumed to be a single line in height. Note that when
		/// this method is invoked previous entries are deleted. Also supply a text
		/// string and optionally a color. (If a color is not specified, then the
		/// entry color is the same as this actor's color.) (Note: use the set
		/// methods when you use SetNumberOfEntries().)
		/// </summary>
		// Token: 0x0600B5D7 RID: 46551 RVA: 0x00100068 File Offset: 0x000FE268
		public void SetEntry(int i, vtkPolyData symbol, string arg2, IntPtr color)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntry_47(base.GetCppThis(), i, (symbol == null) ? default(HandleRef) : symbol.GetCppThis(), arg2, color);
		}

		// Token: 0x0600B5D8 RID: 46552
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetEntry_48(HandleRef pThis, int i, HandleRef symbol, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg2, IntPtr color);

		/// <summary>
		/// Add an entry to the legend box. You must supply a vtkPolyData to be
		/// used as a symbol (it can be NULL) and a text string (which also can
		/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
		/// and the text is assumed to be a single line in height. Note that when
		/// this method is invoked previous entries are deleted. Also supply a text
		/// string and optionally a color. (If a color is not specified, then the
		/// entry color is the same as this actor's color.) (Note: use the set
		/// methods when you use SetNumberOfEntries().)
		/// </summary>
		// Token: 0x0600B5D9 RID: 46553 RVA: 0x0010009C File Offset: 0x000FE29C
		public void SetEntry(int i, vtkImageData symbol, string arg2, IntPtr color)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntry_48(base.GetCppThis(), i, (symbol == null) ? default(HandleRef) : symbol.GetCppThis(), arg2, color);
		}

		// Token: 0x0600B5DA RID: 46554
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetEntry_49(HandleRef pThis, int i, HandleRef symbol, HandleRef icon, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg3, IntPtr color);

		/// <summary>
		/// Add an entry to the legend box. You must supply a vtkPolyData to be
		/// used as a symbol (it can be NULL) and a text string (which also can
		/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
		/// and the text is assumed to be a single line in height. Note that when
		/// this method is invoked previous entries are deleted. Also supply a text
		/// string and optionally a color. (If a color is not specified, then the
		/// entry color is the same as this actor's color.) (Note: use the set
		/// methods when you use SetNumberOfEntries().)
		/// </summary>
		// Token: 0x0600B5DB RID: 46555 RVA: 0x001000D0 File Offset: 0x000FE2D0
		public void SetEntry(int i, vtkPolyData symbol, vtkImageData icon, string arg3, IntPtr color)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntry_49(base.GetCppThis(), i, (symbol == null) ? default(HandleRef) : symbol.GetCppThis(), (icon == null) ? default(HandleRef) : icon.GetCppThis(), arg3, color);
		}

		// Token: 0x0600B5DC RID: 46556
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetEntryColor_50(HandleRef pThis, int i, IntPtr color);

		/// <summary>
		/// Add an entry to the legend box. You must supply a vtkPolyData to be
		/// used as a symbol (it can be NULL) and a text string (which also can
		/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
		/// and the text is assumed to be a single line in height. Note that when
		/// this method is invoked previous entries are deleted. Also supply a text
		/// string and optionally a color. (If a color is not specified, then the
		/// entry color is the same as this actor's color.) (Note: use the set
		/// methods when you use SetNumberOfEntries().)
		/// </summary>
		// Token: 0x0600B5DD RID: 46557 RVA: 0x00100119 File Offset: 0x000FE319
		public void SetEntryColor(int i, IntPtr color)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntryColor_50(base.GetCppThis(), i, color);
		}

		// Token: 0x0600B5DE RID: 46558
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetEntryColor_51(HandleRef pThis, int i, double r, double g, double b);

		/// <summary>
		/// Add an entry to the legend box. You must supply a vtkPolyData to be
		/// used as a symbol (it can be NULL) and a text string (which also can
		/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
		/// and the text is assumed to be a single line in height. Note that when
		/// this method is invoked previous entries are deleted. Also supply a text
		/// string and optionally a color. (If a color is not specified, then the
		/// entry color is the same as this actor's color.) (Note: use the set
		/// methods when you use SetNumberOfEntries().)
		/// </summary>
		// Token: 0x0600B5DF RID: 46559 RVA: 0x0010012A File Offset: 0x000FE32A
		public void SetEntryColor(int i, double r, double g, double b)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntryColor_51(base.GetCppThis(), i, r, g, b);
		}

		// Token: 0x0600B5E0 RID: 46560
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetEntryIcon_52(HandleRef pThis, int i, HandleRef icon);

		/// <summary>
		/// Add an entry to the legend box. You must supply a vtkPolyData to be
		/// used as a symbol (it can be NULL) and a text string (which also can
		/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
		/// and the text is assumed to be a single line in height. Note that when
		/// this method is invoked previous entries are deleted. Also supply a text
		/// string and optionally a color. (If a color is not specified, then the
		/// entry color is the same as this actor's color.) (Note: use the set
		/// methods when you use SetNumberOfEntries().)
		/// </summary>
		// Token: 0x0600B5E1 RID: 46561 RVA: 0x00100140 File Offset: 0x000FE340
		public void SetEntryIcon(int i, vtkImageData icon)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntryIcon_52(base.GetCppThis(), i, (icon == null) ? default(HandleRef) : icon.GetCppThis());
		}

		// Token: 0x0600B5E2 RID: 46562
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetEntryString_53(HandleRef pThis, int i, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1);

		/// <summary>
		/// Add an entry to the legend box. You must supply a vtkPolyData to be
		/// used as a symbol (it can be NULL) and a text string (which also can
		/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
		/// and the text is assumed to be a single line in height. Note that when
		/// this method is invoked previous entries are deleted. Also supply a text
		/// string and optionally a color. (If a color is not specified, then the
		/// entry color is the same as this actor's color.) (Note: use the set
		/// methods when you use SetNumberOfEntries().)
		/// </summary>
		// Token: 0x0600B5E3 RID: 46563 RVA: 0x00100170 File Offset: 0x000FE370
		public void SetEntryString(int i, string arg1)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntryString_53(base.GetCppThis(), i, arg1);
		}

		// Token: 0x0600B5E4 RID: 46564
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetEntrySymbol_54(HandleRef pThis, int i, HandleRef symbol);

		/// <summary>
		/// Add an entry to the legend box. You must supply a vtkPolyData to be
		/// used as a symbol (it can be NULL) and a text string (which also can
		/// be NULL). The vtkPolyData is assumed to be defined in the x-y plane,
		/// and the text is assumed to be a single line in height. Note that when
		/// this method is invoked previous entries are deleted. Also supply a text
		/// string and optionally a color. (If a color is not specified, then the
		/// entry color is the same as this actor's color.) (Note: use the set
		/// methods when you use SetNumberOfEntries().)
		/// </summary>
		// Token: 0x0600B5E5 RID: 46565 RVA: 0x00100184 File Offset: 0x000FE384
		public void SetEntrySymbol(int i, vtkPolyData symbol)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntrySymbol_54(base.GetCppThis(), i, (symbol == null) ? default(HandleRef) : symbol.GetCppThis());
		}

		// Token: 0x0600B5E6 RID: 46566
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetEntryTextProperty_55(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the text property.
		/// </summary>
		// Token: 0x0600B5E7 RID: 46567 RVA: 0x001001B4 File Offset: 0x000FE3B4
		public virtual void SetEntryTextProperty(vtkTextProperty p)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetEntryTextProperty_55(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B5E8 RID: 46568
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetLockBorder_56(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag that controls whether the border and legend
		/// placement is locked into the rectangle defined by (Position,Position2).
		/// If off, then the legend box will adjust its size so that the border
		/// fits nicely around the text and symbols. (The ivar is off by default.)
		/// Note: the legend box is guaranteed to lie within the original border
		/// definition.
		/// </summary>
		// Token: 0x0600B5E9 RID: 46569 RVA: 0x001001E3 File Offset: 0x000FE3E3
		public virtual void SetLockBorder(int _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetLockBorder_56(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B5EA RID: 46570
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetNumberOfEntries_57(HandleRef pThis, int num);

		/// <summary>
		/// Specify the number of entries in the legend box.
		/// </summary>
		// Token: 0x0600B5EB RID: 46571 RVA: 0x001001F3 File Offset: 0x000FE3F3
		public void SetNumberOfEntries(int num)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetNumberOfEntries_57(base.GetCppThis(), num);
		}

		// Token: 0x0600B5EC RID: 46572
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetPadding_58(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the padding between the legend entries and the border. The value
		/// is specified in pixels.
		/// </summary>
		// Token: 0x0600B5ED RID: 46573 RVA: 0x00100203 File Offset: 0x000FE403
		public virtual void SetPadding(int _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetPadding_58(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B5EE RID: 46574
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetScalarVisibility_59(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off flag to control whether the symbol's scalar data
		/// is used to color the symbol. If off, the color of the
		/// vtkLegendBoxActor is used.
		/// </summary>
		// Token: 0x0600B5EF RID: 46575 RVA: 0x00100213 File Offset: 0x000FE413
		public virtual void SetScalarVisibility(int _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetScalarVisibility_59(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B5F0 RID: 46576
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_SetUseBackground_60(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off background.
		/// </summary>
		// Token: 0x0600B5F1 RID: 46577 RVA: 0x00100223 File Offset: 0x000FE423
		public virtual void SetUseBackground(int _arg)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_SetUseBackground_60(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B5F2 RID: 46578
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_ShallowCopy_61(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of this scaled text actor. Overloads the virtual
		/// vtkProp method.
		/// </summary>
		// Token: 0x0600B5F3 RID: 46579 RVA: 0x00100234 File Offset: 0x000FE434
		public override void ShallowCopy(vtkProp prop)
		{
			vtkLegendBoxActor.vtkLegendBoxActor_ShallowCopy_61(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x0600B5F4 RID: 46580
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_UseBackgroundOff_62(HandleRef pThis);

		/// <summary>
		/// Turn on/off background.
		/// </summary>
		// Token: 0x0600B5F5 RID: 46581 RVA: 0x00100263 File Offset: 0x000FE463
		public virtual void UseBackgroundOff()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_UseBackgroundOff_62(base.GetCppThis());
		}

		// Token: 0x0600B5F6 RID: 46582
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLegendBoxActor_UseBackgroundOn_63(HandleRef pThis);

		/// <summary>
		/// Turn on/off background.
		/// </summary>
		// Token: 0x0600B5F7 RID: 46583 RVA: 0x00100272 File Offset: 0x000FE472
		public virtual void UseBackgroundOn()
		{
			vtkLegendBoxActor.vtkLegendBoxActor_UseBackgroundOn_63(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DF6 RID: 3574
		public new const string MRFullTypeName = "Kitware.VTK.vtkLegendBoxActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DF7 RID: 3575
		public new static readonly string MRClassNameKey = "class vtkLegendBoxActor";
	}
}
