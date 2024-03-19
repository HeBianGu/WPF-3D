using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBarChartActor
	/// </summary>
	/// <remarks>
	///    create a bar chart from an array
	///
	/// vtkBarChartActor generates a bar chart from an array of numbers defined in
	/// field data (a vtkDataObject). To use this class, you must specify an input
	/// data object. You'll probably also want to specify the position of the plot
	/// be setting the Position and Position2 instance variables, which define a
	/// rectangle in which the plot lies.  There are also many other instance
	/// variables that control the look of the plot includes its title and legend.
	///
	/// Set the text property/attributes of the title and the labels through the
	/// vtkTextProperty objects associated with these components.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkParallelCoordinatesActor vtkXYPlotActor vtkSpiderPlotActor
	/// vtkPieChartActor
	/// </seealso>
	// Token: 0x020003BE RID: 958
	public class vtkBarChartActor : vtkActor2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600B0B8 RID: 45240 RVA: 0x000F9E53 File Offset: 0x000F8053
		static vtkBarChartActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBarChartActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBarChartActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600B0B9 RID: 45241 RVA: 0x000F9E7B File Offset: 0x000F807B
		public vtkBarChartActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600B0BA RID: 45242
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBarChartActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600B0BB RID: 45243 RVA: 0x000F9E8C File Offset: 0x000F808C
		public new static vtkBarChartActor New()
		{
			vtkBarChartActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBarChartActor.vtkBarChartActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBarChartActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600B0BC RID: 45244 RVA: 0x000F9EE0 File Offset: 0x000F80E0
		public vtkBarChartActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBarChartActor.vtkBarChartActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600B0BD RID: 45245 RVA: 0x000F9F24 File Offset: 0x000F8124
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600B0BE RID: 45246
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBarChartActor_GetBarColor_01(HandleRef pThis, int i);

		/// <summary>
		/// Specify colors for each bar. If not specified, they are
		/// automatically generated.
		/// </summary>
		// Token: 0x0600B0BF RID: 45247 RVA: 0x000F9F30 File Offset: 0x000F8130
		public IntPtr GetBarColor(int i)
		{
			return vtkBarChartActor.vtkBarChartActor_GetBarColor_01(base.GetCppThis(), i);
		}

		// Token: 0x0600B0C0 RID: 45248
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBarChartActor_GetBarLabel_02(HandleRef pThis, int i);

		/// <summary>
		/// Specify the names of each bar. If
		/// not specified, then an integer number is automatically generated.
		/// </summary>
		// Token: 0x0600B0C1 RID: 45249 RVA: 0x000F9F50 File Offset: 0x000F8150
		public string GetBarLabel(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkBarChartActor.vtkBarChartActor_GetBarLabel_02(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B0C2 RID: 45250
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBarChartActor_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input data object to this actor.
		/// </summary>
		// Token: 0x0600B0C3 RID: 45251 RVA: 0x000F9F8C File Offset: 0x000F818C
		public virtual vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBarChartActor.vtkBarChartActor_GetInput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0600B0C4 RID: 45252
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBarChartActor_GetLabelTextProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the labels text property. This controls the appearance
		/// of all bar bar labels.
		/// </summary>
		// Token: 0x0600B0C5 RID: 45253 RVA: 0x000F9FFC File Offset: 0x000F81FC
		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBarChartActor.vtkBarChartActor_GetLabelTextProperty_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B0C6 RID: 45254
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBarChartActor_GetLabelVisibility_05(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the display of bar labels.
		/// </summary>
		// Token: 0x0600B0C7 RID: 45255 RVA: 0x000FA06C File Offset: 0x000F826C
		public virtual int GetLabelVisibility()
		{
			return vtkBarChartActor.vtkBarChartActor_GetLabelVisibility_05(base.GetCppThis());
		}

		// Token: 0x0600B0C8 RID: 45256
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBarChartActor_GetLegendActor_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve handles to the legend box. This is useful if you would like
		/// to manually control the legend appearance.
		/// </summary>
		// Token: 0x0600B0C9 RID: 45257 RVA: 0x000FA08C File Offset: 0x000F828C
		public virtual vtkLegendBoxActor GetLegendActor()
		{
			vtkLegendBoxActor vtkLegendBoxActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBarChartActor.vtkBarChartActor_GetLegendActor_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B0CA RID: 45258
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBarChartActor_GetLegendVisibility_07(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the creation of a legend. If on, the legend labels will
		/// be created automatically unless the per plot legend symbol has been
		/// set.
		/// </summary>
		// Token: 0x0600B0CB RID: 45259 RVA: 0x000FA0FC File Offset: 0x000F82FC
		public virtual int GetLegendVisibility()
		{
			return vtkBarChartActor.vtkBarChartActor_GetLegendVisibility_07(base.GetCppThis());
		}

		// Token: 0x0600B0CC RID: 45260
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBarChartActor_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600B0CD RID: 45261 RVA: 0x000FA11C File Offset: 0x000F831C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBarChartActor.vtkBarChartActor_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600B0CE RID: 45262
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBarChartActor_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600B0CF RID: 45263 RVA: 0x000FA13C File Offset: 0x000F833C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBarChartActor.vtkBarChartActor_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600B0D0 RID: 45264
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBarChartActor_GetTitle_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the title of the bar chart.
		/// </summary>
		// Token: 0x0600B0D1 RID: 45265 RVA: 0x000FA158 File Offset: 0x000F8358
		public virtual string GetTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkBarChartActor.vtkBarChartActor_GetTitle_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B0D2 RID: 45266
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBarChartActor_GetTitleTextProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the title text property. The property controls the
		/// appearance of the plot title.
		/// </summary>
		// Token: 0x0600B0D3 RID: 45267 RVA: 0x000FA194 File Offset: 0x000F8394
		public virtual vtkTextProperty GetTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBarChartActor.vtkBarChartActor_GetTitleTextProperty_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B0D4 RID: 45268
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBarChartActor_GetTitleVisibility_12(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the display of a plot title.
		/// </summary>
		// Token: 0x0600B0D5 RID: 45269 RVA: 0x000FA204 File Offset: 0x000F8404
		public virtual int GetTitleVisibility()
		{
			return vtkBarChartActor.vtkBarChartActor_GetTitleVisibility_12(base.GetCppThis());
		}

		// Token: 0x0600B0D6 RID: 45270
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBarChartActor_GetYTitle_13(HandleRef pThis);

		/// <summary>
		/// Specify the title of the y-axis.
		/// </summary>
		// Token: 0x0600B0D7 RID: 45271 RVA: 0x000FA224 File Offset: 0x000F8424
		public virtual string GetYTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkBarChartActor.vtkBarChartActor_GetYTitle_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B0D8 RID: 45272
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBarChartActor_HasTranslucentPolygonalGeometry_14(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600B0D9 RID: 45273 RVA: 0x000FA260 File Offset: 0x000F8460
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkBarChartActor.vtkBarChartActor_HasTranslucentPolygonalGeometry_14(base.GetCppThis());
		}

		// Token: 0x0600B0DA RID: 45274
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBarChartActor_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600B0DB RID: 45275 RVA: 0x000FA280 File Offset: 0x000F8480
		public override int IsA(string type)
		{
			return vtkBarChartActor.vtkBarChartActor_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x0600B0DC RID: 45276
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBarChartActor_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600B0DD RID: 45277 RVA: 0x000FA2A0 File Offset: 0x000F84A0
		public new static int IsTypeOf(string type)
		{
			return vtkBarChartActor.vtkBarChartActor_IsTypeOf_16(type);
		}

		// Token: 0x0600B0DE RID: 45278
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_LabelVisibilityOff_17(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the display of bar labels.
		/// </summary>
		// Token: 0x0600B0DF RID: 45279 RVA: 0x000FA2BA File Offset: 0x000F84BA
		public virtual void LabelVisibilityOff()
		{
			vtkBarChartActor.vtkBarChartActor_LabelVisibilityOff_17(base.GetCppThis());
		}

		// Token: 0x0600B0E0 RID: 45280
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_LabelVisibilityOn_18(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the display of bar labels.
		/// </summary>
		// Token: 0x0600B0E1 RID: 45281 RVA: 0x000FA2C9 File Offset: 0x000F84C9
		public virtual void LabelVisibilityOn()
		{
			vtkBarChartActor.vtkBarChartActor_LabelVisibilityOn_18(base.GetCppThis());
		}

		// Token: 0x0600B0E2 RID: 45282
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_LegendVisibilityOff_19(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the creation of a legend. If on, the legend labels will
		/// be created automatically unless the per plot legend symbol has been
		/// set.
		/// </summary>
		// Token: 0x0600B0E3 RID: 45283 RVA: 0x000FA2D8 File Offset: 0x000F84D8
		public virtual void LegendVisibilityOff()
		{
			vtkBarChartActor.vtkBarChartActor_LegendVisibilityOff_19(base.GetCppThis());
		}

		// Token: 0x0600B0E4 RID: 45284
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_LegendVisibilityOn_20(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the creation of a legend. If on, the legend labels will
		/// be created automatically unless the per plot legend symbol has been
		/// set.
		/// </summary>
		// Token: 0x0600B0E5 RID: 45285 RVA: 0x000FA2E7 File Offset: 0x000F84E7
		public virtual void LegendVisibilityOn()
		{
			vtkBarChartActor.vtkBarChartActor_LegendVisibilityOn_20(base.GetCppThis());
		}

		// Token: 0x0600B0E6 RID: 45286
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBarChartActor_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600B0E7 RID: 45287 RVA: 0x000FA2F8 File Offset: 0x000F84F8
		public new vtkBarChartActor NewInstance()
		{
			vtkBarChartActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBarChartActor.vtkBarChartActor_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBarChartActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600B0E8 RID: 45288
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_ReleaseGraphicsResources_23(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600B0E9 RID: 45289 RVA: 0x000FA354 File Offset: 0x000F8554
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkBarChartActor.vtkBarChartActor_ReleaseGraphicsResources_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B0EA RID: 45290
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBarChartActor_RenderOpaqueGeometry_24(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the bar plot.
		/// </summary>
		// Token: 0x0600B0EB RID: 45291 RVA: 0x000FA384 File Offset: 0x000F8584
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkBarChartActor.vtkBarChartActor_RenderOpaqueGeometry_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B0EC RID: 45292
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBarChartActor_RenderOverlay_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the bar plot.
		/// </summary>
		// Token: 0x0600B0ED RID: 45293 RVA: 0x000FA3B8 File Offset: 0x000F85B8
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkBarChartActor.vtkBarChartActor_RenderOverlay_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B0EE RID: 45294
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBarChartActor_RenderTranslucentPolygonalGeometry_26(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the bar plot.
		/// </summary>
		// Token: 0x0600B0EF RID: 45295 RVA: 0x000FA3EC File Offset: 0x000F85EC
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkBarChartActor.vtkBarChartActor_RenderTranslucentPolygonalGeometry_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B0F0 RID: 45296
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBarChartActor_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600B0F1 RID: 45297 RVA: 0x000FA420 File Offset: 0x000F8620
		public new static vtkBarChartActor SafeDownCast(vtkObjectBase o)
		{
			vtkBarChartActor vtkBarChartActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBarChartActor.vtkBarChartActor_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBarChartActor = (vtkBarChartActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBarChartActor.Register(null);
				}
			}
			return vtkBarChartActor;
		}

		// Token: 0x0600B0F2 RID: 45298
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_SetBarColor_28(HandleRef pThis, int i, double r, double g, double b);

		/// <summary>
		/// Specify colors for each bar. If not specified, they are
		/// automatically generated.
		/// </summary>
		// Token: 0x0600B0F3 RID: 45299 RVA: 0x000FA49F File Offset: 0x000F869F
		public void SetBarColor(int i, double r, double g, double b)
		{
			vtkBarChartActor.vtkBarChartActor_SetBarColor_28(base.GetCppThis(), i, r, g, b);
		}

		// Token: 0x0600B0F4 RID: 45300
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_SetBarColor_29(HandleRef pThis, int i, IntPtr color);

		/// <summary>
		/// Specify colors for each bar. If not specified, they are
		/// automatically generated.
		/// </summary>
		// Token: 0x0600B0F5 RID: 45301 RVA: 0x000FA4B3 File Offset: 0x000F86B3
		public void SetBarColor(int i, IntPtr color)
		{
			vtkBarChartActor.vtkBarChartActor_SetBarColor_29(base.GetCppThis(), i, color);
		}

		// Token: 0x0600B0F6 RID: 45302
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_SetBarLabel_30(HandleRef pThis, int i, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1);

		/// <summary>
		/// Specify the names of each bar. If
		/// not specified, then an integer number is automatically generated.
		/// </summary>
		// Token: 0x0600B0F7 RID: 45303 RVA: 0x000FA4C4 File Offset: 0x000F86C4
		public void SetBarLabel(int i, string arg1)
		{
			vtkBarChartActor.vtkBarChartActor_SetBarLabel_30(base.GetCppThis(), i, arg1);
		}

		// Token: 0x0600B0F8 RID: 45304
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_SetInput_31(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the input to the bar chart actor.
		/// </summary>
		// Token: 0x0600B0F9 RID: 45305 RVA: 0x000FA4D8 File Offset: 0x000F86D8
		public virtual void SetInput(vtkDataObject arg0)
		{
			vtkBarChartActor.vtkBarChartActor_SetInput_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B0FA RID: 45306
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_SetLabelTextProperty_32(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the labels text property. This controls the appearance
		/// of all bar bar labels.
		/// </summary>
		// Token: 0x0600B0FB RID: 45307 RVA: 0x000FA508 File Offset: 0x000F8708
		public virtual void SetLabelTextProperty(vtkTextProperty p)
		{
			vtkBarChartActor.vtkBarChartActor_SetLabelTextProperty_32(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B0FC RID: 45308
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_SetLabelVisibility_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/Disable the display of bar labels.
		/// </summary>
		// Token: 0x0600B0FD RID: 45309 RVA: 0x000FA537 File Offset: 0x000F8737
		public virtual void SetLabelVisibility(int _arg)
		{
			vtkBarChartActor.vtkBarChartActor_SetLabelVisibility_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B0FE RID: 45310
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_SetLegendVisibility_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/Disable the creation of a legend. If on, the legend labels will
		/// be created automatically unless the per plot legend symbol has been
		/// set.
		/// </summary>
		// Token: 0x0600B0FF RID: 45311 RVA: 0x000FA547 File Offset: 0x000F8747
		public virtual void SetLegendVisibility(int _arg)
		{
			vtkBarChartActor.vtkBarChartActor_SetLegendVisibility_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B100 RID: 45312
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_SetTitle_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the title of the bar chart.
		/// </summary>
		// Token: 0x0600B101 RID: 45313 RVA: 0x000FA557 File Offset: 0x000F8757
		public virtual void SetTitle(string _arg)
		{
			vtkBarChartActor.vtkBarChartActor_SetTitle_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B102 RID: 45314
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_SetTitleTextProperty_36(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the title text property. The property controls the
		/// appearance of the plot title.
		/// </summary>
		// Token: 0x0600B103 RID: 45315 RVA: 0x000FA568 File Offset: 0x000F8768
		public virtual void SetTitleTextProperty(vtkTextProperty p)
		{
			vtkBarChartActor.vtkBarChartActor_SetTitleTextProperty_36(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B104 RID: 45316
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_SetTitleVisibility_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/Disable the display of a plot title.
		/// </summary>
		// Token: 0x0600B105 RID: 45317 RVA: 0x000FA597 File Offset: 0x000F8797
		public virtual void SetTitleVisibility(int _arg)
		{
			vtkBarChartActor.vtkBarChartActor_SetTitleVisibility_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B106 RID: 45318
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_SetYTitle_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the title of the y-axis.
		/// </summary>
		// Token: 0x0600B107 RID: 45319 RVA: 0x000FA5A7 File Offset: 0x000F87A7
		public virtual void SetYTitle(string _arg)
		{
			vtkBarChartActor.vtkBarChartActor_SetYTitle_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B108 RID: 45320
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_TitleVisibilityOff_39(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the display of a plot title.
		/// </summary>
		// Token: 0x0600B109 RID: 45321 RVA: 0x000FA5B7 File Offset: 0x000F87B7
		public virtual void TitleVisibilityOff()
		{
			vtkBarChartActor.vtkBarChartActor_TitleVisibilityOff_39(base.GetCppThis());
		}

		// Token: 0x0600B10A RID: 45322
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBarChartActor_TitleVisibilityOn_40(HandleRef pThis);

		/// <summary>
		/// Enable/Disable the display of a plot title.
		/// </summary>
		// Token: 0x0600B10B RID: 45323 RVA: 0x000FA5C6 File Offset: 0x000F87C6
		public virtual void TitleVisibilityOn()
		{
			vtkBarChartActor.vtkBarChartActor_TitleVisibilityOn_40(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DBF RID: 3519
		public new const string MRFullTypeName = "Kitware.VTK.vtkBarChartActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DC0 RID: 3520
		public new static readonly string MRClassNameKey = "class vtkBarChartActor";
	}
}
